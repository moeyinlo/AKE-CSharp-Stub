/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 37: DestMath.dll - Assembly: DestMath, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58460-58611
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 58611
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_20 _170A8789272DFBCBA0E6B7D2530CAA16D9199834934F442421DAB41C5EEA8C29; // 0x00 // Static value (base64): 9pxyPtEO9T60ohE/0Q71Pvaccj4= - Metadata: 0x0234BE1C
	internal static readonly __StaticArrayInitTypeSize_20 _92052E6D9D3C30FD20B710DFB226BEEA15F69C2188B5AA373563D6966493C59C; // 0x14 // Static value (base64): Z/tnvyDZCb8AAAAAINkJP2f7Zz8= - Metadata: 0x0234BE34

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 58610
	{
	}
}

namespace Dest.Math
{
	public class Polynomial // TypeDefIndex: 58461
	{
		// Fields
		private int _degree; // 0x10
		private float[] _coeffs; // 0x18
	
		// Properties
		public int Degree { get; set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x0000000186920178-0x00000001869201CC
		public float this[int index] { get => default; set {} } // 0x0000000186920148-0x0000000186920178 0x00000001869201CC-0x00000001869201FC
	
		// Constructors
		public Polynomial(int degree); // 0x0000000186920140-0x0000000186920148
	
		// Methods
		public Polynomial DeepCopy(); // 0x000000018692003C-0x00000001869200EC
		public Polynomial CalcDerivative(); // 0x000000018691FDB8-0x000000018691FEBC
		public Polynomial CalcInversion(); // 0x000000018691FEBC-0x000000018691FF70
		public void Compress(float epsilon = 1E-05f /* Metadata: 0x0234BC70 */); // 0x000000018691FF70-0x000000018692003C
		public float Eval(float t); // 0x00000001869200EC-0x0000000186920140
	}

	public static class Approximation // TypeDefIndex: 58462
	{
		// Methods
		public static Box2 GaussPointsFit2(IList<Vector2> points); // 0x00000001869126D0-0x0000000186912A7C
		internal static bool HeightLineFit2(IList<Vector2> points, out float a, out float b); // 0x0000000186912F60-0x0000000186913230
		public static Line2 LeastSquaresLineFit2(IList<Vector2> points); // 0x00000001869136C8-0x00000001869139B4
		public static Box3 GaussPointsFit3(IList<Vector3> points); // 0x0000000186912A7C-0x0000000186912F60
		public static Line3 LeastsSquaresLineFit3(IList<Vector3> points); // 0x0000000186913D70-0x00000001869141A4
		internal static bool HeightPlaneFit3(IList<Vector3> points, out float a, out float b, out float c); // 0x0000000186913230-0x00000001869136C8
		public static Plane3 LeastSquaresPlaneFit3(IList<Vector3> points); // 0x00000001869139B4-0x0000000186913D70
	}

	internal class ConcaveHull2 // TypeDefIndex: 58465
	{
		// Nested types
		private struct Edge // TypeDefIndex: 58463
		{
			// Fields
			public int V0; // 0x00
			public int V1; // 0x04
	
			// Constructors
			public Edge(int v0, int v1); // 0x0000000184D85C40-0x0000000184D85C50
		}
	
		private struct InnerPoint // TypeDefIndex: 58464
		{
			// Fields
			public float AverageDistance; // 0x00
			public float Distance0; // 0x04
			public float Distance1; // 0x08
			public int Index; // 0x0C
		}
	
		// Constructors
		public ConcaveHull2(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private static bool _TryFastSort(InnerPoint[] x, int first, int last); // 0x0000000186914F30-0x0000000186915004
		private static void Quicksort(InnerPoint[] x, int first, int last); // 0x0000000186914D8C-0x0000000186914F30
		private static float CalcDistanceFromPointToEdge(ref Vector2 pointA, ref Vector2 v0, ref Vector2 v1); // 0x00000001869141A4-0x00000001869142B4
		public static bool Create(Vector2[] points, out int[] concaveHull, int[] convexHull, float N, float epsilon = 1E-05f /* Metadata: 0x0234BC74 */); // 0x00000001869142B4-0x0000000186914D8C
	}

	public static class ConcaveHull // TypeDefIndex: 58466
	{
		// Methods
		public static bool Create2D(Vector2[] points, out int[] concaveHull, out int[] convexHull, float algorithmThreshold, float epsilon = 1E-05f /* Metadata: 0x0234BC78 */); // 0x000000018691502C-0x0000000186915178
		public static bool Create2D(Vector2[] points, out int[] concaveHull, float algorithmThreshold, float epsilon = 1E-05f /* Metadata: 0x0234BC7C */); // 0x0000000186915004-0x000000018691502C
	}

	internal class ConvexHull1 // TypeDefIndex: 58469
	{
		// Nested types
		private class SortedVertex // TypeDefIndex: 58467
		{
			// Fields
			public float Value; // 0x10
			public int Index; // 0x14
	
			// Constructors
			public SortedVertex(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 58468
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<SortedVertex> __9__1_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000186920418-0x000000018692047C
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal int _Create_b__1_0(SortedVertex e1, SortedVertex e2); // 0x00000001869203AC-0x0000000186920418
		}
	
		// Constructors
		public ConvexHull1(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void Create(float[] vertices, float epsilon, out int dimension, out int[] indices); // 0x0000000186915178-0x0000000186915430
	}

	internal class ConvexHull2 // TypeDefIndex: 58471
	{
		// Nested types
		private class Edge // TypeDefIndex: 58470
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public Edge E0; // 0x18
			public Edge E1; // 0x20
			public int Sign; // 0x28
			public int Time; // 0x2C
	
			// Constructors
			public Edge(int v0, int v1); // 0x0000000184D898B0-0x0000000184D898C0
	
			// Methods
			public int GetSign(int i, Query2 query); // 0x000000018691FD1C-0x000000018691FD60
			public void Insert(Edge adj0, Edge adj1); // 0x000000018691FD60-0x000000018691FDB8
			public void DeleteSelf(); // 0x000000018691FC38-0x000000018691FC78
			public void GetIndices(out int[] indices); // 0x000000018691FC78-0x000000018691FD1C
		}
	
		// Constructors
		public ConvexHull2(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool Create(IList<Vector2> vertices, float epsilon, out int dimension, out int[] indices); // 0x0000000186915430-0x00000001869158E4
		private static bool Update(ref Edge hull, int i, Query2 query); // 0x00000001869158E4-0x0000000186915ABC
	}

	internal class ConvexHull3 // TypeDefIndex: 58474
	{
		// Nested types
		private class Triangle // TypeDefIndex: 58472
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public int V2; // 0x18
			public Triangle Adj0; // 0x20
			public Triangle Adj1; // 0x28
			public Triangle Adj2; // 0x30
			public int Sign; // 0x38
			public int Time; // 0x3C
			public bool OnStack; // 0x40
	
			// Constructors
			public Triangle(int v0, int v1, int v2); // 0x0000000184D898C0-0x0000000184D898E0
	
			// Methods
			public Triangle GetAdj(int index); // 0x0000000186920304-0x000000018692031C
			public void SetAdj(int index, Triangle value); // 0x000000018692037C-0x00000001869203AC
			public int GetV(int index); // 0x0000000186920364-0x000000018692037C
			public int GetSign(int i, Query3 query); // 0x000000018692031C-0x0000000186920364
			public void AttachTo(Triangle adj0, Triangle adj1, Triangle adj2); // 0x0000000186920230-0x0000000186920268
			public int DetachFrom(int adjIndex, Triangle adj); // 0x0000000186920268-0x0000000186920304
		}
	
		private class TerminatorData // TypeDefIndex: 58473
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public int NullIndex; // 0x18
			public Triangle T; // 0x20
	
			// Constructors
			public TerminatorData(int v0 = -1 /* Metadata: 0x0234BC80 */, int v1 = -1 /* Metadata: 0x0234BC81 */, int nullIndex = -1 /* Metadata: 0x0234BC82 */, Triangle tri = null); // 0x00000001869201FC-0x0000000186920230
		}
	
		// Constructors
		public ConvexHull3(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool Create(IList<Vector3> vertices, float epsilon, out int dimension, out int[] indices); // 0x0000000186915ABC-0x00000001869162B0
		private static bool Update(HashSet<Triangle> hull, int i, Query3 query); // 0x00000001869164C8-0x0000000186916D60
		private static void ExtractIndices(HashSet<Triangle> hull, out int[] indices); // 0x00000001869162B0-0x00000001869164C8
	}

	public static class ConvexHull // TypeDefIndex: 58475
	{
		// Methods
		public static bool Create2D(IList<Vector2> points, out int[] indices, out int dimension, float epsilon = 1E-05f /* Metadata: 0x0234BC83 */); // 0x0000000186916D60-0x0000000186916E00
		public static bool Create3D(IList<Vector3> points, out int[] indices, out int dimension, float epsilon = 1E-05f /* Metadata: 0x0234BC87 */); // 0x0000000186916E00-0x0000000186916EA0
	}

	public static class Distance // TypeDefIndex: 58476
	{
		// Methods
		public static float Line2Line2(ref Line2 line0, ref Line2 line1); // 0x000000018691853C-0x0000000186918564
		public static float Line2Line2(ref Line2 line0, ref Line2 line1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000186918564-0x0000000186918594
		public static float SqrLine2Line2(ref Line2 line0, ref Line2 line1); // 0x000000018691982C-0x0000000186919944
		public static float SqrLine2Line2(ref Line2 line0, ref Line2 line1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000186919944-0x0000000186919B70
		public static float Line2Ray2(ref Line2 line, ref Ray2 ray); // 0x0000000186918594-0x00000001869185BC
		public static float Line2Ray2(ref Line2 line, ref Ray2 ray, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x00000001869185BC-0x00000001869185EC
		public static float SqrLine2Ray2(ref Line2 line, ref Ray2 ray); // 0x0000000186919B70-0x0000000186919CFC
		public static float SqrLine2Ray2(ref Line2 line, ref Ray2 ray, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000186919CFC-0x0000000186919F58
		public static float Line2Segment2(ref Line2 line, ref Segment2 segment); // 0x000000018691861C-0x0000000186918644
		public static float Line2Segment2(ref Line2 line, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x00000001869185EC-0x000000018691861C
		public static float SqrLine2Segment2(ref Line2 line, ref Segment2 segment); // 0x0000000186919F58-0x000000018691A188
		public static float SqrLine2Segment2(ref Line2 line, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x000000018691A188-0x000000018691A458
		public static float Point2AAB2(ref Vector2 point, ref AAB2 box); // 0x0000000186918894-0x0000000186918908
		public static float Point2AAB2(ref Vector2 point, ref AAB2 box, out Vector2 closestPoint); // 0x00000001869187D8-0x0000000186918894
		public static float SqrPoint2AAB2(ref Vector2 point, ref AAB2 box); // 0x000000018691B530-0x000000018691B5A0
		public static float SqrPoint2AAB2(ref Vector2 point, ref AAB2 box, out Vector2 closestPoint); // 0x000000018691B5A0-0x000000018691B658
		public static float Point2Box2(ref Vector2 point, ref Box2 box); // 0x0000000186918930-0x0000000186918958
		public static float Point2Box2(ref Vector2 point, ref Box2 box, out Vector2 closestPoint); // 0x0000000186918908-0x0000000186918930
		public static float SqrPoint2Box2(ref Vector2 point, ref Box2 box); // 0x000000018691B658-0x000000018691B770
		public static float SqrPoint2Box2(ref Vector2 point, ref Box2 box, out Vector2 closestPoint); // 0x000000018691B770-0x000000018691B930
		public static float Point2Circle2(ref Vector2 point, ref Circle2 circle); // 0x0000000186918A08-0x0000000186918A44
		public static float Point2Circle2(ref Vector2 point, ref Circle2 circle, out Vector2 closestPoint); // 0x0000000186918958-0x0000000186918A08
		public static float SqrPoint2Circle2(ref Vector2 point, ref Circle2 circle); // 0x000000018691B9E4-0x000000018691BA24
		public static float SqrPoint2Circle2(ref Vector2 point, ref Circle2 circle, out Vector2 closestPoint); // 0x000000018691B930-0x000000018691B9E4
		public static float Point2Line2(ref Vector2 point, ref Line2 line); // 0x0000000186918A6C-0x0000000186918A94
		public static float Point2Line2(ref Vector2 point, ref Line2 line, out Vector2 closestPoint); // 0x0000000186918A44-0x0000000186918A6C
		public static float SqrPoint2Line2(ref Vector2 point, ref Line2 line); // 0x000000018691BB08-0x000000018691BBDC
		public static float SqrPoint2Line2(ref Vector2 point, ref Line2 line, out Vector2 closestPoint); // 0x000000018691BA24-0x000000018691BB08
		public static float Point2Ray2(ref Vector2 point, ref Ray2 ray); // 0x0000000186918A94-0x0000000186918ABC
		public static float Point2Ray2(ref Vector2 point, ref Ray2 ray, out Vector2 closestPoint); // 0x0000000186918ABC-0x0000000186918AE4
		public static float SqrPoint2Ray2(ref Vector2 point, ref Ray2 ray); // 0x000000018691BCE8-0x000000018691BDD4
		public static float SqrPoint2Ray2(ref Vector2 point, ref Ray2 ray, out Vector2 closestPoint); // 0x000000018691BBDC-0x000000018691BCE8
		public static float Point2Segment2(ref Vector2 point, ref Segment2 segment); // 0x0000000186918AE4-0x0000000186918B0C
		public static float Point2Segment2(ref Vector2 point, ref Segment2 segment, out Vector2 closestPoint); // 0x0000000186918B0C-0x0000000186918B34
		public static float SqrPoint2Segment2(ref Vector2 point, ref Segment2 segment); // 0x000000018691BF08-0x000000018691C030
		public static float SqrPoint2Segment2(ref Vector2 point, ref Segment2 segment, out Vector2 closestPoint); // 0x000000018691BDD4-0x000000018691BF08
		public static float Point2Triangle2(ref Vector2 point, ref Triangle2 triangle); // 0x0000000186918B34-0x0000000186918C9C
		public static float Point2Triangle2(ref Vector2 point, ref Triangle2 triangle, out Vector2 closestPoint); // 0x0000000186918C9C-0x0000000186918E54
		public static float SqrPoint2Triangle2(ref Vector2 point, ref Triangle2 triangle); // 0x000000018691C030-0x000000018691C198
		public static float SqrPoint2Triangle2(ref Vector2 point, ref Triangle2 triangle, out Vector2 closestPoint); // 0x000000018691C198-0x000000018691C350
		public static float Ray2Ray2(ref Ray2 ray0, ref Ray2 ray1); // 0x000000018691957C-0x00000001869195BC
		public static float Ray2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x000000018691954C-0x000000018691957C
		public static float SqrRay2Ray2(ref Ray2 ray0, ref Ray2 ray1); // 0x000000018691E1F8-0x000000018691E224
		public static float SqrRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x000000018691DF08-0x000000018691E1F8
		public static float Ray2Segment2(ref Ray2 ray, ref Segment2 segment); // 0x00000001869195BC-0x00000001869195FC
		public static float Ray2Segment2(ref Ray2 ray, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x00000001869195FC-0x000000018691962C
		public static float SqrRay2Segment2(ref Ray2 ray, ref Segment2 segment); // 0x000000018691E588-0x000000018691E5B4
		public static float SqrRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x000000018691E224-0x000000018691E588
		public static float Segment2Segment2(ref Segment2 segment0, ref Segment2 segment1); // 0x0000000186919724-0x0000000186919764
		public static float Segment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x00000001869196F4-0x0000000186919724
		public static float SqrSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1); // 0x000000018691EE94-0x000000018691EEC0
		public static float SqrSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x000000018691EEC0-0x000000018691F444
		private static void Face(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref Vector3 PmE, ref float sqrDistance); // 0x0000000186917710-0x000000018691853C
		private static void CaseNoZeros(ref Box3 mBox, ref float mLineParameter, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance); // 0x0000000186917630-0x0000000186917710
		private static void Case0(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance); // 0x00000001869171CC-0x0000000186917630
		private static void Case00(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance); // 0x0000000186916FBC-0x00000001869171CC
		private static void Case000(ref Box3 mBox, ref float mLineParameter, ref Vector3 pnt, ref float sqrDistance); // 0x0000000186916EA0-0x0000000186916FBC
		public static float Line3Box3(ref Line3 line, ref Box3 box, out Line3Box3Dist info); // 0x0000000186918644-0x000000018691866C
		public static float Line3Box3(ref Line3 line, ref Box3 box); // 0x000000018691866C-0x00000001869186AC
		public static float SqrLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Dist info); // 0x000000018691A458-0x000000018691AA10
		public static float SqrLine3Box3(ref Line3 line, ref Box3 box); // 0x000000018691AA10-0x000000018691AA3C
		public static float Line3Line3(ref Line3 line0, ref Line3 line1); // 0x00000001869186AC-0x00000001869186E0
		public static float Line3Line3(ref Line3 line0, ref Line3 line1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x00000001869186E0-0x0000000186918710
		public static float SqrLine3Line3(ref Line3 line0, ref Line3 line1); // 0x000000018691AA3C-0x000000018691AA70
		public static float SqrLine3Line3(ref Line3 line0, ref Line3 line1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x000000018691AA70-0x000000018691ADC0
		public static float Line3Ray3(ref Line3 line, ref Ray3 ray); // 0x0000000186918710-0x0000000186918744
		public static float Line3Ray3(ref Line3 line, ref Ray3 ray, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000186918744-0x0000000186918774
		public static float SqrLine3Ray3(ref Line3 line, ref Ray3 ray); // 0x000000018691B100-0x000000018691B134
		public static float SqrLine3Ray3(ref Line3 line, ref Ray3 ray, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x000000018691ADC0-0x000000018691B100
		public static float Line3Segment3(ref Line3 line, ref Segment3 segment); // 0x0000000186918774-0x00000001869187A8
		public static float Line3Segment3(ref Line3 line, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x00000001869187A8-0x00000001869187D8
		public static float SqrLine3Segment3(ref Line3 line, ref Segment3 segment); // 0x000000018691B134-0x000000018691B168
		public static float SqrLine3Segment3(ref Line3 line, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x000000018691B168-0x000000018691B530
		public static float Point3AAB3(ref Vector3 point, ref AAB3 box); // 0x0000000186918E54-0x0000000186918EF8
		public static float Point3AAB3(ref Vector3 point, ref AAB3 box, out Vector3 closestPoint); // 0x0000000186918EF8-0x0000000186919008
		public static float SqrPoint3AAB3(ref Vector3 point, ref AAB3 box); // 0x000000018691C45C-0x000000018691C4FC
		public static float SqrPoint3AAB3(ref Vector3 point, ref AAB3 box, out Vector3 closestPoint); // 0x000000018691C350-0x000000018691C45C
		public static float Point3Box3(ref Vector3 point, ref Box3 box); // 0x0000000186919030-0x0000000186919058
		public static float Point3Box3(ref Vector3 point, ref Box3 box, out Vector3 closestPoint); // 0x0000000186919008-0x0000000186919030
		public static float SqrPoint3Box3(ref Vector3 point, ref Box3 box); // 0x000000018691C4FC-0x000000018691C6D8
		public static float SqrPoint3Box3(ref Vector3 point, ref Box3 box, out Vector3 closestPoint); // 0x000000018691C6D8-0x000000018691CA28
		public static float Point3Circle3(ref Vector3 point, ref Circle3 circle, bool solid = true /* Metadata: 0x0234BC8B */); // 0x0000000186919088-0x00000001869190C8
		public static float Point3Circle3(ref Vector3 point, ref Circle3 circle, out Vector3 closestPoint, bool solid = true /* Metadata: 0x0234BC8C */); // 0x0000000186919058-0x0000000186919088
		public static float SqrPoint3Circle3(ref Vector3 point, ref Circle3 circle, bool solid = true /* Metadata: 0x0234BC8D */); // 0x000000018691CE20-0x000000018691CE48
		public static float SqrPoint3Circle3(ref Vector3 point, ref Circle3 circle, out Vector3 closestPoint, bool solid = true /* Metadata: 0x0234BC8E */); // 0x000000018691CA28-0x000000018691CE20
		public static float Point3Line3(ref Vector3 point, ref Line3 line); // 0x00000001869190C8-0x00000001869190F0
		public static float Point3Line3(ref Vector3 point, ref Line3 line, out Vector3 closestPoint); // 0x00000001869190F0-0x0000000186919118
		public static float SqrPoint3Line3(ref Vector3 point, ref Line3 line); // 0x000000018691CFC4-0x000000018691D138
		public static float SqrPoint3Line3(ref Vector3 point, ref Line3 line, out Vector3 closestPoint); // 0x000000018691CE48-0x000000018691CFC4
		public static float Point3Plane3(ref Vector3 point, ref Plane3 plane); // 0x0000000186919234-0x00000001869192D4
		public static float Point3Plane3(ref Vector3 point, ref Plane3 plane, out Vector3 closestPoint); // 0x0000000186919118-0x0000000186919234
		public static float SqrPoint3Plane3(ref Vector3 point, ref Plane3 plane); // 0x000000018691D250-0x000000018691D2F0
		public static float SqrPoint3Plane3(ref Vector3 point, ref Plane3 plane, out Vector3 closestPoint); // 0x000000018691D138-0x000000018691D250
		public static float Point3Ray3(ref Vector3 point, ref Ray3 ray); // 0x00000001869192FC-0x0000000186919324
		public static float Point3Ray3(ref Vector3 point, ref Ray3 ray, out Vector3 closestPoint); // 0x00000001869192D4-0x00000001869192FC
		public static float SqrPoint3Ray3(ref Vector3 point, ref Ray3 ray); // 0x000000018691D494-0x000000018691D614
		public static float SqrPoint3Ray3(ref Vector3 point, ref Ray3 ray, out Vector3 closestPoint); // 0x000000018691D2F0-0x000000018691D494
		public static float Point3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle); // 0x000000018691934C-0x0000000186919374
		public static float Point3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle, out Vector3 closestPoint); // 0x0000000186919324-0x000000018691934C
		public static float SqrPoint3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle); // 0x000000018691D878-0x000000018691DA18
		public static float SqrPoint3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle, out Vector3 closestPoint); // 0x000000018691D614-0x000000018691D878
		public static float Point3Segment3(ref Vector3 point, ref Segment3 segment); // 0x000000018691939C-0x00000001869193C4
		public static float Point3Segment3(ref Vector3 point, ref Segment3 segment, out Vector3 closestPoint); // 0x0000000186919374-0x000000018691939C
		public static float SqrPoint3Segment3(ref Vector3 point, ref Segment3 segment); // 0x000000018691DBD8-0x000000018691DD78
		public static float SqrPoint3Segment3(ref Vector3 point, ref Segment3 segment, out Vector3 closestPoint); // 0x000000018691DA18-0x000000018691DBD8
		public static float Point3Sphere3(ref Vector3 point, ref Sphere3 sphere); // 0x00000001869194D8-0x000000018691954C
		public static float Point3Sphere3(ref Vector3 point, ref Sphere3 sphere, out Vector3 closestPoint); // 0x00000001869193C4-0x00000001869194D8
		public static float SqrPoint3Sphere3(ref Vector3 point, ref Sphere3 sphere); // 0x000000018691DD78-0x000000018691DDF0
		public static float SqrPoint3Sphere3(ref Vector3 point, ref Sphere3 sphere, out Vector3 closestPoint); // 0x000000018691DDF0-0x000000018691DF08
		public static float Ray3Ray3(ref Ray3 ray0, ref Ray3 ray1); // 0x000000018691965C-0x0000000186919690
		public static float Ray3Ray3(ref Ray3 ray0, ref Ray3 ray1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x000000018691962C-0x000000018691965C
		public static float SqrRay3Ray3(ref Ray3 ray0, ref Ray3 ray1); // 0x000000018691E9E4-0x000000018691EA18
		public static float SqrRay3Ray3(ref Ray3 ray0, ref Ray3 ray1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x000000018691E5B4-0x000000018691E9E4
		public static float Ray3Segment3(ref Ray3 ray, ref Segment3 segment); // 0x00000001869196C0-0x00000001869196F4
		public static float Ray3Segment3(ref Ray3 ray, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000186919690-0x00000001869196C0
		public static float SqrRay3Segment3(ref Ray3 ray, ref Segment3 segment); // 0x000000018691EE60-0x000000018691EE94
		public static float SqrRay3Segment3(ref Ray3 ray, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x000000018691EA18-0x000000018691EE60
		public static float Segment3Box3(ref Segment3 segment, ref Box3 box, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000186919764-0x0000000186919794
		public static float Segment3Box3(ref Segment3 segment, ref Box3 box); // 0x0000000186919794-0x00000001869197C8
		public static float SqrSegment3Box3(ref Segment3 segment, ref Box3 box, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x000000018691F478-0x000000018691F57C
		public static float SqrSegment3Box3(ref Segment3 segment, ref Box3 box); // 0x000000018691F444-0x000000018691F478
		public static float Segment3Segment3(ref Segment3 segment0, ref Segment3 segment1); // 0x00000001869197F8-0x000000018691982C
		public static float Segment3Segment3(ref Segment3 segment0, ref Segment3 segment1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x00000001869197C8-0x00000001869197F8
		public static float SqrSegment3Segment3(ref Segment3 segment0, ref Segment3 segment1); // 0x000000018691F57C-0x000000018691F5B0
		public static float SqrSegment3Segment3(ref Segment3 segment0, ref Segment3 segment1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x000000018691F5B0-0x000000018691FC38
	}

	public struct Line3Box3Dist // TypeDefIndex: 58477
	{
		// Fields
		public Vector3 ClosestPoint0; // 0x00
		public Vector3 ClosestPoint1; // 0x0C
		public float LineParameter; // 0x18
	}

	public static class Intersection // TypeDefIndex: 58478
	{
		// Fields
		private static float _intervalThreshold; // 0x00
		private static float _dotThreshold; // 0x04
		private static float _distanceThreshold; // 0x08
	
		// Properties
		public static float IntervalThreshold { get; set; } // 0x00000001869344B0-0x0000000186934500 0x0000000186934630-0x00000001869346C4
		public static float DotThreshold { get; set; } // 0x0000000186934460-0x00000001869344B0 0x0000000186934598-0x0000000186934630
		public static float DistanceThreshold { get; set; } // 0x0000000186934410-0x0000000186934460 0x0000000186934500-0x0000000186934598
	
		// Constructors
		static Intersection(); // 0x0000000184D532A0-0x0000000184D53310
	
		// Methods
		public static bool TestAAB2AAB2(ref AAB2 box0, ref AAB2 box1); // 0x000000018692C508-0x000000018692C538
		public static bool FindAAB2AAB2(ref AAB2 box0, ref AAB2 box1, out AAB2 intersection); // 0x0000000186922EDC-0x0000000186922F68
		public static bool TestAAB2AAB2OverlapX(ref AAB2 box0, ref AAB2 box1); // 0x000000018692C4D0-0x000000018692C4EC
		public static bool TestAAB2AAB2OverlapY(ref AAB2 box0, ref AAB2 box1); // 0x000000018692C4EC-0x000000018692C508
		public static bool TestAAB2Circle2(ref AAB2 box, ref Circle2 circle); // 0x000000018355A4A0-0x000000018355A510
		public static bool TestBox2Box2(ref Box2 box0, ref Box2 box1); // 0x000000018692C5D4-0x000000018692C8A4
		public static bool TestBox2Circle2(ref Box2 box, ref Circle2 circle); // 0x000000018692C8A4-0x000000018692C9DC
		public static bool TestCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1); // 0x000000018692D6C0-0x000000018692D710
		public static bool FindCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1, out Circle2Circle2Intr info); // 0x0000000186923054-0x00000001869232AC
		private static int WhichSide(Polygon2 V, Vector2 P, ref Vector2 D); // 0x000000018693410C-0x000000018693423C
		public static bool TestConvexPolygon2ConvexPolygon2(Polygon2 convexPolygon0, Polygon2 convexPolygon1); // 0x000000018692D710-0x000000018692D908
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref AAB2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType); // 0x0000000186922BFC-0x0000000186922EDC
		public static bool TestLine2AAB2(ref Line2 line, ref AAB2 box); // 0x000000018692D908-0x000000018692DA60
		public static bool FindLine2AAB2(ref Line2 line, ref AAB2 box, out Line2AAB2Intr info); // 0x00000001869232AC-0x0000000186923348
		private static bool Clip(float denom, float numer, ref float t0, ref float t1); // 0x0000000186921AB0-0x0000000186921B10
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref Box2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType); // 0x00000001869222A0-0x0000000186922604
		public static bool TestLine2Box2(ref Line2 line, ref Box2 box); // 0x000000018692DA60-0x000000018692DB50
		public static bool FindLine2Box2(ref Line2 line, ref Box2 box, out Line2Box2Intr info); // 0x0000000186923348-0x00000001869233E4
		private static bool Find(ref Vector2 origin, ref Vector2 direction, ref Vector2 center, float radius, out int rootCount, out float t0, out float t1); // 0x000000018692B284-0x000000018692B3DC
		public static bool TestLine2Circle2(ref Line2 line, ref Circle2 circle); // 0x000000018692DB50-0x000000018692DBD8
		public static bool FindLine2Circle2(ref Line2 line, ref Circle2 circle, out Line2Circle2Intr info); // 0x00000001869233E4-0x0000000186923590
		public static bool TestLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon); // 0x000000018692DBD8-0x000000018692DCE4
		public static bool FindLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon, out Line2ConvexPolygon2Intr info); // 0x0000000186923590-0x00000001869238DC
		private static IntersectionTypes Classify(ref Line2 line0, ref Line2 line1, out float s0); // 0x00000001869206C0-0x0000000186920888
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1, out IntersectionTypes intersectionType); // 0x000000018692DD40-0x000000018692DDB0
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1); // 0x000000018692DCE4-0x000000018692DD40
		public static bool FindLine2Line2(ref Line2 line0, ref Line2 line1, out Line2Line2Intr info); // 0x00000001869238DC-0x00000001869239B0
		private static IntersectionTypes Classify(ref Line2 line, ref Ray2 ray, out float s0, out float s1); // 0x0000000186920E0C-0x0000000186921014
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray, out IntersectionTypes intersectionType); // 0x000000018692DE0C-0x000000018692DEC4
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray); // 0x000000018692DDB0-0x000000018692DE0C
		public static bool FindLine2Ray2(ref Line2 line, ref Ray2 ray, out Line2Ray2Intr info); // 0x00000001869239B0-0x0000000186923AF0
		private static IntersectionTypes Classify(ref Segment2 segment, ref Line2 line, out float s0, out float s1); // 0x0000000186921014-0x000000018692122C
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment, out IntersectionTypes intersectionType); // 0x000000018692DF20-0x000000018692DFBC
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment); // 0x000000018692DEC4-0x000000018692DF20
		public static bool FindLine2Segment2(ref Line2 line, ref Segment2 segment, out Line2Segment2Intr info); // 0x0000000186923AF0-0x0000000186923C14
		private static void TriangleLineRelations(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, out float dist0, out float dist1, out float dist2, out int sign0, out int sign1, out int sign2, out int positive, out int negative, out int zero); // 0x0000000186933C74-0x0000000186933EFC
		private static bool GetInterval(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, float dist0, float dist1, float dist2, int sign0, int sign1, int sign2, out float param0, out float param1); // 0x000000018692B9F4-0x000000018692BC60
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out IntersectionTypes intersectionType); // 0x000000018692DFBC-0x000000018692E184
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle); // 0x000000018692E184-0x000000018692E1E0
		public static bool FindLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out Line2Triangle2Intr info); // 0x0000000186923C14-0x0000000186923EB4
		public static bool TestRay2AAB2(ref Ray2 ray, ref AAB2 box); // 0x000000018692F508-0x000000018692F630
		public static bool FindRay2AAB2(ref Ray2 ray, ref AAB2 box, out Ray2AAB2Intr info); // 0x0000000186925B48-0x0000000186925BE0
		public static bool TestRay2Box2(ref Ray2 ray, ref Box2 box); // 0x000000018692F630-0x000000018692F81C
		public static bool FindRay2Box2(ref Ray2 ray, ref Box2 box, out Ray2Box2Intr info); // 0x0000000186925BE0-0x0000000186925C78
		public static bool TestRay2Circle2(ref Ray2 ray, ref Circle2 circle); // 0x000000018692F81C-0x000000018692F8B0
		public static bool FindRay2Circle2(ref Ray2 ray, ref Circle2 circle, out Ray2Circle2Intr info); // 0x0000000186925C78-0x0000000186925E54
		public static bool TestRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon); // 0x000000018692F8B0-0x000000018692F9BC
		public static bool FindRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon, out Ray2ConvexPolygon2Intr info); // 0x0000000186925E54-0x000000018692619C
		public static bool TestRay2Polygon2(ref Ray2 ray, Polygon2 polygon); // 0x000000018692F9BC-0x000000018692FAC8
		public static bool TestRay2Polygon2(ref Ray2 ray, Segment2[] segments); // 0x000000018692FAC8-0x000000018692FB68
		public static bool FindRay2Polygon2(ref Ray2 ray, Polygon2 polygon, out Ray2Polygon2Intr info); // 0x0000000186926318-0x0000000186926510
		public static bool FindRay2Polygon2(ref Ray2 ray, Segment2[] segments, out Ray2Polygon2Intr info); // 0x000000018692619C-0x0000000186926318
		private static IntersectionTypes Classify(ref Ray2 ray0, ref Ray2 ray1, out float s0, out float s1); // 0x000000018692047C-0x00000001869206C0
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out IntersectionTypes intersectionType); // 0x000000018692FB68-0x000000018692FCC4
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1); // 0x000000018692FCC4-0x000000018692FD20
		public static bool FindRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Ray2Ray2Intr info); // 0x0000000186926510-0x0000000186926714
		private static IntersectionTypes Classify(ref Ray2 ray, ref Segment2 segment, out float s0, out float s1); // 0x0000000186920B60-0x0000000186920E0C
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment, out IntersectionTypes intersectionType); // 0x000000018692FD7C-0x000000018692FEC8
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment); // 0x000000018692FD20-0x000000018692FD7C
		public static bool FindRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Ray2Segment2Intr info); // 0x0000000186926714-0x0000000186926924
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out IntersectionTypes intersectionType); // 0x000000018692FEC8-0x000000018693008C
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle); // 0x000000018693008C-0x00000001869300E8
		public static bool FindRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out Ray2Triangle2Intr info); // 0x0000000186926924-0x0000000186926BC0
		public static bool TestSegment2AAB2(ref Segment2 segment, ref AAB2 box); // 0x0000000186931154-0x0000000186931294
		public static bool FindSegment2AAB2(ref Segment2 segment, ref AAB2 box, out Segment2AAB2Intr info); // 0x00000001869280C8-0x0000000186928188
		public static bool TestSegment2Box2(ref Segment2 segment, ref Box2 box); // 0x0000000186931294-0x0000000186931494
		public static bool FindSegment2Box2(ref Segment2 segment, ref Box2 box, out Segment2Box2Intr info); // 0x0000000186928188-0x0000000186928248
		public static bool TestSegment2Circle2(ref Segment2 segment, ref Circle2 circle); // 0x0000000186931494-0x0000000186931568
		public static bool FindSegment2Circle2(ref Segment2 segment, ref Circle2 circle, out Segment2Circle2Intr info); // 0x0000000186928248-0x00000001869284B0
		public static bool TestSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon); // 0x0000000186931568-0x00000001869315CC
		public static bool FindSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon, out Segment2ConvexPolygon2Intr info); // 0x00000001869284B0-0x00000001869287F4
		private static IntersectionTypes Classify(ref Segment2 segment0, ref Segment2 segment1, out float s0, out float s1); // 0x0000000186920888-0x0000000186920B60
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out IntersectionTypes intersectionType); // 0x0000000186931628-0x000000018693178C
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1); // 0x00000001869315CC-0x0000000186931628
		public static bool FindSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Segment2Segment2Intr info); // 0x00000001869287F4-0x0000000186928B10
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out IntersectionTypes intersectionType); // 0x00000001869317E8-0x00000001869319D0
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle); // 0x000000018693178C-0x00000001869317E8
		public static bool FindSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out Segment2Triangle2Intr info); // 0x0000000186928B10-0x0000000186928E20
		private static int WhichSide(ref Triangle2 triangle, ref Vector2 P, ref Vector2 D); // 0x000000018693423C-0x0000000186934410
		private static void ClipConvexPolygonAgainstLine(ref Vector2 edgeStart, ref Vector2 edgeEnd, ref int quantity, ref Triangle2Triangle2Intr info); // 0x000000018692122C-0x0000000186921AB0
		public static bool TestTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1); // 0x0000000186932B18-0x0000000186932D64
		public static bool FindTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1, out Triangle2Triangle2Intr info); // 0x000000018692A844-0x000000018692A98C
		public static bool TestAAB3AAB3(ref AAB3 box0, ref AAB3 box1); // 0x000000018692C58C-0x000000018692C5D4
		public static bool FindAAB3AAB3(ref AAB3 box0, ref AAB3 box1, out AAB3 intersection); // 0x0000000186922F68-0x0000000186923054
		public static bool TestAAB3AAB3OverlapX(ref AAB3 box0, ref AAB3 box1); // 0x000000018692C538-0x000000018692C554
		public static bool TestAAB3AAB3OverlapY(ref AAB3 box0, ref AAB3 box1); // 0x000000018692C554-0x000000018692C570
		public static bool TestAAB3AAB3OverlapZ(ref AAB3 box0, ref AAB3 box1); // 0x000000018692C570-0x000000018692C58C
		public static bool TestAAB3Sphere3(ref AAB3 box, ref Sphere3 sphere); // 0x00000001833A4D40-0x00000001833A4DD0
		public static bool TestBox3Box3(ref Box3 box0, ref Box3 box1); // 0x000000018692C9DC-0x000000018692D494
		public static bool TestBox3Capsule3(ref Box3 box, ref Capsule3 capsule); // 0x000000018692D494-0x000000018692D4BC
		public static bool TestBox3Sphere3(ref Box3 box, ref Sphere3 sphere); // 0x000000018692D4BC-0x000000018692D6C0
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref AAB3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType); // 0x0000000186921E50-0x00000001869222A0
		public static bool TestLine3AAB3(ref Line3 line, ref AAB3 box); // 0x000000018692E1E0-0x000000018692E37C
		public static bool FindLine3AAB3(ref Line3 line, ref AAB3 box, out Line3AAB3Intr info); // 0x0000000186923EB4-0x0000000186923F50
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref Box3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType); // 0x0000000186922604-0x0000000186922BFC
		public static bool TestLine3Box3(ref Line3 line, ref Box3 box); // 0x000000018692E37C-0x000000018692E63C
		public static bool FindLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Intr info); // 0x0000000186923F50-0x0000000186923FEC
		public static bool TestLine3Circle3(ref Line3 line, ref Circle3 circle); // 0x000000018692E63C-0x000000018692E69C
		public static bool FindLine3Circle3(ref Line3 line, ref Circle3 circle, out Line3Circle3Intr info); // 0x0000000186923FEC-0x0000000186924200
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane, out IntersectionTypes intersectionType); // 0x000000018692E69C-0x000000018692E7D4
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane); // 0x000000018692E7D4-0x000000018692E830
		public static bool FindLine3Plane3(ref Line3 line, ref Plane3 plane, out Line3Plane3Intr info); // 0x0000000186924200-0x0000000186924380
		public static bool TestLine3Polygon3(ref Line3 line, Polygon3 polygon); // 0x000000018692E830-0x000000018692E890
		public static bool FindLine3Polygon3(ref Line3 line, Polygon3 polygon, out Line3Polygon3Intr info); // 0x0000000186924380-0x0000000186924560
		private static bool Point3InsideRectangle3(ref Vector3 point, ref Rectangle3 rectangle); // 0x000000018692C110-0x000000018692C23C
		public static bool TestLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle); // 0x000000018692E890-0x000000018692E8F0
		public static bool FindLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle, out Line3Rectangle3Intr info); // 0x0000000186924560-0x0000000186924748
		public static bool TestLine3Sphere3(ref Line3 line, ref Sphere3 sphere); // 0x000000018692E8F0-0x000000018692EA04
		public static bool FindLine3Sphere3(ref Line3 line, ref Sphere3 sphere, out Line3Sphere3Intr info); // 0x0000000186924748-0x0000000186924A40
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out IntersectionTypes intersectionType); // 0x000000018692ED68-0x000000018692F098
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType); // 0x000000018692ECA4-0x000000018692ED68
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType); // 0x000000018692EB20-0x000000018692EBE4
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle); // 0x000000018692EA04-0x000000018692EA60
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x000000018692EBE4-0x000000018692ECA4
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2); // 0x000000018692EA60-0x000000018692EB20
		public static bool FindLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out Line3Triangle3Intr info); // 0x0000000186924BC8-0x0000000186924FD0
		public static bool FindLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Line3Triangle3Intr info); // 0x0000000186924A40-0x0000000186924B04
		public static bool FindLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out Line3Triangle3Intr info); // 0x0000000186924B04-0x0000000186924BC8
		public static bool TestPlane3AAB3(ref Plane3 plane, ref AAB3 box); // 0x000000018692F098-0x000000018692F168
		public static bool TestPlane3Box3(ref Plane3 plane, ref Box3 box); // 0x000000018692F168-0x000000018692F2D4
		public static bool TestPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1); // 0x000000018692F2D4-0x000000018692F374
		public static bool FindPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1, out Plane3Plane3Intr info); // 0x0000000186924FD0-0x000000018692520C
		public static bool TestPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere); // 0x000000018692F374-0x000000018692F3A8
		public static bool FindPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere, out Plane3Sphere3Intr info); // 0x000000018692520C-0x000000018692538C
		public static bool TestPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle); // 0x000000018692F3A8-0x000000018692F508
		public static bool FindPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle, out Plane3Triangle3Intr info); // 0x000000018692538C-0x0000000186925B48
		public static bool TestRay3AAB3(ref Ray3 ray, ref AAB3 box); // 0x00000001869300E8-0x0000000186930334
		public static bool FindRay3AAB3(ref Ray3 ray, ref AAB3 box, out Ray3AAB3Intr info); // 0x0000000186926BC0-0x0000000186926C58
		public static bool TestRay3Box3(ref Ray3 ray, ref Box3 box); // 0x0000000186930334-0x00000001869306FC
		public static bool FindRay3Box3(ref Ray3 ray, ref Box3 box, out Ray3Box3Intr info); // 0x0000000186926C58-0x0000000186926CF0
		public static bool TestRay3Circle3(ref Ray3 ray, ref Circle3 circle); // 0x00000001869306FC-0x000000018693075C
		public static bool FindRay3Circle3(ref Ray3 ray, ref Circle3 circle, out Ray3Circle3Intr info); // 0x0000000186926CF0-0x0000000186926F78
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane, out IntersectionTypes intersectionType); // 0x00000001869307C0-0x0000000186930838
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane); // 0x000000018693075C-0x00000001869307C0
		public static bool FindRay3Plane3(ref Ray3 ray, ref Plane3 plane, out Ray3Plane3Intr info); // 0x0000000186926F78-0x000000018692717C
		public static bool TestRay3Polygon3(ref Ray3 ray, Polygon3 polygon); // 0x0000000186930838-0x0000000186930898
		public static bool FindRay3Polygon3(ref Ray3 ray, Polygon3 polygon, out Ray3Polygon3Intr info); // 0x000000018692717C-0x00000001869273D4
		public static bool TestRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle); // 0x0000000186930898-0x00000001869308F8
		public static bool FindRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle, out Ray3Rectangle3Intr info); // 0x00000001869273D4-0x0000000186927628
		public static bool TestRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere); // 0x00000001869308F8-0x0000000186930A40
		public static bool FindRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere, out Ray3Sphere3Intr info); // 0x0000000186927628-0x00000001869279F4
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out IntersectionTypes intersectionType); // 0x0000000186930DA4-0x0000000186931154
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000186930A40-0x0000000186930B04
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000186930B04-0x0000000186930BC8
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle); // 0x0000000186930C88-0x0000000186930CE4
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000186930CE4-0x0000000186930DA4
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000186930BC8-0x0000000186930C88
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out Ray3Triangle3Intr info); // 0x0000000186927AB8-0x0000000186927EF0
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Ray3Triangle3Intr info); // 0x00000001869279F4-0x0000000186927AB8
		public static bool FindRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out Ray3Triangle3Intr info); // 0x0000000186927EF0-0x0000000186927FB4
		public static bool TestSegment3AAB3(ref Segment3 segment, ref AAB3 box); // 0x00000001869319D0-0x0000000186931C1C
		public static bool FindSegment3AAB3(ref Segment3 segment, ref AAB3 box, out Segment3AAB3Intr info); // 0x0000000186928E20-0x0000000186928EE0
		public static bool TestSegment3Box3(ref Segment3 segment, ref Box3 box); // 0x0000000186931C1C-0x0000000186931FD0
		public static bool FindSegment3Box3(ref Segment3 segment, ref Box3 box, out Segment3Box3Intr info); // 0x0000000186928EE0-0x0000000186928FA0
		public static bool TestSegment3Circle3(ref Segment3 segment, ref Circle3 circle); // 0x0000000186931FD0-0x0000000186932030
		public static bool FindSegment3Circle3(ref Segment3 segment, ref Circle3 circle, out Segment3Circle3Intr info); // 0x0000000186928FA0-0x0000000186929230
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out IntersectionTypes intersectionType); // 0x000000018693208C-0x00000001869321D8
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane); // 0x0000000186932030-0x000000018693208C
		public static bool FindSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out Segment3Plane3Intr info); // 0x0000000186929230-0x0000000186929468
		public static bool TestSegment3Polygon3(ref Segment3 segment, Polygon3 polygon); // 0x00000001869321D8-0x0000000186932238
		public static bool FindSegment3Polygon3(ref Segment3 segment, Polygon3 polygon, out Segment3Polygon3Intr info); // 0x0000000186929468-0x00000001869296BC
		public static bool TestSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle); // 0x0000000186932238-0x0000000186932298
		public static bool FindSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle, out Segment3Rectangle3Intr info); // 0x00000001869296BC-0x000000018692991C
		public static bool TestSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere); // 0x0000000186932298-0x000000018693240C
		public static bool FindSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere, out Segment3Sphere3Intr info); // 0x000000018692991C-0x0000000186929D88
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out IntersectionTypes intersectionType); // 0x0000000186932714-0x0000000186932ABC
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000186932650-0x0000000186932714
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType); // 0x00000001869324CC-0x0000000186932590
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle); // 0x0000000186932ABC-0x0000000186932B18
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000186932590-0x0000000186932650
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2); // 0x000000018693240C-0x00000001869324CC
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out Segment3Triangle3Intr info); // 0x0000000186929E4C-0x000000018692A2D4
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Segment3Triangle3Intr info); // 0x000000018692A2D4-0x000000018692A398
		public static bool FindSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out Segment3Triangle3Intr info); // 0x0000000186929D88-0x0000000186929E4C
		public static bool TestSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1); // 0x00000001849E3D50-0x00000001849E3DD0
		public static bool FindSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1, out Sphere3Sphere3Intr info); // 0x000000018692A398-0x000000018692A844
		private static void ProjectOntoAxis(ref Triangle3 triangle, ref Vector3 axis, out float fmin, out float fmax); // 0x000000018692C23C-0x000000018692C3A0
		private static void TrianglePlaneRelations(ref Triangle3 triangle, ref Plane3 plane, out float dist0, out float dist1, out float dist2, out int sign0, out int sign1, out int sign2, out int positive, out int negative, out int zero); // 0x0000000186933FB0-0x000000018693410C
		private static bool TrianglePlaneRelationsQuick(ref Triangle3 triangle, ref Plane3 plane); // 0x0000000186933EFC-0x0000000186933FB0
		private static bool IntersectsSegment(ref Plane3 plane, ref Triangle3 triangle, ref Vector3 end0, ref Vector3 end1, bool grazing, out Triangle3Triangle3Intr info); // 0x000000018692BC60-0x000000018692C110
		private static int QueryToLine(ref Vector2 test, ref Vector2 vec0, ref Vector2 vec1); // 0x000000018692C3A0-0x000000018692C3F4
		private static int QueryToTriangle(ref Vector2 test, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x000000018692C3F4-0x000000018692C4D0
		private static bool ContainsPoint(ref Triangle3 triangle, ref Plane3 plane, ref Vector3 point, out Triangle3Triangle3Intr info); // 0x0000000186921B10-0x0000000186921E50
		private static bool GetCoplanarIntersection(ref Plane3 plane, ref Triangle3 tri0, ref Triangle3 tri1, out Triangle3Triangle3Intr info); // 0x000000018692B3DC-0x000000018692B9F4
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out IntersectionTypes intersectionType); // 0x0000000186932D64-0x0000000186933C18
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1); // 0x0000000186933C18-0x0000000186933C74
		public static bool FindTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out Triangle3Triangle3Intr info, bool reportCoplanarIntersections = false /* Metadata: 0x0234BC8F */); // 0x000000018692A98C-0x000000018692B284
		public static int FindSegment1Segment1(float seg0Start, float seg0End, float seg1Start, float seg1End, out float w0, out float w1); // 0x0000000186927FB4-0x00000001869280C8
	}

	public struct Circle2Circle2Intr // TypeDefIndex: 58479
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2AAB2Intr // TypeDefIndex: 58480
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2Box2Intr // TypeDefIndex: 58481
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2Circle2Intr // TypeDefIndex: 58482
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Line2ConvexPolygon2Intr // TypeDefIndex: 58483
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Line2Line2Intr // TypeDefIndex: 58484
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Ray2Intr // TypeDefIndex: 58485
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Segment2Intr // TypeDefIndex: 58486
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Triangle2Intr // TypeDefIndex: 58487
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2AAB2Intr // TypeDefIndex: 58488
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2Box2Intr // TypeDefIndex: 58489
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2Circle2Intr // TypeDefIndex: 58490
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Ray2ConvexPolygon2Intr // TypeDefIndex: 58491
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Ray2Polygon2Intr // TypeDefIndex: 58492
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Ray2Ray2Intr // TypeDefIndex: 58493
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Ray2Segment2Intr // TypeDefIndex: 58494
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Ray2Triangle2Intr // TypeDefIndex: 58495
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2AAB2Intr // TypeDefIndex: 58496
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2Box2Intr // TypeDefIndex: 58497
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2Circle2Intr // TypeDefIndex: 58498
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Segment2ConvexPolygon2Intr // TypeDefIndex: 58499
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Segment2Segment2Intr // TypeDefIndex: 58500
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Segment2Triangle2Intr // TypeDefIndex: 58501
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Triangle2Triangle2Intr // TypeDefIndex: 58502
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public Vector2 Point2; // 0x18
		public Vector2 Point3; // 0x20
		public Vector2 Point4; // 0x28
		public Vector2 Point5; // 0x30
	
		// Properties
		public Vector2 this[int i] { get => default; internal set {} } // 0x000000018693A094-0x000000018693A110 0x000000018693A110-0x000000018693A14C
	}

	internal struct Float6 // TypeDefIndex: 58503
	{
		// Fields
		private float _0; // 0x00
		private float _1; // 0x04
		private float _2; // 0x08
		private float _3; // 0x0C
		private float _4; // 0x10
		private float _5; // 0x14
	
		// Properties
		public float this[int i] { get => default; set {} } // 0x00000001869347A8-0x00000001869347EC 0x00000001869347EC-0x0000000186934844
	}

	public struct Line3AAB3Intr // TypeDefIndex: 58504
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Line3Box3Intr // TypeDefIndex: 58505
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Line3Circle3Intr // TypeDefIndex: 58506
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Plane3Intr // TypeDefIndex: 58507
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float LineParameter; // 0x10
	}

	public struct Line3Polygon3Intr // TypeDefIndex: 58508
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Rectangle3Intr // TypeDefIndex: 58509
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Sphere3Intr // TypeDefIndex: 58510
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float LineParameter0; // 0x20
		public float LineParameter1; // 0x24
	}

	public struct Line3Triangle3Intr // TypeDefIndex: 58511
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float LineParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public struct Plane3Plane3Intr // TypeDefIndex: 58512
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Line3 Line; // 0x04
	}

	public struct Plane3Sphere3Intr // TypeDefIndex: 58513
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Circle3 Circle; // 0x04
	}

	public struct Plane3Triangle3Intr // TypeDefIndex: 58514
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public Vector3 Point2; // 0x20
	}

	public struct Ray3AAB3Intr // TypeDefIndex: 58515
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Ray3Box3Intr // TypeDefIndex: 58516
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Ray3Circle3Intr // TypeDefIndex: 58517
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Plane3Intr // TypeDefIndex: 58518
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float RayParameter; // 0x10
	}

	public struct Ray3Polygon3Intr // TypeDefIndex: 58519
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Rectangle3Intr // TypeDefIndex: 58520
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Sphere3Intr // TypeDefIndex: 58521
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float RayParameter0; // 0x20
		public float RayParameter1; // 0x24
	}

	public struct Ray3Triangle3Intr // TypeDefIndex: 58522
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float RayParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public struct Segment3AAB3Intr // TypeDefIndex: 58523
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Segment3Box3Intr // TypeDefIndex: 58524
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Segment3Circle3Intr // TypeDefIndex: 58525
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Plane3Intr // TypeDefIndex: 58526
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float SegmentParameter; // 0x10
	}

	public struct Segment3Polygon3Intr // TypeDefIndex: 58527
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Rectangle3Intr // TypeDefIndex: 58528
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Sphere3Intr // TypeDefIndex: 58529
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float SegmentParameter0; // 0x20
		public float SegmentParameter1; // 0x24
	}

	public struct Segment3Triangle3Intr // TypeDefIndex: 58530
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float SegmentParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public enum Sphere3Sphere3IntrTypes // TypeDefIndex: 58531
	{
		Empty = 0,
		Point = 1,
		Circle = 2,
		Sphere0 = 3,
		Sphere0Point = 4,
		Sphere1 = 5,
		Sphere1Point = 6,
		Same = 7
	}

	public struct Sphere3Sphere3Intr // TypeDefIndex: 58532
	{
		// Fields
		public Sphere3Sphere3IntrTypes IntersectionType; // 0x00
		public Circle3 Circle; // 0x04
		public Vector3 ContactPoint; // 0x38
	}

	public struct Triangle3Triangle3Intr // TypeDefIndex: 58533
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public IntersectionTypes CoplanarIntersectionType; // 0x04
		public bool Touching; // 0x08
		public int Quantity; // 0x0C
		public Vector3 Point0; // 0x10
		public Vector3 Point1; // 0x1C
		public Vector3 Point2; // 0x28
		public Vector3 Point3; // 0x34
		public Vector3 Point4; // 0x40
		public Vector3 Point5; // 0x4C
	
		// Properties
		public Vector3 this[int i] { get => default; internal set {} } // 0x000000018693A14C-0x000000018693A1DC 0x000000018693A1DC-0x000000018693A268
	}

	public enum IntersectionTypes // TypeDefIndex: 58534
	{
		Empty = 0,
		Point = 1,
		Segment = 2,
		Ray = 3,
		Line = 4,
		Polygon = 5,
		Plane = 6,
		Polyhedron = 7,
		Other = 8
	}

	public interface ILogger // TypeDefIndex: 58535
	{
		// Methods
		void LogInfo(object value);
		void LogWarning(object value);
		void LogError(object value);
	}

	public class Logger // TypeDefIndex: 58536
	{
		// Fields
		private static ILogger _instance; // 0x00
	
		// Constructors
		static Logger(); // 0x0000000186934B70-0x0000000186934BE0
		public Logger(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void LogInfo(object value); // 0x00000001869349C0-0x0000000186934A50
		public static void LogWarning(object value); // 0x0000000186934A50-0x0000000186934AE8
		public static void LogError(object value); // 0x000000018693492C-0x00000001869349C0
		public static void SetLogger(ILogger logger); // 0x0000000186934AE8-0x0000000186934B70
	}

	public class DefaultLogger : ILogger // TypeDefIndex: 58537
	{
		// Constructors
		public DefaultLogger(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void LogInfo(object value); // 0x0000000186934710-0x000000018693475C
		public void LogWarning(object value); // 0x000000018693475C-0x00000001869347A8
		public void LogError(object value); // 0x00000001869346C4-0x0000000186934710
	}

	public class EmptyLogger : ILogger // TypeDefIndex: 58538
	{
		// Constructors
		public EmptyLogger(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void LogInfo(object value); // 0x00000001841E1670-0x00000001841E1680
		public void LogWarning(object value); // 0x00000001841E1670-0x00000001841E1680
		public void LogError(object value); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class Mathfex // TypeDefIndex: 58539
	{
		// Fields
		public const float ZeroTolerance = 1E-05f; // Metadata: 0x0234BCA9
		public const float NegativeZeroTolerance = -1E-05f; // Metadata: 0x0234BCAD
		public const float ZeroToleranceSqr = 9.9999994E-11f; // Metadata: 0x0234BCB1
		public const float Pi = 3.1415927f; // Metadata: 0x0234BCB5
		public const float HalfPi = 1.5707964f; // Metadata: 0x0234BCB9
		public const float TwoPi = 6.2831855f; // Metadata: 0x0234BCBD
	
		// Methods
		public static float EvalSquared(float x); // 0x0000000184D886E0-0x0000000184D886F0
		public static float EvalInvSquared(float x); // 0x0000000184D88670-0x0000000184D88690
		public static float EvalCubic(float x); // 0x0000000184D89930-0x0000000184D89940
		public static float EvalInvCubic(float x); // 0x0000000184D899A0-0x0000000184D899B0
		public static float EvalQuadratic(float x, float a, float b, float c); // 0x0000000184D899B0-0x0000000184D899D0
		public static float EvalSigmoid(float x); // 0x0000000184D899D0-0x0000000184D899F0
		public static float EvalOverlappedStep(float x, float overlap, int objectIndex, int objectCount); // 0x0000000186934FE0-0x0000000186935030
		public static float EvalSmoothOverlappedStep(float x, float overlap, int objectIndex, int objectCount); // 0x0000000186935030-0x0000000186935098
		public static float EvalGaussian(float x, float a, float b, float c); // 0x0000000186934FA4-0x0000000186934FE0
		public static float EvalGaussian2D(float x, float y, float x0, float y0, float A, float a, float b, float c); // 0x0000000184D89940-0x0000000184D899A0
		public static float Lerp(float value0, float value1, float factor); // 0x0000000186935148-0x0000000186935178
		public static float LerpUnclamped(float value0, float value1, float factor); // 0x0000000184D899F0-0x0000000184D89A00
		public static float SigmoidInterp(float value0, float value1, float factor); // 0x000000018693519C-0x00000001869351E8
		public static float SinInterp(float value0, float value1, float factor); // 0x00000001869351E8-0x0000000186935244
		public static float CosInterp(float value0, float value1, float factor); // 0x0000000186934EC8-0x0000000186934F3C
		public static float WobbleInterp(float value0, float value1, float factor); // 0x0000000186935244-0x0000000186935328
		public static float CurveInterp(float value0, float value1, float factor, AnimationCurve curve); // 0x0000000186934F3C-0x0000000186934FA4
		public static float FuncInterp(float value0, float value1, float factor, Func<float, float> func); // 0x0000000186935098-0x0000000186935118
		public static float InvSqrt(float value); // 0x0000000186935118-0x0000000186935148
		public static bool Near(float value0, float value1, float epsilon = 1E-05f /* Metadata: 0x0234BCA1 */); // 0x0000000186935188-0x000000018693519C
		public static bool NearZero(float value, float epsilon = 1E-05f /* Metadata: 0x0234BCA5 */); // 0x0000000186935178-0x0000000186935188
		public static Vector2 CartesianToPolar(Vector2 cartesianCoordinates); // 0x0000000186934CC8-0x0000000186934DAC
		public static Vector2 PolarToCartesian(Vector2 polarCoordinates); // 0x0000000184D89A00-0x0000000184D89A50
		public static Vector3 CartesianToSpherical(Vector3 cartesianCoordinates); // 0x0000000186934DAC-0x0000000186934EC8
		public static Vector3 SphericalToCartesian(Vector3 sphericalCoordinates); // 0x0000000184D89A50-0x0000000184D89AF0
		public static Vector3 CartesianToCylindrical(Vector3 cartesianCoordinates); // 0x0000000186934BE0-0x0000000186934CC8
		public static Vector3 CylindricalToCartesian(Vector3 cylindricalCoordinates); // 0x0000000184D898E0-0x0000000184D89930
	}

	public static class Matrix4x4ex // TypeDefIndex: 58540
	{
		// Fields
		public static readonly Matrix4x4 Identity; // 0x00
	
		// Constructors
		static Matrix4x4ex(); // 0x0000000186937C2C-0x0000000186937CB4
	
		// Methods
		public static void RotationMatrixToQuaternion(ref Matrix4x4 matrix, out Quaternion quaternion); // 0x0000000186937B64-0x0000000186937C2C
		public static void QuaternionToRotationMatrix(Quaternion quaternion, out Matrix4x4 matrix); // 0x0000000184D8B050-0x0000000184D8B1D0
		public static void QuaternionToRotationMatrix(ref Quaternion quaternion, out Matrix4x4 matrix); // 0x0000000184D8B1D0-0x0000000184D8B350
		public static void CreateTranslation(Vector3 position, out Matrix4x4 matrix); // 0x0000000184D8A9C0-0x0000000184D8AA00
		public static void CreateTranslation(ref Vector3 position, out Matrix4x4 matrix); // 0x0000000184D8A980-0x0000000184D8A9C0
		public static void CreateScale(Vector3 scale, out Matrix4x4 matrix); // 0x0000000184D8A000-0x0000000184D8A040
		public static void CreateScale(ref Vector3 scale, out Matrix4x4 matrix); // 0x0000000184D8A040-0x0000000184D8A080
		public static void CreateScale(float scale, out Matrix4x4 matrix); // 0x0000000184D8A080-0x0000000184D8A0C0
		public static void CreateRotationEuler(float eulerX, float eulerY, float eulerZ, out Matrix4x4 matrix); // 0x00000001869357BC-0x000000018693584C
		public static void CreateRotationEuler(Vector3 eulerAngles, out Matrix4x4 matrix); // 0x00000001869358C0-0x0000000186935934
		public static void CreateRotationEuler(ref Vector3 eulerAngles, out Matrix4x4 matrix); // 0x000000018693584C-0x00000001869358C0
		public static void CreateRotationX(float angleInDegrees, out Matrix4x4 matrix); // 0x0000000184D89E00-0x0000000184D89E90
		public static void CreateRotationY(float angleInDegrees, out Matrix4x4 matrix); // 0x0000000184D89E90-0x0000000184D89F20
		public static void CreateRotationZ(float angleInDegrees, out Matrix4x4 matrix); // 0x0000000184D89F20-0x0000000184D89FB0
		public static void CreateRotationAngleAxis(float angleInDegrees, Vector3 rotationAxis, out Matrix4x4 matrix); // 0x0000000186935638-0x00000001869357BC
		public static void CreateRotationAngleUnitAxis(float angleInDegrees, Vector3 normalizedAxis, out Matrix4x4 matrix); // 0x0000000184D89CA0-0x0000000184D89E00
		public static void CreateRotation(Vector3 rotationOrigin, Quaternion rotation, out Matrix4x4 result); // 0x0000000186935C50-0x0000000186935D4C
		public static void CreateRotation(ref Vector3 rotationOrigin, ref Quaternion rotation, out Matrix4x4 result); // 0x0000000186935B54-0x0000000186935C50
		public static void Transpose(ref Matrix4x4 matrix); // 0x0000000184D8B350-0x0000000184D8B3C0
		public static void Transpose(ref Matrix4x4 matrix, out Matrix4x4 transpose); // 0x0000000184D8B3C0-0x0000000184D8B420
		public static float CalcDeterminant(ref Matrix4x4 matrix); // 0x0000000184D89AF0-0x0000000184D89C40
		public static void Inverse(ref Matrix4x4 matrix, float epsilon = 1E-05f /* Metadata: 0x0234BCC1 */); // 0x0000000186936D68-0x0000000186937394
		public static void Inverse(ref Matrix4x4 matrix, out Matrix4x4 inverse, float epsilon = 1E-05f /* Metadata: 0x0234BCC5 */); // 0x000000018693679C-0x0000000186936D68
		public static void CopyMatrix(ref Matrix4x4 source, out Matrix4x4 destination); // 0x0000000184D89C40-0x0000000184D89CA0
		public static void Multiply(ref Matrix4x4 matrix0, ref Matrix4x4 matrix1, out Matrix4x4 result); // 0x0000000184D8ABD0-0x0000000184D8AF70
		public static void MultiplyRight(ref Matrix4x4 matrix0, ref Matrix4x4 matrix1); // 0x000000018693777C-0x0000000186937B64
		public static void MultiplyLeft(ref Matrix4x4 matrix1, ref Matrix4x4 matrix0); // 0x0000000186937394-0x000000018693777C
		public static void Multiply(ref Matrix4x4 matrix, float scalar); // 0x0000000184D8AA00-0x0000000184D8AAD0
		public static void Multiply(ref Matrix4x4 matrix, float scalar, out Matrix4x4 result); // 0x0000000184D8AF70-0x0000000184D8B050
		public static Vector4 Multiply(ref Matrix4x4 matrix, Vector4 vector); // 0x0000000184D8AAD0-0x0000000184D8ABD0
		public static Vector4 Multiply(ref Matrix4x4 matrix, ref Vector4 vector); // 0x0000000184D8AAD0-0x0000000184D8ABD0
		public static void CreateSRT(Vector3 scaling, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000186936188-0x0000000186936288
		public static void CreateSRT(ref Vector3 scaling, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000186936088-0x0000000186936188
		public static void CreateSRT(float scaling, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x00000001869365C4-0x00000001869366B0
		public static void CreateSRT(float scaling, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x00000001869366B0-0x000000018693679C
		public static void CreateSRT(Vector3 scaling, Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x000000018693641C-0x00000001869365C4
		public static void CreateSRT(ref Vector3 scaling, ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000186935EE0-0x0000000186936088
		public static void CreateSRT(float scaling, Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000186935D4C-0x0000000186935EE0
		public static void CreateSRT(float scaling, ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000186936288-0x000000018693641C
		public static void CreateRT(Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000186935440-0x00000001869354B0
		public static void CreateRT(ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x00000001869354B0-0x0000000186935520
		public static void CreateRT(Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000186935328-0x0000000186935440
		public static void CreateRT(ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000186935520-0x0000000186935638
		public static void CreateST(Vector3 scaling, Vector3 translation, out Matrix4x4 result); // 0x0000000184D89FB0-0x0000000184D8A000
		public static void CreateST(ref Vector3 scaling, ref Vector3 translation, out Matrix4x4 result); // 0x0000000184D89FB0-0x0000000184D8A000
		public static void CreateRotationFromColumns(Vector3 column0, Vector3 column1, Vector3 column2, out Matrix4x4 matrix); // 0x0000000186935A44-0x0000000186935B54
		public static void CreateRotationFromColumns(ref Vector3 column0, ref Vector3 column1, ref Vector3 column2, out Matrix4x4 matrix); // 0x0000000186935934-0x0000000186935A44
		public static void CreateShadowDirectional(Plane3 shadowPlane, Vector3 dirLightOppositeDirection, out Matrix4x4 result); // 0x0000000184D8A0C0-0x0000000184D8A220
		public static void CreateShadowDirectional(ref Plane3 shadowPlane, ref Vector3 dirLightOppositeDirection, out Matrix4x4 result); // 0x0000000184D8A220-0x0000000184D8A380
		public static void CreateShadowPoint(Plane3 shadowPlane, Vector3 pointLightPosition, out Matrix4x4 result); // 0x0000000184D8A380-0x0000000184D8A4E0
		public static void CreateShadowPoint(ref Plane3 shadowPlane, ref Vector3 pointLightPosition, out Matrix4x4 result); // 0x0000000184D8A4E0-0x0000000184D8A640
		public static void CreateShadow(Plane3 shadowPlane, Vector4 lightData, out Matrix4x4 result); // 0x0000000184D8A7E0-0x0000000184D8A980
		public static void CreateShadow(ref Plane3 shadowPlane, ref Vector4 lightData, out Matrix4x4 result); // 0x0000000184D8A640-0x0000000184D8A7E0
	}

	public static class Quaternionex // TypeDefIndex: 58541
	{
		// Extension methods
		public static Quaternion DeltaTo(this Quaternion quat, Quaternion target); // 0x0000000186937CB4-0x0000000186937D1C
		public static string ToStringEx(this Quaternion quat); // 0x0000000186937D1C-0x0000000186937E38
	}

	public class Rand // TypeDefIndex: 58542
	{
		// Fields
		private const int a = 5; // Metadata: 0x0234BCE9
		private const int b = 14; // Metadata: 0x0234BCEA
		private const int c = 1; // Metadata: 0x0234BCEB
		private const uint DefaultY = 273326509; // Metadata: 0x0234BCEC
		private const uint DefaultZ = 3579807591; // Metadata: 0x0234BCF0
		private const uint DefaultW = 842502087; // Metadata: 0x0234BCF5
		private const uint PositiveMask = 2147483647; // Metadata: 0x0234BCFA
		private const uint BoolModuloMask = 1; // Metadata: 0x0234BCFF
		private const uint ByteModuloMask = 255; // Metadata: 0x0234BD00
		private const double One_div_uintMaxValuePlusOne = 2.3283064365386963E-10; // Metadata: 0x0234BD02
		private const double TwoPi = 6.283185307179586; // Metadata: 0x0234BD0A
		private static Rand _seedGenerator; // 0x00
		private uint _x; // 0x10
		private uint _y; // 0x14
		private uint _z; // 0x18
		private uint _w; // 0x1C
		public static Rand Instance; // 0x08
	
		// Constructors
		static Rand(); // 0x0000000186938E74-0x0000000186938F44
		public Rand(); // 0x0000000186938F44-0x0000000186938FBC
		public Rand(int seed); // 0x0000000184D8B5A0-0x0000000184D8B5C0
	
		// Methods
		public void ResetSeed(int seed); // 0x0000000184D8B5A0-0x0000000184D8B5C0
		public void GetState(out uint x, out uint y, out uint z, out uint w); // 0x0000000184D8B420-0x0000000184D8B440
		public void SetState(uint x, uint y, uint z, uint w); // 0x0000000184D8B5C0-0x0000000184D8B5E0
		public int NextInt(); // 0x0000000184D8B440-0x0000000184D8B470
		public int NextInt(int max); // 0x0000000184D8B500-0x0000000184D8B560
		public int NextInt(int min, int max); // 0x0000000186938610-0x00000001869386F0
		public int NextIntInclusive(int min, int max); // 0x0000000186938604-0x0000000186938610
		public int NextPositiveInt(); // 0x0000000184D8B560-0x0000000184D8B5A0
		public uint NextUInt(); // 0x0000000184D8B440-0x0000000184D8B470
		public double NextDouble(); // 0x0000000184D8B470-0x0000000184D8B4B0
		public double NextDouble(double min, double max); // 0x0000000186938480-0x0000000186938540
		public float NextFloat(); // 0x0000000184D8B4B0-0x0000000184D8B500
		public float NextFloat(float min, float max); // 0x0000000186938540-0x0000000186938604
		public bool NextBool(); // 0x000000018693844C-0x0000000186938480
		public byte NextByte(); // 0x0000000184D8B440-0x0000000184D8B470
		public UnityEngine.Color RandomColorOpaque(); // 0x0000000186938C58-0x0000000186938CC4
		public UnityEngine.Color RandomColorTransparent(); // 0x0000000186938CC4-0x0000000186938D48
		public Color32 RandomColor32Opaque(); // 0x0000000186938BC4-0x0000000186938C04
		public Color32 RandomColor32Transparent(); // 0x0000000186938C04-0x0000000186938C58
		public float RandomAngleRadians(); // 0x0000000186938BAC-0x0000000186938BC4
		public float RandomAngleDegrees(); // 0x0000000186938B94-0x0000000186938BAC
		public Vector2 InSquare(float side = 1f /* Metadata: 0x0234BCC9 */); // 0x00000001869380E0-0x0000000186938154
		public Vector2 OnSquare(float side = 1f /* Metadata: 0x0234BCCD */); // 0x0000000186938A5C-0x0000000186938B94
		public Vector3 InCube(float side = 1f /* Metadata: 0x0234BCD1 */); // 0x0000000186937F50-0x0000000186938000
		public Vector3 OnCube(float side = 1f /* Metadata: 0x0234BCD5 */); // 0x000000018693874C-0x0000000186938990
		public Vector2 InCircle(float radius = 1f /* Metadata: 0x0234BCD9 */); // 0x0000000186937ED8-0x0000000186937F50
		public Vector2 InCircle(float radiusMin, float radiusMax); // 0x0000000186937E38-0x0000000186937ED8
		public Vector2 OnCircle(float radius = 1f /* Metadata: 0x0234BCDD */); // 0x00000001869386F0-0x000000018693874C
		public Vector3 InSphere(float radius = 1f /* Metadata: 0x0234BCE1 */); // 0x0000000186938000-0x00000001869380E0
		public Vector3 OnSphere(float radius = 1f /* Metadata: 0x0234BCE5 */); // 0x0000000186938990-0x0000000186938A5C
		public Vector3 InTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x00000001869382D0-0x000000018693844C
		public Vector3 InTriangle(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000186938154-0x00000001869382D0
		public Quaternion RandomRotation(); // 0x0000000186938D48-0x0000000186938E74
	}

	public static class Vector2ex // TypeDefIndex: 58544
	{
		// Fields
		public static readonly Vector2 Zero; // 0x00
		public static readonly Vector2 One; // 0x08
		public static readonly Vector2 UnitX; // 0x10
		public static readonly Vector2 UnitY; // 0x18
		public static readonly Vector2 PositiveInfinity; // 0x20
		public static readonly Vector2 NegativeInfinity; // 0x28
	
		// Nested types
		internal class Information // TypeDefIndex: 58543
		{
			// Fields
			public int Dimension; // 0x10
			public Vector2 Min; // 0x14
			public Vector2 Max; // 0x1C
			public float MaxRange; // 0x24
			public Vector2 Origin; // 0x28
			public Vector2[] Direction; // 0x30
			public int[] Extreme; // 0x38
			public bool ExtremeCCW; // 0x40
	
			// Constructors
			public Information(); // 0x0000000186934844-0x00000001869348B8
		}
	
		// Constructors
		static Vector2ex(); // 0x000000018693ABBC-0x000000018693AC6C
	
		// Methods
		internal static Information GetInformation(IList<Vector2> points, float epsilon); // 0x000000018693A3C8-0x000000018693AA04
		public static float DotPerp(ref Vector2 vector, ref Vector2 value); // 0x0000000184D8B600-0x0000000184D8B620
		public static float Dot(ref Vector2 vector, ref Vector2 value); // 0x0000000184D8B670-0x0000000184D8B690
		public static float Normalize(ref Vector2 vector, float epsilon = 1E-05f /* Metadata: 0x0234BD12 */); // 0x000000018693AA7C-0x000000018693AAEC
		public static float SetLength(ref Vector2 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x0234BD16 */); // 0x000000018693AAEC-0x000000018693AB60
		public static float GrowLength(ref Vector2 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x0234BD1A */); // 0x000000018693AA04-0x000000018693AA7C
		public static Vector2 Replicate(float value); // 0x0000000184D8B720-0x0000000184D8B730
	
		// Extension methods
		public static float Length(this Vector2 vector); // 0x0000000184D8B6B0-0x0000000184D8B6F0
		public static float LengthSqr(this Vector2 vector); // 0x0000000184D8B690-0x0000000184D8B6B0
		public static float DotPerp(this Vector2 vector, Vector2 value); // 0x0000000184D85F20-0x0000000184D85F50
		public static float DotPerp(this Vector2 vector, ref Vector2 value); // 0x0000000184D8B5E0-0x0000000184D8B600
		public static float Dot(this Vector2 vector, Vector2 value); // 0x0000000184D8B640-0x0000000184D8B670
		public static float Dot(this Vector2 vector, ref Vector2 value); // 0x0000000184D8B620-0x0000000184D8B640
		public static Vector2 Perp(this Vector2 vector); // 0x0000000184D8B6F0-0x0000000184D8B720
		public static float AngleDeg(this Vector2 vector, Vector2 target); // 0x000000018693A268-0x000000018693A31C
		public static float AngleRad(this Vector2 vector, Vector2 target); // 0x000000018693A31C-0x000000018693A3C8
		public static Vector3 ToVector3XY(this Vector2 vector); // 0x0000000184D88A10-0x0000000184D88A40
		public static Vector3 ToVector3XZ(this Vector2 vector); // 0x0000000184D88A60-0x0000000184D88A90
		public static Vector3 ToVector3YZ(this Vector2 vector); // 0x0000000184D8B730-0x0000000184D8B760
		public static string ToStringEx(this Vector2 vector); // 0x000000018693AB60-0x000000018693ABBC
	}

	public enum ProjectionPlanes // TypeDefIndex: 58545
	{
		XY = 0,
		XZ = 1,
		YZ = 2
	}

	public static class Vector3ex // TypeDefIndex: 58547
	{
		// Fields
		public static readonly Vector3 Zero; // 0x00
		public static readonly Vector3 One; // 0x0C
		public static readonly Vector3 UnitX; // 0x18
		public static readonly Vector3 UnitY; // 0x24
		public static readonly Vector3 UnitZ; // 0x30
		public static readonly Vector3 PositiveInfinity; // 0x3C
		public static readonly Vector3 NegativeInfinity; // 0x48
	
		// Nested types
		internal class Information // TypeDefIndex: 58546
		{
			// Fields
			public int Dimension; // 0x10
			public Vector3 Min; // 0x14
			public Vector3 Max; // 0x20
			public float MaxRange; // 0x2C
			public Vector3 Origin; // 0x30
			public Vector3[] Direction; // 0x40
			public int[] Extreme; // 0x48
			public bool ExtremeCCW; // 0x50
	
			// Constructors
			public Information(); // 0x00000001869348B8-0x000000018693492C
		}
	
		// Constructors
		static Vector3ex(); // 0x000000018693C2CC-0x000000018693C3E0
	
		// Methods
		internal static Information GetInformation(IList<Vector3> points, float epsilon); // 0x000000018693AF04-0x000000018693BAC0
		public static float Dot(ref Vector3 vector, ref Vector3 value); // 0x0000000184D8B7C0-0x0000000184D8B7F0
		public static Vector3 Cross(ref Vector3 vector, ref Vector3 value); // 0x0000000184D8B760-0x0000000184D8B7C0
		public static Vector3 UnitCross(ref Vector3 vector, ref Vector3 value); // 0x000000018693C20C-0x000000018693C2CC
		public static float Normalize(ref Vector3 vector, float epsilon = 1E-05f /* Metadata: 0x0234BD21 */); // 0x000000018693BB94-0x000000018693BC20
		public static float SetLength(ref Vector3 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x0234BD25 */); // 0x000000018693BCA4-0x000000018693BD34
		public static float GrowLength(ref Vector3 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x0234BD29 */); // 0x000000018693BB00-0x000000018693BB94
		public static Vector3 Replicate(float value); // 0x0000000184D8B860-0x0000000184D8B880
		public static void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, ref Vector3 w); // 0x000000018693ADDC-0x000000018693AF04
		public static bool SameDirection(Vector3 value0, Vector3 value1); // 0x000000018693BC20-0x000000018693BCA4
	
		// Extension methods
		public static float Length(this Vector3 vector); // 0x0000000184D8B820-0x0000000184D8B860
		public static float LengthSqr(this Vector3 vector); // 0x0000000184D8B7F0-0x0000000184D8B820
		public static float Dot(this Vector3 vector, Vector3 value); // 0x0000000184D8B7C0-0x0000000184D8B7F0
		public static float Dot(this Vector3 vector, ref Vector3 value); // 0x0000000184D8B7C0-0x0000000184D8B7F0
		public static float AngleDeg(this Vector3 vector, Vector3 target); // 0x000000018693AC6C-0x000000018693AD28
		public static float AngleRad(this Vector3 vector, Vector3 target); // 0x000000018693AD28-0x000000018693ADDC
		public static float SignedAngleDeg(this Vector3 vector, Vector3 target, Vector3 normal); // 0x000000018693BD34-0x000000018693BE94
		public static float SignedAngleRad(this Vector3 vector, Vector3 target, Vector3 normal); // 0x000000018693BE94-0x000000018693BFEC
		public static Vector3 Cross(this Vector3 vector, Vector3 value); // 0x0000000184D8B760-0x0000000184D8B7C0
		public static Vector3 Cross(this Vector3 vector, ref Vector3 value); // 0x0000000184D8B760-0x0000000184D8B7C0
		public static Vector3 UnitCross(this Vector3 vector, Vector3 value); // 0x000000018693C154-0x000000018693C20C
		public static Vector3 UnitCross(this Vector3 vector, ref Vector3 value); // 0x000000018693C094-0x000000018693C154
		public static Vector2 ToVector2XY(this Vector3 vector); // 0x0000000184D889F0-0x0000000184D88A10
		public static Vector2 ToVector2XZ(this Vector3 vector); // 0x0000000184D88A40-0x0000000184D88A60
		public static Vector2 ToVector2YZ(this Vector3 vector); // 0x0000000184D8B880-0x0000000184D8B8A0
		public static Vector2 ToVector2(this Vector3 vector, ProjectionPlanes projectionPlane); // 0x000000018693C06C-0x000000018693C094
		public static ProjectionPlanes GetProjectionPlane(this Vector3 vector); // 0x000000018693BAC0-0x000000018693BB00
		public static string ToStringEx(this Vector3 vector); // 0x000000018693BFEC-0x000000018693C06C
	}

	public struct BrentsRoot // TypeDefIndex: 58548
	{
		// Fields
		public float X; // 0x00
		public int Iterations; // 0x04
		public bool ExceededMaxIterations; // 0x08
	}

	public static class RootFinder // TypeDefIndex: 58550
	{
		// Fields
		private const float third = 0.33333334f; // Metadata: 0x0234BD5D
		private const float twentySeventh = 0.037037037f; // Metadata: 0x0234BD61
		private static float sqrt3; // 0x00
	
		// Nested types
		private class PolyRootFinder // TypeDefIndex: 58549
		{
			// Fields
			private int _count; // 0x10
			private int _maxRoot; // 0x14
			private float[] _roots; // 0x18
			private float _epsilon; // 0x20
	
			// Properties
			public float[] Roots { get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			public PolyRootFinder(float epsilon); // 0x00000001869469A0-0x0000000186946A04
	
			// Methods
			public bool Bisection(Polynomial poly, float xMin, float xMax, int digits, out float root); // 0x00000001869463D0-0x0000000186946570
			public bool Find(Polynomial poly, float xMin, float xMax, int digits); // 0x0000000186946570-0x00000001869469A0
		}
	
		// Constructors
		static RootFinder(); // 0x000000018693A050-0x000000018693A094
	
		// Methods
		public static bool BrentsMethod(Func<float, float> function, float x0, float x1, out BrentsRoot root, int maxIterations = 128 /* Metadata: 0x0234BD2D */, float negativeTolerance = -1E-05f /* Metadata: 0x0234BD2F */, float positiveTolerance = 1E-05f /* Metadata: 0x0234BD33 */, float stepTolerance = 1E-05f /* Metadata: 0x0234BD37 */, float segmentTolerance = 1E-05f /* Metadata: 0x0234BD3B */); // 0x0000000186938FBC-0x0000000186939394
		public static bool Linear(float c0, float c1, out float root, float epsilon = 1E-05f /* Metadata: 0x0234BD3F */); // 0x0000000186939750-0x000000018693977C
		public static bool Quadratic(float c0, float c1, float c2, out QuadraticRoots roots, float epsilon = 1E-05f /* Metadata: 0x0234BD43 */); // 0x0000000186939A14-0x0000000186939B9C
		public static bool Cubic(float c0, float c1, float c2, float c3, out CubicRoots roots, float epsilon = 1E-05f /* Metadata: 0x0234BD47 */); // 0x0000000186939394-0x0000000186939750
		public static bool Quartic(float c0, float c1, float c2, float c3, float c4, out QuarticRoots roots, float epsilon = 1E-05f /* Metadata: 0x0234BD4B */); // 0x0000000186939B9C-0x000000018693A050
		public static float PolynomialBound(Polynomial poly, float epsilon = 1E-05f /* Metadata: 0x0234BD4F */); // 0x000000018693977C-0x0000000186939848
		public static bool Polynomial(Polynomial poly, float xMin, float xMax, out float[] roots, int digits = 6 /* Metadata: 0x0234BD53 */, float epsilon = 1E-05f /* Metadata: 0x0234BD54 */); // 0x000000018693992C-0x0000000186939A14
		public static bool Polynomial(Polynomial poly, out float[] roots, int digits = 6 /* Metadata: 0x0234BD58 */, float epsilon = 1E-05f /* Metadata: 0x0234BD59 */); // 0x0000000186939848-0x000000018693992C
	}

	public class EigenData // TypeDefIndex: 58551
	{
		// Fields
		private int _size; // 0x10
		private float[] _diagonal; // 0x18
		private float[,] _matrix; // 0x20
	
		// Properties
		public int Size { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
	
		// Constructors
		internal EigenData(float[] diagonal, float[,] matrix); // 0x0000000186941A3C-0x0000000186941A78
	
		// Methods
		public float GetEigenvalue(int index); // 0x0000000186920148-0x0000000186920178
		public Vector2 GetEigenvector2(int index); // 0x000000018694179C-0x0000000186941854
		public Vector3 GetEigenvector3(int index); // 0x0000000186941854-0x0000000186941924
		public float[] GetEigenvector(int index); // 0x0000000186941924-0x00000001869419C8
		public void GetEigenvector(int index, float[] out_eigenvector); // 0x00000001869419C8-0x0000000186941A3C
	}

	public static class EigenDecomposition // TypeDefIndex: 58552
	{
		// Methods
		private static void Tridiagonal2(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation); // 0x00000001869423D4-0x00000001869424E8
		private static void Tridiagonal3(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation); // 0x00000001869424E8-0x000000018694285C
		private static void TridiagonalN(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation); // 0x000000018694285C-0x0000000186942EE8
		private static bool QLAlgorithm(float[] diagonal, float[] subdiagonal, float[,] matrix); // 0x0000000186941DB4-0x0000000186942224
		private static void IncreasingSort(float[] diagonal, float[] subdiagonal, float[,] matrix, ref bool isRotation); // 0x0000000186941C50-0x0000000186941DB4
		private static void DecreasingSort(float[] diagonal, float[] subdiagonal, float[,] matrix, ref bool isRotation); // 0x0000000186941A78-0x0000000186941BE0
		private static void GuaranteeRotation(float[,] matrix, bool isRotation); // 0x0000000186941BE0-0x0000000186941C50
		public static EigenData Solve(float[,] symmetricSquareMatrix, bool increasingSort); // 0x0000000186942224-0x00000001869423D4
	}

	public static class Integrator // TypeDefIndex: 58553
	{
		// Fields
		private const int _degree = 5; // Metadata: 0x0234BD65
		private static float[] root; // 0x00
		private static float[] coeff; // 0x08
	
		// Constructors
		static Integrator(); // 0x0000000186943374-0x0000000186943458
	
		// Methods
		public static float TrapezoidRule(Func<float, float> function, float a, float b, int sampleCount); // 0x0000000186943270-0x0000000186943374
		public static float RombergIntegral(Func<float, float> function, float a, float b, int order); // 0x0000000186943004-0x0000000186943270
		public static float GaussianQuadrature(Func<float, float> function, float a, float b); // 0x0000000186942EE8-0x0000000186943004
	}

	public static class LinearSystem // TypeDefIndex: 58554
	{
		// Methods
		public static bool Solve2(float[,] A, float[] B, out float[] X, float zeroTolerance = 1E-05f /* Metadata: 0x0234BD66 */); // 0x00000001869447D0-0x00000001869449D8
		public static bool Solve2(float[,] A, float[] B, out Vector2 X, float zeroTolerance = 1E-05f /* Metadata: 0x0234BD6A */); // 0x00000001869449D8-0x0000000186944AAC
		public static bool Solve3(float[,] A, float[] B, out float[] X, float zeroTolerance = 1E-05f /* Metadata: 0x0234BD6E */); // 0x0000000186944B8C-0x00000001869452A0
		public static bool Solve3(float[,] A, float[] B, out Vector3 X, float zeroTolerance = 1E-05f /* Metadata: 0x0234BD72 */); // 0x0000000186944AAC-0x0000000186944B8C
		private static void SwapRows(float[,] matrix, int row0, int row1, int columnCount); // 0x0000000186945A34-0x0000000186945ADC
		public static bool Solve(float[,] A, float[] B, out float[] X); // 0x0000000186945548-0x0000000186945A34
		public static bool SolveTridiagonal(float[] A, float[] B, float[] C, float[] R, out float[] U); // 0x00000001869452A0-0x0000000186945548
		public static bool Inverse(float[,] A, out float[,] invA); // 0x0000000186944308-0x00000001869447D0
	}

	public delegate void OdeFunction(float t, float[] y, float[] F); // TypeDefIndex: 58555; 0x0000000186945C38-0x0000000186945C4C

	public abstract class OdeSolver // TypeDefIndex: 58556
	{
		// Fields
		protected int _dim; // 0x10
		protected float _step; // 0x14
		protected OdeFunction _function; // 0x18
		protected float[] _FValue; // 0x20
	
		// Properties
		public virtual float Step { get; set; } // 0x0000000184D88D40-0x0000000184D88D50 0x0000000184D88D50-0x0000000184D88D60
	
		// Constructors
		public OdeSolver(int dim, float step, OdeFunction function); // 0x0000000186946350-0x00000001869463D0
	
		// Methods
		public abstract void Update(float tIn, float[] yIn, ref float tOut, float[] yOut);
	}

	public class OdeEuler : OdeSolver // TypeDefIndex: 58557
	{
		// Constructors
		public OdeEuler(int dim, float step, OdeFunction function); // 0x0000000186945BA0-0x0000000186945BB0
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut); // 0x0000000186945ADC-0x0000000186945BA0
	}

	public class OdeMidpoint : OdeSolver // TypeDefIndex: 58558
	{
		// Fields
		private float _halfStep; // 0x28
		private float[] _yTemp; // 0x30
	
		// Properties
		public override float Step { get; set; } // 0x0000000184D88D40-0x0000000184D88D50 0x0000000184D8BF40-0x0000000184D8BF60
	
		// Constructors
		public OdeMidpoint(int dim, float step, OdeFunction function); // 0x0000000186945E74-0x0000000186945F08
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut); // 0x0000000186945D14-0x0000000186945E74
	}

	public class OdeRungeKutta4 : OdeSolver // TypeDefIndex: 58559
	{
		// Fields
		private float _halfStep; // 0x28
		private float _sixthStep; // 0x2C
		private float[] _temp1; // 0x30
		private float[] _temp2; // 0x38
		private float[] _temp3; // 0x40
		private float[] _temp4; // 0x48
		private float[] _yTemp; // 0x50
	
		// Properties
		public override float Step { get; set; } // 0x0000000184D88D40-0x0000000184D88D50 0x000000018694632C-0x0000000186946350
	
		// Constructors
		public OdeRungeKutta4(int dim, float step, OdeFunction function); // 0x000000018694621C-0x000000018694632C
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut); // 0x0000000186945F08-0x000000018694621C
	}

	public struct QuadraticRoots // TypeDefIndex: 58560
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public int RootCount; // 0x08
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x00000001869488E0-0x0000000186948900 
	}

	public struct CubicRoots // TypeDefIndex: 58561
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public float X2; // 0x08
		public int RootCount; // 0x0C
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x0000000186941774-0x000000018694179C 
	}

	public struct QuarticRoots // TypeDefIndex: 58562
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public float X2; // 0x08
		public float X3; // 0x0C
		public int RootCount; // 0x10
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x0000000186948900-0x0000000186948934 
	}

	public struct AAB2 // TypeDefIndex: 58563
	{
		// Fields
		public Vector2 Min; // 0x00
		public Vector2 Max; // 0x08
	
		// Constructors
		public AAB2(ref Vector2 min, ref Vector2 max); // 0x0000000184D8B9B0-0x0000000184D8B9D0
		public AAB2(Vector2 min, Vector2 max); // 0x0000000184D861B0-0x0000000184D861C0
		public AAB2(float xMin, float xMax, float yMin, float yMax); // 0x0000000184D8B9D0-0x0000000184D8B9F0
	
		// Methods
		public static implicit operator Rect(AAB2 value); // 0x000000018693CAC8-0x000000018693CB0C
		public static implicit operator AAB2(Rect value); // 0x0000000184D8B9F0-0x0000000184D8BA30
		public static AAB2 CreateFromPoint(ref Vector2 point); // 0x0000000184D8B980-0x0000000184D8B9B0
		public static AAB2 CreateFromPoint(Vector2 point); // 0x0000000184D8B970-0x0000000184D8B980
		public static AAB2 CreateFromTwoPoints(ref Vector2 point0, ref Vector2 point1); // 0x000000018693C8A4-0x000000018693C8F0
		public static AAB2 CreateFromTwoPoints(Vector2 point0, Vector2 point1); // 0x000000018693C868-0x000000018693C8A4
		public static AAB2 CreateFromPoints(IEnumerable<Vector2> points); // 0x000000018693C624-0x000000018693C75C
		public static AAB2 CreateFromPoints(IList<Vector2> points); // 0x000000018693C75C-0x000000018693C868
		public static AAB2 CreateFromPoints(Vector2[] points); // 0x000000018693C568-0x000000018693C624
		public void CalcCenterExtents(out Vector2 center, out Vector2 extents); // 0x0000000184D8B8C0-0x0000000184D8B920
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3); // 0x0000000184D8B920-0x0000000184D8B970
		public Vector2[] CalcVertices(); // 0x000000018693C3E0-0x000000018693C4A0
		public void CalcVertices(Vector2[] array); // 0x000000018693C4A0-0x000000018693C530
		public float CalcArea(); // 0x0000000184D8B8A0-0x0000000184D8B8C0
		public float DistanceTo(Vector2 point); // 0x000000018693C8F0-0x000000018693C910
		public Vector2 Project(Vector2 point); // 0x000000018693CA00-0x000000018693CA30
		public bool Contains(ref Vector2 point); // 0x000000018355A9C0-0x000000018355A9F0
		public bool Contains(Vector2 point); // 0x000000018693C530-0x000000018693C568
		public void Include(ref Vector2 point); // 0x000000018693C9C0-0x000000018693CA00
		public void Include(Vector2 point); // 0x000000018693C910-0x000000018693C958
		public void Include(ref AAB2 box); // 0x000000018693C98C-0x000000018693C9C0
		public void Include(AAB2 box); // 0x000000018693C958-0x000000018693C98C
		public override string ToString(); // 0x000000018693CA30-0x000000018693CAC8
	}

	public struct Box2 // TypeDefIndex: 58564
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Axis0; // 0x08
		public Vector2 Axis1; // 0x10
		public Vector2 Extents; // 0x18
	
		// Constructors
		public Box2(ref Vector2 center, ref Vector2 axis0, ref Vector2 axis1, ref Vector2 extents); // 0x0000000184D8BC60-0x0000000184D8BCB0
		public Box2(Vector2 center, Vector2 axis0, Vector2 axis1, Vector2 extents); // 0x0000000184D8BCB0-0x0000000184D8BCD0
		public Box2(ref AAB2 box); // 0x000000018693E578-0x000000018693E614
		public Box2(AAB2 box); // 0x000000018693E614-0x000000018693E6B0
	
		// Methods
		public static Box2 CreateFromPoints(IList<Vector2> points); // 0x000000018693DB34-0x000000018693DEB0
		public Vector2 GetAxis(int index); // 0x000000018693DED0-0x000000018693DF54
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3); // 0x000000018693D568-0x000000018693D63C
		public Vector2[] CalcVertices(); // 0x000000018693D63C-0x000000018693D7E8
		public void CalcVertices(Vector2[] array); // 0x000000018693D7E8-0x000000018693D950
		public float CalcArea(); // 0x0000000184D8BC40-0x0000000184D8BC60
		public float DistanceTo(Vector2 point); // 0x000000018693DEB0-0x000000018693DED0
		public Vector2 Project(Vector2 point); // 0x000000018693E3DC-0x000000018693E40C
		public bool Contains(ref Vector2 point); // 0x000000018693D950-0x000000018693DA44
		public bool Contains(Vector2 point); // 0x000000018693DA44-0x000000018693DB34
		public void Include(ref Box2 box); // 0x000000018693DF54-0x000000018693E3C8
		public void Include(Box2 box); // 0x000000018693E3C8-0x000000018693E3DC
		public override string ToString(); // 0x000000018693E40C-0x000000018693E578
	}

	public struct Circle2 // TypeDefIndex: 58565
	{
		// Fields
		public Vector2 Center; // 0x00
		public float Radius; // 0x08
	
		// Constructors
		public Circle2(ref Vector2 center, float radius); // 0x0000000184D8BEB0-0x0000000184D8BEC0
		public Circle2(Vector2 center, float radius); // 0x0000000184D8BEC0-0x0000000184D8BED0
	
		// Methods
		public static Circle2 CreateFromPointsAAB(IEnumerable<Vector2> points); // 0x0000000186940D78-0x0000000186940E88
		public static Circle2 CreateFromPointsAAB(IList<Vector2> points); // 0x0000000186940CB0-0x0000000186940D78
		public static Circle2 CreateFromPointsAverage(IEnumerable<Vector2> points); // 0x000000018694105C-0x0000000186941390
		public static Circle2 CreateFromPointsAverage(IList<Vector2> points); // 0x0000000186940E88-0x000000018694105C
		public static bool CreateCircumscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle); // 0x0000000186940A94-0x0000000186940CB0
		public static bool CreateInscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle); // 0x0000000186941390-0x00000001869415A0
		public float CalcPerimeter(); // 0x0000000184D8BDD0-0x0000000184D8BDE0
		public float CalcArea(); // 0x0000000184D8BDB0-0x0000000184D8BDD0
		public Vector2 Eval(float t); // 0x0000000184D8BDE0-0x0000000184D8BE40
		public Vector2 Eval(float t, float radius); // 0x0000000184D8BE40-0x0000000184D8BEB0
		public float DistanceTo(Vector2 point); // 0x00000001869415A0-0x00000001869415C0
		public Vector2 Project(Vector2 point); // 0x00000001869416BC-0x00000001869416EC
		public bool Contains(ref Vector2 point); // 0x0000000186940A4C-0x0000000186940A94
		public bool Contains(Vector2 point); // 0x0000000186940A00-0x0000000186940A4C
		public void Include(ref Circle2 circle); // 0x00000001869415D4-0x00000001869416BC
		public void Include(Circle2 circle); // 0x00000001869415C0-0x00000001869415D4
		public override string ToString(); // 0x00000001869416EC-0x0000000186941774
	}

	public struct Line2 // TypeDefIndex: 58566
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Line2(ref Vector2 center, ref Vector2 direction); // 0x0000000184D8B9B0-0x0000000184D8B9D0
		public Line2(Vector2 center, Vector2 direction); // 0x0000000184D861B0-0x0000000184D861C0
	
		// Methods
		public static Line2 CreateFromTwoPoints(ref Vector2 p0, ref Vector2 p1); // 0x0000000186943568-0x00000001869435D4
		public static Line2 CreateFromTwoPoints(Vector2 p0, Vector2 p1); // 0x000000018694351C-0x0000000186943568
		public static Line2 CreatePerpToLineTrhoughPoint(Line2 line, Vector2 point); // 0x0000000186943638-0x00000001869436BC
		public static Line2 CreateBetweenAndEquidistantToPoints(Vector2 point0, Vector2 point1); // 0x0000000184D8BED0-0x0000000184D8BF40
		public static Line2 CreateParallelToGivenLineAtGivenDistance(Line2 line, float distance); // 0x00000001869435D4-0x0000000186943638
		public Vector2 Eval(float t); // 0x00000001869436DC-0x000000018694370C
		public float SignedDistanceTo(Vector2 point); // 0x00000001869441EC-0x0000000186944270
		public float DistanceTo(Vector2 point); // 0x00000001869436BC-0x00000001869436DC
		public int QuerySide(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0234BD76 */); // 0x0000000186943F0C-0x0000000186943FC8
		public bool QuerySideNegative(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0234BD7A */); // 0x000000018694373C-0x00000001869437D0
		public bool QuerySidePositive(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0234BD7E */); // 0x0000000186943B10-0x0000000186943BAC
		public int QuerySide(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x0234BD82 */); // 0x000000018694409C-0x00000001869441EC
		public bool QuerySideNegative(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x0234BD86 */); // 0x0000000186943898-0x00000001869439C8
		public bool QuerySidePositive(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x0234BD8A */); // 0x0000000186943BAC-0x0000000186943CD4
		public int QuerySide(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x0234BD8E */); // 0x0000000186943DA4-0x0000000186943F0C
		public bool QuerySideNegative(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x0234BD92 */); // 0x00000001869437D0-0x0000000186943898
		public bool QuerySidePositive(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x0234BD96 */); // 0x0000000186943CD4-0x0000000186943DA4
		public int QuerySide(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x0234BD9A */); // 0x0000000186943FC8-0x000000018694409C
		public bool QuerySideNegative(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x0234BD9E */); // 0x00000001869439C8-0x0000000186943A70
		public bool QuerySidePositive(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x0234BDA2 */); // 0x0000000186943A70-0x0000000186943B10
		public Vector2 Project(Vector2 point); // 0x000000018694370C-0x000000018694373C
		public float AngleBetweenTwoLines(Line2 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x0234BDA6 */); // 0x0000000186943458-0x000000018694351C
		public override string ToString(); // 0x0000000186944270-0x0000000186944308
	}

	public struct Edge2 // TypeDefIndex: 58567
	{
		// Fields
		public Vector2 Point0; // 0x00
		public Vector2 Point1; // 0x08
		public Vector2 Direction; // 0x10
		public Vector2 Normal; // 0x18
		public float Length; // 0x20
	}

	public class Polygon2 // TypeDefIndex: 58568
	{
		// Fields
		private Vector2[] _vertices; // 0x10
		private Edge2[] _edges; // 0x18
	
		// Properties
		public Vector2[] Vertices { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public Edge2[] Edges { get; } // 0x000000018385B100-0x000000018385B110 
		public int VertexCount { get; } // 0x00000001867B6CAC-0x00000001867B6CC8 
		public Vector2 this[int vertexIndex] { get => default; set {} } // 0x000000018694886C-0x0000000186948898 0x0000000186948898-0x00000001869488E0
	
		// Constructors
		private Polygon2(); // 0x00000001841E1670-0x00000001841E1680
		public Polygon2(Vector2[] vertices); // 0x000000018694874C-0x00000001869487F0
		public Polygon2(int vertexCount); // 0x00000001869487F0-0x000000018694886C
	
		// Methods
		public static Polygon2 CreateProjected(Polygon3 polygon, ProjectionPlanes projectionPlane); // 0x0000000186947664-0x0000000186947878
		public Edge2 GetEdge(int edgeIndex); // 0x0000000186947878-0x00000001869478C8
		public void UpdateEdges(); // 0x000000018694858C-0x000000018694874C
		public void UpdateEdge(int edgeIndex); // 0x00000001869483EC-0x000000018694858C
		public Vector2 CalcCenter(); // 0x0000000186946B94-0x0000000186946C5C
		public float CalcPerimeter(); // 0x0000000186946C5C-0x0000000186946CC4
		public float CalcArea(); // 0x0000000186946A04-0x0000000186946B94
		public bool IsConvex(out Orientations orientation, float threshold = 1E-05f /* Metadata: 0x0234BDA7 */); // 0x00000001869479B4-0x0000000186947B30
		public bool IsConvex(float threshold = 1E-05f /* Metadata: 0x0234BDAB */); // 0x000000018694798C-0x00000001869479B4
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x0234BDAF */); // 0x00000001869478C8-0x000000018694798C
		public void ReverseVertices(); // 0x0000000186947B30-0x0000000186947C24
		public bool ContainsConvexQuadCCW(ref Vector2 point); // 0x0000000186946D58-0x0000000186947138
		public bool ContainsConvexQuadCCW(Vector2 point); // 0x0000000186946D3C-0x0000000186946D58
		public bool ContainsConvexQuadCW(ref Vector2 point); // 0x0000000186947138-0x0000000186947518
		public bool ContainsConvexQuadCW(Vector2 point); // 0x0000000186947518-0x0000000186947534
		public bool ContainsConvexCCW(ref Vector2 point); // 0x0000000186946CC4-0x0000000186946CE4
		public bool ContainsConvexCCW(Vector2 point); // 0x0000000186946CE4-0x0000000186946D00
		private bool SubContainsPointCCW(ref Vector2 p, int i0, int i1); // 0x0000000186947C24-0x0000000186947EA4
		public bool ContainsConvexCW(ref Vector2 point); // 0x0000000186946D00-0x0000000186946D20
		public bool ContainsConvexCW(Vector2 point); // 0x0000000186946D20-0x0000000186946D3C
		private bool SubContainsPointCW(ref Vector2 p, int i0, int i1); // 0x0000000186947EA4-0x0000000186948124
		public bool ContainsSimple(ref Vector2 point); // 0x0000000186947550-0x0000000186947664
		public bool ContainsSimple(Vector2 point); // 0x0000000186947534-0x0000000186947550
		public Segment2[] ToSegmentArray(); // 0x0000000186948124-0x0000000186948268
		public override string ToString(); // 0x0000000186948268-0x00000001869483EC
	}

	public struct Ray2 // TypeDefIndex: 58569
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Ray2(ref Vector2 center, ref Vector2 direction); // 0x0000000184D8B9B0-0x0000000184D8B9D0
		public Ray2(Vector2 center, Vector2 direction); // 0x0000000184D861B0-0x0000000184D861C0
	
		// Methods
		public Vector2 Eval(float t); // 0x00000001869436DC-0x000000018694370C
		public float DistanceTo(Vector2 point); // 0x0000000186948934-0x0000000186948954
		public Vector2 Project(Vector2 point); // 0x0000000186948954-0x0000000186948984
		public override string ToString(); // 0x0000000186948984-0x0000000186948A1C
	}

	public struct Segment2 // TypeDefIndex: 58570
	{
		// Fields
		public Vector2 P0; // 0x00
		public Vector2 P1; // 0x08
		public Vector2 Center; // 0x10
		public Vector2 Direction; // 0x18
		public float Extent; // 0x20
	
		// Constructors
		public Segment2(ref Vector2 p0, ref Vector2 p1); // 0x0000000186948E30-0x0000000186948E70
		public Segment2(Vector2 p0, Vector2 p1); // 0x0000000186948DEC-0x0000000186948E08
		public Segment2(ref Vector2 center, ref Vector2 direction, float extent); // 0x0000000186948E70-0x0000000186948ED4
		public Segment2(Vector2 center, Vector2 direction, float extent); // 0x0000000186948E08-0x0000000186948E30
	
		// Methods
		public void SetEndpoints(Vector2 p0, Vector2 p1); // 0x0000000186948C44-0x0000000186948C54
		public void SetCenterDirectionExtent(Vector2 center, Vector2 direction, float extent); // 0x0000000186948C30-0x0000000186948C44
		public void CalcCenterDirectionExtent(); // 0x0000000186948A1C-0x0000000186948AFC
		public void CalcEndPoints(); // 0x0000000186948AFC-0x0000000186948B94
		public Vector2 Eval(float s); // 0x0000000186948BB4-0x0000000186948C00
		public float DistanceTo(Vector2 point); // 0x0000000186948B94-0x0000000186948BB4
		public Vector2 Project(Vector2 point); // 0x0000000186948C00-0x0000000186948C30
		public override string ToString(); // 0x0000000186948C54-0x0000000186948DEC
	}

	public struct Triangle2 // TypeDefIndex: 58571
	{
		// Fields
		public Vector2 V0; // 0x00
		public Vector2 V1; // 0x08
		public Vector2 V2; // 0x10
	
		// Properties
		public Vector2 this[int index] { get => default; set {} } // 0x0000000186949DEC-0x0000000186949E2C 0x0000000186949E2C-0x0000000186949E48
	
		// Constructors
		public Triangle2(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x0000000184D8C0E0-0x0000000184D8C120
		public Triangle2(Vector2 v0, Vector2 v1, Vector2 v2); // 0x0000000184D8C0D0-0x0000000184D8C0E0
	
		// Methods
		public Vector2 CalcEdge(int edgeIndex); // 0x00000001869496A8-0x000000018694971C
		public float CalcDeterminant(); // 0x0000000184D8C070-0x0000000184D8C0D0
		public Orientations CalcOrientation(float threshold = 1E-05f /* Metadata: 0x0234BDB3 */); // 0x000000018694971C-0x000000018694975C
		public float CalcArea(); // 0x000000018694946C-0x000000018694948C
		public static float CalcArea(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x0000000184D8BF60-0x0000000184D8BFD0
		public static float CalcArea(Vector2 v0, Vector2 v1, Vector2 v2); // 0x0000000184D8BFD0-0x0000000184D8C070
		public Vector3 CalcAnglesDeg(); // 0x0000000186949028-0x000000018694917C
		public static Vector3 CalcAnglesDeg(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x0000000186948ED4-0x0000000186949028
		public static Vector3 CalcAnglesDeg(Vector2 v0, Vector2 v1, Vector2 v2); // 0x000000018694917C-0x00000001869491C4
		public Vector3 CalcAnglesRad(); // 0x000000018694933C-0x000000018694946C
		public static Vector3 CalcAnglesRad(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x000000018694920C-0x000000018694933C
		public static Vector3 CalcAnglesRad(Vector2 v0, Vector2 v1, Vector2 v2); // 0x00000001869491C4-0x000000018694920C
		public Vector2 EvalBarycentric(float c0, float c1); // 0x0000000186949A10-0x0000000186949AA8
		public Vector2 EvalBarycentric(ref Vector3 baryCoords); // 0x0000000186949AA8-0x0000000186949B24
		public Vector2 EvalBarycentric(Vector3 baryCoords); // 0x0000000186949AA8-0x0000000186949B24
		public static void CalcBarycentricCoords(ref Vector2 point, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2, out Vector3 baryCoords); // 0x00000001869494C4-0x000000018694966C
		public Vector3 CalcBarycentricCoords(ref Vector2 point); // 0x000000018694948C-0x00000001869494C4
		public Vector3 CalcBarycentricCoords(Vector2 point); // 0x000000018694966C-0x00000001869496A8
		public float DistanceTo(Vector2 point); // 0x00000001869499F0-0x0000000186949A10
		public int QuerySideCCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0234BDB7 */); // 0x0000000186949B54-0x0000000186949C38
		public int QuerySideCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0234BDBB */); // 0x0000000186949C38-0x0000000186949D28
		public Vector2 Project(Vector2 point); // 0x0000000186949B24-0x0000000186949B54
		public bool Contains(ref Vector2 point); // 0x00000001869498F4-0x00000001869499D4
		public bool Contains(Vector2 point); // 0x00000001869499D4-0x00000001869499F0
		public bool ContainsCCW(ref Vector2 point); // 0x0000000186949778-0x0000000186949828
		public bool ContainsCCW(Vector2 point); // 0x000000018694975C-0x0000000186949778
		public bool ContainsCW(ref Vector2 point); // 0x0000000186949844-0x00000001869498F4
		public bool ContainsCW(Vector2 point); // 0x0000000186949828-0x0000000186949844
		public override string ToString(); // 0x0000000186949D28-0x0000000186949DEC
	}

	public struct AAB3 // TypeDefIndex: 58572
	{
		// Fields
		public Vector3 Min; // 0x00
		public Vector3 Max; // 0x0C
	
		// Constructors
		public AAB3(ref Vector3 min, ref Vector3 max); // 0x0000000184D8BBF0-0x0000000184D8BC10
		public AAB3(Vector3 min, Vector3 max); // 0x0000000184D871E0-0x0000000184D87200
		public AAB3(float xMin, float xMax, float yMin, float yMax, float zMin, float zMax); // 0x0000000184D8BC10-0x0000000184D8BC40
	
		// Methods
		public static implicit operator Bounds(AAB3 value); // 0x000000018693D4FC-0x000000018693D568
		public static implicit operator AAB3(Bounds value); // 0x000000018693D498-0x000000018693D4FC
		public static AAB3 CreateFromPoint(ref Vector3 point); // 0x0000000184D8BBD0-0x0000000184D8BBF0
		public static AAB3 CreateFromPoint(Vector3 point); // 0x0000000184D8BBD0-0x0000000184D8BBF0
		public static AAB3 CreateFromTwoPoints(ref Vector3 point0, ref Vector3 point1); // 0x000000018693D260-0x000000018693D2D8
		public static AAB3 CreateFromTwoPoints(Vector3 point0, Vector3 point1); // 0x000000018693D230-0x000000018693D260
		public static AAB3 CreateFromPoints(IEnumerable<Vector3> points); // 0x000000018693CE7C-0x000000018693CFF4
		public static AAB3 CreateFromPoints(IList<Vector3> points); // 0x000000018693CFF4-0x000000018693D144
		public static AAB3 CreateFromPoints(Vector3[] points); // 0x000000018693D144-0x000000018693D230
		public void CalcCenterExtents(out Vector3 center, out Vector3 extents); // 0x0000000184D8BA30-0x0000000184D8BAB0
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7); // 0x0000000184D8BAB0-0x0000000184D8BBA0
		public Vector3[] CalcVertices(); // 0x000000018693CC88-0x000000018693CE34
		public void CalcVertices(Vector3[] array); // 0x000000018693CB0C-0x000000018693CC88
		public float CalcVolume(); // 0x0000000184D8BBA0-0x0000000184D8BBD0
		public float DistanceTo(Vector3 point); // 0x000000018693D2D8-0x000000018693D2F4
		public Vector3 Project(Vector3 point); // 0x000000018693D3C0-0x000000018693D3EC
		public bool Contains(ref Vector3 point); // 0x00000001833A4CF0-0x00000001833A4D40
		public bool Contains(Vector3 point); // 0x000000018693CE34-0x000000018693CE7C
		public void Include(ref Vector3 point); // 0x000000018693D2F4-0x000000018693D358
		public void Include(Vector3 point); // 0x000000018693D2F4-0x000000018693D358
		public void Include(ref AAB3 box); // 0x000000018693D358-0x000000018693D38C
		public void Include(AAB3 box); // 0x000000018693D38C-0x000000018693D3C0
		public override string ToString(); // 0x000000018693D3EC-0x000000018693D498
	}

	public struct Box3 // TypeDefIndex: 58573
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Axis2; // 0x24
		public Vector3 Extents; // 0x30
	
		// Constructors
		public Box3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, ref Vector3 axis2, ref Vector3 extents); // 0x0000000184D8BCF0-0x0000000184D8BD50
		public Box3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector3 axis2, Vector3 extents); // 0x0000000184D8BD50-0x0000000184D8BDB0
		public Box3(ref AAB3 box); // 0x00000001869408C4-0x0000000186940974
		public Box3(AAB3 box); // 0x0000000186940974-0x0000000186940A00
	
		// Methods
		public static Box3 CreateFromPoints(IList<Vector3> points); // 0x000000018693F94C-0x000000018693FEAC
		public Vector3 GetAxis(int index); // 0x000000018693FEC8-0x000000018693FF64
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7); // 0x000000018693F258-0x000000018693F7A0
		public Vector3[] CalcVertices(); // 0x000000018693E6B0-0x000000018693EC9C
		public void CalcVertices(Vector3[] array); // 0x000000018693EC9C-0x000000018693F258
		public float CalcVolume(); // 0x0000000184D8BCD0-0x0000000184D8BCF0
		public float DistanceTo(Vector3 point); // 0x000000018693FEAC-0x000000018693FEC8
		public Vector3 Project(Vector3 point); // 0x00000001869406D4-0x0000000186940700
		public bool Contains(ref Vector3 point); // 0x000000018693F7A0-0x000000018693F938
		public bool Contains(Vector3 point); // 0x000000018693F938-0x000000018693F94C
		public void Include(ref Box3 box); // 0x000000018693FF64-0x00000001869406C0
		public void Include(Box3 box); // 0x00000001869406C0-0x00000001869406D4
		public override string ToString(); // 0x0000000186940700-0x00000001869408C4
	}

	public struct Capsule3 // TypeDefIndex: 58574
	{
		// Fields
		public Segment3 Segment; // 0x00
		public float Radius; // 0x34
	
		// Constructors
		public Capsule3(ref Segment3 segment, float radius); // 0x0000000184D8C120-0x0000000184D8C150
		public Capsule3(Segment3 segment, float radius); // 0x0000000184D8C150-0x0000000184D8C180
	}

	public struct Circle3 // TypeDefIndex: 58575
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Normal; // 0x24
		public float Radius; // 0x30
	
		// Constructors
		public Circle3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, float radius); // 0x000000018694B958-0x000000018694BA4C
		public Circle3(Vector3 center, Vector3 axis0, Vector3 axis1, float radius); // 0x000000018694BA4C-0x000000018694BB2C
		public Circle3(ref Vector3 center, ref Vector3 normal, float radius); // 0x000000018694B8C4-0x000000018694B958
		public Circle3(Vector3 center, Vector3 normal, float radius); // 0x000000018694BB2C-0x000000018694BBC0
	
		// Methods
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle); // 0x000000018694AC08-0x000000018694AFA8
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle); // 0x000000018694AFA8-0x000000018694B488
		public float CalcPerimeter(); // 0x0000000184D8C1A0-0x0000000184D8C1B0
		public float CalcArea(); // 0x0000000184D8C180-0x0000000184D8C1A0
		public Vector3 Eval(float t); // 0x000000018694B4A4-0x000000018694B5BC
		public Vector3 Eval(float t, float radius); // 0x000000018694B5BC-0x000000018694B6E0
		public float DistanceTo(Vector3 point, bool solid = true /* Metadata: 0x0234BDBF */); // 0x000000018694B488-0x000000018694B4A4
		public Vector3 Project(Vector3 point, bool solid = true /* Metadata: 0x0234BDC0 */); // 0x000000018694B6E0-0x000000018694B710
		public override string ToString(); // 0x000000018694B710-0x000000018694B8C4
	}

	public struct Line3 // TypeDefIndex: 58576
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Line3(ref Vector3 center, ref Vector3 direction); // 0x0000000184D8BBF0-0x0000000184D8BC10
		public Line3(Vector3 center, Vector3 direction); // 0x0000000184D871E0-0x0000000184D87200
	
		// Methods
		public static Line3 CreateFromTwoPoints(ref Vector3 p0, ref Vector3 p1); // 0x000000018694F5BC-0x000000018694F648
		public static Line3 CreateFromTwoPoints(Vector3 p0, Vector3 p1); // 0x000000018694F5BC-0x000000018694F648
		public Vector3 Eval(float t); // 0x000000018694F664-0x000000018694F6E0
		public float DistanceTo(Vector3 point); // 0x000000018694F648-0x000000018694F664
		public Vector3 Project(Vector3 point); // 0x000000018694F6E0-0x000000018694F70C
		public float AngleBetweenTwoLines(Line3 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x0234BDC1 */); // 0x000000018694F4F4-0x000000018694F5BC
		public override string ToString(); // 0x000000018694F70C-0x000000018694F7B8
	}

	[Serializable]
	public struct Plane3 // TypeDefIndex: 58577
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float Constant; // 0x0C
	
		// Constructors
		public Plane3(ref Vector3 normal, float constant); // 0x0000000184D8C1B0-0x0000000184D8C1D0
		public Plane3(Vector3 normal, float constant); // 0x0000000184D8C1B0-0x0000000184D8C1D0
		public Plane3(ref Vector3 normal, ref Vector3 point); // 0x00000001869514E8-0x0000000186951594
		public Plane3(Vector3 normal, Vector3 point); // 0x0000000186951450-0x00000001869514E8
		public Plane3(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2); // 0x00000001869516DC-0x0000000186951824
		public Plane3(Vector3 p0, Vector3 p1, Vector3 p2); // 0x0000000186951594-0x00000001869516DC
	
		// Methods
		public static implicit operator Plane(Plane3 value); // 0x0000000186951824-0x0000000186951868
		public static implicit operator Plane3(Plane value); // 0x0000000184D8C1D0-0x0000000184D8C200
		public Vector3 CalcOrigin(); // 0x00000001869501F4-0x0000000186950238
		public void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, out Vector3 n); // 0x0000000186950238-0x0000000186950340
		internal float SignedDistanceTo(ref Vector3 point); // 0x000000018695131C-0x00000001869513B8
		public float SignedDistanceTo(Vector3 point); // 0x000000018695128C-0x000000018695131C
		public float DistanceTo(Vector3 point); // 0x0000000186950340-0x00000001869503D8
		public int QuerySide(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x0234BDC2 */); // 0x00000001869511C4-0x000000018695128C
		public bool QuerySideNegative(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x0234BDC6 */); // 0x00000001869507B8-0x000000018695085C
		public bool QuerySidePositive(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x0234BDCA */); // 0x0000000186950B00-0x0000000186950BAC
		public int QuerySide(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x0234BDCE */); // 0x0000000186950FFC-0x00000001869511C4
		public bool QuerySideNegative(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x0234BDD2 */); // 0x0000000186950504-0x00000001869506AC
		public bool QuerySidePositive(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x0234BDD6 */); // 0x0000000186950BAC-0x0000000186950D4C
		public int QuerySide(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x0234BDDA */); // 0x0000000186950E44-0x0000000186950FFC
		public bool QuerySideNegative(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x0234BDDE */); // 0x00000001869506AC-0x00000001869507B8
		public bool QuerySidePositive(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x0234BDE2 */); // 0x00000001869509EC-0x0000000186950B00
		public int QuerySide(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x0234BDE6 */); // 0x0000000186950D4C-0x0000000186950E44
		public bool QuerySideNegative(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x0234BDEA */); // 0x000000018695085C-0x0000000186950928
		public bool QuerySidePositive(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x0234BDEE */); // 0x0000000186950928-0x00000001869509EC
		public Vector3 Project(Vector3 point); // 0x00000001869504D8-0x0000000186950504
		public Vector3 ProjectVector(Vector3 vector); // 0x00000001869503D8-0x00000001869504D8
		public float AngleBetweenPlaneNormalAndLine(Line3 line); // 0x0000000186950098-0x0000000186950150
		public float AngleBetweenPlaneNormalAndLine(Vector3 direction); // 0x000000018694FFEC-0x0000000186950098
		public float AngleBetweenPlaneAndLine(Line3 line); // 0x000000018694FF24-0x000000018694FFEC
		public float AngleBetweenPlaneAndLine(Vector3 direction); // 0x000000018694FE68-0x000000018694FF24
		public float AngleBetweenTwoPlanes(Plane3 anotherPlane); // 0x0000000186950150-0x00000001869501F4
		public override string ToString(); // 0x00000001869513B8-0x0000000186951450
	}

	[Serializable]
	public struct Edge3 // TypeDefIndex: 58578
	{
		// Fields
		public Vector3 Point0; // 0x00
		public Vector3 Point1; // 0x0C
		public Vector3 Direction; // 0x18
		public Vector3 Normal; // 0x24
		public float Length; // 0x30
	}

	[Serializable]
	public class Polygon3 // TypeDefIndex: 58579
	{
		// Fields
		[SerializeField]
		private Vector3[] _vertices; // 0x10
		[SerializeField]
		private Edge3[] _edges; // 0x18
		[SerializeField]
		private Plane3 _plane; // 0x20
	
		// Properties
		public Vector3[] Vertices { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public Edge3[] Edges { get; } // 0x000000018385B100-0x000000018385B110 
		public int VertexCount { get; } // 0x00000001867B6CAC-0x00000001867B6CC8 
		public Vector3 this[int vertexIndex] { get => default; set {} } // 0x0000000186953194-0x00000001869531C0 0x00000001869531C0-0x00000001869531F8
		public Plane3 Plane { get; set; } // 0x0000000184D8C200-0x0000000184D8C210 0x0000000184D8C210-0x0000000184D8C220
	
		// Constructors
		private Polygon3(); // 0x00000001841E1670-0x00000001841E1680
		public Polygon3(Vector3[] vertices, Plane3 plane); // 0x00000001869530DC-0x0000000186953194
		public Polygon3(int vertexCount, Plane3 plane); // 0x000000018695304C-0x00000001869530DC
	
		// Methods
		public void SetVertexProjected(int vertexIndex, Vector3 vertex); // 0x0000000186952850-0x0000000186952974
		public void ProjectVertices(); // 0x00000001869525F0-0x0000000186952764
		public Edge3 GetEdge(int edgeIndex); // 0x0000000186952490-0x00000001869524EC
		public void UpdateEdges(); // 0x0000000186952E44-0x000000018695304C
		public void UpdateEdge(int edgeIndex); // 0x0000000186952C6C-0x0000000186952E44
		public Vector3 CalcCenter(); // 0x00000001869522F8-0x0000000186952428
		public float CalcPerimeter(); // 0x0000000186952428-0x0000000186952490
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x0234BDF2 */); // 0x00000001869524EC-0x00000001869525F0
		public void ReverseVertices(); // 0x0000000186952764-0x0000000186952850
		public Segment3[] ToSegmentArray(); // 0x0000000186952974-0x0000000186952ACC
		public override string ToString(); // 0x0000000186952ACC-0x0000000186952C6C
	}

	public struct Ray3 // TypeDefIndex: 58580
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Ray3(ref Vector3 center, ref Vector3 direction); // 0x0000000184D8BBF0-0x0000000184D8BC10
		public Ray3(Vector3 center, Vector3 direction); // 0x0000000184D871E0-0x0000000184D87200
	
		// Methods
		public static implicit operator Ray(Ray3 value); // 0x0000000186954118-0x000000018695416C
		public static implicit operator Ray3(Ray value); // 0x0000000184D8C560-0x0000000184D8C590
		public Vector3 Eval(float t); // 0x000000018694F664-0x000000018694F6E0
		public float DistanceTo(Vector3 point); // 0x0000000186954024-0x0000000186954040
		public Vector3 Project(Vector3 point); // 0x0000000186954040-0x000000018695406C
		public override string ToString(); // 0x000000018695406C-0x0000000186954118
	}

	public struct Rectangle3 // TypeDefIndex: 58581
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Normal; // 0x24
		public Vector2 Extents; // 0x30
	
		// Constructors
		public Rectangle3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, ref Vector2 extents); // 0x0000000186954F9C-0x00000001869550B4
		public Rectangle3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector2 extents); // 0x0000000186954EBC-0x0000000186954F9C
	
		// Methods
		public static Rectangle3 CreateFromCCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x00000001869548A4-0x0000000186954A9C
		public static Rectangle3 CreateFromCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x0000000186954A9C-0x0000000186954C94
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3); // 0x00000001869543E0-0x0000000186954600
		public Vector3[] CalcVertices(); // 0x0000000186954600-0x00000001869548A4
		public void CalcVertices(Vector3[] array); // 0x000000018695416C-0x00000001869543E0
		public float CalcArea(); // 0x0000000184D8C590-0x0000000184D8C5B0
		public float DistanceTo(Vector3 point); // 0x0000000186954C94-0x0000000186954CB0
		public Vector3 Project(Vector3 point); // 0x0000000186954CB0-0x0000000186954CDC
		public override string ToString(); // 0x0000000186954CDC-0x0000000186954EBC
	}

	public struct Segment3 // TypeDefIndex: 58582
	{
		// Fields
		public Vector3 P0; // 0x00
		public Vector3 P1; // 0x0C
		public Vector3 Center; // 0x18
		public Vector3 Direction; // 0x24
		public float Extent; // 0x30
	
		// Constructors
		public Segment3(ref Vector3 p0, ref Vector3 p1); // 0x00000001869555F4-0x0000000186955654
		public Segment3(Vector3 p0, Vector3 p1); // 0x0000000186955594-0x00000001869555F4
		public Segment3(ref Vector3 center, ref Vector3 direction, float extent); // 0x00000001869556B4-0x0000000186955714
		public Segment3(Vector3 center, Vector3 direction, float extent); // 0x0000000186955654-0x00000001869556B4
	
		// Methods
		public void SetEndpoints(Vector3 p0, Vector3 p1); // 0x00000001869553B8-0x00000001869553E0
		public void SetCenterDirectionExtent(Vector3 center, Vector3 direction, float extent); // 0x000000018695538C-0x00000001869553B8
		public void CalcCenterDirectionExtent(); // 0x00000001869550B4-0x00000001869551C4
		public void CalcEndPoints(); // 0x00000001869551C4-0x00000001869552A4
		public Vector3 Eval(float s); // 0x00000001869552C0-0x0000000186955360
		public float DistanceTo(Vector3 point); // 0x00000001869552A4-0x00000001869552C0
		public Vector3 Project(Vector3 point); // 0x0000000186955360-0x000000018695538C
		public override string ToString(); // 0x00000001869553E0-0x0000000186955594
	}

	public struct Sphere3 // TypeDefIndex: 58583
	{
		// Fields
		private const float _4div3mulPi = 4.1887903f; // Metadata: 0x0234BDF6
		public Vector3 Center; // 0x00
		public float Radius; // 0x0C
	
		// Constructors
		public Sphere3(ref Vector3 center, float radius); // 0x0000000184D8C1B0-0x0000000184D8C1D0
		public Sphere3(Vector3 center, float radius); // 0x0000000184D8C1B0-0x0000000184D8C1D0
	
		// Methods
		public static Sphere3 CreateFromPointsAAB(IEnumerable<Vector3> points); // 0x0000000186955B80-0x0000000186955CA4
		public static Sphere3 CreateFromPointsAAB(IList<Vector3> points); // 0x0000000186955AA8-0x0000000186955B80
		public static Sphere3 CreateFromPointsAverage(IEnumerable<Vector3> points); // 0x0000000186955CA4-0x0000000186956050
		public static Sphere3 CreateFromPointsAverage(IList<Vector3> points); // 0x0000000186956050-0x0000000186956244
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere); // 0x0000000186955784-0x0000000186955AA8
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere); // 0x0000000186956244-0x000000018695686C
		public float CalcArea(); // 0x0000000184D8C5B0-0x0000000184D8C5D0
		public float CalcVolume(); // 0x0000000184D8C5D0-0x0000000184D8C5F0
		public Vector3 Eval(float theta, float phi); // 0x0000000184D8C5F0-0x0000000184D8C690
		public float DistanceTo(Vector3 point); // 0x000000018695686C-0x0000000186956888
		public Vector3 Project(Vector3 point); // 0x00000001869569E4-0x0000000186956A10
		public bool Contains(ref Vector3 point); // 0x0000000186955714-0x0000000186955784
		public bool Contains(Vector3 point); // 0x0000000186955714-0x0000000186955784
		public void Include(ref Sphere3 sphere); // 0x0000000186956888-0x00000001869569D0
		public void Include(Sphere3 sphere); // 0x00000001869569D0-0x00000001869569E4
		public override string ToString(); // 0x0000000186956A10-0x0000000186956AA8
	}

	public struct Triangle3 // TypeDefIndex: 58584
	{
		// Fields
		public Vector3 V0; // 0x00
		public Vector3 V1; // 0x0C
		public Vector3 V2; // 0x18
	
		// Properties
		public Vector3 this[int index] { get => default; set {} } // 0x0000000186959734-0x0000000186959794 0x0000000186959794-0x00000001869597D8
	
		// Constructors
		public Triangle3(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000184D8C6D0-0x0000000184D8C710
		public Triangle3(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000184D8C690-0x0000000184D8C6D0
	
		// Methods
		public Vector3 CalcEdge(int edgeIndex); // 0x00000001869592F8-0x00000001869593BC
		public Vector3 CalcNormal(); // 0x00000001869593BC-0x0000000186959470
		public float CalcArea(); // 0x0000000186958FE8-0x00000001869590A8
		public static float CalcArea(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000186958F28-0x0000000186958FE8
		public static float CalcArea(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000186958F28-0x0000000186958FE8
		public Vector3 CalcAnglesDeg(); // 0x0000000186958A94-0x0000000186958C20
		public static Vector3 CalcAnglesDeg(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x00000001869588D0-0x0000000186958A60
		public static Vector3 CalcAnglesDeg(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000186958A60-0x0000000186958A94
		public Vector3 CalcAnglesRad(); // 0x0000000186958DC0-0x0000000186958F28
		public static Vector3 CalcAnglesRad(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000186958C20-0x0000000186958D8C
		public static Vector3 CalcAnglesRad(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000186958D8C-0x0000000186958DC0
		public Vector3 EvalBarycentric(float c0, float c1); // 0x0000000186959560-0x0000000186959658
		public Vector3 EvalBarycentric(ref Vector3 baryCoords); // 0x0000000186959470-0x0000000186959560
		public Vector3 EvalBarycentric(Vector3 baryCoords); // 0x0000000186959470-0x0000000186959560
		public static void CalcBarycentricCoords(ref Vector3 point, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Vector3 baryCoords); // 0x00000001869590E0-0x00000001869592F8
		public Vector3 CalcBarycentricCoords(ref Vector3 point); // 0x00000001869590A8-0x00000001869590E0
		public Vector3 CalcBarycentricCoords(Vector3 point); // 0x00000001869590A8-0x00000001869590E0
		public override string ToString(); // 0x0000000186959658-0x0000000186959734
	}

	public enum Orientations // TypeDefIndex: 58585
	{
		CW = 0,
		CCW = 1,
		None = 2
	}

	internal class Query2 : Query // TypeDefIndex: 58586
	{
		// Fields
		private static float Zero; // 0x00
		private Vector2[] _vertices; // 0x10
	
		// Constructors
		public Query2(Vector2[] vertices); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public int ToLine(int i, int v0, int v1); // 0x0000000186953544-0x000000018695359C
		public int ToLine(ref Vector2 test, int v0, int v1); // 0x0000000186953450-0x0000000186953544
		public int ToTriangle(int i, int v0, int v1, int v2); // 0x0000000186953644-0x00000001869536A4
		public int ToTriangle(ref Vector2 test, int v0, int v1, int v2); // 0x000000018695359C-0x0000000186953644
		public int ToCircumcircle(int i, int v0, int v1, int v2); // 0x00000001869531F8-0x0000000186953258
		public int ToCircumcircle(ref Vector2 test, int v0, int v1, int v2); // 0x0000000186953258-0x0000000186953450
		public float Dot(float x0, float y0, float x1, float y1); // 0x0000000184D8C300-0x0000000184D8C320
		public float Det2(float x0, float y0, float x1, float y1); // 0x0000000184D8C220-0x0000000184D8C240
		public float Det3(float x0, float y0, float z0, float x1, float y1, float z1, float x2, float y2, float z2); // 0x0000000184D8C240-0x0000000184D8C300
	}

	internal class Query3 : Query // TypeDefIndex: 58587
	{
		// Fields
		private static float Zero; // 0x00
		private Vector3[] _vertices; // 0x10
	
		// Constructors
		public Query3(Vector3[] vertices); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public int ToPlane(int i, int v0, int v1, int v2); // 0x0000000186953AA0-0x0000000186953B00
		public int ToPlane(ref Vector3 test, int v0, int v1, int v2); // 0x0000000186953B00-0x0000000186953CBC
		public int ToTetrahedron(int i, int v0, int v1, int v2, int v3); // 0x0000000186953CBC-0x0000000186953D24
		public int ToTetrahedron(ref Vector3 test, int v0, int v1, int v2, int v3); // 0x0000000186953D24-0x0000000186953E10
		public int ToCircumsphere(int i, int v0, int v1, int v2, int v3); // 0x0000000186953A38-0x0000000186953AA0
		public int ToCircumsphere(ref Vector3 test, int v0, int v1, int v2, int v3); // 0x00000001869536A4-0x0000000186953A38
		public float Dot(float x0, float y0, float z0, float x1, float y1, float z1); // 0x0000000184D8C540-0x0000000184D8C560
		public float Det3(float x0, float y0, float z0, float x1, float y1, float z1, float x2, float y2, float z2); // 0x0000000184D8C240-0x0000000184D8C300
		public float Det4(float x0, float y0, float z0, float w0, float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2, float x3, float y3, float z3, float w3); // 0x0000000184D8C320-0x0000000184D8C540
	}

	internal enum QueryTypes // TypeDefIndex: 58588
	{
		Int64 = 0,
		Integer = 1,
		Rational = 2,
		Real = 3,
		Filtered = 4
	}

	internal class Query // TypeDefIndex: 58589
	{
		// Constructors
		protected Query(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static bool Sort(ref int v0, ref int v1); // 0x0000000186954010-0x0000000186954024
		public static bool Sort(ref int v0, ref int v1, ref int v2); // 0x0000000186953E10-0x0000000186953E80
		public static bool Sort(ref int v0, ref int v1, ref int v2, ref int v3); // 0x0000000186953E80-0x0000000186954010
	}

	public class CatmullRomSpline3 : SplineBase // TypeDefIndex: 58590
	{
		// Properties
		public override SplineTypes SplineType { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x000000018694AB98-0x000000018694AC08
	
		// Constructors
		public CatmullRomSpline3(); // 0x000000018694AB90-0x000000018694AB98
	
		// Methods
		public static CatmullRomSpline3 Create(); // 0x000000018694A044-0x000000018694A0C0
		public static CatmullRomSpline3 Create(IList<Vector3> points, SplineTypes type); // 0x000000018694A0C0-0x000000018694A2D0
		private void UpdateSegment(int index); // 0x000000018694A6AC-0x000000018694AB90
		private void UpdateAdjacentSegments(int vertexIndex); // 0x000000018694A57C-0x000000018694A6AC
		public override void AddVertexFirst(Vector3 position); // 0x0000000186949F18-0x0000000186949F4C
		public override void AddVertexLast(Vector3 position); // 0x0000000186949F4C-0x0000000186949FF8
		public override void RemoveVertex(int index); // 0x000000018694A48C-0x000000018694A4F4
		public override void Clear(); // 0x0000000186949FF8-0x000000018694A044
		public override void InsertBefore(int vertexIndex, Vector3 position); // 0x000000018694A3EC-0x000000018694A48C
		public override void InsertAfter(int vertexIndex, Vector3 position); // 0x000000018694A348-0x000000018694A3EC
		public override Vector3 GetVertex(int vertexIndex); // 0x000000018694A2D0-0x000000018694A348
		public override void SetVertex(int vertexIndex, Vector3 position); // 0x000000018694A4F4-0x000000018694A57C
	}

	public class CubicSpline3 : SplineBase // TypeDefIndex: 58591
	{
		// Properties
		public override SplineTypes SplineType { get; set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x000000018694D844-0x000000018694D858
	
		// Constructors
		public CubicSpline3(); // 0x000000018694AB90-0x000000018694AB98
	
		// Methods
		public static CubicSpline3 Create(); // 0x000000018694D340-0x000000018694D3BC
		public static CubicSpline3 Create(IList<Vector3> points, SplineTypes type); // 0x000000018694D3BC-0x000000018694D5A4
		private void BuildSpline(); // 0x000000018694BCE4-0x000000018694BD4C
		private void CreateOpenedSpline(); // 0x000000018694CB5C-0x000000018694D340
		private void CreateClosedSpline(); // 0x000000018694BD98-0x000000018694CB5C
		public override void AddVertexFirst(Vector3 position); // 0x000000018694BBC0-0x000000018694BC54
		public override void AddVertexLast(Vector3 position); // 0x000000018694BC54-0x000000018694BCE4
		public override void RemoveVertex(int index); // 0x000000018694D75C-0x000000018694D7C0
		public override void Clear(); // 0x000000018694BD4C-0x000000018694BD98
		public override void InsertBefore(int vertexIndex, Vector3 position); // 0x000000018694D6BC-0x000000018694D75C
		public override void InsertAfter(int vertexIndex, Vector3 position); // 0x000000018694D61C-0x000000018694D6BC
		public override Vector3 GetVertex(int vertexIndex); // 0x000000018694D5A4-0x000000018694D61C
		public override void SetVertex(int vertexIndex, Vector3 position); // 0x000000018694D7C0-0x000000018694D844
	}

	public enum SplineTypes // TypeDefIndex: 58592
	{
		Open = 0,
		Closed = 1
	}

	public enum SplinePlaneTypes // TypeDefIndex: 58593
	{
		XZ = 0,
		XY = 1,
		YZ = 2
	}

	public struct PositionTangent // TypeDefIndex: 58594
	{
		// Fields
		public Vector3 Position; // 0x00
		public Vector3 Tangent; // 0x0C
	}

	public struct CurveFrame // TypeDefIndex: 58595
	{
		// Fields
		public Vector3 Position; // 0x00
		public Vector3 Tangent; // 0x0C
		public Vector3 Normal; // 0x18
		public Vector3 Binormal; // 0x24
	}

	public abstract class SplineBase : MonoBehaviour // TypeDefIndex: 58598
	{
		// Fields
		protected ArcLengthParametrization _parametrization; // 0x18
		[SerializeField]
		protected List<ItemData> _data; // 0x20
		[SerializeField]
		protected SplineTypes _type; // 0x28
		[SerializeField]
		protected bool _recalcSegmentsLength; // 0x2C
		[SerializeField]
		protected UnityEngine.Color _renderColor; // 0x30
		[SerializeField]
		protected SplinePlaneTypes _creationPlane; // 0x40
	
		// Properties
		protected int SegmentCount { get; } // 0x00000001869587FC-0x000000018695884C 
		public int VertexCount { get; } // 0x0000000186958890-0x00000001869588D0 
		public bool Valid { get; } // 0x000000018695884C-0x0000000186958890 
		public abstract SplineTypes SplineType { get; set; }
	
		// Nested types
		[Serializable]
		protected class ItemData // TypeDefIndex: 58596
		{
			// Fields
			public Vector3 Position; // 0x10
			public Vector3 A; // 0x1C
			public Vector3 B; // 0x28
			public Vector3 C; // 0x34
			public Vector3 D; // 0x40
			public float Length; // 0x4C
			public float AccumulatedLength; // 0x50
			private const int SegmentCount = 10; // Metadata: 0x0234BE07
			private const int SegmentCountPlus1 = 11; // Metadata: 0x0234BE08
			private const float DeltaTime = 0.1f; // Metadata: 0x0234BE09
			public Vector3[] RenderPoints; // 0x58
	
			// Constructors
			public ItemData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool EnsureRenderPointsValidity(); // 0x000000018694ED80-0x000000018694EDE0
			public void UpdateRenderPoints(); // 0x000000018694F47C-0x000000018694F4F4
			public Vector3 EvalPosition(float t); // 0x000000018694F028-0x000000018694F148
			public Vector3 EvalFirstDerivative(float t); // 0x000000018694EDE0-0x000000018694EED8
			public Vector3 EvalSecondDerivative(float t); // 0x000000018694F148-0x000000018694F1EC
			public Vector3 EvalThirdDerivative(float t); // 0x000000018694F400-0x000000018694F448
			public float EvalSpeed(float t); // 0x000000018694F1EC-0x000000018694F2E8
			public Vector3 EvalTangent(float t); // 0x000000018694F2E8-0x000000018694F400
			public float EvalLength(); // 0x000000018694EED8-0x000000018694EF74
			public float EvalLength(float t0, float t1); // 0x000000018694EF74-0x000000018694F028
			public float ProcessLength(float currentLength); // 0x000000018694F448-0x000000018694F47C
		}
	
		protected class ArcLengthParametrization // TypeDefIndex: 58597
		{
			// Fields
			public float[] sSample; // 0x10
			public float[] tSample; // 0x18
			public float[] tsSlope; // 0x20
			public float L; // 0x28
	
			// Constructors
			public ArcLengthParametrization(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public float GetApproximateTimeParameter(float s); // 0x0000000186949E48-0x0000000186949F18
		}
	
		// Constructors
		protected SplineBase(); // 0x0000000186958764-0x00000001869587FC
	
		// Methods
		private void Awake(); // 0x0000000186956AA8-0x0000000186956AB0
		protected void GetSegmentIndexAndTime(float time, out int segmentIndex, out float segmentTime); // 0x0000000186957FCC-0x000000018695805C
		protected void PrepareForRuntime(); // 0x00000001869585FC-0x0000000186958690
		protected void RecalcSegmentsLength(); // 0x0000000186958690-0x0000000186958764
		public abstract void AddVertexFirst(Vector3 position);
		public abstract void AddVertexLast(Vector3 position);
		public abstract void RemoveVertex(int index);
		public abstract void Clear();
		public abstract void InsertBefore(int vertexIndex, Vector3 position);
		public abstract void InsertAfter(int vertexIndex, Vector3 position);
		public abstract Vector3 GetVertex(int vertexIndex);
		public abstract void SetVertex(int vertexIndex, Vector3 position);
		public Vector3 EvalPosition(float time); // 0x00000001869578C8-0x000000018695797C
		public Vector3 EvalTangent(float time); // 0x0000000186957B0C-0x0000000186957BC0
		public PositionTangent EvalPositionTangent(float time); // 0x000000018695772C-0x0000000186957814
		public void EvalPosition(float time, out Vector3 position); // 0x0000000186957814-0x00000001869578C8
		public void EvalTangent(float time, out Vector3 tangent); // 0x0000000186957BC0-0x0000000186957C74
		public void EvalPositionTangent(float time, out PositionTangent positionTangent); // 0x0000000186957650-0x000000018695772C
		public void EvalFrame(float time, out CurveFrame frame); // 0x00000001869570A4-0x00000001869572CC
		public float EvalCurvature(float time); // 0x0000000186956CE0-0x0000000186956E64
		public float EvalTorsion(float time); // 0x0000000186957E2C-0x0000000186957FCC
		public Vector3 EvalPositionParametrized(float length); // 0x00000001869572CC-0x0000000186957394
		public Vector3 EvalTangentParametrized(float length); // 0x0000000186957A44-0x0000000186957B0C
		public PositionTangent EvalPositionTangentParametrized(float length); // 0x000000018695745C-0x000000018695755C
		public void EvalPositionParametrized(float length, out Vector3 position); // 0x0000000186957394-0x000000018695745C
		public void EvalTangentParametrized(float length, out Vector3 tangent); // 0x000000018695797C-0x0000000186957A44
		public void EvalPositionTangentParametrized(float length, out PositionTangent positionTangent); // 0x000000018695755C-0x0000000186957650
		public void EvalFrameParametrized(float length, out CurveFrame frame); // 0x0000000186956E64-0x00000001869570A4
		public float EvalCurvatureParametrized(float length); // 0x0000000186956B44-0x0000000186956CE0
		public float EvalTorsionParametrized(float length); // 0x0000000186957C74-0x0000000186957E2C
		public float CalcTotalLength(); // 0x0000000186956AB0-0x0000000186956B44
		public float LengthToTime(float length, int iterations, float tolerance); // 0x0000000186958084-0x000000018695834C
		public float LengthToTime(float length); // 0x000000018695805C-0x0000000186958084
		public float ParametrizeByArcLength(int pointCount); // 0x000000018695834C-0x00000001869585FC
	}

	public static class PointsFilter // TypeDefIndex: 58600
	{
		// Nested types
		private class Data // TypeDefIndex: 58599
		{
			// Fields
			private Vector3[] _points; // 0x10
			private List<int>[,,] _grid; // 0x18
			private Vector3 _min; // 0x20
			private Vector3 _max; // 0x2C
			private int _cellsX; // 0x38
			private int _cellsY; // 0x3C
			private int _cellsZ; // 0x40
			private float _cellSize; // 0x44
			private float _radius; // 0x48
			private Rand _rand; // 0x50
	
			// Constructors
			public Data(Vector3[] points, float radius, Rand rand, AAB3 aab); // 0x000000018694E0A8-0x000000018694E214
	
			// Methods
			private static int BinarySearch(List<int> array, int value); // 0x000000018694D8D0-0x000000018694D990
			private static int BinarySearch(int[] array, int length, int value); // 0x000000018694D858-0x000000018694D8D0
			private void CalcGridIndices(ref Vector3 point, out int i, out int j, out int k); // 0x000000018694D990-0x000000018694D9D8
			public List<int> Filter(); // 0x000000018694D9D8-0x000000018694E0A8
		}
	
		// Methods
		public static List<int> DistanceFilter(Vector3[] points, AAB3 pointsAAB, float radius, Rand rand); // 0x00000001869519BC-0x0000000186951A70
	}

	public class PoissonDiskSampler // TypeDefIndex: 58602
	{
		// Fields
		private static readonly float one_div_sqrtTwo; // 0x00
		private Rand _rand; // 0x10
		private List<int> _activeList; // 0x18
		private List<Vector2> _points; // 0x20
		private int?[,] _grid; // 0x28
		private float _r; // 0x30
		private float _rSquared; // 0x34
		private float _rTwo; // 0x38
		private float _rMin; // 0x3C
		private Vector2 _min; // 0x40
		private Vector2 _max; // 0x48
		private Vector2 _size; // 0x50
		private float _cellSize; // 0x58
		private int _cellsX; // 0x5C
		private int _cellsY; // 0x60
		public PointDelegate DistanceFilter; // 0x68
		public int PointsPerStep; // 0x70
		[CompilerGenerated]
		private int _MaxPoints_k__BackingField; // 0x74
	
		// Properties
		public int MaxPoints { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D868B0-0x0000000184D868C0 0x0000000184D868E0-0x0000000184D868F0
	
		// Nested types
		public delegate float PointDelegate(ref Vector2 point); // TypeDefIndex: 58601; 0x00000001814E2060-0x00000001814E2070
	
		// Constructors
		static PoissonDiskSampler(); // 0x0000000186952060-0x00000001869520B0
		public PoissonDiskSampler(Rand rand, Vector2 minCorner, Vector2 maxCorner, float minDistanceOuter, float minDistanceInner = 1f /* Metadata: 0x0234BE0D */); // 0x00000001869520B0-0x00000001869522F8
	
		// Methods
		private void CalcGridIndices(ref Vector2 point, out int i, out int j); // 0x0000000186951D98-0x0000000186951DC4
		private void InsertIntoGrid(ref Vector2 point, int index); // 0x0000000186951DC4-0x0000000186951E5C
		private bool AddPoint(ref Vector2 center); // 0x0000000186951A70-0x0000000186951D98
		public List<Vector2> Sample(); // 0x0000000186951E5C-0x0000000186952060
	}

	public class WeightedSampler // TypeDefIndex: 58603
	{
		// Fields
		protected float[] _accum; // 0x10
		protected float _total; // 0x18
		protected Rand _rand; // 0x20
	
		// Constructors
		protected WeightedSampler(Rand rand); // 0x0000000185390F40-0x0000000185390F50
		public WeightedSampler(float[] weights); // 0x00000001869599AC-0x0000000186959A1C
		public WeightedSampler(float[] weights, Rand rand); // 0x0000000186959980-0x00000001869599AC
	
		// Methods
		protected static int BinarySearch(float[] array, float value); // 0x00000001869597D8-0x0000000186959844
		protected void Init(float[] weights); // 0x0000000186959844-0x0000000186959940
		public int SampleIndex(); // 0x0000000186959940-0x0000000186959980
	}

	public class TrianglesSamplerBase : WeightedSampler // TypeDefIndex: 58604
	{
		// Fields
		protected Vector3[] _vertices; // 0x28
	
		// Constructors
		protected TrianglesSamplerBase(Rand rand); // 0x0000000185390F40-0x0000000185390F50
	
		// Methods
		protected float CalclTriangleArea(ref Vector3 e0, ref Vector3 e1); // 0x0000000184D8C710-0x0000000184D8C7B0
	}

	public class IndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 58605
	{
		// Fields
		protected int[] _indices; // 0x30
	
		// Constructors
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices); // 0x000000018694EB80-0x000000018694EC10
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices, Rand rand); // 0x000000018694EC10-0x000000018694EC68
		public IndexedTrianglesSampler(Mesh mesh); // 0x000000018694EC68-0x000000018694ED10
		public IndexedTrianglesSampler(Mesh mesh, Rand rand); // 0x000000018694ED10-0x000000018694ED80
	
		// Methods
		protected void Init(); // 0x000000018694E214-0x000000018694E5D4
		public Vector3 Sample(); // 0x000000018694EA74-0x000000018694EB80
		public Vector3[] SampleArray(int count); // 0x000000018694E90C-0x000000018694EA74
		public Vector3[] SampleArray(int count, Vector2[] uvs, Texture2D sampleMap, float min = 0f /* Metadata: 0x0234BE11 */, float max = 1f /* Metadata: 0x0234BE15 */); // 0x000000018694E5D4-0x000000018694E90C
	}

	public class NonIndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 58606
	{
		// Constructors
		public NonIndexedTrianglesSampler(Vector3[] vertices); // 0x000000018694FDF0-0x000000018694FE68
		public NonIndexedTrianglesSampler(Vector3[] vertices, Rand rand); // 0x000000018694FCDC-0x000000018694FD10
		public NonIndexedTrianglesSampler(Mesh mesh); // 0x000000018694FD10-0x000000018694FD9C
		public NonIndexedTrianglesSampler(Mesh mesh, Rand rand); // 0x000000018694FD9C-0x000000018694FDF0
	
		// Methods
		protected void Init(); // 0x000000018694F7B8-0x000000018694FAEC
		public Vector3 Sample(); // 0x000000018694FC10-0x000000018694FCDC
		public Vector3[] SampleArray(int count); // 0x000000018694FAEC-0x000000018694FC10
	}

	public class ShuffleBag<T> : IEnumerable<T> // TypeDefIndex: 58608
	{
		// Fields
		private Rand _rand;
		private List<T> _items;
		private int _index;
	
		// Properties
		public int Count { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__13 : IEnumerator<T> // TypeDefIndex: 58607
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public ShuffleBag<T> __4__this;
			private int _i_5__2;
			private int _len_5__3;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ShuffleBag();
		public ShuffleBag(int capacity);
		public ShuffleBag(Rand rand);
		public ShuffleBag(Rand rand, int capacity);
	
		// Methods
		public void Add(T item, uint count = 1 /* Metadata: 0x0234BE19 */);
		public T NextItem();
		public void Reset();
		public void Clear();
		[IteratorStateMachine(typeof(_GetEnumerator_d__13))]
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public static class Util // TypeDefIndex: 58609
	{
		// Extension methods
		public static void Shuffle<T>(this IList<T> collection);
		public static void Shuffle<T>(this IList<T> collection, Rand rand);
		public static void Shuffle<T>(this T[] collection);
		public static void Shuffle<T>(this T[] collection, Rand rand);
	}
}
