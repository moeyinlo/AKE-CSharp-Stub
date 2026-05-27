/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

// Image 122: AbilityUnsafe.Gameplay.Beyond.dll - Assembly: AbilityUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59985-59998
[assembly: CompilationRelaxations(8)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond
{
	public struct FPtrAnimNativeCurve // TypeDefIndex: 59989
	{
		// Fields
		private unsafe Keyframe* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
		private static KeyframeComparer s_keyframeComparer; // 0x00
		public static readonly float4x4 CURVE_MATRIX; // 0x04
		public static readonly float3x3 CURVE_MATRIX_PRIME; // 0x44
	
		// Nested types
		public struct KeyframeComparer : IComparer<Keyframe> // TypeDefIndex: 59988
		{
			// Methods
			public int Compare(Keyframe keyframe1, Keyframe keyframe2) => default; // 0x000000018231AF20-0x000000018231AF60
		}
	
		// Constructors
		static FPtrAnimNativeCurve() {
			s_keyframeComparer = default;
			CURVE_MATRIX = default;
			CURVE_MATRIX_PRIME = default;
		} // 0x00000001838A4860-0x00000001838A4A50
	
		// Methods
		public bool IsValid() => default; // 0x0000000184278130-0x0000000184278138
		public NativeArray<Keyframe> CreateCurve(AnimationCurve animationCurve, Unity.Collections.Allocator allocator) => default; // 0x0000000182CFC870-0x0000000182CFCA90
		public NativeArray<Keyframe> CreateLine(float val, Unity.Collections.Allocator allocator) => default; // 0x0000000182CFC070-0x0000000182CFC1A0
		public float Evaluate(float time) => default; // 0x00000001842778AC-0x00000001842779D0
		public static unsafe int GetInsertionIndex(Keyframe* keys, int valuesLength, float time) => default; // 0x0000000184277CC0-0x0000000184277D24
		public float WrapTime(float time) => default; // 0x00000001842782BC-0x0000000184278398
		public float Evaluate(float time, ref Keyframe keyframe, ref Keyframe nextKeyframe) => default; // 0x00000001842779D0-0x0000000184277CC0
		public float CubicBezier([IsReadOnly] in float4 curveMatrix, float t) => default; // 0x0000000184277810-0x0000000184277854
		public float CubicBezier([IsReadOnly] in float3 curveMatrix, float t) => default; // 0x00000001842777C8-0x0000000184277810
		public float DeCasteljauBezier(int degree, float4 coords, float t) => default; // 0x0000000184277854-0x00000001842778AC
		public void GetTWithBisectionMethod(float time, [IsReadOnly] in float4 curveXCoords, ref float t, ref float tBottom, ref float tTop, ref float diff) {} // 0x0000000184277D24-0x0000000184277E8C
		public void GetTWithNewtonMethod(float time, [IsReadOnly] in float4 xCoords, [IsReadOnly] in float4 curveXCoords, ref float t, ref float tBottom, ref float tTop, ref float diff) {} // 0x0000000184277E8C-0x0000000184278130
		public float UseNewtonMethod(float4 curveCoords, float coord, float t, float3 curvePrimeCoords, float4 primePrimeCoords, out float coordAtT) {
			coordAtT = default;
			return default;
		} // 0x0000000184278170-0x00000001842782BC
		public void UpdateTLimits(float x, float time, float t, ref float tBottom, ref float tTop) {} // 0x0000000184278138-0x0000000184278170
	}

	public struct FPtrNativeCurve // TypeDefIndex: 59990
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe float* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
	
		// Methods
		public bool IsValid() => default; // 0x0000000184278130-0x0000000184278138
		public NativeArray<float> CreateCurve(AnimationCurve curve, int resolution) => default; // 0x0000000184278398-0x000000018427856C
		public float Evaluate(float t) => default; // 0x000000018427856C-0x00000001842786BC
		private float _Repeat(float t, float length) => default; // 0x0000000184277234-0x0000000184277280
		private float _Pingpong(float t, float length) => default; // 0x00000001842786BC-0x00000001842786F0
	}
}

namespace Beyond.Gameplay.AbilityUnsafe
{
	public enum ENPCAbilityPathFollowStateType // TypeDefIndex: 59996
	{
		Idle = 0,
		Move = 1,
		MoveStop = 2
	}

	public struct FNPCAbilityPathFollowFragment // TypeDefIndex: 59998
	{
		// Fields
		public const int TOTAL_POINT_CAPACITY = 32; // Metadata: 0x01FDD5B3
		public const int ELEMENT_PER_POINT = 7; // Metadata: 0x01FDD5B4
		private unsafe fixed /* 0x00000000-0x00000000 */ float m_pathPointQueue[0]; // 0x00
		private int m_front; // 0x380
		private int m_pointCount; // 0x384
		public ENPCAbilityPathFollowStateType state; // 0x388
		public Vector3 passedAim; // 0x38C
		public int passedAimStyle; // 0x398
		public int passedAimExtInfo; // 0x39C
		public float passedAimSpeed; // 0x3A0
		public bool passedPatrolActionPoint; // 0x3A4
		private Vector3 m_StartPos; // 0x3A8
		public Vector3 forward; // 0x3B4
		public float maxDistance; // 0x3C0
		public float progressDistance; // 0x3C4
		public bool startMoveProcess; // 0x3C8
		public bool bPathFollowEnd; // 0x3C9
		public float startMoveStopTime; // 0x3CC
		public int loopCount; // 0x3D0
		public int loopCountStartIndex; // 0x3D4
		public bool bRetargetAim; // 0x3D8
		public bool pathChanged; // 0x3D9
		private bool m_passedPoint; // 0x3DA
		public float groundSlopeAngle; // 0x3DC
	
		// Properties
		public int pointCount { get => default; } // 0x0000000183D4E230-0x0000000183D4E240 
		public Vector3 aim { get => default; } // 0x0000000184270088-0x00000001842700B8 
		public int aimStyle { get => default; } // 0x000000018427007C-0x0000000184270088 
		public int aimExtInfo { get => default; } // 0x00000001842777BC-0x00000001842777C8 
		public float aimDesiredSpeed { get => default; } // 0x00000001842721A4-0x00000001842721B0 
		public Vector3 startPos { get => default; set {} } // 0x0000000183D4E240-0x0000000183D4E260 0x0000000183D4E260-0x0000000183D4E280
	
		// Methods
		public void Init() {} // 0x0000000182983B50-0x0000000182983B80
		public void MarkPathFollowEnd() {} // 0x0000000183D4E200-0x0000000183D4E230
		public void MarkMoveStop(float time) {} // 0x0000000183D4E1D0-0x0000000183D4E200
		public void SetPathIsLoop(bool bIsLoop) {} // 0x00000001842776D8-0x0000000184277704
		public bool GetPathIsLoop() => default; // 0x00000001824A1A90-0x00000001824A1AA0
		public bool PushPoint(Vector3 point, int styleEnum, int extPointInfo, float desiredSpeed, bool patrolActionPoint) => default; // 0x000000018254C5C0-0x000000018254C710
		public bool PopPathPoint() => default; // 0x00000001842774BC-0x00000001842775D8
		private bool _RefreshScope() => default; // 0x000000018427779C-0x00000001842777BC
		public void CalGroundSlope(Vector3 curPos, Vector3 steeringPos, float speed, float smoothTime) {} // 0x0000000184277280-0x00000001842773A4
		public static float SlopeAngleDeg(Vector3 pos, Vector3 aim) => default; // 0x0000000184277704-0x000000018427779C
		public bool ReplaceLastPoint(Vector3 point, int styleEnum, int extPointInfo, float desiredSpeed) => default; // 0x00000001842775D8-0x00000001842776A8
		public void ClearAllPathPoints() {} // 0x0000000183D4E1B0-0x0000000183D4E1D0
		public Vector3 GetPathPoint(int idx) => default; // 0x00000001824A1D60-0x00000001824A1DC0
		public int GetPathPointStyle(int idx) => default; // 0x00000001824A21E0-0x00000001824A2270
		public int GetPathPointExtInfo(int idx) => default; // 0x0000000184277404-0x0000000184277434
		public float GetPathPointDesiredSpeed(int idx) => default; // 0x00000001837B1860-0x00000001837B18A0
		public void SetAimPointDesiredSpeed(float speed) {} // 0x00000001842776A8-0x00000001842776D8
		public bool IsSubActionPoint(int idx) => default; // 0x0000000184277484-0x00000001842774BC
		public bool IsPathFull() => default; // 0x0000000184277478-0x0000000184277484
		public int GetPointCount() => default; // 0x00000001824A1A70-0x00000001824A1A90
		public float GetPathLength(Vector3 currentLocation) => default; // 0x00000001824A1BD0-0x00000001824A1D60
		public int GetEffectPointCount() => default; // 0x00000001842773F0-0x0000000184277404
		public static int FloatToInt32Bits(float v) => default; // 0x00000001842773A4-0x00000001842773F0
		public static float Int32BitsToFloat(int v) => default; // 0x0000000184277434-0x0000000184277478
	}
}

namespace Beyond.NPC.Ability
{
	public class NPCAbilityUnsafeUtils // TypeDefIndex: 59991
	{
		// Constructors
		public NPCAbilityUnsafeUtils() {} // 0x000000018350B670-0x000000018350B680
	}

	public struct FNPCUnionAnimationAbilityCommand // TypeDefIndex: 59995
	{
		// Fields
		public ENPCUnionAnimationAbilityCommandType cmdType; // 0x00
		public FixedBytes4094 Payload; // 0x04
	
		// Nested types
		public enum ENPCUnionAnimationAbilityCommandType // TypeDefIndex: 59992
		{
			DoAnimatorStepBegin = 0,
			DoAnimatorStepEnd = 1
		}
	
		public struct DoAnimatorStepEndParams // TypeDefIndex: 59993
		{
			// Fields
			public float stepEndDegree; // 0x00
		}
	
		public struct DoAnimatorUpdateStepBeginDegreeParams // TypeDefIndex: 59994
		{
			// Fields
			public float stepBeginDegree; // 0x00
		}
	
		// Methods
		public void SetData<T>([IsReadOnly] in ref T data)
			where T : struct {}
		public T GetData<T>()
			where T : struct => default;
	}
}
