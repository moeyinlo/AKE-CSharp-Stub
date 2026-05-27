/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Pool;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.U2D;
using UnityEngine.UI.Collections;
using UnityEngine.UI.CoroutineTween;
using UnityEngine.UIElements;

// Image 32: UnityEngine.UI.dll - Assembly: UnityEngine.UI, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53790-54018

namespace Unity.Profiling
{
	[IsReadOnly]
	public struct ProfilerCounter<T> // TypeDefIndex: 54001
		where T : struct
	{
		// Constructors
		public ProfilerCounter(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit) {}
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Sample(T value) {}
	}

	[IsReadOnly]
	public struct ProfilerCounterValue<T> // TypeDefIndex: 54002
		where T : struct
	{
		// Properties
		public T Value { get => default; set {} }
	
		// Constructors
		public ProfilerCounterValue(string name) : this() {}
		public ProfilerCounterValue(string name, ProfilerMarkerDataUnit dataUnit) : this() {}
		public ProfilerCounterValue(string name, ProfilerMarkerDataUnit dataUnit, ProfilerCounterOptions counterOptions) : this() {}
		public ProfilerCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit) : this() {}
		public ProfilerCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit, ProfilerCounterOptions counterOptions) : this() {}
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Sample() {}
	}

	[IsReadOnly]
	public struct ProfilerMarker<TP1> // TypeDefIndex: 54004
		where TP1 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 54003
		{
			// Constructors
			internal AutoScope(ProfilerMarker<TP1> marker, TP1 p1) {}
	
			// Methods
			public void Dispose() {}
		}
	
		// Constructors
		public ProfilerMarker(string name, string param1Name) {}
		public ProfilerMarker(ProfilerCategory category, string name, string param1Name) {}
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Begin(TP1 p1) {}
		[Conditional("ENABLE_PROFILER")]
		public void End() {}
		public AutoScope Auto(TP1 p1) => default;
	}

	[IsReadOnly]
	public struct ProfilerMarker<TP1, TP2> // TypeDefIndex: 54006
		where TP1 : struct
		where TP2 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 54005
		{
			// Constructors
			internal AutoScope(ProfilerMarker<TP1, TP2> marker, TP1 p1, TP2 p2) {}
	
			// Methods
			public void Dispose() {}
		}
	
		// Constructors
		public ProfilerMarker(string name, string param1Name, string param2Name) {}
		public ProfilerMarker(ProfilerCategory category, string name, string param1Name, string param2Name) {}
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Begin(TP1 p1, TP2 p2) {}
		[Conditional("ENABLE_PROFILER")]
		public void End() {}
		public AutoScope Auto(TP1 p1, TP2 p2) => default;
	}

	[IsReadOnly]
	public struct ProfilerMarker<TP1, TP2, TP3> // TypeDefIndex: 54008
		where TP1 : struct
		where TP2 : struct
		where TP3 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 54007
		{
			// Constructors
			internal AutoScope(ProfilerMarker<TP1, TP2, TP3> marker, TP1 p1, TP2 p2, TP3 p3) {}
	
			// Methods
			public void Dispose() {}
		}
	
		// Constructors
		public ProfilerMarker(string name, string param1Name, string param2Name, string param3Name) {}
		public ProfilerMarker(ProfilerCategory category, string name, string param1Name, string param2Name, string param3Name) {}
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Begin(TP1 p1, TP2 p2, TP3 p3) {}
		[Conditional("ENABLE_PROFILER")]
		public void End() {}
		public AutoScope Auto(TP1 p1, TP2 p2, TP3 p3) => default;
	}

	public static class ProfilerMarkerExtension // TypeDefIndex: 54010
	{
		// Nested types
		[IsReadOnly]
		public struct ProfilerMarkerScope : IDisposable // TypeDefIndex: 54009
		{
			// Constructors
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker) {} // 0x0000000189F7E4E0-0x0000000189F7E554
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, int context) {} // 0x0000000189F7E9AC-0x0000000189F7EA20
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context) {} // 0x0000000189F7E8BC-0x0000000189F7E934
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, float context) {} // 0x0000000189F7E934-0x0000000189F7E9AC
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, string context) {} // 0x0000000189F7E694-0x0000000189F7E70C
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, string context, string context2) {} // 0x0000000189F7E554-0x0000000189F7E5CC
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context, string context2) {} // 0x0000000189F7E48C-0x0000000189F7E4E0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context, long context2) {} // 0x0000000189F7E70C-0x0000000189F7E7E4
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, UnityEngine.Object obj) {} // 0x0000000189F7E7E4-0x0000000189F7E8BC
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, Transform transform, bool path) {} // 0x0000000189F7E5CC-0x0000000189F7E694
	
			// Methods
			public void Dispose() {} // 0x000000018115F4C0-0x000000018115F530
		}
	
		// Extension methods
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, int metadata) {} // 0x0000000183D89EF0-0x0000000183D89F00
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, uint metadata) {} // 0x0000000183D89EF0-0x0000000183D89F00
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata) {} // 0x0000000183D89EF0-0x0000000183D89F00
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, ulong metadata) {} // 0x0000000183D89EF0-0x0000000183D89F00
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, float metadata) {} // 0x0000000183D89EE0-0x0000000183D89EF0
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, double metadata) {} // 0x0000000183D89EE0-0x0000000183D89EF0
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, string metadata) {} // 0x0000000183D89EE0-0x0000000183D89EF0
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, string metadata, string metadata2) {} // 0x0000000183D89EE0-0x0000000183D89EF0
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata, string metadata2) {} // 0x000000018350B670-0x000000018350B680
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata, long metadata2) {} // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker) => default; // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, int context) => default; // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context) => default; // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, float context) => default; // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, string context) => default; // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, string context, string context2) => default; // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context, string context2) => default; // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context, long context2) => default; // 0x000000018350B670-0x000000018350B680
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, Transform transform, bool path = false /* Metadata: 0x01FD6273 */) => default; // 0x000000018350B670-0x000000018350B680
	}

	public struct MonoObject_64 // TypeDefIndex: 54011
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x08
	}

	public struct MonoObject_32 // TypeDefIndex: 54012
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x04
	}

	public struct MonoString_64 // TypeDefIndex: 54013
	{
		// Fields
		public MonoObject_64 obj; // 0x00
		public int length; // 0x10
		public char firstChar; // 0x14
	}

	public struct MonoString_32 // TypeDefIndex: 54014
	{
		// Fields
		public MonoObject_32 obj; // 0x00
		public int length; // 0x08
		public char firstChar; // 0x0C
	}

	public class ProfilerString : IDisposable // TypeDefIndex: 54015
	{
		// Fields
		private const int MAX = 256; // Metadata: 0x01FD6276
		private string m_buffer; // 0x10
		private int m_length; // 0x18
		private unsafe int* m_strCount; // 0x20
		private ulong m_handler; // 0x28
	
		// Constructors
		public ProfilerString() {} // Dummy constructor
		public ProfilerString(int count = 256 /* Metadata: 0x01FD6274 */) {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x000000018350B670-0x000000018350B680
		public override string ToString() => default; // 0x00000001820B7B20-0x00000001820B7B30
		public static implicit operator string(ProfilerString handle) => default; // 0x0000000189F7ED1C-0x0000000189F7ED3C
		public void Append(string value) {} // 0x0000000189F7EC34-0x0000000189F7ED1C
	}

	internal struct ProfilerUtility // TypeDefIndex: 54016
	{
		// Methods
		public static byte GetProfilerMarkerDataType<T>() => default;
	}
}

namespace UnityEngine.EventSystems
{
	public class AxisEventData : BaseEventData // TypeDefIndex: 53946
	{
		// Properties
		public Vector2 moveVector { get; set; } // 0x0000000183D71660-0x0000000183D71680 0x0000000183D4ED30-0x0000000183D4ED40
		public MoveDirection moveDir { get; set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
	
		// Constructors
		public AxisEventData() {} // Dummy constructor
		public AxisEventData(EventSystem eventSystem) {} // 0x0000000189F76CEC-0x0000000189F76D14
	}

	public abstract class AbstractEventData // TypeDefIndex: 53947
	{
		// Fields
		protected bool m_Used; // 0x10
	
		// Properties
		public virtual bool used { get; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		protected AbstractEventData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void Reset() {} // 0x0000000183D557C0-0x0000000183D557D0
		public virtual void Use() {} // 0x0000000181168960-0x0000000181168970
	}

	public class BaseEventData : AbstractEventData // TypeDefIndex: 53948
	{
		// Fields
		private readonly EventSystem m_EventSystem; // 0x18
	
		// Properties
		public BaseInputModule currentInputModule { get => default; } // 0x0000000185F986E4-0x0000000185F98700 
		public GameObject selectedObject { get => default; set {} } // 0x0000000185F407B4-0x0000000185F407D0 0x0000000189F76D14-0x0000000189F76D3C
	
		// Constructors
		public BaseEventData() {} // Dummy constructor
		public BaseEventData(EventSystem eventSystem) {} // 0x00000001822C3A90-0x00000001822C3AA0
	}

	public class PointerEventData : BaseEventData // TypeDefIndex: 53951
	{
		// Fields
		private GameObject m_PointerPress; // 0x28
		public List<GameObject> hovered; // 0xE0
	
		// Properties
		public GameObject pointerEnter { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public GameObject lastPress { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public GameObject rawPointerPress { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public GameObject pointerDrag { get; set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public GameObject pointerClick { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public RaycastResult pointerCurrentRaycast { get; set; } // 0x0000000183D89D10-0x0000000183D89D50 0x0000000189F7CA44-0x0000000189F7CA7C
		public RaycastResult pointerPressRaycast { get; set; } // 0x0000000183D89D50-0x0000000183D89D90 0x0000000189F7CA7C-0x0000000189F7CAC0
		public bool eligibleForClick { get; set; } // 0x0000000183D554A0-0x0000000183D554B0 0x0000000183D554D0-0x0000000183D554E0
		public int pointerId { get; set; } // 0x0000000183D58150-0x0000000183D58160 0x0000000183D68F50-0x0000000183D68F60
		public Vector2 position { get; set; } // 0x0000000183D56D10-0x0000000183D56D30 0x0000000183D51970-0x0000000183D51980
		public Vector2 delta { get; set; } // 0x0000000183D89CE0-0x0000000183D89D00 0x0000000183D89E20-0x0000000183D89E30
		public Vector2 pressPosition { get; set; } // 0x0000000183D89D90-0x0000000183D89DB0 0x0000000183D89E40-0x0000000183D89E50
		[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
		public Vector3 worldPosition { get; set; } // 0x0000000183D5C360-0x0000000183D5C380 0x0000000183D5C3A0-0x0000000183D5C3C0
		[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
		public Vector3 worldNormal { get; set; } // 0x0000000183D5B7A0-0x0000000183D5B7C0 0x0000000183D5B860-0x0000000183D5B880
		public float clickTime { get; set; } // 0x0000000183D583D0-0x0000000183D583E0 0x0000000183D884B0-0x0000000183D884C0
		public int clickCount { get; set; } // 0x0000000183D6DED0-0x0000000183D6DEE0 0x0000000183D742C0-0x0000000183D742D0
		public Vector2 scrollDelta { get; set; } // 0x0000000183D89DF0-0x0000000183D89E10 0x0000000183D89E70-0x0000000183D89E80
		public bool useDragThreshold { get; set; } // 0x0000000183D57B50-0x0000000183D57B60 0x0000000183D5A340-0x0000000183D5A350
		public bool dragging { get; set; } // 0x0000000183D89D00-0x0000000183D89D10 0x0000000183D89E30-0x0000000183D89E40
		public InputButton button { get; set; } // 0x0000000183D4FC40-0x0000000183D4FC50 0x0000000183D886C0-0x0000000183D886D0
		public float pressure { get; set; } // 0x0000000183D57590-0x0000000183D575A0 0x0000000183D59AB0-0x0000000183D59AC0
		public float tangentialPressure { get; set; } // 0x0000000183D57900-0x0000000183D57910 0x0000000183D86E50-0x0000000183D86E60
		public float altitudeAngle { get; set; } // 0x0000000183D56EB0-0x0000000183D56EC0 0x0000000183D56F30-0x0000000183D56F40
		public float azimuthAngle { get; set; } // 0x0000000183D57D40-0x0000000183D57D50 0x0000000183D89E10-0x0000000183D89E20
		public float twist { get; set; } // 0x0000000183D58220-0x0000000183D58230 0x0000000183D5B6A0-0x0000000183D5B6B0
		public Vector2 radius { get; set; } // 0x0000000183D89DD0-0x0000000183D89DF0 0x0000000183D89E60-0x0000000183D89E70
		public Vector2 radiusVariance { get; set; } // 0x0000000183D89DB0-0x0000000183D89DD0 0x0000000183D89E50-0x0000000183D89E60
		public bool fullyExited { get; set; } // 0x0000000183D5BC90-0x0000000183D5BCA0 0x0000000183D5BCE0-0x0000000183D5BCF0
		public bool reentered { get; set; } // 0x0000000183D5BC60-0x0000000183D5BC70 0x0000000183D5BCB0-0x0000000183D5BCC0
		public Camera enterEventCamera { get => default; } // 0x0000000189F7C938-0x0000000189F7C9BC 
		public Camera pressEventCamera { get => default; } // 0x0000000189F7C9BC-0x0000000189F7CA44 
		public GameObject pointerPress { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x00000001822C1E00-0x00000001822C1F70
	
		// Nested types
		public enum InputButton // TypeDefIndex: 53949
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		public enum FramePressState // TypeDefIndex: 53950
		{
			Pressed = 0,
			Released = 1,
			PressedAndReleased = 2,
			NotChanged = 3
		}
	
		// Constructors
		public PointerEventData() {} // Dummy constructor
		public PointerEventData(EventSystem eventSystem) {} // 0x00000001822C3990-0x00000001822C3A90
	
		// Methods
		public bool IsPointerMoving() => default; // 0x00000001822C22A0-0x00000001822C22D0
		public bool IsScrolling() => default; // 0x00000001828C1410-0x00000001828C1440
		public override string ToString() => default; // 0x0000000189F7C3B8-0x0000000189F7C938
	}

	[Flags]
	public enum EventHandle // TypeDefIndex: 53952
	{
		Unused = 0,
		Used = 1
	}

	public interface IEventSystemHandler // TypeDefIndex: 53953
	{
	}

	public interface IPointerMoveHandler : IEventSystemHandler // TypeDefIndex: 53954
	{
		// Methods
		void OnPointerMove(PointerEventData eventData);
	}

	public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 53955
	{
		// Methods
		void OnPointerEnter(PointerEventData eventData);
	}

	public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 53956
	{
		// Methods
		void OnPointerExit(PointerEventData eventData);
	}

	public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 53957
	{
		// Methods
		void OnPointerDown(PointerEventData eventData);
	}

	public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 53958
	{
		// Methods
		void OnPointerUp(PointerEventData eventData);
	}

	public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 53959
	{
		// Methods
		void OnPointerClick(PointerEventData eventData);
	}

	public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 53960
	{
		// Methods
		void OnBeginDrag(PointerEventData eventData);
	}

	public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 53961
	{
		// Methods
		void OnInitializePotentialDrag(PointerEventData eventData);
	}

	public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 53962
	{
		// Methods
		void OnDrag(PointerEventData eventData);
	}

	public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 53963
	{
		// Methods
		void OnEndDrag(PointerEventData eventData);
	}

	public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 53964
	{
		// Methods
		void OnDrop(PointerEventData eventData);
	}

	public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 53965
	{
		// Methods
		void OnScroll(PointerEventData eventData);
	}

	public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 53966
	{
		// Methods
		void OnUpdateSelected(BaseEventData eventData);
	}

	public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 53967
	{
		// Methods
		void OnSelect(BaseEventData eventData);
	}

	public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 53968
	{
		// Methods
		void OnDeselect(BaseEventData eventData);
	}

	public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 53969
	{
		// Methods
		void OnMove(AxisEventData eventData);
	}

	public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 53970
	{
		// Methods
		void OnSubmit(BaseEventData eventData);
	}

	public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 53971
	{
		// Methods
		void OnCancel(BaseEventData eventData);
	}

	[AddComponentMenu("Event/Event System")]
	[DisallowMultipleComponent]
	public class EventSystem : UIBehaviour // TypeDefIndex: 53975
	{
		// Fields
		private List<BaseInputModule> m_SystemInputModules; // 0x18
		private BaseInputModule m_CurrentInputModule; // 0x20
		private static List<EventSystem> m_EventSystems; // 0x00
		[FormerlySerializedAs("m_Selected")]
		[SerializeField]
		private GameObject m_FirstSelected; // 0x28
		[SerializeField]
		private bool m_sendNavigationEvents; // 0x30
		[SerializeField]
		private int m_DragThreshold; // 0x34
		private GameObject m_CurrentSelected; // 0x38
		private bool m_HasFocus; // 0x40
		private bool m_SelectionGuard; // 0x41
		private BaseEventData m_DummyData; // 0x48
		private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x08
		private static UIToolkitOverrideConfig s_UIToolkitOverride; // 0x10
	
		// Properties
		public static EventSystem current { get => default; set {} } // 0x0000000183D4EF70-0x0000000183D4EF80 0x0000000183D4EE00-0x0000000183D4EE10
		public bool sendNavigationEvents { get => default; set {} } // 0x0000000183D4EE40-0x0000000183D4EE50 0x0000000183D4EB40-0x0000000183D4EB50
		public int pixelDragThreshold { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public BaseInputModule currentInputModule { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public GameObject firstSelectedGameObject { get => default; set {} } // 0x0000000181002730-0x0000000181002740 0x0000000183D4EE90-0x0000000183D4EEA0
		public GameObject currentSelectedGameObject { get => default; } // 0x0000000183CE10A0-0x0000000183CE1130 
		[Obsolete("lastSelectedGameObject is no longer supported")]
		public GameObject lastSelectedGameObject { get => default; } // 0x00000001837A0510-0x00000001837A0620 
		public bool isFocused { get => default; } // 0x0000000183D4F7B0-0x0000000183D4F7C0 
		public bool alreadySelecting { get => default; } // 0x0000000189F77FDC-0x0000000189F78010 
		private BaseEventData baseEventDataCache { get => default; } // 0x00000001823964C0-0x00000001823968C0 
		private bool isUIToolkitActiveEventSystem { get => default; } // 0x0000000189F78010-0x0000000189F78154 
		private bool sendUIToolkitEvents { get => default; } // 0x0000000189F77B94-0x0000000189F77DD4 
		private bool createUIToolkitPanelGameObjectsOnStart { get => default; } // 0x00000001836FDF00-0x00000001836FE8C0 
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 53972
		{
			// Fields
			public static readonly ProfilerMarker Update; // 0x00
			public static readonly ProfilerMarker TickModules; // 0x08
			public static readonly ProfilerMarker CurrentModuleProcess; // 0x10
			public static readonly ProfilerMarker RaycastAll; // 0x18
			public static readonly ProfilerMarker RaycastAllSort; // 0x20
	
			// Constructors
			static ProfilerMarkers() {} // 0x00000001822B2A60-0x00000001822B2B40
		}
	
		private struct UIToolkitOverrideConfig // TypeDefIndex: 53973
		{
			// Fields
			public EventSystem activeEventSystem; // 0x00
			public bool sendEvents; // 0x08
			public bool createPanelGameObjectsOnStart; // 0x09
		}
	
		// Constructors
		protected EventSystem() {} // 0x00000001822C3500-0x00000001822C3840
		static EventSystem() {} // 0x0000000189F84150-0x0000000189F841A0
	
		// Methods
		public void UpdateModules() {} // 0x0000000189F78284-0x0000000189F782F8
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) {} // 0x000000018231A230-0x000000018231A780
		public void SetSelectedGameObject(GameObject selected) {} // 0x0000000189F77E54-0x0000000189F77E64
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) => default; // 0x0000000189F77DD4-0x0000000189F77E54
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) {} // 0x00000001836FEAB0-0x00000001836FEBA0
		public bool IsPointerOverGameObject() => default; // 0x00000001836FDE90-0x00000001836FDF00
		public bool IsPointerOverGameObject(int pointerId) => default; // 0x00000001836FE960-0x00000001836FE9D0
		public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true /* Metadata: 0x01FD6254 */, bool createPanelGameObjectsOnStart = true /* Metadata: 0x01FD6255 */) {} // 0x0000000189F77E64-0x0000000189F77EF4
		private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) {} // 0x00000001836FDDD0-0x00000001836FDE90
		protected override void Start() {} // 0x0000000189F77EF4-0x0000000189F77FDC
		protected override void OnDestroy() {} // 0x00000001822B22A0-0x00000001822B2A60
		protected override void OnEnable() {} // 0x0000000183134980-0x00000001831349A0
		protected override void OnDisable() {} // 0x00000001822B1F30-0x00000001822B22A0
		private void TickModules() {} // 0x0000000183C850A0-0x0000000183C85190
		protected virtual void OnApplicationFocus(bool hasFocus) {} // 0x0000000189F78154-0x0000000189F78284
		protected virtual void Update() {} // 0x0000000183B20B10-0x0000000183B20C60
		private void ChangeEventModule(BaseInputModule module) {} // 0x0000000183B1D970-0x0000000183B1DAC0
		public override string ToString() => default; // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("Event/Event Trigger")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, UnityEngine.EventSystems.IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 53978
	{
		// Fields
		[FormerlySerializedAs("delegates")]
		[SerializeField]
		private List<Entry> m_Delegates; // 0x18
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", true)]
		public List<Entry> delegates { get => default; set {} } // 0x000000018426FE60-0x000000018426FE68 0x0000000189F78654-0x0000000189F786D8
		public List<Entry> triggers { get => default; set {} } // 0x0000000189F78454-0x0000000189F7853C 0x0000000189F785DC-0x0000000189F785EC
	
		// Nested types
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 53976
		{
			// Constructors
			public TriggerEvent() {} // 0x0000000189F7864C-0x0000000189F78654
		}
	
		[Serializable]
		public class Entry // TypeDefIndex: 53977
		{
			// Fields
			public EventTriggerType eventID; // 0x10
			public TriggerEvent callback; // 0x18
	
			// Constructors
			public Entry() {} // 0x00000001822C3A90-0x00000001822C3AA0
		}
	
		// Constructors
		protected EventTrigger() {} // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Methods
		private void Execute(EventTriggerType id, BaseEventData eventData) {} // 0x0000000189F785EC-0x0000000189F785FC
		public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x0000000189F7856C-0x0000000189F7857C
		public virtual void OnPointerExit(PointerEventData eventData) {} // 0x0000000189F7857C-0x0000000189F7858C
		public virtual void OnDrag(PointerEventData eventData) {} // 0x0000000189F785CC-0x0000000189F785DC
		public virtual void OnDrop(PointerEventData eventData) {} // 0x0000000189F785FC-0x0000000189F7860C
		public virtual void OnPointerDown(PointerEventData eventData) {} // 0x0000000189F785BC-0x0000000189F785CC
		public virtual void OnPointerUp(PointerEventData eventData) {} // 0x0000000189F7861C-0x0000000189F7862C
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000189F7855C-0x0000000189F7856C
		public virtual void OnSelect(BaseEventData eventData) {} // 0x0000000189F7860C-0x0000000189F7861C
		public virtual void OnDeselect(BaseEventData eventData) {} // 0x0000000189F785AC-0x0000000189F785BC
		public virtual void OnScroll(PointerEventData eventData) {} // 0x0000000189F7863C-0x0000000189F7864C
		public virtual void OnMove(AxisEventData eventData) {} // 0x0000000189F7859C-0x0000000189F785AC
		public virtual void OnUpdateSelected(BaseEventData eventData) {} // 0x0000000189F7853C-0x0000000189F7854C
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x0000000189F7858C-0x0000000189F7859C
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189F7862C-0x0000000189F7863C
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x0000000189F7854C-0x0000000189F7855C
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000189F84114-0x0000000189F84150
		public virtual void OnCancel(BaseEventData eventData) {} // 0x0000000189F77B28-0x0000000189F77B94
	}

	public enum EventTriggerType // TypeDefIndex: 53979
	{
		PointerEnter = 0,
		PointerExit = 1,
		PointerDown = 2,
		PointerUp = 3,
		PointerClick = 4,
		Drag = 5,
		Drop = 6,
		Scroll = 7,
		UpdateSelected = 8,
		Select = 9,
		Deselect = 10,
		Move = 11,
		InitializePotentialDrag = 12,
		BeginDrag = 13,
		EndDrag = 14,
		Submit = 15,
		Cancel = 16
	}

	public static class ExecuteEvents // TypeDefIndex: 53981
	{
		// Fields
		private static readonly EventFunction<IPointerMoveHandler> s_PointerMoveHandler; // 0x00
		private static readonly EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x08
		private static readonly EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x10
		private static readonly EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x18
		private static readonly EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x20
		private static readonly EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x28
		private static readonly EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x30
		private static readonly EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x38
		private static readonly EventFunction<IDragHandler> s_DragHandler; // 0x40
		private static readonly EventFunction<IEndDragHandler> s_EndDragHandler; // 0x48
		private static readonly EventFunction<IDropHandler> s_DropHandler; // 0x50
		private static readonly EventFunction<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler; // 0x58
		private static readonly EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x60
		private static readonly EventFunction<ISelectHandler> s_SelectHandler; // 0x68
		private static readonly EventFunction<IDeselectHandler> s_DeselectHandler; // 0x70
		private static readonly EventFunction<IMoveHandler> s_MoveHandler; // 0x78
		private static readonly EventFunction<ISubmitHandler> s_SubmitHandler; // 0x80
		private static readonly EventFunction<ICancelHandler> s_CancelHandler; // 0x88
		private static readonly List<Transform> s_InternalTransformList; // 0x90
	
		// Properties
		public static EventFunction<IPointerMoveHandler> pointerMoveHandler { get; } // 0x0000000189F78CC0-0x0000000189F78D10 
		public static EventFunction<IPointerEnterHandler> pointerEnterHandler { get; } // 0x0000000189F78B30-0x0000000189F78B80 
		public static EventFunction<IPointerExitHandler> pointerExitHandler { get; } // 0x0000000189F78A90-0x0000000189F78AE0 
		public static EventFunction<IPointerDownHandler> pointerDownHandler { get; } // 0x0000000189F788AC-0x0000000189F788FC 
		public static EventFunction<IPointerUpHandler> pointerUpHandler { get; } // 0x0000000189F789A0-0x0000000189F789F0 
		public static EventFunction<IPointerClickHandler> pointerClickHandler { get; } // 0x0000000189F78A40-0x0000000189F78A90 
		public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; } // 0x0000000189F789F0-0x0000000189F78A40 
		public static EventFunction<IBeginDragHandler> beginDragHandler { get; } // 0x0000000189F78D10-0x0000000189F78D60 
		public static EventFunction<IDragHandler> dragHandler { get; } // 0x0000000189F78E04-0x0000000189F78E54 
		public static EventFunction<IEndDragHandler> endDragHandler { get; } // 0x0000000189F78D60-0x0000000189F78DB0 
		public static EventFunction<IDropHandler> dropHandler { get; } // 0x0000000189F78950-0x0000000189F789A0 
		public static EventFunction<UnityEngine.EventSystems.IScrollHandler> scrollHandler { get; } // 0x0000000189F78AE0-0x0000000189F78B30 
		public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; } // 0x0000000189F78DB0-0x0000000189F78E04 
		public static EventFunction<ISelectHandler> selectHandler { get; } // 0x0000000189F788FC-0x0000000189F78950 
		public static EventFunction<IDeselectHandler> deselectHandler { get; } // 0x0000000182704D50-0x0000000182704E60 
		public static EventFunction<IMoveHandler> moveHandler { get; }
		public static EventFunction<ISubmitHandler> submitHandler { get; }
		public static EventFunction<ICancelHandler> cancelHandler { get; }
	
		// Nested types
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData); // TypeDefIndex: 53980; 0x0000000189F786F0-0x0000000189F787AC
	
		// Constructors
		static ExecuteEvents() {}
	
		// Methods
		public static T ValidateEventData<T>(BaseEventData data)
			where T : class => default; // 0x000000018284C450-0x000000018284C630
		private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) {} // 0x000000018284C630-0x000000018284C7F0
		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) {} // 0x000000018284C290-0x000000018284C450
		private static void Execute(IPointerExitHandler handler, BaseEventData eventData) {} // 0x0000000183B41430-0x0000000183B414F0
		private static void Execute(IPointerDownHandler handler, BaseEventData eventData) {} // 0x0000000183976620-0x00000001839766E0
		private static void Execute(IPointerUpHandler handler, BaseEventData eventData) {} // 0x0000000182911820-0x0000000182911900
		private static void Execute(IPointerClickHandler handler, BaseEventData eventData) {} // 0x0000000183126290-0x0000000183126350
		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) {} // 0x0000000189F787C4-0x0000000189F78838
		private static void Execute(IBeginDragHandler handler, BaseEventData eventData) {} // 0x00000001828C1330-0x00000001828C1410
		private static void Execute(IDragHandler handler, BaseEventData eventData) {} // 0x0000000182CD92C0-0x0000000182CD9330
		private static void Execute(IEndDragHandler handler, BaseEventData eventData) {} // 0x0000000183CDD030-0x0000000183CDD0A0
		private static void Execute(IDropHandler handler, BaseEventData eventData) {} // 0x0000000183CBAA70-0x0000000183CBAAE0
		private static void Execute(UnityEngine.EventSystems.IScrollHandler handler, BaseEventData eventData) {} // 0x0000000189F78838-0x0000000189F788AC
		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) {} // 0x0000000189F787AC-0x0000000189F787C4
		private static void Execute(ISelectHandler handler, BaseEventData eventData) {} // 0x0000000189F786D8-0x0000000189F786F0
		private static void Execute(IDeselectHandler handler, BaseEventData eventData) {} // 0x0000000189F78C70-0x0000000189F78CC0
		private static void Execute(IMoveHandler handler, BaseEventData eventData) {} // 0x0000000189F78BD0-0x0000000189F78C20
		private static void Execute(ISubmitHandler handler, BaseEventData eventData) {} // 0x0000000189F78C20-0x0000000189F78C70
		private static void Execute(ICancelHandler handler, BaseEventData eventData) {} // 0x0000000189F78B80-0x0000000189F78BD0
		private static void GetEventChain(GameObject root, IList<Transform> eventChain) {}
		public static bool Execute<T>(GameObject target, BaseEventData eventData, EventFunction<T> functor)
			where T : IEventSystemHandler => default;
		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction)
			where T : IEventSystemHandler => default;
		private static bool ShouldSendToComponent<T>(UnityEngine.Component component)
			where T : IEventSystemHandler => default; // 0x0000000182E20360-0x0000000182E20BB0
		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results)
			where T : IEventSystemHandler {}
		public static bool CanHandleEvent<T>(GameObject go)
			where T : IEventSystemHandler => default;
		public static GameObject GetEventHandler<T>(GameObject root)
			where T : IEventSystemHandler => default;
	}

	public class BaseInput : UIBehaviour // TypeDefIndex: 53982
	{
		// Properties
		public virtual string compositionString { get => default; } // 0x00000001836E6FE0-0x00000001836E6FF0 
		public virtual IMECompositionMode imeCompositionMode { get => default; set {} } // 0x0000000189F77644-0x0000000189F7764C 0x00000001842768C0-0x00000001842768CC
		public virtual Vector2 compositionCursorPos { get => default; set {} } // 0x0000000189F7763C-0x0000000189F77644 0x000000018427312C-0x0000000184273148
		public virtual bool mousePresent { get => default; } // 0x0000000189E75CCC-0x0000000189E75CD4 
		public virtual Vector2 mousePosition { get => default; } // 0x0000000189F7764C-0x0000000189F77674 
		public virtual Vector2 mouseScrollDelta { get => default; } // 0x0000000189F77674-0x0000000189F7767C 
		public virtual bool touchSupported { get => default; } // 0x0000000189F7767C-0x0000000189F77684 
		public virtual int touchCount { get => default; } // 0x00000001889CEE70-0x00000001889CEE78 
	
		// Constructors
		public BaseInput() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public virtual bool GetMouseButtonDown(int button) => default; // 0x0000000189F77618-0x0000000189F77624
		public virtual bool GetMouseButtonUp(int button) => default; // 0x0000000189F77624-0x0000000189F77630
		public virtual bool GetMouseButton(int button) => default; // 0x0000000189F77630-0x0000000189F7763C
		public virtual Touch GetTouch(int index) => default; // 0x000000018943BB00-0x000000018943BB48
		public virtual float GetAxisRaw(string axisName) => default; // 0x0000000189F7760C-0x0000000189F77618
		public virtual bool GetButtonDown(string buttonName) => default; // 0x0000000189E75CC0-0x0000000189E75CCC
	}

	[RequireComponent(typeof(EventSystem))]
	public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 53983
	{
		// Fields
		[NonSerialized]
		protected List<RaycastResult> m_RaycastResultCache; // 0x18
		private AxisEventData m_AxisEventData; // 0x20
		private EventSystem m_EventSystem; // 0x28
		private BaseEventData m_BaseEventData; // 0x30
		protected BaseInput m_InputOverride; // 0x38
		private BaseInput m_DefaultInput; // 0x40
	
		// Properties
		public BaseInput input { get; } // 0x00000001822B4110-0x00000001822B42A0 
		public BaseInput inputOverride { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		protected EventSystem eventSystem { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		protected BaseInputModule() {} // 0x000000018284AC10-0x000000018284AC90
	
		// Methods
		protected override void OnEnable() {} // 0x00000001837A0440-0x00000001837A04A0
		protected override void OnDisable() {} // 0x0000000189F775EC-0x0000000189F7760C
		public abstract void Process();
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) => default; // 0x00000001822C2F90-0x00000001822C31D0
		protected static MoveDirection DetermineMoveDirection(float x, float y) => default; // 0x0000000189F76E28-0x0000000189F76E38
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) => default; // 0x0000000189F76DB8-0x0000000189F76E28
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) => default; // 0x00000001830FB710-0x00000001830FB950
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) {} // 0x0000000189F76F20-0x0000000189F775EC
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) => default; // 0x0000000189F76E38-0x0000000189F76F20
		protected virtual BaseEventData GetBaseEventData() => default; // 0x00000001822C3900-0x00000001822C3990
		public virtual bool IsPointerOverGameObject(int pointerId) => default; // 0x000000018115F4C0-0x000000018115F530
		public virtual bool ShouldActivateModule() => default; // 0x00000001830DD5E0-0x00000001830DD650
		public virtual void DeactivateModule() {} // 0x000000018350B670-0x000000018350B680
		public virtual void ActivateModule() {} // 0x000000018350B670-0x000000018350B680
		public virtual void UpdateModule() {} // 0x000000018350B670-0x000000018350B680
		public virtual bool IsModuleSupported() => default; // 0x000000018232EB60-0x000000018232EB70
		public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) => default; // 0x0000000189F76D3C-0x0000000189F76DB8
	}

	public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 53987
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x01FD6267
		public const int kMouseRightId = -2; // Metadata: 0x01FD6268
		public const int kMouseMiddleId = -3; // Metadata: 0x01FD6269
		public const int kFakeTouchesId = -4; // Metadata: 0x01FD626A
		protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
		private readonly MouseState m_MouseState; // 0x50
	
		// Nested types
		protected class ButtonState // TypeDefIndex: 53984
		{
			// Fields
			private PointerEventData.InputButton m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get => default; set {} } // 0x0000000189F7D854-0x0000000189F7D948 0x0000000189F7DF70-0x0000000189F7DFCC
			public PointerEventData.InputButton button { get => default; set {} } // 0x0000000189F7D948-0x0000000189F7DC9C 0x0000000189F7D1EC-0x0000000189F7D36C
	
			// Constructors
			public ButtonState() {} // 0x0000000189F7DFCC-0x0000000189F7E044
		}
	
		protected class MouseState // TypeDefIndex: 53985
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState() {} // 0x0000000189F7DF24-0x0000000189F7DF70
	
			// Methods
			public bool AnyPressesThisFrame() => default; // 0x0000000189F7D460-0x0000000189F7D46C
			public bool AnyReleasesThisFrame() => default; // 0x0000000189F7D46C-0x0000000189F7D854
			public ButtonState GetButtonState(PointerEventData.InputButton button) => default; // 0x0000000189F7D438-0x0000000189F7D460
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) {} // 0x00000001893E9C98-0x00000001893E9CD8
		}
	
		public class MouseButtonEventData // TypeDefIndex: 53986
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData() {} // 0x0000000189F7D03C-0x0000000189F7D1EC
	
			// Methods
			public bool PressedThisFrame() => default; // 0x0000000189F7DD04-0x0000000189F7DF24
			public bool ReleasedThisFrame() => default; // 0x0000000189F7DC9C-0x0000000189F7DD04
		}
	
		// Constructors
		protected PointerInputModule() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected bool GetPointerData(int id, out PointerEventData data, bool create) {
			data = default;
			return default;
		} // 0x0000000189F7E044-0x0000000189F7E2D8
		protected void RemovePointerData(PointerEventData data) {} // 0x0000000189F7D36C-0x0000000189F7D438
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) {
			pressed = default;
			released = default;
			return default;
		} // 0x0000000189F7E2D8-0x0000000189F7E390
		protected void CopyFromTo(PointerEventData from, PointerEventData to) {} // 0x0000000181041090-0x00000001810410A0
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId) => default; // 0x00000001822C3A90-0x00000001822C3AA0
		protected virtual MouseState GetMousePointerEventData() => default; // 0x0000000183D4E340-0x0000000183D4E350
		protected virtual MouseState GetMousePointerEventData(int id) => default; // 0x00000001810410F0-0x0000000181041100
		protected PointerEventData GetLastPointerEventData(int id) => default; // 0x000000018350B670-0x000000018350B680
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) => default; // 0x0000000189F78F8C-0x0000000189F7902C
		protected virtual void ProcessMove(PointerEventData pointerEvent) {} // 0x0000000189F7902C-0x0000000189F790CC
		protected virtual void ProcessDrag(PointerEventData pointerEvent) {} // 0x0000000189F790CC-0x0000000189F79204
		public override bool IsPointerOverGameObject(int pointerId) => default; // 0x0000000189F79204-0x0000000189F79254
		protected void ClearSelection() {} // 0x0000000189F79254-0x0000000189F792CC
		public override string ToString() => default; // 0x00000001893E67CC-0x00000001893E67E0
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) {} // 0x00000001871262D0-0x00000001871262E4
	}

	[AddComponentMenu("Event/Standalone Input Module")]
	public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 53990
	{
		// Fields
		private float m_PrevActionTime; // 0x58
		private Vector2 m_LastMoveVector; // 0x5C
		private int m_ConsecutiveMoveCount; // 0x64
		private Vector2 m_LastMousePosition; // 0x68
		private Vector2 m_MousePosition; // 0x70
		private GameObject m_CurrentFocusedGameObject; // 0x78
		private PointerEventData m_InputPointerEvent; // 0x80
		[SerializeField]
		private string m_HorizontalAxis; // 0x88
		[SerializeField]
		private string m_VerticalAxis; // 0x90
		[SerializeField]
		private string m_SubmitButton; // 0x98
		[SerializeField]
		private string m_CancelButton; // 0xA0
		[SerializeField]
		private float m_InputActionsPerSecond; // 0xA8
		[SerializeField]
		private float m_RepeatDelay; // 0xAC
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[HideInInspector]
		[SerializeField]
		private bool m_ForceModuleActive; // 0xB0
	
		// Properties
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public InputMode inputMode { get => default; } // 0x0000000181151530-0x0000000181151540 
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnMobileDevice { get => default; set {} } // 0x0000000181151540-0x0000000181151550 0x0000000181151530-0x0000000181151540
		[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
		public bool forceModuleActive { get => default; set {} } // 0x0000000181151540-0x0000000181151550 0x0000000183D58510-0x0000000183D58520
		public float inputActionsPerSecond { get => default; set {} } // 0x0000000183D6DF40-0x0000000183D6DF50 0x0000000183D58380-0x0000000183D58390
		public float repeatDelay { get => default; set {} } // 0x0000000183D6DF50-0x0000000183D6DF60 0x0000000183D4EA60-0x0000000183D4EA70
		public string horizontalAxis { get => default; set {} } // 0x0000000184274DA0-0x0000000184274DB4 0x0000000183D4EA90-0x0000000183D4EAA0
		public string verticalAxis { get => default; set {} } // 0x00000001851DFCB4-0x00000001851DFCC8 0x00000001811AC510-0x00000001811AC520
		public string submitButton { get => default; set {} } // 0x00000001851417AC-0x00000001851417C0 0x0000000183D4EA80-0x0000000183D4EA90
		public string cancelButton { get => default; set {} } // 0x0000000184270264-0x0000000184270278 0x000000018232EB60-0x000000018232EB70
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 53988
		{
			// Fields
			public static readonly ProfilerMarker Process; // 0x00
			public static readonly ProfilerMarker ProcessMouseEvent; // 0x08
			public static readonly ProfilerMarker ProcessMousePress; // 0x10
			public static readonly ProfilerMarker ProcessTouchEvents; // 0x18
			public static readonly ProfilerMarker ProcessTouchPress; // 0x20
	
			// Constructors
			static ProfilerMarkers() {} // 0x0000000189F8239C-0x0000000189F82470
		}
	
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode // TypeDefIndex: 53989
		{
			Mouse = 0,
			Buttons = 1
		}
	
		// Constructors
		protected StandaloneInputModule() {} // 0x0000000181002730-0x0000000181002740
	
		// Methods
		private bool ShouldIgnoreEventsOnNoFocus() => default; // 0x0000000189F82288-0x0000000189F8239C
		public override void UpdateModule() {} // 0x0000000189F81A98-0x0000000189F81D14
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) {} // 0x0000000189F820F0-0x0000000189F82288
		public override bool ShouldActivateModule() => default; // 0x0000000189F7F8D4-0x0000000189F7F9FC
		public override void ActivateModule() {} // 0x0000000189F7F9FC-0x0000000189F7FA04
		public override void DeactivateModule() {} // 0x0000000189F81940-0x0000000189F81A98
		public override void Process() {} // 0x0000000189F802EC-0x0000000189F80528
		private bool ProcessTouchEvents() => default; // 0x0000000189F80528-0x0000000189F81940
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x0000000189F81EB8-0x0000000189F8201C
		protected bool SendSubmitEventToSelectedObject() => default; // 0x0000000189F7FA04-0x0000000189F7FB08
		private Vector2 GetRawMoveVector() => default; // 0x0000000189F81D14-0x0000000189F81EB8
		protected bool SendMoveEventToSelectedObject() => default; // 0x0000000189F7FD38-0x0000000189F7FE00
		protected void ProcessMouseEvent() {} // 0x000000018115F4C0-0x000000018115F530
		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		protected virtual bool ForceAutoSelect() => default; // 0x0000000189F7FB08-0x0000000189F7FD38
		protected void ProcessMouseEvent(int id) {} // 0x0000000189F8201C-0x0000000189F820F0
		protected bool SendUpdateEventToSelectedObject() => default; // 0x0000000189F7FE00-0x0000000189F802EC
		protected void ProcessMousePress(MouseButtonEventData data) {} // 0x0000000183D4EB20-0x0000000183D4EB30
		protected GameObject GetCurrentFocusedGameObject() => default; // 0x0000000189F7EAF4-0x0000000189F7EC34
	}

	[AddComponentMenu("Event/Touch Input Module")]
	[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
	public class TouchInputModule : PointerInputModule // TypeDefIndex: 53992
	{
		// Fields
		private Vector2 m_LastMousePosition; // 0x58
		private Vector2 m_MousePosition; // 0x60
		private PointerEventData m_InputPointerEvent; // 0x68
		[FormerlySerializedAs("m_AllowActivationOnStandalone")]
		[SerializeField]
		private bool m_ForceModuleActive; // 0x70
	
		// Properties
		[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnStandalone { get => default; set {} } // 0x0000000183D4F290-0x0000000183D4F2A0 0x0000000183D4F260-0x0000000183D4F270
		public bool forceModuleActive { get => default; set {} } // 0x0000000183D4F290-0x0000000183D4F2A0 0x0000000189F83FB4-0x0000000189F840E8
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 53991
		{
			// Fields
			public static readonly ProfilerMarker Process; // 0x00
			public static readonly ProfilerMarker ProcessTouchEvents; // 0x08
			public static readonly ProfilerMarker ProcessTouchPress; // 0x10
	
			// Constructors
			static ProfilerMarkers() {} // 0x0000000189F8410C-0x0000000189F84114
		}
	
		// Constructors
		protected TouchInputModule() {} // 0x0000000183D4F260-0x0000000183D4F270
	
		// Methods
		public override void UpdateModule() {} // 0x0000000189F82560-0x0000000189F82590
		public override bool IsModuleSupported() => default; // 0x0000000189F83C60-0x0000000189F83D38
		public override bool ShouldActivateModule() => default; // 0x0000000189F840E8-0x0000000189F8410C
		private bool UseFakeInput() => default; // 0x0000000189F83B7C-0x0000000189F83C60
		public override void Process() {} // 0x0000000189F82470-0x0000000189F82560
		private void FakeTouches() {} // 0x0000000189F82590-0x0000000189F827A4
		private void ProcessTouchEvents() {} // 0x0000000189F827A4-0x0000000189F83B7C
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x0000000189F7F9FC-0x0000000189F7FA04
		public override void DeactivateModule() {} // 0x0000000189F83D38-0x0000000189F83FB4
		public override string ToString() => default; // 0x0000000189F7EA20-0x0000000189F7EAF4
	}

	public enum MoveDirection // TypeDefIndex: 53993
	{
		Left = 0,
		Up = 1,
		Right = 2,
		Down = 3,
		None = 4
	}

	internal static class RaycasterManager // TypeDefIndex: 53994
	{
		// Fields
		private static readonly List<BaseRaycaster> s_Raycasters; // 0x00
	
		// Constructors
		static RaycasterManager() {} // 0x0000000183CE3430-0x0000000183CE34C0
	
		// Methods
		public static void AddRaycaster(BaseRaycaster baseRaycaster) {} // 0x0000000183327490-0x0000000183327570
		public static List<BaseRaycaster> GetRaycasters() => default; // 0x0000000189F7F2B8-0x0000000189F7F308
		public static void RemoveRaycasters(BaseRaycaster baseRaycaster) {} // 0x0000000183327360-0x0000000183327440
	}

	public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 53995
	{
		// Fields
		private BaseRaycaster m_RootRaycaster; // 0x18
	
		// Properties
		public abstract Camera eventCamera { get; }
		[Obsolete("Please use sortOrderPriority and renderOrderPriority", false)]
		public virtual int priority { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual int sortOrderPriority { get; } // 0x0000000183D89CD0-0x0000000183D89CE0 
		public virtual int renderOrderPriority { get; } // 0x0000000183D89CD0-0x0000000183D89CE0 
		public BaseRaycaster rootRaycaster { get; } // 0x0000000182319F60-0x000000018231A0C0 
	
		// Constructors
		protected BaseRaycaster() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
		public override string ToString() => default; // 0x0000000189F7798C-0x0000000189F77B28
		protected override void OnEnable() {} // 0x0000000183327440-0x0000000183327490
		protected override void OnDisable() {} // 0x0000000183327310-0x0000000183327360
		protected override void OnCanvasHierarchyChanged() {} // 0x000000018364B0F0-0x000000018364B110
		protected override void OnTransformParentChanged() {} // 0x000000018364B0F0-0x000000018364B110
	}

	[AddComponentMenu("Event/Physics 2D Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class Physics2DRaycaster : PhysicsRaycaster // TypeDefIndex: 53996
	{
		// Fields
		private RaycastHit2D[] m_Hits; // 0x40
	
		// Constructors
		protected Physics2DRaycaster() {} // 0x0000000189F7BBA0-0x0000000189F7BBB0
	
		// Methods
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x0000000189F7B604-0x0000000189F7BBA0
	}

	[AddComponentMenu("Event/Physics Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 53998
	{
		// Fields
		protected const int kNoEventMaskSet = -1; // Metadata: 0x01FD6272
		protected Camera m_EventCamera; // 0x20
		[SerializeField]
		protected LayerMask m_EventMask; // 0x28
		[SerializeField]
		protected int m_MaxRayIntersections; // 0x2C
		protected int m_LastMaxRayIntersections; // 0x30
		private RaycastHit[] m_Hits; // 0x38
	
		// Properties
		public override Camera eventCamera { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		public virtual int depth { get => default; } // 0x0000000183D4EBA0-0x0000000183D4EBB0 
		public int finalEventMask { get => default; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 
		public LayerMask eventMask { get => default; set {} } // 0x0000000183D4EDE0-0x0000000183D4EDF0 0x0000000189F7BBB0-0x0000000189F7BE30
		public int maxRayIntersections { get => default; set {} } // 0x0000000189F7BE30-0x0000000189F7C21C 0x0000000189F7ED3C-0x0000000189F7ED68
	
		// Nested types
		private class RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 53997
		{
			// Fields
			public static RaycastHitComparer instance; // 0x00
	
			// Constructors
			public RaycastHitComparer() {} // 0x0000000189F7C2A0-0x0000000189F7C330
			static RaycastHitComparer() {} // 0x0000000189F7C21C-0x0000000189F7C2A0
	
			// Methods
			public int Compare(RaycastHit x, RaycastHit y) => default; // 0x0000000189F7BBA0-0x0000000189F7BBB0
		}
	
		// Constructors
		protected PhysicsRaycaster() {} // 0x0000000189F7C330-0x0000000189F7C3B8
	
		// Methods
		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) => default; // 0x000000018350B670-0x000000018350B680
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x0000000189F7ED68-0x0000000189F7EDCC
	}

	public struct RaycastResult // TypeDefIndex: 53999
	{
		// Fields
		private GameObject m_GameObject; // 0x00
		public BaseRaycaster module; // 0x08
		public float distance; // 0x10
		public float index; // 0x14
		public int depth; // 0x18
		public int sortingLayer; // 0x1C
		public int sortingOrder; // 0x20
		public Vector3 worldPosition; // 0x24
		public Vector3 worldNormal; // 0x30
		public Vector2 screenPosition; // 0x3C
		public int displayIndex; // 0x44
	
		// Properties
		public GameObject gameObject { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public bool isValid { get => default; } // 0x0000000189F7F244-0x0000000189F7F2B8 
	
		// Methods
		public void Clear() {} // 0x0000000189F7EDCC-0x0000000189F7EE74
		public override string ToString() => default; // 0x0000000189F7EE74-0x0000000189F7F244
	}

	public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 54000
	{
		// Constructors
		protected UIBehaviour() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected virtual void Awake() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnEnable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void Start() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDisable() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDestroy() {} // 0x000000018350B670-0x000000018350B680
		public virtual bool IsActive() => default; // 0x00000001825198D0-0x0000000182519A10
		protected virtual void OnRectTransformDimensionsChange() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnBeforeTransformParentChanged() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnTransformParentChanged() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnDidApplyAnimationProperties() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnCanvasHierarchyChanged() {} // 0x000000018350B670-0x000000018350B680
		public bool IsDestroyed() => default; // 0x000000018239C840-0x000000018239C900
	}
}

namespace UnityEngine.UI
{
	[Serializable]
	public class AnimationTriggers // TypeDefIndex: 53793
	{
		// Fields
		private const string kDefaultNormalAnimName = "Normal"; // Metadata: 0x01FD611C
		private const string kDefaultHighlightedAnimName = "Highlighted"; // Metadata: 0x01FD6123
		private const string kDefaultPressedAnimName = "Pressed"; // Metadata: 0x01FD612F
		private const string kDefaultSelectedAnimName = "Selected"; // Metadata: 0x01FD6137
		private const string kDefaultDisabledAnimName = "Disabled"; // Metadata: 0x01FD6140
		[FormerlySerializedAs("normalTrigger")]
		[SerializeField]
		private string m_NormalTrigger; // 0x10
		[FormerlySerializedAs("highlightedTrigger")]
		[SerializeField]
		private string m_HighlightedTrigger; // 0x18
		[FormerlySerializedAs("pressedTrigger")]
		[SerializeField]
		private string m_PressedTrigger; // 0x20
		[FormerlySerializedAs("m_HighlightedTrigger")]
		[SerializeField]
		private string m_SelectedTrigger; // 0x28
		[FormerlySerializedAs("disabledTrigger")]
		[SerializeField]
		private string m_DisabledTrigger; // 0x30
	
		// Properties
		public string normalTrigger { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public string highlightedTrigger { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string pressedTrigger { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public string selectedTrigger { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public string disabledTrigger { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Constructors
		public AnimationTriggers() {} // 0x0000000182848B40-0x0000000182848C10
	}

	[AddComponentMenu("UI/Button", 30)]
	public class Button : Selectable, IPointerClickHandler, ISubmitHandler // TypeDefIndex: 53796
	{
		// Fields
		[FormerlySerializedAs("onClick")]
		[SerializeField]
		private ButtonClickedEvent m_OnClick; // 0x180
	
		// Properties
		public ButtonClickedEvent onClick { get => default; set {} } // 0x00000001810410F0-0x0000000181041100 0x000000018350B670-0x000000018350B680
	
		// Nested types
		[Serializable]
		public class ButtonClickedEvent : UnityEvent // TypeDefIndex: 53794
		{
			// Constructors
			public ButtonClickedEvent() {} // 0x0000000189E5C808-0x0000000189E5C894
		}
	
		// Constructors
		protected Button() {} // 0x0000000184271C98-0x0000000184271CA0
	
		// Methods
		private void Press() {} // 0x0000000189E66A70-0x0000000189E66B64
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000181041090-0x00000001810410A0
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000189E66B64-0x0000000189E66BB0
		[IteratorStateMachine(typeof(_OnFinishSubmit_d__9))]
		private IEnumerator OnFinishSubmit() => default; // 0x0000000181041090-0x00000001810410A0
	}

	public enum CanvasUpdate // TypeDefIndex: 53797
	{
		Prelayout = 0,
		Layout = 1,
		PostLayout = 2,
		PreRender = 3,
		LatePreRender = 4,
		MaxUpdateValue = 5
	}

	public interface ICanvasElement // TypeDefIndex: 53798
	{
		// Properties
		Transform transform { get; }
	
		// Methods
		void Rebuild(CanvasUpdate executing);
		void LayoutComplete();
		void GraphicUpdateComplete();
		bool IsDestroyed();
	}

	public class CanvasUpdateRegistry // TypeDefIndex: 53799
	{
		// Fields
		private static CanvasUpdateRegistry s_Instance; // 0x00
		private bool m_PerformingLayoutUpdate; // 0x10
		private bool m_PerformingGraphicUpdate; // 0x11
		private ProfilerMarker[] m_CanvasUpdateProfilerStrings; // 0x18
		private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull"; // Metadata: 0x01FD614F
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x08
	
		// Properties
		public static CanvasUpdateRegistry instance { get => default; } // 0x000000018239DCC0-0x000000018239DDC0 
	
		// Constructors
		protected CanvasUpdateRegistry() {} // 0x0000000182CD05B0-0x0000000182CD0800
		static CanvasUpdateRegistry() {} // 0x0000000183CBD3B0-0x0000000183CBD450
	
		// Methods
		private bool ObjectValidForUpdate(ICanvasElement element) => default; // 0x000000018239C000-0x000000018239C840
		private void CleanInvalidItems() {} // 0x000000018239B3A0-0x000000018239B5A0
		private void PerformUpdate() {} // 0x000000018239B5A0-0x000000018239C000
		private static int ParentCount(Transform child) => default; // 0x0000000182DA8E30-0x0000000182DA9030
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y) => default; // 0x0000000182DA8CC0-0x0000000182DA8E30
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) {} // 0x00000001834CFE10-0x00000001834CFE80
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) => default; // 0x000000018239D100-0x000000018239D260
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) => default; // 0x000000018239DFD0-0x000000018239E1A0
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) {} // 0x000000018239D980-0x000000018239DCC0
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) => default; // 0x0000000189E5C894-0x0000000189E5C8EC
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) => default; // 0x000000018239DDC0-0x000000018239DFD0
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) {} // 0x000000018239CDC0-0x000000018239CE40
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) {} // 0x000000018239C980-0x000000018239CB40
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) {} // 0x000000018239CB40-0x000000018239CD00
		public static bool IsRebuildingLayout() => default; // 0x000000018239CD00-0x000000018239CD60
		public static bool IsRebuildingGraphics() => default; // 0x000000018239CD60-0x000000018239CDC0
	}

	[Serializable]
	public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 53800
	{
		// Fields
		[FormerlySerializedAs("normalColor")]
		[SerializeField]
		private UnityEngine.Color m_NormalColor; // 0x00
		[FormerlySerializedAs("highlightedColor")]
		[SerializeField]
		private UnityEngine.Color m_HighlightedColor; // 0x10
		[FormerlySerializedAs("pressedColor")]
		[SerializeField]
		private UnityEngine.Color m_PressedColor; // 0x20
		[FormerlySerializedAs("m_HighlightedColor")]
		[SerializeField]
		private UnityEngine.Color m_SelectedColor; // 0x30
		[FormerlySerializedAs("disabledColor")]
		[SerializeField]
		private UnityEngine.Color m_DisabledColor; // 0x40
		[Range(1f, 5f)]
		[SerializeField]
		private float m_ColorMultiplier; // 0x50
		[FormerlySerializedAs("fadeDuration")]
		[SerializeField]
		private float m_FadeDuration; // 0x54
		public static ColorBlock defaultColorBlock; // 0x00
	
		// Properties
		public UnityEngine.Color normalColor { get => default; set {} } // 0x0000000183D5B250-0x0000000183D5B260 0x0000000183D5E620-0x0000000183D5E630
		public UnityEngine.Color highlightedColor { get => default; set {} } // 0x00000001820B7B30-0x00000001820B7B40 0x0000000183D55580-0x0000000183D55590
		public UnityEngine.Color pressedColor { get => default; set {} } // 0x0000000183D54E00-0x0000000183D54E10 0x0000000183D54E10-0x0000000183D54E20
		public UnityEngine.Color selectedColor { get => default; set {} } // 0x0000000183D4FD30-0x0000000183D4FD40 0x0000000183D4FD40-0x0000000183D4FD50
		public UnityEngine.Color disabledColor { get => default; set {} } // 0x0000000183D5A160-0x0000000183D5A170 0x0000000183D5D610-0x0000000183D5D620
		public float colorMultiplier { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000183D51CA0-0x0000000183D51CB0
		public float fadeDuration { get => default; set {} } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000183D4F680-0x0000000183D4F690
	
		// Constructors
		static ColorBlock() {
			defaultColorBlock = default;
		} // 0x0000000182561F60-0x0000000182562110
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189E5C8EC-0x0000000189E5C99C
		public bool Equals(ColorBlock other) => default; // 0x0000000189E5C99C-0x0000000189E5CB20
		public static bool operator ==(ColorBlock point1, ColorBlock point2) => default; // 0x0000000189E5CBA4-0x0000000189E5CC38
		public static bool operator !=(ColorBlock point1, ColorBlock point2) => default; // 0x0000000189E5CC38-0x0000000189E5CCD0
		public override int GetHashCode() => default; // 0x0000000189E5CB20-0x0000000189E5CBA4
	}

	public class ClipperRegistry // TypeDefIndex: 53801
	{
		// Fields
		private static ClipperRegistry s_Instance; // 0x00
		private readonly IndexedSet<IClipper> m_Clippers; // 0x10
		private readonly ProfilerMarker clippersMarker; // 0x18
	
		// Properties
		public static ClipperRegistry instance { get => default; } // 0x0000000182516E40-0x0000000182516EE0 
	
		// Constructors
		protected ClipperRegistry() {} // 0x0000000182515620-0x00000001825156D0
	
		// Methods
		public void Cull() {} // 0x0000000182DF7F90-0x0000000182DF80F0
		public static void Register(IClipper c) {} // 0x0000000182516DD0-0x0000000182516E40
		public static void Unregister(IClipper c) {} // 0x0000000182516D40-0x0000000182516DA0
	}

	public static class Clipping // TypeDefIndex: 53802
	{
		// Methods
		public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect) {
			validRect = default;
			return default;
		} // 0x000000018233E630-0x000000018233EBC0
	}

	public interface IClipper // TypeDefIndex: 53803
	{
		// Methods
		void PerformClipping();
	}

	public interface IClippable // TypeDefIndex: 53804
	{
		// Properties
		GameObject gameObject { get; }
		RectTransform rectTransform { get; }
	
		// Methods
		void RecalculateClipping();
		void Cull(Rect clipRect, bool validRect);
		void SetClipRect(Rect value, bool validRect);
		void SetClipSoftness(Vector2 clipSoftness);
		void SetHGClipSoftness(Vector4 hgClipSoftness);
	}

	internal class RectangularVertexClipper // TypeDefIndex: 53805
	{
		// Fields
		private readonly Vector3[] m_WorldCorners; // 0x10
		private readonly Vector3[] m_CanvasCorners; // 0x18
	
		// Constructors
		public RectangularVertexClipper() {} // 0x0000000183294BB0-0x0000000183294C20
	
		// Methods
		public Rect GetCanvasRect(RectTransform t, Canvas c) => default; // 0x00000001823443C0-0x0000000182344A10
	}

	public static class DefaultControls // TypeDefIndex: 53809
	{
		// Fields
		private static IFactoryControls m_CurrentFactory; // 0x00
		private const float kWidth = 160f; // Metadata: 0x01FD6164
		private const float kThickHeight = 30f; // Metadata: 0x01FD6168
		private const float kThinHeight = 20f; // Metadata: 0x01FD616C
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static Vector2 s_ImageElementSize; // 0x18
		private static UnityEngine.Color s_DefaultSelectableColor; // 0x20
		private static UnityEngine.Color s_PanelColor; // 0x30
		private static UnityEngine.Color s_TextColor; // 0x40
	
		// Properties
		public static IFactoryControls factory { get; } // 0x0000000189E6068C-0x0000000189E606DC 
	
		// Nested types
		public interface IFactoryControls // TypeDefIndex: 53806
		{
			// Methods
			GameObject CreateGameObject(string name, params System.Type[] components); // 0x0000000189E60A34-0x0000000189E60A84
		}
	
		private class DefaultRuntimeFactory : IFactoryControls // TypeDefIndex: 53807
		{
			// Fields
			public static IFactoryControls Default; // 0x00
	
			// Constructors
			public DefaultRuntimeFactory() {} // 0x0000000189E60608-0x0000000189E6068C
			static DefaultRuntimeFactory() {} // 0x0000000189E606DC-0x0000000189E60794
	
			// Methods
			public GameObject CreateGameObject(string name, params System.Type[] components) => default; // 0x0000000189E6055C-0x0000000189E60608
		}
	
		public struct Resources // TypeDefIndex: 53808
		{
			// Fields
			public Sprite standard; // 0x00
			public Sprite background; // 0x08
			public Sprite inputField; // 0x10
			public Sprite knob; // 0x18
			public Sprite checkmark; // 0x20
			public Sprite dropdown; // 0x28
			public Sprite mask; // 0x30
		}
	
		// Constructors
		static DefaultControls() {} // 0x0000000189E60AF4-0x0000000189E60B58
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size, params System.Type[] components) => default; // 0x0000000189E60854-0x0000000189E60920
		private static GameObject CreateUIObject(string name, GameObject parent, params System.Type[] components) => default; // 0x0000000189E60794-0x0000000189E60854
		private static void SetDefaultTextValues(Text lbl) {} // 0x0000000189E5E800-0x0000000189E5EA30
		private static void SetDefaultColorTransitionValues(Selectable slider) {} // 0x0000000189E5CCD0-0x0000000189E5D02C
		private static void SetParentAndAlign(GameObject child, GameObject parent) {} // 0x0000000189E5FE38-0x0000000189E5FF9C
		private static void SetLayerRecursively(GameObject go, int layer) {} // 0x0000000189E5E164-0x0000000189E5E270
		public static GameObject CreatePanel(Resources resources) => default; // 0x0000000189E5EA30-0x0000000189E5EB3C
		public static GameObject CreateButton(Resources resources) => default; // 0x0000000189E5F6EC-0x0000000189E5FE38
		public static GameObject CreateText(Resources resources) => default; // 0x0000000189E5F298-0x0000000189E5F6EC
		public static GameObject CreateImage(Resources resources) => default; // 0x0000000189E5FF9C-0x0000000189E6055C
		public static GameObject CreateRawImage(Resources resources) => default; // 0x0000000189E5E270-0x0000000189E5E800
		public static GameObject CreateSlider(Resources resources) => default; // 0x0000000189E5D02C-0x0000000189E5E164
		public static GameObject CreateScrollbar(Resources resources) => default; // 0x0000000189E5EB3C-0x0000000189E5F298
		public static GameObject CreateToggle(Resources resources) => default; // 0x0000000189E60920-0x0000000189E60A34
		public static GameObject CreateInputField(Resources resources) => default;
		public static GameObject CreateDropdown(Resources resources) => default; // 0x0000000189E60A84-0x0000000189E60AF4
		public static GameObject CreateScrollView(Resources resources) => default; // 0x000000018350B670-0x000000018350B680
	}

	[RequireComponent(typeof(RectTransform))]
	public class Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 53816
	{
		// Fields
		[SerializeField]
		private RectTransform m_Template; // 0x180
		[SerializeField]
		private Text m_CaptionText; // 0x188
		[SerializeField]
		private Image m_CaptionImage; // 0x190
		[SerializeField]
		[Space]
		private Text m_ItemText; // 0x198
		[SerializeField]
		private Image m_ItemImage; // 0x1A0
		[SerializeField]
		[Space]
		private int m_Value; // 0x1A8
		[SerializeField]
		[Space]
		private OptionDataList m_Options; // 0x1B0
		[SerializeField]
		[Space]
		private DropdownEvent m_OnValueChanged; // 0x1B8
		[SerializeField]
		private float m_AlphaFadeSpeed; // 0x1C0
		private GameObject m_Dropdown; // 0x1C8
		private GameObject m_Blocker; // 0x1D0
		private List<DropdownItem> m_Items; // 0x1D8
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x1E0
		private bool validTemplate; // 0x1E8
		private const int kHighSortingLayer = 30000; // Metadata: 0x01FD6171
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get => default; set {} } // 0x0000000189E61D84-0x0000000189E61D8C 0x0000000189E61D84-0x0000000189E61D8C
		public Text captionText { get => default; set {} } // 0x0000000189E61CE8-0x0000000189E61CF0 0x0000000189E6285C-0x0000000189E63608
		public Image captionImage { get => default; set {} } // 0x0000000189E614C4-0x0000000189E618F8 0x0000000189E61A0C-0x0000000189E61A58
		public Text itemText { get => default; set {} } // 0x0000000189E618F8-0x0000000189E6194C 0x0000000189E61A58-0x0000000189E61AA4
		public Image itemImage { get => default; set {} } // 0x0000000189E6194C-0x0000000189E619A0 0x000000018350B670-0x000000018350B680
		public List<OptionData> options { get => default; set {} } // 0x0000000189E60C78-0x0000000189E60F04 0x0000000189E612F0-0x0000000189E6137C
		public DropdownEvent onValueChanged { get => default; set {} } // 0x0000000189E61174-0x0000000189E612F0 0x0000000189E62078-0x0000000189E62118
		public float alphaFadeSpeed { get => default; set {} } // 0x0000000189E61AA4-0x0000000189E61B98 0x0000000189E619A0-0x0000000189E61A0C
		public int value { get => default; set {} } // 0x0000000189E61B98-0x0000000189E61CE8 0x0000000189E61D8C-0x0000000189E61E94
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 53810
		{
			// Fields
			[SerializeField]
			private Text m_Text; // 0x18
			[SerializeField]
			private Image m_Image; // 0x20
			[SerializeField]
			private RectTransform m_RectTransform; // 0x28
			[SerializeField]
			private Toggle m_Toggle; // 0x30
	
			// Properties
			public Text text { get => default; set {} } // 0x0000000183D56B50-0x0000000183D56B60 0x0000000189E63924-0x0000000189E6394C
			public Image image { get => default; set {} } // 0x0000000183D56AF0-0x0000000183D56B00 0x0000000189E63878-0x0000000189E638A0
			public RectTransform rectTransform { get => default; set {} } // 0x0000000183D56B70-0x0000000183D56B80 0x0000000189E63850-0x0000000189E63878
			public Toggle toggle { get => default; set {} } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000189E638C8-0x0000000189E638F0
	
			// Constructors
			public DropdownItem() {} // 0x0000000189E63830-0x0000000189E63850
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x0000000183D56AD0-0x0000000183D56AE0
			public virtual void OnCancel(BaseEventData eventData) {} // 0x0000000189E638A0-0x0000000189E638C8
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 53811
		{
			// Fields
			[SerializeField]
			private string m_Text; // 0x10
			[SerializeField]
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get => default; set {} } // 0x0000000189E638F0-0x0000000189E63924 0x0000000183D57130-0x0000000183D57140
			public Sprite image { get => default; set {} } // 0x0000000184275B98-0x0000000184275BAC 0x0000000183D584D0-0x0000000183D584E0
	
			// Constructors
			public OptionData() {} // 0x0000000183D58600-0x0000000183D58610
			public OptionData(string text) {} // 0x0000000183D583A0-0x0000000183D583B0
			public OptionData(Sprite image) {} // 0x0000000189E6394C-0x0000000189E63958
			public OptionData(string text, Sprite image) {} // 0x0000000189E62118-0x0000000189E62124
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 53812
		{
			// Fields
			[SerializeField]
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get => default; set {} } // 0x0000000189E62124-0x0000000189E62214 0x0000000189E63708-0x0000000189E63830
	
			// Constructors
			public OptionDataList() {} // 0x0000000189E6137C-0x0000000189E61464
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 53813
		{
			// Constructors
			public DropdownEvent() {} // 0x0000000189E63608-0x0000000189E63698
		}
	
		// Constructors
		protected Dropdown() {} // 0x00000001822C3A90-0x00000001822C3AA0
		static Dropdown() {} // 0x0000000181041090-0x00000001810410A0
	
		// Methods
		public void SetValueWithoutNotify(int input) {} // 0x0000000189E63698-0x0000000189E63708
		private void Set(int value, bool sendCallback = true /* Metadata: 0x01FD6170 */) {} // 0x0000000181041090-0x00000001810410A0
		protected override void Awake() {} // 0x0000000183D4EB40-0x0000000183D4EB50
		protected override void Start() {} // 0x0000000184271930-0x0000000184271940
		protected override void OnDisable() {} // 0x0000000183D4EAC0-0x0000000183D4EAD0
		public void RefreshShownValue() {} // 0x0000000182C92F10-0x0000000182C92F20
		public void AddOptions(List<OptionData> options) {} // 0x0000000181003830-0x0000000181003840
		public void AddOptions(List<string> options) {} // 0x0000000184270470-0x0000000184270480
		public void AddOptions(List<Sprite> options) {} // 0x0000000189E60C0C-0x0000000189E60C78
		public void ClearOptions() {} // 0x0000000189E60B94-0x0000000189E60C0C
		private void SetupTemplate(Canvas rootCanvas) {} // 0x000000018426FE60-0x000000018426FE68
		private static T GetOrAddComponent<T>(GameObject go)
			where T : UnityEngine.Component => default; // 0x00000001820B7B20-0x00000001820B7B30
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x000000018426FEE0-0x000000018426FEF0
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000181041090-0x00000001810410A0
		public virtual void OnCancel(BaseEventData eventData) {} // 0x00000001822C3A90-0x00000001822C3AA0
		public void Show() {} // 0x000000018350B670-0x000000018350B680
		protected virtual GameObject CreateBlocker(Canvas rootCanvas) => default; // 0x000000018426FEE0-0x000000018426FEF0
		protected virtual void DestroyBlocker(GameObject blocker) {} // 0x00000001822C3A90-0x00000001822C3AA0
		protected virtual GameObject CreateDropdownList(GameObject template) => default; // 0x0000000182676770-0x00000001826767A0
		protected virtual void DestroyDropdownList(GameObject dropdownList) {} // 0x00000001820B7B20-0x00000001820B7B30
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) => default; // 0x000000018426FEE0-0x000000018426FEF0
		protected virtual void DestroyItem(DropdownItem item) {} // 0x0000000189E66910-0x0000000189E66988
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) => default; // 0x0000000189E60B58-0x0000000189E60B94
		private void AlphaFadeList(float duration, float alpha) {} // 0x000000018350B670-0x000000018350B680
		private void AlphaFadeList(float duration, float start, float end) {} // 0x0000000189E66BB0-0x0000000189E672C4
		private void SetAlpha(float alpha) {} // 0x00000001810410F0-0x0000000181041100
		public void Hide() {} // 0x000000018350B670-0x000000018350B680
		[IteratorStateMachine(typeof(_DelayedDestroyDropdownList_d__75))]
		private IEnumerator DelayedDestroyDropdownList(float delay) => default; // 0x0000000189E66988-0x0000000189E66A24
		private void ImmediateDestroyDropdownList() {} // 0x0000000181041090-0x00000001810410A0
		private void OnSelectItem(Toggle toggle) {} // 0x0000000189E66A24-0x0000000189E66A70
	}

	[Serializable]
	public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 53817
	{
		// Fields
		[FormerlySerializedAs("font")]
		[SerializeField]
		private Font m_Font; // 0x10
		[FormerlySerializedAs("fontSize")]
		[SerializeField]
		private int m_FontSize; // 0x18
		[FormerlySerializedAs("fontStyle")]
		[SerializeField]
		private FontStyle m_FontStyle; // 0x1C
		[SerializeField]
		private bool m_BestFit; // 0x20
		[SerializeField]
		private int m_MinSize; // 0x24
		[SerializeField]
		private int m_MaxSize; // 0x28
		[FormerlySerializedAs("alignment")]
		[SerializeField]
		private TextAnchor m_Alignment; // 0x2C
		[SerializeField]
		private bool m_AlignByGeometry; // 0x30
		[FormerlySerializedAs("richText")]
		[SerializeField]
		private bool m_RichText; // 0x31
		[SerializeField]
		private HorizontalWrapMode m_HorizontalOverflow; // 0x34
		[SerializeField]
		private VerticalWrapMode m_VerticalOverflow; // 0x38
		[SerializeField]
		private float m_LineSpacing; // 0x3C
	
		// Properties
		public static FontData defaultFontData { get => default; } // 0x0000000189E639A4-0x0000000189E63A18 
		public Font font { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public int fontSize { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public FontStyle fontStyle { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public bool bestFit { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public int minSize { get => default; set {} } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public int maxSize { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public TextAnchor alignment { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public bool alignByGeometry { get => default; set {} } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000183D4EF70-0x0000000183D4EF80
		public bool richText { get => default; set {} } // 0x0000000183D4F2C0-0x0000000183D4F2D0 0x0000000183D4F2D0-0x0000000183D4F2E0
		public HorizontalWrapMode horizontalOverflow { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		public VerticalWrapMode verticalOverflow { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public float lineSpacing { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000183D4ECE0-0x0000000183D4ECF0
	
		// Constructors
		public FontData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189E63958-0x0000000189E639A4
	}

	public static class FontUpdateTracker // TypeDefIndex: 53818
	{
		// Fields
		private static Dictionary<Font, HashSet<Text>> m_Tracked; // 0x00
	
		// Constructors
		static FontUpdateTracker() {} // 0x0000000189E63F8C-0x0000000189E64018
	
		// Methods
		public static void TrackText(Text t) {} // 0x0000000189E63B88-0x0000000189E63DA8
		private static void RebuildForFont(Font f) {} // 0x0000000189E63A18-0x0000000189E63B88
		public static void UntrackText(Text t) {} // 0x0000000189E63DA8-0x0000000189E63F8C
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 53819
	{
		// Fields
		protected static Material s_DefaultUI; // 0x00
		protected static Texture2D s_WhiteTexture; // 0x08
		private static string s_DefaultMaterialName; // 0x10
		private static string s_OverlayShaderKeyword; // 0x18
		[FormerlySerializedAs("m_Mat")]
		[SerializeField]
		protected Material m_Material; // 0x18
		[SerializeField]
		private UnityEngine.Color m_Color; // 0x20
		[NonSerialized]
		protected bool m_SkipLayoutUpdate; // 0x30
		[NonSerialized]
		protected bool m_SkipMaterialUpdate; // 0x31
		[SerializeField]
		private bool m_RaycastTarget; // 0x32
		[SerializeField]
		private Vector4 m_RaycastPadding; // 0x34
		[SerializeField]
		private bool m_RaycastIgnoreMask; // 0x44
		[NonSerialized]
		private RectTransform m_RectTransform; // 0x48
		[NonSerialized]
		private CanvasRenderer m_CanvasRenderer; // 0x50
		[NonSerialized]
		private Canvas m_Canvas; // 0x58
		[NonSerialized]
		private bool m_VertsDirty; // 0x60
		[NonSerialized]
		private bool m_MaterialDirty; // 0x61
		[NonSerialized]
		protected UnityAction m_OnDirtyLayoutCallback; // 0x68
		[NonSerialized]
		protected UnityAction m_OnDirtyVertsCallback; // 0x70
		[NonSerialized]
		protected UnityAction m_OnDirtyMaterialCallback; // 0x78
		[NonSerialized]
		protected static Mesh s_Mesh; // 0x20
		[NonSerialized]
		private static readonly VertexHelper s_VertexHelper; // 0x28
		[NonSerialized]
		protected Mesh m_CachedMesh; // 0x80
		[NonSerialized]
		protected Vector2[] m_CachedUvs; // 0x88
		private TweenRunner<ColorTween> m_ColorTweenRunnerLazy; // 0x90
		[NonSerialized]
		protected bool m_EnableRuntimeAtlas; // 0x98
		[NonSerialized]
		protected Texture m_RuntimeAtlasTexture; // 0xA0
	
		// Properties
		public static string defaultMaterialName { get; set; } // 0x0000000189E64430-0x0000000189E64480 0x0000000189E644D0-0x0000000189E64530
		public static Material defaultGraphicMaterial { get; } // 0x00000001825C3E70-0x00000001825C40E0 
		public static string overlayShaderKeyword { get; set; } // 0x0000000189E64480-0x0000000189E644D0 0x0000000189E64560-0x0000000189E645C0
		public virtual UnityEngine.Color color { get; set; } // 0x0000000183D54E00-0x0000000183D54E10 0x00000001825C1E20-0x00000001825C1E90
		public virtual bool raycastTarget { get; set; } // 0x0000000183D4F630-0x0000000183D4F640 0x0000000183567B30-0x0000000183567C10
		public Vector4 raycastPadding { get; set; } // 0x0000000183D51E40-0x0000000183D51E50 0x0000000183D51E50-0x0000000183D51E60
		private TweenRunner<ColorTween> m_ColorTweenRunner { get; } // 0x00000001824A3DF0-0x00000001824A3EA0 
		public virtual bool enableRuntimeAtlas { get; set; } // 0x0000000183D58690-0x0000000183D586A0 0x0000000189E64530-0x0000000189E64560
		public Texture runtimeAtlasTexture { get; set; } // 0x0000000183D4EA80-0x0000000183D4EA90 0x0000000189E645C0-0x0000000189E645EC
		protected bool useLegacyMeshGeneration { get; set; } // 0x00000001811B9C10-0x00000001811B9C20 0x00000001811B9C20-0x00000001811B9C30
		public int depth { get; } // 0x0000000182341D00-0x0000000182341DB0 
		public RectTransform rectTransform { get; } // 0x000000018233FD70-0x000000018233FDD0 
		public Canvas canvas { get; } // 0x0000000182345AD0-0x00000001823463C0 
		public CanvasRenderer canvasRenderer { get; } // 0x0000000182341C90-0x0000000182341D00 
		public virtual Material defaultMaterial { get; } // 0x00000001825C3E20-0x00000001825C3E70 
		public virtual Material material { get; set; } // 0x00000001830A8360-0x00000001830A8470 0x00000001834D2AC0-0x00000001834D2B50
		public virtual Material materialForRendering { get; } // 0x00000001825C6F00-0x00000001825C75E0 
		public virtual Texture mainTexture { get; } // 0x0000000183CFAFA0-0x0000000183CFB000 
		protected static Mesh workerMesh { get; } // 0x000000018233EFA0-0x000000018233F1D0 
		Transform ICanvasElement.transform { get; } // 0x0000000184273A88-0x0000000184273A90 
	
		// Constructors
		protected Graphic() {} // 0x00000001824340C0-0x0000000182434120
		static Graphic() {} // 0x0000000183B39A40-0x0000000183B39B80
	
		// Methods
		public virtual void SetAllDirty() {} // 0x0000000183009260-0x00000001830092B0
		public virtual void SetLayoutDirty() {} // 0x000000018233E250-0x000000018233E320
		public virtual void SetVerticesDirty() {} // 0x000000018239D5F0-0x000000018239D980
		public virtual void SetMaterialDirty() {} // 0x000000018239D260-0x000000018239D5F0
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000182394070-0x0000000182394130
		protected override void OnBeforeTransformParentChanged() {} // 0x00000001831ED950-0x00000001831EDA00
		protected override void OnTransformParentChanged() {} // 0x00000001831635B0-0x0000000183163660
		private void CacheCanvas() {} // 0x000000018251D250-0x000000018251D780
		protected override void OnEnable() {} // 0x0000000182399F40-0x000000018239A120
		protected override void OnDisable() {} // 0x000000018239AE50-0x000000018239B1E0
		protected override void OnDestroy() {} // 0x00000001825CAEC0-0x00000001825CAF40
		protected override void OnCanvasHierarchyChanged() {} // 0x00000001825A2510-0x00000001825A2C60
		public virtual void OnCullingChanged() {} // 0x0000000182C6F700-0x0000000182C6F800
		public virtual void Rebuild(CanvasUpdate update) {} // 0x0000000182342510-0x0000000182342750
		public virtual void LayoutComplete() {} // 0x000000018350B670-0x000000018350B680
		public virtual void GraphicUpdateComplete() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void UpdateMaterial() {} // 0x00000001825C6C70-0x00000001825C6F00
		protected virtual void UpdateGeometry() {} // 0x000000018233E5B0-0x000000018233E5E0
		private void DoMeshGeneration() {} // 0x000000018233F3F0-0x000000018233FB70
		private void DoLegacyMeshGeneration() {} // 0x000000018398B650-0x000000018398B8B0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use OnPopulateMesh instead.", true)]
		protected virtual void OnFillVBO(List<UIVertex> vbo) {} // 0x000000018350B670-0x000000018350B680
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		protected virtual void OnPopulateMesh(Mesh m) {} // 0x0000000183CF0F00-0x0000000183CF0FA0
		protected virtual void OnPopulateMesh(VertexHelper vh) {} // 0x00000001825A3710-0x00000001825A39D0
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000189E640BC-0x0000000189E640CC
		public virtual void SetNativeSize() {} // 0x000000018350B670-0x000000018350B680
		public virtual bool Raycast(Vector2 sp, Camera eventCamera) => default; // 0x0000000182519020-0x0000000182519810
		public Vector2 PixelAdjustPoint(Vector2 point) => default; // 0x0000000189E640CC-0x0000000189E64200
		public Rect GetPixelAdjustedRect() => default; // 0x000000018233E320-0x000000018233E5B0
		public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x00000001824A3780-0x00000001824A3800
		public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) {} // 0x00000001824A3800-0x00000001824A3D40
		private static UnityEngine.Color CreateColorFromAlpha(float alpha) => default; // 0x0000000183C95E10-0x0000000183C95E40
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x0000000183C95D40-0x0000000183C95E10
		public void RegisterDirtyLayoutCallback(UnityAction action) {} // 0x0000000189E64200-0x0000000189E6428C
		public void UnregisterDirtyLayoutCallback(UnityAction action) {} // 0x0000000189E64318-0x0000000189E643A4
		public void RegisterDirtyVerticesCallback(UnityAction action) {} // 0x0000000182CD8F30-0x0000000182CD8FC0
		public void UnregisterDirtyVerticesCallback(UnityAction action) {} // 0x0000000182CD8670-0x0000000182CD8700
		public void RegisterDirtyMaterialCallback(UnityAction action) {} // 0x0000000189E6428C-0x0000000189E64318
		public void UnregisterDirtyMaterialCallback(UnityAction action) {} // 0x0000000189E643A4-0x0000000189E64430
	}

	[AddComponentMenu("Event/Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 53822
	{
		// Fields
		protected const int kNoEventMaskSet = -1; // Metadata: 0x01FD6175
		[FormerlySerializedAs("ignoreReversedGraphics")]
		[SerializeField]
		private bool m_IgnoreReversedGraphics; // 0x20
		[FormerlySerializedAs("blockingObjects")]
		[SerializeField]
		private BlockingObjects m_BlockingObjects; // 0x24
		[SerializeField]
		protected LayerMask m_BlockingMask; // 0x28
		private Canvas m_Canvas; // 0x30
		[NonSerialized]
		private List<Graphic> m_RaycastResults; // 0x38
		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics; // 0x00
	
		// Properties
		public override int sortOrderPriority { get => default; } // 0x0000000183D4EFC0-0x0000000183D4EFD0 
		public override int renderOrderPriority { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public bool ignoreReversedGraphics { get => default; set {} } // 0x0000000183D4E2F0-0x0000000183D4E300 0x0000000183D4EB90-0x0000000183D4EBA0
		public BlockingObjects blockingObjects { get => default; set {} } // 0x0000000183D4EBA0-0x0000000183D4EBB0 0x00000001834CF540-0x00000001834CF5D0
		public LayerMask blockingMask { get => default; set {} } // 0x0000000182398350-0x0000000182398470 0x00000001823968C0-0x0000000182398350
		private Canvas canvas { get => default; } // 0x000000018233FE10-0x00000001823408B0 
		public override Camera eventCamera { get => default; } // 0x0000000183D14B10-0x0000000183D14B70 
	
		// Nested types
		public enum BlockingObjects // TypeDefIndex: 53820
		{
			None = 0,
			TwoD = 1,
			ThreeD = 2,
			All = 3
		}
	
		// Constructors
		protected GraphicRaycaster() {} // 0x0000000182398A50-0x0000000182398D30
		static GraphicRaycaster() {} // 0x0000000182319F00-0x0000000182319F60
	
		// Methods
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x00000001834CF410-0x00000001834CF4A0
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) {} // 0x000000018350B670-0x000000018350B680
	}

	public class GraphicRegistry // TypeDefIndex: 53823
	{
		// Fields
		private static GraphicRegistry s_Instance; // 0x00
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
		private static readonly List<Graphic> s_EmptyList; // 0x08
	
		// Properties
		public static GraphicRegistry instance { get => default; } // 0x0000000182398950-0x0000000182398A50 
	
		// Constructors
		protected GraphicRegistry() {} // 0x0000000183A20290-0x0000000183A20410
		static GraphicRegistry() {} // 0x00000001834CF4A0-0x00000001834CF540
	
		// Methods
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) {} // 0x0000000182399060-0x00000001823994F0
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) {} // 0x00000001823998B0-0x0000000182399C60
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) {} // 0x00000001823994F0-0x00000001823998B0
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) {} // 0x0000000182399C60-0x0000000182399F40
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) => default; // 0x0000000189E64018-0x0000000189E640BC
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) => default; // 0x0000000182398470-0x0000000182398950
	}

	[Obsolete("Not supported anymore")]
	internal interface IGraphicEnabledDisabled // TypeDefIndex: 53824
	{
		// Methods
		void OnSiblingGraphicEnabledDisabled();
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 53834
	{
		// Fields
		protected static Material s_ETC1DefaultUI; // 0x00
		[FormerlySerializedAs("m_Frame")]
		[SerializeField]
		private Sprite m_Sprite; // 0xE8
		[NonSerialized]
		protected Rect m_RuntimeAtlasRect; // 0xF0
		[NonSerialized]
		protected Rect m_RuntimeAtlasTextureRect; // 0x100
		[NonSerialized]
		protected Vector4 m_RuntimeAtlasBorder; // 0x110
		[NonSerialized]
		protected float m_RuntimeAtlasPixelsPerUnit; // 0x120
		[NonSerialized]
		private Sprite m_OverrideSprite; // 0x128
		[SerializeField]
		private Type m_Type; // 0x130
		[SerializeField]
		private bool m_PreserveAspect; // 0x134
		[SerializeField]
		private bool m_FillCenter; // 0x135
		[SerializeField]
		private FillMethod m_FillMethod; // 0x138
		[Range(0f, 1f)]
		[SerializeField]
		private float m_FillAmount; // 0x13C
		[SerializeField]
		private bool m_FillClockwise; // 0x140
		[SerializeField]
		private int m_FillOrigin; // 0x144
		private float m_AlphaHitTestMinimumThreshold; // 0x148
		private bool m_Tracked; // 0x14C
		[SerializeField]
		private bool m_UseSpriteMesh; // 0x14D
		[SerializeField]
		private float m_PixelsPerUnitMultiplier; // 0x150
		private float m_CachedReferencePixelsPerUnit; // 0x154
		[NonSerialized]
		public SlicedSpriteParams slicedSpriteParams; // 0x158
		private bool bAwakeOnce; // 0x17C
		private static readonly Vector2[] s_VertScratch; // 0x08
		private static readonly Vector2[] s_UVScratch; // 0x10
		private const int QuadCount = 4; // Metadata: 0x01FD617A
		private static readonly Vector3[] s_Xy; // 0x18
		private static readonly Vector3[] s_Uv; // 0x20
		private static List<Image> m_TrackedTexturelessImages; // 0x28
		private static bool s_Initialized; // 0x30
		protected const int VALIDATE_MAX_VERT_COUNT = 10000; // Metadata: 0x01FD617B
		[FormerlySerializedAs("mDynamicAtlasActiveMode")]
		[SerializeField]
		private EDynamicAtlasActiveMode m_DynamicAtlasActiveMode; // 0x17D
		[SerializeField]
		protected bool _packIntoRuntimeAtlas; // 0x17E
		protected int m_panelLevel; // 0x180
		[NonSerialized]
		public bool keepOriginUV; // 0x184
		private Action dynamicAtlasCallBack; // 0x188
		private static bool _sDynamicAtlasInitialized; // 0x31
		private static readonly List<Image> s_FreeList; // 0x38
		private static readonly HashSet<Image> s_TrackedDynamicAtlasImages; // 0x40
		private static readonly List<Image> s_FreeListRevert; // 0x48
		private static readonly HashSet<Image> s_TrackedDynamicAtlasSpriteRevert; // 0x50
		public static bool s_AtlasV2; // 0x58
	
		// Properties
		public Rect runtimeAtlasRect { get => default; set {} } // 0x0000000183D6C110-0x0000000183D6C120 0x0000000183D6C060-0x0000000183D6C070
		public Rect runtimeAtlasTextureRect { get => default; set {} } // 0x0000000183D6C0E0-0x0000000183D6C0F0 0x0000000183D6C050-0x0000000183D6C060
		public Vector4 runtimeAtlasBorder { get => default; set {} } // 0x0000000183D6C0D0-0x0000000183D6C0E0 0x0000000183D583D0-0x0000000183D583E0
		public float runtimeAtlasPixelsPerUnit { get => default; set {} } // 0x0000000183D884B0-0x0000000183D884C0 0x0000000183D50EA0-0x0000000183D50EB0
		public Sprite sprite { get => default; set {} } // 0x00000001825C39D0-0x00000001825C3E20 0x0000000183D58690-0x0000000183D586A0
		public bool enableRuntimeAtlasRaw { get => default; } // 0x0000000182E55420-0x0000000182E55460 
		public override bool enableRuntimeAtlas { get => default; set {} } // 0x0000000189E64530-0x0000000189E64560 0x0000000183C84750-0x0000000183C847C0
		public Sprite overrideSprite { get => default; set {} } // 0x0000000189E66768-0x0000000189E667D0 0x00000001825C6650-0x00000001825C6840
		private Sprite activeSprite { get => default; } // 0x0000000183D5CE60-0x0000000183D5CE70 
		public Type type { get => default; set {} } // 0x0000000189E66854-0x0000000189E668B0 0x0000000183D5AED0-0x0000000183D5AEE0
		public bool preserveAspect { get => default; set {} } // 0x0000000189E667F4-0x0000000189E66854 0x0000000183D5AF00-0x0000000183D5AF10
		public bool fillCenter { get => default; set {} } // 0x0000000189E665E8-0x0000000189E66648 0x0000000183D59CD0-0x0000000183D59CE0
		public FillMethod fillMethod { get => default; set {} } // 0x0000000189E666A8-0x0000000189E6670C 0x0000000183D57900-0x0000000183D57910
		public float fillAmount { get => default; set {} } // 0x0000000182409C90-0x0000000182409DC0 0x0000000183D576E0-0x0000000183D576F0
		public bool fillClockwise { get => default; set {} } // 0x0000000189E66648-0x0000000189E666A8 0x0000000183D76300-0x0000000183D76310
		public int fillOrigin { get => default; set {} } // 0x0000000189E6670C-0x0000000189E66768 0x0000000183D88460-0x0000000183D88480
		[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
		public float eventAlphaThreshold { get => default; set {} } // 0x0000000183D88490-0x0000000183D884B0 0x0000000183D58220-0x0000000183D58230
		public float alphaHitTestMinimumThreshold { get => default; set {} } // 0x0000000183D5B6A0-0x0000000183D5B6B0 0x0000000183D88480-0x0000000183D88490
		public bool useSpriteMesh { get => default; set {} } // 0x0000000189E668B0-0x0000000189E66910 0x0000000182432BB0-0x0000000182432C50
		public static Material defaultETC1GraphicMaterial { get => default; } // 0x00000001825C57E0-0x00000001825C5D40 
		public override Texture mainTexture { get => default; } // 0x00000001825A12F0-0x00000001825A1410 
		public bool hasBorder { get => default; } // 0x0000000183D581F0-0x0000000183D58200 
		public float pixelsPerUnitMultiplier { get => default; set {} } // 0x0000000189E667D0-0x0000000189E667F4 0x00000001825A1790-0x00000001825A1A20
		public float pixelsPerUnit { get => default; } // 0x00000001825A1770-0x00000001825A1790 
		protected float multipliedPixelsPerUnit { get => default; } // 0x00000001825C4BA0-0x00000001825C50D0 
		public override Material material { get => default; set {} } // 0x00000001834D2AB0-0x00000001834D2AC0 0x000000018350B670-0x000000018350B680
		public virtual float minWidth { get => default; } // 0x00000001825A0C40-0x00000001825A0EF0 
		public virtual float preferredWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float flexibleWidth { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public virtual float minHeight { get => default; } // 0x00000001825A0990-0x00000001825A0AE0 
		public virtual float preferredHeight { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float flexibleHeight { get => default; } // 0x0000000181002730-0x0000000181002740 
		public virtual int layoutPriority { get => default; } // 0x0000000182517520-0x0000000182517670 
		public EDynamicAtlasActiveMode DynamicAtlasActiveMode { get => default; } // 0x00000001825CA9D0-0x00000001825CADA0 
	
		// Nested types
		public enum Type // TypeDefIndex: 53825
		{
			Simple = 0,
			Sliced = 1,
			Tiled = 2,
			Filled = 3,
			Mirror = 4,
			Quarter = 5
		}
	
		public enum FillMethod // TypeDefIndex: 53826
		{
			Horizontal = 0,
			Vertical = 1,
			Radial90 = 2,
			Radial180 = 3,
			Radial360 = 4
		}
	
		public enum OriginHorizontal // TypeDefIndex: 53827
		{
			Left = 0,
			Right = 1
		}
	
		public enum OriginVertical // TypeDefIndex: 53828
		{
			Bottom = 0,
			Top = 1
		}
	
		public enum Origin90 // TypeDefIndex: 53829
		{
			BottomLeft = 0,
			TopLeft = 1,
			TopRight = 2,
			BottomRight = 3
		}
	
		public enum Origin180 // TypeDefIndex: 53830
		{
			Bottom = 0,
			Left = 1,
			Top = 2,
			Right = 3
		}
	
		public enum Origin360 // TypeDefIndex: 53831
		{
			Bottom = 0,
			Right = 1,
			Top = 2,
			Left = 3
		}
	
		public struct SlicedSpriteParams // TypeDefIndex: 53832
		{
			// Fields
			public bool slicedParamNeedUpdate; // 0x00
			public Vector2 inner_PosMin; // 0x04
			public Vector2 inner_PosMax; // 0x0C
			public Vector2 inner_UVMin; // 0x14
			public Vector2 inner_UVMax; // 0x1C
	
			// Constructors
			public SlicedSpriteParams(bool slicedParamNeedUpdate, Vector2 inner_PosMin, Vector2 inner_PosMax, Vector2 inner_UVMin, Vector2 inner_UVMax) {
				this.slicedParamNeedUpdate = default;
				this.inner_PosMin = default;
				this.inner_PosMax = default;
				this.inner_UVMin = default;
				this.inner_UVMax = default;
			} // 0x0000000183D6C080-0x0000000183D6C090
		}
	
		public enum EDynamicAtlasActiveMode : byte // TypeDefIndex: 53833
		{
			ActiveOnAwake = 0,
			ActiveOnEnable = 1
		}
	
		// Constructors
		protected Image() {} // 0x0000000189E66518-0x0000000189E665E0
		static Image() {} // 0x0000000183D89BB0-0x0000000183D89BE0
	
		// Methods
		public virtual void ReleaseSprite() {} // 0x00000001825CA680-0x00000001825CA830
		protected virtual void _OnSpriteChanged(Sprite oldOne) {} // 0x0000000183D88440-0x0000000183D88450
		public void DisableSpriteOptimizations() {} // 0x0000000189E665E0-0x0000000189E665E8
		public virtual void OnBeforeSerialize() {} // 0x00000001823938D0-0x0000000182393950
		public virtual void OnAfterDeserialize() {} // 0x00000001833285D0-0x00000001833286C0
		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) {} // 0x00000001825C5D40-0x00000001825C6650
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) => default; // 0x00000001825A0EF0-0x00000001825A10E0
		public override void SetNativeSize() {} // 0x00000001825C4680-0x00000001825C4980
		protected override void OnPopulateMesh(VertexHelper toFill) {} // 0x00000001825C6880-0x00000001825C6C70
		private void TrackSprite() {} // 0x000000018239AD90-0x000000018239AE50
		protected override void OnEnable() {} // 0x000000018239F370-0x000000018239F4B0
		protected override void OnDisable() {} // 0x00000001825CA950-0x00000001825CA9D0
		protected override void Awake() {} // 0x00000001825CAE30-0x00000001825CAEC0
		protected override void OnDestroy() {} // 0x00000001825C50D0-0x00000001825C57E0
		protected override void UpdateMaterial() {} // 0x00000001825A1BD0-0x00000001825A1D50
		protected override void OnCanvasHierarchyChanged() {} // 0x00000001825A6ED0-0x00000001825A7610
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) {} // 0x0000000189E654E8-0x0000000189E65968
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) {} // 0x00000001825A2CF0-0x00000001825A3710
		private void GenerateSlicedSprite(VertexHelper toFill) {} // 0x0000000182F93F50-0x0000000182F95050
		private void GenerateTiledSprite(VertexHelper toFill) {} // 0x0000000189E64F80-0x0000000189E654E8
		private void GenerateMirrorSprite(VertexHelper toFill) {} // 0x0000000189E645EC-0x0000000189E64F80
		private void GenerateMirrorQuarter(VertexHelper toFill) {} // 0x00000001825A4330-0x00000001825A52A0
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) {} // 0x00000001825A3A10-0x00000001825A4330
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) {} // 0x0000000182636AC0-0x0000000182636CE0
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) => default; // 0x0000000182349130-0x000000018234A240
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) {} // 0x0000000182770A50-0x0000000182770BD0
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) => default; // 0x0000000182770BD0-0x0000000182770FA0
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) {} // 0x000000018350B670-0x000000018350B680
		public virtual void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public virtual void CalculateLayoutInputVertical() {} // 0x0000000183D503F0-0x0000000183D50400
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) => default; // 0x0000000189E65E74-0x0000000189E66220
		private Vector2 MapCoordinate(Vector2 local, Rect rect) => default; // 0x0000000189E66220-0x0000000189E663A8
		private static void RebuildImage(SpriteAtlas spriteAtlas) {} // 0x0000000189E663A8-0x0000000189E664A8
		private static void TrackImage(Image g) {} // 0x0000000189E664A8-0x0000000189E66518
		private static void UnTrackImage(Image g) {} // 0x00000001830FB950-0x00000001830FB980
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000189E65DCC-0x0000000189E65E74
		private Vector4 GetRuntimeAtlasSpritePadding() => default; // 0x0000000189E65CC0-0x0000000189E65DCC
		private Vector4 GetRuntimeAtlasSpriteOuterUV() => default; // 0x0000000189E65A94-0x0000000189E65CC0
		private Vector4 GetRuntimeAtlasSpriteInnerUV() => default; // 0x0000000189E65968-0x0000000189E65A94
		public string GetParticlePath() => default; // 0x0000000183D88450-0x0000000183D88460
		public void RegisterDynamicAtlas() {} // 0x00000001825CA340-0x00000001825CA510
		public void UnRegisterDynamicAtlas(Sprite _sprite) {} // 0x0000000182529DA0-0x0000000182529EC0
		public void RegisterDynamicAtlasCallBack(Action cb) {} // 0x000000018252A230-0x000000018252A2D0
		public void UnRegisterDynamicAtlasCallBack(Action cb) {} // 0x00000001825C9090-0x00000001825CA300
		private static void _CanvasRreWillRenderCanvases() {} // 0x00000001838E2ED0-0x00000001838E3210
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Not supported anymore.", true)]
	public interface IMask // TypeDefIndex: 53835
	{
		// Properties
		RectTransform rectTransform { get; }
	
		// Methods
		bool Enabled();
	}

	public interface IMaskable // TypeDefIndex: 53836
	{
		// Methods
		void RecalculateMasking();
	}

	public class InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 53848
	{
		// Fields
		protected TouchScreenKeyboard m_Keyboard; // 0x180
		private static readonly char[] kSeparators; // 0x00
		private static bool s_IsQuestDevice; // 0x08
		[FormerlySerializedAs("text")]
		[SerializeField]
		protected Text m_TextComponent; // 0x188
		[SerializeField]
		protected Graphic m_Placeholder; // 0x190
		[SerializeField]
		private ContentType m_ContentType; // 0x198
		[FormerlySerializedAs("inputType")]
		[SerializeField]
		private InputType m_InputType; // 0x19C
		[FormerlySerializedAs("asteriskChar")]
		[SerializeField]
		private char m_AsteriskChar; // 0x1A0
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType; // 0x1A4
		[SerializeField]
		private LineType m_LineType; // 0x1A8
		[FormerlySerializedAs("hideMobileInput")]
		[SerializeField]
		private bool m_HideMobileInput; // 0x1AC
		[FormerlySerializedAs("validation")]
		[SerializeField]
		private CharacterValidation m_CharacterValidation; // 0x1B0
		[FormerlySerializedAs("characterLimit")]
		[SerializeField]
		private int m_CharacterLimit; // 0x1B4
		[FormerlySerializedAs("m_OnEndEdit")]
		[FormerlySerializedAs("m_EndEdit")]
		[FormerlySerializedAs("m_OnSubmit")]
		[FormerlySerializedAs("onSubmit")]
		[SerializeField]
		private SubmitEvent m_OnSubmit; // 0x1B8
		[SerializeField]
		private EndEditEvent m_OnDidEndEdit; // 0x1C0
		[FormerlySerializedAs("onValueChange")]
		[FormerlySerializedAs("m_OnValueChange")]
		[SerializeField]
		private OnChangeEvent m_OnValueChanged; // 0x1C8
		[FormerlySerializedAs("onValidateInput")]
		[SerializeField]
		private OnValidateInput m_OnValidateInput; // 0x1D0
		[FormerlySerializedAs("selectionColor")]
		[SerializeField]
		private UnityEngine.Color m_CaretColor; // 0x1D8
		[SerializeField]
		private bool m_CustomCaretColor; // 0x1E8
		[SerializeField]
		private UnityEngine.Color m_SelectionColor; // 0x1EC
		[FormerlySerializedAs("mValue")]
		[Multiline]
		[SerializeField]
		protected string m_Text; // 0x200
		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate; // 0x208
		[Range(1f, 5f)]
		[SerializeField]
		private int m_CaretWidth; // 0x20C
		[SerializeField]
		private bool m_ReadOnly; // 0x210
		[SerializeField]
		private bool m_ShouldActivateOnSelect; // 0x211
		protected int m_CaretPosition; // 0x214
		protected int m_CaretSelectPosition; // 0x218
		private RectTransform caretRectTrans; // 0x220
		protected UIVertex[] m_CursorVerts; // 0x228
		private TextGenerator m_InputTextCache; // 0x230
		private CanvasRenderer m_CachedInputRenderer; // 0x238
		private bool m_PreventFontCallback; // 0x240
		[NonSerialized]
		protected Mesh m_Mesh; // 0x248
		private bool m_AllowInput; // 0x250
		private bool m_ShouldActivateNextUpdate; // 0x251
		private bool m_UpdateDrag; // 0x252
		private bool m_DragPositionOutOfBounds; // 0x253
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x01FD619D
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x01FD61A1
		protected bool m_CaretVisible; // 0x254
		private Coroutine m_BlinkCoroutine; // 0x258
		private float m_BlinkStartTime; // 0x260
		protected int m_DrawStart; // 0x264
		protected int m_DrawEnd; // 0x268
		private Coroutine m_DragCoroutine; // 0x270
		private string m_OriginalText; // 0x278
		private bool m_WasCanceled; // 0x280
		private bool m_HasDoneFocusTransition; // 0x281
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x288
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x290
		private bool m_IsCompositionActive; // 0x291
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x01FD61A5
		private const string kOculusQuestDeviceModel = "Oculus Quest"; // Metadata: 0x01FD61B9
		private UnityEngine.Event m_ProcessingEvent; // 0x298
		private const int k_MaxTextLength = 16382; // Metadata: 0x01FD61C6
	
		// Properties
		private BaseInput input { get => default; } // 0x0000000189F6E1D8-0x0000000189F6E494 
		private string compositionString { get => default; } // 0x0000000183D56B70-0x0000000183D56B80 
		protected Mesh mesh { get => default; } // 0x0000000189F6D460-0x0000000189F6D4B0 
		protected TextGenerator cachedInputTextGenerator { get => default; } // 0x0000000189F6DB74-0x0000000189F6DBB4 
		public bool shouldHideMobileInput { get => default; set {} } // 0x0000000189F6DDBC-0x0000000189F6DDD4 0x0000000183D57B80-0x0000000183D57B90
		public virtual bool shouldActivateOnSelect { get => default; set {} } // 0x0000000189F6E100-0x0000000189F6E140 0x0000000183D89B90-0x0000000183D89BA0
		public string text { get => default; set {} } // 0x0000000183D571E0-0x0000000183D571F0 0x0000000189F6DF30-0x0000000189F6DF7C
		public bool isFocused { get => default; } // 0x0000000183D571D0-0x0000000183D571E0 
		public float caretBlinkRate { get => default; set {} } // 0x0000000189F6E014-0x0000000189F6E01C 0x0000000183D571D0-0x0000000183D571E0
		public int caretWidth { get => default; set {} } // 0x0000000189F6E01C-0x0000000189F6E068 0x0000000183D57000-0x0000000183D57010
		public Text textComponent { get => default; set {} } // 0x0000000189F6DFC8-0x0000000189F6E014 0x0000000183D75FD0-0x0000000183D75FE0
		public Graphic placeholder { get => default; set {} } // 0x0000000189F6DC70-0x0000000189F6DD04 0x0000000183D59CC0-0x0000000183D59CD0
		public UnityEngine.Color caretColor { get => default; set {} } // 0x0000000189F6DD60-0x0000000189F6DDBC 0x0000000183D583A0-0x0000000183D583B0
		public bool customCaretColor { get => default; set {} } // 0x0000000189F6DE8C-0x0000000189F6DF30 0x0000000183D59CB0-0x0000000183D59CC0
		public UnityEngine.Color selectionColor { get => default; set {} } // 0x0000000189F6DDD4-0x0000000189F6DE30 0x0000000183D56B50-0x0000000183D56B60
		public EndEditEvent onEndEdit { get => default; set {} } // 0x0000000183D730A0-0x0000000183D730B0 0x0000000189F6DE30-0x0000000189F6DE8C
		public SubmitEvent onSubmit { get => default; set {} } // 0x0000000183D84CB0-0x0000000183D84CC0 0x0000000189F6DD04-0x0000000189F6DD60
		[Obsolete("onValueChange has been renamed to onValueChanged")]
		public OnChangeEvent onValueChange { get => default; set {} } // 0x0000000183D58AD0-0x0000000183D58AE0 0x0000000183D58AE0-0x0000000183D58AF0
		public OnChangeEvent onValueChanged { get => default; set {} } // 0x0000000189F6D738-0x0000000189F6D750 0x0000000183D89B80-0x0000000183D89B90
		public OnValidateInput onValidateInput { get => default; set {} } // 0x0000000189F6DAB0-0x0000000189F6DB0C 0x0000000183D57C70-0x0000000183D57C80
		public int characterLimit { get => default; set {} } // 0x0000000189F66AB4-0x0000000189F66AE8 0x0000000189F6D4B0-0x0000000189F6D4DC
		public ContentType contentType { get => default; set {} } // 0x0000000189F6DBB4-0x0000000189F6DBCC 0x0000000189F6D4DC-0x0000000189F6D508
		public LineType lineType { get => default; set {} } // 0x0000000189F6DBFC-0x0000000189F6DC14 0x0000000189F6D594-0x0000000189F6D5C4
		public InputType inputType { get => default; set {} } // 0x0000000189F6D4DC-0x0000000189F6D508 0x0000000189F6DBCC-0x0000000189F6DBFC
		public TouchScreenKeyboard touchScreenKeyboard { get => default; } // 0x0000000189F6D4B0-0x0000000189F6D4DC 
		public TouchScreenKeyboardType keyboardType { get => default; set {} } // 0x0000000189F6E0B4-0x0000000189F6E100 0x0000000189F6D4DC-0x0000000189F6D508
		public CharacterValidation characterValidation { get => default; set {} } // 0x0000000189F6E140-0x0000000189F6E18C 0x0000000189F6A958-0x0000000189F6ABC8
		public bool readOnly { get => default; set {} } // 0x0000000189F6A554-0x0000000189F6A7A0 0x0000000189F66A58-0x0000000189F66AB4
		public bool multiLine { get => default; } // 0x0000000189F6B6B8-0x0000000189F6B6F8 
		public char asteriskChar { get => default; set {} } // 0x0000000189F6B650-0x0000000189F6B6B8 0x0000000189F6C1CC-0x0000000189F6C2B0
		public bool wasCanceled { get => default; } // 0x0000000189F6AD68-0x0000000189F6AD70 
		protected int caretPositionInternal { get => default; set {} } // 0x0000000189F6A398-0x0000000189F6A3EC 0x0000000189F6A3EC-0x0000000189F6A42C
		protected int caretSelectPositionInternal { get => default; set {} } // 0x0000000189D005B0-0x0000000189D005B8 0x0000000189D00AB8-0x0000000189D00AC0
		private new bool hasSelection { get => default; } // 0x0000000189F6C0B4-0x0000000189F6C11C 
		public int caretPosition { get => default; set {} } // 0x0000000189F68874-0x0000000189F68898 0x0000000189F68810-0x0000000189F68874
		public int selectionAnchorPosition { get => default; set {} } // 0x0000000189F6C11C-0x0000000189F6C1CC 0x0000000189F68E40-0x0000000189F69BEC
		public int selectionFocusPosition { get => default; set {} } // 0x0000000189F6B1D8-0x0000000189F6B4A8 0x0000000189F686AC-0x0000000189F68810
		private static string clipboard { get => default; set {} } // 0x0000000189F6B008-0x0000000189F6B1C0 0x0000000189F68620-0x0000000189F686AC
		public virtual float minWidth { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public virtual float preferredWidth { get => default; } // 0x0000000189F6EA40-0x0000000189F6EA8C 
		public virtual float flexibleWidth { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public virtual float minHeight { get => default; } // 0x00000001810410F0-0x0000000181041100 
		public virtual float preferredHeight { get => default; } // 0x000000018350B670-0x000000018350B680 
		public virtual float flexibleHeight { get => default; } // 0x0000000189F6EAD8-0x0000000189F6ED60 
		public virtual int layoutPriority { get => default; } // 0x0000000181041090-0x00000001810410A0 
		Transform ICanvasElement.transform { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 53837
		{
			Standard = 0,
			Autocorrected = 1,
			IntegerNumber = 2,
			DecimalNumber = 3,
			Alphanumeric = 4,
			Name = 5,
			EmailAddress = 6,
			Password = 7,
			Pin = 8,
			Custom = 9
		}
	
		public enum InputType // TypeDefIndex: 53838
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 53839
		{
			None = 0,
			Integer = 1,
			Decimal = 2,
			Alphanumeric = 3,
			Name = 4,
			EmailAddress = 5
		}
	
		public enum LineType // TypeDefIndex: 53840
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 53841; 0x0000000189F6D508-0x0000000189F6D594
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 53842
		{
			// Constructors
			public SubmitEvent() {} // 0x0000000189F6D3E4-0x0000000189F6D460
		}
	
		[Serializable]
		public class EndEditEvent : UnityEvent<string> // TypeDefIndex: 53843
		{
			// Constructors
			public EndEditEvent() {} // 0x0000000189F6E18C-0x0000000189F6E1D8
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 53844
		{
			// Constructors
			public OnChangeEvent() {} // 0x0000000189F6DA80-0x0000000189F6DAB0
		}
	
		protected enum EditState // TypeDefIndex: 53845
		{
			Continue = 0,
			Finish = 1
		}
	
		// Constructors
		protected InputField() {} // 0x0000000189F6E068-0x0000000189F6E0B4
		static InputField() {} // 0x0000000189F6ED60-0x0000000189F6EF08
	
		// Methods
		public void SetTextWithoutNotify(string input) {} // 0x0000000183D57130-0x0000000183D57140
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x01FD619C */) {} // 0x0000000189F6DF7C-0x0000000189F6DFC8
		protected void ClampPos(ref int pos) {} // 0x0000000189F6B4A8-0x0000000189F6B4E0
		protected override void OnEnable() {} // 0x0000000189F682C4-0x0000000189F684BC
		protected override void OnDisable() {} // 0x0000000189F6A030-0x0000000189F6A0DC
		[IteratorStateMachine(typeof(_CaretBlink_d__169))]
		private IEnumerator CaretBlink() => default; // 0x0000000189F6A508-0x0000000189F6A52C
		private void SetCaretVisible() {} // 0x0000000189F6A7A0-0x0000000189F6A958
		private void SetCaretActive() {} // 0x0000000189F6A0DC-0x0000000189F6A150
		private void UpdateCaretMaterial() {} // 0x0000000189F6ABC8-0x0000000189F6ABEC
		protected void OnFocus() {} // 0x0000000189F6AD98-0x0000000189F6AF88
		protected void SelectAll() {} // 0x0000000189F68A6C-0x0000000189F68E40
		public void MoveTextEnd(bool shift) {} // 0x0000000189F68A0C-0x0000000189F68A6C
		public void MoveTextStart(bool shift) {} // 0x0000000189F6B1C0-0x0000000189F6B1C8
		private bool TouchScreenKeyboardShouldBeUsed() => default; // 0x0000000189F67240-0x0000000189F672FC
		private bool InPlaceEditing() => default; // 0x0000000189F6A2EC-0x0000000189F6A398
		private bool InPlaceEditingChanged() => default; // 0x0000000189F672FC-0x0000000189F673B0
		private void UpdateCaretFromKeyboard() {} // 0x0000000189F6A240-0x0000000189F6A2EC
		protected virtual void LateUpdate() {} // 0x0000000189F66FBC-0x0000000189F67058
		[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
		public Vector2 ScreenToLocal(Vector2 screen) => default; // 0x0000000189F69DDC-0x0000000189F69FE4
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) => default; // 0x0000000189F69BEC-0x0000000189F69DDC
		protected int GetCharacterIndexFromPosition(Vector2 pos) => default; // 0x0000000189F6A234-0x0000000189F6A240
		private bool MayDrag(PointerEventData eventData) => default; // 0x0000000189F6A150-0x0000000189F6A234
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189F6A42C-0x0000000189F6A438
		public virtual void OnDrag(PointerEventData eventData) {} // 0x0000000189F6A438-0x0000000189F6A508
		[IteratorStateMachine(typeof(_MouseDragOutsideRect_d__191))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData) => default; // 0x0000000189F66DE4-0x0000000189F66FBC
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x0000000189F673B8-0x0000000189F67454
		public override void OnPointerDown(PointerEventData eventData) {} // 0x0000000189F66978-0x0000000189F66A58
		protected EditState KeyPressed(UnityEngine.Event evt) => default; // 0x0000000189F68898-0x0000000189F689A0
		private bool IsValidChar(char c) => default; // 0x0000000189F6CAD0-0x0000000189F6CB18
		public void ProcessEvent(UnityEngine.Event e) {} // 0x0000000189F6B5C0-0x0000000189F6B5E0
		public virtual void OnUpdateSelected(BaseEventData eventData) {} // 0x0000000189F6B5E0-0x0000000189F6B650
		private string GetSelectedString() => default; // 0x0000000189F6B4E0-0x0000000189F6B550
		private int FindtNextWordBegin() => default; // 0x0000000189F6B550-0x0000000189F6B5C0
		private void MoveRight(bool shift, bool ctrl) {} // 0x0000000189F661E0-0x0000000189F66268
		private int FindtPrevWordBegin() => default; // 0x0000000189F65F60-0x0000000189F661E0
		private void MoveLeft(bool shift, bool ctrl) {} // 0x0000000189F6C69C-0x0000000189F6CAD0
		private int DetermineCharacterLine(int charPos, TextGenerator generator) => default; // 0x0000000189F689A0-0x0000000189F68A0C
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) => default; // 0x0000000189F68578-0x0000000189F68620
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar) => default; // 0x0000000189F684BC-0x0000000189F68578
		private void MoveDown(bool shift) {} // 0x0000000189F6B6F8-0x0000000189F6BCCC
		private void MoveDown(bool shift, bool goToLastChar) {} // 0x0000000189F673B0-0x0000000189F673B8
		private void MoveUp(bool shift) {} // 0x0000000189F69FE4-0x0000000189F6A030
		private void MoveUp(bool shift, bool goToFirstChar) {} // 0x0000000189F6B1C8-0x0000000189F6B1D8
		private void Delete() {} // 0x000000018350B670-0x000000018350B680
		private void ForwardSpace() {} // 0x000000018350B670-0x000000018350B680
		private void Backspace() {} // 0x0000000189F6C2B0-0x0000000189F6C69C
		private void Insert(char c) {} // 0x0000000189F66268-0x0000000189F66978
		private void UpdateTouchKeyboardFromEditChanges() {} // 0x0000000189F6ABEC-0x0000000189F6AD68
		private void SendOnValueChangedAndUpdateLabel() {} // 0x0000000189F67454-0x0000000189F67B14
		private void SendOnValueChanged() {} // 0x0000000189F66AE8-0x0000000189F66C50
		protected void SendOnEndEdit() {} // 0x0000000189F67B14-0x0000000189F682C4
		protected void SendOnSubmit() {} // 0x0000000189F6CB18-0x0000000189F6D154
		protected virtual void Append(string input) {} // 0x0000000189F65E48-0x0000000189F65F60
		protected virtual void Append(char input) {} // 0x0000000189F65B2C-0x0000000189F65E48
		protected void UpdateLabel() {} // 0x0000000189F6AF88-0x0000000189F6AFC4
		private bool IsSelectionVisible() => default; // 0x0000000189F6AD70-0x0000000189F6AD98
		private static int GetLineStartPosition(TextGenerator gen, int line) => default; // 0x0000000189F66C50-0x0000000189F66DE4
		private static int GetLineEndPosition(TextGenerator gen, int line) => default; // 0x0000000189F6A52C-0x0000000189F6A554
		private void SetDrawRangeToContainCaretPosition(int caretPos) {} // 0x0000000189F6AFC4-0x0000000189F6B008
		public void ForceLabelUpdate() {} // 0x0000000189F6707C-0x0000000189F671AC
		private void MarkGeometryAsDirty() {} // 0x0000000189F671AC-0x0000000189F67240
		public virtual void Rebuild(CanvasUpdate update) {} // 0x0000000189F6C04C-0x0000000189F6C09C
		public virtual void LayoutComplete() {} // 0x0000000189F6C09C-0x0000000189F6C0B4
		public virtual void GraphicUpdateComplete() {} // 0x0000000189F67058-0x0000000189F6707C
		private void UpdateGeometry() {} // 0x000000018350B670-0x000000018350B680
		private void AssignPositioningIfNeeded() {} // 0x000000018350B670-0x000000018350B680
		private void OnFillVBO(Mesh vbo) {} // 0x0000000183D503F0-0x0000000183D50400
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) {} // 0x0000000189F6D8FC-0x0000000189F6DA5C
		private void CreateCursorVerts() {} // 0x0000000183D751A0-0x0000000183D751B0
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) {} // 0x0000000183D503F0-0x0000000183D50400
		protected char Validate(string text, int pos, char ch) => default; // 0x0000000189F6D750-0x0000000189F6D8FC
		public void ActivateInputField() {} // 0x0000000183D751A0-0x0000000183D751B0
		private void ActivateInputFieldInternal() {} // 0x0000000181168950-0x0000000181168960
		public override void OnSelect(BaseEventData eventData) {} // 0x0000000189F6D154-0x0000000189F6D1F0
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000184273A88-0x0000000184273A90
		public void DeactivateInputField() {} // 0x0000000189CFC420-0x0000000189CFC4F4
		public override void OnDeselect(BaseEventData eventData) {} // 0x0000000181035ED0-0x0000000181035EF0
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000189F6E848-0x0000000189F6E8E4
		private void EnforceContentType() {} // 0x00000001880658B0-0x00000001880659E0
		private void EnforceTextHOverflow() {} // 0x0000000189F6E8E4-0x0000000189F6E920
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes) {} // 0x0000000189F65708-0x0000000189F65744
		private void SetToCustom() {} // 0x0000000189F6E80C-0x0000000189F6E848
		protected override void DoStateTransition(SelectionState state, bool instant) {} // 0x00000001810410F0-0x0000000181041100
		public virtual void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public virtual void CalculateLayoutInputVertical() {} // 0x0000000189F6E920-0x0000000189F6EA40
	}

	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController // TypeDefIndex: 53850
	{
		// Fields
		[SerializeField]
		private AspectMode m_AspectMode; // 0x18
		[SerializeField]
		private float m_AspectRatio; // 0x1C
		[NonSerialized]
		private RectTransform m_Rect; // 0x20
		private bool m_DelayedSetDirty; // 0x28
		private bool m_DoesParentExist; // 0x29
		private DrivenRectTransformTracker m_Tracker; // 0x2A
	
		// Properties
		public AspectMode aspectMode { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000189F65530-0x0000000189F65588
		public float aspectRatio { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000189F65588-0x0000000189F655E4
		private RectTransform rectTransform { get => default; } // 0x00000001833BCC80-0x00000001833BCD10 
	
		// Nested types
		public enum AspectMode // TypeDefIndex: 53849
		{
			None = 0,
			WidthControlsHeight = 1,
			HeightControlsWidth = 2,
			FitInParent = 3,
			EnvelopeParent = 4
		}
	
		// Constructors
		protected AspectRatioFitter() {} // 0x0000000183B45ED0-0x0000000183B45EE0
	
		// Methods
		protected override void OnEnable() {} // 0x00000001833BC860-0x00000001833BC910
		protected override void Start() {} // 0x00000001833BC650-0x00000001833BC680
		protected override void OnDisable() {} // 0x00000001833BC910-0x00000001833BC970
		protected override void OnTransformParentChanged() {} // 0x0000000189F654B0-0x0000000189F65530
		protected virtual void Update() {} // 0x00000001836515F0-0x0000000183651610
		protected override void OnRectTransformDimensionsChange() {} // 0x00000001833BC970-0x00000001833BC980
		private void UpdateRect() {} // 0x00000001833BC980-0x00000001833BCC80
		private float GetSizeDeltaToProduceSize(float size, int axis) => default; // 0x00000001833BC690-0x00000001833BC790
		private Vector2 GetParentSize() => default; // 0x00000001833BC790-0x00000001833BC860
		public virtual void SetLayoutHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public virtual void SetLayoutVertical() {} // 0x000000018350B670-0x000000018350B680
		protected void SetDirty() {} // 0x00000001833BC970-0x00000001833BC980
		public bool IsComponentValidOnObject() => default; // 0x00000001833BCD10-0x00000001833BCDA0
		public bool IsAspectModeValid() => default; // 0x00000001833BC680-0x00000001833BC690
		private bool DoesParentExists() => default; // 0x0000000183D4F2A0-0x0000000183D4F2B0
	}

	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(Canvas))]
	public class CanvasScaler : UIBehaviour // TypeDefIndex: 53854
	{
		// Fields
		[SerializeField]
		[Tooltip("Determines how UI elements in the Canvas are scaled.")]
		private ScaleMode m_UiScaleMode; // 0x18
		[SerializeField]
		[Tooltip("If a sprite has this \'Pixels Per Unit\' setting, then one pixel in the sprite will cover one unit in the UI.")]
		protected float m_ReferencePixelsPerUnit; // 0x1C
		[SerializeField]
		[Tooltip("Scales all UI elements in the Canvas by this factor.")]
		protected float m_ScaleFactor; // 0x20
		[SerializeField]
		[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it\'s smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
		protected Vector2 m_ReferenceResolution; // 0x24
		[SerializeField]
		[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn\'t fit the reference resolution.")]
		protected ScreenMatchMode m_ScreenMatchMode; // 0x2C
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
		protected float m_MatchWidthOrHeight; // 0x30
		private const float kLogBase = 2f; // Metadata: 0x01FD61E7
		[SerializeField]
		[Tooltip("The physical unit to specify positions and sizes in.")]
		protected Unit m_PhysicalUnit; // 0x34
		[SerializeField]
		[Tooltip("The DPI to assume if the screen DPI is not known.")]
		protected float m_FallbackScreenDPI; // 0x38
		[SerializeField]
		[Tooltip("The pixels per inch to use for sprites that have a \'Pixels Per Unit\' setting that matches the \'Reference Pixels Per Unit\' setting.")]
		protected float m_DefaultSpriteDPI; // 0x3C
		[SerializeField]
		[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
		protected float m_DynamicPixelsPerUnit; // 0x40
		private Canvas m_Canvas; // 0x48
		[NonSerialized]
		private float m_PrevScaleFactor; // 0x50
		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit; // 0x54
		[SerializeField]
		protected bool m_PresetInfoIsWorld; // 0x58
	
		// Properties
		public ScaleMode uiScaleMode { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public float referencePixelsPerUnit { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000183D4F120-0x0000000183D4F130
		public float scaleFactor { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000189F6569C-0x0000000189F656B0
		public Vector2 referenceResolution { get => default; set {} } // 0x0000000183D50A80-0x0000000183D50AA0 0x00000001827FF6C0-0x00000001827FF710
		public ScreenMatchMode screenMatchMode { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public float matchWidthOrHeight { get => default; set {} } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000183D4F5E0-0x0000000183D4F5F0
		public Unit physicalUnit { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		public float fallbackScreenDPI { get => default; set {} } // 0x0000000183D51000-0x0000000183D51010 0x0000000183D51010-0x0000000183D51020
		public float defaultSpriteDPI { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000189F65688-0x0000000189F6569C
		public float dynamicPixelsPerUnit { get => default; set {} } // 0x0000000183D4EC70-0x0000000183D4EC80 0x0000000183D4ECF0-0x0000000183D4ED00
	
		// Nested types
		public enum ScaleMode // TypeDefIndex: 53851
		{
			ConstantPixelSize = 0,
			ScaleWithScreenSize = 1,
			ConstantPhysicalSize = 2
		}
	
		public enum ScreenMatchMode // TypeDefIndex: 53852
		{
			MatchWidthOrHeight = 0,
			Expand = 1,
			Shrink = 2
		}
	
		public enum Unit // TypeDefIndex: 53853
		{
			Centimeters = 0,
			Millimeters = 1,
			Inches = 2,
			Points = 3,
			Picas = 4
		}
	
		// Constructors
		protected CanvasScaler() {} // 0x000000018352E5B0-0x000000018352E600
	
		// Methods
		protected override void OnEnable() {} // 0x0000000182473670-0x0000000182473720
		private void Canvas_preWillRenderCanvases() {} // 0x0000000182373580-0x00000001823737A0
		protected override void OnDisable() {} // 0x0000000182472550-0x0000000182472600
		public void HandleManually() {} // 0x00000001827FE790-0x00000001827FE830
		protected virtual void Handle() {} // 0x00000001823737A0-0x00000001823739C0
		protected virtual void HandleWorldCanvas() {} // 0x0000000182FEC020-0x0000000182FEC080
		protected virtual void HandleConstantPixelSize() {} // 0x0000000183D47B30-0x0000000183D47B60
		protected virtual void HandleScaleWithScreenSize() {} // 0x0000000182375490-0x00000001823757F0
		protected virtual void HandleConstantPhysicalSize() {} // 0x0000000189F655E4-0x0000000189F65688
		protected void SetScaleFactor(float scaleFactor) {} // 0x0000000182373A90-0x0000000182373AE0
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) {} // 0x0000000182373AE0-0x0000000182373B10
	}

	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController // TypeDefIndex: 53856
	{
		// Fields
		[SerializeField]
		protected FitMode m_HorizontalFit; // 0x18
		[SerializeField]
		protected FitMode m_VerticalFit; // 0x1C
		[NonSerialized]
		private RectTransform m_Rect; // 0x20
		private DrivenRectTransformTracker m_Tracker; // 0x28
	
		// Properties
		public FitMode horizontalFit { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x000000018259D3B0-0x000000018259D410
		public FitMode verticalFit { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000189F656B0-0x0000000189F65708
		private RectTransform rectTransform { get => default; } // 0x000000018259FEA0-0x000000018259FFD0 
	
		// Nested types
		public enum FitMode // TypeDefIndex: 53855
		{
			Unconstrained = 0,
			MinSize = 1,
			PreferredSize = 2
		}
	
		// Constructors
		protected ContentSizeFitter() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnEnable() {} // 0x000000018259E3B0-0x000000018259E3C0
		protected override void OnDisable() {} // 0x000000018259E350-0x000000018259E3B0
		protected override void OnRectTransformDimensionsChange() {} // 0x000000018259E3B0-0x000000018259E3C0
		private void HandleSelfFittingAlongAxis(int axis) {} // 0x000000018259FE10-0x000000018259FEA0
		public virtual void SetLayoutHorizontal() {} // 0x000000018259FDA0-0x000000018259FE10
		public virtual void SetLayoutVertical() {} // 0x000000018427071C-0x0000000184270730
		protected void SetDirty() {} // 0x000000018259E560-0x000000018259E5E0
	}

	[AddComponentMenu("Layout/Grid Layout Group", 152)]
	public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 53860
	{
		// Fields
		[SerializeField]
		protected Corner m_StartCorner; // 0x58
		[SerializeField]
		protected Axis m_StartAxis; // 0x5C
		[SerializeField]
		protected Vector2 m_CellSize; // 0x60
		[SerializeField]
		protected Vector2 m_Spacing; // 0x68
		[SerializeField]
		protected Constraint m_Constraint; // 0x70
		[SerializeField]
		protected int m_ConstraintCount; // 0x74
	
		// Properties
		public Corner startCorner { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000189F65900-0x0000000189F6594C
		public Axis startAxis { get => default; set {} } // 0x0000000183D4EEF0-0x0000000183D4EF00 0x0000000189F658B4-0x0000000189F65900
		public Vector2 cellSize { get => default; set {} } // 0x0000000183D89B40-0x0000000183D89B60 0x0000000189F65760-0x0000000189F657B4
		public Vector2 spacing { get => default; set {} } // 0x0000000183D89B60-0x0000000183D89B80 0x0000000189F65860-0x0000000189F658B4
		public Constraint constraint { get => default; set {} } // 0x0000000183D4F0C0-0x0000000183D4F0D0 0x0000000189F65814-0x0000000189F65860
		public int constraintCount { get => default; set {} } // 0x0000000183D4F0D0-0x0000000183D4F0E0 0x0000000189F657B4-0x0000000189F65814
	
		// Nested types
		public enum Corner // TypeDefIndex: 53857
		{
			UpperLeft = 0,
			UpperRight = 1,
			LowerLeft = 2,
			LowerRight = 3
		}
	
		public enum Axis // TypeDefIndex: 53858
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		public enum Constraint // TypeDefIndex: 53859
		{
			Flexible = 0,
			FixedColumnCount = 1,
			FixedRowCount = 2
		}
	
		// Constructors
		protected GridLayoutGroup() {} // 0x0000000182849F60-0x0000000182849F90
	
		// Methods
		public override void CalculateLayoutInputHorizontal() {} // 0x00000001836BE620-0x00000001836BE780
		public override void CalculateLayoutInputVertical() {} // 0x0000000182EE1740-0x0000000182EE1890
		public override void SetLayoutHorizontal() {} // 0x0000000189F65744-0x0000000189F65750
		public override void SetLayoutVertical() {} // 0x0000000189F65750-0x0000000189F65760
		private void SetCellsAlongAxis(int axis) {} // 0x0000000183497880-0x0000000183497DD0
	}

	[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 53861
	{
		// Constructors
		protected HorizontalLayoutGroup() {} // 0x000000018335B640-0x000000018335B650
	
		// Methods
		public override void CalculateLayoutInputHorizontal() {} // 0x00000001824A55E0-0x00000001824A5610
		public override void CalculateLayoutInputVertical() {} // 0x00000001842745E0-0x00000001842745F0
		public override void SetLayoutHorizontal() {} // 0x00000001842706EC-0x00000001842706FC
		public override void SetLayoutVertical() {} // 0x00000001842706DC-0x00000001842706EC
	}

	[ExecuteAlways]
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 53862
	{
		// Fields
		[SerializeField]
		protected float m_Spacing; // 0x58
		[SerializeField]
		protected bool m_ChildForceExpandWidth; // 0x5C
		[SerializeField]
		protected bool m_ChildForceExpandHeight; // 0x5D
		[SerializeField]
		protected bool m_ChildControlWidth; // 0x5E
		[SerializeField]
		protected bool m_ChildControlHeight; // 0x5F
		[SerializeField]
		protected bool m_ChildScaleWidth; // 0x60
		[SerializeField]
		protected bool m_ChildScaleHeight; // 0x61
		[SerializeField]
		protected bool m_ReverseArrangement; // 0x62
	
		// Properties
		public float spacing { get; set; } // 0x0000000183D51080-0x0000000183D51090 0x0000000183C7DF90-0x0000000183C7DFE0
		public bool childForceExpandWidth { get; set; } // 0x0000000183D4F600-0x0000000183D4F610 0x0000000183641ED0-0x0000000183641F20
		public bool childForceExpandHeight { get; set; } // 0x0000000183D71350-0x0000000183D71360 0x0000000189F659EC-0x0000000189F65A3C
		public bool childControlWidth { get; set; } // 0x0000000183D71370-0x0000000183D71380 0x0000000189F6599C-0x0000000189F659EC
		public bool childControlHeight { get; set; } // 0x0000000183D57680-0x0000000183D57690 0x0000000189F6594C-0x0000000189F6599C
		public bool childScaleWidth { get; set; } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000189F65A8C-0x0000000189F65ADC
		public bool childScaleHeight { get; set; } // 0x0000000183D51F90-0x0000000183D51FA0 0x0000000189F65A3C-0x0000000189F65A8C
		public bool reverseArrangement { get; set; } // 0x0000000183D5B400-0x0000000183D5B410 0x0000000189F65ADC-0x0000000189F65B2C
	
		// Constructors
		protected HorizontalOrVerticalLayoutGroup() {} // 0x000000018335B640-0x000000018335B650
	
		// Methods
		protected void CalcAlongAxis(int axis, bool isVertical) {} // 0x00000001824A8150-0x00000001824A87E0
		protected void SetChildrenAlongAxis(int axis, bool isVertical) {} // 0x00000001824A7280-0x00000001824A8150
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) {
			min = default;
			preferred = default;
			flexible = default;
		} // 0x00000001824A87E0-0x00000001824A8B20
	}

	public interface ILayoutElement // TypeDefIndex: 53863
	{
		// Properties
		float minWidth { get; }
		float preferredWidth { get; }
		float flexibleWidth { get; }
		float minHeight { get; }
		float preferredHeight { get; }
		float flexibleHeight { get; }
		int layoutPriority { get; }
	
		// Methods
		void CalculateLayoutInputHorizontal();
		void CalculateLayoutInputVertical();
	}

	public interface ILayoutController // TypeDefIndex: 53864
	{
		// Methods
		void SetLayoutHorizontal();
		void SetLayoutVertical();
	}

	public interface ILayoutGroup : ILayoutController // TypeDefIndex: 53865
	{
	}

	public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 53866
	{
	}

	public interface ILayoutIgnorer // TypeDefIndex: 53867
	{
		// Properties
		bool ignoreLayout { get; }
	}

	[AddComponentMenu("Layout/Layout Element", 140)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 53868
	{
		// Fields
		[SerializeField]
		private bool m_IgnoreLayout; // 0x18
		[SerializeField]
		private float m_MinWidth; // 0x1C
		[SerializeField]
		private float m_MinHeight; // 0x20
		[SerializeField]
		private float m_PreferredWidth; // 0x24
		[SerializeField]
		private float m_PreferredHeight; // 0x28
		[SerializeField]
		private float m_FlexibleWidth; // 0x2C
		[SerializeField]
		private float m_FlexibleHeight; // 0x30
		[SerializeField]
		private int m_LayoutPriority; // 0x34
	
		// Properties
		public virtual bool ignoreLayout { get => default; set {} } // 0x0000000181002A50-0x0000000181002A60 0x00000001822BF6C0-0x00000001822BF720
		public virtual float minWidth { get => default; set {} } // 0x0000000183D4F110-0x0000000183D4F120 0x0000000189F6E5B0-0x0000000189F6E60C
		public virtual float minHeight { get => default; set {} } // 0x0000000183D4F2E0-0x0000000183D4F2F0 0x0000000189F6E554-0x0000000189F6E5B0
		public virtual float preferredWidth { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000182CD0CC0-0x0000000182CD0D20
		public virtual float preferredHeight { get => default; set {} } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000182CD1420-0x0000000182CD1480
		public virtual float flexibleWidth { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000183197A10-0x0000000183197A70
		public virtual float flexibleHeight { get => default; set {} } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000189F6E4A0-0x0000000189F6E4FC
		public virtual int layoutPriority { get => default; set {} } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000189F6E4FC-0x0000000189F6E554
	
		// Constructors
		protected LayoutElement() {} // 0x00000001831659C0-0x0000000183165A30
	
		// Methods
		public virtual void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public virtual void CalculateLayoutInputVertical() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnEnable() {} // 0x0000000182CD1270-0x0000000182CD1280
		protected override void OnTransformParentChanged() {} // 0x0000000182CD1270-0x0000000182CD1280
		protected override void OnDisable() {} // 0x0000000182CD1270-0x0000000182CD1280
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000182CD1270-0x0000000182CD1280
		protected override void OnBeforeTransformParentChanged() {} // 0x0000000182CD1270-0x0000000182CD1280
		protected void SetDirty() {} // 0x0000000182CD1280-0x0000000182CD1320
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup // TypeDefIndex: 53870
	{
		// Fields
		[SerializeField]
		protected RectOffset m_Padding; // 0x18
		[SerializeField]
		protected TextAnchor m_ChildAlignment; // 0x20
		[NonSerialized]
		private RectTransform m_Rect; // 0x28
		protected DrivenRectTransformTracker m_Tracker; // 0x30
		private Vector2 m_TotalMinSize; // 0x34
		private Vector2 m_TotalPreferredSize; // 0x3C
		private Vector2 m_TotalFlexibleSize; // 0x44
		[NonSerialized]
		private List<RectTransform> m_RectChildren; // 0x50
	
		// Properties
		public RectOffset padding { get; set; } // 0x00000001824A61E0-0x00000001824A68A0 
		public TextAnchor childAlignment { get; set; } // 0x00000001842743D0-0x00000001842743D8 0x0000000184270790-0x0000000184270798
		protected RectTransform rectTransform { get; } // 0x0000000184270750-0x0000000184270760 
		protected List<RectTransform> rectChildren { get; } // 0x0000000184270730-0x0000000184270740 
		public virtual float minWidth { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual float preferredWidth { get; }
		public virtual float flexibleWidth { get; }
		public virtual float minHeight { get; } // 0x00000001828495F0-0x0000000182849710 
		public virtual float preferredHeight { get; } // 0x00000001824A3500-0x00000001824A3510 
		public virtual float flexibleHeight { get; } // 0x000000018338BEE0-0x000000018338BF40 
		public virtual int layoutPriority { get; } // 0x00000001824A3500-0x00000001824A3510 
		private bool isRootLayoutGroup { get; } // 0x00000001810410F0-0x0000000181041100 
	
		// Constructors
		protected LayoutGroup() {} // 0x0000000189F6E60C-0x0000000189F6E618
	
		// Methods
		public virtual void CalculateLayoutInputHorizontal() {} // 0x0000000184270740-0x0000000184270750
		public abstract void CalculateLayoutInputVertical(); // 0x0000000184270760-0x0000000184270768
		public abstract void SetLayoutHorizontal(); // 0x00000001842700B8-0x00000001842700C4
		public abstract void SetLayoutVertical(); // 0x00000001842700C4-0x00000001842700D0
		protected override void OnEnable() {} // 0x00000001824A6000-0x00000001824A61E0
		protected override void OnDisable() {} // 0x00000001824A69D0-0x00000001824A6A20
		protected override void OnDidApplyAnimationProperties() {} // 0x00000001824A6E90-0x00000001824A6F00
		protected float GetTotalMinSize(int axis) => default; // 0x0000000189F6E618-0x0000000189F6E6AC
		protected float GetTotalPreferredSize(int axis) => default; // 0x00000001824A5CB0-0x00000001824A6000
		protected float GetTotalFlexibleSize(int axis) => default; // 0x0000000183497DD0-0x0000000183497E90
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) => default; // 0x00000001824A6AC0-0x00000001824A6E90
		protected float GetAlignmentOnAxis(int axis) => default; // 0x00000001824A4C20-0x00000001824A4EE0
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) {} // 0x00000001824A4BF0-0x00000001824A4C20
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) {} // 0x00000001824A3500-0x00000001824A3510
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) {}
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) {} // 0x00000001824A52C0-0x00000001824A53A0
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) {} // 0x00000001824A4550-0x00000001824A45B0
		protected override void OnRectTransformDimensionsChange() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnTransformChildrenChanged() {} // 0x00000001833F8E60-0x00000001833F8EF0
		protected void SetProperty<T>(ref ref T currentValue, T newValue) {} // 0x0000000181041090-0x00000001810410A0
		protected void SetDirty() {} // 0x0000000189F6EA8C-0x0000000189F6EAD8
		[IteratorStateMachine(typeof(_DelayedSetDirty_d__56))]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform) => default; // 0x0000000181041090-0x00000001810410A0
	}

	public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 53872
	{
		// Fields
		private RectTransform m_ToRebuild; // 0x10
		private int m_CachedHashFromTransform; // 0x18
		private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x00
	
		// Properties
		public Transform transform { get => default; } // 0x000000018239CE40-0x000000018239D060 
	
		// Constructors
		static LayoutRebuilder() {} // 0x000000018251B890-0x000000018251CA00
		public LayoutRebuilder() {} // 0x000000018259FA10-0x000000018259FAC0
	
		// Methods
		private void Initialize(RectTransform controller) {} // 0x0000000182B7C6F0-0x0000000182B7CF40
		private void Clear() {} // 0x000000018251D780-0x000000018251E0C0
		private static void ReapplyDrivenProperties(RectTransform driven) {} // 0x000000018251E350-0x000000018251E7B0
		public bool IsDestroyed() => default; // 0x000000018329DBF0-0x000000018329DC70
		private static void StripDisabledBehavioursFromList(List<UnityEngine.Component> components) {} // 0x000000018350B670-0x000000018350B680
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) {} // 0x00000001820D1AC0-0x00000001820D1AD0
		public void Rebuild(CanvasUpdate executing) {} // 0x0000000182F82620-0x0000000182F82670
		private void PerformLayoutControl(RectTransform rect, UnityAction<UnityEngine.Component> action) {} // 0x0000000189F6E6F8-0x0000000189F6E758
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<UnityEngine.Component> action) {} // 0x000000018350B670-0x000000018350B680
		public static void MarkLayoutForRebuild(RectTransform rect) {} // 0x0000000183D19E50-0x0000000183D19EB0
		private static bool ValidController(RectTransform layoutRoot, List<UnityEngine.Component> comps) => default; // 0x000000018350B670-0x000000018350B680
		private static void MarkLayoutRootForRebuild(RectTransform controller) {} // 0x000000018365AB80-0x000000018365ABC0
		public void LayoutComplete() {} // 0x0000000182337A90-0x0000000182337B10
		public void GraphicUpdateComplete() {} // 0x0000000182519810-0x00000001825198D0
		public override int GetHashCode() => default; // 0x00000001824A53E0-0x00000001824A55E0
		public override bool Equals(object obj) => default; // 0x000000018259FAC0-0x000000018259FDA0
		public override string ToString() => default; // 0x0000000182EE1550-0x0000000182EE1740
	}

	public static class LayoutUtility // TypeDefIndex: 53874
	{
		// Methods
		public static float GetMinSize(RectTransform rect, int axis) => default; // 0x0000000182517DC0-0x0000000182518C70
		public static float GetPreferredSize(RectTransform rect, int axis) => default; // 0x0000000183D1A030-0x0000000183D1A090
		public static float GetFlexibleSize(RectTransform rect, int axis) => default; // 0x000000018350B670-0x000000018350B680
		public static float GetMinWidth(RectTransform rect) => default; // 0x0000000182E88B90-0x0000000182E88BB0
		public static float GetPreferredWidth(RectTransform rect) => default; // 0x0000000182E88BB0-0x0000000182E88CF0
		public static float GetFlexibleWidth(RectTransform rect) => default; // 0x00000001825A0AE0-0x00000001825A0C40
		public static float GetMinHeight(RectTransform rect) => default; // 0x00000001825A0480-0x00000001825A05D0
		public static float GetPreferredHeight(RectTransform rect) => default; // 0x00000001825A0740-0x00000001825A08A0
		public static float GetFlexibleHeight(RectTransform rect) => default; // 0x00000001825A0740-0x00000001825A08A0
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) => default; // 0x00000001825A05D0-0x00000001825A0740
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) {
			source = default;
			return default;
		} // 0x00000001825A08A0-0x00000001825A0990
	}

	[AddComponentMenu("Layout/Vertical Layout Group", 151)]
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 53875
	{
		// Constructors
		protected VerticalLayoutGroup() {} // 0x000000018335B640-0x000000018335B650
	
		// Methods
		public override void CalculateLayoutInputHorizontal() {} // 0x00000001824A4BC0-0x00000001824A4BF0
		public override void CalculateLayoutInputVertical() {} // 0x00000001842745F0-0x0000000184274600
		public override void SetLayoutHorizontal() {} // 0x000000018427070C-0x000000018427071C
		public override void SetLayoutVertical() {} // 0x00000001842706FC-0x000000018427070C
	}

	[AddComponentMenu("UI/Mask", 13)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 53876
	{
		// Fields
		[NonSerialized]
		private RectTransform m_RectTransform; // 0x18
		[SerializeField]
		private bool m_ShowMaskGraphic; // 0x20
		[NonSerialized]
		private Graphic m_Graphic; // 0x28
		[NonSerialized]
		private Material m_MaskMaterial; // 0x30
		[NonSerialized]
		private Material m_UnmaskMaterial; // 0x38
	
		// Properties
		public RectTransform rectTransform { get => default; } // 0x0000000182516120-0x0000000182516180 
		public bool showMaskGraphic { get => default; set {} } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000189F6E758-0x0000000189F6E7E4
		public Graphic graphic { get => default; } // 0x00000001825167D0-0x0000000182516830 
	
		// Constructors
		protected Mask() {} // 0x0000000183A1E660-0x0000000183A1E670
	
		// Methods
		public virtual bool MaskEnabled() => default; // 0x0000000182516230-0x00000001825162B0
		[Obsolete("Not used anymore.")]
		public virtual void OnSiblingGraphicEnabledDisabled() {} // 0x000000018350B670-0x000000018350B680
		protected override void OnEnable() {} // 0x0000000182516680-0x00000001825167D0
		protected override void OnDisable() {} // 0x00000001825162B0-0x0000000182516490
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => default; // 0x0000000182516080-0x0000000182516120
		public virtual Material GetModifiedMaterial(Material baseMaterial) => default; // 0x0000000182516490-0x0000000182516680
	}

	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 53878
	{
		// Fields
		[NonSerialized]
		protected bool m_ShouldRecalculateStencil; // 0xB0
		[NonSerialized]
		protected Material m_MaskMaterial; // 0xB8
		[NonSerialized]
		private RectMask2D m_ParentMask; // 0xC0
		[SerializeField]
		private bool m_Maskable; // 0xC8
		private bool m_IsMaskingGraphic; // 0xC9
		[NonSerialized]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore.", true)]
		protected bool m_IncludeForMasking; // 0xCA
		[SerializeField]
		private CullStateChangedEvent m_OnCullStateChanged; // 0xD0
		[NonSerialized]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore", true)]
		protected bool m_ShouldRecalculate; // 0xD8
		[NonSerialized]
		protected int m_StencilValue; // 0xDC
		private readonly Vector3[] m_Corners; // 0xE0
	
		// Properties
		public CullStateChangedEvent onCullStateChanged { get; set; } // 0x000000018554A7E0-0x000000018554A7F4 0x0000000183D519D0-0x0000000183D519E0
		public bool maskable { get; set; } // 0x0000000189F6E7E4-0x0000000189F6E80C 0x0000000183D58400-0x0000000183D58410
		public bool isMaskingGraphic { get; set; } // 0x0000000182515FD0-0x0000000182515FE0 0x00000001825C75E0-0x00000001825C77B0
		private Rect rootCanvasRect { get; } // 0x000000018239A170-0x000000018239A3E0 
		GameObject IClippable.gameObject { get; } // 0x0000000182434120-0x00000001824341A0 
	
		// Nested types
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 53877
		{
			// Constructors
			public CullStateChangedEvent() {} // 0x0000000183D50050-0x0000000183D50060
		}
	
		// Constructors
		protected MaskableGraphic() {} // 0x000000018426FB4C-0x000000018426FB54
	
		// Methods
		public virtual Material GetModifiedMaterial(Material baseMaterial) => default; // 0x0000000182342020-0x0000000182342350
		public virtual void Cull(Rect clipRect, bool validRect) {} // 0x0000000182341DF0-0x0000000182342020
		private void UpdateCull(bool cull) {} // 0x0000000182EC41E0-0x0000000182EC4360
		public virtual void SetClipRect(Rect clipRect, bool validRect) {} // 0x0000000182341BC0-0x0000000182341C90
		public virtual void SetClipSoftness(Vector2 clipSoftness) {} // 0x0000000182341AF0-0x0000000182341BC0
		public virtual void SetHGClipSoftness(Vector4 hgClipSoftness) {} // 0x000000018239A120-0x000000018239A170
		protected override void OnEnable() {} // 0x000000018239F4B0-0x000000018239F570
		protected override void OnDisable() {} // 0x0000000183163550-0x00000001831635B0
		protected override void OnTransformParentChanged() {} // 0x000000018350B670-0x000000018350B680
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore.", true)]
		public virtual void ParentMaskStateChanged() {} // 0x00000001825A1D50-0x00000001825A2510
		protected override void OnCanvasHierarchyChanged() {} // 0x0000000182347550-0x00000001823486E0
		private void UpdateClipParent() {} // 0x0000000182515D70-0x0000000182515D80
		public virtual void RecalculateClipping() {} // 0x000000018239F2E0-0x000000018239F370
		public virtual void RecalculateMasking() {} // 0x0000000182433960-0x00000001824340C0
	}

	public class MaskUtilities // TypeDefIndex: 53879
	{
		// Constructors
		public MaskUtilities() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void Notify2DMaskStateChanged(UnityEngine.Component mask) {} // 0x0000000182518C70-0x0000000182519020
		public static void NotifyStencilStateChanged(UnityEngine.Component mask) {} // 0x00000001825168D0-0x0000000182516B00
		public static Transform FindRootSortOverrideCanvas(Transform start) => default; // 0x0000000182517670-0x00000001825179F0
		public static int GetStencilDepth(Transform transform, Transform stopAfter) => default; // 0x000000018251E990-0x000000018251EE60
		public static bool IsDescendantOrSelf(Transform father, Transform child) => default; // 0x000000018251CDF0-0x000000018251D250
		public static RectMask2D GetRectMaskForClippable(IClippable clippable) => default; // 0x000000018239A3E0-0x000000018239AD90
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks) {} // 0x0000000182516EE0-0x0000000182517200
	}

	public interface IMaterialModifier // TypeDefIndex: 53880
	{
		// Methods
		Material GetModifiedMaterial(Material baseMaterial);
	}

	internal static class Misc // TypeDefIndex: 53881
	{
		// Methods
		public static void Destroy(UnityEngine.Object obj) {} // 0x0000000189F6F368-0x0000000189F6F434
		public static void DestroyImmediate(UnityEngine.Object obj) {} // 0x00000001839B53E0-0x00000001839B5460
	}

	internal static class MultipleDisplayUtilities // TypeDefIndex: 53882
	{
		// Methods
		public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) => default; // 0x0000000189F6F434-0x0000000189F6F50C
		public static Vector3 RelativeMouseAtScaled(Vector2 position) => default; // 0x000000018256C470-0x000000018256CA50
	}

	[Serializable]
	public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 53884
	{
		// Fields
		[SerializeField]
		private Mode m_Mode; // 0x00
		[SerializeField]
		[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
		private bool m_WrapAround; // 0x04
		[SerializeField]
		private Selectable m_SelectOnUp; // 0x08
		[SerializeField]
		private Selectable m_SelectOnDown; // 0x10
		[SerializeField]
		private Selectable m_SelectOnLeft; // 0x18
		[SerializeField]
		private Selectable m_SelectOnRight; // 0x20
	
		// Properties
		public Mode mode { get => default; set {} } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public bool wrapAround { get => default; set {} } // 0x0000000183D55A00-0x0000000183D55A10 0x0000000183D5DDF0-0x0000000183D5DE00
		public Selectable selectOnUp { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public Selectable selectOnDown { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public Selectable selectOnLeft { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public Selectable selectOnRight { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public static Navigation defaultNavigation { get => default; } // 0x0000000183D89BF0-0x0000000183D89C10 
	
		// Nested types
		[Flags]
		public enum Mode // TypeDefIndex: 53883
		{
			None = 0,
			Horizontal = 1,
			Vertical = 2,
			Automatic = 3,
			Explicit = 4
		}
	
		// Methods
		public bool Equals(Navigation other) => default; // 0x000000018314FF60-0x0000000183150080
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class RawImage : MaskableGraphic // TypeDefIndex: 53885
	{
		// Fields
		[FormerlySerializedAs("m_Tex")]
		[SerializeField]
		private Texture m_Texture; // 0xE8
		[SerializeField]
		private Rect m_UVRect; // 0xF0
	
		// Properties
		public override Texture mainTexture { get => default; } // 0x00000001833F9BE0-0x00000001833F9D30 
		public Texture texture { get => default; set {} } // 0x0000000183D50EA0-0x0000000183D50EB0 0x00000001835ED400-0x00000001835ED4A0
		public Rect uvRect { get => default; set {} } // 0x0000000183D6C080-0x0000000183D6C090 0x0000000189F6F644-0x0000000189F6F6A4
	
		// Constructors
		protected RawImage() {} // 0x0000000182700780-0x00000001827007B0
	
		// Methods
		public override void SetNativeSize() {} // 0x0000000189F6F50C-0x0000000189F6F644
		protected override void OnPopulateMesh(VertexHelper vh) {} // 0x00000001831EA390-0x00000001831EA780
		protected override void OnDidApplyAnimationProperties() {} // 0x00000001830FB950-0x00000001830FB980
	}

	[AddComponentMenu("UI/Rect Mask 2D", 14)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 53886
	{
		// Fields
		[NonSerialized]
		private readonly RectangularVertexClipper m_VertexClipper; // 0x18
		[NonSerialized]
		private RectTransform m_RectTransform; // 0x20
		[NonSerialized]
		private HashSet<MaskableGraphic> m_MaskableTargets; // 0x28
		[NonSerialized]
		private HashSet<IClippable> m_ClipTargets; // 0x30
		[NonSerialized]
		private bool m_ShouldRecalculateClipRects; // 0x38
		[NonSerialized]
		private List<RectMask2D> m_Clippers; // 0x40
		[NonSerialized]
		private Rect m_LastClipRectCanvasSpace; // 0x48
		[NonSerialized]
		private bool m_ForceClip; // 0x58
		[SerializeField]
		private Vector4 m_Padding; // 0x5C
		[SerializeField]
		private Vector2Int m_Softness; // 0x6C
		[SerializeField]
		private Vector4 m_HGSoftness; // 0x74
		[NonSerialized]
		private Canvas m_Canvas; // 0x88
		private Vector3[] m_Corners; // 0x90
	
		// Properties
		public Vector4 padding { get => default; set {} } // 0x0000000183D73B30-0x0000000183D73B40 0x0000000189F6FB38-0x0000000189F6FB48
		public Vector2Int softness { get => default; set {} } // 0x0000000183D55B60-0x0000000183D55B70 0x0000000189F6FB48-0x0000000189F6FB70
		public Vector4 hgSoftness { get => default; set {} } // 0x0000000183D5D5D0-0x0000000183D5D5E0 0x0000000189F6FAF8-0x0000000189F6FB38
		private Canvas Canvas { get => default; } // 0x000000018233F1D0-0x000000018233F3F0 
		public Rect canvasRect { get => default; } // 0x000000018233EBC0-0x000000018233EE90 
		public RectTransform rectTransform { get => default; } // 0x000000018233EE90-0x000000018233EEF0 
		private Rect rootCanvasRect { get => default; } // 0x0000000182343A80-0x0000000182344380 
	
		// Constructors
		protected RectMask2D() {} // 0x0000000183294A20-0x0000000183294BB0
	
		// Methods
		protected override void OnEnable() {} // 0x0000000182516DA0-0x0000000182516DD0
		protected override void OnDisable() {} // 0x0000000182516CA0-0x0000000182516D40
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => default; // 0x0000000182517200-0x00000001825172C0
		public virtual void PerformClipping() {} // 0x00000001823408B0-0x0000000182341600
		public virtual void UpdateClipSoftness() {} // 0x0000000182341600-0x0000000182341AF0
		public void AddClippable(IClippable clippable) {} // 0x000000018308CBA0-0x000000018308CD60
		public void RemoveClippable(IClippable clippable) {} // 0x0000000182EC3E40-0x0000000182EC41E0
		protected override void OnTransformParentChanged() {} // 0x0000000183D5C330-0x0000000183D5C340
		protected override void OnCanvasHierarchyChanged() {} // 0x000000018352D200-0x000000018352D230
	}

	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Scrollbar : Selectable, IBeginDragHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 53891
	{
		// Fields
		[SerializeField]
		private RectTransform m_HandleRect; // 0x180
		[SerializeField]
		private Direction m_Direction; // 0x188
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Value; // 0x18C
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Size; // 0x190
		[Range(0f, 11f)]
		[SerializeField]
		private int m_NumberOfSteps; // 0x194
		[SerializeField]
		[Space(6f)]
		private ScrollEvent m_OnValueChanged; // 0x198
		private RectTransform m_ContainerRect; // 0x1A0
		private Vector2 m_Offset; // 0x1A8
		private DrivenRectTransformTracker m_Tracker; // 0x1B0
		private Coroutine m_PointerDownRepeat; // 0x1B8
		private bool isPointerDownAndNotDragging; // 0x1C0
		private bool m_DelayedUpdateVisuals; // 0x1C1
	
		// Properties
		public RectTransform handleRect { get => default; set {} } // 0x0000000189F71910-0x0000000189F7191C 0x0000000183D58260-0x0000000183D58270
		public Direction direction { get => default; set {} } // 0x00000001828C2090-0x00000001828C2100 0x0000000183D89C40-0x0000000183D89C50
		public float value { get => default; set {} } // 0x0000000183D56AE0-0x0000000183D56AF0 0x0000000184275BC0-0x0000000184275BD4
		public float size { get => default; set {} } // 0x000000018350B670-0x000000018350B680 0x000000018350B670-0x000000018350B680
		public int numberOfSteps { get => default; set {} } // 0x000000018350B670-0x000000018350B680 0x0000000183916020-0x0000000183916060
		public ScrollEvent onValueChanged { get => default; set {} } // 0x000000018361D5F0-0x000000018361D600 0x00000001838DDF60-0x00000001838DDF80
		private float stepSize { get => default; } // 0x0000000183916060-0x0000000183916170 
		private Axis axis { get => default; } // 0x0000000189F71458-0x0000000189F714E0 
		private bool reverseValue { get => default; } // 0x0000000189F716EC-0x0000000189F717B4 
		Transform ICanvasElement.transform { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Nested types
		public enum Direction // TypeDefIndex: 53887
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}
	
		[Serializable]
		public class ScrollEvent : UnityEvent<float> // TypeDefIndex: 53888
		{
			// Constructors
			public ScrollEvent() {} // 0x0000000183D56B50-0x0000000183D56B60
		}
	
		private enum Axis // TypeDefIndex: 53889
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		// Constructors
		protected Scrollbar() {} // 0x0000000189F71C94-0x0000000189F71D04
	
		// Methods
		public virtual void SetValueWithoutNotify(float input) {} // 0x0000000189F71BA0-0x0000000189F71BD0
		public virtual void Rebuild(CanvasUpdate executing) {} // 0x0000000182C6D080-0x0000000182C6D150
		public virtual void LayoutComplete() {} // 0x0000000183B0D650-0x0000000183B0D680
		public virtual void GraphicUpdateComplete() {} // 0x0000000182C6D060-0x0000000182C6D080
		protected override void OnEnable() {} // 0x0000000182C6D180-0x0000000182C6D1A0
		protected override void OnDisable() {} // 0x0000000182C6CED0-0x0000000182C6D060
		protected virtual void Update() {} // 0x0000000189F7191C-0x0000000189F71BA0
		private void UpdateCachedReferences() {} // 0x0000000189F710B8-0x0000000189F71124
		private void Set(float input, bool sendCallback = true /* Metadata: 0x01FD6207 */) {} // 0x0000000189F711F4-0x0000000189F71248
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000189F71248-0x0000000189F71458
		private void UpdateVisuals() {} // 0x0000000189F71040-0x0000000189F710B8
		private void UpdateDrag(PointerEventData eventData) {} // 0x0000000189F70FB0-0x0000000189F71040
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) {} // 0x0000000189F717B4-0x0000000189F717D4
		private bool MayDrag(PointerEventData eventData) => default; // 0x0000000189F714FC-0x0000000189F716EC
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189F71158-0x0000000189F7118C
		public virtual void OnDrag(PointerEventData eventData) {} // 0x0000000189F7118C-0x0000000189F711C0
		public override void OnPointerDown(PointerEventData eventData) {} // 0x0000000189F711C0-0x0000000189F711F4
		protected IEnumerator ClickRepeat(PointerEventData eventData) => default; // 0x0000000189F71124-0x0000000189F71158
		[IteratorStateMachine(typeof(_ClickRepeat_d__58))]
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) => default; // 0x0000000189F714E0-0x0000000189F714FC
		public override void OnPointerUp(PointerEventData eventData) {} // 0x0000000189F717D4-0x0000000189F71910
		public override void OnMove(AxisEventData eventData) {} // 0x0000000184273A88-0x0000000184273A90
		public override Selectable FindSelectableOnLeft() => default; // 0x0000000182848F50-0x0000000182848F90
		public override Selectable FindSelectableOnRight() => default; // 0x00000001810410F0-0x0000000181041100
		public override Selectable FindSelectableOnUp() => default; // 0x000000018350B670-0x000000018350B680
		public override Selectable FindSelectableOnDown() => default; // 0x0000000189F75CA0-0x0000000189F75EC8
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x0000000181041090-0x00000001810410A0
		public void SetDirection(Direction direction, bool includeRectLayouts) {} // 0x0000000189F75EC8-0x0000000189F75F14
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[SelectionBase]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup // TypeDefIndex: 53895
	{
		// Fields
		[SerializeField]
		private RectTransform m_Content; // 0x18
		[SerializeField]
		private bool m_Horizontal; // 0x20
		[SerializeField]
		private bool m_Vertical; // 0x21
		[SerializeField]
		protected GameObject m_scrollEnableNode; // 0x28
		[SerializeField]
		private MovementType m_MovementType; // 0x30
		[SerializeField]
		private float m_Elasticity; // 0x34
		[SerializeField]
		private bool m_Inertia; // 0x38
		[SerializeField]
		private float m_DecelerationRate; // 0x3C
		[SerializeField]
		private float m_ScrollSensitivity; // 0x40
		[SerializeField]
		private RectTransform m_Viewport; // 0x48
		[SerializeField]
		private Scrollbar m_HorizontalScrollbar; // 0x50
		[SerializeField]
		private Scrollbar m_VerticalScrollbar; // 0x58
		[SerializeField]
		private ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x60
		[SerializeField]
		private ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x64
		[SerializeField]
		private float m_HorizontalScrollbarSpacing; // 0x68
		[SerializeField]
		private float m_VerticalScrollbarSpacing; // 0x6C
		[SerializeField]
		private ScrollRectEvent m_OnValueChanged; // 0x70
		public bool disableScroll; // 0x78
		[NonSerialized]
		public ScrollRectEvent OnScrollStart; // 0x80
		[NonSerialized]
		public ScrollRectEvent OnScrollEnd; // 0x88
		private Vector2 m_PointerStartLocalCursor; // 0x90
		protected Vector2 m_ContentStartPosition; // 0x98
		private RectTransform m_ViewRect; // 0xA0
		protected Bounds m_ContentBounds; // 0xA8
		private Bounds m_ViewBounds; // 0xC0
		private Vector2 m_Velocity; // 0xD8
		protected bool m_Dragging; // 0xE0
		protected bool m_onScrollEndCbFlag; // 0xE1
		protected bool m_Scrolling; // 0xE2
		private Vector2 m_PrevPosition; // 0xE4
		private Bounds m_PrevContentBounds; // 0xEC
		private Bounds m_PrevViewBounds; // 0x104
		[NonSerialized]
		private bool m_HasRebuiltLayout; // 0x11C
		private bool m_HSliderExpand; // 0x11D
		private bool m_VSliderExpand; // 0x11E
		private float m_HSliderHeight; // 0x120
		private float m_VSliderWidth; // 0x124
		[NonSerialized]
		private RectTransform m_Rect; // 0x128
		private RectTransform m_HorizontalScrollbarRect; // 0x130
		private RectTransform m_VerticalScrollbarRect; // 0x138
		private DrivenRectTransformTracker m_Tracker; // 0x140
		private readonly Vector3[] m_Corners; // 0x148
	
		// Properties
		public RectTransform content { get => default; set {} } // 0x00000001822C3A90-0x00000001822C3AA0 0x0000000183D4EF90-0x0000000183D4EFA0
		public bool horizontal { get => default; set {} } // 0x0000000183D4EFC0-0x0000000183D4EFD0 0x0000000183D4F070-0x0000000183D4F080
		public bool vertical { get => default; set {} } // 0x0000000183D4F080-0x0000000183D4F090 0x0000000183D4ED20-0x0000000183D4ED30
		public MovementType movementType { get => default; set {} } // 0x0000000183D4EE10-0x0000000183D4EE20 0x0000000183D56CA0-0x0000000183D56CB0
		public float elasticity { get => default; set {} } // 0x0000000183D56CB0-0x0000000183D56CC0 0x0000000183D4F190-0x0000000183D4F1A0
		public bool inertia { get => default; set {} } // 0x0000000183D4E280-0x0000000183D4E290 0x0000000183D4EC60-0x0000000183D4EC70
		public float decelerationRate { get => default; set {} } // 0x0000000183D4ECE0-0x0000000183D4ECF0 0x0000000183D4EC70-0x0000000183D4EC80
		public float scrollSensitivity { get => default; set {} } // 0x0000000183D4ECF0-0x0000000183D4ED00 0x0000000183D4EA70-0x0000000183D4EA80
		public RectTransform viewport { get => default; set {} } // 0x0000000189F70F8C-0x0000000189F70FB0 0x0000000183D4EAF0-0x0000000183D4EB00
		public Scrollbar horizontalScrollbar { get => default; set {} } // 0x0000000189F70C28-0x0000000189F70DB0 0x0000000183D4EAA0-0x0000000183D4EAB0
		public Scrollbar verticalScrollbar { get => default; set {} } // 0x0000000189F70E04-0x0000000189F70F8C 0x0000000183D4F050-0x0000000183D4F060
		public ScrollbarVisibility horizontalScrollbarVisibility { get => default; set {} } // 0x0000000189F70C1C-0x0000000189F70C28 0x0000000183D50B30-0x0000000183D50B40
		public ScrollbarVisibility verticalScrollbarVisibility { get => default; set {} } // 0x0000000189F70DF8-0x0000000189F70E04 0x0000000183D56A40-0x0000000183D56A50
		public float horizontalScrollbarSpacing { get => default; set {} } // 0x0000000189F70C10-0x0000000189F70C1C 0x0000000183D56C50-0x0000000183D56C60
		public float verticalScrollbarSpacing { get => default; set {} } // 0x0000000189F70DEC-0x0000000189F70DF8 0x0000000183D4EB30-0x0000000183D4EB40
		public ScrollRectEvent onValueChanged { get => default; set {} } // 0x000000018519C3C8-0x000000018519C3D8 0x000000018233DFC0-0x000000018233E1D0
		protected RectTransform viewRect { get => default; } // 0x0000000183D89C10-0x0000000183D89C30 
		public Vector2 velocity { get => default; set {} } // 0x0000000183D89C30-0x0000000183D89C40 0x00000001834CFD70-0x00000001834CFE10
		private RectTransform rectTransform { get => default; } // 0x000000018284A4A0-0x000000018284A5F0 
		public Vector2 normalizedPosition { get => default; set {} } // 0x0000000189F70DB0-0x0000000189F70DEC 0x00000001828C2650-0x00000001828C27F0
		public float horizontalNormalizedPosition { get => default; set {} } // 0x0000000184274DE0-0x0000000184274DEC 0x00000001828C27F0-0x00000001828C29B0
		public float verticalNormalizedPosition { get => default; set {} } // 0x0000000184274DEC-0x0000000184274DFC 0x0000000184274DE0-0x0000000184274DEC
		public bool hScrollingNeeded { get => default; } // 0x000000018233D2D0-0x000000018233D380 
		public bool vScrollingNeeded { get => default; } // 0x000000018350B670-0x000000018350B680 
		public virtual float minWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float preferredWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float flexibleWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float minHeight { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float preferredHeight { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float flexibleHeight { get => default; } // 0x0000000183D5CD90-0x0000000183D5CDA0 
		public virtual int layoutPriority { get => default; } // 0x000000018337CD50-0x000000018337CE20 
		Transform ICanvasElement.transform { get => default; } // 0x000000018284A5F0-0x000000018284A630 
	
		// Nested types
		public enum MovementType // TypeDefIndex: 53892
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		public enum ScrollbarVisibility // TypeDefIndex: 53893
		{
			Permanent = 0,
			AutoHide = 1,
			AutoHideAndExpandViewport = 2
		}
	
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 53894
		{
			// Constructors
			public ScrollRectEvent() {} // 0x0000000181041090-0x00000001810410A0
		}
	
		// Constructors
		protected ScrollRect() {} // 0x000000018337CC00-0x000000018337CC60
	
		// Methods
		public virtual void Rebuild(CanvasUpdate executing) {} // 0x000000018350B670-0x000000018350B680
		public virtual void LayoutComplete() {} // 0x000000018350B670-0x000000018350B680
		public virtual void GraphicUpdateComplete() {} // 0x000000018337CE20-0x000000018337D1C0
		private void UpdateCachedData() {} // 0x00000001834CFB80-0x00000001834CFCF0
		protected override void OnEnable() {} // 0x00000001834CF820-0x00000001834CF9E0
		protected override void OnDisable() {} // 0x000000018363A500-0x000000018363A570
		public override bool IsActive() => default; // 0x000000018233D1C0-0x000000018233D230
		public void EnsureLayoutHasRebuilt() {} // 0x0000000189F70BE4-0x0000000189F70BF0
		public virtual void StopMovement() {} // 0x00000001828C1440-0x00000001828C15F0
		public virtual void OnScroll(PointerEventData data) {} // 0x0000000189F70BF0-0x0000000189F70C10
		protected virtual void _CustomSetPosOnScroll(Vector2 position) {} // 0x0000000183B414F0-0x0000000183B41520
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x0000000189F706BC-0x0000000189F707E8
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189F70AD8-0x0000000189F70AFC
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x0000000189F707E8-0x0000000189F70AD8
		public virtual void OnDrag(PointerEventData eventData) {} // 0x00000001834E5060-0x00000001834E5160
		protected virtual void SetContentAnchoredPosition(Vector2 position) {} // 0x000000018233C2A0-0x000000018233CBC0
		protected virtual void LateUpdate() {} // 0x000000018337CC60-0x000000018337CD50
		protected void UpdatePrevData() {} // 0x00000001828C2220-0x00000001828C2400
		protected virtual void UpdateScrollbars(Vector2 offset) {} // 0x00000001828C2610-0x00000001828C2650
		protected virtual void SetHorizontalNormalizedPosition(float value) {} // 0x00000001834556D0-0x00000001834556E0
		protected virtual void SetVerticalNormalizedPosition(float value) {} // 0x00000001834556E0-0x0000000183455990
		protected virtual void SetNormalizedPosition(float value, int axis) {} // 0x0000000189F70AFC-0x0000000189F70B44
		private static float RubberDelta(float overStretching, float viewSize) => default; // 0x00000001834CFCF0-0x00000001834CFD00
		protected override void OnRectTransformDimensionsChange() {} // 0x000000018233D230-0x000000018233D2D0
		public virtual void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public virtual void CalculateLayoutInputVertical() {} // 0x0000000183D751A0-0x0000000183D751B0
		public virtual void SetLayoutHorizontal() {} // 0x00000001834DE930-0x00000001834DEA90
		public virtual void SetLayoutVertical() {} // 0x000000018233D010-0x000000018233D070
		private void UpdateScrollbarVisibility() {} // 0x000000018233D070-0x000000018233D1C0
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) {} // 0x00000001834DEA90-0x00000001834DEC80
		private void UpdateScrollbarLayout() {} // 0x00000001830C1010-0x00000001830C10F0
		protected virtual void UpdateScrollEnableNode() {} // 0x000000018233D790-0x000000018233DFC0
		protected void UpdateBounds() {} // 0x000000018233D380-0x000000018233D4C0
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) {} // 0x000000018233D580-0x000000018233D790
		private Bounds GetBounds() => default; // 0x000000018238C980-0x000000018238CC80
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) => default; // 0x000000018233CD20-0x000000018233CD70
		protected Vector2 CalculateOffset(Vector2 delta) => default; // 0x000000018233CD70-0x000000018233D010
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta) => default; // 0x00000001834CFD00-0x00000001834CFD70
		protected void SetDirty() {} // 0x0000000189F70B44-0x0000000189F70BE4
		protected void SetDirtyCaching() {} // 0x0000000184273A88-0x0000000184273A90
	}

	[AddComponentMenu("UI/Selectable", 35)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[SelectionBase]
	public class Selectable : UIBehaviour, IMoveHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 53898
	{
		// Fields
		protected static Selectable[] s_Selectables; // 0x00
		protected static int s_SelectableCount; // 0x08
		private bool m_EnableCalled; // 0x18
		[FormerlySerializedAs("navigation")]
		[SerializeField]
		private Navigation m_Navigation; // 0x20
		[FormerlySerializedAs("transition")]
		[SerializeField]
		private Transition m_Transition; // 0x48
		[FormerlySerializedAs("colors")]
		[SerializeField]
		private ColorBlock m_Colors; // 0x4C
		[FormerlySerializedAs("spriteState")]
		[SerializeField]
		private SpriteState m_SpriteState; // 0xA8
		[FormerlySerializedAs("animationTriggers")]
		[SerializeField]
		private AnimationTriggers m_AnimationTriggers; // 0xC8
		[SerializeField]
		[Tooltip("Can the Selectable be interacted with?")]
		private bool m_Interactable; // 0xD0
		[FormerlySerializedAs("m_HighlightGraphic")]
		[FormerlySerializedAs("highlightGraphic")]
		[SerializeField]
		private Graphic m_TargetGraphic; // 0xD8
		[SerializeField]
		[Tooltip("\u60AC\u6D6E\u65F6\u662F\u5426\u901A\u77E5\u865A\u62DF\u9F20\u6807")]
		protected bool m_NotifyHover; // 0xE0
		[SerializeField]
		[Tooltip("\u60AC\u6D6E\u65F6\u542F\u7528\u7684\u8282\u70B9\uFF0C\u4EC5\u5728notifyHover\u52FE\u9009\u65F6\u751F\u6548")]
		protected GameObject m_HoverEnableNode; // 0xE8
		[SerializeField]
		[Tooltip("\u60AC\u6D6E\u65F6\u97F3\u6548id")]
		protected string m_HoverAudioKey; // 0xF0
		protected bool _enableUnityNavi; // 0xF8
		private bool m_GroupsAllowInteraction; // 0xF9
		protected int m_CurrentIndex; // 0xFC
		private readonly List<CanvasGroup> m_CanvasGroupCache; // 0x108
		public static UnityEvent<Selectable, bool> onAnyHoverChange; // 0x10
		public bool enableControllerNavi; // 0x118
		public Transform overrideNaviHintRectTransform; // 0x120
		public float overrideNaviHintRectScale; // 0x128
		public bool changeNaviHintParent; // 0x12C
		public bool hideNaviHint; // 0x12D
		public bool needNaviConfirmKeyHint; // 0x12E
		public bool useExplicitNaviSelect; // 0x12F
		public bool banExplicitOnLeft; // 0x130
		public bool banExplicitOnRight; // 0x131
		public bool banExplicitOnUp; // 0x132
		public bool banExplicitOnDown; // 0x133
		[SerializeField]
		private Selectable m_ExplicitSelectOnLeft; // 0x138
		[SerializeField]
		private Selectable m_ExplicitSelectOnRight; // 0x140
		[SerializeField]
		private Selectable m_ExplicitSelectOnUp; // 0x148
		[SerializeField]
		private Selectable m_ExplicitSelectOnDown; // 0x150
		public Action<bool, bool, bool> onIsNaviTargetChanged; // 0x160
		public SelectableNaviGroup naviGroup; // 0x170
		private bool m_naviInited; // 0x178
	
		// Properties
		public static Selectable[] allSelectablesArray { get => default; } // 0x0000000189F72F38-0x0000000189F72FBC 
		public static int allSelectableCount { get => default; } // 0x0000000189F72EE8-0x0000000189F72F38 
		[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", false)]
		public static List<Selectable> allSelectables { get => default; } // 0x0000000189F72FBC-0x0000000189F7304C 
		public string hoverAudioKey { get => default; } // 0x0000000183D51950-0x0000000183D51960 
		public Navigation navigation { get => default; set {} } // 0x0000000183D581B0-0x0000000183D581D0 0x0000000182C70710-0x0000000182C70790
		public Transition transition { get => default; set {} } // 0x0000000183D4EC50-0x0000000183D4EC60 0x0000000189F73250-0x0000000189F732A8
		public ColorBlock colors { get => default; set {} } // 0x0000000183D89C50-0x0000000183D89C90 0x0000000189F730E8-0x0000000189F73184
		public SpriteState spriteState { get => default; set {} } // 0x0000000183D89C90-0x0000000183D89CB0 0x0000000189F73184-0x0000000189F731F4
		public AnimationTriggers animationTriggers { get => default; set {} } // 0x0000000183D4E7C0-0x0000000183D4E7D0 0x0000000189F7308C-0x0000000189F730E8
		public Graphic targetGraphic { get => default; set {} } // 0x0000000183D4E7B0-0x0000000183D4E7C0 0x0000000189F731F4-0x0000000189F73250
		public bool interactable { get => default; set {} } // 0x0000000183D58E40-0x0000000183D58E50 0x0000000182C3BC20-0x0000000182C3BC90
		private bool isPointerInside { get; set; } // 0x0000000183D56750-0x0000000183D56760 0x0000000183D89CC0-0x0000000183D89CD0
		private bool isPointerDown { get; set; } // 0x0000000183D75780-0x0000000183D75790 0x0000000183D89CB0-0x0000000183D89CC0
		private bool hasSelection { get; set; } // 0x0000000183D554B0-0x0000000183D554C0 0x0000000183D554E0-0x0000000183D554F0
		public Image image { get => default; set {} } // 0x0000000189F7304C-0x0000000189F7308C 0x0000000185142FC4-0x0000000185142FD8
		public Animator animator { get => default; } // 0x00000001822B3BD0-0x00000001822B3C10 
		protected SelectionState currentSelectionState { get => default; } // 0x00000001822B2B40-0x00000001822B2B90 
		public UnityEvent<bool> onHoverChange { get; } // 0x0000000183D56CF0-0x0000000183D56D00 
		public bool isNaviTarget { get; protected set; } // 0x0000000183D5AC60-0x0000000183D5AC70 0x0000000183D5AC70-0x0000000183D5AC80
		public bool isNavigationSilent { get; protected set; } // 0x0000000183D5BC50-0x0000000183D5BC60 0x0000000183D5BCA0-0x0000000183D5BCB0
	
		// Nested types
		public enum Transition // TypeDefIndex: 53896
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 3
		}
	
		protected enum SelectionState // TypeDefIndex: 53897
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Selected = 3,
			Disabled = 4
		}
	
		// Constructors
		protected Selectable() {} // 0x00000001828488B0-0x0000000182848B40
		static Selectable() {} // 0x0000000183C84DD0-0x0000000183C84EC0
	
		// Methods
		public static int AllSelectablesNoAlloc(Selectable[] selectables) => default; // 0x0000000189F71D24-0x0000000189F71DCC
		protected override void Awake() {} // 0x0000000182C705D0-0x0000000182C70710
		protected void OnCanvasGroupChanged() {} // 0x000000018251CA00-0x000000018251CD70
		public virtual bool IsInteractable() => default; // 0x00000001822B2B90-0x00000001822B2BB0
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000189F72930-0x0000000189F72938
		protected override void OnEnable() {} // 0x00000001822B1BA0-0x00000001822B1F30
		protected override void OnTransformParentChanged() {} // 0x00000001839DD000-0x00000001839DD010
		private void OnSetProperty() {} // 0x00000001836E62D0-0x00000001836E6300
		protected override void OnDisable() {} // 0x00000001822B2BB0-0x00000001822B2D90
		private void OnApplicationFocus(bool hasFocus) {} // 0x00000001822B3C50-0x00000001822B3C80
		protected virtual void InstantClearState() {} // 0x00000001822B30D0-0x00000001822B3160
		protected virtual void DoStateTransition(SelectionState state, bool instant) {} // 0x00000001822B2E50-0x00000001822B30D0
		public Selectable FindSelectable(Vector3 dir) => default; // 0x0000000189F7211C-0x0000000189F725DC
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) => default; // 0x0000000189F7267C-0x0000000189F72850
		private void Navigate(AxisEventData eventData, Selectable sel) {} // 0x0000000189F728A0-0x0000000189F72930
		public virtual Selectable FindSelectableOnLeft() => default; // 0x0000000189F71F0C-0x0000000189F71FBC
		public virtual Selectable FindSelectableOnRight() => default; // 0x0000000189F71FBC-0x0000000189F7206C
		public virtual Selectable FindSelectableOnUp() => default; // 0x0000000189F7206C-0x0000000189F7211C
		public virtual Selectable FindSelectableOnDown() => default; // 0x0000000189F71E5C-0x0000000189F71F0C
		public virtual void OnMove(AxisEventData eventData) {} // 0x0000000189F72938-0x0000000189F729A8
		private void StartColorTween(UnityEngine.Color targetColor, bool instant) {} // 0x00000001822B31B0-0x00000001822B3460
		private void DoSpriteSwap(Sprite newSprite) {} // 0x0000000189F71DCC-0x0000000189F71E5C
		private void TriggerAnimation(string triggername) {} // 0x00000001822B39D0-0x00000001822B3BD0
		protected bool IsHighlighted() => default; // 0x0000000189F72850-0x0000000189F728A0
		protected bool IsPressed() => default; // 0x00000001822B3C80-0x00000001822B3CC0
		private void EvaluateAndTransitionToSelectionState() {} // 0x00000001822B4090-0x00000001822B4110
		public virtual void OnPointerDown(PointerEventData eventData) {} // 0x000000018284C830-0x000000018284C860
		public virtual void OnPointerUp(PointerEventData eventData) {} // 0x000000018284C800-0x000000018284C830
		public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x00000001822B4B20-0x00000001822B4C20
		public virtual void OnPointerExit(PointerEventData eventData) {} // 0x00000001822B4C20-0x00000001822B4C50
		public virtual void OnSelect(BaseEventData eventData) {} // 0x0000000183CDD160-0x0000000183CDD170
		public virtual void OnDeselect(BaseEventData eventData) {} // 0x0000000183CBABA0-0x0000000183CBABB0
		public virtual void Select() {} // 0x0000000189F72A14-0x0000000189F72AE0
		protected virtual void _RefreshHoverEnableNode(bool active) {} // 0x00000001824B2200-0x00000001824B2330
		public virtual void OnInteractableChanged() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void _NotifyIsHover(bool isHover) {} // 0x0000000182C6F620-0x0000000182C6F700
		protected override void OnDestroy() {} // 0x0000000182C71AF0-0x0000000182C71B30
		public virtual bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId) {
			clickHintTextId = default;
			longPressHintTextId = default;
			return default;
		} // 0x0000000189F72654-0x0000000189F7267C
		public void SetAsNaviTarget(bool isTarget, bool silentMode, bool isGroupChanged) {} // 0x0000000189F72AE0-0x0000000189F72C28
		public virtual void OnNaviTargetEnabledAgain() {} // 0x0000000189F729A8-0x0000000189F72A14
		protected virtual void _OnSetAsNaviTarget(bool isTarget, bool silentMode) {} // 0x000000018350B670-0x000000018350B680
		public void TryFindNaviGroup() {} // 0x0000000182C70790-0x0000000182C707E0
		public SelectableNaviGroup GetLayerGroup() => default; // 0x0000000189F725DC-0x0000000189F72654
		public bool TryFindExplicitNaviTarget(NaviDirection dir, out Selectable target) {
			target = default;
			return default;
		} // 0x0000000189F72C88-0x0000000189F72E10
		public bool banExplicitNavi(NaviDirection dir) => default; // 0x0000000189F72E10-0x0000000189F72EE8
		private void _TryRegisterOnNaviGroup() {} // 0x00000001822B2D90-0x00000001822B2E50
		private void _TryUnRegisterOnNaviGroup() {} // 0x0000000182C71B30-0x0000000182C71C50
		public void SetExplicitSelectOnLeft(Selectable selectable) {} // 0x0000000184275CE0-0x0000000184275CF4
		public void SetExplicitSelectOnRight(Selectable selectable) {} // 0x00000001858B3FD8-0x00000001858B3FEC
		public void SetExplicitSelectOnUp(Selectable selectable) {} // 0x00000001858B3DA8-0x00000001858B3DBC
		public void SetExplicitSelectOnDown(Selectable selectable) {} // 0x00000001858B3DD0-0x00000001858B3DE4
		public void SetExplicitSelect(Selectable left, Selectable right, Selectable up, Selectable down) {} // 0x0000000189F72C28-0x0000000189F72C88
	}

	public enum NaviDirection // TypeDefIndex: 53899
	{
		None = 0,
		Up = 1,
		Down = 2,
		Left = 3,
		Right = 4
	}

	public enum NaviStrategy // TypeDefIndex: 53900
	{
		Normal = 0,
		Strict = 1,
		NotInternalFirst = 2,
		VerticalOnlyWithInternalWrap = 3,
		HorizontalOnlyWithInternalWrap = 4
	}

	public enum NavigationBindingType // TypeDefIndex: 53901
	{
		InValid = -1,
		AllDirections = 0,
		HorizontalOnly = 1,
		VerticalOnly = 2,
		ArrowAllDirections = 3,
		ArrowHorizontalOnly = 4,
		ArrowVerticalOnly = 5,
		RightJsAllDirections = 6,
		RightJsHorizontalOnly = 7,
		RightJsVerticalOnly = 8,
		RightJsOnlyAllDirections = 9,
		RightJsOnlyHorizontalOnly = 10,
		RightJsOnlyVerticalOnly = 11
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	public abstract class SelectableNaviGroup : MonoBehaviour // TypeDefIndex: 53902
	{
		// Fields
		public bool isIsolate; // 0x18
		public bool isLayer; // 0x19
		public bool removeLayerOnDisable; // 0x1A
		public SelectableNaviGroup parentNaviGroup; // 0x20
		[FormerlySerializedAs("naviStrategy")]
		public NaviStrategy internalNaviStrategy; // 0x28
		public NavigationBindingType navigationBindingType; // 0x2C
		public bool enablePartner; // 0x30
		[SerializeReference]
		public List<SelectableNaviGroup> naviPartnerOnUp; // 0x38
		[SerializeReference]
		public List<SelectableNaviGroup> naviPartnerOnDown; // 0x40
		[SerializeReference]
		public List<SelectableNaviGroup> naviPartnerOnLeft; // 0x48
		[SerializeReference]
		public List<SelectableNaviGroup> naviPartnerOnRight; // 0x50
		protected bool m_inited; // 0x58
		protected Selectable m_layerSelectedTarget; // 0x60
		public HashSet<Selectable> targets; // 0x68
		public HashSet<SelectableNaviGroup> subGroups; // 0x70
		[NonSerialized]
		public UnityEvent<Selectable> onSetLayerSelectedTarget; // 0x78
		[NonSerialized]
		public UnityEvent<bool> onIsTopLayerChanged; // 0x80
		[NonSerialized]
		public UnityEvent<NaviDirection> onDefaultNaviFailed; // 0x88
		[NonSerialized]
		public UnityEvent onRemoveFromLayerStack; // 0x90
		protected bool m_isTopLayer; // 0x98
	
		// Properties
		public Selectable LayerSelectedTarget { get; } // 0x0000000182C707E0-0x0000000182C70800 
		public bool IsTopLayer { get; set; } // 0x0000000183D58690-0x0000000183D586A0 0x0000000189F71D0C-0x0000000189F71D24
	
		// Constructors
		protected SelectableNaviGroup() {} // 0x000000018283A100-0x000000018283A400
	
		// Methods
		protected virtual void Reset() {} // 0x0000000189F71D04-0x0000000189F71D0C
		protected virtual void OnEnable() {} // 0x0000000182C6F9C0-0x0000000182C6F9F0
		protected virtual void OnDisable() {} // 0x0000000184272FC0-0x0000000184272FD0
		protected virtual void OnDestroy() {} // 0x000000018304D760-0x000000018304D850
		protected virtual void _Init() {} // 0x0000000182C6FB50-0x0000000182C6FC40
		public void TryFindParentNaviGroup() {} // 0x0000000182C70280-0x0000000182C70370
		public SelectableNaviGroup GetLayerGroup() => default; // 0x0000000182C700D0-0x0000000182C70150
		public void SetLayerSelectedTarget(Selectable value, bool silentMode) {} // 0x0000000182C6FF20-0x0000000182C6FFA0
		public void OnRemoveFromLayerStack() {} // 0x0000000182C70250-0x0000000182C70280
		protected virtual void _OnIsTopLayerChanged() {} // 0x0000000182C6F090-0x0000000182C6F0F0
		protected virtual void _OnSelectableNaviGroupInited() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void _BeforeSelectableNaviGroupDestroy() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void _OnSelectableNaviGroupDisabled() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void _OnSetLayerSelectedTarget(Selectable value) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void _OnRemoveFromLayerStack() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class SetPropertyUtility // TypeDefIndex: 53903
	{
		// Methods
		public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue) => default; // 0x00000001825C1E90-0x00000001825C1ED0
		public static bool SetStruct<T>(ref ref T currentValue, T newValue)
			where T : struct => default;
		public static bool SetClass<T>(ref ref T currentValue, T newValue)
			where T : class => default;
	}

	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Slider : Selectable, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 53907
	{
		// Fields
		[SerializeField]
		private RectTransform m_FillRect; // 0x180
		[SerializeField]
		private RectTransform m_HandleRect; // 0x188
		[SerializeField]
		[Space]
		private Direction m_Direction; // 0x190
		[SerializeField]
		private float m_MinValue; // 0x194
		[SerializeField]
		private float m_MaxValue; // 0x198
		[SerializeField]
		private bool m_WholeNumbers; // 0x19C
		[SerializeField]
		protected float m_Value; // 0x1A0
		[SerializeField]
		[Space]
		private SliderEvent m_OnValueChanged; // 0x1A8
		private Image m_FillImage; // 0x1B0
		private Transform m_FillTransform; // 0x1B8
		private RectTransform m_FillContainerRect; // 0x1C0
		private Transform m_HandleTransform; // 0x1C8
		private RectTransform m_HandleContainerRect; // 0x1D0
		private Vector2 m_Offset; // 0x1D8
		private DrivenRectTransformTracker m_Tracker; // 0x1E0
		private bool m_DelayedUpdateVisuals; // 0x1E1
	
		// Properties
		public RectTransform fillRect { get => default; set {} } // 0x0000000189F73DDC-0x0000000189F73E44 0x0000000183D56AF0-0x0000000183D56B00
		public RectTransform handleRect { get => default; set {} } // 0x0000000189F73E44-0x0000000189F73EAC 0x0000000183D760B0-0x0000000183D760C0
		public Direction direction { get => default; set {} } // 0x0000000189F73D80-0x0000000189F73DDC 0x0000000183D58B50-0x0000000183D58B60
		public float minValue { get => default; set {} } // 0x0000000183B72620-0x0000000183B726A0 0x0000000183D583C0-0x0000000183D583D0
		public float maxValue { get => default; set {} } // 0x0000000183B727B0-0x0000000183B72830 0x0000000183D5B0C0-0x0000000183D5B0D0
		public bool wholeNumbers { get => default; set {} } // 0x0000000189F73EDC-0x0000000189F73F50 0x00000001827E8BB0-0x00000001827E8BE0
		public virtual float value { get => default; set {} } // 0x00000001842725E4-0x00000001842725F0 0x0000000189F73B18-0x0000000189F73B24
		public float normalizedValue { get => default; set {} } // 0x0000000189F73EAC-0x0000000189F73EDC 0x0000000183D57170-0x0000000183D57180
		public SliderEvent onValueChanged { get => default; set {} } // 0x0000000184275BE8-0x0000000184275BFC 0x0000000189F73D54-0x0000000189F73D80
		private float stepSize { get => default; } // 0x0000000182848250-0x0000000182848300 
		private Axis axis { get => default; } // 0x00000001827E7CA0-0x00000001827E7CC0 
		private bool reverseValue { get => default; } // 0x00000001827E8810-0x00000001827E8B40 
		Transform ICanvasElement.transform { get => default; } // 0x00000001828484B0-0x00000001828484F0 
	
		// Nested types
		public enum Direction // TypeDefIndex: 53904
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}
	
		[Serializable]
		public class SliderEvent : UnityEvent<float> // TypeDefIndex: 53905
		{
			// Constructors
			public SliderEvent() {} // 0x0000000183D56B50-0x0000000183D56B60
		}
	
		private enum Axis // TypeDefIndex: 53906
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		// Constructors
		protected Slider() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void SetValueWithoutNotify(float input) {} // 0x00000001827E8B40-0x00000001827E8BB0
		public virtual void Rebuild(CanvasUpdate executing) {} // 0x000000018350B670-0x000000018350B680
		public virtual void LayoutComplete() {} // 0x000000018350B670-0x000000018350B680
		public virtual void GraphicUpdateComplete() {} // 0x0000000182529580-0x00000001825295C0
		protected override void OnEnable() {} // 0x000000018361D5F0-0x000000018361D600
		protected override void OnDisable() {} // 0x0000000182394050-0x0000000182394070
		protected virtual void Update() {} // 0x0000000189F733AC-0x0000000189F735C8
		protected override void OnDidApplyAnimationProperties() {} // 0x00000001825295C0-0x0000000182529940
		private void UpdateCachedReferences() {} // 0x0000000189F732A8-0x0000000189F732DC
		protected virtual float ClampValue(float input) => default; // 0x000000018272C470-0x000000018272C570
		protected virtual void Set(float input, bool sendCallback = true /* Metadata: 0x01FD6234 */) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnValueChanged() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnClickSliderBar() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnClickSliderHandle() {} // 0x00000001836ABA40-0x00000001836ABC10
		protected override void OnRectTransformDimensionsChange() {} // 0x00000001827E87F0-0x00000001827E8810
		private void UpdateVisuals() {} // 0x0000000189F73B24-0x0000000189F73D54
		private void UpdateDrag(PointerEventData eventData, Camera cam) {} // 0x0000000183D65EB0-0x0000000183D65EC0
		protected virtual float CustomProcessNormalizedValue(float val) => default; // 0x0000000189F711F4-0x0000000189F71248
		private bool MayDrag(PointerEventData eventData) => default; // 0x0000000189F73800-0x0000000189F739DC
		public override void OnPointerDown(PointerEventData eventData) {} // 0x0000000189F735C8-0x0000000189F73618
		public virtual void OnDrag(PointerEventData eventData) {} // 0x0000000189F73618-0x0000000189F73800
		public override void OnMove(AxisEventData eventData) {} // 0x0000000189F73310-0x0000000189F73344
		public override Selectable FindSelectableOnLeft() => default; // 0x0000000189F73344-0x0000000189F73378
		public override Selectable FindSelectableOnRight() => default; // 0x0000000189F73378-0x0000000189F733AC
		public override Selectable FindSelectableOnUp() => default; // 0x0000000189F732DC-0x0000000189F73310
		public override Selectable FindSelectableOnDown() => default; // 0x0000000189F714E0-0x0000000189F714FC
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x0000000189F739DC-0x0000000189F73B18
		public void SetDirection(Direction direction, bool includeRectLayouts) {} // 0x0000000184273A88-0x0000000184273A90
	}

	[Serializable]
	public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 53908
	{
		// Fields
		[SerializeField]
		private Sprite m_HighlightedSprite; // 0x00
		[SerializeField]
		private Sprite m_PressedSprite; // 0x08
		[FormerlySerializedAs("m_HighlightedSprite")]
		[SerializeField]
		private Sprite m_SelectedSprite; // 0x10
		[SerializeField]
		private Sprite m_DisabledSprite; // 0x18
	
		// Properties
		public Sprite highlightedSprite { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Sprite pressedSprite { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public Sprite selectedSprite { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public Sprite disabledSprite { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Methods
		public bool Equals(SpriteState other) => default; // 0x0000000189F73F50-0x0000000189F7401C
	}

	public static class StencilMaterial // TypeDefIndex: 53910
	{
		// Fields
		private static List<MatEntry> m_List; // 0x00
		private static bool s_EnableStencilMaterialWarning; // 0x08
	
		// Nested types
		private class MatEntry // TypeDefIndex: 53909
		{
			// Fields
			public Material baseMat; // 0x10
			public Material customMat; // 0x18
			public int count; // 0x20
			public int stencilId; // 0x24
			public StencilOp operation; // 0x28
			public CompareFunction compareFunction; // 0x2C
			public int readMask; // 0x30
			public int writeMask; // 0x34
			public bool useAlphaClip; // 0x38
			public ColorWriteMask colorMask; // 0x3C
	
			// Constructors
			public MatEntry() {} // 0x0000000181002730-0x0000000181002740
		}
	
		// Constructors
		static StencilMaterial() {} // 0x0000000183D89BE0-0x0000000183D89BF0
	
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Material.Add instead.", true)]
		public static Material Add(Material baseMat, int stencilID) => default; // 0x0000000182516830-0x00000001825168D0
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) => default; // 0x0000000189F74130-0x0000000189F741B8
		private static void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context) {} // 0x00000001828006E0-0x0000000182800F20
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) => default; // 0x000000018239F570-0x000000018239F800
		public static void Remove(Material customMat) {} // 0x0000000189F7401C-0x0000000189F74130
		public static void ClearAll() {} // 0x0000000183CBCE10-0x0000000183CBCEB0
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 53911
	{
		// Fields
		[SerializeField]
		private FontData m_FontData; // 0xE8
		[SerializeField]
		[TextArea(3, 10)]
		protected string m_Text; // 0xF0
		private TextGenerator m_TextCache; // 0xF8
		private TextGenerator m_TextCacheForLayout; // 0x100
		protected static Material s_DefaultText; // 0x00
		[NonSerialized]
		protected bool m_DisableFontTextureRebuiltCallback; // 0x108
		private readonly UIVertex[] m_TempVerts; // 0x110
	
		// Properties
		public TextGenerator cachedTextGenerator { get => default; } // 0x0000000189F74E44-0x0000000189F74EF8 
		public TextGenerator cachedTextGeneratorForLayout { get => default; } // 0x0000000189F74DC8-0x0000000189F74E44 
		public override Texture mainTexture { get => default; } // 0x0000000189F74F98-0x0000000189F75120 
		public Font font { get => default; set {} } // 0x0000000189F74F38-0x0000000189F74F58 0x0000000189F7561C-0x0000000189F75710
		public virtual string text { get => default; set {} } // 0x0000000183D51950-0x0000000183D51960 0x0000000189F758B0-0x0000000189F7597C
		public bool supportRichText { get => default; set {} } // 0x0000000189F754D4-0x0000000189F754F4 0x0000000189F7586C-0x0000000189F758B0
		public bool resizeTextForBestFit { get => default; set {} } // 0x0000000189F75474-0x0000000189F75494 0x0000000189F757A0-0x0000000189F757E4
		public int resizeTextMinSize { get => default; set {} } // 0x0000000189F754B4-0x0000000189F754D4 0x0000000189F75828-0x0000000189F7586C
		public int resizeTextMaxSize { get => default; set {} } // 0x0000000189F75494-0x0000000189F754B4 0x0000000189F757E4-0x0000000189F75828
		public TextAnchor alignment { get => default; set {} } // 0x0000000189F74DA8-0x0000000189F74DC8 0x0000000189F75550-0x0000000189F75594
		public bool alignByGeometry { get => default; set {} } // 0x0000000189F74D88-0x0000000189F74DA8 0x0000000189F75514-0x0000000189F75550
		public int fontSize { get => default; set {} } // 0x0000000189F74EF8-0x0000000189F74F18 0x0000000189F75594-0x0000000189F755D8
		public HorizontalWrapMode horizontalOverflow { get => default; set {} } // 0x0000000189F74F58-0x0000000189F74F78 0x0000000189F75710-0x0000000189F75754
		public VerticalWrapMode verticalOverflow { get => default; set {} } // 0x0000000189F754F4-0x0000000189F75514 0x0000000189F7597C-0x0000000189F759C0
		public float lineSpacing { get => default; set {} } // 0x0000000189F74F78-0x0000000189F74F98 0x0000000189F75754-0x0000000189F757A0
		public FontStyle fontStyle { get => default; set {} } // 0x0000000189F74F18-0x0000000189F74F38 0x0000000189F755D8-0x0000000189F7561C
		public float pixelsPerUnit { get => default; } // 0x0000000189F75120-0x0000000189F7525C 
		public virtual float minWidth { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public virtual float preferredWidth { get => default; } // 0x0000000189F75384-0x0000000189F75474 
		public virtual float flexibleWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual float minHeight { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public virtual float preferredHeight { get => default; } // 0x0000000189F7525C-0x0000000189F75384 
		public virtual float flexibleHeight { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public virtual int layoutPriority { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		protected Text() {} // 0x0000000189F74CDC-0x0000000189F74D88
	
		// Methods
		public void FontTextureChanged() {} // 0x0000000189F742A8-0x0000000189F74370
		protected override void OnEnable() {} // 0x0000000189F74654-0x0000000189F746BC
		protected override void OnDisable() {} // 0x0000000189F74608-0x0000000189F74654
		protected override void UpdateGeometry() {} // 0x0000000189F74C74-0x0000000189F74CDC
		public void AssignDefaultFont() {} // 0x0000000189F74250-0x0000000189F742A8
		internal void AssignDefaultFontIfNecessary() {} // 0x0000000189F741B8-0x0000000189F74250
		public TextGenerationSettings GetGenerationSettings(Vector2 extents) => default; // 0x0000000189F74370-0x0000000189F7457C
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor) => default; // 0x0000000189F7457C-0x0000000189F74608
		protected override void OnPopulateMesh(VertexHelper toFill) {} // 0x0000000189F746BC-0x0000000189F74C74
		public virtual void CalculateLayoutInputHorizontal() {} // 0x000000018350B670-0x000000018350B680
		public virtual void CalculateLayoutInputVertical() {} // 0x000000018350B670-0x000000018350B680
	}

	[RequireComponent(typeof(RectTransform))]
	public class Toggle : Selectable, IPointerClickHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 53914
	{
		// Fields
		public ToggleTransition toggleTransition; // 0x180
		public Graphic graphic; // 0x188
		[SerializeField]
		private ToggleGroup m_Group; // 0x190
		public ToggleEvent onValueChanged; // 0x198
		[SerializeField]
		[Tooltip("Is the toggle currently on or off?")]
		private bool m_IsOn; // 0x1A0
	
		// Properties
		public ToggleGroup group { get => default; set {} } // 0x0000000189F75C78-0x0000000189F75CA0 0x0000000182848160-0x0000000182848210
		public bool isOn { get => default; set {} } // 0x0000000182C6BE20-0x0000000182C6BE30 0x0000000184276904-0x0000000184276910
		Transform ICanvasElement.transform { get => default; } // 0x0000000182848210-0x0000000182848250 
	
		// Nested types
		public enum ToggleTransition // TypeDefIndex: 53912
		{
			None = 0,
			Fade = 1
		}
	
		[Serializable]
		public class ToggleEvent : UnityEvent<bool> // TypeDefIndex: 53913
		{
			// Constructors
			public ToggleEvent() {} // 0x0000000183D56B70-0x0000000183D56B80
		}
	
		// Constructors
		protected Toggle() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void Rebuild(CanvasUpdate executing) {} // 0x000000018350B670-0x000000018350B680
		public virtual void LayoutComplete() {} // 0x000000018350B670-0x000000018350B680
		public virtual void GraphicUpdateComplete() {} // 0x0000000189F75B08-0x0000000189F75B84
		protected override void OnDestroy() {} // 0x0000000182C6C100-0x0000000182C6C140
		protected override void OnEnable() {} // 0x0000000182C6C070-0x0000000182C6C0A0
		protected override void OnDisable() {} // 0x0000000189F75B84-0x0000000189F75C44
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000182C6C2F0-0x0000000182C6C460
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) {} // 0x0000000183D57C40-0x0000000183D57C50
		public void SetIsOnWithoutNotify(bool value) {} // 0x0000000182C6BE30-0x0000000182C6BF60
		private void Set(bool value, bool sendCallback = true /* Metadata: 0x01FD623B */) {} // 0x0000000182C6C140-0x0000000182C6C200
		private void PlayEffect(bool instant) {} // 0x0000000184272FA8-0x0000000184272FB4
		protected override void Start() {} // 0x0000000182C6ACA0-0x0000000182C6AD00
		protected virtual void InternalToggle() {} // 0x0000000189F75C44-0x0000000189F75C78
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x000000018968FA40-0x000000018968FA50
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnValueChange() {} // 0x0000000184273A88-0x0000000184273A90
	}

	[AddComponentMenu("UI/Toggle Group", 31)]
	[DisallowMultipleComponent]
	public class ToggleGroup : UIBehaviour // TypeDefIndex: 53916
	{
		// Fields
		[SerializeField]
		private bool m_AllowSwitchOff; // 0x18
		protected List<Toggle> m_Toggles; // 0x20
	
		// Properties
		public bool allowSwitchOff { get => default; set {} } // 0x0000000182C6AE20-0x0000000182C6AE30 0x0000000182C6AF20-0x0000000182C6AFD0
	
		// Constructors
		protected ToggleGroup() {} // 0x0000000182C6AE30-0x0000000182C6AF20
	
		// Methods
		protected override void Start() {} // 0x0000000182C6C460-0x0000000182C6C4E0
		protected override void OnEnable() {} // 0x0000000182C6BFB0-0x0000000182C6C030
		private void ValidateToggleIsInGroup(Toggle toggle) {} // 0x0000000182C6AFD0-0x0000000182C6B2E0
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true /* Metadata: 0x01FD623E */) {} // 0x0000000182C6B420-0x0000000182C6B5A0
		public void UnregisterToggle(Toggle toggle) {} // 0x0000000182C6B2E0-0x0000000182C6B420
		public void RegisterToggle(Toggle toggle) {} // 0x0000000189F759C0-0x0000000189F75A30
		public void EnsureValidState() {} // 0x0000000189F75A30-0x0000000189F75B08
		public bool AnyTogglesOn() => default; // 0x0000000183D13430-0x0000000183D13490
		public IEnumerable<Toggle> ActiveToggles() => default; // 0x000000018350B670-0x000000018350B680
		public Toggle GetFirstActiveToggle() => default; // 0x0000000183D4D870-0x0000000183D4D890
		public void SetAllTogglesOff(bool sendCallback = true /* Metadata: 0x01FD623F */) {} // 0x0000000183D07B60-0x0000000183D07B80
	}

	internal class ReflectionMethodsCache // TypeDefIndex: 53923
	{
		// Fields
		public Raycast3DCallback raycast3D; // 0x10
		public RaycastAllCallback raycast3DAll; // 0x18
		public GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x20
		public Raycast2DCallback raycast2D; // 0x28
		public GetRayIntersectionAllCallback getRayIntersectionAll; // 0x30
		public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x38
		private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x00
	
		// Properties
		public static ReflectionMethodsCache Singleton { get => default; } // 0x0000000184279B70-0x0000000184279CA0 
	
		// Nested types
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i); // TypeDefIndex: 53917; 0x0000000189F7062C-0x0000000189F706BC
	
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i); // TypeDefIndex: 53918; 0x00000001850C0FC0-0x00000001850C0FEC
	
		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i); // TypeDefIndex: 53919; 0x0000000184276D7C-0x0000000184276EA0
	
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i); // TypeDefIndex: 53920; 0x0000000184279B70-0x0000000184279CA0
	
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i); // TypeDefIndex: 53921; 0x0000000186F4E714-0x0000000186F4E864
	
		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i); // TypeDefIndex: 53922; 0x0000000184276D7C-0x0000000184276EA0
	
		// Constructors
		public ReflectionMethodsCache() {} // 0x0000000189F6F0C0-0x0000000189F6F190
	}

	public class VertexHelper : IDisposable // TypeDefIndex: 53924
	{
		// Fields
		private List<Vector3> m_Positions; // 0x10
		private List<Color32> m_Colors; // 0x18
		private List<Vector4> m_Uv0S; // 0x20
		private List<Vector4> m_Uv1S; // 0x28
		private List<Vector4> m_Uv2S; // 0x30
		private List<Vector4> m_Uv3S; // 0x38
		private List<Vector3> m_Normals; // 0x40
		private List<Vector4> m_Tangents; // 0x48
		private List<int> m_Indices; // 0x50
		private static readonly Vector4 s_DefaultTangent; // 0x00
		private static readonly Vector3 s_DefaultNormal; // 0x10
		private bool m_ListsInitalized; // 0x58
	
		// Properties
		public int currentVertCount { get => default; } // 0x00000001825A39D0-0x00000001825A3A10 
		public int currentIndexCount { get => default; } // 0x0000000189F76800-0x0000000189F76CEC 
	
		// Constructors
		public VertexHelper() {} // 0x000000018350B670-0x000000018350B680
		public VertexHelper(Mesh m) {} // 0x0000000189F765C8-0x0000000189F76800
		static VertexHelper() {} // 0x000000018398BF50-0x000000018398BFC0
	
		// Methods
		private void InitializeListIfRequired() {} // 0x00000001825A6CE0-0x00000001825A6ED0
		public void Dispose() {} // 0x00000001836D4C20-0x00000001836D4E50
		public void Clear() {} // 0x0000000182337B50-0x0000000182337C50
		public void PopulateUIVertex(ref UIVertex vertex, int i) {} // 0x0000000189F760C4-0x0000000189F76280
		public void SetUIVertex(UIVertex vertex, int i) {} // 0x0000000189F76280-0x0000000189F765C8
		public void FillMesh(Mesh mesh) {} // 0x00000001825A84D0-0x00000001825A93E0
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) {} // 0x00000001825A6590-0x00000001825A6CE0
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) {} // 0x00000001825A5E30-0x00000001825A6590
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0) {} // 0x00000001825A5670-0x00000001825A5E30
		public void AddVert(UIVertex v) {} // 0x00000001836A4D70-0x00000001836A4E20
		public void AddTriangle(int idx0, int idx1, int idx2) {} // 0x00000001825A52A0-0x00000001825A5670
		public void AddUIVertexQuad(UIVertex[] verts) {} // 0x0000000182CDBCF0-0x0000000182CDBEB0
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) {} // 0x0000000189F75F14-0x0000000189F75FD4
		public void AddUIVertexTriangleStream(List<UIVertex> verts) {} // 0x0000000189F75FD4-0x0000000189F7604C
		public void GetUIVertexStream(List<UIVertex> stream) {} // 0x0000000189F7604C-0x0000000189F760C4
	}

	[Obsolete("Use BaseMeshEffect instead", true)]
	public abstract class BaseVertexEffect // TypeDefIndex: 53925
	{
		// Constructors
		protected BaseVertexEffect() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		public abstract void ModifyVertices(List<UIVertex> vertices);
	}

	[ExecuteAlways]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 53926
	{
		// Fields
		[NonSerialized]
		private Graphic m_Graphic; // 0x18
	
		// Properties
		protected Graphic graphic { get; } // 0x0000000189F77908-0x0000000189F7798C 
	
		// Constructors
		protected BaseMeshEffect() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void OnEnable() {} // 0x0000000189F77888-0x0000000189F77908
		protected override void OnDisable() {} // 0x0000000189F77808-0x0000000189F77888
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000189F77788-0x0000000189F77808
		public virtual void ModifyMesh(Mesh mesh) {} // 0x0000000189F77684-0x0000000189F77788
		public abstract void ModifyMesh(VertexHelper vh);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use IMeshModifier instead", true)]
	public interface IVertexModifier // TypeDefIndex: 53927
	{
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		void ModifyVertices(List<UIVertex> verts);
	}

	public interface IMeshModifier // TypeDefIndex: 53928
	{
		// Methods
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		void ModifyMesh(Mesh mesh);
		void ModifyMesh(VertexHelper verts);
	}

	[AddComponentMenu("UI/Effects/Outline", 81)]
	public class Outline : Shadow // TypeDefIndex: 53929
	{
		// Constructors
		protected Outline() {} // 0x0000000189F79564-0x0000000189F7956C
	
		// Methods
		public override void ModifyMesh(VertexHelper vh) {} // 0x0000000189F792CC-0x0000000189F79564
	}

	[AddComponentMenu("UI/Effects/Position As UV1", 82)]
	public class PositionAsUV1 : BaseMeshEffect // TypeDefIndex: 53930
	{
		// Constructors
		protected PositionAsUV1() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public override void ModifyMesh(VertexHelper vh) {} // 0x0000000189F7E390-0x0000000189F7E48C
	}

	[AddComponentMenu("UI/Effects/Shadow", 80)]
	public class Shadow : BaseMeshEffect // TypeDefIndex: 53931
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color m_EffectColor; // 0x20
		[SerializeField]
		private Vector2 m_EffectDistance; // 0x30
		[SerializeField]
		private bool m_UseGraphicAlpha; // 0x38
		private const float kMaxEffectDistance = 600f; // Metadata: 0x01FD6240
	
		// Properties
		public UnityEngine.Color effectColor { get => default; set {} } // 0x0000000183D54E00-0x0000000183D54E10 0x0000000189F7F6BC-0x0000000189F7F748
		public Vector2 effectDistance { get => default; set {} } // 0x0000000183D69670-0x0000000183D69690 0x0000000189F7F748-0x0000000189F7F84C
		public bool useGraphicAlpha { get => default; set {} } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000189F7F84C-0x0000000189F7F8D4
	
		// Constructors
		protected Shadow() {} // 0x0000000183D474D0-0x0000000183D47500
	
		// Methods
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) {} // 0x0000000189F7F308-0x0000000189F7F584
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) {} // 0x0000000189F7F584-0x0000000189F7F594
		public override void ModifyMesh(VertexHelper vh) {} // 0x0000000189F7F594-0x0000000189F7F6BC
	}
}

namespace UnityEngine.UI.Collections
{
	internal class IndexedSet<T> : IList<T> // TypeDefIndex: 53932
	{
		// Fields
		private readonly List<T> m_List;
		private Dictionary<T, int> m_Dictionary;
	
		// Properties
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public IndexedSet() {}
	
		// Methods
		public void Add(T item) {}
		public bool AddUnique(T item) => default;
		public bool Remove(T item) => default;
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void RemoveAt(int index) {}
		public void RemoveAll(Predicate<T> match) {}
		public void Sort(Comparison<T> sortLayoutFunction) {}
	}
}

namespace UnityEngine.UI.CoroutineTween
{
	internal interface ITweenValue // TypeDefIndex: 53933
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}

	internal struct ColorTween : ITweenValue // TypeDefIndex: 53936
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private UnityEngine.Color m_StartColor; // 0x08
		private UnityEngine.Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public UnityEngine.Color startColor { get => default; set {} } // 0x0000000183D707A0-0x0000000183D707B0 0x0000000183D51D80-0x0000000183D51D90
		public UnityEngine.Color targetColor { get => default; set {} } // 0x0000000183D51D90-0x0000000183D51DA0 0x0000000183D4EB90-0x0000000183D4EBA0
		public ColorTweenMode tweenMode { get => default; set {} } // 0x0000000183D4EBA0-0x0000000183D4EBB0 0x0000000183D4F3A0-0x0000000183D4F3B0
		public float duration { get => default; set {} } // 0x0000000183D4F3B0-0x0000000183D4F3C0 0x0000000183D4EF60-0x0000000183D4EF70
		public bool ignoreTimeScale { get => default; set {} } // 0x0000000183D4EF70-0x0000000183D4EF80 0x000000018317A040-0x000000018317A1F0
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 53934
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<UnityEngine.Color> // TypeDefIndex: 53935
		{
			// Constructors
			public ColorTweenCallback() {} // 0x00000001820C61C0-0x00000001820C61D0
		}
	
		// Methods
		public void TweenValue(float floatPercentage) {} // 0x00000001824A3EA0-0x00000001824A3F40
		public void AddOnChangedCallback(UnityAction<UnityEngine.Color> callback) {} // 0x0000000183D4EF60-0x0000000183D4EF70
		public bool GetIgnoreTimescale() => default; // 0x0000000183D4F3A0-0x0000000183D4F3B0
		public float GetDuration() => default; // 0x000000018317A1F0-0x000000018317A200
		public bool ValidTarget() => default; // 0x00000001824A3F40-0x00000001824A3F80
	}

	internal struct FloatTween : ITweenValue // TypeDefIndex: 53938
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get => default; set {} } // 0x0000000183D58BE0-0x0000000183D58BF0 0x0000000183D5E120-0x0000000183D5E130
		public float targetValue { get => default; set {} } // 0x0000000183D5E130-0x0000000183D5E140 0x0000000183D4E7A0-0x0000000183D4E7B0
		public float duration { get => default; set {} } // 0x0000000183D50CA0-0x0000000183D50CB0 0x0000000183D58C00-0x0000000183D58C10
		public bool ignoreTimeScale { get => default; set {} } // 0x0000000183D58C20-0x0000000183D58C30 0x0000000189F78F28-0x0000000189F78F8C
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 53937
		{
			// Constructors
			public FloatTweenCallback() {} // 0x0000000183D58BB0-0x0000000183D58BC0
		}
	
		// Methods
		public void TweenValue(float floatPercentage) {} // 0x0000000189F78E90-0x0000000189F78F28
		public void AddOnChangedCallback(UnityAction<float> callback) {} // 0x0000000183D58C00-0x0000000183D58C10
		public bool GetIgnoreTimescale() => default; // 0x0000000183D4E7A0-0x0000000183D4E7B0
		public float GetDuration() => default; // 0x00000001822B4F90-0x00000001822B4FA0
		public bool ValidTarget() => default; // 0x0000000189F78E54-0x0000000189F78E90
	}

	internal class TweenRunner<T> // TypeDefIndex: 53940
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Constructors
		public TweenRunner() {}
	
		// Methods
		[IteratorStateMachine(typeof(_Start_d__2))]
		private static IEnumerator Start(T tweenInfo) => default;
		public void Init(MonoBehaviour coroutineContainer) {}
		public void StartTween(T info) {}
		public void StopTween() {}
	}
}

namespace UnityEngine.UIElements
{
	[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
	public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, UnityEngine.EventSystems.IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent // TypeDefIndex: 53943
	{
		// Fields
		private BaseRuntimePanel m_Panel; // 0x18
		private readonly PointerEvent m_PointerEvent; // 0x20
		private bool m_Selecting; // 0x28
		private UnityEngine.Event m_Event; // 0x30
		private static EventModifiers s_Modifiers; // 0x00
	
		// Properties
		public IPanel panel { get => default; set {} } // 0x0000000183D59800-0x0000000183D59820 0x0000000183D5BF30-0x0000000183D5BF40
		private GameObject selectableGameObject { get => default; } // 0x0000000183D69690-0x0000000183D696B0 
		private EventSystem eventSystem { get => default; } // 0x0000000183D68D90-0x0000000183D68DA0 
	
		// Nested types
		private enum PointerEventType // TypeDefIndex: 53941
		{
			Default = 0,
			Down = 1,
			Up = 2
		}
	
		private class PointerEvent : IPointerEvent // TypeDefIndex: 53942
		{
			// Properties
			public int pointerId { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x0000000189F7AED0-0x0000000189F7AF40
			public string pointerType { get; private set; } // 0x0000000189F7AEBC-0x0000000189F7AED0 0x0000000189F7AE6C-0x0000000189F7AEBC
			public bool isPrimary { get; private set; } // 0x0000000189F796F4-0x0000000189F796FC 0x0000000189F79658-0x0000000189F79660
			public int button { get; private set; } // 0x0000000189F7A5A8-0x0000000189F7A750 0x0000000189F7AB6C-0x0000000189F7AD14
			public int pressedButtons { get; private set; } // 0x0000000189F797D8-0x0000000189F797E4 0x0000000189F79660-0x0000000189F796F4
			public Vector3 position { get; private set; } // 0x000000018350B670-0x000000018350B680 0x0000000189F79FD8-0x0000000189F7A070
			public Vector3 localPosition { get; private set; } // 0x0000000189F79644-0x0000000189F79658 0x0000000189F79C58-0x0000000189F79D44
			public Vector3 deltaPosition { get; private set; } // 0x0000000189F79D44-0x0000000189F79E98 0x0000000189F797E4-0x0000000189F799A8
			public float deltaTime { get; private set; } // 0x0000000189F79A1C-0x0000000189F79C58 0x0000000189F799A8-0x0000000189F79A1C
			public int clickCount { get; private set; } // 0x0000000189F7A070-0x0000000189F7A13C 0x0000000189F79578-0x0000000189F79644
			public float pressure { get; private set; } // 0x0000000189F796FC-0x0000000189F797D8 0x0000000189F79E98-0x0000000189F79FD8
			public float tangentialPressure { get; private set; } // 0x0000000189F7A750-0x0000000189F7A79C 0x0000000189F7A79C-0x0000000189F7A7EC
			public float altitudeAngle { get; private set; } // 0x0000000189F7AD14-0x0000000189F7ADD4 0x0000000189F7956C-0x0000000189F79578
			public float azimuthAngle { get; private set; } // 0x0000000189F7A13C-0x0000000189F7A288 0x0000000189F7A288-0x0000000189F7A384
			public float twist { get; private set; } // 0x0000000189F7A384-0x0000000189F7A3F8 0x0000000189F7A9BC-0x0000000189F7AA80
			public Vector2 radius { get; private set; } // 0x0000000189F7A8D4-0x0000000189F7A9BC 0x0000000189F7A7EC-0x0000000189F7A8D4
			public Vector2 radiusVariance { get; private set; } // 0x0000000189F7AA80-0x0000000189F7AB6C 0x0000000189F7A3F8-0x0000000189F7A5A8
			public EventModifiers modifiers { get; private set; } // 0x0000000189F7ADD4-0x0000000189F7AE6C 0x0000000183D4E340-0x0000000183D4E350
			public bool shiftKey { get => default; } // 0x00000001810410F0-0x0000000181041100 
			public bool ctrlKey { get => default; } // 0x0000000181041090-0x00000001810410A0 
			public bool commandKey { get => default; } // 0x00000001822C3A90-0x00000001822C3AA0 
			public bool altKey { get => default; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
			public bool actionKey { get => default; } // 0x0000000183D4EFC0-0x0000000183D4EFD0 
	
			// Constructors
			public PointerEvent() {} // 0x0000000183D4EB90-0x0000000183D4EBA0
	
			// Methods
			public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) {} // 0x0000000183D4E2E0-0x0000000183D4E2F0
			public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) {} // 0x0000000183D4E2F0-0x0000000183D4E300
		}
	
		// Constructors
		public PanelEventHandler() {} // 0x0000000189F7CFD4-0x0000000189F7CFE8
	
		// Methods
		protected override void OnEnable() {} // 0x0000000183D5BDA0-0x0000000183D5BDC0
		protected override void OnDisable() {} // 0x0000000183D5BDC0-0x0000000183D5BDD0
		private void RegisterCallbacks() {} // 0x0000000183D51C90-0x0000000183D51CA0
		private void UnregisterCallbacks() {} // 0x0000000183D51CA0-0x0000000183D51CB0
		private void OnPanelDestroyed() {} // 0x0000000183D4EEC0-0x0000000183D4EED0
		private void OnElementFocus(FocusEvent e) {} // 0x0000000183D4EF10-0x0000000183D4EF20
		private void OnElementBlur(BlurEvent e) {} // 0x0000000183D51080-0x0000000183D51090
		public void OnSelect(BaseEventData eventData) {} // 0x0000000183D510B0-0x0000000183D510C0
		public void OnDeselect(BaseEventData eventData) {} // 0x0000000183D56C10-0x0000000183D56C20
		public void OnPointerMove(PointerEventData eventData) {} // 0x0000000183D5BDF0-0x0000000183D5BE00
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000183D50D50-0x0000000183D50D60
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000183D50D80-0x0000000183D50D90
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000183D50D60-0x0000000183D50D70
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000183D50D70-0x0000000183D50D80
		public void OnSubmit(BaseEventData eventData) {} // 0x0000000183D56A40-0x0000000183D56A50
		public void OnCancel(BaseEventData eventData) {} // 0x0000000183D59110-0x0000000183D59120
		public void OnMove(AxisEventData eventData) {} // 0x0000000183D5C200-0x0000000183D5C220
		public void OnScroll(PointerEventData eventData) {} // 0x0000000183D55B80-0x0000000183D55B90
		private void SendEvent(EventBase e, BaseEventData sourceEventData) {} // 0x0000000183D89EB0-0x0000000183D89ED0
		private void SendEvent(EventBase e, UnityEngine.Event sourceEvent) {} // 0x0000000183D89ED0-0x0000000183D89EE0
		private void Update() {} // 0x0000000183D4EC90-0x0000000183D4ECA0
		private void LateUpdate() {} // 0x0000000183D4ED10-0x0000000183D4ED20
		private void ProcessImguiEvents(bool isSelected) {} // 0x0000000189F7D034-0x0000000189F7D03C
		private void ProcessKeyboardEvent(UnityEngine.Event e) {} // 0x0000000189F7D02C-0x0000000189F7D034
		private void ProcessTabEvent(UnityEngine.Event e) {} // 0x0000000189F7D024-0x0000000189F7D02C
		private void SendTabEvent(UnityEngine.Event e, int direction) {} // 0x0000000189F7D01C-0x0000000189F7D024
		private void SendKeyUpEvent(UnityEngine.Event e, KeyCode keyCode, EventModifiers modifiers) {} // 0x0000000189F7CFE8-0x0000000189F7D01C
		private void SendKeyDownEvent(UnityEngine.Event e, KeyCode keyCode, EventModifiers modifiers) {} // 0x0000000189F7CAC0-0x0000000189F7CFD4
		private void SendTextEvent(UnityEngine.Event e, char c, EventModifiers modifiers) {} // 0x0000000183D89E80-0x0000000183D89EB0
		private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = PointerEventType.Default /* Metadata: 0x01FD6247 */) => default; // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
	public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent // TypeDefIndex: 53945
	{
		// Fields
		private BaseRuntimePanel m_Panel; // 0x20
	
		// Properties
		public IPanel panel { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000189F7B594-0x0000000189F7B604
		private GameObject selectableGameObject { get => default; } // 0x0000000189F7B564-0x0000000189F7B578 
		public override int sortOrderPriority { get => default; } // 0x0000000189F7B578-0x0000000189F7B594 
		public override int renderOrderPriority { get => default; } // 0x0000000189F7B54C-0x0000000189F7B564 
		public override Camera eventCamera { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Nested types
		private struct FloatIntBits // TypeDefIndex: 53944
		{
			// Fields
			public float f; // 0x00
			public int i; // 0x00
		}
	
		// Constructors
		public PanelRaycaster() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void RegisterCallbacks() {} // 0x0000000189F7B424-0x0000000189F7B4B8
		private void UnregisterCallbacks() {} // 0x0000000189F7B4B8-0x0000000189F7B54C
		private void OnPanelDestroyed() {} // 0x0000000189F7AF40-0x0000000189F7AF4C
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x0000000189F7AF4C-0x0000000189F7B424
		private static int ConvertFloatBitsToInt(float f) => default; // 0x0000000183D70290-0x0000000183D702A0
	}
}
