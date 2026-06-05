/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Image 36: DestMath.dll - Assembly: DestMath, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55819-55970

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 55970
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_20 _170A8789272DFBCBA0E6B7D2530CAA16D9199834934F442421DAB41C5EEA8C29; // 0x00 // Static value (base64): 9pxyPtEO9T60ohE/0Q71Pvaccj4= - Metadata: 0x0207C16C
	internal static readonly __StaticArrayInitTypeSize_20 _92052E6D9D3C30FD20B710DFB226BEEA15F69C2188B5AA373563D6966493C59C; // 0x14 // Static value (base64): Z/tnvyDZCb8AAAAAINkJP2f7Zz8= - Metadata: 0x0207C184

	// Nested types
	private struct __StaticArrayInitTypeSize_20 // TypeDefIndex: 55969
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Dest.Math
{
	public class Polynomial // TypeDefIndex: 55820
	{
		// Fields
		private int _degree; // 0x10
		private float[] _coeffs; // 0x18
	
		// Properties
		public int Degree { get => default; set {} } // 0x0000000181C0BBD0-0x0000000181C0BBE0 0x00000001878B60A4-0x00000001878B60F8
		public float this[int index] { get => default; set {} } // 0x00000001878B6074-0x00000001878B60A4 0x00000001878B60F8-0x00000001878B6128
	
		// Constructors
		public Polynomial() {} // Dummy constructor
		public Polynomial(int degree) {} // 0x00000001878B606C-0x00000001878B6074
	
		// Methods
		public Polynomial DeepCopy() => default; // 0x00000001878B5F68-0x00000001878B6018
		public Polynomial CalcDerivative() => default; // 0x00000001878B5CE4-0x00000001878B5DE8
		public Polynomial CalcInversion() => default; // 0x00000001878B5DE8-0x00000001878B5E9C
		public void Compress(float epsilon = 1E-05f /* Metadata: 0x0207BFC0 */) {} // 0x00000001878B5E9C-0x00000001878B5F68
		public float Eval(float t) => default; // 0x00000001878B6018-0x00000001878B606C
	}

	public static class Approximation // TypeDefIndex: 55821
	{
		// Methods
		public static Box2 GaussPointsFit2(IList<Vector2> points) => default; // 0x00000001878A8510-0x00000001878A88BC
		internal static bool HeightLineFit2(IList<Vector2> points, out float a, out float b) {
			a = default;
			b = default;
			return default;
		} // 0x00000001878A8DA0-0x00000001878A9070
		public static Line2 LeastSquaresLineFit2(IList<Vector2> points) => default; // 0x00000001878A9508-0x00000001878A97F4
		public static Box3 GaussPointsFit3(IList<Vector3> points) => default; // 0x00000001878A88BC-0x00000001878A8DA0
		public static Line3 LeastsSquaresLineFit3(IList<Vector3> points) => default; // 0x00000001878A9BB0-0x00000001878A9FE4
		internal static bool HeightPlaneFit3(IList<Vector3> points, out float a, out float b, out float c) {
			a = default;
			b = default;
			c = default;
			return default;
		} // 0x00000001878A9070-0x00000001878A9508
		public static Plane3 LeastSquaresPlaneFit3(IList<Vector3> points) => default; // 0x00000001878A97F4-0x00000001878A9BB0
	}

	internal class ConcaveHull2 // TypeDefIndex: 55824
	{
		// Nested types
		private struct Edge // TypeDefIndex: 55822
		{
			// Fields
			public int V0; // 0x00
			public int V1; // 0x04
	
			// Constructors
			public Edge(int v0, int v1) {
				V0 = default;
				V1 = default;
			} // 0x00000001878AAD70-0x00000001878AAE44
		}
	
		private struct InnerPoint // TypeDefIndex: 55823
		{
			// Fields
			public float AverageDistance; // 0x00
			public float Distance0; // 0x04
			public float Distance1; // 0x08
			public int Index; // 0x0C
		}
	
		// Constructors
		public ConcaveHull2() {} // 0x000000018357CB90-0x000000018357CBA0
	
		// Methods
		private static bool _TryFastSort(InnerPoint[] x, int first, int last) => default; // 0x00000001878AABCC-0x00000001878AAD70
		private static void Quicksort(InnerPoint[] x, int first, int last) {} // 0x00000001878A9FE4-0x00000001878AA0F4
		private static float CalcDistanceFromPointToEdge(ref Vector2 pointA, ref Vector2 v0, ref Vector2 v1) => default; // 0x00000001878AA0F4-0x00000001878AABCC
		public static bool Create(Vector2[] points, out int[] concaveHull, int[] convexHull, float N, float epsilon = 1E-05f /* Metadata: 0x0207BFC4 */) {
			concaveHull = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
	}

	public static class ConcaveHull // TypeDefIndex: 55825
	{
		// Methods
		public static bool Create2D(Vector2[] points, out int[] concaveHull, out int[] convexHull, float algorithmThreshold, float epsilon = 1E-05f /* Metadata: 0x0207BFC8 */) {
			concaveHull = default;
			convexHull = default;
			return default;
		} // 0x00000001878AAE6C-0x00000001878AAFB8
		public static bool Create2D(Vector2[] points, out int[] concaveHull, float algorithmThreshold, float epsilon = 1E-05f /* Metadata: 0x0207BFCC */) {
			concaveHull = default;
			return default;
		} // 0x00000001878AAE44-0x00000001878AAE6C
	}

	internal class ConvexHull1 // TypeDefIndex: 55828
	{
		// Nested types
		private class SortedVertex // TypeDefIndex: 55826
		{
			// Fields
			public float Value; // 0x10
			public int Index; // 0x14
	
			// Constructors
			public SortedVertex() {} // 0x00000001878AAFB8-0x00000001878AB270
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 55827
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Comparison<SortedVertex> __9__1_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185492010-0x0000000185492020
			public __c() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal int _Create_b__1_0(SortedVertex e1, SortedVertex e2) => default; // 0x00000001878B6344-0x00000001878B63A8
		}
	
		// Constructors
		public ConvexHull1() {} // 0x00000001878B62D8-0x00000001878B6344
	
		// Methods
		public static void Create(float[] vertices, float epsilon, out int dimension, out int[] indices) {
			dimension = default;
			indices = default;
		} // 0x0000000185492010-0x0000000185492020
	}

	internal class ConvexHull2 // TypeDefIndex: 55830
	{
		// Nested types
		private class Edge // TypeDefIndex: 55829
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public Edge E0; // 0x18
			public Edge E1; // 0x20
			public int Sign; // 0x28
			public int Time; // 0x2C
	
			// Constructors
			public Edge() {} // Dummy constructor
			public Edge(int v0, int v1) {} // 0x00000001878AB270-0x00000001878AB724
	
			// Methods
			public int GetSign(int i, Query2 query) => default; // 0x00000001878AB724-0x00000001878AB8FC
			public void Insert(Edge adj0, Edge adj1) {} // 0x0000000185492010-0x0000000185492020
			public void DeleteSelf() {} // 0x0000000185FB3870-0x0000000185FB3880
			public void GetIndices(out int[] indices) {
				indices = default;
			} // 0x00000001878B5C48-0x00000001878B5C8C
		}
	
		// Constructors
		public ConvexHull2() {} // 0x00000001878B5BA4-0x00000001878B5C48
	
		// Methods
		public static bool Create(IList<Vector2> vertices, float epsilon, out int dimension, out int[] indices) {
			dimension = default;
			indices = default;
			return default;
		} // 0x00000001878B5C8C-0x00000001878B5CE4
		private static bool Update(ref Edge hull, int i, Query2 query) => default; // 0x00000001878B5B64-0x00000001878B5BA4
	}

	internal class ConvexHull3 // TypeDefIndex: 55833
	{
		// Nested types
		private class Triangle // TypeDefIndex: 55831
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
			public Triangle() {} // Dummy constructor
			public Triangle(int v0, int v1, int v2) {} // 0x00000001878AB8FC-0x00000001878AC0F0
	
			// Methods
			public Triangle GetAdj(int index) => default; // 0x00000001878AC308-0x00000001878ACC90
			public void SetAdj(int index, Triangle value) {} // 0x00000001878AC0F0-0x00000001878AC308
			public int GetV(int index) => default; // 0x0000000185492010-0x0000000185492020
			public int GetSign(int i, Query3 query) => default; // 0x0000000185FB3880-0x0000000185FB38A0
			public void AttachTo(Triangle adj0, Triangle adj1, Triangle adj2) {} // 0x00000001878B6230-0x00000001878B6248
			public int DetachFrom(int adjIndex, Triangle adj) => default; // 0x00000001878B62A8-0x00000001878B62D8
		}
	
		private class TerminatorData // TypeDefIndex: 55832
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public int NullIndex; // 0x18
			public Triangle T; // 0x20
	
			// Constructors
			public TerminatorData() {} // Dummy constructor
			public TerminatorData(int v0 = -1 /* Metadata: 0x0207BFD0 */, int v1 = -1 /* Metadata: 0x0207BFD1 */, int nullIndex = -1 /* Metadata: 0x0207BFD2 */, Triangle tri = null) {} // 0x00000001878B6290-0x00000001878B62A8
		}
	
		// Constructors
		public ConvexHull3() {} // 0x00000001878B6128-0x00000001878B615C
	
		// Methods
		public static bool Create(IList<Vector3> vertices, float epsilon, out int dimension, out int[] indices) {
			dimension = default;
			indices = default;
			return default;
		} // 0x00000001878B6248-0x00000001878B6290
		private static bool Update(HashSet<Triangle> hull, int i, Query3 query) => default; // 0x00000001878B615C-0x00000001878B6194
		private static void ExtractIndices(HashSet<Triangle> hull, out int[] indices) {
			indices = default;
		} // 0x00000001878B6194-0x00000001878B6230
	}

	public static class ConvexHull // TypeDefIndex: 55834
	{
		// Methods
		public static bool Create2D(IList<Vector2> points, out int[] indices, out int dimension, float epsilon = 1E-05f /* Metadata: 0x0207BFD3 */) {
			indices = default;
			dimension = default;
			return default;
		} // 0x00000001878ACC90-0x00000001878ACD30
		public static bool Create3D(IList<Vector3> points, out int[] indices, out int dimension, float epsilon = 1E-05f /* Metadata: 0x0207BFD7 */) {
			indices = default;
			dimension = default;
			return default;
		} // 0x00000001878ACD30-0x00000001878ACDD0
	}

	public static class Distance // TypeDefIndex: 55835
	{
		// Methods
		public static float Line2Line2(ref Line2 line0, ref Line2 line1) => default; // 0x00000001878AE468-0x00000001878AE490
		public static float Line2Line2(ref Line2 line0, ref Line2 line1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AE490-0x00000001878AE4C0
		public static float SqrLine2Line2(ref Line2 line0, ref Line2 line1) => default; // 0x00000001878AF758-0x00000001878AF870
		public static float SqrLine2Line2(ref Line2 line0, ref Line2 line1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AF870-0x00000001878AFA9C
		public static float Line2Ray2(ref Line2 line, ref Ray2 ray) => default; // 0x00000001878AE4C0-0x00000001878AE4E8
		public static float Line2Ray2(ref Line2 line, ref Ray2 ray, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AE4E8-0x00000001878AE518
		public static float SqrLine2Ray2(ref Line2 line, ref Ray2 ray) => default; // 0x00000001878AFA9C-0x00000001878AFC28
		public static float SqrLine2Ray2(ref Line2 line, ref Ray2 ray, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AFC28-0x00000001878AFE84
		public static float Line2Segment2(ref Line2 line, ref Segment2 segment) => default; // 0x00000001878AE548-0x00000001878AE570
		public static float Line2Segment2(ref Line2 line, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AE518-0x00000001878AE548
		public static float SqrLine2Segment2(ref Line2 line, ref Segment2 segment) => default; // 0x00000001878AFE84-0x00000001878B00B4
		public static float SqrLine2Segment2(ref Line2 line, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B00B4-0x00000001878B0384
		public static float Point2AAB2(ref Vector2 point, ref AAB2 box) => default; // 0x00000001878AE7C0-0x00000001878AE834
		public static float Point2AAB2(ref Vector2 point, ref AAB2 box, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AE704-0x00000001878AE7C0
		public static float SqrPoint2AAB2(ref Vector2 point, ref AAB2 box) => default; // 0x00000001878B145C-0x00000001878B14CC
		public static float SqrPoint2AAB2(ref Vector2 point, ref AAB2 box, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B14CC-0x00000001878B1584
		public static float Point2Box2(ref Vector2 point, ref Box2 box) => default; // 0x00000001878AE85C-0x00000001878AE884
		public static float Point2Box2(ref Vector2 point, ref Box2 box, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AE834-0x00000001878AE85C
		public static float SqrPoint2Box2(ref Vector2 point, ref Box2 box) => default; // 0x00000001878B1584-0x00000001878B169C
		public static float SqrPoint2Box2(ref Vector2 point, ref Box2 box, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B169C-0x00000001878B185C
		public static float Point2Circle2(ref Vector2 point, ref Circle2 circle) => default; // 0x00000001878AE934-0x00000001878AE970
		public static float Point2Circle2(ref Vector2 point, ref Circle2 circle, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AE884-0x00000001878AE934
		public static float SqrPoint2Circle2(ref Vector2 point, ref Circle2 circle) => default; // 0x00000001878B1910-0x00000001878B1950
		public static float SqrPoint2Circle2(ref Vector2 point, ref Circle2 circle, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B185C-0x00000001878B1910
		public static float Point2Line2(ref Vector2 point, ref Line2 line) => default; // 0x00000001878AE998-0x00000001878AE9C0
		public static float Point2Line2(ref Vector2 point, ref Line2 line, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AE970-0x00000001878AE998
		public static float SqrPoint2Line2(ref Vector2 point, ref Line2 line) => default; // 0x00000001878B1A34-0x00000001878B1B08
		public static float SqrPoint2Line2(ref Vector2 point, ref Line2 line, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B1950-0x00000001878B1A34
		public static float Point2Ray2(ref Vector2 point, ref Ray2 ray) => default; // 0x00000001878AE9C0-0x00000001878AE9E8
		public static float Point2Ray2(ref Vector2 point, ref Ray2 ray, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AE9E8-0x00000001878AEA10
		public static float SqrPoint2Ray2(ref Vector2 point, ref Ray2 ray) => default; // 0x00000001878B1C14-0x00000001878B1D00
		public static float SqrPoint2Ray2(ref Vector2 point, ref Ray2 ray, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B1B08-0x00000001878B1C14
		public static float Point2Segment2(ref Vector2 point, ref Segment2 segment) => default; // 0x00000001878AEA10-0x00000001878AEA38
		public static float Point2Segment2(ref Vector2 point, ref Segment2 segment, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AEA38-0x00000001878AEA60
		public static float SqrPoint2Segment2(ref Vector2 point, ref Segment2 segment) => default; // 0x00000001878B1E34-0x00000001878B1F5C
		public static float SqrPoint2Segment2(ref Vector2 point, ref Segment2 segment, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B1D00-0x00000001878B1E34
		public static float Point2Triangle2(ref Vector2 point, ref Triangle2 triangle) => default; // 0x00000001878AEA60-0x00000001878AEBC8
		public static float Point2Triangle2(ref Vector2 point, ref Triangle2 triangle, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AEBC8-0x00000001878AED80
		public static float SqrPoint2Triangle2(ref Vector2 point, ref Triangle2 triangle) => default; // 0x00000001878B1F5C-0x00000001878B20C4
		public static float SqrPoint2Triangle2(ref Vector2 point, ref Triangle2 triangle, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B20C4-0x00000001878B227C
		public static float Ray2Ray2(ref Ray2 ray0, ref Ray2 ray1) => default; // 0x00000001878AF4A8-0x00000001878AF4E8
		public static float Ray2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AF478-0x00000001878AF4A8
		public static float SqrRay2Ray2(ref Ray2 ray0, ref Ray2 ray1) => default; // 0x00000001878B4124-0x00000001878B4150
		public static float SqrRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B3E34-0x00000001878B4124
		public static float Ray2Segment2(ref Ray2 ray, ref Segment2 segment) => default; // 0x00000001878AF4E8-0x00000001878AF528
		public static float Ray2Segment2(ref Ray2 ray, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AF528-0x00000001878AF558
		public static float SqrRay2Segment2(ref Ray2 ray, ref Segment2 segment) => default; // 0x00000001878B44B4-0x00000001878B44E0
		public static float SqrRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B4150-0x00000001878B44B4
		public static float Segment2Segment2(ref Segment2 segment0, ref Segment2 segment1) => default; // 0x00000001878AF650-0x00000001878AF690
		public static float Segment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AF620-0x00000001878AF650
		public static float SqrSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1) => default; // 0x00000001878B4DC0-0x00000001878B4DEC
		public static float SqrSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B4DEC-0x00000001878B5370
		private static void Face(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref Vector3 PmE, ref float sqrDistance) {} // 0x00000001878AD63C-0x00000001878AE468
		private static void CaseNoZeros(ref Box3 mBox, ref float mLineParameter, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance) {} // 0x00000001878AD55C-0x00000001878AD63C
		private static void Case0(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance) {} // 0x00000001878AD0F8-0x00000001878AD55C
		private static void Case00(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance) {} // 0x00000001878ACEE8-0x00000001878AD0F8
		private static void Case000(ref Box3 mBox, ref float mLineParameter, ref Vector3 pnt, ref float sqrDistance) {} // 0x00000001878ACDD0-0x00000001878ACEE8
		public static float Line3Box3(ref Line3 line, ref Box3 box, out Line3Box3Dist info) {
			info = default;
			return default;
		} // 0x00000001878AE570-0x00000001878AE598
		public static float Line3Box3(ref Line3 line, ref Box3 box) => default; // 0x00000001878AE598-0x00000001878AE5D8
		public static float SqrLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Dist info) {
			info = default;
			return default;
		} // 0x00000001878B0384-0x00000001878B093C
		public static float SqrLine3Box3(ref Line3 line, ref Box3 box) => default; // 0x00000001878B093C-0x00000001878B0968
		public static float Line3Line3(ref Line3 line0, ref Line3 line1) => default; // 0x00000001878AE5D8-0x00000001878AE60C
		public static float Line3Line3(ref Line3 line0, ref Line3 line1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AE60C-0x00000001878AE63C
		public static float SqrLine3Line3(ref Line3 line0, ref Line3 line1) => default; // 0x00000001878B0968-0x00000001878B099C
		public static float SqrLine3Line3(ref Line3 line0, ref Line3 line1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B099C-0x00000001878B0CEC
		public static float Line3Ray3(ref Line3 line, ref Ray3 ray) => default; // 0x00000001878AE63C-0x00000001878AE670
		public static float Line3Ray3(ref Line3 line, ref Ray3 ray, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AE670-0x00000001878AE6A0
		public static float SqrLine3Ray3(ref Line3 line, ref Ray3 ray) => default; // 0x00000001878B102C-0x00000001878B1060
		public static float SqrLine3Ray3(ref Line3 line, ref Ray3 ray, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B0CEC-0x00000001878B102C
		public static float Line3Segment3(ref Line3 line, ref Segment3 segment) => default; // 0x00000001878AE6A0-0x00000001878AE6D4
		public static float Line3Segment3(ref Line3 line, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AE6D4-0x00000001878AE704
		public static float SqrLine3Segment3(ref Line3 line, ref Segment3 segment) => default; // 0x00000001878B1060-0x00000001878B1094
		public static float SqrLine3Segment3(ref Line3 line, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B1094-0x00000001878B145C
		public static float Point3AAB3(ref Vector3 point, ref AAB3 box) => default; // 0x00000001878AED80-0x00000001878AEE24
		public static float Point3AAB3(ref Vector3 point, ref AAB3 box, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AEE24-0x00000001878AEF34
		public static float SqrPoint3AAB3(ref Vector3 point, ref AAB3 box) => default; // 0x00000001878B2388-0x00000001878B2428
		public static float SqrPoint3AAB3(ref Vector3 point, ref AAB3 box, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B227C-0x00000001878B2388
		public static float Point3Box3(ref Vector3 point, ref Box3 box) => default; // 0x00000001878AEF5C-0x00000001878AEF84
		public static float Point3Box3(ref Vector3 point, ref Box3 box, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AEF34-0x00000001878AEF5C
		public static float SqrPoint3Box3(ref Vector3 point, ref Box3 box) => default; // 0x00000001878B2428-0x00000001878B2604
		public static float SqrPoint3Box3(ref Vector3 point, ref Box3 box, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B2604-0x00000001878B2954
		public static float Point3Circle3(ref Vector3 point, ref Circle3 circle, bool solid = true /* Metadata: 0x0207BFDB */) => default; // 0x00000001878AEFB4-0x00000001878AEFF4
		public static float Point3Circle3(ref Vector3 point, ref Circle3 circle, out Vector3 closestPoint, bool solid = true /* Metadata: 0x0207BFDC */) {
			closestPoint = default;
			return default;
		} // 0x00000001878AEF84-0x00000001878AEFB4
		public static float SqrPoint3Circle3(ref Vector3 point, ref Circle3 circle, bool solid = true /* Metadata: 0x0207BFDD */) => default; // 0x00000001878B2D4C-0x00000001878B2D74
		public static float SqrPoint3Circle3(ref Vector3 point, ref Circle3 circle, out Vector3 closestPoint, bool solid = true /* Metadata: 0x0207BFDE */) {
			closestPoint = default;
			return default;
		} // 0x00000001878B2954-0x00000001878B2D4C
		public static float Point3Line3(ref Vector3 point, ref Line3 line) => default; // 0x00000001878AEFF4-0x00000001878AF01C
		public static float Point3Line3(ref Vector3 point, ref Line3 line, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AF01C-0x00000001878AF044
		public static float SqrPoint3Line3(ref Vector3 point, ref Line3 line) => default; // 0x00000001878B2EF0-0x00000001878B3064
		public static float SqrPoint3Line3(ref Vector3 point, ref Line3 line, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B2D74-0x00000001878B2EF0
		public static float Point3Plane3(ref Vector3 point, ref Plane3 plane) => default; // 0x00000001878AF160-0x00000001878AF200
		public static float Point3Plane3(ref Vector3 point, ref Plane3 plane, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AF044-0x00000001878AF160
		public static float SqrPoint3Plane3(ref Vector3 point, ref Plane3 plane) => default; // 0x00000001878B317C-0x00000001878B321C
		public static float SqrPoint3Plane3(ref Vector3 point, ref Plane3 plane, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B3064-0x00000001878B317C
		public static float Point3Ray3(ref Vector3 point, ref Ray3 ray) => default; // 0x00000001878AF228-0x00000001878AF250
		public static float Point3Ray3(ref Vector3 point, ref Ray3 ray, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AF200-0x00000001878AF228
		public static float SqrPoint3Ray3(ref Vector3 point, ref Ray3 ray) => default; // 0x00000001878B33C0-0x00000001878B3540
		public static float SqrPoint3Ray3(ref Vector3 point, ref Ray3 ray, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B321C-0x00000001878B33C0
		public static float Point3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle) => default; // 0x00000001878AF278-0x00000001878AF2A0
		public static float Point3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AF250-0x00000001878AF278
		public static float SqrPoint3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle) => default; // 0x00000001878B37A4-0x00000001878B3944
		public static float SqrPoint3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B3540-0x00000001878B37A4
		public static float Point3Segment3(ref Vector3 point, ref Segment3 segment) => default; // 0x00000001878AF2C8-0x00000001878AF2F0
		public static float Point3Segment3(ref Vector3 point, ref Segment3 segment, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AF2A0-0x00000001878AF2C8
		public static float SqrPoint3Segment3(ref Vector3 point, ref Segment3 segment) => default; // 0x00000001878B3B04-0x00000001878B3CA4
		public static float SqrPoint3Segment3(ref Vector3 point, ref Segment3 segment, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B3944-0x00000001878B3B04
		public static float Point3Sphere3(ref Vector3 point, ref Sphere3 sphere) => default; // 0x00000001878AF404-0x00000001878AF478
		public static float Point3Sphere3(ref Vector3 point, ref Sphere3 sphere, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878AF2F0-0x00000001878AF404
		public static float SqrPoint3Sphere3(ref Vector3 point, ref Sphere3 sphere) => default; // 0x00000001878B3CA4-0x00000001878B3D1C
		public static float SqrPoint3Sphere3(ref Vector3 point, ref Sphere3 sphere, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001878B3D1C-0x00000001878B3E34
		public static float Ray3Ray3(ref Ray3 ray0, ref Ray3 ray1) => default; // 0x00000001878AF588-0x00000001878AF5BC
		public static float Ray3Ray3(ref Ray3 ray0, ref Ray3 ray1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AF558-0x00000001878AF588
		public static float SqrRay3Ray3(ref Ray3 ray0, ref Ray3 ray1) => default; // 0x00000001878B4910-0x00000001878B4944
		public static float SqrRay3Ray3(ref Ray3 ray0, ref Ray3 ray1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B44E0-0x00000001878B4910
		public static float Ray3Segment3(ref Ray3 ray, ref Segment3 segment) => default; // 0x00000001878AF5EC-0x00000001878AF620
		public static float Ray3Segment3(ref Ray3 ray, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AF5BC-0x00000001878AF5EC
		public static float SqrRay3Segment3(ref Ray3 ray, ref Segment3 segment) => default; // 0x00000001878B4D8C-0x00000001878B4DC0
		public static float SqrRay3Segment3(ref Ray3 ray, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B4944-0x00000001878B4D8C
		public static float Segment3Box3(ref Segment3 segment, ref Box3 box, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AF690-0x00000001878AF6C0
		public static float Segment3Box3(ref Segment3 segment, ref Box3 box) => default; // 0x00000001878AF6C0-0x00000001878AF6F4
		public static float SqrSegment3Box3(ref Segment3 segment, ref Box3 box, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B53A4-0x00000001878B54A8
		public static float SqrSegment3Box3(ref Segment3 segment, ref Box3 box) => default; // 0x00000001878B5370-0x00000001878B53A4
		public static float Segment3Segment3(ref Segment3 segment0, ref Segment3 segment1) => default; // 0x00000001878AF724-0x00000001878AF758
		public static float Segment3Segment3(ref Segment3 segment0, ref Segment3 segment1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878AF6F4-0x00000001878AF724
		public static float SqrSegment3Segment3(ref Segment3 segment0, ref Segment3 segment1) => default; // 0x00000001878B54A8-0x00000001878B54DC
		public static float SqrSegment3Segment3(ref Segment3 segment0, ref Segment3 segment1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001878B54DC-0x00000001878B5B64
	}

	public struct Line3Box3Dist // TypeDefIndex: 55836
	{
		// Fields
		public Vector3 ClosestPoint0; // 0x00
		public Vector3 ClosestPoint1; // 0x0C
		public float LineParameter; // 0x18
	}

	public static class Intersection // TypeDefIndex: 55837
	{
		// Fields
		private static float _intervalThreshold; // 0x00
		private static float _dotThreshold; // 0x04
		private static float _distanceThreshold; // 0x08
	
		// Properties
		public static float IntervalThreshold { get; set; } // 0x00000001878C9924-0x00000001878C9974 0x00000001878C9AA4-0x00000001878C9B38
		public static float DotThreshold { get; set; } // 0x00000001878C98D4-0x00000001878C9924 0x00000001878C9A0C-0x00000001878C9AA4
		public static float DistanceThreshold { get; set; } // 0x00000001878C9884-0x00000001878C98D4 0x00000001878C9974-0x00000001878C9A0C
	
		// Constructors
		static Intersection() {} // 0x0000000185F7FDF0-0x0000000185F7FE60
	
		// Methods
		public static bool TestAAB2AAB2(ref AAB2 box0, ref AAB2 box1) => default; // 0x00000001878C2434-0x00000001878C2464
		public static bool FindAAB2AAB2(ref AAB2 box0, ref AAB2 box1, out AAB2 intersection) {
			intersection = default;
			return default;
		} // 0x00000001878B8E08-0x00000001878B8E94
		public static bool TestAAB2AAB2OverlapX(ref AAB2 box0, ref AAB2 box1) => default; // 0x00000001878C23FC-0x00000001878C2418
		public static bool TestAAB2AAB2OverlapY(ref AAB2 box0, ref AAB2 box1) => default; // 0x00000001878C2418-0x00000001878C2434
		public static bool TestAAB2Circle2(ref AAB2 box, ref Circle2 circle) => default; // 0x0000000184CFF330-0x0000000184CFF3A0
		public static bool TestBox2Box2(ref Box2 box0, ref Box2 box1) => default; // 0x00000001878C2500-0x00000001878C27D0
		public static bool TestBox2Circle2(ref Box2 box, ref Circle2 circle) => default; // 0x00000001878C27D0-0x00000001878C2908
		public static bool TestCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1) => default; // 0x00000001878C2B34-0x00000001878C2B84
		public static bool FindCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1, out Circle2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B8F80-0x00000001878B91D8
		private static int WhichSide(Polygon2 V, Vector2 P, ref Vector2 D) => default; // 0x00000001878C9580-0x00000001878C96B0
		public static bool TestConvexPolygon2ConvexPolygon2(Polygon2 convexPolygon0, Polygon2 convexPolygon1) => default; // 0x00000001878C2B84-0x00000001878C2D7C
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref AAB2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001878B8B28-0x00000001878B8E08
		public static bool TestLine2AAB2(ref Line2 line, ref AAB2 box) => default; // 0x00000001878C2D7C-0x00000001878C2ED4
		public static bool FindLine2AAB2(ref Line2 line, ref AAB2 box, out Line2AAB2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B91D8-0x00000001878B9274
		private static bool Clip(float denom, float numer, ref float t0, ref float t1) => default; // 0x00000001878B79DC-0x00000001878B7A3C
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref Box2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001878B81CC-0x00000001878B8530
		public static bool TestLine2Box2(ref Line2 line, ref Box2 box) => default; // 0x00000001878C2ED4-0x00000001878C2FC4
		public static bool FindLine2Box2(ref Line2 line, ref Box2 box, out Line2Box2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B9274-0x00000001878B9310
		private static bool Find(ref Vector2 origin, ref Vector2 direction, ref Vector2 center, float radius, out int rootCount, out float t0, out float t1) {
			rootCount = default;
			t0 = default;
			t1 = default;
			return default;
		} // 0x00000001878C11B0-0x00000001878C1308
		public static bool TestLine2Circle2(ref Line2 line, ref Circle2 circle) => default; // 0x00000001878C2FC4-0x00000001878C304C
		public static bool FindLine2Circle2(ref Line2 line, ref Circle2 circle, out Line2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B9310-0x00000001878B94BC
		public static bool TestLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon) => default; // 0x00000001878C304C-0x00000001878C3158
		public static bool FindLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon, out Line2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B94BC-0x00000001878B9808
		private static IntersectionTypes Classify(ref Line2 line0, ref Line2 line1, out float s0) {
			s0 = default;
			return default;
		} // 0x00000001878B65EC-0x00000001878B67B4
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C31B4-0x00000001878C3224
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1) => default; // 0x00000001878C3158-0x00000001878C31B4
		public static bool FindLine2Line2(ref Line2 line0, ref Line2 line1, out Line2Line2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B9808-0x00000001878B98DC
		private static IntersectionTypes Classify(ref Line2 line, ref Ray2 ray, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001878B6D38-0x00000001878B6F40
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C3280-0x00000001878C3338
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray) => default; // 0x00000001878C3224-0x00000001878C3280
		public static bool FindLine2Ray2(ref Line2 line, ref Ray2 ray, out Line2Ray2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B98DC-0x00000001878B9A1C
		private static IntersectionTypes Classify(ref Segment2 segment, ref Line2 line, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001878B6F40-0x00000001878B7158
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C3394-0x00000001878C3430
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment) => default; // 0x00000001878C3338-0x00000001878C3394
		public static bool FindLine2Segment2(ref Line2 line, ref Segment2 segment, out Line2Segment2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B9A1C-0x00000001878B9B40
		private static void TriangleLineRelations(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, out float dist0, out float dist1, out float dist2, out int sign0, out int sign1, out int sign2, out int positive, out int negative, out int zero) {
			dist0 = default;
			dist1 = default;
			dist2 = default;
			sign0 = default;
			sign1 = default;
			sign2 = default;
			positive = default;
			negative = default;
			zero = default;
		} // 0x00000001878C90E8-0x00000001878C9370
		private static bool GetInterval(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, float dist0, float dist1, float dist2, int sign0, int sign1, int sign2, out float param0, out float param1) {
			param0 = default;
			param1 = default;
			return default;
		} // 0x00000001878C1920-0x00000001878C1B8C
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C3430-0x00000001878C35F8
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle) => default; // 0x00000001878C35F8-0x00000001878C3654
		public static bool FindLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out Line2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001878B9B40-0x00000001878B9DE0
		public static bool TestRay2AAB2(ref Ray2 ray, ref AAB2 box) => default; // 0x00000001878C497C-0x00000001878C4AA4
		public static bool FindRay2AAB2(ref Ray2 ray, ref AAB2 box, out Ray2AAB2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BBA74-0x00000001878BBB0C
		public static bool TestRay2Box2(ref Ray2 ray, ref Box2 box) => default; // 0x00000001878C4AA4-0x00000001878C4C90
		public static bool FindRay2Box2(ref Ray2 ray, ref Box2 box, out Ray2Box2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BBB0C-0x00000001878BBBA4
		public static bool TestRay2Circle2(ref Ray2 ray, ref Circle2 circle) => default; // 0x00000001878C4C90-0x00000001878C4D24
		public static bool FindRay2Circle2(ref Ray2 ray, ref Circle2 circle, out Ray2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BBBA4-0x00000001878BBD80
		public static bool TestRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon) => default; // 0x00000001878C4D24-0x00000001878C4E30
		public static bool FindRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon, out Ray2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BBD80-0x00000001878BC0C8
		public static bool TestRay2Polygon2(ref Ray2 ray, Polygon2 polygon) => default; // 0x00000001878C4E30-0x00000001878C4F3C
		public static bool TestRay2Polygon2(ref Ray2 ray, Segment2[] segments) => default; // 0x00000001878C4F3C-0x00000001878C4FDC
		public static bool FindRay2Polygon2(ref Ray2 ray, Polygon2 polygon, out Ray2Polygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BC244-0x00000001878BC43C
		public static bool FindRay2Polygon2(ref Ray2 ray, Segment2[] segments, out Ray2Polygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BC0C8-0x00000001878BC244
		private static IntersectionTypes Classify(ref Ray2 ray0, ref Ray2 ray1, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001878B63A8-0x00000001878B65EC
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C4FDC-0x00000001878C5138
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1) => default; // 0x00000001878C5138-0x00000001878C5194
		public static bool FindRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Ray2Ray2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BC43C-0x00000001878BC640
		private static IntersectionTypes Classify(ref Ray2 ray, ref Segment2 segment, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001878B6A8C-0x00000001878B6D38
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C51F0-0x00000001878C533C
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment) => default; // 0x00000001878C5194-0x00000001878C51F0
		public static bool FindRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Ray2Segment2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BC640-0x00000001878BC850
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C533C-0x00000001878C5500
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle) => default; // 0x00000001878C5500-0x00000001878C555C
		public static bool FindRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out Ray2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BC850-0x00000001878BCAEC
		public static bool TestSegment2AAB2(ref Segment2 segment, ref AAB2 box) => default; // 0x00000001878C65C8-0x00000001878C6708
		public static bool FindSegment2AAB2(ref Segment2 segment, ref AAB2 box, out Segment2AAB2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BDFF4-0x00000001878BE0B4
		public static bool TestSegment2Box2(ref Segment2 segment, ref Box2 box) => default; // 0x00000001878C6708-0x00000001878C6908
		public static bool FindSegment2Box2(ref Segment2 segment, ref Box2 box, out Segment2Box2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BE0B4-0x00000001878BE174
		public static bool TestSegment2Circle2(ref Segment2 segment, ref Circle2 circle) => default; // 0x00000001878C6908-0x00000001878C69DC
		public static bool FindSegment2Circle2(ref Segment2 segment, ref Circle2 circle, out Segment2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BE174-0x00000001878BE3DC
		public static bool TestSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon) => default; // 0x00000001878C69DC-0x00000001878C6A40
		public static bool FindSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon, out Segment2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BE3DC-0x00000001878BE720
		private static IntersectionTypes Classify(ref Segment2 segment0, ref Segment2 segment1, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001878B67B4-0x00000001878B6A8C
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C6A9C-0x00000001878C6C00
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1) => default; // 0x00000001878C6A40-0x00000001878C6A9C
		public static bool FindSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Segment2Segment2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BE720-0x00000001878BEA3C
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C6C5C-0x00000001878C6E44
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle) => default; // 0x00000001878C6C00-0x00000001878C6C5C
		public static bool FindSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out Segment2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001878BEA3C-0x00000001878BED4C
		private static int WhichSide(ref Triangle2 triangle, ref Vector2 P, ref Vector2 D) => default; // 0x00000001878C96B0-0x00000001878C9884
		private static void ClipConvexPolygonAgainstLine(ref Vector2 edgeStart, ref Vector2 edgeEnd, ref int quantity, ref Triangle2Triangle2Intr info) {} // 0x00000001878B7158-0x00000001878B79DC
		public static bool TestTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1) => default; // 0x00000001878C7F8C-0x00000001878C81D8
		public static bool FindTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1, out Triangle2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001878C0770-0x00000001878C08B8
		public static bool TestAAB3AAB3(ref AAB3 box0, ref AAB3 box1) => default; // 0x00000001878C24B8-0x00000001878C2500
		public static bool FindAAB3AAB3(ref AAB3 box0, ref AAB3 box1, out AAB3 intersection) {
			intersection = default;
			return default;
		} // 0x00000001878B8E94-0x00000001878B8F80
		public static bool TestAAB3AAB3OverlapX(ref AAB3 box0, ref AAB3 box1) => default; // 0x00000001878C2464-0x00000001878C2480
		public static bool TestAAB3AAB3OverlapY(ref AAB3 box0, ref AAB3 box1) => default; // 0x00000001878C2480-0x00000001878C249C
		public static bool TestAAB3AAB3OverlapZ(ref AAB3 box0, ref AAB3 box1) => default; // 0x00000001878C249C-0x00000001878C24B8
		public static bool TestAAB3Sphere3(ref AAB3 box, ref Sphere3 sphere) => default; // 0x0000000184265F40-0x0000000184265FD0
		public static bool TestBox3Box3(ref Box3 box0, ref Box3 box1) => default; // 0x0000000184402350-0x00000001844028C0
		public static bool TestBox3Capsule3(ref Box3 box, ref Capsule3 capsule) => default; // 0x00000001878C2908-0x00000001878C2930
		public static bool TestBox3Sphere3(ref Box3 box, ref Sphere3 sphere) => default; // 0x00000001878C2930-0x00000001878C2B34
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref AAB3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001878B7D7C-0x00000001878B81CC
		public static bool TestLine3AAB3(ref Line3 line, ref AAB3 box) => default; // 0x00000001878C3654-0x00000001878C37F0
		public static bool FindLine3AAB3(ref Line3 line, ref AAB3 box, out Line3AAB3Intr info) {
			info = default;
			return default;
		} // 0x00000001878B9DE0-0x00000001878B9E7C
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref Box3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001878B8530-0x00000001878B8B28
		public static bool TestLine3Box3(ref Line3 line, ref Box3 box) => default; // 0x00000001878C37F0-0x00000001878C3AB0
		public static bool FindLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Intr info) {
			info = default;
			return default;
		} // 0x00000001878B9E7C-0x00000001878B9F18
		public static bool TestLine3Circle3(ref Line3 line, ref Circle3 circle) => default; // 0x00000001878C3AB0-0x00000001878C3B10
		public static bool FindLine3Circle3(ref Line3 line, ref Circle3 circle, out Line3Circle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878B9F18-0x00000001878BA12C
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C3B10-0x00000001878C3C48
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane) => default; // 0x00000001878C3C48-0x00000001878C3CA4
		public static bool FindLine3Plane3(ref Line3 line, ref Plane3 plane, out Line3Plane3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BA12C-0x00000001878BA2AC
		public static bool TestLine3Polygon3(ref Line3 line, Polygon3 polygon) => default; // 0x00000001878C3CA4-0x00000001878C3D04
		public static bool FindLine3Polygon3(ref Line3 line, Polygon3 polygon, out Line3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BA2AC-0x00000001878BA48C
		private static bool Point3InsideRectangle3(ref Vector3 point, ref Rectangle3 rectangle) => default; // 0x00000001878C203C-0x00000001878C2168
		public static bool TestLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle) => default; // 0x00000001878C3D04-0x00000001878C3D64
		public static bool FindLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle, out Line3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BA48C-0x00000001878BA674
		public static bool TestLine3Sphere3(ref Line3 line, ref Sphere3 sphere) => default; // 0x00000001878C3D64-0x00000001878C3E78
		public static bool FindLine3Sphere3(ref Line3 line, ref Sphere3 sphere, out Line3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BA674-0x00000001878BA96C
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C41DC-0x00000001878C450C
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C4118-0x00000001878C41DC
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C3F94-0x00000001878C4058
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle) => default; // 0x00000001878C3E78-0x00000001878C3ED4
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001878C4058-0x00000001878C4118
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001878C3ED4-0x00000001878C3F94
		public static bool FindLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BAAF4-0x00000001878BAEFC
		public static bool FindLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BA96C-0x00000001878BAA30
		public static bool FindLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BAA30-0x00000001878BAAF4
		public static bool TestPlane3AAB3(ref Plane3 plane, ref AAB3 box) => default; // 0x00000001878C450C-0x00000001878C45DC
		public static bool TestPlane3Box3(ref Plane3 plane, ref Box3 box) => default; // 0x00000001878C45DC-0x00000001878C4748
		public static bool TestPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1) => default; // 0x00000001878C4748-0x00000001878C47E8
		public static bool FindPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1, out Plane3Plane3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BAEFC-0x00000001878BB138
		public static bool TestPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere) => default; // 0x00000001878C47E8-0x00000001878C481C
		public static bool FindPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere, out Plane3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BB138-0x00000001878BB2B8
		public static bool TestPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle) => default; // 0x00000001878C481C-0x00000001878C497C
		public static bool FindPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle, out Plane3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BB2B8-0x00000001878BBA74
		public static bool TestRay3AAB3(ref Ray3 ray, ref AAB3 box) => default; // 0x00000001878C555C-0x00000001878C57A8
		public static bool FindRay3AAB3(ref Ray3 ray, ref AAB3 box, out Ray3AAB3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BCAEC-0x00000001878BCB84
		public static bool TestRay3Box3(ref Ray3 ray, ref Box3 box) => default; // 0x00000001878C57A8-0x00000001878C5B70
		public static bool FindRay3Box3(ref Ray3 ray, ref Box3 box, out Ray3Box3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BCB84-0x00000001878BCC1C
		public static bool TestRay3Circle3(ref Ray3 ray, ref Circle3 circle) => default; // 0x00000001878C5B70-0x00000001878C5BD0
		public static bool FindRay3Circle3(ref Ray3 ray, ref Circle3 circle, out Ray3Circle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BCC1C-0x00000001878BCEA4
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C5C34-0x00000001878C5CAC
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane) => default; // 0x00000001878C5BD0-0x00000001878C5C34
		public static bool FindRay3Plane3(ref Ray3 ray, ref Plane3 plane, out Ray3Plane3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BCEA4-0x00000001878BD0A8
		public static bool TestRay3Polygon3(ref Ray3 ray, Polygon3 polygon) => default; // 0x00000001878C5CAC-0x00000001878C5D0C
		public static bool FindRay3Polygon3(ref Ray3 ray, Polygon3 polygon, out Ray3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BD0A8-0x00000001878BD300
		public static bool TestRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle) => default; // 0x00000001878C5D0C-0x00000001878C5D6C
		public static bool FindRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle, out Ray3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BD300-0x00000001878BD554
		public static bool TestRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere) => default; // 0x00000001878C5D6C-0x00000001878C5EB4
		public static bool FindRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere, out Ray3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BD554-0x00000001878BD920
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C6218-0x00000001878C65C8
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C5EB4-0x00000001878C5F78
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C5F78-0x00000001878C603C
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle) => default; // 0x00000001878C60FC-0x00000001878C6158
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001878C6158-0x00000001878C6218
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001878C603C-0x00000001878C60FC
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BD9E4-0x00000001878BDE1C
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BD920-0x00000001878BD9E4
		public static bool FindRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BDE1C-0x00000001878BDEE0
		public static bool TestSegment3AAB3(ref Segment3 segment, ref AAB3 box) => default; // 0x00000001878C6E44-0x00000001878C7090
		public static bool FindSegment3AAB3(ref Segment3 segment, ref AAB3 box, out Segment3AAB3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BED4C-0x00000001878BEE0C
		public static bool TestSegment3Box3(ref Segment3 segment, ref Box3 box) => default; // 0x00000001878C7090-0x00000001878C7444
		public static bool FindSegment3Box3(ref Segment3 segment, ref Box3 box, out Segment3Box3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BEE0C-0x00000001878BEECC
		public static bool TestSegment3Circle3(ref Segment3 segment, ref Circle3 circle) => default; // 0x00000001878C7444-0x00000001878C74A4
		public static bool FindSegment3Circle3(ref Segment3 segment, ref Circle3 circle, out Segment3Circle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BEECC-0x00000001878BF15C
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C7500-0x00000001878C764C
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane) => default; // 0x00000001878C74A4-0x00000001878C7500
		public static bool FindSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out Segment3Plane3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BF15C-0x00000001878BF394
		public static bool TestSegment3Polygon3(ref Segment3 segment, Polygon3 polygon) => default; // 0x00000001878C764C-0x00000001878C76AC
		public static bool FindSegment3Polygon3(ref Segment3 segment, Polygon3 polygon, out Segment3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BF394-0x00000001878BF5E8
		public static bool TestSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle) => default; // 0x00000001878C76AC-0x00000001878C770C
		public static bool FindSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle, out Segment3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BF5E8-0x00000001878BF848
		public static bool TestSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere) => default; // 0x00000001878C770C-0x00000001878C7880
		public static bool FindSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere, out Segment3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BF848-0x00000001878BFCB4
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C7B88-0x00000001878C7F30
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C7AC4-0x00000001878C7B88
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C7940-0x00000001878C7A04
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle) => default; // 0x00000001878C7F30-0x00000001878C7F8C
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001878C7A04-0x00000001878C7AC4
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001878C7880-0x00000001878C7940
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BFD78-0x00000001878C0200
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878C0200-0x00000001878C02C4
		public static bool FindSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878BFCB4-0x00000001878BFD78
		public static bool TestSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1) => default; // 0x0000000185F4CBB0-0x0000000185F4CC30
		public static bool FindSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1, out Sphere3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x00000001878C02C4-0x00000001878C0770
		private static void ProjectOntoAxis(ref Triangle3 triangle, ref Vector3 axis, out float fmin, out float fmax) {
			fmin = default;
			fmax = default;
		} // 0x00000001878C2168-0x00000001878C22CC
		private static void TrianglePlaneRelations(ref Triangle3 triangle, ref Plane3 plane, out float dist0, out float dist1, out float dist2, out int sign0, out int sign1, out int sign2, out int positive, out int negative, out int zero) {
			dist0 = default;
			dist1 = default;
			dist2 = default;
			sign0 = default;
			sign1 = default;
			sign2 = default;
			positive = default;
			negative = default;
			zero = default;
		} // 0x00000001878C9424-0x00000001878C9580
		private static bool TrianglePlaneRelationsQuick(ref Triangle3 triangle, ref Plane3 plane) => default; // 0x00000001878C9370-0x00000001878C9424
		private static bool IntersectsSegment(ref Plane3 plane, ref Triangle3 triangle, ref Vector3 end0, ref Vector3 end1, bool grazing, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878C1B8C-0x00000001878C203C
		private static int QueryToLine(ref Vector2 test, ref Vector2 vec0, ref Vector2 vec1) => default; // 0x00000001878C22CC-0x00000001878C2320
		private static int QueryToTriangle(ref Vector2 test, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x00000001878C2320-0x00000001878C23FC
		private static bool ContainsPoint(ref Triangle3 triangle, ref Plane3 plane, ref Vector3 point, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878B7A3C-0x00000001878B7D7C
		private static bool GetCoplanarIntersection(ref Plane3 plane, ref Triangle3 tri0, ref Triangle3 tri1, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001878C1308-0x00000001878C1920
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001878C81D8-0x00000001878C908C
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1) => default; // 0x00000001878C908C-0x00000001878C90E8
		public static bool FindTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out Triangle3Triangle3Intr info, bool reportCoplanarIntersections = false /* Metadata: 0x0207BFDF */) {
			info = default;
			return default;
		} // 0x00000001878C08B8-0x00000001878C11B0
		public static int FindSegment1Segment1(float seg0Start, float seg0End, float seg1Start, float seg1End, out float w0, out float w1) {
			w0 = default;
			w1 = default;
			return default;
		} // 0x00000001878BDEE0-0x00000001878BDFF4
	}

	public struct Circle2Circle2Intr // TypeDefIndex: 55838
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2AAB2Intr // TypeDefIndex: 55839
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2Box2Intr // TypeDefIndex: 55840
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2Circle2Intr // TypeDefIndex: 55841
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Line2ConvexPolygon2Intr // TypeDefIndex: 55842
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Line2Line2Intr // TypeDefIndex: 55843
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Ray2Intr // TypeDefIndex: 55844
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Segment2Intr // TypeDefIndex: 55845
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Triangle2Intr // TypeDefIndex: 55846
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2AAB2Intr // TypeDefIndex: 55847
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2Box2Intr // TypeDefIndex: 55848
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2Circle2Intr // TypeDefIndex: 55849
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Ray2ConvexPolygon2Intr // TypeDefIndex: 55850
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Ray2Polygon2Intr // TypeDefIndex: 55851
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Ray2Ray2Intr // TypeDefIndex: 55852
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Ray2Segment2Intr // TypeDefIndex: 55853
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Ray2Triangle2Intr // TypeDefIndex: 55854
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2AAB2Intr // TypeDefIndex: 55855
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2Box2Intr // TypeDefIndex: 55856
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2Circle2Intr // TypeDefIndex: 55857
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Segment2ConvexPolygon2Intr // TypeDefIndex: 55858
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Segment2Segment2Intr // TypeDefIndex: 55859
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Segment2Triangle2Intr // TypeDefIndex: 55860
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Triangle2Triangle2Intr // TypeDefIndex: 55861
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
		public Vector2 this[int i] { get => default; internal set {} } // 0x00000001878CF58C-0x00000001878CF608 0x00000001878CF608-0x00000001878CF644
	}

	internal struct Float6 // TypeDefIndex: 55862
	{
		// Fields
		private float _0; // 0x00
		private float _1; // 0x04
		private float _2; // 0x08
		private float _3; // 0x0C
		private float _4; // 0x10
		private float _5; // 0x14
	
		// Properties
		public float this[int i] { get => default; set {} } // 0x00000001878C9C1C-0x00000001878C9C60 0x00000001878C9C60-0x00000001878C9CB8
	}

	public struct Line3AAB3Intr // TypeDefIndex: 55863
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Line3Box3Intr // TypeDefIndex: 55864
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Line3Circle3Intr // TypeDefIndex: 55865
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Plane3Intr // TypeDefIndex: 55866
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float LineParameter; // 0x10
	}

	public struct Line3Polygon3Intr // TypeDefIndex: 55867
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Rectangle3Intr // TypeDefIndex: 55868
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Sphere3Intr // TypeDefIndex: 55869
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float LineParameter0; // 0x20
		public float LineParameter1; // 0x24
	}

	public struct Line3Triangle3Intr // TypeDefIndex: 55870
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float LineParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public struct Plane3Plane3Intr // TypeDefIndex: 55871
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Line3 Line; // 0x04
	}

	public struct Plane3Sphere3Intr // TypeDefIndex: 55872
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Circle3 Circle; // 0x04
	}

	public struct Plane3Triangle3Intr // TypeDefIndex: 55873
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public Vector3 Point2; // 0x20
	}

	public struct Ray3AAB3Intr // TypeDefIndex: 55874
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Ray3Box3Intr // TypeDefIndex: 55875
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Ray3Circle3Intr // TypeDefIndex: 55876
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Plane3Intr // TypeDefIndex: 55877
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float RayParameter; // 0x10
	}

	public struct Ray3Polygon3Intr // TypeDefIndex: 55878
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Rectangle3Intr // TypeDefIndex: 55879
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Sphere3Intr // TypeDefIndex: 55880
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float RayParameter0; // 0x20
		public float RayParameter1; // 0x24
	}

	public struct Ray3Triangle3Intr // TypeDefIndex: 55881
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float RayParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public struct Segment3AAB3Intr // TypeDefIndex: 55882
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Segment3Box3Intr // TypeDefIndex: 55883
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Segment3Circle3Intr // TypeDefIndex: 55884
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Plane3Intr // TypeDefIndex: 55885
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float SegmentParameter; // 0x10
	}

	public struct Segment3Polygon3Intr // TypeDefIndex: 55886
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Rectangle3Intr // TypeDefIndex: 55887
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Sphere3Intr // TypeDefIndex: 55888
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float SegmentParameter0; // 0x20
		public float SegmentParameter1; // 0x24
	}

	public struct Segment3Triangle3Intr // TypeDefIndex: 55889
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float SegmentParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public enum Sphere3Sphere3IntrTypes // TypeDefIndex: 55890
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

	public struct Sphere3Sphere3Intr // TypeDefIndex: 55891
	{
		// Fields
		public Sphere3Sphere3IntrTypes IntersectionType; // 0x00
		public Circle3 Circle; // 0x04
		public Vector3 ContactPoint; // 0x38
	}

	public struct Triangle3Triangle3Intr // TypeDefIndex: 55892
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
		public Vector3 this[int i] { get => default; internal set {} } // 0x00000001878CF644-0x00000001878CF6D4 0x00000001878CF6D4-0x00000001878CF760
	}

	public enum IntersectionTypes // TypeDefIndex: 55893
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

	public interface ILogger // TypeDefIndex: 55894
	{
		// Methods
		void LogInfo(object value);
		void LogWarning(object value);
		void LogError(object value);
	}

	public class Logger // TypeDefIndex: 55895
	{
		// Fields
		private static ILogger _instance; // 0x00
	
		// Constructors
		static Logger() {} // 0x00000001878CA04C-0x00000001878CA0BC
		public Logger() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void LogInfo(object value) {} // 0x00000001878C9E58-0x00000001878C9F0C
		public static void LogWarning(object value) {} // 0x00000001878C9F0C-0x00000001878C9FC4
		public static void LogError(object value) {} // 0x00000001878C9DA0-0x00000001878C9E58
		public static void SetLogger(ILogger logger) {} // 0x00000001878C9FC4-0x00000001878CA04C
	}

	public class DefaultLogger : ILogger // TypeDefIndex: 55896
	{
		// Constructors
		public DefaultLogger() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void LogInfo(object value) {} // 0x00000001878C9B84-0x00000001878C9BD0
		public void LogWarning(object value) {} // 0x00000001878C9BD0-0x00000001878C9C1C
		public void LogError(object value) {} // 0x00000001878C9B38-0x00000001878C9B84
	}

	public class EmptyLogger : ILogger // TypeDefIndex: 55897
	{
		// Constructors
		public EmptyLogger() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void LogInfo(object value) {} // 0x0000000185492010-0x0000000185492020
		public void LogWarning(object value) {} // 0x0000000185492010-0x0000000185492020
		public void LogError(object value) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class Mathfex // TypeDefIndex: 55898
	{
		// Fields
		public const float ZeroTolerance = 1E-05f; // Metadata: 0x0207BFF9
		public const float NegativeZeroTolerance = -1E-05f; // Metadata: 0x0207BFFD
		public const float ZeroToleranceSqr = 9.9999994E-11f; // Metadata: 0x0207C001
		public const float Pi = 3.1415927f; // Metadata: 0x0207C005
		public const float HalfPi = 1.5707964f; // Metadata: 0x0207C009
		public const float TwoPi = 6.2831855f; // Metadata: 0x0207C00D
	
		// Methods
		public static float EvalSquared(float x) => default; // 0x0000000185FB2920-0x0000000185FB2930
		public static float EvalInvSquared(float x) => default; // 0x0000000185FB2AC0-0x0000000185FB2AE0
		public static float EvalCubic(float x) => default; // 0x0000000185FB38F0-0x0000000185FB3900
		public static float EvalInvCubic(float x) => default; // 0x0000000185FB3960-0x0000000185FB3970
		public static float EvalQuadratic(float x, float a, float b, float c) => default; // 0x0000000185FB3970-0x0000000185FB3990
		public static float EvalSigmoid(float x) => default; // 0x0000000185FB3990-0x0000000185FB39B0
		public static float EvalOverlappedStep(float x, float overlap, int objectIndex, int objectCount) => default; // 0x00000001878CA4BC-0x00000001878CA50C
		public static float EvalSmoothOverlappedStep(float x, float overlap, int objectIndex, int objectCount) => default; // 0x00000001878CA50C-0x00000001878CA574
		public static float EvalGaussian(float x, float a, float b, float c) => default; // 0x00000001878CA480-0x00000001878CA4BC
		public static float EvalGaussian2D(float x, float y, float x0, float y0, float A, float a, float b, float c) => default; // 0x0000000185FB3900-0x0000000185FB3960
		public static float Lerp(float value0, float value1, float factor) => default; // 0x00000001878CA624-0x00000001878CA654
		public static float LerpUnclamped(float value0, float value1, float factor) => default; // 0x0000000185FB39B0-0x0000000185FB39C0
		public static float SigmoidInterp(float value0, float value1, float factor) => default; // 0x00000001878CA678-0x00000001878CA6C4
		public static float SinInterp(float value0, float value1, float factor) => default; // 0x00000001878CA6C4-0x00000001878CA720
		public static float CosInterp(float value0, float value1, float factor) => default; // 0x00000001878CA3A4-0x00000001878CA418
		public static float WobbleInterp(float value0, float value1, float factor) => default; // 0x00000001878CA720-0x00000001878CA804
		public static float CurveInterp(float value0, float value1, float factor, AnimationCurve curve) => default; // 0x00000001878CA418-0x00000001878CA480
		public static float FuncInterp(float value0, float value1, float factor, Func<float, float> func) => default; // 0x00000001878CA574-0x00000001878CA5F4
		public static float InvSqrt(float value) => default; // 0x00000001878CA5F4-0x00000001878CA624
		public static bool Near(float value0, float value1, float epsilon = 1E-05f /* Metadata: 0x0207BFF1 */) => default; // 0x00000001878CA664-0x00000001878CA678
		public static bool NearZero(float value, float epsilon = 1E-05f /* Metadata: 0x0207BFF5 */) => default; // 0x00000001878CA654-0x00000001878CA664
		public static Vector2 CartesianToPolar(Vector2 cartesianCoordinates) => default; // 0x00000001878CA1A4-0x00000001878CA288
		public static Vector2 PolarToCartesian(Vector2 polarCoordinates) => default; // 0x0000000185FB39C0-0x0000000185FB3A10
		public static Vector3 CartesianToSpherical(Vector3 cartesianCoordinates) => default; // 0x00000001878CA288-0x00000001878CA3A4
		public static Vector3 SphericalToCartesian(Vector3 sphericalCoordinates) => default; // 0x0000000185FB3A10-0x0000000185FB3AB0
		public static Vector3 CartesianToCylindrical(Vector3 cartesianCoordinates) => default; // 0x00000001878CA0BC-0x00000001878CA1A4
		public static Vector3 CylindricalToCartesian(Vector3 cylindricalCoordinates) => default; // 0x0000000185FB38A0-0x0000000185FB38F0
	}

	public static class Matrix4x4ex // TypeDefIndex: 55899
	{
		// Fields
		public static readonly Matrix4x4 Identity; // 0x00
	
		// Constructors
		static Matrix4x4ex() {} // 0x00000001878CD124-0x00000001878CD1AC
	
		// Methods
		public static void RotationMatrixToQuaternion(ref Matrix4x4 matrix, out Quaternion quaternion) {
			quaternion = default;
		} // 0x00000001878CD05C-0x00000001878CD124
		public static void QuaternionToRotationMatrix(Quaternion quaternion, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB5010-0x0000000185FB5190
		public static void QuaternionToRotationMatrix(ref Quaternion quaternion, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB5190-0x0000000185FB5310
		public static void CreateTranslation(Vector3 position, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB4980-0x0000000185FB49C0
		public static void CreateTranslation(ref Vector3 position, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB4940-0x0000000185FB4980
		public static void CreateScale(Vector3 scale, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB3FC0-0x0000000185FB4000
		public static void CreateScale(ref Vector3 scale, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB4000-0x0000000185FB4040
		public static void CreateScale(float scale, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB4040-0x0000000185FB4080
		public static void CreateRotationEuler(float eulerX, float eulerY, float eulerZ, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x00000001878CAC98-0x00000001878CAD28
		public static void CreateRotationEuler(Vector3 eulerAngles, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x00000001878CAD9C-0x00000001878CAE10
		public static void CreateRotationEuler(ref Vector3 eulerAngles, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x00000001878CAD28-0x00000001878CAD9C
		public static void CreateRotationX(float angleInDegrees, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB3DC0-0x0000000185FB3E50
		public static void CreateRotationY(float angleInDegrees, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB3E50-0x0000000185FB3EE0
		public static void CreateRotationZ(float angleInDegrees, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB3EE0-0x0000000185FB3F70
		public static void CreateRotationAngleAxis(float angleInDegrees, Vector3 rotationAxis, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x00000001878CAB14-0x00000001878CAC98
		public static void CreateRotationAngleUnitAxis(float angleInDegrees, Vector3 normalizedAxis, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185FB3C60-0x0000000185FB3DC0
		public static void CreateRotation(Vector3 rotationOrigin, Quaternion rotation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CB13C-0x00000001878CB238
		public static void CreateRotation(ref Vector3 rotationOrigin, ref Quaternion rotation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CB040-0x00000001878CB13C
		public static void Transpose(ref Matrix4x4 matrix) {} // 0x0000000185FB5310-0x0000000185FB5380
		public static void Transpose(ref Matrix4x4 matrix, out Matrix4x4 transpose) {
			transpose = default;
		} // 0x0000000185FB5380-0x0000000185FB53E0
		public static float CalcDeterminant(ref Matrix4x4 matrix) => default; // 0x0000000185FB3AB0-0x0000000185FB3C00
		public static void Inverse(ref Matrix4x4 matrix, float epsilon = 1E-05f /* Metadata: 0x0207C011 */) {} // 0x00000001878CC260-0x00000001878CC88C
		public static void Inverse(ref Matrix4x4 matrix, out Matrix4x4 inverse, float epsilon = 1E-05f /* Metadata: 0x0207C015 */) {
			inverse = default;
		} // 0x00000001878CBC88-0x00000001878CC260
		public static void CopyMatrix(ref Matrix4x4 source, out Matrix4x4 destination) {
			destination = default;
		} // 0x0000000185FB3C00-0x0000000185FB3C60
		public static void Multiply(ref Matrix4x4 matrix0, ref Matrix4x4 matrix1, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB4B90-0x0000000185FB4F30
		public static void MultiplyRight(ref Matrix4x4 matrix0, ref Matrix4x4 matrix1) {} // 0x00000001878CCC74-0x00000001878CD05C
		public static void MultiplyLeft(ref Matrix4x4 matrix1, ref Matrix4x4 matrix0) {} // 0x00000001878CC88C-0x00000001878CCC74
		public static void Multiply(ref Matrix4x4 matrix, float scalar) {} // 0x0000000185FB49C0-0x0000000185FB4A90
		public static void Multiply(ref Matrix4x4 matrix, float scalar, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB4F30-0x0000000185FB5010
		public static Vector4 Multiply(ref Matrix4x4 matrix, Vector4 vector) => default; // 0x0000000185FB4A90-0x0000000185FB4B90
		public static Vector4 Multiply(ref Matrix4x4 matrix, ref Vector4 vector) => default; // 0x0000000185FB4A90-0x0000000185FB4B90
		public static void CreateSRT(Vector3 scaling, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CB674-0x00000001878CB774
		public static void CreateSRT(ref Vector3 scaling, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CB574-0x00000001878CB674
		public static void CreateSRT(float scaling, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CBAB0-0x00000001878CBB9C
		public static void CreateSRT(float scaling, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CBB9C-0x00000001878CBC88
		public static void CreateSRT(Vector3 scaling, Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CB908-0x00000001878CBAB0
		public static void CreateSRT(ref Vector3 scaling, ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CB3CC-0x00000001878CB574
		public static void CreateSRT(float scaling, Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CB238-0x00000001878CB3CC
		public static void CreateSRT(float scaling, ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CB774-0x00000001878CB908
		public static void CreateRT(Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CA91C-0x00000001878CA98C
		public static void CreateRT(ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CA98C-0x00000001878CA9FC
		public static void CreateRT(Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CA804-0x00000001878CA91C
		public static void CreateRT(ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001878CA9FC-0x00000001878CAB14
		public static void CreateST(Vector3 scaling, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB3F70-0x0000000185FB3FC0
		public static void CreateST(ref Vector3 scaling, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB3F70-0x0000000185FB3FC0
		public static void CreateRotationFromColumns(Vector3 column0, Vector3 column1, Vector3 column2, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x00000001878CAF28-0x00000001878CB040
		public static void CreateRotationFromColumns(ref Vector3 column0, ref Vector3 column1, ref Vector3 column2, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x00000001878CAE10-0x00000001878CAF28
		public static void CreateShadowDirectional(Plane3 shadowPlane, Vector3 dirLightOppositeDirection, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB4080-0x0000000185FB41E0
		public static void CreateShadowDirectional(ref Plane3 shadowPlane, ref Vector3 dirLightOppositeDirection, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB41E0-0x0000000185FB4340
		public static void CreateShadowPoint(Plane3 shadowPlane, Vector3 pointLightPosition, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB4340-0x0000000185FB44A0
		public static void CreateShadowPoint(ref Plane3 shadowPlane, ref Vector3 pointLightPosition, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB44A0-0x0000000185FB4600
		public static void CreateShadow(Plane3 shadowPlane, Vector4 lightData, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB47A0-0x0000000185FB4940
		public static void CreateShadow(ref Plane3 shadowPlane, ref Vector4 lightData, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185FB4600-0x0000000185FB47A0
	}

	public static class Quaternionex // TypeDefIndex: 55900
	{
		// Methods
		public static Quaternion DeltaTo(Quaternion quat, Quaternion target) => default; // 0x00000001878CD1AC-0x00000001878CD214
		public static string ToStringEx(Quaternion quat) => default; // 0x00000001878CD214-0x00000001878CD330
	}

	public class Rand // TypeDefIndex: 55901
	{
		// Fields
		private const int a = 5; // Metadata: 0x0207C039
		private const int b = 14; // Metadata: 0x0207C03A
		private const int c = 1; // Metadata: 0x0207C03B
		private const uint DefaultY = 273326509; // Metadata: 0x0207C03C
		private const uint DefaultZ = 3579807591; // Metadata: 0x0207C040
		private const uint DefaultW = 842502087; // Metadata: 0x0207C045
		private const uint PositiveMask = 2147483647; // Metadata: 0x0207C04A
		private const uint BoolModuloMask = 1; // Metadata: 0x0207C04F
		private const uint ByteModuloMask = 255; // Metadata: 0x0207C050
		private const double One_div_uintMaxValuePlusOne = 2.3283064365386963E-10; // Metadata: 0x0207C052
		private const double TwoPi = 6.283185307179586; // Metadata: 0x0207C05A
		private static Rand _seedGenerator; // 0x00
		private uint _x; // 0x10
		private uint _y; // 0x14
		private uint _z; // 0x18
		private uint _w; // 0x1C
		public static Rand Instance; // 0x08
	
		// Constructors
		static Rand() {} // 0x00000001878CE36C-0x00000001878CE43C
		public Rand() {} // 0x00000001878CE43C-0x00000001878CE4B4
		public Rand(int seed) {} // 0x0000000185FB5560-0x0000000185FB5580
	
		// Methods
		public void ResetSeed(int seed) {} // 0x0000000185FB5560-0x0000000185FB5580
		public void GetState(out uint x, out uint y, out uint z, out uint w) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FB53E0-0x0000000185FB5400
		public void SetState(uint x, uint y, uint z, uint w) {} // 0x0000000185FB5580-0x0000000185FB55A0
		public int NextInt() => default; // 0x0000000185FB5400-0x0000000185FB5430
		public int NextInt(int max) => default; // 0x0000000185FB54C0-0x0000000185FB5520
		public int NextInt(int min, int max) => default; // 0x00000001878CDB08-0x00000001878CDBE8
		public int NextIntInclusive(int min, int max) => default; // 0x00000001878CDAFC-0x00000001878CDB08
		public int NextPositiveInt() => default; // 0x0000000185FB5520-0x0000000185FB5560
		public uint NextUInt() => default; // 0x0000000185FB5400-0x0000000185FB5430
		public double NextDouble() => default; // 0x0000000185FB5430-0x0000000185FB5470
		public double NextDouble(double min, double max) => default; // 0x00000001878CD978-0x00000001878CDA38
		public float NextFloat() => default; // 0x0000000185FB5470-0x0000000185FB54C0
		public float NextFloat(float min, float max) => default; // 0x00000001878CDA38-0x00000001878CDAFC
		public bool NextBool() => default; // 0x00000001878CD944-0x00000001878CD978
		public byte NextByte() => default; // 0x0000000185FB5400-0x0000000185FB5430
		public UnityEngine.Color RandomColorOpaque() => default; // 0x00000001878CE150-0x00000001878CE1BC
		public UnityEngine.Color RandomColorTransparent() => default; // 0x00000001878CE1BC-0x00000001878CE240
		public Color32 RandomColor32Opaque() => default; // 0x00000001878CE0BC-0x00000001878CE0FC
		public Color32 RandomColor32Transparent() => default; // 0x00000001878CE0FC-0x00000001878CE150
		public float RandomAngleRadians() => default; // 0x00000001878CE0A4-0x00000001878CE0BC
		public float RandomAngleDegrees() => default; // 0x00000001878CE08C-0x00000001878CE0A4
		public Vector2 InSquare(float side = 1f /* Metadata: 0x0207C019 */) => default; // 0x00000001878CD5D8-0x00000001878CD64C
		public Vector2 OnSquare(float side = 1f /* Metadata: 0x0207C01D */) => default; // 0x00000001878CDF54-0x00000001878CE08C
		public Vector3 InCube(float side = 1f /* Metadata: 0x0207C021 */) => default; // 0x00000001878CD448-0x00000001878CD4F8
		public Vector3 OnCube(float side = 1f /* Metadata: 0x0207C025 */) => default; // 0x00000001878CDC44-0x00000001878CDE88
		public Vector2 InCircle(float radius = 1f /* Metadata: 0x0207C029 */) => default; // 0x00000001878CD3D0-0x00000001878CD448
		public Vector2 InCircle(float radiusMin, float radiusMax) => default; // 0x00000001878CD330-0x00000001878CD3D0
		public Vector2 OnCircle(float radius = 1f /* Metadata: 0x0207C02D */) => default; // 0x00000001878CDBE8-0x00000001878CDC44
		public Vector3 InSphere(float radius = 1f /* Metadata: 0x0207C031 */) => default; // 0x00000001878CD4F8-0x00000001878CD5D8
		public Vector3 OnSphere(float radius = 1f /* Metadata: 0x0207C035 */) => default; // 0x00000001878CDE88-0x00000001878CDF54
		public Vector3 InTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001878CD7C8-0x00000001878CD944
		public Vector3 InTriangle(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001878CD64C-0x00000001878CD7C8
		public Quaternion RandomRotation() => default; // 0x00000001878CE240-0x00000001878CE36C
	}

	public static class Vector2ex // TypeDefIndex: 55903
	{
		// Fields
		public static readonly Vector2 Zero; // 0x00
		public static readonly Vector2 One; // 0x08
		public static readonly Vector2 UnitX; // 0x10
		public static readonly Vector2 UnitY; // 0x18
		public static readonly Vector2 PositiveInfinity; // 0x20
		public static readonly Vector2 NegativeInfinity; // 0x28
	
		// Nested types
		internal class Information // TypeDefIndex: 55902
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
			public Information() {} // 0x00000001878CF8C0-0x00000001878CFEFC
		}
	
		// Constructors
		static Vector2ex() {} // 0x00000001878C9CB8-0x00000001878C9D2C
	
		// Methods
		internal static Information GetInformation(IList<Vector2> points, float epsilon) => default; // 0x0000000185FB5670-0x0000000185FB56B0
		public static float Length(Vector2 vector) => default; // 0x0000000185FB5650-0x0000000185FB5670
		public static float LengthSqr(Vector2 vector) => default; // 0x0000000185FB26D0-0x0000000185FB2700
		public static float DotPerp(Vector2 vector, Vector2 value) => default; // 0x0000000185FB55A0-0x0000000185FB55C0
		public static float DotPerp(Vector2 vector, ref Vector2 value) => default; // 0x0000000185FB55C0-0x0000000185FB55E0
		public static float DotPerp(ref Vector2 vector, ref Vector2 value) => default; // 0x0000000185FB5600-0x0000000185FB5630
		public static float Dot(Vector2 vector, Vector2 value) => default; // 0x0000000185FB55E0-0x0000000185FB5600
		public static float Dot(Vector2 vector, ref Vector2 value) => default; // 0x0000000185FB5630-0x0000000185FB5650
		public static float Dot(ref Vector2 vector, ref Vector2 value) => default; // 0x0000000185FB56B0-0x0000000185FB56E0
		public static Vector2 Perp(Vector2 vector) => default; // 0x00000001878CF760-0x00000001878CF814
		public static float AngleDeg(Vector2 vector, Vector2 target) => default; // 0x00000001878CF814-0x00000001878CF8C0
		public static float AngleRad(Vector2 vector, Vector2 target) => default; // 0x00000001878CFF74-0x00000001878CFFE4
		public static float Normalize(ref Vector2 vector, float epsilon = 1E-05f /* Metadata: 0x0207C062 */) => default; // 0x00000001878CFFE4-0x00000001878D0058
		public static float SetLength(ref Vector2 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x0207C066 */) => default; // 0x00000001878CFEFC-0x00000001878CFF74
		public static float GrowLength(ref Vector2 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x0207C06A */) => default; // 0x0000000185FB56E0-0x0000000185FB56F0
		public static Vector2 Replicate(float value) => default; // 0x0000000185FB29F0-0x0000000185FB2A20
		public static Vector3 ToVector3XY(Vector2 vector) => default; // 0x0000000185FB2A40-0x0000000185FB2A70
		public static Vector3 ToVector3XZ(Vector2 vector) => default; // 0x0000000185FB56F0-0x0000000185FB5720
		public static Vector3 ToVector3YZ(Vector2 vector) => default; // 0x00000001878D0058-0x00000001878D00B4
		public static string ToStringEx(Vector2 vector) => default; // 0x00000001878D00B4-0x00000001878D0164
	}

	public enum ProjectionPlanes // TypeDefIndex: 55904
	{
		XY = 0,
		XZ = 1,
		YZ = 2
	}

	public static class Vector3ex // TypeDefIndex: 55906
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
		internal class Information // TypeDefIndex: 55905
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
			public Information() {} // 0x00000001878D03FC-0x00000001878D0FB8
		}
	
		// Constructors
		static Vector3ex() {} // 0x00000001878C9D2C-0x00000001878C9DA0
	
		// Methods
		internal static Information GetInformation(IList<Vector3> points, float epsilon) => default; // 0x0000000185FB57E0-0x0000000185FB5820
		public static float Length(Vector3 vector) => default; // 0x0000000185FB57B0-0x0000000185FB57E0
		public static float LengthSqr(Vector3 vector) => default; // 0x0000000185FB5780-0x0000000185FB57B0
		public static float Dot(Vector3 vector, Vector3 value) => default; // 0x0000000185FB5780-0x0000000185FB57B0
		public static float Dot(Vector3 vector, ref Vector3 value) => default; // 0x0000000185FB5780-0x0000000185FB57B0
		public static float Dot(ref Vector3 vector, ref Vector3 value) => default; // 0x00000001878D0164-0x00000001878D0220
		public static float AngleDeg(Vector3 vector, Vector3 target) => default; // 0x00000001878D0220-0x00000001878D02D4
		public static float AngleRad(Vector3 vector, Vector3 target) => default; // 0x00000001878D122C-0x00000001878D138C
		public static float SignedAngleDeg(Vector3 vector, Vector3 target, Vector3 normal) => default; // 0x00000001878D138C-0x00000001878D14E4
		public static float SignedAngleRad(Vector3 vector, Vector3 target, Vector3 normal) => default; // 0x0000000185FB5720-0x0000000185FB5780
		public static Vector3 Cross(Vector3 vector, Vector3 value) => default; // 0x0000000185FB5720-0x0000000185FB5780
		public static Vector3 Cross(Vector3 vector, ref Vector3 value) => default; // 0x0000000185FB5720-0x0000000185FB5780
		public static Vector3 Cross(ref Vector3 vector, ref Vector3 value) => default; // 0x00000001878D164C-0x00000001878D1704
		public static Vector3 UnitCross(Vector3 vector, Vector3 value) => default; // 0x00000001878D158C-0x00000001878D164C
		public static Vector3 UnitCross(Vector3 vector, ref Vector3 value) => default; // 0x00000001878D1704-0x00000001878D17C4
		public static Vector3 UnitCross(ref Vector3 vector, ref Vector3 value) => default; // 0x00000001878D108C-0x00000001878D1118
		public static float Normalize(ref Vector3 vector, float epsilon = 1E-05f /* Metadata: 0x0207C071 */) => default; // 0x00000001878D119C-0x00000001878D122C
		public static float SetLength(ref Vector3 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x0207C075 */) => default; // 0x00000001878D0FF8-0x00000001878D108C
		public static float GrowLength(ref Vector3 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x0207C079 */) => default; // 0x0000000185FB5820-0x0000000185FB5840
		public static Vector3 Replicate(float value) => default; // 0x00000001878D02D4-0x00000001878D03FC
		public static void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, ref Vector3 w) {
			u = default;
			v = default;
		} // 0x00000001878D1118-0x00000001878D119C
		public static bool SameDirection(Vector3 value0, Vector3 value1) => default; // 0x0000000185FB29D0-0x0000000185FB29F0
		public static Vector2 ToVector2XY(Vector3 vector) => default; // 0x0000000185FB2A20-0x0000000185FB2A40
		public static Vector2 ToVector2XZ(Vector3 vector) => default; // 0x0000000185FB5840-0x0000000185FB5860
		public static Vector2 ToVector2YZ(Vector3 vector) => default; // 0x00000001878D1564-0x00000001878D158C
		public static Vector2 ToVector2(Vector3 vector, ProjectionPlanes projectionPlane) => default; // 0x00000001878D0FB8-0x00000001878D0FF8
		public static ProjectionPlanes GetProjectionPlane(Vector3 vector) => default; // 0x00000001878D14E4-0x00000001878D1564
		public static string ToStringEx(Vector3 vector) => default; // 0x000000018496CFA0-0x000000018496D0C0
	}

	public struct BrentsRoot // TypeDefIndex: 55907
	{
		// Fields
		public float X; // 0x00
		public int Iterations; // 0x04
		public bool ExceededMaxIterations; // 0x08
	}

	public static class RootFinder // TypeDefIndex: 55909
	{
		// Fields
		private const float third = 0.33333334f; // Metadata: 0x0207C0AD
		private const float twentySeventh = 0.037037037f; // Metadata: 0x0207C0B1
		private static float sqrt3; // 0x00
	
		// Nested types
		private class PolyRootFinder // TypeDefIndex: 55908
		{
			// Fields
			private int _count; // 0x10
			private int _maxRoot; // 0x14
			private float[] _roots; // 0x18
			private float _epsilon; // 0x20
	
			// Properties
			public float[] Roots { get => default; } // 0x00000001878CE4B4-0x00000001878CE88C 
	
			// Constructors
			public PolyRootFinder() {} // Dummy constructor
			public PolyRootFinder(float epsilon) {} // 0x00000001878CEC48-0x00000001878CEC74
	
			// Methods
			public bool Bisection(Polynomial poly, float xMin, float xMax, int digits, out float root) {
				root = default;
				return default;
			} // 0x00000001878CEF0C-0x00000001878CF094
			public bool Find(Polynomial poly, float xMin, float xMax, int digits) => default; // 0x00000001878CE88C-0x00000001878CEC48
		}
	
		// Constructors
		static RootFinder() {} // 0x00000001878DB8B4-0x00000001878DBCE4
	
		// Methods
		public static bool BrentsMethod(Func<float, float> function, float x0, float x1, out BrentsRoot root, int maxIterations = 128 /* Metadata: 0x0207C07D */, float negativeTolerance = -1E-05f /* Metadata: 0x0207C07F */, float positiveTolerance = 1E-05f /* Metadata: 0x0207C083 */, float stepTolerance = 1E-05f /* Metadata: 0x0207C087 */, float segmentTolerance = 1E-05f /* Metadata: 0x0207C08B */) {
			root = default;
			return default;
		} // 0x00000001878CF094-0x00000001878CF548
		public static bool Linear(float c0, float c1, out float root, float epsilon = 1E-05f /* Metadata: 0x0207C08F */) {
			root = default;
			return default;
		} // 0x00000001878CEC74-0x00000001878CED40
		public static bool Quadratic(float c0, float c1, float c2, out QuadraticRoots roots, float epsilon = 1E-05f /* Metadata: 0x0207C093 */) {
			roots = default;
			return default;
		} // 0x00000001878CEE24-0x00000001878CEF0C
		public static bool Cubic(float c0, float c1, float c2, float c3, out CubicRoots roots, float epsilon = 1E-05f /* Metadata: 0x0207C097 */) {
			roots = default;
			return default;
		} // 0x00000001878CED40-0x00000001878CEE24
		public static bool Quartic(float c0, float c1, float c2, float c3, float c4, out QuarticRoots roots, float epsilon = 1E-05f /* Metadata: 0x0207C09B */) {
			roots = default;
			return default;
		} // 0x00000001878CF548-0x00000001878CF58C
		public static float PolynomialBound(Polynomial poly, float epsilon = 1E-05f /* Metadata: 0x0207C09F */) => default; // 0x0000000181377E40-0x0000000181377E50
		public static bool Polynomial(Polynomial poly, float xMin, float xMax, out float[] roots, int digits = 6 /* Metadata: 0x0207C0A3 */, float epsilon = 1E-05f /* Metadata: 0x0207C0A4 */) {
			roots = default;
			return default;
		} // 0x00000001878DBCE4-0x00000001878DBD48
		public static bool Polynomial(Polynomial poly, out float[] roots, int digits = 6 /* Metadata: 0x0207C0A8 */, float epsilon = 1E-05f /* Metadata: 0x0207C0A9 */) {
			roots = default;
			return default;
		} // 0x00000001878DB714-0x00000001878DB8B4
	}

	public class EigenData // TypeDefIndex: 55910
	{
		// Fields
		private int _size; // 0x10
		private float[] _diagonal; // 0x18
		private float[,] _matrix; // 0x20
	
		// Properties
		public int Size { get => default; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
	
		// Constructors
		public EigenData() {} // Dummy constructor
		internal EigenData(float[] diagonal, float[,] matrix) {} // 0x00000001878D6D94-0x00000001878D6DD0
	
		// Methods
		public float GetEigenvalue(int index) => default; // 0x00000001878B6074-0x00000001878B60A4
		public Vector2 GetEigenvector2(int index) => default; // 0x00000001878D6AF4-0x00000001878D6BAC
		public Vector3 GetEigenvector3(int index) => default; // 0x00000001878D6BAC-0x00000001878D6C7C
		public float[] GetEigenvector(int index) => default; // 0x00000001878D6C7C-0x00000001878D6D20
		public void GetEigenvector(int index, float[] out_eigenvector) {} // 0x00000001878D6D20-0x00000001878D6D94
	}

	public static class EigenDecomposition // TypeDefIndex: 55911
	{
		// Methods
		private static void Tridiagonal2(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation) {
			isRotation = default;
		} // 0x00000001878D772C-0x00000001878D7840
		private static void Tridiagonal3(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation) {
			isRotation = default;
		} // 0x00000001878D7840-0x00000001878D7BB4
		private static void TridiagonalN(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation) {
			isRotation = default;
		} // 0x00000001878D7BB4-0x00000001878D8240
		private static bool QLAlgorithm(float[] diagonal, float[] subdiagonal, float[,] matrix) => default; // 0x00000001878D710C-0x00000001878D757C
		private static void IncreasingSort(float[] diagonal, float[] subdiagonal, float[,] matrix, ref bool isRotation) {} // 0x00000001878D6FA8-0x00000001878D710C
		private static void DecreasingSort(float[] diagonal, float[] subdiagonal, float[,] matrix, ref bool isRotation) {} // 0x00000001878D6DD0-0x00000001878D6F38
		private static void GuaranteeRotation(float[,] matrix, bool isRotation) {} // 0x00000001878D6F38-0x00000001878D6FA8
		public static EigenData Solve(float[,] symmetricSquareMatrix, bool increasingSort) => default; // 0x00000001878D757C-0x00000001878D772C
	}

	public static class Integrator // TypeDefIndex: 55912
	{
		// Fields
		private const int _degree = 5; // Metadata: 0x0207C0B5
		private static float[] root; // 0x00
		private static float[] coeff; // 0x08
	
		// Constructors
		static Integrator() {} // 0x00000001878D86CC-0x00000001878D87B0
	
		// Methods
		public static float TrapezoidRule(Func<float, float> function, float a, float b, int sampleCount) => default; // 0x00000001878D85C8-0x00000001878D86CC
		public static float RombergIntegral(Func<float, float> function, float a, float b, int order) => default; // 0x00000001878D835C-0x00000001878D85C8
		public static float GaussianQuadrature(Func<float, float> function, float a, float b) => default; // 0x00000001878D8240-0x00000001878D835C
	}

	public static class LinearSystem // TypeDefIndex: 55913
	{
		// Methods
		public static bool Solve2(float[,] A, float[] B, out float[] X, float zeroTolerance = 1E-05f /* Metadata: 0x0207C0B6 */) {
			X = default;
			return default;
		} // 0x00000001878D9B28-0x00000001878D9D30
		public static bool Solve2(float[,] A, float[] B, out Vector2 X, float zeroTolerance = 1E-05f /* Metadata: 0x0207C0BA */) {
			X = default;
			return default;
		} // 0x00000001878D9D30-0x00000001878D9E04
		public static bool Solve3(float[,] A, float[] B, out float[] X, float zeroTolerance = 1E-05f /* Metadata: 0x0207C0BE */) {
			X = default;
			return default;
		} // 0x00000001878D9EE4-0x00000001878DA5F8
		public static bool Solve3(float[,] A, float[] B, out Vector3 X, float zeroTolerance = 1E-05f /* Metadata: 0x0207C0C2 */) {
			X = default;
			return default;
		} // 0x00000001878D9E04-0x00000001878D9EE4
		private static void SwapRows(float[,] matrix, int row0, int row1, int columnCount) {} // 0x00000001878DAD8C-0x00000001878DAE34
		public static bool Solve(float[,] A, float[] B, out float[] X) {
			X = default;
			return default;
		} // 0x00000001878DA8A0-0x00000001878DAD8C
		public static bool SolveTridiagonal(float[] A, float[] B, float[] C, float[] R, out float[] U) {
			U = default;
			return default;
		} // 0x00000001878DA5F8-0x00000001878DA8A0
		public static bool Inverse(float[,] A, out float[,] invA) {
			invA = default;
			return default;
		} // 0x00000001878D9660-0x00000001878D9B28
	}

	public delegate void OdeFunction(float t, float[] y, float[] F); // TypeDefIndex: 55914; 0x0000000183688650-0x0000000183688670

	public abstract class OdeSolver // TypeDefIndex: 55915
	{
		// Fields
		protected int _dim; // 0x10
		protected float _step; // 0x14
		protected OdeFunction _function; // 0x18
		protected float[] _FValue; // 0x20
	
		// Properties
		public virtual float Step { get; set; } // 0x0000000185FB2D80-0x0000000185FB2D90 0x0000000181A6E390-0x0000000181A6FA00
	
		// Constructors
		protected OdeSolver() {} // Dummy constructor
		public OdeSolver(int dim, float step, OdeFunction function) {} // 0x00000001878DB694-0x00000001878DB714
	
		// Methods
		public abstract void Update(float tIn, float[] yIn, ref float tOut, float[] yOut);
	}

	public class OdeEuler : OdeSolver // TypeDefIndex: 55916
	{
		// Constructors
		public OdeEuler() {} // Dummy constructor
		public OdeEuler(int dim, float step, OdeFunction function) {} // 0x00000001878DAEF8-0x00000001878DAF08
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut) {} // 0x00000001878DAE34-0x00000001878DAEF8
	}

	public class OdeMidpoint : OdeSolver // TypeDefIndex: 55917
	{
		// Fields
		private float _halfStep; // 0x28
		private float[] _yTemp; // 0x30
	
		// Properties
		public override float Step { get => default; set {} } // 0x0000000185FB2D80-0x0000000185FB2D90 0x0000000185FB5E80-0x0000000185FB5EA0
	
		// Constructors
		public OdeMidpoint() {} // Dummy constructor
		public OdeMidpoint(int dim, float step, OdeFunction function) {} // 0x00000001878DB1B8-0x00000001878DB24C
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut) {} // 0x00000001878DB058-0x00000001878DB1B8
	}

	public class OdeRungeKutta4 : OdeSolver // TypeDefIndex: 55918
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
		public override float Step { get => default; set {} } // 0x0000000185FB2D80-0x0000000185FB2D90 0x00000001878DB670-0x00000001878DB694
	
		// Constructors
		public OdeRungeKutta4() {} // Dummy constructor
		public OdeRungeKutta4(int dim, float step, OdeFunction function) {} // 0x00000001878DB560-0x00000001878DB670
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut) {} // 0x00000001878DB24C-0x00000001878DB560
	}

	public struct QuadraticRoots // TypeDefIndex: 55919
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public int RootCount; // 0x08
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x00000001878DDC24-0x00000001878DDC44 
	}

	public struct CubicRoots // TypeDefIndex: 55920
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public float X2; // 0x08
		public int RootCount; // 0x0C
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x00000001878D6ACC-0x00000001878D6AF4 
	}

	public struct QuarticRoots // TypeDefIndex: 55921
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public float X2; // 0x08
		public float X3; // 0x0C
		public int RootCount; // 0x10
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x00000001878DDC44-0x00000001878DDC78 
	}

	public struct AAB2 // TypeDefIndex: 55922
	{
		// Fields
		public Vector2 Min; // 0x00
		public Vector2 Max; // 0x08
	
		// Constructors
		public AAB2(ref Vector2 min, ref Vector2 max) {
			Min = default;
			Max = default;
		} // 0x0000000185FB5970-0x0000000185FB5990
		public AAB2(Vector2 min, Vector2 max) {
			Min = default;
			Max = default;
		} // 0x0000000183680100-0x0000000183680110
		public AAB2(float xMin, float xMax, float yMin, float yMax) {
			Min = default;
			Max = default;
		} // 0x0000000185FB5990-0x0000000185FB59B0
	
		// Methods
		public static implicit operator Rect(AAB2 value) => default; // 0x00000001878D1EAC-0x00000001878D1EF0
		public static implicit operator AAB2(Rect value) => default; // 0x0000000185FB59B0-0x0000000185FB59F0
		public static AAB2 CreateFromPoint(ref Vector2 point) => default; // 0x0000000185FB5940-0x0000000185FB5970
		public static AAB2 CreateFromPoint(Vector2 point) => default; // 0x0000000185FB5930-0x0000000185FB5940
		public static AAB2 CreateFromTwoPoints(ref Vector2 point0, ref Vector2 point1) => default; // 0x00000001878D1C88-0x00000001878D1CD4
		public static AAB2 CreateFromTwoPoints(Vector2 point0, Vector2 point1) => default; // 0x00000001878D1C4C-0x00000001878D1C88
		public static AAB2 CreateFromPoints(IEnumerable<Vector2> points) => default; // 0x00000001878D1A08-0x00000001878D1B40
		public static AAB2 CreateFromPoints(IList<Vector2> points) => default; // 0x00000001878D1B40-0x00000001878D1C4C
		public static AAB2 CreateFromPoints(Vector2[] points) => default; // 0x00000001878D194C-0x00000001878D1A08
		public void CalcCenterExtents(out Vector2 center, out Vector2 extents) {
			center = default;
			extents = default;
		} // 0x0000000185FB5880-0x0000000185FB58E0
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x0000000185FB58E0-0x0000000185FB5930
		public Vector2[] CalcVertices() => default; // 0x00000001878D17C4-0x00000001878D1884
		public void CalcVertices(Vector2[] array) {} // 0x00000001878D1884-0x00000001878D1914
		public float CalcArea() => default; // 0x0000000185FB5860-0x0000000185FB5880
		public float DistanceTo(Vector2 point) => default; // 0x00000001878D1CD4-0x00000001878D1CF4
		public Vector2 Project(Vector2 point) => default; // 0x00000001878D1DE4-0x00000001878D1E14
		public bool Contains(ref Vector2 point) => default; // 0x000000018406A1E0-0x000000018406A210
		public bool Contains(Vector2 point) => default; // 0x00000001878D1914-0x00000001878D194C
		public void Include(ref Vector2 point) {} // 0x00000001878D1DA4-0x00000001878D1DE4
		public void Include(Vector2 point) {} // 0x00000001878D1CF4-0x00000001878D1D3C
		public void Include(ref AAB2 box) {} // 0x00000001878D1D70-0x00000001878D1DA4
		public void Include(AAB2 box) {} // 0x00000001878D1D3C-0x00000001878D1D70
		public override string ToString() => default; // 0x00000001878D1E14-0x00000001878D1EAC
	}

	public struct Box2 // TypeDefIndex: 55923
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Axis0; // 0x08
		public Vector2 Axis1; // 0x10
		public Vector2 Extents; // 0x18
	
		// Constructors
		public Box2(ref Vector2 center, ref Vector2 axis0, ref Vector2 axis1, ref Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x0000000185FB5BA0-0x0000000185FB5BF0
		public Box2(Vector2 center, Vector2 axis0, Vector2 axis1, Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x0000000185FB5BF0-0x0000000185FB5C10
		public Box2(ref AAB2 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x00000001878D395C-0x00000001878D39F8
		public Box2(AAB2 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x00000001878D39F8-0x00000001878D3A94
	
		// Methods
		public static Box2 CreateFromPoints(IList<Vector2> points) => default; // 0x00000001878D2F18-0x00000001878D3294
		public Vector2 GetAxis(int index) => default; // 0x00000001878D32B4-0x00000001878D3338
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x00000001878D294C-0x00000001878D2A20
		public Vector2[] CalcVertices() => default; // 0x00000001878D2A20-0x00000001878D2BCC
		public void CalcVertices(Vector2[] array) {} // 0x00000001878D2BCC-0x00000001878D2D34
		public float CalcArea() => default; // 0x0000000185FB5B80-0x0000000185FB5BA0
		public float DistanceTo(Vector2 point) => default; // 0x00000001878D3294-0x00000001878D32B4
		public Vector2 Project(Vector2 point) => default; // 0x00000001878D37C0-0x00000001878D37F0
		public bool Contains(ref Vector2 point) => default; // 0x00000001878D2D34-0x00000001878D2E28
		public bool Contains(Vector2 point) => default; // 0x00000001878D2E28-0x00000001878D2F18
		public void Include(ref Box2 box) {} // 0x00000001878D3338-0x00000001878D37AC
		public void Include(Box2 box) {} // 0x00000001878D37AC-0x00000001878D37C0
		public override string ToString() => default; // 0x00000001878D37F0-0x00000001878D395C
	}

	public struct Circle2 // TypeDefIndex: 55924
	{
		// Fields
		public Vector2 Center; // 0x00
		public float Radius; // 0x08
	
		// Constructors
		public Circle2(ref Vector2 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x0000000185FB5DF0-0x0000000185FB5E00
		public Circle2(Vector2 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x0000000185FB5E00-0x0000000185FB5E10
	
		// Methods
		public static Circle2 CreateFromPointsAAB(IEnumerable<Vector2> points) => default; // 0x00000001878D60D0-0x00000001878D61E0
		public static Circle2 CreateFromPointsAAB(IList<Vector2> points) => default; // 0x00000001878D6008-0x00000001878D60D0
		public static Circle2 CreateFromPointsAverage(IEnumerable<Vector2> points) => default; // 0x00000001878D63B4-0x00000001878D66E8
		public static Circle2 CreateFromPointsAverage(IList<Vector2> points) => default; // 0x00000001878D61E0-0x00000001878D63B4
		public static bool CreateCircumscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle) {
			circle = default;
			return default;
		} // 0x00000001878D5DEC-0x00000001878D6008
		public static bool CreateInscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle) {
			circle = default;
			return default;
		} // 0x00000001878D66E8-0x00000001878D68F8
		public float CalcPerimeter() => default; // 0x0000000185FB5D10-0x0000000185FB5D20
		public float CalcArea() => default; // 0x0000000185FB5CF0-0x0000000185FB5D10
		public Vector2 Eval(float t) => default; // 0x0000000185FB5D20-0x0000000185FB5D80
		public Vector2 Eval(float t, float radius) => default; // 0x0000000185FB5D80-0x0000000185FB5DF0
		public float DistanceTo(Vector2 point) => default; // 0x00000001878D68F8-0x00000001878D6918
		public Vector2 Project(Vector2 point) => default; // 0x00000001878D6A14-0x00000001878D6A44
		public bool Contains(ref Vector2 point) => default; // 0x00000001878D5DA4-0x00000001878D5DEC
		public bool Contains(Vector2 point) => default; // 0x00000001878D5D58-0x00000001878D5DA4
		public void Include(ref Circle2 circle) {} // 0x00000001878D692C-0x00000001878D6A14
		public void Include(Circle2 circle) {} // 0x00000001878D6918-0x00000001878D692C
		public override string ToString() => default; // 0x00000001878D6A44-0x00000001878D6ACC
	}

	public struct Line2 // TypeDefIndex: 55925
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Line2(ref Vector2 center, ref Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000185FB5970-0x0000000185FB5990
		public Line2(Vector2 center, Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183680100-0x0000000183680110
	
		// Methods
		public static Line2 CreateFromTwoPoints(ref Vector2 p0, ref Vector2 p1) => default; // 0x00000001878D88C0-0x00000001878D892C
		public static Line2 CreateFromTwoPoints(Vector2 p0, Vector2 p1) => default; // 0x00000001878D8874-0x00000001878D88C0
		public static Line2 CreatePerpToLineTrhoughPoint(Line2 line, Vector2 point) => default; // 0x00000001878D8990-0x00000001878D8A14
		public static Line2 CreateBetweenAndEquidistantToPoints(Vector2 point0, Vector2 point1) => default; // 0x0000000185FB5E10-0x0000000185FB5E80
		public static Line2 CreateParallelToGivenLineAtGivenDistance(Line2 line, float distance) => default; // 0x00000001878D892C-0x00000001878D8990
		public Vector2 Eval(float t) => default; // 0x00000001878D8A34-0x00000001878D8A64
		public float SignedDistanceTo(Vector2 point) => default; // 0x00000001878D9544-0x00000001878D95C8
		public float DistanceTo(Vector2 point) => default; // 0x00000001878D8A14-0x00000001878D8A34
		public int QuerySide(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0207C0C6 */) => default; // 0x00000001878D9264-0x00000001878D9320
		public bool QuerySideNegative(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0207C0CA */) => default; // 0x00000001878D8A94-0x00000001878D8B28
		public bool QuerySidePositive(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0207C0CE */) => default; // 0x00000001878D8E68-0x00000001878D8F04
		public int QuerySide(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x0207C0D2 */) => default; // 0x00000001878D93F4-0x00000001878D9544
		public bool QuerySideNegative(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x0207C0D6 */) => default; // 0x00000001878D8BF0-0x00000001878D8D20
		public bool QuerySidePositive(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x0207C0DA */) => default; // 0x00000001878D8F04-0x00000001878D902C
		public int QuerySide(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x0207C0DE */) => default; // 0x00000001878D90FC-0x00000001878D9264
		public bool QuerySideNegative(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x0207C0E2 */) => default; // 0x00000001878D8B28-0x00000001878D8BF0
		public bool QuerySidePositive(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x0207C0E6 */) => default; // 0x00000001878D902C-0x00000001878D90FC
		public int QuerySide(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x0207C0EA */) => default; // 0x00000001878D9320-0x00000001878D93F4
		public bool QuerySideNegative(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x0207C0EE */) => default; // 0x00000001878D8D20-0x00000001878D8DC8
		public bool QuerySidePositive(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x0207C0F2 */) => default; // 0x00000001878D8DC8-0x00000001878D8E68
		public Vector2 Project(Vector2 point) => default; // 0x00000001878D8A64-0x00000001878D8A94
		public float AngleBetweenTwoLines(Line2 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x0207C0F6 */) => default; // 0x00000001878D87B0-0x00000001878D8874
		public override string ToString() => default; // 0x00000001878D95C8-0x00000001878D9660
	}

	public struct Edge2 // TypeDefIndex: 55926
	{
		// Fields
		public Vector2 Point0; // 0x00
		public Vector2 Point1; // 0x08
		public Vector2 Direction; // 0x10
		public Vector2 Normal; // 0x18
		public float Length; // 0x20
	}

	public class Polygon2 // TypeDefIndex: 55927
	{
		// Fields
		private Vector2[] _vertices; // 0x10
		private Edge2[] _edges; // 0x18
	
		// Properties
		public Vector2[] Vertices { get => default; } // 0x000000018346D130-0x000000018346D140 
		public Edge2[] Edges { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public int VertexCount { get => default; } // 0x00000001877752B4-0x00000001877752D0 
		public Vector2 this[int vertexIndex] { get => default; set {} } // 0x00000001878DDBB0-0x00000001878DDBDC 0x00000001878DDBDC-0x00000001878DDC24
	
		// Constructors
		private Polygon2() {} // 0x0000000185492010-0x0000000185492020
		public Polygon2(Vector2[] vertices) {} // 0x00000001878DDA90-0x00000001878DDB34
		public Polygon2(int vertexCount) {} // 0x00000001878DDB34-0x00000001878DDBB0
	
		// Methods
		public static Polygon2 CreateProjected(Polygon3 polygon, ProjectionPlanes projectionPlane) => default; // 0x00000001878DC9A8-0x00000001878DCBBC
		public Edge2 GetEdge(int edgeIndex) => default; // 0x00000001878DCBBC-0x00000001878DCC0C
		public void UpdateEdges() {} // 0x00000001878DD8D0-0x00000001878DDA90
		public void UpdateEdge(int edgeIndex) {} // 0x00000001878DD730-0x00000001878DD8D0
		public Vector2 CalcCenter() => default; // 0x00000001878DBED8-0x00000001878DBFA0
		public float CalcPerimeter() => default; // 0x00000001878DBFA0-0x00000001878DC008
		public float CalcArea() => default; // 0x00000001878DBD48-0x00000001878DBED8
		public bool IsConvex(out Orientations orientation, float threshold = 1E-05f /* Metadata: 0x0207C0F7 */) {
			orientation = default;
			return default;
		} // 0x00000001878DCCF8-0x00000001878DCE74
		public bool IsConvex(float threshold = 1E-05f /* Metadata: 0x0207C0FB */) => default; // 0x00000001878DCCD0-0x00000001878DCCF8
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x0207C0FF */) => default; // 0x00000001878DCC0C-0x00000001878DCCD0
		public void ReverseVertices() {} // 0x00000001878DCE74-0x00000001878DCF68
		public bool ContainsConvexQuadCCW(ref Vector2 point) => default; // 0x00000001878DC09C-0x00000001878DC47C
		public bool ContainsConvexQuadCCW(Vector2 point) => default; // 0x00000001878DC080-0x00000001878DC09C
		public bool ContainsConvexQuadCW(ref Vector2 point) => default; // 0x00000001878DC47C-0x00000001878DC85C
		public bool ContainsConvexQuadCW(Vector2 point) => default; // 0x00000001878DC85C-0x00000001878DC878
		public bool ContainsConvexCCW(ref Vector2 point) => default; // 0x00000001878DC008-0x00000001878DC028
		public bool ContainsConvexCCW(Vector2 point) => default; // 0x00000001878DC028-0x00000001878DC044
		private bool SubContainsPointCCW(ref Vector2 p, int i0, int i1) => default; // 0x00000001878DCF68-0x00000001878DD1E8
		public bool ContainsConvexCW(ref Vector2 point) => default; // 0x00000001878DC044-0x00000001878DC064
		public bool ContainsConvexCW(Vector2 point) => default; // 0x00000001878DC064-0x00000001878DC080
		private bool SubContainsPointCW(ref Vector2 p, int i0, int i1) => default; // 0x00000001878DD1E8-0x00000001878DD468
		public bool ContainsSimple(ref Vector2 point) => default; // 0x00000001878DC894-0x00000001878DC9A8
		public bool ContainsSimple(Vector2 point) => default; // 0x00000001878DC878-0x00000001878DC894
		public Segment2[] ToSegmentArray() => default; // 0x00000001878DD468-0x00000001878DD5AC
		public override string ToString() => default; // 0x00000001878DD5AC-0x00000001878DD730
	}

	public struct Ray2 // TypeDefIndex: 55928
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Ray2(ref Vector2 center, ref Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000185FB5970-0x0000000185FB5990
		public Ray2(Vector2 center, Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183680100-0x0000000183680110
	
		// Methods
		public Vector2 Eval(float t) => default; // 0x00000001878D8A34-0x00000001878D8A64
		public float DistanceTo(Vector2 point) => default; // 0x00000001878DDC78-0x00000001878DDC98
		public Vector2 Project(Vector2 point) => default; // 0x00000001878DDC98-0x00000001878DDCC8
		public override string ToString() => default; // 0x00000001878DDCC8-0x00000001878DDD60
	}

	public struct Segment2 // TypeDefIndex: 55929
	{
		// Fields
		public Vector2 P0; // 0x00
		public Vector2 P1; // 0x08
		public Vector2 Center; // 0x10
		public Vector2 Direction; // 0x18
		public float Extent; // 0x20
	
		// Constructors
		public Segment2(ref Vector2 p0, ref Vector2 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001878DE174-0x00000001878DE1B4
		public Segment2(Vector2 p0, Vector2 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001878DE130-0x00000001878DE14C
		public Segment2(ref Vector2 center, ref Vector2 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001878DE1B4-0x00000001878DE218
		public Segment2(Vector2 center, Vector2 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001878DE14C-0x00000001878DE174
	
		// Methods
		public void SetEndpoints(Vector2 p0, Vector2 p1) {} // 0x00000001878DDF88-0x00000001878DDF98
		public void SetCenterDirectionExtent(Vector2 center, Vector2 direction, float extent) {} // 0x00000001878DDF74-0x00000001878DDF88
		public void CalcCenterDirectionExtent() {} // 0x00000001878DDD60-0x00000001878DDE40
		public void CalcEndPoints() {} // 0x00000001878DDE40-0x00000001878DDED8
		public Vector2 Eval(float s) => default; // 0x00000001878DDEF8-0x00000001878DDF44
		public float DistanceTo(Vector2 point) => default; // 0x00000001878DDED8-0x00000001878DDEF8
		public Vector2 Project(Vector2 point) => default; // 0x00000001878DDF44-0x00000001878DDF74
		public override string ToString() => default; // 0x00000001878DDF98-0x00000001878DE130
	}

	public struct Triangle2 // TypeDefIndex: 55930
	{
		// Fields
		public Vector2 V0; // 0x00
		public Vector2 V1; // 0x08
		public Vector2 V2; // 0x10
	
		// Properties
		public Vector2 this[int index] { get => default; set {} } // 0x00000001878DF130-0x00000001878DF170 0x00000001878DF170-0x00000001878DF18C
	
		// Constructors
		public Triangle2(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x0000000185FB6020-0x0000000185FB6060
		public Triangle2(Vector2 v0, Vector2 v1, Vector2 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x0000000185FB6010-0x0000000185FB6020
	
		// Methods
		public Vector2 CalcEdge(int edgeIndex) => default; // 0x00000001878DE9EC-0x00000001878DEA60
		public float CalcDeterminant() => default; // 0x0000000185FB5FB0-0x0000000185FB6010
		public Orientations CalcOrientation(float threshold = 1E-05f /* Metadata: 0x0207C103 */) => default; // 0x00000001878DEA60-0x00000001878DEAA0
		public float CalcArea() => default; // 0x00000001878DE7B0-0x00000001878DE7D0
		public static float CalcArea(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x0000000185FB5EA0-0x0000000185FB5F10
		public static float CalcArea(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x0000000185FB5F10-0x0000000185FB5FB0
		public Vector3 CalcAnglesDeg() => default; // 0x00000001878DE36C-0x00000001878DE4C0
		public static Vector3 CalcAnglesDeg(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x00000001878DE218-0x00000001878DE36C
		public static Vector3 CalcAnglesDeg(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x00000001878DE4C0-0x00000001878DE508
		public Vector3 CalcAnglesRad() => default; // 0x00000001878DE680-0x00000001878DE7B0
		public static Vector3 CalcAnglesRad(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x00000001878DE550-0x00000001878DE680
		public static Vector3 CalcAnglesRad(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x00000001878DE508-0x00000001878DE550
		public Vector2 EvalBarycentric(float c0, float c1) => default; // 0x00000001878DED54-0x00000001878DEDEC
		public Vector2 EvalBarycentric(ref Vector3 baryCoords) => default; // 0x00000001878DEDEC-0x00000001878DEE68
		public Vector2 EvalBarycentric(Vector3 baryCoords) => default; // 0x00000001878DEDEC-0x00000001878DEE68
		public static void CalcBarycentricCoords(ref Vector2 point, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2, out Vector3 baryCoords) {
			baryCoords = default;
		} // 0x00000001878DE808-0x00000001878DE9B0
		public Vector3 CalcBarycentricCoords(ref Vector2 point) => default; // 0x00000001878DE7D0-0x00000001878DE808
		public Vector3 CalcBarycentricCoords(Vector2 point) => default; // 0x00000001878DE9B0-0x00000001878DE9EC
		public float DistanceTo(Vector2 point) => default; // 0x00000001878DED34-0x00000001878DED54
		public int QuerySideCCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0207C107 */) => default; // 0x00000001878DEE98-0x00000001878DEF7C
		public int QuerySideCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x0207C10B */) => default; // 0x00000001878DEF7C-0x00000001878DF06C
		public Vector2 Project(Vector2 point) => default; // 0x00000001878DEE68-0x00000001878DEE98
		public bool Contains(ref Vector2 point) => default; // 0x00000001878DEC38-0x00000001878DED18
		public bool Contains(Vector2 point) => default; // 0x00000001878DED18-0x00000001878DED34
		public bool ContainsCCW(ref Vector2 point) => default; // 0x00000001878DEABC-0x00000001878DEB6C
		public bool ContainsCCW(Vector2 point) => default; // 0x00000001878DEAA0-0x00000001878DEABC
		public bool ContainsCW(ref Vector2 point) => default; // 0x00000001878DEB88-0x00000001878DEC38
		public bool ContainsCW(Vector2 point) => default; // 0x00000001878DEB6C-0x00000001878DEB88
		public override string ToString() => default; // 0x00000001878DF06C-0x00000001878DF130
	}

	public struct AAB3 // TypeDefIndex: 55931
	{
		// Fields
		public Vector3 Min; // 0x00
		public Vector3 Max; // 0x0C
	
		// Constructors
		public AAB3(ref Vector3 min, ref Vector3 max) {
			Min = default;
			Max = default;
		} // 0x0000000185FB5B30-0x0000000185FB5B50
		public AAB3(Vector3 min, Vector3 max) {
			Min = default;
			Max = default;
		} // 0x0000000185FB1480-0x0000000185FB14A0
		public AAB3(float xMin, float xMax, float yMin, float yMax, float zMin, float zMax) {
			Min = default;
			Max = default;
		} // 0x0000000185FB5B50-0x0000000185FB5B80
	
		// Methods
		public static implicit operator Bounds(AAB3 value) => default; // 0x00000001878D28E0-0x00000001878D294C
		public static implicit operator AAB3(Bounds value) => default; // 0x00000001878D287C-0x00000001878D28E0
		public static AAB3 CreateFromPoint(ref Vector3 point) => default; // 0x0000000185FB5B10-0x0000000185FB5B30
		public static AAB3 CreateFromPoint(Vector3 point) => default; // 0x0000000185FB5B10-0x0000000185FB5B30
		public static AAB3 CreateFromTwoPoints(ref Vector3 point0, ref Vector3 point1) => default; // 0x00000001878D2644-0x00000001878D26BC
		public static AAB3 CreateFromTwoPoints(Vector3 point0, Vector3 point1) => default; // 0x00000001878D2614-0x00000001878D2644
		public static AAB3 CreateFromPoints(IEnumerable<Vector3> points) => default; // 0x00000001878D2260-0x00000001878D23D8
		public static AAB3 CreateFromPoints(IList<Vector3> points) => default; // 0x00000001878D23D8-0x00000001878D2528
		public static AAB3 CreateFromPoints(Vector3[] points) => default; // 0x00000001878D2528-0x00000001878D2614
		public void CalcCenterExtents(out Vector3 center, out Vector3 extents) {
			center = default;
			extents = default;
		} // 0x0000000184402A70-0x0000000184402AF0
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
			vertex4 = default;
			vertex5 = default;
			vertex6 = default;
			vertex7 = default;
		} // 0x0000000185FB59F0-0x0000000185FB5AE0
		public Vector3[] CalcVertices() => default; // 0x00000001878D206C-0x00000001878D2218
		public void CalcVertices(Vector3[] array) {} // 0x00000001878D1EF0-0x00000001878D206C
		public float CalcVolume() => default; // 0x0000000185FB5AE0-0x0000000185FB5B10
		public float DistanceTo(Vector3 point) => default; // 0x00000001878D26BC-0x00000001878D26D8
		public Vector3 Project(Vector3 point) => default; // 0x00000001878D27A4-0x00000001878D27D0
		public bool Contains(ref Vector3 point) => default; // 0x0000000184265EF0-0x0000000184265F40
		public bool Contains(Vector3 point) => default; // 0x00000001878D2218-0x00000001878D2260
		public void Include(ref Vector3 point) {} // 0x00000001878D26D8-0x00000001878D273C
		public void Include(Vector3 point) {} // 0x00000001878D26D8-0x00000001878D273C
		public void Include(ref AAB3 box) {} // 0x00000001878D273C-0x00000001878D2770
		public void Include(AAB3 box) {} // 0x00000001878D2770-0x00000001878D27A4
		public override string ToString() => default; // 0x00000001878D27D0-0x00000001878D287C
	}

	public struct Box3 // TypeDefIndex: 55932
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Axis2; // 0x24
		public Vector3 Extents; // 0x30
	
		// Constructors
		public Box3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, ref Vector3 axis2, ref Vector3 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x0000000185FB5C30-0x0000000185FB5C90
		public Box3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector3 axis2, Vector3 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x0000000185FB5C90-0x0000000185FB5CF0
		public Box3(ref AAB3 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x00000001878D5CA8-0x00000001878D5D58
		public Box3(AAB3 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x00000001844029A0-0x0000000184402A70
	
		// Methods
		public static Box3 CreateFromPoints(IList<Vector3> points) => default; // 0x00000001878D4D30-0x00000001878D5290
		public Vector3 GetAxis(int index) => default; // 0x00000001878D52AC-0x00000001878D5348
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
			vertex4 = default;
			vertex5 = default;
			vertex6 = default;
			vertex7 = default;
		} // 0x00000001878D463C-0x00000001878D4B84
		public Vector3[] CalcVertices() => default; // 0x00000001878D3A94-0x00000001878D4080
		public void CalcVertices(Vector3[] array) {} // 0x00000001878D4080-0x00000001878D463C
		public float CalcVolume() => default; // 0x0000000185FB5C10-0x0000000185FB5C30
		public float DistanceTo(Vector3 point) => default; // 0x00000001878D5290-0x00000001878D52AC
		public Vector3 Project(Vector3 point) => default; // 0x00000001878D5AB8-0x00000001878D5AE4
		public bool Contains(ref Vector3 point) => default; // 0x00000001878D4B84-0x00000001878D4D1C
		public bool Contains(Vector3 point) => default; // 0x00000001878D4D1C-0x00000001878D4D30
		public void Include(ref Box3 box) {} // 0x00000001878D5348-0x00000001878D5AA4
		public void Include(Box3 box) {} // 0x00000001878D5AA4-0x00000001878D5AB8
		public override string ToString() => default; // 0x00000001878D5AE4-0x00000001878D5CA8
	}

	public struct Capsule3 // TypeDefIndex: 55933
	{
		// Fields
		public Segment3 Segment; // 0x00
		public float Radius; // 0x34
	
		// Constructors
		public Capsule3(ref Segment3 segment, float radius) {
			Segment = default;
			Radius = default;
		} // 0x0000000185FB6060-0x0000000185FB6090
		public Capsule3(Segment3 segment, float radius) {
			Segment = default;
			Radius = default;
		} // 0x0000000185FB6090-0x0000000185FB60C0
	}

	public struct Circle3 // TypeDefIndex: 55934
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Normal; // 0x24
		public float Radius; // 0x30
	
		// Constructors
		public Circle3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x00000001878E0C9C-0x00000001878E0D90
		public Circle3(Vector3 center, Vector3 axis0, Vector3 axis1, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x00000001878E0D90-0x00000001878E0E70
		public Circle3(ref Vector3 center, ref Vector3 normal, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x00000001878E0C08-0x00000001878E0C9C
		public Circle3(Vector3 center, Vector3 normal, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x00000001878E0E70-0x00000001878E0F04
	
		// Methods
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle) {
			circle = default;
			return default;
		} // 0x00000001878DFF4C-0x00000001878E02EC
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle) {
			circle = default;
			return default;
		} // 0x00000001878E02EC-0x00000001878E07CC
		public float CalcPerimeter() => default; // 0x0000000185FB60E0-0x0000000185FB60F0
		public float CalcArea() => default; // 0x0000000185FB60C0-0x0000000185FB60E0
		public Vector3 Eval(float t) => default; // 0x00000001878E07E8-0x00000001878E0900
		public Vector3 Eval(float t, float radius) => default; // 0x00000001878E0900-0x00000001878E0A24
		public float DistanceTo(Vector3 point, bool solid = true /* Metadata: 0x0207C10F */) => default; // 0x00000001878E07CC-0x00000001878E07E8
		public Vector3 Project(Vector3 point, bool solid = true /* Metadata: 0x0207C110 */) => default; // 0x00000001878E0A24-0x00000001878E0A54
		public override string ToString() => default; // 0x00000001878E0A54-0x00000001878E0C08
	}

	public struct Line3 // TypeDefIndex: 55935
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Line3(ref Vector3 center, ref Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000185FB5B30-0x0000000185FB5B50
		public Line3(Vector3 center, Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000185FB1480-0x0000000185FB14A0
	
		// Methods
		public static Line3 CreateFromTwoPoints(ref Vector3 p0, ref Vector3 p1) => default; // 0x00000001878E4900-0x00000001878E498C
		public static Line3 CreateFromTwoPoints(Vector3 p0, Vector3 p1) => default; // 0x00000001878E4900-0x00000001878E498C
		public Vector3 Eval(float t) => default; // 0x00000001878E49A8-0x00000001878E4A24
		public float DistanceTo(Vector3 point) => default; // 0x00000001878E498C-0x00000001878E49A8
		public Vector3 Project(Vector3 point) => default; // 0x00000001878E4A24-0x00000001878E4A50
		public float AngleBetweenTwoLines(Line3 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x0207C111 */) => default; // 0x00000001878E4838-0x00000001878E4900
		public override string ToString() => default; // 0x00000001878E4A50-0x00000001878E4AFC
	}

	[Serializable]
	public struct Plane3 // TypeDefIndex: 55936
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float Constant; // 0x0C
	
		// Constructors
		public Plane3(ref Vector3 normal, float constant) {
			Normal = default;
			Constant = default;
		} // 0x00000001836800E0-0x0000000183680100
		public Plane3(Vector3 normal, float constant) {
			Normal = default;
			Constant = default;
		} // 0x00000001836800E0-0x0000000183680100
		public Plane3(ref Vector3 normal, ref Vector3 point) {
			Normal = default;
			Constant = default;
		} // 0x00000001878E682C-0x00000001878E68D8
		public Plane3(Vector3 normal, Vector3 point) {
			Normal = default;
			Constant = default;
		} // 0x00000001878E6794-0x00000001878E682C
		public Plane3(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2) {
			Normal = default;
			Constant = default;
		} // 0x00000001878E6A20-0x00000001878E6B68
		public Plane3(Vector3 p0, Vector3 p1, Vector3 p2) {
			Normal = default;
			Constant = default;
		} // 0x00000001878E68D8-0x00000001878E6A20
	
		// Methods
		public static implicit operator Plane(Plane3 value) => default; // 0x00000001878E6B68-0x00000001878E6BAC
		public static implicit operator Plane3(Plane value) => default; // 0x0000000185FB60F0-0x0000000185FB6120
		public Vector3 CalcOrigin() => default; // 0x00000001878E5538-0x00000001878E557C
		public void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, out Vector3 n) {
			u = default;
			v = default;
			n = default;
		} // 0x00000001878E557C-0x00000001878E5684
		internal float SignedDistanceTo(ref Vector3 point) => default; // 0x00000001878E6660-0x00000001878E66FC
		public float SignedDistanceTo(Vector3 point) => default; // 0x00000001878E65D0-0x00000001878E6660
		public float DistanceTo(Vector3 point) => default; // 0x00000001878E5684-0x00000001878E571C
		public int QuerySide(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x0207C112 */) => default; // 0x00000001878E6508-0x00000001878E65D0
		public bool QuerySideNegative(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x0207C116 */) => default; // 0x00000001878E5AFC-0x00000001878E5BA0
		public bool QuerySidePositive(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x0207C11A */) => default; // 0x00000001878E5E44-0x00000001878E5EF0
		public int QuerySide(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x0207C11E */) => default; // 0x00000001878E6340-0x00000001878E6508
		public bool QuerySideNegative(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x0207C122 */) => default; // 0x00000001878E5848-0x00000001878E59F0
		public bool QuerySidePositive(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x0207C126 */) => default; // 0x00000001878E5EF0-0x00000001878E6090
		public int QuerySide(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x0207C12A */) => default; // 0x00000001878E6188-0x00000001878E6340
		public bool QuerySideNegative(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x0207C12E */) => default; // 0x00000001878E59F0-0x00000001878E5AFC
		public bool QuerySidePositive(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x0207C132 */) => default; // 0x00000001878E5D30-0x00000001878E5E44
		public int QuerySide(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x0207C136 */) => default; // 0x00000001878E6090-0x00000001878E6188
		public bool QuerySideNegative(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x0207C13A */) => default; // 0x00000001878E5BA0-0x00000001878E5C6C
		public bool QuerySidePositive(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x0207C13E */) => default; // 0x00000001878E5C6C-0x00000001878E5D30
		public Vector3 Project(Vector3 point) => default; // 0x00000001878E581C-0x00000001878E5848
		public Vector3 ProjectVector(Vector3 vector) => default; // 0x00000001878E571C-0x00000001878E581C
		public float AngleBetweenPlaneNormalAndLine(Line3 line) => default; // 0x00000001878E53DC-0x00000001878E5494
		public float AngleBetweenPlaneNormalAndLine(Vector3 direction) => default; // 0x00000001878E5330-0x00000001878E53DC
		public float AngleBetweenPlaneAndLine(Line3 line) => default; // 0x00000001878E5268-0x00000001878E5330
		public float AngleBetweenPlaneAndLine(Vector3 direction) => default; // 0x00000001878E51AC-0x00000001878E5268
		public float AngleBetweenTwoPlanes(Plane3 anotherPlane) => default; // 0x00000001878E5494-0x00000001878E5538
		public override string ToString() => default; // 0x00000001878E66FC-0x00000001878E6794
	}

	[Serializable]
	public struct Edge3 // TypeDefIndex: 55937
	{
		// Fields
		public Vector3 Point0; // 0x00
		public Vector3 Point1; // 0x0C
		public Vector3 Direction; // 0x18
		public Vector3 Normal; // 0x24
		public float Length; // 0x30
	}

	[Serializable]
	public class Polygon3 // TypeDefIndex: 55938
	{
		// Fields
		private Vector3[] _vertices; // 0x10
		private Edge3[] _edges; // 0x18
		private Plane3 _plane; // 0x20
	
		// Properties
		public Vector3[] Vertices { get => default; } // 0x000000018346D130-0x000000018346D140 
		public Edge3[] Edges { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public int VertexCount { get => default; } // 0x00000001877752B4-0x00000001877752D0 
		public Vector3 this[int vertexIndex] { get => default; set {} } // 0x00000001878E84D8-0x00000001878E8504 0x00000001878E8504-0x00000001878E853C
		public Plane3 Plane { get => default; set {} } // 0x0000000185FB6120-0x0000000185FB6130 0x0000000185FB6130-0x0000000185FB6140
	
		// Constructors
		private Polygon3() {} // 0x0000000185492010-0x0000000185492020
		public Polygon3(Vector3[] vertices, Plane3 plane) {} // 0x00000001878E8420-0x00000001878E84D8
		public Polygon3(int vertexCount, Plane3 plane) {} // 0x00000001878E8390-0x00000001878E8420
	
		// Methods
		public void SetVertexProjected(int vertexIndex, Vector3 vertex) {} // 0x00000001878E7B94-0x00000001878E7CB8
		public void ProjectVertices() {} // 0x00000001878E7934-0x00000001878E7AA8
		public Edge3 GetEdge(int edgeIndex) => default; // 0x00000001878E77D4-0x00000001878E7830
		public void UpdateEdges() {} // 0x00000001878E8188-0x00000001878E8390
		public void UpdateEdge(int edgeIndex) {} // 0x00000001878E7FB0-0x00000001878E8188
		public Vector3 CalcCenter() => default; // 0x00000001878E763C-0x00000001878E776C
		public float CalcPerimeter() => default; // 0x00000001878E776C-0x00000001878E77D4
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x0207C142 */) => default; // 0x00000001878E7830-0x00000001878E7934
		public void ReverseVertices() {} // 0x00000001878E7AA8-0x00000001878E7B94
		public Segment3[] ToSegmentArray() => default; // 0x00000001878E7CB8-0x00000001878E7E10
		public override string ToString() => default; // 0x00000001878E7E10-0x00000001878E7FB0
	}

	public struct Ray3 // TypeDefIndex: 55939
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Ray3(ref Vector3 center, ref Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000185FB5B30-0x0000000185FB5B50
		public Ray3(Vector3 center, Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000185FB1480-0x0000000185FB14A0
	
		// Methods
		public static implicit operator Ray(Ray3 value) => default; // 0x00000001878E945C-0x00000001878E94B0
		public static implicit operator Ray3(Ray value) => default; // 0x0000000185FB6480-0x0000000185FB64B0
		public Vector3 Eval(float t) => default; // 0x00000001878E49A8-0x00000001878E4A24
		public float DistanceTo(Vector3 point) => default; // 0x00000001878E9368-0x00000001878E9384
		public Vector3 Project(Vector3 point) => default; // 0x00000001878E9384-0x00000001878E93B0
		public override string ToString() => default; // 0x00000001878E93B0-0x00000001878E945C
	}

	public struct Rectangle3 // TypeDefIndex: 55940
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Normal; // 0x24
		public Vector2 Extents; // 0x30
	
		// Constructors
		public Rectangle3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, ref Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Extents = default;
		} // 0x00000001878EA2E0-0x00000001878EA3F8
		public Rectangle3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Extents = default;
		} // 0x00000001878EA200-0x00000001878EA2E0
	
		// Methods
		public static Rectangle3 CreateFromCCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x00000001878E9BE8-0x00000001878E9DE0
		public static Rectangle3 CreateFromCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x00000001878E9DE0-0x00000001878E9FD8
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x00000001878E9724-0x00000001878E9944
		public Vector3[] CalcVertices() => default; // 0x00000001878E9944-0x00000001878E9BE8
		public void CalcVertices(Vector3[] array) {} // 0x00000001878E94B0-0x00000001878E9724
		public float CalcArea() => default; // 0x0000000185FB64B0-0x0000000185FB64D0
		public float DistanceTo(Vector3 point) => default; // 0x00000001878E9FD8-0x00000001878E9FF4
		public Vector3 Project(Vector3 point) => default; // 0x00000001878E9FF4-0x00000001878EA020
		public override string ToString() => default; // 0x00000001878EA020-0x00000001878EA200
	}

	public struct Segment3 // TypeDefIndex: 55941
	{
		// Fields
		public Vector3 P0; // 0x00
		public Vector3 P1; // 0x0C
		public Vector3 Center; // 0x18
		public Vector3 Direction; // 0x24
		public float Extent; // 0x30
	
		// Constructors
		public Segment3(ref Vector3 p0, ref Vector3 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001878EA938-0x00000001878EA998
		public Segment3(Vector3 p0, Vector3 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001878EA8D8-0x00000001878EA938
		public Segment3(ref Vector3 center, ref Vector3 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001878EA9F8-0x00000001878EAA58
		public Segment3(Vector3 center, Vector3 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x00000001878EA998-0x00000001878EA9F8
	
		// Methods
		public void SetEndpoints(Vector3 p0, Vector3 p1) {} // 0x00000001878EA6FC-0x00000001878EA724
		public void SetCenterDirectionExtent(Vector3 center, Vector3 direction, float extent) {} // 0x00000001878EA6D0-0x00000001878EA6FC
		public void CalcCenterDirectionExtent() {} // 0x00000001878EA3F8-0x00000001878EA508
		public void CalcEndPoints() {} // 0x00000001878EA508-0x00000001878EA5E8
		public Vector3 Eval(float s) => default; // 0x00000001878EA604-0x00000001878EA6A4
		public float DistanceTo(Vector3 point) => default; // 0x00000001878EA5E8-0x00000001878EA604
		public Vector3 Project(Vector3 point) => default; // 0x00000001878EA6A4-0x00000001878EA6D0
		public override string ToString() => default; // 0x00000001878EA724-0x00000001878EA8D8
	}

	public struct Sphere3 // TypeDefIndex: 55942
	{
		// Fields
		private const float _4div3mulPi = 4.1887903f; // Metadata: 0x0207C146
		public Vector3 Center; // 0x00
		public float Radius; // 0x0C
	
		// Constructors
		public Sphere3(ref Vector3 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x00000001836800E0-0x0000000183680100
		public Sphere3(Vector3 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x00000001836800E0-0x0000000183680100
	
		// Methods
		public static Sphere3 CreateFromPointsAAB(IEnumerable<Vector3> points) => default; // 0x00000001878EAEC4-0x00000001878EAFE8
		public static Sphere3 CreateFromPointsAAB(IList<Vector3> points) => default; // 0x00000001878EADEC-0x00000001878EAEC4
		public static Sphere3 CreateFromPointsAverage(IEnumerable<Vector3> points) => default; // 0x00000001878EAFE8-0x00000001878EB394
		public static Sphere3 CreateFromPointsAverage(IList<Vector3> points) => default; // 0x00000001878EB394-0x00000001878EB588
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere) {
			sphere = default;
			return default;
		} // 0x00000001878EAAC8-0x00000001878EADEC
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere) {
			sphere = default;
			return default;
		} // 0x00000001878EB588-0x00000001878EBBB0
		public float CalcArea() => default; // 0x0000000185FB64D0-0x0000000185FB64F0
		public float CalcVolume() => default; // 0x0000000185FB64F0-0x0000000185FB6510
		public Vector3 Eval(float theta, float phi) => default; // 0x0000000185FB6510-0x0000000185FB65B0
		public float DistanceTo(Vector3 point) => default; // 0x00000001878EBBB0-0x00000001878EBBCC
		public Vector3 Project(Vector3 point) => default; // 0x00000001878EBD28-0x00000001878EBD54
		public bool Contains(ref Vector3 point) => default; // 0x00000001878EAA58-0x00000001878EAAC8
		public bool Contains(Vector3 point) => default; // 0x00000001878EAA58-0x00000001878EAAC8
		public void Include(ref Sphere3 sphere) {} // 0x00000001878EBBCC-0x00000001878EBD14
		public void Include(Sphere3 sphere) {} // 0x00000001878EBD14-0x00000001878EBD28
		public override string ToString() => default; // 0x00000001878EBD54-0x00000001878EBDEC
	}

	public struct Triangle3 // TypeDefIndex: 55943
	{
		// Fields
		public Vector3 V0; // 0x00
		public Vector3 V1; // 0x0C
		public Vector3 V2; // 0x18
	
		// Properties
		public Vector3 this[int index] { get => default; set {} } // 0x00000001878EEA78-0x00000001878EEAD8 0x00000001878EEAD8-0x00000001878EEB1C
	
		// Constructors
		public Triangle3(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x0000000185FB65F0-0x0000000185FB6630
		public Triangle3(Vector3 v0, Vector3 v1, Vector3 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x0000000185FB65B0-0x0000000185FB65F0
	
		// Methods
		public Vector3 CalcEdge(int edgeIndex) => default; // 0x00000001878EE63C-0x00000001878EE700
		public Vector3 CalcNormal() => default; // 0x00000001878EE700-0x00000001878EE7B4
		public float CalcArea() => default; // 0x00000001878EE32C-0x00000001878EE3EC
		public static float CalcArea(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001878EE26C-0x00000001878EE32C
		public static float CalcArea(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001878EE26C-0x00000001878EE32C
		public Vector3 CalcAnglesDeg() => default; // 0x00000001878EDDD8-0x00000001878EDF64
		public static Vector3 CalcAnglesDeg(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001878EDC14-0x00000001878EDDA4
		public static Vector3 CalcAnglesDeg(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001878EDDA4-0x00000001878EDDD8
		public Vector3 CalcAnglesRad() => default; // 0x00000001878EE104-0x00000001878EE26C
		public static Vector3 CalcAnglesRad(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001878EDF64-0x00000001878EE0D0
		public static Vector3 CalcAnglesRad(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001878EE0D0-0x00000001878EE104
		public Vector3 EvalBarycentric(float c0, float c1) => default; // 0x00000001878EE8A4-0x00000001878EE99C
		public Vector3 EvalBarycentric(ref Vector3 baryCoords) => default; // 0x00000001878EE7B4-0x00000001878EE8A4
		public Vector3 EvalBarycentric(Vector3 baryCoords) => default; // 0x00000001878EE7B4-0x00000001878EE8A4
		public static void CalcBarycentricCoords(ref Vector3 point, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Vector3 baryCoords) {
			baryCoords = default;
		} // 0x00000001878EE424-0x00000001878EE63C
		public Vector3 CalcBarycentricCoords(ref Vector3 point) => default; // 0x00000001878EE3EC-0x00000001878EE424
		public Vector3 CalcBarycentricCoords(Vector3 point) => default; // 0x00000001878EE3EC-0x00000001878EE424
		public override string ToString() => default; // 0x00000001878EE99C-0x00000001878EEA78
	}

	public enum Orientations // TypeDefIndex: 55944
	{
		CW = 0,
		CCW = 1,
		None = 2
	}

	internal class Query2 : Query // TypeDefIndex: 55945
	{
		// Fields
		private static float Zero; // 0x00
		private Vector2[] _vertices; // 0x10
	
		// Constructors
		public Query2() {} // Dummy constructor
		public Query2(Vector2[] vertices) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public int ToLine(int i, int v0, int v1) => default; // 0x00000001878E8888-0x00000001878E88E0
		public int ToLine(ref Vector2 test, int v0, int v1) => default; // 0x00000001878E8794-0x00000001878E8888
		public int ToTriangle(int i, int v0, int v1, int v2) => default; // 0x00000001878E8988-0x00000001878E89E8
		public int ToTriangle(ref Vector2 test, int v0, int v1, int v2) => default; // 0x00000001878E88E0-0x00000001878E8988
		public int ToCircumcircle(int i, int v0, int v1, int v2) => default; // 0x00000001878E853C-0x00000001878E859C
		public int ToCircumcircle(ref Vector2 test, int v0, int v1, int v2) => default; // 0x00000001878E859C-0x00000001878E8794
		public float Dot(float x0, float y0, float x1, float y1) => default; // 0x0000000185FB6220-0x0000000185FB6240
		public float Det2(float x0, float y0, float x1, float y1) => default; // 0x0000000185FB6140-0x0000000185FB6160
		public float Det3(float x0, float y0, float z0, float x1, float y1, float z1, float x2, float y2, float z2) => default; // 0x0000000185FB6160-0x0000000185FB6220
	}

	internal class Query3 : Query // TypeDefIndex: 55946
	{
		// Fields
		private static float Zero; // 0x00
		private Vector3[] _vertices; // 0x10
	
		// Constructors
		public Query3() {} // Dummy constructor
		public Query3(Vector3[] vertices) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public int ToPlane(int i, int v0, int v1, int v2) => default; // 0x00000001878E8DE4-0x00000001878E8E44
		public int ToPlane(ref Vector3 test, int v0, int v1, int v2) => default; // 0x00000001878E8E44-0x00000001878E9000
		public int ToTetrahedron(int i, int v0, int v1, int v2, int v3) => default; // 0x00000001878E9000-0x00000001878E9068
		public int ToTetrahedron(ref Vector3 test, int v0, int v1, int v2, int v3) => default; // 0x00000001878E9068-0x00000001878E9154
		public int ToCircumsphere(int i, int v0, int v1, int v2, int v3) => default; // 0x00000001878E8D7C-0x00000001878E8DE4
		public int ToCircumsphere(ref Vector3 test, int v0, int v1, int v2, int v3) => default; // 0x00000001878E89E8-0x00000001878E8D7C
		public float Dot(float x0, float y0, float z0, float x1, float y1, float z1) => default; // 0x0000000185FB6460-0x0000000185FB6480
		public float Det3(float x0, float y0, float z0, float x1, float y1, float z1, float x2, float y2, float z2) => default; // 0x0000000185FB6160-0x0000000185FB6220
		public float Det4(float x0, float y0, float z0, float w0, float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2, float x3, float y3, float z3, float w3) => default; // 0x0000000185FB6240-0x0000000185FB6460
	}

	internal enum QueryTypes // TypeDefIndex: 55947
	{
		Int64 = 0,
		Integer = 1,
		Rational = 2,
		Real = 3,
		Filtered = 4
	}

	internal class Query // TypeDefIndex: 55948
	{
		// Constructors
		protected Query() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static bool Sort(ref int v0, ref int v1) => default; // 0x00000001878E9354-0x00000001878E9368
		public static bool Sort(ref int v0, ref int v1, ref int v2) => default; // 0x00000001878E9154-0x00000001878E91C4
		public static bool Sort(ref int v0, ref int v1, ref int v2, ref int v3) => default; // 0x00000001878E91C4-0x00000001878E9354
	}

	public class CatmullRomSpline3 : SplineBase // TypeDefIndex: 55949
	{
		// Properties
		public override SplineTypes SplineType { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x00000001878DFEDC-0x00000001878DFF4C
	
		// Constructors
		public CatmullRomSpline3() {} // 0x00000001878DFED4-0x00000001878DFEDC
	
		// Methods
		public static CatmullRomSpline3 Create() => default; // 0x00000001878DF388-0x00000001878DF404
		public static CatmullRomSpline3 Create(IList<Vector3> points, SplineTypes type) => default; // 0x00000001878DF404-0x00000001878DF614
		private void UpdateSegment(int index) {} // 0x00000001878DF9F0-0x00000001878DFED4
		private void UpdateAdjacentSegments(int vertexIndex) {} // 0x00000001878DF8C0-0x00000001878DF9F0
		public override void AddVertexFirst(Vector3 position) {} // 0x00000001878DF25C-0x00000001878DF290
		public override void AddVertexLast(Vector3 position) {} // 0x00000001878DF290-0x00000001878DF33C
		public override void RemoveVertex(int index) {} // 0x00000001878DF7D0-0x00000001878DF838
		public override void Clear() {} // 0x00000001878DF33C-0x00000001878DF388
		public override void InsertBefore(int vertexIndex, Vector3 position) {} // 0x00000001878DF730-0x00000001878DF7D0
		public override void InsertAfter(int vertexIndex, Vector3 position) {} // 0x00000001878DF68C-0x00000001878DF730
		public override Vector3 GetVertex(int vertexIndex) => default; // 0x00000001878DF614-0x00000001878DF68C
		public override void SetVertex(int vertexIndex, Vector3 position) {} // 0x00000001878DF838-0x00000001878DF8C0
	}

	public class CubicSpline3 : SplineBase // TypeDefIndex: 55950
	{
		// Properties
		public override SplineTypes SplineType { get => default; set {} } // 0x0000000181C9AC80-0x0000000181C9AC90 0x00000001878E2B88-0x00000001878E2B9C
	
		// Constructors
		public CubicSpline3() {} // 0x00000001878DFED4-0x00000001878DFEDC
	
		// Methods
		public static CubicSpline3 Create() => default; // 0x00000001878E2684-0x00000001878E2700
		public static CubicSpline3 Create(IList<Vector3> points, SplineTypes type) => default; // 0x00000001878E2700-0x00000001878E28E8
		private void BuildSpline() {} // 0x00000001878E1028-0x00000001878E1090
		private void CreateOpenedSpline() {} // 0x00000001878E1EA0-0x00000001878E2684
		private void CreateClosedSpline() {} // 0x00000001878E10DC-0x00000001878E1EA0
		public override void AddVertexFirst(Vector3 position) {} // 0x00000001878E0F04-0x00000001878E0F98
		public override void AddVertexLast(Vector3 position) {} // 0x00000001878E0F98-0x00000001878E1028
		public override void RemoveVertex(int index) {} // 0x00000001878E2AA0-0x00000001878E2B04
		public override void Clear() {} // 0x00000001878E1090-0x00000001878E10DC
		public override void InsertBefore(int vertexIndex, Vector3 position) {} // 0x00000001878E2A00-0x00000001878E2AA0
		public override void InsertAfter(int vertexIndex, Vector3 position) {} // 0x00000001878E2960-0x00000001878E2A00
		public override Vector3 GetVertex(int vertexIndex) => default; // 0x00000001878E28E8-0x00000001878E2960
		public override void SetVertex(int vertexIndex, Vector3 position) {} // 0x00000001878E2B04-0x00000001878E2B88
	}

	public enum SplineTypes // TypeDefIndex: 55951
	{
		Open = 0,
		Closed = 1
	}

	public enum SplinePlaneTypes // TypeDefIndex: 55952
	{
		XZ = 0,
		XY = 1,
		YZ = 2
	}

	public struct PositionTangent // TypeDefIndex: 55953
	{
		// Fields
		public Vector3 Position; // 0x00
		public Vector3 Tangent; // 0x0C
	}

	public struct CurveFrame // TypeDefIndex: 55954
	{
		// Fields
		public Vector3 Position; // 0x00
		public Vector3 Tangent; // 0x0C
		public Vector3 Normal; // 0x18
		public Vector3 Binormal; // 0x24
	}

	public abstract class SplineBase : MonoBehaviour // TypeDefIndex: 55957
	{
		// Fields
		protected ArcLengthParametrization _parametrization; // 0x18
		protected List<ItemData> _data; // 0x20
		protected SplineTypes _type; // 0x28
		protected bool _recalcSegmentsLength; // 0x2C
		protected UnityEngine.Color _renderColor; // 0x30
		protected SplinePlaneTypes _creationPlane; // 0x40
	
		// Properties
		protected int SegmentCount { get; }
		public int VertexCount { get; }
		public bool Valid { get; }
		public abstract SplineTypes SplineType { get; set; } // 0x00000001878ECC0C-0x00000001878ECCC0
	
		// Nested types
		[Serializable]
		protected class ItemData // TypeDefIndex: 55955
		{
			// Fields
			public Vector3 Position; // 0x10
			public Vector3 A; // 0x1C
			public Vector3 B; // 0x28
			public Vector3 C; // 0x34
			public Vector3 D; // 0x40
			public float Length; // 0x4C
			public float AccumulatedLength; // 0x50
			private const int SegmentCount = 10; // Metadata: 0x0207C157
			private const int SegmentCountPlus1 = 11; // Metadata: 0x0207C158
			private const float DeltaTime = 0.1f; // Metadata: 0x0207C159
			public Vector3[] RenderPoints; // 0x58
	
			// Constructors
			public ItemData() {}
	
			// Methods
			public bool EnsureRenderPointsValidity() => default; // 0x00000001878EDB40-0x00000001878EDB90
			public void UpdateRenderPoints() {} // 0x00000001878EDBD4-0x00000001878EDC14
			public Vector3 EvalPosition(float t) => default; // 0x00000001878EDB90-0x00000001878EDBD4
			public Vector3 EvalFirstDerivative(float t) => default;
			public Vector3 EvalSecondDerivative(float t) => default;
			public Vector3 EvalThirdDerivative(float t) => default; // 0x00000001878EBDEC-0x00000001878EBDF4
			public float EvalSpeed(float t) => default; // 0x00000001878EDAA8-0x00000001878EDB40
			public Vector3 EvalTangent(float t) => default; // 0x00000001878ED310-0x00000001878ED3A0
			public float EvalLength() => default; // 0x00000001878ED940-0x00000001878ED9D4
			public float EvalLength(float t0, float t1) => default; // 0x00000001878ED9D4-0x00000001878EDAA8
			public float ProcessLength(float currentLength) => default;
		}
	
		protected class ArcLengthParametrization // TypeDefIndex: 55956
		{
			// Fields
			public float[] sSample; // 0x10
			public float[] tSample; // 0x18
			public float[] tsSlope; // 0x20
			public float L; // 0x28
	
			// Constructors
			public ArcLengthParametrization() {}
	
			// Methods
			public float GetApproximateTimeParameter(float s) => default;
		}
	
		// Constructors
		protected SplineBase() {} // 0x00000001878ECA70-0x00000001878ECB58
	
		// Methods
		private void Awake() {} // 0x00000001878ECE50-0x00000001878ECF04
		protected void GetSegmentIndexAndTime(float time, out int segmentIndex, out float segmentTime) {
			segmentIndex = default;
			segmentTime = default;
		} // 0x00000001878ECB58-0x00000001878ECC0C
		protected void PrepareForRuntime() {} // 0x00000001878ECF04-0x00000001878ECFB8
		protected void RecalcSegmentsLength() {} // 0x00000001878EC994-0x00000001878ECA70
		public abstract void AddVertexFirst(Vector3 position); // 0x00000001878EC3E8-0x00000001878EC610
		public abstract void AddVertexLast(Vector3 position); // 0x00000001878EC024-0x00000001878EC1A8
		public abstract void RemoveVertex(int index); // 0x00000001878ED170-0x00000001878ED310
		public abstract void Clear(); // 0x00000001878EC610-0x00000001878EC6D8
		public abstract void InsertBefore(int vertexIndex, Vector3 position); // 0x00000001878ECD88-0x00000001878ECE50
		public abstract void InsertAfter(int vertexIndex, Vector3 position); // 0x00000001878EC7A0-0x00000001878EC8A0
		public abstract Vector3 GetVertex(int vertexIndex); // 0x00000001878EC6D8-0x00000001878EC7A0
		public abstract void SetVertex(int vertexIndex, Vector3 position); // 0x00000001878ECCC0-0x00000001878ECD88
		public Vector3 EvalPosition(float time) => default; // 0x00000001878EC8A0-0x00000001878EC994
		public Vector3 EvalTangent(float time) => default; // 0x00000001878EC1A8-0x00000001878EC3E8
		public PositionTangent EvalPositionTangent(float time) => default; // 0x00000001878EBE88-0x00000001878EC024
		public void EvalPosition(float time, out Vector3 position) {
			position = default;
		} // 0x00000001878ECFB8-0x00000001878ED170
		public void EvalTangent(float time, out Vector3 tangent) {
			tangent = default;
		} // 0x00000001878EBDF4-0x00000001878EBE88
		public void EvalPositionTangent(float time, out PositionTangent positionTangent) {
			positionTangent = default;
		} // 0x00000001878ED3C8-0x00000001878ED690
		public void EvalFrame(float time, out CurveFrame frame) {
			frame = default;
		} // 0x00000001878ED3A0-0x00000001878ED3C8
		public float EvalCurvature(float time) => default; // 0x00000001878ED690-0x00000001878ED940
		public float EvalTorsion(float time) => default; // 0x00000001878E40C4-0x00000001878E4124
		public Vector3 EvalPositionParametrized(float length) => default; // 0x00000001878E47C0-0x00000001878E4838
		public Vector3 EvalTangentParametrized(float length) => default; // 0x00000001878E436C-0x00000001878E448C
		public PositionTangent EvalPositionTangentParametrized(float length) => default; // 0x00000001878E4124-0x00000001878E421C
		public void EvalPositionParametrized(float length, out Vector3 position) {
			position = default;
		} // 0x00000001878E448C-0x00000001878E4530
		public void EvalTangentParametrized(float length, out Vector3 tangent) {
			tangent = default;
		} // 0x00000001878E4744-0x00000001878E478C
		public void EvalPositionTangentParametrized(float length, out PositionTangent positionTangent) {
			positionTangent = default;
		} // 0x00000001878E4530-0x00000001878E462C
		public void EvalFrameParametrized(float length, out CurveFrame frame) {
			frame = default;
		} // 0x00000001878E462C-0x00000001878E4744
		public float EvalCurvatureParametrized(float length) => default; // 0x00000001878E421C-0x00000001878E42B8
		public float EvalTorsionParametrized(float length) => default; // 0x00000001878E42B8-0x00000001878E436C
		public float CalcTotalLength() => default; // 0x00000001878E478C-0x00000001878E47C0
		public float LengthToTime(float length, int iterations, float tolerance) => default; // 0x0000000185492010-0x0000000185492020
		public float LengthToTime(float length) => default; // 0x00000001878DF18C-0x00000001878DF25C
		public float ParametrizeByArcLength(int pointCount) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class PointsFilter // TypeDefIndex: 55959
	{
		// Nested types
		private class Data // TypeDefIndex: 55958
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
			public Data() {} // Dummy constructor
			public Data(Vector3[] points, float radius, Rand rand, AAB3 aab) {} // 0x00000001878E6D00-0x00000001878E6DB4
	
			// Methods
			private static int BinarySearch(List<int> array, int value) => default; // 0x00000001878E33EC-0x00000001878E3558
			private static int BinarySearch(int[] array, int length, int value) => default; // 0x00000001878E2C14-0x00000001878E2CD4
			private void CalcGridIndices(ref Vector3 point, out int i, out int j, out int k) {
				i = default;
				j = default;
				k = default;
			} // 0x00000001878E2B9C-0x00000001878E2C14
			public List<int> Filter() => default; // 0x00000001878E2CD4-0x00000001878E2D1C
		}
	
		// Methods
		public static List<int> DistanceFilter(Vector3[] points, AAB3 pointsAAB, float radius, Rand rand) => default; // 0x00000001878E2D1C-0x00000001878E33EC
	}

	public class PoissonDiskSampler // TypeDefIndex: 55961
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
		private int _MaxPoints_k__BackingField; // 0x74
	
		// Properties
		public int MaxPoints { get; set; } // 0x00000001878E70DC-0x00000001878E7108 0x00000001878E7108-0x00000001878E71A0
	
		// Nested types
		public delegate float PointDelegate(ref Vector2 point); // TypeDefIndex: 55960; 0x0000000185FB0840-0x0000000185FB0850
	
		// Constructors
		public PoissonDiskSampler() {} // Dummy constructor
		static PoissonDiskSampler() {} // 0x00000001878E6DB4-0x00000001878E70DC
		public PoissonDiskSampler(Rand rand, Vector2 minCorner, Vector2 maxCorner, float minDistanceOuter, float minDistanceInner = 1f /* Metadata: 0x0207C15D */) {} // 0x00000001878E71A0-0x00000001878E73A4
	
		// Methods
		private void CalcGridIndices(ref Vector2 point, out int i, out int j) {
			i = default;
			j = default;
		} // 0x00000001878E6C2C-0x00000001878E6D00
		private void InsertIntoGrid(ref Vector2 point, int index) {} // 0x00000001817C2F70-0x00000001817C2F80
		private bool AddPoint(ref Vector2 center) => default; // 0x00000001878E6BAC-0x00000001878E6C2C
		public List<Vector2> Sample() => default; // 0x000000018720A634-0x000000018720A660
	}

	public class WeightedSampler // TypeDefIndex: 55962
	{
		// Fields
		protected float[] _accum; // 0x10
		protected float _total; // 0x18
		protected Rand _rand; // 0x20
	
		// Constructors
		public WeightedSampler() {} // Dummy constructor
		protected WeightedSampler(Rand rand) {} // 0x000000018646EE40-0x000000018646EE50
		public WeightedSampler(float[] weights) {} // 0x00000001878EECF0-0x00000001878EED60
		public WeightedSampler(float[] weights, Rand rand) {} // 0x00000001878EECC4-0x00000001878EECF0
	
		// Methods
		protected static int BinarySearch(float[] array, float value) => default; // 0x00000001878EEB1C-0x00000001878EEB88
		protected void Init(float[] weights) {} // 0x00000001878EEB88-0x00000001878EEC84
		public int SampleIndex() => default; // 0x00000001878EEC84-0x00000001878EECC4
	}

	public class TrianglesSamplerBase : WeightedSampler // TypeDefIndex: 55963
	{
		// Fields
		protected Vector3[] _vertices; // 0x28
	
		// Constructors
		public TrianglesSamplerBase() {} // Dummy constructor
		protected TrianglesSamplerBase(Rand rand) {} // 0x000000018646EE40-0x000000018646EE50
	
		// Methods
		protected float CalclTriangleArea(ref Vector3 e0, ref Vector3 e1) => default; // 0x0000000185FB6630-0x0000000185FB66D0
	}

	public class IndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 55964
	{
		// Fields
		protected int[] _indices; // 0x30
	
		// Constructors
		public IndexedTrianglesSampler() {} // Dummy constructor
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices) {} // 0x00000001878E3EC4-0x00000001878E3F54
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices, Rand rand) {} // 0x00000001878E3F54-0x00000001878E3FAC
		public IndexedTrianglesSampler(Mesh mesh) {} // 0x00000001878E3FAC-0x00000001878E4054
		public IndexedTrianglesSampler(Mesh mesh, Rand rand) {} // 0x00000001878E4054-0x00000001878E40C4
	
		// Methods
		protected void Init() {} // 0x00000001878E3558-0x00000001878E3918
		public Vector3 Sample() => default; // 0x00000001878E3DB8-0x00000001878E3EC4
		public Vector3[] SampleArray(int count) => default; // 0x00000001878E3C50-0x00000001878E3DB8
		public Vector3[] SampleArray(int count, Vector2[] uvs, Texture2D sampleMap, float min = 0f /* Metadata: 0x0207C161 */, float max = 1f /* Metadata: 0x0207C165 */) => default; // 0x00000001878E3918-0x00000001878E3C50
	}

	public class NonIndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 55965
	{
		// Constructors
		public NonIndexedTrianglesSampler() {} // Dummy constructor
		public NonIndexedTrianglesSampler(Vector3[] vertices) {} // 0x00000001878E5134-0x00000001878E51AC
		public NonIndexedTrianglesSampler(Vector3[] vertices, Rand rand) {} // 0x00000001878E5020-0x00000001878E5054
		public NonIndexedTrianglesSampler(Mesh mesh) {} // 0x00000001878E5054-0x00000001878E50E0
		public NonIndexedTrianglesSampler(Mesh mesh, Rand rand) {} // 0x00000001878E50E0-0x00000001878E5134
	
		// Methods
		protected void Init() {} // 0x00000001878E4AFC-0x00000001878E4E30
		public Vector3 Sample() => default; // 0x00000001878E4F54-0x00000001878E5020
		public Vector3[] SampleArray(int count) => default; // 0x00000001878E4E30-0x00000001878E4F54
	}

	public class ShuffleBag<T> : IEnumerable<T> // TypeDefIndex: 55967
	{
		// Fields
		private Rand _rand;
		private List<T> _items;
		private int _index;
	
		// Properties
		public int Count { get => default; }
	
		// Nested types
		private sealed class _GetEnumerator_d__13 : IEnumerator<T> // TypeDefIndex: 55966
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public ShuffleBag<T> __4__this;
			private int _i_5__2;
			private int _len_5__3;
	
			// Properties
			T IEnumerator<T>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__13() {} // Dummy constructor
			public _GetEnumerator_d__13(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public ShuffleBag() {}
		public ShuffleBag(int capacity) {}
		public ShuffleBag(Rand rand) {}
		public ShuffleBag(Rand rand, int capacity) {}
	
		// Methods
		public void Add(T item, uint count = 1 /* Metadata: 0x0207C169 */) {}
		public T NextItem() => default;
		public void Reset() {}
		public void Clear() {}
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public static class Util // TypeDefIndex: 55968
	{
		// Methods
		public static void Shuffle<T>(IList<T> collection) {}
		public static void Shuffle<T>(IList<T> collection, Rand rand) {}
		public static void Shuffle<T>(T[] collection) {}
		public static void Shuffle<T>(T[] collection, Rand rand) {}
	}
}
