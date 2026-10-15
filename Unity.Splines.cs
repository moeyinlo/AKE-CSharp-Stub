/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

// Image 85: Unity.Splines.dll - Assembly: Unity.Splines, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90000-90036

namespace UnityEngine.Splines
{
	internal static class ArrayUtility // TypeDefIndex: 90001
	{
		// Methods
		public static void RemoveAt<T>(ref ref T[] array, int index);
		public static void Remove<T>(ref ref T[] array, T element);
	}

	public struct BezierCurve : IEquatable<BezierCurve> // TypeDefIndex: 90002
	{
		// Fields
		public float3 P0; // 0x00
		public float3 P1; // 0x0C
		public float3 P2; // 0x18
		public float3 P3; // 0x24
	
		// Constructors
		public BezierCurve(float3 p0, float3 p1, float3 p2, float3 p3); // 0x000000018725EE10-0x000000018725EE60
		public BezierCurve(BezierKnot a, BezierKnot b); // 0x0000000185DC9C40-0x0000000185DC9DE0
	
		// Methods
		public bool Equals(BezierCurve other); // 0x000000018D3A86CC-0x000000018D3A8790
		public override bool Equals(object obj); // 0x000000018D3FF530-0x000000018D3FF5B0
		public override int GetHashCode(); // 0x000000018D3FF5B0-0x000000018D3FF640
	}

	[Serializable]
	public struct BezierKnot : ISerializationCallbackReceiver, IEquatable<BezierKnot> // TypeDefIndex: 90003
	{
		// Fields
		public float3 Position; // 0x00
		public float3 TangentIn; // 0x0C
		public float3 TangentOut; // 0x18
		public quaternion Rotation; // 0x24
		public float Width; // 0x34
	
		// Constructors
		public BezierKnot(float3 position); // 0x000000018D3FFF80-0x000000018D400008
		public BezierKnot(float3 position, float3 tangentIn, float3 tangentOut, quaternion rotation, float width = 1f /* Metadata: 0x0264AA97 */); // 0x000000018725EE60-0x000000018725EEB0
	
		// Methods
		public BezierKnot Transform(float4x4 matrix); // 0x000000018D3FFCF4-0x000000018D3FFF80
		internal BezierKnot BakeTangentDirectionToRotation(bool mirrored, BezierTangent main = BezierTangent.Out /* Metadata: 0x0264AA9B */); // 0x000000018D3FF640-0x000000018D3FF944
		public void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnAfterDeserialize(); // 0x0000000186A864C0-0x0000000186A86520
		public override string ToString(); // 0x000000018D3FFB68-0x000000018D3FFCF4
		public bool Equals(BezierKnot other); // 0x000000018D3FF944-0x000000018D3FFA18
		public override bool Equals(object obj); // 0x000000018D3FFA18-0x000000018D3FFAA4
		public override int GetHashCode(); // 0x000000018D3FFAA4-0x000000018D3FFB68
	}

	public enum TangentMode // TypeDefIndex: 90004
	{
		AutoSmooth = 0,
		Linear = 1,
		Mirrored = 2,
		Continuous = 3,
		Broken = 4
	}

	public enum BezierTangent // TypeDefIndex: 90005
	{
		In = 0,
		Out = 1
	}

	public static class CurveUtility // TypeDefIndex: 90007
	{
		// Fields
		private static readonly DistanceToInterpolation[] k_DistanceLUT; // 0x00
	
		// Nested types
		private struct FrenetFrame // TypeDefIndex: 90006
		{
			// Fields
			public float3 origin; // 0x00
			public float3 tangent; // 0x0C
			public float3 normal; // 0x18
			public float3 binormal; // 0x24
		}
	
		// Constructors
		static CurveUtility(); // 0x00000001871DBCF0-0x00000001871DBD60
	
		// Methods
		public static float3 EvaluatePosition(BezierCurve curve, float t); // 0x0000000185777B70-0x0000000185777EB0
		public static float3 EvaluateTangent(BezierCurve curve, float t); // 0x0000000185DC7B40-0x0000000185DC7D50
		public static float3 EvaluateAcceleration(BezierCurve curve, float t); // 0x000000018D400068-0x000000018D4001EC
		public static void CalculateCurveLengths(BezierCurve curve, DistanceToInterpolation[] lookupTable); // 0x0000000185DC8FA0-0x0000000185DC9250
		private static bool Approximately(float a, float b); // 0x000000018D400008-0x000000018D400068
		internal static float3 EvaluateUpVector(BezierCurve curve, float t, float3 startUp, float3 endUp); // 0x000000018D4001EC-0x000000018D400CE0
		private static FrenetFrame GetNextRotationMinimizingFrame(BezierCurve curve, FrenetFrame previousRMFrame, float nextRMFrameT); // 0x000000018D400CE0-0x000000018D401238
		public static float GetDistanceToInterpolation<T>(T lut, float distance)
			where T : IReadOnlyList<DistanceToInterpolation>;
	}

	public interface IDataPoint // TypeDefIndex: 90008
	{
		// Properties
		float Index { get; }
	}

	[Serializable]
	public struct DataPoint<TDataType> : IComparable<DataPoint<TDataType>>, IComparable<float>, IDataPoint // TypeDefIndex: 90009
	{
		// Fields
		[FormerlySerializedAs("m_Time")]
		[SerializeField]
		private float m_Index;
		[SerializeField]
		private TDataType m_Value;
	
		// Properties
		public float Index { get; set; }
		public TDataType Value { get; }
	
		// Methods
		public int CompareTo(DataPoint<TDataType> other);
		public int CompareTo(float other);
		public override string ToString();
	}

	internal class DataPointComparer<T> : IComparer<T> // TypeDefIndex: 90010
		where T : IDataPoint
	{
		// Constructors
		public DataPointComparer();
	
		// Methods
		public int Compare(T x, T y);
	}

	[Serializable]
	public struct DistanceToInterpolation // TypeDefIndex: 90011
	{
		// Fields
		public float Distance; // 0x00
		public float T; // 0x04
		internal static readonly DistanceToInterpolation Invalid; // 0x00
	
		// Constructors
		static DistanceToInterpolation(); // 0x000000018721B3A0-0x000000018721B3E0
	}

	public interface IHasEmptyCurves // TypeDefIndex: 90012
	{
		// Properties
		IReadOnlyList<int> EmptyCurves { get; }
	}

	public interface ISpline : IReadOnlyList<BezierKnot> // TypeDefIndex: 90013
	{
		// Properties
		bool Closed { get; }
	
		// Methods
		float GetLength();
		BezierCurve GetCurve(int index);
		float GetCurveLength(int index);
		float GetCurveInterpolation(int curveIndex, float curveDistance);
	}

	public interface ISplineContainer // TypeDefIndex: 90014
	{
		// Properties
		IReadOnlyList<Spline> Splines { get; }
		KnotLinkCollection KnotLinkCollection { get; }
	}

	[Serializable]
	public sealed class KnotLinkCollection // TypeDefIndex: 90016
	{
		// Fields
		[SerializeField]
		private KnotLink[] m_KnotsLink; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class KnotLink : IReadOnlyList<SplineKnotIndex> // TypeDefIndex: 90015
		{
			// Fields
			public SplineKnotIndex[] Knots; // 0x10
	
			// Properties
			public int Count { get; } // 0x0000000188A9F760-0x0000000188A9F77C 
			public SplineKnotIndex this[int index] { get => default; } // 0x000000018B636CDC-0x000000018B636D08 
	
			// Constructors
			public KnotLink(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public IEnumerator<SplineKnotIndex> GetEnumerator(); // 0x000000018D401538-0x000000018D401580
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D15B424-0x000000018D15B444
		}
	
		// Constructors
		public KnotLinkCollection(); // 0x0000000185DCA540-0x0000000185DCA590
	
		// Methods
		private KnotLink GetKnotLinksInternal(SplineKnotIndex index); // 0x000000018D401238-0x000000018D4012E0
		public bool TryGetKnotLinks(SplineKnotIndex knotIndex, out IReadOnlyList<SplineKnotIndex> linkedKnots); // 0x000000018D401448-0x000000018D401474
		public void Unlink(SplineKnotIndex knot); // 0x000000018D401474-0x000000018D401538
		public void KnotRemoved(int splineIndex, int knotIndex); // 0x000000018D401314-0x000000018D401334
		public void KnotRemoved(SplineKnotIndex index); // 0x000000018D401334-0x000000018D40136C
		public void KnotInserted(int splineIndex, int knotIndex); // 0x000000018D4012E0-0x000000018D401304
		public void KnotInserted(SplineKnotIndex index); // 0x000000018D401304-0x000000018D401314
		public void ShiftKnotIndices(SplineKnotIndex index, int offset); // 0x000000018D40136C-0x000000018D401448
	}

	public struct NativeSpline : ISpline, IDisposable // TypeDefIndex: 90018
	{
		// Fields
		[ReadOnly]
		private NativeArray<BezierKnot> m_Knots; // 0x00
		[ReadOnly]
		private NativeArray<BezierCurve> m_Curves; // 0x10
		[ReadOnly]
		private NativeArray<DistanceToInterpolation> m_SegmentLengthsLookupTable; // 0x20
		private bool m_Closed; // 0x30
		private float m_Length; // 0x34
	
		// Properties
		public bool Closed { get; } // 0x00000001822434B0-0x00000001822434C0 
		public int Count { get; } // 0x0000000184431A70-0x0000000184431A80 
		public BezierKnot this[int index] { get => default; } // 0x000000018724DBE0-0x000000018724DC20 
	
		// Nested types
		private struct Slice<T> : IReadOnlyList<T> // TypeDefIndex: 90017
			where T : struct
		{
			// Fields
			private NativeSlice<T> m_Slice;
	
			// Properties
			public int Count { get; }
			public T this[int index] { get => default; }
	
			// Constructors
			public Slice(NativeArray<T> array, int start, int count);
	
			// Methods
			public IEnumerator<T> GetEnumerator();
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		public NativeSpline(ISpline spline, float4x4 transform, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0264AAA3 */); // 0x000000018D401DB8-0x000000018D401EA4
		public NativeSpline(IReadOnlyList<BezierKnot> knots, IReadOnlyList<int> splits, bool closed, float4x4 transform, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0264AAA4 */); // 0x000000018D401788-0x000000018D401DB8
	
		// Methods
		public float GetLength(); // 0x000000018723CEF0-0x000000018723CF00
		public IEnumerator<BezierKnot> GetEnumerator(); // 0x000000018D4016E4-0x000000018D401780
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D401780-0x000000018D401788
		public BezierCurve GetCurve(int index); // 0x000000018725EED0-0x000000018725EF00
		public float GetCurveLength(int curveIndex); // 0x000000018725EEB0-0x000000018725EED0
		public void Dispose(); // 0x000000018D401580-0x000000018D4015F4
		public float GetCurveInterpolation(int curveIndex, float curveDistance); // 0x000000018D4015F4-0x000000018D4016E4
	}

	[Serializable]
	public class Spline : ISpline, IList<BezierKnot> // TypeDefIndex: 90021
	{
		// Fields
		private const TangentMode k_DefaultTangentMode = TangentMode.Broken; // Metadata: 0x0264AAAA
		private const BezierTangent k_DefaultMainTangent = BezierTangent.Out; // Metadata: 0x0264AAAB
		private const int k_BatchModification = -1; // Metadata: 0x0264AAAC
		private const int k_CurveDistanceLutResolution = 30; // Metadata: 0x0264AAAD
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private SplineType m_EditModeType; // 0x10
		[SerializeField]
		private List<BezierKnot> m_Knots; // 0x18
		private float m_Length; // 0x20
		[HideInInspector]
		[SerializeField]
		private List<MetaData> m_MetaData; // 0x28
		[SerializeField]
		private bool m_Closed; // 0x30
		[SerializeField]
		private SplineDataDictionary<int> m_IntData; // 0x38
		[SerializeField]
		private SplineDataDictionary<float> m_FloatData; // 0x40
		[SerializeField]
		private SplineDataDictionary<float4> m_Float4Data; // 0x48
		[SerializeField]
		private SplineDataDictionary<UnityEngine.Object> m_ObjectData; // 0x50
		[CompilerGenerated]
		private Action changed; // 0x58
		[CompilerGenerated]
		private static Action<Spline, int, SplineModification> Changed; // 0x00
		[TupleElementNames(new string[2] {"curve0", "curve1" })]
		private ValueTuple<float, float> m_LastKnotChangeCurveLengths; // 0x60
	
		// Properties
		private IEnumerable<ISplineModificationHandler> embeddedSplineData { [IteratorStateMachine(typeof(_get_embeddedSplineData_d__15))] get; } // 0x000000018D405170-0x000000018D4051E0 
		public int Count { get; } // 0x0000000185DC9E40-0x0000000185DC9E80 
		public bool IsReadOnly { get; } // 0x00000001843FFFF0-0x0000000184400000 
		public IEnumerable<BezierKnot> Knots { get; } // 0x0000000182234E30-0x0000000182234E40 
		public bool Closed { get; set; } // 0x00000001822434B0-0x00000001822434C0 0x000000018D4051E0-0x000000018D4051FC
		public BezierKnot this[int index] { get => default; set {} } // 0x000000018D4050E0-0x000000018D405170 0x000000018D4051FC-0x000000018D405248
	
		// Events
		public static event Action<Spline, int, SplineModification> Changed {
			add; // 0x0000000186B0E880-0x0000000186B0E930
			remove; // 0x0000000186B0E930-0x0000000186B0E9E0
		}
	
		// Nested types
		[Serializable]
		private sealed class MetaData // TypeDefIndex: 90019
		{
			// Fields
			public TangentMode Mode; // 0x10
			public float Tension; // 0x14
			[FormerlySerializedAs("DistanceToInterpolation")]
			[SerializeField]
			private DistanceToInterpolation[] m_DistanceToInterpolation; // 0x18
	
			// Properties
			public DistanceToInterpolation[] DistanceToInterpolation { get; } // 0x0000000185DC8F50-0x0000000185DC8FA0 
	
			// Constructors
			public MetaData(); // 0x0000000185DC8C80-0x0000000185DC8CF0
	
			// Methods
			public void InvalidateCache(); // 0x0000000185DC8CF0-0x0000000185DC8D80
		}
	
		[CompilerGenerated]
		private sealed class _get_embeddedSplineData_d__15 : IEnumerable<ISplineModificationHandler>, IEnumerator<ISplineModificationHandler> // TypeDefIndex: 90020
		{
			// Fields
			private int __1__state; // 0x10
			private ISplineModificationHandler __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public Spline __4__this; // 0x28
			private IEnumerator<SplineDataKeyValuePair<int>> __7__wrap1; // 0x30
			private IEnumerator<SplineDataKeyValuePair<float>> __7__wrap2; // 0x38
			private IEnumerator<SplineDataKeyValuePair<float4>> __7__wrap3; // 0x40
			private IEnumerator<SplineDataKeyValuePair<UnityEngine.Object>> __7__wrap4; // 0x48
	
			// Properties
			ISplineModificationHandler IEnumerator<UnityEngine.Splines.ISplineModificationHandler>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _get_embeddedSplineData_d__15(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D405BDC-0x000000018D405DBC
			private bool MoveNext(); // 0x000000018D4052A8-0x000000018D405AF8
			private void __m__Finally1(); // 0x000000018D405DBC-0x000000018D405E08
			private void __m__Finally2(); // 0x000000018D405E08-0x000000018D405E54
			private void __m__Finally3(); // 0x000000018D405E54-0x000000018D405EA0
			private void __m__Finally4(); // 0x000000018D405EA0-0x000000018D405EEC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D405B90-0x000000018D405BDC
			[DebuggerHidden]
			IEnumerator<ISplineModificationHandler> IEnumerable<ISplineModificationHandler>.GetEnumerator(); // 0x000000018D405AF8-0x000000018D405B88
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D405B88-0x000000018D405B90
		}
	
		// Constructors
		public Spline(); // 0x0000000185DCA590-0x0000000185DCA7A0
		public Spline(IEnumerable<BezierKnot> knots, bool closed = false /* Metadata: 0x0264AAA9 */); // 0x0000000185DCA110-0x0000000185DCA360
	
		// Methods
		internal void SetDirtyNoNotify(); // 0x000000018D404A8C-0x000000018D404B2C
		internal void SetDirty(SplineModification modificationEvent, int knotIndex = -1 /* Metadata: 0x0264AAA5 */); // 0x000000018D404B2C-0x000000018D404E4C
		protected virtual void OnSplineChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		private void EnsureMetaDataValid(); // 0x0000000185DC9250-0x0000000185DC9310
		public TangentMode GetTangentMode(int index); // 0x000000018D4045A8-0x000000018D404610
		private void ApplyTangentModeNoNotify(int index, BezierTangent main = BezierTangent.Out /* Metadata: 0x0264AAA6 */); // 0x000000018D404024-0x000000018D404320
		public int IndexOf(BezierKnot item); // 0x000000018D404610-0x000000018D40468C
		public void Insert(int index, BezierKnot knot); // 0x000000018D404884-0x000000018D4048DC
		public void Insert(int index, BezierKnot knot, TangentMode mode); // 0x000000018D404834-0x000000018D404884
		public void Insert(int index, BezierKnot knot, TangentMode mode, float tension); // 0x000000018D40468C-0x000000018D404834
		public void RemoveAt(int index); // 0x000000018D4048DC-0x000000018D4049F8
		public void SetKnot(int index, BezierKnot value, BezierTangent main = BezierTangent.Out /* Metadata: 0x0264AAA7 */); // 0x000000018D404FA8-0x000000018D405038
		public void SetKnotNoNotify(int index, BezierKnot value, BezierTangent main = BezierTangent.Out /* Metadata: 0x0264AAA8 */); // 0x000000018D404E4C-0x000000018D404FA8
		public BezierCurve GetCurve(int index); // 0x0000000185DC96D0-0x0000000185DC9870
		public float GetCurveLength(int index); // 0x0000000185DC8D80-0x0000000185DC8F50
		public float GetLength(); // 0x0000000185DC8A20-0x0000000185DC8AB0
		private DistanceToInterpolation[] GetCurveDistanceLut(int index); // 0x0000000185DC8940-0x0000000185DC8A20
		public float GetCurveInterpolation(int curveIndex, float curveDistance); // 0x0000000185DC87B0-0x0000000185DC8840
		public IEnumerator<BezierKnot> GetEnumerator(); // 0x000000018D404500-0x000000018D4045A8
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D405038-0x000000018D4050E0
		public void Add(BezierKnot item); // 0x000000018D403F6C-0x000000018D403FB0
		public void Add(BezierKnot item, TangentMode mode); // 0x000000018D403FB0-0x000000018D404024
		public void Clear(); // 0x000000018D4043A8-0x000000018D404420
		public bool Contains(BezierKnot item); // 0x000000018D404420-0x000000018D40449C
		public void CopyTo(BezierKnot[] array, int arrayIndex); // 0x000000018D40449C-0x000000018D404500
		public bool Remove(BezierKnot item); // 0x000000018D4049F8-0x000000018D404A8C
		internal void CacheKnotOperationCurves(int index); // 0x000000018D404320-0x000000018D4043A8
	}

	[AddComponentMenu("Splines/Spline")]
	[ExecuteInEditMode]
	public class SplineContainer : MonoBehaviour, ISplineContainer, ISerializationCallbackReceiver // TypeDefIndex: 90023
	{
		// Fields
		private const string k_IconPath = "Packages/com.unity.splines/Editor/Resources/Icons/SplineComponent.png"; // Metadata: 0x0264AAAE
		[HideInInspector]
		[Obsolete]
		[SerializeField]
		private Spline m_Spline; // 0x18
		[SerializeField]
		private Spline[] m_Splines; // 0x20
		[SerializeField]
		private KnotLinkCollection m_Knots; // 0x28
		[TupleElementNames(new string[2] {"previousIndex", "newIndex" })]
		private List<ValueTuple<int, int>> m_ReorderedSplinesIndices; // 0x30
		private List<int> m_RemovedSplinesIndices; // 0x38
		private List<int> m_AddedSplinesIndices; // 0x40
		[CompilerGenerated]
		private static Action<SplineContainer, int> SplineAdded; // 0x00
		[CompilerGenerated]
		private static Action<SplineContainer, int> SplineRemoved; // 0x08
		[CompilerGenerated]
		private static Action<SplineContainer, int, int> SplineReordered; // 0x10
	
		// Properties
		public IReadOnlyList<Spline> Splines { get; set; } // 0x000000018D402994-0x000000018D402A08 0x000000018D402C34-0x000000018D403338
		public KnotLinkCollection KnotLinkCollection { get; } // 0x0000000182262130-0x0000000182262140 
		public Spline this[int index] { get => default; } // 0x000000018D402934-0x000000018D402960 
		private bool IsScaled { get; } // 0x000000018D4028A4-0x000000018D402934 
		public Spline Spline { get; set; } // 0x000000018D402960-0x000000018D402994 0x000000018D402BEC-0x000000018D402C34
	
		// Events
		public static event Action<SplineContainer, int> SplineAdded {
			add; // 0x000000018D4026C0-0x000000018D40275C
			remove; // 0x000000018D402A08-0x000000018D402AA4
		}
		public static event Action<SplineContainer, int> SplineRemoved {
			add; // 0x000000018D40275C-0x000000018D402800
			remove; // 0x000000018D402AA4-0x000000018D402B48
		}
		public static event Action<SplineContainer, int, int> SplineReordered {
			add; // 0x000000018D402800-0x000000018D4028A4
			remove; // 0x000000018D402B48-0x000000018D402BEC
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 90022
		{
			// Fields
			public IReadOnlyList<Spline> value; // 0x10
			public int i; // 0x18
			public Predicate<Spline> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _set_Splines_b__0(Spline spline); // 0x000000018D405248-0x000000018D4052A8
		}
	
		// Constructors
		public SplineContainer(); // 0x0000000185DCA360-0x0000000185DCA540
	
		// Methods
		private static int IndexOf(IReadOnlyList<Spline> self, Spline elementToFind); // 0x000000018D4024CC-0x000000018D402560
		private void OnEnable(); // 0x0000000186B0E780-0x0000000186B0E800
		private void OnDisable(); // 0x0000000186B0E800-0x0000000186B0E880
		private void OnSplineChanged(Spline spline, int index, SplineModification modificationType); // 0x000000018D4025E4-0x000000018D4026C0
		private void OnKnotModified(Spline spline, int index); // 0x000000018D402560-0x000000018D4025E4
		public bool Evaluate(float t, out float3 position, out float3 tangent, out float3 upVector); // 0x000000018D4023F8-0x000000018D402428
		public bool Evaluate(int splineIndex, float t, out float3 position, out float3 tangent, out float3 upVector); // 0x000000018D402428-0x000000018D4024CC
		public bool Evaluate<T>(T spline, float t, out float3 position, out float3 tangent, out float3 upVector)
			where T : ISpline;
		public float3 EvaluatePosition(float t); // 0x000000018D402110-0x000000018D40214C
		public Vector3 EvaluatePositionV3(float t); // 0x000000018D4020B4-0x000000018D402110
		public float3 EvaluatePosition(int splineIndex, float t); // 0x000000018D40214C-0x000000018D402208
		public float3 EvaluatePosition<T>(T spline, float t)
			where T : ISpline;
		public float3 EvaluateTangent(float t); // 0x000000018D4022C4-0x000000018D402300
		public float3 EvaluateTangent(int splineIndex, float t); // 0x000000018D402208-0x000000018D4022C4
		public float3 EvaluateTangent<T>(T spline, float t)
			where T : ISpline;
		public float3 EvaluateUpVector(float t); // 0x000000018D4023BC-0x000000018D4023F8
		public float3 EvaluateUpVector(int splineIndex, float t); // 0x000000018D402300-0x000000018D4023BC
		public float3 EvaluateUpVector<T>(T spline, float t)
			where T : ISpline;
		public float3 EvaluateAcceleration(float t); // 0x000000018D402078-0x000000018D4020B4
		public float3 EvaluateAcceleration(int splineIndex, float t); // 0x000000018D401FBC-0x000000018D402078
		public float3 EvaluateAcceleration<T>(T spline, float t)
			where T : ISpline;
		public float CalculateLength(); // 0x000000018D401FB0-0x000000018D401FBC
		public float CalculateLength(int splineIndex); // 0x000000018D401EA4-0x000000018D401FB0
		public void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnAfterDeserialize(); // 0x0000000185DC9DE0-0x0000000185DC9E40
	}

	public enum PathIndexUnit // TypeDefIndex: 90024
	{
		Distance = 0,
		Normalized = 1,
		Knot = 2
	}

	internal interface ISplineModificationHandler // TypeDefIndex: 90025
	{
		// Methods
		void OnSplineModified(SplineModificationData info);
	}

	[Serializable]
	[DefaultMember("Item")]
	public class SplineData<T> : IEnumerable<DataPoint<T>>, ISplineModificationHandler // TypeDefIndex: 90027
	{
		// Fields
		private static readonly DataPointComparer<DataPoint<T>> k_DataPointComparer;
		[SerializeField]
		private PathIndexUnit m_IndexUnit;
		[SerializeField]
		private T m_DefaultValue;
		[SerializeField]
		private List<DataPoint<T>> m_DataPoints;
		[NonSerialized]
		private bool m_NeedsSort;
		[CompilerGenerated]
		private Action changed;
		[CompilerGenerated]
		private Action Changed;
	
		// Properties
		public int Count { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__46 : IEnumerator<DataPoint<T>> // TypeDefIndex: 90026
		{
			// Fields
			private int __1__state;
			private DataPoint<T> __2__current;
			public SplineData<T> __4__this;
			private int _i_5__2;
			private int _c_5__3;
	
			// Properties
			DataPoint<T> IEnumerator<UnityEngine.Splines.DataPoint<T>>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SplineData();
		static SplineData();
	
		// Methods
		[IteratorStateMachine(typeof(_GetEnumerator_d__46))]
		public IEnumerator<DataPoint<T>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		void ISplineModificationHandler.OnSplineModified(SplineModificationData data);
	}

	[Serializable]
	internal class SplineDataKeyValuePair<T> // TypeDefIndex: 90028
	{
		// Fields
		public string Key;
		public SplineData<T> Value;
	
		// Constructors
		public SplineDataKeyValuePair();
	}

	[Serializable]
	[DefaultMember("Item")]
	internal class SplineDataDictionary<T> : IEnumerable<SplineDataKeyValuePair<T>> // TypeDefIndex: 90029
	{
		// Fields
		[SerializeField]
		private List<SplineDataKeyValuePair<T>> m_Data;
	
		// Constructors
		public SplineDataDictionary();
	
		// Methods
		public IEnumerator<SplineDataKeyValuePair<T>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	[Serializable]
	public struct SplineKnotIndex : IEquatable<SplineKnotIndex> // TypeDefIndex: 90030
	{
		// Fields
		public int Spline; // 0x00
		public int Knot; // 0x04
	
		// Constructors
		public SplineKnotIndex(int spline, int knot); // 0x00000001827241A0-0x00000001827241B0
	
		// Methods
		public bool Equals(SplineKnotIndex otherIndex); // 0x00000001887DCEB4-0x00000001887DCEC8
		public override bool Equals(object obj); // 0x000000018D403338-0x000000018D40339C
		public override int GetHashCode(); // 0x000000018725EF00-0x000000018725EF10
		public override string ToString(); // 0x000000018D40339C-0x000000018D403424
	}

	public static class SplineMath // TypeDefIndex: 90031
	{
		// Methods
		public static float3 PointLineNearestPoint(float3 p, float3 a, float3 b, out float lineParam); // 0x000000018D403424-0x000000018D4035D8
	}

	public enum SplineModification // TypeDefIndex: 90032
	{
		Default = 0,
		ClosedModified = 1,
		KnotModified = 2,
		KnotInserted = 3,
		KnotRemoved = 4,
		KnotReordered = 5
	}

	internal struct SplineModificationData // TypeDefIndex: 90033
	{
		// Fields
		public readonly Spline Spline; // 0x00
		public readonly SplineModification Modification; // 0x08
		public readonly int KnotIndex; // 0x0C
		public readonly float PrevCurveLength; // 0x10
		public readonly float NextCurveLength; // 0x14
	
		// Constructors
		public SplineModificationData(Spline spline, SplineModification modification, int knotIndex, float prevCurveLength, float nextCurveLength); // 0x000000018D4035D8-0x000000018D403610
	}

	[Obsolete("Replaced by GetTangentMode and SetTangentMode.")]
	public enum SplineType : byte // TypeDefIndex: 90034
	{
		CatmullRom = 0,
		Bezier = 1,
		Linear = 2
	}

	public static class SplineUtility // TypeDefIndex: 90036
	{
		// Nested types
		private struct Segment // TypeDefIndex: 90035
		{
			// Fields
			public float start; // 0x00
			public float length; // 0x04
	
			// Constructors
			public Segment(float start, float length); // 0x0000000187234A10-0x0000000187234A20
		}
	
		// Methods
		public static int GetSubdivisionCount(float length, int resolution); // 0x000000018D403EDC-0x000000018D403F34
		private static Segment GetNearestPoint<T>(T spline, float3 point, Segment range, out float distance, out float3 nearest, out float time, int segments)
			where T : ISpline;
		public static float GetNearestPoint<T>(T spline, float3 point, out float3 nearest, out float t, int resolution = 4 /* Metadata: 0x0264AB01 */, int iterations = 2 /* Metadata: 0x0264AB02 */)
			where T : ISpline;
		internal static int PreviousIndex(int index, int count, bool wrap); // 0x000000018D403F50-0x000000018D403F6C
		internal static int NextIndex(int index, int count, bool wrap); // 0x000000018D403F34-0x000000018D403F50
		internal static float3 GetExplicitLinearTangent(float3 point, float3 to); // 0x000000018D403B78-0x000000018D403BFC
		public static float3 GetAutoSmoothTangent(float3 previous, float3 current, float3 next, float tension = 0.33333334f /* Metadata: 0x0264AB03 */); // 0x000000018D403860-0x000000018D403B78
		public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next, float3 normal, float width, float tension = 0.33333334f /* Metadata: 0x0264AB07 */); // 0x000000018D403610-0x000000018D403860
		internal static quaternion GetKnotRotation(float3 tangent, float3 normal); // 0x000000018D403BFC-0x000000018D403EDC
		internal static bool IsIndexValid<T>(T container, SplineKnotIndex index)
			where T : ISplineContainer;
	
		// Extension methods
		public static bool Evaluate<T>(this T spline, float t, out float3 position, out float3 tangent, out float3 upVector)
			where T : ISpline;
		public static float3 EvaluatePosition<T>(this T spline, float t)
			where T : ISpline;
		public static Vector3 EvaluatePositionV3<T>(this T spline, float t)
			where T : ISpline;
		public static float3 EvaluateTangent<T>(this T spline, float t)
			where T : ISpline;
		public static float3 EvaluateUpVector<T>(this T spline, float t)
			where T : ISpline;
		private static float3 EvaluateUpVector<T>(this T spline, int curveIndex, float curveT)
			where T : ISpline;
		public static float3 EvaluateAcceleration<T>(this T spline, float t)
			where T : ISpline;
		public static int SplineToCurveT<T>(this T spline, float splineT, out float curveT)
			where T : ISpline;
		private static int SplineToCurveT<T>(this T spline, float splineT, out float curveT, bool useLUT)
			where T : ISpline;
		public static float CalculateLength<T>(this T spline, float4x4 transform)
			where T : ISpline;
		public static int GetCurveCount<T>(this T spline)
			where T : ISpline;
		public static int PreviousIndex<T>(this T spline, int index)
			where T : ISpline;
		public static int NextIndex<T>(this T spline, int index)
			where T : ISpline;
		public static BezierKnot Previous<T>(this T spline, int index)
			where T : ISpline;
		public static BezierKnot Next<T>(this T spline, int index)
			where T : ISpline;
		public static void SetLinkedKnotPosition<T>(this T container, SplineKnotIndex index)
			where T : ISplineContainer;
	}
}
