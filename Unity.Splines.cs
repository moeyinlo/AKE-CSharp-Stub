/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

// Image 82: Unity.Splines.dll - Assembly: Unity.Splines, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60069-60105

namespace UnityEngine.Splines
{
	internal static class ArrayUtility // TypeDefIndex: 60070
	{
		// Methods
		public static void RemoveAt<T>(ref ref T[] array, int index) {}
		public static void Remove<T>(ref ref T[] array, T element) {}
	}

	public struct BezierCurve : IEquatable<BezierCurve> // TypeDefIndex: 60071
	{
		// Fields
		public float3 P0; // 0x00
		public float3 P1; // 0x0C
		public float3 P2; // 0x18
		public float3 P3; // 0x24
	
		// Constructors
		public BezierCurve(float3 p0, float3 p1, float3 p2, float3 p3) {
			P0 = default;
			P1 = default;
			P2 = default;
			P3 = default;
		} // 0x0000000185FE24E0-0x0000000185FE2530
		public BezierCurve(BezierKnot a, BezierKnot b) {
			P0 = default;
			P1 = default;
			P2 = default;
			P3 = default;
		} // 0x00000001848EE0E0-0x00000001848EE210
	
		// Methods
		public bool Equals(BezierCurve other) => default; // 0x000000018BD87E98-0x000000018BD87F5C
		public override bool Equals(object obj) => default; // 0x000000018BDEA9F8-0x000000018BDEAA78
		public override int GetHashCode() => default; // 0x000000018BDEAA78-0x000000018BDEAB08
	}

	[Serializable]
	public struct BezierKnot : ISerializationCallbackReceiver, IEquatable<BezierKnot> // TypeDefIndex: 60072
	{
		// Fields
		public float3 Position; // 0x00
		public float3 TangentIn; // 0x0C
		public float3 TangentOut; // 0x18
		public quaternion Rotation; // 0x24
		public float Width; // 0x34
	
		// Constructors
		public BezierKnot(float3 position) {
			Position = default;
			TangentIn = default;
			TangentOut = default;
			Rotation = default;
			Width = default;
		} // 0x000000018BDEB4E8-0x000000018BDEB570
		public BezierKnot(float3 position, float3 tangentIn, float3 tangentOut, quaternion rotation, float width = 1f /* Metadata: 0x020825BF */) {
			Position = default;
			TangentIn = default;
			TangentOut = default;
			Rotation = default;
			Width = default;
		} // 0x0000000185FE56F0-0x0000000185FE5740
	
		// Methods
		public BezierKnot Transform(float4x4 matrix) => default; // 0x000000018BDEB25C-0x000000018BDEB4E8
		internal BezierKnot BakeTangentDirectionToRotation(bool mirrored, BezierTangent main = BezierTangent.Out /* Metadata: 0x020825C3 */) => default; // 0x000000018BDEAB08-0x000000018BDEAE0C
		public void OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		public void OnAfterDeserialize() {} // 0x000000018BDEB064-0x000000018BDEB0D0
		public override string ToString() => default; // 0x000000018BDEB0D0-0x000000018BDEB25C
		public bool Equals(BezierKnot other) => default; // 0x000000018BDEAE0C-0x000000018BDEAEE0
		public override bool Equals(object obj) => default; // 0x000000018BDEAEE0-0x000000018BDEAF6C
		public override int GetHashCode() => default; // 0x000000018BDEAF6C-0x000000018BDEB064
	}

	public enum TangentMode // TypeDefIndex: 60073
	{
		AutoSmooth = 0,
		Linear = 1,
		Mirrored = 2,
		Continuous = 3,
		Broken = 4
	}

	public enum BezierTangent // TypeDefIndex: 60074
	{
		In = 0,
		Out = 1
	}

	public static class CurveUtility // TypeDefIndex: 60076
	{
		// Fields
		private static readonly DistanceToInterpolation[] k_DistanceLUT; // 0x00
	
		// Nested types
		private struct FrenetFrame // TypeDefIndex: 60075
		{
			// Fields
			public float3 origin; // 0x00
			public float3 tangent; // 0x0C
			public float3 normal; // 0x18
			public float3 binormal; // 0x24
		}
	
		// Constructors
		static CurveUtility() {} // 0x0000000185F655F0-0x0000000185F65660
	
		// Methods
		public static float3 EvaluatePosition(BezierCurve curve, float t) => default; // 0x00000001848EF160-0x00000001848EF3B0
		public static float3 EvaluateTangent(BezierCurve curve, float t) => default; // 0x00000001857E55B0-0x00000001857E57C0
		public static float3 EvaluateAcceleration(BezierCurve curve, float t) => default; // 0x000000018BDEB5D0-0x000000018BDEB754
		public static void CalculateCurveLengths(BezierCurve curve, DistanceToInterpolation[] lookupTable) {} // 0x00000001848EEED0-0x00000001848EF160
		private static bool Approximately(float a, float b) => default; // 0x000000018BDEB570-0x000000018BDEB5D0
		internal static float3 EvaluateUpVector(BezierCurve curve, float t, float3 startUp, float3 endUp) => default; // 0x000000018BDEB754-0x000000018BDEC244
		private static FrenetFrame GetNextRotationMinimizingFrame(BezierCurve curve, FrenetFrame previousRMFrame, float nextRMFrameT) => default; // 0x000000018BDEC244-0x000000018BDEC79C
		public static float GetDistanceToInterpolation<T>(T lut, float distance)
			where T : IReadOnlyList<DistanceToInterpolation> => default;
	}

	public interface IDataPoint // TypeDefIndex: 60077
	{
		// Properties
		float Index { get; }
	}

	[Serializable]
	public struct DataPoint<TDataType> : IComparable<DataPoint<TDataType>>, IComparable<float>, IDataPoint // TypeDefIndex: 60078
	{
		// Fields
		private float m_Index;
		private TDataType m_Value;
	
		// Properties
		public float Index { get => default; set {} }
		public TDataType Value { get => default; }
	
		// Methods
		public int CompareTo(DataPoint<TDataType> other) => default;
		public int CompareTo(float other) => default;
		public override string ToString() => default;
	}

	internal class DataPointComparer<T> : IComparer<T> // TypeDefIndex: 60079
		where T : IDataPoint
	{
		// Constructors
		public DataPointComparer() {}
	
		// Methods
		public int Compare(T x, T y) => default;
	}

	[Serializable]
	public struct DistanceToInterpolation // TypeDefIndex: 60080
	{
		// Fields
		public float Distance; // 0x00
		public float T; // 0x04
		internal static readonly DistanceToInterpolation Invalid; // 0x00
	
		// Constructors
		static DistanceToInterpolation() {
			Invalid = default;
		} // 0x0000000185FA1270-0x0000000185FA12B0
	}

	public interface IHasEmptyCurves // TypeDefIndex: 60081
	{
		// Properties
		IReadOnlyList<int> EmptyCurves { get; }
	}

	public interface ISpline : IReadOnlyList<BezierKnot> // TypeDefIndex: 60082
	{
		// Properties
		bool Closed { get; }
	
		// Methods
		float GetLength();
		BezierCurve GetCurve(int index);
		float GetCurveLength(int index);
		float GetCurveInterpolation(int curveIndex, float curveDistance);
	}

	public interface ISplineContainer // TypeDefIndex: 60083
	{
		// Properties
		IReadOnlyList<Spline> Splines { get; }
		KnotLinkCollection KnotLinkCollection { get; }
	}

	[Serializable]
	public sealed class KnotLinkCollection // TypeDefIndex: 60085
	{
		// Fields
		private KnotLink[] m_KnotsLink; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class KnotLink : IReadOnlyList<SplineKnotIndex> // TypeDefIndex: 60084
		{
			// Fields
			public SplineKnotIndex[] Knots; // 0x10
	
			// Properties
			public int Count { get => default; } // 0x000000018BDEC9B4-0x000000018BDECA70 
			public SplineKnotIndex this[int index] { get => default; } // 0x000000018BDEC868-0x000000018BDEC888 
	
			// Constructors
			public KnotLink() {} // 0x000000018BDEC888-0x000000018BDEC8C0
	
			// Methods
			public IEnumerator<SplineKnotIndex> GetEnumerator() => default; // 0x000000018BDEC79C-0x000000018BDEC834
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BDEC988-0x000000018BDEC9B4
		}
	
		// Constructors
		public KnotLinkCollection() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		private KnotLink GetKnotLinksInternal(SplineKnotIndex index) => default; // 0x000000018BDEC834-0x000000018BDEC858
		public bool TryGetKnotLinks(SplineKnotIndex knotIndex, out IReadOnlyList<SplineKnotIndex> linkedKnots) {
			linkedKnots = default;
			return default;
		} // 0x000000018BDEC858-0x000000018BDEC868
		public void Unlink(SplineKnotIndex knot) {} // 0x000000018BDEC8C0-0x000000018BDEC988
		public void KnotRemoved(int splineIndex, int knotIndex) {} // 0x000000018BDECA70-0x000000018BDECAB8
		public void KnotRemoved(SplineKnotIndex index) {} // 0x000000018BDECAB8-0x000000018BDECB00
		public void KnotInserted(int splineIndex, int knotIndex) {} // 0x000000018BB055FC-0x000000018BB0561C
		public void KnotInserted(SplineKnotIndex index) {} // 0x00000001877752B4-0x00000001877752D0
		public void ShiftKnotIndices(SplineKnotIndex index, int offset) {} // 0x000000018BDECB00-0x000000018BDECB2C
	}

	public struct NativeSpline : ISpline, IDisposable // TypeDefIndex: 60087
	{
		// Fields
		private NativeArray<BezierKnot> m_Knots; // 0x00
		private NativeArray<BezierCurve> m_Curves; // 0x10
		private NativeArray<DistanceToInterpolation> m_SegmentLengthsLookupTable; // 0x20
		private bool m_Closed; // 0x30
		private float m_Length; // 0x34
	
		// Properties
		public bool Closed { get => default; } // 0x000000018BDECD30-0x000000018BDECD38 
		public int Count { get => default; } // 0x000000018BDED364-0x000000018BDED450 
		public BezierKnot this[int index] { get => default; } // 0x0000000185FE5760-0x0000000185FE5790 
	
		// Nested types
		private struct Slice<T> : IReadOnlyList<T> // TypeDefIndex: 60086
			where T : struct
		{
			// Fields
			private NativeSlice<T> m_Slice;
	
			// Properties
			public int Count { get => default; } // 0x0000000185FCB2A0-0x0000000185FCB2E0 
			public T this[int index] { get => default; } // 0x000000018BDECC94-0x000000018BDECD30 
	
			// Constructors
			public Slice(NativeArray<T> array, int start, int count) : this() {
				m_Slice = default;
			} // 0x00000001814294C0-0x00000001814294D0
	
			// Methods
			public IEnumerator<T> GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000185FB8060-0x0000000185FB8070
		}
	
		// Constructors
		public NativeSpline(ISpline spline, float4x4 transform, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x020825CB */) : this() {
			m_Knots = default;
			m_Curves = default;
			m_SegmentLengthsLookupTable = default;
			m_Closed = default;
			m_Length = default;
		} // 0x000000018BDECBA0-0x000000018BDECC94
		public NativeSpline(IReadOnlyList<BezierKnot> knots, IReadOnlyList<int> splits, bool closed, float4x4 transform, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x020825CC */) : this() {
			m_Knots = default;
			m_Curves = default;
			m_SegmentLengthsLookupTable = default;
			m_Closed = default;
			m_Length = default;
		}
	
		// Methods
		public float GetLength() => default; // 0x000000018BDECD38-0x000000018BDED364
		public IEnumerator<BezierKnot> GetEnumerator() => default; // 0x0000000185FE5740-0x0000000185FE5760
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BDECB2C-0x000000018BDECBA0
		public BezierCurve GetCurve(int index) => default;
		public float GetCurveLength(int curveIndex) => default;
		public void Dispose() {}
		public float GetCurveInterpolation(int curveIndex, float curveDistance) => default;
	}

	[Serializable]
	public class Spline : ISpline, IList<BezierKnot> // TypeDefIndex: 60090
	{
		// Fields
		private const TangentMode k_DefaultTangentMode = TangentMode.Broken; // Metadata: 0x020825D2
		private const BezierTangent k_DefaultMainTangent = BezierTangent.Out; // Metadata: 0x020825D3
		private const int k_BatchModification = -1; // Metadata: 0x020825D4
		private const int k_CurveDistanceLutResolution = 30; // Metadata: 0x020825D5
		private SplineType m_EditModeType; // 0x10
		private List<BezierKnot> m_Knots; // 0x18
		private float m_Length; // 0x20
		private List<MetaData> m_MetaData; // 0x28
		private bool m_Closed; // 0x30
		private SplineDataDictionary<int> m_IntData; // 0x38
		private SplineDataDictionary<float> m_FloatData; // 0x40
		private SplineDataDictionary<float4> m_Float4Data; // 0x48
		private SplineDataDictionary<UnityEngine.Object> m_ObjectData; // 0x50
		private Action changed; // 0x58
		private static Action<Spline, int, SplineModification> Changed; // 0x00
		private ValueTuple<float, float> m_LastKnotChangeCurveLengths; // 0x60
	
		// Properties
		private IEnumerable<ISplineModificationHandler> embeddedSplineData { get => default; } // 0x000000018BDF0138-0x000000018BDF0190 
		public int Count { get => default; } // 0x000000018BDF00E8-0x000000018BDF0138 
		public bool IsReadOnly { get => default; } // 0x000000018BDEFF40-0x000000018BDF00E8 
		public IEnumerable<BezierKnot> Knots { get => default; } // 0x00000001848EE500-0x00000001848EE6D0 
		public bool Closed { get => default; set {} } // 0x00000001848EDEA0-0x00000001848EDF40 0x00000001848EC9B0-0x00000001848ECA90
		public BezierKnot this[int index] { get => default; set {} } // 0x000000018BDEFC60-0x000000018BDEFCD4 0x000000018BDEFCD4-0x000000018BDEFD50
	
		// Events
		public static event Action<Spline, int, SplineModification> Changed;
	
		// Nested types
		[Serializable]
		private sealed class MetaData // TypeDefIndex: 60088
		{
			// Fields
			public TangentMode Mode; // 0x10
			public float Tension; // 0x14
			private DistanceToInterpolation[] m_DistanceToInterpolation; // 0x18
	
			// Properties
			public DistanceToInterpolation[] DistanceToInterpolation { get => default; } // 0x000000018BDF0CB0-0x000000018BDF0D20 
	
			// Constructors
			public MetaData() {} // 0x0000000185C25790-0x0000000185C257D0
	
			// Methods
			public void InvalidateCache() {} // 0x00000001814A81B0-0x00000001814A81C0
		}
	
		private sealed class _get_embeddedSplineData_d__15 : IEnumerable<ISplineModificationHandler>, IEnumerator<ISplineModificationHandler> // TypeDefIndex: 60089
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
			ISplineModificationHandler IEnumerator<UnityEngine.Splines.ISplineModificationHandler>.Current { get => default; } // 0x000000018BDEF8DC-0x000000018BDEFBD8 
			object IEnumerator.Current { get => default; } // 0x00000001814294C0-0x00000001814294D0 
	
			// Constructors
			public _get_embeddedSplineData_d__15() {} // Dummy constructor
			public _get_embeddedSplineData_d__15(int __1__state) {} // 0x000000018BDF0B84-0x000000018BDF0C20
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BDF0D20-0x000000018BDF0DBC
			private bool MoveNext() => default; // 0x000000018BDF0340-0x000000018BDF03E0
			private void __m__Finally1() {} // 0x000000018BDF03E0-0x000000018BDF06F8
			private void __m__Finally2() {} // 0x0000000185492010-0x0000000185492020
			private void __m__Finally3() {} // 0x00000001848EE720-0x00000001848EE8A0
			private void __m__Finally4() {} // 0x000000018BDEFE5C-0x000000018BDEFEC4
			void IEnumerator.Reset() {} // 0x0000000181377E40-0x0000000181377E50
			IEnumerator<ISplineModificationHandler> IEnumerable<ISplineModificationHandler>.GetEnumerator() => default; // 0x000000018BDF0DBC-0x000000018BDF0DD8
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BDEFEC4-0x000000018BDEFF40
		}
	
		// Constructors
		public Spline() {} // 0x000000018BDEFBD8-0x000000018BDEFC60
		public Spline(IEnumerable<BezierKnot> knots, bool closed = false /* Metadata: 0x020825D1 */) {} // 0x00000001848EE6D0-0x00000001848EE720
	
		// Methods
		internal void SetDirtyNoNotify() {} // 0x000000018BDF0DD8-0x000000018BDF0E24
		internal void SetDirty(SplineModification modificationEvent, int knotIndex = -1 /* Metadata: 0x020825CD */) {} // 0x000000018BDF0854-0x000000018BDF08E0
		protected virtual void OnSplineChanged() {} // 0x000000018BDF06F8-0x000000018BDF0854
		private void EnsureMetaDataValid() {} // 0x000000018BDF0988-0x000000018BDF0B84
		public TangentMode GetTangentMode(int index) => default; // 0x00000001848EB720-0x00000001848EB970
		private void ApplyTangentModeNoNotify(int index, BezierTangent main = BezierTangent.Out /* Metadata: 0x020825CE */) {} // 0x00000001848EDF40-0x00000001848EE0E0
		public int IndexOf(BezierKnot item) => default; // 0x00000001848EBE90-0x00000001848EBF20
		public void Insert(int index, BezierKnot knot) {} // 0x000000018BDEFDB4-0x000000018BDEFE5C
		public void Insert(int index, BezierKnot knot, TangentMode mode) {} // 0x000000018BDF08E0-0x000000018BDF0988
		public void Insert(int index, BezierKnot knot, TangentMode mode, float tension) {} // 0x000000018BDEF828-0x000000018BDEF86C
		public void RemoveAt(int index) {} // 0x000000018BDEF86C-0x000000018BDEF8DC
		public void SetKnot(int index, BezierKnot value, BezierTangent main = BezierTangent.Out /* Metadata: 0x020825CF */) {} // 0x000000018BDEFD50-0x000000018BDEFDB4
		public void SetKnotNoNotify(int index, BezierKnot value, BezierTangent main = BezierTangent.Out /* Metadata: 0x020825D0 */) {} // 0x000000018BDF02AC-0x000000018BDF0340
		public BezierCurve GetCurve(int index) => default; // 0x00000001848EE210-0x00000001848EE280
		public float GetCurveLength(int index) => default; // 0x00000001848EE280-0x00000001848EE310
		public float GetLength() => default; // 0x0000000184775050-0x0000000184775070
		private DistanceToInterpolation[] GetCurveDistanceLut(int index) => default; // 0x000000018BDF17A8-0x000000018BDF1978
		public float GetCurveInterpolation(int curveIndex, float curveDistance) => default; // 0x000000018BDF0E7C-0x000000018BDF16C8
		public IEnumerator<BezierKnot> GetEnumerator() => default; // 0x000000018BDF1978-0x000000018BDF19C0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BDF19C0-0x000000018BDF1A08
		public void Add(BezierKnot item) {} // 0x000000018BDF1A08-0x000000018BDF1A50
		public void Add(BezierKnot item, TangentMode mode) {} // 0x000000018BDF1A50-0x000000018BDF1A98
		public void Clear() {} // 0x0000000181377E40-0x0000000181377E50
		public bool Contains(BezierKnot item) => default; // 0x000000018BDF175C-0x000000018BDF17A8
		public void CopyTo(BezierKnot[] array, int arrayIndex) {} // 0x0000000181377E40-0x0000000181377E50
		public bool Remove(BezierKnot item) => default; // 0x000000018BDF16C8-0x000000018BDF1754
		internal void CacheKnotOperationCurves(int index) {} // 0x000000018BDF1754-0x000000018BDF175C
	}

	public class SplineContainer : MonoBehaviour, ISplineContainer, ISerializationCallbackReceiver // TypeDefIndex: 60092
	{
		// Fields
		private const string k_IconPath = "Packages/com.unity.splines/Editor/Resources/Icons/SplineComponent.png"; // Metadata: 0x020825D6
		private Spline m_Spline; // 0x18
		private Spline[] m_Splines; // 0x20
		private KnotLinkCollection m_Knots; // 0x28
		private List<ValueTuple<int, int>> m_ReorderedSplinesIndices; // 0x30
		private List<int> m_RemovedSplinesIndices; // 0x38
		private List<int> m_AddedSplinesIndices; // 0x40
		private static Action<SplineContainer, int> SplineAdded; // 0x00
		private static Action<SplineContainer, int> SplineRemoved; // 0x08
		private static Action<SplineContainer, int, int> SplineReordered; // 0x10
	
		// Properties
		public IReadOnlyList<Spline> Splines { get => default; set {} } // 0x000000018BDEDA38-0x000000018BDEDAC4 0x00000001813B8590-0x00000001813B85A0
		public KnotLinkCollection KnotLinkCollection { get => default; } // 0x000000018BDEDC48-0x000000018BDEDCC0 
		public Spline this[int index] { get => default; } // 0x000000018BDEDBD0-0x000000018BDEDC48 
		private bool IsScaled { get => default; } // 0x000000018BDEE508-0x000000018BDEE550 
		public Spline Spline { get => default; set {} } // 0x000000018BDED96C-0x000000018BDED99C 0x000000018BDED99C-0x000000018BDEDA38
	
		// Events
		public static event Action<SplineContainer, int> SplineAdded;
		public static event Action<SplineContainer, int> SplineRemoved;
		public static event Action<SplineContainer, int, int> SplineReordered;
	
		// Nested types
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 60091
		{
			// Fields
			public IReadOnlyList<Spline> value; // 0x10
			public int i; // 0x18
			public Predicate<Spline> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass18_0() {} // 0x000000018BDEDFDC-0x000000018BDEE078
	
			// Methods
			internal bool _set_Splines_b__0(Spline spline) => default; // 0x000000018BDEE324-0x000000018BDEE3C0
		}
	
		// Constructors
		public SplineContainer() {} // 0x000000018BDF0E24-0x000000018BDF0E7C
	
		// Methods
		private static int IndexOf(IReadOnlyList<Spline> self, Spline elementToFind) => default; // 0x000000018BDEE250-0x000000018BDEE27C
		private void OnEnable() {} // 0x000000018BDEDD44-0x000000018BDEDE20
		private void OnDisable() {} // 0x000000018BDEDCC0-0x000000018BDEDD44
		private void OnSplineChanged(Spline spline, int index, SplineModification modificationType) {} // 0x000000018BDEE1C0-0x000000018BDEE250
		private void OnKnotModified(Spline spline, int index) {} // 0x000000018BDEE27C-0x000000018BDEE2B0
		public bool Evaluate(float t, out float3 position, out float3 tangent, out float3 upVector) {
			position = default;
			tangent = default;
			upVector = default;
			return default;
		}
		public bool Evaluate(int splineIndex, float t, out float3 position, out float3 tangent, out float3 upVector) {
			position = default;
			tangent = default;
			upVector = default;
			return default;
		} // 0x000000018BDED6A8-0x000000018BDED6E4
		public bool Evaluate<T>(T spline, float t, out float3 position, out float3 tangent, out float3 upVector)
			where T : ISpline {
			position = default;
			tangent = default;
			upVector = default;
			return default;
		} // 0x000000018BDED64C-0x000000018BDED6A8
		public float3 EvaluatePosition(float t) => default; // 0x000000018BDED6E4-0x000000018BDED794
		public Vector3 EvaluatePositionV3(float t) => default;
		public float3 EvaluatePosition(int splineIndex, float t) => default; // 0x000000018BDED844-0x000000018BDED880
		public float3 EvaluatePosition<T>(T spline, float t)
			where T : ISpline => default; // 0x000000018BDED794-0x000000018BDED844
		public float3 EvaluateTangent(float t) => default;
		public float3 EvaluateTangent(int splineIndex, float t) => default; // 0x000000018BDED930-0x000000018BDED96C
		public float3 EvaluateTangent<T>(T spline, float t)
			where T : ISpline => default; // 0x000000018BDED880-0x000000018BDED930
		public float3 EvaluateUpVector(float t) => default;
		public float3 EvaluateUpVector(int splineIndex, float t) => default; // 0x000000018BDED610-0x000000018BDED64C
		public float3 EvaluateUpVector<T>(T spline, float t)
			where T : ISpline => default; // 0x000000018BDED560-0x000000018BDED610
		public float3 EvaluateAcceleration(float t) => default;
		public float3 EvaluateAcceleration(int splineIndex, float t) => default; // 0x000000018BDED554-0x000000018BDED560
		public float3 EvaluateAcceleration<T>(T spline, float t)
			where T : ISpline => default; // 0x000000018BDED450-0x000000018BDED554
		public float CalculateLength() => default; // 0x0000000185492010-0x0000000185492020
		public float CalculateLength(int splineIndex) => default; // 0x000000018BDEDAC4-0x000000018BDEDBD0
		public void OnBeforeSerialize() {} // 0x000000018BDEDE20-0x000000018BDEDFDC
		public void OnAfterDeserialize() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum PathIndexUnit // TypeDefIndex: 60093
	{
		Distance = 0,
		Normalized = 1,
		Knot = 2
	}

	internal interface ISplineModificationHandler // TypeDefIndex: 60094
	{
		// Methods
		void OnSplineModified(SplineModificationData info);
	}

	[Serializable]
	public class SplineData<T> : IEnumerable<DataPoint<T>>, ISplineModificationHandler // TypeDefIndex: 60096
	{
		// Fields
		private static readonly DataPointComparer<DataPoint<T>> k_DataPointComparer;
		private PathIndexUnit m_IndexUnit;
		private T m_DefaultValue;
		private List<DataPoint<T>> m_DataPoints;
		[NonSerialized]
		private bool m_NeedsSort;
		private Action changed;
		private Action Changed;
	
		// Properties
		public int Count { get => default; }
	
		// Nested types
		private sealed class _GetEnumerator_d__46 : IEnumerator<DataPoint<T>> // TypeDefIndex: 60095
		{
			// Fields
			private int __1__state;
			private DataPoint<T> __2__current;
			public SplineData<T> __4__this;
			private int _i_5__2;
			private int _c_5__3;
	
			// Properties
			DataPoint<T> IEnumerator<UnityEngine.Splines.DataPoint<T>>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__46() {} // Dummy constructor
			public _GetEnumerator_d__46(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public SplineData() {}
		static SplineData() {}
	
		// Methods
		public IEnumerator<DataPoint<T>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		void ISplineModificationHandler.OnSplineModified(SplineModificationData data) {}
	}

	[Serializable]
	internal class SplineDataKeyValuePair<T> // TypeDefIndex: 60097
	{
		// Fields
		public string Key;
		public SplineData<T> Value;
	
		// Constructors
		public SplineDataKeyValuePair() {}
	}

	[Serializable]
	internal class SplineDataDictionary<T> : IEnumerable<SplineDataKeyValuePair<T>> // TypeDefIndex: 60098
	{
		// Fields
		private List<SplineDataKeyValuePair<T>> m_Data;
	
		// Constructors
		public SplineDataDictionary() {}
	
		// Methods
		public IEnumerator<SplineDataKeyValuePair<T>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	[Serializable]
	public struct SplineKnotIndex : IEquatable<SplineKnotIndex> // TypeDefIndex: 60099
	{
		// Fields
		public int Spline; // 0x00
		public int Knot; // 0x04
	
		// Constructors
		public SplineKnotIndex(int spline, int knot) {
			Spline = default;
			Knot = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	
		// Methods
		public bool Equals(SplineKnotIndex otherIndex) => default; // 0x0000000187333DF8-0x0000000187333E0C
		public override bool Equals(object obj) => default; // 0x000000018BDEEC38-0x000000018BDEEC9C
		public override int GetHashCode() => default; // 0x0000000185FE5790-0x0000000185FE57A0
		public override string ToString() => default; // 0x000000018BDEEC9C-0x000000018BDEED24
	}

	public static class SplineMath // TypeDefIndex: 60100
	{
		// Methods
		public static float3 PointLineNearestPoint(float3 p, float3 a, float3 b, out float lineParam) {
			lineParam = default;
			return default;
		} // 0x000000018BDEED24-0x000000018BDEEED8
	}

	public enum SplineModification // TypeDefIndex: 60101
	{
		Default = 0,
		ClosedModified = 1,
		KnotModified = 2,
		KnotInserted = 3,
		KnotRemoved = 4,
		KnotReordered = 5
	}

	internal struct SplineModificationData // TypeDefIndex: 60102
	{
		// Fields
		public readonly Spline Spline; // 0x00
		public readonly SplineModification Modification; // 0x08
		public readonly int KnotIndex; // 0x0C
		public readonly float PrevCurveLength; // 0x10
		public readonly float NextCurveLength; // 0x14
	
		// Constructors
		public SplineModificationData(Spline spline, SplineModification modification, int knotIndex, float prevCurveLength, float nextCurveLength) {
			Spline = default;
			Modification = default;
			KnotIndex = default;
			PrevCurveLength = default;
			NextCurveLength = default;
		} // 0x000000018BDEEED8-0x000000018BDEEF10
	}

	public enum SplineType : byte // TypeDefIndex: 60103
	{
		CatmullRom = 0,
		Bezier = 1,
		Linear = 2
	}

	public static class SplineUtility // TypeDefIndex: 60105
	{
		// Nested types
		private struct Segment // TypeDefIndex: 60104
		{
			// Fields
			public float start; // 0x00
			public float length; // 0x04
	
			// Constructors
			public Segment(float start, float length) {
				this.start = default;
				this.length = default;
			}
		}
	
		// Methods
		public static bool Evaluate<T>(T spline, float t, out float3 position, out float3 tangent, out float3 upVector)
			where T : ISpline {
			position = default;
			tangent = default;
			upVector = default;
			return default;
		}
		public static float3 EvaluatePosition<T>(T spline, float t)
			where T : ISpline => default;
		public static Vector3 EvaluatePositionV3<T>(T spline, float t)
			where T : ISpline => default;
		public static float3 EvaluateTangent<T>(T spline, float t)
			where T : ISpline => default;
		public static float3 EvaluateUpVector<T>(T spline, float t)
			where T : ISpline => default;
		private static float3 EvaluateUpVector<T>(T spline, int curveIndex, float curveT)
			where T : ISpline => default;
		public static float3 EvaluateAcceleration<T>(T spline, float t)
			where T : ISpline => default;
		public static int SplineToCurveT<T>(T spline, float splineT, out float curveT)
			where T : ISpline {
			curveT = default;
			return default;
		}
		private static int SplineToCurveT<T>(T spline, float splineT, out float curveT, bool useLUT)
			where T : ISpline {
			curveT = default;
			return default;
		}
		public static float CalculateLength<T>(T spline, float4x4 transform)
			where T : ISpline => default;
		public static int GetCurveCount<T>(T spline)
			where T : ISpline => default; // 0x000000018BDEF798-0x000000018BDEF7F0
		public static int GetSubdivisionCount(float length, int resolution) => default;
		private static Segment GetNearestPoint<T>(T spline, float3 point, Segment range, out float distance, out float3 nearest, out float time, int segments)
			where T : ISpline {
			distance = default;
			nearest = default;
			time = default;
			return default;
		}
		public static float GetNearestPoint<T>(T spline, float3 point, out float3 nearest, out float t, int resolution = 4 /* Metadata: 0x02082629 */, int iterations = 2 /* Metadata: 0x0208262A */)
			where T : ISpline {
			nearest = default;
			t = default;
			return default;
		}
		public static int PreviousIndex<T>(T spline, int index)
			where T : ISpline => default;
		public static int NextIndex<T>(T spline, int index)
			where T : ISpline => default;
		public static BezierKnot Previous<T>(T spline, int index)
			where T : ISpline => default;
		public static BezierKnot Next<T>(T spline, int index)
			where T : ISpline => default; // 0x000000018BDEF80C-0x000000018BDEF828
		internal static int PreviousIndex(int index, int count, bool wrap) => default; // 0x000000018BDEF7F0-0x000000018BDEF80C
		internal static int NextIndex(int index, int count, bool wrap) => default; // 0x000000018BDEF474-0x000000018BDEF4F8
		internal static float3 GetExplicitLinearTangent(float3 point, float3 to) => default; // 0x000000018BDEF15C-0x000000018BDEF474
		public static float3 GetAutoSmoothTangent(float3 previous, float3 current, float3 next, float tension = 0.33333334f /* Metadata: 0x0208262B */) => default; // 0x000000018BDEEF10-0x000000018BDEF15C
		public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next, float3 normal, float width, float tension = 0.33333334f /* Metadata: 0x0208262F */) => default; // 0x000000018BDEF4F8-0x000000018BDEF798
		internal static quaternion GetKnotRotation(float3 tangent, float3 normal) => default;
		internal static bool IsIndexValid<T>(T container, SplineKnotIndex index)
			where T : ISplineContainer => default;
		public static void SetLinkedKnotPosition<T>(T container, SplineKnotIndex index)
			where T : ISplineContainer {} // 0x0000000185FB1970-0x0000000185FB1980
	}
}
