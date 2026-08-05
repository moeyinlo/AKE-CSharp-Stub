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

// Image 32: UnityEngine.UI.dll - Assembly: UnityEngine.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57267-57499
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright \u00A9 Microsoft 2013")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("guisystem")]
[assembly: AssemblyTitle("guisystem")]
[assembly: AssemblyTrademark("")]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("d4f464c7-9b15-460d-b4bc-2cacd1c1df73")]
[assembly: InternalsVisibleTo("UnityEngine.UI.Tests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 57499
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB; // 0x00 // Static value (base64): IAAuACwACQANAAoA - Metadata: 0x0234B11C

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 57498
	{
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 57268
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 57269
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Unity.Profiling
{
	[IsReadOnly]
	public struct ProfilerCounter<T> // TypeDefIndex: 57482
		where T : struct
	{
		// Constructors
		public ProfilerCounter(ProfilerCategory category, string name, ProfilerMarkerDataUnit dataUnit);
	
		// Methods
		[Conditional("ENABLE_PROFILER")]
		public void Sample(T value);
	}

	[IsReadOnly]
	public struct ProfilerCounterValue<T> // TypeDefIndex: 57483
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
	public struct ProfilerMarker<TP1> // TypeDefIndex: 57485
		where TP1 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 57484
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
	public struct ProfilerMarker<TP1, TP2> // TypeDefIndex: 57487
		where TP1 : struct
		where TP2 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 57486
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
	public struct ProfilerMarker<TP1, TP2, TP3> // TypeDefIndex: 57489
		where TP1 : struct
		where TP2 : struct
		where TP3 : struct
	{
		// Nested types
		[IsReadOnly]
		public struct AutoScope : IDisposable // TypeDefIndex: 57488
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

	public static class ProfilerMarkerExtension // TypeDefIndex: 57491
	{
		// Nested types
		[IsReadOnly]
		public struct ProfilerMarkerScope : IDisposable // TypeDefIndex: 57490
		{
			// Constructors
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, int context); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, float context); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, string context); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, string context, string context2); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context, string context2); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, long context, long context2); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, UnityEngine.Object obj); // 0x00000001841E1670-0x00000001841E1680
			public ProfilerMarkerScope([IsReadOnly] in ProfilerMarker marker, Transform transform, bool path); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Extension methods
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, int metadata); // 0x000000018B582C80-0x000000018B582CF4
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, uint metadata); // 0x000000018B58314C-0x000000018B5831C0
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata); // 0x000000018B58305C-0x000000018B5830D4
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, ulong metadata); // 0x000000018B5830D4-0x000000018B58314C
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, float metadata); // 0x000000018B582E34-0x000000018B582EAC
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, double metadata); // 0x000000018B582CF4-0x000000018B582D6C
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, string metadata); // 0x000000018B582C2C-0x000000018B582C80
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, string metadata, string metadata2); // 0x000000018B582EAC-0x000000018B582F84
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata, string metadata2); // 0x000000018B582F84-0x000000018B58305C
		[Conditional("ENABLE_PROFILER")]
		public static void Begin(this ProfilerMarker marker, long metadata, long metadata2); // 0x000000018B582D6C-0x000000018B582E34
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker); // 0x00000001812081B0-0x0000000181208610
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, int context); // 0x0000000184DBF390-0x0000000184DBF3A0
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context); // 0x0000000184DBF390-0x0000000184DBF3A0
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, float context); // 0x0000000184DBF390-0x0000000184DBF3A0
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, string context); // 0x0000000184DBF390-0x0000000184DBF3A0
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, string context, string context2); // 0x0000000184DBF380-0x0000000184DBF390
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context, string context2); // 0x0000000184DBF380-0x0000000184DBF390
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, long context, long context2); // 0x0000000184DBF380-0x0000000184DBF390
		public static ProfilerMarkerScope Scope(this ProfilerMarker marker, Transform transform, bool path = false /* Metadata: 0x0234B111 */); // 0x0000000184DBF380-0x0000000184DBF390
	}

	public struct MonoObject_64 // TypeDefIndex: 57492
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x08
	}

	public struct MonoObject_32 // TypeDefIndex: 57493
	{
		// Fields
		public unsafe void* p1; // 0x00
		public unsafe void* p2; // 0x04
	}

	public struct MonoString_64 // TypeDefIndex: 57494
	{
		// Fields
		public MonoObject_64 obj; // 0x00
		public int length; // 0x10
		public char firstChar; // 0x14
	}

	public struct MonoString_32 // TypeDefIndex: 57495
	{
		// Fields
		public MonoObject_32 obj; // 0x00
		public int length; // 0x08
		public char firstChar; // 0x0C
	}

	public class ProfilerString : IDisposable // TypeDefIndex: 57496
	{
		// Fields
		private const int MAX = 256; // Metadata: 0x0234B114
		private string m_buffer; // 0x10
		private int m_length; // 0x18
		private unsafe int* m_strCount; // 0x20
		private ulong m_handler; // 0x28
	
		// Constructors
		public ProfilerString(int count = 256 /* Metadata: 0x0234B112 */); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
		public override string ToString(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		public static implicit operator string(ProfilerString handle); // 0x000000018B5834BC-0x000000018B5834DC
		public void Append(string value); // 0x000000018B5833D4-0x000000018B5834BC
	}

	internal struct ProfilerUtility // TypeDefIndex: 57497
	{
		// Methods
		public static byte GetProfilerMarkerDataType<T>();
	}
}

namespace UnityEngine.EventSystems
{
	public class AxisEventData : BaseEventData // TypeDefIndex: 57427
	{
		// Fields
		[CompilerGenerated]
		private Vector2 _moveVector_k__BackingField; // 0x20
		[CompilerGenerated]
		private MoveDirection _moveDir_k__BackingField; // 0x28
	
		// Properties
		public Vector2 moveVector { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA5EA0-0x0000000184DA5EC0 0x0000000184D86500-0x0000000184D86510
		public MoveDirection moveDir { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
	
		// Constructors
		public AxisEventData(EventSystem eventSystem); // 0x000000018B57B33C-0x000000018B57B364
	}

	public abstract class AbstractEventData // TypeDefIndex: 57428
	{
		// Fields
		protected bool m_Used; // 0x10
	
		// Properties
		public virtual bool used { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
	
		// Constructors
		protected AbstractEventData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public virtual void Reset(); // 0x0000000184D8CCB0-0x0000000184D8CCC0
		public virtual void Use(); // 0x00000001815EFCD0-0x00000001815EFCE0
	}

	public class BaseEventData : AbstractEventData // TypeDefIndex: 57429
	{
		// Fields
		private readonly EventSystem m_EventSystem; // 0x18
	
		// Properties
		public BaseInputModule currentInputModule { get; } // 0x000000018A8DA4B4-0x000000018A8DA4D0 
		public GameObject selectedObject { get; set; } // 0x000000018A8DA594-0x000000018A8DA5B0 0x000000018B57B364-0x000000018B57B38C
	
		// Constructors
		public BaseEventData(EventSystem eventSystem); // 0x0000000185392C40-0x0000000185392C50
	}

	public class PointerEventData : BaseEventData // TypeDefIndex: 57432
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
		public GameObject pointerEnter { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public GameObject lastPress { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public GameObject rawPointerPress { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public GameObject pointerDrag { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public GameObject pointerClick { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public RaycastResult pointerCurrentRaycast { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF160-0x0000000184DBF1A0 0x000000018B5811E4-0x000000018B58121C
		public RaycastResult pointerPressRaycast { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF1A0-0x0000000184DBF1E0 0x000000018B58121C-0x000000018B581260
		public bool eligibleForClick { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8C8C0-0x0000000184D8C8D0 0x0000000184D8C8F0-0x0000000184D8C900
		public int pointerId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D9DF40-0x0000000184D9DF50 0x0000000184D9E020-0x0000000184D9E030
		public Vector2 position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8E090-0x0000000184D8E0B0 0x0000000184D8E0B0-0x0000000184D8E0C0
		public Vector2 delta { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF130-0x0000000184DBF150 0x0000000184DBF270-0x0000000184DBF280
		public Vector2 pressPosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF1E0-0x0000000184DBF200 0x0000000184DBF2A0-0x0000000184DBF2B0
		[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
		public Vector3 worldPosition { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D91A30-0x0000000184D91A50 0x0000000184D91A70-0x0000000184D91A90
		[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
		public Vector3 worldNormal { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D90F70-0x0000000184D90F90 0x0000000184D90FF0-0x0000000184D91010
		public float clickTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBD7E0-0x0000000184DBD7F0 0x0000000184DBD820-0x0000000184DBD830
		public int clickCount { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D90A80-0x0000000184D90A90 0x0000000184D90AB0-0x0000000184D90AC0
		public Vector2 scrollDelta { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF240-0x0000000184DBF260 0x0000000184DA14B0-0x0000000184DA14C0
		public bool useDragThreshold { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D92620-0x0000000184D92630 0x0000000184D92640-0x0000000184D92650
		public bool dragging { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF150-0x0000000184DBF160 0x0000000184DBF280-0x0000000184DBF290
		public InputButton button { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA3240-0x0000000184DA3250 0x0000000184DBDA30-0x0000000184DBDA40
		public float pressure { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA3250-0x0000000184DA3260 0x0000000184DBF2B0-0x0000000184DBF2C0
		public float tangentialPressure { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA7940-0x0000000184DA7950 0x0000000184DBC020-0x0000000184DBC030
		public float altitudeAngle { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8E180-0x0000000184D8E190 0x0000000184D8E1D0-0x0000000184D8E1E0
		public float azimuthAngle { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF120-0x0000000184DBF130 0x0000000184DBF260-0x0000000184DBF270
		public float twist { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D90E70-0x0000000184D90E80 0x0000000184D90E80-0x0000000184D90E90
		public Vector2 radius { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF220-0x0000000184DBF240 0x0000000184DBF2D0-0x0000000184DBF2E0
		public Vector2 radiusVariance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DBF200-0x0000000184DBF220 0x0000000184DBF2C0-0x0000000184DBF2D0
		public bool fullyExited { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA7930-0x0000000184DA7940 0x0000000184DBF290-0x0000000184DBF2A0
		public bool reentered { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA7C60-0x0000000184DA7C70 0x0000000184DBF2E0-0x0000000184DBF2F0
		public Camera enterEventCamera { get; } // 0x000000018B5810D8-0x000000018B58115C 
		public Camera pressEventCamera { get; } // 0x000000018B58115C-0x000000018B5811E4 
		public GameObject pointerPress { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x00000001833F30B0-0x00000001833F31A0
	
		// Nested types
		public enum InputButton // TypeDefIndex: 57430
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		public enum FramePressState // TypeDefIndex: 57431
		{
			Pressed = 0,
			Released = 1,
			PressedAndReleased = 2,
			NotChanged = 3
		}
	
		// Constructors
		public PointerEventData(EventSystem eventSystem); // 0x0000000183E9B9B0-0x0000000183E9BAC0
	
		// Methods
		public bool IsPointerMoving(); // 0x00000001833F2A80-0x00000001833F2AB0
		public bool IsScrolling(); // 0x000000018B580B40-0x000000018B580B68
		public override string ToString(); // 0x000000018B580B68-0x000000018B5810D8
	}

	[Flags]
	public enum EventHandle // TypeDefIndex: 57433
	{
		Unused = 0,
		Used = 1
	}

	public interface IEventSystemHandler // TypeDefIndex: 57434
	{
	}

	public interface IPointerMoveHandler : IEventSystemHandler // TypeDefIndex: 57435
	{
		// Methods
		void OnPointerMove(PointerEventData eventData);
	}

	public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 57436
	{
		// Methods
		void OnPointerEnter(PointerEventData eventData);
	}

	public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 57437
	{
		// Methods
		void OnPointerExit(PointerEventData eventData);
	}

	public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 57438
	{
		// Methods
		void OnPointerDown(PointerEventData eventData);
	}

	public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 57439
	{
		// Methods
		void OnPointerUp(PointerEventData eventData);
	}

	public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 57440
	{
		// Methods
		void OnPointerClick(PointerEventData eventData);
	}

	public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 57441
	{
		// Methods
		void OnBeginDrag(PointerEventData eventData);
	}

	public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 57442
	{
		// Methods
		void OnInitializePotentialDrag(PointerEventData eventData);
	}

	public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 57443
	{
		// Methods
		void OnDrag(PointerEventData eventData);
	}

	public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 57444
	{
		// Methods
		void OnEndDrag(PointerEventData eventData);
	}

	public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 57445
	{
		// Methods
		void OnDrop(PointerEventData eventData);
	}

	public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 57446
	{
		// Methods
		void OnScroll(PointerEventData eventData);
	}

	public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 57447
	{
		// Methods
		void OnUpdateSelected(BaseEventData eventData);
	}

	public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 57448
	{
		// Methods
		void OnSelect(BaseEventData eventData);
	}

	public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 57449
	{
		// Methods
		void OnDeselect(BaseEventData eventData);
	}

	public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 57450
	{
		// Methods
		void OnMove(AxisEventData eventData);
	}

	public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 57451
	{
		// Methods
		void OnSubmit(BaseEventData eventData);
	}

	public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 57452
	{
		// Methods
		void OnCancel(BaseEventData eventData);
	}

	[AddComponentMenu("Event/Event System")]
	[DisallowMultipleComponent]
	public class EventSystem : UIBehaviour // TypeDefIndex: 57456
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
		public static EventSystem current { get; set; } // 0x0000000183795B00-0x0000000183795BA0 0x000000018B57C964-0x000000018B57CAC0
		public bool sendNavigationEvents { get; set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
		public int pixelDragThreshold { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public BaseInputModule currentInputModule { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public GameObject firstSelectedGameObject { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public GameObject currentSelectedGameObject { get; } // 0x0000000184D85A50-0x0000000184D85A60 
		[Obsolete("lastSelectedGameObject is no longer supported")]
		public GameObject lastSelectedGameObject { get; } // 0x00000001811EC580-0x00000001811EC590 
		public bool isFocused { get; } // 0x0000000182D480A0-0x0000000182D480B0 
		public bool alreadySelecting { get; } // 0x0000000184D86F40-0x0000000184D86F50 
		private BaseEventData baseEventDataCache { get; } // 0x000000018B57C8F0-0x000000018B57C964 
		private bool isUIToolkitActiveEventSystem { get; } // 0x0000000184648650-0x0000000184648760 
		private bool sendUIToolkitEvents { get; } // 0x0000000184647B00-0x0000000184647B70 
		private bool createUIToolkitPanelGameObjectsOnStart { get; } // 0x0000000184648500-0x0000000184648570 
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 57453
		{
			// Fields
			public static readonly ProfilerMarker Update; // 0x00
			public static readonly ProfilerMarker TickModules; // 0x08
			public static readonly ProfilerMarker CurrentModuleProcess; // 0x10
			public static readonly ProfilerMarker RaycastAll; // 0x18
			public static readonly ProfilerMarker RaycastAllSort; // 0x20
	
			// Constructors
			static ProfilerMarkers(); // 0x0000000184B1D7A0-0x0000000184B1D8F0
		}
	
		private struct UIToolkitOverrideConfig // TypeDefIndex: 57454
		{
			// Fields
			public EventSystem activeEventSystem; // 0x00
			public bool sendEvents; // 0x08
			public bool createPanelGameObjectsOnStart; // 0x09
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 57455
		{
			// Fields
			public GameObject go; // 0x10
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CreateUIToolkitPanelGameObject_b__0(); // 0x000000018B588900-0x000000018B588950
		}
	
		// Constructors
		protected EventSystem(); // 0x0000000184D12950-0x0000000184D129F0
		static EventSystem(); // 0x0000000184B20F90-0x0000000184B210E0
	
		// Methods
		public void UpdateModules(); // 0x0000000183DFA5D0-0x0000000183DFA6E0
		public void SetSelectedGameObject(GameObject selected, BaseEventData pointer); // 0x0000000183E9A200-0x0000000183E9A360
		public void SetSelectedGameObject(GameObject selected); // 0x000000018B57C648-0x000000018B57C67C
		private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs); // 0x000000018389F8B0-0x000000018389FCC0
		public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults); // 0x0000000182FC7540-0x0000000182FC7830
		public bool IsPointerOverGameObject(); // 0x000000018B57C4C0-0x000000018B57C4D0
		public bool IsPointerOverGameObject(int pointerId); // 0x000000018B57C440-0x000000018B57C4C0
		public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true /* Metadata: 0x0234B0F2 */, bool createPanelGameObjectsOnStart = true /* Metadata: 0x0234B0F3 */); // 0x000000018B57C67C-0x000000018B57C7C0
		private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel); // 0x000000018B57C200-0x000000018B57C440
		protected override void Start(); // 0x0000000184647B70-0x0000000184648460
		protected override void OnDestroy(); // 0x000000018B57C4D0-0x000000018B57C560
		protected override void OnEnable(); // 0x0000000184647A40-0x0000000184647B00
		protected override void OnDisable(); // 0x000000018B57C560-0x000000018B57C648
		private void TickModules(); // 0x0000000183795770-0x0000000183795980
		protected virtual void OnApplicationFocus(bool hasFocus); // 0x0000000183F26150-0x0000000183F26170
		protected virtual void Update(); // 0x00000001837952F0-0x0000000183795770
		private void ChangeEventModule(BaseInputModule module); // 0x0000000184CB05B0-0x0000000184CB06F0
		public override string ToString(); // 0x000000018B57C7C0-0x000000018B57C8F0
	}

	[AddComponentMenu("Event/Event Trigger")]
	public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, UnityEngine.EventSystems.IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 57459
	{
		// Fields
		[FormerlySerializedAs("delegates")]
		[SerializeField]
		private List<Entry> m_Delegates; // 0x18
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", true)]
		public List<Entry> delegates { get; set; } // 0x000000018B57CCB8-0x000000018B57CCC0 0x0000000185392C40-0x0000000185392C50
		public List<Entry> triggers { get; set; } // 0x000000018B57CCC0-0x000000018B57CD44 0x0000000185392C40-0x0000000185392C50
	
		// Nested types
		[Serializable]
		public class TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 57457
		{
			// Constructors
			public TriggerEvent(); // 0x000000018B5888C4-0x000000018B588900
		}
	
		[Serializable]
		public class Entry // TypeDefIndex: 57458
		{
			// Fields
			public EventTriggerType eventID; // 0x10
			public TriggerEvent callback; // 0x18
	
			// Constructors
			public Entry(); // 0x000000018B57C194-0x000000018B57C200
		}
	
		// Constructors
		protected EventTrigger(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Execute(EventTriggerType id, BaseEventData eventData); // 0x000000018B57CAC0-0x000000018B57CBA8
		public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018B57CC48-0x000000018B57CC58
		public virtual void OnPointerExit(PointerEventData eventData); // 0x000000018B57CC58-0x000000018B57CC68
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018B57CBD8-0x000000018B57CBE8
		public virtual void OnDrop(PointerEventData eventData); // 0x000000018B57CBE8-0x000000018B57CBF8
		public virtual void OnPointerDown(PointerEventData eventData); // 0x000000018B57CC38-0x000000018B57CC48
		public virtual void OnPointerUp(PointerEventData eventData); // 0x000000018B57CC68-0x000000018B57CC78
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018B57CC28-0x000000018B57CC38
		public virtual void OnSelect(BaseEventData eventData); // 0x000000018B57CC88-0x000000018B57CC98
		public virtual void OnDeselect(BaseEventData eventData); // 0x000000018B57CBC8-0x000000018B57CBD8
		public virtual void OnScroll(PointerEventData eventData); // 0x000000018B57CC78-0x000000018B57CC88
		public virtual void OnMove(AxisEventData eventData); // 0x000000018B57CC18-0x000000018B57CC28
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x000000018B57CCA8-0x000000018B57CCB8
		public virtual void OnInitializePotentialDrag(PointerEventData eventData); // 0x000000018B57CC08-0x000000018B57CC18
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018B57CBA8-0x000000018B57CBB8
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018B57CBF8-0x000000018B57CC08
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018B57CC98-0x000000018B57CCA8
		public virtual void OnCancel(BaseEventData eventData); // 0x000000018B57CBB8-0x000000018B57CBC8
	}

	public enum EventTriggerType // TypeDefIndex: 57460
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

	public static class ExecuteEvents // TypeDefIndex: 57462
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
		public static EventFunction<IPointerMoveHandler> pointerMoveHandler { get; } // 0x000000018B57D3E4-0x000000018B57D418 
		public static EventFunction<IPointerEnterHandler> pointerEnterHandler { get; } // 0x000000018B57D37C-0x000000018B57D3B0 
		public static EventFunction<IPointerExitHandler> pointerExitHandler { get; } // 0x000000018B57D3B0-0x000000018B57D3E4 
		public static EventFunction<IPointerDownHandler> pointerDownHandler { get; } // 0x000000018B57D348-0x000000018B57D37C 
		public static EventFunction<IPointerUpHandler> pointerUpHandler { get; } // 0x000000018B57D418-0x000000018B57D44C 
		public static EventFunction<IPointerClickHandler> pointerClickHandler { get; } // 0x000000018B57D314-0x000000018B57D348 
		public static EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; } // 0x000000018B57D274-0x000000018B57D2C4 
		public static EventFunction<IBeginDragHandler> beginDragHandler { get; } // 0x000000018B57D0AC-0x000000018B57D0FC 
		public static EventFunction<IDragHandler> dragHandler { get; } // 0x000000018B57D1A0-0x000000018B57D1D4 
		public static EventFunction<IEndDragHandler> endDragHandler { get; } // 0x000000018B57D224-0x000000018B57D274 
		public static EventFunction<IDropHandler> dropHandler { get; } // 0x000000018B57D1D4-0x000000018B57D224 
		public static EventFunction<UnityEngine.EventSystems.IScrollHandler> scrollHandler { get; } // 0x000000018B57D44C-0x000000018B57D49C 
		public static EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; } // 0x000000018B57D540-0x000000018B57D574 
		public static EventFunction<ISelectHandler> selectHandler { get; } // 0x000000018B57D49C-0x000000018B57D4EC 
		public static EventFunction<IDeselectHandler> deselectHandler { get; } // 0x000000018B57D150-0x000000018B57D1A0 
		public static EventFunction<IMoveHandler> moveHandler { get; } // 0x000000018B57D2C4-0x000000018B57D314 
		public static EventFunction<ISubmitHandler> submitHandler { get; } // 0x000000018B57D4EC-0x000000018B57D540 
		public static EventFunction<ICancelHandler> cancelHandler { get; } // 0x000000018B57D0FC-0x000000018B57D150 
	
		// Nested types
		public delegate void EventFunction<T1>(T1 handler, BaseEventData eventData); // TypeDefIndex: 57461; 0x00000000-0x00000000
	
		// Constructors
		static ExecuteEvents(); // 0x000000018468AC20-0x000000018468B470
	
		// Methods
		public static T ValidateEventData<T>(BaseEventData data)
			where T : class;
		private static void Execute(IPointerMoveHandler handler, BaseEventData eventData); // 0x000000018B57CEA4-0x000000018B57CF40
		private static void Execute(IPointerEnterHandler handler, BaseEventData eventData); // 0x000000018379AE30-0x000000018379B050
		private static void Execute(IPointerExitHandler handler, BaseEventData eventData); // 0x000000018379ADD0-0x000000018379AE30
		private static void Execute(IPointerDownHandler handler, BaseEventData eventData); // 0x000000018379AD10-0x000000018379AD70
		private static void Execute(IPointerUpHandler handler, BaseEventData eventData); // 0x000000018379AD70-0x000000018379ADD0
		private static void Execute(IPointerClickHandler handler, BaseEventData eventData); // 0x000000018379ACB0-0x000000018379AD10
		private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData); // 0x0000000184A26280-0x0000000184A26320
		private static void Execute(IBeginDragHandler handler, BaseEventData eventData); // 0x00000001837D64A0-0x00000001837D6540
		private static void Execute(IDragHandler handler, BaseEventData eventData); // 0x00000001837D6750-0x00000001837D67E0
		private static void Execute(IEndDragHandler handler, BaseEventData eventData); // 0x00000001837D6540-0x00000001837D65E0
		private static void Execute(IDropHandler handler, BaseEventData eventData); // 0x000000018B57CF58-0x000000018B57D038
		private static void Execute(UnityEngine.EventSystems.IScrollHandler handler, BaseEventData eventData); // 0x000000018B57CD44-0x000000018B57CDB8
		private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData); // 0x0000000183798760-0x00000001837987D0
		private static void Execute(ISelectHandler handler, BaseEventData eventData); // 0x0000000184CA2A10-0x0000000184CA2A60
		private static void Execute(IDeselectHandler handler, BaseEventData eventData); // 0x0000000184B6C870-0x0000000184B6C8C0
		private static void Execute(IMoveHandler handler, BaseEventData eventData); // 0x000000018B57D038-0x000000018B57D0AC
		private static void Execute(ISubmitHandler handler, BaseEventData eventData); // 0x000000018B57CF40-0x000000018B57CF58
		private static void Execute(ICancelHandler handler, BaseEventData eventData); // 0x000000018B57CDB8-0x000000018B57CEA4
		private static void GetEventChain(GameObject root, IList<Transform> eventChain); // 0x00000001841AEF30-0x00000001841AF060
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

	public class BaseInput : UIBehaviour // TypeDefIndex: 57463
	{
		// Properties
		public virtual string compositionString { get; } // 0x0000000184118260-0x0000000184118270 
		public virtual IMECompositionMode imeCompositionMode { get; set; } // 0x000000018B57BC94-0x000000018B57BC9C 0x000000018539555C-0x0000000185395568
		public virtual Vector2 compositionCursorPos { get; set; } // 0x000000018B57BC8C-0x000000018B57BC94 0x000000018B57BCD4-0x000000018B57BCF0
		public virtual bool mousePresent { get; } // 0x000000018B47AE10-0x000000018B47AE18 
		public virtual Vector2 mousePosition { get; } // 0x000000018B57BC9C-0x000000018B57BCC4 
		public virtual Vector2 mouseScrollDelta { get; } // 0x000000018B57BCC4-0x000000018B57BCCC 
		public virtual bool touchSupported { get; } // 0x000000018B57BCCC-0x000000018B57BCD4 
		public virtual int touchCount { get; } // 0x0000000189F48384-0x0000000189F4838C 
	
		// Constructors
		public BaseInput(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public virtual bool GetMouseButtonDown(int button); // 0x000000018B57BC68-0x000000018B57BC74
		public virtual bool GetMouseButtonUp(int button); // 0x000000018B57BC74-0x000000018B57BC80
		public virtual bool GetMouseButton(int button); // 0x000000018B57BC80-0x000000018B57BC8C
		public virtual Touch GetTouch(int index); // 0x000000018AA1FDE0-0x000000018AA1FE28
		public virtual float GetAxisRaw(string axisName); // 0x000000018B57BC5C-0x000000018B57BC68
		public virtual bool GetButtonDown(string buttonName); // 0x000000018B47AE04-0x000000018B47AE10
	}

	[RequireComponent(typeof(EventSystem))]
	public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 57464
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
		public BaseInput input { get; } // 0x0000000183795BA0-0x0000000183795D60 
		public BaseInput inputOverride { get; set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		protected EventSystem eventSystem { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Constructors
		protected BaseInputModule(); // 0x000000018445D4D0-0x000000018445D560
	
		// Methods
		protected override void OnEnable(); // 0x0000000183DFA850-0x0000000183DFA8B0
		protected override void OnDisable(); // 0x000000018B57BC3C-0x000000018B57BC5C
		public abstract void Process();
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates); // 0x00000001833F34A0-0x00000001833F3630
		protected static MoveDirection DetermineMoveDirection(float x, float y); // 0x000000018B57B478-0x000000018B57B488
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone); // 0x000000018B57B408-0x000000018B57B478
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2); // 0x0000000183F32D60-0x0000000183F32FB0
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget); // 0x000000018B57B570-0x000000018B57BC3C
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone); // 0x000000018B57B488-0x000000018B57B570
		protected virtual BaseEventData GetBaseEventData(); // 0x0000000183E9A450-0x0000000183E9A4C0
		public virtual bool IsPointerOverGameObject(int pointerId); // 0x00000001812081B0-0x0000000181208610
		public virtual bool ShouldActivateModule(); // 0x0000000183E148A0-0x0000000183E14910
		public virtual void DeactivateModule(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void ActivateModule(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void UpdateModule(); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool IsModuleSupported(); // 0x0000000182FFF600-0x0000000182FFF610
		public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData); // 0x000000018B57B38C-0x000000018B57B408
	}

	public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 57468
	{
		// Fields
		public const int kMouseLeftId = -1; // Metadata: 0x0234B105
		public const int kMouseRightId = -2; // Metadata: 0x0234B106
		public const int kMouseMiddleId = -3; // Metadata: 0x0234B107
		public const int kFakeTouchesId = -4; // Metadata: 0x0234B108
		protected Dictionary<int, PointerEventData> m_PointerData; // 0x48
		private readonly MouseState m_MouseState; // 0x50
	
		// Nested types
		protected class ButtonState // TypeDefIndex: 57465
		{
			// Fields
			private PointerEventData.InputButton m_Button; // 0x10
			private MouseButtonEventData m_EventData; // 0x18
	
			// Properties
			public MouseButtonEventData eventData { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public PointerEventData.InputButton button { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
	
			// Constructors
			public ButtonState(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		protected class MouseState // TypeDefIndex: 57466
		{
			// Fields
			private List<ButtonState> m_TrackedButtons; // 0x10
	
			// Constructors
			public MouseState(); // 0x000000018B57D974-0x000000018B57D9EC
	
			// Methods
			public bool AnyPressesThisFrame(); // 0x000000018B57D6AC-0x000000018B57D74C
			public bool AnyReleasesThisFrame(); // 0x000000018B57D74C-0x000000018B57D7EC
			public ButtonState GetButtonState(PointerEventData.InputButton button); // 0x000000018B57D7EC-0x000000018B57D924
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data); // 0x000000018B57D924-0x000000018B57D974
		}
	
		public class MouseButtonEventData // TypeDefIndex: 57467
		{
			// Fields
			public PointerEventData.FramePressState buttonState; // 0x10
			public PointerEventData buttonData; // 0x18
	
			// Constructors
			public MouseButtonEventData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool PressedThisFrame(); // 0x000000018A9CB864-0x000000018A9CB878
			public bool ReleasedThisFrame(); // 0x000000018863E6DC-0x000000018863E6F0
		}
	
		// Constructors
		protected PointerInputModule(); // 0x000000018B582A78-0x000000018B582B30
	
		// Methods
		protected bool GetPointerData(int id, out PointerEventData data, bool create); // 0x000000018B581FF4-0x000000018B5820E8
		protected void RemovePointerData(PointerEventData data); // 0x000000018B582710-0x000000018B58276C
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released); // 0x000000018B5820E8-0x000000018B58243C
		protected void CopyFromTo(PointerEventData from, PointerEventData to); // 0x000000018B58198C-0x000000018B581B0C
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId); // 0x000000018B58276C-0x000000018B5827E4
		protected virtual MouseState GetMousePointerEventData(); // 0x000000018B581C00-0x000000018B581C0C
		protected virtual MouseState GetMousePointerEventData(int id); // 0x000000018B581C0C-0x000000018B581FF4
		protected PointerEventData GetLastPointerEventData(int id); // 0x000000018B581BD8-0x000000018B581C00
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold); // 0x000000018A9CED1C-0x000000018A9CED5C
		protected virtual void ProcessMove(PointerEventData pointerEvent); // 0x000000018B5826C4-0x000000018B582710
		protected virtual void ProcessDrag(PointerEventData pointerEvent); // 0x000000018B5824A4-0x000000018B5826C4
		public override bool IsPointerOverGameObject(int pointerId); // 0x000000018B58243C-0x000000018B5824A4
		protected void ClearSelection(); // 0x000000018B5817DC-0x000000018B58198C
		public override string ToString(); // 0x000000018B5827E4-0x000000018B582A78
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent); // 0x000000018B581B0C-0x000000018B581BD8
	}

	[AddComponentMenu("Event/Standalone Input Module")]
	public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 57471
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
		public InputMode inputMode { get; } // 0x00000001811EC580-0x00000001811EC590 
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		public bool allowActivationOnMobileDevice { get; set; } // 0x0000000184D88CC0-0x0000000184D88CD0 0x0000000184D88D20-0x0000000184D88D30
		[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
		public bool forceModuleActive { get; set; } // 0x0000000184D88CC0-0x0000000184D88CD0 0x0000000184D88D20-0x0000000184D88D30
		public float inputActionsPerSecond { get; set; } // 0x0000000184D8E650-0x0000000184D8E660 0x0000000184D8E680-0x0000000184D8E690
		public float repeatDelay { get; set; } // 0x0000000184D8E660-0x0000000184D8E670 0x0000000184D8E690-0x0000000184D8E6A0
		public string horizontalAxis { get; set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
		public string verticalAxis { get; set; } // 0x0000000184D86220-0x0000000184D86230 0x0000000186402330-0x0000000186402344
		public string submitButton { get; set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public string cancelButton { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x0000000185391334-0x0000000185391348
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 57469
		{
			// Fields
			public static readonly ProfilerMarker Process; // 0x00
			public static readonly ProfilerMarker ProcessMouseEvent; // 0x08
			public static readonly ProfilerMarker ProcessMousePress; // 0x10
			public static readonly ProfilerMarker ProcessTouchEvents; // 0x18
			public static readonly ProfilerMarker ProcessTouchPress; // 0x20
	
			// Constructors
			static ProfilerMarkers(); // 0x000000018B583294-0x000000018B5833D4
		}
	
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode // TypeDefIndex: 57470
		{
			Mouse = 0,
			Buttons = 1
		}
	
		// Constructors
		protected StandaloneInputModule(); // 0x000000018B586BD8-0x000000018B586CAC
	
		// Methods
		private bool ShouldIgnoreEventsOnNoFocus(); // 0x0000000182FFF600-0x0000000182FFF610
		public override void UpdateModule(); // 0x000000018B586AC4-0x000000018B586BD8
		private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo); // 0x000000018B5861EC-0x000000018B586468
		public override bool ShouldActivateModule(); // 0x000000018B5868A8-0x000000018B586AC4
		public override void ActivateModule(); // 0x000000018B58407C-0x000000018B5841A4
		public override void DeactivateModule(); // 0x000000018B5841A4-0x000000018B5841AC
		public override void Process(); // 0x000000018B586094-0x000000018B5861EC
		private bool ProcessTouchEvents(); // 0x000000018B584ACC-0x000000018B584D08
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x000000018B584D08-0x000000018B586094
		protected bool SendSubmitEventToSelectedObject(); // 0x000000018B586670-0x000000018B5867D4
		private Vector2 GetRawMoveVector(); // 0x000000018B5841AC-0x000000018B5842B0
		protected bool SendMoveEventToSelectedObject(); // 0x000000018B586468-0x000000018B586670
		protected void ProcessMouseEvent(); // 0x000000018B584518-0x000000018B5845E0
		[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
		protected virtual bool ForceAutoSelect(); // 0x00000001812081B0-0x0000000181208610
		protected void ProcessMouseEvent(int id); // 0x000000018B5842B0-0x000000018B584518
		protected bool SendUpdateEventToSelectedObject(); // 0x000000018B5867D4-0x000000018B5868A8
		protected void ProcessMousePress(MouseButtonEventData data); // 0x000000018B5845E0-0x000000018B584ACC
		protected GameObject GetCurrentFocusedGameObject(); // 0x0000000184D862A0-0x0000000184D862B0
	}

	[AddComponentMenu("Event/Touch Input Module")]
	[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
	public class TouchInputModule : PointerInputModule // TypeDefIndex: 57473
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
		public bool allowActivationOnStandalone { get; set; } // 0x0000000184D86A50-0x0000000184D86A60 0x0000000184D86A80-0x0000000184D86A90
		public bool forceModuleActive { get; set; } // 0x0000000184D86A50-0x0000000184D86A60 0x0000000184D86A80-0x0000000184D86A90
	
		// Nested types
		private static class ProfilerMarkers // TypeDefIndex: 57472
		{
			// Fields
			public static readonly ProfilerMarker Process; // 0x00
			public static readonly ProfilerMarker ProcessTouchEvents; // 0x08
			public static readonly ProfilerMarker ProcessTouchPress; // 0x10
	
			// Constructors
			static ProfilerMarkers(); // 0x000000018B5831C0-0x000000018B583294
		}
	
		// Constructors
		protected TouchInputModule(); // 0x000000018B5888BC-0x000000018B5888C4
	
		// Methods
		public override void UpdateModule(); // 0x000000018B588764-0x000000018B588898
		public override bool IsModuleSupported(); // 0x000000018B586D9C-0x000000018B586DCC
		public override bool ShouldActivateModule(); // 0x000000018B588410-0x000000018B5884E8
		private bool UseFakeInput(); // 0x000000018B588898-0x000000018B5888BC
		public override void Process(); // 0x000000018B58832C-0x000000018B588410
		private void FakeTouches(); // 0x000000018B586CAC-0x000000018B586D9C
		private void ProcessTouchEvents(); // 0x000000018B586DCC-0x000000018B586FE0
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released); // 0x000000018B586FE0-0x000000018B58832C
		public override void DeactivateModule(); // 0x000000018B5841A4-0x000000018B5841AC
		public override string ToString(); // 0x000000018B5884E8-0x000000018B588764
	}

	public enum MoveDirection // TypeDefIndex: 57474
	{
		Left = 0,
		Up = 1,
		Right = 2,
		Down = 3,
		None = 4
	}

	internal static class RaycasterManager // TypeDefIndex: 57475
	{
		// Fields
		private static readonly List<BaseRaycaster> s_Raycasters; // 0x00
	
		// Constructors
		static RaycasterManager(); // 0x0000000184D171C0-0x0000000184D17250
	
		// Methods
		public static void AddRaycaster(BaseRaycaster baseRaycaster); // 0x00000001840DD360-0x00000001840DD400
		public static List<BaseRaycaster> GetRaycasters(); // 0x000000018B583A58-0x000000018B583A8C
		public static void RemoveRaycasters(BaseRaycaster baseRaycaster); // 0x00000001840DD290-0x00000001840DD330
	}

	public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 57476
	{
		// Fields
		private BaseRaycaster m_RootRaycaster; // 0x18
	
		// Properties
		public abstract Camera eventCamera { get; }
		[Obsolete("Please use sortOrderPriority and renderOrderPriority", false)]
		public virtual int priority { get; } // 0x00000001811EC580-0x00000001811EC590 
		public virtual int sortOrderPriority { get; } // 0x0000000184DBF110-0x0000000184DBF120 
		public virtual int renderOrderPriority { get; } // 0x0000000184DBF110-0x0000000184DBF120 
		public BaseRaycaster rootRaycaster { get; } // 0x000000018389FF30-0x00000001838A0000 
	
		// Constructors
		protected BaseRaycaster(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
		public override string ToString(); // 0x000000018B57BFF8-0x000000018B57C194
		protected override void OnEnable(); // 0x00000001840DD330-0x00000001840DD360
		protected override void OnDisable(); // 0x00000001840DD260-0x00000001840DD290
		protected override void OnCanvasHierarchyChanged(); // 0x0000000185390C40-0x0000000185390C54
		protected override void OnTransformParentChanged(); // 0x0000000185390C40-0x0000000185390C54
	}

	[AddComponentMenu("Event/Physics 2D Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class Physics2DRaycaster : PhysicsRaycaster // TypeDefIndex: 57477
	{
		// Fields
		private RaycastHit2D[] m_Hits; // 0x40
	
		// Constructors
		protected Physics2DRaycaster(); // 0x000000018B5802C0-0x000000018B5802C8
	
		// Methods
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018B57FD24-0x000000018B5802C0
	}

	[AddComponentMenu("Event/Physics Raycaster")]
	[RequireComponent(typeof(Camera))]
	public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 57479
	{
		// Fields
		protected const int kNoEventMaskSet = -1; // Metadata: 0x0234B110
		protected Camera m_EventCamera; // 0x20
		[SerializeField]
		protected LayerMask m_EventMask; // 0x28
		[SerializeField]
		protected int m_MaxRayIntersections; // 0x2C
		protected int m_LastMaxRayIntersections; // 0x30
		private RaycastHit[] m_Hits; // 0x38
	
		// Properties
		public override Camera eventCamera { get; } // 0x000000018B580A28-0x000000018B580AB8 
		public virtual int depth { get; } // 0x000000018B5809A4-0x000000018B580A28 
		public int finalEventMask { get; } // 0x000000018B580AB8-0x000000018B580B40 
		public LayerMask eventMask { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public int maxRayIntersections { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
	
		// Nested types
		private class RaycastHitComparer : IComparer<RaycastHit> // TypeDefIndex: 57478
		{
			// Fields
			public static RaycastHitComparer instance; // 0x00
	
			// Constructors
			public RaycastHitComparer(); // 0x00000001841E1670-0x00000001841E1680
			static RaycastHitComparer(); // 0x000000018B583508-0x000000018B58356C
	
			// Methods
			public int Compare(RaycastHit x, RaycastHit y); // 0x000000018B5834DC-0x000000018B583508
		}
	
		// Constructors
		protected PhysicsRaycaster(); // 0x000000018B580984-0x000000018B5809A4
	
		// Methods
		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane); // 0x000000018B5802C8-0x000000018B580598
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018B580598-0x000000018B580984
	}

	public struct RaycastResult // TypeDefIndex: 57480
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
		public GameObject gameObject { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public bool isValid { get; } // 0x000000018B5839E4-0x000000018B583A58 
	
		// Methods
		public void Clear(); // 0x000000018B58356C-0x000000018B583614
		public override string ToString(); // 0x000000018B583614-0x000000018B5839E4
	}

	public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 57481
	{
		// Constructors
		protected UIBehaviour(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected virtual void Awake(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void Start(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool IsActive(); // 0x0000000182FA7940-0x0000000182FA7970
		protected virtual void OnRectTransformDimensionsChange(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnBeforeTransformParentChanged(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnTransformParentChanged(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnDidApplyAnimationProperties(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnCanvasHierarchyChanged(); // 0x00000001841E1670-0x00000001841E1680
		public bool IsDestroyed(); // 0x00000001831BD4A0-0x00000001831BD690
	}
}

namespace UnityEngine.UI
{
	[Serializable]
	public class AnimationTriggers // TypeDefIndex: 57270
	{
		// Fields
		private const string kDefaultNormalAnimName = "Normal"; // Metadata: 0x0234AFB8
		private const string kDefaultHighlightedAnimName = "Highlighted"; // Metadata: 0x0234AFBF
		private const string kDefaultPressedAnimName = "Pressed"; // Metadata: 0x0234AFCB
		private const string kDefaultSelectedAnimName = "Selected"; // Metadata: 0x0234AFD3
		private const string kDefaultDisabledAnimName = "Disabled"; // Metadata: 0x0234AFDC
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
		public string normalTrigger { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public string highlightedTrigger { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public string pressedTrigger { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public string selectedTrigger { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		public string disabledTrigger { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
		// Constructors
		public AnimationTriggers(); // 0x0000000183697710-0x0000000183697780
	}

	[AddComponentMenu("UI/Button", 30)]
	public class Button : Selectable, IPointerClickHandler, ISubmitHandler // TypeDefIndex: 57273
	{
		// Fields
		[FormerlySerializedAs("onClick")]
		[SerializeField]
		private ButtonClickedEvent m_OnClick; // 0x188
	
		// Properties
		public ButtonClickedEvent onClick { get; set; } // 0x0000000184D8DA20-0x0000000184D8DA30 0x0000000186B8B3B4-0x0000000186B8B3C8
	
		// Nested types
		[Serializable]
		public class ButtonClickedEvent : UnityEvent // TypeDefIndex: 57271
		{
			// Constructors
			public ButtonClickedEvent(); // 0x0000000185393538-0x0000000185393540
		}
	
		[CompilerGenerated]
		private sealed class _OnFinishSubmit_d__9 : IEnumerator<object> // TypeDefIndex: 57272
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Button __4__this; // 0x20
			private float _fadeTime_5__2; // 0x28
			private float _elapsedTime_5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _OnFinishSubmit_d__9(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B46BFB4-0x000000018B46C0A8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B46C0A8-0x000000018B46C0F4
		}
	
		// Constructors
		protected Button(); // 0x000000018B45FEEC-0x000000018B45FF78
	
		// Methods
		private void Press(); // 0x000000018B45FE74-0x000000018B45FEEC
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018B45FDE8-0x000000018B45FE10
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018B45FE10-0x000000018B45FE74
		[IteratorStateMachine(typeof(_OnFinishSubmit_d__9))]
		private IEnumerator OnFinishSubmit(); // 0x000000018B45FD8C-0x000000018B45FDE8
	}

	public enum CanvasUpdate // TypeDefIndex: 57274
	{
		Prelayout = 0,
		Layout = 1,
		PostLayout = 2,
		PreRender = 3,
		LatePreRender = 4,
		MaxUpdateValue = 5
	}

	public interface ICanvasElement // TypeDefIndex: 57275
	{
		// Properties
		Transform transform { get; }
	
		// Methods
		void Rebuild(CanvasUpdate executing);
		void LayoutComplete();
		void GraphicUpdateComplete();
		bool IsDestroyed();
	}

	public class CanvasUpdateRegistry // TypeDefIndex: 57276
	{
		// Fields
		private static CanvasUpdateRegistry s_Instance; // 0x00
		private bool m_PerformingLayoutUpdate; // 0x10
		private bool m_PerformingGraphicUpdate; // 0x11
		private ProfilerMarker[] m_CanvasUpdateProfilerStrings; // 0x18
		private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull"; // Metadata: 0x0234AFEB
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x08
	
		// Properties
		public static CanvasUpdateRegistry instance { get; } // 0x000000018351BE00-0x000000018351BEE0 
	
		// Constructors
		protected CanvasUpdateRegistry(); // 0x0000000184821CD0-0x0000000184821F30
		static CanvasUpdateRegistry(); // 0x0000000184CED4F0-0x0000000184CED590
	
		// Methods
		private bool ObjectValidForUpdate(ICanvasElement element); // 0x00000001831BE530-0x00000001831BEAD0
		private void CleanInvalidItems(); // 0x00000001831BD690-0x00000001831BD940
		private void PerformUpdate(); // 0x00000001831BD940-0x00000001831BE530
		private static int ParentCount(Transform child); // 0x0000000183B9A390-0x0000000183B9A4B0
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y); // 0x0000000183B9A250-0x0000000183B9A390
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x00000001839D3C60-0x00000001839D3CD0
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018351B260-0x000000018351B370
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018351C0B0-0x000000018351C220
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018351BB50-0x000000018351BE00
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018B45FF78-0x000000018B45FFD0
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018351BEE0-0x000000018351C0B0
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element); // 0x000000018351B370-0x000000018351B640
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element); // 0x000000018351ABA0-0x000000018351AD10
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element); // 0x000000018351AD10-0x000000018351AE80
		public static bool IsRebuildingLayout(); // 0x000000018351AE80-0x000000018351AEC0
		public static bool IsRebuildingGraphics(); // 0x000000018351AEC0-0x000000018351AF00
	}

	[Serializable]
	public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 57277
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
		public UnityEngine.Color normalColor { get; set; } // 0x0000000182B77630-0x0000000182B77640 0x0000000184D8D270-0x0000000184D8D280
		public UnityEngine.Color highlightedColor { get; set; } // 0x0000000182B2D510-0x0000000182B2D520 0x0000000184D8C980-0x0000000184D8C990
		public UnityEngine.Color pressedColor { get; set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000184D8C210-0x0000000184D8C220
		public UnityEngine.Color selectedColor { get; set; } // 0x0000000184D87480-0x0000000184D87490 0x0000000184D87490-0x0000000184D874A0
		public UnityEngine.Color disabledColor { get; set; } // 0x0000000184D905C0-0x0000000184D905D0 0x0000000184D926F0-0x0000000184D92700
		public float colorMultiplier { get; set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
		public float fadeDuration { get; set; } // 0x0000000184D86E00-0x0000000184D86E10 0x0000000184D86E10-0x0000000184D86E20
	
		// Constructors
		static ColorBlock(); // 0x0000000184B2FF10-0x0000000184B30040
	
		// Methods
		public override bool Equals(object obj); // 0x000000018B460300-0x000000018B4603B0
		public bool Equals(ColorBlock other); // 0x000000018B4603B0-0x000000018B460534
		public static bool operator ==(ColorBlock point1, ColorBlock point2); // 0x000000018B4605B8-0x000000018B46064C
		public static bool operator !=(ColorBlock point1, ColorBlock point2); // 0x000000018B46064C-0x000000018B4606E4
		public override int GetHashCode(); // 0x000000018B460534-0x000000018B4605B8
	}

	public class ClipperRegistry // TypeDefIndex: 57278
	{
		// Fields
		private static ClipperRegistry s_Instance; // 0x00
		internal readonly IndexedSet<IClipper> m_Clippers; // 0x10
		private readonly ProfilerMarker clippersMarker; // 0x18
	
		// Properties
		public static ClipperRegistry instance { get; } // 0x00000001831BCA30-0x00000001831BCAB0 
	
		// Constructors
		protected ClipperRegistry(); // 0x0000000184CE72F0-0x0000000184CE73A0
	
		// Methods
		public void Cull(); // 0x00000001831BC990-0x00000001831BCA30
		private void CullOriginal(); // 0x000000018B45FFD0-0x000000018B460068
		public static void Register(IClipper c); // 0x0000000184424750-0x0000000184424790
		public static void Unregister(IClipper c); // 0x0000000183D91BD0-0x0000000183D91C10
	}

	public static class Clipping // TypeDefIndex: 57279
	{
		// Methods
		public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect); // 0x000000018B460068-0x000000018B460300
	}

	public interface IClipper // TypeDefIndex: 57280
	{
		// Methods
		void PerformClipping();
	}

	public interface IClippable // TypeDefIndex: 57281
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

	internal class RectangularVertexClipper // TypeDefIndex: 57282
	{
		// Fields
		private readonly Vector3[] m_WorldCorners; // 0x10
		private readonly Vector3[] m_CanvasCorners; // 0x18
	
		// Constructors
		public RectangularVertexClipper(); // 0x000000018404D5C0-0x000000018404D610
	
		// Methods
		public Rect GetCanvasRect(RectTransform t, Canvas c); // 0x000000018B46BC90-0x000000018B46BECC
		public Rect GetCanvasRectAABB(RectTransform t, Canvas c); // 0x000000018B46BA44-0x000000018B46BC90
	}

	public static class DefaultControls // TypeDefIndex: 57286
	{
		// Fields
		private static IFactoryControls m_CurrentFactory; // 0x00
		private const float kWidth = 160f; // Metadata: 0x0234B000
		private const float kThickHeight = 30f; // Metadata: 0x0234B004
		private const float kThinHeight = 20f; // Metadata: 0x0234B008
		private static Vector2 s_ThickElementSize; // 0x08
		private static Vector2 s_ThinElementSize; // 0x10
		private static Vector2 s_ImageElementSize; // 0x18
		private static UnityEngine.Color s_DefaultSelectableColor; // 0x20
		private static UnityEngine.Color s_PanelColor; // 0x30
		private static UnityEngine.Color s_TextColor; // 0x40
	
		// Properties
		public static IFactoryControls factory { get; } // 0x000000018B464448-0x000000018B464498 
	
		// Nested types
		public interface IFactoryControls // TypeDefIndex: 57283
		{
			// Methods
			GameObject CreateGameObject(string name, params System.Type[] components);
		}
	
		private class DefaultRuntimeFactory : IFactoryControls // TypeDefIndex: 57284
		{
			// Fields
			public static IFactoryControls Default; // 0x00
	
			// Constructors
			public DefaultRuntimeFactory(); // 0x00000001841E1670-0x00000001841E1680
			static DefaultRuntimeFactory(); // 0x000000018B464508-0x000000018B46456C
	
			// Methods
			public GameObject CreateGameObject(string name, params System.Type[] components); // 0x000000018B464498-0x000000018B464508
		}
	
		public struct Resources // TypeDefIndex: 57285
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
		static DefaultControls(); // 0x000000018B464334-0x000000018B464448
	
		// Methods
		private static GameObject CreateUIElementRoot(string name, Vector2 size, params System.Type[] components); // 0x000000018B463F70-0x000000018B46401C
		private static GameObject CreateUIObject(string name, GameObject parent, params System.Type[] components); // 0x000000018B46401C-0x000000018B4640A0
		private static void SetDefaultTextValues(Text lbl); // 0x000000018B4640F0-0x000000018B4641A8
		private static void SetDefaultColorTransitionValues(Selectable slider); // 0x000000018B4640A0-0x000000018B4640F0
		private static void SetParentAndAlign(GameObject child, GameObject parent); // 0x000000018B464268-0x000000018B464334
		private static void SetLayerRecursively(GameObject go, int layer); // 0x000000018B4641A8-0x000000018B464268
		public static GameObject CreatePanel(Resources resources); // 0x000000018B462214-0x000000018B462444
		public static GameObject CreateButton(Resources resources); // 0x000000018B4606E4-0x000000018B460A40
		public static GameObject CreateText(Resources resources); // 0x000000018B46384C-0x000000018B4639B0
		public static GameObject CreateImage(Resources resources); // 0x000000018B461B78-0x000000018B461C84
		public static GameObject CreateRawImage(Resources resources); // 0x000000018B462444-0x000000018B462550
		public static GameObject CreateSlider(Resources resources); // 0x000000018B463100-0x000000018B46384C
		public static GameObject CreateScrollbar(Resources resources); // 0x000000018B462CAC-0x000000018B463100
		public static GameObject CreateToggle(Resources resources); // 0x000000018B4639B0-0x000000018B463F70
		public static GameObject CreateInputField(Resources resources); // 0x000000018B461C84-0x000000018B462214
		public static GameObject CreateDropdown(Resources resources); // 0x000000018B460A40-0x000000018B461B78
		public static GameObject CreateScrollView(Resources resources); // 0x000000018B462550-0x000000018B462CAC
	}

	[RequireComponent(typeof(RectTransform))]
	public class Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 57293
	{
		// Fields
		[SerializeField]
		private RectTransform m_Template; // 0x188
		[SerializeField]
		private Text m_CaptionText; // 0x190
		[SerializeField]
		private Image m_CaptionImage; // 0x198
		[SerializeField]
		[Space]
		private Text m_ItemText; // 0x1A0
		[SerializeField]
		private Image m_ItemImage; // 0x1A8
		[SerializeField]
		[Space]
		private int m_Value; // 0x1B0
		[SerializeField]
		[Space]
		private OptionDataList m_Options; // 0x1B8
		[SerializeField]
		[Space]
		private DropdownEvent m_OnValueChanged; // 0x1C0
		[SerializeField]
		private float m_AlphaFadeSpeed; // 0x1C8
		private GameObject m_Dropdown; // 0x1D0
		private GameObject m_Blocker; // 0x1D8
		private List<DropdownItem> m_Items; // 0x1E0
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x1E8
		private bool validTemplate; // 0x1F0
		private const int kHighSortingLayer = 30000; // Metadata: 0x0234B00D
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get; set; } // 0x0000000184D8DA20-0x0000000184D8DA30 0x000000018B4673B8-0x000000018B4673E0
		public Text captionText { get; set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018B46730C-0x000000018B467334
		public Image captionImage { get; set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x000000018B4672E4-0x000000018B46730C
		public Text itemText { get; set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x000000018B46735C-0x000000018B467384
		public Image itemImage { get; set; } // 0x0000000184D8D9C0-0x0000000184D8D9D0 0x000000018B467334-0x000000018B46735C
		public List<OptionData> options { get; set; } // 0x000000018B4672C4-0x000000018B4672E4 0x000000018B467384-0x000000018B4673B8
		public DropdownEvent onValueChanged { get; set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x0000000186B8B42C-0x0000000186B8B440
		public float alphaFadeSpeed { get; set; } // 0x0000000184D8E980-0x0000000184D8E990 0x0000000184D8EA30-0x0000000184D8EA40
		public int value { get; set; } // 0x0000000184D8E930-0x0000000184D8E940 0x000000018B4673E0-0x000000018B4673EC
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 57287
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
			public Text text { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public Image image { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
			public RectTransform rectTransform { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
			public Toggle toggle { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
	
			// Constructors
			public DropdownItem(); // 0x0000000185393520-0x0000000185393538
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018B464620-0x000000018B46468C
			public virtual void OnCancel(BaseEventData eventData); // 0x000000018B4645A8-0x000000018B464620
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 57288
		{
			// Fields
			[SerializeField]
			private string m_Text; // 0x10
			[SerializeField]
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
			public Sprite image { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
			// Constructors
			public OptionData(); // 0x00000001841E1670-0x00000001841E1680
			public OptionData(string text); // 0x00000001853908C0-0x00000001853908D0
			public OptionData(Sprite image); // 0x0000000185392C40-0x0000000185392C50
			public OptionData(string text, Sprite image); // 0x00000001832AF420-0x00000001832AF450
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 57289
		{
			// Fields
			[SerializeField]
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
			// Constructors
			public OptionDataList(); // 0x000000018B46B9CC-0x000000018B46BA44
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 57290
		{
			// Constructors
			public DropdownEvent(); // 0x000000018B46456C-0x000000018B4645A8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0 // TypeDefIndex: 57291
		{
			// Fields
			public DropdownItem item; // 0x10
			public Dropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass63_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Show_b__0(bool x); // 0x000000018B46C0F4-0x000000018B46C5AC
		}
	
		[CompilerGenerated]
		private sealed class _DelayedDestroyDropdownList_d__75 : IEnumerator<object> // TypeDefIndex: 57292
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float delay; // 0x20
			public Dropdown __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedDestroyDropdownList_d__75(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B46BECC-0x000000018B46BF68
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B46BF68-0x000000018B46BFB4
		}
	
		// Constructors
		protected Dropdown(); // 0x000000018B46719C-0x000000018B4672C4
		static Dropdown(); // 0x000000018B46712C-0x000000018B46719C
	
		// Methods
		public void SetValueWithoutNotify(int input); // 0x000000018B465B2C-0x000000018B465B38
		private void Set(int value, bool sendCallback = true /* Metadata: 0x0234B00C */); // 0x000000018B465B38-0x000000018B465C28
		protected override void Awake(); // 0x000000018B464D90-0x000000018B464E78
		protected override void Start(); // 0x000000018B46709C-0x000000018B46712C
		protected override void OnDisable(); // 0x000000018B465704-0x000000018B465798
		public void RefreshShownValue(); // 0x000000018B4658A8-0x000000018B465A8C
		public void AddOptions(List<OptionData> options); // 0x000000018B464B20-0x000000018B464B88
		public void AddOptions(List<string> options); // 0x000000018B464918-0x000000018B464A1C
		public void AddOptions(List<Sprite> options); // 0x000000018B464A1C-0x000000018B464B20
		public void ClearOptions(); // 0x000000018B464E78-0x000000018B464ED8
		private void SetupTemplate(Canvas rootCanvas); // 0x000000018B465C28-0x000000018B466270
		private static T GetOrAddComponent<T>(GameObject go)
			where T : UnityEngine.Component;
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018B465798-0x000000018B4657A0
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018B465798-0x000000018B4657A0
		public virtual void OnCancel(BaseEventData eventData); // 0x000000018B4656FC-0x000000018B465704
		public void Show(); // 0x000000018B466270-0x000000018B46709C
		protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x000000018B464ED8-0x000000018B46530C
		protected virtual void DestroyBlocker(GameObject blocker); // 0x000000018B465420-0x000000018B46546C
		protected virtual GameObject CreateDropdownList(GameObject template); // 0x000000018B46530C-0x000000018B465360
		protected virtual void DestroyDropdownList(GameObject dropdownList); // 0x000000018B46546C-0x000000018B4654B8
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate); // 0x000000018B465360-0x000000018B4653B4
		protected virtual void DestroyItem(DropdownItem item); // 0x00000001841E1670-0x00000001841E1680
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items); // 0x000000018B46468C-0x000000018B464918
		private void AlphaFadeList(float duration, float alpha); // 0x000000018B464D04-0x000000018B464D90
		private void AlphaFadeList(float duration, float start, float end); // 0x000000018B464B88-0x000000018B464D04
		private void SetAlpha(float alpha); // 0x000000018B465A8C-0x000000018B465B2C
		public void Hide(); // 0x000000018B4654B8-0x000000018B4655AC
		[IteratorStateMachine(typeof(_DelayedDestroyDropdownList_d__75))]
		private IEnumerator DelayedDestroyDropdownList(float delay); // 0x000000018B4653B4-0x000000018B465420
		private void ImmediateDestroyDropdownList(); // 0x000000018B4655AC-0x000000018B4656FC
		private void OnSelectItem(Toggle toggle); // 0x000000018B4657A0-0x000000018B4658A8
	}

	[Serializable]
	public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 57294
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
		public static FontData defaultFontData { get; } // 0x000000018B467438-0x000000018B4674AC 
		public Font font { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public int fontSize { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public FontStyle fontStyle { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x0000000184D86320-0x0000000184D86330
		public bool bestFit { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public int minSize { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public int maxSize { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public TextAnchor alignment { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public bool alignByGeometry { get; set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
		public bool richText { get; set; } // 0x0000000184D86AB0-0x0000000184D86AC0 0x0000000184D86AC0-0x0000000184D86AD0
		public HorizontalWrapMode horizontalOverflow { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public VerticalWrapMode verticalOverflow { get; set; } // 0x0000000184D863B0-0x0000000184D863C0 0x0000000184D86430-0x0000000184D86440
		public float lineSpacing { get; set; } // 0x0000000184D863E0-0x0000000184D863F0 0x0000000184D86460-0x0000000184D86470
	
		// Constructors
		public FontData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018B4673EC-0x000000018B467438
	}

	public static class FontUpdateTracker // TypeDefIndex: 57295
	{
		// Fields
		private static Dictionary<Font, HashSet<Text>> m_Tracked; // 0x00
	
		// Constructors
		static FontUpdateTracker(); // 0x000000018B467A20-0x000000018B467AAC
	
		// Methods
		public static void TrackText(Text t); // 0x000000018B46761C-0x000000018B46783C
		private static void RebuildForFont(Font f); // 0x000000018B4674AC-0x000000018B46761C
		public static void UntrackText(Text t); // 0x000000018B46783C-0x000000018B467A20
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 57296
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
		public static string defaultMaterialName { get; set; } // 0x000000018B467EC4-0x000000018B467F14 0x000000018B467F64-0x000000018B467FC4
		public static Material defaultGraphicMaterial { get; } // 0x00000001831BCDA0-0x00000001831BCF50 
		public static string overlayShaderKeyword { get; set; } // 0x000000018B467F14-0x000000018B467F64 0x000000018B467FF4-0x000000018B468054
		public virtual UnityEngine.Color color { get; set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000183046910-0x0000000183046980
		public virtual bool raycastTarget { get; set; } // 0x0000000184D86DC0-0x0000000184D86DD0 0x00000001844550F0-0x0000000184455160
		public Vector4 raycastPadding { get; set; } // 0x0000000184D89180-0x0000000184D89190 0x0000000184D89190-0x0000000184D891A0
		private TweenRunner<ColorTween> m_ColorTweenRunner { get; } // 0x000000018343F2F0-0x000000018343F360 
		public virtual bool enableRuntimeAtlas { get; set; } // 0x0000000184D86C50-0x0000000184D86C60 0x000000018B467FC4-0x000000018B467FF4
		public Texture runtimeAtlasTexture { get; set; } // 0x0000000184D86210-0x0000000184D86220 0x000000018B468054-0x000000018B468080
		protected bool useLegacyMeshGeneration { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D90720-0x0000000184D90730 0x0000000184D90750-0x0000000184D90760
		public int depth { get; } // 0x00000001831BF800-0x00000001831BF930 
		public RectTransform rectTransform { get; } // 0x00000001831C2170-0x00000001831C2550 
		public Canvas canvas { get; } // 0x0000000182FCB610-0x0000000182FCBF00 
		public CanvasRenderer canvasRenderer { get; } // 0x00000001831BFEC0-0x00000001831C0310 
		public virtual Material defaultMaterial { get; } // 0x00000001831BCD70-0x00000001831BCDA0 
		public virtual Material material { get; set; } // 0x0000000183E9D0E0-0x0000000183E9D1B0 0x000000018425D120-0x000000018425D190
		public virtual Material materialForRendering { get; } // 0x00000001831EE800-0x00000001831EED90 
		public virtual Texture mainTexture { get; } // 0x0000000184D394C0-0x0000000184D39600 
		protected static Mesh workerMesh { get; } // 0x00000001831F2480-0x00000001831F2610 
		Transform ICanvasElement.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Constructors
		protected Graphic(); // 0x0000000183697340-0x0000000183697390
		static Graphic(); // 0x0000000184B473C0-0x0000000184B47500
	
		// Methods
		public virtual void SetAllDirty(); // 0x0000000183D23600-0x0000000183D23650
		public virtual void SetLayoutDirty(); // 0x0000000183C98E90-0x0000000183C98F00
		public virtual void SetVerticesDirty(); // 0x000000018351B640-0x000000018351B8D0
		public virtual void SetMaterialDirty(); // 0x000000018351B8D0-0x000000018351BB50
		protected override void OnRectTransformDimensionsChange(); // 0x000000018351AB00-0x000000018351ABA0
		protected override void OnBeforeTransformParentChanged(); // 0x00000001835197A0-0x0000000183519820
		protected override void OnTransformParentChanged(); // 0x0000000183F3AF00-0x0000000183F3AF90
		private void CacheCanvas(); // 0x0000000182FA9D50-0x0000000182FAA1C0
		protected override void OnEnable(); // 0x00000001831EBEA0-0x00000001831EBFF0
		protected override void OnDisable(); // 0x000000018351A480-0x000000018351A5F0
		protected override void OnDestroy(); // 0x0000000183094210-0x00000001830942B0
		protected override void OnCanvasHierarchyChanged(); // 0x00000001831C3F80-0x00000001831C4370
		public virtual void OnCullingChanged(); // 0x00000001831EAB40-0x00000001831EABC0
		public virtual void Rebuild(CanvasUpdate update); // 0x00000001831BF970-0x00000001831BFC20
		public virtual void LayoutComplete(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void GraphicUpdateComplete(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void UpdateMaterial(); // 0x00000001831BEC70-0x00000001831BEDB0
		protected virtual void UpdateGeometry(); // 0x00000001831F2660-0x00000001831F2690
		private void DoMeshGeneration(); // 0x00000001831F1FC0-0x00000001831F2480
		private void DoLegacyMeshGeneration(); // 0x00000001846923F0-0x00000001846926D0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use OnPopulateMesh instead.", true)]
		protected virtual void OnFillVBO(List<UIVertex> vbo); // 0x00000001841E1670-0x00000001841E1680
		[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", false)]
		protected virtual void OnPopulateMesh(Mesh m); // 0x0000000184A27120-0x0000000184A271C0
		protected virtual void OnPopulateMesh(VertexHelper vh); // 0x0000000183240F40-0x0000000183241250
		protected override void OnDidApplyAnimationProperties(); // 0x000000018B467B50-0x000000018B467B60
		public virtual void SetNativeSize(); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool Raycast(Vector2 sp, Camera eventCamera); // 0x00000001831F0020-0x00000001831F0680
		public Vector2 PixelAdjustPoint(Vector2 point); // 0x000000018B467B60-0x000000018B467C94
		public Rect GetPixelAdjustedRect(); // 0x00000001831C2550-0x00000001831C27F0
		public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x000000018343EE00-0x000000018343EE80
		public virtual void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB); // 0x000000018343EE80-0x000000018343F240
		private static UnityEngine.Color CreateColorFromAlpha(float alpha); // 0x0000000184CC9850-0x0000000184CC9880
		public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x0000000184CC9780-0x0000000184CC9850
		public void RegisterDirtyLayoutCallback(UnityAction action); // 0x000000018B467C94-0x000000018B467D20
		public void UnregisterDirtyLayoutCallback(UnityAction action); // 0x000000018B467DAC-0x000000018B467E38
		public void RegisterDirtyVerticesCallback(UnityAction action); // 0x0000000182EDDB70-0x0000000182EDDC00
		public void UnregisterDirtyVerticesCallback(UnityAction action); // 0x0000000182EDD170-0x0000000182EDD200
		public void RegisterDirtyMaterialCallback(UnityAction action); // 0x000000018B467D20-0x000000018B467DAC
		public void UnregisterDirtyMaterialCallback(UnityAction action); // 0x000000018B467E38-0x000000018B467EC4
	}

	[AddComponentMenu("Event/Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 57299
	{
		// Fields
		protected const int kNoEventMaskSet = -1; // Metadata: 0x0234B011
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
		public override int sortOrderPriority { get; } // 0x0000000183DC3FB0-0x0000000183DC40B0 
		public override int renderOrderPriority { get; } // 0x0000000183DC4A00-0x0000000183DC4AE0 
		public bool ignoreReversedGraphics { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public BlockingObjects blockingObjects { get; set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public LayerMask blockingMask { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		private Canvas canvas { get; } // 0x0000000182FC99B0-0x0000000182FC9CE0 
		public override Camera eventCamera { get; } // 0x0000000183096CF0-0x0000000183096EB0 
	
		// Nested types
		public enum BlockingObjects // TypeDefIndex: 57297
		{
			None = 0,
			TwoD = 1,
			ThreeD = 2,
			All = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57298
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<Graphic> __9__27_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D470B0-0x0000000184D47110
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _Raycast_b__27_0(Graphic g1, Graphic g2); // 0x000000018389F670-0x000000018389F780
		}
	
		// Constructors
		protected GraphicRaycaster(); // 0x00000001843B7CB0-0x00000001843B7D20
		static GraphicRaycaster(); // 0x00000001843B7B80-0x00000001843B7C10
	
		// Methods
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x0000000182FC7E70-0x0000000182FC95A0
		private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results); // 0x00000001831BEDF0-0x00000001831BF7C0
	}

	public class GraphicRegistry // TypeDefIndex: 57300
	{
		// Fields
		private static GraphicRegistry s_Instance; // 0x00
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
		private static readonly List<Graphic> s_EmptyList; // 0x08
	
		// Properties
		public static GraphicRegistry instance { get; } // 0x0000000182FC7CD0-0x0000000182FC7DB0 
	
		// Constructors
		protected GraphicRegistry(); // 0x0000000184A20380-0x0000000184A20500
		static GraphicRegistry(); // 0x00000001843B7C10-0x00000001843B7CB0
	
		// Methods
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic); // 0x00000001831EBFF0-0x00000001831EC3A0
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic); // 0x00000001831EC3A0-0x00000001831EC620
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic); // 0x000000018351A630-0x000000018351A8A0
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic); // 0x000000018351A8A0-0x000000018351AB00
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas); // 0x000000018B467AAC-0x000000018B467B50
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas); // 0x0000000182FC7830-0x0000000182FC7CD0
	}

	public class HGImage : Image // TypeDefIndex: 57301
	{
		// Constructors
		public HGImage(); // 0x0000000183696D70-0x0000000183696E30
	
		// Methods
		protected override void UpdateGeometry(); // 0x00000001831BB800-0x00000001831BB860
		private bool CanUseBatchedPath(); // 0x00000001831C29F0-0x00000001831C2F50
		protected sealed override void OnPopulateMesh(VertexHelper toFill); // 0x00000001831E85B0-0x00000001831E85F0
		protected virtual void OnPopulateMeshFallback(VertexHelper toFill); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class HGUIBatchInit // TypeDefIndex: 57302
	{
		// Methods
		public static void Initialize(); // 0x0000000184821F30-0x0000000184822040
	}

	internal static class HGUIBatchClipper // TypeDefIndex: 57303
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
		public static bool Enabled { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B468124-0x000000018B468174 0x000000018B468174-0x000000018B4681C8
	
		// Constructors
		static HGUIBatchClipper(); // 0x000000018404D2D0-0x000000018404D490
	
		// Methods
		public static void CullBatched(IList<IClipper> clippers); // 0x00000001831C0310-0x00000001831C1D80
	}

	internal static class HGImageBatchHelper // TypeDefIndex: 57304
	{
		// Fields
		[CompilerGenerated]
		private static bool _Enabled_k__BackingField; // 0x00
		private const int kMaxBatchImageCount = 256; // Metadata: 0x0234B016
		private static NativeArray<HGImageBatchBindings.HGBatchImageInput> s_BatchBuffer; // 0x08
		private static int s_BatchCount; // 0x18
		private static readonly ProfilerMarker s_BatchFlushMarker; // 0x20
	
		// Properties
		public static bool Enabled { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B468080-0x000000018B4680D0 0x000000018B4680D0-0x000000018B468124
	
		// Constructors
		static HGImageBatchHelper(); // 0x0000000184D30690-0x0000000184D30700
	
		// Methods
		public static void Enqueue(Image image); // 0x00000001831BB3F0-0x00000001831BB740
		public static void Flush(); // 0x00000001831BC560-0x00000001831BC990
		private static void EnsureBatchBuffer(); // 0x00000001831BB740-0x00000001831BB800
		public static void FillHGImageData(Image image, ref CanvasRenderer.HGImageData data); // 0x00000001831BB290-0x00000001831BB3F0
	}

	[Obsolete("Not supported anymore")]
	internal interface IGraphicEnabledDisabled // TypeDefIndex: 57305
	{
		// Methods
		void OnSiblingGraphicEnabledDisabled();
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 57315
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
		private const int QuadCount = 4; // Metadata: 0x0234B018
		private static readonly Vector3[] s_Xy; // 0x18
		private static readonly Vector3[] s_Uv; // 0x20
		private static List<Image> m_TrackedTexturelessImages; // 0x28
		private static bool s_Initialized; // 0x30
		protected const int VALIDATE_MAX_VERT_COUNT = 10000; // Metadata: 0x0234B019
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
		internal override bool hasCullOverride { get; } // 0x00000001812081B0-0x0000000181208610 
		public Rect runtimeAtlasRect { get; set; } // 0x0000000184DA1270-0x0000000184DA1280 0x0000000184DA1320-0x0000000184DA1330
		public Rect runtimeAtlasTextureRect { get; set; } // 0x0000000184DA1250-0x0000000184DA1260 0x0000000184DA12F0-0x0000000184DA1300
		public Vector4 runtimeAtlasBorder { get; set; } // 0x0000000184DA1240-0x0000000184DA1250 0x0000000184DA12E0-0x0000000184DA12F0
		public float runtimeAtlasPixelsPerUnit { get; set; } // 0x0000000184DBD7E0-0x0000000184DBD7F0 0x0000000184DBD820-0x0000000184DBD830
		public Sprite sprite { get; set; } // 0x0000000184D88590-0x0000000184D885A0 0x00000001831EA420-0x00000001831EA9C0
		public bool enableRuntimeAtlasRaw { get; } // 0x0000000184D86C50-0x0000000184D86C60 
		public override bool enableRuntimeAtlas { get; set; } // 0x0000000183C04DB0-0x0000000183C04DD0 0x000000018B467FC4-0x000000018B467FF4
		public Sprite overrideSprite { get; set; } // 0x00000001853914BC-0x00000001853914C4 0x000000018B46B824-0x000000018B46B88C
		private Sprite activeSprite { get; } // 0x0000000182FC95E0-0x0000000182FC9670 
		public Type type { get; set; } // 0x0000000184D8D520-0x0000000184D8D530 0x000000018B46B910-0x000000018B46B96C
		public bool preserveAspect { get; set; } // 0x0000000184DA7910-0x0000000184DA7920 0x000000018B46B8B0-0x000000018B46B910
		public bool fillCenter { get; set; } // 0x0000000184DBD7C0-0x0000000184DBD7D0 0x000000018B46B6A4-0x000000018B46B704
		public FillMethod fillMethod { get; set; } // 0x0000000184D8D0B0-0x0000000184D8D0C0 0x000000018B46B764-0x000000018B46B7C8
		public float fillAmount { get; set; } // 0x0000000184DA7940-0x0000000184DA7950 0x0000000182F54FD0-0x0000000182F550E0
		public bool fillClockwise { get; set; } // 0x0000000184D8E4D0-0x0000000184D8E4E0 0x000000018B46B704-0x000000018B46B764
		public int fillOrigin { get; set; } // 0x0000000184DBD7D0-0x0000000184DBD7E0 0x000000018B46B7C8-0x000000018B46B824
		[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
		public float eventAlphaThreshold { get; set; } // 0x0000000184DBD7A0-0x0000000184DBD7C0 0x0000000184DBD800-0x0000000184DBD820
		public float alphaHitTestMinimumThreshold { get; set; } // 0x0000000184D90E70-0x0000000184D90E80 0x0000000184D90E80-0x0000000184D90E90
		public bool useSpriteMesh { get; set; } // 0x0000000184DBD7F0-0x0000000184DBD800 0x000000018B46B96C-0x000000018B46B9CC
		public static Material defaultETC1GraphicMaterial { get; } // 0x000000018B46B5DC-0x000000018B46B6A4 
		public override Texture mainTexture { get; } // 0x00000001831EDF80-0x00000001831EE3A0 
		public bool hasBorder { get; } // 0x00000001831CE170-0x00000001831CE290 
		public float pixelsPerUnitMultiplier { get; set; } // 0x0000000184DA7AE0-0x0000000184DA7AF0 0x000000018B46B88C-0x000000018B46B8B0
		public float pixelsPerUnit { get; } // 0x00000001831C4370-0x00000001831C4620 
		protected float multipliedPixelsPerUnit { get; } // 0x00000001831CD2B0-0x00000001831CD2D0 
		public override Material material { get; set; } // 0x00000001831BCAB0-0x00000001831BCD70 0x000000018425D110-0x000000018425D120
		public virtual float minWidth { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual float preferredWidth { get; } // 0x00000001831E9C70-0x00000001831E9E20 
		public virtual float flexibleWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float minHeight { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual float preferredHeight { get; } // 0x00000001831E99C0-0x00000001831E9B20 
		public virtual float flexibleHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual int layoutPriority { get; } // 0x00000001811EC580-0x00000001811EC590 
		public EDynamicAtlasActiveMode DynamicAtlasActiveMode { get; } // 0x0000000184DBD790-0x0000000184DBD7A0 
	
		// Nested types
		public enum Type // TypeDefIndex: 57306
		{
			Simple = 0,
			Sliced = 1,
			Tiled = 2,
			Filled = 3,
			Mirror = 4,
			Quarter = 5
		}
	
		public enum FillMethod // TypeDefIndex: 57307
		{
			Horizontal = 0,
			Vertical = 1,
			Radial90 = 2,
			Radial180 = 3,
			Radial360 = 4
		}
	
		public enum OriginHorizontal // TypeDefIndex: 57308
		{
			Left = 0,
			Right = 1
		}
	
		public enum OriginVertical // TypeDefIndex: 57309
		{
			Bottom = 0,
			Top = 1
		}
	
		public enum Origin90 // TypeDefIndex: 57310
		{
			BottomLeft = 0,
			TopLeft = 1,
			TopRight = 2,
			BottomRight = 3
		}
	
		public enum Origin180 // TypeDefIndex: 57311
		{
			Bottom = 0,
			Left = 1,
			Top = 2,
			Right = 3
		}
	
		public enum Origin360 // TypeDefIndex: 57312
		{
			Bottom = 0,
			Right = 1,
			Top = 2,
			Left = 3
		}
	
		public struct SlicedSpriteParams // TypeDefIndex: 57313
		{
			// Fields
			public bool slicedParamNeedUpdate; // 0x00
			public Vector2 inner_PosMin; // 0x04
			public Vector2 inner_PosMax; // 0x0C
			public Vector2 inner_UVMin; // 0x14
			public Vector2 inner_UVMax; // 0x1C
	
			// Constructors
			public SlicedSpriteParams(bool slicedParamNeedUpdate, Vector2 inner_PosMin, Vector2 inner_PosMax, Vector2 inner_UVMin, Vector2 inner_UVMax); // 0x0000000184DBEFB0-0x0000000184DBEFE0
		}
	
		public enum EDynamicAtlasActiveMode : byte // TypeDefIndex: 57314
		{
			ActiveOnAwake = 0,
			ActiveOnEnable = 1
		}
	
		// Constructors
		protected Image(); // 0x0000000183696E30-0x0000000183696ED0
		static Image(); // 0x00000001848B4620-0x00000001848B4960
	
		// Methods
		public virtual void ReleaseSprite(); // 0x0000000184695BF0-0x0000000184695C70
		protected virtual void _OnSpriteChanged(Sprite oldOne); // 0x0000000183093960-0x0000000183093A70
		public void DisableSpriteOptimizations(); // 0x0000000184DBD780-0x0000000184DBD790
		public virtual void OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void OnAfterDeserialize(); // 0x0000000183C82850-0x0000000183C828D0
		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize); // 0x000000018B46ACF0-0x000000018B46ADD8
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect); // 0x00000001831E8D40-0x00000001831E8FA0
		public override void SetNativeSize(); // 0x00000001831EA1B0-0x00000001831EA420
		protected override void OnPopulateMesh(VertexHelper toFill); // 0x00000001831E85F0-0x00000001831E87D0
		private void TrackSprite(); // 0x00000001831ED7C0-0x00000001831ED9F0
		protected override void OnEnable(); // 0x00000001831EBCB0-0x00000001831EBD20
		protected override void OnDisable(); // 0x000000018351A2F0-0x000000018351A3E0
		protected override void Awake(); // 0x0000000183093B40-0x0000000183093BA0
		protected override void OnDestroy(); // 0x0000000183094110-0x0000000183094210
		protected override void UpdateMaterial(); // 0x00000001831BD110-0x00000001831BD4A0
		protected override void OnCanvasHierarchyChanged(); // 0x00000001831C3A40-0x00000001831C3D80
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect); // 0x00000001831E87D0-0x00000001831E8B60
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect); // 0x000000018B46A364-0x000000018B46A7E4
		private void GenerateSlicedSprite(VertexHelper toFill); // 0x00000001831CC8E0-0x00000001831CD260
		private void GenerateTiledSprite(VertexHelper toFill); // 0x00000001831CECC0-0x00000001831CF550
		private void GenerateMirrorSprite(VertexHelper toFill); // 0x000000018B469DFC-0x000000018B46A364
		private void GenerateMirrorQuarter(VertexHelper toFill); // 0x000000018B469468-0x000000018B469DFC
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs); // 0x000000018B4681C8-0x000000018B4682EC
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax); // 0x00000001832407C0-0x0000000183240A50
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect); // 0x00000001831CE290-0x00000001831CE490
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect); // 0x000000018B4682EC-0x000000018B469468
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner); // 0x000000018B46ADD8-0x000000018B46AF08
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner); // 0x000000018B46AF08-0x000000018B46B2E4
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera); // 0x0000000183093020-0x0000000183093330
		private Vector2 MapCoordinate(Vector2 local, Rect rect); // 0x0000000183093540-0x00000001830935E0
		private static void RebuildImage(SpriteAtlas spriteAtlas); // 0x000000018B46B2E4-0x000000018B46B46C
		private static void TrackImage(Image g); // 0x000000018B46B46C-0x000000018B46B56C
		private static void UnTrackImage(Image g); // 0x000000018B46B56C-0x000000018B46B5DC
		protected override void OnDidApplyAnimationProperties(); // 0x0000000183E51A10-0x0000000183E51A40
		private Vector4 GetRuntimeAtlasSpritePadding(); // 0x000000018B46AC48-0x000000018B46ACF0
		private Vector4 GetRuntimeAtlasSpriteOuterUV(); // 0x000000018B46AB3C-0x000000018B46AC48
		private Vector4 GetRuntimeAtlasSpriteInnerUV(); // 0x000000018B46A910-0x000000018B46AB3C
		public string GetParticlePath(); // 0x000000018B46A7E4-0x000000018B46A910
		public void RegisterDynamicAtlas(); // 0x0000000183093BA0-0x0000000183093EA0
		public void UnRegisterDynamicAtlas(Sprite _sprite); // 0x00000001831BC430-0x00000001831BC560
		public void RegisterDynamicAtlasCallBack(Action cb); // 0x000000018309A1A0-0x000000018309A280
		public void UnRegisterDynamicAtlasCallBack(Action cb); // 0x000000018309C080-0x000000018309C100
		private static void _CanvasRreWillRenderCanvases(); // 0x00000001831BB860-0x00000001831BC280
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Not supported anymore.", true)]
	public interface IMask // TypeDefIndex: 57316
	{
		// Properties
		RectTransform rectTransform { get; }
	
		// Methods
		bool Enabled();
	}

	public interface IMaskable // TypeDefIndex: 57317
	{
		// Methods
		void RecalculateMasking();
	}

	public class InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 57329
	{
		// Fields
		protected TouchScreenKeyboard m_Keyboard; // 0x188
		private static readonly char[] kSeparators; // 0x00
		private static bool s_IsQuestDevice; // 0x08
		[FormerlySerializedAs("text")]
		[SerializeField]
		protected Text m_TextComponent; // 0x190
		[SerializeField]
		protected Graphic m_Placeholder; // 0x198
		[SerializeField]
		private ContentType m_ContentType; // 0x1A0
		[FormerlySerializedAs("inputType")]
		[SerializeField]
		private InputType m_InputType; // 0x1A4
		[FormerlySerializedAs("asteriskChar")]
		[SerializeField]
		private char m_AsteriskChar; // 0x1A8
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType; // 0x1AC
		[SerializeField]
		private LineType m_LineType; // 0x1B0
		[FormerlySerializedAs("hideMobileInput")]
		[SerializeField]
		private bool m_HideMobileInput; // 0x1B4
		[FormerlySerializedAs("validation")]
		[SerializeField]
		private CharacterValidation m_CharacterValidation; // 0x1B8
		[FormerlySerializedAs("characterLimit")]
		[SerializeField]
		private int m_CharacterLimit; // 0x1BC
		[FormerlySerializedAs("m_OnSubmit")]
		[FormerlySerializedAs("onSubmit")]
		[FormerlySerializedAs("m_OnEndEdit")]
		[FormerlySerializedAs("m_EndEdit")]
		[SerializeField]
		private SubmitEvent m_OnSubmit; // 0x1C0
		[SerializeField]
		private EndEditEvent m_OnDidEndEdit; // 0x1C8
		[FormerlySerializedAs("m_OnValueChange")]
		[FormerlySerializedAs("onValueChange")]
		[SerializeField]
		private OnChangeEvent m_OnValueChanged; // 0x1D0
		[FormerlySerializedAs("onValidateInput")]
		[SerializeField]
		private OnValidateInput m_OnValidateInput; // 0x1D8
		[FormerlySerializedAs("selectionColor")]
		[SerializeField]
		private UnityEngine.Color m_CaretColor; // 0x1E0
		[SerializeField]
		private bool m_CustomCaretColor; // 0x1F0
		[SerializeField]
		private UnityEngine.Color m_SelectionColor; // 0x1F4
		[FormerlySerializedAs("mValue")]
		[Multiline]
		[SerializeField]
		protected string m_Text; // 0x208
		[Range(0f, 4f)]
		[SerializeField]
		private float m_CaretBlinkRate; // 0x210
		[Range(1f, 5f)]
		[SerializeField]
		private int m_CaretWidth; // 0x214
		[SerializeField]
		private bool m_ReadOnly; // 0x218
		[SerializeField]
		private bool m_ShouldActivateOnSelect; // 0x219
		protected int m_CaretPosition; // 0x21C
		protected int m_CaretSelectPosition; // 0x220
		private RectTransform caretRectTrans; // 0x228
		protected UIVertex[] m_CursorVerts; // 0x230
		private TextGenerator m_InputTextCache; // 0x238
		private CanvasRenderer m_CachedInputRenderer; // 0x240
		private bool m_PreventFontCallback; // 0x248
		[NonSerialized]
		protected Mesh m_Mesh; // 0x250
		private bool m_AllowInput; // 0x258
		private bool m_ShouldActivateNextUpdate; // 0x259
		private bool m_UpdateDrag; // 0x25A
		private bool m_DragPositionOutOfBounds; // 0x25B
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x0234B03B
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x0234B03F
		protected bool m_CaretVisible; // 0x25C
		private Coroutine m_BlinkCoroutine; // 0x260
		private float m_BlinkStartTime; // 0x268
		protected int m_DrawStart; // 0x26C
		protected int m_DrawEnd; // 0x270
		private Coroutine m_DragCoroutine; // 0x278
		private string m_OriginalText; // 0x280
		private bool m_WasCanceled; // 0x288
		private bool m_HasDoneFocusTransition; // 0x289
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x290
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x298
		private bool m_IsCompositionActive; // 0x299
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x0234B043
		private const string kOculusQuestDeviceModel = "Oculus Quest"; // Metadata: 0x0234B057
		private UnityEngine.Event m_ProcessingEvent; // 0x2A0
		private const int k_MaxTextLength = 16382; // Metadata: 0x0234B064
	
		// Properties
		private BaseInput input { get; } // 0x000000018B570BE8-0x000000018B570CB8 
		private string compositionString { get; } // 0x000000018B570B2C-0x000000018B570BB8 
		protected Mesh mesh { get; } // 0x000000018B570CB8-0x000000018B570D5C 
		protected TextGenerator cachedInputTextGenerator { get; } // 0x000000018B570A08-0x000000018B570A84 
		public bool shouldHideMobileInput { get; set; } // 0x000000018B5710A4-0x000000018B5710D4 0x000000018B5717B0-0x000000018B5717FC
		public virtual bool shouldActivateOnSelect { get; set; } // 0x000000018B571080-0x000000018B5710A4 0x0000000184DBEFA0-0x0000000184DBEFB0
		public string text { get; set; } // 0x0000000184D8D8C0-0x0000000184D8D8D0 0x000000018B571AB8-0x000000018B571AC4
		public bool isFocused { get; } // 0x0000000184D8FD90-0x0000000184D8FDA0 
		public float caretBlinkRate { get; set; } // 0x0000000184D928F0-0x0000000184D92900 0x000000018B571130-0x000000018B571198
		public int caretWidth { get; set; } // 0x0000000184DB9DC0-0x0000000184DB9DD0 0x000000018B571238-0x000000018B571294
		public Text textComponent { get; set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018B5717FC-0x000000018B571AB8
		public Graphic placeholder { get; set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x000000018B57168C-0x000000018B5716D8
		public UnityEngine.Color caretColor { get; set; } // 0x000000018B570A84-0x000000018B570AD4 0x000000018B571198-0x000000018B5711D8
		public bool customCaretColor { get; set; } // 0x0000000184DBEF70-0x0000000184DBEF80 0x000000018B5713E0-0x000000018B5713F8
		public UnityEngine.Color selectionColor { get; set; } // 0x0000000184DBEF80-0x0000000184DBEF90 0x000000018B571724-0x000000018B571764
		public EndEditEvent onEndEdit { get; set; } // 0x0000000184D8D790-0x0000000184D8D7A0 0x000000018B571554-0x000000018B5715A0
		public SubmitEvent onSubmit { get; set; } // 0x0000000184D8DA80-0x0000000184D8DA90 0x000000018B5715A0-0x000000018B5715EC
		[Obsolete("onValueChange has been renamed to onValueChanged")]
		public OnChangeEvent onValueChange { get; set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x000000018B571638-0x000000018B571640
		public OnChangeEvent onValueChanged { get; set; } // 0x0000000184D8D7B0-0x0000000184D8D7C0 0x000000018B571640-0x000000018B57168C
		public OnValidateInput onValidateInput { get; set; } // 0x0000000184D87870-0x0000000184D87880 0x000000018B5715EC-0x000000018B571638
		public int characterLimit { get; set; } // 0x0000000184D91080-0x0000000184D91090 0x000000018B571294-0x000000018B571328
		public ContentType contentType { get; set; } // 0x0000000184DA3200-0x0000000184DA3210 0x000000018B571384-0x000000018B5713E0
		public LineType lineType { get; set; } // 0x0000000184D8E930-0x0000000184D8E940 0x000000018B5714B0-0x000000018B571554
		public InputType inputType { get; set; } // 0x0000000184DA7C40-0x0000000184DA7C50 0x000000018B5713F8-0x000000018B571454
		public TouchScreenKeyboard touchScreenKeyboard { get; } // 0x0000000184D8DA20-0x0000000184D8DA30 
		public TouchScreenKeyboardType keyboardType { get; set; } // 0x0000000184D90790-0x0000000184D907A0 0x000000018B571454-0x000000018B5714B0
		public CharacterValidation characterValidation { get; set; } // 0x0000000184D8EAC0-0x0000000184D8EAD0 0x000000018B571328-0x000000018B571384
		public bool readOnly { get; set; } // 0x0000000184D8EDA0-0x0000000184D8EDB0 0x0000000184D8EDB0-0x0000000184D8EDC0
		public bool multiLine { get; } // 0x000000018B570D5C-0x000000018B570D74 
		public char asteriskChar { get; set; } // 0x0000000184DBEF60-0x0000000184DBEF70 0x000000018B5710D4-0x000000018B571130
		public bool wasCanceled { get; } // 0x0000000184DBEF90-0x0000000184DBEFA0 
		protected int caretPositionInternal { get; set; } // 0x000000018B570AD4-0x000000018B570B00 0x000000018B5711D8-0x000000018B5711F0
		protected int caretSelectPositionInternal { get; set; } // 0x000000018B570B00-0x000000018B570B2C 0x000000018B571220-0x000000018B571238
		private new bool hasSelection { get; } // 0x000000018B570BB8-0x000000018B570BE8 
		public int caretPosition { get; set; } // 0x000000018B570B00-0x000000018B570B2C 0x000000018B5711F0-0x000000018B571220
		public int selectionAnchorPosition { get; set; } // 0x000000018B570AD4-0x000000018B570B00 0x000000018B5716D8-0x000000018B571724
		public int selectionFocusPosition { get; set; } // 0x000000018B570B00-0x000000018B570B2C 0x000000018B571764-0x000000018B5717B0
		private static string clipboard { get; set; } // 0x000000018B31DF8C-0x000000018B31DF94 0x000000018B31E494-0x000000018B31E49C
		public virtual float minWidth { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual float preferredWidth { get; } // 0x000000018B570F20-0x000000018B571080 
		public virtual float flexibleWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float minHeight { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual float preferredHeight { get; } // 0x000000018B570D74-0x000000018B570F20 
		public virtual float flexibleHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual int layoutPriority { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		Transform ICanvasElement.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 57318
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
	
		public enum InputType // TypeDefIndex: 57319
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 57320
		{
			None = 0,
			Integer = 1,
			Decimal = 2,
			Alphanumeric = 3,
			Name = 4,
			EmailAddress = 5
		}
	
		public enum LineType // TypeDefIndex: 57321
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 57322; 0x00000001814F3120-0x00000001814F3140
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 57323
		{
			// Constructors
			public SubmitEvent(); // 0x000000018B5722A8-0x000000018B5722E4
		}
	
		[Serializable]
		public class EndEditEvent : UnityEvent<string> // TypeDefIndex: 57324
		{
			// Constructors
			public EndEditEvent(); // 0x000000018B568D1C-0x000000018B568D58
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 57325
		{
			// Constructors
			public OnChangeEvent(); // 0x000000018B5721D0-0x000000018B57220C
		}
	
		protected enum EditState // TypeDefIndex: 57326
		{
			Continue = 0,
			Finish = 1
		}
	
		[CompilerGenerated]
		private sealed class _CaretBlink_d__169 : IEnumerator<object> // TypeDefIndex: 57327
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public InputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _CaretBlink_d__169(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B5722E4-0x000000018B572404
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B572404-0x000000018B572450
		}
	
		[CompilerGenerated]
		private sealed class _MouseDragOutsideRect_d__191 : IEnumerator<object> // TypeDefIndex: 57328
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public PointerEventData eventData; // 0x20
			public InputField __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _MouseDragOutsideRect_d__191(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B57249C-0x000000018B572724
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B572724-0x000000018B572868
		}
	
		// Constructors
		protected InputField(); // 0x000000018B570814-0x000000018B570A08
		static InputField(); // 0x000000018B570778-0x000000018B570814
	
		// Methods
		public void SetTextWithoutNotify(string input); // 0x000000018B56F2F8-0x000000018B56F304
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x0234B03A */); // 0x000000018B56F304-0x000000018B56F678
		protected void ClampPos(ref int pos); // 0x000000018B56A0E8-0x000000018B56A11C
		protected override void OnEnable(); // 0x000000018B56DF84-0x000000018B56E1F4
		protected override void OnDisable(); // 0x000000018B56DB80-0x000000018B56DDCC
		[IteratorStateMachine(typeof(_CaretBlink_d__169))]
		private IEnumerator CaretBlink(); // 0x000000018B56A08C-0x000000018B56A0E8
		private void SetCaretVisible(); // 0x000000018B56ECE4-0x000000018B56ED24
		private void SetCaretActive(); // 0x000000018B56EC7C-0x000000018B56ECE4
		private void UpdateCaretMaterial(); // 0x000000018B56F7F0-0x000000018B56F8D4
		protected void OnFocus(); // 0x000000018B56E394-0x000000018B56E39C
		protected void SelectAll(); // 0x000000018B56EAD4-0x000000018B56EB0C
		public void MoveTextEnd(bool shift); // 0x000000018B56D9C4-0x000000018B56DA18
		public void MoveTextStart(bool shift); // 0x000000018B56DA18-0x000000018B56DA58
		private bool TouchScreenKeyboardShouldBeUsed(); // 0x000000018B56F6E0-0x000000018B56F740
		private bool InPlaceEditing(); // 0x000000018B56BEA0-0x000000018B56BEC4
		private bool InPlaceEditingChanged(); // 0x000000018B56BE44-0x000000018B56BEA0
		private void UpdateCaretFromKeyboard(); // 0x000000018B56F740-0x000000018B56F7F0
		protected virtual void LateUpdate(); // 0x000000018B56C46C-0x000000018B56D218
		[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
		public Vector2 ScreenToLocal(Vector2 screen); // 0x000000018B56E804-0x000000018B56EAD4
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator); // 0x000000018B56BCE0-0x000000018B56BE44
		protected int GetCharacterIndexFromPosition(Vector2 pos); // 0x000000018B56B8F8-0x000000018B56BAF0
		private bool MayDrag(PointerEventData eventData); // 0x000000018B56D65C-0x000000018B56D708
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018B56DB34-0x000000018B56DB58
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018B56DDCC-0x000000018B56DF84
		[IteratorStateMachine(typeof(_MouseDragOutsideRect_d__191))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData); // 0x000000018B56D708-0x000000018B56D77C
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018B56E1F4-0x000000018B56E218
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018B56E3C4-0x000000018B56E5B4
		protected EditState KeyPressed(UnityEngine.Event evt); // 0x000000018B56C098-0x000000018B56C46C
		private bool IsValidChar(char c); // 0x000000018B56C038-0x000000018B56C098
		public void ProcessEvent(UnityEngine.Event e); // 0x000000018B56E7EC-0x000000018B56E7F4
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x000000018B56E634-0x000000018B56E7EC
		private string GetSelectedString(); // 0x000000018B56BC54-0x000000018B56BCE0
		private int FindtNextWordBegin(); // 0x000000018B56A874-0x000000018B56A930
		private void MoveRight(bool shift, bool ctrl); // 0x000000018B56D918-0x000000018B56D9C4
		private int FindtPrevWordBegin(); // 0x000000018B56A930-0x000000018B56A9E4
		private void MoveLeft(bool shift, bool ctrl); // 0x000000018B56D86C-0x000000018B56D918
		private int DetermineCharacterLine(int charPos, TextGenerator generator); // 0x000000018B56A5F0-0x000000018B56A68C
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x000000018B56D408-0x000000018B56D610
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar); // 0x000000018B56D218-0x000000018B56D408
		private void MoveDown(bool shift); // 0x000000018B56D860-0x000000018B56D86C
		private void MoveDown(bool shift, bool goToLastChar); // 0x000000018B56D77C-0x000000018B56D860
		private void MoveUp(bool shift); // 0x000000018B56DA58-0x000000018B56DA64
		private void MoveUp(bool shift, bool goToFirstChar); // 0x000000018B56DA64-0x000000018B56DB34
		private void Delete(); // 0x000000018B56A418-0x000000018B56A5F0
		private void ForwardSpace(); // 0x000000018B56A9EC-0x000000018B56AA88
		private void Backspace(); // 0x000000018B569FAC-0x000000018B56A08C
		private void Insert(char c); // 0x000000018B56BEC4-0x000000018B56BFCC
		private void UpdateTouchKeyboardFromEditChanges(); // 0x000000018B5700F4-0x000000018B57013C
		private void SendOnValueChangedAndUpdateLabel(); // 0x000000018B56EBEC-0x000000018B56EC0C
		private void SendOnValueChanged(); // 0x000000018B56EC0C-0x000000018B56EC7C
		protected void SendOnEndEdit(); // 0x000000018B56EB0C-0x000000018B56EB7C
		protected void SendOnSubmit(); // 0x000000018B56EB7C-0x000000018B56EBEC
		protected virtual void Append(string input); // 0x000000018B569814-0x000000018B56989C
		protected virtual void Append(char input); // 0x000000018B569594-0x000000018B569814
		protected void UpdateLabel(); // 0x000000018B56FCC0-0x000000018B5700F4
		private bool IsSelectionVisible(); // 0x000000018B56BFCC-0x000000018B56C038
		private static int GetLineStartPosition(TextGenerator gen, int line); // 0x000000018B56BBAC-0x000000018B56BC54
		private static int GetLineEndPosition(TextGenerator gen, int line); // 0x000000018B56BAF0-0x000000018B56BBAC
		private void SetDrawRangeToContainCaretPosition(int caretPos); // 0x000000018B56ED24-0x000000018B56F2F8
		public void ForceLabelUpdate(); // 0x000000018B56A9E4-0x000000018B56A9EC
		private void MarkGeometryAsDirty(); // 0x000000018B56D610-0x000000018B56D65C
		public virtual void Rebuild(CanvasUpdate update); // 0x000000018B56E7F4-0x000000018B56E804
		public virtual void LayoutComplete(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void GraphicUpdateComplete(); // 0x00000001841E1670-0x00000001841E1680
		private void UpdateGeometry(); // 0x000000018B56F8D4-0x000000018B56FCC0
		private void AssignPositioningIfNeeded(); // 0x000000018B56989C-0x000000018B569FAC
		private void OnFillVBO(Mesh vbo); // 0x000000018B56E218-0x000000018B56E394
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset); // 0x000000018B56AA88-0x000000018B56B148
		private void CreateCursorVerts(); // 0x000000018B56A11C-0x000000018B56A284
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset); // 0x000000018B56B148-0x000000018B56B8F8
		protected char Validate(string text, int pos, char ch); // 0x000000018B57013C-0x000000018B570778
		public void ActivateInputField(); // 0x000000018B56947C-0x000000018B569594
		private void ActivateInputFieldInternal(); // 0x000000018B569180-0x000000018B56947C
		public override void OnSelect(BaseEventData eventData); // 0x000000018B56E5B4-0x000000018B56E5F0
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018B56E39C-0x000000018B56E3C4
		public void DeactivateInputField(); // 0x000000018B56A284-0x000000018B56A418
		public override void OnDeselect(BaseEventData eventData); // 0x000000018B56DB58-0x000000018B56DB80
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018B56E5F0-0x000000018B56E634
		private void EnforceContentType(); // 0x000000018B56A6B0-0x000000018B56A7E0
		private void EnforceTextHOverflow(); // 0x000000018B56A7E0-0x000000018B56A874
		private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes); // 0x000000018B56F678-0x000000018B56F6C8
		private void SetToCustom(); // 0x000000018B56F6C8-0x000000018B56F6E0
		protected override void DoStateTransition(SelectionState state, bool instant); // 0x000000018B56A68C-0x000000018B56A6B0
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class AspectRatioFitter : UIBehaviour, ILayoutSelfController // TypeDefIndex: 57331
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
		public AspectMode aspectMode { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B568AEC-0x000000018B568B44
		public float aspectRatio { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x000000018B568B44-0x000000018B568BA0
		private RectTransform rectTransform { get; } // 0x000000018449D7D0-0x000000018449D870 
	
		// Nested types
		public enum AspectMode // TypeDefIndex: 57330
		{
			None = 0,
			WidthControlsHeight = 1,
			HeightControlsWidth = 2,
			FitInParent = 3,
			EnvelopeParent = 4
		}
	
		// Constructors
		protected AspectRatioFitter(); // 0x0000000184CC8BA0-0x0000000184CC8BD0
	
		// Methods
		protected override void OnEnable(); // 0x000000018449D220-0x000000018449D2B0
		protected override void Start(); // 0x000000018449D1E0-0x000000018449D210
		protected override void OnDisable(); // 0x000000018449D2B0-0x000000018449D2F0
		protected override void OnTransformParentChanged(); // 0x000000018B568A6C-0x000000018B568AEC
		protected virtual void Update(); // 0x0000000184703A40-0x0000000184703A60
		protected override void OnRectTransformDimensionsChange(); // 0x000000018449D4C0-0x000000018449D4D0
		private void UpdateRect(); // 0x000000018449D4D0-0x000000018449D7D0
		private float GetSizeDeltaToProduceSize(float size, int axis); // 0x000000018449D2F0-0x000000018449D3F0
		private Vector2 GetParentSize(); // 0x000000018449D3F0-0x000000018449D4C0
		public virtual void SetLayoutHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void SetLayoutVertical(); // 0x00000001841E1670-0x00000001841E1680
		protected void SetDirty(); // 0x000000018449D4C0-0x000000018449D4D0
		public bool IsComponentValidOnObject(); // 0x000000018449D870-0x000000018449D8D0
		public bool IsAspectModeValid(); // 0x000000018449D210-0x000000018449D220
		private bool DoesParentExists(); // 0x0000000184D867B0-0x0000000184D867C0
	}

	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(Canvas))]
	public class CanvasScaler : UIBehaviour // TypeDefIndex: 57335
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
		private const float kLogBase = 2f; // Metadata: 0x0234B085
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
		public ScaleMode uiScaleMode { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
		public float referencePixelsPerUnit { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x0000000184D86900-0x0000000184D86910
		public float scaleFactor { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x000000018B568C58-0x000000018B568C6C
		public Vector2 referenceResolution { get; set; } // 0x0000000184D88060-0x0000000184D88080 0x0000000183C00870-0x0000000183C008C0
		public ScreenMatchMode screenMatchMode { get; set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public float matchWidthOrHeight { get; set; } // 0x0000000184D86E20-0x0000000184D86E30 0x0000000184D86E30-0x0000000184D86E40
		public Unit physicalUnit { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x0000000184D86760-0x0000000184D86770
		public float fallbackScreenDPI { get; set; } // 0x0000000184D88360-0x0000000184D88370 0x0000000184D88370-0x0000000184D88380
		public float defaultSpriteDPI { get; set; } // 0x0000000184D863E0-0x0000000184D863F0 0x000000018B568C44-0x000000018B568C58
		public float dynamicPixelsPerUnit { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
	
		// Nested types
		public enum ScaleMode // TypeDefIndex: 57332
		{
			ConstantPixelSize = 0,
			ScaleWithScreenSize = 1,
			ConstantPhysicalSize = 2
		}
	
		public enum ScreenMatchMode // TypeDefIndex: 57333
		{
			MatchWidthOrHeight = 0,
			Expand = 1,
			Shrink = 2
		}
	
		public enum Unit // TypeDefIndex: 57334
		{
			Centimeters = 0,
			Millimeters = 1,
			Inches = 2,
			Points = 3,
			Picas = 4
		}
	
		// Constructors
		protected CanvasScaler(); // 0x00000001844165B0-0x0000000184416620
	
		// Methods
		protected override void OnEnable(); // 0x0000000183099A20-0x0000000183099AA0
		private void Canvas_preWillRenderCanvases(); // 0x0000000182FC71A0-0x0000000182FC7330
		protected override void OnDisable(); // 0x0000000183099830-0x00000001830998B0
		public void HandleManually(); // 0x0000000183BFDC20-0x0000000183BFDCC0
		protected virtual void Handle(); // 0x0000000182FC7330-0x0000000182FC74C0
		protected virtual void HandleWorldCanvas(); // 0x00000001830998B0-0x0000000183099910
		protected virtual void HandleConstantPixelSize(); // 0x0000000184D7EDB0-0x0000000184D7EDE0
		protected virtual void HandleScaleWithScreenSize(); // 0x0000000182F108F0-0x0000000182F10BA0
		protected virtual void HandleConstantPhysicalSize(); // 0x000000018B568BA0-0x000000018B568C44
		protected void SetScaleFactor(float scaleFactor); // 0x0000000183099940-0x0000000183099990
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit); // 0x0000000183099910-0x0000000183099940
	}

	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController // TypeDefIndex: 57337
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
		public FitMode horizontalFit { get; set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x000000018B568C6C-0x000000018B568CC4
		public FitMode verticalFit { get; set; } // 0x0000000184D86310-0x0000000184D86320 0x000000018B568CC4-0x000000018B568D1C
		private RectTransform rectTransform { get; } // 0x00000001831E91F0-0x00000001831E9290 
	
		// Nested types
		public enum FitMode // TypeDefIndex: 57336
		{
			Unconstrained = 0,
			MinSize = 1,
			PreferredSize = 2
		}
	
		// Constructors
		protected ContentSizeFitter(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		protected override void OnEnable(); // 0x00000001831E8550-0x00000001831E8560
		protected override void OnDisable(); // 0x00000001831E8510-0x00000001831E8550
		protected override void OnRectTransformDimensionsChange(); // 0x00000001831E8550-0x00000001831E8560
		private void HandleSelfFittingAlongAxis(int axis); // 0x00000001831E9160-0x00000001831E91F0
		public virtual void SetLayoutHorizontal(); // 0x00000001831E90F0-0x00000001831E9160
		public virtual void SetLayoutVertical(); // 0x00000001853965AC-0x00000001853965BC
		protected void SetDirty(); // 0x00000001831E8560-0x00000001831E85B0
	}

	[AddComponentMenu("Layout/Grid Layout Group", 152)]
	public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 57341
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
		public Corner startCorner { get; set; } // 0x0000000184D86570-0x0000000184D86580 0x000000018B568F04-0x000000018B568F50
		public Axis startAxis { get; set; } // 0x0000000184D86560-0x0000000184D86570 0x000000018B568EB8-0x000000018B568F04
		public Vector2 cellSize { get; set; } // 0x0000000184DBEF20-0x0000000184DBEF40 0x000000018B568D64-0x000000018B568DB8
		public Vector2 spacing { get; set; } // 0x0000000184DBEF40-0x0000000184DBEF60 0x000000018B568E64-0x000000018B568EB8
		public Constraint constraint { get; set; } // 0x0000000184D868A0-0x0000000184D868B0 0x000000018B568E18-0x000000018B568E64
		public int constraintCount { get; set; } // 0x0000000184D868B0-0x0000000184D868C0 0x000000018B568DB8-0x000000018B568E18
	
		// Nested types
		public enum Corner // TypeDefIndex: 57338
		{
			UpperLeft = 0,
			UpperRight = 1,
			LowerLeft = 2,
			LowerRight = 3
		}
	
		public enum Axis // TypeDefIndex: 57339
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		public enum Constraint // TypeDefIndex: 57340
		{
			Flexible = 0,
			FixedColumnCount = 1,
			FixedRowCount = 2
		}
	
		// Constructors
		protected GridLayoutGroup(); // 0x00000001849D3A50-0x00000001849D3A80
	
		// Methods
		public override void CalculateLayoutInputHorizontal(); // 0x0000000183B92180-0x0000000183B922C0
		public override void CalculateLayoutInputVertical(); // 0x0000000183B91B00-0x0000000183B91C30
		public override void SetLayoutHorizontal(); // 0x000000018B568D58-0x000000018B568D64
		public override void SetLayoutVertical(); // 0x00000001853965BC-0x00000001853965CC
		private void SetCellsAlongAxis(int axis); // 0x0000000183B91C30-0x0000000183B920B0
	}

	[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 57342
	{
		// Constructors
		protected HorizontalLayoutGroup(); // 0x000000018416C540-0x000000018416C550
	
		// Methods
		public override void CalculateLayoutInputHorizontal(); // 0x0000000183B91900-0x0000000183B91930
		public override void CalculateLayoutInputVertical(); // 0x00000001853953A0-0x00000001853953B0
		public override void SetLayoutHorizontal(); // 0x00000001853915EC-0x00000001853915FC
		public override void SetLayoutVertical(); // 0x000000018539658C-0x000000018539659C
	}

	[ExecuteAlways]
	public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 57343
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
		public float spacing { get; set; } // 0x0000000184D88400-0x0000000184D88410 0x000000018B569130-0x000000018B569180
		public bool childForceExpandWidth { get; set; } // 0x0000000184D86D90-0x0000000184D86DA0 0x00000001845531B0-0x0000000184553200
		public bool childForceExpandHeight { get; set; } // 0x0000000184DA5B40-0x0000000184DA5B50 0x000000018B568FF0-0x000000018B569040
		public bool childControlWidth { get; set; } // 0x0000000184DA5B60-0x0000000184DA5B70 0x000000018B568FA0-0x000000018B568FF0
		public bool childControlHeight { get; set; } // 0x0000000184D8E420-0x0000000184D8E430 0x000000018B568F50-0x000000018B568FA0
		public bool childScaleWidth { get; set; } // 0x0000000184D88340-0x0000000184D88350 0x000000018B569090-0x000000018B5690E0
		public bool childScaleHeight { get; set; } // 0x0000000184D892D0-0x0000000184D892E0 0x000000018B569040-0x000000018B569090
		public bool reverseArrangement { get; set; } // 0x0000000184D8FF20-0x0000000184D8FF30 0x000000018B5690E0-0x000000018B569130
	
		// Constructors
		protected HorizontalOrVerticalLayoutGroup(); // 0x000000018416C540-0x000000018416C550
	
		// Methods
		protected void CalcAlongAxis(int axis, bool isVertical); // 0x00000001833F8790-0x00000001833F8D20
		protected void SetChildrenAlongAxis(int axis, bool isVertical); // 0x00000001833F7B20-0x00000001833F8790
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible); // 0x00000001833F8D20-0x00000001833F8FE0
	}

	public interface ILayoutElement // TypeDefIndex: 57344
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

	public interface ILayoutController // TypeDefIndex: 57345
	{
		// Methods
		void SetLayoutHorizontal();
		void SetLayoutVertical();
	}

	public interface ILayoutGroup : ILayoutController // TypeDefIndex: 57346
	{
	}

	public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 57347
	{
	}

	public interface ILayoutIgnorer // TypeDefIndex: 57348
	{
		// Properties
		bool ignoreLayout { get; }
	}

	[AddComponentMenu("Layout/Layout Element", 140)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 57349
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
		public virtual bool ignoreLayout { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x00000001833F1220-0x00000001833F12F0
		public virtual float minWidth { get; set; } // 0x0000000184D868F0-0x0000000184D86900 0x000000018B571BD4-0x000000018B571C30
		public virtual float minHeight { get; set; } // 0x00000001811EC8A0-0x00000001811EC8B0 0x000000018B571B78-0x000000018B571BD4
		public virtual float preferredWidth { get; set; } // 0x0000000184D89850-0x0000000184D89860 0x000000018344CDB0-0x000000018344CE10
		public virtual float preferredHeight { get; set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x000000018344CB70-0x000000018344CBD0
		public virtual float flexibleWidth { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x0000000183CD5350-0x0000000183CD5520
		public virtual float flexibleHeight { get; set; } // 0x0000000184D86E20-0x0000000184D86E30 0x000000018B571AC4-0x000000018B571B20
		public virtual int layoutPriority { get; set; } // 0x0000000184D86730-0x0000000184D86740 0x000000018B571B20-0x000000018B571B78
	
		// Constructors
		protected LayoutElement(); // 0x0000000183695EF0-0x0000000183695F50
	
		// Methods
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnEnable(); // 0x000000018344CBD0-0x000000018344CBE0
		protected override void OnTransformParentChanged(); // 0x000000018344CBD0-0x000000018344CBE0
		protected override void OnDisable(); // 0x000000018344CBD0-0x000000018344CBE0
		protected override void OnDidApplyAnimationProperties(); // 0x000000018344CBD0-0x000000018344CBE0
		protected override void OnBeforeTransformParentChanged(); // 0x000000018344CBD0-0x000000018344CBE0
		protected void SetDirty(); // 0x000000018344CBE0-0x000000018344CC70
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup // TypeDefIndex: 57351
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
		public RectOffset padding { get; set; } // 0x000000018385B100-0x000000018385B110 0x00000001849956B0-0x0000000184995700
		public TextAnchor childAlignment { get; set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x000000018B571CDC-0x000000018B571D28
		protected RectTransform rectTransform { get; } // 0x00000001831F1F20-0x00000001831F1FC0 
		protected List<RectTransform> rectChildren { get; } // 0x0000000184D86270-0x0000000184D86280 
		public virtual float minWidth { get; } // 0x00000001853957B0-0x00000001853957C0 
		public virtual float preferredWidth { get; } // 0x0000000185391670-0x0000000185391678 
		public virtual float flexibleWidth { get; } // 0x0000000185391650-0x0000000185391660 
		public virtual float minHeight { get; } // 0x0000000185391630-0x0000000185391640 
		public virtual float preferredHeight { get; } // 0x0000000185391640-0x0000000185391650 
		public virtual float flexibleHeight { get; } // 0x0000000185391660-0x0000000185391670 
		public virtual int layoutPriority { get; } // 0x00000001811EC580-0x00000001811EC590 
		private bool isRootLayoutGroup { get; } // 0x0000000183DC3580-0x0000000183DC3750 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DelayedSetDirty_d__56 : IEnumerator<object> // TypeDefIndex: 57350
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public RectTransform rectTransform; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _DelayedSetDirty_d__56(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000184294B40-0x0000000184294BC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B572450-0x000000018B57249C
		}
	
		// Constructors
		protected LayoutGroup(); // 0x0000000183695590-0x0000000183695650
	
		// Methods
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001831F1AA0-0x00000001831F1F20
		public abstract void CalculateLayoutInputVertical();
		public abstract void SetLayoutHorizontal();
		public abstract void SetLayoutVertical();
		protected override void OnEnable(); // 0x00000001844067D0-0x00000001844067E0
		protected override void OnDisable(); // 0x00000001842561A0-0x00000001842561E0
		protected override void OnDidApplyAnimationProperties(); // 0x00000001844067D0-0x00000001844067E0
		protected float GetTotalMinSize(int axis); // 0x000000018B571C3C-0x000000018B571C48
		protected float GetTotalPreferredSize(int axis); // 0x000000018539241C-0x0000000185392428
		protected float GetTotalFlexibleSize(int axis); // 0x000000018B571C30-0x000000018B571C3C
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding); // 0x00000001833F7010-0x00000001833F7270
		protected float GetAlignmentOnAxis(int axis); // 0x00000001833F7270-0x00000001833F72C0
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis); // 0x00000001833F76D0-0x00000001833F7740
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos); // 0x000000018B571C48-0x000000018B571CDC
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor); // 0x0000000183C5D6D0-0x0000000183C5D910
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size); // 0x0000000183B920B0-0x0000000183B92180
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor); // 0x00000001833F7400-0x00000001833F76D0
		protected override void OnRectTransformDimensionsChange(); // 0x0000000183DC3550-0x0000000183DC3580
		protected virtual void OnTransformChildrenChanged(); // 0x00000001844067D0-0x00000001844067E0
		protected void SetProperty<T>(ref ref T currentValue, T newValue);
		protected void SetDirty(); // 0x0000000183519E40-0x0000000183519EE0
		[IteratorStateMachine(typeof(_DelayedSetDirty_d__56))]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform); // 0x00000001843BB440-0x00000001843BB480
	}

	public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 57353
	{
		// Fields
		private RectTransform m_ToRebuild; // 0x10
		private int m_CachedHashFromTransform; // 0x18
		private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x00
	
		// Properties
		public Transform transform { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57352
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<UnityEngine.Component> __9__10_0; // 0x08
			public static UnityAction<UnityEngine.Component> __9__12_0; // 0x10
			public static UnityAction<UnityEngine.Component> __9__12_1; // 0x18
			public static UnityAction<UnityEngine.Component> __9__12_2; // 0x20
			public static UnityAction<UnityEngine.Component> __9__12_3; // 0x28
	
			// Constructors
			static __c(); // 0x0000000184D4C990-0x0000000184D4C9F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal LayoutRebuilder _.cctor_b__5_0(); // 0x000000018353E490-0x000000018353E4B0
			internal void _.cctor_b__5_1(LayoutRebuilder x); // 0x0000000183E504C0-0x0000000183E504F0
			internal bool _StripDisabledBehavioursFromList_b__10_0(UnityEngine.Component e); // 0x0000000183A18CE0-0x0000000183A18D80
			internal void _Rebuild_b__12_0(UnityEngine.Component e); // 0x0000000183B91740-0x0000000183B91900
			internal void _Rebuild_b__12_1(UnityEngine.Component e); // 0x00000001831E8FA0-0x00000001831E90F0
			internal void _Rebuild_b__12_2(UnityEngine.Component e); // 0x0000000183B91960-0x0000000183B91B00
			internal void _Rebuild_b__12_3(UnityEngine.Component e); // 0x0000000183EF8680-0x0000000183EF8850
		}
	
		// Constructors
		static LayoutRebuilder(); // 0x00000001848F3650-0x00000001848F3840
		public LayoutRebuilder(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private void Initialize(RectTransform controller); // 0x000000018351B220-0x000000018351B260
		private void Clear(); // 0x0000000185396170-0x0000000185396190
		private static void ReapplyDrivenProperties(RectTransform driven); // 0x0000000183EA5880-0x0000000183EA58B0
		public bool IsDestroyed(); // 0x00000001841916B0-0x00000001841917E0
		private static void StripDisabledBehavioursFromList(List<UnityEngine.Component> components); // 0x00000001831F0E10-0x00000001831F0F00
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot); // 0x0000000183543F10-0x0000000183543FC0
		public void Rebuild(CanvasUpdate executing); // 0x0000000183543FC0-0x0000000183544320
		private void PerformLayoutControl(RectTransform rect, UnityAction<UnityEngine.Component> action); // 0x00000001831F13B0-0x00000001831F1AA0
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<UnityEngine.Component> action); // 0x00000001831F0680-0x00000001831F0DD0
		public static void MarkLayoutForRebuild(RectTransform rect); // 0x0000000182FCBF00-0x0000000182FCCC70
		private static bool ValidController(RectTransform layoutRoot, List<UnityEngine.Component> comps); // 0x00000001831F0F50-0x00000001831F1230
		private static void MarkLayoutRootForRebuild(RectTransform controller); // 0x000000018351AF00-0x000000018351B220
		public void LayoutComplete(); // 0x00000001840E03C0-0x00000001840E0410
		public void GraphicUpdateComplete(); // 0x00000001841E1670-0x00000001841E1680
		public override int GetHashCode(); // 0x00000001811EF5B0-0x00000001811EF5C0
		public override bool Equals(object obj); // 0x0000000183D30750-0x0000000183D307A0
		public override string ToString(); // 0x000000018B571D28-0x000000018B571D88
	}

	public static class LayoutUtility // TypeDefIndex: 57355
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57354
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
			static __c(); // 0x0000000184D4CB70-0x0000000184D4CBD0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _GetMinWidth_b__3_0(ILayoutElement e); // 0x0000000183C6D650-0x0000000183C6D670
			internal float _GetPreferredWidth_b__4_0(ILayoutElement e); // 0x0000000183C6D670-0x0000000183C6D7B0
			internal float _GetPreferredWidth_b__4_1(ILayoutElement e); // 0x00000001831E9B20-0x00000001831E9C70
			internal float _GetFlexibleWidth_b__5_0(ILayoutElement e); // 0x00000001831E95A0-0x00000001831E96D0
			internal float _GetMinHeight_b__6_0(ILayoutElement e); // 0x00000001831E97C0-0x00000001831E9890
			internal float _GetPreferredHeight_b__7_0(ILayoutElement e); // 0x00000001831E97C0-0x00000001831E9890
			internal float _GetPreferredHeight_b__7_1(ILayoutElement e); // 0x00000001831E96D0-0x00000001831E97C0
			internal float _GetFlexibleHeight_b__8_0(ILayoutElement e); // 0x00000001831E9890-0x00000001831E99C0
		}
	
		// Methods
		public static float GetMinSize(RectTransform rect, int axis); // 0x00000001833F9120-0x00000001833F9230
		public static float GetPreferredSize(RectTransform rect, int axis); // 0x00000001833F8FE0-0x00000001833F9010
		public static float GetFlexibleSize(RectTransform rect, int axis); // 0x00000001833F9010-0x00000001833F9120
		public static float GetMinWidth(RectTransform rect); // 0x00000001833F7A30-0x00000001833F7B20
		public static float GetPreferredWidth(RectTransform rect); // 0x00000001833F9410-0x00000001833F95F0
		public static float GetFlexibleWidth(RectTransform rect); // 0x00000001833F7940-0x00000001833F7A30
		public static float GetMinHeight(RectTransform rect); // 0x0000000183DB8680-0x0000000183DB8770
		public static float GetPreferredHeight(RectTransform rect); // 0x00000001833F9230-0x00000001833F9410
		public static float GetFlexibleHeight(RectTransform rect); // 0x0000000183DB8770-0x0000000183DB8860
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue); // 0x0000000185392498-0x00000001853924B8
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source); // 0x00000001831EF3A0-0x00000001831F0020
	}

	[AddComponentMenu("Layout/Vertical Layout Group", 151)]
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 57356
	{
		// Constructors
		protected VerticalLayoutGroup(); // 0x000000018416C540-0x000000018416C550
	
		// Methods
		public override void CalculateLayoutInputHorizontal(); // 0x0000000183B91930-0x0000000183B91960
		public override void CalculateLayoutInputVertical(); // 0x00000001853953B0-0x00000001853953C0
		public override void SetLayoutHorizontal(); // 0x00000001853915FC-0x000000018539160C
		public override void SetLayoutVertical(); // 0x000000018539659C-0x00000001853965AC
	}

	[AddComponentMenu("UI/Mask", 13)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 57357
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
		public RectTransform rectTransform { get; } // 0x0000000183091280-0x00000001830912E0 
		public bool showMaskGraphic { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x000000018B571D88-0x000000018B571E14
		public Graphic graphic { get; } // 0x00000001841D2210-0x00000001841D2250 
	
		// Constructors
		protected Mask(); // 0x000000018489D040-0x000000018489D070
	
		// Methods
		public virtual bool MaskEnabled(); // 0x00000001841D1CA0-0x00000001841D1D30
		[Obsolete("Not used anymore.")]
		public virtual void OnSiblingGraphicEnabledDisabled(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnEnable(); // 0x00000001841D20C0-0x00000001841D2210
		protected override void OnDisable(); // 0x00000001841D1D30-0x00000001841D1F10
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x00000001830911F0-0x0000000183091280
		public virtual Material GetModifiedMaterial(Material baseMaterial); // 0x00000001841D1F10-0x00000001841D20C0
	}

	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 57359
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
		public CullStateChangedEvent onCullStateChanged { get; set; } // 0x0000000184D876B0-0x0000000184D876C0 0x000000018678D7BC-0x000000018678D7D0
		public bool maskable { get; set; } // 0x0000000184D8E270-0x0000000184D8E280 0x000000018B5721A8-0x000000018B5721D0
		public bool isMaskingGraphic { get; set; } // 0x0000000184DA2350-0x0000000184DA2360 0x00000001841D2380-0x00000001841D2390
		internal virtual bool hasCullOverride { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		private Rect rootCanvasRect { get; } // 0x000000018B571E74-0x000000018B5721A8 
		GameObject IClippable.gameObject { get; } // 0x00000001853916BC-0x00000001853916C4 
	
		// Nested types
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 57358
		{
			// Constructors
			public CullStateChangedEvent(); // 0x000000018539350C-0x0000000185393520
		}
	
		// Constructors
		protected MaskableGraphic(); // 0x0000000183696ED0-0x0000000183697340
	
		// Methods
		internal void UpdateCullDirect(bool cull); // 0x00000001831E9E20-0x00000001831E9E80
		public virtual Material GetModifiedMaterial(Material baseMaterial); // 0x00000001831EE3E0-0x00000001831EE800
		public virtual void Cull(Rect clipRect, bool validRect); // 0x000000018B571E14-0x000000018B571E74
		private void UpdateCull(bool cull); // 0x00000001831EB1D0-0x00000001831EB2C0
		public virtual void SetClipRect(Rect clipRect, bool validRect); // 0x00000001831EB0E0-0x00000001831EB190
		public virtual void SetClipSoftness(Vector2 clipSoftness); // 0x00000001831BFD70-0x00000001831BFEC0
		public virtual void SetHGClipSoftness(Vector4 hgClipSoftness); // 0x00000001831BFC20-0x00000001831BFD70
		protected override void OnEnable(); // 0x00000001831EBD20-0x00000001831EBEA0
		protected override void OnDisable(); // 0x000000018351A3E0-0x000000018351A480
		protected override void OnTransformParentChanged(); // 0x0000000183F3AEA0-0x0000000183F3AF00
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore.", true)]
		public virtual void ParentMaskStateChanged(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnCanvasHierarchyChanged(); // 0x00000001831C3D80-0x00000001831C3F80
		private void UpdateClipParent(); // 0x00000001831EC620-0x00000001831EC810
		public virtual void RecalculateClipping(); // 0x0000000183F59BE0-0x0000000183F59BF0
		public virtual void RecalculateMasking(); // 0x000000018351C410-0x000000018351C480
	}

	public class MaskUtilities // TypeDefIndex: 57360
	{
		// Constructors
		public MaskUtilities(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void Notify2DMaskStateChanged(UnityEngine.Component mask); // 0x00000001831EF090-0x00000001831EF3A0
		public static void NotifyStencilStateChanged(UnityEngine.Component mask); // 0x00000001841D23E0-0x00000001841D25F0
		public static Transform FindRootSortOverrideCanvas(Transform start); // 0x00000001831ED4E0-0x00000001831ED780
		public static int GetStencilDepth(Transform transform, Transform stopAfter); // 0x00000001831ED130-0x00000001831ED4E0
		public static bool IsDescendantOrSelf(Transform father, Transform child); // 0x00000001831EB530-0x00000001831EB7B0
		public static RectMask2D GetRectMaskForClippable(IClippable clippable); // 0x00000001831EC810-0x00000001831ED130
		public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks); // 0x0000000183D91980-0x0000000183D91BD0
	}

	public interface IMaterialModifier // TypeDefIndex: 57361
	{
		// Methods
		Material GetModifiedMaterial(Material baseMaterial);
	}

	internal static class Misc // TypeDefIndex: 57362
	{
		// Methods
		public static void Destroy(UnityEngine.Object obj); // 0x000000018B572CC8-0x000000018B572D94
		public static void DestroyImmediate(UnityEngine.Object obj); // 0x000000018485FD10-0x000000018485FDA0
	}

	internal static class MultipleDisplayUtilities // TypeDefIndex: 57363
	{
		// Methods
		public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position); // 0x000000018B572D94-0x000000018B572E6C
		public static Vector3 RelativeMouseAtScaled(Vector2 position); // 0x000000018324F2F0-0x000000018324F740
	}

	[Serializable]
	public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 57365
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
		public Mode mode { get; set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public bool wrapAround { get; set; } // 0x0000000184D90BB0-0x0000000184D90BC0 0x0000000184D90BC0-0x0000000184D90BD0
		public Selectable selectOnUp { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public Selectable selectOnDown { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public Selectable selectOnLeft { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public Selectable selectOnRight { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x0000000185390F40-0x0000000185390F50
		public static Navigation defaultNavigation { get; } // 0x0000000184DBEFF0-0x0000000184DBF010 
	
		// Nested types
		[Flags]
		public enum Mode // TypeDefIndex: 57364
		{
			None = 0,
			Horizontal = 1,
			Vertical = 2,
			Automatic = 3,
			Explicit = 4
		}
	
		// Methods
		public bool Equals(Navigation other); // 0x0000000183E58120-0x0000000183E58220
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class RawImage : MaskableGraphic // TypeDefIndex: 57366
	{
		// Fields
		[FormerlySerializedAs("m_Tex")]
		[SerializeField]
		private Texture m_Texture; // 0xE8
		[SerializeField]
		private Rect m_UVRect; // 0xF0
	
		// Properties
		internal override bool hasCullOverride { get; } // 0x00000001812081B0-0x0000000181208610 
		public override Texture mainTexture { get; } // 0x000000018429BCE0-0x000000018429BEB0 
		public Texture texture { get; set; } // 0x0000000184D88590-0x0000000184D885A0 0x00000001837DC210-0x00000001837DC2B0
		public Rect uvRect { get; set; } // 0x0000000184DA1270-0x0000000184DA1280 0x000000018B572FA4-0x000000018B573004
	
		// Constructors
		protected RawImage(); // 0x00000001839C5080-0x00000001839C50B0
	
		// Methods
		public override void SetNativeSize(); // 0x000000018B572E6C-0x000000018B572FA4
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000184032A90-0x0000000184032EA0
		protected override void OnDidApplyAnimationProperties(); // 0x0000000183E51A10-0x0000000183E51A40
	}

	[AddComponentMenu("UI/Rect Mask 2D", 14)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 57367
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
		public Vector4 padding { get; set; } // 0x0000000184DA8720-0x0000000184DA8730 0x000000018B573E70-0x000000018B573E80
		public Vector2Int softness { get; set; } // 0x0000000184DBF020-0x0000000184DBF030 0x000000018B573E80-0x000000018B573EA8
		public Vector4 hgSoftness { get; set; } // 0x0000000184DBF010-0x0000000184DBF020 0x000000018B573E30-0x000000018B573E70
		private Canvas Canvas { get; } // 0x00000001831C28A0-0x00000001831C29F0 
		public Rect canvasRect { get; } // 0x000000018B573B54-0x000000018B573BCC 
		public RectTransform rectTransform { get; } // 0x00000001831BF930-0x00000001831BF970 
		private Rect rootCanvasRect { get; } // 0x000000018B573BCC-0x000000018B573E30 
		internal bool shouldRecalculateClipRects { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		internal List<RectMask2D> clippers { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		internal HashSet<MaskableGraphic> maskableTargets { get; } // 0x0000000184D86240-0x0000000184D86250 
		internal HashSet<IClippable> clipTargets { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		internal Rect lastClipRectCanvasSpace { get; set; } // 0x0000000184D8FD50-0x0000000184D8FD60 0x0000000184D91540-0x0000000184D91550
		internal bool forceClip { get; set; } // 0x0000000184D86F70-0x0000000184D86F80 0x0000000184D86F80-0x0000000184D86F90
		internal Canvas canvasRef { get; } // 0x00000001853914B4-0x00000001853914BC 
	
		// Constructors
		protected RectMask2D(); // 0x000000018404D490-0x000000018404D5C0
	
		// Methods
		protected override void OnEnable(); // 0x0000000184424720-0x0000000184424750
		protected override void OnDisable(); // 0x0000000183D918E0-0x0000000183D91950
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x00000001830933E0-0x0000000183093490
		public virtual void PerformClipping(); // 0x000000018B573458-0x000000018B573B54
		public virtual void UpdateClipSoftness(); // 0x00000001831C1D80-0x00000001831C2170
		public void AddClippable(IClippable clippable); // 0x00000001831EB2C0-0x00000001831EB3E0
		public void RemoveClippable(IClippable clippable); // 0x00000001831EAE20-0x00000001831EB0E0
		protected override void OnTransformParentChanged(); // 0x0000000184D919E0-0x0000000184D919F0
		protected override void OnCanvasHierarchyChanged(); // 0x00000001842ADE00-0x00000001842ADE30
		internal void RecalculateClipperChain(); // 0x0000000183D91950-0x0000000183D91980
	}

	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Scrollbar : Selectable, IBeginDragHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 57372
	{
		// Fields
		[SerializeField]
		private RectTransform m_HandleRect; // 0x188
		[SerializeField]
		private Direction m_Direction; // 0x190
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Value; // 0x194
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Size; // 0x198
		[Range(0f, 11f)]
		[SerializeField]
		private int m_NumberOfSteps; // 0x19C
		[SerializeField]
		[Space(6f)]
		private ScrollEvent m_OnValueChanged; // 0x1A0
		private RectTransform m_ContainerRect; // 0x1A8
		private Vector2 m_Offset; // 0x1B0
		private DrivenRectTransformTracker m_Tracker; // 0x1B8
		private Coroutine m_PointerDownRepeat; // 0x1C0
		private bool isPointerDownAndNotDragging; // 0x1C8
		private bool m_DelayedUpdateVisuals; // 0x1C9
	
		// Properties
		public RectTransform handleRect { get; set; } // 0x0000000184D8DA20-0x0000000184D8DA30 0x000000018B576148-0x000000018B5761B0
		public Direction direction { get; set; } // 0x0000000184DBF060-0x0000000184DBF070 0x000000018B5760EC-0x000000018B576148
		public float value { get; set; } // 0x0000000184033F40-0x0000000184033F70 0x0000000185396DA0-0x0000000185396DAC
		public float size { get; set; } // 0x0000000184D8EDC0-0x0000000184D8EDD0 0x0000000184033C10-0x0000000184033C50
		public int numberOfSteps { get; set; } // 0x0000000184D8F920-0x0000000184D8F930 0x000000018B5761B0-0x000000018B576220
		public ScrollEvent onValueChanged { get; set; } // 0x0000000184D8DA10-0x0000000184D8DA20 0x0000000185397204-0x0000000185397218
		private float stepSize { get; } // 0x000000018B5760BC-0x000000018B5760EC 
		private Axis axis { get; } // 0x0000000184033F20-0x0000000184033F40 
		private bool reverseValue { get; } // 0x0000000184033F70-0x0000000184033F90 
		Transform ICanvasElement.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Nested types
		public enum Direction // TypeDefIndex: 57368
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}
	
		[Serializable]
		public class ScrollEvent : UnityEvent<float> // TypeDefIndex: 57369
		{
			// Constructors
			public ScrollEvent(); // 0x000000018453A600-0x000000018453A640
		}
	
		private enum Axis // TypeDefIndex: 57370
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		[CompilerGenerated]
		private sealed class _ClickRepeat_d__58 : IEnumerator<object> // TypeDefIndex: 57371
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Scrollbar __4__this; // 0x20
			public Vector2 screenPosition; // 0x28
			public Camera camera; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _ClickRepeat_d__58(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B57A574-0x000000018B57A79C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B57A79C-0x000000018B57A7E8
		}
	
		// Constructors
		protected Scrollbar(); // 0x000000018453A550-0x000000018453A600
	
		// Methods
		public virtual void SetValueWithoutNotify(float input); // 0x000000018B575E2C-0x000000018B575E38
		public virtual void Rebuild(CanvasUpdate executing); // 0x00000001841E1670-0x00000001841E1680
		public virtual void LayoutComplete(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void GraphicUpdateComplete(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnEnable(); // 0x0000000184033C80-0x0000000184033CE0
		protected override void OnDisable(); // 0x000000018447EC90-0x000000018447ECA0
		protected virtual void Update(); // 0x0000000184D265A0-0x0000000184D265C0
		private void UpdateCachedReferences(); // 0x0000000184033F90-0x00000001840340B0
		private void Set(float input, bool sendCallback = true /* Metadata: 0x0234B0A5 */); // 0x0000000184033CE0-0x0000000184033D80
		protected override void OnRectTransformDimensionsChange(); // 0x0000000184033C50-0x0000000184033C80
		private void UpdateVisuals(); // 0x0000000184033D80-0x0000000184033F20
		private void UpdateDrag(PointerEventData eventData); // 0x000000018B575E38-0x000000018B5760BC
		private void DoUpdateDrag(Vector2 handleCorner, float remainingSize); // 0x000000018B5755D4-0x000000018B575640
		private bool MayDrag(PointerEventData eventData); // 0x000000018B575710-0x000000018B575764
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018B575764-0x000000018B575974
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018B575974-0x000000018B5759FC
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018B575C08-0x000000018B575CD0
		protected IEnumerator ClickRepeat(PointerEventData eventData); // 0x000000018B57555C-0x000000018B5755D4
		[IteratorStateMachine(typeof(_ClickRepeat_d__58))]
		protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera); // 0x000000018B5754CC-0x000000018B57555C
		public override void OnPointerUp(PointerEventData eventData); // 0x000000018B575CD0-0x000000018B575CF0
		public override void OnMove(AxisEventData eventData); // 0x000000018B575A18-0x000000018B575C08
		public override Selectable FindSelectableOnLeft(); // 0x000000018B575674-0x000000018B5756A8
		public override Selectable FindSelectableOnRight(); // 0x000000018B5756A8-0x000000018B5756DC
		public override Selectable FindSelectableOnUp(); // 0x000000018B5756DC-0x000000018B575710
		public override Selectable FindSelectableOnDown(); // 0x000000018B575640-0x000000018B575674
		public virtual void OnInitializePotentialDrag(PointerEventData eventData); // 0x000000018B5759FC-0x000000018B575A18
		public void SetDirection(Direction direction, bool includeRectLayouts); // 0x000000018B575CF0-0x000000018B575E2C
	}

	[DisallowMultipleComponent]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[SelectionBase]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup // TypeDefIndex: 57376
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
		public RectTransform content { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool horizontal { get; set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
		public bool vertical { get; set; } // 0x0000000184D86850-0x0000000184D86860 0x0000000184D86860-0x0000000184D86870
		public MovementType movementType { get; set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		public float elasticity { get; set; } // 0x0000000184D8E050-0x0000000184D8E060 0x0000000184D8E060-0x0000000184D8E070
		public bool inertia { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x00000001811F2A80-0x00000001811F2A90
		public float decelerationRate { get; set; } // 0x0000000184D863E0-0x0000000184D863F0 0x0000000184D86460-0x0000000184D86470
		public float scrollSensitivity { get; set; } // 0x0000000184D863F0-0x0000000184D86400 0x0000000184D86470-0x0000000184D86480
		public RectTransform viewport { get; set; } // 0x0000000184D86200-0x0000000184D86210 0x000000018B5754A8-0x000000018B5754CC
		public Scrollbar horizontalScrollbar { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x000000018B575144-0x000000018B5752CC
		public Scrollbar verticalScrollbar { get; set; } // 0x0000000182E56440-0x0000000182E56460 0x000000018B575320-0x000000018B5754A8
		public ScrollbarVisibility horizontalScrollbarVisibility { get; set; } // 0x0000000184D86790-0x0000000184D867A0 0x000000018B575138-0x000000018B575144
		public ScrollbarVisibility verticalScrollbarVisibility { get; set; } // 0x0000000184D88110-0x0000000184D88120 0x000000018B575314-0x000000018B575320
		public float horizontalScrollbarSpacing { get; set; } // 0x0000000184D8F060-0x0000000184D8F070 0x000000018B57512C-0x000000018B575138
		public float verticalScrollbarSpacing { get; set; } // 0x0000000184DA3230-0x0000000184DA3240 0x000000018B575308-0x000000018B575314
		public ScrollRectEvent onValueChanged { get; set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		protected RectTransform viewRect { get; } // 0x00000001833F6EF0-0x00000001833F7010 
		public Vector2 velocity { get; set; } // 0x0000000184DBF030-0x0000000184DBF050 0x0000000184DBF050-0x0000000184DBF060
		private RectTransform rectTransform { get; } // 0x00000001839D3BC0-0x00000001839D3C60 
		public Vector2 normalizedPosition { get; set; } // 0x000000018396F070-0x000000018396F0B0 0x000000018B5752CC-0x000000018B575308
		public float horizontalNormalizedPosition { get; set; } // 0x000000018396F0B0-0x000000018396F250 0x0000000185397FA8-0x0000000185397FB4
		public float verticalNormalizedPosition { get; set; } // 0x000000018396F250-0x000000018396F410 0x00000001853945E8-0x00000001853945F8
		public bool hScrollingNeeded { get; } // 0x0000000183E5E6B0-0x0000000183E5E750 
		public bool vScrollingNeeded { get; } // 0x0000000183E5E600-0x0000000183E5E6B0 
		public virtual float minWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float preferredWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float flexibleWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float minHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float preferredHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float flexibleHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual int layoutPriority { get; } // 0x0000000184DA2BB0-0x0000000184DA2BC0 
		Transform ICanvasElement.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Nested types
		public enum MovementType // TypeDefIndex: 57373
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		public enum ScrollbarVisibility // TypeDefIndex: 57374
		{
			Permanent = 0,
			AutoHide = 1,
			AutoHideAndExpandViewport = 2
		}
	
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 57375
		{
			// Constructors
			public ScrollRectEvent(); // 0x0000000185396540-0x0000000185396550
		}
	
		// Constructors
		protected ScrollRect(); // 0x0000000183EB2B60-0x0000000183EB2CB0
	
		// Methods
		public virtual void Rebuild(CanvasUpdate executing); // 0x0000000184033360-0x00000001840333C0
		public virtual void LayoutComplete(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void GraphicUpdateComplete(); // 0x00000001841E1670-0x00000001841E1680
		private void UpdateCachedData(); // 0x00000001840337D0-0x0000000184033C10
		protected override void OnEnable(); // 0x00000001839D39F0-0x00000001839D3B60
		protected override void OnDisable(); // 0x00000001839D37F0-0x00000001839D39B0
		public override bool IsActive(); // 0x00000001845E1060-0x00000001845E10E0
		public void EnsureLayoutHasRebuilt(); // 0x00000001833F6720-0x00000001833F6770
		public virtual void StopMovement(); // 0x000000018B575100-0x000000018B57510C
		public virtual void OnScroll(PointerEventData data); // 0x000000018B574E34-0x000000018B575018
		protected virtual void _CustomSetPosOnScroll(Vector2 position); // 0x000000018B57510C-0x000000018B57512C
		public virtual void OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000184A26320-0x0000000184A26350
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018B5749F4-0x000000018B574B20
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018B574E10-0x000000018B574E34
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018B574B20-0x000000018B574E10
		protected virtual void SetContentAnchoredPosition(Vector2 position); // 0x00000001839722E0-0x00000001839723E0
		protected virtual void LateUpdate(); // 0x00000001833F4C20-0x00000001833F5380
		protected void UpdatePrevData(); // 0x0000000184033630-0x0000000184033740
		protected virtual void UpdateScrollbars(Vector2 offset); // 0x0000000184033480-0x0000000184033630
		protected virtual void SetHorizontalNormalizedPosition(float value); // 0x0000000185397FA8-0x0000000185397FB4
		protected virtual void SetVerticalNormalizedPosition(float value); // 0x0000000184573010-0x0000000184573020
		protected virtual void SetNormalizedPosition(float value, int axis); // 0x0000000184573020-0x0000000184573330
		private static float RubberDelta(float overStretching, float viewSize); // 0x000000018B575018-0x000000018B575060
		protected override void OnRectTransformDimensionsChange(); // 0x00000001839D3B60-0x00000001839D3B70
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void SetLayoutHorizontal(); // 0x0000000184033740-0x00000001840337D0
		public virtual void SetLayoutVertical(); // 0x0000000183EF8850-0x0000000183EF89B0
		private void UpdateScrollbarVisibility(); // 0x0000000183270630-0x0000000183270900
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar); // 0x0000000183270900-0x00000001832709C0
		private void UpdateScrollbarLayout(); // 0x0000000183EF89B0-0x0000000183EF8AB0
		protected virtual void UpdateScrollEnableNode(); // 0x0000000183E0B730-0x0000000183E0B7B0
		protected void UpdateBounds(); // 0x00000001833F6990-0x00000001833F6EF0
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos); // 0x00000001833F6850-0x00000001833F6990
		private Bounds GetBounds(); // 0x0000000182F3C280-0x0000000182F3C5E0
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix); // 0x0000000182F3C5E0-0x0000000182F3C7C0
		protected Vector2 CalculateOffset(Vector2 delta); // 0x00000001833F6440-0x00000001833F6490
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta); // 0x00000001833F6490-0x00000001833F6720
		protected void SetDirty(); // 0x00000001839D3B70-0x00000001839D3BC0
		protected void SetDirtyCaching(); // 0x000000018B575060-0x000000018B575100
	}

	[AddComponentMenu("UI/Selectable", 35)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[SelectionBase]
	public class Selectable : UIBehaviour, IMoveHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 57379
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
		[CompilerGenerated]
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
		public Func<NaviDirection, Selectable> customNaviTargetInDirFunc; // 0x138
		[SerializeField]
		private Selectable m_ExplicitSelectOnLeft; // 0x140
		[SerializeField]
		private Selectable m_ExplicitSelectOnRight; // 0x148
		[SerializeField]
		private Selectable m_ExplicitSelectOnUp; // 0x150
		[SerializeField]
		private Selectable m_ExplicitSelectOnDown; // 0x158
		[CompilerGenerated]
		private bool _isNaviTarget_k__BackingField; // 0x160
		public Action<bool, bool, bool> onIsNaviTargetChanged; // 0x168
		[CompilerGenerated]
		private bool _isNavigationSilent_k__BackingField; // 0x170
		public SelectableNaviGroup naviGroup; // 0x178
		private bool m_naviInited; // 0x180
	
		// Properties
		public static Selectable[] allSelectablesArray { get; } // 0x000000018B577454-0x000000018B5774D8 
		public static int allSelectableCount { get; } // 0x000000018B577404-0x000000018B577454 
		[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", false)]
		public static List<Selectable> allSelectables { get; } // 0x000000018B5774D8-0x000000018B577568 
		public string hoverAudioKey { get; } // 0x0000000184D8D1A0-0x0000000184D8D1B0 
		public Navigation navigation { get; set; } // 0x0000000184D8E8C0-0x0000000184D8E8E0 0x00000001837D4B20-0x00000001837D4B70
		public Transition transition { get; set; } // 0x0000000184D863D0-0x0000000184D863E0 0x000000018B57776C-0x000000018B5777C4
		public ColorBlock colors { get; set; } // 0x0000000184DBF070-0x0000000184DBF0B0 0x000000018B577604-0x000000018B5776A0
		public SpriteState spriteState { get; set; } // 0x0000000184DBF0B0-0x0000000184DBF0D0 0x000000018B5776A0-0x000000018B577710
		public AnimationTriggers animationTriggers { get; set; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 0x000000018B5775A8-0x000000018B577604
		public Graphic targetGraphic { get; set; } // 0x0000000184D88EF0-0x0000000184D88F00 0x000000018B577710-0x000000018B57776C
		public bool interactable { get; set; } // 0x0000000184D90CF0-0x0000000184D90D00 0x0000000183409A80-0x0000000183409AC0
		private bool isPointerInside { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DA5D60-0x0000000184DA5D70 0x0000000184DBF0E0-0x0000000184DBF0F0
		private bool isPointerDown { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAA4D0-0x0000000184DAA4E0 0x0000000184DBF0D0-0x0000000184DBF0E0
		private bool hasSelection { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8C8D0-0x0000000184D8C8E0 0x0000000184D8C900-0x0000000184D8C910
		public Image image { get; set; } // 0x000000018B577568-0x000000018B5775A8 0x0000000186902698-0x00000001869026AC
		public Animator animator { get; } // 0x0000000185393874-0x0000000185393880 
		protected SelectionState currentSelectionState { get; } // 0x0000000183795D60-0x0000000183795DB0 
		public UnityEvent<bool> onHoverChange { [CompilerGenerated] get; } // 0x0000000184D8D1B0-0x0000000184D8D1C0 
		public bool isNaviTarget { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D8E6A0-0x0000000184D8E6B0 0x0000000184D90350-0x0000000184D90360
		public bool isNavigationSilent { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D905A0-0x0000000184D905B0 0x0000000184D905B0-0x0000000184D905C0
	
		// Nested types
		public enum Transition // TypeDefIndex: 57377
		{
			None = 0,
			ColorTint = 1,
			SpriteSwap = 2,
			Animation = 3
		}
	
		protected enum SelectionState // TypeDefIndex: 57378
		{
			Normal = 0,
			Highlighted = 1,
			Pressed = 2,
			Selected = 3,
			Disabled = 4
		}
	
		// Constructors
		protected Selectable(); // 0x0000000183697410-0x0000000183697710
		static Selectable(); // 0x0000000184CB0DE0-0x0000000184CB0ED0
	
		// Methods
		public static int AllSelectablesNoAlloc(Selectable[] selectables); // 0x000000018B576240-0x000000018B5762E8
		protected override void Awake(); // 0x00000001837D4960-0x00000001837D4B20
		protected void OnCanvasGroupChanged(); // 0x0000000182FC9670-0x0000000182FC99B0
		public virtual bool IsInteractable(); // 0x0000000183795DB0-0x0000000183795DD0
		protected override void OnDidApplyAnimationProperties(); // 0x000000018B576E4C-0x000000018B576E54
		protected override void OnEnable(); // 0x0000000183794EC0-0x0000000183795240
		protected override void OnTransformParentChanged(); // 0x0000000184892DC0-0x0000000184892DD0
		private void OnSetProperty(); // 0x00000001837D5010-0x00000001837D5040
		protected override void OnDisable(); // 0x0000000183795DD0-0x0000000183795F90
		private void OnApplicationFocus(bool hasFocus); // 0x00000001837974D0-0x0000000183797500
		protected virtual void InstantClearState(); // 0x00000001837962A0-0x00000001837963D0
		protected virtual void DoStateTransition(SelectionState state, bool instant); // 0x0000000183796050-0x00000001837962A0
		public Selectable FindSelectable(Vector3 dir); // 0x000000018B576638-0x000000018B576AF8
		private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir); // 0x000000018B576B98-0x000000018B576D6C
		private void Navigate(AxisEventData eventData, Selectable sel); // 0x000000018B576DBC-0x000000018B576E4C
		public virtual Selectable FindSelectableOnLeft(); // 0x000000018B576428-0x000000018B5764D8
		public virtual Selectable FindSelectableOnRight(); // 0x000000018B5764D8-0x000000018B576588
		public virtual Selectable FindSelectableOnUp(); // 0x000000018B576588-0x000000018B576638
		public virtual Selectable FindSelectableOnDown(); // 0x000000018B576378-0x000000018B576428
		public virtual void OnMove(AxisEventData eventData); // 0x000000018B576E54-0x000000018B576EC4
		private void StartColorTween(UnityEngine.Color targetColor, bool instant); // 0x0000000183796550-0x0000000183796660
		private void DoSpriteSwap(Sprite newSprite); // 0x000000018B5762E8-0x000000018B576378
		private void TriggerAnimation(string triggername); // 0x00000001837966B0-0x0000000183796920
		protected bool IsHighlighted(); // 0x000000018B576D6C-0x000000018B576DBC
		protected bool IsPressed(); // 0x0000000183797500-0x0000000183797540
		private void EvaluateAndTransitionToSelectionState(); // 0x000000018379B190-0x000000018379B520
		public virtual void OnPointerDown(PointerEventData eventData); // 0x000000018379AC80-0x000000018379ACB0
		public virtual void OnPointerUp(PointerEventData eventData); // 0x000000018379AC50-0x000000018379AC80
		public virtual void OnPointerEnter(PointerEventData eventData); // 0x000000018379B050-0x000000018379B160
		public virtual void OnPointerExit(PointerEventData eventData); // 0x000000018379B160-0x000000018379B190
		public virtual void OnSelect(BaseEventData eventData); // 0x0000000184CA2B20-0x0000000184CA2B30
		public virtual void OnDeselect(BaseEventData eventData); // 0x0000000184B6C980-0x0000000184B6C990
		public virtual void Select(); // 0x000000018B576F30-0x000000018B576FFC
		protected virtual void _RefreshHoverEnableNode(bool active); // 0x0000000183793A20-0x0000000183793AC0
		public virtual void OnInteractableChanged(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void _NotifyIsHover(bool isHover); // 0x00000001831EAD80-0x00000001831EAE20
		protected override void OnDestroy(); // 0x000000018351DB80-0x000000018351DBC0
		public virtual bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId); // 0x000000018B576B70-0x000000018B576B98
		public void SetAsNaviTarget(bool isTarget, bool silentMode, bool isGroupChanged); // 0x000000018B576FFC-0x000000018B577144
		public virtual void OnNaviTargetEnabledAgain(); // 0x000000018B576EC4-0x000000018B576F30
		protected virtual void _OnSetAsNaviTarget(bool isTarget, bool silentMode); // 0x00000001841E1670-0x00000001841E1680
		public void TryFindNaviGroup(); // 0x00000001837D4B70-0x00000001837D4BA0
		public SelectableNaviGroup GetLayerGroup(); // 0x000000018B576AF8-0x000000018B576B70
		public bool TryFindExplicitNaviTarget(NaviDirection dir, out Selectable target); // 0x000000018B5771A4-0x000000018B57732C
		public bool banExplicitNavi(NaviDirection dir); // 0x000000018B57732C-0x000000018B577404
		private void _TryRegisterOnNaviGroup(); // 0x0000000183795F90-0x0000000183796050
		private void _TryUnRegisterOnNaviGroup(); // 0x000000018351DBC0-0x000000018351DCF0
		public void SetExplicitSelectOnLeft(Selectable selectable); // 0x0000000186B8B404-0x0000000186B8B418
		public void SetExplicitSelectOnRight(Selectable selectable); // 0x0000000186B8B468-0x0000000186B8B47C
		public void SetExplicitSelectOnUp(Selectable selectable); // 0x0000000186B8B224-0x0000000186B8B238
		public void SetExplicitSelectOnDown(Selectable selectable); // 0x0000000186B8B274-0x0000000186B8B288
		public void SetExplicitSelect(Selectable left, Selectable right, Selectable up, Selectable down); // 0x000000018B577144-0x000000018B5771A4
	}

	public enum NaviDirection // TypeDefIndex: 57380
	{
		None = 0,
		Up = 1,
		Down = 2,
		Left = 3,
		Right = 4
	}

	public enum NaviStrategy // TypeDefIndex: 57381
	{
		Normal = 0,
		Strict = 1,
		NotInternalFirst = 2,
		VerticalOnlyWithInternalWrap = 3,
		HorizontalOnlyWithInternalWrap = 4
	}

	public enum NavigationBindingType // TypeDefIndex: 57382
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
	public abstract class SelectableNaviGroup : MonoBehaviour // TypeDefIndex: 57383
	{
		// Fields
		public bool isIsolate; // 0x18
		public bool isLayer; // 0x19
		public bool removeLayerOnDisable; // 0x1A
		[NonSerialized]
		public bool isDummy; // 0x1B
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
		public Selectable LayerSelectedTarget { get; } // 0x00000001837D2DD0-0x00000001837D2DF0 
		public bool IsTopLayer { get; set; } // 0x0000000184D86C50-0x0000000184D86C60 0x000000018B576228-0x000000018B576240
	
		// Constructors
		protected SelectableNaviGroup(); // 0x00000001840F99E0-0x00000001840F9C40
	
		// Methods
		protected virtual void Reset(); // 0x000000018B576220-0x000000018B576228
		protected virtual void OnEnable(); // 0x00000001837D3D90-0x00000001837D3DC0
		protected virtual void OnDisable(); // 0x00000001853979C0-0x00000001853979D0
		protected virtual void OnDestroy(); // 0x00000001839CFBF0-0x00000001839CFC90
		protected virtual void _Init(); // 0x00000001837D3E20-0x00000001837D3ED0
		public void TryFindParentNaviGroup(); // 0x00000001837D4820-0x00000001837D4910
		public SelectableNaviGroup GetLayerGroup(); // 0x00000001837D1390-0x00000001837D1410
		public void SetLayerSelectedTarget(Selectable value, bool silentMode); // 0x00000001837D1280-0x00000001837D12E0
		public void OnRemoveFromLayerStack(); // 0x00000001837D14D0-0x00000001837D1500
		protected virtual void _OnIsTopLayerChanged(); // 0x00000001837D3FE0-0x00000001837D4010
		protected virtual void _OnSelectableNaviGroupInited(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void _BeforeSelectableNaviGroupDestroy(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void _OnSelectableNaviGroupDisabled(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void _OnSetLayerSelectedTarget(Selectable value); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void _OnRemoveFromLayerStack(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class SetPropertyUtility // TypeDefIndex: 57384
	{
		// Methods
		public static bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue); // 0x0000000183046980-0x00000001830469C0
		public static bool SetStruct<T>(ref ref T currentValue, T newValue)
			where T : struct;
		public static bool SetClass<T>(ref ref T currentValue, T newValue)
			where T : class;
	}

	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class Slider : Selectable, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 57388
	{
		// Fields
		[SerializeField]
		private RectTransform m_FillRect; // 0x188
		[SerializeField]
		private RectTransform m_HandleRect; // 0x190
		[SerializeField]
		[Space]
		private Direction m_Direction; // 0x198
		[SerializeField]
		private float m_MinValue; // 0x19C
		[SerializeField]
		private float m_MaxValue; // 0x1A0
		[SerializeField]
		private bool m_WholeNumbers; // 0x1A4
		[SerializeField]
		protected float m_Value; // 0x1A8
		[SerializeField]
		[Space]
		private SliderEvent m_OnValueChanged; // 0x1B0
		private Image m_FillImage; // 0x1B8
		private Transform m_FillTransform; // 0x1C0
		private RectTransform m_FillContainerRect; // 0x1C8
		private Transform m_HandleTransform; // 0x1D0
		private RectTransform m_HandleContainerRect; // 0x1D8
		private Vector2 m_Offset; // 0x1E0
		private DrivenRectTransformTracker m_Tracker; // 0x1E8
		private bool m_DelayedUpdateVisuals; // 0x1E9
	
		// Properties
		public RectTransform fillRect { get; set; } // 0x0000000184D8DA20-0x0000000184D8DA30 0x000000018B5782F8-0x000000018B578360
		public RectTransform handleRect { get; set; } // 0x0000000184D8DD50-0x0000000184D8DD60 0x000000018B578360-0x000000018B5783C8
		public Direction direction { get; set; } // 0x0000000184D8F930-0x0000000184D8F940 0x000000018B57829C-0x000000018B5782F8
		public float minValue { get; set; } // 0x0000000184DBF0F0-0x0000000184DBF100 0x00000001846FF340-0x00000001846FF3C0
		public float maxValue { get; set; } // 0x0000000184D8E940-0x0000000184D8E950 0x00000001846FF500-0x00000001846FF580
		public bool wholeNumbers { get; set; } // 0x0000000184DBF100-0x0000000184DBF110 0x000000018B5783F8-0x000000018B57846C
		public virtual float value { get; set; } // 0x0000000183936F60-0x0000000183936F90 0x0000000185390984-0x0000000185390990
		public float normalizedValue { get; set; } // 0x0000000183936EB0-0x0000000183936F60 0x000000018B5783C8-0x000000018B5783F8
		public SliderEvent onValueChanged { get; set; } // 0x0000000184D8D960-0x0000000184D8D970 0x00000001853971DC-0x00000001853971F0
		private float stepSize { get; } // 0x000000018B578270-0x000000018B57829C 
		private Axis axis { get; } // 0x0000000183936E90-0x0000000183936EB0 
		private bool reverseValue { get; } // 0x0000000183936F90-0x0000000183937030 
		Transform ICanvasElement.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Nested types
		public enum Direction // TypeDefIndex: 57385
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}
	
		[Serializable]
		public class SliderEvent : UnityEvent<float> // TypeDefIndex: 57386
		{
			// Constructors
			public SliderEvent(); // 0x0000000185397550-0x000000018539755C
		}
	
		private enum Axis // TypeDefIndex: 57387
		{
			Horizontal = 0,
			Vertical = 1
		}
	
		// Constructors
		protected Slider(); // 0x000000018435C2D0-0x000000018435C390
	
		// Methods
		public virtual void SetValueWithoutNotify(float input); // 0x000000018B578034-0x000000018B578040
		public virtual void Rebuild(CanvasUpdate executing); // 0x00000001841E1670-0x00000001841E1680
		public virtual void LayoutComplete(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void GraphicUpdateComplete(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnEnable(); // 0x0000000183935610-0x0000000183935650
		protected override void OnDisable(); // 0x000000018447EC90-0x000000018447ECA0
		protected virtual void Update(); // 0x000000018419EE40-0x000000018419EE60
		protected override void OnDidApplyAnimationProperties(); // 0x000000018B5778C8-0x000000018B577AE4
		private void UpdateCachedReferences(); // 0x0000000183937030-0x0000000183937420
		protected virtual float ClampValue(float input); // 0x000000018B5777C4-0x000000018B5777F8
		protected virtual void Set(float input, bool sendCallback = true /* Metadata: 0x0234B0D2 */); // 0x0000000183936A10-0x0000000183936AE0
		protected virtual void OnValueChanged(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnClickSliderBar(); // 0x00000001841E1670-0x00000001841E1680
		protected virtual void OnClickSliderHandle(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnRectTransformDimensionsChange(); // 0x0000000184736930-0x0000000184736960
		private void UpdateVisuals(); // 0x0000000183936AE0-0x0000000183936E90
		private void UpdateDrag(PointerEventData eventData, Camera cam); // 0x000000018B578040-0x000000018B578270
		protected virtual float CustomProcessNormalizedValue(float val); // 0x0000000184D9A920-0x0000000184D9A930
		private bool MayDrag(PointerEventData eventData); // 0x000000018B575710-0x000000018B575764
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018B577D1C-0x000000018B577EF8
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018B577AE4-0x000000018B577B34
		public override void OnMove(AxisEventData eventData); // 0x000000018B577B34-0x000000018B577D1C
		public override Selectable FindSelectableOnLeft(); // 0x000000018B57782C-0x000000018B577860
		public override Selectable FindSelectableOnRight(); // 0x000000018B577860-0x000000018B577894
		public override Selectable FindSelectableOnUp(); // 0x000000018B577894-0x000000018B5778C8
		public override Selectable FindSelectableOnDown(); // 0x000000018B5777F8-0x000000018B57782C
		public virtual void OnInitializePotentialDrag(PointerEventData eventData); // 0x000000018B5759FC-0x000000018B575A18
		public void SetDirection(Direction direction, bool includeRectLayouts); // 0x000000018B577EF8-0x000000018B578034
	}

	[Serializable]
	public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 57389
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
		public Sprite highlightedSprite { get; set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
		public Sprite pressedSprite { get; set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		public Sprite selectedSprite { get; set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public Sprite disabledSprite { get; set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Methods
		public bool Equals(SpriteState other); // 0x000000018B57846C-0x000000018B578538
	}

	public static class StencilMaterial // TypeDefIndex: 57391
	{
		// Fields
		private static List<MatEntry> m_List; // 0x00
		private static bool s_EnableStencilMaterialWarning; // 0x08
	
		// Nested types
		private class MatEntry // TypeDefIndex: 57390
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
			public MatEntry(); // 0x0000000184DBEFE0-0x0000000184DBEFF0
		}
	
		// Constructors
		static StencilMaterial(); // 0x0000000184CECE10-0x0000000184CECEB0
	
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Material.Add instead.", true)]
		public static Material Add(Material baseMat, int stencilID); // 0x00000001811EC580-0x00000001811EC590
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask); // 0x00000001841D2250-0x00000001841D22D0
		private static void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context); // 0x000000018B57864C-0x000000018B5786D4
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask); // 0x00000001831DEDB0-0x00000001831DF500
		public static void Remove(Material customMat); // 0x000000018351C220-0x000000018351C410
		public static void ClearAll(); // 0x000000018B578538-0x000000018B57864C
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 57392
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
		internal override bool hasCullOverride { get; } // 0x00000001812081B0-0x0000000181208610 
		public TextGenerator cachedTextGenerator { get; } // 0x000000018B579360-0x000000018B579414 
		public TextGenerator cachedTextGeneratorForLayout { get; } // 0x000000018B5792E4-0x000000018B579360 
		public override Texture mainTexture { get; } // 0x000000018B5794B4-0x000000018B57963C 
		public Font font { get; set; } // 0x000000018B579454-0x000000018B579474 0x000000018B579B38-0x000000018B579C2C
		public virtual string text { get; set; } // 0x0000000184D8D1A0-0x0000000184D8D1B0 0x000000018B579DCC-0x000000018B579E98
		public bool supportRichText { get; set; } // 0x000000018B5799F0-0x000000018B579A10 0x000000018B579D88-0x000000018B579DCC
		public bool resizeTextForBestFit { get; set; } // 0x000000018B579990-0x000000018B5799B0 0x000000018B579CBC-0x000000018B579D00
		public int resizeTextMinSize { get; set; } // 0x000000018B5799D0-0x000000018B5799F0 0x000000018B579D44-0x000000018B579D88
		public int resizeTextMaxSize { get; set; } // 0x000000018B5799B0-0x000000018B5799D0 0x000000018B579D00-0x000000018B579D44
		public TextAnchor alignment { get; set; } // 0x000000018B5792C4-0x000000018B5792E4 0x000000018B579A6C-0x000000018B579AB0
		public bool alignByGeometry { get; set; } // 0x000000018B5792A4-0x000000018B5792C4 0x000000018B579A30-0x000000018B579A6C
		public int fontSize { get; set; } // 0x000000018B579414-0x000000018B579434 0x000000018B579AB0-0x000000018B579AF4
		public HorizontalWrapMode horizontalOverflow { get; set; } // 0x000000018B579474-0x000000018B579494 0x000000018B579C2C-0x000000018B579C70
		public VerticalWrapMode verticalOverflow { get; set; } // 0x000000018B579A10-0x000000018B579A30 0x000000018B579E98-0x000000018B579EDC
		public float lineSpacing { get; set; } // 0x000000018B579494-0x000000018B5794B4 0x000000018B579C70-0x000000018B579CBC
		public FontStyle fontStyle { get; set; } // 0x000000018B579434-0x000000018B579454 0x000000018B579AF4-0x000000018B579B38
		public float pixelsPerUnit { get; } // 0x000000018B57963C-0x000000018B579778 
		public virtual float minWidth { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual float preferredWidth { get; } // 0x000000018B5798A0-0x000000018B579990 
		public virtual float flexibleWidth { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual float minHeight { get; } // 0x0000000184D879D0-0x0000000184D879E0 
		public virtual float preferredHeight { get; } // 0x000000018B579778-0x000000018B5798A0 
		public virtual float flexibleHeight { get; } // 0x0000000184DA9E10-0x0000000184DA9E20 
		public virtual int layoutPriority { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Constructors
		protected Text(); // 0x000000018B5791F8-0x000000018B5792A4
	
		// Methods
		public void FontTextureChanged(); // 0x000000018B5787C4-0x000000018B57888C
		protected override void OnEnable(); // 0x000000018B578B70-0x000000018B578BD8
		protected override void OnDisable(); // 0x000000018B578B24-0x000000018B578B70
		protected override void UpdateGeometry(); // 0x000000018B579190-0x000000018B5791F8
		public void AssignDefaultFont(); // 0x000000018B57876C-0x000000018B5787C4
		internal void AssignDefaultFontIfNecessary(); // 0x000000018B5786D4-0x000000018B57876C
		public TextGenerationSettings GetGenerationSettings(Vector2 extents); // 0x000000018B57888C-0x000000018B578A98
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor); // 0x000000018B578A98-0x000000018B578B24
		protected override void OnPopulateMesh(VertexHelper toFill); // 0x000000018B578BD8-0x000000018B579190
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void CalculateLayoutInputVertical(); // 0x00000001841E1670-0x00000001841E1680
	}

	[RequireComponent(typeof(RectTransform))]
	public class Toggle : Selectable, IPointerClickHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 57395
	{
		// Fields
		public ToggleTransition toggleTransition; // 0x188
		public Graphic graphic; // 0x190
		[SerializeField]
		private ToggleGroup m_Group; // 0x198
		public ToggleEvent onValueChanged; // 0x1A0
		[SerializeField]
		[Tooltip("Is the toggle currently on or off?")]
		private bool m_IsOn; // 0x1A8
	
		// Properties
		public ToggleGroup group { get; set; } // 0x0000000184D8DED0-0x0000000184D8DEE0 0x000000018B57A54C-0x000000018B57A574
		public bool isOn { get; set; } // 0x0000000184DA3310-0x0000000184DA3320 0x000000018378E5A0-0x000000018378E5B0
		Transform ICanvasElement.transform { get; } // 0x00000001853953F4-0x00000001853953FC 
	
		// Nested types
		public enum ToggleTransition // TypeDefIndex: 57393
		{
			None = 0,
			Fade = 1
		}
	
		[Serializable]
		public class ToggleEvent : UnityEvent<bool> // TypeDefIndex: 57394
		{
			// Constructors
			public ToggleEvent(); // 0x000000018539350C-0x0000000185393520
		}
	
		// Constructors
		protected Toggle(); // 0x000000018435DEF0-0x000000018435DF70
	
		// Methods
		public virtual void Rebuild(CanvasUpdate executing); // 0x00000001841E1670-0x00000001841E1680
		public virtual void LayoutComplete(); // 0x00000001841E1670-0x00000001841E1680
		public virtual void GraphicUpdateComplete(); // 0x00000001841E1670-0x00000001841E1680
		protected override void OnDestroy(); // 0x000000018B57A390-0x000000018B57A40C
		protected override void OnEnable(); // 0x000000018378E820-0x000000018378E860
		protected override void OnDisable(); // 0x000000018378E750-0x000000018378E780
		protected override void OnDidApplyAnimationProperties(); // 0x000000018B57A40C-0x000000018B57A518
		private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue); // 0x000000018378E9F0-0x000000018378EB80
		public void SetIsOnWithoutNotify(bool value); // 0x00000001853979D0-0x00000001853979DC
		private void Set(bool value, bool sendCallback = true /* Metadata: 0x0234B0D9 */); // 0x000000018378E5B0-0x000000018378E6D0
		private void PlayEffect(bool instant); // 0x000000018378E920-0x000000018378E9F0
		protected override void Start(); // 0x0000000185393868-0x0000000185393874
		protected virtual void InternalToggle(); // 0x000000018B57A348-0x000000018B57A390
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018B57A518-0x000000018B57A54C
		public virtual void OnSubmit(BaseEventData eventData); // 0x000000018AC6E908-0x000000018AC6E918
		protected virtual void OnValueChange(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("UI/Toggle Group", 31)]
	[DisallowMultipleComponent]
	public class ToggleGroup : UIBehaviour // TypeDefIndex: 57397
	{
		// Fields
		[SerializeField]
		private bool m_AllowSwitchOff; // 0x18
		protected List<Toggle> m_Toggles; // 0x20
	
		// Properties
		public bool allowSwitchOff { get; set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 57396
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<Toggle> __9__13_0; // 0x08
			public static Func<Toggle, bool> __9__14_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000184D45970-0x0000000184D459D0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AnyTogglesOn_b__13_0(Toggle x); // 0x000000018B57A7E8-0x000000018B57A804
			internal bool _ActiveToggles_b__14_0(Toggle x); // 0x000000018B57A7E8-0x000000018B57A804
		}
	
		// Constructors
		protected ToggleGroup(); // 0x00000001845C5E70-0x00000001845C5F00
	
		// Methods
		protected override void Start(); // 0x000000018481BFF0-0x000000018481C000
		protected override void OnEnable(); // 0x000000018481BFF0-0x000000018481C000
		private void ValidateToggleIsInGroup(Toggle toggle); // 0x000000018B57A1FC-0x000000018B57A348
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true /* Metadata: 0x0234B0DC */); // 0x000000018B579F4C-0x000000018B57A07C
		public void UnregisterToggle(Toggle toggle); // 0x000000018B57A1A8-0x000000018B57A1FC
		public void RegisterToggle(Toggle toggle); // 0x000000018B57A07C-0x000000018B57A0D0
		public void EnsureValidState(); // 0x000000018481C000-0x000000018481C260
		public bool AnyTogglesOn(); // 0x000000018481C340-0x000000018481C490
		public IEnumerable<Toggle> ActiveToggles(); // 0x000000018481C260-0x000000018481C340
		public Toggle GetFirstActiveToggle(); // 0x000000018B579EDC-0x000000018B579F4C
		public void SetAllTogglesOff(bool sendCallback = true /* Metadata: 0x0234B0DD */); // 0x000000018B57A0D0-0x000000018B57A1A8
	}

	internal class ReflectionMethodsCache // TypeDefIndex: 57404
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
		public static ReflectionMethodsCache Singleton { get; } // 0x000000018B574964-0x000000018B5749F4 
	
		// Nested types
		public delegate bool Raycast3DCallback(Ray r, out RaycastHit hit, float f, int i); // TypeDefIndex: 57398; 0x000000018B572AF0-0x000000018B572B30
	
		public delegate RaycastHit[] RaycastAllCallback(Ray r, float f, int i); // TypeDefIndex: 57399; 0x000000018B572920-0x000000018B572958
	
		public delegate int GetRaycastNonAllocCallback(Ray r, RaycastHit[] results, float f, int i); // TypeDefIndex: 57400; 0x000000018B572AF0-0x000000018B572B30
	
		public delegate RaycastHit2D Raycast2DCallback(Vector2 p1, Vector2 p2, float f, int i); // TypeDefIndex: 57401; 0x000000018B5730CC-0x000000018B573128
	
		public delegate RaycastHit2D[] GetRayIntersectionAllCallback(Ray r, float f, int i); // TypeDefIndex: 57402; 0x000000018B572920-0x000000018B572958
	
		public delegate int GetRayIntersectionAllNonAllocCallback(Ray r, RaycastHit2D[] results, float f, int i); // TypeDefIndex: 57403; 0x000000018B572AF0-0x000000018B572B30
	
		// Constructors
		public ReflectionMethodsCache(); // 0x000000018B573EA8-0x000000018B574964
	}

	public class VertexHelper : IDisposable // TypeDefIndex: 57405
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
		public int currentVertCount { get; } // 0x0000000183141B90-0x0000000183141BB0 
		public int currentIndexCount { get; } // 0x000000018B57B0F0-0x000000018B57B33C 
	
		// Constructors
		public VertexHelper(); // 0x00000001841E1670-0x00000001841E1680
		public VertexHelper(Mesh m); // 0x000000018B57AEB8-0x000000018B57B0F0
		static VertexHelper(); // 0x00000001849704A0-0x0000000184970510
	
		// Methods
		private void InitializeListIfRequired(); // 0x0000000183242670-0x00000001832427E0
		public void Dispose(); // 0x0000000184028CD0-0x0000000184028E90
		public void Clear(); // 0x00000001831F9AA0-0x00000001831F9B50
		public void PopulateUIVertex(ref UIVertex vertex, int i); // 0x000000018B57A9B4-0x000000018B57AB70
		public void SetUIVertex(UIVertex vertex, int i); // 0x000000018B57AB70-0x000000018B57AEB8
		public void FillMesh(Mesh mesh); // 0x00000001831F3240-0x00000001831F3C80
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent); // 0x0000000183241FE0-0x0000000183242670
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent); // 0x0000000183241930-0x0000000183241FE0
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0); // 0x0000000183241250-0x0000000183241930
		public void AddVert(UIVertex v); // 0x0000000183BA6F90-0x0000000183BA7040
		public void AddTriangle(int idx0, int idx1, int idx2); // 0x0000000183131840-0x0000000183131B70
		public void AddUIVertexQuad(UIVertex[] verts); // 0x00000001837972C0-0x0000000183797430
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices); // 0x000000018B57A804-0x000000018B57A8C4
		public void AddUIVertexTriangleStream(List<UIVertex> verts); // 0x000000018B57A8C4-0x000000018B57A93C
		public void GetUIVertexStream(List<UIVertex> stream); // 0x000000018B57A93C-0x000000018B57A9B4
	}

	[Obsolete("Use BaseMeshEffect instead", true)]
	public abstract class BaseVertexEffect // TypeDefIndex: 57406
	{
		// Constructors
		protected BaseVertexEffect(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)]
		public abstract void ModifyVertices(List<UIVertex> vertices);
	}

	[ExecuteAlways]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 57407
	{
		// Fields
		[NonSerialized]
		private Graphic m_Graphic; // 0x18
	
		// Properties
		protected Graphic graphic { get; } // 0x000000018B57BF74-0x000000018B57BFF8 
	
		// Constructors
		protected BaseMeshEffect(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void OnEnable(); // 0x000000018B57BEF4-0x000000018B57BF74
		protected override void OnDisable(); // 0x000000018B57BE74-0x000000018B57BEF4
		protected override void OnDidApplyAnimationProperties(); // 0x000000018B57BDF4-0x000000018B57BE74
		public virtual void ModifyMesh(Mesh mesh); // 0x000000018B57BCF0-0x000000018B57BDF4
		public abstract void ModifyMesh(VertexHelper vh);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use IMeshModifier instead", true)]
	public interface IVertexModifier // TypeDefIndex: 57408
	{
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
		void ModifyVertices(List<UIVertex> verts);
	}

	public interface IMeshModifier // TypeDefIndex: 57409
	{
		// Methods
		[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", false)]
		void ModifyMesh(Mesh mesh);
		void ModifyMesh(VertexHelper verts);
	}

	[AddComponentMenu("UI/Effects/Outline", 81)]
	public class Outline : Shadow // TypeDefIndex: 57410
	{
		// Constructors
		protected Outline(); // 0x000000018B57DC84-0x000000018B57DC8C
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x000000018B57D9EC-0x000000018B57DC84
	}

	[AddComponentMenu("UI/Effects/Position As UV1", 82)]
	public class PositionAsUV1 : BaseMeshEffect // TypeDefIndex: 57411
	{
		// Constructors
		protected PositionAsUV1(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public override void ModifyMesh(VertexHelper vh); // 0x000000018B582B30-0x000000018B582C2C
	}

	[AddComponentMenu("UI/Effects/Shadow", 80)]
	public class Shadow : BaseMeshEffect // TypeDefIndex: 57412
	{
		// Fields
		[SerializeField]
		private UnityEngine.Color m_EffectColor; // 0x20
		[SerializeField]
		private Vector2 m_EffectDistance; // 0x30
		[SerializeField]
		private bool m_UseGraphicAlpha; // 0x38
		private const float kMaxEffectDistance = 600f; // Metadata: 0x0234B0DE
	
		// Properties
		public UnityEngine.Color effectColor { get; set; } // 0x0000000184D8C200-0x0000000184D8C210 0x000000018B583E40-0x000000018B583ECC
		public Vector2 effectDistance { get; set; } // 0x0000000184D9E6C0-0x0000000184D9E6E0 0x000000018B583ECC-0x000000018B583FF4
		public bool useGraphicAlpha { get; set; } // 0x00000001811F2A70-0x00000001811F2A80 0x000000018B583FF4-0x000000018B58407C
	
		// Constructors
		protected Shadow(); // 0x0000000184D79B90-0x0000000184D79BD0
	
		// Methods
		protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y); // 0x000000018B583A8C-0x000000018B583D08
		protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y); // 0x000000018B583D08-0x000000018B583D18
		public override void ModifyMesh(VertexHelper vh); // 0x000000018B583D18-0x000000018B583E40
	}
}

namespace UnityEngine.UI.Collections
{
	internal class IndexedSet<T> : IList<T> // TypeDefIndex: 57413
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
	internal interface ITweenValue // TypeDefIndex: 57414
	{
		// Properties
		bool ignoreTimeScale { get; }
		float duration { get; }
	
		// Methods
		void TweenValue(float floatPercentage);
		bool ValidTarget();
	}

	internal struct ColorTween : ITweenValue // TypeDefIndex: 57417
	{
		// Fields
		private ColorTweenCallback m_Target; // 0x00
		private UnityEngine.Color m_StartColor; // 0x08
		private UnityEngine.Color m_TargetColor; // 0x18
		private ColorTweenMode m_TweenMode; // 0x28
		private float m_Duration; // 0x2C
		private bool m_IgnoreTimeScale; // 0x30
	
		// Properties
		public UnityEngine.Color startColor { get; set; } // 0x00000001815AD730-0x00000001815AD740 0x0000000184DA4E20-0x0000000184DA4E30
		public UnityEngine.Color targetColor { get; set; } // 0x0000000184D890C0-0x0000000184D890D0 0x0000000184D890D0-0x0000000184D890E0
		public ColorTweenMode tweenMode { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public float duration { get; set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x0000000184D86B00-0x0000000184D86B10
		public bool ignoreTimeScale { get; set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000184D86620-0x0000000184D86630
	
		// Nested types
		public enum ColorTweenMode // TypeDefIndex: 57415
		{
			All = 0,
			RGB = 1,
			Alpha = 2
		}
	
		public class ColorTweenCallback : UnityEvent<UnityEngine.Color> // TypeDefIndex: 57416
		{
			// Constructors
			public ColorTweenCallback(); // 0x0000000185397350-0x000000018539735C
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018374AE50-0x000000018374AFD0
		public void AddOnChangedCallback(UnityAction<UnityEngine.Color> callback); // 0x0000000184259CB0-0x0000000184259D30
		public bool GetIgnoreTimescale(); // 0x0000000184D865F0-0x0000000184D86600
		public float GetDuration(); // 0x0000000184D86AF0-0x0000000184D86B00
		public bool ValidTarget(); // 0x000000018374AFD0-0x000000018374AFE0
	}

	internal struct FloatTween : ITweenValue // TypeDefIndex: 57419
	{
		// Fields
		private FloatTweenCallback m_Target; // 0x00
		private float m_StartValue; // 0x08
		private float m_TargetValue; // 0x0C
		private float m_Duration; // 0x10
		private bool m_IgnoreTimeScale; // 0x14
	
		// Properties
		public float startValue { get; set; } // 0x0000000184D9C280-0x0000000184D9C290 0x0000000184DAC1D0-0x0000000184DAC1E0
		public float targetValue { get; set; } // 0x0000000184D9CC80-0x0000000184D9CC90 0x0000000184DACD70-0x0000000184DACD80
		public float duration { get; set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184D88280-0x0000000184D88290
		public bool ignoreTimeScale { get; set; } // 0x0000000184D8EE50-0x0000000184D8EE60 0x0000000184D8EE70-0x0000000184D8EE80
	
		// Nested types
		public class FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 57418
		{
			// Constructors
			public FloatTweenCallback(); // 0x000000018B57D574-0x000000018B57D5B0
		}
	
		// Methods
		public void TweenValue(float floatPercentage); // 0x000000018B57D648-0x000000018B57D6AC
		public void AddOnChangedCallback(UnityAction<float> callback); // 0x000000018B57D5B0-0x000000018B57D648
		public bool GetIgnoreTimescale(); // 0x0000000184D8EE50-0x0000000184D8EE60
		public float GetDuration(); // 0x0000000184D85F70-0x0000000184D85F80
		public bool ValidTarget(); // 0x0000000183A7A090-0x0000000183A7A0A0
	}

	internal class TweenRunner<T> // TypeDefIndex: 57421
		where T : struct, ITweenValue
	{
		// Fields
		protected MonoBehaviour m_CoroutineContainer;
		protected IEnumerator m_Tween;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__2 : IEnumerator<object> // TypeDefIndex: 57420
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
	public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, UnityEngine.EventSystems.IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent // TypeDefIndex: 57424
	{
		// Fields
		private BaseRuntimePanel m_Panel; // 0x18
		private readonly PointerEvent m_PointerEvent; // 0x20
		private bool m_Selecting; // 0x28
		private UnityEngine.Event m_Event; // 0x30
		private static EventModifiers s_Modifiers; // 0x00
	
		// Properties
		public IPanel panel { get; set; } // 0x000000018385B100-0x000000018385B110 0x000000018B57F5F0-0x000000018B57F660
		private GameObject selectableGameObject { get; } // 0x000000018B57F5DC-0x000000018B57F5F0 
		private EventSystem eventSystem { get; } // 0x000000018B57F58C-0x000000018B57F5DC 
	
		// Nested types
		private enum PointerEventType // TypeDefIndex: 57422
		{
			Default = 0,
			Down = 1,
			Up = 2
		}
	
		private class PointerEvent : IPointerEvent // TypeDefIndex: 57423
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
			public int pointerId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
			public string pointerType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
			public bool isPrimary { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D866B0-0x0000000184D866C0 0x0000000184D866D0-0x0000000184D866E0
			public int button { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
			public int pressedButtons { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
			public Vector3 position { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90540-0x0000000184D90560 0x0000000184D90510-0x0000000184D90520
			public Vector3 localPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9E700-0x0000000184D9E720 0x0000000184D9DB00-0x0000000184D9DB10
			public Vector3 deltaPosition { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D914A0-0x0000000184D914C0 0x0000000184D914C0-0x0000000184D914D0
			public float deltaTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D885A0-0x0000000184D885B0 0x0000000184D88FF0-0x0000000184D89000
			public int clickCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86540-0x0000000184D86550 0x0000000184D86590-0x0000000184D865A0
			public float pressure { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88400-0x0000000184D88410 0x0000000184D88430-0x0000000184D88440
			public float tangentialPressure { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D91500-0x0000000184D91510 0x0000000184D91510-0x0000000184D91520
			public float altitudeAngle { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88480-0x0000000184D88490 0x0000000184D884A0-0x0000000184D884B0
			public float azimuthAngle { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D88470-0x0000000184D88480 0x0000000184D88490-0x0000000184D884A0
			public float twist { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8F060-0x0000000184D8F070 0x0000000184D8F090-0x0000000184D8F0A0
			public Vector2 radius { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DBF340-0x0000000184DBF360 0x0000000184DBF370-0x0000000184DBF380
			public Vector2 radiusVariance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DBF320-0x0000000184DBF340 0x0000000184DBF360-0x0000000184DBF370
			public EventModifiers modifiers { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86410-0x0000000184D86420 0x0000000184D86490-0x0000000184D864A0
			public bool shiftKey { get; } // 0x000000018B5817D4-0x000000018B5817DC 
			public bool ctrlKey { get; } // 0x000000018B5817CC-0x000000018B5817D4 
			public bool commandKey { get; } // 0x000000018B5817C4-0x000000018B5817CC 
			public bool altKey { get; } // 0x000000018B5817BC-0x000000018B5817C4 
			public bool actionKey { get; } // 0x000000018B581788-0x000000018B5817BC 
	
			// Constructors
			public PointerEvent(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType); // 0x000000018B581260-0x000000018B581774
			public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride); // 0x0000000184DBF2F0-0x0000000184DBF320
			[CompilerGenerated]
			internal static bool _Read_g__InRange_82_0(int i, int start, int count); // 0x000000018B581774-0x000000018B581788
		}
	
		// Constructors
		public PanelEventHandler(); // 0x000000018B57F4F4-0x000000018B57F58C
	
		// Methods
		protected override void OnEnable(); // 0x000000018B57DE14-0x000000018B57DE1C
		protected override void OnDisable(); // 0x000000018B57DD78-0x000000018B57DD80
		private void RegisterCallbacks(); // 0x000000018B57ECC8-0x000000018B57EE70
		private void UnregisterCallbacks(); // 0x000000018B57F28C-0x000000018B57F434
		private void OnPanelDestroyed(); // 0x000000018B57DEF8-0x000000018B57DF04
		private void OnElementFocus(FocusEvent e); // 0x000000018B57DD80-0x000000018B57DE14
		private void OnElementBlur(BlurEvent e); // 0x00000001841E1670-0x00000001841E1680
		public void OnSelect(BaseEventData eventData); // 0x000000018B57E6F8-0x000000018B57E790
		public void OnDeselect(BaseEventData eventData); // 0x000000018B57DD64-0x000000018B57DD78
		public void OnPointerMove(PointerEventData eventData); // 0x000000018B57E378-0x000000018B57E464
		public void OnPointerUp(PointerEventData eventData); // 0x000000018B57E464-0x000000018B57E5B8
		public void OnPointerDown(PointerEventData eventData); // 0x000000018B57DF04-0x000000018B57E0C8
		public void OnPointerExit(PointerEventData eventData); // 0x000000018B57E13C-0x000000018B57E378
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018B57E0C8-0x000000018B57E13C
		public void OnSubmit(BaseEventData eventData); // 0x000000018B57E790-0x000000018B57E85C
		public void OnCancel(BaseEventData eventData); // 0x000000018B57DC98-0x000000018B57DD64
		public void OnMove(AxisEventData eventData); // 0x000000018B57DE1C-0x000000018B57DEF8
		public void OnScroll(PointerEventData eventData); // 0x000000018B57E5B8-0x000000018B57E6F8
		private void SendEvent(EventBase e, BaseEventData sourceEventData); // 0x000000018B57EE70-0x000000018B57EEBC
		private void SendEvent(EventBase e, UnityEngine.Event sourceEvent); // 0x000000018B57EEBC-0x000000018B57EF0C
		private void Update(); // 0x000000018B57F434-0x000000018B57F4F4
		private void LateUpdate(); // 0x000000018B57DC8C-0x000000018B57DC98
		private void ProcessImguiEvents(bool isSelected); // 0x000000018B57E85C-0x000000018B57E9A8
		private void ProcessKeyboardEvent(UnityEngine.Event e); // 0x000000018B57E9A8-0x000000018B57EAA4
		private void ProcessTabEvent(UnityEngine.Event e); // 0x000000018B57EAA4-0x000000018B57EB18
		private void SendTabEvent(UnityEngine.Event e, int direction); // 0x000000018B57F0DC-0x000000018B57F1A0
		private void SendKeyUpEvent(UnityEngine.Event e, KeyCode keyCode, EventModifiers modifiers); // 0x000000018B57EFF4-0x000000018B57F0DC
		private void SendKeyDownEvent(UnityEngine.Event e, KeyCode keyCode, EventModifiers modifiers); // 0x000000018B57EF0C-0x000000018B57EFF4
		private void SendTextEvent(UnityEngine.Event e, char c, EventModifiers modifiers); // 0x000000018B57F1A0-0x000000018B57F28C
		private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = PointerEventType.Default /* Metadata: 0x0234B0E5 */); // 0x000000018B57EB18-0x000000018B57ECC8
	}

	[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
	public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent // TypeDefIndex: 57426
	{
		// Fields
		private BaseRuntimePanel m_Panel; // 0x20
	
		// Properties
		public IPanel panel { get; set; } // 0x0000000184D862C0-0x0000000184D862D0 0x000000018B57FCB4-0x000000018B57FD24
		private GameObject selectableGameObject { get; } // 0x000000018B57FC84-0x000000018B57FC98 
		public override int sortOrderPriority { get; } // 0x000000018B57FC98-0x000000018B57FCB4 
		public override int renderOrderPriority { get; } // 0x000000018B57FC6C-0x000000018B57FC84 
		public override Camera eventCamera { get; } // 0x00000001811EC580-0x00000001811EC590 
	
		// Nested types
		private struct FloatIntBits // TypeDefIndex: 57425
		{
			// Fields
			public float f; // 0x00
			public int i; // 0x00
		}
	
		// Constructors
		public PanelRaycaster(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void RegisterCallbacks(); // 0x000000018B57FB44-0x000000018B57FBD8
		private void UnregisterCallbacks(); // 0x000000018B57FBD8-0x000000018B57FC6C
		private void OnPanelDestroyed(); // 0x000000018B57F660-0x000000018B57F66C
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList); // 0x000000018B57F66C-0x000000018B57FB44
		private static int ConvertFloatBitsToInt(float f); // 0x0000000184D94B90-0x0000000184D94BA0
	}
}
