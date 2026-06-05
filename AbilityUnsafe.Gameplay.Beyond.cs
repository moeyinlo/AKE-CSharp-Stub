/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

// Image 125: AbilityUnsafe.Gameplay.Beyond.dll - Assembly: AbilityUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61090-61103

namespace Beyond
{
	public struct FPtrAnimNativeCurve // TypeDefIndex: 61094
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
		public struct KeyframeComparer : IComparer<Keyframe> // TypeDefIndex: 61093
		{
			// Methods
			public int Compare(Keyframe keyframe1, Keyframe keyframe2) => default; // 0x0000000186476414-0x000000018647641C
		}
	
		// Constructors
		static FPtrAnimNativeCurve() {
			s_keyframeComparer = default;
			CURVE_MATRIX = default;
			CURVE_MATRIX_PRIME = default;
		} // 0x00000001841A2F80-0x00000001841A2FC0
	
		// Methods
		public bool IsValid() => default; // 0x000000018487B240-0x000000018487B460
		public NativeArray<Keyframe> CreateCurve(AnimationCurve animationCurve, Unity.Collections.Allocator allocator) => default; // 0x000000018487AA40-0x000000018487AB70
		public NativeArray<Keyframe> CreateLine(float val, Unity.Collections.Allocator allocator) => default; // 0x0000000186475B90-0x0000000186475CB4
		public float Evaluate(float time) => default; // 0x0000000186475FA4-0x0000000186476008
		public static unsafe int GetInsertionIndex(Keyframe* keys, int valuesLength, float time) => default; // 0x00000001864765A0-0x000000018647667C
		public float WrapTime(float time) => default; // 0x0000000186475CB4-0x0000000186475FA4
		public float Evaluate(float time, ref Keyframe keyframe, ref Keyframe nextKeyframe) => default; // 0x0000000186475AF4-0x0000000186475B38
		public float CubicBezier(in float4 curveMatrix, float t) => default; // 0x0000000186475AAC-0x0000000186475AF4
		public float CubicBezier(in float3 curveMatrix, float t) => default; // 0x0000000186475B38-0x0000000186475B90
		public float DeCasteljauBezier(int degree, float4 coords, float t) => default; // 0x0000000186476008-0x0000000186476170
		public void GetTWithBisectionMethod(float time, in float4 curveXCoords, ref float t, ref float tBottom, ref float tTop, ref float diff) {} // 0x0000000186476170-0x0000000186476414
		public void GetTWithNewtonMethod(float time, in float4 xCoords, in float4 curveXCoords, ref float t, ref float tBottom, ref float tTop, ref float diff) {} // 0x0000000186476454-0x00000001864765A0
		public float UseNewtonMethod(float4 curveCoords, float coord, float t, float3 curvePrimeCoords, float4 primePrimeCoords, out float coordAtT) {
			coordAtT = default;
			return default;
		} // 0x000000018647641C-0x0000000186476454
		public void UpdateTLimits(float x, float time, float t, ref float tBottom, ref float tTop) {} // 0x0000000185A30A70-0x0000000185A30C60
	}

	public struct FPtrNativeCurve // TypeDefIndex: 61095
	{
		// Fields
		private unsafe float* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
	
		// Methods
		public bool IsValid() => default; // 0x0000000186476414-0x000000018647641C
		public NativeArray<float> CreateCurve(AnimationCurve curve, int resolution) => default; // 0x000000018647667C-0x0000000186476850
		public float Evaluate(float t) => default; // 0x0000000186476850-0x00000001864769A0
		private float _Repeat(float t, float length) => default; // 0x0000000186475518-0x0000000186475564
		private float _Pingpong(float t, float length) => default; // 0x00000001864769A0-0x00000001864769D4
	}
}

namespace Beyond.Gameplay.AbilityUnsafe
{
	public enum ENPCAbilityPathFollowStateType // TypeDefIndex: 61101
	{
		Idle = 0,
		Move = 1,
		MoveStop = 2
	}

	public struct FNPCAbilityPathFollowFragment // TypeDefIndex: 61103
	{
		// Fields
		public const int TOTAL_POINT_CAPACITY = 32; // Metadata: 0x02082E9E
		public const int ELEMENT_PER_POINT = 7; // Metadata: 0x02082E9F
		private _m_pathPointQueue_e__FixedBuffer m_pathPointQueue; // 0x00
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
		public int pointCount { get => default; } // 0x0000000185FAFDD0-0x0000000185FAFDE0 
		public Vector3 aim { get => default; } // 0x0000000186471A00-0x0000000186471A30 
		public int aimStyle { get => default; } // 0x0000000186471A30-0x0000000186471A68 
		public int aimExtInfo { get => default; } // 0x0000000186475AA0-0x0000000186475AAC 
		public float aimDesiredSpeed { get => default; } // 0x00000001864719F4-0x0000000186471A00 
		public Vector3 startPos { get => default; set {} } // 0x0000000185FAFDE0-0x0000000185FAFE00 0x0000000185FAFE00-0x0000000185FAFE20
	
		// Nested types
		public struct _m_pathPointQueue_e__FixedBuffer // TypeDefIndex: 61102
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		// Methods
		public void Init() {} // 0x0000000184AB2BB0-0x0000000184AB2BE0
		public void MarkPathFollowEnd() {} // 0x0000000185FAFDA0-0x0000000185FAFDD0
		public void MarkMoveStop(float time) {} // 0x0000000185FAFD70-0x0000000185FAFDA0
		public void SetPathIsLoop(bool bIsLoop) {} // 0x00000001864759BC-0x00000001864759E8
		public bool GetPathIsLoop() => default; // 0x0000000184AB57F0-0x0000000184AB5800
		public bool PushPoint(Vector3 point, int styleEnum, int extPointInfo, float desiredSpeed, bool patrolActionPoint) => default; // 0x0000000184AB30D0-0x0000000184AB3220
		public bool PopPathPoint() => default; // 0x00000001864757A0-0x00000001864758BC
		private bool _RefreshScope() => default; // 0x0000000186475A80-0x0000000186475AA0
		public void CalGroundSlope(Vector3 curPos, Vector3 steeringPos, float speed, float smoothTime) {} // 0x0000000186475564-0x0000000186475688
		public static float SlopeAngleDeg(Vector3 pos, Vector3 aim) => default; // 0x00000001864759E8-0x0000000186475A80
		public bool ReplaceLastPoint(Vector3 point, int styleEnum, int extPointInfo, float desiredSpeed) => default; // 0x00000001864758BC-0x000000018647598C
		public void ClearAllPathPoints() {} // 0x0000000185FAFD50-0x0000000185FAFD70
		public Vector3 GetPathPoint(int idx) => default; // 0x0000000184AB4F00-0x0000000184AB4F60
		public int GetPathPointStyle(int idx) => default; // 0x0000000184AB4CE0-0x0000000184AB4D70
		public int GetPathPointExtInfo(int idx) => default; // 0x00000001864756E8-0x0000000186475718
		public float GetPathPointDesiredSpeed(int idx) => default; // 0x00000001858D9630-0x00000001858D9670
		public void SetAimPointDesiredSpeed(float speed) {} // 0x000000018647598C-0x00000001864759BC
		public bool IsSubActionPoint(int idx) => default; // 0x0000000186475768-0x00000001864757A0
		public bool IsPathFull() => default; // 0x000000018647575C-0x0000000186475768
		public int GetPointCount() => default; // 0x0000000184AB57D0-0x0000000184AB57F0
		public float GetPathLength(Vector3 currentLocation) => default; // 0x0000000184AB4D70-0x0000000184AB4F00
		public int GetEffectPointCount() => default; // 0x00000001864756D4-0x00000001864756E8
		public static int FloatToInt32Bits(float v) => default; // 0x0000000186475688-0x00000001864756D4
		public static float Int32BitsToFloat(int v) => default; // 0x0000000186475718-0x000000018647575C
	}
}

namespace Beyond.NPC.Ability
{
	public class NPCAbilityUnsafeUtils // TypeDefIndex: 61096
	{
		// Constructors
		public NPCAbilityUnsafeUtils() {} // 0x0000000185492010-0x0000000185492020
	}

	public struct FNPCUnionAnimationAbilityCommand // TypeDefIndex: 61100
	{
		// Fields
		public ENPCUnionAnimationAbilityCommandType cmdType; // 0x00
		public FixedBytes4094 Payload; // 0x04
	
		// Nested types
		public enum ENPCUnionAnimationAbilityCommandType // TypeDefIndex: 61097
		{
			DoAnimatorStepBegin = 0,
			DoAnimatorStepEnd = 1
		}
	
		public struct DoAnimatorStepEndParams // TypeDefIndex: 61098
		{
			// Fields
			public float stepEndDegree; // 0x00
		}
	
		public struct DoAnimatorUpdateStepBeginDegreeParams // TypeDefIndex: 61099
		{
			// Fields
			public float stepBeginDegree; // 0x00
		}
	
		// Methods
		public void SetData<T>(in ref T data)
			where T : struct {}
		public T GetData<T>()
			where T : struct => default;
	}
}

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 61091
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 61092
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
