/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

// Image 127: AbilityUnsafe.Gameplay.Beyond.dll - Assembly: AbilityUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91172-91185

namespace Beyond
{
	public struct FPtrAnimNativeCurve // TypeDefIndex: 91176
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
		public struct KeyframeComparer : IComparer<Keyframe> // TypeDefIndex: 91175
		{
			// Methods
			public int Compare(Keyframe keyframe1, Keyframe keyframe2); // 0x000000018501A0C0-0x000000018501A100
		}
	
		// Constructors
		static FPtrAnimNativeCurve(); // 0x0000000186CEDEC0-0x0000000186CEE0B0
	
		// Methods
		public bool IsValid(); // 0x00000001853CC6D0-0x00000001853CC6E0
		public NativeArray<Keyframe> CreateCurve(AnimationCurve animationCurve, Unity.Collections.Allocator allocator); // 0x0000000185364D60-0x0000000185364ED0
		public NativeArray<Keyframe> CreateLine(float val, Unity.Collections.Allocator allocator); // 0x0000000186564DC0-0x0000000186564EF0
		public float Evaluate(float time); // 0x000000018783E100-0x000000018783E228
		public static unsafe int GetInsertionIndex(Keyframe* keys, int valuesLength, float time); // 0x000000018783E524-0x000000018783E588
		public float WrapTime(float time); // 0x000000018783EB28-0x000000018783EC04
		public float Evaluate(float time, ref Keyframe keyframe, ref Keyframe nextKeyframe); // 0x000000018783E228-0x000000018783E524
		public float CubicBezier([IsReadOnly] in float4 curveMatrix, float t); // 0x000000018783E064-0x000000018783E0A8
		public float CubicBezier([IsReadOnly] in float3 curveMatrix, float t); // 0x000000018783E01C-0x000000018783E064
		public float DeCasteljauBezier(int degree, float4 coords, float t); // 0x000000018783E0A8-0x000000018783E100
		public void GetTWithBisectionMethod(float time, [IsReadOnly] in float4 curveXCoords, ref float t, ref float tBottom, ref float tTop, ref float diff); // 0x000000018783E588-0x000000018783E6F0
		public void GetTWithNewtonMethod(float time, [IsReadOnly] in float4 xCoords, [IsReadOnly] in float4 curveXCoords, ref float t, ref float tBottom, ref float tTop, ref float diff); // 0x000000018783E6F0-0x000000018783E9A0
		public float UseNewtonMethod(float4 curveCoords, float coord, float t, float3 curvePrimeCoords, float4 primePrimeCoords, out float coordAtT); // 0x000000018783E9D8-0x000000018783EB28
		public void UpdateTLimits(float x, float time, float t, ref float tBottom, ref float tTop); // 0x000000018783E9A0-0x000000018783E9D8
	}

	public struct FPtrNativeCurve // TypeDefIndex: 91177
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe float* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
	
		// Methods
		public bool IsValid(); // 0x00000001853CC6D0-0x00000001853CC6E0
		public NativeArray<float> CreateCurve(AnimationCurve curve, int resolution); // 0x000000018783EC04-0x000000018783EDD8
		public float Evaluate(float t); // 0x000000018783EDD8-0x000000018783EF34
		private float _Repeat(float t, float length); // 0x000000018783DA84-0x000000018783DAD0
		private float _Pingpong(float t, float length); // 0x000000018783EF34-0x000000018783EF68
	}
}

namespace Beyond.Gameplay.AbilityUnsafe
{
	public enum ENPCAbilityPathFollowStateType // TypeDefIndex: 91183
	{
		Idle = 0,
		Move = 1,
		MoveStop = 2
	}

	public struct FNPCAbilityPathFollowFragment // TypeDefIndex: 91185
	{
		// Fields
		public const int TOTAL_POINT_CAPACITY = 32; // Metadata: 0x0264B4A2
		public const int ELEMENT_PER_POINT = 7; // Metadata: 0x0264B4A3
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
		public int pointCount { get; } // 0x0000000187232740-0x0000000187232750 
		public Vector3 aim { get; } // 0x0000000187836988-0x00000001878369B8 
		public int aimStyle { get; } // 0x000000018783697C-0x0000000187836988 
		public int aimExtInfo { get; } // 0x000000018783E010-0x000000018783E01C 
		public float aimDesiredSpeed { get; } // 0x0000000187839638-0x0000000187839644 
		public Vector3 startPos { get; set; } // 0x0000000187232750-0x0000000187232770 0x0000000187232770-0x0000000187232790
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_pathPointQueue_e__FixedBuffer // TypeDefIndex: 91184
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		// Methods
		public void Init(); // 0x0000000185A72A10-0x0000000185A72A40
		public void MarkPathFollowEnd(); // 0x0000000187232710-0x0000000187232740
		public void MarkMoveStop(float time); // 0x00000001872326E0-0x0000000187232710
		public void SetPathIsLoop(bool bIsLoop); // 0x000000018783DF2C-0x000000018783DF58
		public bool GetPathIsLoop(); // 0x0000000185572D90-0x0000000185572DA0
		public bool PushPoint(Vector3 point, int styleEnum, int extPointInfo, float desiredSpeed, bool patrolActionPoint); // 0x0000000185A72A90-0x0000000185A72BE0
		public bool PopPathPoint(); // 0x000000018783DD0C-0x000000018783DE28
		private bool _RefreshScope(); // 0x000000018783DFF0-0x000000018783E010
		public void CalGroundSlope(Vector3 curPos, Vector3 steeringPos, float speed, float smoothTime); // 0x000000018783DAD0-0x000000018783DBF4
		public static float SlopeAngleDeg(Vector3 pos, Vector3 aim); // 0x000000018783DF58-0x000000018783DFF0
		public bool ReplaceLastPoint(Vector3 point, int styleEnum, int extPointInfo, float desiredSpeed); // 0x000000018783DE28-0x000000018783DEFC
		public void ClearAllPathPoints(); // 0x00000001872326C0-0x00000001872326E0
		public Vector3 GetPathPoint(int idx); // 0x0000000185573120-0x0000000185573180
		public int GetPathPointStyle(int idx); // 0x0000000185571080-0x0000000185571110
		public int GetPathPointExtInfo(int idx); // 0x000000018783DC54-0x000000018783DC84
		public float GetPathPointDesiredSpeed(int idx); // 0x0000000186A37060-0x0000000186A370A0
		public void SetAimPointDesiredSpeed(float speed); // 0x000000018783DEFC-0x000000018783DF2C
		public bool IsSubActionPoint(int idx); // 0x000000018783DCD4-0x000000018783DD0C
		public bool IsPathFull(); // 0x000000018783DCC8-0x000000018783DCD4
		public int GetPointCount(); // 0x0000000185572D70-0x0000000185572D90
		public float GetPathLength(Vector3 currentLocation); // 0x0000000185572EE0-0x0000000185573120
		public int GetEffectPointCount(); // 0x000000018783DC40-0x000000018783DC54
		public static int FloatToInt32Bits(float v); // 0x000000018783DBF4-0x000000018783DC40
		public static float Int32BitsToFloat(int v); // 0x000000018783DC84-0x000000018783DCC8
	}
}

namespace Beyond.NPC.Ability
{
	public class NPCAbilityUnsafeUtils // TypeDefIndex: 91178
	{
		// Constructors
		public NPCAbilityUnsafeUtils(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct FNPCUnionAnimationAbilityCommand // TypeDefIndex: 91182
	{
		// Fields
		public ENPCUnionAnimationAbilityCommandType cmdType; // 0x00
		public FixedBytes4094 Payload; // 0x04
	
		// Nested types
		public enum ENPCUnionAnimationAbilityCommandType // TypeDefIndex: 91179
		{
			DoAnimatorStepBegin = 0,
			DoAnimatorStepEnd = 1
		}
	
		public struct DoAnimatorStepEndParams // TypeDefIndex: 91180
		{
			// Fields
			public float stepEndDegree; // 0x00
		}
	
		public struct DoAnimatorUpdateStepBeginDegreeParams // TypeDefIndex: 91181
		{
			// Fields
			public float stepBeginDegree; // 0x00
		}
	
		// Methods
		public void SetData<T>([IsReadOnly] in ref T data)
			where T : struct;
		public T GetData<T>()
			where T : struct;
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 91173
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 91174
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
