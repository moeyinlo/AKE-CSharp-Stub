/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Pool;
using UnityEngine.Rendering;
using UnityEngine.U2D;
using UnityEngine.UI.Collections;
using UnityEngine.UI.CoroutineTween;
using UnityEngine.UIElements;

// Image 32: UnityEngine.UI.dll - Assembly: UnityEngine.UI, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54783-55011

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 55011
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB; // 0x00 // Static value (base64): IAAuACwACQANAAoA - Metadata: 0x0207BAAC

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 55010
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 54784
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 54785
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Profiling
{
	public struct ProfilerCounter<T> // TypeDefIndex: 54994
		where T : struct
	{
		// Constructors
		public ProfilerCounter(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit) {}
	
		// Methods
		public void Sample(T value) {}
	}

	public struct ProfilerCounterValue<T> // TypeDefIndex: 54995
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
		public void Sample() {}
	}

	public struct ProfilerMarker<TP1> // TypeDefIndex: 54997
		where TP1 : struct
	{
		// Nested types
		public struct AutoScope : IDisposable // TypeDefIndex: 54996
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
		public void Begin(TP1 p1) {}
		public void End() {}
		public AutoScope Auto(TP1 p1) => default;
	}

	public struct ProfilerMarker<TP1, TP2> // TypeDefIndex: 54999
		where TP1 : struct
		where TP2 : struct
	{
		// Nested types
		public struct AutoScope : IDisposable // TypeDefIndex: 54998
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
		public void Begin(TP1 p1, TP2 p2) {}
		public void End() {}
		public AutoScope Auto(TP1 p1, TP2 p2) => default;
	}

	public struct ProfilerMarker<TP1, TP2, TP3> // TypeDefIndex: 55001
		where TP1 : struct
		where TP2 : struct
		where TP3 : struct
	{
		// Nested types
		public struct AutoScope : IDisposable // TypeDefIndex: 55000
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
		public void Begin(TP1 p1, TP2 p2, TP3 p3) {}
		public void End() {}
		public AutoScope Auto(TP1 p1, TP2 p2, TP3 p3) => default;
	}

	public static class ProfilerMarkerExtension // TypeDefIndex: 55003
	{
		// Nested types
		public struct ProfilerMarkerScope : IDisposable // TypeDefIndex: 55002
		{
			// Constructors
			public ProfilerMarkerScope(in ProfilerMarker marker) {} // 0x000000018C0961E4-0x000000018C096258
			public ProfilerMarkerScope(in ProfilerMarker marker, int context) {} // 0x000000018C0966B0-0x000000018C096724
			public ProfilerMarkerScope(in ProfilerMarker marker, long context) {} // 0x000000018C0965C0-0x000000018C096638
			public ProfilerMarkerScope(in ProfilerMarker marker, float context) {} // 0x000000018C096638-0x000000018C0966B0
			public ProfilerMarkerScope(in ProfilerMarker marker, string context) {} // 0x000000018C096398-0x000000018C096410
			public ProfilerMarkerScope(in ProfilerMarker marker, string context, string context2) {} // 0x000000018C096258-0x000000018C0962D0
			public ProfilerMarkerScope(in ProfilerMarker marker, long context, string context2) {} // 0x000000018C096190-0x000000018C0961E4
			public ProfilerMarkerScope(in ProfilerMarker marker, long context, long context2) {} // 0x000000018C096410-0x000000018C0964E8
			public ProfilerMarkerScope(in ProfilerMarker marker, UnityEngine.Object obj) {} // 0x000000018C0964E8-0x000000018C0965C0
			public ProfilerMarkerScope(in ProfilerMarker marker, Transform transform, bool path) {} // 0x000000018C0962D0-0x000000018C096398
	
			// Methods
			public void Dispose() {} // 0x00000001814A81B0-0x00000001814A81C0
		}
	
		// Methods
		public static void Begin(ProfilerMarker marker, int metadata) {} // 0x0000000185FEAD30-0x0000000185FEAD40
		public static void Begin(ProfilerMarker marker, uint metadata) {} // 0x0000000185FEAD30-0x0000000185FEAD40
		public static void Begin(ProfilerMarker marker, long metadata) {} // 0x0000000185FEAD30-0x0000000185FEAD40
		public static void Begin(ProfilerMarker marker, ulong metadata) {} // 0x0000000185FEAD30-0x0000000185FEAD40
		public static void Begin(ProfilerMarker marker, float metadata) {} // 0x0000000185FEAD20-0x0000000185FEAD30
		public static void Begin(ProfilerMarker marker, double metadata) {} // 0x0000000185FEAD20-0x0000000185FEAD30
		public static void Begin(ProfilerMarker marker, string metadata) {} // 0x0000000185FEAD20-0x0000000185FEAD30
		public static void Begin(ProfilerMarker marker, string metadata, string metadata2) {} // 0x0000000185FEAD20-0x0000000185FEAD30
		public static void Begin(ProfilerMarker marker, long metadata, string metadata2) {} // 0x0000000185492010-0x0000000185492020
		public static void Begin(ProfilerMarker marker, long metadata, long metadata2) {} // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker) => default; // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker, int context) => default; // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker, long context) => default; // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker, float context) => default; // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker, string context) => default; // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker, string context, string context2) => default; // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker, long context, string context2) => default; // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker, long context, long context2) => default; // 0x0000000185492010-0x0000000185492020
		public static ProfilerMarkerScope Scope(ProfilerMarker marker, Transform transform, bool path = false /* Metadata: 0x0207BA9F */) => default; // 0x0000000185492010-0x0000000185492020
	}

	public struct MonoObject_64 // TypeDefIndex: 55004
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x08
	}

	public struct MonoObject_32 // TypeDefIndex: 55005
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x04
	}

	public struct MonoString_64 // TypeDefIndex: 55006
	{
		// Fields
		public MonoObject_64 obj; // 0x00
		public int length; // 0x10
		public char firstChar; // 0x14
	}

	public struct MonoString_32 // TypeDefIndex: 55007
	{
		// Fields
		public MonoObject_32 obj; // 0x00
		public int length; // 0x08
		public char firstChar; // 0x0C
	}

	public class ProfilerString : IDisposable // TypeDefIndex: 55008
	{
		// Fields
		private const int MAX = 256; // Metadata: 0x0207BAA2
		private string m_buffer; // 0x10
		private int m_length; // 0x18
		private unsafe int* m_strCount; // 0x20
		private ulong m_handler; // 0x28
	
		// Constructors
		public ProfilerString() {} // Dummy constructor
		public ProfilerString(int count = 256 /* Metadata: 0x0207BAA0 */) {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
		public override string ToString() => default; // 0x000000018346D130-0x000000018346D140
		public static implicit operator string(ProfilerString handle) => default; // 0x000000018C096A20-0x000000018C096A40
		public void Append(string value) {} // 0x000000018C096938-0x000000018C096A20
	}

	internal struct ProfilerUtility // TypeDefIndex: 55009
	{
		// Methods
		public static byte GetProfilerMarkerDataType<T>() => default;
	}
}

namespace UnityEngine.EventSystems
{
	public class AxisEventData : BaseEventData // TypeDefIndex: 54939
	{
		// Fields
		private Vector2 _moveVector_k__BackingField; // 0x20
		private MoveDirection _moveDir_k__BackingField; // 0x28
	
		// Properties
		public Vector2 moveVector { get; set; } // 0x0000000185FD22C0-0x0000000185FD22E0 0x00000001813BDF70-0x00000001813BDF80
		public MoveDirection moveDir { get; set; } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
	
		// Constructors
		public AxisEventData() {} // Dummy constructor
		public AxisEventData(EventSystem eventSystem) {} // 0x000000018C08E9D4-0x000000018C08E9FC
	}

	public abstract class AbstractEventData // TypeDefIndex: 54940
	{
		// Fields
		protected bool m_Used; // 0x10
	
		// Properties
		public virtual bool used { get; } // 0x0000000181C2FD60-0x0000000181C2FD70 
	
		// Constructors
		protected AbstractEventData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void Reset() {} // 0x0000000185FB6A70-0x0000000185FB6A80
		public virtual void Use() {} // 0x0000000181B9A230-0x0000000181B9A240
	}

	public class BaseEventData : AbstractEventData // TypeDefIndex: 54941
	{
		// Fields
		private readonly EventSystem m_EventSystem; // 0x18
	
		// Properties
		public BaseInputModule currentInputModule { get => default; } // 0x0000000188115408-0x0000000188115424 
		public GameObject selectedObject { get => default; set {} } // 0x00000001880BDABC-0x00000001880BDAD8 0x000000018C08E9FC-0x000000018C08EA24
	
		// Constructors
		public BaseEventData() {} // Dummy constructor
		public BaseEventData(EventSystem eventSystem) {} // 0x0000000184088E70-0x0000000184088E80
	}

	public class PointerEventData : BaseEventData // TypeDefIndex: 54944
	{
		// Fields
		private GameObject _pointerEnter_k__BackingField; // 0x20
		private GameObject m_PointerPress; // 0x28
		private GameObject _lastPress_k__BackingField; // 0x30
		private GameObject _rawPointerPress_k__BackingField; // 0x38
		private GameObject _pointerDrag_k__BackingField; // 0x40
		private GameObject _pointerClick_k__BackingField; // 0x48
		private RaycastResult _pointerCurrentRaycast_k__BackingField; // 0x50
		private RaycastResult _pointerPressRaycast_k__BackingField; // 0x98
		public List<GameObject> hovered; // 0xE0
		private bool _eligibleForClick_k__BackingField; // 0xE8
		private int _pointerId_k__BackingField; // 0xEC
		private Vector2 _position_k__BackingField; // 0xF0
		private Vector2 _delta_k__BackingField; // 0xF8
		private Vector2 _pressPosition_k__BackingField; // 0x100
		private Vector3 _worldPosition_k__BackingField; // 0x108
		private Vector3 _worldNormal_k__BackingField; // 0x114
		private float _clickTime_k__BackingField; // 0x120
		private int _clickCount_k__BackingField; // 0x124
		private Vector2 _scrollDelta_k__BackingField; // 0x128
		private bool _useDragThreshold_k__BackingField; // 0x130
		private bool _dragging_k__BackingField; // 0x131
		private InputButton _button_k__BackingField; // 0x134
		private float _pressure_k__BackingField; // 0x138
		private float _tangentialPressure_k__BackingField; // 0x13C
		private float _altitudeAngle_k__BackingField; // 0x140
		private float _azimuthAngle_k__BackingField; // 0x144
		private float _twist_k__BackingField; // 0x148
		private Vector2 _radius_k__BackingField; // 0x14C
		private Vector2 _radiusVariance_k__BackingField; // 0x154
		private bool _fullyExited_k__BackingField; // 0x15C
		private bool _reentered_k__BackingField; // 0x15D
	
		// Properties
		public GameObject pointerEnter { get; set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public GameObject lastPress { get; private set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public GameObject rawPointerPress { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public GameObject pointerDrag { get; set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public GameObject pointerClick { get; set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public RaycastResult pointerCurrentRaycast { get; set; } // 0x0000000185FEAB50-0x0000000185FEAB90 0x000000018C094748-0x000000018C094780
		public RaycastResult pointerPressRaycast { get; set; } // 0x0000000185FEAB90-0x0000000185FEABD0 0x000000018C094780-0x000000018C0947C4
		public bool eligibleForClick { get; set; } // 0x0000000185FB67C0-0x0000000185FB67D0 0x0000000185FB67F0-0x0000000185FB6800
		public int pointerId { get; set; } // 0x0000000185FB9650-0x0000000185FB9660 0x0000000185FB96B0-0x0000000185FB96C0
		public Vector2 position { get; set; } // 0x0000000185FB8A90-0x0000000185FB8AB0 0x0000000185FB8AB0-0x0000000185FB8AC0
		public Vector2 delta { get; set; } // 0x0000000185FEAB20-0x0000000185FEAB40 0x0000000185FEAC60-0x0000000185FEAC70
		public Vector2 pressPosition { get; set; } // 0x0000000185FEABD0-0x0000000185FEABF0 0x0000000185FEAC80-0x0000000185FEAC90
		public Vector3 worldPosition { get; set; } // 0x0000000185FBD900-0x0000000185FBD920 0x0000000185FBD940-0x0000000185FBD960
		public Vector3 worldNormal { get; set; } // 0x0000000185FBCE60-0x0000000185FBCE80 0x0000000185FBCF20-0x0000000185FBCF40
		public float clickTime { get; set; } // 0x0000000185FB9C00-0x0000000185FB9C10 0x0000000185FE9320-0x0000000185FE9330
		public int clickCount { get; set; } // 0x0000000185FCEAF0-0x0000000185FCEB00 0x0000000185FD4F30-0x0000000185FD4F40
		public Vector2 scrollDelta { get; set; } // 0x0000000185FEAC30-0x0000000185FEAC50 0x0000000185FEACB0-0x0000000185FEACC0
		public bool useDragThreshold { get; set; } // 0x0000000185FB9330-0x0000000185FB9340 0x0000000185FBBA90-0x0000000185FBBAA0
		public bool dragging { get; set; } // 0x0000000185FEAB40-0x0000000185FEAB50 0x0000000185FEAC70-0x0000000185FEAC80
		public InputButton button { get; set; } // 0x0000000185FB11A0-0x0000000185FB11B0 0x0000000185FE9530-0x0000000185FE9540
		public float pressure { get; set; } // 0x0000000185FB8E20-0x0000000185FB8E30 0x0000000185FBAD50-0x0000000185FBAD60
		public float tangentialPressure { get; set; } // 0x0000000185FB9110-0x0000000185FB9120 0x0000000185FE7C80-0x0000000185FE7C90
		public float altitudeAngle { get; set; } // 0x0000000185FB8C00-0x0000000185FB8C10 0x0000000185FB8C60-0x0000000185FB8C70
		public float azimuthAngle { get; set; } // 0x0000000185FB9500-0x0000000185FB9510 0x0000000185FEAC50-0x0000000185FEAC60
		public float twist { get; set; } // 0x0000000185FB9A70-0x0000000185FB9A80 0x0000000185FBCC60-0x0000000185FBCC70
		public Vector2 radius { get; set; } // 0x0000000185FEAC10-0x0000000185FEAC30 0x0000000185FEACA0-0x0000000185FEACB0
		public Vector2 radiusVariance { get; set; } // 0x0000000185FEABF0-0x0000000185FEAC10 0x0000000185FEAC90-0x0000000185FEACA0
		public bool fullyExited { get; set; } // 0x0000000185FBD0C0-0x0000000185FBD0D0 0x0000000185FBD110-0x0000000185FBD120
		public bool reentered { get; set; } // 0x0000000185FBD090-0x0000000185FBD0A0 0x0000000185FBD0E0-0x0000000185FBD0F0
		public Camera enterEventCamera { get => default; } // 0x000000018C09463C-0x000000018C0946C0 
		public Camera pressEventCamera { get => default; } // 0x000000018C0946C0-0x000000018C094748 
		public GameObject pointerPress { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184211860-0x00000001842119D0
	
		// Nested types
		public enum InputButton // TypeDefIndex: 54942
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		public enum FramePressState // TypeDefIndex: 54943
		{
			Pressed = 0,
			Released = 1,
			PressedAndReleased = 2,
			NotChanged = 3
		}
	
		// Constructors
		public PointerEventData() {} // Dummy constructor
		public PointerEventData(EventSystem eventSystem) {} // 0x00000001845E3130-0x00000001845E3230
	
		// Methods
		public bool IsPointerMoving() => default; // 0x0000000184211D00-0x0000000184211D30
		public bool IsScrolling() => default; // 0x000000018467AF10-0x000000018467AF40
		public override string ToString() => default; // 0x000000018C0940BC-0x000000018C09463C
	}

	public enum EventHandle // TypeDefIndex: 54945
	{
		Unused = 0,
		Used = 1
	}

	public interface IEventSystemHandler // TypeDefIndex: 54946
	{
	}

	public interface IPointerMoveHandler : IEventSystemHandler // TypeDefIndex: 54947
	{
		// Methods
		void OnPointerMove(PointerEventData eventData);
	}

	public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 54948
	{
		// Methods
		void OnPointerEnter(PointerEventData eventData);
	}

	public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 54949
	{
		// Methods
		void OnPointerExit(PointerEventData eventData);
	}

	public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 54950
	{
		// Methods
		void OnPointerDown(PointerEventData eventData);
	}

	public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 54951
	{
		// Methods
		void OnPointerUp(PointerEventData eventData);
	}

	public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 54952
	{
		// Methods
		void OnPointerClick(PointerEventData eventData);
	}

	public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 54953
	{
		// Methods
		void OnBeginDrag(PointerEventData eventData);
	}

	public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 54954
	{
		// Methods
		void OnInitializePotentialDrag(PointerEventData eventData);
	}

	public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 54955
	{
		// Methods
		void OnDrag(PointerEventData eventData);
	}

	public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 54956
	{
		// Methods
		void OnEndDrag(PointerEventData eventData);
	}

	public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 54957
	{
		// Methods
		void OnDrop(PointerEventData eventData);
	}

	public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 54958
	{
		// Methods
		void OnScroll(PointerEventData eventData);
	}

	public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 54959
	{
		// Methods
		void OnUpdateSelected(BaseEventData eventData);
	}

	public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 54960
	{
		// Methods
		void OnSelect(BaseEventData eventData);
	}

	public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 54961
	{
		// Methods
		void OnDeselect(BaseEventData eventData);
	}

	public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 54962
	{
		// Methods
		void OnMove(AxisEventData eventData);
	}

	public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 54963
	{
		// Methods
		void OnSubmit(BaseEventData eventData);
	}

	public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 54964
	{
		// Methods
		void OnCancel(BaseEventData eventData);
	}

	public class EventSystem : UIBehaviour // TypeDefIndex: 54968
	{
		// Fields
		private List<BaseInputModule> m_SystemInputModules; // 0x18
		private BaseInputModule m_CurrentInputModule; // 0x20
		private static List<EventSystem> m_EventSystems; // 0x00
		private GameObject m_FirstSelected; // 0x28
		private bool m_sendNavigationEvents; // 0x30
		private int m_DragThreshold; // 0x34
		private GameObject m_CurrentSelected; // 0x38
		private bool m_HasFocus; // 0x40
		private bool m_SelectionGuard; // 0x41
		private BaseEventData m_DummyData; // 0x48
		private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x08
		private static UIToolkitOverrideConfig s_UIToolkitOverride; // 0x10
	
		// Properties
		public static EventSystem current { get => default; set {} } // 0x000000018142A360-0x000000018142A370 0x0000000185FB07C0-0x0000000185FB07D0
		public bool sendNavigationEvents { get => default; set {} } // 0x0000000185FB07E0-0x0000000185FB07F0 0x00000001813B31A0-0x00000001813B31B0
		public int pixelDragThreshold { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public BaseInputModule currentInputModule { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
		public GameObject firstSelectedGameObject { get => default; set {} } // 0x00000001813AE580-0x00000001813AE590 0x0000000185FB0650-0x0000000185FB0660
		public GameObject currentSelectedGameObject { get => default; } // 0x0000000185F3C060-0x0000000185F3C0F0 
		public GameObject lastSelectedGameObject { get => default; } // 0x00000001858C8B00-0x00000001858C8C10 
		public bool isFocused { get => default; } // 0x0000000185FB0D70-0x0000000185FB0D80 
		public bool alreadySelecting { get => default; } // 0x000000018C08FCE0-0x000000018C08FD14 
		private BaseEventData baseEventDataCache { get => default; } // 0x0000000184237D90-0x0000000184238190 
		private bool isUIToolkitActiveEventSystem { get => default; } // 0x000000018C08FD14-0x000000018C08FE58 
		private bool sendUIToolkitEvents { get => default; } // 0x000000018C08F898-0x000000018C08FAD8 
		private bool createUIToolkitPanelGameObjectsOnStart { get => default; } // 0x00000001857F9C20-0x00000001857FA5E0 
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 54965
		{
			// Fields
			public static readonly ProfilerMarker Update; // 0x00
			public static readonly ProfilerMarker TickModules; // 0x08
			public static readonly ProfilerMarker CurrentModuleProcess; // 0x10
			public static readonly ProfilerMarker RaycastAll; // 0x18
			public static readonly ProfilerMarker RaycastAllSort; // 0x20
	
			// Constructors
			static ProfilerMarkers() {} // 0x0000000183FB3320-0x0000000183FB3400
		}
	
		private struct UIToolkitOverrideConfig // TypeDefIndex: 54966
		{
			// Fields
			public EventSystem activeEventSystem; // 0x00
			public bool sendEvents; // 0x08
			public bool createPanelGameObjectsOnStart; // 0x09
		}
	
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 54967
		{
			// Fields
			public GameObject go; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0() {} // 0x000000018C08FFFC-0x000000018C090158
	
			// Methods
			internal void _CreateUIToolkitPanelGameObject_b__0() {} // 0x00000001814294C0-0x00000001814294D0
		}
	
		// Constructors
		protected EventSystem() {} // 0x00000001845E3230-0x00000001845E33F0
		static EventSystem() {} // 0x000000018C09BE54-0x000000018C09BEA4
	
		// Methods
		public void UpdateModules() {} // 0x000000018C08FF88-0x000000018C08FFFC
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) {} // 0x0000000184235F30-0x0000000184236480
		public void SetSelectedGameObject(GameObject selected) {} // 0x000000018C08FB58-0x000000018C08FB68
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) => default; // 0x000000018C08FAD8-0x000000018C08FB58
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) {} // 0x00000001857FA7D0-0x00000001857FA8C0
		public bool IsPointerOverGameObject() => default; // 0x00000001857F9BB0-0x00000001857F9C20
		public bool IsPointerOverGameObject(int pointerId) => default; // 0x00000001857FA680-0x00000001857FA6F0
		public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true /* Metadata: 0x0207BA80 */, bool createPanelGameObjectsOnStart = true /* Metadata: 0x0207BA81 */) {} // 0x000000018C08FB68-0x000000018C08FBF8
		private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) {} // 0x00000001857F9AF0-0x00000001857F9BB0
		protected override void Start() {} // 0x000000018C08FBF8-0x000000018C08FCE0
		protected override void OnDestroy() {} // 0x0000000183FB2B60-0x0000000183FB3320
		protected override void OnEnable() {} // 0x000000018509B790-0x000000018509B7B0
		protected override void OnDisable() {} // 0x0000000183FB27F0-0x0000000183FB2B60
		private void TickModules() {} // 0x0000000185EC2F90-0x0000000185EC3080
		protected virtual void OnApplicationFocus(bool hasFocus) {} // 0x000000018C08FE58-0x000000018C08FF88
		protected virtual void Update() {} // 0x0000000185D4A2F0-0x0000000185D4A440
		private void ChangeEventModule(BaseInputModule module) {} // 0x0000000185D44600-0x0000000185D44750
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
	}

	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, UnityEngine.EventSystems.IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 54971
	{
		// Fields
		private List<Entry> m_Delegates; // 0x18
	
		// Properties
		public List<Entry> delegates { get => default; set {} } // 0x000000018646DB20-0x000000018646DB28 0x000000018C090358-0x000000018C0903DC
		public List<Entry> triggers { get => default; set {} } // 0x000000018C090158-0x000000018C090240 0x000000018C0902E0-0x000000018C0902F0
	
		// Nested types
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 54969
		{
			// Constructors
			public TriggerEvent() {} // 0x000000018C090350-0x000000018C090358
		}
	
		[Serializable]
		public class Entry // TypeDefIndex: 54970
		{
			// Fields
			public EventTriggerType eventID; // 0x10
			public TriggerEvent callback; // 0x18
	
			// Constructors
			public Entry() {} // 0x0000000184088E70-0x0000000184088E80
		}
	
		// Constructors
		protected EventTrigger() {} // 0x0000000184088E70-0x0000000184088E80
	
		// Methods
		private void Execute(EventTriggerType id, BaseEventData eventData) {} // 0x000000018C0902F0-0x000000018C090300
		public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x000000018C090270-0x000000018C090280
		public virtual void OnPointerExit(PointerEventData eventData) {} // 0x000000018C090280-0x000000018C090290
		public virtual void OnDrag(PointerEventData eventData) {} // 0x000000018C0902D0-0x000000018C0902E0
		public virtual void OnDrop(PointerEventData eventData) {} // 0x000000018C090300-0x000000018C090310
		public virtual void OnPointerDown(PointerEventData eventData) {} // 0x000000018C0902C0-0x000000018C0902D0
		public virtual void OnPointerUp(PointerEventData eventData) {} // 0x000000018C090320-0x000000018C090330
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x000000018C090260-0x000000018C090270
		public virtual void OnSelect(BaseEventData eventData) {} // 0x000000018C090310-0x000000018C090320
		public virtual void OnDeselect(BaseEventData eventData) {} // 0x000000018C0902B0-0x000000018C0902C0
		public virtual void OnScroll(PointerEventData eventData) {} // 0x000000018C090340-0x000000018C090350
		public virtual void OnMove(AxisEventData eventData) {} // 0x000000018C0902A0-0x000000018C0902B0
		public virtual void OnUpdateSelected(BaseEventData eventData) {} // 0x000000018C090240-0x000000018C090250
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x000000018C090290-0x000000018C0902A0
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x000000018C090330-0x000000018C090340
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x000000018C090250-0x000000018C090260
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x000000018C09BE18-0x000000018C09BE54
		public virtual void OnCancel(BaseEventData eventData) {} // 0x000000018C08F82C-0x000000018C08F898
	}

	public enum EventTriggerType // TypeDefIndex: 54972
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

	public static class ExecuteEvents // TypeDefIndex: 54974
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
		public static EventFunction<IPointerMoveHandler> pointerMoveHandler { get; } // 0x000000018C0909C4-0x000000018C090A14 
		public static EventFunction<IPointerEnterHandler> pointerEnterHandler { get; } // 0x000000018C090834-0x000000018C090884 
		public static EventFunction<IPointerExitHandler> pointerExitHandler { get; } // 0x000000018C090794-0x000000018C0907E4 
		public static EventFunction<IPointerDownHandler> pointerDownHandler { get; } // 0x000000018C0905B0-0x000000018C090600 
		public static EventFunction<IPointerUpHandler> pointerUpHandler { get; } // 0x000000018C0906A4-0x000000018C0906F4 
		public static EventFunction<IPointerClickHandler> pointerClickHandler { get; } // 0x000000018C090744-0x000000018C090794 
		public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; } // 0x000000018C0906F4-0x000000018C090744 
		public static EventFunction<IBeginDragHandler> beginDragHandler { get; } // 0x000000018C090A14-0x000000018C090A64 
		public static EventFunction<IDragHandler> dragHandler { get; } // 0x000000018C090B08-0x000000018C090B58 
		public static EventFunction<IEndDragHandler> endDragHandler { get; } // 0x000000018C090A64-0x000000018C090AB4 
		public static EventFunction<IDropHandler> dropHandler { get; } // 0x000000018C090654-0x000000018C0906A4 
		public static EventFunction<UnityEngine.EventSystems.IScrollHandler> scrollHandler { get; } // 0x000000018C0907E4-0x000000018C090834 
		public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; } // 0x000000018C090AB4-0x000000018C090B08 
		public static EventFunction<ISelectHandler> selectHandler { get; } // 0x000000018C090600-0x000000018C090654 
		public static EventFunction<IDeselectHandler> deselectHandler { get; } // 0x000000018528BAD0-0x000000018528BBE0 
		public static EventFunction<IMoveHandler> moveHandler { get; }
		public static EventFunction<ISubmitHandler> submitHandler { get; }
		public static EventFunction<ICancelHandler> cancelHandler { get; }
	
		// Nested types
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData); // TypeDefIndex: 54973; 0x000000018C0903F4-0x000000018C0904B0
	
		// Constructors
		static ExecuteEvents() {}
	
		// Methods
		public static T ValidateEventData<T>(BaseEventData data)
			where T : class => default; // 0x000000018467D3D0-0x0000000184680910
		private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) {} // 0x000000018467D350-0x000000018467D3D0
		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) {} // 0x0000000184FBF730-0x0000000184FBF8F0
		private static void Execute(IPointerExitHandler handler, BaseEventData eventData) {} // 0x0000000185D74180-0x0000000185D74240
		private static void Execute(IPointerDownHandler handler, BaseEventData eventData) {} // 0x0000000185B36E40-0x0000000185B36F00
		private static void Execute(IPointerUpHandler handler, BaseEventData eventData) {} // 0x0000000185727DD0-0x0000000185727EB0
		private static void Execute(IPointerClickHandler handler, BaseEventData eventData) {} // 0x0000000185BA6640-0x0000000185BA6700
		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) {} // 0x000000018C0904C8-0x000000018C09053C
		private static void Execute(IBeginDragHandler handler, BaseEventData eventData) {} // 0x000000018467B2D0-0x000000018467B350
		private static void Execute(IDragHandler handler, BaseEventData eventData) {} // 0x0000000184A14980-0x0000000184A151C0
		private static void Execute(IEndDragHandler handler, BaseEventData eventData) {} // 0x0000000185F37900-0x0000000185F38840
		private static void Execute(IDropHandler handler, BaseEventData eventData) {} // 0x0000000185F0F870-0x0000000185F10980
		private static void Execute(UnityEngine.EventSystems.IScrollHandler handler, BaseEventData eventData) {} // 0x000000018C09053C-0x000000018C0905B0
		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) {} // 0x000000018C0904B0-0x000000018C0904C8
		private static void Execute(ISelectHandler handler, BaseEventData eventData) {} // 0x000000018C0903DC-0x000000018C0903F4
		private static void Execute(IDeselectHandler handler, BaseEventData eventData) {} // 0x000000018C090974-0x000000018C0909C4
		private static void Execute(IMoveHandler handler, BaseEventData eventData) {} // 0x000000018C0908D4-0x000000018C090924
		private static void Execute(ISubmitHandler handler, BaseEventData eventData) {} // 0x000000018C090924-0x000000018C090974
		private static void Execute(ICancelHandler handler, BaseEventData eventData) {} // 0x000000018C090884-0x000000018C0908D4
		private static void GetEventChain(GameObject root, IList<Transform> eventChain) {}
		public static bool Execute<T>(GameObject target, BaseEventData eventData, EventFunction<T> functor)
			where T : IEventSystemHandler => default;
		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction)
			where T : IEventSystemHandler => default;
		private static bool ShouldSendToComponent<T>(Component component)
			where T : IEventSystemHandler => default; // 0x0000000185843A30-0x0000000185844280
		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results)
			where T : IEventSystemHandler {}
		public static bool CanHandleEvent<T>(GameObject go)
			where T : IEventSystemHandler => default;
		public static GameObject GetEventHandler<T>(GameObject root)
			where T : IEventSystemHandler => default;
	}

	public class BaseInput : UIBehaviour // TypeDefIndex: 54975
	{
		// Properties
		public virtual string compositionString { get => default; } // 0x00000001857D81C0-0x00000001857D81D0 
		public virtual IMECompositionMode imeCompositionMode { get => default; set {} } // 0x000000018C08F32C-0x000000018C08F334 0x00000001864743C4-0x00000001864743D0
		public virtual Vector2 compositionCursorPos { get => default; set {} } // 0x000000018C08F324-0x000000018C08F32C 0x000000018C08F36C-0x000000018C08F388
		public virtual bool mousePresent { get => default; } // 0x000000018BF8D9B4-0x000000018BF8D9BC 
		public virtual Vector2 mousePosition { get => default; } // 0x000000018C08F334-0x000000018C08F35C 
		public virtual Vector2 mouseScrollDelta { get => default; } // 0x000000018C08F35C-0x000000018C08F364 
		public virtual bool touchSupported { get => default; } // 0x000000018C08F364-0x000000018C08F36C 
		public virtual int touchCount { get => default; } // 0x000000018AAE1FA4-0x000000018AAE1FAC 
	
		// Constructors
		public BaseInput() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public virtual bool GetMouseButtonDown(int button) => default; // 0x000000018C08F300-0x000000018C08F30C
		public virtual bool GetMouseButtonUp(int button) => default; // 0x000000018C08F30C-0x000000018C08F318
		public virtual bool GetMouseButton(int button) => default; // 0x000000018C08F318-0x000000018C08F324
		public virtual Touch GetTouch(int index) => default; // 0x000000018B561B58-0x000000018B561BA0
		public virtual float GetAxisRaw(string axisName) => default; // 0x000000018C08F2F4-0x000000018C08F300
		public virtual bool GetButtonDown(string buttonName) => default; // 0x000000018BF8D9A8-0x000000018BF8D9B4
	}

	public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 54976
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
		public BaseInput input { get; } // 0x0000000183FB49D0-0x0000000183FB4B60 
		public BaseInput inputOverride { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		protected EventSystem eventSystem { get; } // 0x00000001813B8590-0x00000001813B85A0 
	
		// Constructors
		protected BaseInputModule() {} // 0x00000001857EEDE0-0x00000001857EEE60
	
		// Methods
		protected override void OnEnable() {} // 0x00000001858C8A30-0x00000001858C8A90
		protected override void OnDisable() {} // 0x000000018C08F2D4-0x000000018C08F2F4
		public abstract void Process();
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) => default; // 0x00000001842129F0-0x0000000184212C30
		protected static MoveDirection DetermineMoveDirection(float x, float y) => default; // 0x000000018C08EB10-0x000000018C08EB20
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) => default; // 0x000000018C08EAA0-0x000000018C08EB10
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) => default; // 0x000000018420FE30-0x0000000184210130
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) {} // 0x000000018C08EC08-0x000000018C08F2D4
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) => default; // 0x000000018C08EB20-0x000000018C08EC08
		protected virtual BaseEventData GetBaseEventData() => default; // 0x00000001845E30A0-0x00000001845E3130
		public virtual bool IsPointerOverGameObject(int pointerId) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public virtual bool ShouldActivateModule() => default; // 0x0000000184FE10F0-0x0000000184FE1160
		public virtual void DeactivateModule() {} // 0x0000000185492010-0x0000000185492020
		public virtual void ActivateModule() {} // 0x0000000185492010-0x0000000185492020
		public virtual void UpdateModule() {} // 0x0000000185492010-0x0000000185492020
		public virtual bool IsModuleSupported() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) => default; // 0x000000018C08EA24-0x000000018C08EAA0
	}

	public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 54980
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x0207BA93
		public const int kMouseRightId = -2; // Metadata: 0x0207BA94
		public const int kMouseMiddleId = -3; // Metadata: 0x0207BA95
		public const int kFakeTouchesId = -4; // Metadata: 0x0207BA96
		protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
		private readonly MouseState m_MouseState; // 0x50
	
		// Nested types
		protected class ButtonState // TypeDefIndex: 54977
		{
			// Fields
			private PointerEventData.InputButton m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get => default; set {} } // 0x000000018C095558-0x000000018C09564C 0x000000018C095C74-0x000000018C095CD0
			public PointerEventData.InputButton button { get => default; set {} } // 0x000000018C09564C-0x000000018C0959A0 0x000000018C094EF0-0x000000018C095070
	
			// Constructors
			public ButtonState() {} // 0x000000018C095CD0-0x000000018C095D48
		}
	
		protected class MouseState // TypeDefIndex: 54978
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState() {} // 0x000000018C095C28-0x000000018C095C74
	
			// Methods
			public bool AnyPressesThisFrame() => default; // 0x000000018C095164-0x000000018C095170
			public bool AnyReleasesThisFrame() => default; // 0x000000018C095170-0x000000018C095558
			public ButtonState GetButtonState(PointerEventData.InputButton button) => default; // 0x000000018C09513C-0x000000018C095164
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) {} // 0x000000018B50FCD0-0x000000018B50FD10
		}
	
		public class MouseButtonEventData // TypeDefIndex: 54979
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData() {} // 0x000000018C094D40-0x000000018C094EF0
	
			// Methods
			public bool PressedThisFrame() => default; // 0x000000018C095A08-0x000000018C095C28
			public bool ReleasedThisFrame() => default; // 0x000000018C0959A0-0x000000018C095A08
		}
	
		// Constructors
		protected PointerInputModule() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected bool GetPointerData(int id, out PointerEventData data, bool create) {
			data = default;
			return default;
		} // 0x000000018C095D48-0x000000018C095FDC
		protected void RemovePointerData(PointerEventData data) {} // 0x000000018C095070-0x000000018C09513C
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) {
			pressed = default;
			released = default;
			return default;
		} // 0x000000018C095FDC-0x000000018C096094
		protected void CopyFromTo(PointerEventData from, PointerEventData to) {} // 0x0000000181377E40-0x0000000181377E50
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId) => default; // 0x0000000184088E70-0x0000000184088E80
		protected virtual MouseState GetMousePointerEventData() => default; // 0x0000000181C0BBD0-0x0000000181C0BBE0
		protected virtual MouseState GetMousePointerEventData(int id) => default; // 0x0000000181378230-0x0000000181378240
		protected PointerEventData GetLastPointerEventData(int id) => default; // 0x0000000185492010-0x0000000185492020
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) => default; // 0x000000018C090C90-0x000000018C090D30
		protected virtual void ProcessMove(PointerEventData pointerEvent) {} // 0x000000018C090D30-0x000000018C090DD0
		protected virtual void ProcessDrag(PointerEventData pointerEvent) {} // 0x000000018C090DD0-0x000000018C090F08
		public override bool IsPointerOverGameObject(int pointerId) => default; // 0x000000018C090F08-0x000000018C090F58
		protected void ClearSelection() {} // 0x000000018C090F58-0x000000018C090FD0
		public override string ToString() => default; // 0x000000018B50C804-0x000000018B50C818
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) {} // 0x0000000189291CF8-0x0000000189291D0C
	}

	public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 54983
	{
		// Fields
		private float m_PrevActionTime; // 0x58
		private Vector2 m_LastMoveVector; // 0x5C
		private int m_ConsecutiveMoveCount; // 0x64
		private Vector2 m_LastMousePosition; // 0x68
		private Vector2 m_MousePosition; // 0x70
		private GameObject m_CurrentFocusedGameObject; // 0x78
		private PointerEventData m_InputPointerEvent; // 0x80
		private string m_HorizontalAxis; // 0x88
		private string m_VerticalAxis; // 0x90
		private string m_SubmitButton; // 0x98
		private string m_CancelButton; // 0xA0
		private float m_InputActionsPerSecond; // 0xA8
		private float m_RepeatDelay; // 0xAC
		private bool m_ForceModuleActive; // 0xB0
	
		// Properties
		public InputMode inputMode { get => default; } // 0x0000000181B10450-0x0000000181B10460 
		public bool allowActivationOnMobileDevice { get => default; set {} } // 0x0000000181B10460-0x0000000181B10470 0x0000000181B10450-0x0000000181B10460
		public bool forceModuleActive { get => default; set {} } // 0x0000000181B10460-0x0000000181B10470 0x0000000185FB9D40-0x0000000185FB9D50
		public float inputActionsPerSecond { get => default; set {} } // 0x0000000185FCEB60-0x0000000185FCEB70 0x0000000185FB9BB0-0x0000000185FB9BC0
		public float repeatDelay { get => default; set {} } // 0x0000000185FCEB70-0x0000000185FCEB80 0x0000000185FB0510-0x0000000185FB0520
		public string horizontalAxis { get => default; set {} } // 0x0000000186472AA8-0x0000000186472ABC 0x0000000181B5FFD0-0x0000000181B5FFE0
		public string verticalAxis { get => default; set {} } // 0x00000001873CBEA8-0x00000001873CBEBC 0x0000000181E336C0-0x0000000181E336D0
		public string submitButton { get => default; set {} } // 0x00000001873350D4-0x00000001873350E8 0x0000000185FB0520-0x0000000185FB0530
		public string cancelButton { get => default; set {} } // 0x000000018646EBCC-0x000000018646EBE0 0x00000001840A27C0-0x00000001840A27D0
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 54981
		{
			// Fields
			public static readonly ProfilerMarker Process; // 0x00
			public static readonly ProfilerMarker ProcessMouseEvent; // 0x08
			public static readonly ProfilerMarker ProcessMousePress; // 0x10
			public static readonly ProfilerMarker ProcessTouchEvents; // 0x18
			public static readonly ProfilerMarker ProcessTouchPress; // 0x20
	
			// Constructors
			static ProfilerMarkers() {} // 0x000000018C09A0A0-0x000000018C09A174
		}
	
		public enum InputMode // TypeDefIndex: 54982
		{
			Mouse = 0,
			Buttons = 1
		}
	
		// Constructors
		protected StandaloneInputModule() {} // 0x00000001813AE580-0x00000001813AE590
	
		// Methods
		private bool ShouldIgnoreEventsOnNoFocus() => default; // 0x000000018C099F8C-0x000000018C09A0A0
		public override void UpdateModule() {} // 0x000000018C09979C-0x000000018C099A18
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) {} // 0x000000018C099DF4-0x000000018C099F8C
		public override bool ShouldActivateModule() => default; // 0x000000018C0975D8-0x000000018C097700
		public override void ActivateModule() {} // 0x000000018C097700-0x000000018C097708
		public override void DeactivateModule() {} // 0x000000018C099644-0x000000018C09979C
		public override void Process() {} // 0x000000018C097FF0-0x000000018C09822C
		private bool ProcessTouchEvents() => default; // 0x000000018C09822C-0x000000018C099644
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x000000018C099BBC-0x000000018C099D20
		protected bool SendSubmitEventToSelectedObject() => default; // 0x000000018C097708-0x000000018C09780C
		private Vector2 GetRawMoveVector() => default; // 0x000000018C099A18-0x000000018C099BBC
		protected bool SendMoveEventToSelectedObject() => default; // 0x000000018C097A3C-0x000000018C097B04
		protected void ProcessMouseEvent() {} // 0x00000001814A81B0-0x00000001814A81C0
		protected virtual bool ForceAutoSelect() => default; // 0x000000018C09780C-0x000000018C097A3C
		protected void ProcessMouseEvent(int id) {} // 0x000000018C099D20-0x000000018C099DF4
		protected bool SendUpdateEventToSelectedObject() => default; // 0x000000018C097B04-0x000000018C097FF0
		protected void ProcessMousePress(MouseButtonEventData data) {} // 0x0000000183060C50-0x0000000183060C60
		protected GameObject GetCurrentFocusedGameObject() => default; // 0x000000018C0967F8-0x000000018C096938
	}

	public class TouchInputModule : PointerInputModule // TypeDefIndex: 54985
	{
		// Fields
		private Vector2 m_LastMousePosition; // 0x58
		private Vector2 m_MousePosition; // 0x60
		private PointerEventData m_InputPointerEvent; // 0x68
		private bool m_ForceModuleActive; // 0x70
	
		// Properties
		public bool allowActivationOnStandalone { get => default; set {} } // 0x0000000185FB0970-0x0000000185FB0980 0x0000000185FB0950-0x0000000185FB0960
		public bool forceModuleActive { get => default; set {} } // 0x0000000185FB0970-0x0000000185FB0980 0x000000018C09BCB8-0x000000018C09BDEC
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 54984
		{
			// Fields
			public static readonly ProfilerMarker Process; // 0x00
			public static readonly ProfilerMarker ProcessTouchEvents; // 0x08
			public static readonly ProfilerMarker ProcessTouchPress; // 0x10
	
			// Constructors
			static ProfilerMarkers() {} // 0x000000018C09BE10-0x000000018C09BE18
		}
	
		// Constructors
		protected TouchInputModule() {} // 0x0000000185FB0950-0x0000000185FB0960
	
		// Methods
		public override void UpdateModule() {} // 0x000000018C09A264-0x000000018C09A294
		public override bool IsModuleSupported() => default; // 0x000000018C09B964-0x000000018C09BA3C
		public override bool ShouldActivateModule() => default; // 0x000000018C09BDEC-0x000000018C09BE10
		private bool UseFakeInput() => default; // 0x000000018C09B880-0x000000018C09B964
		public override void Process() {} // 0x000000018C09A174-0x000000018C09A264
		private void FakeTouches() {} // 0x000000018C09A294-0x000000018C09A4A8
		private void ProcessTouchEvents() {} // 0x000000018C09A4A8-0x000000018C09B880
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x000000018C097700-0x000000018C097708
		public override void DeactivateModule() {} // 0x000000018C09BA3C-0x000000018C09BCB8
		public override string ToString() => default; // 0x000000018C096724-0x000000018C0967F8
	}

	public enum MoveDirection // TypeDefIndex: 54986
	{
		Left = 0,
		Up = 1,
		Right = 2,
		Down = 3,
		None = 4
	}

	internal static class RaycasterManager // TypeDefIndex: 54987
	{
		// Fields
		private static readonly List<BaseRaycaster> s_Raycasters; // 0x00
	
		// Constructors
		static RaycasterManager() {} // 0x0000000185F3F010-0x0000000185F3F0A0
	
		// Methods
		public static void AddRaycaster(BaseRaycaster baseRaycaster) {} // 0x000000018529B6B0-0x000000018529B790
		public static List<BaseRaycaster> GetRaycasters() => default; // 0x000000018C096FBC-0x000000018C09700C
		public static void RemoveRaycasters(BaseRaycaster baseRaycaster) {} // 0x000000018529B580-0x000000018529B660
	}

	public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 54988
	{
		// Fields
		private BaseRaycaster m_RootRaycaster; // 0x18
	
		// Properties
		public abstract Camera eventCamera { get; }
		public virtual int priority { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual int sortOrderPriority { get; } // 0x0000000185FEAB10-0x0000000185FEAB20 
		public virtual int renderOrderPriority { get; } // 0x0000000185FEAB10-0x0000000185FEAB20 
		public BaseRaycaster rootRaycaster { get; } // 0x0000000185172170-0x00000001851722D0 
	
		// Constructors
		protected BaseRaycaster() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
		public override string ToString() => default; // 0x000000018C08F690-0x000000018C08F82C
		protected override void OnEnable() {} // 0x000000018529B660-0x000000018529B6B0
		protected override void OnDisable() {} // 0x000000018529B530-0x000000018529B580
		protected override void OnCanvasHierarchyChanged() {} // 0x000000018570A480-0x000000018570A4A0
		protected override void OnTransformParentChanged() {} // 0x000000018570A480-0x000000018570A4A0
	}

	public class Physics2DRaycaster : PhysicsRaycaster // TypeDefIndex: 54989
	{
		// Fields
		private RaycastHit2D[] m_Hits; // 0x40
	
		// Constructors
		protected Physics2DRaycaster() {} // 0x000000018C0938A4-0x000000018C0938B4
	
		// Methods
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x000000018C093308-0x000000018C0938A4
	}

	public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 54991
	{
		// Fields
		protected const int kNoEventMaskSet = -1; // Metadata: 0x0207BA9E
		protected Camera m_EventCamera; // 0x20
		protected LayerMask m_EventMask; // 0x28
		protected int m_MaxRayIntersections; // 0x2C
		protected int m_LastMaxRayIntersections; // 0x30
		private RaycastHit[] m_Hits; // 0x38
	
		// Properties
		public override Camera eventCamera { get => default; } // 0x0000000181C9AC80-0x0000000181C9AC90 
		public virtual int depth { get => default; } // 0x0000000181C9A5C0-0x0000000181C9A5D0 
		public int finalEventMask { get => default; } // 0x0000000185FB0630-0x0000000185FB0640 
		public LayerMask eventMask { get => default; set {} } // 0x0000000185FB0640-0x0000000185FB0650 0x000000018C0938B4-0x000000018C093B34
		public int maxRayIntersections { get => default; set {} } // 0x000000018C093B34-0x000000018C093F20 0x000000018C096A40-0x000000018C096A6C
	
		// Nested types
		private class RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 54990
		{
			// Fields
			public static RaycastHitComparer instance; // 0x00
	
			// Constructors
			public RaycastHitComparer() {} // 0x000000018C093FA4-0x000000018C094034
			static RaycastHitComparer() {} // 0x000000018C093F20-0x000000018C093FA4
	
			// Methods
			public int Compare(RaycastHit x, RaycastHit y) => default; // 0x000000018C0938A4-0x000000018C0938B4
		}
	
		// Constructors
		protected PhysicsRaycaster() {} // 0x000000018C094034-0x000000018C0940BC
	
		// Methods
		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) => default; // 0x0000000185492010-0x0000000185492020
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x000000018C096A6C-0x000000018C096AD0
	}

	public struct RaycastResult // TypeDefIndex: 54992
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
		public GameObject gameObject { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public bool isValid { get => default; } // 0x000000018C096F48-0x000000018C096FBC 
	
		// Methods
		public void Clear() {} // 0x000000018C096AD0-0x000000018C096B78
		public override string ToString() => default; // 0x000000018C096B78-0x000000018C096F48
	}

	public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 54993
	{
		// Constructors
		protected UIBehaviour() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected virtual void Awake() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnEnable() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void Start() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDisable() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDestroy() {} // 0x0000000185492010-0x0000000185492020
		public virtual bool IsActive() => default; // 0x0000000183FCDC30-0x0000000183FCDD70
		protected virtual void OnRectTransformDimensionsChange() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnBeforeTransformParentChanged() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnTransformParentChanged() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnDidApplyAnimationProperties() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnCanvasHierarchyChanged() {} // 0x0000000185492010-0x0000000185492020
		public bool IsDestroyed() => default; // 0x000000018423E110-0x000000018423E1D0
	}
}

namespace UnityEngine.UI
{
	[Serializable]
	public class AnimationTriggers // TypeDefIndex: 54786
	{
		// Fields
		private const string kDefaultNormalAnimName = "Normal"; // Metadata: 0x0207B948
		private const string kDefaultHighlightedAnimName = "Highlighted"; // Metadata: 0x0207B94F
		private const string kDefaultPressedAnimName = "Pressed"; // Metadata: 0x0207B95B
		private const string kDefaultSelectedAnimName = "Selected"; // Metadata: 0x0207B963
		private const string kDefaultDisabledAnimName = "Disabled"; // Metadata: 0x0207B96C
		private string m_NormalTrigger; // 0x10
		private string m_HighlightedTrigger; // 0x18
		private string m_PressedTrigger; // 0x20
		private string m_SelectedTrigger; // 0x28
		private string m_DisabledTrigger; // 0x30
	
		// Properties
		public string normalTrigger { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public string highlightedTrigger { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public string pressedTrigger { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public string selectedTrigger { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x0000000184A4EDC0-0x0000000184A4EDD0
		public string disabledTrigger { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
	
		// Constructors
		public AnimationTriggers() {} // 0x0000000184817910-0x00000001848179E0
	}

	public class Button : Selectable, IPointerClickHandler, ISubmitHandler // TypeDefIndex: 54789
	{
		// Fields
		private ButtonClickedEvent m_OnClick; // 0x180
	
		// Properties
		public ButtonClickedEvent onClick { get => default; set {} } // 0x0000000181378230-0x0000000181378240 0x0000000185492010-0x0000000185492020
	
		// Nested types
		[Serializable]
		public class ButtonClickedEvent : UnityEvent // TypeDefIndex: 54787
		{
			// Constructors
			public ButtonClickedEvent() {} // 0x000000018BF744F0-0x000000018BF7457C
		}
	
		private sealed class _OnFinishSubmit_d__9 : IEnumerator<object> // TypeDefIndex: 54788
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Button __4__this; // 0x20
			private float _fadeTime_5__2; // 0x28
			private float _elapsedTime_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BF743EC-0x000000018BF74414 
			object IEnumerator.Current { get => default; } // 0x000000018BF74390-0x000000018BF743EC 
	
			// Constructors
			public _OnFinishSubmit_d__9() {} // Dummy constructor
			public _OnFinishSubmit_d__9(int __1__state) {} // 0x0000000185FB8280-0x0000000185FB8290
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018647352C-0x0000000186473540
			private bool MoveNext() => default; // 0x000000018BF74478-0x000000018BF744F0
			void IEnumerator.Reset() {} // 0x000000018BF74414-0x000000018BF74478
		}
	
		// Constructors
		protected Button() {} // 0x0000000186470378-0x0000000186470380
	
		// Methods
		private void Press() {} // 0x000000018BF7E758-0x000000018BF7E84C
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000181377E40-0x0000000181377E50
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x000000018BF7E84C-0x000000018BF7E898
		private IEnumerator OnFinishSubmit() => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public enum CanvasUpdate // TypeDefIndex: 54790
	{
		Prelayout = 0,
		Layout = 1,
		PostLayout = 2,
		PreRender = 3,
		LatePreRender = 4,
		MaxUpdateValue = 5
	}

	public interface ICanvasElement // TypeDefIndex: 54791
	{
		// Properties
		Transform transform { get; }
	
		// Methods
		void Rebuild(CanvasUpdate executing);
		void LayoutComplete();
		void GraphicUpdateComplete();
		bool IsDestroyed();
	}

	public class CanvasUpdateRegistry // TypeDefIndex: 54792
	{
		// Fields
		private static CanvasUpdateRegistry s_Instance; // 0x00
		private bool m_PerformingLayoutUpdate; // 0x10
		private bool m_PerformingGraphicUpdate; // 0x11
		private ProfilerMarker[] m_CanvasUpdateProfilerStrings; // 0x18
		private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull"; // Metadata: 0x0207B97B
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x08
	
		// Properties
		public static CanvasUpdateRegistry instance { get => default; } // 0x000000018423F590-0x000000018423F690 
	
		// Constructors
		protected CanvasUpdateRegistry() {} // 0x00000001845A2A40-0x00000001845A2C90
		static CanvasUpdateRegistry() {} // 0x0000000185F142D0-0x0000000185F14370
	
		// Methods
		private bool ObjectValidForUpdate(ICanvasElement element) => default; // 0x000000018423D8D0-0x000000018423E110
		private void CleanInvalidItems() {} // 0x000000018423CC70-0x000000018423CE70
		private void PerformUpdate() {} // 0x000000018423CE70-0x000000018423D8D0
		private static int ParentCount(Transform child) => default; // 0x0000000184B989C0-0x0000000184B98BC0
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y) => default; // 0x0000000184B98850-0x0000000184B989C0
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) {} // 0x00000001854F9F70-0x00000001854F9FE0
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) => default; // 0x000000018423E9D0-0x000000018423EB30
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) => default; // 0x000000018423F8A0-0x000000018423FA70
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) {} // 0x000000018423F250-0x000000018423F590
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) => default; // 0x000000018BF7457C-0x000000018BF745D4
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) => default; // 0x000000018423F690-0x000000018423F8A0
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) {} // 0x000000018423E690-0x000000018423E710
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) {} // 0x000000018423E250-0x000000018423E410
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) {} // 0x000000018423E410-0x000000018423E5D0
		public static bool IsRebuildingLayout() => default; // 0x000000018423E5D0-0x000000018423E630
		public static bool IsRebuildingGraphics() => default; // 0x000000018423E630-0x000000018423E690
	}

	[Serializable]
	public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 54793
	{
		// Fields
		private UnityEngine.Color m_NormalColor; // 0x00
		private UnityEngine.Color m_HighlightedColor; // 0x10
		private UnityEngine.Color m_PressedColor; // 0x20
		private UnityEngine.Color m_SelectedColor; // 0x30
		private UnityEngine.Color m_DisabledColor; // 0x40
		private float m_ColorMultiplier; // 0x50
		private float m_FadeDuration; // 0x54
		public static ColorBlock defaultColorBlock; // 0x00
	
		// Properties
		public UnityEngine.Color normalColor { get => default; set {} } // 0x0000000181D61820-0x0000000181D61830 0x0000000185FBFA60-0x0000000185FBFA70
		public UnityEngine.Color highlightedColor { get => default; set {} } // 0x00000001834A7540-0x00000001834A7550 0x0000000185FB6860-0x0000000185FB6870
		public UnityEngine.Color pressedColor { get => default; set {} } // 0x0000000185FB6120-0x0000000185FB6130 0x0000000185FB6130-0x0000000185FB6140
		public UnityEngine.Color selectedColor { get => default; set {} } // 0x0000000185FB1290-0x0000000185FB12A0 0x0000000185FB12A0-0x0000000185FB12B0
		public UnityEngine.Color disabledColor { get => default; set {} } // 0x0000000185FBBFF0-0x0000000185FBC000 0x0000000185FBEB30-0x0000000185FBEB40
		public float colorMultiplier { get => default; set {} } // 0x0000000185FB3000-0x0000000185FB3010 0x0000000185FB3010-0x0000000185FB3020
		public float fadeDuration { get => default; set {} } // 0x0000000183F80440-0x0000000183F80450 0x0000000183F804D0-0x0000000183F804E0
	
		// Constructors
		static ColorBlock() {
			defaultColorBlock = default;
		} // 0x00000001857E05A0-0x00000001857E0750
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BF745D4-0x000000018BF74684
		public bool Equals(ColorBlock other) => default; // 0x000000018BF74684-0x000000018BF74808
		public static bool operator ==(ColorBlock point1, ColorBlock point2) => default; // 0x000000018BF7488C-0x000000018BF74920
		public static bool operator !=(ColorBlock point1, ColorBlock point2) => default; // 0x000000018BF74920-0x000000018BF749B8
		public override int GetHashCode() => default; // 0x000000018BF74808-0x000000018BF7488C
	}

	public class ClipperRegistry // TypeDefIndex: 54794
	{
		// Fields
		private static ClipperRegistry s_Instance; // 0x00
		private readonly IndexedSet<IClipper> m_Clippers; // 0x10
		private readonly ProfilerMarker clippersMarker; // 0x18
	
		// Properties
		public static ClipperRegistry instance { get => default; } // 0x0000000183FCB1A0-0x0000000183FCB240 
	
		// Constructors
		protected ClipperRegistry() {} // 0x0000000183FCA130-0x0000000183FCA1E0
	
		// Methods
		public void Cull() {} // 0x0000000184BE81C0-0x0000000184BE8320
		public static void Register(IClipper c) {} // 0x0000000183FCB130-0x0000000183FCB1A0
		public static void Unregister(IClipper c) {} // 0x0000000183FCB0A0-0x0000000183FCB100
	}

	public static class Clipping // TypeDefIndex: 54795
	{
		// Methods
		public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect) {
			validRect = default;
			return default;
		} // 0x00000001840E2400-0x00000001840E2990
	}

	public interface IClipper // TypeDefIndex: 54796
	{
		// Methods
		void PerformClipping();
	}

	public interface IClippable // TypeDefIndex: 54797
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

	internal class RectangularVertexClipper // TypeDefIndex: 54798
	{
		// Fields
		private readonly Vector3[] m_WorldCorners; // 0x10
		private readonly Vector3[] m_CanvasCorners; // 0x18
	
		// Constructors
		public RectangularVertexClipper() {} // 0x000000018521A250-0x000000018521A2C0
	
		// Methods
		public Rect GetCanvasRect(RectTransform t, Canvas c) => default; // 0x00000001840E8190-0x00000001840E87E0
	}

	public static class DefaultControls // TypeDefIndex: 54802
	{
		// Fields
		private static IFactoryControls m_CurrentFactory; // 0x00
		private const float kWidth = 160f; // Metadata: 0x0207B990
		private const float kThickHeight = 30f; // Metadata: 0x0207B994
		private const float kThinHeight = 20f; // Metadata: 0x0207B998
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static Vector2 s_ImageElementSize; // 0x18
		private static UnityEngine.Color s_DefaultSelectableColor; // 0x20
		private static UnityEngine.Color s_PanelColor; // 0x30
		private static UnityEngine.Color s_TextColor; // 0x40
	
		// Properties
		public static IFactoryControls factory { get; } // 0x000000018BF78374-0x000000018BF783C4 
	
		// Nested types
		public interface IFactoryControls // TypeDefIndex: 54799
		{
			// Methods
			GameObject CreateGameObject(string name, System.Type[] components); // 0x000000018BF7871C-0x000000018BF7876C
		}
	
		private class DefaultRuntimeFactory : IFactoryControls // TypeDefIndex: 54800
		{
			// Fields
			public static IFactoryControls Default; // 0x00
	
			// Constructors
			public DefaultRuntimeFactory() {} // 0x000000018BF782F0-0x000000018BF78374
			static DefaultRuntimeFactory() {} // 0x000000018BF783C4-0x000000018BF7847C
	
			// Methods
			public GameObject CreateGameObject(string name, System.Type[] components) => default; // 0x000000018BF78244-0x000000018BF782F0
		}
	
		public struct Resources // TypeDefIndex: 54801
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
		static DefaultControls() {} // 0x000000018BF787DC-0x000000018BF78840
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size, System.Type[] components) => default; // 0x000000018BF7853C-0x000000018BF78608
		private static GameObject CreateUIObject(string name, GameObject parent, System.Type[] components) => default; // 0x000000018BF7847C-0x000000018BF7853C
		private static void SetDefaultTextValues(Text lbl) {} // 0x000000018BF764E8-0x000000018BF76718
		private static void SetDefaultColorTransitionValues(Selectable slider) {} // 0x000000018BF749B8-0x000000018BF74D14
		private static void SetParentAndAlign(GameObject child, GameObject parent) {} // 0x000000018BF77B20-0x000000018BF77C84
		private static void SetLayerRecursively(GameObject go, int layer) {} // 0x000000018BF75E4C-0x000000018BF75F58
		public static GameObject CreatePanel(Resources resources) => default; // 0x000000018BF76718-0x000000018BF76824
		public static GameObject CreateButton(Resources resources) => default; // 0x000000018BF773D4-0x000000018BF77B20
		public static GameObject CreateText(Resources resources) => default; // 0x000000018BF76F80-0x000000018BF773D4
		public static GameObject CreateImage(Resources resources) => default; // 0x000000018BF77C84-0x000000018BF78244
		public static GameObject CreateRawImage(Resources resources) => default; // 0x000000018BF75F58-0x000000018BF764E8
		public static GameObject CreateSlider(Resources resources) => default; // 0x000000018BF74D14-0x000000018BF75E4C
		public static GameObject CreateScrollbar(Resources resources) => default; // 0x000000018BF76824-0x000000018BF76F80
		public static GameObject CreateToggle(Resources resources) => default; // 0x000000018BF78608-0x000000018BF7871C
		public static GameObject CreateInputField(Resources resources) => default;
		public static GameObject CreateDropdown(Resources resources) => default; // 0x000000018BF7876C-0x000000018BF787DC
		public static GameObject CreateScrollView(Resources resources) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 54809
	{
		// Fields
		private RectTransform m_Template; // 0x180
		private Text m_CaptionText; // 0x188
		private Image m_CaptionImage; // 0x190
		private Text m_ItemText; // 0x198
		private Image m_ItemImage; // 0x1A0
		private int m_Value; // 0x1A8
		private OptionDataList m_Options; // 0x1B0
		private DropdownEvent m_OnValueChanged; // 0x1B8
		private float m_AlphaFadeSpeed; // 0x1C0
		private GameObject m_Dropdown; // 0x1C8
		private GameObject m_Blocker; // 0x1D0
		private List<DropdownItem> m_Items; // 0x1D8
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x1E0
		private bool validTemplate; // 0x1E8
		private const int kHighSortingLayer = 30000; // Metadata: 0x0207B99D
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get => default; set {} } // 0x000000018BF79A6C-0x000000018BF79A74 0x000000018BF79A6C-0x000000018BF79A74
		public Text captionText { get => default; set {} } // 0x000000018BF799D0-0x000000018BF799D8 0x000000018BF7A544-0x000000018BF7B2F0
		public Image captionImage { get => default; set {} } // 0x000000018BF791AC-0x000000018BF795E0 0x000000018BF796F4-0x000000018BF79740
		public Text itemText { get => default; set {} } // 0x000000018BF795E0-0x000000018BF79634 0x000000018BF79740-0x000000018BF7978C
		public Image itemImage { get => default; set {} } // 0x000000018BF79634-0x000000018BF79688 0x0000000185492010-0x0000000185492020
		public List<OptionData> options { get => default; set {} } // 0x000000018BF78960-0x000000018BF78BEC 0x000000018BF78FD8-0x000000018BF79064
		public DropdownEvent onValueChanged { get => default; set {} } // 0x000000018BF78E5C-0x000000018BF78FD8 0x000000018BF79D60-0x000000018BF79E00
		public float alphaFadeSpeed { get => default; set {} } // 0x000000018BF7978C-0x000000018BF79880 0x000000018BF79688-0x000000018BF796F4
		public int value { get => default; set {} } // 0x000000018BF79880-0x000000018BF799D0 0x000000018BF79A74-0x000000018BF79B7C
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 54803
		{
			// Fields
			private Text m_Text; // 0x18
			private Image m_Image; // 0x20
			private RectTransform m_RectTransform; // 0x28
			private Toggle m_Toggle; // 0x30
	
			// Properties
			public Text text { get => default; set {} } // 0x0000000185FB8280-0x0000000185FB8290 0x000000018BF7B60C-0x000000018BF7B634
			public Image image { get => default; set {} } // 0x0000000185FB8360-0x0000000185FB8370 0x000000018BF7B560-0x000000018BF7B588
			public RectTransform rectTransform { get => default; set {} } // 0x0000000181B44930-0x0000000181B44940 0x000000018BF7B538-0x000000018BF7B560
			public Toggle toggle { get => default; set {} } // 0x0000000185FB88A0-0x0000000185FB88B0 0x000000018BF7B5B0-0x000000018BF7B5D8
	
			// Constructors
			public DropdownItem() {} // 0x000000018BF7B518-0x000000018BF7B538
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x0000000185FB82F0-0x0000000185FB8300
			public virtual void OnCancel(BaseEventData eventData) {} // 0x000000018BF7B588-0x000000018BF7B5B0
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 54804
		{
			// Fields
			private string m_Text; // 0x10
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get => default; set {} } // 0x000000018BF7B5D8-0x000000018BF7B60C 0x0000000181BE0A10-0x0000000181BE0A20
			public Sprite image { get => default; set {} } // 0x0000000186473484-0x0000000186473498 0x0000000185FBAB30-0x0000000185FBAB40
	
			// Constructors
			public OptionData() {} // 0x0000000185FE92A0-0x0000000185FE92B0
			public OptionData(string text) {} // 0x0000000185FBCFB0-0x0000000185FBCFC0
			public OptionData(Sprite image) {} // 0x000000018BF7B634-0x000000018BF7B640
			public OptionData(string text, Sprite image) {} // 0x000000018BF79E00-0x000000018BF79E0C
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 54805
		{
			// Fields
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get => default; set {} } // 0x000000018BF79E0C-0x000000018BF79EFC 0x000000018BF7B3F0-0x000000018BF7B518
	
			// Constructors
			public OptionDataList() {} // 0x000000018BF79064-0x000000018BF7914C
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 54806
		{
			// Constructors
			public DropdownEvent() {} // 0x000000018BF7B2F0-0x000000018BF7B380
		}
	
		private sealed class __c__DisplayClass63_0 // TypeDefIndex: 54807
		{
			// Fields
			public DropdownItem item; // 0x10
			public Dropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass63_0() {} // 0x000000018BF799D8-0x000000018BF79A6C
	
			// Methods
			internal void _Show_b__0(bool x) {} // 0x000000018BF79B7C-0x000000018BF79D60
		}
	
		private sealed class _DelayedDestroyDropdownList_d__75 : IEnumerator<object> // TypeDefIndex: 54808
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float delay; // 0x20
			public Dropdown __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BF7914C-0x000000018BF791AC 
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _DelayedDestroyDropdownList_d__75() {} // Dummy constructor
			public _DelayedDestroyDropdownList_d__75(int __1__state) {} // 0x000000018BF78DF4-0x000000018BF78E5C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BF78BEC-0x000000018BF78CF0
			private bool MoveNext() => default; // 0x000000018BF78CF0-0x000000018BF78DF4
			void IEnumerator.Reset() {} // 0x000000018BF79EFC-0x000000018BF7A544
		}
	
		// Constructors
		protected Dropdown() {} // 0x0000000184088E70-0x0000000184088E80
		static Dropdown() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void SetValueWithoutNotify(int input) {} // 0x000000018BF7B380-0x000000018BF7B3F0
		private void Set(int value, bool sendCallback = true /* Metadata: 0x0207B99C */) {} // 0x0000000181377E40-0x0000000181377E50
		protected override void Awake() {} // 0x00000001813B31A0-0x00000001813B31B0
		protected override void Start() {} // 0x000000018646EE40-0x000000018646EE50
		protected override void OnDisable() {} // 0x00000001813B8590-0x00000001813B85A0
		public void RefreshShownValue() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		public void AddOptions(List<OptionData> options) {} // 0x00000001813B51D0-0x00000001813B51E0
		public void AddOptions(List<string> options) {} // 0x00000001864721F0-0x0000000186472200
		public void AddOptions(List<Sprite> options) {} // 0x000000018BF788F4-0x000000018BF78960
		public void ClearOptions() {} // 0x000000018BF7887C-0x000000018BF788F4
		private void SetupTemplate(Canvas rootCanvas) {} // 0x000000018646DB20-0x000000018646DB28
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component => default; // 0x000000018346D130-0x000000018346D140
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000184096E30-0x0000000184096EF0
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000181377E40-0x0000000181377E50
		public virtual void OnCancel(BaseEventData eventData) {} // 0x0000000184088E70-0x0000000184088E80
		public void Show() {} // 0x0000000185492010-0x0000000185492020
		protected virtual GameObject CreateBlocker(Canvas rootCanvas) => default; // 0x0000000184096E30-0x0000000184096EF0
		protected virtual void DestroyBlocker(GameObject blocker) {} // 0x0000000184088E70-0x0000000184088E80
		protected virtual GameObject CreateDropdownList(GameObject template) => default; // 0x00000001841BC230-0x00000001841BC260
		protected virtual void DestroyDropdownList(GameObject dropdownList) {} // 0x000000018346D130-0x000000018346D140
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate) => default; // 0x0000000184096E30-0x0000000184096EF0
		protected virtual void DestroyItem(DropdownItem item) {} // 0x000000018BF7E5F8-0x000000018BF7E670
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) => default; // 0x000000018BF78840-0x000000018BF7887C
		private void AlphaFadeList(float duration, float alpha) {} // 0x0000000185492010-0x0000000185492020
		private void AlphaFadeList(float duration, float start, float end) {} // 0x000000018BF7E898-0x000000018BF7EFAC
		private void SetAlpha(float alpha) {} // 0x0000000181378230-0x0000000181378240
		public void Hide() {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator DelayedDestroyDropdownList(float delay) => default; // 0x000000018BF7E670-0x000000018BF7E70C
		private void ImmediateDestroyDropdownList() {} // 0x0000000181377E40-0x0000000181377E50
		private void OnSelectItem(Toggle toggle) {} // 0x000000018BF7E70C-0x000000018BF7E758
	}

	[Serializable]
	public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 54810
	{
		// Fields
		private Font m_Font; // 0x10
		private int m_FontSize; // 0x18
		private FontStyle m_FontStyle; // 0x1C
		private bool m_BestFit; // 0x20
		private int m_MinSize; // 0x24
		private int m_MaxSize; // 0x28
		private TextAnchor m_Alignment; // 0x2C
		private bool m_AlignByGeometry; // 0x30
		private bool m_RichText; // 0x31
		private HorizontalWrapMode m_HorizontalOverflow; // 0x34
		private VerticalWrapMode m_VerticalOverflow; // 0x38
		private float m_LineSpacing; // 0x3C
	
		// Properties
		public static FontData defaultFontData { get => default; } // 0x000000018BF7B68C-0x000000018BF7B700 
		public Font font { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public int fontSize { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public FontStyle fontStyle { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x00000001813AE9D0-0x00000001813AE9E0
		public bool bestFit { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x00000001813EE9B0-0x00000001813EE9C0
		public int minSize { get => default; set {} } // 0x0000000181424480-0x0000000181424490 0x0000000181424940-0x0000000181424950
		public int maxSize { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
		public TextAnchor alignment { get => default; set {} } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
		public bool alignByGeometry { get => default; set {} } // 0x00000001814294C0-0x00000001814294D0 0x000000018142A360-0x000000018142A370
		public bool richText { get => default; set {} } // 0x0000000185FB0980-0x0000000185FB0990 0x0000000185FB0990-0x0000000185FB09A0
		public HorizontalWrapMode horizontalOverflow { get => default; set {} } // 0x0000000185FB07C0-0x0000000185FB07D0 0x0000000185FB07E0-0x0000000185FB07F0
		public VerticalWrapMode verticalOverflow { get => default; set {} } // 0x00000001813E5E30-0x00000001813E5E40 0x00000001813E6F50-0x00000001813E6F60
		public float lineSpacing { get => default; set {} } // 0x0000000185FB0580-0x0000000185FB0590 0x0000000185FB05E0-0x0000000185FB05F0
	
		// Constructors
		public FontData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018BF7B640-0x000000018BF7B68C
	}

	public static class FontUpdateTracker // TypeDefIndex: 54811
	{
		// Fields
		private static Dictionary<Font, HashSet<Text>> m_Tracked; // 0x00
	
		// Constructors
		static FontUpdateTracker() {} // 0x000000018BF7BC74-0x000000018BF7BD00
	
		// Methods
		public static void TrackText(Text t) {} // 0x000000018BF7B870-0x000000018BF7BA90
		private static void RebuildForFont(Font f) {} // 0x000000018BF7B700-0x000000018BF7B870
		public static void UntrackText(Text t) {} // 0x000000018BF7BA90-0x000000018BF7BC74
	}

	public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 54812
	{
		// Fields
		protected static Material s_DefaultUI; // 0x00
		protected static Texture2D s_WhiteTexture; // 0x08
		private static string s_DefaultMaterialName; // 0x10
		private static string s_OverlayShaderKeyword; // 0x18
		protected Material m_Material; // 0x18
		private UnityEngine.Color m_Color; // 0x20
		[NonSerialized]
		protected bool m_SkipLayoutUpdate; // 0x30
		[NonSerialized]
		protected bool m_SkipMaterialUpdate; // 0x31
		private bool m_RaycastTarget; // 0x32
		private Vector4 m_RaycastPadding; // 0x34
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
		private bool _useLegacyMeshGeneration_k__BackingField; // 0xA8
	
		// Properties
		public static string defaultMaterialName { get; set; } // 0x000000018BF7C118-0x000000018BF7C168 0x000000018BF7C1B8-0x000000018BF7C218
		public static Material defaultGraphicMaterial { get; } // 0x0000000184044D30-0x0000000184044FA0 
		public static string overlayShaderKeyword { get; set; } // 0x000000018BF7C168-0x000000018BF7C1B8 0x000000018BF7C248-0x000000018BF7C2A8
		public virtual UnityEngine.Color color { get; set; } // 0x0000000185FB6120-0x0000000185FB6130 0x0000000184042CE0-0x0000000184042D50
		public virtual bool raycastTarget { get; set; } // 0x0000000185FB0C40-0x0000000185FB0C50 0x00000001855DC530-0x00000001855DC610
		public Vector4 raycastPadding { get; set; } // 0x0000000185FB3180-0x0000000185FB3190 0x0000000185FB3190-0x0000000185FB31A0
		private TweenRunner<ColorTween> m_ColorTweenRunner { get; } // 0x000000018442F720-0x000000018442F7D0 
		public virtual bool enableRuntimeAtlas { get; set; } // 0x0000000185FB9E80-0x0000000185FB9E90 0x000000018BF7C218-0x000000018BF7C248
		public Texture runtimeAtlasTexture { get; set; } // 0x0000000185FB0520-0x0000000185FB0530 0x000000018BF7C2A8-0x000000018BF7C2D4
		protected bool useLegacyMeshGeneration { get; set; } // 0x0000000185FB8C10-0x0000000185FB8C20 0x0000000185FBC1E0-0x0000000185FBC1F0
		public int depth { get; } // 0x00000001840E5AD0-0x00000001840E5B80 
		public RectTransform rectTransform { get; } // 0x00000001840E3B40-0x00000001840E3BA0 
		public Canvas canvas { get; } // 0x00000001840E9620-0x00000001840E9F10 
		public CanvasRenderer canvasRenderer { get; } // 0x00000001840E5A60-0x00000001840E5AD0 
		public virtual Material defaultMaterial { get; } // 0x0000000184044CE0-0x0000000184044D30 
		public virtual Material material { get; set; } // 0x0000000184F5EED0-0x0000000184F5EFE0 0x0000000185501710-0x0000000185501870
		public virtual Material materialForRendering { get; } // 0x0000000184047DC0-0x00000001840484A0 
		public virtual Texture mainTexture { get; } // 0x0000000185F570A0-0x0000000185F57100 
		protected static Mesh workerMesh { get; } // 0x00000001840E2D70-0x00000001840E2FA0 
		Transform ICanvasElement.transform { get; } // 0x000000018646DBCC-0x000000018646DBD4 
	
		// Constructors
		protected Graphic() {} // 0x00000001840C24B0-0x00000001840C2510
		static Graphic() {} // 0x0000000185D6C3B0-0x0000000185D6C4F0
	
		// Methods
		public virtual void SetAllDirty() {} // 0x0000000184E57460-0x0000000184E574B0
		public virtual void SetLayoutDirty() {} // 0x00000001840E2020-0x00000001840E20F0
		public virtual void SetVerticesDirty() {} // 0x000000018423EEC0-0x000000018423F250
		public virtual void SetMaterialDirty() {} // 0x000000018423EB30-0x000000018423EEC0
		protected override void OnRectTransformDimensionsChange() {} // 0x000000018421AC70-0x000000018421AD30
		protected override void OnBeforeTransformParentChanged() {} // 0x0000000185167370-0x0000000185167420
		protected override void OnTransformParentChanged() {} // 0x00000001850B7D00-0x00000001850B7DB0
		private void CacheCanvas() {} // 0x0000000183FD1BF0-0x0000000183FD2120
		protected override void OnEnable() {} // 0x000000018423B810-0x000000018423B9F0
		protected override void OnDisable() {} // 0x000000018423C720-0x000000018423CAB0
		protected override void OnDestroy() {} // 0x000000018404BD80-0x000000018404BE00
		protected override void OnCanvasHierarchyChanged() {} // 0x0000000183F92880-0x0000000183F92FD0
		public virtual void OnCullingChanged() {} // 0x000000018422DCB0-0x000000018422DDB0
		public virtual void Rebuild(CanvasUpdate update) {} // 0x00000001840E62E0-0x00000001840E6520
		public virtual void LayoutComplete() {} // 0x0000000185492010-0x0000000185492020
		public virtual void GraphicUpdateComplete() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void UpdateMaterial() {} // 0x0000000184047B30-0x0000000184047DC0
		protected virtual void UpdateGeometry() {} // 0x00000001840E2380-0x00000001840E23B0
		private void DoMeshGeneration() {} // 0x00000001840E31C0-0x00000001840E3940
		private void DoLegacyMeshGeneration() {} // 0x0000000185B56240-0x0000000185B564A0
		protected virtual void OnFillVBO(List<UIVertex> vbo) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnPopulateMesh(Mesh m) {} // 0x0000000185F4D550-0x0000000185F4D5F0
		protected virtual void OnPopulateMesh(VertexHelper vh) {} // 0x00000001840E0E90-0x00000001840E1150
		protected override void OnDidApplyAnimationProperties() {} // 0x000000018BF7BDA4-0x000000018BF7BDB4
		public virtual void SetNativeSize() {} // 0x0000000185492010-0x0000000185492020
		public virtual bool Raycast(Vector2 sp, Camera eventCamera) => default; // 0x0000000183FCD380-0x0000000183FCDB70
		public Vector2 PixelAdjustPoint(Vector2 point) => default; // 0x000000018BF7BDB4-0x000000018BF7BEE8
		public Rect GetPixelAdjustedRect() => default; // 0x00000001840E20F0-0x00000001840E2380
		public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x000000018442F0B0-0x000000018442F130
		public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) {} // 0x000000018442F130-0x000000018442F670
		private static UnityEngine.Color CreateColorFromAlpha(float alpha) => default; // 0x0000000185EE4A10-0x0000000185EE4A40
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x0000000185EE4940-0x0000000185EE4A10
		public void RegisterDirtyLayoutCallback(UnityAction action) {} // 0x000000018BF7BEE8-0x000000018BF7BF74
		public void UnregisterDirtyLayoutCallback(UnityAction action) {} // 0x000000018BF7C000-0x000000018BF7C08C
		public void RegisterDirtyVerticesCallback(UnityAction action) {} // 0x0000000184A145F0-0x0000000184A14680
		public void UnregisterDirtyVerticesCallback(UnityAction action) {} // 0x0000000184A13D30-0x0000000184A13DC0
		public void RegisterDirtyMaterialCallback(UnityAction action) {} // 0x000000018BF7BF74-0x000000018BF7C000
		public void UnregisterDirtyMaterialCallback(UnityAction action) {} // 0x000000018BF7C08C-0x000000018BF7C118
	}

	public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 54815
	{
		// Fields
		protected const int kNoEventMaskSet = -1; // Metadata: 0x0207B9A1
		private bool m_IgnoreReversedGraphics; // 0x20
		private BlockingObjects m_BlockingObjects; // 0x24
		protected LayerMask m_BlockingMask; // 0x28
		private Canvas m_Canvas; // 0x30
		[NonSerialized]
		private List<Graphic> m_RaycastResults; // 0x38
		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics; // 0x00
	
		// Properties
		public override int sortOrderPriority { get => default; } // 0x00000001813EE9B0-0x00000001813EE9C0 
		public override int renderOrderPriority { get => default; } // 0x0000000181424480-0x0000000181424490 
		public bool ignoreReversedGraphics { get => default; set {} } // 0x0000000181424940-0x0000000181424950 0x0000000181C9AC80-0x0000000181C9AC90
		public BlockingObjects blockingObjects { get => default; set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0 0x00000001854F6970-0x00000001854F6A00
		public LayerMask blockingMask { get => default; set {} } // 0x0000000184239C20-0x0000000184239D40 0x0000000184238190-0x0000000184239C20
		private Canvas canvas { get => default; } // 0x00000001840E3BE0-0x00000001840E4680 
		public override Camera eventCamera { get => default; } // 0x0000000185F73630-0x0000000185F73690 
	
		// Nested types
		public enum BlockingObjects // TypeDefIndex: 54813
		{
			None = 0,
			TwoD = 1,
			ThreeD = 2,
			All = 3
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 54814
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Graphic> __9__27_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018423A640-0x000000018423A7C0
			public __c() {} // 0x000000018423A7C0-0x000000018423A930
	
			// Methods
			internal int _Raycast_b__27_0(Graphic g1, Graphic g2) => default; // 0x00000001813ECBF0-0x00000001813ECC00
		}
	
		// Constructors
		protected GraphicRaycaster() {} // 0x000000018423A320-0x000000018423A600
		static GraphicRaycaster() {} // 0x0000000184B7E790-0x0000000184B7E7F0
	
		// Methods
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x00000001854F6840-0x00000001854F68D0
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) {} // 0x0000000185492010-0x0000000185492020
	}

	public class GraphicRegistry // TypeDefIndex: 54816
	{
		// Fields
		private static GraphicRegistry s_Instance; // 0x00
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
		private static readonly List<Graphic> s_EmptyList; // 0x08
	
		// Properties
		public static GraphicRegistry instance { get => default; } // 0x000000018423A220-0x000000018423A320 
	
		// Constructors
		protected GraphicRegistry() {} // 0x0000000185C24530-0x0000000185C246B0
		static GraphicRegistry() {} // 0x00000001854F68D0-0x00000001854F6970
	
		// Methods
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) {} // 0x000000018423A930-0x000000018423ADC0
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) {} // 0x000000018423B180-0x000000018423B530
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) {} // 0x000000018423ADC0-0x000000018423B180
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) {} // 0x000000018423B530-0x000000018423B810
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) => default; // 0x000000018BF7BD00-0x000000018BF7BDA4
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) => default; // 0x0000000184239D40-0x000000018423A220
	}

	internal interface IGraphicEnabledDisabled // TypeDefIndex: 54817
	{
		// Methods
		void OnSiblingGraphicEnabledDisabled();
	}

	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 54827
	{
		// Fields
		protected static Material s_ETC1DefaultUI; // 0x00
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
		private Type m_Type; // 0x130
		private bool m_PreserveAspect; // 0x134
		private bool m_FillCenter; // 0x135
		private FillMethod m_FillMethod; // 0x138
		private float m_FillAmount; // 0x13C
		private bool m_FillClockwise; // 0x140
		private int m_FillOrigin; // 0x144
		private float m_AlphaHitTestMinimumThreshold; // 0x148
		private bool m_Tracked; // 0x14C
		private bool m_UseSpriteMesh; // 0x14D
		private float m_PixelsPerUnitMultiplier; // 0x150
		private float m_CachedReferencePixelsPerUnit; // 0x154
		[NonSerialized]
		public SlicedSpriteParams slicedSpriteParams; // 0x158
		private bool bAwakeOnce; // 0x17C
		private static readonly Vector2[] s_VertScratch; // 0x08
		private static readonly Vector2[] s_UVScratch; // 0x10
		private const int QuadCount = 4; // Metadata: 0x0207B9A6
		private static readonly Vector3[] s_Xy; // 0x18
		private static readonly Vector3[] s_Uv; // 0x20
		private static List<Image> m_TrackedTexturelessImages; // 0x28
		private static bool s_Initialized; // 0x30
		protected const int VALIDATE_MAX_VERT_COUNT = 10000; // Metadata: 0x0207B9A7
		private EDynamicAtlasActiveMode m_DynamicAtlasActiveMode; // 0x17D
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
		public Rect runtimeAtlasRect { get => default; set {} } // 0x0000000185FCCD90-0x0000000185FCCDA0 0x0000000185FCCCD0-0x0000000185FCCCE0
		public Rect runtimeAtlasTextureRect { get => default; set {} } // 0x0000000185FCCD60-0x0000000185FCCD70 0x0000000185FCCCC0-0x0000000185FCCCD0
		public Vector4 runtimeAtlasBorder { get => default; set {} } // 0x0000000185FCCD50-0x0000000185FCCD60 0x0000000185FB9C00-0x0000000185FB9C10
		public float runtimeAtlasPixelsPerUnit { get => default; set {} } // 0x0000000185FE9320-0x0000000185FE9330 0x0000000185FB2360-0x0000000185FB2370
		public Sprite sprite { get => default; set {} } // 0x0000000184044890-0x0000000184044CE0 0x0000000185FB9E80-0x0000000185FB9E90
		public bool enableRuntimeAtlasRaw { get => default; } // 0x0000000184C57920-0x0000000184C57960 
		public override bool enableRuntimeAtlas { get => default; set {} } // 0x000000018BF7C218-0x000000018BF7C248 0x0000000185EC2500-0x0000000185EC2570
		public Sprite overrideSprite { get => default; set {} } // 0x000000018BF7E450-0x000000018BF7E4B8 0x0000000184047510-0x0000000184047700
		private Sprite activeSprite { get => default; } // 0x0000000185FB8050-0x0000000185FB8060 
		public Type type { get => default; set {} } // 0x000000018BF7E53C-0x000000018BF7E598 0x0000000185FBC640-0x0000000185FBC650
		public bool preserveAspect { get => default; set {} } // 0x000000018BF7E4DC-0x000000018BF7E53C 0x0000000185FBC670-0x0000000185FBC680
		public bool fillCenter { get => default; set {} } // 0x000000018BF7E2D0-0x000000018BF7E330 0x0000000185FBB480-0x0000000185FBB490
		public FillMethod fillMethod { get => default; set {} } // 0x000000018BF7E390-0x000000018BF7E3F4 0x0000000185FB9110-0x0000000185FB9120
		public float fillAmount { get => default; set {} } // 0x00000001848E1CC0-0x00000001848E1DF0 0x0000000185FB8EC0-0x0000000185FB8ED0
		public bool fillClockwise { get => default; set {} } // 0x000000018BF7E330-0x000000018BF7E390 0x0000000185FD6F70-0x0000000185FD6F80
		public int fillOrigin { get => default; set {} } // 0x000000018BF7E3F4-0x000000018BF7E450 0x0000000185FE92D0-0x0000000185FE92F0
		public float eventAlphaThreshold { get => default; set {} } // 0x0000000185FE9300-0x0000000185FE9320 0x0000000185FB9A70-0x0000000185FB9A80
		public float alphaHitTestMinimumThreshold { get => default; set {} } // 0x0000000185FBCC60-0x0000000185FBCC70 0x0000000185FE92F0-0x0000000185FE9300
		public bool useSpriteMesh { get => default; set {} } // 0x000000018BF7E598-0x000000018BF7E5F8 0x00000001840C06F0-0x00000001840C0790
		public static Material defaultETC1GraphicMaterial { get => default; } // 0x00000001840466A0-0x0000000184046C00 
		public override Texture mainTexture { get => default; } // 0x0000000183F916C0-0x0000000183F917E0 
		public bool hasBorder { get => default; } // 0x0000000185FB9A40-0x0000000185FB9A50 
		public float pixelsPerUnitMultiplier { get => default; set {} } // 0x000000018BF7E4B8-0x000000018BF7E4DC 0x0000000183F91B00-0x0000000183F91D90
		public float pixelsPerUnit { get => default; } // 0x0000000183F91AE0-0x0000000183F91B00 
		protected float multipliedPixelsPerUnit { get => default; } // 0x0000000184045A60-0x0000000184045F90 
		public override Material material { get => default; set {} } // 0x0000000185501700-0x0000000185501710 0x0000000185492010-0x0000000185492020
		public virtual float minWidth { get => default; } // 0x0000000183F90F70-0x0000000183F91220 
		public virtual float preferredWidth { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual float flexibleWidth { get => default; } // 0x0000000183908D00-0x0000000183908D10 
		public virtual float minHeight { get => default; } // 0x0000000183F90CC0-0x0000000183F90E10 
		public virtual float preferredHeight { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual float flexibleHeight { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual int layoutPriority { get => default; } // 0x0000000183FCB880-0x0000000183FCB9D0 
		public EDynamicAtlasActiveMode DynamicAtlasActiveMode { get => default; } // 0x000000018404B890-0x000000018404BC60 
	
		// Nested types
		public enum Type // TypeDefIndex: 54818
		{
			Simple = 0,
			Sliced = 1,
			Tiled = 2,
			Filled = 3,
			Mirror = 4,
			Quarter = 5
		}
	
		public enum FillMethod // TypeDefIndex: 54819
		{
			Horizontal = 0,
			Vertical = 1,
			Radial90 = 2,
			Radial180 = 3,
			Radial360 = 4
		}
	
		public enum OriginHorizontal // TypeDefIndex: 54820
		{
			Left = 0,
			Right = 1
		}
	
		public enum OriginVertical // TypeDefIndex: 54821
		{
			Bottom = 0,
			Top = 1
		}
	
		public enum Origin90 // TypeDefIndex: 54822
		{
			BottomLeft = 0,
			TopLeft = 1,
			TopRight = 2,
			BottomRight = 3
		}
	
		public enum Origin180 // TypeDefIndex: 54823
		{
			Bottom = 0,
			Left = 1,
			Top = 2,
			Right = 3
		}
	
		public enum Origin360 // TypeDefIndex: 54824
		{
			Bottom = 0,
			Right = 1,
			Top = 2,
			Left = 3
		}
	
		public struct SlicedSpriteParams // TypeDefIndex: 54825
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
			} // 0x0000000185FCCCF0-0x0000000185FCCD00
		}
	
		public enum EDynamicAtlasActiveMode : byte // TypeDefIndex: 54826
		{
			ActiveOnAwake = 0,
			ActiveOnEnable = 1
		}
	
		// Constructors
		protected Image() {} // 0x000000018BF7E200-0x000000018BF7E2C8
		static Image() {} // 0x0000000185FEA9F0-0x0000000185FEAA20
	
		// Methods
		public virtual void ReleaseSprite() {} // 0x000000018404B540-0x000000018404B6F0
		protected virtual void _OnSpriteChanged(Sprite oldOne) {} // 0x0000000185FE92B0-0x0000000185FE92C0
		public void DisableSpriteOptimizations() {} // 0x000000018BF7E2C8-0x000000018BF7E2D0
		public virtual void OnBeforeSerialize() {} // 0x000000018421A4D0-0x000000018421A550
		public virtual void OnAfterDeserialize() {} // 0x000000018529C7F0-0x000000018529C8E0
		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) {} // 0x0000000184046C00-0x0000000184047510
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) => default; // 0x0000000183F91220-0x0000000183F91410
		public override void SetNativeSize() {} // 0x0000000184045540-0x0000000184045840
		protected override void OnPopulateMesh(VertexHelper toFill) {} // 0x0000000184047740-0x0000000184047B30
		private void TrackSprite() {} // 0x000000018423C660-0x000000018423C720
		protected override void OnEnable() {} // 0x00000001842412D0-0x0000000184241410
		protected override void OnDisable() {} // 0x000000018404B810-0x000000018404B890
		protected override void Awake() {} // 0x000000018404BCF0-0x000000018404BD80
		protected override void OnDestroy() {} // 0x0000000184045F90-0x00000001840466A0
		protected override void UpdateMaterial() {} // 0x0000000183F91F40-0x0000000183F920C0
		protected override void OnCanvasHierarchyChanged() {} // 0x0000000183F970E0-0x0000000183F97820
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) {} // 0x000000018BF7D1D0-0x000000018BF7D650
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) {} // 0x0000000183F93060-0x0000000183F93A80
		private void GenerateSlicedSprite(VertexHelper toFill) {} // 0x0000000184DDEF40-0x0000000184DE0040
		private void GenerateTiledSprite(VertexHelper toFill) {} // 0x000000018BF7CC68-0x000000018BF7D1D0
		private void GenerateMirrorSprite(VertexHelper toFill) {} // 0x000000018BF7C2D4-0x000000018BF7CC68
		private void GenerateMirrorQuarter(VertexHelper toFill) {} // 0x0000000183F94540-0x0000000183F954B0
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) {} // 0x0000000183F93C20-0x0000000183F94540
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) {} // 0x00000001844B13D0-0x00000001844B15F0
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) => default; // 0x00000001840ECC80-0x00000001840EDD90
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) {} // 0x000000018436B760-0x000000018436B8E0
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) => default; // 0x000000018436B8E0-0x000000018436BCB0
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) {} // 0x0000000185492010-0x0000000185492020
		public virtual void CalculateLayoutInputHorizontal() {} // 0x0000000185492010-0x0000000185492020
		public virtual void CalculateLayoutInputVertical() {} // 0x0000000183908D00-0x0000000183908D10
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) => default; // 0x000000018BF7DB5C-0x000000018BF7DF08
		private Vector2 MapCoordinate(Vector2 local, Rect rect) => default; // 0x000000018BF7DF08-0x000000018BF7E090
		private static void RebuildImage(SpriteAtlas spriteAtlas) {} // 0x000000018BF7E090-0x000000018BF7E190
		private static void TrackImage(Image g) {} // 0x000000018BF7E190-0x000000018BF7E200
		private static void UnTrackImage(Image g) {} // 0x0000000185029CD0-0x0000000185029D00
		protected override void OnDidApplyAnimationProperties() {} // 0x000000018BF7DAB4-0x000000018BF7DB5C
		private Vector4 GetRuntimeAtlasSpritePadding() => default; // 0x000000018BF7D9A8-0x000000018BF7DAB4
		private Vector4 GetRuntimeAtlasSpriteOuterUV() => default; // 0x000000018BF7D77C-0x000000018BF7D9A8
		private Vector4 GetRuntimeAtlasSpriteInnerUV() => default; // 0x000000018BF7D650-0x000000018BF7D77C
		public string GetParticlePath() => default; // 0x0000000185FE92C0-0x0000000185FE92D0
		public void RegisterDynamicAtlas() {} // 0x000000018404B200-0x000000018404B3D0
		public void UnRegisterDynamicAtlas(Sprite _sprite) {} // 0x00000001849D1E70-0x00000001849D1F90
		public void RegisterDynamicAtlasCallBack(Action cb) {} // 0x00000001849D28D0-0x00000001849D2970
		public void UnRegisterDynamicAtlasCallBack(Action cb) {} // 0x0000000184049F50-0x000000018404B1C0
		private static void _CanvasRreWillRenderCanvases() {} // 0x0000000185A876B0-0x0000000185A879F0
	}

	public interface IMask // TypeDefIndex: 54828
	{
		// Properties
		RectTransform rectTransform { get; }
	
		// Methods
		bool Enabled();
	}

	public interface IMaskable // TypeDefIndex: 54829
	{
		// Methods
		void RecalculateMasking();
	}

	public class InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 54841
	{
		// Fields
		protected TouchScreenKeyboard m_Keyboard; // 0x180
		private static readonly char[] kSeparators; // 0x00
		private static bool s_IsQuestDevice; // 0x08
		protected Text m_TextComponent; // 0x188
		protected Graphic m_Placeholder; // 0x190
		private ContentType m_ContentType; // 0x198
		private InputType m_InputType; // 0x19C
		private char m_AsteriskChar; // 0x1A0
		private TouchScreenKeyboardType m_KeyboardType; // 0x1A4
		private LineType m_LineType; // 0x1A8
		private bool m_HideMobileInput; // 0x1AC
		private CharacterValidation m_CharacterValidation; // 0x1B0
		private int m_CharacterLimit; // 0x1B4
		private SubmitEvent m_OnSubmit; // 0x1B8
		private EndEditEvent m_OnDidEndEdit; // 0x1C0
		private OnChangeEvent m_OnValueChanged; // 0x1C8
		private OnValidateInput m_OnValidateInput; // 0x1D0
		private UnityEngine.Color m_CaretColor; // 0x1D8
		private bool m_CustomCaretColor; // 0x1E8
		private UnityEngine.Color m_SelectionColor; // 0x1EC
		protected string m_Text; // 0x200
		private float m_CaretBlinkRate; // 0x208
		private int m_CaretWidth; // 0x20C
		private bool m_ReadOnly; // 0x210
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
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x0207B9C9
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x0207B9CD
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
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x0207B9D1
		private const string kOculusQuestDeviceModel = "Oculus Quest"; // Metadata: 0x0207B9E5
		private UnityEngine.Event m_ProcessingEvent; // 0x298
		private const int k_MaxTextLength = 16382; // Metadata: 0x0207B9F2
	
		// Properties
		private BaseInput input { get => default; } // 0x000000018C085EC0-0x000000018C08617C 
		private string compositionString { get => default; } // 0x0000000181B44930-0x0000000181B44940 
		protected Mesh mesh { get => default; } // 0x000000018C085148-0x000000018C085198 
		protected TextGenerator cachedInputTextGenerator { get => default; } // 0x000000018C08585C-0x000000018C08589C 
		public bool shouldHideMobileInput { get => default; set {} } // 0x000000018C085AA4-0x000000018C085ABC 0x0000000185FB9350-0x0000000185FB9360
		public virtual bool shouldActivateOnSelect { get => default; set {} } // 0x000000018C085DE8-0x000000018C085E28 0x0000000185FEA9C0-0x0000000185FEA9D0
		public string text { get => default; set {} } // 0x0000000185FB7F50-0x0000000185FB7F60 0x000000018C085C18-0x000000018C085C64
		public bool isFocused { get => default; } // 0x0000000185FB8420-0x0000000185FB8430 
		public float caretBlinkRate { get => default; set {} } // 0x000000018C085CFC-0x000000018C085D04 0x0000000185FB8420-0x0000000185FB8430
		public int caretWidth { get => default; set {} } // 0x000000018C085D04-0x000000018C085D50 0x0000000185FB8030-0x0000000185FB8040
		public Text textComponent { get => default; set {} } // 0x000000018C085CB0-0x000000018C085CFC 0x0000000185FD6C10-0x0000000185FD6C20
		public Graphic placeholder { get => default; set {} } // 0x000000018C085958-0x000000018C0859EC 0x0000000185FBB470-0x0000000185FBB480
		public UnityEngine.Color caretColor { get => default; set {} } // 0x000000018C085A48-0x000000018C085AA4 0x0000000185FBCFB0-0x0000000185FBCFC0
		public bool customCaretColor { get => default; set {} } // 0x000000018C085B74-0x000000018C085C18 0x0000000185FBB460-0x0000000185FBB470
		public UnityEngine.Color selectionColor { get => default; set {} } // 0x000000018C085ABC-0x000000018C085B18 0x0000000185FB8280-0x0000000185FB8290
		public EndEditEvent onEndEdit { get => default; set {} } // 0x0000000185FD3CF0-0x0000000185FD3D00 0x000000018C085B18-0x000000018C085B74
		public SubmitEvent onSubmit { get => default; set {} } // 0x0000000185FB9BD0-0x0000000185FB9BE0 0x000000018C0859EC-0x000000018C085A48
		public OnChangeEvent onValueChange { get => default; set {} } // 0x0000000185FBFBF0-0x0000000185FBFC00 0x0000000185FEA9D0-0x0000000185FEA9E0
		public OnChangeEvent onValueChanged { get => default; set {} } // 0x000000018C085420-0x000000018C085438 0x0000000185FEA9B0-0x0000000185FEA9C0
		public OnValidateInput onValidateInput { get => default; set {} } // 0x000000018C085798-0x000000018C0857F4 0x0000000185FB9430-0x0000000185FB9440
		public int characterLimit { get => default; set {} } // 0x000000018C07E79C-0x000000018C07E7D0 0x000000018C085198-0x000000018C0851C4
		public ContentType contentType { get => default; set {} } // 0x000000018C08589C-0x000000018C0858B4 0x000000018C0851C4-0x000000018C0851F0
		public LineType lineType { get => default; set {} } // 0x000000018C0858E4-0x000000018C0858FC 0x000000018C08527C-0x000000018C0852AC
		public InputType inputType { get => default; set {} } // 0x000000018C0851C4-0x000000018C0851F0 0x000000018C0858B4-0x000000018C0858E4
		public TouchScreenKeyboard touchScreenKeyboard { get => default; } // 0x000000018C085198-0x000000018C0851C4 
		public TouchScreenKeyboardType keyboardType { get => default; set {} } // 0x000000018C085D9C-0x000000018C085DE8 0x000000018C0851C4-0x000000018C0851F0
		public CharacterValidation characterValidation { get => default; set {} } // 0x000000018C085E28-0x000000018C085E74 0x000000018C082640-0x000000018C0828B0
		public bool readOnly { get => default; set {} } // 0x000000018C08223C-0x000000018C082488 0x000000018C07E740-0x000000018C07E79C
		public bool multiLine { get => default; } // 0x000000018C0833A0-0x000000018C0833E0 
		public char asteriskChar { get => default; set {} } // 0x000000018C083338-0x000000018C0833A0 0x000000018C083EB4-0x000000018C083F98
		public bool wasCanceled { get => default; } // 0x000000018C082A50-0x000000018C082A58 
		protected int caretPositionInternal { get => default; set {} } // 0x000000018C082080-0x000000018C0820D4 0x000000018C0820D4-0x000000018C082114
		protected int caretSelectPositionInternal { get => default; set {} } // 0x000000018BE19EE4-0x000000018BE19EEC 0x000000018BE1A3EC-0x000000018BE1A3F4
		private new bool hasSelection { get => default; } // 0x000000018C083D9C-0x000000018C083E04 
		public int caretPosition { get => default; set {} } // 0x000000018C08055C-0x000000018C080580 0x000000018C0804F8-0x000000018C08055C
		public int selectionAnchorPosition { get => default; set {} } // 0x000000018C083E04-0x000000018C083EB4 0x000000018C080B28-0x000000018C0818D4
		public int selectionFocusPosition { get => default; set {} } // 0x000000018C082EC0-0x000000018C083190 0x000000018C080394-0x000000018C0804F8
		private static string clipboard { get => default; set {} } // 0x000000018C082CF0-0x000000018C082EA8 0x000000018C080308-0x000000018C080394
		public virtual float minWidth { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public virtual float preferredWidth { get => default; } // 0x000000018C086728-0x000000018C086774 
		public virtual float flexibleWidth { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public virtual float minHeight { get => default; } // 0x0000000181378230-0x0000000181378240 
		public virtual float preferredHeight { get => default; } // 0x0000000185492010-0x0000000185492020 
		public virtual float flexibleHeight { get => default; } // 0x000000018C0867C0-0x000000018C086A48 
		public virtual int layoutPriority { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		Transform ICanvasElement.transform { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 54830
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
	
		public enum InputType // TypeDefIndex: 54831
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 54832
		{
			None = 0,
			Integer = 1,
			Decimal = 2,
			Alphanumeric = 3,
			Name = 4,
			EmailAddress = 5
		}
	
		public enum LineType // TypeDefIndex: 54833
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 54834; 0x000000018C0851F0-0x000000018C08527C
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 54835
		{
			// Constructors
			public SubmitEvent() {} // 0x000000018C0850CC-0x000000018C085148
		}
	
		[Serializable]
		public class EndEditEvent : UnityEvent<string> // TypeDefIndex: 54836
		{
			// Constructors
			public EndEditEvent() {} // 0x000000018C085E74-0x000000018C085EC0
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 54837
		{
			// Constructors
			public OnChangeEvent() {} // 0x000000018C085768-0x000000018C085798
		}
	
		protected enum EditState // TypeDefIndex: 54838
		{
			Continue = 0,
			Finish = 1
		}
	
		private sealed class _CaretBlink_d__169 : IEnumerator<object> // TypeDefIndex: 54839
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public InputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018C08617C-0x000000018C086188 
			object IEnumerator.Current { get => default; } // 0x000000018C0839C0-0x000000018C083D34 
	
			// Constructors
			public _CaretBlink_d__169() {} // Dummy constructor
			public _CaretBlink_d__169(int __1__state) {} // 0x0000000185FEA9E0-0x0000000185FEA9F0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018C085744-0x000000018C085768
			private bool MoveNext() => default; // 0x0000000185FB85D0-0x0000000185FB85E0
			void IEnumerator.Reset() {} // 0x000000018C0839B4-0x000000018C0839C0
		}
	
		private sealed class _MouseDragOutsideRect_d__191 : IEnumerator<object> // TypeDefIndex: 54840
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PointerEventData eventData; // 0x20
			public InputField __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FE5B90-0x0000000185FE5BA0 
			object IEnumerator.Current { get => default; } // 0x0000000185FB8360-0x0000000185FB8370 
	
			// Constructors
			public _MouseDragOutsideRect_d__191() {} // Dummy constructor
			public _MouseDragOutsideRect_d__191(int __1__state) {} // 0x0000000181CE76E0-0x0000000181CE76F0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FBACF0-0x0000000185FBAD00
			private bool MoveNext() => default; // 0x000000018C0857F4-0x000000018C08585C
			void IEnumerator.Reset() {} // 0x000000018C0858FC-0x000000018C085958
		}
	
		// Constructors
		protected InputField() {} // 0x000000018C085D50-0x000000018C085D9C
		static InputField() {} // 0x000000018C086A48-0x000000018C086BF0
	
		// Methods
		public void SetTextWithoutNotify(string input) {} // 0x0000000181BE0A10-0x0000000181BE0A20
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x0207B9C8 */) {} // 0x000000018C085C64-0x000000018C085CB0
		protected void ClampPos(ref int pos) {} // 0x000000018C083190-0x000000018C0831C8
		protected override void OnEnable() {} // 0x000000018C07FFAC-0x000000018C0801A4
		protected override void OnDisable() {} // 0x000000018C081D18-0x000000018C081DC4
		private IEnumerator CaretBlink() => default; // 0x000000018C0821F0-0x000000018C082214
		private void SetCaretVisible() {} // 0x000000018C082488-0x000000018C082640
		private void SetCaretActive() {} // 0x000000018C081DC4-0x000000018C081E38
		private void UpdateCaretMaterial() {} // 0x000000018C0828B0-0x000000018C0828D4
		protected void OnFocus() {} // 0x000000018C082A80-0x000000018C082C70
		protected void SelectAll() {} // 0x000000018C080754-0x000000018C080B28
		public void MoveTextEnd(bool shift) {} // 0x000000018C0806F4-0x000000018C080754
		public void MoveTextStart(bool shift) {} // 0x000000018C082EA8-0x000000018C082EB0
		private bool TouchScreenKeyboardShouldBeUsed() => default; // 0x000000018C07EF28-0x000000018C07EFE4
		private bool InPlaceEditing() => default; // 0x000000018C081FD4-0x000000018C082080
		private bool InPlaceEditingChanged() => default; // 0x000000018C07EFE4-0x000000018C07F098
		private void UpdateCaretFromKeyboard() {} // 0x000000018C081F28-0x000000018C081FD4
		protected virtual void LateUpdate() {} // 0x000000018C07ECA4-0x000000018C07ED40
		public Vector2 ScreenToLocal(Vector2 screen) => default; // 0x000000018C081AC4-0x000000018C081CCC
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) => default; // 0x000000018C0818D4-0x000000018C081AC4
		protected int GetCharacterIndexFromPosition(Vector2 pos) => default; // 0x000000018C081F1C-0x000000018C081F28
		private bool MayDrag(PointerEventData eventData) => default; // 0x000000018C081E38-0x000000018C081F1C
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x000000018C082114-0x000000018C082120
		public virtual void OnDrag(PointerEventData eventData) {} // 0x000000018C082120-0x000000018C0821F0
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData) => default; // 0x000000018C07EACC-0x000000018C07ECA4
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x000000018C07F0A0-0x000000018C07F13C
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018C07E660-0x000000018C07E740
		protected EditState KeyPressed(UnityEngine.Event evt) => default; // 0x000000018C080580-0x000000018C080688
		private bool IsValidChar(char c) => default; // 0x000000018C0847B8-0x000000018C084800
		public void ProcessEvent(UnityEngine.Event e) {} // 0x000000018C0832A8-0x000000018C0832C8
		public virtual void OnUpdateSelected(BaseEventData eventData) {} // 0x000000018C0832C8-0x000000018C083338
		private string GetSelectedString() => default; // 0x000000018C0831C8-0x000000018C083238
		private int FindtNextWordBegin() => default; // 0x000000018C083238-0x000000018C0832A8
		private void MoveRight(bool shift, bool ctrl) {} // 0x000000018C07DEC8-0x000000018C07DF50
		private int FindtPrevWordBegin() => default; // 0x000000018C07DC48-0x000000018C07DEC8
		private void MoveLeft(bool shift, bool ctrl) {} // 0x000000018C084384-0x000000018C0847B8
		private int DetermineCharacterLine(int charPos, TextGenerator generator) => default; // 0x000000018C080688-0x000000018C0806F4
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) => default; // 0x000000018C080260-0x000000018C080308
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar) => default; // 0x000000018C0801A4-0x000000018C080260
		private void MoveDown(bool shift) {} // 0x000000018C0833E0-0x000000018C0839B4
		private void MoveDown(bool shift, bool goToLastChar) {} // 0x000000018C07F098-0x000000018C07F0A0
		private void MoveUp(bool shift) {} // 0x000000018C081CCC-0x000000018C081D18
		private void MoveUp(bool shift, bool goToFirstChar) {} // 0x000000018C082EB0-0x000000018C082EC0
		private void Delete() {} // 0x0000000185492010-0x0000000185492020
		private void ForwardSpace() {} // 0x0000000185492010-0x0000000185492020
		private void Backspace() {} // 0x000000018C083F98-0x000000018C084384
		private void Insert(char c) {} // 0x000000018C07DF50-0x000000018C07E660
		private void UpdateTouchKeyboardFromEditChanges() {} // 0x000000018C0828D4-0x000000018C082A50
		private void SendOnValueChangedAndUpdateLabel() {} // 0x000000018C07F13C-0x000000018C07F7FC
		private void SendOnValueChanged() {} // 0x000000018C07E7D0-0x000000018C07E938
		protected void SendOnEndEdit() {} // 0x000000018C07F7FC-0x000000018C07FFAC
		protected void SendOnSubmit() {} // 0x000000018C084800-0x000000018C084E3C
		protected virtual void Append(string input) {} // 0x000000018C07DB30-0x000000018C07DC48
		protected virtual void Append(char input) {} // 0x000000018C07D814-0x000000018C07DB30
		protected void UpdateLabel() {} // 0x000000018C082C70-0x000000018C082CAC
		private bool IsSelectionVisible() => default; // 0x000000018C082A58-0x000000018C082A80
		private static int GetLineStartPosition(TextGenerator gen, int line) => default; // 0x000000018C07E938-0x000000018C07EACC
		private static int GetLineEndPosition(TextGenerator gen, int line) => default; // 0x000000018C082214-0x000000018C08223C
		private void SetDrawRangeToContainCaretPosition(int caretPos) {} // 0x000000018C082CAC-0x000000018C082CF0
		public void ForceLabelUpdate() {} // 0x000000018C07ED64-0x000000018C07EE94
		private void MarkGeometryAsDirty() {} // 0x000000018C07EE94-0x000000018C07EF28
		public virtual void Rebuild(CanvasUpdate update) {} // 0x000000018C083D34-0x000000018C083D84
		public virtual void LayoutComplete() {} // 0x000000018C083D84-0x000000018C083D9C
		public virtual void GraphicUpdateComplete() {} // 0x000000018C07ED40-0x000000018C07ED64
		private void UpdateGeometry() {} // 0x0000000185492010-0x0000000185492020
		private void AssignPositioningIfNeeded() {} // 0x0000000185492010-0x0000000185492020
		private void OnFillVBO(Mesh vbo) {} // 0x0000000183908D00-0x0000000183908D10
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) {} // 0x000000018C0855E4-0x000000018C085744
		private void CreateCursorVerts() {} // 0x0000000185FD5E00-0x0000000185FD5E10
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) {} // 0x0000000183908D00-0x0000000183908D10
		protected char Validate(string text, int pos, char ch) => default; // 0x000000018C085438-0x000000018C0855E4
		public void ActivateInputField() {} // 0x0000000185FD5E00-0x0000000185FD5E10
		private void ActivateInputFieldInternal() {} // 0x0000000181B87DE0-0x0000000181B87DF0
		public override void OnSelect(BaseEventData eventData) {} // 0x000000018C084E3C-0x000000018C084ED8
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x000000018646DBCC-0x000000018646DBD4
		public void DeactivateInputField() {} // 0x000000018BE15D54-0x000000018BE15E28
		public override void OnDeselect(BaseEventData eventData) {} // 0x00000001817E31E0-0x00000001817E3200
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x000000018C086530-0x000000018C0865CC
		private void EnforceContentType() {} // 0x000000018A1CE150-0x000000018A1CE280
		private void EnforceTextHOverflow() {} // 0x000000018C0865CC-0x000000018C086608
		private void SetToCustomIfContentTypeIsNot(ContentType[] allowedContentTypes) {} // 0x000000018C07D3F0-0x000000018C07D42C
		private void SetToCustom() {} // 0x000000018C0864F4-0x000000018C086530
		protected override void DoStateTransition(SelectionState state, bool instant) {} // 0x0000000181378230-0x0000000181378240
		public virtual void CalculateLayoutInputHorizontal() {} // 0x0000000185492010-0x0000000185492020
		public virtual void CalculateLayoutInputVertical() {} // 0x000000018C086608-0x000000018C086728
	}

	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController // TypeDefIndex: 54843
	{
		// Fields
		private AspectMode m_AspectMode; // 0x18
		private float m_AspectRatio; // 0x1C
		[NonSerialized]
		private RectTransform m_Rect; // 0x20
		private bool m_DelayedSetDirty; // 0x28
		private bool m_DoesParentExist; // 0x29
		private DrivenRectTransformTracker m_Tracker; // 0x2A
	
		// Properties
		public AspectMode aspectMode { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x000000018C07D218-0x000000018C07D270
		public float aspectRatio { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x000000018C07D270-0x000000018C07D2CC
		private RectTransform rectTransform { get => default; } // 0x0000000185390280-0x0000000185390310 
	
		// Nested types
		public enum AspectMode // TypeDefIndex: 54842
		{
			None = 0,
			WidthControlsHeight = 1,
			HeightControlsWidth = 2,
			FitInParent = 3,
			EnvelopeParent = 4
		}
	
		// Constructors
		protected AspectRatioFitter() {} // 0x0000000185D78B50-0x0000000185D78B60
	
		// Methods
		protected override void OnEnable() {} // 0x000000018538FE60-0x000000018538FF10
		protected override void Start() {} // 0x000000018538FC50-0x000000018538FC80
		protected override void OnDisable() {} // 0x000000018538FF10-0x000000018538FF70
		protected override void OnTransformParentChanged() {} // 0x000000018C07D198-0x000000018C07D218
		protected virtual void Update() {} // 0x0000000185718700-0x0000000185718720
		protected override void OnRectTransformDimensionsChange() {} // 0x000000018538FF70-0x000000018538FF80
		private void UpdateRect() {} // 0x000000018538FF80-0x0000000185390280
		private float GetSizeDeltaToProduceSize(float size, int axis) => default; // 0x000000018538FC90-0x000000018538FD90
		private Vector2 GetParentSize() => default; // 0x000000018538FD90-0x000000018538FE60
		public virtual void SetLayoutHorizontal() {} // 0x0000000185492010-0x0000000185492020
		public virtual void SetLayoutVertical() {} // 0x0000000185492010-0x0000000185492020
		protected void SetDirty() {} // 0x000000018538FF70-0x000000018538FF80
		public bool IsComponentValidOnObject() => default; // 0x0000000185390310-0x00000001853903A0
		public bool IsAspectModeValid() => default; // 0x000000018538FC80-0x000000018538FC90
		private bool DoesParentExists() => default; // 0x00000001813B34D0-0x00000001813B34E0
	}

	public class CanvasScaler : UIBehaviour // TypeDefIndex: 54847
	{
		// Fields
		private ScaleMode m_UiScaleMode; // 0x18
		protected float m_ReferencePixelsPerUnit; // 0x1C
		protected float m_ScaleFactor; // 0x20
		protected Vector2 m_ReferenceResolution; // 0x24
		protected ScreenMatchMode m_ScreenMatchMode; // 0x2C
		protected float m_MatchWidthOrHeight; // 0x30
		private const float kLogBase = 2f; // Metadata: 0x0207BA13
		protected Unit m_PhysicalUnit; // 0x34
		protected float m_FallbackScreenDPI; // 0x38
		protected float m_DefaultSpriteDPI; // 0x3C
		protected float m_DynamicPixelsPerUnit; // 0x40
		private Canvas m_Canvas; // 0x48
		[NonSerialized]
		private float m_PrevScaleFactor; // 0x50
		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit; // 0x54
		protected bool m_PresetInfoIsWorld; // 0x58
	
		// Properties
		public ScaleMode uiScaleMode { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
		public float referencePixelsPerUnit { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x0000000183B7E5A0-0x0000000183B7E5B0
		public float scaleFactor { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x000000018C07D384-0x000000018C07D398
		public Vector2 referenceResolution { get => default; set {} } // 0x0000000185FB1F70-0x0000000185FB1F90 0x00000001845E5C90-0x00000001845E5CE0
		public ScreenMatchMode screenMatchMode { get => default; set {} } // 0x0000000185FB0630-0x0000000185FB0640 0x0000000185FB0640-0x0000000185FB0650
		public float matchWidthOrHeight { get => default; set {} } // 0x0000000185FB0BE0-0x0000000185FB0BF0 0x0000000185FB0BF0-0x0000000185FB0C00
		public Unit physicalUnit { get => default; set {} } // 0x0000000185FB07C0-0x0000000185FB07D0 0x0000000185FB07E0-0x0000000185FB07F0
		public float fallbackScreenDPI { get => default; set {} } // 0x0000000185FB24B0-0x0000000185FB24C0 0x0000000185FB24C0-0x0000000185FB24D0
		public float defaultSpriteDPI { get => default; set {} } // 0x0000000185FB0580-0x0000000185FB0590 0x000000018C07D370-0x000000018C07D384
		public float dynamicPixelsPerUnit { get => default; set {} } // 0x0000000185FB0590-0x0000000185FB05A0 0x0000000185FB05F0-0x0000000185FB0600
	
		// Nested types
		public enum ScaleMode // TypeDefIndex: 54844
		{
			ConstantPixelSize = 0,
			ScaleWithScreenSize = 1,
			ConstantPhysicalSize = 2
		}
	
		public enum ScreenMatchMode // TypeDefIndex: 54845
		{
			MatchWidthOrHeight = 0,
			Expand = 1,
			Shrink = 2
		}
	
		public enum Unit // TypeDefIndex: 54846
		{
			Centimeters = 0,
			Millimeters = 1,
			Inches = 2,
			Points = 3,
			Picas = 4
		}
	
		// Constructors
		protected CanvasScaler() {} // 0x0000000185571F00-0x0000000185571F50
	
		// Methods
		protected override void OnEnable() {} // 0x00000001849CF970-0x00000001849CFA20
		private void Canvas_preWillRenderCanvases() {} // 0x00000001842378D0-0x0000000184237AF0
		protected override void OnDisable() {} // 0x00000001849CDEF0-0x00000001849CDFA0
		public void HandleManually() {} // 0x0000000185686960-0x0000000185686A80
		protected virtual void Handle() {} // 0x0000000184237AF0-0x0000000184237D10
		protected virtual void HandleWorldCanvas() {} // 0x00000001842377F0-0x0000000184237850
		protected virtual void HandleConstantPixelSize() {} // 0x0000000185FA7F30-0x0000000185FA7F60
		protected virtual void HandleScaleWithScreenSize() {} // 0x000000018402D1B0-0x000000018402D510
		protected virtual void HandleConstantPhysicalSize() {} // 0x000000018C07D2CC-0x000000018C07D370
		protected void SetScaleFactor(float scaleFactor) {} // 0x0000000184237880-0x00000001842378D0
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) {} // 0x0000000184237850-0x0000000184237880
	}

	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController // TypeDefIndex: 54849
	{
		// Fields
		protected FitMode m_HorizontalFit; // 0x18
		protected FitMode m_VerticalFit; // 0x1C
		[NonSerialized]
		private RectTransform m_Rect; // 0x20
		private DrivenRectTransformTracker m_Tracker; // 0x28
	
		// Properties
		public FitMode horizontalFit { get => default; set {} } // 0x00000001813AE560-0x00000001813AE570 0x0000000183F8D630-0x0000000183F8D690
		public FitMode verticalFit { get => default; set {} } // 0x00000001813AE570-0x00000001813AE580 0x000000018C07D398-0x000000018C07D3F0
		private RectTransform rectTransform { get => default; } // 0x0000000183F901D0-0x0000000183F90300 
	
		// Nested types
		public enum FitMode // TypeDefIndex: 54848
		{
			Unconstrained = 0,
			MinSize = 1,
			PreferredSize = 2
		}
	
		// Constructors
		protected ContentSizeFitter() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnEnable() {} // 0x0000000183F8E6E0-0x0000000183F8E6F0
		protected override void OnDisable() {} // 0x0000000183F8E680-0x0000000183F8E6E0
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000183F8E6E0-0x0000000183F8E6F0
		private void HandleSelfFittingAlongAxis(int axis) {} // 0x0000000183F90140-0x0000000183F901D0
		public virtual void SetLayoutHorizontal() {} // 0x0000000183F900D0-0x0000000183F90140
		public virtual void SetLayoutVertical() {} // 0x000000018646D1C8-0x000000018646D1E0
		protected void SetDirty() {} // 0x0000000183F8E890-0x0000000183F8E910
	}

	public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 54853
	{
		// Fields
		protected Corner m_StartCorner; // 0x58
		protected Axis m_StartAxis; // 0x5C
		protected Vector2 m_CellSize; // 0x60
		protected Vector2 m_Spacing; // 0x68
		protected Constraint m_Constraint; // 0x70
		protected int m_ConstraintCount; // 0x74
	
		// Properties
		public Corner startCorner { get => default; set {} } // 0x0000000183F80450-0x0000000183F80460 0x000000018C07D5E8-0x000000018C07D634
		public Axis startAxis { get => default; set {} } // 0x0000000183F80460-0x0000000183F80470 0x000000018C07D59C-0x000000018C07D5E8
		public Vector2 cellSize { get => default; set {} } // 0x0000000185FEA970-0x0000000185FEA990 0x000000018C07D448-0x000000018C07D49C
		public Vector2 spacing { get => default; set {} } // 0x0000000185FEA990-0x0000000185FEA9B0 0x000000018C07D548-0x000000018C07D59C
		public Constraint constraint { get => default; set {} } // 0x0000000185FB0690-0x0000000185FB06A0 0x000000018C07D4FC-0x000000018C07D548
		public int constraintCount { get => default; set {} } // 0x0000000185FB0830-0x0000000185FB0840 0x000000018C07D49C-0x000000018C07D4FC
	
		// Nested types
		public enum Corner // TypeDefIndex: 54850
		{
			UpperLeft = 0,
			UpperRight = 1,
			LowerLeft = 2,
			LowerRight = 3
		}
	
		public enum Axis // TypeDefIndex: 54851
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		public enum Constraint // TypeDefIndex: 54852
		{
			Flexible = 0,
			FixedColumnCount = 1,
			FixedRowCount = 2
		}
	
		// Constructors
		protected GridLayoutGroup() {} // 0x0000000184DBE7D0-0x0000000184DBE800
	
		// Methods
		public override void CalculateLayoutInputHorizontal() {} // 0x00000001857A9500-0x00000001857A9660
		public override void CalculateLayoutInputVertical() {} // 0x0000000184CF8EC0-0x0000000184CF9010
		public override void SetLayoutHorizontal() {} // 0x000000018C07D42C-0x000000018C07D438
		public override void SetLayoutVertical() {} // 0x000000018C07D438-0x000000018C07D448
		private void SetCellsAlongAxis(int axis) {} // 0x000000018549DD50-0x000000018549E2A0
	}

	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 54854
	{
		// Constructors
		protected HorizontalLayoutGroup() {} // 0x0000000185311E40-0x0000000185311E50
	
		// Methods
		public override void CalculateLayoutInputHorizontal() {} // 0x0000000184430C10-0x0000000184430C40
		public override void CalculateLayoutInputVertical() {} // 0x0000000186472574-0x0000000186472584
		public override void SetLayoutHorizontal() {} // 0x000000018646D198-0x000000018646D1A8
		public override void SetLayoutVertical() {} // 0x000000018646D188-0x000000018646D198
	}

	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 54855
	{
		// Fields
		protected float m_Spacing; // 0x58
		protected bool m_ChildForceExpandWidth; // 0x5C
		protected bool m_ChildForceExpandHeight; // 0x5D
		protected bool m_ChildControlWidth; // 0x5E
		protected bool m_ChildControlHeight; // 0x5F
		protected bool m_ChildScaleWidth; // 0x60
		protected bool m_ChildScaleHeight; // 0x61
		protected bool m_ReverseArrangement; // 0x62
	
		// Properties
		public float spacing { get; set; } // 0x0000000181DE2580-0x0000000181DE2590 0x0000000185EBBC80-0x0000000185EBBCD0
		public bool childForceExpandWidth { get; set; } // 0x0000000185FB0C10-0x0000000185FB0C20 0x00000001856FC8B0-0x00000001856FC900
		public bool childForceExpandHeight { get; set; } // 0x0000000185FD1FA0-0x0000000185FD1FB0 0x000000018C07D6D4-0x000000018C07D724
		public bool childControlWidth { get; set; } // 0x0000000185FD1FC0-0x0000000185FD1FD0 0x000000018C07D684-0x000000018C07D6D4
		public bool childControlHeight { get; set; } // 0x0000000185FB8DF0-0x0000000185FB8E00 0x000000018C07D634-0x000000018C07D684
		public bool childScaleWidth { get; set; } // 0x000000018386C570-0x000000018386C580 0x000000018C07D774-0x000000018C07D7C4
		public bool childScaleHeight { get; set; } // 0x0000000185FB32C0-0x0000000185FB32D0 0x000000018C07D724-0x000000018C07D774
		public bool reverseArrangement { get; set; } // 0x0000000185FBCA50-0x0000000185FBCA60 0x000000018C07D7C4-0x000000018C07D814
	
		// Constructors
		protected HorizontalOrVerticalLayoutGroup() {} // 0x0000000185311E40-0x0000000185311E50
	
		// Methods
		protected void CalcAlongAxis(int axis, bool isVertical) {} // 0x0000000184433780-0x0000000184433E10
		protected void SetChildrenAlongAxis(int axis, bool isVertical) {} // 0x00000001844328B0-0x0000000184433780
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) {
			min = default;
			preferred = default;
			flexible = default;
		} // 0x0000000184433E10-0x0000000184434150
	}

	public interface ILayoutElement // TypeDefIndex: 54856
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

	public interface ILayoutController // TypeDefIndex: 54857
	{
		// Methods
		void SetLayoutHorizontal();
		void SetLayoutVertical();
	}

	public interface ILayoutGroup : ILayoutController // TypeDefIndex: 54858
	{
	}

	public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 54859
	{
	}

	public interface ILayoutIgnorer // TypeDefIndex: 54860
	{
		// Properties
		bool ignoreLayout { get; }
	}

	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 54861
	{
		// Fields
		private bool m_IgnoreLayout; // 0x18
		private float m_MinWidth; // 0x1C
		private float m_MinHeight; // 0x20
		private float m_PreferredWidth; // 0x24
		private float m_PreferredHeight; // 0x28
		private float m_FlexibleWidth; // 0x2C
		private float m_FlexibleHeight; // 0x30
		private int m_LayoutPriority; // 0x34
	
		// Properties
		public virtual bool ignoreLayout { get => default; set {} } // 0x00000001813C0430-0x00000001813C0440 0x0000000184210240-0x00000001842102A0
		public virtual float minWidth { get => default; set {} } // 0x0000000185FB0850-0x0000000185FB0860 0x000000018C086298-0x000000018C0862F4
		public virtual float minHeight { get => default; set {} } // 0x0000000181C9AC70-0x0000000181C9AC80 0x000000018C08623C-0x000000018C086298
		public virtual float preferredWidth { get => default; set {} } // 0x0000000185FB3810-0x0000000185FB3820 0x00000001845A3150-0x00000001845A31B0
		public virtual float preferredHeight { get => default; set {} } // 0x0000000185FB0A50-0x0000000185FB0A60 0x00000001845A3800-0x00000001845A3860
		public virtual float flexibleWidth { get => default; set {} } // 0x0000000185FB09A0-0x0000000185FB09B0 0x00000001850D4BA0-0x00000001850D4C00
		public virtual float flexibleHeight { get => default; set {} } // 0x0000000185FB0BE0-0x0000000185FB0BF0 0x000000018C086188-0x000000018C0861E4
		public virtual int layoutPriority { get => default; set {} } // 0x0000000185FB07C0-0x0000000185FB07D0 0x000000018C0861E4-0x000000018C08623C
	
		// Constructors
		protected LayoutElement() {} // 0x00000001840C3C30-0x00000001840C3CA0
	
		// Methods
		public virtual void CalculateLayoutInputHorizontal() {} // 0x0000000185492010-0x0000000185492020
		public virtual void CalculateLayoutInputVertical() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnEnable() {} // 0x000000018420FC70-0x000000018420FC80
		protected override void OnTransformParentChanged() {} // 0x000000018420FC70-0x000000018420FC80
		protected override void OnDisable() {} // 0x000000018420FC70-0x000000018420FC80
		protected override void OnDidApplyAnimationProperties() {} // 0x000000018420FC70-0x000000018420FC80
		protected override void OnBeforeTransformParentChanged() {} // 0x000000018420FC70-0x000000018420FC80
		protected void SetDirty() {} // 0x000000018420FC80-0x000000018420FD20
	}

	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup // TypeDefIndex: 54863
	{
		// Fields
		protected RectOffset m_Padding; // 0x18
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
		public RectOffset padding { get; set; } // 0x0000000184431810-0x0000000184431ED0 
		public TextAnchor childAlignment { get; set; } // 0x0000000186472350-0x0000000186472358 0x000000018646D240-0x000000018646D248
		protected RectTransform rectTransform { get; } // 0x000000018646D200-0x000000018646D210 
		protected List<RectTransform> rectChildren { get; } // 0x000000018646D1E0-0x000000018646D1F0 
		public virtual float minWidth { get; } // 0x00000001813AE580-0x00000001813AE590 
		public virtual float preferredWidth { get; }
		public virtual float flexibleWidth { get; }
		public virtual float minHeight { get; } // 0x0000000184DBEA30-0x0000000184DBEB50 
		public virtual float preferredHeight { get; } // 0x00000001844305F0-0x0000000184430600 
		public virtual float flexibleHeight { get; } // 0x0000000184430300-0x0000000184430360 
		public virtual int layoutPriority { get; } // 0x00000001844305F0-0x0000000184430600 
		private bool isRootLayoutGroup { get; } // 0x0000000181378230-0x0000000181378240 
	
		// Nested types
		private sealed class _DelayedSetDirty_d__56 : IEnumerator<object> // TypeDefIndex: 54862
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RectTransform rectTransform; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018C086394-0x000000018C0863E0 
			object IEnumerator.Current { get => default; } // 0x0000000181460F60-0x0000000181460F70 
	
			// Constructors
			public _DelayedSetDirty_d__56() {} // Dummy constructor
			public _DelayedSetDirty_d__56(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x00000001845A36B0-0x00000001845A3700
			private bool MoveNext() => default; // 0x00000001813B88B0-0x00000001813B88C0
			void IEnumerator.Reset() {} // 0x0000000184431ED0-0x0000000184432000
		}
	
		// Constructors
		protected LayoutGroup() {} // 0x000000018C0862F4-0x000000018C086300
	
		// Methods
		public virtual void CalculateLayoutInputHorizontal() {} // 0x000000018646D1F0-0x000000018646D200
		public abstract void CalculateLayoutInputVertical(); // 0x000000018646D210-0x000000018646D218
		public abstract void SetLayoutHorizontal(); // 0x000000018646ED38-0x000000018646ED44
		public abstract void SetLayoutVertical(); // 0x000000018646ED44-0x000000018646ED50
		protected override void OnEnable() {} // 0x0000000184431630-0x0000000184431810
		protected override void OnDisable() {} // 0x0000000184432000-0x0000000184432050
		protected override void OnDidApplyAnimationProperties() {} // 0x00000001844324C0-0x0000000184432530
		protected float GetTotalMinSize(int axis) => default; // 0x000000018C086300-0x000000018C086394
		protected float GetTotalPreferredSize(int axis) => default; // 0x00000001844312E0-0x0000000184431630
		protected float GetTotalFlexibleSize(int axis) => default; // 0x000000018549E2A0-0x000000018549E360
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) => default; // 0x00000001844320F0-0x00000001844324C0
		protected float GetAlignmentOnAxis(int axis) => default; // 0x0000000184430630-0x00000001844308F0
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) {} // 0x0000000184430600-0x0000000184430630
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) {} // 0x00000001844305F0-0x0000000184430600
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) {}
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) {} // 0x00000001844308F0-0x00000001844309D0
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) {} // 0x000000018442FE80-0x000000018442FEE0
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnTransformChildrenChanged() {} // 0x00000001853C8040-0x00000001853C80D0
		protected void SetProperty<T>(ref ref T currentValue, T newValue) {} // 0x0000000181377E40-0x0000000181377E50
		protected void SetDirty() {} // 0x000000018C086774-0x000000018C0867C0
		private IEnumerator DelayedSetDirty(RectTransform rectTransform) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 54865
	{
		// Fields
		private RectTransform m_ToRebuild; // 0x10
		private int m_CachedHashFromTransform; // 0x18
		private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x00
	
		// Properties
		public Transform transform { get => default; } // 0x000000018423E710-0x000000018423E930 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 54864
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Component> __9__10_0; // 0x08
			public static UnityAction<Component> __9__12_0; // 0x10
			public static UnityAction<Component> __9__12_1; // 0x18
			public static UnityAction<Component> __9__12_2; // 0x20
			public static UnityAction<Component> __9__12_3; // 0x28
	
			// Constructors
			static __c() {} // 0x000000018423E930-0x000000018423E9D0
			public __c() {} // 0x000000018646DA14-0x000000018646DA34
	
			// Methods
			internal LayoutRebuilder _.cctor_b__5_0() => default; // 0x0000000185A88980-0x0000000185A88B70
			internal void _.cctor_b__5_1(LayoutRebuilder x) {} // 0x0000000184EEE670-0x0000000184EEE6C0
			internal bool _StripDisabledBehavioursFromList_b__10_0(Component e) => default; // 0x000000018346D130-0x000000018346D140
			internal void _Rebuild_b__12_0(Component e) {} // 0x000000018528D760-0x000000018528D7C0
			internal void _Rebuild_b__12_1(Component e) {} // 0x0000000183FD2AA0-0x0000000183FD2BE0
			internal void _Rebuild_b__12_2(Component e) {} // 0x0000000184A04260-0x0000000184A04350
			internal void _Rebuild_b__12_3(Component e) {} // 0x0000000184A04350-0x0000000184A04710
		}
	
		// Constructors
		static LayoutRebuilder() {} // 0x0000000183FD0230-0x0000000183FD13A0
		public LayoutRebuilder() {} // 0x0000000183F8FD40-0x0000000183F8FDF0
	
		// Methods
		private void Initialize(RectTransform controller) {} // 0x0000000184A04710-0x0000000184A04F60
		private void Clear() {} // 0x0000000183FD2120-0x0000000183FD2A60
		private static void ReapplyDrivenProperties(RectTransform driven) {} // 0x0000000183FD2CF0-0x0000000183FD3150
		public bool IsDestroyed() => default; // 0x00000001842418F0-0x0000000184241970
		private static void StripDisabledBehavioursFromList(List<Component> components) {} // 0x0000000185492010-0x0000000185492020
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) {} // 0x00000001813AE560-0x00000001813AE570
		public void Rebuild(CanvasUpdate executing) {} // 0x0000000184DBED70-0x0000000184DBEDC0
		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) {} // 0x000000018C0863E0-0x000000018C086440
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) {} // 0x0000000185492010-0x0000000185492020
		public static void MarkLayoutForRebuild(RectTransform rect) {} // 0x0000000185F78970-0x0000000185F789D0
		private static bool ValidController(RectTransform layoutRoot, List<Component> comps) => default; // 0x0000000185492010-0x0000000185492020
		private static void MarkLayoutRootForRebuild(RectTransform controller) {} // 0x0000000184902230-0x0000000184902270
		public void LayoutComplete() {} // 0x00000001840AB790-0x00000001840AC100
		public void GraphicUpdateComplete() {} // 0x0000000183FCDB70-0x0000000183FCDC30
		public override int GetHashCode() => default; // 0x0000000184430A10-0x0000000184430C10
		public override bool Equals(object obj) => default; // 0x0000000183F8FDF0-0x0000000183F900D0
		public override string ToString() => default; // 0x0000000184CF8CD0-0x0000000184CF8EC0
	}

	public static class LayoutUtility // TypeDefIndex: 54867
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 54866
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ILayoutElement, float> __9__3_0; // 0x08
			public static Func<ILayoutElement, float> __9__4_0; // 0x10
			public static Func<ILayoutElement, float> __9__4_1; // 0x18
			public static Func<ILayoutElement, float> __9__5_0; // 0x20
			public static Func<ILayoutElement, float> __9__6_0; // 0x28
			public static Func<ILayoutElement, float> __9__7_0; // 0x30
			public static Func<ILayoutElement, float> __9__7_1; // 0x38
			public static Func<ILayoutElement, float> __9__8_0; // 0x40
	
			// Constructors
			static __c() {} // 0x00000001844342B0-0x00000001844343E0
			public __c() {} // 0x0000000184434150-0x0000000184434180
	
			// Methods
			internal float _GetMinWidth_b__3_0(ILayoutElement e) => default; // 0x0000000184434180-0x00000001844342B0
			internal float _GetPreferredWidth_b__4_0(ILayoutElement e) => default; // 0x0000000184432790-0x00000001844328B0
			internal float _GetPreferredWidth_b__4_1(ILayoutElement e) => default; // 0x00000001844343E0-0x00000001844345F0
			internal float _GetFlexibleWidth_b__5_0(ILayoutElement e) => default; // 0x0000000184432670-0x0000000184432790
			internal float _GetMinHeight_b__6_0(ILayoutElement e) => default; // 0x0000000184D66BF0-0x0000000184D66D10
			internal float _GetPreferredHeight_b__7_0(ILayoutElement e) => default; // 0x0000000184D66E30-0x0000000184D67060
			internal float _GetPreferredHeight_b__7_1(ILayoutElement e) => default; // 0x0000000184D66D10-0x0000000184D66E30
			internal float _GetFlexibleHeight_b__8_0(ILayoutElement e) => default; // 0x000000018646EDA4-0x000000018646EDC4
		}
	
		// Methods
		public static float GetMinSize(RectTransform rect, int axis) => default; // 0x0000000183FCC120-0x0000000183FCCFD0
		public static float GetPreferredSize(RectTransform rect, int axis) => default; // 0x0000000185F78B50-0x0000000185F78BB0
		public static float GetFlexibleSize(RectTransform rect, int axis) => default; // 0x0000000185492010-0x0000000185492020
		public static float GetMinWidth(RectTransform rect) => default; // 0x0000000184C78740-0x0000000184C78760
		public static float GetPreferredWidth(RectTransform rect) => default; // 0x0000000184C78760-0x0000000184C788A0
		public static float GetFlexibleWidth(RectTransform rect) => default; // 0x0000000183F90E10-0x0000000183F90F70
		public static float GetMinHeight(RectTransform rect) => default; // 0x0000000183F907B0-0x0000000183F90900
		public static float GetPreferredHeight(RectTransform rect) => default; // 0x0000000183F90A70-0x0000000183F90BD0
		public static float GetFlexibleHeight(RectTransform rect) => default; // 0x0000000183F90A70-0x0000000183F90BD0
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) => default; // 0x0000000183F90900-0x0000000183F90A70
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) {
			source = default;
			return default;
		} // 0x0000000183F90BD0-0x0000000183F90CC0
	}

	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 54868
	{
		// Constructors
		protected VerticalLayoutGroup() {} // 0x0000000185311E40-0x0000000185311E50
	
		// Methods
		public override void CalculateLayoutInputHorizontal() {} // 0x00000001844305C0-0x00000001844305F0
		public override void CalculateLayoutInputVertical() {} // 0x0000000186472584-0x0000000186472594
		public override void SetLayoutHorizontal() {} // 0x000000018646D1B8-0x000000018646D1C8
		public override void SetLayoutVertical() {} // 0x000000018646D1A8-0x000000018646D1B8
	}

	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 54869
	{
		// Fields
		[NonSerialized]
		private RectTransform m_RectTransform; // 0x18
		private bool m_ShowMaskGraphic; // 0x20
		[NonSerialized]
		private Graphic m_Graphic; // 0x28
		[NonSerialized]
		private Material m_MaskMaterial; // 0x30
		[NonSerialized]
		private Material m_UnmaskMaterial; // 0x38
	
		// Properties
		public RectTransform rectTransform { get => default; } // 0x0000000183FCABD0-0x0000000183FCAC30 
		public bool showMaskGraphic { get => default; set {} } // 0x00000001813ECBF0-0x00000001813ECC00 0x000000018C086440-0x000000018C0864CC
		public Graphic graphic { get => default; } // 0x00000001845E5600-0x00000001845E5660 
	
		// Constructors
		protected Mask() {} // 0x0000000185C20250-0x0000000185C20260
	
		// Methods
		public virtual bool MaskEnabled() => default; // 0x00000001845E5020-0x00000001845E50A0
		public virtual void OnSiblingGraphicEnabledDisabled() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnEnable() {} // 0x00000001845E54B0-0x00000001845E5600
		protected override void OnDisable() {} // 0x00000001845E50A0-0x00000001845E5280
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => default; // 0x0000000183FCAB30-0x0000000183FCABD0
		public virtual Material GetModifiedMaterial(Material baseMaterial) => default; // 0x00000001845E52C0-0x00000001845E54B0
	}

	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 54871
	{
		// Fields
		[NonSerialized]
		protected bool m_ShouldRecalculateStencil; // 0xB0
		[NonSerialized]
		protected Material m_MaskMaterial; // 0xB8
		[NonSerialized]
		private RectMask2D m_ParentMask; // 0xC0
		private bool m_Maskable; // 0xC8
		private bool m_IsMaskingGraphic; // 0xC9
		[NonSerialized]
		protected bool m_IncludeForMasking; // 0xCA
		private CullStateChangedEvent m_OnCullStateChanged; // 0xD0
		[NonSerialized]
		protected bool m_ShouldRecalculate; // 0xD8
		[NonSerialized]
		protected int m_StencilValue; // 0xDC
		private readonly Vector3[] m_Corners; // 0xE0
	
		// Properties
		public CullStateChangedEvent onCullStateChanged { get; set; } // 0x000000018774BD78-0x000000018774BD8C 0x0000000185FB2DA0-0x0000000185FB2DB0
		public bool maskable { get; set; } // 0x000000018C0864CC-0x000000018C0864F4 0x0000000185FB9C30-0x0000000185FB9C40
		public bool isMaskingGraphic { get; set; } // 0x00000001845E4500-0x00000001845E4510 0x00000001840484A0-0x0000000184048670
		private Rect rootCanvasRect { get; } // 0x000000018423BA40-0x000000018423BCB0 
		GameObject IClippable.gameObject { get; } // 0x00000001840C2510-0x00000001840C2590 
	
		// Nested types
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 54870
		{
			// Constructors
			public CullStateChangedEvent() {} // 0x0000000185FB15A0-0x0000000185FB15B0
		}
	
		// Constructors
		protected MaskableGraphic() {} // 0x000000018646E428-0x000000018646E430
	
		// Methods
		public virtual Material GetModifiedMaterial(Material baseMaterial) => default; // 0x00000001840E5DF0-0x00000001840E6120
		public virtual void Cull(Rect clipRect, bool validRect) {} // 0x00000001840E5BC0-0x00000001840E5DF0
		private void UpdateCull(bool cull) {} // 0x0000000184CAC370-0x0000000184CAC4F0
		public virtual void SetClipRect(Rect clipRect, bool validRect) {} // 0x00000001840E5990-0x00000001840E5A60
		public virtual void SetClipSoftness(Vector2 clipSoftness) {} // 0x00000001840E58C0-0x00000001840E5990
		public virtual void SetHGClipSoftness(Vector4 hgClipSoftness) {} // 0x000000018423B9F0-0x000000018423BA40
		protected override void OnEnable() {} // 0x0000000184241410-0x00000001842414D0
		protected override void OnDisable() {} // 0x00000001850B7CA0-0x00000001850B7D00
		protected override void OnTransformParentChanged() {} // 0x0000000185492010-0x0000000185492020
		public virtual void ParentMaskStateChanged() {} // 0x0000000183F920C0-0x0000000183F92880
		protected override void OnCanvasHierarchyChanged() {} // 0x00000001840EB0A0-0x00000001840EC230
		private void UpdateClipParent() {} // 0x0000000183FCA880-0x0000000183FCA890
		public virtual void RecalculateClipping() {} // 0x0000000184241240-0x00000001842412D0
		public virtual void RecalculateMasking() {} // 0x00000001840C1D50-0x00000001840C24B0
	}

	public class MaskUtilities // TypeDefIndex: 54872
	{
		// Constructors
		public MaskUtilities() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void Notify2DMaskStateChanged(Component mask) {} // 0x0000000183FCCFD0-0x0000000183FCD380
		public static void NotifyStencilStateChanged(Component mask) {} // 0x0000000183FCAC30-0x0000000183FCAE60
		public static Transform FindRootSortOverrideCanvas(Transform start) => default; // 0x0000000183FCB9D0-0x0000000183FCBD50
		public static int GetStencilDepth(Transform transform, Transform stopAfter) => default; // 0x0000000183FD3330-0x0000000183FD3800
		public static bool IsDescendantOrSelf(Transform father, Transform child) => default; // 0x0000000183FD1790-0x0000000183FD1BF0
		public static RectMask2D GetRectMaskForClippable(IClippable clippable) => default; // 0x000000018423BCB0-0x000000018423C660
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks) {} // 0x0000000183FCB240-0x0000000183FCB560
	}

	public interface IMaterialModifier // TypeDefIndex: 54873
	{
		// Methods
		Material GetModifiedMaterial(Material baseMaterial);
	}

	internal static class Misc // TypeDefIndex: 54874
	{
		// Methods
		public static void Destroy(UnityEngine.Object obj) {} // 0x000000018C087050-0x000000018C08711C
		public static void DestroyImmediate(UnityEngine.Object obj) {} // 0x0000000185B981E0-0x0000000185B98260
	}

	internal static class MultipleDisplayUtilities // TypeDefIndex: 54875
	{
		// Methods
		public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) => default; // 0x000000018C08711C-0x000000018C0871F4
		public static Vector3 RelativeMouseAtScaled(Vector2 position) => default; // 0x0000000184236DB0-0x0000000184237390
	}

	[Serializable]
	public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 54877
	{
		// Fields
		private Mode m_Mode; // 0x00
		private bool m_WrapAround; // 0x04
		private Selectable m_SelectOnUp; // 0x08
		private Selectable m_SelectOnDown; // 0x10
		private Selectable m_SelectOnLeft; // 0x18
		private Selectable m_SelectOnRight; // 0x20
	
		// Properties
		public Mode mode { get => default; set {} } // 0x00000001818226B0-0x00000001818226C0 0x00000001818AA390-0x00000001818AA3A0
		public bool wrapAround { get => default; set {} } // 0x0000000185FB6C60-0x0000000185FB6C70 0x0000000185FBF450-0x0000000185FBF460
		public Selectable selectOnUp { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public Selectable selectOnDown { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public Selectable selectOnLeft { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public Selectable selectOnRight { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public static Navigation defaultNavigation { get => default; } // 0x0000000185FEAA30-0x0000000185FEAA50 
	
		// Nested types
		public enum Mode // TypeDefIndex: 54876
		{
			None = 0,
			Horizontal = 1,
			Vertical = 2,
			Automatic = 3,
			Explicit = 4
		}
	
		// Methods
		public bool Equals(Navigation other) => default; // 0x00000001850A6D30-0x00000001850A6E50
	}

	public class RawImage : MaskableGraphic // TypeDefIndex: 54878
	{
		// Fields
		private Texture m_Texture; // 0xE8
		private Rect m_UVRect; // 0xF0
	
		// Properties
		public override Texture mainTexture { get => default; } // 0x00000001853C9FC0-0x00000001853CA110 
		public Texture texture { get => default; set {} } // 0x0000000185FB2360-0x0000000185FB2370 0x00000001852C9650-0x00000001852C96F0
		public Rect uvRect { get => default; set {} } // 0x0000000185FCCCF0-0x0000000185FCCD00 0x000000018C08732C-0x000000018C08738C
	
		// Constructors
		protected RawImage() {} // 0x0000000184B37DE0-0x0000000184B37E10
	
		// Methods
		public override void SetNativeSize() {} // 0x000000018C0871F4-0x000000018C08732C
		protected override void OnPopulateMesh(VertexHelper vh) {} // 0x00000001840E0720-0x00000001840E0B10
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000185029CD0-0x0000000185029D00
	}

	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 54879
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
		private Vector4 m_Padding; // 0x5C
		private Vector2Int m_Softness; // 0x6C
		private Vector4 m_HGSoftness; // 0x74
		[NonSerialized]
		private Canvas m_Canvas; // 0x88
		private Vector3[] m_Corners; // 0x90
	
		// Properties
		public Vector4 padding { get => default; set {} } // 0x0000000185FD4790-0x0000000185FD47A0 0x000000018C087820-0x000000018C087830
		public Vector2Int softness { get => default; set {} } // 0x0000000185FB6D90-0x0000000185FB6DA0 0x000000018C087830-0x000000018C087858
		public Vector4 hgSoftness { get => default; set {} } // 0x0000000185FBEAF0-0x0000000185FBEB00 0x000000018C0877E0-0x000000018C087820
		private Canvas Canvas { get => default; } // 0x00000001840E2FA0-0x00000001840E31C0 
		public Rect canvasRect { get => default; } // 0x00000001840E2990-0x00000001840E2C60 
		public RectTransform rectTransform { get => default; } // 0x00000001840E2C60-0x00000001840E2CC0 
		private Rect rootCanvasRect { get => default; } // 0x00000001840E7850-0x00000001840E8150 
	
		// Constructors
		protected RectMask2D() {} // 0x000000018521A0C0-0x000000018521A250
	
		// Methods
		protected override void OnEnable() {} // 0x0000000183FCB100-0x0000000183FCB130
		protected override void OnDisable() {} // 0x0000000183FCB000-0x0000000183FCB0A0
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => default; // 0x0000000183FCB560-0x0000000183FCB620
		public virtual void PerformClipping() {} // 0x00000001840E4680-0x00000001840E53D0
		public virtual void UpdateClipSoftness() {} // 0x00000001840E53D0-0x00000001840E58C0
		public void AddClippable(IClippable clippable) {} // 0x0000000184F25410-0x0000000184F255D0
		public void RemoveClippable(IClippable clippable) {} // 0x0000000184CABFD0-0x0000000184CAC370
		protected override void OnTransformParentChanged() {} // 0x0000000185FB8040-0x0000000185FB8050
		protected override void OnCanvasHierarchyChanged() {} // 0x0000000185570D30-0x0000000185570D60
	}

	public class Scrollbar : Selectable, IBeginDragHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 54884
	{
		// Fields
		private RectTransform m_HandleRect; // 0x180
		private Direction m_Direction; // 0x188
		private float m_Value; // 0x18C
		private float m_Size; // 0x190
		private int m_NumberOfSteps; // 0x194
		private ScrollEvent m_OnValueChanged; // 0x198
		private RectTransform m_ContainerRect; // 0x1A0
		private Vector2 m_Offset; // 0x1A8
		private DrivenRectTransformTracker m_Tracker; // 0x1B0
		private Coroutine m_PointerDownRepeat; // 0x1B8
		private bool isPointerDownAndNotDragging; // 0x1C0
		private bool m_DelayedUpdateVisuals; // 0x1C1
	
		// Properties
		public RectTransform handleRect { get => default; set {} } // 0x000000018C0895F8-0x000000018C089604 0x0000000185FB9A90-0x0000000185FB9AA0
		public Direction direction { get => default; set {} } // 0x00000001840DF320-0x00000001840DF390 0x0000000185FEAA80-0x0000000185FEAA90
		public float value { get => default; set {} } // 0x0000000185FB88A0-0x0000000185FB88B0 0x00000001864734AC-0x00000001864734C0
		public float size { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x0000000185492010-0x0000000185492020
		public int numberOfSteps { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x0000000185AD4C20-0x0000000185AD4C60
		public ScrollEvent onValueChanged { get => default; set {} } // 0x00000001856CD2A0-0x00000001856CD2B0 0x0000000185A81B00-0x0000000185A81B20
		private float stepSize { get => default; } // 0x0000000185AD4C60-0x0000000185AD4D70 
		private Axis axis { get => default; } // 0x000000018C089140-0x000000018C0891C8 
		private bool reverseValue { get => default; } // 0x000000018C0893D4-0x000000018C08949C 
		Transform ICanvasElement.transform { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Nested types
		public enum Direction // TypeDefIndex: 54880
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}
	
		[Serializable]
		public class ScrollEvent : UnityEvent<float> // TypeDefIndex: 54881
		{
			// Constructors
			public ScrollEvent() {} // 0x0000000185FB8280-0x0000000185FB8290
		}
	
		private enum Axis // TypeDefIndex: 54882
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		private sealed class _ClickRepeat_d__58 : IEnumerator<object> // TypeDefIndex: 54883
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Scrollbar __4__this; // 0x20
			public Vector2 screenPosition; // 0x28
			public Camera camera; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000184817D60-0x0000000184817E10 
			object IEnumerator.Current { get => default; } // 0x000000018646DBC0-0x000000018646DBCC 
	
			// Constructors
			public _ClickRepeat_d__58() {} // Dummy constructor
			public _ClickRepeat_d__58(int __1__state) {} // 0x000000018C089914-0x000000018C08997C
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FB1170-0x0000000185FB1180
			private bool MoveNext() => default; // 0x000000018C0898B8-0x000000018C089914
			void IEnumerator.Reset() {} // 0x0000000184231140-0x0000000184231170
		}
	
		// Constructors
		protected Scrollbar() {} // 0x000000018C08997C-0x000000018C0899EC
	
		// Methods
		public virtual void SetValueWithoutNotify(float input) {} // 0x000000018C089888-0x000000018C0898B8
		public virtual void Rebuild(CanvasUpdate executing) {} // 0x0000000184231070-0x0000000184231140
		public virtual void LayoutComplete() {} // 0x0000000185D20E10-0x0000000185D20E40
		public virtual void GraphicUpdateComplete() {} // 0x0000000184231050-0x0000000184231070
		protected override void OnEnable() {} // 0x0000000184231170-0x0000000184231190
		protected override void OnDisable() {} // 0x0000000184230EC0-0x0000000184231050
		protected virtual void Update() {} // 0x000000018C089604-0x000000018C089888
		private void UpdateCachedReferences() {} // 0x000000018C088DA0-0x000000018C088E0C
		private void Set(float input, bool sendCallback = true /* Metadata: 0x0207BA33 */) {} // 0x000000018C088EDC-0x000000018C088F30
		protected override void OnRectTransformDimensionsChange() {} // 0x000000018C088F30-0x000000018C089140
		private void UpdateVisuals() {} // 0x000000018C088D28-0x000000018C088DA0
		private void UpdateDrag(PointerEventData eventData) {} // 0x000000018C088C98-0x000000018C088D28
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) {} // 0x000000018C08949C-0x000000018C0894BC
		private bool MayDrag(PointerEventData eventData) => default; // 0x000000018C0891E4-0x000000018C0893D4
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x000000018C088E40-0x000000018C088E74
		public virtual void OnDrag(PointerEventData eventData) {} // 0x000000018C088E74-0x000000018C088EA8
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018C088EA8-0x000000018C088EDC
		protected IEnumerator ClickRepeat(PointerEventData eventData) => default; // 0x000000018C088E0C-0x000000018C088E40
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) => default; // 0x000000018C0891C8-0x000000018C0891E4
		public override void OnPointerUp(PointerEventData eventData) {} // 0x000000018C0894BC-0x000000018C0895F8
		public override void OnMove(AxisEventData eventData) {} // 0x000000018646DBCC-0x000000018646DBD4
		public override Selectable FindSelectableOnLeft() => default; // 0x0000000184817D20-0x0000000184817D60
		public override Selectable FindSelectableOnRight() => default; // 0x0000000181378230-0x0000000181378240
		public override Selectable FindSelectableOnUp() => default; // 0x0000000185492010-0x0000000185492020
		public override Selectable FindSelectableOnDown() => default; // 0x000000018C08D988-0x000000018C08DBB0
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x0000000181377E40-0x0000000181377E50
		public void SetDirection(Direction direction, bool includeRectLayouts) {} // 0x000000018C08DBB0-0x000000018C08DBFC
	}

	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup // TypeDefIndex: 54888
	{
		// Fields
		private RectTransform m_Content; // 0x18
		private bool m_Horizontal; // 0x20
		private bool m_Vertical; // 0x21
		protected GameObject m_scrollEnableNode; // 0x28
		private MovementType m_MovementType; // 0x30
		private float m_Elasticity; // 0x34
		private bool m_Inertia; // 0x38
		private float m_DecelerationRate; // 0x3C
		private float m_ScrollSensitivity; // 0x40
		private RectTransform m_Viewport; // 0x48
		private Scrollbar m_HorizontalScrollbar; // 0x50
		private Scrollbar m_VerticalScrollbar; // 0x58
		private ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x60
		private ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x64
		private float m_HorizontalScrollbarSpacing; // 0x68
		private float m_VerticalScrollbarSpacing; // 0x6C
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
		public RectTransform content { get => default; set {} } // 0x0000000184088E70-0x0000000184088E80 0x00000001813ECBF0-0x00000001813ECC00
		public bool horizontal { get => default; set {} } // 0x00000001813EE9B0-0x00000001813EE9C0 0x00000001813ECBD0-0x00000001813ECBE0
		public bool vertical { get => default; set {} } // 0x00000001813EE990-0x00000001813EE9A0 0x00000001813CFF60-0x00000001813CFF70
		public MovementType movementType { get => default; set {} } // 0x00000001813D0A90-0x00000001813D0AA0 0x0000000185FB8060-0x0000000185FB8070
		public float elasticity { get => default; set {} } // 0x0000000185FB8A50-0x0000000185FB8A60 0x0000000185FB0700-0x0000000185FB0710
		public bool inertia { get => default; set {} } // 0x0000000185FAFE20-0x0000000185FAFE30 0x0000000185FB0580-0x0000000185FB0590
		public float decelerationRate { get => default; set {} } // 0x0000000185FB05E0-0x0000000185FB05F0 0x0000000185FB0590-0x0000000185FB05A0
		public float scrollSensitivity { get => default; set {} } // 0x0000000185FB05F0-0x0000000185FB0600 0x00000001813ECF20-0x00000001813ECF30
		public RectTransform viewport { get => default; set {} } // 0x000000018C088C74-0x000000018C088C98 0x0000000181460F60-0x0000000181460F70
		public Scrollbar horizontalScrollbar { get => default; set {} } // 0x000000018C088910-0x000000018C088A98 0x00000001813F1630-0x00000001813F1640
		public Scrollbar verticalScrollbar { get => default; set {} } // 0x000000018C088AEC-0x000000018C088C74 0x000000018143E3B0-0x000000018143E3C0
		public ScrollbarVisibility horizontalScrollbarVisibility { get => default; set {} } // 0x000000018C088904-0x000000018C088910 0x0000000185FB2020-0x0000000185FB2030
		public ScrollbarVisibility verticalScrollbarVisibility { get => default; set {} } // 0x000000018C088AE0-0x000000018C088AEC 0x0000000185FB8230-0x0000000185FB8240
		public float horizontalScrollbarSpacing { get => default; set {} } // 0x000000018C0888F8-0x000000018C088904 0x0000000185FB8A10-0x0000000185FB8A20
		public float verticalScrollbarSpacing { get => default; set {} } // 0x000000018C088AD4-0x000000018C088AE0 0x0000000181460F70-0x0000000181460F80
		public ScrollRectEvent onValueChanged { get => default; set {} } // 0x00000001874BE90C-0x00000001874BE91C 0x00000001840E1D90-0x00000001840E1FA0
		protected RectTransform viewRect { get => default; } // 0x0000000185FEAA50-0x0000000185FEAA70 
		public Vector2 velocity { get => default; set {} } // 0x0000000185FEAA70-0x0000000185FEAA80 0x00000001854F9ED0-0x00000001854F9F70
		private RectTransform rectTransform { get => default; } // 0x0000000184819970-0x0000000184819AC0 
		public Vector2 normalizedPosition { get => default; set {} } // 0x000000018C088A98-0x000000018C088AD4 0x00000001840E0320-0x00000001840E04C0
		public float horizontalNormalizedPosition { get => default; set {} } // 0x00000001864716EC-0x00000001864716F8 0x00000001840E04C0-0x00000001840E0680
		public float verticalNormalizedPosition { get => default; set {} } // 0x0000000186475090-0x00000001864750A0 0x00000001864716EC-0x00000001864716F8
		public bool hScrollingNeeded { get => default; } // 0x0000000184DAE5D0-0x0000000184DAE680 
		public bool vScrollingNeeded { get => default; } // 0x0000000185492010-0x0000000185492020 
		public virtual float minWidth { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual float preferredWidth { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual float flexibleWidth { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual float minHeight { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual float preferredHeight { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual float flexibleHeight { get => default; } // 0x0000000185FBE2F0-0x0000000185FBE300 
		public virtual int layoutPriority { get => default; } // 0x0000000185338F50-0x0000000185339020 
		Transform ICanvasElement.transform { get => default; } // 0x0000000184819AC0-0x0000000184819B00 
	
		// Nested types
		public enum MovementType // TypeDefIndex: 54885
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		public enum ScrollbarVisibility // TypeDefIndex: 54886
		{
			Permanent = 0,
			AutoHide = 1,
			AutoHideAndExpandViewport = 2
		}
	
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 54887
		{
			// Constructors
			public ScrollRectEvent() {} // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		protected ScrollRect() {} // 0x0000000185338E00-0x0000000185338E60
	
		// Methods
		public virtual void Rebuild(CanvasUpdate executing) {} // 0x0000000185492010-0x0000000185492020
		public virtual void LayoutComplete() {} // 0x0000000185492010-0x0000000185492020
		public virtual void GraphicUpdateComplete() {} // 0x0000000185339020-0x00000001853393C0
		private void UpdateCachedData() {} // 0x00000001854F9CE0-0x00000001854F9E50
		protected override void OnEnable() {} // 0x00000001854F9AE0-0x00000001854F9CA0
		protected override void OnDisable() {} // 0x00000001856F4BB0-0x00000001856F4C20
		public override bool IsActive() => default; // 0x000000018467B200-0x000000018467B2D0
		public void EnsureLayoutHasRebuilt() {} // 0x000000018C0888CC-0x000000018C0888D8
		public virtual void StopMovement() {} // 0x000000018467AD60-0x000000018467AF10
		public virtual void OnScroll(PointerEventData data) {} // 0x000000018C0888D8-0x000000018C0888F8
		protected virtual void _CustomSetPosOnScroll(Vector2 position) {} // 0x0000000185D74240-0x0000000185D74270
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x000000018C0883A4-0x000000018C0884D0
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x000000018C0887C0-0x000000018C0887E4
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x000000018C0884D0-0x000000018C0887C0
		public virtual void OnDrag(PointerEventData eventData) {} // 0x000000018557AFD0-0x000000018557B0D0
		protected virtual void SetContentAnchoredPosition(Vector2 position) {} // 0x0000000184213AF0-0x0000000184214410
		protected virtual void LateUpdate() {} // 0x0000000185338E60-0x0000000185338F50
		protected void UpdatePrevData() {} // 0x00000001840DF4B0-0x00000001840DF690
		protected virtual void UpdateScrollbars(Vector2 offset) {} // 0x00000001840E02E0-0x00000001840E0320
		protected virtual void SetHorizontalNormalizedPosition(float value) {} // 0x000000018467AF40-0x000000018467AF50
		protected virtual void SetVerticalNormalizedPosition(float value) {} // 0x000000018467AF50-0x000000018467B200
		protected virtual void SetNormalizedPosition(float value, int axis) {} // 0x000000018C0887E4-0x000000018C08882C
		private static float RubberDelta(float overStretching, float viewSize) => default; // 0x00000001854F9E50-0x00000001854F9E60
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000184DAE530-0x0000000184DAE5D0
		public virtual void CalculateLayoutInputHorizontal() {} // 0x0000000185492010-0x0000000185492020
		public virtual void CalculateLayoutInputVertical() {} // 0x0000000185FD5E00-0x0000000185FD5E10
		public virtual void SetLayoutHorizontal() {} // 0x00000001840E0180-0x00000001840E02E0
		public virtual void SetLayoutVertical() {} // 0x0000000184DAE380-0x0000000184DAE3E0
		private void UpdateScrollbarVisibility() {} // 0x0000000184DAE3E0-0x0000000184DAE530
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) {} // 0x00000001840DF210-0x00000001840DF2A0
		private void UpdateScrollbarLayout() {} // 0x0000000184F9DB30-0x0000000184F9DC10
		protected virtual void UpdateScrollEnableNode() {} // 0x00000001840E1560-0x00000001840E1D90
		protected void UpdateBounds() {} // 0x00000001840E1150-0x00000001840E1290
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) {} // 0x00000001840E1350-0x00000001840E1560
		private Bounds GetBounds() => default; // 0x0000000184291690-0x0000000184291990
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) => default; // 0x0000000184B8E1B0-0x0000000184B8E200
		protected Vector2 CalculateOffset(Vector2 delta) => default; // 0x0000000184B8E200-0x0000000184B8E4A0
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta) => default; // 0x00000001854F9E60-0x00000001854F9ED0
		protected void SetDirty() {} // 0x000000018C08882C-0x000000018C0888CC
		protected void SetDirtyCaching() {} // 0x000000018646DBCC-0x000000018646DBD4
	}

	public class Selectable : UIBehaviour, IMoveHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 54891
	{
		// Fields
		protected static Selectable[] s_Selectables; // 0x00
		protected static int s_SelectableCount; // 0x08
		private bool m_EnableCalled; // 0x18
		private Navigation m_Navigation; // 0x20
		private Transition m_Transition; // 0x48
		private ColorBlock m_Colors; // 0x4C
		private SpriteState m_SpriteState; // 0xA8
		private AnimationTriggers m_AnimationTriggers; // 0xC8
		private bool m_Interactable; // 0xD0
		private Graphic m_TargetGraphic; // 0xD8
		protected bool m_NotifyHover; // 0xE0
		protected GameObject m_HoverEnableNode; // 0xE8
		protected string m_HoverAudioKey; // 0xF0
		protected bool _enableUnityNavi; // 0xF8
		private bool m_GroupsAllowInteraction; // 0xF9
		protected int m_CurrentIndex; // 0xFC
		private bool _isPointerInside_k__BackingField; // 0x100
		private bool _isPointerDown_k__BackingField; // 0x101
		private bool _hasSelection_k__BackingField; // 0x102
		private readonly List<CanvasGroup> m_CanvasGroupCache; // 0x108
		public static UnityEvent<Selectable, bool> onAnyHoverChange; // 0x10
		private readonly UnityEvent<bool> _onHoverChange_k__BackingField; // 0x110
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
		private Selectable m_ExplicitSelectOnLeft; // 0x138
		private Selectable m_ExplicitSelectOnRight; // 0x140
		private Selectable m_ExplicitSelectOnUp; // 0x148
		private Selectable m_ExplicitSelectOnDown; // 0x150
		private bool _isNaviTarget_k__BackingField; // 0x158
		public Action<bool, bool, bool> onIsNaviTargetChanged; // 0x160
		private bool _isNavigationSilent_k__BackingField; // 0x168
		public SelectableNaviGroup naviGroup; // 0x170
		private bool m_naviInited; // 0x178
	
		// Properties
		public static Selectable[] allSelectablesArray { get => default; } // 0x000000018C08AC20-0x000000018C08ACA4 
		public static int allSelectableCount { get => default; } // 0x000000018C08ABD0-0x000000018C08AC20 
		public static List<Selectable> allSelectables { get => default; } // 0x000000018C08ACA4-0x000000018C08AD34 
		public string hoverAudioKey { get => default; } // 0x0000000185FB87A0-0x0000000185FB87B0 
		public Navigation navigation { get => default; set {} } // 0x0000000185FB9A00-0x0000000185FB9A20 0x000000018422C680-0x000000018422C700
		public Transition transition { get => default; set {} } // 0x0000000185FB0570-0x0000000185FB0580 0x000000018C08AF38-0x000000018C08AF90
		public ColorBlock colors { get => default; set {} } // 0x0000000185FEAA90-0x0000000185FEAAD0 0x000000018C08ADD0-0x000000018C08AE6C
		public SpriteState spriteState { get => default; set {} } // 0x0000000185FEAAD0-0x0000000185FEAAF0 0x000000018C08AE6C-0x000000018C08AEDC
		public AnimationTriggers animationTriggers { get => default; set {} } // 0x0000000185FB0300-0x0000000185FB0310 0x000000018C08AD74-0x000000018C08ADD0
		public Graphic targetGraphic { get => default; set {} } // 0x0000000185FB02F0-0x0000000185FB0300 0x000000018C08AEDC-0x000000018C08AF38
		public bool interactable { get => default; set {} } // 0x0000000185FBA3C0-0x0000000185FBA3D0 0x000000018420FD20-0x000000018420FD90
		private bool isPointerInside { get; set; } // 0x0000000181ABEDC0-0x0000000181ABEDD0 0x0000000185FEAB00-0x0000000185FEAB10
		private bool isPointerDown { get; set; } // 0x0000000185FD63E0-0x0000000185FD63F0 0x0000000185FEAAF0-0x0000000185FEAB00
		private bool hasSelection { get; set; } // 0x0000000185FB67D0-0x0000000185FB67E0 0x0000000185FB6800-0x0000000185FB6810
		public Image image { get => default; set {} } // 0x000000018C08AD34-0x000000018C08AD74 0x00000001873368EC-0x0000000187336900
		public Animator animator { get => default; } // 0x0000000183FB4490-0x0000000183FB44D0 
		protected SelectionState currentSelectionState { get => default; } // 0x0000000183FB3400-0x0000000183FB3450 
		public UnityEvent<bool> onHoverChange { get; } // 0x0000000185FB8600-0x0000000185FB8610 
		public bool isNaviTarget { get; protected set; } // 0x0000000185FBC3E0-0x0000000185FBC3F0 0x0000000185FBC3F0-0x0000000185FBC400
		public bool isNavigationSilent { get; protected set; } // 0x0000000185FBD080-0x0000000185FBD090 0x0000000185FBD0D0-0x0000000185FBD0E0
	
		// Nested types
		public enum Transition // TypeDefIndex: 54889
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 3
		}
	
		protected enum SelectionState // TypeDefIndex: 54890
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Selected = 3,
			Disabled = 4
		}
	
		// Constructors
		protected Selectable() {} // 0x0000000184817680-0x0000000184817910
		static Selectable() {} // 0x0000000185EC2CC0-0x0000000185EC2DB0
	
		// Methods
		public static int AllSelectablesNoAlloc(Selectable[] selectables) => default; // 0x000000018C089A0C-0x000000018C089AB4
		protected override void Awake() {} // 0x000000018422C540-0x000000018422C680
		protected void OnCanvasGroupChanged() {} // 0x0000000183FD13A0-0x0000000183FD1710
		public virtual bool IsInteractable() => default; // 0x0000000183FB3450-0x0000000183FB3470
		protected override void OnDidApplyAnimationProperties() {} // 0x000000018C08A618-0x000000018C08A620
		protected override void OnEnable() {} // 0x0000000183FB2460-0x0000000183FB27F0
		protected override void OnTransformParentChanged() {} // 0x0000000185BC5950-0x0000000185BC5960
		private void OnSetProperty() {} // 0x00000001857D7680-0x00000001857D76B0
		protected override void OnDisable() {} // 0x0000000183FB3470-0x0000000183FB3650
		private void OnApplicationFocus(bool hasFocus) {} // 0x0000000183FB4510-0x0000000183FB4540
		protected virtual void InstantClearState() {} // 0x0000000183FB3990-0x0000000183FB3A20
		protected virtual void DoStateTransition(SelectionState state, bool instant) {} // 0x0000000183FB3710-0x0000000183FB3990
		public Selectable FindSelectable(Vector3 dir) => default; // 0x000000018C089E04-0x000000018C08A2C4
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) => default; // 0x000000018C08A364-0x000000018C08A538
		private void Navigate(AxisEventData eventData, Selectable sel) {} // 0x000000018C08A588-0x000000018C08A618
		public virtual Selectable FindSelectableOnLeft() => default; // 0x000000018C089BF4-0x000000018C089CA4
		public virtual Selectable FindSelectableOnRight() => default; // 0x000000018C089CA4-0x000000018C089D54
		public virtual Selectable FindSelectableOnUp() => default; // 0x000000018C089D54-0x000000018C089E04
		public virtual Selectable FindSelectableOnDown() => default; // 0x000000018C089B44-0x000000018C089BF4
		public virtual void OnMove(AxisEventData eventData) {} // 0x000000018C08A620-0x000000018C08A690
		private void StartColorTween(UnityEngine.Color targetColor, bool instant) {} // 0x0000000183FB3A70-0x0000000183FB3D20
		private void DoSpriteSwap(Sprite newSprite) {} // 0x000000018C089AB4-0x000000018C089B44
		private void TriggerAnimation(string triggername) {} // 0x0000000183FB4290-0x0000000183FB4490
		protected bool IsHighlighted() => default; // 0x000000018C08A538-0x000000018C08A588
		protected bool IsPressed() => default; // 0x0000000183FB4540-0x0000000183FB4580
		private void EvaluateAndTransitionToSelectionState() {} // 0x0000000183FB4950-0x0000000183FB49D0
		public virtual void OnPointerDown(PointerEventData eventData) {} // 0x0000000184FC15C0-0x0000000184FC15F0
		public virtual void OnPointerUp(PointerEventData eventData) {} // 0x0000000184FC15F0-0x0000000184FC1620
		public virtual void OnPointerEnter(PointerEventData eventData) {} // 0x000000018467D180-0x000000018467D280
		public virtual void OnPointerExit(PointerEventData eventData) {} // 0x000000018467D280-0x000000018467D2B0
		public virtual void OnSelect(BaseEventData eventData) {} // 0x0000000185F38900-0x0000000185F38910
		public virtual void OnDeselect(BaseEventData eventData) {} // 0x0000000185F10A40-0x0000000185F10A50
		public virtual void Select() {} // 0x000000018C08A6FC-0x000000018C08A7C8
		protected virtual void _RefreshHoverEnableNode(bool active) {} // 0x0000000184330830-0x0000000184330960
		public virtual void OnInteractableChanged() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void _NotifyIsHover(bool isHover) {} // 0x000000018422DBD0-0x000000018422DCB0
		protected override void OnDestroy() {} // 0x00000001849D5900-0x00000001849D5940
		public virtual bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId) {
			clickHintTextId = default;
			longPressHintTextId = default;
			return default;
		} // 0x000000018C08A33C-0x000000018C08A364
		public void SetAsNaviTarget(bool isTarget, bool silentMode, bool isGroupChanged) {} // 0x000000018C08A7C8-0x000000018C08A910
		public virtual void OnNaviTargetEnabledAgain() {} // 0x000000018C08A690-0x000000018C08A6FC
		protected virtual void _OnSetAsNaviTarget(bool isTarget, bool silentMode) {} // 0x0000000185492010-0x0000000185492020
		public void TryFindNaviGroup() {} // 0x000000018422C700-0x000000018422C750
		public SelectableNaviGroup GetLayerGroup() => default; // 0x000000018C08A2C4-0x000000018C08A33C
		public bool TryFindExplicitNaviTarget(NaviDirection dir, out Selectable target) {
			target = default;
			return default;
		} // 0x000000018C08A970-0x000000018C08AAF8
		public bool banExplicitNavi(NaviDirection dir) => default; // 0x000000018C08AAF8-0x000000018C08ABD0
		private void _TryRegisterOnNaviGroup() {} // 0x0000000183FB3650-0x0000000183FB3710
		private void _TryUnRegisterOnNaviGroup() {} // 0x00000001849D5940-0x00000001849D5A60
		public void SetExplicitSelectOnLeft(Selectable selectable) {} // 0x00000001864735CC-0x00000001864735E0
		public void SetExplicitSelectOnRight(Selectable selectable) {} // 0x0000000187A47758-0x0000000187A4776C
		public void SetExplicitSelectOnUp(Selectable selectable) {} // 0x0000000187A47780-0x0000000187A47794
		public void SetExplicitSelectOnDown(Selectable selectable) {} // 0x0000000187A475C8-0x0000000187A475DC
		public void SetExplicitSelect(Selectable left, Selectable right, Selectable up, Selectable down) {} // 0x000000018C08A910-0x000000018C08A970
	}

	public enum NaviDirection // TypeDefIndex: 54892
	{
		None = 0,
		Up = 1,
		Down = 2,
		Left = 3,
		Right = 4
	}

	public enum NaviStrategy // TypeDefIndex: 54893
	{
		Normal = 0,
		Strict = 1,
		NotInternalFirst = 2,
		VerticalOnlyWithInternalWrap = 3,
		HorizontalOnlyWithInternalWrap = 4
	}

	public enum NavigationBindingType // TypeDefIndex: 54894
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

	public abstract class SelectableNaviGroup : MonoBehaviour // TypeDefIndex: 54895
	{
		// Fields
		public bool isIsolate; // 0x18
		public bool isLayer; // 0x19
		public bool removeLayerOnDisable; // 0x1A
		[NonSerialized]
		public bool isDummy; // 0x1B
		public SelectableNaviGroup parentNaviGroup; // 0x20
		public NaviStrategy internalNaviStrategy; // 0x28
		public NavigationBindingType navigationBindingType; // 0x2C
		public bool enablePartner; // 0x30
		public List<SelectableNaviGroup> naviPartnerOnUp; // 0x38
		public List<SelectableNaviGroup> naviPartnerOnDown; // 0x40
		public List<SelectableNaviGroup> naviPartnerOnLeft; // 0x48
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
		public Selectable LayerSelectedTarget { get; } // 0x00000001849D4320-0x00000001849D4340 
		public bool IsTopLayer { get; set; } // 0x0000000185FB9E80-0x0000000185FB9E90 0x000000018C0899F4-0x000000018C089A0C
	
		// Constructors
		protected SelectableNaviGroup() {} // 0x0000000185264030-0x0000000185264330
	
		// Methods
		protected virtual void Reset() {} // 0x000000018C0899EC-0x000000018C0899F4
		protected virtual void OnEnable() {} // 0x000000018422CE20-0x000000018422CE50
		protected virtual void OnDisable() {} // 0x000000018646E3D4-0x000000018646E3E4
		protected virtual void OnDestroy() {} // 0x000000018422A000-0x000000018422A0F0
		protected virtual void _Init() {} // 0x000000018422CFB0-0x000000018422D0A0
		public void TryFindParentNaviGroup() {} // 0x000000018422C280-0x000000018422C370
		public SelectableNaviGroup GetLayerGroup() => default; // 0x000000018422CC20-0x000000018422CCA0
		public void SetLayerSelectedTarget(Selectable value, bool silentMode) {} // 0x000000018422CA70-0x000000018422CAF0
		public void OnRemoveFromLayerStack() {} // 0x000000018422CDA0-0x000000018422CDD0
		protected virtual void _OnIsTopLayerChanged() {} // 0x000000018422D0F0-0x000000018422D150
		protected virtual void _OnSelectableNaviGroupInited() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void _BeforeSelectableNaviGroupDestroy() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void _OnSelectableNaviGroupDisabled() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void _OnSetLayerSelectedTarget(Selectable value) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void _OnRemoveFromLayerStack() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class SetPropertyUtility // TypeDefIndex: 54896
	{
		// Methods
		public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue) => default; // 0x0000000184042D50-0x0000000184042D90
		public static bool SetStruct<T>(ref ref T currentValue, T newValue)
			where T : struct => default;
		public static bool SetClass<T>(ref ref T currentValue, T newValue)
			where T : class => default;
	}

	public class Slider : Selectable, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 54900
	{
		// Fields
		private RectTransform m_FillRect; // 0x180
		private RectTransform m_HandleRect; // 0x188
		private Direction m_Direction; // 0x190
		private float m_MinValue; // 0x194
		private float m_MaxValue; // 0x198
		private bool m_WholeNumbers; // 0x19C
		protected float m_Value; // 0x1A0
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
		public RectTransform fillRect { get => default; set {} } // 0x000000018C08BAC4-0x000000018C08BB2C 0x0000000185FB8360-0x0000000185FB8370
		public RectTransform handleRect { get => default; set {} } // 0x000000018C08BB2C-0x000000018C08BB94 0x0000000185FD6D00-0x0000000185FD6D10
		public Direction direction { get => default; set {} } // 0x000000018C08BA68-0x000000018C08BAC4 0x0000000185FB9AA0-0x0000000185FB9AB0
		public float minValue { get => default; set {} } // 0x0000000185DAF110-0x0000000185DAF190 0x0000000185FB9AB0-0x0000000185FB9AC0
		public float maxValue { get => default; set {} } // 0x0000000185DAF2A0-0x0000000185DAF320 0x0000000185FB9C10-0x0000000185FB9C20
		public bool wholeNumbers { get => default; set {} } // 0x000000018C08BBC4-0x000000018C08BC38 0x0000000184232BE0-0x0000000184232C10
		public virtual float value { get => default; set {} } // 0x000000018646EF94-0x000000018646EFA0 0x000000018C08B800-0x000000018C08B80C
		public float normalizedValue { get => default; set {} } // 0x000000018C08BB94-0x000000018C08BBC4 0x0000000185FB82E0-0x0000000185FB82F0
		public SliderEvent onValueChanged { get => default; set {} } // 0x00000001864734D4-0x00000001864734E8 0x000000018C08BA3C-0x000000018C08BA68
		private float stepSize { get => default; } // 0x0000000184817020-0x00000001848170D0 
		private Axis axis { get => default; } // 0x0000000184232C30-0x0000000184232C50 
		private bool reverseValue { get => default; } // 0x0000000184232840-0x0000000184232B70 
		Transform ICanvasElement.transform { get => default; } // 0x0000000184817280-0x00000001848172C0 
	
		// Nested types
		public enum Direction // TypeDefIndex: 54897
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}
	
		[Serializable]
		public class SliderEvent : UnityEvent<float> // TypeDefIndex: 54898
		{
			// Constructors
			public SliderEvent() {} // 0x0000000185FB8280-0x0000000185FB8290
		}
	
		private enum Axis // TypeDefIndex: 54899
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		// Constructors
		protected Slider() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void SetValueWithoutNotify(float input) {} // 0x0000000184232B70-0x0000000184232BE0
		public virtual void Rebuild(CanvasUpdate executing) {} // 0x0000000185492010-0x0000000185492020
		public virtual void LayoutComplete() {} // 0x0000000185492010-0x0000000185492020
		public virtual void GraphicUpdateComplete() {} // 0x0000000184232150-0x0000000184232210
		protected override void OnEnable() {} // 0x00000001856CD2A0-0x00000001856CD2B0
		protected override void OnDisable() {} // 0x000000018421AC50-0x000000018421AC70
		protected virtual void Update() {} // 0x000000018C08B094-0x000000018C08B2B0
		protected override void OnDidApplyAnimationProperties() {} // 0x0000000184231190-0x0000000184231510
		private void UpdateCachedReferences() {} // 0x000000018C08AF90-0x000000018C08AFC4
		protected virtual float ClampValue(float input) => default; // 0x0000000184233FB0-0x00000001842340B0
		protected virtual void Set(float input, bool sendCallback = true /* Metadata: 0x0207BA60 */) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnValueChanged() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnClickSliderBar() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnClickSliderHandle() {} // 0x0000000184230E90-0x0000000184230EC0
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000184232C10-0x0000000184232C30
		private void UpdateVisuals() {} // 0x000000018C08B80C-0x000000018C08BA3C
		private void UpdateDrag(PointerEventData eventData, Camera cam) {} // 0x0000000183667B80-0x0000000183667B90
		protected virtual float CustomProcessNormalizedValue(float val) => default; // 0x000000018C088EDC-0x000000018C088F30
		private bool MayDrag(PointerEventData eventData) => default; // 0x000000018C08B4E8-0x000000018C08B6C4
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018C08B2B0-0x000000018C08B300
		public virtual void OnDrag(PointerEventData eventData) {} // 0x000000018C08B300-0x000000018C08B4E8
		public override void OnMove(AxisEventData eventData) {} // 0x000000018C08AFF8-0x000000018C08B02C
		public override Selectable FindSelectableOnLeft() => default; // 0x000000018C08B02C-0x000000018C08B060
		public override Selectable FindSelectableOnRight() => default; // 0x000000018C08B060-0x000000018C08B094
		public override Selectable FindSelectableOnUp() => default; // 0x000000018C08AFC4-0x000000018C08AFF8
		public override Selectable FindSelectableOnDown() => default; // 0x000000018C0891C8-0x000000018C0891E4
		public virtual void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x000000018C08B6C4-0x000000018C08B800
		public void SetDirection(Direction direction, bool includeRectLayouts) {} // 0x000000018646DBCC-0x000000018646DBD4
	}

	[Serializable]
	public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 54901
	{
		// Fields
		private Sprite m_HighlightedSprite; // 0x00
		private Sprite m_PressedSprite; // 0x08
		private Sprite m_SelectedSprite; // 0x10
		private Sprite m_DisabledSprite; // 0x18
	
		// Properties
		public Sprite highlightedSprite { get => default; set {} } // 0x00000001834AFB60-0x00000001834AFB70 0x000000018646FE2C-0x000000018646FE34
		public Sprite pressedSprite { get => default; set {} } // 0x000000018357A260-0x000000018357A270 0x00000001877900A4-0x00000001877900B4
		public Sprite selectedSprite { get => default; set {} } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public Sprite disabledSprite { get => default; set {} } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Methods
		public bool Equals(SpriteState other) => default; // 0x000000018C08BC38-0x000000018C08BD04
	}

	public static class StencilMaterial // TypeDefIndex: 54903
	{
		// Fields
		private static List<MatEntry> m_List; // 0x00
		private static bool s_EnableStencilMaterialWarning; // 0x08
	
		// Nested types
		private class MatEntry // TypeDefIndex: 54902
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
			public MatEntry() {} // 0x00000001813AE580-0x00000001813AE590
		}
	
		// Constructors
		static StencilMaterial() {} // 0x0000000185FEAA20-0x0000000185FEAA30
	
		// Methods
		public static Material Add(Material baseMat, int stencilID) => default; // 0x00000001845E5660-0x00000001845E5700
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) => default; // 0x000000018C08BE18-0x000000018C08BEA0
		private static void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context) {} // 0x00000001845E6DE0-0x00000001845E7620
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) => default; // 0x00000001842414D0-0x0000000184241760
		public static void Remove(Material customMat) {} // 0x000000018C08BD04-0x000000018C08BE18
		public static void ClearAll() {} // 0x0000000185F13D30-0x0000000185F13DD0
	}

	public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 54904
	{
		// Fields
		private FontData m_FontData; // 0xE8
		protected string m_Text; // 0xF0
		private TextGenerator m_TextCache; // 0xF8
		private TextGenerator m_TextCacheForLayout; // 0x100
		protected static Material s_DefaultText; // 0x00
		[NonSerialized]
		protected bool m_DisableFontTextureRebuiltCallback; // 0x108
		private readonly UIVertex[] m_TempVerts; // 0x110
	
		// Properties
		public TextGenerator cachedTextGenerator { get => default; } // 0x000000018C08CB2C-0x000000018C08CBE0 
		public TextGenerator cachedTextGeneratorForLayout { get => default; } // 0x000000018C08CAB0-0x000000018C08CB2C 
		public override Texture mainTexture { get => default; } // 0x000000018C08CC80-0x000000018C08CE08 
		public Font font { get => default; set {} } // 0x000000018C08CC20-0x000000018C08CC40 0x000000018C08D304-0x000000018C08D3F8
		public virtual string text { get => default; set {} } // 0x0000000185FB87A0-0x0000000185FB87B0 0x000000018C08D598-0x000000018C08D664
		public bool supportRichText { get => default; set {} } // 0x000000018C08D1BC-0x000000018C08D1DC 0x000000018C08D554-0x000000018C08D598
		public bool resizeTextForBestFit { get => default; set {} } // 0x000000018C08D15C-0x000000018C08D17C 0x000000018C08D488-0x000000018C08D4CC
		public int resizeTextMinSize { get => default; set {} } // 0x000000018C08D19C-0x000000018C08D1BC 0x000000018C08D510-0x000000018C08D554
		public int resizeTextMaxSize { get => default; set {} } // 0x000000018C08D17C-0x000000018C08D19C 0x000000018C08D4CC-0x000000018C08D510
		public TextAnchor alignment { get => default; set {} } // 0x000000018C08CA90-0x000000018C08CAB0 0x000000018C08D238-0x000000018C08D27C
		public bool alignByGeometry { get => default; set {} } // 0x000000018C08CA70-0x000000018C08CA90 0x000000018C08D1FC-0x000000018C08D238
		public int fontSize { get => default; set {} } // 0x000000018C08CBE0-0x000000018C08CC00 0x000000018C08D27C-0x000000018C08D2C0
		public HorizontalWrapMode horizontalOverflow { get => default; set {} } // 0x000000018C08CC40-0x000000018C08CC60 0x000000018C08D3F8-0x000000018C08D43C
		public VerticalWrapMode verticalOverflow { get => default; set {} } // 0x000000018C08D1DC-0x000000018C08D1FC 0x000000018C08D664-0x000000018C08D6A8
		public float lineSpacing { get => default; set {} } // 0x000000018C08CC60-0x000000018C08CC80 0x000000018C08D43C-0x000000018C08D488
		public FontStyle fontStyle { get => default; set {} } // 0x000000018C08CC00-0x000000018C08CC20 0x000000018C08D2C0-0x000000018C08D304
		public float pixelsPerUnit { get => default; } // 0x000000018C08CE08-0x000000018C08CF44 
		public virtual float minWidth { get => default; } // 0x0000000183908D00-0x0000000183908D10 
		public virtual float preferredWidth { get => default; } // 0x000000018C08D06C-0x000000018C08D15C 
		public virtual float flexibleWidth { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual float minHeight { get => default; } // 0x0000000183908D00-0x0000000183908D10 
		public virtual float preferredHeight { get => default; } // 0x000000018C08CF44-0x000000018C08D06C 
		public virtual float flexibleHeight { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public virtual int layoutPriority { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		protected Text() {} // 0x000000018C08C9C4-0x000000018C08CA70
	
		// Methods
		public void FontTextureChanged() {} // 0x000000018C08BF90-0x000000018C08C058
		protected override void OnEnable() {} // 0x000000018C08C33C-0x000000018C08C3A4
		protected override void OnDisable() {} // 0x000000018C08C2F0-0x000000018C08C33C
		protected override void UpdateGeometry() {} // 0x000000018C08C95C-0x000000018C08C9C4
		public void AssignDefaultFont() {} // 0x000000018C08BF38-0x000000018C08BF90
		internal void AssignDefaultFontIfNecessary() {} // 0x000000018C08BEA0-0x000000018C08BF38
		public TextGenerationSettings GetGenerationSettings(Vector2 extents) => default; // 0x000000018C08C058-0x000000018C08C264
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor) => default; // 0x000000018C08C264-0x000000018C08C2F0
		protected override void OnPopulateMesh(VertexHelper toFill) {} // 0x000000018C08C3A4-0x000000018C08C95C
		public virtual void CalculateLayoutInputHorizontal() {} // 0x0000000185492010-0x0000000185492020
		public virtual void CalculateLayoutInputVertical() {} // 0x0000000185492010-0x0000000185492020
	}

	public class Toggle : Selectable, IPointerClickHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 54907
	{
		// Fields
		public ToggleTransition toggleTransition; // 0x180
		public Graphic graphic; // 0x188
		private ToggleGroup m_Group; // 0x190
		public ToggleEvent onValueChanged; // 0x198
		private bool m_IsOn; // 0x1A0
	
		// Properties
		public ToggleGroup group { get => default; set {} } // 0x000000018C08D960-0x000000018C08D988 0x0000000184816F30-0x0000000184816FE0
		public bool isOn { get => default; set {} } // 0x0000000184230D50-0x0000000184230D60 0x0000000186474484-0x0000000186474490
		Transform ICanvasElement.transform { get => default; } // 0x0000000184816FE0-0x0000000184817020 
	
		// Nested types
		public enum ToggleTransition // TypeDefIndex: 54905
		{
			None = 0,
			Fade = 1
		}
	
		[Serializable]
		public class ToggleEvent : UnityEvent<bool> // TypeDefIndex: 54906
		{
			// Constructors
			public ToggleEvent() {} // 0x0000000181B44930-0x0000000181B44940
		}
	
		// Constructors
		protected Toggle() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual void Rebuild(CanvasUpdate executing) {} // 0x0000000185492010-0x0000000185492020
		public virtual void LayoutComplete() {} // 0x0000000185492010-0x0000000185492020
		public virtual void GraphicUpdateComplete() {} // 0x000000018C08D7F0-0x000000018C08D86C
		protected override void OnDestroy() {} // 0x000000018422FE00-0x000000018422FE40
		protected override void OnEnable() {} // 0x000000018422FD70-0x000000018422FDA0
		protected override void OnDisable() {} // 0x000000018C08D86C-0x000000018C08D92C
		protected override void OnDidApplyAnimationProperties() {} // 0x000000018422FFF0-0x0000000184230160
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) {} // 0x0000000185FB9400-0x0000000185FB9410
		public void SetIsOnWithoutNotify(bool value) {} // 0x0000000184230D60-0x0000000184230E90
		private void Set(bool value, bool sendCallback = true /* Metadata: 0x0207BA67 */) {} // 0x000000018422FE40-0x000000018422FF00
		private void PlayEffect(bool instant) {} // 0x000000018646E3F0-0x000000018646E3FC
		protected override void Start() {} // 0x0000000185EF81D0-0x0000000185EF8230
		protected virtual void InternalToggle() {} // 0x000000018C08D92C-0x000000018C08D960
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x000000018B7B5B4C-0x000000018B7B5B5C
		public virtual void OnSubmit(BaseEventData eventData) {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnValueChange() {} // 0x000000018646DBCC-0x000000018646DBD4
	}

	public class ToggleGroup : UIBehaviour // TypeDefIndex: 54909
	{
		// Fields
		private bool m_AllowSwitchOff; // 0x18
		protected List<Toggle> m_Toggles; // 0x20
	
		// Properties
		public bool allowSwitchOff { get => default; set {} } // 0x00000001857DCA40-0x00000001857DCA50 0x0000000185B660C0-0x0000000185B66170
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 54908
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Toggle> __9__13_0; // 0x08
			public static Func<Toggle, bool> __9__14_0; // 0x10
	
			// Constructors
			static __c() {} // 0x00000001813C0430-0x00000001813C0440
			public __c() {} // 0x00000001813C0520-0x00000001813C0530
	
			// Methods
			internal bool _AnyTogglesOn_b__13_0(Toggle x) => default; // 0x000000018582C610-0x000000018582C6A0
			internal bool _ActiveToggles_b__14_0(Toggle x) => default; // 0x00000001857DCA40-0x00000001857DCA50
		}
	
		// Constructors
		protected ToggleGroup() {} // 0x0000000185B65FD0-0x0000000185B660C0
	
		// Methods
		protected override void Start() {} // 0x0000000184230160-0x00000001842301E0
		protected override void OnEnable() {} // 0x000000018422FCB0-0x000000018422FD30
		private void ValidateToggleIsInGroup(Toggle toggle) {} // 0x00000001857DCB50-0x00000001857DCE60
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true /* Metadata: 0x0207BA6A */) {} // 0x00000001857DCFA0-0x00000001857DD120
		public void UnregisterToggle(Toggle toggle) {} // 0x00000001857DCE60-0x00000001857DCFA0
		public void RegisterToggle(Toggle toggle) {} // 0x000000018C08D6A8-0x000000018C08D718
		public void EnsureValidState() {} // 0x000000018C08D718-0x000000018C08D7F0
		public bool AnyTogglesOn() => default; // 0x0000000185F71F50-0x0000000185F71FB0
		public IEnumerable<Toggle> ActiveToggles() => default; // 0x0000000185492010-0x0000000185492020
		public Toggle GetFirstActiveToggle() => default; // 0x0000000184C76230-0x0000000184C76250
		public void SetAllTogglesOff(bool sendCallback = true /* Metadata: 0x0207BA6B */) {} // 0x0000000185F666D0-0x0000000185F666F0
	}

	internal class ReflectionMethodsCache // TypeDefIndex: 54916
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
		public static ReflectionMethodsCache Singleton { get => default; } // 0x0000000186477E54-0x0000000186477F84 
	
		// Nested types
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i); // TypeDefIndex: 54910; 0x000000018C088314-0x000000018C0883A4
	
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i); // TypeDefIndex: 54911; 0x0000000187207114-0x0000000187207140
	
		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i); // TypeDefIndex: 54912; 0x00000001864750A8-0x00000001864751CC
	
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i); // TypeDefIndex: 54913; 0x0000000186477E54-0x0000000186477F84
	
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i); // TypeDefIndex: 54914; 0x00000001890BEC84-0x00000001890BEDD4
	
		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i); // TypeDefIndex: 54915; 0x00000001864750A8-0x00000001864751CC
	
		// Constructors
		public ReflectionMethodsCache() {} // 0x000000018C086DA8-0x000000018C086E78
	}

	public class VertexHelper : IDisposable // TypeDefIndex: 54917
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
		public int currentVertCount { get => default; } // 0x0000000183F93A80-0x0000000183F93AC0 
		public int currentIndexCount { get => default; } // 0x000000018C08E4E8-0x000000018C08E9D4 
	
		// Constructors
		public VertexHelper() {} // 0x0000000185492010-0x0000000185492020
		public VertexHelper(Mesh m) {} // 0x000000018C08E2B0-0x000000018C08E4E8
		static VertexHelper() {} // 0x0000000185B57040-0x0000000185B570B0
	
		// Methods
		private void InitializeListIfRequired() {} // 0x0000000183F96EF0-0x0000000183F970E0
		public void Dispose() {} // 0x00000001857C3150-0x00000001857C3380
		public void Clear() {} // 0x0000000183FA0710-0x0000000183FA0810
		public void PopulateUIVertex(ref UIVertex vertex, int i) {} // 0x000000018C08DDAC-0x000000018C08DF68
		public void SetUIVertex(UIVertex vertex, int i) {} // 0x000000018C08DF68-0x000000018C08E2B0
		public void FillMesh(Mesh mesh) {} // 0x0000000183F986E0-0x0000000183F995F0
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) {} // 0x0000000183F967A0-0x0000000183F96EF0
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) {} // 0x0000000183F96040-0x0000000183F967A0
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0) {} // 0x0000000183F95880-0x0000000183F96040
		public void AddVert(UIVertex v) {} // 0x00000001857861A0-0x0000000185786250
		public void AddTriangle(int idx0, int idx1, int idx2) {} // 0x0000000183F954B0-0x0000000183F95880
		public void AddUIVertexQuad(UIVertex[] verts) {} // 0x0000000184A18830-0x0000000184A189F0
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) {} // 0x000000018C08DBFC-0x000000018C08DCBC
		public void AddUIVertexTriangleStream(List<UIVertex> verts) {} // 0x000000018C08DCBC-0x000000018C08DD34
		public void GetUIVertexStream(List<UIVertex> stream) {} // 0x000000018C08DD34-0x000000018C08DDAC
	}

	public abstract class BaseVertexEffect // TypeDefIndex: 54918
	{
		// Constructors
		protected BaseVertexEffect() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract void ModifyVertices(List<UIVertex> vertices);
	}

	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 54919
	{
		// Fields
		[NonSerialized]
		private Graphic m_Graphic; // 0x18
	
		// Properties
		protected Graphic graphic { get; } // 0x000000018C08F60C-0x000000018C08F690 
	
		// Constructors
		protected BaseMeshEffect() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void OnEnable() {} // 0x000000018C08F58C-0x000000018C08F60C
		protected override void OnDisable() {} // 0x000000018C08F50C-0x000000018C08F58C
		protected override void OnDidApplyAnimationProperties() {} // 0x000000018C08F48C-0x000000018C08F50C
		public virtual void ModifyMesh(Mesh mesh) {} // 0x000000018C08F388-0x000000018C08F48C
		public abstract void ModifyMesh(VertexHelper vh);
	}

	public interface IVertexModifier // TypeDefIndex: 54920
	{
		// Methods
		void ModifyVertices(List<UIVertex> verts);
	}

	public interface IMeshModifier // TypeDefIndex: 54921
	{
		// Methods
		void ModifyMesh(Mesh mesh);
		void ModifyMesh(VertexHelper verts);
	}

	public class Outline : Shadow // TypeDefIndex: 54922
	{
		// Constructors
		protected Outline() {} // 0x000000018C091268-0x000000018C091270
	
		// Methods
		public override void ModifyMesh(VertexHelper vh) {} // 0x000000018C090FD0-0x000000018C091268
	}

	public class PositionAsUV1 : BaseMeshEffect // TypeDefIndex: 54923
	{
		// Constructors
		protected PositionAsUV1() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public override void ModifyMesh(VertexHelper vh) {} // 0x000000018C096094-0x000000018C096190
	}

	public class Shadow : BaseMeshEffect // TypeDefIndex: 54924
	{
		// Fields
		private UnityEngine.Color m_EffectColor; // 0x20
		private Vector2 m_EffectDistance; // 0x30
		private bool m_UseGraphicAlpha; // 0x38
		private const float kMaxEffectDistance = 600f; // Metadata: 0x0207BA6C
	
		// Properties
		public UnityEngine.Color effectColor { get => default; set {} } // 0x0000000185FB6120-0x0000000185FB6130 0x000000018C0973C0-0x000000018C09744C
		public Vector2 effectDistance { get => default; set {} } // 0x0000000185FCA300-0x0000000185FCA320 0x000000018C09744C-0x000000018C097550
		public bool useGraphicAlpha { get => default; set {} } // 0x0000000185FB0700-0x0000000185FB0710 0x000000018C097550-0x000000018C0975D8
	
		// Constructors
		protected Shadow() {} // 0x0000000185FA7930-0x0000000185FA7960
	
		// Methods
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) {} // 0x000000018C09700C-0x000000018C097288
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) {} // 0x000000018C097288-0x000000018C097298
		public override void ModifyMesh(VertexHelper vh) {} // 0x000000018C097298-0x000000018C0973C0
	}
}

namespace UnityEngine.UI.Collections
{
	internal class IndexedSet<T> : IList<T> // TypeDefIndex: 54925
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
	internal interface ITweenValue // TypeDefIndex: 54926
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}

	internal struct ColorTween : ITweenValue // TypeDefIndex: 54929
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private UnityEngine.Color m_StartColor; // 0x08
		private UnityEngine.Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public UnityEngine.Color startColor { get => default; set {} } // 0x0000000185FD13F0-0x0000000185FD1400 0x0000000185FB30D0-0x0000000185FB30E0
		public UnityEngine.Color targetColor { get => default; set {} } // 0x0000000185FB30E0-0x0000000185FB30F0 0x0000000181C9AC80-0x0000000181C9AC90
		public ColorTweenMode tweenMode { get => default; set {} } // 0x0000000181C9A5C0-0x0000000181C9A5D0 0x0000000185FB09A0-0x0000000185FB09B0
		public float duration { get => default; set {} } // 0x0000000185FB09B0-0x0000000185FB09C0 0x00000001814294C0-0x00000001814294D0
		public bool ignoreTimeScale { get => default; set {} } // 0x000000018142A360-0x000000018142A370 0x00000001850F03F0-0x00000001850F0510
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 54927
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<UnityEngine.Color> // TypeDefIndex: 54928
		{
			// Constructors
			public ColorTweenCallback() {} // 0x0000000183577F20-0x0000000183577F30
		}
	
		// Methods
		public void TweenValue(float floatPercentage) {} // 0x000000018442F7D0-0x000000018442F870
		public void AddOnChangedCallback(UnityAction<UnityEngine.Color> callback) {} // 0x00000001814294C0-0x00000001814294D0
		public bool GetIgnoreTimescale() => default; // 0x0000000185FB09A0-0x0000000185FB09B0
		public float GetDuration() => default; // 0x00000001850F0510-0x00000001850F0520
		public bool ValidTarget() => default; // 0x000000018442F870-0x000000018442F8B0
	}

	internal struct FloatTween : ITweenValue // TypeDefIndex: 54931
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get => default; set {} } // 0x0000000185FBA170-0x0000000185FBA180 0x0000000185FBF760-0x0000000185FBF770
		public float targetValue { get => default; set {} } // 0x0000000185FBF770-0x0000000185FBF780 0x0000000181DCCCE0-0x0000000181DCCCF0
		public float duration { get => default; set {} } // 0x0000000181A6E380-0x0000000181A6E390 0x0000000185FBA190-0x0000000185FBA1A0
		public bool ignoreTimeScale { get => default; set {} } // 0x0000000185FBA1B0-0x0000000185FBA1C0 0x000000018C090C2C-0x000000018C090C90
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 54930
		{
			// Constructors
			public FloatTweenCallback() {} // 0x0000000185FBA140-0x0000000185FBA150
		}
	
		// Methods
		public void TweenValue(float floatPercentage) {} // 0x000000018C090B94-0x000000018C090C2C
		public void AddOnChangedCallback(UnityAction<float> callback) {} // 0x0000000185FBA190-0x0000000185FBA1A0
		public bool GetIgnoreTimescale() => default; // 0x0000000181DCCCE0-0x0000000181DCCCF0
		public float GetDuration() => default; // 0x0000000183FB53F0-0x0000000183FB5400
		public bool ValidTarget() => default; // 0x000000018C090B58-0x000000018C090B94
	}

	internal class TweenRunner<T> // TypeDefIndex: 54933
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		private sealed class _Start_d__2 : IEnumerator<object> // TypeDefIndex: 54932
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public T tweenInfo;
			private float _elapsedTime_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _Start_d__2() {} // Dummy constructor
			public _Start_d__2(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public TweenRunner() {}
	
		// Methods
		private static IEnumerator Start(T tweenInfo) => default;
		public void Init(MonoBehaviour coroutineContainer) {}
		public void StartTween(T info) {}
		public void StopTween() {}
	}
}

namespace UnityEngine.UIElements
{
	public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, UnityEngine.EventSystems.IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent // TypeDefIndex: 54936
	{
		// Fields
		private BaseRuntimePanel m_Panel; // 0x18
		private readonly PointerEvent m_PointerEvent; // 0x20
		private bool m_Selecting; // 0x28
		private UnityEngine.Event m_Event; // 0x30
		private static EventModifiers s_Modifiers; // 0x00
	
		// Properties
		public IPanel panel { get => default; set {} } // 0x0000000185FBAA80-0x0000000185FBAAA0 0x0000000185FBCE10-0x0000000185FBCE20
		private GameObject selectableGameObject { get => default; } // 0x0000000185FCA320-0x0000000185FCA340 
		private EventSystem eventSystem { get => default; } // 0x0000000185FC9A60-0x0000000185FC9A70 
	
		// Nested types
		private enum PointerEventType // TypeDefIndex: 54934
		{
			Default = 0,
			Down = 1,
			Up = 2
		}
	
		private class PointerEvent : IPointerEvent // TypeDefIndex: 54935
		{
			// Fields
			private int _pointerId_k__BackingField; // 0x10
			private string _pointerType_k__BackingField; // 0x18
			private bool _isPrimary_k__BackingField; // 0x20
			private int _button_k__BackingField; // 0x24
			private int _pressedButtons_k__BackingField; // 0x28
			private Vector3 _position_k__BackingField; // 0x2C
			private Vector3 _localPosition_k__BackingField; // 0x38
			private Vector3 _deltaPosition_k__BackingField; // 0x44
			private float _deltaTime_k__BackingField; // 0x50
			private int _clickCount_k__BackingField; // 0x54
			private float _pressure_k__BackingField; // 0x58
			private float _tangentialPressure_k__BackingField; // 0x5C
			private float _altitudeAngle_k__BackingField; // 0x60
			private float _azimuthAngle_k__BackingField; // 0x64
			private float _twist_k__BackingField; // 0x68
			private Vector2 _radius_k__BackingField; // 0x6C
			private Vector2 _radiusVariance_k__BackingField; // 0x74
			private EventModifiers _modifiers_k__BackingField; // 0x7C
	
			// Properties
			public int pointerId { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x000000018C092BD4-0x000000018C092C44
			public string pointerType { get; private set; } // 0x000000018C092BC0-0x000000018C092BD4 0x000000018C092B70-0x000000018C092BC0
			public bool isPrimary { get; private set; } // 0x000000018C0913F8-0x000000018C091400 0x000000018C09135C-0x000000018C091364
			public int button { get; private set; } // 0x000000018C0922AC-0x000000018C092454 0x000000018C092870-0x000000018C092A18
			public int pressedButtons { get; private set; } // 0x000000018C0914DC-0x000000018C0914E8 0x000000018C091364-0x000000018C0913F8
			public Vector3 position { get; private set; } // 0x0000000185492010-0x0000000185492020 0x000000018C091CDC-0x000000018C091D74
			public Vector3 localPosition { get; private set; } // 0x000000018C091348-0x000000018C09135C 0x000000018C09195C-0x000000018C091A48
			public Vector3 deltaPosition { get; private set; } // 0x000000018C091A48-0x000000018C091B9C 0x000000018C0914E8-0x000000018C0916AC
			public float deltaTime { get; private set; } // 0x000000018C091720-0x000000018C09195C 0x000000018C0916AC-0x000000018C091720
			public int clickCount { get; private set; } // 0x000000018C091D74-0x000000018C091E40 0x000000018C09127C-0x000000018C091348
			public float pressure { get; private set; } // 0x000000018C091400-0x000000018C0914DC 0x000000018C091B9C-0x000000018C091CDC
			public float tangentialPressure { get; private set; } // 0x000000018C092454-0x000000018C0924A0 0x000000018C0924A0-0x000000018C0924F0
			public float altitudeAngle { get; private set; } // 0x000000018C092A18-0x000000018C092AD8 0x000000018C091270-0x000000018C09127C
			public float azimuthAngle { get; private set; } // 0x000000018C091E40-0x000000018C091F8C 0x000000018C091F8C-0x000000018C092088
			public float twist { get; private set; } // 0x000000018C092088-0x000000018C0920FC 0x000000018C0926C0-0x000000018C092784
			public Vector2 radius { get; private set; } // 0x000000018C0925D8-0x000000018C0926C0 0x000000018C0924F0-0x000000018C0925D8
			public Vector2 radiusVariance { get; private set; } // 0x000000018C092784-0x000000018C092870 0x000000018C0920FC-0x000000018C0922AC
			public EventModifiers modifiers { get; private set; } // 0x000000018C092AD8-0x000000018C092B70 0x0000000181C0BBD0-0x0000000181C0BBE0
			public bool shiftKey { get => default; } // 0x0000000181378230-0x0000000181378240 
			public bool ctrlKey { get => default; } // 0x0000000181377E40-0x0000000181377E50 
			public bool commandKey { get => default; } // 0x0000000184088E70-0x0000000184088E80 
			public bool altKey { get => default; } // 0x00000001813ECBF0-0x00000001813ECC00 
			public bool actionKey { get => default; } // 0x00000001813EE9B0-0x00000001813EE9C0 
	
			// Constructors
			public PointerEvent() {} // 0x0000000181C9AC80-0x0000000181C9AC90
	
			// Methods
			public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType) {} // 0x0000000181424480-0x0000000181424490
			public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride) {} // 0x0000000181424940-0x0000000181424950
			internal static bool _Read_g__InRange_82_0(int i, int start, int count) => default; // 0x0000000181C9A5C0-0x0000000181C9A5D0
		}
	
		// Constructors
		public PanelEventHandler() {} // 0x000000018C094CD8-0x000000018C094CEC
	
		// Methods
		protected override void OnEnable() {} // 0x0000000183165040-0x0000000183165060
		protected override void OnDisable() {} // 0x0000000185FBCDC0-0x0000000185FBCDD0
		private void RegisterCallbacks() {} // 0x0000000185FB3000-0x0000000185FB3010
		private void UnregisterCallbacks() {} // 0x0000000185FB3010-0x0000000185FB3020
		private void OnPanelDestroyed() {} // 0x0000000185FB0670-0x0000000185FB0680
		private void OnElementFocus(FocusEvent e) {} // 0x0000000185FB06A0-0x0000000185FB06B0
		private void OnElementBlur(BlurEvent e) {} // 0x0000000181DE2580-0x0000000181DE2590
		public void OnSelect(BaseEventData eventData) {} // 0x0000000181DE28C0-0x0000000181DE28D0
		public void OnDeselect(BaseEventData eventData) {} // 0x0000000185FB89D0-0x0000000185FB89E0
		public void OnPointerMove(PointerEventData eventData) {} // 0x0000000185FBD3C0-0x0000000185FBD3D0
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000185FB2200-0x0000000185FB2210
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000185FB2230-0x0000000185FB2240
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000185FB2210-0x0000000185FB2220
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000185FB2220-0x0000000185FB2230
		public void OnSubmit(BaseEventData eventData) {} // 0x0000000185FB8230-0x0000000185FB8240
		public void OnCancel(BaseEventData eventData) {} // 0x0000000185FBA690-0x0000000185FBA6A0
		public void OnMove(AxisEventData eventData) {} // 0x0000000185FBD780-0x0000000185FBD7A0
		public void OnScroll(PointerEventData eventData) {} // 0x0000000185FB6DB0-0x0000000185FB6DC0
		private void SendEvent(EventBase e, BaseEventData sourceEventData) {} // 0x0000000185FEACF0-0x0000000185FEAD10
		private void SendEvent(EventBase e, UnityEngine.Event sourceEvent) {} // 0x0000000185FEAD10-0x0000000185FEAD20
		private void Update() {} // 0x0000000185FB05B0-0x0000000185FB05C0
		private void LateUpdate() {} // 0x0000000185FB0610-0x0000000185FB0620
		private void ProcessImguiEvents(bool isSelected) {} // 0x000000018C094D38-0x000000018C094D40
		private void ProcessKeyboardEvent(UnityEngine.Event e) {} // 0x000000018C094D30-0x000000018C094D38
		private void ProcessTabEvent(UnityEngine.Event e) {} // 0x000000018C094D28-0x000000018C094D30
		private void SendTabEvent(UnityEngine.Event e, int direction) {} // 0x000000018C094D20-0x000000018C094D28
		private void SendKeyUpEvent(UnityEngine.Event e, KeyCode keyCode, EventModifiers modifiers) {} // 0x000000018C094CEC-0x000000018C094D20
		private void SendKeyDownEvent(UnityEngine.Event e, KeyCode keyCode, EventModifiers modifiers) {} // 0x000000018C0947C4-0x000000018C094CD8
		private void SendTextEvent(UnityEngine.Event e, char c, EventModifiers modifiers) {} // 0x0000000185FEACC0-0x0000000185FEACF0
		private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = PointerEventType.Default /* Metadata: 0x0207BA73 */) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent // TypeDefIndex: 54938
	{
		// Fields
		private BaseRuntimePanel m_Panel; // 0x20
	
		// Properties
		public IPanel panel { get => default; set {} } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018C093298-0x000000018C093308
		private GameObject selectableGameObject { get => default; } // 0x000000018C093268-0x000000018C09327C 
		public override int sortOrderPriority { get => default; } // 0x000000018C09327C-0x000000018C093298 
		public override int renderOrderPriority { get => default; } // 0x000000018C093250-0x000000018C093268 
		public override Camera eventCamera { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Nested types
		private struct FloatIntBits // TypeDefIndex: 54937
		{
			// Fields
			public float f; // 0x00
			public int i; // 0x00
		}
	
		// Constructors
		public PanelRaycaster() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void RegisterCallbacks() {} // 0x000000018C093128-0x000000018C0931BC
		private void UnregisterCallbacks() {} // 0x000000018C0931BC-0x000000018C093250
		private void OnPanelDestroyed() {} // 0x000000018C092C44-0x000000018C092C50
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) {} // 0x000000018C092C50-0x000000018C093128
		private static int ConvertFloatBitsToInt(float f) => default; // 0x0000000185FD0EE0-0x0000000185FD0EF0
	}
}
