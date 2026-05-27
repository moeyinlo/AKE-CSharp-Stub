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

// Image 36: DestMath.dll - Assembly: DestMath, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54826-54977
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Dest.Math
{
	public class Polynomial // TypeDefIndex: 54827
	{
		// Fields
		private int _degree; // 0x10
		private float[] _coeffs; // 0x18
	
		// Properties
		public int Degree { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x0000000185703608-0x000000018570365C
		public float this[int index] { get => default; set {} } // 0x00000001857035D8-0x0000000185703608 0x000000018570365C-0x000000018570368C
	
		// Constructors
		public Polynomial() {} // Dummy constructor
		public Polynomial(int degree) {} // 0x00000001857035D0-0x00000001857035D8
	
		// Methods
		public Polynomial DeepCopy() => default; // 0x00000001857034CC-0x000000018570357C
		public Polynomial CalcDerivative() => default; // 0x0000000185703248-0x000000018570334C
		public Polynomial CalcInversion() => default; // 0x000000018570334C-0x0000000185703400
		public void Compress(float epsilon = 1E-05f /* Metadata: 0x01FD6794 */) {} // 0x0000000185703400-0x00000001857034CC
		public float Eval(float t) => default; // 0x000000018570357C-0x00000001857035D0
	}

	public static class Approximation // TypeDefIndex: 54828
	{
		// Methods
		public static Box2 GaussPointsFit2(IList<Vector2> points) => default; // 0x00000001856F5A74-0x00000001856F5E20
		internal static bool HeightLineFit2(IList<Vector2> points, out float a, out float b) {
			a = default;
			b = default;
			return default;
		} // 0x00000001856F6304-0x00000001856F65D4
		public static Line2 LeastSquaresLineFit2(IList<Vector2> points) => default; // 0x00000001856F6A6C-0x00000001856F6D58
		public static Box3 GaussPointsFit3(IList<Vector3> points) => default; // 0x00000001856F5E20-0x00000001856F6304
		public static Line3 LeastsSquaresLineFit3(IList<Vector3> points) => default; // 0x00000001856F7114-0x00000001856F7548
		internal static bool HeightPlaneFit3(IList<Vector3> points, out float a, out float b, out float c) {
			a = default;
			b = default;
			c = default;
			return default;
		} // 0x00000001856F65D4-0x00000001856F6A6C
		public static Plane3 LeastSquaresPlaneFit3(IList<Vector3> points) => default; // 0x00000001856F6D58-0x00000001856F7114
	}

	internal class ConcaveHull2 // TypeDefIndex: 54831
	{
		// Nested types
		private struct Edge // TypeDefIndex: 54829
		{
			// Fields
			public int V0; // 0x00
			public int V1; // 0x04
	
			// Constructors
			public Edge(int v0, int v1) {
				V0 = default;
				V1 = default;
			} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		}
	
		private struct InnerPoint // TypeDefIndex: 54830
		{
			// Fields
			public float AverageDistance; // 0x00
			public float Distance0; // 0x04
			public float Distance1; // 0x08
			public int Index; // 0x0C
		}
	
		// Constructors
		public ConcaveHull2() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private static bool _TryFastSort(InnerPoint[] x, int first, int last) => default; // 0x00000001856F82D4-0x00000001856F83A8
		private static void Quicksort(InnerPoint[] x, int first, int last) {} // 0x00000001856F8130-0x00000001856F82D4
		private static float CalcDistanceFromPointToEdge(ref Vector2 pointA, ref Vector2 v0, ref Vector2 v1) => default; // 0x00000001856F7548-0x00000001856F7658
		public static bool Create(Vector2[] points, out int[] concaveHull, int[] convexHull, float N, float epsilon = 1E-05f /* Metadata: 0x01FD6798 */) {
			concaveHull = default;
			return default;
		} // 0x00000001856F7658-0x00000001856F8130
	}

	public static class ConcaveHull // TypeDefIndex: 54832
	{
		// Methods
		public static bool Create2D(Vector2[] points, out int[] concaveHull, out int[] convexHull, float algorithmThreshold, float epsilon = 1E-05f /* Metadata: 0x01FD679C */) {
			concaveHull = default;
			convexHull = default;
			return default;
		} // 0x00000001856F83D0-0x00000001856F851C
		public static bool Create2D(Vector2[] points, out int[] concaveHull, float algorithmThreshold, float epsilon = 1E-05f /* Metadata: 0x01FD67A0 */) {
			concaveHull = default;
			return default;
		} // 0x00000001856F83A8-0x00000001856F83D0
	}

	internal class ConvexHull1 // TypeDefIndex: 54835
	{
		// Nested types
		private class SortedVertex // TypeDefIndex: 54833
		{
			// Fields
			public float Value; // 0x10
			public int Index; // 0x14
	
			// Constructors
			public SortedVertex() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public ConvexHull1() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void Create(float[] vertices, float epsilon, out int dimension, out int[] indices) {
			dimension = default;
			indices = default;
		} // 0x00000001856F851C-0x00000001856F87D4
	}

	internal class ConvexHull2 // TypeDefIndex: 54837
	{
		// Nested types
		private class Edge // TypeDefIndex: 54836
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
			public Edge(int v0, int v1) {} // 0x0000000183D52550-0x0000000183D52560
	
			// Methods
			public int GetSign(int i, Query2 query) => default; // 0x00000001857031AC-0x00000001857031F0
			public void Insert(Edge adj0, Edge adj1) {} // 0x00000001857031F0-0x0000000185703248
			public void DeleteSelf() {} // 0x00000001857030C8-0x0000000185703108
			public void GetIndices(out int[] indices) {
				indices = default;
			} // 0x0000000185703108-0x00000001857031AC
		}
	
		// Constructors
		public ConvexHull2() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool Create(IList<Vector2> vertices, float epsilon, out int dimension, out int[] indices) {
			dimension = default;
			indices = default;
			return default;
		} // 0x00000001856F87D4-0x00000001856F8C88
		private static bool Update(ref Edge hull, int i, Query2 query) => default; // 0x00000001856F8C88-0x00000001856F8E60
	}

	internal class ConvexHull3 // TypeDefIndex: 54840
	{
		// Nested types
		private class Triangle // TypeDefIndex: 54838
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
			public Triangle(int v0, int v1, int v2) {} // 0x0000000183D52560-0x0000000183D52580
	
			// Methods
			public Triangle GetAdj(int index) => default; // 0x0000000185703794-0x00000001857037AC
			public void SetAdj(int index, Triangle value) {} // 0x000000018570380C-0x000000018570383C
			public int GetV(int index) => default; // 0x00000001857037F4-0x000000018570380C
			public int GetSign(int i, Query3 query) => default; // 0x00000001857037AC-0x00000001857037F4
			public void AttachTo(Triangle adj0, Triangle adj1, Triangle adj2) {} // 0x00000001857036C0-0x00000001857036F8
			public int DetachFrom(int adjIndex, Triangle adj) => default; // 0x00000001857036F8-0x0000000185703794
		}
	
		private class TerminatorData // TypeDefIndex: 54839
		{
			// Fields
			public int V0; // 0x10
			public int V1; // 0x14
			public int NullIndex; // 0x18
			public Triangle T; // 0x20
	
			// Constructors
			public TerminatorData() {} // Dummy constructor
			public TerminatorData(int v0 = -1 /* Metadata: 0x01FD67A4 */, int v1 = -1 /* Metadata: 0x01FD67A5 */, int nullIndex = -1 /* Metadata: 0x01FD67A6 */, Triangle tri = null) {} // 0x000000018570368C-0x00000001857036C0
		}
	
		// Constructors
		public ConvexHull3() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool Create(IList<Vector3> vertices, float epsilon, out int dimension, out int[] indices) {
			dimension = default;
			indices = default;
			return default;
		} // 0x00000001856F8E60-0x00000001856F9654
		private static bool Update(HashSet<Triangle> hull, int i, Query3 query) => default; // 0x00000001856F986C-0x00000001856FA1F4
		private static void ExtractIndices(HashSet<Triangle> hull, out int[] indices) {
			indices = default;
		} // 0x00000001856F9654-0x00000001856F986C
	}

	public static class ConvexHull // TypeDefIndex: 54841
	{
		// Methods
		public static bool Create2D(IList<Vector2> points, out int[] indices, out int dimension, float epsilon = 1E-05f /* Metadata: 0x01FD67A7 */) {
			indices = default;
			dimension = default;
			return default;
		} // 0x00000001856FA1F4-0x00000001856FA294
		public static bool Create3D(IList<Vector3> points, out int[] indices, out int dimension, float epsilon = 1E-05f /* Metadata: 0x01FD67AB */) {
			indices = default;
			dimension = default;
			return default;
		} // 0x00000001856FA294-0x00000001856FA334
	}

	public static class Distance // TypeDefIndex: 54842
	{
		// Methods
		public static float Line2Line2(ref Line2 line0, ref Line2 line1) => default; // 0x00000001856FB9CC-0x00000001856FB9F4
		public static float Line2Line2(ref Line2 line0, ref Line2 line1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FB9F4-0x00000001856FBA24
		public static float SqrLine2Line2(ref Line2 line0, ref Line2 line1) => default; // 0x00000001856FCCBC-0x00000001856FCDD4
		public static float SqrLine2Line2(ref Line2 line0, ref Line2 line1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FCDD4-0x00000001856FD000
		public static float Line2Ray2(ref Line2 line, ref Ray2 ray) => default; // 0x00000001856FBA24-0x00000001856FBA4C
		public static float Line2Ray2(ref Line2 line, ref Ray2 ray, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FBA4C-0x00000001856FBA7C
		public static float SqrLine2Ray2(ref Line2 line, ref Ray2 ray) => default; // 0x00000001856FD000-0x00000001856FD18C
		public static float SqrLine2Ray2(ref Line2 line, ref Ray2 ray, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FD18C-0x00000001856FD3E8
		public static float Line2Segment2(ref Line2 line, ref Segment2 segment) => default; // 0x00000001856FBAAC-0x00000001856FBAD4
		public static float Line2Segment2(ref Line2 line, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FBA7C-0x00000001856FBAAC
		public static float SqrLine2Segment2(ref Line2 line, ref Segment2 segment) => default; // 0x00000001856FD3E8-0x00000001856FD618
		public static float SqrLine2Segment2(ref Line2 line, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FD618-0x00000001856FD8E8
		public static float Point2AAB2(ref Vector2 point, ref AAB2 box) => default; // 0x00000001856FBD24-0x00000001856FBD98
		public static float Point2AAB2(ref Vector2 point, ref AAB2 box, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FBC68-0x00000001856FBD24
		public static float SqrPoint2AAB2(ref Vector2 point, ref AAB2 box) => default; // 0x00000001856FE9C0-0x00000001856FEA30
		public static float SqrPoint2AAB2(ref Vector2 point, ref AAB2 box, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FEA30-0x00000001856FEAE8
		public static float Point2Box2(ref Vector2 point, ref Box2 box) => default; // 0x00000001856FBDC0-0x00000001856FBDE8
		public static float Point2Box2(ref Vector2 point, ref Box2 box, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FBD98-0x00000001856FBDC0
		public static float SqrPoint2Box2(ref Vector2 point, ref Box2 box) => default; // 0x00000001856FEAE8-0x00000001856FEC00
		public static float SqrPoint2Box2(ref Vector2 point, ref Box2 box, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FEC00-0x00000001856FEDC0
		public static float Point2Circle2(ref Vector2 point, ref Circle2 circle) => default; // 0x00000001856FBE98-0x00000001856FBED4
		public static float Point2Circle2(ref Vector2 point, ref Circle2 circle, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FBDE8-0x00000001856FBE98
		public static float SqrPoint2Circle2(ref Vector2 point, ref Circle2 circle) => default; // 0x00000001856FEE74-0x00000001856FEEB4
		public static float SqrPoint2Circle2(ref Vector2 point, ref Circle2 circle, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FEDC0-0x00000001856FEE74
		public static float Point2Line2(ref Vector2 point, ref Line2 line) => default; // 0x00000001856FBEFC-0x00000001856FBF24
		public static float Point2Line2(ref Vector2 point, ref Line2 line, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FBED4-0x00000001856FBEFC
		public static float SqrPoint2Line2(ref Vector2 point, ref Line2 line) => default; // 0x00000001856FEF98-0x00000001856FF06C
		public static float SqrPoint2Line2(ref Vector2 point, ref Line2 line, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FEEB4-0x00000001856FEF98
		public static float Point2Ray2(ref Vector2 point, ref Ray2 ray) => default; // 0x00000001856FBF24-0x00000001856FBF4C
		public static float Point2Ray2(ref Vector2 point, ref Ray2 ray, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FBF4C-0x00000001856FBF74
		public static float SqrPoint2Ray2(ref Vector2 point, ref Ray2 ray) => default; // 0x00000001856FF178-0x00000001856FF264
		public static float SqrPoint2Ray2(ref Vector2 point, ref Ray2 ray, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FF06C-0x00000001856FF178
		public static float Point2Segment2(ref Vector2 point, ref Segment2 segment) => default; // 0x00000001856FBF74-0x00000001856FBF9C
		public static float Point2Segment2(ref Vector2 point, ref Segment2 segment, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FBF9C-0x00000001856FBFC4
		public static float SqrPoint2Segment2(ref Vector2 point, ref Segment2 segment) => default; // 0x00000001856FF398-0x00000001856FF4C0
		public static float SqrPoint2Segment2(ref Vector2 point, ref Segment2 segment, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FF264-0x00000001856FF398
		public static float Point2Triangle2(ref Vector2 point, ref Triangle2 triangle) => default; // 0x00000001856FBFC4-0x00000001856FC12C
		public static float Point2Triangle2(ref Vector2 point, ref Triangle2 triangle, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC12C-0x00000001856FC2E4
		public static float SqrPoint2Triangle2(ref Vector2 point, ref Triangle2 triangle) => default; // 0x00000001856FF4C0-0x00000001856FF628
		public static float SqrPoint2Triangle2(ref Vector2 point, ref Triangle2 triangle, out Vector2 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FF628-0x00000001856FF7E0
		public static float Ray2Ray2(ref Ray2 ray0, ref Ray2 ray1) => default; // 0x00000001856FCA0C-0x00000001856FCA4C
		public static float Ray2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FC9DC-0x00000001856FCA0C
		public static float SqrRay2Ray2(ref Ray2 ray0, ref Ray2 ray1) => default; // 0x0000000185701688-0x00000001857016B4
		public static float SqrRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x0000000185701398-0x0000000185701688
		public static float Ray2Segment2(ref Ray2 ray, ref Segment2 segment) => default; // 0x00000001856FCA4C-0x00000001856FCA8C
		public static float Ray2Segment2(ref Ray2 ray, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FCA8C-0x00000001856FCABC
		public static float SqrRay2Segment2(ref Ray2 ray, ref Segment2 segment) => default; // 0x0000000185701A18-0x0000000185701A44
		public static float SqrRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001857016B4-0x0000000185701A18
		public static float Segment2Segment2(ref Segment2 segment0, ref Segment2 segment1) => default; // 0x00000001856FCBB4-0x00000001856FCBF4
		public static float Segment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FCB84-0x00000001856FCBB4
		public static float SqrSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1) => default; // 0x0000000185702324-0x0000000185702350
		public static float SqrSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Vector2 closestPoint0, out Vector2 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x0000000185702350-0x00000001857028D4
		private static void Face(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref Vector3 PmE, ref float sqrDistance) {} // 0x00000001856FABA0-0x00000001856FB9CC
		private static void CaseNoZeros(ref Box3 mBox, ref float mLineParameter, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance) {} // 0x00000001856FAAC0-0x00000001856FABA0
		private static void Case0(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance) {} // 0x00000001856FA65C-0x00000001856FAAC0
		private static void Case00(ref Box3 mBox, ref float mLineParameter, int i0, int i1, int i2, ref Vector3 pnt, ref Vector3 dir, ref float sqrDistance) {} // 0x00000001856FA44C-0x00000001856FA65C
		private static void Case000(ref Box3 mBox, ref float mLineParameter, ref Vector3 pnt, ref float sqrDistance) {} // 0x00000001856FA334-0x00000001856FA44C
		public static float Line3Box3(ref Line3 line, ref Box3 box, out Line3Box3Dist info) {
			info = default;
			return default;
		} // 0x00000001856FBAD4-0x00000001856FBAFC
		public static float Line3Box3(ref Line3 line, ref Box3 box) => default; // 0x00000001856FBAFC-0x00000001856FBB3C
		public static float SqrLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Dist info) {
			info = default;
			return default;
		} // 0x00000001856FD8E8-0x00000001856FDEA0
		public static float SqrLine3Box3(ref Line3 line, ref Box3 box) => default; // 0x00000001856FDEA0-0x00000001856FDECC
		public static float Line3Line3(ref Line3 line0, ref Line3 line1) => default; // 0x00000001856FBB3C-0x00000001856FBB70
		public static float Line3Line3(ref Line3 line0, ref Line3 line1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FBB70-0x00000001856FBBA0
		public static float SqrLine3Line3(ref Line3 line0, ref Line3 line1) => default; // 0x00000001856FDECC-0x00000001856FDF00
		public static float SqrLine3Line3(ref Line3 line0, ref Line3 line1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FDF00-0x00000001856FE250
		public static float Line3Ray3(ref Line3 line, ref Ray3 ray) => default; // 0x00000001856FBBA0-0x00000001856FBBD4
		public static float Line3Ray3(ref Line3 line, ref Ray3 ray, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FBBD4-0x00000001856FBC04
		public static float SqrLine3Ray3(ref Line3 line, ref Ray3 ray) => default; // 0x00000001856FE590-0x00000001856FE5C4
		public static float SqrLine3Ray3(ref Line3 line, ref Ray3 ray, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FE250-0x00000001856FE590
		public static float Line3Segment3(ref Line3 line, ref Segment3 segment) => default; // 0x00000001856FBC04-0x00000001856FBC38
		public static float Line3Segment3(ref Line3 line, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FBC38-0x00000001856FBC68
		public static float SqrLine3Segment3(ref Line3 line, ref Segment3 segment) => default; // 0x00000001856FE5C4-0x00000001856FE5F8
		public static float SqrLine3Segment3(ref Line3 line, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FE5F8-0x00000001856FE9C0
		public static float Point3AAB3(ref Vector3 point, ref AAB3 box) => default; // 0x00000001856FC2E4-0x00000001856FC388
		public static float Point3AAB3(ref Vector3 point, ref AAB3 box, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC388-0x00000001856FC498
		public static float SqrPoint3AAB3(ref Vector3 point, ref AAB3 box) => default; // 0x00000001856FF8EC-0x00000001856FF98C
		public static float SqrPoint3AAB3(ref Vector3 point, ref AAB3 box, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FF7E0-0x00000001856FF8EC
		public static float Point3Box3(ref Vector3 point, ref Box3 box) => default; // 0x00000001856FC4C0-0x00000001856FC4E8
		public static float Point3Box3(ref Vector3 point, ref Box3 box, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC498-0x00000001856FC4C0
		public static float SqrPoint3Box3(ref Vector3 point, ref Box3 box) => default; // 0x00000001856FF98C-0x00000001856FFB68
		public static float SqrPoint3Box3(ref Vector3 point, ref Box3 box, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FFB68-0x00000001856FFEB8
		public static float Point3Circle3(ref Vector3 point, ref Circle3 circle, bool solid = true /* Metadata: 0x01FD67AF */) => default; // 0x00000001856FC518-0x00000001856FC558
		public static float Point3Circle3(ref Vector3 point, ref Circle3 circle, out Vector3 closestPoint, bool solid = true /* Metadata: 0x01FD67B0 */) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC4E8-0x00000001856FC518
		public static float SqrPoint3Circle3(ref Vector3 point, ref Circle3 circle, bool solid = true /* Metadata: 0x01FD67B1 */) => default; // 0x00000001857002B0-0x00000001857002D8
		public static float SqrPoint3Circle3(ref Vector3 point, ref Circle3 circle, out Vector3 closestPoint, bool solid = true /* Metadata: 0x01FD67B2 */) {
			closestPoint = default;
			return default;
		} // 0x00000001856FFEB8-0x00000001857002B0
		public static float Point3Line3(ref Vector3 point, ref Line3 line) => default; // 0x00000001856FC558-0x00000001856FC580
		public static float Point3Line3(ref Vector3 point, ref Line3 line, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC580-0x00000001856FC5A8
		public static float SqrPoint3Line3(ref Vector3 point, ref Line3 line) => default; // 0x0000000185700454-0x00000001857005C8
		public static float SqrPoint3Line3(ref Vector3 point, ref Line3 line, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001857002D8-0x0000000185700454
		public static float Point3Plane3(ref Vector3 point, ref Plane3 plane) => default; // 0x00000001856FC6C4-0x00000001856FC764
		public static float Point3Plane3(ref Vector3 point, ref Plane3 plane, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC5A8-0x00000001856FC6C4
		public static float SqrPoint3Plane3(ref Vector3 point, ref Plane3 plane) => default; // 0x00000001857006E0-0x0000000185700780
		public static float SqrPoint3Plane3(ref Vector3 point, ref Plane3 plane, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001857005C8-0x00000001857006E0
		public static float Point3Ray3(ref Vector3 point, ref Ray3 ray) => default; // 0x00000001856FC78C-0x00000001856FC7B4
		public static float Point3Ray3(ref Vector3 point, ref Ray3 ray, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC764-0x00000001856FC78C
		public static float SqrPoint3Ray3(ref Vector3 point, ref Ray3 ray) => default; // 0x0000000185700924-0x0000000185700AA4
		public static float SqrPoint3Ray3(ref Vector3 point, ref Ray3 ray, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x0000000185700780-0x0000000185700924
		public static float Point3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle) => default; // 0x00000001856FC7DC-0x00000001856FC804
		public static float Point3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC7B4-0x00000001856FC7DC
		public static float SqrPoint3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle) => default; // 0x0000000185700D08-0x0000000185700EA8
		public static float SqrPoint3Rectangle3(ref Vector3 point, ref Rectangle3 rectangle, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x0000000185700AA4-0x0000000185700D08
		public static float Point3Segment3(ref Vector3 point, ref Segment3 segment) => default; // 0x00000001856FC82C-0x00000001856FC854
		public static float Point3Segment3(ref Vector3 point, ref Segment3 segment, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC804-0x00000001856FC82C
		public static float SqrPoint3Segment3(ref Vector3 point, ref Segment3 segment) => default; // 0x0000000185701068-0x0000000185701208
		public static float SqrPoint3Segment3(ref Vector3 point, ref Segment3 segment, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x0000000185700EA8-0x0000000185701068
		public static float Point3Sphere3(ref Vector3 point, ref Sphere3 sphere) => default; // 0x00000001856FC968-0x00000001856FC9DC
		public static float Point3Sphere3(ref Vector3 point, ref Sphere3 sphere, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x00000001856FC854-0x00000001856FC968
		public static float SqrPoint3Sphere3(ref Vector3 point, ref Sphere3 sphere) => default; // 0x0000000185701208-0x0000000185701280
		public static float SqrPoint3Sphere3(ref Vector3 point, ref Sphere3 sphere, out Vector3 closestPoint) {
			closestPoint = default;
			return default;
		} // 0x0000000185701280-0x0000000185701398
		public static float Ray3Ray3(ref Ray3 ray0, ref Ray3 ray1) => default; // 0x00000001856FCAEC-0x00000001856FCB20
		public static float Ray3Ray3(ref Ray3 ray0, ref Ray3 ray1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FCABC-0x00000001856FCAEC
		public static float SqrRay3Ray3(ref Ray3 ray0, ref Ray3 ray1) => default; // 0x0000000185701E74-0x0000000185701EA8
		public static float SqrRay3Ray3(ref Ray3 ray0, ref Ray3 ray1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x0000000185701A44-0x0000000185701E74
		public static float Ray3Segment3(ref Ray3 ray, ref Segment3 segment) => default; // 0x00000001856FCB50-0x00000001856FCB84
		public static float Ray3Segment3(ref Ray3 ray, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FCB20-0x00000001856FCB50
		public static float SqrRay3Segment3(ref Ray3 ray, ref Segment3 segment) => default; // 0x00000001857022F0-0x0000000185702324
		public static float SqrRay3Segment3(ref Ray3 ray, ref Segment3 segment, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x0000000185701EA8-0x00000001857022F0
		public static float Segment3Box3(ref Segment3 segment, ref Box3 box, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FCBF4-0x00000001856FCC24
		public static float Segment3Box3(ref Segment3 segment, ref Box3 box) => default; // 0x00000001856FCC24-0x00000001856FCC58
		public static float SqrSegment3Box3(ref Segment3 segment, ref Box3 box, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x0000000185702908-0x0000000185702A0C
		public static float SqrSegment3Box3(ref Segment3 segment, ref Box3 box) => default; // 0x00000001857028D4-0x0000000185702908
		public static float Segment3Segment3(ref Segment3 segment0, ref Segment3 segment1) => default; // 0x00000001856FCC88-0x00000001856FCCBC
		public static float Segment3Segment3(ref Segment3 segment0, ref Segment3 segment1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x00000001856FCC58-0x00000001856FCC88
		public static float SqrSegment3Segment3(ref Segment3 segment0, ref Segment3 segment1) => default; // 0x0000000185702A0C-0x0000000185702A40
		public static float SqrSegment3Segment3(ref Segment3 segment0, ref Segment3 segment1, out Vector3 closestPoint0, out Vector3 closestPoint1) {
			closestPoint0 = default;
			closestPoint1 = default;
			return default;
		} // 0x0000000185702A40-0x00000001857030C8
	}

	public struct Line3Box3Dist // TypeDefIndex: 54843
	{
		// Fields
		public Vector3 ClosestPoint0; // 0x00
		public Vector3 ClosestPoint1; // 0x0C
		public float LineParameter; // 0x18
	}

	public static class Intersection // TypeDefIndex: 54844
	{
		// Fields
		private static float _intervalThreshold; // 0x00
		private static float _dotThreshold; // 0x04
		private static float _distanceThreshold; // 0x08
	
		// Properties
		public static float IntervalThreshold { get; set; } // 0x0000000185716E88-0x0000000185716ED8 0x0000000185717008-0x000000018571709C
		public static float DotThreshold { get; set; } // 0x0000000185716E38-0x0000000185716E88 0x0000000185716F70-0x0000000185717008
		public static float DistanceThreshold { get; set; } // 0x0000000185716DE8-0x0000000185716E38 0x0000000185716ED8-0x0000000185716F70
	
		// Constructors
		static Intersection() {} // 0x0000000183D20950-0x0000000183D209C0
	
		// Methods
		public static bool TestAAB2AAB2(ref AAB2 box0, ref AAB2 box1) => default; // 0x000000018570F998-0x000000018570F9C8
		public static bool FindAAB2AAB2(ref AAB2 box0, ref AAB2 box1, out AAB2 intersection) {
			intersection = default;
			return default;
		} // 0x000000018570636C-0x00000001857063F8
		public static bool TestAAB2AAB2OverlapX(ref AAB2 box0, ref AAB2 box1) => default; // 0x000000018570F960-0x000000018570F97C
		public static bool TestAAB2AAB2OverlapY(ref AAB2 box0, ref AAB2 box1) => default; // 0x000000018570F97C-0x000000018570F998
		public static bool TestAAB2Circle2(ref AAB2 box, ref Circle2 circle) => default; // 0x0000000182EE72E0-0x0000000182EE7350
		public static bool TestBox2Box2(ref Box2 box0, ref Box2 box1) => default; // 0x000000018570FA64-0x000000018570FD34
		public static bool TestBox2Circle2(ref Box2 box, ref Circle2 circle) => default; // 0x000000018570FD34-0x000000018570FE6C
		public static bool TestCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1) => default; // 0x0000000185710098-0x00000001857100E8
		public static bool FindCircle2Circle2(ref Circle2 circle0, ref Circle2 circle1, out Circle2Circle2Intr info) {
			info = default;
			return default;
		} // 0x00000001857064E4-0x000000018570673C
		private static int WhichSide(Polygon2 V, Vector2 P, ref Vector2 D) => default; // 0x0000000185716AE4-0x0000000185716C14
		public static bool TestConvexPolygon2ConvexPolygon2(Polygon2 convexPolygon0, Polygon2 convexPolygon1) => default; // 0x00000001857100E8-0x00000001857102E0
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref AAB2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x000000018570608C-0x000000018570636C
		public static bool TestLine2AAB2(ref Line2 line, ref AAB2 box) => default; // 0x00000001857102E0-0x0000000185710438
		public static bool FindLine2AAB2(ref Line2 line, ref AAB2 box, out Line2AAB2Intr info) {
			info = default;
			return default;
		} // 0x000000018570673C-0x00000001857067D8
		private static bool Clip(float denom, float numer, ref float t0, ref float t1) => default; // 0x0000000185704F40-0x0000000185704FA0
		private static bool DoClipping(float t0, float t1, ref Vector2 origin, ref Vector2 direction, ref Box2 box, bool solid, out int quantity, out Vector2 point0, out Vector2 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x0000000185705730-0x0000000185705A94
		public static bool TestLine2Box2(ref Line2 line, ref Box2 box) => default; // 0x0000000185710438-0x0000000185710528
		public static bool FindLine2Box2(ref Line2 line, ref Box2 box, out Line2Box2Intr info) {
			info = default;
			return default;
		} // 0x00000001857067D8-0x0000000185706874
		private static bool Find(ref Vector2 origin, ref Vector2 direction, ref Vector2 center, float radius, out int rootCount, out float t0, out float t1) {
			rootCount = default;
			t0 = default;
			t1 = default;
			return default;
		} // 0x000000018570E714-0x000000018570E86C
		public static bool TestLine2Circle2(ref Line2 line, ref Circle2 circle) => default; // 0x0000000185710528-0x00000001857105B0
		public static bool FindLine2Circle2(ref Line2 line, ref Circle2 circle, out Line2Circle2Intr info) {
			info = default;
			return default;
		} // 0x0000000185706874-0x0000000185706A20
		public static bool TestLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon) => default; // 0x00000001857105B0-0x00000001857106BC
		public static bool FindLine2ConvexPolygon2(ref Line2 line, Polygon2 convexPolygon, out Line2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x0000000185706A20-0x0000000185706D6C
		private static IntersectionTypes Classify(ref Line2 line0, ref Line2 line1, out float s0) {
			s0 = default;
			return default;
		} // 0x0000000185703B50-0x0000000185703D18
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185710718-0x0000000185710788
		public static bool TestLine2Line2(ref Line2 line0, ref Line2 line1) => default; // 0x00000001857106BC-0x0000000185710718
		public static bool FindLine2Line2(ref Line2 line0, ref Line2 line1, out Line2Line2Intr info) {
			info = default;
			return default;
		} // 0x0000000185706D6C-0x0000000185706E40
		private static IntersectionTypes Classify(ref Line2 line, ref Ray2 ray, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x000000018570429C-0x00000001857044A4
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001857107E4-0x000000018571089C
		public static bool TestLine2Ray2(ref Line2 line, ref Ray2 ray) => default; // 0x0000000185710788-0x00000001857107E4
		public static bool FindLine2Ray2(ref Line2 line, ref Ray2 ray, out Line2Ray2Intr info) {
			info = default;
			return default;
		} // 0x0000000185706E40-0x0000000185706F80
		private static IntersectionTypes Classify(ref Segment2 segment, ref Line2 line, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x00000001857044A4-0x00000001857046BC
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001857108F8-0x0000000185710994
		public static bool TestLine2Segment2(ref Line2 line, ref Segment2 segment) => default; // 0x000000018571089C-0x00000001857108F8
		public static bool FindLine2Segment2(ref Line2 line, ref Segment2 segment, out Line2Segment2Intr info) {
			info = default;
			return default;
		} // 0x0000000185706F80-0x00000001857070A4
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
		} // 0x000000018571664C-0x00000001857168D4
		private static bool GetInterval(ref Vector2 origin, ref Vector2 direction, ref Triangle2 triangle, float dist0, float dist1, float dist2, int sign0, int sign1, int sign2, out float param0, out float param1) {
			param0 = default;
			param1 = default;
			return default;
		} // 0x000000018570EE84-0x000000018570F0F0
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185710994-0x0000000185710B5C
		public static bool TestLine2Triangle2(ref Line2 line, ref Triangle2 triangle) => default; // 0x0000000185710B5C-0x0000000185710BB8
		public static bool FindLine2Triangle2(ref Line2 line, ref Triangle2 triangle, out Line2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x00000001857070A4-0x0000000185707344
		public static bool TestRay2AAB2(ref Ray2 ray, ref AAB2 box) => default; // 0x0000000185711EE0-0x0000000185712008
		public static bool FindRay2AAB2(ref Ray2 ray, ref AAB2 box, out Ray2AAB2Intr info) {
			info = default;
			return default;
		} // 0x0000000185708FD8-0x0000000185709070
		public static bool TestRay2Box2(ref Ray2 ray, ref Box2 box) => default; // 0x0000000185712008-0x00000001857121F4
		public static bool FindRay2Box2(ref Ray2 ray, ref Box2 box, out Ray2Box2Intr info) {
			info = default;
			return default;
		} // 0x0000000185709070-0x0000000185709108
		public static bool TestRay2Circle2(ref Ray2 ray, ref Circle2 circle) => default; // 0x00000001857121F4-0x0000000185712288
		public static bool FindRay2Circle2(ref Ray2 ray, ref Circle2 circle, out Ray2Circle2Intr info) {
			info = default;
			return default;
		} // 0x0000000185709108-0x00000001857092E4
		public static bool TestRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon) => default; // 0x0000000185712288-0x0000000185712394
		public static bool FindRay2ConvexPolygon2(ref Ray2 ray, Polygon2 convexPolygon, out Ray2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001857092E4-0x000000018570962C
		public static bool TestRay2Polygon2(ref Ray2 ray, Polygon2 polygon) => default; // 0x0000000185712394-0x00000001857124A0
		public static bool TestRay2Polygon2(ref Ray2 ray, Segment2[] segments) => default; // 0x00000001857124A0-0x0000000185712540
		public static bool FindRay2Polygon2(ref Ray2 ray, Polygon2 polygon, out Ray2Polygon2Intr info) {
			info = default;
			return default;
		} // 0x00000001857097A8-0x00000001857099A0
		public static bool FindRay2Polygon2(ref Ray2 ray, Segment2[] segments, out Ray2Polygon2Intr info) {
			info = default;
			return default;
		} // 0x000000018570962C-0x00000001857097A8
		private static IntersectionTypes Classify(ref Ray2 ray0, ref Ray2 ray1, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x000000018570390C-0x0000000185703B50
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185712540-0x000000018571269C
		public static bool TestRay2Ray2(ref Ray2 ray0, ref Ray2 ray1) => default; // 0x000000018571269C-0x00000001857126F8
		public static bool FindRay2Ray2(ref Ray2 ray0, ref Ray2 ray1, out Ray2Ray2Intr info) {
			info = default;
			return default;
		} // 0x00000001857099A0-0x0000000185709BA4
		private static IntersectionTypes Classify(ref Ray2 ray, ref Segment2 segment, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x0000000185703FF0-0x000000018570429C
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185712754-0x00000001857128A0
		public static bool TestRay2Segment2(ref Ray2 ray, ref Segment2 segment) => default; // 0x00000001857126F8-0x0000000185712754
		public static bool FindRay2Segment2(ref Ray2 ray, ref Segment2 segment, out Ray2Segment2Intr info) {
			info = default;
			return default;
		} // 0x0000000185709BA4-0x0000000185709DB4
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001857128A0-0x0000000185712A64
		public static bool TestRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle) => default; // 0x0000000185712A64-0x0000000185712AC0
		public static bool FindRay2Triangle2(ref Ray2 ray, ref Triangle2 triangle, out Ray2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x0000000185709DB4-0x000000018570A050
		public static bool TestSegment2AAB2(ref Segment2 segment, ref AAB2 box) => default; // 0x0000000185713B2C-0x0000000185713C6C
		public static bool FindSegment2AAB2(ref Segment2 segment, ref AAB2 box, out Segment2AAB2Intr info) {
			info = default;
			return default;
		} // 0x000000018570B558-0x000000018570B618
		public static bool TestSegment2Box2(ref Segment2 segment, ref Box2 box) => default; // 0x0000000185713C6C-0x0000000185713E6C
		public static bool FindSegment2Box2(ref Segment2 segment, ref Box2 box, out Segment2Box2Intr info) {
			info = default;
			return default;
		} // 0x000000018570B618-0x000000018570B6D8
		public static bool TestSegment2Circle2(ref Segment2 segment, ref Circle2 circle) => default; // 0x0000000185713E6C-0x0000000185713F40
		public static bool FindSegment2Circle2(ref Segment2 segment, ref Circle2 circle, out Segment2Circle2Intr info) {
			info = default;
			return default;
		} // 0x000000018570B6D8-0x000000018570B940
		public static bool TestSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon) => default; // 0x0000000185713F40-0x0000000185713FA4
		public static bool FindSegment2ConvexPolygon2(ref Segment2 segment, Polygon2 convexPolygon, out Segment2ConvexPolygon2Intr info) {
			info = default;
			return default;
		} // 0x000000018570B940-0x000000018570BC84
		private static IntersectionTypes Classify(ref Segment2 segment0, ref Segment2 segment1, out float s0, out float s1) {
			s0 = default;
			s1 = default;
			return default;
		} // 0x0000000185703D18-0x0000000185703FF0
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185714000-0x0000000185714164
		public static bool TestSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1) => default; // 0x0000000185713FA4-0x0000000185714000
		public static bool FindSegment2Segment2(ref Segment2 segment0, ref Segment2 segment1, out Segment2Segment2Intr info) {
			info = default;
			return default;
		} // 0x000000018570BC84-0x000000018570BFA0
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001857141C0-0x00000001857143A8
		public static bool TestSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle) => default; // 0x0000000185714164-0x00000001857141C0
		public static bool FindSegment2Triangle2(ref Segment2 segment, ref Triangle2 triangle, out Segment2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x000000018570BFA0-0x000000018570C2B0
		private static int WhichSide(ref Triangle2 triangle, ref Vector2 P, ref Vector2 D) => default; // 0x0000000185716C14-0x0000000185716DE8
		private static void ClipConvexPolygonAgainstLine(ref Vector2 edgeStart, ref Vector2 edgeEnd, ref int quantity, ref Triangle2Triangle2Intr info) {} // 0x00000001857046BC-0x0000000185704F40
		public static bool TestTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1) => default; // 0x00000001857154F0-0x000000018571573C
		public static bool FindTriangle2Triangle2(ref Triangle2 triangle0, ref Triangle2 triangle1, out Triangle2Triangle2Intr info) {
			info = default;
			return default;
		} // 0x000000018570DCD4-0x000000018570DE1C
		public static bool TestAAB3AAB3(ref AAB3 box0, ref AAB3 box1) => default; // 0x000000018570FA1C-0x000000018570FA64
		public static bool FindAAB3AAB3(ref AAB3 box0, ref AAB3 box1, out AAB3 intersection) {
			intersection = default;
			return default;
		} // 0x00000001857063F8-0x00000001857064E4
		public static bool TestAAB3AAB3OverlapX(ref AAB3 box0, ref AAB3 box1) => default; // 0x000000018570F9C8-0x000000018570F9E4
		public static bool TestAAB3AAB3OverlapY(ref AAB3 box0, ref AAB3 box1) => default; // 0x000000018570F9E4-0x000000018570FA00
		public static bool TestAAB3AAB3OverlapZ(ref AAB3 box0, ref AAB3 box1) => default; // 0x000000018570FA00-0x000000018570FA1C
		public static bool TestAAB3Sphere3(ref AAB3 box, ref Sphere3 sphere) => default; // 0x000000018294A0B0-0x000000018294A140
		public static bool TestBox3Box3(ref Box3 box0, ref Box3 box1) => default; // 0x0000000182A5CC80-0x0000000182A5D1F0
		public static bool TestBox3Capsule3(ref Box3 box, ref Capsule3 capsule) => default; // 0x000000018570FE6C-0x000000018570FE94
		public static bool TestBox3Sphere3(ref Box3 box, ref Sphere3 sphere) => default; // 0x000000018570FE94-0x0000000185710098
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref AAB3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x00000001857052E0-0x0000000185705730
		public static bool TestLine3AAB3(ref Line3 line, ref AAB3 box) => default; // 0x0000000185710BB8-0x0000000185710D54
		public static bool FindLine3AAB3(ref Line3 line, ref AAB3 box, out Line3AAB3Intr info) {
			info = default;
			return default;
		} // 0x0000000185707344-0x00000001857073E0
		private static bool DoClipping(float t0, float t1, ref Vector3 origin, ref Vector3 direction, ref Box3 box, bool solid, out int quantity, out Vector3 point0, out Vector3 point1, out IntersectionTypes intrType) {
			quantity = default;
			point0 = default;
			point1 = default;
			intrType = default;
			return default;
		} // 0x0000000185705A94-0x000000018570608C
		public static bool TestLine3Box3(ref Line3 line, ref Box3 box) => default; // 0x0000000185710D54-0x0000000185711014
		public static bool FindLine3Box3(ref Line3 line, ref Box3 box, out Line3Box3Intr info) {
			info = default;
			return default;
		} // 0x00000001857073E0-0x000000018570747C
		public static bool TestLine3Circle3(ref Line3 line, ref Circle3 circle) => default; // 0x0000000185711014-0x0000000185711074
		public static bool FindLine3Circle3(ref Line3 line, ref Circle3 circle, out Line3Circle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570747C-0x0000000185707690
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185711074-0x00000001857111AC
		public static bool TestLine3Plane3(ref Line3 line, ref Plane3 plane) => default; // 0x00000001857111AC-0x0000000185711208
		public static bool FindLine3Plane3(ref Line3 line, ref Plane3 plane, out Line3Plane3Intr info) {
			info = default;
			return default;
		} // 0x0000000185707690-0x0000000185707810
		public static bool TestLine3Polygon3(ref Line3 line, Polygon3 polygon) => default; // 0x0000000185711208-0x0000000185711268
		public static bool FindLine3Polygon3(ref Line3 line, Polygon3 polygon, out Line3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x0000000185707810-0x00000001857079F0
		private static bool Point3InsideRectangle3(ref Vector3 point, ref Rectangle3 rectangle) => default; // 0x000000018570F5A0-0x000000018570F6CC
		public static bool TestLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle) => default; // 0x0000000185711268-0x00000001857112C8
		public static bool FindLine3Rectangle3(ref Line3 line, ref Rectangle3 rectangle, out Line3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x00000001857079F0-0x0000000185707BD8
		public static bool TestLine3Sphere3(ref Line3 line, ref Sphere3 sphere) => default; // 0x00000001857112C8-0x00000001857113DC
		public static bool FindLine3Sphere3(ref Line3 line, ref Sphere3 sphere, out Line3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x0000000185707BD8-0x0000000185707ED0
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185711740-0x0000000185711A70
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x000000018571167C-0x0000000185711740
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001857114F8-0x00000001857115BC
		public static bool TestLine3Triangle3(ref Line3 line, ref Triangle3 triangle) => default; // 0x00000001857113DC-0x0000000185711438
		public static bool TestLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001857115BC-0x000000018571167C
		public static bool TestLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x0000000185711438-0x00000001857114F8
		public static bool FindLine3Triangle3(ref Line3 line, ref Triangle3 triangle, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x0000000185708058-0x0000000185708460
		public static bool FindLine3Triangle3(ref Line3 line, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x0000000185707ED0-0x0000000185707F94
		public static bool FindLine3Triangle3(ref Line3 line, Vector3 v0, Vector3 v1, Vector3 v2, out Line3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x0000000185707F94-0x0000000185708058
		public static bool TestPlane3AAB3(ref Plane3 plane, ref AAB3 box) => default; // 0x0000000185711A70-0x0000000185711B40
		public static bool TestPlane3Box3(ref Plane3 plane, ref Box3 box) => default; // 0x0000000185711B40-0x0000000185711CAC
		public static bool TestPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1) => default; // 0x0000000185711CAC-0x0000000185711D4C
		public static bool FindPlane3Plane3(ref Plane3 plane0, ref Plane3 plane1, out Plane3Plane3Intr info) {
			info = default;
			return default;
		} // 0x0000000185708460-0x000000018570869C
		public static bool TestPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere) => default; // 0x0000000185711D4C-0x0000000185711D80
		public static bool FindPlane3Sphere3(ref Plane3 plane, ref Sphere3 sphere, out Plane3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x000000018570869C-0x000000018570881C
		public static bool TestPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle) => default; // 0x0000000185711D80-0x0000000185711EE0
		public static bool FindPlane3Triangle3(ref Plane3 plane, ref Triangle3 triangle, out Plane3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570881C-0x0000000185708FD8
		public static bool TestRay3AAB3(ref Ray3 ray, ref AAB3 box) => default; // 0x0000000185712AC0-0x0000000185712D0C
		public static bool FindRay3AAB3(ref Ray3 ray, ref AAB3 box, out Ray3AAB3Intr info) {
			info = default;
			return default;
		} // 0x000000018570A050-0x000000018570A0E8
		public static bool TestRay3Box3(ref Ray3 ray, ref Box3 box) => default; // 0x0000000185712D0C-0x00000001857130D4
		public static bool FindRay3Box3(ref Ray3 ray, ref Box3 box, out Ray3Box3Intr info) {
			info = default;
			return default;
		} // 0x000000018570A0E8-0x000000018570A180
		public static bool TestRay3Circle3(ref Ray3 ray, ref Circle3 circle) => default; // 0x00000001857130D4-0x0000000185713134
		public static bool FindRay3Circle3(ref Ray3 ray, ref Circle3 circle, out Ray3Circle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570A180-0x000000018570A408
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185713198-0x0000000185713210
		public static bool TestRay3Plane3(ref Ray3 ray, ref Plane3 plane) => default; // 0x0000000185713134-0x0000000185713198
		public static bool FindRay3Plane3(ref Ray3 ray, ref Plane3 plane, out Ray3Plane3Intr info) {
			info = default;
			return default;
		} // 0x000000018570A408-0x000000018570A60C
		public static bool TestRay3Polygon3(ref Ray3 ray, Polygon3 polygon) => default; // 0x0000000185713210-0x0000000185713270
		public static bool FindRay3Polygon3(ref Ray3 ray, Polygon3 polygon, out Ray3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x000000018570A60C-0x000000018570A864
		public static bool TestRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle) => default; // 0x0000000185713270-0x00000001857132D0
		public static bool FindRay3Rectangle3(ref Ray3 ray, ref Rectangle3 rectangle, out Ray3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570A864-0x000000018570AAB8
		public static bool TestRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere) => default; // 0x00000001857132D0-0x0000000185713418
		public static bool FindRay3Sphere3(ref Ray3 ray, ref Sphere3 sphere, out Ray3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x000000018570AAB8-0x000000018570AE84
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x000000018571377C-0x0000000185713B2C
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185713418-0x00000001857134DC
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001857134DC-0x00000001857135A0
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle) => default; // 0x0000000185713660-0x00000001857136BC
		public static bool TestRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001857136BC-0x000000018571377C
		public static bool TestRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001857135A0-0x0000000185713660
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Triangle3 triangle, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570AF48-0x000000018570B380
		public static bool FindRay3Triangle3(ref Ray3 ray, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570AE84-0x000000018570AF48
		public static bool FindRay3Triangle3(ref Ray3 ray, Vector3 v0, Vector3 v1, Vector3 v2, out Ray3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570B380-0x000000018570B444
		public static bool TestSegment3AAB3(ref Segment3 segment, ref AAB3 box) => default; // 0x00000001857143A8-0x00000001857145F4
		public static bool FindSegment3AAB3(ref Segment3 segment, ref AAB3 box, out Segment3AAB3Intr info) {
			info = default;
			return default;
		} // 0x000000018570C2B0-0x000000018570C370
		public static bool TestSegment3Box3(ref Segment3 segment, ref Box3 box) => default; // 0x00000001857145F4-0x00000001857149A8
		public static bool FindSegment3Box3(ref Segment3 segment, ref Box3 box, out Segment3Box3Intr info) {
			info = default;
			return default;
		} // 0x000000018570C370-0x000000018570C430
		public static bool TestSegment3Circle3(ref Segment3 segment, ref Circle3 circle) => default; // 0x00000001857149A8-0x0000000185714A08
		public static bool FindSegment3Circle3(ref Segment3 segment, ref Circle3 circle, out Segment3Circle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570C430-0x000000018570C6C0
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185714A64-0x0000000185714BB0
		public static bool TestSegment3Plane3(ref Segment3 segment, ref Plane3 plane) => default; // 0x0000000185714A08-0x0000000185714A64
		public static bool FindSegment3Plane3(ref Segment3 segment, ref Plane3 plane, out Segment3Plane3Intr info) {
			info = default;
			return default;
		} // 0x000000018570C6C0-0x000000018570C8F8
		public static bool TestSegment3Polygon3(ref Segment3 segment, Polygon3 polygon) => default; // 0x0000000185714BB0-0x0000000185714C10
		public static bool FindSegment3Polygon3(ref Segment3 segment, Polygon3 polygon, out Segment3Polygon3Intr info) {
			info = default;
			return default;
		} // 0x000000018570C8F8-0x000000018570CB4C
		public static bool TestSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle) => default; // 0x0000000185714C10-0x0000000185714C70
		public static bool FindSegment3Rectangle3(ref Segment3 segment, ref Rectangle3 rectangle, out Segment3Rectangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570CB4C-0x000000018570CDAC
		public static bool TestSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere) => default; // 0x0000000185714C70-0x0000000185714DE4
		public static bool FindSegment3Sphere3(ref Segment3 segment, ref Sphere3 sphere, out Segment3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x000000018570CDAC-0x000000018570D218
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x00000001857150EC-0x0000000185715494
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185715028-0x00000001857150EC
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x0000000185714EA4-0x0000000185714F68
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle) => default; // 0x0000000185715494-0x00000001857154F0
		public static bool TestSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x0000000185714F68-0x0000000185715028
		public static bool TestSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x0000000185714DE4-0x0000000185714EA4
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Triangle3 triangle, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570D2DC-0x000000018570D764
		public static bool FindSegment3Triangle3(ref Segment3 segment, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570D764-0x000000018570D828
		public static bool FindSegment3Triangle3(ref Segment3 segment, Vector3 v0, Vector3 v1, Vector3 v2, out Segment3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570D218-0x000000018570D2DC
		public static bool TestSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1) => default; // 0x0000000183496D10-0x0000000183496D90
		public static bool FindSphere3Sphere3(ref Sphere3 sphere0, ref Sphere3 sphere1, out Sphere3Sphere3Intr info) {
			info = default;
			return default;
		} // 0x000000018570D828-0x000000018570DCD4
		private static void ProjectOntoAxis(ref Triangle3 triangle, ref Vector3 axis, out float fmin, out float fmax) {
			fmin = default;
			fmax = default;
		} // 0x000000018570F6CC-0x000000018570F830
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
		} // 0x0000000185716988-0x0000000185716AE4
		private static bool TrianglePlaneRelationsQuick(ref Triangle3 triangle, ref Plane3 plane) => default; // 0x00000001857168D4-0x0000000185716988
		private static bool IntersectsSegment(ref Plane3 plane, ref Triangle3 triangle, ref Vector3 end0, ref Vector3 end1, bool grazing, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570F0F0-0x000000018570F5A0
		private static int QueryToLine(ref Vector2 test, ref Vector2 vec0, ref Vector2 vec1) => default; // 0x000000018570F830-0x000000018570F884
		private static int QueryToTriangle(ref Vector2 test, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x000000018570F884-0x000000018570F960
		private static bool ContainsPoint(ref Triangle3 triangle, ref Plane3 plane, ref Vector3 point, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x0000000185704FA0-0x00000001857052E0
		private static bool GetCoplanarIntersection(ref Plane3 plane, ref Triangle3 tri0, ref Triangle3 tri1, out Triangle3Triangle3Intr info) {
			info = default;
			return default;
		} // 0x000000018570E86C-0x000000018570EE84
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out IntersectionTypes intersectionType) {
			intersectionType = default;
			return default;
		} // 0x000000018571573C-0x00000001857165F0
		public static bool TestTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1) => default; // 0x00000001857165F0-0x000000018571664C
		public static bool FindTriangle3Triangle3(ref Triangle3 triangle0, ref Triangle3 triangle1, out Triangle3Triangle3Intr info, bool reportCoplanarIntersections = false /* Metadata: 0x01FD67B3 */) {
			info = default;
			return default;
		} // 0x000000018570DE1C-0x000000018570E714
		public static int FindSegment1Segment1(float seg0Start, float seg0End, float seg1Start, float seg1End, out float w0, out float w1) {
			w0 = default;
			w1 = default;
			return default;
		} // 0x000000018570B444-0x000000018570B558
	}

	public struct Circle2Circle2Intr // TypeDefIndex: 54845
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2AAB2Intr // TypeDefIndex: 54846
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2Box2Intr // TypeDefIndex: 54847
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Line2Circle2Intr // TypeDefIndex: 54848
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Line2ConvexPolygon2Intr // TypeDefIndex: 54849
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Line2Line2Intr // TypeDefIndex: 54850
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Ray2Intr // TypeDefIndex: 54851
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Segment2Intr // TypeDefIndex: 54852
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Line2Triangle2Intr // TypeDefIndex: 54853
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2AAB2Intr // TypeDefIndex: 54854
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2Box2Intr // TypeDefIndex: 54855
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Ray2Circle2Intr // TypeDefIndex: 54856
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Ray2ConvexPolygon2Intr // TypeDefIndex: 54857
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Ray2Polygon2Intr // TypeDefIndex: 54858
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Ray2Ray2Intr // TypeDefIndex: 54859
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point; // 0x04
		public float Parameter; // 0x0C
	}

	public struct Ray2Segment2Intr // TypeDefIndex: 54860
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Ray2Triangle2Intr // TypeDefIndex: 54861
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2AAB2Intr // TypeDefIndex: 54862
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2Box2Intr // TypeDefIndex: 54863
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Segment2Circle2Intr // TypeDefIndex: 54864
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
	}

	public struct Segment2ConvexPolygon2Intr // TypeDefIndex: 54865
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
		public float Parameter0; // 0x18
		public float Parameter1; // 0x1C
	}

	public struct Segment2Segment2Intr // TypeDefIndex: 54866
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector2 Point0; // 0x04
		public Vector2 Point1; // 0x0C
		public float Parameter0; // 0x14
		public float Parameter1; // 0x18
	}

	public struct Segment2Triangle2Intr // TypeDefIndex: 54867
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector2 Point0; // 0x08
		public Vector2 Point1; // 0x10
	}

	public struct Triangle2Triangle2Intr // TypeDefIndex: 54868
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
		public Vector2 this[int i] { get => default; internal set {} } // 0x000000018571CAF0-0x000000018571CB6C 0x000000018571CB6C-0x000000018571CBA8
	}

	internal struct Float6 // TypeDefIndex: 54869
	{
		// Fields
		private float _0; // 0x00
		private float _1; // 0x04
		private float _2; // 0x08
		private float _3; // 0x0C
		private float _4; // 0x10
		private float _5; // 0x14
	
		// Properties
		public float this[int i] { get => default; set {} } // 0x0000000185717180-0x00000001857171C4 0x00000001857171C4-0x000000018571721C
	}

	public struct Line3AAB3Intr // TypeDefIndex: 54870
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Line3Box3Intr // TypeDefIndex: 54871
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Line3Circle3Intr // TypeDefIndex: 54872
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Plane3Intr // TypeDefIndex: 54873
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float LineParameter; // 0x10
	}

	public struct Line3Polygon3Intr // TypeDefIndex: 54874
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Rectangle3Intr // TypeDefIndex: 54875
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Line3Sphere3Intr // TypeDefIndex: 54876
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float LineParameter0; // 0x20
		public float LineParameter1; // 0x24
	}

	public struct Line3Triangle3Intr // TypeDefIndex: 54877
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float LineParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public struct Plane3Plane3Intr // TypeDefIndex: 54878
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Line3 Line; // 0x04
	}

	public struct Plane3Sphere3Intr // TypeDefIndex: 54879
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Circle3 Circle; // 0x04
	}

	public struct Plane3Triangle3Intr // TypeDefIndex: 54880
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public Vector3 Point2; // 0x20
	}

	public struct Ray3AAB3Intr // TypeDefIndex: 54881
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Ray3Box3Intr // TypeDefIndex: 54882
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Ray3Circle3Intr // TypeDefIndex: 54883
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Plane3Intr // TypeDefIndex: 54884
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float RayParameter; // 0x10
	}

	public struct Ray3Polygon3Intr // TypeDefIndex: 54885
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Rectangle3Intr // TypeDefIndex: 54886
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Ray3Sphere3Intr // TypeDefIndex: 54887
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float RayParameter0; // 0x20
		public float RayParameter1; // 0x24
	}

	public struct Ray3Triangle3Intr // TypeDefIndex: 54888
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float RayParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public struct Segment3AAB3Intr // TypeDefIndex: 54889
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Segment3Box3Intr // TypeDefIndex: 54890
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
	}

	public struct Segment3Circle3Intr // TypeDefIndex: 54891
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Plane3Intr // TypeDefIndex: 54892
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float SegmentParameter; // 0x10
	}

	public struct Segment3Polygon3Intr // TypeDefIndex: 54893
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Rectangle3Intr // TypeDefIndex: 54894
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
	}

	public struct Segment3Sphere3Intr // TypeDefIndex: 54895
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public int Quantity; // 0x04
		public Vector3 Point0; // 0x08
		public Vector3 Point1; // 0x14
		public float SegmentParameter0; // 0x20
		public float SegmentParameter1; // 0x24
	}

	public struct Segment3Triangle3Intr // TypeDefIndex: 54896
	{
		// Fields
		public IntersectionTypes IntersectionType; // 0x00
		public Vector3 Point; // 0x04
		public float SegmentParameter; // 0x10
		public float TriBary0; // 0x14
		public float TriBary1; // 0x18
		public float TriBary2; // 0x1C
	}

	public enum Sphere3Sphere3IntrTypes // TypeDefIndex: 54897
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

	public struct Sphere3Sphere3Intr // TypeDefIndex: 54898
	{
		// Fields
		public Sphere3Sphere3IntrTypes IntersectionType; // 0x00
		public Circle3 Circle; // 0x04
		public Vector3 ContactPoint; // 0x38
	}

	public struct Triangle3Triangle3Intr // TypeDefIndex: 54899
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
		public Vector3 this[int i] { get => default; internal set {} } // 0x000000018571CBA8-0x000000018571CC38 0x000000018571CC38-0x000000018571CCC4
	}

	public enum IntersectionTypes // TypeDefIndex: 54900
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

	public interface ILogger // TypeDefIndex: 54901
	{
		// Methods
		void LogInfo(object value);
		void LogWarning(object value);
		void LogError(object value);
	}

	public class Logger // TypeDefIndex: 54902
	{
		// Fields
		private static ILogger _instance; // 0x00
	
		// Constructors
		static Logger() {} // 0x00000001857175B0-0x0000000185717620
		public Logger() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void LogInfo(object value) {} // 0x00000001857173BC-0x0000000185717470
		public static void LogWarning(object value) {} // 0x0000000185717470-0x0000000185717528
		public static void LogError(object value) {} // 0x0000000185717304-0x00000001857173BC
		public static void SetLogger(ILogger logger) {} // 0x0000000185717528-0x00000001857175B0
	}

	public class DefaultLogger : ILogger // TypeDefIndex: 54903
	{
		// Constructors
		public DefaultLogger() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void LogInfo(object value) {} // 0x00000001857170E8-0x0000000185717134
		public void LogWarning(object value) {} // 0x0000000185717134-0x0000000185717180
		public void LogError(object value) {} // 0x000000018571709C-0x00000001857170E8
	}

	public class EmptyLogger : ILogger // TypeDefIndex: 54904
	{
		// Constructors
		public EmptyLogger() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void LogInfo(object value) {} // 0x000000018350B670-0x000000018350B680
		public void LogWarning(object value) {} // 0x000000018350B670-0x000000018350B680
		public void LogError(object value) {} // 0x000000018350B670-0x000000018350B680
	}

	public static class Mathfex // TypeDefIndex: 54905
	{
		// Fields
		public const float ZeroTolerance = 1E-05f; // Metadata: 0x01FD67CD
		public const float NegativeZeroTolerance = -1E-05f; // Metadata: 0x01FD67D1
		public const float ZeroToleranceSqr = 9.9999994E-11f; // Metadata: 0x01FD67D5
		public const float Pi = 3.1415927f; // Metadata: 0x01FD67D9
		public const float HalfPi = 1.5707964f; // Metadata: 0x01FD67DD
		public const float TwoPi = 6.2831855f; // Metadata: 0x01FD67E1
	
		// Methods
		public static float EvalSquared(float x) => default; // 0x0000000183D51490-0x0000000183D514A0
		public static float EvalInvSquared(float x) => default; // 0x0000000183D51630-0x0000000183D51650
		public static float EvalCubic(float x) => default; // 0x0000000183D525D0-0x0000000183D525E0
		public static float EvalInvCubic(float x) => default; // 0x0000000183D52640-0x0000000183D52650
		public static float EvalQuadratic(float x, float a, float b, float c) => default; // 0x0000000183D52650-0x0000000183D52670
		public static float EvalSigmoid(float x) => default; // 0x0000000183D52670-0x0000000183D52690
		public static float EvalOverlappedStep(float x, float overlap, int objectIndex, int objectCount) => default; // 0x0000000185717A20-0x0000000185717A70
		public static float EvalSmoothOverlappedStep(float x, float overlap, int objectIndex, int objectCount) => default; // 0x0000000185717A70-0x0000000185717AD8
		public static float EvalGaussian(float x, float a, float b, float c) => default; // 0x00000001857179E4-0x0000000185717A20
		public static float EvalGaussian2D(float x, float y, float x0, float y0, float A, float a, float b, float c) => default; // 0x0000000183D525E0-0x0000000183D52640
		public static float Lerp(float value0, float value1, float factor) => default; // 0x0000000185717B88-0x0000000185717BB8
		public static float LerpUnclamped(float value0, float value1, float factor) => default; // 0x0000000183D52690-0x0000000183D526A0
		public static float SigmoidInterp(float value0, float value1, float factor) => default; // 0x0000000185717BDC-0x0000000185717C28
		public static float SinInterp(float value0, float value1, float factor) => default; // 0x0000000185717C28-0x0000000185717C84
		public static float CosInterp(float value0, float value1, float factor) => default; // 0x0000000185717908-0x000000018571797C
		public static float WobbleInterp(float value0, float value1, float factor) => default; // 0x0000000185717C84-0x0000000185717D68
		public static float CurveInterp(float value0, float value1, float factor, AnimationCurve curve) => default; // 0x000000018571797C-0x00000001857179E4
		public static float FuncInterp(float value0, float value1, float factor, Func<float, float> func) => default; // 0x0000000185717AD8-0x0000000185717B58
		public static float InvSqrt(float value) => default; // 0x0000000185717B58-0x0000000185717B88
		public static bool Near(float value0, float value1, float epsilon = 1E-05f /* Metadata: 0x01FD67C5 */) => default; // 0x0000000185717BC8-0x0000000185717BDC
		public static bool NearZero(float value, float epsilon = 1E-05f /* Metadata: 0x01FD67C9 */) => default; // 0x0000000185717BB8-0x0000000185717BC8
		public static Vector2 CartesianToPolar(Vector2 cartesianCoordinates) => default; // 0x0000000185717708-0x00000001857177EC
		public static Vector2 PolarToCartesian(Vector2 polarCoordinates) => default; // 0x0000000183D526A0-0x0000000183D526F0
		public static Vector3 CartesianToSpherical(Vector3 cartesianCoordinates) => default; // 0x00000001857177EC-0x0000000185717908
		public static Vector3 SphericalToCartesian(Vector3 sphericalCoordinates) => default; // 0x0000000183D526F0-0x0000000183D52790
		public static Vector3 CartesianToCylindrical(Vector3 cartesianCoordinates) => default; // 0x0000000185717620-0x0000000185717708
		public static Vector3 CylindricalToCartesian(Vector3 cylindricalCoordinates) => default; // 0x0000000183D52580-0x0000000183D525D0
	}

	public static class Matrix4x4ex // TypeDefIndex: 54906
	{
		// Fields
		public static readonly Matrix4x4 Identity; // 0x00
	
		// Constructors
		static Matrix4x4ex() {} // 0x000000018571A688-0x000000018571A710
	
		// Methods
		public static void RotationMatrixToQuaternion(ref Matrix4x4 matrix, out Quaternion quaternion) {
			quaternion = default;
		} // 0x000000018571A5C0-0x000000018571A688
		public static void QuaternionToRotationMatrix(Quaternion quaternion, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D53CF0-0x0000000183D53E70
		public static void QuaternionToRotationMatrix(ref Quaternion quaternion, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D53E70-0x0000000183D53FF0
		public static void CreateTranslation(Vector3 position, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D53660-0x0000000183D536A0
		public static void CreateTranslation(ref Vector3 position, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D53620-0x0000000183D53660
		public static void CreateScale(Vector3 scale, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D52CA0-0x0000000183D52CE0
		public static void CreateScale(ref Vector3 scale, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D52CE0-0x0000000183D52D20
		public static void CreateScale(float scale, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D52D20-0x0000000183D52D60
		public static void CreateRotationEuler(float eulerX, float eulerY, float eulerZ, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x00000001857181FC-0x000000018571828C
		public static void CreateRotationEuler(Vector3 eulerAngles, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185718300-0x0000000185718374
		public static void CreateRotationEuler(ref Vector3 eulerAngles, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x000000018571828C-0x0000000185718300
		public static void CreateRotationX(float angleInDegrees, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D52AA0-0x0000000183D52B30
		public static void CreateRotationY(float angleInDegrees, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D52B30-0x0000000183D52BC0
		public static void CreateRotationZ(float angleInDegrees, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D52BC0-0x0000000183D52C50
		public static void CreateRotationAngleAxis(float angleInDegrees, Vector3 rotationAxis, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185718078-0x00000001857181FC
		public static void CreateRotationAngleUnitAxis(float angleInDegrees, Vector3 normalizedAxis, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000183D52940-0x0000000183D52AA0
		public static void CreateRotation(Vector3 rotationOrigin, Quaternion rotation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001857186A0-0x000000018571879C
		public static void CreateRotation(ref Vector3 rotationOrigin, ref Quaternion rotation, out Matrix4x4 result) {
			result = default;
		} // 0x00000001857185A4-0x00000001857186A0
		public static void Transpose(ref Matrix4x4 matrix) {} // 0x0000000183D53FF0-0x0000000183D54060
		public static void Transpose(ref Matrix4x4 matrix, out Matrix4x4 transpose) {
			transpose = default;
		} // 0x0000000183D54060-0x0000000183D540C0
		public static float CalcDeterminant(ref Matrix4x4 matrix) => default; // 0x0000000183D52790-0x0000000183D528E0
		public static void Inverse(ref Matrix4x4 matrix, float epsilon = 1E-05f /* Metadata: 0x01FD67E5 */) {} // 0x00000001857197C4-0x0000000185719DF0
		public static void Inverse(ref Matrix4x4 matrix, out Matrix4x4 inverse, float epsilon = 1E-05f /* Metadata: 0x01FD67E9 */) {
			inverse = default;
		} // 0x00000001857191EC-0x00000001857197C4
		public static void CopyMatrix(ref Matrix4x4 source, out Matrix4x4 destination) {
			destination = default;
		} // 0x0000000183D528E0-0x0000000183D52940
		public static void Multiply(ref Matrix4x4 matrix0, ref Matrix4x4 matrix1, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D53870-0x0000000183D53C10
		public static void MultiplyRight(ref Matrix4x4 matrix0, ref Matrix4x4 matrix1) {} // 0x000000018571A1D8-0x000000018571A5C0
		public static void MultiplyLeft(ref Matrix4x4 matrix1, ref Matrix4x4 matrix0) {} // 0x0000000185719DF0-0x000000018571A1D8
		public static void Multiply(ref Matrix4x4 matrix, float scalar) {} // 0x0000000183D536A0-0x0000000183D53770
		public static void Multiply(ref Matrix4x4 matrix, float scalar, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D53C10-0x0000000183D53CF0
		public static Vector4 Multiply(ref Matrix4x4 matrix, Vector4 vector) => default; // 0x0000000183D53770-0x0000000183D53870
		public static Vector4 Multiply(ref Matrix4x4 matrix, ref Vector4 vector) => default; // 0x0000000183D53770-0x0000000183D53870
		public static void CreateSRT(Vector3 scaling, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185718BD8-0x0000000185718CD8
		public static void CreateSRT(ref Vector3 scaling, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185718AD8-0x0000000185718BD8
		public static void CreateSRT(float scaling, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185719014-0x0000000185719100
		public static void CreateSRT(float scaling, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185719100-0x00000001857191EC
		public static void CreateSRT(Vector3 scaling, Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185718E6C-0x0000000185719014
		public static void CreateSRT(ref Vector3 scaling, ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185718930-0x0000000185718AD8
		public static void CreateSRT(float scaling, Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x000000018571879C-0x0000000185718930
		public static void CreateSRT(float scaling, ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185718CD8-0x0000000185718E6C
		public static void CreateRT(Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185717E80-0x0000000185717EF0
		public static void CreateRT(ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185717EF0-0x0000000185717F60
		public static void CreateRT(Vector3 rotationOrigin, Quaternion rotation, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185717D68-0x0000000185717E80
		public static void CreateRT(ref Vector3 rotationOrigin, ref Quaternion rotation, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000185717F60-0x0000000185718078
		public static void CreateST(Vector3 scaling, Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D52C50-0x0000000183D52CA0
		public static void CreateST(ref Vector3 scaling, ref Vector3 translation, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D52C50-0x0000000183D52CA0
		public static void CreateRotationFromColumns(Vector3 column0, Vector3 column1, Vector3 column2, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x000000018571848C-0x00000001857185A4
		public static void CreateRotationFromColumns(ref Vector3 column0, ref Vector3 column1, ref Vector3 column2, out Matrix4x4 matrix) {
			matrix = default;
		} // 0x0000000185718374-0x000000018571848C
		public static void CreateShadowDirectional(Plane3 shadowPlane, Vector3 dirLightOppositeDirection, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D52D60-0x0000000183D52EC0
		public static void CreateShadowDirectional(ref Plane3 shadowPlane, ref Vector3 dirLightOppositeDirection, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D52EC0-0x0000000183D53020
		public static void CreateShadowPoint(Plane3 shadowPlane, Vector3 pointLightPosition, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D53020-0x0000000183D53180
		public static void CreateShadowPoint(ref Plane3 shadowPlane, ref Vector3 pointLightPosition, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D53180-0x0000000183D532E0
		public static void CreateShadow(Plane3 shadowPlane, Vector4 lightData, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D53480-0x0000000183D53620
		public static void CreateShadow(ref Plane3 shadowPlane, ref Vector4 lightData, out Matrix4x4 result) {
			result = default;
		} // 0x0000000183D532E0-0x0000000183D53480
	}

	public static class Quaternionex // TypeDefIndex: 54907
	{
		// Extension methods
		public static Quaternion DeltaTo(this Quaternion quat, Quaternion target) => default; // 0x000000018571A710-0x000000018571A778
		public static string ToStringEx(this Quaternion quat) => default; // 0x000000018571A778-0x000000018571A894
	}

	public class Rand // TypeDefIndex: 54908
	{
		// Fields
		private const int a = 5; // Metadata: 0x01FD680D
		private const int b = 14; // Metadata: 0x01FD680E
		private const int c = 1; // Metadata: 0x01FD680F
		private const uint DefaultY = 273326509; // Metadata: 0x01FD6810
		private const uint DefaultZ = 3579807591; // Metadata: 0x01FD6814
		private const uint DefaultW = 842502087; // Metadata: 0x01FD6819
		private const uint PositiveMask = 2147483647; // Metadata: 0x01FD681E
		private const uint BoolModuloMask = 1; // Metadata: 0x01FD6823
		private const uint ByteModuloMask = 255; // Metadata: 0x01FD6824
		private const double One_div_uintMaxValuePlusOne = 2.3283064365386963E-10; // Metadata: 0x01FD6826
		private const double TwoPi = 6.283185307179586; // Metadata: 0x01FD682E
		private static Rand _seedGenerator; // 0x00
		private uint _x; // 0x10
		private uint _y; // 0x14
		private uint _z; // 0x18
		private uint _w; // 0x1C
		public static Rand Instance; // 0x08
	
		// Constructors
		static Rand() {} // 0x000000018571B8D0-0x000000018571B9A0
		public Rand() {} // 0x000000018571B9A0-0x000000018571BA18
		public Rand(int seed) {} // 0x0000000183D54240-0x0000000183D54260
	
		// Methods
		public void ResetSeed(int seed) {} // 0x0000000183D54240-0x0000000183D54260
		public void GetState(out uint x, out uint y, out uint z, out uint w) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D540C0-0x0000000183D540E0
		public void SetState(uint x, uint y, uint z, uint w) {} // 0x0000000183D54260-0x0000000183D54280
		public int NextInt() => default; // 0x0000000183D540E0-0x0000000183D54110
		public int NextInt(int max) => default; // 0x0000000183D541A0-0x0000000183D54200
		public int NextInt(int min, int max) => default; // 0x000000018571B06C-0x000000018571B14C
		public int NextIntInclusive(int min, int max) => default; // 0x000000018571B060-0x000000018571B06C
		public int NextPositiveInt() => default; // 0x0000000183D54200-0x0000000183D54240
		public uint NextUInt() => default; // 0x0000000183D540E0-0x0000000183D54110
		public double NextDouble() => default; // 0x0000000183D54110-0x0000000183D54150
		public double NextDouble(double min, double max) => default; // 0x000000018571AEDC-0x000000018571AF9C
		public float NextFloat() => default; // 0x0000000183D54150-0x0000000183D541A0
		public float NextFloat(float min, float max) => default; // 0x000000018571AF9C-0x000000018571B060
		public bool NextBool() => default; // 0x000000018571AEA8-0x000000018571AEDC
		public byte NextByte() => default; // 0x0000000183D540E0-0x0000000183D54110
		public UnityEngine.Color RandomColorOpaque() => default; // 0x000000018571B6B4-0x000000018571B720
		public UnityEngine.Color RandomColorTransparent() => default; // 0x000000018571B720-0x000000018571B7A4
		public Color32 RandomColor32Opaque() => default; // 0x000000018571B620-0x000000018571B660
		public Color32 RandomColor32Transparent() => default; // 0x000000018571B660-0x000000018571B6B4
		public float RandomAngleRadians() => default; // 0x000000018571B608-0x000000018571B620
		public float RandomAngleDegrees() => default; // 0x000000018571B5F0-0x000000018571B608
		public Vector2 InSquare(float side = 1f /* Metadata: 0x01FD67ED */) => default; // 0x000000018571AB3C-0x000000018571ABB0
		public Vector2 OnSquare(float side = 1f /* Metadata: 0x01FD67F1 */) => default; // 0x000000018571B4B8-0x000000018571B5F0
		public Vector3 InCube(float side = 1f /* Metadata: 0x01FD67F5 */) => default; // 0x000000018571A9AC-0x000000018571AA5C
		public Vector3 OnCube(float side = 1f /* Metadata: 0x01FD67F9 */) => default; // 0x000000018571B1A8-0x000000018571B3EC
		public Vector2 InCircle(float radius = 1f /* Metadata: 0x01FD67FD */) => default; // 0x000000018571A934-0x000000018571A9AC
		public Vector2 InCircle(float radiusMin, float radiusMax) => default; // 0x000000018571A894-0x000000018571A934
		public Vector2 OnCircle(float radius = 1f /* Metadata: 0x01FD6801 */) => default; // 0x000000018571B14C-0x000000018571B1A8
		public Vector3 InSphere(float radius = 1f /* Metadata: 0x01FD6805 */) => default; // 0x000000018571AA5C-0x000000018571AB3C
		public Vector3 OnSphere(float radius = 1f /* Metadata: 0x01FD6809 */) => default; // 0x000000018571B3EC-0x000000018571B4B8
		public Vector3 InTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x000000018571AD2C-0x000000018571AEA8
		public Vector3 InTriangle(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x000000018571ABB0-0x000000018571AD2C
		public Quaternion RandomRotation() => default; // 0x000000018571B7A4-0x000000018571B8D0
	}

	public static class Vector2ex // TypeDefIndex: 54910
	{
		// Fields
		public static readonly Vector2 Zero; // 0x00
		public static readonly Vector2 One; // 0x08
		public static readonly Vector2 UnitX; // 0x10
		public static readonly Vector2 UnitY; // 0x18
		public static readonly Vector2 PositiveInfinity; // 0x20
		public static readonly Vector2 NegativeInfinity; // 0x28
	
		// Nested types
		internal class Information // TypeDefIndex: 54909
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
			public Information() {} // 0x000000018571721C-0x0000000185717290
		}
	
		// Constructors
		static Vector2ex() {} // 0x000000018571D618-0x000000018571D6C8
	
		// Methods
		internal static Information GetInformation(IList<Vector2> points, float epsilon) => default; // 0x000000018571CE24-0x000000018571D460
		public static float DotPerp(ref Vector2 vector, ref Vector2 value) => default; // 0x0000000183D542A0-0x0000000183D542C0
		public static float Dot(ref Vector2 vector, ref Vector2 value) => default; // 0x0000000183D54310-0x0000000183D54330
		public static float Normalize(ref Vector2 vector, float epsilon = 1E-05f /* Metadata: 0x01FD6836 */) => default; // 0x000000018571D4D8-0x000000018571D548
		public static float SetLength(ref Vector2 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x01FD683A */) => default; // 0x000000018571D548-0x000000018571D5BC
		public static float GrowLength(ref Vector2 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x01FD683E */) => default; // 0x000000018571D460-0x000000018571D4D8
		public static Vector2 Replicate(float value) => default; // 0x0000000183D543C0-0x0000000183D543D0
	
		// Extension methods
		public static float Length(this Vector2 vector) => default; // 0x0000000183D54350-0x0000000183D54390
		public static float LengthSqr(this Vector2 vector) => default; // 0x0000000183D54330-0x0000000183D54350
		public static float DotPerp(this Vector2 vector, Vector2 value) => default; // 0x0000000183D51240-0x0000000183D51270
		public static float DotPerp(this Vector2 vector, ref Vector2 value) => default; // 0x0000000183D54280-0x0000000183D542A0
		public static float Dot(this Vector2 vector, Vector2 value) => default; // 0x0000000183D542E0-0x0000000183D54310
		public static float Dot(this Vector2 vector, ref Vector2 value) => default; // 0x0000000183D542C0-0x0000000183D542E0
		public static Vector2 Perp(this Vector2 vector) => default; // 0x0000000183D54390-0x0000000183D543C0
		public static float AngleDeg(this Vector2 vector, Vector2 target) => default; // 0x000000018571CCC4-0x000000018571CD78
		public static float AngleRad(this Vector2 vector, Vector2 target) => default; // 0x000000018571CD78-0x000000018571CE24
		public static Vector3 ToVector3XY(this Vector2 vector) => default; // 0x0000000183D51560-0x0000000183D51590
		public static Vector3 ToVector3XZ(this Vector2 vector) => default; // 0x0000000183D515B0-0x0000000183D515E0
		public static Vector3 ToVector3YZ(this Vector2 vector) => default; // 0x0000000183D543D0-0x0000000183D54400
		public static string ToStringEx(this Vector2 vector) => default; // 0x000000018571D5BC-0x000000018571D618
	}

	public enum ProjectionPlanes // TypeDefIndex: 54911
	{
		XY = 0,
		XZ = 1,
		YZ = 2
	}

	public static class Vector3ex // TypeDefIndex: 54913
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
		internal class Information // TypeDefIndex: 54912
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
			public Information() {} // 0x0000000185717290-0x0000000185717304
		}
	
		// Constructors
		static Vector3ex() {} // 0x0000000183CE1DD0-0x0000000183CE1EF0
	
		// Methods
		internal static Information GetInformation(IList<Vector3> points, float epsilon) => default; // 0x000000018571D960-0x000000018571E51C
		public static float Dot(ref Vector3 vector, ref Vector3 value) => default; // 0x0000000183D54460-0x0000000183D54490
		public static Vector3 Cross(ref Vector3 vector, ref Vector3 value) => default; // 0x0000000183D54400-0x0000000183D54460
		public static Vector3 UnitCross(ref Vector3 vector, ref Vector3 value) => default; // 0x000000018571EC68-0x000000018571ED28
		public static float Normalize(ref Vector3 vector, float epsilon = 1E-05f /* Metadata: 0x01FD6845 */) => default; // 0x000000018571E5F0-0x000000018571E67C
		public static float SetLength(ref Vector3 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x01FD6849 */) => default; // 0x000000018571E700-0x000000018571E790
		public static float GrowLength(ref Vector3 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x01FD684D */) => default; // 0x000000018571E55C-0x000000018571E5F0
		public static Vector3 Replicate(float value) => default; // 0x0000000183D54500-0x0000000183D54520
		public static void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, ref Vector3 w) {
			u = default;
			v = default;
		} // 0x000000018571D838-0x000000018571D960
		public static bool SameDirection(Vector3 value0, Vector3 value1) => default; // 0x000000018571E67C-0x000000018571E700
	
		// Extension methods
		public static float Length(this Vector3 vector) => default; // 0x0000000183D544C0-0x0000000183D54500
		public static float LengthSqr(this Vector3 vector) => default; // 0x0000000183D54490-0x0000000183D544C0
		public static float Dot(this Vector3 vector, Vector3 value) => default; // 0x0000000183D54460-0x0000000183D54490
		public static float Dot(this Vector3 vector, ref Vector3 value) => default; // 0x0000000183D54460-0x0000000183D54490
		public static float AngleDeg(this Vector3 vector, Vector3 target) => default; // 0x000000018571D6C8-0x000000018571D784
		public static float AngleRad(this Vector3 vector, Vector3 target) => default; // 0x000000018571D784-0x000000018571D838
		public static float SignedAngleDeg(this Vector3 vector, Vector3 target, Vector3 normal) => default; // 0x000000018571E790-0x000000018571E8F0
		public static float SignedAngleRad(this Vector3 vector, Vector3 target, Vector3 normal) => default; // 0x000000018571E8F0-0x000000018571EA48
		public static Vector3 Cross(this Vector3 vector, Vector3 value) => default; // 0x0000000183D54400-0x0000000183D54460
		public static Vector3 Cross(this Vector3 vector, ref Vector3 value) => default; // 0x0000000183D54400-0x0000000183D54460
		public static Vector3 UnitCross(this Vector3 vector, Vector3 value) => default; // 0x000000018571EBB0-0x000000018571EC68
		public static Vector3 UnitCross(this Vector3 vector, ref Vector3 value) => default; // 0x000000018571EAF0-0x000000018571EBB0
		public static Vector2 ToVector2XY(this Vector3 vector) => default; // 0x0000000183D51540-0x0000000183D51560
		public static Vector2 ToVector2XZ(this Vector3 vector) => default; // 0x0000000183D51590-0x0000000183D515B0
		public static Vector2 ToVector2YZ(this Vector3 vector) => default; // 0x0000000183D54520-0x0000000183D54540
		public static Vector2 ToVector2(this Vector3 vector, ProjectionPlanes projectionPlane) => default; // 0x000000018571EAC8-0x000000018571EAF0
		public static ProjectionPlanes GetProjectionPlane(this Vector3 vector) => default; // 0x000000018571E51C-0x000000018571E55C
		public static string ToStringEx(this Vector3 vector) => default; // 0x000000018571EA48-0x000000018571EAC8
	}

	public struct BrentsRoot // TypeDefIndex: 54914
	{
		// Fields
		public float X; // 0x00
		public int Iterations; // 0x04
		public bool ExceededMaxIterations; // 0x08
	}

	public static class RootFinder // TypeDefIndex: 54916
	{
		// Fields
		private const float third = 0.33333334f; // Metadata: 0x01FD6881
		private const float twentySeventh = 0.037037037f; // Metadata: 0x01FD6885
		private static float sqrt3; // 0x00
	
		// Nested types
		private class PolyRootFinder // TypeDefIndex: 54915
		{
			// Fields
			private int _count; // 0x10
			private int _maxRoot; // 0x14
			private float[] _roots; // 0x18
			private float _epsilon; // 0x20
	
			// Properties
			public float[] Roots { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
			// Constructors
			public PolyRootFinder() {} // Dummy constructor
			public PolyRootFinder(float epsilon) {} // 0x000000018572925C-0x00000001857292C0
	
			// Methods
			public bool Bisection(Polynomial poly, float xMin, float xMax, int digits, out float root) {
				root = default;
				return default;
			} // 0x0000000185728C8C-0x0000000185728E2C
			public bool Find(Polynomial poly, float xMin, float xMax, int digits) => default; // 0x0000000185728E2C-0x000000018572925C
		}
	
		// Constructors
		static RootFinder() {} // 0x000000018571CAAC-0x000000018571CAF0
	
		// Methods
		public static bool BrentsMethod(Func<float, float> function, float x0, float x1, out BrentsRoot root, int maxIterations = 128 /* Metadata: 0x01FD6851 */, float negativeTolerance = -1E-05f /* Metadata: 0x01FD6853 */, float positiveTolerance = 1E-05f /* Metadata: 0x01FD6857 */, float stepTolerance = 1E-05f /* Metadata: 0x01FD685B */, float segmentTolerance = 1E-05f /* Metadata: 0x01FD685F */) {
			root = default;
			return default;
		} // 0x000000018571BA18-0x000000018571BDF0
		public static bool Linear(float c0, float c1, out float root, float epsilon = 1E-05f /* Metadata: 0x01FD6863 */) {
			root = default;
			return default;
		} // 0x000000018571C1AC-0x000000018571C1D8
		public static bool Quadratic(float c0, float c1, float c2, out QuadraticRoots roots, float epsilon = 1E-05f /* Metadata: 0x01FD6867 */) {
			roots = default;
			return default;
		} // 0x000000018571C470-0x000000018571C5F8
		public static bool Cubic(float c0, float c1, float c2, float c3, out CubicRoots roots, float epsilon = 1E-05f /* Metadata: 0x01FD686B */) {
			roots = default;
			return default;
		} // 0x000000018571BDF0-0x000000018571C1AC
		public static bool Quartic(float c0, float c1, float c2, float c3, float c4, out QuarticRoots roots, float epsilon = 1E-05f /* Metadata: 0x01FD686F */) {
			roots = default;
			return default;
		} // 0x000000018571C5F8-0x000000018571CAAC
		public static float PolynomialBound(Polynomial poly, float epsilon = 1E-05f /* Metadata: 0x01FD6873 */) => default; // 0x000000018571C1D8-0x000000018571C2A4
		public static bool Polynomial(Polynomial poly, float xMin, float xMax, out float[] roots, int digits = 6 /* Metadata: 0x01FD6877 */, float epsilon = 1E-05f /* Metadata: 0x01FD6878 */) {
			roots = default;
			return default;
		} // 0x000000018571C388-0x000000018571C470
		public static bool Polynomial(Polynomial poly, out float[] roots, int digits = 6 /* Metadata: 0x01FD687C */, float epsilon = 1E-05f /* Metadata: 0x01FD687D */) {
			roots = default;
			return default;
		} // 0x000000018571C2A4-0x000000018571C388
	}

	public class EigenData // TypeDefIndex: 54917
	{
		// Fields
		private int _size; // 0x10
		private float[] _diagonal; // 0x18
		private float[,] _matrix; // 0x20
	
		// Properties
		public int Size { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public EigenData() {} // Dummy constructor
		internal EigenData(float[] diagonal, float[,] matrix) {} // 0x00000001857242F8-0x0000000185724334
	
		// Methods
		public float GetEigenvalue(int index) => default; // 0x00000001857035D8-0x0000000185703608
		public Vector2 GetEigenvector2(int index) => default; // 0x0000000185724058-0x0000000185724110
		public Vector3 GetEigenvector3(int index) => default; // 0x0000000185724110-0x00000001857241E0
		public float[] GetEigenvector(int index) => default; // 0x00000001857241E0-0x0000000185724284
		public void GetEigenvector(int index, float[] out_eigenvector) {} // 0x0000000185724284-0x00000001857242F8
	}

	public static class EigenDecomposition // TypeDefIndex: 54918
	{
		// Methods
		private static void Tridiagonal2(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation) {
			isRotation = default;
		} // 0x0000000185724C90-0x0000000185724DA4
		private static void Tridiagonal3(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation) {
			isRotation = default;
		} // 0x0000000185724DA4-0x0000000185725118
		private static void TridiagonalN(float[] diagonal, float[] subdiagonal, float[,] matrix, out bool isRotation) {
			isRotation = default;
		} // 0x0000000185725118-0x00000001857257A4
		private static bool QLAlgorithm(float[] diagonal, float[] subdiagonal, float[,] matrix) => default; // 0x0000000185724670-0x0000000185724AE0
		private static void IncreasingSort(float[] diagonal, float[] subdiagonal, float[,] matrix, ref bool isRotation) {} // 0x000000018572450C-0x0000000185724670
		private static void DecreasingSort(float[] diagonal, float[] subdiagonal, float[,] matrix, ref bool isRotation) {} // 0x0000000185724334-0x000000018572449C
		private static void GuaranteeRotation(float[,] matrix, bool isRotation) {} // 0x000000018572449C-0x000000018572450C
		public static EigenData Solve(float[,] symmetricSquareMatrix, bool increasingSort) => default; // 0x0000000185724AE0-0x0000000185724C90
	}

	public static class Integrator // TypeDefIndex: 54919
	{
		// Fields
		private const int _degree = 5; // Metadata: 0x01FD6889
		private static float[] root; // 0x00
		private static float[] coeff; // 0x08
	
		// Constructors
		static Integrator() {} // 0x0000000185725C30-0x0000000185725D14
	
		// Methods
		public static float TrapezoidRule(Func<float, float> function, float a, float b, int sampleCount) => default; // 0x0000000185725B2C-0x0000000185725C30
		public static float RombergIntegral(Func<float, float> function, float a, float b, int order) => default; // 0x00000001857258C0-0x0000000185725B2C
		public static float GaussianQuadrature(Func<float, float> function, float a, float b) => default; // 0x00000001857257A4-0x00000001857258C0
	}

	public static class LinearSystem // TypeDefIndex: 54920
	{
		// Methods
		public static bool Solve2(float[,] A, float[] B, out float[] X, float zeroTolerance = 1E-05f /* Metadata: 0x01FD688A */) {
			X = default;
			return default;
		} // 0x000000018572708C-0x0000000185727294
		public static bool Solve2(float[,] A, float[] B, out Vector2 X, float zeroTolerance = 1E-05f /* Metadata: 0x01FD688E */) {
			X = default;
			return default;
		} // 0x0000000185727294-0x0000000185727368
		public static bool Solve3(float[,] A, float[] B, out float[] X, float zeroTolerance = 1E-05f /* Metadata: 0x01FD6892 */) {
			X = default;
			return default;
		} // 0x0000000185727448-0x0000000185727B5C
		public static bool Solve3(float[,] A, float[] B, out Vector3 X, float zeroTolerance = 1E-05f /* Metadata: 0x01FD6896 */) {
			X = default;
			return default;
		} // 0x0000000185727368-0x0000000185727448
		private static void SwapRows(float[,] matrix, int row0, int row1, int columnCount) {} // 0x00000001857282F0-0x0000000185728398
		public static bool Solve(float[,] A, float[] B, out float[] X) {
			X = default;
			return default;
		} // 0x0000000185727E04-0x00000001857282F0
		public static bool SolveTridiagonal(float[] A, float[] B, float[] C, float[] R, out float[] U) {
			U = default;
			return default;
		} // 0x0000000185727B5C-0x0000000185727E04
		public static bool Inverse(float[,] A, out float[,] invA) {
			invA = default;
			return default;
		} // 0x0000000185726BC4-0x000000018572708C
	}

	public delegate void OdeFunction(float t, float[] y, float[] F); // TypeDefIndex: 54921; 0x00000001857284F4-0x0000000185728508

	public abstract class OdeSolver // TypeDefIndex: 54922
	{
		// Fields
		protected int _dim; // 0x10
		protected float _step; // 0x14
		protected OdeFunction _function; // 0x18
		protected float[] _FValue; // 0x20
	
		// Properties
		public virtual float Step { get; set; } // 0x0000000183D51930-0x0000000183D51940 0x0000000183D51940-0x0000000183D51950
	
		// Constructors
		protected OdeSolver() {} // Dummy constructor
		public OdeSolver(int dim, float step, OdeFunction function) {} // 0x0000000185728C0C-0x0000000185728C8C
	
		// Methods
		public abstract void Update(float tIn, float[] yIn, ref float tOut, float[] yOut);
	}

	public class OdeEuler : OdeSolver // TypeDefIndex: 54923
	{
		// Constructors
		public OdeEuler() {} // Dummy constructor
		public OdeEuler(int dim, float step, OdeFunction function) {} // 0x000000018572845C-0x000000018572846C
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut) {} // 0x0000000185728398-0x000000018572845C
	}

	public class OdeMidpoint : OdeSolver // TypeDefIndex: 54924
	{
		// Fields
		private float _halfStep; // 0x28
		private float[] _yTemp; // 0x30
	
		// Properties
		public override float Step { get => default; set {} } // 0x0000000183D51930-0x0000000183D51940 0x0000000183D54B60-0x0000000183D54B80
	
		// Constructors
		public OdeMidpoint() {} // Dummy constructor
		public OdeMidpoint(int dim, float step, OdeFunction function) {} // 0x0000000185728730-0x00000001857287C4
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut) {} // 0x00000001857285D0-0x0000000185728730
	}

	public class OdeRungeKutta4 : OdeSolver // TypeDefIndex: 54925
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
		public override float Step { get => default; set {} } // 0x0000000183D51930-0x0000000183D51940 0x0000000185728BE8-0x0000000185728C0C
	
		// Constructors
		public OdeRungeKutta4() {} // Dummy constructor
		public OdeRungeKutta4(int dim, float step, OdeFunction function) {} // 0x0000000185728AD8-0x0000000185728BE8
	
		// Methods
		public override void Update(float tIn, float[] yIn, ref float tOut, float[] yOut) {} // 0x00000001857287C4-0x0000000185728AD8
	}

	public struct QuadraticRoots // TypeDefIndex: 54926
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public int RootCount; // 0x08
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x000000018572B19C-0x000000018572B1BC 
	}

	public struct CubicRoots // TypeDefIndex: 54927
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public float X2; // 0x08
		public int RootCount; // 0x0C
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x0000000185724030-0x0000000185724058 
	}

	public struct QuarticRoots // TypeDefIndex: 54928
	{
		// Fields
		public float X0; // 0x00
		public float X1; // 0x04
		public float X2; // 0x08
		public float X3; // 0x0C
		public int RootCount; // 0x10
	
		// Properties
		public float this[int rootIndex] { get => default; } // 0x000000018572B1BC-0x000000018572B1F0 
	}

	public struct AAB2 // TypeDefIndex: 54929
	{
		// Fields
		public Vector2 Min; // 0x00
		public Vector2 Max; // 0x08
	
		// Constructors
		public AAB2(ref Vector2 min, ref Vector2 max) {
			Min = default;
			Max = default;
		} // 0x0000000183D54650-0x0000000183D54670
		public AAB2(Vector2 min, Vector2 max) {
			Min = default;
			Max = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
		public AAB2(float xMin, float xMax, float yMin, float yMax) {
			Min = default;
			Max = default;
		} // 0x0000000183D54670-0x0000000183D54690
	
		// Methods
		public static implicit operator Rect(AAB2 value) => default; // 0x000000018571F410-0x000000018571F454
		public static implicit operator AAB2(Rect value) => default; // 0x0000000183D54690-0x0000000183D546D0
		public static AAB2 CreateFromPoint(ref Vector2 point) => default; // 0x0000000183D54620-0x0000000183D54650
		public static AAB2 CreateFromPoint(Vector2 point) => default; // 0x0000000183D54610-0x0000000183D54620
		public static AAB2 CreateFromTwoPoints(ref Vector2 point0, ref Vector2 point1) => default; // 0x000000018571F1EC-0x000000018571F238
		public static AAB2 CreateFromTwoPoints(Vector2 point0, Vector2 point1) => default; // 0x000000018571F1B0-0x000000018571F1EC
		public static AAB2 CreateFromPoints(IEnumerable<Vector2> points) => default; // 0x000000018571EF6C-0x000000018571F0A4
		public static AAB2 CreateFromPoints(IList<Vector2> points) => default; // 0x000000018571F0A4-0x000000018571F1B0
		public static AAB2 CreateFromPoints(Vector2[] points) => default; // 0x000000018571EEB0-0x000000018571EF6C
		public void CalcCenterExtents(out Vector2 center, out Vector2 extents) {
			center = default;
			extents = default;
		} // 0x0000000183D54560-0x0000000183D545C0
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x0000000183D545C0-0x0000000183D54610
		public Vector2[] CalcVertices() => default; // 0x000000018571ED28-0x000000018571EDE8
		public void CalcVertices(Vector2[] array) {} // 0x000000018571EDE8-0x000000018571EE78
		public float CalcArea() => default; // 0x0000000183D54540-0x0000000183D54560
		public float DistanceTo(Vector2 point) => default; // 0x000000018571F238-0x000000018571F258
		public Vector2 Project(Vector2 point) => default; // 0x000000018571F348-0x000000018571F378
		public bool Contains(ref Vector2 point) => default; // 0x0000000182411D30-0x0000000182411D60
		public bool Contains(Vector2 point) => default; // 0x000000018571EE78-0x000000018571EEB0
		public void Include(ref Vector2 point) {} // 0x000000018571F308-0x000000018571F348
		public void Include(Vector2 point) {} // 0x000000018571F258-0x000000018571F2A0
		public void Include(ref AAB2 box) {} // 0x000000018571F2D4-0x000000018571F308
		public void Include(AAB2 box) {} // 0x000000018571F2A0-0x000000018571F2D4
		public override string ToString() => default; // 0x000000018571F378-0x000000018571F410
	}

	public struct Box2 // TypeDefIndex: 54930
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
		} // 0x0000000183D54880-0x0000000183D548D0
		public Box2(Vector2 center, Vector2 axis0, Vector2 axis1, Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x0000000183D548D0-0x0000000183D548F0
		public Box2(ref AAB2 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x0000000185720EC0-0x0000000185720F5C
		public Box2(AAB2 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x0000000185720F5C-0x0000000185720FF8
	
		// Methods
		public static Box2 CreateFromPoints(IList<Vector2> points) => default; // 0x000000018572047C-0x00000001857207F8
		public Vector2 GetAxis(int index) => default; // 0x0000000185720818-0x000000018572089C
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x000000018571FEB0-0x000000018571FF84
		public Vector2[] CalcVertices() => default; // 0x000000018571FF84-0x0000000185720130
		public void CalcVertices(Vector2[] array) {} // 0x0000000185720130-0x0000000185720298
		public float CalcArea() => default; // 0x0000000183D54860-0x0000000183D54880
		public float DistanceTo(Vector2 point) => default; // 0x00000001857207F8-0x0000000185720818
		public Vector2 Project(Vector2 point) => default; // 0x0000000185720D24-0x0000000185720D54
		public bool Contains(ref Vector2 point) => default; // 0x0000000185720298-0x000000018572038C
		public bool Contains(Vector2 point) => default; // 0x000000018572038C-0x000000018572047C
		public void Include(ref Box2 box) {} // 0x000000018572089C-0x0000000185720D10
		public void Include(Box2 box) {} // 0x0000000185720D10-0x0000000185720D24
		public override string ToString() => default; // 0x0000000185720D54-0x0000000185720EC0
	}

	public struct Circle2 // TypeDefIndex: 54931
	{
		// Fields
		public Vector2 Center; // 0x00
		public float Radius; // 0x08
	
		// Constructors
		public Circle2(ref Vector2 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x0000000183D54AD0-0x0000000183D54AE0
		public Circle2(Vector2 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x0000000183D54AE0-0x0000000183D54AF0
	
		// Methods
		public static Circle2 CreateFromPointsAAB(IEnumerable<Vector2> points) => default; // 0x0000000185723634-0x0000000185723744
		public static Circle2 CreateFromPointsAAB(IList<Vector2> points) => default; // 0x000000018572356C-0x0000000185723634
		public static Circle2 CreateFromPointsAverage(IEnumerable<Vector2> points) => default; // 0x0000000185723918-0x0000000185723C4C
		public static Circle2 CreateFromPointsAverage(IList<Vector2> points) => default; // 0x0000000185723744-0x0000000185723918
		public static bool CreateCircumscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle) {
			circle = default;
			return default;
		} // 0x0000000185723350-0x000000018572356C
		public static bool CreateInscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle) {
			circle = default;
			return default;
		} // 0x0000000185723C4C-0x0000000185723E5C
		public float CalcPerimeter() => default; // 0x0000000183D549F0-0x0000000183D54A00
		public float CalcArea() => default; // 0x0000000183D549D0-0x0000000183D549F0
		public Vector2 Eval(float t) => default; // 0x0000000183D54A00-0x0000000183D54A60
		public Vector2 Eval(float t, float radius) => default; // 0x0000000183D54A60-0x0000000183D54AD0
		public float DistanceTo(Vector2 point) => default; // 0x0000000185723E5C-0x0000000185723E7C
		public Vector2 Project(Vector2 point) => default; // 0x0000000185723F78-0x0000000185723FA8
		public bool Contains(ref Vector2 point) => default; // 0x0000000185723308-0x0000000185723350
		public bool Contains(Vector2 point) => default; // 0x00000001857232BC-0x0000000185723308
		public void Include(ref Circle2 circle) {} // 0x0000000185723E90-0x0000000185723F78
		public void Include(Circle2 circle) {} // 0x0000000185723E7C-0x0000000185723E90
		public override string ToString() => default; // 0x0000000185723FA8-0x0000000185724030
	}

	public struct Line2 // TypeDefIndex: 54932
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Line2(ref Vector2 center, ref Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183D54650-0x0000000183D54670
		public Line2(Vector2 center, Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
	
		// Methods
		public static Line2 CreateFromTwoPoints(ref Vector2 p0, ref Vector2 p1) => default; // 0x0000000185725E24-0x0000000185725E90
		public static Line2 CreateFromTwoPoints(Vector2 p0, Vector2 p1) => default; // 0x0000000185725DD8-0x0000000185725E24
		public static Line2 CreatePerpToLineTrhoughPoint(Line2 line, Vector2 point) => default; // 0x0000000185725EF4-0x0000000185725F78
		public static Line2 CreateBetweenAndEquidistantToPoints(Vector2 point0, Vector2 point1) => default; // 0x0000000183D54AF0-0x0000000183D54B60
		public static Line2 CreateParallelToGivenLineAtGivenDistance(Line2 line, float distance) => default; // 0x0000000185725E90-0x0000000185725EF4
		public Vector2 Eval(float t) => default; // 0x0000000185725F98-0x0000000185725FC8
		public float SignedDistanceTo(Vector2 point) => default; // 0x0000000185726AA8-0x0000000185726B2C
		public float DistanceTo(Vector2 point) => default; // 0x0000000185725F78-0x0000000185725F98
		public int QuerySide(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x01FD689A */) => default; // 0x00000001857267C8-0x0000000185726884
		public bool QuerySideNegative(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x01FD689E */) => default; // 0x0000000185725FF8-0x000000018572608C
		public bool QuerySidePositive(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x01FD68A2 */) => default; // 0x00000001857263CC-0x0000000185726468
		public int QuerySide(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x01FD68A6 */) => default; // 0x0000000185726958-0x0000000185726AA8
		public bool QuerySideNegative(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x01FD68AA */) => default; // 0x0000000185726154-0x0000000185726284
		public bool QuerySidePositive(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x01FD68AE */) => default; // 0x0000000185726468-0x0000000185726590
		public int QuerySide(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x01FD68B2 */) => default; // 0x0000000185726660-0x00000001857267C8
		public bool QuerySideNegative(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x01FD68B6 */) => default; // 0x000000018572608C-0x0000000185726154
		public bool QuerySidePositive(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x01FD68BA */) => default; // 0x0000000185726590-0x0000000185726660
		public int QuerySide(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x01FD68BE */) => default; // 0x0000000185726884-0x0000000185726958
		public bool QuerySideNegative(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x01FD68C2 */) => default; // 0x0000000185726284-0x000000018572632C
		public bool QuerySidePositive(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x01FD68C6 */) => default; // 0x000000018572632C-0x00000001857263CC
		public Vector2 Project(Vector2 point) => default; // 0x0000000185725FC8-0x0000000185725FF8
		public float AngleBetweenTwoLines(Line2 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x01FD68CA */) => default; // 0x0000000185725D14-0x0000000185725DD8
		public override string ToString() => default; // 0x0000000185726B2C-0x0000000185726BC4
	}

	public struct Edge2 // TypeDefIndex: 54933
	{
		// Fields
		public Vector2 Point0; // 0x00
		public Vector2 Point1; // 0x08
		public Vector2 Direction; // 0x10
		public Vector2 Normal; // 0x18
		public float Length; // 0x20
	}

	public class Polygon2 // TypeDefIndex: 54934
	{
		// Fields
		private Vector2[] _vertices; // 0x10
		private Edge2[] _edges; // 0x18
	
		// Properties
		public Vector2[] Vertices { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Edge2[] Edges { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public int VertexCount { get => default; } // 0x00000001842746EC-0x0000000184274708 
		public Vector2 this[int vertexIndex] { get => default; set {} } // 0x000000018572B128-0x000000018572B154 0x000000018572B154-0x000000018572B19C
	
		// Constructors
		private Polygon2() {} // 0x000000018350B670-0x000000018350B680
		public Polygon2(Vector2[] vertices) {} // 0x000000018572B008-0x000000018572B0AC
		public Polygon2(int vertexCount) {} // 0x000000018572B0AC-0x000000018572B128
	
		// Methods
		public static Polygon2 CreateProjected(Polygon3 polygon, ProjectionPlanes projectionPlane) => default; // 0x0000000185729F20-0x000000018572A134
		public Edge2 GetEdge(int edgeIndex) => default; // 0x000000018572A134-0x000000018572A184
		public void UpdateEdges() {} // 0x000000018572AE48-0x000000018572B008
		public void UpdateEdge(int edgeIndex) {} // 0x000000018572ACA8-0x000000018572AE48
		public Vector2 CalcCenter() => default; // 0x0000000185729450-0x0000000185729518
		public float CalcPerimeter() => default; // 0x0000000185729518-0x0000000185729580
		public float CalcArea() => default; // 0x00000001857292C0-0x0000000185729450
		public bool IsConvex(out Orientations orientation, float threshold = 1E-05f /* Metadata: 0x01FD68CB */) {
			orientation = default;
			return default;
		} // 0x000000018572A270-0x000000018572A3EC
		public bool IsConvex(float threshold = 1E-05f /* Metadata: 0x01FD68CF */) => default; // 0x000000018572A248-0x000000018572A270
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x01FD68D3 */) => default; // 0x000000018572A184-0x000000018572A248
		public void ReverseVertices() {} // 0x000000018572A3EC-0x000000018572A4E0
		public bool ContainsConvexQuadCCW(ref Vector2 point) => default; // 0x0000000185729614-0x00000001857299F4
		public bool ContainsConvexQuadCCW(Vector2 point) => default; // 0x00000001857295F8-0x0000000185729614
		public bool ContainsConvexQuadCW(ref Vector2 point) => default; // 0x00000001857299F4-0x0000000185729DD4
		public bool ContainsConvexQuadCW(Vector2 point) => default; // 0x0000000185729DD4-0x0000000185729DF0
		public bool ContainsConvexCCW(ref Vector2 point) => default; // 0x0000000185729580-0x00000001857295A0
		public bool ContainsConvexCCW(Vector2 point) => default; // 0x00000001857295A0-0x00000001857295BC
		private bool SubContainsPointCCW(ref Vector2 p, int i0, int i1) => default; // 0x000000018572A4E0-0x000000018572A760
		public bool ContainsConvexCW(ref Vector2 point) => default; // 0x00000001857295BC-0x00000001857295DC
		public bool ContainsConvexCW(Vector2 point) => default; // 0x00000001857295DC-0x00000001857295F8
		private bool SubContainsPointCW(ref Vector2 p, int i0, int i1) => default; // 0x000000018572A760-0x000000018572A9E0
		public bool ContainsSimple(ref Vector2 point) => default; // 0x0000000185729E0C-0x0000000185729F20
		public bool ContainsSimple(Vector2 point) => default; // 0x0000000185729DF0-0x0000000185729E0C
		public Segment2[] ToSegmentArray() => default; // 0x000000018572A9E0-0x000000018572AB24
		public override string ToString() => default; // 0x000000018572AB24-0x000000018572ACA8
	}

	public struct Ray2 // TypeDefIndex: 54935
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Ray2(ref Vector2 center, ref Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183D54650-0x0000000183D54670
		public Ray2(Vector2 center, Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
	
		// Methods
		public Vector2 Eval(float t) => default; // 0x0000000185725F98-0x0000000185725FC8
		public float DistanceTo(Vector2 point) => default; // 0x000000018572B1F0-0x000000018572B210
		public Vector2 Project(Vector2 point) => default; // 0x000000018572B210-0x000000018572B240
		public override string ToString() => default; // 0x000000018572B240-0x000000018572B2D8
	}

	public struct Segment2 // TypeDefIndex: 54936
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
		} // 0x000000018572B6EC-0x000000018572B72C
		public Segment2(Vector2 p0, Vector2 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x000000018572B6A8-0x000000018572B6C4
		public Segment2(ref Vector2 center, ref Vector2 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x000000018572B72C-0x000000018572B790
		public Segment2(Vector2 center, Vector2 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x000000018572B6C4-0x000000018572B6EC
	
		// Methods
		public void SetEndpoints(Vector2 p0, Vector2 p1) {} // 0x000000018572B500-0x000000018572B510
		public void SetCenterDirectionExtent(Vector2 center, Vector2 direction, float extent) {} // 0x000000018572B4EC-0x000000018572B500
		public void CalcCenterDirectionExtent() {} // 0x000000018572B2D8-0x000000018572B3B8
		public void CalcEndPoints() {} // 0x000000018572B3B8-0x000000018572B450
		public Vector2 Eval(float s) => default; // 0x000000018572B470-0x000000018572B4BC
		public float DistanceTo(Vector2 point) => default; // 0x000000018572B450-0x000000018572B470
		public Vector2 Project(Vector2 point) => default; // 0x000000018572B4BC-0x000000018572B4EC
		public override string ToString() => default; // 0x000000018572B510-0x000000018572B6A8
	}

	public struct Triangle2 // TypeDefIndex: 54937
	{
		// Fields
		public Vector2 V0; // 0x00
		public Vector2 V1; // 0x08
		public Vector2 V2; // 0x10
	
		// Properties
		public Vector2 this[int index] { get => default; set {} } // 0x000000018572C6A8-0x000000018572C6E8 0x000000018572C6E8-0x000000018572C704
	
		// Constructors
		public Triangle2(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x0000000183D54D00-0x0000000183D54D40
		public Triangle2(Vector2 v0, Vector2 v1, Vector2 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x0000000183D54CF0-0x0000000183D54D00
	
		// Methods
		public Vector2 CalcEdge(int edgeIndex) => default; // 0x000000018572BF64-0x000000018572BFD8
		public float CalcDeterminant() => default; // 0x0000000183D54C90-0x0000000183D54CF0
		public Orientations CalcOrientation(float threshold = 1E-05f /* Metadata: 0x01FD68D7 */) => default; // 0x000000018572BFD8-0x000000018572C018
		public float CalcArea() => default; // 0x000000018572BD28-0x000000018572BD48
		public static float CalcArea(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x0000000183D54B80-0x0000000183D54BF0
		public static float CalcArea(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x0000000183D54BF0-0x0000000183D54C90
		public Vector3 CalcAnglesDeg() => default; // 0x000000018572B8E4-0x000000018572BA38
		public static Vector3 CalcAnglesDeg(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x000000018572B790-0x000000018572B8E4
		public static Vector3 CalcAnglesDeg(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x000000018572BA38-0x000000018572BA80
		public Vector3 CalcAnglesRad() => default; // 0x000000018572BBF8-0x000000018572BD28
		public static Vector3 CalcAnglesRad(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x000000018572BAC8-0x000000018572BBF8
		public static Vector3 CalcAnglesRad(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x000000018572BA80-0x000000018572BAC8
		public Vector2 EvalBarycentric(float c0, float c1) => default; // 0x000000018572C2CC-0x000000018572C364
		public Vector2 EvalBarycentric(ref Vector3 baryCoords) => default; // 0x000000018572C364-0x000000018572C3E0
		public Vector2 EvalBarycentric(Vector3 baryCoords) => default; // 0x000000018572C364-0x000000018572C3E0
		public static void CalcBarycentricCoords(ref Vector2 point, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2, out Vector3 baryCoords) {
			baryCoords = default;
		} // 0x000000018572BD80-0x000000018572BF28
		public Vector3 CalcBarycentricCoords(ref Vector2 point) => default; // 0x000000018572BD48-0x000000018572BD80
		public Vector3 CalcBarycentricCoords(Vector2 point) => default; // 0x000000018572BF28-0x000000018572BF64
		public float DistanceTo(Vector2 point) => default; // 0x000000018572C2AC-0x000000018572C2CC
		public int QuerySideCCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x01FD68DB */) => default; // 0x000000018572C410-0x000000018572C4F4
		public int QuerySideCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x01FD68DF */) => default; // 0x000000018572C4F4-0x000000018572C5E4
		public Vector2 Project(Vector2 point) => default; // 0x000000018572C3E0-0x000000018572C410
		public bool Contains(ref Vector2 point) => default; // 0x000000018572C1B0-0x000000018572C290
		public bool Contains(Vector2 point) => default; // 0x000000018572C290-0x000000018572C2AC
		public bool ContainsCCW(ref Vector2 point) => default; // 0x000000018572C034-0x000000018572C0E4
		public bool ContainsCCW(Vector2 point) => default; // 0x000000018572C018-0x000000018572C034
		public bool ContainsCW(ref Vector2 point) => default; // 0x000000018572C100-0x000000018572C1B0
		public bool ContainsCW(Vector2 point) => default; // 0x000000018572C0E4-0x000000018572C100
		public override string ToString() => default; // 0x000000018572C5E4-0x000000018572C6A8
	}

	public struct AAB3 // TypeDefIndex: 54938
	{
		// Fields
		public Vector3 Min; // 0x00
		public Vector3 Max; // 0x0C
	
		// Constructors
		public AAB3(ref Vector3 min, ref Vector3 max) {
			Min = default;
			Max = default;
		} // 0x0000000183D54810-0x0000000183D54830
		public AAB3(Vector3 min, Vector3 max) {
			Min = default;
			Max = default;
		} // 0x0000000183D4FF30-0x0000000183D4FF50
		public AAB3(float xMin, float xMax, float yMin, float yMax, float zMin, float zMax) {
			Min = default;
			Max = default;
		} // 0x0000000183D54830-0x0000000183D54860
	
		// Methods
		public static implicit operator Bounds(AAB3 value) => default; // 0x000000018571FE44-0x000000018571FEB0
		public static implicit operator AAB3(Bounds value) => default; // 0x000000018571FDE0-0x000000018571FE44
		public static AAB3 CreateFromPoint(ref Vector3 point) => default; // 0x0000000183D547F0-0x0000000183D54810
		public static AAB3 CreateFromPoint(Vector3 point) => default; // 0x0000000183D547F0-0x0000000183D54810
		public static AAB3 CreateFromTwoPoints(ref Vector3 point0, ref Vector3 point1) => default; // 0x000000018571FBA8-0x000000018571FC20
		public static AAB3 CreateFromTwoPoints(Vector3 point0, Vector3 point1) => default; // 0x000000018571FB78-0x000000018571FBA8
		public static AAB3 CreateFromPoints(IEnumerable<Vector3> points) => default; // 0x000000018571F7C4-0x000000018571F93C
		public static AAB3 CreateFromPoints(IList<Vector3> points) => default; // 0x000000018571F93C-0x000000018571FA8C
		public static AAB3 CreateFromPoints(Vector3[] points) => default; // 0x000000018571FA8C-0x000000018571FB78
		public void CalcCenterExtents(out Vector3 center, out Vector3 extents) {
			center = default;
			extents = default;
		} // 0x0000000182A5CC00-0x0000000182A5CC80
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
			vertex4 = default;
			vertex5 = default;
			vertex6 = default;
			vertex7 = default;
		} // 0x0000000183D546D0-0x0000000183D547C0
		public Vector3[] CalcVertices() => default; // 0x000000018571F5D0-0x000000018571F77C
		public void CalcVertices(Vector3[] array) {} // 0x000000018571F454-0x000000018571F5D0
		public float CalcVolume() => default; // 0x0000000183D547C0-0x0000000183D547F0
		public float DistanceTo(Vector3 point) => default; // 0x000000018571FC20-0x000000018571FC3C
		public Vector3 Project(Vector3 point) => default; // 0x000000018571FD08-0x000000018571FD34
		public bool Contains(ref Vector3 point) => default; // 0x000000018294A060-0x000000018294A0B0
		public bool Contains(Vector3 point) => default; // 0x000000018571F77C-0x000000018571F7C4
		public void Include(ref Vector3 point) {} // 0x000000018571FC3C-0x000000018571FCA0
		public void Include(Vector3 point) {} // 0x000000018571FC3C-0x000000018571FCA0
		public void Include(ref AAB3 box) {} // 0x000000018571FCA0-0x000000018571FCD4
		public void Include(AAB3 box) {} // 0x000000018571FCD4-0x000000018571FD08
		public override string ToString() => default; // 0x000000018571FD34-0x000000018571FDE0
	}

	public struct Box3 // TypeDefIndex: 54939
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
		} // 0x0000000183D54910-0x0000000183D54970
		public Box3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector3 axis2, Vector3 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x0000000183D54970-0x0000000183D549D0
		public Box3(ref AAB3 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x000000018572320C-0x00000001857232BC
		public Box3(AAB3 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x0000000182A5CB30-0x0000000182A5CC00
	
		// Methods
		public static Box3 CreateFromPoints(IList<Vector3> points) => default; // 0x0000000185722294-0x00000001857227F4
		public Vector3 GetAxis(int index) => default; // 0x0000000185722810-0x00000001857228AC
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
			vertex4 = default;
			vertex5 = default;
			vertex6 = default;
			vertex7 = default;
		} // 0x0000000185721BA0-0x00000001857220E8
		public Vector3[] CalcVertices() => default; // 0x0000000185720FF8-0x00000001857215E4
		public void CalcVertices(Vector3[] array) {} // 0x00000001857215E4-0x0000000185721BA0
		public float CalcVolume() => default; // 0x0000000183D548F0-0x0000000183D54910
		public float DistanceTo(Vector3 point) => default; // 0x00000001857227F4-0x0000000185722810
		public Vector3 Project(Vector3 point) => default; // 0x000000018572301C-0x0000000185723048
		public bool Contains(ref Vector3 point) => default; // 0x00000001857220E8-0x0000000185722280
		public bool Contains(Vector3 point) => default; // 0x0000000185722280-0x0000000185722294
		public void Include(ref Box3 box) {} // 0x00000001857228AC-0x0000000185723008
		public void Include(Box3 box) {} // 0x0000000185723008-0x000000018572301C
		public override string ToString() => default; // 0x0000000185723048-0x000000018572320C
	}

	public struct Capsule3 // TypeDefIndex: 54940
	{
		// Fields
		public Segment3 Segment; // 0x00
		public float Radius; // 0x34
	
		// Constructors
		public Capsule3(ref Segment3 segment, float radius) {
			Segment = default;
			Radius = default;
		} // 0x0000000183D54D40-0x0000000183D54D70
		public Capsule3(Segment3 segment, float radius) {
			Segment = default;
			Radius = default;
		} // 0x0000000183D54D70-0x0000000183D54DA0
	}

	public struct Circle3 // TypeDefIndex: 54941
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
		} // 0x000000018572E214-0x000000018572E308
		public Circle3(Vector3 center, Vector3 axis0, Vector3 axis1, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x000000018572E308-0x000000018572E3E8
		public Circle3(ref Vector3 center, ref Vector3 normal, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x000000018572E180-0x000000018572E214
		public Circle3(Vector3 center, Vector3 normal, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x000000018572E3E8-0x000000018572E47C
	
		// Methods
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle) {
			circle = default;
			return default;
		} // 0x000000018572D4C4-0x000000018572D864
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle) {
			circle = default;
			return default;
		} // 0x000000018572D864-0x000000018572DD44
		public float CalcPerimeter() => default; // 0x0000000183D54DC0-0x0000000183D54DD0
		public float CalcArea() => default; // 0x0000000183D54DA0-0x0000000183D54DC0
		public Vector3 Eval(float t) => default; // 0x000000018572DD60-0x000000018572DE78
		public Vector3 Eval(float t, float radius) => default; // 0x000000018572DE78-0x000000018572DF9C
		public float DistanceTo(Vector3 point, bool solid = true /* Metadata: 0x01FD68E3 */) => default; // 0x000000018572DD44-0x000000018572DD60
		public Vector3 Project(Vector3 point, bool solid = true /* Metadata: 0x01FD68E4 */) => default; // 0x000000018572DF9C-0x000000018572DFCC
		public override string ToString() => default; // 0x000000018572DFCC-0x000000018572E180
	}

	public struct Line3 // TypeDefIndex: 54942
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Line3(ref Vector3 center, ref Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183D54810-0x0000000183D54830
		public Line3(Vector3 center, Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183D4FF30-0x0000000183D4FF50
	
		// Methods
		public static Line3 CreateFromTwoPoints(ref Vector3 p0, ref Vector3 p1) => default; // 0x0000000185731E78-0x0000000185731F04
		public static Line3 CreateFromTwoPoints(Vector3 p0, Vector3 p1) => default; // 0x0000000185731E78-0x0000000185731F04
		public Vector3 Eval(float t) => default; // 0x0000000185731F20-0x0000000185731F9C
		public float DistanceTo(Vector3 point) => default; // 0x0000000185731F04-0x0000000185731F20
		public Vector3 Project(Vector3 point) => default; // 0x0000000185731F9C-0x0000000185731FC8
		public float AngleBetweenTwoLines(Line3 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x01FD68E5 */) => default; // 0x0000000185731DB0-0x0000000185731E78
		public override string ToString() => default; // 0x0000000185731FC8-0x0000000185732074
	}

	[Serializable]
	public struct Plane3 // TypeDefIndex: 54943
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float Constant; // 0x0C
	
		// Constructors
		public Plane3(ref Vector3 normal, float constant) {
			Normal = default;
			Constant = default;
		} // 0x0000000182103850-0x00000001821038C0
		public Plane3(Vector3 normal, float constant) {
			Normal = default;
			Constant = default;
		} // 0x0000000182103850-0x00000001821038C0
		public Plane3(ref Vector3 normal, ref Vector3 point) {
			Normal = default;
			Constant = default;
		} // 0x0000000185733DA4-0x0000000185733E50
		public Plane3(Vector3 normal, Vector3 point) {
			Normal = default;
			Constant = default;
		} // 0x0000000185733D0C-0x0000000185733DA4
		public Plane3(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2) {
			Normal = default;
			Constant = default;
		} // 0x0000000185733F98-0x00000001857340E0
		public Plane3(Vector3 p0, Vector3 p1, Vector3 p2) {
			Normal = default;
			Constant = default;
		} // 0x0000000185733E50-0x0000000185733F98
	
		// Methods
		public static implicit operator Plane(Plane3 value) => default; // 0x00000001857340E0-0x0000000185734124
		public static implicit operator Plane3(Plane value) => default; // 0x0000000183D54DD0-0x0000000183D54E00
		public Vector3 CalcOrigin() => default; // 0x0000000185732AB0-0x0000000185732AF4
		public void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, out Vector3 n) {
			u = default;
			v = default;
			n = default;
		} // 0x0000000185732AF4-0x0000000185732BFC
		internal float SignedDistanceTo(ref Vector3 point) => default; // 0x0000000185733BD8-0x0000000185733C74
		public float SignedDistanceTo(Vector3 point) => default; // 0x0000000185733B48-0x0000000185733BD8
		public float DistanceTo(Vector3 point) => default; // 0x0000000185732BFC-0x0000000185732C94
		public int QuerySide(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x01FD68E6 */) => default; // 0x0000000185733A80-0x0000000185733B48
		public bool QuerySideNegative(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x01FD68EA */) => default; // 0x0000000185733074-0x0000000185733118
		public bool QuerySidePositive(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x01FD68EE */) => default; // 0x00000001857333BC-0x0000000185733468
		public int QuerySide(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x01FD68F2 */) => default; // 0x00000001857338B8-0x0000000185733A80
		public bool QuerySideNegative(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x01FD68F6 */) => default; // 0x0000000185732DC0-0x0000000185732F68
		public bool QuerySidePositive(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x01FD68FA */) => default; // 0x0000000185733468-0x0000000185733608
		public int QuerySide(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x01FD68FE */) => default; // 0x0000000185733700-0x00000001857338B8
		public bool QuerySideNegative(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x01FD6902 */) => default; // 0x0000000185732F68-0x0000000185733074
		public bool QuerySidePositive(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x01FD6906 */) => default; // 0x00000001857332A8-0x00000001857333BC
		public int QuerySide(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x01FD690A */) => default; // 0x0000000185733608-0x0000000185733700
		public bool QuerySideNegative(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x01FD690E */) => default; // 0x0000000185733118-0x00000001857331E4
		public bool QuerySidePositive(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x01FD6912 */) => default; // 0x00000001857331E4-0x00000001857332A8
		public Vector3 Project(Vector3 point) => default; // 0x0000000185732D94-0x0000000185732DC0
		public Vector3 ProjectVector(Vector3 vector) => default; // 0x0000000185732C94-0x0000000185732D94
		public float AngleBetweenPlaneNormalAndLine(Line3 line) => default; // 0x0000000185732954-0x0000000185732A0C
		public float AngleBetweenPlaneNormalAndLine(Vector3 direction) => default; // 0x00000001857328A8-0x0000000185732954
		public float AngleBetweenPlaneAndLine(Line3 line) => default; // 0x00000001857327E0-0x00000001857328A8
		public float AngleBetweenPlaneAndLine(Vector3 direction) => default; // 0x0000000185732724-0x00000001857327E0
		public float AngleBetweenTwoPlanes(Plane3 anotherPlane) => default; // 0x0000000185732A0C-0x0000000185732AB0
		public override string ToString() => default; // 0x0000000185733C74-0x0000000185733D0C
	}

	[Serializable]
	public struct Edge3 // TypeDefIndex: 54944
	{
		// Fields
		public Vector3 Point0; // 0x00
		public Vector3 Point1; // 0x0C
		public Vector3 Direction; // 0x18
		public Vector3 Normal; // 0x24
		public float Length; // 0x30
	}

	[Serializable]
	public class Polygon3 // TypeDefIndex: 54945
	{
		// Fields
		[SerializeField]
		private Vector3[] _vertices; // 0x10
		[SerializeField]
		private Edge3[] _edges; // 0x18
		[SerializeField]
		private Plane3 _plane; // 0x20
	
		// Properties
		public Vector3[] Vertices { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Edge3[] Edges { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public int VertexCount { get => default; } // 0x00000001842746EC-0x0000000184274708 
		public Vector3 this[int vertexIndex] { get => default; set {} } // 0x0000000185735A50-0x0000000185735A7C 0x0000000185735A7C-0x0000000185735AB4
		public Plane3 Plane { get => default; set {} } // 0x0000000183D54E00-0x0000000183D54E10 0x0000000183D54E10-0x0000000183D54E20
	
		// Constructors
		private Polygon3() {} // 0x000000018350B670-0x000000018350B680
		public Polygon3(Vector3[] vertices, Plane3 plane) {} // 0x0000000185735998-0x0000000185735A50
		public Polygon3(int vertexCount, Plane3 plane) {} // 0x0000000185735908-0x0000000185735998
	
		// Methods
		public void SetVertexProjected(int vertexIndex, Vector3 vertex) {} // 0x000000018573510C-0x0000000185735230
		public void ProjectVertices() {} // 0x0000000185734EAC-0x0000000185735020
		public Edge3 GetEdge(int edgeIndex) => default; // 0x0000000185734D4C-0x0000000185734DA8
		public void UpdateEdges() {} // 0x0000000185735700-0x0000000185735908
		public void UpdateEdge(int edgeIndex) {} // 0x0000000185735528-0x0000000185735700
		public Vector3 CalcCenter() => default; // 0x0000000185734BB4-0x0000000185734CE4
		public float CalcPerimeter() => default; // 0x0000000185734CE4-0x0000000185734D4C
		public bool HasZeroCorners(float threshold = 1E-05f /* Metadata: 0x01FD6916 */) => default; // 0x0000000185734DA8-0x0000000185734EAC
		public void ReverseVertices() {} // 0x0000000185735020-0x000000018573510C
		public Segment3[] ToSegmentArray() => default; // 0x0000000185735230-0x0000000185735388
		public override string ToString() => default; // 0x0000000185735388-0x0000000185735528
	}

	public struct Ray3 // TypeDefIndex: 54946
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Ray3(ref Vector3 center, ref Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183D54810-0x0000000183D54830
		public Ray3(Vector3 center, Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000183D4FF30-0x0000000183D4FF50
	
		// Methods
		public static implicit operator Ray(Ray3 value) => default; // 0x00000001857369D4-0x0000000185736A28
		public static implicit operator Ray3(Ray value) => default; // 0x0000000183D55160-0x0000000183D55190
		public Vector3 Eval(float t) => default; // 0x0000000185731F20-0x0000000185731F9C
		public float DistanceTo(Vector3 point) => default; // 0x00000001857368E0-0x00000001857368FC
		public Vector3 Project(Vector3 point) => default; // 0x00000001857368FC-0x0000000185736928
		public override string ToString() => default; // 0x0000000185736928-0x00000001857369D4
	}

	public struct Rectangle3 // TypeDefIndex: 54947
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
		} // 0x0000000185737858-0x0000000185737970
		public Rectangle3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Extents = default;
		} // 0x0000000185737778-0x0000000185737858
	
		// Methods
		public static Rectangle3 CreateFromCCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x0000000185737160-0x0000000185737358
		public static Rectangle3 CreateFromCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x0000000185737358-0x0000000185737550
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x0000000185736C9C-0x0000000185736EBC
		public Vector3[] CalcVertices() => default; // 0x0000000185736EBC-0x0000000185737160
		public void CalcVertices(Vector3[] array) {} // 0x0000000185736A28-0x0000000185736C9C
		public float CalcArea() => default; // 0x0000000183D55190-0x0000000183D551B0
		public float DistanceTo(Vector3 point) => default; // 0x0000000185737550-0x000000018573756C
		public Vector3 Project(Vector3 point) => default; // 0x000000018573756C-0x0000000185737598
		public override string ToString() => default; // 0x0000000185737598-0x0000000185737778
	}

	public struct Segment3 // TypeDefIndex: 54948
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
		} // 0x0000000185737EB0-0x0000000185737F10
		public Segment3(Vector3 p0, Vector3 p1) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x0000000185737E50-0x0000000185737EB0
		public Segment3(ref Vector3 center, ref Vector3 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x0000000185737F70-0x0000000185737FD0
		public Segment3(Vector3 center, Vector3 direction, float extent) {
			P0 = default;
			P1 = default;
			Center = default;
			Direction = default;
			Extent = default;
		} // 0x0000000185737F10-0x0000000185737F70
	
		// Methods
		public void SetEndpoints(Vector3 p0, Vector3 p1) {} // 0x0000000185737C74-0x0000000185737C9C
		public void SetCenterDirectionExtent(Vector3 center, Vector3 direction, float extent) {} // 0x0000000185737C48-0x0000000185737C74
		public void CalcCenterDirectionExtent() {} // 0x0000000185737970-0x0000000185737A80
		public void CalcEndPoints() {} // 0x0000000185737A80-0x0000000185737B60
		public Vector3 Eval(float s) => default; // 0x0000000185737B7C-0x0000000185737C1C
		public float DistanceTo(Vector3 point) => default; // 0x0000000185737B60-0x0000000185737B7C
		public Vector3 Project(Vector3 point) => default; // 0x0000000185737C1C-0x0000000185737C48
		public override string ToString() => default; // 0x0000000185737C9C-0x0000000185737E50
	}

	public struct Sphere3 // TypeDefIndex: 54949
	{
		// Fields
		private const float _4div3mulPi = 4.1887903f; // Metadata: 0x01FD691A
		public Vector3 Center; // 0x00
		public float Radius; // 0x0C
	
		// Constructors
		public Sphere3(ref Vector3 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x0000000182103850-0x00000001821038C0
		public Sphere3(Vector3 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x0000000182103850-0x00000001821038C0
	
		// Methods
		public static Sphere3 CreateFromPointsAAB(IEnumerable<Vector3> points) => default; // 0x000000018573843C-0x0000000185738560
		public static Sphere3 CreateFromPointsAAB(IList<Vector3> points) => default; // 0x0000000185738364-0x000000018573843C
		public static Sphere3 CreateFromPointsAverage(IEnumerable<Vector3> points) => default; // 0x0000000185738560-0x000000018573890C
		public static Sphere3 CreateFromPointsAverage(IList<Vector3> points) => default; // 0x000000018573890C-0x0000000185738B00
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere) {
			sphere = default;
			return default;
		} // 0x0000000185738040-0x0000000185738364
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, out Sphere3 sphere) {
			sphere = default;
			return default;
		} // 0x0000000185738B00-0x0000000185739128
		public float CalcArea() => default; // 0x0000000183D551B0-0x0000000183D551D0
		public float CalcVolume() => default; // 0x0000000183D551D0-0x0000000183D551F0
		public Vector3 Eval(float theta, float phi) => default; // 0x0000000183D551F0-0x0000000183D55290
		public float DistanceTo(Vector3 point) => default; // 0x0000000185739128-0x0000000185739144
		public Vector3 Project(Vector3 point) => default; // 0x00000001857392A0-0x00000001857392CC
		public bool Contains(ref Vector3 point) => default; // 0x0000000185737FD0-0x0000000185738040
		public bool Contains(Vector3 point) => default; // 0x0000000185737FD0-0x0000000185738040
		public void Include(ref Sphere3 sphere) {} // 0x0000000185739144-0x000000018573928C
		public void Include(Sphere3 sphere) {} // 0x000000018573928C-0x00000001857392A0
		public override string ToString() => default; // 0x00000001857392CC-0x0000000185739364
	}

	public struct Triangle3 // TypeDefIndex: 54950
	{
		// Fields
		public Vector3 V0; // 0x00
		public Vector3 V1; // 0x0C
		public Vector3 V2; // 0x18
	
		// Properties
		public Vector3 this[int index] { get => default; set {} } // 0x000000018573BFF0-0x000000018573C050 0x000000018573C050-0x000000018573C094
	
		// Constructors
		public Triangle3(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x0000000183D552D0-0x0000000183D55310
		public Triangle3(Vector3 v0, Vector3 v1, Vector3 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x0000000183D55290-0x0000000183D552D0
	
		// Methods
		public Vector3 CalcEdge(int edgeIndex) => default; // 0x000000018573BBB4-0x000000018573BC78
		public Vector3 CalcNormal() => default; // 0x000000018573BC78-0x000000018573BD2C
		public float CalcArea() => default; // 0x000000018573B8A4-0x000000018573B964
		public static float CalcArea(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x000000018573B7E4-0x000000018573B8A4
		public static float CalcArea(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x000000018573B7E4-0x000000018573B8A4
		public Vector3 CalcAnglesDeg() => default; // 0x000000018573B350-0x000000018573B4DC
		public static Vector3 CalcAnglesDeg(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x000000018573B18C-0x000000018573B31C
		public static Vector3 CalcAnglesDeg(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x000000018573B31C-0x000000018573B350
		public Vector3 CalcAnglesRad() => default; // 0x000000018573B67C-0x000000018573B7E4
		public static Vector3 CalcAnglesRad(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x000000018573B4DC-0x000000018573B648
		public static Vector3 CalcAnglesRad(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x000000018573B648-0x000000018573B67C
		public Vector3 EvalBarycentric(float c0, float c1) => default; // 0x000000018573BE1C-0x000000018573BF14
		public Vector3 EvalBarycentric(ref Vector3 baryCoords) => default; // 0x000000018573BD2C-0x000000018573BE1C
		public Vector3 EvalBarycentric(Vector3 baryCoords) => default; // 0x000000018573BD2C-0x000000018573BE1C
		public static void CalcBarycentricCoords(ref Vector3 point, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Vector3 baryCoords) {
			baryCoords = default;
		} // 0x000000018573B99C-0x000000018573BBB4
		public Vector3 CalcBarycentricCoords(ref Vector3 point) => default; // 0x000000018573B964-0x000000018573B99C
		public Vector3 CalcBarycentricCoords(Vector3 point) => default; // 0x000000018573B964-0x000000018573B99C
		public override string ToString() => default; // 0x000000018573BF14-0x000000018573BFF0
	}

	public enum Orientations // TypeDefIndex: 54951
	{
		CW = 0,
		CCW = 1,
		None = 2
	}

	internal class Query2 : Query // TypeDefIndex: 54952
	{
		// Fields
		private static float Zero; // 0x00
		private Vector2[] _vertices; // 0x10
	
		// Constructors
		public Query2() {} // Dummy constructor
		public Query2(Vector2[] vertices) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public int ToLine(int i, int v0, int v1) => default; // 0x0000000185735E00-0x0000000185735E58
		public int ToLine(ref Vector2 test, int v0, int v1) => default; // 0x0000000185735D0C-0x0000000185735E00
		public int ToTriangle(int i, int v0, int v1, int v2) => default; // 0x0000000185735F00-0x0000000185735F60
		public int ToTriangle(ref Vector2 test, int v0, int v1, int v2) => default; // 0x0000000185735E58-0x0000000185735F00
		public int ToCircumcircle(int i, int v0, int v1, int v2) => default; // 0x0000000185735AB4-0x0000000185735B14
		public int ToCircumcircle(ref Vector2 test, int v0, int v1, int v2) => default; // 0x0000000185735B14-0x0000000185735D0C
		public float Dot(float x0, float y0, float x1, float y1) => default; // 0x0000000183D54F00-0x0000000183D54F20
		public float Det2(float x0, float y0, float x1, float y1) => default; // 0x0000000183D54E20-0x0000000183D54E40
		public float Det3(float x0, float y0, float z0, float x1, float y1, float z1, float x2, float y2, float z2) => default; // 0x0000000183D54E40-0x0000000183D54F00
	}

	internal class Query3 : Query // TypeDefIndex: 54953
	{
		// Fields
		private static float Zero; // 0x00
		private Vector3[] _vertices; // 0x10
	
		// Constructors
		public Query3() {} // Dummy constructor
		public Query3(Vector3[] vertices) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public int ToPlane(int i, int v0, int v1, int v2) => default; // 0x000000018573635C-0x00000001857363BC
		public int ToPlane(ref Vector3 test, int v0, int v1, int v2) => default; // 0x00000001857363BC-0x0000000185736578
		public int ToTetrahedron(int i, int v0, int v1, int v2, int v3) => default; // 0x0000000185736578-0x00000001857365E0
		public int ToTetrahedron(ref Vector3 test, int v0, int v1, int v2, int v3) => default; // 0x00000001857365E0-0x00000001857366CC
		public int ToCircumsphere(int i, int v0, int v1, int v2, int v3) => default; // 0x00000001857362F4-0x000000018573635C
		public int ToCircumsphere(ref Vector3 test, int v0, int v1, int v2, int v3) => default; // 0x0000000185735F60-0x00000001857362F4
		public float Dot(float x0, float y0, float z0, float x1, float y1, float z1) => default; // 0x0000000183D55140-0x0000000183D55160
		public float Det3(float x0, float y0, float z0, float x1, float y1, float z1, float x2, float y2, float z2) => default; // 0x0000000183D54E40-0x0000000183D54F00
		public float Det4(float x0, float y0, float z0, float w0, float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2, float x3, float y3, float z3, float w3) => default; // 0x0000000183D54F20-0x0000000183D55140
	}

	internal enum QueryTypes // TypeDefIndex: 54954
	{
		Int64 = 0,
		Integer = 1,
		Rational = 2,
		Real = 3,
		Filtered = 4
	}

	internal class Query // TypeDefIndex: 54955
	{
		// Constructors
		protected Query() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool Sort(ref int v0, ref int v1) => default; // 0x00000001857368CC-0x00000001857368E0
		public static bool Sort(ref int v0, ref int v1, ref int v2) => default; // 0x00000001857366CC-0x000000018573673C
		public static bool Sort(ref int v0, ref int v1, ref int v2, ref int v3) => default; // 0x000000018573673C-0x00000001857368CC
	}

	public class CatmullRomSpline3 : SplineBase // TypeDefIndex: 54956
	{
		// Properties
		public override SplineTypes SplineType { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x000000018572D454-0x000000018572D4C4
	
		// Constructors
		public CatmullRomSpline3() {} // 0x000000018572D44C-0x000000018572D454
	
		// Methods
		public static CatmullRomSpline3 Create() => default; // 0x000000018572C900-0x000000018572C97C
		public static CatmullRomSpline3 Create(IList<Vector3> points, SplineTypes type) => default; // 0x000000018572C97C-0x000000018572CB8C
		private void UpdateSegment(int index) {} // 0x000000018572CF68-0x000000018572D44C
		private void UpdateAdjacentSegments(int vertexIndex) {} // 0x000000018572CE38-0x000000018572CF68
		public override void AddVertexFirst(Vector3 position) {} // 0x000000018572C7D4-0x000000018572C808
		public override void AddVertexLast(Vector3 position) {} // 0x000000018572C808-0x000000018572C8B4
		public override void RemoveVertex(int index) {} // 0x000000018572CD48-0x000000018572CDB0
		public override void Clear() {} // 0x000000018572C8B4-0x000000018572C900
		public override void InsertBefore(int vertexIndex, Vector3 position) {} // 0x000000018572CCA8-0x000000018572CD48
		public override void InsertAfter(int vertexIndex, Vector3 position) {} // 0x000000018572CC04-0x000000018572CCA8
		public override Vector3 GetVertex(int vertexIndex) => default; // 0x000000018572CB8C-0x000000018572CC04
		public override void SetVertex(int vertexIndex, Vector3 position) {} // 0x000000018572CDB0-0x000000018572CE38
	}

	public class CubicSpline3 : SplineBase // TypeDefIndex: 54957
	{
		// Properties
		public override SplineTypes SplineType { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000185730100-0x0000000185730114
	
		// Constructors
		public CubicSpline3() {} // 0x000000018572D44C-0x000000018572D454
	
		// Methods
		public static CubicSpline3 Create() => default; // 0x000000018572FBFC-0x000000018572FC78
		public static CubicSpline3 Create(IList<Vector3> points, SplineTypes type) => default; // 0x000000018572FC78-0x000000018572FE60
		private void BuildSpline() {} // 0x000000018572E5A0-0x000000018572E608
		private void CreateOpenedSpline() {} // 0x000000018572F418-0x000000018572FBFC
		private void CreateClosedSpline() {} // 0x000000018572E654-0x000000018572F418
		public override void AddVertexFirst(Vector3 position) {} // 0x000000018572E47C-0x000000018572E510
		public override void AddVertexLast(Vector3 position) {} // 0x000000018572E510-0x000000018572E5A0
		public override void RemoveVertex(int index) {} // 0x0000000185730018-0x000000018573007C
		public override void Clear() {} // 0x000000018572E608-0x000000018572E654
		public override void InsertBefore(int vertexIndex, Vector3 position) {} // 0x000000018572FF78-0x0000000185730018
		public override void InsertAfter(int vertexIndex, Vector3 position) {} // 0x000000018572FED8-0x000000018572FF78
		public override Vector3 GetVertex(int vertexIndex) => default; // 0x000000018572FE60-0x000000018572FED8
		public override void SetVertex(int vertexIndex, Vector3 position) {} // 0x000000018573007C-0x0000000185730100
	}

	public enum SplineTypes // TypeDefIndex: 54958
	{
		Open = 0,
		Closed = 1
	}

	public enum SplinePlaneTypes // TypeDefIndex: 54959
	{
		XZ = 0,
		XY = 1,
		YZ = 2
	}

	public struct PositionTangent // TypeDefIndex: 54960
	{
		// Fields
		public Vector3 Position; // 0x00
		public Vector3 Tangent; // 0x0C
	}

	public struct CurveFrame // TypeDefIndex: 54961
	{
		// Fields
		public Vector3 Position; // 0x00
		public Vector3 Tangent; // 0x0C
		public Vector3 Normal; // 0x18
		public Vector3 Binormal; // 0x24
	}

	public abstract class SplineBase : MonoBehaviour // TypeDefIndex: 54964
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
		protected int SegmentCount { get; } // 0x000000018573B0B8-0x000000018573B108 
		public int VertexCount { get; } // 0x000000018573B14C-0x000000018573B18C 
		public bool Valid { get; } // 0x000000018573B108-0x000000018573B14C 
		public abstract SplineTypes SplineType { get; set; }
	
		// Nested types
		[Serializable]
		protected class ItemData // TypeDefIndex: 54962
		{
			// Fields
			public Vector3 Position; // 0x10
			public Vector3 A; // 0x1C
			public Vector3 B; // 0x28
			public Vector3 C; // 0x34
			public Vector3 D; // 0x40
			public float Length; // 0x4C
			public float AccumulatedLength; // 0x50
			private const int SegmentCount = 10; // Metadata: 0x01FD692B
			private const int SegmentCountPlus1 = 11; // Metadata: 0x01FD692C
			private const float DeltaTime = 0.1f; // Metadata: 0x01FD692D
			public Vector3[] RenderPoints; // 0x58
	
			// Constructors
			public ItemData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool EnsureRenderPointsValidity() => default; // 0x000000018573163C-0x000000018573169C
			public void UpdateRenderPoints() {} // 0x0000000185731D38-0x0000000185731DB0
			public Vector3 EvalPosition(float t) => default; // 0x00000001857318E4-0x0000000185731A04
			public Vector3 EvalFirstDerivative(float t) => default; // 0x000000018573169C-0x0000000185731794
			public Vector3 EvalSecondDerivative(float t) => default; // 0x0000000185731A04-0x0000000185731AA8
			public Vector3 EvalThirdDerivative(float t) => default; // 0x0000000185731CBC-0x0000000185731D04
			public float EvalSpeed(float t) => default; // 0x0000000185731AA8-0x0000000185731BA4
			public Vector3 EvalTangent(float t) => default; // 0x0000000185731BA4-0x0000000185731CBC
			public float EvalLength() => default; // 0x0000000185731794-0x0000000185731830
			public float EvalLength(float t0, float t1) => default; // 0x0000000185731830-0x00000001857318E4
			public float ProcessLength(float currentLength) => default; // 0x0000000185731D04-0x0000000185731D38
		}
	
		protected class ArcLengthParametrization // TypeDefIndex: 54963
		{
			// Fields
			public float[] sSample; // 0x10
			public float[] tSample; // 0x18
			public float[] tsSlope; // 0x20
			public float L; // 0x28
	
			// Constructors
			public ArcLengthParametrization() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public float GetApproximateTimeParameter(float s) => default; // 0x000000018572C704-0x000000018572C7D4
		}
	
		// Constructors
		protected SplineBase() {} // 0x000000018573B020-0x000000018573B0B8
	
		// Methods
		private void Awake() {} // 0x0000000185739364-0x000000018573936C
		protected void GetSegmentIndexAndTime(float time, out int segmentIndex, out float segmentTime) {
			segmentIndex = default;
			segmentTime = default;
		} // 0x000000018573A888-0x000000018573A918
		protected void PrepareForRuntime() {} // 0x000000018573AEB8-0x000000018573AF4C
		protected void RecalcSegmentsLength() {} // 0x000000018573AF4C-0x000000018573B020
		public abstract void AddVertexFirst(Vector3 position);
		public abstract void AddVertexLast(Vector3 position);
		public abstract void RemoveVertex(int index);
		public abstract void Clear();
		public abstract void InsertBefore(int vertexIndex, Vector3 position);
		public abstract void InsertAfter(int vertexIndex, Vector3 position);
		public abstract Vector3 GetVertex(int vertexIndex);
		public abstract void SetVertex(int vertexIndex, Vector3 position);
		public Vector3 EvalPosition(float time) => default; // 0x000000018573A184-0x000000018573A238
		public Vector3 EvalTangent(float time) => default; // 0x000000018573A3C8-0x000000018573A47C
		public PositionTangent EvalPositionTangent(float time) => default; // 0x0000000185739FE8-0x000000018573A0D0
		public void EvalPosition(float time, out Vector3 position) {
			position = default;
		} // 0x000000018573A0D0-0x000000018573A184
		public void EvalTangent(float time, out Vector3 tangent) {
			tangent = default;
		} // 0x000000018573A47C-0x000000018573A530
		public void EvalPositionTangent(float time, out PositionTangent positionTangent) {
			positionTangent = default;
		} // 0x0000000185739F0C-0x0000000185739FE8
		public void EvalFrame(float time, out CurveFrame frame) {
			frame = default;
		} // 0x0000000185739960-0x0000000185739B88
		public float EvalCurvature(float time) => default; // 0x000000018573959C-0x0000000185739720
		public float EvalTorsion(float time) => default; // 0x000000018573A6E8-0x000000018573A888
		public Vector3 EvalPositionParametrized(float length) => default; // 0x0000000185739B88-0x0000000185739C50
		public Vector3 EvalTangentParametrized(float length) => default; // 0x000000018573A300-0x000000018573A3C8
		public PositionTangent EvalPositionTangentParametrized(float length) => default; // 0x0000000185739D18-0x0000000185739E18
		public void EvalPositionParametrized(float length, out Vector3 position) {
			position = default;
		} // 0x0000000185739C50-0x0000000185739D18
		public void EvalTangentParametrized(float length, out Vector3 tangent) {
			tangent = default;
		} // 0x000000018573A238-0x000000018573A300
		public void EvalPositionTangentParametrized(float length, out PositionTangent positionTangent) {
			positionTangent = default;
		} // 0x0000000185739E18-0x0000000185739F0C
		public void EvalFrameParametrized(float length, out CurveFrame frame) {
			frame = default;
		} // 0x0000000185739720-0x0000000185739960
		public float EvalCurvatureParametrized(float length) => default; // 0x0000000185739400-0x000000018573959C
		public float EvalTorsionParametrized(float length) => default; // 0x000000018573A530-0x000000018573A6E8
		public float CalcTotalLength() => default; // 0x000000018573936C-0x0000000185739400
		public float LengthToTime(float length, int iterations, float tolerance) => default; // 0x000000018573A940-0x000000018573AC08
		public float LengthToTime(float length) => default; // 0x000000018573A918-0x000000018573A940
		public float ParametrizeByArcLength(int pointCount) => default; // 0x000000018573AC08-0x000000018573AEB8
	}

	public static class PointsFilter // TypeDefIndex: 54966
	{
		// Nested types
		private class Data // TypeDefIndex: 54965
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
			public Data(Vector3[] points, float radius, Rand rand, AAB3 aab) {} // 0x0000000185730964-0x0000000185730AD0
	
			// Methods
			private static int BinarySearch(List<int> array, int value) => default; // 0x000000018573018C-0x000000018573024C
			private static int BinarySearch(int[] array, int length, int value) => default; // 0x0000000185730114-0x000000018573018C
			private void CalcGridIndices(ref Vector3 point, out int i, out int j, out int k) {
				i = default;
				j = default;
				k = default;
			} // 0x000000018573024C-0x0000000185730294
			public List<int> Filter() => default; // 0x0000000185730294-0x0000000185730964
		}
	
		// Methods
		public static List<int> DistanceFilter(Vector3[] points, AAB3 pointsAAB, float radius, Rand rand) => default; // 0x0000000185734278-0x000000018573432C
	}

	public class PoissonDiskSampler // TypeDefIndex: 54968
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
	
		// Properties
		public int MaxPoints { get; set; } // 0x0000000183D4F0D0-0x0000000183D4F0E0 0x0000000183D4F100-0x0000000183D4F110
	
		// Nested types
		public delegate float PointDelegate(ref Vector2 point); // TypeDefIndex: 54967; 0x000000018102B410-0x000000018102B420
	
		// Constructors
		public PoissonDiskSampler() {} // Dummy constructor
		static PoissonDiskSampler() {} // 0x000000018573491C-0x000000018573496C
		public PoissonDiskSampler(Rand rand, Vector2 minCorner, Vector2 maxCorner, float minDistanceOuter, float minDistanceInner = 1f /* Metadata: 0x01FD6931 */) {} // 0x000000018573496C-0x0000000185734BB4
	
		// Methods
		private void CalcGridIndices(ref Vector2 point, out int i, out int j) {
			i = default;
			j = default;
		} // 0x0000000185734654-0x0000000185734680
		private void InsertIntoGrid(ref Vector2 point, int index) {} // 0x0000000185734680-0x0000000185734718
		private bool AddPoint(ref Vector2 center) => default; // 0x000000018573432C-0x0000000185734654
		public List<Vector2> Sample() => default; // 0x0000000185734718-0x000000018573491C
	}

	public class WeightedSampler // TypeDefIndex: 54969
	{
		// Fields
		protected float[] _accum; // 0x10
		protected float _total; // 0x18
		protected Rand _rand; // 0x20
	
		// Constructors
		public WeightedSampler() {} // Dummy constructor
		protected WeightedSampler(Rand rand) {} // 0x0000000184271930-0x0000000184271940
		public WeightedSampler(float[] weights) {} // 0x000000018573C268-0x000000018573C2D8
		public WeightedSampler(float[] weights, Rand rand) {} // 0x000000018573C23C-0x000000018573C268
	
		// Methods
		protected static int BinarySearch(float[] array, float value) => default; // 0x000000018573C094-0x000000018573C100
		protected void Init(float[] weights) {} // 0x000000018573C100-0x000000018573C1FC
		public int SampleIndex() => default; // 0x000000018573C1FC-0x000000018573C23C
	}

	public class TrianglesSamplerBase : WeightedSampler // TypeDefIndex: 54970
	{
		// Fields
		protected Vector3[] _vertices; // 0x28
	
		// Constructors
		public TrianglesSamplerBase() {} // Dummy constructor
		protected TrianglesSamplerBase(Rand rand) {} // 0x0000000184271930-0x0000000184271940
	
		// Methods
		protected float CalclTriangleArea(ref Vector3 e0, ref Vector3 e1) => default; // 0x0000000183D55310-0x0000000183D553B0
	}

	public class IndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 54971
	{
		// Fields
		protected int[] _indices; // 0x30
	
		// Constructors
		public IndexedTrianglesSampler() {} // Dummy constructor
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices) {} // 0x000000018573143C-0x00000001857314CC
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices, Rand rand) {} // 0x00000001857314CC-0x0000000185731524
		public IndexedTrianglesSampler(Mesh mesh) {} // 0x0000000185731524-0x00000001857315CC
		public IndexedTrianglesSampler(Mesh mesh, Rand rand) {} // 0x00000001857315CC-0x000000018573163C
	
		// Methods
		protected void Init() {} // 0x0000000185730AD0-0x0000000185730E90
		public Vector3 Sample() => default; // 0x0000000185731330-0x000000018573143C
		public Vector3[] SampleArray(int count) => default; // 0x00000001857311C8-0x0000000185731330
		public Vector3[] SampleArray(int count, Vector2[] uvs, Texture2D sampleMap, float min = 0f /* Metadata: 0x01FD6935 */, float max = 1f /* Metadata: 0x01FD6939 */) => default; // 0x0000000185730E90-0x00000001857311C8
	}

	public class NonIndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 54972
	{
		// Constructors
		public NonIndexedTrianglesSampler() {} // Dummy constructor
		public NonIndexedTrianglesSampler(Vector3[] vertices) {} // 0x00000001857326AC-0x0000000185732724
		public NonIndexedTrianglesSampler(Vector3[] vertices, Rand rand) {} // 0x0000000185732598-0x00000001857325CC
		public NonIndexedTrianglesSampler(Mesh mesh) {} // 0x00000001857325CC-0x0000000185732658
		public NonIndexedTrianglesSampler(Mesh mesh, Rand rand) {} // 0x0000000185732658-0x00000001857326AC
	
		// Methods
		protected void Init() {} // 0x0000000185732074-0x00000001857323A8
		public Vector3 Sample() => default; // 0x00000001857324CC-0x0000000185732598
		public Vector3[] SampleArray(int count) => default; // 0x00000001857323A8-0x00000001857324CC
	}

	public class ShuffleBag<T> : IEnumerable<T> // TypeDefIndex: 54974
	{
		// Fields
		private Rand _rand;
		private List<T> _items;
		private int _index;
	
		// Properties
		public int Count { get => default; }
	
		// Constructors
		public ShuffleBag() {}
		public ShuffleBag(int capacity) {}
		public ShuffleBag(Rand rand) {}
		public ShuffleBag(Rand rand, int capacity) {}
	
		// Methods
		public void Add(T item, uint count = 1 /* Metadata: 0x01FD693D */) {}
		public T NextItem() => default;
		public void Reset() {}
		public void Clear() {}
		[IteratorStateMachine(typeof(_GetEnumerator_d__13))]
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public static class Util // TypeDefIndex: 54975
	{
		// Extension methods
		public static void Shuffle<T>(this IList<T> collection) {}
		public static void Shuffle<T>(this IList<T> collection, Rand rand) {}
		public static void Shuffle<T>(this T[] collection) {}
		public static void Shuffle<T>(this T[] collection, Rand rand) {}
	}
}
