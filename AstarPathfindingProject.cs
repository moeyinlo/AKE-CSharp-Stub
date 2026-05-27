/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

// Image 81: AstarPathfindingProject.dll - Assembly: AstarPathfindingProject, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59022-59043
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace RVO
{
	public static class AstarMemory // TypeDefIndex: 59025
	{
		// Methods
		public static T[] ShrinkArray<T>(T[] arr, int newLength) => default;
		public static void Swap<T>(ref ref T a, ref ref T b) {}
		public static void Realloc<T>(ref NativeArray<T> arr, int newSize, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x01FDCC62 */)
			where T : struct {}
		public static void Realloc<T>(ref ref T[] arr, int newSize) {}
		public static T[] UnsafeAppendBufferToArray<T>(UnsafeAppendBuffer src)
			where T : struct => default;
	}

	[BurstCompatible]
	public static class NativeCollectionExtensions // TypeDefIndex: 59026
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static void FillIn<T>(this ref NativeArray<T> array, int start, int length, T value)
			where T : struct {}
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static void SetValueAt<T>(this ref NativeArray<T> array, int index, T value)
			where T : struct {}
		public static T GetValueAt<T>(this ref NativeArray<T> array, int index)
			where T : struct => default;
	}

	[Flags]
	public enum RVOLayer // TypeDefIndex: 59027
	{
		DefaultAgent = 1,
		DefaultObstacle = 2,
		Character = 4,
		Enemy = 8,
		NPC = 16,
		FactoryObstacle = 32,
		Layer6 = 64,
		Layer7 = 128,
		Layer8 = 256,
		Layer9 = 512,
		Layer10 = 1024,
		Layer11 = 2048,
		Layer12 = 4096,
		Layer13 = 8192,
		Layer14 = 16384,
		Layer15 = 32768,
		Layer16 = 65536,
		Layer17 = 131072,
		Layer18 = 262144,
		Layer19 = 524288,
		Layer20 = 1048576,
		Layer21 = 2097152,
		Layer22 = 4194304,
		Layer23 = 8388608,
		Layer24 = 16777216,
		Layer25 = 33554432,
		Layer26 = 67108864,
		Layer27 = 134217728,
		Layer28 = 268435456,
		Layer29 = 536870912,
		Layer30 = 1073741824
	}

	public enum Side : byte // TypeDefIndex: 59028
	{
		Colinear = 0,
		Left = 1,
		Right = 2
	}

	public static class VectorMath // TypeDefIndex: 59029
	{
		// Methods
		public static Vector2 ComplexMultiply(Vector2 a, Vector2 b) => default; // 0x0000000183D4E860-0x0000000183D4E8B0
		public static Vector2 ComplexMultiplyConjugate(Vector2 a, Vector2 b) => default; // 0x0000000183D4E810-0x0000000183D4E860
		public static Vector3 ClosestPointOnLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point) => default; // 0x0000000185143A80-0x0000000185143BC4
		public static float ClosestPointOnLineFactor(Vector3 lineStart, Vector3 lineEnd, Vector3 point) => default; // 0x00000001851437E8-0x00000001851438C8
		public static float ClosestPointOnLineFactor(Int3 lineStart, Int3 lineEnd, Int3 point) => default; // 0x00000001851438C8-0x00000001851439D0
		public static float ClosestPointOnLineFactor(Int2 lineStart, Int2 lineEnd, Int2 point) => default; // 0x00000001851439D0-0x0000000185143A80
		public static Vector3 ClosestPointOnSegment(Vector3 lineStart, Vector3 lineEnd, Vector3 point) => default; // 0x0000000185143D8C-0x0000000185143EEC
		public static Vector3 ClosestPointOnSegmentXZ(Vector3 lineStart, Vector3 lineEnd, Vector3 point) => default; // 0x0000000185143BC4-0x0000000185143D8C
		public static float SqrDistancePointSegmentApproximate(int x, int z, int px, int pz, int qx, int qz) => default; // 0x0000000185145DC4-0x0000000185145E98
		public static float SqrDistancePointSegmentApproximate(Int3 a, Int3 b, Int3 p) => default; // 0x0000000185145CF0-0x0000000185145DC4
		public static float SqrDistancePointSegment(Vector3 a, Vector3 b, Vector3 p) => default; // 0x0000000185145E98-0x0000000185145F40
		public static float SqrDistanceSegmentSegment(Vector3 s1, Vector3 e1, Vector3 s2, Vector3 e2) => default; // 0x0000000185145F40-0x00000001851463AC
		public static float SqrDistanceXZ(Vector3 a, Vector3 b) => default; // 0x00000001851463AC-0x0000000185146530
		public static long SignedTriangleAreaTimes2XZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000183D4E920-0x0000000183D4E960
		public static float SignedTriangleAreaTimes2XZ(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000183D4E8E0-0x0000000183D4E920
		public static bool RightXZ(Vector3 a, Vector3 b, Vector3 p) => default; // 0x00000001851452F0-0x0000000185145334
		public static bool RightXZ(Int3 a, Int3 b, Int3 p) => default; // 0x0000000185145334-0x0000000185145378
		public static Side SideXZ(Int3 a, Int3 b, Int3 p) => default; // 0x0000000185145CB4-0x0000000185145CF0
		public static bool RightOrColinear(Vector2 a, Vector2 b, Vector2 p) => default; // 0x0000000185145294-0x00000001851452F0
		public static bool RightOrColinear(Int2 a, Int2 b, Int2 p) => default; // 0x0000000185145258-0x0000000185145294
		public static bool RightOrColinearXZ(Vector3 a, Vector3 b, Vector3 p) => default; // 0x00000001851451E8-0x0000000185145224
		public static bool RightOrColinearXZ(Int3 a, Int3 b, Int3 p) => default; // 0x0000000185145224-0x0000000185145258
		public static bool IsClockwiseMarginXZ(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000185143EEC-0x0000000185143F30
		public static bool IsClockwiseXZ(Vector3 a, Vector3 b, Vector3 c) => default; // 0x000000018294A370-0x000000018294A3B0
		public static bool IsClockwiseXZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000185143FF0-0x0000000185144074
		public static bool IsClockwiseOrColinearXZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000185143F30-0x0000000185143FB4
		public static bool IsClockwiseOrColinear(Int2 a, Int2 b, Int2 c) => default; // 0x0000000185143FB4-0x0000000185143FF0
		public static bool IsColinear(Vector3 a, Vector3 b, Vector3 c) => default; // 0x000000018514419C-0x0000000185144290
		public static bool IsColinear(Vector2 a, Vector2 b, Vector2 c) => default; // 0x0000000185144130-0x000000018514419C
		public static bool IsColinearXZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000185144100-0x0000000185144130
		public static bool IsColinearXZ(Vector3 a, Vector3 b, Vector3 c) => default; // 0x00000001851440B0-0x0000000185144100
		public static bool IsColinearAlmostXZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000185144074-0x00000001851440B0
		public static bool SegmentsIntersect(Int2 start1, Int2 end1, Int2 start2, Int2 end2) => default; // 0x0000000185145B9C-0x0000000185145CB4
		public static bool SegmentsIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) => default; // 0x0000000185145874-0x0000000185145A6C
		public static bool SegmentsIntersectXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) => default; // 0x0000000185145A6C-0x0000000185145B9C
		public static bool LineLineIntersectionFactor(Vector2 start1, Vector2 dir1, Vector2 start2, Vector2 dir2, out float t) {
			t = default;
			return default;
		} // 0x0000000185144C34-0x0000000185144CC0
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2) => default; // 0x0000000185144400-0x00000001851444D8
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2, out bool intersects) {
			intersects = default;
			return default;
		} // 0x00000001851444D8-0x00000001851445C8
		public static bool RaySegmentIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) => default; // 0x0000000185144ED0-0x0000000185145004
		public static bool LineIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2, out float factor1, out float factor2) {
			factor1 = default;
			factor2 = default;
			return default;
		} // 0x00000001851445C8-0x000000018514470C
		public static bool LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out float factor1, out float factor2) {
			factor1 = default;
			factor2 = default;
			return default;
		} // 0x00000001851447FC-0x0000000185144938
		public static float LineRayIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) => default; // 0x0000000185144CC0-0x0000000185144DEC
		public static float LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) => default; // 0x000000018514470C-0x00000001851447FC
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) => default; // 0x0000000185144938-0x00000001851449E4
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects) {
			intersects = default;
			return default;
		} // 0x00000001851449E4-0x0000000185144B3C
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2) => default; // 0x0000000185144B3C-0x0000000185144B60
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2, out bool intersects) {
			intersects = default;
			return default;
		} // 0x0000000185144B60-0x0000000185144C34
		public static Vector3 SegmentIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects) {
			intersects = default;
			return default;
		} // 0x0000000185145378-0x0000000185145528
		public static bool SegmentIntersectsBounds(Bounds bounds, Vector3 a, Vector3 b) => default; // 0x0000000185145528-0x0000000185145874
		public static float LineCircleIntersectionFactor(Vector3 circleCenter, Vector3 linePoint1, Vector3 linePoint2, float radius) => default; // 0x0000000185144290-0x0000000185144400
		public static bool ReversesFaceOrientations(Matrix4x4 matrix) => default; // 0x00000001851450C4-0x00000001851451E8
		public static bool ReversesFaceOrientationsXZ(Matrix4x4 matrix) => default; // 0x0000000185145004-0x00000001851450C4
		public static Vector3 Normalize(Vector3 v, out float magnitude) {
			magnitude = default;
			return default;
		} // 0x0000000185144DEC-0x0000000185144E7C
		public static Vector2 Normalize(Vector2 v, out float magnitude) {
			magnitude = default;
			return default;
		} // 0x0000000185144E7C-0x0000000185144ED0
		public static Vector3 ClampMagnitudeXZ(Vector3 v, float maxMagnitude) => default; // 0x0000000185143764-0x00000001851437E8
		public static float MagnitudeXZ(Vector3 v) => default; // 0x0000000183D4E8B0-0x0000000183D4E8E0
	}

	public struct Int3 : IEquatable<RVO.Int3> // TypeDefIndex: 59030
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public const int Precision = 1000; // Metadata: 0x01FDCCC5
		public const float FloatPrecision = 1000f; // Metadata: 0x01FDCCC7
		public const float PrecisionFactor = 0.001f; // Metadata: 0x01FDCCCB
	
		// Properties
		public static Int3 zero { get => default; } // 0x0000000183D4E630-0x0000000183D4E640 
		public int this[int i] { get => default; set {} } // 0x0000000185140A78-0x0000000185140A8C 0x0000000185140E6C-0x0000000185140E84
		public float magnitude { get => default; } // 0x0000000185140AEC-0x0000000185140B80 
		public int costMagnitude { get => default; } // 0x0000000185140A8C-0x0000000185140AEC 
		public float sqrMagnitude { get => default; } // 0x0000000183D4E600-0x0000000183D4E630 
		public long sqrMagnitudeLong { get => default; } // 0x0000000183D4E5E0-0x0000000183D4E600 
	
		// Constructors
		public Int3(Vector3 position) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x00000001851409E0-0x0000000185140A78
		public Int3(int _x, int _y, int _z) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D4E5D0-0x0000000183D4E5E0
	
		// Methods
		public static bool operator ==(Int3 lhs, Int3 rhs) => default; // 0x00000001851408A4-0x00000001851408C0
		public static bool operator !=(Int3 lhs, Int3 rhs) => default; // 0x0000000185140CF8-0x0000000185140D14
		public static explicit operator Int3(Vector3 ob) => default; // 0x0000000185140C30-0x0000000185140CE8
		public static explicit operator Vector3(Int3 ob) => default; // 0x0000000183D4E670-0x0000000183D4E6B0
		public static Int3 operator -(Int3 lhs, Int3 rhs) => default; // 0x0000000183D4E6E0-0x0000000183D4E710
		public static Int3 operator -(Int3 lhs) => default; // 0x0000000183D4E710-0x0000000183D4E740
		public static Int3 operator +(Int3 lhs, Int3 rhs) => default; // 0x0000000183D4E640-0x0000000183D4E670
		public static Int3 operator *(Int3 lhs, int rhs) => default; // 0x0000000183D4E6B0-0x0000000183D4E6E0
		public static Int3 operator *(Int3 lhs, float rhs) => default; // 0x0000000185140D14-0x0000000185140DC4
		public static Int3 operator *(Int3 lhs, double rhs) => default; // 0x0000000185140DC4-0x0000000185140E6C
		public static Int3 operator /(Int3 lhs, float rhs) => default; // 0x0000000185140B80-0x0000000185140C30
		public static float Angle(Int3 lhs, Int3 rhs) => default; // 0x000000018514073C-0x000000018514082C
		public static int Dot(Int3 lhs, Int3 rhs) => default; // 0x0000000183D4E570-0x0000000183D4E590
		public static long DotLong(Int3 lhs, Int3 rhs) => default; // 0x0000000183D4E540-0x0000000183D4E570
		public Int3 Normal2D() => default; // 0x0000000183D4E5B0-0x0000000183D4E5D0
		public static implicit operator string(Int3 obj) => default; // 0x0000000185140CE8-0x0000000185140CF8
		public override string ToString() => default; // 0x00000001851408C0-0x00000001851409E0
		public override bool Equals(object obj) => default; // 0x000000018514082C-0x00000001851408A4
		public bool Equals(Int3 other) => default; // 0x00000001851408A4-0x00000001851408C0
		public override int GetHashCode() => default; // 0x0000000183D4E590-0x0000000183D4E5B0
	}

	public struct Int2 : IEquatable<RVO.Int2> // TypeDefIndex: 59031
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
	
		// Properties
		public long sqrMagnitudeLong { get => default; } // 0x0000000183D4E4C0-0x0000000183D4E4E0 
	
		// Constructors
		public Int2(int x, int y) : this() {
			this.x = default;
			this.y = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
	
		// Methods
		public static Int2 operator -(Int2 lhs) => default; // 0x0000000183D4E520-0x0000000183D4E540
		public static Int2 operator +(Int2 a, Int2 b) => default; // 0x0000000183D4E4E0-0x0000000183D4E500
		public static Int2 operator -(Int2 a, Int2 b) => default; // 0x0000000183D4E500-0x0000000183D4E520
		public static bool operator ==(Int2 a, Int2 b) => default; // 0x000000018514070C-0x0000000185140724
		public static bool operator !=(Int2 a, Int2 b) => default; // 0x0000000185140724-0x000000018514073C
		public static long DotLong(Int2 a, Int2 b) => default; // 0x0000000183D4E430-0x0000000183D4E460
		public override bool Equals(object o) => default; // 0x00000001851404E4-0x0000000185140544
		public bool Equals(Int2 other) => default; // 0x00000001851404D0-0x00000001851404E4
		public override int GetHashCode() => default; // 0x0000000183D4E480-0x0000000183D4E490
		public static Int2 Min(Int2 a, Int2 b) => default; // 0x00000001851405B0-0x000000018514061C
		public static Int2 Max(Int2 a, Int2 b) => default; // 0x0000000185140544-0x00000001851405B0
		public static Int2 FromInt3XZ(Int3 o) => default; // 0x0000000183D4E460-0x0000000183D4E480
		public static Int3 ToInt3XZ(Int2 o) => default; // 0x0000000183D4E490-0x0000000183D4E4B0
		public override string ToString() => default; // 0x000000018514061C-0x000000018514070C
	}

	public struct RVOAgentJobData // TypeDefIndex: 59032
	{
		// Fields
		public int agentID; // 0x00
		public int agentIndex; // 0x04
		public bool manuallyControlled; // 0x08
		public bool locked; // 0x09
		public float radius; // 0x0C
		public float height; // 0x10
		public float desiredSpeed; // 0x14
		public float maxSpeed; // 0x18
		public float agentTimeHorizon; // 0x1C
		public float obstacleTimeHorizon; // 0x20
		public float priority; // 0x24
		public float elevationCoordinate; // 0x28
		public RVOLayer layer; // 0x2C
		public RVOLayer collidesWith; // 0x30
		public Vector2 position; // 0x34
		public Vector2 currentVelocity; // 0x3C
		public Vector2 desiredVelocity; // 0x44
		public Vector2 desiredTargetPointInVelocitySpace; // 0x4C
	}

	public class RVOAgent // TypeDefIndex: 59033
	{
		// Fields
		public int agentID; // 0x10
		public int agentIndex; // 0x14
		public float radius; // 0x18
		public float height; // 0x1C
		public float desiredSpeed; // 0x20
		public float maxSpeed; // 0x24
		public float agentTimeHorizon; // 0x28
		public float obstacleTimeHorizon; // 0x2C
		public float priority; // 0x30
		public bool locked; // 0x34
		public RVOLayer layer; // 0x38
		public RVOLayer collidesWith; // 0x3C
		public int maxNeighbours; // 0x40
		public Vector2 position; // 0x44
		public Vector3 position3; // 0x4C
		public float elevationCoordinate; // 0x58
		public RVOAgent ignoreAgent; // 0x60
		public Vector2 currentVelocity; // 0x68
		public Vector2 desiredTargetPointInVelocitySpace; // 0x70
		public Vector2 desiredVelocity; // 0x78
		public Vector2 nextTargetPoint; // 0x80
		public Vector2 collisionNormal; // 0x88
		public bool manuallyControlled; // 0x90
		public RVOAgent next; // 0xA0
		public float calculatedSpeed; // 0xA8
		public Vector2 calculatedTargetPoint; // 0xAC
		private List<RVOAgent> m_neighbours; // 0xB8
		private List<float> m_neighbourDists; // 0xC0
	
		// Properties
		public Action PreCalculationCallback { private get; set; } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public List<RVOAgent> neighbours { get => default; } // 0x0000000183D4E750-0x0000000183D4E760 
	
		// Constructors
		public RVOAgent() {} // 0x0000000182F33320-0x0000000182F33420
	
		// Methods
		public void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed) {} // 0x0000000182AC89F0-0x0000000182AC8AC0
		public void SetCollisionNormal(Vector2 normal) {} // 0x0000000183D4E740-0x0000000183D4E750
		public void ForceSetVelocity(Vector2 velocity) {} // 0x000000018353B8E0-0x000000018353B970
		public void PreCalculation() {} // 0x00000001823EB470-0x00000001823EB490
		public RVOAgentJobData CreateJobData() => default; // 0x00000001823EB3B0-0x00000001823EB470
		public void PostCalculation(float resultSpeed, Vector2 resultTargetPoint) {} // 0x0000000182948DF0-0x0000000182948E10
		public void CalculateNeighbours(RVOQuadtree quadtree, float desiredDeltaTime) {} // 0x00000001823EB490-0x00000001823EB950
		internal float InsertAgentNeighbour(RVOAgent rvoAgent, float rangeSq) => default; // 0x00000001823E8C40-0x00000001823E9180
		private static UnityEngine.Color Rainbow(float v) => default; // 0x0000000185141764-0x00000001851417AC
	}

	public struct RVOObstacleJobData // TypeDefIndex: 59034
	{
		// Fields
		public int obstacleID; // 0x00
		public int obstacleIndex; // 0x04
		public RVOLayer layer; // 0x08
		public float height; // 0x0C
		public Vector3 position; // 0x10
	
		// Methods
		public static bool operator ==(RVOObstacleJobData a, RVOObstacleJobData b) => default; // 0x000000018514191C-0x0000000185141A14
		public static bool operator !=(RVOObstacleJobData a, RVOObstacleJobData b) => default; // 0x0000000185141A14-0x0000000185141A68
		public override bool Equals(object obj) => default; // 0x00000001851417C0-0x0000000185141864
		public override int GetHashCode() => default; // 0x0000000185141864-0x000000018514191C
	}

	public class Simulator // TypeDefIndex: 59038
	{
		// Fields
		private float desiredDeltaTime; // 0x10
		private NativeList<RVOAgentJobData> m_jobAgents; // 0x18
		private NativeList<bool> m_jobNeighbours; // 0x28
		private NativeList<RVOObstacleJobData> m_jobObstacles; // 0x38
		private NativeArray<float> m_jobCalculatedSpeeds; // 0x48
		private NativeArray<Vector2> m_jobCalculatedTargetPoints; // 0x58
		private NativeArray<int> m_jobAgentBufferMaxIndex; // 0x68
		private NativeArray<VO> m_jobAgentVoBuffer; // 0x78
		private NativeArray<int> m_jobObsBufferMaxIndex; // 0x88
		private NativeArray<VO> m_jobObsVoBuffer; // 0x98
		private NativeList<RVOObstacleJobData> m_obstacles; // 0xA8
		private Dictionary<int, int> m_obstacleIDToIndex; // 0xB8
		private static int s_nextObstacleID; // 0x00
		private bool m_obstaclesChanged; // 0xC0
		private List<RVOAgent> m_agents; // 0xC8
		private Dictionary<int, int> m_agentIDToIndex; // 0xD0
		private static int s_nextAgentID; // 0x04
		private float deltaTime; // 0xE0
		private float lastStep; // 0xE4
		private readonly float m_symmetryBreakingBias; // 0xE8
		private readonly int m_simulationFPS; // 0xEC
		private readonly int m_vertexCount; // 0xF0
		private const float SHRINK_FACTOR = 0.3f; // Metadata: 0x01FDCCCF
		private const int INIT_AGENT_COUNT = 32; // Metadata: 0x01FDCCD3
		private const int INIT_OBSTACLE_COUNT = 256; // Metadata: 0x01FDCCD4
		private const int INIT_AGENT_VO_COUNT = 1024; // Metadata: 0x01FDCCD6
		private const int INIT_OBS_VO_COUNT = 2048; // Metadata: 0x01FDCCD8
		private int m_agentCount; // 0xF4
		private int m_agentVOCount; // 0xF8
		private int m_obsVOCount; // 0xFC
		private JobHandle m_handle; // 0x100
	
		// Properties
		public float DesiredDeltaTime { get => default; set {} } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x000000018319C760-0x000000018319C7D0
		public List<RVOAgent> agents { get => default; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 
		public RVOQuadtree Quadtree { get; private set; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 0x0000000185142FC4-0x0000000185142FD8
	
		// Nested types
		[BurstCompile]
		private struct RVOParallelJob : IJobParallelFor // TypeDefIndex: 59035
		{
			// Fields
			[ReadOnly]
			public int agentCount; // 0x00
			[ReadOnly]
			public NativeList<RVOAgentJobData> agents; // 0x08
			[ReadOnly]
			public int obstacleCount; // 0x18
			[ReadOnly]
			public float breakingBias; // 0x1C
			public NativeArray<int> obsBufferMaxIndex; // 0x20
			public NativeArray<int> agentBufferMaxIndex; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<VO> obsVoBuffer; // 0x40
			[NativeDisableParallelForRestriction]
			public NativeArray<VO> agentVoBuffer; // 0x50
			[NativeDisableParallelForRestriction]
			public NativeArray<float> calculatedSpeeds; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<Vector2> calculatedTargetPoints; // 0x70
	
			// Methods
			public void Execute(int index) {} // 0x0000000185141A68-0x0000000185141D28
		}
	
		[BurstCompile]
		private struct JobForCalcObstacleVO : IJobParallelFor // TypeDefIndex: 59036
		{
			// Fields
			[ReadOnly]
			public int agentCount; // 0x00
			[ReadOnly]
			public NativeList<RVOAgentJobData> agents; // 0x08
			[ReadOnly]
			public int obstacleCount; // 0x18
			[ReadOnly]
			public NativeList<RVOObstacleJobData> obstacles; // 0x20
			[ReadOnly]
			public float deltaTime; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<int> obsBufferMaxIndex; // 0x38
			[NativeDisableParallelForRestriction]
			public NativeArray<VO> obsVoBuffer; // 0x48
	
			// Methods
			public void Execute(int index) {} // 0x0000000185141208-0x0000000185141764
		}
	
		[BurstCompile]
		private struct JobForCalcAgentNeighbourVO : IJobParallelFor // TypeDefIndex: 59037
		{
			// Fields
			[ReadOnly]
			public int agentCount; // 0x00
			[ReadOnly]
			public NativeList<RVOAgentJobData> agents; // 0x08
			[ReadOnly]
			public NativeList<bool> agentNeighbours; // 0x18
			[ReadOnly]
			public float deltaTime; // 0x28
			[NativeDisableParallelForRestriction]
			public NativeArray<int> agentBufferMaxIndex; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<VO> agentVoBuffer; // 0x40
	
			// Methods
			public void Execute(int index) {} // 0x0000000185140E84-0x0000000185141208
		}
	
		// Constructors
		public Simulator() {} // 0x000000018319BE20-0x000000018319C230
	
		// Methods
		public void OnDestroy() {} // 0x0000000185142348-0x000000018514251C
		public RVOAgent AddAgent() => default; // 0x0000000182F33220-0x0000000182F33320
		public void RemoveAgent(RVOAgent agent) {} // 0x0000000182AFBD10-0x0000000182AFBE70
		public int AddObstacle(Vector3[] vertices, float height, RVOLayer layer) => default; // 0x000000018294A1C0-0x000000018294A370
		public void UpdateObstacle(int obstacleID, Vector3[] vertices) {} // 0x0000000185142EB0-0x0000000185142FC4
		public void RemoveObstacle(int obstacleID) {} // 0x000000018514251C-0x0000000185142700
		private void BuildQuadtree() {} // 0x00000001823E96E0-0x00000001823E99C0
		public void Update() {} // 0x00000001823E99C0-0x00000001823EB3B0
		private void _Realloc(int agentCount, int obstacleCount) {} // 0x000000018319C230-0x000000018319C690
		[BurstCompile]
		private void _WriteBackResult() {} // 0x0000000182948BD0-0x0000000182948DF0
		private static Vector2 _To2D(Vector3 p, out float elevation) {
			elevation = default;
			return default;
		} // 0x0000000183D4E780-0x0000000183D4E7A0
		public static VO SegmentObstacle(Vector2 segmentStart, Vector2 segmentEnd, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime) => default; // 0x0000000185142700-0x0000000185142CB8
		private static bool BiasDesiredVelocity(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, int agentStart, int agentEnd, ref NativeArray<VO> agentVos, ref Vector2 desiredVelocity, ref Vector2 targetPointInVelocitySpace, float maxBiasRadians) => default; // 0x0000000185141D28-0x0000000185141F28
		private static Vector2 GradientDescent(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, int agentStart, int agentEnd, ref NativeArray<VO> agentVos, RVOAgentJobData agent, Vector2 sampleAround1, Vector2 sampleAround2) => default; // 0x0000000185142208-0x0000000185142348
		private static Vector2 Trace(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, int agentStart, int agentEnd, ref NativeArray<VO> agentVos, RVOAgentJobData agent, Vector2 p, out float score) {
			score = default;
			return default;
		} // 0x0000000185142CB8-0x0000000185142EB0
		private static Vector2 EvaluateGradient(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, int agentStart, int agentEnd, ref NativeArray<VO> agentVos, RVOAgentJobData agent, Vector2 p, out float value) {
			value = default;
			return default;
		} // 0x0000000185141F28-0x0000000185142208
	}

	public struct Line // TypeDefIndex: 59039
	{
		// Fields
		public Vector2 point; // 0x00
		public Vector2 dir; // 0x08
	}

	public class RVOQuadtree // TypeDefIndex: 59042
	{
		// Fields
		private const int LeafSize = 15; // Metadata: 0x01FDCCDA
		private float maxRadius; // 0x10
		private Node[] m_nodes; // 0x18
		private int filledNodes; // 0x20
		private Rect m_bounds; // 0x24
	
		// Properties
		public Node[] nodes { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public Rect bounds { get => default; } // 0x0000000183D4E770-0x0000000183D4E780 
	
		// Nested types
		public struct Node // TypeDefIndex: 59040
		{
			// Fields
			public int child00; // 0x00
			public RVOAgent linkedList; // 0x08
			public byte count; // 0x10
			public float maxSpeed; // 0x14
	
			// Methods
			public void Add(RVOAgent rvoAgent) {} // 0x00000001823E9600-0x00000001823E96E0
			public void Distribute(Node[] nodes, Rect r) {} // 0x0000000182ED2800-0x0000000182ED2910
			public float CalculateMaxSpeed(Node[] nodes, int index) => default; // 0x0000000182EC0480-0x0000000182EC0670
		}
	
		private struct QuadtreeQuery // TypeDefIndex: 59041
		{
			// Fields
			public Vector2 p; // 0x00
			public float speed; // 0x08
			public float timeHorizon; // 0x0C
			public float agentRadius; // 0x10
			public float maxRadius; // 0x14
			public RVOAgent RvoAgent; // 0x18
			public Node[] nodes; // 0x20
	
			// Methods
			public void QueryRec(int i, Rect r) {} // 0x00000001823E87B0-0x00000001823E8C40
		}
	
		// Constructors
		public RVOQuadtree() {} // 0x000000018319C710-0x000000018319C760
	
		// Methods
		public void Clear() {} // 0x00000001833C0E90-0x00000001833C1180
		public void SetBounds(Rect r) {} // 0x0000000183D4E760-0x0000000183D4E770
		private int GetNodeIndex() => default; // 0x0000000183114440-0x00000001831145F0
		public void Insert(RVOAgent rvoAgent) {} // 0x00000001823E82F0-0x00000001823E87B0
		public void CalculateSpeeds() {} // 0x0000000182EC0440-0x0000000182EC0480
		public void Query(Vector2 p, float speed, float timeHorizon, float agentRadius, RVOAgent rvoAgent) {} // 0x0000000182E67BC0-0x0000000182E67CE0
	}

	public struct VO // TypeDefIndex: 59043
	{
		// Fields
		public Vector2 line1; // 0x00
		public Vector2 line2; // 0x08
		public Vector2 dir1; // 0x10
		public Vector2 dir2; // 0x18
		public Vector2 cutoffLine; // 0x20
		public Vector2 cutoffDir; // 0x28
		public Vector2 circleCenter; // 0x30
		public bool colliding; // 0x38
		public float radius; // 0x3C
		public float weightFactor; // 0x40
		public float weightBonus; // 0x44
		public Vector2 segmentStart; // 0x48
		public Vector2 segmentEnd; // 0x50
		public bool segment; // 0x58
	
		// Constructors
		public VO(Vector2 center, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime) {
			line1 = default;
			line2 = default;
			dir1 = default;
			dir2 = default;
			cutoffLine = default;
			cutoffDir = default;
			circleCenter = default;
			colliding = default;
			this.radius = default;
			weightFactor = default;
			weightBonus = default;
			segmentStart = default;
			segmentEnd = default;
			segment = default;
		} // 0x0000000185143394-0x0000000185143764
	
		// Methods
		public static float SignedDistanceFromLine(Vector2 a, Vector2 dir, Vector2 p) => default; // 0x0000000183D4E7D0-0x0000000183D4E810
		public Vector2 ScaledGradient(Vector2 p, out float weight) {
			weight = default;
			return default;
		} // 0x000000018514331C-0x0000000185143394
		public Vector2 Gradient(Vector2 p, out float weight) {
			weight = default;
			return default;
		} // 0x0000000185142FD8-0x000000018514331C
	}
}
