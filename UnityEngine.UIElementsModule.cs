/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements.Internal;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.StyleSheets.Syntax;
using UnityEngine.UIElements.UIR;
using UnityEngine.UIElements.UIR.Implementation;
using UnityEngine.Yoga;

// Image 10: UnityEngine.UIElementsModule.dll - Assembly: UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 44123-44991

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 44991
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_108 _2658253827592C8000DF6C48FD5487B674D9E695DB670A56FDEAB2B7F291523E; // 0x00 // Static value (base64): AAAEAAEABAAFAAEAAQAFAAIABQAGAAIAAgAGAAMABgAHAAMABAAIAAUACAAJAAUABQAJAAYACQAKAAYABgAKAAcACgALAAcACAAMAAkADAANAAkACQANAAoADQAOAAoACgAOAAsADgAPAAsA - Metadata: 0x0205B97C

	// Nested types
	private struct __StaticArrayInitTypeSize_108 // TypeDefIndex: 44990
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 44124
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 44125
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.UIElements
{
	internal static class AlignmentUtils // TypeDefIndex: 44126
	{
		// Methods
		internal static float RoundToPixelGrid(float v, float pixelsPerPoint, float offset = 0.02f /* Metadata: 0x0205B448 */) => default; // 0x000000018BF7EFD4-0x000000018BF7F004
		internal static float CeilToPixelGrid(float v, float pixelsPerPoint, float offset = -0.02f /* Metadata: 0x0205B44C */) => default; // 0x000000018BF7EFAC-0x000000018BF7EFD4
	}

	internal abstract class AtlasBase // TypeDefIndex: 44127
	{
		// Fields
		internal TextureRegistry textureRegistry; // 0x10
	
		// Constructors
		protected AtlasBase() {} // 0x000000018BF7F560-0x000000018BF7F5B4
	
		// Methods
		public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect) {
			atlas = default;
			atlasRect = default;
			return default;
		} // 0x000000018BF7F508-0x000000018BF7F560
		public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) {} // 0x0000000185492010-0x0000000185492020
		public virtual void Reset() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnAssignedToPanel(IPanel panel) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnRemovedFromPanel(IPanel panel) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnUpdateDynamicTextures(IPanel panel) {} // 0x0000000185492010-0x0000000185492020
		internal void InvokeAssignedToPanel(IPanel panel) {} // 0x000000018BF7F454-0x000000018BF7F468
		internal void InvokeRemovedFromPanel(IPanel panel) {} // 0x000000018B5DA940-0x000000018B5DA954
		internal void InvokeUpdateDynamicTextures(IPanel panel) {} // 0x000000018B5E7B98-0x000000018B5E7BAC
		protected static void RepaintTexturedElements(IPanel panel) {} // 0x000000018BF7F468-0x000000018BF7F4E8
		protected void SetDynamicTexture(TextureId id, Texture texture) {} // 0x000000018BF7F4E8-0x000000018BF7F508
	}

	public enum DynamicAtlasFilters // TypeDefIndex: 44128
	{
		None = 0,
		Readability = 1,
		Size = 2,
		Format = 4,
		ColorSpace = 8,
		FilterMode = 16
	}

	public delegate bool DynamicAtlasCustomFilter(Texture2D texture, ref DynamicAtlasFilters filtersToApply); // TypeDefIndex: 44129; 0x0000000181B59400-0x0000000181B59410

	internal class DynamicAtlas : AtlasBase // TypeDefIndex: 44131
	{
		// Fields
		private Dictionary<Texture, TextureInfo> m_Database; // 0x18
		private DynamicAtlasPage m_PointPage; // 0x20
		private DynamicAtlasPage m_BilinearPage; // 0x28
		private ColorSpace m_ColorSpace; // 0x30
		private List<IPanel> m_Panels; // 0x38
		private int m_MinAtlasSize; // 0x40
		private int m_MaxAtlasSize; // 0x44
		private int m_MaxSubTextureSize; // 0x48
		private DynamicAtlasFilters m_ActiveFilters; // 0x4C
		private DynamicAtlasCustomFilter m_CustomFilter; // 0x50
	
		// Properties
		internal bool isInitialized { get => default; } // 0x000000018BF865A8-0x000000018BF866CC 
		public int minAtlasSize { set {} } // 0x0000000185FE7D20-0x0000000185FE7D30
		public int maxAtlasSize { set {} } // 0x000000018BF87224-0x000000018BF8723C
		public static DynamicAtlasFilters defaultFilters { get => default; } // 0x000000018BF871C4-0x000000018BF8720C 
		public DynamicAtlasFilters activeFilters { set {} } // 0x000000018BF870AC-0x000000018BF87198
		public int maxSubTextureSize { get => default; set {} } // 0x000000018BF8FB08-0x000000018BF8FB58 0x000000018BF8FB58-0x000000018BF8FB9C
		public DynamicAtlasCustomFilter customFilter { set {} } // 0x000000018BF8FCD0-0x000000018BF8FCF8
	
		// Nested types
		private class TextureInfo : LinkedPoolItem<TextureInfo> // TypeDefIndex: 44130
		{
			// Fields
			public DynamicAtlasPage page; // 0x18
			public int counter; // 0x20
			public Allocator2D.Alloc2D alloc; // 0x28
			public RectInt rect; // 0x58
			public static readonly LinkedPool<TextureInfo> pool; // 0x00
	
			// Constructors
			public TextureInfo() {} // 0x000000018BF869F0-0x000000018BF86A78
			static TextureInfo() {} // 0x000000018BF86AE8-0x000000018BF86B88
	
			// Methods
			private static TextureInfo Create() => default; // 0x000000018BF87198-0x000000018BF871AC
			private static void Reset(TextureInfo info) {} // 0x000000018BF86974-0x000000018BF869F0
		}
	
		// Constructors
		public DynamicAtlas() {} // 0x000000018BF8FB9C-0x000000018BF8FCD0
	
		// Methods
		protected override void OnAssignedToPanel(IPanel panel) {} // 0x000000018BF86524-0x000000018BF865A8
		protected override void OnRemovedFromPanel(IPanel panel) {} // 0x000000018BF86CBC-0x000000018BF870AC
		public override void Reset() {} // 0x000000018BF86B88-0x000000018BF86CBC
		private void InitPages() {} // 0x000000018BF86A78-0x000000018BF86AE8
		private void DestroyPages() {} // 0x000000018BF866CC-0x000000018BF86828
		public override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect) {
			atlas = default;
			atlasRect = default;
			return default;
		} // 0x000000018BF86828-0x000000018BF86974
		public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) {} // 0x000000018BF8723C-0x000000018BF87254
		protected override void OnUpdateDynamicTextures(IPanel panel) {} // 0x000000018BF8720C-0x000000018BF87224
		internal static bool IsTextureFormatSupported(TextureFormat format) => default; // 0x0000000183214D00-0x0000000183214D10
		public virtual bool IsTextureValid(Texture2D texture, UnityEngine.FilterMode atlasFilterMode) => default; // 0x000000018BF871AC-0x000000018BF871C4
	}

	public class BindableElement : VisualElement, IBindable // TypeDefIndex: 44134
	{
		// Fields
		private IBinding _binding_k__BackingField; // 0x3C0
		private string _bindingPath_k__BackingField; // 0x3C8
	
		// Properties
		public IBinding binding { get; } // 0x000000018BF90098-0x000000018BF900D4 
		public string bindingPath { get; set; } // 0x000000018BF901E8-0x000000018BF90278
	
		// Nested types
		public class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits> // TypeDefIndex: 44132
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FB8430-0x0000000185FB8440
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 44133
		{
			// Fields
			private UxmlStringAttributeDescription m_PropertyPath; // 0x70
	
			// Constructors
			public UxmlTraits() {} // 0x0000000187A474B0-0x0000000187A474C4
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018BF81220-0x000000018BF8126C
		}
	
		// Constructors
		public BindableElement() {} // 0x000000018BF90110-0x000000018BF901E8
	}

	internal class ClampedDragger<T> : Clickable // TypeDefIndex: 44136
		where T : IComparable<T>
	{
		// Fields
		private Action dragging;
		private Action draggingEnded;
		private DragDirection _dragDirection_k__BackingField;
		private BaseSlider<T> _slider_k__BackingField;
		private Vector2 _startMousePosition_k__BackingField;
	
		// Properties
		public DragDirection dragDirection { get; set; }
		private BaseSlider<T> slider { get; set; }
		public Vector2 startMousePosition { get; private set; }
		public Vector2 delta { get => default; }
	
		// Events
		public event Action dragging;
		public event Action draggingEnded;
	
		// Nested types
		public enum DragDirection // TypeDefIndex: 44135
		{
			None = 0,
			LowToHigh = 1,
			HighToLow = 2,
			Free = 4
		}
	
		// Constructors
		public ClampedDragger() {} // Dummy constructor
		public ClampedDragger(BaseSlider<T> slider, Action clickHandler, Action dragHandler) {}
	
		// Methods
		protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) {}
		protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) {}
		protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition) {}
	}

	public class Clickable : PointerManipulator // TypeDefIndex: 44137
	{
		// Fields
		private Action<EventBase> clickedWithEventInfo; // 0x38
		private Action clicked; // 0x40
		private readonly long m_Delay; // 0x48
		private readonly long m_Interval; // 0x50
		private bool _active_k__BackingField; // 0x58
		private Vector2 _lastMousePosition_k__BackingField; // 0x5C
		private int m_ActivePointerId; // 0x64
		private bool m_AcceptClicksIfDisabled; // 0x68
		private IVisualElementScheduledItem m_Repeater; // 0x70
	
		// Properties
		protected bool active { get; set; } // 0x0000000181BE64B0-0x0000000181BE64C0 0x0000000181BE64C0-0x0000000181BE64D0
		public Vector2 lastMousePosition { get; private set; } // 0x0000000185FE93A0-0x0000000185FE93C0 0x0000000185FCF3F0-0x0000000185FCF400
		internal bool acceptClicksIfDisabled { get => default; set {} } // 0x0000000185FB09E0-0x0000000185FB09F0 0x000000018BF837AC-0x000000018BF837EC
		private InvokePolicy invokePolicy { get => default; } // 0x000000018BF83680-0x000000018BF8368C 
	
		// Events
		public event Action<EventBase> clickedWithEventInfo;
		public event Action clicked;
	
		// Constructors
		public Clickable() {} // Dummy constructor
		public Clickable(Action handler, long delay, long interval) {} // 0x000000018BF833F8-0x000000018BF83434
		public Clickable(Action<EventBase> handler) {} // 0x000000018BF83434-0x000000018BF834C8
		public Clickable(Action handler) {} // 0x000000018BF834C8-0x000000018BF83560
	
		// Methods
		private void OnTimer(UnityEngine.UIElements.TimerState timerState) {} // 0x000000018BF8253C-0x000000018BF825B8
		private bool IsRepeatable() => default; // 0x000000018BF81ED0-0x000000018BF81EE4
		protected override void RegisterCallbacksOnTarget() {} // 0x000000018BF829F4-0x000000018BF82EB0
		protected override void UnregisterCallbacksFromTarget() {} // 0x000000018BF82FBC-0x000000018BF833F8
		protected void OnMouseDown(MouseDownEvent evt) {} // 0x000000018BF81F50-0x000000018BF82010
		protected void OnMouseMove(MouseMoveEvent evt) {} // 0x000000018BF82010-0x000000018BF8207C
		protected void OnMouseUp(MouseUpEvent evt) {} // 0x000000018BF8207C-0x000000018BF82140
		private void OnMouseCaptureOut(MouseCaptureOutEvent evt) {} // 0x000000018BF81EE4-0x000000018BF81F50
		private void OnPointerDown(PointerDownEvent evt) {} // 0x000000018BF82230-0x000000018BF82344
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x000000018BF82344-0x000000018BF8242C
		private void OnPointerUp(PointerUpEvent evt) {} // 0x000000018BF8242C-0x000000018BF8253C
		private void OnPointerCancel(PointerCancelEvent evt) {} // 0x000000018BF82140-0x000000018BF821C0
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt) {} // 0x000000018BF821C0-0x000000018BF82230
		private bool ContainsPointer(int pointerId) => default; // 0x000000018BF81DF0-0x000000018BF81E44
		private static bool IsNotMouseEvent(int pointerId) => default; // 0x000000018BF81E84-0x000000018BF81ED0
		protected void Invoke(EventBase evt) {} // 0x000000018BF81E44-0x000000018BF81E84
		internal void SimulateSingleClick(EventBase evt, int delayMs = 100 /* Metadata: 0x0205B45A */) {} // 0x000000018BF82EB0-0x000000018BF82F94
		protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) {} // 0x000000018BF82688-0x000000018BF82888
		protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) {} // 0x000000018BF82888-0x000000018BF828F0
		protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) {} // 0x000000018BF828F0-0x000000018BF829F4
		protected virtual void ProcessCancelEvent(EventBase evt, int pointerId) {} // 0x000000018BF825B8-0x000000018BF82688
		private void _SimulateSingleClick_b__43_0() {} // 0x000000018BF82F94-0x000000018BF82FBC
	}

	internal class ClickDetector // TypeDefIndex: 44139
	{
		// Fields
		private List<ButtonClickStatus> m_ClickStatus; // 0x10
		private static int _s_DoubleClickTime_k__BackingField; // 0x00
	
		// Properties
		internal static int s_DoubleClickTime { get; set; } // 0x000000018BF81BBC-0x000000018BF81D4C 0x000000018BF81A24-0x000000018BF81B80
	
		// Nested types
		private class ButtonClickStatus // TypeDefIndex: 44138
		{
			// Fields
			public VisualElement m_Target; // 0x10
			public Vector3 m_PointerDownPosition; // 0x18
			public long m_LastPointerDownTime; // 0x28
			public int m_ClickCount; // 0x30
	
			// Constructors
			public ButtonClickStatus() {} // 0x000000018BF81D9C-0x000000018BF81DF0
	
			// Methods
			public void Reset() {} // 0x000000018BF81D4C-0x000000018BF81D9C
		}
	
		// Constructors
		public ClickDetector() {} // 0x000000018BF817D0-0x000000018BF81A24
		static ClickDetector() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void StartClickTracking(EventBase evt) {} // 0x000000018BF812A8-0x000000018BF81338
		private void SendClickEvent(EventBase evt) {} // 0x000000018BF81584-0x000000018BF817D0
		private void CancelClickTracking(EventBase evt) {} // 0x000000018BF81498-0x000000018BF81584
		public void ProcessEvent(EventBase evt) {} // 0x000000018BF81338-0x000000018BF81498
		private static bool ContainsPointer(VisualElement element, Vector2 position) => default; // 0x000000018BF81B80-0x000000018BF81BBC
		internal void Cleanup(List<VisualElement> elements) {} // 0x000000018BF8126C-0x000000018BF812A8
	}

	public abstract class ContextualMenuManager // TypeDefIndex: 44140
	{
		// Fields
		private bool _displayMenuHandledOSX_k__BackingField; // 0x10
	
		// Properties
		internal bool displayMenuHandledOSX { get; set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		protected ContextualMenuManager() {} // Dummy constructor
	
		// Methods
		public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);
		public void DisplayMenu(EventBase triggerEvent, IEventHandler target) {} // 0x000000018BF837EC-0x000000018BF83914
		protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);
	}

	public class ContextualMenuManipulator : MouseManipulator // TypeDefIndex: 44141
	{
		// Fields
		private Action<ContextualMenuPopulateEvent> m_MenuBuilder; // 0x30
	
		// Constructors
		public ContextualMenuManipulator() {} // Dummy constructor
		public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder) {} // 0x000000018BF83F94-0x000000018BF84074
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x000000018BF83AFC-0x000000018BF83D48
		protected override void UnregisterCallbacksFromTarget() {} // 0x000000018BF83D48-0x000000018BF83F94
		private void OnMouseUpDownEvent(IMouseEvent evt) {} // 0x000000018BF83A44-0x000000018BF83AAC
		private void OnMouseDownEventOSX(MouseDownEvent evt) {} // 0x000000018BF839EC-0x000000018BF83A44
		private void OnMouseUpEventOSX(MouseUpEvent evt) {} // 0x000000018BF83AAC-0x000000018BF83AFC
		private void OnKeyUpEvent(KeyUpEvent evt) {} // 0x000000018BF83990-0x000000018BF839EC
		private void DoDisplayMenu(EventBase evt) {} // 0x000000018BF83914-0x000000018BF8397C
		private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) {} // 0x000000018BF8397C-0x000000018BF83990
	}

	internal struct CountingBloomFilter // TypeDefIndex: 44143
	{
		// Fields
		private _m_Counters_e__FixedBuffer m_Counters; // 0x00
	
		// Nested types
		public struct _m_Counters_e__FixedBuffer // TypeDefIndex: 44142
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		private void AdjustSlot(uint index, bool increment) {} // 0x000000018BF84074-0x000000018BF84098
		private uint Hash1(uint hash) => default; // 0x0000000185FE93C0-0x0000000185FE93D0
		private uint Hash2(uint hash) => default; // 0x0000000185FE93D0-0x0000000185FE93E0
		private bool IsSlotEmpty(uint index) => default; // 0x000000018BF840F0-0x000000018BF840FC
		public void InsertHash(uint hash) {} // 0x000000018BF840C4-0x000000018BF840F0
		public void RemoveHash(uint hash) {} // 0x000000018BF840FC-0x000000018BF84128
		public bool ContainsHash(uint hash) => default; // 0x000000018BF84098-0x000000018BF840C4
	}

	internal class AncestorFilter // TypeDefIndex: 44144
	{
		// Fields
		private CountingBloomFilter m_CountingBloomFilter; // 0x10
		private Stack<int> m_HashStack; // 0x4010
	
		// Constructors
		public AncestorFilter() {} // 0x000000018BF7F3D4-0x000000018BF7F454
	
		// Methods
		private void AddHash(int hash) {} // 0x000000018BF7F004-0x000000018BF7F068
		public bool IsCandidate(StyleComplexSelector complexSel) => default; // 0x000000018BF7F068-0x000000018BF7F0E0
		public void PushElement(VisualElement element) {} // 0x000000018BF7F1A0-0x000000018BF7F3D4
		public void PopElement() {} // 0x000000018BF7F0E0-0x000000018BF7F1A0
	}

	public struct Cursor : IEquatable<UnityEngine.UIElements.Cursor> // TypeDefIndex: 44145
	{
		// Fields
		private Texture2D _texture_k__BackingField; // 0x00
		private Vector2 _hotspot_k__BackingField; // 0x08
		private int _defaultCursorId_k__BackingField; // 0x10
	
		// Properties
		public Texture2D texture { get; set; } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Vector2 hotspot { get; set; } // 0x0000000185FB8260-0x0000000185FB8280 0x0000000185FB6DD0-0x0000000185FB6DE0
		internal int defaultCursorId { get; set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BF84224-0x000000018BF842A8
		public bool Equals(Cursor other) => default; // 0x000000018BF842A8-0x000000018BF8436C
		public override int GetHashCode() => default; // 0x000000018BF8436C-0x000000018BF84440
		public static bool operator ==(Cursor style1, Cursor style2) => default; // 0x000000018BF844B4-0x000000018BF844E0
		public override string ToString() => default; // 0x000000018BF84440-0x000000018BF844B4
	}

	internal interface ICursorManager // TypeDefIndex: 44146
	{
		// Methods
		void SetCursor(UnityEngine.UIElements.Cursor cursor);
		void ResetCursor();
	}

	internal class CursorManager : ICursorManager // TypeDefIndex: 44147
	{
		// Fields
		private bool _isCursorOverriden_k__BackingField; // 0x10
	
		// Properties
		public bool isCursorOverriden { get; private set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public CursorManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void SetCursor(UnityEngine.UIElements.Cursor cursor) {} // 0x000000018BF84168-0x000000018BF84224
		public void ResetCursor() {} // 0x000000018BF84128-0x000000018BF84168
	}

	internal class DefaultEventSystem // TypeDefIndex: 44153
	{
		// Fields
		internal static Func<bool> IsEditorRemoteConnected; // 0x00
		private IInput m_Input; // 0x10
		private readonly string m_HorizontalAxis; // 0x18
		private readonly string m_VerticalAxis; // 0x20
		private readonly string m_SubmitButton; // 0x28
		private readonly string m_CancelButton; // 0x30
		private readonly float m_InputActionsPerSecond; // 0x38
		private readonly float m_RepeatDelay; // 0x3C
		private bool m_SendingTouchEvents; // 0x40
		private UnityEngine.Event m_Event; // 0x48
		private BaseRuntimePanel m_FocusedPanel; // 0x50
		private int m_ConsecutiveMoveCount; // 0x58
		private Vector2 m_LastMoveVector; // 0x5C
		private float m_PrevActionTime; // 0x64
	
		// Properties
		private bool isAppFocused { get => default; } // 0x000000018B561B58-0x000000018B561BA0 
		internal IInput input { get => default; } // 0x000000018BF8D9B4-0x000000018BF8D9BC 
		public BaseRuntimePanel focusedPanel { get => default; set {} } // 0x0000000183908D00-0x0000000183908D10 0x00000001813AE580-0x00000001813AE590
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 44148
		{
			Always = 0,
			IgnoreIfAppNotFocused = 1
		}
	
		internal interface IInput // TypeDefIndex: 44149
		{
			// Properties
			int touchCount { get; } // 0x000000018BF844E0-0x000000018BF845E8 
			bool mousePresent { get; } // 0x0000000181460F60-0x0000000181460F70 
	
			// Methods
			bool GetButtonDown(string button); // 0x0000000186472690-0x0000000186472698
			float GetAxisRaw(string axis); // 0x000000018BF85758-0x000000018BF8578C
			Touch GetTouch(int index); // 0x000000018BF85350-0x000000018BF85368
		}
	
		private class Input : IInput // TypeDefIndex: 44150
		{
			// Properties
			public int touchCount { get => default; } // 0x000000018BF84B60-0x000000018BF8507C 
			public bool mousePresent { get => default; }
	
			// Constructors
			public Input() {}
	
			// Methods
			public bool GetButtonDown(string button) => default; // 0x000000018BF8578C-0x000000018BF857DC
			public float GetAxisRaw(string axis) => default; // 0x000000018BF85544-0x000000018BF855A0
			public Touch GetTouch(int index) => default; // 0x000000018BF8507C-0x000000018BF85350
		}
	
		private class NoInput : IInput // TypeDefIndex: 44151
		{
			// Properties
			public int touchCount { get => default; } // 0x000000018BF84800-0x000000018BF84B60 
			public bool mousePresent { get => default; } // 0x000000018BF85368-0x000000018BF854E4 
	
			// Constructors
			public NoInput() {} // 0x000000018BF845E8-0x000000018BF84608
	
			// Methods
			public bool GetButtonDown(string button) => default; // 0x000000018BF854E4-0x000000018BF85544
			public float GetAxisRaw(string axis) => default; // 0x000000018BF84704-0x000000018BF84800
			public Touch GetTouch(int index) => default; // 0x000000018BF84608-0x000000018BF84704
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 44152
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<DefaultEventSystem, EventBase> __9__23_0; // 0x08
			public static Func<Vector3, Vector3, DefaultEventSystem, EventBase> __9__23_1; // 0x10
			public static Func<Vector3, Vector3, DefaultEventSystem, EventBase> __9__23_2; // 0x18
			public static Func<DefaultEventSystem, EventBase> __9__24_0; // 0x20
			public static Func<DefaultEventSystem, EventBase> __9__24_1; // 0x28
			public static Func<DefaultEventSystem, EventBase> __9__24_2; // 0x30
			public static Func<Vector3, Vector3, Touch, EventBase> __9__30_0; // 0x38
	
			// Constructors
			static __c() {} // 0x000000018BF85664-0x000000018BF85758
			public __c() {} // 0x000000018BF855A0-0x000000018BF85664
	
			// Methods
			internal EventBase _SendIMGUIEvents_b__23_0(DefaultEventSystem self) => default;
			internal EventBase _SendIMGUIEvents_b__23_1(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self) => default;
			internal EventBase _SendIMGUIEvents_b__23_2(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self) => default;
			internal EventBase _SendInputEvents_b__24_0(DefaultEventSystem self) => default;
			internal EventBase _SendInputEvents_b__24_1(DefaultEventSystem self) => default;
			internal EventBase _SendInputEvents_b__24_2(DefaultEventSystem self) => default; // 0x000000018BF8D9A8-0x000000018BF8D9B4
			internal EventBase _ProcessTouchEvents_b__30_0(Vector3 panelPosition, Vector3 panelDelta, Touch _touch) => default; // 0x000000018BF8D99C-0x000000018BF8D9A8
			internal bool _.cctor_b__41_0() => default; // 0x000000018AAE1FA4-0x000000018AAE1FAC
		}
	
		// Constructors
		public DefaultEventSystem() {} // 0x000000018BF8FCF8-0x000000018BF8FDF0
		static DefaultEventSystem() {} // 0x00000001814A81B0-0x00000001814A81C0
	
		// Methods
		private IInput GetDefaultInput() => default; // 0x0000000185492010-0x0000000185492020
		private bool ShouldIgnoreEventsOnAppNotFocused() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public void Update(UpdateMode updateMode = UpdateMode.Always /* Metadata: 0x0205B45C */) {} // 0x0000000185FE94D0-0x0000000185FE94F0
		private void SendIMGUIEvents() {} // 0x00000001814A81B0-0x00000001814A81C0
		private void SendInputEvents() {} // 0x0000000185492010-0x0000000185492020
		internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg) {} // 0x000000018BF90034-0x000000018BF90098
		private void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false /* Metadata: 0x0205B45D */) {} // 0x0000000185492010-0x0000000185492020
		private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel) {} // 0x000000018BF8FDF0-0x000000018BF8FE40
		private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers) => default; // 0x000000018BF8FE40-0x000000018BF8FECC
		private bool ProcessTouchEvents() => default; // 0x000000018BF8FECC-0x000000018BF8FF9C
		private Vector2 GetRawMoveVector() => default; // 0x000000018BF8FF9C-0x000000018BF8FFCC
		private bool ShouldSendMoveFromInput() => default; // 0x000000018BF8FFCC-0x000000018BF90000
		private static Vector2 GetLocalScreenPosition(UnityEngine.Event evt, out int? targetDisplay) {
			targetDisplay = default;
			return default;
		} // 0x000000018BF90000-0x000000018BF90034
	}

	internal class DisposeHelper // TypeDefIndex: 44154
	{
		// Constructors
		public DisposeHelper() {} // Dummy constructor
	
		// Methods
		public static void NotifyDisposedUsed(IDisposable disposable) {} // 0x000000018BF85AB8-0x000000018BF85B54
	}

	public class DropdownMenuEventInfo // TypeDefIndex: 44155
	{
		// Fields
		private readonly EventModifiers _modifiers_k__BackingField; // 0x10
		private readonly Vector2 _mousePosition_k__BackingField; // 0x14
		private readonly Vector2 _localMousePosition_k__BackingField; // 0x1C
		private readonly char _character_k__BackingField; // 0x24
		private readonly KeyCode _keyCode_k__BackingField; // 0x28
	
		// Constructors
		public DropdownMenuEventInfo() {} // Dummy constructor
		public DropdownMenuEventInfo(EventBase e) {} // 0x000000018BF85BDC-0x000000018BF85DE0
	}

	public abstract class DropdownMenuItem // TypeDefIndex: 44156
	{
		// Constructors
		protected DropdownMenuItem() {} // 0x0000000185492010-0x0000000185492020
	}

	public class DropdownMenuSeparator : DropdownMenuItem // TypeDefIndex: 44157
	{
		// Fields
		private readonly string _subMenuPath_k__BackingField; // 0x10
	
		// Constructors
		public DropdownMenuSeparator() {} // Dummy constructor
		public DropdownMenuSeparator(string subMenuPath) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class DropdownMenuAction : DropdownMenuItem // TypeDefIndex: 44159
	{
		// Fields
		private readonly string _name_k__BackingField; // 0x10
		private Status _status_k__BackingField; // 0x18
		private DropdownMenuEventInfo _eventInfo_k__BackingField; // 0x20
		private object _userData_k__BackingField; // 0x28
		private readonly Action<DropdownMenuAction> actionCallback; // 0x30
		private readonly Func<DropdownMenuAction, Status> actionStatusCallback; // 0x38
	
		// Properties
		private Status status { get; set; } // 0x00000001813AE9C0-0x00000001813AE9D0
		private DropdownMenuEventInfo eventInfo { get; set; } // 0x000000018646EE40-0x000000018646EE50
		private object userData { get; set; } // 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Nested types
		public enum Status // TypeDefIndex: 44158
		{
			None = 0,
			Normal = 1,
			Disabled = 2,
			Checked = 4,
			Hidden = 8
		}
	
		// Constructors
		public DropdownMenuAction() {} // Dummy constructor
		public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) {} // 0x000000018BF85B94-0x000000018BF85BDC
	
		// Methods
		public static Status AlwaysEnabled(DropdownMenuAction a) => default; // 0x0000000185FE93F0-0x0000000185FE9400
		public static Status AlwaysDisabled(DropdownMenuAction a) => default; // 0x0000000185FE93E0-0x0000000185FE93F0
		public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) {} // 0x000000018BF85B54-0x000000018BF85B94
	}

	public class DropdownMenu // TypeDefIndex: 44161
	{
		// Fields
		private List<DropdownMenuItem> m_MenuItems; // 0x10
		private DropdownMenuEventInfo m_DropdownMenuEventInfo; // 0x18
	
		// Nested types
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 44160
		{
			// Fields
			public DropdownMenuAction.Status status; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x0000000185FC7990-0x0000000185FC79A0
	
			// Methods
			internal DropdownMenuAction.Status _AppendAction_b__0(DropdownMenuAction e) => default; // 0x000000018BF85F04-0x000000018BF85FC0
		}
	
		// Constructors
		public DropdownMenu() {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
	
		// Methods
		public List<DropdownMenuItem> MenuItems() => default; // 0x000000018BF85DE0-0x000000018BF85F04
		public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData = null) {} // 0x000000018BF85FC0-0x000000018BF860C4
		public void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.Normal /* Metadata: 0x0205B465 */) {} // 0x000000018BF860C4-0x000000018BF861DC
		public void AppendSeparator(string subMenuPath = null) {} // 0x000000018BF861DC-0x000000018BF8642C
		public void InsertSeparator(string subMenuPath, int atIndex) {} // 0x000000018BF8642C-0x000000018BF864A4
		public void PrepareForDisplay(EventBase e) {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class DropdownUtility // TypeDefIndex: 44162
	{
		// Fields
		internal static Func<IGenericMenu> MakeDropdownFunc; // 0x00
	
		// Methods
		internal static IGenericMenu CreateDropdown() => default; // 0x000000018BF864A4-0x000000018BF86524
	}

	internal enum DispatchMode // TypeDefIndex: 44163
	{
		Default = 1,
		Queued = 1,
		Immediate = 2
	}

	public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate> // TypeDefIndex: 44164
	{
		// Fields
		private readonly EventDispatcher m_Dispatcher; // 0x00
	
		// Constructors
		public EventDispatcherGate(EventDispatcher d) {
			m_Dispatcher = default;
		} // 0x000000018BF872F4-0x000000018BF87370
	
		// Methods
		public void Dispose() {} // 0x000000018BF87254-0x000000018BF87274
		public bool Equals(EventDispatcherGate other) => default; // 0x000000018BF87274-0x000000018BF87284
		public override bool Equals(object obj) => default; // 0x000000018BF87284-0x000000018BF872F4
		public override int GetHashCode() => default; // 0x0000000189289CE0-0x0000000189289D04
	}

	public sealed class EventDispatcher // TypeDefIndex: 44167
	{
		// Fields
		internal ClickDetector m_ClickDetector; // 0x10
		private List<IEventDispatchingStrategy> m_DispatchingStrategies; // 0x18
		private static readonly ObjectPool<Queue<EventRecord>> k_EventQueuePool; // 0x00
		private Queue<EventRecord> m_Queue; // 0x20
		private readonly PointerDispatchState _pointerState_k__BackingField; // 0x28
		private uint m_GateCount; // 0x30
		private Stack<DispatchContext> m_DispatchContexts; // 0x38
		private static readonly IEventDispatchingStrategy[] s_EditorStrategies; // 0x08
		private bool m_Immediate; // 0x40
		private bool _processingEvents_k__BackingField; // 0x41
	
		// Properties
		internal PointerDispatchState pointerState { get; } // 0x00000001813B8590-0x00000001813B85A0 
		private bool dispatchImmediately { get => default; } // 0x000000018BF882E8-0x000000018BF882FC 
		private bool processingEvents { get; set; } // 0x0000000185FB0D90-0x0000000185FB0DA0
	
		// Nested types
		private struct EventRecord // TypeDefIndex: 44165
		{
			// Fields
			public EventBase m_Event; // 0x00
			public IPanel m_Panel; // 0x08
		}
	
		private struct DispatchContext // TypeDefIndex: 44166
		{
			// Fields
			public uint m_GateCount; // 0x00
			public Queue<EventRecord> m_Queue; // 0x08
		}
	
		// Constructors
		public EventDispatcher() {} // Dummy constructor
		private EventDispatcher(IList<IEventDispatchingStrategy> strategies) {} // 0x000000018BF88128-0x000000018BF882E8
		static EventDispatcher() {} // 0x000000018BF87E44-0x000000018BF88128
	
		// Methods
		internal static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies) => default; // 0x000000018BF8757C-0x000000018BF875DC
		internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) {} // 0x000000018BF875DC-0x000000018BF87738
		internal void CloseGate() {} // 0x0000000185FE9400-0x0000000185FE9410
		internal void OpenGate() {} // 0x000000018BF87738-0x000000018BF877A0
		private void ProcessEventQueue() {} // 0x000000018BF877A0-0x000000018BF87AC8
		private void ProcessEvent(EventBase evt, IPanel panel) {} // 0x000000018BF87AC8-0x000000018BF87E44
		private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) {} // 0x000000018BF87370-0x000000018BF8757C
	}

	public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 44168
	{
		// Fields
		private bool _focusable_k__BackingField; // 0x20
		private int _tabIndex_k__BackingField; // 0x24
		private bool m_DelegatesFocus; // 0x28
		private bool m_ExcludeFromFocusRing; // 0x29
	
		// Properties
		public abstract FocusController focusController { get; }
		public bool focusable { get; set; } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public int tabIndex { get; set; } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public bool delegatesFocus { get; set; } // 0x0000000185FE9420-0x0000000185FE9430 0x00000001813B4840-0x00000001813B4850
		internal bool excludeFromFocusRing { get; set; } // 0x0000000185FE9430-0x0000000185FE9440 0x000000018BF89AEC-0x000000018BF89BA4
		public virtual bool canGrabFocus { get; } // 0x00000001813ECBF0-0x00000001813ECC00 
	
		// Constructors
		protected Focusable() {} // 0x0000000185FE9410-0x0000000185FE9420
	
		// Methods
		public virtual void Focus() {} // 0x000000018BF898A8-0x000000018BF89940
		public virtual void Blur() {} // 0x000000018BF89864-0x000000018BF898A0
		internal void BlurImmediately() {} // 0x000000018BF89828-0x000000018BF89864
		private Focusable GetFocusDelegate() => default; // 0x000000018BF89A54-0x000000018BF89AAC
		private static Focusable GetFirstFocusableChild(VisualElement ve) => default; // 0x000000018BF89940-0x000000018BF89A54
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x000000018BF898A0-0x000000018BF898A8
		internal override void ExecuteDefaultActionDisabled(EventBase evt) {} // 0x000000018BF898A0-0x000000018BF898A8
		private void ProcessEvent(EventBase evt) {} // 0x000000018BF89AAC-0x000000018BF89AEC
	}

	public class FocusChangeDirection : IDisposable // TypeDefIndex: 44169
	{
		// Fields
		private static readonly FocusChangeDirection _unspecified_k__BackingField; // 0x00
		private static readonly FocusChangeDirection _none_k__BackingField; // 0x08
		private static readonly FocusChangeDirection _lastValue_k__BackingField; // 0x10
		private readonly int m_Value; // 0x10
	
		// Properties
		public static FocusChangeDirection unspecified { get; } // 0x000000018BF884AC-0x000000018BF884FC 
		public static FocusChangeDirection none { get; } // 0x000000018BF8845C-0x000000018BF884AC 
		protected static FocusChangeDirection lastValue { get; } // 0x000000018BF8840C-0x000000018BF8845C 
	
		// Constructors
		public FocusChangeDirection() {} // Dummy constructor
		protected FocusChangeDirection(int value) {} // 0x0000000181378230-0x0000000181378240
		static FocusChangeDirection() {} // 0x000000018BF88338-0x000000018BF8840C
	
		// Methods
		public static implicit operator int(FocusChangeDirection fcd) => default; // 0x000000018BF884FC-0x000000018BF88508
		void IDisposable.Dispose() {} // 0x000000018B71F490-0x000000018B71F4A0
		protected virtual void Dispose() {} // 0x0000000185492010-0x0000000185492020
		internal virtual void ApplyTo(FocusController focusController, Focusable f) {} // 0x000000018BF882FC-0x000000018BF88338
	}

	public interface IFocusRing // TypeDefIndex: 44170
	{
		// Methods
		FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);
		Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);
	}

	public class FocusController // TypeDefIndex: 44172
	{
		// Fields
		private readonly IFocusRing _focusRing_k__BackingField; // 0x10
		private List<FocusedElement> m_FocusedElements; // 0x18
		private Focusable m_LastFocusedElement; // 0x20
		internal Focusable m_LastPendingFocusedElement; // 0x28
		private int m_PendingFocusCount; // 0x30
		private int _imguiKeyboardControl_k__BackingField; // 0x34
	
		// Properties
		private IFocusRing focusRing { get; } // 0x000000018346D130-0x000000018346D140 
		public Focusable focusedElement { get => default; } // 0x000000018BF897E8-0x000000018BF89828 
		internal int imguiKeyboardControl { get; set; } // 0x0000000185FB07C0-0x0000000185FB07D0 0x0000000185FB07E0-0x0000000185FB07F0
	
		// Nested types
		private struct FocusedElement // TypeDefIndex: 44171
		{
			// Fields
			public VisualElement m_SubTreeRoot; // 0x00
			public Focusable m_FocusedElement; // 0x08
		}
	
		// Constructors
		public FocusController() {} // Dummy constructor
		public FocusController(IFocusRing focusRing) {} // 0x000000018BF89750-0x000000018BF897E8
	
		// Methods
		internal bool IsFocused(Focusable f) => default; // 0x000000018BF88EC4-0x000000018BF88FF0
		internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst) => default; // 0x000000018BF88B84-0x000000018BF88DB4
		internal Focusable GetLeafFocusedElement() => default; // 0x000000018BF88AEC-0x000000018BF88B84
		private bool IsLocalElement(Focusable f) => default; // 0x000000018BF88FF0-0x000000018BF89014
		internal bool IsPendingFocus(Focusable f) => default; // 0x000000018BF89014-0x000000018BF89090
		internal void SetFocusToLastFocusedElement() {} // 0x000000018BF89208-0x000000018BF89268
		internal void BlurLastFocusedElement() {} // 0x000000018BF88718-0x000000018BF88790
		internal void DoFocusChange(Focusable f) {} // 0x000000018BF887E8-0x000000018BF88928
		internal Focusable FocusNextInDirection(FocusChangeDirection direction) => default; // 0x000000018BF88928-0x000000018BF88A08
		private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) {} // 0x000000018BF88610-0x000000018BF88718
		private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) {} // 0x000000018BF89100-0x000000018BF89208
		private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode) {} // 0x000000018BF88508-0x000000018BF88610
		private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) {} // 0x000000018BF88DB4-0x000000018BF88EC4
		internal void Blur(Focusable focusable, bool bIsFocusDelegated = false /* Metadata: 0x0205B469 */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x0205B46A */) {} // 0x000000018BF88790-0x000000018BF887E8
		internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false /* Metadata: 0x0205B46B */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x0205B46C */) {} // 0x000000018BF89414-0x000000018BF89494
		internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false /* Metadata: 0x0205B46D */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x0205B46E */) {} // 0x000000018BF89494-0x000000018BF896B4
		internal Focusable SwitchFocusOnEvent(EventBase e) => default; // 0x000000018BF89268-0x000000018BF89414
		internal void ReevaluateFocus() {} // 0x000000018BF89090-0x000000018BF89100
		internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget) {
			effectiveTarget = default;
			return default;
		} // 0x000000018BF88A08-0x000000018BF88AEC
		internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) {} // 0x000000018BF896B4-0x000000018BF89750
	}

	internal static class GroupBoxUtility // TypeDefIndex: 44173
	{
		// Fields
		private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers; // 0x00
		private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache; // 0x08
		private static readonly System.Type k_GenericGroupBoxType; // 0x10
	
		// Constructors
		static GroupBoxUtility() {} // 0x000000018BF8A3E8-0x000000018BF8A540
	
		// Methods
		public static void RegisterGroupBoxOptionCallbacks<T>(T option)
			where T : VisualElement, IGroupBoxOption {}
		public static void OnOptionSelected<T>(T selectedOption)
			where T : VisualElement, IGroupBoxOption {}
		private static void OnOptionAttachToPanel(AttachToPanelEvent evt) {} // 0x000000018BF89FB0-0x000000018BF8A190
		private static void OnOptionDetachFromPanel(DetachFromPanelEvent evt) {} // 0x000000018BF8A190-0x000000018BF8A31C
		private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox) => default; // 0x000000018BF89BA4-0x000000018BF89F04
		private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt) {} // 0x000000018BF89F04-0x000000018BF89FB0
		private static void OnPanelDestroyed(BaseVisualElementPanel panel) {} // 0x000000018BF8A31C-0x000000018BF8A3E8
	}

	internal interface IGroupBoxOption // TypeDefIndex: 44174
	{
		// Methods
		void SetSelected(bool selected);
	}

	internal interface IGroupBox // TypeDefIndex: 44175
	{
	}

	internal interface IGroupBox<T> : IGroupBox // TypeDefIndex: 44176
		where T : IGroupManager
	{
	}

	internal interface IGroupManager // TypeDefIndex: 44177
	{
		// Methods
		void OnOptionSelectionChanged(IGroupBoxOption selectedOption);
		void RegisterOption(IGroupBoxOption option);
		void UnregisterOption(IGroupBoxOption option);
	}

	internal class DefaultGroupManager : IGroupManager // TypeDefIndex: 44178
	{
		// Fields
		private List<IGroupBoxOption> m_GroupOptions; // 0x10
		private IGroupBoxOption m_SelectedOption; // 0x18
	
		// Constructors
		public DefaultGroupManager() {} // 0x000000018BF85A40-0x000000018BF85AB8
	
		// Methods
		public void OnOptionSelectionChanged(IGroupBoxOption selectedOption) {} // 0x000000018BF857DC-0x000000018BF8596C
		public void RegisterOption(IGroupBoxOption option) {} // 0x000000018BF8596C-0x000000018BF859EC
		public void UnregisterOption(IGroupBoxOption option) {} // 0x000000018BF859EC-0x000000018BF85A40
	}

	public class IMGUIContainer : VisualElement, IDisposable // TypeDefIndex: 44182
	{
		// Fields
		private Action m_OnGUIHandler; // 0x3C0
		private ObjectGUIState m_ObjectGUIState; // 0x3C8
		internal bool useOwnerObjectGUIState; // 0x3D0
		private Rect _lastWorldClip_k__BackingField; // 0x3D4
		private bool m_CullingEnabled; // 0x3E4
		private bool m_IsFocusDelegated; // 0x3E5
		private bool m_RefreshCachedLayout; // 0x3E6
		private GUILayoutUtility.LayoutCache m_Cache; // 0x3E8
		private Rect m_CachedClippingRect; // 0x3F0
		private Matrix4x4 m_CachedTransform; // 0x400
		private ContextType _contextType_k__BackingField; // 0x440
		private bool lostFocus; // 0x444
		private bool receivedFocus; // 0x445
		private FocusChangeDirection focusChangeDirection; // 0x448
		private bool hasFocusableControls; // 0x450
		private int newKeyboardFocusControlID; // 0x454
		private bool _focusOnlyIfHasFocusableControls_k__BackingField; // 0x458
		public static readonly string ussClassName; // 0x00
		internal static readonly string ussFoldoutChildDepthClassName; // 0x08
		internal static readonly List<string> ussFoldoutChildDepthClassNames; // 0x10
		private GUIGlobals m_GUIGlobals; // 0x45C
		private static readonly ProfilerMarker k_OnGUIMarker; // 0x18
		private static readonly ProfilerMarker k_ImmediateCallbackMarker; // 0x20
		private static UnityEngine.Event s_DefaultMeasureEvent; // 0x28
		private static UnityEngine.Event s_MeasureEvent; // 0x30
		private static UnityEngine.Event s_CurrentEvent; // 0x38
	
		// Properties
		public Action onGUIHandler { get => default; set {} } // 0x000000018BF8D7D0-0x000000018BF8D878 0x0000000185FE9470-0x0000000185FE9480
		internal ObjectGUIState guiState { get => default; } // 0x0000000185FE94A0-0x0000000185FE94B0 
		internal Rect lastWorldClip { get; set; } // 0x0000000185FE9450-0x0000000185FE9460 0x000000018BF8D72C-0x000000018BF8D7AC
		public bool cullingEnabled { get => default; } // 0x000000018BF8D8A8-0x000000018BF8D8D8 
		private GUILayoutUtility.LayoutCache cache { get => default; } // 0x000000018BF8D878-0x000000018BF8D8A8 
		private float layoutMeasuredWidth { get => default; } // 0x0000000185FE9440-0x0000000185FE9450 
		private float layoutMeasuredHeight { get => default; } // 0x0000000185FE9490-0x0000000185FE94A0 
		public ContextType contextType { get; set; } // 0x0000000185FE9460-0x0000000185FE9470 0x000000018BF8D7AC-0x000000018BF8D7D0
		internal bool focusOnlyIfHasFocusableControls { get; } // 0x000000018BF8D160-0x000000018BF8D53C 
		public override bool canGrabFocus { get => default; } // 0x000000018BF8D720-0x000000018BF8D72C 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits> // TypeDefIndex: 44179
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FE9480-0x0000000185FE9490
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 44180
		{
			// Constructors
			public UxmlTraits() {} // 0x000000018BF8D8D8-0x000000018BF8D938
		}
	
		private struct GUIGlobals // TypeDefIndex: 44181
		{
			// Fields
			public Matrix4x4 matrix; // 0x00
			public UnityEngine.Color color; // 0x40
			public UnityEngine.Color contentColor; // 0x50
			public UnityEngine.Color backgroundColor; // 0x60
			public bool enabled; // 0x70
			public bool changed; // 0x71
			public int displayIndex; // 0x74
		}
	
		// Constructors
		static IMGUIContainer() {} // 0x000000018BF8D53C-0x000000018BF8D720
		public IMGUIContainer() {} // 0x000000018BF8C8CC-0x000000018BF8C9E4
		public IMGUIContainer(Action onGUIHandler) {} // 0x000000018BF8CB24-0x000000018BF8CC24
	
		// Methods
		private void OnGenerateVisualContent(MeshGenerationContext mgc) {} // 0x000000018BF8C9E4-0x000000018BF8CB24
		private void SaveGlobals() {} // 0x000000018BF8AC44-0x000000018BF8BBA4
		private void RestoreGlobals() {} // 0x000000018BF8C8B8-0x000000018BF8C8CC
		private void DoOnGUI(UnityEngine.Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true /* Metadata: 0x0205B46F */) {} // 0x000000018BF8C010-0x000000018BF8C090
		public void MarkDirtyLayout() {} // 0x000000018BF8A6D8-0x000000018BF8A9B8
		public override void HandleEvent(EventBase evt) {} // 0x000000018BF8CCFC-0x000000018BF8CF8C
		private void DoIMGUIRepaint() {} // 0x000000018BF8CC24-0x000000018BF8CCFC
		internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true /* Metadata: 0x0205B470 */, bool verifyBounds = true /* Metadata: 0x0205B471 */) => default; // 0x000000018BF8D0D0-0x000000018BF8D160
		private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) => default; // 0x000000018BF8C4B4-0x000000018BF8C54C
		private bool VerifyBounds(EventBase evt) => default; // 0x000000018BF8C724-0x000000018BF8C8B8
		private bool IsContainerCapturingTheMouse() => default; // 0x000000018BF8C614-0x000000018BF8C724
		private bool IsLocalEvent(EventBase evt) => default; // 0x000000018BF8C54C-0x000000018BF8C614
		private bool IsEventInsideLocalWindow(EventBase evt) => default; // 0x000000018BF8C178-0x000000018BF8C19C
		private static bool IsDockAreaMouseUp(EventBase evt) => default; // 0x000000018BF8C090-0x000000018BF8C178
		private bool HandleIMGUIEvent(UnityEngine.Event e, bool canAffectFocus) => default; // 0x000000018BF8C19C-0x000000018BF8C4B4
		internal bool HandleIMGUIEvent(UnityEngine.Event e, Action onGUIHandler, bool canAffectFocus) => default; // 0x000000018BF8BBA4-0x000000018BF8BE08
		private bool HandleIMGUIEvent(UnityEngine.Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) => default; // 0x000000018BF8CF8C-0x000000018BF8D0C0
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x000000018BF8A9B8-0x000000018BF8AC44
		private void SetFoldoutDepthClass() {} // 0x000000018BF8BE08-0x000000018BF8BE80
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x000000018BF8BE80-0x000000018BF8C010
		private Rect GetCurrentClipRect() => default; // 0x000000018BF8A668-0x000000018BF8A6B8
		private static void GetCurrentTransformAndClip(IMGUIContainer container, UnityEngine.Event evt, out Matrix4x4 transform, out Rect clipRect) {
			transform = default;
			clipRect = default;
		} // 0x000000018BF8A6B8-0x000000018BF8A6D8
		public void Dispose() {} // 0x000000018BF8D0C0-0x000000018BF8D0D0
		protected virtual void Dispose(bool disposeManaged) {} // 0x000000018BF900D4-0x000000018BF90110
		private void _DoOnGUI_b__56_0() {} // 0x000000018BF90278-0x000000018BF922CC
	}

	internal class ImmediateModeException : Exception // TypeDefIndex: 44183
	{
		// Constructors
		public ImmediateModeException() {} // Dummy constructor
		public ImmediateModeException(Exception inner) {} // 0x000000018BF8D938-0x000000018BF8D99C
	}

	public enum SelectionType // TypeDefIndex: 44184
	{
		None = 0,
		Single = 1,
		Multiple = 2
	}

	internal interface ISerializableJsonDictionary // TypeDefIndex: 44185
	{
		// Methods
		void Set<T>(string key, T value)
			where T : class;
		T Get<T>(string key)
			where T : class;
		void Overwrite(object obj, string key);
		bool ContainsKey(string key);
	}

	public interface ITransform // TypeDefIndex: 44186
	{
		// Properties
		Vector3 position { get; set; }
		Vector3 scale { get; }
	}

	public enum KeyboardNavigationOperation // TypeDefIndex: 44187
	{
		None = 0,
		SelectAll = 1,
		Cancel = 2,
		Submit = 3,
		Previous = 4,
		Next = 5,
		MoveRight = 6,
		MoveLeft = 7,
		PageUp = 8,
		PageDown = 9,
		Begin = 10,
		End = 11
	}

	public class KeyboardNavigationManipulator : Manipulator // TypeDefIndex: 44190
	{
		// Fields
		private readonly Action<KeyboardNavigationOperation, EventBase> m_Action; // 0x18
	
		// Nested types
		private struct __c__DisplayClass5_0 // TypeDefIndex: 44188
		{
			// Fields
			public KeyDownEvent evt; // 0x00
		}
	
		private struct __c__DisplayClass6_0 // TypeDefIndex: 44189
		{
			// Fields
			public KeyDownEvent evt; // 0x00
		}
	
		// Constructors
		public KeyboardNavigationManipulator() {} // Dummy constructor
		public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action) {} // 0x0000000184088E70-0x0000000184088E80
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x000000018BF8DB38-0x000000018BF8DD34
		protected override void UnregisterCallbacksFromTarget() {} // 0x000000018BF8DED4-0x000000018BF8E0D0
		internal void OnKeyDown(KeyDownEvent evt) {} // 0x000000018BF8DA1C-0x000000018BF8DA7C
		private void OnRuntimeKeyDown(KeyDownEvent evt) {} // 0x000000018BF8DAFC-0x000000018BF8DB38
		private void OnEditorKeyDown(KeyDownEvent evt) {} // 0x000000018BF8D9E0-0x000000018BF8DA1C
		private void OnNavigationCancel(NavigationCancelEvent evt) {} // 0x000000018BF8DA7C-0x000000018BF8DA8C
		private void OnNavigationSubmit(NavigationSubmitEvent evt) {} // 0x000000018BF8DAEC-0x000000018BF8DAFC
		private void OnNavigationMove(NavigationMoveEvent evt) {} // 0x000000018BF8DA8C-0x000000018BF8DAEC
		private void Invoke(KeyboardNavigationOperation operation, EventBase evt) {} // 0x000000018BF8D9BC-0x000000018BF8D9E0
		internal static KeyboardNavigationOperation _OnRuntimeKeyDown_g__GetOperation_5_0(ref __c__DisplayClass5_0 param_0005e436) => default; // 0x000000018BF8DE2C-0x000000018BF8DED4
		internal static KeyboardNavigationOperation _OnEditorKeyDown_g__GetOperation_6_0(ref __c__DisplayClass6_0 param_0005e437) => default; // 0x000000018BF8DD34-0x000000018BF8DE2C
	}

	public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter> // TypeDefIndex: 44191
	{
		// Fields
		private MouseButton _button_k__BackingField; // 0x00
		private EventModifiers _modifiers_k__BackingField; // 0x04
		private int _clickCount_k__BackingField; // 0x08
	
		// Properties
		public MouseButton button { get; set; } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public EventModifiers modifiers { get; set; } // 0x000000018357CBC0-0x000000018357CBD0 0x0000000185FB2BA0-0x0000000185FB2BB0
		public int clickCount { get; } // 0x0000000181B7E450-0x0000000181B7E460 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BF8E1A4-0x000000018BF8E224
		public bool Equals(ManipulatorActivationFilter other) => default; // 0x00000001873341CC-0x00000001873341E8
		public override int GetHashCode() => default; // 0x0000000185FE94B0-0x0000000185FE94D0
		public bool Matches(IMouseEvent e) => default; // 0x000000018BF8E43C-0x000000018BF8E4BC
		private bool HasModifiers(IMouseEvent e) => default; // 0x000000018BF8E2AC-0x000000018BF8E334
		public bool Matches(IPointerEvent e) => default; // 0x000000018BF8E3BC-0x000000018BF8E43C
		private bool HasModifiers(IPointerEvent e) => default; // 0x000000018BF8E224-0x000000018BF8E2AC
		private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command) => default; // 0x000000018BF8E334-0x000000018BF8E3BC
	}

	public interface IManipulator // TypeDefIndex: 44192
	{
		// Properties
		VisualElement target { get; set; }
	}

	public abstract class Manipulator : IManipulator // TypeDefIndex: 44193
	{
		// Fields
		private VisualElement m_Target; // 0x10
	
		// Properties
		public VisualElement target { get; set; } // 0x0000000185FC7990-0x0000000185FC79A0 0x000000018BF8E4BC-0x000000018BF8E50C
	
		// Constructors
		protected Manipulator() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected abstract void RegisterCallbacksOnTarget();
		protected abstract void UnregisterCallbacksFromTarget();
	}

	public enum MouseButton // TypeDefIndex: 44194
	{
		LeftMouse = 0,
		RightMouse = 1,
		MiddleMouse = 2
	}

	public static class MouseCaptureController // TypeDefIndex: 44195
	{
		// Methods
		public static bool HasMouseCapture(IEventHandler handler) => default; // 0x000000018BF8E5A4-0x000000018BF8E614
		public static void CaptureMouse(IEventHandler handler) {} // 0x000000018BF8E50C-0x000000018BF8E5A4
		public static void ReleaseMouse(IEventHandler handler) {} // 0x000000018BF8E614-0x000000018BF8E6AC
	}

	public abstract class MouseManipulator : Manipulator // TypeDefIndex: 44196
	{
		// Fields
		private List<ManipulatorActivationFilter> _activators_k__BackingField; // 0x18
		private ManipulatorActivationFilter m_currentActivator; // 0x20
	
		// Properties
		public List<ManipulatorActivationFilter> activators { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		protected MouseManipulator() {} // 0x000000018BF8E834-0x000000018BF8E8AC
	
		// Methods
		protected bool CanStartManipulation(IMouseEvent e) => default; // 0x000000018BF8E6AC-0x000000018BF8E810
		protected bool CanStopManipulation(IMouseEvent e) => default; // 0x000000018BF8E810-0x000000018BF8E834
	}

	internal class ObjectPool<T> // TypeDefIndex: 44197
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private int m_MaxSize;
	
		// Properties
		public int maxSize { get => default; set {} }
	
		// Constructors
		public ObjectPool() {} // Dummy constructor
		public ObjectPool(int maxSize = 100 /* Metadata: 0x0205B484 */) {}
	
		// Methods
		public int Size() => default;
		public T Get() => default;
		public void Release(T element) {}
	}

	public enum ContextType // TypeDefIndex: 44198
	{
		Player = 0,
		Editor = 1
	}

	internal enum VersionChangeType // TypeDefIndex: 44199
	{
		Bindings = 1,
		ViewData = 2,
		Hierarchy = 4,
		Layout = 8,
		StyleSheet = 16,
		Styles = 32,
		Overflow = 64,
		BorderRadius = 128,
		BorderWidth = 256,
		Transform = 512,
		Size = 1024,
		Repaint = 2048,
		Opacity = 4096,
		Color = 8192,
		RenderHints = 16384,
		TransitionProperty = 32768
	}

	public enum UsageHints // TypeDefIndex: 44200
	{
		None = 0,
		DynamicTransform = 1,
		GroupTransform = 2,
		MaskContainer = 4,
		DynamicColor = 8
	}

	internal enum RenderHints // TypeDefIndex: 44201
	{
		None = 0,
		GroupTransform = 1,
		BoneTransform = 2,
		ClipWithScissors = 4,
		DirtyOffset = 5,
		MaskContainer = 8,
		DynamicColor = 16,
		DirtyGroupTransform = 32,
		DirtyBoneTransform = 64,
		DirtyClipWithScissors = 128,
		DirtyMaskContainer = 256,
		DirtyAll = 480
	}

	internal struct PanelClearSettings // TypeDefIndex: 44202
	{
		// Fields
		public bool clearDepthStencil; // 0x00
		public bool clearColor; // 0x01
		public UnityEngine.Color color; // 0x04
	}

	internal class RepaintData // TypeDefIndex: 44203
	{
		// Fields
		private Matrix4x4 _currentOffset_k__BackingField; // 0x10
		private Vector2 _mousePosition_k__BackingField; // 0x50
		private Rect _currentWorldClip_k__BackingField; // 0x58
		private UnityEngine.Event _repaintEvent_k__BackingField; // 0x68
	
		// Properties
		public Matrix4x4 currentOffset { get; } // 0x0000000185FBF640-0x0000000185FBF670 
		public Rect currentWorldClip { get; } // 0x0000000185FB1D60-0x0000000185FB1D70 
		public UnityEngine.Event repaintEvent { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
	
		// Constructors
		public RepaintData() {} // 0x000000018BF8FAD0-0x000000018BF8FB08
	}

	internal delegate void HierarchyEvent(VisualElement ve, HierarchyChangeType changeType); // TypeDefIndex: 44204; 0x00000001831C5680-0x00000001831C5690

	public interface IPanel : IDisposable // TypeDefIndex: 44205
	{
		// Properties
		VisualElement visualTree { get; }
		EventDispatcher dispatcher { get; }
		ContextType contextType { get; }
		FocusController focusController { get; }
	
		// Methods
		VisualElement Pick(Vector2 point);
	}

	internal abstract class BaseVisualElementPanel : IPanel, IGroupBox // TypeDefIndex: 44206
	{
		// Fields
		private Action<BaseVisualElementPanel> panelDisposed; // 0x10
		private float m_Scale; // 0x18
		internal YogaConfig yogaConfig; // 0x20
		private float m_PixelsPerPoint; // 0x28
		private PanelClearSettings _clearSettings_k__BackingField; // 0x2C
		private bool _duringLayoutPhase_k__BackingField; // 0x40
		private RepaintData _repaintData_k__BackingField; // 0x48
		private ICursorManager _cursorManager_k__BackingField; // 0x50
		private ContextualMenuManager _contextualMenuManager_k__BackingField; // 0x58
		private bool _disposed_k__BackingField; // 0x60
		internal ElementUnderPointer m_TopElementUnderPointers; // 0x68
		private Action standardShaderChanged; // 0x70
		private Action standardWorldSpaceShaderChanged; // 0x78
		private Action atlasChanged; // 0x80
		private Action<Material> updateMaterial; // 0x88
		private HierarchyEvent hierarchyChanged; // 0x90
		private Action<IPanel> beforeUpdate; // 0x98
	
		// Properties
		public abstract EventInterests IMGUIEventInterests { get; set; }
		public abstract ScriptableObject ownerObject { get; protected set; }
		public abstract SavePersistentViewData saveViewData { get; }
		public abstract GetViewDataDictionary getViewDataDictionary { get; }
		public abstract int IMGUIContainersCount { get; set; }
		public abstract FocusController focusController { get; set; }
		public abstract IMGUIContainer rootIMGUIContainer { get; }
		internal float scale { get; set; } // 0x0000000185FE68F0-0x0000000185FE6900 0x000000018BF8118C-0x000000018BF81220
		internal float pixelsPerPoint { get; set; } // 0x000000018BF810F8-0x000000018BF8118C
		public float scaledPixelsPerPoint { get; } // 0x0000000185FE9380-0x0000000185FE9390 
		internal PanelClearSettings clearSettings { get; set; } // 0x0000000185FE9360-0x0000000185FE9380 0x0000000185FE9390-0x0000000185FE93A0
		internal bool duringLayoutPhase { get; set; } // 0x0000000185FB0650-0x0000000185FB0660 0x0000000185FB0660-0x0000000185FB0670
		internal abstract uint version { get; }
		internal abstract uint hierarchyVersion { get; }
		internal virtual RepaintData repaintData { get; set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		internal virtual ICursorManager cursorManager { get; set; } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public ContextualMenuManager contextualMenuManager { get; internal set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public abstract VisualElement visualTree { get; }
		public abstract EventDispatcher dispatcher { get; set; }
		internal abstract IScheduler scheduler { get; }
		internal abstract IStylePropertyAnimationSystem styleAnimationSystem { get; set; }
		public abstract ContextType contextType { get; protected set; }
		internal bool disposed { get; private set; } // 0x000000018386C570-0x000000018386C580 0x000000018386C580-0x000000018386C590
		internal abstract Shader standardShader { get; }
		internal virtual Shader standardWorldSpaceShader { get; } // 0x0000000185FE67B0-0x0000000185FE67C0 
		public abstract AtlasBase atlas { get; set; }
	
		// Events
		internal event Action<BaseVisualElementPanel> panelDisposed;
		internal event Action standardShaderChanged;
		internal event Action standardWorldSpaceShaderChanged;
		internal event Action atlasChanged;
		internal event HierarchyEvent hierarchyChanged;
	
		// Constructors
		protected BaseVisualElementPanel() {} // 0x000000018BF80A10-0x000000018BF80B30
	
		// Methods
		public void Dispose() {} // 0x000000018BF80464-0x000000018BF804B4
		protected virtual void Dispose(bool disposing) {} // 0x000000018BF804B4-0x000000018BF805A8
		public abstract void Repaint(UnityEngine.Event e);
		public abstract void ValidateLayout();
		public abstract void UpdateAnimations();
		public abstract void UpdateBindings();
		public abstract void ApplyStyles();
		internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);
		internal void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x0205B4BD */) {} // 0x000000018BF80730-0x000000018BF807C8
		public abstract VisualElement Pick(Vector2 point);
		public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked);
		internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase);
		internal VisualElement GetTopElementUnderPointer(int pointerId) => default; // 0x000000018BF805A8-0x000000018BF805C8
		internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) => default; // 0x000000018BF80638-0x000000018BF80730
		internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) {} // 0x000000018BF803D8-0x000000018BF80408
		internal void CommitElementUnderPointers() {} // 0x000000018BF80408-0x000000018BF80464
		protected void InvokeAtlasChanged() {} // 0x000000018BF805C8-0x000000018BF805DC
		internal void InvokeUpdateMaterial(Material mat) {} // 0x000000018BF80620-0x000000018BF80638
		internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) {} // 0x000000018BF805F8-0x000000018BF80620
		internal void InvokeBeforeUpdate() {} // 0x000000018BF805DC-0x000000018BF805F8
		internal void UpdateElementUnderPointers() {} // 0x000000018BF807C8-0x000000018BF8096C
		public virtual void Update() {} // 0x000000018BF8096C-0x000000018BF80A10
	}

	internal delegate UnityEngine.Object LoadResourceFunction(string pathName, System.Type type, float dpiScaling); // TypeDefIndex: 44207; 0x00000001817B82F0-0x00000001817B8310

	internal delegate long TimeMsFunction(); // TypeDefIndex: 44208; 0x0000000183683B30-0x0000000183683B40

	internal delegate ISerializableJsonDictionary GetViewDataDictionary(); // TypeDefIndex: 44209; 0x0000000183683B30-0x0000000183683B40

	internal delegate void SavePersistentViewData(); // TypeDefIndex: 44210; 0x00000001864BC320-0x00000001864BC330

	internal class Panel : BaseVisualElementPanel // TypeDefIndex: 44211
	{
		// Fields
		private VisualElement m_RootContainer; // 0xA0
		private VisualTreeUpdater m_VisualTreeUpdater; // 0xA8
		private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; // 0xB0
		private string m_PanelName; // 0xB8
		private uint m_Version; // 0xC0
		private uint m_RepaintVersion; // 0xC4
		private uint m_HierarchyVersion; // 0xC8
		private ProfilerMarker m_MarkerBeforeUpdate; // 0xD0
		private ProfilerMarker m_MarkerUpdate; // 0xD8
		private ProfilerMarker m_MarkerLayout; // 0xE0
		private ProfilerMarker m_MarkerBindings; // 0xE8
		private ProfilerMarker m_MarkerAnimations; // 0xF0
		private static ProfilerMarker s_MarkerPickAll; // 0x00
		private EventDispatcher _dispatcher_k__BackingField; // 0xF8
		private TimerEventScheduler m_Scheduler; // 0x100
		private ScriptableObject _ownerObject_k__BackingField; // 0x108
		private ContextType _contextType_k__BackingField; // 0x110
		private SavePersistentViewData _saveViewData_k__BackingField; // 0x118
		private GetViewDataDictionary _getViewDataDictionary_k__BackingField; // 0x120
		private FocusController _focusController_k__BackingField; // 0x128
		private EventInterests _IMGUIEventInterests_k__BackingField; // 0x130
		private static LoadResourceFunction _loadResourceFunc_k__BackingField; // 0x08
		private static TimeMsFunction _TimeSinceStartup_k__BackingField; // 0x10
		private int _IMGUIContainersCount_k__BackingField; // 0x134
		private IMGUIContainer _rootIMGUIContainer_k__BackingField; // 0x138
		private Shader m_StandardShader; // 0x140
		private AtlasBase m_Atlas; // 0x148
		private bool m_ValidatingLayout; // 0x150
		private static Action<Panel> beforeAnyRepaint; // 0x18
	
		// Properties
		public sealed override VisualElement visualTree { get => default; } // 0x0000000185FE8B50-0x0000000185FE8B60 
		public sealed override EventDispatcher dispatcher { get; set; } // 0x0000000185FB16B0-0x0000000185FB16C0 0x000000018774E878-0x000000018774E88C
		public TimerEventScheduler timerEventScheduler { get => default; } // 0x000000018BF8F924-0x000000018BF8F9A0 
		internal override IScheduler scheduler { get => default; } // 0x000000018BF8F918-0x000000018BF8F924 
		internal override IStylePropertyAnimationSystem styleAnimationSystem { get => default; set {} } // 0x000000018346D8F0-0x000000018346D900 0x000000018BF8FA38-0x000000018BF8FAD0
		public override ScriptableObject ownerObject { get; protected set; } // 0x0000000181ABEDF0-0x0000000181ABEE00 0x0000000187A474C4-0x0000000187A474D8
		public override ContextType contextType { get; protected set; } // 0x0000000185FBEB60-0x0000000185FBEB70 0x0000000185FBEB80-0x0000000185FBEB90
		public override SavePersistentViewData saveViewData { get; } // 0x0000000185FB8540-0x0000000185FB8550 
		public override GetViewDataDictionary getViewDataDictionary { get; } // 0x0000000185FB8700-0x0000000185FB8710 
		public sealed override FocusController focusController { get; set; } // 0x0000000185FB8550-0x0000000185FB8560 0x00000001864735A4-0x00000001864735B8
		public override EventInterests IMGUIEventInterests { get; set; } // 0x0000000185FE94F0-0x0000000185FE9510 0x0000000185FE9540-0x0000000185FE9560
		private static LoadResourceFunction loadResourceFunc { get; } // 0x000000018BF8F8C8-0x000000018BF8F918 
		internal string name { get => default; set {} } // 0x0000000185FE8C10-0x0000000185FE8C20 0x000000018BF8FA10-0x000000018BF8FA38
		private static TimeMsFunction TimeSinceStartup { get; } // 0x000000018BF8F878-0x000000018BF8F8C8 
		public override int IMGUIContainersCount { get; set; } // 0x0000000185FB11A0-0x0000000185FB11B0 0x0000000185FE9530-0x0000000185FE9540
		public override IMGUIContainer rootIMGUIContainer { get; } // 0x0000000185FB8720-0x0000000185FB8730 
		internal override uint version { get => default; } // 0x0000000185FBE0C0-0x0000000185FBE0D0 
		internal override uint hierarchyVersion { get => default; } // 0x0000000185FB32E0-0x0000000185FB32F0 
		internal override Shader standardShader { get => default; } // 0x0000000185FE9520-0x0000000185FE9530 
		public override AtlasBase atlas { get => default; set {} } // 0x0000000185FE9510-0x0000000185FE9520 0x000000018BF8F9A0-0x000000018BF8FA10
	
		// Constructors
		public Panel() {} // Dummy constructor
		public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) {} // 0x000000018BF8F518-0x000000018BF8F878
		static Panel() {} // 0x000000018BF8F4B8-0x000000018BF8F518
	
		// Methods
		internal static UnityEngine.Object LoadResource(string pathName, System.Type type, float dpiScaling) => default; // 0x000000018BF8EC1C-0x000000018BF8ECC4
		internal void Focus() {} // 0x000000018BF8EBCC-0x000000018BF8EBF8
		internal void Blur() {} // 0x000000018BF8E8D4-0x000000018BF8E900
		private void CreateMarkers() {} // 0x000000018BF8E900-0x000000018BF8EB54
		protected override void Dispose(bool disposing) {} // 0x000000018BF8EB74-0x000000018BF8EBCC
		public static long TimeSinceStartupMs() => default; // 0x000000018BF8F2D0-0x000000018BF8F360
		internal static long DefaultTimeSinceStartupMs() => default; // 0x000000018BF8EB54-0x000000018BF8EB74
		private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null) => default; // 0x000000018BF8EF8C-0x000000018BF8EFF0
		private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null) => default; // 0x000000018BF8ED0C-0x000000018BF8EEE8
		public override VisualElement PickAll(Vector2 point, List<VisualElement> picked) => default; // 0x000000018BF8EEE8-0x000000018BF8EF8C
		public override VisualElement Pick(Vector2 point) => default; // 0x000000018BF8EFF0-0x000000018BF8F11C
		public override void ValidateLayout() {} // 0x000000018BF8F444-0x000000018BF8F4B8
		public override void UpdateAnimations() {} // 0x000000018BF8F368-0x000000018BF8F390
		public override void UpdateBindings() {} // 0x000000018BF8F390-0x000000018BF8F3B8
		public override void ApplyStyles() {} // 0x000000018BF8E8AC-0x000000018BF8E8D4
		private void UpdateForRepaint() {} // 0x000000018BF8F3B8-0x000000018BF8F444
		public override void Repaint(UnityEngine.Event e) {} // 0x000000018BF8F11C-0x000000018BF8F2D0
		internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018BF8ECC4-0x000000018BF8ED0C
		internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) => default; // 0x000000018BF8EBF8-0x000000018BF8EC1C
		internal static Vector2Int _Pick_g__PixelOf_99_0(Vector2 p) => default; // 0x000000018BF8F360-0x000000018BF8F368
	}

	internal abstract class BaseRuntimePanel : UnityEngine.UIElements.Panel // TypeDefIndex: 44213
	{
		// Fields
		private GameObject m_SelectableGameObject; // 0x158
		private static int s_CurrentRuntimePanelCounter; // 0x00
		internal readonly int m_RuntimePanelCreationIndex; // 0x160
		private float m_SortingPriority; // 0x164
		private Action destroyed; // 0x168
		private Shader m_StandardWorldSpaceShader; // 0x170
		private bool m_DrawToCameras; // 0x178
		internal RenderTexture targetTexture; // 0x180
		internal Matrix4x4 panelToWorld; // 0x188
		private int _targetDisplay_k__BackingField; // 0x1C8
		internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace; // 0x08
		private Func<Vector2, Vector2> m_ScreenToPanelSpace; // 0x1D0
	
		// Properties
		public GameObject selectableGameObject { get; set; } // 0x000000018BF80360-0x000000018BF803D8 0x000000018BF7FF3C-0x000000018BF7FFD4
		public float sortingPriority { get; set; } // 0x000000018BF80144-0x000000018BF801DC 0x000000018BF7FE28-0x000000018BF7FF3C
		internal override Shader standardWorldSpaceShader { get; } // 0x0000000185FBF260-0x0000000185FBF270 
		internal bool drawToCameras { get; set; } // 0x0000000185FE9350-0x0000000185FE9360 0x000000018BF8008C-0x000000018BF80144
		internal int targetDisplay { get; set; } // 0x000000018BF7FFD4-0x000000018BF8008C 0x000000018BF7F9C0-0x000000018BF7FBC0
		internal int screenRenderingWidth { get; } // 0x0000000185FB8030-0x0000000185FB8040 
		internal int screenRenderingHeight { get; } // 0x000000018BF80254-0x000000018BF802CC 
		public Func<Vector2, Vector2> screenToPanelSpace { get; set; } // 0x000000018BF7FC10-0x000000018BF7FD4C 0x000000018BF7F5B4-0x000000018BF7F864
	
		// Events
		public event Action destroyed;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44212
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000185FB8510-0x0000000185FB8520
			public __c() {} // 0x000000018BF802CC-0x000000018BF80360
	
			// Methods
			internal Vector2 _.cctor_b__44_0(Vector2 p) => default; // 0x0000000185FB9AC0-0x0000000185FB9AD0
		}
	
		// Constructors
		protected BaseRuntimePanel() {} // Dummy constructor
		protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null) {} // 0x0000000185FE9330-0x0000000185FE9340
		static BaseRuntimePanel() {} // 0x00000001834A4750-0x00000001834A4760
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x000000018BF801DC-0x000000018BF80254
		public override void Repaint(UnityEngine.Event e) {} // 0x000000018BF7FBC0-0x000000018BF7FC10
		internal Vector2 ScreenToPanel(Vector2 screen) => default; // 0x000000018BF7F92C-0x000000018BF7F9C0
		internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false /* Metadata: 0x0205B4BE */) {
			panelPosition = default;
			panelDelta = default;
			return default;
		} // 0x000000018BF7F8A8-0x000000018BF7F92C
		private void AssignPanelToComponents(BaseRuntimePanel panel) {} // 0x000000018BF7FD4C-0x000000018BF7FE28
		internal void PointerLeavesPanel(int pointerId, Vector2 position) {} // 0x000000018BF96174-0x000000018BF961D8
		internal void PointerEntersPanel(int pointerId, Vector2 position) {} // 0x0000000185492010-0x0000000185492020
	}

	internal interface IRuntimePanelComponent // TypeDefIndex: 44214
	{
		// Properties
		IPanel panel { get; set; }
	}

	public static class PointerCaptureHelper // TypeDefIndex: 44215
	{
		// Methods
		private static PointerDispatchState GetStateFor(IEventHandler handler) => default; // 0x000000018BF94488-0x000000018BF944F0
		public static bool HasPointerCapture(IEventHandler handler, int pointerId) => default; // 0x000000018BF944F0-0x000000018BF9452C
		public static void CapturePointer(IEventHandler handler, int pointerId) {} // 0x000000018BF94408-0x000000018BF94440
		public static void ReleasePointer(IEventHandler handler, int pointerId) {} // 0x000000018BF9459C-0x000000018BF945D4
		public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) => default; // 0x000000018BF94440-0x000000018BF94488
		public static void ReleasePointer(IPanel panel, int pointerId) {} // 0x000000018BF945D4-0x000000018BF9460C
		internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) {} // 0x000000018BF943D0-0x000000018BF94408
		internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) {} // 0x000000018BF9452C-0x000000018BF94564
		internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) => default; // 0x000000018BF9460C-0x000000018BF946C8
		internal static void ProcessPointerCapture(IPanel panel, int pointerId) {} // 0x000000018BF94564-0x000000018BF9459C
	}

	internal class PointerDispatchState // TypeDefIndex: 44216
	{
		// Fields
		private IEventHandler[] m_PendingPointerCapture; // 0x10
		private IEventHandler[] m_PointerCapture; // 0x18
		private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20
	
		// Constructors
		public PointerDispatchState() {} // 0x000000018BF94F4C-0x000000018BF95020
	
		// Methods
		internal void Reset() {} // 0x000000018BF94E74-0x000000018BF94EEC
		public IEventHandler GetCapturingElement(int pointerId) => default; // 0x0000000187B1A518-0x0000000187B1A544
		public bool HasPointerCapture(IEventHandler handler, int pointerId) => default; // 0x000000018BF947E0-0x000000018BF94810
		public void CapturePointer(IEventHandler handler, int pointerId) {} // 0x000000018BF946F8-0x000000018BF947E0
		public void ReleasePointer(int pointerId) {} // 0x000000018BF94E0C-0x000000018BF94E30
		public void ReleasePointer(IEventHandler handler, int pointerId) {} // 0x000000018BF94E30-0x000000018BF94E74
		public void ProcessPointerCapture(int pointerId) {} // 0x000000018BF94840-0x000000018BF94E0C
		public void ActivateCompatibilityMouseEvents(int pointerId) {} // 0x000000018BF946C8-0x000000018BF946F8
		public void PreventCompatibilityMouseEvents(int pointerId) {} // 0x000000018BF94810-0x000000018BF94840
		public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) => default; // 0x000000018BF94EEC-0x000000018BF94F4C
	}

	public abstract class PointerManipulator : MouseManipulator // TypeDefIndex: 44217
	{
		// Fields
		private int m_CurrentPointerId; // 0x30
	
		// Constructors
		protected PointerManipulator() {} // 0x000000018BF951B0-0x000000018BF951B8
	
		// Methods
		protected bool CanStartManipulation(IPointerEvent e) => default; // 0x000000018BF95020-0x000000018BF9518C
		protected bool CanStopManipulation(IPointerEvent e) => default; // 0x000000018BF9518C-0x000000018BF951B0
	}

	internal static class ProjectionUtils // TypeDefIndex: 44218
	{
		// Methods
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far) => default; // 0x000000018BF951B8-0x000000018BF952D4
	}

	public struct TimerState : IEquatable<UnityEngine.UIElements.TimerState> // TypeDefIndex: 44219
	{
		// Fields
		private long _start_k__BackingField; // 0x00
		private long _now_k__BackingField; // 0x08
	
		// Properties
		public long start { get; set; } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public long now { get; set; } // 0x000000018357A260-0x000000018357A270 0x0000000185FB6DD0-0x0000000185FB6DE0
		public long deltaTime { get => default; } // 0x0000000185FE95B0-0x0000000185FE95C0 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BF96098-0x000000018BF96110
		public bool Equals(TimerState other) => default; // 0x000000018BF9606C-0x000000018BF96098
		public override int GetHashCode() => default; // 0x0000000185FE9570-0x0000000185FE95B0
	}

	internal interface IScheduler // TypeDefIndex: 44220
	{
		// Methods
		void Unschedule(ScheduledItem item);
		void Schedule(ScheduledItem item);
		void UpdateScheduledEvents();
	}

	internal abstract class ScheduledItem // TypeDefIndex: 44222
	{
		// Fields
		public Func<bool> timerUpdateStopCondition; // 0x10
		public static readonly Func<bool> OnceCondition; // 0x00
		public static readonly Func<bool> ForeverCondition; // 0x08
		private long _startMs_k__BackingField; // 0x18
		private long _delayMs_k__BackingField; // 0x20
		private long _intervalMs_k__BackingField; // 0x28
		private long _endTimeMs_k__BackingField; // 0x30
	
		// Properties
		public long startMs { get; set; } // 0x00000001813B8590-0x00000001813B85A0 0x0000000185FB0620-0x0000000185FB0630
		public long delayMs { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x000000018BF95478-0x000000018BF954D8
		public long intervalMs { get; set; } // 0x000000018BF952D4-0x000000018BF95320 
		public long endTimeMs { get; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44221
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x0000000181448AC0-0x0000000181448AD0
	
			// Methods
			internal bool _.cctor_b__25_0() => default; // 0x00000001813B31A0-0x00000001813B31B0
			internal bool _.cctor_b__25_1() => default; // 0x00000001813BDF70-0x00000001813BDF80
		}
	
		// Constructors
		public ScheduledItem() {} // 0x000000018BF95320-0x000000018BF95340
		static ScheduledItem() {} // 0x00000001814A81B0-0x00000001814A81C0
	
		// Methods
		protected void ResetStartTime() {} // 0x000000018BF95340-0x000000018BF95478
		public abstract void PerformTimerUpdate(UnityEngine.UIElements.TimerState state); // 0x000000018BF96110-0x000000018BF96174
		internal virtual void OnItemUnscheduled() {} // 0x0000000185492010-0x0000000185492020
		public virtual bool ShouldUnschedule() => default; // 0x00000001840A27C0-0x00000001840A27D0
	}

	internal class TimerEventScheduler : IScheduler // TypeDefIndex: 44223
	{
		// Fields
		private readonly List<ScheduledItem> m_ScheduledItems; // 0x10
		private bool m_TransactionMode; // 0x18
		private readonly List<ScheduledItem> m_ScheduleTransactions; // 0x20
		private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; // 0x28
		internal bool disableThrottling; // 0x30
		private int m_LastUpdatedIndex; // 0x34
	
		// Constructors
		public TimerEventScheduler() {} // 0x000000018BF95EE0-0x000000018BF95FDC
	
		// Methods
		public void Schedule(ScheduledItem item) {} // 0x000000018BF956D0-0x000000018BF958C4
		private bool RemovedScheduledItemAt(int index) => default; // 0x000000018BF95660-0x000000018BF956D0
		public void Unschedule(ScheduledItem item) {} // 0x000000018BF958C4-0x000000018BF95B34
		private bool PrivateUnSchedule(ScheduledItem sItem) => default; // 0x000000018BF955C4-0x000000018BF95660
		public void UpdateScheduledEvents() {} // 0x000000018BF95B34-0x000000018BF95EE0
	}

	internal struct Spacing // TypeDefIndex: 44224
	{
		// Fields
		public float left; // 0x00
		public float top; // 0x04
		public float right; // 0x08
		public float bottom; // 0x0C
	
		// Properties
		public float horizontal { get => default; } // 0x0000000185FE6B00-0x0000000185FE6B10 
		public float vertical { get => default; } // 0x0000000185FE6A90-0x0000000185FE6AA0 
	
		// Constructors
		public Spacing(float left, float top, float right, float bottom) : this() {
			this.left = default;
			this.top = default;
			this.right = default;
			this.bottom = default;
		} // 0x0000000185FB2B40-0x0000000185FB2B60
	
		// Methods
		public static Rect operator -(Rect r, Spacing a) => default; // 0x000000018BF95558-0x000000018BF955C4
	}

	public enum Position // TypeDefIndex: 44225
	{
		Relative = 0,
		Absolute = 1
	}

	internal enum OverflowInternal // TypeDefIndex: 44226
	{
		Visible = 0,
		Hidden = 1,
		Scroll = 2
	}

	public enum OverflowClipBox // TypeDefIndex: 44227
	{
		PaddingBox = 0,
		ContentBox = 1
	}

	public enum FlexDirection // TypeDefIndex: 44228
	{
		Column = 0,
		ColumnReverse = 1,
		Row = 2,
		RowReverse = 3
	}

	public enum Wrap // TypeDefIndex: 44229
	{
		NoWrap = 0,
		Wrap = 1,
		WrapReverse = 2
	}

	public enum Align // TypeDefIndex: 44230
	{
		Auto = 0,
		FlexStart = 1,
		Center = 2,
		FlexEnd = 3,
		Stretch = 4
	}

	public enum Justify // TypeDefIndex: 44231
	{
		FlexStart = 0,
		Center = 1,
		FlexEnd = 2,
		SpaceBetween = 3,
		SpaceAround = 4
	}

	public enum TextOverflowPosition // TypeDefIndex: 44232
	{
		End = 0,
		Start = 1,
		Middle = 2
	}

	public enum TextOverflow // TypeDefIndex: 44233
	{
		Clip = 0,
		Ellipsis = 1
	}

	public enum TransformOriginOffset // TypeDefIndex: 44234
	{
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4,
		Center = 5
	}

	public enum Visibility // TypeDefIndex: 44235
	{
		Visible = 0,
		Hidden = 1
	}

	public enum WhiteSpace // TypeDefIndex: 44236
	{
		Normal = 0,
		NoWrap = 1
	}

	public enum DisplayStyle // TypeDefIndex: 44237
	{
		Flex = 0,
		None = 1
	}

	internal interface IStylePainter // TypeDefIndex: 44238
	{
		// Methods
		void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint);
		void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams);
		void DrawImmediate(Action callback, bool cullingEnabled);
	}

	internal struct CursorPositionStylePainterParameters // TypeDefIndex: 44239
	{
		// Fields
		public Rect rect; // 0x00
		public string text; // 0x10
		public Font font; // 0x18
		public int fontSize; // 0x20
		public FontStyle fontStyle; // 0x24
		public TextAnchor anchor; // 0x28
		public float wordWrapWidth; // 0x2C
		public bool richText; // 0x30
		public int cursorIndex; // 0x34
	
		// Methods
		public static CursorPositionStylePainterParameters GetDefault(VisualElement ve, string text) => default; // 0x000000018BF9264C-0x000000018BF927C8
		internal TextNativeSettings GetTextNativeSettings(float scaling) => default; // 0x000000018BF927C8-0x000000018BF928A4
	}

	internal interface IStylePropertyAnimations // TypeDefIndex: 44240
	{
		// Properties
		int runningAnimationCount { get; set; }
		int completedAnimationCount { get; set; }
	
		// Methods
		bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve);
		void UpdateAnimation(StylePropertyId id);
		void GetAllAnimations(List<StylePropertyId> outPropertyIds);
		void CancelAnimation(StylePropertyId id);
		void CancelAllAnimations();
	}

	public class VisualElement : Focusable, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler, IResolvedStyle // TypeDefIndex: 44253
	{
		// Fields
		private int _UnityEngine_UIElements_IStylePropertyAnimations_runningAnimationCount_k__BackingField; // 0x30
		private int _UnityEngine_UIElements_IStylePropertyAnimations_completedAnimationCount_k__BackingField; // 0x34
		private static uint s_NextId; // 0x00
		private static List<string> s_EmptyClassList; // 0x08
		internal static readonly PropertyName userDataPropertyKey; // 0x10
		public static readonly string disabledUssClassName; // 0x18
		private string m_Name; // 0x38
		private List<string> m_ClassList; // 0x40
		private List<KeyValuePair<PropertyName, object>> m_PropertyBag; // 0x48
		internal VisualElementFlags m_Flags; // 0x50
		private string m_ViewDataKey; // 0x58
		private RenderHints m_RenderHints; // 0x60
		internal Rect lastLayout; // 0x64
		internal Rect lastPseudoPadding; // 0x74
		internal RenderChainVEData renderChainData; // 0x88
		private Rect m_Layout; // 0x1E0
		private Rect m_BoundingBox; // 0x1F0
		private Rect m_WorldBoundingBox; // 0x200
		private Matrix4x4 m_WorldTransformCache; // 0x210
		private Matrix4x4 m_WorldTransformInverseCache; // 0x250
		private Rect m_WorldClip; // 0x290
		private Rect m_WorldClipMinusGroup; // 0x2A0
		private bool m_WorldClipIsInfinite; // 0x2B0
		internal static readonly Rect s_InfiniteRect; // 0x20
		internal PseudoStates triggerPseudoMask; // 0x2B4
		internal PseudoStates dependencyPseudoMask; // 0x2B8
		private PseudoStates m_PseudoStates; // 0x2BC
		private int _containedPointerIds_k__BackingField; // 0x2C0
		private PickingMode _pickingMode_k__BackingField; // 0x2C4
		private YogaNode _yogaNode_k__BackingField; // 0x2C8
		internal ComputedStyle m_Style; // 0x2D0
		internal StyleVariableContext variableContext; // 0x328
		internal int inheritedStylesHash; // 0x330
		internal readonly uint controlid; // 0x334
		internal int imguiContainerDescendantCount; // 0x338
		private bool _enabledSelf_k__BackingField; // 0x33C
		private LanguageDirection m_LanguageDirection; // 0x340
		private LanguageDirection m_LocalLanguageDirection; // 0x344
		private Action<MeshGenerationContext> _generateVisualContent_k__BackingField; // 0x348
		private ProfilerMarker k_GenerateVisualContentMarker; // 0x350
		private RenderTargetMode m_SubRenderTargetMode; // 0x358
		private static Material s_runtimeMaterial; // 0x30
		private Material m_defaultMaterial; // 0x360
		private List<IValueAnimationUpdate> m_RunningAnimations; // 0x368
		internal const string k_RootVisualContainerName = "rootVisualContainer"; // Metadata: 0x0205B4E9
		private Hierarchy _hierarchy_k__BackingField; // 0x370
		private bool _isRootVisualContainer_k__BackingField; // 0x378
		private bool _cacheAsBitmap_k__BackingField; // 0x379
		private VisualElement m_PhysicalParent; // 0x380
		private VisualElement m_LogicalParent; // 0x388
		private static readonly List<VisualElement> s_EmptyList; // 0x38
		private List<VisualElement> m_Children; // 0x390
		private BaseVisualElementPanel _elementPanel_k__BackingField; // 0x398
		private VisualTreeAsset m_VisualTreeAssetSource; // 0x3A0
		internal static CustomStyleAccess s_CustomStyleAccess; // 0x40
		internal InlineStyleAccess inlineStyleAccess; // 0x3A8
		internal List<StyleSheet> styleSheetList; // 0x3B0
		private static readonly Regex s_InternalStyleSheetPath; // 0x48
		internal static readonly PropertyName tooltipPropertyKey; // 0x50
		private static readonly Dictionary<System.Type, TypeData> s_TypeData; // 0x58
		private TypeData m_TypeData; // 0x3B8
	
		// Properties
		internal bool hasRunningAnimations { get => default; } // 0x000000018BF9F5D8-0x000000018BF9F628 
		internal bool hasCompletedAnimations { get => default; } // 0x000000018BF9E4A8-0x000000018BF9E720 
		int IStylePropertyAnimations.runningAnimationCount { get; set; } // 0x000000018BF9E954-0x000000018BF9E9CC 0x000000018BFA0178-0x000000018BFA0200
		int IStylePropertyAnimations.completedAnimationCount { get; set; } // 0x000000018BF9FC1C-0x000000018BF9FC6C 0x000000018BF9FDF4-0x000000018BF9FE48
		internal IStylePropertyAnimations styleAnimation { get => default; } // 0x000000018BAE3154-0x000000018BAE3180 
		internal bool isCompositeRoot { get => default; set {} } // 0x000000018BF9E88C-0x000000018BF9E954 0x0000000185FE9910-0x0000000185FE9920
		internal bool isHierarchyDisplayed { get => default; set {} } // 0x0000000185FE9980-0x0000000185FE9990 0x0000000185FE7CE0-0x0000000185FE7CF0
		public string viewDataKey { get => default; set {} } // 0x000000018BFA08B0-0x000000018BFA08F8 0x000000018BF9F754-0x000000018BF9F7F0
		internal bool enableViewDataPersistence { get => default; private set {} } // 0x000000018BF9F980-0x000000018BF9F9A4 0x000000018BFA00B8-0x000000018BFA00DC
		public object userData { get => default; set {} } // 0x0000000185FB6FD0-0x0000000185FB6FE0 0x0000000187A47AA0-0x0000000187A47AB4
		public override bool canGrabFocus { get => default; } // 0x0000000185FE98B0-0x0000000185FE98C0 
		public override FocusController focusController { get => default; } // 0x000000018BF9FA88-0x000000018BF9FA94 
		public UsageHints usageHints { get => default; set {} } // 0x000000018BF9FE74-0x000000018BF9FE80 0x000000018BFA0A08-0x000000018BFA0A38
		internal RenderHints renderHints { get => default; set {} } // 0x000000018BF97E28-0x000000018BF97E64 0x000000018BF9F27C-0x000000018BF9F56C
		public ITransform transform { get => default; } // 0x000000018BF998F8-0x000000018BF99924 
		Vector3 ITransform.position { get => default; set {} } // 0x000000018BF9C464-0x000000018BF9C52C 0x000000018BF98F7C-0x000000018BF98FF8
		Vector3 ITransform.scale { get => default; } // 0x000000018BF9B950-0x000000018BF9C224 
		internal bool isLayoutManual { get => default; private set {} } // 0x000000018BF9EE5C-0x000000018BF9EF90 0x000000018BF99924-0x000000018BF99B38
		internal float scaledPixelsPerPoint { get => default; } // 0x000000018BF9B3F8-0x000000018BF9B414 
		public Rect layout { get => default; internal set {} } // 0x000000018BF9B414-0x000000018BF9B42C 0x000000018BF99B9C-0x000000018BF99BBC
		public Rect contentRect { get => default; } // 0x000000018BF9B5B4-0x000000018BF9B88C 
		protected Rect paddingRect { get => default; } // 0x000000018BF9FAE4-0x000000018BF9FB4C 
		internal bool isBoundingBoxDirty { get => default; set {} } // 0x000000018BF9F950-0x000000018BF9F960 0x0000000185FE98D0-0x0000000185FE98E0
		internal bool isWorldBoundingBoxDirty { get => default; set {} } // 0x0000000185FE9960-0x0000000185FE9970 0x000000018BF9B88C-0x000000018BF9B8A4
		internal Rect boundingBox { get => default; } // 0x000000018BF9A3D8-0x000000018BF9A490 
		internal Rect worldBoundingBox { get => default; } // 0x000000018BFA0158-0x000000018BFA0178 
		private Rect boundingBoxInParentSpace { get => default; } // 0x000000018BFA0C78-0x000000018BFA0CE4 
		public Rect worldBound { get => default; } // 0x0000000187A479EC-0x0000000187A47A00 
		public Rect localBound { get => default; } // 0x000000018BF99CC4-0x000000018BF99E04 
		internal Rect rect { get => default; } // 0x000000018BF99194-0x000000018BF99224 
		internal bool isWorldTransformDirty { get => default; set {} } // 0x000000018BF99120-0x000000018BF99194 
		internal bool isWorldTransformInverseDirty { get => default; set {} } // 0x000000018BF9A084-0x000000018BF9A270 0x000000018BF9B38C-0x000000018BF9B3F8
		public Matrix4x4 worldTransform { get => default; } // 0x000000018BF99E24-0x000000018BF99EA8 
		internal ref Matrix4x4 worldTransformRef { get => default; } // 0x000000018BF9A010-0x000000018BF9A034 
		internal ref Matrix4x4 worldTransformInverse { get => default; } // 0x0000000185492010-0x0000000185492020 
		internal bool isWorldClipDirty { get => default; set {} } // 0x000000018BFA09A4-0x000000018BFA0A08 0x000000018BF96D78-0x000000018BF96E0C
		internal Rect worldClip { get => default; } // 0x000000018BF9ADD4-0x000000018BF9ADF8 
		internal Rect worldClipMinusGroup { get => default; } // 0x0000000185FE95C0-0x0000000185FE95E0 
		internal bool worldClipIsInfinite { get => default; } // 0x000000018BF99EC8-0x000000018BF9A000 
		internal PseudoStates pseudoStates { get => default; set {} } // 0x000000018BF96B40-0x000000018BF96CB4 0x000000018BF9AC74-0x000000018BF9AD68
		internal int containedPointerIds { get; private set; } // 0x000000018BF987FC-0x000000018BF98820 0x000000018BF98054-0x000000018BF980F0
		public PickingMode pickingMode { get; set; } // 0x000000018BF9C3FC-0x000000018BF9C464 0x000000018BF99B38-0x000000018BF99B9C
		public string name { get => default; set {} } // 0x000000018BF9CF64-0x000000018BF9D064 0x000000018BF97E64-0x000000018BF97FBC
		internal List<string> classList { get => default; } // 0x000000018BF9C224-0x000000018BF9C3FC 
		internal string fullTypeName { get => default; } // 0x000000018BF9E720-0x000000018BF9E88C 
		internal string typeName { get => default; } // 0x0000000185FE9940-0x0000000185FE9950 
		internal YogaNode yogaNode { get; private set; } // 0x0000000185FE98C0-0x0000000185FE98D0 0x000000018BF990B8-0x000000018BF99120
		internal ref ComputedStyle computedStyle { get => default; } // 0x000000018BF9AB38-0x000000018BF9AC10 
		internal bool hasInlineStyle { get => default; } // 0x000000018BF9E3C8-0x000000018BF9E43C 
		internal bool styleInitialized { get => default; set {} } // 0x000000018BF9E43C-0x000000018BF9E4A8 0x000000018BF9AC10-0x000000018BF9AC74
		private bool isParentEnabledInHierarchy { get => default; } // 0x0000000185FE9900-0x0000000185FE9910 
		public bool enabledInHierarchy { get => default; } // 0x0000000185FB0DD0-0x0000000185FB0DE0 
		public bool enabledSelf { get; private set; } // 0x000000018764FF50-0x000000018764FF64 0x0000000185FE98F0-0x0000000185FE9900
		public bool visible { get => default; set {} } // 0x000000018BF96CB4-0x000000018BF96D78 0x000000018BF99C2C-0x000000018BF99CC4
		public Action<MeshGenerationContext> generateVisualContent { get; set; } // 0x000000018BF987F0-0x000000018BF987FC 0x000000018BF9F56C-0x000000018BF9F5D8
		internal bool requireMeasureFunction { get => default; set {} } // 0x000000018BF98610-0x000000018BF9867C
		internal RenderTargetMode subRenderTargetMode { get => default; } // 0x0000000185FE4FC0-0x0000000185FE5050 
		internal Material defaultMaterial { get => default; } // 0x0000000185FE7B10-0x0000000185FE7B20 
		public IExperimentalFeatures experimental { get => default; } // 0x000000018BF9AFB0-0x000000018BF9B04C 
		ITransitionAnimations IExperimentalFeatures.animation { get => default; } // 0x000000018BF9FF00-0x000000018BF9FF7C 
		public Hierarchy hierarchy { get; private set; } // 0x000000018BFA0A38-0x000000018BFA0B38 0x000000018BF9FF7C-0x000000018BFA00B8
		internal bool isRootVisualContainer { get; set; } // 0x0000000185779060-0x0000000185779070 0x000000018BF9D150-0x000000018BF9D17C
		internal bool disableClipping { get => default; set {} } // 0x000000018BF9D17C-0x000000018BF9D1A8 0x000000018BF9D1A8-0x000000018BF9D1CC
		public VisualElement parent { get => default; } // 0x000000018BF9D1F0-0x000000018BF9D214 
		internal BaseVisualElementPanel elementPanel { get; private set; } // 0x000000018BF9D214-0x000000018BF9D240 0x000000018BF9D240-0x000000018BF9D264
		public IPanel panel { get => default; } // 0x000000018BF9D264-0x000000018BF9D290 
		public virtual VisualElement contentContainer { get => default; } // 0x000000018BF9D290-0x000000018BF9D2B4 
		internal VisualTreeAsset visualTreeAssetSource { set {} } // 0x000000018BF9D2B4-0x000000018BF9D2E0
		public VisualElement this[int key] { get => default; } // 0x000000018BF9D370-0x000000018BF9D39C 
		public int childCount { get => default; } // 0x000000018BF9D39C-0x000000018BF9D3AC 
		private Vector3 positionWithLayout { get => default; } // 0x000000018BF9D604-0x000000018BF9D628 
		internal bool hasDefaultRotationAndScale { get => default; } // 0x000000018BF9D658-0x000000018BF9D688 
		public IVisualElementScheduler schedule { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public IStyle style { get => default; } // 0x000000018BF96480-0x000000018BF969A4 
		public ICustomStyle customStyle { get => default; } // 0x000000018BF943B0-0x000000018BF943D0 
		public VisualElementStyleSheetSet styleSheets { get => default; } // 0x000000018646FE2C-0x000000018646FE34 
		public string tooltip { get => default; set {} } // 0x000000018BF941F8-0x000000018BF94284 0x000000018BF93B28-0x000000018BF93C14
		private TypeData typeData { get => default; } // 0x000000018BF93A24-0x000000018BF93B28 
		public IResolvedStyle resolvedStyle { get => default; } // 0x000000018BF94368-0x000000018BF943B0 
		UnityEngine.Color IResolvedStyle.backgroundColor { get => default; } // 0x000000018BF94308-0x000000018BF94368 
		UnityEngine.Color IResolvedStyle.borderBottomColor { get => default; } // 0x000000018BF93680-0x000000018BF936E0 
		float IResolvedStyle.borderBottomLeftRadius { get => default; } // 0x000000018BF93608-0x000000018BF93614 
		float IResolvedStyle.borderBottomRightRadius { get => default; } // 0x000000018BF9320C-0x000000018BF9322C 
		float IResolvedStyle.borderBottomWidth { get => default; } // 0x000000018BF94284-0x000000018BF94308 
		UnityEngine.Color IResolvedStyle.borderLeftColor { get => default; } // 0x000000018BF93C14-0x000000018BF93D1C 
		float IResolvedStyle.borderLeftWidth { get => default; } // 0x000000018BF94044-0x000000018BF940C0 
		UnityEngine.Color IResolvedStyle.borderRightColor { get => default; } // 0x000000018BF93D1C-0x000000018BF93DF4 
		float IResolvedStyle.borderRightWidth { get => default; } // 0x000000018BE97160-0x000000018BE97168 
		UnityEngine.Color IResolvedStyle.borderTopColor { get => default; } // 0x000000018BF93614-0x000000018BF93680 
		float IResolvedStyle.borderTopLeftRadius { get => default; } // 0x0000000189289CE0-0x0000000189289D04 
		float IResolvedStyle.borderTopRightRadius { get => default; } // 0x000000018406FBE0-0x000000018406FBF0 
		float IResolvedStyle.borderTopWidth { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		float IResolvedStyle.bottom { get => default; } // 0x0000000185A16440-0x0000000185A16450 
		UnityEngine.Color IResolvedStyle.color { get => default; } // 0x000000018BF92630-0x000000018BF9264C 
		DisplayStyle IResolvedStyle.display { get => default; } // 0x000000018BF92590-0x000000018BF92630 
		FlexDirection IResolvedStyle.flexDirection { get => default; } // 0x0000000185FE9560-0x0000000185FE9570 
		float IResolvedStyle.flexGrow { get => default; } // 0x000000018BF92308-0x000000018BF923A4 
		float IResolvedStyle.flexShrink { get => default; } // 0x000000018BF923DC-0x000000018BF9240C 
		float IResolvedStyle.height { get => default; } // 0x000000018BF9256C-0x000000018BF92590 
		float IResolvedStyle.left { get => default; } // 0x000000018BF92548-0x000000018BF9256C 
		float IResolvedStyle.marginBottom { get => default; } // 0x000000018BF923A4-0x000000018BF923DC 
		float IResolvedStyle.marginLeft { get => default; } // 0x000000018BF9240C-0x000000018BF924B0 
		float IResolvedStyle.marginRight { get => default; } // 0x000000018BF924B0-0x000000018BF92548 
		float IResolvedStyle.marginTop { get => default; } // 0x000000018BF922CC-0x000000018BF92308 
		StyleFloat IResolvedStyle.minHeight { get => default; }
		StyleFloat IResolvedStyle.minWidth { get => default; } // 0x000000018BF96014-0x000000018BF9606C 
		float IResolvedStyle.opacity { get => default; } // 0x000000018BF95FDC-0x000000018BF96014 
		float IResolvedStyle.paddingBottom { get => default; } // 0x000000018BF95500-0x000000018BF95558 
		float IResolvedStyle.paddingLeft { get => default; } // 0x000000018BF954D8-0x000000018BF95500 
		float IResolvedStyle.paddingRight { get => default; } // 0x00000001879072B0-0x00000001879072D0 
		float IResolvedStyle.paddingTop { get => default; } // 0x000000018BF92D20-0x000000018BF92DC8 
		float IResolvedStyle.right { get => default; } // 0x000000018BF92AA8-0x000000018BF92B5C 
		Scale IResolvedStyle.scale { get => default; } // 0x000000018BF92964-0x000000018BF92AA8 
		float IResolvedStyle.top { get => default; } // 0x000000018BF92B5C-0x000000018BF92C78 
		Vector3 IResolvedStyle.transformOrigin { get => default; } // 0x000000018BF92EE4-0x000000018BF93004 
		Vector3 IResolvedStyle.translate { get => default; } // 0x000000018BF92DC8-0x000000018BF92EE4 
		UnityEngine.Color IResolvedStyle.unityBackgroundImageTintColor { get => default; } // 0x000000018BF93004-0x000000018BF930D0 
		int IResolvedStyle.unitySliceLeft { get => default; } // 0x000000018BF92C78-0x000000018BF92D20 
		int IResolvedStyle.unitySliceRight { get => default; } // 0x000000018BF928A4-0x000000018BF92964 
		UnityEngine.Color IResolvedStyle.unityTextOutlineColor { get => default; } // 0x0000000185492010-0x0000000185492020 
		float IResolvedStyle.unityTextOutlineWidth { get => default; } // 0x000000018346D130-0x000000018346D140 
		Visibility IResolvedStyle.visibility { get => default; } // 0x000000018BFE8BC8-0x000000018BFE8C48 
		WhiteSpace IResolvedStyle.whiteSpace { get => default; } // 0x000000018BFE8C48-0x000000018BFE8C90 
		float IResolvedStyle.width { get => default; } // 0x000000018BFE8C90-0x000000018BFE8D38 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits> // TypeDefIndex: 44241
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018BF9FA94-0x000000018BF9FAB4
		}
	
		public class UxmlTraits : UIElements.UxmlTraits // TypeDefIndex: 44242
		{
			// Fields
			protected UxmlStringAttributeDescription m_Name; // 0x18
			private UxmlStringAttributeDescription m_ViewDataKey; // 0x20
			protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode; // 0x28
			private UxmlStringAttributeDescription m_Tooltip; // 0x30
			private UxmlEnumAttributeDescription<UsageHints> m_UsageHints; // 0x38
			private UxmlIntAttributeDescription _focusIndex_k__BackingField; // 0x40
			private UxmlIntAttributeDescription m_TabIndex; // 0x48
			private UxmlBoolAttributeDescription _focusable_k__BackingField; // 0x50
			private UxmlStringAttributeDescription m_Class; // 0x58
			private UxmlStringAttributeDescription m_ContentContainer; // 0x60
			private UxmlStringAttributeDescription m_Style; // 0x68
	
			// Properties
			protected UxmlIntAttributeDescription focusIndex { get; } // 0x000000018BF9F9A4-0x000000018BF9F9C4 
			protected UxmlBoolAttributeDescription focusable { get; } // 0x00000001813CFF60-0x00000001813CFF70 
	
			// Constructors
			public UxmlTraits() {} // 0x0000000185FB07C0-0x0000000185FB07D0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x00000001813D0A90-0x00000001813D0AA0
		}
	
		public enum MeasureMode // TypeDefIndex: 44243
		{
			Undefined = 0,
			Exactly = 1,
			AtMost = 2
		}
	
		internal enum RenderTargetMode // TypeDefIndex: 44244
		{
			None = 0,
			NoColorConversion = 1,
			LinearToGamma = 2,
			GammaToLinear = 3
		}
	
		public struct Hierarchy // TypeDefIndex: 44245
		{
			// Fields
			private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation"; // Metadata: 0x0205B504
			private readonly VisualElement m_Owner; // 0x00
	
			// Properties
			public VisualElement parent { get => default; } // 0x0000000185FB07E0-0x0000000185FB07F0 
			public int childCount { get => default; } // 0x000000018BF9DF14-0x000000018BF9DFDC 
			public VisualElement this[int key] { get => default; } // 0x000000018BF9DBD8-0x000000018BF9DC74 
	
			// Constructors
			internal Hierarchy(VisualElement element) : this() {
				m_Owner = default;
			} // 0x000000018BF998D4-0x000000018BF998F8
	
			// Methods
			public void Add(VisualElement child) {} // 0x0000000185779060-0x0000000185779070
			public void Insert(int index, VisualElement child) {} // 0x000000018BF9DB54-0x000000018BF9DBD8
			public void Remove(VisualElement child) {} // 0x000000018BF9D91C-0x000000018BF9D99C
			public void RemoveAt(int index) {} // 0x000000018BF9DA1C-0x000000018BF9DA9C
			public void Clear() {} // 0x000000018BF9DD24-0x000000018BF9DDC0
			internal void BringToFront(VisualElement child) {} // 0x000000018BF9D91C-0x000000018BF9D99C
			internal void SendToBack(VisualElement child) {} // 0x000000018BF9DFDC-0x000000018BF9E090
			internal void PlaceBehind(VisualElement child, VisualElement over) {} // 0x000000018BF9DE78-0x000000018BF9DF14
			private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) {} // 0x000000018BF9D99C-0x000000018BF9DA1C
			public int IndexOf(VisualElement element) => default; // 0x000000018BF9DDC0-0x000000018BF9DE78
			public VisualElement ElementAt(int index) => default; // 0x000000018BF9DA9C-0x000000018BF9DB54
			public IEnumerable<VisualElement> Children() => default; // 0x000000018BF9DC74-0x000000018BF9DD24
			private void SetParent(VisualElement value) {} // 0x000000018BF9D7EC-0x000000018BF9D878
			private void PutChildAtIndex(VisualElement child, int index) {} // 0x000000018BF9D754-0x000000018BF9D7EC
			private void RemoveChildAtIndex(int index) {} // 0x000000018BF9E090-0x000000018BF9E124
			private void ReleaseChildList() {} // 0x000000018BF9D878-0x000000018BF9D91C
			public bool Equals(Hierarchy other) => default; // 0x000000018BF9CC04-0x000000018BF9CE14
			public override bool Equals(object obj) => default; // 0x000000018BF9CE14-0x000000018BF9CEBC
			public override int GetHashCode() => default; // 0x000000018BF9CEBC-0x000000018BF9CF64
			public static bool operator ==(Hierarchy x, Hierarchy y) => default; // 0x000000018BF99318-0x000000018BF99584
		}
	
		private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem, IVisualElementPanelActivatable // TypeDefIndex: 44246
		{
			// Fields
			private VisualElement _element_k__BackingField; // 0x38
			public bool isScheduled; // 0x40
			private VisualElementPanelActivator m_Activator; // 0x48
	
			// Properties
			public VisualElement element { get; private set; } // 0x000000018BF9FAC0-0x000000018BF9FACC 0x000000018BFA0470-0x000000018BFA049C
			public bool isActive { get; } // 0x000000018BF9FACC-0x000000018BF9FAD8 
	
			// Constructors
			protected BaseVisualElementScheduledItem() {} // Dummy constructor
			protected BaseVisualElementScheduledItem(VisualElement handler) {} // 0x000000018BFA049C-0x000000018BFA04CC
	
			// Methods
			public IVisualElementScheduledItem StartingIn(long delayMs) => default; // 0x0000000185FE8BB0-0x0000000185FE8BC0
			public IVisualElementScheduledItem Every(long intervalMs) => default; // 0x000000018BFA0C24-0x000000018BFA0C78
			internal override void OnItemUnscheduled() {} // 0x000000018BF9F944-0x000000018BF9F950
			public void Resume() {} // 0x000000018BFA0414-0x000000018BFA0444
			public void Pause() {} // 0x000000018BFA00F4-0x000000018BFA0158
			public void ExecuteLater(long delayMs) {} // 0x000000018BFA0BC0-0x000000018BFA0C24
			public void OnPanelActivate() {} // 0x000000018BF9F674-0x000000018BF9F6F4
			public void OnPanelDeactivate() {} // 0x000000018BF9F960-0x000000018BF9F980
			public bool CanBeActivated() => default; // 0x000000018BFA00DC-0x000000018BFA00F4
		}
	
		private abstract class VisualElementScheduledItem<ActionType> : BaseVisualElementScheduledItem // TypeDefIndex: 44247
		{
			// Fields
			public ActionType updateEvent;
	
			// Constructors
			protected VisualElementScheduledItem() {} // Dummy constructor
			public VisualElementScheduledItem(VisualElement handler, ActionType upEvent) {} // 0x000000018BFA0B38-0x000000018BFA0BC0
		}
	
		private class TimerStateScheduledItem : VisualElementScheduledItem<Action<UnityEngine.UIElements.TimerState>> // TypeDefIndex: 44248
		{
			// Constructors
			public TimerStateScheduledItem() {} // Dummy constructor
			public TimerStateScheduledItem(VisualElement handler, Action<UnityEngine.UIElements.TimerState> updateEvent) {} // 0x0000000185FE9930-0x0000000185FE9940
	
			// Methods
			public override void PerformTimerUpdate(UnityEngine.UIElements.TimerState state) {} // 0x000000018BFA0964-0x000000018BFA09A4
		}
	
		private class SimpleScheduledItem : VisualElementScheduledItem<Action> // TypeDefIndex: 44249
		{
			// Constructors
			public SimpleScheduledItem() {} // Dummy constructor
			public SimpleScheduledItem(VisualElement handler, Action updateEvent) {} // 0x0000000185FE95E0-0x0000000185FE95F0
	
			// Methods
			public override void PerformTimerUpdate(UnityEngine.UIElements.TimerState state) {} // 0x0000000185FE7B10-0x0000000185FE7B20
		}
	
		internal class CustomStyleAccess : ICustomStyle // TypeDefIndex: 44250
		{
			// Fields
			private Dictionary<string, StylePropertyValue> m_CustomProperties; // 0x10
			private float m_DpiScaling; // 0x18
	
			// Constructors
			public CustomStyleAccess() {} // 0x000000018BF9FC6C-0x000000018BF9FD34
	
			// Methods
			public void SetContext(Dictionary<string, StylePropertyValue> customProperties, float dpiScaling) {} // 0x000000018BF9E124-0x000000018BF9E164
			public bool TryGetValue(CustomStyleProperty<float> property, out float value) {
				value = default;
				return default;
			} // 0x000000018BF9E1A4-0x000000018BF9E268
			public bool TryGetValue(CustomStyleProperty<int> property, out int value) {
				value = default;
				return default;
			} // 0x000000018BF9E164-0x000000018BF9E1A4
			public bool TryGetValue(CustomStyleProperty<UnityEngine.Color> property, out UnityEngine.Color value) {
				value = default;
				return default;
			} // 0x000000018BF9FAD8-0x000000018BF9FAE4
			public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) {
				value = default;
				return default;
			} // 0x000000018BFA04CC-0x000000018BFA04F8
			public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) {
				value = default;
				return default;
			} // 0x000000018BF9FE54-0x000000018BF9FE74
			public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) {
				value = default;
				return default;
			} // 0x000000018BF9FB6C-0x000000018BF9FC1C
			public bool TryGetValue(CustomStyleProperty<string> property, out string value) {
				value = default;
				return default;
			} // 0x000000018BFA0550-0x000000018BFA08B0
			private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp) {
				customProp = default;
				return default;
			} // 0x000000018BF980F0-0x000000018BF98310
			private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) {} // 0x000000018BF9F7F0-0x000000018BF9F8B8
		}
	
		private class TypeData // TypeDefIndex: 44251
		{
			// Fields
			private readonly System.Type _type_k__BackingField; // 0x10
			private string m_FullTypeName; // 0x18
			private string m_TypeName; // 0x20
	
			// Properties
			public System.Type type { get; } // 0x000000018BF9FAB4-0x000000018BF9FAC0 
			public string fullTypeName { get => default; } // 0x000000018BF9FB4C-0x000000018BF9FB58 
			public string typeName { get => default; } // 0x000000018BFA04F8-0x000000018BFA0524 
	
			// Constructors
			public TypeData() {} // Dummy constructor
			public TypeData(System.Type type) {} // 0x000000018BFA0444-0x000000018BFA0470
		}
	
		private sealed class __c__DisplayClass322_0 // TypeDefIndex: 44252
		{
			// Fields
			public VisualElement __4__this; // 0x10
			public StyleValues to; // 0x18
	
			// Constructors
			public __c__DisplayClass322_0() {} // 0x000000018BF9F628-0x000000018BF9F674
	
			// Methods
			internal StyleValues _UnityEngine.UIElements.Experimental.ITransitionAnimations.Start_b__0(VisualElement e) => default; // 0x000000018BFA0200-0x000000018BFA0254
		}
	
		// Constructors
		public VisualElement() {} // 0x000000018BF96E0C-0x000000018BF97AD4
		static VisualElement() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() => default; // 0x000000018B2B1568-0x000000018B2B1570
		bool IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BF9FB64-0x000000018BF9FB6C
		bool IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BAE3180-0x000000018BAE31AC
		bool IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFA0380-0x000000018BFA03E4
		bool IStylePropertyAnimations.Start(StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFA0354-0x000000018BFA0380
		bool IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFA0328-0x000000018BFA0354
		bool IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BF9ECB8-0x000000018BF9EE5C
		bool IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BF9EC4C-0x000000018BF9ECB8
		bool IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BF9FB58-0x000000018BF9FB64
		bool IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFA0524-0x000000018BFA0550
		bool IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFA02DC-0x000000018BFA0328
		bool IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFA0290-0x000000018BFA02DC
		bool IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFA0254-0x000000018BFA0290
		bool IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BF98820-0x000000018BF9885C
		void IStylePropertyAnimations.CancelAnimation(StylePropertyId id) {} // 0x000000018BF9E9CC-0x000000018BF9EC4C
		void IStylePropertyAnimations.CancelAllAnimations() {} // 0x000000018BF98360-0x000000018BF983EC
		void IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) {} // 0x000000018BF9C6B8-0x000000018BF9C890
		void IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds) {} // 0x000000018BF983EC-0x000000018BF985CC
		internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0 /* Metadata: 0x0205B4E7 */) => default; // 0x0000000185FE9920-0x0000000185FE9930
		internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) => default; // 0x000000018BFA08F8-0x000000018BFA0964
		internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to) => default; // 0x0000000185FCD800-0x0000000185FCD810
		private float? GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0 /* Metadata: 0x0205B4E8 */) => default; // 0x0000000185FE9950-0x0000000185FE9960
		internal void MarkRenderHintsClean() {} // 0x000000018BF9885C-0x000000018BF98CA8
		internal void ClearManualLayout() {} // 0x000000018BF99E04-0x000000018BF99E24
		internal void UpdateBoundingBox() {} // 0x000000018BF99EA8-0x000000018BF99EB8
		internal void UpdateWorldBoundingBox() {} // 0x0000000185FB7010-0x0000000185FB7020
		internal void UpdateWorldTransform() {} // 0x000000018BF985CC-0x000000018BF98610
		internal void UpdateWorldTransformInverse() {} // 0x000000018BF9FE48-0x000000018BF9FE54
		internal void EnsureWorldTransformAndClipUpToDate() {} // 0x000000018BF98CA8-0x000000018BF98D14
		private void UpdateWorldClip() {} // 0x000000018BF9B8A4-0x000000018BF9B950
		private Rect CombineClipRects(Rect rect, Rect parentRect) => default; // 0x000000018BF9B498-0x000000018BF9B5B4
		private Rect SubstractBorderPadding(Rect worldRect) => default; // 0x000000018BF9C890-0x000000018BF9C9EC
		internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) => default; // 0x0000000185FE8B00-0x0000000185FE8B10
		private void UpdateHoverPseudoState() {} // 0x000000018BF997E8-0x000000018BF99850
		private void ChangeIMGUIContainerCount(int delta) {}
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x000000018BF9A490-0x000000018BF9AB38
		internal virtual Rect GetTooltipRect() => default; // 0x000000018BF9D074-0x000000018BF9D150
		private void SetTooltip(TooltipEvent e) {} // 0x000000018BF9C55C-0x000000018BF9C6B8
		public sealed override void Focus() {} // 0x0000000185FE7B10-0x0000000185FE7B20
		internal void SetPanel(BaseVisualElementPanel p) {} // 0x0000000185FE7B10-0x0000000185FE7B20
		private void WillChangePanel(BaseVisualElementPanel destinationPanel) {} // 0x0000000185FB7030-0x0000000185FB7040
		private void HasChangedPanel(BaseVisualElementPanel prevPanel) {} // 0x0000000187A47B18-0x0000000187A47B2C
		public sealed override void SendEvent(EventBase e) {} // 0x0000000185FE98E0-0x0000000185FE98F0
		internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode) {} // 0x0000000185FE9970-0x0000000185FE9980
		internal void IncrementVersion(VersionChangeType changeType) {} // 0x000000018BF9F938-0x000000018BF9F944
		internal void InvokeHierarchyChanged(HierarchyChangeType changeType) {} // 0x000000018BFA03E4-0x000000018BFA0414
		private bool SetEnabledFromHierarchyPrivate(bool state) => default; // 0x000000018BF9C52C-0x000000018BF9C55C
		public void SetEnabled(bool value) {} // 0x0000000185FE7B10-0x0000000185FE7B20
		private void PropagateEnabledToChildren(bool value) {} // 0x0000000187A47AF0-0x0000000187A47B04
		public void MarkDirtyRepaint() {} // 0x000000018BF98310-0x000000018BF98360
		internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) {} // 0x000000018BF9F6F4-0x000000018BF9F754
		internal void GetFullHierarchicalViewDataKey(StringBuilder key) {} // 0x000000018BF99BBC-0x000000018BF99C2C
		internal string GetFullHierarchicalViewDataKey() => default; // 0x000000018BF9867C-0x000000018BF987F0
		internal T GetOrCreateViewData<T>(object existing, string key)
			where T : class, new() => default; // 0x000000018BF98E98-0x000000018BF98F7C
		internal void OverwriteFromViewData(object obj, string key) {} // 0x000000018BF97FBC-0x000000018BF98054
		internal void SaveViewData() {} // 0x000000018BF97AD4-0x000000018BF97B40
		internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState) => default; // 0x000000018BF9B42C-0x000000018BF9B498
		internal void OnViewDataReady(bool enablePersistence) {} // 0x000000018BF9A270-0x000000018BF9A3D8
		internal virtual void OnViewDataReady() {} // 0x000000018BF9AD68-0x000000018BF9ADD4
		public virtual bool ContainsPoint(Vector2 localPoint) => default;
		private void AssignMeasureFunction() {} // 0x000000018BF98FF8-0x000000018BF990B8
		private void RemoveMeasureFunction() {} // 0x000000018BF98D14-0x000000018BF98E98
		protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x000000018BF99890-0x000000018BF998D4
		internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) => default; // 0x000000018BF99850-0x000000018BF99890
		private void FinalizeLayout() {} // 0x000000018BF99224-0x000000018BF99318
		internal void SetInlineRule(StyleSheet sheet, StyleRule rule) {} // 0x000000018BF99708-0x000000018BF997E8
		internal void SetComputedStyle(ref ComputedStyle newStyle) {} // 0x000000018BF9B318-0x000000018BF9B38C
		public override string ToString() => default; // 0x000000018BF9FD34-0x000000018BF9FDF4
		internal List<string> GetClassesForIteration() => default; // 0x000000018BF99584-0x000000018BF99708
		public void AddToClassList(string className) {} // 0x000000018BF9F9C4-0x000000018BF9FA88
		public void RemoveFromClassList(string className) {} // 0x000000018BF9A000-0x000000018BF9A010
		public void EnableInClassList(string className, bool enable) {} // 0x000000018BF99EB8-0x000000018BF99EC8
		public bool ClassListContains(string cls) => default; // 0x000000018BF9C9EC-0x000000018BF9CB04
		internal object GetProperty(PropertyName key) => default; // 0x000000018BF97B40-0x000000018BF97E28
		internal void SetProperty(PropertyName key, object value) {} // 0x000000018BF9CB04-0x000000018BF9CB78
		internal bool HasProperty(PropertyName key) => default; // 0x000000018BF9A034-0x000000018BF9A084
		private bool TryGetPropertyInternal(PropertyName key, out object value) {
			value = default;
			return default;
		} // 0x0000000185FE9820-0x0000000185FE9870
		private static void CheckUserKeyArgument(PropertyName key) {} // 0x0000000185FE9870-0x0000000185FE98B0
		private void SetPropertyInternal(PropertyName key, object value) {} // 0x0000000185FE95F0-0x0000000185FE9820
		private void UpdateCursorStyle(long eventType) {} // 0x000000018BF9CB78-0x000000018BF9CC04
		private VisualElementAnimationSystem GetAnimationSystem() => default; // 0x000000018BF9E268-0x000000018BF9E318
		internal void RegisterAnimation(IValueAnimationUpdate anim) {} // 0x000000018BF9E318-0x000000018BF9E3C8
		internal void UnregisterAnimation(IValueAnimationUpdate anim) {} // 0x000000018BF9FE80-0x000000018BF9FF00
		private void UnregisterRunningAnimations() {} // 0x000000018BF9F8B8-0x000000018BF9F938
		private void RegisterRunningAnimations() {} // 0x0000000184759830-0x0000000184759850
		private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged) => default; // 0x000000018BF969A4-0x000000018BF96B40
		private static void AssignStyleValues(VisualElement ve, StyleValues src) {} // 0x000000018BF9ADF8-0x000000018BF9AEF0
		private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) => default; // 0x000000018BF9B1CC-0x000000018BF9B318
		ValueAnimation<StyleValues> ITransitionAnimations.Start(StyleValues to, int durationMs) => default; // 0x000000018BF9B04C-0x000000018BF9B1CC
		private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs) => default; // 0x000000018BF9AEF0-0x000000018BF9AFB0
		internal bool ShouldClip() => default; // 0x000000018BF9D1CC-0x000000018BF9D1F0
		public void Add(VisualElement child) {} // 0x000000018BF9D2E0-0x000000018BF9D304
		public void Insert(int index, VisualElement element) {} // 0x000000018BF9D304-0x000000018BF9D328
		public void Clear() {} // 0x000000018BF9D328-0x000000018BF9D34C
		public VisualElement ElementAt(int index) => default; // 0x000000018BF9D34C-0x000000018BF9D370
		public int IndexOf(VisualElement element) => default; // 0x000000018BF9D3AC-0x000000018BF9D3BC
		internal VisualElement ElementAtTreePath(List<int> childIndexes) => default; // 0x000000018BF9D3BC-0x000000018BF9D3CC
		internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes) => default; // 0x000000018BF9D3CC-0x000000018BF9D3DC
		public IEnumerable<VisualElement> Children() => default; // 0x000000018BF9D3DC-0x000000018BF9D400
		public void BringToFront() {} // 0x000000018BF9D400-0x000000018BF9D424
		public void SendToBack() {} // 0x000000018BF9D424-0x000000018BF9D448
		public void PlaceBehind(VisualElement sibling) {} // 0x000000018BF9D448-0x000000018BF9D46C
		public void RemoveFromHierarchy() {} // 0x000000018BF9D46C-0x000000018BF9D490
		public T GetFirstOfType<T>()
			where T : class => default; // 0x000000018BF9D490-0x000000018BF9D4B4
		public T GetFirstAncestorOfType<T>()
			where T : class => default; // 0x000000018BF9D4B4-0x000000018BF9D4E4
		public bool Contains(VisualElement child) => default; // 0x000000018BF9D4E4-0x000000018BF9D514
		private void GatherAllChildren(List<VisualElement> elements) {} // 0x000000018BF9D514-0x000000018BF9D524
		public VisualElement FindCommonAncestor(VisualElement other) => default; // 0x000000018BF9D524-0x000000018BF9D548
		internal VisualElement GetRoot() => default; // 0x000000018BF9D548-0x000000018BF9D56C
		internal VisualElement GetRootVisualContainer() => default; // 0x000000018BF9D56C-0x000000018BF9D590
		internal VisualElement GetNextElementDepthFirst() => default; // 0x000000018BF9D590-0x000000018BF9D5B4
		internal VisualElement GetPreviousElementDepthFirst() => default; // 0x000000018BF9D5B4-0x000000018BF9D5D8
		internal VisualElement RetargetElement(VisualElement retargetAgainst) => default; // 0x000000018BF9D5D8-0x000000018BF9D604
		internal void GetPivotedMatrixWithLayout(out Matrix4x4 result) {
			result = default;
		} // 0x000000018BF9D628-0x000000018BF9D658
		internal static float Min(float a, float b, float c, float d) => default; // 0x000000018BF9D688-0x000000018BF9D6B4
		internal static float Max(float a, float b, float c, float d) => default; // 0x000000018BF9D6B4-0x000000018BF9D6C4
		private void TransformAlignedRectToParentSpace(ref Rect rect) {} // 0x000000018BF9D6C4-0x000000018BF9D6D4
		internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) => default; // 0x000000018BF9D6D4-0x000000018BF9D700
		internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) {} // 0x000000018BF9D700-0x000000018BF9D710
		internal static void OrderMinMaxRect(ref Rect rect) {} // 0x000000018BF9D710-0x000000018BF9D720
		internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) => default; // 0x000000018BF9D720-0x000000018BF9D730
		internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) => default; // 0x000000018BF9D730-0x000000018BF9D754
		internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) {
			res = default;
		} // 0x000000018BF9EF90-0x000000018BF9F27C
		private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) {
			res = default;
		} // 0x000000018BF9D064-0x000000018BF9D074
		private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) {} // 0x000000018BF961D8-0x000000018BF96214
		IVisualElementScheduledItem IVisualElementScheduler.Execute(Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) => default; // 0x0000000181460F60-0x0000000181460F70
		IVisualElementScheduledItem IVisualElementScheduler.Execute(Action updateEvent) => default; // 0x000000018BF96214-0x000000018BF96480
		internal void AddStyleSheetPath(string sheetPath) {} // 0x000000018BF930D0-0x000000018BF9315C
		private StyleFloat ResolveLengthValue(Length length, bool isRow) => default; // 0x000000018BF936E0-0x000000018BF93A24
		private Vector3 ResolveTranslate() => default; // 0x000000018BF940C0-0x000000018BF941F8
		private Vector3 ResolveTransformOrigin() => default; // 0x000000018BF93DF4-0x000000018BF94044
		private Quaternion ResolveRotation() => default; // 0x000000018BF9322C-0x000000018BF93608
		private Vector3 ResolveScale() => default; // 0x000000018BF9315C-0x000000018BF9320C
		private YogaSize _AssignMeasureFunction_b__262_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode) => default; // 0x000000018BFE904C-0x000000018BFE9074
	}

	internal interface IStylePropertyAnimationSystem // TypeDefIndex: 44254
	{
		// Methods
		bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<float, float> easingCurve);
		void CancelAllAnimations();
		void CancelAllAnimations(VisualElement owner);
		void CancelAnimation(VisualElement owner, StylePropertyId id);
		void UpdateAnimation(VisualElement owner, StylePropertyId id);
		void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds);
		void Update();
	}

	internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem // TypeDefIndex: 44279
	{
		// Fields
		private long m_CurrentTimeMs; // 0x10
		private ValuesFloat m_Floats; // 0x18
		private ValuesInt m_Ints; // 0x20
		private ValuesLength m_Lengths; // 0x28
		private ValuesColor m_Colors; // 0x30
		private ValuesBackground m_Backgrounds; // 0x38
		private ValuesFontDefinition m_FontDefinitions; // 0x40
		private ValuesFont m_Fonts; // 0x48
		private ValuesTextShadow m_TextShadows; // 0x50
		private ValuesScale m_Scale; // 0x58
		private ValuesRotate m_Rotate; // 0x60
		private ValuesTranslate m_Translate; // 0x68
		private ValuesTransformOrigin m_TransformOrigin; // 0x70
		private readonly List<Values> m_AllValues; // 0x78
		private readonly Dictionary<StylePropertyId, Values> m_PropertyToValues; // 0x80
	
		// Nested types
		private enum TransitionState // TypeDefIndex: 44255
		{
			None = 0,
			Running = 1,
			Started = 2,
			Ended = 4,
			Canceled = 8
		}
	
		private struct AnimationDataSet<TTimingData, TStyleData> // TypeDefIndex: 44256
		{
			// Fields
			public VisualElement[] elements;
			public StylePropertyId[] properties;
			public TTimingData[] timing;
			public TStyleData[] style;
			public int count;
			private Dictionary<ElementPropertyPair, int> indices;
	
			// Properties
			private int capacity { get => default; set {} }
	
			// Methods
			private void LocalInit() {}
			public static AnimationDataSet<TTimingData, TStyleData> Create() => default; // 0x000000018BFE6FDC-0x000000018BFE70A0
			public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index) {
				index = default;
				return default;
			} // 0x000000018BFE6D10-0x000000018BFE6DD0
			public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) {} // 0x000000018BFE6A7C-0x000000018BFE6B40
			public void Remove(int cancelledIndex) {}
			public void Replace(int index, TTimingData timingData, TStyleData styleData) {} // 0x000000018BFE68A8-0x000000018BFE69A0
			public void RemoveAll(VisualElement ve) {} // 0x000000018BFE69A0-0x000000018BFE6A7C
			public void RemoveAll() {} // 0x000000018BFE717C-0x000000018BFE7240
			public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties) {} // 0x000000018BFE6ECC-0x000000018BFE6FDC
		}
	
		private struct ElementPropertyPair // TypeDefIndex: 44258
		{
			// Fields
			public static readonly IEqualityComparer<ElementPropertyPair> Comparer; // 0x00
			public readonly VisualElement element; // 0x00
			public readonly StylePropertyId property; // 0x08
	
			// Nested types
			private class EqualityComparer : IEqualityComparer<ElementPropertyPair> // TypeDefIndex: 44257
			{
				// Constructors
				public EqualityComparer() {} // 0x000000018BFE7240-0x000000018BFE733C
	
				// Methods
				public bool Equals(ElementPropertyPair x, ElementPropertyPair y) => default; // 0x000000018BFE70A0-0x000000018BFE717C
				public int GetHashCode(ElementPropertyPair obj) => default; // 0x000000018BFE6DD0-0x000000018BFE6ECC
			}
	
			// Constructors
			public ElementPropertyPair(VisualElement element, StylePropertyId property) {
				this.element = default;
				this.property = default;
			} // 0x000000018BFE6C1C-0x000000018BFE6D10
			static ElementPropertyPair() {
				Comparer = default;
			} // 0x000000018BFE6444-0x000000018BFE6554
		}
	
		private abstract class Values // TypeDefIndex: 44259
		{
			// Constructors
			protected Values() {}
	
			// Methods
			public abstract void CancelAllAnimations(); // 0x000000018BFE6554-0x000000018BFE66D0
			public abstract void CancelAllAnimations(VisualElement ve); // 0x000000018BFE66D0-0x000000018BFE6760
			public abstract void CancelAnimation(VisualElement ve, StylePropertyId id); // 0x000000018BFE733C-0x000000018BFE73CC
			public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id); // 0x000000018BFE6760-0x000000018BFE68A8
			public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds);
			public abstract void Update(long currentTimeMs); // 0x0000000185FC7990-0x0000000185FC79A0
			protected abstract void UpdateValues(); // 0x000000018BFE73CC-0x000000018BFE7484
			protected abstract void UpdateComputedStyle();
			protected abstract void UpdateComputedStyle(int i);
		}
	
		private abstract class Values<T> : Values // TypeDefIndex: 44265
		{
			// Fields
			private long m_CurrentTimeMs;
			private TransitionEventsFrameState m_CurrentFrameEventsState;
			private TransitionEventsFrameState m_NextFrameEventsState;
			public AnimationDataSet<TimingData, StyleData> running;
			public AnimationDataSet<EmptyData, T> completed;
	
			// Properties
			public bool isEmpty { get; } // 0x000000018BFE5BD8-0x000000018BFE5C08 
			public abstract Func<T, T, bool> SameFunc { get; }
	
			// Nested types
			private class TransitionEventsFrameState // TypeDefIndex: 44261
			{
				// Fields
				private static readonly ObjectPool<Queue<EventBase>> k_EventQueuePool;
				public readonly Dictionary<ElementPropertyPair, TransitionState> elementPropertyStateDelta;
				public readonly Dictionary<ElementPropertyPair, Queue<EventBase>> elementPropertyQueuedEvents;
				public IPanel panel;
				private int m_ChangesCount;
	
				// Nested types
				[Serializable]
				private sealed class __c // TypeDefIndex: 44260
				{
					// Fields
					public static readonly __c<T> __9;
	
					// Constructors
					static __c() {}
					public __c() {}
	
					// Methods
					internal Queue<EventBase> _.cctor_b__11_0() => default;
				}
	
				// Constructors
				public TransitionEventsFrameState() {} // 0x0000000186472594-0x00000001864725B0
				static TransitionEventsFrameState() {} // 0x000000018BFE5B50-0x000000018BFE5BC0
	
				// Methods
				public static Queue<EventBase> GetPooledQueue() => default;
				public void RegisterChange() {}
				public void UnregisterChange() {}
				public bool StateChanged() => default;
				public void Clear() {}
			}
	
			public struct TimingData // TypeDefIndex: 44262
			{
				// Fields
				public long startTimeMs;
				public int durationMs;
				public Func<float, float> easingCurve;
				public float easedProgress;
				public float reversingShorteningFactor;
				public bool isStarted;
				public int delayMs;
			}
	
			public struct StyleData // TypeDefIndex: 44263
			{
				// Fields
				public T startValue;
				public T endValue;
				public T reversingAdjustedStartValue;
				public T currentValue;
			}
	
			public struct EmptyData // TypeDefIndex: 44264
			{
				// Fields
				public static EmptyData<T> Default;
	
				// Constructors
				static EmptyData() {
					Default = default;
				} // 0x000000018BFE5BC0-0x000000018BFE5BD8
			}
	
			// Constructors
			protected Values() {}
	
			// Methods
			protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref ref T a, ref ref T b) => default;
			private void SwapFrameStates() {}
			private void QueueEvent(EventBase evt, ElementPropertyPair epp) {}
			private void ClearEventQueue(ElementPropertyPair epp) {}
			private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) {}
			private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) {}
			private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) {}
			private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) {}
			private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) {}
			public sealed override void CancelAllAnimations() {}
			public sealed override void CancelAllAnimations(VisualElement ve) {}
			public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id) {}
			public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id) {}
			public sealed override void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) {}
			private float ComputeReversingShorteningFactor(int oldIndex) => default;
			private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) => default;
			private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) => default;
			public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, long currentTimeMs) => default;
			private void ForceComputedStyleEndValue(int runningIndex) {}
			public sealed override void Update(long currentTimeMs) {}
			private void ProcessEventQueue() {}
			private void UpdateProgress(long currentTimeMs) {}
		}
	
		private class ValuesFloat : Values<float> // TypeDefIndex: 44266
		{
			// Fields
			private readonly Func<float, float, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<float, float, bool> SameFunc { get; }
	
			// Constructors
			public ValuesFloat() {}
	
			// Methods
			private static bool IsSame(float a, float b) => default;
			private static float Lerp(float a, float b, float t) => default;
			protected sealed override void UpdateValues() {}
			protected sealed override void UpdateComputedStyle() {}
			protected sealed override void UpdateComputedStyle(int i) {}
		}
	
		private class ValuesInt : Values<int> // TypeDefIndex: 44267
		{
			// Fields
			private readonly Func<int, int, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<int, int, bool> SameFunc { get; }
	
			// Constructors
			public ValuesInt() {}
	
			// Methods
			private static bool IsSame(int a, int b) => default;
			private static int Lerp(int a, int b, float t) => default;
			protected sealed override void UpdateValues() {}
			protected sealed override void UpdateComputedStyle() {}
			protected sealed override void UpdateComputedStyle(int i) {}
		}
	
		private class ValuesLength : Values<Length> // TypeDefIndex: 44268
		{
			// Fields
			private readonly Func<Length, Length, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<Length, Length, bool> SameFunc { get; }
	
			// Constructors
			public ValuesLength() {}
	
			// Methods
			private static bool IsSame(Length a, Length b) => default;
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b) => default;
			internal static Length Lerp(Length a, Length b, float t) => default;
			protected sealed override void UpdateValues() {}
			protected sealed override void UpdateComputedStyle() {}
			protected sealed override void UpdateComputedStyle(int i) {}
		}
	
		private class ValuesColor : Values<UnityEngine.Color> // TypeDefIndex: 44269
		{
			// Fields
			private readonly Func<UnityEngine.Color, UnityEngine.Color, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<UnityEngine.Color, UnityEngine.Color, bool> SameFunc { get; }
	
			// Constructors
			public ValuesColor() {} // 0x000000018BFEDB2C-0x000000018BFEDBC0
	
			// Methods
			private static bool IsSame(UnityEngine.Color c, UnityEngine.Color d) => default; // 0x0000000185FB0510-0x0000000185FB0520
			private static UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t) => default; // 0x000000018B7EFB70-0x000000018B7EFB78
			protected sealed override void UpdateValues() {} // 0x0000000185FE6FF0-0x0000000185FE7010
			protected sealed override void UpdateComputedStyle() {} // 0x000000018BFEDBC0-0x000000018BFEDC3C
			protected sealed override void UpdateComputedStyle(int i) {} // 0x000000018BFEDA78-0x000000018BFEDB2C
		}
	
		private abstract class ValuesDiscrete<T> : Values<T> // TypeDefIndex: 44270
		{
			// Fields
			private readonly Func<T, T, bool> _SameFunc_k__BackingField;
	
			// Properties
			public override Func<T, T, bool> SameFunc { get; } // 0x000000018BFEDC3C-0x000000018BFEDCD8 
	
			// Constructors
			protected ValuesDiscrete() {} // 0x000000018BFEE148-0x000000018BFEE1D0
	
			// Methods
			private static bool IsSame(T a, T b) => default;
			private static T Lerp(T a, T b, float t) => default;
			protected sealed override void UpdateValues() {} // 0x000000018BFEDFE0-0x000000018BFEE000
		}
	
		private class ValuesBackground : ValuesDiscrete<Background> // TypeDefIndex: 44271
		{
			// Constructors
			public ValuesBackground() {} // 0x000000018BFEE1D0-0x000000018BFEE26C
	
			// Methods
			protected sealed override void UpdateComputedStyle() {} // 0x000000018BFEE094-0x000000018BFEE148
			protected sealed override void UpdateComputedStyle(int i) {} // 0x000000018BFEE000-0x000000018BFEE094
		}
	
		private class ValuesFontDefinition : ValuesDiscrete<FontDefinition> // TypeDefIndex: 44272
		{
			// Constructors
			public ValuesFontDefinition() {} // 0x000000018BFEE26C-0x000000018BFEE2A8
	
			// Methods
			protected sealed override void UpdateComputedStyle() {} // 0x0000000185FB0510-0x0000000185FB0520
			protected sealed override void UpdateComputedStyle(int i) {} // 0x000000018BFEE2A8-0x000000018BFEE2E0
		}
	
		private class ValuesFont : ValuesDiscrete<Font> // TypeDefIndex: 44273
		{
			// Constructors
			public ValuesFont() {} // 0x000000018BFEE328-0x000000018BFEE3DC
	
			// Methods
			protected sealed override void UpdateComputedStyle() {} // 0x000000018BFEE2E0-0x000000018BFEE328
			protected sealed override void UpdateComputedStyle(int i) {} // 0x000000018BFEE470-0x000000018BFEE4FC
		}
	
		private class ValuesTextShadow : Values<TextShadow> // TypeDefIndex: 44274
		{
			// Fields
			private readonly Func<TextShadow, TextShadow, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<TextShadow, TextShadow, bool> SameFunc { get; } // 0x000000018BFEE3DC-0x000000018BFEE470 
	
			// Constructors
			public ValuesTextShadow() {} // 0x000000018BFED868-0x000000018BFED92C
	
			// Methods
			private static bool IsSame(TextShadow a, TextShadow b) => default; // 0x000000018BFEE4FC-0x000000018BFEE598
			private static TextShadow Lerp(TextShadow a, TextShadow b, float t) => default; // 0x0000000185FB0510-0x0000000185FB0520
			protected sealed override void UpdateValues() {} // 0x000000018BFED718-0x000000018BFED78C
			protected sealed override void UpdateComputedStyle() {} // 0x000000018BFED78C-0x000000018BFED7C8
			protected sealed override void UpdateComputedStyle(int i) {} // 0x000000018BFED92C-0x000000018BFED9DC
		}
	
		private class ValuesScale : Values<Scale> // TypeDefIndex: 44275
		{
			// Fields
			private readonly Func<Scale, Scale, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<Scale, Scale, bool> SameFunc { get; } // 0x000000018BFED7C8-0x000000018BFED868 
	
			// Constructors
			public ValuesScale() {}
	
			// Methods
			private static bool IsSame(Scale a, Scale b) => default; // 0x000000018BFED9DC-0x000000018BFEDA78
			protected sealed override void UpdateComputedStyle() {}
			protected sealed override void UpdateComputedStyle(int i) {}
			private static Scale Lerp(Scale a, Scale b, float t) => default;
			protected sealed override void UpdateValues() {}
		}
	
		private class ValuesRotate : Values<Rotate> // TypeDefIndex: 44276
		{
			// Fields
			private readonly Func<Rotate, Rotate, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<Rotate, Rotate, bool> SameFunc { get; } // 0x000000018BFED60C-0x000000018BFED6DC 
	
			// Constructors
			public ValuesRotate() {} // 0x000000018BFEDEFC-0x000000018BFEDFA4
	
			// Methods
			private static bool IsSame(Rotate a, Rotate b) => default; // 0x000000018BFED560-0x000000018BFED60C
			protected sealed override void UpdateComputedStyle() {} // 0x000000018BFED6DC-0x000000018BFED718
			protected sealed override void UpdateComputedStyle(int i) {} // 0x000000018BFEDD78-0x000000018BFEDE3C
			private static Rotate Lerp(Rotate a, Rotate b, float t) => default; // 0x000000018BFEDCD8-0x000000018BFEDD78
			protected sealed override void UpdateValues() {} // 0x000000018BFEDE3C-0x000000018BFEDE78
		}
	
		private class ValuesTranslate : Values<Translate> // TypeDefIndex: 44277
		{
			// Fields
			private readonly Func<Translate, Translate, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<Translate, Translate, bool> SameFunc { get; } // 0x000000018BFEDE78-0x000000018BFEDEFC 
	
			// Constructors
			public ValuesTranslate() {} // 0x000000018BFEED90-0x000000018BFEEE48
	
			// Methods
			private static bool IsSame(Translate a, Translate b) => default; // 0x000000018BFEDFA4-0x000000018BFEDFE0
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b) => default; // 0x0000000185FB0510-0x0000000185FB0520
			protected sealed override void UpdateComputedStyle() {} // 0x000000018BFEECC0-0x000000018BFEED10
			protected sealed override void UpdateComputedStyle(int i) {} // 0x000000018BFEED10-0x000000018BFEED90
			private static Translate Lerp(Translate a, Translate b, float t) => default; // 0x000000018BFEEF24-0x000000018BFEF014
			protected sealed override void UpdateValues() {} // 0x000000018BFEEE48-0x000000018BFEEF24
		}
	
		private class ValuesTransformOrigin : Values<TransformOrigin> // TypeDefIndex: 44278
		{
			// Fields
			private readonly Func<TransformOrigin, TransformOrigin, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<TransformOrigin, TransformOrigin, bool> SameFunc { get; } // 0x000000018BFEF014-0x000000018BFEF0B0 
	
			// Constructors
			public ValuesTransformOrigin() {} // 0x000000018BFEEC24-0x000000018BFEECC0
	
			// Methods
			private static bool IsSame(TransformOrigin a, TransformOrigin b) => default; // 0x0000000185FB0510-0x0000000185FB0520
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b) => default; // 0x000000018BFEE970-0x000000018BFEE99C
			protected sealed override void UpdateComputedStyle() {} // 0x000000018BFEEAB0-0x000000018BFEEB74
			protected sealed override void UpdateComputedStyle(int i) {} // 0x000000018BFEEA10-0x000000018BFEEAB0
			private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) => default; // 0x000000018BFEE99C-0x000000018BFEEA10
			protected sealed override void UpdateValues() {} // 0x000000018BFEEB74-0x000000018BFEEC24
		}
	
		// Constructors
		public StylePropertyAnimationSystem() {} // 0x0000000185FB0510-0x0000000185FB0520
	
		// Methods
		private T GetOrCreate<T>(ref ref T values)
			where T : new() => default; // 0x000000018BFEE598-0x000000018BFEE5DC
		private bool StartTransition<T>(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, Values<T> values) => default; // 0x000000018BFEE72C-0x000000018BFEE7FC
		public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEE680-0x000000018BFEE72C
		public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEE5DC-0x000000018BFEE680
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEE7FC-0x000000018BFEE8D4
		public bool StartTransition(VisualElement owner, StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEE8D4-0x000000018BFEE970
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000185FB0510-0x0000000185FB0520
		public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEF4A4-0x000000018BFEF4E8
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEF478-0x000000018BFEF4A4
		public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEF62C-0x000000018BFEF6FC
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEF580-0x000000018BFEF62C
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEF4E8-0x000000018BFEF580
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEF6FC-0x000000018BFEF7D4
		public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018BFEF7D4-0x000000018BFEF870
		public void CancelAllAnimations() {} // 0x0000000185FB0510-0x0000000185FB0520
		public void CancelAllAnimations(VisualElement owner) {} // 0x000000018BFEF0DC-0x000000018BFEF118
		public void CancelAnimation(VisualElement owner, StylePropertyId id) {} // 0x000000018BFEF0B0-0x000000018BFEF0DC
		public void UpdateAnimation(VisualElement owner, StylePropertyId id) {} // 0x000000018BFEF24C-0x000000018BFEF318
		public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) {} // 0x000000018BFEF1A4-0x000000018BFEF24C
		private void UpdateTracking<T>(Values<T> values) {} // 0x000000018BFEF118-0x000000018BFEF1A4
		private long CurrentTimeMs() => default; // 0x000000018BFEF318-0x000000018BFEF3DC
		public void Update() {} // 0x000000018BFEF3DC-0x000000018BFEF478
	}

	public struct StylePropertyName : IEquatable<StylePropertyName> // TypeDefIndex: 44280
	{
		// Fields
		private readonly StylePropertyId _id_k__BackingField; // 0x00
		private readonly string _name_k__BackingField; // 0x08
	
		// Properties
		internal StylePropertyId id { get; } // 0x00000001818226B0-0x00000001818226C0 
		private string name { get; } // 0x000000018357A260-0x000000018357A270 
	
		// Constructors
		internal StylePropertyName(StylePropertyId stylePropertyId) : this() {
			<id>k__BackingField = default;
			<name>k__BackingField = default;
		} // 0x000000018BFE76A8-0x000000018BFE7754
		public StylePropertyName(string name) : this() {
			<id>k__BackingField = default;
			<name>k__BackingField = default;
		} // 0x000000018BFE7660-0x000000018BFE76A8
	
		// Methods
		internal static StylePropertyId StylePropertyIdFromString(string name) => default; // 0x000000018BFE75DC-0x000000018BFE7660
		public static bool operator ==(StylePropertyName lhs, StylePropertyName rhs) => default; // 0x000000018BFE7754-0x000000018BFE775C
		public static bool operator !=(StylePropertyName lhs, StylePropertyName rhs) => default; // 0x000000018BFE7790-0x000000018BFE779C
		public static implicit operator StylePropertyName(string name) => default; // 0x000000018BFE775C-0x000000018BFE7790
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public override bool Equals(object other) => default; // 0x000000018BFE7570-0x000000018BFE75D4
		public bool Equals(StylePropertyName other) => default; // 0x000000018BFE75D4-0x000000018BFE75DC
		public override string ToString() => default; // 0x0000000185FE6720-0x0000000185FE6730
	}

	public class TemplateContainer : BindableElement // TypeDefIndex: 44283
	{
		// Fields
		private string _templateId_k__BackingField; // 0x3D0
		private VisualElement m_ContentContainer; // 0x3D8
		private VisualTreeAsset m_TemplateSource; // 0x3E0
	
		// Properties
		public string templateId { get; private set; } // 0x0000000185FE9C20-0x0000000185FE9C30 0x0000000187A476CC-0x0000000187A476E0
		internal VisualTreeAsset templateSource { set {} } // 0x000000018BFECE50-0x000000018BFECE7C
		public override VisualElement contentContainer { get => default; } // 0x000000018BFECEF0-0x000000018BFED230 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits> // TypeDefIndex: 44281
		{
			// Properties
			public override string uxmlName { get => default; } // 0x0000000185FB7090-0x0000000185FB70A0 
			public override string uxmlQualifiedName { get => default; } // 0x0000000187A47A28-0x0000000187A47A3C 
	
			// Constructors
			public UxmlFactory() {} // 0x0000000187A47C08-0x0000000187A47C1C
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 44282
		{
			// Fields
			private UxmlStringAttributeDescription m_Template; // 0x78
	
			// Constructors
			public UxmlTraits() {} // 0x000000018BFE779C-0x000000018BFE77E4
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018BFE77E4-0x000000018BFE77F0
		}
	
		// Constructors
		public TemplateContainer() {} // 0x000000018BFECE7C-0x000000018BFECEF0
		public TemplateContainer(string templateId) {} // 0x000000018BFECE14-0x000000018BFECE50
	
		// Methods
		internal void SetContentContainer(VisualElement content) {} // 0x000000018BFED4C8-0x000000018BFED560
	}

	internal interface ITextElement // TypeDefIndex: 44284
	{
		// Properties
		string text { get; }
	}

	public class TextElement : BindableElement, ITextElement, INotifyValueChanged<string> // TypeDefIndex: 44287
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private ITextHandle m_TextHandle; // 0x3D0
		internal static int maxTextVertices; // 0x08
		private string m_Text; // 0x3D8
		private bool m_EnableRichText; // 0x3E0
		private bool m_DisplayTooltipWhenElided; // 0x3E1
		private bool _isElided_k__BackingField; // 0x3E2
		internal static readonly string k_EllipsisText; // 0x10
		private bool m_WasElided; // 0x3E3
		private bool m_UpdateTextParams; // 0x3E4
		private MeshGenerationContextUtils.TextParams m_TextParams; // 0x3E8
		private int m_PreviousTextParamsHashCode; // 0x480
	
		// Properties
		internal ITextHandle textHandle { get => default; set {} } // 0x000000018BFE7F20-0x000000018BFE7F28 0x000000018BFE86B0-0x000000018BFE86EC
		public virtual string text { get => default; set {} } // 0x000000018BFE871C-0x000000018BFE8738 0x0000000185FE9C30-0x0000000185FE9C40
		public bool enableRichText { get => default; set {} } // 0x000000018BFE86EC-0x000000018BFE871C 0x0000000185FE9C50-0x0000000185FE9C60
		public bool displayTooltipWhenElided { get => default; set {} } // 0x0000000185FE9C70-0x0000000185FE9C80 0x000000018BFE7DA0-0x000000018BFE7F20
		public bool isElided { get; private set; } // 0x000000018BFE7854-0x000000018BFE7C24 0x000000018BFE81C0-0x000000018BFE821C
		string UnityEngine.UIElements.INotifyValueChanged<System.String>.value { get => default; set {} } // 0x000000018BFE8430-0x000000018BFE8504 0x000000018BFECDD8-0x000000018BFECE14
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TextElement, UxmlTraits> // TypeDefIndex: 44285
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018BFE8504-0x000000018BFE86B0
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 44286
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
			private UxmlBoolAttributeDescription m_EnableRichText; // 0x80
			private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x0000000187A47A28-0x0000000187A47A3C
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000185FE9C60-0x0000000185FE9C70
		}
	
		// Constructors
		public TextElement() {} // 0x000000018BFE7C24-0x000000018BFE7D68
		static TextElement() {} // 0x000000018BFED374-0x000000018BFED4C8
	
		// Methods
		public override void HandleEvent(EventBase evt) {} // 0x000000018BFE8738-0x000000018BFE8788
		private void OnGeometryChanged(GeometryChangedEvent e) {} // 0x0000000185FE9C40-0x0000000185FE9C50
		private void OnGenerateVisualContent(MeshGenerationContext mgc) {} // 0x000000018BFE821C-0x000000018BFE8430
		internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) => default; // 0x000000018BFE7F28-0x000000018BFE7F78
		private void UpdateTooltip() {} // 0x000000018BFE7F78-0x000000018BFE7FB8
		private void UpdateVisibleText() {} // 0x000000018BFE7D68-0x000000018BFE7DA0
		private bool ShouldElide() => default; // 0x000000018BFE77F0-0x000000018BFE7854
		private bool TextLibraryCanElide() => default; // 0x000000018BFE8024-0x000000018BFE806C
		public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) => default; // 0x000000018BFE806C-0x000000018BFE81C0
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x000000018BFE7FB8-0x000000018BFE8024
		void INotifyValueChanged<string>.SetValueWithoutNotify(string newValue) {} // 0x000000018BFED230-0x000000018BFED374
	}

	public struct TextShadow : IEquatable<TextShadow> // TypeDefIndex: 44288
	{
		// Fields
		public Vector2 offset; // 0x00
		public float blurRadius; // 0x08
		public UnityEngine.Color color; // 0x0C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BFE8788-0x000000018BFE8814
		public bool Equals(TextShadow other) => default; // 0x000000018BFE8814-0x000000018BFE88B0
		public override int GetHashCode() => default; // 0x000000018BFE88B0-0x000000018BFE8904
		public static bool operator ==(TextShadow style1, TextShadow style2) => default; // 0x000000018BFE8B44-0x000000018BFE8B74
		public static bool operator !=(TextShadow style1, TextShadow style2) => default; // 0x000000018BFE8B74-0x000000018BFE8BC8
		public override string ToString() => default; // 0x000000018BFE8A6C-0x000000018BFE8B44
		internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) => default; // 0x000000018BFE8904-0x000000018BFE8A6C
	}

	internal static class UIElementsPackageUtility // TypeDefIndex: 44289
	{
		// Fields
		internal static readonly string EditorResourcesBasePath; // 0x00
		internal static readonly bool IsUIEPackageLoaded; // 0x08
	
		// Constructors
		static UIElementsPackageUtility() {} // 0x000000018BFE913C-0x000000018BFE91AC
	}

	internal static class UIElementsRuntimeUtility // TypeDefIndex: 44292
	{
		// Fields
		private static Action<BaseRuntimePanel> onCreatePanel; // 0x00
		private static bool s_RegisteredPlayerloopCallback; // 0x08
		private static List<UnityEngine.UIElements.Panel> s_SortedRuntimePanels; // 0x10
		private static bool s_PanelOrderingDirty; // 0x18
		internal static readonly string s_RepaintProfilerMarkerName; // 0x20
		private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x28
		private static int currentOverlayIndex; // 0x30
		private static UnityEngine.Object _activeEventSystem_k__BackingField; // 0x38
		private static DefaultEventSystem s_DefaultEventSystem; // 0x40
		private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; // 0x48
	
		// Properties
		internal static UnityEngine.Object activeEventSystem { get; private set; } // 0x000000018BFE94F4-0x000000018BFE95A8 0x000000018BFE99E0-0x000000018BFE9B80
		internal static bool useDefaultEventSystem { get; } // 0x000000018BFE9834-0x000000018BFE98D4 
		internal static DefaultEventSystem defaultEventSystem { get; } // 0x00000001857FA5E0-0x00000001857FA680 
	
		// Events
		public static event Action<BaseRuntimePanel> onCreatePanel;
	
		// Nested types
		public delegate BaseRuntimePanel CreateRuntimePanelDelegate(ScriptableObject ownerObject); // TypeDefIndex: 44290; 0x000000018BFEA498-0x000000018BFEA55C
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 44291
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<UnityEngine.UIElements.Panel> __9__47_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000184D71570-0x0000000184D719E0
			public __c() {} // 0x000000018BFE9200-0x000000018BFE9264
	
			// Methods
			internal void _.cctor_b__9_0() {} // 0x000000018BFE9370-0x000000018BFE94F4
			internal void _.cctor_b__9_1(int displayIndex, int sortOrder) {} // 0x000000018BFE9264-0x000000018BFE9314
			internal int _SortPanels_b__47_0(UnityEngine.UIElements.Panel a, UnityEngine.UIElements.Panel b) => default; // 0x000000018BFE9764-0x000000018BFE9834
		}
	
		// Constructors
		static UIElementsRuntimeUtility() {} // 0x000000018BFE9E74-0x000000018BFE9FA0
	
		// Methods
		public static EventBase CreateEvent(UnityEngine.Event systemEvent) => default; // 0x000000018BFE91AC-0x000000018BFE9200
		public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) => default; // 0x000000018BFE9B80-0x000000018BFE9CE8
		public static void DisposeRuntimePanel(ScriptableObject ownerObject) {} // 0x000000018BFE9314-0x000000018BFE9370
		private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) {} // 0x000000018BFEA334-0x000000018BFEA384
		private static void RemoveCachedPanelInternal(int instanceID) {} // 0x000000018BFEA55C-0x000000018BFEA5BC
		public static void RepaintOffscreenPanels() {} // 0x000000018BFEA438-0x000000018BFEA498
		public static void RepaintOverlayPanel(BaseRuntimePanel panel) {} // 0x00000001857FA8C0-0x00000001857FAA70
		internal static void BeginRenderOverlays(int displayIndex) {} // 0x000000018BFEA0B4-0x000000018BFEA13C
		internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) {} // 0x000000018BFEA384-0x000000018BFEA438
		internal static void EndRenderOverlays(int displayIndex) {} // 0x000000018BFEA194-0x000000018BFEA334
		public static void RegisterEventSystem(UnityEngine.Object eventSystem) {} // 0x000000018BFEA13C-0x000000018BFEA194
		public static void UnregisterEventSystem(UnityEngine.Object eventSystem) {} // 0x000000018BFEA064-0x000000018BFEA0B4
		public static void UpdateRuntimePanels() {} // 0x00000001857FAA70-0x00000001857FAC70
		internal static void MarkPotentiallyEmpty(PanelSettings settings) {} // 0x000000018BFE95A8-0x000000018BFE9618
		internal static void RemoveUnusedPanels() {} // 0x000000018BFE9618-0x000000018BFE9764
		public static void RegisterPlayerloopCallback() {} // 0x000000018BFE9FA0-0x000000018BFEA064
		public static void UnregisterPlayerloopCallback() {} // 0x0000000185FE9C80-0x0000000185FE9CA0
		internal static void SetPanelOrderingDirty() {} // 0x0000000188FF6620-0x0000000188FF6744
		internal static List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels() => default; // 0x00000001817C2F70-0x00000001817C2F80
		private static void SortPanels() {} // 0x0000000185F73AB0-0x0000000185F73B10
		internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int? targetDisplay) {
			targetDisplay = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out int? targetDisplay) {
			targetDisplay = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) => default; // 0x000000018BFE8FF8-0x000000018BFE904C
		internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) => default; // 0x000000018BFE8D7C-0x000000018BFE8E54
	}

	internal interface IUIElementsUtility // TypeDefIndex: 44293
	{
		// Methods
		bool TakeCapture();
		bool ReleaseCapture();
		bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled);
		bool CleanupRoots();
		bool EndContainerGUIFromException(Exception exception);
		bool MakeCurrentIMGUIContainerDirty();
	}

	internal static class UIEventRegistration // TypeDefIndex: 44295
	{
		// Fields
		private static List<IUIElementsUtility> s_Utilities; // 0x00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44294
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018596C1F0-0x000000018596C800
			public __c() {} // 0x0000000184D70270-0x0000000184D702F0
	
			// Methods
			internal void _.cctor_b__1_0() {} // 0x000000018BFEBF30-0x000000018BFEC0B0
			internal void _.cctor_b__1_1() {} // 0x000000018BFEBDBC-0x000000018BFEBF30
			internal bool _.cctor_b__1_2(int i, IntPtr ptr) => default; // 0x000000018BFEB8A8-0x000000018BFEBA5C
			internal void _.cctor_b__1_3() {} // 0x000000018BFEBBDC-0x000000018BFEBDBC
			internal bool _.cctor_b__1_4(Exception exception) => default; // 0x000000018BFEB728-0x000000018BFEB8A8
			internal void _.cctor_b__1_5() {} // 0x000000018BFEBA5C-0x000000018BFEBBDC
		}
	
		// Constructors
		static UIEventRegistration() {} // 0x0000000185F79390-0x0000000185F793F0
	
		// Methods
		internal static void RegisterUIElementSystem(IUIElementsUtility utility) {} // 0x0000000185492010-0x0000000185492020
		private static void TakeCapture() {} // 0x000000018BFE8E54-0x000000018BFE8E94
		private static void ReleaseCapture() {} // 0x000000018BFE8E94-0x000000018BFE8ED4
		private static bool EndContainerGUIFromException(Exception exception) => default; // 0x000000018BFE8ED4-0x000000018BFE8F2C
		private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) => default; // 0x000000018BFE8F2C-0x000000018BFE8F6C
		private static void CleanupRoots() {} // 0x000000018BFE8F6C-0x000000018BFE8FB8
		internal static void MakeCurrentIMGUIContainerDirty() {} // 0x000000018BFE8FB8-0x000000018BFE8FF8
	}

	internal class UIElementsUtility : IUIElementsUtility // TypeDefIndex: 44296
	{
		// Fields
		private static Stack<IMGUIContainer> s_ContainerStack; // 0x00
		private static Dictionary<int, UnityEngine.UIElements.Panel> s_UIElementsCache; // 0x08
		private static UnityEngine.Event s_EventInstance; // 0x10
		internal static UnityEngine.Color editorPlayModeTintColor; // 0x18
		internal static float singleLineHeight; // 0x28
		private static UIElementsUtility s_Instance; // 0x30
		internal static List<UnityEngine.UIElements.Panel> s_PanelsIterationList; // 0x38
		internal static readonly string s_RepaintProfilerMarkerName; // 0x40
		internal static readonly string s_EventProfilerMarkerName; // 0x48
		private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x50
		private static readonly ProfilerMarker s_EventProfilerMarker; // 0x58
	
		// Constructors
		private UIElementsUtility() {} // 0x0000000184D702F0-0x0000000184D70340
		static UIElementsUtility() {} // 0x0000000184D719E0-0x0000000184D71D00
	
		// Methods
		bool IUIElementsUtility.MakeCurrentIMGUIContainerDirty() => default; // 0x000000018BFEB428-0x000000018BFEB4D4
		bool IUIElementsUtility.TakeCapture() => default; // 0x000000018BFEB5E0-0x000000018BFEB728
		bool IUIElementsUtility.ReleaseCapture() => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
		bool IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) => default; // 0x000000018BFEB4D4-0x000000018BFEB5E0
		bool IUIElementsUtility.CleanupRoots() => default; // 0x000000018BFEB2D8-0x000000018BFEB384
		bool IUIElementsUtility.EndContainerGUIFromException(Exception exception) => default; // 0x000000018BFEB384-0x000000018BFEB428
		public static void RegisterCachedPanel(int instanceID, UnityEngine.UIElements.Panel panel) {} // 0x000000018BFEB174-0x000000018BFEB1F0
		public static void RemoveCachedPanel(int instanceID) {} // 0x000000018BFEB1F0-0x000000018BFEB25C
		public static bool TryGetPanel(int instanceID, out UnityEngine.UIElements.Panel panel) {
			panel = default;
			return default;
		} // 0x000000018BFEB25C-0x000000018BFEB2D8
		internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, UnityEngine.Event evt, IMGUIContainer container) {} // 0x000000018BFEA5BC-0x000000018BFEA774
		internal static void EndContainerGUI(UnityEngine.Event evt, Rect layoutSize) {} // 0x000000018BFEAF28-0x000000018BFEB0E4
		internal static EventBase CreateEvent(UnityEngine.Event systemEvent) => default; // 0x000000018BFEA774-0x000000018BFEA7D8
		internal static EventBase CreateEvent(UnityEngine.Event systemEvent, UnityEngine.EventType eventType) => default; // 0x000000018BFEA7D8-0x000000018BFEAA60
		private static bool DoDispatch(BaseVisualElementPanel panel) => default; // 0x000000018BFEAA60-0x000000018BFEAF28
		internal static void GetAllPanels(List<UnityEngine.UIElements.Panel> panels, ContextType contextType) {} // 0x00000001857FAC70-0x00000001857FAD50
		internal static Dictionary<int, UnityEngine.UIElements.Panel> GetPanelsIterator() => default; // 0x00000001857FAD50-0x00000001857FAE00
		internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) => default; // 0x000000018BFEB0E4-0x000000018BFEB174
	}

	internal struct RuleMatcher // TypeDefIndex: 44297
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public StyleComplexSelector complexSelector; // 0x08
	
		// Methods
		public override string ToString() => default; // 0x000000018BFE5CC8-0x000000018BFE5CEC
	}

	public static class UQuery // TypeDefIndex: 44304
	{
		// Nested types
		internal interface IVisualPredicateWrapper // TypeDefIndex: 44298
		{
			// Methods
			bool Predicate(object e);
		}
	
		internal class IsOfType<T> : IVisualPredicateWrapper // TypeDefIndex: 44299
			where T : VisualElement
		{
			// Fields
			public static IsOfType<T> s_Instance;
	
			// Constructors
			public IsOfType() {}
			static IsOfType() {}
	
			// Methods
			public bool Predicate(object e) => default;
		}
	
		internal abstract class UQueryMatcher : HierarchyTraversal // TypeDefIndex: 44301
		{
			// Fields
			internal List<RuleMatcher> m_Matchers; // 0x10
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 44300
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Action<VisualElement, MatchResultInfo> __9__5_0; // 0x08
	
				// Constructors
				static __c() {} // 0x0000000185492010-0x0000000185492020
				public __c() {} // 0x000000018BFECD88-0x000000018BFECD90
	
				// Methods
				internal void _TraverseRecursive_b__5_0(VisualElement e, MatchResultInfo i) {} // 0x0000000185FAFEF0-0x0000000185FAFF00
			}
	
			// Constructors
			protected UQueryMatcher() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public override void Traverse(VisualElement element) {} // 0x000000018BFECB90-0x000000018BFECD88
			protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) => default; // 0x000000018BFECB64-0x000000018BFECB90
			private static void NoProcessResult(VisualElement e, MatchResultInfo i) {} // 0x000000018BFE9074-0x000000018BFE90D8
			public override void TraverseRecursive(VisualElement element, int depth) {} // 0x0000000185492010-0x0000000185492020
			public virtual void Run(VisualElement root, List<RuleMatcher> matchers) {} // 0x0000000185492010-0x0000000185492020
		}
	
		internal abstract class SingleQueryMatcher : UQueryMatcher // TypeDefIndex: 44302
		{
			// Fields
			private VisualElement _match_k__BackingField; // 0x18
	
			// Properties
			public VisualElement match { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
			// Constructors
			protected SingleQueryMatcher() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public override void Run(VisualElement root, List<RuleMatcher> matchers) {} // 0x000000018BFE5CEC-0x000000018BFE5D34
			public bool IsInUse() => default; // 0x00000001882E0F9C-0x00000001882E0FA8
			public abstract SingleQueryMatcher CreateNew();
		}
	
		internal class FirstQueryMatcher : SingleQueryMatcher // TypeDefIndex: 44303
		{
			// Fields
			public static readonly FirstQueryMatcher Instance; // 0x00
	
			// Constructors
			public FirstQueryMatcher() {} // 0x0000000185492010-0x0000000185492020
			static FirstQueryMatcher() {} // 0x000000018BFE5C64-0x000000018BFE5CC8
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) => default; // 0x000000018BFE5C44-0x000000018BFE5C64
			public override SingleQueryMatcher CreateNew() => default; // 0x000000018BFE5C08-0x000000018BFE5C44
		}
	}

	public struct UQueryState<T> : IEnumerable<T>, IEquatable<UQueryState<T>> // TypeDefIndex: 44308
		where T : VisualElement
	{
		// Fields
		private static ActionQueryMatcher s_Action;
		private readonly VisualElement m_Element;
		internal readonly List<RuleMatcher> m_Matchers;
		private static readonly ListQueryMatcher s_List;
		private static readonly ListQueryMatcher<VisualElement> s_EnumerationList;
	
		// Nested types
		private class ListQueryMatcher<TElement> : UQuery.UQueryMatcher // TypeDefIndex: 44305
			where TElement : VisualElement
		{
			// Fields
			private List<TElement> _matches_k__BackingField;
	
			// Properties
			public List<TElement> matches { get; set; }
	
			// Constructors
			public ListQueryMatcher() {}
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) => default;
			public void Reset() {}
		}
	
		private class ActionQueryMatcher : UQuery.UQueryMatcher // TypeDefIndex: 44306
		{
			// Fields
			private Action<T> _callBack_k__BackingField;
	
			// Properties
			internal Action<T> callBack { get; }
	
			// Constructors
			public ActionQueryMatcher() {}
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) => default;
		}
	
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 44307
		{
			// Fields
			private List<VisualElement> iterationList;
			private int currentIndex;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal Enumerator(UQueryState<T> queryState) : this() {
				iterationList = default;
				currentIndex = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
			public void Dispose() {}
		}
	
		// Constructors
		internal UQueryState(VisualElement element, List<RuleMatcher> matchers) {
			m_Element = default;
			m_Matchers = default;
		}
		static UQueryState() {
			s_Action = default;
			s_List = default;
			s_EnumerationList = default;
		}
	
		// Methods
		public UQueryState<T> RebuildOn(VisualElement element) => default;
		private T Single(UQuery.SingleQueryMatcher matcher) => default;
		public T First() => default;
		public void ToList(List<T> results) {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool Equals(UQueryState<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> // TypeDefIndex: 44309
		where T : VisualElement
	{
		// Fields
		private List<StyleSelector> m_StyleSelectors;
		private List<StyleSelectorPart> m_Parts;
		private VisualElement m_Element;
		private List<RuleMatcher> m_Matchers;
		private StyleSelectorRelationship m_Relationship;
		private int pseudoStatesMask;
		private int negatedPseudoStatesMask;
	
		// Properties
		private List<StyleSelector> styleSelectors { get => default; }
		private List<StyleSelectorPart> parts { get => default; }
	
		// Constructors
		public UQueryBuilder(VisualElement visualElement) : this() {
			m_StyleSelectors = default;
			m_Parts = default;
			m_Element = default;
			m_Matchers = default;
			m_Relationship = default;
			pseudoStatesMask = default;
			negatedPseudoStatesMask = default;
		}
	
		// Methods
		public UQueryBuilder<T> Class(string classname) => default;
		public UQueryBuilder<T> Name(string id) => default;
		public UIElements.UQueryBuilder<T2> OfType<T2>(string name = null, string className = null)
			where T2 : VisualElement => default;
		internal UQueryBuilder<T> SingleBaseType() => default;
		private void AddClass(string c) {}
		private void AddName(string id) {}
		private void AddType<T2>()
			where T2 : VisualElement {}
		private UIElements.UQueryBuilder<T2> AddRelationship<T2>(StyleSelectorRelationship relationship)
			where T2 : VisualElement => default;
		private void AddPseudoStatesRuleIfNecessasy() {}
		private void FinishSelector() {}
		private bool CurrentSelectorEmpty() => default;
		private void FinishCurrentSelector() {}
		public UQueryState<T> Build() => default;
		public void ToList(List<T> results) {}
		public bool Equals(UQueryBuilder<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	public static class UQueryExtensions // TypeDefIndex: 44310
	{
		// Fields
		private static UQueryState<VisualElement> SingleElementEmptyQuery; // 0x00
		private static UQueryState<VisualElement> SingleElementNameQuery; // 0x10
		private static UQueryState<VisualElement> SingleElementClassQuery; // 0x20
		private static UQueryState<VisualElement> SingleElementNameAndClassQuery; // 0x30
		private static UQueryState<VisualElement> SingleElementTypeQuery; // 0x40
		private static UQueryState<VisualElement> SingleElementTypeAndNameQuery; // 0x50
		private static UQueryState<VisualElement> SingleElementTypeAndClassQuery; // 0x60
		private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery; // 0x70
	
		// Constructors
		static UQueryExtensions() {} // 0x000000018BFEC478-0x000000018BFECB64
	
		// Methods
		public static T Q<T>(VisualElement e, string name = null, string className = null)
			where T : VisualElement => default;
		public static VisualElement Q(VisualElement e, string name = null, string className = null) => default; // 0x000000018BFEC0B0-0x000000018BFEC478
		public static UQueryBuilder<T> Query<T>(VisualElement e, string name = null, string className = null)
			where T : VisualElement => default;
	}

	internal enum GradientType // TypeDefIndex: 44311
	{
		Linear = 0,
		Radial = 1
	}

	internal enum AddressMode // TypeDefIndex: 44312
	{
		Wrap = 0,
		Clamp = 1,
		Mirror = 2
	}

	[Serializable]
	internal struct VectorImageVertex // TypeDefIndex: 44313
	{
		// Fields
		public Vector3 position; // 0x00
		public Color32 tint; // 0x0C
		public Vector2 uv; // 0x10
		public uint settingIndex; // 0x18
	}

	[Serializable]
	internal struct GradientSettings // TypeDefIndex: 44314
	{
		// Fields
		public GradientType gradientType; // 0x00
		public AddressMode addressMode; // 0x04
		public Vector2 radialFocus; // 0x08
		public RectInt location; // 0x10
	}

	[Serializable]
	public class VectorImage : ScriptableObject // TypeDefIndex: 44315
	{
		// Fields
		internal Texture2D atlas; // 0x18
		internal VectorImageVertex[] vertices; // 0x20
		internal ushort[] indices; // 0x28
		internal GradientSettings[] settings; // 0x30
		internal Vector2 size; // 0x38
	
		// Constructors
		public VectorImage() {} // 0x000000018BFEF870-0x000000018BFEF8C0
	}

	internal enum PseudoStates // TypeDefIndex: 44316
	{
		Active = 1,
		Hover = 2,
		Checked = 8,
		Disabled = 32,
		Focus = 64,
		Root = 128
	}

	internal enum VisualElementFlags // TypeDefIndex: 44317
	{
		WorldTransformDirty = 1,
		WorldTransformInverseDirty = 2,
		WorldClipDirty = 4,
		BoundingBoxDirty = 8,
		WorldBoundingBoxDirty = 16,
		LayoutManual = 32,
		CompositeRoot = 64,
		RequireMeasureFunction = 128,
		EnableViewDataPersistence = 256,
		DisableClipping = 512,
		NeedsAttachToPanelEvent = 1024,
		HierarchyDisplayed = 2048,
		Init = 2079,
		StyleInitialized = 4096
	}

	public enum PickingMode // TypeDefIndex: 44318
	{
		Position = 0,
		Ignore = 1
	}

	public enum LanguageDirection // TypeDefIndex: 44319
	{
		Inherit = 0,
		LTR = 1,
		RTL = 2
	}

	internal static class VisualElementListPool // TypeDefIndex: 44320
	{
		// Fields
		private static ObjectPool<List<VisualElement>> pool; // 0x00
	
		// Constructors
		static VisualElementListPool() {} // 0x000000018BFF1EE0-0x000000018BFF1F74
	
		// Methods
		public static List<VisualElement> Copy(List<VisualElement> elements) => default; // 0x000000018BFF1CF0-0x000000018BFF1D90
		public static List<VisualElement> Get(int initialCapacity = 0 /* Metadata: 0x0205B571 */) => default; // 0x000000018BFF1D90-0x000000018BFF1E50
		public static void Release(List<VisualElement> elements) {} // 0x000000018BFF1E50-0x000000018BFF1EE0
	}

	internal class ObjectListPool<T> // TypeDefIndex: 44321
	{
		// Fields
		private static ObjectPool<List<T>> pool;
	
		// Constructors
		public ObjectListPool() {} // Dummy constructor
		static ObjectListPool() {}
	
		// Methods
		public static List<T> Get() => default;
		public static void Release(List<T> elements) {}
	}

	public static class VisualElementExtensions // TypeDefIndex: 44322
	{
		// Methods
		public static void StretchToParentSize(VisualElement elem) {} // 0x000000018BFF02DC-0x000000018BFF044C
		public static void AddManipulator(VisualElement ele, IManipulator manipulator) {} // 0x000000018BFF01C8-0x000000018BFF01DC
		public static void RemoveManipulator(VisualElement ele, IManipulator manipulator) {} // 0x000000018BFF02C8-0x000000018BFF02DC
		public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) => default; // 0x000000018BFF0530-0x000000018BFF05EC
		public static Vector2 LocalToWorld(VisualElement ele, Vector2 p) => default; // 0x000000018BFF020C-0x000000018BFF02C8
		public static Rect WorldToLocal(VisualElement ele, Rect r) => default; // 0x000000018BFF044C-0x000000018BFF0530
		public static Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point) => default; // 0x000000018BFF01DC-0x000000018BFF020C
	}

	public interface IExperimentalFeatures // TypeDefIndex: 44323
	{
		// Properties
		ITransitionAnimations animation { get; }
	}

	public class VisualElementFocusChangeDirection : FocusChangeDirection // TypeDefIndex: 44324
	{
		// Fields
		private static readonly VisualElementFocusChangeDirection s_Left; // 0x00
		private static readonly VisualElementFocusChangeDirection s_Right; // 0x08
	
		// Properties
		public static FocusChangeDirection left { get => default; } // 0x000000018BFF0744-0x000000018BFF0794 
		public static FocusChangeDirection right { get => default; } // 0x000000018BFF0794-0x000000018BFF07E4 
	
		// Constructors
		public VisualElementFocusChangeDirection() {} // Dummy constructor
		protected VisualElementFocusChangeDirection(int value) {} // 0x000000018BFF06F4-0x000000018BFF0744
		static VisualElementFocusChangeDirection() {} // 0x000000018BFF05EC-0x000000018BFF06F4
	}

	internal class VisualElementFocusChangeTarget : FocusChangeDirection // TypeDefIndex: 44325
	{
		// Fields
		private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool; // 0x00
		private Focusable _target_k__BackingField; // 0x18
	
		// Properties
		public Focusable target { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public VisualElementFocusChangeTarget() {} // 0x000000018BFF0998-0x000000018BFF09F4
		static VisualElementFocusChangeTarget() {} // 0x000000018BFF0904-0x000000018BFF0998
	
		// Methods
		public static VisualElementFocusChangeTarget GetPooled(Focusable target) => default; // 0x000000018BFF0880-0x000000018BFF0904
		protected override void Dispose() {} // 0x000000018BFF0804-0x000000018BFF0880
		internal override void ApplyTo(FocusController focusController, Focusable f) {} // 0x000000018BFF07E4-0x000000018BFF0804
	}

	public class VisualElementFocusRing : IFocusRing // TypeDefIndex: 44328
	{
		// Fields
		private readonly VisualElement root; // 0x10
		private DefaultFocusOrder _defaultFocusOrder_k__BackingField; // 0x18
		private List<FocusRingRecord> m_FocusRing; // 0x20
	
		// Properties
		private FocusController focusController { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public DefaultFocusOrder defaultFocusOrder { get; set; } // 0x00000001813AE9C0-0x00000001813AE9D0 0x000000018BFF0D0C-0x000000018BFF1144
	
		// Nested types
		public enum DefaultFocusOrder // TypeDefIndex: 44326
		{
			ChildOrder = 0,
			PositionXY = 1,
			PositionYX = 2
		}
	
		private class FocusRingRecord // TypeDefIndex: 44327
		{
			// Fields
			public int m_AutoIndex; // 0x10
			public Focusable m_Focusable; // 0x18
			public bool m_IsSlot; // 0x20
			public List<FocusRingRecord> m_ScopeNavigationOrder; // 0x28
	
			// Constructors
			public FocusRingRecord() {} // 0x000000018BFF1C34-0x000000018BFF1CCC
		}
	
		// Constructors
		public VisualElementFocusRing() {} // Dummy constructor
		public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = DefaultFocusOrder.ChildOrder /* Metadata: 0x0205B572 */) {} // 0x000000018BFF1CCC-0x000000018BFF1CF0
	
		// Methods
		private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) => default; // 0x000000018BFF1144-0x000000018BFF124C
		private int FocusRingSort(FocusRingRecord a, FocusRingRecord b) => default; // 0x000000018BFF0C4C-0x000000018BFF0D0C
		private void DoUpdate() {} // 0x000000018BFF09F4-0x000000018BFF0C4C
		private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList) {} // 0x000000018BFF198C-0x000000018BFF1C34
		private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList) {} // 0x000000018BFF1400-0x000000018BFF1490
		private int GetFocusableInternalIndex(Focusable f) => default; // 0x000000018BFF124C-0x000000018BFF1400
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) => default; // 0x000000018BFF1490-0x000000018BFF15BC
		internal static FocusChangeDirection GetKeyDownFocusChangeDirection(EventBase e) => default; // 0x000000018BFF1644-0x000000018BFF18C8
		public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) => default; // 0x000000018BFF15BC-0x000000018BFF1644
		internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable) => default; // 0x000000018BFF18C8-0x000000018BFF198C
		internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable) => default; // 0x0000000185492010-0x0000000185492020
	}

	public interface IVisualElementScheduledItem // TypeDefIndex: 44329
	{
		// Properties
		bool isActive { get; }
	
		// Methods
		void Resume();
		void Pause();
		void ExecuteLater(long delayMs);
		IVisualElementScheduledItem StartingIn(long delayMs);
		IVisualElementScheduledItem Every(long intervalMs);
	}

	public interface IVisualElementScheduler // TypeDefIndex: 44330
	{
		// Methods
		IVisualElementScheduledItem Execute(Action<UnityEngine.UIElements.TimerState> timerUpdateEvent);
		IVisualElementScheduledItem Execute(Action updateEvent);
	}

	internal interface IVisualElementPanelActivatable // TypeDefIndex: 44331
	{
		// Properties
		VisualElement element { get; }
	
		// Methods
		bool CanBeActivated();
		void OnPanelActivate();
		void OnPanelDeactivate();
	}

	internal class VisualElementPanelActivator // TypeDefIndex: 44332
	{
		// Fields
		private IVisualElementPanelActivatable m_Activatable; // 0x10
		private bool _isActive_k__BackingField; // 0x18
		private bool _isDetaching_k__BackingField; // 0x19
	
		// Properties
		public bool isActive { get; private set; } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public bool isDetaching { get; private set; } // 0x0000000181A73E90-0x0000000181A73EA0 0x0000000181A73EB0-0x0000000181A73EC0
	
		// Constructors
		public VisualElementPanelActivator() {} // Dummy constructor
		public VisualElementPanelActivator(IVisualElementPanelActivatable activatable) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public void SetActive(bool action) {} // 0x000000018BFF2110-0x000000018BFF2348
		public void SendActivation() {} // 0x000000018BFF2010-0x000000018BFF2090
		public void SendDeactivation() {} // 0x000000018BFF2090-0x000000018BFF2110
		private void OnEnter(AttachToPanelEvent evt) {} // 0x000000018BFF1F74-0x000000018BFF1F84
		private void OnLeave(DetachFromPanelEvent evt) {} // 0x000000018BFF1F84-0x000000018BFF2010
	}

	public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet> // TypeDefIndex: 44333
	{
		// Fields
		private readonly VisualElement m_Element; // 0x00
	
		// Constructors
		internal VisualElementStyleSheetSet(VisualElement element) {
			m_Element = default;
		} // 0x000000018646FE2C-0x000000018646FE34
	
		// Methods
		public void Add(StyleSheet styleSheet) {} // 0x000000018BFF2348-0x000000018BFF24E0
		public bool Remove(StyleSheet styleSheet) => default; // 0x000000018BFF2550-0x000000018BFF269C
		public bool Equals(VisualElementStyleSheetSet other) => default; // 0x000000018BF87274-0x000000018BF87284
		public override bool Equals(object obj) => default; // 0x000000018BFF24E0-0x000000018BFF2550
		public override int GetHashCode() => default; // 0x0000000189289CE0-0x0000000189289D04
	}

	internal static class VisualElementUtils // TypeDefIndex: 44334
	{
		// Fields
		private static readonly HashSet<string> s_usedNames; // 0x00
		private static readonly System.Type s_FoldoutType; // 0x08
	
		// Constructors
		static VisualElementUtils() {} // 0x000000018BFF2930-0x000000018BFF2A1C
	
		// Methods
		public static string GetUniqueName(string nameBase) => default; // 0x000000018BFF283C-0x000000018BFF2930
		internal static int GetFoldoutDepth(VisualElement element) => default; // 0x000000018BFF269C-0x000000018BFF274C
		internal static int GetListAndFoldoutDepth(VisualElement element) => default; // 0x000000018BFF274C-0x000000018BFF283C
	}

	internal class VisualElementAnimationSystem : BaseVisualTreeUpdater // TypeDefIndex: 44335
	{
		// Fields
		private HashSet<IValueAnimationUpdate> m_Animations; // 0x20
		private List<IValueAnimationUpdate> m_IterationList; // 0x28
		private bool m_HasNewAnimations; // 0x30
		private bool m_IterationListDirty; // 0x31
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
		private static readonly string s_StylePropertyAnimationDescription; // 0x10
		private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker; // 0x18
		private long lastUpdate; // 0x38
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x000000018BFF0128-0x000000018BFF0178 
		private static ProfilerMarker stylePropertyAnimationProfilerMarker { get => default; } // 0x000000018BFF0178-0x000000018BFF01C8 
	
		// Constructors
		public VisualElementAnimationSystem() {} // 0x000000018BFF0064-0x000000018BFF0128
		static VisualElementAnimationSystem() {} // 0x000000018BFEFF58-0x000000018BFF0064
	
		// Methods
		public void UnregisterAnimation(IValueAnimationUpdate anim) {} // 0x000000018BFEFA5C-0x000000018BFEFAB8
		public void UnregisterAnimations(List<IValueAnimationUpdate> anims) {} // 0x000000018BFEFAB8-0x000000018BFEFBF4
		public void RegisterAnimation(IValueAnimationUpdate anim) {} // 0x000000018BFEF8C0-0x000000018BFEF91C
		public void RegisterAnimations(List<IValueAnimationUpdate> anims) {} // 0x000000018BFEF91C-0x000000018BFEFA5C
		public override void Update() {} // 0x000000018BFEFBF4-0x000000018BFEFF58
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000185492010-0x0000000185492020
	}

	internal enum HierarchyChangeType // TypeDefIndex: 44336
	{
		Add = 0,
		Remove = 1,
		Move = 2
	}

	internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater // TypeDefIndex: 44338
	{
		// Fields
		private State m_State; // 0x20
		private VisualElement m_CurrentChangeElement; // 0x28
		private VisualElement m_CurrentChangeParent; // 0x30
	
		// Nested types
		private enum State // TypeDefIndex: 44337
		{
			Waiting = 0,
			TrackingAddOrMove = 1,
			TrackingRemove = 2
		}
	
		// Constructors
		protected BaseVisualTreeHierarchyTrackerUpdater() {} // 0x0000000185FAFE40-0x0000000185FAFE50
	
		// Methods
		protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type);
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018BFE5730-0x000000018BFE5770
		public override void Update() {} // 0x000000018BFE58F8-0x000000018BFE5990
		private void ProcessNewChange(VisualElement ve) {} // 0x000000018BFE5808-0x000000018BFE5884
		private void ProcessAddOrMove(VisualElement ve) {} // 0x000000018BFE5770-0x000000018BFE5808
		private void ProcessRemove(VisualElement ve) {} // 0x000000018BFE5884-0x000000018BFE58F8
	}

	internal static class StyleCache // TypeDefIndex: 44339
	{
		// Fields
		private static Dictionary<long, ComputedStyle> s_ComputedStyleCache; // 0x00
		private static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache; // 0x08
		private static Dictionary<int, ComputedTransitionProperty[]> s_ComputedTransitionsCache; // 0x10
	
		// Constructors
		static StyleCache() {} // 0x000000018BFE6060-0x000000018BFE61BC
	
		// Methods
		public static bool TryGetValue(long hash, out ComputedStyle data) {
			data = default;
			return default;
		} // 0x000000018BFE5FE4-0x000000018BFE6060
		public static void SetValue(long hash, ref ComputedStyle data) {} // 0x000000018BFE5D34-0x000000018BFE5DF4
		public static bool TryGetValue(int hash, out StyleVariableContext data) {
			data = default;
			return default;
		} // 0x000000018BFE5EEC-0x000000018BFE5F68
		public static void SetValue(int hash, StyleVariableContext data) {} // 0x000000018BFE5DF4-0x000000018BFE5E70
		public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data) {
			data = default;
			return default;
		} // 0x000000018BFE5F68-0x000000018BFE5FE4
		public static void SetValue(int hash, ComputedTransitionProperty[] data) {} // 0x000000018BFE5E70-0x000000018BFE5EEC
	}

	internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater // TypeDefIndex: 44340
	{
		// Fields
		private HashSet<VisualElement> m_ApplyStyleUpdateList; // 0x20
		private HashSet<VisualElement> m_TransitionPropertyUpdateList; // 0x28
		private bool m_IsApplyingStyles; // 0x30
		private uint m_Version; // 0x34
		private uint m_LastVersion; // 0x38
		private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal; // 0x40
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
		private bool _disposed_k__BackingField; // 0x48
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x000000018BFF5F00-0x000000018BFF5F50 
		protected bool disposed { get; private set; } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
	
		// Constructors
		public VisualTreeStyleUpdater() {} // 0x000000018BFF5E14-0x000000018BFF5F00
		static VisualTreeStyleUpdater() {} // 0x000000018BFF5D80-0x000000018BFF5E14
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018BFF59B8-0x000000018BFF5A6C
		public override void Update() {} // 0x000000018BFF5A6C-0x000000018BFF5D80
		protected override void Dispose(bool disposing) {} // 0x000000018BFF5984-0x000000018BFF59B8
		private void ApplyStyles() {} // 0x000000018BFF58CC-0x000000018BFF5984
	}

	internal class StyleMatchingContext // TypeDefIndex: 44341
	{
		// Fields
		private List<StyleSheet> m_StyleSheetStack; // 0x10
		public StyleVariableContext variableContext; // 0x18
		public VisualElement currentElement; // 0x20
		public Action<VisualElement, MatchResultInfo> processResult; // 0x28
		public AncestorFilter ancestorFilter; // 0x30
	
		// Properties
		public int styleSheetCount { get => default; } // 0x000000018BFE6404-0x000000018BFE6444 
	
		// Constructors
		public StyleMatchingContext() {} // Dummy constructor
		public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult) {} // 0x000000018BFE62F4-0x000000018BFE6404
	
		// Methods
		public void AddStyleSheet(StyleSheet sheet) {} // 0x000000018BFE61BC-0x000000018BFE623C
		public void RemoveStyleSheetRange(int index, int count) {} // 0x000000018BFE6290-0x000000018BFE62F4
		public StyleSheet GetStyleSheetAt(int index) => default; // 0x000000018BFE623C-0x000000018BFE6290
	}

	internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal // TypeDefIndex: 44343
	{
		// Fields
		private StyleVariableContext m_ProcessVarContext; // 0x10
		private HashSet<VisualElement> m_UpdateList; // 0x18
		private HashSet<VisualElement> m_ParentList; // 0x20
		private List<SelectorMatchRecord> m_TempMatchResults; // 0x28
		private float _currentPixelsPerPoint_k__BackingField; // 0x30
		private StyleMatchingContext m_StyleMatchingContext; // 0x38
		private StylePropertyReader m_StylePropertyReader; // 0x40
		private readonly List<StylePropertyId> m_AnimatedProperties; // 0x48
	
		// Properties
		private float currentPixelsPerPoint { get; set; } // 0x000000018BFF3DB8-0x000000018BFF3E3C 0x000000018BFF3FF8-0x000000018BFF4074
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44342
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<SelectorMatchRecord> __9__24_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185FB0BE0-0x0000000185FB0BF0
			public __c() {} // 0x0000000185FB0BF0-0x0000000185FB0C00
	
			// Methods
			internal int _ProcessMatchedRules_b__24_0(SelectorMatchRecord a, SelectorMatchRecord b) => default; // 0x0000000185FB0BF0-0x0000000185FB0C00
		}
	
		// Constructors
		public VisualTreeStyleUpdaterTraversal() {} // 0x000000018BFE8D38-0x000000018BFE8D7C
	
		// Methods
		public void PrepareTraversal(float pixelsPerPoint) {} // 0x000000018BFF4DF8-0x000000018BFF4EB8
		public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018BFF4EB8-0x000000018BFF4F38
		public void Clear() {} // 0x000000018BFF421C-0x000000018BFF4250
		private void PropagateToChildren(VisualElement ve) {} // 0x000000018BFF4FBC-0x000000018BFF5680
		private void PropagateToParents(VisualElement ve) {} // 0x000000018BFF4D24-0x000000018BFF4DF8
		private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) {} // 0x000000018BFF4074-0x000000018BFF421C
		public override void TraverseRecursive(VisualElement element, int depth) {} // 0x000000018BFF3E3C-0x000000018BFF3FF8
		private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) {} // 0x000000018BFF4F38-0x000000018BFF4FBC
		private void ForceUpdateTransitions(VisualElement element) {} // 0x000000018BFF4250-0x000000018BFF4C64
		internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) {} // 0x000000018BFF4C64-0x000000018BFF4D24
		protected bool ShouldSkipElement(VisualElement element) => default; // 0x000000018BFF5680-0x000000018BFF58CC
		private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors) => default; // 0x000000018BFE90D8-0x000000018BFE913C
		private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) {} // 0x0000000185492010-0x0000000185492020
	}

	internal class VisualTreeTransformClipUpdater : BaseVisualTreeUpdater // TypeDefIndex: 44344
	{
		// Fields
		private uint m_Version; // 0x20
		private uint m_LastVersion; // 0x24
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x000000018BFF6294-0x000000018BFF62E4 
	
		// Constructors
		public VisualTreeTransformClipUpdater() {} // 0x0000000185FC6B20-0x0000000185FC6B30
		static VisualTreeTransformClipUpdater() {} // 0x000000018BFF6200-0x000000018BFF6294
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018BFF60D4-0x000000018BFF61A8
		private static void DirtyHierarchy(VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip) {} // 0x000000018BFF5FAC-0x000000018BFF60D4
		private static void DirtyBoundingBoxHierarchy(VisualElement ve) {} // 0x000000018BFF5F50-0x000000018BFF5FAC
		public override void Update() {} // 0x000000018BFF61A8-0x000000018BFF6200
	}

	internal enum VisualTreeUpdatePhase // TypeDefIndex: 44345
	{
		ViewData = 0,
		Bindings = 1,
		Animation = 2,
		Styles = 3,
		Layout = 4,
		TransformClip = 5,
		Repaint = 6,
		Count = 7
	}

	internal sealed class VisualTreeUpdater : IDisposable // TypeDefIndex: 44347
	{
		// Fields
		private BaseVisualElementPanel m_Panel; // 0x10
		private UpdaterArray m_UpdaterArray; // 0x18
	
		// Nested types
		private class UpdaterArray // TypeDefIndex: 44346
		{
			// Fields
			private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10
	
			// Properties
			public IVisualTreeUpdater this[VisualTreeUpdatePhase phase] { get => default; set {} } // 0x000000018BFF64DC-0x000000018BFF65A8 0x000000018BFF62E4-0x000000018BFF6354
			public IVisualTreeUpdater this[int index] { get => default; } // 0x000000018BFF6374-0x000000018BFF63E0 
	
			// Constructors
			public UpdaterArray() {} // 0x000000018BFF65A8-0x000000018BFF6628
		}
	
		// Constructors
		public VisualTreeUpdater() {} // Dummy constructor
		public VisualTreeUpdater(BaseVisualElementPanel panel) {}
	
		// Methods
		public void Dispose() {} // 0x000000018BFF6354-0x000000018BFF6374
		public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) {} // 0x000000018BFF63E0-0x000000018BFF64DC
		public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018BFECD90-0x000000018BFECDD8
		public void SetUpdater<T>(VisualTreeUpdatePhase phase)
			where T : IVisualTreeUpdater, new() {} // 0x0000000187B1A544-0x0000000187B1A5A0
		public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) => default; // 0x0000000187B1A518-0x0000000187B1A544
		private void SetDefaultUpdaters() {} // 0x0000000187B1A518-0x0000000187B1A544
	}

	internal interface IVisualTreeUpdater : IDisposable // TypeDefIndex: 44348
	{
		// Properties
		BaseVisualElementPanel panel { get; set; }
		ProfilerMarker profilerMarker { get; }
	
		// Methods
		void Update();
		void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
	}

	internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater // TypeDefIndex: 44349
	{
		// Fields
		private Action<BaseVisualElementPanel> panelChanged; // 0x10
		private BaseVisualElementPanel m_Panel; // 0x18
	
		// Properties
		public BaseVisualElementPanel panel { get; set; } // 0x0000000185FC2A70-0x0000000185FC2A80 0x000000018BFE5B1C-0x000000018BFE5B50
		public VisualElement visualTree { get; } // 0x000000018BFE5A6C-0x000000018BFE5A90 
		public abstract ProfilerMarker profilerMarker { get; }
	
		// Events
		public event Action<BaseVisualElementPanel> panelChanged;
	
		// Constructors
		protected BaseVisualTreeUpdater() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x000000018BFE5990-0x000000018BFE59E0
		protected virtual void Dispose(bool disposing) {} // 0x0000000185492010-0x0000000185492020
		public abstract void Update();
		public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
	}

	internal class VisualTreeViewDataUpdater : BaseVisualTreeUpdater // TypeDefIndex: 44350
	{
		// Fields
		private HashSet<VisualElement> m_UpdateList; // 0x20
		private HashSet<VisualElement> m_ParentList; // 0x28
		private uint m_Version; // 0x30
		private uint m_LastVersion; // 0x34
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x000000018BFF6AB0-0x000000018BFF6CF0 
	
		// Constructors
		public VisualTreeViewDataUpdater() {} // 0x000000018BFF6A00-0x000000018BFF6AB0
		static VisualTreeViewDataUpdater() {} // 0x000000018BFF696C-0x000000018BFF6A00
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018BFF6628-0x000000018BFF66A4
		public override void Update() {} // 0x000000018BFF6724-0x000000018BFF6828
		private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence) {} // 0x000000018BFF6828-0x000000018BFF696C
		private void PropagateToParents(VisualElement ve) {} // 0x000000018BFF66A4-0x000000018BFF6724
	}

	internal interface IBindingRequest // TypeDefIndex: 44351
	{
		// Methods
		void Bind(VisualElement element);
	}

	internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater // TypeDefIndex: 44352
	{
		// Fields
		private static readonly PropertyName s_BindingRequestObjectVEPropertyName; // 0x00
		private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; // 0x04
		private static readonly string s_Description; // 0x08
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x10
		private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; // 0x18
		private static ProfilerMarker s_MarkerUpdate; // 0x20
		private static ProfilerMarker s_MarkerPoll; // 0x28
		private static bool _disableBindingsThrottling_k__BackingField; // 0x30
		private readonly HashSet<VisualElement> m_ElementsWithBindings; // 0x38
		private readonly HashSet<VisualElement> m_ElementsToAdd; // 0x40
		private readonly HashSet<VisualElement> m_ElementsToRemove; // 0x48
		private long m_LastUpdateTime; // 0x50
		private HashSet<VisualElement> m_ElementsToBind; // 0x58
		private Dictionary<object, object> _temporaryObjectCache_k__BackingField; // 0x60
		private List<IBinding> updatedBindings; // 0x68
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x000000018BFF3D68-0x000000018BFF3DB8 
		public Dictionary<object, object> temporaryObjectCache { get; } // 0x0000000185FB0530-0x0000000185FB0540 
	
		// Constructors
		public VisualTreeBindingsUpdater() {} // 0x000000018BFF3BB8-0x000000018BFF3D68
		static VisualTreeBindingsUpdater() {} // 0x000000018BFF39F4-0x000000018BFF3BB8
	
		// Methods
		private IBinding GetBindingObjectFromElement(VisualElement ve) => default; // 0x000000018BFF2AD4-0x000000018BFF2B58
		private void StartTracking(VisualElement ve) {} // 0x000000018BFF3000-0x000000018BFF3078
		private void StopTracking(VisualElement ve) {} // 0x000000018BFF3178-0x000000018BFF31F0
		public static IBinding GetAdditionalBinding(VisualElement ve) => default; // 0x000000018BFF2A5C-0x000000018BFF2AD4
		private void StartTrackingRecursive(VisualElement ve) {} // 0x000000018BFF2EEC-0x000000018BFF3000
		private void StopTrackingRecursive(VisualElement ve) {} // 0x000000018BFF3078-0x000000018BFF3178
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018BFF2B80-0x000000018BFF2C60
		protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) {} // 0x000000018BFF2B58-0x000000018BFF2B80
		private static long CurrentTime() => default; // 0x000000018BFF2A1C-0x000000018BFF2A5C
		public void PerformTrackingOperations() {} // 0x000000018BFF2C60-0x000000018BFF2EEC
		public override void Update() {} // 0x000000018BFF35C0-0x000000018BFF39F4
		private void UpdateBindings() {} // 0x000000018BFF31F0-0x000000018BFF35C0
	}

	public abstract class BaseListViewController : CollectionViewController // TypeDefIndex: 44353
	{
		// Fields
		private Action itemsSourceSizeChanged; // 0x30
		private Action<IEnumerable<int>> itemsAdded; // 0x38
		private Action<IEnumerable<int>> itemsRemoved; // 0x40
	
		// Properties
		protected BaseListView baseListView { get; } // 0x000000018BFE5548-0x000000018BFE5584 
	
		// Events
		public event Action itemsSourceSizeChanged;
		public event Action<IEnumerable<int>> itemsAdded;
		public event Action<IEnumerable<int>> itemsRemoved;
	
		// Constructors
		protected BaseListViewController() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x000000018BFE48EC-0x000000018BFE49BC
		internal void PostInitRegistration(ReusableListViewItem listItem) {} // 0x000000018BFE4A9C-0x000000018BFE4CD8
		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) {} // 0x000000018BFE481C-0x000000018BFE48EC
		public virtual bool NeedsDragHandle(int index) => default; // 0x0000000185FC71B0-0x0000000185FC71C0
		public virtual void AddItems(int itemCount) {} // 0x000000018BFE41A4-0x000000018BFE45C0
		public virtual void Move(int index, int newIndex) {} // 0x000000018BFE49BC-0x000000018BFE4A9C
		public virtual void RemoveItem(int index) {} // 0x000000018BFE4E8C-0x000000018BFE4FA4
		public virtual void RemoveItems(List<int> indices) {} // 0x000000018BFE50EC-0x000000018BFE5238
		internal virtual void RemoveItems(int itemCount) {} // 0x000000018BFE4FA4-0x000000018BFE50EC
		public virtual void ClearItems() {} // 0x000000018BFE46A0-0x000000018BFE473C
		protected void RaiseOnSizeChanged() {} // 0x000000018BFE4D00-0x000000018BFE4D10
		protected void RaiseItemsAdded(IEnumerable<int> indices) {} // 0x000000018BFE4CD8-0x000000018BFE4CEC
		protected void RaiseItemsRemoved(IEnumerable<int> indices) {} // 0x000000018BFE4CEC-0x000000018BFE4D00
		private static Array AddToArray(Array source, int itemCount) => default; // 0x000000018BFE45C0-0x000000018BFE46A0
		private static Array RemoveFromArray(Array source, List<int> indicesToRemove) => default; // 0x000000018BFE4D10-0x000000018BFE4E8C
		private void Swap(int lhs, int rhs) {} // 0x000000018BFE5238-0x000000018BFE5308
		private void EnsureItemSourceCanBeResized() {} // 0x000000018BFE473C-0x000000018BFE481C
		internal static bool _AddItems_g__IsGenericList_15_0(System.Type t) => default; // 0x000000018BFE5308-0x000000018BFE539C
	}

	public abstract class BaseTreeViewController : CollectionViewController // TypeDefIndex: 44355
	{
		// Fields
		private Dictionary<int, TreeItem> m_TreeItems; // 0x30
		private List<int> m_RootIndices; // 0x38
		private List<TreeViewItemWrapper> m_ItemWrappers; // 0x40
		private HashSet<int> m_TreeItemIdsWithItemWrappers; // 0x48
		private List<TreeViewItemWrapper> m_WrapperInsertionList; // 0x50
		private static readonly ProfilerMarker K_ExpandItemByIndex; // 0x00
		private static readonly ProfilerMarker k_CreateWrappers; // 0x08
	
		// Properties
		protected BaseTreeView baseTreeView { get; } // 0x000000018BFFBE08-0x000000018BFFBE64 
		public override IList itemsSource { get; set; } // 0x000000018BFFB87C-0x000000018BFFBB14 0x0000000185FE7CE0-0x0000000185FE7CF0
	
		// Nested types
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 44354
		{
			// Fields
			public BaseTreeViewController __4__this; // 0x10
			public ReusableTreeViewItem treeItem; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0() {} // 0x000000018BFFBDCC-0x000000018BFFBE08
	
			// Methods
			internal void _PostInitRegistration_b__0() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		protected BaseTreeViewController() {} // 0x0000000185492010-0x0000000185492020
		static BaseTreeViewController() {} // 0x000000018C009DC8-0x000000018C009E04
	
		// Methods
		public void RebuildTree() {}
		public IEnumerable<int> GetRootItemIds() => default;
		public abstract IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null);
		public abstract int GetParentId(int id);
		public abstract IEnumerable<int> GetChildrenIds(int id); // 0x000000018BFFAEFC-0x000000018BFFAF78
		public abstract void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x0205B584 */, bool rebuildTree = true /* Metadata: 0x0205B585 */); // 0x000000018BFFAD24-0x000000018BFFADE8
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x000000018BFFADE8-0x000000018BFFAEFC
		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) {} // 0x000000018BFFB66C-0x000000018BFFB868
		internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem) {} // 0x000000018BFFB0C0-0x000000018BFFB564
		internal void PostInitRegistration(ReusableTreeViewItem treeItem) {} // 0x000000018BFFB564-0x000000018BFFB66C
		private void OnItemPointerUp(PointerUpEvent evt) {} // 0x000000018BFFAB58-0x000000018BFFAC08
		private void OnToggleValueChanged(ChangeEvent<bool> evt) {} // 0x000000018BFFAA74-0x000000018BFFAAE8
		public override int GetIndexForId(int id) => default; // 0x000000018BFFACA4-0x000000018BFFAD24
		public override int GetIdForIndex(int index) => default; // 0x000000018BFFA020-0x000000018BFFA074
		public virtual bool HasChildren(int id) => default; // 0x000000018BFFAC08-0x000000018BFFACA4
		internal bool Exists(int id) => default; // 0x000000018BFFA9F4-0x000000018BFFAA74
		public bool HasChildrenByIndex(int index) => default; // 0x000000018BFFA80C-0x000000018BFFA9F4
		public IEnumerable<int> GetChildrenIdsByIndex(int index) => default; // 0x000000018BFFAB14-0x000000018BFFAB58
		public int GetChildIndexForId(int id) => default; // 0x000000018BFFAAE8-0x000000018BFFAB14
		internal int GetIndentationDepth(int id) => default; // 0x0000000185FC71B0-0x0000000185FC71C0
		internal int GetIndentationDepthByIndex(int index) => default; // 0x000000018BFFB000-0x000000018BFFB064
		internal virtual bool CanChangeExpandedState(int id) => default; // 0x000000018BFFAF78-0x000000018BFFB000
		public bool IsExpanded(int id) => default; // 0x000000018BFFA074-0x000000018BFFA6B8
		public bool IsExpandedByIndex(int index) => default; // 0x000000018BFFA6B8-0x000000018BFFA80C
		public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true /* Metadata: 0x0205B586 */) {} // 0x000000018BFF9784-0x000000018BFF9AC8
		public void ExpandItem(int id, bool expandAllChildren, bool refresh = true /* Metadata: 0x0205B587 */) {} // 0x000000018BFF9AC8-0x000000018BFF9BF0
		public void CollapseItemByIndex(int index, bool collapseAllChildren) {} // 0x000000018BFFBB14-0x000000018BFFBBA8
		public void CollapseItem(int id, bool collapseAllChildren) {} // 0x000000018BFF9BF0-0x000000018BFFA020
		internal void RegenerateWrappers() {} // 0x000000018BFFB064-0x000000018BFFB0C0
		private void CreateWrappers(IEnumerable<int> treeViewItemIds, int depth, ref List<TreeViewItemWrapper> wrappers) {} // 0x000000018BFFB868-0x000000018BFFB87C
		private bool IsIndexValid(int index) => default; // 0x000000018BFFBC40-0x000000018BFFBDCC
		internal void RaiseItemParentChanged(int id, int newParentId) {} // 0x000000018BFFBBA8-0x000000018BFFBC40
	}

	public abstract class CollectionViewController : IDisposable // TypeDefIndex: 44356
	{
		// Fields
		private BaseVerticalCollectionView m_View; // 0x10
		private IList m_ItemsSource; // 0x18
		private Action itemsSourceChanged; // 0x20
		private Action<int, int> itemIndexChanged; // 0x28
	
		// Properties
		public virtual IList itemsSource { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x000000018C002864-0x000000018C002904
		protected BaseVerticalCollectionView view { get; } // 0x000000018346D130-0x000000018346D140 
	
		// Events
		public event Action itemsSourceChanged;
		public event Action<int, int> itemIndexChanged;
	
		// Constructors
		protected CollectionViewController() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected void SetItemsSourceWithoutNotify(IList source) {} // 0x0000000184088E70-0x0000000184088E80
		public void SetView(BaseVerticalCollectionView collectionView) {} // 0x000000018C002594-0x000000018C002624
		protected virtual void PrepareView() {} // 0x0000000185492010-0x0000000185492020
		public virtual void Dispose() {} // 0x000000018C002370-0x000000018C0023A8
		public virtual int GetItemsCount() => default; // 0x000000018C002408-0x000000018C002428
		internal virtual int GetItemsMinCount() => default; // 0x000000018C002428-0x000000018C002430
		public virtual int GetIndexForId(int id) => default; // 0x0000000185FC7A40-0x0000000185FC7A50
		public virtual int GetIdForIndex(int index) => default; // 0x0000000185FC7A40-0x0000000185FC7A50
		public virtual object GetItemForIndex(int index) => default; // 0x000000018C0023A8-0x000000018C002408
		internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x000000018C002514-0x000000018C00254C
		internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) {} // 0x000000018C002430-0x000000018C0024EC
		internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index) {} // 0x000000018C00254C-0x000000018C002584
		internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) {} // 0x000000018C0024EC-0x000000018C002514
		protected abstract VisualElement MakeItem();
		protected abstract void BindItem(VisualElement element, int index);
		protected abstract void UnbindItem(VisualElement element, int index);
		protected abstract void DestroyItem(VisualElement element);
		protected void RaiseItemsSourceChanged() {} // 0x000000018C002584-0x000000018C002594
		protected void RaiseItemIndexChanged(int srcIndex, int dstIndex) {} // 0x000000018BFFB868-0x000000018BFFB87C
	}

	internal class DefaultMultiColumnTreeViewController<T> : MultiColumnTreeViewController // TypeDefIndex: 44357
	{
		// Fields
		private TreeDataController<T> m_TreeDataController;
	
		// Properties
		private TreeDataController<T> treeDataController { get => default; }
		public override IList itemsSource { get => default; set {} }
	
		// Constructors
		public DefaultMultiColumnTreeViewController() {} // Dummy constructor
		public DefaultMultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {}
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> items) {}
		public override object GetItemForIndex(int index) => default;
		public override int GetParentId(int id) => default;
		public override bool HasChildren(int id) => default;
		public override IEnumerable<int> GetChildrenIds(int id) => default;
		public override void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x0205B588 */, bool rebuildTree = true /* Metadata: 0x0205B589 */) {}
		private bool IsChildOf(int childId, int id) => default;
		public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null) => default;
	}

	internal class DefaultTreeViewController<T> : TreeViewController // TypeDefIndex: 44358
	{
		// Fields
		private TreeDataController<T> m_TreeDataController;
	
		// Properties
		private TreeDataController<T> treeDataController { get => default; }
		public override IList itemsSource { get => default; set {} }
	
		// Constructors
		public DefaultTreeViewController() {}
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> items) {}
		public override object GetItemForIndex(int index) => default;
		public override int GetParentId(int id) => default;
		public override bool HasChildren(int id) => default;
		public override IEnumerable<int> GetChildrenIds(int id) => default;
		public override void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x0205B58A */, bool rebuildTree = true /* Metadata: 0x0205B58B */) {}
		private bool IsChildOf(int childId, int id) => default;
		public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null) => default;
	}

	public class ListViewController : BaseListViewController // TypeDefIndex: 44359
	{
		// Properties
		protected ListView listView { get => default; } // 0x000000018C006B1C-0x000000018C006B58 
	
		// Constructors
		public ListViewController() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override VisualElement MakeItem() => default; // 0x000000018C0069D4-0x000000018C006AD4
		protected override void BindItem(VisualElement element, int index) {} // 0x000000018C006818-0x000000018C00699C
		protected override void UnbindItem(VisualElement element, int index) {} // 0x000000018C006AD4-0x000000018C006B1C
		protected override void DestroyItem(VisualElement element) {} // 0x000000018C00699C-0x000000018C0069D4
	}

	public class MultiColumnListViewController : BaseListViewController // TypeDefIndex: 44360
	{
		// Fields
		private MultiColumnController m_ColumnController; // 0x48
	
		// Properties
		public MultiColumnController columnController { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
		internal MultiColumnCollectionHeader header { get => default; } // 0x000000018C006FF4-0x000000018C007004 
	
		// Constructors
		public MultiColumnListViewController() {} // Dummy constructor
		public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {} // 0x000000018C006F58-0x000000018C006FF4
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x000000018C006CC4-0x000000018C006DA4
		protected override VisualElement MakeItem() => default; // 0x000000018C006DA4-0x000000018C006DC4
		protected override void BindItem(VisualElement element, int index) {} // 0x000000018C006B58-0x000000018C006BE4
		protected override void UnbindItem(VisualElement element, int index) {} // 0x000000018C006E74-0x000000018C006E94
		protected override void DestroyItem(VisualElement element) {} // 0x000000018C006BE4-0x000000018C006C04
		protected override void PrepareView() {} // 0x000000018C006DC4-0x000000018C006E74
		public override void Dispose() {} // 0x000000018C006C04-0x000000018C006CC4
		private void UpdateReorderClassList() {} // 0x000000018C006E94-0x000000018C006F58
	}

	public abstract class MultiColumnTreeViewController : BaseTreeViewController // TypeDefIndex: 44361
	{
		// Fields
		private MultiColumnController m_ColumnController; // 0x58
	
		// Properties
		public MultiColumnController columnController { get; } // 0x00000001813F1630-0x00000001813F1640 
		internal MultiColumnCollectionHeader header { get; } // 0x000000018C0072C4-0x000000018C0072D4 
	
		// Constructors
		protected MultiColumnTreeViewController() {} // Dummy constructor
		protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {} // 0x000000018C007208-0x000000018C0072C4
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x000000018C0070F0-0x000000018C0071A0
		protected override VisualElement MakeItem() => default; // 0x000000018C0071A0-0x000000018C0071C0
		protected override void BindItem(VisualElement element, int index) {} // 0x000000018C007004-0x000000018C007090
		protected override void UnbindItem(VisualElement element, int index) {} // 0x000000018C0071E8-0x000000018C007208
		protected override void DestroyItem(VisualElement element) {} // 0x000000018C007090-0x000000018C0070B0
		protected override void PrepareView() {} // 0x000000018C0071C0-0x000000018C0071E8
		public override void Dispose() {} // 0x000000018C0070B0-0x000000018C0070F0
	}

	internal sealed class TreeDataController<T> // TypeDefIndex: 44364
	{
		// Fields
		private TreeData<T> m_TreeData;
		private Stack<IEnumerator<int>> m_IteratorStack;
	
		// Nested types
		private sealed class _GetItemIds_d__9 : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 44362
		{
			// Fields
			private int __1__state;
			private int __2__current;
			private int __l__initialThreadId;
			private IEnumerable<TreeViewItemData<T>> items;
			public IEnumerable<TreeViewItemData<T>> __3__items;
			private IEnumerator<TreeViewItemData<T>> __s__1;
			private TreeViewItemData<T> _item_5__2;
	
			// Properties
			int IEnumerator<System.Int32>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetItemIds_d__9() {} // Dummy constructor
			public _GetItemIds_d__9(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			private void __m__Finally1() {}
			void IEnumerator.Reset() {}
			IEnumerator<int> IEnumerable<int>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		private sealed class _GetAllItemIds_d__13 : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 44363
		{
			// Fields
			private int __1__state;
			private int __2__current;
			private int __l__initialThreadId;
			private IEnumerable<int> rootIds;
			public IEnumerable<int> __3__rootIds;
			public TreeDataController<T> __4__this;
			private IEnumerator<int> _currentIterator_5__1;
			private bool _hasNext_5__2;
			private int _currentItemId_5__3;
	
			// Properties
			int IEnumerator<System.Int32>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetAllItemIds_d__13() {} // Dummy constructor
			public _GetAllItemIds_d__13(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
			IEnumerator<int> IEnumerable<int>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		// Constructors
		public TreeDataController() {}
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> rootItems) {}
		public T GetDataForId(int id) => default;
		public int GetParentId(int id) => default;
		public bool HasChildren(int id) => default;
		private static IEnumerable<int> GetItemIds(IEnumerable<TreeViewItemData<T>> items) => default;
		public IEnumerable<int> GetChildrenIds(int id) => default;
		public void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x0205B58C */) {}
		public bool IsChildOf(int childId, int id) => default;
		public IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null) => default;
	}

	public abstract class TreeViewController : BaseTreeViewController // TypeDefIndex: 44365
	{
		// Properties
		protected TreeView treeView { get; } // 0x000000018C009D6C-0x000000018C009DA8 
	
		// Constructors
		protected TreeViewController() {} // 0x000000018C009D20-0x000000018C009D6C
	
		// Methods
		protected override VisualElement MakeItem() => default; // 0x000000018C009BD8-0x000000018C009CD8
		protected override void BindItem(VisualElement element, int index) {} // 0x000000018C009A40-0x000000018C009BA0
		protected override void UnbindItem(VisualElement element, int index) {} // 0x000000018C009CD8-0x000000018C009D20
		protected override void DestroyItem(VisualElement element) {} // 0x000000018C009BA0-0x000000018C009BD8
	}

	internal abstract class CollectionVirtualizationController // TypeDefIndex: 44366
	{
		// Fields
		protected readonly ScrollView m_ScrollView; // 0x10
	
		// Properties
		public abstract int firstVisibleIndex { get; protected set; }
		public abstract int visibleItemCount { get; }
		public abstract IEnumerable<ReusableCollectionItem> activeItems { get; }
	
		// Constructors
		protected CollectionVirtualizationController() {} // Dummy constructor
		protected CollectionVirtualizationController(ScrollView scrollView) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public abstract void Refresh(bool rebuild);
		public abstract void ScrollToItem(int id);
		public abstract void Resize(Vector2 size);
		public abstract void OnScroll(Vector2 offset);
		public abstract int GetIndexFromPosition(Vector2 position);
		public abstract float GetExpectedItemHeight(int index);
		public abstract float GetExpectedContentHeight();
		public abstract void OnFocus(VisualElement leafTarget);
		public abstract void OnBlur(VisualElement willFocus);
		public abstract void UpdateBackground();
		internal abstract void StartDragItem(ReusableCollectionItem item);
		internal abstract void EndDrag(int dropIndex);
	}

	internal class DynamicHeightVirtualizationController<T> : VerticalVirtualizationController<T> // TypeDefIndex: 44370
		where T : ReusableCollectionItem, new()
	{
		// Fields
		private int m_HighestCachedIndex;
		private readonly Dictionary<int, float> m_ItemHeightCache;
		private readonly Dictionary<int, ContentHeightCacheInfo> m_ContentHeightCache;
		private readonly HashSet<int> m_WaitingCache;
		private int m_ForcedFirstVisibleItem;
		private int m_ForcedLastVisibleItem;
		private bool m_StickToBottom;
		private VirtualizationChange m_LastChange;
		private ScrollDirection m_ScrollDirection;
		private Vector2 m_DelayedScrollOffset;
		private float m_AccumulatedHeight;
		private float m_MinimumItemHeight;
		private Action m_FillCallback;
		private Action m_ScrollCallback;
		private Action m_ScrollResetCallback;
		private Action<ReusableCollectionItem> m_GeometryChangedCallback;
		private IVisualElementScheduledItem m_ScheduledItem;
		private IVisualElementScheduledItem m_ScrollScheduledItem;
		private IVisualElementScheduledItem m_ScrollResetScheduledItem;
		private Predicate<int> m_IndexOutOfBoundsPredicate;
	
		// Properties
		private float defaultExpectedHeight { get => default; }
		private float contentPadding { get => default; set {} }
		private float contentHeight { get => default; set {} }
		private int anchoredIndex { get => default; set {} }
		private float anchorOffset { get => default; set {} }
		private float viewportMaxOffset { get => default; }
		protected override bool alwaysRebindOnRefresh { get => default; }
	
		// Nested types
		private struct ContentHeightCacheInfo // TypeDefIndex: 44367
		{
			// Fields
			public readonly float sum;
			public readonly int count;
	
			// Constructors
			public ContentHeightCacheInfo(float sum, int count) {
				this.sum = default;
				this.count = default;
			}
		}
	
		private enum VirtualizationChange // TypeDefIndex: 44368
		{
			None = 0,
			Resize = 1,
			Scroll = 2,
			ForcedScroll = 3
		}
	
		private enum ScrollDirection // TypeDefIndex: 44369
		{
			Idle = 0,
			Up = 1,
			Down = 2
		}
	
		// Constructors
		public DynamicHeightVirtualizationController() {} // Dummy constructor
		public DynamicHeightVirtualizationController(BaseVerticalCollectionView collectionView) {}
	
		// Methods
		public override void Refresh(bool rebuild) {}
		public override void ScrollToItem(int index) {}
		public override void Resize(Vector2 size) {}
		public override void OnScroll(Vector2 scrollOffset) {}
		private void OnScrollUpdate() {}
		private void CycleItems(int firstIndex) {}
		private bool NeedsFill() => default;
		private void Fill() {}
		private void UpdateScrollViewContainer(float previousHeight, float newHeight) {}
		private void ApplyScrollViewUpdate(bool dimensionsOnly = false /* Metadata: 0x0205B58D */) {}
		private void UpdateAnchor() {}
		private void ScheduleFill() {}
		private void ScheduleScroll() {}
		private void ScheduleScrollDirectionReset() {}
		private void ResetScroll() {}
		public override int GetIndexFromPosition(Vector2 position) => default;
		public override float GetExpectedItemHeight(int index) => default;
		private int GetFirstVisibleItem(float offset) => default;
		public override float GetExpectedContentHeight() => default;
		private float GetContentHeightForIndex(int lastIndex) => default;
		private ContentHeightCacheInfo GetCachedContentHeight(int index) => default;
		private void RegisterItemHeight(int index, float height) {}
		private void UnregisterItemHeight(int index) {}
		private void CleanItemHeightCache() {}
		private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) {}
		private bool UpdateRegisteredHeight(ReusableCollectionItem item) => default;
		internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x0205B58E */, int scrollViewIndex = -1 /* Metadata: 0x0205B58F */) => default;
		internal override void ReleaseItem(int activeItemsIndex) {}
		internal override void StartDragItem(ReusableCollectionItem item) {}
		internal override void EndDrag(int dropIndex) {}
		private void HideItem(int activeItemsIndex) {}
		private void MarkWaitingForLayout(T item) {}
		private bool IsIndexOutOfBounds(int i) => default;
	}

	internal class FixedHeightVirtualizationController<T> : VerticalVirtualizationController<T> // TypeDefIndex: 44371
		where T : ReusableCollectionItem, new()
	{
		// Properties
		private float resolvedItemHeight { get => default; }
	
		// Constructors
		public FixedHeightVirtualizationController() {} // Dummy constructor
		public FixedHeightVirtualizationController(BaseVerticalCollectionView collectionView) {}
	
		// Methods
		protected override bool VisibleItemPredicate(T i) => default;
		public override int GetIndexFromPosition(Vector2 position) => default;
		public override float GetExpectedItemHeight(int index) => default;
		public override float GetExpectedContentHeight() => default;
		public override void ScrollToItem(int index) {}
		public override void Resize(Vector2 size) {}
		public override void OnScroll(Vector2 scrollOffset) {}
		internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x0205B597 */, int scrollViewIndex = -1 /* Metadata: 0x0205B598 */) => default;
		internal override void EndDrag(int dropIndex) {}
	}

	internal class ReusableCollectionItem // TypeDefIndex: 44372
	{
		// Fields
		private VisualElement _bindableElement_k__BackingField; // 0x10
		private ValueAnimation<StyleValues> _animator_k__BackingField; // 0x18
		private int _index_k__BackingField; // 0x20
		private int _id_k__BackingField; // 0x24
		private bool _isDragGhost_k__BackingField; // 0x28
		private Action<ReusableCollectionItem> onGeometryChanged; // 0x30
		protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback; // 0x38
		private Action<ReusableCollectionItem> onDestroy; // 0x40
	
		// Properties
		public virtual VisualElement rootElement { get => default; } // 0x000000018346D130-0x000000018346D140 
		public VisualElement bindableElement { get; protected set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public ValueAnimation<StyleValues> animator { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public int index { get; set; } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		public int id { get; set; } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		internal bool isDragGhost { get; private set; } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
	
		// Events
		public event Action<ReusableCollectionItem> onGeometryChanged;
		internal event Action<ReusableCollectionItem> onDestroy;
	
		// Constructors
		public ReusableCollectionItem() {} // 0x000000018C0077C0-0x000000018C007844
	
		// Methods
		public virtual void Init(VisualElement item) {} // 0x0000000184096E30-0x0000000184096EF0
		public virtual void PreAttachElement() {} // 0x000000018C0074DC-0x000000018C007588
		public virtual void DetachElement() {} // 0x000000018C0073D0-0x000000018C0074C4
		public virtual void DestroyElement() {} // 0x000000018C0073B8-0x000000018C0073D0
		public virtual void SetSelected(bool selected) {} // 0x000000018C0076BC-0x000000018C0077C0
		public virtual void SetDragGhost(bool dragGhost) {} // 0x000000018C007588-0x000000018C0076BC
		protected void OnGeometryChanged(GeometryChangedEvent evt) {} // 0x000000018C0074C4-0x000000018C0074DC
	}

	internal class ReusableListViewItem : ReusableCollectionItem // TypeDefIndex: 44373
	{
		// Fields
		private VisualElement m_Container; // 0x48
		private VisualElement m_DragHandle; // 0x50
		private VisualElement m_ItemContainer; // 0x58
	
		// Properties
		public override VisualElement rootElement { get => default; } // 0x000000018C0080A8-0x000000018C0080B8 
	
		// Constructors
		public ReusableListViewItem() {} // 0x000000018C0080A0-0x000000018C0080A8
	
		// Methods
		public void Init(VisualElement item, bool usesAnimatedDragger) {} // 0x000000018C007AEC-0x000000018C007BB0
		protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) {} // 0x000000018C007DC0-0x000000018C0080A0
		public void UpdateDragHandle(bool needsDragHandle) {} // 0x000000018C007CAC-0x000000018C007DC0
		public override void PreAttachElement() {} // 0x000000018C007BB0-0x000000018C007C28
		public override void DetachElement() {} // 0x000000018C007A74-0x000000018C007AEC
		public override void SetDragGhost(bool dragGhost) {} // 0x000000018C007C28-0x000000018C007CAC
	}

	internal class ReusableMultiColumnListViewItem : ReusableListViewItem // TypeDefIndex: 44374
	{
		// Properties
		public override VisualElement rootElement { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public ReusableMultiColumnListViewItem() {} // 0x000000018C0080A0-0x000000018C0080A8
	
		// Methods
		public override void Init(VisualElement item) {} // 0x0000000185492010-0x0000000185492020
		public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag) {} // 0x000000018C0080B8-0x000000018C0082D8
	}

	internal class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem // TypeDefIndex: 44375
	{
		// Properties
		public override VisualElement rootElement { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public ReusableMultiColumnTreeViewItem() {} // 0x000000018C0084E0-0x000000018C0084E8
	
		// Methods
		public override void Init(VisualElement item) {} // 0x0000000185492010-0x0000000185492020
		public void Init(VisualElement container, Columns columns) {} // 0x000000018C0082D8-0x000000018C0084E0
	}

	internal class ReusableTreeViewItem : ReusableCollectionItem // TypeDefIndex: 44376
	{
		// Fields
		private Toggle m_Toggle; // 0x48
		private VisualElement m_Container; // 0x50
		private VisualElement m_IndentElement; // 0x58
		private VisualElement m_BindableContainer; // 0x60
		private VisualElement m_Checkmark; // 0x68
		private Action<PointerUpEvent> onPointerUp; // 0x70
		private Action<ChangeEvent<bool>> onToggleValueChanged; // 0x78
		private int m_Depth; // 0x80
		private float m_IndentWidth; // 0x84
		private EventCallback<PointerUpEvent> m_PointerUpCallback; // 0x88
		private EventCallback<ChangeEvent<bool>> m_ToggleValueChangedCallback; // 0x90
		private EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback; // 0x98
	
		// Properties
		public override VisualElement rootElement { get => default; } // 0x000000018C009134-0x000000018C009144 
	
		// Events
		public event Action<PointerUpEvent> onPointerUp;
		public event Action<ChangeEvent<bool>> onToggleValueChanged;
	
		// Constructors
		public ReusableTreeViewItem() {} // 0x000000018C008EE4-0x000000018C00901C
	
		// Methods
		public override void Init(VisualElement item) {} // 0x000000018C008A90-0x000000018C008B68
		protected void InitExpandHierarchy(VisualElement root, VisualElement item) {} // 0x000000018C00867C-0x000000018C008A90
		public override void PreAttachElement() {} // 0x000000018C008C64-0x000000018C008DE0
		public override void DetachElement() {} // 0x000000018C0084E8-0x000000018C008664
		public void Indent(int depth) {} // 0x000000018C008664-0x000000018C00867C
		public void SetExpandedWithoutNotify(bool expanded) {} // 0x000000018C008DE0-0x000000018C008DF8
		public void SetToggleVisibility(bool visible) {} // 0x000000018C008DF8-0x000000018C008E14
		private void OnToggleGeometryChanged(GeometryChangedEvent evt) {} // 0x000000018C008B7C-0x000000018C008C50
		private void UpdateIndentLayout() {} // 0x000000018C008E14-0x000000018C008EE4
		private void OnPointerUp(PointerUpEvent evt) {} // 0x000000018C008B68-0x000000018C008B7C
		private void OnToggleValueChanged(ChangeEvent<bool> evt) {} // 0x000000018C008C50-0x000000018C008C64
	}

	internal abstract class VerticalVirtualizationController<T> : CollectionVirtualizationController // TypeDefIndex: 44378
		where T : ReusableCollectionItem, new()
	{
		// Fields
		private readonly UnityEngine.Pool.ObjectPool<T> m_Pool;
		protected BaseVerticalCollectionView m_CollectionView;
		protected List<T> m_ActiveItems;
		protected T m_DraggedItem;
		private int m_LastFocusedElementIndex;
		private List<int> m_LastFocusedElementTreeChildIndexes;
		protected readonly Func<T, bool> m_VisibleItemPredicateDelegate;
		protected List<T> m_ScrollInsertionList;
		private VisualElement m_EmptyRows;
	
		// Properties
		public override IEnumerable<ReusableCollectionItem> activeItems { get; }
		internal int itemsCount { get; }
		internal T firstVisibleItem { get; }
		internal T lastVisibleItem { get; }
		public override int visibleItemCount { get; }
		protected SerializedVirtualizationData serializedData { get; }
		public override int firstVisibleIndex { get; protected set; }
		protected float lastHeight { get; }
		protected virtual bool alwaysRebindOnRefresh { get; }
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44377
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<T> __9__30_0;
			public static Action<T> __9__30_1;
			public static Action<T> __9__30_2;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal T _.ctor_b__30_0() => default;
			internal void _.ctor_b__30_1(T i) {}
			internal void _.ctor_b__30_2(T i) {}
		}
	
		// Constructors
		protected VerticalVirtualizationController() {} // Dummy constructor
		protected VerticalVirtualizationController(BaseVerticalCollectionView collectionView) {}
	
		// Methods
		protected virtual bool VisibleItemPredicate(T i) => default;
		public override void Refresh(bool rebuild) {}
		protected void Setup(T recycledItem, int newIndex) {}
		public override void OnFocus(VisualElement leafTarget) {}
		public override void OnBlur(VisualElement willFocus) {}
		private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) {}
		public override void UpdateBackground() {}
		internal override void StartDragItem(ReusableCollectionItem item) {}
		internal override void EndDrag(int dropIndex) {}
		internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x0205B599 */, int scrollViewIndex = -1 /* Metadata: 0x0205B59A */) => default;
		internal virtual void ReleaseItem(int activeItemsIndex) {}
		private void OnDestroyItem(ReusableCollectionItem item) {}
		protected int GetDraggedIndex() => default;
	}

	public abstract class BaseBoolField : BaseField<bool> // TypeDefIndex: 44379
	{
		// Fields
		protected UnityEngine.UIElements.Label m_Label; // 0x418
		protected readonly VisualElement m_CheckMark; // 0x420
		internal Clickable m_Clickable; // 0x428
		private string m_OriginalText; // 0x430
	
		// Properties
		public string text { get; set; } // 0x000000018BFF7484-0x000000018BFF74A4 0x000000018BFF74A4-0x000000018BFF752C
	
		// Constructors
		protected BaseBoolField() {} // Dummy constructor
		public BaseBoolField(string label) {} // 0x000000018BFF71FC-0x000000018BFF7484
	
		// Methods
		private void OnNavigationSubmit(NavigationSubmitEvent evt) {} // 0x000000018BFF6F8C-0x000000018BFF6FB8
		private void OnKeyDown(KeyDownEvent evt) {} // 0x000000018BFF6F04-0x000000018BFF6F8C
		protected virtual void InitLabel() {} // 0x000000018BFF6CF0-0x000000018BFF6D8C
		public override void SetValueWithoutNotify(bool newValue) {} // 0x000000018BFF6FB8-0x000000018BFF706C
		private void OnClickEvent(EventBase evt) {} // 0x000000018BFF6D8C-0x000000018BFF6F04
		protected virtual void ToggleValue() {} // 0x000000018BFF706C-0x000000018BFF709C
		protected override void UpdateMixedValueContent() {} // 0x000000018BFF709C-0x000000018BFF71FC
	}

	public abstract class BaseField<TValueType> : BindableElement, INotifyValueChanged<TValueType> // TypeDefIndex: 44381
	{
		// Fields
		public static readonly string ussClassName;
		public static readonly string labelUssClassName;
		public static readonly string inputUssClassName;
		public static readonly string noLabelVariantUssClassName;
		public static readonly string labelDraggerVariantUssClassName;
		public static readonly string mixedValueLabelUssClassName;
		public static readonly string alignedFieldUssClassName;
		private static readonly string inspectorFieldUssClassName;
		protected internal static readonly string mixedValueString;
		protected internal static readonly PropertyName serializedPropertyCopyName;
		private static CustomStyleProperty<float> s_LabelWidthRatioProperty;
		private static CustomStyleProperty<float> s_LabelExtraPaddingProperty;
		private static CustomStyleProperty<float> s_LabelBaseMinWidthProperty;
		private float m_LabelWidthRatio;
		private float m_LabelExtraPadding;
		private float m_LabelBaseMinWidth;
		private VisualElement m_VisualInput;
		private TValueType m_Value;
		private UnityEngine.UIElements.Label _labelElement_k__BackingField;
		private bool m_ShowMixedValue;
		private UnityEngine.UIElements.Label m_MixedValueLabel;
		private VisualElement m_CachedInspectorElement;
		private int m_CachedListAndFoldoutDepth;
	
		// Properties
		internal VisualElement visualInput { get; set; }
		protected TValueType rawValue { get; set; }
		public virtual TValueType value { get; set; }
		public UnityEngine.UIElements.Label labelElement { get; private set; }
		public string label { get; set; }
		public bool showMixedValue { get; set; }
		protected UnityEngine.UIElements.Label mixedValueLabel { get; }
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 44380
		{
			// Fields
			private UxmlStringAttributeDescription m_Label;
	
			// Constructors
			public UxmlTraits() {}
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {}
			internal static List<string> ParseChoiceList(string choicesFromBag) => default;
		}
	
		// Constructors
		protected BaseField() {} // Dummy constructor
		internal BaseField(string label) {}
		protected BaseField(string label, VisualElement visualInput) {}
		static BaseField() {}
	
		// Methods
		private void OnAttachToPanel(AttachToPanelEvent e) {}
		private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) {}
		private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) {}
		private void AlignLabel() {}
		protected virtual void UpdateMixedValueContent() {}
		public virtual void SetValueWithoutNotify(TValueType newValue) {}
		internal override void OnViewDataReady() {}
		internal override Rect GetTooltipRect() => default;
	}

	public class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : BaseField<TValueType> // TypeDefIndex: 44382
		where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
	{
		// Fields
		private TValueUxmlAttributeType m_Value;
	
		// Constructors
		public BaseFieldTraits() {}
	
		// Methods
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {}
	}

	public enum ListViewReorderMode // TypeDefIndex: 44383
	{
		Simple = 0,
		Animated = 1
	}

	public abstract class BaseListView : BaseVerticalCollectionView // TypeDefIndex: 44385
	{
		// Fields
		private static readonly string k_SizeFieldLabel; // 0x00
		private bool m_ShowBoundCollectionSize; // 0x4A8
		private bool m_ShowFoldoutHeader; // 0x4A9
		private string m_HeaderTitle; // 0x4B0
		private Action<IEnumerable<int>> itemsAdded; // 0x4B8
		private Action<IEnumerable<int>> itemsRemoved; // 0x4C0
		private Action itemsSourceSizeChanged; // 0x4C8
		private UnityEngine.UIElements.Label m_ListViewLabel; // 0x4D0
		protected UnityEngine.UIElements.Foldout m_Foldout; // 0x4D8
		protected TextField m_ArraySizeField; // 0x4E0
		private bool m_IsOverMultiEditLimit; // 0x4E8
		private VisualElement m_Footer; // 0x4F0
		private UnityEngine.UIElements.Button m_AddButton; // 0x4F8
		private UnityEngine.UIElements.Button m_RemoveButton; // 0x500
		private Action<IEnumerable<int>> m_ItemAddedCallback; // 0x508
		private Action<IEnumerable<int>> m_ItemRemovedCallback; // 0x510
		private Action m_ItemsSourceSizeChangedCallback; // 0x518
		private ListViewReorderMode m_ReorderMode; // 0x520
		private Action reorderModeChanged; // 0x528
		public static readonly string ussClassName; // 0x08
		public static readonly string itemUssClassName; // 0x10
		public static readonly string emptyLabelUssClassName; // 0x18
		public static readonly string overMaxMultiEditLimitClassName; // 0x20
		public static readonly string reorderableUssClassName; // 0x28
		public static readonly string reorderableItemUssClassName; // 0x30
		public static readonly string reorderableItemContainerUssClassName; // 0x38
		public static readonly string reorderableItemHandleUssClassName; // 0x40
		public static readonly string reorderableItemHandleBarUssClassName; // 0x48
		public static readonly string footerUssClassName; // 0x50
		public static readonly string foldoutHeaderUssClassName; // 0x58
		public static readonly string arraySizeFieldUssClassName; // 0x60
		public static readonly string arraySizeFieldWithHeaderUssClassName; // 0x68
		public static readonly string arraySizeFieldWithFooterUssClassName; // 0x70
		public static readonly string listViewWithHeaderUssClassName; // 0x78
		public static readonly string listViewWithFooterUssClassName; // 0x80
		public static readonly string scrollViewWithFooterUssClassName; // 0x88
		public static readonly string footerAddButtonName; // 0x90
		public static readonly string footerRemoveButtonName; // 0x98
		private string m_MaxMultiEditStr; // 0x530
		private static readonly string k_EmptyListStr; // 0xA0
	
		// Properties
		public bool showBoundCollectionSize { get; set; } // 0x0000000185FE9CC0-0x0000000185FE9CD0 0x000000018BFF9520-0x000000018BFF9784
		public bool showFoldoutHeader { get; set; } // 0x000000018BFF84F8-0x000000018BFF884C 0x000000018BFF9474-0x000000018BFF94B4
		public string headerTitle { get; set; } // 0x000000018BFF9500-0x000000018BFF9508
		public bool showAddRemoveFooter { get; set; } // 0x000000018BFF7674-0x000000018BFF7A8C 0x000000018BFF752C-0x000000018BFF7558
		internal VisualElement footer { get; } // 0x000000018BFF7638-0x000000018BFF7674 
		public new BaseListViewController viewController { get; } // 0x000000018BFF82A4-0x000000018BFF84F8 
		public ListViewReorderMode reorderMode { get; set; } // 0x000000018BFF75B8-0x000000018BFF7638 0x000000018BFF7558-0x000000018BFF75B8
	
		// Events
		internal event Action reorderModeChanged;
	
		// Nested types
		public class UxmlTraits : BaseVerticalCollectionView.UxmlTraits // TypeDefIndex: 44384
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; // 0xB0
			private readonly UxmlStringAttributeDescription m_HeaderTitle; // 0xB8
			private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; // 0xC0
			private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode; // 0xC8
			private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; // 0xD0
	
			// Constructors
			protected UxmlTraits() {} // 0x000000018BFF9508-0x000000018BFF9520
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000185FE9CB0-0x0000000185FE9CC0
		}
	
		// Constructors
		public BaseListView() {} // 0x000000018BFF7A8C-0x000000018BFF7D8C
		static BaseListView() {} // 0x000000018C00A488-0x000000018C00A640
	
		// Methods
		internal void SetupArraySizeField() {} // 0x000000018BFF9390-0x000000018BFF939C
		private void EnableFooter(bool enabled) {} // 0x000000018BFF7EA8-0x000000018BFF8090
		private void AddItems(int itemCount) {} // 0x000000018BFF8894-0x000000018BFF8954
		private void OnArraySizeFieldChanged(ChangeEvent<string> evt) {} // 0x000000018BFF8954-0x000000018BFF8B88
		internal void UpdateArraySizeField() {} // 0x000000018BFF7D8C-0x000000018BFF7EA8
		internal void UpdateListViewLabel() {} // 0x000000018BFF8134-0x000000018BFF8278
		private void OnAddClicked() {} // 0x0000000185FCD500-0x0000000185FCD510
		private void OnRemoveClicked() {} // 0x000000018BFF939C-0x000000018BFF93DC
		private protected override void CreateVirtualizationController() {} // 0x000000018BFF8090-0x000000018BFF80A8
		public override void SetViewController(CollectionViewController controller) {} // 0x000000018BFF80A8-0x000000018BFF80C0
		private void OnItemAdded(IEnumerable<int> indices) {} // 0x000000018BFF80C0-0x000000018BFF8134
		private void OnItemsRemoved(IEnumerable<int> indices) {} // 0x000000018BFF92F8-0x000000018BFF9390
		private void OnItemsSourceSizeChanged() {} // 0x000000018BFF93DC-0x000000018BFF9474
		internal override ListViewDragger CreateDragger() => default; // 0x000000018BFF9270-0x000000018BFF92F8
		internal override ICollectionDragAndDropController CreateDragAndDropController() => default; // 0x000000018BFF8278-0x000000018BFF82A4
		private protected override void PostRefresh() {} // 0x000000018BFF8B88-0x000000018BFF9270
		private protected override bool HandleItemNavigation(bool moveIn, bool altPressed) => default; // 0x000000018BFF884C-0x000000018BFF8894
		private void _OnAddClicked_b__38_0() {} // 0x000000018C00AB7C-0x000000018C00AE0C
	}

	public enum SliderDirection // TypeDefIndex: 44386
	{
		Horizontal = 0,
		Vertical = 1
	}

	public abstract class BaseSlider<TValueType> : BaseField<TValueType> // TypeDefIndex: 44388
		where TValueType : IComparable<TValueType>
	{
		// Fields
		private VisualElement _dragContainer_k__BackingField;
		private VisualElement _dragElement_k__BackingField;
		private VisualElement _dragBorderElement_k__BackingField;
		private TextField _inputTextField_k__BackingField;
		private TValueType m_LowValue;
		private TValueType m_HighValue;
		private float m_PageSize;
		private bool m_ShowInputField;
		private bool _clamped_k__BackingField;
		private ClampedDragger<TValueType> _clampedDragger_k__BackingField;
		private Rect m_DragElementStartPos;
		private SliderDirection m_Direction;
		private bool m_Inverted;
		public static readonly string ussClassName;
		public static readonly string labelUssClassName;
		public static readonly string inputUssClassName;
		public static readonly string horizontalVariantUssClassName;
		public static readonly string verticalVariantUssClassName;
		public static readonly string dragContainerUssClassName;
		public static readonly string trackerUssClassName;
		public static readonly string draggerUssClassName;
		public static readonly string draggerBorderUssClassName;
		public static readonly string textFieldClassName;
	
		// Properties
		internal VisualElement dragContainer { get; private set; }
		internal VisualElement dragElement { get; private set; }
		internal VisualElement dragBorderElement { get; private set; }
		internal TextField inputTextField { get; private set; }
		public TValueType lowValue { get; set; }
		public TValueType highValue { get; set; }
		public virtual float pageSize { get; set; }
		public virtual bool showInputField { get; set; }
		internal bool clamped { get; set; }
		internal ClampedDragger<TValueType> clampedDragger { get; private set; }
		public override TValueType value { get; set; }
		public SliderDirection direction { get; set; }
		public bool inverted { get; set; }
	
		// Nested types
		internal enum SliderKey // TypeDefIndex: 44387
		{
			None = 0,
			Lowest = 1,
			LowerPage = 2,
			Lower = 3,
			Higher = 4,
			HigherPage = 5,
			Highest = 6
		}
	
		// Constructors
		protected BaseSlider() {} // Dummy constructor
		internal BaseSlider(string label, TValueType start, TValueType end, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x0205B59F */, float pageSize = 0f /* Metadata: 0x0205B5A0 */) {}
		static BaseSlider() {}
	
		// Methods
		internal void SetHighValueWithoutNotify(TValueType newHighValue) {}
		private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) => default;
		private TValueType GetClampedValue(TValueType newValue) => default;
		public override void SetValueWithoutNotify(TValueType newValue) {}
		protected static float GetClosestPowerOfTen(float positiveNumber) => default;
		protected static float RoundToMultipleOf(float value, float roundingValue) => default;
		private void ClampValue() {}
		internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);
		internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);
		internal abstract TValueType ParseStringToValue(string stringValue);
		internal abstract void ComputeValueFromKey(SliderKey sliderKey, bool isShift);
		private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) => default;
		private void SetSliderValueFromDrag() {}
		private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) {}
		private void SetSliderValueFromClick() {}
		private void OnKeyDown(KeyDownEvent evt) {}
		internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) {}
		public void AdjustDragElement(float factor) {}
		private void UpdateDragElementPosition(GeometryChangedEvent evt) {}
		internal override void OnViewDataReady() {}
		private bool SameValues(float a, float b, float epsilon) => default;
		private void UpdateDragElementPosition() {}
		protected override void ExecuteDefaultAction(EventBase evt) {}
		private void UpdateTextFieldVisibility() {}
		private void UpdateTextFieldValue() {}
		private void OnTextFieldFocusOut(FocusOutEvent evt) {}
		private void OnTextFieldValueChange(ChangeEvent<string> evt) {}
		protected override void UpdateMixedValueContent() {}
	}

	public abstract class BaseTreeView : BaseVerticalCollectionView // TypeDefIndex: 44390
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string itemUssClassName; // 0x08
		public static readonly string itemToggleUssClassName; // 0x10
		public static readonly string itemIndentsContainerUssClassName; // 0x18
		public static readonly string itemIndentUssClassName; // 0x20
		public static readonly string itemContentContainerUssClassName; // 0x28
		private bool m_AutoExpand; // 0x4A8
		private List<int> m_ExpandedItemIds; // 0x4B0
	
		// Properties
		public new IList itemsSource { get; } // 0x000000018BFFBF98-0x000000018BFFBFD4 
		public new BaseTreeViewController viewController { get; } // 0x000000018BFFC71C-0x000000018BFFC840 
		public bool autoExpand { get; set; } // 0x0000000185FB8670-0x0000000185FB8680 0x0000000187A47834-0x0000000187A47848
		internal List<int> expandedItemIds { get; set; } // 0x000000018BFFCB98-0x000000018BFFCBA8 0x000000018BFFCA50-0x000000018BFFCB98
	
		// Nested types
		public class UxmlTraits : BaseVerticalCollectionView.UxmlTraits // TypeDefIndex: 44389
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_AutoExpand; // 0xB0
	
			// Constructors
			public UxmlTraits() {} // 0x000000018BFFCBD0-0x000000018BFFCC10
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018BFFCBA8-0x000000018BFFCBD0
		}
	
		// Constructors
		public BaseTreeView() {} // 0x000000018BFFC574-0x000000018BFFC5C4
		public BaseTreeView(int itemHeight) {} // 0x000000018BFFC18C-0x000000018BFFC4DC
		static BaseTreeView() {} // 0x000000018C00A744-0x000000018C00A814
	
		// Methods
		private protected override void CreateVirtualizationController() {} // 0x000000018BFFC534-0x000000018BFFC53C
		public override void SetViewController(CollectionViewController controller) {} // 0x000000018BFFBF38-0x000000018BFFBF98
		private new void OnItemIndexChanged(int srcIndex, int dstIndex) {} // 0x0000000185FE9CB0-0x0000000185FE9CC0
		internal override ICollectionDragAndDropController CreateDragAndDropController() => default; // 0x000000018BFFCC10-0x000000018BFFCC44
		internal override void OnViewDataReady() {} // 0x000000018BFFC5D0-0x000000018BFFC644
		private protected override bool HandleItemNavigation(bool moveIn, bool altPressed) => default; // 0x000000018BFFC5C4-0x000000018BFFC5D0
		public void SetSelectionById(int id) {} // 0x000000018BFFC644-0x000000018BFFC71C
		public void SetSelectionById(IEnumerable<int> ids) {} // 0x000000018BFFC0A0-0x000000018BFFC18C
		internal void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification) {} // 0x000000018BFFC508-0x000000018BFFC534
		private int GetItemIndex(int id, bool expand = false /* Metadata: 0x0205B5AB */) => default; // 0x000000018BFFBEE4-0x000000018BFFBF38
		public bool IsExpanded(int id) => default; // 0x000000018BFFC058-0x000000018BFFC0A0
		public void CollapseItem(int id, bool collapseAllChildren = false /* Metadata: 0x0205B5AC */) {} // 0x000000018BFFC53C-0x000000018BFFC574
		public void ExpandItem(int id, bool expandAllChildren = false /* Metadata: 0x0205B5AD */) {} // 0x000000018BFFC4DC-0x000000018BFFC508
		private void OnTreeViewPointerUp(PointerUpEvent evt) {} // 0x000000018BFFBE64-0x000000018BFFBEE4
		private bool IsExpandedByIndex(int index) => default; // 0x000000018BFFBFD4-0x000000018BFFC058
		private void CollapseItemByIndex(int index, bool collapseAll) {} // 0x000000018BFFC84C-0x000000018BFFCA50
		private void ExpandItemByIndex(int index, bool expandAll) {} // 0x000000018BFFC840-0x000000018BFFC84C
		private int _SetSelectionInternalById_b__47_0(int id) => default; // 0x000000018C00B2F0-0x000000018C00B394
	}

	public enum AlternatingRowBackground // TypeDefIndex: 44391
	{
		None = 0,
		ContentOnly = 1,
		All = 2
	}

	public enum CollectionVirtualizationMethod // TypeDefIndex: 44392
	{
		FixedHeight = 0,
		DynamicHeight = 1
	}

	[Serializable]
	internal class SerializedVirtualizationData // TypeDefIndex: 44393
	{
		// Fields
		public Vector2 scrollOffset; // 0x10
		public int firstVisibleIndex; // 0x18
		public float contentPadding; // 0x1C
		public float contentHeight; // 0x20
		public int anchoredItemIndex; // 0x24
		public float anchorOffset; // 0x28
	
		// Constructors
		public SerializedVirtualizationData() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver // TypeDefIndex: 44400
	{
		// Fields
		private static readonly ProfilerMarker k_RefreshMarker; // 0x00
		private static readonly ProfilerMarker k_RebuildMarker; // 0x08
		private Action<IEnumerable<object>> itemsChosen; // 0x3D0
		private Action<IEnumerable<object>> selectionChanged; // 0x3D8
		private Action<IEnumerable<int>> selectedIndicesChanged; // 0x3E0
		private Action<int, int> itemIndexChanged; // 0x3E8
		private Action itemsSourceChanged; // 0x3F0
		private Action selectionNotChanged; // 0x3F8
		private Func<CanStartDragArgs, bool> canStartDrag; // 0x400
		private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop; // 0x408
		private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate; // 0x410
		private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop; // 0x418
		private SelectionType m_SelectionType; // 0x420
		private static readonly List<ReusableCollectionItem> k_EmptyItems; // 0x10
		private bool m_HorizontalScrollingEnabled; // 0x424
		private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; // 0x428
		internal static readonly int s_DefaultItemHeight; // 0x18
		internal float m_FixedItemHeight; // 0x42C
		internal bool m_ItemHeightIsInline; // 0x430
		private CollectionVirtualizationMethod m_VirtualizationMethod; // 0x434
		private readonly ScrollView m_ScrollView; // 0x438
		private CollectionViewController m_ViewController; // 0x440
		private CollectionVirtualizationController m_VirtualizationController; // 0x448
		private KeyboardNavigationManipulator m_NavigationManipulator; // 0x450
		internal SerializedVirtualizationData serializedVirtualizationData; // 0x458
		private readonly List<int> m_SelectedIds; // 0x460
		private readonly Selection m_Selection; // 0x468
		private float m_LastHeight; // 0x470
		private bool m_IsRangeSelectionDirectionUp; // 0x474
		private ListViewDragger m_Dragger; // 0x478
		internal static CustomStyleProperty<int> s_ItemHeightProperty; // 0x20
		private Action<int, int> m_ItemIndexChangedCallback; // 0x480
		private Action m_ItemsSourceChangedCallback; // 0x488
		internal IVisualElementScheduledItem m_RebuildScheduled; // 0x490
		public static readonly string ussClassName; // 0x28
		public static readonly string borderUssClassName; // 0x30
		public static readonly string itemUssClassName; // 0x38
		public static readonly string dragHoverBarUssClassName; // 0x40
		public static readonly string dragHoverMarkerUssClassName; // 0x48
		public static readonly string itemDragHoverUssClassName; // 0x50
		public static readonly string itemSelectedVariantUssClassName; // 0x58
		public static readonly string itemAlternativeBackgroundUssClassName; // 0x60
		public static readonly string listScrollViewUssClassName; // 0x68
		internal static readonly string backgroundFillUssClassName; // 0x70
		private Vector3 m_TouchDownPosition; // 0x498
	
		// Properties
		public IList itemsSource { get; set; } // 0x000000018BFFD774-0x000000018BFFD7D4 0x000000018BFFE194-0x000000018BFFE284
		public override VisualElement contentContainer { get; }
		public SelectionType selectionType { get; set; } // 0x000000018C000FC4-0x000000018C0015EC 0x000000018C0015EC-0x000000018C001684
		public IEnumerable<object> selectedItems { get; } // 0x000000018BFFE074-0x000000018BFFE160 
		public int selectedIndex { get; set; } // 0x000000018BFFE16C-0x000000018BFFE194 0x000000018BFFEC78-0x000000018BFFECA4
		public IEnumerable<int> selectedIndices { get; } // 0x000000018BFFECA4-0x000000018BFFECB8 
		internal IEnumerable<int> selectedIds { get; } // 0x000000018BFFF8D4-0x000000018BFFFA3C 
		internal IEnumerable<ReusableCollectionItem> activeItems { get; } // 0x000000018BFFF788-0x000000018BFFF8D4 
		internal ScrollView scrollView { get; } // 0x000000018C0001FC-0x000000018C0002B8 
		internal ListViewDragger dragger { get; } // 0x000000018BFFFA3C-0x000000018BFFFF30 
		internal CollectionVirtualizationController virtualizationController { get; } // 0x000000018BFFF074-0x000000018BFFF12C 
		public CollectionViewController viewController { get; } // 0x000000018C000324-0x000000018C000374 
		public bool showBorder { get; set; } // 0x000000018BFFEF20-0x000000018BFFEF78
		public bool reorderable { get; set; } // 0x000000018C000138-0x000000018C0001AC 0x000000018BFFE578-0x000000018BFFE8C4
		public bool horizontalScrollingEnabled { get; set; } // 0x000000018BFFE9C4-0x000000018BFFEC78
		public AlternatingRowBackground showAlternatingRowBackgrounds { get; set; } // 0x000000018BFFD060-0x000000018BFFD47C 0x000000018BFFD47C-0x000000018BFFD5C4
		public CollectionVirtualizationMethod virtualizationMethod { get; set; } // 0x0000000185FAFEF0-0x0000000185FAFF00 0x000000018BFFEDE4-0x000000018BFFEE5C
		public float fixedItemHeight { get; set; } // 0x000000018BFFED20-0x000000018BFFEDE4 0x000000018BFFECB8-0x000000018BFFED20
		internal float lastHeight { get; } // 0x000000018BFFEE5C-0x000000018BFFEF20 
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 44394
		{
			// Fields
			private readonly UxmlIntAttributeDescription m_FixedItemHeight; // 0x78
			private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod; // 0x80
			private readonly UxmlBoolAttributeDescription m_ShowBorder; // 0x88
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType; // 0x90
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds; // 0x98
			private readonly UxmlBoolAttributeDescription m_Reorderable; // 0xA0
			private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled; // 0xA8
	
			// Constructors
			public UxmlTraits() {} // 0x000000018BFFE160-0x000000018BFFE16C
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018BFFF4EC-0x000000018BFFF588
		}
	
		private class Selection // TypeDefIndex: 44395
		{
			// Fields
			private readonly HashSet<int> m_IndexLookup; // 0x10
			private readonly HashSet<int> m_IdLookup; // 0x18
			private int m_MinIndex; // 0x20
			private int m_MaxIndex; // 0x24
			private List<int> _selectedIds_k__BackingField; // 0x28
			public readonly List<int> indices; // 0x30
			public readonly Dictionary<int, object> items; // 0x38
	
			// Properties
			public List<int> selectedIds { get; set; } // 0x000000018BFFF698-0x000000018BFFF788 0x000000018BFFF610-0x000000018BFFF698
			public int indexCount { get => default; } // 0x000000018BFFF588-0x000000018BFFF610 
			public int idCount { get => default; } // 0x000000018C0016E8-0x000000018C00170C 
			public int minIndex { get => default; } // 0x000000018C0019DC-0x000000018C001A0C 
			public int maxIndex { get => default; } // 0x00000001813AE580-0x00000001813AE590 
			public int capacity { get => default; set {} } // 0x0000000185FE9CF0-0x0000000185FE9D00 0x000000018C001A70-0x000000018C001AD8
	
			// Constructors
			public Selection() {} // 0x000000018C001AF0-0x000000018C001B64
	
			// Methods
			public int FirstIndex() => default; // 0x000000018C001804-0x000000018C001874
			public bool ContainsIndex(int index) => default; // 0x000000018C00179C-0x000000018C0017E4
			public bool ContainsId(int id) => default; // 0x000000018BFFF4E4-0x000000018BFFF4EC
			public void AddId(int id) {} // 0x000000018C0017E4-0x000000018C001804
			public void AddIndex(int index, object obj) {} // 0x000000018C00177C-0x000000018C00179C
			public bool TryRemove(int index) => default; // 0x000000018C001684-0x000000018C0016E8
			public void RemoveId(int id) {} // 0x0000000185FB70D0-0x0000000185FB70E0
			public void ClearItems() {} // 0x0000000185FB8820-0x0000000185FB8830
			public void ClearIds() {} // 0x000000018C001874-0x000000018C00187C
			public void ClearIndices() {} // 0x0000000185FB7110-0x0000000185FB7120
			public void Clear() {} // 0x000000018C0001AC-0x000000018C0001FC
		}
	
		private sealed class _get_selectedItems_d__72 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 44396
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public BaseVerticalCollectionView __4__this; // 0x28
			private List<int> __s__1; // 0x30
			private int _index_5__2; // 0x48
			private object _item_5__3; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018C001AD8-0x000000018C001AF0 
			object IEnumerator.Current { get => default; } // 0x000000018C001B64-0x000000018C001B9C 
	
			// Constructors
			public _get_selectedItems_d__72() {} // Dummy constructor
			public _get_selectedItems_d__72(int __1__state) {} // 0x000000018C00170C-0x000000018C00177C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018C001A0C-0x000000018C001A70
			private bool MoveNext() => default; // 0x000000018C001978-0x000000018C0019DC
			private void __m__Finally1() {} // 0x0000000185FE9D00-0x0000000185FE9D10
			void IEnumerator.Reset() {} // 0x0000000185FE9D10-0x0000000185FE9D20
			IEnumerator<object> IEnumerable<object>.GetEnumerator() => default; // 0x0000000185FE9CD0-0x0000000185FE9CE0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C00187C-0x000000018C001978
		}
	
		private sealed class __c__DisplayClass163_0 // TypeDefIndex: 44397
		{
			// Fields
			public int id; // 0x10
	
			// Constructors
			public __c__DisplayClass163_0() {} // 0x0000000185FE9CE0-0x0000000185FE9CF0
	
			// Methods
			internal bool _GetRootElementForId_b__0(ReusableCollectionItem t) => default; // 0x000000018BFFD7D4-0x000000018BFFD810
		}
	
		private struct __c__DisplayClass173_0 // TypeDefIndex: 44398
		{
			// Fields
			public bool selectedIndicesChanged; // 0x00
			public BaseVerticalCollectionView __4__this; // 0x08
			public int previousSelectionCount; // 0x10
		}
	
		private struct __c__DisplayClass184_0 // TypeDefIndex: 44399
		{
			// Fields
			public BaseVerticalCollectionView __4__this; // 0x00
			public bool shiftKey; // 0x08
		}
	
		// Constructors
		public BaseVerticalCollectionView() {} // 0x000000018C0000EC-0x000000018C000138
		public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1f /* Metadata: 0x0205B5B7 */) {} // 0x000000018BFFFF30-0x000000018C0000EC
		static BaseVerticalCollectionView() {} // 0x000000018C00A1B8-0x000000018C00A254
	
		// Methods
		internal bool HasCanStartDrag() => default; // 0x000000018BFFE03C-0x000000018BFFE074
		internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<int> ids) => default;
		internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<int> ids, StartDragArgs args) => default; // 0x000000018BFFDFD0-0x000000018BFFE03C
		internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) => default;
		internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) => default; // 0x000000018C0008C4-0x000000018C0009B8
		internal float ResolveItemHeight(float height = -1f /* Metadata: 0x0205B5B3 */) => default; // 0x000000018C0002B8-0x000000018C000324
		private protected virtual void CreateVirtualizationController() {} // 0x000000018BFFF12C-0x000000018BFFF27C
		internal CollectionVirtualizationController GetOrCreateVirtualizationController() => default; // 0x000000018BFFF27C-0x000000018BFFF4E4
		internal void CreateVirtualizationController<T>()
			where T : ReusableCollectionItem, new() {} // 0x000000018BFFD928-0x000000018BFFDD4C
		internal CollectionViewController GetOrCreateViewController() => default; // 0x000000018BFFD810-0x000000018BFFD928
		protected abstract CollectionViewController CreateViewController(); // 0x000000018BFFF4E4-0x000000018BFFF4EC
		public virtual void SetViewController(CollectionViewController controller) {} // 0x000000018C000374-0x000000018C000608
		internal virtual ListViewDragger CreateDragger() => default; // 0x000000018BFFCE70-0x000000018BFFCEE0
		internal void InitializeDragAndDropController(bool enableReordering) {} // 0x000000018BFFCEE0-0x000000018BFFD060
		internal abstract ICollectionDragAndDropController CreateDragAndDropController(); // 0x000000018BFFCC44-0x000000018BFFCE70
		public VisualElement GetRootElementForId(int id) => default; // 0x000000018C000840-0x000000018C0008C4
		internal virtual bool HasValidDataAndBindings() => default; // 0x000000018C000834-0x000000018C000840
		private void OnItemIndexChanged(int srcIndex, int dstIndex) {} // 0x000000018C000828-0x000000018C000834
		private void OnItemsSourceChanged() {} // 0x000000018C000608-0x000000018C000828
		public void RefreshItems() {} // 0x000000018BFFE284-0x000000018BFFE500
		public void Rebuild() {} // 0x000000018BFFE500-0x000000018BFFE578
		internal void ScheduleRebuild() {} // 0x000000018BFFD720-0x000000018BFFD774
		private void RefreshSelection() {} // 0x000000018BFFD5C4-0x000000018BFFD720
		private protected virtual void PostRefresh() {} // 0x000000018BFFF034-0x000000018BFFF074
		public void ScrollToItem(int index) {} // 0x000000018BFFDD4C-0x000000018BFFDFD0
		public void ScrollToItemById(int id) {} // 0x000000018BFFEF78-0x000000018BFFF034
		private void OnScroll(Vector2 offset) {} // 0x000000018BFFE8C4-0x000000018BFFE9C4
		private void Resize(Vector2 size) {} // 0x0000000185492010-0x0000000185492020
		private void OnAttachToPanel(AttachToPanelEvent evt) {} // 0x000000018C000AC4-0x000000018C000B00
		private void OnDetachFromPanel(DetachFromPanelEvent evt) {} // 0x000000018C000B00-0x000000018C000FC4
		private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) => default; // 0x000000018C000AB0-0x000000018C000AC4
		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) {} // 0x000000018C000A68-0x000000018C000AB0
		private protected virtual bool HandleItemNavigation(bool moveIn, bool altKey) => default; // 0x000000018C0009B8-0x000000018C000A68
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x000000018C00AE0C-0x000000018C00B1F0
		private void OnPointerDown(PointerDownEvent evt) {} // 0x000000018C00A814-0x000000018C00AA44
		private void OnPointerCancel(PointerCancelEvent evt) {} // 0x00000001813B8590-0x00000001813B85A0
		private void OnPointerUp(PointerUpEvent evt) {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		private void ProcessPointerDown(IPointerEvent evt) {} // 0x000000018C009920-0x000000018C009960
		private void ProcessPointerUp(IPointerEvent evt) {} // 0x000000018C0098E0-0x000000018C009920
		private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey) {} // 0x000000018C009988-0x000000018C0099B0
		internal void DoRangeSelection(int rangeSelectionFinalIndex) {} // 0x000000018C009960-0x000000018C009988
		private void ProcessSingleClick(int clickedIndex) {} // 0x000000018C009898-0x000000018C0098E0
		internal void SelectAll() {} // 0x000000018C0099B0-0x000000018C009A40
		public void AddToSelection(int index) {} // 0x000000018C00957C-0x000000018C0095E4
		internal void AddToSelection(IList<int> indexes) {} // 0x000000018C009528-0x000000018C00957C
		private void AddToSelectionWithoutValidation(int index) {} // 0x000000018C0094D4-0x000000018C009528
		public void RemoveFromSelection(int index) {} // 0x000000018C00925C-0x000000018C0092D4
		private void RemoveFromSelectionWithoutValidation(int index) {} // 0x000000018C0092D4-0x000000018C009390
		public void SetSelection(int index) {} // 0x000000018C00965C-0x000000018C00974C
		public void SetSelection(IEnumerable<int> indices) {} // 0x000000018C0095E4-0x000000018C00965C
		public void SetSelectionWithoutNotify(IEnumerable<int> indices) {} // 0x000000018C009460-0x000000018C0094A8
		internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification) {} // 0x000000018C009390-0x000000018C0093F4
		private bool MatchesExistingSelection(IEnumerable<int> indices) => default; // 0x000000018C0093F4-0x000000018C009460
		private void NotifyOfSelectionChange() {} // 0x000000018C0094A8-0x000000018C0094D4
		public void ClearSelection() {} // 0x000000018C00974C-0x000000018C009898
		private void ClearSelectionWithoutValidation() {} // 0x0000000189D638DC-0x0000000189D63910
		internal override void OnViewDataReady() {} // 0x000000018C00A2A8-0x000000018C00A320
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x000000018C009E2C-0x000000018C00A1B8
		private void OnSizeChanged(GeometryChangedEvent evt) {} // 0x000000018C00A320-0x000000018C00A35C
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e) {} // 0x0000000181377E40-0x0000000181377E50
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018C00A25C-0x000000018C00A2A8
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000181377E40-0x0000000181377E50
		private void _.ctor_b__160_0(float v) {} // 0x000000018C00A254-0x000000018C00A25C
		private void _RefreshSelection_g__NotifyIfChanged_173_0(ref __c__DisplayClass173_0 param_0005eafe) {} // 0x0000000185492010-0x0000000185492020
		private void _Apply_g__HandleSelectionAndScroll_184_0(int index, ref __c__DisplayClass184_0 param_0005eb00) {} // 0x000000018C009DA8-0x000000018C009DC8
	}

	public interface IBindable // TypeDefIndex: 44401
	{
		// Properties
		IBinding binding { get; }
		string bindingPath { get; set; }
	}

	public interface IBinding // TypeDefIndex: 44402
	{
		// Methods
		void PreUpdate();
		void Update();
		void Release();
	}

	public class Box : VisualElement // TypeDefIndex: 44404
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Box> // TypeDefIndex: 44403
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C001BF8-0x000000018C001C6C
		}
	
		// Constructors
		public Box() {} // 0x000000018C001B9C-0x000000018C001BF8
		static Box() {} // 0x000000018C00A3D4-0x000000018C00A410
	}

	public class Button : UnityEngine.UIElements.TextElement // TypeDefIndex: 44407
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private Clickable m_Clickable; // 0x488
		private static readonly string NonEmptyString; // 0x08
	
		// Properties
		public Clickable clickable { get => default; set {} } // 0x000000018C0022F4-0x000000018C002300 0x000000018C00215C-0x000000018C0022F4
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Button, UxmlTraits> // TypeDefIndex: 44405
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FE9D20-0x0000000185FE9D30
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 44406
		{
			// Constructors
			public UxmlTraits() {} // 0x000000018C002300-0x000000018C002370
		}
	
		// Constructors
		public Button() {} // 0x000000018C00208C-0x000000018C0020C4
		public Button(Action clickEvent) {} // 0x000000018C001FF4-0x000000018C00208C
		static Button() {} // 0x000000018C00B4D8-0x000000018C00B520
	
		// Methods
		private void OnNavigationSubmit(NavigationSubmitEvent evt) {} // 0x000000018C001F48-0x000000018C001FF4
		private void OnKeyDown(KeyDownEvent evt) {} // 0x000000018C0020C4-0x000000018C00215C
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x000000018C00A410-0x000000018C00A44C
	}

	internal class ButtonStripField : BaseField<int> // TypeDefIndex: 44410
	{
		// Fields
		private List<UnityEngine.UIElements.Button> m_Buttons; // 0x418
	
		// Properties
		private List<UnityEngine.UIElements.Button> buttons { get => default; } // 0x000000018C001D34-0x000000018C001DB8 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits> // TypeDefIndex: 44408
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C001E68-0x000000018C001F48
		}
	
		public class UxmlTraits : BaseField<int> // TypeDefIndex: 44409
		{
			// Constructors
			public UxmlTraits() {} // 0x000000018C001DB8-0x000000018C001E68
		}
	
		// Constructors
		public ButtonStripField() {} // 0x000000018C001C6C-0x000000018C001D34
	
		// Methods
		public override void SetValueWithoutNotify(int newValue) {} // 0x000000018C00A398-0x000000018C00A3D4
		private void RefreshButtonsState() {} // 0x000000018C00B49C-0x000000018C00B4D8
	}

	public class DropdownField : BaseField<string> // TypeDefIndex: 44415
	{
		// Fields
		internal List<string> m_Choices; // 0x418
		private UnityEngine.UIElements.TextElement m_TextElement; // 0x420
		private VisualElement m_ArrowElement; // 0x428
		internal Func<string, string> m_FormatSelectedValueCallback; // 0x430
		internal Func<string, string> m_FormatListItemCallback; // 0x438
		internal Func<IGenericMenu> createMenuCallback; // 0x440
		private int m_Index; // 0x448
		internal static readonly string ussClassNameBasePopupField; // 0x00
		internal static readonly string textUssClassNameBasePopupField; // 0x08
		internal static readonly string arrowUssClassNameBasePopupField; // 0x10
		internal static readonly string labelUssClassNameBasePopupField; // 0x18
		internal static readonly string inputUssClassNameBasePopupField; // 0x20
		internal static readonly string ussClassNamePopupField; // 0x28
		internal static readonly string labelUssClassNamePopupField; // 0x30
		internal static readonly string inputUssClassNamePopupField; // 0x38
	
		// Properties
		protected UnityEngine.UIElements.TextElement textElement { get => default; } // 0x000000018C002D18-0x000000018C002D2C 
		public int index { set {} } // 0x000000018C00393C-0x000000018C0039B8
		public virtual List<string> choices { set {} } // 0x000000018C003278-0x000000018C0034F8
		public override string value { get => default; set {} } // 0x000000018C00A35C-0x000000018C00A398 0x000000018C00AA44-0x000000018C00AB7C
	
		// Nested types
		public class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits> // TypeDefIndex: 44411
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FE9D30-0x0000000185FE9D40
		}
	
		public class UxmlTraits : BaseField<string> // TypeDefIndex: 44412
		{
			// Fields
			private UxmlIntAttributeDescription m_Index; // 0x80
			private UxmlStringAttributeDescription m_Choices; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C002E7C-0x000000018C002F24
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C002F24-0x000000018C002FAC
		}
	
		private class PopupTextElement : UnityEngine.UIElements.TextElement // TypeDefIndex: 44413
		{
			// Constructors
			public PopupTextElement() {} // 0x000000018C00380C-0x000000018C003818
	
			// Methods
			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x000000018C0038B4-0x000000018C00393C
		}
	
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 44414
		{
			// Fields
			public string item; // 0x10
			public DropdownField __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass38_0() {} // 0x000000018C0034F8-0x000000018C00380C
	
			// Methods
			internal void _AddMenuItems_b__0() {} // 0x000000018C002904-0x000000018C002D18
		}
	
		// Constructors
		public DropdownField() {} // 0x000000018C002FAC-0x000000018C003068
		public DropdownField(string label) {} // 0x000000018C002D2C-0x000000018C002E7C
		static DropdownField() {} // 0x000000018C009E04-0x000000018C009E2C
	
		// Methods
		internal string GetValueToDisplay() => default; // 0x000000018C003854-0x000000018C0038B4
		internal string GetListItemToDisplay(string value) => default; // 0x000000018C003818-0x000000018C003854
		internal void AddMenuItems(IGenericMenu menu) {} // 0x000000018C003068-0x000000018C0031B8
		private void ChangeValueFromMenu(string menuItem) {} // 0x000000018C0031B8-0x000000018C003278
		public override void SetValueWithoutNotify(string newValue) {} // 0x000000018C00B394-0x000000018C00B49C
		protected override void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x000000018C0072D4-0x000000018C00736C
		private void ShowMenu() {} // 0x000000018C00736C-0x000000018C0073B8
		protected override void UpdateMixedValueContent() {} // 0x0000000185492010-0x0000000185492020
	}

	public class Foldout : BindableElement, INotifyValueChanged<bool> // TypeDefIndex: 44418
	{
		// Fields
		private Toggle m_Toggle; // 0x3D0
		private VisualElement m_Container; // 0x3D8
		private bool m_Value; // 0x3E0
		public static readonly string ussClassName; // 0x00
		public static readonly string toggleUssClassName; // 0x08
		public static readonly string contentUssClassName; // 0x10
		public static readonly string inputUssClassName; // 0x18
		public static readonly string checkmarkUssClassName; // 0x20
		public static readonly string textUssClassName; // 0x28
		internal static readonly string ussFoldoutDepthClassName; // 0x30
		internal static readonly int ussFoldoutMaxDepth; // 0x38
	
		// Properties
		internal Toggle toggle { get => default; } // 0x0000000185FE9D40-0x0000000185FE9D50 
		public override VisualElement contentContainer { get => default; } // 0x000000018C004320-0x000000018C00442C 
		public string text { set {} } // 0x000000018C003B70-0x000000018C003C0C
		public bool value { get => default; set {} } // 0x000000018C003B38-0x000000018C003B70 0x000000018C003ECC-0x000000018C004224
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Foldout, UxmlTraits> // TypeDefIndex: 44416
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FB7090-0x0000000185FB70A0
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 44417
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
			private UxmlBoolAttributeDescription m_Value; // 0x80
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C004224-0x000000018C004320
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000185FB70A0-0x0000000185FB70B0
		}
	
		// Constructors
		public Foldout() {} // 0x000000018C003C0C-0x000000018C003C5C
		static Foldout() {} // 0x000000018C00A640-0x000000018C00A744
	
		// Methods
		public void SetValueWithoutNotify(bool newValue) {} // 0x000000018C0039B8-0x000000018C003B38
		internal override void OnViewDataReady() {} // 0x000000018C003C5C-0x000000018C003ECC
		private void OnAttachToPanel(AttachToPanelEvent evt) {} // 0x000000018C00A44C-0x000000018C00A488
		private void _.ctor_b__25_0(ChangeEvent<bool> evt) {} // 0x000000018C00B1F0-0x000000018C00B2F0
	}

	internal interface IGenericMenu // TypeDefIndex: 44419
	{
		// Methods
		void AddItem(string itemName, bool isChecked, Action action);
		void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false /* Metadata: 0x0205B5BB */);
	}

	public class GenericDropdownMenu : IGenericMenu // TypeDefIndex: 44422
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string itemUssClassName; // 0x08
		public static readonly string labelUssClassName; // 0x10
		public static readonly string containerInnerUssClassName; // 0x18
		public static readonly string containerOuterUssClassName; // 0x20
		public static readonly string checkmarkUssClassName; // 0x28
		public static readonly string separatorUssClassName; // 0x30
		private List<MenuItem> m_Items; // 0x10
		private VisualElement m_MenuContainer; // 0x18
		private VisualElement m_OuterContainer; // 0x20
		private ScrollView m_ScrollView; // 0x28
		private VisualElement m_PanelRootVisualContainer; // 0x30
		private VisualElement m_TargetElement; // 0x38
		private Rect m_DesiredRect; // 0x40
		private KeyboardNavigationManipulator m_NavigationManipulator; // 0x50
		private Vector2 m_MousePosition; // 0x58
	
		// Properties
		public VisualElement contentContainer { get => default; } // 0x000000018C0064C8-0x000000018C0067F4 
	
		// Nested types
		internal class MenuItem // TypeDefIndex: 44420
		{
			// Fields
			public string name; // 0x10
			public VisualElement element; // 0x18
			public Action action; // 0x20
			public Action<object> actionUserData; // 0x28
	
			// Constructors
			public MenuItem() {} // 0x000000018C0067F4-0x000000018C006818
		}
	
		private struct __c__DisplayClass27_0 // TypeDefIndex: 44421
		{
			// Fields
			public GenericDropdownMenu __4__this; // 0x00
			public int selectedIndex; // 0x08
		}
	
		// Constructors
		public GenericDropdownMenu() {} // 0x000000018C0054EC-0x000000018C0058A4
		static GenericDropdownMenu() {} // 0x000000018C00602C-0x000000018C0060CC
	
		// Methods
		private void OnAttachToPanel(AttachToPanelEvent evt) {} // 0x000000018C0058AC-0x000000018C005BD4
		private void OnDetachFromPanel(DetachFromPanelEvent evt) {} // 0x000000018C00540C-0x000000018C0054EC
		private void Hide() {} // 0x000000018C0049AC-0x000000018C0049E8
		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) {} // 0x000000018C004804-0x000000018C0049AC
		private bool Apply(KeyboardNavigationOperation op) => default; // 0x000000018C005CAC-0x000000018C005DD4
		private void OnPointerDown(PointerDownEvent evt) {} // 0x000000018C005DD4-0x000000018C005EFC
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x000000018C005EFC-0x000000018C00602C
		private void OnPointerUp(PointerUpEvent evt) {} // 0x000000018C005BD4-0x000000018C005CA4
		private void OnFocusOut(FocusOutEvent evt) {} // 0x000000018C005CA4-0x000000018C005CAC
		private void OnParentResized(GeometryChangedEvent evt) {} // 0x000000018C00615C-0x000000018C00626C
		private void UpdateSelection(VisualElement target) {} // 0x000000018C0049E8-0x000000018C004B04
		private void ChangeSelectedIndex(int newIndex, int previousIndex) {} // 0x000000018C005384-0x000000018C00540C
		private int GetSelectedIndex() => default; // 0x000000018C00442C-0x000000018C004464
		public void AddItem(string itemName, bool isChecked, Action action) {} // 0x000000018C004758-0x000000018C004804
		public void AddSeparator(string path) {} // 0x000000018C004464-0x000000018C004758
		private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data = null) => default; // 0x000000018C004B04-0x000000018C004FB0
		public void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false /* Metadata: 0x0205B5BC */) {} // 0x000000018C005CA4-0x000000018C005CAC
		private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) {} // 0x000000018C0058A4-0x000000018C0058AC
		private void OnContainerGeometryChanged(GeometryChangedEvent evt) {} // 0x000000018C004FB0-0x000000018C005384
		private void EnsureVisibilityInParent() {} // 0x000000018C00626C-0x000000018C0064C8
		private void _Apply_g__UpdateSelectionDown_27_0(int newIndex, ref __c__DisplayClass27_0 param_0005eb52) {} // 0x000000018C0060CC-0x000000018C00615C
		private void _Apply_g__UpdateSelectionUp_27_1(int newIndex, ref __c__DisplayClass27_0 param_0005eb54) {} // 0x0000000185492010-0x0000000185492020
	}

	public class GroupBox : BindableElement, IGroupBox // TypeDefIndex: 44425
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		private UnityEngine.UIElements.Label m_TitleLabel; // 0x3D0
	
		// Properties
		public string text { set {} } // 0x000000018C00BD84-0x000000018C00BE34
	
		// Nested types
		public class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits> // TypeDefIndex: 44423
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C00BEB8-0x000000018C00BFEC
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 44424
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C00BE34-0x000000018C00BEAC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C00BEAC-0x000000018C00BEB8
		}
	
		// Constructors
		public GroupBox() {} // 0x000000018C01974C-0x000000018C019788
		public GroupBox(string text) {} // 0x000000018C01A754-0x000000018C01A830
		static GroupBox() {} // 0x000000018C01B650-0x000000018C01B6E0
	}

	public enum HelpBoxMessageType // TypeDefIndex: 44426
	{
		None = 0,
		Info = 1,
		Warning = 2,
		Error = 3
	}

	public class HelpBox : VisualElement // TypeDefIndex: 44429
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string iconUssClassName; // 0x10
		public static readonly string iconInfoUssClassName; // 0x18
		public static readonly string iconwarningUssClassName; // 0x20
		public static readonly string iconErrorUssClassName; // 0x28
		private HelpBoxMessageType m_HelpBoxMessageType; // 0x3C0
		private VisualElement m_Icon; // 0x3C8
		private string m_IconClass; // 0x3D0
		private UnityEngine.UIElements.Label m_Label; // 0x3D8
	
		// Properties
		public string text { set {} } // 0x000000018C00C3AC-0x000000018C00C534
		public HelpBoxMessageType messageType { set {} } // 0x000000018C00BFEC-0x000000018C00C094
	
		// Nested types
		public class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits> // TypeDefIndex: 44427
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C00C554-0x000000018C00C578
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 44428
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x70
			private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType; // 0x78
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C00C360-0x000000018C00C3AC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C00C534-0x000000018C00C554
		}
	
		// Constructors
		public HelpBox() {} // 0x000000018C00C094-0x000000018C00C158
		public HelpBox(string text, HelpBoxMessageType messageType) {} // 0x000000018C00C158-0x000000018C00C360
		static HelpBox() {} // 0x000000018C01B9B8-0x000000018C01BAC4
	
		// Methods
		private string GetIconClass(HelpBoxMessageType messageType) => default; // 0x000000018C0197C4-0x000000018C019800
		private void UpdateIcon(HelpBoxMessageType messageType) {} // 0x000000018C01A654-0x000000018C01A754
	}

	public class Image : VisualElement // TypeDefIndex: 44432
	{
		// Fields
		private UnityEngine.ScaleMode m_ScaleMode; // 0x3C0
		private Texture m_Image; // 0x3C8
		private Sprite m_Sprite; // 0x3D0
		private VectorImage m_VectorImage; // 0x3D8
		private Rect m_UV; // 0x3E0
		private UnityEngine.Color m_TintColor; // 0x3F0
		private bool m_ImageIsInline; // 0x400
		private bool m_ScaleModeIsInline; // 0x401
		private bool m_TintColorIsInline; // 0x402
		public static readonly string ussClassName; // 0x00
		private static CustomStyleProperty<Texture2D> s_ImageProperty; // 0x08
		private static CustomStyleProperty<Sprite> s_SpriteProperty; // 0x10
		private static CustomStyleProperty<VectorImage> s_VectorImageProperty; // 0x18
		private static CustomStyleProperty<string> s_ScaleModeProperty; // 0x20
		private static CustomStyleProperty<UnityEngine.Color> s_TintColorProperty; // 0x28
	
		// Properties
		public Texture image { get => default; set {} } // 0x0000000185FE9C60-0x0000000185FE9C70 0x000000018C00D8E0-0x000000018C00DAAC
		public Sprite sprite { get => default; set {} } // 0x0000000185FE9C20-0x0000000185FE9C30 0x000000018C00DAAC-0x000000018C00DCAC
		public VectorImage vectorImage { get => default; set {} } // 0x000000018C00D6B4-0x000000018C00D6E0 0x0000000185FE9DB0-0x0000000185FE9DC0
		public Rect sourceRect { get => default; } // 0x0000000185FE9D90-0x0000000185FE9DA0 
		public Rect uv { get => default; } // 0x0000000185FE9DA0-0x0000000185FE9DB0 
		public UnityEngine.ScaleMode scaleMode { get => default; } // 0x000000018C00D50C-0x000000018C00D6B4 
		public UnityEngine.Color tintColor { get => default; } // 0x000000018C00C938-0x000000018C00C9D8 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Image, UxmlTraits> // TypeDefIndex: 44430
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FE9D80-0x0000000185FE9D90
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 44431
		{
			// Constructors
			public UxmlTraits() {} // 0x000000018C00D6E0-0x000000018C00D8E0
		}
	
		// Constructors
		public Image() {} // 0x000000018C00C9D8-0x000000018C00CAD8
		static Image() {} // 0x000000018C01BAC4-0x000000018C01BC24
	
		// Methods
		private Vector2 GetTextureDisplaySize(Texture texture) => default; // 0x000000018C00C578-0x000000018C00C7A8
		private Vector2 GetTextureDisplaySize(Sprite sprite) => default; // 0x000000018C00CED0-0x000000018C00D2B8
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x000000018C00CAD8-0x000000018C00CED0
		private void OnGenerateVisualContent(MeshGenerationContext mgc) {} // 0x000000018C00D2B8-0x000000018C00D2DC
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e) {} // 0x000000018C00C7A8-0x000000018C00C938
		private void SetScaleMode(UnityEngine.ScaleMode mode) {} // 0x000000018C00D2DC-0x000000018C00D50C
		private Rect GetSourceRect() => default; // 0x000000018C0195A8-0x000000018C0195E4
	}

	public interface INotifyValueChanged<T> // TypeDefIndex: 44433
	{
		// Properties
		T value { get; set; }
	
		// Methods
		void SetValueWithoutNotify(T newValue);
	}

	public static class INotifyValueChangedExtensions // TypeDefIndex: 44434
	{
		// Methods
		public static bool RegisterValueChangedCallback<T>(INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback) => default;
		public static bool UnregisterValueChangedCallback<T>(INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback) => default;
	}

	internal class KeyboardTextEditorEventHandler : TextEditorEventHandler // TypeDefIndex: 44435
	{
		// Fields
		internal bool m_Changed; // 0x20
		private bool m_Dragged; // 0x21
		private bool m_DragToPosition; // 0x22
		private bool m_SelectAllOnMouseUp; // 0x23
		private string m_PreDrawCursorText; // 0x28
		private bool m_IsClicking; // 0x30
		private Vector2 m_ClickStartPosition; // 0x34
		private readonly UnityEngine.Event m_ImguiEvent; // 0x40
	
		// Properties
		private bool isClicking { get => default; set {} } // 0x00000001814294C0-0x00000001814294D0 0x000000018C00F458-0x000000018C00F484
	
		// Constructors
		public KeyboardTextEditorEventHandler() {} // Dummy constructor
		public KeyboardTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField) {} // 0x000000018C00F3C8-0x000000018C00F458
	
		// Methods
		public override void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x000000018C00DCAC-0x000000018C00E088
		private void OnFocus(FocusEvent _) {} // 0x000000018C00E3E0-0x000000018C00E4BC
		private void OnBlur(BlurEvent _) {} // 0x000000018C00E0CC-0x000000018C00E0D8
		private void OnMouseDown(MouseDownEvent evt) {} // 0x000000018C00E884-0x000000018C00EC08
		private void OnMouseUp(MouseUpEvent evt) {} // 0x000000018C00ED14-0x000000018C00EDFC
		private void OnMouseMove(MouseMoveEvent evt) {} // 0x000000018C00EC08-0x000000018C00ED14
		private void ProcessDragMove(MouseMoveEvent evt) {} // 0x000000018C00F268-0x000000018C00F3C8
		private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) => default; // 0x000000018C00E088-0x000000018C00E0CC
		private void OnKeyDown(KeyDownEvent evt) {} // 0x000000018C00E4BC-0x000000018C00E884
		private void OnValidateCommandEvent(ValidateCommandEvent evt) {} // 0x000000018C00EDFC-0x000000018C00EFB8
		private void OnExecuteCommandEvent(ExecuteCommandEvent evt) {} // 0x000000018C00E0D8-0x000000018C00E3E0
		public void PreDrawCursor(string newText) {} // 0x000000018C00EFE0-0x000000018C00F268
		public void PostDrawCursor() {} // 0x000000018C00EFB8-0x000000018C00EFE0
	}

	public class Label : UnityEngine.UIElements.TextElement // TypeDefIndex: 44438
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Label, UxmlTraits> // TypeDefIndex: 44436
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C00F570-0x000000018C00F5B8
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 44437
		{
			// Constructors
			public UxmlTraits() {} // 0x000000018C00F4E0-0x000000018C00F570
		}
	
		// Constructors
		public Label() {} // 0x000000018C00F484-0x000000018C00F4E0
		public Label(string text) {} // 0x000000018C019788-0x000000018C0197C4
		static Label() {} // 0x000000018C01AEB0-0x000000018C01AEB8
	}

	public class ListView : BaseListView // TypeDefIndex: 44441
	{
		// Fields
		private Func<VisualElement> m_MakeItem; // 0x538
		private Action<VisualElement, int> m_BindItem; // 0x540
		private Action<VisualElement, int> _unbindItem_k__BackingField; // 0x548
		private Action<VisualElement> _destroyItem_k__BackingField; // 0x550
	
		// Properties
		public Func<VisualElement> makeItem { get => default; } // 0x0000000185FCD780-0x0000000185FCD790 
		public Action<VisualElement, int> bindItem { get => default; } // 0x0000000185FCD790-0x0000000185FCD7A0 
		public Action<VisualElement, int> unbindItem { get; } // 0x000000018C00F5F4-0x000000018C00F630 
		public Action<VisualElement> destroyItem { get; } // 0x000000018C00F5B8-0x000000018C00F5F4 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ListView, UxmlTraits> // TypeDefIndex: 44439
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FCD750-0x0000000185FCD760
		}
	
		public class UxmlTraits : BaseListView.UxmlTraits // TypeDefIndex: 44440
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000185FCD770-0x0000000185FCD780
		}
	
		// Constructors
		public ListView() {} // 0x000000018C01AEB8-0x000000018C01AEC0
	
		// Methods
		internal override bool HasValidDataAndBindings() => default; // 0x000000018C00F630-0x000000018C00F690
		protected override CollectionViewController CreateViewController() => default; // 0x000000018C019800-0x000000018C01983C
	}

	public class MinMaxSlider : BaseField<Vector2> // TypeDefIndex: 44445
	{
		// Fields
		private VisualElement _dragElement_k__BackingField; // 0x418
		private VisualElement _dragMinThumb_k__BackingField; // 0x420
		private VisualElement _dragMaxThumb_k__BackingField; // 0x428
		private ClampedDragger<float> _clampedDragger_k__BackingField; // 0x430
		private Vector2 m_DragElementStartPos; // 0x438
		private Vector2 m_ValueStartPos; // 0x440
		private Rect m_DragMinThumbRect; // 0x448
		private Rect m_DragMaxThumbRect; // 0x458
		private DragState m_DragState; // 0x468
		private float m_MinLimit; // 0x46C
		private float m_MaxLimit; // 0x470
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
		public static readonly string trackerUssClassName; // 0x18
		public static readonly string draggerUssClassName; // 0x20
		public static readonly string minThumbUssClassName; // 0x28
		public static readonly string maxThumbUssClassName; // 0x30
	
		// Properties
		internal VisualElement dragElement { get; private set; } // 0x0000000187A47988-0x0000000187A4799C 0x0000000185FB7100-0x0000000185FB7110
		internal VisualElement dragMinThumb { get; private set; } // 0x0000000187A47848-0x0000000187A4785C 0x0000000185FB70E0-0x0000000185FB70F0
		internal VisualElement dragMaxThumb { get; private set; } // 0x0000000187A477F8-0x0000000187A4780C 0x000000018C010FC4-0x000000018C010FE8
		internal ClampedDragger<float> clampedDragger { get; private set; } // 0x000000018C011298-0x000000018C011308 0x000000018C010FA0-0x000000018C010FC4
		public float minValue { get => default; set {} } // 0x000000018C011228-0x000000018C011298 0x000000018C010FE8-0x000000018C01102C
		public float maxValue { get => default; set {} } // 0x000000018C011308-0x000000018C011364 0x000000018C00FE44-0x000000018C00FEAC
		public override Vector2 value { get => default; set {} } // 0x0000000185FE9DF0-0x0000000185FE9E00 0x000000018C01112C-0x000000018C011228
		public float lowLimit { get => default; set {} } // 0x000000018C01102C-0x000000018C01112C 0x000000018C010970-0x000000018C0109B0
		public float highLimit { get => default; set {} } // 0x000000018C0109B0-0x000000018C010FA0 0x000000018C00F690-0x000000018C00F710
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits> // TypeDefIndex: 44442
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FB85B0-0x0000000185FB85C0
		}
	
		public class UxmlTraits : BaseField<Vector2> // TypeDefIndex: 44443
		{
			// Fields
			private UxmlFloatAttributeDescription m_MinValue; // 0x80
			private UxmlFloatAttributeDescription m_MaxValue; // 0x88
			private UxmlFloatAttributeDescription m_LowLimit; // 0x90
			private UxmlFloatAttributeDescription m_HighLimit; // 0x98
	
			// Constructors
			public UxmlTraits() {} // 0x0000000185FB8740-0x0000000185FB8750
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000187A476B8-0x0000000187A476CC
		}
	
		private enum DragState // TypeDefIndex: 44444
		{
			NoThumb = 0,
			MinThumb = 1,
			MiddleThumb = 2,
			MaxThumb = 3
		}
	
		// Constructors
		public MinMaxSlider() {} // 0x000000018C010690-0x000000018C010714
		public MinMaxSlider(string label, float minValue = 0f /* Metadata: 0x0205B5C1 */, float maxValue = 10f /* Metadata: 0x0205B5C5 */, float minLimit = -3.4028235E+38f /* Metadata: 0x0205B5C9 */, float maxLimit = 3.4028235E+38f /* Metadata: 0x0205B5CD */) {} // 0x000000018C00FEC0-0x000000018C010690
		static MinMaxSlider() {} // 0x000000018C01B178-0x000000018C01B344
	
		// Methods
		public override void SetValueWithoutNotify(Vector2 newValue) {} // 0x0000000185FE9DE0-0x0000000185FE9DF0
		private Vector2 ClampValues(Vector2 valueToClamp) => default; // 0x0000000185FE9DC0-0x0000000185FE9DE0
		private void UpdateDragElementPosition(GeometryChangedEvent evt) {} // 0x000000018C00FEAC-0x000000018C00FEC0
		private void UpdateDragElementPosition() {} // 0x000000018C00F920-0x000000018C00FA04
		internal float SliderLerpUnclamped(float a, float b, float interpolant) => default; // 0x000000018C00FA04-0x000000018C00FABC
		internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) => default; // 0x000000018C00FDB4-0x000000018C00FE44
		private float ComputeValueFromPosition(float positionToConvert) => default; // 0x000000018C00FABC-0x000000018C00FDB4
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x000000018C00F710-0x000000018C00F7AC
		private void SetSliderValueFromDrag() {} // 0x000000018C00F7AC-0x000000018C00F920
		private void SetSliderValueFromClick() {} // 0x0000000185492010-0x0000000185492020
		private void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos) {} // 0x000000018C010714-0x000000018C010970
		private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) {} // 0x000000018C0195E4-0x000000018C019620
		protected override void UpdateMixedValueContent() {} // 0x000000018C0198B4-0x000000018C019A48
	}

	public class PopupWindow : UnityEngine.UIElements.TextElement // TypeDefIndex: 44448
	{
		// Fields
		private VisualElement m_ContentContainer; // 0x488
		public static readonly string ussClassName; // 0x00
		public static readonly string contentUssClassName; // 0x08
	
		// Properties
		public override VisualElement contentContainer { get => default; } // 0x000000018C01956C-0x000000018C0195A8 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits> // TypeDefIndex: 44446
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C011414-0x000000018C011540
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 44447
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000185FE9D20-0x0000000185FE9D30
		}
	
		// Constructors
		public PopupWindow() {} // 0x000000018C011364-0x000000018C011414
		static PopupWindow() {} // 0x000000018C01AEB0-0x000000018C01AEB8
	}

	public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float> // TypeDefIndex: 44450
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string containerUssClassName; // 0x08
		public static readonly string titleUssClassName; // 0x10
		public static readonly string titleContainerUssClassName; // 0x18
		public static readonly string progressUssClassName; // 0x20
		public static readonly string backgroundUssClassName; // 0x28
		private readonly VisualElement m_Background; // 0x3D0
		private readonly VisualElement m_Progress; // 0x3D8
		private readonly UnityEngine.UIElements.Label m_Title; // 0x3E0
		private float m_LowValue; // 0x3E8
		private float m_HighValue; // 0x3EC
		private float m_Value; // 0x3F0
	
		// Properties
		public string title { get; set; } // 0x000000018C00BBDC-0x000000018C00BBF4
		public float lowValue { get; set; } // 0x0000000185FE9D50-0x0000000185FE9D60 0x000000018C00BBC4-0x000000018C00BBDC
		public float highValue { get; set; } // 0x000000018C00B890-0x000000018C00BBC4 0x000000018C00B5C8-0x000000018C00B5DC
		public virtual float value { get; set; } // 0x000000018C00B67C-0x000000018C00B68C 0x000000018C00B5DC-0x000000018C00B67C
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 44449
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x78
			private UxmlFloatAttributeDescription m_HighValue; // 0x80
			private UxmlFloatAttributeDescription m_Value; // 0x88
			private UxmlStringAttributeDescription m_Title; // 0x90
	
			// Constructors
			public UxmlTraits() {} // 0x0000000185FE9D60-0x0000000185FE9D70
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C00BBF4-0x000000018C00BC18
		}
	
		// Constructors
		public AbstractProgressBar() {} // 0x0000000185FE9D70-0x0000000185FE9D80
		static AbstractProgressBar() {} // 0x000000018C01B7CC-0x000000018C01B9B8
	
		// Methods
		private void OnGeometryChanged(GeometryChangedEvent e) {} // 0x000000018C00BC18-0x000000018C00BD84
		public void SetValueWithoutNotify(float newValue) {} // 0x000000018C00B520-0x000000018C00B5C8
		private void SetProgress(float p) {} // 0x000000018C00B68C-0x000000018C00B890
		private float CalculateProgressWidth(float width) => default; // 0x000000018C01A4D4-0x000000018C01A654
	}

	public class ProgressBar : AbstractProgressBar // TypeDefIndex: 44452
	{
		// Nested types
		public class UxmlFactory : UxmlFactory<ProgressBar, UxmlTraits> // TypeDefIndex: 44451
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C011540-0x000000018C01158C
		}
	
		// Constructors
		public ProgressBar() {} // 0x000000018C019710-0x000000018C01974C
	}

	public class RadioButton : BaseBoolField, IGroupBoxOption // TypeDefIndex: 44455
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
		public static readonly string checkmarkBackgroundUssClassName; // 0x18
		public static readonly string checkmarkUssClassName; // 0x20
		public static readonly string textUssClassName; // 0x28
		private VisualElement m_CheckmarkBackground; // 0x438
	
		// Properties
		public override bool value { get => default; set {} } // 0x000000018C0121F0-0x000000018C0123F4 0x000000018C011DF4-0x000000018C011E64
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits> // TypeDefIndex: 44453
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C0123F4-0x000000018C012430
		}
	
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription> // TypeDefIndex: 44454
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C0121E4-0x000000018C0121F0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C012430-0x000000018C0124D0
		}
	
		// Constructors
		public RadioButton() {} // 0x000000018C011E98-0x000000018C011EC8
		public RadioButton(string label) {} // 0x000000018C011E64-0x000000018C011E78
		static RadioButton() {} // 0x000000018C01AE08-0x000000018C01AEB0
	
		// Methods
		protected override void InitLabel() {} // 0x000000018C011E78-0x000000018C011E98
		protected override void ToggleValue() {} // 0x000000018C011EC8-0x000000018C011F48
		public void SetSelected(bool selected) {} // 0x000000018C011F48-0x000000018C011FE0
		public override void SetValueWithoutNotify(bool newValue) {} // 0x000000018C011FE0-0x000000018C0121E4
		private void UpdateCheckmark() {} // 0x000000018C01983C-0x000000018C019878
		protected override void UpdateMixedValueContent() {} // 0x000000018C019F70-0x000000018C01A054
	}

	public class RadioButtonGroup : BaseField<int>, IGroupBox // TypeDefIndex: 44458
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private IEnumerable<string> m_Choices; // 0x418
		private List<RadioButton> m_RadioButtons; // 0x420
		private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback; // 0x428
	
		// Properties
		public IEnumerable<string> choices { set {} } // 0x000000018C01158C-0x000000018C011648
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits> // TypeDefIndex: 44456
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C011A70-0x000000018C011DF4
		}
	
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription> // TypeDefIndex: 44457
		{
			// Fields
			private UxmlStringAttributeDescription m_Choices; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C0118C4-0x000000018C011A60
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C011A60-0x000000018C011A70
		}
	
		// Constructors
		public RadioButtonGroup() {} // 0x000000018C011648-0x000000018C011698
		public RadioButtonGroup(string label, List<string> radioButtonChoices = null) {} // 0x000000018C011698-0x000000018C011868
		static RadioButtonGroup() {} // 0x000000018C01B344-0x000000018C01B3EC
	
		// Methods
		private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt) {} // 0x000000018C011868-0x000000018C0118C4
		public override void SetValueWithoutNotify(int newValue) {} // 0x000000018C01965C-0x000000018C019698
		private void UpdateRadioButtons() {} // 0x000000018C01A3E4-0x000000018C01A4D4
	}

	public class RepeatButton : UnityEngine.UIElements.TextElement // TypeDefIndex: 44461
	{
		// Fields
		private Clickable m_Clickable; // 0x488
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits> // TypeDefIndex: 44459
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C012670-0x000000018C0126E4
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 44460
		{
			// Fields
			private UxmlLongAttributeDescription m_Delay; // 0x90
			private UxmlLongAttributeDescription m_Interval; // 0x98
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C0124F4-0x000000018C0125BC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C012618-0x000000018C012670
		}
	
		// Constructors
		public RepeatButton() {} // 0x000000018C0124D0-0x000000018C0124F4
		public RepeatButton(Action clickEvent, long delay, long interval) {} // 0x000000018C0125BC-0x000000018C012618
		static RepeatButton() {} // 0x000000018C01B6E0-0x000000018C01B7CC
	
		// Methods
		public void SetAction(Action clickEvent, long delay, long interval) {} // 0x000000018C0196D4-0x000000018C019710
		internal void AddAction(Action clickEvent) {} // 0x000000018C019A48-0x000000018C019B5C
	}

	public class Scroller : VisualElement // TypeDefIndex: 44464
	{
		// Fields
		private Action<float> valueChanged; // 0x3C0
		private Slider _slider_k__BackingField; // 0x3C8
		private RepeatButton _lowButton_k__BackingField; // 0x3D0
		private RepeatButton _highButton_k__BackingField; // 0x3D8
		public static readonly string ussClassName; // 0x00
		public static readonly string horizontalVariantUssClassName; // 0x08
		public static readonly string verticalVariantUssClassName; // 0x10
		public static readonly string sliderUssClassName; // 0x18
		public static readonly string lowButtonUssClassName; // 0x20
		public static readonly string highButtonUssClassName; // 0x28
	
		// Properties
		public Slider slider { get; private set; } // 0x0000000187A47A28-0x0000000187A47A3C 0x0000000185FB70A0-0x0000000185FB70B0
		public RepeatButton lowButton { get; private set; } // 0x0000000187A476CC-0x0000000187A476E0 0x000000018C0184E0-0x000000018C018504
		public RepeatButton highButton { get; private set; } // 0x000000018C018788-0x000000018C0187B0 0x000000018C018498-0x000000018C0184E0
		public float value { get => default; set {} } // 0x000000018C018730-0x000000018C018788 0x000000018C018450-0x000000018C018498
		public float lowValue { get => default; set {} } // 0x000000018C0186D8-0x000000018C018730 0x000000018C018594-0x000000018C0186D8
		public float highValue { get => default; set {} } // 0x000000018C017F78-0x000000018C017FA0 0x000000018C017FA0-0x000000018C0183C0
		public SliderDirection direction { set {} } // 0x000000018C017ACC-0x000000018C017B40
	
		// Events
		public event Action<float> valueChanged;
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Scroller, UxmlTraits> // TypeDefIndex: 44462
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C0183C0-0x000000018C018450
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 44463
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x70
			private UxmlFloatAttributeDescription m_HighValue; // 0x78
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0x80
			private UxmlFloatAttributeDescription m_Value; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x0000000185FB8410-0x0000000185FB8420
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C018504-0x000000018C018594
		}
	
		// Constructors
		public Scroller() {} // 0x000000018C017B40-0x000000018C017BD4
		public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical /* Metadata: 0x0205B5D5 */) {} // 0x000000018C017D64-0x000000018C017D74
		static Scroller() {} // 0x000000018C01B3EC-0x000000018C01B650
	
		// Methods
		public void Adjust(float factor) {} // 0x000000018C017C94-0x000000018C017CA4
		private void OnSliderValueChange(ChangeEvent<float> evt) {} // 0x000000018C017CA4-0x000000018C017D64
		public void ScrollPageUp() {} // 0x000000018C017BD4-0x000000018C017C94
		public void ScrollPageDown() {} // 0x000000018C017D74-0x000000018C017F78
		public void ScrollPageUp(float factor) {} // 0x000000018C019878-0x000000018C0198B4
		public void ScrollPageDown(float factor) {} // 0x000000018C019DB4-0x000000018C019F70
	}

	public enum ScrollViewMode // TypeDefIndex: 44465
	{
		Vertical = 0,
		Horizontal = 1,
		VerticalAndHorizontal = 2
	}

	public enum ScrollerVisibility // TypeDefIndex: 44466
	{
		Auto = 0,
		AlwaysVisible = 1,
		Hidden = 2
	}

	public class ScrollView : VisualElement // TypeDefIndex: 44472
	{
		// Fields
		private int m_FirstLayoutPass; // 0x3C0
		private ScrollerVisibility m_HorizontalScrollerVisibility; // 0x3C4
		private ScrollerVisibility m_VerticalScrollerVisibility; // 0x3C8
		private VisualElement m_AttachedRootVisualContainer; // 0x3D0
		private float m_SingleLineHeight; // 0x3D8
		internal bool m_MouseWheelScrollSizeIsInline; // 0x3DC
		private float m_HorizontalPageSize; // 0x3E0
		private float m_VerticalPageSize; // 0x3E4
		private float m_MouseWheelScrollSize; // 0x3E8
		private static readonly float k_DefaultScrollDecelerationRate; // 0x00
		private float m_ScrollDecelerationRate; // 0x3EC
		private float k_ScaledPixelsPerPointMultiplier; // 0x3F0
		private float k_TouchScrollInertiaBaseTimeInterval; // 0x3F4
		private static readonly float k_DefaultElasticity; // 0x04
		private float m_Elasticity; // 0x3F8
		private TouchScrollBehavior m_TouchScrollBehavior; // 0x3FC
		private NestedInteractionKind m_NestedInteractionKind; // 0x400
		private static readonly long k_DefaultElasticAnimationInterval; // 0x08
		private long m_ElasticAnimationIntervalMs; // 0x408
		private readonly VisualElement _contentViewport_k__BackingField; // 0x410
		private readonly Scroller _horizontalScroller_k__BackingField; // 0x418
		private readonly Scroller _verticalScroller_k__BackingField; // 0x420
		private VisualElement m_ContentContainer; // 0x428
		private VisualElement m_ContentAndVerticalScrollContainer; // 0x430
		private float previousVerticalTouchScrollTimeStamp; // 0x438
		private float previousHorizontalTouchScrollTimeStamp; // 0x43C
		private float elapsedTimeSinceLastVerticalTouchScroll; // 0x440
		private float elapsedTimeSinceLastHorizontalTouchScroll; // 0x444
		public static readonly string ussClassName; // 0x10
		public static readonly string viewportUssClassName; // 0x18
		public static readonly string horizontalVariantViewportUssClassName; // 0x20
		public static readonly string verticalVariantViewportUssClassName; // 0x28
		public static readonly string verticalHorizontalVariantViewportUssClassName; // 0x30
		public static readonly string contentAndVerticalScrollUssClassName; // 0x38
		public static readonly string contentUssClassName; // 0x40
		public static readonly string horizontalVariantContentUssClassName; // 0x48
		public static readonly string verticalVariantContentUssClassName; // 0x50
		public static readonly string verticalHorizontalVariantContentUssClassName; // 0x58
		public static readonly string hScrollerUssClassName; // 0x60
		public static readonly string vScrollerUssClassName; // 0x68
		public static readonly string horizontalVariantUssClassName; // 0x70
		public static readonly string verticalVariantUssClassName; // 0x78
		public static readonly string verticalHorizontalVariantUssClassName; // 0x80
		public static readonly string scrollVariantUssClassName; // 0x88
		private ScrollViewMode m_Mode; // 0x448
		private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; // 0x450
		private Vector2 m_StartPosition; // 0x458
		private Vector2 m_PointerStartPosition; // 0x460
		private Vector2 m_Velocity; // 0x468
		private Vector2 m_SpringBackVelocity; // 0x470
		private Vector2 m_LowBounds; // 0x478
		private Vector2 m_HighBounds; // 0x480
		private float m_LastVelocityLerpTime; // 0x488
		private bool m_StartedMoving; // 0x48C
		private bool m_TouchPointerMoveAllowed; // 0x48D
		private bool m_TouchStoppedVelocity; // 0x48E
		private VisualElement m_CapturedTarget; // 0x490
		private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback; // 0x498
		private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback; // 0x4A0
		internal IVisualElementScheduledItem m_PostPointerUpAnimation; // 0x4A8
	
		// Properties
		public ScrollerVisibility horizontalScrollerVisibility { get => default; set {} } // 0x000000018C017A88-0x000000018C017ACC 0x000000018C017978-0x000000018C017998
		public ScrollerVisibility verticalScrollerVisibility { get => default; set {} } // 0x000000018C017998-0x000000018C0179B8 0x000000018C01753C-0x000000018C01757C
		public bool showHorizontal { set {} } // 0x000000018C01757C-0x000000018C0175BC
		public bool showVertical { set {} } // 0x000000018C017514-0x000000018C01753C
		internal bool needsHorizontal { get => default; } // 0x000000018C0174EC-0x000000018C017514 
		internal bool needsVertical { get => default; } // 0x000000018C0175BC-0x000000018C01760C 
		internal bool isVerticalScrollDisplayed { get => default; } // 0x000000018C0178A8-0x000000018C017978 
		internal bool isHorizontalScrollDisplayed { get => default; } // 0x000000018C0177B0-0x000000018C0177C0 
		public Vector2 scrollOffset { get => default; set {} } // 0x000000018C017A78-0x000000018C017A88 0x0000000185FC9AA0-0x0000000185FC9AB0
		public float horizontalPageSize { set {} } // 0x000000018C017818-0x000000018C017894
		public float verticalPageSize { set {} } // 0x000000018C017678-0x000000018C0176E4
		public float mouseWheelScrollSize { get => default; set {} } // 0x000000018C01760C-0x000000018C017678 0x000000018C0174D8-0x000000018C0174EC
		internal float scrollableWidth { get => default; } // 0x0000000185FE9E70-0x0000000185FE9E80 
		internal float scrollableHeight { get => default; } // 0x000000018C017894-0x000000018C0178A8 
		private bool hasInertia { get => default; } // 0x0000000185FE9E30-0x0000000185FE9E40 
		public float scrollDecelerationRate { get => default; set {} } // 0x000000018C01779C-0x000000018C0177B0 0x0000000185FE9E80-0x0000000185FE9E90
		public float elasticity { get => default; set {} } // 0x000000018C0179B8-0x000000018C017A78 0x0000000185FE9E60-0x0000000185FE9E70
		public TouchScrollBehavior touchScrollBehavior { get => default; set {} } // 0x0000000185FE9EA0-0x0000000185FE9EB0 0x000000018C0176E4-0x000000018C01779C
		public NestedInteractionKind nestedInteractionKind { get => default; set {} } // 0x000000018C0142F8-0x000000018C01437C 0x000000018C014EF8-0x000000018C014F7C
		public long elasticAnimationIntervalMs { set {} } // 0x000000018C015D40-0x000000018C015E18
		public VisualElement contentViewport { get; } // 0x0000000185FE9E20-0x0000000185FE9E30 
		public Scroller horizontalScroller { get; } // 0x000000018C0174CC-0x000000018C0174D8 
		public Scroller verticalScroller { get; } // 0x000000018C016778-0x000000018C0174CC 
		public override VisualElement contentContainer { get => default; } // 0x0000000185FE9E50-0x0000000185FE9E60 
		public ScrollViewMode mode { get => default; set {} } // 0x000000018C0138CC-0x000000018C013D4C 0x000000018C013D4C-0x000000018C0141D4
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits> // TypeDefIndex: 44467
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FE9E40-0x0000000185FE9E50
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 44468
		{
			// Fields
			private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode; // 0x70
			private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind; // 0x78
			private UxmlBoolAttributeDescription m_ShowHorizontal; // 0x80
			private UxmlBoolAttributeDescription m_ShowVertical; // 0x88
			private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility; // 0x90
			private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; // 0x98
			private UxmlFloatAttributeDescription m_HorizontalPageSize; // 0xA0
			private UxmlFloatAttributeDescription m_VerticalPageSize; // 0xA8
			private UxmlFloatAttributeDescription m_MouseWheelScrollSize; // 0xB0
			private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior; // 0xB8
			private UxmlFloatAttributeDescription m_ScrollDecelerationRate; // 0xC0
			private UxmlFloatAttributeDescription m_Elasticity; // 0xC8
			private UxmlLongAttributeDescription m_ElasticAnimationIntervalMs; // 0xD0
	
			// Constructors
			public UxmlTraits() {} // 0x0000000185FE9E90-0x0000000185FE9EA0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C0177C0-0x000000018C017804
		}
	
		public enum TouchScrollBehavior // TypeDefIndex: 44469
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		public enum NestedInteractionKind // TypeDefIndex: 44470
		{
			Default = 0,
			StopScrolling = 1,
			ForwardScrolling = 2
		}
	
		internal enum TouchScrollingResult // TypeDefIndex: 44471
		{
			Apply = 0,
			Forward = 1,
			Block = 2
		}
	
		// Constructors
		public ScrollView() {} // 0x000000018C017804-0x000000018C017818
		public ScrollView(ScrollViewMode scrollViewMode) {} // 0x000000018C0154E8-0x000000018C0158C0
		static ScrollView() {} // 0x000000018C019620-0x000000018C01965C
	
		// Methods
		private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) {} // 0x000000018C016130-0x000000018C016208
		private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) {} // 0x000000018C015AFC-0x000000018C015C1C
		private void UpdateHorizontalSliderPageSize() {} // 0x000000018C0152F0-0x000000018C0154E8
		private void UpdateVerticalSliderPageSize() {} // 0x000000018C013490-0x000000018C0135FC
		internal void UpdateContentViewTransform() {} // 0x000000018C0135FC-0x000000018C013774
		public void ScrollTo(VisualElement child) {} // 0x000000018C01343C-0x000000018C013490
		private float GetXDeltaOffset(VisualElement child) => default; // 0x0000000185FB8500-0x0000000185FB8510
		private float GetYDeltaOffset(VisualElement child) => default; // 0x0000000185FB85B0-0x0000000185FB85C0
		private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) => default; // 0x0000000185FB8740-0x0000000185FB8750
		private void SetScrollViewMode(ScrollViewMode mode) {} // 0x000000018C0144A0-0x000000018C014588
		private void OnAttachToPanel(AttachToPanelEvent evt) {} // 0x000000018C0143D4-0x000000018C0144A0
		private void OnDetachFromPanel(DetachFromPanelEvent evt) {} // 0x000000018C0141D4-0x000000018C0142F8
		private void OnPointerCapture(PointerCaptureEvent evt) {} // 0x000000018C015238-0x000000018C0152F0
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt) {} // 0x0000000185FE9E10-0x0000000185FE9E20
		private void OnGeometryChanged(GeometryChangedEvent evt) {} // 0x000000018C012D94-0x000000018C012EFC
		private void ScheduleResetLayoutPass() {} // 0x000000018C012EFC-0x000000018C01300C
		private void ResetLayoutPass() {} // 0x000000018C0158C0-0x000000018C015A64
		private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) => default; // 0x000000018C012848-0x000000018C012B7C
		private void ComputeInitialSpringBackVelocity() {} // 0x000000018C014F7C-0x000000018C01507C
		private void SpringBack() {} // 0x000000018C014588-0x000000018C014764
		internal void ApplyScrollInertia() {} // 0x000000018C014764-0x000000018C0149B8
		private void PostPointerUpAnimation() {} // 0x000000018C01437C-0x000000018C0143D4
		private void OnPointerDown(PointerDownEvent evt) {} // 0x000000018C0149B8-0x000000018C014A40
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x000000018C013774-0x000000018C0138CC
		private void OnPointerCancel(PointerCancelEvent evt) {} // 0x000000018C01300C-0x000000018C013368
		private void OnPointerUp(PointerUpEvent evt) {} // 0x000000018C012B7C-0x000000018C012D94
		internal void InitTouchScrolling(Vector2 position) {} // 0x000000018C015160-0x000000018C015238
		internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) => default; // 0x000000018C013368-0x000000018C01343C
		private bool ApplyTouchScrolling(Vector2 newScrollOffset) => default; // 0x000000018C0126E4-0x000000018C012848
		private bool ReleaseScrolling(int pointerId, IEventHandler target) => default; // 0x000000018C015E18-0x000000018C016130
		private void ExecuteElasticSpringAnimation() {} // 0x000000018C014DA8-0x000000018C014EF8
		private void AdjustScrollers() {} // 0x000000018C014A48-0x000000018C014DA8
		internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) {} // 0x000000018C014A40-0x000000018C014A48
		private void OnScrollersGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000185FE9E00-0x0000000185FE9E10
		private void OnScrollWheel(WheelEvent evt) {} // 0x000000018C01507C-0x000000018C015160
		private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) {} // 0x000000018C015C1C-0x000000018C015D40
		private void OnRootPointerUp(PointerUpEvent evt) {} // 0x000000018C016208-0x000000018C016778
		private void ReadSingleLineHeight() {} // 0x000000018C015A64-0x000000018C015AB0
		private void UpdateElasticBehaviour() {} // 0x000000018C015AB0-0x000000018C015AFC
		private void _.ctor_b__126_0(float value) {} // 0x000000018C01A054-0x000000018C01A3E4
		private void _.ctor_b__126_1(float value) {} // 0x000000018C01A830-0x000000018C01AE08
	}

	public class Slider : BaseSlider<float> // TypeDefIndex: 44475
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Slider, UxmlTraits> // TypeDefIndex: 44473
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C019510-0x000000018C01953C
		}
	
		public class UxmlTraits : BaseFieldTraits<float, UxmlFloatAttributeDescription> // TypeDefIndex: 44474
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x88
			private UxmlFloatAttributeDescription m_HighValue; // 0x90
			private UxmlFloatAttributeDescription m_PageSize; // 0x98
			private UxmlBoolAttributeDescription m_ShowInputField; // 0xA0
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0xA8
			private UxmlBoolAttributeDescription m_Inverted; // 0xB0
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C0193D0-0x000000018C019510
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C01953C-0x000000018C01956C
		}
	
		// Constructors
		public Slider() {} // 0x000000018C019158-0x000000018C0192C8
		public Slider(float start, float end, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x0205B5E5 */, float pageSize = 0f /* Metadata: 0x0205B5E6 */) {} // 0x000000018C00FEAC-0x000000018C00FEC0
		public Slider(string label, float start = 0f /* Metadata: 0x0205B5EA */, float end = 10f /* Metadata: 0x0205B5EE */, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x0205B5F2 */, float pageSize = 0f /* Metadata: 0x0205B5F3 */) {} // 0x000000018C0190A0-0x000000018C019158
		static Slider() {} // 0x000000018C01AEC0-0x000000018C01B178
	
		// Methods
		internal override float SliderLerpUnclamped(float a, float b, float interpolant) => default; // 0x000000018C018F0C-0x000000018C0190A0
		internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) => default; // 0x000000018C0192C8-0x000000018C0193D0
		internal override float ParseStringToValue(string stringValue) => default; // 0x000000018C019698-0x000000018C0196D4
		internal override void ComputeValueFromKey(BaseSlider<float> sliderKey, bool isShift) {} // 0x000000018C019B5C-0x000000018C019DB4
	}

	public class SliderInt : BaseSlider<int> // TypeDefIndex: 44478
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Properties
		public override float pageSize { get => default; set {} } // 0x000000018C018BDC-0x000000018C018C0C 0x000000018C018B8C-0x000000018C018BBC
	
		// Nested types
		public class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits> // TypeDefIndex: 44476
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C018D14-0x000000018C018D44
		}
	
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription> // TypeDefIndex: 44477
		{
			// Fields
			private UxmlIntAttributeDescription m_LowValue; // 0x88
			private UxmlIntAttributeDescription m_HighValue; // 0x90
			private UxmlIntAttributeDescription m_PageSize; // 0x98
			private UxmlBoolAttributeDescription m_ShowInputField; // 0xA0
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0xA8
			private UxmlBoolAttributeDescription m_Inverted; // 0xB0
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C018E7C-0x000000018C018EBC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C018D44-0x000000018C018E7C
		}
	
		// Constructors
		public SliderInt() {} // 0x000000018C018EBC-0x000000018C018F0C
		public SliderInt(string label, int start = 0 /* Metadata: 0x0205B5F7 */, int end = 10 /* Metadata: 0x0205B5F8 */, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x0205B5F9 */, float pageSize = 0f /* Metadata: 0x0205B5FA */) {} // 0x000000018C018BBC-0x000000018C018BDC
		static SliderInt() {} // 0x000000018C02DBB8-0x000000018C02DE70
	
		// Methods
		internal override int SliderLerpUnclamped(int a, int b, float interpolant) => default; // 0x000000018C0187B0-0x000000018C0189E4
		internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) => default; // 0x000000018C0189E4-0x000000018C018B8C
		internal override int ParseStringToValue(string stringValue) => default; // 0x000000018C018C0C-0x000000018C018D14
		internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) {} // 0x000000018C02CD6C-0x000000018C02CDA8
		internal override void ComputeValueFromKey(BaseSlider<int> sliderKey, bool isShift) {} // 0x000000018C02CEC8-0x000000018C02D118
	}

	internal class TextEditorEventHandler // TypeDefIndex: 44479
	{
		// Fields
		private TextEditorEngine _editorEngine_k__BackingField; // 0x10
		private ITextInputField _textInputField_k__BackingField; // 0x18
	
		// Properties
		protected TextEditorEngine editorEngine { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		protected ITextInputField textInputField { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public TextEditorEventHandler() {} // Dummy constructor
		protected TextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField) {} // 0x000000018C028F30-0x000000018C028F6C
	
		// Methods
		public virtual void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x0000000185492010-0x0000000185492020
		public virtual void ExecuteDefaultAction(EventBase evt) {} // 0x000000018C028E18-0x000000018C028F30
	}

	internal class TextEditorEngine : TextEditor // TypeDefIndex: 44482
	{
		// Fields
		private OnDetectFocusChangeFunction m_DetectFocusChangeFunction; // 0x90
		private OnIndexChangeFunction m_IndexChangeFunction; // 0x98
	
		// Properties
		internal override Rect localPosition { get => default; } // 0x00000001864BC330-0x00000001864BC3F4 
	
		// Nested types
		internal delegate void OnDetectFocusChangeFunction(); // TypeDefIndex: 44480; 0x0000000185FE9F10-0x0000000185FE9F50
	
		internal delegate void OnIndexChangeFunction(); // TypeDefIndex: 44481; 0x000000018C028D74-0x000000018C028D9C
	
		// Constructors
		public TextEditorEngine() {} // Dummy constructor
		public TextEditorEngine(OnDetectFocusChangeFunction detectFocusChange, OnIndexChangeFunction indexChangeFunction) {} // 0x000000018C028D74-0x000000018C028D9C
	
		// Methods
		internal override void OnDetectFocusChange() {} // 0x00000001864BC320-0x00000001864BC330
		internal override void OnCursorIndexChange() {} // 0x00000001864BC330-0x00000001864BC3F4
		internal override void OnSelectIndexChange() {} // 0x00000001864BC320-0x00000001864BC330
	}

	public class TextField : TextInputBaseField<string> // TypeDefIndex: 44486
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Properties
		private TextInput textInput { get => default; } // 0x000000018C029DC0-0x000000018C029E00 
		public bool multiline { set {} } // 0x0000000185FE9F60-0x0000000185FE9F70
		public override string value { get => default; set {} } // 0x0000000185FE9F50-0x0000000185FE9F60 0x000000018C029CF4-0x000000018C029D84
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TextField, UxmlTraits> // TypeDefIndex: 44483
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C029368-0x000000018C0293B4
		}
	
		public class UxmlTraits : TextInputBaseField<string> // TypeDefIndex: 44484
		{
			// Fields
			private static readonly UxmlStringAttributeDescription k_Value; // 0x00
			private UxmlBoolAttributeDescription m_Multiline; // 0xB8
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C02935C-0x000000018C029368
			static UxmlTraits() {} // 0x000000018C029330-0x000000018C02935C
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C0293F0-0x000000018C029420
		}
	
		private class TextInput : TextInputBaseField<string> // TypeDefIndex: 44485
		{
			// Fields
			private bool m_Multiline; // 0x420
	
			// Properties
			private TextField parentTextField { get => default; } // 0x000000018C029170-0x000000018C029330 
			public bool multiline { get => default; set {} } // 0x000000018C0293B4-0x000000018C0293F0 0x000000018C029420-0x000000018C029498
			public override bool isPasswordField { set {} } // 0x000000018C028F6C-0x000000018C028FF0
	
			// Constructors
			public TextInput() {} // 0x000000018C02D680-0x000000018C02D778
	
			// Methods
			private void SetTextAlign() {} // 0x000000018C028FF0-0x000000018C029068
			protected override string StringToValue(string str) => default; // 0x000000018C029068-0x000000018C029170
			internal override void SyncTextEngine() {} // 0x000000018C02CC7C-0x000000018C02CCB8
			protected override void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x000000018C02D260-0x000000018C02D3D8
			protected override void ExecuteDefaultAction(EventBase evt) {} // 0x000000018C02D778-0x000000018C02D820
		}
	
		// Constructors
		public TextField() {} // 0x000000018C029E50-0x000000018C029EFC
		public TextField(string label) {} // 0x000000018C029C44-0x000000018C029CF4
		public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar) {} // 0x000000018C029E00-0x000000018C029E50
		static TextField() {} // 0x000000018C029D84-0x000000018C029DC0
	
		// Methods
		public override void SetValueWithoutNotify(string newValue) {} // 0x000000018C029498-0x000000018C029AE0
		internal override void OnViewDataReady() {} // 0x000000018C029AE0-0x000000018C029C44
	}

	internal interface ITextInputField : IEventHandler, ITextElement // TypeDefIndex: 44487
	{
		// Properties
		bool hasFocus { get; }
		bool doubleClickSelectsWord { get; }
		bool tripleClickSelectsLine { get; }
		bool isReadOnly { get; }
		bool isDelayed { get; }
		bool isPasswordField { get; }
		TextEditorEngine editorEngine { get; }
	
		// Methods
		void SyncTextEngine();
		bool AcceptCharacter(char c);
		string CullString(string s);
		void UpdateText(string value);
		void UpdateValueFromText();
	}

	public abstract class TextInputBaseField<TValueType> : BaseField<TValueType> // TypeDefIndex: 44490
	{
		// Fields
		private static CustomStyleProperty<UnityEngine.Color> s_SelectionColorProperty;
		private static CustomStyleProperty<UnityEngine.Color> s_CursorColorProperty;
		private int m_VisualInputTabIndex;
		private TextInputBase m_TextInputBase;
		private ITextHandle _iTextHandle_k__BackingField;
		public static readonly string ussClassName;
		public static readonly string labelUssClassName;
		public static readonly string inputUssClassName;
		public static readonly string singleLineInputUssClassName;
		public static readonly string multilineInputUssClassName;
		public static readonly string textInputUssName;
		private Action<bool> onIsReadOnlyChanged;
	
		// Properties
		protected internal TextInputBase textInputBase { get; }
		private ITextHandle iTextHandle { get; set; }
		public string text { get; set; }
		public bool isReadOnly { get; set; }
		public bool isPasswordField { get; set; }
		public int maxLength { get; set; }
		public bool isDelayed { get; set; }
		public char maskChar { get; set; }
	
		// Nested types
		public class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription> // TypeDefIndex: 44488
		{
			// Fields
			private UxmlIntAttributeDescription m_MaxLength;
			private UxmlBoolAttributeDescription m_Password;
			private UxmlStringAttributeDescription m_MaskCharacter;
			private UxmlStringAttributeDescription m_Text;
			private UxmlBoolAttributeDescription m_IsReadOnly;
			private UxmlBoolAttributeDescription m_IsDelayed;
	
			// Constructors
			public UxmlTraits() {}
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {}
		}
	
		protected internal abstract class TextInputBase : VisualElement, ITextInputField // TypeDefIndex: 44489
		{
			// Fields
			private string m_OriginalText;
			private bool _isReadOnly_k__BackingField;
			private int _maxLength_k__BackingField;
			private char _maskChar_k__BackingField;
			private bool _isPasswordField_k__BackingField;
			private bool _doubleClickSelectsWord_k__BackingField;
			private bool _tripleClickSelectsLine_k__BackingField;
			private bool _isDelayed_k__BackingField;
			private bool _isDragging_k__BackingField;
			private bool m_TouchScreenTextFieldInitialized;
			private IVisualElementScheduledItem m_HardwareKeyboardPoller;
			private UnityEngine.Color m_SelectionColor;
			private UnityEngine.Color m_CursorColor;
			private TextEditorEventHandler _editorEventHandler_k__BackingField;
			private TextEditorEngine _editorEngine_k__BackingField;
			private ITextHandle m_TextHandle;
			private string m_Text;
	
			// Properties
			bool ITextInputField.isReadOnly { get; }
			public bool isReadOnly { get; set; }
			public int maxLength { get; set; }
			public char maskChar { get; set; }
			public virtual bool isPasswordField { get; set; }
			public bool doubleClickSelectsWord { get; set; }
			public bool tripleClickSelectsLine { get; set; }
			internal bool isDelayed { get; set; }
			internal bool isDragging { get; }
			private bool touchScreenTextField { get; }
			private bool touchScreenTextFieldChanged { get; }
			public UnityEngine.Color selectionColor { get; }
			public UnityEngine.Color cursorColor { get; }
			internal bool hasFocus { get; }
			internal TextEditorEventHandler editorEventHandler { get; private set; }
			internal TextEditorEngine editorEngine { get; private set; }
			public string text { get; set; }
			bool ITextInputField.hasFocus { get; }
			TextEditorEngine ITextInputField.editorEngine { get; }
			bool ITextInputField.isDelayed { get; }
	
			// Constructors
			internal TextInputBase() {}
	
			// Methods
			public void ResetValueAndText() {}
			private void SaveValueAndText() {}
			private void RestoreValueAndText() {}
			private void UpdateText(string value) {}
			protected virtual TValueType StringToValue(string str) => default;
			internal void UpdateValueFromText() {}
			private void InitTextEditorEventHandler() {}
			private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a) => default;
			private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a) => default;
			private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a) => default;
			private void ProcessMenuCommand(string command) {}
			private void Cut(DropdownMenuAction a) {}
			private void Copy(DropdownMenuAction a) {}
			private void Paste(DropdownMenuAction a) {}
			internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) {}
			private void OnAttachToPanel(AttachToPanelEvent attachEvent) {}
			internal virtual void SyncTextEngine() {}
			internal string CullString(string s) => default;
			internal void OnGenerateVisualContent(MeshGenerationContext mgc) {}
			internal void DrawWithTextSelectionAndCursor(MeshGenerationContext mgc, string newText, float pixelsPerPoint) {}
			internal virtual bool AcceptCharacter(char c) => default;
			protected virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt) {}
			private void OnDetectFocusChange() {}
			private void OnCursorIndexChange() {}
			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default;
			internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt) {}
			protected override void ExecuteDefaultActionAtTarget(EventBase evt) {}
			private void ProcessEventAtTarget(EventBase evt) {}
			protected override void ExecuteDefaultAction(EventBase evt) {}
			void ITextInputField.SyncTextEngine() {}
			bool ITextInputField.AcceptCharacter(char c) => default;
			string ITextInputField.CullString(string s) => default;
			void ITextInputField.UpdateText(string value) {}
			void ITextInputField.UpdateValueFromText() {}
			private void DeferGUIStyleRectSync() {}
			private void OnPercentResolved(GeometryChangedEvent evt) {}
			private static void SyncGUIStyle(TextInputBase<TValueType> textInput, GUIStyle style) {}
			private static bool IsLayoutUsingPercent(VisualElement ve) => default;
			private static void AssignRect(RectOffset rect, int left, int top, int right, int bottom) {}
			private void _ProcessEventAtTarget_b__99_0() {}
		}
	
		// Constructors
		protected TextInputBaseField() {} // Dummy constructor
		protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase textInputBase) {}
		static TextInputBaseField() {}
	
		// Methods
		private new void OnAttachToPanel(AttachToPanelEvent e) {}
		private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) {}
		protected override void ExecuteDefaultActionAtTarget(EventBase evt) {}
		protected override void UpdateMixedValueContent() {}
	}

	public class Toggle : BaseBoolField // TypeDefIndex: 44493
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
		public static readonly string noTextVariantUssClassName; // 0x18
		public static readonly string checkmarkUssClassName; // 0x20
		public static readonly string textUssClassName; // 0x28
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Toggle, UxmlTraits> // TypeDefIndex: 44491
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C02A26C-0x000000018C02A278
		}
	
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription> // TypeDefIndex: 44492
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C029EFC-0x000000018C029F6C
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C02A170-0x000000018C02A26C
		}
	
		// Constructors
		public Toggle() {} // 0x000000018C029F6C-0x000000018C02A170
		public Toggle(string label) {} // 0x000000018C02CCB8-0x000000018C02CCF4
		static Toggle() {} // 0x000000018C02DE78-0x000000018C02E0A0
	
		// Methods
		protected override void InitLabel() {} // 0x000000018C02CDE4-0x000000018C02CEC8
	}

	internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler // TypeDefIndex: 44494
	{
		// Fields
		private IVisualElementScheduledItem m_TouchKeyboardPoller; // 0x20
		private VisualElement m_LastPointerDownTarget; // 0x28
	
		// Constructors
		public TouchScreenTextEditorEventHandler() {} // Dummy constructor
		public TouchScreenTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField) {} // 0x000000018C02A898-0x000000018C02A8D0
	
		// Methods
		private void PollTouchScreenKeyboard() {} // 0x000000018C02A798-0x000000018C02A898
		private void DoPollTouchScreenKeyboard() {} // 0x000000018C02A278-0x000000018C02A440
		public override void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x000000018C02A440-0x000000018C02A798
	}

	public class TreeView : BaseTreeView // TypeDefIndex: 44497
	{
		// Fields
		private Func<VisualElement> m_MakeItem; // 0x4B8
		private Action<VisualElement, int> m_BindItem; // 0x4C0
		private Action<VisualElement, int> _unbindItem_k__BackingField; // 0x4C8
		private Action<VisualElement> _destroyItem_k__BackingField; // 0x4D0
	
		// Properties
		public Func<VisualElement> makeItem { get => default; set {} } // 0x0000000185FB8760-0x0000000185FB8770 0x000000018C02AA4C-0x000000018C02AA9C
		public Action<VisualElement, int> bindItem { get => default; set {} } // 0x0000000185FB8710-0x0000000185FB8720 0x0000000181ACF060-0x0000000181ACF070
		public Action<VisualElement, int> unbindItem { get; } // 0x000000018C02A984-0x000000018C02A9C0 
		public Action<VisualElement> destroyItem { get; } // 0x000000018C02A928-0x000000018C02A984 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TreeView, UxmlTraits> // TypeDefIndex: 44495
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FB8750-0x0000000185FB8760
		}
	
		public class UxmlTraits : BaseTreeView.UxmlTraits // TypeDefIndex: 44496
		{
			// Constructors
			public UxmlTraits() {} // 0x000000018C02AA9C-0x000000018C02AAEC
		}
	
		// Constructors
		public TreeView() {} // 0x000000018C02CC40-0x000000018C02CC7C
		public TreeView(Func<VisualElement> makeItem, Action<VisualElement, int> bindItem) {} // 0x000000018C02DE70-0x000000018C02DE78
	
		// Methods
		internal override bool HasValidDataAndBindings() => default; // 0x000000018C02A9C0-0x000000018C02A9D0
		protected override CollectionViewController CreateViewController() => default; // 0x000000018C02A9D0-0x000000018C02AA4C
	}

	internal struct TreeData<T> // TypeDefIndex: 44498
	{
		// Fields
		private readonly IList<int> m_RootItemIds;
		private readonly Dictionary<int, TreeViewItemData<T>> m_Tree;
		private readonly Dictionary<int, int> m_ParentIds;
		private readonly Dictionary<int, List<int>> m_ChildrenIds;
	
		// Properties
		public IEnumerable<int> rootItemIds { get => default; }
	
		// Constructors
		public TreeData(IList<TreeViewItemData<T>> rootItems) : this() {
			m_RootItemIds = default;
			m_Tree = default;
			m_ParentIds = default;
			m_ChildrenIds = default;
		}
	
		// Methods
		public TreeViewItemData<T> GetDataForId(int id) => default;
		public int GetParentId(int id) => default;
		public void Move(int id, int newParentId, int childIndex) {}
		public bool HasAncestor(int childId, int ancestorId) => default;
		private void AddItemToParent(TreeViewItemData<T> item, int parentId, int childIndex) {}
		private void RemoveFromParent(int id, int parentId) {}
		private void UpdateParentTree(TreeViewItemData<T> current) {}
		private void RefreshTree(IList<TreeViewItemData<T>> rootItems) {}
		private void BuildTree(IEnumerable<TreeViewItemData<T>> items, bool isRoot) {}
	}

	internal struct TreeItem // TypeDefIndex: 44499
	{
		// Fields
		private readonly int _id_k__BackingField; // 0x00
		private readonly int _parentId_k__BackingField; // 0x04
		private readonly IEnumerable<int> _childrenIds_k__BackingField; // 0x08
	
		// Properties
		public int id { get; } // 0x00000001818226B0-0x00000001818226C0 
		public int parentId { get; } // 0x000000018357CBC0-0x000000018357CBD0 
		public IEnumerable<int> childrenIds { get; } // 0x000000018357A260-0x000000018357A270 
		public bool hasChildren { get => default; } // 0x000000018C02A8D0-0x000000018C02A920 
	
		// Constructors
		public TreeItem(int id, int parentId = -1 /* Metadata: 0x0205B5FE */, IEnumerable<int> childrenIds = null) : this() {
			<id>k__BackingField = default;
			<parentId>k__BackingField = default;
			<childrenIds>k__BackingField = default;
		} // 0x0000000186473D34-0x0000000186473D48
	}

	internal struct TreeViewItemWrapper // TypeDefIndex: 44500
	{
		// Fields
		public readonly TreeItem item; // 0x00
		public readonly int depth; // 0x10
	
		// Properties
		public int id { get => default; } // 0x00000001818226B0-0x00000001818226C0 
		public IEnumerable<int> childrenIds { get => default; } // 0x000000018357A260-0x000000018357A270 
		public bool hasChildren { get => default; } // 0x000000018C02A920-0x000000018C02A928 
	
		// Constructors
		public TreeViewItemWrapper(TreeItem item, int depth) : this() {
			this.item = default;
			this.depth = default;
		} // 0x00000001893180FC-0x0000000189318120
	}

	public struct TreeViewItemData<T> // TypeDefIndex: 44501
	{
		// Fields
		private readonly int _id_k__BackingField;
		private readonly T m_Data;
		private readonly IList<TreeViewItemData<T>> m_Children;
	
		// Properties
		public int id { get; }
		public T data { get => default; }
		public IEnumerable<TreeViewItemData<T>> children { get => default; }
		public bool hasChildren { get => default; }
	
		// Methods
		internal void InsertChild(TreeViewItemData<T> child, int index) {}
		internal void RemoveChild(int childId) {}
		internal int GetChildIndex(int itemId) => default;
		internal void ReplaceChild(TreeViewItemData<T> newChild) {}
	}

	public class TwoPaneSplitView : VisualElement // TypeDefIndex: 44504
	{
		// Fields
		private static readonly string s_UssClassName; // 0x00
		private static readonly string s_ContentContainerClassName; // 0x08
		private static readonly string s_HandleDragLineClassName; // 0x10
		private static readonly string s_HandleDragLineVerticalClassName; // 0x18
		private static readonly string s_HandleDragLineHorizontalClassName; // 0x20
		private static readonly string s_HandleDragLineAnchorClassName; // 0x28
		private static readonly string s_HandleDragLineAnchorVerticalClassName; // 0x30
		private static readonly string s_HandleDragLineAnchorHorizontalClassName; // 0x38
		private static readonly string s_VerticalClassName; // 0x40
		private static readonly string s_HorizontalClassName; // 0x48
		private VisualElement m_LeftPane; // 0x3C0
		private VisualElement m_RightPane; // 0x3C8
		private VisualElement m_FixedPane; // 0x3D0
		private VisualElement m_FlexedPane; // 0x3D8
		private float m_FixedPaneDimension; // 0x3E0
		private VisualElement m_DragLine; // 0x3E8
		private VisualElement m_DragLineAnchor; // 0x3F0
		private bool m_CollapseMode; // 0x3F8
		private VisualElement m_Content; // 0x400
		private TwoPaneSplitViewOrientation m_Orientation; // 0x408
		private int m_FixedPaneIndex; // 0x40C
		private float m_FixedPaneInitialDimension; // 0x410
		internal TwoPaneSplitViewResizer m_Resizer; // 0x418
	
		// Properties
		public VisualElement fixedPane { get => default; } // 0x000000018C02CB44-0x000000018C02CB68 
		public VisualElement flexedPane { get => default; } // 0x000000018C02CB68-0x000000018C02CB84 
		public int fixedPaneIndex { get => default; } // 0x000000018C02C8C4-0x000000018C02CB44 
		internal float fixedPaneDimension { get => default; set {} } // 0x000000018C02B4CC-0x000000018C02B824 0x000000018C02B824-0x000000018C02B90C
		public override VisualElement contentContainer { get => default; } // 0x000000018C02C53C-0x000000018C02C5FC 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits> // TypeDefIndex: 44502
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000185FB7090-0x0000000185FB70A0
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 44503
		{
			// Fields
			private UxmlIntAttributeDescription m_FixedPaneIndex; // 0x70
			private UxmlIntAttributeDescription m_FixedPaneInitialDimension; // 0x78
			private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation; // 0x80
	
			// Constructors
			public UxmlTraits() {} // 0x0000000185FE9F80-0x0000000185FE9F90
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000185FB70A0-0x0000000185FB70B0
		}
	
		// Constructors
		public TwoPaneSplitView() {} // 0x000000018C02BB20-0x000000018C02C47C
		static TwoPaneSplitView() {} // 0x000000018C02D820-0x000000018C02D998
	
		// Methods
		internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) {} // 0x000000018C02BAE8-0x000000018C02BAF0
		private void OnPostDisplaySetup(GeometryChangedEvent evt) {} // 0x000000018C02B90C-0x000000018C02BAE8
		private void PostDisplaySetup() {} // 0x0000000185FE9F70-0x0000000185FE9F80
		private void OnSizeChange(GeometryChangedEvent evt) {} // 0x000000018C02BAF0-0x000000018C02BB20
		private void OnSizeChange() {} // 0x000000018C02C47C-0x000000018C02C53C
		internal override void OnViewDataReady() {} // 0x000000018C02C5FC-0x000000018C02C8C4
		private void SetDragLineOffset(float offset) {} // 0x000000018C02CD30-0x000000018C02CD6C
		private void SetFixedPaneDimension(float dimension) {} // 0x000000018C02D3D8-0x000000018C02D538
	}

	public enum TwoPaneSplitViewOrientation // TypeDefIndex: 44505
	{
		Horizontal = 0,
		Vertical = 1
	}

	internal class TwoPaneSplitViewResizer : PointerManipulator // TypeDefIndex: 44506
	{
		// Fields
		private Vector3 m_Start; // 0x38
		protected bool m_Active; // 0x44
		private TwoPaneSplitView m_SplitView; // 0x48
		private int m_Direction; // 0x50
		private TwoPaneSplitViewOrientation m_Orientation; // 0x54
	
		// Properties
		private VisualElement fixedPane { get => default; } // 0x000000018C02B43C-0x000000018C02B45C 
		private VisualElement flexedPane { get => default; } // 0x000000018C02B4AC-0x000000018C02B4CC 
		private float fixedPaneMinDimension { get => default; } // 0x000000018C02B3EC-0x000000018C02B43C 
		private float flexedPaneMinDimension { get => default; } // 0x000000018C02B45C-0x000000018C02B4AC 
	
		// Constructors
		public TwoPaneSplitViewResizer() {} // Dummy constructor
		public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir, TwoPaneSplitViewOrientation orientation) {} // 0x000000018C02B338-0x000000018C02B3EC
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x000000018C02B030-0x000000018C02B1B4
		protected override void UnregisterCallbacksFromTarget() {} // 0x000000018C02B1B4-0x000000018C02B338
		public void ApplyDelta(float delta) {} // 0x000000018C02AAEC-0x000000018C02ADF4
		protected void OnPointerDown(PointerDownEvent e) {} // 0x000000018C02ADF4-0x000000018C02AEA0
		protected void OnPointerMove(PointerMoveEvent e) {} // 0x000000018C02AEA0-0x000000018C02AFA4
		protected void OnPointerUp(PointerUpEvent e) {} // 0x000000018C02AFA4-0x000000018C02B030
	}

	internal enum ColumnDataType // TypeDefIndex: 44507
	{
		Name = 0,
		Title = 1,
		Icon = 2,
		Visibility = 3,
		Width = 4,
		MaxWidth = 5,
		MinWidth = 6,
		Stretchable = 7,
		Sortable = 8,
		Optional = 9,
		Resizable = 10,
		HeaderTemplate = 11,
		CellTemplate = 12
	}

	public class Column // TypeDefIndex: 44512
	{
		// Fields
		private static readonly string k_InvalidTemplateError; // 0x00
		private string m_Name; // 0x10
		private string m_Title; // 0x18
		private Background m_Icon; // 0x20
		private bool m_Visible; // 0x40
		private Length m_Width; // 0x44
		private Length m_MinWidth; // 0x4C
		private Length m_MaxWidth; // 0x54
		private float m_DesiredWidth; // 0x5C
		private bool m_Stretchable; // 0x60
		private bool m_Sortable; // 0x61
		private bool m_Optional; // 0x62
		private bool m_Resizable; // 0x63
		private Func<VisualElement> m_MakeHeader; // 0x68
		private Action<VisualElement> m_BindHeader; // 0x70
		private Action<VisualElement> m_UnbindHeader; // 0x78
		private Action<VisualElement> m_DestroyHeader; // 0x80
		private Func<VisualElement> m_MakeCell; // 0x88
		private Action<VisualElement, int> m_BindCell; // 0x90
		private Action<VisualElement, int> m_UnbindCellItem; // 0x98
		private Action<VisualElement> _destroyCell_k__BackingField; // 0xA0
		private Columns _collection_k__BackingField; // 0xA8
		private Action<Column, ColumnDataType> changed; // 0xB0
		private Action<Column> resized; // 0xB8
	
		// Properties
		public string name { get => default; set {} } // 0x0000000185FB0650-0x0000000185FB0660 0x000000018C01FFF4-0x000000018C02000C
		public string title { get => default; set {} } // 0x0000000185FE9F00-0x0000000185FE9F10 0x000000018C02000C-0x000000018C020060
		public Background icon { get => default; } // 0x0000000185FB7D50-0x0000000185FB7D60 
		internal int index { get => default; } // 0x000000018C01FEC4-0x000000018C01FF04 
		internal int displayIndex { get => default; } // 0x0000000185FE9EF0-0x0000000185FE9F00 
		internal int visibleIndex { get => default; } // 0x000000018C01FE84-0x000000018C01FEC4 
		public bool visible { get => default; set {} } // 0x0000000185FB89D0-0x0000000185FB89E0 0x000000018C01FDB4-0x000000018C01FDE8
		public Length width { get => default; set {} } // 0x0000000185FB32C0-0x0000000185FB32D0 0x000000018C01FF7C-0x000000018C01FF94
		public Length minWidth { get => default; set {} } // 0x000000018386C570-0x000000018386C580 0x000000018C01FF94-0x000000018C01FFAC
		public Length maxWidth { get => default; set {} } // 0x0000000185FBCA50-0x0000000185FBCA60 0x000000018C01FF4C-0x000000018C01FF64
		internal float desiredWidth { get => default; set {} } // 0x0000000185FBCA40-0x0000000185FBCA50 0x000000018C01FF64-0x000000018C01FF7C
		public bool sortable { get => default; set {} } // 0x00000001813AC280-0x00000001813AC290 0x000000018C01FE3C-0x000000018C01FE84
		public bool stretchable { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x0000000183060C50-0x0000000183060C60
		public bool optional { get => default; set {} } // 0x000000018140CF50-0x000000018140CF60 0x0000000185FB0510-0x0000000185FB0520
		public bool resizable { get => default; set {} } // 0x000000018C01FDE8-0x000000018C01FE3C 0x0000000181B5FFD0-0x0000000181B5FFE0
		public Func<VisualElement> makeHeader { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x0000000185FB0520-0x0000000185FB0530
		public Action<VisualElement> bindHeader { get => default; } // 0x000000018349D730-0x000000018349D740 
		public Action<VisualElement> unbindHeader { get => default; } // 0x000000018774BD8C-0x000000018774BDA0 
		public Action<VisualElement> destroyHeader { get => default; } // 0x000000018C01FA50-0x000000018C01FAE0 
		public Func<VisualElement> makeCell { get => default; set {} } // 0x000000018C01FC94-0x000000018C01FD24 0x000000018C01FAE0-0x000000018C01FB70
		public Action<VisualElement, int> bindCell { get => default; } // 0x000000018C01FD24-0x000000018C01FDB4 
		public Action<VisualElement, int> unbindCell { get => default; } // 0x000000018C01F97C-0x000000018C01F99C 
		public Action<VisualElement> destroyCell { get; } // 0x000000018C01F954-0x000000018C01F97C 
		public Columns collection { get; internal set; } // 0x000000018C01F904-0x000000018C01F92C 0x000000018C01F92C-0x000000018C01F954
	
		// Events
		internal event Action<Column, ColumnDataType> changed;
		internal event Action<Column> resized;
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 44508
			where T : Column, new()
		{
			// Constructors
			public UxmlObjectFactory() {} // 0x000000018346D130-0x000000018346D140
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 44511
			where T : Column
		{
			// Fields
			private UxmlStringAttributeDescription m_Name;
			private UxmlStringAttributeDescription m_Text;
			private UxmlBoolAttributeDescription m_Visible;
			private UxmlStringAttributeDescription m_Width;
			private UxmlStringAttributeDescription m_MinWidth;
			private UxmlStringAttributeDescription m_MaxWidth;
			private UxmlBoolAttributeDescription m_Stretch;
			private UxmlBoolAttributeDescription m_Sortable;
			private UxmlBoolAttributeDescription m_Optional;
			private UxmlBoolAttributeDescription m_Resizable;
			private UxmlStringAttributeDescription m_HeaderTemplateId;
			private UxmlStringAttributeDescription m_CellTemplateId;
	
			// Nested types
			private sealed class __c__DisplayClass15_0 // TypeDefIndex: 44509
			{
				// Fields
				public VisualTreeAsset asset;
	
				// Constructors
				public __c__DisplayClass15_0() {} // 0x000000018C01FF04-0x000000018C01FF4C
	
				// Methods
				internal VisualElement _Init_b__0() => default; // 0x0000000181377E40-0x0000000181377E50
			}
	
			private sealed class __c__DisplayClass15_1 // TypeDefIndex: 44510
			{
				// Fields
				public VisualTreeAsset asset;
	
				// Constructors
				public __c__DisplayClass15_1() {} // 0x000000018C01FFAC-0x000000018C01FFF4
	
				// Methods
				internal VisualElement _Init_b__1() => default; // 0x0000000185FE9ED0-0x0000000185FE9EF0
			}
	
			// Constructors
			public UxmlObjectTraits() {} // 0x000000018C01FC18-0x000000018C01FC94
	
			// Methods
			private static Length ParseLength(string str, Length defaultValue) => default;
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C01FB70-0x000000018C01FBEC
		}
	
		// Constructors
		public Column() {}
		static Column() {}
	
		// Methods
		private void NotifyChange(ColumnDataType type) {}
		internal float GetWidth(float layoutWidth) => default;
		internal float GetMaxWidth(float layoutWidth) => default;
		internal float GetMinWidth(float layoutWidth) => default;
	}

	internal class ColumnLayout // TypeDefIndex: 44515
	{
		// Fields
		private List<Column> m_StretchableColumns; // 0x10
		private List<Column> m_FixedColumns; // 0x18
		private List<Column> m_RelativeWidthColumns; // 0x20
		private List<Column> m_MixedWidthColumns; // 0x28
		private Columns m_Columns; // 0x30
		private float m_ColumnsWidth; // 0x38
		private bool m_ColumnsWidthDirty; // 0x3C
		private float m_MaxColumnsWidth; // 0x40
		private float m_MinColumnsWidth; // 0x44
		private bool m_IsDirty; // 0x48
		private float m_PreviousWidth; // 0x4C
		private float m_LayoutWidth; // 0x50
		private bool m_DragResizeInPreviewMode; // 0x54
		private bool m_DragResizing; // 0x55
		private float m_DragStartPos; // 0x58
		private float m_DragLastPos; // 0x5C
		private float m_DragInitialColumnWidth; // 0x60
		private List<Column> m_DragStretchableColumns; // 0x68
		private List<Column> m_DragRelativeColumns; // 0x70
		private List<Column> m_DragFixedColumns; // 0x78
		private Dictionary<Column, float> m_PreviewDesiredWidths; // 0x80
		private Action layoutRequested; // 0x88
	
		// Properties
		public Columns columns { get => default; } // 0x0000000185FB0590-0x0000000185FB05A0 
		public float columnsWidth { get => default; } // 0x000000018C01F828-0x000000018C01F86C 
		public float layoutWidth { get => default; } // 0x000000018C01F7CC-0x000000018C01F828 
		public float minColumnsWidth { get => default; } // 0x000000018C01F5C8-0x000000018C01F660 
		public float maxColumnsWidth { get => default; } // 0x000000018C01F86C-0x000000018C01F904 
		public bool hasStretchableColumns { get => default; } // 0x000000018C01F2AC-0x000000018C01F5C8 
		public bool hasRelativeWidthColumns { get => default; } // 0x000000018C01C370-0x000000018C01C3A8 
	
		// Events
		public event Action layoutRequested;
	
		// Nested types
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 44513
		{
			// Fields
			public float totalColumnWidth; // 0x10
			public ColumnLayout __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass53_0() {} // 0x00000001813B51D0-0x00000001813B51E0
	
			// Methods
			internal void _RecomputeToMaxWidthProportionally_b__1(Column c) {} // 0x000000018C01F660-0x000000018C01F7CC
		}
	
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 44514
		{
			// Fields
			public float totalColumnsWidth; // 0x10
			public ColumnLayout __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass54_0() {} // 0x0000000185FB3000-0x0000000185FB3010
	
			// Methods
			internal void _RecomputeToMinWidthProportionally_b__1(Column c) {} // 0x0000000185FB05A0-0x0000000185FB05B0
		}
	
		// Constructors
		public ColumnLayout() {} // Dummy constructor
		public ColumnLayout(Columns columns) {} // 0x000000018C01DC74-0x000000018C01DC7C
	
		// Methods
		public void Dirty() {} // 0x000000018C01E868-0x000000018C01E880
		private void OnColumnAdded(Column column, int index) {} // 0x000000018C01DB5C-0x000000018C01DB8C
		private void OnColumnRemoved(Column column) {} // 0x0000000185FE9EC0-0x0000000185FE9ED0
		private void OnColumnReordered(Column column, int from, int to) {} // 0x000000018C01DA64-0x000000018C01DA74
		private bool RequiresLayoutUpdate(ColumnDataType type) => default; // 0x000000018C01C6CC-0x000000018C01D3D0
		private void OnColumnChanged(Column column, ColumnDataType type) {} // 0x000000018C01ED30-0x000000018C01EDF0
		private void OnColumnResized(Column column) {} // 0x000000018C01C50C-0x000000018C01C6CC
		private static bool IsClamped(float value, float min, float max) => default; // 0x000000018C01C3A8-0x000000018C01C50C
		public void DoLayout(float width) {} // 0x000000018C01DF7C-0x000000018C01E250
		public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) {} // 0x000000018C01E3EC-0x000000018C01E6D4
		private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) {} // 0x000000018C01DE68-0x000000018C01DF7C
		private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) {} // 0x000000018C01DC7C-0x000000018C01DE68
		private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x0205B60E */) => default; // 0x000000018C01E6D4-0x000000018C01E868
		private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x0205B60F */) => default; // 0x000000018C01E250-0x000000018C01E3EC
		private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) => default; // 0x000000018C01E970-0x000000018C01ED30
		private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) => default; // 0x000000018C01E880-0x000000018C01E970
		private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x0205B610 */) => default; // 0x000000018C01C044-0x000000018C01C2F4
		private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x0205B611 */) => default; // 0x000000018C01D910-0x000000018C01D9CC
		public void ResizeToFit(float width) {} // 0x000000018C01D9CC-0x000000018C01DA64
		private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false /* Metadata: 0x0205B612 */) {} // 0x000000018C01D3D0-0x000000018C01D6F4
		internal void BeginDragResize(Column column, float pos, bool previewMode) {} // 0x000000018C01D6F4-0x000000018C01D910
		public float GetDesiredPosition(Column column) => default; // 0x000000018C01EEB8-0x000000018C01F130
		public float GetDesiredWidth(Column c) => default; // 0x000000018C01F130-0x000000018C01F2AC
		public void DragResize(Column column, float pos) {} // 0x000000018C01C2F4-0x000000018C01C370
		internal void EndDragResize(Column column, bool cancelled) {} // 0x000000018C01EDF0-0x000000018C01EE54
		private void UpdateCache() {} // 0x000000018C01EDF0-0x000000018C01EE54
		private void UpdateMinAndMaxColumnsWidth() {} // 0x000000018C01EDF0-0x000000018C01EE54
		private void ClearCache() {} // 0x000000018C01EE54-0x000000018C01EEB8
		private int _DoLayout_b__49_0(Column c1, Column c2) => default; // 0x0000000185492010-0x0000000185492020
		private int _DoLayout_b__49_1(Column c1, Column c2) => default; // 0x000000018C02CB9C-0x000000018C02CBDC
		private int _RecomputeToMaxWidthProportionally_b__53_0(Column c1, Column c2) => default; // 0x0000000185492010-0x0000000185492020
		private int _RecomputeToMinWidthProportionally_b__54_0(Column c1, Column c2) => default; // 0x000000018C02CB9C-0x000000018C02CBDC
	}

	internal enum ColumnsDataType // TypeDefIndex: 44516
	{
		PrimaryColumn = 0,
		StretchMode = 1,
		Reorderable = 2,
		Resizable = 3,
		ResizePreview = 4
	}

	public class Columns : ICollection<Column> // TypeDefIndex: 44521
	{
		// Fields
		private IList<Column> m_Columns; // 0x10
		private List<Column> m_DisplayColumns; // 0x18
		private List<Column> m_VisibleColumns; // 0x20
		private bool m_VisibleColumnsDirty; // 0x28
		private StretchMode m_StretchMode; // 0x2C
		private bool m_Reorderable; // 0x30
		private bool m_Resizable; // 0x31
		private bool m_ResizePreview; // 0x32
		private string m_PrimaryColumnName; // 0x38
		private Action<ColumnsDataType> changed; // 0x40
		private Action<Column, int> columnAdded; // 0x48
		private Action<Column> columnRemoved; // 0x50
		private Action<Column, ColumnDataType> columnChanged; // 0x58
		private Action<Column> columnResized; // 0x60
		private Action<Column, int, int> columnReordered; // 0x68
	
		// Properties
		public string primaryColumnName { get => default; set {} } // 0x0000000185FB0C40-0x0000000185FB0C50 0x000000018C0216A0-0x000000018C0216B8
		public bool reorderable { get => default; set {} } // 0x000000018C0212A8-0x000000018C0212C4 0x000000018C0212C4-0x000000018C0212E0
		public bool resizable { get => default; set {} } // 0x000000018C020D30-0x000000018C020DBC 0x000000018C0212E0-0x000000018C02136C
		public bool resizePreview { get => default; set {} } // 0x0000000185FB0630-0x0000000185FB0640 0x000000018C0216B8-0x000000018C0216D0
		internal IEnumerable<Column> displayList { get => default; } // 0x000000018C020DBC-0x000000018C020E48 
		internal IEnumerable<Column> visibleList { get => default; } // 0x000000018C02136C-0x000000018C0213F8 
		public StretchMode stretchMode { get => default; set {} } // 0x000000018C020E48-0x000000018C020ED4 0x000000018C0213F8-0x000000018C021484
		public int Count { get => default; } // 0x000000018C0209C4-0x000000018C020AB8 
		public bool IsReadOnly { get => default; } // 0x000000018C020450-0x000000018C0204D0 
		public Column this[int index] { get => default; } // 0x000000018C02077C-0x000000018C020790 
		public Column this[string name] { get => default; } // 0x000000018C020CA8-0x000000018C020D30 
	
		// Events
		internal event Action<ColumnsDataType> changed;
		internal event Action<Column, int> columnAdded;
		internal event Action<Column> columnRemoved;
		internal event Action<Column, ColumnDataType> columnChanged;
		internal event Action<Column> columnResized;
		internal event Action<Column, int, int> columnReordered;
	
		// Nested types
		public enum StretchMode // TypeDefIndex: 44517
		{
			Grow = 0,
			GrowAndFill = 1
		}
	
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 44518
			where T : Columns, new()
		{
			// Constructors
			public UxmlObjectFactory() {} // 0x00000001813ECBC0-0x00000001813ECBD0
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 44519
			where T : Columns
		{
			// Fields
			private readonly UxmlStringAttributeDescription m_PrimaryColumnName;
			private readonly UxmlEnumAttributeDescription<StretchMode> m_StretchMode;
			private readonly UxmlBoolAttributeDescription m_Reorderable;
			private readonly UxmlBoolAttributeDescription m_Resizable;
			private readonly UxmlBoolAttributeDescription m_ResizePreview;
			private readonly UxmlObjectListAttributeDescription<Column> m_Columns;
	
			// Constructors
			public UxmlObjectTraits() {} // 0x00000001814294C0-0x00000001814294D0
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C021628-0x000000018C021670
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 44520
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Column> __9__76_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018C021670-0x000000018C021688
			public __c() {} // 0x0000000185FB0980-0x0000000185FB0990
	
			// Methods
			internal bool _UpdateVisibleColumns_b__76_0(Column c) => default; // 0x000000018C021688-0x000000018C0216A0
		}
	
		// Constructors
		public Columns() {} // 0x000000018C02CB84-0x000000018C02CB9C
	
		// Methods
		public bool IsPrimary(Column column) => default; // 0x000000018C020164-0x000000018C0202BC
		public IEnumerator<Column> GetEnumerator() => default; // 0x000000018C020310-0x000000018C020370
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0207F0-0x000000018C0209C4
		public void Add(Column item) {} // 0x000000018C020790-0x000000018C0207DC
		public void Clear() {} // 0x000000018C0207DC-0x000000018C0207F0
		public bool Contains(Column item) => default; // 0x000000018C021078-0x000000018C0210C0
		public bool Contains(string name) => default; // 0x000000018C0210C0-0x000000018C02110C
		public void CopyTo(Column[] array, int arrayIndex) {} // 0x000000018C020400-0x000000018C020450
		public bool Remove(Column column) => default; // 0x000000018C0204D0-0x000000018C020710
		private void OnColumnChanged(Column column, ColumnDataType type) {} // 0x000000018C02110C-0x000000018C021160
		private void OnColumnResized(Column column) {} // 0x000000018C021160-0x000000018C0212A8
		public int IndexOf(Column column) => default; // 0x000000018C020370-0x000000018C0203B8
		public void Insert(int index, Column column) {} // 0x000000018C020AC4-0x000000018C020CA8
		public void ReorderDisplay(int from, int to) {}
		private void InitOrderColumns() {}
		private void DirtyVisibleColumns() {}
		private void UpdateVisibleColumns() {} // 0x000000018C02CBDC-0x000000018C02CC40
		private void NotifyChange(ColumnsDataType type) {} // 0x0000000185492010-0x0000000185492020
	}

	public class MultiColumnController : IDisposable // TypeDefIndex: 44522
	{
		// Fields
		private static readonly PropertyName k_BoundColumnVePropertyName; // 0x00
		internal static readonly PropertyName bindableElementPropertyName; // 0x04
		internal static readonly string baseUssClassName; // 0x08
		private static readonly string k_HeaderContainerViewDataKey; // 0x10
		public static readonly string headerContainerUssClassName; // 0x18
		public static readonly string rowContainerUssClassName; // 0x20
		public static readonly string cellUssClassName; // 0x28
		public static readonly string cellLabelUssClassName; // 0x30
		private static readonly string k_HeaderViewDataKey; // 0x38
		private Action columnSortingChanged; // 0x10
		private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x18
		private BaseVerticalCollectionView m_View; // 0x20
		private VisualElement m_HeaderContainer; // 0x28
		private MultiColumnCollectionHeader m_MultiColumnHeader; // 0x30
	
		// Properties
		internal MultiColumnCollectionHeader header { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
	
		// Events
		public event Action columnSortingChanged;
		public event Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent;
	
		// Constructors
		public MultiColumnController() {} // Dummy constructor
		public MultiColumnController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {} // 0x000000018C026F94-0x000000018C027400
		static MultiColumnController() {} // 0x000000018C026CF0-0x000000018C026F94
	
		// Methods
		private static void BindCellItem<T>(VisualElement ve, int rowIndex, Column column, T item) {}
		private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column) {} // 0x000000018C0269D8-0x000000018C026A0C
		private static VisualElement DefaultMakeCellItem() => default; // 0x000000018C025760-0x000000018C0257E4
		private static void DefaultBindCellItem<T>(VisualElement ve, Column column, T item) {}
		public VisualElement MakeItem() => default; // 0x000000018C025FCC-0x000000018C0262C4
		public void BindItem<T>(VisualElement element, int index, T item) {}
		public void UnbindItem(VisualElement element, int index) {} // 0x000000018C026A0C-0x000000018C026C18
		public void DestroyItem(VisualElement element) {} // 0x000000018C0257E4-0x000000018C025A14
		public void PrepareView(BaseVerticalCollectionView collectionView) {} // 0x000000018C0266D4-0x000000018C0269D8
		public void Dispose() {} // 0x000000018C025A14-0x000000018C025FCC
		private void OnHorizontalScrollerValueChanged(float v) {} // 0x000000018C026588-0x000000018C0265A8
		private void OnViewportGeometryChanged(GeometryChangedEvent evt) {} // 0x000000018C0265A8-0x000000018C0266D4
		private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt) {} // 0x000000018C02631C-0x000000018C026328
		private void UpdateContentContainer(BaseVerticalCollectionView collectionView) {} // 0x000000018C026C18-0x000000018C026CF0
		private void OnColumnSortingChanged() {} // 0x00000001830EEE80-0x00000001830EEE90
		private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column) {} // 0x000000018C026574-0x000000018C026588
		private void OnColumnResized(int index, float width) {} // 0x000000018C026360-0x000000018C02653C
		private void OnColumnAdded(Column column, int index) {} // 0x000000018C0262C4-0x000000018C0262E4
		private void OnColumnRemoved(Column column) {} // 0x000000018C0262C4-0x000000018C0262E4
		private void OnColumnReordered(Column column, int from, int to) {} // 0x000000018C026328-0x000000018C026360
		private void OnColumnsChanged(Column column, ColumnDataType type) {} // 0x000000018C02653C-0x000000018C026574
		private void OnColumnChanged(ColumnsDataType type) {} // 0x000000018C0262E4-0x000000018C02631C
		private void OnViewDataRestored() {} // 0x000000018C0262C4-0x000000018C0262E4
	}

	public class MultiColumnListView : BaseListView // TypeDefIndex: 44525
	{
		// Fields
		private Columns m_Columns; // 0x538
		private bool m_SortingEnabled; // 0x540
		private SortColumnDescriptions m_SortColumnDescriptions; // 0x548
		private List<SortColumnDescription> m_SortedColumns; // 0x550
		private Action columnSortingChanged; // 0x558
		private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x560
	
		// Properties
		public new MultiColumnListViewController viewController { get => default; } // 0x0000000185FCD780-0x0000000185FCD790 
		public Columns columns { get => default; private set {} } // 0x000000018C027BDC-0x000000018C027C70 0x000000018C027C70-0x000000018C027CD0
		public SortColumnDescriptions sortColumnDescriptions { get => default; private set {} } // 0x000000018C027ACC-0x000000018C027B34 0x000000018C027978-0x000000018C027ACC
		public bool sortingEnabled { set {} } // 0x000000018C027640-0x000000018C0276D4
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits> // TypeDefIndex: 44523
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C027B34-0x000000018C027B78
		}
	
		public class UxmlTraits : BaseListView.UxmlTraits // TypeDefIndex: 44524
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xD8
			private readonly UxmlObjectAttributeDescription<Columns> m_Columns; // 0xE0
			private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; // 0xE8
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C027B78-0x000000018C027BDC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000185FCD750-0x0000000185FCD760
		}
	
		// Constructors
		public MultiColumnListView() {} // 0x000000018C02773C-0x000000018C027978
		public MultiColumnListView(Columns columns) {} // 0x000000018C0276D4-0x000000018C027710
	
		// Methods
		protected override CollectionViewController CreateViewController() => default; // 0x000000018C027710-0x000000018C027724
		public override void SetViewController(CollectionViewController controller) {} // 0x000000018C027724-0x000000018C02773C
		private protected override void CreateVirtualizationController() {} // 0x000000018C02CCF4-0x000000018C02CD30
		private void RaiseColumnSortingChanged() {} // 0x000000018C02D118-0x000000018C02D260
		private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) {} // 0x000000018C02D998-0x000000018C02DAA8
	}

	public class MultiColumnTreeView : BaseTreeView // TypeDefIndex: 44528
	{
		// Fields
		private Columns m_Columns; // 0x4B8
		private bool m_SortingEnabled; // 0x4C0
		private SortColumnDescriptions m_SortColumnDescriptions; // 0x4C8
		private List<SortColumnDescription> m_SortedColumns; // 0x4D0
		private Action columnSortingChanged; // 0x4D8
		private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x4E0
	
		// Properties
		public new MultiColumnTreeViewController viewController { get => default; } // 0x0000000185FB8710-0x0000000185FB8720 
		public Columns columns { get => default; private set {} } // 0x000000018C028278-0x000000018C02830C 0x000000018C02830C-0x000000018C02836C
		public SortColumnDescriptions sortColumnDescriptions { get => default; private set {} } // 0x000000018C028168-0x000000018C0281D0 0x000000018C028014-0x000000018C028168
		public bool sortingEnabled { set {} } // 0x000000018C027CD0-0x000000018C027D70
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MultiColumnTreeView, UxmlTraits> // TypeDefIndex: 44526
		{
			// Constructors
			public UxmlFactory() {} // 0x000000018C0281D0-0x000000018C028214
		}
	
		public class UxmlTraits : BaseTreeView.UxmlTraits // TypeDefIndex: 44527
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xB8
			private readonly UxmlObjectAttributeDescription<Columns> m_Columns; // 0xC0
			private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; // 0xC8
	
			// Constructors
			public UxmlTraits() {} // 0x000000018C028214-0x000000018C028278
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000185FB8750-0x0000000185FB8760
		}
	
		// Constructors
		public MultiColumnTreeView() {} // 0x000000018C027DD8-0x000000018C028014
		public MultiColumnTreeView(Columns columns) {} // 0x000000018C027D70-0x000000018C027DAC
	
		// Methods
		protected override CollectionViewController CreateViewController() => default; // 0x000000018C027DAC-0x000000018C027DC0
		public override void SetViewController(CollectionViewController controller) {} // 0x000000018C027DC0-0x000000018C027DD8
		private protected override void CreateVirtualizationController() {} // 0x000000018C02CDA8-0x000000018C02CDE4
		private void RaiseColumnSortingChanged() {} // 0x000000018C02D538-0x000000018C02D680
		private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) {} // 0x000000018C02DAA8-0x000000018C02DBB8
	}

	public enum SortDirection // TypeDefIndex: 44529
	{
		Ascending = 0,
		Descending = 1
	}

	[Serializable]
	public class SortColumnDescription // TypeDefIndex: 44532
	{
		// Fields
		private int m_ColumnIndex; // 0x10
		private string m_ColumnName; // 0x18
		private SortDirection m_SortDirection; // 0x20
		private Column _column_k__BackingField; // 0x28
		private Action<SortColumnDescription> changed; // 0x30
	
		// Properties
		public string columnName { get => default; set {} } // 0x000000018C028534-0x000000018C02855C 0x00000001813B8590-0x00000001813B85A0
		public int columnIndex { get => default; set {} } // 0x0000000184A4EDC0-0x0000000184A4EDD0 0x00000001813B88B0-0x00000001813B88C0
		public Column column { get; internal set; } // 0x000000018C0285A8-0x000000018C0285D0 0x000000018C02841C-0x000000018C0284A8
		public SortDirection direction { get => default; set {} } // 0x000000018C0284A8-0x000000018C028534 0x00000001834A6020-0x00000001834A6030
	
		// Events
		internal event Action<SortColumnDescription> changed;
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 44530
			where T : SortColumnDescription, new()
		{
			// Constructors
			public UxmlObjectFactory() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 44531
			where T : SortColumnDescription
		{
			// Fields
			private readonly UxmlStringAttributeDescription m_ColumnName;
			private readonly UxmlIntAttributeDescription m_ColumnIndex;
			private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription;
	
			// Constructors
			public UxmlObjectTraits() {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C02855C-0x000000018C0285A8
		}
	
		// Constructors
		public SortColumnDescription() {}
		public SortColumnDescription(int columnIndex, SortDirection direction) {}
		public SortColumnDescription(string columnName, SortDirection direction) {}
	}

	[Serializable]
	public class SortColumnDescriptions : ICollection<SortColumnDescription> // TypeDefIndex: 44535
	{
		// Fields
		private readonly IList<SortColumnDescription> m_Descriptions; // 0x10
		private Action changed; // 0x18
	
		// Properties
		public int Count { get => default; } // 0x000000018C028A68-0x000000018C028AE0 
		public bool IsReadOnly { get => default; }
	
		// Events
		internal event Action changed;
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 44533
			where T : SortColumnDescriptions, new()
		{
			// Constructors
			public UxmlObjectFactory() {} // 0x000000018C028AE0-0x000000018C028B74
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 44534
			where T : SortColumnDescriptions
		{
			// Fields
			private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions;
	
			// Constructors
			public UxmlObjectTraits() {} // 0x000000018C028760-0x000000018C0287A8
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018C028C08-0x000000018C028C9C
		}
	
		// Constructors
		public SortColumnDescriptions() {}
	
		// Methods
		public IEnumerator<SortColumnDescription> GetEnumerator() => default; // 0x000000018C028634-0x000000018C0286AC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0286AC-0x000000018C028700
		public void Add(SortColumnDescription item) {} // 0x000000018C028700-0x000000018C028760
		public void Clear() {} // 0x000000018C028924-0x000000018C028A5C
		public bool Contains(SortColumnDescription item) => default; // 0x00000001899FDB7C-0x00000001899FDB8C
		public void CopyTo(SortColumnDescription[] array, int arrayIndex) {} // 0x000000018C028B74-0x000000018C028BBC
		public bool Remove(SortColumnDescription desc) => default; // 0x000000018C028BBC-0x000000018C028C08
		private void OnDescriptionChanged(SortColumnDescription desc) {} // 0x000000018C0287A8-0x000000018C028924
		public void Insert(int index, SortColumnDescription desc) {}
	}

	internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController // TypeDefIndex: 44536
	{
		// Fields
		protected readonly BaseVerticalCollectionView m_View; // 0x10
		protected List<int> m_SortedSelectedIds; // 0x18
		private bool _enableReordering_k__BackingField; // 0x20
	
		// Properties
		public virtual bool enableReordering { get; set; } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
	
		// Constructors
		protected BaseReorderableDragAndDropController() {} // Dummy constructor
		public BaseReorderableDragAndDropController(BaseVerticalCollectionView view) {} // 0x000000018C01BFB0-0x000000018C01C044
	
		// Methods
		public IEnumerable<int> GetSortedSelectedIds() => default; // 0x0000000181377E40-0x0000000181377E50
		public virtual bool CanStartDrag(IEnumerable<int> itemIndices) => default; // 0x0000000185FE9EB0-0x0000000185FE9EC0
		public virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false /* Metadata: 0x0205B61C */) => default; // 0x000000018C01BC44-0x000000018C01BFB0
		protected virtual int CompareId(int id1, int id2) => default; // 0x000000018C01BC24-0x000000018C01BC44
		public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args);
		public abstract void OnDrop(IListDragAndDropArgs args);
		public virtual void DragCleanup() {} // 0x0000000185492010-0x0000000185492020
		public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class DragAndDropUtility // TypeDefIndex: 44537
	{
		// Fields
		private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc; // 0x00
		private static IDragAndDrop s_DragAndDropEditor; // 0x08
		private static IDragAndDrop s_DragAndDropPlayMode; // 0x10
	
		// Methods
		internal static IDragAndDrop GetDragAndDrop(IPanel panel) => default; // 0x000000018C021D08-0x000000018C021E34
	}

	internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop // TypeDefIndex: 44538
	{
		// Fields
		private readonly Hashtable m_GenericData; // 0x10
		private UnityEngine.UIElements.Label m_DraggedInfoLabel; // 0x18
		private DragVisualMode m_VisualMode; // 0x20
		private IEnumerable<UnityEngine.Object> m_UnityObjectReferences; // 0x28
	
		// Properties
		public override object source { get => default; } // 0x000000018C021CC8-0x000000018C021D08 
		public DragAndDropData data { get => default; } // 0x0000000185779060-0x0000000185779070 
	
		// Constructors
		public DefaultDragAndDropClient() {} // 0x000000018C021C64-0x000000018C021CC8
	
		// Methods
		public override object GetGenericData(string key) => default; // 0x000000018C021714-0x000000018C021774
		public void StartDrag(StartDragArgs args, Vector3 pointerPosition) {} // 0x000000018C021774-0x000000018C021BA4
		public void UpdateDrag(Vector3 pointerPosition) {} // 0x000000018C021BA4-0x000000018C021C64
		public void AcceptDrag() {} // 0x0000000185492010-0x0000000185492020
		public void SetVisualMode(DragVisualMode mode) {} // 0x00000001813B9430-0x00000001813B9440
		public void DragCleanup() {} // 0x000000018C0216D0-0x000000018C021714
	}

	internal abstract class DragEventsProcessor // TypeDefIndex: 44540
	{
		// Fields
		private bool m_IsRegistered; // 0x10
		internal DragState m_DragState; // 0x14
		private Vector3 m_Start; // 0x18
		internal readonly VisualElement m_Target; // 0x28
	
		// Properties
		protected virtual bool supportsDragEvents { get; } // 0x00000001840A27C0-0x00000001840A27D0 
		internal bool useDragEvents { get; } // 0x000000018C022DC8-0x000000018C022DF8 
		protected IDragAndDrop dragAndDrop { get; } // 0x000000018C022CFC-0x000000018C022D24 
		internal virtual bool isEditorContext { get; } // 0x000000018C022D24-0x000000018C022DC8 
	
		// Nested types
		internal enum DragState // TypeDefIndex: 44539
		{
			None = 0,
			CanStartDrag = 1,
			Dragging = 2
		}
	
		// Constructors
		protected DragEventsProcessor() {} // Dummy constructor
		internal DragEventsProcessor(VisualElement target) {} // 0x000000018C022BD0-0x000000018C022CFC
	
		// Methods
		private void RegisterCallbacksFromTarget(AttachToPanelEvent evt) {} // 0x000000018C0227D4-0x000000018C0227DC
		private void RegisterCallbacksFromTarget() {} // 0x000000018C0224DC-0x000000018C0227D4
		private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) {} // 0x000000018C022BC4-0x000000018C022BD0
		internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false /* Metadata: 0x0205B61D */) {} // 0x000000018C0227DC-0x000000018C022BC4
		protected abstract bool CanStartDrag(Vector3 pointerPosition);
		protected internal abstract StartDragArgs StartDrag(Vector3 pointerPosition);
		protected internal abstract void UpdateDrag(Vector3 pointerPosition);
		protected internal abstract void OnDrop(Vector3 pointerPosition);
		protected abstract void ClearDragAndDropUI(bool dragCancelled);
		private void OnPointerDownEvent(PointerDownEvent evt) {} // 0x000000018C022014-0x000000018C0220E8
		internal void OnPointerUpEvent(PointerUpEvent evt) {} // 0x000000018C022370-0x000000018C0224DC
		private void OnPointerLeaveEvent(PointerLeaveEvent evt) {} // 0x000000018C0220E8-0x000000018C0220F8
		private void OnPointerCancelEvent(PointerCancelEvent evt) {} // 0x000000018C021F10-0x000000018C021FB4
		private void OnPointerCapturedOut(PointerCaptureOutEvent evt) {} // 0x000000018C021FB4-0x000000018C022014
		private void OnPointerMoveEvent(PointerMoveEvent evt) {} // 0x000000018C0220F8-0x000000018C022370
		private DragEventsProcessor GetDropTarget(Vector2 position) => default; // 0x000000018C021E34-0x000000018C021F10
	}

	internal interface ICollectionDragAndDropController : IDragAndDropController<IListDragAndDropArgs>, IReorderable // TypeDefIndex: 44541
	{
	}

	internal interface IDragAndDrop // TypeDefIndex: 44542
	{
		// Properties
		DragAndDropData data { get; }
	
		// Methods
		void StartDrag(StartDragArgs args, Vector3 pointerPosition);
		void UpdateDrag(Vector3 pointerPosition);
		void AcceptDrag();
		void DragCleanup();
		void SetVisualMode(DragVisualMode visualMode);
	}

	internal abstract class DragAndDropData // TypeDefIndex: 44543
	{
		// Properties
		public abstract object source { get; }
	
		// Constructors
		protected DragAndDropData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract object GetGenericData(string key);
	}

	internal interface IDragAndDropController<in TArgs> // TypeDefIndex: 44544
	{
		// Methods
		bool CanStartDrag(IEnumerable<int> itemIndices);
		StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIndices, bool skipText = false /* Metadata: 0x0205B621 */);
		DragVisualMode HandleDragAndDrop(TArgs args);
		void OnDrop(TArgs args);
		void DragCleanup();
		void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition);
		IEnumerable<int> GetSortedSelectedIds();
	}

	internal enum DragVisualMode // TypeDefIndex: 44545
	{
		None = 0,
		Copy = 1,
		Move = 2,
		Rejected = 3
	}

	internal struct CanStartDragArgs // TypeDefIndex: 44546
	{
		// Fields
		public readonly VisualElement draggedElement; // 0x00
		public readonly int id; // 0x08
		public readonly IEnumerable<int> selectedIds; // 0x10
	
		// Constructors
		internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<int> selectedIds) {
			this.draggedElement = default;
			this.id = default;
			this.selectedIds = default;
		} // 0x000000018A0790E0-0x000000018A079108
	}

	internal struct SetupDragAndDropArgs // TypeDefIndex: 44547
	{
		// Fields
		public readonly VisualElement draggedElement; // 0x00
		public readonly IEnumerable<int> selectedIds; // 0x08
		public readonly StartDragArgs startDragArgs; // 0x10
	
		// Constructors
		internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<int> selectedIds, StartDragArgs startDragArgs) {
			this.draggedElement = default;
			this.selectedIds = default;
			this.startDragArgs = default;
		} // 0x000000018C02836C-0x000000018C0283AC
	}

	internal struct HandleDragAndDropArgs // TypeDefIndex: 44548
	{
		// Fields
		private readonly DragAndDropArgs m_DragAndDropArgs; // 0x00
		private readonly Vector2 _position_k__BackingField; // 0x20
	
		// Constructors
		internal HandleDragAndDropArgs(Vector2 position, DragAndDropArgs dragAndDropArgs) {
			m_DragAndDropArgs = default;
			<position>k__BackingField = default;
		} // 0x000000018C022DF8-0x000000018C022E14
	}

	internal struct StartDragArgs // TypeDefIndex: 44549
	{
		// Fields
		private readonly string _title_k__BackingField; // 0x00
		private readonly DragVisualMode _visualMode_k__BackingField; // 0x08
		private Hashtable _genericData_k__BackingField; // 0x10
		private IEnumerable<UnityEngine.Object> _unityObjectReferences_k__BackingField; // 0x18
	
		// Properties
		public string title { get; } // 0x00000001834AFB60-0x00000001834AFB70 
		public DragVisualMode visualMode { get; } // 0x0000000181B7E450-0x0000000181B7E460 
		internal Hashtable genericData { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		internal IEnumerable<UnityEngine.Object> unityObjectReferences { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public StartDragArgs(string title, DragVisualMode visualMode) : this() {
			<title>k__BackingField = default;
			<visualMode>k__BackingField = default;
			<genericData>k__BackingField = default;
			<unityObjectReferences>k__BackingField = default;
		} // 0x000000018C028D3C-0x000000018C028D74
	
		// Methods
		public void SetGenericData(string key, object data) {} // 0x000000018C028C9C-0x000000018C028D3C
	}

	internal interface IListDragAndDropArgs // TypeDefIndex: 44550
	{
		// Properties
		int insertAtIndex { get; }
		int parentId { get; }
		int childIndex { get; }
		DragAndDropData dragAndDropData { get; }
		DragAndDropPosition dragAndDropPosition { get; }
	}

	internal struct DragAndDropArgs : IListDragAndDropArgs // TypeDefIndex: 44551
	{
		// Fields
		private object _target_k__BackingField; // 0x00
		private int _insertAtIndex_k__BackingField; // 0x08
		private int _parentId_k__BackingField; // 0x0C
		private int _childIndex_k__BackingField; // 0x10
		private DragAndDropPosition _dragAndDropPosition_k__BackingField; // 0x14
		private DragAndDropData _dragAndDropData_k__BackingField; // 0x18
	
		// Properties
		public object target { get; set; } // 0x000000018646FE2C-0x000000018646FE34
		public int insertAtIndex { get; set; } // 0x0000000181B7E450-0x0000000181B7E460 0x0000000185FB2B90-0x0000000185FB2BA0
		public int parentId { get; set; } // 0x00000001834AFB70-0x00000001834AFB80 0x0000000185FB6960-0x0000000185FB6970
		public int childIndex { get; set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public DragAndDropPosition dragAndDropPosition { get; set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public DragAndDropData dragAndDropData { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	}

	internal enum DragAndDropPosition // TypeDefIndex: 44552
	{
		OverItem = 0,
		BetweenItems = 1,
		OutsideItems = 2
	}

	internal interface IReorderable // TypeDefIndex: 44553
	{
		// Properties
		bool enableReordering { get; set; }
	}

	internal class ListViewDragger : DragEventsProcessor // TypeDefIndex: 44555
	{
		// Fields
		private DragPosition m_LastDragPosition; // 0x30
		private VisualElement m_DragHoverBar; // 0x50
		private VisualElement m_DragHoverItemMarker; // 0x58
		private VisualElement m_DragHoverSiblingMarker; // 0x60
		private float m_LeftIndentation; // 0x68
		private float m_SiblingBottom; // 0x6C
		private ICollectionDragAndDropController _dragAndDropController_k__BackingField; // 0x70
	
		// Properties
		protected BaseVerticalCollectionView targetView { get => default; } // 0x00000001874BE90C-0x00000001874BE91C 
		protected ScrollView targetScrollView { get => default; } // 0x000000018C0256E8-0x000000018C025700 
		public ICollectionDragAndDropController dragAndDropController { get; set; } // 0x000000018C023440-0x000000018C0236BC 0x000000018C024F0C-0x000000018C025160
	
		// Nested types
		internal struct DragPosition : IEquatable<DragPosition> // TypeDefIndex: 44554
		{
			// Fields
			public int insertAtIndex; // 0x00
			public int parentId; // 0x04
			public int childIndex; // 0x08
			public ReusableCollectionItem recycledItem; // 0x10
			public DragAndDropPosition dropPosition; // 0x18
	
			// Methods
			public bool Equals(DragPosition other) => default; // 0x000000018C025724-0x000000018C025760
			public override bool Equals(object obj) => default; // 0x000000018C025700-0x000000018C025724
			public override int GetHashCode() => default; // 0x0000000181460F70-0x0000000181460F80
		}
	
		// Constructors
		public ListViewDragger() {} // Dummy constructor
		public ListViewDragger(BaseVerticalCollectionView listView) {} // 0x000000018C025524-0x000000018C0256E8
	
		// Methods
		protected override bool CanStartDrag(Vector3 pointerPosition) => default; // 0x000000018C023DD4-0x000000018C023F44
		protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) => default; // 0x000000018C02496C-0x000000018C024B58
		protected internal override void UpdateDrag(Vector3 pointerPosition) {} // 0x000000018C023FD0-0x000000018C0241AC
		private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref DragPosition dragPosition) => default; // 0x000000018C023F44-0x000000018C023FD0
		protected internal override void OnDrop(Vector3 pointerPosition) {} // 0x000000018C022E14-0x000000018C023440
		internal void HandleDragAndScroll(Vector2 pointerPosition) {} // 0x000000018C025160-0x000000018C02549C
		private void HandleAutoExpansion(Vector2 pointerPosition) {} // 0x000000018C024744-0x000000018C024814
		private void ApplyDragAndDropUI(DragPosition dragPosition) {} // 0x000000018C0241AC-0x000000018C024744
		protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) => default; // 0x000000018C023A80-0x000000018C023C00
		private void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition) {} // 0x000000018C024814-0x000000018C02496C
		private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition) {} // 0x000000018C0239AC-0x000000018C023A80
		private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId) {
			previousItemId = default;
			nextItemId = default;
		} // 0x000000018C024B58-0x000000018C024B90
		protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition) => default; // 0x000000018C024B90-0x000000018C024F0C
		private float GetHoverBarTopPosition(ReusableCollectionItem item) => default; // 0x000000018C0236BC-0x000000018C0239AC
		private void PlaceHoverBarAtElement(ReusableCollectionItem item) {} // 0x000000018C023C00-0x000000018C023DD4
		private void PlaceHoverBarAt(float top, float indentationPadding = -1f /* Metadata: 0x0205B629 */, float siblingBottom = -1f /* Metadata: 0x0205B62D */) {} // 0x000000018C02549C-0x000000018C025524
		protected override void ClearDragAndDropUI(bool dragCancelled) {} // 0x000000018C02F004-0x000000018C02F068
		protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) => default; // 0x000000018C02EF84-0x000000018C02F004
		private void _ApplyDragAndDropUI_g__GeometryChangedCallback_27_0(GeometryChangedEvent e) {} // 0x000000018C02F068-0x000000018C02F0D8
	}

	internal static class ListViewDraggerExtension // TypeDefIndex: 44556
	{
		// Methods
		public static ReusableCollectionItem GetRecycledItemFromId(BaseVerticalCollectionView listView, int id) => default; // 0x000000018C034290-0x000000018C0343E0
		public static ReusableCollectionItem GetRecycledItemFromIndex(BaseVerticalCollectionView listView, int index) => default; // 0x000000018C0343E0-0x000000018C034530
	}

	internal class ListViewDraggerAnimated : ListViewDragger // TypeDefIndex: 44557
	{
		// Fields
		private int m_DragStartIndex; // 0x78
		private int m_CurrentIndex; // 0x7C
		private float m_SelectionHeight; // 0x80
		private float m_LocalOffsetOnStart; // 0x84
		private Vector3 m_CurrentPointerPosition; // 0x88
		private ReusableCollectionItem m_Item; // 0x98
		private ReusableCollectionItem m_OffsetItem; // 0xA0
		private bool _isDragging_k__BackingField; // 0xA8
	
		// Properties
		public bool isDragging { get; private set; } // 0x0000000185FB8C10-0x0000000185FB8C20 0x0000000185FBC1E0-0x0000000185FBC1F0
		public ReusableCollectionItem draggedItem { get => default; } // 0x0000000181E336C0-0x0000000181E336D0 
		protected override bool supportsDragEvents { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
	
		// Constructors
		public ListViewDraggerAnimated() {} // Dummy constructor
		public ListViewDraggerAnimated(BaseVerticalCollectionView listView) {} // 0x000000018C034288-0x000000018C034290
	
		// Methods
		protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) => default; // 0x000000018C03355C-0x000000018C033B8C
		protected internal override void UpdateDrag(Vector3 pointerPosition) {} // 0x000000018C033BC0-0x000000018C034288
		private void Animate(ReusableCollectionItem element, float paddingTop) {} // 0x000000018C032FBC-0x000000018C033218
		protected internal override void OnDrop(Vector3 pointerPosition) {} // 0x000000018C033218-0x000000018C03355C
		protected override void ClearDragAndDropUI(bool dragCancelled) {} // 0x0000000185492010-0x0000000185492020
		protected override bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) => default; // 0x000000018C033B8C-0x000000018C033BC0
	}

	internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController // TypeDefIndex: 44558
	{
		// Fields
		protected readonly BaseListView m_ListView; // 0x28
	
		// Constructors
		public ListViewReorderableDragAndDropController() {} // Dummy constructor
		public ListViewReorderableDragAndDropController(BaseListView view) {} // 0x000000018C0347C8-0x000000018C0347F8
	
		// Methods
		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) => default; // 0x000000018C034530-0x000000018C0345A0
		public override void OnDrop(IListDragAndDropArgs args) {} // 0x000000018C0345A0-0x000000018C0347C8
	}

	internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController // TypeDefIndex: 44561
	{
		// Fields
		protected DropData m_DropData; // 0x28
		protected readonly BaseTreeView m_TreeView; // 0x30
		private IVisualElementScheduledItem m_ExpandDropItemScheduledItem; // 0x38
		private Action m_ExpandDropItemCallback; // 0x40
	
		// Nested types
		protected class DropData // TypeDefIndex: 44559
		{
			// Fields
			public int[] expandedIdsBeforeDrag; // 0x10
			public int[] draggedIds; // 0x18
			public int lastItemId; // 0x20
			public float expandItemBeginTimerMs; // 0x24
			public Vector2 expandItemBeginPosition; // 0x28
	
			// Constructors
			public DropData() {} // 0x000000018C03BE50-0x000000018C03BF18
		}
	
		private struct TreeItemState // TypeDefIndex: 44560
		{
			// Fields
			public int parentId; // 0x00
			public int childIndex; // 0x04
	
			// Constructors
			public TreeItemState(int parentId, int childIndex) {
				this.parentId = default;
				this.childIndex = default;
			} // 0x000000018C03ABEC-0x000000018C03B1B0
		}
	
		// Constructors
		public TreeViewReorderableDragAndDropController() {} // Dummy constructor
		public TreeViewReorderableDragAndDropController(BaseTreeView view) {} // 0x000000018C03BD88-0x000000018C03BE50
	
		// Methods
		protected override int CompareId(int id1, int id2) => default; // 0x000000018C03B628-0x000000018C03B680
		public override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false /* Metadata: 0x0205B631 */) => default; // 0x000000018C03B680-0x000000018C03BBD4
		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) => default; // 0x000000018C03B21C-0x000000018C03B2F4
		public override void OnDrop(IListDragAndDropArgs args) {} // 0x000000018C03BBD4-0x000000018C03BD88
		public override void DragCleanup() {} // 0x000000018C03B498-0x000000018C03B628
		private void RestoreExpanded(List<int> ids) {} // 0x000000018C03B1B0-0x000000018C03B21C
		public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) {} // 0x000000018C03B2F4-0x000000018C03B498
		private void DelayExpandDropItem() {} // 0x0000000185FBD7E0-0x0000000185FBD7F0
		private void ExpandDropItem() {} // 0x000000018357CB90-0x000000018357CBA0
	}

	internal interface IPointerCaptureEventInternal // TypeDefIndex: 44562
	{
		// Properties
		int pointerId { get; }
	}

	public abstract class PointerCaptureEventBase<T> : EventBase<T>, IPointerCaptureEventInternal // TypeDefIndex: 44563
		where T : PointerCaptureEventBase<T>, new()
	{
		// Fields
		private IEventHandler _relatedTarget_k__BackingField;
		private int _pointerId_k__BackingField;
	
		// Properties
		private IEventHandler relatedTarget { get; set; }
		public int pointerId { get; private set; }
	
		// Constructors
		protected PointerCaptureEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) => default;
	}

	public class PointerCaptureOutEvent : PointerCaptureEventBase<PointerCaptureOutEvent> // TypeDefIndex: 44564
	{
		// Constructors
		public PointerCaptureOutEvent() {} // 0x000000018C0381A8-0x000000018C0381E4
	}

	public class PointerCaptureEvent : PointerCaptureEventBase<PointerCaptureEvent> // TypeDefIndex: 44565
	{
		// Constructors
		public PointerCaptureEvent() {} // 0x000000018C03816C-0x000000018C0381A8
	}

	public abstract class MouseCaptureEventBase<T> : PointerCaptureEventBase<T> // TypeDefIndex: 44566
		where T : MouseCaptureEventBase<T>, new()
	{
		// Constructors
		protected MouseCaptureEventBase() {}
	
		// Methods
		protected override void Init() {}
	}

	public class MouseCaptureOutEvent : MouseCaptureEventBase<MouseCaptureOutEvent> // TypeDefIndex: 44567
	{
		// Constructors
		public MouseCaptureOutEvent() {} // 0x000000018C034CD0-0x000000018C034D0C
	}

	public class MouseCaptureEvent : MouseCaptureEventBase<MouseCaptureEvent> // TypeDefIndex: 44568
	{
		// Constructors
		public MouseCaptureEvent() {} // 0x000000018C034C94-0x000000018C034CD0
	}

	public class ChangeEvent<T> : EventBase<ChangeEvent<T>> // TypeDefIndex: 44569
	{
		// Fields
		private T _previousValue_k__BackingField;
		private T _newValue_k__BackingField;
	
		// Properties
		public T previousValue { get; protected set; }
		public T newValue { get; protected set; }
	
		// Constructors
		public ChangeEvent() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static ChangeEvent<T> GetPooled(T previousValue, T newValue) => default;
	}

	internal class CommandEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44570
	{
		// Constructors
		public CommandEventDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C02E5BC-0x000000018C02E5FC
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x000000018C02E5FC-0x000000018C02E78C
	}

	public interface ICommandEvent // TypeDefIndex: 44571
	{
	}

	public abstract class CommandEventBase<T> : EventBase<T>, ICommandEvent // TypeDefIndex: 44572
		where T : CommandEventBase<T>, new()
	{
		// Fields
		private string m_CommandName;
	
		// Properties
		public string commandName { get; protected set; }
	
		// Constructors
		protected CommandEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(UnityEngine.Event systemEvent) => default;
		public static T GetPooled(string commandName) => default;
	}

	public class ValidateCommandEvent : CommandEventBase<ValidateCommandEvent> // TypeDefIndex: 44573
	{
		// Constructors
		public ValidateCommandEvent() {} // 0x000000018C03DB8C-0x000000018C03DBC8
	}

	public class ExecuteCommandEvent : CommandEventBase<ExecuteCommandEvent> // TypeDefIndex: 44574
	{
		// Constructors
		public ExecuteCommandEvent() {} // 0x000000018C03210C-0x000000018C032148
	}

	internal class DefaultDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44575
	{
		// Constructors
		public DefaultDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C02EDB8-0x000000018C02EDF8
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x000000018C02EDF8-0x000000018C02EF48
	}

	internal class ElementUnderPointer // TypeDefIndex: 44576
	{
		// Fields
		private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
		private VisualElement[] m_TopElementUnderPointer; // 0x18
		private IPointerEvent[] m_TriggerPointerEvent; // 0x20
		private IMouseEvent[] m_TriggerMouseEvent; // 0x28
		private Vector2[] m_PickingPointerPositions; // 0x30
		private bool[] m_IsPickingPointerTemporaries; // 0x38
	
		// Constructors
		public ElementUnderPointer() {} // 0x000000018C0301B0-0x000000018C030318
	
		// Methods
		internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) {
			pickPosition = default;
			isTemporary = default;
			return default;
		} // 0x000000018C02FDB0-0x000000018C02FE38
		internal VisualElement GetTopElementUnderPointer(int pointerId) => default; // 0x0000000187B1A518-0x0000000187B1A544
		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) {} // 0x000000018C030068-0x000000018C030194
		private Vector2 GetEventPointerPosition(EventBase triggerEvent) => default; // 0x000000018C02FCF0-0x000000018C02FDB0
		internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) {} // 0x000000018C030194-0x000000018C0301B0
		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) {} // 0x000000018C03004C-0x000000018C030068
		private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) {} // 0x000000018C02FE38-0x000000018C03004C
		internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) {} // 0x000000018C02F148-0x000000018C02FCF0
	}

	public abstract class EventBase : IDisposable // TypeDefIndex: 44579
	{
		// Fields
		private static long s_LastTypeId; // 0x00
		private static ulong s_NextEventId; // 0x08
		private long _timestamp_k__BackingField; // 0x10
		private ulong _eventId_k__BackingField; // 0x18
		private ulong _triggerEventId_k__BackingField; // 0x20
		private EventPropagation _propagation_k__BackingField; // 0x28
		private PropagationPaths m_Path; // 0x30
		private LifeCycleStatus _lifeCycleStatus_k__BackingField; // 0x38
		private IEventHandler _leafTarget_k__BackingField; // 0x40
		private IEventHandler m_Target; // 0x48
		private readonly List<IEventHandler> _skipElements_k__BackingField; // 0x50
		private PropagationPhase _propagationPhase_k__BackingField; // 0x58
		private IEventHandler m_CurrentTarget; // 0x60
		private UnityEngine.Event m_ImguiEvent; // 0x68
		private Vector2 _originalMousePosition_k__BackingField; // 0x70
	
		// Properties
		public virtual long eventTypeId { get; } // 0x0000000185FCFB80-0x0000000185FCFB90 
		public long timestamp { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000185FB2C40-0x0000000185FB2C50
		internal ulong eventId { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000181448AC0-0x0000000181448AD0
		private ulong triggerEventId { get; set; } // 0x00000001813BDF70-0x00000001813BDF80
		internal EventPropagation propagation { get; set; } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		internal PropagationPaths path { get; set; } // 0x000000018C030774-0x000000018C030834 0x000000018C030AE8-0x000000018C030B48
		private LifeCycleStatus lifeCycleStatus { get; set; } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public bool bubbles { get; } // 0x000000018C030720-0x000000018C030728 
		public bool tricklesDown { get; } // 0x000000018C030870-0x000000018C030878 
		internal bool skipDisabledElements { get; set; } // 0x000000018C030860-0x000000018C030868 0x000000018C030BB8-0x000000018C030BD4
		internal bool ignoreCompositeRoots { get; set; } // 0x000000018C03073C-0x000000018C030744 0x000000018C030998-0x000000018C0309B4
		internal IEventHandler leafTarget { get; private set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public IEventHandler target { get; set; } // 0x0000000185FE8BF0-0x0000000185FE8C00 0x000000018C030BF0-0x000000018C030C20
		internal List<IEventHandler> skipElements { get; } // 0x0000000181460F60-0x0000000181460F70 
		public bool isPropagationStopped { get; private set; } // 0x000000018C03076C-0x000000018C030774 0x000000018C030ACC-0x000000018C030AE8
		public bool isImmediatePropagationStopped { get; private set; } // 0x000000018C030764-0x000000018C03076C 0x000000018C030AB0-0x000000018C030ACC
		public bool isDefaultPrevented { get; private set; } // 0x000000018C03075C-0x000000018C030764 0x000000018C030A94-0x000000018C030AB0
		public PropagationPhase propagationPhase { get; internal set; } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
		public virtual IEventHandler currentTarget { get; internal set; } // 0x0000000185FE8BA0-0x0000000185FE8BB0 0x000000018C030878-0x000000018C030964
		public bool dispatch { get; internal set; } // 0x000000018C030728-0x000000018C030730 0x000000018C030964-0x000000018C03097C
		private bool dispatched { get; set; } // 0x000000018C030730-0x000000018C03073C 0x000000018C03097C-0x000000018C030998
		internal bool processed { get; private set; } // 0x000000018C030848-0x000000018C030854 0x000000018C030B80-0x000000018C030B9C
		internal bool processedByFocusController { get; set; } // 0x000000018C03083C-0x000000018C030848 0x000000018C030B64-0x000000018C030B80
		internal bool stopDispatch { get; set; } // 0x000000018C030868-0x000000018C030870 0x000000018C030BD4-0x000000018C030BF0
		internal bool propagateToIMGUI { get; set; } // 0x000000018C030854-0x000000018C030860 0x000000018C030B9C-0x000000018C030BB8
		private bool imguiEventIsValid { get; set; } // 0x000000018C030744-0x000000018C03074C 0x000000018C0309B4-0x000000018C0309D0
		public UnityEngine.Event imguiEvent { get; protected set; } // 0x000000018C03074C-0x000000018C03075C 0x000000018C0309D0-0x000000018C030A94
		public Vector2 originalMousePosition { get; private set; } // 0x0000000185FBCAA0-0x0000000185FBCAC0 0x0000000185FB07F0-0x0000000185FB0800
		protected bool pooled { get; set; } // 0x000000018C030834-0x000000018C03083C 0x000000018C030B48-0x000000018C030B64
	
		// Nested types
		internal enum EventPropagation // TypeDefIndex: 44577
		{
			None = 0,
			Bubbles = 1,
			TricklesDown = 2,
			Cancellable = 4,
			SkipDisabledElements = 8,
			IgnoreCompositeRoots = 16
		}
	
		private enum LifeCycleStatus // TypeDefIndex: 44578
		{
			None = 0,
			PropagationStopped = 1,
			ImmediatePropagationStopped = 2,
			DefaultPrevented = 4,
			Dispatching = 8,
			Pooled = 16,
			IMGUIEventIsValid = 32,
			StopDispatch = 64,
			PropagateToIMGUI = 128,
			Dispatched = 512,
			Processed = 1024,
			ProcessedByFocusController = 2048
		}
	
		// Constructors
		protected EventBase() {} // 0x000000018C030690-0x000000018C030720
	
		// Methods
		protected static long RegisterEventType() => default; // 0x000000018C0305E0-0x000000018C030624
		internal void SetTriggerEventId(ulong id) {} // 0x00000001813BDF70-0x00000001813BDF80
		protected virtual void PreDispatch() {} // 0x0000000185492010-0x0000000185492020
		protected internal virtual void PreDispatch(IPanel panel) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void PostDispatch() {} // 0x0000000185492010-0x0000000185492020
		protected internal virtual void PostDispatch(IPanel panel) {} // 0x000000018C0305CC-0x000000018C0305D4
		internal bool Skip(IEventHandler h) => default; // 0x000000018C030624-0x000000018C030678
		public void StopPropagation() {} // 0x000000018C030688-0x000000018C030690
		public void StopImmediatePropagation() {} // 0x000000018C030678-0x000000018C030688
		public void PreventDefault() {} // 0x000000018C0305D4-0x000000018C0305E0
		internal void MarkReceivedByDispatcher() {} // 0x000000018C030560-0x000000018C0305CC
		protected virtual void Init() {} // 0x000000018C03042C-0x000000018C030434
		private void LocalInit() {} // 0x000000018C030434-0x000000018C030560
		internal abstract void Acquire();
		public abstract void Dispose();
	}

	public abstract class EventBase<T> : EventBase // TypeDefIndex: 44580
		where T : EventBase<T>, new()
	{
		// Fields
		private static readonly long s_TypeId;
		private static readonly ObjectPool<T> s_Pool;
		private int m_RefCount;
	
		// Properties
		public override long eventTypeId { get; }
	
		// Constructors
		protected EventBase() {}
		static EventBase() {}
	
		// Methods
		public static long TypeId() => default;
		protected override void Init() {}
		public static T GetPooled() => default;
		internal static T GetPooled(EventBase e) => default;
		private static void ReleasePooled(T evt) {}
		internal override void Acquire() {}
		public sealed override void Dispose() {}
	}

	public delegate void EventCallback<in TEventType>(TEventType evt); // TypeDefIndex: 44581; 0x00000000-0x00000000

	internal abstract class EventCallbackFunctorBase // TypeDefIndex: 44582
	{
		// Fields
		private readonly CallbackPhase _phase_k__BackingField; // 0x10
		private readonly InvokePolicy _invokePolicy_k__BackingField; // 0x14
	
		// Properties
		public CallbackPhase phase { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		public InvokePolicy invokePolicy { get; } // 0x0000000185FB21A0-0x0000000185FB21B0 
	
		// Constructors
		protected EventCallbackFunctorBase() {} // Dummy constructor
		protected EventCallbackFunctorBase(CallbackPhase phase, InvokePolicy invokePolicy) {} // 0x0000000185FB2190-0x0000000185FB21A0
	
		// Methods
		public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase);
		public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase);
		protected bool PhaseMatches(PropagationPhase propagationPhase) => default; // 0x000000018C030C20-0x000000018C030C44
	}

	internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase // TypeDefIndex: 44583
		where TEventType : EventBase<TEventType>, new()
	{
		// Fields
		private readonly EventCallback<TEventType> m_Callback;
		private readonly long m_EventTypeId;
	
		// Constructors
		public EventCallbackFunctor() {} // Dummy constructor
		public EventCallbackFunctor(EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy = InvokePolicy.Default /* Metadata: 0x0205B649 */) {}
	
		// Methods
		public override void Invoke(EventBase evt, PropagationPhase propagationPhase) {}
		public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase) => default;
	}

	public enum TrickleDown // TypeDefIndex: 44584
	{
		NoTrickleDown = 0,
		TrickleDown = 1
	}

	internal enum CallbackPhase // TypeDefIndex: 44585
	{
		TargetAndBubbleUp = 1,
		TrickleDownAndTarget = 2
	}

	internal enum InvokePolicy // TypeDefIndex: 44586
	{
		Default = 0,
		IncludeDisabled = 1
	}

	internal class EventCallbackListPool // TypeDefIndex: 44587
	{
		// Fields
		private readonly Stack<EventCallbackList> m_Stack; // 0x10
	
		// Constructors
		public EventCallbackListPool() {} // 0x000000018C030D74-0x000000018C030DEC
	
		// Methods
		public EventCallbackList Get(EventCallbackList initializer) => default; // 0x000000018C030C44-0x000000018C030D10
		public void Release(EventCallbackList element) {} // 0x000000018C030D10-0x000000018C030D74
	}

	internal class EventCallbackList // TypeDefIndex: 44588
	{
		// Fields
		private List<EventCallbackFunctorBase> m_List; // 0x10
		private int _trickleDownCallbackCount_k__BackingField; // 0x18
		private int _bubbleUpCallbackCount_k__BackingField; // 0x1C
	
		// Properties
		public int trickleDownCallbackCount { get; private set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public int bubbleUpCallbackCount { get; private set; } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public int Count { get => default; } // 0x000000018C031324-0x000000018C031364 
		public EventCallbackFunctorBase this[int i] { get => default; } // 0x000000018C031364-0x000000018C0313B8 
	
		// Constructors
		public EventCallbackList() {} // 0x000000018C03120C-0x000000018C03128C
		public EventCallbackList(EventCallbackList source) {} // 0x000000018C03128C-0x000000018C031324
	
		// Methods
		public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase) => default; // 0x000000018C031034-0x000000018C031054
		public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase) => default; // 0x000000018C031054-0x000000018C031120
		public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase) => default; // 0x000000018C031120-0x000000018C03120C
		public void Add(EventCallbackFunctorBase item) {} // 0x000000018C030F74-0x000000018C030FE4
		public void AddRange(EventCallbackList list) {} // 0x000000018C030DEC-0x000000018C030F74
		public void Clear() {} // 0x000000018C030FE4-0x000000018C031034
	}

	internal class EventCallbackRegistry // TypeDefIndex: 44589
	{
		// Fields
		private static readonly EventCallbackListPool s_ListPool; // 0x00
		private EventCallbackList m_Callbacks; // 0x10
		private EventCallbackList m_TemporaryCallbacks; // 0x18
		private int m_IsInvoking; // 0x20
	
		// Constructors
		public EventCallbackRegistry() {} // 0x0000000185FAFE40-0x0000000185FAFE50
		static EventCallbackRegistry() {} // 0x000000018C031754-0x000000018C0317D0
	
		// Methods
		private static EventCallbackList GetCallbackList(EventCallbackList initializer = null) => default; // 0x000000018C03146C-0x000000018C0314CC
		private static void ReleaseCallbackList(EventCallbackList toRelease) {} // 0x000000018C031684-0x000000018C0316E4
		private EventCallbackList GetCallbackListForWriting() => default; // 0x000000018C0313CC-0x000000018C03146C
		private EventCallbackList GetCallbackListForReading() => default; // 0x000000018C0313B8-0x000000018C0313CC
		private bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown) => default; // 0x000000018C0316E4-0x000000018C031754
		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x0205B650 */, InvokePolicy invokePolicy = InvokePolicy.Default /* Metadata: 0x0205B651 */)
			where TEventType : EventBase<TEventType>, new() {}
		public bool UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x0205B652 */)
			where TEventType : EventBase<TEventType>, new() => default;
		public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase) {} // 0x000000018C0314FC-0x000000018C031684
		public bool HasTrickleDownHandlers() => default; // 0x000000018C0314E4-0x000000018C0314FC
		public bool HasBubbleHandlers() => default; // 0x000000018C0314CC-0x000000018C0314E4
	}

	public interface IEventHandler // TypeDefIndex: 44590
	{
		// Methods
		void SendEvent(EventBase e);
		void HandleEvent(EventBase evt);
	}

	public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 44591
	{
		// Fields
		internal bool isIMGUIContainer; // 0x10
		private EventCallbackRegistry m_CallbackRegistry; // 0x18
	
		// Constructors
		protected CallbackEventHandler() {} // 0x0000000185FB6A70-0x0000000185FB6A80
	
		// Methods
		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x0205B653 */)
			where TEventType : EventBase<TEventType>, new() {}
		internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x0205B654 */)
			where TEventType : EventBase<TEventType>, new() {}
		public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x0205B655 */)
			where TEventType : EventBase<TEventType>, new() {}
		public abstract void SendEvent(EventBase e);
		internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);
		internal void HandleEventAtTargetPhase(EventBase evt) {} // 0x000000018C02E1BC-0x000000018C02E21C
		internal void HandleEventAtTargetAndDefaultPhase(EventBase evt) {} // 0x000000018C02E178-0x000000018C02E1BC
		internal void HandleEventAtCurrentTargetAndPhase(EventBase evt) {} // 0x000000018B992BDC-0x000000018B992BF0
		void IEventHandler.HandleEvent(EventBase evt) {} // 0x000000018B992BDC-0x000000018B992BF0
		public virtual void HandleEvent(EventBase evt) {} // 0x000000018C02E21C-0x000000018C02E448
		public bool HasTrickleDownHandlers() => default; // 0x000000018C02E464-0x000000018C02E480
		public bool HasBubbleUpHandlers() => default; // 0x000000018C02E448-0x000000018C02E464
		protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void ExecuteDefaultAction(EventBase evt) {} // 0x0000000185492010-0x0000000185492020
		internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt) {} // 0x0000000185492010-0x0000000185492020
		internal virtual void ExecuteDefaultActionDisabled(EventBase evt) {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class FocusEventBase<T> : EventBase<T> // TypeDefIndex: 44592
		where T : FocusEventBase<T>, new()
	{
		// Fields
		private Focusable _relatedTarget_k__BackingField;
		private FocusChangeDirection _direction_k__BackingField;
		private FocusController _focusController_k__BackingField;
		private bool _IsFocusDelegated_k__BackingField;
	
		// Properties
		public Focusable relatedTarget { get; private set; }
		public FocusChangeDirection direction { get; private set; }
		protected FocusController focusController { get; private set; }
		internal bool IsFocusDelegated { get; private set; }
	
		// Constructors
		protected FocusEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false /* Metadata: 0x0205B656 */) => default;
	}

	public class FocusOutEvent : FocusEventBase<FocusOutEvent> // TypeDefIndex: 44593
	{
		// Constructors
		public FocusOutEvent() {} // 0x000000018C0322C0-0x000000018C032304
	
		// Methods
		protected override void Init() {} // 0x000000018C03227C-0x000000018C0322C0
		private new void LocalInit() {} // 0x0000000185FE9FA0-0x0000000185FE9FB0
	}

	public class BlurEvent : FocusEventBase<BlurEvent> // TypeDefIndex: 44594
	{
		// Constructors
		public BlurEvent() {} // 0x000000018C02E13C-0x000000018C02E178
	
		// Methods
		protected internal override void PreDispatch(IPanel panel) {} // 0x000000018C02E0DC-0x000000018C02E13C
	}

	public class FocusInEvent : FocusEventBase<FocusInEvent> // TypeDefIndex: 44595
	{
		// Constructors
		public FocusInEvent() {} // 0x000000018C032238-0x000000018C03227C
	
		// Methods
		protected override void Init() {} // 0x000000018C0321F4-0x000000018C032238
		private new void LocalInit() {} // 0x0000000185FE9FA0-0x0000000185FE9FB0
	}

	public class FocusEvent : FocusEventBase<FocusEvent> // TypeDefIndex: 44596
	{
		// Constructors
		public FocusEvent() {} // 0x000000018C0321B8-0x000000018C0321F4
	
		// Methods
		protected internal override void PreDispatch(IPanel panel) {} // 0x000000018C032148-0x000000018C0321B8
	}

	public enum PropagationPhase // TypeDefIndex: 44597
	{
		None = 0,
		TrickleDown = 1,
		AtTarget = 2,
		BubbleUp = 3,
		DefaultAction = 4,
		DefaultActionAtTarget = 5
	}

	internal interface IEventDispatchingStrategy // TypeDefIndex: 44598
	{
		// Methods
		bool CanDispatchEvent(EventBase evt);
		void DispatchEvent(EventBase evt, IPanel panel);
	}

	internal static class EventDispatchUtilities // TypeDefIndex: 44599
	{
		// Methods
		public static void PropagateEvent(EventBase evt) {} // 0x000000018C03187C-0x000000018C031F38
		internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) {} // 0x000000018C031F38-0x000000018C03210C
		public static void ExecuteDefaultAction(EventBase evt, IPanel panel) {} // 0x000000018C0317D0-0x000000018C03187C
	}

	internal class IMGUIEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44600
	{
		// Constructors
		public IMGUIEventDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C0329E4-0x000000018C032A24
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x000000018C032A24-0x000000018C032A68
	}

	public class InputEvent : EventBase<InputEvent> // TypeDefIndex: 44601
	{
		// Fields
		private string _previousData_k__BackingField; // 0x80
		private string _newData_k__BackingField; // 0x88
	
		// Properties
		protected string previousData { get; set; } // 0x00000001873CBE98-0x00000001873CBEA8
		protected string newData { get; set; } // 0x0000000186472AA8-0x0000000186472ABC
	
		// Constructors
		public InputEvent() {} // 0x000000018C032C90-0x000000018C032CEC
	
		// Methods
		protected override void Init() {} // 0x000000018C032C14-0x000000018C032C58
		private new void LocalInit() {} // 0x000000018C032C58-0x000000018C032C90
		public static InputEvent GetPooled(string previousData, string newData) => default; // 0x000000018C032B80-0x000000018C032C14
	}

	internal class KeyboardEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44602
	{
		// Constructors
		public KeyboardEventDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C032E30-0x000000018C032E70
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x000000018C032E70-0x000000018C032FBC
	}

	public interface IKeyboardEvent // TypeDefIndex: 44603
	{
		// Properties
		EventModifiers modifiers { get; }
		char character { get; }
		KeyCode keyCode { get; }
	}

	public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent // TypeDefIndex: 44604
		where T : KeyboardEventBase<T>, new()
	{
		// Fields
		private EventModifiers _modifiers_k__BackingField;
		private char _character_k__BackingField;
		private KeyCode _keyCode_k__BackingField;
	
		// Properties
		public EventModifiers modifiers { get; protected set; }
		public char character { get; protected set; }
		public KeyCode keyCode { get; protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		public bool actionKey { get; }
	
		// Constructors
		protected KeyboardEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers) => default;
		public static T GetPooled(UnityEngine.Event systemEvent) => default;
	}

	public class KeyDownEvent : KeyboardEventBase<KeyDownEvent> // TypeDefIndex: 44605
	{
		// Constructors
		public KeyDownEvent() {} // 0x000000018C032DB8-0x000000018C032DF4
	
		// Methods
		internal void GetEquivalentImguiEvent(UnityEngine.Event outImguiEvent) {} // 0x000000018C032CEC-0x000000018C032DB8
	}

	public class KeyUpEvent : KeyboardEventBase<KeyUpEvent> // TypeDefIndex: 44606
	{
		// Constructors
		public KeyUpEvent() {} // 0x000000018C032DF4-0x000000018C032E30
	}

	public class GeometryChangedEvent : EventBase<GeometryChangedEvent> // TypeDefIndex: 44607
	{
		// Fields
		private Rect _oldRect_k__BackingField; // 0x80
		private Rect _newRect_k__BackingField; // 0x90
		private int _layoutPass_k__BackingField; // 0xA0
	
		// Properties
		public Rect oldRect { get; private set; } // 0x0000000185FBC0B0-0x0000000185FBC0C0 0x0000000185FC9CB0-0x0000000185FC9CC0
		public Rect newRect { get; private set; } // 0x0000000185FC9A40-0x0000000185FC9A50 0x0000000185FCCD40-0x0000000185FCCD50
		internal int layoutPass { get; set; } // 0x0000000185FB2320-0x0000000185FB2330 0x0000000185FB23E0-0x0000000185FB23F0
	
		// Constructors
		public GeometryChangedEvent() {} // 0x000000018C032988-0x000000018C0329E4
	
		// Methods
		public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect) => default; // 0x000000018C0328C8-0x000000018C032944
		protected override void Init() {} // 0x000000018C032944-0x000000018C032988
		private new void LocalInit() {} // 0x0000000185FE9FB0-0x0000000185FE9FD0
	}

	internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44609
	{
		// Nested types
		private enum EventBehavior // TypeDefIndex: 44608
		{
			None = 0,
			IsCapturable = 1,
			IsSentExclusivelyToCapturingElement = 2
		}
	
		// Constructors
		public MouseCaptureDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C0347F8-0x000000018C034860
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x000000018C034860-0x000000018C034C94
	}

	internal class MouseEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44610
	{
		// Constructors
		public MouseEventDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C035000-0x000000018C035040
		public void DispatchEvent(EventBase evt, IPanel iPanel) {} // 0x000000018C035040-0x000000018C0350F0
		private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel) => default; // 0x000000018C0352C4-0x000000018C035300
		private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel) => default; // 0x000000018C035290-0x000000018C0352C4
		private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel) => default; // 0x000000018C035130-0x000000018C035290
		private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel) {} // 0x000000018C035300-0x000000018C035384
		private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse) {
			elementUnderMouse = default;
		} // 0x000000018C035384-0x000000018C035578
		private static bool IsDone(EventBase evt) => default; // 0x000000018C0350F0-0x000000018C035130
	}

	public interface IMouseEvent // TypeDefIndex: 44611
	{
		// Properties
		EventModifiers modifiers { get; }
		Vector2 mousePosition { get; }
		Vector2 localMousePosition { get; }
		Vector2 mouseDelta { get; }
		int clickCount { get; }
		int button { get; }
		int pressedButtons { get; }
		bool shiftKey { get; }
		bool ctrlKey { get; }
		bool commandKey { get; }
		bool altKey { get; }
	}

	internal interface IMouseEventInternal // TypeDefIndex: 44612
	{
		// Properties
		bool triggeredByOS { get; set; }
		bool recomputeTopElementUnderMouse { get; set; }
		IPointerEvent sourcePointerEvent { get; set; }
	}

	public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal // TypeDefIndex: 44613
		where T : MouseEventBase<T>, new()
	{
		// Fields
		private EventModifiers _modifiers_k__BackingField;
		private Vector2 _mousePosition_k__BackingField;
		private Vector2 _localMousePosition_k__BackingField;
		private Vector2 _mouseDelta_k__BackingField;
		private int _clickCount_k__BackingField;
		private int _button_k__BackingField;
		private int _pressedButtons_k__BackingField;
		private bool _UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField;
		private bool _UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField;
		private IPointerEvent _UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField;
	
		// Properties
		public EventModifiers modifiers { get; protected set; }
		public Vector2 mousePosition { get; protected set; }
		public Vector2 localMousePosition { get; internal set; }
		public Vector2 mouseDelta { get; protected set; }
		public int clickCount { get; protected set; }
		public int button { get; protected set; }
		public int pressedButtons { get; protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		bool IMouseEventInternal.triggeredByOS { get; set; }
		bool IMouseEventInternal.recomputeTopElementUnderMouse { get; set; }
		IPointerEvent IMouseEventInternal.sourcePointerEvent { get; set; }
		public override IEventHandler currentTarget { get; internal set; }
	
		// Constructors
		protected MouseEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		protected internal override void PreDispatch(IPanel panel) {}
		protected internal override void PostDispatch(IPanel panel) {}
		public static T GetPooled(UnityEngine.Event systemEvent) => default;
		internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse) => default;
		public static T GetPooled(IMouseEvent triggerEvent) => default;
		protected static T GetPooled(IPointerEvent pointerEvent) => default;
	}

	public class MouseDownEvent : MouseEventBase<MouseDownEvent> // TypeDefIndex: 44614
	{
		// Constructors
		public MouseDownEvent() {} // 0x000000018C034E10-0x000000018C034E54
	
		// Methods
		protected override void Init() {} // 0x000000018C034D18-0x000000018C034D5C
		private new void LocalInit() {} // 0x0000000185FE9F90-0x0000000185FE9FA0
		private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) => default; // 0x000000018C034D5C-0x000000018C034E10
		internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) => default; // 0x000000018C034D0C-0x000000018C034D18
		internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) => default; // 0x000000018C034D0C-0x000000018C034D18
	}

	public class MouseUpEvent : MouseEventBase<MouseUpEvent> // TypeDefIndex: 44615
	{
		// Constructors
		public MouseUpEvent() {} // 0x000000018C035C1C-0x000000018C035C60
	
		// Methods
		protected override void Init() {} // 0x000000018C035B24-0x000000018C035B68
		private new void LocalInit() {} // 0x0000000185FE9F90-0x0000000185FE9FA0
		private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent) => default; // 0x000000018C035B68-0x000000018C035C1C
		internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent) => default; // 0x000000018C035B18-0x000000018C035B24
		internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent) => default; // 0x000000018C035B18-0x000000018C035B24
		internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent) => default; // 0x000000018C035B18-0x000000018C035B24
	}

	public class MouseMoveEvent : MouseEventBase<MouseMoveEvent> // TypeDefIndex: 44616
	{
		// Constructors
		public MouseMoveEvent() {} // 0x000000018C035A5C-0x000000018C035AA0
	
		// Methods
		protected override void Init() {} // 0x000000018C035A18-0x000000018C035A5C
		private new void LocalInit() {} // 0x0000000185FE9FD0-0x0000000185FE9FE0
		internal static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent) => default; // 0x000000018C0359DC-0x000000018C035A18
	}

	public class ContextClickEvent : MouseEventBase<ContextClickEvent> // TypeDefIndex: 44617
	{
		// Constructors
		public ContextClickEvent() {} // 0x000000018C02E78C-0x000000018C02E7C8
	}

	public class WheelEvent : MouseEventBase<WheelEvent> // TypeDefIndex: 44618
	{
		// Fields
		private Vector3 _delta_k__BackingField; // 0xB8
	
		// Properties
		public Vector3 delta { get; private set; } // 0x0000000185FB1B00-0x0000000185FB1B20 0x0000000185FB1B70-0x0000000185FB1B90
	
		// Constructors
		public WheelEvent() {} // 0x000000018C03DD48-0x000000018C03DDA4
	
		// Methods
		public static new WheelEvent GetPooled(UnityEngine.Event systemEvent) => default; // 0x000000018C03DBC8-0x000000018C03DC5C
		internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) => default; // 0x000000018C03DC5C-0x000000018C03DCC8
		protected override void Init() {} // 0x000000018C03DCC8-0x000000018C03DD24
		private new void LocalInit() {} // 0x000000018C03DD24-0x000000018C03DD48
	}

	public class MouseEnterEvent : MouseEventBase<MouseEnterEvent> // TypeDefIndex: 44619
	{
		// Constructors
		public MouseEnterEvent() {} // 0x000000018C034E98-0x000000018C034EDC
	
		// Methods
		protected override void Init() {} // 0x000000018C034E54-0x000000018C034E98
		private new void LocalInit() {} // 0x0000000185FE9FE0-0x0000000185FE9FF0
	}

	public class MouseLeaveEvent : MouseEventBase<MouseLeaveEvent> // TypeDefIndex: 44620
	{
		// Constructors
		public MouseLeaveEvent() {} // 0x000000018C0357C0-0x000000018C035804
	
		// Methods
		protected override void Init() {} // 0x000000018C03577C-0x000000018C0357C0
		private new void LocalInit() {} // 0x0000000185FE9FE0-0x0000000185FE9FF0
	}

	public class MouseEnterWindowEvent : MouseEventBase<MouseEnterWindowEvent> // TypeDefIndex: 44621
	{
		// Constructors
		public MouseEnterWindowEvent() {} // 0x000000018C034FBC-0x000000018C035000
	
		// Methods
		protected override void Init() {} // 0x000000018C034EDC-0x000000018C034F20
		private new void LocalInit() {} // 0x0000000185FE9FF0-0x0000000185FEA000
		protected internal override void PostDispatch(IPanel panel) {} // 0x000000018C034F20-0x000000018C034FBC
	}

	public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent> // TypeDefIndex: 44622
	{
		// Constructors
		public MouseLeaveWindowEvent() {} // 0x000000018C035990-0x000000018C0359DC
	
		// Methods
		protected override void Init() {} // 0x000000018C035898-0x000000018C0358E4
		private new void LocalInit() {} // 0x000000018C0358E4-0x000000018C0358F4
		public static new MouseLeaveWindowEvent GetPooled(UnityEngine.Event systemEvent) => default; // 0x000000018C035804-0x000000018C035898
		protected internal override void PostDispatch(IPanel panel) {} // 0x000000018C0358F4-0x000000018C035990
	}

	public class MouseOverEvent : MouseEventBase<MouseOverEvent> // TypeDefIndex: 44623
	{
		// Constructors
		public MouseOverEvent() {} // 0x000000018C035ADC-0x000000018C035B18
	}

	public class MouseOutEvent : MouseEventBase<MouseOutEvent> // TypeDefIndex: 44624
	{
		// Constructors
		public MouseOutEvent() {} // 0x000000018C035AA0-0x000000018C035ADC
	}

	public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent> // TypeDefIndex: 44625
	{
		// Fields
		private DropdownMenu _menu_k__BackingField; // 0xB8
		private EventBase _triggerEvent_k__BackingField; // 0xC0
		private ContextualMenuManager m_ContextualMenuManager; // 0xC8
	
		// Properties
		public DropdownMenu menu { get; private set; } // 0x000000018349D710-0x000000018349D720 0x0000000187A47500-0x0000000187A47514
		public EventBase triggerEvent { get; private set; } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
	
		// Constructors
		public ContextualMenuPopulateEvent() {} // 0x000000018C02ECC4-0x000000018C02ED08
	
		// Methods
		public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) => default; // 0x000000018C02E7C8-0x000000018C02EB44
		protected override void Init() {} // 0x000000018C02EB44-0x000000018C02EB88
		private new void LocalInit() {} // 0x000000018C02EB88-0x000000018C02EBF0
		protected internal override void PostDispatch(IPanel panel) {} // 0x000000018C02EBF0-0x000000018C02ECC4
	}

	internal static class MouseEventsHelper // TypeDefIndex: 44626
	{
		// Methods
		internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition)
			where TLeaveEvent : MouseEventBase<TLeaveEvent>, new()
			where TEnterEvent : MouseEventBase<TEnterEvent>, new() {}
		internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) {} // 0x000000018C035578-0x000000018C03577C
	}

	internal static class PointerEventsHelper // TypeDefIndex: 44627
	{
		// Methods
		internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId)
			where TLeaveEvent : PointerEventBase<TLeaveEvent>, new()
			where TEnterEvent : PointerEventBase<TEnterEvent>, new() {}
		internal static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) {} // 0x000000018C038F3C-0x000000018C03914C
	}

	internal class NavigationEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44628
	{
		// Constructors
		public NavigationEventDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C036980-0x000000018C0369C0
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x000000018C0369C0-0x000000018C036A3C
	}

	public interface INavigationEvent // TypeDefIndex: 44629
	{
		// Properties
		bool shiftKey { get; }
		bool altKey { get; }
	}

	internal enum NavigationDeviceType // TypeDefIndex: 44630
	{
		Unknown = 0,
		Keyboard = 1,
		NonKeyboard = 2
	}

	public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent // TypeDefIndex: 44631
		where T : NavigationEventBase<T>, new()
	{
		// Fields
		private EventModifiers _modifiers_k__BackingField;
		private NavigationDeviceType _deviceType_k__BackingField;
	
		// Properties
		public EventModifiers modifiers { get; protected set; }
		public bool shiftKey { get; }
		public bool altKey { get; }
		private NavigationDeviceType deviceType { get; set; }
	
		// Constructors
		protected NavigationEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(EventModifiers modifiers = EventModifiers.None /* Metadata: 0x0205B663 */) => default;
		internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x0205B664 */) => default;
	}

	public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent> // TypeDefIndex: 44633
	{
		// Fields
		private Direction _direction_k__BackingField; // 0x88
		private Vector2 _move_k__BackingField; // 0x8C
	
		// Properties
		public Direction direction { get; private set; } // 0x00000001834A1F30-0x00000001834A1F40 0x00000001834A2280-0x00000001834A2290
		private Vector2 move { get; set; } // 0x0000000185FC8DC0-0x0000000185FC8DD0
	
		// Nested types
		public enum Direction // TypeDefIndex: 44632
		{
			None = 0,
			Left = 1,
			Up = 2,
			Right = 3,
			Down = 4,
			Next = 5,
			Previous = 6
		}
	
		// Constructors
		public NavigationMoveEvent() {} // 0x000000018C036BA4-0x000000018C036BF0
	
		// Methods
		internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f /* Metadata: 0x0205B665 */) => default; // 0x000000018C036A3C-0x000000018C036AAC
		public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x0205B669 */) => default; // 0x000000018C036AAC-0x000000018C036B48
		protected override void Init() {} // 0x000000018C036B48-0x000000018C036B94
		private new void LocalInit() {} // 0x000000018C036B94-0x000000018C036BA4
	}

	internal class NavigationTabEvent : NavigationEventBase<NavigationTabEvent> // TypeDefIndex: 44635
	{
		// Fields
		private Direction _direction_k__BackingField; // 0x88
	
		// Properties
		private Direction direction { get; set; } // 0x00000001834A2280-0x00000001834A2290
	
		// Nested types
		public enum Direction // TypeDefIndex: 44634
		{
			None = 0,
			Next = 1,
			Previous = 2
		}
	
		// Constructors
		public NavigationTabEvent() {} // 0x000000018C036CE8-0x000000018C036D30
	
		// Methods
		internal static Direction DetermineMoveDirection(int moveValue) => default; // 0x000000018C036C2C-0x000000018C036C40
		public static NavigationTabEvent GetPooled(int moveValue) => default; // 0x000000018C036C40-0x000000018C036CA4
		protected override void Init() {} // 0x000000018C036CA4-0x000000018C036CE8
	}

	public class NavigationCancelEvent : NavigationEventBase<NavigationCancelEvent> // TypeDefIndex: 44636
	{
		// Constructors
		public NavigationCancelEvent() {} // 0x000000018C036944-0x000000018C036980
	}

	public class NavigationSubmitEvent : NavigationEventBase<NavigationSubmitEvent> // TypeDefIndex: 44637
	{
		// Constructors
		public NavigationSubmitEvent() {} // 0x000000018C036BF0-0x000000018C036C2C
	}

	public abstract class PanelChangedEventBase<T> : EventBase<T> // TypeDefIndex: 44638
		where T : PanelChangedEventBase<T>, new()
	{
		// Fields
		private IPanel _originPanel_k__BackingField;
		private IPanel _destinationPanel_k__BackingField;
	
		// Properties
		public IPanel originPanel { get; private set; }
		public IPanel destinationPanel { get; private set; }
	
		// Constructors
		protected PanelChangedEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(IPanel originPanel, IPanel destinationPanel) => default;
	}

	public class AttachToPanelEvent : PanelChangedEventBase<AttachToPanelEvent> // TypeDefIndex: 44639
	{
		// Constructors
		public AttachToPanelEvent() {} // 0x000000018C02E0A0-0x000000018C02E0DC
	}

	public class DetachFromPanelEvent : PanelChangedEventBase<DetachFromPanelEvent> // TypeDefIndex: 44640
	{
		// Constructors
		public DetachFromPanelEvent() {} // 0x000000018C02EF48-0x000000018C02EF84
	}

	internal class PointerCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44641
	{
		// Constructors
		public PointerCaptureDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C037E50-0x000000018C037E90
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x000000018C037E90-0x000000018C03816C
	}

	internal static class PointerDeviceState // TypeDefIndex: 44644
	{
		// Fields
		private static PointerLocation[] s_PlayerPointerLocations; // 0x00
		private static int[] s_PressedButtons; // 0x08
		private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture; // 0x10
	
		// Nested types
		internal enum LocationFlag // TypeDefIndex: 44642
		{
			None = 0,
			OutsidePanel = 1
		}
	
		private struct PointerLocation // TypeDefIndex: 44643
		{
			// Fields
			private Vector2 _Position_k__BackingField; // 0x00
			private IPanel _Panel_k__BackingField; // 0x08
			private LocationFlag _Flags_k__BackingField; // 0x10
	
			// Properties
			internal Vector2 Position { get; private set; } // 0x000000018C03861C-0x000000018C038774 0x000000018C038774-0x000000018C038800
			internal IPanel Panel { get; private set; } // 0x000000018C038468-0x000000018C038510 0x000000018C038574-0x000000018C03861C
			internal LocationFlag Flags { get; private set; } // 0x000000018C038510-0x000000018C038574 0x000000018C0382A8-0x000000018C038314
	
			// Methods
			internal void SetLocation(Vector2 position, IPanel panel) {} // 0x000000018C0381E4-0x000000018C038244
		}
	
		// Constructors
		static PointerDeviceState() {} // 0x000000018C0391D4-0x000000018C039258
	
		// Methods
		internal static void RemovePanelData(IPanel panel) {} // 0x000000018B2D8E6C-0x000000018B2D8E74
		public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType) {} // 0x000000018C0383F4-0x000000018C038468
		public static void PressButton(int pointerId, int buttonId) {} // 0x000000018C038314-0x000000018C038378
		public static void ReleaseButton(int pointerId, int buttonId) {} // 0x000000018C038378-0x000000018C0383F4
		public static void ReleaseAllButtons(int pointerId) {} // 0x000000018C038800-0x000000018C038884
		public static Vector2 GetPointerPosition(int pointerId, ContextType contextType) => default; // 0x000000018C038244-0x000000018C0382A8
		public static IPanel GetPanel(int pointerId, ContextType contextType) => default; // 0x000000018C038884-0x000000018C0389B0
		private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag) => default; // 0x00000001834AFB60-0x00000001834AFB70
		public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag) => default; // 0x0000000185FB2BB0-0x0000000185FB2BC0
		public static int GetPressedButtons(int pointerId) => default; // 0x000000018357A260-0x000000018357A270
		internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) => default; // 0x00000001877900A4-0x00000001877900B4
		internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel) {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
		internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId) => default; // 0x0000000181378230-0x0000000181378240
	}

	internal class PointerEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 44645
	{
		// Constructors
		public PointerEventDispatchingStrategy() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x000000018C038C34-0x000000018C038C74
		public virtual void DispatchEvent(EventBase evt, IPanel panel) {} // 0x000000018C038C74-0x000000018C038CB0
		private static void SendEventToTarget(EventBase evt) {} // 0x000000018C038CB0-0x000000018C038CD8
		private static void SetBestTargetForEvent(EventBase evt, IPanel panel) {} // 0x000000018C038CD8-0x000000018C038DFC
		private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer) {
			elementUnderPointer = default;
		} // 0x000000018C038DFC-0x000000018C038F3C
	}

	public static class PointerType // TypeDefIndex: 44646
	{
		// Fields
		public static readonly string mouse; // 0x00
		public static readonly string touch; // 0x08
		public static readonly string pen; // 0x10
		public static readonly string unknown; // 0x18
	
		// Constructors
		static PointerType() {} // 0x000000018C039874-0x000000018C039984
	
		// Methods
		internal static string GetPointerType(int pointerId) => default; // 0x000000018C039774-0x000000018C039800
		internal static bool IsDirectManipulationDevice(string pointerType) => default; // 0x000000018C039800-0x000000018C039874
	}

	public static class PointerId // TypeDefIndex: 44647
	{
		// Fields
		public static readonly int maxPointers; // 0x00
		public static readonly int invalidPointerId; // 0x04
		public static readonly int mousePointerId; // 0x08
		public static readonly int touchPointerIdBase; // 0x0C
		public static readonly int touchPointerCount; // 0x10
		public static readonly int penPointerIdBase; // 0x14
		public static readonly int penPointerCount; // 0x18
		internal static readonly int[] hoveringPointers; // 0x20
	
		// Constructors
		static PointerId() {} // 0x0000000185D8F5B0-0x0000000185D8F6E0
	}

	public interface IPointerEvent // TypeDefIndex: 44648
	{
		// Properties
		int pointerId { get; }
		string pointerType { get; }
		bool isPrimary { get; }
		int button { get; }
		int pressedButtons { get; }
		Vector3 position { get; }
		Vector3 localPosition { get; }
		Vector3 deltaPosition { get; }
		float deltaTime { get; }
		int clickCount { get; }
		float pressure { get; }
		float tangentialPressure { get; }
		float altitudeAngle { get; }
		float azimuthAngle { get; }
		float twist { get; }
		Vector2 radius { get; }
		Vector2 radiusVariance { get; }
		EventModifiers modifiers { get; }
		bool shiftKey { get; }
		bool ctrlKey { get; }
		bool commandKey { get; }
		bool altKey { get; }
		bool actionKey { get; }
	}

	internal interface IPointerEventInternal // TypeDefIndex: 44649
	{
		// Properties
		bool triggeredByOS { get; set; }
		bool recomputeTopElementUnderPointer { get; set; }
	}

	public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal // TypeDefIndex: 44650
		where T : PointerEventBase<T>, new()
	{
		// Fields
		private int _pointerId_k__BackingField;
		private string _pointerType_k__BackingField;
		private bool _isPrimary_k__BackingField;
		private int _button_k__BackingField;
		private int _pressedButtons_k__BackingField;
		private Vector3 _position_k__BackingField;
		private Vector3 _localPosition_k__BackingField;
		private Vector3 _deltaPosition_k__BackingField;
		private float _deltaTime_k__BackingField;
		private int _clickCount_k__BackingField;
		private float _pressure_k__BackingField;
		private float _tangentialPressure_k__BackingField;
		private float _altitudeAngle_k__BackingField;
		private float _azimuthAngle_k__BackingField;
		private float _twist_k__BackingField;
		private Vector2 _radius_k__BackingField;
		private Vector2 _radiusVariance_k__BackingField;
		private EventModifiers _modifiers_k__BackingField;
		private bool _UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField;
		private bool _UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField;
	
		// Properties
		public int pointerId { get; protected set; }
		public string pointerType { get; protected set; }
		public bool isPrimary { get; protected set; }
		public int button { get; protected set; }
		public int pressedButtons { get; protected set; }
		public Vector3 position { get; protected set; }
		public Vector3 localPosition { get; protected set; }
		public Vector3 deltaPosition { get; protected set; }
		public float deltaTime { get; protected set; }
		public int clickCount { get; protected set; }
		public float pressure { get; protected set; }
		public float tangentialPressure { get; protected set; }
		public float altitudeAngle { get; protected set; }
		public float azimuthAngle { get; protected set; }
		public float twist { get; protected set; }
		public Vector2 radius { get; protected set; }
		public Vector2 radiusVariance { get; protected set; }
		public EventModifiers modifiers { get; protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		public bool actionKey { get; }
		bool IPointerEventInternal.triggeredByOS { get; set; }
		bool IPointerEventInternal.recomputeTopElementUnderPointer { get; set; }
		public override IEventHandler currentTarget { get; internal set; }
	
		// Constructors
		protected PointerEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		private static bool IsMouse(UnityEngine.Event systemEvent) => default;
		public static T GetPooled(UnityEngine.Event systemEvent) => default;
		public static T GetPooled(Touch touch, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x0205B676 */) => default;
		internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) => default;
		public static T GetPooled(IPointerEvent triggerEvent) => default;
		protected internal override void PreDispatch(IPanel panel) {}
		protected internal override void PostDispatch(IPanel panel) {}
	}

	public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent> // TypeDefIndex: 44651
	{
		// Constructors
		public PointerDownEvent() {} // 0x000000018C038B68-0x000000018C038BAC
	
		// Methods
		protected override void Init() {} // 0x000000018C0389B0-0x000000018C0389F4
		private new void LocalInit() {} // 0x000000018C0389F4-0x000000018C038A1C
		protected internal override void PostDispatch(IPanel panel) {} // 0x000000018C038A1C-0x000000018C038B68
	}

	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent> // TypeDefIndex: 44652
	{
		// Fields
		private bool _isHandledByDraggable_k__BackingField; // 0xF8
	
		// Properties
		internal bool isHandledByDraggable { get; set; } // 0x0000000185FB9380-0x0000000185FB9390 0x0000000185FEA040-0x0000000185FEA050
	
		// Constructors
		public PointerMoveEvent() {} // 0x000000018C039608-0x000000018C03964C
	
		// Methods
		protected override void Init() {} // 0x000000018C039258-0x000000018C03929C
		private new void LocalInit() {} // 0x000000018C03929C-0x000000018C0392CC
		protected internal override void PostDispatch(IPanel panel) {} // 0x000000018C0392CC-0x000000018C039608
	}

	public sealed class PointerStationaryEvent : PointerEventBase<PointerStationaryEvent> // TypeDefIndex: 44653
	{
		// Constructors
		public PointerStationaryEvent() {} // 0x000000018C039730-0x000000018C039774
	
		// Methods
		protected override void Init() {} // 0x000000018C0396C4-0x000000018C039708
		private new void LocalInit() {} // 0x000000018C039708-0x000000018C039730
	}

	public sealed class PointerUpEvent : PointerEventBase<PointerUpEvent> // TypeDefIndex: 44654
	{
		// Constructors
		public PointerUpEvent() {} // 0x000000018C039B8C-0x000000018C039BD0
	
		// Methods
		protected override void Init() {} // 0x000000018C039984-0x000000018C0399C8
		private new void LocalInit() {} // 0x000000018C0389F4-0x000000018C038A1C
		protected internal override void PostDispatch(IPanel panel) {} // 0x000000018C0399C8-0x000000018C039B8C
	}

	public sealed class PointerCancelEvent : PointerEventBase<PointerCancelEvent> // TypeDefIndex: 44655
	{
		// Constructors
		public PointerCancelEvent() {} // 0x000000018C037E0C-0x000000018C037E50
	
		// Methods
		protected override void Init() {} // 0x000000018C037BE8-0x000000018C037C2C
		private new void LocalInit() {} // 0x000000018C037C2C-0x000000018C037C54
		protected internal override void PostDispatch(IPanel panel) {} // 0x000000018C037C54-0x000000018C037E0C
	}

	public sealed class ClickEvent : PointerEventBase<ClickEvent> // TypeDefIndex: 44656
	{
		// Constructors
		public ClickEvent() {} // 0x000000018C02E578-0x000000018C02E5BC
	
		// Methods
		protected override void Init() {} // 0x000000018C02E534-0x000000018C02E578
		private new void LocalInit() {} // 0x0000000185FE9F90-0x0000000185FE9FA0
		internal static ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount) => default; // 0x000000018C02E4D0-0x000000018C02E534
	}

	public sealed class PointerEnterEvent : PointerEventBase<PointerEnterEvent> // TypeDefIndex: 44657
	{
		// Constructors
		public PointerEnterEvent() {} // 0x000000018C038BF0-0x000000018C038C34
	
		// Methods
		protected override void Init() {} // 0x000000018C038BAC-0x000000018C038BF0
		private new void LocalInit() {} // 0x0000000185FEA030-0x0000000185FEA040
	}

	public sealed class PointerLeaveEvent : PointerEventBase<PointerLeaveEvent> // TypeDefIndex: 44658
	{
		// Constructors
		public PointerLeaveEvent() {} // 0x000000018C039190-0x000000018C0391D4
	
		// Methods
		protected override void Init() {} // 0x000000018C03914C-0x000000018C039190
		private new void LocalInit() {} // 0x0000000185FEA030-0x0000000185FEA040
	}

	public sealed class PointerOverEvent : PointerEventBase<PointerOverEvent> // TypeDefIndex: 44659
	{
		// Constructors
		public PointerOverEvent() {} // 0x000000018C039688-0x000000018C0396C4
	}

	public sealed class PointerOutEvent : PointerEventBase<PointerOutEvent> // TypeDefIndex: 44660
	{
		// Constructors
		public PointerOutEvent() {} // 0x000000018C03964C-0x000000018C039688
	}

	internal class PropagationPaths // TypeDefIndex: 44662
	{
		// Fields
		private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x00
		public readonly List<VisualElement> trickleDownPath; // 0x10
		public readonly List<VisualElement> targetElements; // 0x18
		public readonly List<VisualElement> bubbleUpPath; // 0x20
		private const int k_DefaultPropagationDepth = 16; // Metadata: 0x0205B677
		private const int k_DefaultTargetCount = 4; // Metadata: 0x0205B678
	
		// Nested types
		public enum Type // TypeDefIndex: 44661
		{
			None = 0,
			TrickleDown = 1,
			BubbleUp = 2
		}
	
		// Constructors
		public PropagationPaths() {} // 0x000000018C039F80-0x000000018C03A068
		static PropagationPaths() {} // 0x000000018C039EEC-0x000000018C039F80
	
		// Methods
		internal static PropagationPaths Copy(PropagationPaths paths) => default; // 0x000000018C039D58-0x000000018C039E34
		public static PropagationPaths Build(VisualElement elem, EventBase evt, Type pathTypesRequested) => default; // 0x000000018C039BD0-0x000000018C039D58
		public void Release() {} // 0x000000018C039E34-0x000000018C039EEC
	}

	public class CustomStyleResolvedEvent : EventBase<CustomStyleResolvedEvent> // TypeDefIndex: 44663
	{
		// Properties
		public ICustomStyle customStyle { get => default; } // 0x000000018C02ED5C-0x000000018C02EDB8 
	
		// Constructors
		public CustomStyleResolvedEvent() {} // 0x000000018C02ED08-0x000000018C02ED5C
	}

	public class TooltipEvent : EventBase<TooltipEvent> // TypeDefIndex: 44664
	{
		// Fields
		private string _tooltip_k__BackingField; // 0x80
		private Rect _rect_k__BackingField; // 0x88
	
		// Properties
		public string tooltip { get; set; } // 0x00000001873CBE98-0x00000001873CBEA8
		public Rect rect { get; set; } // 0x0000000185FD6FE0-0x0000000185FD6FF0
	
		// Constructors
		public TooltipEvent() {} // 0x000000018C03AAA0-0x000000018C03AAFC
	
		// Methods
		protected override void Init() {} // 0x000000018C03A9F4-0x000000018C03AA38
		private new void LocalInit() {} // 0x000000018C03AA38-0x000000018C03AAA0
	}

	public struct StylePropertyNameCollection : IEnumerable<StylePropertyName> // TypeDefIndex: 44666
	{
		// Fields
		internal List<StylePropertyName> propertiesList; // 0x00
	
		// Nested types
		public struct Enumerator : IEnumerator<StylePropertyName> // TypeDefIndex: 44665
		{
			// Fields
			private List<StylePropertyName> m_Enumerator; // 0x00
	
			// Properties
			public StylePropertyName Current { get => default; } // 0x000000018C03A934-0x000000018C03A994 
			object IEnumerator.Current { get => default; } // 0x000000018C03A994-0x000000018C03A9F4 
	
			// Constructors
			internal Enumerator(List<StylePropertyName> enumerator) : this() {
				m_Enumerator = default;
			} // 0x000000018646FE2C-0x000000018646FE34
	
			// Methods
			public bool MoveNext() => default; // 0x000000018C03A8A0-0x000000018C03A934
			public void Reset() {} // 0x000000018C0303D4-0x000000018C0303E8
			public void Dispose() {} // 0x000000018C030340-0x000000018C03037C
		}
	
		// Constructors
		internal StylePropertyNameCollection(List<StylePropertyName> list) {
			propertiesList = default;
		} // 0x000000018C0303E8-0x000000018C03042C
	
		// Methods
		public Enumerator GetEnumerator() => default; // 0x000000018C03037C-0x000000018C0303D4
		IEnumerator<StylePropertyName> IEnumerable<StylePropertyName>.GetEnumerator() => default; // 0x0000000185492010-0x0000000185492020
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C030318-0x000000018C030340
	}

	public abstract class TransitionEventBase<T> : EventBase<T> // TypeDefIndex: 44667
		where T : TransitionEventBase<T>, new()
	{
		// Fields
		private readonly StylePropertyNameCollection _stylePropertyNames_k__BackingField;
		private double _elapsedTime_k__BackingField;
	
		// Properties
		public StylePropertyNameCollection stylePropertyNames { get; }
		protected double elapsedTime { get; set; }
	
		// Constructors
		protected TransitionEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime) => default;
	}

	public sealed class TransitionRunEvent : TransitionEventBase<TransitionRunEvent> // TypeDefIndex: 44668
	{
		// Constructors
		public TransitionRunEvent() {} // 0x000000018C03AB74-0x000000018C03ABB0
	}

	public sealed class TransitionStartEvent : TransitionEventBase<TransitionStartEvent> // TypeDefIndex: 44669
	{
		// Constructors
		public TransitionStartEvent() {} // 0x000000018C03ABB0-0x000000018C03ABEC
	}

	public sealed class TransitionEndEvent : TransitionEventBase<TransitionEndEvent> // TypeDefIndex: 44670
	{
		// Constructors
		public TransitionEndEvent() {} // 0x000000018C03AB38-0x000000018C03AB74
	}

	public sealed class TransitionCancelEvent : TransitionEventBase<TransitionCancelEvent> // TypeDefIndex: 44671
	{
		// Constructors
		public TransitionCancelEvent() {} // 0x000000018C03AAFC-0x000000018C03AB38
	}

	public class IMGUIEvent : EventBase<IMGUIEvent> // TypeDefIndex: 44672
	{
		// Constructors
		public IMGUIEvent() {} // 0x000000018C032B24-0x000000018C032B80
	
		// Methods
		public static IMGUIEvent GetPooled(UnityEngine.Event systemEvent) => default; // 0x000000018C032A68-0x000000018C032AE0
		protected override void Init() {} // 0x000000018C032AE0-0x000000018C032B24
		private new void LocalInit() {} // 0x0000000185FE9FD0-0x0000000185FE9FE0
	}

	internal struct EventDebuggerLogCall : IDisposable // TypeDefIndex: 44673
	{
		// Constructors
		public EventDebuggerLogCall(Delegate callback, EventBase evt) {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
	}

	internal struct EventDebuggerLogIMGUICall : IDisposable // TypeDefIndex: 44674
	{
		// Constructors
		public EventDebuggerLogIMGUICall(EventBase evt) {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
	}

	internal struct EventDebuggerLogExecuteDefaultAction : IDisposable // TypeDefIndex: 44675
	{
		// Constructors
		public EventDebuggerLogExecuteDefaultAction(EventBase evt) {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class EventDebugger // TypeDefIndex: 44676
	{
		// Constructors
		public EventDebugger() {} // Dummy constructor
	
		// Methods
		public static void LogPropagationPaths(EventBase evt, PropagationPaths paths) {} // 0x0000000185492010-0x0000000185492020
	}

	internal enum DynamicAtlasFiltersInternal // TypeDefIndex: 44677
	{
		None = 0,
		Readability = 1,
		Size = 2,
		Format = 4,
		ColorSpace = 8,
		FilterMode = 16
	}

	[Serializable]
	public class DynamicAtlasSettings // TypeDefIndex: 44678
	{
		// Fields
		private int m_MinAtlasSize; // 0x10
		private int m_MaxAtlasSize; // 0x14
		private int m_MaxSubTextureSize; // 0x18
		private DynamicAtlasFiltersInternal m_ActiveFilters; // 0x1C
		private DynamicAtlasCustomFilter m_CustomFilter; // 0x20
	
		// Properties
		public int minAtlasSize { get => default; set {} } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public int maxAtlasSize { get => default; set {} } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public int maxSubTextureSize { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public DynamicAtlasFilters activeFilters { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public static DynamicAtlasFilters defaultFilters { get => default; } // 0x0000000183214D00-0x0000000183214D10 
		public DynamicAtlasCustomFilter customFilter { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public static DynamicAtlasSettings defaults { get => default; } // 0x000000018C02F0D8-0x000000018C02F148 
	
		// Constructors
		public DynamicAtlasSettings() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class NavigateFocusRing : IFocusRing // TypeDefIndex: 44681
	{
		// Fields
		public static readonly ChangeDirection Left; // 0x00
		public static readonly ChangeDirection Right; // 0x08
		public static readonly ChangeDirection Up; // 0x10
		public static readonly ChangeDirection Down; // 0x18
		public static readonly ChangeDirection Next; // 0x20
		public static readonly ChangeDirection Previous; // 0x28
		private readonly VisualElement m_Root; // 0x10
		private readonly VisualElementFocusRing m_Ring; // 0x18
	
		// Properties
		private FocusController focusController { get => default; } // 0x000000018C02E480-0x000000018C02E4D0 
	
		// Nested types
		public class ChangeDirection : FocusChangeDirection // TypeDefIndex: 44679
		{
			// Constructors
			public ChangeDirection() {} // Dummy constructor
			public ChangeDirection(int i) {} // 0x000000018BFF1CCC-0x000000018BFF1CF0
		}
	
		private struct FocusableHierarchyTraversal // TypeDefIndex: 44680
		{
			// Fields
			public VisualElement currentFocusable; // 0x00
			public Rect validRect; // 0x08
			public bool firstPass; // 0x18
			public ChangeDirection direction; // 0x20
	
			// Methods
			private bool ValidateHierarchyTraversal(VisualElement v) => default; // 0x000000018C0368BC-0x000000018C036944
			private bool ValidateElement(VisualElement v) => default; // 0x000000018C035C60-0x000000018C035FA8
			private int Order(VisualElement a, VisualElement b) => default; // 0x000000018C036478-0x000000018C036624
			private int StrictOrder(VisualElement a, VisualElement b) => default; // 0x000000018C035FA8-0x000000018C036478
			private int StrictOrder(Rect ra, Rect rb) => default; // 0x000000018C036624-0x000000018C036664
			private int TieBreaker(Rect ra, Rect rb) => default; // 0x000000018C036664-0x000000018C0366AC
			public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null) => default; // 0x000000018C0366AC-0x000000018C0368BC
		}
	
		// Constructors
		public NavigateFocusRing() {} // Dummy constructor
		public NavigateFocusRing(VisualElement root) {} // 0x000000018C032828-0x000000018C0328C8
		static NavigateFocusRing() {} // 0x000000018C032304-0x000000018C032400
	
		// Methods
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) => default; // 0x000000018C032788-0x000000018C032828
		public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) => default; // 0x000000018C032400-0x000000018C0324B0
		private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction) => default; // 0x000000018C0324B0-0x000000018C03252C
		private static bool IsActive(VisualElement v) => default; // 0x000000018C03252C-0x000000018C032678
		private static bool IsNavigable(Focusable focusable) => default; // 0x000000018C032678-0x000000018C032788
	}

	public enum PanelScaleMode // TypeDefIndex: 44682
	{
		ConstantPixelSize = 0,
		ConstantPhysicalSize = 1,
		ScaleWithScreenSize = 2
	}

	public enum PanelScreenMatchMode // TypeDefIndex: 44683
	{
		MatchWidthOrHeight = 0,
		Shrink = 1,
		Expand = 2
	}

	public class PanelSettings : ScriptableObject // TypeDefIndex: 44685
	{
		// Fields
		private const int k_DefaultSortingOrder = 0; // Metadata: 0x0205B688
		private const float k_DefaultScaleValue = 1f; // Metadata: 0x0205B689
		internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset"; // Metadata: 0x0205B68D
		private ThemeStyleSheet themeUss; // 0x18
		private RenderTexture m_TargetTexture; // 0x20
		private PanelScaleMode m_ScaleMode; // 0x28
		private float m_Scale; // 0x2C
		private const float DefaultDpi = 96f; // Metadata: 0x0205B6DD
		private float m_ReferenceDpi; // 0x30
		private float m_FallbackDpi; // 0x34
		private Vector2Int m_ReferenceResolution; // 0x38
		private PanelScreenMatchMode m_ScreenMatchMode; // 0x40
		private float m_Match; // 0x44
		private float m_SortingOrder; // 0x48
		private int m_TargetDisplay; // 0x4C
		private bool m_ClearDepthStencil; // 0x50
		private bool m_ClearColor; // 0x51
		private UnityEngine.Color m_ColorClearValue; // 0x54
		private RuntimePanelAccess m_PanelAccess; // 0x68
		internal UIDocumentList m_AttachedUIDocumentsList; // 0x70
		private DynamicAtlasSettings m_DynamicAtlasSettings; // 0x78
		private Shader m_AtlasBlitShader; // 0x80
		private Shader m_RuntimeShader; // 0x88
		private Shader m_RuntimeWorldShader; // 0x90
		public PanelTextSettings textSettings; // 0x98
		private Rect m_TargetRect; // 0xA0
		private float m_ResolvedScale; // 0xB0
		private StyleSheet m_OldThemeUss; // 0xB8
		internal int m_EmptyPanelCounter; // 0xC0
		private float _ScreenDPI_k__BackingField; // 0xC4
		private Func<Vector2, Vector2> m_AssignedScreenToPanel; // 0xC8
	
		// Properties
		public ThemeStyleSheet themeStyleSheet { get => default; set {} } // 0x0000000185FB8060-0x0000000185FB8070 0x000000018C037B08-0x000000018C037B34
		public RenderTexture targetTexture { get => default; set {} } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185FB06D0-0x0000000185FB06E0
		public PanelScaleMode scaleMode { get => default; set {} } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
		public float scale { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public float referenceDpi { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x000000018C037B60-0x000000018C037B6C
		public float fallbackDpi { get => default; set {} } // 0x000000018C0371A0-0x000000018C0371C0 0x0000000185FB06E0-0x0000000185FB06F0
		public Vector2Int referenceResolution { get => default; set {} } // 0x000000018C037B6C-0x000000018C037B90 0x00000001813ECBE0-0x00000001813ECBF0
		public PanelScreenMatchMode screenMatchMode { get => default; set {} } // 0x00000001813EE9A0-0x00000001813EE9B0 0x0000000185FEA010-0x0000000185FEA020
		public float match { get => default; set {} } // 0x00000001813AF340-0x00000001813AF350 0x00000001813AF350-0x00000001813AF360
		public float sortingOrder { get => default; set {} } // 0x0000000185FEA000-0x0000000185FEA010 0x0000000185FEA020-0x0000000185FEA030
		public int targetDisplay { get => default; set {} } // 0x000000018C037AD8-0x000000018C037B08 0x0000000183060C50-0x0000000183060C60
		public bool clearDepthStencil { get => default; set {} } // 0x000000018738A324-0x000000018738A334 0x000000018C0379D0-0x000000018C037AB8
		public float depthClearValue { get => default; } // 0x0000000185492010-0x0000000185492020 
		public bool clearColor { get => default; set {} } // 0x000000018C0377A4-0x000000018C037878 0x000000018C037450-0x000000018C037470
		public UnityEngine.Color colorClearValue { get => default; set {} } // 0x000000018C037450-0x000000018C037470 0x0000000185FB9CA0-0x0000000185FB9CB0
		internal BaseRuntimePanel panel { get => default; } // 0x0000000185FCA210-0x0000000185FCA220 
		internal VisualElement visualTree { get => default; } // 0x000000018C0379B0-0x000000018C0379D0 
		public DynamicAtlasSettings dynamicAtlasSettings { get => default; set {} } // 0x000000018C0371C0-0x000000018C037320 0x000000018C03763C-0x000000018C0377A4
		private float ScreenDPI { get; set; } // 0x000000018C0373D4-0x000000018C037450 0x0000000184096E30-0x0000000184096EF0
	
		// Nested types
		private class RuntimePanelAccess // TypeDefIndex: 44684
		{
			// Fields
			private readonly PanelSettings m_Settings; // 0x10
			private BaseRuntimePanel m_RuntimePanel; // 0x18
	
			// Properties
			internal bool isInitialized { get => default; } // 0x000000018C037BC0-0x000000018C037BE8 
			internal BaseRuntimePanel panel { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
	
			// Constructors
			public RuntimePanelAccess() {} // Dummy constructor
			internal RuntimePanelAccess(PanelSettings settings) {} // 0x0000000185FC2A70-0x0000000185FC2A80
	
			// Methods
			internal void DisposePanel() {} // 0x000000018C037B90-0x000000018C037BC0
			internal void SetTargetTexture() {} // 0x0000000181C9AC80-0x0000000181C9AC90
			internal void SetSortingPriority() {} // 0x0000000181C9A5C0-0x0000000181C9A5D0
			internal void SetTargetDisplay() {} // 0x0000000185FB09A0-0x0000000185FB09B0
			private BaseRuntimePanel CreateRelatedRuntimePanel() => default; // 0x0000000185FB09B0-0x0000000185FB09C0
			private void DisposeRelatedPanel() {} // 0x0000000185FB0BE0-0x0000000185FB0BF0
			internal void MarkPotentiallyEmpty() {} // 0x000000018C037B34-0x000000018C037B60
		}
	
		// Constructors
		private PanelSettings() {} // 0x000000018C036D30-0x000000018C0371A0
	
		// Methods
		internal void ApplySortingOrder() {} // 0x000000018C037AB8-0x000000018C037AD8
		private void Reset() {} // 0x000000018C037968-0x000000018C0379B0
		private void OnEnable() {} // 0x000000018C037878-0x000000018C037968
		private void OnDisable() {} // 0x000000018C037470-0x000000018C03763C
		internal void DisposePanel() {} // 0x000000018C037320-0x000000018C0373D4
		internal void UpdateScreenDPI() {} // 0x00000001847EB9E0-0x00000001847EB9F0
		private void ApplyThemeStyleSheet(VisualElement root = null) {} // 0x000000018C03A43C-0x000000018C03A5BC
		private void InitializeShaders() {} // 0x000000018C03A2D0-0x000000018C03A304
		internal void ApplyPanelSettings() {} // 0x000000018C03A400-0x000000018C03A43C
		public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction) {} // 0x000000018C03A3A4-0x000000018C03A3D4
		internal float ResolveScale(Rect targetRect, float screenDpi) => default; // 0x000000018C03A3D4-0x000000018C03A400
		internal Rect GetDisplayRect() => default; // 0x000000018C03A21C-0x000000018C03A2D0
		internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) {} // 0x000000018C03A304-0x000000018C03A354
		internal void DetachUIDocument(UIDocument uiDocument) {} // 0x000000018C03A354-0x000000018C03A3A4
	}

	internal static class RuntimeEventDispatcher // TypeDefIndex: 44686
	{
		// Methods
		public static EventDispatcher Create() => default; // 0x000000018C03A068-0x000000018C03A21C
	}

	internal class RuntimePanel : BaseRuntimePanel // TypeDefIndex: 44687
	{
		// Fields
		internal static readonly EventDispatcher s_EventDispatcher; // 0x00
		private readonly PanelSettings m_PanelSettings; // 0x1D8
	
		// Properties
		public PanelSettings panelSettings { get => default; } // 0x0000000185FB1760-0x0000000185FB1770 
	
		// Constructors
		public RuntimePanel() {} // Dummy constructor
		private RuntimePanel(ScriptableObject ownerObject) {} // 0x000000018C03A6E8-0x000000018C03A8A0
		static RuntimePanel() {} // 0x000000018C03A698-0x000000018C03A6E8
	
		// Methods
		public static RuntimePanel Create(ScriptableObject ownerObject) => default; // 0x000000018C03A5BC-0x000000018C03A61C
		public override void Update() {} // 0x000000018C03A61C-0x000000018C03A698
	}

	internal class UIDocumentList // TypeDefIndex: 44688
	{
		// Fields
		internal List<UIDocument> m_AttachedUIDocuments; // 0x10
	
		// Constructors
		public UIDocumentList() {} // 0x000000018C03C29C-0x000000018C03C314
	
		// Methods
		internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument) {} // 0x000000018C03C230-0x000000018C03C29C
		internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex = 0 /* Metadata: 0x0205B6E1 */) {} // 0x000000018C03BF18-0x000000018C03C230
	}

	public sealed class UIDocument : MonoBehaviour // TypeDefIndex: 44689
	{
		// Fields
		internal const string k_RootStyleClassName = "unity-ui-document__root"; // Metadata: 0x0205B6E2
		internal const string k_VisualElementNameSuffix = "-container"; // Metadata: 0x0205B6FA
		private const int k_DefaultSortingOrder = 0; // Metadata: 0x0205B705
		private static int s_CurrentUIDocumentCounter; // 0x00
		internal readonly int m_UIDocumentCreationIndex; // 0x18
		private PanelSettings m_PanelSettings; // 0x20
		private PanelSettings m_PreviousPanelSettings; // 0x28
		private UIDocument m_ParentUI; // 0x30
		private UIDocumentList m_ChildrenContent; // 0x38
		private List<UIDocument> m_ChildrenContentCopy; // 0x40
		private VisualTreeAsset sourceAsset; // 0x48
		private VisualElement m_RootVisualElement; // 0x50
		private int m_FirstChildInsertIndex; // 0x58
		private float m_SortingOrder; // 0x5C
	
		// Properties
		public PanelSettings panelSettings { get => default; set {} } // 0x0000000185FE66B0-0x0000000185FE66C0 0x000000018C03D008-0x000000018C03D30C
		public UIDocument parentUI { get => default; private set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public VisualTreeAsset visualTreeAsset { get => default; set {} } // 0x0000000185FE8BF0-0x0000000185FE8C00 0x000000018C03D328-0x000000018C03D34C
		public VisualElement rootVisualElement { get => default; } // 0x0000000185FE8C70-0x0000000185FE8C80 
		internal int firstChildInserIndex { get => default; } // 0x0000000183F80450-0x0000000183F80460 
		public float sortingOrder { get => default; set {} } // 0x0000000185FB89D0-0x0000000185FB89E0 0x000000018C03D30C-0x000000018C03D328
	
		// Constructors
		private UIDocument() {} // 0x000000018C03CF88-0x000000018C03D008
	
		// Methods
		internal void ApplySortingOrder() {} // 0x000000018C03C474-0x000000018C03C47C
		private void Awake() {} // 0x000000018C03C47C-0x000000018C03C484
		private void OnEnable() {} // 0x000000018C03C560-0x000000018C03C610
		private void SetupFromHierarchy() {} // 0x000000018C03CE84-0x000000018C03CF0C
		private UIDocument FindUIDocumentParent() => default; // 0x000000018C03C484-0x000000018C03C52C
		internal void Reset() {} // 0x000000018C03CD94-0x000000018C03CE84
		private void AddChildAndInsertContentToVisualTree(UIDocument child) {} // 0x000000018C03C314-0x000000018C03C3C0
		private void RemoveChild(UIDocument child) {} // 0x000000018C03CCD8-0x000000018C03CCEC
		private void RecreateUI() {} // 0x000000018C03C8A4-0x000000018C03CCD8
		private void SetupRootClassList() {} // 0x000000018C03CF0C-0x000000018C03CF88
		private void AddRootVisualElementToTree() {} // 0x000000018C03C3C0-0x000000018C03C474
		private void RemoveFromHierarchy() {} // 0x000000018C03CCEC-0x000000018C03CD94
		private void OnDisable() {} // 0x000000018C03C52C-0x000000018C03C560
		private void OnTransformChildrenChanged() {} // 0x000000018C03C610-0x000000018C03C7FC
		private void OnTransformParentChanged() {} // 0x000000018C03C7FC-0x000000018C03C804
		internal void ReactToHierarchyChanged() {} // 0x000000018C03C804-0x000000018C03C8A4
	}

	internal class UIRAtlasAllocator : IDisposable // TypeDefIndex: 44692
	{
		// Fields
		private readonly int _maxAtlasSize_k__BackingField; // 0x10
		private readonly int _maxImageWidth_k__BackingField; // 0x14
		private readonly int _maxImageHeight_k__BackingField; // 0x18
		private int _virtualWidth_k__BackingField; // 0x1C
		private int _virtualHeight_k__BackingField; // 0x20
		private int _physicalWidth_k__BackingField; // 0x24
		private int _physicalHeight_k__BackingField; // 0x28
		private AreaNode m_FirstUnpartitionedArea; // 0x30
		private Row[] m_OpenRows; // 0x38
		private int m_1SidePadding; // 0x40
		private int m_2SidePadding; // 0x44
		private static ProfilerMarker s_MarkerTryAllocate; // 0x00
		private bool _disposed_k__BackingField; // 0x48
	
		// Properties
		public int maxAtlasSize { get; } // 0x000000018C03D530-0x000000018C03D824 
		public int maxImageWidth { get; } // 0x000000018C03D824-0x000000018C03D9B0 
		public int maxImageHeight { get; } // 0x000000018C03D34C-0x000000018C03D424 
		public int virtualWidth { get; private set; } // 0x000000018C03D9B0-0x000000018C03DA10 0x0000000181C0BBD0-0x0000000181C0BBE0
		public int virtualHeight { get; private set; } // 0x0000000181378230-0x0000000181378240 0x0000000185FB21A0-0x0000000185FB21B0
		public int physicalWidth { get; private set; } // 0x0000000185FBB0B0-0x0000000185FBB0C0 0x00000001813AE560-0x00000001813AE570
		public int physicalHeight { get; private set; } // 0x00000001813AE9C0-0x00000001813AE9D0 0x00000001813AE9D0-0x00000001813AE9E0
		protected bool disposed { get; private set; } // 0x000000018C0566A8-0x000000018C05674C 0x000000018C05674C-0x000000018C0567CC
	
		// Nested types
		private class Row // TypeDefIndex: 44690
		{
			// Fields
			private static ObjectPool<Row> s_Pool; // 0x00
			private int _offsetX_k__BackingField; // 0x10
			private int _offsetY_k__BackingField; // 0x14
			private int _width_k__BackingField; // 0x18
			private int _height_k__BackingField; // 0x1C
			public int Cursor; // 0x20
	
			// Properties
			public int offsetX { get; private set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000185FB21A0-0x0000000185FB21B0
			public int offsetY { get; private set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE570-0x00000001813AE580
			public int width { get; private set; } // 0x00000001813AE9D0-0x00000001813AE9E0 0x00000001813B88B0-0x00000001813B88C0
			private int height { get; set; } // 0x00000001813B9430-0x00000001813B9440
	
			// Constructors
			public Row() {} // 0x0000000181C9AC80-0x0000000181C9AC90
			static Row() {} // 0x0000000181C9A5C0-0x0000000181C9A5D0
	
			// Methods
			public static Row Acquire(int offsetX, int offsetY, int width, int height) => default; // 0x0000000181424480-0x0000000181424490
			public void Release() {} // 0x0000000181424940-0x0000000181424950
		}
	
		private class AreaNode // TypeDefIndex: 44691
		{
			// Fields
			private static ObjectPool<AreaNode> s_Pool; // 0x00
			public RectInt rect; // 0x10
			public AreaNode previous; // 0x20
			public AreaNode next; // 0x28
	
			// Constructors
			public AreaNode() {} // 0x000000018C03D508-0x000000018C03D530
			static AreaNode() {} // 0x000000018C03DA10-0x000000018C03DB8C
	
			// Methods
			public static AreaNode Acquire(RectInt rect) => default; // 0x0000000185FB0750-0x0000000185FB0760
			public void Release() {} // 0x0000000185FB0770-0x0000000185FB0780
			public void RemoveFromChain() {} // 0x000000018C03D4B8-0x000000018C03D508
			public void AddAfter(AreaNode previous) {} // 0x000000018C03D424-0x000000018C03D4B8
		}
	
		// Constructors
		public UIRAtlasAllocator() {} // Dummy constructor
		public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1 /* Metadata: 0x0205B706 */) {} // 0x000000018C04D554-0x000000018C04D5C4
		static UIRAtlasAllocator() {} // 0x000000018C04D624-0x000000018C04D6B8
	
		// Methods
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void Dispose(bool disposing) {} // 0x000000018C0567CC-0x000000018C056860
		private static int GetLog2OfNextPower(int n) => default; // 0x000000018C04D3F4-0x000000018C04D490
		public bool TryAllocate(int width, int height, out RectInt location) {
			location = default;
			return default;
		} // 0x000000018C04D5C4-0x000000018C04D624
		private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) => default; // 0x000000018C04D490-0x000000018C04D554
		private void BuildAreas() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DynamicAtlasPage : IDisposable // TypeDefIndex: 44693
	{
		// Fields
		private TextureId _textureId_k__BackingField; // 0x10
		private RenderTexture _atlas_k__BackingField; // 0x18
		private readonly RenderTextureFormat _format_k__BackingField; // 0x20
		private readonly UnityEngine.FilterMode _filterMode_k__BackingField; // 0x24
		private readonly Vector2Int _minSize_k__BackingField; // 0x28
		private readonly Vector2Int _maxSize_k__BackingField; // 0x30
		private readonly int m_1Padding; // 0x38
		private readonly int m_2Padding; // 0x3C
		private Allocator2D m_Allocator; // 0x40
		private TextureBlitter m_Blitter; // 0x48
		private Vector2Int m_CurrentSize; // 0x50
		private static int s_TextureCounter; // 0x00
		private bool _disposed_k__BackingField; // 0x58
	
		// Properties
		public TextureId textureId { get; private set; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x0000000181378230-0x0000000181378240
		public RenderTexture atlas { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public RenderTextureFormat format { get; } // 0x00000001813B88B0-0x00000001813B88C0 
		public UnityEngine.FilterMode filterMode { get; } // 0x0000000181424480-0x0000000181424490 
		protected bool disposed { get; private set; } // 0x0000000181BE64B0-0x0000000181BE64C0 0x0000000181BE64C0-0x0000000181BE64D0
	
		// Constructors
		public DynamicAtlasPage() {} // Dummy constructor
		public DynamicAtlasPage(RenderTextureFormat format, UnityEngine.FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize) {} // 0x000000018C050728-0x000000018C050854
	
		// Methods
		public void Dispose() {} // 0x000000018C04FFE4-0x000000018C050034
		protected virtual void Dispose(bool disposing) {} // 0x000000018C04FE80-0x000000018C04FFE4
		public bool TryAdd(Texture2D image, out Allocator2D.Alloc2D alloc, out RectInt rect) {
			alloc = default;
			rect = default;
			return default;
		} // 0x000000018C0500E8-0x000000018C0502B4
		public void Update(Texture2D image, RectInt rect) {} // 0x000000018C0505D8-0x000000018C050728
		public void Remove(Allocator2D.Alloc2D alloc) {} // 0x000000018C050034-0x000000018C0500E8
		public void Commit() {} // 0x000000018C04FD24-0x000000018C04FD64
		private void UpdateAtlasTexture() {} // 0x000000018C0502B4-0x000000018C0505D8
		private RenderTexture CreateAtlasTexture() => default; // 0x000000018C04FD64-0x000000018C04FE80
	}

	internal class UIRLayoutUpdater : BaseVisualTreeUpdater // TypeDefIndex: 44694
	{
		// Fields
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
		private List<KeyValuePair<Rect, VisualElement>> changeEventsList; // 0x20
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x000000018C05B038-0x000000018C05B088 
	
		// Constructors
		public UIRLayoutUpdater() {} // 0x000000018C05AFC0-0x000000018C05B038
		static UIRLayoutUpdater() {} // 0x000000018C05AF2C-0x000000018C05AFC0
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018C05A868-0x000000018C05A8A0
		public override void Update() {} // 0x000000018C05AD64-0x000000018C05AF2C
		private void UpdateSubTree(VisualElement ve, bool isDisplayed, List<KeyValuePair<Rect, VisualElement>> changeEvents) {} // 0x000000018C05A8A0-0x000000018C05AD64
		private void DispatchChangeEvents(List<KeyValuePair<Rect, VisualElement>> changeEvents, int currentLayoutPass) {} // 0x000000018C05A5FC-0x000000018C05A868
	}

	public struct Vertex // TypeDefIndex: 44695
	{
		// Fields
		public static readonly float nearZ; // 0x00
		public Vector3 position; // 0x00
		public Color32 tint; // 0x0C
		public Vector2 uv; // 0x10
		internal Color32 xformClipPages; // 0x18
		internal Color32 ids; // 0x1C
		internal Color32 flags; // 0x20
		internal Color32 opacityColorPages; // 0x24
		internal Vector4 circle; // 0x28
		internal float textureId; // 0x38
	}

	public class MeshWriteData // TypeDefIndex: 44696
	{
		// Fields
		internal NativeSlice<UnityEngine.UIElements.Vertex> m_Vertices; // 0x10
		internal NativeSlice<ushort> m_Indices; // 0x20
		internal Rect m_UVRegion; // 0x30
		internal int currentIndex; // 0x40
		internal int currentVertex; // 0x44
	
		// Properties
		public int vertexCount { get => default; } // 0x000000018C05476C-0x000000018C0547A0 
		public int indexCount { get => default; } // 0x000000018C054738-0x000000018C05476C 
		public Rect uvRegion { get => default; } // 0x0000000185FE8740-0x0000000185FE8750 
	
		// Constructors
		internal MeshWriteData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void SetNextVertex(UnityEngine.UIElements.Vertex vertex) {} // 0x000000018C0546B4-0x000000018C054738
		public void SetNextIndex(ushort index) {} // 0x000000018C054660-0x000000018C0546B4
		public void SetAllVertices(UnityEngine.UIElements.Vertex[] vertices) {} // 0x000000018C0545A8-0x000000018C054660
		public void SetAllIndices(ushort[] indices) {} // 0x000000018C0544F0-0x000000018C0545A8
		internal void Reset(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices) {} // 0x0000000185FEA090-0x0000000185FEA0C0
		internal void Reset(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices, Rect uvRegion) {} // 0x0000000185FEA0C0-0x0000000185FEA0E0
	}

	internal struct ColorPage // TypeDefIndex: 44697
	{
		// Fields
		public bool isValid; // 0x00
		public Color32 pageAndID; // 0x04
	
		// Methods
		public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc) => default; // 0x000000018C04DF38-0x000000018C04DFDC
	}

	internal static class MeshGenerationContextUtils // TypeDefIndex: 44701
	{
		// Nested types
		public struct BorderParams // TypeDefIndex: 44698
		{
			// Fields
			public Rect rect; // 0x00
			public UnityEngine.Color playmodeTintColor; // 0x10
			public UnityEngine.Color leftColor; // 0x20
			public UnityEngine.Color topColor; // 0x30
			public UnityEngine.Color rightColor; // 0x40
			public UnityEngine.Color bottomColor; // 0x50
			public float leftWidth; // 0x60
			public float topWidth; // 0x64
			public float rightWidth; // 0x68
			public float bottomWidth; // 0x6C
			public Vector2 topLeftRadius; // 0x70
			public Vector2 topRightRadius; // 0x78
			public Vector2 bottomRightRadius; // 0x80
			public Vector2 bottomLeftRadius; // 0x88
			public Material material; // 0x90
			internal ColorPage leftColorPage; // 0x98
			internal ColorPage topColorPage; // 0xA0
			internal ColorPage rightColorPage; // 0xA8
			internal ColorPage bottomColorPage; // 0xB0
		}
	
		public struct RectangleParams // TypeDefIndex: 44699
		{
			// Fields
			public Rect rect; // 0x00
			public Rect uv; // 0x10
			public UnityEngine.Color color; // 0x20
			public Texture texture; // 0x30
			public Sprite sprite; // 0x38
			public VectorImage vectorImage; // 0x40
			public Material material; // 0x48
			public UnityEngine.ScaleMode scaleMode; // 0x50
			public UnityEngine.Color playmodeTintColor; // 0x54
			public Vector2 topLeftRadius; // 0x64
			public Vector2 topRightRadius; // 0x6C
			public Vector2 bottomRightRadius; // 0x74
			public Vector2 bottomLeftRadius; // 0x7C
			public int leftSlice; // 0x84
			public int topSlice; // 0x88
			public int rightSlice; // 0x8C
			public int bottomSlice; // 0x90
			public float sliceScale; // 0x94
			internal Rect spriteGeomRect; // 0x98
			public Vector4 rectInset; // 0xA8
			internal ColorPage colorPage; // 0xB8
			internal MeshGenerationContext.MeshFlags meshFlags; // 0xC0
	
			// Methods
			private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, UnityEngine.ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) {
				rectOut = default;
				uvOut = default;
			} // 0x000000018C0542FC-0x000000018C0543B4
			private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, UnityEngine.ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) {
				rectOut = default;
				uvOut = default;
			} // 0x000000018C0543B4-0x000000018C0544F0
			private static Rect RectIntersection(Rect a, Rect b) => default; // 0x000000018C054140-0x000000018C0541A0
			private static Rect ComputeGeomRect(Sprite sprite) => default; // 0x000000018C0541A0-0x000000018C0542FC
			private static Rect ComputeUVRect(Sprite sprite) => default; // 0x000000018C054038-0x000000018C054140
			private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) => default; // 0x000000018C054F48-0x000000018C055150
			public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, UnityEngine.ScaleMode scaleMode, ContextType panelContext) => default; // 0x000000018C0547A0-0x000000018C054F48
			public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, UnityEngine.ScaleMode scaleMode, ContextType panelContext, bool hasRadius, ref Vector4 slices) => default; // 0x000000018C05611C-0x000000018C056270
			public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, UnityEngine.ScaleMode scaleMode, ContextType panelContext) => default; // 0x000000018C055300-0x000000018C055444
			internal bool HasRadius(float epsilon) => default; // 0x000000018C055444-0x000000018C055588
		}
	
		public struct TextParams // TypeDefIndex: 44700
		{
			// Fields
			public Rect rect; // 0x00
			public string text; // 0x10
			public Font font; // 0x18
			public FontDefinition fontDefinition; // 0x20
			public int fontSize; // 0x30
			public Length letterSpacing; // 0x34
			public Length wordSpacing; // 0x3C
			public Length paragraphSpacing; // 0x44
			public FontStyle fontStyle; // 0x4C
			public UnityEngine.Color fontColor; // 0x50
			public TextAnchor anchor; // 0x60
			public bool wordWrap; // 0x64
			public float wordWrapWidth; // 0x68
			public bool richText; // 0x6C
			public UnityEngine.Color playmodeTintColor; // 0x70
			public TextOverflow textOverflow; // 0x80
			public TextOverflowPosition textOverflowPosition; // 0x84
			public OverflowInternal overflow; // 0x88
			public IPanel panel; // 0x90
	
			// Methods
			public override int GetHashCode() => default; // 0x000000018C055150-0x000000018C055300
			internal static TextParams MakeStyleBased(VisualElement ve, string text) => default; // 0x000000018C055DE0-0x000000018C055F98
			internal static TextNativeSettings GetTextNativeSettings(TextParams textParams, float scaling) => default; // 0x000000018C0555E8-0x000000018C055DE0
		}
	
		// Methods
		public static void Rectangle(MeshGenerationContext mgc, RectangleParams rectParams) {} // 0x000000018C055F98-0x000000018C05611C
		public static void Text(MeshGenerationContext mgc, TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x000000018C055588-0x000000018C0555E8
		private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) => default; // 0x000000018C058690-0x000000018C058864
		public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) {
			topLeft = default;
			bottomLeft = default;
			topRight = default;
			bottomRight = default;
		} // 0x000000018C058C5C-0x000000018C058F94
		public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams) {} // 0x000000018C058864-0x000000018C058C5C
	}

	public class MeshGenerationContext // TypeDefIndex: 44703
	{
		// Fields
		internal IStylePainter painter; // 0x10
	
		// Nested types
		internal enum MeshFlags // TypeDefIndex: 44702
		{
			None = 0,
			UVisDisplacement = 1,
			SkipDynamicAtlas = 2
		}
	
		// Constructors
		public MeshGenerationContext() {} // Dummy constructor
		internal MeshGenerationContext(IStylePainter painter) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal class UIRRepaintUpdater : BaseVisualTreeUpdater // TypeDefIndex: 44704
	{
		// Fields
		private BaseVisualElementPanel attachedPanel; // 0x20
		internal RenderChain renderChain; // 0x28
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
		private bool _drawStats_k__BackingField; // 0x30
		private bool _breakBatches_k__BackingField; // 0x31
		private bool _disposed_k__BackingField; // 0x32
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x000000018C05BEA4-0x000000018C05BEF4 
		public bool drawStats { get; } // 0x00000001814294C0-0x00000001814294D0 
		public bool breakBatches { get; } // 0x0000000185FB0980-0x0000000185FB0990 
		protected bool disposed { get; private set; } // 0x0000000185FB0C40-0x0000000185FB0C50 0x0000000185FB0C50-0x0000000185FB0C60
	
		// Constructors
		public UIRRepaintUpdater() {} // 0x000000018C05BE28-0x000000018C05BEA4
		static UIRRepaintUpdater() {} // 0x000000018C05BD28-0x000000018C05BE28
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018C05BA20-0x000000018C05BB60
		public override void Update() {} // 0x000000018C05BBF0-0x000000018C05BD28
		protected virtual RenderChain CreateRenderChain() => default; // 0x000000018C05B260-0x000000018C05B2C4
		private static void OnGraphicsResourcesRecreate(bool recreate) {} // 0x000000018C05B598-0x000000018C05B6F0
		private void OnPanelChanged(BaseVisualElementPanel obj) {} // 0x000000018C05B6F8-0x000000018C05B718
		private void AttachToPanel() {} // 0x000000018C05B088-0x000000018C05B260
		private void DetachFromPanel() {} // 0x000000018C05B31C-0x000000018C05B4D4
		private void InitRenderChain() {} // 0x000000018C05B4F8-0x000000018C05B598
		internal void DestroyRenderChain() {} // 0x000000018C05B2C4-0x000000018C05B31C
		private void OnPanelAtlasChanged() {} // 0x000000018C05B6F0-0x000000018C05B6F8
		private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) {} // 0x000000018C05B718-0x000000018C05B778
		private void OnPanelStandardShaderChanged() {} // 0x000000018C05B778-0x000000018C05B8CC
		private void OnPanelStandardWorldSpaceShaderChanged() {} // 0x000000018C05B8CC-0x000000018C05BA20
		private void ResetAllElementsDataRecursive(VisualElement ve) {} // 0x000000018C05BB60-0x000000018C05BBF0
		protected override void Dispose(bool disposing) {} // 0x000000018C05B4D4-0x000000018C05B4F8
	}

	internal struct TextureId // TypeDefIndex: 44705
	{
		// Fields
		private readonly int m_Index; // 0x00
		public static readonly TextureId invalid; // 0x00
	
		// Properties
		public int index { get => default; } // 0x0000000185FBC820-0x0000000185FBC830 
	
		// Constructors
		public TextureId(int index) : this() {
			m_Index = default;
		} // 0x0000000185FBC830-0x0000000185FBC840
		static TextureId() {
			invalid = default;
		} // 0x000000018C059050-0x000000018C05908C
	
		// Methods
		public float ConvertToGpu() => default; // 0x000000018C058F94-0x000000018C058FE0
		public override bool Equals(object obj) => default; // 0x000000018C058FE0-0x000000018C059050
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public static bool operator ==(TextureId left, TextureId right) => default; // 0x0000000188645D08-0x0000000188645D10
		public static bool operator !=(TextureId left, TextureId right) => default; // 0x000000018C05908C-0x000000018C0590D4
	}

	internal class TextureRegistry // TypeDefIndex: 44707
	{
		// Fields
		private List<TextureInfo> m_Textures; // 0x10
		private Dictionary<Texture, TextureId> m_TextureToId; // 0x18
		private Stack<TextureId> m_FreeIds; // 0x20
		internal const int maxTextures = 2048; // Metadata: 0x0205B70A
		private static readonly TextureRegistry _instance_k__BackingField; // 0x00
	
		// Properties
		public static TextureRegistry instance { get; } // 0x000000018C059C74-0x000000018C059CC4 
	
		// Nested types
		private struct TextureInfo // TypeDefIndex: 44706
		{
			// Fields
			public Texture texture; // 0x00
			public bool dynamic; // 0x08
			public int refCount; // 0x0C
		}
	
		// Constructors
		public TextureRegistry() {} // 0x000000018C059B60-0x000000018C059C74
		static TextureRegistry() {} // 0x000000018C059AF0-0x000000018C059B60
	
		// Methods
		public Texture GetTexture(TextureId id) => default; // 0x000000018C05950C-0x000000018C05968C
		public TextureId AllocAndAcquireDynamic() => default; // 0x000000018C059244-0x000000018C059254
		public void UpdateDynamic(TextureId id, Texture texture) {} // 0x000000018C0598D4-0x000000018C059AF0
		private TextureId AllocAndAcquire(Texture texture, bool dynamic) => default; // 0x000000018C059254-0x000000018C05950C
		public TextureId Acquire(Texture tex) => default; // 0x000000018C0590D4-0x000000018C059244
		public void Release(TextureId id) {} // 0x000000018C05968C-0x000000018C0598D4
	}

	internal static class UIRUtility // TypeDefIndex: 44708
	{
		// Fields
		public static readonly string k_DefaultShaderName; // 0x00
		public static readonly string k_DefaultWorldSpaceShaderName; // 0x08
	
		// Constructors
		static UIRUtility() {} // 0x000000018C05C118-0x000000018C05C640
	
		// Methods
		public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef) => default; // 0x000000018C05C0AC-0x000000018C05C118
		public static bool IsRoundRect(VisualElement ve) => default; // 0x000000018C05BFD0-0x000000018C05C034
		public static bool IsVectorImageBackground(VisualElement ve) => default; // 0x000000018C05C034-0x000000018C05C0AC
		public static bool IsElementSelfHidden(VisualElement ve) => default; // 0x000000018C05BFB0-0x000000018C05BFD0
		public static void Destroy(UnityEngine.Object obj) {} // 0x000000018C05BEF4-0x000000018C05BF74
		public static int GetPrevPow2(int n) => default; // 0x000000018C05BF98-0x000000018C05BFB0
		public static int GetNextPow2(int n) => default; // 0x000000018C05BF88-0x000000018C05BF98
		public static int GetNextPow2Exp(int n) => default; // 0x000000018C05BF74-0x000000018C05BF88
	}

	public enum AngleUnit // TypeDefIndex: 44709
	{
		Degree = 0,
		Gradian = 1,
		Radian = 2,
		Turn = 3
	}

	public struct Angle : IEquatable<Angle> // TypeDefIndex: 44711
	{
		// Fields
		private float m_Value; // 0x00
		private Unit m_Unit; // 0x04
	
		// Properties
		public float value { get => default; } // 0x0000000185FB0F90-0x0000000185FB0FA0 
	
		// Nested types
		private enum Unit // TypeDefIndex: 44710
		{
			Degree = 0,
			Gradian = 1,
			Radian = 2,
			Turn = 3,
			None = 4
		}
	
		// Constructors
		public Angle(float value, AngleUnit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000185FB0F70-0x0000000185FB0F80
		private Angle(float value, Unit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000185FB0F70-0x0000000185FB0F80
	
		// Methods
		internal static Angle None() => default; // 0x0000000185FEA050-0x0000000185FEA070
		public float ToDegrees() => default; // 0x000000018C04D230-0x000000018C04D288
		public static implicit operator Angle(float value) => default; // 0x0000000185FEA070-0x0000000185FEA090
		public static bool operator ==(Angle lhs, Angle rhs) => default; // 0x000000018C04D3C8-0x000000018C04D3F4
		public bool Equals(Angle other) => default; // 0x000000018C04D1FC-0x000000018C04D210
		public override bool Equals(object obj) => default; // 0x000000018C04D18C-0x000000018C04D1FC
		public override int GetHashCode() => default; // 0x000000018C04D210-0x000000018C04D230
		public override string ToString() => default; // 0x000000018C04D288-0x000000018C04D3C8
	}

	public struct Background : IEquatable<Background> // TypeDefIndex: 44712
	{
		// Fields
		private Texture2D m_Texture; // 0x00
		private Sprite m_Sprite; // 0x08
		private RenderTexture m_RenderTexture; // 0x10
		private VectorImage m_VectorImage; // 0x18
	
		// Properties
		public Texture2D texture { get => default; set {} } // 0x0000000184142CB0-0x0000000184142CC0 0x000000018C04DE08-0x000000018C04DEA0
		public Sprite sprite { get => default; set {} } // 0x0000000185FE6720-0x0000000185FE6730 0x000000018C04DD70-0x000000018C04DE08
		public RenderTexture renderTexture { get => default; set {} } // 0x0000000185FC7990-0x0000000185FC79A0 0x000000018C04DCD8-0x000000018C04DD70
		public VectorImage vectorImage { get => default; set {} } // 0x0000000185FC2A70-0x0000000185FC2A80 0x000000018C04DEA0-0x000000018C04DF38
	
		// Methods
		public static Background FromTexture2D(Texture2D t) => default; // 0x000000018C04D9BC-0x000000018C04DA00
		public static Background FromRenderTexture(RenderTexture rt) => default; // 0x000000018C04D934-0x000000018C04D978
		public static Background FromSprite(Sprite s) => default; // 0x000000018C04D978-0x000000018C04D9BC
		public static Background FromVectorImage(VectorImage vi) => default; // 0x000000018C04DA00-0x000000018C04DA44
		internal static Background FromObject(object obj) => default; // 0x000000018C04D78C-0x000000018C04D934
		public static bool operator ==(Background lhs, Background rhs) => default; // 0x000000018C04DBDC-0x000000018C04DC9C
		public static bool operator !=(Background lhs, Background rhs) => default; // 0x000000018C04DC9C-0x000000018C04DCD8
		public bool Equals(Background other) => default; // 0x000000018C04D74C-0x000000018C04D78C
		public override bool Equals(object obj) => default; // 0x000000018C04D6B8-0x000000018C04D74C
		public override int GetHashCode() => default; // 0x000000018C04DA44-0x000000018C04DAE0
		public override string ToString() => default; // 0x000000018C04DAE0-0x000000018C04DBDC
	}

	internal struct ComputedStyle // TypeDefIndex: 44713
	{
		// Fields
		public StyleDataRef<InheritedData> inheritedData; // 0x00
		public StyleDataRef<UnityEngine.UIElements.LayoutData> layoutData; // 0x08
		public StyleDataRef<RareData> rareData; // 0x10
		public StyleDataRef<UnityEngine.UIElements.TransformData> transformData; // 0x18
		public StyleDataRef<TransitionData> transitionData; // 0x20
		public StyleDataRef<VisualData> visualData; // 0x28
		public YogaNode yogaNode; // 0x30
		public Dictionary<string, StylePropertyValue> customProperties; // 0x38
		public long matchingRulesHash; // 0x40
		public float dpiScaling; // 0x48
		public ComputedTransitionProperty[] computedTransitions; // 0x50
	
		// Properties
		public int customPropertiesCount { get => default; } // 0x000000018C04BCBC-0x000000018C04BD04 
		public bool hasTransition { get => default; } // 0x000000018C04BEC4-0x000000018C04BED8 
		public Align alignContent { get => default; } // 0x000000018C04B70C-0x000000018C04B74C 
		public Align alignItems { get => default; } // 0x000000018C04B74C-0x000000018C04B78C 
		public Align alignSelf { get => default; } // 0x000000018C04B78C-0x000000018C04B7CC 
		public UnityEngine.Color backgroundColor { get => default; } // 0x000000018C04B7CC-0x000000018C04B81C 
		public Background backgroundImage { get => default; } // 0x000000018C04B81C-0x000000018C04B878 
		public UnityEngine.Color borderBottomColor { get => default; } // 0x000000018C04B878-0x000000018C04B8CC 
		public Length borderBottomLeftRadius { get => default; } // 0x000000018C04B8CC-0x000000018C04B90C 
		public Length borderBottomRightRadius { get => default; } // 0x000000018C04B90C-0x000000018C04B94C 
		public float borderBottomWidth { get => default; } // 0x000000018C04B94C-0x000000018C04B98C 
		public UnityEngine.Color borderLeftColor { get => default; } // 0x000000018C04B98C-0x000000018C04B9E0 
		public float borderLeftWidth { get => default; } // 0x000000018C04B9E0-0x000000018C04BA20 
		public UnityEngine.Color borderRightColor { get => default; } // 0x000000018C04BA20-0x000000018C04BA74 
		public float borderRightWidth { get => default; } // 0x000000018C04BA74-0x000000018C04BAB4 
		public UnityEngine.Color borderTopColor { get => default; } // 0x000000018C04BAB4-0x000000018C04BB08 
		public Length borderTopLeftRadius { get => default; } // 0x000000018C04BB08-0x000000018C04BB4C 
		public Length borderTopRightRadius { get => default; } // 0x000000018C04BB4C-0x000000018C04BB90 
		public float borderTopWidth { get => default; } // 0x000000018C04BB90-0x000000018C04BBD0 
		public Length bottom { get => default; } // 0x000000018C04BBD0-0x000000018C04BC10 
		public UnityEngine.Color color { get => default; } // 0x000000018C04BC10-0x000000018C04BC60 
		public UnityEngine.UIElements.Cursor cursor { get => default; } // 0x000000018C04BC60-0x000000018C04BCBC 
		public DisplayStyle display { get => default; } // 0x000000018C04BD04-0x000000018C04BD44 
		public Length flexBasis { get => default; } // 0x000000018C04BD44-0x000000018C04BD84 
		public FlexDirection flexDirection { get => default; } // 0x000000018C04BD84-0x000000018C04BDC4 
		public float flexGrow { get => default; } // 0x000000018C04BDC4-0x000000018C04BE04 
		public float flexShrink { get => default; } // 0x000000018C04BE04-0x000000018C04BE44 
		public Wrap flexWrap { get => default; } // 0x000000018C04BE44-0x000000018C04BE84 
		public Length fontSize { get => default; } // 0x000000018C04BE84-0x000000018C04BEC4 
		public Length height { get => default; } // 0x000000018C04BED8-0x000000018C04BF18 
		public Justify justifyContent { get => default; } // 0x000000018C04BF18-0x000000018C04BF58 
		public Length left { get => default; } // 0x000000018C04BF58-0x000000018C04BF98 
		public Length letterSpacing { get => default; } // 0x000000018C04BF98-0x000000018C04BFD8 
		public Length marginBottom { get => default; } // 0x000000018C04BFD8-0x000000018C04C018 
		public Length marginLeft { get => default; } // 0x000000018C04C018-0x000000018C04C058 
		public Length marginRight { get => default; } // 0x000000018C04C058-0x000000018C04C098 
		public Length marginTop { get => default; } // 0x000000018C04C098-0x000000018C04C0D8 
		public Length maxHeight { get => default; } // 0x000000018C04C0D8-0x000000018C04C118 
		public Length maxWidth { get => default; } // 0x000000018C04C118-0x000000018C04C158 
		public Length minHeight { get => default; } // 0x000000018C04C158-0x000000018C04C19C 
		public Length minWidth { get => default; } // 0x000000018C04C19C-0x000000018C04C1E0 
		public float opacity { get => default; } // 0x000000018C04C1E0-0x000000018C04C224 
		public OverflowInternal overflow { get => default; } // 0x000000018C04C224-0x000000018C04C268 
		public Length paddingBottom { get => default; } // 0x000000018C04C268-0x000000018C04C2AC 
		public Length paddingLeft { get => default; } // 0x000000018C04C2AC-0x000000018C04C2F0 
		public Length paddingRight { get => default; } // 0x000000018C04C2F0-0x000000018C04C334 
		public Length paddingTop { get => default; } // 0x000000018C04C334-0x000000018C04C378 
		public Position position { get => default; } // 0x000000018C04C378-0x000000018C04C3BC 
		public Length right { get => default; } // 0x000000018C04C3BC-0x000000018C04C400 
		public Rotate rotate { get => default; } // 0x000000018C04C400-0x000000018C04C45C 
		public Scale scale { get => default; } // 0x000000018C04C45C-0x000000018C04C4B0 
		public TextOverflow textOverflow { get => default; } // 0x000000018C04C4B0-0x000000018C04C4F0 
		public TextShadow textShadow { get => default; } // 0x000000018C04C4F0-0x000000018C04C550 
		public Length top { get => default; } // 0x000000018C04C550-0x000000018C04C594 
		public TransformOrigin transformOrigin { get => default; } // 0x000000018C04C594-0x000000018C04C5EC 
		public List<TimeValue> transitionDelay { get => default; } // 0x000000018C04C5EC-0x000000018C04C62C 
		public List<TimeValue> transitionDuration { get => default; } // 0x000000018C04C62C-0x000000018C04C66C 
		public List<StylePropertyName> transitionProperty { get => default; } // 0x000000018C04C66C-0x000000018C04C6AC 
		public List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction { get => default; } // 0x000000018C04C6AC-0x000000018C04C6EC 
		public Translate translate { get => default; } // 0x000000018C04C6EC-0x000000018C04C748 
		public UnityEngine.Color unityBackgroundImageTintColor { get => default; } // 0x000000018C04C748-0x000000018C04C79C 
		public UnityEngine.ScaleMode unityBackgroundScaleMode { get => default; } // 0x000000018C04C79C-0x000000018C04C7DC 
		public Font unityFont { get => default; } // 0x000000018C04C86C-0x000000018C04C8AC 
		public FontDefinition unityFontDefinition { get => default; } // 0x000000018C04C7DC-0x000000018C04C82C 
		public FontStyle unityFontStyleAndWeight { get => default; } // 0x000000018C04C82C-0x000000018C04C86C 
		public OverflowClipBox unityOverflowClipBox { get => default; } // 0x000000018C04C8AC-0x000000018C04C8EC 
		public Length unityParagraphSpacing { get => default; } // 0x000000018C04C8EC-0x000000018C04C92C 
		public int unitySliceBottom { get => default; } // 0x000000018C04C92C-0x000000018C04C96C 
		public int unitySliceLeft { get => default; } // 0x000000018C04C96C-0x000000018C04C9AC 
		public int unitySliceRight { get => default; } // 0x000000018C04C9AC-0x000000018C04C9EC 
		public int unitySliceTop { get => default; } // 0x000000018C04C9EC-0x000000018C04CA2C 
		public TextAnchor unityTextAlign { get => default; } // 0x000000018C04CA2C-0x000000018C04CA6C 
		public UnityEngine.Color unityTextOutlineColor { get => default; } // 0x000000018C04CA6C-0x000000018C04CABC 
		public float unityTextOutlineWidth { get => default; } // 0x000000018C04CABC-0x000000018C04CAFC 
		public TextOverflowPosition unityTextOverflowPosition { get => default; } // 0x000000018C04CAFC-0x000000018C04CB3C 
		public Visibility visibility { get => default; } // 0x000000018C04CB3C-0x000000018C04CB7C 
		public WhiteSpace whiteSpace { get => default; } // 0x000000018C04CB7C-0x000000018C04CBBC 
		public Length width { get => default; } // 0x000000018C04CBBC-0x000000018C04CC00 
		public Length wordSpacing { get => default; } // 0x000000018C04CC00-0x000000018C04D18C 
	
		// Methods
		public void FinalizeApply(ref ComputedStyle parentStyle) {} // 0x000000018C0459B8-0x000000018C045AD4
		public void SyncWithLayout(YogaNode targetNode) {} // 0x000000018C04B2EC-0x000000018C04B70C
		private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) => default; // 0x000000018C03F2A4-0x000000018C03F334
		private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) => default; // 0x000000018C03F334-0x000000018C03F354
		private void RemoveCustomStyleProperty(StylePropertyReader reader) {} // 0x000000018C045B9C-0x000000018C045C30
		private void ApplyCustomStyleProperty(StylePropertyReader reader) {} // 0x000000018C03DF04-0x000000018C03DFEC
		private void ApplyAllPropertyInitial() {} // 0x000000018C03DEB8-0x000000018C03DF04
		private void ResetComputedTransitions() {} // 0x0000000187F218AC-0x0000000187F218C0
		public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) => default; // 0x000000018C0451C0-0x000000018C045500
		public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018C0474F0-0x000000018C047610
		public static ComputedStyle Create(ref ComputedStyle parentStyle) => default; // 0x000000018C0457CC-0x000000018C0459B8
		public static ComputedStyle CreateInitial() => default; // 0x000000018C04562C-0x000000018C0457CC
		public ComputedStyle Acquire() => default; // 0x000000018C03DDA4-0x000000018C03DEB8
		public void Release() {} // 0x000000018C045AD4-0x000000018C045B9C
		public void CopyFrom(ref ComputedStyle other) {} // 0x000000018C045500-0x000000018C04562C
		public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) {} // 0x000000018C040ADC-0x000000018C041D64
		public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) {} // 0x000000018C0440E4-0x000000018C044E74
		public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) {} // 0x000000018C043DD4-0x000000018C0440E4
		public void ApplyStyleCursor(UnityEngine.UIElements.Cursor cursor) {} // 0x000000018C043BC0-0x000000018C043C20
		public void ApplyStyleTextShadow(TextShadow st) {} // 0x000000018C043CC8-0x000000018C043D28
		public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) {} // 0x000000018C03DFEC-0x000000018C03F2A4
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) {} // 0x000000018C0421F0-0x000000018C042AD8
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) {} // 0x000000018C041EA8-0x000000018C0421F0
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) {} // 0x000000018C042C18-0x000000018C0431BC
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, UnityEngine.Color newValue) {} // 0x000000018C043954-0x000000018C043BC0
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) {} // 0x000000018C04357C-0x000000018C0436C8
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) {} // 0x000000018C042AD8-0x000000018C042C18
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) {} // 0x000000018C0436C8-0x000000018C04380C
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) {} // 0x000000018C04380C-0x000000018C043954
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) {} // 0x000000018C0431BC-0x000000018C043300
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) {} // 0x000000018C04343C-0x000000018C04357C
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) {} // 0x000000018C041D64-0x000000018C041EA8
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) {} // 0x000000018C043300-0x000000018C04343C
		public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018C049294-0x000000018C04B2EC
		public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018C045C30-0x000000018C0474F0
		public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x000000018C047610-0x000000018C049294
		public void ApplyStyleTransformOrigin(TransformOrigin st) {} // 0x000000018C043D28-0x000000018C043D7C
		public void ApplyStyleTranslate(Translate translateValue) {} // 0x000000018C043D7C-0x000000018C043DD4
		public void ApplyStyleRotate(Rotate rotateValue) {} // 0x000000018C043C20-0x000000018C043C78
		public void ApplyStyleScale(Scale scaleValue) {} // 0x000000018C043C78-0x000000018C043CC8
		public void ApplyInitialValue(StylePropertyReader reader) {} // 0x000000018C03F354-0x000000018C03F39C
		public void ApplyInitialValue(StylePropertyId id) {} // 0x000000018C03F39C-0x000000018C040ADC
		public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) {} // 0x000000018C044E74-0x000000018C044EA8
		public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) {} // 0x000000018C044EA8-0x000000018C0451C0
	}

	internal struct ComputedTransitionProperty // TypeDefIndex: 44714
	{
		// Fields
		public StylePropertyId id; // 0x00
		public int durationMs; // 0x04
		public int delayMs; // 0x08
		public Func<float, float> easingCurve; // 0x10
	}

	internal static class ComputedTransitionUtils // TypeDefIndex: 44716
	{
		// Fields
		private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer; // 0x00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44715
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<float, float> __9__12_0; // 0x08
			public static Func<float, float> __9__12_1; // 0x10
			public static Func<float, float> __9__12_2; // 0x18
			public static Func<float, float> __9__12_3; // 0x20
			public static Func<float, float> __9__12_4; // 0x28
			public static Func<float, float> __9__12_5; // 0x30
			public static Func<float, float> __9__12_6; // 0x38
			public static Func<float, float> __9__12_7; // 0x40
			public static Func<float, float> __9__12_8; // 0x48
			public static Func<float, float> __9__12_9; // 0x50
			public static Func<float, float> __9__12_10; // 0x58
			public static Func<float, float> __9__12_11; // 0x60
			public static Func<float, float> __9__12_12; // 0x68
			public static Func<float, float> __9__12_13; // 0x70
			public static Func<float, float> __9__12_14; // 0x78
			public static Func<float, float> __9__12_15; // 0x80
			public static Func<float, float> __9__12_16; // 0x88
			public static Func<float, float> __9__12_17; // 0x90
			public static Func<float, float> __9__12_18; // 0x98
			public static Func<float, float> __9__12_19; // 0xA0
			public static Func<float, float> __9__12_20; // 0xA8
			public static Func<float, float> __9__12_21; // 0xB0
			public static Func<float, float> __9__12_22; // 0xB8
	
			// Constructors
			static __c() {} // 0x000000018C04FC40-0x000000018C04FC98
			public __c() {} // 0x000000018C04F8F8-0x000000018C04F9A0
	
			// Methods
			internal float _ConvertTransitionFunction_b__12_0(float t) => default; // 0x000000018C04F810-0x000000018C04F8F8
			internal float _ConvertTransitionFunction_b__12_1(float t) => default; // 0x000000018C04F214-0x000000018C04F38C
			internal float _ConvertTransitionFunction_b__12_2(float t) => default; // 0x000000018C04F38C-0x000000018C04F810
			internal float _ConvertTransitionFunction_b__12_3(float t) => default; // 0x000000018C04FA68-0x000000018C04FB78
			internal float _ConvertTransitionFunction_b__12_4(float t) => default; // 0x000000018C04F9A0-0x000000018C04FA68
			internal float _ConvertTransitionFunction_b__12_5(float t) => default; // 0x000000018C04FB78-0x000000018C04FC40
			internal float _ConvertTransitionFunction_b__12_6(float t) => default; // 0x000000018C04DFDC-0x000000018C04E234
			internal float _ConvertTransitionFunction_b__12_7(float t) => default;
			internal float _ConvertTransitionFunction_b__12_8(float t) => default; // 0x000000018C04F1E8-0x000000018C04F214
			internal float _ConvertTransitionFunction_b__12_9(float t) => default; // 0x000000018C04E234-0x000000018C04F1E8
			internal float _ConvertTransitionFunction_b__12_10(float t) => default; // 0x000000018C04FC98-0x000000018C04FD24
			internal float _ConvertTransitionFunction_b__12_11(float t) => default; // 0x000000018C05A598-0x000000018C05A5FC
			internal float _ConvertTransitionFunction_b__12_12(float t) => default; // 0x0000000185492010-0x0000000185492020
			internal float _ConvertTransitionFunction_b__12_13(float t) => default; // 0x0000000185FEA370-0x0000000185FEA3A0
			internal float _ConvertTransitionFunction_b__12_14(float t) => default; // 0x0000000185FEA430-0x0000000185FEA440
			internal float _ConvertTransitionFunction_b__12_15(float t) => default; // 0x0000000185FEA440-0x0000000185FEA460
			internal float _ConvertTransitionFunction_b__12_16(float t) => default; // 0x000000018C05A560-0x000000018C05A56C
			internal float _ConvertTransitionFunction_b__12_17(float t) => default; // 0x0000000185FEA460-0x0000000185FEA470
			internal float _ConvertTransitionFunction_b__12_18(float t) => default; // 0x0000000185FEA470-0x0000000185FEA4A0
			internal float _ConvertTransitionFunction_b__12_19(float t) => default; // 0x0000000185FEA4A0-0x0000000185FEA4C0
			internal float _ConvertTransitionFunction_b__12_20(float t) => default; // 0x0000000185FEA4C0-0x0000000185FEA500
			internal float _ConvertTransitionFunction_b__12_21(float t) => default; // 0x0000000185FEA500-0x0000000185FEA510
			internal float _ConvertTransitionFunction_b__12_22(float t) => default; // 0x000000018C05A56C-0x000000018C05A598
		}
	
		// Constructors
		static ComputedTransitionUtils() {} // 0x000000018C05A554-0x000000018C05A560
	
		// Methods
		internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle) {} // 0x000000018C05A48C-0x000000018C05A4A0
		internal static bool HasTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id) => default; // 0x0000000185FEA3A0-0x0000000185FEA400
		internal static bool GetTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result) {
			result = default;
			return default;
		} // 0x0000000185FEA400-0x0000000185FEA430
		private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle) => default; // 0x000000018C05A4A0-0x000000018C05A4AC
		private static int GetTransitionHashCode(ref ComputedStyle cs) => default; // 0x000000018C05A4AC-0x000000018C05A4B8
		internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y) => default; // 0x000000018C05A4B8-0x000000018C05A4C4
		private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b) => default; // 0x000000018C05A4C4-0x000000018C05A4D0
		private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b) => default; // 0x000000018C05A4D0-0x000000018C05A4DC
		private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData) {} // 0x000000018C05A4DC-0x000000018C05A50C
		private static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue) => default; // 0x000000018C05A50C-0x000000018C05A518
		private static int ConvertTransitionTime(TimeValue time) => default; // 0x000000018C05A518-0x000000018C05A548
		private static Func<float, float> ConvertTransitionFunction(EasingMode mode) => default; // 0x000000018C05A548-0x000000018C05A554
	}

	public struct CustomStyleProperty<T> : IEquatable<CustomStyleProperty<T>> // TypeDefIndex: 44717
	{
		// Fields
		private string _name_k__BackingField;
	
		// Properties
		public string name { get; private set; }
	
		// Constructors
		public CustomStyleProperty(string propertyName) : this() {
			<name>k__BackingField = default;
		}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(CustomStyleProperty<T> other) => default;
		public override int GetHashCode() => default;
	}

	public interface ICustomStyle // TypeDefIndex: 44718
	{
		// Methods
		bool TryGetValue(CustomStyleProperty<float> property, out float value);
		bool TryGetValue(CustomStyleProperty<int> property, out int value);
		bool TryGetValue(CustomStyleProperty<UnityEngine.Color> property, out UnityEngine.Color value);
		bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value);
		bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value);
		bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value);
		bool TryGetValue(CustomStyleProperty<string> property, out string value);
	}

	public enum EasingMode // TypeDefIndex: 44719
	{
		Ease = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3,
		Linear = 4,
		EaseInSine = 5,
		EaseOutSine = 6,
		EaseInOutSine = 7,
		EaseInCubic = 8,
		EaseOutCubic = 9,
		EaseInOutCubic = 10,
		EaseInCirc = 11,
		EaseOutCirc = 12,
		EaseInOutCirc = 13,
		EaseInElastic = 14,
		EaseOutElastic = 15,
		EaseInOutElastic = 16,
		EaseInBack = 17,
		EaseOutBack = 18,
		EaseInOutBack = 19,
		EaseInBounce = 20,
		EaseOutBounce = 21,
		EaseInOutBounce = 22
	}

	public struct EasingFunction : IEquatable<UnityEngine.UIElements.EasingFunction> // TypeDefIndex: 44720
	{
		// Fields
		private EasingMode m_Mode; // 0x00
	
		// Properties
		public EasingMode mode { get => default; } // 0x00000001818226B0-0x00000001818226C0 
	
		// Constructors
		public EasingFunction(EasingMode mode) : this() {
			m_Mode = default;
		} // 0x00000001818AA390-0x00000001818AA3A0
	
		// Methods
		public static implicit operator EasingFunction(EasingMode easingMode) => default; // 0x0000000185FE7B20-0x0000000185FE7B30
		public static bool operator ==(EasingFunction lhs, EasingFunction rhs) => default; // 0x0000000188645D08-0x0000000188645D10
		public bool Equals(EasingFunction other) => default; // 0x000000018B6F1078-0x000000018B6F1080
		public override bool Equals(object obj) => default; // 0x000000018C050854-0x000000018C0508BC
		public override string ToString() => default; // 0x000000018C0508BC-0x000000018C05090C
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
	}

	public struct FontDefinition : IEquatable<FontDefinition> // TypeDefIndex: 44721
	{
		// Fields
		private Font m_Font; // 0x00
		private FontAsset m_FontAsset; // 0x08
	
		// Properties
		public Font font { get => default; } // 0x0000000184142CB0-0x0000000184142CC0 
		public FontAsset fontAsset { get => default; } // 0x0000000185FE6720-0x0000000185FE6730 
	
		// Methods
		public static FontDefinition FromFont(Font f) => default; // 0x000000018C0509CC-0x000000018C050A04
		public static FontDefinition FromSDFFont(FontAsset f) => default; // 0x000000018C050AF8-0x000000018C050B30
		internal static FontDefinition FromObject(object obj) => default; // 0x000000018C050A04-0x000000018C050AF8
		internal bool IsEmpty() => default; // 0x000000018C050BF8-0x000000018C050C7C
		public override string ToString() => default; // 0x000000018C050C7C-0x000000018C050CF4
		public bool Equals(FontDefinition other) => default; // 0x000000018C050984-0x000000018C0509CC
		public override bool Equals(object obj) => default; // 0x000000018C05090C-0x000000018C050984
		public override int GetHashCode() => default; // 0x000000018C050B30-0x000000018C050BF8
		public static bool operator ==(FontDefinition left, FontDefinition right) => default; // 0x000000018C050CF4-0x000000018C050D14
		public static bool operator !=(FontDefinition left, FontDefinition right) => default; // 0x000000018C050D14-0x000000018C050D34
	}

	internal class StyleValueCollection // TypeDefIndex: 44722
	{
		// Fields
		internal List<StyleValue> m_Values; // 0x10
	
		// Constructors
		public StyleValueCollection() {} // 0x000000018C058144-0x000000018C0581BC
	
		// Methods
		public StyleLength GetStyleLength(StylePropertyId id) => default; // 0x000000018C057E24-0x000000018C057EB4
		public StyleFloat GetStyleFloat(StylePropertyId id) => default; // 0x000000018C057D50-0x000000018C057DB8
		public StyleInt GetStyleInt(StylePropertyId id) => default; // 0x000000018C057DB8-0x000000018C057E24
		public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value) => default; // 0x000000018C057FE4-0x000000018C058144
		public void SetStyleValue(StyleValue value) {} // 0x000000018C057EB4-0x000000018C057FE4
	}

	internal class InlineStyleAccess : StyleValueCollection, IStyle // TypeDefIndex: 44724
	{
		// Fields
		private static StylePropertyReader s_StylePropertyReader; // 0x00
		private List<StyleValueManaged> m_ValuesManaged; // 0x18
		private VisualElement _ve_k__BackingField; // 0x20
		private bool m_HasInlineCursor; // 0x28
		private StyleCursor m_InlineCursor; // 0x30
		private bool m_HasInlineTextShadow; // 0x50
		private StyleTextShadow m_InlineTextShadow; // 0x54
		private bool m_HasInlineTransformOrigin; // 0x74
		private StyleTransformOrigin m_InlineTransformOrigin; // 0x78
		private bool m_HasInlineTranslate; // 0x90
		private StyleTranslate m_InlineTranslateOperation; // 0x94
		private bool m_HasInlineRotate; // 0xB0
		private StyleRotate m_InlineRotateOperation; // 0xB4
		private bool m_HasInlineScale; // 0xD0
		private StyleScale m_InlineScale; // 0xD4
		private InlineRule m_InlineRule; // 0xE8
	
		// Properties
		private VisualElement ve { get; set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		StyleCursor IStyle.cursor { get => default; } // 0x000000018C0524E4-0x000000018C05254C 
		StyleTextShadow IStyle.textShadow { get => default; } // 0x000000018C0526D0-0x000000018C052738 
		StyleTransformOrigin IStyle.transformOrigin { get => default; } // 0x000000018C052738-0x000000018C0527A8 
		StyleTranslate IStyle.translate { get => default; set {} } // 0x000000018C0527A8-0x000000018C052828 0x000000018C053B04-0x000000018C053B5C
		StyleRotate IStyle.rotate { get => default; } // 0x000000018C0525E8-0x000000018C052668 
		StyleScale IStyle.scale { get => default; } // 0x000000018C052668-0x000000018C0526D0 
		StyleColor IStyle.backgroundColor { set {} } // 0x000000018C052864-0x000000018C0528B4
		StyleColor IStyle.borderBottomColor { set {} } // 0x000000018C0528B4-0x000000018C052904
		StyleLength IStyle.borderBottomLeftRadius { set {} } // 0x000000018C052904-0x000000018C052958
		StyleLength IStyle.borderBottomRightRadius { set {} } // 0x000000018C052958-0x000000018C0529AC
		StyleFloat IStyle.borderBottomWidth { set {} } // 0x000000018C0529AC-0x000000018C052A28
		StyleColor IStyle.borderLeftColor { set {} } // 0x000000018C052A28-0x000000018C052A78
		StyleFloat IStyle.borderLeftWidth { set {} } // 0x000000018C052A78-0x000000018C052AF4
		StyleColor IStyle.borderRightColor { set {} } // 0x000000018C052AF4-0x000000018C052B44
		StyleFloat IStyle.borderRightWidth { set {} } // 0x000000018C052B44-0x000000018C052BC0
		StyleColor IStyle.borderTopColor { set {} } // 0x000000018C052BC0-0x000000018C052C10
		StyleLength IStyle.borderTopLeftRadius { set {} } // 0x000000018C052C10-0x000000018C052C64
		StyleLength IStyle.borderTopRightRadius { set {} } // 0x000000018C052C64-0x000000018C052CB8
		StyleFloat IStyle.borderTopWidth { set {} } // 0x000000018C052CB8-0x000000018C052D34
		StyleLength IStyle.bottom { set {} } // 0x000000018C052D34-0x000000018C052DCC
		StyleColor IStyle.color { set {} } // 0x000000018C052DCC-0x000000018C052E1C
		StyleEnum<DisplayStyle> IStyle.display { get => default; set {} } // 0x000000018C05254C-0x000000018C0525AC 0x000000018C052E1C-0x000000018C052EBC
		StyleLength IStyle.flexBasis { set {} } // 0x000000018C052EBC-0x000000018C052F54
		StyleEnum<FlexDirection> IStyle.flexDirection { set {} } // 0x000000018C052F54-0x000000018C052FF4
		StyleFloat IStyle.flexGrow { set {} } // 0x000000018C052FF4-0x000000018C05306C
		StyleFloat IStyle.flexShrink { set {} } // 0x000000018C05306C-0x000000018C0530E4
		StyleLength IStyle.fontSize { set {} } // 0x000000018C0530E4-0x000000018C053138
		StyleLength IStyle.height { set {} } // 0x000000018C053138-0x000000018C0531D0
		StyleLength IStyle.left { set {} } // 0x000000018C0531D0-0x000000018C053268
		StyleLength IStyle.marginBottom { set {} } // 0x000000018C053268-0x000000018C053300
		StyleLength IStyle.marginLeft { set {} } // 0x000000018C053300-0x000000018C053398
		StyleLength IStyle.marginRight { set {} } // 0x000000018C053398-0x000000018C053430
		StyleLength IStyle.marginTop { set {} } // 0x000000018C053430-0x000000018C0534C8
		StyleLength IStyle.maxHeight { set {} } // 0x000000018C0534C8-0x000000018C053560
		StyleLength IStyle.maxWidth { set {} } // 0x000000018C053560-0x000000018C0535F8
		StyleLength IStyle.minWidth { set {} } // 0x000000018C0535F8-0x000000018C053690
		StyleFloat IStyle.opacity { set {} } // 0x000000018C053690-0x000000018C0536D4
		StyleLength IStyle.paddingBottom { set {} } // 0x000000018C0536D4-0x000000018C05376C
		StyleLength IStyle.paddingLeft { set {} } // 0x000000018C05376C-0x000000018C053804
		StyleLength IStyle.paddingRight { set {} } // 0x000000018C053804-0x000000018C05389C
		StyleLength IStyle.paddingTop { get => default; set {} } // 0x000000018C0525AC-0x000000018C0525E8 0x000000018C05389C-0x000000018C053934
		StyleEnum<Position> IStyle.position { set {} } // 0x000000018C053934-0x000000018C0539D4
		StyleLength IStyle.right { set {} } // 0x000000018C0539D4-0x000000018C053A6C
		StyleLength IStyle.top { set {} } // 0x000000018C053A6C-0x000000018C053B04
		StyleColor IStyle.unityBackgroundImageTintColor { set {} } // 0x000000018C053B5C-0x000000018C053BAC
		StyleEnum<Visibility> IStyle.visibility { set {} } // 0x000000018C053BAC-0x000000018C053C1C
		StyleLength IStyle.width { get => default; set {} } // 0x000000018C052828-0x000000018C052864 0x000000018C053C1C-0x000000018C053CB4
	
		// Nested types
		internal struct InlineRule // TypeDefIndex: 44723
		{
			// Fields
			public StyleSheet sheet; // 0x00
			public StyleRule rule; // 0x08
			public StylePropertyId[] propertyIds; // 0x10
		}
	
		// Constructors
		public InlineStyleAccess() {} // Dummy constructor
		public InlineStyleAccess(VisualElement ve) {} // 0x000000018C053D30-0x000000018C053D60
		static InlineStyleAccess() {} // 0x000000018C053CB4-0x000000018C053D30
	
		// Methods
		~InlineStyleAccess() {} // 0x000000018C051A74-0x000000018C051B44
		public void SetInlineRule(StyleSheet sheet, StyleRule rule) {} // 0x000000018C051EC4-0x000000018C051F74
		public bool IsValueSet(StylePropertyId id) => default; // 0x000000018C051B44-0x000000018C051DEC
		public void ApplyInlineStyles(ref ComputedStyle computedStyle) {} // 0x000000018C050EE8-0x000000018C05164C
		private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) => default; // 0x000000018C0520B4-0x000000018C0521C4
		private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) => default; // 0x000000018C0522F4-0x000000018C0523F8
		private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) => default; // 0x000000018C0521C4-0x000000018C0522F4
		private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue)
			where T : struct, IConvertible => default;
		private bool SetInlineTranslate(StyleTranslate inlineValue) => default; // 0x000000018C051F74-0x000000018C0520B4
		private void ApplyStyleTranslate(StyleTranslate translate) {} // 0x000000018C05164C-0x000000018C051818
		private void ApplyStyleValue(StyleValue value) {} // 0x000000018C051818-0x000000018C051A74
		private bool RemoveInlineStyle(StylePropertyId id) => default; // 0x000000018C051DEC-0x000000018C051EC4
		private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) {} // 0x000000018C050D34-0x000000018C050EE8
		public bool TryGetInlineCursor(ref StyleCursor value) => default; // 0x000000018C0523F8-0x000000018C052424
		public bool TryGetInlineTextShadow(ref StyleTextShadow value) => default; // 0x000000018C052478-0x000000018C052494
		public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) => default; // 0x000000018C052494-0x000000018C0524B4
		public bool TryGetInlineTranslate(ref StyleTranslate value) => default; // 0x000000018C0524B4-0x000000018C0524E4
		public bool TryGetInlineRotate(ref StyleRotate value) => default; // 0x000000018C052424-0x000000018C052454
		public bool TryGetInlineScale(ref StyleScale value) => default; // 0x000000018C052454-0x000000018C052478
	}

	public enum LengthUnit // TypeDefIndex: 44725
	{
		Pixel = 0,
		Percent = 1
	}

	[Serializable]
	public struct Length : IEquatable<Length> // TypeDefIndex: 44727
	{
		// Fields
		internal const float k_MaxValue = 8388608f; // Metadata: 0x0205B72E
		private float m_Value; // 0x00
		private Unit m_Unit; // 0x04
	
		// Properties
		public float value { get => default; set {} } // 0x0000000185FB0F90-0x0000000185FB0FA0 0x000000018C054014-0x000000018C054038
		public LengthUnit unit { get => default; } // 0x000000018357CBC0-0x000000018357CBD0 
	
		// Nested types
		private enum Unit // TypeDefIndex: 44726
		{
			Pixel = 0,
			Percent = 1,
			Auto = 2,
			None = 3
		}
	
		// Constructors
		public Length(float value) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x000000018C053FC0-0x000000018C053FCC
		public Length(float value, LengthUnit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x000000018C053FCC-0x000000018C053FD4
		private Length(float value, Unit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x000000018C053F94-0x000000018C053FC0
	
		// Methods
		public static Length Percent(float value) => default; // 0x000000018C053E40-0x000000018C053E70
		public static Length Auto() => default; // 0x000000018C053D60-0x000000018C053D90
		public static Length None() => default; // 0x000000018C053E10-0x000000018C053E40
		public bool IsAuto() => default; // 0x000000018C053E00-0x000000018C053E08
		public bool IsNone() => default; // 0x000000018C053E08-0x000000018C053E10
		public static implicit operator Length(float value) => default; // 0x000000018C053FD4-0x000000018C054000
		public static bool operator ==(Length lhs, Length rhs) => default; // 0x000000018C04D3C8-0x000000018C04D3F4
		public static bool operator !=(Length lhs, Length rhs) => default; // 0x000000018C054000-0x000000018C054014
		public bool Equals(Length other) => default; // 0x000000018C04D1FC-0x000000018C04D210
		public override bool Equals(object obj) => default; // 0x000000018C053D90-0x000000018C053E00
		public override int GetHashCode() => default; // 0x000000018C04D210-0x000000018C04D230
		public override string ToString() => default; // 0x000000018C053E70-0x000000018C053F94
	}

	public struct Rotate : IEquatable<Rotate> // TypeDefIndex: 44728
	{
		// Fields
		private Angle m_Angle; // 0x00
		private Vector3 m_Axis; // 0x08
		private bool m_IsNone; // 0x14
	
		// Properties
		public Angle angle { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		internal Vector3 axis { get => default; } // 0x0000000185FBFA70-0x0000000185FBFA90 
	
		// Constructors
		public Rotate(Angle angle) : this() {
			m_Angle = default;
			m_Axis = default;
			m_IsNone = default;
		} // 0x000000018C056550-0x000000018C056574
	
		// Methods
		internal static Rotate Initial() => default; // 0x000000018C0563CC-0x000000018C056448
		public static Rotate None() => default; // 0x000000018C056448-0x000000018C056494
		public static bool operator ==(Rotate lhs, Rotate rhs) => default; // 0x000000018C056574-0x000000018C056668
		public static bool operator !=(Rotate lhs, Rotate rhs) => default; // 0x000000018C056668-0x000000018C0566A8
		public bool Equals(Rotate other) => default; // 0x000000018C056308-0x000000018C05634C
		public override bool Equals(object obj) => default; // 0x000000018C056270-0x000000018C056308
		public override int GetHashCode() => default; // 0x000000018C05634C-0x000000018C0563CC
		public override string ToString() => default; // 0x000000018C0564F0-0x000000018C056550
		internal Quaternion ToQuaternion() => default; // 0x000000018C056494-0x000000018C0564F0
	}

	public struct Scale : IEquatable<Scale> // TypeDefIndex: 44729
	{
		// Fields
		private Vector3 m_Scale; // 0x00
		private bool m_IsNone; // 0x0C
	
		// Properties
		public Vector3 value { get => default; } // 0x0000000185FB7B80-0x0000000185FB7BA0 
	
		// Constructors
		public Scale(Vector3 scale) : this() {
			m_Scale = default;
			m_IsNone = default;
		} // 0x0000000185FEA0E0-0x0000000185FEA110
	
		// Methods
		internal static Scale Initial() => default; // 0x000000018C056924-0x000000018C056978
		public static Scale None() => default; // 0x000000018C056978-0x000000018C0569B4
		public static bool operator ==(Scale lhs, Scale rhs) => default; // 0x000000018C0569C0-0x000000018C056A14
		public static bool operator !=(Scale lhs, Scale rhs) => default; // 0x000000018C056A14-0x000000018C056A44
		public bool Equals(Scale other) => default; // 0x000000018C056860-0x000000018C05688C
		public override bool Equals(object obj) => default; // 0x000000018C05688C-0x000000018C056910
		public override int GetHashCode() => default; // 0x000000018C056910-0x000000018C056924
		public override string ToString() => default; // 0x000000018C0569B4-0x000000018C0569C0
	}

	public struct StyleColor : IStyleValue<UnityEngine.Color>, IEquatable<StyleColor> // TypeDefIndex: 44730
	{
		// Fields
		private UnityEngine.Color m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x10
	
		// Properties
		public UnityEngine.Color value { get => default; } // 0x000000018C056B9C-0x000000018C056BC8 
		public StyleKeyword keyword { get => default; } // 0x0000000185FE6790-0x0000000185FE67A0 
	
		// Constructors
		public StyleColor(UnityEngine.Color v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FD11E0-0x0000000185FD11F0
		internal StyleColor(UnityEngine.Color v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x000000018357CA90-0x000000018357CAA0
	
		// Methods
		public static bool operator ==(StyleColor lhs, StyleColor rhs) => default; // 0x000000018C056BC8-0x000000018C056C18
		public static implicit operator StyleColor(UnityEngine.Color v) => default; // 0x0000000185FEA110-0x0000000185FEA130
		public bool Equals(StyleColor other) => default; // 0x000000018C056A44-0x000000018C056A80
		public override bool Equals(object obj) => default; // 0x000000018C056A80-0x000000018C056B14
		public override int GetHashCode() => default; // 0x000000018C056B14-0x000000018C056B34
		public override string ToString() => default; // 0x000000018C056B34-0x000000018C056B9C
	}

	public struct StyleCursor : IStyleValue<UnityEngine.UIElements.Cursor>, IEquatable<StyleCursor> // TypeDefIndex: 44731
	{
		// Fields
		private UnityEngine.UIElements.Cursor m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public UnityEngine.UIElements.Cursor value { get => default; } // 0x000000018C056DA4-0x000000018C056DD8 
		public StyleKeyword keyword { get => default; } // 0x0000000185FC9940-0x0000000185FC9950 
	
		// Constructors
		public StyleCursor(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x000000018C056D60-0x000000018C056D88
		internal StyleCursor(UnityEngine.UIElements.Cursor v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x000000018C056D88-0x000000018C056DA4
	
		// Methods
		public static bool operator ==(StyleCursor lhs, StyleCursor rhs) => default; // 0x000000018C056DD8-0x000000018C056E38
		public static implicit operator StyleCursor(StyleKeyword keyword) => default; // 0x000000018C056E38-0x000000018C056E7C
		public bool Equals(StyleCursor other) => default; // 0x000000018C056C18-0x000000018C056C58
		public override bool Equals(object obj) => default; // 0x000000018C056C58-0x000000018C056CD8
		public override int GetHashCode() => default; // 0x000000018C056CD8-0x000000018C056CF8
		public override string ToString() => default; // 0x000000018C056CF8-0x000000018C056D60
	}

	internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> // TypeDefIndex: 44733
		where T : struct, IEquatable<T>, IStyleDataGroup<T>
	{
		// Fields
		private RefCounted m_Ref;
	
		// Nested types
		private class RefCounted // TypeDefIndex: 44732
		{
			// Fields
			private static uint m_NextId;
			private int m_RefCount;
			private readonly uint m_Id;
			public T value;
	
			// Properties
			public int refCount { get => default; }
	
			// Constructors
			public RefCounted() {}
			static RefCounted() {}
	
			// Methods
			public void Acquire() {}
			public void Release() {}
			public RefCounted<T> Copy() => default;
		}
	
		// Methods
		public StyleDataRef<T> Acquire() => default;
		public void Release() {}
		public void CopyFrom(StyleDataRef<T> other) {}
		public ref ref T Read() => ref _refReturnTypeForRead;
		private ref T _refReturnTypeForRead; // Dummy field
		public ref ref T Write() => ref _refReturnTypeForWrite;
		private ref T _refReturnTypeForWrite; // Dummy field
		public static StyleDataRef<T> Create() => default;
		public override int GetHashCode() => default;
		public static bool operator ==(StyleDataRef<T> lhs, StyleDataRef<T> rhs) => default;
		public bool Equals(StyleDataRef<T> other) => default;
		public override bool Equals(object obj) => default;
	}

	public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> // TypeDefIndex: 44734
		where T : struct, IConvertible
	{
		// Fields
		private T m_Value;
		private StyleKeyword m_Keyword;
	
		// Properties
		public T value { get => default; }
		public StyleKeyword keyword { get => default; }
	
		// Constructors
		public StyleEnum(T v) : this() {
			m_Value = default;
			m_Keyword = default;
		}
		public StyleEnum(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		}
		internal StyleEnum(T v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		}
	
		// Methods
		public static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs) => default;
		public static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs) => default;
		public static implicit operator StyleEnum<T>(StyleKeyword keyword) => default;
		public static implicit operator StyleEnum<T>(T v) => default;
		public bool Equals(StyleEnum<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
		public override string ToString() => default;
	}

	public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 44735
	{
		// Fields
		private float m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x04
	
		// Properties
		public float value { get => default; } // 0x000000018C056F60-0x000000018C056F70 
		public StyleKeyword keyword { get => default; } // 0x0000000185FCA560-0x0000000185FCA570 
	
		// Constructors
		public StyleFloat(float v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FB0F80-0x0000000185FB0F90
		public StyleFloat(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FEA130-0x0000000185FEA140
		internal StyleFloat(float v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FB0F70-0x0000000185FB0F80
	
		// Methods
		public static bool operator ==(StyleFloat lhs, StyleFloat rhs) => default; // 0x000000018C056F70-0x000000018C056F9C
		public static implicit operator StyleFloat(StyleKeyword keyword) => default; // 0x0000000185FEA140-0x0000000185FEA160
		public static implicit operator StyleFloat(float v) => default; // 0x0000000185FEA070-0x0000000185FEA090
		public bool Equals(StyleFloat other) => default; // 0x000000018C056EEC-0x000000018C056F00
		public override bool Equals(object obj) => default; // 0x000000018C056E7C-0x000000018C056EEC
		public override int GetHashCode() => default; // 0x000000018C04D210-0x000000018C04D230
		public override string ToString() => default; // 0x000000018C056F00-0x000000018C056F60
	}

	public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 44736
	{
		// Fields
		private int m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x04
	
		// Properties
		public int value { get => default; } // 0x0000000189EA33BC-0x0000000189EA33C8 
		public StyleKeyword keyword { get => default; } // 0x0000000185FCA560-0x0000000185FCA570 
	
		// Constructors
		public StyleInt(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FEA130-0x0000000185FEA140
		internal StyleInt(int v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FCA550-0x0000000185FCA560
	
		// Methods
		public static bool operator ==(StyleInt lhs, StyleInt rhs) => default; // 0x000000018C057080-0x000000018C05709C
		public static implicit operator StyleInt(StyleKeyword keyword) => default; // 0x0000000185FEA140-0x0000000185FEA160
		public bool Equals(StyleInt other) => default; // 0x000000018C05700C-0x000000018C057020
		public override bool Equals(object obj) => default; // 0x000000018C056F9C-0x000000018C05700C
		public override int GetHashCode() => default; // 0x0000000185FE7CB0-0x0000000185FE7CC0
		public override string ToString() => default; // 0x000000018C057020-0x000000018C057080
	}

	public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 44737
	{
		// Fields
		private Length m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x08
	
		// Properties
		public Length value { get => default; } // 0x000000018C05727C-0x000000018C057294 
		public StyleKeyword keyword { get => default; } // 0x00000001835DC780-0x00000001835DC790 
	
		// Constructors
		public StyleLength(float v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x000000018C0571FC-0x000000018C057238
		public StyleLength(Length v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x000000018C057270-0x000000018C05727C
		public StyleLength(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x000000018C057238-0x000000018C057248
		internal StyleLength(Length v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x000000018C057248-0x000000018C057270
	
		// Methods
		public static bool operator ==(StyleLength lhs, StyleLength rhs) => default; // 0x000000018C057294-0x000000018C0572B8
		public static implicit operator StyleLength(StyleKeyword keyword) => default; // 0x000000018C0572F8-0x000000018C057334
		public static implicit operator StyleLength(float v) => default; // 0x000000018C057334-0x000000018C057370
		public static implicit operator StyleLength(Length v) => default; // 0x000000018C0572B8-0x000000018C0572F8
		public bool Equals(StyleLength other) => default; // 0x000000018C05709C-0x000000018C0570DC
		public override bool Equals(object obj) => default; // 0x000000018C0570DC-0x000000018C057174
		public override int GetHashCode() => default; // 0x000000018C057174-0x000000018C057194
		public override string ToString() => default; // 0x000000018C057194-0x000000018C0571FC
	}

	public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate> // TypeDefIndex: 44738
	{
		// Fields
		private Rotate m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public Rotate value { get => default; } // 0x000000018C056DA4-0x000000018C056DD8 
		public StyleKeyword keyword { get => default; } // 0x0000000185FC9940-0x0000000185FC9950 
	
		// Constructors
		public StyleRotate(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FEA160-0x0000000185FEA190
		internal StyleRotate(Rotate v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FC8330-0x0000000185FC8350
	
		// Methods
		public static bool operator ==(StyleRotate lhs, StyleRotate rhs) => default; // 0x000000018C0574DC-0x000000018C057554
		public static implicit operator StyleRotate(StyleKeyword keyword) => default; // 0x0000000185FEA190-0x0000000185FEA1C0
		public bool Equals(StyleRotate other) => default; // 0x000000018C0573FC-0x000000018C05744C
		public override bool Equals(object obj) => default; // 0x000000018C057370-0x000000018C0573FC
		public override int GetHashCode() => default; // 0x000000018C05744C-0x000000018C05746C
		public override string ToString() => default; // 0x000000018C05746C-0x000000018C0574DC
	}

	public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale> // TypeDefIndex: 44739
	{
		// Fields
		private Scale m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x10
	
		// Properties
		public Scale value { get => default; } // 0x000000018C0576AC-0x000000018C0576C4 
		public StyleKeyword keyword { get => default; } // 0x0000000185FE6790-0x0000000185FE67A0 
	
		// Constructors
		public StyleScale(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FEA1C0-0x0000000185FEA1D0
		internal StyleScale(Scale v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x000000018357CA90-0x000000018357CAA0
	
		// Methods
		public static bool operator ==(StyleScale lhs, StyleScale rhs) => default; // 0x000000018C0576C4-0x000000018C057718
		public static implicit operator StyleScale(StyleKeyword keyword) => default; // 0x0000000185FEA1D0-0x0000000185FEA1E0
		public bool Equals(StyleScale other) => default; // 0x000000018C057554-0x000000018C057590
		public override bool Equals(object obj) => default; // 0x000000018C057590-0x000000018C057624
		public override int GetHashCode() => default; // 0x000000018C057624-0x000000018C057644
		public override string ToString() => default; // 0x000000018C057644-0x000000018C0576AC
	}

	public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate> // TypeDefIndex: 44740
	{
		// Fields
		private Translate m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public Translate value { get => default; } // 0x000000018C056DA4-0x000000018C056DD8 
		public StyleKeyword keyword { get => default; } // 0x0000000185FC9940-0x0000000185FC9950 
	
		// Constructors
		public StyleTranslate(Translate v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FEA2D0-0x0000000185FEA2F0
		public StyleTranslate(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FEA160-0x0000000185FEA190
		internal StyleTranslate(Translate v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FC8330-0x0000000185FC8350
	
		// Methods
		public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs) => default; // 0x000000018C057CD8-0x000000018C057D50
		public static implicit operator StyleTranslate(StyleKeyword keyword) => default; // 0x0000000185FEA190-0x0000000185FEA1C0
		public static implicit operator StyleTranslate(Translate v) => default; // 0x0000000185FEA2F0-0x0000000185FEA320
		public bool Equals(StyleTranslate other) => default; // 0x000000018C057B6C-0x000000018C057BBC
		public override bool Equals(object obj) => default; // 0x000000018C057BBC-0x000000018C057C48
		public override int GetHashCode() => default; // 0x000000018C057C48-0x000000018C057C68
		public override string ToString() => default; // 0x000000018C057C68-0x000000018C057CD8
	}

	public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow> // TypeDefIndex: 44741
	{
		// Fields
		private StyleKeyword m_Keyword; // 0x00
		private TextShadow m_Value; // 0x04
	
		// Properties
		public TextShadow value { get => default; } // 0x000000018C05787C-0x000000018C0578B8 
		public StyleKeyword keyword { get => default; } // 0x0000000185FE64F0-0x0000000185FE6500 
	
		// Constructors
		public StyleTextShadow(StyleKeyword keyword) : this() {
			m_Keyword = default;
			m_Value = default;
		} // 0x0000000185FEA1E0-0x0000000185FEA210
		internal StyleTextShadow(TextShadow v, StyleKeyword keyword) : this() {
			m_Keyword = default;
			m_Value = default;
		} // 0x0000000185FEA210-0x0000000185FEA230
	
		// Methods
		public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs) => default; // 0x000000018C0578B8-0x000000018C057954
		public static implicit operator StyleTextShadow(StyleKeyword keyword) => default; // 0x0000000185FEA230-0x0000000185FEA270
		public bool Equals(StyleTextShadow other) => default; // 0x000000018C0577AC-0x000000018C0577EC
		public override bool Equals(object obj) => default; // 0x000000018C057718-0x000000018C0577AC
		public override int GetHashCode() => default; // 0x000000018C0577EC-0x000000018C057814
		public override string ToString() => default; // 0x000000018C057814-0x000000018C05787C
	}

	public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin> // TypeDefIndex: 44742
	{
		// Fields
		private TransformOrigin m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x14
	
		// Properties
		public TransformOrigin value { get => default; } // 0x000000018C057ABC-0x000000018C057ADC 
		public StyleKeyword keyword { get => default; } // 0x0000000185FB1090-0x0000000185FB10A0 
	
		// Constructors
		public StyleTransformOrigin(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FEA270-0x0000000185FEA280
		internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000185FEA280-0x0000000185FEA2A0
	
		// Methods
		public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs) => default; // 0x000000018C057ADC-0x000000018C057B6C
		public static implicit operator StyleTransformOrigin(StyleKeyword keyword) => default; // 0x0000000185FEA2A0-0x0000000185FEA2D0
		public bool Equals(StyleTransformOrigin other) => default; // 0x000000018C057954-0x000000018C057998
		public override bool Equals(object obj) => default; // 0x000000018C057998-0x000000018C057A30
		public override int GetHashCode() => default; // 0x000000018C057A30-0x000000018C057A50
		public override string ToString() => default; // 0x000000018C057A50-0x000000018C057ABC
	}

	internal interface IStyleValue<T> // TypeDefIndex: 44743
	{
		// Properties
		T value { get; }
		StyleKeyword keyword { get; }
	}

	public enum StyleKeyword // TypeDefIndex: 44744
	{
		Undefined = 0,
		Null = 1,
		Auto = 2,
		None = 3,
		Initial = 4
	}

	internal static class StyleValueExtensions // TypeDefIndex: 44745
	{
		// Methods
		internal static string DebugString<T>(IStyleValue<T> styleValue) => default;
		internal static YogaValue ToYogaValue(Length length) => default; // 0x000000018C058570-0x000000018C058690
		internal static Length ToLength(StyleKeyword keyword) => default; // 0x000000018C0581BC-0x000000018C05828C
		internal static Rotate ToRotate(StyleKeyword keyword) => default; // 0x000000018C0582B4-0x000000018C0583A8
		internal static Scale ToScale(StyleKeyword keyword) => default; // 0x000000018C0583A8-0x000000018C05847C
		internal static Translate ToTranslate(StyleKeyword keyword) => default; // 0x000000018C05847C-0x000000018C058570
		internal static Length ToLength(StyleLength styleLength) => default; // 0x000000018C05828C-0x000000018C0582B4
		internal static void CopyFrom<T>(List<T> list, List<T> other) {}
	}

	public enum TimeUnit // TypeDefIndex: 44746
	{
		Second = 0,
		Millisecond = 1
	}

	public struct TimeValue : IEquatable<TimeValue> // TypeDefIndex: 44747
	{
		// Fields
		private float m_Value; // 0x00
		private TimeUnit m_Unit; // 0x04
	
		// Properties
		public float value { get => default; } // 0x0000000185FB0F90-0x0000000185FB0FA0 
		public TimeUnit unit { get => default; } // 0x000000018357CBC0-0x000000018357CBD0 
	
		// Constructors
		public TimeValue(float value) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000185FB0F80-0x0000000185FB0F90
		public TimeValue(float value, TimeUnit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000185FB0F70-0x0000000185FB0F80
	
		// Methods
		public static implicit operator TimeValue(float value) => default; // 0x0000000185FEA070-0x0000000185FEA090
		public static bool operator ==(TimeValue lhs, TimeValue rhs) => default; // 0x000000018C04D3C8-0x000000018C04D3F4
		public static bool operator !=(TimeValue lhs, TimeValue rhs) => default; // 0x000000018C054000-0x000000018C054014
		public bool Equals(TimeValue other) => default; // 0x000000018C04D1FC-0x000000018C04D210
		public override bool Equals(object obj) => default; // 0x000000018C059CC4-0x000000018C059D34
		public override int GetHashCode() => default; // 0x000000018C04D210-0x000000018C04D230
		public override string ToString() => default; // 0x000000018C059D34-0x000000018C059DFC
	}

	public struct TransformOrigin : IEquatable<TransformOrigin> // TypeDefIndex: 44748
	{
		// Fields
		private Length m_X; // 0x00
		private Length m_Y; // 0x08
		private float m_Z; // 0x10
	
		// Properties
		public Length x { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public Length y { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x0000000185FB6DD0-0x0000000185FB6DE0
		public float z { get => default; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 
	
		// Constructors
		public TransformOrigin(Length x, Length y, float z) : this() {
			m_X = default;
			m_Y = default;
			m_Z = default;
		} // 0x0000000185FCC340-0x0000000185FCC350
	
		// Methods
		public static TransformOrigin Initial() => default; // 0x000000018C059F28-0x000000018C059F74
		public static bool operator ==(TransformOrigin lhs, TransformOrigin rhs) => default; // 0x000000018C05A094-0x000000018C05A120
		public static bool operator !=(TransformOrigin lhs, TransformOrigin rhs) => default; // 0x000000018C05A120-0x000000018C05A15C
		public bool Equals(TransformOrigin other) => default; // 0x000000018C059DFC-0x000000018C059E38
		public override bool Equals(object obj) => default; // 0x000000018C059E38-0x000000018C059ECC
		public override int GetHashCode() => default; // 0x000000018C059ECC-0x000000018C059F28
		public override string ToString() => default; // 0x000000018C059F74-0x000000018C05A094
	}

	public struct Translate : IEquatable<Translate> // TypeDefIndex: 44749
	{
		// Fields
		private Length m_X; // 0x00
		private Length m_Y; // 0x08
		private float m_Z; // 0x10
		private bool m_isNone; // 0x14
	
		// Properties
		public Length x { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public Length y { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x0000000185FB6DD0-0x0000000185FB6DE0
		public float z { get => default; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 
	
		// Constructors
		public Translate(Length x, Length y, float z) : this() {
			m_X = default;
			m_Y = default;
			m_Z = default;
			m_isNone = default;
		} // 0x0000000185FEA350-0x0000000185FEA370
	
		// Methods
		public static Translate None() => default; // 0x0000000185FEA320-0x0000000185FEA350
		public static bool operator ==(Translate lhs, Translate rhs) => default; // 0x000000018C05A358-0x000000018C05A44C
		public static bool operator !=(Translate lhs, Translate rhs) => default; // 0x000000018C05A44C-0x000000018C05A48C
		public bool Equals(Translate other) => default; // 0x000000018C05A15C-0x000000018C05A1A0
		public override bool Equals(object obj) => default; // 0x000000018C05A1A0-0x000000018C05A238
		public override int GetHashCode() => default; // 0x000000018C059ECC-0x000000018C059F28
		public override string ToString() => default; // 0x000000018C05A238-0x000000018C05A358
	}

	public interface IResolvedStyle // TypeDefIndex: 44750
	{
		// Properties
		UnityEngine.Color backgroundColor { get; }
		UnityEngine.Color borderBottomColor { get; }
		float borderBottomLeftRadius { get; }
		float borderBottomRightRadius { get; }
		float borderBottomWidth { get; }
		UnityEngine.Color borderLeftColor { get; }
		float borderLeftWidth { get; }
		UnityEngine.Color borderRightColor { get; }
		float borderRightWidth { get; }
		UnityEngine.Color borderTopColor { get; }
		float borderTopLeftRadius { get; }
		float borderTopRightRadius { get; }
		float borderTopWidth { get; }
		float bottom { get; }
		UnityEngine.Color color { get; }
		DisplayStyle display { get; }
		FlexDirection flexDirection { get; }
		float flexGrow { get; }
		float flexShrink { get; }
		float height { get; }
		float left { get; }
		float marginBottom { get; }
		float marginLeft { get; }
		float marginRight { get; }
		float marginTop { get; }
		StyleFloat minHeight { get; }
		StyleFloat minWidth { get; }
		float opacity { get; }
		float paddingBottom { get; }
		float paddingLeft { get; }
		float paddingRight { get; }
		float paddingTop { get; }
		float right { get; }
		Scale scale { get; }
		float top { get; }
		Vector3 transformOrigin { get; }
		Vector3 translate { get; }
		UnityEngine.Color unityBackgroundImageTintColor { get; }
		int unitySliceLeft { get; }
		int unitySliceRight { get; }
		UnityEngine.Color unityTextOutlineColor { get; }
		float unityTextOutlineWidth { get; }
		Visibility visibility { get; }
		WhiteSpace whiteSpace { get; }
		float width { get; }
	}

	public interface IStyle // TypeDefIndex: 44751
	{
		// Properties
		StyleColor backgroundColor { get; set; }
		StyleColor borderBottomColor { get; set; }
		StyleLength borderBottomLeftRadius { get; set; }
		StyleLength borderBottomRightRadius { get; set; }
		StyleFloat borderBottomWidth { get; set; }
		StyleColor borderLeftColor { get; set; }
		StyleFloat borderLeftWidth { get; set; }
		StyleColor borderRightColor { get; set; }
		StyleFloat borderRightWidth { get; set; }
		StyleColor borderTopColor { get; set; }
		StyleLength borderTopLeftRadius { get; set; }
		StyleLength borderTopRightRadius { get; set; }
		StyleFloat borderTopWidth { get; set; }
		StyleLength bottom { get; set; }
		StyleColor color { get; set; }
		StyleCursor cursor { get; }
		StyleEnum<DisplayStyle> display { get; set; }
		StyleLength flexBasis { get; set; }
		StyleEnum<FlexDirection> flexDirection { get; set; }
		StyleFloat flexGrow { get; set; }
		StyleFloat flexShrink { get; set; }
		StyleLength fontSize { get; set; }
		StyleLength height { get; set; }
		StyleLength left { get; set; }
		StyleLength marginBottom { get; set; }
		StyleLength marginLeft { get; set; }
		StyleLength marginRight { get; set; }
		StyleLength marginTop { get; set; }
		StyleLength maxHeight { get; set; }
		StyleLength maxWidth { get; set; }
		StyleLength minWidth { get; set; }
		StyleFloat opacity { get; set; }
		StyleLength paddingBottom { get; set; }
		StyleLength paddingLeft { get; set; }
		StyleLength paddingRight { get; set; }
		StyleLength paddingTop { get; set; }
		StyleEnum<Position> position { get; set; }
		StyleLength right { get; set; }
		StyleRotate rotate { get; }
		StyleScale scale { get; }
		StyleTextShadow textShadow { get; }
		StyleLength top { get; set; }
		StyleTransformOrigin transformOrigin { get; }
		StyleTranslate translate { get; set; }
		StyleColor unityBackgroundImageTintColor { get; set; }
		StyleEnum<Visibility> visibility { get; set; }
		StyleLength width { get; set; }
	}

	internal interface IStyleDataGroup<T> // TypeDefIndex: 44752
	{
		// Methods
		T Copy();
		void CopyFrom(ref ref T other);
	}

	internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData> // TypeDefIndex: 44753
	{
		// Fields
		public UnityEngine.Color color; // 0x00
		public Length fontSize; // 0x10
		public Length letterSpacing; // 0x18
		public TextShadow textShadow; // 0x20
		public Font unityFont; // 0x40
		public FontDefinition unityFontDefinition; // 0x48
		public FontStyle unityFontStyleAndWeight; // 0x58
		public Length unityParagraphSpacing; // 0x5C
		public TextAnchor unityTextAlign; // 0x64
		public UnityEngine.Color unityTextOutlineColor; // 0x68
		public float unityTextOutlineWidth; // 0x78
		public Visibility visibility; // 0x7C
		public WhiteSpace whiteSpace; // 0x80
		public Length wordSpacing; // 0x84
	
		// Methods
		public InheritedData Copy() => default; // 0x0000000185FEA510-0x0000000185FEA560
		public void CopyFrom(ref InheritedData other) {} // 0x000000018C05DFB0-0x000000018C05E06C
		public static bool operator ==(InheritedData lhs, InheritedData rhs) => default; // 0x000000018C05E364-0x000000018C05EE08
		public bool Equals(InheritedData other) => default; // 0x000000018C05E06C-0x000000018C05E138
		public override bool Equals(object obj) => default; // 0x000000018C05E138-0x000000018C05E204
		public override int GetHashCode() => default; // 0x000000018C05E204-0x000000018C05E364
	}

	internal struct LayoutData : IStyleDataGroup<UnityEngine.UIElements.LayoutData>, IEquatable<UnityEngine.UIElements.LayoutData> // TypeDefIndex: 44754
	{
		// Fields
		public Align alignContent; // 0x00
		public Align alignItems; // 0x04
		public Align alignSelf; // 0x08
		public float borderBottomWidth; // 0x0C
		public float borderLeftWidth; // 0x10
		public float borderRightWidth; // 0x14
		public float borderTopWidth; // 0x18
		public Length bottom; // 0x1C
		public DisplayStyle display; // 0x24
		public Length flexBasis; // 0x28
		public FlexDirection flexDirection; // 0x30
		public float flexGrow; // 0x34
		public float flexShrink; // 0x38
		public Wrap flexWrap; // 0x3C
		public Length height; // 0x40
		public Justify justifyContent; // 0x48
		public Length left; // 0x4C
		public Length marginBottom; // 0x54
		public Length marginLeft; // 0x5C
		public Length marginRight; // 0x64
		public Length marginTop; // 0x6C
		public Length maxHeight; // 0x74
		public Length maxWidth; // 0x7C
		public Length minHeight; // 0x84
		public Length minWidth; // 0x8C
		public Length paddingBottom; // 0x94
		public Length paddingLeft; // 0x9C
		public Length paddingRight; // 0xA4
		public Length paddingTop; // 0xAC
		public Position position; // 0xB4
		public Length right; // 0xB8
		public Length top; // 0xC0
		public Length width; // 0xC8
	
		// Methods
		public LayoutData Copy() => default; // 0x0000000185FEA670-0x0000000185FEA6F0
		public void CopyFrom(ref LayoutData other) {} // 0x0000000185FEA560-0x0000000185FEA670
		public static bool operator ==(LayoutData lhs, LayoutData rhs) => default; // 0x000000018C05F28C-0x000000018C061280
		public bool Equals(LayoutData other) => default; // 0x000000018C05EF00-0x000000018C05F00C
		public override bool Equals(object obj) => default; // 0x000000018C05EE08-0x000000018C05EF00
		public override int GetHashCode() => default; // 0x000000018C05F00C-0x000000018C05F28C
	}

	internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData> // TypeDefIndex: 44755
	{
		// Fields
		public UnityEngine.UIElements.Cursor cursor; // 0x00
		public TextOverflow textOverflow; // 0x18
		public UnityEngine.Color unityBackgroundImageTintColor; // 0x1C
		public UnityEngine.ScaleMode unityBackgroundScaleMode; // 0x2C
		public OverflowClipBox unityOverflowClipBox; // 0x30
		public int unitySliceBottom; // 0x34
		public int unitySliceLeft; // 0x38
		public int unitySliceRight; // 0x3C
		public int unitySliceTop; // 0x40
		public TextOverflowPosition unityTextOverflowPosition; // 0x44
	
		// Methods
		public RareData Copy() => default; // 0x0000000185FEA7B0-0x0000000185FEA7E0
		public void CopyFrom(ref RareData other) {} // 0x000000018C067E9C-0x000000018C067ECC
		public static bool operator ==(RareData lhs, RareData rhs) => default; // 0x000000018C068060-0x000000018C06825C
		public bool Equals(RareData other) => default; // 0x000000018C067F6C-0x000000018C067FE8
		public override bool Equals(object obj) => default; // 0x000000018C067ECC-0x000000018C067F6C
		public override int GetHashCode() => default; // 0x000000018C067FE8-0x000000018C068060
	}

	internal struct TransformData : IStyleDataGroup<UnityEngine.UIElements.TransformData>, IEquatable<UnityEngine.UIElements.TransformData> // TypeDefIndex: 44756
	{
		// Fields
		public Rotate rotate; // 0x00
		public Scale scale; // 0x18
		public TransformOrigin transformOrigin; // 0x28
		public Translate translate; // 0x3C
	
		// Methods
		public TransformData Copy() => default; // 0x0000000185FEA880-0x0000000185FEA8B0
		public void CopyFrom(ref TransformData other) {} // 0x0000000185FEA850-0x0000000185FEA880
		public static bool operator ==(TransformData lhs, TransformData rhs) => default; // 0x000000018C06E5FC-0x000000018C06E818
		public bool Equals(TransformData other) => default; // 0x000000018C06E464-0x000000018C06E4E8
		public override bool Equals(object obj) => default; // 0x000000018C06E4E8-0x000000018C06E594
		public override int GetHashCode() => default; // 0x000000018C06E594-0x000000018C06E5FC
	}

	internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData> // TypeDefIndex: 44757
	{
		// Fields
		public List<TimeValue> transitionDelay; // 0x00
		public List<TimeValue> transitionDuration; // 0x08
		public List<StylePropertyName> transitionProperty; // 0x10
		public List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction; // 0x18
	
		// Methods
		public TransitionData Copy() => default; // 0x000000018C06E970-0x000000018C06EB18
		public void CopyFrom(ref TransitionData other) {} // 0x000000018C06E818-0x000000018C06E970
		public static bool operator ==(TransitionData lhs, TransitionData rhs) => default; // 0x000000018C06EC80-0x000000018C06ECB8
		public bool Equals(TransitionData other) => default; // 0x000000018C06EB18-0x000000018C06EB58
		public override bool Equals(object obj) => default; // 0x000000018C06EB58-0x000000018C06EBEC
		public override int GetHashCode() => default; // 0x000000018C06EBEC-0x000000018C06EC80
	}

	internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData> // TypeDefIndex: 44758
	{
		// Fields
		public UnityEngine.Color backgroundColor; // 0x00
		public Background backgroundImage; // 0x10
		public UnityEngine.Color borderBottomColor; // 0x30
		public Length borderBottomLeftRadius; // 0x40
		public Length borderBottomRightRadius; // 0x48
		public UnityEngine.Color borderLeftColor; // 0x50
		public UnityEngine.Color borderRightColor; // 0x60
		public UnityEngine.Color borderTopColor; // 0x70
		public Length borderTopLeftRadius; // 0x80
		public Length borderTopRightRadius; // 0x88
		public float opacity; // 0x90
		public OverflowInternal overflow; // 0x94
	
		// Methods
		public VisualData Copy() => default; // 0x0000000185FEA8B0-0x0000000185FEA910
		public void CopyFrom(ref VisualData other) {} // 0x000000018C072D8C-0x000000018C072E64
		public static bool operator ==(VisualData lhs, VisualData rhs) => default; // 0x000000018C07312C-0x000000018C073B74
		public bool Equals(VisualData other) => default; // 0x000000018C072E64-0x000000018C072F4C
		public override bool Equals(object obj) => default; // 0x000000018C072F4C-0x000000018C073024
		public override int GetHashCode() => default; // 0x000000018C073024-0x000000018C07312C
	}

	internal struct Hashes // TypeDefIndex: 44760
	{
		// Fields
		public const int kSize = 4; // Metadata: 0x0205B73D
		public _hashes_e__FixedBuffer hashes; // 0x00
	
		// Nested types
		public struct _hashes_e__FixedBuffer // TypeDefIndex: 44759
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	}

	[Serializable]
	internal class StyleComplexSelector : ISerializationCallbackReceiver // TypeDefIndex: 44763
	{
		// Fields
		[NonSerialized]
		public Hashes ancestorHashes; // 0x10
		private int m_Specificity; // 0x20
		private StyleRule _rule_k__BackingField; // 0x28
		[NonSerialized]
		private bool m_isSimple; // 0x30
		private StyleSelector[] m_Selectors; // 0x38
		internal int ruleIndex; // 0x40
		[NonSerialized]
		internal StyleComplexSelector nextInTable; // 0x48
		[NonSerialized]
		internal int orderInStyleSheet; // 0x50
		private static Dictionary<string, PseudoStateData> s_PseudoStates; // 0x00
		private static List<StyleSelectorPart> m_HashList; // 0x08
	
		// Properties
		public int specificity { get => default; } // 0x0000000185FE7CE0-0x0000000185FE7CF0 
		public StyleRule rule { get; internal set; } // 0x000000018C068D94-0x000000018C068DC8 0x0000000185492010-0x0000000185492020
		public bool isSimple { get => default; } // 0x000000018C068B00-0x000000018C068B24 
		public StyleSelector[] selectors { get => default; internal set {} } // 0x000000018C06859C-0x000000018C068B00 0x000000018C068B24-0x000000018C068D00
	
		// Nested types
		private struct PseudoStateData // TypeDefIndex: 44761
		{
			// Fields
			public readonly PseudoStates state; // 0x00
			public readonly bool negate; // 0x04
	
			// Constructors
			public PseudoStateData(PseudoStates state, bool negate) {
				this.state = default;
				this.negate = default;
			} // 0x0000000185FE7AF0-0x0000000185FE7B00
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 44762
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<StyleSelector, string> __9__24_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001813B8590-0x00000001813B85A0
			public __c() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
	
			// Methods
			internal string _ToString_b__24_0(StyleSelector x) => default; // 0x0000000185FE7AD0-0x0000000185FE7AE0
		}
	
		// Constructors
		public StyleComplexSelector() {} // 0x0000000185492010-0x0000000185492020
		static StyleComplexSelector() {} // 0x000000018B7AE13C-0x000000018B7AE15C
	
		// Methods
		public void OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnAfterDeserialize() {} // 0x000000018C068D00-0x000000018C068D94
		internal void CachePseudoStateMasks() {} // 0x0000000185FB9F20-0x0000000185FB9F30
		public override string ToString() => default; // 0x000000018C06EEC8-0x000000018C06EF2C
	}

	[Serializable]
	internal class StyleProperty // TypeDefIndex: 44764
	{
		// Fields
		private string m_Name; // 0x10
		private int m_Line; // 0x18
		private StyleValueHandle[] m_Values; // 0x20
		[NonSerialized]
		internal bool isCustomProperty; // 0x28
		[NonSerialized]
		internal bool requireVariableResolve; // 0x29
	
		// Properties
		public string name { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
		public StyleValueHandle[] values { get => default; } // 0x0000000185FE66B0-0x0000000185FE66C0 
	
		// Constructors
		public StyleProperty() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal class StyleRule // TypeDefIndex: 44765
	{
		// Fields
		private StyleProperty[] m_Properties; // 0x10
		internal int line; // 0x18
		[NonSerialized]
		internal int customPropertiesCount; // 0x1C
	
		// Properties
		public StyleProperty[] properties { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
	
		// Constructors
		public StyleRule() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal class StyleSelector // TypeDefIndex: 44767
	{
		// Fields
		private StyleSelectorPart[] m_Parts; // 0x10
		private StyleSelectorRelationship m_PreviousRelationship; // 0x18
		internal int pseudoStateMask; // 0x1C
		internal int negatedPseudoStateMask; // 0x20
	
		// Properties
		public StyleSelectorPart[] parts { get => default; internal set {} } // 0x00000001813AE9C0-0x00000001813AE9D0 0x000000018C068F90-0x000000018C069140
		public StyleSelectorRelationship previousRelationship { get => default; internal set {} } // 0x0000000185FEA7E0-0x0000000185FEA7F0 0x000000018C06ED9C-0x000000018C06EE00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44766
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<StyleSelectorPart, string> __9__10_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185FC7990-0x0000000185FC79A0
			public __c() {} // 0x0000000184096E30-0x0000000184096EF0
	
			// Methods
			internal string _ToString_b__10_0(StyleSelectorPart p) => default; // 0x0000000185FC9940-0x0000000185FC9950
		}
	
		// Constructors
		public StyleSelector() {} // 0x000000018C06ED00-0x000000018C06ED14
	
		// Methods
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	internal struct StyleSelectorPart // TypeDefIndex: 44768
	{
		// Fields
		private string m_Value; // 0x00
		private StyleSelectorType m_Type; // 0x08
		internal object tempData; // 0x10
	
		// Properties
		public string value { get => default; } // 0x0000000184142CB0-0x0000000184142CC0 
		public StyleSelectorType type { get => default; internal set {} } // 0x00000001835DC780-0x00000001835DC790 0x0000000185FB2B90-0x0000000185FB2BA0
	
		// Methods
		public override string ToString() => default; // 0x000000018C068EB8-0x000000018C068F90
		public static StyleSelectorPart CreateClass(string className) => default; // 0x000000018C068DC8-0x000000018C068E18
		public static StyleSelectorPart CreateId(string Id) => default; // 0x000000018C068E18-0x000000018C068E68
		public static StyleSelectorPart CreatePredicate(object predicate) => default; // 0x000000018C068E68-0x000000018C068EB8
	}

	internal enum StyleSelectorRelationship // TypeDefIndex: 44769
	{
		None = 0,
		Child = 1,
		Descendent = 2
	}

	internal enum StyleSelectorType // TypeDefIndex: 44770
	{
		Unknown = 0,
		Wildcard = 1,
		Type = 2,
		Class = 3,
		PseudoClass = 4,
		RecursivePseudoClass = 5,
		ID = 6,
		Predicate = 7
	}

	[Serializable]
	public class StyleSheet : ScriptableObject // TypeDefIndex: 44772
	{
		// Fields
		private bool m_ImportedWithErrors; // 0x18
		private bool m_ImportedWithWarnings; // 0x19
		private StyleRule[] m_Rules; // 0x20
		private StyleComplexSelector[] m_ComplexSelectors; // 0x28
		internal float[] floats; // 0x30
		internal Dimension[] dimensions; // 0x38
		internal UnityEngine.Color[] colors; // 0x40
		internal string[] strings; // 0x48
		internal UnityEngine.Object[] assets; // 0x50
		internal ImportStruct[] imports; // 0x58
		private List<StyleSheet> m_FlattenedImportedStyleSheets; // 0x60
		private int m_ContentHash; // 0x68
		internal ScalableImage[] scalableImages; // 0x70
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedNameSelectors; // 0x78
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedTypeSelectors; // 0x80
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedClassSelectors; // 0x88
		[NonSerialized]
		private bool m_IsDefaultStyleSheet; // 0x90
		private static string kCustomPropertyMarker; // 0x00
	
		// Properties
		public bool importedWithErrors { get => default; internal set {} } // 0x0000000185FEA810-0x0000000185FEA820 0x00000001813C0520-0x00000001813C0530
		public bool importedWithWarnings { get => default; internal set {} } // 0x0000000185FEA820-0x0000000185FEA830 0x0000000181A73EB0-0x0000000181A73EC0
		internal StyleRule[] rules { get => default; set {} } // 0x0000000185FE66B0-0x0000000185FE66C0 0x000000018C06A488-0x000000018C06A4AC
		internal StyleComplexSelector[] complexSelectors { get => default; set {} } // 0x0000000185FE7B00-0x0000000185FE7B10 0x000000018C06A344-0x000000018C06A368
		internal List<StyleSheet> flattenedRecursiveImports { get => default; } // 0x0000000185FE8BA0-0x0000000185FE8BB0 
		public int contentHash { get => default; set {} } // 0x0000000185FEA800-0x0000000185FEA810 0x0000000185FB0B10-0x0000000185FB0B20
		internal bool isDefaultStyleSheet { get => default; set {} } // 0x0000000185FEA830-0x0000000185FEA840 0x000000018C06A368-0x000000018C06A488
	
		// Nested types
		[Serializable]
		internal struct ImportStruct // TypeDefIndex: 44771
		{
			// Fields
			public StyleSheet styleSheet; // 0x00
			public string[] mediaQueries; // 0x08
		}
	
		// Constructors
		public StyleSheet() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
		static StyleSheet() {} // 0x000000018C06A2E8-0x000000018C06A344
	
		// Methods
		private static bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out ref T value) {
			value = default;
			return default;
		}
		private static T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle) => default;
		internal virtual void OnEnable() {} // 0x000000018C069368-0x000000018C069370
		internal void FlattenImportedStyleSheetsRecursive() {} // 0x000000018C0692E4-0x000000018C069368
		private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) {} // 0x000000018C0691EC-0x000000018C0692E4
		private void SetupReferences() {} // 0x000000018C06997C-0x000000018C069E18
		internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) => default; // 0x0000000185FEA7F0-0x0000000185FEA800
		internal float ReadFloat(StyleValueHandle handle) => default; // 0x000000018C06958C-0x000000018C069634
		internal bool TryReadFloat(StyleValueHandle handle, out float value) {
			value = default;
			return default;
		} // 0x000000018C06A088-0x000000018C06A168
		internal Dimension ReadDimension(StyleValueHandle handle) => default; // 0x000000018C069470-0x000000018C069520
		internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) {
			value = default;
			return default;
		} // 0x000000018C069F18-0x000000018C06A008
		internal UnityEngine.Color ReadColor(StyleValueHandle handle) => default; // 0x000000018C0693DC-0x000000018C069470
		internal bool TryReadColor(StyleValueHandle handle, out UnityEngine.Color value) {
			value = default;
			return default;
		} // 0x000000018C069E98-0x000000018C069F18
		internal string ReadString(StyleValueHandle handle) => default; // 0x000000018C0698A4-0x000000018C069910
		internal bool TryReadString(StyleValueHandle handle, out string value) {
			value = default;
			return default;
		} // 0x000000018C06A1E8-0x000000018C06A268
		internal string ReadEnum(StyleValueHandle handle) => default; // 0x000000018C069520-0x000000018C06958C
		internal bool TryReadEnum(StyleValueHandle handle, out string value) {
			value = default;
			return default;
		} // 0x000000018C06A008-0x000000018C06A088
		internal string ReadVariable(StyleValueHandle handle) => default; // 0x000000018C069910-0x000000018C06997C
		internal bool TryReadVariable(StyleValueHandle handle, out string value) {
			value = default;
			return default;
		} // 0x000000018C06A268-0x000000018C06A2E8
		internal string ReadResourcePath(StyleValueHandle handle) => default; // 0x000000018C0697A4-0x000000018C069810
		internal bool TryReadResourcePath(StyleValueHandle handle, out string value) {
			value = default;
			return default;
		} // 0x000000018C06A168-0x000000018C06A1E8
		internal UnityEngine.Object ReadAssetReference(StyleValueHandle handle) => default; // 0x000000018C069370-0x000000018C0693DC
		internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) => default; // 0x000000018C069738-0x000000018C0697A4
		internal bool TryReadAssetReference(StyleValueHandle handle, out UnityEngine.Object value) {
			value = default;
			return default;
		} // 0x000000018C069E18-0x000000018C069E98
		internal StyleValueFunction ReadFunction(StyleValueHandle handle) => default; // 0x0000000185FEA7F0-0x0000000185FEA800
		internal string ReadFunctionName(StyleValueHandle handle) => default; // 0x000000018C069634-0x000000018C069738
		internal ScalableImage ReadScalableImage(StyleValueHandle handle) => default; // 0x000000018C069810-0x000000018C0698A4
		private static bool CustomStartsWith(string originalString, string pattern) => default; // 0x000000018C069140-0x000000018C0691EC
	}

	internal enum StyleValueFunction // TypeDefIndex: 44773
	{
		Unknown = 0,
		Var = 1,
		Env = 2,
		LinearGradient = 3
	}

	internal static class StyleValueFunctionExtension // TypeDefIndex: 44774
	{
		// Methods
		public static string ToUssString(StyleValueFunction svf) => default; // 0x000000018C06A4AC-0x000000018C06A5C4
	}

	[Serializable]
	internal struct StyleValueHandle // TypeDefIndex: 44775
	{
		// Fields
		private StyleValueType m_ValueType; // 0x00
		internal int valueIndex; // 0x04
	
		// Properties
		public StyleValueType valueType { get => default; internal set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x00000001818AA390-0x00000001818AA3A0
	}

	internal enum StyleValueKeyword // TypeDefIndex: 44776
	{
		Inherit = 0,
		Initial = 1,
		Auto = 2,
		Unset = 3,
		True = 4,
		False = 5,
		None = 6
	}

	internal static class StyleValueKeywordExtension // TypeDefIndex: 44777
	{
		// Methods
		public static string ToUssString(StyleValueKeyword svk) => default; // 0x000000018C06A5C4-0x000000018C06A754
	}

	internal enum StyleValueType // TypeDefIndex: 44778
	{
		Invalid = 0,
		Keyword = 1,
		Float = 2,
		Dimension = 3,
		Color = 4,
		ResourcePath = 5,
		AssetReference = 6,
		Enum = 7,
		Variable = 8,
		String = 9,
		Function = 10,
		CommaSeparator = 11,
		ScalableImage = 12,
		MissingAssetReference = 13
	}

	internal struct StyleVariable // TypeDefIndex: 44779
	{
		// Fields
		public readonly string name; // 0x00
		public readonly StyleSheet sheet; // 0x08
		public readonly StyleValueHandle[] handles; // 0x10
	
		// Constructors
		public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles) {
			this.name = default;
			this.sheet = default;
			this.handles = default;
		} // 0x000000018476BBB0-0x000000018476BBE0
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018C06BB28-0x000000018C06BB9C
	}

	internal class StyleVariableContext // TypeDefIndex: 44781
	{
		// Fields
		public static readonly StyleVariableContext none; // 0x00
		private int m_VariableHash; // 0x10
		private List<StyleVariable> m_Variables; // 0x18
		private List<int> m_SortedHash; // 0x20
		private List<int> m_UnsortedHash; // 0x28
	
		// Nested types
		private struct __c__DisplayClass7_0 // TypeDefIndex: 44780
		{
			// Fields
			public int hash; // 0x00
		}
	
		// Constructors
		public StyleVariableContext() {} // 0x000000018C06ADAC-0x000000018C06AEA4
		public StyleVariableContext(StyleVariableContext other) {} // 0x000000018C06AC7C-0x000000018C06ADAC
		static StyleVariableContext() {} // 0x000000018C06AC0C-0x000000018C06AC7C
	
		// Methods
		public void Add(StyleVariable sv) {} // 0x000000018C06A850-0x000000018C06AA78
		public void AddInitialRange(StyleVariableContext other) {} // 0x000000018C06A754-0x000000018C06A850
		public void Clear() {} // 0x000000018C06AA78-0x000000018C06AB04
		public bool TryFindVariable(string name, out StyleVariable v) {
			v = default;
			return default;
		} // 0x000000018C06AB04-0x000000018C06AC0C
		public int GetVariableHash() => default; // 0x0000000185FE6790-0x0000000185FE67A0
		internal static int _Add_g__ComputeOrderSensitiveHash_7_0(int index, ref __c__DisplayClass7_0 param_0005f2dc) => default; // 0x0000000185FEA840-0x0000000185FEA850
	}

	internal class StyleVariableResolver // TypeDefIndex: 44784
	{
		// Fields
		internal const int kMaxResolves = 100; // Metadata: 0x0205B762
		private static StyleSyntaxParser s_SyntaxParser; // 0x00
		private StylePropertyValueMatcher m_Matcher; // 0x10
		private List<StylePropertyValue> m_ResolvedValues; // 0x18
		private Stack<string> m_ResolvedVarStack; // 0x20
		private StyleProperty m_Property; // 0x28
		private Stack<ResolveContext> m_ContextStack; // 0x30
		private ResolveContext m_CurrentContext; // 0x38
		private StyleVariableContext _variableContext_k__BackingField; // 0x48
	
		// Properties
		private StyleSheet currentSheet { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		private StyleValueHandle[] currentHandles { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public List<StylePropertyValue> resolvedValues { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public StyleVariableContext variableContext { get; set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
	
		// Nested types
		private enum Result // TypeDefIndex: 44782
		{
			Valid = 0,
			Invalid = 1,
			NotFound = 2
		}
	
		private struct ResolveContext // TypeDefIndex: 44783
		{
			// Fields
			public StyleSheet sheet; // 0x00
			public StyleValueHandle[] handles; // 0x08
		}
	
		// Constructors
		public StyleVariableResolver() {} // 0x000000018C06B9E4-0x000000018C06BB28
		static StyleVariableResolver() {} // 0x000000018C06B968-0x000000018C06B9E4
	
		// Methods
		public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) {} // 0x000000018C06AF28-0x000000018C06AFD4
		private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) {} // 0x000000018C06B100-0x000000018C06B1A8
		private void PopContext() {} // 0x000000018C06B07C-0x000000018C06B100
		public void AddValue(StyleValueHandle handle) {} // 0x000000018C06AEA4-0x000000018C06AF28
		public bool ResolveVarFunction(ref int index) => default; // 0x000000018C06B4E4-0x000000018C06B5A8
		private Result ResolveVarFunction(ref int index, int argc, string varName) => default; // 0x000000018C06B3BC-0x000000018C06B4E4
		public bool ValidateResolvedValues() => default; // 0x000000018C06B824-0x000000018C06B968
		private Result ResolveVariable(string variableName) => default; // 0x000000018C06B5A8-0x000000018C06B824
		private Result ResolveFallback(ref int index) => default; // 0x000000018C06B1A8-0x000000018C06B3BC
		private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) {
			argCount = default;
			variableName = default;
		} // 0x000000018C06AFD4-0x000000018C06B07C
	}

	[Serializable]
	public class ThemeStyleSheet : StyleSheet // TypeDefIndex: 44785
	{
		// Constructors
		public ThemeStyleSheet() {} // 0x000000018C06E418-0x000000018C06E464
	
		// Methods
		internal override void OnEnable() {} // 0x000000018C06E3F4-0x000000018C06E418
	}

	public class PanelTextSettings : TextSettings // TypeDefIndex: 44786
	{
		// Fields
		private static PanelTextSettings s_DefaultPanelTextSettings; // 0x00
		internal static Func<string, UnityEngine.Object> EditorGUIUtilityLoad; // 0x08
		internal static Func<SystemLanguage> GetCurrentLanguage; // 0x10
		internal static readonly string s_DefaultEditorPanelTextSettingPath; // 0x18
	
		// Properties
		internal static PanelTextSettings defaultPanelTextSettings { get => default; } // 0x000000018C067D8C-0x000000018C067E9C 
	
		// Constructors
		public PanelTextSettings() {} // 0x000000018C067D84-0x000000018C067D8C
		static PanelTextSettings() {} // 0x000000018C067D24-0x000000018C067D84
	
		// Methods
		internal static void UpdateLocalizationFontAsset() {} // 0x000000018C0678E8-0x000000018C067D24
		internal FontAsset GetCachedFontAsset(Font font) => default; // 0x000000018C0678DC-0x000000018C0678E8
	}

	internal interface ITextHandle // TypeDefIndex: 44787
	{
		// Properties
		Vector2 MeasuredSizes { get; set; }
		Vector2 RoundedSizes { get; set; }
	
		// Methods
		Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling);
		float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling);
		float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling);
		float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
		TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
		bool IsLegacy();
		bool IsElided();
	}

	internal struct TextCoreHandle : ITextHandle // TypeDefIndex: 44788
	{
		// Fields
		private Vector2 _MeasuredSizes_k__BackingField; // 0x00
		private Vector2 _RoundedSizes_k__BackingField; // 0x08
		private Vector2 m_PreferredSize; // 0x10
		private int m_PreviousGenerationSettingsHash; // 0x18
		private UnityEngine.TextCore.Text.TextGenerationSettings m_CurrentGenerationSettings; // 0x20
		private static UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings; // 0x00
		private TextInfo m_TextInfoMesh; // 0x28
		private static TextInfo s_TextInfoLayout; // 0x08
		private bool isDirty; // 0x30
	
		// Properties
		public Vector2 MeasuredSizes { get; set; } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public Vector2 RoundedSizes { get; set; } // 0x0000000185FB8260-0x0000000185FB8280 0x0000000185FB6DD0-0x0000000185FB6DE0
		internal TextInfo textInfoMesh { get => default; } // 0x000000018C06CE54-0x000000018C06CEC4 
		internal static TextInfo textInfoLayout { get => default; } // 0x000000018C06CD88-0x000000018C06CE54 
	
		// Constructors
		static TextCoreHandle() {
			s_LayoutSettings = default;
			s_TextInfoLayout = default;
		} // 0x000000018C06CD0C-0x000000018C06CD88
	
		// Methods
		public static ITextHandle New() => default; // 0x000000018C06C168-0x000000018C06C22C
		public bool IsLegacy() => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
		public bool IsDirty(MeshGenerationContextUtils.TextParams parms) => default; // 0x000000018C06C0E0-0x000000018C06C114
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling) => default; // 0x000000018C06BD9C-0x000000018C06BE28
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x000000018C06BCE0-0x000000018C06BD9C
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x000000018C06BC24-0x000000018C06BCE0
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint) => default; // 0x000000018C06BE28-0x000000018C06BF24
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint) => default; // 0x000000018C06C9D4-0x000000018C06CD0C
		private void UpdatePreferredValues(MeshGenerationContextUtils.TextParams parms) {} // 0x000000018C06C880-0x000000018C06C9D4
		private static TextOverflowMode GetTextOverflowMode(MeshGenerationContextUtils.TextParams textParams) => default; // 0x000000018C06BF24-0x000000018C06C0E0
		private static void UpdateGenerationSettingsCommon(MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings) {} // 0x000000018C06C22C-0x000000018C06C880
		public bool IsElided() => default; // 0x000000018C06C114-0x000000018C06C168
	}

	internal struct TextNativeHandle : ITextHandle // TypeDefIndex: 44789
	{
		// Fields
		private Vector2 _MeasuredSizes_k__BackingField; // 0x00
		private Vector2 _RoundedSizes_k__BackingField; // 0x08
		internal NativeArray<UnityEngine.UIElements.TextVertex> textVertices; // 0x10
		private int m_PreviousTextParamsHash; // 0x20
	
		// Properties
		public Vector2 MeasuredSizes { get; set; } // 0x00000001834AFB60-0x00000001834AFB70 0x0000000185FB2BB0-0x0000000185FB2BC0
		public Vector2 RoundedSizes { get; set; } // 0x0000000185FB8260-0x0000000185FB8280 0x0000000185FB6DD0-0x0000000185FB6DE0
	
		// Methods
		public static ITextHandle New() => default; // 0x000000018C06D3E8-0x000000018C06D444
		public bool IsLegacy() => default; // 0x0000000185FC71B0-0x0000000185FC71C0
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint) => default; // 0x000000018C06D0D4-0x000000018C06D164
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint) => default; // 0x000000018C06D444-0x000000018C06D494
		public NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x000000018C06D164-0x000000018C06D3E8
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling) => default; // 0x000000018C06D058-0x000000018C06D0D4
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x000000018C06CF78-0x000000018C06D058
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x000000018C06CEC4-0x000000018C06CF78
		public bool IsElided() => default; // 0x0000000185FAFEF0-0x0000000185FAFF00
	}

	internal static class TextUtilities // TypeDefIndex: 44790
	{
		// Methods
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint) => default; // 0x000000018C06D494-0x000000018C06D524
		internal static Vector2 MeasureVisualElementTextSize(VisualElement ve, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, ITextHandle textHandle) => default; // 0x000000018C06E04C-0x000000018C06E3F4
		internal static FontAsset GetFontAsset(MeshGenerationContextUtils.TextParams textParam) => default; // 0x000000018C06D524-0x000000018C06D698
		internal static FontAsset GetFontAsset(VisualElement ve) => default; // 0x000000018C06D698-0x000000018C06D7D0
		internal static Font GetFont(MeshGenerationContextUtils.TextParams textParam) => default; // 0x000000018C06D7D0-0x000000018C06D928
		internal static Font GetFont(VisualElement ve) => default; // 0x000000018C06D928-0x000000018C06DA70
		internal static bool IsFontAssigned(VisualElement ve) => default; // 0x000000018C06DFA0-0x000000018C06E04C
		internal static bool IsFontAssigned(MeshGenerationContextUtils.TextParams textParams) => default; // 0x000000018C06DED4-0x000000018C06DFA0
		internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve) => default; // 0x000000018C06DD68-0x000000018C06DDF0
		internal static PanelTextSettings GetTextSettingsFrom(MeshGenerationContextUtils.TextParams textParam) => default; // 0x000000018C06DDF0-0x000000018C06DED4
		internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve) => default; // 0x000000018C06DA70-0x000000018C06DD68
	}

	public interface IUxmlAttributes // TypeDefIndex: 44791
	{
		// Methods
		bool TryGetAttributeValue(string attributeName, out string value);
	}

	public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits> // TypeDefIndex: 44792
	{
		// Properties
		public override string uxmlName { get => default; } // 0x000000018C0724B8-0x000000018C0724E4 
		public override string uxmlQualifiedName { get => default; } // 0x000000018C0724E4-0x000000018C072558 
	
		// Constructors
		public UxmlRootElementFactory() {} // 0x000000018C07247C-0x000000018C0724B8
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
	}

	public class UxmlRootElementTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 44793
	{
		// Fields
		protected UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Class; // 0x20
	
		// Constructors
		public UxmlRootElementTraits() {} // 0x000000018C072558-0x000000018C07262C
	}

	public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits> // TypeDefIndex: 44794
	{
		// Properties
		public override string uxmlName { get => default; } // 0x000000018C0729C0-0x000000018C0729EC 
		public override string uxmlQualifiedName { get => default; } // 0x000000018C0729EC-0x000000018C072A60 
	
		// Constructors
		public UxmlStyleFactory() {} // 0x000000018C072984-0x000000018C0729C0
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
	}

	public class UxmlStyleTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 44795
	{
		// Fields
		private UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Path; // 0x20
		private UxmlStringAttributeDescription m_Src; // 0x28
	
		// Constructors
		public UxmlStyleTraits() {} // 0x000000018C072A60-0x000000018C072B84
	}

	public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits> // TypeDefIndex: 44796
	{
		// Properties
		public override string uxmlName { get => default; } // 0x000000018C072BC0-0x000000018C072BEC 
		public override string uxmlQualifiedName { get => default; } // 0x000000018C072BEC-0x000000018C072C60 
	
		// Constructors
		public UxmlTemplateFactory() {} // 0x000000018C072B84-0x000000018C072BC0
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
	}

	public class UxmlTemplateTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 44797
	{
		// Fields
		private UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Path; // 0x20
		private UxmlStringAttributeDescription m_Src; // 0x28
	
		// Constructors
		public UxmlTemplateTraits() {} // 0x000000018C072C60-0x000000018C072D8C
	}

	public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits> // TypeDefIndex: 44798
	{
		// Properties
		public override string uxmlName { get => default; } // 0x000000018C070DC0-0x000000018C070DEC 
		public override string uxmlQualifiedName { get => default; } // 0x000000018C070DEC-0x000000018C070E60 
	
		// Constructors
		public UxmlAttributeOverridesFactory() {} // 0x000000018C070D84-0x000000018C070DC0
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000185FE67B0-0x0000000185FE67C0
	}

	public class UxmlAttributeOverridesTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 44799
	{
		// Fields
		private UxmlStringAttributeDescription m_ElementName; // 0x18
	
		// Constructors
		public UxmlAttributeOverridesTraits() {} // 0x000000018C070E60-0x000000018C070EF0
	}

	[Serializable]
	internal class TemplateAsset : VisualElementAsset // TypeDefIndex: 44801
	{
		// Fields
		private string m_TemplateAlias; // 0x70
		private List<AttributeOverride> m_AttributeOverrides; // 0x78
		private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages; // 0x80
	
		// Properties
		public List<AttributeOverride> attributeOverrides { get => default; } // 0x000000018C06BB9C-0x000000018C06BC24 
		internal List<VisualTreeAsset.SlotUsageEntry> slotUsages { get => default; } // 0x0000000185FE8C40-0x0000000185FE8C50 
	
		// Nested types
		[Serializable]
		public struct AttributeOverride // TypeDefIndex: 44800
		{
			// Fields
			public string m_ElementName; // 0x00
			public string m_AttributeName; // 0x08
			public string m_Value; // 0x10
		}
	
		// Constructors
		public TemplateAsset() {} // Dummy constructor
	}

	public abstract class UxmlAttributeDescription // TypeDefIndex: 44803
	{
		// Fields
		private string _name_k__BackingField; // 0x10
		private string[] m_ObsoleteNames; // 0x18
		private string _type_k__BackingField; // 0x20
		private string _typeNamespace_k__BackingField; // 0x28
		private Use _use_k__BackingField; // 0x30
		private UxmlTypeRestriction _restriction_k__BackingField; // 0x38
	
		// Properties
		public string name { get; set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public IEnumerable<string> obsoleteNames { get; set; } // 0x000000018C070D30-0x000000018C070D84
		protected string type { get; set; } // 0x000000018646EE40-0x000000018646EE50
		protected string typeNamespace { get; set; } // 0x0000000184A4EDC0-0x0000000184A4EDD0
		public Use use { get; set; } // 0x00000001813D0A90-0x00000001813D0AA0
		public UxmlTypeRestriction restriction { get; set; } // 0x0000000185A16440-0x0000000185A16450
	
		// Nested types
		public enum Use // TypeDefIndex: 44802
		{
			None = 0,
			Optional = 1,
			Prohibited = 2,
			Required = 3
		}
	
		// Constructors
		protected UxmlAttributeDescription() {} // 0x0000000189EF35A4-0x0000000189EF35BC
	
		// Methods
		internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value) {
			value = default;
			return default;
		} // 0x000000018C0709AC-0x000000018C070D30
		protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref ref T value) => default;
		protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue) => default;
	}

	public abstract class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription // TypeDefIndex: 44804
	{
		// Fields
		private T _defaultValue_k__BackingField;
	
		// Properties
		public T defaultValue { get; set; }
	
		// Constructors
		protected TypedUxmlAttributeDescription() {}
	
		// Methods
		public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
	}

	public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string> // TypeDefIndex: 44806
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44805
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, string, string> __9__3_0; // 0x08
			public static Func<string, string, string> __9__4_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018C0728DC-0x000000018C072984
			public __c() {} // 0x000000018C07262C-0x000000018C072780
	
			// Methods
			internal string _GetValueFromBag_b__3_0(string s, string t) => default; // 0x000000018C072780-0x000000018C0728DC
			internal string _TryGetValueFromBag_b__4_0(string s, string t) => default; // 0x000000018C06EE64-0x000000018C06EEC8
		}
	
		// Constructors
		public UxmlStringAttributeDescription() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x00000001834A4750-0x00000001834A4760
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value) => default; // 0x00000001834A4750-0x00000001834A4760
	}

	public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<float> // TypeDefIndex: 44808
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44807
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, float, float> __9__3_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018C0714F0-0x000000018C071570
			public __c() {} // 0x000000018C071398-0x000000018C0714F0
	
			// Methods
			internal float _GetValueFromBag_b__3_0(string s, float f) => default; // 0x000000018C071318-0x000000018C071398
		}
	
		// Constructors
		public UxmlFloatAttributeDescription() {} // 0x000000018C06ED38-0x000000018C06ED9C
	
		// Methods
		public override float GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000185492010-0x0000000185492020
		private static float ConvertValueToFloat(string v, float defaultValue) => default; // 0x000000018C06ECF0-0x000000018C06ED00
	}

	public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int> // TypeDefIndex: 44810
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44809
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, int, int> __9__3_0; // 0x08
			public static Func<string, int, int> __9__4_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018C07184C-0x000000018C0718D8
			public __c() {} // 0x000000018C0715A0-0x000000018C0716F4
	
			// Methods
			internal int _GetValueFromBag_b__3_0(string s, int i) => default; // 0x000000018C0716F4-0x000000018C07184C
			internal int _TryGetValueFromBag_b__4_0(string s, int i) => default; // 0x000000018C071570-0x000000018C0715A0
		}
	
		// Constructors
		public UxmlIntAttributeDescription() {} // 0x000000018C06EF2C-0x000000018C06EF90
	
		// Methods
		public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000185492010-0x0000000185492020
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value) => default; // 0x000000018C06ECB8-0x000000018C06ECC8
		private static int ConvertValueToInt(string v, int defaultValue) => default; // 0x000000018C06ECB8-0x000000018C06ECC8
	}

	public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long> // TypeDefIndex: 44812
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44811
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, long, long> __9__3_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018C071A60-0x000000018C071AEC
			public __c() {} // 0x000000018C07190C-0x000000018C071A60
	
			// Methods
			internal long _GetValueFromBag_b__3_0(string s, long l) => default; // 0x000000018C0718D8-0x000000018C07190C
		}
	
		// Constructors
		public UxmlLongAttributeDescription() {} // 0x000000018C06EF90-0x000000018C06EFF4
	
		// Methods
		public override long GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000185492010-0x0000000185492020
		private static long ConvertValueToLong(string v, long defaultValue) => default; // 0x000000018C06ECC8-0x000000018C06ECDC
	}

	public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool> // TypeDefIndex: 44814
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44813
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool, bool> __9__3_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018C0710AC-0x000000018C071138
			public __c() {} // 0x000000018C070F58-0x000000018C0710AC
	
			// Methods
			internal bool _GetValueFromBag_b__3_0(string s, bool b) => default; // 0x000000018C070EF0-0x000000018C070F58
		}
	
		// Constructors
		public UxmlBoolAttributeDescription() {} // 0x000000018C06EE00-0x000000018C06EE64
	
		// Methods
		public override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000185492010-0x0000000185492020
		private static bool ConvertValueToBool(string v, bool defaultValue) => default; // 0x000000018C06ECDC-0x000000018C06ECF0
	}

	public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> // TypeDefIndex: 44816
		where T : struct, IConvertible
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44815
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<string, T, T> __9__3_0;
			public static Func<string, T, T> __9__4_0;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal T _GetValueFromBag_b__3_0(string s, T convertible) => default;
			internal T _TryGetValueFromBag_b__4_0(string s, T convertible) => default;
		}
	
		// Constructors
		public UxmlEnumAttributeDescription() {}
	
		// Methods
		public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default;
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref ref T value) => default;
		private static U ConvertValueToEnum<U>(string v, U defaultValue) => default;
	}

	internal class UxmlObjectAttributeDescription<T> // TypeDefIndex: 44817
		where T : new()
	{
		// Fields
		private T _defaultValue_k__BackingField;
	
		// Properties
		public T defaultValue { get; }
	
		// Constructors
		public UxmlObjectAttributeDescription() {}
	
		// Methods
		public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default;
	}

	internal class UxmlObjectListAttributeDescription<T> : UxmlObjectAttributeDescription<List<T>> // TypeDefIndex: 44818
		where T : new()
	{
		// Constructors
		public UxmlObjectListAttributeDescription() {}
	
		// Methods
		public override List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default;
	}

	public abstract class UxmlTraits // TypeDefIndex: 44819
	{
		// Fields
		private bool _canHaveAnyAttribute_k__BackingField; // 0x10
	
		// Properties
		protected bool canHaveAnyAttribute { get; set; } // 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		protected UxmlTraits() {} // 0x0000000181B9A230-0x0000000181B9A240
	
		// Methods
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000185492010-0x0000000185492020
	}

	public interface IUxmlFactory // TypeDefIndex: 44820
	{
		// Properties
		string uxmlQualifiedName { get; }
	
		// Methods
		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
		VisualElement Create(IUxmlAttributes bag, CreationContext cc);
	}

	public class UxmlFactory<TCreatedType, TTraits> : IUxmlFactory // TypeDefIndex: 44821
		where TCreatedType : VisualElement, new()
		where TTraits : UnityEngine.UIElements.UxmlTraits, new()
	{
		// Fields
		internal TTraits m_Traits;
	
		// Properties
		public virtual string uxmlName { get => default; }
		public virtual string uxmlNamespace { get => default; }
		public virtual string uxmlQualifiedName { get => default; }
	
		// Constructors
		protected UxmlFactory() {}
	
		// Methods
		public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) => default;
		public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default;
	}

	public class UxmlFactory<TCreatedType> : UxmlFactory<TCreatedType, VisualElement.UxmlTraits> // TypeDefIndex: 44822
		where TCreatedType : VisualElement, new()
	{
		// Constructors
		public UxmlFactory() {}
	}

	public abstract class BaseUxmlTraits // TypeDefIndex: 44823
	{
		// Fields
		private bool _canHaveAnyAttribute_k__BackingField; // 0x10
	
		// Properties
		protected bool canHaveAnyAttribute { get; set; } // 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		protected BaseUxmlTraits() {} // 0x0000000181B9A230-0x0000000181B9A240
	}

	internal abstract class UxmlObjectTraits<T> : BaseUxmlTraits // TypeDefIndex: 44824
	{
		// Constructors
		protected UxmlObjectTraits() {}
	
		// Methods
		public virtual void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {}
	}

	public interface IBaseUxmlFactory // TypeDefIndex: 44825
	{
		// Properties
		string uxmlQualifiedName { get; }
	
		// Methods
		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
	}

	internal interface IBaseUxmlObjectFactory : IBaseUxmlFactory // TypeDefIndex: 44826
	{
	}

	internal interface IUxmlObjectFactory<out T> : IBaseUxmlObjectFactory // TypeDefIndex: 44827
		where T : new()
	{
		// Methods
		T CreateObject(IUxmlAttributes bag, CreationContext cc);
	}

	internal class UxmlObjectFactory<TCreatedType, TTraits> : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlObjectFactory<TCreatedType> // TypeDefIndex: 44828
		where TCreatedType : new()
		where TTraits : UxmlObjectTraits<TCreatedType>, new()
	{
		// Constructors
		public UxmlObjectFactory() {}
	
		// Methods
		public virtual TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc) => default;
	}

	public abstract class BaseUxmlFactory<TCreatedType, TTraits> // TypeDefIndex: 44829
		where TCreatedType : new()
		where TTraits : BaseUxmlTraits, new()
	{
		// Fields
		internal TTraits m_Traits;
	
		// Properties
		public virtual string uxmlQualifiedName { get; }
	
		// Constructors
		protected BaseUxmlFactory() {}
	
		// Methods
		public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) => default;
	}

	[Serializable]
	internal class UxmlAsset : IUxmlAttributes // TypeDefIndex: 44830
	{
		// Fields
		private string m_FullTypeName; // 0x10
		private int m_Id; // 0x18
		private int m_OrderInDocument; // 0x1C
		private int m_ParentId; // 0x20
		protected List<string> m_Properties; // 0x28
	
		// Properties
		public string fullTypeName { get => default; } // 0x000000018346D130-0x000000018346D140 
		public int id { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public int orderInDocument { get => default; } // 0x00000001813AE570-0x00000001813AE580 
		public int parentId { get => default; } // 0x00000001813B88B0-0x00000001813B88C0 
	
		// Constructors
		public UxmlAsset() {} // Dummy constructor
	
		// Methods
		public bool TryGetAttributeValue(string propertyName, out string value) {
			value = default;
			return default;
		} // 0x000000018C0708CC-0x000000018C0709AC
		public void SetAttribute(string name, string value) {} // 0x000000018C070774-0x000000018C07077C
		private void SetOrAddProperty(string propertyName, string propertyValue) {} // 0x000000018C07077C-0x000000018C0708CC
	}

	[Serializable]
	internal sealed class UxmlObjectAsset : UxmlAsset // TypeDefIndex: 44831
	{
		// Constructors
		public UxmlObjectAsset() {} // Dummy constructor
	}

	internal class UxmlObjectFactoryRegistry // TypeDefIndex: 44832
	{
		// Fields
		private static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories; // 0x00
	
		// Properties
		internal static Dictionary<string, List<IBaseUxmlObjectFactory>> factories { get => default; } // 0x000000018C0723BC-0x000000018C07247C 
	
		// Constructors
		public UxmlObjectFactoryRegistry() {} // Dummy constructor
	
		// Methods
		protected static void RegisterFactory(IBaseUxmlObjectFactory factory) {} // 0x000000018C071CCC-0x000000018C0720F0
		internal static bool TryGetFactories(string fullTypeName, out List<IBaseUxmlObjectFactory> factoryList) {
			factoryList = default;
			return default;
		} // 0x000000018C07235C-0x000000018C0723BC
		private static void RegisterEngineFactories() {} // 0x000000018C071AEC-0x000000018C071CCC
		private static void RegisterUserFactories() {} // 0x000000018C0720F0-0x000000018C07235C
	}

	public abstract class UxmlTypeRestriction : IEquatable<UxmlTypeRestriction> // TypeDefIndex: 44833
	{
		// Constructors
		protected UxmlTypeRestriction() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual bool Equals(UxmlTypeRestriction other) => default; // 0x000000018406FBE0-0x000000018406FBF0
	}

	public class UxmlEnumeration : UxmlTypeRestriction // TypeDefIndex: 44834
	{
		// Fields
		private List<string> m_Values; // 0x10
	
		// Properties
		public IEnumerable<string> values { get => default; set {} } // 0x0000000185FC7990-0x0000000185FC79A0 0x000000018C0712C4-0x000000018C071318
	
		// Constructors
		public UxmlEnumeration() {} // 0x000000018C07124C-0x000000018C0712C4
	
		// Methods
		public override bool Equals(UxmlTypeRestriction other) => default; // 0x000000018C071138-0x000000018C07124C
	}

	[Serializable]
	internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver // TypeDefIndex: 44835
	{
		// Fields
		private string m_Name; // 0x30
		private int m_RuleIndex; // 0x38
		private string m_Text; // 0x40
		private PickingMode m_PickingMode; // 0x48
		private string[] m_Classes; // 0x50
		private List<string> m_StylesheetPaths; // 0x58
		private List<StyleSheet> m_Stylesheets; // 0x60
		private bool m_SkipClone; // 0x68
	
		// Properties
		public int ruleIndex { get => default; } // 0x0000000185FE7B50-0x0000000185FE7B60 
		public string[] classes { get => default; } // 0x0000000185FE8C70-0x0000000185FE8C80 
		public List<string> stylesheetPaths { get => default; } // 0x000000018C073CF4-0x000000018C073D78 
		public bool hasStylesheetPaths { get => default; } // 0x0000000187E45764-0x0000000187E45770 
		public List<StyleSheet> stylesheets { get => default; } // 0x000000018C073D78-0x000000018C073DFC 
		public bool hasStylesheets { get => default; } // 0x0000000187CD183C-0x0000000187CD1848 
		internal bool skipClone { get => default; } // 0x0000000185FB09E0-0x0000000185FB09F0 
	
		// Constructors
		public VisualElementAsset() {} // Dummy constructor
	
		// Methods
		public void OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		public void OnAfterDeserialize() {} // 0x000000018C073B74-0x000000018C073CF4
	}

	internal class VisualElementFactoryRegistry // TypeDefIndex: 44836
	{
		// Fields
		private static Dictionary<string, List<IUxmlFactory>> s_Factories; // 0x00
	
		// Properties
		internal static Dictionary<string, List<IUxmlFactory>> factories { get => default; } // 0x000000018C074F6C-0x000000018C07502C 
	
		// Constructors
		public VisualElementFactoryRegistry() {} // Dummy constructor
	
		// Methods
		protected static void RegisterFactory(IUxmlFactory factory) {} // 0x000000018C074870-0x000000018C074C94
		internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList) {
			factoryList = default;
			return default;
		} // 0x000000018C074F00-0x000000018C074F6C
		private static void RegisterEngineFactories() {} // 0x000000018C073DFC-0x000000018C074870
		internal static void RegisterUserFactories() {} // 0x000000018C074C94-0x000000018C074F00
	}

	[Serializable]
	public class VisualTreeAsset : ScriptableObject // TypeDefIndex: 44847
	{
		// Fields
		internal static string LinkedVEAInTemplatePropertyName; // 0x00
		private bool m_ImportedWithErrors; // 0x18
		private bool m_ImportedWithWarnings; // 0x19
		private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints; // 0x08
		private List<UsingEntry> m_Usings; // 0x20
		internal StyleSheet inlineSheet; // 0x28
		private List<VisualElementAsset> m_VisualElementAssets; // 0x30
		private List<TemplateAsset> m_TemplateAssets; // 0x38
		private List<UxmlObjectEntry> m_UxmlObjectEntries; // 0x40
		private List<int> m_UxmlObjectIds; // 0x48
		private List<AssetEntry> m_AssetEntries; // 0x50
		private List<SlotDefinition> m_Slots; // 0x58
		private int m_ContentContainerId; // 0x60
		private int m_ContentHash; // 0x64
	
		// Properties
		public bool importedWithErrors { get => default; internal set {} } // 0x000000018C076400-0x000000018C0765B0 0x000000018C075CF0-0x000000018C0763F4
		public bool importedWithWarnings { get => default; internal set {} } // 0x000000018C0753BC-0x000000018C075CC8 0x000000018C0765BC-0x000000018C0765EC
		public IEnumerable<VisualTreeAsset> templateDependencies { get => default; } // 0x000000018C077620-0x000000018C077890 
		public IEnumerable<StyleSheet> stylesheets { get => default; } // 0x000000018C0765EC-0x000000018C076D24 
		internal List<VisualElementAsset> visualElementAssets { get => default; set {} } // 0x000000018C0751B0-0x000000018C07521C 0x000000018C07521C-0x000000018C0753BC
		internal List<TemplateAsset> templateAssets { get => default; set {} } // 0x0000000185FEA910-0x0000000185FEA920 0x0000000185FB2030-0x0000000185FB2040
		internal List<UxmlObjectEntry> uxmlObjectEntries { get => default; } // 0x0000000184BBD7B0-0x0000000184BBD7C0 
		internal List<int> uxmlObjectIds { get => default; } // 0x000000018C077A6C-0x000000018C077B34 
		internal List<SlotDefinition> slots { get => default; set {} } // 0x000000018C05D264-0x000000018C05D2D4 0x0000000189D638DC-0x0000000189D63910
		internal int contentContainerId { get => default; set {} } // 0x000000018C0705F8-0x000000018C070670 0x000000018C06FDB8-0x000000018C070508
		public int contentHash { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x000000018C06FAC0-0x000000018C06FB5C
	
		// Nested types
		[Serializable]
		internal struct UsingEntry // TypeDefIndex: 44837
		{
			// Fields
			internal static readonly IComparer<UsingEntry> comparer; // 0x00
			public string alias; // 0x00
			public string path; // 0x08
			public VisualTreeAsset asset; // 0x10
	
			// Constructors
			public UsingEntry(string alias, string path) {
				this.alias = default;
				this.path = default;
				asset = default;
			} // 0x0000000185FEA810-0x0000000185FEA820
			static UsingEntry() {
				comparer = default;
			} // 0x00000001813C0520-0x00000001813C0530
		}
	
		private class UsingEntryComparer : IComparer<UsingEntry> // TypeDefIndex: 44838
		{
			// Constructors
			public UsingEntryComparer() {} // 0x0000000181A73EB0-0x0000000181A73EC0
	
			// Methods
			public int Compare(UsingEntry x, UsingEntry y) => default; // 0x0000000185FEA820-0x0000000185FEA830
		}
	
		[Serializable]
		internal struct SlotDefinition // TypeDefIndex: 44839
		{
			// Fields
			public string name; // 0x00
			public int insertionPointId; // 0x08
		}
	
		[Serializable]
		internal struct SlotUsageEntry // TypeDefIndex: 44840
		{
			// Fields
			public string slotName; // 0x00
			public int assetId; // 0x08
		}
	
		[Serializable]
		internal struct UxmlObjectEntry // TypeDefIndex: 44841
		{
			// Fields
			public int parentId; // 0x00
			public List<UxmlObjectAsset> uxmlObjectAssets; // 0x08
	
			// Constructors
			public UxmlObjectEntry(int parentId, List<UxmlObjectAsset> uxmlObjectAssets) {
				this.parentId = default;
				this.uxmlObjectAssets = default;
			} // 0x000000018C076D24-0x000000018C076DA4
		}
	
		[Serializable]
		private struct AssetEntry // TypeDefIndex: 44842
		{
			// Fields
			public string path; // 0x00
			public string typeFullName; // 0x08
			public UnityEngine.Object asset; // 0x10
			private System.Type m_CachedType; // 0x18
	
			// Properties
			public System.Type type { get => default; } // 0x000000018C077BA4-0x000000018C077C14 
	
			// Constructors
			public AssetEntry(string path, System.Type type, UnityEngine.Object asset) : this() {
				this.path = default;
				typeFullName = default;
				this.asset = default;
				m_CachedType = default;
			} // 0x000000018C077B34-0x000000018C077BA4
		}
	
		private sealed class _get_templateDependencies_d__19 : IEnumerable<VisualTreeAsset>, IEnumerator<VisualTreeAsset> // TypeDefIndex: 44843
		{
			// Fields
			private int __1__state; // 0x10
			private VisualTreeAsset __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public VisualTreeAsset __4__this; // 0x28
			private HashSet<VisualTreeAsset> _sent_5__1; // 0x30
			private List<UsingEntry> __s__2; // 0x38
			private UsingEntry _entry_5__3; // 0x60
			private VisualTreeAsset _vta_5__4; // 0x78
	
			// Properties
			VisualTreeAsset IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current { get => default; } // 0x00000001813FF010-0x00000001813FF020 
			object IEnumerator.Current { get => default; } // 0x000000018C077424-0x000000018C077620 
	
			// Constructors
			public _get_templateDependencies_d__19() {} // Dummy constructor
			public _get_templateDependencies_d__19(int __1__state) {} // 0x0000000185FE7B40-0x0000000185FE7B50
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001864721F0-0x0000000186472200
			private bool MoveNext() => default; // 0x0000000185FE7CE0-0x0000000185FE7CF0
			private void __m__Finally1() {} // 0x0000000185A16440-0x0000000185A16450
			void IEnumerator.Reset() {} // 0x00000001813ECF20-0x00000001813ECF30
			IEnumerator<VisualTreeAsset> IEnumerable<VisualTreeAsset>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C07502C-0x000000018C0751B0
		}
	
		private sealed class _get_stylesheets_d__23 : IEnumerable<StyleSheet>, IEnumerator<StyleSheet> // TypeDefIndex: 44844
		{
			// Fields
			private int __1__state; // 0x10
			private StyleSheet __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public VisualTreeAsset __4__this; // 0x28
			private HashSet<StyleSheet> _sent_5__1; // 0x30
			private List<VisualElementAsset> __s__2; // 0x38
			private VisualElementAsset _vea_5__3; // 0x50
			private List<StyleSheet> __s__4; // 0x58
			private StyleSheet _stylesheet_5__5; // 0x70
			private List<string> __s__6; // 0x78
			private string _stylesheetPath_5__7; // 0x90
			private StyleSheet _stylesheet_5__8; // 0x98
	
			// Properties
			StyleSheet IEnumerator<UnityEngine.UIElements.StyleSheet>.Current { get => default; } // 0x0000000185FE9930-0x0000000185FE9940 
			object IEnumerator.Current { get => default; } // 0x000000018C0771F8-0x000000018C077314 
	
			// Constructors
			public _get_stylesheets_d__23() {} // Dummy constructor
			public _get_stylesheets_d__23(int __1__state) {} // 0x000000018C077314-0x000000018C077424
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default; // 0x000000018C076DA4-0x000000018C076ED8
			private void __m__Finally1() {} // 0x000000018C076ED8-0x000000018C0771BC
			private void __m__Finally2() {} // 0x0000000185FE8BB0-0x0000000185FE8BC0
			private void __m__Finally3() {} // 0x0000000186472DB0-0x0000000186472DC0
			void IEnumerator.Reset() {} // 0x000000018143E3C0-0x000000018143E3D0
			IEnumerator<StyleSheet> IEnumerable<StyleSheet>.GetEnumerator() => default; // 0x000000018C0771BC-0x000000018C0771F8
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0765B0-0x000000018C0765BC
		}
	
		private sealed class __c__DisplayClass61_0 // TypeDefIndex: 44845
		{
			// Fields
			public VisualElementAsset childVea; // 0x10
	
			// Constructors
			public __c__DisplayClass61_0() {} // 0x000000018C0763F4-0x000000018C076400
	
			// Methods
			internal bool _CloneSetupRecursively_b__0(SlotUsageEntry u) => default; // 0x000000018C075CC8-0x000000018C075CF0
		}
	
		private struct __c__DisplayClass65_0 // TypeDefIndex: 44846
		{
			// Fields
			public VisualElementAsset asset; // 0x00
		}
	
		// Constructors
		public VisualTreeAsset() {} // 0x000000018C06FB5C-0x000000018C06FB64
		static VisualTreeAsset() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal int GetNextChildSerialNumber() => default; // 0x000000018C077890-0x000000018C077950
		internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) {} // 0x000000018C077950-0x000000018C077A6C
		internal List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc)
			where T : new() => default; // 0x000000018C070740-0x000000018C070774
		internal bool AssetEntryExists(string path, System.Type type) => default; // 0x000000018C0706D0-0x000000018C070740
		internal void RegisterAssetEntry(string path, System.Type type, UnityEngine.Object asset) {} // 0x000000018C0706AC-0x000000018C0706D0
		internal T GetAsset<T>(string path)
			where T : UnityEngine.Object => default; // 0x0000000185492010-0x0000000185492020
		internal UxmlObjectEntry GetUxmlObjectEntry(int id) => default; // 0x0000000189317CA8-0x0000000189317CB8
		private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) => default; // 0x000000018C05D2D4-0x000000018C05D35C
		public TemplateContainer Instantiate() => default; // 0x000000018C070670-0x000000018C0706AC
		public TemplateContainer Instantiate(string bindingPath) => default; // 0x0000000181377E40-0x0000000181377E50
		public TemplateContainer CloneTree() => default; // 0x000000018C0705AC-0x000000018C0705F8
		public TemplateContainer CloneTree(string bindingPath) => default; // 0x0000000181377E40-0x0000000181377E50
		public void CloneTree(VisualElement target) {} // 0x000000018C070508-0x000000018C0705A4
		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount) {
			firstElementIndex = default;
			elementAddedCount = default;
		} // 0x000000018C0705A4-0x000000018C0705AC
		internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides) {} // 0x0000000189D638DC-0x0000000189D63910
		private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context) => default; // 0x000000018C06FBB0-0x000000018C06FD04
		private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b) => default; // 0x000000018C06EFF4-0x000000018C06FAC0
		internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName) {
			slotName = default;
			return default;
		} // 0x000000018C06FD04-0x000000018C06FD40
		internal VisualTreeAsset ResolveTemplate(string templateName) => default; // 0x000000018C06FD40-0x000000018C06FD7C
		internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) => default; // 0x000000018C06FD7C-0x000000018C06FDB8
		private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) {} // 0x0000000181377E40-0x0000000181377E50
		private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) {} // 0x000000018C06FB64-0x000000018C06FBB0
		internal static VisualElement _Create_g__CreateError_65_0(ref __c__DisplayClass65_0 param_0005f3d7) => default; // 0x000000018C06ED14-0x000000018C06ED38
	}

	public struct CreationContext : IEquatable<CreationContext> // TypeDefIndex: 44848
	{
		// Fields
		public static readonly CreationContext Default; // 0x00
		private VisualElement _target_k__BackingField; // 0x00
		private VisualTreeAsset _visualTreeAsset_k__BackingField; // 0x08
		private Dictionary<string, VisualElement> _slotInsertionPoints_k__BackingField; // 0x10
		private List<TemplateAsset.AttributeOverride> _attributeOverrides_k__BackingField; // 0x18
	
		// Properties
		public VisualElement target { get; private set; } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public VisualTreeAsset visualTreeAsset { get; private set; } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public Dictionary<string, VisualElement> slotInsertionPoints { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		internal List<TemplateAsset.AttributeOverride> attributeOverrides { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) : this() {
			<target>k__BackingField = default;
			<visualTreeAsset>k__BackingField = default;
			<slotInsertionPoints>k__BackingField = default;
			<attributeOverrides>k__BackingField = default;
		} // 0x000000018C05D764-0x000000018C05D7E0
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target) : this() {
			<target>k__BackingField = default;
			<visualTreeAsset>k__BackingField = default;
			<slotInsertionPoints>k__BackingField = default;
			<attributeOverrides>k__BackingField = default;
		} // 0x000000018C05D6D0-0x000000018C05D764
		static CreationContext() {
			Default = default;
		} // 0x000000018C05D690-0x000000018C05D6D0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018C05D4D0-0x000000018C05D55C
		public bool Equals(CreationContext other) => default; // 0x000000018C05D35C-0x000000018C05D4D0
		public override int GetHashCode() => default; // 0x000000018C05D55C-0x000000018C05D690
	}
}

namespace UnityEngine.UIElements.Experimental
{
	public static class Easing // TypeDefIndex: 44984
	{
		// Methods
		public static float Linear(float t) => default; // 0x0000000185FACE20-0x0000000185FACE30
		public static float InSine(float t) => default; // 0x0000000185FE9B90-0x0000000185FE9BC0
		public static float OutSine(float t) => default; // 0x0000000185FE9C10-0x0000000185FE9C20
		public static float InOutSine(float t) => default; // 0x0000000185FE9B40-0x0000000185FE9B70
		public static float InQuad(float t) => default; // 0x0000000185FE9B80-0x0000000185FE9B90
		public static float OutQuad(float t) => default; // 0x0000000185FE9BF0-0x0000000185FE9C10
		public static float InOutQuad(float t) => default; // 0x000000018BFE2234-0x000000018BFE2278
		public static float InCubic(float t) => default; // 0x0000000185FE9B30-0x0000000185FE9B40
		public static float OutCubic(float t) => default; // 0x000000018BFE22AC-0x000000018BFE22D4
		public static float InOutCubic(float t) => default; // 0x000000018BFE2164-0x000000018BFE2174
		public static float InPower(float t, int power) => default; // 0x0000000185FE9B70-0x0000000185FE9B80
		public static float OutPower(float t, int power) => default; // 0x000000018BFE2364-0x000000018BFE23A8
		public static float InOutPower(float t, int power) => default; // 0x000000018BFE21BC-0x000000018BFE2234
		public static float InBounce(float t) => default; // 0x000000018BFE1F60-0x000000018BFE1F94
		public static float OutBounce(float t) => default; // 0x000000018B4E0770-0x000000018B4E0808
		public static float InOutBounce(float t) => default; // 0x000000018BFE208C-0x000000018BFE20FC
		public static float InElastic(float t) => default; // 0x000000018BFE1F94-0x000000018BFE201C
		public static float OutElastic(float t) => default; // 0x000000018BFE22D4-0x000000018BFE2364
		public static float InOutElastic(float t) => default; // 0x000000018BFE2174-0x000000018BFE21BC
		public static float InBack(float t) => default; // 0x0000000185FD2C30-0x0000000185FD2C50
		public static float OutBack(float t) => default; // 0x000000018BFE2278-0x000000018BFE22AC
		public static float InOutBack(float t) => default; // 0x000000018BFE201C-0x000000018BFE208C
		public static float InCirc(float t) => default; // 0x0000000185FE9AD0-0x0000000185FE9B30
		public static float OutCirc(float t) => default; // 0x0000000185FE9BC0-0x0000000185FE9BF0
		public static float InOutCirc(float t) => default; // 0x000000018BFE20FC-0x000000018BFE2164
	}

	public struct StyleValues // TypeDefIndex: 44985
	{
		// Fields
		internal StyleValueCollection m_StyleValues; // 0x00
	
		// Properties
		public float top { set {} } // 0x000000018BFE3ACC-0x000000018BFE3ADC
		public float left { set {} } // 0x000000018BFE3A1C-0x000000018BFE3A2C
		public float width { set {} } // 0x000000018BFE3B00-0x000000018BFE41A4
		public float height { set {} } // 0x000000018BFE3A0C-0x000000018BFE3A1C
		public float right { set {} } // 0x000000018BFE3ABC-0x000000018BFE3ACC
		public float bottom { set {} } // 0x000000018BFE39C8-0x000000018BFE39D8
		public UnityEngine.Color color { set {} } // 0x000000018BFE39D8-0x000000018BFE39FC
		public UnityEngine.Color backgroundColor { set {} } // 0x000000018BFE3900-0x000000018BFE3924
		public UnityEngine.Color unityBackgroundImageTintColor { set {} } // 0x000000018BFE3ADC-0x000000018BFE3B00
		public UnityEngine.Color borderColor { set {} } // 0x000000018BFE3954-0x000000018BFE3978
		public float marginLeft { set {} } // 0x000000018BFE3A3C-0x000000018BFE3A4C
		public float marginTop { set {} } // 0x000000018BFE3A5C-0x000000018BFE3A6C
		public float marginRight { set {} } // 0x000000018BFE3A4C-0x000000018BFE3A5C
		public float marginBottom { set {} } // 0x000000018BFE3A2C-0x000000018BFE3A3C
		public float paddingLeft { set {} } // 0x000000018BFE3A8C-0x000000018BFE3A9C
		public float paddingTop { get => default; set {} } // 0x000000018BFE38C4-0x000000018BFE3900 0x000000018BFE3AAC-0x000000018BFE3ABC
		public float paddingRight { set {} } // 0x000000018BFE3A9C-0x000000018BFE3AAC
		public float paddingBottom { set {} } // 0x000000018BFE3A7C-0x000000018BFE3A8C
		public float borderLeftWidth { set {} } // 0x000000018BFE3978-0x000000018BFE3988
		public float borderRightWidth { set {} } // 0x000000018BFE3988-0x000000018BFE3998
		public float borderTopWidth { set {} } // 0x000000018BFE39B8-0x000000018BFE39C8
		public float borderBottomWidth { set {} } // 0x000000018BFE3944-0x000000018BFE3954
		public float borderTopLeftRadius { set {} } // 0x000000018BFE3998-0x000000018BFE39A8
		public float borderTopRightRadius { set {} } // 0x000000018BFE39A8-0x000000018BFE39B8
		public float borderBottomLeftRadius { set {} } // 0x000000018BFE3924-0x000000018BFE3934
		public float borderBottomRightRadius { set {} } // 0x000000018BFE3934-0x000000018BFE3944
		public float opacity { set {} } // 0x000000018BFE3A6C-0x000000018BFE3A7C
		public float flexGrow { set {} } // 0x000000018BFE39FC-0x000000018BFE3A0C
		public float flexShrink { set {} } // 0x000000018BFE39FC-0x000000018BFE3A0C
	
		// Methods
		internal void SetValue(StylePropertyId id, float value) {} // 0x000000018BFE379C-0x000000018BFE37F8
		internal void SetValue(StylePropertyId id, UnityEngine.Color value) {} // 0x000000018BFE37F8-0x000000018BFE3858
		internal StyleValueCollection Values() => default; // 0x000000018BFE3858-0x000000018BFE38C4
	}

	public interface ITransitionAnimations // TypeDefIndex: 44986
	{
		// Methods
		ValueAnimation<StyleValues> Start(StyleValues to, int durationMs);
	}

	internal static class Lerp // TypeDefIndex: 44987
	{
		// Methods
		public static float Interpolate(float start, float end, float ratio) => default; // 0x0000000185FE6FF0-0x0000000185FE7010
		public static UnityEngine.Color Interpolate(UnityEngine.Color start, UnityEngine.Color end, float ratio) => default; // 0x000000018BFE23A8-0x000000018BFE23EC
		internal static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio) => default; // 0x000000018BFE23EC-0x000000018BFE2A28
	}

	internal interface IValueAnimationUpdate // TypeDefIndex: 44988
	{
		// Methods
		void Tick(long currentTimeMs);
	}

	public sealed class ValueAnimation<T> : IValueAnimationUpdate // TypeDefIndex: 44989
	{
		// Fields
		private long m_StartTimeMs;
		private int m_DurationMs;
		private Func<float, float> _easingCurve_k__BackingField;
		private bool _isRunning_k__BackingField;
		private Action _onAnimationCompleted_k__BackingField;
		private bool _autoRecycle_k__BackingField;
		private bool _recycled_k__BackingField;
		private static ObjectPool<ValueAnimation<T>> sObjectPool;
		private VisualElement _owner_k__BackingField;
		private Action<VisualElement, T> _valueUpdated_k__BackingField;
		private Func<VisualElement, T> _initialValue_k__BackingField;
		private Func<T, T, float, T> _interpolator_k__BackingField;
		private T _from;
		private bool fromValueSet;
		private T _to_k__BackingField;
	
		// Properties
		public int durationMs { get => default; set {} }
		public Func<float, float> easingCurve { get; set; }
		public bool isRunning { get; private set; }
		public Action onAnimationCompleted { get; set; }
		public bool autoRecycle { get; set; }
		private bool recycled { get; set; }
		private VisualElement owner { get; set; }
		public Action<VisualElement, T> valueUpdated { get; set; }
		public Func<VisualElement, T> initialValue { get; set; }
		public Func<T, T, float, T> interpolator { get; set; }
		public T from { get => default; set {} }
		public T to { get; set; }
	
		// Constructors
		public ValueAnimation() {}
		static ValueAnimation() {}
	
		// Methods
		public void Start() {}
		public void Stop() {}
		public void Recycle() {}
		void IValueAnimationUpdate.Tick(long currentTimeMs) {}
		private void SetDefaultValues() {}
		private void Unregister() {}
		private void Register() {}
		internal void SetOwner(VisualElement e) {}
		private void CheckNotRecycled() {}
		public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator) => default;
		public ValueAnimation<T> KeepAlive() => default;
	}
}

namespace UnityEngine.UIElements.Internal
{
	internal class MultiColumnHeaderColumnMovePreview : VisualElement // TypeDefIndex: 44929
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Constructors
		public MultiColumnHeaderColumnMovePreview() {} // 0x000000018BFC7A48-0x000000018BFC7AC8
		static MultiColumnHeaderColumnMovePreview() {} // 0x000000018BFC79BC-0x000000018BFC7A48
	}

	internal class MultiColumnHeaderColumnMoveLocationPreview : VisualElement // TypeDefIndex: 44930
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string visualUssClassName; // 0x08
	
		// Constructors
		public MultiColumnHeaderColumnMoveLocationPreview() {} // 0x000000018BFC78DC-0x000000018BFC79BC
		static MultiColumnHeaderColumnMoveLocationPreview() {} // 0x000000018BFC77F8-0x000000018BFC78DC
	}

	internal class ColumnMover : PointerManipulator // TypeDefIndex: 44931
	{
		// Fields
		private float m_StartPos; // 0x38
		private float m_LastPos; // 0x3C
		private bool m_Active; // 0x40
		private bool m_Moving; // 0x41
		private bool m_Cancelled; // 0x42
		private MultiColumnCollectionHeader m_Header; // 0x48
		private VisualElement m_PreviewElement; // 0x50
		private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; // 0x58
		private Column m_ColumnToMove; // 0x60
		private float m_ColumnToMovePos; // 0x68
		private float m_ColumnToMoveWidth; // 0x6C
		private Column m_DestinationColumn; // 0x70
		private bool m_MoveBeforeDestination; // 0x78
		private ColumnLayout _columnLayout_k__BackingField; // 0x80
		private Action<ColumnMover> activeChanged; // 0x88
		private Action<ColumnMover> movingChanged; // 0x90
	
		// Properties
		public ColumnLayout columnLayout { get; set; } // 0x000000018140CF50-0x000000018140CF60 0x00000001873CBE98-0x00000001873CBEA8
		public bool active { get => default; set {} } // 0x0000000185FB0650-0x0000000185FB0660 0x000000018BFC2094-0x000000018BFC20C0
		public bool moving { get => default; set {} } // 0x0000000185FB0D70-0x0000000185FB0D80 0x000000018BFC20C0-0x000000018BFC20EC
	
		// Events
		public event Action<ColumnMover> activeChanged;
		public event Action<ColumnMover> movingChanged;
	
		// Constructors
		public ColumnMover() {} // 0x000000018BFC1DE0-0x000000018BFC1E54
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x000000018BFC1104-0x000000018BFC15B4
		protected override void UnregisterCallbacksFromTarget() {} // 0x000000018BFC15B4-0x000000018BFC1A64
		protected void OnMouseDown(MouseDownEvent evt) {} // 0x000000018BFC0734-0x000000018BFC07F0
		protected void OnMouseMove(MouseMoveEvent evt) {} // 0x000000018BFC07F0-0x000000018BFC0860
		protected void OnMouseUp(MouseUpEvent evt) {} // 0x000000018BFC0860-0x000000018BFC0924
		private void OnMouseCaptureOut(MouseCaptureOutEvent evt) {} // 0x000000018BFC06C8-0x000000018BFC0734
		private void OnPointerDown(PointerDownEvent evt) {} // 0x000000018BFC0A14-0x000000018BFC0B1C
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x000000018BFC0B1C-0x000000018BFC0C08
		private void OnPointerUp(PointerUpEvent evt) {} // 0x000000018BFC0C08-0x000000018BFC0D10
		private void OnPointerCancel(PointerCancelEvent evt) {} // 0x000000018BFC0924-0x000000018BFC09A4
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt) {} // 0x000000018BFC09A4-0x000000018BFC0A14
		private static bool IsNotMouseEvent(int pointerId) => default; // 0x000000018BFC061C-0x000000018BFC0668
		protected void ProcessCancelEvent(EventBase evt, int pointerId) {} // 0x000000018BFC0D10-0x000000018BFC0DC0
		private void OnKeyDown(KeyDownEvent e) {} // 0x000000018BFC0668-0x000000018BFC06C8
		private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) {} // 0x000000018BFC0DC0-0x000000018BFC0F58
		private void ProcessMoveEvent(EventBase e, Vector2 localPosition) {} // 0x000000018BFC0F58-0x000000018BFC1034
		private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) {} // 0x000000018BFC1034-0x000000018BFC1104
		private void BeginDragMove(float pos) {} // 0x000000018BFC00E8-0x000000018BFC04E0
		internal void DragMove(float pos) {} // 0x000000018BFC04E0-0x000000018BFC04EC
		private void UpdatePreviewPosition() {} // 0x000000018BFC1C74-0x000000018BFC1DE0
		private void UpdateMoveLocation() {} // 0x000000018BFC1A64-0x000000018BFC1C74
		private void EndDragMove(bool cancelled) {} // 0x000000018BFC04EC-0x000000018BFC061C
	}

	internal class MultiColumnHeaderColumnResizePreview : VisualElement // TypeDefIndex: 44932
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string visualUssClassName; // 0x08
	
		// Constructors
		public MultiColumnHeaderColumnResizePreview() {} // 0x000000018BFC7D80-0x000000018BFC7E60
		static MultiColumnHeaderColumnResizePreview() {} // 0x000000018BFC7C9C-0x000000018BFC7D80
	}

	internal class ColumnResizer : PointerManipulator // TypeDefIndex: 44933
	{
		// Fields
		private Vector2 m_Start; // 0x38
		protected bool m_Active; // 0x40
		private bool m_Resizing; // 0x41
		private MultiColumnCollectionHeader m_Header; // 0x48
		private Column m_Column; // 0x50
		private VisualElement m_PreviewElement; // 0x58
		private ColumnLayout _columnLayout_k__BackingField; // 0x60
		private bool _preview_k__BackingField; // 0x68
	
		// Properties
		public ColumnLayout columnLayout { get; set; } // 0x0000000185FB0530-0x0000000185FB0540 0x0000000185AE8FE0-0x0000000185AE8FF0
		public bool preview { get; set; } // 0x0000000185FB09E0-0x0000000185FB09F0 0x0000000185FB0A20-0x0000000185FB0A30
	
		// Constructors
		public ColumnResizer() {} // Dummy constructor
		public ColumnResizer(Column column) {} // 0x000000018BFC2B38-0x000000018BFC2BCC
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x000000018BFC26A0-0x000000018BFC289C
		protected override void UnregisterCallbacksFromTarget() {} // 0x000000018BFC289C-0x000000018BFC2A98
		private void OnKeyDown(KeyDownEvent e) {} // 0x000000018BFC21D4-0x000000018BFC223C
		private void OnPointerDown(PointerDownEvent e) {} // 0x000000018BFC223C-0x000000018BFC2494
		private void OnPointerMove(PointerMoveEvent e) {} // 0x000000018BFC2494-0x000000018BFC2580
		private void OnPointerUp(PointerUpEvent e) {} // 0x000000018BFC2580-0x000000018BFC26A0
		private void BeginDragResize(float pos) {} // 0x000000018BFC20EC-0x000000018BFC2130
		private void DragResize(float pos) {} // 0x000000018BFC2130-0x000000018BFC2170
		private void UpdatePreviewPosition() {} // 0x000000018BFC2A98-0x000000018BFC2B38
		private void EndDragResize(float pos, bool cancelled) {} // 0x000000018BFC2170-0x000000018BFC21D4
	}

	internal class MultiColumnCollectionHeader : VisualElement, IDisposable // TypeDefIndex: 44940
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string columnContainerUssClassName; // 0x08
		public static readonly string handleContainerUssClassName; // 0x10
		public static readonly string reorderableUssClassName; // 0x18
		private bool m_SortingEnabled; // 0x3C0
		private List<SortColumnDescription> m_SortedColumns; // 0x3C8
		private SortColumnDescriptions m_SortDescriptions; // 0x3D0
		private List<SortedColumnState> m_OldSortedColumnStates; // 0x3D8
		private bool m_SortingUpdatesTemporarilyDisabled; // 0x3E0
		private ViewState m_ViewState; // 0x3E8
		private bool m_ApplyingViewState; // 0x3F0
		private bool m_DoLayoutScheduled; // 0x3F1
		private readonly Dictionary<Column, ColumnData> _columnDataMap_k__BackingField; // 0x3F8
		private readonly ColumnLayout _columnLayout_k__BackingField; // 0x400
		private readonly VisualElement _columnContainer_k__BackingField; // 0x408
		private readonly VisualElement _resizeHandleContainer_k__BackingField; // 0x410
		private readonly Columns _columns_k__BackingField; // 0x418
		private Action<int, float> columnResized; // 0x420
		private Action columnSortingChanged; // 0x428
		private Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent; // 0x430
		private Action viewDataRestored; // 0x438
	
		// Properties
		internal bool isApplyingViewState { get => default; } // 0x000000018BFC72B4-0x000000018BFC734C 
		public Dictionary<Column, ColumnData> columnDataMap { get; } // 0x000000018BFC70FC-0x000000018BFC718C 
		public ColumnLayout columnLayout { get; } // 0x000000018BFC734C-0x000000018BFC73DC 
		public VisualElement columnContainer { get; } // 0x000000018BFC718C-0x000000018BFC7224 
		public VisualElement resizeHandleContainer { get; } // 0x000000018BFC73DC-0x000000018BFC7474 
		public IEnumerable<SortColumnDescription> sortedColumns { get => default; } // 0x000000018BFC626C-0x000000018BFC6FD4 
		public SortColumnDescriptions sortDescriptions { get => default; protected internal set {} } // 0x000000018BFC4FA8-0x000000018BFC5034 0x000000018BFC4F2C-0x000000018BFC4F6C
		public Columns columns { get; } // 0x000000018BFC57B4-0x000000018BFC5D7C 
		public bool sortingEnabled { get => default; set {} } // 0x000000018BFC50B4-0x000000018BFC5590 0x000000018BFC3888-0x000000018BFC3890
	
		// Events
		public event Action<int, float> columnResized;
		public event Action columnSortingChanged;
		public event Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent;
		internal event Action viewDataRestored;
	
		// Nested types
		[Serializable]
		private class ViewState // TypeDefIndex: 44935
		{
			// Fields
			private bool m_HasPersistedData; // 0x10
			private List<SortColumnDescription> m_SortDescriptions; // 0x18
			private List<ColumnState> m_OrderedColumnStates; // 0x20
	
			// Nested types
			[Serializable]
			private struct ColumnState // TypeDefIndex: 44934
			{
				// Fields
				public int index; // 0x00
				public string name; // 0x08
				public float actualWidth; // 0x10
				public Length width; // 0x14
				public bool visible; // 0x1C
			}
	
			// Constructors
			public ViewState() {} // 0x0000000185FB86A0-0x0000000185FB86B0
	
			// Methods
			internal void Save(MultiColumnCollectionHeader header) {} // 0x0000000185FE9A00-0x0000000185FE9A10
			internal void Apply(MultiColumnCollectionHeader header) {} // 0x0000000185FB84B0-0x0000000185FB84C0
		}
	
		internal class ColumnData // TypeDefIndex: 44936
		{
			// Fields
			private MultiColumnHeaderColumn _control_k__BackingField; // 0x10
			private MultiColumnHeaderColumnResizeHandle _resizeHandle_k__BackingField; // 0x18
	
			// Properties
			public MultiColumnHeaderColumn control { get; set; } // 0x0000000185FB8690-0x0000000185FB86A0 0x0000000185FB8500-0x0000000185FB8510
			public MultiColumnHeaderColumnResizeHandle resizeHandle { get; set; } // 0x0000000185FB8410-0x0000000185FB8420 0x0000000185FB7090-0x0000000185FB70A0
	
			// Constructors
			public ColumnData() {} // 0x000000018BFC7474-0x000000018BFC7528
		}
	
		private struct SortedColumnState // TypeDefIndex: 44937
		{
			// Fields
			public SortColumnDescription columnDesc; // 0x00
			public SortDirection direction; // 0x08
	
			// Constructors
			public SortedColumnState(SortColumnDescription desc, SortDirection dir) {
				columnDesc = default;
				direction = default;
			} // 0x0000000185FB85B0-0x0000000185FB85C0
		}
	
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 44938
		{
			// Fields
			public Column column; // 0x10
			public MultiColumnCollectionHeader __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass65_0() {} // 0x0000000185FE9A10-0x0000000185FE9A20
	
			// Methods
			internal void _OnContextualMenuManipulator_b__1(DropdownMenuAction a) {} // 0x000000018BFC7528-0x000000018BFC755C
			internal DropdownMenuAction.Status _OnContextualMenuManipulator_b__2(DropdownMenuAction a) => default; // 0x000000018BFC6FD4-0x000000018BFC7064
		}
	
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 44939
		{
			// Fields
			public Column column; // 0x10
	
			// Constructors
			public __c__DisplayClass71_0() {} // 0x000000018BFC7224-0x000000018BFC72B4
	
			// Methods
			internal bool _UpdateSortColumnDescriptionsOnClick_b__0(SortColumnDescription d) => default; // 0x000000018BFC7064-0x000000018BFC70FC
		}
	
		// Constructors
		public MultiColumnCollectionHeader() {} // Dummy constructor
		public MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {} // 0x000000018BFC3834-0x000000018BFC3888
		static MultiColumnCollectionHeader() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private void ScheduleDoLayout() {} // 0x000000018BFC3DD8-0x000000018BFC3F90
		private void ResizeToFit() {} // 0x000000018BFC3C38-0x000000018BFC3DD8
		private void UpdateSortedColumns() {} // 0x000000018BFC5590-0x000000018BFC57B4
		private void UpdateColumnControls() {} // 0x000000018BFC5034-0x000000018BFC50AC
		private void OnColumnAdded(Column column, int index) {} // 0x000000018BFC4EA0-0x000000018BFC4EFC
		private void OnColumnAdded(Column column) {} // 0x000000018BFC4EFC-0x000000018BFC4F2C
		private void OnColumnRemoved(Column column) {} // 0x000000018BFC2C94-0x000000018BFC31DC
		private void OnColumnChanged(Column column, ColumnDataType type) {} // 0x000000018BFC5D7C-0x000000018BFC6110
		private void OnColumnReordered(Column column, int from, int to) {} // 0x000000018BFC4D48-0x000000018BFC4EA0
		private void OnColumnResized(Column column) {} // 0x000000018BFC4F6C-0x000000018BFC4FA8
		private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) {} // 0x000000018BFC31DC-0x000000018BFC3834
		private void OnMoveManipulatorActivated(ColumnMover mover) {} // 0x000000018BFC6110-0x000000018BFC626C
		private void OnGeometryChanged(GeometryChangedEvent e) {} // 0x000000018BFC50AC-0x000000018BFC50B4
		private void DoLayout() {} // 0x000000018BFD2DD4-0x000000018BFD3200
		private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) {} // 0x000000018BFD2A18-0x000000018BFD2DD4
		private void OnColumnClicked(EventBase evt) {} // 0x000000018BFD3200-0x000000018BFD32C0
		private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) {} // 0x000000018346D130-0x000000018346D140
		public void ScrollHorizontally(float horizontalOffset) {} // 0x0000000184096E30-0x0000000184096EF0
		private void RaiseColumnResized(int columnIndex) {} // 0x0000000181377E40-0x0000000181377E50
		private void RaiseColumnSortingChanged() {} // 0x0000000184088E70-0x0000000184088E80
		private void ApplyColumnSorting() {} // 0x0000000185492010-0x0000000185492020
		private void UpdateSortingStatus() {} // 0x0000000186472594-0x00000001864725B0
		internal override void OnViewDataReady() {} // 0x0000000185492010-0x0000000185492020
		private void SaveViewState() {} // 0x000000018BFCC830-0x000000018BFCC85C
		public void Dispose() {} // 0x000000018BFCC85C-0x000000018BFCC8D8
		private void _OnContextualMenuManipulator_b__65_0(DropdownMenuAction a) {} // 0x000000018BFCC8D8-0x000000018BFCC94C
	}

	internal class MultiColumnHeaderColumnSortIndicator : VisualElement // TypeDefIndex: 44941
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string arrowUssClassName; // 0x08
		public static readonly string indexLabelUssClassName; // 0x10
		private UnityEngine.UIElements.Label m_IndexLabel; // 0x3C0
	
		// Properties
		public string sortOrderLabel { set {} } // 0x000000018BFC80FC-0x000000018BFC8120
	
		// Constructors
		public MultiColumnHeaderColumnSortIndicator() {} // 0x000000018BFC7F98-0x000000018BFC80FC
		static MultiColumnHeaderColumnSortIndicator() {} // 0x000000018BFC7E60-0x000000018BFC7F98
	}

	internal class MultiColumnHeaderColumnIcon : Image // TypeDefIndex: 44942
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private bool _isImageInline_k__BackingField; // 0x408
	
		// Properties
		public bool isImageInline { get; set; } // 0x0000000185FE9A20-0x0000000185FE9A30 0x0000000185FE9A30-0x0000000185FE9A40
	
		// Constructors
		public MultiColumnHeaderColumnIcon() {} // 0x000000018BFC7710-0x000000018BFC77F8
		static MultiColumnHeaderColumnIcon() {} // 0x000000018BFC7684-0x000000018BFC7710
	
		// Methods
		public void UpdateClassList() {} // 0x000000018BFC7564-0x000000018BFC7684
		private void _.ctor_b__5_0(CustomStyleResolvedEvent evt) {} // 0x000000018BFC755C-0x000000018BFC7564
	}

	internal class MultiColumnHeaderColumn : VisualElement // TypeDefIndex: 44943
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string sortableUssClassName; // 0x08
		public static readonly string sortedAscendingUssClassName; // 0x10
		public static readonly string sortedDescendingUssClassName; // 0x18
		public static readonly string movingUssClassName; // 0x20
		public static readonly string contentContainerUssClassName; // 0x28
		public static readonly string contentUssClassName; // 0x30
		public static readonly string defaultContentUssClassName; // 0x38
		public static readonly string hasIconUssClassName; // 0x40
		public static readonly string hasTitleUssClassName; // 0x48
		public static readonly string titleUssClassName; // 0x50
		public static readonly string iconElementName; // 0x58
		public static readonly string titleElementName; // 0x60
		private static readonly string s_BoundVEPropertyName; // 0x68
		private static readonly string s_BindingCallbackVEPropertyName; // 0x70
		private static readonly string s_UnbindingCallbackVEPropertyName; // 0x78
		private static readonly string s_DestroyCallbackVEPropertyName; // 0x80
		private VisualElement m_ContentContainer; // 0x3C0
		private VisualElement m_Content; // 0x3C8
		private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; // 0x3D0
		private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; // 0x3D8
		private Clickable _clickable_k__BackingField; // 0x3E0
		private ColumnMover _mover_k__BackingField; // 0x3E8
		private Column _column_k__BackingField; // 0x3F0
	
		// Properties
		public Clickable clickable { get; private set; } // 0x0000000185FB70B0-0x0000000185FB70C0 0x0000000187A47C08-0x0000000187A47C1C
		public ColumnMover mover { get; private set; } // 0x0000000185FB86F0-0x0000000185FB8700 0x0000000187A47938-0x0000000187A4794C
		public string sortOrderLabel { set {} } // 0x000000018BFC9B18-0x000000018BFC9B3C
		public Column column { get; set; } // 0x0000000185FB8730-0x0000000185FB8740 0x0000000187A47974-0x0000000187A47988
		public VisualElement content { get => default; set {} } // 0x0000000185FB8410-0x0000000185FB8420 0x000000018BFC98D0-0x000000018BFC9A70
		private bool isContentBound { get => default; set {} } // 0x000000018BFC982C-0x000000018BFC98D0 0x000000018BFC9A70-0x000000018BFC9B18
	
		// Constructors
		public MultiColumnHeaderColumn() {} // Dummy constructor
		public MultiColumnHeaderColumn(Column column) {} // 0x000000018BFC9354-0x000000018BFC982C
		static MultiColumnHeaderColumn() {} // 0x000000018BFC8E04-0x000000018BFC9354
	
		// Methods
		private void InitManipulators() {} // 0x000000018BFC8700-0x000000018BFC88E8
		private void UpdateDataFromColumn() {} // 0x000000018BFC8B10-0x000000018BFC8B50
		private void BindHeaderContent() {} // 0x000000018BFC8120-0x000000018BFC81F8
		private void UnbindHeaderContent() {} // 0x000000018BFC8A38-0x000000018BFC8B10
		private void DestroyHeaderContent() {} // 0x000000018BFC863C-0x000000018BFC8700
		private VisualElement CreateDefaultHeaderContent() => default; // 0x000000018BFC81F8-0x000000018BFC837C
		private void DefaultBindHeaderContent(VisualElement ve) {} // 0x000000018BFC837C-0x000000018BFC863C
		private void UpdateHeaderTemplate() {} // 0x000000018BFC8BD4-0x000000018BFC8E04
		private void UpdateGeometryFromColumn() {} // 0x000000018BFC8B50-0x000000018BFC8BD4
		private void _.ctor_b__45_0(Column c, ColumnDataType role) {} // 0x000000018BFC897C-0x000000018BFC8A30
		private void _.ctor_b__45_1(Column c) {} // 0x000000018BFC8A30-0x000000018BFC8A38
		private void _InitManipulators_b__46_0(ColumnMover mv) {} // 0x000000018BFC88E8-0x000000018BFC897C
	}

	internal class MultiColumnHeaderColumnResizeHandle : VisualElement // TypeDefIndex: 44944
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string dragAreaUssClassName; // 0x08
		private readonly VisualElement _dragArea_k__BackingField; // 0x3C0
	
		// Properties
		public VisualElement dragArea { get; } // 0x0000000185FB8430-0x0000000185FB8440 
	
		// Constructors
		public MultiColumnHeaderColumnResizeHandle() {} // 0x000000018BFC7BAC-0x000000018BFC7C9C
		static MultiColumnHeaderColumnResizeHandle() {} // 0x000000018BFC7AC8-0x000000018BFC7BAC
	}
}

namespace UnityEngine.UIElements.StyleSheets
{
	internal abstract class HierarchyTraversal // TypeDefIndex: 44945
	{
		// Constructors
		protected HierarchyTraversal() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void Traverse(VisualElement element) {} // 0x000000018BFC2C7C-0x000000018BFC2C94
		public abstract void TraverseRecursive(VisualElement element, int depth);
		protected void Recurse(VisualElement element, int depth) {} // 0x000000018BFC2BCC-0x000000018BFC2C7C
	}

	internal static class StylePropertyUtil // TypeDefIndex: 44946
	{
		// Fields
		private static readonly HashSet<StylePropertyId> s_AnimatablePropertiesHash; // 0x00
		internal static readonly Dictionary<string, StylePropertyId> s_NameToId; // 0x08
		internal static readonly Dictionary<StylePropertyId, string> s_IdToName; // 0x10
		internal static readonly StylePropertyId[] s_AnimatableProperties; // 0x18
	
		// Constructors
		static StylePropertyUtil() {} // 0x000000018BFCAA48-0x000000018BFCC830
	
		// Methods
		public static bool IsAnimatable(StylePropertyId id) => default; // 0x000000018BFC9B3C-0x000000018BFC9BA8
		public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) {
			intValue = default;
			return default;
		} // 0x000000018BFC9C88-0x000000018BFCAA48
		public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) => default; // 0x000000018BFC9BA8-0x000000018BFC9C88
	}

	internal static class InitialStyle // TypeDefIndex: 44947
	{
		// Fields
		private static ComputedStyle s_InitialStyle; // 0x00
	
		// Properties
		public static Align alignContent { get; } // 0x000000018BFD53E0-0x000000018BFD5440 
		public static Align alignItems { get; } // 0x000000018BFD5440-0x000000018BFD54A0 
		public static Align alignSelf { get; } // 0x000000018BFD54A0-0x000000018BFD5500 
		public static UnityEngine.Color backgroundColor { get; } // 0x000000018BFD5500-0x000000018BFD556C 
		public static Background backgroundImage { get; } // 0x000000018BFD556C-0x000000018BFD55E0 
		public static UnityEngine.Color borderBottomColor { get; } // 0x000000018BFD55E0-0x000000018BFD564C 
		public static Length borderBottomLeftRadius { get; } // 0x000000018BFD564C-0x000000018BFD56AC 
		public static Length borderBottomRightRadius { get; } // 0x000000018BFD56AC-0x000000018BFD570C 
		public static float borderBottomWidth { get; } // 0x000000018BFD570C-0x000000018BFD576C 
		public static UnityEngine.Color borderLeftColor { get; } // 0x000000018BFD576C-0x000000018BFD57D8 
		public static float borderLeftWidth { get; } // 0x000000018BFD57D8-0x000000018BFD5838 
		public static UnityEngine.Color borderRightColor { get; } // 0x000000018BFD5838-0x000000018BFD58A4 
		public static float borderRightWidth { get; } // 0x000000018BFD58A4-0x000000018BFD5904 
		public static UnityEngine.Color borderTopColor { get; } // 0x000000018BFD5904-0x000000018BFD5970 
		public static Length borderTopLeftRadius { get; } // 0x000000018BFD5970-0x000000018BFD59D4 
		public static Length borderTopRightRadius { get; } // 0x000000018BFD59D4-0x000000018BFD5A38 
		public static float borderTopWidth { get; } // 0x000000018BFD5A38-0x000000018BFD5A98 
		public static Length bottom { get; } // 0x000000018BFD5A98-0x000000018BFD5AF8 
		public static UnityEngine.Color color { get; } // 0x000000018BFD5AF8-0x000000018BFD5B60 
		public static UnityEngine.UIElements.Cursor cursor { get; } // 0x000000018BFD5B60-0x000000018BFD5BD4 
		public static DisplayStyle display { get; } // 0x000000018BFD5BD4-0x000000018BFD5C34 
		public static Length flexBasis { get; } // 0x000000018BFD5C34-0x000000018BFD5C94 
		public static FlexDirection flexDirection { get; } // 0x000000018BFD5C94-0x000000018BFD5CF4 
		public static float flexGrow { get; } // 0x000000018BFD5CF4-0x000000018BFD5D54 
		public static float flexShrink { get; } // 0x000000018BFD5D54-0x000000018BFD5DB4 
		public static Wrap flexWrap { get; } // 0x000000018BFD5DB4-0x000000018BFD5E14 
		public static Length fontSize { get; } // 0x000000018BFD5E14-0x000000018BFD5E70 
		public static Length height { get; } // 0x000000018BFD5E70-0x000000018BFD5ED0 
		public static Justify justifyContent { get; } // 0x000000018BFD5ED0-0x000000018BFD5F30 
		public static Length left { get; } // 0x000000018BFD5F30-0x000000018BFD5F90 
		public static Length letterSpacing { get; } // 0x000000018BFD5F90-0x000000018BFD5FEC 
		public static Length marginBottom { get; } // 0x000000018BFD5FEC-0x000000018BFD604C 
		public static Length marginLeft { get; } // 0x000000018BFD604C-0x000000018BFD60AC 
		public static Length marginRight { get; } // 0x000000018BFD60AC-0x000000018BFD610C 
		public static Length marginTop { get; } // 0x000000018BFD610C-0x000000018BFD616C 
		public static Length maxHeight { get; } // 0x000000018BFD616C-0x000000018BFD61CC 
		public static Length maxWidth { get; } // 0x000000018BFD61CC-0x000000018BFD622C 
		public static Length minHeight { get; } // 0x000000018BFD622C-0x000000018BFD6290 
		public static Length minWidth { get; } // 0x000000018BFD6290-0x000000018BFD62F4 
		public static float opacity { get; } // 0x000000018BFD62F4-0x000000018BFD6358 
		public static OverflowInternal overflow { get; } // 0x000000018BFD6358-0x000000018BFD63BC 
		public static Length paddingBottom { get; } // 0x000000018BFD63BC-0x000000018BFD6420 
		public static Length paddingLeft { get; } // 0x000000018BFD6420-0x000000018BFD6484 
		public static Length paddingRight { get; } // 0x000000018BFD6484-0x000000018BFD64E8 
		public static Length paddingTop { get; } // 0x000000018BFD64E8-0x000000018BFD654C 
		public static Position position { get; } // 0x000000018BFD654C-0x000000018BFD65B0 
		public static Length right { get; } // 0x000000018BFD65B0-0x000000018BFD6614 
		public static Rotate rotate { get; } // 0x000000018BFD6614-0x000000018BFD6688 
		public static Scale scale { get; } // 0x000000018BFD6688-0x000000018BFD66F4 
		public static TextOverflow textOverflow { get; } // 0x000000018BFD66F4-0x000000018BFD6754 
		public static TextShadow textShadow { get; } // 0x000000018BFD6754-0x000000018BFD67CC 
		public static Length top { get; } // 0x000000018BFD67CC-0x000000018BFD6830 
		public static TransformOrigin transformOrigin { get; } // 0x000000018BFD6830-0x000000018BFD68A4 
		public static List<TimeValue> transitionDelay { get; } // 0x000000018BFD68A4-0x000000018BFD6904 
		public static List<TimeValue> transitionDuration { get; } // 0x000000018BFD6904-0x000000018BFD6964 
		public static List<StylePropertyName> transitionProperty { get; } // 0x000000018BFD6964-0x000000018BFD69C4 
		public static List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction { get; } // 0x000000018BFD69C4-0x000000018BFD6A24 
		public static Translate translate { get; } // 0x000000018BFD6A24-0x000000018BFD6A9C 
		public static UnityEngine.Color unityBackgroundImageTintColor { get; } // 0x000000018BFD6A9C-0x000000018BFD6B08 
		public static UnityEngine.ScaleMode unityBackgroundScaleMode { get; } // 0x000000018BFD6B08-0x000000018BFD6B68 
		public static Font unityFont { get; } // 0x000000018BFD6C2C-0x000000018BFD6C88 
		public static FontDefinition unityFontDefinition { get; } // 0x000000018BFD6B68-0x000000018BFD6BD0 
		public static FontStyle unityFontStyleAndWeight { get; } // 0x000000018BFD6BD0-0x000000018BFD6C2C 
		public static OverflowClipBox unityOverflowClipBox { get; } // 0x000000018BFD6C88-0x000000018BFD6CE8 
		public static Length unityParagraphSpacing { get; } // 0x000000018BFD6CE8-0x000000018BFD6D44 
		public static int unitySliceBottom { get; } // 0x000000018BFD6D44-0x000000018BFD6DA4 
		public static int unitySliceLeft { get; } // 0x000000018BFD6DA4-0x000000018BFD6E04 
		public static int unitySliceRight { get; } // 0x000000018BFD6E04-0x000000018BFD6E64 
		public static int unitySliceTop { get; } // 0x000000018BFD6E64-0x000000018BFD6EC4 
		public static TextAnchor unityTextAlign { get; } // 0x000000018BFD6EC4-0x000000018BFD6F20 
		public static UnityEngine.Color unityTextOutlineColor { get; } // 0x000000018BFD6F20-0x000000018BFD6F88 
		public static float unityTextOutlineWidth { get; } // 0x000000018BFD6F88-0x000000018BFD6FE4 
		public static TextOverflowPosition unityTextOverflowPosition { get; } // 0x000000018BFD6FE4-0x000000018BFD7044 
		public static Visibility visibility { get; } // 0x000000018BFD7044-0x000000018BFD70A0 
		public static WhiteSpace whiteSpace { get; } // 0x000000018BFD70A0-0x000000018BFD7100 
		public static Length width { get; } // 0x000000018BFD7100-0x000000018BFD7164 
		public static Length wordSpacing { get; } // 0x000000018BFD7164-0x000000018BFD71C4 
	
		// Constructors
		static InitialStyle() {} // 0x000000018BFD444C-0x000000018BFD53E0
	
		// Methods
		public static ref ComputedStyle Get() => ref _refReturnTypeForGet; // 0x000000018BFD4400-0x000000018BFD444C
		private ref ComputedStyle _refReturnTypeForGet; // Dummy field
		public static ComputedStyle Acquire() => default; // 0x000000018BFD4364-0x000000018BFD4400
	}

	internal static class ShorthandApplicator // TypeDefIndex: 44948
	{
		// Fields
		private static List<TimeValue> s_TransitionDelayList; // 0x00
		private static List<TimeValue> s_TransitionDurationList; // 0x08
		private static List<StylePropertyName> s_TransitionPropertyList; // 0x10
		private static List<UnityEngine.UIElements.EasingFunction> s_TransitionTimingFunctionList; // 0x18
	
		// Constructors
		static ShorthandApplicator() {} // 0x000000018BFD8844-0x000000018BFD89F0
	
		// Methods
		public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x000000018BFD7454-0x000000018BFD7550
		public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x000000018BFD7550-0x000000018BFD763C
		public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x000000018BFD763C-0x000000018BFD7724
		public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x000000018BFD7724-0x000000018BFD77F0
		public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x000000018BFD77F0-0x000000018BFD78D4
		public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x000000018BFD78D4-0x000000018BFD79C4
		public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x000000018BFD79C4-0x000000018BFD7AFC
		public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x000000018BFD7AFC-0x000000018BFD7BA0
		private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) {
			grow = default;
			shrink = default;
			basis = default;
			return default;
		} // 0x000000018BFD806C-0x000000018BFD8220
		private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) {
			top = default;
			right = default;
			bottom = default;
			left = default;
		} // 0x000000018BFD7BA0-0x000000018BFD7C90
		private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) {
			top = default;
			right = default;
			bottom = default;
			left = default;
		} // 0x000000018BFD7F10-0x000000018BFD806C
		private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) {
			top = default;
			right = default;
			bottom = default;
			left = default;
		} // 0x000000018BFD7E64-0x000000018BFD7F10
		private static void CompileBoxArea(StylePropertyReader reader, out UnityEngine.Color top, out UnityEngine.Color right, out UnityEngine.Color bottom, out UnityEngine.Color left) {
			top = default;
			right = default;
			bottom = default;
			left = default;
		} // 0x000000018BFD7C90-0x000000018BFD7E64
		private static void CompileTextOutline(StylePropertyReader reader, out UnityEngine.Color outlineColor, out float outlineWidth) {
			outlineColor = default;
			outlineWidth = default;
		} // 0x000000018BFD8220-0x000000018BFD82D8
		private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<UnityEngine.UIElements.EasingFunction> outTimingFunction) {
			outDelay = default;
			outDuration = default;
			outProperty = default;
			outTimingFunction = default;
		} // 0x000000018BFD82D8-0x000000018BFD8844
	}

	internal static class StylePropertyCache // TypeDefIndex: 44949
	{
		// Fields
		internal static readonly Dictionary<string, string> s_PropertySyntaxCache; // 0x00
		internal static readonly Dictionary<string, string> s_NonTerminalValues; // 0x08
	
		// Constructors
		static StylePropertyCache() {} // 0x000000018BFD8AEC-0x000000018BFD9CA4
	
		// Methods
		public static bool TryGetSyntax(string name, out string syntax) {
			syntax = default;
			return default;
		} // 0x000000018BFD8A70-0x000000018BFD8AEC
		public static bool TryGetNonTerminalValue(string name, out string syntax) {
			syntax = default;
			return default;
		} // 0x000000018BFD89F0-0x000000018BFD8A70
	}

	internal enum StyleEnumType // TypeDefIndex: 44950
	{
		Align = 0,
		DisplayStyle = 1,
		EasingMode = 2,
		FlexDirection = 3,
		FontStyle = 4,
		Justify = 5,
		Overflow = 6,
		OverflowClipBox = 7,
		OverflowInternal = 8,
		Position = 9,
		ScaleMode = 10,
		TextAnchor = 11,
		TextOverflow = 12,
		TextOverflowPosition = 13,
		TransformOriginOffset = 14,
		Visibility = 15,
		WhiteSpace = 16,
		Wrap = 17
	}

	internal enum StylePropertyId // TypeDefIndex: 44951
	{
		Custom = -1,
		Unknown = 0,
		Color = 65536,
		FontSize = 65537,
		LetterSpacing = 65538,
		TextShadow = 65539,
		UnityFont = 65540,
		UnityFontDefinition = 65541,
		UnityFontStyleAndWeight = 65542,
		UnityParagraphSpacing = 65543,
		UnityTextAlign = 65544,
		UnityTextOutlineColor = 65545,
		UnityTextOutlineWidth = 65546,
		Visibility = 65547,
		WhiteSpace = 65548,
		WordSpacing = 65549,
		AlignContent = 131072,
		AlignItems = 131073,
		AlignSelf = 131074,
		BorderBottomWidth = 131075,
		BorderLeftWidth = 131076,
		BorderRightWidth = 131077,
		BorderTopWidth = 131078,
		Bottom = 131079,
		Display = 131080,
		FlexBasis = 131081,
		FlexDirection = 131082,
		FlexGrow = 131083,
		FlexShrink = 131084,
		FlexWrap = 131085,
		Height = 131086,
		JustifyContent = 131087,
		Left = 131088,
		MarginBottom = 131089,
		MarginLeft = 131090,
		MarginRight = 131091,
		MarginTop = 131092,
		MaxHeight = 131093,
		MaxWidth = 131094,
		MinHeight = 131095,
		MinWidth = 131096,
		PaddingBottom = 131097,
		PaddingLeft = 131098,
		PaddingRight = 131099,
		PaddingTop = 131100,
		Position = 131101,
		Right = 131102,
		Top = 131103,
		Width = 131104,
		Cursor = 196608,
		TextOverflow = 196609,
		UnityBackgroundImageTintColor = 196610,
		UnityBackgroundScaleMode = 196611,
		UnityOverflowClipBox = 196612,
		UnitySliceBottom = 196613,
		UnitySliceLeft = 196614,
		UnitySliceRight = 196615,
		UnitySliceTop = 196616,
		UnityTextOverflowPosition = 196617,
		All = 262144,
		BorderColor = 262145,
		BorderRadius = 262146,
		BorderWidth = 262147,
		Flex = 262148,
		Margin = 262149,
		Padding = 262150,
		Transition = 262151,
		UnityTextOutline = 262152,
		Rotate = 327680,
		Scale = 327681,
		TransformOrigin = 327682,
		Translate = 327683,
		TransitionDelay = 393216,
		TransitionDuration = 393217,
		TransitionProperty = 393218,
		TransitionTimingFunction = 393219,
		BackgroundColor = 458752,
		BackgroundImage = 458753,
		BorderBottomColor = 458754,
		BorderBottomLeftRadius = 458755,
		BorderBottomRightRadius = 458756,
		BorderLeftColor = 458757,
		BorderRightColor = 458758,
		BorderTopColor = 458759,
		BorderTopLeftRadius = 458760,
		BorderTopRightRadius = 458761,
		Opacity = 458762,
		Overflow = 458763
	}

	[Serializable]
	internal struct Dimension : IEquatable<Dimension> // TypeDefIndex: 44953
	{
		// Fields
		public Unit unit; // 0x00
		public float value; // 0x04
	
		// Nested types
		public enum Unit // TypeDefIndex: 44952
		{
			Unitless = 0,
			Pixel = 1,
			Percent = 2,
			Second = 3,
			Millisecond = 4,
			Degree = 5,
			Gradian = 6,
			Radian = 7,
			Turn = 8
		}
	
		// Constructors
		public Dimension(float value, Unit unit) {
			this.unit = default;
			this.value = default;
		} // 0x0000000185FE9A90-0x0000000185FE9AA0
	
		// Methods
		public Length ToLength() => default; // 0x000000018BFD3EC0-0x000000018BFD3EF0
		public TimeValue ToTime() => default; // 0x000000018BFD405C-0x000000018BFD407C
		public Angle ToAngle() => default; // 0x000000018BFD3E74-0x000000018BFD3EC0
		public static bool operator ==(Dimension lhs, Dimension rhs) => default; // 0x000000018BFD407C-0x000000018BFD40A0
		public bool Equals(Dimension other) => default; // 0x000000018BFD3E38-0x000000018BFD3E4C
		public override bool Equals(object obj) => default; // 0x000000018BFD3DC8-0x000000018BFD3E38
		public override int GetHashCode() => default; // 0x000000018BFD3E4C-0x000000018BFD3E74
		public override string ToString() => default; // 0x000000018BFD3EF0-0x000000018BFD405C
	}

	[Serializable]
	internal struct ScalableImage // TypeDefIndex: 44954
	{
		// Fields
		public Texture2D normalImage; // 0x00
		public Texture2D highResolutionImage; // 0x08
	
		// Methods
		public override string ToString() => default; // 0x000000018BFD71C4-0x000000018BFD72D8
	}

	internal struct StylePropertyValue // TypeDefIndex: 44955
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public StyleValueHandle handle; // 0x08
	}

	internal struct ImageSource // TypeDefIndex: 44956
	{
		// Fields
		public Texture2D texture; // 0x00
		public Sprite sprite; // 0x08
		public VectorImage vectorImage; // 0x10
		public RenderTexture renderTexture; // 0x18
	
		// Methods
		public bool IsNull() => default; // 0x000000018BFD429C-0x000000018BFD4364
	}

	internal class StylePropertyReader // TypeDefIndex: 44958
	{
		// Fields
		internal static GetCursorIdFunction getCursorIdFunc; // 0x00
		private List<StylePropertyValue> m_Values; // 0x10
		private List<int> m_ValueCount; // 0x18
		private StyleVariableResolver m_Resolver; // 0x20
		private StyleSheet m_Sheet; // 0x28
		private StyleProperty[] m_Properties; // 0x30
		private StylePropertyId[] m_PropertyIds; // 0x38
		private int m_CurrentValueIndex; // 0x40
		private int m_CurrentPropertyIndex; // 0x44
		private StyleProperty _property_k__BackingField; // 0x48
		private StylePropertyId _propertyId_k__BackingField; // 0x50
		private int _valueCount_k__BackingField; // 0x54
		private float _dpiScaling_k__BackingField; // 0x58
	
		// Properties
		public StyleProperty property { get; private set; } // 0x0000000185FB0680-0x0000000185FB0690 0x0000000185FB06B0-0x0000000185FB06C0
		public StylePropertyId propertyId { get; private set; } // 0x0000000185FB0670-0x0000000185FB0680 0x0000000185FB06A0-0x0000000185FB06B0
		public int valueCount { get; private set; } // 0x0000000181DE2580-0x0000000181DE2590 0x0000000181DE28C0-0x0000000181DE28D0
		public float dpiScaling { get; private set; } // 0x000000018BFDC5B4-0x000000018BFDC690 0x000000018BFDC74C-0x000000018BFDC798
	
		// Nested types
		internal delegate int GetCursorIdFunction(StyleSheet sheet, StyleValueHandle handle); // TypeDefIndex: 44957; 0x000000018571FEC0-0x000000018571FED0
	
		// Constructors
		public StylePropertyReader() {} // 0x0000000181B59400-0x0000000181B59410
	
		// Methods
		public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1f /* Metadata: 0x0205B937 */) {} // 0x000000018BFDA1A8-0x000000018BFDA1CC
		public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1f /* Metadata: 0x0205B93B */) {} // 0x000000018BFD9D08-0x000000018BFD9D88
		public StylePropertyId MoveNextProperty() => default; // 0x000000018BFD9CA4-0x000000018BFD9D08
		public StylePropertyValue GetValue(int index) => default; // 0x000000018BFD9E14-0x000000018BFD9E88
		public StyleValueType GetValueType(int index) => default; // 0x000000018BFD9D88-0x000000018BFD9E14
		public bool IsValueType(int index, StyleValueType type) => default; // 0x000000018BFDA244-0x000000018BFDA2B4
		public bool IsKeyword(int index, StyleValueKeyword keyword) => default; // 0x000000018BFDB1DC-0x000000018BFDB298
		public string ReadAsString(int index) => default; // 0x000000018BFDBE18-0x000000018BFDBED8
		public Length ReadLength(int index) => default; // 0x000000018BFDC284-0x000000018BFDC3D4
		public TimeValue ReadTimeValue(int index) => default; // 0x000000018BFDBFC4-0x000000018BFDC10C
		public Translate ReadTranslate(int index) => default; // 0x000000018BFDB72C-0x000000018BFDB8C8
		public TransformOrigin ReadTransformOrigin(int index) => default; // 0x000000018BFDBA40-0x000000018BFDBB7C
		public Rotate ReadRotate(int index) => default; // 0x000000018BFDAA48-0x000000018BFDAABC
		public Scale ReadScale(int index) => default; // 0x000000018BFDB164-0x000000018BFDB1DC
		public float ReadFloat(int index) => default; // 0x000000018BFDA50C-0x000000018BFDA614
		public int ReadInt(int index) => default; // 0x000000018BFDA974-0x000000018BFDAA48
		public UnityEngine.Color ReadColor(int index) => default; // 0x000000018BFDAABC-0x000000018BFDAECC
		public int ReadEnum(StyleEnumType enumType, int index) => default; // 0x000000018BFDAECC-0x000000018BFDB164
		public FontDefinition ReadFontDefinition(int index) => default; // 0x000000018BFDA2B4-0x000000018BFDA50C
		public Font ReadFont(int index) => default; // 0x000000018BFDA614-0x000000018BFDA8DC
		public Background ReadBackground(int index) => default; // 0x000000018BFDBB7C-0x000000018BFDBE18
		public UnityEngine.UIElements.Cursor ReadCursor(int index) => default; // 0x000000018BFDB298-0x000000018BFDB3E4
		public TextShadow ReadTextShadow(int index) => default; // 0x000000018BFDB520-0x000000018BFDB670
		public void ReadListEasingFunction(List<UnityEngine.UIElements.EasingFunction> list, int index) {} // 0x000000018BFDB3E4-0x000000018BFDB520
		public void ReadListTimeValue(List<TimeValue> list, int index) {} // 0x000000018BFD9E88-0x000000018BFDA1A8
		public void ReadListStylePropertyName(List<StylePropertyName> list, int index) {} // 0x000000018BFDC690-0x000000018BFDC74C
		private void LoadProperties() {} // 0x000000018BFDC10C-0x000000018BFDC284
		private void SetCurrentProperty() {} // 0x000000018BFDBED8-0x000000018BFDBFC4
		public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) => default; // 0x000000018BFDC3D4-0x000000018BFDC5B4
		private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal) {
			isVertical = default;
			isHorizontal = default;
			return default;
		} // 0x000000018BFDB8C8-0x000000018BFDBA40
		public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) => default; // 0x000000018BFDB670-0x000000018BFDB72C
		public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) => default; // 0x000000018BFDA8DC-0x000000018BFDA974
		public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) => default; // 0x000000018BFDA1CC-0x000000018BFDA244
		private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) => default; // 0x000000018BFDC798-0x000000018BFDCD10
		public static Angle ReadAngle(StylePropertyValue value) => default; // 0x000000018BFDCD10-0x000000018BFDCE08
		internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source) {
			source = default;
			return default;
		} // 0x000000018BFD4174-0x000000018BFD429C
	}

	internal struct MatchResultInfo // TypeDefIndex: 44959
	{
		// Fields
		public readonly bool success; // 0x00
		public readonly PseudoStates triggerPseudoMask; // 0x04
		public readonly PseudoStates dependencyPseudoMask; // 0x08
	
		// Constructors
		public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) {
			this.success = default;
			this.triggerPseudoMask = default;
			this.dependencyPseudoMask = default;
		} // 0x0000000185FE9AA0-0x0000000185FE9AB0
	}

	internal struct SelectorMatchRecord // TypeDefIndex: 44960
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public int styleSheetIndexInStack; // 0x08
		public StyleComplexSelector complexSelector; // 0x10
	
		// Constructors
		public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack) {
			this.sheet = default;
			this.styleSheetIndexInStack = default;
			complexSelector = default;
		} // 0x000000018BFD73F4-0x000000018BFD741C
	
		// Methods
		public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) => default; // 0x000000018BFD72D8-0x000000018BFD73F4
	}

	internal static class StyleSelectorHelper // TypeDefIndex: 44961
	{
		// Methods
		public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) => default; // 0x000000018BFDDCA0-0x000000018BFDDF04
		public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) => default; // 0x000000018BFDDB10-0x000000018BFDDCA0
		private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) {} // 0x000000018BFDD530-0x000000018BFDD678
		public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) {} // 0x000000018BFDD678-0x000000018BFDDB10
	}

	internal static class StyleSheetCache // TypeDefIndex: 44964
	{
		// Fields
		private static SheetHandleKeyComparer s_Comparer; // 0x00
		private static Dictionary<SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; // 0x08
	
		// Nested types
		private struct SheetHandleKey // TypeDefIndex: 44962
		{
			// Fields
			public readonly int sheetInstanceID; // 0x00
			public readonly int index; // 0x04
	
			// Constructors
			public SheetHandleKey(StyleSheet sheet, int index) {
				sheetInstanceID = default;
				this.index = default;
			} // 0x000000018BFDDFC4-0x000000018BFDE164
		}
	
		private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey> // TypeDefIndex: 44963
		{
			// Constructors
			public SheetHandleKeyComparer() {} // 0x000000018BFDE214-0x000000018BFDE308
	
			// Methods
			public bool Equals(SheetHandleKey x, SheetHandleKey y) => default; // 0x000000018BFDE164-0x000000018BFDE214
			public int GetHashCode(SheetHandleKey key) => default; // 0x000000018BFDDF04-0x000000018BFDDFC4
		}
	
		// Constructors
		static StyleSheetCache() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) => default; // 0x000000018BFD741C-0x000000018BFD7454
		internal static StylePropertyId[] GetPropertyIds(StyleRule rule) => default; // 0x00000001890D46A8-0x00000001890D46C0
		private static StylePropertyId GetPropertyId(StyleRule rule, int index) => default; // 0x0000000185FC7B00-0x0000000185FC7B10
	}

	internal static class StyleSheetColor // TypeDefIndex: 44965
	{
		// Fields
		private static Dictionary<string, Color32> s_NameToColor; // 0x00
	
		// Constructors
		static StyleSheetColor() {} // 0x000000018BFDE3A8-0x000000018BFE00C4
	
		// Methods
		public static bool TryGetColor(string name, out UnityEngine.Color color) {
			color = default;
			return default;
		} // 0x000000018BFDE308-0x000000018BFDE3A8
		private static Color32 HexToColor32(uint color) => default; // 0x0000000185FE9AB0-0x0000000185FE9AD0
	}

	internal static class StyleSheetExtensions // TypeDefIndex: 44966
	{
		// Methods
		public static string ReadAsString(StyleSheet sheet, StyleValueHandle handle) => default; // 0x000000018BFE00DC-0x000000018BFE03C0
		public static bool IsVarFunction(StyleValueHandle handle) => default; // 0x000000018BFE00C4-0x000000018BFE00DC
	}

	internal struct StyleValue // TypeDefIndex: 44967
	{
		// Fields
		public StylePropertyId id; // 0x00
		public StyleKeyword keyword; // 0x04
		public float number; // 0x08
		public Length length; // 0x08
		public UnityEngine.Color color; // 0x08
		public GCHandle resource; // 0x08
	}

	internal struct StyleValueManaged // TypeDefIndex: 44968
	{
		// Fields
		public StylePropertyId id; // 0x00
		public StyleKeyword keyword; // 0x04
		public object value; // 0x08
	}

	internal enum MatchResultErrorCode // TypeDefIndex: 44969
	{
		None = 0,
		Syntax = 1,
		EmptyValue = 2,
		ExpectedEndOfValue = 3
	}

	internal struct MatchResult // TypeDefIndex: 44970
	{
		// Fields
		public MatchResultErrorCode errorCode; // 0x00
		public string errorValue; // 0x08
	
		// Properties
		public bool success { get => default; } // 0x00000001840066E0-0x00000001840066F0 
	}

	internal abstract class BaseStyleMatcher // TypeDefIndex: 44972
	{
		// Fields
		protected static readonly Regex s_CustomIdentRegex; // 0x00
		private Stack<MatchContext> m_ContextStack; // 0x10
		private MatchContext m_CurrentContext; // 0x18
	
		// Properties
		public abstract int valueCount { get; }
		public abstract bool isCurrentVariable { get; }
		public abstract bool isCurrentComma { get; }
		public bool hasCurrent { get; } // 0x000000018BFD3DA4-0x000000018BFD3DC8 
		public int currentIndex { get; set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public int matchedVariableCount { get; set; } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
	
		// Nested types
		private struct MatchContext // TypeDefIndex: 44971
		{
			// Fields
			public int valueIndex; // 0x00
			public int matchedVariableCount; // 0x04
		}
	
		// Constructors
		protected BaseStyleMatcher() {} // 0x000000018BFD3D2C-0x000000018BFD3DA4
		static BaseStyleMatcher() {} // 0x000000018BFD3C98-0x000000018BFD3D2C
	
		// Methods
		protected abstract bool MatchKeyword(string keyword);
		protected abstract bool MatchNumber();
		protected abstract bool MatchInteger();
		protected abstract bool MatchLength();
		protected abstract bool MatchPercentage();
		protected abstract bool MatchColor();
		protected abstract bool MatchResource();
		protected abstract bool MatchUrl();
		protected abstract bool MatchTime();
		protected abstract bool MatchAngle();
		protected abstract bool MatchCustomIdent();
		protected void Initialize() {} // 0x000000018BFD3308-0x000000018BFD3350
		public void MoveNext() {} // 0x000000018BFD3BCC-0x000000018BFD3C00
		public void SaveContext() {} // 0x000000018BFD3C4C-0x000000018BFD3C98
		public void RestoreContext() {} // 0x000000018BFD3C00-0x000000018BFD3C4C
		public void DropContext() {} // 0x000000018BFD32C0-0x000000018BFD3308
		protected bool Match(Expression exp) => default; // 0x000000018BFD3B2C-0x000000018BFD3BCC
		private bool MatchExpression(Expression exp) => default; // 0x000000018BFD35E0-0x000000018BFD36A4
		private bool MatchExpressionWithMultiplier(Expression exp) => default; // 0x000000018BFD3518-0x000000018BFD35E0
		private bool MatchGroup(Expression exp) => default; // 0x000000018BFD36A4-0x000000018BFD374C
		private bool MatchCombinator(Expression exp) => default; // 0x000000018BFD3384-0x000000018BFD344C
		private bool MatchOr(Expression exp) => default; // 0x000000018BFD3A44-0x000000018BFD3B2C
		private bool MatchOrOr(Expression exp) => default; // 0x000000018BFD3A2C-0x000000018BFD3A44
		private bool MatchAndAnd(Expression exp) => default; // 0x000000018BFD3350-0x000000018BFD3384
		private int MatchMany(Expression exp) => default; // 0x000000018BFD38FC-0x000000018BFD3A2C
		private unsafe int MatchManyByOrder(Expression exp, int* matchOrder) => default; // 0x000000018BFD37B4-0x000000018BFD38FC
		private bool MatchJuxtaposition(Expression exp) => default; // 0x000000018BFD374C-0x000000018BFD37B4
		private bool MatchDataType(Expression exp) => default; // 0x000000018BFD344C-0x000000018BFD3518
	}

	internal class StylePropertyValueMatcher : BaseStyleMatcher // TypeDefIndex: 44973
	{
		// Fields
		private List<StylePropertyValue> m_Values; // 0x20
	
		// Properties
		private StylePropertyValue current { get => default; } // 0x000000018BFDD3FC-0x000000018BFDD47C 
		public override int valueCount { get => default; } // 0x000000018BFDD4F0-0x000000018BFDD530 
		public override bool isCurrentVariable { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public override bool isCurrentComma { get => default; } // 0x000000018BFDD47C-0x000000018BFDD4F0 
	
		// Constructors
		public StylePropertyValueMatcher() {} // 0x000000018BFDD3B0-0x000000018BFDD3FC
	
		// Methods
		public UnityEngine.UIElements.StyleSheets.MatchResult Match(Expression exp, List<StylePropertyValue> values) => default; // 0x000000018BFDD238-0x000000018BFDD3B0
		protected override bool MatchKeyword(string keyword) => default; // 0x000000018BFDD018-0x000000018BFDD0B4
		protected override bool MatchNumber() => default; // 0x000000018BFDCFF8-0x000000018BFDD018
		protected override bool MatchInteger() => default; // 0x000000018BFDCFF8-0x000000018BFDD018
		protected override bool MatchLength() => default; // 0x000000018BFDD0B4-0x000000018BFDD128
		protected override bool MatchPercentage() => default; // 0x000000018BFDD128-0x000000018BFDD19C
		protected override bool MatchColor() => default; // 0x000000018BFDCE84-0x000000018BFDCF40
		protected override bool MatchResource() => default; // 0x000000018BFDD19C-0x000000018BFDD1BC
		protected override bool MatchUrl() => default; // 0x000000018BFDD20C-0x000000018BFDD238
		protected override bool MatchTime() => default; // 0x000000018BFDD1BC-0x000000018BFDD20C
		protected override bool MatchCustomIdent() => default; // 0x000000018BFDCF40-0x000000018BFDCFF8
		protected override bool MatchAngle() => default; // 0x000000018BFDCE08-0x000000018BFDCE84
	}
}

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	internal class Expression // TypeDefIndex: 44974
	{
		// Fields
		public ExpressionType type; // 0x10
		public ExpressionMultiplier multiplier; // 0x14
		public UnityEngine.UIElements.StyleSheets.Syntax.DataType dataType; // 0x20
		public ExpressionCombinator combinator; // 0x24
		public Expression[] subExpressions; // 0x28
		public string keyword; // 0x30
	
		// Constructors
		public Expression() {} // Dummy constructor
		public Expression(ExpressionType type) {} // 0x000000018BFD4114-0x000000018BFD4174
	}

	internal enum ExpressionType // TypeDefIndex: 44975
	{
		Unknown = 0,
		Data = 1,
		Keyword = 2,
		Combinator = 3
	}

	internal enum DataType // TypeDefIndex: 44976
	{
		None = 0,
		Number = 1,
		Integer = 2,
		Length = 3,
		Percentage = 4,
		Color = 5,
		Resource = 6,
		Url = 7,
		Time = 8,
		Angle = 9,
		CustomIdent = 10
	}

	internal enum ExpressionCombinator // TypeDefIndex: 44977
	{
		None = 0,
		Or = 1,
		OrOr = 2,
		AndAnd = 3,
		Juxtaposition = 4,
		Group = 5
	}

	internal enum ExpressionMultiplierType // TypeDefIndex: 44978
	{
		None = 0,
		ZeroOrMore = 1,
		OneOrMore = 2,
		ZeroOrOne = 3,
		Ranges = 4,
		OneOrMoreComma = 5,
		GroupAtLeastOne = 6
	}

	internal struct ExpressionMultiplier // TypeDefIndex: 44979
	{
		// Fields
		public const int Infinity = 100; // Metadata: 0x0205B960
		private ExpressionMultiplierType m_Type; // 0x00
		public int min; // 0x04
		public int max; // 0x08
	
		// Properties
		public ExpressionMultiplierType type { get => default; set {} } // 0x0000000185FE64F0-0x0000000185FE6500 0x000000018BFD410C-0x000000018BFD4114
	
		// Constructors
		public ExpressionMultiplier(ExpressionMultiplierType type = ExpressionMultiplierType.None /* Metadata: 0x0205B95F */) : this() {
			m_Type = default;
			min = default;
			max = default;
		} // 0x000000018BFD40F4-0x000000018BFD410C
	
		// Methods
		private void SetType(ExpressionMultiplierType value) {} // 0x000000018BFD40A0-0x000000018BFD40F4
	}

	internal class StyleSyntaxParser // TypeDefIndex: 44980
	{
		// Fields
		private List<Expression> m_ProcessExpressionList; // 0x10
		private Stack<Expression> m_ExpressionStack; // 0x18
		private Stack<ExpressionCombinator> m_CombinatorStack; // 0x20
		private Dictionary<string, Expression> m_ParsedExpressionCache; // 0x28
	
		// Constructors
		public StyleSyntaxParser() {} // 0x000000018BFE1E08-0x000000018BFE1F60
	
		// Methods
		public Expression Parse(string syntax) => default; // 0x000000018BFE1A2C-0x000000018BFE1BD0
		private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) => default; // 0x000000018BFE0AB8-0x000000018BFE0D34
		private void ProcessCombinatorStack() {} // 0x000000018BFE1BD0-0x000000018BFE1E08
		private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) => default; // 0x000000018BFE187C-0x000000018BFE1A2C
		private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) => default; // 0x000000018BFE0464-0x000000018BFE05D8
		private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) => default; // 0x000000018BFE0D34-0x000000018BFE0FD0
		private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) => default; // 0x000000018BFE05D8-0x000000018BFE0AB8
		private Expression ParseNonTerminalValue(string syntax) => default; // 0x000000018BFE1178-0x000000018BFE12AC
		private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) => default; // 0x000000018BFE12AC-0x000000018BFE1744
		private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) {} // 0x000000018BFE0FD0-0x000000018BFE1178
		private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) {
			min = default;
			max = default;
		} // 0x000000018BFE1744-0x000000018BFE187C
		private static void EatSpace(StyleSyntaxTokenizer tokenizer) {} // 0x000000018BFE03C0-0x000000018BFE0414
		private static bool IsExpressionEnd(StyleSyntaxToken token) => default; // 0x000000018BFE0428-0x000000018BFE0444
		private static bool IsCombinator(StyleSyntaxToken token) => default; // 0x000000018BFE0414-0x000000018BFE0428
		private static bool IsMultiplier(StyleSyntaxToken token) => default; // 0x000000018BFE0444-0x000000018BFE0464
	}

	internal enum StyleSyntaxTokenType // TypeDefIndex: 44981
	{
		Unknown = 0,
		String = 1,
		Number = 2,
		Space = 3,
		SingleBar = 4,
		DoubleBar = 5,
		DoubleAmpersand = 6,
		Comma = 7,
		SingleQuote = 8,
		Asterisk = 9,
		Plus = 10,
		QuestionMark = 11,
		HashMark = 12,
		ExclamationPoint = 13,
		OpenBracket = 14,
		CloseBracket = 15,
		OpenBrace = 16,
		CloseBrace = 17,
		LessThan = 18,
		GreaterThan = 19,
		End = 20
	}

	internal struct StyleSyntaxToken // TypeDefIndex: 44982
	{
		// Fields
		public StyleSyntaxTokenType type; // 0x00
		public string text; // 0x08
		public int number; // 0x10
	
		// Constructors
		public StyleSyntaxToken(StyleSyntaxTokenType t) {
			type = default;
			text = default;
			number = default;
		} // 0x000000018BFE2A28-0x000000018BFE2A4C
		public StyleSyntaxToken(StyleSyntaxTokenType type, string text) {
			this.type = default;
			this.text = default;
			number = default;
		} // 0x000000018BFE2A4C-0x000000018BFE2A70
		public StyleSyntaxToken(StyleSyntaxTokenType type, int number) {
			this.type = default;
			text = default;
			this.number = default;
		} // 0x000000018BFE2A70-0x000000018BFE2A98
	}

	internal class StyleSyntaxTokenizer // TypeDefIndex: 44983
	{
		// Fields
		private List<StyleSyntaxToken> m_Tokens; // 0x10
		private int m_CurrentTokenIndex; // 0x18
	
		// Properties
		public StyleSyntaxToken current { get => default; } // 0x000000018BFE36E4-0x000000018BFE379C 
	
		// Constructors
		public StyleSyntaxTokenizer() {} // 0x000000018BFE3668-0x000000018BFE36E4
	
		// Methods
		public StyleSyntaxToken MoveNext() => default; // 0x000000018BFE2C60-0x000000018BFE2D14
		public StyleSyntaxToken PeekNext() => default; // 0x000000018BFE2D14-0x000000018BFE2DCC
		public void Tokenize(string syntax) {} // 0x000000018BFE2DCC-0x000000018BFE3668
		private static bool IsNextCharacter(string s, int index, char c) => default; // 0x000000018BFE2AE8-0x000000018BFE2B24
		private static bool IsNextLetterOrDash(string s, int index) => default; // 0x000000018BFE2B24-0x000000018BFE2BE0
		private static bool IsNextNumber(string s, int index) => default; // 0x000000018BFE2BE0-0x000000018BFE2C60
		private static int GlobCharacter(string s, int index, char c) => default; // 0x000000018BFE2A98-0x000000018BFE2AE8
	}
}

namespace UnityEngine.UIElements.UIR
{
	internal class Allocator2D // TypeDefIndex: 44852
	{
		// Fields
		private readonly Vector2Int m_MinSize; // 0x10
		private readonly Vector2Int m_MaxSize; // 0x18
		private readonly Vector2Int m_MaxAllocSize; // 0x20
		private readonly int m_RowHeightBias; // 0x28
		private readonly Row[] m_Rows; // 0x30
		private readonly List<Area> m_Areas; // 0x38
	
		// Nested types
		public class Area // TypeDefIndex: 44849
		{
			// Fields
			public RectInt rect; // 0x10
			public BestFitAllocator allocator; // 0x20
	
			// Constructors
			public Area() {} // Dummy constructor
			public Area(RectInt rect) {} // 0x000000018C05D018-0x000000018C05D1E4
		}
	
		public class Row : LinkedPoolItem<Row> // TypeDefIndex: 44850
		{
			// Fields
			public RectInt rect; // 0x18
			public Area area; // 0x28
			public BestFitAllocator allocator; // 0x30
			public Alloc alloc; // 0x38
			public Row next; // 0x50
			public static readonly LinkedPool<Row> pool; // 0x00
	
			// Constructors
			public Row() {} // 0x000000018C05C6E0-0x000000018C05C884
			static Row() {} // 0x000000018C05C8EC-0x000000018C05C9B8
	
			// Methods
			private static Row Create() => default; // 0x000000018C05CBBC-0x000000018C05D018
			private static void Reset(Row row) {} // 0x000000018C05C9B8-0x000000018C05CBBC
		}
	
		public struct Alloc2D // TypeDefIndex: 44851
		{
			// Fields
			public RectInt rect; // 0x00
			public Row row; // 0x10
			public Alloc alloc; // 0x18
	
			// Constructors
			public Alloc2D(Row row, Alloc alloc, int width, int height) {
				rect = default;
				this.row = default;
				this.alloc = default;
			} // 0x000000018C05C884-0x000000018C05C8EC
		}
	
		// Constructors
		public Allocator2D() {} // Dummy constructor
		public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) {} // 0x000000018C05D1E4-0x000000018C05D264
	
		// Methods
		public bool TryAllocate(int width, int height, out Alloc2D alloc2D) {
			alloc2D = default;
			return default;
		} // 0x000000018C06839C-0x000000018C0683EC
		public void Free(Alloc2D alloc2D) {} // 0x000000018C0683EC-0x000000018C068440
		private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize) {} // 0x000000018C068574-0x000000018C06859C
		private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias) => default; // 0x000000018C068440-0x000000018C068574
		private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) => default; // 0x000000018C05C640-0x000000018C05C6E0
	}

	internal class GradientSettingsAtlas : IDisposable // TypeDefIndex: 44854
	{
		// Fields
		private static ProfilerMarker s_MarkerWrite; // 0x00
		private static ProfilerMarker s_MarkerCommit; // 0x08
		private readonly int m_Length; // 0x10
		private readonly int m_ElemWidth; // 0x14
		private BestFitAllocator m_Allocator; // 0x18
		private Texture2D m_Atlas; // 0x20
		private RawTexture m_RawAtlas; // 0x28
		private static int s_TextureCounter; // 0x10
		private bool _disposed_k__BackingField; // 0x38
		private bool _MustCommit_k__BackingField; // 0x39
	
		// Properties
		internal int length { get => default; } // 0x0000000185FAFE20-0x0000000185FAFE30 
		protected bool disposed { get; private set; } // 0x000000018C05D908-0x000000018C05D958 0x000000018C05D958-0x000000018C05D9B8
		public Texture2D atlas { get => default; } // 0x000000018C05DBC4-0x000000018C05DF04 
		public bool MustCommit { get; private set; } // 0x000000018C05D8A4-0x000000018C05D908 0x000000018C05D9B8-0x000000018C05DB0C
	
		// Nested types
		private struct RawTexture // TypeDefIndex: 44853
		{
			// Fields
			public Color32[] rgba; // 0x00
			public int width; // 0x08
			public int height; // 0x0C
	
			// Methods
			public void WriteRawInt2Packed(int v0, int v1, int destX, int destY) {} // 0x0000000185FE6790-0x0000000185FE67A0
			public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY) {} // 0x0000000185FB0700-0x0000000185FB0710
		}
	
		// Constructors
		public GradientSettingsAtlas() {} // Dummy constructor
		public GradientSettingsAtlas(int length = 4096 /* Metadata: 0x0205B76B */) {} // 0x0000000185FE66B0-0x0000000185FE66C0
		static GradientSettingsAtlas() {} // 0x000000018C06825C-0x000000018C068308
	
		// Methods
		public void Dispose() {} // 0x000000018C05DF9C-0x000000018C05DFB0
		protected virtual void Dispose(bool disposing) {} // 0x000000018C05DB0C-0x000000018C05DBC4
		public void Reset() {} // 0x000000018C05D7E0-0x000000018C05D8A4
		public Alloc Add(int count) => default; // 0x0000000185FB0710-0x0000000185FB0720
		public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) {} // 0x0000000185FB0720-0x0000000185FB0730
		public void Commit() {} // 0x000000018C05DF04-0x000000018C05DF9C
		private void PrepareAtlas() {} // 0x000000018C068308-0x000000018C06839C
	}

	internal class LinkedPoolItem<T> // TypeDefIndex: 44855
	{
		// Fields
		internal T poolNext;
	
		// Constructors
		public LinkedPoolItem() {}
	}

	internal class LinkedPool<T> // TypeDefIndex: 44856
		where T : LinkedPoolItem<T>
	{
		// Fields
		private readonly Func<T> m_CreateFunc;
		private readonly Action<T> m_ResetAction;
		private readonly int m_Limit;
		private T m_PoolFirst;
		private int _Count_k__BackingField;
	
		// Properties
		public int Count { get; private set; }
	
		// Constructors
		public LinkedPool() {} // Dummy constructor
		public LinkedPool(Func<T> createFunc, Action<T> resetAction, int limit = 10000 /* Metadata: 0x0205B76D */) {}
	
		// Methods
		public void Clear() {}
		public T Get() => default;
		public void Return(T item) {}
	}

	internal class BasicNode<T> : LinkedPoolItem<BasicNode<T>> // TypeDefIndex: 44857
	{
		// Fields
		public BasicNode<T> next;
		public T data;
	
		// Constructors
		public BasicNode() {}
	
		// Methods
		public void AppendTo(ref BasicNode<T> first) {}
	}

	internal class BasicNodePool<T> : LinkedPool<BasicNode<T>> // TypeDefIndex: 44858
	{
		// Constructors
		public BasicNodePool() {}
	
		// Methods
		private static void Reset(BasicNode<T> node) {}
		private static BasicNode<T> Create() => default;
	}

	internal static class MeshBuilder // TypeDefIndex: 44863
	{
		// Fields
		private static ProfilerMarker s_VectorGraphics9Slice; // 0x00
		private static ProfilerMarker s_VectorGraphicsSplitTriangle; // 0x08
		private static ProfilerMarker s_VectorGraphicsScaleTriangle; // 0x10
		private static ProfilerMarker s_VectorGraphicsStretch; // 0x18
		internal static readonly int s_MaxTextMeshVertices; // 0x20
		private static readonly ushort[] slicedQuadIndices; // 0x28
		private static readonly float[] k_TexCoordSlicesX; // 0x30
		private static readonly float[] k_TexCoordSlicesY; // 0x38
		private static readonly float[] k_PositionSlicesX; // 0x40
		private static readonly float[] k_PositionSlicesY; // 0x48
		private static VertexClipEdge[] s_AllClipEdges; // 0x50
	
		// Nested types
		internal struct AllocMeshData // TypeDefIndex: 44860
		{
			// Fields
			internal Allocator alloc; // 0x00
			internal Texture texture; // 0x08
			internal TextureId svgTexture; // 0x10
			internal Material material; // 0x18
			internal MeshGenerationContext.MeshFlags flags; // 0x20
			internal BMPAlloc colorAlloc; // 0x24
	
			// Nested types
			internal delegate MeshWriteData Allocator(uint vertexCount, uint indexCount, ref AllocMeshData allocatorData); // TypeDefIndex: 44859; 0x000000018C062990-0x000000018C062B84
	
			// Methods
			internal MeshWriteData Allocate(uint vertexCount, uint indexCount) => default; // 0x000000018C0631FC-0x000000018C063A10
		}
	
		private struct ClipCounts // TypeDefIndex: 44861
		{
			// Fields
			public int firstClippedIndex; // 0x00
			public int firstDegenerateIndex; // 0x04
			public int lastClippedIndex; // 0x08
			public int clippedTriangles; // 0x0C
			public int addedTriangles; // 0x10
			public int degenerateTriangles; // 0x14
		}
	
		private enum VertexClipEdge // TypeDefIndex: 44862
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8
		}
	
		// Constructors
		static MeshBuilder() {} // 0x00000001817E31E0-0x00000001817E3200
	
		// Methods
		internal static void MakeBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, AllocMeshData meshAlloc) {} // 0x000000018C061280-0x000000018C061434
		internal static void MakeSolidRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc) {} // 0x0000000185FEA6F0-0x0000000185FEA7B0
		internal static void MakeTexturedRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc, ColorPage colorPage) {} // 0x000000018C061ACC-0x000000018C061BC0
		private static UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.MeshInfo info, int index, Vector2 offset, VertexFlags flags = VertexFlags.IsText /* Metadata: 0x0205B771 */, bool isDynamicColor = false /* Metadata: 0x0205B772 */) => default; // 0x000000018C062EA0-0x000000018C0631FC
		private static UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.UIElements.TextVertex textVertex, Vector2 offset) => default; // 0x000000018C062B84-0x000000018C062EA0
		private static int LimitTextVertices(int vertexCount, bool logTruncation = true /* Metadata: 0x0205B773 */) => default; // 0x000000018C067174-0x000000018C06739C
		internal static void MakeText(UnityEngine.TextCore.Text.MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags = VertexFlags.IsText /* Metadata: 0x0205B774 */, bool isDynamicColor = false /* Metadata: 0x0205B775 */) {} // 0x000000018C061CB8-0x000000018C0620BC
		internal static void MakeText(NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, Vector2 offset, AllocMeshData meshAlloc) {} // 0x000000018C0620BC-0x000000018C062990
		internal static void UpdateText(NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, Vector2 offset, Matrix4x4 transform, Color32 xformClipPages, Color32 ids, Color32 flags, Color32 opacityPageSettingIndex, NativeSlice<UnityEngine.UIElements.Vertex> vertices) {} // 0x000000018C0649F8-0x000000018C0654EC
		private static void MakeQuad(Rect rcPosition, Rect rcTexCoord, UnityEngine.Color color, float posZ, AllocMeshData meshAlloc, ColorPage colorPage) {} // 0x000000018C06420C-0x000000018C0649F8
		internal static void MakeSlicedQuad(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc) {} // 0x000000018C066928-0x000000018C067174
		internal static void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, int settingIndexOffset, AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount) {
			finalVertexCount = default;
			finalIndexCount = default;
		} // 0x000000018C0666B4-0x000000018C066928
		internal static void MakeVectorGraphicsStretchBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, UnityEngine.ScaleMode scaleMode, UnityEngine.Color tint, int settingIndexOffset, AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount) {
			finalVertexCount = default;
			finalIndexCount = default;
		} // 0x000000018C063A10-0x000000018C06420C
		private static unsafe void SplitTriangle(UnityEngine.UIElements.Vertex* vertices, ushort* indices, ref int vertexCount, int indexToProcess, ref int indexCount, float svgWidth, float svgHeight, Vector4 sliceLTRB, int sliceIndex) {} // 0x000000018C06739C-0x000000018C0675DC
		private static unsafe void ScaleSplittedTriangles(UnityEngine.UIElements.Vertex* vertices, int vertexCount, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB) {} // 0x000000018C0661CC-0x000000018C0666B4
		internal static void MakeVectorGraphics9SliceBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, bool stretch, UnityEngine.Color tint, int settingIndexOffset, AllocMeshData meshAlloc) {} // 0x000000018C0654EC-0x000000018C0661CC
		private static ClipCounts UpperBoundApproximateRectClippingResults(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax) => default; // 0x000000018C061434-0x000000018C061598
		private static void RectClip(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax, MeshWriteData mwd, ClipCounts cc, ref int newVertexCount) {} // 0x000000018C061768-0x000000018C06199C
		private static unsafe void RectClipTriangle(UnityEngine.UIElements.Vertex* vt, ushort* it, Vector4 clipRectMinMax, MeshWriteData mwd, ref ushort nextNewVertex) {} // 0x000000018C061598-0x000000018C061768
		private static unsafe Vector3 GetVertexBaryCentricCoordinates(UnityEngine.UIElements.Vertex* vt, float x, float y) => default; // 0x000000018C06199C-0x000000018C061ACC
		private static unsafe UnityEngine.UIElements.Vertex InterpolateVertexInTriangle(UnityEngine.UIElements.Vertex* vt, float x, float y, Vector3 uvw) => default; // 0x000000018C0675DC-0x000000018C0678DC
		private static unsafe UnityEngine.UIElements.Vertex InterpolateVertexInTriangleEdge(UnityEngine.UIElements.Vertex* vt, int e0, int e1, float t) => default; // 0x000000018BFA0D3C-0x000000018BFA0D6C
		private static float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy) => default; // 0x000000018A396C70-0x000000018A396D38
	}

	internal struct ChainBuilderStats // TypeDefIndex: 44864
	{
		// Fields
		public uint elementsAdded; // 0x00
		public uint elementsRemoved; // 0x04
		public uint recursiveClipUpdates; // 0x08
		public uint recursiveClipUpdatesExpanded; // 0x0C
		public uint nonRecursiveClipUpdates; // 0x10
		public uint recursiveTransformUpdates; // 0x14
		public uint recursiveTransformUpdatesExpanded; // 0x18
		public uint recursiveOpacityUpdates; // 0x1C
		public uint recursiveOpacityUpdatesExpanded; // 0x20
		public uint colorUpdates; // 0x24
		public uint colorUpdatesExpanded; // 0x28
		public uint recursiveVisualUpdates; // 0x2C
		public uint recursiveVisualUpdatesExpanded; // 0x30
		public uint nonRecursiveVisualUpdates; // 0x34
		public uint dirtyProcessed; // 0x38
		public uint nudgeTransformed; // 0x3C
		public uint boneTransformed; // 0x40
		public uint skipTransformed; // 0x44
		public uint visualUpdateTransformed; // 0x48
		public uint updatedMeshAllocations; // 0x4C
		public uint newMeshAllocations; // 0x50
		public uint groupTransformElementsChanged; // 0x54
		public uint immedateRenderersActive; // 0x58
		public uint textUpdates; // 0x5C
	}

	internal class RenderChain : IDisposable // TypeDefIndex: 44869
	{
		// Fields
		private RenderChainCommand m_FirstCommand; // 0x10
		private DepthOrderedDirtyTracking m_DirtyTracker; // 0x18
		private LinkedPool<RenderChainCommand> m_CommandPool; // 0x40
		private BasicNodePool<TextureEntry> m_TexturePool; // 0x48
		private List<RenderNodeData> m_RenderNodesData; // 0x50
		private Shader m_DefaultShader; // 0x58
		private Shader m_DefaultWorldSpaceShader; // 0x60
		private Material m_DefaultMat; // 0x68
		private Material m_DefaultWorldSpaceMat; // 0x70
		private bool m_BlockDirtyRegistration; // 0x78
		private int m_StaticIndex; // 0x7C
		private int m_ActiveRenderNodes; // 0x80
		private int m_CustomMaterialCommands; // 0x84
		private ChainBuilderStats m_Stats; // 0x88
		private uint m_StatsElementsAdded; // 0xE8
		private uint m_StatsElementsRemoved; // 0xEC
		private VisualElement m_FirstTextElement; // 0xF0
		private UIRTextUpdatePainter m_TextUpdatePainter; // 0xF8
		private int m_TextElementCount; // 0x100
		private int m_DirtyTextStartIndex; // 0x104
		private int m_DirtyTextRemaining; // 0x108
		private bool m_FontWasReset; // 0x10C
		private Dictionary<VisualElement, Vector2> m_LastGroupTransformElementScale; // 0x110
		private TextureRegistry m_TextureRegistry; // 0x118
		private static ProfilerMarker s_MarkerProcess; // 0x00
		private static ProfilerMarker s_MarkerClipProcessing; // 0x08
		private static ProfilerMarker s_MarkerOpacityProcessing; // 0x10
		private static ProfilerMarker s_MarkerColorsProcessing; // 0x18
		private static ProfilerMarker s_MarkerTransformProcessing; // 0x20
		private static ProfilerMarker s_MarkerVisualsProcessing; // 0x28
		private static ProfilerMarker s_MarkerTextRegen; // 0x30
		private bool _disposed_k__BackingField; // 0x120
		internal static Action OnPreRender; // 0x38
		private BaseVisualElementPanel _panel_k__BackingField; // 0x128
		private UIRenderDevice _device_k__BackingField; // 0x130
		private AtlasBase _atlas_k__BackingField; // 0x138
		private VectorImageManager _vectorImageManager_k__BackingField; // 0x140
		internal UIRVEShaderInfoAllocator shaderInfoAllocator; // 0x148
		private UIRStylePainter _painter_k__BackingField; // 0x218
		private bool _drawStats_k__BackingField; // 0x220
		private bool _drawInCameras_k__BackingField; // 0x221
	
		// Properties
		protected bool disposed { get; private set; } // 0x000000018BFA52B4-0x000000018BFA534C 0x000000018BFA53DC-0x000000018BFA5478
		internal BaseVisualElementPanel panel { get; private set; } // 0x0000000185FBC730-0x0000000185FBC740 0x0000000185FBC750-0x0000000185FBC760
		internal UIRenderDevice device { get; private set; } // 0x000000018BFA5CB8-0x000000018BFA5D5C 0x000000018BFA5D5C-0x000000018BFA5E00
		internal AtlasBase atlas { get; private set; } // 0x000000018BFA3440-0x000000018BFA352C 0x000000018BFA352C-0x000000018BFA3618
		internal VectorImageManager vectorImageManager { get; private set; } // 0x000000018BFA3368-0x000000018BFA3374 0x000000018BFA2314-0x000000018BFA23BC
		internal UIRStylePainter painter { get; private set; } // 0x000000018BFA2204-0x000000018BFA2260 0x000000018BFA3374-0x000000018BFA3414
		internal bool drawStats { get; set; } // 0x000000018BFA3ED0-0x000000018BFA3F50 0x000000018BFA3F50-0x000000018BFA3F84
		internal bool drawInCameras { get; private set; } // 0x000000018BFA2190-0x000000018BFA2204 0x000000018BFA4804-0x000000018BFA48CC
		internal Shader defaultShader { set {} } // 0x000000018BFA3618-0x000000018BFA374C
		internal Shader defaultWorldSpaceShader { set {} } // 0x000000018BFA20B4-0x000000018BFA2190
	
		// Nested types
		private struct DepthOrderedDirtyTracking // TypeDefIndex: 44865
		{
			// Fields
			public List<VisualElement> heads; // 0x00
			public List<VisualElement> tails; // 0x08
			public int[] minDepths; // 0x10
			public int[] maxDepths; // 0x18
			public uint dirtyID; // 0x20
	
			// Methods
			public void EnsureFits(int maxDepth) {} // 0x000000018BFA564C-0x000000018BFA58E0
			public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) {} // 0x000000018BFA58E0-0x000000018BFA5CB8
			public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse) {} // 0x000000018BFA23BC-0x000000018BFA2744
			public void Reset() {} // 0x000000018BFA2744-0x000000018BFA298C
		}
	
		private struct RenderChainStaticIndexAllocator // TypeDefIndex: 44866
		{
			// Fields
			private static List<RenderChain> renderChains; // 0x00
	
			// Constructors
			static RenderChainStaticIndexAllocator() {
				renderChains = default;
			} // 0x000000018BFA298C-0x000000018BFA29B8
	
			// Methods
			public static int AllocateIndex(RenderChain renderChain) => default; // 0x0000000185FB9310-0x0000000185FB9320
			public static void FreeIndex(int index) {} // 0x0000000185FD21B0-0x0000000185FD21C0
			public static RenderChain AccessIndex(int index) => default; // 0x000000018BFA29B8-0x000000018BFA2A08
		}
	
		private struct RenderNodeData // TypeDefIndex: 44867
		{
			// Fields
			public Material standardMaterial; // 0x00
			public Material initialMaterial; // 0x08
			public MaterialPropertyBlock matPropBlock; // 0x10
			public RenderChainCommand firstCommand; // 0x18
			public UIRenderDevice device; // 0x20
			public Texture vectorAtlas; // 0x28
			public Texture shaderInfoAtlas; // 0x30
			public float dpiScale; // 0x38
			public NativeSlice<Transform3x4> transformConstants; // 0x40
			public NativeSlice<Vector4> clipRectConstants; // 0x50
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 44868
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<RenderChainCommand> __9__37_0; // 0x08
			public static Action<RenderChainCommand> __9__37_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BFA4088-0x000000018BFA4604
			public __c() {} // 0x000000018BFA48CC-0x000000018BFA4C40
	
			// Methods
			internal RenderChainCommand _.ctor_b__37_0() => default; // 0x000000018BFA4604-0x000000018BFA4804
			internal void _.ctor_b__37_1(RenderChainCommand cmd) {} // 0x000000018BFA4E80-0x000000018BFA5030
		}
	
		// Constructors
		public RenderChain() {} // Dummy constructor
		static RenderChain() {} // 0x000000018BFA5124-0x000000018BFA52B4
		public RenderChain(BaseVisualElementPanel panel) {} // 0x000000018BFA5030-0x000000018BFA5124
	
		// Methods
		private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan) {} // 0x000000018BFA4E28-0x000000018BFA4E80
		private void Destructor() {} // 0x000000018BFA5478-0x000000018BFA5514
		public void Dispose() {} // 0x000000018BFA534C-0x000000018BFA53DC
		protected void Dispose(bool disposing) {} // 0x000000018BFA5514-0x000000018BFA55B0
		public void ProcessChanges() {} // 0x000000018BFA55B0-0x000000018BFA564C
		public void Render() {} // 0x0000000185FB8550-0x0000000185FB8560
		private void ProcessTextRegen(bool timeSliced) {} // 0x00000001864735A4-0x00000001864735B8
		public void UIEOnChildAdded(VisualElement ve) {} // 0x0000000185FB84E0-0x0000000185FB84F0
		public void UIEOnChildrenReordered(VisualElement ve) {} // 0x00000001864735B8-0x00000001864735CC
		public void UIEOnChildRemoving(VisualElement ve) {} // 0x0000000185FB8720-0x0000000185FB8730
		public void StopTrackingGroupTransformElement(VisualElement ve) {} // 0x00000001864735CC-0x00000001864735E0
		public void UIEOnRenderHintsChanged(VisualElement ve) {} // 0x0000000185FB85F0-0x0000000185FB8600
		public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) {} // 0x0000000187A47758-0x0000000187A4776C
		public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false /* Metadata: 0x0205B77B */) {} // 0x0000000185FB8830-0x0000000185FB8840
		public void UIEOnColorChanged(VisualElement ve) {} // 0x0000000187A47B2C-0x0000000187A47B40
		public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) {} // 0x0000000185FBC740-0x0000000185FBC750
		public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) {} // 0x0000000185FBC760-0x0000000185FBC770
		internal Material GetStandardMaterial() => default; // 0x000000018BFA3F84-0x000000018BFA4088
		internal Material GetStandardWorldSpaceMaterial() => default; // 0x000000018BFA3AC8-0x000000018BFA3ED0
		internal void EnsureFitsDepth(int depth) {} // 0x000000018BFA374C-0x000000018BFA3AC8
		internal void ChildWillBeRemoved(VisualElement ve) {} // 0x000000018BFA4C40-0x000000018BFA4CF4
		internal RenderChainCommand AllocCommand() => default; // 0x0000000185FE9990-0x0000000185FE99A0
		internal void FreeCommand(RenderChainCommand cmd) {} // 0x000000018BFA2260-0x000000018BFA2314
		internal void OnRenderCommandAdded(RenderChainCommand command) {} // 0x000000018BFA4CF4-0x000000018BFA4E28
		internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) {} // 0x000000018BFA2A08-0x000000018BFA3368
		internal void AddTextElement(VisualElement ve) {} // 0x000000018BFA3414-0x000000018BFA3440
		internal void RemoveTextElement(VisualElement ve) {} // 0x000000018BFA1894-0x000000018BFA1914
		internal void OnGroupTransformElementChangedTransform(VisualElement ve) {} // 0x000000018BFA1914-0x000000018BFA1AD8
		private static RenderNodeData AccessRenderNodeData(IntPtr obj) => default; // 0x000000018BFA16A0-0x000000018BFA1894
		private static void OnRenderNodeExecute(IntPtr obj) {} // 0x000000018BFA1AD8-0x000000018BFA1B30
		private static void OnRegisterIntermediateRenderers(Camera camera) {} // 0x000000018BFA1DE4-0x000000018BFA1EF0
		private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderNodeData rnd, Camera camera, int sameDistanceSortPriority) {} // 0x000000018BFA1EF0-0x000000018BFA1F60
		internal void RepaintTexturedElements() {} // 0x000000018BFA1D78-0x000000018BFA1DE4
		private void OnFontReset(Font font) {} // 0x000000018BFA1F60-0x000000018BFA1FF4
		public void AppendTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) {} // 0x000000018BFAE33C-0x000000018BFAE3A0
		public void ResetTextures(VisualElement ve) {} // 0x0000000185492010-0x0000000185492020
		private void DrawStats() {} // 0x000000018BFAE2EC-0x000000018BFAE33C
		private static VisualElement GetFirstElementInPanel(VisualElement ve) => default; // 0x0000000185492010-0x0000000185492020
	}

	internal enum RenderDataDirtyTypes // TypeDefIndex: 44870
	{
		None = 0,
		Transform = 1,
		ClipRectSize = 2,
		Clipping = 4,
		ClippingHierarchy = 8,
		Visuals = 16,
		VisualsHierarchy = 32,
		Opacity = 64,
		OpacityHierarchy = 128,
		Color = 256
	}

	internal enum RenderDataDirtyTypeClasses // TypeDefIndex: 44871
	{
		Clipping = 0,
		Opacity = 1,
		Color = 2,
		TransformSize = 3,
		Visuals = 4,
		Count = 5
	}

	internal struct RenderChainVEData // TypeDefIndex: 44872
	{
		// Fields
		internal VisualElement prev; // 0x00
		internal VisualElement next; // 0x08
		internal VisualElement groupTransformAncestor; // 0x10
		internal VisualElement boneTransformAncestor; // 0x18
		internal VisualElement prevDirty; // 0x20
		internal VisualElement nextDirty; // 0x28
		internal int hierarchyDepth; // 0x30
		internal RenderDataDirtyTypes dirtiedValues; // 0x34
		internal uint dirtyID; // 0x38
		internal RenderChainCommand firstCommand; // 0x40
		internal RenderChainCommand lastCommand; // 0x48
		internal RenderChainCommand firstClosingCommand; // 0x50
		internal RenderChainCommand lastClosingCommand; // 0x58
		internal bool isInChain; // 0x60
		internal bool isHierarchyHidden; // 0x61
		internal bool localFlipsWinding; // 0x62
		internal bool localTransformScaleZero; // 0x63
		internal bool worldFlipsWinding; // 0x64
		internal ClipMethod clipMethod; // 0x68
		internal int childrenStencilRef; // 0x6C
		internal int childrenMaskDepth; // 0x70
		internal bool disableNudging; // 0x74
		internal bool usesLegacyText; // 0x75
		internal MeshHandle data; // 0x78
		internal MeshHandle closingData; // 0x80
		internal Matrix4x4 verticesSpace; // 0x88
		internal int displacementUVStart; // 0xC8
		internal int displacementUVEnd; // 0xCC
		internal BMPAlloc transformID; // 0xD0
		internal BMPAlloc clipRectID; // 0xD8
		internal BMPAlloc opacityID; // 0xE0
		internal BMPAlloc textCoreSettingsID; // 0xE8
		internal BMPAlloc backgroundColorID; // 0xF0
		internal BMPAlloc borderLeftColorID; // 0xF8
		internal BMPAlloc borderTopColorID; // 0x100
		internal BMPAlloc borderRightColorID; // 0x108
		internal BMPAlloc borderBottomColorID; // 0x110
		internal BMPAlloc tintColorID; // 0x118
		internal float compositeOpacity; // 0x120
		internal UnityEngine.Color backgroundColor; // 0x124
		internal VisualElement prevText; // 0x138
		internal VisualElement nextText; // 0x140
		internal List<RenderChainTextEntry> textEntries; // 0x148
		internal BasicNode<TextureEntry> textures; // 0x150
	
		// Properties
		internal RenderChainCommand lastClosingOrLastCommand { get => default; } // 0x000000018BFA20A4-0x000000018BFA20B4 
	
		// Methods
		internal static bool AllocatesID(BMPAlloc alloc) => default; // 0x000000018BFA1FF4-0x000000018BFA204C
		internal static bool InheritsID(BMPAlloc alloc) => default; // 0x000000018BFA204C-0x000000018BFA20A4
	}

	internal struct RenderChainTextEntry // TypeDefIndex: 44873
	{
		// Fields
		internal RenderChainCommand command; // 0x00
		internal int firstVertex; // 0x08
		internal int vertexCount; // 0x0C
	}

	internal struct TextureEntry // TypeDefIndex: 44874
	{
		// Fields
		public Texture source; // 0x00
		public TextureId actual; // 0x08
		public bool replaced; // 0x0C
	}

	internal abstract class BaseShaderInfoStorage : IDisposable // TypeDefIndex: 44875
	{
		// Fields
		protected static int s_TextureCounter; // 0x00
		internal static ProfilerMarker s_MarkerCopyTexture; // 0x08
		internal static ProfilerMarker s_MarkerGetTextureData; // 0x10
		internal static ProfilerMarker s_MarkerUpdateTexture; // 0x18
		private bool _disposed_k__BackingField; // 0x10
	
		// Properties
		public abstract Texture2D texture { get; }
		protected bool disposed { get; private set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		protected BaseShaderInfoStorage() {} // 0x0000000185492010-0x0000000185492020
		static BaseShaderInfoStorage() {} // 0x000000018BFA0F00-0x000000018BFA0FD4
	
		// Methods
		public abstract bool AllocateRect(int width, int height, out RectInt uvs);
		public abstract void SetTexel(int x, int y, UnityEngine.Color color);
		public abstract void UpdateTexture();
		public void Dispose() {} // 0x000000018BFA0EB0-0x000000018BFA0F00
		protected virtual void Dispose(bool disposing) {} // 0x00000001873414D8-0x00000001873414E4
	}

	internal class ShaderInfoStorage<T> : BaseShaderInfoStorage // TypeDefIndex: 44876
		where T : struct
	{
		// Fields
		private readonly int m_InitialSize;
		private readonly int m_MaxSize;
		private readonly TextureFormat m_Format;
		private readonly Func<UnityEngine.Color, T> m_Convert;
		private UIRAtlasAllocator m_Allocator;
		private Texture2D m_Texture;
		private NativeArray<T> m_Texels;
	
		// Properties
		public override Texture2D texture { get => default; }
	
		// Constructors
		public ShaderInfoStorage() {} // Dummy constructor
		public ShaderInfoStorage(TextureFormat format, Func<UnityEngine.Color, T> convert, int initialSize = 64 /* Metadata: 0x0205B78F */, int maxSize = 4096 /* Metadata: 0x0205B791 */) {}
	
		// Methods
		protected override void Dispose(bool disposing) {}
		public override bool AllocateRect(int width, int height, out RectInt uvs) {
			uvs = default;
			return default;
		}
		public override void SetTexel(int x, int y, UnityEngine.Color color) {}
		public override void UpdateTexture() {}
		private void CreateOrExpandTexture() {}
		private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight) {}
	}

	internal class ShaderInfoStorageRGBA32 : ShaderInfoStorage<Color32> // TypeDefIndex: 44878
	{
		// Fields
		private static readonly Func<UnityEngine.Color, Color32> s_Convert; // 0x00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44877
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018BFA5EC4-0x000000018BFA5F50
			public __c() {} // 0x000000018BFA5E00-0x000000018BFA5EC4
	
			// Methods
			internal Color32 _.cctor_b__2_0(UnityEngine.Color c) => default; // 0x000000018BFAE468-0x000000018BFAE4CC
		}
	
		// Constructors
		public ShaderInfoStorageRGBA32() {} // Dummy constructor
		public ShaderInfoStorageRGBA32(int initialSize = 64 /* Metadata: 0x0205B793 */, int maxSize = 4096 /* Metadata: 0x0205B795 */) {} // 0x0000000185492010-0x0000000185492020
		static ShaderInfoStorageRGBA32() {} // 0x000000018BFAE1F0-0x000000018BFAE20C
	}

	internal class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<UnityEngine.Color> // TypeDefIndex: 44880
	{
		// Fields
		private static readonly Func<UnityEngine.Color, UnityEngine.Color> s_Convert; // 0x00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44879
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018BFA6014-0x000000018BFA60A0
			public __c() {} // 0x000000018BFA5F50-0x000000018BFA6014
	
			// Methods
			internal UnityEngine.Color _.cctor_b__2_0(UnityEngine.Color c) => default; // 0x000000018BFAE3A0-0x000000018BFAE404
		}
	
		// Constructors
		public ShaderInfoStorageRGBAFloat() {} // Dummy constructor
		public ShaderInfoStorageRGBAFloat(int initialSize = 64 /* Metadata: 0x0205B797 */, int maxSize = 4096 /* Metadata: 0x0205B799 */) {} // 0x0000000185492010-0x0000000185492020
		static ShaderInfoStorageRGBAFloat() {} // 0x0000000185FC6CA0-0x0000000185FC6CB0
	}

	internal static class Shaders // TypeDefIndex: 44881
	{
		// Fields
		public static readonly string k_AtlasBlit; // 0x00
		public static readonly string k_Editor; // 0x08
		public static readonly string k_Runtime; // 0x10
		public static readonly string k_RuntimeWorld; // 0x18
		public static readonly string k_GraphView; // 0x20
	
		// Constructors
		static Shaders() {} // 0x000000018BFA60A0-0x000000018BFA6314
	}

	internal static class Tessellation // TypeDefIndex: 44883
	{
		// Fields
		internal static float kEpsilon; // 0x00
		internal static float kUnusedArc; // 0x04
		internal static ushort kSubdivisions; // 0x08
		private static ProfilerMarker s_MarkerTessellateRect; // 0x10
		private static ProfilerMarker s_MarkerTessellateBorder; // 0x18
		private static Edges[] s_AllEdges; // 0x20
	
		// Nested types
		internal enum Edges // TypeDefIndex: 44882
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8,
			All = 15
		}
	
		// Constructors
		static Tessellation() {} // 0x000000018BFACA90-0x000000018BFACBF4
	
		// Methods
		public static void TessellateRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc, bool computeUVs) {} // 0x000000018BFAA45C-0x000000018BFAAA98
		public static void TessellateQuad(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc) {} // 0x000000018BFA9008-0x000000018BFA94D8
		public static void TessellateBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, MeshBuilder.AllocMeshData meshAlloc) {} // 0x000000018BFA700C-0x000000018BFA75A8
		private static void TessellateRoundedCorners(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFAB98C-0x000000018BFABD9C
		private static void TessellateRoundedBorders(ref MeshGenerationContextUtils.BorderParams border, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFAB17C-0x000000018BFAB6A8
		private static void TessellateRoundedCorner(Rect rect, Color32 color, float posZ, Vector2 radius, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFAB6A8-0x000000018BFAB98C
		private static void TessellateRoundedBorder(Rect rect, Color32 leftColor, Color32 topColor, float posZ, Vector2 radius, float leftWidth, float topWidth, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFAAA98-0x000000018BFAB17C
		private static Vector2 IntersectLines(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) => default; // 0x000000018BFA6CCC-0x000000018BFA6DC0
		private static int LooseCompare(float a, float b) => default; // 0x000000018BFA6DC0-0x000000018BFA6E50
		private static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFA7A80-0x000000018BFA8124
		private static void TessellateQuad(Rect rect, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFAA074-0x000000018BFAA45C
		private static void TessellateQuad(Rect rect, Edges smoothedEdges, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFA94D8-0x000000018BFA95A4
		private static int EdgesCount(Edges edges) => default; // 0x000000018BFA6680-0x000000018BFA66B0
		private static unsafe void TessellateQuad(Rect rect, Edges smoothedEdges, Vector2* offsets, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFA95A4-0x000000018BFAA074
		private static void EncodeStraightArc(ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex center, float radius) {} // 0x000000018BFA66B0-0x000000018BFA68A0
		private static void ExpandTriangle(ref Vector3 v0, ref Vector3 v1, Vector3 center, float factor) {} // 0x000000018BFA68A0-0x000000018BFA6A40
		private static void TessellateQuadSingleEdge(Rect rect, Edges smoothedEdge, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFA899C-0x000000018BFA9008
		private static void TessellateStraightBorder(Rect rect, Edges smoothedEdge, float miterOffset, UnityEngine.Color color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFABD9C-0x000000018BFACA90
		private static Vector4 GetInterpolatedCircle(Vector2 p, ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex v2) => default; // 0x000000018BFA6B04-0x000000018BFA6CCC
		private static void ComputeBarycentricCoordinates(Vector2 p, Vector2 a, Vector2 b, Vector2 c, out float u, out float v, out float w) {
			u = default;
			v = default;
			w = default;
		} // 0x000000018BFA6314-0x000000018BFA6498
		private static void TessellateFilledFan(Vector2 center, Vector2 radius, Vector2 miterOffset, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFA8124-0x000000018BFA899C
		private static void TessellateBorderedFan(Vector2 center, Vector2 outerRadius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x000000018BFA75A8-0x000000018BFA7A80
		private static void MirrorVertices(Rect rect, NativeSlice<UnityEngine.UIElements.Vertex> vertices, int vertexStart, int vertexCount, bool flipHorizontal) {} // 0x000000018BFA6E50-0x000000018BFA700C
		private static void FlipWinding(NativeSlice<ushort> indices, int indexStart, int indexCount) {} // 0x000000018BFA6A40-0x000000018BFA6B04
		private static void ComputeUVs(Rect tessellatedRect, Rect textureRect, Rect uvRegion, NativeSlice<UnityEngine.UIElements.Vertex> vertices) {} // 0x000000018BFA6498-0x000000018BFA6680
	}

	internal struct TextCoreSettings : IEquatable<TextCoreSettings> // TypeDefIndex: 44884
	{
		// Fields
		public UnityEngine.Color faceColor; // 0x00
		public UnityEngine.Color outlineColor; // 0x10
		public float outlineWidth; // 0x20
		public UnityEngine.Color underlayColor; // 0x24
		public Vector2 underlayOffset; // 0x34
		public float underlaySoftness; // 0x3C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BFACBF4-0x000000018BFACC88
		public bool Equals(TextCoreSettings other) => default; // 0x000000018BFACC88-0x000000018BFACDA4
		public override int GetHashCode() => default; // 0x000000018BFACDA4-0x000000018BFACE4C
	}

	internal class TextureBlitter : IDisposable // TypeDefIndex: 44886
	{
		// Fields
		private static readonly int[] k_TextureIds; // 0x00
		private static ProfilerMarker s_CommitSampler; // 0x08
		private BlitInfo[] m_SingleBlit; // 0x10
		private Material m_BlitMaterial; // 0x18
		private MaterialPropertyBlock m_Properties; // 0x20
		private RectInt m_Viewport; // 0x28
		private RenderTexture m_PrevRT; // 0x38
		private List<BlitInfo> m_PendingBlits; // 0x40
		private bool _disposed_k__BackingField; // 0x48
	
		// Properties
		protected bool disposed { get; private set; } // 0x0000000185FB0750-0x0000000185FB0760 0x0000000185FB0770-0x0000000185FB0780
	
		// Nested types
		private struct BlitInfo // TypeDefIndex: 44885
		{
			// Fields
			public Texture src; // 0x00
			public RectInt srcRect; // 0x08
			public Vector2Int dstPos; // 0x18
			public int border; // 0x20
			public UnityEngine.Color tint; // 0x24
		}
	
		// Constructors
		public TextureBlitter() {} // Dummy constructor
		static TextureBlitter() {} // 0x000000018BFAD904-0x000000018BFADA24
		public TextureBlitter(int capacity = 512 /* Metadata: 0x0205B7A1 */) {} // 0x000000018BFADA24-0x000000018BFADAD4
	
		// Methods
		public void Dispose() {} // 0x000000018BFAD204-0x000000018BFAD254
		protected virtual void Dispose(bool disposing) {} // 0x000000018BFAD254-0x000000018BFAD2C0
		public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, UnityEngine.Color tint) {} // 0x000000018BFAD804-0x000000018BFAD904
		public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, UnityEngine.Color tint) {} // 0x000000018BFAD054-0x000000018BFAD148
		public void Commit(RenderTexture dst) {} // 0x000000018BFAD148-0x000000018BFAD204
		private void BeginBlit(RenderTexture dst) {} // 0x000000018BFACE4C-0x000000018BFAD054
		private void DoBlit(IList<BlitInfo> blitInfos, int startIndex) {} // 0x000000018BFAD2C0-0x000000018BFAD768
		private void EndBlit() {} // 0x000000018BFAD768-0x000000018BFAD804
	}

	internal class TextureSlotManager // TypeDefIndex: 44887
	{
		// Fields
		private static readonly int k_SlotCount; // 0x00
		internal static readonly int[] slotIds; // 0x08
		internal static readonly int textureTableId; // 0x10
		private TextureId[] m_Textures; // 0x10
		private int[] m_Tickets; // 0x18
		private int m_CurrentTicket; // 0x20
		private int m_FirstUsedTicket; // 0x24
		private Vector4[] m_GpuTextures; // 0x28
		private int _FreeSlots_k__BackingField; // 0x30
		internal TextureRegistry textureRegistry; // 0x38
	
		// Properties
		public int FreeSlots { get; private set; } // 0x00000001813CFF60-0x00000001813CFF70 0x00000001813D0A90-0x00000001813D0AA0
	
		// Constructors
		static TextureSlotManager() {} // 0x000000018BFADF6C-0x000000018BFAE0D4
		public TextureSlotManager() {} // 0x000000018BFAE0D4-0x000000018BFAE1F0
	
		// Methods
		public void Reset() {} // 0x000000018BFADE18-0x000000018BFADF14
		public void StartNewBatch() {} // 0x000000018BFADF14-0x000000018BFADF6C
		public int IndexOf(TextureId id) => default; // 0x000000018BFADD68-0x000000018BFADE18
		public void MarkUsed(int slotIndex) {} // 0x000000018BFA0CE4-0x000000018BFA0D3C
		public int FindOldestSlot() => default; // 0x000000018BFADCB4-0x000000018BFADD68
		public void Bind(TextureId id, int slot, MaterialPropertyBlock mat) {} // 0x000000018BFADAD4-0x000000018BFADCB4
	}

	internal class VectorImageRenderInfoPool : LinkedPool<VectorImageRenderInfo> // TypeDefIndex: 44889
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44888
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<VectorImageRenderInfo> __9__0_0; // 0x08
			public static Action<VectorImageRenderInfo> __9__0_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BFB0F14-0x000000018BFB10D8
			public __c() {} // 0x000000018BFAE404-0x000000018BFAE468
	
			// Methods
			internal VectorImageRenderInfo _.ctor_b__0_0() => default; // 0x0000000185492010-0x0000000185492020
			internal void _.ctor_b__0_1(VectorImageRenderInfo vectorImageInfo) {} // 0x000000018BFAE25C-0x000000018BFAE2AC
		}
	
		// Constructors
		public VectorImageRenderInfoPool() {} // 0x000000018BFAE2AC-0x000000018BFAE2CC
	}

	internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo> // TypeDefIndex: 44890
	{
		// Fields
		public int useCount; // 0x18
		public GradientRemap firstGradientRemap; // 0x20
		public Alloc gradientSettingsAlloc; // 0x28
	
		// Constructors
		public VectorImageRenderInfo() {} // 0x000000018BFB1104-0x000000018BFB13A4
	
		// Methods
		public void Reset() {} // 0x000000018BFB10D8-0x000000018BFB1104
	}

	internal class GradientRemapPool : LinkedPool<GradientRemap> // TypeDefIndex: 44892
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 44891
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<GradientRemap> __9__0_0; // 0x08
			public static Action<GradientRemap> __9__0_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BFA1B30-0x000000018BFA1CF4
			public __c() {} // 0x000000018BFAE4CC-0x000000018BFAE530
	
			// Methods
			internal GradientRemap _.ctor_b__0_0() => default; // 0x0000000185492010-0x0000000185492020
			internal void _.ctor_b__0_1(GradientRemap gradientRemap) {} // 0x000000018BFAE20C-0x000000018BFAE25C
		}
	
		// Constructors
		public GradientRemapPool() {} // 0x000000018BFAE2CC-0x000000018BFAE2EC
	}

	internal class GradientRemap : LinkedPoolItem<GradientRemap> // TypeDefIndex: 44893
	{
		// Fields
		public int origIndex; // 0x18
		public int destIndex; // 0x1C
		public RectInt location; // 0x20
		public GradientRemap next; // 0x30
		public TextureId atlas; // 0x38
	
		// Constructors
		public GradientRemap() {} // 0x000000018BFA1D50-0x000000018BFA1D78
	
		// Methods
		public void Reset() {} // 0x000000018BFA1CF4-0x000000018BFA1D50
	}

	internal class VectorImageManager : IDisposable // TypeDefIndex: 44894
	{
		// Fields
		public static List<VectorImageManager> instances; // 0x00
		private static ProfilerMarker s_MarkerRegister; // 0x08
		private static ProfilerMarker s_MarkerUnregister; // 0x10
		private readonly AtlasBase m_Atlas; // 0x10
		private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered; // 0x18
		private VectorImageRenderInfoPool m_RenderInfoPool; // 0x20
		private GradientRemapPool m_GradientRemapPool; // 0x28
		private GradientSettingsAtlas m_GradientSettingsAtlas; // 0x30
		private bool m_LoggedExhaustedSettingsAtlas; // 0x38
		private bool _disposed_k__BackingField; // 0x39
	
		// Properties
		public Texture2D atlas { get => default; } // 0x000000018BFB0F00-0x000000018BFB0F14 
		protected bool disposed { get; private set; } // 0x0000000185FB0710-0x0000000185FB0720 0x0000000185FB0720-0x0000000185FB0730
	
		// Constructors
		public VectorImageManager() {} // Dummy constructor
		public VectorImageManager(AtlasBase atlas) {} // 0x000000018BFB0D78-0x000000018BFB0F00
		static VectorImageManager() {} // 0x000000018BFB0C70-0x000000018BFB0D78
	
		// Methods
		public void Dispose() {} // 0x000000018BFB084C-0x000000018BFB089C
		protected virtual void Dispose(bool disposing) {} // 0x000000018BFB0744-0x000000018BFB084C
		public void Commit() {} // 0x000000018BFB0710-0x000000018BFB0744
		public GradientRemap AddUser(VectorImage vi, VisualElement context) => default; // 0x000000018BFB0624-0x000000018BFB0710
		private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) => default; // 0x000000018BFB089C-0x000000018BFB0C70
	}

	internal enum OwnedState : byte // TypeDefIndex: 44895
	{
		Inherited = 0,
		Owned = 1
	}

	internal struct BMPAlloc // TypeDefIndex: 44896
	{
		// Fields
		public static readonly BMPAlloc Invalid; // 0x00
		public int page; // 0x00
		public ushort pageLine; // 0x04
		public byte bitIndex; // 0x06
		public OwnedState ownedState; // 0x07
	
		// Constructors
		static BMPAlloc() {
			Invalid = default;
		} // 0x000000018BFA0E64-0x000000018BFA0EB0
	
		// Methods
		public bool Equals(BMPAlloc other) => default; // 0x000000018BFA0D6C-0x000000018BFA0D8C
		public bool IsValid() => default; // 0x000000018BFA0D8C-0x000000018BFA0D98
		public override string ToString() => default; // 0x000000018BFA0D98-0x000000018BFA0E64
	}

	internal struct BitmapAllocator32 // TypeDefIndex: 44898
	{
		// Fields
		private int m_PageHeight; // 0x00
		private List<Page> m_Pages; // 0x08
		private List<uint> m_AllocMap; // 0x10
		private int m_EntryWidth; // 0x18
		private int m_EntryHeight; // 0x1C
	
		// Properties
		public int entryWidth { get => default; } // 0x0000000185FC9940-0x0000000185FC9950 
		public int entryHeight { get => default; } // 0x0000000185FC79A0-0x0000000185FC79B0 
	
		// Nested types
		private struct Page // TypeDefIndex: 44897
		{
			// Fields
			public ushort x; // 0x00
			public ushort y; // 0x02
			public int freeSlots; // 0x04
		}
	
		// Methods
		public void Construct(int pageHeight, int entryWidth = 1 /* Metadata: 0x0205B7A5 */, int entryHeight = 1 /* Metadata: 0x0205B7A6 */) {} // 0x000000018BFA12CC-0x000000018BFA13EC
		public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) {} // 0x000000018BFA1428-0x000000018BFA14F8
		public BMPAlloc Allocate(BaseShaderInfoStorage storage) => default; // 0x000000018BFA0FD4-0x000000018BFA12CC
		public void Free(BMPAlloc alloc) {} // 0x000000018BFA14F8-0x000000018BFA1628
		internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) {
			x = default;
			y = default;
		} // 0x000000018BFA1628-0x000000018BFA16A0
		private static byte CountTrailingZeroes(uint val) => default; // 0x000000018BFA13EC-0x000000018BFA1428
	}

	internal struct UIRVEShaderInfoAllocator // TypeDefIndex: 44899
	{
		// Fields
		private BaseShaderInfoStorage m_Storage; // 0x00
		private BitmapAllocator32 m_TransformAllocator; // 0x08
		private BitmapAllocator32 m_ClipRectAllocator; // 0x28
		private BitmapAllocator32 m_OpacityAllocator; // 0x48
		private BitmapAllocator32 m_ColorAllocator; // 0x68
		private BitmapAllocator32 m_TextSettingsAllocator; // 0x88
		private bool m_StorageReallyCreated; // 0xA8
		private bool m_VertexTexturingEnabled; // 0xA9
		private NativeArray<Transform3x4> m_Transforms; // 0xB0
		private NativeArray<Vector4> m_ClipRects; // 0xC0
		internal static readonly Vector2Int identityTransformTexel; // 0x00
		internal static readonly Vector2Int infiniteClipRectTexel; // 0x08
		internal static readonly Vector2Int fullOpacityTexel; // 0x10
		internal static readonly Vector2Int clearColorTexel; // 0x18
		internal static readonly Vector2Int defaultTextCoreSettingsTexel; // 0x20
		internal static readonly Matrix4x4 identityTransformValue; // 0x28
		internal static readonly Vector4 identityTransformRow0Value; // 0x68
		internal static readonly Vector4 identityTransformRow1Value; // 0x78
		internal static readonly Vector4 identityTransformRow2Value; // 0x88
		internal static readonly Vector4 infiniteClipRectValue; // 0x98
		internal static readonly Vector4 fullOpacityValue; // 0xA8
		internal static readonly Vector4 clearColorValue; // 0xB8
		internal static readonly TextCoreSettings defaultTextCoreSettingsValue; // 0xC8
		public static readonly BMPAlloc identityTransform; // 0x108
		public static readonly BMPAlloc infiniteClipRect; // 0x110
		public static readonly BMPAlloc fullOpacity; // 0x118
		public static readonly BMPAlloc clearColor; // 0x120
		public static readonly BMPAlloc defaultTextCoreSettings; // 0x128
	
		// Properties
		private static int pageWidth { get => default; } // 0x0000000185FE99B0-0x0000000185FE99C0 
		private static int pageHeight { get => default; } // 0x0000000185FE99A0-0x0000000185FE99B0 
		public NativeSlice<Transform3x4> transformConstants { get => default; } // 0x000000018BFB05B8-0x000000018BFB0624 
		public NativeSlice<Vector4> clipRectConstants { get => default; } // 0x000000018BFB054C-0x000000018BFB05B8 
		public Texture atlas { get => default; } // 0x000000018BFB04CC-0x000000018BFB054C 
	
		// Constructors
		static UIRVEShaderInfoAllocator() {
			identityTransformTexel = default;
			infiniteClipRectTexel = default;
			fullOpacityTexel = default;
			clearColorTexel = default;
			defaultTextCoreSettingsTexel = default;
			identityTransformValue = default;
			identityTransformRow0Value = default;
			identityTransformRow1Value = default;
			identityTransformRow2Value = default;
			infiniteClipRectValue = default;
			fullOpacityValue = default;
			clearColorValue = default;
			defaultTextCoreSettingsValue = default;
			identityTransform = default;
			infiniteClipRect = default;
			fullOpacity = default;
			clearColor = default;
			defaultTextCoreSettings = default;
		} // 0x000000018BFB0258-0x000000018BFB04CC
	
		// Methods
		private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) => default; // 0x000000018BFAE760-0x000000018BFAE7C0
		private static int AllocToConstantBufferIndex(BMPAlloc alloc) => default; // 0x000000018BFAE710-0x000000018BFAE760
		private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) => default; // 0x000000018BFAE894-0x000000018BFAE958
		public void Construct() {} // 0x000000018BFAEB1C-0x000000018BFAEE1C
		private void ReallyCreateStorage() {} // 0x000000018BFAF248-0x000000018BFAF86C
		public void Dispose() {} // 0x000000018BFAEE1C-0x000000018BFAEEC8
		public void IssuePendingStorageChanges() {} // 0x000000018BFAF160-0x000000018BFAF174
		public BMPAlloc AllocTransform() => default; // 0x000000018BFAE7C0-0x000000018BFAE894
		public BMPAlloc AllocClipRect() => default; // 0x000000018BFAE530-0x000000018BFAE604
		public BMPAlloc AllocOpacity() => default; // 0x000000018BFAE65C-0x000000018BFAE6B4
		public BMPAlloc AllocColor() => default; // 0x000000018BFAE604-0x000000018BFAE65C
		public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) => default; // 0x000000018BFAE6B4-0x000000018BFAE710
		public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) {} // 0x000000018BFAFE3C-0x000000018BFB0090
		public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) {} // 0x000000018BFAF86C-0x000000018BFAF994
		public void SetOpacityValue(BMPAlloc alloc, float opacity) {} // 0x000000018BFAFAA4-0x000000018BFAFBA0
		public void SetColorValue(BMPAlloc alloc, UnityEngine.Color color, bool isEditorContext) {} // 0x000000018BFAF994-0x000000018BFAFAA4
		public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) {} // 0x000000018BFAFBA0-0x000000018BFAFE3C
		public void FreeTransform(BMPAlloc alloc) {} // 0x000000018BFAF0DC-0x000000018BFAF160
		public void FreeClipRect(BMPAlloc alloc) {} // 0x000000018BFAEEC8-0x000000018BFAEF4C
		public void FreeOpacity(BMPAlloc alloc) {} // 0x000000018BFAEFD0-0x000000018BFAF054
		public void FreeColor(BMPAlloc alloc) {} // 0x000000018BFAEF4C-0x000000018BFAEFD0
		public void FreeTextCoreSettings(BMPAlloc alloc) {} // 0x000000018BFAF054-0x000000018BFAF0DC
		public Color32 TransformAllocToVertexData(BMPAlloc alloc) => default; // 0x000000018BFB0168-0x000000018BFB0258
		public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) => default; // 0x000000018BFAE958-0x000000018BFAEA48
		public Color32 OpacityAllocToVertexData(BMPAlloc alloc) => default; // 0x000000018BFAF174-0x000000018BFAF248
		public Color32 ColorAllocToVertexData(BMPAlloc alloc) => default; // 0x000000018BFAEA48-0x000000018BFAEB1C
		public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) => default; // 0x000000018BFB0090-0x000000018BFB0168
	}

	internal struct Transform3x4 // TypeDefIndex: 44900
	{
		// Fields
		public Vector4 v0; // 0x00
		public Vector4 v1; // 0x10
		public Vector4 v2; // 0x20
	}

	internal class MeshHandle : LinkedPoolItem<MeshHandle> // TypeDefIndex: 44901
	{
		// Fields
		internal Alloc allocVerts; // 0x18
		internal Alloc allocIndices; // 0x30
		internal uint triangleCount; // 0x48
		internal UnityEngine.UIElements.UIR.Page allocPage; // 0x50
		internal uint allocTime; // 0x58
		internal uint updateAllocID; // 0x5C
	
		// Constructors
		public MeshHandle() {} // 0x000000018BFB60A0-0x000000018BFB60C8
	}

	internal class UIRenderDevice : IDisposable // TypeDefIndex: 44908
	{
		// Fields
		private readonly bool m_MockDevice; // 0x10
		private IntPtr m_DefaultStencilState; // 0x18
		private IntPtr m_VertexDecl; // 0x20
		private UnityEngine.UIElements.UIR.Page m_FirstPage; // 0x28
		private uint m_NextPageVertexCount; // 0x30
		private uint m_LargeMeshVertexCount; // 0x34
		private float m_IndexToVertexCountRatio; // 0x38
		private List<List<AllocToFree>> m_DeferredFrees; // 0x40
		private List<List<AllocToUpdate>> m_Updates; // 0x48
		private uint[] m_Fences; // 0x50
		private MaterialPropertyBlock m_StandardMatProps; // 0x58
		private uint m_FrameIndex; // 0x60
		private uint m_NextUpdateID; // 0x64
		private DrawStatistics m_DrawStats; // 0x68
		private readonly LinkedPool<MeshHandle> m_MeshHandles; // 0x90
		private readonly DrawParams m_DrawParams; // 0x98
		private readonly TextureSlotManager m_TextureSlotManager; // 0xA0
		private static LinkedList<DeviceToFree> m_DeviceFreeQueue; // 0x00
		private static int m_ActiveDeviceCount; // 0x08
		private static bool m_SubscribedToNotifications; // 0x0C
		private static bool m_SynchronousFree; // 0x0D
		private static readonly int s_FontTexPropID; // 0x10
		private static readonly int s_FontTexSDFScaleID; // 0x14
		private static readonly int s_GradientSettingsTexID; // 0x18
		private static readonly int s_ShaderInfoTexID; // 0x1C
		private static readonly int s_TransformsPropID; // 0x20
		private static readonly int s_ClipRectsPropID; // 0x24
		private static readonly int s_ClipSpaceParamsID; // 0x28
		private static ProfilerMarker s_MarkerAllocate; // 0x30
		private static ProfilerMarker s_MarkerFree; // 0x38
		private static ProfilerMarker s_MarkerAdvanceFrame; // 0x40
		private static ProfilerMarker s_MarkerFence; // 0x48
		private static ProfilerMarker s_MarkerBeforeDraw; // 0x50
		private static bool? s_VertexTexturingIsAvailable; // 0x58
		private static bool? s_ShaderModelIs35; // 0x5A
		private readonly uint _maxVerticesPerPage_k__BackingField; // 0xA8
		private bool _breakBatches_k__BackingField; // 0xAC
		private static Texture2D s_DefaultShaderInfoTexFloat; // 0x60
		private static Texture2D s_DefaultShaderInfoTexARGB8; // 0x68
		private bool _disposed_k__BackingField; // 0xAD
	
		// Properties
		internal uint maxVerticesPerPage { get; } // 0x000000018BFBECB4-0x000000018BFBF21C 
		internal bool breakBatches { get; set; } // 0x000000018BFBF5F4-0x000000018BFBFB68 0x000000018BFBF238-0x000000018BFBF5F4
		internal static Texture2D defaultShaderInfoTexFloat { get => default; } // 0x000000018BFBBB70-0x000000018BFBBC8C 
		internal static Texture2D defaultShaderInfoTexARGB8 { get => default; } // 0x000000018482D5A0-0x000000018482D5B0 
		internal static bool vertexTexturingIsAvailable { get => default; } // 0x0000000185FB7DB0-0x0000000185FB7DC0 
		internal static bool shaderModelIs35 { get => default; } // 0x0000000185FE99F0-0x0000000185FE9A00 
		private bool fullyCreated { get => default; } // 0x000000018BFBB098-0x000000018BFBB160 
		protected bool disposed { get; private set; } // 0x000000018BFBE4A8-0x000000018BFBE6A4 0x000000018BFBE6A4-0x000000018BFBE884
	
		// Nested types
		internal struct AllocToUpdate // TypeDefIndex: 44902
		{
			// Fields
			public uint id; // 0x00
			public uint allocTime; // 0x04
			public MeshHandle meshHandle; // 0x08
			public Alloc permAllocVerts; // 0x10
			public Alloc permAllocIndices; // 0x28
			public UnityEngine.UIElements.UIR.Page permPage; // 0x40
			public bool copyBackIndices; // 0x48
		}
	
		private struct AllocToFree // TypeDefIndex: 44903
		{
			// Fields
			public Alloc alloc; // 0x00
			public UnityEngine.UIElements.UIR.Page page; // 0x18
			public bool vertices; // 0x20
		}
	
		private struct DeviceToFree // TypeDefIndex: 44904
		{
			// Fields
			public uint handle; // 0x00
			public UnityEngine.UIElements.UIR.Page page; // 0x08
	
			// Methods
			public void Dispose() {} // 0x0000000185FB2CD0-0x0000000185FB2CE0
		}
	
		private struct EvaluationState // TypeDefIndex: 44905
		{
			// Fields
			public MaterialPropertyBlock stateMatProps; // 0x00
			public Material defaultMat; // 0x08
			public UnityEngine.UIElements.UIR.State curState; // 0x10
			public UnityEngine.UIElements.UIR.Page curPage; // 0x30
			public bool mustApplyMaterial; // 0x38
			public bool mustApplyCommonBlock; // 0x39
			public bool mustApplyStateBlock; // 0x3A
			public bool mustApplyStencil; // 0x3B
		}
	
		internal struct DrawStatistics // TypeDefIndex: 44906
		{
			// Fields
			public int currentFrameIndex; // 0x00
			public uint totalIndices; // 0x04
			public uint commandCount; // 0x08
			public uint drawCommandCount; // 0x0C
			public uint materialSetCount; // 0x10
			public uint drawRangeCount; // 0x14
			public uint drawRangeCallCount; // 0x18
			public uint immediateDraws; // 0x1C
			public uint stencilRefChanges; // 0x20
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 44907
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MeshHandle> __9__53_0; // 0x08
			public static Action<MeshHandle> __9__53_1; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000185FBCA90-0x0000000185FBCAA0
			public __c() {} // 0x0000000185FBCAC0-0x0000000185FBCAD0
	
			// Methods
			internal MeshHandle _.ctor_b__53_0() => default; // 0x000000018BFBE934-0x000000018BFBECB4
			internal void _.ctor_b__53_1(MeshHandle mh) {} // 0x000000018BFBF21C-0x000000018BFBF238
		}
	
		// Constructors
		public UIRenderDevice() {} // Dummy constructor
		static UIRenderDevice() {} // 0x000000018BFBFD04-0x000000018BFC00E8
		public UIRenderDevice(uint initialVertexCapacity = 0 /* Metadata: 0x0205B7A7 */, uint initialIndexCapacity = 0 /* Metadata: 0x0205B7A8 */) {} // 0x000000018BFBFB68-0x000000018BFBFD04
		protected UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice) {} // 0x000000018BFBD064-0x000000018BFBD1F8
	
		// Methods
		private void InitVertexDeclaration() {} // 0x000000018BFBBDD8-0x000000018BFBBE28
		private void CompleteCreation() {} // 0x000000018BFBBC8C-0x000000018BFBBDD8
		public void Dispose() {} // 0x000000018BFBE304-0x000000018BFBE3F8
		protected virtual void Dispose(bool disposing) {} // 0x000000018BFBA4A8-0x000000018BFBA518
		public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) {
			vertexData = default;
			indexData = default;
			indexOffset = default;
			return default;
		} // 0x000000018BFBDB70-0x000000018BFBDCA4
		public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData) {
			vertexData = default;
		} // 0x000000018BFBB160-0x000000018BFBB864
		public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) {
			vertexData = default;
			indexData = default;
			indexOffset = default;
		} // 0x000000018BFBDCA4-0x000000018BFBE304
		private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) {} // 0x000000018BFBC9A4-0x000000018BFBCFA8
		internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) => default; // 0x000000018BFBCFA8-0x000000018BFBD064
		private bool TryAllocFromPage(UnityEngine.UIElements.UIR.Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) => default; // 0x000000018BFBD4E0-0x000000018BFBD57C
		private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived) {
			vertexData = default;
			indexData = default;
		}
		private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices) {
			vertexData = default;
			indexData = default;
			indexOffset = default;
			allocToUpdate = default;
		} // 0x000000018BFBB9AC-0x000000018BFBBB70
		public void Free(MeshHandle mesh) {} // 0x000000018BFBB864-0x000000018BFBB9AC
		private static Vector4 GetClipSpaceParams() => default; // 0x000000018BFBBE28-0x000000018BFBC94C
		public void OnFrameRenderingBegin() {} // 0x000000018BFBE3F8-0x000000018BFBE4A8
		private static unsafe NativeSlice<T> PtrToSlice<T>(void* p, int count)
			where T : struct => default; // 0x000000018BFBD1F8-0x000000018BFBD448
		private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, bool newFontDiffers, ref EvaluationState st) {}
		private void ApplyBatchState(ref EvaluationState st, bool allowMaterialChange) {} // 0x000000018BFBE884-0x000000018BFBE8E0
		public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException) {} // 0x000000018BFBA518-0x000000018BFBB098
		private void UpdateFenceValue() {} // 0x000000018BFBDA7C-0x000000018BFBDB70
		private unsafe void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, UnityEngine.UIElements.UIR.Page curPage) {} // 0x000000018BFBD57C-0x000000018BFBD704
		private void DrawRanges<I, T>(Utility.GPUBuffer<I> ib, Utility.GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges)
			where I : struct
			where T : struct {} // 0x000000018BFBE8E0-0x000000018BFBE934
		private void WaitOnCpuFence(uint fence) {} // 0x000000018BFBC94C-0x000000018BFBC9A4
		public void AdvanceFrame() {} // 0x0000000185FE99D0-0x0000000185FE99F0
		private void PruneUnusedPages() {} // 0x000000018BFBD704-0x000000018BFBDA7C
		internal static void PrepareForGfxDeviceRecreate() {} // 0x000000018BFBD448-0x000000018BFBD488
		internal static void WrapUpGfxDeviceRecreate() {} // 0x000000018BFBD488-0x000000018BFBD4E0
		internal static void FlushAllPendingDeviceDisposes() {} // 0x000000018BFB5AB0-0x000000018BFB5AE4
		internal DrawStatistics GatherDrawStatistics() => default; // 0x000000018BFBA444-0x000000018BFBA4A8
		private static void ProcessDeviceFreeQueue() {} // 0x0000000185492010-0x0000000185492020
		private static void OnEngineUpdateGlobal() {} // 0x000000018BFBA3F4-0x000000018BFBA444
		private static void OnFlushPendingResources() {} // 0x0000000185492010-0x0000000185492020
	}

	internal struct Alloc // TypeDefIndex: 44909
	{
		// Fields
		public uint start; // 0x00
		public uint size; // 0x04
		internal object handle; // 0x08
		internal bool shortLived; // 0x10
	}

	internal class BestFitAllocator // TypeDefIndex: 44912
	{
		// Fields
		private readonly uint _totalSize_k__BackingField; // 0x10
		private Block m_FirstBlock; // 0x18
		private Block m_FirstAvailableBlock; // 0x20
		private BlockPool m_BlockPool; // 0x28
		private uint m_HighWatermark; // 0x30
	
		// Properties
		public uint totalSize { get; } // 0x000000018BFB1568-0x000000018BFB15A4 
		public uint highWatermark { get => default; } // 0x000000018BFB18D4-0x000000018BFB1A2C 
	
		// Nested types
		private class BlockPool : LinkedPool<Block> // TypeDefIndex: 44910
		{
			// Constructors
			public BlockPool() {} // 0x0000000185FE6710-0x0000000185FE6720
	
			// Methods
			private static Block CreateBlock() => default; // 0x000000018BFB1A2C-0x000000018BFB1AEC
			private static void ResetBlock(Block block) {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
		}
	
		private class Block : LinkedPoolItem<Block> // TypeDefIndex: 44911
		{
			// Fields
			public uint start; // 0x18
			public uint end; // 0x1C
			public Block prev; // 0x20
			public Block next; // 0x28
			public Block prevAvailable; // 0x30
			public Block nextAvailable; // 0x38
			public bool allocated; // 0x40
	
			// Properties
			public uint size { get => default; } // 0x000000018BFB13A4-0x000000018BFB1568 
	
			// Constructors
			public Block() {} // 0x000000018BFB16D4-0x000000018BFB18D4
		}
	
		// Constructors
		public BestFitAllocator() {} // Dummy constructor
		public BestFitAllocator(uint size) {} // 0x000000018BFB15A4-0x000000018BFB16D4
	
		// Methods
		public Alloc Allocate(uint size) => default; // 0x000000018BFB1AEC-0x000000018BFB1B3C
		public void Free(Alloc alloc) {} // 0x0000000185492010-0x0000000185492020
		private Block CoalesceBlockWithPrevious(Block block) => default; // 0x000000018BFB1B3C-0x000000018BFB1C20
		private Block BestFitFindAvailableBlock(uint size) => default; // 0x0000000185FE99C0-0x0000000185FE99D0
		private void SplitBlock(Block block, uint size) {} // 0x000000018BFB1C20-0x000000018BFB1C48
	}

	internal class GPUBufferAllocator // TypeDefIndex: 44913
	{
		// Fields
		private BestFitAllocator m_Low; // 0x10
		private BestFitAllocator m_High; // 0x18
	
		// Properties
		public bool isEmpty { get => default; } // 0x000000018BFB6070-0x000000018BFB60A0 
	
		// Constructors
		public GPUBufferAllocator() {} // Dummy constructor
		public GPUBufferAllocator(uint maxSize) {} // 0x000000018BFB5FCC-0x000000018BFB6070
	
		// Methods
		public Alloc Allocate(uint size, bool shortLived) => default; // 0x000000018BFB5E00-0x000000018BFB5F1C
		public void Free(Alloc alloc) {} // 0x000000018BFB5F1C-0x000000018BFB5F98
		private bool HighLowCollide() => default; // 0x000000018BFB5F98-0x000000018BFB5FCC
	}

	internal class Page : IDisposable // TypeDefIndex: 44915
	{
		// Fields
		private bool _disposed_k__BackingField; // 0x10
		public DataSet<UnityEngine.UIElements.Vertex> vertices; // 0x18
		public DataSet<ushort> indices; // 0x20
		public Page next; // 0x28
		public int framesEmpty; // 0x30
	
		// Properties
		protected bool disposed { get; private set; }
		public bool isEmpty { get => default; }
	
		// Nested types
		public class DataSet<T> : IDisposable // TypeDefIndex: 44914
			where T : struct
		{
			// Fields
			private bool _disposed_k__BackingField;
			public Utility.GPUBuffer<T> gpuData;
			public NativeArray<T> cpuData;
			public NativeArray<GfxUpdateBufferRange> updateRanges;
			public GPUBufferAllocator allocator;
			private readonly uint m_UpdateRangePoolSize;
			private uint m_ElemStride;
			private uint m_UpdateRangeMin;
			private uint m_UpdateRangeMax;
			private uint m_UpdateRangesEnqueued;
			private uint m_UpdateRangesBatchStart;
			private bool m_UpdateRangesSaturated;
	
			// Properties
			protected bool disposed { get; private set; }
	
			// Constructors
			public DataSet() {} // Dummy constructor
			public DataSet(Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer) {} // 0x000000018BFB619C-0x000000018BFB62E4
	
			// Methods
			public void Dispose() {} // 0x000000018BFB614C-0x000000018BFB619C
			public void Dispose(bool disposing) {}
			public void RegisterUpdate(uint start, uint size) {} // 0x000000018BFB62E4-0x000000018BFB6340
			private bool HasMappedBufferRange() => default;
			public void SendUpdates() {}
			public void SendFullRange() {}
			public void SendPartialRanges() {}
			private void ResetUpdateState() {}
		}
	
		// Constructors
		public Page() {} // Dummy constructor
		public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage) {}
	
		// Methods
		public void Dispose() {}
		protected virtual void Dispose(bool disposing) {}
	}

	internal enum VertexFlags // TypeDefIndex: 44916
	{
		IsSolid = 0,
		IsText = 1,
		IsTextured = 2,
		IsDynamic = 3,
		IsSvgGradients = 4,
		LastType = 10,
		IsGraphViewEdge = 10
	}

	internal struct State // TypeDefIndex: 44917
	{
		// Fields
		public Material material; // 0x00
		public Texture font; // 0x08
		public float fontTexSDFScale; // 0x10
		public TextureId texture; // 0x14
		public int stencilRef; // 0x18
	}

	internal enum CommandType // TypeDefIndex: 44918
	{
		Draw = 0,
		ImmediateCull = 1,
		Immediate = 2,
		PushView = 3,
		PopView = 4,
		PushScissor = 5,
		PopScissor = 6,
		PushRenderTexture = 7,
		PopRenderTexture = 8,
		BlitToPreviousRT = 9,
		PushDefaultMaterial = 10,
		PopDefaultMaterial = 11
	}

	internal class DrawParams // TypeDefIndex: 44919
	{
		// Fields
		internal static readonly Rect k_UnlimitedRect; // 0x00
		internal static readonly Rect k_FullNormalizedRect; // 0x10
		internal readonly Stack<Matrix4x4> view; // 0x10
		internal readonly Stack<Rect> scissor; // 0x18
		internal readonly List<RenderTexture> renderTexture; // 0x20
		internal readonly List<Material> defaultMaterial; // 0x28
	
		// Constructors
		public DrawParams() {} // 0x000000018BFB5C94-0x000000018BFB5E00
		static DrawParams() {} // 0x000000018BFB5C3C-0x000000018BFB5C94
	
		// Methods
		public void Reset() {} // 0x000000018BFB5AE4-0x000000018BFB5C3C
	}

	internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand> // TypeDefIndex: 44920
	{
		// Fields
		internal VisualElement owner; // 0x18
		internal RenderChainCommand prev; // 0x20
		internal RenderChainCommand next; // 0x28
		internal bool closing; // 0x30
		internal UnityEngine.UIElements.UIR.CommandType type; // 0x34
		internal UnityEngine.UIElements.UIR.State state; // 0x38
		internal MeshHandle mesh; // 0x58
		internal int indexOffset; // 0x60
		internal int indexCount; // 0x64
		internal Action callback; // 0x68
		private static readonly int k_ID_MainTex; // 0x00
		private static ProfilerMarker s_ImmediateOverheadMarker; // 0x08
	
		// Constructors
		public RenderChainCommand() {} // 0x000000018BFB740C-0x000000018BFB7434
		static RenderChainCommand() {} // 0x000000018BFB7380-0x000000018BFB740C
	
		// Methods
		internal void Reset() {} // 0x000000018BFB7318-0x000000018BFB7380
		internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) {} // 0x000000018BFB65C0-0x000000018BFB7240
		private void Blit(Texture source, RenderTexture destination, float depth) {} // 0x000000018BFB6340-0x000000018BFB64B0
		private static Rect CombineScissorRects(Rect r0, Rect r1) => default; // 0x000000018BFB64B0-0x000000018BFB65C0
		private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) => default; // 0x000000018BFB7240-0x000000018BFB7318
	}
}

namespace UnityEngine.UIElements.UIR.Implementation
{
	internal static class CommandGenerator // TypeDefIndex: 44921
	{
		// Fields
		private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; // 0x00
		private static readonly ProfilerMarker k_NudgeVerticesMarker; // 0x08
		private static readonly ProfilerMarker k_ComputeTransformMatrixMarker; // 0x10
		private static Material s_blitMaterial_LinearToGamma; // 0x18
		private static Material s_blitMaterial_GammaToLinear; // 0x20
		private static Material s_blitMaterial_NoChange; // 0x28
		private static Shader s_blitShader; // 0x30
	
		// Constructors
		static CommandGenerator() {} // 0x000000018BFB59DC-0x000000018BFB5AB0
	
		// Methods
		private static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform) {
			transform = default;
		} // 0x000000018BFB30A8-0x000000018BFB31FC
		internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result) {
			result = default;
		} // 0x000000018BFB1DE4-0x000000018BFB1F14
		private static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) => default; // 0x000000018BFB3708-0x000000018BFB3798
		public static UIRStylePainter.ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats) => default; // 0x000000018BFB3B58-0x000000018BFB5564
		private static Material CreateBlitShader(float colorConversion) => default; // 0x000000018BFB2514-0x000000018BFB26E0
		private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode) => default; // 0x000000018BFB2E04-0x000000018BFB30A8
		public static void ClosePaintElement(VisualElement ve, UIRStylePainter.ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats) {} // 0x000000018BFB1C48-0x000000018BFB1DE4
		private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<UnityEngine.UIElements.Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats) {
			verts = default;
			indices = default;
			indexOffset = default;
		} // 0x000000018BFB58D0-0x000000018BFB59DC
		private static void CopyTransformVertsPos(NativeSlice<UnityEngine.UIElements.Vertex> source, NativeSlice<UnityEngine.UIElements.Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 ids, Color32 addFlags, Color32 opacityPage, Color32 textCoreSettingsPage, bool isText, float textureId) {} // 0x000000018BFB2168-0x000000018BFB2320
		private static void CopyTransformVertsPosAndVec(NativeSlice<UnityEngine.UIElements.Vertex> source, NativeSlice<UnityEngine.UIElements.Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 ids, Color32 addFlags, Color32 opacityPage, Color32 textCoreSettingsPage, bool isText, float textureId) {} // 0x000000018BFB1F14-0x000000018BFB2168
		private static void CopyTriangleIndicesFlipWindingOrder(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset) {} // 0x000000018BFB2320-0x000000018BFB247C
		private static void CopyTriangleIndices(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset) {} // 0x000000018BFB247C-0x000000018BFB2514
		public static bool NudgeVerticesToNewSpace(VisualElement ve, UIRenderDevice device) => default; // 0x000000018BFB3798-0x000000018BFB3B58
		private static void DoNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, ref Matrix4x4 nudgeTransform) {} // 0x000000018BFB26E0-0x000000018BFB2A98
		private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font, int stencilRef) => default; // 0x000000018BFB35B0-0x000000018BFB3708
		private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font, int stencilRef) => default; // 0x000000018BFB3344-0x000000018BFB34A0
		private static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) {
			prev = default;
			next = default;
		} // 0x000000018BFB2C18-0x000000018BFB2E04
		private static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) {
			prev = default;
			next = default;
		} // 0x000000018BFB2A98-0x000000018BFB2C18
		private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) {} // 0x000000018BFB34A0-0x000000018BFB35B0
		private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) {} // 0x000000018BFB31FC-0x000000018BFB3344
		public static void ResetCommands(RenderChain renderChain, VisualElement ve) {} // 0x000000018BFB5564-0x000000018BFB58D0
	}

	internal enum ClipMethod // TypeDefIndex: 44922
	{
		Undetermined = 0,
		NotClipped = 1,
		Scissor = 2,
		ShaderDiscard = 3,
		Stencil = 4
	}

	internal static class RenderEvents // TypeDefIndex: 44923
	{
		// Fields
		private static readonly float VisibilityTreshold; // 0x00
	
		// Constructors
		static RenderEvents() {} // 0x000000018BFBA3B8-0x000000018BFBA3F4
	
		// Methods
		internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x000000018BFB978C-0x000000018BFB987C
		internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x000000018BFB98F4-0x000000018BFB99EC
		internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x000000018BFB987C-0x000000018BFB98F4
		internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x000000018BFB99EC-0x000000018BFB9AB4
		internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x000000018BFB9AB4-0x000000018BFB9BA4
		internal static void ProcessRegenText(RenderChain renderChain, VisualElement ve, UIRTextUpdatePainter painter, UIRenderDevice device, ref ChainBuilderStats stats) {} // 0x000000018BFB9BA4-0x000000018BFB9C00
		private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) => default; // 0x000000018BFB9204-0x000000018BFB935C
		private static Vector4 GetClipRectIDClipInfo(VisualElement ve) => default; // 0x000000018BFB8FAC-0x000000018BFB9198
		internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) => default; // 0x000000018BFB7434-0x000000018BFB7A3C
		internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) => default; // 0x000000018BFB7A3C-0x000000018BFB7FF4
		private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats) {} // 0x000000018BFB7FF4-0x000000018BFB84B4
		private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false /* Metadata: 0x0205B7C1 */) {} // 0x000000018BFB84B4-0x000000018BFB882C
		private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x000000018BFB9668-0x000000018BFB978C
		private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats) {} // 0x000000018BFB882C-0x000000018BFB8BD0
		private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats) {} // 0x000000018BFB8BD0-0x000000018BFB8EBC
		private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) => default; // 0x000000018BFB9F98-0x000000018BFBA2B8
		private static bool IsElementHierarchyHidden(VisualElement ve) => default; // 0x000000018BFB9608-0x000000018BFB9628
		private static VisualElement GetLastDeepestChild(VisualElement ve) => default; // 0x000000018BFB9198-0x000000018BFB9204
		private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) => default; // 0x000000018BFB8EBC-0x000000018BFB8FAC
		private static bool UpdateLocalFlipsWinding(VisualElement ve) => default; // 0x000000018BFB9EDC-0x000000018BFB9F98
		private static void UpdateWorldFlipsWinding(VisualElement ve) {} // 0x000000018BFBA2B8-0x000000018BFBA320
		private static void UpdateZeroScaling(VisualElement ve) {} // 0x000000018BFBA320-0x000000018BFBA3B8
		private static bool NeedsTransformID(VisualElement ve) => default; // 0x000000018BFB9644-0x000000018BFB9668
		internal static bool NeedsColorID(VisualElement ve) => default; // 0x000000018BFB9628-0x000000018BFB9644
		private static bool InitColorIDs(RenderChain renderChain, VisualElement ve) => default; // 0x000000018BFB935C-0x000000018BFB9608
		private static void SetColorValues(RenderChain renderChain, VisualElement ve) {} // 0x000000018BFB9C00-0x000000018BFB9EDC
	}

	internal class UIRStylePainter : IStylePainter, IDisposable // TypeDefIndex: 44927
	{
		// Fields
		private RenderChain m_Owner; // 0x10
		private List<Entry> m_Entries; // 0x18
		private AtlasBase m_Atlas; // 0x20
		private VectorImageManager m_VectorImageManager; // 0x28
		private Entry m_CurrentEntry; // 0x30
		private ClosingInfo m_ClosingInfo; // 0x90
		private int m_MaskDepth; // 0xC8
		private int m_StencilRef; // 0xCC
		private BMPAlloc m_ClipRectID; // 0xD0
		private int m_SVGBackgroundEntryIndex; // 0xD8
		private TempDataAlloc<UnityEngine.UIElements.Vertex> m_VertsPool; // 0xE0
		private TempDataAlloc<ushort> m_IndicesPool; // 0x108
		private List<MeshWriteData> m_MeshWriteDataPool; // 0x130
		private int m_NextMeshWriteDataPoolItem; // 0x138
		private MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate; // 0x140
		private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate; // 0x148
		private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawGradientsDelegate; // 0x150
		private readonly MeshGenerationContext _meshGenerationContext_k__BackingField; // 0x158
		private VisualElement _currentElement_k__BackingField; // 0x160
		private int _totalVertices_k__BackingField; // 0x168
		private int _totalIndices_k__BackingField; // 0x16C
		private bool _disposed_k__BackingField; // 0x170
	
		// Properties
		public MeshGenerationContext meshGenerationContext { get; } // 0x0000000185FE9A40-0x0000000185FE9A80 
		public VisualElement currentElement { get; private set; } // 0x0000000185FB1210-0x0000000185FB1220 0x0000000185FB1220-0x0000000185FB1230
		public List<Entry> entries { get => default; } // 0x0000000185FBBE40-0x0000000185FBBE50 
		public ClosingInfo closingInfo { get => default; } // 0x0000000185FBBEB0-0x0000000185FBBEC0 
		public int totalVertices { get; private set; } // 0x0000000185FB9420-0x0000000185FB9430 0x0000000185FCEBB0-0x0000000185FCEBC0
		public int totalIndices { get; private set; } // 0x000000018BFCD8EC-0x000000018BFCD93C 0x000000018BFCD93C-0x000000018BFCD9BC
		protected bool disposed { get; private set; } // 0x000000018BFCD4B8-0x000000018BFCD8EC 0x000000018BFD17FC-0x000000018BFD186C
		public VisualElement visualElement { get => default; } // 0x000000018BFCCBE8-0x000000018BFCCF0C 
	
		// Nested types
		internal struct Entry // TypeDefIndex: 44924
		{
			// Fields
			public NativeSlice<UnityEngine.UIElements.Vertex> vertices; // 0x00
			public NativeSlice<ushort> indices; // 0x10
			public Material material; // 0x20
			public Texture custom; // 0x28
			public Texture font; // 0x30
			public float fontTexSDFScale; // 0x38
			public TextureId texture; // 0x3C
			public RenderChainCommand customCommand; // 0x40
			public BMPAlloc clipRectID; // 0x48
			public VertexFlags addFlags; // 0x50
			public bool uvIsDisplacement; // 0x54
			public bool isTextEntry; // 0x55
			public bool isClipRegisterEntry; // 0x56
			public int stencilRef; // 0x58
			public int maskDepth; // 0x5C
		}
	
		internal struct ClosingInfo // TypeDefIndex: 44925
		{
			// Fields
			public bool needsClosing; // 0x00
			public bool popViewMatrix; // 0x01
			public bool popScissorClip; // 0x02
			public bool blitAndPopRenderTexture; // 0x03
			public bool PopDefaultMaterial; // 0x04
			public RenderChainCommand clipUnregisterDrawCommand; // 0x08
			public NativeSlice<UnityEngine.UIElements.Vertex> clipperRegisterVertices; // 0x10
			public NativeSlice<ushort> clipperRegisterIndices; // 0x20
			public int clipperRegisterIndexOffset; // 0x30
			public int maskStencilRef; // 0x34
		}
	
		internal struct TempDataAlloc<T> : IDisposable // TypeDefIndex: 44926
			where T : struct
		{
			// Fields
			private int maxPoolElemCount;
			private NativeArray<T> pool;
			private List<NativeArray<T>> excess;
			private uint takenFromPool;
	
			// Constructors
			public TempDataAlloc(int maxPoolElems) {
				maxPoolElemCount = default;
				pool = default;
				excess = default;
				takenFromPool = default;
			} // 0x000000018BFD16A0-0x000000018BFD1764
	
			// Methods
			public void Dispose() {} // 0x000000018BFCCF0C-0x000000018BFCCFEC
			internal NativeSlice<T> Alloc(uint count) => default; // 0x000000018BFCD018-0x000000018BFCD044
			internal void SessionDone() {} // 0x000000018BFCCFEC-0x000000018BFCD018
		}
	
		// Constructors
		public UIRStylePainter() {} // Dummy constructor
		public UIRStylePainter(RenderChain renderChain) {} // 0x0000000185FC2A70-0x0000000185FC2A80
	
		// Methods
		private MeshWriteData GetPooledMeshWriteData() => default; // 0x000000018BFD1C9C-0x000000018BFD2050
		private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) => default; // 0x0000000185FB8510-0x0000000185FB8520
		private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) => default; // 0x0000000185FB8520-0x0000000185FB8530
		private MeshWriteData AllocThroughDrawGradients(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) => default; // 0x0000000187A4762C-0x0000000187A47640
		public void Dispose() {} // 0x000000018BFD1764-0x000000018BFD17FC
		protected void Dispose(bool disposing) {} // 0x000000018BFCC94C-0x000000018BFCCBE8
		public void Begin(VisualElement ve) {} // 0x000000018BFCDCA0-0x000000018BFCE0D4
		public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd) {} // 0x000000018BFCF858-0x000000018BFCF9A4
		public void LandClipRegisterMesh(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices, int indexOffset) {} // 0x000000018BFCF234-0x000000018BFCF858
		public MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, TextureId texture, Material material, MeshGenerationContext.MeshFlags flags) => default; // 0x000000018BFCED04-0x000000018BFCF234
		public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags) => default; // 0x000000018BFCE0D4-0x000000018BFCE798
		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x000000018BFCD9BC-0x000000018BFCDB84
		internal void DrawTextNative(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x000000018BFCDB84-0x000000018BFCDCA0
		internal void DrawTextCore(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x0000000185FE9A80-0x0000000185FE9A90
		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams) {} // 0x000000018BFCFE90-0x000000018BFD08F8
		public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams) {} // 0x000000018BFD08F8-0x000000018BFD0DE8
		public void DrawImmediate(Action callback, bool cullingEnabled) {} // 0x000000018BFCD2D0-0x000000018BFCD4B8
		public void DrawVisualElementBackground() {} // 0x000000018BFCE798-0x000000018BFCED04
		public void DrawVisualElementBorder() {} // 0x000000018BFCD044-0x000000018BFCD2D0
		public void ApplyVisualElementClipping() {} // 0x000000018BFCF9A4-0x000000018BFCFE90
		private ushort[] AdjustSpriteWinding(Vector2[] vertices, ushort[] indices) => default; // 0x000000018BFD186C-0x000000018BFD195C
		public void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams) {} // 0x000000018BFD195C-0x000000018BFD1C9C
		private void ApplyInset(ref MeshGenerationContextUtils.RectangleParams rectParams, Texture tex) {} // 0x000000018BFD0DE8-0x000000018BFD1428
		public void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams) {} // 0x000000018BFD1428-0x000000018BFD16A0
		internal void Reset() {}
		private void ValidateMeshWriteData() {}
		private void GenerateStencilClipEntryForRoundedRectBackground() {}
		private void GenerateStencilClipEntryForSVGBackground() {}
	}

	internal class UIRTextUpdatePainter : IStylePainter, IDisposable // TypeDefIndex: 44928
	{
		// Fields
		private VisualElement m_CurrentElement; // 0x10
		private int m_TextEntryIndex; // 0x18
		private NativeArray<UnityEngine.UIElements.Vertex> m_DudVerts; // 0x20
		private NativeArray<ushort> m_DudIndices; // 0x30
		private NativeSlice<UnityEngine.UIElements.Vertex> m_MeshDataVerts; // 0x40
		private Color32 m_XFormClipPages; // 0x50
		private Color32 m_IDs; // 0x54
		private Color32 m_Flags; // 0x58
		private Color32 m_OpacityColorPages; // 0x5C
		private readonly MeshGenerationContext _meshGenerationContext_k__BackingField; // 0x60
	
		// Properties
		public MeshGenerationContext meshGenerationContext { get; } // 0x0000000185FB0530-0x0000000185FB0540 
	
		// Constructors
		public UIRTextUpdatePainter() {} // 0x000000018BFD29B0-0x000000018BFD2A18
	
		// Methods
		public void Begin(VisualElement ve, UIRenderDevice device) {} // 0x000000018BFD2050-0x000000018BFD22D8
		public void End() {} // 0x000000018BFD2920-0x000000018BFD29B0
		public void Dispose() {} // 0x000000018BFD22D8-0x000000018BFD2358
		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams) {} // 0x0000000185492010-0x0000000185492020
		public void DrawImmediate(Action callback, bool cullingEnabled) {} // 0x0000000185492010-0x0000000185492020
		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x000000018BFD2358-0x000000018BFD2920
	}
}
