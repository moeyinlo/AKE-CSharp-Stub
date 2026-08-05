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

// Image 127: AbilityUnsafe.Gameplay.Beyond.dll - Assembly: AbilityUnsafe.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63726-63739
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond
{
	public struct FPtrAnimNativeCurve // TypeDefIndex: 63730
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
		public struct KeyframeComparer : IComparer<Keyframe> // TypeDefIndex: 63729
		{
			// Methods
			public int Compare(Keyframe keyframe1, Keyframe keyframe2); // 0x000000018389FD40-0x000000018389FD80
		}
	
		// Constructors
		static FPtrAnimNativeCurve(); // 0x000000018327F8A0-0x000000018327FA90
	
		// Methods
		public bool IsValid(); // 0x000000018423A5F0-0x000000018423A600
		public NativeArray<Keyframe> CreateCurve(AnimationCurve animationCurve, Unity.Collections.Allocator allocator); // 0x0000000183B05230-0x0000000183B053A0
		public NativeArray<Keyframe> CreateLine(float val, Unity.Collections.Allocator allocator); // 0x000000018419F010-0x000000018419F140
		public float Evaluate(float time); // 0x0000000185398984-0x0000000185398AA8
		public static unsafe int GetInsertionIndex(Keyframe* keys, int valuesLength, float time); // 0x0000000185398D98-0x0000000185398DFC
		public float WrapTime(float time); // 0x000000018539938C-0x0000000185399468
		public float Evaluate(float time, ref Keyframe keyframe, ref Keyframe nextKeyframe); // 0x0000000185398AA8-0x0000000185398D98
		public float CubicBezier([IsReadOnly] in float4 curveMatrix, float t); // 0x00000001853988E8-0x000000018539892C
		public float CubicBezier([IsReadOnly] in float3 curveMatrix, float t); // 0x00000001853988A0-0x00000001853988E8
		public float DeCasteljauBezier(int degree, float4 coords, float t); // 0x000000018539892C-0x0000000185398984
		public void GetTWithBisectionMethod(float time, [IsReadOnly] in float4 curveXCoords, ref float t, ref float tBottom, ref float tTop, ref float diff); // 0x0000000185398DFC-0x0000000185398F64
		public void GetTWithNewtonMethod(float time, [IsReadOnly] in float4 xCoords, [IsReadOnly] in float4 curveXCoords, ref float t, ref float tBottom, ref float tTop, ref float diff); // 0x0000000185398F64-0x0000000185399208
		public float UseNewtonMethod(float4 curveCoords, float coord, float t, float3 curvePrimeCoords, float4 primePrimeCoords, out float coordAtT); // 0x0000000185399240-0x000000018539938C
		public void UpdateTLimits(float x, float time, float t, ref float tBottom, ref float tTop); // 0x0000000185399208-0x0000000185399240
	}

	public struct FPtrNativeCurve // TypeDefIndex: 63731
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private unsafe float* m_values; // 0x00
		private int m_valuesLength; // 0x08
		private UnityEngine.WrapMode m_preWrapMode; // 0x0C
		private UnityEngine.WrapMode m_postWrapMode; // 0x10
	
		// Methods
		public bool IsValid(); // 0x000000018423A5F0-0x000000018423A600
		public NativeArray<float> CreateCurve(AnimationCurve curve, int resolution); // 0x0000000185399468-0x000000018539963C
		public float Evaluate(float t); // 0x000000018539963C-0x000000018539978C
		private float _Repeat(float t, float length); // 0x0000000185398300-0x000000018539834C
		private float _Pingpong(float t, float length); // 0x000000018539978C-0x00000001853997C0
	}
}

namespace Beyond.Gameplay.AbilityUnsafe
{
	public enum ENPCAbilityPathFollowStateType // TypeDefIndex: 63737
	{
		Idle = 0,
		Move = 1,
		MoveStop = 2
	}

	public struct FNPCAbilityPathFollowFragment // TypeDefIndex: 63739
	{
		// Fields
		public const int TOTAL_POINT_CAPACITY = 32; // Metadata: 0x02352B1E
		public const int ELEMENT_PER_POINT = 7; // Metadata: 0x02352B1F
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
		public int pointCount { get; } // 0x0000000184D859F0-0x0000000184D85A00 
		public Vector3 aim { get; } // 0x0000000185393E6C-0x0000000185393E9C 
		public int aimStyle { get; } // 0x0000000185393E60-0x0000000185393E6C 
		public int aimExtInfo { get; } // 0x0000000185398894-0x00000001853988A0 
		public float aimDesiredSpeed { get; } // 0x0000000185398888-0x0000000185398894 
		public Vector3 startPos { get; set; } // 0x0000000184D85A00-0x0000000184D85A20 0x0000000184D85A20-0x0000000184D85A40
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_pathPointQueue_e__FixedBuffer // TypeDefIndex: 63738
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		// Methods
		public void Init(); // 0x00000001846AB460-0x00000001846AB490
		public void MarkPathFollowEnd(); // 0x0000000184D859C0-0x0000000184D859F0
		public void MarkMoveStop(float time); // 0x0000000184D85990-0x0000000184D859C0
		public void SetPathIsLoop(bool bIsLoop); // 0x00000001853987A4-0x00000001853987D0
		public bool GetPathIsLoop(); // 0x00000001838D73D0-0x00000001838D73E0
		public bool PushPoint(Vector3 point, int styleEnum, int extPointInfo, float desiredSpeed, bool patrolActionPoint); // 0x00000001838D97D0-0x00000001838D9920
		public bool PopPathPoint(); // 0x0000000185398588-0x00000001853986A4
		private bool _RefreshScope(); // 0x0000000185398868-0x0000000185398888
		public void CalGroundSlope(Vector3 curPos, Vector3 steeringPos, float speed, float smoothTime); // 0x000000018539834C-0x0000000185398470
		public static float SlopeAngleDeg(Vector3 pos, Vector3 aim); // 0x00000001853987D0-0x0000000185398868
		public bool ReplaceLastPoint(Vector3 point, int styleEnum, int extPointInfo, float desiredSpeed); // 0x00000001853986A4-0x0000000185398774
		public void ClearAllPathPoints(); // 0x0000000184D85970-0x0000000184D85990
		public Vector3 GetPathPoint(int idx); // 0x00000001838D7570-0x00000001838D75D0
		public int GetPathPointStyle(int idx); // 0x00000001838D4F40-0x00000001838D4FD0
		public int GetPathPointExtInfo(int idx); // 0x00000001853984D0-0x0000000185398500
		public float GetPathPointDesiredSpeed(int idx); // 0x000000018468ABE0-0x000000018468AC20
		public void SetAimPointDesiredSpeed(float speed); // 0x0000000185398774-0x00000001853987A4
		public bool IsSubActionPoint(int idx); // 0x0000000185398550-0x0000000185398588
		public bool IsPathFull(); // 0x0000000185398544-0x0000000185398550
		public int GetPointCount(); // 0x00000001838D73B0-0x00000001838D73D0
		public float GetPathLength(Vector3 currentLocation); // 0x00000001838D73E0-0x00000001838D7570
		public int GetEffectPointCount(); // 0x00000001853984BC-0x00000001853984D0
		public static int FloatToInt32Bits(float v); // 0x0000000185398470-0x00000001853984BC
		public static float Int32BitsToFloat(int v); // 0x0000000185398500-0x0000000185398544
	}
}

namespace Beyond.NPC.Ability
{
	public class NPCAbilityUnsafeUtils // TypeDefIndex: 63732
	{
		// Constructors
		public NPCAbilityUnsafeUtils(); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct FNPCUnionAnimationAbilityCommand // TypeDefIndex: 63736
	{
		// Fields
		public ENPCUnionAnimationAbilityCommandType cmdType; // 0x00
		public FixedBytes4094 Payload; // 0x04
	
		// Nested types
		public enum ENPCUnionAnimationAbilityCommandType // TypeDefIndex: 63733
		{
			DoAnimatorStepBegin = 0,
			DoAnimatorStepEnd = 1
		}
	
		public struct DoAnimatorStepEndParams // TypeDefIndex: 63734
		{
			// Fields
			public float stepEndDegree; // 0x00
		}
	
		public struct DoAnimatorUpdateStepBeginDegreeParams // TypeDefIndex: 63735
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
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 63727
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 63728
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
