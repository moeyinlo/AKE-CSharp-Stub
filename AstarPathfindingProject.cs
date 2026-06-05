/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

// Image 81: AstarPathfindingProject.dll - Assembly: AstarPathfindingProject, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60047-60068

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60048
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace RVO
{
	public static class AstarMemory // TypeDefIndex: 60050
	{
		// Methods
		public static T[] ShrinkArray<T>(T[] arr, int newLength) => default;
		public static void Swap<T>(ref ref T a, ref ref T b) {}
		public static void Realloc<T>(ref NativeArray<T> arr, int newSize, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x02082546 */)
			where T : struct {}
		public static void Realloc<T>(ref ref T[] arr, int newSize) {}
		public static T[] UnsafeAppendBufferToArray<T>(UnsafeAppendBuffer src)
			where T : struct => default;
	}

	public static class NativeCollectionExtensions // TypeDefIndex: 60051
	{
		// Methods
		public static void FillIn<T>(ref NativeArray<T> array, int start, int length, T value)
			where T : struct {}
		public static void SetValueAt<T>(ref NativeArray<T> array, int index, T value)
			where T : struct {}
		public static T GetValueAt<T>(ref NativeArray<T> array, int index)
			where T : struct => default;
	}

	public enum RVOLayer // TypeDefIndex: 60052
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

	public enum Side : byte // TypeDefIndex: 60053
	{
		Colinear = 0,
		Left = 1,
		Right = 2
	}

	public static class VectorMath // TypeDefIndex: 60054
	{
		// Methods
		public static Vector2 ComplexMultiply(Vector2 a, Vector2 b) => default; // 0x0000000185FB03A0-0x0000000185FB03F0
		public static Vector2 ComplexMultiplyConjugate(Vector2 a, Vector2 b) => default; // 0x0000000185FB0350-0x0000000185FB03A0
		public static Vector3 ClosestPointOnLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point) => default; // 0x00000001873373A8-0x00000001873374EC
		public static float ClosestPointOnLineFactor(Vector3 lineStart, Vector3 lineEnd, Vector3 point) => default; // 0x0000000187337110-0x00000001873371F0
		public static float ClosestPointOnLineFactor(Int3 lineStart, Int3 lineEnd, Int3 point) => default; // 0x00000001873371F0-0x00000001873372F8
		public static float ClosestPointOnLineFactor(Int2 lineStart, Int2 lineEnd, Int2 point) => default; // 0x00000001873372F8-0x00000001873373A8
		public static Vector3 ClosestPointOnSegment(Vector3 lineStart, Vector3 lineEnd, Vector3 point) => default; // 0x00000001873376B4-0x0000000187337814
		public static Vector3 ClosestPointOnSegmentXZ(Vector3 lineStart, Vector3 lineEnd, Vector3 point) => default; // 0x00000001873374EC-0x00000001873376B4
		public static float SqrDistancePointSegmentApproximate(int x, int z, int px, int pz, int qx, int qz) => default; // 0x00000001873396EC-0x00000001873397C0
		public static float SqrDistancePointSegmentApproximate(Int3 a, Int3 b, Int3 p) => default; // 0x0000000187339618-0x00000001873396EC
		public static float SqrDistancePointSegment(Vector3 a, Vector3 b, Vector3 p) => default; // 0x00000001873397C0-0x0000000187339868
		public static float SqrDistanceSegmentSegment(Vector3 s1, Vector3 e1, Vector3 s2, Vector3 e2) => default; // 0x0000000187339868-0x0000000187339CD4
		public static float SqrDistanceXZ(Vector3 a, Vector3 b) => default; // 0x0000000187339CD4-0x0000000187339E58
		public static long SignedTriangleAreaTimes2XZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000185FB0460-0x0000000185FB04A0
		public static float SignedTriangleAreaTimes2XZ(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000185FB0420-0x0000000185FB0460
		public static bool RightXZ(Vector3 a, Vector3 b, Vector3 p) => default; // 0x0000000187338C18-0x0000000187338C5C
		public static bool RightXZ(Int3 a, Int3 b, Int3 p) => default; // 0x0000000187338C5C-0x0000000187338CA0
		public static Side SideXZ(Int3 a, Int3 b, Int3 p) => default; // 0x00000001873395DC-0x0000000187339618
		public static bool RightOrColinear(Vector2 a, Vector2 b, Vector2 p) => default; // 0x0000000187338BBC-0x0000000187338C18
		public static bool RightOrColinear(Int2 a, Int2 b, Int2 p) => default; // 0x0000000187338B80-0x0000000187338BBC
		public static bool RightOrColinearXZ(Vector3 a, Vector3 b, Vector3 p) => default; // 0x0000000187338B10-0x0000000187338B4C
		public static bool RightOrColinearXZ(Int3 a, Int3 b, Int3 p) => default; // 0x0000000187338B4C-0x0000000187338B80
		public static bool IsClockwiseMarginXZ(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000187337814-0x0000000187337858
		public static bool IsClockwiseXZ(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000184266200-0x0000000184266240
		public static bool IsClockwiseXZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000187337918-0x000000018733799C
		public static bool IsClockwiseOrColinearXZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000187337858-0x00000001873378DC
		public static bool IsClockwiseOrColinear(Int2 a, Int2 b, Int2 c) => default; // 0x00000001873378DC-0x0000000187337918
		public static bool IsColinear(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000187337AC4-0x0000000187337BB8
		public static bool IsColinear(Vector2 a, Vector2 b, Vector2 c) => default; // 0x0000000187337A58-0x0000000187337AC4
		public static bool IsColinearXZ(Int3 a, Int3 b, Int3 c) => default; // 0x0000000187337A28-0x0000000187337A58
		public static bool IsColinearXZ(Vector3 a, Vector3 b, Vector3 c) => default; // 0x00000001873379D8-0x0000000187337A28
		public static bool IsColinearAlmostXZ(Int3 a, Int3 b, Int3 c) => default; // 0x000000018733799C-0x00000001873379D8
		public static bool SegmentsIntersect(Int2 start1, Int2 end1, Int2 start2, Int2 end2) => default; // 0x00000001873394C4-0x00000001873395DC
		public static bool SegmentsIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) => default; // 0x000000018733919C-0x0000000187339394
		public static bool SegmentsIntersectXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) => default; // 0x0000000187339394-0x00000001873394C4
		public static bool LineLineIntersectionFactor(Vector2 start1, Vector2 dir1, Vector2 start2, Vector2 dir2, out float t) {
			t = default;
			return default;
		} // 0x000000018733855C-0x00000001873385E8
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2) => default; // 0x0000000187337D28-0x0000000187337E00
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2, out bool intersects) {
			intersects = default;
			return default;
		} // 0x0000000187337E00-0x0000000187337EF0
		public static bool RaySegmentIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) => default; // 0x00000001873387F8-0x000000018733892C
		public static bool LineIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2, out float factor1, out float factor2) {
			factor1 = default;
			factor2 = default;
			return default;
		} // 0x0000000187337EF0-0x0000000187338034
		public static bool LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out float factor1, out float factor2) {
			factor1 = default;
			factor2 = default;
			return default;
		} // 0x0000000187338124-0x0000000187338260
		public static float LineRayIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2) => default; // 0x00000001873385E8-0x0000000187338714
		public static float LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) => default; // 0x0000000187338034-0x0000000187338124
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2) => default; // 0x0000000187338260-0x000000018733830C
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects) {
			intersects = default;
			return default;
		} // 0x000000018733830C-0x0000000187338464
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2) => default; // 0x0000000187338464-0x0000000187338488
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2, out bool intersects) {
			intersects = default;
			return default;
		} // 0x0000000187338488-0x000000018733855C
		public static Vector3 SegmentIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects) {
			intersects = default;
			return default;
		} // 0x0000000187338CA0-0x0000000187338E50
		public static bool SegmentIntersectsBounds(Bounds bounds, Vector3 a, Vector3 b) => default; // 0x0000000187338E50-0x000000018733919C
		public static float LineCircleIntersectionFactor(Vector3 circleCenter, Vector3 linePoint1, Vector3 linePoint2, float radius) => default; // 0x0000000187337BB8-0x0000000187337D28
		public static bool ReversesFaceOrientations(Matrix4x4 matrix) => default; // 0x00000001873389EC-0x0000000187338B10
		public static bool ReversesFaceOrientationsXZ(Matrix4x4 matrix) => default; // 0x000000018733892C-0x00000001873389EC
		public static Vector3 Normalize(Vector3 v, out float magnitude) {
			magnitude = default;
			return default;
		} // 0x0000000187338714-0x00000001873387A4
		public static Vector2 Normalize(Vector2 v, out float magnitude) {
			magnitude = default;
			return default;
		} // 0x00000001873387A4-0x00000001873387F8
		public static Vector3 ClampMagnitudeXZ(Vector3 v, float maxMagnitude) => default; // 0x000000018733708C-0x0000000187337110
		public static float MagnitudeXZ(Vector3 v) => default; // 0x0000000185FB03F0-0x0000000185FB0420
	}

	public struct Int3 : IEquatable<RVO.Int3> // TypeDefIndex: 60055
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public const int Precision = 1000; // Metadata: 0x020825A9
		public const float FloatPrecision = 1000f; // Metadata: 0x020825AB
		public const float PrecisionFactor = 0.001f; // Metadata: 0x020825AF
	
		// Properties
		public static Int3 zero { get => default; } // 0x0000000185FB0190-0x0000000185FB01A0 
		public int this[int i] { get => default; set {} } // 0x00000001873343A0-0x00000001873343B4 0x0000000187334794-0x00000001873347AC
		public float magnitude { get => default; } // 0x0000000187334414-0x00000001873344A8 
		public int costMagnitude { get => default; } // 0x00000001873343B4-0x0000000187334414 
		public float sqrMagnitude { get => default; } // 0x0000000185FB0160-0x0000000185FB0190 
		public long sqrMagnitudeLong { get => default; } // 0x0000000185FB0140-0x0000000185FB0160 
	
		// Constructors
		public Int3(Vector3 position) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000187334308-0x00000001873343A0
		public Int3(int _x, int _y, int _z) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FB0130-0x0000000185FB0140
	
		// Methods
		public static bool operator ==(Int3 lhs, Int3 rhs) => default; // 0x00000001873341CC-0x00000001873341E8
		public static bool operator !=(Int3 lhs, Int3 rhs) => default; // 0x0000000187334620-0x000000018733463C
		public static explicit operator Int3(Vector3 ob) => default; // 0x0000000187334558-0x0000000187334610
		public static explicit operator Vector3(Int3 ob) => default; // 0x0000000185FB01D0-0x0000000185FB0210
		public static Int3 operator -(Int3 lhs, Int3 rhs) => default; // 0x0000000185FB0240-0x0000000185FB0270
		public static Int3 operator -(Int3 lhs) => default; // 0x0000000185FB0270-0x0000000185FB02A0
		public static Int3 operator +(Int3 lhs, Int3 rhs) => default; // 0x0000000185FB01A0-0x0000000185FB01D0
		public static Int3 operator *(Int3 lhs, int rhs) => default; // 0x0000000185FB0210-0x0000000185FB0240
		public static Int3 operator *(Int3 lhs, float rhs) => default; // 0x000000018733463C-0x00000001873346EC
		public static Int3 operator *(Int3 lhs, double rhs) => default; // 0x00000001873346EC-0x0000000187334794
		public static Int3 operator /(Int3 lhs, float rhs) => default; // 0x00000001873344A8-0x0000000187334558
		public static float Angle(Int3 lhs, Int3 rhs) => default; // 0x0000000187334064-0x0000000187334154
		public static int Dot(Int3 lhs, Int3 rhs) => default; // 0x0000000185FB00D0-0x0000000185FB00F0
		public static long DotLong(Int3 lhs, Int3 rhs) => default; // 0x0000000185FB00A0-0x0000000185FB00D0
		public Int3 Normal2D() => default; // 0x0000000185FB0110-0x0000000185FB0130
		public static implicit operator string(Int3 obj) => default; // 0x0000000187334610-0x0000000187334620
		public override string ToString() => default; // 0x00000001873341E8-0x0000000187334308
		public override bool Equals(object obj) => default; // 0x0000000187334154-0x00000001873341CC
		public bool Equals(Int3 other) => default; // 0x00000001873341CC-0x00000001873341E8
		public override int GetHashCode() => default; // 0x0000000185FB00F0-0x0000000185FB0110
	}

	public struct Int2 : IEquatable<RVO.Int2> // TypeDefIndex: 60056
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
	
		// Properties
		public long sqrMagnitudeLong { get => default; } // 0x0000000185FB0020-0x0000000185FB0040 
	
		// Constructors
		public Int2(int x, int y) : this() {
			this.x = default;
			this.y = default;
		} // 0x000000018357CB90-0x000000018357CBA0
	
		// Methods
		public static Int2 operator -(Int2 lhs) => default; // 0x0000000185FB0080-0x0000000185FB00A0
		public static Int2 operator +(Int2 a, Int2 b) => default; // 0x0000000185FB0040-0x0000000185FB0060
		public static Int2 operator -(Int2 a, Int2 b) => default; // 0x0000000185FB0060-0x0000000185FB0080
		public static bool operator ==(Int2 a, Int2 b) => default; // 0x0000000187334034-0x000000018733404C
		public static bool operator !=(Int2 a, Int2 b) => default; // 0x000000018733404C-0x0000000187334064
		public static long DotLong(Int2 a, Int2 b) => default; // 0x0000000185FAFFA0-0x0000000185FAFFD0
		public override bool Equals(object o) => default; // 0x0000000187333E0C-0x0000000187333E6C
		public bool Equals(Int2 other) => default; // 0x0000000187333DF8-0x0000000187333E0C
		public override int GetHashCode() => default; // 0x0000000185FAFFF0-0x0000000185FB0000
		public static Int2 Min(Int2 a, Int2 b) => default; // 0x0000000187333ED8-0x0000000187333F44
		public static Int2 Max(Int2 a, Int2 b) => default; // 0x0000000187333E6C-0x0000000187333ED8
		public static Int2 FromInt3XZ(Int3 o) => default; // 0x0000000185FAFFD0-0x0000000185FAFFF0
		public static Int3 ToInt3XZ(Int2 o) => default; // 0x0000000185FB0000-0x0000000185FB0020
		public override string ToString() => default; // 0x0000000187333F44-0x0000000187334034
	}

	public struct RVOAgentJobData // TypeDefIndex: 60057
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

	public class RVOAgent // TypeDefIndex: 60058
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
		private Action _PreCalculationCallback_k__BackingField; // 0x98
		public RVOAgent next; // 0xA0
		public float calculatedSpeed; // 0xA8
		public Vector2 calculatedTargetPoint; // 0xAC
		private List<RVOAgent> m_neighbours; // 0xB8
		private List<float> m_neighbourDists; // 0xC0
	
		// Properties
		public Action PreCalculationCallback { private get; set; } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public List<RVOAgent> neighbours { get => default; } // 0x000000018349D710-0x000000018349D720 
	
		// Constructors
		public RVOAgent() {} // 0x0000000184320CF0-0x0000000184320DF0
	
		// Methods
		public void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed) {} // 0x0000000184322A10-0x0000000184322AE0
		public void SetCollisionNormal(Vector2 normal) {} // 0x0000000185FB02A0-0x0000000185FB02B0
		public void ForceSetVelocity(Vector2 velocity) {} // 0x00000001850DB140-0x00000001850DB1D0
		public void PreCalculation() {} // 0x00000001842DF0E0-0x00000001842DF100
		public RVOAgentJobData CreateJobData() => default; // 0x00000001842DF020-0x00000001842DF0E0
		public void PostCalculation(float resultSpeed, Vector2 resultTargetPoint) {} // 0x0000000184264C80-0x0000000184264CA0
		public void CalculateNeighbours(RVOQuadtree quadtree, float desiredDeltaTime) {} // 0x00000001842DBB80-0x00000001842DC040
		internal float InsertAgentNeighbour(RVOAgent rvoAgent, float rangeSq) => default; // 0x00000001842DCDF0-0x00000001842DD330
		private static UnityEngine.Color Rainbow(float v) => default; // 0x000000018733508C-0x00000001873350D4
	}

	public struct RVOObstacleJobData // TypeDefIndex: 60059
	{
		// Fields
		public int obstacleID; // 0x00
		public int obstacleIndex; // 0x04
		public RVOLayer layer; // 0x08
		public float height; // 0x0C
		public Vector3 position; // 0x10
	
		// Methods
		public static bool operator ==(RVOObstacleJobData a, RVOObstacleJobData b) => default; // 0x0000000187335244-0x000000018733533C
		public static bool operator !=(RVOObstacleJobData a, RVOObstacleJobData b) => default; // 0x000000018733533C-0x0000000187335390
		public override bool Equals(object obj) => default; // 0x00000001873350E8-0x000000018733518C
		public override int GetHashCode() => default; // 0x000000018733518C-0x0000000187335244
	}

	public class Simulator // TypeDefIndex: 60063
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
		private RVOQuadtree _Quadtree_k__BackingField; // 0xD8
		private float deltaTime; // 0xE0
		private float lastStep; // 0xE4
		private readonly float m_symmetryBreakingBias; // 0xE8
		private readonly int m_simulationFPS; // 0xEC
		private readonly int m_vertexCount; // 0xF0
		private const float SHRINK_FACTOR = 0.3f; // Metadata: 0x020825B3
		private const int INIT_AGENT_COUNT = 32; // Metadata: 0x020825B7
		private const int INIT_OBSTACLE_COUNT = 256; // Metadata: 0x020825B8
		private const int INIT_AGENT_VO_COUNT = 1024; // Metadata: 0x020825BA
		private const int INIT_OBS_VO_COUNT = 2048; // Metadata: 0x020825BC
		private int m_agentCount; // 0xF4
		private int m_agentVOCount; // 0xF8
		private int m_obsVOCount; // 0xFC
		private JobHandle m_handle; // 0x100
	
		// Properties
		public float DesiredDeltaTime { get => default; set {} } // 0x0000000185FB02F0-0x0000000185FB0300 0x00000001873368EC-0x0000000187336900
		public List<RVOAgent> agents { get => default; } // 0x000000018494ACF0-0x000000018494B100 
		public RVOQuadtree Quadtree { get; private set; } // 0x0000000187335C70-0x0000000187335E44 0x0000000184320BF0-0x0000000184320CF0
	
		// Nested types
		private struct RVOParallelJob : IJobParallelFor // TypeDefIndex: 60060
		{
			// Fields
			public int agentCount; // 0x00
			public NativeList<RVOAgentJobData> agents; // 0x08
			public int obstacleCount; // 0x18
			public float breakingBias; // 0x1C
			public NativeArray<int> obsBufferMaxIndex; // 0x20
			public NativeArray<int> agentBufferMaxIndex; // 0x30
			public NativeArray<VO> obsVoBuffer; // 0x40
			public NativeArray<VO> agentVoBuffer; // 0x50
			public NativeArray<float> calculatedSpeeds; // 0x60
			public NativeArray<Vector2> calculatedTargetPoints; // 0x70
	
			// Methods
			public void Execute(int index) {} // 0x0000000181DCCCE0-0x0000000181DCCCF0
		}
	
		private struct JobForCalcObstacleVO : IJobParallelFor // TypeDefIndex: 60061
		{
			// Fields
			public int agentCount; // 0x00
			public NativeList<RVOAgentJobData> agents; // 0x08
			public int obstacleCount; // 0x18
			public NativeList<RVOObstacleJobData> obstacles; // 0x20
			public float deltaTime; // 0x30
			public NativeArray<int> obsBufferMaxIndex; // 0x38
			public NativeArray<VO> obsVoBuffer; // 0x48
	
			// Methods
			public void Execute(int index) {} // 0x000000018494B630-0x000000018494B6A0
		}
	
		private struct JobForCalcAgentNeighbourVO : IJobParallelFor // TypeDefIndex: 60062
		{
			// Fields
			public int agentCount; // 0x00
			public NativeList<RVOAgentJobData> agents; // 0x08
			public NativeList<bool> agentNeighbours; // 0x18
			public float deltaTime; // 0x28
			public NativeArray<int> agentBufferMaxIndex; // 0x30
			public NativeArray<VO> agentVoBuffer; // 0x40
	
			// Methods
			public void Execute(int index) {} // 0x0000000185FB0300-0x0000000185FB0310
		}
	
		// Constructors
		public Simulator() {} // 0x00000001846C85B0-0x00000001846C8710
	
		// Methods
		public void OnDestroy() {} // 0x0000000184266050-0x0000000184266200
		public RVOAgent AddAgent() => default; // 0x00000001873367D8-0x00000001873368EC
		public void RemoveAgent(RVOAgent agent) {} // 0x0000000187335E44-0x0000000187336028
		public int AddObstacle(Vector3[] vertices, float height, RVOLayer layer) => default; // 0x00000001842DED40-0x00000001842DF020
		public void UpdateObstacle(int obstacleID, Vector3[] vertices) {} // 0x00000001842DD350-0x00000001842DED40
		public void RemoveObstacle(int obstacleID) {} // 0x000000018494B100-0x000000018494B560
		private void BuildQuadtree() {} // 0x0000000184264A60-0x0000000184264C80
		public void Update() {} // 0x0000000185FB02D0-0x0000000185FB02F0
		private void _Realloc(int agentCount, int obstacleCount) {} // 0x0000000187336028-0x00000001873365E0
		private void _WriteBackResult() {} // 0x0000000187335650-0x0000000187335850
		private static Vector2 _To2D(Vector3 p, out float elevation) {
			elevation = default;
			return default;
		} // 0x0000000187335B30-0x0000000187335C70
		public static VO SegmentObstacle(Vector2 segmentStart, Vector2 segmentEnd, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime) => default; // 0x00000001873365E0-0x00000001873367D8
		private static bool BiasDesiredVelocity(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, int agentStart, int agentEnd, ref NativeArray<VO> agentVos, ref Vector2 desiredVelocity, ref Vector2 targetPointInVelocitySpace, float maxBiasRadians) => default; // 0x0000000187335850-0x0000000187335B30
		private static Vector2 GradientDescent(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, int agentStart, int agentEnd, ref NativeArray<VO> agentVos, RVOAgentJobData agent, Vector2 sampleAround1, Vector2 sampleAround2) => default; // 0x0000000187335390-0x0000000187335650
		private static Vector2 Trace(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, int agentStart, int agentEnd, ref NativeArray<VO> agentVos, RVOAgentJobData agent, Vector2 p, out float score) {
			score = default;
			return default;
		} // 0x0000000187334B30-0x000000018733508C
		private static Vector2 EvaluateGradient(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, int agentStart, int agentEnd, ref NativeArray<VO> agentVos, RVOAgentJobData agent, Vector2 p, out float value) {
			value = default;
			return default;
		} // 0x00000001873347AC-0x0000000187334B30
	}

	public struct Line // TypeDefIndex: 60064
	{
		// Fields
		public Vector2 point; // 0x00
		public Vector2 dir; // 0x08
	}

	public class RVOQuadtree // TypeDefIndex: 60067
	{
		// Fields
		private const int LeafSize = 15; // Metadata: 0x020825BE
		private float maxRadius; // 0x10
		private Node[] m_nodes; // 0x18
		private int filledNodes; // 0x20
		private Rect m_bounds; // 0x24
	
		// Properties
		public Node[] nodes { get => default; } // 0x0000000185044820-0x00000001850449D0 
		public Rect bounds { get => default; } // 0x00000001842DC4A0-0x00000001842DC960 
	
		// Nested types
		public struct Node // TypeDefIndex: 60065
		{
			// Fields
			public int child00; // 0x00
			public RVOAgent linkedList; // 0x08
			public byte count; // 0x10
			public float maxSpeed; // 0x14
	
			// Methods
			public void Add(RVOAgent rvoAgent) {} // 0x0000000181377E40-0x0000000181377E50
			public void Distribute(Node[] nodes, Rect r) {} // 0x0000000185FB02C0-0x0000000185FB02D0
			public float CalculateMaxSpeed(Node[] nodes, int index) => default; // 0x00000001853A1C80-0x00000001853A1F70
		}
	
		private struct QuadtreeQuery // TypeDefIndex: 60066
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
			public void QueryRec(int i, Rect r) {} // 0x0000000185FB02B0-0x0000000185FB02C0
		}
	
		// Constructors
		public RVOQuadtree() {} // 0x00000001842DC960-0x00000001842DCDF0
	
		// Methods
		public void Clear() {} // 0x0000000184CA7F40-0x0000000184CA7F80
		public void SetBounds(Rect r) {} // 0x00000001842DBA60-0x00000001842DBB80
		private int GetNodeIndex() => default; // 0x000000018494B5E0-0x000000018494B630
		public void Insert(RVOAgent rvoAgent) {} // 0x00000001842DC040-0x00000001842DC120
		public void CalculateSpeeds() {} // 0x0000000184CDB220-0x0000000184CDB330
		public void Query(Vector2 p, float speed, float timeHorizon, float agentRadius, RVOAgent rvoAgent) {} // 0x0000000184CA7F80-0x0000000184CA8170
	}

	public struct VO // TypeDefIndex: 60068
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
		} // 0x0000000187336CBC-0x000000018733708C
	
		// Methods
		public static float SignedDistanceFromLine(Vector2 a, Vector2 dir, Vector2 p) => default; // 0x0000000185FB0310-0x0000000185FB0350
		public Vector2 ScaledGradient(Vector2 p, out float weight) {
			weight = default;
			return default;
		} // 0x0000000187336C44-0x0000000187336CBC
		public Vector2 Gradient(Vector2 p, out float weight) {
			weight = default;
			return default;
		} // 0x0000000187336900-0x0000000187336C44
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60049
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
