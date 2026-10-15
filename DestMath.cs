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

// Image 36: DestMath.dll - Assembly: DestMath, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 84978-85129

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 85129
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_20 _170A8789272DFBCBA0E6B7D2530CAA16D9199834934F442421DAB41C5EEA8C29; // 0x00 // Static value (base64): 9pxyPtEO9T60ohE/0Q71Pvaccj4= - Metadata: 0x026448E8
	internal static readonly __StaticArrayInitTypeSize_20 _92052E6D9D3C30FD20B710DFB226BEEA15F69C2188B5AA373563D6966493C59C; // 0x14 // Static value (base64): Z/tnvyDZCb8AAAAAINkJP2f7Zz8= - Metadata: 0x02644900

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 85128
	{
	}
}

namespace Dest.Math
{
	public class Polynomial // TypeDefIndex: 84979
	{
		// Fields
		private int _degree; // 0x10
		private float[] _coeffs; // 0x18
	
		// Properties
		public int Degree { get; set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000188C3F358-0x0000000188C3F3AC
		public float this[int index] { get => default; set {} } // 0x0000000188C3F328-0x0000000188C3F358 0x0000000188C3F3AC-0x0000000188C3F3DC
	
		// Constructors
		public Polynomial(int degree); // 0x0000000188C3F320-0x0000000188C3F328
	
		// Methods
		public Polynomial DeepCopy(); // 0x0000000188C3F214-0x0000000188C3F2C0
		public Polynomial CalcDerivative(); // 0x0000000188C3EF7C-0x0000000188C3F084
		public Polynomial CalcInversion(); // 0x0000000188C3F084-0x0000000188C3F13C
		public void Compress(float epsilon = 1E-05f /* Metadata: 0x0264473C */); // 0x0000000188C3F13C-0x0000000188C3F214
		public float Eval(float t); // 0x0000000188C3F2C0-0x0000000188C3F320
	}

	public static class Approximation // TypeDefIndex: 84980
	{
		// Methods
		public static Box2 GaussPointsFit2(IList<Vector2> points); // 0x0000000188C31530-0x0000000188C318D8
		internal static bool HeightLineFit2(IList<Vector2> points, out float a, out float b); // 0x0000000188C31DBC-0x0000000188C32090
		public static Line2 LeastSquaresLineFit2(IList<Vector2> points); // 0x0000000188C32530-0x0000000188C3281C
		public static Box3 GaussPointsFit3(IList<Vector3> points); // 0x0000000188C318D8-0x0000000188C31DBC
		public static Line3 LeastsSquaresLineFit3(IList<Vector3> points); // 0x0000000188C32BD8-0x0000000188C3300C
		internal static bool HeightPlaneFit3(IList<Vector3> points, out float a, out float b, out float c); // 0x0000000188C32090-0x0000000188C32530
		public static Plane3 LeastSquaresPlaneFit3(IList<Vector3> points); // 0x0000000188C3281C-0x0000000188C32BD8
	}

	internal class ConcaveHull2 // TypeDefIndex: 84983
	{
		// Nested types
		private struct Edge // TypeDefIndex: 84981
		{
			// Fields
			public int V0; // 0x00
			public int V1; // 0x04
	
			// Constructors
			public Edge(int v0, int v1); // 0x00000001827241A0-0x00000001827241B0
		}
	
		private struct InnerPoint // TypeDefIndex: 84982
		{
			// Fields
			public float AverageDistance; // 0x00
			public float Distance0; // 0x04
			public float Distance1; // 0x08
			public int Index; // 0x0C
		}
	
		// Constructors
		public ConcaveHull2(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private static bool _TryFastSort(InnerPoint[] x, int first, int last); // 0x0000000188C33DA0-0x0000000188C33E74
		private static void Quicksort(InnerPoint[] x, int first, int last); // 0x0000000188C33BFC-0x0000000188C33DA0
		private static float CalcDistanceFromPointToEdge(ref Vector2 pointA, ref Vector2 v0, ref Vector2 v1); // 0x0000000188C3300C-0x0000000188C3311C
		public static bool Create(Vector2[] points, out int[] concaveHull, int[] convexHull, float N, float epsilon = 1E-05f /* Metadata: 0x02644740 */); // 0x0000000188C3311C-0x0000000188C33BFC
	}

	public static class ConcaveHull // TypeDefIndex: 84984
	{
		// Methods
		public static bool Create2D(Vector2[] points, out int[] concaveHull, out int[] convexHull, float algorithmThreshold, float epsilon = 1E-05f /* Metadata: 0x02644744 */); // 0x0000000188C33E9C-0x0000000188C33FFC
		public static bool Create2D(Vector2[] points, out int[] concaveHull, float algorithmThreshold, float epsilon = 1E-05f /* Metadata: 0x02644748 */); // 0x0000000188C33E74-0x0000000188C33E9C
	}

	internal class ConvexHull1 // TypeDefIndex: 84987
	{
		// Nested types
		private class SortedVertex // TypeDefIndex: 84985
		{
			// Fields
			public float Value; // 0x10
			public int Index; // 0x14
	
			// Constructors
			public SortedVertex(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 84986
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<SortedVertex> __9__1_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188C3F600-0x0000000188C3F664
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _Create_b__1_0(SortedVertex e1, SortedVertex e2); // 0x0000000188C3F590-0x0000000188C3F600
		}
	
		// Constructors
		public ConvexHull1(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void Create(float[] vertices, float epsilon, out int dimension, out int[] indices); // 0x0000000188C33FFC-0x0000000188C342F8
	}

	internal class ConvexHull2 // TypeDefIndex: 84989
	{
		// Nested types
		private class Edge // TypeDefIndex: 84988
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public Edge E0; // 0x18
			public Edge E1; // 0x20
			public int Sign; // 0x28
			public int Time; // 0x2C
	
			// Constructors
			public Edge(int v0, int v1); // 0x0000000187236770-0x0000000187236780
	
			// Methods
			public int GetSign(int i, Query2 query); // 0x0000000188C3EEE0-0x0000000188C3EF24
			public void Insert(Edge adj0, Edge adj1); // 0x0000000188C3EF24-0x0000000188C3EF7C
			public void DeleteSelf(); // 0x0000000188C3EDF8-0x0000000188C3EE38
			public void GetIndices(out int[] indices); // 0x0000000188C3EE38-0x0000000188C3EEE0
		}
	
		// Constructors
		public ConvexHull2(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static bool Create(IList<Vector2> vertices, float epsilon, out int dimension, out int[] indices); // 0x0000000188C342F8-0x0000000188C347E0
		private static bool Update(ref Edge hull, int i, Query2 query); // 0x0000000188C347E0-0x0000000188C349C0
	}

	internal class ConvexHull3 // TypeDefIndex: 84992
	{
		// Nested types
		private class Triangle // TypeDefIndex: 84990
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
			public Triangle(int v0, int v1, int v2); // 0x0000000187236780-0x00000001872367A0
	
			// Methods
			public Triangle GetAdj(int index); // 0x0000000188C3F4E4-0x0000000188C3F4FC
			public void SetAdj(int index, Triangle value); // 0x0000000188C3F560-0x0000000188C3F590
			public int GetV(int index); // 0x0000000188C3F548-0x0000000188C3F560
			public int GetSign(int i, Query3 query); // 0x0000000188C3F4FC-0x0000000188C3F548
			public void AttachTo(Triangle adj0, Triangle adj1, Triangle adj2); // 0x0000000188C3F410-0x0000000188C3F448
			public int DetachFrom(int adjIndex, Triangle adj); // 0x0000000188C3F448-0x0000000188C3F4E4
		}
	
		private class TerminatorData // TypeDefIndex: 84991
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public int NullIndex; // 0x18
			public Triangle T; // 0x20
	
			// Constructors
			public TerminatorData(int v0 = -1 /* Metadata: 0x0264474C */, int v1 = -1 /* Metadata: 0x0264474D */, int nullIndex = -1 /* Metadata: 0x0264474E */, Triangle tri = null); // 0x0000000188C3F3DC-0x0000000188C3F410
		}
	
		// Constructors
		public ConvexHull3(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static bool Create(IList<Vector3> vertices, float epsilon, out int dimension, out int[] indices); // 0x0000000188C349C0-0x0000000188C35224
		private static bool Update(HashSet<Triangle> hull, int i, Query3 query); // 0x0000000188C35440-0x0000000188C35CF0
		private static void ExtractIndices(HashSet<Triangle> hull, out int[] indices); // 0x0000000188C35224-0x0000000188C35440
	}

	public static class ConvexHull // TypeDefIndex: 84993
	{
		// Methods
		public static bool Create2D(IList<Vector2> points, out int[] indices, out int dimension, float epsilon = 1E-05f /* Metadata: 0x0264474F */); // 0x0000000188C35CF0-0x0000000188C35D98
		public static bool Create3D(IList<Vector3> points, out int[] indices, out int dimension, float epsilon = 1E-05f /* Metadata: 0x02644753 */); // 0x0000000188C35D98-0x0000000188C35E40
	}

	public static class Distance // TypeDefIndex: 84994
	{
		// Methods
		public static float Line2Line2(ref Line2 line0, ref Line2 line1); // 0x0000000188C374E4-0x0000000188C3750C
		public static float Line2Line2(ref Line2 line0, ref Line2 line1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C3750C-0x0000000188C3753C
		public static float SqrLine2Line2(ref Line2 line0, ref Line2 line1); // 0x0000000188C38800-0x0000000188C38964
		public static float SqrLine2Line2(ref Line2 line0, ref Line2 line1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C38964-0x0000000188C38BC8
		public static float Line2Ray2(ref Line2 line, ref Ray2 ray); // 0x0000000188C3753C-0x0000000188C37564
		public static float Line2Ray2(ref Line2 line, ref Ray2 ray, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C37564-0x0000000188C37594
		public static float SqrLine2Ray2(ref Line2 line, ref Ray2 ray); // 0x0000000188C38BC8-0x0000000188C38D70
		public static float SqrLine2Ray2(ref Line2 line, ref Ray2 ray, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C38D70-0x0000000188C39014
		public static float Line2Segment2(ref Line2 line, ref Segment2 segment); // 0x0000000188C375C4-0x0000000188C375EC
		public static float Line2Segment2(ref Line2 line, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C37594-0x0000000188C375C4
		public static float SqrLine2Segment2(ref Line2 line, ref Segment2 segment); // 0x0000000188C39014-0x0000000188C39250
		public static float SqrLine2Segment2(ref Line2 line, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C39250-0x0000000188C3953C
		public static float Point2AAB2(ref Vector2 point, ref AAB2 box); // 0x0000000188C37840-0x0000000188C378B4
		public static float Point2AAB2(ref Vector2 point, ref AAB2 box, out Vector2 closestPoint); // 0x0000000188C37780-0x0000000188C37840
		public static float SqrPoint2AAB2(ref Vector2 point, ref AAB2 box); // 0x0000000188C3A654-0x0000000188C3A6C4
		public static float SqrPoint2AAB2(ref Vector2 point, ref AAB2 box, out Vector2 closestPoint); // 0x0000000188C3A6C4-0x0000000188C3A780
		public static float Point2Box2(ref Vector2 point, ref Box2 box); // 0x0000000188C378DC-0x0000000188C37904
		public static float Point2Box2(ref Vector2 point, ref Box2 box, out Vector2 closestPoint); // 0x0000000188C378B4-0x0000000188C378DC
		public static float SqrPoint2Box2(ref Vector2 point, ref Box2 box); // 0x0000000188C3A780-0x0000000188C3A8A4
		public static float SqrPoint2Box2(ref Vector2 point, ref Box2 box, out Vector2 closestPoint); // 0x0000000188C3A8A4-0x0000000188C3AA80
		public static float Point2Circle2(ref Vector2 point, ref Circle2 circle); // 0x0000000188C379D0-0x0000000188C37A18
		public static float Point2Circle2(ref Vector2 point, ref Circle2 circle, out Vector2 closestPoint); // 0x0000000188C37904-0x0000000188C379D0
		public static float SqrPoint2Circle2(ref Vector2 point, ref Circle2 circle); // 0x0000000188C3AB50-0x0000000188C3ABA0
		public static float SqrPoint2Circle2(ref Vector2 point, ref Circle2 circle, out Vector2 closestPoint); // 0x0000000188C3AA80-0x0000000188C3AB50
		public static float Point2Line2(ref Vector2 point, ref Line2 line); // 0x0000000188C37A40-0x0000000188C37A68
		public static float Point2Line2(ref Vector2 point, ref Line2 line, out Vector2 closestPoint); // 0x0000000188C37A18-0x0000000188C37A40
		public static float SqrPoint2Line2(ref Vector2 point, ref Line2 line); // 0x0000000188C3ACA0-0x0000000188C3AD90
		public static float SqrPoint2Line2(ref Vector2 point, ref Line2 line, out Vector2 closestPoint); // 0x0000000188C3ABA0-0x0000000188C3ACA0
		public static float Point2Ray2(ref Vector2 point, ref Ray2 ray); // 0x0000000188C37A68-0x0000000188C37A90
		public static float Point2Ray2(ref Vector2 point, ref Ray2 ray, out Vector2 closestPoint); // 0x0000000188C37A90-0x0000000188C37AB8
		public static float SqrPoint2Ray2(ref Vector2 point, ref Ray2 ray); // 0x0000000188C3AEB8-0x0000000188C3AFBC
		public static float SqrPoint2Ray2(ref Vector2 point, ref Ray2 ray, out Vector2 closestPoint); // 0x0000000188C3AD90-0x0000000188C3AEB8
		public static float Point2Segment2(ref Vector2 point, ref Segment2 segment); // 0x0000000188C37AB8-0x0000000188C37AE0
		public static float Point2Segment2(ref Vector2 point, ref Segment2 segment, out Vector2 closestPoint); // 0x0000000188C37AE0-0x0000000188C37B08
		public static float SqrPoint2Segment2(ref Vector2 point, ref Segment2 segment); // 0x0000000188C3B10C-0x0000000188C3B234
		public static float SqrPoint2Segment2(ref Vector2 point, ref Segment2 segment, out Vector2 closestPoint); // 0x0000000188C3AFBC-0x0000000188C3B10C
		public static float Point2Triangle2(ref Vector2 point, ref Triangle2 triangle); // 0x0000000188C37B08-0x0000000188C37C70
		public static float Point2Triangle2(ref Vector2 point, ref Triangle2 triangle, out Vector2 closestPoint); // 0x0000000188C37C70-0x0000000188C37E28
		public static float SqrPoint2Triangle2(ref Vector2 point, ref Triangle2 triangle); // 0x0000000188C3B234-0x0000000188C3B39C
		public static float SqrPoint2Triangle2(ref Vector2 point, ref Triangle2 triangle, out Vector2 closestPoint); // 0x0000000188C3B39C-0x0000000188C3B554
		public static float Ray2Ray2(ref Ray2 ray0, ref Ray2 ray1); // 0x0000000188C38550-0x0000000188C38590
		public static float Ray2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C38520-0x0000000188C38550
		public static float SqrRay2Ray2(ref Ray2 ray0, ref Ray2 ray1); // 0x0000000188C3D40C-0x0000000188C3D438
		public static float SqrRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C3D0E4-0x0000000188C3D40C
		public static float Ray2Segment2(ref Ray2 ray, ref Segment2 segment); // 0x0000000188C38590-0x0000000188C385D0
		public static float Ray2Segment2(ref Ray2 ray, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C385D0-0x0000000188C38600
		public static float SqrRay2Segment2(ref Ray2 ray, ref Segment2 segment); // 0x0000000188C3D7C0-0x0000000188C3D7EC
		public static float SqrRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C3D438-0x0000000188C3D7C0
		public static float Segment2Segment2(ref Segment2 segment0, ref Segment2 segment1); // 0x0000000188C386F8-0x0000000188C38738
		public static float Segment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C386C8-0x0000000188C386F8
		public static float SqrSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1); // 0x0000000188C3E128-0x0000000188C3E154
		public static float SqrSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Vector2 closestPoint0, out Vector2 closestPoint1); // 0x0000000188C3E154-0x0000000188C3E668
		private static void Face(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref Vector3 PmE, ref float sqrDistance); // 0x0000000188C366A8-0x0000000188C374E4
		private static void CaseNoZeros(ref Box3 mBox, ref float mLineParameter, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance); // 0x0000000188C365C8-0x0000000188C366A8
		private static void Case0(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance); // 0x0000000188C36164-0x0000000188C365C8
		private static void Case00(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance); // 0x0000000188C35F54-0x0000000188C36164
		private static void Case000(ref Box3 mBox, ref float mLineParameter, ref Vector3 pnt, ref float sqrDistance); // 0x0000000188C35E40-0x0000000188C35F54
		public static float Line3Box3(ref Line3 line, ref Box3 box, out Line3Box3Dist info); // 0x0000000188C375EC-0x0000000188C37614
		public static float Line3Box3(ref Line3 line, ref Box3 box); // 0x0000000188C37614-0x0000000188C37654
		public static float SqrLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Dist info); // 0x0000000188C3953C-0x0000000188C39B34
		public static float SqrLine3Box3(ref Line3 line, ref Box3 box); // 0x0000000188C39B34-0x0000000188C39B60
		public static float Line3Line3(ref Line3 line0, ref Line3 line1); // 0x0000000188C37654-0x0000000188C37688
		public static float Line3Line3(ref Line3 line0, ref Line3 line1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C37688-0x0000000188C376B8
		public static float SqrLine3Line3(ref Line3 line0, ref Line3 line1); // 0x0000000188C39B60-0x0000000188C39B94
		public static float SqrLine3Line3(ref Line3 line0, ref Line3 line1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C39B94-0x0000000188C39EE4
		public static float Line3Ray3(ref Line3 line, ref Ray3 ray); // 0x0000000188C376B8-0x0000000188C376EC
		public static float Line3Ray3(ref Line3 line, ref Ray3 ray, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C376EC-0x0000000188C3771C
		public static float SqrLine3Ray3(ref Line3 line, ref Ray3 ray); // 0x0000000188C3A220-0x0000000188C3A254
		public static float SqrLine3Ray3(ref Line3 line, ref Ray3 ray, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C39EE4-0x0000000188C3A220
		public static float Line3Segment3(ref Line3 line, ref Segment3 segment); // 0x0000000188C3771C-0x0000000188C37750
		public static float Line3Segment3(ref Line3 line, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C37750-0x0000000188C37780
		public static float SqrLine3Segment3(ref Line3 line, ref Segment3 segment); // 0x0000000188C3A254-0x0000000188C3A288
		public static float SqrLine3Segment3(ref Line3 line, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C3A288-0x0000000188C3A654
		public static float Point3AAB3(ref Vector3 point, ref AAB3 box); // 0x0000000188C37E28-0x0000000188C37ECC
		public static float Point3AAB3(ref Vector3 point, ref AAB3 box, out Vector3 closestPoint); // 0x0000000188C37ECC-0x0000000188C37FDC
		public static float SqrPoint3AAB3(ref Vector3 point, ref AAB3 box); // 0x0000000188C3B660-0x0000000188C3B700
		public static float SqrPoint3AAB3(ref Vector3 point, ref AAB3 box, out Vector3 closestPoint); // 0x0000000188C3B554-0x0000000188C3B660
		public static float Point3Box3(ref Vector3 point, ref Box3 box); // 0x0000000188C38004-0x0000000188C3802C
		public static float Point3Box3(ref Vector3 point, ref Box3 box, out Vector3 closestPoint); // 0x0000000188C37FDC-0x0000000188C38004
		public static float SqrPoint3Box3(ref Vector3 point, ref Box3 box); // 0x0000000188C3B700-0x0000000188C3B8DC
		public static float SqrPoint3Box3(ref Vector3 point, ref Box3 box, out Vector3 closestPoint); // 0x0000000188C3B8DC-0x0000000188C3BC2C
		public static float Point3Circle3(ref Vector3 point, ref Circle3 circle, bool solid = true /* Metadata: 0x02644757 */); // 0x0000000188C3805C-0x0000000188C3809C
		public static float Point3Circle3(ref Vector3 point, ref Circle3 circle, out Vector3 closestPoint, bool solid = true /* Metadata: 0x02644758 */); // 0x0000000188C3802C-0x0000000188C3805C
		public static float SqrPoint3Circle3(ref Vector3 point, ref Circle3 circle, bool solid = true /* Metadata: 0x02644759 */); // 0x0000000188C3C010-0x0000000188C3C038
		public static float SqrPoint3Circle3(ref Vector3 point, ref Circle3 circle, out Vector3 closestPoint, bool solid = true /* Metadata: 0x0264475A */); // 0x0000000188C3BC2C-0x0000000188C3C010
		public static float Point3Line3(ref Vector3 point, ref Line3 line); // 0x0000000188C3809C-0x0000000188C380C4
		public static float Point3Line3(ref Vector3 point, ref Line3 line, out Vector3 closestPoint); // 0x0000000188C380C4-0x0000000188C380EC
		public static float SqrPoint3Line3(ref Vector3 point, ref Line3 line); // 0x0000000188C3C1B4-0x0000000188C3C328
		public static float SqrPoint3Line3(ref Vector3 point, ref Line3 line, out Vector3 closestPoint); // 0x0000000188C3C038-0x0000000188C3C1B4
		public static float Point3Plane3(ref Vector3 point, ref Plane3 plane); // 0x0000000188C38208-0x0000000188C382A8
		public static float Point3Plane3(ref Vector3 point, ref Plane3 plane, out Vector3 closestPoint); // 0x0000000188C380EC-0x0000000188C38208
		public static float SqrPoint3Plane3(ref Vector3 point, ref Plane3 plane); // 0x0000000188C3C440-0x0000000188C3C4E0
		public static float SqrPoint3Plane3(ref Vector3 point, ref Plane3 plane, out Vector3 closestPoint); // 0x0000000188C3C328-0x0000000188C3C440
		public static float Point3Ray3(ref Vector3 point, ref Ray3 ray); // 0x0000000188C382D0-0x0000000188C382F8
		public static float Point3Ray3(ref Vector3 point, ref Ray3 ray, out Vector3 closestPoint); // 0x0000000188C382A8-0x0000000188C382D0
		public static float SqrPoint3Ray3(ref Vector3 point, ref Ray3 ray); // 0x0000000188C3C684-0x0000000188C3C804
		public static float SqrPoint3Ray3(ref Vector3 point, ref Ray3 ray, out Vector3 closestPoint); // 0x0000000188C3C4E0-0x0000000188C3C684
		public static float Point3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle); // 0x0000000188C38320-0x0000000188C38348
		public static float Point3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle, out Vector3 closestPoint); // 0x0000000188C382F8-0x0000000188C38320
		public static float SqrPoint3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle); // 0x0000000188C3CA5C-0x0000000188C3CBF8
		public static float SqrPoint3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle, out Vector3 closestPoint); // 0x0000000188C3C804-0x0000000188C3CA5C
		public static float Point3Segment3(ref Vector3 point, ref Segment3 segment); // 0x0000000188C38370-0x0000000188C38398
		public static float Point3Segment3(ref Vector3 point, ref Segment3 segment, out Vector3 closestPoint); // 0x0000000188C38348-0x0000000188C38370
		public static float SqrPoint3Segment3(ref Vector3 point, ref Segment3 segment); // 0x0000000188C3CDB4-0x0000000188C3CF54
		public static float SqrPoint3Segment3(ref Vector3 point, ref Segment3 segment, out Vector3 closestPoint); // 0x0000000188C3CBF8-0x0000000188C3CDB4
		public static float Point3Sphere3(ref Vector3 point, ref Sphere3 sphere); // 0x0000000188C384AC-0x0000000188C38520
		public static float Point3Sphere3(ref Vector3 point, ref Sphere3 sphere, out Vector3 closestPoint); // 0x0000000188C38398-0x0000000188C384AC
		public static float SqrPoint3Sphere3(ref Vector3 point, ref Sphere3 sphere); // 0x0000000188C3CF54-0x0000000188C3CFCC
		public static float SqrPoint3Sphere3(ref Vector3 point, ref Sphere3 sphere, out Vector3 closestPoint); // 0x0000000188C3CFCC-0x0000000188C3D0E4
		public static float Ray3Ray3(ref Ray3 ray0, ref Ray3 ray1); // 0x0000000188C38630-0x0000000188C38664
		public static float Ray3Ray3(ref Ray3 ray0, ref Ray3 ray1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C38600-0x0000000188C38630
		public static float SqrRay3Ray3(ref Ray3 ray0, ref Ray3 ray1); // 0x0000000188C3DC10-0x0000000188C3DC44
		public static float SqrRay3Ray3(ref Ray3 ray0, ref Ray3 ray1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C3D7EC-0x0000000188C3DC10
		public static float Ray3Segment3(ref Ray3 ray, ref Segment3 segment); // 0x0000000188C38694-0x0000000188C386C8
		public static float Ray3Segment3(ref Ray3 ray, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C38664-0x0000000188C38694
		public static float SqrRay3Segment3(ref Ray3 ray, ref Segment3 segment); // 0x0000000188C3E0F4-0x0000000188C3E128
		public static float SqrRay3Segment3(ref Ray3 ray, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C3DC44-0x0000000188C3E0F4
		public static float Segment3Box3(ref Segment3 segment, ref Box3 box, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C38738-0x0000000188C38768
		public static float Segment3Box3(ref Segment3 segment, ref Box3 box); // 0x0000000188C38768-0x0000000188C3879C
		public static float SqrSegment3Box3(ref Segment3 segment, ref Box3 box, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C3E69C-0x0000000188C3E7A0
		public static float SqrSegment3Box3(ref Segment3 segment, ref Box3 box); // 0x0000000188C3E668-0x0000000188C3E69C
		public static float Segment3Segment3(ref Segment3 segment0, ref Segment3 segment1); // 0x0000000188C387CC-0x0000000188C38800
		public static float Segment3Segment3(ref Segment3 segment0, ref Segment3 segment1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C3879C-0x0000000188C387CC
		public static float SqrSegment3Segment3(ref Segment3 segment0, ref Segment3 segment1); // 0x0000000188C3E7A0-0x0000000188C3E7D4
		public static float SqrSegment3Segment3(ref Segment3 segment0, ref Segment3 segment1, out Vector3 closestPoint0, out Vector3 closestPoint1); // 0x0000000188C3E7D4-0x0000000188C3EDF8
	}

	public struct Line3Box3Dist // TypeDefIndex: 84995
	{
		// Fields
		public Vector3 ClosestPoint0; // 0x00
		public Vector3 ClosestPoint1; // 0x0C
		public float LineParameter; // 0x18
	}

	public static class Intersection // TypeDefIndex: 84996
	{
		// Fields
		private static float _intervalThreshold; // 0x00
		private static float _dotThreshold; // 0x04
		private static float _distanceThreshold; // 0x08
	
		// Properties
		public static float IntervalThreshold { get; set; } // 0x0000000188C53C44-0x0000000188C53C94 0x0000000188C53DC4-0x0000000188C53E58
		public static float DotThreshold { get; set; } // 0x0000000188C53BF4-0x0000000188C53C44 0x0000000188C53D2C-0x0000000188C53DC4
		public static float DistanceThreshold { get; set; } // 0x0000000188C53BA4-0x0000000188C53BF4 0x0000000188C53C94-0x0000000188C53D2C
	
		// Constructors
		static Intersection(); // 0x00000001871EDC40-0x00000001871EDCB0
	
		// Methods
		public static bool TestAAB2AAB2(ref AAB2 box0, ref AAB2 box1); // 0x0000000188C4BB58-0x0000000188C4BB88
		public static bool FindAAB2AAB2(ref AAB2 box0, ref AAB2 box1, out AAB2 intersection); // 0x0000000188C4204C-0x0000000188C420D8
		public static bool TestAAB2AAB2OverlapX(ref AAB2 box0, ref AAB2 box1); // 0x0000000188C4BB20-0x0000000188C4BB3C
		public static bool TestAAB2AAB2OverlapY(ref AAB2 box0, ref AAB2 box1); // 0x0000000188C4BB3C-0x0000000188C4BB58
		public static bool TestAAB2Circle2(ref AAB2 box, ref Circle2 circle); // 0x0000000185BF96F0-0x0000000185BF9760
		public static bool TestBox2Box2(ref Box2 box0, ref Box2 box1); // 0x0000000188C4BC24-0x0000000188C4BF14
		public static bool TestBox2Circle2(ref Box2 box, ref Circle2 circle); // 0x0000000188C4BF14-0x0000000188C4C068
		public static bool TestCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1); // 0x0000000186187940-0x00000001861879B0
		public static bool FindCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1, out Circle2Circle2Intr info); // 0x0000000188C421C4-0x0000000188C424E8
		private static int WhichSide(Polygon2 V, Vector2 P, ref Vector2 D); // 0x0000000188C53898-0x0000000188C539C8
		public static bool TestConvexPolygon2ConvexPolygon2(Polygon2 convexPolygon0, Polygon2 convexPolygon1); // 0x0000000188C4CD4C-0x0000000188C4CF44
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref AAB2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType); // 0x0000000188C41D58-0x0000000188C4204C
		public static bool TestLine2AAB2(ref Line2 line, ref AAB2 box); // 0x0000000188C4CF44-0x0000000188C4D0EC
		public static bool FindLine2AAB2(ref Line2 line, ref AAB2 box, out Line2AAB2Intr info); // 0x0000000188C424E8-0x0000000188C42588
		private static bool Clip(float denom, float numer, ref float t0, ref float t1); // 0x0000000188C40BC8-0x0000000188C40C30
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref Box2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType); // 0x0000000188C413D8-0x0000000188C41748
		public static bool TestLine2Box2(ref Line2 line, ref Box2 box); // 0x0000000188C4D0EC-0x0000000188C4D1E0
		public static bool FindLine2Box2(ref Line2 line, ref Box2 box, out Line2Box2Intr info); // 0x0000000188C42588-0x0000000188C42628
		private static bool Find(ref Vector2 origin, ref Vector2 direction, ref Vector2 center, float radius, out int rootCount, out float t0, out float t1); // 0x0000000188C4A8A8-0x0000000188C4AA08
		public static bool TestLine2Circle2(ref Line2 line, ref Circle2 circle); // 0x0000000188C4D1E0-0x0000000188C4D27C
		public static bool FindLine2Circle2(ref Line2 line, ref Circle2 circle, out Line2Circle2Intr info); // 0x0000000188C42628-0x0000000188C42808
		public static bool TestLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon); // 0x0000000188C4D27C-0x0000000188C4D384
		public static bool FindLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon, out Line2ConvexPolygon2Intr info); // 0x0000000188C42808-0x0000000188C42BA4
		private static IntersectionTypes Classify(ref Line2 line0, ref Line2 line1, out float s0); // 0x0000000188C3F898-0x0000000188C3FA3C
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1, out IntersectionTypes intersectionType); // 0x0000000188C4D3E4-0x0000000188C4D458
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1); // 0x0000000188C4D384-0x0000000188C4D3E4
		public static bool FindLine2Line2(ref Line2 line0, ref Line2 line1, out Line2Line2Intr info); // 0x0000000188C42BA4-0x0000000188C42C98
		private static IntersectionTypes Classify(ref Line2 line, ref Ray2 ray, out float s0, out float s1); // 0x0000000188C3FF68-0x0000000188C40150
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray, out IntersectionTypes intersectionType); // 0x0000000188C4D4B8-0x0000000188C4D57C
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray); // 0x0000000188C4D458-0x0000000188C4D4B8
		public static bool FindLine2Ray2(ref Line2 line, ref Ray2 ray, out Line2Ray2Intr info); // 0x0000000188C42C98-0x0000000188C42DEC
		private static IntersectionTypes Classify(ref Segment2 segment, ref Line2 line, out float s0, out float s1); // 0x0000000188C40150-0x0000000188C4033C
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment, out IntersectionTypes intersectionType); // 0x0000000188C4D5DC-0x0000000188C4D684
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment); // 0x0000000188C4D57C-0x0000000188C4D5DC
		public static bool FindLine2Segment2(ref Line2 line, ref Segment2 segment, out Line2Segment2Intr info); // 0x0000000188C42DEC-0x0000000188C42F2C
		private static void TriangleLineRelations(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, out float dist0, out float dist1, out float dist2, out int sign0, out int sign1, out int sign2, out int positive, out int negative, out int zero); // 0x0000000188C533AC-0x0000000188C53664
		private static bool GetInterval(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, float dist0, float dist1, float dist2, int sign0, int sign1, int sign2, out float param0, out float param1); // 0x0000000188C4B088-0x0000000188C4B308
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out IntersectionTypes intersectionType); // 0x0000000188C4D684-0x0000000188C4D84C
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle); // 0x0000000188C4D84C-0x0000000188C4D8AC
		public static bool FindLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out Line2Triangle2Intr info); // 0x0000000188C42F2C-0x0000000188C43224
		public static bool TestRay2AAB2(ref Ray2 ray, ref AAB2 box); // 0x0000000188C4EBE4-0x0000000188C4ED1C
		public static bool FindRay2AAB2(ref Ray2 ray, ref AAB2 box, out Ray2AAB2Intr info); // 0x0000000188C44ECC-0x0000000188C44F68
		public static bool TestRay2Box2(ref Ray2 ray, ref Box2 box); // 0x0000000188C4ED1C-0x0000000188C4EEF8
		public static bool FindRay2Box2(ref Ray2 ray, ref Box2 box, out Ray2Box2Intr info); // 0x0000000188C44F68-0x0000000188C45004
		public static bool TestRay2Circle2(ref Ray2 ray, ref Circle2 circle); // 0x0000000188C4EEF8-0x0000000188C4EFA0
		public static bool FindRay2Circle2(ref Ray2 ray, ref Circle2 circle, out Ray2Circle2Intr info); // 0x0000000188C45004-0x0000000188C45248
		public static bool TestRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon); // 0x0000000188C4EFA0-0x0000000188C4F0A8
		public static bool FindRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon, out Ray2ConvexPolygon2Intr info); // 0x0000000188C45248-0x0000000188C455E0
		public static bool TestRay2Polygon2(ref Ray2 ray, Polygon2 polygon); // 0x0000000188C4F0A8-0x0000000188C4F1B0
		public static bool TestRay2Polygon2(ref Ray2 ray, Segment2[] segments); // 0x0000000188C4F1B0-0x0000000188C4F250
		public static bool FindRay2Polygon2(ref Ray2 ray, Polygon2 polygon, out Ray2Polygon2Intr info); // 0x0000000188C4575C-0x0000000188C45954
		public static bool FindRay2Polygon2(ref Ray2 ray, Segment2[] segments, out Ray2Polygon2Intr info); // 0x0000000188C455E0-0x0000000188C4575C
		private static IntersectionTypes Classify(ref Ray2 ray0, ref Ray2 ray1, out float s0, out float s1); // 0x0000000188C3F664-0x0000000188C3F898
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out IntersectionTypes intersectionType); // 0x0000000188C4F250-0x0000000188C4F3B8
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1); // 0x0000000188C4F3B8-0x0000000188C4F418
		public static bool FindRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Ray2Ray2Intr info); // 0x0000000188C45954-0x0000000188C45B54
		private static IntersectionTypes Classify(ref Ray2 ray, ref Segment2 segment, out float s0, out float s1); // 0x0000000188C3FCD4-0x0000000188C3FF68
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment, out IntersectionTypes intersectionType); // 0x0000000188C4F478-0x0000000188C4F5D8
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment); // 0x0000000188C4F418-0x0000000188C4F478
		public static bool FindRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Ray2Segment2Intr info); // 0x0000000188C45B54-0x0000000188C45DE0
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out IntersectionTypes intersectionType); // 0x0000000188C4F5D8-0x0000000188C4F79C
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle); // 0x0000000188C4F79C-0x0000000188C4F7FC
		public static bool FindRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out Ray2Triangle2Intr info); // 0x0000000188C45DE0-0x0000000188C460D0
		public static bool TestSegment2AAB2(ref Segment2 segment, ref AAB2 box); // 0x0000000188C5086C-0x0000000188C509AC
		public static bool FindSegment2AAB2(ref Segment2 segment, ref AAB2 box, out Segment2AAB2Intr info); // 0x0000000188C475F8-0x0000000188C476B8
		public static bool TestSegment2Box2(ref Segment2 segment, ref Box2 box); // 0x0000000188C509AC-0x0000000188C50BAC
		public static bool FindSegment2Box2(ref Segment2 segment, ref Box2 box, out Segment2Box2Intr info); // 0x0000000188C476B8-0x0000000188C47778
		public static bool TestSegment2Circle2(ref Segment2 segment, ref Circle2 circle); // 0x0000000188C50BAC-0x0000000188C50C84
		public static bool FindSegment2Circle2(ref Segment2 segment, ref Circle2 circle, out Segment2Circle2Intr info); // 0x0000000188C47778-0x0000000188C47A1C
		public static bool TestSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon); // 0x0000000188C50C84-0x0000000188C50CE8
		public static bool FindSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon, out Segment2ConvexPolygon2Intr info); // 0x0000000188C47A1C-0x0000000188C47DB8
		private static IntersectionTypes Classify(ref Segment2 segment0, ref Segment2 segment1, out float s0, out float s1); // 0x0000000188C3FA3C-0x0000000188C3FCD4
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out IntersectionTypes intersectionType); // 0x0000000188C50D48-0x0000000188C50EC0
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1); // 0x0000000188C50CE8-0x0000000188C50D48
		public static bool FindSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Segment2Segment2Intr info); // 0x0000000188C47DB8-0x0000000188C480D4
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out IntersectionTypes intersectionType); // 0x0000000188C50F20-0x0000000188C51108
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle); // 0x0000000188C50EC0-0x0000000188C50F20
		public static bool FindSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out Segment2Triangle2Intr info); // 0x0000000188C480D4-0x0000000188C48404
		private static int WhichSide(ref Triangle2 triangle, ref Vector2 P, ref Vector2 D); // 0x0000000188C539C8-0x0000000188C53BA4
		private static void ClipConvexPolygonAgainstLine(ref Vector2 edgeStart, ref Vector2 edgeEnd, ref int quantity, ref Triangle2Triangle2Intr info); // 0x0000000188C4033C-0x0000000188C40BC8
		public static bool TestTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1); // 0x0000000188C52260-0x0000000188C52490
		public static bool FindTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1, out Triangle2Triangle2Intr info); // 0x0000000188C49E48-0x0000000188C49F8C
		public static bool TestAAB3AAB3(ref AAB3 box0, ref AAB3 box1); // 0x0000000188C4BBDC-0x0000000188C4BC24
		public static bool FindAAB3AAB3(ref AAB3 box0, ref AAB3 box1, out AAB3 intersection); // 0x0000000188C420D8-0x0000000188C421C4
		public static bool TestAAB3AAB3OverlapX(ref AAB3 box0, ref AAB3 box1); // 0x0000000188C4BB88-0x0000000188C4BBA4
		public static bool TestAAB3AAB3OverlapY(ref AAB3 box0, ref AAB3 box1); // 0x0000000188C4BBA4-0x0000000188C4BBC0
		public static bool TestAAB3AAB3OverlapZ(ref AAB3 box0, ref AAB3 box1); // 0x0000000188C4BBC0-0x0000000188C4BBDC
		public static bool TestAAB3Sphere3(ref AAB3 box, ref Sphere3 sphere); // 0x0000000185C967C0-0x0000000185C96850
		public static bool TestBox3Box3(ref Box3 box0, ref Box3 box1); // 0x0000000188C4C068-0x0000000188C4CB20
		public static bool TestBox3Capsule3(ref Box3 box, ref Capsule3 capsule); // 0x0000000188C4CB20-0x0000000188C4CB48
		public static bool TestBox3Sphere3(ref Box3 box, ref Sphere3 sphere); // 0x0000000188C4CB48-0x0000000188C4CD4C
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref AAB3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType); // 0x0000000188C40F70-0x0000000188C413D8
		public static bool TestLine3AAB3(ref Line3 line, ref AAB3 box); // 0x0000000188C4D8AC-0x0000000188C4DA48
		public static bool FindLine3AAB3(ref Line3 line, ref AAB3 box, out Line3AAB3Intr info); // 0x0000000188C43224-0x0000000188C432C4
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref Box3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType); // 0x0000000188C41748-0x0000000188C41D58
		public static bool TestLine3Box3(ref Line3 line, ref Box3 box); // 0x0000000188C4DA48-0x0000000188C4DD08
		public static bool FindLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Intr info); // 0x0000000188C432C4-0x0000000188C43364
		public static bool TestLine3Circle3(ref Line3 line, ref Circle3 circle); // 0x0000000188C4DD08-0x0000000188C4DD68
		public static bool FindLine3Circle3(ref Line3 line, ref Circle3 circle, out Line3Circle3Intr info); // 0x0000000188C43364-0x0000000188C4357C
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane, out IntersectionTypes intersectionType); // 0x0000000188C4DD68-0x0000000188C4DEA4
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane); // 0x0000000188C4DEA4-0x0000000188C4DF04
		public static bool FindLine3Plane3(ref Line3 line, ref Plane3 plane, out Line3Plane3Intr info); // 0x0000000188C4357C-0x0000000188C43704
		public static bool TestLine3Polygon3(ref Line3 line, Polygon3 polygon); // 0x0000000188C4DF04-0x0000000188C4DF64
		public static bool FindLine3Polygon3(ref Line3 line, Polygon3 polygon, out Line3Polygon3Intr info); // 0x0000000188C43704-0x0000000188C438E8
		private static bool Point3InsideRectangle3(ref Vector3 point, ref Rectangle3 rectangle); // 0x0000000188C4B75C-0x0000000188C4B88C
		public static bool TestLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle); // 0x0000000188C4DF64-0x0000000188C4DFC4
		public static bool FindLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle, out Line3Rectangle3Intr info); // 0x0000000188C438E8-0x0000000188C43AD4
		public static bool TestLine3Sphere3(ref Line3 line, ref Sphere3 sphere); // 0x0000000188C4DFC4-0x0000000188C4E0D8
		public static bool FindLine3Sphere3(ref Line3 line, ref Sphere3 sphere, out Line3Sphere3Intr info); // 0x0000000188C43AD4-0x0000000188C43DC8
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out IntersectionTypes intersectionType); // 0x0000000188C4E440-0x0000000188C4E774
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000188C4E37C-0x0000000188C4E440
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000188C4E1F8-0x0000000188C4E2BC
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle); // 0x0000000188C4E0D8-0x0000000188C4E138
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000188C4E2BC-0x0000000188C4E37C
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000188C4E138-0x0000000188C4E1F8
		public static bool FindLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out Line3Triangle3Intr info); // 0x0000000188C43F50-0x0000000188C44358
		public static bool FindLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Line3Triangle3Intr info); // 0x0000000188C43DC8-0x0000000188C43E8C
		public static bool FindLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out Line3Triangle3Intr info); // 0x0000000188C43E8C-0x0000000188C43F50
		public static bool TestPlane3AAB3(ref Plane3 plane, ref AAB3 box); // 0x0000000188C4E774-0x0000000188C4E844
		public static bool TestPlane3Box3(ref Plane3 plane, ref Box3 box); // 0x0000000188C4E844-0x0000000188C4E9B0
		public static bool TestPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1); // 0x0000000188C4E9B0-0x0000000188C4EA50
		public static bool FindPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1, out Plane3Plane3Intr info); // 0x0000000188C44358-0x0000000188C44590
		public static bool TestPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere); // 0x0000000188C4EA50-0x0000000188C4EA84
		public static bool FindPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere, out Plane3Sphere3Intr info); // 0x0000000188C44590-0x0000000188C44718
		public static bool TestPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle); // 0x0000000188C4EA84-0x0000000188C4EBE4
		public static bool FindPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle, out Plane3Triangle3Intr info); // 0x0000000188C44718-0x0000000188C44ECC
		public static bool TestRay3AAB3(ref Ray3 ray, ref AAB3 box); // 0x0000000188C4F7FC-0x0000000188C4FA48
		public static bool FindRay3AAB3(ref Ray3 ray, ref AAB3 box, out Ray3AAB3Intr info); // 0x0000000188C460D0-0x0000000188C4616C
		public static bool TestRay3Box3(ref Ray3 ray, ref Box3 box); // 0x0000000188C4FA48-0x0000000188C4FE10
		public static bool FindRay3Box3(ref Ray3 ray, ref Box3 box, out Ray3Box3Intr info); // 0x0000000188C4616C-0x0000000188C46208
		public static bool TestRay3Circle3(ref Ray3 ray, ref Circle3 circle); // 0x0000000188C4FE10-0x0000000188C4FE70
		public static bool FindRay3Circle3(ref Ray3 ray, ref Circle3 circle, out Ray3Circle3Intr info); // 0x0000000188C46208-0x0000000188C46490
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane, out IntersectionTypes intersectionType); // 0x0000000188C4FED4-0x0000000188C4FF4C
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane); // 0x0000000188C4FE70-0x0000000188C4FED4
		public static bool FindRay3Plane3(ref Ray3 ray, ref Plane3 plane, out Ray3Plane3Intr info); // 0x0000000188C46490-0x0000000188C4669C
		public static bool TestRay3Polygon3(ref Ray3 ray, Polygon3 polygon); // 0x0000000188C4FF4C-0x0000000188C4FFAC
		public static bool FindRay3Polygon3(ref Ray3 ray, Polygon3 polygon, out Ray3Polygon3Intr info); // 0x0000000188C4669C-0x0000000188C468F8
		public static bool TestRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle); // 0x0000000188C4FFAC-0x0000000188C5000C
		public static bool FindRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle, out Ray3Rectangle3Intr info); // 0x0000000188C468F8-0x0000000188C46B50
		public static bool TestRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere); // 0x0000000188C5000C-0x0000000188C50154
		public static bool FindRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere, out Ray3Sphere3Intr info); // 0x0000000188C46B50-0x0000000188C46F20
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out IntersectionTypes intersectionType); // 0x0000000188C504BC-0x0000000188C5086C
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000188C50154-0x0000000188C50218
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000188C50218-0x0000000188C502DC
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle); // 0x0000000188C5039C-0x0000000188C503FC
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000188C503FC-0x0000000188C504BC
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000188C502DC-0x0000000188C5039C
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out Ray3Triangle3Intr info); // 0x0000000188C46FE4-0x0000000188C4741C
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Ray3Triangle3Intr info); // 0x0000000188C46F20-0x0000000188C46FE4
		public static bool FindRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out Ray3Triangle3Intr info); // 0x0000000188C4741C-0x0000000188C474E0
		public static bool TestSegment3AAB3(ref Segment3 segment, ref AAB3 box); // 0x0000000188C51108-0x0000000188C51354
		public static bool FindSegment3AAB3(ref Segment3 segment, ref AAB3 box, out Segment3AAB3Intr info); // 0x0000000188C48404-0x0000000188C484C4
		public static bool TestSegment3Box3(ref Segment3 segment, ref Box3 box); // 0x0000000188C51354-0x0000000188C51708
		public static bool FindSegment3Box3(ref Segment3 segment, ref Box3 box, out Segment3Box3Intr info); // 0x0000000188C484C4-0x0000000188C48584
		public static bool TestSegment3Circle3(ref Segment3 segment, ref Circle3 circle); // 0x0000000188C51708-0x0000000188C51768
		public static bool FindSegment3Circle3(ref Segment3 segment, ref Circle3 circle, out Segment3Circle3Intr info); // 0x0000000188C48584-0x0000000188C48818
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out IntersectionTypes intersectionType); // 0x0000000188C517C8-0x0000000188C51918
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane); // 0x0000000188C51768-0x0000000188C517C8
		public static bool FindSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out Segment3Plane3Intr info); // 0x0000000188C48818-0x0000000188C48A5C
		public static bool TestSegment3Polygon3(ref Segment3 segment, Polygon3 polygon); // 0x0000000188C51918-0x0000000188C51978
		public static bool FindSegment3Polygon3(ref Segment3 segment, Polygon3 polygon, out Segment3Polygon3Intr info); // 0x0000000188C48A5C-0x0000000188C48CB4
		public static bool TestSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle); // 0x0000000188C51978-0x0000000188C519D8
		public static bool FindSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle, out Segment3Rectangle3Intr info); // 0x0000000188C48CB4-0x0000000188C48F18
		public static bool TestSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere); // 0x0000000188C519D8-0x0000000188C51B4C
		public static bool FindSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere, out Segment3Sphere3Intr info); // 0x0000000188C48F18-0x0000000188C49388
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out IntersectionTypes intersectionType); // 0x0000000188C51E54-0x0000000188C52200
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000188C51D90-0x0000000188C51E54
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType); // 0x0000000188C51C0C-0x0000000188C51CD0
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle); // 0x0000000188C52200-0x0000000188C52260
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000188C51CD0-0x0000000188C51D90
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000188C51B4C-0x0000000188C51C0C
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out Segment3Triangle3Intr info); // 0x0000000188C4944C-0x0000000188C498D4
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Segment3Triangle3Intr info); // 0x0000000188C498D4-0x0000000188C49998
		public static bool FindSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out Segment3Triangle3Intr info); // 0x0000000188C49388-0x0000000188C4944C
		public static bool TestSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1); // 0x0000000185C96850-0x0000000185C968D0
		public static bool FindSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1, out Sphere3Sphere3Intr info); // 0x0000000188C49998-0x0000000188C49E48
		private static void ProjectOntoAxis(ref Triangle3 triangle, ref Vector3 axis, out float fmin, out float fmax); // 0x0000000188C4B88C-0x0000000188C4B9F0
		private static void TrianglePlaneRelations(ref Triangle3 triangle, ref Plane3 plane, out float dist0, out float dist1, out float dist2, out int sign0, out int sign1, out int sign2, out int positive, out int negative, out int zero); // 0x0000000188C53718-0x0000000188C53898
		private static bool TrianglePlaneRelationsQuick(ref Triangle3 triangle, ref Plane3 plane); // 0x0000000188C53664-0x0000000188C53718
		private static bool IntersectsSegment(ref Plane3 plane, ref Triangle3 triangle, ref Vector3 end0, ref Vector3 end1, bool grazing, out Triangle3Triangle3Intr info); // 0x0000000188C4B308-0x0000000188C4B75C
		private static int QueryToLine(ref Vector2 test, ref Vector2 vec0, ref Vector2 vec1); // 0x0000000188C4B9F0-0x0000000188C4BA44
		private static int QueryToTriangle(ref Vector2 test, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x0000000188C4BA44-0x0000000188C4BB20
		private static bool ContainsPoint(ref Triangle3 triangle, ref Plane3 plane, ref Vector3 point, out Triangle3Triangle3Intr info); // 0x0000000188C40C30-0x0000000188C40F70
		private static bool GetCoplanarIntersection(ref Plane3 plane, ref Triangle3 tri0, ref Triangle3 tri1, out Triangle3Triangle3Intr info); // 0x0000000188C4AA08-0x0000000188C4B088
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out IntersectionTypes intersectionType); // 0x0000000188C52490-0x0000000188C5334C
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1); // 0x0000000188C5334C-0x0000000188C533AC
		public static bool FindTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out Triangle3Triangle3Intr info, bool reportCoplanarIntersections = false /* Metadata: 0x0264475B */); // 0x0000000188C49F8C-0x0000000188C4A8A8
		public static int FindSegment1Segment1(float seg0Start, float seg0End, float seg1Start, float seg1End, out float w0, out float w1); // 0x0000000188C474E0-0x0000000188C475F8
	}

	public struct Circle2Circle2Intr // TypeDefIndex: 84997
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2AAB2Intr // TypeDefIndex: 84998
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2Box2Intr // TypeDefIndex: 84999
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2Circle2Intr // TypeDefIndex: 85000
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Line2ConvexPolygon2Intr // TypeDefIndex: 85001
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Line2Line2Intr // TypeDefIndex: 85002
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Ray2Intr // TypeDefIndex: 85003
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Segment2Intr // TypeDefIndex: 85004
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Triangle2Intr // TypeDefIndex: 85005
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2AAB2Intr // TypeDefIndex: 85006
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2Box2Intr // TypeDefIndex: 85007
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2Circle2Intr // TypeDefIndex: 85008
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Ray2ConvexPolygon2Intr // TypeDefIndex: 85009
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Ray2Polygon2Intr // TypeDefIndex: 85010
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Ray2Ray2Intr // TypeDefIndex: 85011
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Ray2Segment2Intr // TypeDefIndex: 85012
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Ray2Triangle2Intr // TypeDefIndex: 85013
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2AAB2Intr // TypeDefIndex: 85014
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2Box2Intr // TypeDefIndex: 85015
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2Circle2Intr // TypeDefIndex: 85016
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Segment2ConvexPolygon2Intr // TypeDefIndex: 85017
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Segment2Segment2Intr // TypeDefIndex: 85018
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Segment2Triangle2Intr // TypeDefIndex: 85019
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Triangle2Triangle2Intr // TypeDefIndex: 85020
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
		public Vector2 this[int i] { get => default; internal set {} } // 0x0000000188C59818-0x0000000188C59894 0x0000000188C59894-0x0000000188C598D0
	}

	internal struct Float6 // TypeDefIndex: 85021
	{
		// Fields
		private float _0; // 0x00
		private float _1; // 0x04
		private float _2; // 0x08
		private float _3; // 0x0C
		private float _4; // 0x10
		private float _5; // 0x14
	
		// Properties
		public float this[int i] { get => default; set {} } // 0x0000000188C53F3C-0x0000000188C53F80 0x0000000188C53F80-0x0000000188C53FD8
	}

	public struct Line3AAB3Intr // TypeDefIndex: 85022
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Line3Box3Intr // TypeDefIndex: 85023
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Line3Circle3Intr // TypeDefIndex: 85024
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Plane3Intr // TypeDefIndex: 85025
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float LineParameter; // 0x10
	}

	public struct Line3Polygon3Intr // TypeDefIndex: 85026
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Rectangle3Intr // TypeDefIndex: 85027
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Sphere3Intr // TypeDefIndex: 85028
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float LineParameter0; // 0x20
		public float LineParameter1; // 0x24
	}

	public struct Line3Triangle3Intr // TypeDefIndex: 85029
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float LineParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public struct Plane3Plane3Intr // TypeDefIndex: 85030
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Line3 Line; // 0x04
	}

	public struct Plane3Sphere3Intr // TypeDefIndex: 85031
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Circle3 Circle; // 0x04
	}

	public struct Plane3Triangle3Intr // TypeDefIndex: 85032
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public Vector3 Point2; // 0x20
	}

	public struct Ray3AAB3Intr // TypeDefIndex: 85033
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Ray3Box3Intr // TypeDefIndex: 85034
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Ray3Circle3Intr // TypeDefIndex: 85035
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Plane3Intr // TypeDefIndex: 85036
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float RayParameter; // 0x10
	}

	public struct Ray3Polygon3Intr // TypeDefIndex: 85037
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Rectangle3Intr // TypeDefIndex: 85038
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Sphere3Intr // TypeDefIndex: 85039
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float RayParameter0; // 0x20
		public float RayParameter1; // 0x24
	}

	public struct Ray3Triangle3Intr // TypeDefIndex: 85040
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float RayParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public struct Segment3AAB3Intr // TypeDefIndex: 85041
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Segment3Box3Intr // TypeDefIndex: 85042
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Segment3Circle3Intr // TypeDefIndex: 85043
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Plane3Intr // TypeDefIndex: 85044
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float SegmentParameter; // 0x10
	}

	public struct Segment3Polygon3Intr // TypeDefIndex: 85045
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Rectangle3Intr // TypeDefIndex: 85046
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Sphere3Intr // TypeDefIndex: 85047
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float SegmentParameter0; // 0x20
		public float SegmentParameter1; // 0x24
	}

	public struct Segment3Triangle3Intr // TypeDefIndex: 85048
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float SegmentParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public enum Sphere3Sphere3IntrTypes // TypeDefIndex: 85049
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

	public struct Sphere3Sphere3Intr // TypeDefIndex: 85050
	{
		// Fields
		public Sphere3Sphere3IntrTypes IntersectionType; // 0x00
		public Circle3 Circle; // 0x04
		public Vector3 ContactPoint; // 0x38
	}

	public struct Triangle3Triangle3Intr // TypeDefIndex: 85051
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
		public Vector3 this[int i] { get => default; internal set {} } // 0x0000000188C598D0-0x0000000188C59960 0x0000000188C59960-0x0000000188C599EC
	}

	public enum IntersectionTypes // TypeDefIndex: 85052
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

	public interface ILogger // TypeDefIndex: 85053
	{
		// Methods
		void LogInfo(object value);
		void LogWarning(object value);
		void LogError(object value);
	}

	public class Logger // TypeDefIndex: 85054
	{
		// Fields
		private static ILogger _instance; // 0x00
	
		// Constructors
		static Logger(); // 0x0000000188C54304-0x0000000188C54374
		public Logger(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void LogInfo(object value); // 0x0000000188C54154-0x0000000188C541E4
		public static void LogWarning(object value); // 0x0000000188C541E4-0x0000000188C5427C
		public static void LogError(object value); // 0x0000000188C540C0-0x0000000188C54154
		public static void SetLogger(ILogger logger); // 0x0000000188C5427C-0x0000000188C54304
	}

	public class DefaultLogger : ILogger // TypeDefIndex: 85055
	{
		// Constructors
		public DefaultLogger(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void LogInfo(object value); // 0x0000000188C53EA4-0x0000000188C53EF0
		public void LogWarning(object value); // 0x0000000188C53EF0-0x0000000188C53F3C
		public void LogError(object value); // 0x0000000188C53E58-0x0000000188C53EA4
	}

	public class EmptyLogger : ILogger // TypeDefIndex: 85056
	{
		// Constructors
		public EmptyLogger(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void LogInfo(object value); // 0x0000000186805BA0-0x0000000186805BB0
		public void LogWarning(object value); // 0x0000000186805BA0-0x0000000186805BB0
		public void LogError(object value); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class Mathfex // TypeDefIndex: 85057
	{
		// Fields
		public const float ZeroTolerance = 1E-05f; // Metadata: 0x02644775
		public const float NegativeZeroTolerance = -1E-05f; // Metadata: 0x02644779
		public const float ZeroToleranceSqr = 9.9999994E-11f; // Metadata: 0x0264477D
		public const float Pi = 3.1415927f; // Metadata: 0x02644781
		public const float HalfPi = 1.5707964f; // Metadata: 0x02644785
		public const float TwoPi = 6.2831855f; // Metadata: 0x02644789
	
		// Methods
		public static float EvalSquared(float x); // 0x00000001872355E0-0x00000001872355F0
		public static float EvalInvSquared(float x); // 0x0000000187235570-0x0000000187235590
		public static float EvalCubic(float x); // 0x00000001872367F0-0x0000000187236800
		public static float EvalInvCubic(float x); // 0x0000000187236860-0x0000000187236870
		public static float EvalQuadratic(float x, float a, float b, float c); // 0x0000000187236870-0x0000000187236890
		public static float EvalSigmoid(float x); // 0x0000000187236890-0x00000001872368B0
		public static float EvalOverlappedStep(float x, float overlap, int objectIndex, int objectCount); // 0x0000000188C54774-0x0000000188C547C4
		public static float EvalSmoothOverlappedStep(float x, float overlap, int objectIndex, int objectCount); // 0x0000000188C547C4-0x0000000188C5482C
		public static float EvalGaussian(float x, float a, float b, float c); // 0x0000000188C54738-0x0000000188C54774
		public static float EvalGaussian2D(float x, float y, float x0, float y0, float A, float a, float b, float c); // 0x0000000187236800-0x0000000187236860
		public static float Lerp(float value0, float value1, float factor); // 0x0000000188C548DC-0x0000000188C5490C
		public static float LerpUnclamped(float value0, float value1, float factor); // 0x00000001872368B0-0x00000001872368C0
		public static float SigmoidInterp(float value0, float value1, float factor); // 0x0000000188C54930-0x0000000188C5497C
		public static float SinInterp(float value0, float value1, float factor); // 0x0000000188C5497C-0x0000000188C549D8
		public static float CosInterp(float value0, float value1, float factor); // 0x0000000188C5465C-0x0000000188C546D0
		public static float WobbleInterp(float value0, float value1, float factor); // 0x0000000188C549D8-0x0000000188C54ABC
		public static float CurveInterp(float value0, float value1, float factor, AnimationCurve curve); // 0x0000000188C546D0-0x0000000188C54738
		public static float FuncInterp(float value0, float value1, float factor, Func<float, float> func); // 0x0000000188C5482C-0x0000000188C548AC
		public static float InvSqrt(float value); // 0x0000000188C548AC-0x0000000188C548DC
		public static bool Near(float value0, float value1, float epsilon = 1E-05f /* Metadata: 0x0264476D */); // 0x0000000188C5491C-0x0000000188C54930
		public static bool NearZero(float value, float epsilon = 1E-05f /* Metadata: 0x02644771 */); // 0x0000000188C5490C-0x0000000188C5491C
		public static Vector2 CartesianToPolar(Vector2 cartesianCoordinates); // 0x0000000188C5445C-0x0000000188C54540
		public static Vector2 PolarToCartesian(Vector2 polarCoordinates); // 0x00000001872368C0-0x0000000187236910
		public static Vector3 CartesianToSpherical(Vector3 cartesianCoordinates); // 0x0000000188C54540-0x0000000188C5465C
		public static Vector3 SphericalToCartesian(Vector3 sphericalCoordinates); // 0x0000000187236910-0x00000001872369B0
		public static Vector3 CartesianToCylindrical(Vector3 cartesianCoordinates); // 0x0000000188C54374-0x0000000188C5445C
		public static Vector3 CylindricalToCartesian(Vector3 cylindricalCoordinates); // 0x00000001872367A0-0x00000001872367F0
	}

	public static class Matrix4x4ex // TypeDefIndex: 85058
	{
		// Fields
		public static readonly Matrix4x4 Identity; // 0x00
	
		// Constructors
		static Matrix4x4ex(); // 0x0000000188C573C0-0x0000000188C57448
	
		// Methods
		public static void RotationMatrixToQuaternion(ref Matrix4x4 matrix, out Quaternion quaternion); // 0x0000000188C572F8-0x0000000188C573C0
		public static void QuaternionToRotationMatrix(Quaternion quaternion, out Matrix4x4 matrix); // 0x0000000187237F10-0x0000000187238090
		public static void QuaternionToRotationMatrix(ref Quaternion quaternion, out Matrix4x4 matrix); // 0x0000000187237F10-0x0000000187238090
		public static void CreateTranslation(Vector3 position, out Matrix4x4 matrix); // 0x0000000187237880-0x00000001872378C0
		public static void CreateTranslation(ref Vector3 position, out Matrix4x4 matrix); // 0x0000000187237840-0x0000000187237880
		public static void CreateScale(Vector3 scale, out Matrix4x4 matrix); // 0x0000000187236EC0-0x0000000187236F00
		public static void CreateScale(ref Vector3 scale, out Matrix4x4 matrix); // 0x0000000187236F00-0x0000000187236F40
		public static void CreateScale(float scale, out Matrix4x4 matrix); // 0x0000000187236F40-0x0000000187236F80
		public static void CreateRotationEuler(float eulerX, float eulerY, float eulerZ, out Matrix4x4 matrix); // 0x0000000188C54F50-0x0000000188C54FE0
		public static void CreateRotationEuler(Vector3 eulerAngles, out Matrix4x4 matrix); // 0x0000000188C55054-0x0000000188C550C8
		public static void CreateRotationEuler(ref Vector3 eulerAngles, out Matrix4x4 matrix); // 0x0000000188C54FE0-0x0000000188C55054
		public static void CreateRotationX(float angleInDegrees, out Matrix4x4 matrix); // 0x0000000187236CC0-0x0000000187236D50
		public static void CreateRotationY(float angleInDegrees, out Matrix4x4 matrix); // 0x0000000187236D50-0x0000000187236DE0
		public static void CreateRotationZ(float angleInDegrees, out Matrix4x4 matrix); // 0x0000000187236DE0-0x0000000187236E70
		public static void CreateRotationAngleAxis(float angleInDegrees, Vector3 rotationAxis, out Matrix4x4 matrix); // 0x0000000188C54DCC-0x0000000188C54F50
		public static void CreateRotationAngleUnitAxis(float angleInDegrees, Vector3 normalizedAxis, out Matrix4x4 matrix); // 0x0000000187236B60-0x0000000187236CC0
		public static void CreateRotation(Vector3 rotationOrigin, Quaternion rotation, out Matrix4x4 result); // 0x0000000188C553E4-0x0000000188C554E0
		public static void CreateRotation(ref Vector3 rotationOrigin, ref Quaternion rotation, out Matrix4x4 result); // 0x0000000188C552E8-0x0000000188C553E4
		public static void Transpose(ref Matrix4x4 matrix); // 0x0000000187238090-0x0000000187238100
		public static void Transpose(ref Matrix4x4 matrix, out Matrix4x4 transpose); // 0x0000000187238100-0x0000000187238160
		public static float CalcDeterminant(ref Matrix4x4 matrix); // 0x00000001872369B0-0x0000000187236B00
		public static void Inverse(ref Matrix4x4 matrix, float epsilon = 1E-05f /* Metadata: 0x0264478D */); // 0x0000000188C564FC-0x0000000188C56B28
		public static void Inverse(ref Matrix4x4 matrix, out Matrix4x4 inverse, float epsilon = 1E-05f /* Metadata: 0x02644791 */); // 0x0000000188C55F30-0x0000000188C564FC
		public static void CopyMatrix(ref Matrix4x4 source, out Matrix4x4 destination); // 0x0000000187236B00-0x0000000187236B60
		public static void Multiply(ref Matrix4x4 matrix0, ref Matrix4x4 matrix1, out Matrix4x4 result); // 0x0000000187237A90-0x0000000187237E30
		public static void MultiplyRight(ref Matrix4x4 matrix0, ref Matrix4x4 matrix1); // 0x0000000188C56F10-0x0000000188C572F8
		public static void MultiplyLeft(ref Matrix4x4 matrix1, ref Matrix4x4 matrix0); // 0x0000000188C56B28-0x0000000188C56F10
		public static void Multiply(ref Matrix4x4 matrix, float scalar); // 0x00000001872378C0-0x0000000187237990
		public static void Multiply(ref Matrix4x4 matrix, float scalar, out Matrix4x4 result); // 0x0000000187237E30-0x0000000187237F10
		public static Vector4 Multiply(ref Matrix4x4 matrix, Vector4 vector); // 0x0000000187237990-0x0000000187237A90
		public static Vector4 Multiply(ref Matrix4x4 matrix, ref Vector4 vector); // 0x0000000187237990-0x0000000187237A90
		public static void CreateSRT(Vector3 scaling, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000188C5591C-0x0000000188C55A1C
		public static void CreateSRT(ref Vector3 scaling, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000188C5581C-0x0000000188C5591C
		public static void CreateSRT(float scaling, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000188C55D58-0x0000000188C55E44
		public static void CreateSRT(float scaling, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000188C55E44-0x0000000188C55F30
		public static void CreateSRT(Vector3 scaling, Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000188C55BB0-0x0000000188C55D58
		public static void CreateSRT(ref Vector3 scaling, ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000188C55674-0x0000000188C5581C
		public static void CreateSRT(float scaling, Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000188C554E0-0x0000000188C55674
		public static void CreateSRT(float scaling, ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000188C55A1C-0x0000000188C55BB0
		public static void CreateRT(Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000188C54BD4-0x0000000188C54C44
		public static void CreateRT(ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000188C54C44-0x0000000188C54CB4
		public static void CreateRT(Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result); // 0x0000000188C54ABC-0x0000000188C54BD4
		public static void CreateRT(ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result); // 0x0000000188C54CB4-0x0000000188C54DCC
		public static void CreateST(Vector3 scaling, Vector3 translation, out Matrix4x4 result); // 0x0000000187236E70-0x0000000187236EC0
		public static void CreateST(ref Vector3 scaling, ref Vector3 translation, out Matrix4x4 result); // 0x0000000187236E70-0x0000000187236EC0
		public static void CreateRotationFromColumns(Vector3 column0, Vector3 column1, Vector3 column2, out Matrix4x4 matrix); // 0x0000000188C551D8-0x0000000188C552E8
		public static void CreateRotationFromColumns(ref Vector3 column0, ref Vector3 column1, ref Vector3 column2, out Matrix4x4 matrix); // 0x0000000188C550C8-0x0000000188C551D8
		public static void CreateShadowDirectional(Plane3 shadowPlane, Vector3 dirLightOppositeDirection, out Matrix4x4 result); // 0x0000000187236F80-0x00000001872370E0
		public static void CreateShadowDirectional(ref Plane3 shadowPlane, ref Vector3 dirLightOppositeDirection, out Matrix4x4 result); // 0x00000001872370E0-0x0000000187237240
		public static void CreateShadowPoint(Plane3 shadowPlane, Vector3 pointLightPosition, out Matrix4x4 result); // 0x0000000187237240-0x00000001872373A0
		public static void CreateShadowPoint(ref Plane3 shadowPlane, ref Vector3 pointLightPosition, out Matrix4x4 result); // 0x00000001872373A0-0x0000000187237500
		public static void CreateShadow(Plane3 shadowPlane, Vector4 lightData, out Matrix4x4 result); // 0x00000001872376A0-0x0000000187237840
		public static void CreateShadow(ref Plane3 shadowPlane, ref Vector4 lightData, out Matrix4x4 result); // 0x0000000187237500-0x00000001872376A0
	}

	public static class Quaternionex // TypeDefIndex: 85059
	{
		// Extension methods
		public static Quaternion DeltaTo(this Quaternion quat, Quaternion target); // 0x0000000188C57448-0x0000000188C574B0
		public static string ToStringEx(this Quaternion quat); // 0x0000000188C574B0-0x0000000188C575CC
	}

	public class Rand // TypeDefIndex: 85060
	{
		// Fields
		private const int a = 5; // Metadata: 0x026447B5
		private const int b = 14; // Metadata: 0x026447B6
		private const int c = 1; // Metadata: 0x026447B7
		private const uint DefaultY = 273326509; // Metadata: 0x026447B8
		private const uint DefaultZ = 3579807591; // Metadata: 0x026447BC
		private const uint DefaultW = 842502087; // Metadata: 0x026447C1
		private const uint PositiveMask = 2147483647; // Metadata: 0x026447C6
		private const uint BoolModuloMask = 1; // Metadata: 0x026447CB
		private const uint ByteModuloMask = 255; // Metadata: 0x026447CC
		private const double One_div_uintMaxValuePlusOne = 2.3283064365386963E-10; // Metadata: 0x026447CE
		private const double TwoPi = 6.283185307179586; // Metadata: 0x026447D6
		private static Rand _seedGenerator; // 0x00
		private uint _x; // 0x10
		private uint _y; // 0x14
		private uint _z; // 0x18
		private uint _w; // 0x1C
		public static Rand Instance; // 0x08
	
		// Constructors
		static Rand(); // 0x0000000188C58600-0x0000000188C586D0
		public Rand(); // 0x0000000188C586D0-0x0000000188C58748
		public Rand(int seed); // 0x00000001872382E0-0x0000000187238300
	
		// Methods
		public void ResetSeed(int seed); // 0x00000001872382E0-0x0000000187238300
		public void GetState(out uint x, out uint y, out uint z, out uint w); // 0x0000000187238160-0x0000000187238180
		public void SetState(uint x, uint y, uint z, uint w); // 0x0000000187238300-0x0000000187238320
		public int NextInt(); // 0x0000000187238180-0x00000001872381B0
		public int NextInt(int max); // 0x0000000187238240-0x00000001872382A0
		public int NextInt(int min, int max); // 0x0000000188C57DA4-0x0000000188C57E84
		public int NextIntInclusive(int min, int max); // 0x0000000188C57D98-0x0000000188C57DA4
		public int NextPositiveInt(); // 0x00000001872382A0-0x00000001872382E0
		public uint NextUInt(); // 0x0000000187238180-0x00000001872381B0
		public double NextDouble(); // 0x00000001872381B0-0x00000001872381F0
		public double NextDouble(double min, double max); // 0x0000000188C57C14-0x0000000188C57CD4
		public float NextFloat(); // 0x00000001872381F0-0x0000000187238240
		public float NextFloat(float min, float max); // 0x0000000188C57CD4-0x0000000188C57D98
		public bool NextBool(); // 0x0000000188C57BE0-0x0000000188C57C14
		public byte NextByte(); // 0x0000000187238180-0x00000001872381B0
		public UnityEngine.Color RandomColorOpaque(); // 0x0000000188C583EC-0x0000000188C58458
		public UnityEngine.Color RandomColorTransparent(); // 0x0000000188C58458-0x0000000188C584DC
		public Color32 RandomColor32Opaque(); // 0x0000000188C58358-0x0000000188C58398
		public Color32 RandomColor32Transparent(); // 0x0000000188C58398-0x0000000188C583EC
		public float RandomAngleRadians(); // 0x0000000188C58340-0x0000000188C58358
		public float RandomAngleDegrees(); // 0x0000000188C58328-0x0000000188C58340
		public Vector2 InSquare(float side = 1f /* Metadata: 0x02644795 */); // 0x0000000188C57874-0x0000000188C578E8
		public Vector2 OnSquare(float side = 1f /* Metadata: 0x02644799 */); // 0x0000000188C581F0-0x0000000188C58328
		public Vector3 InCube(float side = 1f /* Metadata: 0x0264479D */); // 0x0000000188C576E4-0x0000000188C57794
		public Vector3 OnCube(float side = 1f /* Metadata: 0x026447A1 */); // 0x0000000188C57EE0-0x0000000188C58124
		public Vector2 InCircle(float radius = 1f /* Metadata: 0x026447A5 */); // 0x0000000188C5766C-0x0000000188C576E4
		public Vector2 InCircle(float radiusMin, float radiusMax); // 0x0000000188C575CC-0x0000000188C5766C
		public Vector2 OnCircle(float radius = 1f /* Metadata: 0x026447A9 */); // 0x0000000188C57E84-0x0000000188C57EE0
		public Vector3 InSphere(float radius = 1f /* Metadata: 0x026447AD */); // 0x0000000188C57794-0x0000000188C57874
		public Vector3 OnSphere(float radius = 1f /* Metadata: 0x026447B1 */); // 0x0000000188C58124-0x0000000188C581F0
		public Vector3 InTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000188C57A64-0x0000000188C57BE0
		public Vector3 InTriangle(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000188C578E8-0x0000000188C57A64
		public Quaternion RandomRotation(); // 0x0000000188C584DC-0x0000000188C58600
	}

	public static class Vector2ex // TypeDefIndex: 85062
	{
		// Fields
		public static readonly Vector2 Zero; // 0x00
		public static readonly Vector2 One; // 0x08
		public static readonly Vector2 UnitX; // 0x10
		public static readonly Vector2 UnitY; // 0x18
		public static readonly Vector2 PositiveInfinity; // 0x20
		public static readonly Vector2 NegativeInfinity; // 0x28
	
		// Nested types
		internal class Information // TypeDefIndex: 85061
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
			public Information(); // 0x0000000188C53FD8-0x0000000188C5404C
		}
	
		// Constructors
		static Vector2ex(); // 0x0000000187105AE0-0x0000000187105BA0
	
		// Methods
		internal static Information GetInformation(IList<Vector2> points, float epsilon); // 0x0000000188C59B44-0x0000000188C5A17C
		public static float DotPerp(ref Vector2 vector, ref Vector2 value); // 0x0000000187238340-0x0000000187238360
		public static float Dot(ref Vector2 vector, ref Vector2 value); // 0x00000001872383B0-0x00000001872383D0
		public static float Normalize(ref Vector2 vector, float epsilon = 1E-05f /* Metadata: 0x026447DE */); // 0x0000000188C5A1F4-0x0000000188C5A25C
		public static float SetLength(ref Vector2 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x026447E2 */); // 0x0000000188C5A25C-0x0000000188C5A2D0
		public static float GrowLength(ref Vector2 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x026447E6 */); // 0x0000000188C5A17C-0x0000000188C5A1F4
		public static Vector2 Replicate(float value); // 0x0000000187238460-0x0000000187238470
	
		// Extension methods
		public static float Length(this Vector2 vector); // 0x00000001872383F0-0x0000000187238430
		public static float LengthSqr(this Vector2 vector); // 0x00000001872383D0-0x00000001872383F0
		public static float DotPerp(this Vector2 vector, Vector2 value); // 0x0000000187232CB0-0x0000000187232CE0
		public static float DotPerp(this Vector2 vector, ref Vector2 value); // 0x0000000187238320-0x0000000187238340
		public static float Dot(this Vector2 vector, Vector2 value); // 0x0000000187238380-0x00000001872383B0
		public static float Dot(this Vector2 vector, ref Vector2 value); // 0x0000000187238360-0x0000000187238380
		public static Vector2 Perp(this Vector2 vector); // 0x0000000187238430-0x0000000187238460
		public static float AngleDeg(this Vector2 vector, Vector2 target); // 0x0000000188C599EC-0x0000000188C59A9C
		public static float AngleRad(this Vector2 vector, Vector2 target); // 0x0000000188C59A9C-0x0000000188C59B44
		public static Vector3 ToVector3XY(this Vector2 vector); // 0x0000000187235910-0x0000000187235940
		public static Vector3 ToVector3XZ(this Vector2 vector); // 0x0000000187235960-0x0000000187235990
		public static Vector3 ToVector3YZ(this Vector2 vector); // 0x0000000187238470-0x00000001872384A0
		public static string ToStringEx(this Vector2 vector); // 0x0000000188C5A2D0-0x0000000188C5A32C
	}

	public enum ProjectionPlanes // TypeDefIndex: 85063
	{
		XY = 0,
		XZ = 1,
		YZ = 2
	}

	public static class Vector3ex // TypeDefIndex: 85065
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
		internal class Information // TypeDefIndex: 85064
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
			public Information(); // 0x0000000188C5404C-0x0000000188C540C0
		}
	
		// Constructors
		static Vector3ex(); // 0x0000000188C5B998-0x0000000188C5BAAC
	
		// Methods
		internal static Information GetInformation(IList<Vector3> points, float epsilon); // 0x0000000188C5A5D4-0x0000000188C5B190
		public static float Dot(ref Vector3 vector, ref Vector3 value); // 0x0000000187238500-0x0000000187238530
		public static Vector3 Cross(ref Vector3 vector, ref Vector3 value); // 0x00000001872384A0-0x0000000187238500
		public static Vector3 UnitCross(ref Vector3 vector, ref Vector3 value); // 0x0000000188C5B8D8-0x0000000188C5B998
		public static float Normalize(ref Vector3 vector, float epsilon = 1E-05f /* Metadata: 0x026447ED */); // 0x0000000188C5B264-0x0000000188C5B2E8
		public static float SetLength(ref Vector3 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x026447F1 */); // 0x0000000188C5B36C-0x0000000188C5B3FC
		public static float GrowLength(ref Vector3 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x026447F5 */); // 0x0000000188C5B1D0-0x0000000188C5B264
		public static Vector3 Replicate(float value); // 0x00000001872385A0-0x00000001872385C0
		public static void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, ref Vector3 w); // 0x0000000188C5A49C-0x0000000188C5A5D4
		public static bool SameDirection(Vector3 value0, Vector3 value1); // 0x0000000188C5B2E8-0x0000000188C5B36C
	
		// Extension methods
		public static float Length(this Vector3 vector); // 0x0000000187238560-0x00000001872385A0
		public static float LengthSqr(this Vector3 vector); // 0x0000000187238530-0x0000000187238560
		public static float Dot(this Vector3 vector, Vector3 value); // 0x0000000187238500-0x0000000187238530
		public static float Dot(this Vector3 vector, ref Vector3 value); // 0x0000000187238500-0x0000000187238530
		public static float AngleDeg(this Vector3 vector, Vector3 target); // 0x0000000188C5A32C-0x0000000188C5A3E8
		public static float AngleRad(this Vector3 vector, Vector3 target); // 0x0000000188C5A3E8-0x0000000188C5A49C
		public static float SignedAngleDeg(this Vector3 vector, Vector3 target, Vector3 normal); // 0x0000000188C5B3FC-0x0000000188C5B55C
		public static float SignedAngleRad(this Vector3 vector, Vector3 target, Vector3 normal); // 0x0000000188C5B55C-0x0000000188C5B6B4
		public static Vector3 Cross(this Vector3 vector, Vector3 value); // 0x00000001872384A0-0x0000000187238500
		public static Vector3 Cross(this Vector3 vector, ref Vector3 value); // 0x00000001872384A0-0x0000000187238500
		public static Vector3 UnitCross(this Vector3 vector, Vector3 value); // 0x0000000188C5B820-0x0000000188C5B8D8
		public static Vector3 UnitCross(this Vector3 vector, ref Vector3 value); // 0x0000000188C5B760-0x0000000188C5B820
		public static Vector2 ToVector2XY(this Vector3 vector); // 0x00000001872358F0-0x0000000187235910
		public static Vector2 ToVector2XZ(this Vector3 vector); // 0x0000000187235940-0x0000000187235960
		public static Vector2 ToVector2YZ(this Vector3 vector); // 0x00000001872385C0-0x00000001872385E0
		public static Vector2 ToVector2(this Vector3 vector, ProjectionPlanes projectionPlane); // 0x0000000188C5B738-0x0000000188C5B760
		public static ProjectionPlanes GetProjectionPlane(this Vector3 vector); // 0x0000000188C5B190-0x0000000188C5B1D0
		public static string ToStringEx(this Vector3 vector); // 0x0000000188C5B6B4-0x0000000188C5B738
	}

	public struct BrentsRoot // TypeDefIndex: 85066
	{
		// Fields
		public float X; // 0x00
		public int Iterations; // 0x04
		public bool ExceededMaxIterations; // 0x08
	}

	public static class RootFinder // TypeDefIndex: 85068
	{
		// Fields
		private const float third = 0.33333334f; // Metadata: 0x02644829
		private const float twentySeventh = 0.037037037f; // Metadata: 0x0264482D
		private static float sqrt3; // 0x00
	
		// Nested types
		private class PolyRootFinder // TypeDefIndex: 85067
		{
			// Fields
			private int _count; // 0x10
			private int _maxRoot; // 0x14
			private float[] _roots; // 0x18
			private float _epsilon; // 0x20
	
			// Properties
			public float[] Roots { get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			public PolyRootFinder(float epsilon); // 0x0000000188C665F0-0x0000000188C66658
	
			// Methods
			public bool Bisection(Polynomial poly, float xMin, float xMax, int digits, out float root); // 0x0000000188C66004-0x0000000188C661A4
			public bool Find(Polynomial poly, float xMin, float xMax, int digits); // 0x0000000188C661A4-0x0000000188C665F0
		}
	
		// Constructors
		static RootFinder(); // 0x0000000188C597D4-0x0000000188C59818
	
		// Methods
		public static bool BrentsMethod(Func<float, float> function, float x0, float x1, out BrentsRoot root, int maxIterations = 128 /* Metadata: 0x026447F9 */, float negativeTolerance = -1E-05f /* Metadata: 0x026447FB */, float positiveTolerance = 1E-05f /* Metadata: 0x026447FF */, float stepTolerance = 1E-05f /* Metadata: 0x02644803 */, float segmentTolerance = 1E-05f /* Metadata: 0x02644807 */); // 0x0000000188C58748-0x0000000188C58B24
		public static bool Linear(float c0, float c1, out float root, float epsilon = 1E-05f /* Metadata: 0x0264480B */); // 0x0000000188C58EF4-0x0000000188C58F20
		public static bool Quadratic(float c0, float c1, float c2, out QuadraticRoots roots, float epsilon = 1E-05f /* Metadata: 0x0264480F */); // 0x0000000188C591C0-0x0000000188C59354
		public static bool Cubic(float c0, float c1, float c2, float c3, out CubicRoots roots, float epsilon = 1E-05f /* Metadata: 0x02644813 */); // 0x0000000188C58B24-0x0000000188C58EF4
		public static bool Quartic(float c0, float c1, float c2, float c3, float c4, out QuarticRoots roots, float epsilon = 1E-05f /* Metadata: 0x02644817 */); // 0x0000000188C59354-0x0000000188C597D4
		public static float PolynomialBound(Polynomial poly, float epsilon = 1E-05f /* Metadata: 0x0264481B */); // 0x0000000188C58F20-0x0000000188C58FEC
		public static bool Polynomial(Polynomial poly, float xMin, float xMax, out float[] roots, int digits = 6 /* Metadata: 0x0264481F */, float epsilon = 1E-05f /* Metadata: 0x02644820 */); // 0x0000000188C590D4-0x0000000188C591C0
		public static bool Polynomial(Polynomial poly, out float[] roots, int digits = 6 /* Metadata: 0x02644824 */, float epsilon = 1E-05f /* Metadata: 0x02644825 */); // 0x0000000188C58FEC-0x0000000188C590D4
	}

	public class EigenData // TypeDefIndex: 85069
	{
		// Fields
		private int _size; // 0x10
		private float[] _diagonal; // 0x18
		private float[,] _matrix; // 0x20
	
		// Properties
		public int Size { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
	
		// Constructors
		internal EigenData(float[] diagonal, float[,] matrix); // 0x0000000188C6126C-0x0000000188C612A8
	
		// Methods
		public float GetEigenvalue(int index); // 0x0000000188C3F328-0x0000000188C3F358
		public Vector2 GetEigenvector2(int index); // 0x0000000188C60FB0-0x0000000188C61068
		public Vector3 GetEigenvector3(int index); // 0x0000000188C61068-0x0000000188C61138
		public float[] GetEigenvector(int index); // 0x0000000188C61138-0x0000000188C611E8
		public void GetEigenvector(int index, float[] out_eigenvector); // 0x0000000188C611E8-0x0000000188C6126C
	}

	public static class EigenDecomposition // TypeDefIndex: 85070
	{
		// Methods
		private static void Tridiagonal2(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation); // 0x0000000188C61C74-0x0000000188C61D88
		private static void Tridiagonal3(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation); // 0x0000000188C61D88-0x0000000188C620FC
		private static void TridiagonalN(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation); // 0x0000000188C620FC-0x0000000188C62804
		private static bool QLAlgorithm(float[] diagonal, float[] subdiagonal, float[,] matrix); // 0x0000000188C615EC-0x0000000188C61ABC
		private static void IncreasingSort(float[] diagonal, float[] subdiagonal, float[,] matrix, ref bool isRotation); // 0x0000000188C61484-0x0000000188C615EC
		private static void DecreasingSort(float[] diagonal, float[] subdiagonal, float[,] matrix, ref bool isRotation); // 0x0000000188C612A8-0x0000000188C61414
		private static void GuaranteeRotation(float[,] matrix, bool isRotation); // 0x0000000188C61414-0x0000000188C61484
		public static EigenData Solve(float[,] symmetricSquareMatrix, bool increasingSort); // 0x0000000188C61ABC-0x0000000188C61C74
	}

	public static class Integrator // TypeDefIndex: 85071
	{
		// Fields
		private const int _degree = 5; // Metadata: 0x02644831
		private static float[] root; // 0x00
		private static float[] coeff; // 0x08
	
		// Constructors
		static Integrator(); // 0x0000000188C62C90-0x0000000188C62D74
	
		// Methods
		public static float TrapezoidRule(Func<float, float> function, float a, float b, int sampleCount); // 0x0000000188C62B8C-0x0000000188C62C90
		public static float RombergIntegral(Func<float, float> function, float a, float b, int order); // 0x0000000188C62920-0x0000000188C62B8C
		public static float GaussianQuadrature(Func<float, float> function, float a, float b); // 0x0000000188C62804-0x0000000188C62920
	}

	public static class LinearSystem // TypeDefIndex: 85072
	{
		// Methods
		public static bool Solve2(float[,] A, float[] B, out float[] X, float zeroTolerance = 1E-05f /* Metadata: 0x02644832 */); // 0x0000000188C642EC-0x0000000188C644F8
		public static bool Solve2(float[,] A, float[] B, out Vector2 X, float zeroTolerance = 1E-05f /* Metadata: 0x02644836 */); // 0x0000000188C644F8-0x0000000188C645D4
		public static bool Solve3(float[,] A, float[] B, out float[] X, float zeroTolerance = 1E-05f /* Metadata: 0x0264483A */); // 0x0000000188C646B8-0x0000000188C64DCC
		public static bool Solve3(float[,] A, float[] B, out Vector3 X, float zeroTolerance = 1E-05f /* Metadata: 0x0264483E */); // 0x0000000188C645D4-0x0000000188C646B8
		private static void SwapRows(float[,] matrix, int row0, int row1, int columnCount); // 0x0000000188C6562C-0x0000000188C656D4
		public static bool Solve(float[,] A, float[] B, out float[] X); // 0x0000000188C650D8-0x0000000188C6562C
		public static bool SolveTridiagonal(float[] A, float[] B, float[] C, float[] R, out float[] U); // 0x0000000188C64DCC-0x0000000188C650D8
		public static bool Inverse(float[,] A, out float[,] invA); // 0x0000000188C63DA8-0x0000000188C642EC
	}

	public delegate void OdeFunction(float t, float[] y, float[] F); // TypeDefIndex: 85073; 0x0000000182235E70-0x0000000182235E90

	public abstract class OdeSolver // TypeDefIndex: 85074
	{
		// Fields
		protected int _dim; // 0x10
		protected float _step; // 0x14
		protected OdeFunction _function; // 0x18
		protected float[] _FValue; // 0x20
	
		// Properties
		public virtual float Step { get; set; } // 0x0000000187235C60-0x0000000187235C70 0x0000000187235C70-0x0000000187235C80
	
		// Constructors
		public OdeSolver(int dim, float step, OdeFunction function); // 0x0000000188C65F84-0x0000000188C66004
	
		// Methods
		public abstract void Update(float tIn, float[] yIn, ref float tOut, float[] yOut);
	}

	public class OdeEuler : OdeSolver // TypeDefIndex: 85075
	{
		// Constructors
		public OdeEuler(int dim, float step, OdeFunction function); // 0x0000000188C657B4-0x0000000188C657C4
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut); // 0x0000000188C656D4-0x0000000188C657B4
	}

	public class OdeMidpoint : OdeSolver // TypeDefIndex: 85076
	{
		// Fields
		private float _halfStep; // 0x28
		private float[] _yTemp; // 0x30
	
		// Properties
		public override float Step { get; set; } // 0x0000000187235C60-0x0000000187235C70 0x0000000187238C90-0x0000000187238CB0
	
		// Constructors
		public OdeMidpoint(int dim, float step, OdeFunction function); // 0x0000000188C65A84-0x0000000188C65B1C
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut); // 0x0000000188C65900-0x0000000188C65A84
	}

	public class OdeRungeKutta4 : OdeSolver // TypeDefIndex: 85077
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
		public override float Step { get; set; } // 0x0000000187235C60-0x0000000187235C70 0x0000000188C65F60-0x0000000188C65F84
	
		// Constructors
		public OdeRungeKutta4(int dim, float step, OdeFunction function); // 0x0000000188C65E4C-0x0000000188C65F60
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut); // 0x0000000188C65B1C-0x0000000188C65E4C
	}

	public struct QuadraticRoots // TypeDefIndex: 85078
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public int RootCount; // 0x08
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x0000000188C68574-0x0000000188C68594 
	}

	public struct CubicRoots // TypeDefIndex: 85079
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public float X2; // 0x08
		public int RootCount; // 0x0C
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x0000000188C60F88-0x0000000188C60FB0 
	}

	public struct QuarticRoots // TypeDefIndex: 85080
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public float X2; // 0x08
		public float X3; // 0x0C
		public int RootCount; // 0x10
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x0000000188C68594-0x0000000188C685C8 
	}

	public struct AAB2 // TypeDefIndex: 85081
	{
		// Fields
		public Vector2 Min; // 0x00
		public Vector2 Max; // 0x08
	
		// Constructors
		public AAB2(ref Vector2 min, ref Vector2 max); // 0x00000001872386E0-0x0000000187238710
		public AAB2(Vector2 min, Vector2 max); // 0x0000000187232F10-0x0000000187232F20
		public AAB2(float xMin, float xMax, float yMin, float yMax); // 0x0000000187238710-0x0000000187238730
	
		// Methods
		public static implicit operator Rect(AAB2 value); // 0x0000000188C5C188-0x0000000188C5C1CC
		public static implicit operator AAB2(Rect value); // 0x0000000187238730-0x0000000187238760
		public static AAB2 CreateFromPoint(ref Vector2 point); // 0x00000001872386C0-0x00000001872386E0
		public static AAB2 CreateFromPoint(Vector2 point); // 0x00000001872386B0-0x00000001872386C0
		public static AAB2 CreateFromTwoPoints(ref Vector2 point0, ref Vector2 point1); // 0x0000000188C5BF54-0x0000000188C5BFA0
		public static AAB2 CreateFromTwoPoints(Vector2 point0, Vector2 point1); // 0x0000000188C5BF18-0x0000000188C5BF54
		public static AAB2 CreateFromPoints(IEnumerable<Vector2> points); // 0x0000000188C5BCD4-0x0000000188C5BE0C
		public static AAB2 CreateFromPoints(IList<Vector2> points); // 0x0000000188C5BE0C-0x0000000188C5BF18
		public static AAB2 CreateFromPoints(Vector2[] points); // 0x0000000188C5BC18-0x0000000188C5BCD4
		public void CalcCenterExtents(out Vector2 center, out Vector2 extents); // 0x0000000187238600-0x0000000187238660
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3); // 0x0000000187238660-0x00000001872386B0
		public Vector2[] CalcVertices(); // 0x0000000188C5BAAC-0x0000000188C5BB60
		public void CalcVertices(Vector2[] array); // 0x0000000188C5BB60-0x0000000188C5BBE0
		public float CalcArea(); // 0x00000001872385E0-0x0000000187238600
		public float DistanceTo(Vector2 point); // 0x0000000188C5BFA0-0x0000000188C5BFC0
		public Vector2 Project(Vector2 point); // 0x0000000188C5C0B0-0x0000000188C5C0E0
		public bool Contains(ref Vector2 point); // 0x0000000185BA7680-0x0000000185BA76B0
		public bool Contains(Vector2 point); // 0x0000000188C5BBE0-0x0000000188C5BC18
		public void Include(ref Vector2 point); // 0x0000000188C5C070-0x0000000188C5C0B0
		public void Include(Vector2 point); // 0x0000000188C5BFC0-0x0000000188C5C008
		public void Include(ref AAB2 box); // 0x0000000188C5C03C-0x0000000188C5C070
		public void Include(AAB2 box); // 0x0000000188C5C008-0x0000000188C5C03C
		public override string ToString(); // 0x0000000188C5C0E0-0x0000000188C5C188
	}

	public struct Box2 // TypeDefIndex: 85082
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Axis0; // 0x08
		public Vector2 Axis1; // 0x10
		public Vector2 Extents; // 0x18
	
		// Constructors
		public Box2(ref Vector2 center, ref Vector2 axis0, ref Vector2 axis1, ref Vector2 extents); // 0x0000000187238990-0x00000001872389F0
		public Box2(Vector2 center, Vector2 axis0, Vector2 axis1, Vector2 extents); // 0x00000001872389F0-0x0000000187238A10
		public Box2(ref AAB2 box); // 0x0000000188C5DD24-0x0000000188C5DDC0
		public Box2(AAB2 box); // 0x0000000188C5DDC0-0x0000000188C5DE5C
	
		// Methods
		public static Box2 CreateFromPoints(IList<Vector2> points); // 0x0000000188C5D2AC-0x0000000188C5D628
		public Vector2 GetAxis(int index); // 0x0000000188C5D648-0x0000000188C5D6CC
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3); // 0x0000000188C5CC28-0x0000000188C5CD3C
		public Vector2[] CalcVertices(); // 0x0000000188C5CD3C-0x0000000188C5CF20
		public void CalcVertices(Vector2[] array); // 0x0000000188C5CF20-0x0000000188C5D0C8
		public float CalcArea(); // 0x0000000187238970-0x0000000187238990
		public float DistanceTo(Vector2 point); // 0x0000000188C5D628-0x0000000188C5D648
		public Vector2 Project(Vector2 point); // 0x0000000188C5DB74-0x0000000188C5DBA4
		public bool Contains(ref Vector2 point); // 0x0000000188C5D0C8-0x0000000188C5D1BC
		public bool Contains(Vector2 point); // 0x0000000188C5D1BC-0x0000000188C5D2AC
		public void Include(ref Box2 box); // 0x0000000188C5D6CC-0x0000000188C5DB60
		public void Include(Box2 box); // 0x0000000188C5DB60-0x0000000188C5DB74
		public override string ToString(); // 0x0000000188C5DBA4-0x0000000188C5DD24
	}

	public struct Circle2 // TypeDefIndex: 85083
	{
		// Fields
		public Vector2 Center; // 0x00
		public float Radius; // 0x08
	
		// Constructors
		public Circle2(ref Vector2 center, float radius); // 0x0000000187238BF0-0x0000000187238C10
		public Circle2(Vector2 center, float radius); // 0x0000000187238C10-0x0000000187238C20
	
		// Methods
		public static Circle2 CreateFromPointsAAB(IEnumerable<Vector2> points); // 0x0000000188C60564-0x0000000188C60674
		public static Circle2 CreateFromPointsAAB(IList<Vector2> points); // 0x0000000188C6049C-0x0000000188C60564
		public static Circle2 CreateFromPointsAverage(IEnumerable<Vector2> points); // 0x0000000188C60848-0x0000000188C60B84
		public static Circle2 CreateFromPointsAverage(IList<Vector2> points); // 0x0000000188C60674-0x0000000188C60848
		public static bool CreateCircumscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle); // 0x0000000188C60264-0x0000000188C6049C
		public static bool CreateInscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle); // 0x0000000188C60B84-0x0000000188C60D50
		public float CalcPerimeter(); // 0x0000000187238B10-0x0000000187238B20
		public float CalcArea(); // 0x0000000187238AF0-0x0000000187238B10
		public Vector2 Eval(float t); // 0x0000000187238B20-0x0000000187238B80
		public Vector2 Eval(float t, float radius); // 0x0000000187238B80-0x0000000187238BF0
		public float DistanceTo(Vector2 point); // 0x0000000188C60D50-0x0000000188C60D70
		public Vector2 Project(Vector2 point); // 0x0000000188C60EBC-0x0000000188C60EEC
		public bool Contains(ref Vector2 point); // 0x0000000188C6020C-0x0000000188C60264
		public bool Contains(Vector2 point); // 0x0000000188C601B0-0x0000000188C6020C
		public void Include(ref Circle2 circle); // 0x0000000188C60D84-0x0000000188C60EBC
		public void Include(Circle2 circle); // 0x0000000188C60D70-0x0000000188C60D84
		public override string ToString(); // 0x0000000188C60EEC-0x0000000188C60F88
	}

	public struct Line2 // TypeDefIndex: 85084
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Line2(ref Vector2 center, ref Vector2 direction); // 0x00000001872386E0-0x0000000187238710
		public Line2(Vector2 center, Vector2 direction); // 0x0000000187232F10-0x0000000187232F20
	
		// Methods
		public static Line2 CreateFromTwoPoints(ref Vector2 p0, ref Vector2 p1); // 0x0000000188C62E64-0x0000000188C62EBC
		public static Line2 CreateFromTwoPoints(Vector2 p0, Vector2 p1); // 0x0000000188C62E14-0x0000000188C62E64
		public static Line2 CreatePerpToLineTrhoughPoint(Line2 line, Vector2 point); // 0x0000000188C62F20-0x0000000188C62F98
		public static Line2 CreateBetweenAndEquidistantToPoints(Vector2 point0, Vector2 point1); // 0x0000000187238C20-0x0000000187238C90
		public static Line2 CreateParallelToGivenLineAtGivenDistance(Line2 line, float distance); // 0x0000000188C62EBC-0x0000000188C62F20
		public Vector2 Eval(float t); // 0x0000000188C62FB8-0x0000000188C62FF4
		public float SignedDistanceTo(Vector2 point); // 0x0000000188C63C70-0x0000000188C63D00
		public float DistanceTo(Vector2 point); // 0x0000000188C62F98-0x0000000188C62FB8
		public int QuerySide(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x02644842 */); // 0x0000000188C63958-0x0000000188C63A1C
		public bool QuerySideNegative(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x02644846 */); // 0x0000000188C63024-0x0000000188C630C8
		public bool QuerySidePositive(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0264484A */); // 0x0000000188C6349C-0x0000000188C63548
		public int QuerySide(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x0264484E */); // 0x0000000188C63B04-0x0000000188C63C70
		public bool QuerySideNegative(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x02644852 */); // 0x0000000188C631D0-0x0000000188C6331C
		public bool QuerySidePositive(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x02644856 */); // 0x0000000188C63548-0x0000000188C63690
		public int QuerySide(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x0264485A */); // 0x0000000188C637A0-0x0000000188C63958
		public bool QuerySideNegative(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x0264485E */); // 0x0000000188C630C8-0x0000000188C631D0
		public bool QuerySidePositive(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x02644862 */); // 0x0000000188C63690-0x0000000188C637A0
		public int QuerySide(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x02644866 */); // 0x0000000188C63A1C-0x0000000188C63B04
		public bool QuerySideNegative(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x0264486A */); // 0x0000000188C6331C-0x0000000188C633E0
		public bool QuerySidePositive(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x0264486E */); // 0x0000000188C633E0-0x0000000188C6349C
		public Vector2 Project(Vector2 point); // 0x0000000188C62FF4-0x0000000188C63024
		public float AngleBetweenTwoLines(Line2 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x02644872 */); // 0x0000000188C62D74-0x0000000188C62E14
		public override string ToString(); // 0x0000000188C63D00-0x0000000188C63DA8
	}

	public struct Edge2 // TypeDefIndex: 85085
	{
		// Fields
		public Vector2 Point0; // 0x00
		public Vector2 Point1; // 0x08
		public Vector2 Direction; // 0x10
		public Vector2 Normal; // 0x18
		public float Length; // 0x20
	}

	public class Polygon2 // TypeDefIndex: 85086
	{
		// Fields
		private Vector2[] _vertices; // 0x10
		private Edge2[] _edges; // 0x18
	
		// Properties
		public Vector2[] Vertices { get; } // 0x00000001829260F0-0x0000000182926100 
		public Edge2[] Edges { get; } // 0x0000000182234E30-0x0000000182234E40 
		public int VertexCount { get; } // 0x0000000188A9F760-0x0000000188A9F77C 
		public Vector2 this[int vertexIndex] { get => default; set {} } // 0x0000000188C68500-0x0000000188C6852C 0x0000000188C6852C-0x0000000188C68574
	
		// Constructors
		private Polygon2(); // 0x0000000186805BA0-0x0000000186805BB0
		public Polygon2(Vector2[] vertices); // 0x0000000188C683E0-0x0000000188C68484
		public Polygon2(int vertexCount); // 0x0000000188C68484-0x0000000188C68500
	
		// Methods
		public static Polygon2 CreateProjected(Polygon3 polygon, ProjectionPlanes projectionPlane); // 0x0000000188C672A8-0x0000000188C674DC
		public Edge2 GetEdge(int edgeIndex); // 0x0000000188C674DC-0x0000000188C6752C
		public void UpdateEdges(); // 0x0000000188C68220-0x0000000188C683E0
		public void UpdateEdge(int edgeIndex); // 0x0000000188C68080-0x0000000188C68220
		public Vector2 CalcCenter(); // 0x0000000188C667E8-0x0000000188C668B0
		public float CalcPerimeter(); // 0x0000000188C668B0-0x0000000188C66918
		public float CalcArea(); // 0x0000000188C66658-0x0000000188C667E8
		public bool IsConvex(out Orientations orientation, float threshold = 1E-05f /* Metadata: 0x02644873 */); // 0x0000000188C67630-0x0000000188C677AC
		public bool IsConvex(float threshold = 1E-05f /* Metadata: 0x02644877 */); // 0x0000000188C67608-0x0000000188C67630
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x0264487B */); // 0x0000000188C6752C-0x0000000188C67608
		public void ReverseVertices(); // 0x0000000188C677AC-0x0000000188C678C4
		public bool ContainsConvexQuadCCW(ref Vector2 point); // 0x0000000188C669AC-0x0000000188C66D84
		public bool ContainsConvexQuadCCW(Vector2 point); // 0x0000000188C66990-0x0000000188C669AC
		public bool ContainsConvexQuadCW(ref Vector2 point); // 0x0000000188C66D84-0x0000000188C6715C
		public bool ContainsConvexQuadCW(Vector2 point); // 0x0000000188C6715C-0x0000000188C67178
		public bool ContainsConvexCCW(ref Vector2 point); // 0x0000000188C66918-0x0000000188C66938
		public bool ContainsConvexCCW(Vector2 point); // 0x0000000188C66938-0x0000000188C66954
		private bool SubContainsPointCCW(ref Vector2 p, int i0, int i1); // 0x0000000188C678C4-0x0000000188C67B38
		public bool ContainsConvexCW(ref Vector2 point); // 0x0000000188C66954-0x0000000188C66974
		public bool ContainsConvexCW(Vector2 point); // 0x0000000188C66974-0x0000000188C66990
		private bool SubContainsPointCW(ref Vector2 p, int i0, int i1); // 0x0000000188C67B38-0x0000000188C67DAC
		public bool ContainsSimple(ref Vector2 point); // 0x0000000188C67194-0x0000000188C672A8
		public bool ContainsSimple(Vector2 point); // 0x0000000188C67178-0x0000000188C67194
		public Segment2[] ToSegmentArray(); // 0x0000000188C67DAC-0x0000000188C67EFC
		public override string ToString(); // 0x0000000188C67EFC-0x0000000188C68080
	}

	public struct Ray2 // TypeDefIndex: 85087
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Ray2(ref Vector2 center, ref Vector2 direction); // 0x00000001872386E0-0x0000000187238710
		public Ray2(Vector2 center, Vector2 direction); // 0x0000000187232F10-0x0000000187232F20
	
		// Methods
		public Vector2 Eval(float t); // 0x0000000188C62FB8-0x0000000188C62FF4
		public float DistanceTo(Vector2 point); // 0x0000000188C685C8-0x0000000188C685E8
		public Vector2 Project(Vector2 point); // 0x0000000188C685E8-0x0000000188C68618
		public override string ToString(); // 0x0000000188C68618-0x0000000188C686C0
	}

	public struct Segment2 // TypeDefIndex: 85088
	{
		// Fields
		public Vector2 P0; // 0x00
		public Vector2 P1; // 0x08
		public Vector2 Center; // 0x10
		public Vector2 Direction; // 0x18
		public float Extent; // 0x20
	
		// Constructors
		public Segment2(ref Vector2 p0, ref Vector2 p1); // 0x0000000188C68B20-0x0000000188C68B74
		public Segment2(Vector2 p0, Vector2 p1); // 0x0000000188C68AE4-0x0000000188C68B00
		public Segment2(ref Vector2 center, ref Vector2 direction, float extent); // 0x0000000188C68B74-0x0000000188C68BCC
		public Segment2(Vector2 center, Vector2 direction, float extent); // 0x0000000188C68B00-0x0000000188C68B20
	
		// Methods
		public void SetEndpoints(Vector2 p0, Vector2 p1); // 0x0000000188C6892C-0x0000000188C6893C
		public void SetCenterDirectionExtent(Vector2 center, Vector2 direction, float extent); // 0x0000000188C68918-0x0000000188C6892C
		public void CalcCenterDirectionExtent(); // 0x0000000188C686C0-0x0000000188C687BC
		public void CalcEndPoints(); // 0x0000000188C687BC-0x0000000188C6886C
		public Vector2 Eval(float s); // 0x0000000188C6888C-0x0000000188C688E8
		public float DistanceTo(Vector2 point); // 0x0000000188C6886C-0x0000000188C6888C
		public Vector2 Project(Vector2 point); // 0x0000000188C688E8-0x0000000188C68918
		public override string ToString(); // 0x0000000188C6893C-0x0000000188C68AE4
	}

	public struct Triangle2 // TypeDefIndex: 85089
	{
		// Fields
		public Vector2 V0; // 0x00
		public Vector2 V1; // 0x08
		public Vector2 V2; // 0x10
	
		// Properties
		public Vector2 this[int index] { get => default; set {} } // 0x0000000188C69B1C-0x0000000188C69B64 0x0000000188C69B64-0x0000000188C69B80
	
		// Constructors
		public Triangle2(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x0000000187238E30-0x0000000187238E80
		public Triangle2(Vector2 v0, Vector2 v1, Vector2 v2); // 0x0000000187238E20-0x0000000187238E30
	
		// Methods
		public Vector2 CalcEdge(int edgeIndex); // 0x0000000188C693A8-0x0000000188C69418
		public float CalcDeterminant(); // 0x0000000187238DC0-0x0000000187238E20
		public Orientations CalcOrientation(float threshold = 1E-05f /* Metadata: 0x0264487F */); // 0x0000000188C69418-0x0000000188C69458
		public float CalcArea(); // 0x0000000188C6916C-0x0000000188C6918C
		public static float CalcArea(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x0000000187238CB0-0x0000000187238D20
		public static float CalcArea(Vector2 v0, Vector2 v1, Vector2 v2); // 0x0000000187238D20-0x0000000187238DC0
		public Vector3 CalcAnglesDeg(); // 0x0000000188C68D20-0x0000000188C68E74
		public static Vector3 CalcAnglesDeg(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x0000000188C68BCC-0x0000000188C68D20
		public static Vector3 CalcAnglesDeg(Vector2 v0, Vector2 v1, Vector2 v2); // 0x0000000188C68E74-0x0000000188C68EC0
		public Vector3 CalcAnglesRad(); // 0x0000000188C6903C-0x0000000188C6916C
		public static Vector3 CalcAnglesRad(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2); // 0x0000000188C68F0C-0x0000000188C6903C
		public static Vector3 CalcAnglesRad(Vector2 v0, Vector2 v1, Vector2 v2); // 0x0000000188C68EC0-0x0000000188C68F0C
		public Vector2 EvalBarycentric(float c0, float c1); // 0x0000000188C6970C-0x0000000188C697B4
		public Vector2 EvalBarycentric(ref Vector3 baryCoords); // 0x0000000188C697B4-0x0000000188C69840
		public Vector2 EvalBarycentric(Vector3 baryCoords); // 0x0000000188C697B4-0x0000000188C69840
		public static void CalcBarycentricCoords(ref Vector2 point, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2, out Vector3 baryCoords); // 0x0000000188C691C4-0x0000000188C6936C
		public Vector3 CalcBarycentricCoords(ref Vector2 point); // 0x0000000188C6918C-0x0000000188C691C4
		public Vector3 CalcBarycentricCoords(Vector2 point); // 0x0000000188C6936C-0x0000000188C693A8
		public float DistanceTo(Vector2 point); // 0x0000000188C696EC-0x0000000188C6970C
		public int QuerySideCCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x02644883 */); // 0x0000000188C69870-0x0000000188C69954
		public int QuerySideCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x02644887 */); // 0x0000000188C69954-0x0000000188C69A44
		public Vector2 Project(Vector2 point); // 0x0000000188C69840-0x0000000188C69870
		public bool Contains(ref Vector2 point); // 0x0000000188C695F0-0x0000000188C696D0
		public bool Contains(Vector2 point); // 0x0000000188C696D0-0x0000000188C696EC
		public bool ContainsCCW(ref Vector2 point); // 0x0000000188C69474-0x0000000188C69524
		public bool ContainsCCW(Vector2 point); // 0x0000000188C69458-0x0000000188C69474
		public bool ContainsCW(ref Vector2 point); // 0x0000000188C69540-0x0000000188C695F0
		public bool ContainsCW(Vector2 point); // 0x0000000188C69524-0x0000000188C69540
		public override string ToString(); // 0x0000000188C69A44-0x0000000188C69B1C
	}

	public struct AAB3 // TypeDefIndex: 85090
	{
		// Fields
		public Vector3 Min; // 0x00
		public Vector3 Max; // 0x0C
	
		// Constructors
		public AAB3(ref Vector3 min, ref Vector3 max); // 0x0000000187238920-0x0000000187238940
		public AAB3(Vector3 min, Vector3 max); // 0x0000000187233BB0-0x0000000187233BD0
		public AAB3(float xMin, float xMax, float yMin, float yMax, float zMin, float zMax); // 0x0000000187238940-0x0000000187238970
	
		// Methods
		public static implicit operator Bounds(AAB3 value); // 0x0000000188C5CBBC-0x0000000188C5CC28
		public static implicit operator AAB3(Bounds value); // 0x0000000188C5CB58-0x0000000188C5CBBC
		public static AAB3 CreateFromPoint(ref Vector3 point); // 0x0000000187238900-0x0000000187238920
		public static AAB3 CreateFromPoint(Vector3 point); // 0x0000000187238900-0x0000000187238920
		public static AAB3 CreateFromTwoPoints(ref Vector3 point0, ref Vector3 point1); // 0x0000000188C5C920-0x0000000188C5C998
		public static AAB3 CreateFromTwoPoints(Vector3 point0, Vector3 point1); // 0x0000000188C5C8F0-0x0000000188C5C920
		public static AAB3 CreateFromPoints(IEnumerable<Vector3> points); // 0x0000000188C5C53C-0x0000000188C5C6B4
		public static AAB3 CreateFromPoints(IList<Vector3> points); // 0x0000000188C5C6B4-0x0000000188C5C804
		public static AAB3 CreateFromPoints(Vector3[] points); // 0x0000000188C5C804-0x0000000188C5C8F0
		public void CalcCenterExtents(out Vector3 center, out Vector3 extents); // 0x0000000187238760-0x00000001872387E0
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7); // 0x00000001872387E0-0x00000001872388D0
		public Vector3[] CalcVertices(); // 0x0000000188C5C348-0x0000000188C5C4F4
		public void CalcVertices(Vector3[] array); // 0x0000000188C5C1CC-0x0000000188C5C348
		public float CalcVolume(); // 0x00000001872388D0-0x0000000187238900
		public float DistanceTo(Vector3 point); // 0x0000000188C5C998-0x0000000188C5C9B4
		public Vector3 Project(Vector3 point); // 0x0000000188C5CA80-0x0000000188C5CAAC
		public bool Contains(ref Vector3 point); // 0x0000000185C96770-0x0000000185C967C0
		public bool Contains(Vector3 point); // 0x0000000188C5C4F4-0x0000000188C5C53C
		public void Include(ref Vector3 point); // 0x0000000188C5C9B4-0x0000000188C5CA18
		public void Include(Vector3 point); // 0x0000000188C5C9B4-0x0000000188C5CA18
		public void Include(ref AAB3 box); // 0x0000000188C5CA18-0x0000000188C5CA4C
		public void Include(AAB3 box); // 0x0000000188C5CA4C-0x0000000188C5CA80
		public override string ToString(); // 0x0000000188C5CAAC-0x0000000188C5CB58
	}

	public struct Box3 // TypeDefIndex: 85091
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Axis2; // 0x24
		public Vector3 Extents; // 0x30
	
		// Constructors
		public Box3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, ref Vector3 axis2, ref Vector3 extents); // 0x0000000187238A30-0x0000000187238A90
		public Box3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector3 axis2, Vector3 extents); // 0x0000000187238A90-0x0000000187238AF0
		public Box3(ref AAB3 box); // 0x0000000188C60074-0x0000000188C60124
		public Box3(AAB3 box); // 0x0000000188C60124-0x0000000188C601B0
	
		// Methods
		public static Box3 CreateFromPoints(IList<Vector3> points); // 0x0000000188C5F0F8-0x0000000188C5F658
		public Vector3 GetAxis(int index); // 0x0000000188C5F674-0x0000000188C5F710
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7); // 0x0000000188C5EA04-0x0000000188C5EF4C
		public Vector3[] CalcVertices(); // 0x0000000188C5DE5C-0x0000000188C5E448
		public void CalcVertices(Vector3[] array); // 0x0000000188C5E448-0x0000000188C5EA04
		public float CalcVolume(); // 0x0000000187238A10-0x0000000187238A30
		public float DistanceTo(Vector3 point); // 0x0000000188C5F658-0x0000000188C5F674
		public Vector3 Project(Vector3 point); // 0x0000000188C5FE84-0x0000000188C5FEB0
		public bool Contains(ref Vector3 point); // 0x0000000188C5EF4C-0x0000000188C5F0E4
		public bool Contains(Vector3 point); // 0x0000000188C5F0E4-0x0000000188C5F0F8
		public void Include(ref Box3 box); // 0x0000000188C5F710-0x0000000188C5FE70
		public void Include(Box3 box); // 0x0000000188C5FE70-0x0000000188C5FE84
		public override string ToString(); // 0x0000000188C5FEB0-0x0000000188C60074
	}

	public struct Capsule3 // TypeDefIndex: 85092
	{
		// Fields
		public Segment3 Segment; // 0x00
		public float Radius; // 0x34
	
		// Constructors
		public Capsule3(ref Segment3 segment, float radius); // 0x0000000187238E80-0x0000000187238EB0
		public Capsule3(Segment3 segment, float radius); // 0x0000000187238EB0-0x0000000187238EE0
	}

	public struct Circle3 // TypeDefIndex: 85093
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Normal; // 0x24
		public float Radius; // 0x30
	
		// Constructors
		public Circle3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, float radius); // 0x0000000188C6B68C-0x0000000188C6B780
		public Circle3(Vector3 center, Vector3 axis0, Vector3 axis1, float radius); // 0x0000000188C6B780-0x0000000188C6B860
		public Circle3(ref Vector3 center, ref Vector3 normal, float radius); // 0x0000000188C6B5F8-0x0000000188C6B68C
		public Circle3(Vector3 center, Vector3 normal, float radius); // 0x0000000188C6B860-0x0000000188C6B8F4
	
		// Methods
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle); // 0x0000000188C6A938-0x0000000188C6ACDC
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle); // 0x0000000188C6ACDC-0x0000000188C6B1BC
		public float CalcPerimeter(); // 0x0000000187238F00-0x0000000187238F10
		public float CalcArea(); // 0x0000000187238EE0-0x0000000187238F00
		public Vector3 Eval(float t); // 0x0000000188C6B1D8-0x0000000188C6B2F0
		public Vector3 Eval(float t, float radius); // 0x0000000188C6B2F0-0x0000000188C6B414
		public float DistanceTo(Vector3 point, bool solid = true /* Metadata: 0x0264488B */); // 0x0000000188C6B1BC-0x0000000188C6B1D8
		public Vector3 Project(Vector3 point, bool solid = true /* Metadata: 0x0264488C */); // 0x0000000188C6B414-0x0000000188C6B444
		public override string ToString(); // 0x0000000188C6B444-0x0000000188C6B5F8
	}

	public struct Line3 // TypeDefIndex: 85094
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Line3(ref Vector3 center, ref Vector3 direction); // 0x0000000187238920-0x0000000187238940
		public Line3(Vector3 center, Vector3 direction); // 0x0000000187233BB0-0x0000000187233BD0
	
		// Methods
		public static Line3 CreateFromTwoPoints(ref Vector3 p0, ref Vector3 p1); // 0x0000000188C6F3EC-0x0000000188C6F47C
		public static Line3 CreateFromTwoPoints(Vector3 p0, Vector3 p1); // 0x0000000188C6F3EC-0x0000000188C6F47C
		public Vector3 Eval(float t); // 0x0000000188C6F498-0x0000000188C6F514
		public float DistanceTo(Vector3 point); // 0x0000000188C6F47C-0x0000000188C6F498
		public Vector3 Project(Vector3 point); // 0x0000000188C6F514-0x0000000188C6F540
		public float AngleBetweenTwoLines(Line3 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x0264488D */); // 0x0000000188C6F324-0x0000000188C6F3EC
		public override string ToString(); // 0x0000000188C6F540-0x0000000188C6F5EC
	}

	[Serializable]
	public struct Plane3 // TypeDefIndex: 85095
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float Constant; // 0x0C
	
		// Constructors
		public Plane3(ref Vector3 normal, float constant); // 0x0000000187238F10-0x0000000187238F30
		public Plane3(Vector3 normal, float constant); // 0x0000000187238F10-0x0000000187238F30
		public Plane3(ref Vector3 normal, ref Vector3 point); // 0x0000000188C7133C-0x0000000188C713E8
		public Plane3(Vector3 normal, Vector3 point); // 0x0000000188C712A4-0x0000000188C7133C
		public Plane3(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2); // 0x0000000188C71530-0x0000000188C71678
		public Plane3(Vector3 p0, Vector3 p1, Vector3 p2); // 0x0000000188C713E8-0x0000000188C71530
	
		// Methods
		public static implicit operator Plane(Plane3 value); // 0x0000000188C71678-0x0000000188C716BC
		public static implicit operator Plane3(Plane value); // 0x0000000187238F30-0x0000000187238F60
		public Vector3 CalcOrigin(); // 0x0000000188C70044-0x0000000188C70088
		public void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, out Vector3 n); // 0x0000000188C70088-0x0000000188C70194
		internal float SignedDistanceTo(ref Vector3 point); // 0x0000000188C71170-0x0000000188C7120C
		public float SignedDistanceTo(Vector3 point); // 0x0000000188C710E0-0x0000000188C71170
		public float DistanceTo(Vector3 point); // 0x0000000188C70194-0x0000000188C7022C
		public int QuerySide(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x0264488E */); // 0x0000000188C71018-0x0000000188C710E0
		public bool QuerySideNegative(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x02644892 */); // 0x0000000188C7060C-0x0000000188C706B0
		public bool QuerySidePositive(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x02644896 */); // 0x0000000188C70954-0x0000000188C70A00
		public int QuerySide(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x0264489A */); // 0x0000000188C70E50-0x0000000188C71018
		public bool QuerySideNegative(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x0264489E */); // 0x0000000188C70358-0x0000000188C70500
		public bool QuerySidePositive(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x026448A2 */); // 0x0000000188C70A00-0x0000000188C70BA0
		public int QuerySide(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x026448A6 */); // 0x0000000188C70C98-0x0000000188C70E50
		public bool QuerySideNegative(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x026448AA */); // 0x0000000188C70500-0x0000000188C7060C
		public bool QuerySidePositive(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x026448AE */); // 0x0000000188C70840-0x0000000188C70954
		public int QuerySide(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x026448B2 */); // 0x0000000188C70BA0-0x0000000188C70C98
		public bool QuerySideNegative(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x026448B6 */); // 0x0000000188C706B0-0x0000000188C7077C
		public bool QuerySidePositive(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x026448BA */); // 0x0000000188C7077C-0x0000000188C70840
		public Vector3 Project(Vector3 point); // 0x0000000188C7032C-0x0000000188C70358
		public Vector3 ProjectVector(Vector3 vector); // 0x0000000188C7022C-0x0000000188C7032C
		public float AngleBetweenPlaneNormalAndLine(Line3 line); // 0x0000000188C6FEE8-0x0000000188C6FFA0
		public float AngleBetweenPlaneNormalAndLine(Vector3 direction); // 0x0000000188C6FE3C-0x0000000188C6FEE8
		public float AngleBetweenPlaneAndLine(Line3 line); // 0x0000000188C6FD74-0x0000000188C6FE3C
		public float AngleBetweenPlaneAndLine(Vector3 direction); // 0x0000000188C6FCB8-0x0000000188C6FD74
		public float AngleBetweenTwoPlanes(Plane3 anotherPlane); // 0x0000000188C6FFA0-0x0000000188C70044
		public override string ToString(); // 0x0000000188C7120C-0x0000000188C712A4
	}

	[Serializable]
	public struct Edge3 // TypeDefIndex: 85096
	{
		// Fields
		public Vector3 Point0; // 0x00
		public Vector3 Point1; // 0x0C
		public Vector3 Direction; // 0x18
		public Vector3 Normal; // 0x24
		public float Length; // 0x30
	}

	[Serializable]
	public class Polygon3 // TypeDefIndex: 85097
	{
		// Fields
		[SerializeField]
		private Vector3[] _vertices; // 0x10
		[SerializeField]
		private Edge3[] _edges; // 0x18
		[SerializeField]
		private Plane3 _plane; // 0x20
	
		// Properties
		public Vector3[] Vertices { get; } // 0x00000001829260F0-0x0000000182926100 
		public Edge3[] Edges { get; } // 0x0000000182234E30-0x0000000182234E40 
		public int VertexCount { get; } // 0x0000000188A9F760-0x0000000188A9F77C 
		public Vector3 this[int vertexIndex] { get => default; set {} } // 0x0000000188C72F44-0x0000000188C72F70 0x0000000188C72F70-0x0000000188C72FA8
		public Plane3 Plane { get; set; } // 0x0000000187238F60-0x0000000187238F70 0x0000000187238F70-0x0000000187238F80
	
		// Constructors
		private Polygon3(); // 0x0000000186805BA0-0x0000000186805BB0
		public Polygon3(Vector3[] vertices, Plane3 plane); // 0x0000000188C72E8C-0x0000000188C72F44
		public Polygon3(int vertexCount, Plane3 plane); // 0x0000000188C72DFC-0x0000000188C72E8C
	
		// Methods
		public void SetVertexProjected(int vertexIndex, Vector3 vertex); // 0x0000000188C725F4-0x0000000188C72718
		public void ProjectVertices(); // 0x0000000188C7239C-0x0000000188C72504
		public Edge3 GetEdge(int edgeIndex); // 0x0000000188C7223C-0x0000000188C72298
		public void UpdateEdges(); // 0x0000000188C72BF4-0x0000000188C72DFC
		public void UpdateEdge(int edgeIndex); // 0x0000000188C72A1C-0x0000000188C72BF4
		public Vector3 CalcCenter(); // 0x0000000188C720A4-0x0000000188C721D4
		public float CalcPerimeter(); // 0x0000000188C721D4-0x0000000188C7223C
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x026448BE */); // 0x0000000188C72298-0x0000000188C7239C
		public void ReverseVertices(); // 0x0000000188C72504-0x0000000188C725F4
		public Segment3[] ToSegmentArray(); // 0x0000000188C72718-0x0000000188C7287C
		public override string ToString(); // 0x0000000188C7287C-0x0000000188C72A1C
	}

	public struct Ray3 // TypeDefIndex: 85098
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Ray3(ref Vector3 center, ref Vector3 direction); // 0x0000000187238920-0x0000000187238940
		public Ray3(Vector3 center, Vector3 direction); // 0x0000000187233BB0-0x0000000187233BD0
	
		// Methods
		public static implicit operator Ray(Ray3 value); // 0x0000000188C73EA8-0x0000000188C73EFC
		public static implicit operator Ray3(Ray value); // 0x00000001872392C0-0x00000001872392F0
		public Vector3 Eval(float t); // 0x0000000188C6F498-0x0000000188C6F514
		public float DistanceTo(Vector3 point); // 0x0000000188C73DB4-0x0000000188C73DD0
		public Vector3 Project(Vector3 point); // 0x0000000188C73DD0-0x0000000188C73DFC
		public override string ToString(); // 0x0000000188C73DFC-0x0000000188C73EA8
	}

	public struct Rectangle3 // TypeDefIndex: 85099
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Normal; // 0x24
		public Vector2 Extents; // 0x30
	
		// Constructors
		public Rectangle3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, ref Vector2 extents); // 0x0000000188C74D2C-0x0000000188C74E44
		public Rectangle3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector2 extents); // 0x0000000188C74C4C-0x0000000188C74D2C
	
		// Methods
		public static Rectangle3 CreateFromCCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x0000000188C74634-0x0000000188C7482C
		public static Rectangle3 CreateFromCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x0000000188C7482C-0x0000000188C74A24
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3); // 0x0000000188C74170-0x0000000188C74390
		public Vector3[] CalcVertices(); // 0x0000000188C74390-0x0000000188C74634
		public void CalcVertices(Vector3[] array); // 0x0000000188C73EFC-0x0000000188C74170
		public float CalcArea(); // 0x00000001872392F0-0x0000000187239310
		public float DistanceTo(Vector3 point); // 0x0000000188C74A24-0x0000000188C74A40
		public Vector3 Project(Vector3 point); // 0x0000000188C74A40-0x0000000188C74A6C
		public override string ToString(); // 0x0000000188C74A6C-0x0000000188C74C4C
	}

	public struct Segment3 // TypeDefIndex: 85100
	{
		// Fields
		public Vector3 P0; // 0x00
		public Vector3 P1; // 0x0C
		public Vector3 Center; // 0x18
		public Vector3 Direction; // 0x24
		public float Extent; // 0x30
	
		// Constructors
		public Segment3(ref Vector3 p0, ref Vector3 p1); // 0x0000000188C75388-0x0000000188C753EC
		public Segment3(Vector3 p0, Vector3 p1); // 0x0000000188C75324-0x0000000188C75388
		public Segment3(ref Vector3 center, ref Vector3 direction, float extent); // 0x0000000188C7544C-0x0000000188C754AC
		public Segment3(Vector3 center, Vector3 direction, float extent); // 0x0000000188C753EC-0x0000000188C7544C
	
		// Methods
		public void SetEndpoints(Vector3 p0, Vector3 p1); // 0x0000000188C75148-0x0000000188C75170
		public void SetCenterDirectionExtent(Vector3 center, Vector3 direction, float extent); // 0x0000000188C7511C-0x0000000188C75148
		public void CalcCenterDirectionExtent(); // 0x0000000188C74E44-0x0000000188C74F54
		public void CalcEndPoints(); // 0x0000000188C74F54-0x0000000188C75034
		public Vector3 Eval(float s); // 0x0000000188C75050-0x0000000188C750F0
		public float DistanceTo(Vector3 point); // 0x0000000188C75034-0x0000000188C75050
		public Vector3 Project(Vector3 point); // 0x0000000188C750F0-0x0000000188C7511C
		public override string ToString(); // 0x0000000188C75170-0x0000000188C75324
	}

	public struct Sphere3 // TypeDefIndex: 85101
	{
		// Fields
		private const float _4div3mulPi = 4.1887903f; // Metadata: 0x026448C2
		public Vector3 Center; // 0x00
		public float Radius; // 0x0C
	
		// Constructors
		public Sphere3(ref Vector3 center, float radius); // 0x0000000187238F10-0x0000000187238F30
		public Sphere3(Vector3 center, float radius); // 0x0000000187238F10-0x0000000187238F30
	
		// Methods
		public static Sphere3 CreateFromPointsAAB(IEnumerable<Vector3> points); // 0x0000000188C7591C-0x0000000188C75A40
		public static Sphere3 CreateFromPointsAAB(IList<Vector3> points); // 0x0000000188C75844-0x0000000188C7591C
		public static Sphere3 CreateFromPointsAverage(IEnumerable<Vector3> points); // 0x0000000188C75A40-0x0000000188C75DF4
		public static Sphere3 CreateFromPointsAverage(IList<Vector3> points); // 0x0000000188C75DF4-0x0000000188C75FE8
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere); // 0x0000000188C7551C-0x0000000188C75844
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere); // 0x0000000188C75FE8-0x0000000188C76614
		public float CalcArea(); // 0x0000000187239310-0x0000000187239330
		public float CalcVolume(); // 0x0000000187239330-0x0000000187239350
		public Vector3 Eval(float theta, float phi); // 0x0000000187239350-0x00000001872393F0
		public float DistanceTo(Vector3 point); // 0x0000000188C76614-0x0000000188C76630
		public Vector3 Project(Vector3 point); // 0x0000000188C7678C-0x0000000188C767B8
		public bool Contains(ref Vector3 point); // 0x0000000188C754AC-0x0000000188C7551C
		public bool Contains(Vector3 point); // 0x0000000188C754AC-0x0000000188C7551C
		public void Include(ref Sphere3 sphere); // 0x0000000188C76630-0x0000000188C76778
		public void Include(Sphere3 sphere); // 0x0000000188C76778-0x0000000188C7678C
		public override string ToString(); // 0x0000000188C767B8-0x0000000188C76850
	}

	public struct Triangle3 // TypeDefIndex: 85102
	{
		// Fields
		public Vector3 V0; // 0x00
		public Vector3 V1; // 0x0C
		public Vector3 V2; // 0x18
	
		// Properties
		public Vector3 this[int index] { get => default; set {} } // 0x0000000188C79578-0x0000000188C795D8 0x0000000188C795D8-0x0000000188C7961C
	
		// Constructors
		public Triangle3(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000187239430-0x0000000187239470
		public Triangle3(Vector3 v0, Vector3 v1, Vector3 v2); // 0x00000001872393F0-0x0000000187239430
	
		// Methods
		public Vector3 CalcEdge(int edgeIndex); // 0x0000000188C79138-0x0000000188C791FC
		public Vector3 CalcNormal(); // 0x0000000188C791FC-0x0000000188C792B0
		public float CalcArea(); // 0x0000000188C78E28-0x0000000188C78EE8
		public static float CalcArea(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000188C78D68-0x0000000188C78E28
		public static float CalcArea(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000188C78D68-0x0000000188C78E28
		public Vector3 CalcAnglesDeg(); // 0x0000000188C788D4-0x0000000188C78A60
		public static Vector3 CalcAnglesDeg(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000188C78710-0x0000000188C788A0
		public static Vector3 CalcAnglesDeg(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000188C788A0-0x0000000188C788D4
		public Vector3 CalcAnglesRad(); // 0x0000000188C78C00-0x0000000188C78D68
		public static Vector3 CalcAnglesRad(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2); // 0x0000000188C78A60-0x0000000188C78BCC
		public static Vector3 CalcAnglesRad(Vector3 v0, Vector3 v1, Vector3 v2); // 0x0000000188C78BCC-0x0000000188C78C00
		public Vector3 EvalBarycentric(float c0, float c1); // 0x0000000188C793A0-0x0000000188C79498
		public Vector3 EvalBarycentric(ref Vector3 baryCoords); // 0x0000000188C792B0-0x0000000188C793A0
		public Vector3 EvalBarycentric(Vector3 baryCoords); // 0x0000000188C792B0-0x0000000188C793A0
		public static void CalcBarycentricCoords(ref Vector3 point, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Vector3 baryCoords); // 0x0000000188C78F20-0x0000000188C79138
		public Vector3 CalcBarycentricCoords(ref Vector3 point); // 0x0000000188C78EE8-0x0000000188C78F20
		public Vector3 CalcBarycentricCoords(Vector3 point); // 0x0000000188C78EE8-0x0000000188C78F20
		public override string ToString(); // 0x0000000188C79498-0x0000000188C79578
	}

	public enum Orientations // TypeDefIndex: 85103
	{
		CW = 0,
		CCW = 1,
		None = 2
	}

	internal class Query2 : Query // TypeDefIndex: 85104
	{
		// Fields
		private static float Zero; // 0x00
		private Vector2[] _vertices; // 0x10
	
		// Constructors
		public Query2(Vector2[] vertices); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public int ToLine(int i, int v0, int v1); // 0x0000000188C732EC-0x0000000188C73344
		public int ToLine(ref Vector2 test, int v0, int v1); // 0x0000000188C731F8-0x0000000188C732EC
		public int ToTriangle(int i, int v0, int v1, int v2); // 0x0000000188C733F4-0x0000000188C7344C
		public int ToTriangle(ref Vector2 test, int v0, int v1, int v2); // 0x0000000188C73344-0x0000000188C733F4
		public int ToCircumcircle(int i, int v0, int v1, int v2); // 0x0000000188C72FA8-0x0000000188C73000
		public int ToCircumcircle(ref Vector2 test, int v0, int v1, int v2); // 0x0000000188C73000-0x0000000188C731F8
		public float Dot(float x0, float y0, float x1, float y1); // 0x0000000187239060-0x0000000187239080
		public float Det2(float x0, float y0, float x1, float y1); // 0x0000000187238F80-0x0000000187238FA0
		public float Det3(float x0, float y0, float z0, float x1, float y1, float z1, float x2, float y2, float z2); // 0x0000000187238FA0-0x0000000187239060
	}

	internal class Query3 : Query // TypeDefIndex: 85105
	{
		// Fields
		private static float Zero; // 0x00
		private Vector3[] _vertices; // 0x10
	
		// Constructors
		public Query3(Vector3[] vertices); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public int ToPlane(int i, int v0, int v1, int v2); // 0x0000000188C7383C-0x0000000188C73894
		public int ToPlane(ref Vector3 test, int v0, int v1, int v2); // 0x0000000188C73894-0x0000000188C73A50
		public int ToTetrahedron(int i, int v0, int v1, int v2, int v3); // 0x0000000188C73A50-0x0000000188C73AAC
		public int ToTetrahedron(ref Vector3 test, int v0, int v1, int v2, int v3); // 0x0000000188C73AAC-0x0000000188C73BA8
		public int ToCircumsphere(int i, int v0, int v1, int v2, int v3); // 0x0000000188C737E0-0x0000000188C7383C
		public int ToCircumsphere(ref Vector3 test, int v0, int v1, int v2, int v3); // 0x0000000188C7344C-0x0000000188C737E0
		public float Dot(float x0, float y0, float z0, float x1, float y1, float z1); // 0x00000001872392A0-0x00000001872392C0
		public float Det3(float x0, float y0, float z0, float x1, float y1, float z1, float x2, float y2, float z2); // 0x0000000187238FA0-0x0000000187239060
		public float Det4(float x0, float y0, float z0, float w0, float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2, float x3, float y3, float z3, float w3); // 0x0000000187239080-0x00000001872392A0
	}

	internal enum QueryTypes // TypeDefIndex: 85106
	{
		Int64 = 0,
		Integer = 1,
		Rational = 2,
		Real = 3,
		Filtered = 4
	}

	internal class Query // TypeDefIndex: 85107
	{
		// Constructors
		protected Query(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static bool Sort(ref int v0, ref int v1); // 0x0000000188C73DA0-0x0000000188C73DB4
		public static bool Sort(ref int v0, ref int v1, ref int v2); // 0x0000000188C73BA8-0x0000000188C73C14
		public static bool Sort(ref int v0, ref int v1, ref int v2, ref int v3); // 0x0000000188C73C14-0x0000000188C73DA0
	}

	public class CatmullRomSpline3 : SplineBase // TypeDefIndex: 85108
	{
		// Properties
		public override SplineTypes SplineType { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000188C6A8C8-0x0000000188C6A938
	
		// Constructors
		public CatmullRomSpline3(); // 0x0000000188C6A8C0-0x0000000188C6A8C8
	
		// Methods
		public static CatmullRomSpline3 Create(); // 0x0000000188C69D7C-0x0000000188C69DF8
		public static CatmullRomSpline3 Create(IList<Vector3> points, SplineTypes type); // 0x0000000188C69DF8-0x0000000188C6A008
		private void UpdateSegment(int index); // 0x0000000188C6A3E4-0x0000000188C6A8C0
		private void UpdateAdjacentSegments(int vertexIndex); // 0x0000000188C6A2B4-0x0000000188C6A3E4
		public override void AddVertexFirst(Vector3 position); // 0x0000000188C69C50-0x0000000188C69C84
		public override void AddVertexLast(Vector3 position); // 0x0000000188C69C84-0x0000000188C69D30
		public override void RemoveVertex(int index); // 0x0000000188C6A1C4-0x0000000188C6A22C
		public override void Clear(); // 0x0000000188C69D30-0x0000000188C69D7C
		public override void InsertBefore(int vertexIndex, Vector3 position); // 0x0000000188C6A124-0x0000000188C6A1C4
		public override void InsertAfter(int vertexIndex, Vector3 position); // 0x0000000188C6A080-0x0000000188C6A124
		public override Vector3 GetVertex(int vertexIndex); // 0x0000000188C6A008-0x0000000188C6A080
		public override void SetVertex(int vertexIndex, Vector3 position); // 0x0000000188C6A22C-0x0000000188C6A2B4
	}

	public class CubicSpline3 : SplineBase // TypeDefIndex: 85109
	{
		// Properties
		public override SplineTypes SplineType { get; set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000188C6D638-0x0000000188C6D64C
	
		// Constructors
		public CubicSpline3(); // 0x0000000188C6A8C0-0x0000000188C6A8C8
	
		// Methods
		public static CubicSpline3 Create(); // 0x0000000188C6D134-0x0000000188C6D1B0
		public static CubicSpline3 Create(IList<Vector3> points, SplineTypes type); // 0x0000000188C6D1B0-0x0000000188C6D398
		private void BuildSpline(); // 0x0000000188C6BA18-0x0000000188C6BA80
		private void CreateOpenedSpline(); // 0x0000000188C6C8E4-0x0000000188C6D134
		private void CreateClosedSpline(); // 0x0000000188C6BACC-0x0000000188C6C8E4
		public override void AddVertexFirst(Vector3 position); // 0x0000000188C6B8F4-0x0000000188C6B988
		public override void AddVertexLast(Vector3 position); // 0x0000000188C6B988-0x0000000188C6BA18
		public override void RemoveVertex(int index); // 0x0000000188C6D550-0x0000000188C6D5B4
		public override void Clear(); // 0x0000000188C6BA80-0x0000000188C6BACC
		public override void InsertBefore(int vertexIndex, Vector3 position); // 0x0000000188C6D4B0-0x0000000188C6D550
		public override void InsertAfter(int vertexIndex, Vector3 position); // 0x0000000188C6D410-0x0000000188C6D4B0
		public override Vector3 GetVertex(int vertexIndex); // 0x0000000188C6D398-0x0000000188C6D410
		public override void SetVertex(int vertexIndex, Vector3 position); // 0x0000000188C6D5B4-0x0000000188C6D638
	}

	public enum SplineTypes // TypeDefIndex: 85110
	{
		Open = 0,
		Closed = 1
	}

	public enum SplinePlaneTypes // TypeDefIndex: 85111
	{
		XZ = 0,
		XY = 1,
		YZ = 2
	}

	public struct PositionTangent // TypeDefIndex: 85112
	{
		// Fields
		public Vector3 Position; // 0x00
		public Vector3 Tangent; // 0x0C
	}

	public struct CurveFrame // TypeDefIndex: 85113
	{
		// Fields
		public Vector3 Position; // 0x00
		public Vector3 Tangent; // 0x0C
		public Vector3 Normal; // 0x18
		public Vector3 Binormal; // 0x24
	}

	public abstract class SplineBase : MonoBehaviour // TypeDefIndex: 85116
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
		protected int SegmentCount { get; } // 0x0000000188C7863C-0x0000000188C7868C 
		public int VertexCount { get; } // 0x0000000188C786D0-0x0000000188C78710 
		public bool Valid { get; } // 0x0000000188C7868C-0x0000000188C786D0 
		public abstract SplineTypes SplineType { get; set; }
	
		// Nested types
		[Serializable]
		protected class ItemData // TypeDefIndex: 85114
		{
			// Fields
			public Vector3 Position; // 0x10
			public Vector3 A; // 0x1C
			public Vector3 B; // 0x28
			public Vector3 C; // 0x34
			public Vector3 D; // 0x40
			public float Length; // 0x4C
			public float AccumulatedLength; // 0x50
			private const int SegmentCount = 10; // Metadata: 0x026448D3
			private const int SegmentCountPlus1 = 11; // Metadata: 0x026448D4
			private const float DeltaTime = 0.1f; // Metadata: 0x026448D5
			public Vector3[] RenderPoints; // 0x58
	
			// Constructors
			public ItemData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool EnsureRenderPointsValidity(); // 0x0000000188C6EBB0-0x0000000188C6EC10
			public void UpdateRenderPoints(); // 0x0000000188C6F2AC-0x0000000188C6F324
			public Vector3 EvalPosition(float t); // 0x0000000188C6EE58-0x0000000188C6EF78
			public Vector3 EvalFirstDerivative(float t); // 0x0000000188C6EC10-0x0000000188C6ED08
			public Vector3 EvalSecondDerivative(float t); // 0x0000000188C6EF78-0x0000000188C6F01C
			public Vector3 EvalThirdDerivative(float t); // 0x0000000188C6F230-0x0000000188C6F278
			public float EvalSpeed(float t); // 0x0000000188C6F01C-0x0000000188C6F118
			public Vector3 EvalTangent(float t); // 0x0000000188C6F118-0x0000000188C6F230
			public float EvalLength(); // 0x0000000188C6ED08-0x0000000188C6EDA4
			public float EvalLength(float t0, float t1); // 0x0000000188C6EDA4-0x0000000188C6EE58
			public float ProcessLength(float currentLength); // 0x0000000188C6F278-0x0000000188C6F2AC
		}
	
		protected class ArcLengthParametrization // TypeDefIndex: 85115
		{
			// Fields
			public float[] sSample; // 0x10
			public float[] tSample; // 0x18
			public float[] tsSlope; // 0x20
			public float L; // 0x28
	
			// Constructors
			public ArcLengthParametrization(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public float GetApproximateTimeParameter(float s); // 0x0000000188C69B80-0x0000000188C69C50
		}
	
		// Constructors
		protected SplineBase(); // 0x0000000188C785A4-0x0000000188C7863C
	
		// Methods
		private void Awake(); // 0x0000000188C76850-0x0000000188C76858
		protected void GetSegmentIndexAndTime(float time, out int segmentIndex, out float segmentTime); // 0x0000000188C77DE8-0x0000000188C77E7C
		protected void PrepareForRuntime(); // 0x0000000188C78438-0x0000000188C784D0
		protected void RecalcSegmentsLength(); // 0x0000000188C784D0-0x0000000188C785A4
		public abstract void AddVertexFirst(Vector3 position);
		public abstract void AddVertexLast(Vector3 position);
		public abstract void RemoveVertex(int index);
		public abstract void Clear();
		public abstract void InsertBefore(int vertexIndex, Vector3 position);
		public abstract void InsertAfter(int vertexIndex, Vector3 position);
		public abstract Vector3 GetVertex(int vertexIndex);
		public abstract void SetVertex(int vertexIndex, Vector3 position);
		public Vector3 EvalPosition(float time); // 0x0000000188C776B0-0x0000000188C77770
		public Vector3 EvalTangent(float time); // 0x0000000188C77914-0x0000000188C779D4
		public PositionTangent EvalPositionTangent(float time); // 0x0000000188C77504-0x0000000188C775F4
		public void EvalPosition(float time, out Vector3 position); // 0x0000000188C775F4-0x0000000188C776B0
		public void EvalTangent(float time, out Vector3 tangent); // 0x0000000188C779D4-0x0000000188C77A90
		public void EvalPositionTangent(float time, out PositionTangent positionTangent); // 0x0000000188C77420-0x0000000188C77504
		public void EvalFrame(float time, out CurveFrame frame); // 0x0000000188C76E4C-0x0000000188C77074
		public float EvalCurvature(float time); // 0x0000000188C76A88-0x0000000188C76C0C
		public float EvalTorsion(float time); // 0x0000000188C77C48-0x0000000188C77DE8
		public Vector3 EvalPositionParametrized(float length); // 0x0000000188C77074-0x0000000188C77148
		public Vector3 EvalTangentParametrized(float length); // 0x0000000188C77840-0x0000000188C77914
		public PositionTangent EvalPositionTangentParametrized(float length); // 0x0000000188C77218-0x0000000188C77324
		public void EvalPositionParametrized(float length, out Vector3 position); // 0x0000000188C77148-0x0000000188C77218
		public void EvalTangentParametrized(float length, out Vector3 tangent); // 0x0000000188C77770-0x0000000188C77840
		public void EvalPositionTangentParametrized(float length, out PositionTangent positionTangent); // 0x0000000188C77324-0x0000000188C77420
		public void EvalFrameParametrized(float length, out CurveFrame frame); // 0x0000000188C76C0C-0x0000000188C76E4C
		public float EvalCurvatureParametrized(float length); // 0x0000000188C768EC-0x0000000188C76A88
		public float EvalTorsionParametrized(float length); // 0x0000000188C77A90-0x0000000188C77C48
		public float CalcTotalLength(); // 0x0000000188C76858-0x0000000188C768EC
		public float LengthToTime(float length, int iterations, float tolerance); // 0x0000000188C77EA4-0x0000000188C7816C
		public float LengthToTime(float length); // 0x0000000188C77E7C-0x0000000188C77EA4
		public float ParametrizeByArcLength(int pointCount); // 0x0000000188C7816C-0x0000000188C78438
	}

	public static class PointsFilter // TypeDefIndex: 85118
	{
		// Nested types
		private class Data // TypeDefIndex: 85117
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
			public Data(Vector3[] points, float radius, Rand rand, AAB3 aab); // 0x0000000188C6DEA8-0x0000000188C6E014
	
			// Methods
			private static int BinarySearch(List<int> array, int value); // 0x0000000188C6D6C4-0x0000000188C6D784
			private static int BinarySearch(int[] array, int length, int value); // 0x0000000188C6D64C-0x0000000188C6D6C4
			private void CalcGridIndices(ref Vector3 point, out int i, out int j, out int k); // 0x0000000188C6D784-0x0000000188C6D7CC
			public List<int> Filter(); // 0x0000000188C6D7CC-0x0000000188C6DEA8
		}
	
		// Methods
		public static List<int> DistanceFilter(Vector3[] points, AAB3 pointsAAB, float radius, Rand rand); // 0x0000000188C71740-0x0000000188C717F8
	}

	public class PoissonDiskSampler // TypeDefIndex: 85120
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
		public int MaxPoints { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233390-0x00000001872333A0 0x00000001872333F0-0x0000000187233400
	
		// Nested types
		public delegate float PointDelegate(ref Vector2 point); // TypeDefIndex: 85119; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		static PoissonDiskSampler(); // 0x0000000188C71E0C-0x0000000188C71E5C
		public PoissonDiskSampler(Rand rand, Vector2 minCorner, Vector2 maxCorner, float minDistanceOuter, float minDistanceInner = 1f /* Metadata: 0x026448D9 */); // 0x0000000188C71E5C-0x0000000188C720A4
	
		// Methods
		private void CalcGridIndices(ref Vector2 point, out int i, out int j); // 0x0000000188C71B40-0x0000000188C71B6C
		private void InsertIntoGrid(ref Vector2 point, int index); // 0x0000000188C71B6C-0x0000000188C71C08
		private bool AddPoint(ref Vector2 center); // 0x0000000188C717F8-0x0000000188C71B40
		public List<Vector2> Sample(); // 0x0000000188C71C08-0x0000000188C71E0C
	}

	public class WeightedSampler // TypeDefIndex: 85121
	{
		// Fields
		protected float[] _accum; // 0x10
		protected float _total; // 0x18
		protected Rand _rand; // 0x20
	
		// Constructors
		protected WeightedSampler(Rand rand); // 0x0000000187835950-0x0000000187835960
		public WeightedSampler(float[] weights); // 0x0000000188C797F4-0x0000000188C79864
		public WeightedSampler(float[] weights, Rand rand); // 0x0000000188C797C8-0x0000000188C797F4
	
		// Methods
		protected static int BinarySearch(float[] array, float value); // 0x0000000188C7961C-0x0000000188C79688
		protected void Init(float[] weights); // 0x0000000188C79688-0x0000000188C79788
		public int SampleIndex(); // 0x0000000188C79788-0x0000000188C797C8
	}

	public class TrianglesSamplerBase : WeightedSampler // TypeDefIndex: 85122
	{
		// Fields
		protected Vector3[] _vertices; // 0x28
	
		// Constructors
		protected TrianglesSamplerBase(Rand rand); // 0x0000000187835950-0x0000000187835960
	
		// Methods
		protected float CalclTriangleArea(ref Vector3 e0, ref Vector3 e1); // 0x0000000187239470-0x0000000187239510
	}

	public class IndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 85123
	{
		// Fields
		protected int[] _indices; // 0x30
	
		// Constructors
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices); // 0x0000000188C6E9B0-0x0000000188C6EA40
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices, Rand rand); // 0x0000000188C6EA40-0x0000000188C6EA98
		public IndexedTrianglesSampler(Mesh mesh); // 0x0000000188C6EA98-0x0000000188C6EB40
		public IndexedTrianglesSampler(Mesh mesh, Rand rand); // 0x0000000188C6EB40-0x0000000188C6EBB0
	
		// Methods
		protected void Init(); // 0x0000000188C6E014-0x0000000188C6E3EC
		public Vector3 Sample(); // 0x0000000188C6E898-0x0000000188C6E9B0
		public Vector3[] SampleArray(int count); // 0x0000000188C6E730-0x0000000188C6E898
		public Vector3[] SampleArray(int count, Vector2[] uvs, Texture2D sampleMap, float min = 0f /* Metadata: 0x026448DD */, float max = 1f /* Metadata: 0x026448E1 */); // 0x0000000188C6E3EC-0x0000000188C6E730
	}

	public class NonIndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 85124
	{
		// Constructors
		public NonIndexedTrianglesSampler(Vector3[] vertices); // 0x0000000188C6FC40-0x0000000188C6FCB8
		public NonIndexedTrianglesSampler(Vector3[] vertices, Rand rand); // 0x0000000188C6FB2C-0x0000000188C6FB60
		public NonIndexedTrianglesSampler(Mesh mesh); // 0x0000000188C6FB60-0x0000000188C6FBEC
		public NonIndexedTrianglesSampler(Mesh mesh, Rand rand); // 0x0000000188C6FBEC-0x0000000188C6FC40
	
		// Methods
		protected void Init(); // 0x0000000188C6F5EC-0x0000000188C6F934
		public Vector3 Sample(); // 0x0000000188C6FA5C-0x0000000188C6FB2C
		public Vector3[] SampleArray(int count); // 0x0000000188C6F934-0x0000000188C6FA5C
	}

	public class ShuffleBag<T> : IEnumerable<T> // TypeDefIndex: 85126
	{
		// Fields
		private Rand _rand;
		private List<T> _items;
		private int _index;
	
		// Properties
		public int Count { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__13 : IEnumerator<T> // TypeDefIndex: 85125
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
		public void Add(T item, uint count = 1 /* Metadata: 0x026448E5 */);
		public T NextItem();
		public void Reset();
		public void Clear();
		[IteratorStateMachine(typeof(_GetEnumerator_d__13))]
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public static class Util // TypeDefIndex: 85127
	{
		// Extension methods
		public static void Shuffle<T>(this IList<T> collection);
		public static void Shuffle<T>(this IList<T> collection, Rand rand);
		public static void Shuffle<T>(this T[] collection);
		public static void Shuffle<T>(this T[] collection, Rand rand);
	}
}
