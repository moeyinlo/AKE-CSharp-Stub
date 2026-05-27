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

// Image 82: Unity.Splines.dll - Assembly: Unity.Splines, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59044-59080
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.Splines.Editor.Debug")]
[assembly: InternalsVisibleTo("Unity.Splines.Debug")]
[assembly: InternalsVisibleTo("Unity.Splines.Tests")]
[assembly: InternalsVisibleTo("Unity.Splines.Editor")]
[assembly: InternalsVisibleTo("Unity.Splines.Editor.Tests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace UnityEngine.Splines
{
	internal static class ArrayUtility // TypeDefIndex: 59045
	{
		// Methods
		public static void RemoveAt<T>(ref ref T[] array, int index) {}
		public static void Remove<T>(ref ref T[] array, T element) {}
	}

	public struct BezierCurve : IEquatable<BezierCurve> // TypeDefIndex: 59046
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
		} // 0x0000000183D81850-0x0000000183D818A0
		public BezierCurve(BezierKnot a, BezierKnot b) {
			P0 = default;
			P1 = default;
			P2 = default;
			P3 = default;
		} // 0x0000000182E02140-0x0000000182E02270
	
		// Methods
		public bool Equals(BezierCurve other) => default; // 0x0000000189C6E67C-0x0000000189C6E740
		public override bool Equals(object obj) => default; // 0x0000000189CD11DC-0x0000000189CD125C
		public override int GetHashCode() => default; // 0x0000000189CD125C-0x0000000189CD12EC
	}

	[Serializable]
	public struct BezierKnot : ISerializationCallbackReceiver, IEquatable<BezierKnot> // TypeDefIndex: 59047
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
		} // 0x0000000189CD1CCC-0x0000000189CD1D54
		public BezierKnot(float3 position, float3 tangentIn, float3 tangentOut, quaternion rotation, float width = 1f /* Metadata: 0x01FDCCDB */) {
			Position = default;
			TangentIn = default;
			TangentOut = default;
			Rotation = default;
			Width = default;
		} // 0x0000000183D84A60-0x0000000183D84AB0
	
		// Methods
		public BezierKnot Transform(float4x4 matrix) => default; // 0x0000000189CD1A40-0x0000000189CD1CCC
		internal BezierKnot BakeTangentDirectionToRotation(bool mirrored, BezierTangent main = BezierTangent.Out /* Metadata: 0x01FDCCDF */) => default; // 0x0000000189CD12EC-0x0000000189CD15F0
		public void OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		public void OnAfterDeserialize() {} // 0x0000000189CD1848-0x0000000189CD18B4
		public override string ToString() => default; // 0x0000000189CD18B4-0x0000000189CD1A40
		public bool Equals(BezierKnot other) => default; // 0x0000000189CD15F0-0x0000000189CD16C4
		public override bool Equals(object obj) => default; // 0x0000000189CD16C4-0x0000000189CD1750
		public override int GetHashCode() => default; // 0x0000000189CD1750-0x0000000189CD1848
	}

	public enum TangentMode // TypeDefIndex: 59048
	{
		AutoSmooth = 0,
		Linear = 1,
		Mirrored = 2,
		Continuous = 3,
		Broken = 4
	}

	public enum BezierTangent // TypeDefIndex: 59049
	{
		In = 0,
		Out = 1
	}

	public static class CurveUtility // TypeDefIndex: 59051
	{
		// Fields
		private static readonly DistanceToInterpolation[] k_DistanceLUT; // 0x00
	
		// Nested types
		private struct FrenetFrame // TypeDefIndex: 59050
		{
			// Fields
			public float3 origin; // 0x00
			public float3 tangent; // 0x0C
			public float3 normal; // 0x18
			public float3 binormal; // 0x24
		}
	
		// Constructors
		static CurveUtility() {} // 0x0000000183D06910-0x0000000183D06980
	
		// Methods
		public static float3 EvaluatePosition(BezierCurve curve, float t) => default; // 0x0000000182A5DCA0-0x0000000182A5DEF0
		public static float3 EvaluateTangent(BezierCurve curve, float t) => default; // 0x0000000182E02630-0x0000000182E02840
		public static float3 EvaluateAcceleration(BezierCurve curve, float t) => default; // 0x0000000189CD1DB4-0x0000000189CD1F38
		public static void CalculateCurveLengths(BezierCurve curve, DistanceToInterpolation[] lookupTable) {} // 0x0000000182A5DA10-0x0000000182A5DCA0
		private static bool Approximately(float a, float b) => default; // 0x0000000189CD1D54-0x0000000189CD1DB4
		internal static float3 EvaluateUpVector(BezierCurve curve, float t, float3 startUp, float3 endUp) => default; // 0x0000000189CD1F38-0x0000000189CD2A28
		private static FrenetFrame GetNextRotationMinimizingFrame(BezierCurve curve, FrenetFrame previousRMFrame, float nextRMFrameT) => default; // 0x0000000189CD2A28-0x0000000189CD2F80
		public static float GetDistanceToInterpolation<T>(T lut, float distance)
			where T : IReadOnlyList<DistanceToInterpolation> => default;
	}

	public interface IDataPoint // TypeDefIndex: 59052
	{
		// Properties
		float Index { get; }
	}

	[Serializable]
	public struct DataPoint<TDataType> : IComparable<DataPoint<TDataType>>, IComparable<float>, IDataPoint // TypeDefIndex: 59053
	{
		// Fields
		[FormerlySerializedAs("m_Time")]
		[SerializeField]
		private float m_Index;
		[SerializeField]
		private TDataType m_Value;
	
		// Properties
		public float Index { get => default; set {} }
		public TDataType Value { get => default; }
	
		// Methods
		public int CompareTo(DataPoint<TDataType> other) => default;
		public int CompareTo(float other) => default;
		public override string ToString() => default;
	}

	internal class DataPointComparer<T> : IComparer<T> // TypeDefIndex: 59054
		where T : IDataPoint
	{
		// Constructors
		public DataPointComparer() {}
	
		// Methods
		public int Compare(T x, T y) => default;
	}

	[Serializable]
	public struct DistanceToInterpolation // TypeDefIndex: 59055
	{
		// Fields
		public float Distance; // 0x00
		public float T; // 0x04
		internal static readonly DistanceToInterpolation Invalid; // 0x00
	
		// Constructors
		static DistanceToInterpolation() {
			Invalid = default;
		} // 0x0000000183D41520-0x0000000183D41560
	}

	public interface IHasEmptyCurves // TypeDefIndex: 59056
	{
		// Properties
		IReadOnlyList<int> EmptyCurves { get; }
	}

	public interface ISpline : IReadOnlyList<BezierKnot> // TypeDefIndex: 59057
	{
		// Properties
		bool Closed { get; }
	
		// Methods
		float GetLength();
		BezierCurve GetCurve(int index);
		float GetCurveLength(int index);
		float GetCurveInterpolation(int curveIndex, float curveDistance);
	}

	public interface ISplineContainer // TypeDefIndex: 59058
	{
		// Properties
		IReadOnlyList<Spline> Splines { get; }
		KnotLinkCollection KnotLinkCollection { get; }
	}

	[Serializable]
	public sealed class KnotLinkCollection // TypeDefIndex: 59060
	{
		// Fields
		[SerializeField]
		private KnotLink[] m_KnotsLink; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class KnotLink : IReadOnlyList<SplineKnotIndex> // TypeDefIndex: 59059
		{
			// Fields
			public SplineKnotIndex[] Knots; // 0x10
	
			// Properties
			public int Count { get => default; } // 0x00000001842746EC-0x0000000184274708 
			public SplineKnotIndex this[int index] { get => default; } // 0x0000000189CD32E4-0x0000000189CD3310 
	
			// Constructors
			public KnotLink() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public IEnumerator<SplineKnotIndex> GetEnumerator() => default; // 0x0000000189CD329C-0x0000000189CD32E4
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001899DF280-0x00000001899DF2A0
		}
	
		// Constructors
		public KnotLinkCollection() {} // 0x0000000189CD3254-0x0000000189CD329C
	
		// Methods
		private KnotLink GetKnotLinksInternal(SplineKnotIndex index) => default; // 0x0000000189CD2F80-0x0000000189CD3018
		public bool TryGetKnotLinks(SplineKnotIndex knotIndex, out IReadOnlyList<SplineKnotIndex> linkedKnots) {
			linkedKnots = default;
			return default;
		} // 0x0000000189CD316C-0x0000000189CD3198
		public void Unlink(SplineKnotIndex knot) {} // 0x0000000189CD3198-0x0000000189CD3254
		public void KnotRemoved(int splineIndex, int knotIndex) {} // 0x0000000189CD304C-0x0000000189CD306C
		public void KnotRemoved(SplineKnotIndex index) {} // 0x0000000189CD306C-0x0000000189CD30A4
		public void KnotInserted(int splineIndex, int knotIndex) {} // 0x0000000189CD3018-0x0000000189CD303C
		public void KnotInserted(SplineKnotIndex index) {} // 0x0000000189CD303C-0x0000000189CD304C
		public void ShiftKnotIndices(SplineKnotIndex index, int offset) {} // 0x0000000189CD30A4-0x0000000189CD316C
	}

	public struct NativeSpline : ISpline, IDisposable // TypeDefIndex: 59062
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
		public bool Closed { get => default; } // 0x0000000183D4EF60-0x0000000183D4EF70 
		public int Count { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
		public BezierKnot this[int index] { get => default; } // 0x0000000183D6A320-0x0000000183D6A360 
	
		// Nested types
		private struct Slice<T> : IReadOnlyList<T> // TypeDefIndex: 59061
			where T : struct
		{
			// Fields
			private NativeSlice<T> m_Slice;
	
			// Properties
			public int Count { get => default; }
			public T this[int index] { get => default; }
	
			// Constructors
			public Slice(NativeArray<T> array, int start, int count) : this() {
				m_Slice = default;
			}
	
			// Methods
			public IEnumerator<T> GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		// Constructors
		public NativeSpline(ISpline spline, float4x4 transform, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x01FDCCE7 */) : this() {
			m_Knots = default;
			m_Curves = default;
			m_SegmentLengthsLookupTable = default;
			m_Closed = default;
			m_Length = default;
		} // 0x0000000189CD3B48-0x0000000189CD3C34
		public NativeSpline(IReadOnlyList<BezierKnot> knots, IReadOnlyList<int> splits, bool closed, float4x4 transform, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x01FDCCE8 */) : this() {
			m_Knots = default;
			m_Curves = default;
			m_SegmentLengthsLookupTable = default;
			m_Closed = default;
			m_Length = default;
		} // 0x0000000189CD351C-0x0000000189CD3B48
	
		// Methods
		public float GetLength() => default; // 0x0000000183D56CA0-0x0000000183D56CB0
		public IEnumerator<BezierKnot> GetEnumerator() => default; // 0x0000000189CD3478-0x0000000189CD3514
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189CD3514-0x0000000189CD351C
		public BezierCurve GetCurve(int index) => default; // 0x0000000183D84AD0-0x0000000183D84B00
		public float GetCurveLength(int curveIndex) => default; // 0x0000000183D84AB0-0x0000000183D84AD0
		public void Dispose() {} // 0x0000000189CD3310-0x0000000189CD3384
		public float GetCurveInterpolation(int curveIndex, float curveDistance) => default; // 0x0000000189CD3384-0x0000000189CD3478
	}

	[Serializable]
	public class Spline : ISpline, IList<BezierKnot> // TypeDefIndex: 59065
	{
		// Fields
		private const TangentMode k_DefaultTangentMode = TangentMode.Broken; // Metadata: 0x01FDCCEE
		private const BezierTangent k_DefaultMainTangent = BezierTangent.Out; // Metadata: 0x01FDCCEF
		private const int k_BatchModification = -1; // Metadata: 0x01FDCCF0
		private const int k_CurveDistanceLutResolution = 30; // Metadata: 0x01FDCCF1
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
		[TupleElementNames(new string[2] {"curve0", "curve1" })]
		private ValueTuple<float, float> m_LastKnotChangeCurveLengths; // 0x60
	
		// Properties
		private IEnumerable<ISplineModificationHandler> embeddedSplineData { [IteratorStateMachine(typeof(_get_embeddedSplineData_d__15))] get => default; } // 0x0000000189CD7494-0x0000000189CD7504 
		public int Count { get => default; } // 0x0000000182E025F0-0x0000000182E02630 
		public bool IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public IEnumerable<BezierKnot> Knots { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public bool Closed { get => default; set {} } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000189CD75A0-0x0000000189CD75BC
		public BezierKnot this[int index] { get => default; set {} } // 0x0000000189CD7404-0x0000000189CD7494 0x0000000189CD75BC-0x0000000189CD7608
	
		// Events
		public static event Action<Spline, int, SplineModification> Changed;
	
		// Nested types
		[Serializable]
		private sealed class MetaData // TypeDefIndex: 59063
		{
			// Fields
			public TangentMode Mode; // 0x10
			public float Tension; // 0x14
			[FormerlySerializedAs("DistanceToInterpolation")]
			[SerializeField]
			private DistanceToInterpolation[] m_DistanceToInterpolation; // 0x18
	
			// Properties
			public DistanceToInterpolation[] DistanceToInterpolation { get => default; } // 0x0000000182E01E20-0x0000000182E01E70 
	
			// Constructors
			public MetaData() {} // 0x0000000182E01F30-0x0000000182E01FA0
	
			// Methods
			public void InvalidateCache() {} // 0x0000000182E019D0-0x0000000182E01A60
		}
	
		// Constructors
		public Spline() {} // 0x0000000189CD716C-0x0000000189CD7368
		public Spline(IEnumerable<BezierKnot> knots, bool closed = false /* Metadata: 0x01FDCCED */) {} // 0x0000000182E02B50-0x0000000182E02DA0
	
		// Methods
		internal void SetDirtyNoNotify() {} // 0x0000000189CD6B24-0x0000000189CD6BC4
		internal void SetDirty(SplineModification modificationEvent, int knotIndex = -1 /* Metadata: 0x01FDCCE9 */) {} // 0x0000000189CD6BC4-0x0000000189CD6EDC
		protected virtual void OnSplineChanged() {} // 0x000000018350B670-0x000000018350B680
		private void EnsureMetaDataValid() {} // 0x0000000182E01E70-0x0000000182E01F30
		public TangentMode GetTangentMode(int index) => default; // 0x0000000189CD6640-0x0000000189CD66A8
		private void ApplyTangentModeNoNotify(int index, BezierTangent main = BezierTangent.Out /* Metadata: 0x01FDCCEA */) {} // 0x0000000189CD60C0-0x0000000189CD63BC
		public int IndexOf(BezierKnot item) => default; // 0x0000000189CD66A8-0x0000000189CD6724
		public void Insert(int index, BezierKnot knot) {} // 0x0000000189CD691C-0x0000000189CD6974
		public void Insert(int index, BezierKnot knot, TangentMode mode) {} // 0x0000000189CD68CC-0x0000000189CD691C
		public void Insert(int index, BezierKnot knot, TangentMode mode, float tension) {} // 0x0000000189CD6724-0x0000000189CD68CC
		public void RemoveAt(int index) {} // 0x0000000189CD6974-0x0000000189CD6A90
		public void SetKnot(int index, BezierKnot value, BezierTangent main = BezierTangent.Out /* Metadata: 0x01FDCCEB */) {} // 0x0000000189CD7038-0x0000000189CD70C4
		public void SetKnotNoNotify(int index, BezierKnot value, BezierTangent main = BezierTangent.Out /* Metadata: 0x01FDCCEC */) {} // 0x0000000189CD6EDC-0x0000000189CD7038
		public BezierCurve GetCurve(int index) => default; // 0x0000000182E01FA0-0x0000000182E02140
		public float GetCurveLength(int index) => default; // 0x0000000182E01C50-0x0000000182E01E20
		public float GetLength() => default; // 0x0000000182E01930-0x0000000182E019D0
		private DistanceToInterpolation[] GetCurveDistanceLut(int index) => default; // 0x0000000182E01760-0x0000000182E01840
		public float GetCurveInterpolation(int curveIndex, float curveDistance) => default; // 0x0000000182E01310-0x0000000182E013A0
		public IEnumerator<BezierKnot> GetEnumerator() => default; // 0x0000000189CD6598-0x0000000189CD6640
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189CD70C4-0x0000000189CD716C
		public void Add(BezierKnot item) {} // 0x0000000189CD600C-0x0000000189CD6050
		public void Add(BezierKnot item, TangentMode mode) {} // 0x0000000189CD6050-0x0000000189CD60C0
		public void Clear() {} // 0x0000000189CD6444-0x0000000189CD64B8
		public bool Contains(BezierKnot item) => default; // 0x0000000189CD64B8-0x0000000189CD6534
		public void CopyTo(BezierKnot[] array, int arrayIndex) {} // 0x0000000189CD6534-0x0000000189CD6598
		public bool Remove(BezierKnot item) => default; // 0x0000000189CD6A90-0x0000000189CD6B24
		internal void CacheKnotOperationCurves(int index) {} // 0x0000000189CD63BC-0x0000000189CD6444
	}

	[AddComponentMenu("Splines/Spline")]
	[ExecuteInEditMode]
	public class SplineContainer : MonoBehaviour, ISplineContainer, ISerializationCallbackReceiver // TypeDefIndex: 59067
	{
		// Fields
		private const string k_IconPath = "Packages/com.unity.splines/Editor/Resources/Icons/SplineComponent.png"; // Metadata: 0x01FDCCF2
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
	
		// Properties
		public IReadOnlyList<Spline> Splines { get => default; set {} } // 0x0000000189CD4A94-0x0000000189CD4B08 0x0000000189CD4D34-0x0000000189CD541C
		public KnotLinkCollection KnotLinkCollection { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public Spline this[int index] { get => default; } // 0x0000000189CD4A34-0x0000000189CD4A60 
		private bool IsScaled { get => default; } // 0x0000000189CD49A4-0x0000000189CD4A34 
		public Spline Spline { get => default; set {} } // 0x0000000189CD4A60-0x0000000189CD4A94 0x0000000189CD4CEC-0x0000000189CD4D34
	
		// Events
		public static event Action<SplineContainer, int> SplineAdded;
		public static event Action<SplineContainer, int> SplineRemoved;
		public static event Action<SplineContainer, int, int> SplineReordered;
	
		// Constructors
		public SplineContainer() {} // 0x0000000189CD4604-0x0000000189CD47C0
	
		// Methods
		private static int IndexOf(IReadOnlyList<Spline> self, Spline elementToFind) => default; // 0x0000000189CD421C-0x0000000189CD42A8
		private void OnEnable() {} // 0x0000000189CD442C-0x0000000189CD44A4
		private void OnDisable() {} // 0x0000000189CD43B4-0x0000000189CD442C
		private void OnSplineChanged(Spline spline, int index, SplineModification modificationType) {} // 0x0000000189CD4528-0x0000000189CD4604
		private void OnKnotModified(Spline spline, int index) {} // 0x0000000189CD44A4-0x0000000189CD4528
		public bool Evaluate(float t, out float3 position, out float3 tangent, out float3 upVector) {
			position = default;
			tangent = default;
			upVector = default;
			return default;
		} // 0x0000000189CD4150-0x0000000189CD4180
		public bool Evaluate(int splineIndex, float t, out float3 position, out float3 tangent, out float3 upVector) {
			position = default;
			tangent = default;
			upVector = default;
			return default;
		} // 0x0000000189CD4180-0x0000000189CD421C
		public bool Evaluate<T>(T spline, float t, out float3 position, out float3 tangent, out float3 upVector)
			where T : ISpline {
			position = default;
			tangent = default;
			upVector = default;
			return default;
		}
		public float3 EvaluatePosition(float t) => default; // 0x0000000189CD3E8C-0x0000000189CD3EC8
		public Vector3 EvaluatePositionV3(float t) => default; // 0x0000000189CD3E30-0x0000000189CD3E8C
		public float3 EvaluatePosition(int splineIndex, float t) => default; // 0x0000000189CD3EC8-0x0000000189CD3F78
		public float3 EvaluatePosition<T>(T spline, float t)
			where T : ISpline => default;
		public float3 EvaluateTangent(float t) => default; // 0x0000000189CD4028-0x0000000189CD4064
		public float3 EvaluateTangent(int splineIndex, float t) => default; // 0x0000000189CD3F78-0x0000000189CD4028
		public float3 EvaluateTangent<T>(T spline, float t)
			where T : ISpline => default;
		public float3 EvaluateUpVector(float t) => default; // 0x0000000189CD4114-0x0000000189CD4150
		public float3 EvaluateUpVector(int splineIndex, float t) => default; // 0x0000000189CD4064-0x0000000189CD4114
		public float3 EvaluateUpVector<T>(T spline, float t)
			where T : ISpline => default;
		public float3 EvaluateAcceleration(float t) => default; // 0x0000000189CD3DF4-0x0000000189CD3E30
		public float3 EvaluateAcceleration(int splineIndex, float t) => default; // 0x0000000189CD3D44-0x0000000189CD3DF4
		public float3 EvaluateAcceleration<T>(T spline, float t)
			where T : ISpline => default;
		public float CalculateLength() => default; // 0x0000000189CD3D38-0x0000000189CD3D44
		public float CalculateLength(int splineIndex) => default; // 0x0000000189CD3C34-0x0000000189CD3D38
		public void OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		public void OnAfterDeserialize() {} // 0x0000000189CD42A8-0x0000000189CD43B4
	}

	public enum PathIndexUnit // TypeDefIndex: 59068
	{
		Distance = 0,
		Normalized = 1,
		Knot = 2
	}

	internal interface ISplineModificationHandler // TypeDefIndex: 59069
	{
		// Methods
		void OnSplineModified(SplineModificationData info);
	}

	[Serializable]
	[DefaultMember("Item")]
	public class SplineData<T> : IEnumerable<DataPoint<T>>, ISplineModificationHandler // TypeDefIndex: 59071
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
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public SplineData() {}
		static SplineData() {}
	
		// Methods
		[IteratorStateMachine(typeof(_GetEnumerator_d__46))]
		public IEnumerator<DataPoint<T>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		void ISplineModificationHandler.OnSplineModified(SplineModificationData data) {}
	}

	[Serializable]
	internal class SplineDataKeyValuePair<T> // TypeDefIndex: 59072
	{
		// Fields
		public string Key;
		public SplineData<T> Value;
	
		// Constructors
		public SplineDataKeyValuePair() {}
	}

	[Serializable]
	[DefaultMember("Item")]
	internal class SplineDataDictionary<T> : IEnumerable<SplineDataKeyValuePair<T>> // TypeDefIndex: 59073
	{
		// Fields
		[SerializeField]
		private List<SplineDataKeyValuePair<T>> m_Data;
	
		// Constructors
		public SplineDataDictionary() {}
	
		// Methods
		public IEnumerator<SplineDataKeyValuePair<T>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	[Serializable]
	public struct SplineKnotIndex : IEquatable<SplineKnotIndex> // TypeDefIndex: 59074
	{
		// Fields
		public int Spline; // 0x00
		public int Knot; // 0x04
	
		// Constructors
		public SplineKnotIndex(int spline, int knot) {
			Spline = default;
			Knot = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
	
		// Methods
		public bool Equals(SplineKnotIndex otherIndex) => default; // 0x00000001851404D0-0x00000001851404E4
		public override bool Equals(object obj) => default; // 0x0000000189CD541C-0x0000000189CD5480
		public override int GetHashCode() => default; // 0x0000000183D84B00-0x0000000183D84B10
		public override string ToString() => default; // 0x0000000189CD5480-0x0000000189CD5508
	}

	public static class SplineMath // TypeDefIndex: 59075
	{
		// Methods
		public static float3 PointLineNearestPoint(float3 p, float3 a, float3 b, out float lineParam) {
			lineParam = default;
			return default;
		} // 0x0000000189CD5508-0x0000000189CD56BC
	}

	public enum SplineModification // TypeDefIndex: 59076
	{
		Default = 0,
		ClosedModified = 1,
		KnotModified = 2,
		KnotInserted = 3,
		KnotRemoved = 4,
		KnotReordered = 5
	}

	internal struct SplineModificationData // TypeDefIndex: 59077
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
		} // 0x0000000189CD56BC-0x0000000189CD56F4
	}

	[Obsolete("Replaced by GetTangentMode and SetTangentMode.")]
	public enum SplineType : byte // TypeDefIndex: 59078
	{
		CatmullRom = 0,
		Bezier = 1,
		Linear = 2
	}

	public static class SplineUtility // TypeDefIndex: 59080
	{
		// Nested types
		private struct Segment // TypeDefIndex: 59079
		{
			// Fields
			public float start; // 0x00
			public float length; // 0x04
	
			// Constructors
			public Segment(float start, float length) {
				this.start = default;
				this.length = default;
			} // 0x0000000183D50430-0x0000000183D50440
		}
	
		// Methods
		public static int GetSubdivisionCount(float length, int resolution) => default; // 0x0000000189CD5F7C-0x0000000189CD5FD4
		private static Segment GetNearestPoint<T>(T spline, float3 point, Segment range, out float distance, out float3 nearest, out float time, int segments)
			where T : ISpline {
			distance = default;
			nearest = default;
			time = default;
			return default;
		}
		public static float GetNearestPoint<T>(T spline, float3 point, out float3 nearest, out float t, int resolution = 4 /* Metadata: 0x01FDCD45 */, int iterations = 2 /* Metadata: 0x01FDCD46 */)
			where T : ISpline {
			nearest = default;
			t = default;
			return default;
		}
		internal static int PreviousIndex(int index, int count, bool wrap) => default; // 0x0000000189CD5FF0-0x0000000189CD600C
		internal static int NextIndex(int index, int count, bool wrap) => default; // 0x0000000189CD5FD4-0x0000000189CD5FF0
		internal static float3 GetExplicitLinearTangent(float3 point, float3 to) => default; // 0x0000000189CD5C58-0x0000000189CD5CDC
		public static float3 GetAutoSmoothTangent(float3 previous, float3 current, float3 next, float tension = 0.33333334f /* Metadata: 0x01FDCD47 */) => default; // 0x0000000189CD5940-0x0000000189CD5C58
		public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next, float3 normal, float width, float tension = 0.33333334f /* Metadata: 0x01FDCD4B */) => default; // 0x0000000189CD56F4-0x0000000189CD5940
		internal static quaternion GetKnotRotation(float3 tangent, float3 normal) => default; // 0x0000000189CD5CDC-0x0000000189CD5F7C
		internal static bool IsIndexValid<T>(T container, SplineKnotIndex index)
			where T : ISplineContainer => default;
	
		// Extension methods
		public static bool Evaluate<T>(this T spline, float t, out float3 position, out float3 tangent, out float3 upVector)
			where T : ISpline {
			position = default;
			tangent = default;
			upVector = default;
			return default;
		}
		public static float3 EvaluatePosition<T>(this T spline, float t)
			where T : ISpline => default;
		public static Vector3 EvaluatePositionV3<T>(this T spline, float t)
			where T : ISpline => default;
		public static float3 EvaluateTangent<T>(this T spline, float t)
			where T : ISpline => default;
		public static float3 EvaluateUpVector<T>(this T spline, float t)
			where T : ISpline => default;
		private static float3 EvaluateUpVector<T>(this T spline, int curveIndex, float curveT)
			where T : ISpline => default;
		public static float3 EvaluateAcceleration<T>(this T spline, float t)
			where T : ISpline => default;
		public static int SplineToCurveT<T>(this T spline, float splineT, out float curveT)
			where T : ISpline {
			curveT = default;
			return default;
		}
		private static int SplineToCurveT<T>(this T spline, float splineT, out float curveT, bool useLUT)
			where T : ISpline {
			curveT = default;
			return default;
		}
		public static float CalculateLength<T>(this T spline, float4x4 transform)
			where T : ISpline => default;
		public static int GetCurveCount<T>(this T spline)
			where T : ISpline => default;
		public static int PreviousIndex<T>(this T spline, int index)
			where T : ISpline => default;
		public static int NextIndex<T>(this T spline, int index)
			where T : ISpline => default;
		public static BezierKnot Previous<T>(this T spline, int index)
			where T : ISpline => default;
		public static BezierKnot Next<T>(this T spline, int index)
			where T : ISpline => default;
		public static void SetLinkedKnotPosition<T>(this T container, SplineKnotIndex index)
			where T : ISplineContainer {}
	}
}
