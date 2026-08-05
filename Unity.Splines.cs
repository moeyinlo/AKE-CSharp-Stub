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

// Image 85: Unity.Splines.dll - Assembly: Unity.Splines, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62684-62720
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
	internal static class ArrayUtility // TypeDefIndex: 62685
	{
		// Methods
		public static void RemoveAt<T>(ref ref T[] array, int index);
		public static void Remove<T>(ref ref T[] array, T element);
	}

	public struct BezierCurve : IEquatable<BezierCurve> // TypeDefIndex: 62686
	{
		// Fields
		public float3 P0; // 0x00
		public float3 P1; // 0x0C
		public float3 P2; // 0x18
		public float3 P3; // 0x24
	
		// Constructors
		public BezierCurve(float3 p0, float3 p1, float3 p2, float3 p3); // 0x0000000184DB65D0-0x0000000184DB6620
		public BezierCurve(BezierKnot a, BezierKnot b); // 0x0000000183C29DD0-0x0000000183C29F00
	
		// Methods
		public bool Equals(BezierCurve other); // 0x000000018B28C160-0x000000018B28C224
		public override bool Equals(object obj); // 0x000000018B2EE70C-0x000000018B2EE78C
		public override int GetHashCode(); // 0x000000018B2EE78C-0x000000018B2EE81C
	}

	[Serializable]
	public struct BezierKnot : ISerializationCallbackReceiver, IEquatable<BezierKnot> // TypeDefIndex: 62687
	{
		// Fields
		public float3 Position; // 0x00
		public float3 TangentIn; // 0x0C
		public float3 TangentOut; // 0x18
		public quaternion Rotation; // 0x24
		public float Width; // 0x34
	
		// Constructors
		public BezierKnot(float3 position); // 0x000000018B2EF15C-0x000000018B2EF1E4
		public BezierKnot(float3 position, float3 tangentIn, float3 tangentOut, quaternion rotation, float width = 1f /* Metadata: 0x0235210F */); // 0x0000000184DB9900-0x0000000184DB9950
	
		// Methods
		public BezierKnot Transform(float4x4 matrix); // 0x000000018B2EEED0-0x000000018B2EF15C
		internal BezierKnot BakeTangentDirectionToRotation(bool mirrored, BezierTangent main = BezierTangent.Out /* Metadata: 0x02352113 */); // 0x000000018B2EE81C-0x000000018B2EEB20
		public void OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		public void OnAfterDeserialize(); // 0x00000001845E25C0-0x00000001845E2620
		public override string ToString(); // 0x000000018B2EED44-0x000000018B2EEED0
		public bool Equals(BezierKnot other); // 0x000000018B2EEB20-0x000000018B2EEBF4
		public override bool Equals(object obj); // 0x000000018B2EEBF4-0x000000018B2EEC80
		public override int GetHashCode(); // 0x000000018B2EEC80-0x000000018B2EED44
	}

	public enum TangentMode // TypeDefIndex: 62688
	{
		AutoSmooth = 0,
		Linear = 1,
		Mirrored = 2,
		Continuous = 3,
		Broken = 4
	}

	public enum BezierTangent // TypeDefIndex: 62689
	{
		In = 0,
		Out = 1
	}

	public static class CurveUtility // TypeDefIndex: 62691
	{
		// Fields
		private static readonly DistanceToInterpolation[] k_DistanceLUT; // 0x00
	
		// Nested types
		private struct FrenetFrame // TypeDefIndex: 62690
		{
			// Fields
			public float3 origin; // 0x00
			public float3 tangent; // 0x0C
			public float3 normal; // 0x18
			public float3 binormal; // 0x24
		}
	
		// Constructors
		static CurveUtility(); // 0x0000000184D388A0-0x0000000184D38910
	
		// Methods
		public static float3 EvaluatePosition(BezierCurve curve, float t); // 0x00000001830E7670-0x00000001830E7A30
		public static float3 EvaluateTangent(BezierCurve curve, float t); // 0x0000000183280B50-0x0000000183280D60
		public static float3 EvaluateAcceleration(BezierCurve curve, float t); // 0x000000018B2EF244-0x000000018B2EF3C8
		public static void CalculateCurveLengths(BezierCurve curve, DistanceToInterpolation[] lookupTable); // 0x00000001834C8110-0x00000001834C83A0
		private static bool Approximately(float a, float b); // 0x000000018B2EF1E4-0x000000018B2EF244
		internal static float3 EvaluateUpVector(BezierCurve curve, float t, float3 startUp, float3 endUp); // 0x000000018B2EF3C8-0x000000018B2EFEB8
		private static FrenetFrame GetNextRotationMinimizingFrame(BezierCurve curve, FrenetFrame previousRMFrame, float nextRMFrameT); // 0x000000018B2EFEB8-0x000000018B2F0410
		public static float GetDistanceToInterpolation<T>(T lut, float distance)
			where T : IReadOnlyList<DistanceToInterpolation>;
	}

	public interface IDataPoint // TypeDefIndex: 62692
	{
		// Properties
		float Index { get; }
	}

	[Serializable]
	public struct DataPoint<TDataType> : IComparable<DataPoint<TDataType>>, IComparable<float>, IDataPoint // TypeDefIndex: 62693
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

	internal class DataPointComparer<T> : IComparer<T> // TypeDefIndex: 62694
		where T : IDataPoint
	{
		// Constructors
		public DataPointComparer();
	
		// Methods
		public int Compare(T x, T y);
	}

	[Serializable]
	public struct DistanceToInterpolation // TypeDefIndex: 62695
	{
		// Fields
		public float Distance; // 0x00
		public float T; // 0x04
		internal static readonly DistanceToInterpolation Invalid; // 0x00
	
		// Constructors
		static DistanceToInterpolation(); // 0x0000000184D758C0-0x0000000184D75900
	}

	public interface IHasEmptyCurves // TypeDefIndex: 62696
	{
		// Properties
		IReadOnlyList<int> EmptyCurves { get; }
	}

	public interface ISpline : IReadOnlyList<BezierKnot> // TypeDefIndex: 62697
	{
		// Properties
		bool Closed { get; }
	
		// Methods
		float GetLength();
		BezierCurve GetCurve(int index);
		float GetCurveLength(int index);
		float GetCurveInterpolation(int curveIndex, float curveDistance);
	}

	public interface ISplineContainer // TypeDefIndex: 62698
	{
		// Properties
		IReadOnlyList<Spline> Splines { get; }
		KnotLinkCollection KnotLinkCollection { get; }
	}

	[Serializable]
	public sealed class KnotLinkCollection // TypeDefIndex: 62700
	{
		// Fields
		[SerializeField]
		private KnotLink[] m_KnotsLink; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class KnotLink : IReadOnlyList<SplineKnotIndex> // TypeDefIndex: 62699
		{
			// Fields
			public SplineKnotIndex[] Knots; // 0x10
	
			// Properties
			public int Count { get; } // 0x00000001867B6CAC-0x00000001867B6CC8 
			public SplineKnotIndex this[int index] { get => default; } // 0x000000018B2F072C-0x000000018B2F0758 
	
			// Constructors
			public KnotLink(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public IEnumerator<SplineKnotIndex> GetEnumerator(); // 0x000000018B2F06E4-0x000000018B2F072C
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AFBA390-0x000000018AFBA3B0
		}
	
		// Constructors
		public KnotLinkCollection(); // 0x0000000183C2C120-0x0000000183C2C170
	
		// Methods
		private KnotLink GetKnotLinksInternal(SplineKnotIndex index); // 0x000000018B2F0410-0x000000018B2F04A8
		public bool TryGetKnotLinks(SplineKnotIndex knotIndex, out IReadOnlyList<SplineKnotIndex> linkedKnots); // 0x000000018B2F05FC-0x000000018B2F0628
		public void Unlink(SplineKnotIndex knot); // 0x000000018B2F0628-0x000000018B2F06E4
		public void KnotRemoved(int splineIndex, int knotIndex); // 0x000000018B2F04DC-0x000000018B2F04FC
		public void KnotRemoved(SplineKnotIndex index); // 0x000000018B2F04FC-0x000000018B2F0534
		public void KnotInserted(int splineIndex, int knotIndex); // 0x000000018B2F04A8-0x000000018B2F04CC
		public void KnotInserted(SplineKnotIndex index); // 0x000000018B2F04CC-0x000000018B2F04DC
		public void ShiftKnotIndices(SplineKnotIndex index, int offset); // 0x000000018B2F0534-0x000000018B2F05FC
	}

	public struct NativeSpline : ISpline, IDisposable // TypeDefIndex: 62702
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
		public bool Closed { get; } // 0x0000000184D865F0-0x0000000184D86600 
		public int Count { get; } // 0x0000000184D88B10-0x0000000184D88B20 
		public BezierKnot this[int index] { get => default; } // 0x0000000184D9F8A0-0x0000000184D9F8E0 
	
		// Nested types
		private struct Slice<T> : IReadOnlyList<T> // TypeDefIndex: 62701
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
		public NativeSpline(ISpline spline, float4x4 transform, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0235211B */); // 0x000000018B2F0F90-0x000000018B2F107C
		public NativeSpline(IReadOnlyList<BezierKnot> knots, IReadOnlyList<int> splits, bool closed, float4x4 transform, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Temp /* Metadata: 0x0235211C */); // 0x000000018B2F0964-0x000000018B2F0F90
	
		// Methods
		public float GetLength(); // 0x0000000184D8E050-0x0000000184D8E060
		public IEnumerator<BezierKnot> GetEnumerator(); // 0x000000018B2F08C0-0x000000018B2F095C
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B2F095C-0x000000018B2F0964
		public BezierCurve GetCurve(int index); // 0x0000000184DB9970-0x0000000184DB99A0
		public float GetCurveLength(int curveIndex); // 0x0000000184DB9950-0x0000000184DB9970
		public void Dispose(); // 0x000000018B2F0758-0x000000018B2F07CC
		public float GetCurveInterpolation(int curveIndex, float curveDistance); // 0x000000018B2F07CC-0x000000018B2F08C0
	}

	[Serializable]
	public class Spline : ISpline, IList<BezierKnot> // TypeDefIndex: 62705
	{
		// Fields
		private const TangentMode k_DefaultTangentMode = TangentMode.Broken; // Metadata: 0x02352122
		private const BezierTangent k_DefaultMainTangent = BezierTangent.Out; // Metadata: 0x02352123
		private const int k_BatchModification = -1; // Metadata: 0x02352124
		private const int k_CurveDistanceLutResolution = 30; // Metadata: 0x02352125
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
		private IEnumerable<ISplineModificationHandler> embeddedSplineData { [IteratorStateMachine(typeof(_get_embeddedSplineData_d__15))] get; } // 0x000000018B2F423C-0x000000018B2F42AC 
		public int Count { get; } // 0x0000000183157740-0x0000000183157780 
		public bool IsReadOnly { get; } // 0x00000001812081B0-0x0000000181208610 
		public IEnumerable<BezierKnot> Knots { get; } // 0x000000018385B100-0x000000018385B110 
		public bool Closed { get; set; } // 0x0000000184D865F0-0x0000000184D86600 0x0000000183159990-0x00000001831599B0
		public BezierKnot this[int index] { get => default; set {} } // 0x0000000183EFD750-0x0000000183EFD7F0 0x000000018B2F42AC-0x000000018B2F42F8
	
		// Events
		public static event Action<Spline, int, SplineModification> Changed {
			add; // 0x00000001847C3C10-0x00000001847C3CC0
			remove; // 0x00000001847C3CC0-0x00000001847C3D70
		}
	
		// Nested types
		[Serializable]
		private sealed class MetaData // TypeDefIndex: 62703
		{
			// Fields
			public TangentMode Mode; // 0x10
			public float Tension; // 0x14
			[FormerlySerializedAs("DistanceToInterpolation")]
			[SerializeField]
			private DistanceToInterpolation[] m_DistanceToInterpolation; // 0x18
	
			// Properties
			public DistanceToInterpolation[] DistanceToInterpolation { get; } // 0x0000000183155AD0-0x0000000183155B20 
	
			// Constructors
			public MetaData(); // 0x00000001831575E0-0x0000000183157650
	
			// Methods
			public void InvalidateCache(); // 0x0000000183157550-0x00000001831575E0
		}
	
		[CompilerGenerated]
		private sealed class _get_embeddedSplineData_d__15 : IEnumerable<ISplineModificationHandler>, IEnumerator<ISplineModificationHandler> // TypeDefIndex: 62704
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
			ISplineModificationHandler IEnumerator<UnityEngine.Splines.ISplineModificationHandler>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _get_embeddedSplineData_d__15(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B2F4C7C-0x000000018B2F4E4C
			private bool MoveNext(); // 0x000000018B2F4350-0x000000018B2F4B9C
			private void __m__Finally1(); // 0x000000018B2F4E4C-0x000000018B2F4E94
			private void __m__Finally2(); // 0x000000018B2F4E94-0x000000018B2F4EDC
			private void __m__Finally3(); // 0x000000018B2F4EDC-0x000000018B2F4F24
			private void __m__Finally4(); // 0x000000018B2F4F24-0x000000018B2F4F6C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B2F4C30-0x000000018B2F4C7C
			[DebuggerHidden]
			IEnumerator<ISplineModificationHandler> IEnumerable<ISplineModificationHandler>.GetEnumerator(); // 0x000000018B2F4B9C-0x000000018B2F4C28
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B2F4C28-0x000000018B2F4C30
		}
	
		// Constructors
		public Spline(); // 0x0000000183C2A7A0-0x0000000183C2A9B0
		public Spline(IEnumerable<BezierKnot> knots, bool closed = false /* Metadata: 0x02352121 */); // 0x0000000183C2A4D0-0x0000000183C2A720
	
		// Methods
		internal void SetDirtyNoNotify(); // 0x000000018B2F3BF4-0x000000018B2F3C94
		internal void SetDirty(SplineModification modificationEvent, int knotIndex = -1 /* Metadata: 0x0235211D */); // 0x000000018B2F3C94-0x000000018B2F3FAC
		protected virtual void OnSplineChanged(); // 0x00000001841E1670-0x00000001841E1680
		private void EnsureMetaDataValid(); // 0x0000000183155B20-0x0000000183155C20
		public TangentMode GetTangentMode(int index); // 0x000000018B2F3710-0x000000018B2F3778
		private void ApplyTangentModeNoNotify(int index, BezierTangent main = BezierTangent.Out /* Metadata: 0x0235211E */); // 0x000000018B2F3190-0x000000018B2F348C
		public int IndexOf(BezierKnot item); // 0x000000018B2F3778-0x000000018B2F37F4
		public void Insert(int index, BezierKnot knot); // 0x000000018B2F39EC-0x000000018B2F3A44
		public void Insert(int index, BezierKnot knot, TangentMode mode); // 0x000000018B2F399C-0x000000018B2F39EC
		public void Insert(int index, BezierKnot knot, TangentMode mode, float tension); // 0x000000018B2F37F4-0x000000018B2F399C
		public void RemoveAt(int index); // 0x000000018B2F3A44-0x000000018B2F3B60
		public void SetKnot(int index, BezierKnot value, BezierTangent main = BezierTangent.Out /* Metadata: 0x0235211F */); // 0x000000018B2F4108-0x000000018B2F4194
		public void SetKnotNoNotify(int index, BezierKnot value, BezierTangent main = BezierTangent.Out /* Metadata: 0x02352120 */); // 0x000000018B2F3FAC-0x000000018B2F4108
		public BezierCurve GetCurve(int index); // 0x0000000183C29BF0-0x0000000183C29DD0
		public float GetCurveLength(int index); // 0x0000000183155900-0x0000000183155AD0
		public float GetLength(); // 0x0000000183155C20-0x0000000183155CB0
		private DistanceToInterpolation[] GetCurveDistanceLut(int index); // 0x0000000183155820-0x0000000183155900
		public float GetCurveInterpolation(int curveIndex, float curveDistance); // 0x00000001831555B0-0x0000000183155640
		public IEnumerator<BezierKnot> GetEnumerator(); // 0x000000018B2F3668-0x000000018B2F3710
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B2F4194-0x000000018B2F423C
		public void Add(BezierKnot item); // 0x000000018B2F30DC-0x000000018B2F3120
		public void Add(BezierKnot item, TangentMode mode); // 0x000000018B2F3120-0x000000018B2F3190
		public void Clear(); // 0x000000018B2F3514-0x000000018B2F3588
		public bool Contains(BezierKnot item); // 0x000000018B2F3588-0x000000018B2F3604
		public void CopyTo(BezierKnot[] array, int arrayIndex); // 0x000000018B2F3604-0x000000018B2F3668
		public bool Remove(BezierKnot item); // 0x000000018B2F3B60-0x000000018B2F3BF4
		internal void CacheKnotOperationCurves(int index); // 0x000000018B2F348C-0x000000018B2F3514
	}

	[AddComponentMenu("Splines/Spline")]
	[ExecuteInEditMode]
	public class SplineContainer : MonoBehaviour, ISplineContainer, ISerializationCallbackReceiver // TypeDefIndex: 62707
	{
		// Fields
		private const string k_IconPath = "Packages/com.unity.splines/Editor/Resources/Icons/SplineComponent.png"; // Metadata: 0x02352126
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
		public IReadOnlyList<Spline> Splines { get; set; } // 0x000000018B2F1B24-0x000000018B2F1B98 0x000000018B2F1DC4-0x000000018B2F24AC
		public KnotLinkCollection KnotLinkCollection { get; } // 0x0000000184D86240-0x0000000184D86250 
		public Spline this[int index] { get => default; } // 0x000000018B2F1AC4-0x000000018B2F1AF0 
		private bool IsScaled { get; } // 0x000000018B2F1A34-0x000000018B2F1AC4 
		public Spline Spline { get; set; } // 0x000000018B2F1AF0-0x000000018B2F1B24 0x000000018B2F1D7C-0x000000018B2F1DC4
	
		// Events
		public static event Action<SplineContainer, int> SplineAdded {
			add; // 0x000000018B2F1850-0x000000018B2F18EC
			remove; // 0x000000018B2F1B98-0x000000018B2F1C34
		}
		public static event Action<SplineContainer, int> SplineRemoved {
			add; // 0x000000018B2F18EC-0x000000018B2F1990
			remove; // 0x000000018B2F1C34-0x000000018B2F1CD8
		}
		public static event Action<SplineContainer, int, int> SplineReordered {
			add; // 0x000000018B2F1990-0x000000018B2F1A34
			remove; // 0x000000018B2F1CD8-0x000000018B2F1D7C
		}
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 62706
		{
			// Fields
			public IReadOnlyList<Spline> value; // 0x10
			public int i; // 0x18
			public Predicate<Spline> __9__0; // 0x20
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _set_Splines_b__0(Spline spline); // 0x000000018B2F42F8-0x000000018B2F4350
		}
	
		// Constructors
		public SplineContainer(); // 0x0000000183C2BF40-0x0000000183C2C120
	
		// Methods
		private static int IndexOf(IReadOnlyList<Spline> self, Spline elementToFind); // 0x000000018B2F1664-0x000000018B2F16F0
		private void OnEnable(); // 0x00000001847C3B10-0x00000001847C3B90
		private void OnDisable(); // 0x00000001847C3B90-0x00000001847C3C10
		private void OnSplineChanged(Spline spline, int index, SplineModification modificationType); // 0x000000018B2F1774-0x000000018B2F1850
		private void OnKnotModified(Spline spline, int index); // 0x000000018B2F16F0-0x000000018B2F1774
		public bool Evaluate(float t, out float3 position, out float3 tangent, out float3 upVector); // 0x000000018B2F1598-0x000000018B2F15C8
		public bool Evaluate(int splineIndex, float t, out float3 position, out float3 tangent, out float3 upVector); // 0x000000018B2F15C8-0x000000018B2F1664
		public bool Evaluate<T>(T spline, float t, out float3 position, out float3 tangent, out float3 upVector)
			where T : ISpline;
		public float3 EvaluatePosition(float t); // 0x000000018B2F12D4-0x000000018B2F1310
		public Vector3 EvaluatePositionV3(float t); // 0x000000018B2F1278-0x000000018B2F12D4
		public float3 EvaluatePosition(int splineIndex, float t); // 0x000000018B2F1310-0x000000018B2F13C0
		public float3 EvaluatePosition<T>(T spline, float t)
			where T : ISpline;
		public float3 EvaluateTangent(float t); // 0x000000018B2F1470-0x000000018B2F14AC
		public float3 EvaluateTangent(int splineIndex, float t); // 0x000000018B2F13C0-0x000000018B2F1470
		public float3 EvaluateTangent<T>(T spline, float t)
			where T : ISpline;
		public float3 EvaluateUpVector(float t); // 0x000000018B2F155C-0x000000018B2F1598
		public float3 EvaluateUpVector(int splineIndex, float t); // 0x000000018B2F14AC-0x000000018B2F155C
		public float3 EvaluateUpVector<T>(T spline, float t)
			where T : ISpline;
		public float3 EvaluateAcceleration(float t); // 0x000000018B2F123C-0x000000018B2F1278
		public float3 EvaluateAcceleration(int splineIndex, float t); // 0x000000018B2F118C-0x000000018B2F123C
		public float3 EvaluateAcceleration<T>(T spline, float t)
			where T : ISpline;
		public float CalculateLength(); // 0x000000018B2F1180-0x000000018B2F118C
		public float CalculateLength(int splineIndex); // 0x000000018B2F107C-0x000000018B2F1180
		public void OnBeforeSerialize(); // 0x00000001841E1670-0x00000001841E1680
		public void OnAfterDeserialize(); // 0x0000000183157F60-0x0000000183157FC0
	}

	public enum PathIndexUnit // TypeDefIndex: 62708
	{
		Distance = 0,
		Normalized = 1,
		Knot = 2
	}

	internal interface ISplineModificationHandler // TypeDefIndex: 62709
	{
		// Methods
		void OnSplineModified(SplineModificationData info);
	}

	[Serializable]
	[DefaultMember("Item")]
	public class SplineData<T> : IEnumerable<DataPoint<T>>, ISplineModificationHandler // TypeDefIndex: 62711
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
		private sealed class _GetEnumerator_d__46 : IEnumerator<DataPoint<T>> // TypeDefIndex: 62710
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
	internal class SplineDataKeyValuePair<T> // TypeDefIndex: 62712
	{
		// Fields
		public string Key;
		public SplineData<T> Value;
	
		// Constructors
		public SplineDataKeyValuePair();
	}

	[Serializable]
	[DefaultMember("Item")]
	internal class SplineDataDictionary<T> : IEnumerable<SplineDataKeyValuePair<T>> // TypeDefIndex: 62713
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
	public struct SplineKnotIndex : IEquatable<SplineKnotIndex> // TypeDefIndex: 62714
	{
		// Fields
		public int Spline; // 0x00
		public int Knot; // 0x04
	
		// Constructors
		public SplineKnotIndex(int spline, int knot); // 0x0000000184D85C40-0x0000000184D85C50
	
		// Methods
		public bool Equals(SplineKnotIndex otherIndex); // 0x00000001863516B4-0x00000001863516C8
		public override bool Equals(object obj); // 0x000000018B2F24AC-0x000000018B2F2510
		public override int GetHashCode(); // 0x0000000184DB99A0-0x0000000184DB99B0
		public override string ToString(); // 0x000000018B2F2510-0x000000018B2F2598
	}

	public static class SplineMath // TypeDefIndex: 62715
	{
		// Methods
		public static float3 PointLineNearestPoint(float3 p, float3 a, float3 b, out float lineParam); // 0x000000018B2F2598-0x000000018B2F274C
	}

	public enum SplineModification // TypeDefIndex: 62716
	{
		Default = 0,
		ClosedModified = 1,
		KnotModified = 2,
		KnotInserted = 3,
		KnotRemoved = 4,
		KnotReordered = 5
	}

	internal struct SplineModificationData // TypeDefIndex: 62717
	{
		// Fields
		public readonly Spline Spline; // 0x00
		public readonly SplineModification Modification; // 0x08
		public readonly int KnotIndex; // 0x0C
		public readonly float PrevCurveLength; // 0x10
		public readonly float NextCurveLength; // 0x14
	
		// Constructors
		public SplineModificationData(Spline spline, SplineModification modification, int knotIndex, float prevCurveLength, float nextCurveLength); // 0x000000018B2F274C-0x000000018B2F2784
	}

	[Obsolete("Replaced by GetTangentMode and SetTangentMode.")]
	public enum SplineType : byte // TypeDefIndex: 62718
	{
		CatmullRom = 0,
		Bezier = 1,
		Linear = 2
	}

	public static class SplineUtility // TypeDefIndex: 62720
	{
		// Nested types
		private struct Segment // TypeDefIndex: 62719
		{
			// Fields
			public float start; // 0x00
			public float length; // 0x04
	
			// Constructors
			public Segment(float start, float length); // 0x0000000184D87A10-0x0000000184D87A20
		}
	
		// Methods
		public static int GetSubdivisionCount(float length, int resolution); // 0x000000018B2F304C-0x000000018B2F30A4
		private static Segment GetNearestPoint<T>(T spline, float3 point, Segment range, out float distance, out float3 nearest, out float time, int segments)
			where T : ISpline;
		public static float GetNearestPoint<T>(T spline, float3 point, out float3 nearest, out float t, int resolution = 4 /* Metadata: 0x02352179 */, int iterations = 2 /* Metadata: 0x0235217A */)
			where T : ISpline;
		internal static int PreviousIndex(int index, int count, bool wrap); // 0x000000018B2F30C0-0x000000018B2F30DC
		internal static int NextIndex(int index, int count, bool wrap); // 0x000000018B2F30A4-0x000000018B2F30C0
		internal static float3 GetExplicitLinearTangent(float3 point, float3 to); // 0x000000018B2F2CE8-0x000000018B2F2D6C
		public static float3 GetAutoSmoothTangent(float3 previous, float3 current, float3 next, float tension = 0.33333334f /* Metadata: 0x0235217B */); // 0x000000018B2F29D0-0x000000018B2F2CE8
		public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next, float3 normal, float width, float tension = 0.33333334f /* Metadata: 0x0235217F */); // 0x000000018B2F2784-0x000000018B2F29D0
		internal static quaternion GetKnotRotation(float3 tangent, float3 normal); // 0x000000018B2F2D6C-0x000000018B2F304C
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
