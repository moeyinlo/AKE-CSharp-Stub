/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements.Internal;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.StyleSheets.Syntax;
using UnityEngine.UIElements.UIR;
using UnityEngine.UIElements.UIR.Implementation;
using UnityEngine.Yoga;

// Image 9: UnityEngine.UIElementsModule.dll - Assembly: UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 71217-72085

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 72085
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_108 _2658253827592C8000DF6C48FD5487B674D9E695DB670A56FDEAB2B7F291523E; // 0x00 // Static value (base64): AAAEAAEABAAFAAEAAQAFAAIABQAGAAIAAgAGAAMABgAHAAMABAAIAAUACAAJAAUABQAJAAYACQAKAAYABgAKAAcACgALAAcACAAMAAkADAANAAkACQANAAoADQAOAAoACgAOAAsADgAPAAsA - Metadata: 0x02622778

	// Nested types
	private struct __StaticArrayInitTypeSize_108 // TypeDefIndex: 72084
	{
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 71218
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 71219
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.UIElements
{
	internal static class AlignmentUtils // TypeDefIndex: 71220
	{
		// Methods
		internal static float RoundToPixelGrid(float v, float pixelsPerPoint, float offset = 0.02f /* Metadata: 0x02622247 */); // 0x000000018D596450-0x000000018D596480
		internal static float CeilToPixelGrid(float v, float pixelsPerPoint, float offset = -0.02f /* Metadata: 0x0262224B */); // 0x000000018D596428-0x000000018D596450
	}

	internal abstract class AtlasBase // TypeDefIndex: 71221
	{
		// Fields
		internal TextureRegistry textureRegistry; // 0x10
	
		// Constructors
		protected AtlasBase(); // 0x000000018D5969F0-0x000000018D596A44
	
		// Methods
		public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect); // 0x000000018D596998-0x000000018D5969F0
		public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void Reset(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAssignedToPanel(IPanel panel); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnRemovedFromPanel(IPanel panel); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnUpdateDynamicTextures(IPanel panel); // 0x0000000186805BA0-0x0000000186805BB0
		internal void InvokeAssignedToPanel(IPanel panel); // 0x000000018D5968E4-0x000000018D5968F8
		internal void InvokeRemovedFromPanel(IPanel panel); // 0x000000018CC88E38-0x000000018CC88E4C
		internal void InvokeUpdateDynamicTextures(IPanel panel); // 0x000000018CC96110-0x000000018CC96124
		protected static void RepaintTexturedElements(IPanel panel); // 0x000000018D5968F8-0x000000018D596978
		protected void SetDynamicTexture(TextureId id, Texture texture); // 0x000000018D596978-0x000000018D596998
	}

	[Flags]
	public enum DynamicAtlasFilters // TypeDefIndex: 71222
	{
		None = 0,
		Readability = 1,
		Size = 2,
		Format = 4,
		ColorSpace = 8,
		FilterMode = 16
	}

	public delegate bool DynamicAtlasCustomFilter(Texture2D texture, ref DynamicAtlasFilters filtersToApply); // TypeDefIndex: 71223; 0x00000001859B7730-0x00000001859B7740

	internal class DynamicAtlas : AtlasBase // TypeDefIndex: 71225
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
		internal bool isInitialized { get; } // 0x000000018D59E744-0x000000018D59E758 
		public int minAtlasSize { set; } // 0x000000018D59E7E8-0x000000018D59E800
		public int maxAtlasSize { set; } // 0x000000018D59E7B8-0x000000018D59E7D0
		public static DynamicAtlasFilters defaultFilters { get; } // 0x0000000187239DE0-0x0000000187239DF0 
		public DynamicAtlasFilters activeFilters { set; } // 0x000000018D59E758-0x000000018D59E770
		public int maxSubTextureSize { get; set; } // 0x00000001872615F0-0x0000000187261600 0x000000018D59E7D0-0x000000018D59E7E8
		public DynamicAtlasCustomFilter customFilter { set; } // 0x000000018D59E770-0x000000018D59E7B8
	
		// Nested types
		private class TextureInfo : LinkedPoolItem<TextureInfo> // TypeDefIndex: 71224
		{
			// Fields
			public DynamicAtlasPage page; // 0x18
			public int counter; // 0x20
			public Allocator2D.Alloc2D alloc; // 0x28
			public RectInt rect; // 0x58
			public static readonly LinkedPool<TextureInfo> pool; // 0x00
	
			// Constructors
			public TextureInfo(); // 0x000000018D5A71D0-0x000000018D5A71F8
			static TextureInfo(); // 0x000000018D5A709C-0x000000018D5A71D0
	
			// Methods
			private static TextureInfo Create(); // 0x000000018D5A7004-0x000000018D5A7054
			private static void Reset(TextureInfo info); // 0x000000018D5A7054-0x000000018D5A709C
		}
	
		// Constructors
		public DynamicAtlas(); // 0x000000018D59E658-0x000000018D59E744
	
		// Methods
		protected override void OnAssignedToPanel(IPanel panel); // 0x000000018D59DF14-0x000000018D59DF90
		protected override void OnRemovedFromPanel(IPanel panel); // 0x000000018D59DF90-0x000000018D59E018
		public override void Reset(); // 0x000000018D59E088-0x000000018D59E128
		private void InitPages(); // 0x000000018D59DB08-0x000000018D59DC38
		private void DestroyPages(); // 0x000000018D59DA80-0x000000018D59DB08
		public override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect); // 0x000000018D59E260-0x000000018D59E658
		public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas); // 0x000000018D59E128-0x000000018D59E260
		protected override void OnUpdateDynamicTextures(IPanel panel); // 0x000000018D59E018-0x000000018D59E088
		internal static bool IsTextureFormatSupported(TextureFormat format); // 0x000000018D59DC38-0x000000018D59DDD4
		public virtual bool IsTextureValid(Texture2D texture, UnityEngine.FilterMode atlasFilterMode); // 0x000000018D59DDD4-0x000000018D59DF14
	}

	public class BindableElement : VisualElement, IBindable // TypeDefIndex: 71228
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IBinding _binding_k__BackingField; // 0x3C0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _bindingPath_k__BackingField; // 0x3C8
	
		// Properties
		public IBinding binding { [CompilerGenerated] get; } // 0x000000018723A1B0-0x000000018723A1C0 
		public string bindingPath { [CompilerGenerated] set; } // 0x0000000188DC4BC4-0x0000000188DC4BD8
	
		// Nested types
		public class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits> // TypeDefIndex: 71226
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D5A7570-0x000000018D5A75AC
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 71227
		{
			// Fields
			private UxmlStringAttributeDescription m_PropertyPath; // 0x70
	
			// Constructors
			public UxmlTraits(); // 0x000000018D5A76C0-0x000000018D5A7750
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D5A75E8-0x000000018D5A76C0
		}
	
		// Constructors
		public BindableElement(); // 0x000000018D598748-0x000000018D598794
	}

	internal class ClampedDragger<T> : Clickable // TypeDefIndex: 71230
		where T : IComparable<T>
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action dragging;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action draggingEnded;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DragDirection _dragDirection_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private BaseSlider<T> _slider_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _startMousePosition_k__BackingField;
	
		// Properties
		public DragDirection dragDirection { [CompilerGenerated] get; [CompilerGenerated] set; }
		private BaseSlider<T> slider { [CompilerGenerated] set; }
		public Vector2 startMousePosition { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector2 delta { get; }
	
		// Events
		public event Action dragging {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		public event Action draggingEnded {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Nested types
		[Flags]
		public enum DragDirection // TypeDefIndex: 71229
		{
			None = 0,
			LowToHigh = 1,
			HighToLow = 2,
			Free = 4
		}
	
		// Constructors
		public ClampedDragger(BaseSlider<T> slider, Action clickHandler, Action dragHandler);
	
		// Methods
		protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId);
		protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId);
		protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition);
	}

	public class Clickable : PointerManipulator // TypeDefIndex: 71231
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<EventBase> clickedWithEventInfo; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action clicked; // 0x40
		private readonly long m_Delay; // 0x48
		private readonly long m_Interval; // 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _active_k__BackingField; // 0x58
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _lastMousePosition_k__BackingField; // 0x5C
		private int m_ActivePointerId; // 0x64
		private bool m_AcceptClicksIfDisabled; // 0x68
		private IVisualElementScheduledItem m_Repeater; // 0x70
	
		// Properties
		protected bool active { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018226EBF0-0x000000018226EC00
		public Vector2 lastMousePosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187262740-0x0000000187262760 0x00000001872517E0-0x00000001872517F0
		internal bool acceptClicksIfDisabled { get; set; } // 0x000000018226EF80-0x000000018226EF90 0x000000018D59AC90-0x000000018D59ACD0
		private InvokePolicy invokePolicy { get; } // 0x000000018D59AB64-0x000000018D59AB70 
	
		// Events
		public event Action<EventBase> clickedWithEventInfo {
			add; // 0x000000018D59AA44-0x000000018D59AAD0
			remove; // 0x000000018D59AB70-0x000000018D59ABFC
		}
		public event Action clicked {
			add; // 0x000000018D59AAD0-0x000000018D59AB64
			remove; // 0x000000018D59ABFC-0x000000018D59AC90
		}
	
		// Constructors
		public Clickable(Action handler, long delay, long interval); // 0x000000018D59A8CC-0x000000018D59A908
		public Clickable(Action<EventBase> handler); // 0x000000018D59A908-0x000000018D59A9A4
		public Clickable(Action handler); // 0x000000018D59A9A4-0x000000018D59AA44
	
		// Methods
		private void OnTimer(UnityEngine.UIElements.TimerState timerState); // 0x000000018D599A30-0x000000018D599AAC
		private bool IsRepeatable(); // 0x000000018D5993DC-0x000000018D5993F0
		protected override void RegisterCallbacksOnTarget(); // 0x000000018D599EC8-0x000000018D59A384
		protected override void UnregisterCallbacksFromTarget(); // 0x000000018D59A490-0x000000018D59A8CC
		protected void OnMouseDown(MouseDownEvent evt); // 0x000000018D59945C-0x000000018D59951C
		protected void OnMouseMove(MouseMoveEvent evt); // 0x000000018D59951C-0x000000018D599588
		protected void OnMouseUp(MouseUpEvent evt); // 0x000000018D599588-0x000000018D59964C
		private void OnMouseCaptureOut(MouseCaptureOutEvent evt); // 0x000000018D5993F0-0x000000018D59945C
		private void OnPointerDown(PointerDownEvent evt); // 0x000000018D59973C-0x000000018D599844
		private void OnPointerMove(PointerMoveEvent evt); // 0x000000018D599844-0x000000018D599928
		private void OnPointerUp(PointerUpEvent evt); // 0x000000018D599928-0x000000018D599A30
		private void OnPointerCancel(PointerCancelEvent evt); // 0x000000018D59964C-0x000000018D5996CC
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt); // 0x000000018D5996CC-0x000000018D59973C
		private bool ContainsPointer(int pointerId); // 0x000000018D5992FC-0x000000018D599350
		private static bool IsNotMouseEvent(int pointerId); // 0x000000018D599390-0x000000018D5993DC
		protected void Invoke(EventBase evt); // 0x000000018D599350-0x000000018D599390
		internal void SimulateSingleClick(EventBase evt, int delayMs = 100 /* Metadata: 0x02622259 */); // 0x000000018D59A384-0x000000018D59A468
		protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId); // 0x000000018D599B7C-0x000000018D599D58
		protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition); // 0x000000018D599D58-0x000000018D599DC0
		protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId); // 0x000000018D599DC0-0x000000018D599EC8
		protected virtual void ProcessCancelEvent(EventBase evt, int pointerId); // 0x000000018D599AAC-0x000000018D599B7C
		[CompilerGenerated]
		private void _SimulateSingleClick_b__43_0(); // 0x000000018D59A468-0x000000018D59A490
	}

	internal class ClickDetector // TypeDefIndex: 71233
	{
		// Fields
		private List<ButtonClickStatus> m_ClickStatus; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static int _s_DoubleClickTime_k__BackingField; // 0x00
	
		// Properties
		internal static int s_DoubleClickTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D599258-0x000000018D5992A8 0x000000018D5992A8-0x000000018D5992FC
	
		// Nested types
		private class ButtonClickStatus // TypeDefIndex: 71232
		{
			// Fields
			public VisualElement m_Target; // 0x10
			public Vector3 m_PointerDownPosition; // 0x18
			public long m_LastPointerDownTime; // 0x28
			public int m_ClickCount; // 0x30
	
			// Constructors
			public ButtonClickStatus(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Reset(); // 0x000000018D598794-0x000000018D5987D0
		}
	
		// Constructors
		public ClickDetector(); // 0x000000018D5990C8-0x000000018D599258
		static ClickDetector(); // 0x000000018D59908C-0x000000018D5990C8
	
		// Methods
		private void StartClickTracking(EventBase evt); // 0x000000018D598F2C-0x000000018D59908C
		private void SendClickEvent(EventBase evt); // 0x000000018D598CD4-0x000000018D598F2C
		private void CancelClickTracking(EventBase evt); // 0x000000018D5987D0-0x000000018D598860
		public void ProcessEvent(EventBase evt); // 0x000000018D598A84-0x000000018D598CD4
		private static bool ContainsPointer(VisualElement element, Vector2 position); // 0x000000018D5989C8-0x000000018D598A84
		internal void Cleanup(List<VisualElement> elements); // 0x000000018D598860-0x000000018D5989C8
	}

	public abstract class ContextualMenuManager // TypeDefIndex: 71234
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _displayMenuHandledOSX_k__BackingField; // 0x10
	
		// Properties
		internal bool displayMenuHandledOSX { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Methods
		public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);
		public void DisplayMenu(EventBase triggerEvent, IEventHandler target); // 0x000000018D59ACD0-0x000000018D59AE08
		protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);
	}

	public class ContextualMenuManipulator : MouseManipulator // TypeDefIndex: 71235
	{
		// Fields
		private Action<ContextualMenuPopulateEvent> m_MenuBuilder; // 0x30
	
		// Constructors
		public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder); // 0x000000018D59B488-0x000000018D59B570
	
		// Methods
		protected override void RegisterCallbacksOnTarget(); // 0x000000018D59AFF0-0x000000018D59B23C
		protected override void UnregisterCallbacksFromTarget(); // 0x000000018D59B23C-0x000000018D59B488
		private void OnMouseUpDownEvent(IMouseEvent evt); // 0x000000018D59AF38-0x000000018D59AFA0
		private void OnMouseDownEventOSX(MouseDownEvent evt); // 0x000000018D59AEE0-0x000000018D59AF38
		private void OnMouseUpEventOSX(MouseUpEvent evt); // 0x000000018D59AFA0-0x000000018D59AFF0
		private void OnKeyUpEvent(KeyUpEvent evt); // 0x000000018D59AE84-0x000000018D59AEE0
		private void DoDisplayMenu(EventBase evt); // 0x000000018D59AE08-0x000000018D59AE70
		private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt); // 0x000000018D59AE70-0x000000018D59AE84
	}

	internal struct CountingBloomFilter // TypeDefIndex: 71237
	{
		// Fields
		private unsafe fixed /* 0x00000000-0x00000000 */ byte m_Counters[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_Counters_e__FixedBuffer // TypeDefIndex: 71236
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		private void AdjustSlot(uint index, bool increment); // 0x000000018D59B570-0x000000018D59B594
		private uint Hash1(uint hash); // 0x0000000187262760-0x0000000187262770
		private uint Hash2(uint hash); // 0x0000000187262770-0x0000000187262780
		private bool IsSlotEmpty(uint index); // 0x000000018D59B5E8-0x000000018D59B5F4
		public void InsertHash(uint hash); // 0x000000018D59B5C0-0x000000018D59B5E8
		public void RemoveHash(uint hash); // 0x000000018D59B5F4-0x000000018D59B638
		public bool ContainsHash(uint hash); // 0x000000018D59B594-0x000000018D59B5C0
	}

	internal class AncestorFilter // TypeDefIndex: 71238
	{
		// Fields
		private CountingBloomFilter m_CountingBloomFilter; // 0x10
		private Stack<int> m_HashStack; // 0x4010
	
		// Constructors
		public AncestorFilter(); // 0x000000018D596864-0x000000018D5968E4
	
		// Methods
		private void AddHash(int hash); // 0x000000018D596480-0x000000018D5964E4
		public bool IsCandidate(StyleComplexSelector complexSel); // 0x000000018D5964E4-0x000000018D59655C
		public void PushElement(VisualElement element); // 0x000000018D59661C-0x000000018D596864
		public void PopElement(); // 0x000000018D59655C-0x000000018D59661C
	}

	public struct Cursor : IEquatable<UnityEngine.UIElements.Cursor> // TypeDefIndex: 71239
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Texture2D _texture_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _hotspot_k__BackingField; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _defaultCursorId_k__BackingField; // 0x10
	
		// Properties
		public Texture2D texture { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Vector2 hotspot { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018724A700-0x000000018724A720 0x000000018561B590-0x000000018561B5A0
		internal int defaultCursorId { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D59B734-0x000000018D59B7B8
		public bool Equals(Cursor other); // 0x000000018D59B7B8-0x000000018D59B87C
		public override int GetHashCode(); // 0x000000018D59B87C-0x000000018D59B950
		public static bool operator ==(Cursor style1, Cursor style2); // 0x000000018D59B9C4-0x000000018D59B9F0
		public override string ToString(); // 0x000000018D59B950-0x000000018D59B9C4
	}

	internal interface ICursorManager // TypeDefIndex: 71240
	{
		// Methods
		void SetCursor(UnityEngine.UIElements.Cursor cursor);
		void ResetCursor();
	}

	internal class CursorManager : ICursorManager // TypeDefIndex: 71241
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isCursorOverriden_k__BackingField; // 0x10
	
		// Properties
		public bool isCursorOverriden { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public CursorManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void SetCursor(UnityEngine.UIElements.Cursor cursor); // 0x000000018D59B678-0x000000018D59B734
		public void ResetCursor(); // 0x000000018D59B638-0x000000018D59B678
	}

	internal class DefaultEventSystem // TypeDefIndex: 71247
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
		private bool isAppFocused { get; } // 0x000000018783C5E0-0x000000018783C5E8 
		internal IInput input { get; } // 0x000000018D59CD08-0x000000018D59CD3C 
		public BaseRuntimePanel focusedPanel { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x000000018D59CD3C-0x000000018D59CD8C
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 71242
		{
			Always = 0,
			IgnoreIfAppNotFocused = 1
		}
	
		internal interface IInput // TypeDefIndex: 71243
		{
			// Properties
			int touchCount { get; }
			bool mousePresent { get; }
	
			// Methods
			bool GetButtonDown(string button);
			float GetAxisRaw(string axis);
			Touch GetTouch(int index);
		}
	
		private class Input : IInput // TypeDefIndex: 71244
		{
			// Properties
			public int touchCount { get; } // 0x000000018C36BAAC-0x000000018C36BAB4 
			public bool mousePresent { get; } // 0x000000018D5A4EBC-0x000000018D5A4EC4 
	
			// Constructors
			public Input(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool GetButtonDown(string button); // 0x000000018D5A4EB0-0x000000018D5A4EBC
			public float GetAxisRaw(string axis); // 0x000000018D5A4EA4-0x000000018D5A4EB0
			public Touch GetTouch(int index); // 0x000000018CC10850-0x000000018CC10898
		}
	
		private class NoInput : IInput // TypeDefIndex: 71245
		{
			// Properties
			public int touchCount { get; } // 0x0000000185829EC0-0x0000000185829ED0 
			public bool mousePresent { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
			// Constructors
			public NoInput(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool GetButtonDown(string button); // 0x00000001843FFFF0-0x0000000184400000
			public float GetAxisRaw(string axis); // 0x0000000187234CD0-0x0000000187234CE0
			public Touch GetTouch(int index); // 0x0000000187262870-0x0000000187262890
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71246
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
			static __c(); // 0x000000018D5A750C-0x000000018D5A7570
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal EventBase _SendIMGUIEvents_b__23_0(DefaultEventSystem self); // 0x000000018D5A72CC-0x000000018D5A731C
			internal EventBase _SendIMGUIEvents_b__23_1(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self); // 0x000000018D5A731C-0x000000018D5A73A8
			internal EventBase _SendIMGUIEvents_b__23_2(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self); // 0x000000018D5A73A8-0x000000018D5A7474
			internal EventBase _SendInputEvents_b__24_0(DefaultEventSystem self); // 0x000000018D5A7474-0x000000018D5A74A4
			internal EventBase _SendInputEvents_b__24_1(DefaultEventSystem self); // 0x000000018D5A74A4-0x000000018D5A74D8
			internal EventBase _SendInputEvents_b__24_2(DefaultEventSystem self); // 0x000000018D5A74D8-0x000000018D5A750C
			internal EventBase _ProcessTouchEvents_b__30_0(Vector3 panelPosition, Vector3 panelDelta, Touch _touch); // 0x000000018D5A71F8-0x000000018D5A72CC
			internal bool _.cctor_b__41_0(); // 0x00000001843FFFF0-0x0000000184400000
		}
	
		// Constructors
		public DefaultEventSystem(); // 0x000000018D59CC14-0x000000018D59CD08
		static DefaultEventSystem(); // 0x000000018D59CB50-0x000000018D59CC14
	
		// Methods
		private IInput GetDefaultInput(); // 0x000000018D59B9F0-0x000000018D59BAF8
		private bool ShouldIgnoreEventsOnAppNotFocused(); // 0x000000018D59C898-0x000000018D59C8B0
		public void Update(UpdateMode updateMode = UpdateMode.Always /* Metadata: 0x0262225B */); // 0x000000018D59CAF4-0x000000018D59CB50
		private void SendIMGUIEvents(); // 0x000000018D59C0C4-0x000000018D59C5C4
		private void SendInputEvents(); // 0x000000018D59C5C4-0x000000018D59C898
		internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg);
		private void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false /* Metadata: 0x0262225C */);
		private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel); // 0x000000018D59CA94-0x000000018D59CAF4
		private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers); // 0x000000018D59BC14-0x000000018D59BD10
		private bool ProcessTouchEvents(); // 0x000000018D59BD10-0x000000018D59C0C4
		private Vector2 GetRawMoveVector(); // 0x000000018D59BB18-0x000000018D59BC14
		private bool ShouldSendMoveFromInput(); // 0x000000018D59C8B0-0x000000018D59CA94
		private static Vector2 GetLocalScreenPosition(UnityEngine.Event evt, out int? targetDisplay); // 0x000000018D59BAF8-0x000000018D59BB18
	}

	internal class DisposeHelper // TypeDefIndex: 71248
	{
		// Methods
		public static void NotifyDisposedUsed(IDisposable disposable); // 0x000000018D59D050-0x000000018D59D0EC
	}

	public class DropdownMenuEventInfo // TypeDefIndex: 71249
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly EventModifiers _modifiers_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector2 _mousePosition_k__BackingField; // 0x14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector2 _localMousePosition_k__BackingField; // 0x1C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly char _character_k__BackingField; // 0x24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly KeyCode _keyCode_k__BackingField; // 0x28
	
		// Constructors
		public DropdownMenuEventInfo(EventBase e); // 0x000000018D59D174-0x000000018D59D324
	}

	public abstract class DropdownMenuItem // TypeDefIndex: 71250
	{
		// Constructors
		protected DropdownMenuItem(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class DropdownMenuSeparator : DropdownMenuItem // TypeDefIndex: 71251
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _subMenuPath_k__BackingField; // 0x10
	
		// Constructors
		public DropdownMenuSeparator(string subMenuPath); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public class DropdownMenuAction : DropdownMenuItem // TypeDefIndex: 71253
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Status _status_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DropdownMenuEventInfo _eventInfo_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _userData_k__BackingField; // 0x28
		private readonly Action<DropdownMenuAction> actionCallback; // 0x30
		private readonly Func<DropdownMenuAction, Status> actionStatusCallback; // 0x38
	
		// Properties
		private Status status { [CompilerGenerated] set; } // 0x000000018442F470-0x000000018442F480
		private DropdownMenuEventInfo eventInfo { [CompilerGenerated] set; } // 0x0000000187835950-0x0000000187835960
		private object userData { [CompilerGenerated] set; } // 0x0000000185CA30F0-0x0000000185CA3100
	
		// Nested types
		[Flags]
		public enum Status // TypeDefIndex: 71252
		{
			None = 0,
			Normal = 1,
			Disabled = 2,
			Checked = 4,
			Hidden = 8
		}
	
		// Constructors
		public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null); // 0x000000018D59D12C-0x000000018D59D174
	
		// Methods
		public static Status AlwaysEnabled(DropdownMenuAction a); // 0x0000000187262790-0x00000001872627A0
		public static Status AlwaysDisabled(DropdownMenuAction a); // 0x0000000187262780-0x0000000187262790
		public void UpdateActionStatus(DropdownMenuEventInfo eventInfo); // 0x000000018D59D0EC-0x000000018D59D12C
	}

	public class DropdownMenu // TypeDefIndex: 71255
	{
		// Fields
		private List<DropdownMenuItem> m_MenuItems; // 0x10
		private DropdownMenuEventInfo m_DropdownMenuEventInfo; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 71254
		{
			// Fields
			public DropdownMenuAction.Status status; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal DropdownMenuAction.Status _AppendAction_b__0(DropdownMenuAction e); // 0x00000001828BC2B0-0x00000001828BC2C0
		}
	
		// Constructors
		public DropdownMenu(); // 0x000000018D59D988-0x000000018D59DA00
	
		// Methods
		public List<DropdownMenuItem> MenuItems(); // 0x0000000187249840-0x0000000187249850
		public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData = null); // 0x000000018D59D44C-0x000000018D59D50C
		public void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.None | DropdownMenuAction.Status.Normal /* Metadata: 0x02622264 */); // 0x000000018D59D324-0x000000018D59D44C
		public void AppendSeparator(string subMenuPath = null); // 0x000000018D59D50C-0x000000018D59D610
		public void InsertSeparator(string subMenuPath, int atIndex); // 0x000000018D59D610-0x000000018D59D728
		public void PrepareForDisplay(EventBase e); // 0x000000018D59D728-0x000000018D59D988
	}

	internal static class DropdownUtility // TypeDefIndex: 71256
	{
		// Fields
		internal static Func<IGenericMenu> MakeDropdownFunc; // 0x00
	
		// Methods
		internal static IGenericMenu CreateDropdown(); // 0x000000018D59DA00-0x000000018D59DA80
	}

	internal enum DispatchMode // TypeDefIndex: 71257
	{
		Default = 1,
		Queued = 1,
		Immediate = 2
	}

	public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate> // TypeDefIndex: 71258
	{
		// Fields
		private readonly EventDispatcher m_Dispatcher; // 0x00
	
		// Constructors
		public EventDispatcherGate(EventDispatcher d); // 0x000000018D59E8A0-0x000000018D59E91C
	
		// Methods
		public void Dispose(); // 0x000000018D59E800-0x000000018D59E820
		public bool Equals(EventDispatcherGate other); // 0x000000018D59E820-0x000000018D59E830
		public override bool Equals(object obj); // 0x000000018D59E830-0x000000018D59E8A0
		public override int GetHashCode(); // 0x000000018AB02AA8-0x000000018AB02ACC
	}

	public sealed class EventDispatcher // TypeDefIndex: 71261
	{
		// Fields
		internal ClickDetector m_ClickDetector; // 0x10
		private List<IEventDispatchingStrategy> m_DispatchingStrategies; // 0x18
		private static readonly ObjectPool<Queue<EventRecord>> k_EventQueuePool; // 0x00
		private Queue<EventRecord> m_Queue; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly PointerDispatchState _pointerState_k__BackingField; // 0x28
		private uint m_GateCount; // 0x30
		private Stack<DispatchContext> m_DispatchContexts; // 0x38
		private static readonly IEventDispatchingStrategy[] s_EditorStrategies; // 0x08
		private bool m_Immediate; // 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _processingEvents_k__BackingField; // 0x41
	
		// Properties
		internal PointerDispatchState pointerState { [CompilerGenerated] get; } // 0x0000000182262130-0x0000000182262140 
		private bool dispatchImmediately { get; } // 0x000000018D59F8D0-0x000000018D59F8E4 
		private bool processingEvents { [CompilerGenerated] set; } // 0x000000018226EE70-0x000000018226EE80
	
		// Nested types
		private struct EventRecord // TypeDefIndex: 71259
		{
			// Fields
			public EventBase m_Event; // 0x00
			public IPanel m_Panel; // 0x08
		}
	
		private struct DispatchContext // TypeDefIndex: 71260
		{
			// Fields
			public uint m_GateCount; // 0x00
			public Queue<EventRecord> m_Queue; // 0x08
		}
	
		// Constructors
		private EventDispatcher(IList<IEventDispatchingStrategy> strategies); // 0x000000018D59F710-0x000000018D59F8D0
		static EventDispatcher(); // 0x000000018D59F42C-0x000000018D59F710
	
		// Methods
		internal static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies); // 0x000000018D59EB2C-0x000000018D59EB8C
		internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode); // 0x000000018D59EB8C-0x000000018D59ECF4
		internal void CloseGate(); // 0x00000001872627A0-0x00000001872627B0
		internal void OpenGate(); // 0x000000018D59ECF4-0x000000018D59ED5C
		private void ProcessEventQueue(); // 0x000000018D59ED5C-0x000000018D59F088
		private void ProcessEvent(EventBase evt, IPanel panel); // 0x000000018D59F088-0x000000018D59F42C
		private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed); // 0x000000018D59E91C-0x000000018D59EB2C
	}

	public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 71262
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _focusable_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _tabIndex_k__BackingField; // 0x24
		private bool m_DelegatesFocus; // 0x28
		private bool m_ExcludeFromFocusRing; // 0x29
	
		// Properties
		public abstract FocusController focusController { get; }
		public bool focusable { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public int tabIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public bool delegatesFocus { get; set; } // 0x00000001872627C0-0x00000001872627D0 0x000000018225DF80-0x000000018225DF90
		internal bool excludeFromFocusRing { get; set; } // 0x00000001872627D0-0x00000001872627E0 0x000000018D5A1110-0x000000018D5A11C8
		public virtual bool canGrabFocus { get; } // 0x0000000182246E50-0x0000000182246E60 
	
		// Constructors
		protected Focusable(); // 0x00000001872627B0-0x00000001872627C0
	
		// Methods
		public virtual void Focus(); // 0x000000018D5A0EC8-0x000000018D5A0F64
		public virtual void Blur(); // 0x000000018D5A0E80-0x000000018D5A0EC0
		internal void BlurImmediately(); // 0x000000018D5A0E40-0x000000018D5A0E80
		private Focusable GetFocusDelegate(); // 0x000000018D5A1078-0x000000018D5A10D0
		private static Focusable GetFirstFocusableChild(VisualElement ve); // 0x000000018D5A0F64-0x000000018D5A1078
		protected override void ExecuteDefaultAction(EventBase evt); // 0x000000018D5A0EC0-0x000000018D5A0EC8
		internal override void ExecuteDefaultActionDisabled(EventBase evt); // 0x000000018D5A0EC0-0x000000018D5A0EC8
		private void ProcessEvent(EventBase evt); // 0x000000018D5A10D0-0x000000018D5A1110
	}

	public class FocusChangeDirection : IDisposable // TypeDefIndex: 71263
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly FocusChangeDirection _unspecified_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly FocusChangeDirection _none_k__BackingField; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly FocusChangeDirection _lastValue_k__BackingField; // 0x10
		private readonly int m_Value; // 0x10
	
		// Properties
		public static FocusChangeDirection unspecified { [CompilerGenerated] get; } // 0x000000018D59FA9C-0x000000018D59FAEC 
		public static FocusChangeDirection none { [CompilerGenerated] get; } // 0x000000018D59FA4C-0x000000018D59FA9C 
		protected static FocusChangeDirection lastValue { [CompilerGenerated] get; } // 0x000000018D59F9FC-0x000000018D59FA4C 
	
		// Constructors
		protected FocusChangeDirection(int value); // 0x0000000182234E90-0x0000000182234EA0
		static FocusChangeDirection(); // 0x000000018D59F920-0x000000018D59F9FC
	
		// Methods
		public static implicit operator int(FocusChangeDirection fcd); // 0x000000018D59FAEC-0x000000018D59FAF8
		void IDisposable.Dispose(); // 0x000000018CDCD15C-0x000000018CDCD16C
		protected virtual void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void ApplyTo(FocusController focusController, Focusable f); // 0x000000018D59F8E4-0x000000018D59F920
	}

	public interface IFocusRing // TypeDefIndex: 71264
	{
		// Methods
		FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);
		Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);
	}

	public class FocusController // TypeDefIndex: 71266
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IFocusRing _focusRing_k__BackingField; // 0x10
		private List<FocusedElement> m_FocusedElements; // 0x18
		private Focusable m_LastFocusedElement; // 0x20
		internal Focusable m_LastPendingFocusedElement; // 0x28
		private int m_PendingFocusCount; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _imguiKeyboardControl_k__BackingField; // 0x34
	
		// Properties
		private IFocusRing focusRing { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public Focusable focusedElement { get; } // 0x000000018D5A0E00-0x000000018D5A0E40 
		internal int imguiKeyboardControl { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
	
		// Nested types
		private struct FocusedElement // TypeDefIndex: 71265
		{
			// Fields
			public VisualElement m_SubTreeRoot; // 0x00
			public Focusable m_FocusedElement; // 0x08
		}
	
		// Constructors
		public FocusController(IFocusRing focusRing); // 0x000000018D5A0D60-0x000000018D5A0E00
	
		// Methods
		internal bool IsFocused(Focusable f); // 0x000000018D5A04BC-0x000000018D5A05F4
		internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst); // 0x000000018D5A0170-0x000000018D5A03A0
		internal Focusable GetLeafFocusedElement(); // 0x000000018D5A00D8-0x000000018D5A0170
		private bool IsLocalElement(Focusable f); // 0x000000018D5A05F4-0x000000018D5A0618
		internal bool IsPendingFocus(Focusable f); // 0x000000018D5A0618-0x000000018D5A0694
		internal void SetFocusToLastFocusedElement(); // 0x000000018D5A0818-0x000000018D5A0878
		internal void BlurLastFocusedElement(); // 0x000000018D59FD20-0x000000018D59FD98
		internal void DoFocusChange(Focusable f); // 0x000000018D59FDF4-0x000000018D59FF38
		internal Focusable FocusNextInDirection(FocusChangeDirection direction); // 0x000000018D59FF38-0x000000018D59FFF4
		private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode); // 0x000000018D59FC0C-0x000000018D59FD20
		private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode); // 0x000000018D5A0704-0x000000018D5A0818
		private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode); // 0x000000018D59FAF8-0x000000018D59FC0C
		private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode); // 0x000000018D5A03A0-0x000000018D5A04BC
		internal void Blur(Focusable focusable, bool bIsFocusDelegated = false /* Metadata: 0x02622268 */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x02622269 */); // 0x000000018D59FD98-0x000000018D59FDF4
		internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false /* Metadata: 0x0262226A */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x0262226B */); // 0x000000018D5A0A14-0x000000018D5A0A94
		internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false /* Metadata: 0x0262226C */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x0262226D */); // 0x000000018D5A0A94-0x000000018D5A0CC0
		internal Focusable SwitchFocusOnEvent(EventBase e); // 0x000000018D5A0878-0x000000018D5A0A14
		internal void ReevaluateFocus(); // 0x000000018D5A0694-0x000000018D5A0704
		internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget); // 0x000000018D59FFF4-0x000000018D5A00D8
		internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch); // 0x000000018D5A0CC0-0x000000018D5A0D60
	}

	internal static class GroupBoxUtility // TypeDefIndex: 71267
	{
		// Fields
		private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers; // 0x00
		private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache; // 0x08
		private static readonly System.Type k_GenericGroupBoxType; // 0x10
	
		// Constructors
		static GroupBoxUtility(); // 0x000000018D5A19BC-0x000000018D5A1B14
	
		// Methods
		private static void OnOptionAttachToPanel(AttachToPanelEvent evt); // 0x000000018D5A15D4-0x000000018D5A1794
		private static void OnOptionDetachFromPanel(DetachFromPanelEvent evt); // 0x000000018D5A1794-0x000000018D5A18F0
		private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox); // 0x000000018D5A11C8-0x000000018D5A1528
		private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt); // 0x000000018D5A1528-0x000000018D5A15D4
		private static void OnPanelDestroyed(BaseVisualElementPanel panel); // 0x000000018D5A18F0-0x000000018D5A19BC
	
		// Extension methods
		public static void RegisterGroupBoxOptionCallbacks<T>(this T option)
			where T : VisualElement, IGroupBoxOption;
		public static void OnOptionSelected<T>(this T selectedOption)
			where T : VisualElement, IGroupBoxOption;
	}

	internal interface IGroupBoxOption // TypeDefIndex: 71268
	{
		// Methods
		void SetSelected(bool selected);
	}

	internal interface IGroupBox // TypeDefIndex: 71269
	{
	}

	internal interface IGroupBox<T> : IGroupBox // TypeDefIndex: 71270
		where T : IGroupManager
	{
	}

	internal interface IGroupManager // TypeDefIndex: 71271
	{
		// Methods
		void OnOptionSelectionChanged(IGroupBoxOption selectedOption);
		void RegisterOption(IGroupBoxOption option);
		void UnregisterOption(IGroupBoxOption option);
	}

	internal class DefaultGroupManager : IGroupManager // TypeDefIndex: 71272
	{
		// Fields
		private List<IGroupBoxOption> m_GroupOptions; // 0x10
		private IGroupBoxOption m_SelectedOption; // 0x18
	
		// Constructors
		public DefaultGroupManager(); // 0x000000018D59CFD8-0x000000018D59D050
	
		// Methods
		public void OnOptionSelectionChanged(IGroupBoxOption selectedOption); // 0x000000018D59CD8C-0x000000018D59CF04
		public void RegisterOption(IGroupBoxOption option); // 0x000000018D59CF04-0x000000018D59CF84
		public void UnregisterOption(IGroupBoxOption option); // 0x000000018D59CF84-0x000000018D59CFD8
	}

	public class IMGUIContainer : VisualElement, IDisposable // TypeDefIndex: 71276
	{
		// Fields
		private Action m_OnGUIHandler; // 0x3C0
		private ObjectGUIState m_ObjectGUIState; // 0x3C8
		internal bool useOwnerObjectGUIState; // 0x3D0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Rect _lastWorldClip_k__BackingField; // 0x3D4
		private bool m_CullingEnabled; // 0x3E4
		private bool m_IsFocusDelegated; // 0x3E5
		private bool m_RefreshCachedLayout; // 0x3E6
		private GUILayoutUtility.LayoutCache m_Cache; // 0x3E8
		private Rect m_CachedClippingRect; // 0x3F0
		private Matrix4x4 m_CachedTransform; // 0x400
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ContextType _contextType_k__BackingField; // 0x440
		private bool lostFocus; // 0x444
		private bool receivedFocus; // 0x445
		private FocusChangeDirection focusChangeDirection; // 0x448
		private bool hasFocusableControls; // 0x450
		private int newKeyboardFocusControlID; // 0x454
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
		public Action onGUIHandler { get; set; } // 0x0000000187262820-0x0000000187262830 0x000000018D5A4DE0-0x000000018D5A4E40
		internal ObjectGUIState guiState { get; } // 0x000000018D5A4CD8-0x000000018D5A4D80 
		internal Rect lastWorldClip { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187262810-0x0000000187262820 0x0000000187262840-0x0000000187262850
		public bool cullingEnabled { get; } // 0x00000001872627F0-0x0000000187262800 
		private GUILayoutUtility.LayoutCache cache { get; } // 0x000000018D5A4C34-0x000000018D5A4CB4 
		private float layoutMeasuredWidth { get; } // 0x000000018D5A4DB0-0x000000018D5A4DE0 
		private float layoutMeasuredHeight { get; } // 0x000000018D5A4D80-0x000000018D5A4DB0 
		public ContextType contextType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872627E0-0x00000001872627F0 0x0000000187262830-0x0000000187262840
		internal bool focusOnlyIfHasFocusableControls { [CompilerGenerated] get; } // 0x0000000187262800-0x0000000187262810 
		public override bool canGrabFocus { get; } // 0x000000018D5A4CB4-0x000000018D5A4CD8 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits> // TypeDefIndex: 71273
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D5A75AC-0x000000018D5A75E8
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 71274
		{
			// Constructors
			public UxmlTraits(); // 0x000000018D5A7750-0x000000018D5A8B4C
		}
	
		private struct GUIGlobals // TypeDefIndex: 71275
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
		static IMGUIContainer(); // 0x000000018D5A465C-0x000000018D5A4A34
		public IMGUIContainer(); // 0x000000018D5A4C28-0x000000018D5A4C34
		public IMGUIContainer(Action onGUIHandler); // 0x000000018D5A4A34-0x000000018D5A4C28
	
		// Methods
		private void OnGenerateVisualContent(MeshGenerationContext mgc); // 0x000000018D5A3DF0-0x000000018D5A3EE4
		private void SaveGlobals(); // 0x000000018D5A401C-0x000000018D5A4110
		private void RestoreGlobals(); // 0x000000018D5A3EE4-0x000000018D5A401C
		private void DoOnGUI(UnityEngine.Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true /* Metadata: 0x0262226E */); // 0x000000018D5A2230-0x000000018D5A30BC
		public void MarkDirtyLayout(); // 0x000000018D5A3DDC-0x000000018D5A3DF0
		public override void HandleEvent(EventBase evt); // 0x000000018D5A3528-0x000000018D5A35AC
		private void DoIMGUIRepaint(); // 0x000000018D5A1CA0-0x000000018D5A1F90
		internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true /* Metadata: 0x0262226F */, bool verifyBounds = true /* Metadata: 0x02622270 */); // 0x000000018D5A41E8-0x000000018D5A4480
		private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds); // 0x000000018D5A4110-0x000000018D5A41E8
		private bool VerifyBounds(EventBase evt); // 0x000000018D5A45CC-0x000000018D5A465C
		private bool IsContainerCapturingTheMouse(); // 0x000000018D5A39D8-0x000000018D5A3A70
		private bool IsLocalEvent(EventBase evt); // 0x000000018D5A3C48-0x000000018D5A3DDC
		private bool IsEventInsideLocalWindow(EventBase evt); // 0x000000018D5A3B38-0x000000018D5A3C48
		private static bool IsDockAreaMouseUp(EventBase evt); // 0x000000018D5A3A70-0x000000018D5A3B38
		private bool HandleIMGUIEvent(UnityEngine.Event e, bool canAffectFocus); // 0x000000018D5A369C-0x000000018D5A36C0
		internal bool HandleIMGUIEvent(UnityEngine.Event e, Action onGUIHandler, bool canAffectFocus); // 0x000000018D5A35AC-0x000000018D5A369C
		private bool HandleIMGUIEvent(UnityEngine.Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus); // 0x000000018D5A36C0-0x000000018D5A39D8
		protected override void ExecuteDefaultAction(EventBase evt); // 0x000000018D5A30BC-0x000000018D5A3320
		private void SetFoldoutDepthClass(); // 0x000000018D5A4480-0x000000018D5A45BC
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode); // 0x000000018D5A1F90-0x000000018D5A2230
		private Rect GetCurrentClipRect(); // 0x000000018D5A3320-0x000000018D5A3398
		private static void GetCurrentTransformAndClip(IMGUIContainer container, UnityEngine.Event evt, out Matrix4x4 transform, out Rect clipRect); // 0x000000018D5A3398-0x000000018D5A3528
		public void Dispose(); // 0x000000018D5A1C30-0x000000018D5A1C80
		protected virtual void Dispose(bool disposeManaged); // 0x000000018D5A1C80-0x000000018D5A1CA0
		[CompilerGenerated]
		private void _DoOnGUI_b__56_0(); // 0x000000018D5A45BC-0x000000018D5A45CC
	}

	internal class ImmediateModeException : Exception // TypeDefIndex: 71277
	{
		// Constructors
		public ImmediateModeException(Exception inner); // 0x000000018D5A4E40-0x000000018D5A4EA4
	}

	public enum SelectionType // TypeDefIndex: 71278
	{
		None = 0,
		Single = 1,
		Multiple = 2
	}

	internal interface ISerializableJsonDictionary // TypeDefIndex: 71279
	{
		// Methods
		void Set<T>(string key, T value)
			where T : class;
		T Get<T>(string key)
			where T : class;
		void Overwrite(object obj, string key);
		bool ContainsKey(string key);
	}

	public interface ITransform // TypeDefIndex: 71280
	{
		// Properties
		Vector3 position { get; set; }
		Vector3 scale { get; }
	}

	public enum KeyboardNavigationOperation // TypeDefIndex: 71281
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

	public class KeyboardNavigationManipulator : Manipulator // TypeDefIndex: 71284
	{
		// Fields
		private readonly Action<KeyboardNavigationOperation, EventBase> m_Action; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private struct __c__DisplayClass5_0 // TypeDefIndex: 71282
		{
			// Fields
			public KeyDownEvent evt; // 0x00
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass6_0 // TypeDefIndex: 71283
		{
			// Fields
			public KeyDownEvent evt; // 0x00
		}
	
		// Constructors
		public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action); // 0x0000000187835500-0x0000000187835510
	
		// Methods
		protected override void RegisterCallbacksOnTarget(); // 0x000000018D5A5040-0x000000018D5A523C
		protected override void UnregisterCallbacksFromTarget(); // 0x000000018D5A53E4-0x000000018D5A55E0
		internal void OnKeyDown(KeyDownEvent evt); // 0x000000018D5A4F24-0x000000018D5A4F84
		private void OnRuntimeKeyDown(KeyDownEvent evt); // 0x000000018D5A5004-0x000000018D5A5040
		private void OnEditorKeyDown(KeyDownEvent evt); // 0x000000018D5A4EE8-0x000000018D5A4F24
		private void OnNavigationCancel(NavigationCancelEvent evt); // 0x000000018D5A4F84-0x000000018D5A4F94
		private void OnNavigationSubmit(NavigationSubmitEvent evt); // 0x000000018D5A4FF4-0x000000018D5A5004
		private void OnNavigationMove(NavigationMoveEvent evt); // 0x000000018D5A4F94-0x000000018D5A4FF4
		private void Invoke(KeyboardNavigationOperation operation, EventBase evt); // 0x000000018D5A4EC4-0x000000018D5A4EE8
		[CompilerGenerated]
		internal static KeyboardNavigationOperation _OnRuntimeKeyDown_g__GetOperation_5_0(ref __c__DisplayClass5_0 param_0009af85); // 0x000000018D5A533C-0x000000018D5A53E4
		[CompilerGenerated]
		internal static KeyboardNavigationOperation _OnEditorKeyDown_g__GetOperation_6_0(ref __c__DisplayClass6_0 param_0009af86); // 0x000000018D5A523C-0x000000018D5A533C
	}

	public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter> // TypeDefIndex: 71285
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private MouseButton _button_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventModifiers _modifiers_k__BackingField; // 0x04
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _clickCount_k__BackingField; // 0x08
	
		// Properties
		public MouseButton button { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public EventModifiers modifiers { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001872342E0-0x00000001872342F0 0x0000000187235AB0-0x0000000187235AC0
		public int clickCount { [CompilerGenerated] [IsReadOnly] get; } // 0x0000000184431A70-0x0000000184431A80 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D5A56A0-0x000000018D5A5720
		public bool Equals(ManipulatorActivationFilter other); // 0x00000001887DD288-0x00000001887DD2A4
		public override int GetHashCode(); // 0x0000000187262850-0x0000000187262870
		public bool Matches(IMouseEvent e); // 0x000000018D5A593C-0x000000018D5A59C4
		private bool HasModifiers(IMouseEvent e); // 0x000000018D5A57A8-0x000000018D5A5830
		public bool Matches(IPointerEvent e); // 0x000000018D5A58B4-0x000000018D5A593C
		private bool HasModifiers(IPointerEvent e); // 0x000000018D5A5720-0x000000018D5A57A8
		private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command); // 0x000000018D5A5830-0x000000018D5A58B4
	}

	public interface IManipulator // TypeDefIndex: 71286
	{
		// Properties
		VisualElement target { set; }
	}

	public abstract class Manipulator : IManipulator // TypeDefIndex: 71287
	{
		// Fields
		private VisualElement m_Target; // 0x10
	
		// Properties
		public VisualElement target { get; set; } // 0x0000000187249840-0x0000000187249850 0x000000018D5A59C4-0x000000018D5A5A14
	
		// Constructors
		protected Manipulator(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected abstract void RegisterCallbacksOnTarget();
		protected abstract void UnregisterCallbacksFromTarget();
	}

	public enum MouseButton // TypeDefIndex: 71288
	{
		LeftMouse = 0,
		RightMouse = 1,
		MiddleMouse = 2
	}

	public static class MouseCaptureController // TypeDefIndex: 71289
	{
		// Extension methods
		public static bool HasMouseCapture(this IEventHandler handler); // 0x000000018D5A5AAC-0x000000018D5A5B1C
		public static void CaptureMouse(this IEventHandler handler); // 0x000000018D5A5A14-0x000000018D5A5AAC
		public static void ReleaseMouse(this IEventHandler handler); // 0x000000018D5A5B1C-0x000000018D5A5BB4
	}

	public abstract class MouseManipulator : Manipulator // TypeDefIndex: 71290
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<ManipulatorActivationFilter> _activators_k__BackingField; // 0x18
		private ManipulatorActivationFilter m_currentActivator; // 0x20
	
		// Properties
		public List<ManipulatorActivationFilter> activators { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		protected MouseManipulator(); // 0x000000018D5A5D4C-0x000000018D5A5DC4
	
		// Methods
		protected bool CanStartManipulation(IMouseEvent e); // 0x000000018D5A5BB4-0x000000018D5A5D28
		protected bool CanStopManipulation(IMouseEvent e); // 0x000000018D5A5D28-0x000000018D5A5D4C
	}

	internal class ObjectPool<T> // TypeDefIndex: 71291
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private int m_MaxSize;
	
		// Properties
		public int maxSize { get; set; }
	
		// Constructors
		public ObjectPool(int maxSize = 100 /* Metadata: 0x02622283 */);
	
		// Methods
		public int Size();
		public T Get();
		public void Release(T element);
	}

	public enum ContextType // TypeDefIndex: 71292
	{
		Player = 0,
		Editor = 1
	}

	[Flags]
	internal enum VersionChangeType // TypeDefIndex: 71293
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

	[Flags]
	public enum UsageHints // TypeDefIndex: 71294
	{
		None = 0,
		DynamicTransform = 1,
		GroupTransform = 2,
		MaskContainer = 4,
		DynamicColor = 8
	}

	[Flags]
	internal enum RenderHints // TypeDefIndex: 71295
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

	internal struct PanelClearSettings // TypeDefIndex: 71296
	{
		// Fields
		public bool clearDepthStencil; // 0x00
		public bool clearColor; // 0x01
		public UnityEngine.Color color; // 0x04
	}

	internal class RepaintData // TypeDefIndex: 71297
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Matrix4x4 _currentOffset_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _mousePosition_k__BackingField; // 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Rect _currentWorldClip_k__BackingField; // 0x58
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UnityEngine.Event _repaintEvent_k__BackingField; // 0x68
	
		// Properties
		public Matrix4x4 currentOffset { [CompilerGenerated] get; } // 0x0000000184437D60-0x0000000184437D90 
		public Rect currentWorldClip { [CompilerGenerated] get; } // 0x0000000187234DB0-0x0000000187234DC0 
		public UnityEngine.Event repaintEvent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
	
		// Constructors
		public RepaintData(); // 0x0000000187262900-0x0000000187262940
	}

	internal delegate void HierarchyEvent(VisualElement ve, HierarchyChangeType changeType); // TypeDefIndex: 71298; 0x00000001859B7730-0x00000001859B7740

	public interface IPanel : IDisposable // TypeDefIndex: 71299
	{
		// Properties
		VisualElement visualTree { get; }
		EventDispatcher dispatcher { get; }
		ContextType contextType { get; }
		FocusController focusController { get; }
	
		// Methods
		VisualElement Pick(Vector2 point);
	}

	internal abstract class BaseVisualElementPanel : IPanel, IGroupBox // TypeDefIndex: 71300
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<BaseVisualElementPanel> panelDisposed; // 0x10
		private float m_Scale; // 0x18
		internal YogaConfig yogaConfig; // 0x20
		private float m_PixelsPerPoint; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PanelClearSettings _clearSettings_k__BackingField; // 0x2C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _duringLayoutPhase_k__BackingField; // 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RepaintData _repaintData_k__BackingField; // 0x48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ICursorManager _cursorManager_k__BackingField; // 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ContextualMenuManager _contextualMenuManager_k__BackingField; // 0x58
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x60
		internal ElementUnderPointer m_TopElementUnderPointers; // 0x68
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action standardShaderChanged; // 0x70
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action standardWorldSpaceShaderChanged; // 0x78
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action atlasChanged; // 0x80
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Material> updateMaterial; // 0x88
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private HierarchyEvent hierarchyChanged; // 0x90
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IPanel> beforeUpdate; // 0x98
	
		// Properties
		public abstract EventInterests IMGUIEventInterests { get; set; }
		public abstract ScriptableObject ownerObject { get; protected set; }
		public abstract SavePersistentViewData saveViewData { get; }
		public abstract GetViewDataDictionary getViewDataDictionary { get; }
		public abstract int IMGUIContainersCount { get; set; }
		public abstract FocusController focusController { get; set; }
		public abstract IMGUIContainer rootIMGUIContainer { get; }
		internal float scale { get; set; } // 0x0000000184F6C3E0-0x0000000184F6C650 0x000000018D598680-0x000000018D598748
		internal float pixelsPerPoint { set; } // 0x000000018D5985B8-0x000000018D598680
		public float scaledPixelsPerPoint { get; } // 0x0000000187262720-0x0000000187262730 
		internal PanelClearSettings clearSettings { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187262700-0x0000000187262720 0x0000000187262730-0x0000000187262740
		internal bool duringLayoutPhase { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		internal abstract uint version { get; }
		internal abstract uint hierarchyVersion { get; }
		internal virtual RepaintData repaintData { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		internal virtual ICursorManager cursorManager { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public ContextualMenuManager contextualMenuManager { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public abstract VisualElement visualTree { get; }
		public abstract EventDispatcher dispatcher { get; set; }
		internal abstract IScheduler scheduler { get; }
		internal abstract IStylePropertyAnimationSystem styleAnimationSystem { get; set; }
		public abstract ContextType contextType { get; protected set; }
		internal bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018226ED70-0x000000018226ED80
		internal abstract Shader standardShader { get; }
		internal virtual Shader standardWorldSpaceShader { get; } // 0x000000018724EFC0-0x000000018724EFD0 
		public abstract AtlasBase atlas { get; set; }
	
		// Events
		internal event Action<BaseVisualElementPanel> panelDisposed {
			add; // 0x000000018D598120-0x000000018D5981AC
			remove; // 0x000000018D598404-0x000000018D598490
		}
		internal event Action standardShaderChanged {
			add; // 0x000000018D5981AC-0x000000018D598240
			remove; // 0x000000018D598490-0x000000018D598524
		}
		internal event Action standardWorldSpaceShaderChanged {
			add; // 0x000000018D598240-0x000000018D5982D4
			remove; // 0x000000018D598524-0x000000018D5985B8
		}
		internal event Action atlasChanged {
			add; // 0x000000018D597FF0-0x000000018D598088
			remove; // 0x000000018D5982D4-0x000000018D59836C
		}
		internal event HierarchyEvent hierarchyChanged {
			add; // 0x000000018D598088-0x000000018D598120
			remove; // 0x000000018D59836C-0x000000018D598404
		}
	
		// Constructors
		protected BaseVisualElementPanel(); // 0x000000018D597ED0-0x000000018D597FF0
	
		// Methods
		public void Dispose(); // 0x000000018D597940-0x000000018D597990
		protected virtual void Dispose(bool disposing); // 0x000000018D597990-0x000000018D597A88
		public abstract void Repaint(UnityEngine.Event e);
		public abstract void ValidateLayout();
		public abstract void UpdateAnimations();
		public abstract void UpdateBindings();
		public abstract void ApplyStyles();
		internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);
		internal void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x026222BC */); // 0x000000018D597C10-0x000000018D597CAC
		public abstract VisualElement Pick(Vector2 point);
		public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked);
		internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase);
		internal VisualElement GetTopElementUnderPointer(int pointerId); // 0x000000018D597A88-0x000000018D597AA8
		internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent); // 0x000000018D597B18-0x000000018D597C10
		internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent); // 0x000000018D5978B4-0x000000018D5978E4
		internal void CommitElementUnderPointers(); // 0x000000018D5978E4-0x000000018D597940
		protected void InvokeAtlasChanged(); // 0x000000018D597AA8-0x000000018D597ABC
		internal void InvokeUpdateMaterial(Material mat); // 0x000000018D597B00-0x000000018D597B18
		internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType); // 0x000000018D597AD8-0x000000018D597B00
		internal void InvokeBeforeUpdate(); // 0x000000018D597ABC-0x000000018D597AD8
		internal void UpdateElementUnderPointers(); // 0x000000018D597CAC-0x000000018D597E54
		public virtual void Update(); // 0x000000018D597E54-0x000000018D597ED0
	}

	internal delegate UnityEngine.Object LoadResourceFunction(string pathName, System.Type type, float dpiScaling); // TypeDefIndex: 71301; 0x000000018124EAD0-0x000000018124EAF0

	internal delegate long TimeMsFunction(); // TypeDefIndex: 71302; 0x0000000185B44B70-0x0000000185B44B80

	internal delegate ISerializableJsonDictionary GetViewDataDictionary(); // TypeDefIndex: 71303; 0x0000000185B44B70-0x0000000185B44B80

	internal delegate void SavePersistentViewData(); // TypeDefIndex: 71304; 0x0000000185B44B70-0x0000000185B44B80

	internal class Panel : BaseVisualElementPanel // TypeDefIndex: 71305
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventDispatcher _dispatcher_k__BackingField; // 0xF8
		private TimerEventScheduler m_Scheduler; // 0x100
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ScriptableObject _ownerObject_k__BackingField; // 0x108
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ContextType _contextType_k__BackingField; // 0x110
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SavePersistentViewData _saveViewData_k__BackingField; // 0x118
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GetViewDataDictionary _getViewDataDictionary_k__BackingField; // 0x120
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FocusController _focusController_k__BackingField; // 0x128
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventInterests _IMGUIEventInterests_k__BackingField; // 0x130
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static LoadResourceFunction _loadResourceFunc_k__BackingField; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static TimeMsFunction _TimeSinceStartup_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _IMGUIContainersCount_k__BackingField; // 0x134
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IMGUIContainer _rootIMGUIContainer_k__BackingField; // 0x138
		private Shader m_StandardShader; // 0x140
		private AtlasBase m_Atlas; // 0x148
		private bool m_ValidatingLayout; // 0x150
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Panel> beforeAnyRepaint; // 0x18
	
		// Properties
		public sealed override VisualElement visualTree { get; } // 0x0000000187261EB0-0x0000000187261EC0 
		public sealed override EventDispatcher dispatcher { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872346D0-0x00000001872346E0 0x0000000188A7C28C-0x0000000188A7C2A0
		public TimerEventScheduler timerEventScheduler { get; } // 0x000000018D5A6E80-0x000000018D5A6EFC 
		internal override IScheduler scheduler { get; } // 0x000000018D5A6E74-0x000000018D5A6E80 
		internal override IStylePropertyAnimationSystem styleAnimationSystem { get; set; } // 0x0000000187232F90-0x0000000187232FA0 0x000000018D5A6F94-0x000000018D5A7004
		public override ScriptableObject ownerObject { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187232D20-0x0000000187232D30 0x0000000188BD49B4-0x0000000188BD49C8
		public override ContextType contextType { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872406A0-0x00000001872406B0 0x0000000185FBF190-0x0000000185FBF1A0
		public override SavePersistentViewData saveViewData { [CompilerGenerated] get; } // 0x0000000187232D10-0x0000000187232D20 
		public override GetViewDataDictionary getViewDataDictionary { [CompilerGenerated] get; } // 0x000000018723B5E0-0x000000018723B5F0 
		public sealed override FocusController focusController { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018783BF64-0x000000018783BF78
		public override EventInterests IMGUIEventInterests { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187262890-0x00000001872628B0 0x00000001872628E0-0x0000000187262900
		private static LoadResourceFunction loadResourceFunc { [CompilerGenerated] get; } // 0x000000018D5A6E24-0x000000018D5A6E74 
		internal string name { get; set; } // 0x0000000187261F70-0x0000000187261F80 0x000000018D5A6F6C-0x000000018D5A6F94
		private static TimeMsFunction TimeSinceStartup { [CompilerGenerated] get; } // 0x000000018D5A6DD4-0x000000018D5A6E24 
		public override int IMGUIContainersCount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187250E60-0x0000000187250E70 0x00000001872628D0-0x00000001872628E0
		public override IMGUIContainer rootIMGUIContainer { [CompilerGenerated] get; } // 0x000000018723B5C0-0x000000018723B5D0 
		internal override uint version { get; } // 0x000000018723BAC0-0x000000018723BAD0 
		internal override uint hierarchyVersion { get; } // 0x0000000187235AE0-0x0000000187235AF0 
		internal override Shader standardShader { get; } // 0x00000001872628C0-0x00000001872628D0 
		public override AtlasBase atlas { get; set; } // 0x00000001872628B0-0x00000001872628C0 0x000000018D5A6EFC-0x000000018D5A6F6C
	
		// Constructors
		public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher); // 0x000000018D5A6A48-0x000000018D5A6DD4
		static Panel(); // 0x000000018D5A69E4-0x000000018D5A6A48
	
		// Methods
		internal static UnityEngine.Object LoadResource(string pathName, System.Type type, float dpiScaling); // 0x000000018D5A6134-0x000000018D5A61DC
		internal void Focus(); // 0x000000018D5A60E4-0x000000018D5A6110
		internal void Blur(); // 0x000000018D5A5DEC-0x000000018D5A5E18
		private void CreateMarkers(); // 0x000000018D5A5E18-0x000000018D5A606C
		protected override void Dispose(bool disposing); // 0x000000018D5A608C-0x000000018D5A60E4
		public static long TimeSinceStartupMs(); // 0x000000018D5A67FC-0x000000018D5A688C
		internal static long DefaultTimeSinceStartupMs(); // 0x000000018D5A606C-0x000000018D5A608C
		private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null); // 0x000000018D5A64A4-0x000000018D5A6508
		private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null); // 0x000000018D5A6224-0x000000018D5A6400
		public override VisualElement PickAll(Vector2 point, List<VisualElement> picked); // 0x000000018D5A6400-0x000000018D5A64A4
		public override VisualElement Pick(Vector2 point); // 0x000000018D5A6508-0x000000018D5A6630
		public override void ValidateLayout(); // 0x000000018D5A6970-0x000000018D5A69E4
		public override void UpdateAnimations(); // 0x000000018D5A6894-0x000000018D5A68BC
		public override void UpdateBindings(); // 0x000000018D5A68BC-0x000000018D5A68E4
		public override void ApplyStyles(); // 0x000000018D5A5DC4-0x000000018D5A5DEC
		private void UpdateForRepaint(); // 0x000000018D5A68E4-0x000000018D5A6970
		public override void Repaint(UnityEngine.Event e); // 0x000000018D5A6630-0x000000018D5A67FC
		internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D5A61DC-0x000000018D5A6224
		internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase); // 0x000000018D5A6110-0x000000018D5A6134
		[CompilerGenerated]
		internal static Vector2Int _Pick_g__PixelOf_99_0(Vector2 p); // 0x000000018D5A688C-0x000000018D5A6894
	}

	internal abstract class BaseRuntimePanel : UnityEngine.UIElements.Panel // TypeDefIndex: 71307
	{
		// Fields
		private GameObject m_SelectableGameObject; // 0x158
		private static int s_CurrentRuntimePanelCounter; // 0x00
		internal readonly int m_RuntimePanelCreationIndex; // 0x160
		private float m_SortingPriority; // 0x164
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action destroyed; // 0x168
		private Shader m_StandardWorldSpaceShader; // 0x170
		private bool m_DrawToCameras; // 0x178
		internal RenderTexture targetTexture; // 0x180
		internal Matrix4x4 panelToWorld; // 0x188
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _targetDisplay_k__BackingField; // 0x1C8
		internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace; // 0x08
		private Func<Vector2, Vector2> m_ScreenToPanelSpace; // 0x1D0
	
		// Properties
		public GameObject selectableGameObject { get; set; } // 0x000000018723BD30-0x000000018723BD40 0x000000018D597768-0x000000018D5977FC
		public float sortingPriority { get; set; } // 0x00000001872626E0-0x00000001872626F0 0x000000018D5977FC-0x000000018D5978B4
		internal override Shader standardWorldSpaceShader { get; } // 0x00000001872626F0-0x0000000187262700 
		internal bool drawToCameras { get; set; } // 0x00000001872626D0-0x00000001872626E0 0x000000018D597678-0x000000018D5976F0
		internal int targetDisplay { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723D850-0x000000018723D860 0x000000018723D9B0-0x000000018723D9C0
		internal int screenRenderingWidth { get; } // 0x000000018D597528-0x000000018D5975E0 
		internal int screenRenderingHeight { get; } // 0x000000018D597470-0x000000018D597528 
		public Func<Vector2, Vector2> screenToPanelSpace { get; set; } // 0x000000018723BC70-0x000000018723BC80 0x000000018D5976F0-0x000000018D597768
	
		// Events
		public event Action destroyed {
			add; // 0x000000018D5973D8-0x000000018D597470
			remove; // 0x000000018D5975E0-0x000000018D597678
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71306
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018D5AC9F0-0x000000018D5ACA54
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector2 _.cctor_b__44_0(Vector2 p); // 0x000000018459BB50-0x000000018459BB60
		}
	
		// Constructors
		protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null); // 0x000000018D5972B8-0x000000018D5973D8
		static BaseRuntimePanel(); // 0x000000018D5971D8-0x000000018D5972B8
	
		// Methods
		protected override void Dispose(bool disposing); // 0x000000018D596CE4-0x000000018D596D28
		public override void Repaint(UnityEngine.Event e); // 0x000000018D596E48-0x000000018D597048
		internal Vector2 ScreenToPanel(Vector2 screen); // 0x000000018D597048-0x000000018D59709C
		internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false /* Metadata: 0x026222BD */); // 0x000000018D59709C-0x000000018D5971D8
		private void AssignPanelToComponents(BaseRuntimePanel panel); // 0x000000018D596A44-0x000000018D596CE4
		internal void PointerLeavesPanel(int pointerId, Vector2 position); // 0x000000018D596DB0-0x000000018D596E48
		internal void PointerEntersPanel(int pointerId, Vector2 position); // 0x000000018D596D28-0x000000018D596DB0
	}

	internal interface IRuntimePanelComponent // TypeDefIndex: 71308
	{
		// Properties
		IPanel panel { set; }
	}

	public static class PointerCaptureHelper // TypeDefIndex: 71309
	{
		// Methods
		private static PointerDispatchState GetStateFor(IEventHandler handler); // 0x000000018D5AACE0-0x000000018D5AAD48
	
		// Extension methods
		public static bool HasPointerCapture(this IEventHandler handler, int pointerId); // 0x000000018D5AAD48-0x000000018D5AAD84
		public static void CapturePointer(this IEventHandler handler, int pointerId); // 0x000000018D5AAC60-0x000000018D5AAC98
		public static void ReleasePointer(this IEventHandler handler, int pointerId); // 0x000000018D5AADF4-0x000000018D5AAE2C
		public static IEventHandler GetCapturingElement(this IPanel panel, int pointerId); // 0x000000018D5AAC98-0x000000018D5AACE0
		public static void ReleasePointer(this IPanel panel, int pointerId); // 0x000000018D5AAE2C-0x000000018D5AAE64
		internal static void ActivateCompatibilityMouseEvents(this IPanel panel, int pointerId); // 0x000000018D5AAC28-0x000000018D5AAC60
		internal static void PreventCompatibilityMouseEvents(this IPanel panel, int pointerId); // 0x000000018D5AAD84-0x000000018D5AADBC
		internal static bool ShouldSendCompatibilityMouseEvents(this IPanel panel, IPointerEvent evt); // 0x000000018D5AAE64-0x000000018D5AAF20
		internal static void ProcessPointerCapture(this IPanel panel, int pointerId); // 0x000000018D5AADBC-0x000000018D5AADF4
	}

	internal class PointerDispatchState // TypeDefIndex: 71310
	{
		// Fields
		private IEventHandler[] m_PendingPointerCapture; // 0x10
		private IEventHandler[] m_PointerCapture; // 0x18
		private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20
	
		// Constructors
		public PointerDispatchState(); // 0x000000018D5AB7C0-0x000000018D5AB894
	
		// Methods
		internal void Reset(); // 0x000000018D5AB6DC-0x000000018D5AB760
		public IEventHandler GetCapturingElement(int pointerId); // 0x000000018B636D34-0x000000018B636D60
		public bool HasPointerCapture(IEventHandler handler, int pointerId); // 0x000000018D5AB038-0x000000018D5AB068
		public void CapturePointer(IEventHandler handler, int pointerId); // 0x000000018D5AAF50-0x000000018D5AB038
		public void ReleasePointer(int pointerId); // 0x000000018D5AB674-0x000000018D5AB698
		public void ReleasePointer(IEventHandler handler, int pointerId); // 0x000000018D5AB698-0x000000018D5AB6DC
		public void ProcessPointerCapture(int pointerId); // 0x000000018D5AB098-0x000000018D5AB674
		public void ActivateCompatibilityMouseEvents(int pointerId); // 0x000000018D5AAF20-0x000000018D5AAF50
		public void PreventCompatibilityMouseEvents(int pointerId); // 0x000000018D5AB068-0x000000018D5AB098
		public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt); // 0x000000018D5AB760-0x000000018D5AB7C0
	}

	public abstract class PointerManipulator : MouseManipulator // TypeDefIndex: 71311
	{
		// Fields
		private int m_CurrentPointerId; // 0x30
	
		// Constructors
		protected PointerManipulator(); // 0x000000018D5ABA34-0x000000018D5ABA3C
	
		// Methods
		protected bool CanStartManipulation(IPointerEvent e); // 0x000000018D5AB894-0x000000018D5ABA10
		protected bool CanStopManipulation(IPointerEvent e); // 0x000000018D5ABA10-0x000000018D5ABA34
	}

	internal static class ProjectionUtils // TypeDefIndex: 71312
	{
		// Methods
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far); // 0x000000018D5ABA3C-0x000000018D5ABB58
	}

	public struct TimerState : IEquatable<UnityEngine.UIElements.TimerState> // TypeDefIndex: 71313
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long _start_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long _now_k__BackingField; // 0x08
	
		// Properties
		public long start { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
		public long now { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AFA30-0x00000001844AFA40 0x000000018561B590-0x000000018561B5A0
		public long deltaTime { get; } // 0x0000000187262990-0x00000001872629A0 
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D5AC914-0x000000018D5AC98C
		public bool Equals(TimerState other); // 0x000000018D5AC8E8-0x000000018D5AC914
		public override int GetHashCode(); // 0x0000000187262950-0x0000000187262990
	}

	internal interface IScheduler // TypeDefIndex: 71314
	{
		// Methods
		void Unschedule(ScheduledItem item);
		void Schedule(ScheduledItem item);
		void UpdateScheduledEvents();
	}

	internal abstract class ScheduledItem // TypeDefIndex: 71316
	{
		// Fields
		public Func<bool> timerUpdateStopCondition; // 0x10
		public static readonly Func<bool> OnceCondition; // 0x00
		public static readonly Func<bool> ForeverCondition; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long _startMs_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long _delayMs_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long _intervalMs_k__BackingField; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long _endTimeMs_k__BackingField; // 0x30
	
		// Properties
		public long startMs { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018561CBD0-0x000000018561CBE0
		public long delayMs { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x000000018561BB30-0x000000018561BB40
		public long intervalMs { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x000000018561BB40-0x000000018561BB50
		public long endTimeMs { [CompilerGenerated] get; } // 0x00000001829600D0-0x00000001829600E0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71315
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018D5AC98C-0x000000018D5AC9F0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _.cctor_b__25_0(); // 0x00000001851A4410-0x00000001851A4420
			internal bool _.cctor_b__25_1(); // 0x00000001843FFFF0-0x0000000184400000
		}
	
		// Constructors
		public ScheduledItem(); // 0x000000018D5ABCF8-0x000000018D5ABD58
		static ScheduledItem(); // 0x000000018D5ABBC4-0x000000018D5ABCF8
	
		// Methods
		protected void ResetStartTime(); // 0x000000018D5ABB58-0x000000018D5ABBA4
		public abstract void PerformTimerUpdate(UnityEngine.UIElements.TimerState state);
		internal virtual void OnItemUnscheduled(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool ShouldUnschedule(); // 0x000000018D5ABBA4-0x000000018D5ABBC4
	}

	internal class TimerEventScheduler : IScheduler // TypeDefIndex: 71317
	{
		// Fields
		private readonly List<ScheduledItem> m_ScheduledItems; // 0x10
		private bool m_TransactionMode; // 0x18
		private readonly List<ScheduledItem> m_ScheduleTransactions; // 0x20
		private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; // 0x28
		internal bool disableThrottling; // 0x30
		private int m_LastUpdatedIndex; // 0x34
	
		// Constructors
		public TimerEventScheduler(); // 0x000000018D5AC75C-0x000000018D5AC85C
	
		// Methods
		public void Schedule(ScheduledItem item); // 0x000000018D5ABF50-0x000000018D5AC144
		private bool RemovedScheduledItemAt(int index); // 0x000000018D5ABEE0-0x000000018D5ABF50
		public void Unschedule(ScheduledItem item); // 0x000000018D5AC144-0x000000018D5AC3B4
		private bool PrivateUnSchedule(ScheduledItem sItem); // 0x000000018D5ABE44-0x000000018D5ABEE0
		public void UpdateScheduledEvents(); // 0x000000018D5AC3B4-0x000000018D5AC75C
	}

	internal struct Spacing // TypeDefIndex: 71318
	{
		// Fields
		public float left; // 0x00
		public float top; // 0x04
		public float right; // 0x08
		public float bottom; // 0x0C
	
		// Properties
		public float horizontal { get; } // 0x0000000187260330-0x0000000187260340 
		public float vertical { get; } // 0x00000001872602E0-0x00000001872602F0 
	
		// Constructors
		public Spacing(float left, float top, float right, float bottom); // 0x00000001872359D0-0x00000001872359F0
	
		// Methods
		public static Rect operator -(Rect r, Spacing a); // 0x000000018D5ABDD8-0x000000018D5ABE44
	}

	public enum Position // TypeDefIndex: 71319
	{
		Relative = 0,
		Absolute = 1
	}

	internal enum OverflowInternal // TypeDefIndex: 71320
	{
		Visible = 0,
		Hidden = 1,
		Scroll = 2
	}

	public enum OverflowClipBox // TypeDefIndex: 71321
	{
		PaddingBox = 0,
		ContentBox = 1
	}

	public enum FlexDirection // TypeDefIndex: 71322
	{
		Column = 0,
		ColumnReverse = 1,
		Row = 2,
		RowReverse = 3
	}

	public enum Wrap // TypeDefIndex: 71323
	{
		NoWrap = 0,
		Wrap = 1,
		WrapReverse = 2
	}

	public enum Align // TypeDefIndex: 71324
	{
		Auto = 0,
		FlexStart = 1,
		Center = 2,
		FlexEnd = 3,
		Stretch = 4
	}

	public enum Justify // TypeDefIndex: 71325
	{
		FlexStart = 0,
		Center = 1,
		FlexEnd = 2,
		SpaceBetween = 3,
		SpaceAround = 4
	}

	public enum TextOverflowPosition // TypeDefIndex: 71326
	{
		End = 0,
		Start = 1,
		Middle = 2
	}

	public enum TextOverflow // TypeDefIndex: 71327
	{
		Clip = 0,
		Ellipsis = 1
	}

	public enum TransformOriginOffset // TypeDefIndex: 71328
	{
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4,
		Center = 5
	}

	public enum Visibility // TypeDefIndex: 71329
	{
		Visible = 0,
		Hidden = 1
	}

	public enum WhiteSpace // TypeDefIndex: 71330
	{
		Normal = 0,
		NoWrap = 1
	}

	public enum DisplayStyle // TypeDefIndex: 71331
	{
		Flex = 0,
		None = 1
	}

	internal interface IStylePainter // TypeDefIndex: 71332
	{
		// Methods
		void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint);
		void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams);
		void DrawImmediate(Action callback, bool cullingEnabled);
	}

	internal struct CursorPositionStylePainterParameters // TypeDefIndex: 71333
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
		public static CursorPositionStylePainterParameters GetDefault(VisualElement ve, string text); // 0x000000018D5A8E80-0x000000018D5A9000
		internal TextNativeSettings GetTextNativeSettings(float scaling); // 0x000000018D5A9000-0x000000018D5A90DC
	}

	internal interface IStylePropertyAnimations // TypeDefIndex: 71334
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

	public class VisualElement : Focusable, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler, IResolvedStyle // TypeDefIndex: 71347
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _UnityEngine_UIElements_IStylePropertyAnimations_runningAnimationCount_k__BackingField; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _containedPointerIds_k__BackingField; // 0x2C0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PickingMode _pickingMode_k__BackingField; // 0x2C4
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private YogaNode _yogaNode_k__BackingField; // 0x2C8
		internal ComputedStyle m_Style; // 0x2D0
		internal StyleVariableContext variableContext; // 0x328
		internal int inheritedStylesHash; // 0x330
		internal readonly uint controlid; // 0x334
		internal int imguiContainerDescendantCount; // 0x338
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _enabledSelf_k__BackingField; // 0x33C
		private LanguageDirection m_LanguageDirection; // 0x340
		private LanguageDirection m_LocalLanguageDirection; // 0x344
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<MeshGenerationContext> _generateVisualContent_k__BackingField; // 0x348
		private ProfilerMarker k_GenerateVisualContentMarker; // 0x350
		private RenderTargetMode m_SubRenderTargetMode; // 0x358
		private static Material s_runtimeMaterial; // 0x30
		private Material m_defaultMaterial; // 0x360
		private List<IValueAnimationUpdate> m_RunningAnimations; // 0x368
		internal const string k_RootVisualContainerName = "rootVisualContainer"; // Metadata: 0x026222E8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Hierarchy _hierarchy_k__BackingField; // 0x370
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isRootVisualContainer_k__BackingField; // 0x378
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _cacheAsBitmap_k__BackingField; // 0x379
		private VisualElement m_PhysicalParent; // 0x380
		private VisualElement m_LogicalParent; // 0x388
		private static readonly List<VisualElement> s_EmptyList; // 0x38
		private List<VisualElement> m_Children; // 0x390
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
		internal bool hasRunningAnimations { get; } // 0x000000018D5B645C-0x000000018D5B647C 
		internal bool hasCompletedAnimations { get; } // 0x000000018D5B636C-0x000000018D5B638C 
		int IStylePropertyAnimations.runningAnimationCount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		int IStylePropertyAnimations.completedAnimationCount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		internal IStylePropertyAnimations styleAnimation { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		internal bool isCompositeRoot { get; set; } // 0x000000018D5B6488-0x000000018D5B6494 0x000000018D5B6E4C-0x000000018D5B6E78
		internal bool isHierarchyDisplayed { get; set; } // 0x000000018D5B6494-0x000000018D5B64A0 0x000000018D5B6E78-0x000000018D5B6EA8
		public string viewDataKey { get; set; } // 0x0000000187261F10-0x0000000187261F20 0x000000018D5B76A4-0x000000018D5B76F8
		internal bool enableViewDataPersistence { get; private set; } // 0x000000018D5B630C-0x000000018D5B6318 0x000000018D5B6DF0-0x000000018D5B6E20
		public object userData { get; set; } // 0x000000018D5B6ACC-0x000000018D5B6B34 0x000000018D5B7640-0x000000018D5B76A4
		public override bool canGrabFocus { get; } // 0x000000018D5B603C-0x000000018D5B60BC 
		public override FocusController focusController { get; } // 0x000000018D5B6328-0x000000018D5B6348 
		public UsageHints usageHints { get; set; } // 0x000000018D5B6A9C-0x000000018D5B6ACC 0x000000018D5B75B8-0x000000018D5B7640
		internal RenderHints renderHints { get; set; } // 0x0000000187262CF0-0x0000000187262D00 0x000000018D5B73E4-0x000000018D5B7424
		public ITransform transform { get; } // 0x0000000187261380-0x0000000187261390 
		Vector3 ITransform.position { get; set; } // 0x000000018D5B4AB8-0x000000018D5B4AF8 0x000000018D5B4B38-0x000000018D5B4BFC
		Vector3 ITransform.scale { get; } // 0x000000018D5B4AF8-0x000000018D5B4B38 
		internal bool isLayoutManual { get; private set; } // 0x000000018D5B64A0-0x000000018D5B64AC 0x000000018D5B6EA8-0x000000018D5B6ED4
		internal float scaledPixelsPerPoint { get; } // 0x000000018D5B6814-0x000000018D5B6834 
		public Rect layout { get; internal set; } // 0x000000018D5B6534-0x000000018D5B65E4 0x000000018D5B6F2C-0x000000018D5B7330
		public Rect contentRect { get; } // 0x000000018D5B61B8-0x000000018D5B6280 
		protected Rect paddingRect { get; } // 0x000000018D5B6634-0x000000018D5B66FC 
		internal bool isBoundingBoxDirty { get; set; } // 0x000000018D5B647C-0x000000018D5B6488 0x000000018D5B6E20-0x000000018D5B6E4C
		internal bool isWorldBoundingBoxDirty { get; set; } // 0x000000018D5B6514-0x000000018D5B6520 0x000000018D5B6ED4-0x000000018D5B6F00
		internal Rect boundingBox { get; } // 0x000000018D5B5FF0-0x000000018D5B603C 
		internal Rect worldBoundingBox { get; } // 0x000000018D5B6BDC-0x000000018D5B6C30 
		private Rect boundingBoxInParentSpace { get; } // 0x000000018D5B5FA0-0x000000018D5B5FF0 
		public Rect worldBound { get; } // 0x000000018D5B6B54-0x000000018D5B6BDC 
		public Rect localBound { get; } // 0x000000018D5B65E4-0x000000018D5B6634 
		internal Rect rect { get; } // 0x000000018D5B67B4-0x000000018D5B6808 
		internal bool isWorldTransformDirty { get; set; } // 0x000000018C93DA24-0x000000018C93DA2C 0x000000018D139FF0-0x000000018D13A01C
		internal bool isWorldTransformInverseDirty { get; set; } // 0x000000018D5B652C-0x000000018D5B6534 0x000000018D13A01C-0x000000018D13A048
		public Matrix4x4 worldTransform { get; } // 0x000000018D5B6D5C-0x000000018D5B6DC0 
		internal ref Matrix4x4 worldTransformRef { get; } // 0x000000018D5B6D30-0x000000018D5B6D5C 
		internal ref Matrix4x4 worldTransformInverse { get; } // 0x000000018D5B6D04-0x000000018D5B6D30 
		internal bool isWorldClipDirty { get; set; } // 0x000000018D5B6520-0x000000018D5B652C 0x000000018D5B6F00-0x000000018D5B6F2C
		internal Rect worldClip { get; } // 0x000000018D5B6CB8-0x000000018D5B6D04 
		internal Rect worldClipMinusGroup { get; } // 0x000000018D5B6C6C-0x000000018D5B6CB8 
		internal bool worldClipIsInfinite { get; } // 0x000000018D5B6C30-0x000000018D5B6C6C 
		internal PseudoStates pseudoStates { get; set; } // 0x0000000187262CE0-0x0000000187262CF0 0x000000018D5B7378-0x000000018D5B73E4
		internal int containedPointerIds { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724FA20-0x000000018724FA30 0x0000000187262D10-0x0000000187262D20
		public PickingMode pickingMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018725F2C0-0x000000018725F2D0 0x0000000187262D30-0x0000000187262D40
		public string name { get; set; } // 0x00000001872615B0-0x00000001872615C0 0x000000018D5B7330-0x000000018D5B7378
		internal List<string> classList { get; } // 0x000000018D5B611C-0x000000018D5B61B8 
		internal string fullTypeName { get; } // 0x000000018D5B6348-0x000000018D5B636C 
		internal string typeName { get; } // 0x000000018D5B6A78-0x000000018D5B6A9C 
		internal YogaNode yogaNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C1D0-0x000000018723C1E0 0x0000000188DC4D2C-0x0000000188DC4D40
		internal ref ComputedStyle computedStyle { get; } // 0x0000000187262C90-0x0000000187262CA0 
		internal bool hasInlineStyle { get; } // 0x000000018D5B6450-0x000000018D5B645C 
		internal bool styleInitialized { get; set; } // 0x000000018D5B6834-0x000000018D5B6840 0x000000018D5B7488-0x000000018D5B74B8
		private bool isParentEnabledInHierarchy { get; } // 0x000000018D5B64AC-0x000000018D5B6514 
		public bool enabledInHierarchy { get; } // 0x000000018D5B6318-0x000000018D5B6328 
		public bool enabledSelf { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187262CB0-0x0000000187262CC0 0x0000000187262D20-0x0000000187262D30
		public bool visible { get; set; } // 0x000000018D5B6B34-0x000000018D5B6B54 0x000000018D5B76F8-0x000000018D5B7764
		public Action<MeshGenerationContext> generateVisualContent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723A170-0x000000018723A180 0x0000000188DC4DA4-0x0000000188DC4DB8
		internal bool requireMeasureFunction { get; set; } // 0x000000018D5B6808-0x000000018D5B6814 0x000000018D5B7424-0x000000018D5B7488
		internal RenderTargetMode subRenderTargetMode { get; } // 0x0000000187262D00-0x0000000187262D10 
		internal Material defaultMaterial { get; } // 0x0000000187262CA0-0x0000000187262CB0 
		public IExperimentalFeatures experimental { get; } // 0x0000000187261380-0x0000000187261390 
		ITransitionAnimations IExperimentalFeatures.animation { get; } // 0x0000000187261380-0x0000000187261390 
		public Hierarchy hierarchy { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723A1A0-0x000000018723A1B0 0x0000000188DC4E30-0x0000000188DC4E44
		internal bool isRootVisualContainer { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018725F380-0x000000018725F390 0x000000018725F430-0x000000018725F440
		internal bool disableClipping { get; set; } // 0x000000018D5B6300-0x000000018D5B630C 0x000000018D5B6DC0-0x000000018D5B6DF0
		public VisualElement parent { get; } // 0x0000000187262CD0-0x0000000187262CE0 
		internal BaseVisualElementPanel elementPanel { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233980-0x0000000187233990 0x00000001889D3C38-0x00000001889D3C4C
		public IPanel panel { get; } // 0x0000000187262CC0-0x0000000187262CD0 
		public virtual VisualElement contentContainer { get; } // 0x0000000187261380-0x0000000187261390 
		internal VisualTreeAsset visualTreeAssetSource { set; } // 0x0000000188E3E140-0x0000000188E3E154
		public VisualElement this[int key] { get => default; } // 0x000000018D5B5F34-0x000000018D5B5FA0 
		public int childCount { get; } // 0x000000018D5B60BC-0x000000018D5B611C 
		private Vector3 positionWithLayout { get; } // 0x000000018D5B66FC-0x000000018D5B67B4 
		internal bool hasDefaultRotationAndScale { get; } // 0x000000018D5B638C-0x000000018D5B6450 
		public IVisualElementScheduler schedule { get; } // 0x0000000187261380-0x0000000187261390 
		public IStyle style { get; } // 0x000000018D5B6840-0x000000018D5B68C0 
		public ICustomStyle customStyle { get; } // 0x000000018D5B6280-0x000000018D5B6300 
		public VisualElementStyleSheetSet styleSheets { get; } // 0x0000000186067390-0x00000001860673B0 
		public string tooltip { get; set; } // 0x000000018D5B68C0-0x000000018D5B693C 0x000000018D5B74B8-0x000000018D5B75B8
		private TypeData typeData { get; } // 0x000000018D5B693C-0x000000018D5B6A78 
		public IResolvedStyle resolvedStyle { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
		UnityEngine.Color IResolvedStyle.backgroundColor { get; } // 0x000000018D5B3ACC-0x000000018D5B3AF8 
		UnityEngine.Color IResolvedStyle.borderBottomColor { get; } // 0x000000018D5B3AF8-0x000000018D5B3B24 
		float IResolvedStyle.borderBottomLeftRadius { get; } // 0x000000018D5B3B24-0x000000018D5B3B48 
		float IResolvedStyle.borderBottomRightRadius { get; } // 0x000000018D5B3B48-0x000000018D5B3B6C 
		float IResolvedStyle.borderBottomWidth { get; } // 0x000000018D5B3B6C-0x000000018D5B3B90 
		UnityEngine.Color IResolvedStyle.borderLeftColor { get; } // 0x000000018D5B3B90-0x000000018D5B3BBC 
		float IResolvedStyle.borderLeftWidth { get; } // 0x000000018D5B3BBC-0x000000018D5B3BE0 
		UnityEngine.Color IResolvedStyle.borderRightColor { get; } // 0x000000018D5B3BE0-0x000000018D5B3C0C 
		float IResolvedStyle.borderRightWidth { get; } // 0x000000018D5B3C0C-0x000000018D5B3C30 
		UnityEngine.Color IResolvedStyle.borderTopColor { get; } // 0x000000018D5B3C30-0x000000018D5B3C5C 
		float IResolvedStyle.borderTopLeftRadius { get; } // 0x000000018D5B3C5C-0x000000018D5B3C80 
		float IResolvedStyle.borderTopRightRadius { get; } // 0x000000018D5B3C80-0x000000018D5B3CA4 
		float IResolvedStyle.borderTopWidth { get; } // 0x000000018D5B3CA4-0x000000018D5B3CC8 
		float IResolvedStyle.bottom { get; } // 0x000000018D5B3CC8-0x000000018D5B3CF0 
		UnityEngine.Color IResolvedStyle.color { get; } // 0x000000018D5B3CF0-0x000000018D5B3D1C 
		DisplayStyle IResolvedStyle.display { get; } // 0x000000018D5B3D1C-0x000000018D5B3D2C 
		FlexDirection IResolvedStyle.flexDirection { get; } // 0x000000018D5B3D2C-0x000000018D5B3D3C 
		float IResolvedStyle.flexGrow { get; } // 0x000000018D5B3D3C-0x000000018D5B3D4C 
		float IResolvedStyle.flexShrink { get; } // 0x000000018D5B3D4C-0x000000018D5B3D5C 
		float IResolvedStyle.height { get; } // 0x000000018D5B3D5C-0x000000018D5B3D84 
		float IResolvedStyle.left { get; } // 0x000000018D5B3D84-0x000000018D5B3DAC 
		float IResolvedStyle.marginBottom { get; } // 0x000000018D5B3DAC-0x000000018D5B3DD0 
		float IResolvedStyle.marginLeft { get; } // 0x000000018D5B3DD0-0x000000018D5B3DF4 
		float IResolvedStyle.marginRight { get; } // 0x000000018D5B3DF4-0x000000018D5B3E18 
		float IResolvedStyle.marginTop { get; } // 0x000000018D5B3E18-0x000000018D5B3E3C 
		StyleFloat IResolvedStyle.minHeight { get; } // 0x000000018D5B3E3C-0x000000018D5B3E6C 
		StyleFloat IResolvedStyle.minWidth { get; } // 0x000000018D5B3E6C-0x000000018D5B3E9C 
		float IResolvedStyle.opacity { get; } // 0x000000018D5B3E9C-0x000000018D5B3EAC 
		float IResolvedStyle.paddingBottom { get; } // 0x000000018D5B3EAC-0x000000018D5B3ED0 
		float IResolvedStyle.paddingLeft { get; } // 0x000000018D5B3ED0-0x000000018D5B3EF4 
		float IResolvedStyle.paddingRight { get; } // 0x000000018D5B3EF4-0x000000018D5B3F18 
		float IResolvedStyle.paddingTop { get; } // 0x000000018D5B3F18-0x000000018D5B3F3C 
		float IResolvedStyle.right { get; } // 0x000000018D5B3F3C-0x000000018D5B3F64 
		Scale IResolvedStyle.scale { get; } // 0x000000018D5B3F64-0x000000018D5B3F90 
		float IResolvedStyle.top { get; } // 0x000000018D5B3F90-0x000000018D5B3FB8 
		Vector3 IResolvedStyle.transformOrigin { get; } // 0x000000018D5B3FB8-0x000000018D5B3FE8 
		Vector3 IResolvedStyle.translate { get; } // 0x000000018D5B3FE8-0x000000018D5B4018 
		UnityEngine.Color IResolvedStyle.unityBackgroundImageTintColor { get; } // 0x000000018D5B4018-0x000000018D5B4044 
		int IResolvedStyle.unitySliceLeft { get; } // 0x000000018D5B4044-0x000000018D5B4054 
		int IResolvedStyle.unitySliceRight { get; } // 0x000000018D5B4054-0x000000018D5B4064 
		UnityEngine.Color IResolvedStyle.unityTextOutlineColor { get; } // 0x000000018D5B4064-0x000000018D5B4090 
		float IResolvedStyle.unityTextOutlineWidth { get; } // 0x000000018D5B4090-0x000000018D5B40A0 
		Visibility IResolvedStyle.visibility { get; } // 0x000000018D5B40A0-0x000000018D5B40B0 
		WhiteSpace IResolvedStyle.whiteSpace { get; } // 0x000000018D5B40B0-0x000000018D5B40C0 
		float IResolvedStyle.width { get; } // 0x000000018D5B40C0-0x000000018D5B40E8 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits> // TypeDefIndex: 71335
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D5ACA54-0x000000018D5ACA90
		}
	
		public class UxmlTraits : UIElements.UxmlTraits // TypeDefIndex: 71336
		{
			// Fields
			protected UxmlStringAttributeDescription m_Name; // 0x18
			private UxmlStringAttributeDescription m_ViewDataKey; // 0x20
			protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode; // 0x28
			private UxmlStringAttributeDescription m_Tooltip; // 0x30
			private UxmlEnumAttributeDescription<UsageHints> m_UsageHints; // 0x38
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private UxmlIntAttributeDescription _focusIndex_k__BackingField; // 0x40
			private UxmlIntAttributeDescription m_TabIndex; // 0x48
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private UxmlBoolAttributeDescription _focusable_k__BackingField; // 0x50
			private UxmlStringAttributeDescription m_Class; // 0x58
			private UxmlStringAttributeDescription m_ContentContainer; // 0x60
			private UxmlStringAttributeDescription m_Style; // 0x68
	
			// Properties
			protected UxmlIntAttributeDescription focusIndex { [CompilerGenerated] get; } // 0x000000018226EEA0-0x000000018226EEB0 
			protected UxmlBoolAttributeDescription focusable { [CompilerGenerated] get; } // 0x000000018226EBD0-0x000000018226EBE0 
	
			// Constructors
			public UxmlTraits(); // 0x000000018D5ACD04-0x000000018D5AD230
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D5ACA90-0x000000018D5ACD04
		}
	
		public enum MeasureMode // TypeDefIndex: 71337
		{
			Undefined = 0,
			Exactly = 1,
			AtMost = 2
		}
	
		internal enum RenderTargetMode // TypeDefIndex: 71338
		{
			None = 0,
			NoColorConversion = 1,
			LinearToGamma = 2,
			GammaToLinear = 3
		}
	
		public struct Hierarchy // TypeDefIndex: 71339
		{
			// Fields
			private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation"; // Metadata: 0x02622303
			private readonly VisualElement m_Owner; // 0x00
	
			// Properties
			public VisualElement parent { get; } // 0x000000018D5AAC08-0x000000018D5AAC28 
			public int childCount { get; } // 0x000000018D5AABC0-0x000000018D5AAC08 
			public VisualElement this[int key] { get => default; } // 0x000000018D5AAB60-0x000000018D5AABC0 
	
			// Constructors
			internal Hierarchy(VisualElement element); // 0x00000001878380EC-0x00000001878380F4
	
			// Methods
			public void Add(VisualElement child); // 0x000000018D5A9934-0x000000018D5A99C0
			public void Insert(int index, VisualElement child); // 0x000000018D5A9F20-0x000000018D5AA268
			public void Remove(VisualElement child); // 0x000000018D5AA914-0x000000018D5AAA4C
			public void RemoveAt(int index); // 0x000000018D5AA644-0x000000018D5AA898
			public void Clear(); // 0x000000018D5A9A94-0x000000018D5A9E48
			internal void BringToFront(VisualElement child); // 0x000000018D5A99C0-0x000000018D5A9A74
			internal void SendToBack(VisualElement child); // 0x000000018D5AAA4C-0x000000018D5AAADC
			internal void PlaceBehind(VisualElement child, VisualElement over); // 0x000000018D5AA36C-0x000000018D5AA464
			private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex); // 0x000000018D5AA268-0x000000018D5AA36C
			public int IndexOf(VisualElement element); // 0x000000018D5A9EC0-0x000000018D5A9F20
			public VisualElement ElementAt(int index); // 0x000000018D5A9E48-0x000000018D5A9E54
			public IEnumerable<VisualElement> Children(); // 0x000000018D5A9A74-0x000000018D5A9A94
			private void SetParent(VisualElement value); // 0x000000018D5AAADC-0x000000018D5AAB60
			private void PutChildAtIndex(VisualElement child, int index); // 0x000000018D5AA464-0x000000018D5AA56C
			private void RemoveChildAtIndex(int index); // 0x000000018D5AA898-0x000000018D5AA914
			private void ReleaseChildList(); // 0x000000018D5AA56C-0x000000018D5AA644
			public bool Equals(Hierarchy other); // 0x000000018D4B1ED0-0x000000018D4B1ED8
			public override bool Equals(object obj); // 0x000000018D5A9E54-0x000000018D5A9EC0
			public override int GetHashCode(); // 0x000000018AB02AA8-0x000000018AB02ACC
			public static bool operator ==(Hierarchy x, Hierarchy y); // 0x0000000184F9DDF0-0x0000000184F9DE00
		}
	
		private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem, IVisualElementPanelActivatable // TypeDefIndex: 71340
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private VisualElement _element_k__BackingField; // 0x38
			public bool isScheduled; // 0x40
			private VisualElementPanelActivator m_Activator; // 0x48
	
			// Properties
			public VisualElement element { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
			public bool isActive { get; } // 0x000000018D5A8E64-0x000000018D5A8E80 
	
			// Constructors
			protected BaseVisualElementScheduledItem(VisualElement handler); // 0x000000018D5A8DC4-0x000000018D5A8E64
	
			// Methods
			public IVisualElementScheduledItem StartingIn(long delayMs); // 0x0000000187262940-0x0000000187262950
			public IVisualElementScheduledItem Every(long intervalMs); // 0x000000018D5A8B88-0x000000018D5A8C24
			internal override void OnItemUnscheduled(); // 0x000000018D5A8C5C-0x000000018D5A8C8C
			public void Resume(); // 0x000000018D5A8DA0-0x000000018D5A8DC4
			public void Pause(); // 0x000000018D5A8D7C-0x000000018D5A8DA0
			public void ExecuteLater(long delayMs); // 0x000000018D5A8C24-0x000000018D5A8C5C
			public void OnPanelActivate(); // 0x000000018D5A8C8C-0x000000018D5A8D08
			public void OnPanelDeactivate(); // 0x000000018D5A8D08-0x000000018D5A8D7C
			public bool CanBeActivated(); // 0x000000018D5A8B4C-0x000000018D5A8B88
		}
	
		private abstract class VisualElementScheduledItem<ActionType> : BaseVisualElementScheduledItem // TypeDefIndex: 71341
		{
			// Fields
			public ActionType updateEvent;
	
			// Constructors
			public VisualElementScheduledItem(VisualElement handler, ActionType upEvent);
		}
	
		private class TimerStateScheduledItem : VisualElementScheduledItem<Action<UnityEngine.UIElements.TimerState>> // TypeDefIndex: 71342
		{
			// Constructors
			public TimerStateScheduledItem(VisualElement handler, Action<UnityEngine.UIElements.TimerState> updateEvent); // 0x000000018D5AC890-0x000000018D5AC8E8
	
			// Methods
			public override void PerformTimerUpdate(UnityEngine.UIElements.TimerState state); // 0x000000018D5AC85C-0x000000018D5AC890
		}
	
		private class SimpleScheduledItem : VisualElementScheduledItem<Action> // TypeDefIndex: 71343
		{
			// Constructors
			public SimpleScheduledItem(VisualElement handler, Action updateEvent); // 0x000000018D5ABD80-0x000000018D5ABDD8
	
			// Methods
			public override void PerformTimerUpdate(UnityEngine.UIElements.TimerState state); // 0x000000018D5ABD58-0x000000018D5ABD80
		}
	
		internal class CustomStyleAccess : ICustomStyle // TypeDefIndex: 71344
		{
			// Fields
			private Dictionary<string, StylePropertyValue> m_CustomProperties; // 0x10
			private float m_DpiScaling; // 0x18
	
			// Constructors
			public CustomStyleAccess(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void SetContext(Dictionary<string, StylePropertyValue> customProperties, float dpiScaling); // 0x0000000185C7AF30-0x0000000185C7AF50
			public bool TryGetValue(CustomStyleProperty<float> property, out float value); // 0x000000018D5A9568-0x000000018D5A9614
			public bool TryGetValue(CustomStyleProperty<int> property, out int value); // 0x000000018D5A92E4-0x000000018D5A9398
			public bool TryGetValue(CustomStyleProperty<UnityEngine.Color> property, out UnityEngine.Color value); // 0x000000018D5A91A0-0x000000018D5A92E4
			public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value); // 0x000000018D5A9398-0x000000018D5A94C0
			public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value); // 0x000000018D5A973C-0x000000018D5A9868
			public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value); // 0x000000018D5A9614-0x000000018D5A973C
			public bool TryGetValue(CustomStyleProperty<string> property, out string value); // 0x000000018D5A9868-0x000000018D5A9934
			private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp); // 0x000000018D5A94C0-0x000000018D5A9568
			private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp); // 0x000000018D5A90DC-0x000000018D5A91A0
		}
	
		private class TypeData // TypeDefIndex: 71345
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly System.Type _type_k__BackingField; // 0x10
			private string m_FullTypeName; // 0x18
			private string m_TypeName; // 0x20
	
			// Properties
			public System.Type type { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
			public string fullTypeName { get; } // 0x000000018D5FF120-0x000000018D5FF168 
			public string typeName { get; } // 0x000000018D5FF168-0x000000018D5FF210 
	
			// Constructors
			public TypeData(System.Type type); // 0x000000018D5FF0A0-0x000000018D5FF120
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass322_0 // TypeDefIndex: 71346
		{
			// Fields
			public VisualElement __4__this; // 0x10
			public StyleValues to; // 0x18
	
			// Constructors
			public __c__DisplayClass322_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal StyleValues _UnityEngine.UIElements.Experimental.ITransitionAnimations.Start_b__0(VisualElement e); // 0x000000018D5FF558-0x000000018D5FF580
		}
	
		// Constructors
		public VisualElement(); // 0x000000018D5B5C28-0x000000018D5B5F34
		static VisualElement(); // 0x000000018D5B5934-0x000000018D5B5C28
	
		// Methods
		private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem(); // 0x000000018D5B017C-0x000000018D5B01A0
		bool IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4510-0x000000018D5B4594
		bool IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4238-0x000000018D5B42B8
		bool IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4388-0x000000018D5B4458
		bool IStylePropertyAnimations.Start(StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B46E0-0x000000018D5B477C
		bool IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4238-0x000000018D5B42B8
		bool IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4998-0x000000018D5B4A4C
		bool IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4834-0x000000018D5B48D0
		bool IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B42B8-0x000000018D5B4388
		bool IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B48D0-0x000000018D5B4998
		bool IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4594-0x000000018D5B4630
		bool IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B477C-0x000000018D5B4834
		bool IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4458-0x000000018D5B4510
		bool IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D5B4630-0x000000018D5B46E0
		void IStylePropertyAnimations.CancelAnimation(StylePropertyId id); // 0x000000018D5B4158-0x000000018D5B41BC
		void IStylePropertyAnimations.CancelAllAnimations(); // 0x000000018D5B40E8-0x000000018D5B4158
		void IStylePropertyAnimations.UpdateAnimation(StylePropertyId id); // 0x000000018D5B4A4C-0x000000018D5B4AB8
		void IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds); // 0x000000018D5B41BC-0x000000018D5B4238
		internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0 /* Metadata: 0x026222E6 */); // 0x000000018D5B3524-0x000000018D5B3778
		internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to); // 0x000000018D5B3778-0x000000018D5B3828
		internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to); // 0x000000018D5B3828-0x000000018D5B38D8
		private float? GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0 /* Metadata: 0x026222E7 */); // 0x000000018D5AFBA0-0x000000018D5AFE24
		internal void MarkRenderHintsClean(); // 0x00000001872629C0-0x00000001872629D0
		internal void ClearManualLayout(); // 0x000000018D5AE914-0x000000018D5AEB34
		internal void UpdateBoundingBox(); // 0x000000018D5B4E3C-0x000000018D5B50B4
		internal void UpdateWorldBoundingBox(); // 0x000000018D5B52E8-0x000000018D5B5360
		internal void UpdateWorldTransform(); // 0x000000018D5B5654-0x000000018D5B57F8
		internal void UpdateWorldTransformInverse(); // 0x000000018D5B55E8-0x000000018D5B5654
		internal void EnsureWorldTransformAndClipUpToDate(); // 0x000000018D5AF058-0x000000018D5AF094
		private void UpdateWorldClip(); // 0x000000018D5B5360-0x000000018D5B55E8
		private Rect CombineClipRects(Rect rect, Rect parentRect); // 0x000000018D5AEB84-0x000000018D5AEC10
		private Rect SubstractBorderPadding(Rect worldRect); // 0x000000018D5B2FD4-0x000000018D5B31AC
		internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat); // 0x000000018D5AEC10-0x000000018D5AEDF4
		private void UpdateHoverPseudoState(); // 0x000000018D5B5220-0x000000018D5B52E8
		private void ChangeIMGUIContainerCount(int delta); // 0x000000018D5AE64C-0x000000018D5AE688
		protected override void ExecuteDefaultAction(EventBase evt); // 0x000000018D5AF094-0x000000018D5AF538
		internal virtual Rect GetTooltipRect(); // 0x000000018D5B01A0-0x000000018D5B01CC
		private void SetTooltip(TooltipEvent e); // 0x000000018D5B2D88-0x000000018D5B2E48
		public sealed override void Focus(); // 0x000000018D5AF804-0x000000018D5AF880
		internal void SetPanel(BaseVisualElementPanel p); // 0x000000018D5B2254-0x000000018D5B2B44
		private void WillChangePanel(BaseVisualElementPanel destinationPanel); // 0x000000018D5B57F8-0x000000018D5B5934
		private void HasChangedPanel(BaseVisualElementPanel prevPanel); // 0x000000018D5B01CC-0x000000018D5B03E8
		public sealed override void SendEvent(EventBase e); // 0x000000018D5B1CFC-0x000000018D5B1D18
		internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode); // 0x000000018D5B1D18-0x000000018D5B1D30
		internal void IncrementVersion(VersionChangeType changeType); // 0x000000018D5B0450-0x000000018D5B0470
		internal void InvokeHierarchyChanged(HierarchyChangeType changeType); // 0x000000018D5B06BC-0x000000018D5B06DC
		private bool SetEnabledFromHierarchyPrivate(bool state); // 0x000000018D5B1EB8-0x000000018D5B2190
		public void SetEnabled(bool value); // 0x000000018D5B2190-0x000000018D5B21A8
		private void PropagateEnabledToChildren(bool value); // 0x000000018D5B0C90-0x000000018D5B0D48
		public void MarkDirtyRepaint(); // 0x000000018D5B0760-0x000000018D5B0770
		internal void InvokeGenerateVisualContent(MeshGenerationContext mgc); // 0x000000018D5B0578-0x000000018D5B06BC
		internal void GetFullHierarchicalViewDataKey(StringBuilder key); // 0x000000018D5AFA1C-0x000000018D5AFAAC
		internal string GetFullHierarchicalViewDataKey(); // 0x000000018D5AF9A8-0x000000018D5AFA1C
		internal T GetOrCreateViewData<T>(object existing, string key)
			where T : class, new();
		internal void OverwriteFromViewData(object obj, string key); // 0x000000018D5B093C-0x000000018D5B0B28
		internal void SaveViewData(); // 0x000000018D5B1C8C-0x000000018D5B1CFC
		internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState); // 0x000000018D5B06DC-0x000000018D5B0760
		internal void OnViewDataReady(bool enablePersistence); // 0x000000018D5B08C8-0x000000018D5B08EC
		internal virtual void OnViewDataReady(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool ContainsPoint(Vector2 localPoint); // 0x000000018D5AEDF4-0x000000018D5AEE38
		private void AssignMeasureFunction(); // 0x000000018D5AD604-0x000000018D5AD698
		private void RemoveMeasureFunction(); // 0x000000018D5B16CC-0x000000018D5B16F0
		protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode); // 0x00000001872629A0-0x00000001872629C0
		internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode); // 0x000000018D5B0780-0x000000018D5B08B8
		private void FinalizeLayout(); // 0x000000018D5AF538-0x000000018D5AF598
		internal void SetInlineRule(StyleSheet sheet, StyleRule rule); // 0x000000018D5B21A8-0x000000018D5B2254
		internal void SetComputedStyle(ref ComputedStyle newStyle); // 0x000000018D5B1D9C-0x000000018D5B1EB8
		public override string ToString(); // 0x000000018D5B31AC-0x000000018D5B3308
		internal List<string> GetClassesForIteration(); // 0x0000000187261E60-0x0000000187261E70
		public void AddToClassList(string className); // 0x000000018D5AD3CC-0x000000018D5AD540
		public void RemoveFromClassList(string className); // 0x000000018D5B156C-0x000000018D5B1660
		public void EnableInClassList(string className, bool enable); // 0x000000018D5AF034-0x000000018D5AF058
		public bool ClassListContains(string cls); // 0x000000018D5AE878-0x000000018D5AE914
		internal object GetProperty(PropertyName key); // 0x000000018D5B008C-0x000000018D5B00F8
		internal void SetProperty(PropertyName key, object value); // 0x000000018D5B2D20-0x000000018D5B2D88
		internal bool HasProperty(PropertyName key); // 0x000000018D5B03E8-0x000000018D5B0450
		private bool TryGetPropertyInternal(PropertyName key, out object value); // 0x000000018D5B38D8-0x000000018D5B39DC
		private static void CheckUserKeyArgument(PropertyName key); // 0x000000018D5AE688-0x000000018D5AE7E0
		private void SetPropertyInternal(PropertyName key, object value); // 0x000000018D5B2B44-0x000000018D5B2D20
		private void UpdateCursorStyle(long eventType); // 0x000000018D5B50B4-0x000000018D5B5220
		private VisualElementAnimationSystem GetAnimationSystem(); // 0x000000018D5AF940-0x000000018D5AF9A8
		internal void RegisterAnimation(IValueAnimationUpdate anim); // 0x000000018D5B1430-0x000000018D5B1508
		internal void UnregisterAnimation(IValueAnimationUpdate anim); // 0x000000018D5B4D5C-0x000000018D5B4DD0
		private void UnregisterRunningAnimations(); // 0x000000018D5B4DD0-0x000000018D5B4E3C
		private void RegisterRunningAnimations(); // 0x000000018D5B1508-0x000000018D5B156C
		private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged);
		private static void AssignStyleValues(VisualElement ve, StyleValues src); // 0x000000018D5AD698-0x000000018D5AE324
		private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead); // 0x000000018D5B0D48-0x000000018D5B1430
		ValueAnimation<StyleValues> ITransitionAnimations.Start(StyleValues to, int durationMs); // 0x000000018D5B39EC-0x000000018D5B3ACC
		private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs); // 0x000000018D5B2E78-0x000000018D5B2FD4
		internal bool ShouldClip(); // 0x000000018D5B2E48-0x000000018D5B2E78
		public void Add(VisualElement child); // 0x000000018D5AD540-0x000000018D5AD604
		public void Insert(int index, VisualElement element); // 0x000000018D5B04E0-0x000000018D5B0578
		public void Clear(); // 0x000000018D5AEB34-0x000000018D5AEB84
		public VisualElement ElementAt(int index); // 0x000000018D5AF028-0x000000018D5AF034
		public int IndexOf(VisualElement element); // 0x000000018D5B0470-0x000000018D5B04E0
		internal VisualElement ElementAtTreePath(List<int> childIndexes); // 0x000000018D5AEEA4-0x000000018D5AF028
		internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes); // 0x000000018D5AF71C-0x000000018D5AF804
		public IEnumerable<VisualElement> Children(); // 0x000000018D5AE7E0-0x000000018D5AE878
		public void BringToFront(); // 0x000000018D5AE324-0x000000018D5AE390
		public void SendToBack(); // 0x000000018D5B1D30-0x000000018D5B1D9C
		public void PlaceBehind(VisualElement sibling); // 0x000000018D5B0B28-0x000000018D5B0C90
		public void RemoveFromHierarchy(); // 0x000000018D5B1660-0x000000018D5B16CC
		public T GetFirstOfType<T>()
			where T : class;
		public T GetFirstAncestorOfType<T>()
			where T : class;
		public bool Contains(VisualElement child); // 0x000000018D5AEE38-0x000000018D5AEEA4
		private void GatherAllChildren(List<VisualElement> elements); // 0x000000018D5AF880-0x000000018D5AF940
		public VisualElement FindCommonAncestor(VisualElement other); // 0x000000018D5AF598-0x000000018D5AF71C
		internal VisualElement GetRoot(); // 0x000000018D5B0138-0x000000018D5B017C
		internal VisualElement GetRootVisualContainer(); // 0x000000018D5B00F8-0x000000018D5B0138
		internal VisualElement GetNextElementDepthFirst(); // 0x000000018D5AFAAC-0x000000018D5AFBA0
		internal VisualElement GetPreviousElementDepthFirst(); // 0x000000018D5AFFAC-0x000000018D5B008C
		internal VisualElement RetargetElement(VisualElement retargetAgainst); // 0x000000018D5B1C18-0x000000018D5B1C8C
		internal void GetPivotedMatrixWithLayout(out Matrix4x4 result); // 0x000000018D5AFE24-0x000000018D5AFFAC
		internal static float Min(float a, float b, float c, float d); // 0x000000018D5B08B8-0x000000018D5B08C8
		internal static float Max(float a, float b, float c, float d); // 0x000000018D5B0770-0x000000018D5B0780
		private void TransformAlignedRectToParentSpace(ref Rect rect); // 0x000000018D5B3308-0x000000018D5B3424
		internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect); // 0x000000018D5AE390-0x000000018D5AE64C
		internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect); // 0x000000018D5B3424-0x000000018D5B3498
		internal static void OrderMinMaxRect(ref Rect rect); // 0x000000018D5B08EC-0x000000018D5B093C
		internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point); // 0x0000000187262C00-0x0000000187262C50
		internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector); // 0x0000000187262C50-0x0000000187262C90
		internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res); // 0x00000001872629D0-0x0000000187262C00
		private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res); // 0x000000018D5B3498-0x000000018D5B3524
		private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs); // 0x000000018725E710-0x000000018725E7A0
		IVisualElementScheduledItem IVisualElementScheduler.Execute(Action<UnityEngine.UIElements.TimerState> timerUpdateEvent); // 0x000000018D5B4BFC-0x000000018D5B4CAC
		IVisualElementScheduledItem IVisualElementScheduler.Execute(Action updateEvent); // 0x000000018D5B4CAC-0x000000018D5B4D5C
		internal void AddStyleSheetPath(string sheetPath); // 0x000000018D5AD230-0x000000018D5AD3CC
		private StyleFloat ResolveLengthValue(Length length, bool isRow); // 0x000000018D5B16F0-0x000000018D5B17F0
		private Vector3 ResolveTranslate(); // 0x000000018D5B1ACC-0x000000018D5B1C18
		private Vector3 ResolveTransformOrigin(); // 0x000000018D5B194C-0x000000018D5B1ACC
		private Quaternion ResolveRotation(); // 0x000000018D5B17F0-0x000000018D5B18B0
		private Vector3 ResolveScale(); // 0x000000018D5B18B0-0x000000018D5B194C
		[CompilerGenerated]
		private YogaSize _AssignMeasureFunction_b__262_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode); // 0x000000018D5B39DC-0x000000018D5B39EC
	}

	internal interface IStylePropertyAnimationSystem // TypeDefIndex: 71348
	{
		// Methods
		bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		void CancelAllAnimations();
		void CancelAllAnimations(VisualElement owner);
		void CancelAnimation(VisualElement owner, StylePropertyId id);
		void UpdateAnimation(VisualElement owner, StylePropertyId id);
		void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds);
		void Update();
	}

	internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem // TypeDefIndex: 71373
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
		[Flags]
		private enum TransitionState // TypeDefIndex: 71349
		{
			None = 0,
			Running = 1,
			Started = 2,
			Ended = 4,
			Canceled = 8
		}
	
		private struct AnimationDataSet<TTimingData, TStyleData> // TypeDefIndex: 71350
		{
			// Fields
			public VisualElement[] elements;
			public StylePropertyId[] properties;
			public TTimingData[] timing;
			public TStyleData[] style;
			public int count;
			private Dictionary<ElementPropertyPair, int> indices;
	
			// Properties
			private int capacity { get; set; }
	
			// Methods
			private void LocalInit();
			public static AnimationDataSet<TTimingData, TStyleData> Create();
			public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index);
			public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData);
			public void Remove(int cancelledIndex);
			public void Replace(int index, TTimingData timingData, TStyleData styleData);
			public void RemoveAll(VisualElement ve);
			public void RemoveAll();
			public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties);
		}
	
		private struct ElementPropertyPair // TypeDefIndex: 71352
		{
			// Fields
			public static readonly IEqualityComparer<ElementPropertyPair> Comparer; // 0x00
			public readonly VisualElement element; // 0x00
			public readonly StylePropertyId property; // 0x08
	
			// Nested types
			private class EqualityComparer : IEqualityComparer<ElementPropertyPair> // TypeDefIndex: 71351
			{
				// Constructors
				public EqualityComparer(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				public bool Equals(ElementPropertyPair x, ElementPropertyPair y); // 0x000000018D5FC03C-0x000000018D5FC054
				public int GetHashCode(ElementPropertyPair obj); // 0x000000018D5FC054-0x000000018D5FC084
			}
	
			// Constructors
			public ElementPropertyPair(VisualElement element, StylePropertyId property); // 0x000000018783B33C-0x000000018783B358
			static ElementPropertyPair(); // 0x000000018D5FBFCC-0x000000018D5FC03C
		}
	
		private abstract class Values // TypeDefIndex: 71353
		{
			// Constructors
			protected Values(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public abstract void CancelAllAnimations();
			public abstract void CancelAllAnimations(VisualElement ve);
			public abstract void CancelAnimation(VisualElement ve, StylePropertyId id);
			public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id);
			public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds);
			public abstract void Update(long currentTimeMs);
			protected abstract void UpdateValues();
			protected abstract void UpdateComputedStyle();
			protected abstract void UpdateComputedStyle(int i);
		}
	
		private abstract class Values<T> : Values // TypeDefIndex: 71359
		{
			// Fields
			private long m_CurrentTimeMs;
			private TransitionEventsFrameState m_CurrentFrameEventsState;
			private TransitionEventsFrameState m_NextFrameEventsState;
			public AnimationDataSet<TimingData, StyleData> running;
			public AnimationDataSet<EmptyData, T> completed;
	
			// Properties
			public bool isEmpty { get; }
			public abstract Func<T, T, bool> SameFunc { get; }
	
			// Nested types
			private class TransitionEventsFrameState // TypeDefIndex: 71355
			{
				// Fields
				private static readonly ObjectPool<Queue<EventBase>> k_EventQueuePool;
				public readonly Dictionary<ElementPropertyPair, TransitionState> elementPropertyStateDelta;
				public readonly Dictionary<ElementPropertyPair, Queue<EventBase>> elementPropertyQueuedEvents;
				public IPanel panel;
				private int m_ChangesCount;
	
				// Nested types
				[Serializable]
				[CompilerGenerated]
				private sealed class __c // TypeDefIndex: 71354
				{
					// Fields
					public static readonly __c<T> __9;
	
					// Constructors
					static __c();
					public __c();
	
					// Methods
					internal Queue<EventBase> _.cctor_b__11_0();
				}
	
				// Constructors
				public TransitionEventsFrameState();
				static TransitionEventsFrameState();
	
				// Methods
				public static Queue<EventBase> GetPooledQueue();
				public void RegisterChange();
				public void UnregisterChange();
				public bool StateChanged();
				public void Clear();
			}
	
			public struct TimingData // TypeDefIndex: 71356
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
	
			public struct StyleData // TypeDefIndex: 71357
			{
				// Fields
				public T startValue;
				public T endValue;
				public T reversingAdjustedStartValue;
				public T currentValue;
			}
	
			public struct EmptyData // TypeDefIndex: 71358
			{
				// Fields
				public static EmptyData<T> Default;
	
				// Constructors
				static EmptyData();
			}
	
			// Constructors
			protected Values();
	
			// Methods
			protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref ref T a, ref ref T b);
			private void SwapFrameStates();
			private void QueueEvent(EventBase evt, ElementPropertyPair epp);
			private void ClearEventQueue(ElementPropertyPair epp);
			private void QueueTransitionRunEvent(VisualElement ve, int runningIndex);
			private void QueueTransitionStartEvent(VisualElement ve, int runningIndex);
			private void QueueTransitionEndEvent(VisualElement ve, int runningIndex);
			private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs);
			private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs);
			public sealed override void CancelAllAnimations();
			public sealed override void CancelAllAnimations(VisualElement ve);
			public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id);
			public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id);
			public sealed override void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds);
			private float ComputeReversingShorteningFactor(int oldIndex);
			private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor);
			private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor);
			public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, long currentTimeMs);
			private void ForceComputedStyleEndValue(int runningIndex);
			public sealed override void Update(long currentTimeMs);
			private void ProcessEventQueue();
			private void UpdateProgress(long currentTimeMs);
		}
	
		private class ValuesFloat : Values<float> // TypeDefIndex: 71360
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<float, float, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<float, float, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesFloat(); // 0x000000018D604264-0x000000018D604300
	
			// Methods
			private static bool IsSame(float a, float b); // 0x00000001850277D0-0x0000000185027A80
			private static float Lerp(float a, float b, float t); // 0x0000000187260830-0x0000000187260850
			protected sealed override void UpdateValues(); // 0x000000018D6041E8-0x000000018D604264
			protected sealed override void UpdateComputedStyle(); // 0x000000018D604088-0x000000018D604150
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D604150-0x000000018D6041E8
		}
	
		private class ValuesInt : Values<int> // TypeDefIndex: 71361
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<int, int, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<int, int, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesInt(); // 0x000000018D604844-0x000000018D6048E0
	
			// Methods
			private static bool IsSame(int a, int b); // 0x0000000189CCDE30-0x0000000189CCDE38
			private static int Lerp(int a, int b, float t); // 0x000000018D604640-0x000000018D604660
			protected sealed override void UpdateValues(); // 0x000000018D6047BC-0x000000018D604844
			protected sealed override void UpdateComputedStyle(); // 0x000000018D6046F8-0x000000018D6047BC
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D604660-0x000000018D6046F8
		}
	
		private class ValuesLength : Values<Length> // TypeDefIndex: 71362
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<Length, Length, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<Length, Length, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesLength(); // 0x000000018D604BBC-0x000000018D604C58
	
			// Methods
			private static bool IsSame(Length a, Length b); // 0x000000018D60491C-0x000000018D60498C
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b); // 0x000000018D6048E0-0x000000018D60491C
			internal static Length Lerp(Length a, Length b, float t); // 0x000000018D60498C-0x000000018D6049D4
			protected sealed override void UpdateValues(); // 0x000000018D604B30-0x000000018D604BBC
			protected sealed override void UpdateComputedStyle(); // 0x000000018D6049D4-0x000000018D604A98
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D604A98-0x000000018D604B30
		}
	
		private class ValuesColor : Values<UnityEngine.Color> // TypeDefIndex: 71363
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<UnityEngine.Color, UnityEngine.Color, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<UnityEngine.Color, UnityEngine.Color, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesColor(); // 0x000000018D603FEC-0x000000018D604088
	
			// Methods
			private static bool IsSame(UnityEngine.Color c, UnityEngine.Color d); // 0x000000018D603C88-0x000000018D603D84
			private static UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t); // 0x000000018D603D84-0x000000018D603DC0
			protected sealed override void UpdateValues(); // 0x000000018D603F38-0x000000018D603FEC
			protected sealed override void UpdateComputedStyle(); // 0x000000018D603E68-0x000000018D603F38
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D603DC0-0x000000018D603E68
		}
	
		private abstract class ValuesDiscrete<T> : Values<T> // TypeDefIndex: 71364
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<T, T, bool> _SameFunc_k__BackingField;
	
			// Properties
			public override Func<T, T, bool> SameFunc { [CompilerGenerated] get; }
	
			// Constructors
			protected ValuesDiscrete();
	
			// Methods
			private static bool IsSame(T a, T b);
			private static T Lerp(T a, T b, float t);
			protected sealed override void UpdateValues();
		}
	
		private class ValuesBackground : ValuesDiscrete<Background> // TypeDefIndex: 71365
		{
			// Constructors
			public ValuesBackground(); // 0x000000018D603C4C-0x000000018D603C88
	
			// Methods
			protected sealed override void UpdateComputedStyle(); // 0x000000018D603B6C-0x000000018D603C4C
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D603ABC-0x000000018D603B6C
		}
	
		private class ValuesFontDefinition : ValuesDiscrete<FontDefinition> // TypeDefIndex: 71366
		{
			// Constructors
			public ValuesFontDefinition(); // 0x000000018D604478-0x000000018D6044B4
	
			// Methods
			protected sealed override void UpdateComputedStyle(); // 0x000000018D6043A8-0x000000018D604478
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D604300-0x000000018D6043A8
		}
	
		private class ValuesFont : ValuesDiscrete<Font> // TypeDefIndex: 71367
		{
			// Constructors
			public ValuesFont(); // 0x000000018D604604-0x000000018D604640
	
			// Methods
			protected sealed override void UpdateComputedStyle(); // 0x000000018D604538-0x000000018D604604
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D6044B4-0x000000018D604538
		}
	
		private class ValuesTextShadow : Values<TextShadow> // TypeDefIndex: 71368
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<TextShadow, TextShadow, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<TextShadow, TextShadow, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesTextShadow(); // 0x000000018D605724-0x000000018D6057C0
	
			// Methods
			private static bool IsSame(TextShadow a, TextShadow b); // 0x000000018D6053B4-0x000000018D605404
			private static TextShadow Lerp(TextShadow a, TextShadow b, float t); // 0x000000018D605404-0x000000018D605484
			protected sealed override void UpdateValues(); // 0x000000018D60562C-0x000000018D605724
			protected sealed override void UpdateComputedStyle(); // 0x000000018D605540-0x000000018D60562C
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D605484-0x000000018D605540
		}
	
		private class ValuesScale : Values<Scale> // TypeDefIndex: 71369
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<Scale, Scale, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<Scale, Scale, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesScale(); // 0x000000018D605318-0x000000018D6053B4
	
			// Methods
			private static bool IsSame(Scale a, Scale b); // 0x000000018D605050-0x000000018D60507C
			protected sealed override void UpdateComputedStyle(); // 0x000000018D605198-0x000000018D605268
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D6050F0-0x000000018D605198
			private static Scale Lerp(Scale a, Scale b, float t); // 0x000000018D60507C-0x000000018D6050F0
			protected sealed override void UpdateValues(); // 0x000000018D605268-0x000000018D605318
		}
	
		private class ValuesRotate : Values<Rotate> // TypeDefIndex: 71370
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<Rotate, Rotate, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<Rotate, Rotate, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesRotate(); // 0x000000018D604FB4-0x000000018D605050
	
			// Methods
			private static bool IsSame(Rotate a, Rotate b); // 0x000000018D604C58-0x000000018D604C9C
			protected sealed override void UpdateComputedStyle(); // 0x000000018D604DF0-0x000000018D604ED4
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D604D40-0x000000018D604DF0
			private static Rotate Lerp(Rotate a, Rotate b, float t); // 0x000000018D604C9C-0x000000018D604D40
			protected sealed override void UpdateValues(); // 0x000000018D604ED4-0x000000018D604FB4
		}
	
		private class ValuesTranslate : Values<Translate> // TypeDefIndex: 71371
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<Translate, Translate, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<Translate, Translate, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesTranslate(); // 0x000000018D605F28-0x000000018D605FC4
	
			// Methods
			private static bool IsSame(Translate a, Translate b); // 0x000000018D605BD8-0x000000018D605C1C
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b); // 0x000000018D605BAC-0x000000018D605BD8
			protected sealed override void UpdateComputedStyle(); // 0x000000018D605D64-0x000000018D605E48
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D605CB4-0x000000018D605D64
			private static Translate Lerp(Translate a, Translate b, float t); // 0x000000018D605C1C-0x000000018D605CB4
			protected sealed override void UpdateValues(); // 0x000000018D605E48-0x000000018D605F28
		}
	
		private class ValuesTransformOrigin : Values<TransformOrigin> // TypeDefIndex: 71372
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<TransformOrigin, TransformOrigin, bool> _SameFunc_k__BackingField; // 0x88
	
			// Properties
			public override Func<TransformOrigin, TransformOrigin, bool> SameFunc { [CompilerGenerated] get; } // 0x0000000187232F50-0x0000000187232F60 
	
			// Constructors
			public ValuesTransformOrigin(); // 0x000000018D605B10-0x000000018D605BAC
	
			// Methods
			private static bool IsSame(TransformOrigin a, TransformOrigin b); // 0x000000018D6057EC-0x000000018D605828
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b); // 0x000000018D6057C0-0x000000018D6057EC
			protected sealed override void UpdateComputedStyle(); // 0x000000018D605960-0x000000018D605A40
			protected sealed override void UpdateComputedStyle(int i); // 0x000000018D6058B4-0x000000018D605960
			private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t); // 0x000000018D605828-0x000000018D6058B4
			protected sealed override void UpdateValues(); // 0x000000018D605A40-0x000000018D605B10
		}
	
		// Constructors
		public StylePropertyAnimationSystem(); // 0x000000018D5FD93C-0x000000018D5FDA2C
	
		// Methods
		private T GetOrCreate<T>(ref ref T values)
			where T : new();
		private bool StartTransition<T>(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, Values<T> values);
		public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FD494-0x000000018D5FD558
		public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FD1C8-0x000000018D5FD288
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FCF34-0x000000018D5FCFF8
		public bool StartTransition(VisualElement owner, StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FCFF8-0x000000018D5FD0D4
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FCD60-0x000000018D5FCE58
		public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FCE58-0x000000018D5FCF34
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FD634-0x000000018D5FD6F8
		public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FD384-0x000000018D5FD494
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FD558-0x000000018D5FD634
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FD288-0x000000018D5FD384
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FD6F8-0x000000018D5FD7F4
		public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve); // 0x000000018D5FD0D4-0x000000018D5FD1C8
		public void CancelAllAnimations(); // 0x000000018D5FC8C4-0x000000018D5FC9E8
		public void CancelAllAnimations(VisualElement owner); // 0x000000018D5FC9E8-0x000000018D5FCB74
		public void CancelAnimation(VisualElement owner, StylePropertyId id); // 0x000000018D5FCB74-0x000000018D5FCC04
		public void UpdateAnimation(VisualElement owner, StylePropertyId id); // 0x000000018D5FD7F4-0x000000018D5FD884
		public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds); // 0x000000018D5FCC04-0x000000018D5FCD60
		private void UpdateTracking<T>(Values<T> values);
		private long CurrentTimeMs(); // 0x0000000187249840-0x0000000187249850
		public void Update(); // 0x000000018D5FD884-0x000000018D5FD93C
	}

	public struct StylePropertyName : IEquatable<StylePropertyName> // TypeDefIndex: 71374
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly StylePropertyId _id_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _name_k__BackingField; // 0x08
	
		// Properties
		internal StylePropertyId id { [IsReadOnly] [CompilerGenerated] get; } // 0x00000001844AD290-0x00000001844AD2A0 
		private string name { [CompilerGenerated] [IsReadOnly] get; } // 0x00000001844AFA30-0x00000001844AFA40 
	
		// Constructors
		internal StylePropertyName(StylePropertyId stylePropertyId); // 0x000000018D5FDB68-0x000000018D5FDC18
		public StylePropertyName(string name); // 0x000000018D5FDB1C-0x000000018D5FDB68
	
		// Methods
		internal static StylePropertyId StylePropertyIdFromString(string name); // 0x000000018D5FDA98-0x000000018D5FDB1C
		public static bool operator ==(StylePropertyName lhs, StylePropertyName rhs); // 0x000000018D5FDC18-0x000000018D5FDC20
		public static bool operator !=(StylePropertyName lhs, StylePropertyName rhs); // 0x000000018D5FDC54-0x000000018D5FDC5C
		public static implicit operator StylePropertyName(string name); // 0x000000018D5FDC20-0x000000018D5FDC54
		public override int GetHashCode(); // 0x000000018725FD00-0x000000018725FD10
		public override bool Equals(object other); // 0x000000018D5FDA2C-0x000000018D5FDA90
		public bool Equals(StylePropertyName other); // 0x000000018D5FDA90-0x000000018D5FDA98
		public override string ToString(); // 0x000000018725FF40-0x000000018725FF50
	}

	public class TemplateContainer : BindableElement // TypeDefIndex: 71377
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _templateId_k__BackingField; // 0x3D0
		private VisualElement m_ContentContainer; // 0x3D8
		private VisualTreeAsset m_TemplateSource; // 0x3E0
	
		// Properties
		public string templateId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723A1D0-0x000000018723A1E0 0x0000000188DC4D68-0x0000000188DC4D7C
		internal VisualTreeAsset templateSource { set; } // 0x0000000188DC4B60-0x0000000188DC4B74
		public override VisualElement contentContainer { get; } // 0x0000000187263010-0x0000000187263020 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits> // TypeDefIndex: 71375
		{
			// Properties
			public override string uxmlName { get; } // 0x000000018D6033A0-0x000000018D6033CC 
			public override string uxmlQualifiedName { get; } // 0x000000018D6033CC-0x000000018D603440 
	
			// Constructors
			public UxmlFactory(); // 0x000000018D603364-0x000000018D6033A0
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 71376
		{
			// Fields
			private UxmlStringAttributeDescription m_Template; // 0x78
	
			// Constructors
			public UxmlTraits(); // 0x000000018D603A24-0x000000018D603ABC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D603440-0x000000018D603788
		}
	
		// Constructors
		public TemplateContainer(); // 0x000000018D5FDCA4-0x000000018D5FDCB0
		public TemplateContainer(string templateId); // 0x000000018D5FDC5C-0x000000018D5FDCA4
	
		// Methods
		internal void SetContentContainer(VisualElement content); // 0x0000000188DC4B74-0x0000000188DC4B88
	}

	internal interface ITextElement // TypeDefIndex: 71378
	{
		// Properties
		string text { get; }
	}

	public class TextElement : BindableElement, ITextElement, INotifyValueChanged<string> // TypeDefIndex: 71381
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private ITextHandle m_TextHandle; // 0x3D0
		internal static int maxTextVertices; // 0x08
		[SerializeField]
		private string m_Text; // 0x3D8
		private bool m_EnableRichText; // 0x3E0
		private bool m_DisplayTooltipWhenElided; // 0x3E1
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isElided_k__BackingField; // 0x3E2
		internal static readonly string k_EllipsisText; // 0x10
		private bool m_WasElided; // 0x3E3
		private bool m_UpdateTextParams; // 0x3E4
		private MeshGenerationContextUtils.TextParams m_TextParams; // 0x3E8
		private int m_PreviousTextParamsHashCode; // 0x480
	
		// Properties
		internal ITextHandle textHandle { get; set; } // 0x0000000187263050-0x0000000187263060 0x0000000188DC4D68-0x0000000188DC4D7C
		public virtual string text { get; set; } // 0x000000018D5FEB7C-0x000000018D5FEBB8 0x000000018D5FEC04-0x000000018D5FEC54
		public bool enableRichText { get; set; } // 0x0000000187263030-0x0000000187263040 0x000000018D5FEBE8-0x000000018D5FEC04
		public bool displayTooltipWhenElided { get; set; } // 0x0000000187263020-0x0000000187263030 0x000000018D5FEBB8-0x000000018D5FEBE8
		public bool isElided { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187263040-0x0000000187263050 0x0000000187263060-0x0000000187263070
		string UnityEngine.UIElements.INotifyValueChanged<System.String>.value { get; set; } // 0x000000018D5FE4E0-0x000000018D5FE528 0x000000018D5FE528-0x000000018D5FE688
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TextElement, UxmlTraits> // TypeDefIndex: 71379
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D603328-0x000000018D603364
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 71380
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
			private UxmlBoolAttributeDescription m_EnableRichText; // 0x80
			private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; // 0x88
	
			// Constructors
			public UxmlTraits(); // 0x000000018D6038D0-0x000000018D603A24
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D603788-0x000000018D6038D0
		}
	
		// Constructors
		public TextElement(); // 0x000000018D5FE9D0-0x000000018D5FEB7C
		static TextElement(); // 0x000000018D5FE8FC-0x000000018D5FE9D0
	
		// Methods
		public override void HandleEvent(EventBase evt); // 0x000000018D5FE0E0-0x000000018D5FE224
		private void OnGeometryChanged(GeometryChangedEvent e); // 0x000000018D5FE3DC-0x000000018D5FE3E4
		private void OnGenerateVisualContent(MeshGenerationContext mgc); // 0x000000018D5FE25C-0x000000018D5FE3DC
		internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition); // 0x000000018D5FDD18-0x000000018D5FE0E0
		private void UpdateTooltip(); // 0x000000018D5FE688-0x000000018D5FE6E4
		private void UpdateVisibleText(); // 0x000000018D5FE6E4-0x000000018D5FE8FC
		private bool ShouldElide(); // 0x000000018D5FE3E4-0x000000018D5FE434
		private bool TextLibraryCanElide(); // 0x000000018D5FE434-0x000000018D5FE474
		public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode); // 0x000000018D5FE224-0x000000018D5FE25C
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode); // 0x000000018D5FDCB0-0x000000018D5FDD18
		void INotifyValueChanged<string>.SetValueWithoutNotify(string newValue); // 0x000000018D5FE474-0x000000018D5FE4E0
	}

	public struct TextShadow : IEquatable<TextShadow> // TypeDefIndex: 71382
	{
		// Fields
		public Vector2 offset; // 0x00
		public float blurRadius; // 0x08
		public UnityEngine.Color color; // 0x0C
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D5FEC54-0x000000018D5FECE0
		public bool Equals(TextShadow other); // 0x000000018D5FECE0-0x000000018D5FED90
		public override int GetHashCode(); // 0x000000018D5FED90-0x000000018D5FEDDC
		public static bool operator ==(TextShadow style1, TextShadow style2); // 0x000000018D5FF01C-0x000000018D5FF04C
		public static bool operator !=(TextShadow style1, TextShadow style2); // 0x000000018D5FF04C-0x000000018D5FF0A0
		public override string ToString(); // 0x000000018D5FEF44-0x000000018D5FF01C
		internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t); // 0x000000018D5FEDDC-0x000000018D5FEF44
	}

	internal static class UIElementsPackageUtility // TypeDefIndex: 71383
	{
		// Fields
		internal static readonly string EditorResourcesBasePath; // 0x00
		internal static readonly bool IsUIEPackageLoaded; // 0x08
	
		// Constructors
		static UIElementsPackageUtility(); // 0x000000018D5FF648-0x000000018D5FF6B8
	}

	internal static class UIElementsRuntimeUtility // TypeDefIndex: 71386
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<BaseRuntimePanel> onCreatePanel; // 0x00
		private static bool s_RegisteredPlayerloopCallback; // 0x08
		private static List<UnityEngine.UIElements.Panel> s_SortedRuntimePanels; // 0x10
		private static bool s_PanelOrderingDirty; // 0x18
		internal static readonly string s_RepaintProfilerMarkerName; // 0x20
		private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x28
		private static int currentOverlayIndex; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityEngine.Object _activeEventSystem_k__BackingField; // 0x38
		private static DefaultEventSystem s_DefaultEventSystem; // 0x40
		private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; // 0x48
	
		// Properties
		internal static UnityEngine.Object activeEventSystem { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D600890-0x000000018D6008E0 0x000000018D600AB8-0x000000018D600B18
		internal static bool useDefaultEventSystem { get; } // 0x000000018D600994-0x000000018D6009F4 
		internal static DefaultEventSystem defaultEventSystem { get; } // 0x000000018D6008E0-0x000000018D600994 
	
		// Events
		public static event Action<BaseRuntimePanel> onCreatePanel {
			add; // 0x0000000186B32740-0x0000000186B32820
			remove; // 0x000000018D6009F4-0x000000018D600AB8
		}
	
		// Nested types
		public delegate BaseRuntimePanel CreateRuntimePanelDelegate(ScriptableObject ownerObject); // TypeDefIndex: 71384; 0x0000000185B78EA0-0x0000000185B78EB0
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71385
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<UnityEngine.UIElements.Panel> __9__47_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E6380-0x00000001871E63E0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.cctor_b__9_0(); // 0x0000000186805BA0-0x0000000186805BB0
			internal void _.cctor_b__9_1(int displayIndex, int sortOrder); // 0x000000018D5FF504-0x000000018D5FF558
			internal int _SortPanels_b__47_0(UnityEngine.UIElements.Panel a, UnityEngine.UIElements.Panel b); // 0x000000018D5FF254-0x000000018D5FF360
		}
	
		// Constructors
		static UIElementsRuntimeUtility(); // 0x000000018683B5B0-0x000000018683BA20
	
		// Methods
		public static EventBase CreateEvent(UnityEngine.Event systemEvent); // 0x000000018D5FF70C-0x000000018D5FF770
		public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate); // 0x000000018D5FF884-0x000000018D5FFA10
		public static void DisposeRuntimePanel(ScriptableObject ownerObject); // 0x000000018D5FF770-0x000000018D5FF824
		private static void RegisterCachedPanelInternal(int instanceID, IPanel panel); // 0x000000018D5FFC78-0x000000018D5FFD48
		private static void RemoveCachedPanelInternal(int instanceID); // 0x000000018D5FFDE8-0x000000018D5FFEF4
		public static void RepaintOffscreenPanels(); // 0x000000018D600210-0x000000018D6003B0
		public static void RepaintOverlayPanel(BaseRuntimePanel panel); // 0x000000018D6003B0-0x000000018D6004EC
		internal static void BeginRenderOverlays(int displayIndex); // 0x000000018D5FF6B8-0x000000018D5FF70C
		internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority); // 0x000000018D6000A8-0x000000018D600210
		internal static void EndRenderOverlays(int displayIndex); // 0x000000018D5FF824-0x000000018D5FF884
		public static void RegisterEventSystem(UnityEngine.Object eventSystem); // 0x0000000186B31ED0-0x0000000186B32090
		public static void UnregisterEventSystem(UnityEngine.Object eventSystem); // 0x000000018D600600-0x000000018D600688
		public static void UpdateRuntimePanels(); // 0x000000018D6006E0-0x000000018D600890
		internal static void MarkPotentiallyEmpty(PanelSettings settings); // 0x000000018D5FFA10-0x000000018D5FFAC4
		internal static void RemoveUnusedPanels(); // 0x000000018D5FFEF4-0x000000018D6000A8
		public static void RegisterPlayerloopCallback(); // 0x000000018D5FFD48-0x000000018D5FFDE8
		public static void UnregisterPlayerloopCallback(); // 0x000000018D600688-0x000000018D6006E0
		internal static void SetPanelOrderingDirty(); // 0x000000018D6005B0-0x000000018D600600
		internal static List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels(); // 0x0000000186B32630-0x0000000186B326D0
		private static void SortPanels(); // 0x0000000186B32940-0x0000000186B32B40
		internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int? targetDisplay); // 0x000000018D5FFAC4-0x000000018D5FFB34
		internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out int? targetDisplay); // 0x000000018D5FFB34-0x000000018D5FFC78
		internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay); // 0x000000018D6004EC-0x000000018D6005B0
		internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta); // 0x0000000187263070-0x0000000187263090
	}

	internal interface IUIElementsUtility // TypeDefIndex: 71387
	{
		// Methods
		bool TakeCapture();
		bool ReleaseCapture();
		bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled);
		bool CleanupRoots();
		bool EndContainerGUIFromException(Exception exception);
		bool MakeCurrentIMGUIContainerDirty();
	}

	internal static class UIEventRegistration // TypeDefIndex: 71389
	{
		// Fields
		private static List<IUIElementsUtility> s_Utilities; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71388
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x00000001871E7940-0x00000001871E79A0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.cctor_b__1_0(); // 0x000000018D5FF360-0x000000018D5FF3A0
			internal void _.cctor_b__1_1(); // 0x000000018D5FF3A0-0x000000018D5FF3E0
			internal bool _.cctor_b__1_2(int i, IntPtr ptr); // 0x000000018D5FF3E0-0x000000018D5FF438
			internal void _.cctor_b__1_3(); // 0x000000018D5FF438-0x000000018D5FF478
			internal bool _.cctor_b__1_4(Exception exception); // 0x000000018D5FF478-0x000000018D5FF4C4
			internal void _.cctor_b__1_5(); // 0x000000018D5FF4C4-0x000000018D5FF504
		}
	
		// Constructors
		static UIEventRegistration(); // 0x0000000186C39C30-0x0000000186C3A210
	
		// Methods
		internal static void RegisterUIElementSystem(IUIElementsUtility utility); // 0x000000018683B190-0x000000018683B210
		private static void TakeCapture(); // 0x000000018D602430-0x000000018D602594
		private static void ReleaseCapture(); // 0x000000018D6022D8-0x000000018D602430
		private static bool EndContainerGUIFromException(Exception exception); // 0x000000018D601E20-0x000000018D601FBC
		private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr); // 0x000000018D602120-0x000000018D6022D8
		private static void CleanupRoots(); // 0x000000018D601CBC-0x000000018D601E20
		internal static void MakeCurrentIMGUIContainerDirty(); // 0x000000018D601FBC-0x000000018D602120
	}

	internal class UIElementsUtility : IUIElementsUtility // TypeDefIndex: 71390
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
		private UIElementsUtility(); // 0x000000018683B540-0x000000018683B590
		static UIElementsUtility(); // 0x000000018683BA20-0x000000018683BD40
	
		// Methods
		bool IUIElementsUtility.MakeCurrentIMGUIContainerDirty(); // 0x000000018D6019BC-0x000000018D601A68
		bool IUIElementsUtility.TakeCapture(); // 0x000000018D601B74-0x000000018D601CBC
		bool IUIElementsUtility.ReleaseCapture(); // 0x0000000187232850-0x0000000187232860
		bool IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled); // 0x000000018D601A68-0x000000018D601B74
		bool IUIElementsUtility.CleanupRoots(); // 0x000000018D601860-0x000000018D601918
		bool IUIElementsUtility.EndContainerGUIFromException(Exception exception); // 0x000000018D601918-0x000000018D6019BC
		public static void RegisterCachedPanel(int instanceID, UnityEngine.UIElements.Panel panel); // 0x000000018D6016FC-0x000000018D601778
		public static void RemoveCachedPanel(int instanceID); // 0x000000018D601778-0x000000018D6017E4
		public static bool TryGetPanel(int instanceID, out UnityEngine.UIElements.Panel panel); // 0x000000018D6017E4-0x000000018D601860
		internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, UnityEngine.Event evt, IMGUIContainer container); // 0x000000018D600B18-0x000000018D600CC8
		internal static void EndContainerGUI(UnityEngine.Event evt, Rect layoutSize); // 0x000000018D6014A4-0x000000018D60166C
		internal static EventBase CreateEvent(UnityEngine.Event systemEvent); // 0x000000018D600CC8-0x000000018D600D2C
		internal static EventBase CreateEvent(UnityEngine.Event systemEvent, UnityEngine.EventType eventType); // 0x000000018D600D2C-0x000000018D600FB4
		private static bool DoDispatch(BaseVisualElementPanel panel); // 0x000000018D600FB4-0x000000018D6014A4
		internal static void GetAllPanels(List<UnityEngine.UIElements.Panel> panels, ContextType contextType); // 0x0000000186B32B40-0x0000000186B32C20
		internal static Dictionary<int, UnityEngine.UIElements.Panel> GetPanelsIterator(); // 0x0000000186B32C20-0x0000000186B32CD0
		internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite); // 0x000000018D60166C-0x000000018D6016FC
	}

	internal struct RuleMatcher // TypeDefIndex: 71391
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public StyleComplexSelector complexSelector; // 0x08
	
		// Methods
		public override string ToString(); // 0x000000018D5FC144-0x000000018D5FC168
	}

	public static class UQuery // TypeDefIndex: 71398
	{
		// Nested types
		internal interface IVisualPredicateWrapper // TypeDefIndex: 71392
		{
			// Methods
			bool Predicate(object e);
		}
	
		internal class IsOfType<T> : IVisualPredicateWrapper // TypeDefIndex: 71393
			where T : VisualElement
		{
			// Fields
			public static IsOfType<T> s_Instance;
	
			// Constructors
			public IsOfType();
			static IsOfType();
	
			// Methods
			public bool Predicate(object e);
		}
	
		internal abstract class UQueryMatcher : HierarchyTraversal // TypeDefIndex: 71395
		{
			// Fields
			internal List<RuleMatcher> m_Matchers; // 0x10
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 71394
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Action<VisualElement, MatchResultInfo> __9__5_0; // 0x08
	
				// Constructors
				static __c(); // 0x000000018D5FF580-0x000000018D5FF5E4
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal void _TraverseRecursive_b__5_0(VisualElement e, MatchResultInfo i); // 0x0000000186805BA0-0x0000000186805BB0
			}
	
			// Constructors
			protected UQueryMatcher(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public override void Traverse(VisualElement element); // 0x000000018D60327C-0x000000018D603284
			protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element); // 0x0000000187232850-0x0000000187232860
			private static void NoProcessResult(VisualElement e, MatchResultInfo i); // 0x0000000186805BA0-0x0000000186805BB0
			public override void TraverseRecursive(VisualElement element, int depth); // 0x000000018D603084-0x000000018D60327C
			public virtual void Run(VisualElement root, List<RuleMatcher> matchers); // 0x000000018D603058-0x000000018D603084
		}
	
		internal abstract class SingleQueryMatcher : UQueryMatcher // TypeDefIndex: 71396
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private VisualElement _match_k__BackingField; // 0x18
	
			// Properties
			public VisualElement match { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
			// Constructors
			protected SingleQueryMatcher(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public override void Run(VisualElement root, List<RuleMatcher> matchers); // 0x000000018D5FC168-0x000000018D5FC1B0
			public bool IsInUse(); // 0x000000018C93AE88-0x000000018C93AE94
			public abstract SingleQueryMatcher CreateNew();
		}
	
		internal class FirstQueryMatcher : SingleQueryMatcher // TypeDefIndex: 71397
		{
			// Fields
			public static readonly FirstQueryMatcher Instance; // 0x00
	
			// Constructors
			public FirstQueryMatcher(); // 0x0000000186805BA0-0x0000000186805BB0
			static FirstQueryMatcher(); // 0x000000018D5FC0E0-0x000000018D5FC144
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element); // 0x000000018D5FC0C0-0x000000018D5FC0E0
			public override SingleQueryMatcher CreateNew(); // 0x000000018D5FC084-0x000000018D5FC0C0
		}
	}

	public struct UQueryState<T> : IEnumerable<T>, IEquatable<UQueryState<T>> // TypeDefIndex: 71402
		where T : VisualElement
	{
		// Fields
		private static ActionQueryMatcher s_Action;
		private readonly VisualElement m_Element;
		internal readonly List<RuleMatcher> m_Matchers;
		private static readonly ListQueryMatcher s_List;
		private static readonly ListQueryMatcher<VisualElement> s_EnumerationList;
	
		// Nested types
		private class ListQueryMatcher<TElement> : UQuery.UQueryMatcher // TypeDefIndex: 71399
			where TElement : VisualElement
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<TElement> _matches_k__BackingField;
	
			// Properties
			public List<TElement> matches { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public ListQueryMatcher();
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element);
			public void Reset();
		}
	
		private class ActionQueryMatcher : UQuery.UQueryMatcher // TypeDefIndex: 71400
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Action<T> _callBack_k__BackingField;
	
			// Properties
			internal Action<T> callBack { [CompilerGenerated] get; }
	
			// Constructors
			public ActionQueryMatcher();
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element);
		}
	
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 71401
		{
			// Fields
			private List<VisualElement> iterationList;
			private int currentIndex;
	
			// Properties
			public T Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			internal Enumerator(UQueryState<T> queryState);
	
			// Methods
			public bool MoveNext();
			public void Reset();
			public void Dispose();
		}
	
		// Constructors
		internal UQueryState(VisualElement element, List<RuleMatcher> matchers);
		static UQueryState();
	
		// Methods
		public UQueryState<T> RebuildOn(VisualElement element);
		private T Single(UQuery.SingleQueryMatcher matcher);
		public T First();
		public void ToList(List<T> results);
		public Enumerator GetEnumerator();
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public bool Equals(UQueryState<T> other);
		public override bool Equals(object obj);
		public override int GetHashCode();
	}

	public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> // TypeDefIndex: 71403
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
		private List<StyleSelector> styleSelectors { get; }
		private List<StyleSelectorPart> parts { get; }
	
		// Constructors
		public UQueryBuilder(VisualElement visualElement);
	
		// Methods
		public UQueryBuilder<T> Class(string classname);
		public UQueryBuilder<T> Name(string id);
		public UIElements.UQueryBuilder<T2> OfType<T2>(string name = null, string className = null)
			where T2 : VisualElement;
		internal UQueryBuilder<T> SingleBaseType();
		private void AddClass(string c);
		private void AddName(string id);
		private void AddType<T2>()
			where T2 : VisualElement;
		private UIElements.UQueryBuilder<T2> AddRelationship<T2>(StyleSelectorRelationship relationship)
			where T2 : VisualElement;
		private void AddPseudoStatesRuleIfNecessasy();
		private void FinishSelector();
		private bool CurrentSelectorEmpty();
		private void FinishCurrentSelector();
		public UQueryState<T> Build();
		public void ToList(List<T> results);
		public bool Equals(UQueryBuilder<T> other);
		public override bool Equals(object obj);
		public override int GetHashCode();
	}

	public static class UQueryExtensions // TypeDefIndex: 71404
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
		static UQueryExtensions(); // 0x000000018D60295C-0x000000018D603058
	
		// Extension methods
		public static T Q<T>(this VisualElement e, string name = null, string className = null)
			where T : VisualElement;
		public static VisualElement Q(this VisualElement e, string name = null, string className = null); // 0x000000018D602594-0x000000018D60295C
		public static UQueryBuilder<T> Query<T>(this VisualElement e, string name = null, string className = null)
			where T : VisualElement;
	}

	internal enum GradientType // TypeDefIndex: 71405
	{
		Linear = 0,
		Radial = 1
	}

	internal enum AddressMode // TypeDefIndex: 71406
	{
		Wrap = 0,
		Clamp = 1,
		Mirror = 2
	}

	[Serializable]
	internal struct VectorImageVertex // TypeDefIndex: 71407
	{
		// Fields
		public Vector3 position; // 0x00
		public Color32 tint; // 0x0C
		public Vector2 uv; // 0x10
		public uint settingIndex; // 0x18
	}

	[Serializable]
	internal struct GradientSettings // TypeDefIndex: 71408
	{
		// Fields
		public GradientType gradientType; // 0x00
		public AddressMode addressMode; // 0x04
		public Vector2 radialFocus; // 0x08
		public RectInt location; // 0x10
	}

	[Serializable]
	public class VectorImage : ScriptableObject // TypeDefIndex: 71409
	{
		// Fields
		[SerializeField]
		internal Texture2D atlas; // 0x18
		[SerializeField]
		internal VectorImageVertex[] vertices; // 0x20
		[SerializeField]
		internal ushort[] indices; // 0x28
		[SerializeField]
		internal GradientSettings[] settings; // 0x30
		[SerializeField]
		internal Vector2 size; // 0x38
	
		// Constructors
		public VectorImage(); // 0x000000018D605FC4-0x000000018D606014
	}

	[Flags]
	internal enum PseudoStates // TypeDefIndex: 71410
	{
		Active = 1,
		Hover = 2,
		Checked = 8,
		Disabled = 32,
		Focus = 64,
		Root = 128
	}

	[Flags]
	internal enum VisualElementFlags // TypeDefIndex: 71411
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

	public enum PickingMode // TypeDefIndex: 71412
	{
		Position = 0,
		Ignore = 1
	}

	public enum LanguageDirection // TypeDefIndex: 71413
	{
		Inherit = 0,
		LTR = 1,
		RTL = 2
	}

	internal static class VisualElementListPool // TypeDefIndex: 71414
	{
		// Fields
		private static ObjectPool<List<VisualElement>> pool; // 0x00
	
		// Constructors
		static VisualElementListPool(); // 0x000000018D6084DC-0x000000018D608570
	
		// Methods
		public static List<VisualElement> Copy(List<VisualElement> elements); // 0x000000018D6082EC-0x000000018D60838C
		public static List<VisualElement> Get(int initialCapacity = 0 /* Metadata: 0x02622370 */); // 0x000000018D60838C-0x000000018D60844C
		public static void Release(List<VisualElement> elements); // 0x000000018D60844C-0x000000018D6084DC
	}

	internal class ObjectListPool<T> // TypeDefIndex: 71415
	{
		// Fields
		private static ObjectPool<List<T>> pool;
	
		// Constructors
		static ObjectListPool();
	
		// Methods
		public static List<T> Get();
		public static void Release(List<T> elements);
	}

	public static class VisualElementExtensions // TypeDefIndex: 71416
	{
		// Extension methods
		public static void StretchToParentSize(this VisualElement elem); // 0x000000018D606A20-0x000000018D606B90
		public static void AddManipulator(this VisualElement ele, IManipulator manipulator); // 0x000000018D60690C-0x000000018D606920
		public static void RemoveManipulator(this VisualElement ele, IManipulator manipulator); // 0x000000018D606A0C-0x000000018D606A20
		public static Vector2 WorldToLocal(this VisualElement ele, Vector2 p); // 0x000000018D606C74-0x000000018D606D30
		public static Vector2 LocalToWorld(this VisualElement ele, Vector2 p); // 0x000000018D606950-0x000000018D606A0C
		public static Rect WorldToLocal(this VisualElement ele, Rect r); // 0x000000018D606B90-0x000000018D606C74
		public static Vector2 ChangeCoordinatesTo(this VisualElement src, VisualElement dest, Vector2 point); // 0x000000018D606920-0x000000018D606950
	}

	public interface IExperimentalFeatures // TypeDefIndex: 71417
	{
		// Properties
		ITransitionAnimations animation { get; }
	}

	public class VisualElementFocusChangeDirection : FocusChangeDirection // TypeDefIndex: 71418
	{
		// Fields
		private static readonly VisualElementFocusChangeDirection s_Left; // 0x00
		private static readonly VisualElementFocusChangeDirection s_Right; // 0x08
	
		// Properties
		public static FocusChangeDirection left { get; } // 0x000000018D606E88-0x000000018D606ED8 
		public static FocusChangeDirection right { get; } // 0x000000018D606ED8-0x000000018D606F28 
	
		// Constructors
		protected VisualElementFocusChangeDirection(int value); // 0x000000018D606E38-0x000000018D606E88
		static VisualElementFocusChangeDirection(); // 0x000000018D606D30-0x000000018D606E38
	}

	internal class VisualElementFocusChangeTarget : FocusChangeDirection // TypeDefIndex: 71419
	{
		// Fields
		private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Focusable _target_k__BackingField; // 0x18
	
		// Properties
		public Focusable target { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public VisualElementFocusChangeTarget(); // 0x000000018D6070E0-0x000000018D60713C
		static VisualElementFocusChangeTarget(); // 0x000000018D60704C-0x000000018D6070E0
	
		// Methods
		public static VisualElementFocusChangeTarget GetPooled(Focusable target); // 0x000000018D606FC8-0x000000018D60704C
		protected override void Dispose(); // 0x000000018D606F48-0x000000018D606FC8
		internal override void ApplyTo(FocusController focusController, Focusable f); // 0x000000018D606F28-0x000000018D606F48
	}

	public class VisualElementFocusRing : IFocusRing // TypeDefIndex: 71422
	{
		// Fields
		private readonly VisualElement root; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DefaultFocusOrder _defaultFocusOrder_k__BackingField; // 0x18
		private List<FocusRingRecord> m_FocusRing; // 0x20
	
		// Properties
		private FocusController focusController { get; } // 0x000000018D6082C8-0x000000018D6082EC 
		public DefaultFocusOrder defaultFocusOrder { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
	
		// Nested types
		public enum DefaultFocusOrder // TypeDefIndex: 71420
		{
			ChildOrder = 0,
			PositionXY = 1,
			PositionYX = 2
		}
	
		private class FocusRingRecord // TypeDefIndex: 71421
		{
			// Fields
			public int m_AutoIndex; // 0x10
			public Focusable m_Focusable; // 0x18
			public bool m_IsSlot; // 0x20
			public List<FocusRingRecord> m_ScopeNavigationOrder; // 0x28
	
			// Constructors
			public FocusRingRecord(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = DefaultFocusOrder.ChildOrder /* Metadata: 0x02622371 */); // 0x000000018D608230-0x000000018D6082C8
	
		// Methods
		private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b); // 0x000000018D607464-0x000000018D607744
		private int FocusRingSort(FocusRingRecord a, FocusRingRecord b); // 0x000000018D607744-0x000000018D60784C
		private void DoUpdate(); // 0x000000018D607398-0x000000018D607464
		private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList); // 0x000000018D60713C-0x000000018D607398
		private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList); // 0x000000018D607F90-0x000000018D608230
		private int GetFocusableInternalIndex(Focusable f); // 0x000000018D607A04-0x000000018D607A94
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e); // 0x000000018D60784C-0x000000018D607A04
		internal static FocusChangeDirection GetKeyDownFocusChangeDirection(EventBase e); // 0x000000018D607A94-0x000000018D607BC0
		public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction); // 0x000000018D607C48-0x000000018D607ECC
		internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable); // 0x000000018D607BC0-0x000000018D607C48
		internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable); // 0x000000018D607ECC-0x000000018D607F90
	}

	public interface IVisualElementScheduledItem // TypeDefIndex: 71423
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

	public interface IVisualElementScheduler // TypeDefIndex: 71424
	{
		// Methods
		IVisualElementScheduledItem Execute(Action<UnityEngine.UIElements.TimerState> timerUpdateEvent);
		IVisualElementScheduledItem Execute(Action updateEvent);
	}

	internal interface IVisualElementPanelActivatable // TypeDefIndex: 71425
	{
		// Properties
		VisualElement element { get; }
	
		// Methods
		bool CanBeActivated();
		void OnPanelActivate();
		void OnPanelDeactivate();
	}

	internal class VisualElementPanelActivator // TypeDefIndex: 71426
	{
		// Fields
		private IVisualElementPanelActivatable m_Activatable; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isActive_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isDetaching_k__BackingField; // 0x19
	
		// Properties
		public bool isActive { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
		public bool isDetaching { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E010-0x000000018225E020 0x000000018225E020-0x000000018225E030
	
		// Constructors
		public VisualElementPanelActivator(IVisualElementPanelActivatable activatable); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public void SetActive(bool action); // 0x000000018D6086D8-0x000000018D6088F0
		public void SendActivation(); // 0x000000018D608610-0x000000018D608674
		public void SendDeactivation(); // 0x000000018D608674-0x000000018D6086D8
		private void OnEnter(AttachToPanelEvent evt); // 0x000000018D608570-0x000000018D608580
		private void OnLeave(DetachFromPanelEvent evt); // 0x000000018D608580-0x000000018D608610
	}

	[DefaultMember("Item")]
	public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet> // TypeDefIndex: 71427
	{
		// Fields
		private readonly VisualElement m_Element; // 0x00
	
		// Constructors
		internal VisualElementStyleSheetSet(VisualElement element); // 0x00000001878380EC-0x00000001878380F4
	
		// Methods
		public void Add(StyleSheet styleSheet); // 0x000000018D6088F0-0x000000018D608A88
		public bool Remove(StyleSheet styleSheet); // 0x000000018D608AF8-0x000000018D608C48
		public bool Equals(VisualElementStyleSheetSet other); // 0x000000018D59E820-0x000000018D59E830
		public override bool Equals(object obj); // 0x000000018D608A88-0x000000018D608AF8
		public override int GetHashCode(); // 0x000000018AB02AA8-0x000000018AB02ACC
	}

	internal static class VisualElementUtils // TypeDefIndex: 71428
	{
		// Fields
		private static readonly HashSet<string> s_usedNames; // 0x00
		private static readonly System.Type s_FoldoutType; // 0x08
	
		// Constructors
		static VisualElementUtils(); // 0x000000018D608EDC-0x000000018D608FC8
	
		// Methods
		public static string GetUniqueName(string nameBase); // 0x000000018D608DE8-0x000000018D608EDC
	
		// Extension methods
		internal static int GetFoldoutDepth(this VisualElement element); // 0x000000018D608C48-0x000000018D608CF8
		internal static int GetListAndFoldoutDepth(this VisualElement element); // 0x000000018D608CF8-0x000000018D608DE8
	}

	internal class VisualElementAnimationSystem : BaseVisualTreeUpdater // TypeDefIndex: 71429
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
		public override ProfilerMarker profilerMarker { get; } // 0x000000018D60686C-0x000000018D6068BC 
		private static ProfilerMarker stylePropertyAnimationProfilerMarker { get; } // 0x000000018D6068BC-0x000000018D60690C 
	
		// Constructors
		public VisualElementAnimationSystem(); // 0x000000018D6067A8-0x000000018D60686C
		static VisualElementAnimationSystem(); // 0x000000018D606698-0x000000018D6067A8
	
		// Methods
		public void UnregisterAnimation(IValueAnimationUpdate anim); // 0x000000018D6061C0-0x000000018D60621C
		public void UnregisterAnimations(List<IValueAnimationUpdate> anims); // 0x000000018D60621C-0x000000018D60636C
		public void RegisterAnimation(IValueAnimationUpdate anim); // 0x000000018D606014-0x000000018D606070
		public void RegisterAnimations(List<IValueAnimationUpdate> anims); // 0x000000018D606070-0x000000018D6061C0
		public override void Update(); // 0x000000018D60636C-0x000000018D606698
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal enum HierarchyChangeType // TypeDefIndex: 71430
	{
		Add = 0,
		Remove = 1,
		Move = 2
	}

	internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater // TypeDefIndex: 71432
	{
		// Fields
		private State m_State; // 0x20
		private VisualElement m_CurrentChangeElement; // 0x28
		private VisualElement m_CurrentChangeParent; // 0x30
	
		// Nested types
		private enum State // TypeDefIndex: 71431
		{
			Waiting = 0,
			TrackingAddOrMove = 1,
			TrackingRemove = 2
		}
	
		// Constructors
		protected BaseVisualTreeHierarchyTrackerUpdater(); // 0x00000001872327A0-0x00000001872327B0
	
		// Methods
		protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type);
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D5FBBA4-0x000000018D5FBBE4
		public override void Update(); // 0x000000018D5FBD6C-0x000000018D5FBE0C
		private void ProcessNewChange(VisualElement ve); // 0x000000018D5FBC7C-0x000000018D5FBCF8
		private void ProcessAddOrMove(VisualElement ve); // 0x000000018D5FBBE4-0x000000018D5FBC7C
		private void ProcessRemove(VisualElement ve); // 0x000000018D5FBCF8-0x000000018D5FBD6C
	}

	internal static class StyleCache // TypeDefIndex: 71433
	{
		// Fields
		private static Dictionary<long, ComputedStyle> s_ComputedStyleCache; // 0x00
		private static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache; // 0x08
		private static Dictionary<int, ComputedTransitionProperty[]> s_ComputedTransitionsCache; // 0x10
	
		// Constructors
		static StyleCache(); // 0x000000018D5FC4DC-0x000000018D5FC638
	
		// Methods
		public static bool TryGetValue(long hash, out ComputedStyle data); // 0x000000018D5FC460-0x000000018D5FC4DC
		public static void SetValue(long hash, ref ComputedStyle data); // 0x000000018D5FC1B0-0x000000018D5FC270
		public static bool TryGetValue(int hash, out StyleVariableContext data); // 0x000000018D5FC368-0x000000018D5FC3E4
		public static void SetValue(int hash, StyleVariableContext data); // 0x000000018D5FC270-0x000000018D5FC2EC
		public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data); // 0x000000018D5FC3E4-0x000000018D5FC460
		public static void SetValue(int hash, ComputedTransitionProperty[] data); // 0x000000018D5FC2EC-0x000000018D5FC368
	}

	internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater // TypeDefIndex: 71434
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x48
	
		// Properties
		public override ProfilerMarker profilerMarker { get; } // 0x000000018D60C4FC-0x000000018D60C54C 
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
	
		// Constructors
		public VisualTreeStyleUpdater(); // 0x000000018D60C410-0x000000018D60C4FC
		static VisualTreeStyleUpdater(); // 0x000000018D60C378-0x000000018D60C410
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D60BFD0-0x000000018D60C084
		public override void Update(); // 0x000000018D60C084-0x000000018D60C378
		protected override void Dispose(bool disposing); // 0x000000018D60BF9C-0x000000018D60BFD0
		private void ApplyStyles(); // 0x000000018D60BEE4-0x000000018D60BF9C
	}

	internal class StyleMatchingContext // TypeDefIndex: 71435
	{
		// Fields
		private List<StyleSheet> m_StyleSheetStack; // 0x10
		public StyleVariableContext variableContext; // 0x18
		public VisualElement currentElement; // 0x20
		public Action<VisualElement, MatchResultInfo> processResult; // 0x28
		public AncestorFilter ancestorFilter; // 0x30
	
		// Properties
		public int styleSheetCount { get; } // 0x000000018D5FC884-0x000000018D5FC8C4 
	
		// Constructors
		public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult); // 0x000000018D5FC770-0x000000018D5FC884
	
		// Methods
		public void AddStyleSheet(StyleSheet sheet); // 0x000000018D5FC638-0x000000018D5FC6B8
		public void RemoveStyleSheetRange(int index, int count); // 0x000000018D5FC70C-0x000000018D5FC770
		public StyleSheet GetStyleSheetAt(int index); // 0x000000018D5FC6B8-0x000000018D5FC70C
	}

	internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal // TypeDefIndex: 71437
	{
		// Fields
		private StyleVariableContext m_ProcessVarContext; // 0x10
		private HashSet<VisualElement> m_UpdateList; // 0x18
		private HashSet<VisualElement> m_ParentList; // 0x20
		private List<SelectorMatchRecord> m_TempMatchResults; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _currentPixelsPerPoint_k__BackingField; // 0x30
		private StyleMatchingContext m_StyleMatchingContext; // 0x38
		private StylePropertyReader m_StylePropertyReader; // 0x40
		private readonly List<StylePropertyId> m_AnimatedProperties; // 0x48
	
		// Properties
		private float currentPixelsPerPoint { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233870-0x0000000187233880 0x0000000187233880-0x0000000187233890
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71436
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<SelectorMatchRecord> __9__24_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D5FF5E4-0x000000018D5FF648
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _ProcessMatchedRules_b__24_0(SelectorMatchRecord a, SelectorMatchRecord b); // 0x000000018D5FF210-0x000000018D5FF254
		}
	
		// Constructors
		public VisualTreeStyleUpdaterTraversal(); // 0x000000018D60BC98-0x000000018D60BEE4
	
		// Methods
		public void PrepareTraversal(float pixelsPerPoint); // 0x0000000187233880-0x0000000187233890
		public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D60A398-0x000000018D60A41C
		public void Clear(); // 0x000000018D60A5EC-0x000000018D60A668
		private void PropagateToChildren(VisualElement ve); // 0x000000018D60B42C-0x000000018D60B4EC
		private void PropagateToParents(VisualElement ve); // 0x000000018D60B4EC-0x000000018D60B56C
		private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info); // 0x000000018D60A824-0x000000018D60A858
		public override void TraverseRecursive(VisualElement element, int depth); // 0x000000018D60B5F0-0x000000018D60BC98
		private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle); // 0x000000018D60B354-0x000000018D60B42C
		private void ForceUpdateTransitions(VisualElement element); // 0x000000018D60A668-0x000000018D60A824
		internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle); // 0x000000018D60A41C-0x000000018D60A5EC
		protected bool ShouldSkipElement(VisualElement element); // 0x000000018D60B56C-0x000000018D60B5F0
		private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors); // 0x000000018D60A858-0x000000018D60B284
		private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule); // 0x000000018D60B284-0x000000018D60B354
	}

	internal class VisualTreeTransformClipUpdater : BaseVisualTreeUpdater // TypeDefIndex: 71438
	{
		// Fields
		private uint m_Version; // 0x20
		private uint m_LastVersion; // 0x24
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
	
		// Properties
		public override ProfilerMarker profilerMarker { get; } // 0x000000018D60C8A0-0x000000018D60C8F0 
	
		// Constructors
		public VisualTreeTransformClipUpdater(); // 0x0000000187248930-0x0000000187248940
		static VisualTreeTransformClipUpdater(); // 0x000000018D60C808-0x000000018D60C8A0
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D60C6C0-0x000000018D60C7B0
		private static void DirtyHierarchy(VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip); // 0x000000018D60C5A8-0x000000018D60C6C0
		private static void DirtyBoundingBoxHierarchy(VisualElement ve); // 0x000000018D60C54C-0x000000018D60C5A8
		public override void Update(); // 0x000000018D60C7B0-0x000000018D60C808
	}

	internal enum VisualTreeUpdatePhase // TypeDefIndex: 71439
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

	internal sealed class VisualTreeUpdater : IDisposable // TypeDefIndex: 71441
	{
		// Fields
		private BaseVisualElementPanel m_Panel; // 0x10
		private UpdaterArray m_UpdaterArray; // 0x18
	
		// Nested types
		private class UpdaterArray // TypeDefIndex: 71440
		{
			// Fields
			private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10
	
			// Properties
			public IVisualTreeUpdater this[VisualTreeUpdatePhase phase] { get => default; set {} } // 0x000000018B636D34-0x000000018B636D60 0x000000018D6032CC-0x000000018D603328
			public IVisualTreeUpdater this[int index] { get => default; } // 0x000000018B636D34-0x000000018B636D60 
	
			// Constructors
			public UpdaterArray(); // 0x000000018D603284-0x000000018D6032CC
		}
	
		// Constructors
		public VisualTreeUpdater(BaseVisualElementPanel panel); // 0x000000018D60CBC0-0x000000018D60CC40
	
		// Methods
		public void Dispose(); // 0x000000018D60C8F0-0x000000018D60C960
		public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase); // 0x000000018D60CAE8-0x000000018D60CBC0
		public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D60C980-0x000000018D60C9EC
		public void SetUpdater<T>(VisualTreeUpdatePhase phase)
			where T : IVisualTreeUpdater, new();
		public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase); // 0x000000018D60C960-0x000000018D60C980
		private void SetDefaultUpdaters(); // 0x000000018D60C9EC-0x000000018D60CAE8
	}

	internal interface IVisualTreeUpdater : IDisposable // TypeDefIndex: 71442
	{
		// Properties
		BaseVisualElementPanel panel { set; }
		ProfilerMarker profilerMarker { get; }
	
		// Methods
		void Update();
		void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
	}

	internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater // TypeDefIndex: 71443
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<BaseVisualElementPanel> panelChanged; // 0x10
		private BaseVisualElementPanel m_Panel; // 0x18
	
		// Properties
		public BaseVisualElementPanel panel { get; set; } // 0x0000000187244530-0x0000000187244540 0x000000018D5FBF98-0x000000018D5FBFCC
		public VisualElement visualTree { get; } // 0x000000018D5FBEE8-0x000000018D5FBF0C 
		public abstract ProfilerMarker profilerMarker { get; }
	
		// Events
		public event Action<BaseVisualElementPanel> panelChanged {
			add; // 0x000000018D5FBE5C-0x000000018D5FBEE8
			remove; // 0x000000018D5FBF0C-0x000000018D5FBF98
		}
	
		// Constructors
		protected BaseVisualTreeUpdater(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x000000018D5FBE0C-0x000000018D5FBE5C
		protected virtual void Dispose(bool disposing); // 0x0000000186805BA0-0x0000000186805BB0
		public abstract void Update();
		public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
	}

	internal class VisualTreeViewDataUpdater : BaseVisualTreeUpdater // TypeDefIndex: 71444
	{
		// Fields
		private HashSet<VisualElement> m_UpdateList; // 0x20
		private HashSet<VisualElement> m_ParentList; // 0x28
		private uint m_Version; // 0x30
		private uint m_LastVersion; // 0x34
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
	
		// Properties
		public override ProfilerMarker profilerMarker { get; } // 0x000000018D60D0CC-0x000000018D60D1F4 
	
		// Constructors
		public VisualTreeViewDataUpdater(); // 0x000000018D60D01C-0x000000018D60D0CC
		static VisualTreeViewDataUpdater(); // 0x000000018D60CF84-0x000000018D60D01C
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D60CC40-0x000000018D60CCBC
		public override void Update(); // 0x000000018D60CD3C-0x000000018D60CE40
		private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence); // 0x000000018D60CE40-0x000000018D60CF84
		private void PropagateToParents(VisualElement ve); // 0x000000018D60CCBC-0x000000018D60CD3C
	}

	internal interface IBindingRequest // TypeDefIndex: 71445
	{
		// Methods
		void Bind(VisualElement element);
	}

	internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater // TypeDefIndex: 71446
	{
		// Fields
		private static readonly PropertyName s_BindingRequestObjectVEPropertyName; // 0x00
		private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; // 0x04
		private static readonly string s_Description; // 0x08
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x10
		private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; // 0x18
		private static ProfilerMarker s_MarkerUpdate; // 0x20
		private static ProfilerMarker s_MarkerPoll; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static bool _disableBindingsThrottling_k__BackingField; // 0x30
		private readonly HashSet<VisualElement> m_ElementsWithBindings; // 0x38
		private readonly HashSet<VisualElement> m_ElementsToAdd; // 0x40
		private readonly HashSet<VisualElement> m_ElementsToRemove; // 0x48
		private long m_LastUpdateTime; // 0x50
		private HashSet<VisualElement> m_ElementsToBind; // 0x58
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Dictionary<object, object> _temporaryObjectCache_k__BackingField; // 0x60
		private List<IBinding> updatedBindings; // 0x68
	
		// Properties
		public override ProfilerMarker profilerMarker { get; } // 0x000000018D60A348-0x000000018D60A398 
		public Dictionary<object, object> temporaryObjectCache { [CompilerGenerated] get; } // 0x0000000187232FA0-0x0000000187232FB0 
	
		// Constructors
		public VisualTreeBindingsUpdater(); // 0x000000018D60A190-0x000000018D60A348
		static VisualTreeBindingsUpdater(); // 0x000000018D609FBC-0x000000018D60A190
	
		// Methods
		private IBinding GetBindingObjectFromElement(VisualElement ve); // 0x000000018D609080-0x000000018D609104
		private void StartTracking(VisualElement ve); // 0x000000018D6095B4-0x000000018D60962C
		private void StopTracking(VisualElement ve); // 0x000000018D60972C-0x000000018D6097A4
		public static IBinding GetAdditionalBinding(VisualElement ve); // 0x000000018D609008-0x000000018D609080
		private void StartTrackingRecursive(VisualElement ve); // 0x000000018D6094A0-0x000000018D6095B4
		private void StopTrackingRecursive(VisualElement ve); // 0x000000018D60962C-0x000000018D60972C
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D60912C-0x000000018D60920C
		protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type); // 0x000000018D609104-0x000000018D60912C
		private static long CurrentTime(); // 0x000000018D608FC8-0x000000018D609008
		public void PerformTrackingOperations(); // 0x000000018D60920C-0x000000018D6094A0
		public override void Update(); // 0x000000018D609B7C-0x000000018D609FBC
		private void UpdateBindings(); // 0x000000018D6097A4-0x000000018D609B7C
	}

	public abstract class BaseListViewController : CollectionViewController // TypeDefIndex: 71447
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action itemsSourceSizeChanged; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> itemsAdded; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> itemsRemoved; // 0x40
	
		// Properties
		protected BaseListView baseListView { get; } // 0x000000018D5FB9BC-0x000000018D5FB9F8 
	
		// Events
		public event Action itemsSourceSizeChanged {
			add; // 0x000000018D5FB928-0x000000018D5FB9BC
			remove; // 0x000000018D5FBB10-0x000000018D5FBBA4
		}
		public event Action<IEnumerable<int>> itemsAdded {
			add; // 0x000000018D5FB810-0x000000018D5FB89C
			remove; // 0x000000018D5FB9F8-0x000000018D5FBA84
		}
		public event Action<IEnumerable<int>> itemsRemoved {
			add; // 0x000000018D5FB89C-0x000000018D5FB928
			remove; // 0x000000018D5FBA84-0x000000018D5FBB10
		}
	
		// Constructors
		protected BaseListViewController(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem); // 0x000000018D5FAD88-0x000000018D5FAE58
		internal void PostInitRegistration(ReusableListViewItem listItem); // 0x000000018D5FAF38-0x000000018D5FB138
		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index); // 0x000000018D5FACB8-0x000000018D5FAD88
		public virtual bool NeedsDragHandle(int index); // 0x0000000187249050-0x0000000187249060
		public virtual void AddItems(int itemCount); // 0x000000018D5FA648-0x000000018D5FAA68
		public virtual void Move(int index, int newIndex); // 0x000000018D5FAE58-0x000000018D5FAF38
		public virtual void RemoveItem(int index); // 0x000000018D5FB2EC-0x000000018D5FB40C
		public virtual void RemoveItems(List<int> indices); // 0x000000018D5FB560-0x000000018D5FB6AC
		internal virtual void RemoveItems(int itemCount); // 0x000000018D5FB40C-0x000000018D5FB560
		public virtual void ClearItems(); // 0x000000018D5FAB48-0x000000018D5FABE4
		protected void RaiseOnSizeChanged(); // 0x000000018D5FB160-0x000000018D5FB170
		protected void RaiseItemsAdded(IEnumerable<int> indices); // 0x000000018D5FB138-0x000000018D5FB14C
		protected void RaiseItemsRemoved(IEnumerable<int> indices); // 0x000000018D5FB14C-0x000000018D5FB160
		private static Array AddToArray(Array source, int itemCount); // 0x000000018D5FAA68-0x000000018D5FAB48
		private static Array RemoveFromArray(Array source, List<int> indicesToRemove); // 0x000000018D5FB170-0x000000018D5FB2EC
		private void Swap(int lhs, int rhs); // 0x000000018D5FB6AC-0x000000018D5FB77C
		private void EnsureItemSourceCanBeResized(); // 0x000000018D5FABE4-0x000000018D5FACB8
		[CompilerGenerated]
		internal static bool _AddItems_g__IsGenericList_15_0(System.Type t); // 0x000000018D5FB77C-0x000000018D5FB810
	}

	public abstract class BaseTreeViewController : CollectionViewController // TypeDefIndex: 71449
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
		protected BaseTreeView baseTreeView { get; } // 0x000000018D612378-0x000000018D6123B4 
		public override IList itemsSource { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D6123B4-0x000000018D612410
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 71448
		{
			// Fields
			public BaseTreeViewController __4__this; // 0x10
			public ReusableTreeViewItem treeItem; // 0x18
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PostInitRegistration_b__0(); // 0x000000018D620428-0x000000018D620464
		}
	
		// Constructors
		protected BaseTreeViewController(); // 0x000000018D6121EC-0x000000018D612378
		static BaseTreeViewController(); // 0x000000018D612150-0x000000018D6121EC
	
		// Methods
		public void RebuildTree(); // 0x000000018D611E0C-0x000000018D6120B8
		public IEnumerable<int> GetRootItemIds(); // 0x00000001872615B0-0x00000001872615C0
		public abstract IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null);
		public abstract int GetParentId(int id);
		public abstract IEnumerable<int> GetChildrenIds(int id);
		public abstract void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x02622383 */, bool rebuildTree = true /* Metadata: 0x02622384 */);
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem); // 0x000000018D61146C-0x000000018D6114E8
		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index); // 0x000000018D611294-0x000000018D611358
		internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem); // 0x000000018D611358-0x000000018D61146C
		internal void PostInitRegistration(ReusableTreeViewItem treeItem); // 0x000000018D611BFC-0x000000018D611DF8
		private void OnItemPointerUp(PointerUpEvent evt); // 0x000000018D611630-0x000000018D611AF4
		private void OnToggleValueChanged(ChangeEvent<bool> evt); // 0x000000018D611AF4-0x000000018D611BFC
		public override int GetIndexForId(int id); // 0x000000018D6110C8-0x000000018D611178
		public override int GetIdForIndex(int index); // 0x000000018D610FE4-0x000000018D611058
		public virtual bool HasChildren(int id); // 0x000000018D611214-0x000000018D611294
		internal bool Exists(int id); // 0x000000018D61055C-0x000000018D6105B0
		public bool HasChildrenByIndex(int index); // 0x000000018D611178-0x000000018D611214
		public IEnumerable<int> GetChildrenIdsByIndex(int index); // 0x000000018D610F64-0x000000018D610FE4
		public int GetChildIndexForId(int id); // 0x000000018D610D70-0x000000018D610F64
		internal int GetIndentationDepth(int id); // 0x000000018D611084-0x000000018D6110C8
		internal int GetIndentationDepthByIndex(int index); // 0x000000018D611058-0x000000018D611084
		internal virtual bool CanChangeExpandedState(int id); // 0x0000000187249050-0x0000000187249060
		public bool IsExpanded(int id); // 0x000000018D611570-0x000000018D6115D4
		public bool IsExpandedByIndex(int index); // 0x000000018D6114E8-0x000000018D611570
		public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true /* Metadata: 0x02622385 */); // 0x000000018D6105B0-0x000000018D610C18
		public void ExpandItem(int id, bool expandAllChildren, bool refresh = true /* Metadata: 0x02622386 */); // 0x000000018D610C18-0x000000018D610D70
		public void CollapseItemByIndex(int index, bool collapseAllChildren); // 0x000000018D60FCA0-0x000000018D60FFE8
		public void CollapseItem(int id, bool collapseAllChildren); // 0x000000018D60FFE8-0x000000018D610110
		internal void RegenerateWrappers(); // 0x000000018D6120B8-0x000000018D612150
		private void CreateWrappers(IEnumerable<int> treeViewItemIds, int depth, ref List<TreeViewItemWrapper> wrappers); // 0x000000018D610110-0x000000018D61055C
		private bool IsIndexValid(int index); // 0x000000018D6115D4-0x000000018D611630
		internal void RaiseItemParentChanged(int id, int newParentId); // 0x000000018D611DF8-0x000000018D611E0C
	}

	public abstract class CollectionViewController : IDisposable // TypeDefIndex: 71450
	{
		// Fields
		private BaseVerticalCollectionView m_View; // 0x10
		private IList m_ItemsSource; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action itemsSourceChanged; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<int, int> itemIndexChanged; // 0x28
	
		// Properties
		public virtual IList itemsSource { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D618FDC-0x000000018D619080
		protected BaseVerticalCollectionView view { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Events
		public event Action itemsSourceChanged {
			add; // 0x000000018D618E28-0x000000018D618EBC
			remove; // 0x000000018D618F48-0x000000018D618FDC
		}
		public event Action<int, int> itemIndexChanged {
			add; // 0x000000018D618D9C-0x000000018D618E28
			remove; // 0x000000018D618EBC-0x000000018D618F48
		}
	
		// Constructors
		protected CollectionViewController(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected void SetItemsSourceWithoutNotify(IList source); // 0x0000000187835500-0x0000000187835510
		public void SetView(BaseVerticalCollectionView collectionView); // 0x000000018D618D0C-0x000000018D618D9C
		protected virtual void PrepareView(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void Dispose(); // 0x000000018D618AE8-0x000000018D618B20
		public virtual int GetItemsCount(); // 0x000000018D618B80-0x000000018D618BA0
		internal virtual int GetItemsMinCount(); // 0x000000018D618BA0-0x000000018D618BA8
		public virtual int GetIndexForId(int id); // 0x00000001872498F0-0x0000000187249900
		public virtual int GetIdForIndex(int index); // 0x00000001872498F0-0x0000000187249900
		public virtual object GetItemForIndex(int index); // 0x000000018D618B20-0x000000018D618B80
		internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem); // 0x000000018D618C8C-0x000000018D618CC4
		internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index); // 0x000000018D618BA8-0x000000018D618C64
		internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index); // 0x000000018D618CC4-0x000000018D618CFC
		internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem); // 0x000000018D618C64-0x000000018D618C8C
		protected abstract VisualElement MakeItem();
		protected abstract void BindItem(VisualElement element, int index);
		protected abstract void UnbindItem(VisualElement element, int index);
		protected abstract void DestroyItem(VisualElement element);
		protected void RaiseItemsSourceChanged(); // 0x000000018D618CFC-0x000000018D618D0C
		protected void RaiseItemIndexChanged(int srcIndex, int dstIndex); // 0x000000018D611DF8-0x000000018D611E0C
	}

	internal class DefaultMultiColumnTreeViewController<T> : MultiColumnTreeViewController // TypeDefIndex: 71451
	{
		// Fields
		private TreeDataController<T> m_TreeDataController;
	
		// Properties
		private TreeDataController<T> treeDataController { get; }
		public override IList itemsSource { get; set; }
	
		// Constructors
		public DefaultMultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns);
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> items);
		public override object GetItemForIndex(int index);
		public override int GetParentId(int id);
		public override bool HasChildren(int id);
		public override IEnumerable<int> GetChildrenIds(int id);
		public override void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x02622387 */, bool rebuildTree = true /* Metadata: 0x02622388 */);
		private bool IsChildOf(int childId, int id);
		public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null);
	}

	internal class DefaultTreeViewController<T> : TreeViewController // TypeDefIndex: 71452
	{
		// Fields
		private TreeDataController<T> m_TreeDataController;
	
		// Properties
		private TreeDataController<T> treeDataController { get; }
		public override IList itemsSource { get; set; }
	
		// Constructors
		public DefaultTreeViewController();
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> items);
		public override object GetItemForIndex(int index);
		public override int GetParentId(int id);
		public override bool HasChildren(int id);
		public override IEnumerable<int> GetChildrenIds(int id);
		public override void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x02622389 */, bool rebuildTree = true /* Metadata: 0x0262238A */);
		private bool IsChildOf(int childId, int id);
		public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null);
	}

	public class ListViewController : BaseListViewController // TypeDefIndex: 71453
	{
		// Properties
		protected ListView listView { get; } // 0x000000018D61D1A0-0x000000018D61D1DC 
	
		// Constructors
		public ListViewController(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override VisualElement MakeItem(); // 0x000000018D61D058-0x000000018D61D158
		protected override void BindItem(VisualElement element, int index); // 0x000000018D61CE9C-0x000000018D61D020
		protected override void UnbindItem(VisualElement element, int index); // 0x000000018D61D158-0x000000018D61D1A0
		protected override void DestroyItem(VisualElement element); // 0x000000018D61D020-0x000000018D61D058
	}

	public class MultiColumnListViewController : BaseListViewController // TypeDefIndex: 71454
	{
		// Fields
		private MultiColumnController m_ColumnController; // 0x48
	
		// Properties
		public MultiColumnController columnController { get; } // 0x000000018226EE80-0x000000018226EE90 
		internal MultiColumnCollectionHeader header { get; } // 0x000000018D61D67C-0x000000018D61D68C 
	
		// Constructors
		public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns); // 0x000000018D61D5E0-0x000000018D61D67C
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem); // 0x000000018D61D34C-0x000000018D61D42C
		protected override VisualElement MakeItem(); // 0x000000018D61D42C-0x000000018D61D44C
		protected override void BindItem(VisualElement element, int index); // 0x000000018D61D1DC-0x000000018D61D268
		protected override void UnbindItem(VisualElement element, int index); // 0x000000018D61D4FC-0x000000018D61D51C
		protected override void DestroyItem(VisualElement element); // 0x000000018D61D268-0x000000018D61D288
		protected override void PrepareView(); // 0x000000018D61D44C-0x000000018D61D4FC
		public override void Dispose(); // 0x000000018D61D288-0x000000018D61D34C
		private void UpdateReorderClassList(); // 0x000000018D61D51C-0x000000018D61D5E0
	}

	public abstract class MultiColumnTreeViewController : BaseTreeViewController // TypeDefIndex: 71455
	{
		// Fields
		private MultiColumnController m_ColumnController; // 0x58
	
		// Properties
		public MultiColumnController columnController { get; } // 0x0000000187232F70-0x0000000187232F80 
		internal MultiColumnCollectionHeader header { get; } // 0x000000018D61D950-0x000000018D61D960 
	
		// Constructors
		protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns); // 0x000000018D61D890-0x000000018D61D950
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem); // 0x000000018D61D778-0x000000018D61D828
		protected override VisualElement MakeItem(); // 0x000000018D61D828-0x000000018D61D848
		protected override void BindItem(VisualElement element, int index); // 0x000000018D61D68C-0x000000018D61D718
		protected override void UnbindItem(VisualElement element, int index); // 0x000000018D61D870-0x000000018D61D890
		protected override void DestroyItem(VisualElement element); // 0x000000018D61D718-0x000000018D61D738
		protected override void PrepareView(); // 0x000000018D61D848-0x000000018D61D870
		public override void Dispose(); // 0x000000018D61D738-0x000000018D61D778
	}

	internal sealed class TreeDataController<T> // TypeDefIndex: 71458
	{
		// Fields
		private TreeData<T> m_TreeData;
		private Stack<IEnumerator<int>> m_IteratorStack;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetItemIds_d__9 : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 71456
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
			int IEnumerator<System.Int32>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetItemIds_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<int> IEnumerable<int>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated]
		private sealed class _GetAllItemIds_d__13 : IEnumerable<int>, IEnumerator<int> // TypeDefIndex: 71457
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
			int IEnumerator<System.Int32>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetAllItemIds_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<int> IEnumerable<int>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		public TreeDataController();
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> rootItems);
		public T GetDataForId(int id);
		public int GetParentId(int id);
		public bool HasChildren(int id);
		private static IEnumerable<int> GetItemIds(IEnumerable<TreeViewItemData<T>> items);
		public IEnumerable<int> GetChildrenIds(int id);
		public void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x0262238B */);
		public bool IsChildOf(int childId, int id);
		public IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null);
	}

	public abstract class TreeViewController : BaseTreeViewController // TypeDefIndex: 71459
	{
		// Properties
		protected TreeView treeView { get; } // 0x000000018D6203CC-0x000000018D620408 
	
		// Constructors
		protected TreeViewController(); // 0x000000018D620380-0x000000018D6203CC
	
		// Methods
		protected override VisualElement MakeItem(); // 0x000000018D620238-0x000000018D620338
		protected override void BindItem(VisualElement element, int index); // 0x000000018D6200A0-0x000000018D620200
		protected override void UnbindItem(VisualElement element, int index); // 0x000000018D620338-0x000000018D620380
		protected override void DestroyItem(VisualElement element); // 0x000000018D620200-0x000000018D620238
	}

	internal abstract class CollectionVirtualizationController // TypeDefIndex: 71460
	{
		// Fields
		protected readonly ScrollView m_ScrollView; // 0x10
	
		// Properties
		public abstract int firstVisibleIndex { get; protected set; }
		public abstract int visibleItemCount { get; }
		public abstract IEnumerable<ReusableCollectionItem> activeItems { get; }
	
		// Constructors
		protected CollectionVirtualizationController(ScrollView scrollView); // 0x0000000184FD2410-0x0000000184FD2420
	
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

	internal class DynamicHeightVirtualizationController<T> : VerticalVirtualizationController<T> // TypeDefIndex: 71464
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
		private float defaultExpectedHeight { get; }
		private float contentPadding { get; set; }
		private float contentHeight { get; set; }
		private int anchoredIndex { get; set; }
		private float anchorOffset { get; set; }
		private float viewportMaxOffset { get; }
		protected override bool alwaysRebindOnRefresh { get; }
	
		// Nested types
		[IsReadOnly]
		private struct ContentHeightCacheInfo // TypeDefIndex: 71461
		{
			// Fields
			public readonly float sum;
			public readonly int count;
	
			// Constructors
			public ContentHeightCacheInfo(float sum, int count);
		}
	
		private enum VirtualizationChange // TypeDefIndex: 71462
		{
			None = 0,
			Resize = 1,
			Scroll = 2,
			ForcedScroll = 3
		}
	
		private enum ScrollDirection // TypeDefIndex: 71463
		{
			Idle = 0,
			Up = 1,
			Down = 2
		}
	
		// Constructors
		public DynamicHeightVirtualizationController(BaseVerticalCollectionView collectionView);
	
		// Methods
		public override void Refresh(bool rebuild);
		public override void ScrollToItem(int index);
		public override void Resize(Vector2 size);
		public override void OnScroll(Vector2 scrollOffset);
		private void OnScrollUpdate();
		private void CycleItems(int firstIndex);
		private bool NeedsFill();
		private void Fill();
		private void UpdateScrollViewContainer(float previousHeight, float newHeight);
		private void ApplyScrollViewUpdate(bool dimensionsOnly = false /* Metadata: 0x0262238C */);
		private void UpdateAnchor();
		private void ScheduleFill();
		private void ScheduleScroll();
		private void ScheduleScrollDirectionReset();
		private void ResetScroll();
		public override int GetIndexFromPosition(Vector2 position);
		public override float GetExpectedItemHeight(int index);
		private int GetFirstVisibleItem(float offset);
		public override float GetExpectedContentHeight();
		private float GetContentHeightForIndex(int lastIndex);
		private ContentHeightCacheInfo GetCachedContentHeight(int index);
		private void RegisterItemHeight(int index, float height);
		private void UnregisterItemHeight(int index);
		private void CleanItemHeightCache();
		private void OnRecycledItemGeometryChanged(ReusableCollectionItem item);
		private bool UpdateRegisteredHeight(ReusableCollectionItem item);
		internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x0262238D */, int scrollViewIndex = -1 /* Metadata: 0x0262238E */);
		internal override void ReleaseItem(int activeItemsIndex);
		internal override void StartDragItem(ReusableCollectionItem item);
		internal override void EndDrag(int dropIndex);
		private void HideItem(int activeItemsIndex);
		private void MarkWaitingForLayout(T item);
		private bool IsIndexOutOfBounds(int i);
	}

	internal class FixedHeightVirtualizationController<T> : VerticalVirtualizationController<T> // TypeDefIndex: 71465
		where T : ReusableCollectionItem, new()
	{
		// Properties
		private float resolvedItemHeight { get; }
	
		// Constructors
		public FixedHeightVirtualizationController(BaseVerticalCollectionView collectionView);
	
		// Methods
		protected override bool VisibleItemPredicate(T i);
		public override int GetIndexFromPosition(Vector2 position);
		public override float GetExpectedItemHeight(int index);
		public override float GetExpectedContentHeight();
		public override void ScrollToItem(int index);
		public override void Resize(Vector2 size);
		public override void OnScroll(Vector2 scrollOffset);
		internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x02622396 */, int scrollViewIndex = -1 /* Metadata: 0x02622397 */);
		internal override void EndDrag(int dropIndex);
	}

	internal class ReusableCollectionItem // TypeDefIndex: 71466
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _bindableElement_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ValueAnimation<StyleValues> _animator_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _index_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _id_k__BackingField; // 0x24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isDragGhost_k__BackingField; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ReusableCollectionItem> onGeometryChanged; // 0x30
		protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ReusableCollectionItem> onDestroy; // 0x40
	
		// Properties
		public virtual VisualElement rootElement { get; } // 0x00000001829260F0-0x0000000182926100 
		public VisualElement bindableElement { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public ValueAnimation<StyleValues> animator { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public int index { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public int id { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		internal bool isDragGhost { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
	
		// Events
		public event Action<ReusableCollectionItem> onGeometryChanged {
			add; // 0x000000018D61DF28-0x000000018D61DFB4
			remove; // 0x000000018D61E040-0x000000018D61E0CC
		}
		internal event Action<ReusableCollectionItem> onDestroy {
			add; // 0x000000018D61DE9C-0x000000018D61DF28
			remove; // 0x000000018D61DFB4-0x000000018D61E040
		}
	
		// Constructors
		public ReusableCollectionItem(); // 0x000000018D61DE18-0x000000018D61DE9C
	
		// Methods
		public virtual void Init(VisualElement item); // 0x0000000184FD2410-0x0000000184FD2420
		public virtual void PreAttachElement(); // 0x000000018D61DB68-0x000000018D61DC14
		public virtual void DetachElement(); // 0x000000018D61DA5C-0x000000018D61DB50
		public virtual void DestroyElement(); // 0x000000018D61DA44-0x000000018D61DA5C
		public virtual void SetSelected(bool selected); // 0x000000018D61DD14-0x000000018D61DE18
		public virtual void SetDragGhost(bool dragGhost); // 0x000000018D61DC14-0x000000018D61DD14
		protected void OnGeometryChanged(GeometryChangedEvent evt); // 0x000000018D61DB50-0x000000018D61DB68
	}

	internal class ReusableListViewItem : ReusableCollectionItem // TypeDefIndex: 71467
	{
		// Fields
		private VisualElement m_Container; // 0x48
		private VisualElement m_DragHandle; // 0x50
		private VisualElement m_ItemContainer; // 0x58
	
		// Properties
		public override VisualElement rootElement { get; } // 0x000000018D61E708-0x000000018D61E718 
	
		// Constructors
		public ReusableListViewItem(); // 0x000000018D61E700-0x000000018D61E708
	
		// Methods
		public void Init(VisualElement item, bool usesAnimatedDragger); // 0x000000018D61E144-0x000000018D61E20C
		protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger); // 0x000000018D61E41C-0x000000018D61E700
		public void UpdateDragHandle(bool needsDragHandle); // 0x000000018D61E308-0x000000018D61E41C
		public override void PreAttachElement(); // 0x000000018D61E20C-0x000000018D61E284
		public override void DetachElement(); // 0x000000018D61E0CC-0x000000018D61E144
		public override void SetDragGhost(bool dragGhost); // 0x000000018D61E284-0x000000018D61E308
	}

	internal class ReusableMultiColumnListViewItem : ReusableListViewItem // TypeDefIndex: 71468
	{
		// Properties
		public override VisualElement rootElement { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public ReusableMultiColumnListViewItem(); // 0x000000018D61E700-0x000000018D61E708
	
		// Methods
		public override void Init(VisualElement item); // 0x0000000186805BA0-0x0000000186805BB0
		public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag); // 0x000000018D61E718-0x000000018D61E944
	}

	internal class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem // TypeDefIndex: 71469
	{
		// Properties
		public override VisualElement rootElement { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public ReusableMultiColumnTreeViewItem(); // 0x000000018D61EB58-0x000000018D61EB60
	
		// Methods
		public override void Init(VisualElement item); // 0x0000000186805BA0-0x0000000186805BB0
		public void Init(VisualElement container, Columns columns); // 0x000000018D61E944-0x000000018D61EB58
	}

	internal class ReusableTreeViewItem : ReusableCollectionItem // TypeDefIndex: 71470
	{
		// Fields
		private Toggle m_Toggle; // 0x48
		private VisualElement m_Container; // 0x50
		private VisualElement m_IndentElement; // 0x58
		private VisualElement m_BindableContainer; // 0x60
		private VisualElement m_Checkmark; // 0x68
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<PointerUpEvent> onPointerUp; // 0x70
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ChangeEvent<bool>> onToggleValueChanged; // 0x78
		private int m_Depth; // 0x80
		private float m_IndentWidth; // 0x84
		private EventCallback<PointerUpEvent> m_PointerUpCallback; // 0x88
		private EventCallback<ChangeEvent<bool>> m_ToggleValueChangedCallback; // 0x90
		private EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback; // 0x98
	
		// Properties
		public override VisualElement rootElement { get; } // 0x000000018D61F78C-0x000000018D61F79C 
	
		// Events
		public event Action<PointerUpEvent> onPointerUp {
			add; // 0x000000018D61F674-0x000000018D61F700
			remove; // 0x000000018D61F79C-0x000000018D61F828
		}
		public event Action<ChangeEvent<bool>> onToggleValueChanged {
			add; // 0x000000018D61F700-0x000000018D61F78C
			remove; // 0x000000018D61F828-0x000000018D61F8B4
		}
	
		// Constructors
		public ReusableTreeViewItem(); // 0x000000018D61F53C-0x000000018D61F674
	
		// Methods
		public override void Init(VisualElement item); // 0x000000018D61F0E8-0x000000018D61F1C0
		protected void InitExpandHierarchy(VisualElement root, VisualElement item); // 0x000000018D61ECF4-0x000000018D61F0E8
		public override void PreAttachElement(); // 0x000000018D61F2BC-0x000000018D61F438
		public override void DetachElement(); // 0x000000018D61EB60-0x000000018D61ECDC
		public void Indent(int depth); // 0x000000018D61ECDC-0x000000018D61ECF4
		public void SetExpandedWithoutNotify(bool expanded); // 0x000000018D61F438-0x000000018D61F450
		public void SetToggleVisibility(bool visible); // 0x000000018D61F450-0x000000018D61F46C
		private void OnToggleGeometryChanged(GeometryChangedEvent evt); // 0x000000018D61F1D4-0x000000018D61F2A8
		private void UpdateIndentLayout(); // 0x000000018D61F46C-0x000000018D61F53C
		private void OnPointerUp(PointerUpEvent evt); // 0x000000018D61F1C0-0x000000018D61F1D4
		private void OnToggleValueChanged(ChangeEvent<bool> evt); // 0x000000018D61F2A8-0x000000018D61F2BC
	}

	internal abstract class VerticalVirtualizationController<T> : CollectionVirtualizationController // TypeDefIndex: 71472
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
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71471
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<T> __9__30_0;
			public static Action<T> __9__30_1;
			public static Action<T> __9__30_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal T _.ctor_b__30_0();
			internal void _.ctor_b__30_1(T i);
			internal void _.ctor_b__30_2(T i);
		}
	
		// Constructors
		protected VerticalVirtualizationController(BaseVerticalCollectionView collectionView);
	
		// Methods
		protected virtual bool VisibleItemPredicate(T i);
		public override void Refresh(bool rebuild);
		protected void Setup(T recycledItem, int newIndex);
		public override void OnFocus(VisualElement leafTarget);
		public override void OnBlur(VisualElement willFocus);
		private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex);
		public override void UpdateBackground();
		internal override void StartDragItem(ReusableCollectionItem item);
		internal override void EndDrag(int dropIndex);
		internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x02622398 */, int scrollViewIndex = -1 /* Metadata: 0x02622399 */);
		internal virtual void ReleaseItem(int activeItemsIndex);
		private void OnDestroyItem(ReusableCollectionItem item);
		protected int GetDraggedIndex();
	}

	public abstract class BaseBoolField : BaseField<bool> // TypeDefIndex: 71473
	{
		// Fields
		protected Label m_Label; // 0x418
		protected readonly VisualElement m_CheckMark; // 0x420
		internal Clickable m_Clickable; // 0x428
		private string m_OriginalText; // 0x430
	
		// Properties
		public string text { get; set; } // 0x000000018D60D98C-0x000000018D60D9AC 0x000000018D60D9AC-0x000000018D60DA38
	
		// Constructors
		public BaseBoolField(string label); // 0x000000018D60D700-0x000000018D60D98C
	
		// Methods
		private void OnNavigationSubmit(NavigationSubmitEvent evt); // 0x000000018D60D490-0x000000018D60D4BC
		private void OnKeyDown(KeyDownEvent evt); // 0x000000018D60D408-0x000000018D60D490
		protected virtual void InitLabel(); // 0x000000018D60D1F4-0x000000018D60D290
		public override void SetValueWithoutNotify(bool newValue); // 0x000000018D60D4BC-0x000000018D60D570
		private void OnClickEvent(EventBase evt); // 0x000000018D60D290-0x000000018D60D408
		protected virtual void ToggleValue(); // 0x000000018D60D570-0x000000018D60D5A0
		protected override void UpdateMixedValueContent(); // 0x000000018D60D5A0-0x000000018D60D700
	}

	public abstract class BaseField<TValueType> : BindableElement, INotifyValueChanged<TValueType> // TypeDefIndex: 71475
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
		[SerializeField]
		private TValueType m_Value;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Label _labelElement_k__BackingField;
		private bool m_ShowMixedValue;
		private Label m_MixedValueLabel;
		private VisualElement m_CachedInspectorElement;
		private int m_CachedListAndFoldoutDepth;
	
		// Properties
		internal VisualElement visualInput { get; set; }
		protected TValueType rawValue { get; set; }
		public virtual TValueType value { get; set; }
		public Label labelElement { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string label { get; set; }
		public bool showMixedValue { get; set; }
		protected Label mixedValueLabel { get; }
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 71474
		{
			// Fields
			private UxmlStringAttributeDescription m_Label;
	
			// Constructors
			public UxmlTraits();
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
			internal static List<string> ParseChoiceList(string choicesFromBag);
		}
	
		// Constructors
		internal BaseField(string label);
		protected BaseField(string label, VisualElement visualInput);
		static BaseField();
	
		// Methods
		private void OnAttachToPanel(AttachToPanelEvent e);
		private void OnCustomStyleResolved(CustomStyleResolvedEvent evt);
		private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e);
		private void AlignLabel();
		protected virtual void UpdateMixedValueContent();
		public virtual void SetValueWithoutNotify(TValueType newValue);
		internal override void OnViewDataReady();
		internal override Rect GetTooltipRect();
	}

	public class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : BaseField<TValueType> // TypeDefIndex: 71476
		where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
	{
		// Fields
		private TValueUxmlAttributeType m_Value;
	
		// Constructors
		public BaseFieldTraits();
	
		// Methods
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
	}

	public enum ListViewReorderMode // TypeDefIndex: 71477
	{
		Simple = 0,
		Animated = 1
	}

	public abstract class BaseListView : BaseVerticalCollectionView // TypeDefIndex: 71479
	{
		// Fields
		private static readonly string k_SizeFieldLabel; // 0x00
		private bool m_ShowBoundCollectionSize; // 0x4A8
		private bool m_ShowFoldoutHeader; // 0x4A9
		private string m_HeaderTitle; // 0x4B0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> itemsAdded; // 0x4B8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> itemsRemoved; // 0x4C0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action itemsSourceSizeChanged; // 0x4C8
		private Label m_ListViewLabel; // 0x4D0
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
		public bool showBoundCollectionSize { get; set; } // 0x00000001872630A0-0x00000001872630B0 0x000000018D60FA20-0x000000018D60FA38
		public bool showFoldoutHeader { get; set; } // 0x00000001872630B0-0x00000001872630C0 0x000000018D60FA38-0x000000018D60FCA0
		public string headerTitle { set; } // 0x000000018D60F98C-0x000000018D60F9CC
		public bool showAddRemoveFooter { get; set; } // 0x000000018D60F8A8-0x000000018D60F8B4 0x000000018D60FA18-0x000000018D60FA20
		internal VisualElement footer { get; } // 0x000000018723A420-0x000000018723A430 
		public new BaseListViewController viewController { get; } // 0x000000018D60F8B4-0x000000018D60F8F4 
		public ListViewReorderMode reorderMode { get; set; } // 0x0000000187263090-0x00000001872630A0 0x000000018D60F9CC-0x000000018D60FA18
	
		// Events
		internal event Action reorderModeChanged {
			add; // 0x000000018D60F810-0x000000018D60F8A8
			remove; // 0x000000018D60F8F4-0x000000018D60F98C
		}
	
		// Nested types
		public class UxmlTraits : BaseVerticalCollectionView.UxmlTraits // TypeDefIndex: 71478
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; // 0xB0
			private readonly UxmlStringAttributeDescription m_HeaderTitle; // 0xB8
			private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; // 0xC0
			private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode; // 0xC8
			private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; // 0xD0
	
			// Constructors
			protected UxmlTraits(); // 0x000000018D6211F8-0x000000018D62148C
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D620AF4-0x000000018D620CAC
		}
	
		// Constructors
		public BaseListView(); // 0x000000018D60F788-0x000000018D60F810
		static BaseListView(); // 0x000000018D60F0A0-0x000000018D60F788
	
		// Methods
		internal void SetupArraySizeField(); // 0x000000018D60EA18-0x000000018D60ED64
		private void EnableFooter(bool enabled); // 0x000000018D60DB80-0x000000018D60DFA0
		private void AddItems(int itemCount); // 0x000000018D60DA38-0x000000018D60DA64
		private void OnArraySizeFieldChanged(ChangeEvent<string> evt); // 0x000000018D60E3D0-0x000000018D60E5BC
		internal void UpdateArraySizeField(); // 0x000000018D60EDAC-0x000000018D60EE6C
		internal void UpdateListViewLabel(); // 0x000000018D60EE6C-0x000000018D60F0A0
		private void OnAddClicked(); // 0x000000018D60E2B8-0x000000018D60E3D0
		private void OnRemoveClicked(); // 0x000000018D60E664-0x000000018D60E798
		private protected override void CreateVirtualizationController(); // 0x000000018D60DB44-0x000000018D60DB80
		public override void SetViewController(CollectionViewController controller); // 0x000000018D60E7C4-0x000000018D60EA18
		private void OnItemAdded(IEnumerable<int> indices); // 0x000000018D60E5BC-0x000000018D60E5D4
		private void OnItemsRemoved(IEnumerable<int> indices); // 0x000000018D60E5D4-0x000000018D60E5EC
		private void OnItemsSourceSizeChanged(); // 0x000000018D60E5EC-0x000000018D60E664
		internal override ListViewDragger CreateDragger(); // 0x000000018D60DAC4-0x000000018D60DB44
		internal override ICollectionDragAndDropController CreateDragAndDropController(); // 0x000000018D60DA64-0x000000018D60DAC4
		private protected override void PostRefresh(); // 0x000000018D60E798-0x000000018D60E7C4
		private protected override bool HandleItemNavigation(bool moveIn, bool altPressed); // 0x000000018D60DFA0-0x000000018D60E2B8
		[CompilerGenerated]
		private void _OnAddClicked_b__38_0(); // 0x000000018D60ED64-0x000000018D60EDAC
	}

	public enum SliderDirection // TypeDefIndex: 71480
	{
		Horizontal = 0,
		Vertical = 1
	}

	public abstract class BaseSlider<TValueType> : BaseField<TValueType> // TypeDefIndex: 71482
		where TValueType : IComparable<TValueType>
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _dragContainer_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _dragElement_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _dragBorderElement_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextField _inputTextField_k__BackingField;
		[SerializeField]
		private TValueType m_LowValue;
		[SerializeField]
		private TValueType m_HighValue;
		private float m_PageSize;
		private bool m_ShowInputField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _clamped_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
		internal VisualElement dragContainer { [CompilerGenerated] get; [CompilerGenerated] private set; }
		internal VisualElement dragElement { [CompilerGenerated] get; [CompilerGenerated] private set; }
		internal VisualElement dragBorderElement { [CompilerGenerated] get; [CompilerGenerated] private set; }
		internal TextField inputTextField { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public TValueType lowValue { get; set; }
		public TValueType highValue { get; set; }
		public virtual float pageSize { get; set; }
		public virtual bool showInputField { get; set; }
		internal bool clamped { [CompilerGenerated] get; [CompilerGenerated] set; }
		internal ClampedDragger<TValueType> clampedDragger { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override TValueType value { get; set; }
		public SliderDirection direction { get; set; }
		public bool inverted { get; set; }
	
		// Nested types
		internal enum SliderKey // TypeDefIndex: 71481
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
		internal BaseSlider(string label, TValueType start, TValueType end, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x0262239E */, float pageSize = 0f /* Metadata: 0x0262239F */);
		static BaseSlider();
	
		// Methods
		internal void SetHighValueWithoutNotify(TValueType newHighValue);
		private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound);
		private TValueType GetClampedValue(TValueType newValue);
		public override void SetValueWithoutNotify(TValueType newValue);
		protected static float GetClosestPowerOfTen(float positiveNumber);
		protected static float RoundToMultipleOf(float value, float roundingValue);
		private void ClampValue();
		internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);
		internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);
		internal abstract TValueType ParseStringToValue(string stringValue);
		internal abstract void ComputeValueFromKey(SliderKey sliderKey, bool isShift);
		private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant);
		private void SetSliderValueFromDrag();
		private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos);
		private void SetSliderValueFromClick();
		private void OnKeyDown(KeyDownEvent evt);
		internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos);
		public void AdjustDragElement(float factor);
		private void UpdateDragElementPosition(GeometryChangedEvent evt);
		internal override void OnViewDataReady();
		private bool SameValues(float a, float b, float epsilon);
		private void UpdateDragElementPosition();
		protected override void ExecuteDefaultAction(EventBase evt);
		private void UpdateTextFieldVisibility();
		private void UpdateTextFieldValue();
		private void OnTextFieldFocusOut(FocusOutEvent evt);
		private void OnTextFieldValueChange(ChangeEvent<string> evt);
		protected override void UpdateMixedValueContent();
	}

	public abstract class BaseTreeView : BaseVerticalCollectionView // TypeDefIndex: 71484
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string itemUssClassName; // 0x08
		public static readonly string itemToggleUssClassName; // 0x10
		public static readonly string itemIndentsContainerUssClassName; // 0x18
		public static readonly string itemIndentUssClassName; // 0x20
		public static readonly string itemContentContainerUssClassName; // 0x28
		private bool m_AutoExpand; // 0x4A8
		[SerializeField]
		private List<int> m_ExpandedItemIds; // 0x4B0
	
		// Properties
		public new IList itemsSource { get; } // 0x000000018D61316C-0x000000018D613194 
		public new BaseTreeViewController viewController { get; } // 0x000000018D613194-0x000000018D6131D4 
		public bool autoExpand { get; set; } // 0x00000001872630A0-0x00000001872630B0 0x000000018D6131D4-0x000000018D613208
		internal List<int> expandedItemIds { get; set; } // 0x0000000184736900-0x0000000184736910 0x0000000188DC4958-0x0000000188DC496C
	
		// Nested types
		public class UxmlTraits : BaseVerticalCollectionView.UxmlTraits // TypeDefIndex: 71483
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_AutoExpand; // 0xB0
	
			// Constructors
			public UxmlTraits(); // 0x000000018D621974-0x000000018D621A18
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D620DB4-0x000000018D620E88
		}
	
		// Constructors
		public BaseTreeView(); // 0x000000018D61315C-0x000000018D61316C
		public BaseTreeView(int itemHeight); // 0x000000018D613014-0x000000018D61315C
		static BaseTreeView(); // 0x000000018D612E10-0x000000018D613014
	
		// Methods
		private protected override void CreateVirtualizationController(); // 0x000000018D612544-0x000000018D612580
		public override void SetViewController(CollectionViewController controller); // 0x000000018D612CE0-0x000000018D612E04
		private new void OnItemIndexChanged(int srcIndex, int dstIndex); // 0x000000018D612AF8-0x000000018D612B00
		internal override ICollectionDragAndDropController CreateDragAndDropController(); // 0x000000018D6124E4-0x000000018D612544
		internal override void OnViewDataReady(); // 0x000000018D612B38-0x000000018D612B88
		private protected override bool HandleItemNavigation(bool moveIn, bool altPressed); // 0x000000018D612744-0x000000018D612AA0
		public void SetSelectionById(int id); // 0x000000018D612B94-0x000000018D612C08
		public void SetSelectionById(IEnumerable<int> ids); // 0x000000018D612B88-0x000000018D612B94
		internal void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification); // 0x000000018D612C08-0x000000018D612CE0
		private int GetItemIndex(int id, bool expand = false /* Metadata: 0x026223AA */); // 0x000000018D612650-0x000000018D612744
		public bool IsExpanded(int id); // 0x000000018D612ACC-0x000000018D612AF8
		public void CollapseItem(int id, bool collapseAllChildren = false /* Metadata: 0x026223AB */); // 0x000000018D612490-0x000000018D6124E4
		public void ExpandItem(int id, bool expandAllChildren = false /* Metadata: 0x026223AC */); // 0x000000018D612608-0x000000018D612650
		private void OnTreeViewPointerUp(PointerUpEvent evt); // 0x000000018D612B00-0x000000018D612B38
		private bool IsExpandedByIndex(int index); // 0x000000018D612AA0-0x000000018D612ACC
		private void CollapseItemByIndex(int index, bool collapseAll); // 0x000000018D612410-0x000000018D612490
		private void ExpandItemByIndex(int index, bool expandAll); // 0x000000018D612580-0x000000018D612608
		[CompilerGenerated]
		private int _SetSelectionInternalById_b__47_0(int id); // 0x000000018D612E04-0x000000018D612E10
	}

	public enum AlternatingRowBackground // TypeDefIndex: 71485
	{
		None = 0,
		ContentOnly = 1,
		All = 2
	}

	public enum CollectionVirtualizationMethod // TypeDefIndex: 71486
	{
		FixedHeight = 0,
		DynamicHeight = 1
	}

	[Serializable]
	internal class SerializedVirtualizationData // TypeDefIndex: 71487
	{
		// Fields
		public Vector2 scrollOffset; // 0x10
		public int firstVisibleIndex; // 0x18
		public float contentPadding; // 0x1C
		public float contentHeight; // 0x20
		public int anchoredItemIndex; // 0x24
		public float anchorOffset; // 0x28
	
		// Constructors
		public SerializedVirtualizationData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver // TypeDefIndex: 71494
	{
		// Fields
		private static readonly ProfilerMarker k_RefreshMarker; // 0x00
		private static readonly ProfilerMarker k_RebuildMarker; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<object>> itemsChosen; // 0x3D0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<object>> selectionChanged; // 0x3D8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> selectedIndicesChanged; // 0x3E0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<int, int> itemIndexChanged; // 0x3E8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action itemsSourceChanged; // 0x3F0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action selectionNotChanged; // 0x3F8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<CanStartDragArgs, bool> canStartDrag; // 0x400
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop; // 0x408
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate; // 0x410
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop; // 0x418
		private SelectionType m_SelectionType; // 0x420
		private static readonly List<ReusableCollectionItem> k_EmptyItems; // 0x10
		private bool m_HorizontalScrollingEnabled; // 0x424
		[SerializeField]
		private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; // 0x428
		internal static readonly int s_DefaultItemHeight; // 0x18
		internal float m_FixedItemHeight; // 0x42C
		internal bool m_ItemHeightIsInline; // 0x430
		private CollectionVirtualizationMethod m_VirtualizationMethod; // 0x434
		private readonly ScrollView m_ScrollView; // 0x438
		private CollectionViewController m_ViewController; // 0x440
		private CollectionVirtualizationController m_VirtualizationController; // 0x448
		private KeyboardNavigationManipulator m_NavigationManipulator; // 0x450
		[SerializeField]
		internal SerializedVirtualizationData serializedVirtualizationData; // 0x458
		[SerializeField]
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
		public IList itemsSource { get; set; } // 0x000000018D617E58-0x000000018D617E7C 0x000000018D61814C-0x000000018D61817C
		public override VisualElement contentContainer { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public SelectionType selectionType { get; set; } // 0x00000001872630E0-0x00000001872630F0 0x000000018D6181E0-0x000000018D618248
		public IEnumerable<object> selectedItems { get; } // 0x000000018D617F74-0x000000018D617FE4 
		public int selectedIndex { get; set; } // 0x000000018D617F0C-0x000000018D617F54 0x000000018D615BD0-0x000000018D615BD8
		public IEnumerable<int> selectedIndices { get; } // 0x000000018D617F54-0x000000018D617F74 
		internal IEnumerable<int> selectedIds { get; } // 0x000000018D617EEC-0x000000018D617F0C 
		internal IEnumerable<ReusableCollectionItem> activeItems { get; } // 0x000000018D617DF4-0x000000018D617E58 
		internal ScrollView scrollView { get; } // 0x000000018723A340-0x000000018723A350 
		internal ListViewDragger dragger { get; } // 0x000000018723A210-0x000000018723A220 
		internal CollectionVirtualizationController virtualizationController { get; } // 0x000000018D617FE4-0x000000018D617FEC 
		public CollectionViewController viewController { get; } // 0x000000018723C090-0x000000018723C0A0 
		public bool showBorder { set; } // 0x000000018D618260-0x000000018D6182D4
		public bool reorderable { get; set; } // 0x000000018D617E7C-0x000000018D617EEC 0x000000018D61817C-0x000000018D6181E0
		public bool horizontalScrollingEnabled { set; } // 0x000000018D6180E8-0x000000018D61814C
		public AlternatingRowBackground showAlternatingRowBackgrounds { get; set; } // 0x00000001872630F0-0x0000000187263100 0x000000018D618248-0x000000018D618260
		public CollectionVirtualizationMethod virtualizationMethod { get; set; } // 0x0000000187263100-0x0000000187263110 0x000000018D6182D4-0x000000018D61830C
		public float fixedItemHeight { get; set; } // 0x00000001872630C0-0x00000001872630D0 0x000000018D617FEC-0x000000018D6180E8
		internal float lastHeight { get; } // 0x00000001872630D0-0x00000001872630E0 
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 71488
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
			public UxmlTraits(); // 0x000000018D62148C-0x000000018D621874
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D620E88-0x000000018D6210C0
		}
	
		private class Selection // TypeDefIndex: 71489
		{
			// Fields
			private readonly HashSet<int> m_IndexLookup; // 0x10
			private readonly HashSet<int> m_IdLookup; // 0x18
			private int m_MinIndex; // 0x20
			private int m_MaxIndex; // 0x24
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<int> _selectedIds_k__BackingField; // 0x28
			public readonly List<int> indices; // 0x30
			public readonly Dictionary<int, object> items; // 0x38
	
			// Properties
			public List<int> selectedIds { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
			public int indexCount { get; } // 0x000000018D61FF80-0x000000018D61FFC0 
			public int idCount { get; } // 0x000000018D61FF40-0x000000018D61FF80 
			public int minIndex { get; } // 0x000000018D61FFE8-0x000000018D620010 
			public int maxIndex { get; } // 0x000000018D61FFC0-0x000000018D61FFE8 
			public int capacity { get; set; } // 0x000000018D61FEF8-0x000000018D61FF40 0x000000018D620010-0x000000018D6200A0
	
			// Constructors
			public Selection(); // 0x000000018D61FDAC-0x000000018D61FEF8
	
			// Methods
			public int FirstIndex(); // 0x000000018D61FBDC-0x000000018D61FC44
			public bool ContainsIndex(int index); // 0x000000018D61FB88-0x000000018D61FBDC
			public bool ContainsId(int id); // 0x000000018D61FB34-0x000000018D61FB88
			public void AddId(int id); // 0x000000018D61F8B4-0x000000018D61F92C
			public void AddIndex(int index, object obj); // 0x000000018D61F92C-0x000000018D61F9E8
			public bool TryRemove(int index); // 0x000000018D61FCBC-0x000000018D61FDAC
			public void RemoveId(int id); // 0x000000018D61FC44-0x000000018D61FCBC
			public void ClearItems(); // 0x000000018D61FAC0-0x000000018D61FB08
			public void ClearIds(); // 0x000000018D61F9E8-0x000000018D61FA50
			public void ClearIndices(); // 0x000000018D61FA50-0x000000018D61FAC0
			public void Clear(); // 0x000000018D61FB08-0x000000018D61FB34
		}
	
		[CompilerGenerated]
		private sealed class _get_selectedItems_d__72 : IEnumerable<object>, IEnumerator<object> // TypeDefIndex: 71490
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_selectedItems_d__72(int __1__state); // 0x000000018B707D6C-0x000000018B707DA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D620910-0x000000018D62098C
			private bool MoveNext(); // 0x000000018D62048C-0x000000018D62081C
			private void __m__Finally1(); // 0x000000018D62098C-0x000000018D6209C8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D6208C4-0x000000018D620910
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator(); // 0x000000018D62081C-0x000000018D6208BC
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6208BC-0x000000018D6208C4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass163_0 // TypeDefIndex: 71491
		{
			// Fields
			public int id; // 0x10
	
			// Constructors
			public __c__DisplayClass163_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetRootElementForId_b__0(ReusableCollectionItem t); // 0x000000018D620408-0x000000018D620428
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass173_0 // TypeDefIndex: 71492
		{
			// Fields
			public bool selectedIndicesChanged; // 0x00
			public BaseVerticalCollectionView __4__this; // 0x08
			public int previousSelectionCount; // 0x10
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass184_0 // TypeDefIndex: 71493
		{
			// Fields
			public BaseVerticalCollectionView __4__this; // 0x00
			public bool shiftKey; // 0x08
		}
	
		// Constructors
		public BaseVerticalCollectionView(); // 0x000000018D617714-0x000000018D617D5C
		public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1f /* Metadata: 0x026223B6 */); // 0x000000018D617D5C-0x000000018D617DF4
		static BaseVerticalCollectionView(); // 0x000000018D617244-0x000000018D617714
	
		// Methods
		internal bool HasCanStartDrag(); // 0x000000018D6147F4-0x000000018D614800
		internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<int> ids); // 0x000000018D615BD8-0x000000018D615C74
		internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<int> ids, StartDragArgs args); // 0x000000018D615D84-0x000000018D615E78
		internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs); // 0x000000018D615CFC-0x000000018D615D84
		internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs); // 0x000000018D615C74-0x000000018D615CFC
		internal float ResolveItemHeight(float height = -1f /* Metadata: 0x026223B2 */); // 0x000000018D6168D8-0x000000018D616928
		private protected virtual void CreateVirtualizationController(); // 0x000000018D613E60-0x000000018D613E9C
		internal CollectionVirtualizationController GetOrCreateVirtualizationController(); // 0x000000018D6146D0-0x000000018D614708
		internal void CreateVirtualizationController<T>()
			where T : ReusableCollectionItem, new();
		internal CollectionViewController GetOrCreateViewController(); // 0x000000018D614664-0x000000018D6146D0
		protected abstract CollectionViewController CreateViewController();
		public virtual void SetViewController(CollectionViewController controller); // 0x000000018D617004-0x000000018D6170FC
		internal virtual ListViewDragger CreateDragger(); // 0x000000018D613E00-0x000000018D613E60
		internal void InitializeDragAndDropController(bool enableReordering); // 0x000000018D614828-0x000000018D61491C
		internal abstract ICollectionDragAndDropController CreateDragAndDropController();
		public VisualElement GetRootElementForId(int id); // 0x000000018D614708-0x000000018D6147F4
		internal virtual bool HasValidDataAndBindings(); // 0x000000018D614800-0x000000018D614828
		private void OnItemIndexChanged(int srcIndex, int dstIndex); // 0x000000018D61531C-0x000000018D615348
		private void OnItemsSourceChanged(); // 0x000000018D615348-0x000000018D61535C
		public void RefreshItems(); // 0x000000018D615FD0-0x000000018D616148
		public void Rebuild(); // 0x000000018D615E78-0x000000018D615FD0
		internal void ScheduleRebuild(); // 0x000000018D616928-0x000000018D6169E4
		private void RefreshSelection(); // 0x000000018D616148-0x000000018D616650
		private protected virtual void PostRefresh(); // 0x000000018D615768-0x000000018D615820
		public void ScrollToItem(int index); // 0x000000018D616A50-0x000000018D616AA0
		public void ScrollToItemById(int id); // 0x000000018D6169E4-0x000000018D616A50
		private void OnScroll(Vector2 offset); // 0x000000018D6155C4-0x000000018D61561C
		private void Resize(Vector2 size); // 0x000000018D616864-0x000000018D6168D8
		private void OnAttachToPanel(AttachToPanelEvent evt); // 0x000000018D614BEC-0x000000018D614F38
		private void OnDetachFromPanel(DetachFromPanelEvent evt); // 0x000000018D615068-0x000000018D61531C
		private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey); // 0x000000018D61363C-0x000000018D613A48
		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent); // 0x000000018D613A48-0x000000018D613C44
		private protected virtual bool HandleItemNavigation(bool moveIn, bool altKey); // 0x0000000187232850-0x0000000187232860
		private void OnPointerMove(PointerMoveEvent evt); // 0x000000018D615488-0x000000018D615500
		private void OnPointerDown(PointerDownEvent evt); // 0x000000018D6153C4-0x000000018D615488
		private void OnPointerCancel(PointerCancelEvent evt); // 0x000000018D61535C-0x000000018D6153C4
		private void OnPointerUp(PointerUpEvent evt); // 0x000000018D615500-0x000000018D6155C4
		private void ProcessPointerDown(IPointerEvent evt); // 0x000000018D615820-0x000000018D61596C
		private void ProcessPointerUp(IPointerEvent evt); // 0x000000018D61596C-0x000000018D615BD0
		private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey); // 0x000000018D613FA8-0x000000018D6143E0
		internal void DoRangeSelection(int rangeSelectionFinalIndex); // 0x000000018D613E9C-0x000000018D613FA8
		private void ProcessSingleClick(int clickedIndex); // 0x000000018D615BD0-0x000000018D615BD8
		internal void SelectAll(); // 0x000000018D616AA0-0x000000018D616D3C
		public void AddToSelection(int index); // 0x000000018D613440-0x000000018D6134B0
		internal void AddToSelection(IList<int> indexes); // 0x000000018D6134B0-0x000000018D61363C
		private void AddToSelectionWithoutValidation(int index); // 0x000000018D613208-0x000000018D613440
		public void RemoveFromSelection(int index); // 0x000000018D616818-0x000000018D616864
		private void RemoveFromSelectionWithoutValidation(int index); // 0x000000018D616650-0x000000018D616818
		public void SetSelection(int index); // 0x000000018D616F80-0x000000018D617004
		public void SetSelection(IEnumerable<int> indices); // 0x000000018D616F74-0x000000018D616F80
		public void SetSelectionWithoutNotify(IEnumerable<int> indices); // 0x000000018D616F68-0x000000018D616F74
		internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification); // 0x000000018D616D3C-0x000000018D616F68
		private bool MatchesExistingSelection(IEnumerable<int> indices); // 0x000000018D61491C-0x000000018D614B74
		private void NotifyOfSelectionChange(); // 0x000000018D614B74-0x000000018D614BEC
		public void ClearSelection(); // 0x000000018D613DAC-0x000000018D613E00
		private void ClearSelectionWithoutValidation(); // 0x000000018D613C44-0x000000018D613DAC
		internal override void OnViewDataReady(); // 0x000000018D615728-0x000000018D615768
		protected override void ExecuteDefaultAction(EventBase evt); // 0x000000018D6143E0-0x000000018D614664
		private void OnSizeChanged(GeometryChangedEvent evt); // 0x000000018D61561C-0x000000018D615728
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e); // 0x000000018D614F38-0x000000018D615068
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018D617208-0x000000018D617244
		[CompilerGenerated]
		private void _.ctor_b__160_0(float v); // 0x000000018D6171F4-0x000000018D617208
		[CompilerGenerated]
		private void _RefreshSelection_g__NotifyIfChanged_173_0(ref __c__DisplayClass173_0 param_0009b64d); // 0x000000018D6171AC-0x000000018D6171F4
		[CompilerGenerated]
		private void _Apply_g__HandleSelectionAndScroll_184_0(int index, ref __c__DisplayClass184_0 param_0009b64f); // 0x000000018D6170FC-0x000000018D6171AC
	}

	public interface IBindable // TypeDefIndex: 71495
	{
		// Properties
		IBinding binding { get; }
		string bindingPath { set; }
	}

	public interface IBinding // TypeDefIndex: 71496
	{
		// Methods
		void PreUpdate();
		void Update();
		void Release();
	}

	public class Box : VisualElement // TypeDefIndex: 71498
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Box> // TypeDefIndex: 71497
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D620A40-0x000000018D620A7C
		}
	
		// Constructors
		public Box(); // 0x000000018D618368-0x000000018D6183DC
		static Box(); // 0x000000018D61830C-0x000000018D618368
	}

	public class Button : UnityEngine.UIElements.TextElement // TypeDefIndex: 71501
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private Clickable m_Clickable; // 0x488
		private static readonly string NonEmptyString; // 0x08
	
		// Properties
		public Clickable clickable { get; set; } // 0x0000000187263110-0x0000000187263120 0x000000018D618A78-0x000000018D618AE8
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Button, UxmlTraits> // TypeDefIndex: 71499
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D620A7C-0x000000018D620AB8
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 71500
		{
			// Constructors
			public UxmlTraits(); // 0x000000018D621B5C-0x000000018D621BA4
		}
	
		// Constructors
		public Button(); // 0x000000018D618A6C-0x000000018D618A78
		public Button(Action clickEvent); // 0x000000018D6188D4-0x000000018D618A6C
		static Button(); // 0x000000018D61883C-0x000000018D6188D4
	
		// Methods
		private void OnNavigationSubmit(NavigationSubmitEvent evt); // 0x000000018D618804-0x000000018D61883C
		private void OnKeyDown(KeyDownEvent evt); // 0x000000018D61876C-0x000000018D618804
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode); // 0x000000018D6186BC-0x000000018D61876C
	}

	internal class ButtonStripField : BaseField<int> // TypeDefIndex: 71504
	{
		// Fields
		private List<UnityEngine.UIElements.Button> m_Buttons; // 0x418
	
		// Properties
		private List<UnityEngine.UIElements.Button> buttons { get; } // 0x000000018D6185CC-0x000000018D6186BC 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits> // TypeDefIndex: 71502
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D620A04-0x000000018D620A40
		}
	
		public class UxmlTraits : BaseField<int> // TypeDefIndex: 71503
		{
			// Constructors
			public UxmlTraits(); // 0x000000018D621B20-0x000000018D621B5C
		}
	
		// Constructors
		public ButtonStripField(); // 0x000000018D61851C-0x000000018D6185CC
	
		// Methods
		public override void SetValueWithoutNotify(int newValue); // 0x000000018D618498-0x000000018D61851C
		private void RefreshButtonsState(); // 0x000000018D6183DC-0x000000018D618498
	}

	public class DropdownField : BaseField<string> // TypeDefIndex: 71509
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
		protected UnityEngine.UIElements.TextElement textElement { get; } // 0x0000000187263120-0x0000000187263130 
		public int index { set; } // 0x000000018D619F1C-0x000000018D619FAC
		public virtual List<string> choices { set; } // 0x000000018D619EBC-0x000000018D619F1C
		public override string value { get; set; } // 0x000000018D619E80-0x000000018D619EBC 0x000000018D619FAC-0x000000018D61A028
	
		// Nested types
		public class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits> // TypeDefIndex: 71505
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D6209C8-0x000000018D620A04
		}
	
		public class UxmlTraits : BaseField<string> // TypeDefIndex: 71506
		{
			// Fields
			private UxmlIntAttributeDescription m_Index; // 0x80
			private UxmlStringAttributeDescription m_Choices; // 0x88
	
			// Constructors
			public UxmlTraits(); // 0x000000018D621A18-0x000000018D621B20
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D6210C0-0x000000018D6211F8
		}
	
		private class PopupTextElement : UnityEngine.UIElements.TextElement // TypeDefIndex: 71507
		{
			// Constructors
			public PopupTextElement(); // 0x000000018D61D9F8-0x000000018D61DA44
	
			// Methods
			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode); // 0x000000018D61D960-0x000000018D61D9F8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0 // TypeDefIndex: 71508
		{
			// Fields
			public string item; // 0x10
			public DropdownField __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass38_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _AddMenuItems_b__0(); // 0x000000018D620464-0x000000018D62048C
		}
	
		// Constructors
		public DropdownField(); // 0x000000018D619E74-0x000000018D619E80
		public DropdownField(string label); // 0x000000018D619B5C-0x000000018D619E74
		static DropdownField(); // 0x000000018D6198DC-0x000000018D619B5C
	
		// Methods
		internal string GetValueToDisplay(); // 0x000000018D6195B0-0x000000018D619638
		internal string GetListItemToDisplay(string value); // 0x000000018D619508-0x000000018D6195B0
		internal void AddMenuItems(IGenericMenu menu); // 0x000000018D619080-0x000000018D6193A4
		private void ChangeValueFromMenu(string menuItem); // 0x000000018D6193A4-0x000000018D6193B8
		public override void SetValueWithoutNotify(string newValue); // 0x000000018D619638-0x000000018D6196F4
		protected override void ExecuteDefaultActionAtTarget(EventBase evt); // 0x000000018D6193B8-0x000000018D619508
		private void ShowMenu(); // 0x000000018D6196F4-0x000000018D61981C
		protected override void UpdateMixedValueContent(); // 0x000000018D61981C-0x000000018D6198DC
	}

	public class Foldout : BindableElement, INotifyValueChanged<bool> // TypeDefIndex: 71512
	{
		// Fields
		private Toggle m_Toggle; // 0x3D0
		private VisualElement m_Container; // 0x3D8
		[SerializeField]
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
		internal Toggle toggle { get; } // 0x000000018723A1D0-0x000000018723A1E0 
		public override VisualElement contentContainer { get; } // 0x000000018723C0C0-0x000000018723C0D0 
		public string text { set; } // 0x000000018D61A894-0x000000018D61A990
		public bool value { get; set; } // 0x0000000187263130-0x0000000187263140 0x000000018D61A990-0x000000018D61AAA8
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Foldout, UxmlTraits> // TypeDefIndex: 71510
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D620AB8-0x000000018D620AF4
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 71511
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
			private UxmlBoolAttributeDescription m_Value; // 0x80
	
			// Constructors
			public UxmlTraits(); // 0x000000018D621874-0x000000018D621974
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D620CAC-0x000000018D620DB4
		}
	
		// Constructors
		public Foldout(); // 0x000000018D61A53C-0x000000018D61A894
		static Foldout(); // 0x000000018D61A2CC-0x000000018D61A53C
	
		// Methods
		public void SetValueWithoutNotify(bool newValue); // 0x000000018D61A1E0-0x000000018D61A27C
		internal override void OnViewDataReady(); // 0x000000018D61A1A8-0x000000018D61A1E0
		private void OnAttachToPanel(AttachToPanelEvent evt); // 0x000000018D61A028-0x000000018D61A1A8
		[CompilerGenerated]
		private void _.ctor_b__25_0(ChangeEvent<bool> evt); // 0x000000018D61A27C-0x000000018D61A2CC
	}

	internal interface IGenericMenu // TypeDefIndex: 71513
	{
		// Methods
		void AddItem(string itemName, bool isChecked, Action action);
		void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false /* Metadata: 0x026223BA */);
	}

	public class GenericDropdownMenu : IGenericMenu // TypeDefIndex: 71516
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
		public VisualElement contentContainer { get; } // 0x000000018D61CE78-0x000000018D61CE9C 
	
		// Nested types
		internal class MenuItem // TypeDefIndex: 71514
		{
			// Fields
			public string name; // 0x10
			public VisualElement element; // 0x18
			public Action action; // 0x20
			public Action<object> actionUserData; // 0x28
	
			// Constructors
			public MenuItem(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass27_0 // TypeDefIndex: 71515
		{
			// Fields
			public GenericDropdownMenu __4__this; // 0x00
			public int selectedIndex; // 0x08
		}
	
		// Constructors
		public GenericDropdownMenu(); // 0x000000018D61CB48-0x000000018D61CE78
		static GenericDropdownMenu(); // 0x000000018D61C8EC-0x000000018D61CB48
	
		// Methods
		private void OnAttachToPanel(AttachToPanelEvent evt); // 0x000000018D61BB74-0x000000018D61BF2C
		private void OnDetachFromPanel(DetachFromPanelEvent evt); // 0x000000018D61BF34-0x000000018D61C25C
		private void Hide(); // 0x000000018D61BA90-0x000000018D61BB74
		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent); // 0x000000018D61B030-0x000000018D61B06C
		private bool Apply(KeyboardNavigationOperation op); // 0x000000018D61AE84-0x000000018D61B030
		private void OnPointerDown(PointerDownEvent evt); // 0x000000018D61C334-0x000000018D61C458
		private void OnPointerMove(PointerMoveEvent evt); // 0x000000018D61C458-0x000000018D61C57C
		private void OnPointerUp(PointerUpEvent evt); // 0x000000018D61C57C-0x000000018D61C6AC
		private void OnFocusOut(FocusOutEvent evt); // 0x000000018D61C25C-0x000000018D61C32C
		private void OnParentResized(GeometryChangedEvent evt); // 0x000000018D61C32C-0x000000018D61C334
		private void UpdateSelection(VisualElement target); // 0x000000018D61C7DC-0x000000018D61C8EC
		private void ChangeSelectedIndex(int newIndex, int previousIndex); // 0x000000018D61B06C-0x000000018D61B188
		private int GetSelectedIndex(); // 0x000000018D61BA08-0x000000018D61BA90
		public void AddItem(string itemName, bool isChecked, Action action); // 0x000000018D61AAA8-0x000000018D61AAE4
		public void AddSeparator(string path); // 0x000000018D61ADD8-0x000000018D61AE84
		private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data = null); // 0x000000018D61AAE4-0x000000018D61ADD8
		public void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false /* Metadata: 0x026223BB */); // 0x000000018D61B188-0x000000018D61B634
		private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt); // 0x000000018D61C32C-0x000000018D61C334
		private void OnContainerGeometryChanged(GeometryChangedEvent evt); // 0x000000018D61BF2C-0x000000018D61BF34
		private void EnsureVisibilityInParent(); // 0x000000018D61B634-0x000000018D61BA08
		[CompilerGenerated]
		private void _Apply_g__UpdateSelectionDown_27_0(int newIndex, ref __c__DisplayClass27_0 param_0009b6a1); // 0x000000018D61C6AC-0x000000018D61C74C
		[CompilerGenerated]
		private void _Apply_g__UpdateSelectionUp_27_1(int newIndex, ref __c__DisplayClass27_0 param_0009b6a3); // 0x000000018D61C74C-0x000000018D61C7DC
	}

	public class GroupBox : BindableElement, IGroupBox // TypeDefIndex: 71519
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		private Label m_TitleLabel; // 0x3D0
	
		// Properties
		public string text { set; } // 0x000000018D622548-0x000000018D622680
	
		// Nested types
		public class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits> // TypeDefIndex: 71517
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FEAC-0x000000018D62FEE8
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 71518
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
	
			// Constructors
			public UxmlTraits(); // 0x000000018D631DCC-0x000000018D631E5C
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D630ECC-0x000000018D630FAC
		}
	
		// Constructors
		public GroupBox(); // 0x000000018D62253C-0x000000018D622548
		public GroupBox(string text); // 0x000000018D6224C4-0x000000018D62253C
		static GroupBox(); // 0x000000018D622414-0x000000018D6224C4
	}

	public enum HelpBoxMessageType // TypeDefIndex: 71520
	{
		None = 0,
		Info = 1,
		Warning = 2,
		Error = 3
	}

	public class HelpBox : VisualElement // TypeDefIndex: 71523
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
		private Label m_Label; // 0x3D8
	
		// Properties
		public string text { set; } // 0x000000018D622BE8-0x000000018D622C0C
		public HelpBoxMessageType messageType { set; } // 0x000000018D622BC8-0x000000018D622BE8
	
		// Nested types
		public class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits> // TypeDefIndex: 71521
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FF24-0x000000018D62FF60
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 71522
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x70
			private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType; // 0x78
	
			// Constructors
			public UxmlTraits(); // 0x000000018D632138-0x000000018D632248
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D630DC8-0x000000018D630ECC
		}
	
		// Constructors
		public HelpBox(); // 0x000000018D6229F4-0x000000018D622A40
		public HelpBox(string text, HelpBoxMessageType messageType); // 0x000000018D622A40-0x000000018D622BC8
		static HelpBox(); // 0x000000018D6227EC-0x000000018D6229F4
	
		// Methods
		private string GetIconClass(HelpBoxMessageType messageType); // 0x000000018D622680-0x000000018D622728
		private void UpdateIcon(HelpBoxMessageType messageType); // 0x000000018D622728-0x000000018D6227EC
	}

	public class Image : VisualElement // TypeDefIndex: 71526
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
		public Texture image { get; set; } // 0x0000000187263170-0x0000000187263180 0x000000018D623D0C-0x000000018D623F00
		public Sprite sprite { get; set; } // 0x0000000187263050-0x0000000187263060 0x000000018D623F00-0x000000018D6240C0
		public VectorImage vectorImage { get; set; } // 0x0000000187263010-0x0000000187263020 0x000000018D6240C0-0x000000018D6242B4
		public Rect sourceRect { get; } // 0x000000018D623CE0-0x000000018D623D0C 
		public Rect uv { get; } // 0x00000001872631A0-0x00000001872631B0 
		public UnityEngine.ScaleMode scaleMode { get; } // 0x0000000187263180-0x0000000187263190 
		public UnityEngine.Color tintColor { get; } // 0x0000000187263190-0x00000001872631A0 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Image, UxmlTraits> // TypeDefIndex: 71524
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FD08-0x000000018D62FD44
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 71525
		{
			// Constructors
			public UxmlTraits(); // 0x000000018D632248-0x000000018D63236C
		}
	
		// Constructors
		public Image(); // 0x000000018D623B38-0x000000018D623CE0
		static Image(); // 0x000000018D6238F8-0x000000018D623B38
	
		// Methods
		private Vector2 GetTextureDisplaySize(Texture texture); // 0x000000018D622FCC-0x000000018D62306C
		private Vector2 GetTextureDisplaySize(Sprite sprite); // 0x000000018D62306C-0x000000018D62316C
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode); // 0x000000018D622C0C-0x000000018D622E3C
		private void OnGenerateVisualContent(MeshGenerationContext mgc); // 0x000000018D6234E4-0x000000018D6238D4
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e); // 0x000000018D62316C-0x000000018D6234E4
		private void SetScaleMode(UnityEngine.ScaleMode mode); // 0x000000018D6238D4-0x000000018D6238F8
		private Rect GetSourceRect(); // 0x000000018D622E3C-0x000000018D622FCC
	}

	public interface INotifyValueChanged<T> // TypeDefIndex: 71527
	{
		// Properties
		T value { get; set; }
	
		// Methods
		void SetValueWithoutNotify(T newValue);
	}

	public static class INotifyValueChangedExtensions // TypeDefIndex: 71528
	{
		// Extension methods
		public static bool RegisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback);
		public static bool UnregisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback);
	}

	internal class KeyboardTextEditorEventHandler : TextEditorEventHandler // TypeDefIndex: 71529
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
		private bool isClicking { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x000000018D625A54-0x000000018D625A80
	
		// Constructors
		public KeyboardTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField); // 0x000000018D6259C4-0x000000018D625A54
	
		// Methods
		public override void ExecuteDefaultActionAtTarget(EventBase evt); // 0x000000018D6242B4-0x000000018D624690
		private void OnFocus(FocusEvent _); // 0x000000018D6249EC-0x000000018D624AC8
		private void OnBlur(BlurEvent _); // 0x000000018D6246D4-0x000000018D6246E0
		private void OnMouseDown(MouseDownEvent evt); // 0x000000018D624EC4-0x000000018D625208
		private void OnMouseUp(MouseUpEvent evt); // 0x000000018D625314-0x000000018D6253FC
		private void OnMouseMove(MouseMoveEvent evt); // 0x000000018D625208-0x000000018D625314
		private void ProcessDragMove(MouseMoveEvent evt); // 0x000000018D62586C-0x000000018D6259C4
		private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current); // 0x000000018D624690-0x000000018D6246D4
		private void OnKeyDown(KeyDownEvent evt); // 0x000000018D624AC8-0x000000018D624EC4
		private void OnValidateCommandEvent(ValidateCommandEvent evt); // 0x000000018D6253FC-0x000000018D6255B8
		private void OnExecuteCommandEvent(ExecuteCommandEvent evt); // 0x000000018D6246E0-0x000000018D6249EC
		public void PreDrawCursor(string newText); // 0x000000018D6255E0-0x000000018D62586C
		public void PostDrawCursor(); // 0x000000018D6255B8-0x000000018D6255E0
	}

	public class Label : UnityEngine.UIElements.TextElement // TypeDefIndex: 71532
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Label, UxmlTraits> // TypeDefIndex: 71530
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FEE8-0x000000018D62FF24
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 71531
		{
			// Constructors
			public UxmlTraits(); // 0x000000018D631628-0x000000018D631630
		}
	
		// Constructors
		public Label(); // 0x000000018D625B6C-0x000000018D625BB4
		public Label(string text); // 0x000000018D625ADC-0x000000018D625B6C
		static Label(); // 0x000000018D625A80-0x000000018D625ADC
	}

	public class ListView : BaseListView // TypeDefIndex: 71535
	{
		// Fields
		private Func<VisualElement> m_MakeItem; // 0x538
		private Action<VisualElement, int> m_BindItem; // 0x540
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<VisualElement, int> _unbindItem_k__BackingField; // 0x548
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<VisualElement> _destroyItem_k__BackingField; // 0x550
	
		// Properties
		public Func<VisualElement> makeItem { get; } // 0x00000001828CD550-0x00000001828CD560 
		public Action<VisualElement, int> bindItem { get; } // 0x000000018723C0E0-0x000000018723C0F0 
		public Action<VisualElement, int> unbindItem { [CompilerGenerated] get; } // 0x000000018723BC60-0x000000018723BC70 
		public Action<VisualElement> destroyItem { [CompilerGenerated] get; } // 0x000000018723BD80-0x000000018723BD90 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ListView, UxmlTraits> // TypeDefIndex: 71533
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FF60-0x000000018D62FF9C
		}
	
		public class UxmlTraits : BaseListView.UxmlTraits // TypeDefIndex: 71534
		{
			// Constructors
			public UxmlTraits(); // 0x000000018D631630-0x000000018D631638
		}
	
		// Constructors
		public ListView(); // 0x000000018D625C2C-0x000000018D625C8C
	
		// Methods
		internal override bool HasValidDataAndBindings(); // 0x000000018D625BF0-0x000000018D625C2C
		protected override CollectionViewController CreateViewController(); // 0x000000018D625BB4-0x000000018D625BF0
	}

	public class MinMaxSlider : BaseField<Vector2> // TypeDefIndex: 71539
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _dragElement_k__BackingField; // 0x418
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _dragMinThumb_k__BackingField; // 0x420
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _dragMaxThumb_k__BackingField; // 0x428
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
		internal VisualElement dragElement { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BFC0-0x000000018723BFD0 0x0000000188DC49F8-0x0000000188DC4A0C
		internal VisualElement dragMinThumb { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BFB0-0x000000018723BFC0 0x0000000188DC49D0-0x0000000188DC49E4
		internal VisualElement dragMaxThumb { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723A320-0x000000018723A330 0x0000000188DC4610-0x0000000188DC4624
		internal ClampedDragger<float> clampedDragger { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723A330-0x000000018723A340 0x0000000188DC4C8C-0x0000000188DC4CA0
		public float minValue { get; set; } // 0x000000018D6275A4-0x000000018D6275C8 0x000000018D6278F0-0x000000018D627960
		public float maxValue { get; set; } // 0x000000018D627580-0x000000018D6275A4 0x000000018D627880-0x000000018D6278F0
		public override Vector2 value { get; set; } // 0x000000018D6275C8-0x000000018D62760C 0x000000018D627960-0x000000018D6279BC
		public float lowLimit { get; set; } // 0x00000001872631E0-0x00000001872631F0 0x000000018D627748-0x000000018D627880
		public float highLimit { get; set; } // 0x00000001872631D0-0x00000001872631E0 0x000000018D62760C-0x000000018D627748
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits> // TypeDefIndex: 71536
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FD44-0x000000018D62FD80
		}
	
		public class UxmlTraits : BaseField<Vector2> // TypeDefIndex: 71537
		{
			// Fields
			private UxmlFloatAttributeDescription m_MinValue; // 0x80
			private UxmlFloatAttributeDescription m_MaxValue; // 0x88
			private UxmlFloatAttributeDescription m_LowLimit; // 0x90
			private UxmlFloatAttributeDescription m_HighLimit; // 0x98
	
			// Constructors
			public UxmlTraits(); // 0x000000018D6318F4-0x000000018D631AC0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D630014-0x000000018D6301A8
		}
	
		private enum DragState // TypeDefIndex: 71538
		{
			NoThumb = 0,
			MinThumb = 1,
			MiddleThumb = 2,
			MaxThumb = 3
		}
	
		// Constructors
		public MinMaxSlider(); // 0x000000018D626F48-0x000000018D626F88
		public MinMaxSlider(string label, float minValue = 0f /* Metadata: 0x026223C0 */, float maxValue = 10f /* Metadata: 0x026223C4 */, float minLimit = -3.4028235E+38f /* Metadata: 0x026223C8 */, float maxLimit = 3.4028235E+38f /* Metadata: 0x026223CC */); // 0x000000018D626F88-0x000000018D627580
		static MinMaxSlider(); // 0x000000018D626CEC-0x000000018D626F48
	
		// Methods
		public override void SetValueWithoutNotify(Vector2 newValue); // 0x000000018D62643C-0x000000018D6264A4
		private Vector2 ClampValues(Vector2 valueToClamp); // 0x000000018D625C8C-0x000000018D625D0C
		private void UpdateDragElementPosition(GeometryChangedEvent evt); // 0x000000018D626C8C-0x000000018D626CEC
		private void UpdateDragElementPosition(); // 0x000000018D6264B8-0x000000018D626C8C
		internal float SliderLerpUnclamped(float a, float b, float interpolant); // 0x00000001872631B0-0x00000001872631D0
		internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue); // 0x000000018D6264A4-0x000000018D6264B8
		private float ComputeValueFromPosition(float positionToConvert); // 0x000000018D625F1C-0x000000018D626000
		protected override void ExecuteDefaultAction(EventBase evt); // 0x000000018D626000-0x000000018D6260B8
		private void SetSliderValueFromDrag(); // 0x000000018D6263AC-0x000000018D62643C
		private void SetSliderValueFromClick(); // 0x000000018D6260B8-0x000000018D6263AC
		private void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos); // 0x000000018D625D0C-0x000000018D625DA8
		private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos); // 0x000000018D625DA8-0x000000018D625F1C
		protected override void UpdateMixedValueContent(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class PopupWindow : UnityEngine.UIElements.TextElement // TypeDefIndex: 71542
	{
		// Fields
		private VisualElement m_ContentContainer; // 0x488
		public static readonly string ussClassName; // 0x00
		public static readonly string contentUssClassName; // 0x08
	
		// Properties
		public override VisualElement contentContainer { get; } // 0x0000000187263110-0x0000000187263120 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits> // TypeDefIndex: 71540
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FCCC-0x000000018D62FD08
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 71541
		{
			// Constructors
			public UxmlTraits(); // 0x000000018D631628-0x000000018D631630
		}
	
		// Constructors
		public PopupWindow(); // 0x000000018D627A6C-0x000000018D627B98
		static PopupWindow(); // 0x000000018D6279BC-0x000000018D627A6C
	}

	public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float> // TypeDefIndex: 71544
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
		private readonly Label m_Title; // 0x3E0
		private float m_LowValue; // 0x3E8
		private float m_HighValue; // 0x3EC
		private float m_Value; // 0x3F0
	
		// Properties
		public string title { set; } // 0x000000018D622278-0x000000018D62229C
		public float lowValue { get; set; } // 0x0000000187263150-0x0000000187263160 0x000000018D622260-0x000000018D622278
		public float highValue { get; set; } // 0x0000000187263140-0x0000000187263150 0x000000018D622248-0x000000018D622260
		public virtual float value { get; set; } // 0x0000000187263160-0x0000000187263170 0x000000018D62229C-0x000000018D622414
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 71543
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x78
			private UxmlFloatAttributeDescription m_HighValue; // 0x80
			private UxmlFloatAttributeDescription m_Value; // 0x88
			private UxmlStringAttributeDescription m_Title; // 0x90
	
			// Constructors
			public UxmlTraits(); // 0x000000018D631F48-0x000000018D632138
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D630C48-0x000000018D630DC8
		}
	
		// Constructors
		public AbstractProgressBar(); // 0x000000018D621F14-0x000000018D622248
		static AbstractProgressBar(); // 0x000000018D621D10-0x000000018D621F14
	
		// Methods
		private void OnGeometryChanged(GeometryChangedEvent e); // 0x000000018D621C4C-0x000000018D621C60
		public void SetValueWithoutNotify(float newValue); // 0x000000018D621D00-0x000000018D621D10
		private void SetProgress(float p); // 0x000000018D621C60-0x000000018D621D00
		private float CalculateProgressWidth(float width); // 0x000000018D621BA4-0x000000018D621C4C
	}

	[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
	public class ProgressBar : AbstractProgressBar // TypeDefIndex: 71546
	{
		// Nested types
		public class UxmlFactory : UxmlFactory<ProgressBar, UxmlTraits> // TypeDefIndex: 71545
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FE70-0x000000018D62FEAC
		}
	
		// Constructors
		public ProgressBar(); // 0x000000018D627B98-0x000000018D627BE4
	}

	public class RadioButton : BaseBoolField, IGroupBoxOption // TypeDefIndex: 71549
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
		public override bool value { get; set; } // 0x000000018D628A74-0x000000018D628AB0 0x000000018D628AB0-0x000000018D628B50
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits> // TypeDefIndex: 71547
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FF9C-0x000000018D62FFD8
		}
	
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription> // TypeDefIndex: 71548
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x88
	
			// Constructors
			public UxmlTraits(); // 0x000000018D631580-0x000000018D631628
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D6306D8-0x000000018D6307BC
		}
	
		// Constructors
		public RadioButton(); // 0x000000018D628864-0x000000018D628870
		public RadioButton(string label); // 0x000000018D628870-0x000000018D628A74
		static RadioButton(); // 0x000000018D628660-0x000000018D628864
	
		// Methods
		protected override void InitLabel(); // 0x000000018D628474-0x000000018D6284E4
		protected override void ToggleValue(); // 0x000000018D628518-0x000000018D628548
		public void SetSelected(bool selected); // 0x000000018D6284E4-0x000000018D6284F8
		public override void SetValueWithoutNotify(bool newValue); // 0x000000018D6284F8-0x000000018D628518
		private void UpdateCheckmark(); // 0x000000018D628548-0x000000018D6285C8
		protected override void UpdateMixedValueContent(); // 0x000000018D6285C8-0x000000018D628660
	}

	public class RadioButtonGroup : BaseField<int>, IGroupBox // TypeDefIndex: 71552
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private IEnumerable<string> m_Choices; // 0x418
		private List<RadioButton> m_RadioButtons; // 0x420
		private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback; // 0x428
	
		// Properties
		public IEnumerable<string> choices { set; } // 0x000000018D6280DC-0x000000018D628474
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits> // TypeDefIndex: 71550
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FDBC-0x000000018D62FDF8
		}
	
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription> // TypeDefIndex: 71551
		{
			// Fields
			private UxmlStringAttributeDescription m_Choices; // 0x88
	
			// Constructors
			public UxmlTraits(); // 0x000000018D631AC0-0x000000018D631B68
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D630B58-0x000000018D630C48
		}
	
		// Constructors
		public RadioButtonGroup(); // 0x000000018D6280CC-0x000000018D6280DC
		public RadioButtonGroup(string label, List<string> radioButtonChoices = null); // 0x000000018D627F30-0x000000018D6280CC
		static RadioButtonGroup(); // 0x000000018D627ED4-0x000000018D627F30
	
		// Methods
		private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt); // 0x000000018D627BE4-0x000000018D627CA0
		public override void SetValueWithoutNotify(int newValue); // 0x000000018D627CA0-0x000000018D627CF0
		private void UpdateRadioButtons(); // 0x000000018D627CF0-0x000000018D627ED4
	}

	public class RepeatButton : UnityEngine.UIElements.TextElement // TypeDefIndex: 71555
	{
		// Fields
		private Clickable m_Clickable; // 0x488
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits> // TypeDefIndex: 71553
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FE34-0x000000018D62FE70
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 71554
		{
			// Fields
			private UxmlLongAttributeDescription m_Delay; // 0x90
			private UxmlLongAttributeDescription m_Interval; // 0x98
	
			// Constructors
			public UxmlTraits(); // 0x000000018D631E5C-0x000000018D631F48
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D6301A8-0x000000018D6302C4
		}
	
		// Constructors
		public RepeatButton(); // 0x000000018D628CF4-0x000000018D628D68
		public RepeatButton(Action clickEvent, long delay, long interval); // 0x000000018D628C9C-0x000000018D628CF4
		static RepeatButton(); // 0x000000018D628C40-0x000000018D628C9C
	
		// Methods
		public void SetAction(Action clickEvent, long delay, long interval); // 0x000000018D628B74-0x000000018D628C40
		internal void AddAction(Action clickEvent); // 0x000000018D628B50-0x000000018D628B74
	}

	public class Scroller : VisualElement // TypeDefIndex: 71558
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<float> valueChanged; // 0x3C0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Slider _slider_k__BackingField; // 0x3C8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RepeatButton _lowButton_k__BackingField; // 0x3D0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RepeatButton _highButton_k__BackingField; // 0x3D8
		public static readonly string ussClassName; // 0x00
		public static readonly string horizontalVariantUssClassName; // 0x08
		public static readonly string verticalVariantUssClassName; // 0x10
		public static readonly string sliderUssClassName; // 0x18
		public static readonly string lowButtonUssClassName; // 0x20
		public static readonly string highButtonUssClassName; // 0x28
	
		// Properties
		public Slider slider { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723A1C0-0x000000018723A1D0 0x0000000188DC4BC4-0x0000000188DC4BD8
		public RepeatButton lowButton { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723A1D0-0x000000018723A1E0 0x0000000188DC4D68-0x0000000188DC4D7C
		public RepeatButton highButton { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C0C0-0x000000018723C0D0 0x0000000188DC4B74-0x0000000188DC4B88
		public float value { get; set; } // 0x000000018D62EC10-0x000000018D62EC34 0x000000018D62EEB8-0x000000018D62EEE0
		public float lowValue { get; set; } // 0x000000018D62EBC8-0x000000018D62EC10 0x000000018D62EE60-0x000000018D62EEB8
		public float highValue { get; set; } // 0x000000018D62EB80-0x000000018D62EBC8 0x000000018D62EE08-0x000000018D62EE60
		public SliderDirection direction { set; } // 0x000000018D62ECC4-0x000000018D62EE08
	
		// Events
		public event Action<float> valueChanged {
			add; // 0x000000018D62EAF0-0x000000018D62EB80
			remove; // 0x000000018D62EC34-0x000000018D62ECC4
		}
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Scroller, UxmlTraits> // TypeDefIndex: 71556
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FFD8-0x000000018D630014
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 71557
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x70
			private UxmlFloatAttributeDescription m_HighValue; // 0x78
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0x80
			private UxmlFloatAttributeDescription m_Value; // 0x88
	
			// Constructors
			public UxmlTraits(); // 0x000000018D631B68-0x000000018D631DCC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D63051C-0x000000018D6306D8
		}
	
		// Constructors
		public Scroller(); // 0x000000018D62E6A0-0x000000018D62E6C8
		public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical /* Metadata: 0x026223D4 */); // 0x000000018D62E6C8-0x000000018D62EAF0
		static Scroller(); // 0x000000018D62E49C-0x000000018D62E6A0
	
		// Methods
		public void Adjust(float factor); // 0x000000018D62E1F0-0x000000018D62E264
		private void OnSliderValueChange(ChangeEvent<float> evt); // 0x000000018D62E264-0x000000018D62E2F8
		public void ScrollPageUp(); // 0x000000018D62E48C-0x000000018D62E49C
		public void ScrollPageDown(); // 0x000000018D62E3B8-0x000000018D62E3C8
		public void ScrollPageUp(float factor); // 0x000000018D62E3C8-0x000000018D62E48C
		public void ScrollPageDown(float factor); // 0x000000018D62E2F8-0x000000018D62E3B8
	}

	public enum ScrollViewMode // TypeDefIndex: 71559
	{
		Vertical = 0,
		Horizontal = 1,
		VerticalAndHorizontal = 2
	}

	public enum ScrollerVisibility // TypeDefIndex: 71560
	{
		Auto = 0,
		AlwaysVisible = 1,
		Hidden = 2
	}

	public class ScrollView : VisualElement // TypeDefIndex: 71566
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly VisualElement _contentViewport_k__BackingField; // 0x410
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Scroller _horizontalScroller_k__BackingField; // 0x418
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
		public ScrollerVisibility horizontalScrollerVisibility { get; set; } // 0x0000000187263230-0x0000000187263240 0x000000018D62DEF0-0x000000018D62DF34
		public ScrollerVisibility verticalScrollerVisibility { get; set; } // 0x0000000187263280-0x0000000187263290 0x000000018D62E1AC-0x000000018D62E1F0
		[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
		public bool showHorizontal { set; } // 0x000000018D62E0A8-0x000000018D62E0C8
		[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
		public bool showVertical { set; } // 0x000000018D62E0C8-0x000000018D62E0E8
		internal bool needsHorizontal { get; } // 0x000000018D62DC6C-0x000000018D62DCAC 
		internal bool needsVertical { get; } // 0x000000018D62DCAC-0x000000018D62DCEC 
		internal bool isVerticalScrollDisplayed { get; } // 0x000000018D62DC44-0x000000018D62DC6C 
		internal bool isHorizontalScrollDisplayed { get; } // 0x000000018D62DC1C-0x000000018D62DC44 
		public Vector2 scrollOffset { get; set; } // 0x000000018D62DCEC-0x000000018D62DD3C 0x000000018D62DFD8-0x000000018D62E0A8
		public float horizontalPageSize { set; } // 0x000000018D62DEE0-0x000000018D62DEF0
		public float verticalPageSize { set; } // 0x000000018D62E19C-0x000000018D62E1AC
		public float mouseWheelScrollSize { get; set; } // 0x000000018724BDC0-0x000000018724BDD0 0x000000018D62DF48-0x000000018D62DFC4
		internal float scrollableWidth { get; } // 0x000000018D62DDA8-0x000000018D62DE14 
		internal float scrollableHeight { get; } // 0x000000018D62DD3C-0x000000018D62DDA8 
		private bool hasInertia { get; } // 0x000000018D62DC08-0x000000018D62DC1C 
		public float scrollDecelerationRate { get; set; } // 0x0000000187263260-0x0000000187263270 0x000000018D62DFC4-0x000000018D62DFD8
		public float elasticity { get; set; } // 0x0000000187263220-0x0000000187263230 0x000000018D62DECC-0x000000018D62DEE0
		public TouchScrollBehavior touchScrollBehavior { get; set; } // 0x0000000187263270-0x0000000187263280 0x000000018D62E0E8-0x000000018D62E19C
		public NestedInteractionKind nestedInteractionKind { get; set; } // 0x0000000187263250-0x0000000187263260 0x0000000187263290-0x00000001872632A0
		public long elasticAnimationIntervalMs { set; } // 0x000000018D62DE14-0x000000018D62DECC
		public VisualElement contentViewport { [CompilerGenerated] get; } // 0x000000018723BF90-0x000000018723BFA0 
		public Scroller horizontalScroller { [CompilerGenerated] get; } // 0x000000018723BFC0-0x000000018723BFD0 
		public Scroller verticalScroller { [CompilerGenerated] get; } // 0x000000018723BFB0-0x000000018723BFC0 
		public override VisualElement contentContainer { get; } // 0x0000000187263210-0x0000000187263220 
		public ScrollViewMode mode { get; set; } // 0x0000000187263240-0x0000000187263250 0x000000018D62DF34-0x000000018D62DF48
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits> // TypeDefIndex: 71561
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FD80-0x000000018D62FDBC
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 71562
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
			public UxmlTraits(); // 0x000000018D630FAC-0x000000018D631580
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D6307BC-0x000000018D630B58
		}
	
		public enum TouchScrollBehavior // TypeDefIndex: 71563
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		public enum NestedInteractionKind // TypeDefIndex: 71564
		{
			Default = 0,
			StopScrolling = 1,
			ForwardScrolling = 2
		}
	
		internal enum TouchScrollingResult // TypeDefIndex: 71565
		{
			Apply = 0,
			Forward = 1,
			Block = 2
		}
	
		// Constructors
		public ScrollView(); // 0x000000018D62DBFC-0x000000018D62DC08
		public ScrollView(ScrollViewMode scrollViewMode); // 0x000000018D62CEA0-0x000000018D62DBFC
		static ScrollView(); // 0x000000018D62C930-0x000000018D62CEA0
	
		// Methods
		private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt); // 0x000000018D62A990-0x000000018D62A9F0
		private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt); // 0x000000018D62B5C8-0x000000018D62B628
		private void UpdateHorizontalSliderPageSize(); // 0x000000018D62C3F0-0x000000018D62C500
		private void UpdateVerticalSliderPageSize(); // 0x000000018D62C820-0x000000018D62C930
		internal void UpdateContentViewTransform(); // 0x000000018D62C1AC-0x000000018D62C2CC
		public void ScrollTo(VisualElement child); // 0x000000018D62B994-0x000000018D62BB88
		private float GetXDeltaOffset(VisualElement child); // 0x000000018D629B30-0x000000018D629CA0
		private float GetYDeltaOffset(VisualElement child); // 0x000000018D629CA0-0x000000018D629E1C
		private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax); // 0x000000018D629ADC-0x000000018D629B30
		private void SetScrollViewMode(ScrollViewMode mode); // 0x000000018D62BB88-0x000000018D62BF60
		private void OnAttachToPanel(AttachToPanelEvent evt); // 0x000000018D629F70-0x000000018D62A3F0
		private void OnDetachFromPanel(DetachFromPanelEvent evt); // 0x000000018D62A3F0-0x000000018D62A87C
		private void OnPointerCapture(PointerCaptureEvent evt); // 0x000000018D62AB1C-0x000000018D62AC04
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt); // 0x000000018D62AA48-0x000000018D62AB1C
		private void OnGeometryChanged(GeometryChangedEvent evt); // 0x000000018D62A87C-0x000000018D62A990
		private void ScheduleResetLayoutPass(); // 0x000000018D62B8DC-0x000000018D62B994
		private void ResetLayoutPass(); // 0x0000000187263200-0x0000000187263210
		private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit); // 0x000000018D629414-0x000000018D62957C
		private void ComputeInitialSpringBackVelocity(); // 0x000000018D62957C-0x000000018D6296A8
		private void SpringBack(); // 0x000000018D62BF60-0x000000018D62C114
		internal void ApplyScrollInertia(); // 0x000000018D628ECC-0x000000018D6291FC
		private void PostPointerUpAnimation(); // 0x000000018D62B628-0x000000018D62B720
		private void OnPointerDown(PointerDownEvent evt); // 0x000000018D62AC04-0x000000018D62ADDC
		private void OnPointerMove(PointerMoveEvent evt); // 0x000000018D62ADDC-0x000000018D62B020
		private void OnPointerCancel(PointerCancelEvent evt); // 0x000000018D62A9F0-0x000000018D62AA48
		private void OnPointerUp(PointerUpEvent evt); // 0x000000018D62B020-0x000000018D62B0A8
		internal void InitTouchScrolling(Vector2 position); // 0x000000018D629E1C-0x000000018D629F70
		internal TouchScrollingResult ComputeTouchScrolling(Vector2 position); // 0x000000018D6296A8-0x000000018D629A08
		private bool ApplyTouchScrolling(Vector2 newScrollOffset); // 0x000000018D6291FC-0x000000018D629414
		private bool ReleaseScrolling(int pointerId, IEventHandler target); // 0x000000018D62B808-0x000000018D62B8DC
		private void ExecuteElasticSpringAnimation(); // 0x000000018D629A08-0x000000018D629ADC
		private void AdjustScrollers(); // 0x000000018D628D68-0x000000018D628ECC
		internal void UpdateScrollers(bool displayHorizontal, bool displayVertical); // 0x000000018D62C500-0x000000018D62C820
		private void OnScrollersGeometryChanged(GeometryChangedEvent evt); // 0x000000018D62B4D8-0x000000018D62B5C8
		private void OnScrollWheel(WheelEvent evt); // 0x000000018D62B0B0-0x000000018D62B4D8
		private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt); // 0x000000018D62B0A8-0x000000018D62B0B0
		private void OnRootPointerUp(PointerUpEvent evt); // 0x00000001872631F0-0x0000000187263200
		private void ReadSingleLineHeight(); // 0x000000018D62B720-0x000000018D62B808
		private void UpdateElasticBehaviour(); // 0x000000018D62C2CC-0x000000018D62C3F0
		[CompilerGenerated]
		private void _.ctor_b__126_0(float value); // 0x000000018D62C114-0x000000018D62C160
		[CompilerGenerated]
		private void _.ctor_b__126_1(float value); // 0x000000018D62C160-0x000000018D62C1AC
	}

	public class Slider : BaseSlider<float> // TypeDefIndex: 71569
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Slider, UxmlTraits> // TypeDefIndex: 71567
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D62FDF8-0x000000018D62FE34
		}
	
		public class UxmlTraits : BaseFieldTraits<float, UxmlFloatAttributeDescription> // TypeDefIndex: 71568
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x88
			private UxmlFloatAttributeDescription m_HighValue; // 0x90
			private UxmlFloatAttributeDescription m_PageSize; // 0x98
			private UxmlBoolAttributeDescription m_ShowInputField; // 0xA0
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0xA8
			private UxmlBoolAttributeDescription m_Inverted; // 0xB0
	
			// Constructors
			public UxmlTraits(); // 0x000000018D631638-0x000000018D6318F4
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D6302C4-0x000000018D63051C
		}
	
		// Constructors
		public Slider(); // 0x000000018D62FC70-0x000000018D62FC9C
		public Slider(float start, float end, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x026223E4 */, float pageSize = 0f /* Metadata: 0x026223E5 */); // 0x000000018D62FC9C-0x000000018D62FCCC
		public Slider(string label, float start = 0f /* Metadata: 0x026223E9 */, float end = 10f /* Metadata: 0x026223ED */, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x026223F1 */, float pageSize = 0f /* Metadata: 0x026223F2 */); // 0x000000018D62FB30-0x000000018D62FC70
		static Slider(); // 0x000000018D62FA28-0x000000018D62FB30
	
		// Methods
		internal override float SliderLerpUnclamped(float a, float b, float interpolant); // 0x000000018D62F8C0-0x000000018D62FA28
		internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue); // 0x000000018D6264A4-0x000000018D6264B8
		internal override float ParseStringToValue(string stringValue); // 0x000000018D62F800-0x000000018D62F8C0
		internal override void ComputeValueFromKey(BaseSlider<float> sliderKey, bool isShift); // 0x000000018D62F670-0x000000018D62F800
	}

	public class SliderInt : BaseSlider<int> // TypeDefIndex: 71572
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Properties
		public override float pageSize { get; set; } // 0x000000018D62F5E0-0x000000018D62F620 0x000000018D62F620-0x000000018D62F670
	
		// Nested types
		public class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits> // TypeDefIndex: 71570
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D643430-0x000000018D64346C
		}
	
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription> // TypeDefIndex: 71571
		{
			// Fields
			private UxmlIntAttributeDescription m_LowValue; // 0x88
			private UxmlIntAttributeDescription m_HighValue; // 0x90
			private UxmlIntAttributeDescription m_PageSize; // 0x98
			private UxmlBoolAttributeDescription m_ShowInputField; // 0xA0
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0xA8
			private UxmlBoolAttributeDescription m_Inverted; // 0xB0
	
			// Constructors
			public UxmlTraits(); // 0x000000018D644298-0x000000018D644554
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D64358C-0x000000018D6437DC
		}
	
		// Constructors
		public SliderInt(); // 0x000000018D62F478-0x000000018D62F4A8
		public SliderInt(string label, int start = 0 /* Metadata: 0x026223F6 */, int end = 10 /* Metadata: 0x026223F7 */, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x026223F8 */, float pageSize = 0f /* Metadata: 0x026223F9 */); // 0x000000018D62F4A8-0x000000018D62F5E0
		static SliderInt(); // 0x000000018D62F370-0x000000018D62F478
	
		// Methods
		internal override int SliderLerpUnclamped(int a, int b, float interpolant); // 0x000000018D62F320-0x000000018D62F340
		internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue); // 0x000000018D62F340-0x000000018D62F370
		internal override int ParseStringToValue(string stringValue); // 0x000000018D62F2F0-0x000000018D62F320
		internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos); // 0x000000018D62EEE0-0x000000018D62F14C
		internal override void ComputeValueFromKey(BaseSlider<int> sliderKey, bool isShift); // 0x000000018D62F14C-0x000000018D62F2F0
	}

	internal class TextEditorEventHandler // TypeDefIndex: 71573
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextEditorEngine _editorEngine_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ITextInputField _textInputField_k__BackingField; // 0x18
	
		// Properties
		protected TextEditorEngine editorEngine { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		protected ITextInputField textInputField { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		protected TextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField); // 0x000000018D63F778-0x000000018D63F7B4
	
		// Methods
		public virtual void ExecuteDefaultActionAtTarget(EventBase evt); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ExecuteDefaultAction(EventBase evt); // 0x000000018D63F660-0x000000018D63F778
	}

	internal class TextEditorEngine : TextEditor // TypeDefIndex: 71576
	{
		// Fields
		private OnDetectFocusChangeFunction m_DetectFocusChangeFunction; // 0x90
		private OnIndexChangeFunction m_IndexChangeFunction; // 0x98
	
		// Properties
		internal override Rect localPosition { get; } // 0x0000000187263300-0x0000000187263340 
	
		// Nested types
		internal delegate void OnDetectFocusChangeFunction(); // TypeDefIndex: 71574; 0x0000000185B44B70-0x0000000185B44B80
	
		internal delegate void OnIndexChangeFunction(); // TypeDefIndex: 71575; 0x0000000185B44B70-0x0000000185B44B80
	
		// Constructors
		public TextEditorEngine(OnDetectFocusChangeFunction detectFocusChange, OnIndexChangeFunction indexChangeFunction); // 0x000000018D63F60C-0x000000018D63F660
	
		// Methods
		internal override void OnDetectFocusChange(); // 0x000000018D63F5E0-0x000000018D63F60C
		internal override void OnCursorIndexChange(); // 0x000000018D63F5B4-0x000000018D63F5E0
		internal override void OnSelectIndexChange(); // 0x000000018D63F5B4-0x000000018D63F5E0
	}

	public class TextField : TextInputBaseField<string> // TypeDefIndex: 71580
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Properties
		private TextInput textInput { get; } // 0x000000018D63FBB0-0x000000018D63FBFC 
		public bool multiline { set; } // 0x000000018D63FC38-0x000000018D63FC68
		public override string value { get; set; } // 0x000000018D63FBFC-0x000000018D63FC38 0x000000018D63FC68-0x000000018D63FCE0
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TextField, UxmlTraits> // TypeDefIndex: 71577
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D643340-0x000000018D64337C
		}
	
		public class UxmlTraits : TextInputBaseField<string> // TypeDefIndex: 71578
		{
			// Fields
			private static readonly UxmlStringAttributeDescription k_Value; // 0x00
			private UxmlBoolAttributeDescription m_Multiline; // 0xB8
	
			// Constructors
			public UxmlTraits(); // 0x000000018D643E54-0x000000018D643EFC
			static UxmlTraits(); // 0x000000018D643D5C-0x000000018D643E54
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D643928-0x000000018D643AAC
		}
	
		private class TextInput : TextInputBaseField<string> // TypeDefIndex: 71579
		{
			// Fields
			private bool m_Multiline; // 0x420
	
			// Properties
			private TextField parentTextField { get; } // 0x000000018D6405DC-0x000000018D64061C 
			public bool multiline { get; set; } // 0x0000000187263350-0x0000000187263360 0x000000018D64066C-0x000000018D640718
			public override bool isPasswordField { set; } // 0x000000018D64061C-0x000000018D64066C
	
			// Constructors
			public TextInput(); // 0x000000018D6405A0-0x000000018D6405DC
	
			// Methods
			private void SetTextAlign(); // 0x000000018D640460-0x000000018D640510
			protected override string StringToValue(string str); // 0x0000000187263340-0x0000000187263350
			internal override void SyncTextEngine(); // 0x000000018D640510-0x000000018D6405A0
			protected override void ExecuteDefaultActionAtTarget(EventBase evt); // 0x000000018D63FCE0-0x000000018D640304
			protected override void ExecuteDefaultAction(EventBase evt); // 0x000000018D640304-0x000000018D640460
		}
	
		// Constructors
		public TextField(); // 0x000000018D63FBA4-0x000000018D63FBB0
		public TextField(string label); // 0x000000018D63FB78-0x000000018D63FBA4
		public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar); // 0x000000018D63F9B8-0x000000018D63FB78
		static TextField(); // 0x000000018D63F8B0-0x000000018D63F9B8
	
		// Methods
		public override void SetValueWithoutNotify(string newValue); // 0x000000018D63F838-0x000000018D63F8B0
		internal override void OnViewDataReady(); // 0x000000018D63F7B4-0x000000018D63F838
	}

	internal interface ITextInputField : IEventHandler, ITextElement // TypeDefIndex: 71581
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

	public abstract class TextInputBaseField<TValueType> : BaseField<TValueType> // TypeDefIndex: 71584
	{
		// Fields
		private static CustomStyleProperty<UnityEngine.Color> s_SelectionColorProperty;
		private static CustomStyleProperty<UnityEngine.Color> s_CursorColorProperty;
		private int m_VisualInputTabIndex;
		private TextInputBase m_TextInputBase;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ITextHandle _iTextHandle_k__BackingField;
		public static readonly string ussClassName;
		public static readonly string labelUssClassName;
		public static readonly string inputUssClassName;
		public static readonly string singleLineInputUssClassName;
		public static readonly string multilineInputUssClassName;
		public static readonly string textInputUssName;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<bool> onIsReadOnlyChanged;
	
		// Properties
		protected internal TextInputBase textInputBase { get; }
		private ITextHandle iTextHandle { [CompilerGenerated] set; }
		public string text { set; }
		public bool isReadOnly { set; }
		public bool isPasswordField { set; }
		public int maxLength { set; }
		public bool isDelayed { get; set; }
		public char maskChar { set; }
	
		// Nested types
		public class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription> // TypeDefIndex: 71582
		{
			// Fields
			private UxmlIntAttributeDescription m_MaxLength;
			private UxmlBoolAttributeDescription m_Password;
			private UxmlStringAttributeDescription m_MaskCharacter;
			private UxmlStringAttributeDescription m_Text;
			private UxmlBoolAttributeDescription m_IsReadOnly;
			private UxmlBoolAttributeDescription m_IsDelayed;
	
			// Constructors
			public UxmlTraits();
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc);
		}
	
		protected internal abstract class TextInputBase : VisualElement, ITextInputField // TypeDefIndex: 71583
		{
			// Fields
			private string m_OriginalText;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool _isReadOnly_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int _maxLength_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private char _maskChar_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool _isPasswordField_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool _doubleClickSelectsWord_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool _tripleClickSelectsLine_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool _isDelayed_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool _isDragging_k__BackingField;
			private bool m_TouchScreenTextFieldInitialized;
			private IVisualElementScheduledItem m_HardwareKeyboardPoller;
			private UnityEngine.Color m_SelectionColor;
			private UnityEngine.Color m_CursorColor;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private TextEditorEventHandler _editorEventHandler_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private TextEditorEngine _editorEngine_k__BackingField;
			private ITextHandle m_TextHandle;
			private string m_Text;
	
			// Properties
			bool ITextInputField.isReadOnly { get; }
			public bool isReadOnly { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int maxLength { [CompilerGenerated] get; [CompilerGenerated] set; }
			public char maskChar { [CompilerGenerated] get; [CompilerGenerated] set; }
			public virtual bool isPasswordField { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool doubleClickSelectsWord { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool tripleClickSelectsLine { [CompilerGenerated] get; [CompilerGenerated] set; }
			internal bool isDelayed { [CompilerGenerated] get; [CompilerGenerated] set; }
			internal bool isDragging { [CompilerGenerated] get; }
			private bool touchScreenTextField { get; }
			private bool touchScreenTextFieldChanged { get; }
			public UnityEngine.Color selectionColor { get; }
			public UnityEngine.Color cursorColor { get; }
			internal bool hasFocus { get; }
			internal TextEditorEventHandler editorEventHandler { [CompilerGenerated] get; [CompilerGenerated] private set; }
			internal TextEditorEngine editorEngine { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public string text { get; set; }
			bool ITextInputField.hasFocus { get; }
			TextEditorEngine ITextInputField.editorEngine { get; }
			bool ITextInputField.isDelayed { get; }
	
			// Constructors
			internal TextInputBase();
	
			// Methods
			public void ResetValueAndText();
			private void SaveValueAndText();
			private void RestoreValueAndText();
			private void UpdateText(string value);
			protected virtual TValueType StringToValue(string str);
			internal void UpdateValueFromText();
			private void InitTextEditorEventHandler();
			private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a);
			private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a);
			private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a);
			private void ProcessMenuCommand(string command);
			private void Cut(DropdownMenuAction a);
			private void Copy(DropdownMenuAction a);
			private void Paste(DropdownMenuAction a);
			internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e);
			private void OnAttachToPanel(AttachToPanelEvent attachEvent);
			internal virtual void SyncTextEngine();
			internal string CullString(string s);
			internal void OnGenerateVisualContent(MeshGenerationContext mgc);
			internal void DrawWithTextSelectionAndCursor(MeshGenerationContext mgc, string newText, float pixelsPerPoint);
			internal virtual bool AcceptCharacter(char c);
			protected virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt);
			private void OnDetectFocusChange();
			private void OnCursorIndexChange();
			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode);
			internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt);
			protected override void ExecuteDefaultActionAtTarget(EventBase evt);
			private void ProcessEventAtTarget(EventBase evt);
			protected override void ExecuteDefaultAction(EventBase evt);
			void ITextInputField.SyncTextEngine();
			bool ITextInputField.AcceptCharacter(char c);
			string ITextInputField.CullString(string s);
			void ITextInputField.UpdateText(string value);
			void ITextInputField.UpdateValueFromText();
			private void DeferGUIStyleRectSync();
			private void OnPercentResolved(GeometryChangedEvent evt);
			private static void SyncGUIStyle(TextInputBase<TValueType> textInput, GUIStyle style);
			private static bool IsLayoutUsingPercent(VisualElement ve);
			private static void AssignRect(RectOffset rect, int left, int top, int right, int bottom);
			[CompilerGenerated]
			private void _ProcessEventAtTarget_b__99_0();
		}
	
		// Constructors
		protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase textInputBase);
		static TextInputBaseField();
	
		// Methods
		private new void OnAttachToPanel(AttachToPanelEvent e);
		private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e);
		protected override void ExecuteDefaultActionAtTarget(EventBase evt);
		protected override void UpdateMixedValueContent();
	}

	public class Toggle : BaseBoolField // TypeDefIndex: 71587
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
		[Obsolete]
		public static readonly string noTextVariantUssClassName; // 0x18
		public static readonly string checkmarkUssClassName; // 0x20
		public static readonly string textUssClassName; // 0x28
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Toggle, UxmlTraits> // TypeDefIndex: 71585
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D64337C-0x000000018D6433B8
		}
	
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription> // TypeDefIndex: 71586
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x88
	
			// Constructors
			public UxmlTraits(); // 0x000000018D64455C-0x000000018D644670
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D6434A8-0x000000018D64358C
		}
	
		// Constructors
		public Toggle(); // 0x000000018D640A88-0x000000018D640A94
		public Toggle(string label); // 0x000000018D64098C-0x000000018D640A88
		static Toggle(); // 0x000000018D640788-0x000000018D64098C
	
		// Methods
		protected override void InitLabel(); // 0x000000018D640718-0x000000018D640788
	}

	internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler // TypeDefIndex: 71588
	{
		// Fields
		private IVisualElementScheduledItem m_TouchKeyboardPoller; // 0x20
		private VisualElement m_LastPointerDownTarget; // 0x28
	
		// Constructors
		public TouchScreenTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField); // 0x000000018D641080-0x000000018D6410B8
	
		// Methods
		private void PollTouchScreenKeyboard(); // 0x000000018D640F8C-0x000000018D641080
		private void DoPollTouchScreenKeyboard(); // 0x000000018D640A94-0x000000018D640C48
		public override void ExecuteDefaultActionAtTarget(EventBase evt); // 0x000000018D640C48-0x000000018D640F8C
	}

	public class TreeView : BaseTreeView // TypeDefIndex: 71591
	{
		// Fields
		private Func<VisualElement> m_MakeItem; // 0x4B8
		private Action<VisualElement, int> m_BindItem; // 0x4C0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<VisualElement, int> _unbindItem_k__BackingField; // 0x4C8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<VisualElement> _destroyItem_k__BackingField; // 0x4D0
	
		// Properties
		public Func<VisualElement> makeItem { get; set; } // 0x000000018723BD20-0x000000018723BD30 0x000000018D641284-0x000000018D6412D4
		public Action<VisualElement, int> bindItem { get; set; } // 0x0000000184736910-0x0000000184736920 0x000000018D641234-0x000000018D641284
		public Action<VisualElement, int> unbindItem { [CompilerGenerated] get; } // 0x000000018723C000-0x000000018723C010 
		public Action<VisualElement> destroyItem { [CompilerGenerated] get; } // 0x0000000184736920-0x0000000184736930 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TreeView, UxmlTraits> // TypeDefIndex: 71589
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D643304-0x000000018D643340
		}
	
		public class UxmlTraits : BaseTreeView.UxmlTraits // TypeDefIndex: 71590
		{
			// Constructors
			public UxmlTraits(); // 0x000000018D644554-0x000000018D64455C
		}
	
		// Constructors
		public TreeView(); // 0x000000018D6411A8-0x000000018D6411B8
		public TreeView(Func<VisualElement> makeItem, Action<VisualElement, int> bindItem); // 0x000000018D6411B8-0x000000018D641234
	
		// Methods
		internal override bool HasValidDataAndBindings(); // 0x000000018D64116C-0x000000018D6411A8
		protected override CollectionViewController CreateViewController(); // 0x000000018D641110-0x000000018D64116C
	}

	[IsReadOnly]
	internal struct TreeData<T> // TypeDefIndex: 71592
	{
		// Fields
		private readonly IList<int> m_RootItemIds;
		private readonly Dictionary<int, TreeViewItemData<T>> m_Tree;
		private readonly Dictionary<int, int> m_ParentIds;
		private readonly Dictionary<int, List<int>> m_ChildrenIds;
	
		// Properties
		public IEnumerable<int> rootItemIds { get; }
	
		// Constructors
		public TreeData(IList<TreeViewItemData<T>> rootItems);
	
		// Methods
		public TreeViewItemData<T> GetDataForId(int id);
		public int GetParentId(int id);
		public void Move(int id, int newParentId, int childIndex);
		public bool HasAncestor(int childId, int ancestorId);
		private void AddItemToParent(TreeViewItemData<T> item, int parentId, int childIndex);
		private void RemoveFromParent(int id, int parentId);
		private void UpdateParentTree(TreeViewItemData<T> current);
		private void RefreshTree(IList<TreeViewItemData<T>> rootItems);
		private void BuildTree(IEnumerable<TreeViewItemData<T>> items, bool isRoot);
	}

	[IsReadOnly]
	internal struct TreeItem // TypeDefIndex: 71593
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _id_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _parentId_k__BackingField; // 0x04
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IEnumerable<int> _childrenIds_k__BackingField; // 0x08
	
		// Properties
		public int id { [CompilerGenerated] get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public int parentId { [CompilerGenerated] get; } // 0x00000001872342E0-0x00000001872342F0 
		public IEnumerable<int> childrenIds { [CompilerGenerated] get; } // 0x00000001844AFA30-0x00000001844AFA40 
		public bool hasChildren { get; } // 0x000000018D6410B8-0x000000018D641108 
	
		// Constructors
		public TreeItem(int id, int parentId = -1 /* Metadata: 0x026223FD */, IEnumerable<int> childrenIds = null); // 0x0000000187838F0C-0x0000000187838F20
	}

	[IsReadOnly]
	internal struct TreeViewItemWrapper // TypeDefIndex: 71594
	{
		// Fields
		public readonly TreeItem item; // 0x00
		public readonly int depth; // 0x10
	
		// Properties
		public int id { get; } // 0x00000001844AD290-0x00000001844AD2A0 
		public IEnumerable<int> childrenIds { get; } // 0x00000001844AFA30-0x00000001844AFA40 
		public bool hasChildren { get; } // 0x000000018D641108-0x000000018D641110 
	
		// Constructors
		public TreeViewItemWrapper(TreeItem item, int depth); // 0x000000018ABA4FAC-0x000000018ABA4FD0
	}

	[IsReadOnly]
	public struct TreeViewItemData<T> // TypeDefIndex: 71595
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _id_k__BackingField;
		private readonly T m_Data;
		private readonly IList<TreeViewItemData<T>> m_Children;
	
		// Properties
		public int id { [CompilerGenerated] get; }
		public T data { get; }
		public IEnumerable<TreeViewItemData<T>> children { get; }
		public bool hasChildren { get; }
	
		// Methods
		internal void InsertChild(TreeViewItemData<T> child, int index);
		internal void RemoveChild(int childId);
		internal int GetChildIndex(int itemId);
		internal void ReplaceChild(TreeViewItemData<T> newChild);
	}

	public class TwoPaneSplitView : VisualElement // TypeDefIndex: 71598
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
		[SerializeField]
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
		public VisualElement fixedPane { get; } // 0x000000018723A1D0-0x000000018723A1E0 
		public VisualElement flexedPane { get; } // 0x000000018723C0C0-0x000000018723C0D0 
		public int fixedPaneIndex { get; } // 0x0000000187263370-0x0000000187263380 
		internal float fixedPaneDimension { get; set; } // 0x000000018D643208-0x000000018D64322C 0x000000018D64322C-0x000000018D643248
		public override VisualElement contentContainer { get; } // 0x0000000187263360-0x0000000187263370 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits> // TypeDefIndex: 71596
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D6433F4-0x000000018D643430
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 71597
		{
			// Fields
			private UxmlIntAttributeDescription m_FixedPaneIndex; // 0x70
			private UxmlIntAttributeDescription m_FixedPaneInitialDimension; // 0x78
			private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation; // 0x80
	
			// Constructors
			public UxmlTraits(); // 0x000000018D643EFC-0x000000018D644078
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D643AAC-0x000000018D643C10
		}
	
		// Constructors
		public TwoPaneSplitView(); // 0x000000018D642F88-0x000000018D643208
		static TwoPaneSplitView(); // 0x000000018D642CC0-0x000000018D642F88
	
		// Methods
		internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation); // 0x000000018D641C84-0x000000018D641FE0
		private void OnPostDisplaySetup(GeometryChangedEvent evt); // 0x000000018D641FE0-0x000000018D6420C8
		private void PostDisplaySetup(); // 0x000000018D6422DC-0x000000018D642B58
		private void OnSizeChange(GeometryChangedEvent evt); // 0x000000018D6422A4-0x000000018D6422AC
		private void OnSizeChange(); // 0x000000018D6420C8-0x000000018D6422A4
		internal override void OnViewDataReady(); // 0x000000018D6422AC-0x000000018D6422DC
		private void SetDragLineOffset(float offset); // 0x000000018D642B58-0x000000018D642C0C
		private void SetFixedPaneDimension(float dimension); // 0x000000018D642C0C-0x000000018D642CC0
	}

	public enum TwoPaneSplitViewOrientation // TypeDefIndex: 71599
	{
		Horizontal = 0,
		Vertical = 1
	}

	internal class TwoPaneSplitViewResizer : PointerManipulator // TypeDefIndex: 71600
	{
		// Fields
		private Vector3 m_Start; // 0x38
		protected bool m_Active; // 0x44
		private TwoPaneSplitView m_SplitView; // 0x48
		private int m_Direction; // 0x50
		private TwoPaneSplitViewOrientation m_Orientation; // 0x54
	
		// Properties
		private VisualElement fixedPane { get; } // 0x000000018D641BF4-0x000000018D641C14 
		private VisualElement flexedPane { get; } // 0x000000018D641C64-0x000000018D641C84 
		private float fixedPaneMinDimension { get; } // 0x000000018D641BA4-0x000000018D641BF4 
		private float flexedPaneMinDimension { get; } // 0x000000018D641C14-0x000000018D641C64 
	
		// Constructors
		public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir, TwoPaneSplitViewOrientation orientation); // 0x000000018D641AEC-0x000000018D641BA4
	
		// Methods
		protected override void RegisterCallbacksOnTarget(); // 0x000000018D6417E4-0x000000018D641968
		protected override void UnregisterCallbacksFromTarget(); // 0x000000018D641968-0x000000018D641AEC
		public void ApplyDelta(float delta); // 0x000000018D6412D4-0x000000018D6415C8
		protected void OnPointerDown(PointerDownEvent e); // 0x000000018D6415C8-0x000000018D641674
		protected void OnPointerMove(PointerMoveEvent e); // 0x000000018D641674-0x000000018D641758
		protected void OnPointerUp(PointerUpEvent e); // 0x000000018D641758-0x000000018D6417E4
	}

	internal enum ColumnDataType // TypeDefIndex: 71601
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

	public class Column // TypeDefIndex: 71606
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<VisualElement> _destroyCell_k__BackingField; // 0xA0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Columns _collection_k__BackingField; // 0xA8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Column, ColumnDataType> changed; // 0xB0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Column> resized; // 0xB8
	
		// Properties
		public string name { get; set; } // 0x00000001829260F0-0x0000000182926100 0x000000018D6366A0-0x000000018D6366E8
		public string title { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D636748-0x000000018D636790
		public Background icon { get; } // 0x00000001872632C0-0x00000001872632E0 
		internal int index { get; } // 0x000000018D636388-0x000000018D6363B4 
		internal int displayIndex { get; } // 0x000000018D63630C-0x000000018D636388 
		internal int visibleIndex { get; } // 0x000000018D6363B4-0x000000018D636430 
		public bool visible { get; set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018D636790-0x000000018D6367A8
		public Length width { get; set; } // 0x00000001872632F0-0x0000000187263300 0x000000018D6367A8-0x000000018D6367FC
		public Length minWidth { get; set; } // 0x0000000187253890-0x00000001872538A0 0x000000018D636660-0x000000018D6366A0
		public Length maxWidth { get; set; } // 0x00000001872632E0-0x00000001872632F0 0x000000018D636620-0x000000018D636660
		internal float desiredWidth { get; set; } // 0x00000001826DD0B0-0x00000001826DD0C0 0x000000018D636550-0x000000018D636584
		public bool sortable { get; set; } // 0x00000001872361E0-0x00000001872361F0 0x000000018D636718-0x000000018D636730
		public bool stretchable { get; set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018D636730-0x000000018D636748
		public bool optional { get; set; } // 0x000000018723DD70-0x000000018723DD80 0x000000018D6366E8-0x000000018D636700
		public bool resizable { get; set; } // 0x000000018723DD60-0x000000018723DD70 0x000000018D636700-0x000000018D636718
		public Func<VisualElement> makeHeader { get; set; } // 0x0000000187232F80-0x0000000187232F90 0x000000018D6365D8-0x000000018D636620
		public Action<VisualElement> bindHeader { get; } // 0x0000000187232FC0-0x0000000187232FD0 
		public Action<VisualElement> unbindHeader { get; } // 0x00000001829CD170-0x00000001829CD180 
		public Action<VisualElement> destroyHeader { get; } // 0x00000001828D49D0-0x00000001828D49E0 
		public Func<VisualElement> makeCell { get; set; } // 0x0000000187232F50-0x0000000187232F60 0x000000018D636584-0x000000018D6365D8
		public Action<VisualElement, int> bindCell { get; } // 0x0000000182271B70-0x0000000182271B80 
		public Action<VisualElement, int> unbindCell { get; } // 0x0000000187232C70-0x0000000187232C80 
		public Action<VisualElement> destroyCell { [CompilerGenerated] get; } // 0x0000000187232F60-0x0000000187232F70 
		public Columns collection { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000187232FB0-0x0000000187232FC0 0x0000000185017110-0x0000000185017130
	
		// Events
		internal event Action<Column, ColumnDataType> changed {
			add; // 0x000000018D6361EC-0x000000018D63627C
			remove; // 0x000000018D636430-0x000000018D6364C0
		}
		internal event Action<Column> resized {
			add; // 0x000000018D63627C-0x000000018D63630C
			remove; // 0x000000018D6364C0-0x000000018D636550
		}
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 71602
			where T : Column, new()
		{
			// Constructors
			public UxmlObjectFactory();
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 71605
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
			[CompilerGenerated]
			private sealed class __c__DisplayClass15_0 // TypeDefIndex: 71603
			{
				// Fields
				public VisualTreeAsset asset;
	
				// Constructors
				public __c__DisplayClass15_0();
	
				// Methods
				internal VisualElement _Init_b__0();
			}
	
			[CompilerGenerated]
			private sealed class __c__DisplayClass15_1 // TypeDefIndex: 71604
			{
				// Fields
				public VisualTreeAsset asset;
	
				// Constructors
				public __c__DisplayClass15_1();
	
				// Methods
				internal VisualElement _Init_b__1();
			}
	
			// Constructors
			public UxmlObjectTraits();
	
			// Methods
			private static Length ParseLength(string str, Length defaultValue);
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc);
		}
	
		// Constructors
		public Column(); // 0x000000018D636194-0x000000018D6361EC
		static Column(); // 0x000000018D636138-0x000000018D636194
	
		// Methods
		private void NotifyChange(ColumnDataType type); // 0x000000018D636118-0x000000018D636138
		internal float GetWidth(float layoutWidth); // 0x000000018D6360F0-0x000000018D636118
		internal float GetMaxWidth(float layoutWidth); // 0x000000018D6360A0-0x000000018D6360C8
		internal float GetMinWidth(float layoutWidth); // 0x000000018D6360C8-0x000000018D6360F0
	}

	internal class ColumnLayout // TypeDefIndex: 71609
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action layoutRequested; // 0x88
	
		// Properties
		public Columns columns { get; } // 0x00000001829600D0-0x00000001829600E0 
		public float columnsWidth { get; } // 0x000000018D635DF0-0x000000018D635F68 
		public float layoutWidth { get; } // 0x000000018226EE90-0x000000018226EEA0 
		public float minColumnsWidth { get; } // 0x00000001872330D0-0x00000001872330E0 
		public float maxColumnsWidth { get; } // 0x00000001872330C0-0x00000001872330D0 
		public bool hasStretchableColumns { get; } // 0x000000018D635FC4-0x000000018D636008 
		public bool hasRelativeWidthColumns { get; } // 0x000000018D635F68-0x000000018D635FC4 
	
		// Events
		public event Action layoutRequested {
			add; // 0x000000018D635D58-0x000000018D635DF0
			remove; // 0x000000018D636008-0x000000018D6360A0
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 71607
		{
			// Fields
			public float totalColumnWidth; // 0x10
			public ColumnLayout __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RecomputeToMaxWidthProportionally_b__1(Column c); // 0x000000018D643260-0x000000018D6432A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0 // TypeDefIndex: 71608
		{
			// Fields
			public float totalColumnsWidth; // 0x10
			public ColumnLayout __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass54_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RecomputeToMinWidthProportionally_b__1(Column c); // 0x000000018D643260-0x000000018D6432A0
		}
	
		// Constructors
		public ColumnLayout(Columns columns); // 0x000000018D635A38-0x000000018D635D58
	
		// Methods
		public void Dirty(); // 0x000000018D632AC0-0x000000018D632AF8
		private void OnColumnAdded(Column column, int index); // 0x000000018D6341CC-0x000000018D6342B4
		private void OnColumnRemoved(Column column); // 0x000000018D6342E4-0x000000018D6343CC
		private void OnColumnReordered(Column column, int from, int to); // 0x000000018D6343CC-0x000000018D6343D4
		private bool RequiresLayoutUpdate(ColumnDataType type); // 0x000000018D634FDC-0x000000018D634FF4
		private void OnColumnChanged(Column column, ColumnDataType type); // 0x000000018D6342B4-0x000000018D6342E4
		private void OnColumnResized(Column column); // 0x00000001872632B0-0x00000001872632C0
		private static bool IsClamped(float value, float min, float max); // 0x000000018D6341BC-0x000000018D6341CC
		public void DoLayout(float width); // 0x000000018D632E24-0x000000018D633B18
		public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize); // 0x000000018D6354A8-0x000000018D63556C
		private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize); // 0x000000018D632C64-0x000000018D632E24
		private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize); // 0x000000018D632AF8-0x000000018D632C64
		private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x0262240D */); // 0x000000018D6346DC-0x000000018D6349B8
		private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x0262240E */); // 0x000000018D634B58-0x000000018D634E44
		private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow); // 0x000000018D6345C0-0x000000018D6346DC
		private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow); // 0x000000018D6343D4-0x000000018D6345C0
		private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x0262240F */); // 0x000000018D634E44-0x000000018D634FDC
		private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x02622410 */); // 0x000000018D6349B8-0x000000018D634B58
		public void ResizeToFit(float width); // 0x000000018D6350E8-0x000000018D6354A8
		private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false /* Metadata: 0x02622411 */); // 0x000000018D634FF4-0x000000018D6350E8
		internal void BeginDragResize(Column column, float pos, bool previewMode); // 0x000000018D632794-0x000000018D632A44
		public float GetDesiredPosition(Column column); // 0x000000018D634068-0x000000018D634124
		public float GetDesiredWidth(Column c); // 0x000000018D634124-0x000000018D6341BC
		public void DragResize(Column column, float pos); // 0x000000018D633B18-0x000000018D633E44
		internal void EndDragResize(Column column, bool cancelled); // 0x000000018D633E44-0x000000018D634068
		private void UpdateCache(); // 0x000000018D635634-0x000000018D6358B0
		private void UpdateMinAndMaxColumnsWidth(); // 0x000000018D6358B0-0x000000018D635A38
		private void ClearCache(); // 0x000000018D632A44-0x000000018D632AC0
		[CompilerGenerated]
		private int _DoLayout_b__49_0(Column c1, Column c2); // 0x000000018D63556C-0x000000018D6355D0
		[CompilerGenerated]
		private int _DoLayout_b__49_1(Column c1, Column c2); // 0x000000018D63556C-0x000000018D6355D0
		[CompilerGenerated]
		private int _RecomputeToMaxWidthProportionally_b__53_0(Column c1, Column c2); // 0x000000018D63556C-0x000000018D6355D0
		[CompilerGenerated]
		private int _RecomputeToMinWidthProportionally_b__54_0(Column c1, Column c2); // 0x000000018D6355D0-0x000000018D635634
	}

	internal enum ColumnsDataType // TypeDefIndex: 71610
	{
		PrimaryColumn = 0,
		StretchMode = 1,
		Reorderable = 2,
		Resizable = 3,
		ResizePreview = 4
	}

	public class Columns : ICollection<Column> // TypeDefIndex: 71615
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ColumnsDataType> changed; // 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Column, int> columnAdded; // 0x48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Column> columnRemoved; // 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Column, ColumnDataType> columnChanged; // 0x58
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Column> columnResized; // 0x60
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<Column, int, int> columnReordered; // 0x68
	
		// Properties
		public string primaryColumnName { get; set; } // 0x0000000182986470-0x0000000182986480 0x000000018D637DD8-0x000000018D637E20
		public bool reorderable { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x000000018D637E20-0x000000018D637E38
		public bool resizable { get; set; } // 0x0000000182260CA0-0x0000000182260CB0 0x000000018D637E38-0x000000018D637E50
		public bool resizePreview { get; set; } // 0x000000018226EE20-0x000000018226EE30 0x000000018D637E50-0x000000018D637E68
		internal IEnumerable<Column> displayList { get; } // 0x000000018D637A58-0x000000018D637A74 
		internal IEnumerable<Column> visibleList { get; } // 0x000000018D637A74-0x000000018D637A90 
		public StretchMode stretchMode { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x000000018D637E68-0x000000018D637E80
		public int Count { get; } // 0x000000018D63781C-0x000000018D637864 
		public bool IsReadOnly { get; } // 0x000000018D637864-0x000000018D6378B0 
		public Column this[int index] { get => default; } // 0x000000018D6378B0-0x000000018D637904 
		public Column this[string name] { get => default; } // 0x000000018D637904-0x000000018D637A58 
	
		// Events
		internal event Action<ColumnsDataType> changed {
			add; // 0x000000018D6374D4-0x000000018D637560
			remove; // 0x000000018D637A90-0x000000018D637B1C
		}
		internal event Action<Column, int> columnAdded {
			add; // 0x000000018D637560-0x000000018D6375EC
			remove; // 0x000000018D637B1C-0x000000018D637BA8
		}
		internal event Action<Column> columnRemoved {
			add; // 0x000000018D637678-0x000000018D637704
			remove; // 0x000000018D637C34-0x000000018D637CC0
		}
		internal event Action<Column, ColumnDataType> columnChanged {
			add; // 0x000000018D6375EC-0x000000018D637678
			remove; // 0x000000018D637BA8-0x000000018D637C34
		}
		internal event Action<Column> columnResized {
			add; // 0x000000018D637790-0x000000018D63781C
			remove; // 0x000000018D637D4C-0x000000018D637DD8
		}
		internal event Action<Column, int, int> columnReordered {
			add; // 0x000000018D637704-0x000000018D637790
			remove; // 0x000000018D637CC0-0x000000018D637D4C
		}
	
		// Nested types
		public enum StretchMode // TypeDefIndex: 71611
		{
			Grow = 0,
			GrowAndFill = 1
		}
	
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 71612
			where T : Columns, new()
		{
			// Constructors
			public UxmlObjectFactory();
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 71613
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
			public UxmlObjectTraits();
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71614
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Column> __9__76_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D6432A0-0x000000018D643304
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _UpdateVisibleColumns_b__76_0(Column c); // 0x000000018D643248-0x000000018D643260
		}
	
		// Constructors
		public Columns(); // 0x000000018D63744C-0x000000018D6374D4
	
		// Methods
		public bool IsPrimary(Column column); // 0x000000018D636EB8-0x000000018D636F24
		public IEnumerator<Column> GetEnumerator(); // 0x000000018D636B60-0x000000018D636BA8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D63725C-0x000000018D637268
		public void Add(Column item); // 0x000000018D6367FC-0x000000018D636860
		public void Clear(); // 0x000000018D636860-0x000000018D636900
		public bool Contains(Column item); // 0x000000018D636A64-0x000000018D636AB8
		public bool Contains(string name); // 0x000000018D636900-0x000000018D636A64
		public void CopyTo(Column[] array, int arrayIndex); // 0x000000018D636AB8-0x000000018D636B18
		public bool Remove(Column column); // 0x000000018D636F98-0x000000018D63716C
		private void OnColumnChanged(Column column, ColumnDataType type); // 0x000000018D636F38-0x000000018D636F84
		private void OnColumnResized(Column column); // 0x000000018D636F84-0x000000018D636F98
		public int IndexOf(Column column); // 0x000000018D636BA8-0x000000018D636BF8
		public void Insert(int index, Column column); // 0x000000018D636C78-0x000000018D636EB8
		public void ReorderDisplay(int from, int to); // 0x000000018D63716C-0x000000018D63725C
		private void InitOrderColumns(); // 0x000000018D636BF8-0x000000018D636C78
		private void DirtyVisibleColumns(); // 0x000000018D636B18-0x000000018D636B60
		private void UpdateVisibleColumns(); // 0x000000018D637268-0x000000018D63744C
		private void NotifyChange(ColumnsDataType type); // 0x000000018D636F24-0x000000018D636F38
	}

	public class MultiColumnController : IDisposable // TypeDefIndex: 71616
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action columnSortingChanged; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x18
		private BaseVerticalCollectionView m_View; // 0x20
		private VisualElement m_HeaderContainer; // 0x28
		private MultiColumnCollectionHeader m_MultiColumnHeader; // 0x30
	
		// Properties
		internal MultiColumnCollectionHeader header { get; } // 0x00000001829600D0-0x00000001829600E0 
	
		// Events
		public event Action columnSortingChanged {
			add; // 0x000000018D63DC40-0x000000018D63DCD4
			remove; // 0x000000018D63DD60-0x000000018D63DDF4
		}
		public event Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent {
			add; // 0x000000018D63DCD4-0x000000018D63DD60
			remove; // 0x000000018D63DDF4-0x000000018D63DE80
		}
	
		// Constructors
		public MultiColumnController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns); // 0x000000018D63D7D0-0x000000018D63DC40
		static MultiColumnController(); // 0x000000018D63D524-0x000000018D63D7D0
	
		// Methods
		private static void BindCellItem<T>(VisualElement ve, int rowIndex, Column column, T item);
		private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column); // 0x000000018D63D200-0x000000018D63D234
		private static VisualElement DefaultMakeCellItem(); // 0x000000018D63BF5C-0x000000018D63BFE0
		private static void DefaultBindCellItem<T>(VisualElement ve, Column column, T item);
		public VisualElement MakeItem(); // 0x000000018D63C7DC-0x000000018D63CAE0
		public void BindItem<T>(VisualElement element, int index, T item);
		public void UnbindItem(VisualElement element, int index); // 0x000000018D63D234-0x000000018D63D44C
		public void DestroyItem(VisualElement element); // 0x000000018D63BFE0-0x000000018D63C21C
		public void PrepareView(BaseVerticalCollectionView collectionView); // 0x000000018D63CEFC-0x000000018D63D200
		public void Dispose(); // 0x000000018D63C21C-0x000000018D63C7DC
		private void OnHorizontalScrollerValueChanged(float v); // 0x000000018D63CDB0-0x000000018D63CDD0
		private void OnViewportGeometryChanged(GeometryChangedEvent evt); // 0x000000018D63CDD0-0x000000018D63CEFC
		private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt); // 0x000000018D63CB38-0x000000018D63CB44
		private void UpdateContentContainer(BaseVerticalCollectionView collectionView); // 0x000000018D63D44C-0x000000018D63D524
		private void OnColumnSortingChanged(); // 0x0000000184221010-0x0000000184221020
		private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column); // 0x000000018D63CD9C-0x000000018D63CDB0
		private void OnColumnResized(int index, float width); // 0x000000018D63CB7C-0x000000018D63CD64
		private void OnColumnAdded(Column column, int index); // 0x000000018D63CAE0-0x000000018D63CB00
		private void OnColumnRemoved(Column column); // 0x000000018D63CAE0-0x000000018D63CB00
		private void OnColumnReordered(Column column, int from, int to); // 0x000000018D63CB44-0x000000018D63CB7C
		private void OnColumnsChanged(Column column, ColumnDataType type); // 0x000000018D63CD64-0x000000018D63CD9C
		private void OnColumnChanged(ColumnsDataType type); // 0x000000018D63CB00-0x000000018D63CB38
		private void OnViewDataRestored(); // 0x000000018D63CAE0-0x000000018D63CB00
	}

	public class MultiColumnListView : BaseListView // TypeDefIndex: 71619
	{
		// Fields
		private Columns m_Columns; // 0x538
		private bool m_SortingEnabled; // 0x540
		private SortColumnDescriptions m_SortColumnDescriptions; // 0x548
		private List<SortColumnDescription> m_SortedColumns; // 0x550
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action columnSortingChanged; // 0x558
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x560
	
		// Properties
		public new MultiColumnListViewController viewController { get; } // 0x000000018D63E374-0x000000018D63E3B8 
		public Columns columns { get; private set; } // 0x00000001828CD550-0x00000001828CD560 0x000000018D63E3B8-0x000000018D63E41C
		public SortColumnDescriptions sortColumnDescriptions { get; private set; } // 0x000000018723BC60-0x000000018723BC70 0x000000018D63E41C-0x000000018D63E4B0
		public bool sortingEnabled { set; } // 0x000000018D63E4B0-0x000000018D63E510
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits> // TypeDefIndex: 71617
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D6433B8-0x000000018D6433F4
		}
	
		public class UxmlTraits : BaseListView.UxmlTraits // TypeDefIndex: 71618
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xD8
			private readonly UxmlObjectAttributeDescription<Columns> m_Columns; // 0xE0
			private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; // 0xE8
	
			// Constructors
			public UxmlTraits(); // 0x000000018D644078-0x000000018D644188
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D6437DC-0x000000018D643928
		}
	
		// Constructors
		public MultiColumnListView(); // 0x000000018D63E30C-0x000000018D63E374
		public MultiColumnListView(Columns columns); // 0x000000018D63E1B8-0x000000018D63E30C
	
		// Methods
		protected override CollectionViewController CreateViewController(); // 0x000000018D63DE80-0x000000018D63DF14
		public override void SetViewController(CollectionViewController controller); // 0x000000018D63DF7C-0x000000018D63E1B8
		private protected override void CreateVirtualizationController(); // 0x000000018D63DF14-0x000000018D63DF50
		private void RaiseColumnSortingChanged(); // 0x000000018D63DF50-0x000000018D63DF64
		private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column); // 0x000000018D63DF64-0x000000018D63DF7C
	}

	public class MultiColumnTreeView : BaseTreeView // TypeDefIndex: 71622
	{
		// Fields
		private Columns m_Columns; // 0x4B8
		private bool m_SortingEnabled; // 0x4C0
		private SortColumnDescriptions m_SortColumnDescriptions; // 0x4C8
		private List<SortColumnDescription> m_SortedColumns; // 0x4D0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action columnSortingChanged; // 0x4D8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; // 0x4E0
	
		// Properties
		public new MultiColumnTreeViewController viewController { get; } // 0x000000018D63EA10-0x000000018D63EA54 
		public Columns columns { get; private set; } // 0x000000018723BD20-0x000000018723BD30 0x000000018D63EA54-0x000000018D63EAB8
		public SortColumnDescriptions sortColumnDescriptions { get; private set; } // 0x000000018723C000-0x000000018723C010 0x000000018D63EAB8-0x000000018D63EB4C
		public bool sortingEnabled { set; } // 0x000000018D63EB4C-0x000000018D63EBAC
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MultiColumnTreeView, UxmlTraits> // TypeDefIndex: 71620
		{
			// Constructors
			public UxmlFactory(); // 0x000000018D64346C-0x000000018D6434A8
		}
	
		public class UxmlTraits : BaseTreeView.UxmlTraits // TypeDefIndex: 71621
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xB8
			private readonly UxmlObjectAttributeDescription<Columns> m_Columns; // 0xC0
			private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; // 0xC8
	
			// Constructors
			public UxmlTraits(); // 0x000000018D644188-0x000000018D644298
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x000000018D643C10-0x000000018D643D5C
		}
	
		// Constructors
		public MultiColumnTreeView(); // 0x000000018D63E9A8-0x000000018D63EA10
		public MultiColumnTreeView(Columns columns); // 0x000000018D63E854-0x000000018D63E9A8
	
		// Methods
		protected override CollectionViewController CreateViewController(); // 0x000000018D63E510-0x000000018D63E5B0
		public override void SetViewController(CollectionViewController controller); // 0x000000018D63E618-0x000000018D63E854
		private protected override void CreateVirtualizationController(); // 0x000000018D63E5B0-0x000000018D63E5EC
		private void RaiseColumnSortingChanged(); // 0x000000018D63E5EC-0x000000018D63E600
		private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column); // 0x000000018D63E600-0x000000018D63E618
	}

	public enum SortDirection // TypeDefIndex: 71623
	{
		Ascending = 0,
		Descending = 1
	}

	[Serializable]
	public class SortColumnDescription // TypeDefIndex: 71626
	{
		// Fields
		[SerializeField]
		private int m_ColumnIndex; // 0x10
		[SerializeField]
		private string m_ColumnName; // 0x18
		[SerializeField]
		private SortDirection m_SortDirection; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Column _column_k__BackingField; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<SortColumnDescription> changed; // 0x30
	
		// Properties
		public string columnName { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D63ED9C-0x000000018D63EDE8
		public int columnIndex { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x000000018D63ED74-0x000000018D63ED9C
		public Column column { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public SortDirection direction { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018D63EDE8-0x000000018D63EE10
	
		// Events
		internal event Action<SortColumnDescription> changed {
			add; // 0x000000018D63EC5C-0x000000018D63ECE8
			remove; // 0x000000018D63ECE8-0x000000018D63ED74
		}
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 71624
			where T : SortColumnDescription, new()
		{
			// Constructors
			public UxmlObjectFactory();
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 71625
			where T : SortColumnDescription
		{
			// Fields
			private readonly UxmlStringAttributeDescription m_ColumnName;
			private readonly UxmlIntAttributeDescription m_ColumnIndex;
			private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription;
	
			// Constructors
			public UxmlObjectTraits();
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc);
		}
	
		// Constructors
		public SortColumnDescription(); // 0x000000018442FC80-0x000000018442FC90
		public SortColumnDescription(int columnIndex, SortDirection direction); // 0x000000018D63EC24-0x000000018D63EC5C
		public SortColumnDescription(string columnName, SortDirection direction); // 0x000000018D63EBEC-0x000000018D63EC24
	}

	[Serializable]
	[DefaultMember("Item")]
	public class SortColumnDescriptions : ICollection<SortColumnDescription> // TypeDefIndex: 71629
	{
		// Fields
		[SerializeField]
		private readonly IList<SortColumnDescription> m_Descriptions; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action changed; // 0x18
	
		// Properties
		public int Count { get; } // 0x000000018D63F3B4-0x000000018D63F3FC 
		public bool IsReadOnly { get; } // 0x000000018D63F3FC-0x000000018D63F448 
	
		// Events
		internal event Action changed {
			add; // 0x000000018D63F320-0x000000018D63F3B4
			remove; // 0x000000018D63F448-0x000000018D63F4DC
		}
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 71627
			where T : SortColumnDescriptions, new()
		{
			// Constructors
			public UxmlObjectFactory();
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 71628
			where T : SortColumnDescriptions
		{
			// Fields
			private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions;
	
			// Constructors
			public UxmlObjectTraits();
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc);
		}
	
		// Constructors
		public SortColumnDescriptions(); // 0x000000018D63F2A8-0x000000018D63F320
	
		// Methods
		public IEnumerator<SortColumnDescription> GetEnumerator(); // 0x000000018D63EFA0-0x000000018D63EFE8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D63F29C-0x000000018D63F2A8
		public void Add(SortColumnDescription item); // 0x000000018D63EE10-0x000000018D63EE74
		public void Clear(); // 0x000000018D63EE74-0x000000018D63EEEC
		public bool Contains(SortColumnDescription item); // 0x000000018D63EEEC-0x000000018D63EF40
		public void CopyTo(SortColumnDescription[] array, int arrayIndex); // 0x000000018D63EF40-0x000000018D63EFA0
		public bool Remove(SortColumnDescription desc); // 0x000000018D63F164-0x000000018D63F29C
		private void OnDescriptionChanged(SortColumnDescription desc); // 0x000000018B334468-0x000000018B334478
		public void Insert(int index, SortColumnDescription desc); // 0x000000018D63EFE8-0x000000018D63F164
	}

	internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController // TypeDefIndex: 71630
	{
		// Fields
		protected readonly BaseVerticalCollectionView m_View; // 0x10
		protected List<int> m_SortedSelectedIds; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _enableReordering_k__BackingField; // 0x20
	
		// Properties
		public virtual bool enableReordering { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
	
		// Constructors
		public BaseReorderableDragAndDropController(BaseVerticalCollectionView view); // 0x000000018D632700-0x000000018D632794
	
		// Methods
		public IEnumerable<int> GetSortedSelectedIds(); // 0x0000000182234E30-0x0000000182234E40
		public virtual bool CanStartDrag(IEnumerable<int> itemIndices); // 0x00000001872632A0-0x00000001872632B0
		public virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false /* Metadata: 0x0262241B */); // 0x000000018D63238C-0x000000018D632700
		protected virtual int CompareId(int id1, int id2); // 0x000000018D63236C-0x000000018D63238C
		public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args);
		public abstract void OnDrop(IListDragAndDropArgs args);
		public virtual void DragCleanup(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class DragAndDropUtility // TypeDefIndex: 71631
	{
		// Fields
		private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc; // 0x00
		private static IDragAndDrop s_DragAndDropEditor; // 0x08
		private static IDragAndDrop s_DragAndDropPlayMode; // 0x10
	
		// Methods
		internal static IDragAndDrop GetDragAndDrop(IPanel panel); // 0x000000018D6384C4-0x000000018D6385F0
	}

	internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop // TypeDefIndex: 71632
	{
		// Fields
		private readonly Hashtable m_GenericData; // 0x10
		private Label m_DraggedInfoLabel; // 0x18
		private DragVisualMode m_VisualMode; // 0x20
		private IEnumerable<UnityEngine.Object> m_UnityObjectReferences; // 0x28
	
		// Properties
		public override object source { get; } // 0x000000018D638484-0x000000018D6384C4 
		public DragAndDropData data { get; } // 0x0000000185BD80B0-0x0000000185BD80C0 
	
		// Constructors
		public DefaultDragAndDropClient(); // 0x000000018D638420-0x000000018D638484
	
		// Methods
		public override object GetGenericData(string key); // 0x000000018D637ECC-0x000000018D637F2C
		public void StartDrag(StartDragArgs args, Vector3 pointerPosition); // 0x000000018D637F2C-0x000000018D638360
		public void UpdateDrag(Vector3 pointerPosition); // 0x000000018D638360-0x000000018D638420
		public void AcceptDrag(); // 0x0000000186805BA0-0x0000000186805BB0
		public void SetVisualMode(DragVisualMode mode); // 0x0000000186036460-0x0000000186036470
		public void DragCleanup(); // 0x000000018D637E80-0x000000018D637ECC
	}

	internal abstract class DragEventsProcessor // TypeDefIndex: 71634
	{
		// Fields
		private bool m_IsRegistered; // 0x10
		internal DragState m_DragState; // 0x14
		private Vector3 m_Start; // 0x18
		internal readonly VisualElement m_Target; // 0x28
	
		// Properties
		protected virtual bool supportsDragEvents { get; } // 0x00000001851A4410-0x00000001851A4420 
		internal bool useDragEvents { get; } // 0x000000018D6395A0-0x000000018D6395D0 
		protected IDragAndDrop dragAndDrop { get; } // 0x000000018D6394D4-0x000000018D6394FC 
		internal virtual bool isEditorContext { get; } // 0x000000018D6394FC-0x000000018D6395A0 
	
		// Nested types
		internal enum DragState // TypeDefIndex: 71633
		{
			None = 0,
			CanStartDrag = 1,
			Dragging = 2
		}
	
		// Constructors
		internal DragEventsProcessor(VisualElement target); // 0x000000018D6393A8-0x000000018D6394D4
	
		// Methods
		private void RegisterCallbacksFromTarget(AttachToPanelEvent evt); // 0x000000018D638FAC-0x000000018D638FB4
		private void RegisterCallbacksFromTarget(); // 0x000000018D638CB4-0x000000018D638FAC
		private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt); // 0x000000018D63939C-0x000000018D6393A8
		internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false /* Metadata: 0x0262241C */); // 0x000000018D638FB4-0x000000018D63939C
		protected abstract bool CanStartDrag(Vector3 pointerPosition);
		protected internal abstract StartDragArgs StartDrag(Vector3 pointerPosition);
		protected internal abstract void UpdateDrag(Vector3 pointerPosition);
		protected internal abstract void OnDrop(Vector3 pointerPosition);
		protected abstract void ClearDragAndDropUI(bool dragCancelled);
		private void OnPointerDownEvent(PointerDownEvent evt); // 0x000000018D6387D8-0x000000018D6388AC
		internal void OnPointerUpEvent(PointerUpEvent evt); // 0x000000018D638B3C-0x000000018D638CB4
		private void OnPointerLeaveEvent(PointerLeaveEvent evt); // 0x000000018D6388AC-0x000000018D6388BC
		private void OnPointerCancelEvent(PointerCancelEvent evt); // 0x000000018D6386CC-0x000000018D638774
		private void OnPointerCapturedOut(PointerCaptureOutEvent evt); // 0x000000018D638774-0x000000018D6387D8
		private void OnPointerMoveEvent(PointerMoveEvent evt); // 0x000000018D6388BC-0x000000018D638B3C
		private DragEventsProcessor GetDropTarget(Vector2 position); // 0x000000018D6385F0-0x000000018D6386CC
	}

	internal interface ICollectionDragAndDropController : IDragAndDropController<IListDragAndDropArgs>, IReorderable // TypeDefIndex: 71635
	{
	}

	internal interface IDragAndDrop // TypeDefIndex: 71636
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

	internal abstract class DragAndDropData // TypeDefIndex: 71637
	{
		// Properties
		public abstract object source { get; }
	
		// Constructors
		protected DragAndDropData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract object GetGenericData(string key);
	}

	internal interface IDragAndDropController<in TArgs> // TypeDefIndex: 71638
	{
		// Methods
		bool CanStartDrag(IEnumerable<int> itemIndices);
		StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIndices, bool skipText = false /* Metadata: 0x02622420 */);
		DragVisualMode HandleDragAndDrop(TArgs args);
		void OnDrop(TArgs args);
		void DragCleanup();
		void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition);
		IEnumerable<int> GetSortedSelectedIds();
	}

	internal enum DragVisualMode // TypeDefIndex: 71639
	{
		None = 0,
		Copy = 1,
		Move = 2,
		Rejected = 3
	}

	[IsReadOnly]
	internal struct CanStartDragArgs // TypeDefIndex: 71640
	{
		// Fields
		public readonly VisualElement draggedElement; // 0x00
		public readonly int id; // 0x08
		public readonly IEnumerable<int> selectedIds; // 0x10
	
		// Constructors
		internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<int> selectedIds); // 0x000000018BA3C704-0x000000018BA3C72C
	}

	[IsReadOnly]
	internal struct SetupDragAndDropArgs // TypeDefIndex: 71641
	{
		// Fields
		public readonly VisualElement draggedElement; // 0x00
		public readonly IEnumerable<int> selectedIds; // 0x08
		public readonly StartDragArgs startDragArgs; // 0x10
	
		// Constructors
		internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<int> selectedIds, StartDragArgs startDragArgs); // 0x000000018D63EBAC-0x000000018D63EBEC
	}

	[IsReadOnly]
	internal struct HandleDragAndDropArgs // TypeDefIndex: 71642
	{
		// Fields
		private readonly DragAndDropArgs m_DragAndDropArgs; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector2 _position_k__BackingField; // 0x20
	
		// Constructors
		internal HandleDragAndDropArgs(Vector2 position, DragAndDropArgs dragAndDropArgs); // 0x000000018D6395D0-0x000000018D6395EC
	}

	internal struct StartDragArgs // TypeDefIndex: 71643
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _title_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly DragVisualMode _visualMode_k__BackingField; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Hashtable _genericData_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IEnumerable<UnityEngine.Object> _unityObjectReferences_k__BackingField; // 0x18
	
		// Properties
		public string title { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184431970-0x0000000184431980 
		public DragVisualMode visualMode { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184431A70-0x0000000184431A80 
		internal Hashtable genericData { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		internal IEnumerable<UnityEngine.Object> unityObjectReferences { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public StartDragArgs(string title, DragVisualMode visualMode); // 0x000000018D63F57C-0x000000018D63F5B4
	
		// Methods
		public void SetGenericData(string key, object data); // 0x000000018D63F4DC-0x000000018D63F57C
	}

	internal interface IListDragAndDropArgs // TypeDefIndex: 71644
	{
		// Properties
		int insertAtIndex { get; }
		int parentId { get; }
		int childIndex { get; }
		DragAndDropData dragAndDropData { get; }
		DragAndDropPosition dragAndDropPosition { get; }
	}

	internal struct DragAndDropArgs : IListDragAndDropArgs // TypeDefIndex: 71645
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _target_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _insertAtIndex_k__BackingField; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _parentId_k__BackingField; // 0x0C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _childIndex_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DragAndDropPosition _dragAndDropPosition_k__BackingField; // 0x14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DragAndDropData _dragAndDropData_k__BackingField; // 0x18
	
		// Properties
		public object target { [CompilerGenerated] set; } // 0x00000001878380EC-0x00000001878380F4
		public int insertAtIndex { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184431A70-0x0000000184431A80 0x0000000187235AA0-0x0000000187235AB0
		public int parentId { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000184431980-0x0000000184431990 0x00000001872397D0-0x00000001872397E0
		public int childIndex { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public DragAndDropPosition dragAndDropPosition { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public DragAndDropData dragAndDropData { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	}

	internal enum DragAndDropPosition // TypeDefIndex: 71646
	{
		OverItem = 0,
		BetweenItems = 1,
		OutsideItems = 2
	}

	internal interface IReorderable // TypeDefIndex: 71647
	{
		// Properties
		bool enableReordering { get; set; }
	}

	internal class ListViewDragger : DragEventsProcessor // TypeDefIndex: 71649
	{
		// Fields
		private DragPosition m_LastDragPosition; // 0x30
		private VisualElement m_DragHoverBar; // 0x50
		private VisualElement m_DragHoverItemMarker; // 0x58
		private VisualElement m_DragHoverSiblingMarker; // 0x60
		private float m_LeftIndentation; // 0x68
		private float m_SiblingBottom; // 0x6C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ICollectionDragAndDropController _dragAndDropController_k__BackingField; // 0x70
	
		// Properties
		protected BaseVerticalCollectionView targetView { get; } // 0x000000018D63BF20-0x000000018D63BF5C 
		protected ScrollView targetScrollView { get; } // 0x000000018D63BEFC-0x000000018D63BF20 
		public ICollectionDragAndDropController dragAndDropController { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
	
		// Nested types
		internal struct DragPosition : IEquatable<DragPosition> // TypeDefIndex: 71648
		{
			// Fields
			public int insertAtIndex; // 0x00
			public int parentId; // 0x04
			public int childIndex; // 0x08
			public ReusableCollectionItem recycledItem; // 0x10
			public DragAndDropPosition dropPosition; // 0x18
	
			// Methods
			public bool Equals(DragPosition other); // 0x000000018D6455A4-0x000000018D645608
			public override bool Equals(object obj); // 0x000000018D645524-0x000000018D6455A4
			public override int GetHashCode(); // 0x000000018D645608-0x000000018D645678
		}
	
		// Constructors
		public ListViewDragger(BaseVerticalCollectionView listView); // 0x000000018D63BEE4-0x000000018D63BEFC
	
		// Methods
		protected override bool CanStartDrag(Vector3 pointerPosition); // 0x000000018D639C20-0x000000018D639E9C
		protected internal override StartDragArgs StartDrag(Vector3 pointerPosition); // 0x000000018D63B6FC-0x000000018D63B950
		protected internal override void UpdateDrag(Vector3 pointerPosition); // 0x000000018D63BD8C-0x000000018D63BEE4
		private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref DragPosition dragPosition); // 0x000000018D63A5D0-0x000000018D63A73C
		protected internal override void OnDrop(Vector3 pointerPosition); // 0x000000018D63B16C-0x000000018D63B354
		internal void HandleDragAndScroll(Vector2 pointerPosition); // 0x000000018D63A7C8-0x000000018D63A9CC
		private void HandleAutoExpansion(Vector2 pointerPosition); // 0x000000018D63A73C-0x000000018D63A7C8
		private void ApplyDragAndDropUI(DragPosition dragPosition); // 0x000000018D6395EC-0x000000018D639C20
		protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition); // 0x000000018D63B950-0x000000018D63BD04
		private void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition); // 0x000000018D63AF5C-0x000000018D63B030
		private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition); // 0x000000018D63A9CC-0x000000018D63AF5C
		private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId); // 0x000000018D63A26C-0x000000018D63A3EC
		protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition); // 0x000000018D63B030-0x000000018D63B16C
		private float GetHoverBarTopPosition(ReusableCollectionItem item); // 0x000000018D63A198-0x000000018D63A26C
		private void PlaceHoverBarAtElement(ReusableCollectionItem item); // 0x000000018D63B354-0x000000018D63B38C
		private void PlaceHoverBarAt(float top, float indentationPadding = -1f /* Metadata: 0x02622428 */, float siblingBottom = -1f /* Metadata: 0x0262242C */); // 0x000000018D63B38C-0x000000018D63B6FC
		protected override void ClearDragAndDropUI(bool dragCancelled); // 0x000000018D639E9C-0x000000018D63A198
		protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition); // 0x000000018D63A3EC-0x000000018D63A5D0
		[CompilerGenerated]
		private void _ApplyDragAndDropUI_g__GeometryChangedCallback_27_0(GeometryChangedEvent e); // 0x000000018D63BD04-0x000000018D63BD8C
	}

	internal static class ListViewDraggerExtension // TypeDefIndex: 71650
	{
		// Extension methods
		public static ReusableCollectionItem GetRecycledItemFromId(this BaseVerticalCollectionView listView, int id); // 0x000000018D64A8C8-0x000000018D64AA24
		public static ReusableCollectionItem GetRecycledItemFromIndex(this BaseVerticalCollectionView listView, int index); // 0x000000018D64AA24-0x000000018D64AB80
	}

	internal class ListViewDraggerAnimated : ListViewDragger // TypeDefIndex: 71651
	{
		// Fields
		private int m_DragStartIndex; // 0x78
		private int m_CurrentIndex; // 0x7C
		private float m_SelectionHeight; // 0x80
		private float m_LocalOffsetOnStart; // 0x84
		private Vector3 m_CurrentPointerPosition; // 0x88
		private ReusableCollectionItem m_Item; // 0x98
		private ReusableCollectionItem m_OffsetItem; // 0xA0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isDragging_k__BackingField; // 0xA8
	
		// Properties
		public bool isDragging { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E110-0x000000018225E120 0x000000018225E120-0x000000018225E130
		public ReusableCollectionItem draggedItem { get; } // 0x0000000187232C70-0x0000000187232C80 
		protected override bool supportsDragEvents { get; } // 0x00000001843FFFF0-0x0000000184400000 
	
		// Constructors
		public ListViewDraggerAnimated(BaseVerticalCollectionView listView); // 0x000000018D64A8C0-0x000000018D64A8C8
	
		// Methods
		protected internal override StartDragArgs StartDrag(Vector3 pointerPosition); // 0x000000018D649B88-0x000000018D64A1BC
		protected internal override void UpdateDrag(Vector3 pointerPosition); // 0x000000018D64A1F0-0x000000018D64A8C0
		private void Animate(ReusableCollectionItem element, float paddingTop); // 0x000000018D6495C0-0x000000018D649830
		protected internal override void OnDrop(Vector3 pointerPosition); // 0x000000018D649830-0x000000018D649B88
		protected override void ClearDragAndDropUI(bool dragCancelled); // 0x0000000186805BA0-0x0000000186805BB0
		protected override bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition); // 0x000000018D64A1BC-0x000000018D64A1F0
	}

	internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController // TypeDefIndex: 71652
	{
		// Fields
		protected readonly BaseListView m_ListView; // 0x28
	
		// Constructors
		public ListViewReorderableDragAndDropController(BaseListView view); // 0x000000018D64ADFC-0x000000018D64AE2C
	
		// Methods
		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args); // 0x000000018D64AB80-0x000000018D64ABF0
		public override void OnDrop(IListDragAndDropArgs args); // 0x000000018D64ABF0-0x000000018D64ADFC
	}

	internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController // TypeDefIndex: 71655
	{
		// Fields
		protected DropData m_DropData; // 0x28
		protected readonly BaseTreeView m_TreeView; // 0x30
		private IVisualElementScheduledItem m_ExpandDropItemScheduledItem; // 0x38
		private Action m_ExpandDropItemCallback; // 0x40
	
		// Nested types
		protected class DropData // TypeDefIndex: 71653
		{
			// Fields
			public int[] expandedIdsBeforeDrag; // 0x10
			public int[] draggedIds; // 0x18
			public int lastItemId; // 0x20
			public float expandItemBeginTimerMs; // 0x24
			public Vector2 expandItemBeginPosition; // 0x28
	
			// Constructors
			public DropData(); // 0x00000001872407F0-0x0000000187240800
		}
	
		private struct TreeItemState // TypeDefIndex: 71654
		{
			// Fields
			public int parentId; // 0x00
			public int childIndex; // 0x04
	
			// Constructors
			public TreeItemState(int parentId, int childIndex); // 0x00000001827241A0-0x00000001827241B0
		}
	
		// Constructors
		public TreeViewReorderableDragAndDropController(BaseTreeView view); // 0x000000018D65245C-0x000000018D652528
	
		// Methods
		protected override int CompareId(int id1, int id2); // 0x000000018D6512BC-0x000000018D65178C
		public override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false /* Metadata: 0x02622430 */); // 0x000000018D652390-0x000000018D65245C
		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args); // 0x000000018D651C2C-0x000000018D651C84
		public override void OnDrop(IListDragAndDropArgs args); // 0x000000018D651C84-0x000000018D6521D0
		public override void DragCleanup(); // 0x000000018D6517F8-0x000000018D6518D4
		private void RestoreExpanded(List<int> ids); // 0x000000018D6521D0-0x000000018D652390
		public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition); // 0x000000018D651A7C-0x000000018D651C2C
		private void DelayExpandDropItem(); // 0x000000018D65178C-0x000000018D6517F8
		private void ExpandDropItem(); // 0x000000018D6518D4-0x000000018D651A7C
	}

	internal interface IPointerCaptureEventInternal // TypeDefIndex: 71656
	{
		// Properties
		int pointerId { get; }
	}

	public abstract class PointerCaptureEventBase<T> : EventBase<T>, IPointerCaptureEventInternal // TypeDefIndex: 71657
		where T : PointerCaptureEventBase<T>, new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IEventHandler _relatedTarget_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _pointerId_k__BackingField;
	
		// Properties
		private IEventHandler relatedTarget { [CompilerGenerated] set; }
		public int pointerId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		protected PointerCaptureEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId);
	}

	public class PointerCaptureOutEvent : PointerCaptureEventBase<PointerCaptureOutEvent> // TypeDefIndex: 71658
	{
		// Constructors
		public PointerCaptureOutEvent(); // 0x000000018D64E830-0x000000018D64E86C
	}

	public class PointerCaptureEvent : PointerCaptureEventBase<PointerCaptureEvent> // TypeDefIndex: 71659
	{
		// Constructors
		public PointerCaptureEvent(); // 0x000000018D64E7F4-0x000000018D64E830
	}

	public abstract class MouseCaptureEventBase<T> : PointerCaptureEventBase<T> // TypeDefIndex: 71660
		where T : MouseCaptureEventBase<T>, new()
	{
		// Constructors
		protected MouseCaptureEventBase();
	
		// Methods
		protected override void Init();
	}

	public class MouseCaptureOutEvent : MouseCaptureEventBase<MouseCaptureOutEvent> // TypeDefIndex: 71661
	{
		// Constructors
		public MouseCaptureOutEvent(); // 0x000000018D64B2FC-0x000000018D64B338
	}

	public class MouseCaptureEvent : MouseCaptureEventBase<MouseCaptureEvent> // TypeDefIndex: 71662
	{
		// Constructors
		public MouseCaptureEvent(); // 0x000000018D64B2C0-0x000000018D64B2FC
	}

	public class ChangeEvent<T> : EventBase<ChangeEvent<T>> // TypeDefIndex: 71663
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private T _previousValue_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private T _newValue_k__BackingField;
	
		// Properties
		public T previousValue { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public T newValue { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public ChangeEvent();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		public static ChangeEvent<T> GetPooled(T previousValue, T newValue);
	}

	internal class CommandEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71664
	{
		// Constructors
		public CommandEventDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D644B90-0x000000018D644BD0
		public void DispatchEvent(EventBase evt, IPanel panel); // 0x000000018D644BD0-0x000000018D644D60
	}

	public interface ICommandEvent // TypeDefIndex: 71665
	{
	}

	public abstract class CommandEventBase<T> : EventBase<T>, ICommandEvent // TypeDefIndex: 71666
		where T : CommandEventBase<T>, new()
	{
		// Fields
		private string m_CommandName;
	
		// Properties
		public string commandName { get; protected set; }
	
		// Constructors
		protected CommandEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		public static T GetPooled(UnityEngine.Event systemEvent);
		public static T GetPooled(string commandName);
	}

	public class ValidateCommandEvent : CommandEventBase<ValidateCommandEvent> // TypeDefIndex: 71667
	{
		// Constructors
		public ValidateCommandEvent(); // 0x000000018D6541CC-0x000000018D654208
	}

	public class ExecuteCommandEvent : CommandEventBase<ExecuteCommandEvent> // TypeDefIndex: 71668
	{
		// Constructors
		public ExecuteCommandEvent(); // 0x000000018D6486C4-0x000000018D648700
	}

	internal class DefaultDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71669
	{
		// Constructors
		public DefaultDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D64535C-0x000000018D64539C
		public void DispatchEvent(EventBase evt, IPanel panel); // 0x000000018D64539C-0x000000018D6454E8
	}

	internal class ElementUnderPointer // TypeDefIndex: 71670
	{
		// Fields
		private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
		private VisualElement[] m_TopElementUnderPointer; // 0x18
		private IPointerEvent[] m_TriggerPointerEvent; // 0x20
		private IMouseEvent[] m_TriggerMouseEvent; // 0x28
		private Vector2[] m_PickingPointerPositions; // 0x30
		private bool[] m_IsPickingPointerTemporaries; // 0x38
	
		// Constructors
		public ElementUnderPointer(); // 0x000000018D64675C-0x000000018D6468C4
	
		// Methods
		internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary); // 0x000000018D64635C-0x000000018D6463E4
		internal VisualElement GetTopElementUnderPointer(int pointerId); // 0x000000018B636D34-0x000000018B636D60
		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos); // 0x000000018D646614-0x000000018D646740
		private Vector2 GetEventPointerPosition(EventBase triggerEvent); // 0x000000018D646298-0x000000018D64635C
		internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent); // 0x000000018D646740-0x000000018D64675C
		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent); // 0x000000018D6465F8-0x000000018D646614
		private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary); // 0x000000018D6463E4-0x000000018D6465F8
		internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType); // 0x000000018D6456E8-0x000000018D646298
	}

	public abstract class EventBase : IDisposable // TypeDefIndex: 71673
	{
		// Fields
		private static long s_LastTypeId; // 0x00
		private static ulong s_NextEventId; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long _timestamp_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ulong _eventId_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ulong _triggerEventId_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventPropagation _propagation_k__BackingField; // 0x28
		private PropagationPaths m_Path; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private LifeCycleStatus _lifeCycleStatus_k__BackingField; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IEventHandler _leafTarget_k__BackingField; // 0x40
		private IEventHandler m_Target; // 0x48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly List<IEventHandler> _skipElements_k__BackingField; // 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private PropagationPhase _propagationPhase_k__BackingField; // 0x58
		private IEventHandler m_CurrentTarget; // 0x60
		private UnityEngine.Event m_ImguiEvent; // 0x68
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _originalMousePosition_k__BackingField; // 0x70
	
		// Properties
		public virtual long eventTypeId { get; } // 0x0000000187251F70-0x0000000187251F80 
		public long timestamp { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x000000018561B5A0-0x000000018561B5B0
		internal ulong eventId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018561CBD0-0x000000018561CBE0
		private ulong triggerEventId { [CompilerGenerated] set; } // 0x000000018561BB30-0x000000018561BB40
		internal EventPropagation propagation { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		internal PropagationPaths path { get; set; } // 0x000000018D646D38-0x000000018D646DF8 0x000000018D647074-0x000000018D6470D4
		private LifeCycleStatus lifeCycleStatus { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public bool bubbles { get; } // 0x000000018D646CE4-0x000000018D646CEC 
		public bool tricklesDown { get; } // 0x000000018D646E34-0x000000018D646E3C 
		internal bool skipDisabledElements { get; set; } // 0x000000018D646E24-0x000000018D646E2C 0x000000018D647144-0x000000018D647160
		internal bool ignoreCompositeRoots { get; set; } // 0x000000018D646D00-0x000000018D646D08 0x000000018D646F5C-0x000000018D646F78
		internal IEventHandler leafTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public IEventHandler target { get; set; } // 0x0000000187261F50-0x0000000187261F60 0x000000018D64717C-0x000000018D6471AC
		internal List<IEventHandler> skipElements { [CompilerGenerated] get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public bool isPropagationStopped { get; private set; } // 0x000000018D646D30-0x000000018D646D38 0x000000018D647058-0x000000018D647074
		public bool isImmediatePropagationStopped { get; private set; } // 0x000000018D646D28-0x000000018D646D30 0x000000018D64703C-0x000000018D647058
		public bool isDefaultPrevented { get; private set; } // 0x000000018D646D20-0x000000018D646D28 0x000000018D2FF3A4-0x000000018D2FF3C0
		public PropagationPhase propagationPhase { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
		public virtual IEventHandler currentTarget { get; internal set; } // 0x0000000187261F00-0x0000000187261F10 0x000000018D646E3C-0x000000018D646F28
		public bool dispatch { get; internal set; } // 0x000000018D646CEC-0x000000018D646CF4 0x000000018D646F28-0x000000018D646F40
		private bool dispatched { get; set; } // 0x000000018D646CF4-0x000000018D646D00 0x000000018D646F40-0x000000018D646F5C
		internal bool processed { get; private set; } // 0x000000018D646E0C-0x000000018D646E18 0x000000018D64710C-0x000000018D647128
		internal bool processedByFocusController { get; set; } // 0x000000018D646E00-0x000000018D646E0C 0x000000018D6470F0-0x000000018D64710C
		internal bool stopDispatch { get; set; } // 0x000000018D646E2C-0x000000018D646E34 0x000000018D647160-0x000000018D64717C
		internal bool propagateToIMGUI { get; set; } // 0x000000018D646E18-0x000000018D646E24 0x000000018D647128-0x000000018D647144
		private bool imguiEventIsValid { get; set; } // 0x000000018D646D08-0x000000018D646D10 0x000000018CB5ED38-0x000000018CB5ED54
		public UnityEngine.Event imguiEvent { get; protected set; } // 0x000000018D646D10-0x000000018D646D20 0x000000018D646F78-0x000000018D64703C
		public Vector2 originalMousePosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187263390-0x00000001872633B0 0x00000001872338F0-0x0000000187233900
		protected bool pooled { get; set; } // 0x000000018D646DF8-0x000000018D646E00 0x000000018D6470D4-0x000000018D6470F0
	
		// Nested types
		[Flags]
		internal enum EventPropagation // TypeDefIndex: 71671
		{
			None = 0,
			Bubbles = 1,
			TricklesDown = 2,
			Cancellable = 4,
			SkipDisabledElements = 8,
			IgnoreCompositeRoots = 16
		}
	
		[Flags]
		private enum LifeCycleStatus // TypeDefIndex: 71672
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
		protected EventBase(); // 0x000000018D646C54-0x000000018D646CE4
	
		// Methods
		protected static long RegisterEventType(); // 0x000000018D646BA4-0x000000018D646BE8
		internal void SetTriggerEventId(ulong id); // 0x000000018561BB30-0x000000018561BB40
		[Obsolete("Override PreDispatch(IPanel panel) instead.")]
		protected virtual void PreDispatch(); // 0x0000000186805BA0-0x0000000186805BB0
		protected internal virtual void PreDispatch(IPanel panel); // 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("Override PostDispatch(IPanel panel) instead.")]
		protected virtual void PostDispatch(); // 0x0000000186805BA0-0x0000000186805BB0
		protected internal virtual void PostDispatch(IPanel panel); // 0x000000018D646B8C-0x000000018D646B98
		internal bool Skip(IEventHandler h); // 0x000000018D646BE8-0x000000018D646C3C
		public void StopPropagation(); // 0x000000018D646C4C-0x000000018D646C54
		public void StopImmediatePropagation(); // 0x000000018D646C3C-0x000000018D646C4C
		public void PreventDefault(); // 0x000000018D646B98-0x000000018D646BA4
		internal void MarkReceivedByDispatcher(); // 0x000000018D646B20-0x000000018D646B8C
		protected virtual void Init(); // 0x000000018D6469D8-0x000000018D6469E0
		private void LocalInit(); // 0x000000018D6469E0-0x000000018D646B20
		internal abstract void Acquire();
		public abstract void Dispose();
	}

	public abstract class EventBase<T> : EventBase // TypeDefIndex: 71674
		where T : EventBase<T>, new()
	{
		// Fields
		private static readonly long s_TypeId;
		private static readonly ObjectPool<T> s_Pool;
		private int m_RefCount;
	
		// Properties
		public override long eventTypeId { get; }
	
		// Constructors
		protected EventBase();
		static EventBase();
	
		// Methods
		public static long TypeId();
		protected override void Init();
		public static T GetPooled();
		internal static T GetPooled(EventBase e);
		private static void ReleasePooled(T evt);
		internal override void Acquire();
		public sealed override void Dispose();
	}

	public delegate void EventCallback<in TEventType>(TEventType evt); // TypeDefIndex: 71675; 0x00000000-0x00000000

	internal abstract class EventCallbackFunctorBase // TypeDefIndex: 71676
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly CallbackPhase _phase_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly InvokePolicy _invokePolicy_k__BackingField; // 0x14
	
		// Properties
		public CallbackPhase phase { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public InvokePolicy invokePolicy { [CompilerGenerated] get; } // 0x0000000182971EE0-0x0000000182971EF0 
	
		// Constructors
		protected EventCallbackFunctorBase(CallbackPhase phase, InvokePolicy invokePolicy); // 0x0000000187235240-0x0000000187235250
	
		// Methods
		public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase);
		public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase);
		protected bool PhaseMatches(PropagationPhase propagationPhase); // 0x000000018D6471AC-0x000000018D6471D0
	}

	internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase // TypeDefIndex: 71677
		where TEventType : EventBase<TEventType>, new()
	{
		// Fields
		private readonly EventCallback<TEventType> m_Callback;
		private readonly long m_EventTypeId;
	
		// Constructors
		public EventCallbackFunctor(EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy = InvokePolicy.Default /* Metadata: 0x02622448 */);
	
		// Methods
		public override void Invoke(EventBase evt, PropagationPhase propagationPhase);
		public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase);
	}

	public enum TrickleDown // TypeDefIndex: 71678
	{
		NoTrickleDown = 0,
		TrickleDown = 1
	}

	internal enum CallbackPhase // TypeDefIndex: 71679
	{
		TargetAndBubbleUp = 1,
		TrickleDownAndTarget = 2
	}

	internal enum InvokePolicy // TypeDefIndex: 71680
	{
		Default = 0,
		IncludeDisabled = 1
	}

	internal class EventCallbackListPool // TypeDefIndex: 71681
	{
		// Fields
		private readonly Stack<EventCallbackList> m_Stack; // 0x10
	
		// Constructors
		public EventCallbackListPool(); // 0x000000018D647300-0x000000018D647378
	
		// Methods
		public EventCallbackList Get(EventCallbackList initializer); // 0x000000018D6471D0-0x000000018D64729C
		public void Release(EventCallbackList element); // 0x000000018D64729C-0x000000018D647300
	}

	internal class EventCallbackList // TypeDefIndex: 71682
	{
		// Fields
		private List<EventCallbackFunctorBase> m_List; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _trickleDownCallbackCount_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _bubbleUpCallbackCount_k__BackingField; // 0x1C
	
		// Properties
		public int trickleDownCallbackCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public int bubbleUpCallbackCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public int Count { get; } // 0x000000018D6478C0-0x000000018D647900 
		public EventCallbackFunctorBase this[int i] { get => default; } // 0x000000018D647900-0x000000018D647954 
	
		// Constructors
		public EventCallbackList(); // 0x000000018D6477A8-0x000000018D647828
		public EventCallbackList(EventCallbackList source); // 0x000000018D647828-0x000000018D6478C0
	
		// Methods
		public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase); // 0x000000018D6475D0-0x000000018D6475F0
		public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase); // 0x000000018D6475F0-0x000000018D6476BC
		public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase); // 0x000000018D6476BC-0x000000018D6477A8
		public void Add(EventCallbackFunctorBase item); // 0x000000018D647510-0x000000018D647580
		public void AddRange(EventCallbackList list); // 0x000000018D647378-0x000000018D647510
		public void Clear(); // 0x000000018D647580-0x000000018D6475D0
	}

	internal class EventCallbackRegistry // TypeDefIndex: 71683
	{
		// Fields
		private static readonly EventCallbackListPool s_ListPool; // 0x00
		private EventCallbackList m_Callbacks; // 0x10
		private EventCallbackList m_TemporaryCallbacks; // 0x18
		private int m_IsInvoking; // 0x20
	
		// Constructors
		public EventCallbackRegistry(); // 0x00000001872327A0-0x00000001872327B0
		static EventCallbackRegistry(); // 0x000000018D647CF4-0x000000018D647D70
	
		// Methods
		private static EventCallbackList GetCallbackList(EventCallbackList initializer = null); // 0x000000018D647A08-0x000000018D647A68
		private static void ReleaseCallbackList(EventCallbackList toRelease); // 0x000000018D647C24-0x000000018D647C84
		private EventCallbackList GetCallbackListForWriting(); // 0x000000018D647968-0x000000018D647A08
		private EventCallbackList GetCallbackListForReading(); // 0x000000018D647954-0x000000018D647968
		private bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown); // 0x000000018D647C84-0x000000018D647CF4
		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x0262244F */, InvokePolicy invokePolicy = InvokePolicy.Default /* Metadata: 0x02622450 */)
			where TEventType : EventBase<TEventType>, new();
		public bool UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x02622451 */)
			where TEventType : EventBase<TEventType>, new();
		public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase); // 0x000000018D647A98-0x000000018D647C24
		public bool HasTrickleDownHandlers(); // 0x000000018D647A80-0x000000018D647A98
		public bool HasBubbleHandlers(); // 0x000000018D647A68-0x000000018D647A80
	}

	public interface IEventHandler // TypeDefIndex: 71684
	{
		// Methods
		void SendEvent(EventBase e);
		void HandleEvent(EventBase evt);
	}

	public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 71685
	{
		// Fields
		internal bool isIMGUIContainer; // 0x10
		private EventCallbackRegistry m_CallbackRegistry; // 0x18
	
		// Constructors
		protected CallbackEventHandler(); // 0x000000018275FD80-0x000000018275FD90
	
		// Methods
		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x02622452 */)
			where TEventType : EventBase<TEventType>, new();
		internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x02622453 */)
			where TEventType : EventBase<TEventType>, new();
		public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x02622454 */)
			where TEventType : EventBase<TEventType>, new();
		public abstract void SendEvent(EventBase e);
		internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);
		internal void HandleEventAtTargetPhase(EventBase evt); // 0x000000018D64478C-0x000000018D6447EC
		internal void HandleEventAtTargetAndDefaultPhase(EventBase evt); // 0x000000018D644748-0x000000018D64478C
		internal void HandleEventAtCurrentTargetAndPhase(EventBase evt); // 0x000000018CFFE830-0x000000018CFFE844
		void IEventHandler.HandleEvent(EventBase evt); // 0x000000018CFFE830-0x000000018CFFE844
		public virtual void HandleEvent(EventBase evt); // 0x000000018D6447EC-0x000000018D644A1C
		public bool HasTrickleDownHandlers(); // 0x000000018D644A38-0x000000018D644A54
		public bool HasBubbleUpHandlers(); // 0x000000018D644A1C-0x000000018D644A38
		protected virtual void ExecuteDefaultActionAtTarget(EventBase evt); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void ExecuteDefaultAction(EventBase evt); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void ExecuteDefaultActionDisabled(EventBase evt); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class FocusEventBase<T> : EventBase<T> // TypeDefIndex: 71686
		where T : FocusEventBase<T>, new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Focusable _relatedTarget_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FocusChangeDirection _direction_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FocusController _focusController_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _IsFocusDelegated_k__BackingField;
	
		// Properties
		public Focusable relatedTarget { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FocusChangeDirection direction { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected FocusController focusController { [CompilerGenerated] get; [CompilerGenerated] private set; }
		internal bool IsFocusDelegated { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		protected FocusEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false /* Metadata: 0x02622455 */);
	}

	public class FocusOutEvent : FocusEventBase<FocusOutEvent> // TypeDefIndex: 71687
	{
		// Constructors
		public FocusOutEvent(); // 0x000000018D648878-0x000000018D6488BC
	
		// Methods
		protected override void Init(); // 0x000000018D648834-0x000000018D648878
		private new void LocalInit(); // 0x00000001872633B0-0x00000001872633C0
	}

	public class BlurEvent : FocusEventBase<BlurEvent> // TypeDefIndex: 71688
	{
		// Constructors
		public BlurEvent(); // 0x000000018D64470C-0x000000018D644748
	
		// Methods
		protected internal override void PreDispatch(IPanel panel); // 0x000000018D6446AC-0x000000018D64470C
	}

	public class FocusInEvent : FocusEventBase<FocusInEvent> // TypeDefIndex: 71689
	{
		// Constructors
		public FocusInEvent(); // 0x000000018D6487F0-0x000000018D648834
	
		// Methods
		protected override void Init(); // 0x000000018D6487AC-0x000000018D6487F0
		private new void LocalInit(); // 0x00000001872633B0-0x00000001872633C0
	}

	public class FocusEvent : FocusEventBase<FocusEvent> // TypeDefIndex: 71690
	{
		// Constructors
		public FocusEvent(); // 0x000000018D648770-0x000000018D6487AC
	
		// Methods
		protected internal override void PreDispatch(IPanel panel); // 0x000000018D648700-0x000000018D648770
	}

	public enum PropagationPhase // TypeDefIndex: 71691
	{
		None = 0,
		TrickleDown = 1,
		AtTarget = 2,
		BubbleUp = 3,
		DefaultAction = 4,
		DefaultActionAtTarget = 5
	}

	internal interface IEventDispatchingStrategy // TypeDefIndex: 71692
	{
		// Methods
		bool CanDispatchEvent(EventBase evt);
		void DispatchEvent(EventBase evt, IPanel panel);
	}

	internal static class EventDispatchUtilities // TypeDefIndex: 71693
	{
		// Methods
		public static void PropagateEvent(EventBase evt); // 0x000000018D647E20-0x000000018D6484F0
		internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt); // 0x000000018D6484F0-0x000000018D6486C4
		public static void ExecuteDefaultAction(EventBase evt, IPanel panel); // 0x000000018D647D70-0x000000018D647E20
	}

	internal class IMGUIEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71694
	{
		// Constructors
		public IMGUIEventDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D648FEC-0x000000018D64902C
		public void DispatchEvent(EventBase evt, IPanel panel); // 0x000000018D64902C-0x000000018D64906C
	}

	public class InputEvent : EventBase<InputEvent> // TypeDefIndex: 71695
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _previousData_k__BackingField; // 0x80
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _newData_k__BackingField; // 0x88
	
		// Properties
		protected string previousData { [CompilerGenerated] set; } // 0x00000001870EAAE0-0x00000001870EAAF0
		protected string newData { [CompilerGenerated] set; } // 0x0000000188800C74-0x0000000188800C88
	
		// Constructors
		public InputEvent(); // 0x000000018D649294-0x000000018D6492F0
	
		// Methods
		protected override void Init(); // 0x000000018D649218-0x000000018D64925C
		private new void LocalInit(); // 0x000000018D64925C-0x000000018D649294
		public static InputEvent GetPooled(string previousData, string newData); // 0x000000018D649184-0x000000018D649218
	}

	internal class KeyboardEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71696
	{
		// Constructors
		public KeyboardEventDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D649434-0x000000018D649474
		public void DispatchEvent(EventBase evt, IPanel panel); // 0x000000018D649474-0x000000018D6495C0
	}

	public interface IKeyboardEvent // TypeDefIndex: 71697
	{
		// Properties
		EventModifiers modifiers { get; }
		char character { get; }
		KeyCode keyCode { get; }
	}

	public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent // TypeDefIndex: 71698
		where T : KeyboardEventBase<T>, new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventModifiers _modifiers_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private char _character_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private KeyCode _keyCode_k__BackingField;
	
		// Properties
		public EventModifiers modifiers { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public char character { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public KeyCode keyCode { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		public bool actionKey { get; }
	
		// Constructors
		protected KeyboardEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers);
		public static T GetPooled(UnityEngine.Event systemEvent);
	}

	public class KeyDownEvent : KeyboardEventBase<KeyDownEvent> // TypeDefIndex: 71699
	{
		// Constructors
		public KeyDownEvent(); // 0x000000018D6493BC-0x000000018D6493F8
	
		// Methods
		internal void GetEquivalentImguiEvent(UnityEngine.Event outImguiEvent); // 0x000000018D6492F0-0x000000018D6493BC
	}

	public class KeyUpEvent : KeyboardEventBase<KeyUpEvent> // TypeDefIndex: 71700
	{
		// Constructors
		public KeyUpEvent(); // 0x000000018D6493F8-0x000000018D649434
	}

	public class GeometryChangedEvent : EventBase<GeometryChangedEvent> // TypeDefIndex: 71701
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Rect _oldRect_k__BackingField; // 0x80
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Rect _newRect_k__BackingField; // 0x90
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _layoutPass_k__BackingField; // 0xA0
	
		// Properties
		public Rect oldRect { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E560-0x000000018723E570 0x0000000187233E20-0x0000000187233E30
		public Rect newRect { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724BCC0-0x000000018724BCD0 0x0000000187233B50-0x0000000187233B60
		internal int layoutPass { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235C10-0x0000000187235C20 0x0000000185B8E1A0-0x0000000185B8E410
	
		// Constructors
		public GeometryChangedEvent(); // 0x000000018D648F90-0x000000018D648FEC
	
		// Methods
		public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect); // 0x000000018D648ED0-0x000000018D648F4C
		protected override void Init(); // 0x000000018D648F4C-0x000000018D648F90
		private new void LocalInit(); // 0x00000001872633C0-0x00000001872633E0
	}

	internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71703
	{
		// Nested types
		[Flags]
		private enum EventBehavior // TypeDefIndex: 71702
		{
			None = 0,
			IsCapturable = 1,
			IsSentExclusivelyToCapturingElement = 2
		}
	
		// Constructors
		public MouseCaptureDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D64AE2C-0x000000018D64AE94
		public void DispatchEvent(EventBase evt, IPanel panel); // 0x000000018D64AE94-0x000000018D64B2C0
	}

	internal class MouseEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71704
	{
		// Constructors
		public MouseEventDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D64B62C-0x000000018D64B66C
		public void DispatchEvent(EventBase evt, IPanel iPanel); // 0x000000018D64B66C-0x000000018D64B71C
		private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel); // 0x000000018D64B8F0-0x000000018D64B92C
		private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel); // 0x000000018D64B8BC-0x000000018D64B8F0
		private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel); // 0x000000018D64B75C-0x000000018D64B8BC
		private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel); // 0x000000018D64B92C-0x000000018D64B9B0
		private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse); // 0x000000018D64B9B0-0x000000018D64BBA8
		private static bool IsDone(EventBase evt); // 0x000000018D64B71C-0x000000018D64B75C
	}

	public interface IMouseEvent // TypeDefIndex: 71705
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

	internal interface IMouseEventInternal // TypeDefIndex: 71706
	{
		// Properties
		bool triggeredByOS { get; set; }
		bool recomputeTopElementUnderMouse { get; set; }
		IPointerEvent sourcePointerEvent { get; set; }
	}

	public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal // TypeDefIndex: 71707
		where T : MouseEventBase<T>, new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventModifiers _modifiers_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _mousePosition_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _localMousePosition_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _mouseDelta_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _clickCount_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _button_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _pressedButtons_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IPointerEvent _UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField;
	
		// Properties
		public EventModifiers modifiers { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector2 mousePosition { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector2 localMousePosition { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public Vector2 mouseDelta { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int clickCount { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int button { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int pressedButtons { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		bool IMouseEventInternal.triggeredByOS { [CompilerGenerated] get; [CompilerGenerated] set; }
		bool IMouseEventInternal.recomputeTopElementUnderMouse { [CompilerGenerated] get; [CompilerGenerated] set; }
		IPointerEvent IMouseEventInternal.sourcePointerEvent { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override IEventHandler currentTarget { get; internal set; }
	
		// Constructors
		protected MouseEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		protected internal override void PreDispatch(IPanel panel);
		protected internal override void PostDispatch(IPanel panel);
		public static T GetPooled(UnityEngine.Event systemEvent);
		internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse);
		public static T GetPooled(IMouseEvent triggerEvent);
		protected static T GetPooled(IPointerEvent pointerEvent);
	}

	public class MouseDownEvent : MouseEventBase<MouseDownEvent> // TypeDefIndex: 71708
	{
		// Constructors
		public MouseDownEvent(); // 0x000000018D64B43C-0x000000018D64B480
	
		// Methods
		protected override void Init(); // 0x000000018D64B344-0x000000018D64B388
		private new void LocalInit(); // 0x0000000187263380-0x0000000187263390
		private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent); // 0x000000018D64B388-0x000000018D64B43C
		internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent); // 0x000000018D64B338-0x000000018D64B344
		internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent); // 0x000000018D64B338-0x000000018D64B344
	}

	public class MouseUpEvent : MouseEventBase<MouseUpEvent> // TypeDefIndex: 71709
	{
		// Constructors
		public MouseUpEvent(); // 0x000000018D64C260-0x000000018D64C2A4
	
		// Methods
		protected override void Init(); // 0x000000018D64C168-0x000000018D64C1AC
		private new void LocalInit(); // 0x0000000187263380-0x0000000187263390
		private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent); // 0x000000018D64C1AC-0x000000018D64C260
		internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent); // 0x000000018D64C15C-0x000000018D64C168
		internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent); // 0x000000018D64C15C-0x000000018D64C168
		internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent); // 0x000000018D64C15C-0x000000018D64C168
	}

	public class MouseMoveEvent : MouseEventBase<MouseMoveEvent> // TypeDefIndex: 71710
	{
		// Constructors
		public MouseMoveEvent(); // 0x000000018D64C0A0-0x000000018D64C0E4
	
		// Methods
		protected override void Init(); // 0x000000018D64C05C-0x000000018D64C0A0
		private new void LocalInit(); // 0x00000001872633E0-0x00000001872633F0
		internal static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent); // 0x000000018D64C020-0x000000018D64C05C
	}

	public class ContextClickEvent : MouseEventBase<ContextClickEvent> // TypeDefIndex: 71711
	{
		// Constructors
		public ContextClickEvent(); // 0x000000018D644D60-0x000000018D644D9C
	}

	public class WheelEvent : MouseEventBase<WheelEvent> // TypeDefIndex: 71712
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _delta_k__BackingField; // 0xB8
	
		// Properties
		public Vector3 delta { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234BA0-0x0000000187234BC0 0x0000000187234C10-0x0000000187234C30
	
		// Constructors
		public WheelEvent(); // 0x000000018D654388-0x000000018D6543E4
	
		// Methods
		public static new WheelEvent GetPooled(UnityEngine.Event systemEvent); // 0x000000018D654208-0x000000018D65429C
		internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent); // 0x000000018D65429C-0x000000018D654308
		protected override void Init(); // 0x000000018D654308-0x000000018D654364
		private new void LocalInit(); // 0x000000018D654364-0x000000018D654388
	}

	public class MouseEnterEvent : MouseEventBase<MouseEnterEvent> // TypeDefIndex: 71713
	{
		// Constructors
		public MouseEnterEvent(); // 0x000000018D64B4C4-0x000000018D64B508
	
		// Methods
		protected override void Init(); // 0x000000018D64B480-0x000000018D64B4C4
		private new void LocalInit(); // 0x00000001872633F0-0x0000000187263400
	}

	public class MouseLeaveEvent : MouseEventBase<MouseLeaveEvent> // TypeDefIndex: 71714
	{
		// Constructors
		public MouseLeaveEvent(); // 0x000000018D64BE04-0x000000018D64BE48
	
		// Methods
		protected override void Init(); // 0x000000018D64BDC0-0x000000018D64BE04
		private new void LocalInit(); // 0x00000001872633F0-0x0000000187263400
	}

	public class MouseEnterWindowEvent : MouseEventBase<MouseEnterWindowEvent> // TypeDefIndex: 71715
	{
		// Constructors
		public MouseEnterWindowEvent(); // 0x000000018D64B5E8-0x000000018D64B62C
	
		// Methods
		protected override void Init(); // 0x000000018D64B508-0x000000018D64B54C
		private new void LocalInit(); // 0x0000000187263400-0x0000000187263410
		protected internal override void PostDispatch(IPanel panel); // 0x000000018D64B54C-0x000000018D64B5E8
	}

	public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent> // TypeDefIndex: 71716
	{
		// Constructors
		public MouseLeaveWindowEvent(); // 0x000000018D64BFD4-0x000000018D64C020
	
		// Methods
		protected override void Init(); // 0x000000018D64BEDC-0x000000018D64BF28
		private new void LocalInit(); // 0x000000018D64BF28-0x000000018D64BF38
		public static new MouseLeaveWindowEvent GetPooled(UnityEngine.Event systemEvent); // 0x000000018D64BE48-0x000000018D64BEDC
		protected internal override void PostDispatch(IPanel panel); // 0x000000018D64BF38-0x000000018D64BFD4
	}

	public class MouseOverEvent : MouseEventBase<MouseOverEvent> // TypeDefIndex: 71717
	{
		// Constructors
		public MouseOverEvent(); // 0x000000018D64C120-0x000000018D64C15C
	}

	public class MouseOutEvent : MouseEventBase<MouseOutEvent> // TypeDefIndex: 71718
	{
		// Constructors
		public MouseOutEvent(); // 0x000000018D64C0E4-0x000000018D64C120
	}

	public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent> // TypeDefIndex: 71719
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DropdownMenu _menu_k__BackingField; // 0xB8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventBase _triggerEvent_k__BackingField; // 0xC0
		private ContextualMenuManager m_ContextualMenuManager; // 0xC8
	
		// Properties
		public DropdownMenu menu { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C80-0x0000000187232C90 0x0000000188D80C28-0x0000000188D80C3C
		public EventBase triggerEvent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
	
		// Constructors
		public ContextualMenuPopulateEvent(); // 0x000000018D645268-0x000000018D6452AC
	
		// Methods
		public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager); // 0x000000018D644D9C-0x000000018D6450DC
		protected override void Init(); // 0x000000018D6450DC-0x000000018D645120
		private new void LocalInit(); // 0x000000018D645120-0x000000018D645190
		protected internal override void PostDispatch(IPanel panel); // 0x000000018D645190-0x000000018D645268
	}

	internal static class MouseEventsHelper // TypeDefIndex: 71720
	{
		// Methods
		internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition)
			where TLeaveEvent : MouseEventBase<TLeaveEvent>, new()
			where TEnterEvent : MouseEventBase<TEnterEvent>, new();
		internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition); // 0x000000018D64BBA8-0x000000018D64BDC0
	}

	internal static class PointerEventsHelper // TypeDefIndex: 71721
	{
		// Methods
		internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId)
			where TLeaveEvent : PointerEventBase<TLeaveEvent>, new()
			where TEnterEvent : PointerEventBase<TEnterEvent>, new();
		internal static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId); // 0x000000018D64F5E0-0x000000018D64F800
	}

	internal class NavigationEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71722
	{
		// Constructors
		public NavigationEventDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D64CFE8-0x000000018D64D028
		public void DispatchEvent(EventBase evt, IPanel panel); // 0x000000018D64D028-0x000000018D64D0A0
	}

	public interface INavigationEvent // TypeDefIndex: 71723
	{
		// Properties
		bool shiftKey { get; }
		bool altKey { get; }
	}

	internal enum NavigationDeviceType // TypeDefIndex: 71724
	{
		Unknown = 0,
		Keyboard = 1,
		NonKeyboard = 2
	}

	public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent // TypeDefIndex: 71725
		where T : NavigationEventBase<T>, new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventModifiers _modifiers_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private NavigationDeviceType _deviceType_k__BackingField;
	
		// Properties
		public EventModifiers modifiers { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool shiftKey { get; }
		public bool altKey { get; }
		private NavigationDeviceType deviceType { [CompilerGenerated] set; }
	
		// Constructors
		protected NavigationEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		public static T GetPooled(EventModifiers modifiers = EventModifiers.None /* Metadata: 0x02622462 */);
		internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x02622463 */);
	}

	public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent> // TypeDefIndex: 71727
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Direction _direction_k__BackingField; // 0x88
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _move_k__BackingField; // 0x8C
	
		// Properties
		public Direction direction { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233450-0x0000000187233460 0x0000000185B8E410-0x0000000185B8E660
		private Vector2 move { [CompilerGenerated] set; } // 0x000000018724B030-0x000000018724B040
	
		// Nested types
		public enum Direction // TypeDefIndex: 71726
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
		public NavigationMoveEvent(); // 0x000000018D64D208-0x000000018D64D254
	
		// Methods
		internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f /* Metadata: 0x02622464 */); // 0x000000018D64D0A0-0x000000018D64D110
		public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x02622468 */); // 0x000000018D64D110-0x000000018D64D1AC
		protected override void Init(); // 0x000000018D64D1AC-0x000000018D64D1F8
		private new void LocalInit(); // 0x000000018D64D1F8-0x000000018D64D208
	}

	internal class NavigationTabEvent : NavigationEventBase<NavigationTabEvent> // TypeDefIndex: 71729
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Direction _direction_k__BackingField; // 0x88
	
		// Properties
		private Direction direction { [CompilerGenerated] set; } // 0x0000000185B8E410-0x0000000185B8E660
	
		// Nested types
		public enum Direction // TypeDefIndex: 71728
		{
			None = 0,
			Next = 1,
			Previous = 2
		}
	
		// Constructors
		public NavigationTabEvent(); // 0x000000018D64D34C-0x000000018D64D394
	
		// Methods
		internal static Direction DetermineMoveDirection(int moveValue); // 0x000000018D64D290-0x000000018D64D2A4
		public static NavigationTabEvent GetPooled(int moveValue); // 0x000000018D64D2A4-0x000000018D64D308
		protected override void Init(); // 0x000000018D64D308-0x000000018D64D34C
	}

	public class NavigationCancelEvent : NavigationEventBase<NavigationCancelEvent> // TypeDefIndex: 71730
	{
		// Constructors
		public NavigationCancelEvent(); // 0x000000018D64CFAC-0x000000018D64CFE8
	}

	public class NavigationSubmitEvent : NavigationEventBase<NavigationSubmitEvent> // TypeDefIndex: 71731
	{
		// Constructors
		public NavigationSubmitEvent(); // 0x000000018D64D254-0x000000018D64D290
	}

	public abstract class PanelChangedEventBase<T> : EventBase<T> // TypeDefIndex: 71732
		where T : PanelChangedEventBase<T>, new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IPanel _originPanel_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IPanel _destinationPanel_k__BackingField;
	
		// Properties
		public IPanel originPanel { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IPanel destinationPanel { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		protected PanelChangedEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		public static T GetPooled(IPanel originPanel, IPanel destinationPanel);
	}

	public class AttachToPanelEvent : PanelChangedEventBase<AttachToPanelEvent> // TypeDefIndex: 71733
	{
		// Constructors
		public AttachToPanelEvent(); // 0x000000018D644670-0x000000018D6446AC
	}

	public class DetachFromPanelEvent : PanelChangedEventBase<DetachFromPanelEvent> // TypeDefIndex: 71734
	{
		// Constructors
		public DetachFromPanelEvent(); // 0x000000018D6454E8-0x000000018D645524
	}

	internal class PointerCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71735
	{
		// Constructors
		public PointerCaptureDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D64E4D0-0x000000018D64E510
		public void DispatchEvent(EventBase evt, IPanel panel); // 0x000000018D64E510-0x000000018D64E7F4
	}

	internal static class PointerDeviceState // TypeDefIndex: 71738
	{
		// Fields
		private static PointerLocation[] s_PlayerPointerLocations; // 0x00
		private static int[] s_PressedButtons; // 0x08
		private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture; // 0x10
	
		// Nested types
		[Flags]
		internal enum LocationFlag // TypeDefIndex: 71736
		{
			None = 0,
			OutsidePanel = 1
		}
	
		private struct PointerLocation // TypeDefIndex: 71737
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Vector2 _Position_k__BackingField; // 0x00
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private IPanel _Panel_k__BackingField; // 0x08
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private LocationFlag _Flags_k__BackingField; // 0x10
	
			// Properties
			internal Vector2 Position { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001872358F0-0x0000000187235910 0x000000018561B5B0-0x000000018561B5C0
			internal IPanel Panel { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
			internal LocationFlag Flags { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			internal void SetLocation(Vector2 position, IPanel panel); // 0x000000018D64F888-0x000000018D64F90C
		}
	
		// Constructors
		static PointerDeviceState(); // 0x000000018D64EF20-0x000000018D64F04C
	
		// Methods
		internal static void RemovePanelData(IPanel panel); // 0x000000018D64ECA8-0x000000018D64EE10
		public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType); // 0x000000018D64EE10-0x000000018D64EE9C
		public static void PressButton(int pointerId, int buttonId); // 0x000000018D64EAF0-0x000000018D64EB98
		public static void ReleaseButton(int pointerId, int buttonId); // 0x000000018D64EC00-0x000000018D64ECA8
		public static void ReleaseAllButtons(int pointerId); // 0x000000018D64EB98-0x000000018D64EC00
		public static Vector2 GetPointerPosition(int pointerId, ContextType contextType); // 0x000000018D64E930-0x000000018D64E99C
		public static IPanel GetPanel(int pointerId, ContextType contextType); // 0x000000018D64E86C-0x000000018D64E8CC
		private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag); // 0x000000018C963A58-0x000000018C963A60
		public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag); // 0x000000018D64EA7C-0x000000018D64EAF0
		public static int GetPressedButtons(int pointerId); // 0x000000018D64E99C-0x000000018D64EA00
		internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId); // 0x000000018D64EA00-0x000000018D64EA7C
		internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel); // 0x000000018D64EE9C-0x000000018D64EF20
		internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId); // 0x000000018D64E8CC-0x000000018D64E930
	}

	internal class PointerEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 71739
	{
		// Constructors
		public PointerEventDispatchingStrategy(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool CanDispatchEvent(EventBase evt); // 0x000000018D64F2D8-0x000000018D64F318
		public virtual void DispatchEvent(EventBase evt, IPanel panel); // 0x000000018D64F318-0x000000018D64F354
		private static void SendEventToTarget(EventBase evt); // 0x000000018D64F354-0x000000018D64F37C
		private static void SetBestTargetForEvent(EventBase evt, IPanel panel); // 0x000000018D64F37C-0x000000018D64F4A0
		private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer); // 0x000000018D64F4A0-0x000000018D64F5E0
	}

	public static class PointerType // TypeDefIndex: 71740
	{
		// Fields
		public static readonly string mouse; // 0x00
		public static readonly string touch; // 0x08
		public static readonly string pen; // 0x10
		public static readonly string unknown; // 0x18
	
		// Constructors
		static PointerType(); // 0x000000018D64FF3C-0x000000018D65004C
	
		// Methods
		internal static string GetPointerType(int pointerId); // 0x000000018D64FE3C-0x000000018D64FEC8
		internal static bool IsDirectManipulationDevice(string pointerType); // 0x000000018D64FEC8-0x000000018D64FF3C
	}

	public static class PointerId // TypeDefIndex: 71741
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
		static PointerId(); // 0x0000000187029830-0x0000000187029960
	}

	public interface IPointerEvent // TypeDefIndex: 71742
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

	internal interface IPointerEventInternal // TypeDefIndex: 71743
	{
		// Properties
		bool triggeredByOS { get; set; }
		bool recomputeTopElementUnderPointer { get; set; }
	}

	public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal // TypeDefIndex: 71744
		where T : PointerEventBase<T>, new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _pointerId_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _pointerType_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isPrimary_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _button_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _pressedButtons_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _position_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _localPosition_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector3 _deltaPosition_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _deltaTime_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _clickCount_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _pressure_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _tangentialPressure_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _altitudeAngle_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _azimuthAngle_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _twist_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _radius_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _radiusVariance_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventModifiers _modifiers_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField;
	
		// Properties
		public int pointerId { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public string pointerType { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool isPrimary { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int button { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int pressedButtons { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector3 position { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector3 localPosition { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector3 deltaPosition { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float deltaTime { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int clickCount { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float pressure { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float tangentialPressure { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float altitudeAngle { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float azimuthAngle { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float twist { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector2 radius { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector2 radiusVariance { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public EventModifiers modifiers { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		public bool actionKey { get; }
		bool IPointerEventInternal.triggeredByOS { [CompilerGenerated] get; [CompilerGenerated] set; }
		bool IPointerEventInternal.recomputeTopElementUnderPointer { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override IEventHandler currentTarget { get; internal set; }
	
		// Constructors
		protected PointerEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		private static bool IsMouse(UnityEngine.Event systemEvent);
		public static T GetPooled(UnityEngine.Event systemEvent);
		public static T GetPooled(Touch touch, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x02622475 */);
		internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId);
		public static T GetPooled(IPointerEvent triggerEvent);
		protected internal override void PreDispatch(IPanel panel);
		protected internal override void PostDispatch(IPanel panel);
	}

	public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent> // TypeDefIndex: 71745
	{
		// Constructors
		public PointerDownEvent(); // 0x000000018D64F20C-0x000000018D64F250
	
		// Methods
		protected override void Init(); // 0x000000018D64F04C-0x000000018D64F090
		private new void LocalInit(); // 0x000000018D64F090-0x000000018D64F0B8
		protected internal override void PostDispatch(IPanel panel); // 0x000000018D64F0B8-0x000000018D64F20C
	}

	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent> // TypeDefIndex: 71746
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isHandledByDraggable_k__BackingField; // 0xF8
	
		// Properties
		internal bool isHandledByDraggable { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187263450-0x0000000187263460 0x0000000187263460-0x0000000187263470
	
		// Constructors
		public PointerMoveEvent(); // 0x000000018D64FCD0-0x000000018D64FD14
	
		// Methods
		protected override void Init(); // 0x000000018D64F90C-0x000000018D64F950
		private new void LocalInit(); // 0x000000018D64F950-0x000000018D64F980
		protected internal override void PostDispatch(IPanel panel); // 0x000000018D64F980-0x000000018D64FCD0
	}

	public sealed class PointerStationaryEvent : PointerEventBase<PointerStationaryEvent> // TypeDefIndex: 71747
	{
		// Constructors
		public PointerStationaryEvent(); // 0x000000018D64FDF8-0x000000018D64FE3C
	
		// Methods
		protected override void Init(); // 0x000000018D64FD8C-0x000000018D64FDD0
		private new void LocalInit(); // 0x000000018D64FDD0-0x000000018D64FDF8
	}

	public sealed class PointerUpEvent : PointerEventBase<PointerUpEvent> // TypeDefIndex: 71748
	{
		// Constructors
		public PointerUpEvent(); // 0x000000018D650258-0x000000018D65029C
	
		// Methods
		protected override void Init(); // 0x000000018D65004C-0x000000018D650090
		private new void LocalInit(); // 0x000000018D64F090-0x000000018D64F0B8
		protected internal override void PostDispatch(IPanel panel); // 0x000000018D650090-0x000000018D650258
	}

	public sealed class PointerCancelEvent : PointerEventBase<PointerCancelEvent> // TypeDefIndex: 71749
	{
		// Constructors
		public PointerCancelEvent(); // 0x000000018D64E48C-0x000000018D64E4D0
	
		// Methods
		protected override void Init(); // 0x000000018D64E260-0x000000018D64E2A4
		private new void LocalInit(); // 0x000000018D64E2A4-0x000000018D64E2CC
		protected internal override void PostDispatch(IPanel panel); // 0x000000018D64E2CC-0x000000018D64E48C
	}

	public sealed class ClickEvent : PointerEventBase<ClickEvent> // TypeDefIndex: 71750
	{
		// Constructors
		public ClickEvent(); // 0x000000018D644B4C-0x000000018D644B90
	
		// Methods
		protected override void Init(); // 0x000000018D644B08-0x000000018D644B4C
		private new void LocalInit(); // 0x0000000187263380-0x0000000187263390
		internal static ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount); // 0x000000018D644AA4-0x000000018D644B08
	}

	public sealed class PointerEnterEvent : PointerEventBase<PointerEnterEvent> // TypeDefIndex: 71751
	{
		// Constructors
		public PointerEnterEvent(); // 0x000000018D64F294-0x000000018D64F2D8
	
		// Methods
		protected override void Init(); // 0x000000018D64F250-0x000000018D64F294
		private new void LocalInit(); // 0x0000000187263440-0x0000000187263450
	}

	public sealed class PointerLeaveEvent : PointerEventBase<PointerLeaveEvent> // TypeDefIndex: 71752
	{
		// Constructors
		public PointerLeaveEvent(); // 0x000000018D64F844-0x000000018D64F888
	
		// Methods
		protected override void Init(); // 0x000000018D64F800-0x000000018D64F844
		private new void LocalInit(); // 0x0000000187263440-0x0000000187263450
	}

	public sealed class PointerOverEvent : PointerEventBase<PointerOverEvent> // TypeDefIndex: 71753
	{
		// Constructors
		public PointerOverEvent(); // 0x000000018D64FD50-0x000000018D64FD8C
	}

	public sealed class PointerOutEvent : PointerEventBase<PointerOutEvent> // TypeDefIndex: 71754
	{
		// Constructors
		public PointerOutEvent(); // 0x000000018D64FD14-0x000000018D64FD50
	}

	internal class PropagationPaths // TypeDefIndex: 71756
	{
		// Fields
		private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x00
		public readonly List<VisualElement> trickleDownPath; // 0x10
		public readonly List<VisualElement> targetElements; // 0x18
		public readonly List<VisualElement> bubbleUpPath; // 0x20
		private const int k_DefaultPropagationDepth = 16; // Metadata: 0x02622476
		private const int k_DefaultTargetCount = 4; // Metadata: 0x02622477
	
		// Nested types
		[Flags]
		public enum Type // TypeDefIndex: 71755
		{
			None = 0,
			TrickleDown = 1,
			BubbleUp = 2
		}
	
		// Constructors
		public PropagationPaths(); // 0x000000018D65064C-0x000000018D650734
		static PropagationPaths(); // 0x000000018D6505B8-0x000000018D65064C
	
		// Methods
		internal static PropagationPaths Copy(PropagationPaths paths); // 0x000000018D650424-0x000000018D650500
		public static PropagationPaths Build(VisualElement elem, EventBase evt, Type pathTypesRequested); // 0x000000018D65029C-0x000000018D650424
		public void Release(); // 0x000000018D650500-0x000000018D6505B8
	}

	public class CustomStyleResolvedEvent : EventBase<CustomStyleResolvedEvent> // TypeDefIndex: 71757
	{
		// Properties
		public ICustomStyle customStyle { get; } // 0x000000018D645300-0x000000018D64535C 
	
		// Constructors
		public CustomStyleResolvedEvent(); // 0x000000018D6452AC-0x000000018D645300
	}

	public class TooltipEvent : EventBase<TooltipEvent> // TypeDefIndex: 71758
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _tooltip_k__BackingField; // 0x80
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Rect _rect_k__BackingField; // 0x88
	
		// Properties
		public string tooltip { [CompilerGenerated] set; } // 0x00000001870EAAE0-0x00000001870EAAF0
		public Rect rect { [CompilerGenerated] set; } // 0x0000000187258F60-0x0000000187258F70
	
		// Constructors
		public TooltipEvent(); // 0x000000018D651170-0x000000018D6511CC
	
		// Methods
		protected override void Init(); // 0x000000018D6510C4-0x000000018D651108
		private new void LocalInit(); // 0x000000018D651108-0x000000018D651170
	}

	public struct StylePropertyNameCollection : IEnumerable<StylePropertyName> // TypeDefIndex: 71760
	{
		// Fields
		internal List<StylePropertyName> propertiesList; // 0x00
	
		// Nested types
		public struct Enumerator : IEnumerator<StylePropertyName> // TypeDefIndex: 71759
		{
			// Fields
			private List<StylePropertyName> m_Enumerator; // 0x00
	
			// Properties
			public StylePropertyName Current { get; } // 0x000000018D646994-0x000000018D6469D8 
			object IEnumerator.Current { get; } // 0x000000018D646928-0x000000018D646980 
	
			// Constructors
			internal Enumerator(List<StylePropertyName> enumerator); // 0x000000018D646980-0x000000018D646994
	
			// Methods
			public bool MoveNext(); // 0x000000018D6468EC-0x000000018D646928
			public void Reset(); // 0x0000000186805BA0-0x0000000186805BB0
			public void Dispose(); // 0x000000018D6468C4-0x000000018D6468EC
		}
	
		// Constructors
		internal StylePropertyNameCollection(List<StylePropertyName> list); // 0x00000001878380EC-0x00000001878380F4
	
		// Methods
		public Enumerator GetEnumerator(); // 0x000000018D650F70-0x000000018D651004
		IEnumerator<StylePropertyName> IEnumerable<StylePropertyName>.GetEnumerator(); // 0x000000018D651004-0x000000018D651064
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D651064-0x000000018D6510C4
	}

	public abstract class TransitionEventBase<T> : EventBase<T> // TypeDefIndex: 71761
		where T : TransitionEventBase<T>, new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly StylePropertyNameCollection _stylePropertyNames_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double _elapsedTime_k__BackingField;
	
		// Properties
		public StylePropertyNameCollection stylePropertyNames { [CompilerGenerated] get; }
		protected double elapsedTime { [CompilerGenerated] set; }
	
		// Constructors
		protected TransitionEventBase();
	
		// Methods
		protected override void Init();
		private new void LocalInit();
		public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime);
	}

	public sealed class TransitionRunEvent : TransitionEventBase<TransitionRunEvent> // TypeDefIndex: 71762
	{
		// Constructors
		public TransitionRunEvent(); // 0x000000018D651244-0x000000018D651280
	}

	public sealed class TransitionStartEvent : TransitionEventBase<TransitionStartEvent> // TypeDefIndex: 71763
	{
		// Constructors
		public TransitionStartEvent(); // 0x000000018D651280-0x000000018D6512BC
	}

	public sealed class TransitionEndEvent : TransitionEventBase<TransitionEndEvent> // TypeDefIndex: 71764
	{
		// Constructors
		public TransitionEndEvent(); // 0x000000018D651208-0x000000018D651244
	}

	public sealed class TransitionCancelEvent : TransitionEventBase<TransitionCancelEvent> // TypeDefIndex: 71765
	{
		// Constructors
		public TransitionCancelEvent(); // 0x000000018D6511CC-0x000000018D651208
	}

	public class IMGUIEvent : EventBase<IMGUIEvent> // TypeDefIndex: 71766
	{
		// Constructors
		public IMGUIEvent(); // 0x000000018D649128-0x000000018D649184
	
		// Methods
		public static IMGUIEvent GetPooled(UnityEngine.Event systemEvent); // 0x000000018D64906C-0x000000018D6490E4
		protected override void Init(); // 0x000000018D6490E4-0x000000018D649128
		private new void LocalInit(); // 0x00000001872633E0-0x00000001872633F0
	}

	internal struct EventDebuggerLogCall : IDisposable // TypeDefIndex: 71767
	{
		// Constructors
		public EventDebuggerLogCall(Delegate callback, EventBase evt); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal struct EventDebuggerLogIMGUICall : IDisposable // TypeDefIndex: 71768
	{
		// Constructors
		public EventDebuggerLogIMGUICall(EventBase evt); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal struct EventDebuggerLogExecuteDefaultAction : IDisposable // TypeDefIndex: 71769
	{
		// Constructors
		public EventDebuggerLogExecuteDefaultAction(EventBase evt); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class EventDebugger // TypeDefIndex: 71770
	{
		// Methods
		public static void LogPropagationPaths(EventBase evt, PropagationPaths paths); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Flags]
	internal enum DynamicAtlasFiltersInternal // TypeDefIndex: 71771
	{
		None = 0,
		Readability = 1,
		Size = 2,
		Format = 4,
		ColorSpace = 8,
		FilterMode = 16
	}

	[Serializable]
	public class DynamicAtlasSettings // TypeDefIndex: 71772
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int m_MinAtlasSize; // 0x10
		[HideInInspector]
		[SerializeField]
		private int m_MaxAtlasSize; // 0x14
		[HideInInspector]
		[SerializeField]
		private int m_MaxSubTextureSize; // 0x18
		[HideInInspector]
		[SerializeField]
		private DynamicAtlasFiltersInternal m_ActiveFilters; // 0x1C
		private DynamicAtlasCustomFilter m_CustomFilter; // 0x20
	
		// Properties
		public int minAtlasSize { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public int maxAtlasSize { get; set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public int maxSubTextureSize { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public DynamicAtlasFilters activeFilters { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public static DynamicAtlasFilters defaultFilters { get; } // 0x0000000187239DE0-0x0000000187239DF0 
		public DynamicAtlasCustomFilter customFilter { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public static DynamicAtlasSettings defaults { get; } // 0x000000018D645678-0x000000018D6456E8 
	
		// Constructors
		public DynamicAtlasSettings(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class NavigateFocusRing : IFocusRing // TypeDefIndex: 71775
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
		private FocusController focusController { get; } // 0x000000018D6082C8-0x000000018D6082EC 
	
		// Nested types
		public class ChangeDirection : FocusChangeDirection // TypeDefIndex: 71773
		{
			// Constructors
			public ChangeDirection(int i); // 0x000000018D644A54-0x000000018D644AA4
		}
	
		private struct FocusableHierarchyTraversal // TypeDefIndex: 71774
		{
			// Fields
			public VisualElement currentFocusable; // 0x00
			public Rect validRect; // 0x08
			public bool firstPass; // 0x18
			public ChangeDirection direction; // 0x20
	
			// Methods
			private bool ValidateHierarchyTraversal(VisualElement v); // 0x000000018D648E30-0x000000018D648ED0
			private bool ValidateElement(VisualElement v); // 0x000000018D648D90-0x000000018D648E30
			private int Order(VisualElement a, VisualElement b); // 0x000000018D6489B0-0x000000018D648A60
			private int StrictOrder(VisualElement a, VisualElement b); // 0x000000018D648A60-0x000000018D648ADC
			private int StrictOrder(Rect ra, Rect rb); // 0x000000018D648ADC-0x000000018D648C64
			private int TieBreaker(Rect ra, Rect rb); // 0x000000018D648C64-0x000000018D648D90
			public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null); // 0x000000018D6488BC-0x000000018D6489B0
		}
	
		// Constructors
		public NavigateFocusRing(VisualElement root); // 0x000000018D64CF24-0x000000018D64CFAC
		static NavigateFocusRing(); // 0x000000018D64CD14-0x000000018D64CF24
	
		// Methods
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e); // 0x000000018D64C2A4-0x000000018D64C5EC
		public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction); // 0x000000018D64CAE0-0x000000018D64CC8C
		private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction); // 0x000000018D64C5EC-0x000000018D64CAE0
		private static bool IsActive(VisualElement v); // 0x000000018D64CC8C-0x000000018D64CCCC
		private static bool IsNavigable(Focusable focusable); // 0x000000018D64CCCC-0x000000018D64CD14
	}

	public enum PanelScaleMode // TypeDefIndex: 71776
	{
		ConstantPixelSize = 0,
		ConstantPhysicalSize = 1,
		ScaleWithScreenSize = 2
	}

	public enum PanelScreenMatchMode // TypeDefIndex: 71777
	{
		MatchWidthOrHeight = 0,
		Shrink = 1,
		Expand = 2
	}

	public class PanelSettings : ScriptableObject // TypeDefIndex: 71779
	{
		// Fields
		private const int k_DefaultSortingOrder = 0; // Metadata: 0x02622487
		private const float k_DefaultScaleValue = 1f; // Metadata: 0x02622488
		internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset"; // Metadata: 0x0262248C
		[SerializeField]
		private ThemeStyleSheet themeUss; // 0x18
		[SerializeField]
		private RenderTexture m_TargetTexture; // 0x20
		[SerializeField]
		private PanelScaleMode m_ScaleMode; // 0x28
		[SerializeField]
		private float m_Scale; // 0x2C
		private const float DefaultDpi = 96f; // Metadata: 0x026224DC
		[SerializeField]
		private float m_ReferenceDpi; // 0x30
		[SerializeField]
		private float m_FallbackDpi; // 0x34
		[SerializeField]
		private Vector2Int m_ReferenceResolution; // 0x38
		[SerializeField]
		private PanelScreenMatchMode m_ScreenMatchMode; // 0x40
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Match; // 0x44
		[SerializeField]
		private float m_SortingOrder; // 0x48
		[SerializeField]
		private int m_TargetDisplay; // 0x4C
		[SerializeField]
		private bool m_ClearDepthStencil; // 0x50
		[SerializeField]
		private bool m_ClearColor; // 0x51
		[SerializeField]
		private UnityEngine.Color m_ColorClearValue; // 0x54
		private RuntimePanelAccess m_PanelAccess; // 0x68
		internal UIDocumentList m_AttachedUIDocumentsList; // 0x70
		[HideInInspector]
		[SerializeField]
		private DynamicAtlasSettings m_DynamicAtlasSettings; // 0x78
		[HideInInspector]
		[SerializeField]
		private Shader m_AtlasBlitShader; // 0x80
		[HideInInspector]
		[SerializeField]
		private Shader m_RuntimeShader; // 0x88
		[HideInInspector]
		[SerializeField]
		private Shader m_RuntimeWorldShader; // 0x90
		[SerializeField]
		public PanelTextSettings textSettings; // 0x98
		private Rect m_TargetRect; // 0xA0
		private float m_ResolvedScale; // 0xB0
		private StyleSheet m_OldThemeUss; // 0xB8
		internal int m_EmptyPanelCounter; // 0xC0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _ScreenDPI_k__BackingField; // 0xC4
		private Func<Vector2, Vector2> m_AssignedScreenToPanel; // 0xC8
	
		// Properties
		public ThemeStyleSheet themeStyleSheet { get; set; } // 0x0000000187244530-0x0000000187244540 0x000000018D64E238-0x000000018D64E260
		public RenderTexture targetTexture { get; set; } // 0x000000018225E800-0x000000018225E810 0x000000018D64E208-0x000000018D64E238
		public PanelScaleMode scaleMode { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public float scale { get; set; } // 0x0000000187233330-0x0000000187233340 0x0000000187233340-0x0000000187233350
		public float referenceDpi { get; set; } // 0x0000000187233870-0x0000000187233880 0x000000018D64E1AC-0x000000018D64E1D8
		public float fallbackDpi { get; set; } // 0x000000018723CEF0-0x000000018723CF00 0x000000018D64E180-0x000000018D64E1AC
		public Vector2Int referenceResolution { get; set; } // 0x0000000182986470-0x0000000182986480 0x00000001855D8A50-0x00000001855D8A60
		public PanelScreenMatchMode screenMatchMode { get; set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
		public float match { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		public float sortingOrder { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018D64E1D8-0x000000018D64E1E4
		public int targetDisplay { get; set; } // 0x0000000187233730-0x0000000187233740 0x000000018D64E1E4-0x000000018D64E208
		public bool clearDepthStencil { get; set; } // 0x000000018225DFF0-0x000000018225E000 0x000000018225E000-0x000000018225E010
		public float depthClearValue { get; } // 0x0000000187263420-0x0000000187263430 
		public bool clearColor { get; set; } // 0x000000018226ECC0-0x000000018226ECD0 0x000000018226ECD0-0x000000018226ECE0
		public UnityEngine.Color colorClearValue { get; set; } // 0x0000000187263410-0x0000000187263420 0x0000000187263430-0x0000000187263440
		internal BaseRuntimePanel panel { get; } // 0x000000018D64E130-0x000000018D64E150 
		internal VisualElement visualTree { get; } // 0x000000018D64E150-0x000000018D64E180 
		public DynamicAtlasSettings dynamicAtlasSettings { get; set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
		private float ScreenDPI { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184F560A0-0x0000000184F560B0 0x000000018724C660-0x000000018724C670
	
		// Nested types
		private class RuntimePanelAccess // TypeDefIndex: 71778
		{
			// Fields
			private readonly PanelSettings m_Settings; // 0x10
			private BaseRuntimePanel m_RuntimePanel; // 0x18
	
			// Properties
			internal bool isInitialized { get; } // 0x0000000185B19DF0-0x0000000185B19E00 
			internal BaseRuntimePanel panel { get; } // 0x000000018D650B0C-0x000000018D650C8C 
	
			// Constructors
			internal RuntimePanelAccess(PanelSettings settings); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			internal void DisposePanel(); // 0x000000018D65099C-0x000000018D6509D0
			internal void SetTargetTexture(); // 0x000000018D650AD0-0x000000018D650B0C
			internal void SetSortingPriority(); // 0x000000018D650A70-0x000000018D650AA4
			internal void SetTargetDisplay(); // 0x000000018D650AA4-0x000000018D650AD0
			private BaseRuntimePanel CreateRelatedRuntimePanel(); // 0x000000018D6508E8-0x000000018D65099C
			private void DisposeRelatedPanel(); // 0x000000018D6509D0-0x000000018D650A20
			internal void MarkPotentiallyEmpty(); // 0x000000018D650A20-0x000000018D650A70
		}
	
		// Constructors
		private PanelSettings(); // 0x000000018D64E044-0x000000018D64E130
	
		// Methods
		internal void ApplySortingOrder(); // 0x000000018D64D810-0x000000018D64D830
		private void Reset(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnEnable(); // 0x000000018D64DE18-0x000000018D64DEEC
		private void OnDisable(); // 0x000000018D64DAC4-0x000000018D64DAE4
		internal void DisposePanel(); // 0x000000018D64DAC4-0x000000018D64DAE4
		internal void UpdateScreenDPI(); // 0x000000018D64E024-0x000000018D64E044
		private void ApplyThemeStyleSheet(VisualElement root = null); // 0x000000018D64D830-0x000000018D64D990
		private void InitializeShaders(); // 0x000000018D64DCB0-0x000000018D64DE18
		internal void ApplyPanelSettings(); // 0x000000018D64D394-0x000000018D64D810
		public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction); // 0x000000018D64DFDC-0x000000018D64E024
		internal float ResolveScale(Rect targetRect, float screenDpi); // 0x000000018D64DEEC-0x000000018D64DFDC
		internal Rect GetDisplayRect(); // 0x000000018D64DAE4-0x000000018D64DCB0
		internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument); // 0x000000018D64D990-0x000000018D64DA48
		internal void DetachUIDocument(UIDocument uiDocument); // 0x000000018D64DA48-0x000000018D64DAC4
	}

	internal static class RuntimeEventDispatcher // TypeDefIndex: 71780
	{
		// Methods
		public static EventDispatcher Create(); // 0x000000018D650734-0x000000018D6508E8
	}

	internal class RuntimePanel : BaseRuntimePanel // TypeDefIndex: 71781
	{
		// Fields
		internal static readonly EventDispatcher s_EventDispatcher; // 0x00
		private readonly PanelSettings m_PanelSettings; // 0x1D8
	
		// Properties
		public PanelSettings panelSettings { get; } // 0x000000018723BCA0-0x000000018723BCB0 
	
		// Constructors
		private RuntimePanel(ScriptableObject ownerObject); // 0x000000018D650DB8-0x000000018D650F70
		static RuntimePanel(); // 0x000000018D650D68-0x000000018D650DB8
	
		// Methods
		public static RuntimePanel Create(ScriptableObject ownerObject); // 0x000000018D650C8C-0x000000018D650CEC
		public override void Update(); // 0x000000018D650CEC-0x000000018D650D68
	}

	internal class UIDocumentList // TypeDefIndex: 71782
	{
		// Fields
		internal List<UIDocument> m_AttachedUIDocuments; // 0x10
	
		// Constructors
		public UIDocumentList(); // 0x000000018D6528AC-0x000000018D652924
	
		// Methods
		internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument); // 0x000000018D652840-0x000000018D6528AC
		internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex = 0 /* Metadata: 0x026224E0 */); // 0x000000018D652528-0x000000018D652840
	}

	[AddComponentMenu("UI Toolkit/UI Document")]
	[DefaultExecutionOrder(-100)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public sealed class UIDocument : MonoBehaviour // TypeDefIndex: 71783
	{
		// Fields
		internal const string k_RootStyleClassName = "unity-ui-document__root"; // Metadata: 0x026224E1
		internal const string k_VisualElementNameSuffix = "-container"; // Metadata: 0x026224F9
		private const int k_DefaultSortingOrder = 0; // Metadata: 0x02622504
		private static int s_CurrentUIDocumentCounter; // 0x00
		internal readonly int m_UIDocumentCreationIndex; // 0x18
		[SerializeField]
		private PanelSettings m_PanelSettings; // 0x20
		private PanelSettings m_PreviousPanelSettings; // 0x28
		[SerializeField]
		private UIDocument m_ParentUI; // 0x30
		private UIDocumentList m_ChildrenContent; // 0x38
		private List<UIDocument> m_ChildrenContentCopy; // 0x40
		[SerializeField]
		private VisualTreeAsset sourceAsset; // 0x48
		private VisualElement m_RootVisualElement; // 0x50
		private int m_FirstChildInsertIndex; // 0x58
		[SerializeField]
		private float m_SortingOrder; // 0x5C
	
		// Properties
		public PanelSettings panelSettings { get; set; } // 0x000000018725FED0-0x000000018725FEE0 0x000000018D653630-0x000000018D653934
		public UIDocument parentUI { get; private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public VisualTreeAsset visualTreeAsset { get; set; } // 0x0000000187261F50-0x0000000187261F60 0x000000018D653950-0x000000018D653974
		public VisualElement rootVisualElement { get; } // 0x0000000187261FD0-0x0000000187261FE0 
		internal int firstChildInserIndex { get; } // 0x00000001872331A0-0x00000001872331B0 
		public float sortingOrder { get; set; } // 0x00000001826DD0B0-0x00000001826DD0C0 0x000000018D653934-0x000000018D653950
	
		// Constructors
		private UIDocument(); // 0x000000018D6535A4-0x000000018D653630
	
		// Methods
		internal void ApplySortingOrder(); // 0x000000018D652A84-0x000000018D652A8C
		private void Awake(); // 0x000000018D652A8C-0x000000018D652A94
		private void OnEnable(); // 0x000000018D652B70-0x000000018D652C20
		private void SetupFromHierarchy(); // 0x000000018D6534A0-0x000000018D653528
		private UIDocument FindUIDocumentParent(); // 0x000000018D652A94-0x000000018D652B3C
		internal void Reset(); // 0x000000018D6533B0-0x000000018D6534A0
		private void AddChildAndInsertContentToVisualTree(UIDocument child); // 0x000000018D652924-0x000000018D6529D0
		private void RemoveChild(UIDocument child); // 0x000000018D6532F4-0x000000018D653308
		private void RecreateUI(); // 0x000000018D652ECC-0x000000018D6532F4
		private void SetupRootClassList(); // 0x000000018D653528-0x000000018D6535A4
		private void AddRootVisualElementToTree(); // 0x000000018D6529D0-0x000000018D652A84
		private void RemoveFromHierarchy(); // 0x000000018D653308-0x000000018D6533B0
		private void OnDisable(); // 0x000000018D652B3C-0x000000018D652B70
		private void OnTransformChildrenChanged(); // 0x000000018D652C20-0x000000018D652E24
		private void OnTransformParentChanged(); // 0x000000018D652E24-0x000000018D652E2C
		internal void ReactToHierarchyChanged(); // 0x000000018D652E2C-0x000000018D652ECC
	}

	internal class UIRAtlasAllocator : IDisposable // TypeDefIndex: 71786
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _maxAtlasSize_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _maxImageWidth_k__BackingField; // 0x14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _maxImageHeight_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _virtualWidth_k__BackingField; // 0x1C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _virtualHeight_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _physicalWidth_k__BackingField; // 0x24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _physicalHeight_k__BackingField; // 0x28
		private AreaNode m_FirstUnpartitionedArea; // 0x30
		private Row[] m_OpenRows; // 0x38
		private int m_1SidePadding; // 0x40
		private int m_2SidePadding; // 0x44
		private static ProfilerMarker s_MarkerTryAllocate; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x48
	
		// Properties
		public int maxAtlasSize { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public int maxImageWidth { [CompilerGenerated] get; } // 0x0000000182971EE0-0x0000000182971EF0 
		public int maxImageHeight { [CompilerGenerated] get; } // 0x00000001844AF510-0x00000001844AF520 
		public int virtualWidth { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public int virtualHeight { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public int physicalWidth { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public int physicalHeight { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
	
		// Nested types
		private class Row // TypeDefIndex: 71784
		{
			// Fields
			private static ObjectPool<Row> s_Pool; // 0x00
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int _offsetX_k__BackingField; // 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int _offsetY_k__BackingField; // 0x14
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int _width_k__BackingField; // 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int _height_k__BackingField; // 0x1C
			public int Cursor; // 0x20
	
			// Properties
			public int offsetX { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
			public int offsetY { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
			public int width { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
			private int height { [CompilerGenerated] set; } // 0x0000000187233010-0x0000000187233020
	
			// Constructors
			public Row(); // 0x0000000186805BA0-0x0000000186805BB0
			static Row(); // 0x000000018D66CC88-0x000000018D66CD1C
	
			// Methods
			public static Row Acquire(int offsetX, int offsetY, int width, int height); // 0x000000018D66CB60-0x000000018D66CC08
			public void Release(); // 0x000000018D66CC08-0x000000018D66CC88
		}
	
		private class AreaNode // TypeDefIndex: 71785
		{
			// Fields
			private static ObjectPool<AreaNode> s_Pool; // 0x00
			public RectInt rect; // 0x10
			public AreaNode previous; // 0x20
			public AreaNode next; // 0x28
	
			// Constructors
			public AreaNode(); // 0x0000000186805BA0-0x0000000186805BB0
			static AreaNode(); // 0x000000018D663B9C-0x000000018D663C30
	
			// Methods
			public static AreaNode Acquire(RectInt rect); // 0x000000018D663968-0x000000018D663A08
			public void Release(); // 0x000000018D663ACC-0x000000018D663B3C
			public void RemoveFromChain(); // 0x000000018D663B3C-0x000000018D663B9C
			public void AddAfter(AreaNode previous); // 0x000000018D663A08-0x000000018D663ACC
		}
	
		// Constructors
		public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1 /* Metadata: 0x02622505 */); // 0x000000018D654048-0x000000018D6541CC
		static UIRAtlasAllocator(); // 0x000000018D653FE4-0x000000018D654048
	
		// Methods
		public void Dispose(); // 0x000000018D653AF4-0x000000018D653B44
		protected virtual void Dispose(bool disposing); // 0x000000018D653A50-0x000000018D653AF4
		private static int GetLog2OfNextPower(int n); // 0x000000018D653B44-0x000000018D653B6C
		public bool TryAllocate(int width, int height, out RectInt location); // 0x000000018D653B6C-0x000000018D653E58
		private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth); // 0x000000018D653E58-0x000000018D653FE4
		private void BuildAreas(); // 0x000000018D653974-0x000000018D653A50
	}

	internal class DynamicAtlasPage : IDisposable // TypeDefIndex: 71787
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextureId _textureId_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RenderTexture _atlas_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly RenderTextureFormat _format_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly UnityEngine.FilterMode _filterMode_k__BackingField; // 0x24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector2Int _minSize_k__BackingField; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector2Int _maxSize_k__BackingField; // 0x30
		private readonly int m_1Padding; // 0x38
		private readonly int m_2Padding; // 0x3C
		private Allocator2D m_Allocator; // 0x40
		private TextureBlitter m_Blitter; // 0x48
		private Vector2Int m_CurrentSize; // 0x50
		private static int s_TextureCounter; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x58
	
		// Properties
		public TextureId textureId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		public RenderTexture atlas { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public RenderTextureFormat format { [CompilerGenerated] get; } // 0x000000018226A850-0x000000018226A860 
		public UnityEngine.FilterMode filterMode { [CompilerGenerated] get; } // 0x0000000182A819B0-0x0000000182A819C0 
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018226EBF0-0x000000018226EC00
	
		// Constructors
		public DynamicAtlasPage(RenderTextureFormat format, UnityEngine.FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize); // 0x000000018D666D00-0x000000018D666E30
	
		// Methods
		public void Dispose(); // 0x000000018D6665B0-0x000000018D666600
		protected virtual void Dispose(bool disposing); // 0x000000018D666444-0x000000018D6665B0
		public bool TryAdd(Texture2D image, out Allocator2D.Alloc2D alloc, out RectInt rect); // 0x000000018D6666B4-0x000000018D666884
		public void Update(Texture2D image, RectInt rect); // 0x000000018D666BAC-0x000000018D666D00
		public void Remove(Allocator2D.Alloc2D alloc); // 0x000000018D666600-0x000000018D6666B4
		public void Commit(); // 0x000000018D6662E4-0x000000018D666324
		private void UpdateAtlasTexture(); // 0x000000018D666884-0x000000018D666BAC
		private RenderTexture CreateAtlasTexture(); // 0x000000018D666324-0x000000018D666444
	}

	internal class UIRLayoutUpdater : BaseVisualTreeUpdater // TypeDefIndex: 71788
	{
		// Fields
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
		private List<KeyValuePair<Rect, VisualElement>> changeEventsList; // 0x20
	
		// Properties
		public override ProfilerMarker profilerMarker { get; } // 0x000000018D671588-0x000000018D6715D8 
	
		// Constructors
		public UIRLayoutUpdater(); // 0x000000018D671510-0x000000018D671588
		static UIRLayoutUpdater(); // 0x000000018D671478-0x000000018D671510
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D670D70-0x000000018D670DA8
		public override void Update(); // 0x000000018D6712AC-0x000000018D671478
		private void UpdateSubTree(VisualElement ve, bool isDisplayed, List<KeyValuePair<Rect, VisualElement>> changeEvents); // 0x000000018D670DA8-0x000000018D6712AC
		private void DispatchChangeEvents(List<KeyValuePair<Rect, VisualElement>> changeEvents, int currentLayoutPass); // 0x000000018D670AEC-0x000000018D670D70
	}

	public struct Vertex // TypeDefIndex: 71789
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

	public class MeshWriteData // TypeDefIndex: 71790
	{
		// Fields
		internal NativeSlice<UnityEngine.UIElements.Vertex> m_Vertices; // 0x10
		internal NativeSlice<ushort> m_Indices; // 0x20
		internal Rect m_UVRegion; // 0x30
		internal int currentIndex; // 0x40
		internal int currentVertex; // 0x44
	
		// Properties
		public int vertexCount { get; } // 0x000000018D66AE6C-0x000000018D66AEA0 
		public int indexCount { get; } // 0x000000018D66AE38-0x000000018D66AE6C 
		public Rect uvRegion { get; } // 0x0000000187261A00-0x0000000187261A10 
	
		// Constructors
		internal MeshWriteData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void SetNextVertex(UnityEngine.UIElements.Vertex vertex); // 0x000000018D66ADB4-0x000000018D66AE38
		public void SetNextIndex(ushort index); // 0x000000018D66AD60-0x000000018D66ADB4
		public void SetAllVertices(UnityEngine.UIElements.Vertex[] vertices); // 0x000000018D66ACA8-0x000000018D66AD60
		public void SetAllIndices(ushort[] indices); // 0x000000018D66ABF0-0x000000018D66ACA8
		internal void Reset(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices); // 0x00000001872634B0-0x00000001872634E0
		internal void Reset(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices, Rect uvRegion); // 0x00000001872634E0-0x0000000187263500
	}

	internal struct ColorPage // TypeDefIndex: 71791
	{
		// Fields
		public bool isValid; // 0x00
		public Color32 pageAndID; // 0x04
	
		// Methods
		public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc); // 0x000000018D6644DC-0x000000018D664580
	}

	internal static class MeshGenerationContextUtils // TypeDefIndex: 71795
	{
		// Nested types
		public struct BorderParams // TypeDefIndex: 71792
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
	
		public struct RectangleParams // TypeDefIndex: 71793
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
			private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, UnityEngine.ScaleMode scaleMode, out Rect rectOut, out Rect uvOut); // 0x000000018D66B4A8-0x000000018D66B698
			private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, UnityEngine.ScaleMode scaleMode, out Rect rectOut, out Rect uvOut); // 0x000000018D66AEA0-0x000000018D66B4A8
			private static Rect RectIntersection(Rect a, Rect b); // 0x000000018D66C624-0x000000018D66C734
			private static Rect ComputeGeomRect(Sprite sprite); // 0x000000018D66B804-0x000000018D66B948
			private static Rect ComputeUVRect(Sprite sprite); // 0x000000018D66B948-0x000000018D66BA8C
			private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation); // 0x000000018D66B698-0x000000018D66B804
			public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, UnityEngine.ScaleMode scaleMode, ContextType panelContext); // 0x000000018D66C2C8-0x000000018D66C498
			public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, UnityEngine.ScaleMode scaleMode, ContextType panelContext, bool hasRadius, ref Vector4 slices); // 0x000000018D66BAEC-0x000000018D66C2C8
			public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, UnityEngine.ScaleMode scaleMode, ContextType panelContext); // 0x000000018D66C498-0x000000018D66C624
			internal bool HasRadius(float epsilon); // 0x000000018D66BA8C-0x000000018D66BAEC
		}
	
		public struct TextParams // TypeDefIndex: 71794
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
			public override int GetHashCode(); // 0x000000018D66EB4C-0x000000018D66ED20
			internal static TextParams MakeStyleBased(VisualElement ve, string text); // 0x000000018D66F118-0x000000018D66F468
			internal static TextNativeSettings GetTextNativeSettings(TextParams textParams, float scaling); // 0x000000018D66ED20-0x000000018D66F118
		}
	
		// Methods
		private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length); // 0x000000018D66A840-0x000000018D66A8A0
		public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight); // 0x000000018D66A8A0-0x000000018D66A9FC
		public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams); // 0x000000018D66A738-0x000000018D66A840
	
		// Extension methods
		public static void Rectangle(this MeshGenerationContext mgc, RectangleParams rectParams); // 0x000000018D66A9FC-0x000000018D66AAB4
		public static void Text(this MeshGenerationContext mgc, TextParams textParams, ITextHandle handle, float pixelsPerPoint); // 0x000000018D66AAB4-0x000000018D66ABF0
	}

	public class MeshGenerationContext // TypeDefIndex: 71797
	{
		// Fields
		internal IStylePainter painter; // 0x10
	
		// Nested types
		[Flags]
		internal enum MeshFlags // TypeDefIndex: 71796
		{
			None = 0,
			UVisDisplacement = 1,
			SkipDynamicAtlas = 2
		}
	
		// Constructors
		internal MeshGenerationContext(IStylePainter painter); // 0x0000000184FD2410-0x0000000184FD2420
	}

	internal class UIRRepaintUpdater : BaseVisualTreeUpdater // TypeDefIndex: 71798
	{
		// Fields
		private BaseVisualElementPanel attachedPanel; // 0x20
		internal RenderChain renderChain; // 0x28
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _drawStats_k__BackingField; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _breakBatches_k__BackingField; // 0x31
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x32
	
		// Properties
		public override ProfilerMarker profilerMarker { get; } // 0x000000018D672408-0x000000018D672458 
		public bool drawStats { [CompilerGenerated] get; } // 0x00000001822434B0-0x00000001822434C0 
		public bool breakBatches { [CompilerGenerated] get; } // 0x0000000182260CA0-0x0000000182260CB0 
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE20-0x000000018226EE30 0x000000018226EE30-0x000000018226EE40
	
		// Constructors
		public UIRRepaintUpdater(); // 0x000000018D67238C-0x000000018D672408
		static UIRRepaintUpdater(); // 0x000000018D672288-0x000000018D67238C
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType); // 0x000000018D671F78-0x000000018D6720BC
		public override void Update(); // 0x000000018D67214C-0x000000018D672288
		protected virtual RenderChain CreateRenderChain(); // 0x000000018D6717B0-0x000000018D671814
		private static void OnGraphicsResourcesRecreate(bool recreate); // 0x000000018D671AF0-0x000000018D671C48
		private void OnPanelChanged(BaseVisualElementPanel obj); // 0x000000018D671C50-0x000000018D671C70
		private void AttachToPanel(); // 0x000000018D6715D8-0x000000018D6717B0
		private void DetachFromPanel(); // 0x000000018D671870-0x000000018D671A2C
		private void InitRenderChain(); // 0x000000018D671A50-0x000000018D671AF0
		internal void DestroyRenderChain(); // 0x000000018D671814-0x000000018D671870
		private void OnPanelAtlasChanged(); // 0x000000018D671C48-0x000000018D671C50
		private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType); // 0x000000018D671C70-0x000000018D671CD0
		private void OnPanelStandardShaderChanged(); // 0x000000018D671CD0-0x000000018D671E24
		private void OnPanelStandardWorldSpaceShaderChanged(); // 0x000000018D671E24-0x000000018D671F78
		private void ResetAllElementsDataRecursive(VisualElement ve); // 0x000000018D6720BC-0x000000018D67214C
		protected override void Dispose(bool disposing); // 0x000000018D671A2C-0x000000018D671A50
	}

	internal struct TextureId // TypeDefIndex: 71799
	{
		// Fields
		private readonly int m_Index; // 0x00
		public static readonly TextureId invalid; // 0x00
	
		// Properties
		public int index { get; } // 0x0000000187263750-0x0000000187263760 
	
		// Constructors
		public TextureId(int index); // 0x0000000187263740-0x0000000187263750
		static TextureId(); // 0x000000018D66F524-0x000000018D66F560
	
		// Methods
		public float ConvertToGpu(); // 0x000000018D66F468-0x000000018D66F4B4
		public override bool Equals(object obj); // 0x000000018D66F4B4-0x000000018D66F524
		public override int GetHashCode(); // 0x000000018725FD00-0x000000018725FD10
		public static bool operator ==(TextureId left, TextureId right); // 0x0000000189CCDE30-0x0000000189CCDE38
		public static bool operator !=(TextureId left, TextureId right); // 0x000000018D66F560-0x000000018D66F5A8
	}

	internal class TextureRegistry // TypeDefIndex: 71801
	{
		// Fields
		private List<TextureInfo> m_Textures; // 0x10
		private Dictionary<Texture, TextureId> m_TextureToId; // 0x18
		private Stack<TextureId> m_FreeIds; // 0x20
		internal const int maxTextures = 2048; // Metadata: 0x02622509
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly TextureRegistry _instance_k__BackingField; // 0x00
	
		// Properties
		public static TextureRegistry instance { [CompilerGenerated] get; } // 0x000000018D670164-0x000000018D6701B4 
	
		// Nested types
		private struct TextureInfo // TypeDefIndex: 71800
		{
			// Fields
			public Texture texture; // 0x00
			public bool dynamic; // 0x08
			public int refCount; // 0x0C
		}
	
		// Constructors
		public TextureRegistry(); // 0x000000018D670050-0x000000018D670164
		static TextureRegistry(); // 0x000000018D66FFE0-0x000000018D670050
	
		// Methods
		public Texture GetTexture(TextureId id); // 0x000000018D66F9E8-0x000000018D66FB68
		public TextureId AllocAndAcquireDynamic(); // 0x000000018D66F71C-0x000000018D66F72C
		public void UpdateDynamic(TextureId id, Texture texture); // 0x000000018D66FDBC-0x000000018D66FFE0
		private TextureId AllocAndAcquire(Texture texture, bool dynamic); // 0x000000018D66F72C-0x000000018D66F9E8
		public TextureId Acquire(Texture tex); // 0x000000018D66F5A8-0x000000018D66F71C
		public void Release(TextureId id); // 0x000000018D66FB68-0x000000018D66FDBC
	}

	internal static class UIRUtility // TypeDefIndex: 71802
	{
		// Fields
		public static readonly string k_DefaultShaderName; // 0x00
		public static readonly string k_DefaultWorldSpaceShaderName; // 0x08
	
		// Constructors
		static UIRUtility(); // 0x000000018D672678-0x000000018D672924
	
		// Methods
		public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef); // 0x000000018D67260C-0x000000018D672678
		public static bool IsRoundRect(VisualElement ve); // 0x000000018D672530-0x000000018D672594
		public static bool IsVectorImageBackground(VisualElement ve); // 0x000000018D672594-0x000000018D67260C
		public static bool IsElementSelfHidden(VisualElement ve); // 0x000000018D672510-0x000000018D672530
		public static void Destroy(UnityEngine.Object obj); // 0x000000018D672458-0x000000018D6724D8
		public static int GetPrevPow2(int n); // 0x000000018D6724FC-0x000000018D672510
		public static int GetNextPow2(int n); // 0x000000018D6724EC-0x000000018D6724FC
		public static int GetNextPow2Exp(int n); // 0x000000018D6724D8-0x000000018D6724EC
	}

	public enum AngleUnit // TypeDefIndex: 71803
	{
		Degree = 0,
		Gradian = 1,
		Radian = 2,
		Turn = 3
	}

	public struct Angle : IEquatable<Angle> // TypeDefIndex: 71805
	{
		// Fields
		private float m_Value; // 0x00
		private Unit m_Unit; // 0x04
	
		// Properties
		public float value { get; } // 0x00000001872342D0-0x00000001872342E0 
	
		// Nested types
		private enum Unit // TypeDefIndex: 71804
		{
			Degree = 0,
			Gradian = 1,
			Radian = 2,
			Turn = 3,
			None = 4
		}
	
		// Constructors
		public Angle(float value, AngleUnit unit); // 0x00000001872342B0-0x00000001872342C0
		private Angle(float value, Unit unit); // 0x00000001872342B0-0x00000001872342C0
	
		// Methods
		internal static Angle None(); // 0x0000000187263470-0x0000000187263490
		public float ToDegrees(); // 0x000000018D663778-0x000000018D6637D0
		public static implicit operator Angle(float value); // 0x0000000187263490-0x00000001872634B0
		public static bool operator ==(Angle lhs, Angle rhs); // 0x000000018D66393C-0x000000018D663968
		public bool Equals(Angle other); // 0x000000018D663744-0x000000018D663758
		public override bool Equals(object obj); // 0x000000018D6636D4-0x000000018D663744
		public override int GetHashCode(); // 0x000000018D663758-0x000000018D663778
		public override string ToString(); // 0x000000018D6637D0-0x000000018D66393C
	}

	public struct Background : IEquatable<Background> // TypeDefIndex: 71806
	{
		// Fields
		private Texture2D m_Texture; // 0x00
		private Sprite m_Sprite; // 0x08
		private RenderTexture m_RenderTexture; // 0x10
		private VectorImage m_VectorImage; // 0x18
	
		// Properties
		public Texture2D texture { get; set; } // 0x000000018514D010-0x000000018514D0E0 0x000000018D664398-0x000000018D664438
		public Sprite sprite { get; set; } // 0x000000018725FF40-0x000000018725FF50 0x000000018D6642F4-0x000000018D664398
		public RenderTexture renderTexture { get; set; } // 0x0000000187249840-0x0000000187249850 0x000000018D664250-0x000000018D6642F4
		public VectorImage vectorImage { get; set; } // 0x0000000187244530-0x0000000187244540 0x000000018D664438-0x000000018D6644DC
	
		// Methods
		public static Background FromTexture2D(Texture2D t); // 0x000000018D663F34-0x000000018D663F78
		public static Background FromRenderTexture(RenderTexture rt); // 0x000000018D663EAC-0x000000018D663EF0
		public static Background FromSprite(Sprite s); // 0x000000018D663EF0-0x000000018D663F34
		public static Background FromVectorImage(VectorImage vi); // 0x000000018D663F78-0x000000018D663FBC
		internal static Background FromObject(object obj); // 0x000000018D663D04-0x000000018D663EAC
		public static bool operator ==(Background lhs, Background rhs); // 0x000000018D664154-0x000000018D664214
		public static bool operator !=(Background lhs, Background rhs); // 0x000000018D664214-0x000000018D664250
		public bool Equals(Background other); // 0x000000018D663CC4-0x000000018D663D04
		public override bool Equals(object obj); // 0x000000018D663C30-0x000000018D663CC4
		public override int GetHashCode(); // 0x000000018D663FBC-0x000000018D664058
		public override string ToString(); // 0x000000018D664058-0x000000018D664154
	}

	internal struct ComputedStyle // TypeDefIndex: 71807
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
		public int customPropertiesCount { get; } // 0x000000018D6624A8-0x000000018D6624F0 
		public bool hasTransition { get; } // 0x000000018D6626B0-0x000000018D6626C4 
		public Align alignContent { get; } // 0x000000018D661EF8-0x000000018D661F38 
		public Align alignItems { get; } // 0x000000018D661F38-0x000000018D661F78 
		public Align alignSelf { get; } // 0x000000018D661F78-0x000000018D661FB8 
		public UnityEngine.Color backgroundColor { get; } // 0x000000018D661FB8-0x000000018D662008 
		public Background backgroundImage { get; } // 0x000000018D662008-0x000000018D662064 
		public UnityEngine.Color borderBottomColor { get; } // 0x000000018D662064-0x000000018D6620B8 
		public Length borderBottomLeftRadius { get; } // 0x000000018D6620B8-0x000000018D6620F8 
		public Length borderBottomRightRadius { get; } // 0x000000018D6620F8-0x000000018D662138 
		public float borderBottomWidth { get; } // 0x000000018D662138-0x000000018D662178 
		public UnityEngine.Color borderLeftColor { get; } // 0x000000018D662178-0x000000018D6621CC 
		public float borderLeftWidth { get; } // 0x000000018D6621CC-0x000000018D66220C 
		public UnityEngine.Color borderRightColor { get; } // 0x000000018D66220C-0x000000018D662260 
		public float borderRightWidth { get; } // 0x000000018D662260-0x000000018D6622A0 
		public UnityEngine.Color borderTopColor { get; } // 0x000000018D6622A0-0x000000018D6622F4 
		public Length borderTopLeftRadius { get; } // 0x000000018D6622F4-0x000000018D662338 
		public Length borderTopRightRadius { get; } // 0x000000018D662338-0x000000018D66237C 
		public float borderTopWidth { get; } // 0x000000018D66237C-0x000000018D6623BC 
		public Length bottom { get; } // 0x000000018D6623BC-0x000000018D6623FC 
		public UnityEngine.Color color { get; } // 0x000000018D6623FC-0x000000018D66244C 
		public UnityEngine.UIElements.Cursor cursor { get; } // 0x000000018D66244C-0x000000018D6624A8 
		public DisplayStyle display { get; } // 0x000000018D6624F0-0x000000018D662530 
		public Length flexBasis { get; } // 0x000000018D662530-0x000000018D662570 
		public FlexDirection flexDirection { get; } // 0x000000018D662570-0x000000018D6625B0 
		public float flexGrow { get; } // 0x000000018D6625B0-0x000000018D6625F0 
		public float flexShrink { get; } // 0x000000018D6625F0-0x000000018D662630 
		public Wrap flexWrap { get; } // 0x000000018D662630-0x000000018D662670 
		public Length fontSize { get; } // 0x000000018D662670-0x000000018D6626B0 
		public Length height { get; } // 0x000000018D6626C4-0x000000018D662704 
		public Justify justifyContent { get; } // 0x000000018D662704-0x000000018D662744 
		public Length left { get; } // 0x000000018D662744-0x000000018D662784 
		public Length letterSpacing { get; } // 0x000000018D662784-0x000000018D6627C4 
		public Length marginBottom { get; } // 0x000000018D6627C4-0x000000018D662804 
		public Length marginLeft { get; } // 0x000000018D662804-0x000000018D662844 
		public Length marginRight { get; } // 0x000000018D662844-0x000000018D662884 
		public Length marginTop { get; } // 0x000000018D662884-0x000000018D6628C4 
		public Length maxHeight { get; } // 0x000000018D6628C4-0x000000018D662904 
		public Length maxWidth { get; } // 0x000000018D662904-0x000000018D662944 
		public Length minHeight { get; } // 0x000000018D662944-0x000000018D662988 
		public Length minWidth { get; } // 0x000000018D662988-0x000000018D6629CC 
		public float opacity { get; } // 0x000000018D6629CC-0x000000018D662A10 
		public OverflowInternal overflow { get; } // 0x000000018D662A10-0x000000018D662A54 
		public Length paddingBottom { get; } // 0x000000018D662A54-0x000000018D662A98 
		public Length paddingLeft { get; } // 0x000000018D662A98-0x000000018D662ADC 
		public Length paddingRight { get; } // 0x000000018D662ADC-0x000000018D662B20 
		public Length paddingTop { get; } // 0x000000018D662B20-0x000000018D662B64 
		public Position position { get; } // 0x000000018D662B64-0x000000018D662BA8 
		public Length right { get; } // 0x000000018D662BA8-0x000000018D662BEC 
		public Rotate rotate { get; } // 0x000000018D662BEC-0x000000018D662C48 
		public Scale scale { get; } // 0x000000018D662C48-0x000000018D662C9C 
		public TextOverflow textOverflow { get; } // 0x000000018D662C9C-0x000000018D662CDC 
		public TextShadow textShadow { get; } // 0x000000018D662CDC-0x000000018D662D3C 
		public Length top { get; } // 0x000000018D662D3C-0x000000018D662D80 
		public TransformOrigin transformOrigin { get; } // 0x000000018D662D80-0x000000018D662DD8 
		public List<TimeValue> transitionDelay { get; } // 0x000000018D662DD8-0x000000018D662E18 
		public List<TimeValue> transitionDuration { get; } // 0x000000018D662E18-0x000000018D662E58 
		public List<StylePropertyName> transitionProperty { get; } // 0x000000018D662E58-0x000000018D662E98 
		public List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction { get; } // 0x000000018D662E98-0x000000018D662ED8 
		public Translate translate { get; } // 0x000000018D662ED8-0x000000018D662F34 
		public UnityEngine.Color unityBackgroundImageTintColor { get; } // 0x000000018D662F34-0x000000018D662F88 
		public UnityEngine.ScaleMode unityBackgroundScaleMode { get; } // 0x000000018D662F88-0x000000018D662FC8 
		public Font unityFont { get; } // 0x000000018D663058-0x000000018D663098 
		public FontDefinition unityFontDefinition { get; } // 0x000000018D662FC8-0x000000018D663018 
		public FontStyle unityFontStyleAndWeight { get; } // 0x000000018D663018-0x000000018D663058 
		public OverflowClipBox unityOverflowClipBox { get; } // 0x000000018D663098-0x000000018D6630D8 
		public Length unityParagraphSpacing { get; } // 0x000000018D6630D8-0x000000018D663118 
		public int unitySliceBottom { get; } // 0x000000018D663118-0x000000018D663158 
		public int unitySliceLeft { get; } // 0x000000018D663158-0x000000018D663198 
		public int unitySliceRight { get; } // 0x000000018D663198-0x000000018D6631D8 
		public int unitySliceTop { get; } // 0x000000018D6631D8-0x000000018D663218 
		public TextAnchor unityTextAlign { get; } // 0x000000018D663218-0x000000018D663258 
		public UnityEngine.Color unityTextOutlineColor { get; } // 0x000000018D663258-0x000000018D6632A8 
		public float unityTextOutlineWidth { get; } // 0x000000018D6632A8-0x000000018D6632E8 
		public TextOverflowPosition unityTextOverflowPosition { get; } // 0x000000018D6632E8-0x000000018D663328 
		public Visibility visibility { get; } // 0x000000018D663328-0x000000018D663368 
		public WhiteSpace whiteSpace { get; } // 0x000000018D663368-0x000000018D6633A8 
		public Length width { get; } // 0x000000018D6633A8-0x000000018D6633EC 
		public Length wordSpacing { get; } // 0x000000018D6633EC-0x000000018D6636D4 
	
		// Methods
		public void FinalizeApply(ref ComputedStyle parentStyle); // 0x000000018D65C144-0x000000018D65C264
		public void SyncWithLayout(YogaNode targetNode); // 0x000000018D661AD8-0x000000018D661EF8
		private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle); // 0x000000018D655914-0x000000018D6559A4
		private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle); // 0x000000018D6559A4-0x000000018D6559C4
		private void RemoveCustomStyleProperty(StylePropertyReader reader); // 0x000000018D65C32C-0x000000018D65C3C0
		private void ApplyCustomStyleProperty(StylePropertyReader reader); // 0x000000018D654544-0x000000018D65462C
		private void ApplyAllPropertyInitial(); // 0x000000018D6544F8-0x000000018D654544
		private void ResetComputedTransitions(); // 0x0000000189255E78-0x0000000189255E8C
		public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y); // 0x000000018D65B930-0x000000018D65BC70
		public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D65DC84-0x000000018D65DDA4
		public static ComputedStyle Create(ref ComputedStyle parentStyle); // 0x000000018D65BF3C-0x000000018D65C144
		public static ComputedStyle CreateInitial(); // 0x000000018D65BD9C-0x000000018D65BF3C
		public ComputedStyle Acquire(); // 0x000000018D6543E4-0x000000018D6544F8
		public void Release(); // 0x000000018D65C264-0x000000018D65C32C
		public void CopyFrom(ref ComputedStyle other); // 0x000000018D65BC70-0x000000018D65BD9C
		public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle); // 0x000000018D657178-0x000000018D658434
		public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle); // 0x000000018D65A804-0x000000018D65B5E4
		public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle); // 0x000000018D65A4F0-0x000000018D65A804
		public void ApplyStyleCursor(UnityEngine.UIElements.Cursor cursor); // 0x000000018D65A2DC-0x000000018D65A33C
		public void ApplyStyleTextShadow(TextShadow st); // 0x000000018D65A3E4-0x000000018D65A444
		public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other); // 0x000000018D65462C-0x000000018D655914
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue); // 0x000000018D6588CC-0x000000018D6591D4
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue); // 0x000000018D65857C-0x000000018D6588CC
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue); // 0x000000018D659318-0x000000018D6598BC
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, UnityEngine.Color newValue); // 0x000000018D65A06C-0x000000018D65A2DC
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue); // 0x000000018D659C88-0x000000018D659DD8
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue); // 0x000000018D6591D4-0x000000018D659318
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue); // 0x000000018D659DD8-0x000000018D659F20
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue); // 0x000000018D659F20-0x000000018D65A06C
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue); // 0x000000018D6598BC-0x000000018D659A04
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue); // 0x000000018D659B44-0x000000018D659C88
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue); // 0x000000018D658434-0x000000018D65857C
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue); // 0x000000018D659A04-0x000000018D659B44
		public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D65FA58-0x000000018D661AD8
		public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D65C3C0-0x000000018D65DC84
		public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve); // 0x000000018D65DDA4-0x000000018D65FA58
		public void ApplyStyleTransformOrigin(TransformOrigin st); // 0x000000018D65A444-0x000000018D65A498
		public void ApplyStyleTranslate(Translate translateValue); // 0x000000018D65A498-0x000000018D65A4F0
		public void ApplyStyleRotate(Rotate rotateValue); // 0x000000018D65A33C-0x000000018D65A394
		public void ApplyStyleScale(Scale scaleValue); // 0x000000018D65A394-0x000000018D65A3E4
		public void ApplyInitialValue(StylePropertyReader reader); // 0x000000018D6559C4-0x000000018D655A0C
		public void ApplyInitialValue(StylePropertyId id); // 0x000000018D655A0C-0x000000018D657178
		public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle); // 0x000000018D65B5E4-0x000000018D65B618
		public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle); // 0x000000018D65B618-0x000000018D65B930
	}

	internal struct ComputedTransitionProperty // TypeDefIndex: 71808
	{
		// Fields
		public StylePropertyId id; // 0x00
		public int durationMs; // 0x04
		public int delayMs; // 0x08
		public Func<float, float> easingCurve; // 0x10
	}

	internal static class ComputedTransitionUtils // TypeDefIndex: 71810
	{
		// Fields
		private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71809
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
			static __c(); // 0x000000018D670A88-0x000000018D670AEC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _ConvertTransitionFunction_b__12_0(float t); // 0x00000001872637B0-0x00000001872637E0
			internal float _ConvertTransitionFunction_b__12_1(float t); // 0x0000000187263870-0x0000000187263880
			internal float _ConvertTransitionFunction_b__12_2(float t); // 0x0000000187263880-0x00000001872638A0
			internal float _ConvertTransitionFunction_b__12_3(float t); // 0x000000018D670A50-0x000000018D670A5C
			internal float _ConvertTransitionFunction_b__12_4(float t); // 0x00000001872638A0-0x00000001872638B0
			internal float _ConvertTransitionFunction_b__12_5(float t); // 0x00000001872638B0-0x00000001872638E0
			internal float _ConvertTransitionFunction_b__12_6(float t); // 0x00000001872638E0-0x0000000187263900
			internal float _ConvertTransitionFunction_b__12_7(float t); // 0x0000000187263900-0x0000000187263940
			internal float _ConvertTransitionFunction_b__12_8(float t); // 0x0000000187263940-0x0000000187263950
			internal float _ConvertTransitionFunction_b__12_9(float t); // 0x000000018D670A5C-0x000000018D670A88
			internal float _ConvertTransitionFunction_b__12_10(float t); // 0x000000018D67097C-0x000000018D670990
			internal float _ConvertTransitionFunction_b__12_11(float t); // 0x00000001872637E0-0x0000000187263840
			internal float _ConvertTransitionFunction_b__12_12(float t); // 0x0000000187263840-0x0000000187263870
			internal float _ConvertTransitionFunction_b__12_13(float t); // 0x000000018D670990-0x000000018D67099C
			internal float _ConvertTransitionFunction_b__12_14(float t); // 0x000000018D67099C-0x000000018D6709A8
			internal float _ConvertTransitionFunction_b__12_15(float t); // 0x000000018D6709A8-0x000000018D6709B4
			internal float _ConvertTransitionFunction_b__12_16(float t); // 0x000000018D6709B4-0x000000018D6709C0
			internal float _ConvertTransitionFunction_b__12_17(float t); // 0x000000018D6709C0-0x000000018D6709CC
			internal float _ConvertTransitionFunction_b__12_18(float t); // 0x000000018D6709CC-0x000000018D6709FC
			internal float _ConvertTransitionFunction_b__12_19(float t); // 0x000000018D6709FC-0x000000018D670A08
			internal float _ConvertTransitionFunction_b__12_20(float t); // 0x000000018D670A08-0x000000018D670A38
			internal float _ConvertTransitionFunction_b__12_21(float t); // 0x000000018D670A38-0x000000018D670A44
			internal float _ConvertTransitionFunction_b__12_22(float t); // 0x000000018D670A44-0x000000018D670A50
		}
	
		// Constructors
		static ComputedTransitionUtils(); // 0x000000018D666258-0x000000018D6662E4
	
		// Methods
		internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle); // 0x000000018D666200-0x000000018D666258
		private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle); // 0x000000018D6657B8-0x000000018D665934
		private static int GetTransitionHashCode(ref ComputedStyle cs); // 0x000000018D665934-0x000000018D665DD0
		internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y); // 0x000000018D666028-0x000000018D666138
		private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b); // 0x000000018D665F60-0x000000018D666028
		private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b); // 0x000000018D666138-0x000000018D666200
		private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData); // 0x000000018D664580-0x000000018D6647D8
		private static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue);
		private static int ConvertTransitionTime(TimeValue time); // 0x000000018D66578C-0x000000018D6657B8
		private static Func<float, float> ConvertTransitionFunction(EasingMode mode); // 0x000000018D6647D8-0x000000018D66578C
	
		// Extension methods
		internal static bool HasTransitionProperty(this ref ComputedStyle computedStyle, StylePropertyId id); // 0x000000018D665EB8-0x000000018D665F60
		internal static bool GetTransitionProperty(this ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result); // 0x000000018D665DD0-0x000000018D665EB8
	}

	public struct CustomStyleProperty<T> : IEquatable<CustomStyleProperty<T>> // TypeDefIndex: 71811
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _name_k__BackingField;
	
		// Properties
		public string name { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CustomStyleProperty(string propertyName);
	
		// Methods
		public override bool Equals(object obj);
		public bool Equals(CustomStyleProperty<T> other);
		public override int GetHashCode();
	}

	public interface ICustomStyle // TypeDefIndex: 71812
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

	public enum EasingMode // TypeDefIndex: 71813
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

	public struct EasingFunction : IEquatable<UnityEngine.UIElements.EasingFunction> // TypeDefIndex: 71814
	{
		// Fields
		private EasingMode m_Mode; // 0x00
	
		// Properties
		public EasingMode mode { get; } // 0x00000001844AD290-0x00000001844AD2A0 
	
		// Constructors
		public EasingFunction(EasingMode mode); // 0x0000000184547F40-0x0000000184547F50
	
		// Methods
		public static implicit operator EasingFunction(EasingMode easingMode); // 0x0000000187261390-0x00000001872613A0
		public static bool operator ==(EasingFunction lhs, EasingFunction rhs); // 0x0000000189CCDE30-0x0000000189CCDE38
		public bool Equals(EasingFunction other); // 0x000000018CD9EF34-0x000000018CD9EF3C
		public override bool Equals(object obj); // 0x000000018D666E30-0x000000018D666E98
		public override string ToString(); // 0x000000018D666E98-0x000000018D666EEC
		public override int GetHashCode(); // 0x000000018725FD00-0x000000018725FD10
	}

	public struct FontDefinition : IEquatable<FontDefinition> // TypeDefIndex: 71815
	{
		// Fields
		private Font m_Font; // 0x00
		private FontAsset m_FontAsset; // 0x08
	
		// Properties
		public Font font { get; } // 0x000000018514D010-0x000000018514D0E0 
		public FontAsset fontAsset { get; } // 0x000000018725FF40-0x000000018725FF50 
	
		// Methods
		public static FontDefinition FromFont(Font f); // 0x000000018D666FAC-0x000000018D666FE4
		public static FontDefinition FromSDFFont(FontAsset f); // 0x000000018D6670D8-0x000000018D667110
		internal static FontDefinition FromObject(object obj); // 0x000000018D666FE4-0x000000018D6670D8
		internal bool IsEmpty(); // 0x000000018D6671D8-0x000000018D66725C
		public override string ToString(); // 0x000000018D66725C-0x000000018D6672D4
		public bool Equals(FontDefinition other); // 0x000000018D666F64-0x000000018D666FAC
		public override bool Equals(object obj); // 0x000000018D666EEC-0x000000018D666F64
		public override int GetHashCode(); // 0x000000018D667110-0x000000018D6671D8
		public static bool operator ==(FontDefinition left, FontDefinition right); // 0x000000018D6672D4-0x000000018D6672F4
		public static bool operator !=(FontDefinition left, FontDefinition right); // 0x000000018D6672F4-0x000000018D667314
	}

	internal class StyleValueCollection // TypeDefIndex: 71816
	{
		// Fields
		internal List<StyleValue> m_Values; // 0x10
	
		// Constructors
		public StyleValueCollection(); // 0x000000018D66E604-0x000000018D66E67C
	
		// Methods
		public StyleLength GetStyleLength(StylePropertyId id); // 0x000000018D66E2E8-0x000000018D66E378
		public StyleFloat GetStyleFloat(StylePropertyId id); // 0x000000018D66E20C-0x000000018D66E278
		public StyleInt GetStyleInt(StylePropertyId id); // 0x000000018D66E278-0x000000018D66E2E8
		public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value); // 0x000000018D66E4A0-0x000000018D66E604
		public void SetStyleValue(StyleValue value); // 0x000000018D66E378-0x000000018D66E4A0
	}

	internal class InlineStyleAccess : StyleValueCollection, IStyle // TypeDefIndex: 71818
	{
		// Fields
		private static StylePropertyReader s_StylePropertyReader; // 0x00
		private List<StyleValueManaged> m_ValuesManaged; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
		private VisualElement ve { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		StyleCursor IStyle.cursor { get; } // 0x000000018D668B94-0x000000018D668BFC 
		StyleTextShadow IStyle.textShadow { get; } // 0x000000018D668D80-0x000000018D668DE8 
		StyleTransformOrigin IStyle.transformOrigin { get; } // 0x000000018D668DE8-0x000000018D668E58 
		StyleTranslate IStyle.translate { get; set; } // 0x000000018D668E58-0x000000018D668ED8 0x000000018D66A1D8-0x000000018D66A230
		StyleRotate IStyle.rotate { get; } // 0x000000018D668C98-0x000000018D668D18 
		StyleScale IStyle.scale { get; } // 0x000000018D668D18-0x000000018D668D80 
		StyleColor IStyle.backgroundColor { set; } // 0x000000018D668F14-0x000000018D668F64
		StyleColor IStyle.borderBottomColor { set; } // 0x000000018D668F64-0x000000018D668FB4
		StyleLength IStyle.borderBottomLeftRadius { set; } // 0x000000018D668FB4-0x000000018D669008
		StyleLength IStyle.borderBottomRightRadius { set; } // 0x000000018D669008-0x000000018D66905C
		StyleFloat IStyle.borderBottomWidth { set; } // 0x000000018D66905C-0x000000018D6690DC
		StyleColor IStyle.borderLeftColor { set; } // 0x000000018D6690DC-0x000000018D66912C
		StyleFloat IStyle.borderLeftWidth { set; } // 0x000000018D66912C-0x000000018D6691AC
		StyleColor IStyle.borderRightColor { set; } // 0x000000018D6691AC-0x000000018D6691FC
		StyleFloat IStyle.borderRightWidth { set; } // 0x000000018D6691FC-0x000000018D66927C
		StyleColor IStyle.borderTopColor { set; } // 0x000000018D66927C-0x000000018D6692CC
		StyleLength IStyle.borderTopLeftRadius { set; } // 0x000000018D6692CC-0x000000018D669320
		StyleLength IStyle.borderTopRightRadius { set; } // 0x000000018D669320-0x000000018D669374
		StyleFloat IStyle.borderTopWidth { set; } // 0x000000018D669374-0x000000018D6693F4
		StyleLength IStyle.bottom { set; } // 0x000000018D6693F4-0x000000018D66948C
		StyleColor IStyle.color { set; } // 0x000000018D66948C-0x000000018D6694DC
		StyleEnum<DisplayStyle> IStyle.display { get; set; } // 0x000000018D668BFC-0x000000018D668C5C 0x000000018D6694DC-0x000000018D669580
		StyleLength IStyle.flexBasis { set; } // 0x000000018D669580-0x000000018D669618
		StyleEnum<FlexDirection> IStyle.flexDirection { set; } // 0x000000018D669618-0x000000018D6696BC
		StyleFloat IStyle.flexGrow { set; } // 0x000000018D6696BC-0x000000018D669738
		StyleFloat IStyle.flexShrink { set; } // 0x000000018D669738-0x000000018D6697B4
		StyleLength IStyle.fontSize { set; } // 0x000000018D6697B4-0x000000018D669808
		StyleLength IStyle.height { set; } // 0x000000018D669808-0x000000018D6698A0
		StyleLength IStyle.left { set; } // 0x000000018D6698A0-0x000000018D669938
		StyleLength IStyle.marginBottom { set; } // 0x000000018D669938-0x000000018D6699D0
		StyleLength IStyle.marginLeft { set; } // 0x000000018D6699D0-0x000000018D669A68
		StyleLength IStyle.marginRight { set; } // 0x000000018D669A68-0x000000018D669B00
		StyleLength IStyle.marginTop { set; } // 0x000000018D669B00-0x000000018D669B98
		StyleLength IStyle.maxHeight { set; } // 0x000000018D669B98-0x000000018D669C30
		StyleLength IStyle.maxWidth { set; } // 0x000000018D669C30-0x000000018D669CC8
		StyleLength IStyle.minWidth { set; } // 0x000000018D669CC8-0x000000018D669D60
		StyleFloat IStyle.opacity { set; } // 0x000000018D669D60-0x000000018D669DA4
		StyleLength IStyle.paddingBottom { set; } // 0x000000018D669DA4-0x000000018D669E3C
		StyleLength IStyle.paddingLeft { set; } // 0x000000018D669E3C-0x000000018D669ED4
		StyleLength IStyle.paddingRight { set; } // 0x000000018D669ED4-0x000000018D669F6C
		StyleLength IStyle.paddingTop { get; set; } // 0x000000018D668C5C-0x000000018D668C98 0x000000018D669F6C-0x000000018D66A004
		StyleEnum<Position> IStyle.position { set; } // 0x000000018D66A004-0x000000018D66A0A8
		StyleLength IStyle.right { set; } // 0x000000018D66A0A8-0x000000018D66A140
		StyleLength IStyle.top { set; } // 0x000000018D66A140-0x000000018D66A1D8
		StyleColor IStyle.unityBackgroundImageTintColor { set; } // 0x000000018D66A230-0x000000018D66A280
		StyleEnum<Visibility> IStyle.visibility { set; } // 0x000000018D66A280-0x000000018D66A2F0
		StyleLength IStyle.width { get; set; } // 0x000000018D668ED8-0x000000018D668F14 0x000000018D66A2F0-0x000000018D66A388
	
		// Nested types
		internal struct InlineRule // TypeDefIndex: 71817
		{
			// Fields
			public StyleSheet sheet; // 0x00
			public StyleRule rule; // 0x08
			public StylePropertyId[] propertyIds; // 0x10
		}
	
		// Constructors
		public InlineStyleAccess(VisualElement ve); // 0x000000018D66A404-0x000000018D66A434
		static InlineStyleAccess(); // 0x000000018D66A388-0x000000018D66A404
	
		// Methods
		~InlineStyleAccess(); // 0x000000018D668118-0x000000018D6681EC
		public void SetInlineRule(StyleSheet sheet, StyleRule rule); // 0x000000018D668574-0x000000018D668624
		public bool IsValueSet(StylePropertyId id); // 0x000000018D6681EC-0x000000018D66849C
		public void ApplyInlineStyles(ref ComputedStyle computedStyle); // 0x000000018D6674D0-0x000000018D667CE4
		private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue); // 0x000000018D668764-0x000000018D668874
		private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue); // 0x000000018D6689A4-0x000000018D668AA8
		private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue); // 0x000000018D668874-0x000000018D6689A4
		private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue)
			where T : struct, IConvertible;
		private bool SetInlineTranslate(StyleTranslate inlineValue); // 0x000000018D668624-0x000000018D668764
		private void ApplyStyleTranslate(StyleTranslate translate); // 0x000000018D667CE4-0x000000018D667EB4
		private void ApplyStyleValue(StyleValue value); // 0x000000018D667EB4-0x000000018D668118
		private bool RemoveInlineStyle(StylePropertyId id); // 0x000000018D66849C-0x000000018D668574
		private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle); // 0x000000018D667314-0x000000018D6674D0
		public bool TryGetInlineCursor(ref StyleCursor value); // 0x000000018D668AA8-0x000000018D668AD4
		public bool TryGetInlineTextShadow(ref StyleTextShadow value); // 0x000000018D668B28-0x000000018D668B44
		public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value); // 0x000000018D668B44-0x000000018D668B64
		public bool TryGetInlineTranslate(ref StyleTranslate value); // 0x000000018D668B64-0x000000018D668B94
		public bool TryGetInlineRotate(ref StyleRotate value); // 0x000000018D668AD4-0x000000018D668B04
		public bool TryGetInlineScale(ref StyleScale value); // 0x000000018D668B04-0x000000018D668B28
	}

	public enum LengthUnit // TypeDefIndex: 71819
	{
		Pixel = 0,
		Percent = 1
	}

	[Serializable]
	public struct Length : IEquatable<Length> // TypeDefIndex: 71821
	{
		// Fields
		internal const float k_MaxValue = 8388608f; // Metadata: 0x0262252D
		[SerializeField]
		private float m_Value; // 0x00
		[SerializeField]
		private Unit m_Unit; // 0x04
	
		// Properties
		public float value { get; set; } // 0x00000001872342D0-0x00000001872342E0 0x000000018D66A714-0x000000018D66A738
		public LengthUnit unit { get; } // 0x00000001872342E0-0x00000001872342F0 
	
		// Nested types
		private enum Unit // TypeDefIndex: 71820
		{
			Pixel = 0,
			Percent = 1,
			Auto = 2,
			None = 3
		}
	
		// Constructors
		public Length(float value); // 0x000000018D66A6C0-0x000000018D66A6CC
		public Length(float value, LengthUnit unit); // 0x000000018D66A6CC-0x000000018D66A6D4
		private Length(float value, Unit unit); // 0x000000018D66A694-0x000000018D66A6C0
	
		// Methods
		public static Length Percent(float value); // 0x000000018D66A514-0x000000018D66A544
		public static Length Auto(); // 0x000000018D66A434-0x000000018D66A464
		public static Length None(); // 0x000000018D66A4E4-0x000000018D66A514
		public bool IsAuto(); // 0x000000018D66A4D4-0x000000018D66A4DC
		public bool IsNone(); // 0x000000018D66A4DC-0x000000018D66A4E4
		public static implicit operator Length(float value); // 0x000000018D66A6D4-0x000000018D66A700
		public static bool operator ==(Length lhs, Length rhs); // 0x000000018D66393C-0x000000018D663968
		public static bool operator !=(Length lhs, Length rhs); // 0x000000018D66A700-0x000000018D66A714
		public bool Equals(Length other); // 0x000000018D663744-0x000000018D663758
		public override bool Equals(object obj); // 0x000000018D66A464-0x000000018D66A4D4
		public override int GetHashCode(); // 0x000000018D663758-0x000000018D663778
		public override string ToString(); // 0x000000018D66A544-0x000000018D66A694
	}

	public struct Rotate : IEquatable<Rotate> // TypeDefIndex: 71822
	{
		// Fields
		private Angle m_Angle; // 0x00
		private Vector3 m_Axis; // 0x08
		private bool m_IsNone; // 0x14
	
		// Properties
		public Angle angle { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
		internal Vector3 axis { get; } // 0x000000018724A620-0x000000018724A640 
	
		// Constructors
		public Rotate(Angle angle); // 0x000000018D66CA08-0x000000018D66CA2C
	
		// Methods
		internal static Rotate Initial(); // 0x000000018D66C890-0x000000018D66C908
		public static Rotate None(); // 0x000000018D66C908-0x000000018D66C954
		public static bool operator ==(Rotate lhs, Rotate rhs); // 0x000000018D66CA2C-0x000000018D66CB20
		public static bool operator !=(Rotate lhs, Rotate rhs); // 0x000000018D66CB20-0x000000018D66CB60
		public bool Equals(Rotate other); // 0x000000018D66C7CC-0x000000018D66C810
		public override bool Equals(object obj); // 0x000000018D66C734-0x000000018D66C7CC
		public override int GetHashCode(); // 0x000000018D66C810-0x000000018D66C890
		public override string ToString(); // 0x000000018D66C9A8-0x000000018D66CA08
		internal Quaternion ToQuaternion(); // 0x000000018D66C954-0x000000018D66C9A8
	}

	public struct Scale : IEquatable<Scale> // TypeDefIndex: 71823
	{
		// Fields
		private Vector3 m_Scale; // 0x00
		private bool m_IsNone; // 0x0C
	
		// Properties
		public Vector3 value { get; } // 0x000000018723AE60-0x000000018723AE80 
	
		// Constructors
		public Scale(Vector3 scale); // 0x0000000187263500-0x0000000187263530
	
		// Methods
		internal static Scale Initial(); // 0x000000018D66CDE0-0x000000018D66CE34
		public static Scale None(); // 0x000000018D66CE34-0x000000018D66CE70
		public static bool operator ==(Scale lhs, Scale rhs); // 0x000000018D66CE7C-0x000000018D66CED0
		public static bool operator !=(Scale lhs, Scale rhs); // 0x000000018D66CED0-0x000000018D66CF00
		public bool Equals(Scale other); // 0x000000018D66CD1C-0x000000018D66CD48
		public override bool Equals(object obj); // 0x000000018D66CD48-0x000000018D66CDCC
		public override int GetHashCode(); // 0x000000018D66CDCC-0x000000018D66CDE0
		public override string ToString(); // 0x000000018D66CE70-0x000000018D66CE7C
	}

	public struct StyleColor : IStyleValue<UnityEngine.Color>, IEquatable<StyleColor> // TypeDefIndex: 71824
	{
		// Fields
		private UnityEngine.Color m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x10
	
		// Properties
		public UnityEngine.Color value { get; } // 0x000000018D66D058-0x000000018D66D084 
		public StyleKeyword keyword { get; } // 0x000000018725FFC0-0x000000018725FFD0 
	
		// Constructors
		public StyleColor(UnityEngine.Color v); // 0x0000000187252B50-0x0000000187252B60
		internal StyleColor(UnityEngine.Color v, StyleKeyword keyword); // 0x000000018724A310-0x000000018724A320
	
		// Methods
		public static bool operator ==(StyleColor lhs, StyleColor rhs); // 0x000000018D66D084-0x000000018D66D0D4
		public static implicit operator StyleColor(UnityEngine.Color v); // 0x0000000187263530-0x0000000187263550
		public bool Equals(StyleColor other); // 0x000000018D66CF00-0x000000018D66CF3C
		public override bool Equals(object obj); // 0x000000018D66CF3C-0x000000018D66CFD0
		public override int GetHashCode(); // 0x000000018D66CFD0-0x000000018D66CFF0
		public override string ToString(); // 0x000000018D66CFF0-0x000000018D66D058
	}

	public struct StyleCursor : IStyleValue<UnityEngine.UIElements.Cursor>, IEquatable<StyleCursor> // TypeDefIndex: 71825
	{
		// Fields
		private UnityEngine.UIElements.Cursor m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public UnityEngine.UIElements.Cursor value { get; } // 0x000000018D66D260-0x000000018D66D294 
		public StyleKeyword keyword { get; } // 0x000000018724B960-0x000000018724B970 
	
		// Constructors
		public StyleCursor(StyleKeyword keyword); // 0x000000018D66D21C-0x000000018D66D244
		internal StyleCursor(UnityEngine.UIElements.Cursor v, StyleKeyword keyword); // 0x000000018D66D244-0x000000018D66D260
	
		// Methods
		public static bool operator ==(StyleCursor lhs, StyleCursor rhs); // 0x000000018D66D294-0x000000018D66D2F4
		public static implicit operator StyleCursor(StyleKeyword keyword); // 0x000000018D66D2F4-0x000000018D66D338
		public bool Equals(StyleCursor other); // 0x000000018D66D0D4-0x000000018D66D114
		public override bool Equals(object obj); // 0x000000018D66D114-0x000000018D66D194
		public override int GetHashCode(); // 0x000000018D66D194-0x000000018D66D1B4
		public override string ToString(); // 0x000000018D66D1B4-0x000000018D66D21C
	}

	internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> // TypeDefIndex: 71827
		where T : struct, IEquatable<T>, IStyleDataGroup<T>
	{
		// Fields
		private RefCounted m_Ref;
	
		// Nested types
		private class RefCounted // TypeDefIndex: 71826
		{
			// Fields
			private static uint m_NextId;
			private int m_RefCount;
			private readonly uint m_Id;
			public T value;
	
			// Properties
			public int refCount { get; }
	
			// Constructors
			public RefCounted();
			static RefCounted();
	
			// Methods
			public void Acquire();
			public void Release();
			public RefCounted<T> Copy();
		}
	
		// Methods
		public StyleDataRef<T> Acquire();
		public void Release();
		public void CopyFrom(StyleDataRef<T> other);
		public ref ref T Read();
		public ref ref T Write();
		public static StyleDataRef<T> Create();
		public override int GetHashCode();
		public static bool operator ==(StyleDataRef<T> lhs, StyleDataRef<T> rhs);
		public bool Equals(StyleDataRef<T> other);
		public override bool Equals(object obj);
	}

	public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> // TypeDefIndex: 71828
		where T : struct, IConvertible
	{
		// Fields
		private T m_Value;
		private StyleKeyword m_Keyword;
	
		// Properties
		public T value { get; }
		public StyleKeyword keyword { get; }
	
		// Constructors
		public StyleEnum(T v);
		public StyleEnum(StyleKeyword keyword);
		internal StyleEnum(T v, StyleKeyword keyword);
	
		// Methods
		public static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs);
		public static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs);
		public static implicit operator StyleEnum<T>(StyleKeyword keyword);
		public static implicit operator StyleEnum<T>(T v);
		public bool Equals(StyleEnum<T> other);
		public override bool Equals(object obj);
		public override int GetHashCode();
		public override string ToString();
	}

	public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 71829
	{
		// Fields
		private float m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x04
	
		// Properties
		public float value { get; } // 0x000000018D66D41C-0x000000018D66D42C 
		public StyleKeyword keyword { get; } // 0x000000018724CA40-0x000000018724CA50 
	
		// Constructors
		public StyleFloat(float v); // 0x00000001872342C0-0x00000001872342D0
		public StyleFloat(StyleKeyword keyword); // 0x0000000187263550-0x0000000187263560
		internal StyleFloat(float v, StyleKeyword keyword); // 0x00000001872342B0-0x00000001872342C0
	
		// Methods
		public static bool operator ==(StyleFloat lhs, StyleFloat rhs); // 0x000000018D66D42C-0x000000018D66D458
		public static implicit operator StyleFloat(StyleKeyword keyword); // 0x0000000187263560-0x0000000187263580
		public static implicit operator StyleFloat(float v); // 0x0000000187263490-0x00000001872634B0
		public bool Equals(StyleFloat other); // 0x000000018D66D3A8-0x000000018D66D3BC
		public override bool Equals(object obj); // 0x000000018D66D338-0x000000018D66D3A8
		public override int GetHashCode(); // 0x000000018D663758-0x000000018D663778
		public override string ToString(); // 0x000000018D66D3BC-0x000000018D66D41C
	}

	public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 71830
	{
		// Fields
		private int m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x04
	
		// Properties
		public int value { get; } // 0x000000018B854288-0x000000018B854294 
		public StyleKeyword keyword { get; } // 0x000000018724CA40-0x000000018724CA50 
	
		// Constructors
		public StyleInt(StyleKeyword keyword); // 0x0000000187263550-0x0000000187263560
		internal StyleInt(int v, StyleKeyword keyword); // 0x000000018724CA30-0x000000018724CA40
	
		// Methods
		public static bool operator ==(StyleInt lhs, StyleInt rhs); // 0x000000018D66D53C-0x000000018D66D558
		public static implicit operator StyleInt(StyleKeyword keyword); // 0x0000000187263560-0x0000000187263580
		public bool Equals(StyleInt other); // 0x000000018D66D4C8-0x000000018D66D4DC
		public override bool Equals(object obj); // 0x000000018D66D458-0x000000018D66D4C8
		public override int GetHashCode(); // 0x0000000187261550-0x0000000187261560
		public override string ToString(); // 0x000000018D66D4DC-0x000000018D66D53C
	}

	public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 71831
	{
		// Fields
		private Length m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x08
	
		// Properties
		public Length value { get; } // 0x000000018D66D738-0x000000018D66D750 
		public StyleKeyword keyword { get; } // 0x000000018453A050-0x000000018453A060 
	
		// Constructors
		public StyleLength(float v); // 0x000000018D66D6B8-0x000000018D66D6F4
		public StyleLength(Length v); // 0x000000018D66D72C-0x000000018D66D738
		public StyleLength(StyleKeyword keyword); // 0x000000018D66D6F4-0x000000018D66D704
		internal StyleLength(Length v, StyleKeyword keyword); // 0x000000018D66D704-0x000000018D66D72C
	
		// Methods
		public static bool operator ==(StyleLength lhs, StyleLength rhs); // 0x000000018D66D750-0x000000018D66D774
		public static implicit operator StyleLength(StyleKeyword keyword); // 0x000000018D66D7B4-0x000000018D66D7F0
		public static implicit operator StyleLength(float v); // 0x000000018D66D7F0-0x000000018D66D82C
		public static implicit operator StyleLength(Length v); // 0x000000018D66D774-0x000000018D66D7B4
		public bool Equals(StyleLength other); // 0x000000018D66D558-0x000000018D66D598
		public override bool Equals(object obj); // 0x000000018D66D598-0x000000018D66D630
		public override int GetHashCode(); // 0x000000018D66D630-0x000000018D66D650
		public override string ToString(); // 0x000000018D66D650-0x000000018D66D6B8
	}

	public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate> // TypeDefIndex: 71832
	{
		// Fields
		private Rotate m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public Rotate value { get; } // 0x000000018D66D260-0x000000018D66D294 
		public StyleKeyword keyword { get; } // 0x000000018724B960-0x000000018724B970 
	
		// Constructors
		public StyleRotate(StyleKeyword keyword); // 0x0000000187263580-0x00000001872635B0
		internal StyleRotate(Rotate v, StyleKeyword keyword); // 0x000000018724A2C0-0x000000018724A2E0
	
		// Methods
		public static bool operator ==(StyleRotate lhs, StyleRotate rhs); // 0x000000018D66D998-0x000000018D66DA10
		public static implicit operator StyleRotate(StyleKeyword keyword); // 0x00000001872635B0-0x00000001872635E0
		public bool Equals(StyleRotate other); // 0x000000018D66D8B8-0x000000018D66D908
		public override bool Equals(object obj); // 0x000000018D66D82C-0x000000018D66D8B8
		public override int GetHashCode(); // 0x000000018D66D908-0x000000018D66D928
		public override string ToString(); // 0x000000018D66D928-0x000000018D66D998
	}

	public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale> // TypeDefIndex: 71833
	{
		// Fields
		private Scale m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x10
	
		// Properties
		public Scale value { get; } // 0x000000018D66DB68-0x000000018D66DB80 
		public StyleKeyword keyword { get; } // 0x000000018725FFC0-0x000000018725FFD0 
	
		// Constructors
		public StyleScale(StyleKeyword keyword); // 0x00000001872635E0-0x00000001872635F0
		internal StyleScale(Scale v, StyleKeyword keyword); // 0x000000018724A310-0x000000018724A320
	
		// Methods
		public static bool operator ==(StyleScale lhs, StyleScale rhs); // 0x000000018D66DB80-0x000000018D66DBD4
		public static implicit operator StyleScale(StyleKeyword keyword); // 0x00000001872635F0-0x0000000187263600
		public bool Equals(StyleScale other); // 0x000000018D66DA10-0x000000018D66DA4C
		public override bool Equals(object obj); // 0x000000018D66DA4C-0x000000018D66DAE0
		public override int GetHashCode(); // 0x000000018D66DAE0-0x000000018D66DB00
		public override string ToString(); // 0x000000018D66DB00-0x000000018D66DB68
	}

	public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate> // TypeDefIndex: 71834
	{
		// Fields
		private Translate m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public Translate value { get; } // 0x000000018D66D260-0x000000018D66D294 
		public StyleKeyword keyword { get; } // 0x000000018724B960-0x000000018724B970 
	
		// Constructors
		public StyleTranslate(Translate v); // 0x00000001872636F0-0x0000000187263710
		public StyleTranslate(StyleKeyword keyword); // 0x0000000187263580-0x00000001872635B0
		internal StyleTranslate(Translate v, StyleKeyword keyword); // 0x000000018724A2C0-0x000000018724A2E0
	
		// Methods
		public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs); // 0x000000018D66E194-0x000000018D66E20C
		public static implicit operator StyleTranslate(StyleKeyword keyword); // 0x00000001872635B0-0x00000001872635E0
		public static implicit operator StyleTranslate(Translate v); // 0x0000000187263710-0x0000000187263740
		public bool Equals(StyleTranslate other); // 0x000000018D66E028-0x000000018D66E078
		public override bool Equals(object obj); // 0x000000018D66E078-0x000000018D66E104
		public override int GetHashCode(); // 0x000000018D66E104-0x000000018D66E124
		public override string ToString(); // 0x000000018D66E124-0x000000018D66E194
	}

	public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow> // TypeDefIndex: 71835
	{
		// Fields
		private StyleKeyword m_Keyword; // 0x00
		private TextShadow m_Value; // 0x04
	
		// Properties
		public TextShadow value { get; } // 0x000000018D66DD38-0x000000018D66DD74 
		public StyleKeyword keyword { get; } // 0x000000018725FD00-0x000000018725FD10 
	
		// Constructors
		public StyleTextShadow(StyleKeyword keyword); // 0x0000000187263600-0x0000000187263630
		internal StyleTextShadow(TextShadow v, StyleKeyword keyword); // 0x0000000187263630-0x0000000187263650
	
		// Methods
		public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs); // 0x000000018D66DD74-0x000000018D66DE10
		public static implicit operator StyleTextShadow(StyleKeyword keyword); // 0x0000000187263650-0x0000000187263690
		public bool Equals(StyleTextShadow other); // 0x000000018D66DC68-0x000000018D66DCA8
		public override bool Equals(object obj); // 0x000000018D66DBD4-0x000000018D66DC68
		public override int GetHashCode(); // 0x000000018D66DCA8-0x000000018D66DCD0
		public override string ToString(); // 0x000000018D66DCD0-0x000000018D66DD38
	}

	public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin> // TypeDefIndex: 71836
	{
		// Fields
		private TransformOrigin m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x14
	
		// Properties
		public TransformOrigin value { get; } // 0x000000018D66DF78-0x000000018D66DF98 
		public StyleKeyword keyword { get; } // 0x0000000187233B60-0x0000000187233B70 
	
		// Constructors
		public StyleTransformOrigin(StyleKeyword keyword); // 0x0000000187263690-0x00000001872636A0
		internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword); // 0x00000001872636A0-0x00000001872636C0
	
		// Methods
		public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs); // 0x000000018D66DF98-0x000000018D66E028
		public static implicit operator StyleTransformOrigin(StyleKeyword keyword); // 0x00000001872636C0-0x00000001872636F0
		public bool Equals(StyleTransformOrigin other); // 0x000000018D66DE10-0x000000018D66DE54
		public override bool Equals(object obj); // 0x000000018D66DE54-0x000000018D66DEEC
		public override int GetHashCode(); // 0x000000018D66DEEC-0x000000018D66DF0C
		public override string ToString(); // 0x000000018D66DF0C-0x000000018D66DF78
	}

	internal interface IStyleValue<T> // TypeDefIndex: 71837
	{
		// Properties
		T value { get; }
		StyleKeyword keyword { get; }
	}

	public enum StyleKeyword // TypeDefIndex: 71838
	{
		Undefined = 0,
		Null = 1,
		Auto = 2,
		None = 3,
		Initial = 4
	}

	internal static class StyleValueExtensions // TypeDefIndex: 71839
	{
		// Extension methods
		internal static string DebugString<T>(this IStyleValue<T> styleValue);
		internal static YogaValue ToYogaValue(this Length length); // 0x000000018D66EA38-0x000000018D66EB4C
		internal static Length ToLength(this StyleKeyword keyword); // 0x000000018D66E67C-0x000000018D66E750
		internal static Rotate ToRotate(this StyleKeyword keyword); // 0x000000018D66E778-0x000000018D66E86C
		internal static Scale ToScale(this StyleKeyword keyword); // 0x000000018D66E86C-0x000000018D66E944
		internal static Translate ToTranslate(this StyleKeyword keyword); // 0x000000018D66E944-0x000000018D66EA38
		internal static Length ToLength(this StyleLength styleLength); // 0x000000018D66E750-0x000000018D66E778
		internal static void CopyFrom<T>(this List<T> list, List<T> other);
	}

	public enum TimeUnit // TypeDefIndex: 71840
	{
		Second = 0,
		Millisecond = 1
	}

	public struct TimeValue : IEquatable<TimeValue> // TypeDefIndex: 71841
	{
		// Fields
		private float m_Value; // 0x00
		private TimeUnit m_Unit; // 0x04
	
		// Properties
		public float value { get; } // 0x00000001872342D0-0x00000001872342E0 
		public TimeUnit unit { get; } // 0x00000001872342E0-0x00000001872342F0 
	
		// Constructors
		public TimeValue(float value); // 0x00000001872342C0-0x00000001872342D0
		public TimeValue(float value, TimeUnit unit); // 0x00000001872342B0-0x00000001872342C0
	
		// Methods
		public static implicit operator TimeValue(float value); // 0x0000000187263490-0x00000001872634B0
		public static bool operator ==(TimeValue lhs, TimeValue rhs); // 0x000000018D66393C-0x000000018D663968
		public static bool operator !=(TimeValue lhs, TimeValue rhs); // 0x000000018D66A700-0x000000018D66A714
		public bool Equals(TimeValue other); // 0x000000018D663744-0x000000018D663758
		public override bool Equals(object obj); // 0x000000018D6701B4-0x000000018D670224
		public override int GetHashCode(); // 0x000000018D663758-0x000000018D663778
		public override string ToString(); // 0x000000018D670224-0x000000018D6702EC
	}

	public struct TransformOrigin : IEquatable<TransformOrigin> // TypeDefIndex: 71842
	{
		// Fields
		private Length m_X; // 0x00
		private Length m_Y; // 0x08
		private float m_Z; // 0x10
	
		// Properties
		public Length x { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
		public Length y { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x000000018561B590-0x000000018561B5A0
		public float z { get; } // 0x0000000187232D00-0x0000000187232D10 
	
		// Constructors
		public TransformOrigin(Length x, Length y, float z); // 0x000000018724EAA0-0x000000018724EAB0
	
		// Methods
		public static TransformOrigin Initial(); // 0x000000018D670418-0x000000018D670464
		public static bool operator ==(TransformOrigin lhs, TransformOrigin rhs); // 0x000000018D670584-0x000000018D670610
		public static bool operator !=(TransformOrigin lhs, TransformOrigin rhs); // 0x000000018D670610-0x000000018D67064C
		public bool Equals(TransformOrigin other); // 0x000000018D6702EC-0x000000018D670328
		public override bool Equals(object obj); // 0x000000018D670328-0x000000018D6703BC
		public override int GetHashCode(); // 0x000000018D6703BC-0x000000018D670418
		public override string ToString(); // 0x000000018D670464-0x000000018D670584
	}

	public struct Translate : IEquatable<Translate> // TypeDefIndex: 71843
	{
		// Fields
		private Length m_X; // 0x00
		private Length m_Y; // 0x08
		private float m_Z; // 0x10
		private bool m_isNone; // 0x14
	
		// Properties
		public Length x { get; set; } // 0x0000000184431970-0x0000000184431980 0x000000018561B5B0-0x000000018561B5C0
		public Length y { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x000000018561B590-0x000000018561B5A0
		public float z { get; } // 0x0000000187232D00-0x0000000187232D10 
	
		// Constructors
		public Translate(Length x, Length y, float z); // 0x0000000187263790-0x00000001872637B0
	
		// Methods
		public static Translate None(); // 0x0000000187263760-0x0000000187263790
		public static bool operator ==(Translate lhs, Translate rhs); // 0x000000018D670848-0x000000018D67093C
		public static bool operator !=(Translate lhs, Translate rhs); // 0x000000018D67093C-0x000000018D67097C
		public bool Equals(Translate other); // 0x000000018D67064C-0x000000018D670690
		public override bool Equals(object obj); // 0x000000018D670690-0x000000018D670728
		public override int GetHashCode(); // 0x000000018D6703BC-0x000000018D670418
		public override string ToString(); // 0x000000018D670728-0x000000018D670848
	}

	public interface IResolvedStyle // TypeDefIndex: 71844
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

	public interface IStyle // TypeDefIndex: 71845
	{
		// Properties
		StyleColor backgroundColor { set; }
		StyleColor borderBottomColor { set; }
		StyleLength borderBottomLeftRadius { set; }
		StyleLength borderBottomRightRadius { set; }
		StyleFloat borderBottomWidth { set; }
		StyleColor borderLeftColor { set; }
		StyleFloat borderLeftWidth { set; }
		StyleColor borderRightColor { set; }
		StyleFloat borderRightWidth { set; }
		StyleColor borderTopColor { set; }
		StyleLength borderTopLeftRadius { set; }
		StyleLength borderTopRightRadius { set; }
		StyleFloat borderTopWidth { set; }
		StyleLength bottom { set; }
		StyleColor color { set; }
		StyleCursor cursor { get; }
		StyleEnum<DisplayStyle> display { get; set; }
		StyleLength flexBasis { set; }
		StyleEnum<FlexDirection> flexDirection { set; }
		StyleFloat flexGrow { set; }
		StyleFloat flexShrink { set; }
		StyleLength fontSize { set; }
		StyleLength height { set; }
		StyleLength left { set; }
		StyleLength marginBottom { set; }
		StyleLength marginLeft { set; }
		StyleLength marginRight { set; }
		StyleLength marginTop { set; }
		StyleLength maxHeight { set; }
		StyleLength maxWidth { set; }
		StyleLength minWidth { set; }
		StyleFloat opacity { set; }
		StyleLength paddingBottom { set; }
		StyleLength paddingLeft { set; }
		StyleLength paddingRight { set; }
		StyleLength paddingTop { get; set; }
		StyleEnum<Position> position { set; }
		StyleLength right { set; }
		StyleRotate rotate { get; }
		StyleScale scale { get; }
		StyleTextShadow textShadow { get; }
		StyleLength top { set; }
		StyleTransformOrigin transformOrigin { get; }
		StyleTranslate translate { get; set; }
		StyleColor unityBackgroundImageTintColor { set; }
		StyleEnum<Visibility> visibility { set; }
		StyleLength width { get; set; }
	}

	internal interface IStyleDataGroup<T> // TypeDefIndex: 71846
	{
		// Methods
		T Copy();
		void CopyFrom(ref ref T other);
	}

	internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData> // TypeDefIndex: 71847
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
		public InheritedData Copy(); // 0x0000000187263950-0x00000001872639A0
		public void CopyFrom(ref InheritedData other); // 0x000000018D6742D4-0x000000018D674390
		public static bool operator ==(InheritedData lhs, InheritedData rhs); // 0x000000018D674698-0x000000018D67513C
		public bool Equals(InheritedData other); // 0x000000018D674390-0x000000018D67445C
		public override bool Equals(object obj); // 0x000000018D67445C-0x000000018D674528
		public override int GetHashCode(); // 0x000000018D674528-0x000000018D674698
	}

	internal struct LayoutData : IStyleDataGroup<UnityEngine.UIElements.LayoutData>, IEquatable<UnityEngine.UIElements.LayoutData> // TypeDefIndex: 71848
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
		public LayoutData Copy(); // 0x0000000187263AB0-0x0000000187263B30
		public void CopyFrom(ref LayoutData other); // 0x00000001872639A0-0x0000000187263AB0
		public static bool operator ==(LayoutData lhs, LayoutData rhs); // 0x000000018D6755C0-0x000000018D6775B4
		public bool Equals(LayoutData other); // 0x000000018D675234-0x000000018D675340
		public override bool Equals(object obj); // 0x000000018D67513C-0x000000018D675234
		public override int GetHashCode(); // 0x000000018D675340-0x000000018D6755C0
	}

	internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData> // TypeDefIndex: 71849
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
		public RareData Copy(); // 0x0000000187263BF0-0x0000000187263C20
		public void CopyFrom(ref RareData other); // 0x000000018D67E2F4-0x000000018D67E324
		public static bool operator ==(RareData lhs, RareData rhs); // 0x000000018D67E4B8-0x000000018D67E6B4
		public bool Equals(RareData other); // 0x000000018D67E3C4-0x000000018D67E440
		public override bool Equals(object obj); // 0x000000018D67E324-0x000000018D67E3C4
		public override int GetHashCode(); // 0x000000018D67E440-0x000000018D67E4B8
	}

	internal struct TransformData : IStyleDataGroup<UnityEngine.UIElements.TransformData>, IEquatable<UnityEngine.UIElements.TransformData> // TypeDefIndex: 71850
	{
		// Fields
		public Rotate rotate; // 0x00
		public Scale scale; // 0x18
		public TransformOrigin transformOrigin; // 0x28
		public Translate translate; // 0x3C
	
		// Methods
		public TransformData Copy(); // 0x0000000187263CC0-0x0000000187263CF0
		public void CopyFrom(ref TransformData other); // 0x0000000187263C90-0x0000000187263CC0
		public static bool operator ==(TransformData lhs, TransformData rhs); // 0x000000018D684AF8-0x000000018D684D14
		public bool Equals(TransformData other); // 0x000000018D684960-0x000000018D6849E4
		public override bool Equals(object obj); // 0x000000018D6849E4-0x000000018D684A90
		public override int GetHashCode(); // 0x000000018D684A90-0x000000018D684AF8
	}

	internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData> // TypeDefIndex: 71851
	{
		// Fields
		public List<TimeValue> transitionDelay; // 0x00
		public List<TimeValue> transitionDuration; // 0x08
		public List<StylePropertyName> transitionProperty; // 0x10
		public List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction; // 0x18
	
		// Methods
		public TransitionData Copy(); // 0x000000018D684E74-0x000000018D685018
		public void CopyFrom(ref TransitionData other); // 0x000000018D684D14-0x000000018D684E74
		public static bool operator ==(TransitionData lhs, TransitionData rhs); // 0x000000018D685180-0x000000018D6851B8
		public bool Equals(TransitionData other); // 0x000000018D685018-0x000000018D685058
		public override bool Equals(object obj); // 0x000000018D685058-0x000000018D6850EC
		public override int GetHashCode(); // 0x000000018D6850EC-0x000000018D685180
	}

	internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData> // TypeDefIndex: 71852
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
		public VisualData Copy(); // 0x0000000187263CF0-0x0000000187263D50
		public void CopyFrom(ref VisualData other); // 0x000000018D6892E4-0x000000018D6893BC
		public static bool operator ==(VisualData lhs, VisualData rhs); // 0x000000018D689684-0x000000018D68A0CC
		public bool Equals(VisualData other); // 0x000000018D6893BC-0x000000018D6894A4
		public override bool Equals(object obj); // 0x000000018D6894A4-0x000000018D68957C
		public override int GetHashCode(); // 0x000000018D68957C-0x000000018D689684
	}

	internal struct Hashes // TypeDefIndex: 71854
	{
		// Fields
		public const int kSize = 4; // Metadata: 0x0262253C
		public unsafe fixed /* 0x00000000-0x00000000 */ int hashes[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _hashes_e__FixedBuffer // TypeDefIndex: 71853
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	}

	[Serializable]
	internal class StyleComplexSelector : ISerializationCallbackReceiver // TypeDefIndex: 71857
	{
		// Fields
		[NonSerialized]
		public Hashes ancestorHashes; // 0x10
		[SerializeField]
		private int m_Specificity; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private StyleRule _rule_k__BackingField; // 0x28
		[NonSerialized]
		private bool m_isSimple; // 0x30
		[SerializeField]
		private StyleSelector[] m_Selectors; // 0x38
		[SerializeField]
		internal int ruleIndex; // 0x40
		[NonSerialized]
		internal StyleComplexSelector nextInTable; // 0x48
		[NonSerialized]
		internal int orderInStyleSheet; // 0x50
		private static Dictionary<string, PseudoStateData> s_PseudoStates; // 0x00
		private static List<StyleSelectorPart> m_HashList; // 0x08
	
		// Properties
		public int specificity { get; } // 0x0000000187261360-0x0000000187261370 
		public StyleRule rule { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public bool isSimple { get; } // 0x0000000187261340-0x0000000187261350 
		public StyleSelector[] selectors { get; internal set; } // 0x00000001872615B0-0x00000001872615C0 0x000000018D67F28C-0x000000018D67F2C0
	
		// Nested types
		private struct PseudoStateData // TypeDefIndex: 71855
		{
			// Fields
			public readonly PseudoStates state; // 0x00
			public readonly bool negate; // 0x04
	
			// Constructors
			public PseudoStateData(PseudoStates state, bool negate); // 0x000000018723C630-0x000000018723C640
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71856
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<StyleSelector, string> __9__24_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D6853C8-0x000000018D68542C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _ToString_b__24_0(StyleSelector x); // 0x000000018CE58DC0-0x000000018CE58DE0
		}
	
		// Constructors
		public StyleComplexSelector(); // 0x0000000186805BA0-0x0000000186805BB0
		static StyleComplexSelector(); // 0x000000018D67F1F8-0x000000018D67F28C
	
		// Methods
		public void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnAfterDeserialize(); // 0x000000018D67EFF4-0x000000018D67F018
		internal void CachePseudoStateMasks(); // 0x000000018D67E9E4-0x000000018D67EFF4
		public override string ToString(); // 0x000000018D67F018-0x000000018D67F1F8
	}

	[Serializable]
	internal class StyleProperty // TypeDefIndex: 71858
	{
		// Fields
		[SerializeField]
		private string m_Name; // 0x10
		[SerializeField]
		private int m_Line; // 0x18
		[SerializeField]
		private StyleValueHandle[] m_Values; // 0x20
		[NonSerialized]
		internal bool isCustomProperty; // 0x28
		[NonSerialized]
		internal bool requireVariableResolve; // 0x29
	
		// Properties
		public string name { get; } // 0x0000000187249840-0x0000000187249850 
		public StyleValueHandle[] values { get; } // 0x000000018725FED0-0x000000018725FEE0 
	
		// Constructors
		public StyleProperty(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	internal class StyleRule // TypeDefIndex: 71859
	{
		// Fields
		[SerializeField]
		private StyleProperty[] m_Properties; // 0x10
		[SerializeField]
		internal int line; // 0x18
		[NonSerialized]
		internal int customPropertiesCount; // 0x1C
	
		// Properties
		public StyleProperty[] properties { get; } // 0x0000000187249840-0x0000000187249850 
	
		// Constructors
		public StyleRule(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	internal class StyleSelector // TypeDefIndex: 71861
	{
		// Fields
		[SerializeField]
		private StyleSelectorPart[] m_Parts; // 0x10
		[SerializeField]
		private StyleSelectorRelationship m_PreviousRelationship; // 0x18
		internal int pseudoStateMask; // 0x1C
		internal int negatedPseudoStateMask; // 0x20
	
		// Properties
		public StyleSelectorPart[] parts { get; internal set; } // 0x0000000187249840-0x0000000187249850 0x0000000184FD2410-0x0000000184FD2420
		public StyleSelectorRelationship previousRelationship { get; internal set; } // 0x000000018724B960-0x000000018724B970 0x000000018442F470-0x000000018442F480
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71860
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<StyleSelectorPart, string> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D68529C-0x000000018D685300
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _ToString_b__10_0(StyleSelectorPart p); // 0x000000018D685200-0x000000018D685214
		}
	
		// Constructors
		public StyleSelector(); // 0x0000000187263C20-0x0000000187263C30
	
		// Methods
		public override string ToString(); // 0x000000018D67F484-0x000000018D67F638
	}

	[Serializable]
	internal struct StyleSelectorPart // TypeDefIndex: 71862
	{
		// Fields
		[SerializeField]
		private string m_Value; // 0x00
		[SerializeField]
		private StyleSelectorType m_Type; // 0x08
		internal object tempData; // 0x10
	
		// Properties
		public string value { get; } // 0x000000018514D010-0x000000018514D0E0 
		public StyleSelectorType type { get; internal set; } // 0x000000018453A050-0x000000018453A060 0x0000000187235AA0-0x0000000187235AB0
	
		// Methods
		public override string ToString(); // 0x000000018D67F3AC-0x000000018D67F484
		public static StyleSelectorPart CreateClass(string className); // 0x000000018D67F2C0-0x000000018D67F310
		public static StyleSelectorPart CreateId(string Id); // 0x000000018D67F310-0x000000018D67F360
		public static StyleSelectorPart CreatePredicate(object predicate); // 0x000000018D67F360-0x000000018D67F3AC
	}

	internal enum StyleSelectorRelationship // TypeDefIndex: 71863
	{
		None = 0,
		Child = 1,
		Descendent = 2
	}

	internal enum StyleSelectorType // TypeDefIndex: 71864
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
	public class StyleSheet : ScriptableObject // TypeDefIndex: 71866
	{
		// Fields
		[SerializeField]
		private bool m_ImportedWithErrors; // 0x18
		[SerializeField]
		private bool m_ImportedWithWarnings; // 0x19
		[SerializeField]
		private StyleRule[] m_Rules; // 0x20
		[SerializeField]
		private StyleComplexSelector[] m_ComplexSelectors; // 0x28
		[SerializeField]
		internal float[] floats; // 0x30
		[SerializeField]
		internal Dimension[] dimensions; // 0x38
		[SerializeField]
		internal UnityEngine.Color[] colors; // 0x40
		[SerializeField]
		internal string[] strings; // 0x48
		[SerializeField]
		internal UnityEngine.Object[] assets; // 0x50
		[SerializeField]
		internal ImportStruct[] imports; // 0x58
		[SerializeField]
		private List<StyleSheet> m_FlattenedImportedStyleSheets; // 0x60
		[SerializeField]
		private int m_ContentHash; // 0x68
		[SerializeField]
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
		public bool importedWithErrors { get; internal set; } // 0x0000000187263C50-0x0000000187263C60 0x000000018225E060-0x000000018225E070
		public bool importedWithWarnings { get; internal set; } // 0x0000000187263C60-0x0000000187263C70 0x000000018225E020-0x000000018225E030
		internal StyleRule[] rules { get; set; } // 0x000000018725FED0-0x000000018725FEE0 0x000000018D6809DC-0x000000018D680A00
		internal StyleComplexSelector[] complexSelectors { get; set; } // 0x0000000187261370-0x0000000187261380 0x000000018D680888-0x000000018D6808AC
		internal List<StyleSheet> flattenedRecursiveImports { get; } // 0x0000000187261F00-0x0000000187261F10 
		public int contentHash { get; set; } // 0x0000000187263C40-0x0000000187263C50 0x0000000185B8E660-0x0000000185B8E8A0
		internal bool isDefaultStyleSheet { get; set; } // 0x0000000187263C70-0x0000000187263C80 0x000000018D6808AC-0x000000018D6809DC
	
		// Nested types
		[Serializable]
		internal struct ImportStruct // TypeDefIndex: 71865
		{
			// Fields
			public StyleSheet styleSheet; // 0x00
			public string[] mediaQueries; // 0x08
		}
	
		// Constructors
		public StyleSheet(); // 0x0000000185DD6260-0x0000000185DD6270
		static StyleSheet(); // 0x000000018D68082C-0x000000018D680888
	
		// Methods
		private static bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out ref T value);
		private static T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle);
		internal virtual void OnEnable(); // 0x000000018D67F870-0x000000018D67F878
		internal void FlattenImportedStyleSheetsRecursive(); // 0x000000018D67F7EC-0x000000018D67F870
		private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet); // 0x000000018D67F6EC-0x000000018D67F7EC
		private void SetupReferences(); // 0x000000018D67FE84-0x000000018D680354
		internal StyleValueKeyword ReadKeyword(StyleValueHandle handle); // 0x0000000187263C30-0x0000000187263C40
		internal float ReadFloat(StyleValueHandle handle); // 0x000000018D67FA94-0x000000018D67FB3C
		internal bool TryReadFloat(StyleValueHandle handle, out float value); // 0x000000018D6805C8-0x000000018D6806AC
		internal Dimension ReadDimension(StyleValueHandle handle); // 0x000000018D67F978-0x000000018D67FA28
		internal bool TryReadDimension(StyleValueHandle handle, out Dimension value); // 0x000000018D680454-0x000000018D680548
		internal UnityEngine.Color ReadColor(StyleValueHandle handle); // 0x000000018D67F8E4-0x000000018D67F978
		internal bool TryReadColor(StyleValueHandle handle, out UnityEngine.Color value); // 0x000000018D6803D4-0x000000018D680454
		internal string ReadString(StyleValueHandle handle); // 0x000000018D67FDAC-0x000000018D67FE18
		internal bool TryReadString(StyleValueHandle handle, out string value); // 0x000000018D68072C-0x000000018D6807AC
		internal string ReadEnum(StyleValueHandle handle); // 0x000000018D67FA28-0x000000018D67FA94
		internal bool TryReadEnum(StyleValueHandle handle, out string value); // 0x000000018D680548-0x000000018D6805C8
		internal string ReadVariable(StyleValueHandle handle); // 0x000000018D67FE18-0x000000018D67FE84
		internal bool TryReadVariable(StyleValueHandle handle, out string value); // 0x000000018D6807AC-0x000000018D68082C
		internal string ReadResourcePath(StyleValueHandle handle); // 0x000000018D67FCAC-0x000000018D67FD18
		internal bool TryReadResourcePath(StyleValueHandle handle, out string value); // 0x000000018D6806AC-0x000000018D68072C
		internal UnityEngine.Object ReadAssetReference(StyleValueHandle handle); // 0x000000018D67F878-0x000000018D67F8E4
		internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle); // 0x000000018D67FC40-0x000000018D67FCAC
		internal bool TryReadAssetReference(StyleValueHandle handle, out UnityEngine.Object value); // 0x000000018D680354-0x000000018D6803D4
		internal StyleValueFunction ReadFunction(StyleValueHandle handle); // 0x0000000187263C30-0x0000000187263C40
		internal string ReadFunctionName(StyleValueHandle handle); // 0x000000018D67FB3C-0x000000018D67FC40
		internal ScalableImage ReadScalableImage(StyleValueHandle handle); // 0x000000018D67FD18-0x000000018D67FDAC
		private static bool CustomStartsWith(string originalString, string pattern); // 0x000000018D67F638-0x000000018D67F6EC
	}

	internal enum StyleValueFunction // TypeDefIndex: 71867
	{
		Unknown = 0,
		Var = 1,
		Env = 2,
		LinearGradient = 3
	}

	internal static class StyleValueFunctionExtension // TypeDefIndex: 71868
	{
		// Extension methods
		public static string ToUssString(this StyleValueFunction svf); // 0x000000018D680A00-0x000000018D680B1C
	}

	[Serializable]
	internal struct StyleValueHandle // TypeDefIndex: 71869
	{
		// Fields
		[SerializeField]
		private StyleValueType m_ValueType; // 0x00
		[SerializeField]
		internal int valueIndex; // 0x04
	
		// Properties
		public StyleValueType valueType { get; internal set; } // 0x000000018725FD00-0x000000018725FD10 0x0000000184547F40-0x0000000184547F50
	}

	internal enum StyleValueKeyword // TypeDefIndex: 71870
	{
		Inherit = 0,
		Initial = 1,
		Auto = 2,
		Unset = 3,
		True = 4,
		False = 5,
		None = 6
	}

	internal static class StyleValueKeywordExtension // TypeDefIndex: 71871
	{
		// Extension methods
		public static string ToUssString(this StyleValueKeyword svk); // 0x000000018D680B1C-0x000000018D680CB0
	}

	internal enum StyleValueType // TypeDefIndex: 71872
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

	internal struct StyleVariable // TypeDefIndex: 71873
	{
		// Fields
		public readonly string name; // 0x00
		public readonly StyleSheet sheet; // 0x08
		public readonly StyleValueHandle[] handles; // 0x10
	
		// Constructors
		public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles); // 0x000000018602B6E0-0x000000018602B710
	
		// Methods
		public override int GetHashCode(); // 0x000000018D6820B0-0x000000018D682124
	}

	internal class StyleVariableContext // TypeDefIndex: 71875
	{
		// Fields
		public static readonly StyleVariableContext none; // 0x00
		private int m_VariableHash; // 0x10
		private List<StyleVariable> m_Variables; // 0x18
		private List<int> m_SortedHash; // 0x20
		private List<int> m_UnsortedHash; // 0x28
	
		// Nested types
		[CompilerGenerated]
		private struct __c__DisplayClass7_0 // TypeDefIndex: 71874
		{
			// Fields
			public int hash; // 0x00
		}
	
		// Constructors
		public StyleVariableContext(); // 0x000000018D681310-0x000000018D681408
		public StyleVariableContext(StyleVariableContext other); // 0x000000018D6811E0-0x000000018D681310
		static StyleVariableContext(); // 0x000000018D681170-0x000000018D6811E0
	
		// Methods
		public void Add(StyleVariable sv); // 0x000000018D680DAC-0x000000018D680FD4
		public void AddInitialRange(StyleVariableContext other); // 0x000000018D680CB0-0x000000018D680DAC
		public void Clear(); // 0x000000018D680FD4-0x000000018D681068
		public bool TryFindVariable(string name, out StyleVariable v); // 0x000000018D681068-0x000000018D681170
		public int GetVariableHash(); // 0x000000018725FFC0-0x000000018725FFD0
		[CompilerGenerated]
		internal static int _Add_g__ComputeOrderSensitiveHash_7_0(int index, ref __c__DisplayClass7_0 param_0009be2b); // 0x0000000187263C80-0x0000000187263C90
	}

	internal class StyleVariableResolver // TypeDefIndex: 71878
	{
		// Fields
		internal const int kMaxResolves = 100; // Metadata: 0x02622561
		private static StyleSyntaxParser s_SyntaxParser; // 0x00
		private StylePropertyValueMatcher m_Matcher; // 0x10
		private List<StylePropertyValue> m_ResolvedValues; // 0x18
		private Stack<string> m_ResolvedVarStack; // 0x20
		private StyleProperty m_Property; // 0x28
		private Stack<ResolveContext> m_ContextStack; // 0x30
		private ResolveContext m_CurrentContext; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private StyleVariableContext _variableContext_k__BackingField; // 0x48
	
		// Properties
		private StyleSheet currentSheet { get; } // 0x0000000182986470-0x0000000182986480 
		private StyleValueHandle[] currentHandles { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public List<StylePropertyValue> resolvedValues { get; } // 0x0000000182234E30-0x0000000182234E40 
		public StyleVariableContext variableContext { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
	
		// Nested types
		private enum Result // TypeDefIndex: 71876
		{
			Valid = 0,
			Invalid = 1,
			NotFound = 2
		}
	
		private struct ResolveContext // TypeDefIndex: 71877
		{
			// Fields
			public StyleSheet sheet; // 0x00
			public StyleValueHandle[] handles; // 0x08
		}
	
		// Constructors
		public StyleVariableResolver(); // 0x000000018D681F6C-0x000000018D6820B0
		static StyleVariableResolver(); // 0x000000018D681EF0-0x000000018D681F6C
	
		// Methods
		public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles); // 0x000000018D681490-0x000000018D68153C
		private void PushContext(StyleSheet sheet, StyleValueHandle[] handles); // 0x000000018D681664-0x000000018D68170C
		private void PopContext(); // 0x000000018D6815E0-0x000000018D681664
		public void AddValue(StyleValueHandle handle); // 0x000000018D681408-0x000000018D681490
		public bool ResolveVarFunction(ref int index); // 0x000000018D681A54-0x000000018D681B24
		private Result ResolveVarFunction(ref int index, int argc, string varName); // 0x000000018D68192C-0x000000018D681A54
		public bool ValidateResolvedValues(); // 0x000000018D681DAC-0x000000018D681EF0
		private Result ResolveVariable(string variableName); // 0x000000018D681B24-0x000000018D681DAC
		private Result ResolveFallback(ref int index); // 0x000000018D68170C-0x000000018D68192C
		private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName); // 0x000000018D68153C-0x000000018D6815E0
	}

	[Serializable]
	public class ThemeStyleSheet : StyleSheet // TypeDefIndex: 71879
	{
		// Constructors
		public ThemeStyleSheet(); // 0x000000018D684914-0x000000018D684960
	
		// Methods
		internal override void OnEnable(); // 0x000000018D6848F0-0x000000018D684914
	}

	public class PanelTextSettings : TextSettings // TypeDefIndex: 71880
	{
		// Fields
		private static PanelTextSettings s_DefaultPanelTextSettings; // 0x00
		internal static Func<string, UnityEngine.Object> EditorGUIUtilityLoad; // 0x08
		internal static Func<SystemLanguage> GetCurrentLanguage; // 0x10
		internal static readonly string s_DefaultEditorPanelTextSettingPath; // 0x18
	
		// Properties
		internal static PanelTextSettings defaultPanelTextSettings { get; } // 0x000000018D67E1E4-0x000000018D67E2F4 
	
		// Constructors
		public PanelTextSettings(); // 0x000000018D67E1DC-0x000000018D67E1E4
		static PanelTextSettings(); // 0x000000018D67E17C-0x000000018D67E1DC
	
		// Methods
		internal static void UpdateLocalizationFontAsset(); // 0x000000018D67DD40-0x000000018D67E17C
		internal FontAsset GetCachedFontAsset(Font font); // 0x000000018D67DD34-0x000000018D67DD40
	}

	internal interface ITextHandle // TypeDefIndex: 71881
	{
		// Properties
		Vector2 MeasuredSizes { set; }
		Vector2 RoundedSizes { set; }
	
		// Methods
		Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling);
		float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling);
		float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling);
		float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
		TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
		bool IsLegacy();
		bool IsElided();
	}

	internal struct TextCoreHandle : ITextHandle // TypeDefIndex: 71882
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _MeasuredSizes_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _RoundedSizes_k__BackingField; // 0x08
		private Vector2 m_PreferredSize; // 0x10
		private int m_PreviousGenerationSettingsHash; // 0x18
		private UnityEngine.TextCore.Text.TextGenerationSettings m_CurrentGenerationSettings; // 0x20
		private static UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings; // 0x00
		private TextInfo m_TextInfoMesh; // 0x28
		private static TextInfo s_TextInfoLayout; // 0x08
		private bool isDirty; // 0x30
	
		// Properties
		public Vector2 MeasuredSizes { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x00000001872358F0-0x0000000187235910 0x000000018561B5B0-0x000000018561B5C0
		public Vector2 RoundedSizes { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] set; } // 0x000000018724A700-0x000000018724A720 0x000000018561B590-0x000000018561B5A0
		internal TextInfo textInfoMesh { get; } // 0x000000018D683364-0x000000018D6833D4 
		internal static TextInfo textInfoLayout { get; } // 0x000000018D683298-0x000000018D683364 
	
		// Constructors
		static TextCoreHandle(); // 0x000000018D68321C-0x000000018D683298
	
		// Methods
		public static ITextHandle New(); // 0x000000018D6826F4-0x000000018D6827B8
		public bool IsLegacy(); // 0x0000000187232850-0x0000000187232860
		public bool IsDirty(MeshGenerationContextUtils.TextParams parms); // 0x000000018D68266C-0x000000018D6826A0
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling); // 0x000000018D682324-0x000000018D6823B4
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling); // 0x000000018D682268-0x000000018D682324
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling); // 0x000000018D6821AC-0x000000018D682268
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint); // 0x000000018D6823B4-0x000000018D6824B0
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint); // 0x000000018D682F44-0x000000018D68321C
		private void UpdatePreferredValues(MeshGenerationContextUtils.TextParams parms); // 0x000000018D682E0C-0x000000018D682F44
		private static TextOverflowMode GetTextOverflowMode(MeshGenerationContextUtils.TextParams textParams); // 0x000000018D6824B0-0x000000018D68266C
		private static void UpdateGenerationSettingsCommon(MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings); // 0x000000018D6827B8-0x000000018D682E0C
		public bool IsElided(); // 0x000000018D6826A0-0x000000018D6826F4
	}

	internal struct TextNativeHandle : ITextHandle // TypeDefIndex: 71883
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _MeasuredSizes_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Vector2 _RoundedSizes_k__BackingField; // 0x08
		internal NativeArray<UnityEngine.UIElements.TextVertex> textVertices; // 0x10
		private int m_PreviousTextParamsHash; // 0x20
	
		// Properties
		public Vector2 MeasuredSizes { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872358F0-0x0000000187235910 0x000000018561B5B0-0x000000018561B5C0
		public Vector2 RoundedSizes { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018724A700-0x000000018724A720 0x000000018561B590-0x000000018561B5A0
	
		// Methods
		public static ITextHandle New(); // 0x000000018D68389C-0x000000018D6838F8
		public bool IsLegacy(); // 0x0000000187249050-0x0000000187249060
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint); // 0x000000018D6835E4-0x000000018D683674
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint); // 0x000000018D6838F8-0x000000018D683948
		public NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(MeshGenerationContextUtils.TextParams parms, float scaling); // 0x000000018D683674-0x000000018D68389C
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling); // 0x000000018D683568-0x000000018D6835E4
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling); // 0x000000018D683488-0x000000018D683568
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling); // 0x000000018D6833D4-0x000000018D683488
		public bool IsElided(); // 0x0000000187232850-0x0000000187232860
	}

	internal static class TextUtilities // TypeDefIndex: 71884
	{
		// Methods
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint); // 0x000000018D683948-0x000000018D6839D8
		internal static Vector2 MeasureVisualElementTextSize(VisualElement ve, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, ITextHandle textHandle); // 0x000000018D6844EC-0x000000018D6848F0
		internal static FontAsset GetFontAsset(MeshGenerationContextUtils.TextParams textParam); // 0x000000018D6839D8-0x000000018D683B4C
		internal static FontAsset GetFontAsset(VisualElement ve); // 0x000000018D683B4C-0x000000018D683C84
		internal static Font GetFont(MeshGenerationContextUtils.TextParams textParam); // 0x000000018D683C84-0x000000018D683DDC
		internal static Font GetFont(VisualElement ve); // 0x000000018D683DDC-0x000000018D683F24
		internal static bool IsFontAssigned(VisualElement ve); // 0x000000018D684440-0x000000018D6844EC
		internal static bool IsFontAssigned(MeshGenerationContextUtils.TextParams textParams); // 0x000000018D684374-0x000000018D684440
		internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve); // 0x000000018D684208-0x000000018D684290
		internal static PanelTextSettings GetTextSettingsFrom(MeshGenerationContextUtils.TextParams textParam); // 0x000000018D684290-0x000000018D684374
		internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve); // 0x000000018D683F24-0x000000018D684208
	}

	public interface IUxmlAttributes // TypeDefIndex: 71885
	{
		// Methods
		bool TryGetAttributeValue(string attributeName, out string value);
	}

	public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits> // TypeDefIndex: 71886
	{
		// Properties
		public override string uxmlName { get; } // 0x000000018D688A10-0x000000018D688A3C 
		public override string uxmlQualifiedName { get; } // 0x000000018D688A3C-0x000000018D688AB0 
	
		// Constructors
		public UxmlRootElementFactory(); // 0x000000018D6889D4-0x000000018D688A10
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc); // 0x000000018724EFC0-0x000000018724EFD0
	}

	public class UxmlRootElementTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 71887
	{
		// Fields
		protected UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Class; // 0x20
	
		// Constructors
		public UxmlRootElementTraits(); // 0x000000018D688AB0-0x000000018D688B84
	}

	public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits> // TypeDefIndex: 71888
	{
		// Properties
		public override string uxmlName { get; } // 0x000000018D688F18-0x000000018D688F44 
		public override string uxmlQualifiedName { get; } // 0x000000018D688F44-0x000000018D688FB8 
	
		// Constructors
		public UxmlStyleFactory(); // 0x000000018D688EDC-0x000000018D688F18
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc); // 0x000000018724EFC0-0x000000018724EFD0
	}

	public class UxmlStyleTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 71889
	{
		// Fields
		private UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Path; // 0x20
		private UxmlStringAttributeDescription m_Src; // 0x28
	
		// Constructors
		public UxmlStyleTraits(); // 0x000000018D688FB8-0x000000018D6890DC
	}

	public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits> // TypeDefIndex: 71890
	{
		// Properties
		public override string uxmlName { get; } // 0x000000018D689118-0x000000018D689144 
		public override string uxmlQualifiedName { get; } // 0x000000018D689144-0x000000018D6891B8 
	
		// Constructors
		public UxmlTemplateFactory(); // 0x000000018D6890DC-0x000000018D689118
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc); // 0x000000018724EFC0-0x000000018724EFD0
	}

	public class UxmlTemplateTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 71891
	{
		// Fields
		private UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Path; // 0x20
		private UxmlStringAttributeDescription m_Src; // 0x28
	
		// Constructors
		public UxmlTemplateTraits(); // 0x000000018D6891B8-0x000000018D6892E4
	}

	public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits> // TypeDefIndex: 71892
	{
		// Properties
		public override string uxmlName { get; } // 0x000000018D6872D0-0x000000018D6872FC 
		public override string uxmlQualifiedName { get; } // 0x000000018D6872FC-0x000000018D687370 
	
		// Constructors
		public UxmlAttributeOverridesFactory(); // 0x000000018D687294-0x000000018D6872D0
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc); // 0x000000018724EFC0-0x000000018724EFD0
	}

	public class UxmlAttributeOverridesTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 71893
	{
		// Fields
		private UxmlStringAttributeDescription m_ElementName; // 0x18
	
		// Constructors
		public UxmlAttributeOverridesTraits(); // 0x000000018D687370-0x000000018D687400
	}

	[Serializable]
	internal class TemplateAsset : VisualElementAsset // TypeDefIndex: 71895
	{
		// Fields
		[SerializeField]
		private string m_TemplateAlias; // 0x70
		[SerializeField]
		private List<AttributeOverride> m_AttributeOverrides; // 0x78
		[SerializeField]
		private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages; // 0x80
	
		// Properties
		public List<AttributeOverride> attributeOverrides { get; } // 0x000000018D682124-0x000000018D6821AC 
		internal List<VisualTreeAsset.SlotUsageEntry> slotUsages { get; } // 0x0000000187261FA0-0x0000000187261FB0 
	
		// Nested types
		[Serializable]
		public struct AttributeOverride // TypeDefIndex: 71894
		{
			// Fields
			public string m_ElementName; // 0x00
			public string m_AttributeName; // 0x08
			public string m_Value; // 0x10
		}
	}

	public abstract class UxmlAttributeDescription // TypeDefIndex: 71897
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _name_k__BackingField; // 0x10
		private string[] m_ObsoleteNames; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _type_k__BackingField; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _typeNamespace_k__BackingField; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Use _use_k__BackingField; // 0x30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UxmlTypeRestriction _restriction_k__BackingField; // 0x38
	
		// Properties
		public string name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public IEnumerable<string> obsoleteNames { set; } // 0x000000018D687240-0x000000018D687294
		protected string type { [CompilerGenerated] set; } // 0x0000000187835950-0x0000000187835960
		protected string typeNamespace { [CompilerGenerated] set; } // 0x0000000185CA30F0-0x0000000185CA3100
		public Use use { [CompilerGenerated] set; } // 0x0000000186033510-0x0000000186033520
		public UxmlTypeRestriction restriction { [CompilerGenerated] set; } // 0x0000000186AB5C00-0x0000000186AB5C10
	
		// Nested types
		public enum Use // TypeDefIndex: 71896
		{
			None = 0,
			Optional = 1,
			Prohibited = 2,
			Required = 3
		}
	
		// Constructors
		protected UxmlAttributeDescription(); // 0x000000018B8D4630-0x000000018B8D4648
	
		// Methods
		internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value); // 0x000000018D686EC0-0x000000018D687240
		protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref ref T value);
		protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue);
	}

	public abstract class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription // TypeDefIndex: 71898
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private T _defaultValue_k__BackingField;
	
		// Properties
		public T defaultValue { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		protected TypedUxmlAttributeDescription();
	
		// Methods
		public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
	}

	public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string> // TypeDefIndex: 71900
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71899
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, string, string> __9__3_0; // 0x08
			public static Func<string, string, string> __9__4_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D685364-0x000000018D6853C8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _GetValueFromBag_b__3_0(string s, string t); // 0x000000018459BB50-0x000000018459BB60
			internal string _TryGetValueFromBag_b__4_0(string s, string t); // 0x000000018459BB50-0x000000018459BB60
		}
	
		// Constructors
		public UxmlStringAttributeDescription(); // 0x000000018D688E34-0x000000018D688EDC
	
		// Methods
		public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc); // 0x000000018D688B84-0x000000018D688CD8
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value); // 0x000000018D688CD8-0x000000018D688E34
	}

	public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<float> // TypeDefIndex: 71902
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71901
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, float, float> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D685238-0x000000018D68529C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _GetValueFromBag_b__3_0(string s, float f); // 0x000000018D6851F0-0x000000018D685200
		}
	
		// Constructors
		public UxmlFloatAttributeDescription(); // 0x000000018D687A04-0x000000018D687A88
	
		// Methods
		public override float GetValueFromBag(IUxmlAttributes bag, CreationContext cc); // 0x000000018D6878AC-0x000000018D687A04
		private static float ConvertValueToFloat(string v, float defaultValue); // 0x000000018D687828-0x000000018D6878AC
	}

	public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int> // TypeDefIndex: 71904
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71903
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, int, int> __9__3_0; // 0x08
			public static Func<string, int, int> __9__4_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D68542C-0x000000018D685490
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _GetValueFromBag_b__3_0(string s, int i); // 0x000000018D6851B8-0x000000018D6851C8
			internal int _TryGetValueFromBag_b__4_0(string s, int i); // 0x000000018D6851B8-0x000000018D6851C8
		}
	
		// Constructors
		public UxmlIntAttributeDescription(); // 0x000000018D687D68-0x000000018D687DF8
	
		// Methods
		public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc); // 0x000000018D687ABC-0x000000018D687C10
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value); // 0x000000018D687C10-0x000000018D687D68
		private static int ConvertValueToInt(string v, int defaultValue); // 0x000000018D687A88-0x000000018D687ABC
	}

	public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long> // TypeDefIndex: 71906
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71905
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, long, long> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D685490-0x000000018D6854F4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal long _GetValueFromBag_b__3_0(string s, long l); // 0x000000018D6851C8-0x000000018D6851DC
		}
	
		// Constructors
		public UxmlLongAttributeDescription(); // 0x000000018D687F84-0x000000018D688014
	
		// Methods
		public override long GetValueFromBag(IUxmlAttributes bag, CreationContext cc); // 0x000000018D687E30-0x000000018D687F84
		private static long ConvertValueToLong(string v, long defaultValue); // 0x000000018D687DF8-0x000000018D687E30
	}

	public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool> // TypeDefIndex: 71908
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71907
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, bool, bool> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D685300-0x000000018D685364
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetValueFromBag_b__3_0(string s, bool b); // 0x000000018D6851DC-0x000000018D6851F0
		}
	
		// Constructors
		public UxmlBoolAttributeDescription(); // 0x000000018D6875BC-0x000000018D687648
	
		// Methods
		public override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc); // 0x000000018D687468-0x000000018D6875BC
		private static bool ConvertValueToBool(string v, bool defaultValue); // 0x000000018D687400-0x000000018D687468
	}

	public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> // TypeDefIndex: 71910
		where T : struct, IConvertible
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71909
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<string, T, T> __9__3_0;
			public static Func<string, T, T> __9__4_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal T _GetValueFromBag_b__3_0(string s, T convertible);
			internal T _TryGetValueFromBag_b__4_0(string s, T convertible);
		}
	
		// Constructors
		public UxmlEnumAttributeDescription();
	
		// Methods
		public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref ref T value);
		private static U ConvertValueToEnum<U>(string v, U defaultValue);
	}

	internal class UxmlObjectAttributeDescription<T> // TypeDefIndex: 71911
		where T : new()
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private T _defaultValue_k__BackingField;
	
		// Properties
		public T defaultValue { [CompilerGenerated] get; }
	
		// Constructors
		public UxmlObjectAttributeDescription();
	
		// Methods
		public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
	}

	internal class UxmlObjectListAttributeDescription<T> : UxmlObjectAttributeDescription<List<T>> // TypeDefIndex: 71912
		where T : new()
	{
		// Constructors
		public UxmlObjectListAttributeDescription();
	
		// Methods
		public override List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
	}

	public abstract class UxmlTraits // TypeDefIndex: 71913
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _canHaveAnyAttribute_k__BackingField; // 0x10
	
		// Properties
		protected bool canHaveAnyAttribute { [CompilerGenerated] set; } // 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		protected UxmlTraits(); // 0x00000001829D07F0-0x00000001829D0800
	
		// Methods
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface IUxmlFactory // TypeDefIndex: 71914
	{
		// Properties
		string uxmlQualifiedName { get; }
	
		// Methods
		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
		VisualElement Create(IUxmlAttributes bag, CreationContext cc);
	}

	public class UxmlFactory<TCreatedType, TTraits> : IUxmlFactory // TypeDefIndex: 71915
		where TCreatedType : VisualElement, new()
		where TTraits : UnityEngine.UIElements.UxmlTraits, new()
	{
		// Fields
		internal TTraits m_Traits;
	
		// Properties
		public virtual string uxmlName { get; }
		public virtual string uxmlNamespace { get; }
		public virtual string uxmlQualifiedName { get; }
	
		// Constructors
		protected UxmlFactory();
	
		// Methods
		public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
		public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc);
	}

	public class UxmlFactory<TCreatedType> : UxmlFactory<TCreatedType, VisualElement.UxmlTraits> // TypeDefIndex: 71916
		where TCreatedType : VisualElement, new()
	{
		// Constructors
		public UxmlFactory();
	}

	public abstract class BaseUxmlTraits // TypeDefIndex: 71917
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _canHaveAnyAttribute_k__BackingField; // 0x10
	
		// Properties
		protected bool canHaveAnyAttribute { [CompilerGenerated] set; } // 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		protected BaseUxmlTraits(); // 0x00000001829D07F0-0x00000001829D0800
	}

	internal abstract class UxmlObjectTraits<T> : BaseUxmlTraits // TypeDefIndex: 71918
	{
		// Constructors
		protected UxmlObjectTraits();
	
		// Methods
		public virtual void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc);
	}

	public interface IBaseUxmlFactory // TypeDefIndex: 71919
	{
		// Properties
		string uxmlQualifiedName { get; }
	
		// Methods
		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
	}

	internal interface IBaseUxmlObjectFactory : IBaseUxmlFactory // TypeDefIndex: 71920
	{
	}

	internal interface IUxmlObjectFactory<out T> : IBaseUxmlObjectFactory // TypeDefIndex: 71921
		where T : new()
	{
		// Methods
		T CreateObject(IUxmlAttributes bag, CreationContext cc);
	}

	internal class UxmlObjectFactory<TCreatedType, TTraits> : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlObjectFactory<TCreatedType> // TypeDefIndex: 71922
		where TCreatedType : new()
		where TTraits : UxmlObjectTraits<TCreatedType>, new()
	{
		// Constructors
		public UxmlObjectFactory();
	
		// Methods
		public virtual TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc);
	}

	public abstract class BaseUxmlFactory<TCreatedType, TTraits> // TypeDefIndex: 71923
		where TCreatedType : new()
		where TTraits : BaseUxmlTraits, new()
	{
		// Fields
		internal TTraits m_Traits;
	
		// Properties
		public virtual string uxmlQualifiedName { get; }
	
		// Constructors
		protected BaseUxmlFactory();
	
		// Methods
		public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
	}

	[Serializable]
	internal class UxmlAsset : IUxmlAttributes // TypeDefIndex: 71924
	{
		// Fields
		[SerializeField]
		private string m_FullTypeName; // 0x10
		[SerializeField]
		private int m_Id; // 0x18
		[SerializeField]
		private int m_OrderInDocument; // 0x1C
		[SerializeField]
		private int m_ParentId; // 0x20
		[SerializeField]
		protected List<string> m_Properties; // 0x28
	
		// Properties
		public string fullTypeName { get; } // 0x00000001829260F0-0x0000000182926100 
		public int id { get; } // 0x00000001844AF510-0x00000001844AF520 
		public int orderInDocument { get; } // 0x0000000187233000-0x0000000187233010 
		public int parentId { get; } // 0x000000018226A850-0x000000018226A860 
	
		// Methods
		public bool TryGetAttributeValue(string propertyName, out string value); // 0x000000018D686DE0-0x000000018D686EC0
		public void SetAttribute(string name, string value); // 0x000000018D686C88-0x000000018D686C90
		private void SetOrAddProperty(string propertyName, string propertyValue); // 0x000000018D686C90-0x000000018D686DE0
	}

	[Serializable]
	internal sealed class UxmlObjectAsset : UxmlAsset // TypeDefIndex: 71925
	{
	}

	internal class UxmlObjectFactoryRegistry // TypeDefIndex: 71926
	{
		// Fields
		private static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories; // 0x00
	
		// Properties
		internal static Dictionary<string, List<IBaseUxmlObjectFactory>> factories { get; } // 0x000000018D688914-0x000000018D6889D4 
	
		// Methods
		protected static void RegisterFactory(IBaseUxmlObjectFactory factory); // 0x000000018D6881F8-0x000000018D688634
		internal static bool TryGetFactories(string fullTypeName, out List<IBaseUxmlObjectFactory> factoryList); // 0x000000018D6888B4-0x000000018D688914
		private static void RegisterEngineFactories(); // 0x000000018D688014-0x000000018D6881F8
		private static void RegisterUserFactories(); // 0x000000018D688634-0x000000018D6888B4
	}

	public abstract class UxmlTypeRestriction : IEquatable<UxmlTypeRestriction> // TypeDefIndex: 71927
	{
		// Constructors
		protected UxmlTypeRestriction(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual bool Equals(UxmlTypeRestriction other); // 0x0000000184F9DDF0-0x0000000184F9DE00
	}

	public class UxmlEnumeration : UxmlTypeRestriction // TypeDefIndex: 71928
	{
		// Fields
		private List<string> m_Values; // 0x10
	
		// Properties
		public IEnumerable<string> values { get; set; } // 0x0000000187249840-0x0000000187249850 0x000000018D6877D4-0x000000018D687828
	
		// Constructors
		public UxmlEnumeration(); // 0x000000018D68775C-0x000000018D6877D4
	
		// Methods
		public override bool Equals(UxmlTypeRestriction other); // 0x000000018D687648-0x000000018D68775C
	}

	[Serializable]
	internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver // TypeDefIndex: 71929
	{
		// Fields
		[SerializeField]
		private string m_Name; // 0x30
		[SerializeField]
		private int m_RuleIndex; // 0x38
		[SerializeField]
		private string m_Text; // 0x40
		[SerializeField]
		private PickingMode m_PickingMode; // 0x48
		[SerializeField]
		private string[] m_Classes; // 0x50
		[SerializeField]
		private List<string> m_StylesheetPaths; // 0x58
		[SerializeField]
		private List<StyleSheet> m_Stylesheets; // 0x60
		[SerializeField]
		private bool m_SkipClone; // 0x68
	
		// Properties
		public int ruleIndex { get; } // 0x000000018725FEC0-0x000000018725FED0 
		public string[] classes { get; } // 0x0000000187261FD0-0x0000000187261FE0 
		public List<string> stylesheetPaths { get; } // 0x000000018D68A25C-0x000000018D68A2E0 
		public bool hasStylesheetPaths { get; } // 0x000000018C1D8718-0x000000018C1D8724 
		public List<StyleSheet> stylesheets { get; } // 0x000000018D68A2E0-0x000000018D68A364 
		public bool hasStylesheets { get; } // 0x000000018D68A250-0x000000018D68A25C 
		internal bool skipClone { get; } // 0x000000018226EF80-0x000000018226EF90 
	
		// Methods
		public void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnAfterDeserialize(); // 0x000000018D68A0CC-0x000000018D68A250
	}

	internal class VisualElementFactoryRegistry // TypeDefIndex: 71930
	{
		// Fields
		private static Dictionary<string, List<IUxmlFactory>> s_Factories; // 0x00
	
		// Properties
		internal static Dictionary<string, List<IUxmlFactory>> factories { get; } // 0x000000018D68B508-0x000000018D68B5C8 
	
		// Methods
		protected static void RegisterFactory(IUxmlFactory factory); // 0x000000018D68ADE0-0x000000018D68B21C
		internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList); // 0x000000018D68B49C-0x000000018D68B508
		private static void RegisterEngineFactories(); // 0x000000018D68A364-0x000000018D68ADE0
		internal static void RegisterUserFactories(); // 0x000000018D68B21C-0x000000018D68B49C
	}

	[Serializable]
	public class VisualTreeAsset : ScriptableObject // TypeDefIndex: 71941
	{
		// Fields
		internal static string LinkedVEAInTemplatePropertyName; // 0x00
		[SerializeField]
		private bool m_ImportedWithErrors; // 0x18
		[SerializeField]
		private bool m_ImportedWithWarnings; // 0x19
		private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints; // 0x08
		[SerializeField]
		private List<UsingEntry> m_Usings; // 0x20
		[SerializeField]
		internal StyleSheet inlineSheet; // 0x28
		[SerializeField]
		private List<VisualElementAsset> m_VisualElementAssets; // 0x30
		[SerializeField]
		private List<TemplateAsset> m_TemplateAssets; // 0x38
		[SerializeField]
		private List<UxmlObjectEntry> m_UxmlObjectEntries; // 0x40
		[SerializeField]
		private List<int> m_UxmlObjectIds; // 0x48
		[SerializeField]
		private List<AssetEntry> m_AssetEntries; // 0x50
		[SerializeField]
		private List<SlotDefinition> m_Slots; // 0x58
		[SerializeField]
		private int m_ContentContainerId; // 0x60
		[SerializeField]
		private int m_ContentHash; // 0x64
	
		// Properties
		public bool importedWithErrors { get; internal set; } // 0x0000000187263C50-0x0000000187263C60 0x000000018225E060-0x000000018225E070
		public bool importedWithWarnings { get; internal set; } // 0x0000000187263C60-0x0000000187263C70 0x000000018225E020-0x000000018225E030
		public IEnumerable<VisualTreeAsset> templateDependencies { get; } // 0x000000018D68E0A4-0x000000018D68E114 
		public IEnumerable<StyleSheet> stylesheets { get; } // 0x000000018D68E034-0x000000018D68E0A4 
		internal List<VisualElementAsset> visualElementAssets { get; set; } // 0x00000001872613B0-0x00000001872613C0 0x000000018783BA80-0x000000018783BA90
		internal List<TemplateAsset> templateAssets { get; set; } // 0x00000001872615B0-0x00000001872615C0 0x0000000186AB5C00-0x0000000186AB5C10
		internal List<UxmlObjectEntry> uxmlObjectEntries { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		internal List<int> uxmlObjectIds { get; } // 0x000000018226EE80-0x000000018226EE90 
		internal List<SlotDefinition> slots { get; set; } // 0x0000000187261F10-0x0000000187261F20 0x00000001856B9750-0x00000001856B9760
		internal int contentContainerId { get; set; } // 0x0000000187262CF0-0x0000000187262D00 0x0000000185FF5E70-0x0000000185FF5F30
		public int contentHash { get; set; } // 0x0000000187263D50-0x0000000187263D60 0x0000000187233690-0x00000001872336A0
	
		// Nested types
		[Serializable]
		internal struct UsingEntry // TypeDefIndex: 71931
		{
			// Fields
			internal static readonly IComparer<UsingEntry> comparer; // 0x00
			[SerializeField]
			public string alias; // 0x00
			[SerializeField]
			public string path; // 0x08
			[SerializeField]
			public VisualTreeAsset asset; // 0x10
	
			// Constructors
			public UsingEntry(string alias, string path); // 0x000000018D686C54-0x000000018D686C88
			static UsingEntry(); // 0x000000018D686BE4-0x000000018D686C54
		}
	
		private class UsingEntryComparer : IComparer<UsingEntry> // TypeDefIndex: 71932
		{
			// Constructors
			public UsingEntryComparer(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public int Compare(UsingEntry x, UsingEntry y); // 0x000000018D686BC0-0x000000018D686BE4
		}
	
		[Serializable]
		internal struct SlotDefinition // TypeDefIndex: 71933
		{
			// Fields
			[SerializeField]
			public string name; // 0x00
			[SerializeField]
			public int insertionPointId; // 0x08
		}
	
		[Serializable]
		internal struct SlotUsageEntry // TypeDefIndex: 71934
		{
			// Fields
			[SerializeField]
			public string slotName; // 0x00
			[SerializeField]
			public int assetId; // 0x08
		}
	
		[Serializable]
		internal struct UxmlObjectEntry // TypeDefIndex: 71935
		{
			// Fields
			[SerializeField]
			public int parentId; // 0x00
			[SerializeField]
			public List<UxmlObjectAsset> uxmlObjectAssets; // 0x08
	
			// Constructors
			public UxmlObjectEntry(int parentId, List<UxmlObjectAsset> uxmlObjectAssets); // 0x000000018783C19C-0x000000018783C1AC
		}
	
		[Serializable]
		private struct AssetEntry // TypeDefIndex: 71936
		{
			// Fields
			[SerializeField]
			public string path; // 0x00
			[SerializeField]
			public string typeFullName; // 0x08
			[SerializeField]
			public UnityEngine.Object asset; // 0x10
			private System.Type m_CachedType; // 0x18
	
			// Properties
			public System.Type type { get; } // 0x000000018D6735C0-0x000000018D673648 
	
			// Constructors
			public AssetEntry(string path, System.Type type, UnityEngine.Object asset); // 0x000000018D673550-0x000000018D6735C0
		}
	
		[CompilerGenerated]
		private sealed class _get_templateDependencies_d__19 : IEnumerable<VisualTreeAsset>, IEnumerator<VisualTreeAsset> // TypeDefIndex: 71937
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
			VisualTreeAsset IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_templateDependencies_d__19(int __1__state); // 0x000000018B707D6C-0x000000018B707DA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D686B08-0x000000018D686B84
			private bool MoveNext(); // 0x000000018D6862C0-0x000000018D686A14
			private void __m__Finally1(); // 0x000000018D686B84-0x000000018D686BC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D686ABC-0x000000018D686B08
			[DebuggerHidden]
			IEnumerator<VisualTreeAsset> IEnumerable<VisualTreeAsset>.GetEnumerator(); // 0x000000018D686A14-0x000000018D686AB4
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D686AB4-0x000000018D686ABC
		}
	
		[CompilerGenerated]
		private sealed class _get_stylesheets_d__23 : IEnumerable<StyleSheet>, IEnumerator<StyleSheet> // TypeDefIndex: 71938
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
			StyleSheet IEnumerator<UnityEngine.UIElements.StyleSheet>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_stylesheets_d__23(int __1__state); // 0x000000018B707D6C-0x000000018B707DA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D6860B8-0x000000018D68620C
			private bool MoveNext(); // 0x000000018D6854F4-0x000000018D685FC4
			private void __m__Finally1(); // 0x000000018D68620C-0x000000018D686248
			private void __m__Finally2(); // 0x000000018D686248-0x000000018D686284
			private void __m__Finally3(); // 0x000000018D686284-0x000000018D6862C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D68606C-0x000000018D6860B8
			[DebuggerHidden]
			IEnumerator<StyleSheet> IEnumerable<StyleSheet>.GetEnumerator(); // 0x000000018D685FC4-0x000000018D686064
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D686064-0x000000018D68606C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0 // TypeDefIndex: 71939
		{
			// Fields
			public VisualElementAsset childVea; // 0x10
	
			// Constructors
			public __c__DisplayClass61_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CloneSetupRecursively_b__0(SlotUsageEntry u); // 0x000000018D685214-0x000000018D685238
		}
	
		[CompilerGenerated]
		private struct __c__DisplayClass65_0 // TypeDefIndex: 71940
		{
			// Fields
			public VisualElementAsset asset; // 0x00
		}
	
		// Constructors
		public VisualTreeAsset(); // 0x0000000185DD6260-0x0000000185DD6270
		static VisualTreeAsset(); // 0x000000018D68DF6C-0x000000018D68E034
	
		// Methods
		internal int GetNextChildSerialNumber(); // 0x000000018D68D1BC-0x000000018D68D23C
		internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset); // 0x000000018D68D930-0x000000018D68DB2C
		internal List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc)
			where T : new();
		internal bool AssetEntryExists(string path, System.Type type); // 0x000000018D68B5C8-0x000000018D68B758
		internal void RegisterAssetEntry(string path, System.Type type, UnityEngine.Object asset); // 0x000000018D68D81C-0x000000018D68D930
		internal T GetAsset<T>(string path)
			where T : UnityEngine.Object;
		internal UxmlObjectEntry GetUxmlObjectEntry(int id); // 0x000000018D68D23C-0x000000018D68D380
		private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset); // 0x000000018D68D380-0x000000018D68D6BC
		public TemplateContainer Instantiate(); // 0x000000018D68D6F8-0x000000018D68D81C
		public TemplateContainer Instantiate(string bindingPath); // 0x000000018D68D6BC-0x000000018D68D6F8
		public TemplateContainer CloneTree(); // 0x000000018D68CB5C-0x000000018D68CB68
		public TemplateContainer CloneTree(string bindingPath); // 0x000000018D68C9BC-0x000000018D68C9C8
		public void CloneTree(VisualElement target); // 0x000000018D68C298-0x000000018D68C2C0
		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount); // 0x000000018D68C9C8-0x000000018D68CB5C
		internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides); // 0x000000018D68C2C0-0x000000018D68C9BC
		private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context); // 0x000000018D68B970-0x000000018D68C298
		private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b); // 0x000000018D68CB68-0x000000018D68CB98
		internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName); // 0x000000018D68DD90-0x000000018D68DE50
		internal VisualTreeAsset ResolveTemplate(string templateName); // 0x000000018D68DB2C-0x000000018D68DD90
		internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx); // 0x000000018D68CB98-0x000000018D68D1BC
		private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element); // 0x000000018D68B758-0x000000018D68B7D0
		private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element); // 0x000000018D68B7D0-0x000000018D68B970
		[CompilerGenerated]
		internal static VisualElement _Create_g__CreateError_65_0(ref __c__DisplayClass65_0 param_0009bf26); // 0x000000018D68DE50-0x000000018D68DF6C
	}

	public struct CreationContext : IEquatable<CreationContext> // TypeDefIndex: 71942
	{
		// Fields
		public static readonly CreationContext Default; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _target_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualTreeAsset _visualTreeAsset_k__BackingField; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Dictionary<string, VisualElement> _slotInsertionPoints_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<TemplateAsset.AttributeOverride> _attributeOverrides_k__BackingField; // 0x18
	
		// Properties
		public VisualElement target { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public VisualTreeAsset visualTreeAsset { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public Dictionary<string, VisualElement> slotInsertionPoints { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		internal List<TemplateAsset.AttributeOverride> attributeOverrides { [CompilerGenerated] [IsReadOnly] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target); // 0x000000018D673A50-0x000000018D673ACC
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target); // 0x000000018D6739BC-0x000000018D673A50
		static CreationContext(); // 0x000000018D67397C-0x000000018D6739BC
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D6737BC-0x000000018D673848
		public bool Equals(CreationContext other); // 0x000000018D673648-0x000000018D6737BC
		public override int GetHashCode(); // 0x000000018D673848-0x000000018D67397C
	}
}

namespace UnityEngine.UIElements.Experimental
{
	public static class Easing // TypeDefIndex: 72078
	{
		// Methods
		public static float Linear(float t); // 0x000000018722B770-0x000000018722B780
		public static float InSine(float t); // 0x0000000187262FB0-0x0000000187262FE0
		public static float OutSine(float t); // 0x0000000187263000-0x0000000187263010
		public static float InOutSine(float t); // 0x0000000187262F60-0x0000000187262F90
		public static float InQuad(float t); // 0x0000000187262FA0-0x0000000187262FB0
		public static float OutQuad(float t); // 0x0000000187262FE0-0x0000000187263000
		public static float InOutQuad(float t); // 0x000000018D5F8938-0x000000018D5F897C
		public static float InCubic(float t); // 0x0000000187262F50-0x0000000187262F60
		public static float OutCubic(float t); // 0x000000018D5F89B0-0x000000018D5F89D8
		public static float InOutCubic(float t); // 0x000000018D5F8868-0x000000018D5F8878
		public static float InPower(float t, int power); // 0x0000000187262F90-0x0000000187262FA0
		public static float OutPower(float t, int power); // 0x000000018D5F8A68-0x000000018D5F8AAC
		public static float InOutPower(float t, int power); // 0x000000018D5F88C0-0x000000018D5F8938
		public static float InBounce(float t); // 0x000000018D5F8664-0x000000018D5F8698
		public static float OutBounce(float t); // 0x000000018CB50EE0-0x000000018CB50F78
		public static float InOutBounce(float t); // 0x000000018D5F8790-0x000000018D5F8800
		public static float InElastic(float t); // 0x000000018D5F8698-0x000000018D5F8720
		public static float OutElastic(float t); // 0x000000018D5F89D8-0x000000018D5F8A68
		public static float InOutElastic(float t); // 0x000000018D5F8878-0x000000018D5F88C0
		public static float InBack(float t); // 0x00000001872544B0-0x00000001872544D0
		public static float OutBack(float t); // 0x000000018D5F897C-0x000000018D5F89B0
		public static float InOutBack(float t); // 0x000000018D5F8720-0x000000018D5F8790
		public static float InCirc(float t); // 0x0000000187262EF0-0x0000000187262F50
		public static float OutCirc(float t); // 0x0000000187254560-0x0000000187254590
		public static float InOutCirc(float t); // 0x000000018D5F8800-0x000000018D5F8868
	}

	public struct StyleValues // TypeDefIndex: 72079
	{
		// Fields
		internal StyleValueCollection m_StyleValues; // 0x00
	
		// Properties
		public float top { set; } // 0x000000018D5FA140-0x000000018D5FA150
		public float left { set; } // 0x000000018D5FA090-0x000000018D5FA0A0
		public float width { set; } // 0x000000018D5FA174-0x000000018D5FA648
		public float height { set; } // 0x000000018D5FA080-0x000000018D5FA090
		public float right { set; } // 0x000000018D5FA130-0x000000018D5FA140
		public float bottom { set; } // 0x000000018D5FA03C-0x000000018D5FA04C
		public UnityEngine.Color color { set; } // 0x000000018D5FA04C-0x000000018D5FA070
		public UnityEngine.Color backgroundColor { set; } // 0x000000018D5F9F74-0x000000018D5F9F98
		public UnityEngine.Color unityBackgroundImageTintColor { set; } // 0x000000018D5FA150-0x000000018D5FA174
		public UnityEngine.Color borderColor { set; } // 0x000000018D5F9FC8-0x000000018D5F9FEC
		public float marginLeft { set; } // 0x000000018D5FA0B0-0x000000018D5FA0C0
		public float marginTop { set; } // 0x000000018D5FA0D0-0x000000018D5FA0E0
		public float marginRight { set; } // 0x000000018D5FA0C0-0x000000018D5FA0D0
		public float marginBottom { set; } // 0x000000018D5FA0A0-0x000000018D5FA0B0
		public float paddingLeft { set; } // 0x000000018D5FA100-0x000000018D5FA110
		public float paddingTop { get; set; } // 0x000000018D5F9F38-0x000000018D5F9F74 0x000000018D5FA120-0x000000018D5FA130
		public float paddingRight { set; } // 0x000000018D5FA110-0x000000018D5FA120
		public float paddingBottom { set; } // 0x000000018D5FA0F0-0x000000018D5FA100
		public float borderLeftWidth { set; } // 0x000000018D5F9FEC-0x000000018D5F9FFC
		public float borderRightWidth { set; } // 0x000000018D5F9FFC-0x000000018D5FA00C
		public float borderTopWidth { set; } // 0x000000018D5FA02C-0x000000018D5FA03C
		public float borderBottomWidth { set; } // 0x000000018D5F9FB8-0x000000018D5F9FC8
		public float borderTopLeftRadius { set; } // 0x000000018D5FA00C-0x000000018D5FA01C
		public float borderTopRightRadius { set; } // 0x000000018D5FA01C-0x000000018D5FA02C
		public float borderBottomLeftRadius { set; } // 0x000000018D5F9F98-0x000000018D5F9FA8
		public float borderBottomRightRadius { set; } // 0x000000018D5F9FA8-0x000000018D5F9FB8
		public float opacity { set; } // 0x000000018D5FA0E0-0x000000018D5FA0F0
		public float flexGrow { set; } // 0x000000018D5FA070-0x000000018D5FA080
		public float flexShrink { set; } // 0x000000018D5FA070-0x000000018D5FA080
	
		// Methods
		internal void SetValue(StylePropertyId id, float value); // 0x000000018D5F9E10-0x000000018D5F9E6C
		internal void SetValue(StylePropertyId id, UnityEngine.Color value); // 0x000000018D5F9E6C-0x000000018D5F9ECC
		internal StyleValueCollection Values(); // 0x000000018D5F9ECC-0x000000018D5F9F38
	}

	public interface ITransitionAnimations // TypeDefIndex: 72080
	{
		// Methods
		ValueAnimation<StyleValues> Start(StyleValues to, int durationMs);
	}

	internal static class Lerp // TypeDefIndex: 72081
	{
		// Methods
		public static float Interpolate(float start, float end, float ratio); // 0x0000000187260830-0x0000000187260850
		public static UnityEngine.Color Interpolate(UnityEngine.Color start, UnityEngine.Color end, float ratio); // 0x000000018D5F8AAC-0x000000018D5F8AF0
		internal static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio); // 0x000000018D5F8AF0-0x000000018D5F9088
	}

	internal interface IValueAnimationUpdate // TypeDefIndex: 72082
	{
		// Methods
		void Tick(long currentTimeMs);
	}

	public sealed class ValueAnimation<T> : IValueAnimationUpdate // TypeDefIndex: 72083
	{
		// Fields
		private long m_StartTimeMs;
		private int m_DurationMs;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<float, float> _easingCurve_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isRunning_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action _onAnimationCompleted_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _autoRecycle_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _recycled_k__BackingField;
		private static ObjectPool<ValueAnimation<T>> sObjectPool;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _owner_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<VisualElement, T> _valueUpdated_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<VisualElement, T> _initialValue_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Func<T, T, float, T> _interpolator_k__BackingField;
		private T _from;
		private bool fromValueSet;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private T _to_k__BackingField;
	
		// Properties
		public int durationMs { get; set; }
		public Func<float, float> easingCurve { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isRunning { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Action onAnimationCompleted { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool autoRecycle { [CompilerGenerated] get; [CompilerGenerated] set; }
		private bool recycled { [CompilerGenerated] get; [CompilerGenerated] set; }
		private VisualElement owner { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action<VisualElement, T> valueUpdated { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Func<VisualElement, T> initialValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Func<T, T, float, T> interpolator { [CompilerGenerated] get; [CompilerGenerated] set; }
		public T from { get; set; }
		public T to { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public ValueAnimation();
		static ValueAnimation();
	
		// Methods
		public void Start();
		public void Stop();
		public void Recycle();
		void IValueAnimationUpdate.Tick(long currentTimeMs);
		private void SetDefaultValues();
		private void Unregister();
		private void Register();
		internal void SetOwner(VisualElement e);
		private void CheckNotRecycled();
		public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator);
		public ValueAnimation<T> KeepAlive();
	}
}

namespace UnityEngine.UIElements.Internal
{
	internal class MultiColumnHeaderColumnMovePreview : VisualElement // TypeDefIndex: 72023
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Constructors
		public MultiColumnHeaderColumnMovePreview(); // 0x000000018D5DDE24-0x000000018D5DDEA4
		static MultiColumnHeaderColumnMovePreview(); // 0x000000018D5DDD98-0x000000018D5DDE24
	}

	internal class MultiColumnHeaderColumnMoveLocationPreview : VisualElement // TypeDefIndex: 72024
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string visualUssClassName; // 0x08
	
		// Constructors
		public MultiColumnHeaderColumnMoveLocationPreview(); // 0x000000018D5DDCB8-0x000000018D5DDD98
		static MultiColumnHeaderColumnMoveLocationPreview(); // 0x000000018D5DDBD4-0x000000018D5DDCB8
	}

	internal class ColumnMover : PointerManipulator // TypeDefIndex: 72025
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnLayout _columnLayout_k__BackingField; // 0x80
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ColumnMover> activeChanged; // 0x88
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ColumnMover> movingChanged; // 0x90
	
		// Properties
		public ColumnLayout columnLayout { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
		public bool active { get; set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018D5D8D60-0x000000018D5D8D8C
		public bool moving { get; set; } // 0x000000018226EE60-0x000000018226EE70 0x000000018D5D8D8C-0x000000018D5D8DB8
	
		// Events
		public event Action<ColumnMover> activeChanged {
			add; // 0x000000018D5D8B20-0x000000018D5D8BB0
			remove; // 0x000000018D5D8C40-0x000000018D5D8CD0
		}
		public event Action<ColumnMover> movingChanged {
			add; // 0x000000018D5D8BB0-0x000000018D5D8C40
			remove; // 0x000000018D5D8CD0-0x000000018D5D8D60
		}
	
		// Constructors
		public ColumnMover(); // 0x000000018D5D8AA4-0x000000018D5D8B20
	
		// Methods
		protected override void RegisterCallbacksOnTarget(); // 0x000000018D5D7DB8-0x000000018D5D8268
		protected override void UnregisterCallbacksFromTarget(); // 0x000000018D5D8268-0x000000018D5D8718
		protected void OnMouseDown(MouseDownEvent evt); // 0x000000018D5D73E8-0x000000018D5D74A8
		protected void OnMouseMove(MouseMoveEvent evt); // 0x000000018D5D74A8-0x000000018D5D7518
		protected void OnMouseUp(MouseUpEvent evt); // 0x000000018D5D7518-0x000000018D5D75DC
		private void OnMouseCaptureOut(MouseCaptureOutEvent evt); // 0x000000018D5D737C-0x000000018D5D73E8
		private void OnPointerDown(PointerDownEvent evt); // 0x000000018D5D76CC-0x000000018D5D77D4
		private void OnPointerMove(PointerMoveEvent evt); // 0x000000018D5D77D4-0x000000018D5D78BC
		private void OnPointerUp(PointerUpEvent evt); // 0x000000018D5D78BC-0x000000018D5D79C4
		private void OnPointerCancel(PointerCancelEvent evt); // 0x000000018D5D75DC-0x000000018D5D765C
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt); // 0x000000018D5D765C-0x000000018D5D76CC
		private static bool IsNotMouseEvent(int pointerId); // 0x000000018D5D72D0-0x000000018D5D731C
		protected void ProcessCancelEvent(EventBase evt, int pointerId); // 0x000000018D5D79C4-0x000000018D5D7A74
		private void OnKeyDown(KeyDownEvent e); // 0x000000018D5D731C-0x000000018D5D737C
		private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId); // 0x000000018D5D7A74-0x000000018D5D7C0C
		private void ProcessMoveEvent(EventBase e, Vector2 localPosition); // 0x000000018D5D7C0C-0x000000018D5D7CE8
		private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId); // 0x000000018D5D7CE8-0x000000018D5D7DB8
		private void BeginDragMove(float pos); // 0x000000018D5D6D80-0x000000018D5D7188
		internal void DragMove(float pos); // 0x000000018D5D7188-0x000000018D5D7194
		private void UpdatePreviewPosition(); // 0x000000018D5D8938-0x000000018D5D8AA4
		private void UpdateMoveLocation(); // 0x000000018D5D8718-0x000000018D5D8938
		private void EndDragMove(bool cancelled); // 0x000000018D5D7194-0x000000018D5D72D0
	}

	internal class MultiColumnHeaderColumnResizePreview : VisualElement // TypeDefIndex: 72026
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string visualUssClassName; // 0x08
	
		// Constructors
		public MultiColumnHeaderColumnResizePreview(); // 0x000000018D5DE15C-0x000000018D5DE23C
		static MultiColumnHeaderColumnResizePreview(); // 0x000000018D5DE078-0x000000018D5DE15C
	}

	internal class ColumnResizer : PointerManipulator // TypeDefIndex: 72027
	{
		// Fields
		private Vector2 m_Start; // 0x38
		protected bool m_Active; // 0x40
		private bool m_Resizing; // 0x41
		private MultiColumnCollectionHeader m_Header; // 0x48
		private Column m_Column; // 0x50
		private VisualElement m_PreviewElement; // 0x58
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnLayout _columnLayout_k__BackingField; // 0x60
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _preview_k__BackingField; // 0x68
	
		// Properties
		public ColumnLayout columnLayout { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public bool preview { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EF80-0x000000018226EF90 0x000000018226EF90-0x000000018226EFA0
	
		// Constructors
		public ColumnResizer(Column column); // 0x000000018D5D97F0-0x000000018D5D9888
	
		// Methods
		protected override void RegisterCallbacksOnTarget(); // 0x000000018D5D9358-0x000000018D5D9554
		protected override void UnregisterCallbacksFromTarget(); // 0x000000018D5D9554-0x000000018D5D9750
		private void OnKeyDown(KeyDownEvent e); // 0x000000018D5D8EA4-0x000000018D5D8F0C
		private void OnPointerDown(PointerDownEvent e); // 0x000000018D5D8F0C-0x000000018D5D9160
		private void OnPointerMove(PointerMoveEvent e); // 0x000000018D5D9160-0x000000018D5D9244
		private void OnPointerUp(PointerUpEvent e); // 0x000000018D5D9244-0x000000018D5D9358
		private void BeginDragResize(float pos); // 0x000000018D5D8DB8-0x000000018D5D8E00
		private void DragResize(float pos); // 0x000000018D5D8E00-0x000000018D5D8E40
		private void UpdatePreviewPosition(); // 0x000000018D5D9750-0x000000018D5D97F0
		private void EndDragResize(float pos, bool cancelled); // 0x000000018D5D8E40-0x000000018D5D8EA4
	}

	internal class MultiColumnCollectionHeader : VisualElement, IDisposable // TypeDefIndex: 72034
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Dictionary<Column, ColumnData> _columnDataMap_k__BackingField; // 0x3F8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ColumnLayout _columnLayout_k__BackingField; // 0x400
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly VisualElement _columnContainer_k__BackingField; // 0x408
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly VisualElement _resizeHandleContainer_k__BackingField; // 0x410
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Columns _columns_k__BackingField; // 0x418
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<int, float> columnResized; // 0x420
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action columnSortingChanged; // 0x428
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent; // 0x430
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action viewDataRestored; // 0x438
	
		// Properties
		internal bool isApplyingViewState { get; } // 0x0000000187262E20-0x0000000187262E30 
		public Dictionary<Column, ColumnData> columnDataMap { [CompilerGenerated] get; } // 0x000000018723A220-0x000000018723A230 
		public ColumnLayout columnLayout { [CompilerGenerated] get; } // 0x000000018723A230-0x000000018723A240 
		public VisualElement columnContainer { [CompilerGenerated] get; } // 0x000000018723A240-0x000000018723A250 
		public VisualElement resizeHandleContainer { [CompilerGenerated] get; } // 0x000000018723BF90-0x000000018723BFA0 
		public IEnumerable<SortColumnDescription> sortedColumns { get; } // 0x000000018723A1C0-0x000000018723A1D0 
		public SortColumnDescriptions sortDescriptions { get; protected internal set; } // 0x000000018723A1D0-0x000000018723A1E0 0x000000018D5DD850-0x000000018D5DD904
		public Columns columns { [CompilerGenerated] get; } // 0x000000018723BFC0-0x000000018723BFD0 
		public bool sortingEnabled { get; set; } // 0x0000000187262E30-0x0000000187262E40 0x000000018D5DD904-0x000000018D5DD938
	
		// Events
		public event Action<int, float> columnResized {
			add; // 0x000000018D5DD3B0-0x000000018D5DD440
			remove; // 0x000000018D5DD600-0x000000018D5DD690
		}
		public event Action columnSortingChanged {
			add; // 0x000000018D5DD440-0x000000018D5DD4D8
			remove; // 0x000000018D5DD690-0x000000018D5DD728
		}
		public event Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent {
			add; // 0x000000018D5DD4D8-0x000000018D5DD568
			remove; // 0x000000018D5DD728-0x000000018D5DD7B8
		}
		internal event Action viewDataRestored {
			add; // 0x000000018D5DD568-0x000000018D5DD600
			remove; // 0x000000018D5DD7B8-0x000000018D5DD850
		}
	
		// Nested types
		[Serializable]
		private class ViewState // TypeDefIndex: 72029
		{
			// Fields
			[SerializeField]
			private bool m_HasPersistedData; // 0x10
			[SerializeField]
			private List<SortColumnDescription> m_SortDescriptions; // 0x18
			[SerializeField]
			private List<ColumnState> m_OrderedColumnStates; // 0x20
	
			// Nested types
			[Serializable]
			private struct ColumnState // TypeDefIndex: 72028
			{
				// Fields
				public int index; // 0x00
				public string name; // 0x08
				public float actualWidth; // 0x10
				public Length width; // 0x14
				public bool visible; // 0x1C
			}
	
			// Constructors
			public ViewState(); // 0x000000018D5E97A4-0x000000018D5E9864
	
			// Methods
			internal void Save(MultiColumnCollectionHeader header); // 0x000000018D5E9368-0x000000018D5E97A4
			internal void Apply(MultiColumnCollectionHeader header); // 0x000000018D5E8FB8-0x000000018D5E9368
		}
	
		internal class ColumnData // TypeDefIndex: 72030
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private MultiColumnHeaderColumn _control_k__BackingField; // 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private MultiColumnHeaderColumnResizeHandle _resizeHandle_k__BackingField; // 0x18
	
			// Properties
			public MultiColumnHeaderColumn control { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
			public MultiColumnHeaderColumnResizeHandle resizeHandle { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
			// Constructors
			public ColumnData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private struct SortedColumnState // TypeDefIndex: 72031
		{
			// Fields
			public SortColumnDescription columnDesc; // 0x00
			public SortDirection direction; // 0x08
	
			// Constructors
			public SortedColumnState(SortColumnDescription desc, SortDirection dir); // 0x000000018783B33C-0x000000018783B358
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0 // TypeDefIndex: 72032
		{
			// Fields
			public Column column; // 0x10
			public MultiColumnCollectionHeader __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass65_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnContextualMenuManipulator_b__1(DropdownMenuAction a); // 0x000000018D5E2BFC-0x000000018D5E2C28
			internal DropdownMenuAction.Status _OnContextualMenuManipulator_b__2(DropdownMenuAction a); // 0x000000018D5E2C28-0x000000018D5E2CA4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass71_0 // TypeDefIndex: 72033
		{
			// Fields
			public Column column; // 0x10
	
			// Constructors
			public __c__DisplayClass71_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _UpdateSortColumnDescriptionsOnClick_b__0(SortColumnDescription d); // 0x000000018D5E2CA4-0x000000018D5E2D18
		}
	
		// Constructors
		public MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns); // 0x000000018D5DCC34-0x000000018D5DD3B0
		static MultiColumnCollectionHeader(); // 0x000000018D5DCAD8-0x000000018D5DCC34
	
		// Methods
		private void ScheduleDoLayout(); // 0x000000018D5DB9A0-0x000000018D5DBA2C
		private void ResizeToFit(); // 0x000000018D5DB924-0x000000018D5DB964
		private void UpdateSortedColumns(); // 0x000000018D5DC144-0x000000018D5DC72C
		private void UpdateColumnControls(); // 0x000000018D5DBAAC-0x000000018D5DBF20
		private void OnColumnAdded(Column column, int index); // 0x000000018D5DA470-0x000000018D5DA478
		private void OnColumnAdded(Column column); // 0x000000018D5DA478-0x000000018D5DA7BC
		private void OnColumnRemoved(Column column); // 0x000000018D5DAB7C-0x000000018D5DADE0
		private void OnColumnChanged(Column column, ColumnDataType type); // 0x000000018D5DA7BC-0x000000018D5DA820
		private void OnColumnReordered(Column column, int from, int to); // 0x000000018D5DADE0-0x000000018D5DAF80
		private void OnColumnResized(Column column); // 0x000000018D5DAF80-0x000000018D5DAF88
		private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt); // 0x000000018D5DAF88-0x000000018D5DB648
		private void OnMoveManipulatorActivated(ColumnMover mover); // 0x000000018D5DB6BC-0x000000018D5DB738
		private void OnGeometryChanged(GeometryChangedEvent e); // 0x000000018D5DB648-0x000000018D5DB6BC
		private void DoLayout(); // 0x000000018D5DA41C-0x000000018D5DA470
		private void OnColumnControlGeometryChanged(GeometryChangedEvent evt); // 0x000000018D5DA9C4-0x000000018D5DAB7C
		private void OnColumnClicked(EventBase evt); // 0x000000018D5DA820-0x000000018D5DA9C4
		private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers); // 0x000000018D5DBF20-0x000000018D5DC144
		public void ScrollHorizontally(float horizontalOffset); // 0x000000018D5DBA2C-0x000000018D5DBAA4
		private void RaiseColumnResized(int columnIndex); // 0x000000018D5DB894-0x000000018D5DB8F4
		private void RaiseColumnSortingChanged(); // 0x000000018D5DB8F4-0x000000018D5DB924
		private void ApplyColumnSorting(); // 0x000000018D5D9950-0x000000018D5D9EB0
		private void UpdateSortingStatus(); // 0x000000018D5DC72C-0x000000018D5DCAD8
		internal override void OnViewDataReady(); // 0x000000018D5DB738-0x000000018D5DB894
		private void SaveViewState(); // 0x000000018D5DB964-0x000000018D5DB9A0
		public void Dispose(); // 0x000000018D5D9EB0-0x000000018D5DA41C
		[CompilerGenerated]
		private void _OnContextualMenuManipulator_b__65_0(DropdownMenuAction a); // 0x000000018D5DBAA4-0x000000018D5DBAAC
	}

	internal class MultiColumnHeaderColumnSortIndicator : VisualElement // TypeDefIndex: 72035
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string arrowUssClassName; // 0x08
		public static readonly string indexLabelUssClassName; // 0x10
		private Label m_IndexLabel; // 0x3C0
	
		// Properties
		public string sortOrderLabel { set; } // 0x000000018D5DE4D8-0x000000018D5DE4FC
	
		// Constructors
		public MultiColumnHeaderColumnSortIndicator(); // 0x000000018D5DE374-0x000000018D5DE4D8
		static MultiColumnHeaderColumnSortIndicator(); // 0x000000018D5DE23C-0x000000018D5DE374
	}

	internal class MultiColumnHeaderColumnIcon : Image // TypeDefIndex: 72036
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isImageInline_k__BackingField; // 0x408
	
		// Properties
		public bool isImageInline { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187262E40-0x0000000187262E50 0x0000000187262E50-0x0000000187262E60
	
		// Constructors
		public MultiColumnHeaderColumnIcon(); // 0x000000018D5DDAEC-0x000000018D5DDBD4
		static MultiColumnHeaderColumnIcon(); // 0x000000018D5DDA60-0x000000018D5DDAEC
	
		// Methods
		public void UpdateClassList(); // 0x000000018D5DD940-0x000000018D5DDA60
		[CompilerGenerated]
		private void _.ctor_b__5_0(CustomStyleResolvedEvent evt); // 0x000000018D5DD938-0x000000018D5DD940
	}

	internal class MultiColumnHeaderColumn : VisualElement // TypeDefIndex: 72037
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Clickable _clickable_k__BackingField; // 0x3E0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ColumnMover _mover_k__BackingField; // 0x3E8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Column _column_k__BackingField; // 0x3F0
	
		// Properties
		public Clickable clickable { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C0B0-0x000000018723C0C0 0x0000000188DC4B60-0x0000000188DC4B74
		public ColumnMover mover { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C1A0-0x000000018723C1B0 0x0000000188DC4CDC-0x0000000188DC4CF0
		public string sortOrderLabel { set; } // 0x000000018D5DFEE4-0x000000018D5DFF08
		public Column column { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723C190-0x000000018723C1A0 0x0000000188DC4CC8-0x0000000188DC4CDC
		public VisualElement content { get; set; } // 0x000000018723A1C0-0x000000018723A1D0 0x000000018D5DFC94-0x000000018D5DFE38
		private bool isContentBound { get; set; } // 0x000000018D5DFBEC-0x000000018D5DFC94 0x000000018D5DFE38-0x000000018D5DFEE4
	
		// Constructors
		public MultiColumnHeaderColumn(Column column); // 0x000000018D5DF74C-0x000000018D5DFBEC
		static MultiColumnHeaderColumn(); // 0x000000018D5DF1FC-0x000000018D5DF74C
	
		// Methods
		private void InitManipulators(); // 0x000000018D5DEAE4-0x000000018D5DECD0
		private void UpdateDataFromColumn(); // 0x000000018D5DEEFC-0x000000018D5DEF3C
		private void BindHeaderContent(); // 0x000000018D5DE4FC-0x000000018D5DE5D8
		private void UnbindHeaderContent(); // 0x000000018D5DEE20-0x000000018D5DEEFC
		private void DestroyHeaderContent(); // 0x000000018D5DEA1C-0x000000018D5DEAE4
		private VisualElement CreateDefaultHeaderContent(); // 0x000000018D5DE5D8-0x000000018D5DE75C
		private void DefaultBindHeaderContent(VisualElement ve); // 0x000000018D5DE75C-0x000000018D5DEA1C
		private void UpdateHeaderTemplate(); // 0x000000018D5DEFC0-0x000000018D5DF1FC
		private void UpdateGeometryFromColumn(); // 0x000000018D5DEF3C-0x000000018D5DEFC0
		[CompilerGenerated]
		private void _.ctor_b__45_0(Column c, ColumnDataType role); // 0x000000018D5DED64-0x000000018D5DEE18
		[CompilerGenerated]
		private void _.ctor_b__45_1(Column c); // 0x000000018D5DEE18-0x000000018D5DEE20
		[CompilerGenerated]
		private void _InitManipulators_b__46_0(ColumnMover mv); // 0x000000018D5DECD0-0x000000018D5DED64
	}

	internal class MultiColumnHeaderColumnResizeHandle : VisualElement // TypeDefIndex: 72038
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string dragAreaUssClassName; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly VisualElement _dragArea_k__BackingField; // 0x3C0
	
		// Properties
		public VisualElement dragArea { [CompilerGenerated] get; } // 0x000000018723A1B0-0x000000018723A1C0 
	
		// Constructors
		public MultiColumnHeaderColumnResizeHandle(); // 0x000000018D5DDF88-0x000000018D5DE078
		static MultiColumnHeaderColumnResizeHandle(); // 0x000000018D5DDEA4-0x000000018D5DDF88
	}
}

namespace UnityEngine.UIElements.StyleSheets
{
	internal abstract class HierarchyTraversal // TypeDefIndex: 72039
	{
		// Constructors
		protected HierarchyTraversal(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual void Traverse(VisualElement element); // 0x000000018D5D9938-0x000000018D5D9950
		public abstract void TraverseRecursive(VisualElement element, int depth);
		protected void Recurse(VisualElement element, int depth); // 0x000000018D5D9888-0x000000018D5D9938
	}

	internal static class StylePropertyUtil // TypeDefIndex: 72040
	{
		// Fields
		private static readonly HashSet<StylePropertyId> s_AnimatablePropertiesHash; // 0x00
		internal static readonly Dictionary<string, StylePropertyId> s_NameToId; // 0x08
		internal static readonly Dictionary<StylePropertyId, string> s_IdToName; // 0x10
		internal static readonly StylePropertyId[] s_AnimatableProperties; // 0x18
	
		// Constructors
		static StylePropertyUtil(); // 0x000000018D5E0E14-0x000000018D5E2BFC
	
		// Methods
		public static bool IsAnimatable(StylePropertyId id); // 0x000000018D5DFF08-0x000000018D5DFF74
		public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue); // 0x000000018D5E0054-0x000000018D5E0E14
		public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id); // 0x000000018D5DFF74-0x000000018D5E0054
	}

	internal static class InitialStyle // TypeDefIndex: 72041
	{
		// Fields
		private static ComputedStyle s_InitialStyle; // 0x00
	
		// Properties
		public static Align alignContent { get; } // 0x000000018D5EB970-0x000000018D5EB9D0 
		public static Align alignItems { get; } // 0x000000018D5EB9D0-0x000000018D5EBA30 
		public static Align alignSelf { get; } // 0x000000018D5EBA30-0x000000018D5EBA90 
		public static UnityEngine.Color backgroundColor { get; } // 0x000000018D5EBA90-0x000000018D5EBAFC 
		public static Background backgroundImage { get; } // 0x000000018D5EBAFC-0x000000018D5EBB70 
		public static UnityEngine.Color borderBottomColor { get; } // 0x000000018D5EBB70-0x000000018D5EBBDC 
		public static Length borderBottomLeftRadius { get; } // 0x000000018D5EBBDC-0x000000018D5EBC3C 
		public static Length borderBottomRightRadius { get; } // 0x000000018D5EBC3C-0x000000018D5EBC9C 
		public static float borderBottomWidth { get; } // 0x000000018D5EBC9C-0x000000018D5EBCFC 
		public static UnityEngine.Color borderLeftColor { get; } // 0x000000018D5EBCFC-0x000000018D5EBD68 
		public static float borderLeftWidth { get; } // 0x000000018D5EBD68-0x000000018D5EBDC8 
		public static UnityEngine.Color borderRightColor { get; } // 0x000000018D5EBDC8-0x000000018D5EBE34 
		public static float borderRightWidth { get; } // 0x000000018D5EBE34-0x000000018D5EBE94 
		public static UnityEngine.Color borderTopColor { get; } // 0x000000018D5EBE94-0x000000018D5EBF00 
		public static Length borderTopLeftRadius { get; } // 0x000000018D5EBF00-0x000000018D5EBF64 
		public static Length borderTopRightRadius { get; } // 0x000000018D5EBF64-0x000000018D5EBFC8 
		public static float borderTopWidth { get; } // 0x000000018D5EBFC8-0x000000018D5EC028 
		public static Length bottom { get; } // 0x000000018D5EC028-0x000000018D5EC088 
		public static UnityEngine.Color color { get; } // 0x000000018D5EC088-0x000000018D5EC0F0 
		public static UnityEngine.UIElements.Cursor cursor { get; } // 0x000000018D5EC0F0-0x000000018D5EC164 
		public static DisplayStyle display { get; } // 0x000000018D5EC164-0x000000018D5EC1C4 
		public static Length flexBasis { get; } // 0x000000018D5EC1C4-0x000000018D5EC224 
		public static FlexDirection flexDirection { get; } // 0x000000018D5EC224-0x000000018D5EC284 
		public static float flexGrow { get; } // 0x000000018D5EC284-0x000000018D5EC2E4 
		public static float flexShrink { get; } // 0x000000018D5EC2E4-0x000000018D5EC344 
		public static Wrap flexWrap { get; } // 0x000000018D5EC344-0x000000018D5EC3A4 
		public static Length fontSize { get; } // 0x000000018D5EC3A4-0x000000018D5EC400 
		public static Length height { get; } // 0x000000018D5EC400-0x000000018D5EC460 
		public static Justify justifyContent { get; } // 0x000000018D5EC460-0x000000018D5EC4C0 
		public static Length left { get; } // 0x000000018D5EC4C0-0x000000018D5EC520 
		public static Length letterSpacing { get; } // 0x000000018D5EC520-0x000000018D5EC57C 
		public static Length marginBottom { get; } // 0x000000018D5EC57C-0x000000018D5EC5DC 
		public static Length marginLeft { get; } // 0x000000018D5EC5DC-0x000000018D5EC63C 
		public static Length marginRight { get; } // 0x000000018D5EC63C-0x000000018D5EC69C 
		public static Length marginTop { get; } // 0x000000018D5EC69C-0x000000018D5EC6FC 
		public static Length maxHeight { get; } // 0x000000018D5EC6FC-0x000000018D5EC75C 
		public static Length maxWidth { get; } // 0x000000018D5EC75C-0x000000018D5EC7BC 
		public static Length minHeight { get; } // 0x000000018D5EC7BC-0x000000018D5EC820 
		public static Length minWidth { get; } // 0x000000018D5EC820-0x000000018D5EC884 
		public static float opacity { get; } // 0x000000018D5EC884-0x000000018D5EC8E8 
		public static OverflowInternal overflow { get; } // 0x000000018D5EC8E8-0x000000018D5EC94C 
		public static Length paddingBottom { get; } // 0x000000018D5EC94C-0x000000018D5EC9B0 
		public static Length paddingLeft { get; } // 0x000000018D5EC9B0-0x000000018D5ECA14 
		public static Length paddingRight { get; } // 0x000000018D5ECA14-0x000000018D5ECA78 
		public static Length paddingTop { get; } // 0x000000018D5ECA78-0x000000018D5ECADC 
		public static Position position { get; } // 0x000000018D5ECADC-0x000000018D5ECB40 
		public static Length right { get; } // 0x000000018D5ECB40-0x000000018D5ECBA4 
		public static Rotate rotate { get; } // 0x000000018D5ECBA4-0x000000018D5ECC18 
		public static Scale scale { get; } // 0x000000018D5ECC18-0x000000018D5ECC84 
		public static TextOverflow textOverflow { get; } // 0x000000018D5ECC84-0x000000018D5ECCE4 
		public static TextShadow textShadow { get; } // 0x000000018D5ECCE4-0x000000018D5ECD5C 
		public static Length top { get; } // 0x000000018D5ECD5C-0x000000018D5ECDC0 
		public static TransformOrigin transformOrigin { get; } // 0x000000018D5ECDC0-0x000000018D5ECE34 
		public static List<TimeValue> transitionDelay { get; } // 0x000000018D5ECE34-0x000000018D5ECE94 
		public static List<TimeValue> transitionDuration { get; } // 0x000000018D5ECE94-0x000000018D5ECEF4 
		public static List<StylePropertyName> transitionProperty { get; } // 0x000000018D5ECEF4-0x000000018D5ECF54 
		public static List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction { get; } // 0x000000018D5ECF54-0x000000018D5ECFB4 
		public static Translate translate { get; } // 0x000000018D5ECFB4-0x000000018D5ED02C 
		public static UnityEngine.Color unityBackgroundImageTintColor { get; } // 0x000000018D5ED02C-0x000000018D5ED098 
		public static UnityEngine.ScaleMode unityBackgroundScaleMode { get; } // 0x000000018D5ED098-0x000000018D5ED0F8 
		public static Font unityFont { get; } // 0x000000018D5ED1BC-0x000000018D5ED218 
		public static FontDefinition unityFontDefinition { get; } // 0x000000018D5ED0F8-0x000000018D5ED160 
		public static FontStyle unityFontStyleAndWeight { get; } // 0x000000018D5ED160-0x000000018D5ED1BC 
		public static OverflowClipBox unityOverflowClipBox { get; } // 0x000000018D5ED218-0x000000018D5ED278 
		public static Length unityParagraphSpacing { get; } // 0x000000018D5ED278-0x000000018D5ED2D4 
		public static int unitySliceBottom { get; } // 0x000000018D5ED2D4-0x000000018D5ED334 
		public static int unitySliceLeft { get; } // 0x000000018D5ED334-0x000000018D5ED394 
		public static int unitySliceRight { get; } // 0x000000018D5ED394-0x000000018D5ED3F4 
		public static int unitySliceTop { get; } // 0x000000018D5ED3F4-0x000000018D5ED454 
		public static TextAnchor unityTextAlign { get; } // 0x000000018D5ED454-0x000000018D5ED4B0 
		public static UnityEngine.Color unityTextOutlineColor { get; } // 0x000000018D5ED4B0-0x000000018D5ED518 
		public static float unityTextOutlineWidth { get; } // 0x000000018D5ED518-0x000000018D5ED574 
		public static TextOverflowPosition unityTextOverflowPosition { get; } // 0x000000018D5ED574-0x000000018D5ED5D4 
		public static Visibility visibility { get; } // 0x000000018D5ED5D4-0x000000018D5ED630 
		public static WhiteSpace whiteSpace { get; } // 0x000000018D5ED630-0x000000018D5ED690 
		public static Length width { get; } // 0x000000018D5ED690-0x000000018D5ED6F4 
		public static Length wordSpacing { get; } // 0x000000018D5ED6F4-0x000000018D5ED754 
	
		// Constructors
		static InitialStyle(); // 0x000000018D5EAA18-0x000000018D5EB970
	
		// Methods
		public static ref ComputedStyle Get(); // 0x000000018D5EA9CC-0x000000018D5EAA18
		public static ComputedStyle Acquire(); // 0x000000018D5EA930-0x000000018D5EA9CC
	}

	internal static class ShorthandApplicator // TypeDefIndex: 72042
	{
		// Fields
		private static List<TimeValue> s_TransitionDelayList; // 0x00
		private static List<TimeValue> s_TransitionDurationList; // 0x08
		private static List<StylePropertyName> s_TransitionPropertyList; // 0x10
		private static List<UnityEngine.UIElements.EasingFunction> s_TransitionTimingFunctionList; // 0x18
	
		// Constructors
		static ShorthandApplicator(); // 0x000000018D5EEE50-0x000000018D5EEFFC
	
		// Methods
		public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle); // 0x000000018D5ED9E4-0x000000018D5EDAE4
		public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle); // 0x000000018D5EDAE4-0x000000018D5EDBE0
		public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle); // 0x000000018D5EDBE0-0x000000018D5EDCD8
		public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle); // 0x000000018D5EDCD8-0x000000018D5EDDB0
		public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle); // 0x000000018D5EDDB0-0x000000018D5EDEA4
		public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle); // 0x000000018D5EDEA4-0x000000018D5EDFA4
		public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle); // 0x000000018D5EDFA4-0x000000018D5EE0EC
		public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle); // 0x000000018D5EE0EC-0x000000018D5EE194
		private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis); // 0x000000018D5EE674-0x000000018D5EE828
		private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left); // 0x000000018D5EE194-0x000000018D5EE288
		private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left); // 0x000000018D5EE518-0x000000018D5EE674
		private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left); // 0x000000018D5EE45C-0x000000018D5EE518
		private static void CompileBoxArea(StylePropertyReader reader, out UnityEngine.Color top, out UnityEngine.Color right, out UnityEngine.Color bottom, out UnityEngine.Color left); // 0x000000018D5EE288-0x000000018D5EE45C
		private static void CompileTextOutline(StylePropertyReader reader, out UnityEngine.Color outlineColor, out float outlineWidth); // 0x000000018D5EE828-0x000000018D5EE8E0
		private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<UnityEngine.UIElements.EasingFunction> outTimingFunction); // 0x000000018D5EE8E0-0x000000018D5EEE50
	}

	internal static class StylePropertyCache // TypeDefIndex: 72043
	{
		// Fields
		internal static readonly Dictionary<string, string> s_PropertySyntaxCache; // 0x00
		internal static readonly Dictionary<string, string> s_NonTerminalValues; // 0x08
	
		// Constructors
		static StylePropertyCache(); // 0x000000018D5EF0F8-0x000000018D5F02B0
	
		// Methods
		public static bool TryGetSyntax(string name, out string syntax); // 0x000000018D5EF07C-0x000000018D5EF0F8
		public static bool TryGetNonTerminalValue(string name, out string syntax); // 0x000000018D5EEFFC-0x000000018D5EF07C
	}

	internal enum StyleEnumType // TypeDefIndex: 72044
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

	internal enum StylePropertyId // TypeDefIndex: 72045
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
	internal struct Dimension : IEquatable<Dimension> // TypeDefIndex: 72047
	{
		// Fields
		public Unit unit; // 0x00
		public float value; // 0x04
	
		// Nested types
		public enum Unit // TypeDefIndex: 72046
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
		public Dimension(float value, Unit unit); // 0x0000000187262EB0-0x0000000187262EC0
	
		// Methods
		public Length ToLength(); // 0x000000018D5EA48C-0x000000018D5EA4BC
		public TimeValue ToTime(); // 0x000000018D5EA628-0x000000018D5EA648
		public Angle ToAngle(); // 0x000000018D5EA43C-0x000000018D5EA48C
		public static bool operator ==(Dimension lhs, Dimension rhs); // 0x000000018D5EA648-0x000000018D5EA66C
		public bool Equals(Dimension other); // 0x000000018D5EA400-0x000000018D5EA414
		public override bool Equals(object obj); // 0x000000018D5EA390-0x000000018D5EA400
		public override int GetHashCode(); // 0x000000018D5EA414-0x000000018D5EA43C
		public override string ToString(); // 0x000000018D5EA4BC-0x000000018D5EA628
	}

	[Serializable]
	internal struct ScalableImage // TypeDefIndex: 72048
	{
		// Fields
		public Texture2D normalImage; // 0x00
		public Texture2D highResolutionImage; // 0x08
	
		// Methods
		public override string ToString(); // 0x000000018D5ED754-0x000000018D5ED868
	}

	internal struct StylePropertyValue // TypeDefIndex: 72049
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public StyleValueHandle handle; // 0x08
	}

	internal struct ImageSource // TypeDefIndex: 72050
	{
		// Fields
		public Texture2D texture; // 0x00
		public Sprite sprite; // 0x08
		public VectorImage vectorImage; // 0x10
		public RenderTexture renderTexture; // 0x18
	
		// Methods
		public bool IsNull(); // 0x000000018D5EA868-0x000000018D5EA930
	}

	internal class StylePropertyReader // TypeDefIndex: 72052
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private StyleProperty _property_k__BackingField; // 0x48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private StylePropertyId _propertyId_k__BackingField; // 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _valueCount_k__BackingField; // 0x54
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private float _dpiScaling_k__BackingField; // 0x58
	
		// Properties
		public StyleProperty property { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public StylePropertyId propertyId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233280-0x0000000187233290 0x00000001854CCF30-0x00000001854CCF40
		public int valueCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
		public float dpiScaling { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872353B0-0x00000001872353C0 0x00000001872353E0-0x00000001872353F0
	
		// Nested types
		internal delegate int GetCursorIdFunction(StyleSheet sheet, StyleValueHandle handle); // TypeDefIndex: 72051; 0x00000001859B7730-0x00000001859B7740
	
		// Constructors
		public StylePropertyReader(); // 0x000000018D5F3324-0x000000018D5F341C
	
		// Methods
		public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1f /* Metadata: 0x02622736 */); // 0x000000018D5F2B80-0x000000018D5F2C5C
		public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1f /* Metadata: 0x0262273A */); // 0x000000018D5F2D1C-0x000000018D5F2D68
		public StylePropertyId MoveNextProperty(); // 0x000000018D5F07B0-0x000000018D5F07D4
		public StylePropertyValue GetValue(int index); // 0x000000018D5F0314-0x000000018D5F0394
		public StyleValueType GetValueType(int index); // 0x000000018D5F02B0-0x000000018D5F0314
		public bool IsValueType(int index, StyleValueType type); // 0x000000018D5F0420-0x000000018D5F0494
		public bool IsKeyword(int index, StyleValueKeyword keyword); // 0x000000018D5F0394-0x000000018D5F0420
		public string ReadAsString(int index); // 0x000000018D5F0834-0x000000018D5F08A4
		public Length ReadLength(int index); // 0x000000018D5F17E4-0x000000018D5F18A0
		public TimeValue ReadTimeValue(int index); // 0x000000018D5F2400-0x000000018D5F24A0
		public Translate ReadTranslate(int index); // 0x000000018D5F2850-0x000000018D5F29A0
		public TransformOrigin ReadTransformOrigin(int index); // 0x000000018D5F258C-0x000000018D5F26D8
		public Rotate ReadRotate(int index); // 0x000000018D5F1D20-0x000000018D5F1EC0
		public Scale ReadScale(int index); // 0x000000018D5F2038-0x000000018D5F2178
		public float ReadFloat(int index); // 0x000000018D5F1044-0x000000018D5F10B8
		public int ReadInt(int index); // 0x000000018D5F176C-0x000000018D5F17E4
		public UnityEngine.Color ReadColor(int index); // 0x000000018D5F0B00-0x000000018D5F0C08
		public int ReadEnum(StyleEnumType enumType, int index); // 0x000000018D5F0F70-0x000000018D5F1044
		public FontDefinition ReadFontDefinition(int index); // 0x000000018D5F10B8-0x000000018D5F14CC
		public Font ReadFont(int index); // 0x000000018D5F14CC-0x000000018D5F176C
		public Background ReadBackground(int index); // 0x000000018D5F08A4-0x000000018D5F0B00
		public UnityEngine.UIElements.Cursor ReadCursor(int index); // 0x000000018D5F0C08-0x000000018D5F0ED4
		public TextShadow ReadTextShadow(int index); // 0x000000018D5F2178-0x000000018D5F2400
		public void ReadListEasingFunction(List<UnityEngine.UIElements.EasingFunction> list, int index); // 0x000000018D5F18A0-0x000000018D5F19F4
		public void ReadListTimeValue(List<TimeValue> list, int index); // 0x000000018D5F1B30-0x000000018D5F1C64
		public void ReadListStylePropertyName(List<StylePropertyName> list, int index); // 0x000000018D5F19F4-0x000000018D5F1B30
		private void LoadProperties(); // 0x000000018D5F0494-0x000000018D5F07B0
		private void SetCurrentProperty(); // 0x000000018D5F2C5C-0x000000018D5F2D1C
		public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue); // 0x000000018D5F26D8-0x000000018D5F2850
		private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal); // 0x000000018D5F24A0-0x000000018D5F258C
		public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3); // 0x000000018D5F29A0-0x000000018D5F2B80
		public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3); // 0x000000018D5F1EC0-0x000000018D5F2038
		public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4); // 0x000000018D5F1C64-0x000000018D5F1D20
		private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value); // 0x000000018D5F0ED4-0x000000018D5F0F70
		public static Angle ReadAngle(StylePropertyValue value); // 0x000000018D5F07D4-0x000000018D5F0834
		internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source); // 0x000000018D5F2D68-0x000000018D5F3324
	}

	internal struct MatchResultInfo // TypeDefIndex: 72053
	{
		// Fields
		public readonly bool success; // 0x00
		public readonly PseudoStates triggerPseudoMask; // 0x04
		public readonly PseudoStates dependencyPseudoMask; // 0x08
	
		// Constructors
		public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask); // 0x0000000187262EC0-0x0000000187262ED0
	}

	internal struct SelectorMatchRecord // TypeDefIndex: 72054
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public int styleSheetIndexInStack; // 0x08
		public StyleComplexSelector complexSelector; // 0x10
	
		// Constructors
		public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack); // 0x000000018D5ED984-0x000000018D5ED9AC
	
		// Methods
		public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b); // 0x000000018D5ED868-0x000000018D5ED984
	}

	internal static class StyleSelectorHelper // TypeDefIndex: 72055
	{
		// Methods
		public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector); // 0x000000018D5F43B0-0x000000018D5F45D0
		public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult); // 0x000000018D5F4200-0x000000018D5F43B0
		private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record); // 0x000000018D5F3C00-0x000000018D5F3D4C
		public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex); // 0x000000018D5F3D4C-0x000000018D5F4200
	}

	internal static class StyleSheetCache // TypeDefIndex: 72058
	{
		// Fields
		private static SheetHandleKeyComparer s_Comparer; // 0x00
		private static Dictionary<SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; // 0x08
	
		// Nested types
		private struct SheetHandleKey // TypeDefIndex: 72056
		{
			// Fields
			public readonly int sheetInstanceID; // 0x00
			public readonly int index; // 0x04
	
			// Constructors
			public SheetHandleKey(StyleSheet sheet, int index); // 0x000000018D5ED9AC-0x000000018D5ED9E4
		}
	
		private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey> // TypeDefIndex: 72057
		{
			// Constructors
			public SheetHandleKeyComparer(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool Equals(SheetHandleKey x, SheetHandleKey y); // 0x000000018A8F29FC-0x000000018A8F2A14
			public int GetHashCode(SheetHandleKey key); // 0x0000000187249990-0x00000001872499A0
		}
	
		// Constructors
		static StyleSheetCache(); // 0x000000018D5F48F8-0x000000018D5F49EC
	
		// Methods
		internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex); // 0x000000018D5F4690-0x000000018D5F4838
		internal static StylePropertyId[] GetPropertyIds(StyleRule rule); // 0x000000018D5F4838-0x000000018D5F48F8
		private static StylePropertyId GetPropertyId(StyleRule rule, int index); // 0x000000018D5F45D0-0x000000018D5F4690
	}

	internal static class StyleSheetColor // TypeDefIndex: 72059
	{
		// Fields
		private static Dictionary<string, Color32> s_NameToColor; // 0x00
	
		// Constructors
		static StyleSheetColor(); // 0x000000018D5F4A90-0x000000018D5F67AC
	
		// Methods
		public static bool TryGetColor(string name, out UnityEngine.Color color); // 0x000000018D5F49EC-0x000000018D5F4A90
		private static Color32 HexToColor32(uint color); // 0x0000000187262ED0-0x0000000187262EF0
	}

	internal static class StyleSheetExtensions // TypeDefIndex: 72060
	{
		// Extension methods
		public static string ReadAsString(this StyleSheet sheet, StyleValueHandle handle); // 0x000000018D5F67C4-0x000000018D5F6AB4
		public static bool IsVarFunction(this StyleValueHandle handle); // 0x000000018D5F67AC-0x000000018D5F67C4
	}

	[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
	internal struct StyleValue // TypeDefIndex: 72061
	{
		// Fields
		public StylePropertyId id; // 0x00
		public StyleKeyword keyword; // 0x04
		public float number; // 0x08
		public Length length; // 0x08
		public UnityEngine.Color color; // 0x08
		public GCHandle resource; // 0x08
	}

	internal struct StyleValueManaged // TypeDefIndex: 72062
	{
		// Fields
		public StylePropertyId id; // 0x00
		public StyleKeyword keyword; // 0x04
		public object value; // 0x08
	}

	internal enum MatchResultErrorCode // TypeDefIndex: 72063
	{
		None = 0,
		Syntax = 1,
		EmptyValue = 2,
		ExpectedEndOfValue = 3
	}

	internal struct MatchResult // TypeDefIndex: 72064
	{
		// Fields
		public MatchResultErrorCode errorCode; // 0x00
		public string errorValue; // 0x08
	
		// Properties
		public bool success { get; } // 0x0000000186535F00-0x0000000186535F10 
	}

	internal abstract class BaseStyleMatcher // TypeDefIndex: 72066
	{
		// Fields
		protected static readonly Regex s_CustomIdentRegex; // 0x00
		private Stack<MatchContext> m_ContextStack; // 0x10
		private MatchContext m_CurrentContext; // 0x18
	
		// Properties
		public abstract int valueCount { get; }
		public abstract bool isCurrentVariable { get; }
		public abstract bool isCurrentComma { get; }
		public bool hasCurrent { get; } // 0x000000018D5EA36C-0x000000018D5EA390 
		public int currentIndex { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public int matchedVariableCount { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
	
		// Nested types
		private struct MatchContext // TypeDefIndex: 72065
		{
			// Fields
			public int valueIndex; // 0x00
			public int matchedVariableCount; // 0x04
		}
	
		// Constructors
		protected BaseStyleMatcher(); // 0x000000018D5EA2F4-0x000000018D5EA36C
		static BaseStyleMatcher(); // 0x000000018D5EA260-0x000000018D5EA2F4
	
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
		protected void Initialize(); // 0x000000018D5E98AC-0x000000018D5E98F4
		public void MoveNext(); // 0x000000018D5EA194-0x000000018D5EA1C8
		public void SaveContext(); // 0x000000018D5EA214-0x000000018D5EA260
		public void RestoreContext(); // 0x000000018D5EA1C8-0x000000018D5EA214
		public void DropContext(); // 0x000000018D5E9864-0x000000018D5E98AC
		protected bool Match(Expression exp); // 0x000000018D5EA0F4-0x000000018D5EA194
		private bool MatchExpression(Expression exp); // 0x000000018D5E9B90-0x000000018D5E9C54
		private bool MatchExpressionWithMultiplier(Expression exp); // 0x000000018D5E9ABC-0x000000018D5E9B90
		private bool MatchGroup(Expression exp); // 0x000000018D5E9C54-0x000000018D5E9CFC
		private bool MatchCombinator(Expression exp); // 0x000000018D5E9928-0x000000018D5E99F0
		private bool MatchOr(Expression exp); // 0x000000018D5EA000-0x000000018D5EA0F4
		private bool MatchOrOr(Expression exp); // 0x000000018D5E9FE8-0x000000018D5EA000
		private bool MatchAndAnd(Expression exp); // 0x000000018D5E98F4-0x000000018D5E9928
		private int MatchMany(Expression exp); // 0x000000018D5E9EB8-0x000000018D5E9FE8
		private unsafe int MatchManyByOrder(Expression exp, int* matchOrder); // 0x000000018D5E9D70-0x000000018D5E9EB8
		private bool MatchJuxtaposition(Expression exp); // 0x000000018D5E9CFC-0x000000018D5E9D70
		private bool MatchDataType(Expression exp); // 0x000000018D5E99F0-0x000000018D5E9ABC
	}

	internal class StylePropertyValueMatcher : BaseStyleMatcher // TypeDefIndex: 72067
	{
		// Fields
		private List<StylePropertyValue> m_Values; // 0x20
	
		// Properties
		private StylePropertyValue current { get; } // 0x000000018D5F3ACC-0x000000018D5F3B4C 
		public override int valueCount { get; } // 0x000000018D5F3BC0-0x000000018D5F3C00 
		public override bool isCurrentVariable { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override bool isCurrentComma { get; } // 0x000000018D5F3B4C-0x000000018D5F3BC0 
	
		// Constructors
		public StylePropertyValueMatcher(); // 0x000000018D5F3A80-0x000000018D5F3ACC
	
		// Methods
		public UnityEngine.UIElements.StyleSheets.MatchResult Match(Expression exp, List<StylePropertyValue> values); // 0x000000018D5F3908-0x000000018D5F3A80
		protected override bool MatchKeyword(string keyword); // 0x000000018D5F3668-0x000000018D5F3704
		protected override bool MatchNumber(); // 0x000000018D5F3648-0x000000018D5F3668
		protected override bool MatchInteger(); // 0x000000018D5F3648-0x000000018D5F3668
		protected override bool MatchLength(); // 0x000000018D5F3704-0x000000018D5F37B8
		protected override bool MatchPercentage(); // 0x000000018D5F37B8-0x000000018D5F386C
		protected override bool MatchColor(); // 0x000000018D5F34D4-0x000000018D5F3590
		protected override bool MatchResource(); // 0x000000018D5F386C-0x000000018D5F388C
		protected override bool MatchUrl(); // 0x000000018D5F38DC-0x000000018D5F3908
		protected override bool MatchTime(); // 0x000000018D5F388C-0x000000018D5F38DC
		protected override bool MatchCustomIdent(); // 0x000000018D5F3590-0x000000018D5F3648
		protected override bool MatchAngle(); // 0x000000018D5F341C-0x000000018D5F34D4
	}
}

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	internal class Expression // TypeDefIndex: 72068
	{
		// Fields
		public ExpressionType type; // 0x10
		public ExpressionMultiplier multiplier; // 0x14
		public UnityEngine.UIElements.StyleSheets.Syntax.DataType dataType; // 0x20
		public ExpressionCombinator combinator; // 0x24
		public Expression[] subExpressions; // 0x28
		public string keyword; // 0x30
	
		// Constructors
		public Expression(ExpressionType type); // 0x000000018D5EA6E4-0x000000018D5EA74C
	}

	internal enum ExpressionType // TypeDefIndex: 72069
	{
		Unknown = 0,
		Data = 1,
		Keyword = 2,
		Combinator = 3
	}

	internal enum DataType // TypeDefIndex: 72070
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

	internal enum ExpressionCombinator // TypeDefIndex: 72071
	{
		None = 0,
		Or = 1,
		OrOr = 2,
		AndAnd = 3,
		Juxtaposition = 4,
		Group = 5
	}

	internal enum ExpressionMultiplierType // TypeDefIndex: 72072
	{
		None = 0,
		ZeroOrMore = 1,
		OneOrMore = 2,
		ZeroOrOne = 3,
		Ranges = 4,
		OneOrMoreComma = 5,
		GroupAtLeastOne = 6
	}

	internal struct ExpressionMultiplier // TypeDefIndex: 72073
	{
		// Fields
		public const int Infinity = 100; // Metadata: 0x0262275F
		private ExpressionMultiplierType m_Type; // 0x00
		public int min; // 0x04
		public int max; // 0x08
	
		// Properties
		public ExpressionMultiplierType type { get; set; } // 0x000000018725FD00-0x000000018725FD10 0x000000018D5EA6DC-0x000000018D5EA6E4
	
		// Constructors
		public ExpressionMultiplier(ExpressionMultiplierType type = ExpressionMultiplierType.None /* Metadata: 0x0262275E */); // 0x000000018D5EA6C4-0x000000018D5EA6DC
	
		// Methods
		private void SetType(ExpressionMultiplierType value); // 0x000000018D5EA66C-0x000000018D5EA6C4
	}

	internal class StyleSyntaxParser // TypeDefIndex: 72074
	{
		// Fields
		private List<Expression> m_ProcessExpressionList; // 0x10
		private Stack<Expression> m_ExpressionStack; // 0x18
		private Stack<ExpressionCombinator> m_CombinatorStack; // 0x20
		private Dictionary<string, Expression> m_ParsedExpressionCache; // 0x28
	
		// Constructors
		public StyleSyntaxParser(); // 0x000000018D5F850C-0x000000018D5F8664
	
		// Methods
		public Expression Parse(string syntax); // 0x000000018D5F8130-0x000000018D5F82D4
		private Expression ParseExpression(StyleSyntaxTokenizer tokenizer); // 0x000000018D5F71B0-0x000000018D5F742C
		private void ProcessCombinatorStack(); // 0x000000018D5F82D4-0x000000018D5F850C
		private Expression ParseTerm(StyleSyntaxTokenizer tokenizer); // 0x000000018D5F7F80-0x000000018D5F8130
		private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer); // 0x000000018D5F6B58-0x000000018D5F6CCC
		private Expression ParseGroup(StyleSyntaxTokenizer tokenizer); // 0x000000018D5F742C-0x000000018D5F76C8
		private Expression ParseDataType(StyleSyntaxTokenizer tokenizer); // 0x000000018D5F6CCC-0x000000018D5F71B0
		private Expression ParseNonTerminalValue(string syntax); // 0x000000018D5F7874-0x000000018D5F79AC
		private Expression ParseProperty(StyleSyntaxTokenizer tokenizer); // 0x000000018D5F79AC-0x000000018D5F7E48
		private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier); // 0x000000018D5F76C8-0x000000018D5F7874
		private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max); // 0x000000018D5F7E48-0x000000018D5F7F80
		private static void EatSpace(StyleSyntaxTokenizer tokenizer); // 0x000000018D5F6AB4-0x000000018D5F6B08
		private static bool IsExpressionEnd(StyleSyntaxToken token); // 0x000000018D5F6B1C-0x000000018D5F6B38
		private static bool IsCombinator(StyleSyntaxToken token); // 0x000000018D5F6B08-0x000000018D5F6B1C
		private static bool IsMultiplier(StyleSyntaxToken token); // 0x000000018D5F6B38-0x000000018D5F6B58
	}

	internal enum StyleSyntaxTokenType // TypeDefIndex: 72075
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

	internal struct StyleSyntaxToken // TypeDefIndex: 72076
	{
		// Fields
		public StyleSyntaxTokenType type; // 0x00
		public string text; // 0x08
		public int number; // 0x10
	
		// Constructors
		public StyleSyntaxToken(StyleSyntaxTokenType t); // 0x000000018D5F9088-0x000000018D5F90AC
		public StyleSyntaxToken(StyleSyntaxTokenType type, string text); // 0x000000018D5F90AC-0x000000018D5F90D0
		public StyleSyntaxToken(StyleSyntaxTokenType type, int number); // 0x000000018D5F90D0-0x000000018D5F90F8
	}

	internal class StyleSyntaxTokenizer // TypeDefIndex: 72077
	{
		// Fields
		private List<StyleSyntaxToken> m_Tokens; // 0x10
		private int m_CurrentTokenIndex; // 0x18
	
		// Properties
		public StyleSyntaxToken current { get; } // 0x000000018D5F9D58-0x000000018D5F9E10 
	
		// Constructors
		public StyleSyntaxTokenizer(); // 0x000000018D5F9CD8-0x000000018D5F9D58
	
		// Methods
		public StyleSyntaxToken MoveNext(); // 0x000000018D5F92C0-0x000000018D5F9378
		public StyleSyntaxToken PeekNext(); // 0x000000018D5F9378-0x000000018D5F9430
		public void Tokenize(string syntax); // 0x000000018D5F9430-0x000000018D5F9CD8
		private static bool IsNextCharacter(string s, int index, char c); // 0x000000018D5F9148-0x000000018D5F9184
		private static bool IsNextLetterOrDash(string s, int index); // 0x000000018D5F9184-0x000000018D5F9240
		private static bool IsNextNumber(string s, int index); // 0x000000018D5F9240-0x000000018D5F92C0
		private static int GlobCharacter(string s, int index, char c); // 0x000000018D5F90F8-0x000000018D5F9148
	}
}

namespace UnityEngine.UIElements.UIR
{
	internal class Allocator2D // TypeDefIndex: 71946
	{
		// Fields
		private readonly Vector2Int m_MinSize; // 0x10
		private readonly Vector2Int m_MaxSize; // 0x18
		private readonly Vector2Int m_MaxAllocSize; // 0x20
		private readonly int m_RowHeightBias; // 0x28
		private readonly Row[] m_Rows; // 0x30
		private readonly List<Area> m_Areas; // 0x38
	
		// Nested types
		public class Area // TypeDefIndex: 71943
		{
			// Fields
			public RectInt rect; // 0x10
			public BestFitAllocator allocator; // 0x20
	
			// Constructors
			public Area(RectInt rect); // 0x000000018D6734D0-0x000000018D673550
		}
	
		public class Row : LinkedPoolItem<Row> // TypeDefIndex: 71944
		{
			// Fields
			public RectInt rect; // 0x18
			public Area area; // 0x28
			public BestFitAllocator allocator; // 0x30
			public Alloc alloc; // 0x38
			public Row next; // 0x50
			public static readonly LinkedPool<Row> pool; // 0x00
	
			// Constructors
			public Row(); // 0x000000018D67E9BC-0x000000018D67E9E4
			static Row(); // 0x000000018D67E888-0x000000018D67E9BC
	
			// Methods
			private static Row Create(); // 0x000000018D67E7E4-0x000000018D67E834
			private static void Reset(Row row); // 0x000000018D67E834-0x000000018D67E888
		}
	
		public struct Alloc2D // TypeDefIndex: 71945
		{
			// Fields
			public RectInt rect; // 0x00
			public Row row; // 0x10
			public Alloc alloc; // 0x18
	
			// Constructors
			public Alloc2D(Row row, Alloc alloc, int width, int height); // 0x000000018D672924-0x000000018D6729C4
		}
	
		// Constructors
		public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias); // 0x000000018D673304-0x000000018D6734D0
	
		// Methods
		public bool TryAllocate(int width, int height, out Alloc2D alloc2D); // 0x000000018D672EA4-0x000000018D673304
		public void Free(Alloc2D alloc2D); // 0x000000018D672CA0-0x000000018D672EA4
		private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize); // 0x000000018D6729C4-0x000000018D672B6C
		private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias); // 0x000000018D672BD4-0x000000018D672CA0
		private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias); // 0x000000018D672B6C-0x000000018D672BD4
	}

	internal class GradientSettingsAtlas : IDisposable // TypeDefIndex: 71948
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _MustCommit_k__BackingField; // 0x39
	
		// Properties
		internal int length { get; } // 0x000000018725FFC0-0x000000018725FFD0 
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public Texture2D atlas { get; } // 0x000000018725FED0-0x000000018725FEE0 
		public bool MustCommit { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226ED20-0x000000018226ED30 0x000000018226ED30-0x000000018226ED40
	
		// Nested types
		private struct RawTexture // TypeDefIndex: 71947
		{
			// Fields
			public Color32[] rgba; // 0x00
			public int width; // 0x08
			public int height; // 0x0C
	
			// Methods
			public void WriteRawInt2Packed(int v0, int v1, int destX, int destY); // 0x000000018D67E75C-0x000000018D67E7E4
			public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY); // 0x000000018D67E6B4-0x000000018D67E75C
		}
	
		// Constructors
		public GradientSettingsAtlas(int length = 4096 /* Metadata: 0x0262256A */); // 0x000000018D6742C0-0x000000018D6742D4
		static GradientSettingsAtlas(); // 0x000000018D674220-0x000000018D6742C0
	
		// Methods
		public void Dispose(); // 0x000000018D673BF4-0x000000018D673C44
		protected virtual void Dispose(bool disposing); // 0x000000018D673C44-0x000000018D673CA4
		public void Reset(); // 0x000000018D673E00-0x000000018D673EB8
		public Alloc Add(int count); // 0x000000018D673ACC-0x000000018D673B90
		public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap); // 0x000000018D673EB8-0x000000018D674220
		public void Commit(); // 0x000000018D673B90-0x000000018D673BF4
		private void PrepareAtlas(); // 0x000000018D673CA4-0x000000018D673E00
	}

	internal class LinkedPoolItem<T> // TypeDefIndex: 71949
	{
		// Fields
		internal T poolNext;
	
		// Constructors
		public LinkedPoolItem();
	}

	internal class LinkedPool<T> // TypeDefIndex: 71950
		where T : LinkedPoolItem<T>
	{
		// Fields
		private readonly Func<T> m_CreateFunc;
		private readonly Action<T> m_ResetAction;
		private readonly int m_Limit;
		private T m_PoolFirst;
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _Count_k__BackingField;
	
		// Properties
		public int Count { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public LinkedPool(Func<T> createFunc, Action<T> resetAction, int limit = 10000 /* Metadata: 0x0262256C */);
	
		// Methods
		public void Clear();
		public T Get();
		public void Return(T item);
	}

	internal class BasicNode<T> : LinkedPoolItem<BasicNode<T>> // TypeDefIndex: 71951
	{
		// Fields
		public BasicNode<T> next;
		public T data;
	
		// Constructors
		public BasicNode();
	
		// Methods
		public void AppendTo(ref BasicNode<T> first);
	}

	internal class BasicNodePool<T> : LinkedPool<BasicNode<T>> // TypeDefIndex: 71952
	{
		// Constructors
		public BasicNodePool();
	
		// Methods
		private static void Reset(BasicNode<T> node);
		private static BasicNode<T> Create();
	}

	internal static class MeshBuilder // TypeDefIndex: 71957
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
		internal struct AllocMeshData // TypeDefIndex: 71954
		{
			// Fields
			internal Allocator alloc; // 0x00
			internal Texture texture; // 0x08
			internal TextureId svgTexture; // 0x10
			internal Material material; // 0x18
			internal MeshGenerationContext.MeshFlags flags; // 0x20
			internal BMPAlloc colorAlloc; // 0x24
	
			// Nested types
			internal delegate MeshWriteData Allocator(uint vertexCount, uint indexCount, ref AllocMeshData allocatorData); // TypeDefIndex: 71953; 0x00000001811DF7F0-0x00000001811DF810
	
			// Methods
			internal MeshWriteData Allocate(uint vertexCount, uint indexCount); // 0x000000018D5B77BC-0x000000018D5B77EC
		}
	
		private struct ClipCounts // TypeDefIndex: 71955
		{
			// Fields
			public int firstClippedIndex; // 0x00
			public int firstDegenerateIndex; // 0x04
			public int lastClippedIndex; // 0x08
			public int clippedTriangles; // 0x0C
			public int addedTriangles; // 0x10
			public int degenerateTriangles; // 0x14
		}
	
		private enum VertexClipEdge // TypeDefIndex: 71956
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8
		}
	
		// Constructors
		static MeshBuilder(); // 0x000000018D67DA28-0x000000018D67DD34
	
		// Methods
		internal static void MakeBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, AllocMeshData meshAlloc); // 0x000000018D677EF4-0x000000018D677FEC
		internal static void MakeSolidRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc); // 0x000000018D678C64-0x000000018D678E58
		internal static void MakeTexturedRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc, ColorPage colorPage); // 0x000000018D6794DC-0x000000018D679CF8
		private static UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.MeshInfo info, int index, Vector2 offset, VertexFlags flags = VertexFlags.IsText /* Metadata: 0x02622570 */, bool isDynamicColor = false /* Metadata: 0x02622571 */); // 0x000000018D6775B4-0x000000018D677764
		private static UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.UIElements.TextVertex textVertex, Vector2 offset); // 0x0000000187263B30-0x0000000187263BF0
		private static int LimitTextVertices(int vertexCount, bool logTruncation = true /* Metadata: 0x02622572 */); // 0x000000018D677E00-0x000000018D677EF4
		internal static void MakeText(UnityEngine.TextCore.Text.MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags = VertexFlags.IsText /* Metadata: 0x02622573 */, bool isDynamicColor = false /* Metadata: 0x02622574 */); // 0x000000018D679174-0x000000018D6794DC
		internal static void MakeText(NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, Vector2 offset, AllocMeshData meshAlloc); // 0x000000018D678E58-0x000000018D679174
		internal static void UpdateText(NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, Vector2 offset, Matrix4x4 transform, Color32 xformClipPages, Color32 ids, Color32 flags, Color32 opacityPageSettingIndex, NativeSlice<UnityEngine.UIElements.Vertex> vertices); // 0x000000018D67D5B4-0x000000018D67D7DC
		private static void MakeQuad(Rect rcPosition, Rect rcTexCoord, UnityEngine.Color color, float posZ, AllocMeshData meshAlloc, ColorPage colorPage); // 0x000000018D677FEC-0x000000018D6783F0
		internal static void MakeSlicedQuad(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc); // 0x000000018D6783F0-0x000000018D678C64
		internal static void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, int settingIndexOffset, AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount); // 0x000000018D67AD78-0x000000018D67B87C
		internal static void MakeVectorGraphicsStretchBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, UnityEngine.ScaleMode scaleMode, UnityEngine.Color tint, int settingIndexOffset, AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount); // 0x000000018D67A554-0x000000018D67AD78
		private static unsafe void SplitTriangle(UnityEngine.UIElements.Vertex* vertices, ushort* indices, ref int vertexCount, int indexToProcess, ref int indexCount, float svgWidth, float svgHeight, Vector4 sliceLTRB, int sliceIndex); // 0x000000018D67CD38-0x000000018D67D5B4
		private static unsafe void ScaleSplittedTriangles(UnityEngine.UIElements.Vertex* vertices, int vertexCount, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB); // 0x000000018D67CAC4-0x000000018D67CD38
		internal static void MakeVectorGraphics9SliceBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, bool stretch, UnityEngine.Color tint, int settingIndexOffset, AllocMeshData meshAlloc); // 0x000000018D679CF8-0x000000018D67A554
		private static ClipCounts UpperBoundApproximateRectClippingResults(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax); // 0x000000018D67D7DC-0x000000018D67DA28
		private static void RectClip(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax, MeshWriteData mwd, ClipCounts cc, ref int newVertexCount); // 0x000000018D67C5A4-0x000000018D67CAC4
		private static unsafe void RectClipTriangle(UnityEngine.UIElements.Vertex* vt, ushort* it, Vector4 clipRectMinMax, MeshWriteData mwd, ref ushort nextNewVertex); // 0x000000018D67B87C-0x000000018D67C5A4
		private static unsafe Vector3 GetVertexBaryCentricCoordinates(UnityEngine.UIElements.Vertex* vt, float x, float y); // 0x000000018D677764-0x000000018D6778D0
		private static unsafe UnityEngine.UIElements.Vertex InterpolateVertexInTriangle(UnityEngine.UIElements.Vertex* vt, float x, float y, Vector3 uvw); // 0x000000018D677A9C-0x000000018D677CD0
		private static unsafe UnityEngine.UIElements.Vertex InterpolateVertexInTriangleEdge(UnityEngine.UIElements.Vertex* vt, int e0, int e1, float t); // 0x000000018D6778D0-0x000000018D677A9C
		private static float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy); // 0x000000018D677CD0-0x000000018D677E00
	}

	internal struct ChainBuilderStats // TypeDefIndex: 71958
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

	internal class RenderChain : IDisposable // TypeDefIndex: 71963
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x120
		internal static Action OnPreRender; // 0x38
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private BaseVisualElementPanel _panel_k__BackingField; // 0x128
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UIRenderDevice _device_k__BackingField; // 0x130
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AtlasBase _atlas_k__BackingField; // 0x138
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VectorImageManager _vectorImageManager_k__BackingField; // 0x140
		internal UIRVEShaderInfoAllocator shaderInfoAllocator; // 0x148
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UIRStylePainter _painter_k__BackingField; // 0x218
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _drawStats_k__BackingField; // 0x220
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _drawInCameras_k__BackingField; // 0x221
	
		// Properties
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872406E0-0x00000001872406F0 0x0000000187240740-0x0000000187240750
		internal BaseVisualElementPanel panel { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723B5D0-0x000000018723B5E0 0x000000018783BF64-0x000000018783BF78
		internal UIRenderDevice device { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723B420-0x000000018723B430 0x000000018783BF78-0x000000018783BF8C
		internal AtlasBase atlas { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723B5C0-0x000000018723B5D0 0x000000018783BF8C-0x000000018783BFA0
		internal VectorImageManager vectorImageManager { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BE50-0x000000018723BE60 0x0000000188DC478C-0x0000000188DC47A0
		internal UIRStylePainter painter { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234910-0x0000000187234920 0x0000000188A865BC-0x0000000188A865D0
		internal bool drawStats { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187262D60-0x0000000187262D70 0x0000000187262D80-0x0000000187262D90
		internal bool drawInCameras { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187262D50-0x0000000187262D60 0x0000000187262D70-0x0000000187262D80
		internal Shader defaultShader { set; } // 0x000000018D5BC890-0x000000018D5BC938
		internal Shader defaultWorldSpaceShader { set; } // 0x000000018D5BC938-0x000000018D5BC9E0
	
		// Nested types
		private struct DepthOrderedDirtyTracking // TypeDefIndex: 71959
		{
			// Fields
			public List<VisualElement> heads; // 0x00
			public List<VisualElement> tails; // 0x08
			public int[] minDepths; // 0x10
			public int[] maxDepths; // 0x18
			public uint dirtyID; // 0x20
	
			// Methods
			public void EnsureFits(int maxDepth); // 0x000000018D5B83CC-0x000000018D5B844C
			public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass); // 0x000000018D5B844C-0x000000018D5B8610
			public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse); // 0x000000018D5B81D4-0x000000018D5B83CC
			public void Reset(); // 0x000000018D5B8610-0x000000018D5B8664
		}
	
		private struct RenderChainStaticIndexAllocator // TypeDefIndex: 71960
		{
			// Fields
			private static List<RenderChain> renderChains; // 0x00
	
			// Constructors
			static RenderChainStaticIndexAllocator(); // 0x000000018D5B8A94-0x000000018D5B8B28
	
			// Methods
			public static int AllocateIndex(RenderChain renderChain); // 0x000000018D5B8918-0x000000018D5B8A24
			public static void FreeIndex(int index); // 0x000000018D5B8A24-0x000000018D5B8A94
			public static RenderChain AccessIndex(int index); // 0x000000018D5B88AC-0x000000018D5B8918
		}
	
		private struct RenderNodeData // TypeDefIndex: 71961
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
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71962
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<RenderChainCommand> __9__37_0; // 0x08
			public static Action<RenderChainCommand> __9__37_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D5C4F60-0x000000018D5C4FC4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal RenderChainCommand _.ctor_b__37_0(); // 0x000000018D5C4F10-0x000000018D5C4F60
			internal void _.ctor_b__37_1(RenderChainCommand cmd); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		static RenderChain(); // 0x000000018D5BC208-0x000000018D5BC4B4
		public RenderChain(BaseVisualElementPanel panel); // 0x000000018D5BC4B4-0x000000018D5BC890
	
		// Methods
		private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan); // 0x000000018D5B8EF0-0x000000018D5B9288
		private void Destructor(); // 0x000000018D5B9288-0x000000018D5B94E8
		public void Dispose(); // 0x000000018D5B9514-0x000000018D5B9564
		protected void Dispose(bool disposing); // 0x000000018D5B94E8-0x000000018D5B9514
		public void ProcessChanges(); // 0x000000018D5BAC04-0x000000018D5BB184
		public void Render(); // 0x000000018D5BB44C-0x000000018D5BB7DC
		private void ProcessTextRegen(bool timeSliced); // 0x000000018D5BB184-0x000000018D5BB388
		public void UIEOnChildAdded(VisualElement ve); // 0x000000018D5BBA24-0x000000018D5BBBD8
		public void UIEOnChildrenReordered(VisualElement ve); // 0x000000018D5BBCCC-0x000000018D5BBE60
		public void UIEOnChildRemoving(VisualElement ve); // 0x000000018D5BBBD8-0x000000018D5BBCCC
		public void StopTrackingGroupTransformElement(VisualElement ve); // 0x000000018D5BB9CC-0x000000018D5BBA24
		public void UIEOnRenderHintsChanged(VisualElement ve); // 0x000000018D5BC030-0x000000018D5BC0CC
		public void UIEOnClippingChanged(VisualElement ve, bool hierarchical); // 0x000000018D5BBE60-0x000000018D5BBEFC
		public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false /* Metadata: 0x0262257A */); // 0x000000018D5BBF94-0x000000018D5BC030
		public void UIEOnColorChanged(VisualElement ve); // 0x000000018D5BBEFC-0x000000018D5BBF94
		public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged); // 0x000000018D5BC0CC-0x000000018D5BC16C
		public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical); // 0x000000018D5BC16C-0x000000018D5BC208
		internal Material GetStandardMaterial(); // 0x000000018D5B9F98-0x000000018D5BA084
		internal Material GetStandardWorldSpaceMaterial(); // 0x000000018D5BA084-0x000000018D5BA170
		internal void EnsureFitsDepth(int depth); // 0x000000018D5B9EC4-0x000000018D5B9ED0
		internal void ChildWillBeRemoved(VisualElement ve); // 0x000000018D5B8E48-0x000000018D5B8EF0
		internal RenderChainCommand AllocCommand(); // 0x000000018D5B8D38-0x000000018D5B8D94
		internal void FreeCommand(RenderChainCommand cmd); // 0x000000018D5B9ED0-0x000000018D5B9F70
		internal void OnRenderCommandAdded(RenderChainCommand command); // 0x000000018D5BAA38-0x000000018D5BAAB8
		internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand); // 0x000000018D5BAAB8-0x000000018D5BAAEC
		internal void AddTextElement(VisualElement ve); // 0x000000018D5B8CC4-0x000000018D5B8D38
		internal void RemoveTextElement(VisualElement ve); // 0x000000018D5BB388-0x000000018D5BB44C
		internal void OnGroupTransformElementChangedTransform(VisualElement ve); // 0x000000018D5BA170-0x000000018D5BA2A4
		private static RenderNodeData AccessRenderNodeData(IntPtr obj); // 0x000000018D5B8BE8-0x000000018D5B8CC4
		private static void OnRenderNodeExecute(IntPtr obj); // 0x000000018D5BAAEC-0x000000018D5BAC04
		private static void OnRegisterIntermediateRenderers(Camera camera); // 0x000000018D5BA628-0x000000018D5BAA38
		private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderNodeData rnd, Camera camera, int sameDistanceSortPriority); // 0x000000018D5BA2A4-0x000000018D5BA628
		internal void RepaintTexturedElements(); // 0x000000018D5BB7DC-0x000000018D5BB890
		private void OnFontReset(Font font); // 0x0000000187262D40-0x0000000187262D50
		public void AppendTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas); // 0x000000018D5B8D94-0x000000018D5B8E48
		public void ResetTextures(VisualElement ve); // 0x000000018D5BB890-0x000000018D5BB9CC
		private void DrawStats(); // 0x000000018D5B9564-0x000000018D5B9EC4
		private static VisualElement GetFirstElementInPanel(VisualElement ve); // 0x000000018D5B9F70-0x000000018D5B9F98
	}

	[Flags]
	internal enum RenderDataDirtyTypes // TypeDefIndex: 71964
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

	internal enum RenderDataDirtyTypeClasses // TypeDefIndex: 71965
	{
		Clipping = 0,
		Opacity = 1,
		Color = 2,
		TransformSize = 3,
		Visuals = 4,
		Count = 5
	}

	internal struct RenderChainVEData // TypeDefIndex: 71966
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
		internal RenderChainCommand lastClosingOrLastCommand { get; } // 0x000000018D5B8BD8-0x000000018D5B8BE8 
	
		// Methods
		internal static bool AllocatesID(BMPAlloc alloc); // 0x000000018D5B8B28-0x000000018D5B8B80
		internal static bool InheritsID(BMPAlloc alloc); // 0x000000018D5B8B80-0x000000018D5B8BD8
	}

	internal struct RenderChainTextEntry // TypeDefIndex: 71967
	{
		// Fields
		internal RenderChainCommand command; // 0x00
		internal int firstVertex; // 0x08
		internal int vertexCount; // 0x0C
	}

	internal struct TextureEntry // TypeDefIndex: 71968
	{
		// Fields
		public Texture source; // 0x00
		public TextureId actual; // 0x08
		public bool replaced; // 0x0C
	}

	internal abstract class BaseShaderInfoStorage : IDisposable // TypeDefIndex: 71969
	{
		// Fields
		protected static int s_TextureCounter; // 0x00
		internal static ProfilerMarker s_MarkerCopyTexture; // 0x08
		internal static ProfilerMarker s_MarkerGetTextureData; // 0x10
		internal static ProfilerMarker s_MarkerUpdateTexture; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x10
	
		// Properties
		public abstract Texture2D texture { get; }
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		protected BaseShaderInfoStorage(); // 0x0000000186805BA0-0x0000000186805BB0
		static BaseShaderInfoStorage(); // 0x000000018D5B7A28-0x000000018D5B7B04
	
		// Methods
		public abstract bool AllocateRect(int width, int height, out RectInt uvs);
		public abstract void SetTexel(int x, int y, UnityEngine.Color color);
		public abstract void UpdateTexture();
		public void Dispose(); // 0x000000018D5B79D8-0x000000018D5B7A28
		protected virtual void Dispose(bool disposing); // 0x00000001887EFED4-0x00000001887EFEE0
	}

	internal class ShaderInfoStorage<T> : BaseShaderInfoStorage // TypeDefIndex: 71970
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
		public override Texture2D texture { get; }
	
		// Constructors
		public ShaderInfoStorage(TextureFormat format, Func<UnityEngine.Color, T> convert, int initialSize = 64 /* Metadata: 0x0262258E */, int maxSize = 4096 /* Metadata: 0x02622590 */);
	
		// Methods
		protected override void Dispose(bool disposing);
		public override bool AllocateRect(int width, int height, out RectInt uvs);
		public override void SetTexel(int x, int y, UnityEngine.Color color);
		public override void UpdateTexture();
		private void CreateOrExpandTexture();
		private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight);
	}

	internal class ShaderInfoStorageRGBA32 : ShaderInfoStorage<Color32> // TypeDefIndex: 71972
	{
		// Fields
		private static readonly Func<UnityEngine.Color, Color32> s_Convert; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71971
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018D5C508C-0x000000018D5C50F0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Color32 _.cctor_b__2_0(UnityEngine.Color c); // 0x000000018D5C4E14-0x000000018D5C4E30
		}
	
		// Constructors
		public ShaderInfoStorageRGBA32(int initialSize = 64 /* Metadata: 0x02622592 */, int maxSize = 4096 /* Metadata: 0x02622594 */); // 0x000000018D5BCAA4-0x000000018D5BCB30
		static ShaderInfoStorageRGBA32(); // 0x000000018D5BC9E0-0x000000018D5BCAA4
	}

	internal class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<UnityEngine.Color> // TypeDefIndex: 71974
	{
		// Fields
		private static readonly Func<UnityEngine.Color, UnityEngine.Color> s_Convert; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71973
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018D5C4FC4-0x000000018D5C5028
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal UnityEngine.Color _.cctor_b__2_0(UnityEngine.Color c); // 0x0000000187233D20-0x0000000187233D30
		}
	
		// Constructors
		public ShaderInfoStorageRGBAFloat(int initialSize = 64 /* Metadata: 0x02622596 */, int maxSize = 4096 /* Metadata: 0x02622598 */); // 0x000000018D5BCBF4-0x000000018D5BCC80
		static ShaderInfoStorageRGBAFloat(); // 0x000000018D5BCB30-0x000000018D5BCBF4
	}

	internal static class Shaders // TypeDefIndex: 71975
	{
		// Fields
		public static readonly string k_AtlasBlit; // 0x00
		public static readonly string k_Editor; // 0x08
		public static readonly string k_Runtime; // 0x10
		public static readonly string k_RuntimeWorld; // 0x18
		public static readonly string k_GraphView; // 0x20
	
		// Constructors
		static Shaders(); // 0x000000018D5BCC80-0x000000018D5BCEF8
	}

	internal static class Tessellation // TypeDefIndex: 71977
	{
		// Fields
		internal static float kEpsilon; // 0x00
		internal static float kUnusedArc; // 0x04
		internal static ushort kSubdivisions; // 0x08
		private static ProfilerMarker s_MarkerTessellateRect; // 0x10
		private static ProfilerMarker s_MarkerTessellateBorder; // 0x18
		private static Edges[] s_AllEdges; // 0x20
	
		// Nested types
		internal enum Edges // TypeDefIndex: 71976
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8,
			All = 15
		}
	
		// Constructors
		static Tessellation(); // 0x000000018D5C3668-0x000000018D5C37D4
	
		// Methods
		public static void TessellateRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc, bool computeUVs); // 0x000000018D5C1008-0x000000018D5C1654
		public static void TessellateQuad(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc); // 0x000000018D5BFB80-0x000000018D5C005C
		public static void TessellateBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, MeshBuilder.AllocMeshData meshAlloc); // 0x000000018D5BDC1C-0x000000018D5BE1C4
		private static void TessellateRoundedCorners(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5C257C-0x000000018D5C29A0
		private static void TessellateRoundedBorders(ref MeshGenerationContextUtils.BorderParams border, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5C1D48-0x000000018D5C2288
		private static void TessellateRoundedCorner(Rect rect, Color32 color, float posZ, Vector2 radius, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5C2288-0x000000018D5C257C
		private static void TessellateRoundedBorder(Rect rect, Color32 leftColor, Color32 topColor, float posZ, Vector2 radius, float leftWidth, float topWidth, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5C1654-0x000000018D5C1D48
		private static Vector2 IntersectLines(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3); // 0x000000018D5BD898-0x000000018D5BD9D0
		private static int LooseCompare(float a, float b); // 0x000000018D5BD9D0-0x000000018D5BDA60
		private static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5BE698-0x000000018D5BED5C
		private static void TessellateQuad(Rect rect, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5C0C1C-0x000000018D5C1008
		private static void TessellateQuad(Rect rect, Edges smoothedEdges, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5C005C-0x000000018D5C012C
		private static int EdgesCount(Edges edges); // 0x000000018D5BD234-0x000000018D5BD264
		private static unsafe void TessellateQuad(Rect rect, Edges smoothedEdges, Vector2* offsets, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5C012C-0x000000018D5C0C1C
		private static void EncodeStraightArc(ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex center, float radius); // 0x000000018D5BD264-0x000000018D5BD460
		private static void ExpandTriangle(ref Vector3 v0, ref Vector3 v1, Vector3 center, float factor); // 0x000000018D5BD460-0x000000018D5BD600
		private static void TessellateQuadSingleEdge(Rect rect, Edges smoothedEdge, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5BF5BC-0x000000018D5BFB80
		private static void TessellateStraightBorder(Rect rect, Edges smoothedEdge, float miterOffset, UnityEngine.Color color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5C29A0-0x000000018D5C3668
		private static Vector4 GetInterpolatedCircle(Vector2 p, ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex v2); // 0x000000018D5BD6C4-0x000000018D5BD898
		private static void ComputeBarycentricCoordinates(Vector2 p, Vector2 a, Vector2 b, Vector2 c, out float u, out float v, out float w); // 0x000000018D5BCEF8-0x000000018D5BD064
		private static void TessellateFilledFan(Vector2 center, Vector2 radius, Vector2 miterOffset, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5BED5C-0x000000018D5BF5BC
		private static void TessellateBorderedFan(Vector2 center, Vector2 outerRadius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly); // 0x000000018D5BE1C4-0x000000018D5BE698
		private static void MirrorVertices(Rect rect, NativeSlice<UnityEngine.UIElements.Vertex> vertices, int vertexStart, int vertexCount, bool flipHorizontal); // 0x000000018D5BDA60-0x000000018D5BDC1C
		private static void FlipWinding(NativeSlice<ushort> indices, int indexStart, int indexCount); // 0x000000018D5BD600-0x000000018D5BD6C4
		private static void ComputeUVs(Rect tessellatedRect, Rect textureRect, Rect uvRegion, NativeSlice<UnityEngine.UIElements.Vertex> vertices); // 0x000000018D5BD064-0x000000018D5BD234
	}

	internal struct TextCoreSettings : IEquatable<TextCoreSettings> // TypeDefIndex: 71978
	{
		// Fields
		public UnityEngine.Color faceColor; // 0x00
		public UnityEngine.Color outlineColor; // 0x10
		public float outlineWidth; // 0x20
		public UnityEngine.Color underlayColor; // 0x24
		public Vector2 underlayOffset; // 0x34
		public float underlaySoftness; // 0x3C
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D5C37D4-0x000000018D5C3868
		public bool Equals(TextCoreSettings other); // 0x000000018D5C3868-0x000000018D5C3984
		public override int GetHashCode(); // 0x000000018D5C3984-0x000000018D5C3A2C
	}

	internal class TextureBlitter : IDisposable // TypeDefIndex: 71980
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x48
	
		// Properties
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223CB60-0x000000018223CB70 0x000000018223CB70-0x000000018223CB80
	
		// Nested types
		private struct BlitInfo // TypeDefIndex: 71979
		{
			// Fields
			public Texture src; // 0x00
			public RectInt srcRect; // 0x08
			public Vector2Int dstPos; // 0x18
			public int border; // 0x20
			public UnityEngine.Color tint; // 0x24
		}
	
		// Constructors
		static TextureBlitter(); // 0x000000018D5C44F4-0x000000018D5C4614
		public TextureBlitter(int capacity = 512 /* Metadata: 0x026225A0 */); // 0x000000018D5C4614-0x000000018D5C46C4
	
		// Methods
		public void Dispose(); // 0x000000018D5C3DE8-0x000000018D5C3E38
		protected virtual void Dispose(bool disposing); // 0x000000018D5C3E38-0x000000018D5C3EA8
		public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, UnityEngine.Color tint); // 0x000000018D5C43F4-0x000000018D5C44F4
		public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, UnityEngine.Color tint); // 0x000000018D5C3C38-0x000000018D5C3D2C
		public void Commit(RenderTexture dst); // 0x000000018D5C3D2C-0x000000018D5C3DE8
		private void BeginBlit(RenderTexture dst); // 0x000000018D5C3A2C-0x000000018D5C3C38
		private void DoBlit(IList<BlitInfo> blitInfos, int startIndex); // 0x000000018D5C3EA8-0x000000018D5C4358
		private void EndBlit(); // 0x000000018D5C4358-0x000000018D5C43F4
	}

	internal class TextureSlotManager // TypeDefIndex: 71981
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _FreeSlots_k__BackingField; // 0x30
		internal TextureRegistry textureRegistry; // 0x38
	
		// Properties
		public int FreeSlots { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
	
		// Constructors
		static TextureSlotManager(); // 0x000000018D5C4B80-0x000000018D5C4CF8
		public TextureSlotManager(); // 0x000000018D5C4CF8-0x000000018D5C4E14
	
		// Methods
		public void Reset(); // 0x000000018D5C4A1C-0x000000018D5C4B28
		public void StartNewBatch(); // 0x000000018D5C4B28-0x000000018D5C4B80
		public int IndexOf(TextureId id); // 0x000000018D5C4960-0x000000018D5C4A1C
		public void MarkUsed(int slotIndex); // 0x000000018D5B7764-0x000000018D5B77BC
		public int FindOldestSlot(); // 0x000000018D5C48A4-0x000000018D5C4960
		public void Bind(TextureId id, int slot, MaterialPropertyBlock mat); // 0x000000018D5C46C4-0x000000018D5C48A4
	}

	internal class VectorImageRenderInfoPool : LinkedPool<VectorImageRenderInfo> // TypeDefIndex: 71983
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71982
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<VectorImageRenderInfo> __9__0_0; // 0x08
			public static Action<VectorImageRenderInfo> __9__0_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D5C5028-0x000000018D5C508C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal VectorImageRenderInfo _.ctor_b__0_0(); // 0x000000018D5C4E80-0x000000018D5C4ED0
			internal void _.ctor_b__0_1(VectorImageRenderInfo vectorImageInfo); // 0x000000018D5C4ED0-0x000000018D5C4EF0
		}
	
		// Constructors
		public VectorImageRenderInfoPool(); // 0x000000018D5C7B60-0x000000018D5C7D24
	}

	internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo> // TypeDefIndex: 71984
	{
		// Fields
		public int useCount; // 0x18
		public GradientRemap firstGradientRemap; // 0x20
		public Alloc gradientSettingsAlloc; // 0x28
	
		// Constructors
		public VectorImageRenderInfo(); // 0x000000018D5C7D50-0x000000018D5C7FE8
	
		// Methods
		public void Reset(); // 0x000000018D5C7D24-0x000000018D5C7D50
	}

	internal class GradientRemapPool : LinkedPool<GradientRemap> // TypeDefIndex: 71986
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 71985
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<GradientRemap> __9__0_0; // 0x08
			public static Action<GradientRemap> __9__0_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D5C50F0-0x000000018D5C5154
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal GradientRemap _.ctor_b__0_0(); // 0x000000018D5C4E30-0x000000018D5C4E80
			internal void _.ctor_b__0_1(GradientRemap gradientRemap); // 0x000000018D5C4EF0-0x000000018D5C4F10
		}
	
		// Constructors
		public GradientRemapPool(); // 0x000000018D5B8664-0x000000018D5B8828
	}

	internal class GradientRemap : LinkedPoolItem<GradientRemap> // TypeDefIndex: 71987
	{
		// Fields
		public int origIndex; // 0x18
		public int destIndex; // 0x1C
		public RectInt location; // 0x20
		public GradientRemap next; // 0x30
		public TextureId atlas; // 0x38
	
		// Constructors
		public GradientRemap(); // 0x000000018D5B8884-0x000000018D5B88AC
	
		// Methods
		public void Reset(); // 0x000000018D5B8828-0x000000018D5B8884
	}

	internal class VectorImageManager : IDisposable // TypeDefIndex: 71988
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x39
	
		// Properties
		public Texture2D atlas { get; } // 0x000000018D5C7B4C-0x000000018D5C7B60 
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226ED20-0x000000018226ED30 0x000000018226ED30-0x000000018226ED40
	
		// Constructors
		public VectorImageManager(AtlasBase atlas); // 0x000000018D5C79C4-0x000000018D5C7B4C
		static VectorImageManager(); // 0x000000018D5C78B8-0x000000018D5C79C4
	
		// Methods
		public void Dispose(); // 0x000000018D5C7494-0x000000018D5C74E4
		protected virtual void Dispose(bool disposing); // 0x000000018D5C738C-0x000000018D5C7494
		public void Commit(); // 0x000000018D5C7358-0x000000018D5C738C
		public GradientRemap AddUser(VectorImage vi, VisualElement context); // 0x000000018D5C726C-0x000000018D5C7358
		private VectorImageRenderInfo Register(VectorImage vi, VisualElement context); // 0x000000018D5C74E4-0x000000018D5C78B8
	}

	internal enum OwnedState : byte // TypeDefIndex: 71989
	{
		Inherited = 0,
		Owned = 1
	}

	internal struct BMPAlloc // TypeDefIndex: 71990
	{
		// Fields
		public static readonly BMPAlloc Invalid; // 0x00
		public int page; // 0x00
		public ushort pageLine; // 0x04
		public byte bitIndex; // 0x06
		public OwnedState ownedState; // 0x07
	
		// Constructors
		static BMPAlloc(); // 0x000000018D5B798C-0x000000018D5B79D8
	
		// Methods
		public bool Equals(BMPAlloc other); // 0x000000018D5B789C-0x000000018D5B78BC
		public bool IsValid(); // 0x0000000188B5630C-0x0000000188B56314
		public override string ToString(); // 0x000000018D5B78BC-0x000000018D5B798C
	}

	internal struct BitmapAllocator32 // TypeDefIndex: 71992
	{
		// Fields
		private int m_PageHeight; // 0x00
		private List<Page> m_Pages; // 0x08
		private List<uint> m_AllocMap; // 0x10
		private int m_EntryWidth; // 0x18
		private int m_EntryHeight; // 0x1C
	
		// Properties
		public int entryWidth { get; } // 0x000000018724B960-0x000000018724B970 
		public int entryHeight { get; } // 0x0000000187249850-0x0000000187249860 
	
		// Nested types
		private struct Page // TypeDefIndex: 71991
		{
			// Fields
			public ushort x; // 0x00
			public ushort y; // 0x02
			public int freeSlots; // 0x04
		}
	
		// Methods
		public void Construct(int pageHeight, int entryWidth = 1 /* Metadata: 0x026225A4 */, int entryHeight = 1 /* Metadata: 0x026225A5 */); // 0x000000018D5B7E00-0x000000018D5B7F20
		public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY); // 0x000000018D5B7F5C-0x000000018D5B802C
		public BMPAlloc Allocate(BaseShaderInfoStorage storage); // 0x000000018D5B7B04-0x000000018D5B7E00
		public void Free(BMPAlloc alloc); // 0x000000018D5B802C-0x000000018D5B815C
		internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y); // 0x000000018D5B815C-0x000000018D5B81D4
		private static byte CountTrailingZeroes(uint val); // 0x000000018D5B7F20-0x000000018D5B7F5C
	}

	internal struct UIRVEShaderInfoAllocator // TypeDefIndex: 71993
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
		private static int pageWidth { get; } // 0x0000000187262DA0-0x0000000187262DB0 
		private static int pageHeight { get; } // 0x0000000187262D90-0x0000000187262DA0 
		public NativeSlice<Transform3x4> transformConstants { get; } // 0x000000018D5C7200-0x000000018D5C726C 
		public NativeSlice<Vector4> clipRectConstants { get; } // 0x000000018D5C7194-0x000000018D5C7200 
		public Texture atlas { get; } // 0x000000018D5C7114-0x000000018D5C7194 
	
		// Constructors
		static UIRVEShaderInfoAllocator(); // 0x000000018D5C6E94-0x000000018D5C7114
	
		// Methods
		private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc); // 0x000000018D5C5384-0x000000018D5C53E4
		private static int AllocToConstantBufferIndex(BMPAlloc alloc); // 0x000000018D5C5334-0x000000018D5C5384
		private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect); // 0x000000018D5C54B8-0x000000018D5C557C
		public void Construct(); // 0x000000018D5C5740-0x000000018D5C5A50
		private void ReallyCreateStorage(); // 0x000000018D5C5E80-0x000000018D5C64A8
		public void Dispose(); // 0x000000018D5C5A50-0x000000018D5C5B00
		public void IssuePendingStorageChanges(); // 0x000000018D5C5D98-0x000000018D5C5DAC
		public BMPAlloc AllocTransform(); // 0x000000018D5C53E4-0x000000018D5C54B8
		public BMPAlloc AllocClipRect(); // 0x000000018D5C5154-0x000000018D5C5228
		public BMPAlloc AllocOpacity(); // 0x000000018D5C5280-0x000000018D5C52D8
		public BMPAlloc AllocColor(); // 0x000000018D5C5228-0x000000018D5C5280
		public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings); // 0x000000018D5C52D8-0x000000018D5C5334
		public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform); // 0x000000018D5C6A78-0x000000018D5C6CCC
		public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect); // 0x000000018D5C64A8-0x000000018D5C65D0
		public void SetOpacityValue(BMPAlloc alloc, float opacity); // 0x000000018D5C66E0-0x000000018D5C67DC
		public void SetColorValue(BMPAlloc alloc, UnityEngine.Color color, bool isEditorContext); // 0x000000018D5C65D0-0x000000018D5C66E0
		public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext); // 0x000000018D5C67DC-0x000000018D5C6A78
		public void FreeTransform(BMPAlloc alloc); // 0x000000018D5C5D14-0x000000018D5C5D98
		public void FreeClipRect(BMPAlloc alloc); // 0x000000018D5C5B00-0x000000018D5C5B84
		public void FreeOpacity(BMPAlloc alloc); // 0x000000018D5C5C08-0x000000018D5C5C8C
		public void FreeColor(BMPAlloc alloc); // 0x000000018D5C5B84-0x000000018D5C5C08
		public void FreeTextCoreSettings(BMPAlloc alloc); // 0x000000018D5C5C8C-0x000000018D5C5D14
		public Color32 TransformAllocToVertexData(BMPAlloc alloc); // 0x000000018D5C6DA4-0x000000018D5C6E94
		public Color32 ClipRectAllocToVertexData(BMPAlloc alloc); // 0x000000018D5C557C-0x000000018D5C566C
		public Color32 OpacityAllocToVertexData(BMPAlloc alloc); // 0x000000018D5C5DAC-0x000000018D5C5E80
		public Color32 ColorAllocToVertexData(BMPAlloc alloc); // 0x000000018D5C566C-0x000000018D5C5740
		public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc); // 0x000000018D5C6CCC-0x000000018D5C6DA4
	}

	internal struct Transform3x4 // TypeDefIndex: 71994
	{
		// Fields
		public Vector4 v0; // 0x00
		public Vector4 v1; // 0x10
		public Vector4 v2; // 0x20
	}

	internal class MeshHandle : LinkedPoolItem<MeshHandle> // TypeDefIndex: 71995
	{
		// Fields
		internal Alloc allocVerts; // 0x18
		internal Alloc allocIndices; // 0x30
		internal uint triangleCount; // 0x48
		internal UnityEngine.UIElements.UIR.Page allocPage; // 0x50
		internal uint allocTime; // 0x58
		internal uint updateAllocID; // 0x5C
	
		// Constructors
		public MeshHandle(); // 0x000000018D5CCCA8-0x000000018D5CCCD0
	}

	internal class UIRenderDevice : IDisposable // TypeDefIndex: 72002
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly uint _maxVerticesPerPage_k__BackingField; // 0xA8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _breakBatches_k__BackingField; // 0xAC
		private static Texture2D s_DefaultShaderInfoTexFloat; // 0x60
		private static Texture2D s_DefaultShaderInfoTexARGB8; // 0x68
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0xAD
	
		// Properties
		internal uint maxVerticesPerPage { [CompilerGenerated] get; } // 0x0000000187235BD0-0x0000000187235BE0 
		internal bool breakBatches { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187262DE0-0x0000000187262DF0 0x0000000187262E00-0x0000000187262E10
		internal static Texture2D defaultShaderInfoTexFloat { get; } // 0x000000018D5D6370-0x000000018D5D68E4 
		internal static Texture2D defaultShaderInfoTexARGB8 { get; } // 0x000000018D5D5FA0-0x000000018D5D6370 
		internal static bool vertexTexturingIsAvailable { get; } // 0x000000018D5D6A80-0x000000018D5D6D80 
		internal static bool shaderModelIs35 { get; } // 0x000000018D5D68E4-0x000000018D5D6A80 
		private bool fullyCreated { get; } // 0x000000018A92967C-0x000000018A929688 
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187262DF0-0x0000000187262E00 0x0000000187262E10-0x0000000187262E20
	
		// Nested types
		internal struct AllocToUpdate // TypeDefIndex: 71996
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
	
		private struct AllocToFree // TypeDefIndex: 71997
		{
			// Fields
			public Alloc alloc; // 0x00
			public UnityEngine.UIElements.UIR.Page page; // 0x18
			public bool vertices; // 0x20
		}
	
		private struct DeviceToFree // TypeDefIndex: 71998
		{
			// Fields
			public uint handle; // 0x00
			public UnityEngine.UIElements.UIR.Page page; // 0x08
	
			// Methods
			public void Dispose(); // 0x000000018D5CC6B4-0x000000018D5CC6E8
		}
	
		private struct EvaluationState // TypeDefIndex: 71999
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
	
		internal struct DrawStatistics // TypeDefIndex: 72000
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
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 72001
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MeshHandle> __9__53_0; // 0x08
			public static Action<MeshHandle> __9__53_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D5D10C4-0x000000018D5D1128
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal MeshHandle _.ctor_b__53_0(); // 0x000000018D5D1074-0x000000018D5D10C4
			internal void _.ctor_b__53_1(MeshHandle mh); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		static UIRenderDevice(); // 0x000000018D5D5690-0x000000018D5D5A24
		public UIRenderDevice(uint initialVertexCapacity = 0 /* Metadata: 0x026225A6 */, uint initialIndexCapacity = 0 /* Metadata: 0x026225A7 */); // 0x000000018D5D5F84-0x000000018D5D5FA0
		protected UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice); // 0x000000018D5D5A24-0x000000018D5D5F84
	
		// Methods
		private void InitVertexDeclaration(); // 0x000000018D5D3D78-0x000000018D5D3F0C
		private void CompleteCreation(); // 0x000000018D5D2838-0x000000018D5D2954
		public void Dispose(); // 0x000000018D5D2AB4-0x000000018D5D2B04
		protected virtual void Dispose(bool disposing); // 0x000000018D5D2954-0x000000018D5D2AB4
		public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset); // 0x000000018D5D1D4C-0x000000018D5D1E18
		public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData); // 0x000000018D5D5200-0x000000018D5D53FC
		public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset); // 0x000000018D5D53FC-0x000000018D5D55E0
		private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices); // 0x000000018D5D505C-0x000000018D5D5150
		internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh); // 0x000000018D5D1128-0x000000018D5D1198
		private bool TryAllocFromPage(UnityEngine.UIElements.UIR.Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived); // 0x000000018D5D48B0-0x000000018D5D49E4
		private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived); // 0x000000018D5D1E18-0x000000018D5D2530
		private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices); // 0x000000018D5D49E4-0x000000018D5D505C
		public void Free(MeshHandle mesh); // 0x000000018D5D36A8-0x000000018D5D3CBC
		private static Vector4 GetClipSpaceParams(); // 0x000000018D5D3CBC-0x000000018D5D3D78
		public void OnFrameRenderingBegin(); // 0x000000018D5D41F8-0x000000018D5D42A0
		private static unsafe NativeSlice<T> PtrToSlice<T>(void* p, int count)
			where T : struct;
		private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, bool newFontDiffers, ref EvaluationState st); // 0x000000018D5D267C-0x000000018D5D2838
		private void ApplyBatchState(ref EvaluationState st, bool allowMaterialChange); // 0x000000018D5D2530-0x000000018D5D267C
		public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException); // 0x000000018D5D2B04-0x000000018D5D3650
		private void UpdateFenceValue(); // 0x000000018D5D5150-0x000000018D5D5200
		private unsafe void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, UnityEngine.UIElements.UIR.Page curPage); // 0x000000018D5D3F0C-0x000000018D5D4160
		private void DrawRanges<I, T>(Utility.GPUBuffer<I> ib, Utility.GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges)
			where I : struct
			where T : struct;
		private void WaitOnCpuFence(uint fence); // 0x000000018D5D55E0-0x000000018D5D563C
		public void AdvanceFrame(); // 0x000000018D5D1198-0x000000018D5D1D4C
		private void PruneUnusedPages(); // 0x000000018D5D47AC-0x000000018D5D48B0
		internal static void PrepareForGfxDeviceRecreate(); // 0x000000018D5D42A0-0x000000018D5D4430
		internal static void WrapUpGfxDeviceRecreate(); // 0x000000018D5D563C-0x000000018D5D5690
		internal static void FlushAllPendingDeviceDisposes(); // 0x000000018D5D3650-0x000000018D5D36A8
		internal DrawStatistics GatherDrawStatistics(); // 0x0000000187262DC0-0x0000000187262DE0
		private static void ProcessDeviceFreeQueue(); // 0x000000018D5D4430-0x000000018D5D47AC
		private static void OnEngineUpdateGlobal(); // 0x000000018D5D4160-0x000000018D5D41A0
		private static void OnFlushPendingResources(); // 0x000000018D5D41A0-0x000000018D5D41F8
	}

	internal struct Alloc // TypeDefIndex: 72003
	{
		// Fields
		public uint start; // 0x00
		public uint size; // 0x04
		internal object handle; // 0x08
		internal bool shortLived; // 0x10
	}

	internal class BestFitAllocator // TypeDefIndex: 72006
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly uint _totalSize_k__BackingField; // 0x10
		private Block m_FirstBlock; // 0x18
		private Block m_FirstAvailableBlock; // 0x20
		private BlockPool m_BlockPool; // 0x28
		private uint m_HighWatermark; // 0x30
	
		// Properties
		public uint totalSize { [CompilerGenerated] get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public uint highWatermark { get; } // 0x000000018725FF30-0x000000018725FF40 
	
		// Nested types
		private class BlockPool : LinkedPool<Block> // TypeDefIndex: 72004
		{
			// Constructors
			public BlockPool(); // 0x000000018D5C8788-0x000000018D5C886C
	
			// Methods
			private static Block CreateBlock(); // 0x000000018D5C8738-0x000000018D5C8788
			private static void ResetBlock(Block block); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class Block : LinkedPoolItem<Block> // TypeDefIndex: 72005
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
			public uint size { get; } // 0x0000000187262DB0-0x0000000187262DC0 
	
			// Constructors
			public Block(); // 0x000000018D5C886C-0x000000018D5C8894
		}
	
		// Constructors
		public BestFitAllocator(uint size); // 0x000000018D5C8678-0x000000018D5C8738
	
		// Methods
		public Alloc Allocate(uint size); // 0x000000018D5C7FE8-0x000000018D5C81C8
		public void Free(Alloc alloc); // 0x000000018D5C8334-0x000000018D5C852C
		private Block CoalesceBlockWithPrevious(Block block); // 0x000000018D5C8204-0x000000018D5C8334
		private Block BestFitFindAvailableBlock(uint size); // 0x000000018D5C81C8-0x000000018D5C8204
		private void SplitBlock(Block block, uint size); // 0x000000018D5C852C-0x000000018D5C8678
	}

	internal class GPUBufferAllocator // TypeDefIndex: 72007
	{
		// Fields
		private BestFitAllocator m_Low; // 0x10
		private BestFitAllocator m_High; // 0x18
	
		// Properties
		public bool isEmpty { get; } // 0x000000018D5CCC78-0x000000018D5CCCA8 
	
		// Constructors
		public GPUBufferAllocator(uint maxSize); // 0x000000018D5CCBD4-0x000000018D5CCC78
	
		// Methods
		public Alloc Allocate(uint size, bool shortLived); // 0x000000018D5CCA08-0x000000018D5CCB24
		public void Free(Alloc alloc); // 0x000000018D5CCB24-0x000000018D5CCBA0
		private bool HighLowCollide(); // 0x000000018D5CCBA0-0x000000018D5CCBD4
	}

	internal class Page : IDisposable // TypeDefIndex: 72009
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x10
		public DataSet<UnityEngine.UIElements.Vertex> vertices; // 0x18
		public DataSet<ushort> indices; // 0x20
		public Page next; // 0x28
		public int framesEmpty; // 0x30
	
		// Properties
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		public bool isEmpty { get; } // 0x000000018D5CCEEC-0x000000018D5CCF48 
	
		// Nested types
		public class DataSet<T> : IDisposable // TypeDefIndex: 72008
			where T : struct
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
			protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public DataSet(Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer);
	
			// Methods
			public void Dispose();
			public void Dispose(bool disposing);
			public void RegisterUpdate(uint start, uint size);
			private bool HasMappedBufferRange();
			public void SendUpdates();
			public void SendFullRange();
			public void SendPartialRanges();
			private void ResetUpdateState();
		}
	
		// Constructors
		public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage); // 0x000000018D5CCDA4-0x000000018D5CCEEC
	
		// Methods
		public void Dispose(); // 0x000000018D5CCD54-0x000000018D5CCDA4
		protected virtual void Dispose(bool disposing); // 0x000000018D5CCCD0-0x000000018D5CCD54
	}

	internal enum VertexFlags // TypeDefIndex: 72010
	{
		IsSolid = 0,
		IsText = 1,
		IsTextured = 2,
		IsDynamic = 3,
		IsSvgGradients = 4,
		LastType = 10,
		IsGraphViewEdge = 10
	}

	internal struct State // TypeDefIndex: 72011
	{
		// Fields
		public Material material; // 0x00
		public Texture font; // 0x08
		public float fontTexSDFScale; // 0x10
		public TextureId texture; // 0x14
		public int stencilRef; // 0x18
	}

	internal enum CommandType // TypeDefIndex: 72012
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

	internal class DrawParams // TypeDefIndex: 72013
	{
		// Fields
		internal static readonly Rect k_UnlimitedRect; // 0x00
		internal static readonly Rect k_FullNormalizedRect; // 0x10
		internal readonly Stack<Matrix4x4> view; // 0x10
		internal readonly Stack<Rect> scissor; // 0x18
		internal readonly List<RenderTexture> renderTexture; // 0x20
		internal readonly List<Material> defaultMaterial; // 0x28
	
		// Constructors
		public DrawParams(); // 0x000000018D5CC89C-0x000000018D5CCA08
		static DrawParams(); // 0x000000018D5CC844-0x000000018D5CC89C
	
		// Methods
		public void Reset(); // 0x000000018D5CC6E8-0x000000018D5CC844
	}

	internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand> // TypeDefIndex: 72014
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
		public RenderChainCommand(); // 0x000000018D5CE028-0x000000018D5CE050
		static RenderChainCommand(); // 0x000000018D5CDF9C-0x000000018D5CE028
	
		// Methods
		internal void Reset(); // 0x000000018D5CDF34-0x000000018D5CDF9C
		internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException); // 0x000000018D5CD1C8-0x000000018D5CDE5C
		private void Blit(Texture source, RenderTexture destination, float depth); // 0x000000018D5CCF48-0x000000018D5CD0B8
		private static Rect CombineScissorRects(Rect r0, Rect r1); // 0x000000018D5CD0B8-0x000000018D5CD1C8
		private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint); // 0x000000018D5CDE5C-0x000000018D5CDF34
	}
}

namespace UnityEngine.UIElements.UIR.Implementation
{
	internal static class CommandGenerator // TypeDefIndex: 72015
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
		static CommandGenerator(); // 0x000000018D5CC5D8-0x000000018D5CC6B4
	
		// Methods
		private static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform); // 0x000000018D5C9CC4-0x000000018D5C9E30
		internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result); // 0x000000018D5C8A30-0x000000018D5C8B5C
		public static UIRStylePainter.ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats); // 0x000000018D5CA76C-0x000000018D5CC15C
		private static Material CreateBlitShader(float colorConversion); // 0x000000018D5C9140-0x000000018D5C930C
		private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode); // 0x000000018D5C9A20-0x000000018D5C9CC4
		public static void ClosePaintElement(VisualElement ve, UIRStylePainter.ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats); // 0x000000018D5C8894-0x000000018D5C8A30
		private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<UnityEngine.UIElements.Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats); // 0x000000018D5CC4C8-0x000000018D5CC5D8
		private static void CopyTransformVertsPos(NativeSlice<UnityEngine.UIElements.Vertex> source, NativeSlice<UnityEngine.UIElements.Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 ids, Color32 addFlags, Color32 opacityPage, Color32 textCoreSettingsPage, bool isText, float textureId); // 0x000000018D5C8D94-0x000000018D5C8F4C
		private static void CopyTransformVertsPosAndVec(NativeSlice<UnityEngine.UIElements.Vertex> source, NativeSlice<UnityEngine.UIElements.Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 ids, Color32 addFlags, Color32 opacityPage, Color32 textCoreSettingsPage, bool isText, float textureId); // 0x000000018D5C8B5C-0x000000018D5C8D94
		private static void CopyTriangleIndicesFlipWindingOrder(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset); // 0x000000018D5C8F4C-0x000000018D5C90A8
		private static void CopyTriangleIndices(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset); // 0x000000018D5C90A8-0x000000018D5C9140
		public static bool NudgeVerticesToNewSpace(VisualElement ve, UIRenderDevice device); // 0x000000018D5CA3A4-0x000000018D5CA76C
		private static void DoNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, ref Matrix4x4 nudgeTransform); // 0x000000018D5C930C-0x000000018D5C96B0
		private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font, int stencilRef); // 0x000000018D5CA1D0-0x000000018D5CA314
		private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font, int stencilRef); // 0x000000018D5C9F78-0x000000018D5CA0C0
		private static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next); // 0x000000018D5C9830-0x000000018D5C9A20
		private static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next); // 0x000000018D5C96B0-0x000000018D5C9830
		private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next); // 0x000000018D5CA0C0-0x000000018D5CA1D0
		private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next); // 0x000000018D5C9E30-0x000000018D5C9F78
		public static void ResetCommands(RenderChain renderChain, VisualElement ve); // 0x000000018D5CC15C-0x000000018D5CC4C8
	
		// Extension methods
		private static bool IsParentOrAncestorOf(this VisualElement ve, VisualElement child); // 0x000000018D5CA314-0x000000018D5CA3A4
	}

	internal enum ClipMethod // TypeDefIndex: 72016
	{
		Undetermined = 0,
		NotClipped = 1,
		Scissor = 2,
		ShaderDiscard = 3,
		Stencil = 4
	}

	internal static class RenderEvents // TypeDefIndex: 72017
	{
		// Fields
		private static readonly float VisibilityTreshold; // 0x00
	
		// Constructors
		static RenderEvents(); // 0x000000018D5D1038-0x000000018D5D1074
	
		// Methods
		internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats); // 0x000000018D5D03F4-0x000000018D5D04E8
		internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats); // 0x000000018D5D0564-0x000000018D5D0660
		internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats); // 0x000000018D5D04E8-0x000000018D5D0564
		internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats); // 0x000000018D5D0660-0x000000018D5D072C
		internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats); // 0x000000018D5D072C-0x000000018D5D0820
		internal static void ProcessRegenText(RenderChain renderChain, VisualElement ve, UIRTextUpdatePainter painter, UIRenderDevice device, ref ChainBuilderStats stats); // 0x000000018D5D0820-0x000000018D5D087C
		private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve); // 0x000000018D5CFE6C-0x000000018D5CFFC4
		private static Vector4 GetClipRectIDClipInfo(VisualElement ve); // 0x000000018D5CFBE4-0x000000018D5CFE04
		internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState); // 0x000000018D5CE050-0x000000018D5CE664
		internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve); // 0x000000018D5CE664-0x000000018D5CEC1C
		private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats); // 0x000000018D5CEC1C-0x000000018D5CF0DC
		private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false /* Metadata: 0x026225C0 */); // 0x000000018D5CF0DC-0x000000018D5CF45C
		private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats); // 0x000000018D5D02D0-0x000000018D5D03F4
		private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats); // 0x000000018D5CF45C-0x000000018D5CF800
		private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats); // 0x000000018D5CF800-0x000000018D5CFAF4
		private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve); // 0x000000018D5D0C14-0x000000018D5D0F38
		private static bool IsElementHierarchyHidden(VisualElement ve); // 0x000000018D5D0270-0x000000018D5D0290
		private static VisualElement GetLastDeepestChild(VisualElement ve); // 0x000000018D5CFE04-0x000000018D5CFE6C
		private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve); // 0x000000018D5CFAF4-0x000000018D5CFBE4
		private static bool UpdateLocalFlipsWinding(VisualElement ve); // 0x000000018D5D0B58-0x000000018D5D0C14
		private static void UpdateWorldFlipsWinding(VisualElement ve); // 0x000000018D5D0F38-0x000000018D5D0FA0
		private static void UpdateZeroScaling(VisualElement ve); // 0x000000018D5D0FA0-0x000000018D5D1038
		private static bool NeedsTransformID(VisualElement ve); // 0x000000018D5D02AC-0x000000018D5D02D0
		internal static bool NeedsColorID(VisualElement ve); // 0x000000018D5D0290-0x000000018D5D02AC
		private static bool InitColorIDs(RenderChain renderChain, VisualElement ve); // 0x000000018D5CFFC4-0x000000018D5D0270
		private static void SetColorValues(RenderChain renderChain, VisualElement ve); // 0x000000018D5D087C-0x000000018D5D0B58
	}

	internal class UIRStylePainter : IStylePainter, IDisposable // TypeDefIndex: 72021
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MeshGenerationContext _meshGenerationContext_k__BackingField; // 0x158
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisualElement _currentElement_k__BackingField; // 0x160
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _totalVertices_k__BackingField; // 0x168
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _totalIndices_k__BackingField; // 0x16C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _disposed_k__BackingField; // 0x170
	
		// Properties
		public MeshGenerationContext meshGenerationContext { [CompilerGenerated] get; } // 0x000000018723BD30-0x000000018723BD40 
		public VisualElement currentElement { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723BD40-0x000000018723BD50 0x0000000188DC45AC-0x0000000188DC45C0
		public List<Entry> entries { get; } // 0x0000000187244530-0x0000000187244540 
		public ClosingInfo closingInfo { get; } // 0x0000000187262E60-0x0000000187262EA0 
		public int totalVertices { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233F30-0x0000000187233F40 0x0000000187233F40-0x0000000187233F50
		public int totalIndices { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E330-0x000000018723E340 0x000000018723E3A0-0x000000018723E3B0
		protected bool disposed { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E4A0-0x000000018723E4B0 0x000000018723E4B0-0x000000018723E4C0
		public VisualElement visualElement { get; } // 0x0000000187262EA0-0x0000000187262EB0 
	
		// Nested types
		internal struct Entry // TypeDefIndex: 72018
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
	
		internal struct ClosingInfo // TypeDefIndex: 72019
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
	
		internal struct TempDataAlloc<T> : IDisposable // TypeDefIndex: 72020
			where T : struct
		{
			// Fields
			private int maxPoolElemCount;
			private NativeArray<T> pool;
			private List<NativeArray<T>> excess;
			private uint takenFromPool;
	
			// Constructors
			public TempDataAlloc(int maxPoolElems);
	
			// Methods
			public void Dispose();
			internal NativeSlice<T> Alloc(uint count);
			internal void SessionDone();
		}
	
		// Constructors
		public UIRStylePainter(RenderChain renderChain); // 0x000000018D5E8228-0x000000018D5E85E0
	
		// Methods
		private MeshWriteData GetPooledMeshWriteData(); // 0x000000018D5E7C30-0x000000018D5E7CF4
		private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData); // 0x000000018D5E3328-0x000000018D5E3408
		private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData); // 0x000000018D5E3434-0x000000018D5E3460
		private MeshWriteData AllocThroughDrawGradients(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData); // 0x000000018D5E3408-0x000000018D5E3434
		public void Dispose(); // 0x000000018D5E3D94-0x000000018D5E3DE4
		protected void Dispose(bool disposing); // 0x000000018D5E3DE4-0x000000018D5E3E64
		public void Begin(VisualElement ve); // 0x000000018D5E3944-0x000000018D5E3D94
		public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd); // 0x000000018D5E7D8C-0x000000018D5E7DFC
		public void LandClipRegisterMesh(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices, int indexOffset); // 0x000000018D5E7CF4-0x000000018D5E7D8C
		public MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, TextureId texture, Material material, MeshGenerationContext.MeshFlags flags); // 0x000000018D5E2D18-0x000000018D5E2FD0
		public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags); // 0x000000018D5E415C-0x000000018D5E45AC
		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint); // 0x000000018D5E5D9C-0x000000018D5E5EEC
		internal void DrawTextNative(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint); // 0x000000018D5E5748-0x000000018D5E5D9C
		internal void DrawTextCore(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint); // 0x000000018D5E5218-0x000000018D5E5748
		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams); // 0x000000018D5E45AC-0x000000018D5E4C70
		public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams); // 0x000000018D5E3E64-0x000000018D5E4030
		public void DrawImmediate(Action callback, bool cullingEnabled); // 0x000000018D5E4030-0x000000018D5E415C
		public void DrawVisualElementBackground(); // 0x000000018D5E63F8-0x000000018D5E6E78
		public void DrawVisualElementBorder(); // 0x000000018D5E6E78-0x000000018D5E7364
		public void ApplyVisualElementClipping(); // 0x000000018D5E374C-0x000000018D5E3944
		private ushort[] AdjustSpriteWinding(Vector2[] vertices, ushort[] indices); // 0x000000018D5E2FD0-0x000000018D5E3328
		public void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams); // 0x000000018D5E4C70-0x000000018D5E5218
		private void ApplyInset(ref MeshGenerationContextUtils.RectangleParams rectParams, Texture tex); // 0x000000018D5E3460-0x000000018D5E374C
		public void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams); // 0x000000018D5E5EEC-0x000000018D5E63F8
		internal void Reset(); // 0x000000018D5E7DFC-0x000000018D5E7EE8
		private void ValidateMeshWriteData(); // 0x000000018D5E7EE8-0x000000018D5E8228
		private void GenerateStencilClipEntryForRoundedRectBackground(); // 0x000000018D5E7364-0x000000018D5E79B8
		private void GenerateStencilClipEntryForSVGBackground(); // 0x000000018D5E79B8-0x000000018D5E7C30
	}

	internal class UIRTextUpdatePainter : IStylePainter, IDisposable // TypeDefIndex: 72022
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
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MeshGenerationContext _meshGenerationContext_k__BackingField; // 0x60
	
		// Properties
		public MeshGenerationContext meshGenerationContext { [CompilerGenerated] get; } // 0x0000000187232FA0-0x0000000187232FB0 
	
		// Constructors
		public UIRTextUpdatePainter(); // 0x000000018D5E8F50-0x000000018D5E8FB8
	
		// Methods
		public void Begin(VisualElement ve, UIRenderDevice device); // 0x000000018D5E85E0-0x000000018D5E8870
		public void End(); // 0x000000018D5E8EBC-0x000000018D5E8F50
		public void Dispose(); // 0x000000018D5E8870-0x000000018D5E88F0
		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams); // 0x0000000186805BA0-0x0000000186805BB0
		public void DrawImmediate(Action callback, bool cullingEnabled); // 0x0000000186805BA0-0x0000000186805BB0
		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint); // 0x000000018D5E88F0-0x000000018D5E8EBC
	}
}
