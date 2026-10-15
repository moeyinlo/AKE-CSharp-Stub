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
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Pool;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.U2D;
using UnityEngine.UI.Collections;
using UnityEngine.UI.CoroutineTween;
using UnityEngine.UIElements;

// Image 31: UnityEngine.UI.dll - Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 83619-83852

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 83852
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB; // 0x00 // Static value (base64): IAAuACwACQANAAoA - Metadata: 0x02643C68

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 83851
	{
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 83620
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 83621
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Unity.Profiling
{
	[IsReadOnly]
	public struct ProfilerCounter<T> // TypeDefIndex: 83835
		where T : struct
	{
		// Constructors
		public ProfilerCounter(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit);
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Sample(T value);
	}

	[IsReadOnly]
	public struct ProfilerCounterValue<T> // TypeDefIndex: 83836
		where T : struct
	{
		// Properties
		public T Value { get; set; }
	
		// Constructors
		public ProfilerCounterValue(string name);
		public ProfilerCounterValue(string name, ProfilerMarkerDataUnit dataUnit);
		public ProfilerCounterValue(string name, ProfilerMarkerDataUnit dataUnit, ProfilerCounterOptions counterOptions);
		public ProfilerCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit);
		public ProfilerCounterValue(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit, ProfilerCounterOptions counterOptions);
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Sample();
	}

	[IsReadOnly]
	public struct ProfilerMarker<TP1> // TypeDefIndex: 83838
		where TP1 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 83837
		{
			// Constructors
			internal AutoScope(ProfilerMarker<TP1> marker, TP1 p1);
	
			// Methods
			public void Dispose();
		}
	
		// Constructors
		public ProfilerMarker(string name, string param1Name);
		public ProfilerMarker(ProfilerCategory category, string name, string param1Name);
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Begin(TP1 p1);
		[Conditional("ENABLE_PROFILER")]
		public void End();
		public AutoScope Auto(TP1 p1);
	}

	[IsReadOnly]
	public struct ProfilerMarker<TP1, TP2> // TypeDefIndex: 83840
		where TP1 : struct
		where TP2 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 83839
		{
			// Constructors
			internal AutoScope(ProfilerMarker<TP1, TP2> marker, TP1 p1, TP2 p2);
	
			// Methods
			public void Dispose();
		}
	
		// Constructors
		public ProfilerMarker(string name, string param1Name, string param2Name);
		public ProfilerMarker(ProfilerCategory category, string name, string param1Name, string param2Name);
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Begin(TP1 p1, TP2 p2);
		[Conditional("ENABLE_PROFILER")]
		public void End();
		public AutoScope Auto(TP1 p1, TP2 p2);
	}

	[IsReadOnly]
	public struct ProfilerMarker<TP1, TP2, TP3> // TypeDefIndex: 83842
		where TP1 : struct
		where TP2 : struct
		where TP3 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 83841
		{
			// Constructors
			internal AutoScope(ProfilerMarker<TP1, TP2, TP3> marker, TP1 p1, TP2 p2, TP3 p3);
	
			// Methods
			public void Dispose();
		}
	
		// Constructors
		public ProfilerMarker(string name, string param1Name, string param2Name, string param3Name);
		public ProfilerMarker(ProfilerCategory category, string name, string param1Name, string param2Name, string param3Name);
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Begin(TP1 p1, TP2 p2, TP3 p3);
		[Conditional("ENABLE_PROFILER")]
		public void End();
		public AutoScope Auto(TP1 p1, TP2 p2, TP3 p3);
	}

	public static class ProfilerMarkerExtension // TypeDefIndex: 83844
	{
		// Nested types
		[IsReadOnly]
		public struct ProfilerMarkerScope : IDisposable // TypeDefIndex: 83843
		{
			// Constructors
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, int context); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, float context); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, string context); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, string context, string context2); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context, string context2); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context, long context2); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, UnityEngine.Object obj); // 0x0000000186805BA0-0x0000000186805BB0
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, Transform transform, bool path); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Extension methods
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, int metadata); // 0x000000018D6AC74C-0x000000018D6AC7C8
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, uint metadata); // 0x000000018D6ACC40-0x000000018D6ACCBC
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata); // 0x000000018D6ACB40-0x000000018D6ACBC0
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, ulong metadata); // 0x000000018D6ACBC0-0x000000018D6ACC40
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, float metadata); // 0x000000018D6AC910-0x000000018D6AC990
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, double metadata); // 0x000000018D6AC7C8-0x000000018D6AC848
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, string metadata); // 0x000000018D6AC6F8-0x000000018D6AC74C
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, string metadata, string metadata2); // 0x000000018D6AC990-0x000000018D6ACA68
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata, string metadata2); // 0x000000018D6ACA68-0x000000018D6ACB40
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata, long metadata2); // 0x000000018D6AC848-0x000000018D6AC910
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker); // 0x00000001843FFFF0-0x0000000184400000
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, int context); // 0x0000000187264220-0x0000000187264230
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context); // 0x0000000187264220-0x0000000187264230
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, float context); // 0x0000000187264220-0x0000000187264230
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, string context); // 0x0000000187264220-0x0000000187264230
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, string context, string context2); // 0x0000000187264210-0x0000000187264220
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context, string context2); // 0x0000000187264210-0x0000000187264220
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context, long context2); // 0x0000000187264210-0x0000000187264220
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, Transform transform, bool path = false /* Metadata: 0x02643C5D */); // 0x0000000187264210-0x0000000187264220
	}

	public struct MonoObject_64 // TypeDefIndex: 83845
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x08
	}

	public struct MonoObject_32 // TypeDefIndex: 83846
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x04
	}

	public struct MonoString_64 // TypeDefIndex: 83847
	{
		// Fields
		public MonoObject_64 obj; // 0x00
		public int length; // 0x10
		public char firstChar; // 0x14
	}

	public struct MonoString_32 // TypeDefIndex: 83848
	{
		// Fields
		public MonoObject_32 obj; // 0x00
		public int length; // 0x08
		public char firstChar; // 0x0C
	}

	public class ProfilerString : IDisposable // TypeDefIndex: 83849
	{
		// Fields
		private const int MAX = 256; // Metadata: 0x02643C60
		private string m_buffer; // 0x10
		private int m_length; // 0x18
		private unsafe int* m_strCount; // 0x20
		private ulong m_handler; // 0x28
	
		// Constructors
		public ProfilerString(int count = 256 /* Metadata: 0x02643C5E */); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		public override string ToString(); // 0x00000001829260F0-0x0000000182926100
		public static implicit operator string(ProfilerString handle); // 0x000000018D6ACFD0-0x000000018D6ACFF0
		public void Append(string value); // 0x000000018D6ACEE4-0x000000018D6ACFD0
	}

	internal struct ProfilerUtility // TypeDefIndex: 83850
	{
		// Methods
		public static byte GetProfilerMarkerDataType<T>();
	}
}

namespace UnityEngine.EventSystems
{
	public class AxisEventData : BaseEventData // TypeDefIndex: 83780
	{
		// Fields
		[CompilerGenerated]
		private Vector2 _moveVector_k__BackingField; // 0x20
		[CompilerGenerated]
		private MoveDirection _moveDir_k__BackingField; // 0x28
	
		// Properties
		public Vector2 moveVector { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187253AE0-0x0000000187253B00 0x000000018561BB30-0x000000018561BB40
		public MoveDirection moveDir { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
	
		// Constructors
		public AxisEventData(EventSystem eventSystem); // 0x000000018D6A4F14-0x000000018D6A4F3C
	}

	public abstract class AbstractEventData // TypeDefIndex: 83781
	{
		// Fields
		protected bool m_Used; // 0x10
	
		// Properties
		public virtual bool used { get; } // 0x00000001829D0800-0x00000001829D0810 
	
		// Constructors
		protected AbstractEventData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual void Reset(); // 0x000000018275FD80-0x000000018275FD90
		public virtual void Use(); // 0x00000001829D07F0-0x00000001829D0800
	}

	public class BaseEventData : AbstractEventData // TypeDefIndex: 83782
	{
		// Fields
		private readonly EventSystem m_EventSystem; // 0x18
	
		// Properties
		public BaseInputModule currentInputModule { get; } // 0x000000018CA8CBEC-0x000000018CA8CC08 
		public GameObject selectedObject { get; set; } // 0x000000018CA8CCCC-0x000000018CA8CCE8 0x000000018D6A4F3C-0x000000018D6A4F64
	
		// Constructors
		public BaseEventData(EventSystem eventSystem); // 0x0000000187835500-0x0000000187835510
	}

	public class PointerEventData : BaseEventData // TypeDefIndex: 83785
	{
		// Fields
		[CompilerGenerated]
		private GameObject _pointerEnter_k__BackingField; // 0x20
		private GameObject m_PointerPress; // 0x28
		[CompilerGenerated]
		private GameObject _lastPress_k__BackingField; // 0x30
		[CompilerGenerated]
		private GameObject _rawPointerPress_k__BackingField; // 0x38
		[CompilerGenerated]
		private GameObject _pointerDrag_k__BackingField; // 0x40
		[CompilerGenerated]
		private GameObject _pointerClick_k__BackingField; // 0x48
		[CompilerGenerated]
		private RaycastResult _pointerCurrentRaycast_k__BackingField; // 0x50
		[CompilerGenerated]
		private RaycastResult _pointerPressRaycast_k__BackingField; // 0x98
		public List<GameObject> hovered; // 0xE0
		[CompilerGenerated]
		private bool _eligibleForClick_k__BackingField; // 0xE8
		[CompilerGenerated]
		private int _pointerId_k__BackingField; // 0xEC
		[CompilerGenerated]
		private Vector2 _position_k__BackingField; // 0xF0
		[CompilerGenerated]
		private Vector2 _delta_k__BackingField; // 0xF8
		[CompilerGenerated]
		private Vector2 _pressPosition_k__BackingField; // 0x100
		[CompilerGenerated]
		private Vector3 _worldPosition_k__BackingField; // 0x108
		[CompilerGenerated]
		private Vector3 _worldNormal_k__BackingField; // 0x114
		[CompilerGenerated]
		private float _clickTime_k__BackingField; // 0x120
		[CompilerGenerated]
		private int _clickCount_k__BackingField; // 0x124
		[CompilerGenerated]
		private Vector2 _scrollDelta_k__BackingField; // 0x128
		[CompilerGenerated]
		private bool _useDragThreshold_k__BackingField; // 0x130
		[CompilerGenerated]
		private bool _dragging_k__BackingField; // 0x131
		[CompilerGenerated]
		private InputButton _button_k__BackingField; // 0x134
		[CompilerGenerated]
		private float _pressure_k__BackingField; // 0x138
		[CompilerGenerated]
		private float _tangentialPressure_k__BackingField; // 0x13C
		[CompilerGenerated]
		private float _altitudeAngle_k__BackingField; // 0x140
		[CompilerGenerated]
		private float _azimuthAngle_k__BackingField; // 0x144
		[CompilerGenerated]
		private float _twist_k__BackingField; // 0x148
		[CompilerGenerated]
		private Vector2 _radius_k__BackingField; // 0x14C
		[CompilerGenerated]
		private Vector2 _radiusVariance_k__BackingField; // 0x154
		[CompilerGenerated]
		private bool _fullyExited_k__BackingField; // 0x15C
		[CompilerGenerated]
		private bool _reentered_k__BackingField; // 0x15D
	
		// Properties
		public GameObject pointerEnter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public GameObject lastPress { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public GameObject rawPointerPress { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public GameObject pointerDrag { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public GameObject pointerClick { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public RaycastResult pointerCurrentRaycast { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187263FF0-0x0000000187264030 0x000000018D6AAC90-0x000000018D6AACC8
		public RaycastResult pointerPressRaycast { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187264030-0x0000000187264070 0x000000018D6AACC8-0x000000018D6AAD0C
		public bool eligibleForClick { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018299E130-0x000000018299E140 0x000000018299E140-0x000000018299E150
		public int pointerId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018724BFC0-0x000000018724BFD0 0x000000018724C080-0x000000018724C090
		public Vector2 position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B430-0x000000018723B450 0x000000018723B450-0x000000018723B460
		public Vector2 delta { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187263FC0-0x0000000187263FE0 0x0000000187264100-0x0000000187264110
		public Vector2 pressPosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187264070-0x0000000187264090 0x0000000187264130-0x0000000187264140
		[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
		public Vector3 worldPosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723F960-0x000000018723F980 0x000000018723F9A0-0x000000018723F9C0
		[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
		public Vector3 worldNormal { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723EE80-0x000000018723EEA0 0x000000018723EF00-0x000000018723EF20
		public float clickTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187262680-0x0000000187262690 0x00000001872626C0-0x00000001872626D0
		public int clickCount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187240800-0x0000000187240810 0x0000000187240820-0x0000000187240830
		public Vector2 scrollDelta { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872640D0-0x00000001872640F0 0x0000000187264180-0x0000000187264190
		public bool useDragThreshold { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723DC60-0x000000018723DC70 0x000000018723DC90-0x000000018723DCA0
		public bool dragging { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187263FE0-0x0000000187263FF0 0x0000000187264110-0x0000000187264120
		public InputButton button { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187250E60-0x0000000187250E70 0x00000001872628D0-0x00000001872628E0
		public float pressure { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187250E70-0x0000000187250E80 0x0000000187264140-0x0000000187264150
		public float tangentialPressure { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872558F0-0x0000000187255900 0x0000000187261520-0x0000000187261530
		public float altitudeAngle { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723B590-0x000000018723B5A0 0x000000018723B610-0x000000018723B620
		public float azimuthAngle { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187263FB0-0x0000000187263FC0 0x00000001872640F0-0x0000000187264100
		public float twist { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723D6D0-0x000000018723D6E0 0x000000018723D700-0x000000018723D710
		public Vector2 radius { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872640B0-0x00000001872640D0 0x0000000187264160-0x0000000187264170
		public Vector2 radiusVariance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187264090-0x00000001872640B0 0x0000000187264150-0x0000000187264160
		public bool fullyExited { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872558E0-0x00000001872558F0 0x0000000187264120-0x0000000187264130
		public bool reentered { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187255BD0-0x0000000187255BE0 0x0000000187264170-0x0000000187264180
		public Camera enterEventCamera { get; } // 0x000000018D6AAC08-0x000000018D6AAC90 
		public Camera pressEventCamera { get; } // 0x0000000185F2DF60-0x0000000185F2E050 
		public GameObject pointerPress { get; set; } // 0x0000000182262130-0x0000000182262140 0x00000001852712E0-0x0000000185271460
	
		// Nested types
		public enum InputButton // TypeDefIndex: 83783
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		public enum FramePressState // TypeDefIndex: 83784
		{
			Pressed = 0,
			Released = 1,
			PressedAndReleased = 2,
			NotChanged = 3
		}
	
		// Constructors
		public PointerEventData(EventSystem eventSystem); // 0x0000000185FBB9E0-0x0000000185FBBAF0
	
		// Methods
		public bool IsPointerMoving(); // 0x00000001852726C0-0x00000001852726F0
		public bool IsScrolling(); // 0x0000000185C8B1D0-0x0000000185C8B200
		public override string ToString(); // 0x000000018D6AA698-0x000000018D6AAC08
	}

	[Flags]
	public enum EventHandle // TypeDefIndex: 83786
	{
		Unused = 0,
		Used = 1
	}

	public interface IEventSystemHandler // TypeDefIndex: 83787
	{
	}

	public interface IPointerMoveHandler : IEventSystemHandler // TypeDefIndex: 83788
	{
		// Methods
		void OnPointerMove(PointerEventData eventData);
	}

	public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 83789
	{
		// Methods
		void OnPointerEnter(PointerEventData eventData);
	}

	public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 83790
	{
		// Methods
		void OnPointerExit(PointerEventData eventData);
	}

	public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 83791
	{
		// Methods
		void OnPointerDown(PointerEventData eventData);
	}

	public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 83792
	{
		// Methods
		void OnPointerUp(PointerEventData eventData);
	}

	public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 83793
	{
		// Methods
		void OnPointerClick(PointerEventData eventData);
	}

	public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 83794
	{
		// Methods
		void OnBeginDrag(PointerEventData eventData);
	}

	public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 83795
	{
		// Methods
		void OnInitializePotentialDrag(PointerEventData eventData);
	}

	public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 83796
	{
		// Methods
		void OnDrag(PointerEventData eventData);
	}

	public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 83797
	{
		// Methods
		void OnEndDrag(PointerEventData eventData);
	}

	public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 83798
	{
		// Methods
		void OnDrop(PointerEventData eventData);
	}

	public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 83799
	{
		// Methods
		void OnScroll(PointerEventData eventData);
	}

	public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 83800
	{
		// Methods
		void OnUpdateSelected(BaseEventData eventData);
	}

	public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 83801
	{
		// Methods
		void OnSelect(BaseEventData eventData);
	}

	public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 83802
	{
		// Methods
		void OnDeselect(BaseEventData eventData);
	}

	public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 83803
	{
		// Methods
		void OnMove(AxisEventData eventData);
	}

	public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 83804
	{
		// Methods
		void OnSubmit(BaseEventData eventData);
	}

	public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 83805
	{
		// Methods
		void OnCancel(BaseEventData eventData);
	}

	[AddComponentMenu("Event/Event System")]
	[DisallowMultipleComponent]
	public class EventSystem : UIBehaviour // TypeDefIndex: 83809
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
		public static EventSystem current { get; set; } // 0x000000018503CB10-0x000000018503CBB0 0x000000018D6A64A0-0x000000018D6A65FC
		public bool sendNavigationEvents { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
		public int pixelDragThreshold { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		public BaseInputModule currentInputModule { get; } // 0x000000018225E800-0x000000018225E810 
		public GameObject firstSelectedGameObject { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public GameObject currentSelectedGameObject { get; } // 0x0000000182986470-0x0000000182986480 
		[Obsolete("lastSelectedGameObject is no longer supported")]
		public GameObject lastSelectedGameObject { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public bool isFocused { get; } // 0x000000018225DFB0-0x000000018225DFC0 
		public bool alreadySelecting { get; } // 0x000000018226EE60-0x000000018226EE70 
		private BaseEventData baseEventDataCache { get; } // 0x0000000185FBC920-0x0000000185FBC990 
		private bool isUIToolkitActiveEventSystem { get; } // 0x0000000186B32820-0x0000000186B32940 
		private bool sendUIToolkitEvents { get; } // 0x0000000186B31E60-0x0000000186B31ED0 
		private bool createUIToolkitPanelGameObjectsOnStart { get; } // 0x0000000186B326D0-0x0000000186B32740 
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 83806
		{
			// Fields
			public static readonly ProfilerMarker Update; // 0x00
			public static readonly ProfilerMarker TickModules; // 0x08
			public static readonly ProfilerMarker CurrentModuleProcess; // 0x10
			public static readonly ProfilerMarker RaycastAll; // 0x18
			public static readonly ProfilerMarker RaycastAllSort; // 0x20
	
			// Constructors
			static ProfilerMarkers(); // 0x0000000186F8E920-0x0000000186F8EA70
		}
	
		private struct UIToolkitOverrideConfig // TypeDefIndex: 83807
		{
			// Fields
			public EventSystem activeEventSystem; // 0x00
			public bool sendEvents; // 0x08
			public bool createPanelGameObjectsOnStart; // 0x09
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 83808
		{
			// Fields
			public GameObject go; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _CreateUIToolkitPanelGameObject_b__0(); // 0x000000018D6B2424-0x000000018D6B2474
		}
	
		// Constructors
		protected EventSystem(); // 0x000000018716F270-0x000000018716F310
		static EventSystem(); // 0x0000000186F93B90-0x0000000186F93CE0
	
		// Methods
		public void UpdateModules(); // 0x0000000186BD0570-0x0000000186BD0680
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer); // 0x00000001852738D0-0x0000000185273A50
		public void SetSelectedGameObject(GameObject selected); // 0x0000000185FBC8E0-0x0000000185FBC920
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs); // 0x00000001850F8550-0x00000001850F9000
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults); // 0x00000001850F9B70-0x00000001850F9E90
		public bool IsPointerOverGameObject(); // 0x000000018D6A6094-0x000000018D6A60A4
		public bool IsPointerOverGameObject(int pointerId); // 0x000000018D6A6014-0x000000018D6A6094
		public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true /* Metadata: 0x02643C3E */, bool createPanelGameObjectsOnStart = true /* Metadata: 0x02643C3F */); // 0x000000018D6A6220-0x000000018D6A6370
		private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel); // 0x000000018D6A5DD4-0x000000018D6A6014
		protected override void Start(); // 0x0000000186B32090-0x0000000186B32630
		protected override void OnDestroy(); // 0x000000018D6A60A4-0x000000018D6A6134
		protected override void OnEnable(); // 0x0000000186B31DA0-0x0000000186B31E60
		protected override void OnDisable(); // 0x000000018D6A6134-0x000000018D6A6220
		private void TickModules(); // 0x000000018503C8F0-0x000000018503CB10
		protected virtual void OnApplicationFocus(bool hasFocus); // 0x0000000185A842C0-0x0000000185A842D0
		protected virtual void Update(); // 0x000000018503C560-0x000000018503C8F0
		private void ChangeEventModule(BaseInputModule module); // 0x00000001870A1970-0x00000001870A1AB0
		public override string ToString(); // 0x000000018D6A6370-0x000000018D6A64A0
	}

	[AddComponentMenu("Event/Event Trigger")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, UnityEngine.EventSystems.IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 83812
	{
		// Fields
		[FormerlySerializedAs("delegates")]
		[SerializeField]
		private List<Entry> m_Delegates; // 0x18
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", true)]
		public List<Entry> delegates { get; set; } // 0x000000018D6A67F4-0x000000018D6A67FC 0x0000000187835500-0x0000000187835510
		public List<Entry> triggers { get; set; } // 0x000000018D6A67FC-0x000000018D6A6880 0x0000000187835500-0x0000000187835510
	
		// Nested types
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 83810
		{
			// Constructors
			public TriggerEvent(); // 0x000000018D6B23E8-0x000000018D6B2424
		}
	
		[Serializable]
		public class Entry // TypeDefIndex: 83811
		{
			// Fields
			public EventTriggerType eventID; // 0x10
			public TriggerEvent callback; // 0x18
	
			// Constructors
			public Entry(); // 0x000000018D6A5D68-0x000000018D6A5DD4
		}
	
		// Constructors
		protected EventTrigger(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Execute(EventTriggerType id, BaseEventData eventData); // 0x000000018D6A65FC-0x000000018D6A66E4
		public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018D6A6784-0x000000018D6A6794
		public virtual void OnPointerExit(PointerEventData eventData); // 0x000000018D6A6794-0x000000018D6A67A4
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018D6A6714-0x000000018D6A6724
		public virtual void OnDrop(PointerEventData eventData); // 0x000000018D6A6724-0x000000018D6A6734
		public virtual void OnPointerDown(PointerEventData eventData); // 0x000000018D6A6774-0x000000018D6A6784
		public virtual void OnPointerUp(PointerEventData eventData); // 0x000000018D6A67A4-0x000000018D6A67B4
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018D6A6764-0x000000018D6A6774
		public virtual void OnSelect(BaseEventData eventData); // 0x000000018D6A67C4-0x000000018D6A67D4
		public virtual void OnDeselect(BaseEventData eventData); // 0x000000018D6A6704-0x000000018D6A6714
		public virtual void OnScroll(PointerEventData eventData); // 0x000000018D6A67B4-0x000000018D6A67C4
		public virtual void OnMove(AxisEventData eventData); // 0x000000018D6A6754-0x000000018D6A6764
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x000000018D6A67E4-0x000000018D6A67F4
		public virtual void OnInitializePotentialDrag(PointerEventData eventData); // 0x000000018D6A6744-0x000000018D6A6754
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018D6A66E4-0x000000018D6A66F4
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018D6A6734-0x000000018D6A6744
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018D6A67D4-0x000000018D6A67E4
		public virtual void OnCancel(BaseEventData eventData); // 0x000000018D6A66F4-0x000000018D6A6704
	}

	public enum EventTriggerType // TypeDefIndex: 83813
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

	public static class ExecuteEvents // TypeDefIndex: 83815
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
		public static EventFunction<IPointerMoveHandler> pointerMoveHandler { get; } // 0x000000018D6A6EA8-0x000000018D6A6EDC 
		public static EventFunction<IPointerEnterHandler> pointerEnterHandler { get; } // 0x000000018D6A6E40-0x000000018D6A6E74 
		public static EventFunction<IPointerExitHandler> pointerExitHandler { get; } // 0x000000018D6A6E74-0x000000018D6A6EA8 
		public static EventFunction<IPointerDownHandler> pointerDownHandler { get; } // 0x000000018D6A6E0C-0x000000018D6A6E40 
		public static EventFunction<IPointerUpHandler> pointerUpHandler { get; } // 0x000000018D6A6EDC-0x000000018D6A6F10 
		public static EventFunction<IPointerClickHandler> pointerClickHandler { get; } // 0x000000018D6A6DD8-0x000000018D6A6E0C 
		public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; } // 0x000000018D6A6D38-0x000000018D6A6D88 
		public static EventFunction<IBeginDragHandler> beginDragHandler { get; } // 0x000000018D6A6B70-0x000000018D6A6BC0 
		public static EventFunction<IDragHandler> dragHandler { get; } // 0x000000018D6A6C64-0x000000018D6A6C98 
		public static EventFunction<IEndDragHandler> endDragHandler { get; } // 0x000000018D6A6CE8-0x000000018D6A6D38 
		public static EventFunction<IDropHandler> dropHandler { get; } // 0x000000018D6A6C98-0x000000018D6A6CE8 
		public static EventFunction<UnityEngine.EventSystems.IScrollHandler> scrollHandler { get; } // 0x000000018D6A6F10-0x000000018D6A6F60 
		public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; } // 0x000000018D6A7004-0x000000018D6A7038 
		public static EventFunction<ISelectHandler> selectHandler { get; } // 0x000000018D6A6F60-0x000000018D6A6FB0 
		public static EventFunction<IDeselectHandler> deselectHandler { get; } // 0x000000018D6A6C14-0x000000018D6A6C64 
		public static EventFunction<IMoveHandler> moveHandler { get; } // 0x000000018D6A6D88-0x000000018D6A6DD8 
		public static EventFunction<ISubmitHandler> submitHandler { get; } // 0x000000018D6A6FB0-0x000000018D6A7004 
		public static EventFunction<ICancelHandler> cancelHandler { get; } // 0x000000018D6A6BC0-0x000000018D6A6C14 
	
		// Nested types
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData); // TypeDefIndex: 83814; 0x00000000-0x00000000
	
		// Constructors
		static ExecuteEvents(); // 0x0000000186B71DD0-0x0000000186B72620
	
		// Methods
		public static T ValidateEventData<T>(BaseEventData data)
			where T : class;
		private static void Execute(IPointerMoveHandler handler, BaseEventData eventData); // 0x000000018D6A6968-0x000000018D6A6A04
		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData); // 0x0000000185038360-0x000000018503B640
		private static void Execute(IPointerExitHandler handler, BaseEventData eventData); // 0x0000000185038300-0x0000000185038360
		private static void Execute(IPointerDownHandler handler, BaseEventData eventData); // 0x0000000185038190-0x00000001850381F0
		private static void Execute(IPointerUpHandler handler, BaseEventData eventData); // 0x0000000185036A70-0x0000000185038190
		private static void Execute(IPointerClickHandler handler, BaseEventData eventData); // 0x0000000185033170-0x0000000185034D40
		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData); // 0x0000000186888590-0x0000000186888630
		private static void Execute(IBeginDragHandler handler, BaseEventData eventData); // 0x0000000186C1DC20-0x0000000186C1FCD0
		private static void Execute(IDragHandler handler, BaseEventData eventData); // 0x0000000185F2E1F0-0x0000000185F30410
		private static void Execute(IEndDragHandler handler, BaseEventData eventData); // 0x0000000186B29F80-0x0000000186B2BF10
		private static void Execute(IDropHandler handler, BaseEventData eventData); // 0x000000018D6A6A1C-0x000000018D6A6AFC
		private static void Execute(UnityEngine.EventSystems.IScrollHandler handler, BaseEventData eventData); // 0x0000000185C8AF70-0x0000000185C8B040
		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData); // 0x0000000185A07770-0x0000000185A077C0
		private static void Execute(ISelectHandler handler, BaseEventData eventData); // 0x0000000186EB9B50-0x0000000186EBA8F0
		private static void Execute(IDeselectHandler handler, BaseEventData eventData); // 0x0000000186E79FA0-0x0000000186E7AFB0
		private static void Execute(IMoveHandler handler, BaseEventData eventData); // 0x000000018D6A6AFC-0x000000018D6A6B70
		private static void Execute(ISubmitHandler handler, BaseEventData eventData); // 0x000000018D6A6A04-0x000000018D6A6A1C
		private static void Execute(ICancelHandler handler, BaseEventData eventData); // 0x000000018D6A6880-0x000000018D6A6968
		private static void GetEventChain(GameObject root, IList<Transform> eventChain); // 0x0000000185B19870-0x0000000185B199A0
		public static bool Execute<T>(GameObject target, BaseEventData eventData, EventFunction<T> functor)
			where T : IEventSystemHandler;
		public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, EventFunction<T> callbackFunction)
			where T : IEventSystemHandler;
		private static bool ShouldSendToComponent<T>(UnityEngine.Component component)
			where T : IEventSystemHandler;
		private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results)
			where T : IEventSystemHandler;
		public static bool CanHandleEvent<T>(GameObject go)
			where T : IEventSystemHandler;
		public static GameObject GetEventHandler<T>(GameObject root)
			where T : IEventSystemHandler;
	}

	public class BaseInput : UIBehaviour // TypeDefIndex: 83816
	{
		// Properties
		public virtual string compositionString { get; } // 0x00000001867E3870-0x00000001867E3880 
		public virtual IMECompositionMode imeCompositionMode { get; set; } // 0x000000018D6A5870-0x000000018D6A5878 0x000000018783729C-0x00000001878372A8
		public virtual Vector2 compositionCursorPos { get; set; } // 0x000000018D6A5868-0x000000018D6A5870 0x00000001878372C8-0x00000001878372E4
		public virtual bool mousePresent { get; } // 0x000000018D5A4EBC-0x000000018D5A4EC4 
		public virtual Vector2 mousePosition { get; } // 0x000000018D6A5878-0x000000018D6A58A0 
		public virtual Vector2 mouseScrollDelta { get; } // 0x000000018D6A58A0-0x000000018D6A58A8 
		public virtual bool touchSupported { get; } // 0x000000018D6A58A8-0x000000018D6A58B0 
		public virtual int touchCount { get; } // 0x000000018C36BAAC-0x000000018C36BAB4 
	
		// Constructors
		public BaseInput(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public virtual bool GetMouseButtonDown(int button); // 0x000000018D6A5844-0x000000018D6A5850
		public virtual bool GetMouseButtonUp(int button); // 0x000000018D6A5850-0x000000018D6A585C
		public virtual bool GetMouseButton(int button); // 0x000000018D6A585C-0x000000018D6A5868
		public virtual Touch GetTouch(int index); // 0x000000018CC10850-0x000000018CC10898
		public virtual float GetAxisRaw(string axisName); // 0x000000018D6A5838-0x000000018D6A5844
		public virtual bool GetButtonDown(string buttonName); // 0x000000018D5A4EB0-0x000000018D5A4EBC
	}

	[RequireComponent(typeof(EventSystem))]
	public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 83817
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
		public BaseInput input { get; } // 0x000000018503B860-0x000000018503BA30 
		public BaseInput inputOverride { get; set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		protected EventSystem eventSystem { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Constructors
		protected BaseInputModule(); // 0x0000000186881540-0x00000001868815D0
	
		// Methods
		protected override void OnEnable(); // 0x0000000186BD0470-0x0000000186BD04D0
		protected override void OnDisable(); // 0x000000018D6A5818-0x000000018D6A5838
		public abstract void Process();
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates); // 0x0000000185271A20-0x0000000185271BD0
		protected static MoveDirection DetermineMoveDirection(float x, float y); // 0x000000018D6A5050-0x000000018D6A5060
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone); // 0x000000018D6A4FE0-0x000000018D6A5050
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2); // 0x0000000185273580-0x00000001852738D0
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget); // 0x000000018D6A5148-0x000000018D6A5818
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone); // 0x000000018D6A5060-0x000000018D6A5148
		protected virtual BaseEventData GetBaseEventData(); // 0x0000000185FBCA80-0x0000000185FBCAF0
		public virtual bool IsPointerOverGameObject(int pointerId); // 0x00000001843FFFF0-0x0000000184400000
		public virtual bool ShouldActivateModule(); // 0x000000018611B4B0-0x000000018611B520
		public virtual void DeactivateModule(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void ActivateModule(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void UpdateModule(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool IsModuleSupported(); // 0x00000001851A4410-0x00000001851A4420
		public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData); // 0x000000018D6A4F64-0x000000018D6A4FE0
	}

	public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 83821
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x02643C51
		public const int kMouseRightId = -2; // Metadata: 0x02643C52
		public const int kMouseMiddleId = -3; // Metadata: 0x02643C53
		public const int kFakeTouchesId = -4; // Metadata: 0x02643C54
		protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
		private readonly MouseState m_MouseState; // 0x50
	
		// Nested types
		protected class ButtonState // TypeDefIndex: 83818
		{
			// Fields
			private PointerEventData.InputButton m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public PointerEventData.InputButton button { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
	
			// Constructors
			public ButtonState(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		protected class MouseState // TypeDefIndex: 83819
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState(); // 0x000000018D6A7438-0x000000018D6A74B0
	
			// Methods
			public bool AnyPressesThisFrame(); // 0x000000018D6A7170-0x000000018D6A7210
			public bool AnyReleasesThisFrame(); // 0x000000018D6A7210-0x000000018D6A72B0
			public ButtonState GetButtonState(PointerEventData.InputButton button); // 0x000000018D6A72B0-0x000000018D6A73E8
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data); // 0x000000018D6A73E8-0x000000018D6A7438
		}
	
		public class MouseButtonEventData // TypeDefIndex: 83820
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool PressedThisFrame(); // 0x000000018CBBB5B4-0x000000018CBBB5C8
			public bool ReleasedThisFrame(); // 0x000000018AB0B2F0-0x000000018AB0B304
		}
	
		// Constructors
		protected PointerInputModule(); // 0x000000018D6AC544-0x000000018D6AC5FC
	
		// Methods
		protected bool GetPointerData(int id, out PointerEventData data, bool create); // 0x000000018D6ABA94-0x000000018D6ABB88
		protected void RemovePointerData(PointerEventData data); // 0x000000018D6AC1C4-0x000000018D6AC220
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released); // 0x000000018D6ABB88-0x000000018D6ABEE8
		protected void CopyFromTo(PointerEventData from, PointerEventData to); // 0x000000018D6AB44C-0x000000018D6AB5AC
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId); // 0x000000018D6AC220-0x000000018D6AC298
		protected virtual MouseState GetMousePointerEventData(); // 0x000000018D6AB6A0-0x000000018D6AB6AC
		protected virtual MouseState GetMousePointerEventData(int id); // 0x000000018D6AB6AC-0x000000018D6ABA94
		protected PointerEventData GetLastPointerEventData(int id); // 0x000000018D6AB678-0x000000018D6AB6A0
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold); // 0x000000018CBBEAB8-0x000000018CBBEAF8
		protected virtual void ProcessMove(PointerEventData pointerEvent); // 0x000000018D6AC178-0x000000018D6AC1C4
		protected virtual void ProcessDrag(PointerEventData pointerEvent); // 0x000000018D6ABF50-0x000000018D6AC178
		public override bool IsPointerOverGameObject(int pointerId); // 0x000000018D6ABEE8-0x000000018D6ABF50
		protected void ClearSelection(); // 0x000000018D6AB288-0x000000018D6AB44C
		public override string ToString(); // 0x000000018D6AC298-0x000000018D6AC544
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent); // 0x000000018D6AB5AC-0x000000018D6AB678
	}

	[AddComponentMenu("Event/Standalone Input Module")]
	public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 83824
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
		public InputMode inputMode { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnMobileDevice { get; set; } // 0x000000018225E0F0-0x000000018225E100 0x000000018225E100-0x000000018225E110
		[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
		public bool forceModuleActive { get; set; } // 0x000000018225E0F0-0x000000018225E100 0x000000018225E100-0x000000018225E110
		public float inputActionsPerSecond { get; set; } // 0x0000000187250E40-0x0000000187250E50 0x0000000187250F10-0x0000000187250F20
		public float repeatDelay { get; set; } // 0x000000018723F560-0x000000018723F570 0x000000018723F650-0x000000018723F660
		public string horizontalAxis { get; set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
		public string verticalAxis { get; set; } // 0x0000000182271B70-0x0000000182271B80 0x0000000188800C9C-0x0000000188800CB0
		public string submitButton { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public string cancelButton { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x0000000188800C88-0x0000000188800C9C
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 83822
		{
			// Fields
			public static readonly ProfilerMarker Process; // 0x00
			public static readonly ProfilerMarker ProcessMouseEvent; // 0x08
			public static readonly ProfilerMarker ProcessMousePress; // 0x10
			public static readonly ProfilerMarker ProcessTouchEvents; // 0x18
			public static readonly ProfilerMarker ProcessTouchPress; // 0x20
	
			// Constructors
			static ProfilerMarkers(); // 0x000000018D6ACD98-0x000000018D6ACEE4
		}
	
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode // TypeDefIndex: 83823
		{
			Mouse = 0,
			Buttons = 1
		}
	
		// Constructors
		protected StandaloneInputModule(); // 0x000000018D6B06E0-0x000000018D6B07B4
	
		// Methods
		private bool ShouldIgnoreEventsOnNoFocus(); // 0x00000001851A4410-0x00000001851A4420
		public override void UpdateModule(); // 0x000000018D6B05C8-0x000000018D6B06E0
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo); // 0x000000018D6AFCD8-0x000000018D6AFF60
		public override bool ShouldActivateModule(); // 0x000000018D6B03AC-0x000000018D6B05C8
		public override void ActivateModule(); // 0x000000018D6ADB40-0x000000018D6ADC68
		public override void DeactivateModule(); // 0x000000018D6ADC68-0x000000018D6ADC70
		public override void Process(); // 0x000000018D6AFB74-0x000000018D6AFCD8
		private bool ProcessTouchEvents(); // 0x000000018D6AE5A0-0x000000018D6AE7F0
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x000000018D6AE7F0-0x000000018D6AFB74
		protected bool SendSubmitEventToSelectedObject(); // 0x000000018D6B0174-0x000000018D6B02D8
		private Vector2 GetRawMoveVector(); // 0x000000018D6ADC70-0x000000018D6ADD74
		protected bool SendMoveEventToSelectedObject(); // 0x000000018D6AFF60-0x000000018D6B0174
		protected void ProcessMouseEvent(); // 0x000000018D6ADFDC-0x000000018D6AE0B0
		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		protected virtual bool ForceAutoSelect(); // 0x00000001843FFFF0-0x0000000184400000
		protected void ProcessMouseEvent(int id); // 0x000000018D6ADD74-0x000000018D6ADFDC
		protected bool SendUpdateEventToSelectedObject(); // 0x000000018D6B02D8-0x000000018D6B03AC
		protected void ProcessMousePress(MouseButtonEventData data); // 0x000000018D6AE0B0-0x000000018D6AE5A0
		protected GameObject GetCurrentFocusedGameObject(); // 0x00000001829CD170-0x00000001829CD180
	}

	[AddComponentMenu("Event/Touch Input Module")]
	[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
	public class TouchInputModule : PointerInputModule // TypeDefIndex: 83826
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
		public bool allowActivationOnStandalone { get; set; } // 0x0000000182271A20-0x0000000182271A30 0x0000000182271A30-0x0000000182271A40
		public bool forceModuleActive { get; set; } // 0x0000000182271A20-0x0000000182271A30 0x0000000182271A30-0x0000000182271A40
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 83825
		{
			// Fields
			public static readonly ProfilerMarker Process; // 0x00
			public static readonly ProfilerMarker ProcessTouchEvents; // 0x08
			public static readonly ProfilerMarker ProcessTouchPress; // 0x10
	
			// Constructors
			static ProfilerMarkers(); // 0x000000018D6ACCBC-0x000000018D6ACD98
		}
	
		// Constructors
		protected TouchInputModule(); // 0x000000018D6B23E0-0x000000018D6B23E8
	
		// Methods
		public override void UpdateModule(); // 0x000000018D6B2280-0x000000018D6B23BC
		public override bool IsModuleSupported(); // 0x000000018D6B08A4-0x000000018D6B08D4
		public override bool ShouldActivateModule(); // 0x000000018D6B1F28-0x000000018D6B2000
		private bool UseFakeInput(); // 0x000000018D6B23BC-0x000000018D6B23E0
		public override void Process(); // 0x000000018D6B1E38-0x000000018D6B1F28
		private void FakeTouches(); // 0x000000018D6B07B4-0x000000018D6B08A4
		private void ProcessTouchEvents(); // 0x000000018D6B08D4-0x000000018D6B0AF8
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x000000018D6B0AF8-0x000000018D6B1E38
		public override void DeactivateModule(); // 0x000000018D6ADC68-0x000000018D6ADC70
		public override string ToString(); // 0x000000018D6B2000-0x000000018D6B2280
	}

	public enum MoveDirection // TypeDefIndex: 83827
	{
		Left = 0,
		Up = 1,
		Right = 2,
		Down = 3,
		None = 4
	}

	internal static class RaycasterManager // TypeDefIndex: 83828
	{
		// Fields
		private static readonly List<BaseRaycaster> s_Raycasters; // 0x00
	
		// Constructors
		static RaycasterManager(); // 0x0000000187177270-0x0000000187177300
	
		// Methods
		public static void AddRaycaster(BaseRaycaster baseRaycaster); // 0x00000001862A5230-0x00000001862A52D0
		public static List<BaseRaycaster> GetRaycasters(); // 0x000000018D6AD558-0x000000018D6AD58C
		public static void RemoveRaycasters(BaseRaycaster baseRaycaster); // 0x00000001862A5160-0x00000001862A5200
	}

	public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 83829
	{
		// Fields
		private BaseRaycaster m_RootRaycaster; // 0x18
	
		// Properties
		public abstract Camera eventCamera { get; }
		[Obsolete("Please use sortOrderPriority and renderOrderPriority", false)]
		public virtual int priority { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public virtual int sortOrderPriority { get; } // 0x0000000187263FA0-0x0000000187263FB0 
		public virtual int renderOrderPriority { get; } // 0x0000000187263FA0-0x0000000187263FB0 
		public BaseRaycaster rootRaycaster { get; } // 0x00000001850F7AF0-0x00000001850F7BD0 
	
		// Constructors
		protected BaseRaycaster(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
		public override string ToString(); // 0x000000018D6A5BC4-0x000000018D6A5D68
		protected override void OnEnable(); // 0x00000001862A5200-0x00000001862A5230
		protected override void OnDisable(); // 0x00000001862A5130-0x00000001862A5160
		protected override void OnCanvasHierarchyChanged(); // 0x0000000187838E10-0x0000000187838E24
		protected override void OnTransformParentChanged(); // 0x0000000187838E10-0x0000000187838E24
	}

	[AddComponentMenu("Event/Physics 2D Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class Physics2DRaycaster : PhysicsRaycaster // TypeDefIndex: 83830
	{
		// Fields
		private RaycastHit2D[] m_Hits; // 0x40
	
		// Constructors
		protected Physics2DRaycaster(); // 0x000000018D6A9DDC-0x000000018D6A9DE4
	
		// Methods
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018D6A983C-0x000000018D6A9DDC
	}

	[AddComponentMenu("Event/Physics Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 83832
	{
		// Fields
		protected const int kNoEventMaskSet = -1; // Metadata: 0x02643C5C
		protected Camera m_EventCamera; // 0x20
		[SerializeField]
		protected LayerMask m_EventMask; // 0x28
		[SerializeField]
		protected int m_MaxRayIntersections; // 0x2C
		protected int m_LastMaxRayIntersections; // 0x30
		private RaycastHit[] m_Hits; // 0x38
	
		// Properties
		public override Camera eventCamera { get; } // 0x000000018D6AA578-0x000000018D6AA608 
		public virtual int depth { get; } // 0x000000018D6AA4E8-0x000000018D6AA578 
		public int finalEventMask { get; } // 0x000000018D6AA608-0x000000018D6AA698 
		public LayerMask eventMask { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public int maxRayIntersections { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
	
		// Nested types
		private class RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 83831
		{
			// Fields
			public static RaycastHitComparer instance; // 0x00
	
			// Constructors
			public RaycastHitComparer(); // 0x0000000186805BA0-0x0000000186805BB0
			static RaycastHitComparer(); // 0x000000018D6AD01C-0x000000018D6AD080
	
			// Methods
			public int Compare(RaycastHit x, RaycastHit y); // 0x000000018D6ACFF0-0x000000018D6AD01C
		}
	
		// Constructors
		protected PhysicsRaycaster(); // 0x000000018D6AA4C8-0x000000018D6AA4E8
	
		// Methods
		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane); // 0x000000018D6A9DE4-0x000000018D6AA0CC
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018D6AA0CC-0x000000018D6AA4C8
	}

	public struct RaycastResult // TypeDefIndex: 83833
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
		public GameObject gameObject { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public bool isValid { get; } // 0x000000018D6AD4E4-0x000000018D6AD558 
	
		// Methods
		public void Clear(); // 0x000000018D6AD080-0x000000018D6AD114
		public override string ToString(); // 0x000000018D6AD114-0x000000018D6AD4E4
	}

	public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 83834
	{
		// Constructors
		protected UIBehaviour(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected virtual void Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool IsActive(); // 0x00000001850D3AE0-0x00000001850D3B10
		protected virtual void OnRectTransformDimensionsChange(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnBeforeTransformParentChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnTransformParentChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnDidApplyAnimationProperties(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnCanvasHierarchyChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		public bool IsDestroyed(); // 0x00000001851C3800-0x00000001851C3A30
	}
}

namespace UnityEngine.UI
{
	[Serializable]
	public class AnimationTriggers // TypeDefIndex: 83622
	{
		// Fields
		private const string kDefaultNormalAnimName = "Normal"; // Metadata: 0x02643B00
		private const string kDefaultHighlightedAnimName = "Highlighted"; // Metadata: 0x02643B07
		private const string kDefaultPressedAnimName = "Pressed"; // Metadata: 0x02643B13
		private const string kDefaultSelectedAnimName = "Selected"; // Metadata: 0x02643B1B
		private const string kDefaultDisabledAnimName = "Disabled"; // Metadata: 0x02643B24
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
		public string normalTrigger { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string highlightedTrigger { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public string pressedTrigger { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public string selectedTrigger { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		public string disabledTrigger { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
		// Constructors
		public AnimationTriggers(); // 0x000000018548FAE0-0x000000018548FB50
	}

	[AddComponentMenu("UI/Button", 30)]
	public class Button : Selectable, IPointerClickHandler, ISubmitHandler // TypeDefIndex: 83625
	{
		// Fields
		[FormerlySerializedAs("onClick")]
		[SerializeField]
		private ButtonClickedEvent m_OnClick; // 0x190
	
		// Properties
		public ButtonClickedEvent onClick { get; set; } // 0x000000018723C0A0-0x000000018723C0B0 0x0000000188DC4B4C-0x0000000188DC4B60
	
		// Nested types
		[Serializable]
		public class ButtonClickedEvent : UnityEvent // TypeDefIndex: 83623
		{
			// Constructors
			public ButtonClickedEvent(); // 0x000000018548D960-0x000000018548D970
		}
	
		[CompilerGenerated]
		private sealed class _OnFinishSubmit_d__9 : IEnumerator<object> // TypeDefIndex: 83624
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Button __4__this; // 0x20
			private float _fadeTime_5__2; // 0x28
			private float _elapsedTime_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _OnFinishSubmit_d__9(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D595E60-0x000000018D595F60
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D595F60-0x000000018D595FAC
		}
	
		// Constructors
		protected Button(); // 0x0000000186A5D110-0x0000000186A5D1B0
	
		// Methods
		private void Press(); // 0x0000000185032B20-0x0000000185032BA0
		public virtual void OnPointerClick(PointerEventData eventData); // 0x0000000185032BE0-0x0000000185032C10
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018D589E6C-0x000000018D589ED0
		[IteratorStateMachine(typeof(_OnFinishSubmit_d__9))]
		private IEnumerator OnFinishSubmit(); // 0x000000018D589E10-0x000000018D589E6C
	}

	public enum CanvasUpdate // TypeDefIndex: 83626
	{
		Prelayout = 0,
		Layout = 1,
		PostLayout = 2,
		PreRender = 3,
		LatePreRender = 4,
		MaxUpdateValue = 5
	}

	public interface ICanvasElement // TypeDefIndex: 83627
	{
		// Properties
		Transform transform { get; }
	
		// Methods
		void Rebuild(CanvasUpdate executing);
		void LayoutComplete();
		void GraphicUpdateComplete();
		bool IsDestroyed();
	}

	public class CanvasUpdateRegistry // TypeDefIndex: 83628
	{
		// Fields
		private static CanvasUpdateRegistry s_Instance; // 0x00
		private bool m_PerformingLayoutUpdate; // 0x10
		private bool m_PerformingGraphicUpdate; // 0x11
		private ProfilerMarker[] m_CanvasUpdateProfilerStrings; // 0x18
		private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull"; // Metadata: 0x02643B33
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x08
	
		// Properties
		public static CanvasUpdateRegistry instance { get; } // 0x00000001851C4C90-0x00000001851C4D60 
	
		// Constructors
		protected CanvasUpdateRegistry(); // 0x0000000186CAE070-0x0000000186CAE2D0
		static CanvasUpdateRegistry(); // 0x0000000187114120-0x00000001871141C0
	
		// Methods
		private bool ObjectValidForUpdate(ICanvasElement element); // 0x00000001851C2800-0x00000001851C3800
		private void CleanInvalidItems(); // 0x00000001851C1720-0x00000001851C1940
		private void PerformUpdate(); // 0x00000001851C1940-0x00000001851C2800
		private static int ParentCount(Transform child); // 0x00000001851C6570-0x00000001851C6690
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y); // 0x000000018501A280-0x000000018501A870
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018531ED10-0x000000018531ED80
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001851C3DD0-0x00000001851C40A0
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001851C4F20-0x00000001851C5160
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001851C49E0-0x00000001851C4C90
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018D589ED0-0x000000018D589F28
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001851C4D60-0x00000001851C4F20
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element); // 0x00000001851C40A0-0x00000001851C44D0
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001851C3A30-0x00000001851C3C00
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x00000001851C3C00-0x00000001851C3DD0
		public static bool IsRebuildingLayout(); // 0x0000000185574500-0x0000000185574590
		public static bool IsRebuildingGraphics(); // 0x0000000185D2CCE0-0x0000000185D2CE50
	}

	[Serializable]
	public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 83629
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
		public UnityEngine.Color normalColor { get; set; } // 0x000000018723AC80-0x000000018723AC90 0x000000018723AC90-0x000000018723ACA0
		public UnityEngine.Color highlightedColor { get; set; } // 0x0000000184430480-0x0000000184430490 0x0000000187239680-0x0000000187239690
		public UnityEngine.Color pressedColor { get; set; } // 0x0000000187238F60-0x0000000187238F70 0x0000000187238F70-0x0000000187238F80
		public UnityEngine.Color selectedColor { get; set; } // 0x0000000187234010-0x0000000187234020 0x0000000187234020-0x0000000187234030
		public UnityEngine.Color disabledColor { get; set; } // 0x000000018723E4C0-0x000000018723E4D0 0x0000000187234080-0x0000000187234090
		public float colorMultiplier { get; set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
		public float fadeDuration { get; set; } // 0x0000000187233590-0x00000001872335A0 0x00000001872335A0-0x00000001872335B0
	
		// Constructors
		static ColorBlock(); // 0x0000000186FA52B0-0x0000000186FA53E0
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D58A258-0x000000018D58A308
		public bool Equals(ColorBlock other); // 0x000000018D58A308-0x000000018D58A48C
		public static bool operator ==(ColorBlock point1, ColorBlock point2); // 0x000000018D58A510-0x000000018D58A5A4
		public static bool operator !=(ColorBlock point1, ColorBlock point2); // 0x000000018D58A5A4-0x000000018D58A63C
		public override int GetHashCode(); // 0x000000018D58A48C-0x000000018D58A510
	}

	public class ClipperRegistry // TypeDefIndex: 83630
	{
		// Fields
		private static ClipperRegistry s_Instance; // 0x00
		internal readonly IndexedSet<IClipper> m_Clippers; // 0x10
		private readonly ProfilerMarker clippersMarker; // 0x18
	
		// Properties
		public static ClipperRegistry instance { get; } // 0x00000001851C1210-0x00000001851C1290 
	
		// Constructors
		protected ClipperRegistry(); // 0x0000000187106850-0x0000000187106900
	
		// Methods
		public void Cull(); // 0x00000001851C1170-0x00000001851C1210
		private void CullOriginal(); // 0x000000018D589F28-0x000000018D589FC0
		public static void Register(IClipper c); // 0x00000001851BFDD0-0x00000001851BFE10
		public static void Unregister(IClipper c); // 0x00000001851BF740-0x00000001851BF780
	}

	public static class Clipping // TypeDefIndex: 83631
	{
		// Methods
		public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect); // 0x000000018D589FC0-0x000000018D58A258
	}

	public interface IClipper // TypeDefIndex: 83632
	{
		// Methods
		void PerformClipping();
	}

	public interface IClippable // TypeDefIndex: 83633
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

	internal class RectangularVertexClipper // TypeDefIndex: 83634
	{
		// Fields
		private readonly Vector3[] m_WorldCorners; // 0x10
		private readonly Vector3[] m_CanvasCorners; // 0x18
	
		// Constructors
		public RectangularVertexClipper(); // 0x000000018548FD10-0x000000018548FD60
	
		// Methods
		public Rect GetCanvasRect(RectTransform t, Canvas c); // 0x000000018D595B34-0x000000018D595D70
		public Rect GetCanvasRectAABB(RectTransform t, Canvas c); // 0x000000018D5958E4-0x000000018D595B34
	}

	public static class DefaultControls // TypeDefIndex: 83638
	{
		// Fields
		private static IFactoryControls m_CurrentFactory; // 0x00
		private const float kWidth = 160f; // Metadata: 0x02643B48
		private const float kThickHeight = 30f; // Metadata: 0x02643B4C
		private const float kThinHeight = 20f; // Metadata: 0x02643B50
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static Vector2 s_ImageElementSize; // 0x18
		private static UnityEngine.Color s_DefaultSelectableColor; // 0x20
		private static UnityEngine.Color s_PanelColor; // 0x30
		private static UnityEngine.Color s_TextColor; // 0x40
	
		// Properties
		public static IFactoryControls factory { get; } // 0x000000018D58E3A0-0x000000018D58E3F0 
	
		// Nested types
		public interface IFactoryControls // TypeDefIndex: 83635
		{
			// Methods
			GameObject CreateGameObject(string name, params System.Type[] components);
		}
	
		private class DefaultRuntimeFactory : IFactoryControls // TypeDefIndex: 83636
		{
			// Fields
			public static IFactoryControls Default; // 0x00
	
			// Constructors
			public DefaultRuntimeFactory(); // 0x0000000186805BA0-0x0000000186805BB0
			static DefaultRuntimeFactory(); // 0x000000018D58E460-0x000000018D58E4C4
	
			// Methods
			public GameObject CreateGameObject(string name, params System.Type[] components); // 0x000000018D58E3F0-0x000000018D58E460
		}
	
		public struct Resources // TypeDefIndex: 83637
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
		static DefaultControls(); // 0x000000018D58E28C-0x000000018D58E3A0
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size, params System.Type[] components); // 0x000000018D58DEC8-0x000000018D58DF74
		private static GameObject CreateUIObject(string name, GameObject parent, params System.Type[] components); // 0x000000018D58DF74-0x000000018D58DFF8
		private static void SetDefaultTextValues(Text lbl); // 0x000000018D58E048-0x000000018D58E100
		private static void SetDefaultColorTransitionValues(Selectable slider); // 0x000000018D58DFF8-0x000000018D58E048
		private static void SetParentAndAlign(GameObject child, GameObject parent); // 0x000000018D58E1C0-0x000000018D58E28C
		private static void SetLayerRecursively(GameObject go, int layer); // 0x000000018D58E100-0x000000018D58E1C0
		public static GameObject CreatePanel(Resources resources); // 0x000000018D58C16C-0x000000018D58C39C
		public static GameObject CreateButton(Resources resources); // 0x000000018D58A63C-0x000000018D58A998
		public static GameObject CreateText(Resources resources); // 0x000000018D58D7A4-0x000000018D58D908
		public static GameObject CreateImage(Resources resources); // 0x000000018D58BAD0-0x000000018D58BBDC
		public static GameObject CreateRawImage(Resources resources); // 0x000000018D58C39C-0x000000018D58C4A8
		public static GameObject CreateSlider(Resources resources); // 0x000000018D58D058-0x000000018D58D7A4
		public static GameObject CreateScrollbar(Resources resources); // 0x000000018D58CC04-0x000000018D58D058
		public static GameObject CreateToggle(Resources resources); // 0x000000018D58D908-0x000000018D58DEC8
		public static GameObject CreateInputField(Resources resources); // 0x000000018D58BBDC-0x000000018D58C16C
		public static GameObject CreateDropdown(Resources resources); // 0x000000018D58A998-0x000000018D58BAD0
		public static GameObject CreateScrollView(Resources resources); // 0x000000018D58C4A8-0x000000018D58CC04
	}

	[RequireComponent(typeof(RectTransform))]
	public class Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 83645
	{
		// Fields
		[SerializeField]
		private RectTransform m_Template; // 0x190
		[SerializeField]
		private Text m_CaptionText; // 0x198
		[SerializeField]
		private Image m_CaptionImage; // 0x1A0
		[SerializeField]
		[Space]
		private Text m_ItemText; // 0x1A8
		[SerializeField]
		private Image m_ItemImage; // 0x1B0
		[SerializeField]
		[Space]
		private int m_Value; // 0x1B8
		[SerializeField]
		[Space]
		private OptionDataList m_Options; // 0x1C0
		[SerializeField]
		[Space]
		private DropdownEvent m_OnValueChanged; // 0x1C8
		[SerializeField]
		private float m_AlphaFadeSpeed; // 0x1D0
		private GameObject m_Dropdown; // 0x1D8
		private GameObject m_Blocker; // 0x1E0
		private List<DropdownItem> m_Items; // 0x1E8
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x1F0
		private bool validTemplate; // 0x1F8
		private const int kHighSortingLayer = 30000; // Metadata: 0x02643B55
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get; set; } // 0x000000018723C0A0-0x000000018723C0B0 0x000000018D591340-0x000000018D591368
		public Text captionText { get; set; } // 0x000000018723C220-0x000000018723C230 0x000000018D591294-0x000000018D5912BC
		public Image captionImage { get; set; } // 0x000000018723BE20-0x000000018723BE30 0x000000018D59126C-0x000000018D591294
		public Text itemText { get; set; } // 0x000000018723BDE0-0x000000018723BDF0 0x000000018D5912E4-0x000000018D59130C
		public Image itemImage { get; set; } // 0x000000018723BD90-0x000000018723BDA0 0x000000018D5912BC-0x000000018D5912E4
		public List<OptionData> options { get; set; } // 0x000000018D59124C-0x000000018D59126C 0x000000018D59130C-0x000000018D591340
		public DropdownEvent onValueChanged { get; set; } // 0x000000018723BC50-0x000000018723BC60 0x0000000188DC4430-0x0000000188DC4444
		public float alphaFadeSpeed { get; set; } // 0x000000018723C430-0x000000018723C440 0x000000018723C4E0-0x000000018723C4F0
		public int value { get; set; } // 0x000000018723C5D0-0x000000018723C5E0 0x000000018D591368-0x000000018D591374
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 83639
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
			public Text text { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public Image image { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
			public RectTransform rectTransform { get; set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
			public Toggle toggle { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
			// Constructors
			public DropdownItem(); // 0x00000001878364A0-0x00000001878364B8
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018D58E578-0x000000018D58E5E4
			public virtual void OnCancel(BaseEventData eventData); // 0x000000018D58E500-0x000000018D58E578
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 83640
		{
			// Fields
			[SerializeField]
			private string m_Text; // 0x10
			[SerializeField]
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
			public Sprite image { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
			// Constructors
			public OptionData(); // 0x0000000186805BA0-0x0000000186805BB0
			public OptionData(string text); // 0x0000000184FD2410-0x0000000184FD2420
			public OptionData(Sprite image); // 0x0000000187835500-0x0000000187835510
			public OptionData(string text, Sprite image); // 0x0000000185381AC0-0x0000000185381AF0
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 83641
		{
			// Fields
			[SerializeField]
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
			// Constructors
			public OptionDataList(); // 0x000000018D59586C-0x000000018D5958E4
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 83642
		{
			// Constructors
			public DropdownEvent(); // 0x000000018D58E4C4-0x000000018D58E500
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0 // TypeDefIndex: 83643
		{
			// Fields
			public DropdownItem item; // 0x10
			public Dropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass63_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Show_b__0(bool x); // 0x000000018D595FAC-0x000000018D596428
		}
	
		[CompilerGenerated]
		private sealed class _DelayedDestroyDropdownList_d__75 : IEnumerator<object> // TypeDefIndex: 83644
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float delay; // 0x20
			public Dropdown __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedDestroyDropdownList_d__75(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D595D70-0x000000018D595E14
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D595E14-0x000000018D595E60
		}
	
		// Constructors
		protected Dropdown(); // 0x000000018D591124-0x000000018D59124C
		static Dropdown(); // 0x000000018D5910B4-0x000000018D591124
	
		// Methods
		public void SetValueWithoutNotify(int input); // 0x000000018D58FA80-0x000000018D58FA8C
		private void Set(int value, bool sendCallback = true /* Metadata: 0x02643B54 */); // 0x000000018D58FA8C-0x000000018D58FB7C
		protected override void Awake(); // 0x000000018D58ECD0-0x000000018D58EDB8
		protected override void Start(); // 0x000000018D591024-0x000000018D5910B4
		protected override void OnDisable(); // 0x000000018D58F658-0x000000018D58F6EC
		public void RefreshShownValue(); // 0x000000018D58F7FC-0x000000018D58F9E0
		public void AddOptions(List<OptionData> options); // 0x000000018D58EA78-0x000000018D58EAE0
		public void AddOptions(List<string> options); // 0x000000018D58E870-0x000000018D58E974
		public void AddOptions(List<Sprite> options); // 0x000000018D58E974-0x000000018D58EA78
		public void ClearOptions(); // 0x000000018D58EDB8-0x000000018D58EE1C
		private void SetupTemplate(Canvas rootCanvas); // 0x000000018D58FB7C-0x000000018D5901C4
		private static T GetOrAddComponent<T>(GameObject go)
			where T : UnityEngine.Component;
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018D58F6EC-0x000000018D58F6F4
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018D58F6EC-0x000000018D58F6F4
		public virtual void OnCancel(BaseEventData eventData); // 0x000000018D58F650-0x000000018D58F658
		public void Show(); // 0x000000018D5901C4-0x000000018D591024
		protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x000000018D58EE1C-0x000000018D58F254
		protected virtual void DestroyBlocker(GameObject blocker); // 0x000000018D58F36C-0x000000018D58F3B8
		protected virtual GameObject CreateDropdownList(GameObject template); // 0x000000018D58F254-0x000000018D58F2A8
		protected virtual void DestroyDropdownList(GameObject dropdownList); // 0x000000018D58F3B8-0x000000018D58F404
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate); // 0x000000018D58F2A8-0x000000018D58F2FC
		protected virtual void DestroyItem(DropdownItem item); // 0x0000000186805BA0-0x0000000186805BB0
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items); // 0x000000018D58E5E4-0x000000018D58E870
		private void AlphaFadeList(float duration, float alpha); // 0x000000018D58EC44-0x000000018D58ECD0
		private void AlphaFadeList(float duration, float start, float end); // 0x000000018D58EAE0-0x000000018D58EC44
		private void SetAlpha(float alpha); // 0x000000018D58F9E0-0x000000018D58FA80
		public void Hide(); // 0x000000018D58F404-0x000000018D58F4FC
		[IteratorStateMachine(typeof(_DelayedDestroyDropdownList_d__75))]
		private IEnumerator DelayedDestroyDropdownList(float delay); // 0x000000018D58F2FC-0x000000018D58F36C
		private void ImmediateDestroyDropdownList(); // 0x000000018D58F4FC-0x000000018D58F650
		private void OnSelectItem(Toggle toggle); // 0x000000018D58F6F4-0x000000018D58F7FC
	}

	[Serializable]
	public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 83646
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
		public static FontData defaultFontData { get; } // 0x0000000186B8D6A0-0x0000000186B8D710 
		public Font font { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public int fontSize { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public FontStyle fontStyle { get; set; } // 0x0000000187233000-0x0000000187233010 0x0000000187233010-0x0000000187233020
		public bool bestFit { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public int minSize { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public int maxSize { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public TextAnchor alignment { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public bool alignByGeometry { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
		public bool richText { get; set; } // 0x0000000182260CA0-0x0000000182260CB0 0x0000000182260CB0-0x0000000182260CC0
		public HorizontalWrapMode horizontalOverflow { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		public VerticalWrapMode verticalOverflow { get; set; } // 0x00000001829600C0-0x00000001829600D0 0x0000000185E3C070-0x0000000185E3C080
		public float lineSpacing { get; set; } // 0x00000001872330B0-0x00000001872330C0 0x0000000187233110-0x0000000187233120
	
		// Constructors
		public FontData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000186E65B00-0x0000000186E65B60
	}

	public static class FontUpdateTracker // TypeDefIndex: 83647
	{
		// Fields
		private static Dictionary<Font, HashSet<Text>> m_Tracked; // 0x00
	
		// Constructors
		static FontUpdateTracker(); // 0x000000018D591900-0x000000018D59198C
	
		// Methods
		public static void TrackText(Text t); // 0x000000018D5914F8-0x000000018D59171C
		private static void RebuildForFont(Font f); // 0x000000018D591374-0x000000018D5914F8
		public static void UntrackText(Text t); // 0x000000018D59171C-0x000000018D591900
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 83648
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
		[CompilerGenerated]
		private bool _useLegacyMeshGeneration_k__BackingField; // 0xA8
	
		// Properties
		public static string defaultMaterialName { get; set; } // 0x000000018D591DA4-0x000000018D591DF4 0x000000018D591E44-0x000000018D591EA4
		public static Material defaultGraphicMaterial { get; } // 0x00000001852E3C20-0x00000001852E3DE0 
		public static string overlayShaderKeyword { get; set; } // 0x000000018D591DF4-0x000000018D591E44 0x000000018D591ED4-0x000000018D591F34
		public virtual UnityEngine.Color color { get; set; } // 0x0000000187238F60-0x0000000187238F70 0x0000000185358320-0x0000000185358390
		public virtual bool raycastTarget { get; set; } // 0x000000018226EE20-0x000000018226EE30 0x0000000185C8D000-0x0000000185C8D0B0
		public Vector4 raycastPadding { get; set; } // 0x0000000187236090-0x00000001872360A0 0x00000001872360A0-0x00000001872360B0
		private TweenRunner<ColorTween> m_ColorTweenRunner { get; } // 0x0000000185576D00-0x0000000185576D70 
		public virtual bool enableRuntimeAtlas { get; set; } // 0x0000000182271B80-0x0000000182271B90 0x000000018D591EA4-0x000000018D591ED4
		public Texture runtimeAtlasTexture { get; set; } // 0x0000000187232F60-0x0000000187232F70 0x000000018D591F34-0x000000018D591F60
		protected bool useLegacyMeshGeneration { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E110-0x000000018225E120 0x000000018225E120-0x000000018225E130
		public int depth { get; } // 0x0000000185148650-0x0000000185148E10 
		public RectTransform rectTransform { get; } // 0x000000018514A9C0-0x000000018514AE30 
		public Canvas canvas { get; } // 0x00000001850D4970-0x00000001850D50F0 
		public CanvasRenderer canvasRenderer { get; } // 0x000000018514A520-0x000000018514A9C0 
		public virtual Material defaultMaterial { get; } // 0x00000001852E3BF0-0x00000001852E3C20 
		public virtual Material material { get; set; } // 0x00000001862BF700-0x00000001862BF790 0x00000001863388D0-0x0000000186338940
		public virtual Material materialForRendering { get; } // 0x00000001852E16F0-0x00000001852E2A80 
		public virtual Texture mainTexture { get; } // 0x0000000186D3BCE0-0x0000000186D3BD40 
		protected static Mesh workerMesh { get; } // 0x000000018569A1A0-0x000000018569A330 
		Transform ICanvasElement.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Constructors
		protected Graphic(); // 0x000000018548FA10-0x000000018548FA60
		static Graphic(); // 0x0000000186FC0ED0-0x0000000186FC1010
	
		// Methods
		public virtual void SetAllDirty(); // 0x0000000185E58A60-0x0000000185E58AB0
		public virtual void SetLayoutDirty(); // 0x0000000185DD0930-0x0000000185DD0AA0
		public virtual void SetVerticesDirty(); // 0x00000001851C44D0-0x00000001851C4760
		public virtual void SetMaterialDirty(); // 0x00000001851C4760-0x00000001851C49E0
		protected override void OnRectTransformDimensionsChange(); // 0x00000001851C8A90-0x00000001851C97C0
		protected override void OnBeforeTransformParentChanged(); // 0x000000018624D830-0x000000018624D8B0
		protected override void OnTransformParentChanged(); // 0x00000001861D2FC0-0x00000001861D3050
		private void CacheCanvas(); // 0x00000001850D50F0-0x00000001850D5A70
		protected override void OnEnable(); // 0x00000001850FD0A0-0x00000001850FDD60
		protected override void OnDisable(); // 0x00000001850FDD60-0x00000001850FEBE0
		protected override void OnDestroy(); // 0x00000001852E4AD0-0x00000001852E4BC0
		protected override void OnCanvasHierarchyChanged(); // 0x0000000185B089C0-0x0000000185B08B60
		public virtual void OnCullingChanged(); // 0x0000000185044A20-0x0000000185044AA0
		public virtual void Rebuild(CanvasUpdate update); // 0x0000000185148E10-0x0000000185149640
		public virtual void LayoutComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void GraphicUpdateComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void UpdateMaterial(); // 0x00000001852E3500-0x00000001852E3800
		protected virtual void UpdateGeometry(); // 0x0000000185695FB0-0x0000000185695FE0
		private void DoMeshGeneration(); // 0x00000001856999E0-0x000000018569A1A0
		private void DoLegacyMeshGeneration(); // 0x0000000186B949C0-0x0000000186B94CA0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use OnPopulateMesh instead.", true)]
		protected virtual void OnFillVBO(List<UIVertex> vbo); // 0x0000000186805BA0-0x0000000186805BB0
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		protected virtual void OnPopulateMesh(Mesh m); // 0x0000000186EB5D80-0x0000000186EB5E20
		protected virtual void OnPopulateMesh(VertexHelper vh); // 0x000000018564B9D0-0x000000018564C250
		protected override void OnDidApplyAnimationProperties(); // 0x000000018D591A30-0x000000018D591A40
		public virtual void SetNativeSize(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool Raycast(Vector2 sp, Camera eventCamera); // 0x00000001850D31D0-0x00000001850D3A40
		public Vector2 PixelAdjustPoint(Vector2 point); // 0x000000018D591A40-0x000000018D591B74
		public Rect GetPixelAdjustedRect(); // 0x00000001850D3E90-0x00000001850D4970
		public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x00000001855766A0-0x0000000185576720
		public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB); // 0x0000000185576720-0x0000000185576C50
		private static UnityEngine.Color CreateColorFromAlpha(float alpha); // 0x0000000186879F20-0x0000000186879F50
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x0000000186879E30-0x0000000186879F20
		public void RegisterDirtyLayoutCallback(UnityAction action); // 0x000000018D591B74-0x000000018D591C00
		public void UnregisterDirtyLayoutCallback(UnityAction action); // 0x000000018D591C8C-0x000000018D591D18
		public void RegisterDirtyVerticesCallback(UnityAction action); // 0x0000000185A08950-0x0000000185A089E0
		public void UnregisterDirtyVerticesCallback(UnityAction action); // 0x0000000185A08010-0x0000000185A080A0
		public void RegisterDirtyMaterialCallback(UnityAction action); // 0x000000018D591C00-0x000000018D591C8C
		public void UnregisterDirtyMaterialCallback(UnityAction action); // 0x000000018D591D18-0x000000018D591DA4
	}

	[AddComponentMenu("Event/Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 83651
	{
		// Fields
		protected const int kNoEventMaskSet = -1; // Metadata: 0x02643B59
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
		public override int sortOrderPriority { get; } // 0x000000018531DC40-0x000000018531DD40 
		public override int renderOrderPriority { get; } // 0x0000000185F32640-0x0000000185F32730 
		public bool ignoreReversedGraphics { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public BlockingObjects blockingObjects { get; set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public LayerMask blockingMask { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		private Canvas canvas { get; } // 0x00000001850FBC00-0x00000001850FBCA0 
		public override Camera eventCamera { get; } // 0x00000001850FBEE0-0x00000001850FC0B0 
	
		// Nested types
		public enum BlockingObjects // TypeDefIndex: 83649
		{
			None = 0,
			TwoD = 1,
			ThreeD = 2,
			All = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83650
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Graphic> __9__27_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E6200-0x00000001871E6260
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _Raycast_b__27_0(Graphic g1, Graphic g2); // 0x00000001850F7A90-0x00000001850F7AF0
		}
	
		// Constructors
		protected GraphicRaycaster(); // 0x00000001865EF650-0x00000001865EF6C0
		static GraphicRaycaster(); // 0x00000001865EF520-0x00000001865EF5B0
	
		// Methods
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x00000001850F9E90-0x00000001850FBC00
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results); // 0x0000000185147BE0-0x00000001851485D0
	}

	public class GraphicRegistry // TypeDefIndex: 83652
	{
		// Fields
		private static GraphicRegistry s_Instance; // 0x00
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
		private static readonly List<Graphic> s_EmptyList; // 0x08
	
		// Properties
		public static GraphicRegistry instance { get; } // 0x00000001850FBE10-0x00000001850FBEE0 
	
		// Constructors
		protected GraphicRegistry(); // 0x0000000186EB4FC0-0x0000000186EB5140
		static GraphicRegistry(); // 0x00000001865EF5B0-0x00000001865EF650
	
		// Methods
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic); // 0x00000001850FC8B0-0x00000001850FCE80
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic); // 0x00000001850FCE80-0x00000001850FD0A0
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic); // 0x00000001850FC0F0-0x00000001850FC620
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic); // 0x00000001850FC620-0x00000001850FC8B0
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas); // 0x000000018D59198C-0x000000018D591A30
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas); // 0x00000001850FBCA0-0x00000001850FBE10
	}

	public class HGImage : Image // TypeDefIndex: 83653
	{
		// Constructors
		public HGImage(); // 0x000000018548F3A0-0x000000018548F600
	
		// Methods
		protected override void UpdateGeometry(); // 0x0000000185697570-0x00000001856979A0
		private bool CanUseBatchedPath(); // 0x00000001856979A0-0x0000000185697E00
		protected sealed override void OnPopulateMesh(VertexHelper toFill); // 0x000000018564A6B0-0x000000018564A890
		protected virtual void OnPopulateMeshFallback(VertexHelper toFill); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class HGUIBatchInit // TypeDefIndex: 83654
	{
		// Methods
		public static void Initialize(); // 0x0000000186CAE2D0-0x0000000186CAE3E0
	}

	internal static class HGUIBatchClipper // TypeDefIndex: 83655
	{
		// Fields
		[CompilerGenerated]
		private static bool _Enabled_k__BackingField; // 0x00
		private static readonly ProfilerMarker s_BatchPrepareMarker; // 0x08
		private static readonly ProfilerMarker s_BatchComputeMarker; // 0x10
		private static readonly ProfilerMarker s_BatchDispatchMarker; // 0x18
		private static readonly List<RectMask2D> s_BatchMasks; // 0x20
		private static readonly List<MaskableGraphic> s_FlatTargets; // 0x28
	
		// Properties
		public static bool Enabled { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D592004-0x000000018D592054 0x000000018D592054-0x000000018D5920A8
	
		// Constructors
		static HGUIBatchClipper(); // 0x0000000186EB4E00-0x0000000186EB4FC0
	
		// Methods
		public static void CullBatched(IList<IClipper> clippers); // 0x000000018514B210-0x000000018514CF60
	}

	internal static class HGImageBatchHelper // TypeDefIndex: 83656
	{
		// Fields
		[CompilerGenerated]
		private static bool _Enabled_k__BackingField; // 0x00
		private const int kMaxBatchImageCount = 256; // Metadata: 0x02643B5E
		private static NativeArray<HGImageBatchBindings.HGBatchImageInput> s_BatchBuffer; // 0x08
		private static int s_BatchCount; // 0x18
		private static readonly ProfilerMarker s_BatchFlushMarker; // 0x20
	
		// Properties
		public static bool Enabled { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D591F60-0x000000018D591FB0 0x000000018D591FB0-0x000000018D592004
	
		// Constructors
		static HGImageBatchHelper(); // 0x00000001871C6BC0-0x00000001871C6C30
	
		// Methods
		public static void Enqueue(Image image); // 0x0000000185697190-0x0000000185697570
		public static void Flush(); // 0x00000001851C0FC0-0x00000001851C1170
		private static void EnsureBatchBuffer(); // 0x0000000185697EB0-0x0000000185697F70
		public static void FillHGImageData(Image image, ref CanvasRenderer.HGImageData data); // 0x0000000185697F70-0x00000001856987B0
	}

	[Obsolete("Not supported anymore")]
	internal interface IGraphicEnabledDisabled // TypeDefIndex: 83657
	{
		// Methods
		void OnSiblingGraphicEnabledDisabled();
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 83667
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
		private const int QuadCount = 4; // Metadata: 0x02643B60
		private static readonly Vector3[] s_Xy; // 0x18
		private static readonly Vector3[] s_Uv; // 0x20
		private static List<Image> m_TrackedTexturelessImages; // 0x28
		private static bool s_Initialized; // 0x30
		protected const int VALIDATE_MAX_VERT_COUNT = 10000; // Metadata: 0x02643B61
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
		internal override bool hasCullOverride { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public Rect runtimeAtlasRect { get; set; } // 0x000000018724F4D0-0x000000018724F4E0 0x000000018724F500-0x000000018724F510
		public Rect runtimeAtlasTextureRect { get; set; } // 0x000000018724F4B0-0x000000018724F4C0 0x0000000187233E00-0x0000000187233E10
		public Vector4 runtimeAtlasBorder { get; set; } // 0x000000018724F4A0-0x000000018724F4B0 0x0000000187233B20-0x0000000187233B30
		public float runtimeAtlasPixelsPerUnit { get; set; } // 0x0000000187262680-0x0000000187262690 0x00000001872626C0-0x00000001872626D0
		public Sprite sprite { get; set; } // 0x00000001872354B0-0x00000001872354C0 0x0000000185101580-0x0000000185101C40
		public bool enableRuntimeAtlasRaw { get; } // 0x0000000182271B80-0x0000000182271B90 
		public override bool enableRuntimeAtlas { get; set; } // 0x0000000185D2CE50-0x0000000185D2CE70 0x000000018D591EA4-0x000000018D591ED4
		public Sprite overrideSprite { get; set; } // 0x0000000187837134-0x000000018783713C 0x000000018D595724-0x000000018D59578C
		private Sprite activeSprite { get; } // 0x00000001850D5A70-0x00000001850D5B00 
		public Type type { get; set; } // 0x000000018723E940-0x000000018723E950 0x000000018D5957B0-0x000000018D59580C
		public bool preserveAspect { get; set; } // 0x00000001872558C0-0x00000001872558D0 0x0000000186542890-0x0000000186542900
		public bool fillCenter { get; set; } // 0x0000000187262660-0x0000000187262670 0x000000018D5955A0-0x000000018D595600
		public FillMethod fillMethod { get; set; } // 0x0000000187233DE0-0x0000000187233DF0 0x000000018D595660-0x000000018D5956C8
		public float fillAmount { get; set; } // 0x00000001872558F0-0x0000000187255900 0x00000001855074C0-0x00000001855075D0
		public bool fillClockwise { get; set; } // 0x000000018723B7F0-0x000000018723B800 0x000000018D595600-0x000000018D595660
		public int fillOrigin { get; set; } // 0x0000000187262670-0x0000000187262680 0x000000018D5956C8-0x000000018D595724
		[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
		public float eventAlphaThreshold { get; set; } // 0x0000000187262640-0x0000000187262660 0x00000001872626A0-0x00000001872626C0
		public float alphaHitTestMinimumThreshold { get; set; } // 0x000000018723D6D0-0x000000018723D6E0 0x000000018723D700-0x000000018723D710
		public bool useSpriteMesh { get; set; } // 0x0000000187262690-0x00000001872626A0 0x000000018D59580C-0x000000018D59586C
		public static Material defaultETC1GraphicMaterial { get; } // 0x000000018D5954D8-0x000000018D5955A0 
		public override Texture mainTexture { get; } // 0x0000000185101040-0x0000000185101430 
		public bool hasBorder { get; } // 0x00000001856C0770-0x00000001856C08A0 
		public float pixelsPerUnitMultiplier { get; set; } // 0x0000000187255A80-0x0000000187255A90 0x000000018D59578C-0x000000018D5957B0
		public float pixelsPerUnit { get; } // 0x00000001850D5B00-0x00000001850D6A10 
		protected float multipliedPixelsPerUnit { get; } // 0x00000001856BFCF0-0x00000001856BFD10 
		public override Material material { get; set; } // 0x00000001852E3940-0x00000001852E3BF0 0x00000001863388C0-0x00000001863388D0
		public virtual float minWidth { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual float preferredWidth { get; } // 0x00000001856C1A00-0x00000001856C1C60 
		public virtual float flexibleWidth { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float minHeight { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual float preferredHeight { get; } // 0x00000001856C1DE0-0x00000001856C1F50 
		public virtual float flexibleHeight { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual int layoutPriority { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public EDynamicAtlasActiveMode DynamicAtlasActiveMode { get; } // 0x0000000187262630-0x0000000187262640 
	
		// Nested types
		public enum Type // TypeDefIndex: 83658
		{
			Simple = 0,
			Sliced = 1,
			Tiled = 2,
			Filled = 3,
			Mirror = 4,
			Quarter = 5
		}
	
		public enum FillMethod // TypeDefIndex: 83659
		{
			Horizontal = 0,
			Vertical = 1,
			Radial90 = 2,
			Radial180 = 3,
			Radial360 = 4
		}
	
		public enum OriginHorizontal // TypeDefIndex: 83660
		{
			Left = 0,
			Right = 1
		}
	
		public enum OriginVertical // TypeDefIndex: 83661
		{
			Bottom = 0,
			Top = 1
		}
	
		public enum Origin90 // TypeDefIndex: 83662
		{
			BottomLeft = 0,
			TopLeft = 1,
			TopRight = 2,
			BottomRight = 3
		}
	
		public enum Origin180 // TypeDefIndex: 83663
		{
			Bottom = 0,
			Left = 1,
			Top = 2,
			Right = 3
		}
	
		public enum Origin360 // TypeDefIndex: 83664
		{
			Bottom = 0,
			Right = 1,
			Top = 2,
			Left = 3
		}
	
		public struct SlicedSpriteParams // TypeDefIndex: 83665
		{
			// Fields
			public bool slicedParamNeedUpdate; // 0x00
			public Vector2 inner_PosMin; // 0x04
			public Vector2 inner_PosMax; // 0x0C
			public Vector2 inner_UVMin; // 0x14
			public Vector2 inner_UVMax; // 0x1C
	
			// Constructors
			public SlicedSpriteParams(bool slicedParamNeedUpdate, Vector2 inner_PosMin, Vector2 inner_PosMax, Vector2 inner_UVMin, Vector2 inner_UVMax); // 0x0000000187263E30-0x0000000187263E60
		}
	
		public enum EDynamicAtlasActiveMode : byte // TypeDefIndex: 83666
		{
			ActiveOnAwake = 0,
			ActiveOnEnable = 1
		}
	
		// Constructors
		protected Image(); // 0x000000018548F600-0x000000018548F840
		static Image(); // 0x0000000186D31DC0-0x0000000186D32100
	
		// Methods
		public virtual void ReleaseSprite(); // 0x00000001868AB050-0x00000001868AB0D0
		protected virtual void _OnSpriteChanged(Sprite oldOne); // 0x0000000185BF10B0-0x0000000185BF12E0
		public void DisableSpriteOptimizations(); // 0x0000000187262620-0x0000000187262630
		public virtual void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnAfterDeserialize(); // 0x0000000185E056D0-0x0000000185E05750
		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize); // 0x000000018D594BE8-0x000000018D594CD0
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect); // 0x00000001856BEBB0-0x00000001856BEEA0
		public override void SetNativeSize(); // 0x000000018604E2E0-0x000000018604E510
		protected override void OnPopulateMesh(VertexHelper toFill); // 0x000000018564A890-0x000000018564AA80
		private void TrackSprite(); // 0x00000001851009E0-0x0000000185100C40
		protected override void OnEnable(); // 0x00000001851003B0-0x00000001851009E0
		protected override void OnDisable(); // 0x00000001852ED280-0x00000001852ED2F0
		protected override void Awake(); // 0x0000000185BF1670-0x0000000185BF19E0
		protected override void OnDestroy(); // 0x00000001852E4990-0x00000001852E4AD0
		protected override void UpdateMaterial(); // 0x00000001852E30C0-0x00000001852E3500
		protected override void OnCanvasHierarchyChanged(); // 0x00000001850D3B50-0x00000001850D3E90
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect); // 0x00000001856BE660-0x00000001856BEA90
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect); // 0x000000018D594260-0x000000018D5946E4
		private void GenerateSlicedSprite(VertexHelper toFill); // 0x00000001856BF300-0x00000001856BFCA0
		private void GenerateTiledSprite(VertexHelper toFill); // 0x00000001856988C0-0x00000001856999E0
		private void GenerateMirrorSprite(VertexHelper toFill); // 0x000000018D593CF8-0x000000018D594260
		private void GenerateMirrorQuarter(VertexHelper toFill); // 0x000000018D593364-0x000000018D593CF8
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs); // 0x000000018D5920A8-0x000000018D5921D8
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax); // 0x000000018564DF70-0x0000000185650060
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect); // 0x00000001856BDF30-0x00000001856BE150
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect); // 0x000000018D5921D8-0x000000018D593364
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner); // 0x000000018D594CD0-0x000000018D594E04
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner); // 0x000000018D594E04-0x000000018D5951E0
		public virtual void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera); // 0x0000000185320130-0x0000000185320440
		private Vector2 MapCoordinate(Vector2 local, Rect rect); // 0x0000000186A519C0-0x0000000186A51A60
		private static void RebuildImage(SpriteAtlas spriteAtlas); // 0x000000018D5951E0-0x000000018D595368
		private static void TrackImage(Image g); // 0x000000018D595368-0x000000018D595468
		private static void UnTrackImage(Image g); // 0x000000018D595468-0x000000018D5954D8
		protected override void OnDidApplyAnimationProperties(); // 0x00000001859E4E40-0x00000001859E5A40
		private Vector4 GetRuntimeAtlasSpritePadding(); // 0x000000018D594B4C-0x000000018D594BE8
		private Vector4 GetRuntimeAtlasSpriteOuterUV(); // 0x000000018D594A3C-0x000000018D594B4C
		private Vector4 GetRuntimeAtlasSpriteInnerUV(); // 0x000000018D594810-0x000000018D594A3C
		public string GetParticlePath(); // 0x000000018D5946E4-0x000000018D594810
		public void RegisterDynamicAtlas(); // 0x0000000185BF19E0-0x0000000185BF1CF0
		public void UnRegisterDynamicAtlas(Sprite _sprite); // 0x00000001852E4860-0x00000001852E4990
		public void RegisterDynamicAtlasCallBack(Action cb); // 0x000000018527E920-0x000000018527EA00
		public void UnRegisterDynamicAtlasCallBack(Action cb); // 0x000000018527F710-0x000000018527F790
		private static void _CanvasRreWillRenderCanvases(); // 0x00000001852E3DE0-0x00000001852E4820
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Not supported anymore.", true)]
	public interface IMask // TypeDefIndex: 83668
	{
		// Properties
		RectTransform rectTransform { get; }
	
		// Methods
		bool Enabled();
	}

	public interface IMaskable // TypeDefIndex: 83669
	{
		// Methods
		void RecalculateMasking();
	}

	public class InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 83681
	{
		// Fields
		protected TouchScreenKeyboard m_Keyboard; // 0x190
		private static readonly char[] kSeparators; // 0x00
		private static bool s_IsQuestDevice; // 0x08
		[FormerlySerializedAs("text")]
		[SerializeField]
		protected Text m_TextComponent; // 0x198
		[SerializeField]
		protected Graphic m_Placeholder; // 0x1A0
		[SerializeField]
		private ContentType m_ContentType; // 0x1A8
		[FormerlySerializedAs("inputType")]
		[SerializeField]
		private InputType m_InputType; // 0x1AC
		[FormerlySerializedAs("asteriskChar")]
		[SerializeField]
		private char m_AsteriskChar; // 0x1B0
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType; // 0x1B4
		[SerializeField]
		private LineType m_LineType; // 0x1B8
		[FormerlySerializedAs("hideMobileInput")]
		[SerializeField]
		private bool m_HideMobileInput; // 0x1BC
		[FormerlySerializedAs("validation")]
		[SerializeField]
		private CharacterValidation m_CharacterValidation; // 0x1C0
		[FormerlySerializedAs("characterLimit")]
		[SerializeField]
		private int m_CharacterLimit; // 0x1C4
		[FormerlySerializedAs("m_OnEndEdit")]
		[FormerlySerializedAs("m_OnSubmit")]
		[FormerlySerializedAs("onSubmit")]
		[FormerlySerializedAs("m_EndEdit")]
		[SerializeField]
		private SubmitEvent m_OnSubmit; // 0x1C8
		[SerializeField]
		private EndEditEvent m_OnDidEndEdit; // 0x1D0
		[FormerlySerializedAs("m_OnValueChange")]
		[FormerlySerializedAs("onValueChange")]
		[SerializeField]
		private OnChangeEvent m_OnValueChanged; // 0x1D8
		[FormerlySerializedAs("onValidateInput")]
		[SerializeField]
		private OnValidateInput m_OnValidateInput; // 0x1E0
		[FormerlySerializedAs("selectionColor")]
		[SerializeField]
		private UnityEngine.Color m_CaretColor; // 0x1E8
		[SerializeField]
		private bool m_CustomCaretColor; // 0x1F8
		[SerializeField]
		private UnityEngine.Color m_SelectionColor; // 0x1FC
		[FormerlySerializedAs("mValue")]
		[Multiline]
		[SerializeField]
		protected string m_Text; // 0x210
		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate; // 0x218
		[Range(1f, 5f)]
		[SerializeField]
		private int m_CaretWidth; // 0x21C
		[SerializeField]
		private bool m_ReadOnly; // 0x220
		[SerializeField]
		private bool m_ShouldActivateOnSelect; // 0x221
		protected int m_CaretPosition; // 0x224
		protected int m_CaretSelectPosition; // 0x228
		private RectTransform caretRectTrans; // 0x230
		protected UIVertex[] m_CursorVerts; // 0x238
		private TextGenerator m_InputTextCache; // 0x240
		private CanvasRenderer m_CachedInputRenderer; // 0x248
		private bool m_PreventFontCallback; // 0x250
		[NonSerialized]
		protected Mesh m_Mesh; // 0x258
		private bool m_AllowInput; // 0x260
		private bool m_ShouldActivateNextUpdate; // 0x261
		private bool m_UpdateDrag; // 0x262
		private bool m_DragPositionOutOfBounds; // 0x263
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x02643B83
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x02643B87
		protected bool m_CaretVisible; // 0x264
		private Coroutine m_BlinkCoroutine; // 0x268
		private float m_BlinkStartTime; // 0x270
		protected int m_DrawStart; // 0x274
		protected int m_DrawEnd; // 0x278
		private Coroutine m_DragCoroutine; // 0x280
		private string m_OriginalText; // 0x288
		private bool m_WasCanceled; // 0x290
		private bool m_HasDoneFocusTransition; // 0x291
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x298
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x2A0
		private bool m_IsCompositionActive; // 0x2A1
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x02643B8B
		private const string kOculusQuestDeviceModel = "Oculus Quest"; // Metadata: 0x02643B9F
		private UnityEngine.Event m_ProcessingEvent; // 0x2A8
		private const int k_MaxTextLength = 16382; // Metadata: 0x02643BAC
	
		// Properties
		private BaseInput input { get; } // 0x000000018D69B688-0x000000018D69B758 
		private string compositionString { get; } // 0x000000018D69B5CC-0x000000018D69B658 
		protected Mesh mesh { get; } // 0x000000018D69B758-0x000000018D69B7FC 
		protected TextGenerator cachedInputTextGenerator { get; } // 0x000000018D69B4A8-0x000000018D69B524 
		public bool shouldHideMobileInput { get; set; } // 0x000000018D69BB24-0x000000018D69BB54 0x000000018D69C230-0x000000018D69C27C
		public virtual bool shouldActivateOnSelect { get; set; } // 0x000000018D69BB00-0x000000018D69BB24 0x0000000187262D70-0x0000000187262D80
		public string text { get; set; } // 0x0000000187234930-0x0000000187234940 0x000000018D69C538-0x000000018D69C544
		public bool isFocused { get; } // 0x0000000187250180-0x0000000187250190 
		public float caretBlinkRate { get; set; } // 0x00000001872500C0-0x00000001872500D0 0x000000018D69BBB0-0x000000018D69BC18
		public int caretWidth { get; set; } // 0x0000000187258080-0x0000000187258090 0x000000018D69BCB8-0x000000018D69BD14
		public Text textComponent { get; set; } // 0x000000018723C220-0x000000018723C230 0x000000018D69C27C-0x000000018D69C538
		public Graphic placeholder { get; set; } // 0x000000018723BE20-0x000000018723BE30 0x000000018D69C10C-0x000000018D69C158
		public UnityEngine.Color caretColor { get; set; } // 0x000000018D69B524-0x000000018D69B574 0x000000018D69BC18-0x000000018D69BC58
		public bool customCaretColor { get; set; } // 0x0000000187263DF0-0x0000000187263E00 0x000000018D69BE60-0x000000018D69BE78
		public UnityEngine.Color selectionColor { get; set; } // 0x0000000187263E10-0x0000000187263E20 0x000000018D69C1A4-0x000000018D69C1E4
		public EndEditEvent onEndEdit { get; set; } // 0x000000018723BC70-0x000000018723BC80 0x000000018D69BFD4-0x000000018D69C020
		public SubmitEvent onSubmit { get; set; } // 0x000000018723BC50-0x000000018723BC60 0x000000018D69C020-0x000000018D69C06C
		[Obsolete("onValueChange has been renamed to onValueChanged")]
		public OnChangeEvent onValueChange { get; set; } // 0x000000018723BCA0-0x000000018723BCB0 0x000000018D69C0B8-0x000000018D69C0C0
		public OnChangeEvent onValueChanged { get; set; } // 0x000000018723BCA0-0x000000018723BCB0 0x000000018D69C0C0-0x000000018D69C10C
		public OnValidateInput onValidateInput { get; set; } // 0x000000018723BD70-0x000000018723BD80 0x000000018D69C06C-0x000000018D69C0B8
		public int characterLimit { get; set; } // 0x0000000187263DE0-0x0000000187263DF0 0x000000018D69BD14-0x000000018D69BDA8
		public ContentType contentType { get; set; } // 0x000000018723E060-0x000000018723E070 0x000000018D69BE04-0x000000018D69BE60
		public LineType lineType { get; set; } // 0x000000018723C5D0-0x000000018723C5E0 0x000000018D69BF30-0x000000018D69BFD4
		public InputType inputType { get; set; } // 0x0000000187263E00-0x0000000187263E10 0x000000018D69BE78-0x000000018D69BED4
		public TouchScreenKeyboard touchScreenKeyboard { get; } // 0x000000018723C0A0-0x000000018723C0B0 
		public TouchScreenKeyboardType keyboardType { get; set; } // 0x0000000187258C60-0x0000000187258C70 0x000000018D69BED4-0x000000018D69BF30
		public CharacterValidation characterValidation { get; set; } // 0x000000018723E870-0x000000018723E880 0x000000018D69BDA8-0x000000018D69BE04
		public bool readOnly { get; set; } // 0x0000000187262D60-0x0000000187262D70 0x0000000187262D80-0x0000000187262D90
		public bool multiLine { get; } // 0x000000018D69B7FC-0x000000018D69B814 
		public char asteriskChar { get; set; } // 0x0000000187263DD0-0x0000000187263DE0 0x000000018D69BB54-0x000000018D69BBB0
		public bool wasCanceled { get; } // 0x0000000187263E20-0x0000000187263E30 
		protected int caretPositionInternal { get; set; } // 0x000000018D69B574-0x000000018D69B5A0 0x000000018D69BC58-0x000000018D69BC70
		protected int caretSelectPositionInternal { get; set; } // 0x000000018D69B5A0-0x000000018D69B5CC 0x000000018D69BCA0-0x000000018D69BCB8
		private new bool hasSelection { get; } // 0x000000018D69B658-0x000000018D69B688 
		public int caretPosition { get; set; } // 0x000000018D69B5A0-0x000000018D69B5CC 0x000000018D69BC70-0x000000018D69BCA0
		public int selectionAnchorPosition { get; set; } // 0x000000018D69B574-0x000000018D69B5A0 0x000000018D69C158-0x000000018D69C1A4
		public int selectionFocusPosition { get; set; } // 0x000000018D69B5A0-0x000000018D69B5CC 0x000000018D69C1E4-0x000000018D69C230
		private static string clipboard { get; set; } // 0x000000018D42EFF0-0x000000018D42EFF8 0x000000018D42F280-0x000000018D42F288
		public virtual float minWidth { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual float preferredWidth { get; } // 0x000000018D69B9A0-0x000000018D69BB00 
		public virtual float flexibleWidth { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float minHeight { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual float preferredHeight { get; } // 0x000000018D69B814-0x000000018D69B9A0 
		public virtual float flexibleHeight { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual int layoutPriority { get; } // 0x00000001872328C0-0x00000001872328D0 
		Transform ICanvasElement.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 83670
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
	
		public enum InputType // TypeDefIndex: 83671
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 83672
		{
			None = 0,
			Integer = 1,
			Decimal = 2,
			Alphanumeric = 3,
			Name = 4,
			EmailAddress = 5
		}
	
		public enum LineType // TypeDefIndex: 83673
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 83674; 0x00000001811DF7F0-0x00000001811DF810
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 83675
		{
			// Constructors
			public SubmitEvent(); // 0x000000018D69CB84-0x000000018D69CBC0
		}
	
		[Serializable]
		public class EndEditEvent : UnityEvent<string> // TypeDefIndex: 83676
		{
			// Constructors
			public EndEditEvent(); // 0x000000018D693844-0x000000018D693880
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 83677
		{
			// Constructors
			public OnChangeEvent(); // 0x000000018D69CAA8-0x000000018D69CAE4
		}
	
		protected enum EditState // TypeDefIndex: 83678
		{
			Continue = 0,
			Finish = 1
		}
	
		[CompilerGenerated]
		private sealed class _CaretBlink_d__169 : IEnumerator<object> // TypeDefIndex: 83679
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public InputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _CaretBlink_d__169(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D69CBC0-0x000000018D69CCF0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D69CCF0-0x000000018D69CD3C
		}
	
		[CompilerGenerated]
		private sealed class _MouseDragOutsideRect_d__191 : IEnumerator<object> // TypeDefIndex: 83680
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PointerEventData eventData; // 0x20
			public InputField __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _MouseDragOutsideRect_d__191(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D69CD88-0x000000018D69D01C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D69D01C-0x000000018D69D160
		}
	
		// Constructors
		protected InputField(); // 0x000000018D69B2B4-0x000000018D69B4A8
		static InputField(); // 0x000000018D69B218-0x000000018D69B2B4
	
		// Methods
		public void SetTextWithoutNotify(string input); // 0x000000018D699D94-0x000000018D699DA0
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x02643B82 */); // 0x000000018D699DA0-0x000000018D69A114
		protected void ClampPos(ref int pos); // 0x000000018D694B6C-0x000000018D694BA4
		protected override void OnEnable(); // 0x000000018D698A18-0x000000018D698C88
		protected override void OnDisable(); // 0x000000018D69860C-0x000000018D69885C
		[IteratorStateMachine(typeof(_CaretBlink_d__169))]
		private IEnumerator CaretBlink(); // 0x000000018D694B10-0x000000018D694B6C
		private void SetCaretVisible(); // 0x000000018D69978C-0x000000018D6997CC
		private void SetCaretActive(); // 0x000000018D699724-0x000000018D69978C
		private void UpdateCaretMaterial(); // 0x000000018D69A28C-0x000000018D69A370
		protected void OnFocus(); // 0x000000018D698E34-0x000000018D698E3C
		protected void SelectAll(); // 0x000000018D69957C-0x000000018D6995B4
		public void MoveTextEnd(bool shift); // 0x000000018D698450-0x000000018D6984A4
		public void MoveTextStart(bool shift); // 0x000000018D6984A4-0x000000018D6984E4
		private bool TouchScreenKeyboardShouldBeUsed(); // 0x000000018D69A17C-0x000000018D69A1DC
		private bool InPlaceEditing(); // 0x000000018D696928-0x000000018D69694C
		private bool InPlaceEditingChanged(); // 0x000000018D6968CC-0x000000018D696928
		private void UpdateCaretFromKeyboard(); // 0x000000018D69A1DC-0x000000018D69A28C
		protected virtual void LateUpdate(); // 0x000000018D696EF4-0x000000018D697CA0
		[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
		public Vector2 ScreenToLocal(Vector2 screen); // 0x000000018D6992A8-0x000000018D69957C
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator); // 0x000000018D696768-0x000000018D6968CC
		protected int GetCharacterIndexFromPosition(Vector2 pos); // 0x000000018D696380-0x000000018D696578
		private bool MayDrag(PointerEventData eventData); // 0x000000018D6980E4-0x000000018D698190
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018D6985C0-0x000000018D6985E4
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018D69885C-0x000000018D698A18
		[IteratorStateMachine(typeof(_MouseDragOutsideRect_d__191))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData); // 0x000000018D698190-0x000000018D698208
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018D698C88-0x000000018D698CAC
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018D698E64-0x000000018D699058
		protected EditState KeyPressed(UnityEngine.Event evt); // 0x000000018D696B20-0x000000018D696EF4
		private bool IsValidChar(char c); // 0x000000018D696AC0-0x000000018D696B20
		public void ProcessEvent(UnityEngine.Event e); // 0x000000018D699290-0x000000018D699298
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x000000018D6990D8-0x000000018D699290
		private string GetSelectedString(); // 0x000000018D6966DC-0x000000018D696768
		private int FindtNextWordBegin(); // 0x000000018D6952FC-0x000000018D6953B8
		private void MoveRight(bool shift, bool ctrl); // 0x000000018D6983A4-0x000000018D698450
		private int FindtPrevWordBegin(); // 0x000000018D6953B8-0x000000018D69546C
		private void MoveLeft(bool shift, bool ctrl); // 0x000000018D6982F8-0x000000018D6983A4
		private int DetermineCharacterLine(int charPos, TextGenerator generator); // 0x000000018D695078-0x000000018D695114
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x000000018D697E90-0x000000018D698098
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar); // 0x000000018D697CA0-0x000000018D697E90
		private void MoveDown(bool shift); // 0x000000018D6982EC-0x000000018D6982F8
		private void MoveDown(bool shift, bool goToLastChar); // 0x000000018D698208-0x000000018D6982EC
		private void MoveUp(bool shift); // 0x000000018D6984E4-0x000000018D6984F0
		private void MoveUp(bool shift, bool goToFirstChar); // 0x000000018D6984F0-0x000000018D6985C0
		private void Delete(); // 0x000000018D694EA0-0x000000018D695078
		private void ForwardSpace(); // 0x000000018D695474-0x000000018D695510
		private void Backspace(); // 0x000000018D694A30-0x000000018D694B10
		private void Insert(char c); // 0x000000018D69694C-0x000000018D696A54
		private void UpdateTouchKeyboardFromEditChanges(); // 0x000000018D69AB94-0x000000018D69ABDC
		private void SendOnValueChangedAndUpdateLabel(); // 0x000000018D699694-0x000000018D6996B4
		private void SendOnValueChanged(); // 0x000000018D6996B4-0x000000018D699724
		protected void SendOnEndEdit(); // 0x000000018D6995B4-0x000000018D699624
		protected void SendOnSubmit(); // 0x000000018D699624-0x000000018D699694
		protected virtual void Append(string input); // 0x000000018D694298-0x000000018D694320
		protected virtual void Append(char input); // 0x000000018D694018-0x000000018D694298
		protected void UpdateLabel(); // 0x000000018D69A75C-0x000000018D69AB94
		private bool IsSelectionVisible(); // 0x000000018D696A54-0x000000018D696AC0
		private static int GetLineStartPosition(TextGenerator gen, int line); // 0x000000018D696634-0x000000018D6966DC
		private static int GetLineEndPosition(TextGenerator gen, int line); // 0x000000018D696578-0x000000018D696634
		private void SetDrawRangeToContainCaretPosition(int caretPos); // 0x000000018D6997CC-0x000000018D699D94
		public void ForceLabelUpdate(); // 0x000000018D69546C-0x000000018D695474
		private void MarkGeometryAsDirty(); // 0x000000018D698098-0x000000018D6980E4
		public virtual void Rebuild(CanvasUpdate update); // 0x000000018D699298-0x000000018D6992A8
		public virtual void LayoutComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void GraphicUpdateComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		private void UpdateGeometry(); // 0x000000018D69A370-0x000000018D69A75C
		private void AssignPositioningIfNeeded(); // 0x000000018D694320-0x000000018D694A30
		private void OnFillVBO(Mesh vbo); // 0x000000018D698CAC-0x000000018D698E34
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset); // 0x000000018D695510-0x000000018D695BC8
		private void CreateCursorVerts(); // 0x000000018D694BA4-0x000000018D694D0C
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset); // 0x000000018D695BC8-0x000000018D696380
		protected char Validate(string text, int pos, char ch); // 0x000000018D69ABDC-0x000000018D69B218
		public void ActivateInputField(); // 0x000000018D693F00-0x000000018D694018
		private void ActivateInputFieldInternal(); // 0x000000018D693C08-0x000000018D693F00
		public override void OnSelect(BaseEventData eventData); // 0x000000018D699058-0x000000018D699094
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018D698E3C-0x000000018D698E64
		public void DeactivateInputField(); // 0x000000018D694D0C-0x000000018D694EA0
		public override void OnDeselect(BaseEventData eventData); // 0x000000018D6985E4-0x000000018D69860C
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018D699094-0x000000018D6990D8
		private void EnforceContentType(); // 0x000000018D695138-0x000000018D695268
		private void EnforceTextHOverflow(); // 0x000000018D695268-0x000000018D6952FC
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes); // 0x000000018D69A114-0x000000018D69A164
		private void SetToCustom(); // 0x000000018D69A164-0x000000018D69A17C
		protected override void DoStateTransition(SelectionState state, bool instant); // 0x000000018D695114-0x000000018D695138
		public virtual void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController // TypeDefIndex: 83683
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
		public AspectMode aspectMode { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018D6936C8-0x000000018D693720
		public float aspectRatio { get; set; } // 0x0000000187233410-0x0000000187233420 0x00000001851AC110-0x00000001851AC170
		private RectTransform rectTransform { get; } // 0x00000001851AC780-0x00000001851AC820 
	
		// Nested types
		public enum AspectMode // TypeDefIndex: 83682
		{
			None = 0,
			WidthControlsHeight = 1,
			HeightControlsWidth = 2,
			FitInParent = 3,
			EnvelopeParent = 4
		}
	
		// Constructors
		protected AspectRatioFitter(); // 0x0000000186BDEC50-0x0000000186BDEC80
	
		// Methods
		protected override void OnEnable(); // 0x00000001851AC1B0-0x00000001851AC240
		protected override void Start(); // 0x00000001851AC170-0x00000001851AC1A0
		protected override void OnDisable(); // 0x00000001851AC240-0x00000001851AC280
		protected override void OnTransformParentChanged(); // 0x000000018D693648-0x000000018D6936C8
		protected virtual void Update(); // 0x000000018676B440-0x000000018676B460
		protected override void OnRectTransformDimensionsChange(); // 0x00000001851AC450-0x00000001851AC460
		private void UpdateRect(); // 0x00000001851AC460-0x00000001851AC780
		private float GetSizeDeltaToProduceSize(float size, int axis); // 0x00000001851AC280-0x00000001851AC380
		private Vector2 GetParentSize(); // 0x00000001851AC380-0x00000001851AC450
		public virtual void SetLayoutHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void SetLayoutVertical(); // 0x0000000186805BA0-0x0000000186805BB0
		protected void SetDirty(); // 0x00000001851AC450-0x00000001851AC460
		public bool IsComponentValidOnObject(); // 0x00000001851AC820-0x00000001851AC880
		public bool IsAspectModeValid(); // 0x00000001851AC1A0-0x00000001851AC1B0
		private bool DoesParentExists(); // 0x000000018225E0D0-0x000000018225E0E0
	}

	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(Canvas))]
	public class CanvasScaler : UIBehaviour // TypeDefIndex: 83687
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
		private const float kLogBase = 2f; // Metadata: 0x02643BCD
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
		public ScaleMode uiScaleMode { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
		public float referencePixelsPerUnit { get; set; } // 0x0000000187233410-0x0000000187233420 0x0000000187233420-0x0000000187233430
		public float scaleFactor { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x000000018D6937D8-0x000000018D6937EC
		public Vector2 referenceResolution { get; set; } // 0x0000000187235030-0x0000000187235050 0x0000000185195190-0x00000001851951E0
		public ScreenMatchMode screenMatchMode { get; set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public float matchWidthOrHeight { get; set; } // 0x0000000187233870-0x0000000187233880 0x0000000187233880-0x0000000187233890
		public Unit physicalUnit { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x0000000182271AA0-0x0000000182271AB0
		public float fallbackScreenDPI { get; set; } // 0x0000000187235380-0x0000000187235390 0x0000000187235390-0x00000001872353A0
		public float defaultSpriteDPI { get; set; } // 0x00000001872330B0-0x00000001872330C0 0x000000018D6937C4-0x000000018D6937D8
		public float dynamicPixelsPerUnit { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
	
		// Nested types
		public enum ScaleMode // TypeDefIndex: 83684
		{
			ConstantPixelSize = 0,
			ScaleWithScreenSize = 1,
			ConstantPhysicalSize = 2
		}
	
		public enum ScreenMatchMode // TypeDefIndex: 83685
		{
			MatchWidthOrHeight = 0,
			Expand = 1,
			Shrink = 2
		}
	
		public enum Unit // TypeDefIndex: 83686
		{
			Centimeters = 0,
			Millimeters = 1,
			Inches = 2,
			Points = 3,
			Picas = 4
		}
	
		// Constructors
		protected CanvasScaler(); // 0x0000000185491380-0x00000001854913F0
	
		// Methods
		protected override void OnEnable(); // 0x000000018527B950-0x000000018527B9D0
		private void Canvas_preWillRenderCanvases(); // 0x00000001850BDB50-0x00000001850BDCF0
		protected override void OnDisable(); // 0x000000018527B840-0x000000018527B8C0
		public void HandleManually(); // 0x0000000185195B80-0x0000000185195C20
		protected virtual void Handle(); // 0x00000001850BDCF0-0x00000001850BDE90
		protected virtual void HandleWorldCanvas(); // 0x00000001860A2100-0x00000001860A2160
		protected virtual void HandleConstantPixelSize(); // 0x00000001867639A0-0x00000001867639D0
		protected virtual void HandleScaleWithScreenSize(); // 0x00000001850BE130-0x00000001850BE4C0
		protected virtual void HandleConstantPhysicalSize(); // 0x000000018D693720-0x000000018D6937C4
		protected void SetScaleFactor(float scaleFactor); // 0x00000001850BEEC0-0x00000001850BEF10
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit); // 0x00000001850BEE90-0x00000001850BEEC0
	}

	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController // TypeDefIndex: 83689
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
		public FitMode horizontalFit { get; set; } // 0x00000001844AF510-0x00000001844AF520 0x00000001861230C0-0x0000000186123120
		public FitMode verticalFit { get; set; } // 0x0000000187233000-0x0000000187233010 0x000000018D6937EC-0x000000018D693844
		private RectTransform rectTransform { get; } // 0x00000001851AC780-0x00000001851AC820 
	
		// Nested types
		public enum FitMode // TypeDefIndex: 83688
		{
			Unconstrained = 0,
			MinSize = 1,
			PreferredSize = 2
		}
	
		// Constructors
		protected ContentSizeFitter(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		protected override void OnEnable(); // 0x0000000186123120-0x0000000186123170
		protected override void OnDisable(); // 0x00000001851AC240-0x00000001851AC280
		protected override void OnRectTransformDimensionsChange(); // 0x0000000186123120-0x0000000186123170
		private void HandleSelfFittingAlongAxis(int axis); // 0x00000001856A53C0-0x00000001856A55C0
		public virtual void SetLayoutHorizontal(); // 0x00000001856A55C0-0x00000001856A55D0
		public virtual void SetLayoutVertical(); // 0x00000001878371E4-0x00000001878371F4
		protected void SetDirty(); // 0x0000000186123120-0x0000000186123170
	}

	[AddComponentMenu("Layout/Grid Layout Group", 152)]
	public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 83693
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
		public Corner startCorner { get; set; } // 0x00000001872331A0-0x00000001872331B0 0x000000018D6939DC-0x000000018D693A28
		public Axis startAxis { get; set; } // 0x0000000187233600-0x0000000187233610 0x000000018D693990-0x000000018D6939DC
		public Vector2 cellSize { get; set; } // 0x000000018723B3E0-0x000000018723B400 0x000000018D69389C-0x000000018D6938F0
		public Vector2 spacing { get; set; } // 0x0000000187263DB0-0x0000000187263DD0 0x000000018D69393C-0x000000018D693990
		public Constraint constraint { get; set; } // 0x0000000187233370-0x0000000187233380 0x000000018D6938F0-0x000000018D69393C
		public int constraintCount { get; set; } // 0x0000000187233390-0x00000001872333A0 0x0000000187077D20-0x0000000187077D80
	
		// Nested types
		public enum Corner // TypeDefIndex: 83690
		{
			UpperLeft = 0,
			UpperRight = 1,
			LowerLeft = 2,
			LowerRight = 3
		}
	
		public enum Axis // TypeDefIndex: 83691
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		public enum Constraint // TypeDefIndex: 83692
		{
			Flexible = 0,
			FixedColumnCount = 1,
			FixedRowCount = 2
		}
	
		// Constructors
		protected GridLayoutGroup(); // 0x0000000186A87930-0x0000000186A87960
	
		// Methods
		public override void CalculateLayoutInputHorizontal(); // 0x000000018569CCB0-0x000000018569CDF0
		public override void CalculateLayoutInputVertical(); // 0x0000000185BA82F0-0x0000000185BA8470
		public override void SetLayoutHorizontal(); // 0x000000018D693880-0x000000018D69388C
		public override void SetLayoutVertical(); // 0x000000018D69388C-0x000000018D69389C
		private void SetCellsAlongAxis(int axis); // 0x0000000185BA84A0-0x0000000185BA89A0
	}

	[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 83694
	{
		// Constructors
		protected HorizontalLayoutGroup(); // 0x00000001862A52E0-0x00000001862A5400
	
		// Methods
		public override void CalculateLayoutInputHorizontal(); // 0x000000018569F5E0-0x000000018569F610
		public override void CalculateLayoutInputVertical(); // 0x0000000187839AB4-0x0000000187839AC4
		public override void SetLayoutHorizontal(); // 0x0000000187837244-0x0000000187837254
		public override void SetLayoutVertical(); // 0x0000000187837234-0x0000000187837244
	}

	[ExecuteAlways]
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 83695
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
		public float spacing { get; set; } // 0x00000001872353B0-0x00000001872353C0 0x0000000186CA4360-0x0000000186CA43B0
		public bool childForceExpandWidth { get; set; } // 0x000000018225DF90-0x000000018225DFA0 0x000000018675E730-0x000000018675E780
		public bool childForceExpandHeight { get; set; } // 0x0000000187253800-0x0000000187253810 0x000000018D693AC8-0x000000018D693B18
		public bool childControlWidth { get; set; } // 0x0000000187253820-0x0000000187253830 0x000000018D693A78-0x000000018D693AC8
		public bool childControlHeight { get; set; } // 0x000000018723B7D0-0x000000018723B7E0 0x000000018D693A28-0x000000018D693A78
		public bool childScaleWidth { get; set; } // 0x000000018226ED60-0x000000018226ED70 0x000000018D693B68-0x000000018D693BB8
		public bool childScaleHeight { get; set; } // 0x00000001872361E0-0x00000001872361F0 0x000000018D693B18-0x000000018D693B68
		public bool reverseArrangement { get; set; } // 0x000000018723DD70-0x000000018723DD80 0x000000018D693BB8-0x000000018D693C08
	
		// Constructors
		protected HorizontalOrVerticalLayoutGroup(); // 0x00000001862A52D0-0x00000001862A52E0
	
		// Methods
		protected void CalcAlongAxis(int axis, bool isVertical); // 0x00000001856A2D10-0x00000001856A3770
		protected void SetChildrenAlongAxis(int axis, bool isVertical); // 0x00000001856A1A00-0x00000001856A2D10
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible); // 0x00000001856A3770-0x00000001856A3ED0
	}

	public interface ILayoutElement // TypeDefIndex: 83696
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

	public interface ILayoutController // TypeDefIndex: 83697
	{
		// Methods
		void SetLayoutHorizontal();
		void SetLayoutVertical();
	}

	public interface ILayoutGroup : ILayoutController // TypeDefIndex: 83698
	{
	}

	public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 83699
	{
	}

	public interface ILayoutIgnorer // TypeDefIndex: 83700
	{
		// Properties
		bool ignoreLayout { get; }
	}

	[AddComponentMenu("Layout/Layout Element", 140)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 83701
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
		public virtual bool ignoreLayout { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018513EBA0-0x000000018513ED30
		public virtual float minWidth { get; set; } // 0x0000000187233410-0x0000000187233420 0x000000018596EF80-0x000000018596EFE0
		public virtual float minHeight { get; set; } // 0x00000001872332C0-0x00000001872332D0 0x000000018596F020-0x000000018596F080
		public virtual float preferredWidth { get; set; } // 0x0000000187236710-0x0000000187236720 0x000000018596E610-0x000000018596E670
		public virtual float preferredHeight { get; set; } // 0x0000000187233430-0x0000000187233440 0x000000018596EE10-0x000000018596EE70
		public virtual float flexibleWidth { get; set; } // 0x0000000187233330-0x0000000187233340 0x0000000185C44B20-0x0000000185C44B80
		public virtual float flexibleHeight { get; set; } // 0x0000000187233870-0x0000000187233880 0x0000000186CE5650-0x0000000186CE56B0
		public virtual int layoutPriority { get; set; } // 0x0000000182271A70-0x0000000182271A80 0x000000018D69C544-0x000000018D69C59C
	
		// Constructors
		protected LayoutElement(); // 0x000000018548F150-0x000000018548F1B0
	
		// Methods
		public virtual void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnEnable(); // 0x000000018596EE80-0x000000018596EEF0
		protected override void OnTransformParentChanged(); // 0x000000018596EE70-0x000000018596EE80
		protected override void OnDisable(); // 0x000000018596EE80-0x000000018596EEF0
		protected override void OnDidApplyAnimationProperties(); // 0x000000018596EE70-0x000000018596EE80
		protected override void OnBeforeTransformParentChanged(); // 0x000000018596EE70-0x000000018596EE80
		protected void SetDirty(); // 0x000000018596EEF0-0x000000018596EF80
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup // TypeDefIndex: 83703
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
		public RectOffset padding { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018596F080-0x000000018596F0D0
		public TextAnchor childAlignment { get; set; } // 0x000000018226A850-0x000000018226A860 0x0000000186BD7BF0-0x0000000186BD7C40
		protected RectTransform rectTransform { get; } // 0x00000001856A0B40-0x00000001856A12B0 
		protected List<RectTransform> rectChildren { get; } // 0x000000018226EBD0-0x000000018226EBE0 
		public virtual float minWidth { get; } // 0x000000018783AB70-0x000000018783AB78 
		public virtual float preferredWidth { get; } // 0x0000000187837310-0x0000000187837318 
		public virtual float flexibleWidth { get; } // 0x0000000187837370-0x0000000187837380 
		public virtual float minHeight { get; } // 0x0000000187837390-0x0000000187837398 
		public virtual float preferredHeight { get; } // 0x0000000187837380-0x0000000187837390 
		public virtual float flexibleHeight { get; } // 0x0000000187837360-0x0000000187837370 
		public virtual int layoutPriority { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		private bool isRootLayoutGroup { get; } // 0x00000001855742F0-0x0000000185574500 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DelayedSetDirty_d__56 : IEnumerator<object> // TypeDefIndex: 83702
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RectTransform rectTransform; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedSetDirty_d__56(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001863EA8A0-0x00000001863EA920
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D69CD3C-0x000000018D69CD88
		}
	
		// Constructors
		protected LayoutGroup(); // 0x000000018548E240-0x000000018548E350
	
		// Methods
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001856A0350-0x00000001856A0B40
		public abstract void CalculateLayoutInputVertical();
		public abstract void SetLayoutHorizontal();
		public abstract void SetLayoutVertical();
		protected override void OnEnable(); // 0x0000000185573F80-0x0000000185574020
		protected override void OnDisable(); // 0x00000001862DA5F0-0x00000001862DA630
		protected override void OnDidApplyAnimationProperties(); // 0x0000000185573F70-0x0000000185573F80
		protected float GetTotalMinSize(int axis); // 0x00000001878371AC-0x00000001878371B8
		protected float GetTotalPreferredSize(int axis); // 0x00000001878371B8-0x00000001878371C4
		protected float GetTotalFlexibleSize(int axis); // 0x000000018D69C59C-0x000000018D69C5A8
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding); // 0x00000001856A0190-0x00000001856A0350
		protected float GetAlignmentOnAxis(int axis); // 0x00000001856A0150-0x00000001856A0190
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis); // 0x00000001856A16F0-0x00000001856A1760
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos); // 0x000000018D69C5A8-0x000000018D69C640
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor); // 0x00000001856A1760-0x00000001856A1A00
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size); // 0x0000000185BA89A0-0x0000000185BA8A80
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor); // 0x00000001856A13F0-0x00000001856A16F0
		protected override void OnRectTransformDimensionsChange(); // 0x0000000185574020-0x00000001855742F0
		protected virtual void OnTransformChildrenChanged(); // 0x0000000185573F70-0x0000000185573F80
		protected void SetProperty<T>(ref ref T currentValue, T newValue);
		protected void SetDirty(); // 0x0000000185573F80-0x0000000185574020
		[IteratorStateMachine(typeof(_DelayedSetDirty_d__56))]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform); // 0x0000000185574590-0x00000001855745D0
	}

	public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 83705
	{
		// Fields
		private RectTransform m_ToRebuild; // 0x10
		private int m_CachedHashFromTransform; // 0x18
		private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x00
	
		// Properties
		public Transform transform { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83704
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<UnityEngine.Component> __9__10_0; // 0x08
			public static UnityAction<UnityEngine.Component> __9__12_0; // 0x10
			public static UnityAction<UnityEngine.Component> __9__12_1; // 0x18
			public static UnityAction<UnityEngine.Component> __9__12_2; // 0x20
			public static UnityAction<UnityEngine.Component> __9__12_3; // 0x28
	
			// Constructors
			static __c(); // 0x00000001871E7580-0x00000001871E75E0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal LayoutRebuilder _.cctor_b__5_0(); // 0x0000000186A68430-0x0000000186A68450
			internal void _.cctor_b__5_1(LayoutRebuilder x); // 0x0000000185FBE900-0x0000000185FBE980
			internal bool _StripDisabledBehavioursFromList_b__10_0(UnityEngine.Component e); // 0x00000001850D3A40-0x00000001850D3AE0
			internal void _Rebuild_b__12_0(UnityEngine.Component e); // 0x000000018569E9B0-0x000000018569F5E0
			internal void _Rebuild_b__12_1(UnityEngine.Component e); // 0x00000001856A5F80-0x00000001856A6B50
			internal void _Rebuild_b__12_2(UnityEngine.Component e); // 0x0000000185BA7E80-0x0000000185BA82F0
			internal void _Rebuild_b__12_3(UnityEngine.Component e); // 0x00000001856A5EF0-0x00000001856A5F80
		}
	
		// Constructors
		static LayoutRebuilder(); // 0x0000000186D45B10-0x0000000186D45D00
		public LayoutRebuilder(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private void Initialize(RectTransform controller); // 0x00000001851C5300-0x00000001851C53A0
		private void Clear(); // 0x000000018783B440-0x000000018783B460
		private static void ReapplyDrivenProperties(RectTransform driven); // 0x00000001851C5B50-0x00000001851C5B80
		public bool IsDestroyed(); // 0x0000000186233F80-0x0000000186233FF0
		private static void StripDisabledBehavioursFromList(List<UnityEngine.Component> components); // 0x00000001851C7880-0x00000001851C7970
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot); // 0x00000001851BF690-0x00000001851BF740
		public void Rebuild(CanvasUpdate executing); // 0x00000001851C13C0-0x00000001851C1720
		private void PerformLayoutControl(RectTransform rect, UnityAction<UnityEngine.Component> action); // 0x00000001851C53A0-0x00000001851C5AB0
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<UnityEngine.Component> action); // 0x00000001851C5C60-0x00000001851C6530
		public static void MarkLayoutForRebuild(RectTransform rect); // 0x00000001851C6910-0x00000001851C7420
		private static bool ValidController(RectTransform layoutRoot, List<UnityEngine.Component> comps); // 0x00000001851C79C0-0x00000001851C8200
		private static void MarkLayoutRootForRebuild(RectTransform controller); // 0x00000001851C5160-0x00000001851C5300
		public void LayoutComplete(); // 0x00000001851C0740-0x00000001851C0890
		public void GraphicUpdateComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		public override int GetHashCode(); // 0x00000001844AF510-0x00000001844AF520
		public override bool Equals(object obj); // 0x0000000185E06E70-0x0000000185E06EC0
		public override string ToString(); // 0x000000018D69C640-0x000000018D69C6A0
	}

	public static class LayoutUtility // TypeDefIndex: 83707
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83706
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
			static __c(); // 0x00000001871E7640-0x00000001871E76A0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _GetMinWidth_b__3_0(ILayoutElement e); // 0x0000000185DCE050-0x0000000185DCE070
			internal float _GetPreferredWidth_b__4_0(ILayoutElement e); // 0x0000000185DCE070-0x0000000185DCEF60
			internal float _GetPreferredWidth_b__4_1(ILayoutElement e); // 0x00000001856C08A0-0x00000001856C1A00
			internal float _GetFlexibleWidth_b__5_0(ILayoutElement e); // 0x00000001856C2640-0x00000001856C2CA0
			internal float _GetMinHeight_b__6_0(ILayoutElement e); // 0x00000001856C1F50-0x00000001856C25B0
			internal float _GetPreferredHeight_b__7_0(ILayoutElement e); // 0x00000001856C1F50-0x00000001856C25B0
			internal float _GetPreferredHeight_b__7_1(ILayoutElement e); // 0x00000001856C2CA0-0x00000001856C4ED0
			internal float _GetFlexibleHeight_b__8_0(ILayoutElement e); // 0x00000001856C25B0-0x00000001856C2640
		}
	
		// Methods
		public static float GetMinSize(RectTransform rect, int axis); // 0x00000001856A4070-0x00000001856A4210
		public static float GetPreferredSize(RectTransform rect, int axis); // 0x00000001856A4210-0x00000001856A4570
		public static float GetFlexibleSize(RectTransform rect, int axis); // 0x00000001856A3ED0-0x00000001856A4070
		public static float GetMinWidth(RectTransform rect); // 0x00000001856A49D0-0x00000001856A4AC0
		public static float GetPreferredWidth(RectTransform rect); // 0x00000001856A47F0-0x00000001856A49D0
		public static float GetFlexibleWidth(RectTransform rect); // 0x00000001856A4AC0-0x00000001856A4BB0
		public static float GetMinHeight(RectTransform rect); // 0x00000001856A4BB0-0x00000001856A4CA0
		public static float GetPreferredHeight(RectTransform rect); // 0x00000001856A4610-0x00000001856A47F0
		public static float GetFlexibleHeight(RectTransform rect); // 0x00000001856A4CA0-0x00000001856A4D90
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue); // 0x00000001878371C4-0x00000001878371E4
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source); // 0x00000001850D2AB0-0x00000001850D31D0
	}

	[AddComponentMenu("Layout/Vertical Layout Group", 151)]
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 83708
	{
		// Constructors
		protected VerticalLayoutGroup(); // 0x00000001862A52D0-0x00000001862A52E0
	
		// Methods
		public override void CalculateLayoutInputHorizontal(); // 0x000000018569E980-0x000000018569E9B0
		public override void CalculateLayoutInputVertical(); // 0x0000000187839AC4-0x0000000187839AD4
		public override void SetLayoutHorizontal(); // 0x00000001878371F4-0x0000000187837204
		public override void SetLayoutVertical(); // 0x0000000187837204-0x0000000187837214
	}

	[AddComponentMenu("UI/Mask", 13)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 83709
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
		public RectTransform rectTransform { get; } // 0x0000000185F2C820-0x0000000185F2C880 
		public bool showMaskGraphic { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x000000018D69C6A0-0x000000018D69C72C
		public Graphic graphic { get; } // 0x00000001852DF8A0-0x00000001852DF8E0 
	
		// Constructors
		protected Mask(); // 0x0000000185490190-0x00000001854901C0
	
		// Methods
		public virtual bool MaskEnabled(); // 0x00000001852DF320-0x00000001852DF3B0
		[Obsolete("Not used anymore.")]
		public virtual void OnSiblingGraphicEnabledDisabled(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnEnable(); // 0x00000001852DF550-0x00000001852DF6B0
		protected override void OnDisable(); // 0x00000001852DF6B0-0x00000001852DF8A0
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x0000000185F2C780-0x0000000185F2C820
		public virtual Material GetModifiedMaterial(Material baseMaterial); // 0x00000001852DF3B0-0x00000001852DF550
	}

	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 83711
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
		public CullStateChangedEvent onCullStateChanged { get; set; } // 0x0000000187234580-0x0000000187234590 0x0000000188A79A0C-0x0000000188A79A20
		public bool maskable { get; set; } // 0x000000018723B680-0x000000018723B690 0x000000018D69CA80-0x000000018D69CAA8
		public bool isMaskingGraphic { get; set; } // 0x000000018723FA10-0x000000018723FA20 0x00000001852DF960-0x00000001852DF970
		internal virtual bool hasCullOverride { get; } // 0x00000001851A4410-0x00000001851A4420 
		private Rect rootCanvasRect { get; } // 0x000000018D69C78C-0x000000018D69CA80 
		GameObject IClippable.gameObject { get; } // 0x0000000187834B68-0x0000000187834B70 
	
		// Nested types
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 83710
		{
			// Constructors
			public CullStateChangedEvent(); // 0x00000001878348A0-0x00000001878348AC
		}
	
		// Constructors
		protected MaskableGraphic(); // 0x000000018548F840-0x000000018548FA10
	
		// Methods
		internal void UpdateCullDirect(bool cull); // 0x0000000185044960-0x0000000185044A20
		public virtual Material GetModifiedMaterial(Material baseMaterial); // 0x00000001852E2A80-0x00000001852E30C0
		public virtual void Cull(Rect clipRect, bool validRect); // 0x000000018D69C72C-0x000000018D69C78C
		private void UpdateCull(bool cull); // 0x0000000185044B40-0x0000000185044CC0
		public virtual void SetClipRect(Rect clipRect, bool validRect); // 0x0000000185CEAD00-0x0000000185CEADB0
		public virtual void SetClipSoftness(Vector2 clipSoftness); // 0x0000000185149DA0-0x000000018514A520
		public virtual void SetHGClipSoftness(Vector4 hgClipSoftness); // 0x0000000185149640-0x0000000185149DA0
		protected override void OnEnable(); // 0x00000001850FEC20-0x00000001850FF200
		protected override void OnDisable(); // 0x00000001852ED2F0-0x00000001852EE240
		protected override void OnTransformParentChanged(); // 0x00000001861D2F00-0x00000001861D2FC0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore.", true)]
		public virtual void ParentMaskStateChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnCanvasHierarchyChanged(); // 0x0000000185B087C0-0x0000000185B089C0
		private void UpdateClipParent(); // 0x00000001850FF200-0x00000001850FF760
		public virtual void RecalculateClipping(); // 0x00000001851BFD90-0x00000001851BFDA0
		public virtual void RecalculateMasking(); // 0x00000001852ECF20-0x00000001852ED1E0
	}

	public class MaskUtilities // TypeDefIndex: 83712
	{
		// Constructors
		public MaskUtilities(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void Notify2DMaskStateChanged(UnityEngine.Component mask); // 0x00000001851BFA60-0x00000001851BFD90
		public static void NotifyStencilStateChanged(UnityEngine.Component mask); // 0x00000001851BF780-0x00000001851BFA60
		public static Transform FindRootSortOverrideCanvas(Transform start); // 0x00000001852E11F0-0x00000001852E16B0
		public static int GetStencilDepth(Transform transform, Transform stopAfter); // 0x00000001851C8200-0x00000001851C8810
		public static bool IsDescendantOrSelf(Transform father, Transform child); // 0x00000001851C6690-0x00000001851C6910
		public static RectMask2D GetRectMaskForClippable(IClippable clippable); // 0x00000001850FF760-0x00000001851003B0
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks); // 0x00000001852E05C0-0x00000001852E0930
	}

	public interface IMaterialModifier // TypeDefIndex: 83713
	{
		// Methods
		Material GetModifiedMaterial(Material baseMaterial);
	}

	internal static class Misc // TypeDefIndex: 83714
	{
		// Methods
		public static void Destroy(UnityEngine.Object obj); // 0x000000018D69D594-0x000000018D69D660
		public static void DestroyImmediate(UnityEngine.Object obj); // 0x00000001867FFBD0-0x00000001867FFC60
	}

	internal static class MultipleDisplayUtilities // TypeDefIndex: 83715
	{
		// Methods
		public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position); // 0x000000018D69D660-0x000000018D69D72C
		public static Vector3 RelativeMouseAtScaled(Vector2 position); // 0x00000001850F9390-0x00000001850F97E0
	}

	[Serializable]
	public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 83717
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
		public Mode mode { get; set; } // 0x00000001844AD290-0x00000001844AD2A0 0x0000000184547F40-0x0000000184547F50
		public bool wrapAround { get; set; } // 0x0000000187239BC0-0x0000000187239BD0 0x000000018723EA20-0x000000018723EA30
		public Selectable selectOnUp { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public Selectable selectOnDown { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public Selectable selectOnLeft { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public Selectable selectOnRight { get; set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public static Navigation defaultNavigation { get; } // 0x0000000187263E70-0x0000000187263E90 
	
		// Nested types
		[Flags]
		public enum Mode // TypeDefIndex: 83716
		{
			None = 0,
			Horizontal = 1,
			Vertical = 2,
			Automatic = 3,
			Explicit = 4
		}
	
		// Methods
		public bool Equals(Navigation other); // 0x00000001860B46E0-0x00000001860B4A50
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class RawImage : MaskableGraphic // TypeDefIndex: 83718
	{
		// Fields
		[FormerlySerializedAs("m_Tex")]
		[SerializeField]
		private Texture m_Texture; // 0xE8
		[SerializeField]
		private Rect m_UVRect; // 0xF0
	
		// Properties
		internal override bool hasCullOverride { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public override Texture mainTexture { get; } // 0x00000001863A4C60-0x00000001863A4E40 
		public Texture texture { get; set; } // 0x00000001872354B0-0x00000001872354C0 0x0000000185FCDDC0-0x0000000185FCDF70
		public Rect uvRect { get; set; } // 0x000000018724F4D0-0x000000018724F4E0 0x000000018D69D864-0x000000018D69D8C4
	
		// Constructors
		protected RawImage(); // 0x00000001854913F0-0x0000000185491420
	
		// Methods
		public override void SetNativeSize(); // 0x000000018D69D72C-0x000000018D69D864
		protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001856BE240-0x00000001856BE660
		protected override void OnDidApplyAnimationProperties(); // 0x0000000186538590-0x00000001865385C0
	}

	[AddComponentMenu("UI/Rect Mask 2D", 14)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 83719
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
		public Vector4 padding { get; set; } // 0x0000000187256820-0x0000000187256830 0x000000018D69E714-0x000000018D69E724
		public Vector2Int softness { get; set; } // 0x0000000187239E10-0x0000000187239E20 0x000000018D69E724-0x000000018D69E74C
		public Vector4 hgSoftness { get; set; } // 0x0000000187263E90-0x0000000187263EA0 0x000000018D69E6D4-0x000000018D69E714
		private Canvas Canvas { get; } // 0x0000000185B34180-0x0000000185B342E0 
		public Rect canvasRect { get; } // 0x000000018D69E3EC-0x000000018D69E468 
		public RectTransform rectTransform { get; } // 0x00000001853205B0-0x00000001853205F0 
		private Rect rootCanvasRect { get; } // 0x000000018D69E470-0x000000018D69E6D4 
		internal bool shouldRecalculateClipRects { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		internal List<RectMask2D> clippers { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		internal HashSet<MaskableGraphic> maskableTargets { get; } // 0x0000000182262130-0x0000000182262140 
		internal HashSet<IClippable> clipTargets { get; } // 0x00000001829600D0-0x00000001829600E0 
		internal Rect lastClipRectCanvasSpace { get; set; } // 0x000000018723DAF0-0x000000018723DB00 0x0000000187233C90-0x0000000187233CA0
		internal bool forceClip { get; set; } // 0x000000018226EBE0-0x000000018226EBF0 0x000000018226EBF0-0x000000018226EC00
		internal Canvas canvasRef { get; } // 0x000000018D69E468-0x000000018D69E470 
	
		// Constructors
		protected RectMask2D(); // 0x000000018548FBB0-0x000000018548FD10
	
		// Methods
		protected override void OnEnable(); // 0x00000001851BFDA0-0x00000001851BFDD0
		protected override void OnDisable(); // 0x00000001852E0520-0x00000001852E0590
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x0000000185320480-0x00000001853205B0
		public virtual void PerformClipping(); // 0x000000018D69DCF4-0x000000018D69E3EC
		public virtual void UpdateClipSoftness(); // 0x000000018514AE30-0x000000018514B210
		public void AddClippable(IClippable clippable); // 0x0000000185EE2530-0x0000000185EE2660
		public void RemoveClippable(IClippable clippable); // 0x0000000185CEAA50-0x0000000185CEAD00
		protected override void OnTransformParentChanged(); // 0x000000018723F910-0x000000018723F920
		protected override void OnCanvasHierarchyChanged(); // 0x00000001863FE5D0-0x00000001863FE600
		internal void RecalculateClipperChain(); // 0x00000001852E0590-0x00000001852E05C0
	}

	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Scrollbar : Selectable, IBeginDragHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 83724
	{
		// Fields
		[SerializeField]
		private RectTransform m_HandleRect; // 0x190
		[SerializeField]
		private Direction m_Direction; // 0x198
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Value; // 0x19C
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Size; // 0x1A0
		[Range(0f, 11f)]
		[SerializeField]
		private int m_NumberOfSteps; // 0x1A4
		[SerializeField]
		[Space(6f)]
		private ScrollEvent m_OnValueChanged; // 0x1A8
		private RectTransform m_ContainerRect; // 0x1B0
		private Vector2 m_Offset; // 0x1B8
		private DrivenRectTransformTracker m_Tracker; // 0x1C0
		private Coroutine m_PointerDownRepeat; // 0x1C8
		private bool isPointerDownAndNotDragging; // 0x1D0
		private bool m_DelayedUpdateVisuals; // 0x1D1
	
		// Properties
		public RectTransform handleRect { get; set; } // 0x000000018723C0A0-0x000000018723C0B0 0x000000018D6A035C-0x000000018D6A03C4
		public Direction direction { get; set; } // 0x0000000187263EC0-0x0000000187263ED0 0x000000018D6A0300-0x000000018D6A035C
		public float value { get; set; } // 0x0000000185C8CA10-0x0000000185C8CA40 0x0000000187839F3C-0x0000000187839F48
		public float size { get; set; } // 0x0000000187263ED0-0x0000000187263EE0 0x0000000185C8C770-0x0000000185C8C7B0
		public int numberOfSteps { get; set; } // 0x000000018723D550-0x000000018723D560 0x000000018D6A03C4-0x000000018D6A0434
		public ScrollEvent onValueChanged { get; set; } // 0x000000018723BDE0-0x000000018723BDF0 0x0000000188DC46B0-0x0000000188DC46C4
		private float stepSize { get; } // 0x000000018D6A02D0-0x000000018D6A0300 
		private Axis axis { get; } // 0x0000000185C8C950-0x0000000185C8C970 
		private bool reverseValue { get; } // 0x0000000185C8CA40-0x0000000185C8CA60 
		Transform ICanvasElement.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Nested types
		public enum Direction // TypeDefIndex: 83720
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}
	
		[Serializable]
		public class ScrollEvent : UnityEvent<float> // TypeDefIndex: 83721
		{
			// Constructors
			public ScrollEvent(); // 0x0000000186636250-0x0000000186636290
		}
	
		private enum Axis // TypeDefIndex: 83722
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		[CompilerGenerated]
		private sealed class _ClickRepeat_d__58 : IEnumerator<object> // TypeDefIndex: 83723
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Scrollbar __4__this; // 0x20
			public Vector2 screenPosition; // 0x28
			public Camera camera; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _ClickRepeat_d__58(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D6A4178-0x000000018D6A43A8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D6A43A8-0x000000018D6A43F4
		}
	
		// Constructors
		protected Scrollbar(); // 0x00000001866361A0-0x0000000186636250
	
		// Methods
		public virtual void SetValueWithoutNotify(float input); // 0x000000018D6A0024-0x000000018D6A0030
		public virtual void Rebuild(CanvasUpdate executing); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void LayoutComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void GraphicUpdateComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnEnable(); // 0x0000000185C8B850-0x0000000185C8B8B0
		protected override void OnDisable(); // 0x0000000185C2D7B0-0x0000000185C2D7C0
		protected virtual void Update(); // 0x00000001869F19A0-0x00000001869F19C0
		private void UpdateCachedReferences(); // 0x0000000185C8CA60-0x0000000185C8CBB0
		private void Set(float input, bool sendCallback = true /* Metadata: 0x02643BED */); // 0x0000000185C8C970-0x0000000185C8CA10
		protected override void OnRectTransformDimensionsChange(); // 0x0000000185C8B820-0x0000000185C8B850
		private void UpdateVisuals(); // 0x0000000185C8C7B0-0x0000000185C8C950
		private void UpdateDrag(PointerEventData eventData); // 0x000000018D6A0030-0x000000018D6A02D0
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize); // 0x000000018D69F7CC-0x000000018D69F838
		private bool MayDrag(PointerEventData eventData); // 0x000000018D69F908-0x000000018D69F95C
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018D69F95C-0x000000018D69FB6C
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018D69FB6C-0x000000018D69FBF4
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018D69FE00-0x000000018D69FEC8
		protected IEnumerator ClickRepeat(PointerEventData eventData); // 0x000000018D69F754-0x000000018D69F7CC
		[IteratorStateMachine(typeof(_ClickRepeat_d__58))]
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera); // 0x000000018D69F6C0-0x000000018D69F754
		public override void OnPointerUp(PointerEventData eventData); // 0x000000018D69FEC8-0x000000018D69FEE8
		public override void OnMove(AxisEventData eventData); // 0x000000018D69FC10-0x000000018D69FE00
		public override Selectable FindSelectableOnLeft(); // 0x000000018D69F86C-0x000000018D69F8A0
		public override Selectable FindSelectableOnRight(); // 0x000000018D69F8A0-0x000000018D69F8D4
		public override Selectable FindSelectableOnUp(); // 0x000000018D69F8D4-0x000000018D69F908
		public override Selectable FindSelectableOnDown(); // 0x000000018D69F838-0x000000018D69F86C
		public virtual void OnInitializePotentialDrag(PointerEventData eventData); // 0x000000018D69FBF4-0x000000018D69FC10
		public void SetDirection(Direction direction, bool includeRectLayouts); // 0x000000018D69FEE8-0x000000018D6A0024
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[SelectionBase]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup // TypeDefIndex: 83728
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
		public RectTransform content { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public bool horizontal { get; set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
		public bool vertical { get; set; } // 0x000000018225E090-0x000000018225E0A0 0x000000018225E0A0-0x000000018225E0B0
		public MovementType movementType { get; set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
		public float elasticity { get; set; } // 0x000000018723CEF0-0x000000018723CF00 0x0000000187233AF0-0x0000000187233B00
		public bool inertia { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		public float decelerationRate { get; set; } // 0x00000001872330B0-0x00000001872330C0 0x0000000187233110-0x0000000187233120
		public float scrollSensitivity { get; set; } // 0x00000001872330C0-0x00000001872330D0 0x0000000187233120-0x0000000187233130
		public RectTransform viewport { get; set; } // 0x000000018226EE80-0x000000018226EE90 0x000000018D69F69C-0x000000018D69F6C0
		public Scrollbar horizontalScrollbar { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x000000018D69F374-0x000000018D69F4FC
		public Scrollbar verticalScrollbar { get; set; } // 0x0000000187232F70-0x0000000187232F80 0x000000018D69F514-0x000000018D69F69C
		public ScrollbarVisibility horizontalScrollbarVisibility { get; set; } // 0x00000001872332A0-0x00000001872332B0 0x000000018D69F368-0x000000018D69F374
		public ScrollbarVisibility verticalScrollbarVisibility { get; set; } // 0x0000000187233670-0x0000000187233680 0x000000018D69F508-0x000000018D69F514
		public float horizontalScrollbarSpacing { get; set; } // 0x000000018723CA40-0x000000018723CA50 0x000000018D69F35C-0x000000018D69F368
		public float verticalScrollbarSpacing { get; set; } // 0x0000000187250E50-0x0000000187250E60 0x000000018D69F4FC-0x000000018D69F508
		public ScrollRectEvent onValueChanged { get; set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
		protected RectTransform viewRect { get; } // 0x0000000185696FF0-0x0000000185697190 
		public Vector2 velocity { get; set; } // 0x0000000187263EA0-0x0000000187263EC0 0x00000001872404C0-0x00000001872404D0
		private RectTransform rectTransform { get; } // 0x000000018531EC60-0x000000018531ED10 
		public Vector2 normalizedPosition { get; set; } // 0x0000000185694940-0x0000000185694980 0x0000000185B0FFC0-0x0000000185B10000
		public float horizontalNormalizedPosition { get; set; } // 0x0000000185694DD0-0x0000000185695020 0x0000000187835CEC-0x0000000187835CF8
		public float verticalNormalizedPosition { get; set; } // 0x0000000185694980-0x0000000185694C00 0x0000000187835CC4-0x0000000187835CD4
		public bool hScrollingNeeded { get; } // 0x0000000185151410-0x00000001851514C0 
		public bool vScrollingNeeded { get; } // 0x00000001851514C0-0x0000000185151580 
		public virtual float minWidth { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float preferredWidth { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float flexibleWidth { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float minHeight { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float preferredHeight { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float flexibleHeight { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual int layoutPriority { get; } // 0x0000000184E58B60-0x0000000184E58B70 
		Transform ICanvasElement.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Nested types
		public enum MovementType // TypeDefIndex: 83725
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		public enum ScrollbarVisibility // TypeDefIndex: 83726
		{
			Permanent = 0,
			AutoHide = 1,
			AutoHideAndExpandViewport = 2
		}
	
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 83727
		{
			// Constructors
			public ScrollRectEvent(); // 0x00000001878364C4-0x00000001878364D0
		}
	
		// Constructors
		protected ScrollRect(); // 0x0000000185491160-0x00000001854912B0
	
		// Methods
		public virtual void Rebuild(CanvasUpdate executing); // 0x0000000185C8B8F0-0x0000000185C8B950
		public virtual void LayoutComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void GraphicUpdateComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		private void UpdateCachedData(); // 0x0000000185C8C300-0x0000000185C8C770
		protected override void OnEnable(); // 0x000000018531EA90-0x000000018531EC00
		protected override void OnDisable(); // 0x000000018531E890-0x000000018531EA50
		public override bool IsActive(); // 0x00000001865C0AA0-0x00000001865C0B20
		public void EnsureLayoutHasRebuilt(); // 0x0000000185150F30-0x0000000185150F80
		public virtual void StopMovement(); // 0x0000000187839894-0x00000001878398A0
		public virtual void OnScroll(PointerEventData data); // 0x0000000185C8B040-0x0000000185C8B1D0
		protected virtual void _CustomSetPosOnScroll(Vector2 position); // 0x000000018D69F33C-0x000000018D69F35C
		public virtual void OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000186888630-0x0000000186888660
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x0000000185F2CDA0-0x0000000185F2CEF0
		public virtual void OnEndDrag(PointerEventData eventData); // 0x0000000186B2BF90-0x0000000186B2BFC0
		public virtual void OnDrag(PointerEventData eventData); // 0x0000000185F2DC50-0x0000000185F2DF60
		protected virtual void SetContentAnchoredPosition(Vector2 position); // 0x0000000185F2E050-0x0000000185F2E180
		protected virtual void LateUpdate(); // 0x000000018514EFC0-0x0000000185150230
		protected void UpdatePrevData(); // 0x0000000185C8B950-0x0000000185C8BA90
		protected virtual void UpdateScrollbars(Vector2 offset); // 0x0000000185C8BBC0-0x0000000185C8BE20
		protected virtual void SetHorizontalNormalizedPosition(float value); // 0x0000000187835CEC-0x0000000187835CF8
		protected virtual void SetVerticalNormalizedPosition(float value); // 0x0000000185B10000-0x0000000185B10010
		protected virtual void SetNormalizedPosition(float value, int axis); // 0x0000000185B10010-0x0000000185B10340
		private static float RubberDelta(float overStretching, float viewSize); // 0x0000000185F2DC00-0x0000000185F2DC50
		protected override void OnRectTransformDimensionsChange(); // 0x000000018531EC00-0x000000018531EC10
		public virtual void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void SetLayoutHorizontal(); // 0x0000000185C8BE20-0x0000000185C8C300
		public virtual void SetLayoutVertical(); // 0x000000018625C400-0x000000018625C580
		private void UpdateScrollbarVisibility(); // 0x0000000185150F80-0x0000000185151300
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar); // 0x0000000185151300-0x0000000185151410
		private void UpdateScrollbarLayout(); // 0x000000018625C580-0x000000018625C620
		protected virtual void UpdateScrollEnableNode(); // 0x0000000185FBE0A0-0x0000000185FBE150
		protected void UpdateBounds(); // 0x0000000185696260-0x0000000185696FF0
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos); // 0x0000000185696120-0x0000000185696260
		private Bounds GetBounds(); // 0x00000001850DC550-0x00000001850DCD70
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix); // 0x00000001850DCD70-0x00000001850DD080
		protected Vector2 CalculateOffset(Vector2 delta); // 0x0000000185150BD0-0x0000000185150C20
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta); // 0x0000000185150C20-0x0000000185150EF0
		protected void SetDirty(); // 0x000000018531EC10-0x000000018531EC60
		protected void SetDirtyCaching(); // 0x000000018D69F298-0x000000018D69F33C
	}

	[AddComponentMenu("UI/Selectable", 35)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[SelectionBase]
	public class Selectable : UIBehaviour, IMoveHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 83731
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
		[FormerlySerializedAs("highlightGraphic")]
		[FormerlySerializedAs("m_HighlightGraphic")]
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
		[CompilerGenerated]
		private bool _isPointerInside_k__BackingField; // 0x100
		[CompilerGenerated]
		private bool _isPointerDown_k__BackingField; // 0x101
		[CompilerGenerated]
		private bool _hasSelection_k__BackingField; // 0x102
		private readonly List<CanvasGroup> m_CanvasGroupCache; // 0x108
		public static UnityEvent<Selectable, bool> onAnyHoverChange; // 0x10
		public static Action<Selectable> onAnyInteractableChanged; // 0x18
		[CompilerGenerated]
		private readonly UnityEvent<bool> _onHoverChange_k__BackingField; // 0x110
		public bool enableControllerNavi; // 0x118
		public Transform overrideNaviHintRectTransform; // 0x120
		public float overrideNaviHintRectScale; // 0x128
		public bool changeNaviHintParent; // 0x12C
		public bool hideNaviHint; // 0x12D
		public bool needNaviConfirmKeyHint; // 0x12E
		public NaviHintSide naviConfirmKeyHintSide; // 0x130
		public float naviConfirmKeyHintOffset; // 0x134
		public bool useExplicitNaviSelect; // 0x138
		public bool banExplicitOnLeft; // 0x139
		public bool banExplicitOnRight; // 0x13A
		public bool banExplicitOnUp; // 0x13B
		public bool banExplicitOnDown; // 0x13C
		public Func<NaviDirection, Selectable> customNaviTargetInDirFunc; // 0x140
		[SerializeField]
		private Selectable m_ExplicitSelectOnLeft; // 0x148
		[SerializeField]
		private Selectable m_ExplicitSelectOnRight; // 0x150
		[SerializeField]
		private Selectable m_ExplicitSelectOnUp; // 0x158
		[SerializeField]
		private Selectable m_ExplicitSelectOnDown; // 0x160
		[CompilerGenerated]
		private bool _isNaviTarget_k__BackingField; // 0x168
		public Action<bool, bool, bool> onIsNaviTargetChanged; // 0x170
		[CompilerGenerated]
		private bool _isNavigationSilent_k__BackingField; // 0x178
		public SelectableNaviGroup naviGroup; // 0x180
		private bool m_naviInited; // 0x188
	
		// Properties
		public static Selectable[] allSelectablesArray { get; } // 0x000000018D6A1634-0x000000018D6A16B8 
		public static int allSelectableCount { get; } // 0x000000018D6A15E4-0x000000018D6A1634 
		[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", false)]
		public static List<Selectable> allSelectables { get; } // 0x000000018D6A16B8-0x000000018D6A1748 
		public string hoverAudioKey { get; } // 0x000000018723C070-0x000000018723C080 
		public Navigation navigation { get; set; } // 0x000000018723C370-0x000000018723C390 0x000000018531FC10-0x000000018531FC60
		public Transition transition { get; set; } // 0x00000001872330A0-0x00000001872330B0 0x000000018D6A18F0-0x000000018D6A1948
		public ColorBlock colors { get; set; } // 0x0000000187263EE0-0x0000000187263F20 0x000000018D6A17E4-0x000000018D6A1880
		public SpriteState spriteState { get; set; } // 0x0000000187263F20-0x0000000187263F40 0x000000018D6A1880-0x000000018D6A18F0
		public AnimationTriggers animationTriggers { get; set; } // 0x000000018723BB00-0x000000018723BB10 0x000000018D6A1788-0x000000018D6A17E4
		public Graphic targetGraphic { get; set; } // 0x0000000187235E40-0x0000000187235E50 0x0000000186E172B0-0x0000000186E17310
		public bool interactable { get; set; } // 0x000000018723DB30-0x000000018723DB40 0x0000000186151AD0-0x0000000186151BC0
		private bool isPointerInside { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723EFB0-0x000000018723EFC0 0x000000018723EFC0-0x000000018723EFD0
		private bool isPointerDown { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258760-0x0000000187258770 0x0000000187263F40-0x0000000187263F50
		private bool hasSelection { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187239600-0x0000000187239610 0x0000000187239620-0x0000000187239630
		public Image image { get; set; } // 0x000000018D6A1748-0x000000018D6A1788 0x0000000188D62F68-0x0000000188D62F7C
		public Animator animator { get; } // 0x0000000187834884-0x0000000187834890 
		protected SelectionState currentSelectionState { get; } // 0x000000018503CBB0-0x000000018503CC00 
		public UnityEvent<bool> onHoverChange { [CompilerGenerated] get; } // 0x000000018723B410-0x000000018723B420 
		public bool isNaviTarget { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187240880-0x0000000187240890 0x0000000187240910-0x0000000187240920
		public bool isNavigationSilent { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187233DF0-0x0000000187233E00 0x000000018723E970-0x000000018723E980
	
		// Nested types
		public enum Transition // TypeDefIndex: 83729
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 3
		}
	
		protected enum SelectionState // TypeDefIndex: 83730
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Selected = 3,
			Disabled = 4
		}
	
		// Constructors
		protected Selectable(); // 0x000000018548DE90-0x000000018548E240
		static Selectable(); // 0x00000001870A20A0-0x00000001870A2190
	
		// Methods
		public static int AllSelectablesNoAlloc(Selectable[] selectables); // 0x000000018D6A0454-0x000000018D6A04FC
		protected override void Awake(); // 0x000000018531FA40-0x000000018531FC10
		protected void OnCanvasGroupChanged(); // 0x00000001851C7420-0x00000001851C7780
		public virtual bool IsInteractable(); // 0x000000018503CC00-0x000000018503CC20
		protected override void OnDidApplyAnimationProperties(); // 0x0000000186D3CBC0-0x0000000186D3CBD0
		protected override void OnEnable(); // 0x000000018503BF00-0x000000018503C560
		protected override void OnTransformParentChanged(); // 0x0000000186BBF570-0x0000000186BBF580
		private void OnSetProperty(); // 0x000000018503B6A0-0x000000018503B6D0
		protected override void OnDisable(); // 0x000000018503CC20-0x000000018503CE50
		private void OnApplicationFocus(bool hasFocus); // 0x000000018503BAB0-0x000000018503BB00
		protected virtual void InstantClearState(); // 0x000000018503D160-0x000000018503D1F0
		protected virtual void DoStateTransition(SelectionState state, bool instant); // 0x000000018503CF10-0x000000018503D160
		public Selectable FindSelectable(Vector3 dir); // 0x000000018D6A084C-0x000000018D6A0D20
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir); // 0x000000018D6A0DC0-0x000000018D6A0FA0
		private void Navigate(AxisEventData eventData, Selectable sel); // 0x000000018D6A0FF0-0x000000018D6A1080
		public virtual Selectable FindSelectableOnLeft(); // 0x000000018D6A063C-0x000000018D6A06EC
		public virtual Selectable FindSelectableOnRight(); // 0x000000018D6A06EC-0x000000018D6A079C
		public virtual Selectable FindSelectableOnUp(); // 0x000000018D6A079C-0x000000018D6A084C
		public virtual Selectable FindSelectableOnDown(); // 0x000000018D6A058C-0x000000018D6A063C
		public virtual void OnMove(AxisEventData eventData); // 0x000000018D6A1080-0x000000018D6A10F0
		private void StartColorTween(UnityEngine.Color targetColor, bool instant); // 0x000000018503D240-0x000000018503D470
		private void DoSpriteSwap(Sprite newSprite); // 0x000000018D6A04FC-0x000000018D6A058C
		private void TriggerAnimation(string triggername); // 0x000000018503D470-0x000000018503DD10
		protected bool IsHighlighted(); // 0x000000018D6A0FA0-0x000000018D6A0FF0
		protected bool IsPressed(); // 0x000000018503BB00-0x000000018503BB40
		private void EvaluateAndTransitionToSelectionState(); // 0x000000018503BA30-0x000000018503BAB0
		public virtual void OnPointerDown(PointerEventData eventData); // 0x0000000185035960-0x0000000185035990
		public virtual void OnPointerUp(PointerEventData eventData); // 0x0000000185035990-0x0000000185036A70
		public virtual void OnPointerEnter(PointerEventData eventData); // 0x00000001850381F0-0x0000000185038300
		public virtual void OnPointerExit(PointerEventData eventData); // 0x000000018503B640-0x000000018503B670
		public virtual void OnSelect(BaseEventData eventData); // 0x0000000186EBA9A0-0x0000000186EBA9B0
		public virtual void OnDeselect(BaseEventData eventData); // 0x0000000186E7B060-0x0000000186E7B070
		public virtual void Select(); // 0x000000018D6A1160-0x000000018D6A122C
		protected virtual void _RefreshHoverEnableNode(bool active); // 0x00000001851DDEC0-0x00000001851DDF90
		public virtual void OnInteractableChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void _NotifyIsHover(bool isHover); // 0x0000000185045550-0x0000000185045600
		protected override void OnDestroy(); // 0x00000001850421F0-0x0000000185042230
		public virtual bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId); // 0x000000018D6A0D98-0x000000018D6A0DC0
		public void SetAsNaviTarget(bool isTarget, bool silentMode, bool isGroupChanged); // 0x000000018D6A122C-0x000000018D6A1374
		public virtual void OnNaviTargetEnabledAgain(); // 0x000000018D6A10F0-0x000000018D6A1160
		protected virtual void _OnSetAsNaviTarget(bool isTarget, bool silentMode); // 0x0000000186805BA0-0x0000000186805BB0
		public void TryFindNaviGroup(); // 0x000000018531FC60-0x000000018531FC90
		public SelectableNaviGroup GetLayerGroup(); // 0x000000018D6A0D20-0x000000018D6A0D98
		public bool TryFindExplicitNaviTarget(NaviDirection dir, out Selectable target); // 0x000000018D6A1374-0x000000018D6A1504
		public bool banExplicitNavi(NaviDirection dir); // 0x000000018D6A1504-0x000000018D6A15E4
		private void _TryRegisterOnNaviGroup(); // 0x000000018503CE50-0x000000018503CF10
		private void _TryUnRegisterOnNaviGroup(); // 0x0000000185042230-0x0000000185042370
		public void SetExplicitSelectOnLeft(Selectable selectable); // 0x0000000188DC4804-0x0000000188DC4818
		public void SetExplicitSelectOnRight(Selectable selectable); // 0x0000000188DC4570-0x0000000188DC4584
		public void SetExplicitSelectOnUp(Selectable selectable); // 0x0000000188DC4598-0x0000000188DC45AC
		public void SetExplicitSelectOnDown(Selectable selectable); // 0x0000000188DC45AC-0x0000000188DC45C0
		public void SetExplicitSelect(Selectable left, Selectable right, Selectable up, Selectable down); // 0x0000000186ADB2E0-0x0000000186ADB340
	}

	public enum NaviDirection // TypeDefIndex: 83732
	{
		None = 0,
		Up = 1,
		Down = 2,
		Left = 3,
		Right = 4
	}

	public enum NaviHintSide // TypeDefIndex: 83733
	{
		Bottom = 0,
		Top = 1,
		Left = 2,
		Right = 3
	}

	public enum NaviStrategy // TypeDefIndex: 83734
	{
		Normal = 0,
		Strict = 1,
		NotInternalFirst = 2,
		VerticalOnlyWithInternalWrap = 3,
		HorizontalOnlyWithInternalWrap = 4
	}

	public enum NavigationBindingType // TypeDefIndex: 83735
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
	public abstract class SelectableNaviGroup : MonoBehaviour // TypeDefIndex: 83736
	{
		// Fields
		public bool isIsolate; // 0x18
		public bool isLayer; // 0x19
		public bool removeLayerOnDisable; // 0x1A
		public SelectableNaviGroup parentNaviGroup; // 0x20
		[FormerlySerializedAs("naviStrategy")]
		public NaviStrategy internalNaviStrategy; // 0x28
		public NavigationBindingType navigationBindingType; // 0x2C
		[Tooltip("\u957F\u6309\u91CD\u590D\u5BFC\u822A\u5931\u8D25\u65F6\uFF0C\u662F\u5426\u5EF6\u8FDF\u89E6\u53D1 onDefaultNaviFailed")]
		public bool delayDefaultNaviFailedOnRepeat; // 0x30
		[NonSerialized]
		public Func<NaviDirection, bool> delayDefaultNaviFailedOnRepeatFilter; // 0x38
		public bool enablePartner; // 0x40
		[SerializeReference]
		public List<SelectableNaviGroup> naviPartnerOnUp; // 0x48
		[SerializeReference]
		public List<SelectableNaviGroup> naviPartnerOnDown; // 0x50
		[SerializeReference]
		public List<SelectableNaviGroup> naviPartnerOnLeft; // 0x58
		[SerializeReference]
		public List<SelectableNaviGroup> naviPartnerOnRight; // 0x60
		protected bool m_inited; // 0x68
		protected Selectable m_layerSelectedTarget; // 0x70
		public HashSet<Selectable> targets; // 0x78
		public HashSet<SelectableNaviGroup> subGroups; // 0x80
		[NonSerialized]
		public UnityEvent<Selectable> onSetLayerSelectedTarget; // 0x88
		[NonSerialized]
		public UnityEvent<bool> onIsTopLayerChanged; // 0x90
		[NonSerialized]
		public UnityEvent<NaviDirection> onDefaultNaviFailed; // 0x98
		[NonSerialized]
		public UnityEvent onRemoveFromLayerStack; // 0xA0
		protected bool m_isTopLayer; // 0xA8
	
		// Properties
		public Selectable LayerSelectedTarget { get; } // 0x0000000185042820-0x0000000185042840 
		public bool IsTopLayer { get; set; } // 0x000000018225E110-0x000000018225E120 0x000000018D6A043C-0x000000018D6A0454
	
		// Constructors
		protected SelectableNaviGroup(); // 0x000000018548FE70-0x00000001854900D0
	
		// Methods
		protected virtual void Reset(); // 0x000000018D6A0434-0x000000018D6A043C
		protected virtual void OnEnable(); // 0x000000018503FF30-0x000000018503FF60
		protected virtual void OnDisable(); // 0x000000018783C598-0x000000018783C5A8
		protected virtual void OnDestroy(); // 0x00000001864D9830-0x00000001864D98E0
		protected virtual void _Init(); // 0x000000018503FFC0-0x0000000185040080
		public void TryFindParentNaviGroup(); // 0x000000018531F650-0x000000018531F740
		public SelectableNaviGroup GetLayerGroup(); // 0x0000000185042BC0-0x0000000185042C40
		public virtual int GetOwnerPanelId(); // 0x0000000184E58B60-0x0000000184E58B70
		public void SetLayerSelectedTarget(Selectable value, bool silentMode); // 0x0000000185042AB0-0x0000000185042B10
		public void OnRemoveFromLayerStack(); // 0x0000000185043320-0x0000000185043350
		protected virtual void _OnIsTopLayerChanged(); // 0x00000001850448B0-0x00000001850448E0
		protected virtual void _OnSelectableNaviGroupInited(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void _BeforeSelectableNaviGroupDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void _OnSelectableNaviGroupDisabled(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void _OnSetLayerSelectedTarget(Selectable value); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void _OnRemoveFromLayerStack(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class SetPropertyUtility // TypeDefIndex: 83737
	{
		// Methods
		public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue); // 0x0000000185358390-0x00000001853583D0
		public static bool SetStruct<T>(ref ref T currentValue, T newValue)
			where T : struct;
		public static bool SetClass<T>(ref ref T currentValue, T newValue)
			where T : class;
	}

	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Slider : Selectable, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 83741
	{
		// Fields
		[SerializeField]
		private RectTransform m_FillRect; // 0x190
		[SerializeField]
		private RectTransform m_HandleRect; // 0x198
		[SerializeField]
		[Space]
		private Direction m_Direction; // 0x1A0
		[SerializeField]
		private float m_MinValue; // 0x1A4
		[SerializeField]
		private float m_MaxValue; // 0x1A8
		[SerializeField]
		private bool m_WholeNumbers; // 0x1AC
		[SerializeField]
		protected float m_Value; // 0x1B0
		[SerializeField]
		[Space]
		private SliderEvent m_OnValueChanged; // 0x1B8
		private Image m_FillImage; // 0x1C0
		private Transform m_FillTransform; // 0x1C8
		private RectTransform m_FillContainerRect; // 0x1D0
		private Transform m_HandleTransform; // 0x1D8
		private RectTransform m_HandleContainerRect; // 0x1E0
		private Vector2 m_Offset; // 0x1E8
		private DrivenRectTransformTracker m_Tracker; // 0x1F0
		private bool m_DelayedUpdateVisuals; // 0x1F1
	
		// Properties
		public RectTransform fillRect { get; set; } // 0x000000018723C0A0-0x000000018723C0B0 0x000000018D6A2458-0x000000018D6A24C0
		public RectTransform handleRect { get; set; } // 0x000000018723C220-0x000000018723C230 0x000000018D6A24C0-0x000000018D6A2528
		public Direction direction { get; set; } // 0x000000018723D560-0x000000018723D570 0x000000018D6A23FC-0x000000018D6A2458
		public float minValue { get; set; } // 0x0000000187263F80-0x0000000187263F90 0x0000000186914CE0-0x0000000186914D60
		public float maxValue { get; set; } // 0x0000000187263F70-0x0000000187263F80 0x000000018690FCE0-0x000000018690FD60
		public bool wholeNumbers { get; set; } // 0x0000000187263F90-0x0000000187263FA0 0x0000000186A51170-0x0000000186A511F0
		public virtual float value { get; set; } // 0x000000018539A020-0x000000018539A050 0x0000000187835D94-0x0000000187835DA0
		public float normalizedValue { get; set; } // 0x0000000185399F60-0x000000018539A020 0x000000018D6A2528-0x000000018D6A2558
		public SliderEvent onValueChanged { get; set; } // 0x000000018723BE80-0x000000018723BE90 0x0000000188DC47C8-0x0000000188DC47DC
		private float stepSize { get; } // 0x000000018D6A23D0-0x000000018D6A23FC 
		private Axis axis { get; } // 0x0000000185399F40-0x0000000185399F60 
		private bool reverseValue { get; } // 0x000000018539A050-0x000000018539A070 
		Transform ICanvasElement.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Nested types
		public enum Direction // TypeDefIndex: 83738
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}
	
		[Serializable]
		public class SliderEvent : UnityEvent<float> // TypeDefIndex: 83739
		{
			// Constructors
			public SliderEvent(); // 0x000000018783C3D4-0x000000018783C3E0
		}
	
		private enum Axis // TypeDefIndex: 83740
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		// Constructors
		protected Slider(); // 0x00000001865852C0-0x0000000186585380
	
		// Methods
		public virtual void SetValueWithoutNotify(float input); // 0x000000018783C984-0x000000018783C990
		public virtual void Rebuild(CanvasUpdate executing); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void LayoutComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void GraphicUpdateComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnEnable(); // 0x000000018531E850-0x000000018531E890
		protected override void OnDisable(); // 0x0000000185C2D7B0-0x0000000185C2D7C0
		protected virtual void Update(); // 0x0000000187263F50-0x0000000187263F70
		protected override void OnDidApplyAnimationProperties(); // 0x000000018D6A1A4C-0x000000018D6A1C50
		private void UpdateCachedReferences(); // 0x000000018531F240-0x000000018531F650
		protected virtual float ClampValue(float input); // 0x000000018D6A1948-0x000000018D6A197C
		protected virtual void Set(float input, bool sendCallback = true /* Metadata: 0x02643C1E */); // 0x0000000185399AA0-0x0000000185399B70
		protected virtual void OnValueChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnClickSliderBar(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnClickSliderHandle(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnRectTransformDimensionsChange(); // 0x0000000186A20870-0x0000000186A208A0
		private void UpdateVisuals(); // 0x0000000185399B70-0x0000000185399F40
		private void UpdateDrag(PointerEventData eventData, Camera cam); // 0x000000018D6A21A0-0x000000018D6A23D0
		protected virtual float CustomProcessNormalizedValue(float val); // 0x0000000187248B60-0x0000000187248B70
		private bool MayDrag(PointerEventData eventData); // 0x000000018D69F908-0x000000018D69F95C
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018D6A1E88-0x000000018D6A2064
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018D6A1C50-0x000000018D6A1CA0
		public override void OnMove(AxisEventData eventData); // 0x000000018D6A1CA0-0x000000018D6A1E88
		public override Selectable FindSelectableOnLeft(); // 0x000000018D6A19B0-0x000000018D6A19E4
		public override Selectable FindSelectableOnRight(); // 0x000000018D6A19E4-0x000000018D6A1A18
		public override Selectable FindSelectableOnUp(); // 0x000000018D6A1A18-0x000000018D6A1A4C
		public override Selectable FindSelectableOnDown(); // 0x000000018D6A197C-0x000000018D6A19B0
		public virtual void OnInitializePotentialDrag(PointerEventData eventData); // 0x000000018D69FBF4-0x000000018D69FC10
		public void SetDirection(Direction direction, bool includeRectLayouts); // 0x000000018D6A2064-0x000000018D6A21A0
	}

	[Serializable]
	public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 83742
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
		public Sprite highlightedSprite { get; set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
		public Sprite pressedSprite { get; set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		public Sprite selectedSprite { get; set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public Sprite disabledSprite { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Methods
		public bool Equals(SpriteState other); // 0x000000018D6A2558-0x000000018D6A2624
	}

	public static class StencilMaterial // TypeDefIndex: 83744
	{
		// Fields
		private static List<MatEntry> m_List; // 0x00
		private static bool s_EnableStencilMaterialWarning; // 0x08
	
		// Nested types
		private class MatEntry // TypeDefIndex: 83743
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
			public MatEntry(); // 0x0000000187263E60-0x0000000187263E70
		}
	
		// Constructors
		static StencilMaterial(); // 0x0000000187113A40-0x0000000187113AE0
	
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Material.Add instead.", true)]
		public static Material Add(Material baseMat, int stencilID); // 0x0000000185829EC0-0x0000000185829ED0
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask); // 0x00000001852DF8E0-0x00000001852DF960
		private static void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context); // 0x000000018D6A2738-0x000000018D6A27C0
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask); // 0x00000001851029D0-0x0000000185103110
		public static void Remove(Material customMat); // 0x00000001852EE240-0x00000001852EE470
		public static void ClearAll(); // 0x000000018D6A2624-0x000000018D6A2738
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 83745
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
		internal override bool hasCullOverride { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public TextGenerator cachedTextGenerator { get; } // 0x000000018D6A33A4-0x000000018D6A3458 
		public TextGenerator cachedTextGeneratorForLayout { get; } // 0x000000018D6A3328-0x000000018D6A33A4 
		public override Texture mainTexture { get; } // 0x000000018D6A34F8-0x000000018D6A3648 
		public Font font { get; set; } // 0x000000018D6A3498-0x000000018D6A34B8 0x000000018D6A3B24-0x000000018D6A3C18
		public virtual string text { get; set; } // 0x000000018723C070-0x000000018723C080 0x000000018D6A3DB8-0x000000018D6A3E84
		public bool supportRichText { get; set; } // 0x000000018D6A39DC-0x000000018D6A39FC 0x000000018D6A3D74-0x000000018D6A3DB8
		public bool resizeTextForBestFit { get; set; } // 0x000000018D6A397C-0x000000018D6A399C 0x000000018D6A3CA8-0x000000018D6A3CEC
		public int resizeTextMinSize { get; set; } // 0x000000018D6A39BC-0x000000018D6A39DC 0x000000018D6A3D30-0x000000018D6A3D74
		public int resizeTextMaxSize { get; set; } // 0x000000018D6A399C-0x000000018D6A39BC 0x000000018D6A3CEC-0x000000018D6A3D30
		public TextAnchor alignment { get; set; } // 0x000000018D6A3308-0x000000018D6A3328 0x000000018D6A3A58-0x000000018D6A3A9C
		public bool alignByGeometry { get; set; } // 0x000000018D6A32E8-0x000000018D6A3308 0x000000018D6A3A1C-0x000000018D6A3A58
		public int fontSize { get; set; } // 0x000000018D6A3458-0x000000018D6A3478 0x000000018D6A3A9C-0x000000018D6A3AE0
		public HorizontalWrapMode horizontalOverflow { get; set; } // 0x000000018D6A34B8-0x000000018D6A34D8 0x000000018D6A3C18-0x000000018D6A3C5C
		public VerticalWrapMode verticalOverflow { get; set; } // 0x000000018D6A39FC-0x000000018D6A3A1C 0x000000018D6A3E84-0x000000018D6A3EC8
		public float lineSpacing { get; set; } // 0x000000018D6A34D8-0x000000018D6A34F8 0x000000018D6A3C5C-0x000000018D6A3CA8
		public FontStyle fontStyle { get; set; } // 0x000000018D6A3478-0x000000018D6A3498 0x000000018D6A3AE0-0x000000018D6A3B24
		public float pixelsPerUnit { get; } // 0x000000018D6A3648-0x000000018D6A3784 
		public virtual float minWidth { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual float preferredWidth { get; } // 0x000000018D6A388C-0x000000018D6A397C 
		public virtual float flexibleWidth { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual float minHeight { get; } // 0x0000000187234CD0-0x0000000187234CE0 
		public virtual float preferredHeight { get; } // 0x000000018D6A3784-0x000000018D6A388C 
		public virtual float flexibleHeight { get; } // 0x0000000187257DF0-0x0000000187257E00 
		public virtual int layoutPriority { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		protected Text(); // 0x0000000186B8D5F0-0x0000000186B8D6A0
	
		// Methods
		public void FontTextureChanged(); // 0x000000018D6A28B0-0x000000018D6A2978
		protected override void OnEnable(); // 0x000000018D6A2C5C-0x000000018D6A2CC4
		protected override void OnDisable(); // 0x000000018D6A2C10-0x000000018D6A2C5C
		protected override void UpdateGeometry(); // 0x000000018D6A3280-0x000000018D6A32E8
		public void AssignDefaultFont(); // 0x000000018D6A2858-0x000000018D6A28B0
		internal void AssignDefaultFontIfNecessary(); // 0x000000018D6A27C0-0x000000018D6A2858
		public TextGenerationSettings GetGenerationSettings(Vector2 extents); // 0x000000018D6A2978-0x000000018D6A2B84
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor); // 0x000000018D6A2B84-0x000000018D6A2C10
		protected override void OnPopulateMesh(VertexHelper toFill); // 0x000000018D6A2CC4-0x000000018D6A3280
		public virtual void CalculateLayoutInputHorizontal(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void CalculateLayoutInputVertical(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[RequireComponent(typeof(RectTransform))]
	public class Toggle : Selectable, IPointerClickHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 83748
	{
		// Fields
		public ToggleTransition toggleTransition; // 0x190
		public Graphic graphic; // 0x198
		[SerializeField]
		private ToggleGroup m_Group; // 0x1A0
		public ToggleEvent onValueChanged; // 0x1A8
		[SerializeField]
		[Tooltip("Is the toggle currently on or off?")]
		private bool m_IsOn; // 0x1B0
	
		// Properties
		public ToggleGroup group { get; set; } // 0x000000018723BE20-0x000000018723BE30 0x000000018D6A4150-0x000000018D6A4178
		public bool isOn { get; set; } // 0x000000018723E850-0x000000018723E860 0x000000018503E9A0-0x000000018503E9B0
		Transform ICanvasElement.transform { get; } // 0x0000000187834814-0x000000018783481C 
	
		// Nested types
		public enum ToggleTransition // TypeDefIndex: 83746
		{
			None = 0,
			Fade = 1
		}
	
		[Serializable]
		public class ToggleEvent : UnityEvent<bool> // TypeDefIndex: 83747
		{
			// Constructors
			public ToggleEvent(); // 0x00000001878348A0-0x00000001878348AC
		}
	
		// Constructors
		protected Toggle(); // 0x000000018503E4D0-0x000000018503E550
	
		// Methods
		public virtual void Rebuild(CanvasUpdate executing); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void LayoutComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void GraphicUpdateComplete(); // 0x0000000186805BA0-0x0000000186805BB0
		protected override void OnDestroy(); // 0x000000018503F540-0x000000018503F600
		protected override void OnEnable(); // 0x000000018503DE30-0x000000018503DE70
		protected override void OnDisable(); // 0x000000018503DD90-0x000000018503DDC0
		protected override void OnDidApplyAnimationProperties(); // 0x000000018D6A4010-0x000000018D6A411C
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue); // 0x000000018503E630-0x000000018503E860
		public void SetIsOnWithoutNotify(bool value); // 0x000000018783C5E8-0x000000018783C5F4
		private void Set(bool value, bool sendCallback = true /* Metadata: 0x02643C25 */); // 0x000000018503E9B0-0x000000018503EB70
		private void PlayEffect(bool instant); // 0x000000018503E550-0x000000018503E630
		protected override void Start(); // 0x00000001878348AC-0x00000001878348B8
		protected virtual void InternalToggle(); // 0x00000001867FAC10-0x00000001867FAC70
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018D6A411C-0x000000018D6A4150
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018CE6052C-0x000000018CE6053C
		protected virtual void OnValueChange(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("UI/Toggle Group", 31)]
	[DisallowMultipleComponent]
	public class ToggleGroup : UIBehaviour // TypeDefIndex: 83750
	{
		// Fields
		[SerializeField]
		private bool m_AllowSwitchOff; // 0x18
		protected List<Toggle> m_Toggles; // 0x20
	
		// Properties
		public bool allowSwitchOff { get; set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 83749
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Toggle> __9__13_0; // 0x08
			public static Func<Toggle, bool> __9__14_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E5CC0-0x00000001871E5D20
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AnyTogglesOn_b__13_0(Toggle x); // 0x0000000185625630-0x0000000185625650
			internal bool _ActiveToggles_b__14_0(Toggle x); // 0x0000000185625630-0x0000000185625650
		}
	
		// Constructors
		protected ToggleGroup(); // 0x000000018693A080-0x000000018693A110
	
		// Methods
		protected override void Start(); // 0x00000001865194E0-0x00000001865194F0
		protected override void OnEnable(); // 0x00000001865194E0-0x00000001865194F0
		private void ValidateToggleIsInGroup(Toggle toggle); // 0x000000018503F600-0x000000018503F6F0
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true /* Metadata: 0x02643C28 */); // 0x000000018503E860-0x000000018503E9A0
		public void UnregisterToggle(Toggle toggle); // 0x000000018503EC60-0x000000018503ECC0
		public void RegisterToggle(Toggle toggle); // 0x00000001868C4800-0x00000001868C4860
		public void EnsureValidState(); // 0x0000000186519600-0x0000000186519870
		public bool AnyTogglesOn(); // 0x0000000186519960-0x0000000186519AD0
		public IEnumerable<Toggle> ActiveToggles(); // 0x0000000186519870-0x0000000186519960
		public Toggle GetFirstActiveToggle(); // 0x000000018D6A3EC8-0x000000018D6A3F38
		public void SetAllTogglesOff(bool sendCallback = true /* Metadata: 0x02643C29 */); // 0x000000018D6A3F38-0x000000018D6A4010
	}

	internal class ReflectionMethodsCache // TypeDefIndex: 83757
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
		public static ReflectionMethodsCache Singleton { get; } // 0x000000018D69F208-0x000000018D69F298 
	
		// Nested types
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i); // TypeDefIndex: 83751; 0x000000018D69D3D4-0x000000018D69D414
	
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i); // TypeDefIndex: 83752; 0x000000018D69D21C-0x000000018D69D254
	
		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i); // TypeDefIndex: 83753; 0x000000018D69D3D4-0x000000018D69D414
	
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i); // TypeDefIndex: 83754; 0x000000018D69D990-0x000000018D69D9EC
	
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i); // TypeDefIndex: 83755; 0x000000018D69D21C-0x000000018D69D254
	
		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i); // TypeDefIndex: 83756; 0x000000018D69D3D4-0x000000018D69D414
	
		// Constructors
		public ReflectionMethodsCache(); // 0x000000018D69E74C-0x000000018D69F208
	}

	public class VertexHelper : IDisposable // TypeDefIndex: 83758
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
		public int currentVertCount { get; } // 0x000000018564C6A0-0x000000018564C6C0 
		public int currentIndexCount { get; } // 0x000000018D6A4CE8-0x000000018D6A4F14 
	
		// Constructors
		public VertexHelper(); // 0x0000000186805BA0-0x0000000186805BB0
		public VertexHelper(Mesh m); // 0x000000018D6A4AB0-0x000000018D6A4CE8
		static VertexHelper(); // 0x0000000186DDC490-0x0000000186DDC500
	
		// Methods
		private void InitializeListIfRequired(); // 0x000000018564DE00-0x000000018564DF70
		public void Dispose(); // 0x0000000186834900-0x0000000186834AC0
		public void Clear(); // 0x000000018564AA80-0x000000018564AB30
		public void PopulateUIVertex(ref UIVertex vertex, int i); // 0x000000018D6A45AC-0x000000018D6A4768
		public void SetUIVertex(UIVertex vertex, int i); // 0x000000018D6A4768-0x000000018D6A4AB0
		public void FillMesh(Mesh mesh); // 0x00000001855AC7F0-0x00000001855AD390
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent); // 0x000000018564D770-0x000000018564DE00
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent); // 0x000000018564D0D0-0x000000018564D770
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0); // 0x000000018564C9F0-0x000000018564D0D0
		public void AddVert(UIVertex v); // 0x00000001856BD1C0-0x00000001856BD270
		public void AddTriangle(int idx0, int idx1, int idx2); // 0x000000018564C6C0-0x000000018564C9F0
		public void AddUIVertexQuad(UIVertex[] verts); // 0x00000001856BBCC0-0x00000001856BBEA0
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices); // 0x000000018D6A43F4-0x000000018D6A44B4
		public void AddUIVertexTriangleStream(List<UIVertex> verts); // 0x000000018D6A44B4-0x000000018D6A4530
		public void GetUIVertexStream(List<UIVertex> stream); // 0x000000018D6A4530-0x000000018D6A45AC
	}

	[Obsolete("Use BaseMeshEffect instead", true)]
	public abstract class BaseVertexEffect // TypeDefIndex: 83759
	{
		// Constructors
		protected BaseVertexEffect(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		public abstract void ModifyVertices(List<UIVertex> vertices);
	}

	[ExecuteAlways]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 83760
	{
		// Fields
		[NonSerialized]
		private Graphic m_Graphic; // 0x18
	
		// Properties
		protected Graphic graphic { get; } // 0x000000018D6A5B40-0x000000018D6A5BC4 
	
		// Constructors
		protected BaseMeshEffect(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		protected override void OnEnable(); // 0x000000018D6A5AC0-0x000000018D6A5B40
		protected override void OnDisable(); // 0x000000018D6A5A40-0x000000018D6A5AC0
		protected override void OnDidApplyAnimationProperties(); // 0x000000018D6A59C0-0x000000018D6A5A40
		public virtual void ModifyMesh(Mesh mesh); // 0x000000018D6A58B0-0x000000018D6A59C0
		public abstract void ModifyMesh(VertexHelper vh);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use IMeshModifier instead", true)]
	public interface IVertexModifier // TypeDefIndex: 83761
	{
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		void ModifyVertices(List<UIVertex> verts);
	}

	public interface IMeshModifier // TypeDefIndex: 83762
	{
		// Methods
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		void ModifyMesh(Mesh mesh);
		void ModifyMesh(VertexHelper verts);
	}

	[AddComponentMenu("UI/Effects/Outline", 81)]
	public class Outline : Shadow // TypeDefIndex: 83763
	{
		// Constructors
		protected Outline(); // 0x000000018D6A7754-0x000000018D6A775C
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x000000018D6A74B0-0x000000018D6A7754
	}

	[AddComponentMenu("UI/Effects/Position As UV1", 82)]
	public class PositionAsUV1 : BaseMeshEffect // TypeDefIndex: 83764
	{
		// Constructors
		protected PositionAsUV1(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x000000018D6AC5FC-0x000000018D6AC6F8
	}

	[AddComponentMenu("UI/Effects/Shadow", 80)]
	public class Shadow : BaseMeshEffect // TypeDefIndex: 83765
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color m_EffectColor; // 0x20
		[SerializeField]
		private Vector2 m_EffectDistance; // 0x30
		[SerializeField]
		private bool m_UseGraphicAlpha; // 0x38
		private const float kMaxEffectDistance = 600f; // Metadata: 0x02643C2A
	
		// Properties
		public UnityEngine.Color effectColor { get; set; } // 0x0000000187238F60-0x0000000187238F70 0x000000018D6AD954-0x000000018D6AD9E0
		public Vector2 effectDistance { get; set; } // 0x000000018724C750-0x000000018724C770 0x000000018D6AD9E0-0x000000018D6ADAB8
		public bool useGraphicAlpha { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018D6ADAB8-0x000000018D6ADB40
	
		// Constructors
		protected Shadow(); // 0x000000018721FBB0-0x000000018721FBF0
	
		// Methods
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y); // 0x000000018D6AD58C-0x000000018D6AD818
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y); // 0x000000018D6AD818-0x000000018D6AD828
		public override void ModifyMesh(VertexHelper vh); // 0x000000018D6AD828-0x000000018D6AD954
	}
}

namespace UnityEngine.UI.Collections
{
	internal class IndexedSet<T> : IList<T> // TypeDefIndex: 83766
	{
		// Fields
		private readonly List<T> m_List;
		private Dictionary<T, int> m_Dictionary;
	
		// Properties
		public int Count { get; }
		public bool IsReadOnly { get; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public IndexedSet();
	
		// Methods
		public void Add(T item);
		public bool AddUnique(T item);
		public bool Remove(T item);
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public void Clear();
		public bool Contains(T item);
		public void CopyTo(T[] array, int arrayIndex);
		public int IndexOf(T item);
		public void Insert(int index, T item);
		public void RemoveAt(int index);
		public void RemoveAll(Predicate<T> match);
		public void Sort(Comparison<T> sortLayoutFunction);
	}
}

namespace UnityEngine.UI.CoroutineTween
{
	internal interface ITweenValue // TypeDefIndex: 83767
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}

	internal struct ColorTween : ITweenValue // TypeDefIndex: 83770
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private UnityEngine.Color m_StartColor; // 0x08
		private UnityEngine.Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public UnityEngine.Color startColor { get; set; } // 0x000000018453CA30-0x000000018453CA40 0x000000018723B0B0-0x000000018723B0C0
		public UnityEngine.Color targetColor { get; set; } // 0x00000001845C28E0-0x00000001845C28F0 0x0000000187235FF0-0x0000000187236000
		public ColorTweenMode tweenMode { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public float duration { get; set; } // 0x0000000187233330-0x0000000187233340 0x0000000187233340-0x0000000187233350
		public bool ignoreTimeScale { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x00000001822434C0-0x00000001822434D0
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 83768
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<UnityEngine.Color> // TypeDefIndex: 83769
		{
			// Constructors
			public ColorTweenCallback(); // 0x00000001878369B8-0x00000001878369C4
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x0000000185576040-0x00000001855761C0
		public void AddOnChangedCallback(UnityAction<UnityEngine.Color> callback); // 0x0000000185576410-0x00000001855764B0
		public bool GetIgnoreTimescale(); // 0x00000001822434B0-0x00000001822434C0
		public float GetDuration(); // 0x0000000187233330-0x0000000187233340
		public bool ValidTarget(); // 0x00000001855761C0-0x00000001855761D0
	}

	internal struct FloatTween : ITweenValue // TypeDefIndex: 83772
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get; set; } // 0x000000018724A400-0x000000018724A410 0x000000018725A120-0x000000018725A130
		public float targetValue { get; set; } // 0x000000018724AEC0-0x000000018724AED0 0x000000018725AC70-0x000000018725AC80
		public float duration { get; set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
		public bool ignoreTimeScale { get; set; } // 0x0000000187239C50-0x0000000187239C60 0x000000018723C800-0x000000018723C810
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 83771
		{
			// Constructors
			public FloatTweenCallback(); // 0x000000018D6A7038-0x000000018D6A7074
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018D6A710C-0x000000018D6A7170
		public void AddOnChangedCallback(UnityAction<float> callback); // 0x000000018D6A7074-0x000000018D6A710C
		public bool GetIgnoreTimescale(); // 0x0000000187239C50-0x0000000187239C60
		public float GetDuration(); // 0x0000000187232D00-0x0000000187232D10
		public bool ValidTarget(); // 0x0000000185AEC7D0-0x0000000185AEC7E0
	}

	internal class TweenRunner<T> // TypeDefIndex: 83774
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__2 : IEnumerator<object> // TypeDefIndex: 83773
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public T tweenInfo;
			private float _elapsedTime_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__2(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TweenRunner();
	
		// Methods
		[IteratorStateMachine(typeof(_Start_d__2))]
		private static IEnumerator Start(T tweenInfo);
		public void Init(MonoBehaviour coroutineContainer);
		public void StartTween(T info);
		public void StopTween();
	}
}

namespace UnityEngine.UIElements
{
	[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
	public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, UnityEngine.EventSystems.IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent // TypeDefIndex: 83777
	{
		// Fields
		private BaseRuntimePanel m_Panel; // 0x18
		private readonly PointerEvent m_PointerEvent; // 0x20
		private bool m_Selecting; // 0x28
		private UnityEngine.Event m_Event; // 0x30
		private static EventModifiers s_Modifiers; // 0x00
	
		// Properties
		public IPanel panel { get; set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018D6A9158-0x000000018D6A91C8
		private GameObject selectableGameObject { get; } // 0x000000018D6A9144-0x000000018D6A9158 
		private EventSystem eventSystem { get; } // 0x000000018D6A90F4-0x000000018D6A9144 
	
		// Nested types
		private enum PointerEventType // TypeDefIndex: 83775
		{
			Default = 0,
			Down = 1,
			Up = 2
		}
	
		private class PointerEvent : IPointerEvent // TypeDefIndex: 83776
		{
			// Fields
			[CompilerGenerated]
			private int _pointerId_k__BackingField; // 0x10
			[CompilerGenerated]
			private string _pointerType_k__BackingField; // 0x18
			[CompilerGenerated]
			private bool _isPrimary_k__BackingField; // 0x20
			[CompilerGenerated]
			private int _button_k__BackingField; // 0x24
			[CompilerGenerated]
			private int _pressedButtons_k__BackingField; // 0x28
			[CompilerGenerated]
			private Vector3 _position_k__BackingField; // 0x2C
			[CompilerGenerated]
			private Vector3 _localPosition_k__BackingField; // 0x38
			[CompilerGenerated]
			private Vector3 _deltaPosition_k__BackingField; // 0x44
			[CompilerGenerated]
			private float _deltaTime_k__BackingField; // 0x50
			[CompilerGenerated]
			private int _clickCount_k__BackingField; // 0x54
			[CompilerGenerated]
			private float _pressure_k__BackingField; // 0x58
			[CompilerGenerated]
			private float _tangentialPressure_k__BackingField; // 0x5C
			[CompilerGenerated]
			private float _altitudeAngle_k__BackingField; // 0x60
			[CompilerGenerated]
			private float _azimuthAngle_k__BackingField; // 0x64
			[CompilerGenerated]
			private float _twist_k__BackingField; // 0x68
			[CompilerGenerated]
			private Vector2 _radius_k__BackingField; // 0x6C
			[CompilerGenerated]
			private Vector2 _radiusVariance_k__BackingField; // 0x74
			[CompilerGenerated]
			private EventModifiers _modifiers_k__BackingField; // 0x7C
	
			// Properties
			public int pointerId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
			public string pointerType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
			public bool isPrimary { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
			public int button { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
			public int pressedButtons { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
			public Vector3 position { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233AD0-0x0000000187233AF0 0x0000000187233B00-0x0000000187233B10
			public Vector3 localPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724C790-0x000000018724C7B0 0x000000018724BD80-0x000000018724BD90
			public Vector3 deltaPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723F3E0-0x000000018723F400 0x000000018723F400-0x000000018723F410
			public float deltaTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE90-0x000000018226EEA0 0x000000018226EF10-0x000000018226EF20
			public int clickCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
			public float pressure { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872353B0-0x00000001872353C0 0x00000001872353E0-0x00000001872353F0
			public float tangentialPressure { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001826DD0B0-0x00000001826DD0C0 0x00000001826DD0C0-0x00000001826DD0D0
			public float altitudeAngle { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872352B0-0x00000001872352C0 0x00000001872352D0-0x00000001872352E0
			public float azimuthAngle { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872352A0-0x00000001872352B0 0x00000001872352C0-0x00000001872352D0
			public float twist { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723CA40-0x000000018723CA50 0x000000018723CA70-0x000000018723CA80
			public Vector2 radius { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872641E0-0x0000000187264200 0x0000000187239E20-0x0000000187239E30
			public Vector2 radiusVariance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872641C0-0x00000001872641E0 0x0000000187264200-0x0000000187264210
			public EventModifiers modifiers { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872330E0-0x00000001872330F0 0x0000000187233140-0x0000000187233150
			public bool shiftKey { get; } // 0x000000018D6AB280-0x000000018D6AB288 
			public bool ctrlKey { get; } // 0x000000018D6AB278-0x000000018D6AB280 
			public bool commandKey { get; } // 0x000000018D6AB270-0x000000018D6AB278 
			public bool altKey { get; } // 0x000000018D6AB268-0x000000018D6AB270 
			public bool actionKey { get; } // 0x000000018D6AB234-0x000000018D6AB268 
	
			// Constructors
			public PointerEvent(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType); // 0x000000018D6AAD0C-0x000000018D6AB220
			public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride); // 0x0000000187264190-0x00000001872641C0
			[CompilerGenerated]
			internal static bool _Read_g__InRange_82_0(int i, int start, int count); // 0x000000018D6AB220-0x000000018D6AB234
		}
	
		// Constructors
		public PanelEventHandler(); // 0x000000018D6A905C-0x000000018D6A90F4
	
		// Methods
		protected override void OnEnable(); // 0x000000018D6A78F0-0x000000018D6A78F8
		protected override void OnDisable(); // 0x000000018D6A7854-0x000000018D6A785C
		private void RegisterCallbacks(); // 0x000000018D6A8800-0x000000018D6A89A8
		private void UnregisterCallbacks(); // 0x000000018D6A8DF4-0x000000018D6A8F9C
		private void OnPanelDestroyed(); // 0x000000018D6A79E0-0x000000018D6A79EC
		private void OnElementFocus(FocusEvent e); // 0x000000018D6A785C-0x000000018D6A78F0
		private void OnElementBlur(BlurEvent e); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnSelect(BaseEventData eventData); // 0x000000018D6A8220-0x000000018D6A82B8
		public void OnDeselect(BaseEventData eventData); // 0x000000018D6A7840-0x000000018D6A7854
		public void OnPointerMove(PointerEventData eventData); // 0x000000018D6A7E74-0x000000018D6A7F70
		public void OnPointerUp(PointerEventData eventData); // 0x000000018D6A7F70-0x000000018D6A80D0
		public void OnPointerDown(PointerEventData eventData); // 0x000000018D6A79EC-0x000000018D6A7BBC
		public void OnPointerExit(PointerEventData eventData); // 0x000000018D6A7C30-0x000000018D6A7E74
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018D6A7BBC-0x000000018D6A7C30
		public void OnSubmit(BaseEventData eventData); // 0x000000018D6A82B8-0x000000018D6A8390
		public void OnCancel(BaseEventData eventData); // 0x000000018D6A7768-0x000000018D6A7840
		public void OnMove(AxisEventData eventData); // 0x000000018D6A78F8-0x000000018D6A79E0
		public void OnScroll(PointerEventData eventData); // 0x000000018D6A80D0-0x000000018D6A8220
		private void SendEvent(EventBase e, BaseEventData sourceEventData); // 0x000000018D6A89A8-0x000000018D6A89F4
		private void SendEvent(EventBase e, UnityEngine.Event sourceEvent); // 0x000000018D6A89F4-0x000000018D6A8A44
		private void Update(); // 0x000000018D6A8F9C-0x000000018D6A905C
		private void LateUpdate(); // 0x000000018D6A775C-0x000000018D6A7768
		private void ProcessImguiEvents(bool isSelected); // 0x000000018D6A8390-0x000000018D6A84DC
		private void ProcessKeyboardEvent(UnityEngine.Event e); // 0x000000018D6A84DC-0x000000018D6A85D8
		private void ProcessTabEvent(UnityEngine.Event e); // 0x000000018D6A85D8-0x000000018D6A864C
		private void SendTabEvent(UnityEngine.Event e, int direction); // 0x000000018D6A8C2C-0x000000018D6A8CFC
		private void SendKeyUpEvent(UnityEngine.Event e, KeyCode keyCode, EventModifiers modifiers); // 0x000000018D6A8B38-0x000000018D6A8C2C
		private void SendKeyDownEvent(UnityEngine.Event e, KeyCode keyCode, EventModifiers modifiers); // 0x000000018D6A8A44-0x000000018D6A8B38
		private void SendTextEvent(UnityEngine.Event e, char c, EventModifiers modifiers); // 0x000000018D6A8CFC-0x000000018D6A8DF4
		private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = PointerEventType.Default /* Metadata: 0x02643C31 */); // 0x000000018D6A864C-0x000000018D6A8800
	}

	[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
	public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent // TypeDefIndex: 83779
	{
		// Fields
		private BaseRuntimePanel m_Panel; // 0x20
	
		// Properties
		public IPanel panel { get; set; } // 0x000000018225E800-0x000000018225E810 0x000000018D6A97CC-0x000000018D6A983C
		private GameObject selectableGameObject { get; } // 0x000000018D6A979C-0x000000018D6A97B0 
		public override int sortOrderPriority { get; } // 0x000000018D6A97B0-0x000000018D6A97CC 
		public override int renderOrderPriority { get; } // 0x000000018D6A9784-0x000000018D6A979C 
		public override Camera eventCamera { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Nested types
		private struct FloatIntBits // TypeDefIndex: 83778
		{
			// Fields
			public float f; // 0x00
			public int i; // 0x00
		}
	
		// Constructors
		public PanelRaycaster(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void RegisterCallbacks(); // 0x000000018D6A965C-0x000000018D6A96F0
		private void UnregisterCallbacks(); // 0x000000018D6A96F0-0x000000018D6A9784
		private void OnPanelDestroyed(); // 0x000000018D6A91C8-0x000000018D6A91D4
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018D6A91D4-0x000000018D6A965C
		private static int ConvertFloatBitsToInt(float f); // 0x00000001872413F0-0x0000000187241400
	}
}
