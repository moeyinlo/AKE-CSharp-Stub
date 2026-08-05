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

// Image 82: AstarPathfindingProject.dll - Assembly: AstarPathfindingProject, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62595-62616
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 62596
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace RVO
{
	public static class AstarMemory // TypeDefIndex: 62598
	{
		// Methods
		public static T[] ShrinkArray<T>(T[] arr, int newLength);
		public static void Swap<T>(ref ref T a, ref ref T b);
		public static void Realloc<T>(ref NativeArray<T> arr, int newSize, Unity.Collections.Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x02352039 */)
			where T : struct;
		public static void Realloc<T>(ref ref T[] arr, int newSize);
		public static T[] UnsafeAppendBufferToArray<T>(UnsafeAppendBuffer src)
			where T : struct;
	}

	[BurstCompatible]
	public static class NativeCollectionExtensions // TypeDefIndex: 62599
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
	public enum RVOLayer // TypeDefIndex: 62600
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

	public enum Side : byte // TypeDefIndex: 62601
	{
		Colinear = 0,
		Left = 1,
		Right = 2
	}

	public static class VectorMath // TypeDefIndex: 62602
	{
		// Methods
		public static Vector2 ComplexMultiply(Vector2 a, Vector2 b); // 0x0000000184D86030-0x0000000184D86080
		public static Vector2 ComplexMultiplyConjugate(Vector2 a, Vector2 b); // 0x0000000184D85FE0-0x0000000184D86030
		public static Vector3 ClosestPointOnLine(Vector3 lineStart, Vector3 lineEnd, Vector3 point); // 0x0000000186356338-0x000000018635647C
		public static float ClosestPointOnLineFactor(Vector3 lineStart, Vector3 lineEnd, Vector3 point); // 0x00000001863560A0-0x0000000186356180
		public static float ClosestPointOnLineFactor(Int3 lineStart, Int3 lineEnd, Int3 point); // 0x0000000186356180-0x0000000186356288
		public static float ClosestPointOnLineFactor(Int2 lineStart, Int2 lineEnd, Int2 point); // 0x0000000186356288-0x0000000186356338
		public static Vector3 ClosestPointOnSegment(Vector3 lineStart, Vector3 lineEnd, Vector3 point); // 0x0000000186356644-0x00000001863567A4
		public static Vector3 ClosestPointOnSegmentXZ(Vector3 lineStart, Vector3 lineEnd, Vector3 point); // 0x000000018635647C-0x0000000186356644
		public static float SqrDistancePointSegmentApproximate(int x, int z, int px, int pz, int qx, int qz); // 0x000000018635867C-0x0000000186358750
		public static float SqrDistancePointSegmentApproximate(Int3 a, Int3 b, Int3 p); // 0x00000001863585A8-0x000000018635867C
		public static float SqrDistancePointSegment(Vector3 a, Vector3 b, Vector3 p); // 0x0000000186358750-0x00000001863587F8
		public static float SqrDistanceSegmentSegment(Vector3 s1, Vector3 e1, Vector3 s2, Vector3 e2); // 0x00000001863587F8-0x0000000186358C64
		public static float SqrDistanceXZ(Vector3 a, Vector3 b); // 0x0000000186358C64-0x0000000186358D98
		public static long SignedTriangleAreaTimes2XZ(Int3 a, Int3 b, Int3 c); // 0x0000000184D860F0-0x0000000184D86130
		public static float SignedTriangleAreaTimes2XZ(Vector3 a, Vector3 b, Vector3 c); // 0x0000000184D860B0-0x0000000184D860F0
		public static bool RightXZ(Vector3 a, Vector3 b, Vector3 p); // 0x0000000186357BA8-0x0000000186357BEC
		public static bool RightXZ(Int3 a, Int3 b, Int3 p); // 0x0000000186357BEC-0x0000000186357C30
		public static Side SideXZ(Int3 a, Int3 b, Int3 p); // 0x000000018635856C-0x00000001863585A8
		public static bool RightOrColinear(Vector2 a, Vector2 b, Vector2 p); // 0x0000000186357B4C-0x0000000186357BA8
		public static bool RightOrColinear(Int2 a, Int2 b, Int2 p); // 0x0000000186357B10-0x0000000186357B4C
		public static bool RightOrColinearXZ(Vector3 a, Vector3 b, Vector3 p); // 0x0000000186357AA0-0x0000000186357ADC
		public static bool RightOrColinearXZ(Int3 a, Int3 b, Int3 p); // 0x0000000186357ADC-0x0000000186357B10
		public static bool IsClockwiseMarginXZ(Vector3 a, Vector3 b, Vector3 c); // 0x00000001863567A4-0x00000001863567E8
		public static bool IsClockwiseXZ(Vector3 a, Vector3 b, Vector3 c); // 0x0000000184396FA0-0x0000000184396FE0
		public static bool IsClockwiseXZ(Int3 a, Int3 b, Int3 c); // 0x00000001863568A8-0x000000018635692C
		public static bool IsClockwiseOrColinearXZ(Int3 a, Int3 b, Int3 c); // 0x00000001863567E8-0x000000018635686C
		public static bool IsClockwiseOrColinear(Int2 a, Int2 b, Int2 c); // 0x000000018635686C-0x00000001863568A8
		public static bool IsColinear(Vector3 a, Vector3 b, Vector3 c); // 0x0000000186356A54-0x0000000186356B48
		public static bool IsColinear(Vector2 a, Vector2 b, Vector2 c); // 0x00000001863569E8-0x0000000186356A54
		public static bool IsColinearXZ(Int3 a, Int3 b, Int3 c); // 0x00000001863569B8-0x00000001863569E8
		public static bool IsColinearXZ(Vector3 a, Vector3 b, Vector3 c); // 0x0000000186356968-0x00000001863569B8
		public static bool IsColinearAlmostXZ(Int3 a, Int3 b, Int3 c); // 0x000000018635692C-0x0000000186356968
		public static bool SegmentsIntersect(Int2 start1, Int2 end1, Int2 start2, Int2 end2); // 0x0000000186358454-0x000000018635856C
		public static bool SegmentsIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2); // 0x000000018635812C-0x0000000186358324
		public static bool SegmentsIntersectXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2); // 0x0000000186358324-0x0000000186358454
		public static bool LineLineIntersectionFactor(Vector2 start1, Vector2 dir1, Vector2 start2, Vector2 dir2, out float t); // 0x00000001863574EC-0x0000000186357578
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2); // 0x0000000186356CB8-0x0000000186356D90
		public static Vector3 LineDirIntersectionPointXZ(Vector3 start1, Vector3 dir1, Vector3 start2, Vector3 dir2, out bool intersects); // 0x0000000186356D90-0x0000000186356E80
		public static bool RaySegmentIntersectXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2); // 0x0000000186357788-0x00000001863578BC
		public static bool LineIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2, out float factor1, out float factor2); // 0x0000000186356E80-0x0000000186356FC4
		public static bool LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out float factor1, out float factor2); // 0x00000001863570B4-0x00000001863571F0
		public static float LineRayIntersectionFactorXZ(Int3 start1, Int3 end1, Int3 start2, Int3 end2); // 0x0000000186357578-0x00000001863576A4
		public static float LineIntersectionFactorXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2); // 0x0000000186356FC4-0x00000001863570B4
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2); // 0x00000001863571F0-0x000000018635729C
		public static Vector3 LineIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects); // 0x000000018635729C-0x00000001863573F4
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2); // 0x00000001863573F4-0x0000000186357418
		public static Vector2 LineIntersectionPoint(Vector2 start1, Vector2 end1, Vector2 start2, Vector2 end2, out bool intersects); // 0x0000000186357418-0x00000001863574EC
		public static Vector3 SegmentIntersectionPointXZ(Vector3 start1, Vector3 end1, Vector3 start2, Vector3 end2, out bool intersects); // 0x0000000186357C30-0x0000000186357DE0
		public static bool SegmentIntersectsBounds(Bounds bounds, Vector3 a, Vector3 b); // 0x0000000186357DE0-0x000000018635812C
		public static float LineCircleIntersectionFactor(Vector3 circleCenter, Vector3 linePoint1, Vector3 linePoint2, float radius); // 0x0000000186356B48-0x0000000186356CB8
		public static bool ReversesFaceOrientations(Matrix4x4 matrix); // 0x000000018635797C-0x0000000186357AA0
		public static bool ReversesFaceOrientationsXZ(Matrix4x4 matrix); // 0x00000001863578BC-0x000000018635797C
		public static Vector3 Normalize(Vector3 v, out float magnitude); // 0x00000001863576A4-0x0000000186357734
		public static Vector2 Normalize(Vector2 v, out float magnitude); // 0x0000000186357734-0x0000000186357788
		public static Vector3 ClampMagnitudeXZ(Vector3 v, float maxMagnitude); // 0x000000018635601C-0x00000001863560A0
		public static float MagnitudeXZ(Vector3 v); // 0x0000000184D86080-0x0000000184D860B0
	}

	public struct Int3 : IEquatable<RVO.Int3> // TypeDefIndex: 62603
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public const int Precision = 1000; // Metadata: 0x0235209C
		public const float FloatPrecision = 1000f; // Metadata: 0x0235209E
		public const float PrecisionFactor = 0.001f; // Metadata: 0x023520A2
	
		// Properties
		public static Int3 zero { get; } // 0x0000000184D85DC0-0x0000000184D85DD0 
		public int this[int i] { get => default; set {} } // 0x0000000186351C5C-0x0000000186351C70 0x0000000186352050-0x0000000186352068
		public float magnitude { get; } // 0x0000000186351CD0-0x0000000186351D64 
		public int costMagnitude { get; } // 0x0000000186351C70-0x0000000186351CD0 
		public float sqrMagnitude { get; } // 0x0000000184D85D90-0x0000000184D85DC0 
		public long sqrMagnitudeLong { get; } // 0x0000000184D85D70-0x0000000184D85D90 
	
		// Constructors
		public Int3(Vector3 position); // 0x0000000186351BC4-0x0000000186351C5C
		public Int3(int _x, int _y, int _z); // 0x0000000184D85D60-0x0000000184D85D70
	
		// Methods
		public static bool operator ==(Int3 lhs, Int3 rhs); // 0x0000000186351A88-0x0000000186351AA4
		public static bool operator !=(Int3 lhs, Int3 rhs); // 0x0000000186351EDC-0x0000000186351EF8
		public static explicit operator Int3(Vector3 ob); // 0x0000000186351E14-0x0000000186351ECC
		public static explicit operator Vector3(Int3 ob); // 0x0000000184D85E00-0x0000000184D85E40
		public static Int3 operator -(Int3 lhs, Int3 rhs); // 0x0000000184D85E70-0x0000000184D85EA0
		public static Int3 operator -(Int3 lhs); // 0x0000000184D85EA0-0x0000000184D85ED0
		public static Int3 operator +(Int3 lhs, Int3 rhs); // 0x0000000184D85DD0-0x0000000184D85E00
		public static Int3 operator *(Int3 lhs, int rhs); // 0x0000000184D85E40-0x0000000184D85E70
		public static Int3 operator *(Int3 lhs, float rhs); // 0x0000000186351EF8-0x0000000186351FA8
		public static Int3 operator *(Int3 lhs, double rhs); // 0x0000000186351FA8-0x0000000186352050
		public static Int3 operator /(Int3 lhs, float rhs); // 0x0000000186351D64-0x0000000186351E14
		public static float Angle(Int3 lhs, Int3 rhs); // 0x0000000186351920-0x0000000186351A10
		public static int Dot(Int3 lhs, Int3 rhs); // 0x0000000184D85D00-0x0000000184D85D20
		public static long DotLong(Int3 lhs, Int3 rhs); // 0x0000000184D85CD0-0x0000000184D85D00
		public Int3 Normal2D(); // 0x0000000184D85D40-0x0000000184D85D60
		public static implicit operator string(Int3 obj); // 0x0000000186351ECC-0x0000000186351EDC
		public override string ToString(); // 0x0000000186351AA4-0x0000000186351BC4
		public override bool Equals(object obj); // 0x0000000186351A10-0x0000000186351A88
		public bool Equals(Int3 other); // 0x0000000186351A88-0x0000000186351AA4
		public override int GetHashCode(); // 0x0000000184D85D20-0x0000000184D85D40
	}

	public struct Int2 : IEquatable<RVO.Int2> // TypeDefIndex: 62604
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
	
		// Properties
		public long sqrMagnitudeLong { get; } // 0x0000000184D85C50-0x0000000184D85C70 
	
		// Constructors
		public Int2(int x, int y); // 0x0000000184D85C40-0x0000000184D85C50
	
		// Methods
		public static Int2 operator -(Int2 lhs); // 0x0000000184D85CB0-0x0000000184D85CD0
		public static Int2 operator +(Int2 a, Int2 b); // 0x0000000184D85C70-0x0000000184D85C90
		public static Int2 operator -(Int2 a, Int2 b); // 0x0000000184D85C90-0x0000000184D85CB0
		public static bool operator ==(Int2 a, Int2 b); // 0x00000001863518F0-0x0000000186351908
		public static bool operator !=(Int2 a, Int2 b); // 0x0000000186351908-0x0000000186351920
		public static long DotLong(Int2 a, Int2 b); // 0x0000000184D85BC0-0x0000000184D85BF0
		public override bool Equals(object o); // 0x00000001863516C8-0x0000000186351728
		public bool Equals(Int2 other); // 0x00000001863516B4-0x00000001863516C8
		public override int GetHashCode(); // 0x0000000184D85C10-0x0000000184D85C20
		public static Int2 Min(Int2 a, Int2 b); // 0x0000000186351794-0x0000000186351800
		public static Int2 Max(Int2 a, Int2 b); // 0x0000000186351728-0x0000000186351794
		public static Int2 FromInt3XZ(Int3 o); // 0x0000000184D85BF0-0x0000000184D85C10
		public static Int3 ToInt3XZ(Int2 o); // 0x0000000184D85C20-0x0000000184D85C40
		public override string ToString(); // 0x0000000186351800-0x00000001863518F0
	}

	public struct RVOAgentJobData // TypeDefIndex: 62605
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

	public class RVOAgent // TypeDefIndex: 62606
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
		public Action PreCalculationCallback { [CompilerGenerated] private get; [CompilerGenerated] set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
		public List<RVOAgent> neighbours { get; } // 0x0000000184D85EF0-0x0000000184D85F00 
	
		// Constructors
		public RVOAgent(); // 0x000000018397F440-0x000000018397F500
	
		// Methods
		public void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed); // 0x00000001834EF4B0-0x00000001834EF550
		public void SetCollisionNormal(Vector2 normal); // 0x0000000184D85ED0-0x0000000184D85EE0
		public void ForceSetVelocity(Vector2 velocity); // 0x00000001832C2240-0x00000001832C22D0
		public void PreCalculation(); // 0x0000000182EE4890-0x0000000182EE48B0
		public RVOAgentJobData CreateJobData(); // 0x0000000182EE48B0-0x0000000182EE4970
		public void PostCalculation(float resultSpeed, Vector2 resultTargetPoint); // 0x000000018333C380-0x000000018333C3A0
		public void CalculateNeighbours(RVOQuadtree quadtree, float desiredDeltaTime); // 0x0000000182EE3510-0x0000000182EE39A0
		internal float InsertAgentNeighbour(RVOAgent rvoAgent, float rangeSq); // 0x0000000182EE6FD0-0x0000000182EE7490
		private static UnityEngine.Color Rainbow(float v); // 0x0000000186352CC4-0x0000000186352D0C
	}

	public struct RVOObstacleJobData // TypeDefIndex: 62607
	{
		// Fields
		public int obstacleID; // 0x00
		public int obstacleIndex; // 0x04
		public RVOLayer layer; // 0x08
		public float height; // 0x0C
		public Vector3 position; // 0x10
	
		// Methods
		public static bool operator ==(RVOObstacleJobData a, RVOObstacleJobData b); // 0x0000000186352E7C-0x0000000186352F74
		public static bool operator !=(RVOObstacleJobData a, RVOObstacleJobData b); // 0x0000000186352F74-0x0000000186352FC8
		public override bool Equals(object obj); // 0x0000000186352D20-0x0000000186352DC4
		public override int GetHashCode(); // 0x0000000186352DC4-0x0000000186352E7C
	}

	public class Simulator // TypeDefIndex: 62611
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
		private const float SHRINK_FACTOR = 0.3f; // Metadata: 0x023520A6
		private const int INIT_AGENT_COUNT = 32; // Metadata: 0x023520AA
		private const int INIT_OBSTACLE_COUNT = 256; // Metadata: 0x023520AB
		private const int INIT_AGENT_VO_COUNT = 1024; // Metadata: 0x023520AD
		private const int INIT_OBS_VO_COUNT = 2048; // Metadata: 0x023520AF
		private int m_agentCount; // 0x138
		private int m_agentVOCount; // 0x13C
		private int m_obsVOCount; // 0x140
		private JobHandle m_handle; // 0x148
	
		// Properties
		public float DesiredDeltaTime { get; set; } // 0x0000000184D85F70-0x0000000184D85F80 0x0000000184B423B0-0x0000000184B42420
		public List<RVOAgent> agents { get; } // 0x0000000184D85F90-0x0000000184D85FA0 
		public RVOQuadtree Quadtree { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85F80-0x0000000184D85F90 0x000000018539715C-0x0000000185397170
	
		// Nested types
		[BurstCompile]
		private struct RVOParallelJob : IJobParallelFor // TypeDefIndex: 62608
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
			public void Execute(int index); // 0x0000000186352FC8-0x00000001863532DC
		}
	
		[BurstCompile]
		private struct JobForCalcObstacleVO : IJobParallelFor // TypeDefIndex: 62609
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
			public void Execute(int index); // 0x00000001863525B4-0x0000000186352CC4
		}
	
		[BurstCompile]
		private struct JobForCalcAgentNeighbourVO : IJobParallelFor // TypeDefIndex: 62610
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
			public void Execute(int index); // 0x0000000186352068-0x00000001863525B4
		}
	
		// Constructors
		public Simulator(); // 0x00000001845A3290-0x00000001845A3780
	
		// Methods
		public void OnDestroy(); // 0x0000000186354AA8-0x0000000186354CD8
		public RVOAgent AddAgent(); // 0x000000018397F050-0x000000018397F420
		public void RemoveAgent(RVOAgent agent); // 0x000000018397FF10-0x0000000183980110
		private void _CompletePendingJob(); // 0x000000018397F420-0x000000018397F440
		public int AddObstacle(Vector3[] vertices, float height, RVOLayer layer); // 0x00000001833A6EB0-0x00000001833A7020
		public void UpdateObstacle(int obstacleID, Vector3[] vertices); // 0x00000001863555D0-0x00000001863556E4
		public void RemoveObstacle(int obstacleID); // 0x00000001833DF240-0x00000001833DF450
		private void BuildQuadtree(); // 0x0000000182EE4970-0x0000000182EE4C40
		public void Update(); // 0x0000000182EE4C40-0x0000000182EE66F0
		private void _Realloc(int agentCount, int obstacleCount); // 0x0000000183AFFD00-0x0000000183B002A0
		[BurstCompile]
		private void _WriteBackResult(); // 0x000000018333C050-0x000000018333C380
		private static Vector2 _To2D(Vector3 p, out float elevation); // 0x0000000184D85F50-0x0000000184D85F70
		private static bool _IsPointInConvexQuad(Vector2 point, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3); // 0x0000000186355760-0x0000000186355890
		private static void _CheckEdgeSign(Vector2 point, Vector2 from, Vector2 to, ref bool hasPositive, ref bool hasNegative, float epsilon); // 0x00000001863556E4-0x0000000186355760
		public static VO SegmentObstacle(Vector2 segmentStart, Vector2 segmentEnd, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime); // 0x0000000186354CD8-0x0000000186355290
		private static bool BiasDesiredVelocity(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, ref Vector2 desiredVelocity, ref Vector2 targetPointInVelocitySpace, float maxBiasRadians); // 0x0000000186353340-0x0000000186353530
		private static Vector2 GradientDescent(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, RVOAgentJobData agent, Vector2 sampleAround1, Vector2 sampleAround2, float desiredVelocityWeightScale); // 0x0000000186353E74-0x0000000186353FA0
		private static Vector2 Trace(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, RVOAgentJobData agent, Vector2 p, float desiredVelocityWeightScale, out float score); // 0x00000001863553E4-0x00000001863555D0
		private static Vector2 EvaluateGradient(int obsStart, int obsEnd, ref NativeArray<VO> obsVos, RVOAgentJobData agent, Vector2 p, float desiredVelocityWeightScale, out float value); // 0x0000000186353BF8-0x0000000186353E74
		private static Vector2 ApplyOverlapRecoveryVelocity(float maxSpeed, Vector2 baseVelocity, Vector2 overlapRecoveryVelocity, int overlapRecoveryCount); // 0x00000001863532DC-0x0000000186353340
		private static bool ShouldUseOverlapRecovery(float dist, float totalRadius, bool wasActive, float enterRatio, float exitRatio); // 0x0000000186355290-0x00000001863552B4
		private static Vector2 CalculateStableOverlapRecoveryDirection(RVOAgentJobData agent, RVOAgentJobData other, Vector2 awayFromOther); // 0x00000001863539C8-0x0000000186353AC8
		private static Line BuildAgentOrcaLine(RVOAgentJobData agent, RVOAgentJobData other, float totalRadius, float deltaTime, float avoidanceStrength); // 0x0000000186353530-0x00000001863539C8
		private static float Det(Vector2 a, Vector2 b); // 0x0000000184D85F20-0x0000000184D85F50
		private static Vector2 SolveAgentLines(int start, int end, ref NativeArray<Line> lines, float radius, Vector2 preferredVelocity); // 0x00000001863552B4-0x00000001863553E4
		private static void ClampResultToAgentLinesFeasible(int start, int end, ref NativeArray<Line> lines, float radius, ref Vector2 result); // 0x0000000186353AC8-0x0000000186353BF8
		private static bool LP1(int start, int end, ref NativeArray<Line> lines, int lineNo, float radius, Vector2 optVelocity, bool dirOpt, ref Vector2 result); // 0x0000000186353FA0-0x00000001863542E8
		private static int LP2(int start, int end, ref NativeArray<Line> lines, float radius, Vector2 optVelocity, bool dirOpt, ref Vector2 result); // 0x00000001863542E8-0x0000000186354498
		private static void LP3(int start, int end, ref NativeArray<Line> lines, int beginLine, float radius, ref Vector2 result); // 0x0000000186354498-0x0000000186354AA8
	}

	public struct Line // TypeDefIndex: 62612
	{
		// Fields
		public Vector2 point; // 0x00
		public Vector2 dir; // 0x08
	}

	public class RVOQuadtree // TypeDefIndex: 62615
	{
		// Fields
		private const int LeafSize = 15; // Metadata: 0x023520B1
		private float maxRadius; // 0x10
		private Node[] m_nodes; // 0x18
		private int filledNodes; // 0x20
		private Rect m_bounds; // 0x24
	
		// Properties
		public Node[] nodes { get; } // 0x000000018385B100-0x000000018385B110 
		public Rect bounds { get; } // 0x0000000184D85F10-0x0000000184D85F20 
	
		// Nested types
		public struct Node // TypeDefIndex: 62613
		{
			// Fields
			public int child00; // 0x00
			public RVOAgent linkedList; // 0x08
			public byte count; // 0x10
			public float maxSpeed; // 0x14
	
			// Methods
			public void Add(RVOAgent rvoAgent); // 0x0000000182EE47B0-0x0000000182EE4890
			public void Distribute(Node[] nodes, Rect r); // 0x0000000183BFB810-0x0000000183BFB920
			public float CalculateMaxSpeed(Node[] nodes, int index); // 0x0000000182EE78A0-0x0000000182EE7A60
		}
	
		private struct QuadtreeQuery // TypeDefIndex: 62614
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
			public void QueryRec(int i, Rect r); // 0x0000000182EE6B80-0x0000000182EE6FD0
		}
	
		// Constructors
		public RVOQuadtree(); // 0x00000001845A3890-0x00000001845A38E0
	
		// Methods
		public void Clear(); // 0x00000001840DE2D0-0x00000001840DE310
		public void SetBounds(Rect r); // 0x0000000184D85F00-0x0000000184D85F10
		private int GetNodeIndex(); // 0x0000000183EA50D0-0x0000000183EA5260
		public void Insert(RVOAgent rvoAgent); // 0x0000000182EE66F0-0x0000000182EE6B80
		public void CalculateSpeeds(); // 0x00000001840DE310-0x00000001840DE350
		public void Query(Vector2 p, float speed, float timeHorizon, float agentRadius, RVOAgent rvoAgent); // 0x0000000182EE33F0-0x0000000182EE3510
	}

	public struct VO // TypeDefIndex: 62616
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
		public VO(Vector2 center, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime); // 0x0000000186355C4C-0x000000018635601C
	
		// Methods
		public static float SignedDistanceFromLine(Vector2 a, Vector2 dir, Vector2 p); // 0x0000000184D85FA0-0x0000000184D85FE0
		public Vector2 ScaledGradient(Vector2 p, out float weight); // 0x0000000186355BD4-0x0000000186355C4C
		public Vector2 Gradient(Vector2 p, out float weight); // 0x0000000186355890-0x0000000186355BD4
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 62597
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
