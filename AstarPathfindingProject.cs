/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

// Image 81: AstarPathfindingProject.dll - Assembly: AstarPathfindingProject, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89882-89903

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 89883
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace RVO
{
	public static class AstarMemory // TypeDefIndex: 89885
	{
		// Methods
		public static T[] ShrinkArray<T>(T[] arr, int newLength);
		public static void Swap<T>(ref ref T a, ref ref T b);
		public static void Realloc<T>(ref NativeArray<T> arr, int newSize, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x0264A950 */)
			where T : struct;
		public static void Realloc<T>(ref ref T[] arr, int newSize);
		public static T[] UnsafeAppendBufferToArray<T>(UnsafeAppendBuffer src)
			where T : struct;
	}

	[BurstCompatible]
	public static class NativeCollectionExtensions // TypeDefIndex: 89886
	{
		// Extension methods
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static void FillIn<T>(this ref NativeArray<T> array, int start, int length, T value)
			where T : struct;
		[BurstCompatible(GenericTypeArguments = new System.Type[1] {typeof(int) })]
		public static void SetValueAt<T>(this ref NativeArray<T> array, int index, T value)
			where T : struct;
		public static T GetValueAt<T>(this ref NativeArray<T> array, int index)
			where T : struct;
	}

	[Flags]
	public enum RVOLayer // TypeDefIndex: 89887
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

	public enum Side : byte // TypeDefIndex: 89888
	{
		Colinear = 0,
		Left = 1,
		Right = 2
	}

	public static class VectorMath // TypeDefIndex: 89889
	{
		// Methods
		public static Vector2 ComplexMultiply(Vector2 a, Vector2 b); // 0x0000000187232DC0-0x0000000187232E10
		public static Vector2 ComplexMultiplyConjugate(Vector2 a, Vector2 b); // 0x0000000187232D70-0x0000000187232DC0
		public static Vector3 ClosestPointOnLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point); // 0x00000001887E1C5C-0x00000001887E1DA0
		public static float ClosestPointOnLineFactor(Vector3 lineStart, Vector3 lineEnd, Vector3 point); // 0x00000001887E19C4-0x00000001887E1AA4
		public static float ClosestPointOnLineFactor(Int3 lineStart, Int3 lineEnd, Int3 point); // 0x00000001887E1AA4-0x00000001887E1BAC
		public static float ClosestPointOnLineFactor(Int2 lineStart, Int2 lineEnd, Int2 point); // 0x00000001887E1BAC-0x00000001887E1C5C
		public static Vector3 ClosestPointOnSegment(Vector3 lineStart, Vector3 lineEnd, Vector3 point); // 0x00000001887E1F68-0x00000001887E20C8
		public static Vector3 ClosestPointOnSegmentXZ(Vector3 lineStart, Vector3 lineEnd, Vector3 point); // 0x00000001887E1DA0-0x00000001887E1F68
		public static float SqrDistancePointSegmentApproximate(int x, int z, int px, int pz, int qx, int qz); // 0x00000001887E3FAC-0x00000001887E4080
		public static float SqrDistancePointSegmentApproximate(Int3 a, Int3 b, Int3 p); // 0x00000001887E3ED8-0x00000001887E3FAC
		public static float SqrDistancePointSegment(Vector3 a, Vector3 b, Vector3 p); // 0x00000001887E4080-0x00000001887E412C
		public static float SqrDistanceSegmentSegment(Vector3 s1, Vector3 e1, Vector3 s2, Vector3 e2); // 0x00000001887E412C-0x00000001887E4598
		public static float SqrDistanceXZ(Vector3 a, Vector3 b); // 0x00000001887E4598-0x00000001887E4670
		public static long SignedTriangleAreaTimes2XZ(Int3 a, Int3 b, Int3 c); // 0x0000000187232E80-0x0000000187232EC0
		public static float SignedTriangleAreaTimes2XZ(Vector3 a, Vector3 b, Vector3 c); // 0x0000000187232E40-0x0000000187232E80
		public static bool RightXZ(Vector3 a, Vector3 b, Vector3 p); // 0x00000001887E34D8-0x00000001887E351C
		public static bool RightXZ(Int3 a, Int3 b, Int3 p); // 0x00000001887E351C-0x00000001887E3560
		public static Side SideXZ(Int3 a, Int3 b, Int3 p); // 0x00000001887E3E9C-0x00000001887E3ED8
		public static bool RightOrColinear(Vector2 a, Vector2 b, Vector2 p); // 0x00000001887E347C-0x00000001887E34D8
		public static bool RightOrColinear(Int2 a, Int2 b, Int2 p); // 0x00000001887E3440-0x00000001887E347C
		public static bool RightOrColinearXZ(Vector3 a, Vector3 b, Vector3 p); // 0x00000001887E33D0-0x00000001887E340C
		public static bool RightOrColinearXZ(Int3 a, Int3 b, Int3 p); // 0x00000001887E340C-0x00000001887E3440
		public static bool IsClockwiseMarginXZ(Vector3 a, Vector3 b, Vector3 c); // 0x00000001887E20C8-0x00000001887E210C
		public static bool IsClockwiseXZ(Vector3 a, Vector3 b, Vector3 c); // 0x00000001864B8E30-0x00000001864B8E70
		public static bool IsClockwiseXZ(Int3 a, Int3 b, Int3 c); // 0x00000001887E21CC-0x00000001887E2250
		public static bool IsClockwiseOrColinearXZ(Int3 a, Int3 b, Int3 c); // 0x00000001887E210C-0x00000001887E2190
		public static bool IsClockwiseOrColinear(Int2 a, Int2 b, Int2 c); // 0x00000001887E2190-0x00000001887E21CC
		public static bool IsColinear(Vector3 a, Vector3 b, Vector3 c); // 0x00000001887E2378-0x00000001887E246C
		public static bool IsColinear(Vector2 a, Vector2 b, Vector2 c); // 0x00000001887E230C-0x00000001887E2378
		public static bool IsColinearXZ(Int3 a, Int3 b, Int3 c); // 0x00000001887E22DC-0x00000001887E230C
		public static bool IsColinearXZ(Vector3 a, Vector3 b, Vector3 c); // 0x00000001887E228C-0x00000001887E22DC
		public static bool IsColinearAlmostXZ(Int3 a, Int3 b, Int3 c); // 0x00000001887E2250-0x00000001887E228C
		public static bool SegmentsIntersect(Int2 start1, Int2 end1, Int2 start2, Int2 end2); // 0x00000001887E3D84-0x00000001887E3E9C
		public static bool SegmentsIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2); // 0x00000001887E3A5C-0x00000001887E3C54
		public static bool SegmentsIntersectXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2); // 0x00000001887E3C54-0x00000001887E3D84
		public static bool LineLineIntersectionFactor(Vector2 start1, Vector2 dir1, Vector2 start2, Vector2 dir2, out float t); // 0x00000001887E2E28-0x00000001887E2EB8
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2); // 0x00000001887E25E0-0x00000001887E26B8
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2, out bool intersects); // 0x00000001887E26B8-0x00000001887E27A8
		public static bool RaySegmentIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2); // 0x00000001887E30C8-0x00000001887E31EC
		public static bool LineIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2, out float factor1, out float factor2); // 0x00000001887E27A8-0x00000001887E28F4
		public static bool LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out float factor1, out float factor2); // 0x00000001887E29E4-0x00000001887E2B28
		public static float LineRayIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2); // 0x00000001887E2EB8-0x00000001887E2FE4
		public static float LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2); // 0x00000001887E28F4-0x00000001887E29E4
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2); // 0x00000001887E2B28-0x00000001887E2BD8
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects); // 0x00000001887E2BD8-0x00000001887E2D30
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2); // 0x00000001887E2D30-0x00000001887E2D54
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2, out bool intersects); // 0x00000001887E2D54-0x00000001887E2E28
		public static Vector3 SegmentIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects); // 0x00000001887E3560-0x00000001887E3710
		public static bool SegmentIntersectsBounds(Bounds bounds, Vector3 a, Vector3 b); // 0x00000001887E3710-0x00000001887E3A5C
		public static float LineCircleIntersectionFactor(Vector3 circleCenter, Vector3 linePoint1, Vector3 linePoint2, float radius); // 0x00000001887E246C-0x00000001887E25E0
		public static bool ReversesFaceOrientations(Matrix4x4 matrix); // 0x00000001887E32AC-0x00000001887E33D0
		public static bool ReversesFaceOrientationsXZ(Matrix4x4 matrix); // 0x00000001887E31EC-0x00000001887E32AC
		public static Vector3 Normalize(Vector3 v, out float magnitude); // 0x00000001887E2FE4-0x00000001887E3074
		public static Vector2 Normalize(Vector2 v, out float magnitude); // 0x00000001887E3074-0x00000001887E30C8
		public static Vector3 ClampMagnitudeXZ(Vector3 v, float maxMagnitude); // 0x00000001887E1940-0x00000001887E19C4
		public static float MagnitudeXZ(Vector3 v); // 0x0000000187232E10-0x0000000187232E40
	}

	public struct Int3 : IEquatable<RVO.Int3> // TypeDefIndex: 89890
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public const int Precision = 1000; // Metadata: 0x0264A9B3
		public const float FloatPrecision = 1000f; // Metadata: 0x0264A9B5
		public const float PrecisionFactor = 0.001f; // Metadata: 0x0264A9B9
	
		// Properties
		public static Int3 zero { get; } // 0x0000000187232AC0-0x0000000187232AD0 
		public int this[int i] { get => default; set {} } // 0x00000001887DD45C-0x00000001887DD470 0x00000001887DD850-0x00000001887DD868
		public float magnitude { get; } // 0x00000001887DD4D0-0x00000001887DD564 
		public int costMagnitude { get; } // 0x00000001887DD470-0x00000001887DD4D0 
		public float sqrMagnitude { get; } // 0x0000000187232A90-0x0000000187232AC0 
		public long sqrMagnitudeLong { get; } // 0x0000000187232A70-0x0000000187232A90 
	
		// Constructors
		public Int3(Vector3 position); // 0x00000001887DD3C4-0x00000001887DD45C
		public Int3(int _x, int _y, int _z); // 0x0000000187232A60-0x0000000187232A70
	
		// Methods
		public static bool operator ==(Int3 lhs, Int3 rhs); // 0x00000001887DD288-0x00000001887DD2A4
		public static bool operator !=(Int3 lhs, Int3 rhs); // 0x00000001887DD6DC-0x00000001887DD6F8
		public static explicit operator Int3(Vector3 ob); // 0x00000001887DD614-0x00000001887DD6CC
		public static explicit operator Vector3(Int3 ob); // 0x0000000187232B00-0x0000000187232B40
		public static Int3 operator -(Int3 lhs, Int3 rhs); // 0x0000000187232B70-0x0000000187232BA0
		public static Int3 operator -(Int3 lhs); // 0x0000000187232BA0-0x0000000187232BD0
		public static Int3 operator +(Int3 lhs, Int3 rhs); // 0x0000000187232AD0-0x0000000187232B00
		public static Int3 operator *(Int3 lhs, int rhs); // 0x0000000187232B40-0x0000000187232B70
		public static Int3 operator *(Int3 lhs, float rhs); // 0x00000001887DD6F8-0x00000001887DD7A8
		public static Int3 operator *(Int3 lhs, double rhs); // 0x00000001887DD7A8-0x00000001887DD850
		public static Int3 operator /(Int3 lhs, float rhs); // 0x00000001887DD564-0x00000001887DD614
		public static float Angle(Int3 lhs, Int3 rhs); // 0x00000001887DD120-0x00000001887DD210
		public static int Dot(Int3 lhs, Int3 rhs); // 0x0000000187232A00-0x0000000187232A20
		public static long DotLong(Int3 lhs, Int3 rhs); // 0x00000001872329D0-0x0000000187232A00
		public Int3 Normal2D(); // 0x0000000187232A40-0x0000000187232A60
		public static implicit operator string(Int3 obj); // 0x00000001887DD6CC-0x00000001887DD6DC
		public override string ToString(); // 0x00000001887DD2A4-0x00000001887DD3C4
		public override bool Equals(object obj); // 0x00000001887DD210-0x00000001887DD288
		public bool Equals(Int3 other); // 0x00000001887DD288-0x00000001887DD2A4
		public override int GetHashCode(); // 0x0000000187232A20-0x0000000187232A40
	}

	public struct Int2 : IEquatable<RVO.Int2> // TypeDefIndex: 89891
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
	
		// Properties
		public long sqrMagnitudeLong { get; } // 0x0000000187232950-0x0000000187232970 
	
		// Constructors
		public Int2(int x, int y); // 0x00000001827241A0-0x00000001827241B0
	
		// Methods
		public static Int2 operator -(Int2 lhs); // 0x00000001872329B0-0x00000001872329D0
		public static Int2 operator +(Int2 a, Int2 b); // 0x0000000187232970-0x0000000187232990
		public static Int2 operator -(Int2 a, Int2 b); // 0x0000000187232990-0x00000001872329B0
		public static bool operator ==(Int2 a, Int2 b); // 0x00000001887DD0F0-0x00000001887DD108
		public static bool operator !=(Int2 a, Int2 b); // 0x00000001887DD108-0x00000001887DD120
		public static long DotLong(Int2 a, Int2 b); // 0x00000001872328D0-0x0000000187232900
		public override bool Equals(object o); // 0x00000001887DCEC8-0x00000001887DCF28
		public bool Equals(Int2 other); // 0x00000001887DCEB4-0x00000001887DCEC8
		public override int GetHashCode(); // 0x0000000187232920-0x0000000187232930
		public static Int2 Min(Int2 a, Int2 b); // 0x00000001887DCF94-0x00000001887DD000
		public static Int2 Max(Int2 a, Int2 b); // 0x00000001887DCF28-0x00000001887DCF94
		public static Int2 FromInt3XZ(Int3 o); // 0x0000000187232900-0x0000000187232920
		public static Int3 ToInt3XZ(Int2 o); // 0x0000000187232930-0x0000000187232950
		public override string ToString(); // 0x00000001887DD000-0x00000001887DD0F0
	}

	public struct RVOAgentJobData // TypeDefIndex: 89892
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

	public class RVOAgent // TypeDefIndex: 89893
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
		[CompilerGenerated]
		private Action _PreCalculationCallback_k__BackingField; // 0x98
		public RVOAgent next; // 0xA0
		public float calculatedSpeed; // 0xA8
		public Vector2 calculatedTargetPoint; // 0xAC
		public bool steeringTargetInsideObstacle; // 0xB4
		private List<RVOAgent> m_neighbours; // 0xB8
		private List<float> m_neighbourDists; // 0xC0
	
		// Properties
		public Action PreCalculationCallback { [CompilerGenerated] private get; [CompilerGenerated] set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public List<RVOAgent> neighbours { get; } // 0x0000000187232C80-0x0000000187232C90 
	
		// Constructors
		public RVOAgent(); // 0x00000001855E1C20-0x00000001855E1CE0
	
		// Methods
		public void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed); // 0x0000000185540F70-0x0000000185541010
		public void SetCollisionNormal(Vector2 normal); // 0x0000000187232C60-0x0000000187232C70
		public void ForceSetVelocity(Vector2 velocity); // 0x0000000185583B40-0x0000000185583BD0
		public void PreCalculation(); // 0x00000001851B60E0-0x00000001851B6100
		public RVOAgentJobData CreateJobData(); // 0x0000000187232BD0-0x0000000187232C60
		public void PostCalculation(float resultSpeed, Vector2 resultTargetPoint); // 0x00000001851B9450-0x00000001851B9470
		public void CalculateNeighbours(RVOQuadtree quadtree, float desiredDeltaTime); // 0x00000001851B5C50-0x00000001851B60E0
		internal float InsertAgentNeighbour(RVOAgent rvoAgent, float rangeSq); // 0x00000001851B88F0-0x00000001851B8DC0
		private static UnityEngine.Color Rainbow(float v); // 0x00000001887DE4D4-0x00000001887DE51C
	}

	public struct RVOObstacleJobData // TypeDefIndex: 89894
	{
		// Fields
		public int obstacleID; // 0x00
		public int obstacleIndex; // 0x04
		public RVOLayer layer; // 0x08
		public float height; // 0x0C
		public Vector3 position; // 0x10
	
		// Methods
		public static bool operator ==(RVOObstacleJobData a, RVOObstacleJobData b); // 0x00000001887DE68C-0x00000001887DE784
		public static bool operator !=(RVOObstacleJobData a, RVOObstacleJobData b); // 0x00000001887DE784-0x00000001887DE7D8
		public override bool Equals(object obj); // 0x00000001887DE530-0x00000001887DE5D4
		public override int GetHashCode(); // 0x00000001887DE5D4-0x00000001887DE68C
	}

	public class Simulator // TypeDefIndex: 89898
	{
		// Fields
		private float desiredDeltaTime; // 0x10
		private NativeList<RVOAgentJobData> m_jobAgents; // 0x18
		private NativeList<bool> m_jobNeighbours; // 0x28
		private NativeList<RVOObstacleJobData> m_jobObstacles; // 0x38
		private NativeArray<float> m_jobCalculatedSpeeds; // 0x48
		private NativeArray<Vector2> m_jobCalculatedTargetPoints; // 0x58
		private NativeArray<Vector2> m_jobOverlapRecoveryVelocities; // 0x68
		private NativeArray<int> m_jobOverlapRecoveryCounts; // 0x78
		private NativeArray<int> m_jobOverlapRecoveryActiveFlags; // 0x88
		private NativeArray<int> m_jobSteeringTargetInsideObstacleMatrix; // 0x98
		private NativeArray<int> m_jobAgentBufferMaxIndex; // 0xA8
		private NativeArray<Line> m_jobAgentLineBuffer; // 0xB8
		private NativeArray<int> m_jobObsBufferMaxIndex; // 0xC8
		private NativeArray<VO> m_jobObsVoBuffer; // 0xD8
		private NativeList<RVOObstacleJobData> m_obstacles; // 0xE8
		private Dictionary<int, int> m_obstacleIDToIndex; // 0xF8
		private static int s_nextObstacleID; // 0x00
		private bool m_obstaclesChanged; // 0x100
		private List<RVOAgent> m_agents; // 0x108
		private Dictionary<int, int> m_agentIDToIndex; // 0x110
		private static int s_nextAgentID; // 0x04
		[CompilerGenerated]
		private RVOQuadtree _Quadtree_k__BackingField; // 0x118
		private float deltaTime; // 0x120
		private float lastStep; // 0x124
		private readonly float m_symmetryBreakingBias; // 0x128
		private readonly float m_deepOverlapRatio; // 0x12C
		private readonly float m_overlapRecoveryExitRatio; // 0x130
		private readonly int m_vertexCount; // 0x134
		private const float SHRINK_FACTOR = 0.3f; // Metadata: 0x0264A9BD
		private const int INIT_AGENT_COUNT = 32; // Metadata: 0x0264A9C1
		private const int INIT_OBSTACLE_COUNT = 256; // Metadata: 0x0264A9C2
		private const int INIT_AGENT_VO_COUNT = 1024; // Metadata: 0x0264A9C4
		private const int INIT_OBS_VO_COUNT = 2048; // Metadata: 0x0264A9C6
		private int m_agentCount; // 0x138
		private int m_agentVOCount; // 0x13C
		private int m_obsVOCount; // 0x140
		private JobHandle m_handle; // 0x148
	
		// Properties
		public float DesiredDeltaTime { get; set; } // 0x0000000187232D00-0x0000000187232D10 0x00000001870DC710-0x00000001870DC780
		public List<RVOAgent> agents { get; } // 0x0000000187232D20-0x0000000187232D30 
		public RVOQuadtree Quadtree { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232D10-0x0000000187232D20 0x000000018783BFA0-0x000000018783BFB4
	
		// Nested types
		[BurstCompile]
		private struct RVOParallelJob : IJobParallelFor // TypeDefIndex: 89895
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
			public NativeArray<Line> agentLineBuffer; // 0x50
			[NativeDisableParallelForRestriction]
			public NativeArray<float> calculatedSpeeds; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<Vector2> calculatedTargetPoints; // 0x70
			[ReadOnly]
			public NativeArray<Vector2> overlapRecoveryVelocities; // 0x80
			[ReadOnly]
			public NativeArray<int> overlapRecoveryCounts; // 0x90
	
			// Methods
			public void Execute(int index); // 0x00000001887DE7D8-0x00000001887DEB34
		}
	
		[BurstCompile]
		private struct JobForCalcObstacleVO : IJobParallelFor // TypeDefIndex: 89896
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
			[NativeDisableParallelForRestriction]
			public NativeArray<int> steeringTargetInsideObstacleMatrix; // 0x58
	
			// Methods
			public void Execute(int index); // 0x00000001887DDDB4-0x00000001887DE4D4
		}
	
		[BurstCompile]
		private struct JobForCalcAgentNeighbourVO : IJobParallelFor // TypeDefIndex: 89897
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
			public NativeArray<Line> agentLineBuffer; // 0x40
			[NativeDisableParallelForRestriction]
			public NativeArray<Vector2> overlapRecoveryVelocities; // 0x50
			[NativeDisableParallelForRestriction]
			public NativeArray<int> overlapRecoveryCounts; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<int> overlapRecoveryActiveFlags; // 0x70
			[ReadOnly]
			public float deepOverlapRatio; // 0x80
			[ReadOnly]
			public float overlapRecoveryExitRatio; // 0x84
	
			// Methods
			public void Execute(int index); // 0x00000001887DD868-0x00000001887DDDB4
		}
	
		// Constructors
		public Simulator(); // 0x0000000186B27F20-0x0000000186B28410
	
		// Methods
		public void OnDestroy(); // 0x00000001887E0354-0x00000001887E058C
		public RVOAgent AddAgent(); // 0x00000001855E28C0-0x00000001855E2980
		public void RemoveAgent(RVOAgent agent); // 0x00000001864EDF00-0x00000001864EE020
		private void _CompletePendingJob(); // 0x00000001855E39E0-0x00000001855E3A00
		public int AddObstacle(Vector3[] vertices, float height, RVOLayer layer); // 0x00000001855E3A00-0x00000001855E3B80
		public void UpdateObstacle(int obstacleID, Vector3[] vertices); // 0x00000001887E0E78-0x00000001887E0F8C
		public void RemoveObstacle(int obstacleID); // 0x00000001865BF790-0x00000001865BF9C0
		private void BuildQuadtree(); // 0x00000001851B6100-0x00000001851B63D0
		public void Update(); // 0x00000001851B63D0-0x00000001851B7FF0
		private void _Realloc(int agentCount, int obstacleCount); // 0x00000001859F6300-0x00000001859F6890
		[BurstCompile]
		private void _WriteBackResult(); // 0x00000001851B9110-0x00000001851B9450
		private static Vector2 _To2D(Vector3 p, out float elevation); // 0x0000000187232CE0-0x0000000187232D00
		private static bool _IsPointInConvexQuad(Vector2 point, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3); // 0x00000001887E1008-0x00000001887E1144
		private static void _CheckEdgeSign(Vector2 point, Vector2 from, Vector2 to, ref bool hasPositive, ref bool hasNegative, float epsilon); // 0x00000001887E0F8C-0x00000001887E1008
		public static VO SegmentObstacle(Vector2 segmentStart, Vector2 segmentEnd, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime); // 0x00000001887E058C-0x00000001887E0B2C
		private static bool BiasDesiredVelocity(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, ref Vector2 desiredVelocity, ref Vector2 targetPointInVelocitySpace, float maxBiasRadians); // 0x00000001887DEB98-0x00000001887DED90
		private static Vector2 GradientDescent(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, RVOAgentJobData agent, Vector2 sampleAround1, Vector2 sampleAround2, float desiredVelocityWeightScale); // 0x00000001887DF6F8-0x00000001887DF830
		private static Vector2 Trace(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, RVOAgentJobData agent, Vector2 p, float desiredVelocityWeightScale, out float score); // 0x00000001887E0C84-0x00000001887E0E78
		private static Vector2 EvaluateGradient(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, RVOAgentJobData agent, Vector2 p, float desiredVelocityWeightScale, out float value); // 0x00000001887DF474-0x00000001887DF6F8
		private static Vector2 ApplyOverlapRecoveryVelocity(float maxSpeed, Vector2 baseVelocity, Vector2 overlapRecoveryVelocity, int overlapRecoveryCount); // 0x00000001887DEB34-0x00000001887DEB98
		private static bool ShouldUseOverlapRecovery(float dist, float totalRadius, bool wasActive, float enterRatio, float exitRatio); // 0x00000001887E0B2C-0x00000001887E0B50
		private static Vector2 CalculateStableOverlapRecoveryDirection(RVOAgentJobData agent, RVOAgentJobData other, Vector2 awayFromOther); // 0x00000001887DF244-0x00000001887DF344
		private static Line BuildAgentOrcaLine(RVOAgentJobData agent, RVOAgentJobData other, float totalRadius, float deltaTime, float avoidanceStrength); // 0x00000001887DED90-0x00000001887DF244
		private static float Det(Vector2 a, Vector2 b); // 0x0000000187232CB0-0x0000000187232CE0
		private static Vector2 SolveAgentLines(int start, int end, ref NativeArray<Line> lines, float radius, Vector2 preferredVelocity); // 0x00000001887E0B50-0x00000001887E0C84
		private static void ClampResultToAgentLinesFeasible(int start, int end, ref NativeArray<Line> lines, float radius, ref Vector2 result); // 0x00000001887DF344-0x00000001887DF474
		private static bool LP1(int start, int end, ref NativeArray<Line> lines, int lineNo, float radius, Vector2 optVelocity, bool dirOpt, ref Vector2 result); // 0x00000001887DF830-0x00000001887DFB70
		private static int LP2(int start, int end, ref NativeArray<Line> lines, float radius, Vector2 optVelocity, bool dirOpt, ref Vector2 result); // 0x00000001887DFB70-0x00000001887DFD20
		private static void LP3(int start, int end, ref NativeArray<Line> lines, int beginLine, float radius, ref Vector2 result); // 0x00000001887DFD20-0x00000001887E0354
	}

	public struct Line // TypeDefIndex: 89899
	{
		// Fields
		public Vector2 point; // 0x00
		public Vector2 dir; // 0x08
	}

	public class RVOQuadtree // TypeDefIndex: 89902
	{
		// Fields
		private const int LeafSize = 15; // Metadata: 0x0264A9C8
		private float maxRadius; // 0x10
		private Node[] m_nodes; // 0x18
		private int filledNodes; // 0x20
		private Rect m_bounds; // 0x24
	
		// Properties
		public Node[] nodes { get; } // 0x0000000182234E30-0x0000000182234E40 
		public Rect bounds { get; } // 0x0000000187232CA0-0x0000000187232CB0 
	
		// Nested types
		public struct Node // TypeDefIndex: 89900
		{
			// Fields
			public int child00; // 0x00
			public RVOAgent linkedList; // 0x08
			public byte count; // 0x10
			public float maxSpeed; // 0x14
	
			// Methods
			public void Add(RVOAgent rvoAgent); // 0x00000001851B9030-0x00000001851B9110
			public void Distribute(Node[] nodes, Rect r); // 0x0000000185E10010-0x0000000185E10230
			public float CalculateMaxSpeed(Node[] nodes, int index); // 0x00000001851B8E70-0x00000001851B9030
		}
	
		private struct QuadtreeQuery // TypeDefIndex: 89901
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
			public void QueryRec(int i, Rect r); // 0x00000001851B84A0-0x00000001851B88F0
		}
	
		// Constructors
		public RVOQuadtree(); // 0x0000000186B28520-0x0000000186B28570
	
		// Methods
		public void Clear(); // 0x00000001862A6690-0x00000001862A66D0
		public void SetBounds(Rect r); // 0x0000000187232C90-0x0000000187232CA0
		private int GetNodeIndex(); // 0x000000018611BF50-0x000000018611C0E0
		public void Insert(RVOAgent rvoAgent); // 0x00000001851B7FF0-0x00000001851B84A0
		public void CalculateSpeeds(); // 0x00000001862A66D0-0x00000001862A6710
		public void Query(Vector2 p, float speed, float timeHorizon, float agentRadius, RVOAgent rvoAgent); // 0x00000001851B5B30-0x00000001851B5C50
	}

	public struct VO // TypeDefIndex: 89903
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
		public VO(Vector2 center, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime); // 0x00000001887E1508-0x00000001887E1940
	
		// Methods
		public static float SignedDistanceFromLine(Vector2 a, Vector2 dir, Vector2 p); // 0x0000000187232D30-0x0000000187232D70
		public Vector2 ScaledGradient(Vector2 p, out float weight); // 0x00000001887E1490-0x00000001887E1508
		public Vector2 Gradient(Vector2 p, out float weight); // 0x00000001887E1144-0x00000001887E1490
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 89884
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
