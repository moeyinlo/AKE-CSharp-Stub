/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BeyondDynamicBone;
using IFix.Core;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.LowLevel;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

// Image 12: BeyondDynamicBone.dll - Assembly: BeyondDynamicBone, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 47993-48632
[assembly: AlwaysLinkAssembly]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateWithVelocityJob2Kernels.AggregateWithVelocityJob2RangeKernel_00000581_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AngleConstraintJobKernels.AngleConstraintKernel_000000C4_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(AngleConstraintJobKernels.AngleConstraintRangeKernel_000000C5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderCollisionConstraint.PointColliderCollisionConstraintJobKernels.PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderCollisionConstraint.PointColliderCollisionConstraintJobKernels.PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderCollisionConstraint.EdgeColliderCollisionConstraintJobKernels.EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderCollisionConstraint.EdgeColliderCollisionConstraintJobKernels.EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderCollisionConstraint.SolveEdgeBufferAndClearJobKernels.SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderCollisionConstraint.SolveEdgeBufferAndClearJobKernels.SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(DistanceConstraintJobKernels.DistanceConstraintKernel_00000101_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(DistanceConstraintJobKernels.DistanceConstraintRangeKernel_00000102_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(MotionConstraintJobKernels.MotionConstraintKernel_00000121_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(MotionConstraintJobKernels.MotionConstraintRangeKernel_00000122_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.IntersectUpdatePrimitiveJobKernels.IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.IntersectUpdatePrimitiveJobKernels.IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.UpdatePrimitiveJobKernels.UpdatePrimitiveKernel_00000147_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.UpdatePrimitiveJobKernels.UpdatePrimitiveRangeKernel_00000148_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.ClearBufferJobKernels.ClearBufferKernel_00000149_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.SortJobKernels.SortKernel_0000014A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.SortJobKernels.SortRangeKernel_0000014B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.SolverPointTriangleCrossFrameJobKernels.SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.SolverPointTriangleCrossFrameJobKernels.SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJobKernels.SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJobKernels.SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TethreConstraintJobKernels.TethreConstraintKernel_00000193_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TethreConstraintJobKernels.TethreConstraintRangeKernel_00000194_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TriangleBendingConstraint.TriangleBendingJobKernels.TriangleBendingKernel_000001AA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TriangleBendingConstraint.TriangleBendingJobKernels.TriangleBendingRangeKernel_000001AB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TriangleBendingConstraint.SolveAggregateBufferJobKernels.SolveAggregateBufferKernel_000001AE_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TriangleBendingConstraint.SolveAggregateBufferJobKernels.SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(DynamicBoneTransformManager.WriteAnimatorBufferDataJobKernels.WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(DynamicBoneTransformManager.WriteAnimatorBufferDataJobKernels.WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(DynamicBoneTransformManager.ValidTransformKernels.ValidateTransformKernel_00000266_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(DynamicBoneTransformManager.ValidTransformKernels.ValidateTransformRangeKernel_00000267_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.SimulationStepTeamUpdateKernels.SimulationStepTeamUpdateKernel_00000296_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.SimulationStepTeamUpdateKernels.SimulationStepTeamUpdateRangeKernel_00000297_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.SimulationStepTeamUpdateKernels.UpdateWind_00000298_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.SimulationStepTeamUpdateKernels.UpdateWindTime_00000299_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.PostTeamUpdateJobKernels.PostTeamUpdateKernel_0000029A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.PostTeamUpdateJobKernels.PostTeamUpdateRangeKernel_0000029B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.CalcCenterAndInertiaAndWindKernels.CalcCenterAndInertiaAndWindKernel_000002BB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.CalcCenterAndInertiaAndWindKernels.CalcCenterAndInertiaAndWindRangeKernel_000002BC_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.CalcCenterAndInertiaAndWindKernels.Wind_000002BD_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcProxyMeshSkinningKernels.CalcProxyMeshSkinningKernel_000002E6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcProxyMeshSkinningKernels.CalcProxyMeshSkinningRangeKernel_000002E7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CreatePostProxyMeshUpdateListJobKernels.CreatePostProxyMeshUpdateListKernel_000002E8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CreatePostProxyMeshUpdateListJobKernels.CreatePostProxyMeshUpdateListRangeKernel_000002E9_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcLineNormalTangentJobKernels.CalcLineNormalTangentKernel_000002EA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcLineNormalTangentJobKernels.CalcLineNormalTangentRangeKernel_000002EB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.WriteTransformDataJobKernels.WriteTransformDataKernel_000002EC_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.WriteTransformLocalDataJobKernels.WriteTransformLocalDataKernel_000002EE_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.WriteTransformLocalDataJobKernels.WriteTransformLocalDataRangeKernel_000002EF_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcProxySkinningJobKernels.CalcProxySkinningKernel_000002F0_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcProxySkinningJobKernels.CalcProxySkinningRangeKernel_000002F1_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcMeshConvertMatrixJobKernels.CalcMeshConvertMatrixKernel_000002F2_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcMeshConvertMatrixJobKernels.CalcMeshConvertMatrixRangeKernel_000002F3_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcTriangleNormalTangentJobKernels.CalcTriangleNormalTangentKernel_000002F4_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcTriangleNormalTangentJobKernels.CalcTriangleNormalTangentRangeKernel_000002F5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcVertexNormalTangentFromTriangleJobKernels.CalcVertexNormalTangentFromTriangleKernel_000002F6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcVertexNormalTangentFromTriangleJobKernels.CalcVertexNormalTangentFromTriangleRangeKernel_000002F7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.WriteTransformDataJobKernels.WriteTransformDataRangeKernel_000002ED_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.ClearProxyMeshUpdateBufferJobKernels.ClearProxyMeshUpdateBufferKernel_000002F8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdatePositionNormalTangentJobKernels.UpdatePositionNormalTangentKernel_0000035D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdatePositionNormalTangentJobKernels.UpdatePositionNormalTangentRangeKernel_0000035E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdateBoneWeightJob2Kernels.UpdateBoneWeight2Kernel_0000035F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdateBoneWeightJob2Kernels.UpdateBoneWeight2RangeKernel_00000360_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(BeyondDynamicBone.EndSimulationStepJobKernels.EndSimulationStepKernel_000003BA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(BeyondDynamicBone.EndSimulationStepJobKernels.EndSimulationStepRangeKernel_000003BB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.ColliderKernels.PreSimulationUpdateKernel_000003D3_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.ColliderKernels.PreSimulationUpdateRangeKernel_000003D4_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.CreateUpdatecolliderListJobKernels.CreateUpdatecolliderListKernel_000003D5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.CreateUpdatecolliderListJobKernels.CreateUpdatecolliderListRangeKernel_000003D6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdatePositionNormalJobKernels.UpdatePositionNormalRangeKernel_0000035C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.StartSimulationStepJobKernels.StartSimulationStepKernel_000003D7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.StartSimulationStepJobKernels.StartSimulationStepRangeKernel_000003D8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.EndSimulationStepJobKernels.EndSimulationStepKernel_0000040E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.CreateUpdateParticleListKernels.CreateUpdateParticleListKernel_00000403_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.CreateUpdateParticleListKernels.CreateUpdateParticleListRangeKernel_00000404_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.PreSimulationUpdateJobKernels.PreSimulationUpdateKernel_00000405_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.PreSimulationUpdateJobKernels.PreSimulationUpdateRangeKernel_00000406_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.StartSimulationStepKernel_00000407_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.StartSimulationStepRangeKernel_00000408_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.Spring_00000409_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.Wind_0000040A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.WindForceBlend_0000040B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.UpdateStepBasicPotureJobKernels.UpdateStepBasicPotureKernel_0000040C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.UpdateStepBasicPotureJobKernels.UpdateStepBasicPotureRangeKernel_0000040D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.PostSimulationUpdateJobKernels.PostSimulationUpdateKernel_000003D9_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdatePositionNormalJobKernels.UpdatePositionNormalKernel_0000035B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.CalcDisplayPositionJobKernels.CalcDisplayPositionKernel_00000410_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.CalcDisplayPositionJobKernels.CalcDisplayPositionRangeKernel_00000411_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.ClearStepCounterKernels.ClearStepCounterKernel_00000412_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateJobKernels.AggregateKernel_0000057A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateJobKernels.AggregateRangeKernel_0000057B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateWithVelocityJobKernels.AggregateWithVelocityKernel_0000057C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateWithVelocityJobKernels.AggregateWithVelocityRangeKernel_0000057D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateJob2Kernels.AggregateJob2Kernel_0000057E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateJob2Kernels.AggregateJob2RangeKernel_0000057F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateWithVelocityJob2Kernels.AggregateWithVelocityJob2Kernel_00000580_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.PostSimulationUpdateJobKernels.PostSimulationUpdateRangeKernel_000003DA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.EndSimulationStepJobKernels.EndSimulationStepRangeKernel_0000040F_BurstDirectCall))]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2841310694 // TypeDefIndex: 48627
{
	// Methods
	public static void CreateJobReflectionData(); // 0x00000001811F6EB0-0x00000001811FF760
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit(); // 0x00000001811FF760-0x00000001812005A0
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 48628
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x00000001844F5D60-0x00000001844F63F0
}

namespace BeyondDynamicBone
{
	public class BeyondBoneCloth : ClothBehaviour, IValid // TypeDefIndex: 47996
	{
		// Fields
		[HideInInspector]
		public int clothAnimatorAbilityLODThresholdProperty; // 0x20
		private int _clothAnimatorAbilityLODThresholdProperty; // 0x24
		[HideInInspector]
		public int clothAnimatorLODThresholdProperty; // 0x28
		private int _clothAnimatorLODThresholdProperty; // 0x2C
		[HideInInspector]
		public float clothLODFadeTimeProperty; // 0x30
		private float _clothLODFadeTimeProperty; // 0x34
		[HideInInspector]
		public float animationPoseRatioProperty; // 0x38
		private float _animationPoseRatioProperty; // 0x3C
		[HideInInspector]
		public float clothSimulateWeightProperty; // 0x40
		private float _clothSimulateWeightProperty; // 0x44
		[HideInInspector]
		public float gravityProperty; // 0x48
		private float _gravityProperty; // 0x4C
		[HideInInspector]
		public float dampingProperty; // 0x50
		private float _dampingProperty; // 0x54
		[HideInInspector]
		public float worldInertiaProperty; // 0x58
		private float _worldInertiaProperty; // 0x5C
		[HideInInspector]
		public float localInertiaProperty; // 0x60
		private float _localInertiaProperty; // 0x64
		[HideInInspector]
		public float windInfluenceProperty; // 0x68
		private float _windInfluenceProperty; // 0x6C
		[HideInInspector]
		public float blendWeightProperty; // 0x70
		private float _blendWeightProperty; // 0x74
		[CompilerGenerated]
		private bool _bUseRelativeTransform_k__BackingField; // 0x78
		public float3 relativeTransformPos; // 0x7C
		public quaternion relativeTransformRot; // 0x88
		[SerializeField]
		private ClothSerializeData serializeData; // 0x98
		[SerializeField]
		internal ClothSerializeData2 serializeData2; // 0xA0
		private ClothProcess process; // 0xA8
		[JsonIgnore]
		public Action<bool> OnBuildComplete; // 0xB0
	
		// Properties
		public bool bUseRelativeTransform { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86F90-0x0000000184D86FA0 0x0000000184D86FA0-0x0000000184D86FB0
		public ClothSerializeData SerializeData { get; set; } // 0x0000000182F956A0-0x0000000182F95730 0x000000018668D244-0x000000018668D2A8
		public ClothProcess Process { get; } // 0x0000000182F95730-0x0000000182F95870 
		public Transform ClothTransform { get; } // 0x000000018308CD30-0x000000018308CD70 
		public BeyondBoneCloth SyncPartnerCloth { get; } // 0x000000018308D0E0-0x000000018308D1C0 
	
		// Constructors
		public BeyondBoneCloth(); // 0x00000001840FAB20-0x00000001840FAC40
	
		// Methods
		internal void InitAnimationProperty(); // 0x00000001843D6C30-0x00000001843D6DA0
		private void OnDidApplyAnimationProperties(); // 0x000000018668C4EC-0x000000018668C7CC
		public void SetRelativeTransform(bool useRelativeTransform, float3 newPos, quaternion newRot); // 0x000000018668CE7C-0x000000018668D0E8
		public bool IsValid(); // 0x000000018418E2A0-0x000000018418E330
		private void Reset(); // 0x000000018668CC90-0x000000018668CCD0
		private void OnValidate(); // 0x000000018668C7CC-0x000000018668C82C
		private void Awake(); // 0x000000018464E550-0x000000018464E5D0
		private void OnEnable(); // 0x00000001837EBF40-0x00000001837EBF90
		private void OnDisable(); // 0x00000001837EBE80-0x00000001837EBED0
		private void Start(); // 0x0000000183E8BAB0-0x0000000183E8BBB0
		private void OnDestroy(); // 0x0000000183E92E10-0x0000000183E92E60
		public override int GetMagicaHashCode(); // 0x000000018668C374-0x000000018668C42C
		public ClothSerializeData2 GetSerializeData2(); // 0x000000018308D0B0-0x000000018308D0E0
		public void Initialize(); // 0x0000000183DD03A0-0x0000000183DD0400
		public void DisableAutoBuild(); // 0x000000018668C1A8-0x000000018668C220
		public void SetClothSimulateWeight(float weight); // 0x0000000183416660-0x0000000183416760
		public void SetClothSimulateWeightIgnorePlaying(float weight); // 0x0000000183434870-0x0000000183434930
		public void SetClothStablizationTimeAfterResetIgnorePlaying(float time); // 0x000000018668CDA4-0x000000018668CE10
		public void SetAnimationPoseRatio(float ratio); // 0x000000018668CCD0-0x000000018668CDA4
		private void SetCodeParamaterDirty(); // 0x0000000183416760-0x0000000183416AE0
		private void SetCodeParamaterDirtyIgnorePlaying(); // 0x00000001834347A0-0x0000000183434870
		public bool BuildAndRun(); // 0x000000018668BC70-0x000000018668C1A8
		public void ReplaceTransform(Dictionary<string, Transform> targetTransformDict); // 0x000000018668C82C-0x000000018668CB48
		public void SetParameterChange(); // 0x000000018668CE10-0x000000018668CE7C
		public void SetTimeScale(float timeScale); // 0x000000018668D168-0x000000018668D23C
		public float GetTimeScale(); // 0x000000018668C42C-0x000000018668C4EC
		public void ResetCloth(bool keepPose = false /* Metadata: 0x0232CD2C */); // 0x000000018668CB48-0x000000018668CC90
		public void SoftResetCloth(bool keepPose = false /* Metadata: 0x0232CD2D */); // 0x000000018418E230-0x000000018418E2A0
		public Vector3 GetCenterPosition(); // 0x000000018668C220-0x000000018668C374
		public void AddForce(Vector3 forceDirection, float forceVelocity, ClothForceMode fmode = ClothForceMode.VelocityAdd /* Metadata: 0x0232CD2E */); // 0x000000018668BAD0-0x000000018668BC70
		public void SetSkipWriting(bool sw); // 0x000000018668D0E8-0x000000018668D168
		public int __iFixBaseProxy_GetMagicaHashCode(); // 0x000000018668D23C-0x000000018668D244
	}

	[Serializable]
	public class CheckSliderSerializeData // TypeDefIndex: 47997
	{
		// Fields
		public float value; // 0x10
		public bool use; // 0x14
	
		// Constructors
		public CheckSliderSerializeData(); // 0x00000001841E1670-0x00000001841E1680
		public CheckSliderSerializeData(bool use, float value); // 0x0000000184D86FB0-0x0000000184D86FC0
	
		// Methods
		public float GetValue(float unusedValue); // 0x000000018308C1F0-0x000000018308C240
		public void SetValue(bool use, float value); // 0x000000018668D4D0-0x000000018668D544
		public void DataValidate(float min, float max); // 0x000000018668D44C-0x000000018668D4D0
		public CheckSliderSerializeData Clone(); // 0x000000018668D3C4-0x000000018668D44C
	}

	public abstract class ClothBehaviour : MonoBehaviour // TypeDefIndex: 47998
	{
		// Fields
		[CompilerGenerated]
		private bool _IsGizmoVisible_k__BackingField; // 0x18
	
		// Properties
		public bool IsGizmoVisible { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
	
		// Constructors
		protected ClothBehaviour(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public virtual int GetMagicaHashCode(); // 0x000000018668D544-0x000000018668D590
		protected virtual void OnDrawGizmos(); // 0x000000018668D590-0x000000018668D5E0
	}

	public enum ClothForceMode // TypeDefIndex: 47999
	{
		None = 0,
		VelocityAdd = 1,
		VelocityChange = 2,
		VelocityAddWithoutDepth = 10,
		VelocityChangeWithoutDepth = 11
	}

	public enum ClothMeshWriteMode // TypeDefIndex: 48000
	{
		PositionAndNormal = 0,
		PositionAndNormalTangent = 1
	}

	public enum ClothNormalAxis // TypeDefIndex: 48001
	{
		Right = 0,
		Up = 1,
		Forward = 2,
		InverseRight = 3,
		InverseUp = 4,
		InverseForward = 5
	}

	public struct ClothParameters // TypeDefIndex: 48002
	{
		// Fields
		public float gravity; // 0x00
		public float3 worldGravityDirection; // 0x04
		public float gravityFalloff; // 0x10
		public float stablizationTimeAfterReset; // 0x14
		public float blendWeight; // 0x18
		public float4x4 dampingCurveData; // 0x1C
		public float4x4 radiusCurveData; // 0x5C
		public ClothNormalAxis normalAxis; // 0x9C
		public float rotationalInterpolation; // 0xA0
		public float rootRotation; // 0xA4
		public CullingSettings.CullingParams culling; // 0xA8
		public InertiaConstraint.InertiaConstraintParams inertiaConstraint; // 0xB4
		public TetherConstraint.TetherConstraintParams tetherConstraint; // 0xEC
		public DistanceConstraint.DistanceConstraintParams distanceConstraint; // 0xF4
		public TriangleBendingConstraint.TriangleBendingConstraintParams triangleBendingConstraint; // 0x138
		public AngleConstraint.AngleConstraintParams angleConstraint; // 0x140
		public MotionConstraint.MotionConstraintParams motionConstraint; // 0x1D4
		public ColliderCollisionConstraint.ColliderCollisionConstraintParams colliderCollisionConstraint; // 0x264
		public SelfCollisionConstraint.SelfCollisionConstraintParams selfCollisionConstraint; // 0x2B0
		public WindParams wind; // 0x2FC
		public SpringConstraint.SpringConstraintParams springConstraint; // 0x318
	}

	public class ClothProcess : IDisposable, IValid, ITransform // TypeDefIndex: 48013
	{
		// Fields
		private static readonly ProfilerMarker initProfiler; // 0x00
		private static readonly ProfilerMarker preBuildProfiler; // 0x08
		private static readonly ProfilerMarker preBuildDeserializationProfiler; // 0x10
		private static readonly ProfilerMarker preBuildRegistrationProfiler; // 0x18
		[CompilerGenerated]
		private BeyondBoneCloth _cloth_k__BackingField; // 0x10
		[CompilerGenerated]
		private BeyondBoneCloth _SyncTopCloth_k__BackingField; // 0x18
		public const int State_Valid = 0; // Metadata: 0x0232CD3C
		public const int State_Enable = 1; // Metadata: 0x0232CD3D
		public const int State_InitSuccess = 3; // Metadata: 0x0232CD3E
		public const int State_InitComplete = 4; // Metadata: 0x0232CD3F
		public const int State_Build = 5; // Metadata: 0x0232CD40
		public const int State_Running = 6; // Metadata: 0x0232CD41
		public const int State_DisableAutoBuild = 7; // Metadata: 0x0232CD42
		public const int State_CameraCullingInvisible = 8; // Metadata: 0x0232CD43
		public const int State_CameraCullingKeep = 9; // Metadata: 0x0232CD44
		public const int State_SkipWriting = 10; // Metadata: 0x0232CD45
		public const int State_UsePreBuild = 12; // Metadata: 0x0232CD46
		public const int State_DistanceCullingInvisible = 13; // Metadata: 0x0232CD47
		public const int State_UpdateTangent = 14; // Metadata: 0x0232CD48
		public const int State_Component = 15; // Metadata: 0x0232CD49
		public const int State_Verification = 16; // Metadata: 0x0232CD4A
		public const int State_LOD_Culled = 25; // Metadata: 0x0232CD4B
		internal BitField32 stateFlag; // 0x20
		[CompilerGenerated]
		private TransformRecord _clothTransformRecord_k__BackingField; // 0x28
		private List<int> renderHandleList; // 0x30
		internal RenderSetupData boneClothSetupData; // 0x38
		internal List<RenderMeshInfo> renderMeshInfoList; // 0x40
		internal List<TransformRecord> customSkinningBoneRecords; // 0x48
		[CompilerGenerated]
		private TransformRecord _normalAdjustmentTransformRecord_k__BackingField; // 0x50
		internal ResultCode result; // 0x58
		[CompilerGenerated]
		private ClothType _clothType_k__BackingField; // 0x60
		private ReductionSettings reductionSettings; // 0x68
		[CompilerGenerated]
		private ClothParameters _parameters_k__BackingField; // 0x70
		[CompilerGenerated]
		private VirtualMeshContainer _ProxyMeshContainer_k__BackingField; // 0x398
		internal List<ColliderComponent> colliderList; // 0x3A0
		[CompilerGenerated]
		private int _TeamId_k__BackingField; // 0x3A8
		internal InertiaConstraint.ConstraintData inertiaConstraintData; // 0x3B0
		internal DistanceConstraint.ConstraintData distanceConstraintData; // 0x3B8
		internal TriangleBendingConstraint.ConstraintData bendingConstraintData; // 0x3C0
		internal Animator interlockingAnimator; // 0x3C8
		internal List<Renderer> interlockingAnimatorRenderers; // 0x3D0
		internal int anchorTransformId; // 0x3D8
		internal int distanceReferenceObjectId; // 0x3DC
		internal Animator cameraCullingAnimator; // 0x3E0
		internal List<Renderer> cameraCullingRenderers; // 0x3E8
		internal CullingSettings.CameraCullingMode cameraCullingMode; // 0x3F0
		internal bool cameraCullingOldInvisible; // 0x3F4
		private CancellationTokenSource cts; // 0x3F8
		private object lockObject; // 0x400
		private bool isDestory; // 0x408
		private bool isDestoryInternal; // 0x409
		private bool isBuild; // 0x40A
	
		// Properties
		public BeyondBoneCloth cloth { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public BeyondBoneCloth SyncTopCloth { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		internal TransformRecord clothTransformRecord { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86240-0x0000000184D86250 0x0000000182FDB880-0x0000000182FDB890
		internal TransformRecord normalAdjustmentTransformRecord { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public ResultCode Result { get; } // 0x000000018668FFEC-0x000000018669003C 
		internal ClothType clothType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86790-0x0000000184D867A0 0x0000000184D86D50-0x0000000184D86D60
		public ClothParameters parameters { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86FE0-0x0000000184D87070 0x0000000184D87080-0x0000000184D87100
		public VirtualMeshContainer ProxyMeshContainer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86FC0-0x0000000184D86FD0 0x000000018669003C-0x0000000186690050
		internal int ColliderCapacity { get; } // 0x0000000183CF6AA0-0x0000000183CF6B00 
		public int TeamId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86FD0-0x0000000184D86FE0 0x0000000184D87070-0x0000000184D87080
		public bool IsEnable { get; } // 0x0000000182F94E60-0x0000000182F95120 
		public bool HasProxyMesh { get; } // 0x000000018668FE7C-0x000000018668FF3C 
		public string Name { get; } // 0x000000018668FF3C-0x000000018668FFEC 
	
		// Nested types
		[BurstCompile]
		private struct GenerateSelectionJob : IJobParallelFor // TypeDefIndex: 48003
		{
			// Fields
			public int offset; // 0x00
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> positionList; // 0x08
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<VertexAttribute> attributeList; // 0x18
			public int attributeMapWidth; // 0x28
			public float4x4 toM; // 0x2C
			public int2 xySize; // 0x6C
			public ExBitFlag8 attributeReadFlag; // 0x74
			[ReadOnly]
			public NativeArray<Color32> attributeMapData; // 0x78
			[ReadOnly]
			public NativeArray<float2> uvs; // 0x88
			[ReadOnly]
			public NativeArray<float3> vertexs; // 0x98
	
			// Methods
			public void Execute(int vindex); // 0x0000000186691B78-0x0000000186691D90
		}
	
		public class RenderMeshInfo // TypeDefIndex: 48004
		{
			// Fields
			public int renderHandle; // 0x10
			public VirtualMeshContainer renderMeshContainer; // 0x18
			public DataChunk mappingChunk; // 0x20
	
			// Constructors
			public RenderMeshInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class PaintMapData // TypeDefIndex: 48005
		{
			// Fields
			public const byte ReadFlag_Fixed = 1; // Metadata: 0x0232CD4C
			public const byte ReadFlag_Move = 2; // Metadata: 0x0232CD4D
			public const byte ReadFlag_Limit = 4; // Metadata: 0x0232CD4E
			public Color32[] paintData; // 0x10
			public int paintMapWidth; // 0x18
			public int paintMapHeight; // 0x1C
			public ExBitFlag8 paintReadFlag; // 0x20
	
			// Constructors
			public PaintMapData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public enum ClothType // TypeDefIndex: 48006
		{
			MeshCloth = 0,
			BoneCloth = 1,
			BoneSpring = 10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 48007
		{
			// Fields
			public CancellationToken ct; // 0x10
			public VirtualMesh proxyMesh; // 0x18
			public ClothProcess __4__this; // 0x20
			public List<RenderMeshInfo> renderMeshInfos; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RuntimeBuildAsync_b__1(); // 0x0000000183CFAF80-0x0000000183CFB3B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_1 // TypeDefIndex: 48008
		{
			// Fields
			public SelectionData selectionData; // 0x10
			public bool useManualVertexAttribute; // 0x18
			public ClothSerializeData2 sdata2; // 0x20
			public bool usePaintMap; // 0x28
			public List<PaintMapData> paintMapDataList; // 0x30
			public Dictionary<int, VertexAttribute> boneAttributeDict; // 0x38
			public ClothSerializeData sdata; // 0x40
			public __c__DisplayClass10_0 CS___8__locals1; // 0x48
	
			// Constructors
			public __c__DisplayClass10_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _RuntimeBuildAsync_b__0(); // 0x0000000183CFCB70-0x0000000183D00200
		}
	
		[CompilerGenerated]
		private struct _RuntimeBuildAsync_d__10 : IAsyncStateMachine // TypeDefIndex: 48009
		{
			// Fields
			public int __1__state; // 0x00
			public AsyncTaskMethodBuilder __t__builder; // 0x08
			public CancellationToken ct; // 0x20
			public ClothProcess __4__this; // 0x28
			private __c__DisplayClass10_1 __8__1; // 0x30
			private __c__DisplayClass10_0 __8__2; // 0x38
			private BeyondBoneCloth _syncCloth_5__2; // 0x40
			private TaskAwaiter __u__1; // 0x48
			private int _timeOutCount_5__3; // 0x50
	
			// Methods
			private void MoveNext(); // 0x000000018308D230-0x0000000183091150
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018459AEB0-0x000000018459AF10
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 48010
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<VirtualMeshContainer> __9__18_0; // 0x08
			public static Action<int> __9__21_0; // 0x10
	
			// Constructors
			static __c(); // 0x0000000184D3FEB0-0x0000000184D3FF10
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PreBuildDataConstruction_b__18_0(VirtualMeshContainer x); // 0x0000000186692408-0x000000018669241C
			internal void _UpdateRendererUse_b__21_0(int handle); // 0x000000018669241C-0x0000000186692488
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass126_0 // TypeDefIndex: 48011
		{
			// Fields
			public HashSet<Transform> transformSet; // 0x10
	
			// Constructors
			public __c__DisplayClass126_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetUsedTransform_b__0(int handle); // 0x0000000186692488-0x00000001866924FC
			internal void _GetUsedTransform_b__1(TransformRecord rd); // 0x00000001866924FC-0x0000000186692524
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_0 // TypeDefIndex: 48012
		{
			// Fields
			public Dictionary<int, Transform> replaceDict; // 0x10
	
			// Constructors
			public __c__DisplayClass127_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _ReplaceTransform_b__0(int handle); // 0x0000000186692524-0x0000000186692598
			internal void _ReplaceTransform_b__1(TransformRecord rd); // 0x0000000186692598-0x00000001866925C0
		}
	
		// Constructors
		public ClothProcess(); // 0x00000001840FADE0-0x00000001840FB030
		static ClothProcess(); // 0x0000000184B4D990-0x0000000184B4DAB0
	
		// Methods
		internal void Init(); // 0x000000018308C560-0x000000018308CC70
		private int AddRenderer(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referenceUniqueSetupData); // 0x000000018668D5E0-0x000000018668D84C
		private void CreateBoneRenderSetupData(ClothType ctype, List<Transform> rootTransforms, List<Transform> ignoreFromRootBones, List<Transform> collisionBones, RenderSetupData.BoneConnectionMode connectionMode); // 0x0000000183E90A00-0x0000000183E90B20
		internal void StartUse(); // 0x00000001837EBF90-0x00000001837EC000
		internal void EndUse(); // 0x00000001837EBED0-0x00000001837EBF40
		internal void UpdateUse(); // 0x00000001837EC560-0x00000001837EC7E0
		internal void DataUpdate(); // 0x000000018668D84C-0x000000018668D93C
		internal bool StartRuntimeBuild(); // 0x0000000183A7B110-0x0000000183A7B240
		internal bool AutoBuild(); // 0x0000000183E8BC40-0x0000000183E8BCD0
		private async System.Threading.Tasks.Task RuntimeBuildAsync(CancellationToken ct); // 0x0000000183A7AFF0-0x0000000183A7B110
		public ResultCode GenerateSelectionDataFromPaintMap(TransformRecord clothTransformRecord, VirtualMesh renderMesh, PaintMapData paintMapData, out SelectionData selectionData); // 0x000000018668E558-0x000000018668EDE0
		public ResultCode GeneratePaintMapDataList(List<PaintMapData> dataList); // 0x000000018668E10C-0x000000018668E558
		public ResultCode GenerateSelectionDataFromVertexAttributeData(TransformRecord clothTransformRecord, VirtualMesh renderMesh, VertexAttribute[] vertexAttributeArray, out SelectionData selectionData); // 0x000000018668EDE0-0x000000018668F30C
		internal bool PreBuildDataConstruction(); // 0x0000000183E8CDC0-0x0000000183E8E950
		internal int GetColliderIndex(ColliderComponent col); // 0x0000000183CF6A20-0x0000000183CF6A70
		internal void UpdateCullingAnimatorAndRenderers(); // 0x00000001839C60F0-0x00000001839C6240
		internal void UpdateRendererUse(); // 0x00000001847D7710-0x00000001847D7870
		public BitField32 GetStateFlag(); // 0x000000018668F550-0x000000018668F59C
		public bool IsState(int state); // 0x0000000182F95870-0x0000000182F95910
		public void SetState(int state, bool sw); // 0x0000000182F949B0-0x0000000182F94A50
		public bool IsValid(); // 0x0000000182F95500-0x0000000182F955B0
		public bool IsRunning(); // 0x00000001835BD800-0x00000001835BD8B0
		public bool IsCameraCullingInvisible(); // 0x000000018668F990-0x000000018668F9E8
		public bool IsLodCulled(); // 0x000000018668FA98-0x000000018668FAF0
		public bool IsCameraCullingKeep(); // 0x000000018668F9E8-0x000000018668FA40
		public bool IsDistanceCullingInvisible(); // 0x000000018668FA40-0x000000018668FA98
		public bool IsSkipWriting(); // 0x000000018668FAF0-0x000000018668FB48
		public bool IsUpdateTangent(); // 0x000000018668FB48-0x000000018668FBA0
		public void Dispose(); // 0x0000000183E92BD0-0x0000000183E92E10
		private void DisposeInternal(); // 0x0000000183E933E0-0x0000000183E96440
		internal void IncrementSuspendCounter(); // 0x000000018668F87C-0x000000018668F990
		internal void DecrementSuspendCounter(); // 0x000000018668D93C-0x000000018668DA44
		internal int GetSuspendCounter(); // 0x000000018668F59C-0x000000018668F664
		public RenderMeshInfo GetRenderMeshInfo(int index); // 0x000000018668F4AC-0x000000018668F550
		internal void SyncParameters(); // 0x000000018308C240-0x000000018308C390
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x000000018668F664-0x000000018668F87C
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x000000018668FBA0-0x000000018668FDB8
		internal void SetSkipWriting(bool sw); // 0x000000018668FDB8-0x000000018668FE7C
		internal ClothUpdateMode GetClothUpdateMode(); // 0x000000018668F30C-0x000000018668F4AC
		public ResultCode GenerateStatusCheck(); // 0x000000018308C390-0x000000018308C560
		internal bool GenerateInitialization(); // 0x000000018668DFC8-0x000000018668E10C
		internal bool GenerateBoneClothSelection(); // 0x000000018668DA44-0x000000018668DFC8
	}

	[Serializable]
	public class ClothSerializeData : IDataValidate, IValid, ITransform // TypeDefIndex: 48018
	{
		// Fields
		public ClothProcess.ClothType clothType; // 0x10
		public List<Renderer> sourceRenderers; // 0x18
		public ClothMeshWriteMode meshWriteMode; // 0x20
		public PaintMode paintMode; // 0x24
		public List<Texture2D> paintMaps; // 0x28
		public List<Transform> rootBones; // 0x30
		public List<Transform> ignoreFromRootBones; // 0x38
		public RenderSetupData.BoneConnectionMode connectionMode; // 0x40
		[Range(0f, 1f)]
		public float rotationalInterpolation; // 0x44
		[Range(0f, 1f)]
		public float rootRotation; // 0x48
		public ClothUpdateMode updateMode; // 0x4C
		public AnimatorAbilityLevel clothAnimatorAbilityLODThreshold; // 0x50
		[Range(0f, 9f)]
		public int clothAnimatorLODThreshold; // 0x54
		[Range(0f, 10f)]
		public float clothLodFadeTime; // 0x58
		[Range(0f, 1f)]
		public float clothSimulateWeight; // 0x5C
		public bool resetSimulationToAnimationPoseWhenWeightLow; // 0x60
		[Range(0f, 1f)]
		public float resetSimulationToAnimationPoseWeightThreshold; // 0x64
		[Range(0f, 1f)]
		public float animationPoseRatio; // 0x68
		public ReductionSettings reductionSetting; // 0x70
		public CustomSkinningSettings customSkinningSetting; // 0x78
		public NormalAlignmentSettings normalAlignmentSetting; // 0x80
		public CullingSettings cullingSettings; // 0x88
		public ClothNormalAxis normalAxis; // 0x90
		[Range(0f, 10f)]
		public float gravity; // 0x94
		public float3 gravityDirection; // 0x98
		[Range(0f, 1f)]
		public float gravityFalloff; // 0xA4
		[Range(0f, 1f)]
		public float stablizationTimeAfterReset; // 0xA8
		[Range(0f, 1f)]
		public float blendWeight; // 0xAC
		public CurveSerializeData damping; // 0xB0
		public CurveSerializeData radius; // 0xB8
		public InertiaConstraint.SerializeData inertiaConstraint; // 0xC0
		public TetherConstraint.SerializeData tetherConstraint; // 0xC8
		public DistanceConstraint.SerializeData distanceConstraint; // 0xD0
		public TriangleBendingConstraint.SerializeData triangleBendingConstraint; // 0xD8
		public AngleConstraint.RestorationSerializeData angleRestorationConstraint; // 0xE0
		public AngleConstraint.LimitSerializeData angleLimitConstraint; // 0xE8
		public MotionConstraint.SerializeData motionConstraint; // 0xF0
		public ColliderCollisionConstraint.SerializeData colliderCollisionConstraint; // 0xF8
		public SelfCollisionConstraint.SerializeData selfCollisionConstraint; // 0x100
		public WindSettings wind; // 0x108
		public SpringConstraint.SerializeData springConstraint; // 0x110
		private ResultCode verificationResult; // 0x118
	
		// Properties
		public Define.Result VerificationResult { get; } // 0x00000001866916C8-0x000000018669171C 
	
		// Nested types
		public enum PaintMode // TypeDefIndex: 48014
		{
			Manual = 0,
			Texture_Fixed_Move = 1,
			Texture_Fixed_Move_Limit = 2
		}
	
		public enum AnimatorAbilityLevel // TypeDefIndex: 48015
		{
			OnlyPlayerOrBoss = 0,
			AICharOrElite = 1,
			DefaultOrAtmosphere = 2
		}
	
		private class TempBuffer // TypeDefIndex: 48016
		{
			// Fields
			private ClothProcess.ClothType clothType; // 0x10
			private List<Renderer> sourceRenderers; // 0x18
			private ClothMeshWriteMode meshWriteMode; // 0x20
			private PaintMode paintMode; // 0x24
			private List<Texture2D> paintMaps; // 0x28
			private List<Transform> rootBones; // 0x30
			private List<Transform> ignoreFromRootBones; // 0x38
			private RenderSetupData.BoneConnectionMode connectionMode; // 0x40
			private float rotationalInterpolation; // 0x44
			private float rootRotation; // 0x48
			private ClothUpdateMode updateMode; // 0x4C
			private int clothAnimatorLODThreshold; // 0x50
			private int clothAnimatorAbilityLODThreshold; // 0x54
			private float clothLodFadeTime; // 0x58
			private float animationPoseRatio; // 0x5C
			private float clothSimulateWeight; // 0x60
			private bool resetSimulationToAnimationPoseWhenWeightLow; // 0x64
			private float resetSimulationToAnimationPoseWeightThreshold; // 0x68
			private ReductionSettings reductionSetting; // 0x70
			private CustomSkinningSettings customSkinningSetting; // 0x78
			private NormalAlignmentSettings normalAlignmentSetting; // 0x80
			private ClothNormalAxis normalAxis; // 0x88
			private List<ColliderComponent> colliderList; // 0x90
			private List<Transform> collisionBones; // 0x98
			private BeyondBoneCloth synchronization; // 0xA0
			private float stablizationTimeAfterReset; // 0xA8
			private float blendWeight; // 0xAC
			private CullingSettings cullingSetting; // 0xB0
			private Transform anchor; // 0xB8
			private float anchorInertia; // 0xC0
	
			// Constructors
			internal TempBuffer(ClothSerializeData sdata); // 0x00000001866923B4-0x00000001866923BC
	
			// Methods
			internal void Push(ClothSerializeData sdata); // 0x0000000186691FD0-0x00000001866923B4
			internal void Pop(ClothSerializeData sdata); // 0x0000000186691D90-0x0000000186691FD0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 48017
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, bool> __9__47_0; // 0x08
			public static Func<Renderer, bool> __9__47_1; // 0x10
	
			// Constructors
			static __c(); // 0x0000000184D40990-0x0000000184D409F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _IsValid_b__47_0(Transform x); // 0x000000018456CFB0-0x000000018456D040
			internal bool _IsValid_b__47_1(Renderer x); // 0x00000001866923BC-0x0000000186692408
		}
	
		// Constructors
		public ClothSerializeData(); // 0x0000000183665930-0x0000000183665F40
	
		// Methods
		public bool IsValid(); // 0x00000001844AA870-0x00000001844AAA60
		public void DataValidate(); // 0x0000000186690200-0x000000018669050C
		public override int GetHashCode(); // 0x000000018669055C-0x0000000186690BA8
		public ClothParameters GetClothParameters(); // 0x000000018308A880-0x000000018308AB90
		public string ExportJson(); // 0x000000018669050C-0x000000018669055C
		public bool ImportJson(string json); // 0x0000000186690DB4-0x0000000186690F18
		[IDTag(0)]
		public void Import(ClothSerializeData sdata, bool deepCopy = false /* Metadata: 0x0232CD52 */); // 0x0000000186690FA0-0x0000000186691500
		[IDTag(1)]
		public void Import(BeyondBoneCloth src, bool deepCopy = false /* Metadata: 0x0232CD53 */); // 0x0000000186690F18-0x0000000186690FA0
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000186690BA8-0x0000000186690DB4
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000186691500-0x00000001866916C8
		public bool IsBoneSpring(); // 0x000000018308D200-0x000000018308D230
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
	}

	[Serializable]
	public class ClothSerializeData2 : IDataValidate, IValid, ITransform // TypeDefIndex: 48019
	{
		// Fields
		[SerializeField]
		public SelectionData selectionData; // 0x10
		[NonSerialized]
		public Dictionary<Transform, VertexAttribute> boneAttributeDict; // 0x18
		[NonSerialized]
		public List<VertexAttribute[]> vertexAttributeList; // 0x20
		public PreBuildSerializeData preBuildData; // 0x28
	
		// Constructors
		public ClothSerializeData2(); // 0x00000001840FACC0-0x00000001840FADE0
	
		// Methods
		public bool IsValid(); // 0x0000000186690148-0x0000000186690194
		public void DataValidate(); // 0x0000000186690050-0x0000000186690090
		public override int GetHashCode(); // 0x0000000186690090-0x00000001866900DC
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001866900DC-0x0000000186690148
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000186690194-0x0000000186690200
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
	}

	public enum ClothUpdateMode // TypeDefIndex: 48020
	{
		Normal = 0,
		UnityPhysics = 1,
		Unscaled = 2,
		AnimatorLinkage = 10
	}

	public class BeyondBoneCapsuleCollider : ColliderComponent // TypeDefIndex: 48022
	{
		// Fields
		public Direction direction; // 0x40
		public bool reverseDirection; // 0x44
		public bool radiusSeparation; // 0x45
		public bool alignedOnCenter; // 0x46
	
		// Nested types
		public enum Direction // TypeDefIndex: 48021
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public BeyondBoneCapsuleCollider(); // 0x00000001840FAC40-0x00000001840FAC50
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType(); // 0x0000000184552AF0-0x0000000184552B50
		public void SetSize(float startRadius, float endRadius, float length); // 0x000000018668B9DC-0x000000018668BA98
		public override Vector3 GetSize(); // 0x000000018323E8E0-0x000000018323E970
		public Vector3 GetLocalDir(); // 0x000000018668B880-0x000000018668B954
		public Vector3 GetLocalUp(); // 0x000000018668B954-0x000000018668B9DC
		public override bool IsReverseDirection(); // 0x00000001845E7D40-0x00000001845E7D70
		public override void DataValidate(); // 0x000000018668B804-0x000000018668B880
		public Vector3 __iFixBaseProxy_GetSize(); // 0x000000018668BA98-0x000000018668BAC8
		public bool __iFixBaseProxy_IsReverseDirection(); // 0x000000018668BAC8-0x000000018668BAD0
	}

	public class BeyondBonePlaneCollider : ColliderComponent // TypeDefIndex: 48023
	{
		// Constructors
		public BeyondBonePlaneCollider(); // 0x00000001840FAB10-0x00000001840FAB20
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType(); // 0x0000000184D26400-0x0000000184D26430
		public override void DataValidate(); // 0x000000018668D2A8-0x000000018668D2EC
	}

	public class BeyondBoneSphereCollider : ColliderComponent // TypeDefIndex: 48024
	{
		// Constructors
		public BeyondBoneSphereCollider(); // 0x00000001840FAB10-0x00000001840FAB20
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType(); // 0x0000000184B2D9D0-0x0000000184B2DA00
		public override void DataValidate(); // 0x000000018668D2EC-0x000000018668D348
		public void SetSize(float radius); // 0x000000018668D348-0x000000018668D3C4
	}

	public abstract class ColliderComponent : ClothBehaviour, IDataValidate // TypeDefIndex: 48025
	{
		// Fields
		public Vector3 center; // 0x20
		[SerializeField]
		protected Vector3 size; // 0x2C
		private HashSet<int> teamIdSet; // 0x38
	
		// Constructors
		protected ColliderComponent(); // 0x00000001840FAC50-0x00000001840FACC0
	
		// Methods
		public abstract ColliderManager.ColliderType GetColliderType();
		public abstract void DataValidate();
		public virtual Vector3 GetSize(); // 0x00000001848F8AD0-0x00000001848F8B20
		public void SetSize(Vector3 size); // 0x0000000186691974-0x00000001866919EC
		public void SetSizeX(float size); // 0x0000000186691860-0x00000001866918BC
		public void SetSizeY(float size); // 0x00000001866918BC-0x0000000186691918
		public void SetSizeZ(float size); // 0x0000000186691918-0x0000000186691974
		public virtual float GetScale(); // 0x00000001866917A4-0x0000000186691810
		public virtual bool IsReverseDirection(); // 0x0000000184A3BA40-0x0000000184A3BA70
		internal void Register(int teamId); // 0x00000001844B4A30-0x00000001844B4AA0
		internal void Exit(int teamId); // 0x000000018669171C-0x00000001866917A4
		public void UpdateParameters(); // 0x00000001866919EC-0x0000000186691B78
		protected virtual void Start(); // 0x00000001846DADE0-0x00000001846DAE10
		protected virtual void OnValidate(); // 0x0000000186691810-0x0000000186691860
		protected virtual void OnEnable(); // 0x00000001843D2240-0x00000001843D24C0
		protected virtual void OnDisable(); // 0x0000000183CF5F60-0x0000000183CF61E0
		protected virtual void OnDestroy(); // 0x0000000183CF54E0-0x0000000183CF5790
	}

	[BurstCompile]
	internal static class AngleConstraintJobKernels // TypeDefIndex: 48030
	{
		// Nested types
		public unsafe delegate void AngleConstraintKernel_000000C4_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // TypeDefIndex: 48026; 0x000000018669A174-0x000000018669A278
	
		internal static class AngleConstraintKernel_000000C4_BurstDirectCall // TypeDefIndex: 48027
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static AngleConstraintKernel_000000C4_BurstDirectCall(); // 0x0000000184D1D5F0-0x0000000184D1D600
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067821); // 0x0000000186699C30-0x0000000186699D34
			private static IntPtr GetFunctionPointer(); // 0x0000000186699D34-0x0000000186699D88
			public static void Constructor(); // 0x0000000184D1D600-0x0000000184D1D690
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // 0x0000000186699D88-0x000000018669A028
		}
	
		public unsafe delegate void AngleConstraintRangeKernel_000000C5_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // TypeDefIndex: 48028; 0x000000018669A830-0x000000018669A934
	
		internal static class AngleConstraintRangeKernel_000000C5_BurstDirectCall // TypeDefIndex: 48029
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static AngleConstraintRangeKernel_000000C5_BurstDirectCall(); // 0x0000000184D1D550-0x0000000184D1D560
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067866); // 0x000000018669A34C-0x000000018669A450
			private static IntPtr GetFunctionPointer(); // 0x000000018669A450-0x000000018669A4A4
			public static void Constructor(); // 0x0000000184D1D560-0x0000000184D1D5F0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // 0x000000018669A4A4-0x000000018669A740
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void AngleConstraintKernel(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // 0x000000018668B3BC-0x000000018668B524
		[BurstCompile]
		internal static unsafe void AngleConstraintRangeKernel(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // 0x000000018668B698-0x000000018668B804
		[BurstCompile]
		public static unsafe void AngleConstraintKernel_BurstManaged(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // 0x0000000186689D38-0x000000018668B3BC
		[BurstCompile]
		public static unsafe void AngleConstraintRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // 0x000000018668B524-0x000000018668B698
	}

	public class AngleConstraint : IDisposable // TypeDefIndex: 48035
	{
		// Fields
		private NativeArray<float> lengthBuffer; // 0x10
		private NativeArray<float3> localPosBuffer; // 0x20
		private NativeArray<quaternion> localRotBuffer; // 0x30
		private NativeArray<quaternion> rotationBuffer; // 0x40
		private NativeArray<float3> restorationVectorBuffer; // 0x50
	
		// Nested types
		[Serializable]
		public class RestorationSerializeData : IDataValidate // TypeDefIndex: 48031
		{
			// Fields
			public bool useAngleRestoration; // 0x10
			public CurveSerializeData stiffness; // 0x18
			[Range(0f, 1f)]
			public float velocityAttenuation; // 0x20
			[Range(0f, 1f)]
			public float gravityFalloff; // 0x24
	
			// Constructors
			public RestorationSerializeData(); // 0x0000000184483400-0x00000001844834A0
	
			// Methods
			public void DataValidate(); // 0x00000001866A5DA4-0x00000001866A5E24
			public RestorationSerializeData Clone(); // 0x00000001866A5CE0-0x00000001866A5DA4
		}
	
		[Serializable]
		public class LimitSerializeData : IDataValidate // TypeDefIndex: 48032
		{
			// Fields
			public bool useAngleLimit; // 0x10
			public CurveSerializeData limitAngle; // 0x18
			[Range(0f, 1f)]
			public float stiffness; // 0x20
	
			// Constructors
			public LimitSerializeData(); // 0x00000001844959E0-0x0000000184495A80
	
			// Methods
			public void DataValidate(); // 0x00000001866A2344-0x00000001866A23B4
			public LimitSerializeData Clone(); // 0x00000001866A228C-0x00000001866A2344
		}
	
		public struct AngleConstraintParams // TypeDefIndex: 48033
		{
			// Fields
			public bool useAngleRestoration; // 0x00
			public float4x4 restorationStiffness; // 0x04
			public float restorationVelocityAttenuation; // 0x44
			public float restorationGravityFalloff; // 0x48
			public bool useAngleLimit; // 0x4C
			public float4x4 limitCurveData; // 0x50
			public float limitstiffness; // 0x90
	
			// Methods
			public void Convert(RestorationSerializeData restorationData, LimitSerializeData limitData); // 0x000000018308AC90-0x000000018308ADC0
		}
	
		[BurstCompile]
		private struct AngleConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48034
		{
			// Fields
			public float4 simulationPower; // 0x00
			[ReadOnly]
			public NativeArray<int> stepBaseLineIndexArray; // 0x10
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x20
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x30
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x40
			[ReadOnly]
			public NativeArray<float> vertexDepths; // 0x50
			[ReadOnly]
			public NativeArray<int> vertexParentIndices; // 0x60
			[ReadOnly]
			public NativeArray<ushort> baseLineStartDataIndices; // 0x70
			[ReadOnly]
			public NativeArray<ushort> baseLineDataCounts; // 0x80
			[ReadOnly]
			public NativeArray<ushort> baseLineData; // 0x90
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0xA0
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0xB0
			[ReadOnly]
			public NativeArray<float> frictionArray; // 0xC0
			[ReadOnly]
			public NativeArray<double3> stepBasicPositionBuffer; // 0xD0
			[ReadOnly]
			public NativeArray<quaternion> stepBasicRotationBuffer; // 0xE0
			[NativeDisableParallelForRestriction]
			public NativeArray<float> lengthBufferArray; // 0xF0
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> localPosBufferArray; // 0x100
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> localRotBufferArray; // 0x110
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> rotationBufferArray; // 0x120
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> restorationVectorBufferArray; // 0x130
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x140
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183BB3750-0x0000000183BB37D0
			[IDTag(1)]
			public void Execute(); // 0x0000000186698114-0x00000001866981AC
			[IDTag(0)]
			public void Execute(int index); // 0x00000001866981AC-0x00000001866999A8
			public void UnsafeDo(); // 0x00000001866999A8-0x0000000186699C30
		}
	
		// Constructors
		public AngleConstraint(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x000000018669AA08-0x000000018669AAD4
		internal void WorkBufferUpdate(); // 0x0000000182F8A690-0x0000000182F8A9F0
		public override string ToString(); // 0x000000018669AAD4-0x000000018669AD6C
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x00000001830A2120-0x00000001830A26A0
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public class ColliderCollisionConstraint : IDisposable // TypeDefIndex: 48057
	{
		// Fields
		private NativeArray<int> tempFrictionArray; // 0x10
		private NativeArray<int> tempNormalArray; // 0x20
	
		// Nested types
		[BurstCompile]
		private static class PointColliderCollisionConstraintJobKernels // TypeDefIndex: 48040
		{
			// Nested types
			public unsafe delegate void PointColliderCollisionConstraintKernel_000000DB_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // TypeDefIndex: 48036; 0x00000001866A5628-0x00000001866A56D0
	
			internal static class PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall // TypeDefIndex: 48037
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall(); // 0x0000000184D1C3D0-0x0000000184D1C3E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000678ec); // 0x00000001866A520C-0x00000001866A5310
				private static IntPtr GetFunctionPointer(); // 0x00000001866A5310-0x00000001866A5364
				public static void Constructor(); // 0x0000000184D1C3E0-0x0000000184D1C470
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // 0x00000001866A5364-0x00000001866A5530
			}
	
			public unsafe delegate void PointColliderCollisionConstraintRangeKernel_000000DC_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // TypeDefIndex: 48038; 0x00000001866A5B60-0x00000001866A5C0C
	
			internal static class PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall // TypeDefIndex: 48039
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall(); // 0x0000000184D1C330-0x0000000184D1C340
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006791c); // 0x00000001866A57A4-0x00000001866A58A8
				private static IntPtr GetFunctionPointer(); // 0x00000001866A58A8-0x00000001866A58FC
				public static void Constructor(); // 0x0000000184D1C340-0x0000000184D1C3D0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // 0x00000001866A58FC-0x00000001866A5AC4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PointColliderCollisionConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // 0x00000001866A33FC-0x00000001866A34F8
			[BurstCompile]
			internal static unsafe void PointColliderCollisionConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // 0x00000001866A34F8-0x00000001866A35F8
			private static double PointSphereColliderDetection(ref double3 nextpos, [IsReadOnly] in double3 basePos, float radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, bool isSpring, float maxLength, out float3 normal); // 0x00000001866A376C-0x00000001866A3AF0
			private static double PointPlaneColliderDetction(ref double3 nextpos, float radius, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001866A35F8-0x00000001866A376C
			private static double PointCapsuleColliderDetection(ref double3 nextpos, float radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001866A23B4-0x00000001866A2758
			[BurstCompile]
			public static unsafe void PointColliderCollisionConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // 0x00000001866A2758-0x00000001866A33FC
			[BurstCompile]
			public static unsafe void PointColliderCollisionConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // 0x0000000186697910-0x0000000186697A0C
		}
	
		[BurstCompile]
		private static class EdgeColliderCollisionConstraintJobKernels // TypeDefIndex: 48045
		{
			// Nested types
			public unsafe delegate void EdgeColliderCollisionConstraintKernel_000000E0_PostfixBurstDelegate(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // TypeDefIndex: 48041; 0x00000001866A1944-0x00000001866A1A20
	
			internal static class EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall // TypeDefIndex: 48042
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall(); // 0x0000000184D1C830-0x0000000184D1C840
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000679ac); // 0x00000001866A1484-0x00000001866A1588
				private static IntPtr GetFunctionPointer(); // 0x00000001866A1588-0x00000001866A15DC
				public static void Constructor(); // 0x0000000184D1C840-0x0000000184D1C8D0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001866A15DC-0x00000001866A181C
			}
	
			public unsafe delegate void EdgeColliderCollisionConstraintRangeKernel_000000E1_PostfixBurstDelegate(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // TypeDefIndex: 48043; 0x00000001866A1F54-0x00000001866A2030
	
			internal static class EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall // TypeDefIndex: 48044
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall(); // 0x0000000184D1C790-0x0000000184D1C7A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000679e8); // 0x00000001866A1AF4-0x00000001866A1BF8
				private static IntPtr GetFunctionPointer(); // 0x00000001866A1BF8-0x00000001866A1C4C
				public static void Constructor(); // 0x0000000184D1C7A0-0x0000000184D1C830
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001866A1C4C-0x00000001866A1E88
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void EdgeColliderCollisionConstraintKernel(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x000000018669E924-0x000000018669EA5C
			[BurstCompile]
			internal static unsafe void EdgeColliderCollisionConstraintRangeKernel(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x000000018669EA5C-0x000000018669EB98
			private static float EdgeSphereColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, double cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x000000018669ED80-0x000000018669F328
			private static double EdgeCapsuleColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, double cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x000000018669D388-0x000000018669DC14
			private static double EdgePlaneColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x000000018669EB98-0x000000018669ED80
			[BurstCompile]
			public static unsafe void EdgeColliderCollisionConstraintKernel_BurstManaged(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x000000018669DC14-0x000000018669E924
			[BurstCompile]
			public static unsafe void EdgeColliderCollisionConstraintRangeKernel_BurstManaged(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x0000000186695998-0x0000000186695AD0
		}
	
		[BurstCompile]
		private static class SolveEdgeBufferAndClearJobKernels // TypeDefIndex: 48050
		{
			// Nested types
			public unsafe delegate void SolveEdgeBufferAndClearKernel_000000E5_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // TypeDefIndex: 48046; 0x00000001866A7290-0x00000001866A7304
	
			internal static class SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall // TypeDefIndex: 48047
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall(); // 0x0000000184D1BED0-0x0000000184D1BEE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067a3c); // 0x00000001866A6F2C-0x00000001866A7030
				private static IntPtr GetFunctionPointer(); // 0x00000001866A7030-0x00000001866A7084
				public static void Constructor(); // 0x0000000184D1BEE0-0x0000000184D1BF70
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001866A7084-0x00000001866A71C0
			}
	
			public unsafe delegate void SolveEdgeBufferAndClearRangeKernel_000000E6_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // TypeDefIndex: 48048; 0x000000018621C638-0x000000018621C6AC
	
			internal static class SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall // TypeDefIndex: 48049
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall(); // 0x0000000184D1BE30-0x0000000184D1BE40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067a60); // 0x00000001866A73D8-0x00000001866A74DC
				private static IntPtr GetFunctionPointer(); // 0x00000001866A74DC-0x00000001866A7530
				public static void Constructor(); // 0x0000000184D1BE40-0x0000000184D1BED0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001866A7530-0x00000001866A76A0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolveEdgeBufferAndClearKernel(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001866A68C8-0x00000001866A698C
			[BurstCompile]
			internal static unsafe void SolveEdgeBufferAndClearRangeKernel(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001866A6A4C-0x00000001866A6B10
			[BurstCompile]
			public static unsafe void SolveEdgeBufferAndClearKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x0000000186697A0C-0x0000000186698114
			[BurstCompile]
			public static unsafe void SolveEdgeBufferAndClearRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001866A698C-0x00000001866A6A4C
		}
	
		public enum Mode // TypeDefIndex: 48051
		{
			None = 0,
			Point = 1,
			Edge = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate, ITransform // TypeDefIndex: 48052
		{
			// Fields
			public Mode mode; // 0x10
			[Range(0f, 0.5f)]
			public float friction; // 0x14
			public List<ColliderComponent> colliderList; // 0x18
			public List<Transform> collisionBones; // 0x20
			public CurveSerializeData limitDistance; // 0x28
	
			// Properties
			public int ColliderLength { get; } // 0x0000000183CF7910-0x0000000183CF7970 
	
			// Constructors
			public SerializeData(); // 0x00000001840FB070-0x00000001840FB190
	
			// Methods
			public void DataValidate(); // 0x00000001866A6384-0x00000001866A6408
			public SerializeData Clone(); // 0x00000001866A6068-0x00000001866A61C0
			public override int GetHashCode(); // 0x00000001866A6408-0x00000001866A65A4
			public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001866A65A4-0x00000001866A674C
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x00000001866A674C-0x00000001866A68C8
			public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
		}
	
		public struct ColliderCollisionConstraintParams // TypeDefIndex: 48053
		{
			// Fields
			public Mode mode; // 0x00
			public float dynamicFriction; // 0x04
			public float staticFriction; // 0x08
			public float4x4 limitDistance; // 0x0C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x000000018308BF90-0x000000018308C000
		}
	
		[BurstCompile]
		private struct PointColliderCollisionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48054
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> stepParticleIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x30
			[ReadOnly]
			public NativeArray<float> vertexDepths; // 0x40
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x50
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0x70
			[ReadOnly]
			public NativeArray<double3> basePosArray; // 0x80
			[NativeDisableParallelForRestriction]
			public NativeArray<float> frictionArray; // 0x90
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> collisionNormalArray; // 0xA0
			[ReadOnly]
			public NativeArray<ExBitFlag8> colliderFlagArray; // 0xB0
			[ReadOnly]
			public NativeArray<ColliderManager.WorkData> colliderWorkDataArray; // 0xC0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xD0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183BB51A0-0x0000000183BB5220
			[IDTag(1)]
			public void Execute(); // 0x00000001866A3AF0-0x00000001866A3B88
			public void UnsafeDo(); // 0x00000001866A5030-0x00000001866A520C
			[IDTag(0)]
			public void Execute(int index); // 0x00000001866A3B88-0x00000001866A4874
			private double PointSphereColliderDetection(ref double3 nextpos, [IsReadOnly] in double3 basePos, double radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, bool isSpring, double maxLength, out float3 normal); // 0x00000001866A4CE0-0x00000001866A5030
			private double PointPlaneColliderDetction(ref double3 nextpos, double radius, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001866A4B98-0x00000001866A4CE0
			private double PointCapsuleColliderDetection(ref double3 nextpos, double radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001866A4874-0x00000001866A4B98
		}
	
		[BurstCompile]
		private struct EdgeColliderCollisionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48055
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> stepEdgeCollisionIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x30
			[ReadOnly]
			public NativeArray<float> vertexDepths; // 0x40
			[ReadOnly]
			public NativeArray<short> edgeTeamIdArray; // 0x50
			[ReadOnly]
			public NativeArray<int2> edges; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x70
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0x80
			[NativeDisableParallelForRestriction]
			public NativeArray<float> frictionArray; // 0x90
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> collisionNormalArray; // 0xA0
			[ReadOnly]
			public NativeArray<ExBitFlag8> colliderFlagArray; // 0xB0
			[ReadOnly]
			public NativeArray<ColliderManager.WorkData> colliderWorkDataArray; // 0xC0
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0xD0
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0xE0
			[NativeDisableParallelForRestriction]
			public NativeArray<int> tempFrictionArray; // 0xF0
			[NativeDisableParallelForRestriction]
			public NativeArray<int> tempNormalArray; // 0x100
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x110
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x00000001866A11C4-0x00000001866A1230
			[IDTag(1)]
			public void Execute(); // 0x00000001866A0334-0x00000001866A03CC
			[IDTag(0)]
			public void Execute(int index); // 0x00000001866A03CC-0x00000001866A11C4
			private double EdgeSphereColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, float cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x000000018669FDA4-0x00000001866A0334
			private double EdgeCapsuleColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, float cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x000000018669F328-0x000000018669FBA4
			private double EdgePlaneColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x000000018669FBA4-0x000000018669FDA4
			public void UnsafeDo(); // 0x00000001866A1230-0x00000001866A1484
		}
	
		[BurstCompile]
		private struct SolveEdgeBufferAndClearJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48056
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobParticleIndexList; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeArray<float> frictionArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> collisionNormalArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0x40
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x50
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<int> tempFrictionArray; // 0x70
			[NativeDisableParallelForRestriction]
			public NativeArray<int> tempNormalArray; // 0x80
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x90
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x00000001866A6D98-0x00000001866A6E04
			[IDTag(1)]
			public void Execute(); // 0x00000001866A6B10-0x00000001866A6BA8
			[IDTag(0)]
			public void Execute(int index); // 0x00000001866A6BA8-0x00000001866A6D98
			public void UnsafeDo(); // 0x00000001866A6E04-0x00000001866A6F2C
		}
	
		// Constructors
		public ColliderCollisionConstraint(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x000000018669AD74-0x000000018669ADF8
		internal void WorkBufferUpdate(); // 0x0000000182F8A600-0x0000000182F8A660
		public override string ToString(); // 0x000000018669ADF8-0x000000018669AF80
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x0000000182F8EF20-0x0000000182F8F430
		public static void Initialize_PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall(); // 0x00000001844F7C50-0x00000001844F7CB0
		public static void Initialize_PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall(); // 0x00000001844F7BF0-0x00000001844F7C50
		public static void Initialize_EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall(); // 0x00000001844F7B90-0x00000001844F7BF0
		public static void Initialize_EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall(); // 0x00000001844F7B30-0x00000001844F7B90
		public static void Initialize_SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall(); // 0x00000001844F7AD0-0x00000001844F7B30
		public static void Initialize_SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall(); // 0x00000001844F7A70-0x00000001844F7AD0
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	[BurstCompile]
	internal static class DistanceConstraintJobKernels // TypeDefIndex: 48062
	{
		// Nested types
		public unsafe delegate void DistanceConstraintKernel_00000101_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // TypeDefIndex: 48058; 0x000000018669C9B4-0x000000018669CA68
	
		internal static class DistanceConstraintKernel_00000101_BurstDirectCall // TypeDefIndex: 48059
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static DistanceConstraintKernel_00000101_BurstDirectCall(); // 0x0000000184D1C970-0x0000000184D1C980
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067af5); // 0x000000018669C574-0x000000018669C678
			private static IntPtr GetFunctionPointer(); // 0x000000018669C678-0x000000018669C6CC
			public static void Constructor(); // 0x0000000184D1C980-0x0000000184D1CA10
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // 0x000000018669C6CC-0x000000018669C8B0
		}
	
		public unsafe delegate void DistanceConstraintRangeKernel_00000102_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // TypeDefIndex: 48060; 0x000000018669CF20-0x000000018669CFD8
	
		internal static class DistanceConstraintRangeKernel_00000102_BurstDirectCall // TypeDefIndex: 48061
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static DistanceConstraintRangeKernel_00000102_BurstDirectCall(); // 0x0000000184D1C8D0-0x0000000184D1C8E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067b28); // 0x000000018669CB3C-0x000000018669CC40
			private static IntPtr GetFunctionPointer(); // 0x000000018669CC40-0x000000018669CC94
			public static void Constructor(); // 0x0000000184D1C8E0-0x0000000184D1C970
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // 0x000000018669CC94-0x000000018669CE78
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void DistanceConstraintKernel(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // 0x000000018669B7E8-0x000000018669B8F0
		[BurstCompile]
		internal static unsafe void DistanceConstraintRangeKernel(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // 0x000000018669B8F0-0x000000018669B9FC
		[BurstCompile]
		public static unsafe void DistanceConstraintKernel_BurstManaged(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // 0x000000018669AF80-0x000000018669B7E8
		[BurstCompile]
		public static unsafe void DistanceConstraintRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // 0x0000000186694B74-0x0000000186695998
	}

	public class DistanceConstraint : IDisposable // TypeDefIndex: 48067
	{
		// Fields
		public const int TypeCount = 2; // Metadata: 0x0232CD64
		public ExNativeArray<uint> indexArray; // 0x10
		public ExNativeArray<ushort> dataArray; // 0x18
		public ExNativeArray<float> distanceArray; // 0x20
	
		// Properties
		public int DataCount { get; } // 0x000000018669D310-0x000000018669D388 
	
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 48063
		{
			// Fields
			public CurveSerializeData stiffness; // 0x10
	
			// Constructors
			public SerializeData(); // 0x00000001844BA530-0x00000001844BA5C0
	
			// Methods
			public void DataValidate(); // 0x00000001866A61C0-0x00000001866A6220
			public SerializeData Clone(); // 0x00000001866A5E24-0x00000001866A5ECC
		}
	
		public struct DistanceConstraintParams // TypeDefIndex: 48064
		{
			// Fields
			public float4x4 restorationStiffness; // 0x00
			public float velocityAttenuation; // 0x40
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x000000018308BD30-0x000000018308BDC0
		}
	
		[Serializable]
		public class ConstraintData : IValid // TypeDefIndex: 48065
		{
			// Fields
			public ResultCode result; // 0x10
			public uint[] indexArray; // 0x18
			public ushort[] dataArray; // 0x20
			public float[] distanceArray; // 0x28
	
			// Constructors
			public ConstraintData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool IsValid(); // 0x0000000183E8CAD0-0x0000000183E8CB10
		}
	
		[BurstCompile]
		private struct DistanceConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48066
		{
			// Fields
			public float4 simulationPower; // 0x00
			[ReadOnly]
			public NativeArray<int> stepParticleIndexArray; // 0x10
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x20
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x30
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x40
			[ReadOnly]
			public NativeArray<float> depthArray; // 0x50
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x70
			[ReadOnly]
			public NativeArray<double3> basePosArray; // 0x80
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0x90
			[ReadOnly]
			public NativeArray<float> frictionArray; // 0xA0
			[ReadOnly]
			public NativeArray<uint> indexArray; // 0xB0
			[ReadOnly]
			public NativeArray<ushort> dataArray; // 0xC0
			[ReadOnly]
			public NativeArray<float> distanceArray; // 0xD0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xE0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183A6F860-0x0000000183A6F8E0
			[IDTag(1)]
			public void Execute(); // 0x000000018669B9FC-0x000000018669BA94
			[IDTag(0)]
			public void Execute(int index); // 0x000000018669BA94-0x000000018669C36C
			public void UnsafeDo(); // 0x000000018669C36C-0x000000018669C574
		}
	
		// Constructors
		public DistanceConstraint(); // 0x0000000183E8AF30-0x0000000183E8B1E0
	
		// Methods
		public void Dispose(); // 0x000000018669D0AC-0x000000018669D168
		public override string ToString(); // 0x000000018669D168-0x000000018669D310
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters); // 0x000000018352B7B0-0x000000018352E4F0
		internal void Register(ClothProcess cprocess); // 0x0000000183E8C740-0x0000000183E8C8F0
		internal void Exit(ClothProcess cprocess); // 0x0000000183CF3590-0x0000000183CF36E0
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x0000000182F90C60-0x0000000182F91160
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public class InertiaConstraint : IDisposable // TypeDefIndex: 48073
	{
		// Fields
		internal ExNativeArray<ushort> fixedArray; // 0x10
	
		// Nested types
		public enum TeleportMode // TypeDefIndex: 48068
		{
			None = 0,
			Reset = 1,
			Keep = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 48069
		{
			// Fields
			public Transform anchor; // 0x10
			[Range(0f, 1f)]
			public float anchorInertia; // 0x18
			[FormerlySerializedAs("movementInertia")]
			[Range(0f, 1f)]
			public float worldInertia; // 0x1C
			[Range(0f, 1f)]
			public float movementInertiaSmoothing; // 0x20
			public CheckSliderSerializeData movementSpeedLimit; // 0x28
			public CheckSliderSerializeData rotationSpeedLimit; // 0x30
			[Range(0f, 1f)]
			public float localInertia; // 0x38
			public CheckSliderSerializeData localMovementSpeedLimit; // 0x40
			public CheckSliderSerializeData localRotationSpeedLimit; // 0x48
			[Range(0f, 1f)]
			public float depthInertia; // 0x50
			[Range(0f, 1f)]
			public float centrifualAcceleration; // 0x54
			public CheckSliderSerializeData particleSpeedLimit; // 0x58
			public TeleportMode teleportMode; // 0x60
			public float teleportDistance; // 0x64
			public float teleportRotation; // 0x68
	
			// Constructors
			public SerializeData(); // 0x00000001842F5850-0x00000001842F59B0
	
			// Methods
			public SerializeData Clone(); // 0x00000001866A5ECC-0x00000001866A6068
			public void DataValidate(); // 0x00000001866A6220-0x00000001866A6384
		}
	
		public struct InertiaConstraintParams // TypeDefIndex: 48070
		{
			// Fields
			public float anchorInertia; // 0x00
			public float worldInertia; // 0x04
			public float movementInertiaSmoothing; // 0x08
			public float movementSpeedLimit; // 0x0C
			public float rotationSpeedLimit; // 0x10
			public float localInertia; // 0x14
			public float localMovementSpeedLimit; // 0x18
			public float localRotationSpeedLimit; // 0x1C
			public float depthInertia; // 0x20
			public float centrifualAcceleration; // 0x24
			public float particleSpeedLimit; // 0x28
			public TeleportMode teleportMode; // 0x2C
			public float teleportDistance; // 0x30
			public float teleportRotation; // 0x34
	
			// Methods
			public void Convert(SerializeData sdata); // 0x000000018308C0E0-0x000000018308C1F0
		}
	
		[Serializable]
		public struct CenterData // TypeDefIndex: 48071
		{
			// Fields
			public double3 anchorPosition; // 0x00
			public quaternion anchorRotation; // 0x18
			public double3 oldAnchorPosition; // 0x28
			public quaternion oldAnchorRotation; // 0x40
			public float3 anchorComponentLocalPosition; // 0x50
			public int centerTransformIndex; // 0x5C
			public double3 componentWorldPosition; // 0x60
			public quaternion componentWorldRotation; // 0x78
			public float3 componentWorldScale; // 0x88
			public double3 oldComponentWorldPosition; // 0x98
			public quaternion oldComponentWorldRotation; // 0xB0
			public float3 oldComponentWorldScale; // 0xC0
			public float3 frameComponentShiftVector; // 0xCC
			public quaternion frameComponentShiftRotation; // 0xD8
			public float frameMovingSpeed; // 0xE8
			public float3 frameMovingDirection; // 0xEC
			public double3 frameWorldPosition; // 0xF8
			public quaternion frameWorldRotation; // 0x110
			public float3 frameWorldScale; // 0x120
			public float3 frameLocalPosition; // 0x12C
			public double3 oldFrameWorldPosition; // 0x138
			public quaternion oldFrameWorldRotation; // 0x150
			public float3 oldFrameWorldScale; // 0x160
			public double3 nowWorldPosition; // 0x170
			public quaternion nowWorldRotation; // 0x188
			public double3 oldWorldPosition; // 0x198
			public quaternion oldWorldRotation; // 0x1B0
			public float stepMoveInertiaRatio; // 0x1C0
			public float stepRotationInertiaRatio; // 0x1C4
			public float3 stepVector; // 0x1C8
			public quaternion stepRotation; // 0x1D4
			public float3 inertiaVector; // 0x1E4
			public quaternion inertiaRotation; // 0x1F0
			public float stepMovingSpeed; // 0x200
			public float3 stepMovingDirection; // 0x204
			public float angularVelocity; // 0x210
			public float3 rotationAxis; // 0x214
			public float3 initLocalGravityDirection; // 0x220
			public float3 smoothingVelocity; // 0x22C
			public double4x4 negativeScaleMatrix; // 0x238
	
			// Methods
			internal void Initialize(); // 0x0000000183E8CB10-0x0000000183E8CC80
		}
	
		[Serializable]
		public class ConstraintData // TypeDefIndex: 48072
		{
			// Fields
			public ResultCode result; // 0x10
			public CenterData centerData; // 0x18
			public float3 initLocalGravityDirection; // 0x2D0
	
			// Constructors
			public ConstraintData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public InertiaConstraint(); // 0x0000000183E86E70-0x0000000183E86F80
	
		// Methods
		public void Dispose(); // 0x00000001866A2104-0x00000001866A218C
		public override string ToString(); // 0x00000001866A218C-0x00000001866A228C
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters); // 0x0000000183E8BCD0-0x0000000183E8C3B0
		internal void Register(ClothProcess cprocess); // 0x0000000183E8C8F0-0x0000000183E8CA90
		internal void Exit(ClothProcess cprocess); // 0x0000000183CF3440-0x0000000183CF3520
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	[BurstCompile]
	internal static class MotionConstraintJobKernels // TypeDefIndex: 48078
	{
		// Nested types
		public unsafe delegate void MotionConstraintKernel_00000121_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // TypeDefIndex: 48074; 0x000000018670A4E0-0x000000018670A57C
	
		internal static class MotionConstraintKernel_00000121_BurstDirectCall // TypeDefIndex: 48075
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static MotionConstraintKernel_00000121_BurstDirectCall(); // 0x0000000184D1C510-0x0000000184D1C520
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067b99); // 0x000000018670A0F0-0x000000018670A1F4
			private static IntPtr GetFunctionPointer(); // 0x000000018670A1F4-0x000000018670A248
			public static void Constructor(); // 0x0000000184D1C520-0x0000000184D1C5B0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // 0x000000018670A248-0x000000018670A3F4
		}
	
		public unsafe delegate void MotionConstraintRangeKernel_00000122_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // TypeDefIndex: 48076; 0x000000018670A9E0-0x000000018670AA80
	
		internal static class MotionConstraintRangeKernel_00000122_BurstDirectCall // TypeDefIndex: 48077
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static MotionConstraintRangeKernel_00000122_BurstDirectCall(); // 0x0000000184D1C470-0x0000000184D1C480
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067bc6); // 0x000000018670A650-0x000000018670A754
			private static IntPtr GetFunctionPointer(); // 0x000000018670A754-0x000000018670A7A8
			public static void Constructor(); // 0x0000000184D1C480-0x0000000184D1C510
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x000000018670A7A8-0x000000018670A950
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void MotionConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // 0x0000000186709388-0x0000000186709470
		[BurstCompile]
		internal static unsafe void MotionConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x0000000186709470-0x000000018670955C
		[BurstCompile]
		public static unsafe void MotionConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // 0x0000000186708A6C-0x0000000186709388
		[BurstCompile]
		public static unsafe void MotionConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x0000000186703794-0x0000000186703878
	}

	public class MotionConstraint : IDisposable // TypeDefIndex: 48082
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 48079
		{
			// Fields
			public bool useMaxDistance; // 0x10
			public CurveSerializeData maxDistance; // 0x18
			public bool useBackstop; // 0x20
			[Range(0.1f, 10f)]
			public float backstopRadius; // 0x24
			public CurveSerializeData backstopDistance; // 0x28
			[Range(0f, 1f)]
			public float stiffness; // 0x30
	
			// Constructors
			public SerializeData(); // 0x0000000183665870-0x0000000183665930
	
			// Methods
			public void DataValidate(); // 0x000000018670E040-0x000000018670E0FC
			public SerializeData Clone(); // 0x000000018670DE0C-0x000000018670DEF4
		}
	
		public struct MotionConstraintParams // TypeDefIndex: 48080
		{
			// Fields
			public bool useMaxDistance; // 0x00
			public float4x4 maxDistanceCurveData; // 0x04
			public bool useBackstop; // 0x44
			public float backstopRadius; // 0x48
			public float4x4 backstopDistanceCurveData; // 0x4C
			public float stiffness; // 0x8C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x000000018308AB90-0x000000018308AC90
		}
	
		[BurstCompile]
		private struct MotionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48081
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> stepParticleIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x30
			[ReadOnly]
			public NativeArray<float> vertexDepths; // 0x40
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x50
			[ReadOnly]
			public NativeArray<double3> basePosArray; // 0x60
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x70
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0x80
			[ReadOnly]
			public NativeArray<quaternion> baseRotArray; // 0x90
			[NativeDisableParallelForRestriction]
			public NativeArray<float> frictionArray; // 0xA0
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> collisionNormalArray; // 0xB0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xC0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183BB7320-0x0000000183BB73A0
			[IDTag(1)]
			public void Execute(); // 0x0000000186709EA8-0x0000000186709F40
			[IDTag(0)]
			public void Execute(int index); // 0x000000018670955C-0x0000000186709EA8
			public void UnsafeDo(); // 0x0000000186709F40-0x000000018670A0F0
		}
	
		// Constructors
		public MotionConstraint(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x000000018670AB54-0x000000018670AB98
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x0000000182F8DA50-0x0000000182F8DF00
	}

	public class SelfCollisionConstraint : IDisposable // TypeDefIndex: 48136
	{
		// Fields
		public const uint KindPoint = 0; // Metadata: 0x0232CD68
		public const uint KindEdge = 1; // Metadata: 0x0232CD69
		public const uint KindTriangle = 2; // Metadata: 0x0232CD6A
		public const uint Flag_KindMask = 50331648; // Metadata: 0x0232CD6B
		public const uint Flag_Fix0 = 67108864; // Metadata: 0x0232CD6F
		public const uint Flag_Fix1 = 134217728; // Metadata: 0x0232CD73
		public const uint Flag_Fix2 = 268435456; // Metadata: 0x0232CD77
		public const uint Flag_AllFix = 536870912; // Metadata: 0x0232CD7B
		public const uint Flag_Ignore = 1073741824; // Metadata: 0x0232CD80
		public const uint Flag_Enable = 2147483648; // Metadata: 0x0232CD85
		private ExNativeArray<Primitive> primitiveArray; // 0x10
		private ExNativeArray<SortData> sortAndSweepArray; // 0x18
		[CompilerGenerated]
		private int _PointPrimitiveCount_k__BackingField; // 0x20
		[CompilerGenerated]
		private int _EdgePrimitiveCount_k__BackingField; // 0x24
		[CompilerGenerated]
		private int _TrianglePrimitiveCount_k__BackingField; // 0x28
		private NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x30
		private NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x48
		private NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x58
		private NativeList<PointTriangleContact> pointTriangleContactList; // 0x70
		private NativeArray<byte> intersectFlagArray; // 0x80
		[CompilerGenerated]
		private int _IntersectCount_k__BackingField; // 0x90
	
		// Properties
		public int PointPrimitiveCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		public int EdgePrimitiveCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F0020-0x00000001811F0030 0x00000001811F0030-0x00000001811F0040
		public int TrianglePrimitiveCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
		public int IntersectCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86B60-0x0000000184D86B70 0x0000000184D86BC0-0x0000000184D86BD0
	
		// Nested types
		[BurstCompile]
		private static class IntersectUpdatePrimitiveJobKernels // TypeDefIndex: 48087
		{
			// Nested types
			public unsafe delegate void IntersectUpdatePrimitiveKernel_00000145_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // TypeDefIndex: 48083; 0x0000000182BED120-0x0000000182BED140
	
			internal static class IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall // TypeDefIndex: 48084
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall(); // 0x0000000184D1C650-0x0000000184D1C660
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067c19); // 0x00000001867082D4-0x00000001867083D8
				private static IntPtr GetFunctionPointer(); // 0x00000001867083D8-0x000000018670842C
				public static void Constructor(); // 0x0000000184D1C660-0x0000000184D1C6F0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // 0x000000018670842C-0x00000001867084FC
			}
	
			public unsafe delegate void IntersectUpdatePrimitiveRangeKernel_00000146_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // TypeDefIndex: 48085; 0x0000000182BED120-0x0000000182BED140
	
			internal static class IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall // TypeDefIndex: 48086
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall(); // 0x0000000184D1C5B0-0x0000000184D1C5C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067c31); // 0x0000000186708690-0x0000000186708794
				private static IntPtr GetFunctionPointer(); // 0x0000000186708794-0x00000001867087E8
				public static void Constructor(); // 0x0000000184D1C5C0-0x0000000184D1C650
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // 0x00000001867087E8-0x00000001867088F0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void IntersectUpdatePrimitiveKernel(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // 0x0000000186707B4C-0x0000000186707BD0
			[BurstCompile]
			internal static unsafe void IntersectUpdatePrimitiveRangeKernel(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // 0x0000000186707C58-0x0000000186707CE0
			[BurstCompile]
			public static unsafe void IntersectUpdatePrimitiveKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // 0x00000001867029C0-0x0000000186703794
			[BurstCompile]
			public static unsafe void IntersectUpdatePrimitiveRangeKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // 0x0000000186707BD0-0x0000000186707C58
		}
	
		[BurstCompile]
		private static class UpdatePrimitiveJobKernels // TypeDefIndex: 48092
		{
			// Nested types
			public unsafe delegate void UpdatePrimitiveKernel_00000147_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // TypeDefIndex: 48088; 0x00000001867141C4-0x0000000186714250
	
			internal static class UpdatePrimitiveKernel_00000147_BurstDirectCall // TypeDefIndex: 48089
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdatePrimitiveKernel_00000147_BurstDirectCall(); // 0x0000000184D1B390-0x0000000184D1B3A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067c85); // 0x0000000186713DF4-0x0000000186713EF8
				private static IntPtr GetFunctionPointer(); // 0x0000000186713EF8-0x0000000186713F4C
				public static void Constructor(); // 0x0000000184D1B3A0-0x0000000184D1B430
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // 0x0000000186713F4C-0x00000001867140CC
			}
	
			public unsafe delegate void UpdatePrimitiveRangeKernel_00000148_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // TypeDefIndex: 48090; 0x000000018621C848-0x000000018621C8D4
	
			internal static class UpdatePrimitiveRangeKernel_00000148_BurstDirectCall // TypeDefIndex: 48091
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdatePrimitiveRangeKernel_00000148_BurstDirectCall(); // 0x0000000184D1B2F0-0x0000000184D1B300
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067caf); // 0x0000000186714318-0x000000018671441C
				private static IntPtr GetFunctionPointer(); // 0x000000018671441C-0x0000000186714470
				public static void Constructor(); // 0x0000000184D1B300-0x0000000184D1B390
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // 0x0000000186714470-0x000000018671461C
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void UpdatePrimitiveKernel(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // 0x0000000186713010-0x00000001867130EC
			[BurstCompile]
			internal static unsafe void UpdatePrimitiveRangeKernel(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // 0x00000001867131C0-0x000000018671329C
			[BurstCompile]
			public static unsafe void UpdatePrimitiveKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // 0x00000001867127BC-0x0000000186713010
			[BurstCompile]
			public static unsafe void UpdatePrimitiveRangeKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // 0x00000001867130EC-0x00000001867131C0
		}
	
		[BurstCompile]
		private static class ClearBufferJobKernels // TypeDefIndex: 48095
		{
			// Nested types
			public delegate void ClearBufferKernel_00000149_PostfixBurstDelegate(); // TypeDefIndex: 48093; 0x00000001853DEDB8-0x00000001853DEDC8
	
			internal static class ClearBufferKernel_00000149_BurstDirectCall // TypeDefIndex: 48094
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearBufferKernel_00000149_BurstDirectCall(); // 0x0000000184D1CBF0-0x0000000184D1CC00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067cc1); // 0x00000001867052B0-0x00000001867053B4
				private static IntPtr GetFunctionPointer(); // 0x00000001867053B4-0x0000000186705408
				public static void Constructor(); // 0x0000000184D1CC00-0x0000000184D1CC90
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static void Invoke(); // 0x0000000186705408-0x000000018670546C
			}
	
			// Methods
			[BurstCompile]
			internal static void ClearBufferKernel(); // 0x00000001867051E0-0x0000000186705220
			[BurstCompile]
			public static void ClearBufferKernel_BurstManaged(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[BurstCompile]
		private static class SortJobKernels // TypeDefIndex: 48100
		{
			// Nested types
			public unsafe delegate void SortKernel_0000014A_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // TypeDefIndex: 48096; 0x00000001815547C0-0x00000001815547E0
	
			internal static class SortKernel_0000014A_BurstDirectCall // TypeDefIndex: 48097
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SortKernel_0000014A_BurstDirectCall(); // 0x0000000184D1BB10-0x0000000184D1BB20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067cdf); // 0x0000000186710788-0x000000018671088C
				private static IntPtr GetFunctionPointer(); // 0x000000018671088C-0x00000001867108E0
				public static void Constructor(); // 0x0000000184D1BB20-0x0000000184D1BBB0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // 0x00000001867108E0-0x0000000186710990
			}
	
			public unsafe delegate void SortRangeKernel_0000014B_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // TypeDefIndex: 48098; 0x00000001815547C0-0x00000001815547E0
	
			internal static class SortRangeKernel_0000014B_BurstDirectCall // TypeDefIndex: 48099
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SortRangeKernel_0000014B_BurstDirectCall(); // 0x0000000184D1BA70-0x0000000184D1BA80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067cf1); // 0x0000000186710B00-0x0000000186710C04
				private static IntPtr GetFunctionPointer(); // 0x0000000186710C04-0x0000000186710C58
				public static void Constructor(); // 0x0000000184D1BA80-0x0000000184D1BB10
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // 0x0000000186710C58-0x0000000186710D24
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SortKernel(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // 0x00000001867101D8-0x000000018671024C
			[BurstCompile]
			internal static unsafe void SortRangeKernel(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // 0x00000001867102B0-0x0000000186710324
			[BurstCompile]
			public static unsafe void SortKernel_BurstManaged(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // 0x000000018670FF20-0x00000001867101D8
			[BurstCompile]
			public static unsafe void SortRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // 0x000000018671024C-0x00000001867102B0
		}
	
		public enum SelfCollisionMode // TypeDefIndex: 48101
		{
			None = 0,
			FullMesh = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 48102
		{
			// Fields
			public SelfCollisionMode selfMode; // 0x10
			public CurveSerializeData surfaceThickness; // 0x18
			public SelfCollisionMode syncMode; // 0x20
			public BeyondBoneCloth syncPartner; // 0x28
			[Range(0f, 1f)]
			public float clothMass; // 0x30
	
			// Constructors
			public SerializeData(); // 0x00000001837DB7E0-0x00000001837DB880
	
			// Methods
			public void DataValidate(); // 0x000000018670DFC8-0x000000018670E040
			public SerializeData Clone(); // 0x000000018670DEF4-0x000000018670DFC8
			public BeyondBoneCloth GetSyncPartner(); // 0x000000018308D1C0-0x000000018308D200
		}
	
		public struct SelfCollisionConstraintParams // TypeDefIndex: 48103
		{
			// Fields
			public SelfCollisionMode selfMode; // 0x00
			public float4x4 surfaceThicknessCurveData; // 0x04
			public SelfCollisionMode syncMode; // 0x44
			public float clothMass; // 0x48
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x000000018308BDC0-0x000000018308BE70
		}
	
		private struct Primitive // TypeDefIndex: 48104
		{
			// Fields
			public uint flagAndTeamId; // 0x00
			public int sortIndex; // 0x04
			public int3 particleIndices; // 0x08
			public double3x3 nextPos; // 0x18
			public double3x3 oldPos; // 0x60
			public float3 invMass; // 0xA8
			public float thickness; // 0xB4
	
			// Methods
			public bool IsIgnore(); // 0x000000018670C384-0x000000018670C390
			public bool HasParticle(int p); // 0x000000018670C330-0x000000018670C384
			public uint GetKind(); // 0x0000000184D872F0-0x0000000184D87300
			public int GetTeamId(); // 0x0000000184D87320-0x0000000184D87330
			public float GetSolveThickness([IsReadOnly] in Primitive pri); // 0x0000000184D87300-0x0000000184D87320
			public bool AnyParticle([IsReadOnly] in Primitive pri); // 0x0000000186703878-0x00000001867038E8
		}
	
		private struct SortData : IComparable<SortData> // TypeDefIndex: 48105
		{
			// Fields
			public uint flagAndTeamId; // 0x00
			public int primitiveIndex; // 0x04
			public double2 firstMinMax; // 0x08
			public double2 secondMinMax; // 0x18
			public double2 thirdMinMax; // 0x28
	
			// Methods
			public int CompareTo(SortData other); // 0x000000018670FE90-0x000000018670FF20
			public uint GetKind(); // 0x0000000184D872F0-0x0000000184D87300
		}
	
		internal struct EdgeEdgeContact // TypeDefIndex: 48106
		{
			// Fields
			public uint flagAndTeamId0; // 0x00
			public uint flagAndTeamId1; // 0x04
			public half thickness; // 0x08
			public half s; // 0x0A
			public half t; // 0x0C
			public half3 n; // 0x0E
			public half2 edgeInvMass0; // 0x14
			public half2 edgeInvMass1; // 0x18
			public int2 edgeParticleIndex0; // 0x1C
			public int2 edgeParticleIndex1; // 0x24
	
			// Methods
			public override string ToString(); // 0x0000000186706450-0x000000018670666C
			public string __iFixBaseProxy_ToString(); // 0x000000018670666C-0x00000001867066D4
		}
	
		internal struct PointTriangleContact // TypeDefIndex: 48107
		{
			// Fields
			public uint flagAndTeamId0; // 0x00
			public uint flagAndTeamId1; // 0x04
			public half thickness; // 0x08
			public half sign; // 0x0A
			public int pointParticleIndex; // 0x0C
			public int3 triangleParticleIndex; // 0x10
			public half pointInvMass; // 0x1C
			public half3 triangleInvMass; // 0x1E
	
			// Methods
			public override string ToString(); // 0x000000018670BF94-0x000000018670C1D8
			public string __iFixBaseProxy_ToString(); // 0x000000018670C1D8-0x000000018670C238
		}
	
		[BurstCompile]
		private struct InitPrimitiveJob : IJobParallelFor // TypeDefIndex: 48108
		{
			// Fields
			public int teamId; // 0x00
			public TeamManager.TeamData tdata; // 0x08
			public uint kind; // 0x1D8
			public int startPrimitive; // 0x1DC
			public int startSort; // 0x1E0
			[ReadOnly]
			public NativeArray<int2> edges; // 0x1E8
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x1F8
			[NativeDisableParallelForRestriction]
			public NativeArray<Primitive> primitiveArray; // 0x208
			[NativeDisableParallelForRestriction]
			public NativeArray<SortData> sortArray; // 0x218
	
			// Methods
			public void Execute(int index); // 0x00000001867067CC-0x0000000186706A88
		}
	
		[BurstCompile]
		private struct ClearBufferJob : IJob // TypeDefIndex: 48109
		{
			// Fields
			[WriteOnly]
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x00
			[WriteOnly]
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x18
	
			// Methods
			public void Execute(); // 0x0000000186705220-0x00000001867052B0
		}
	
		[BurstCompile]
		private struct UpdatePrimitiveJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48110
		{
			// Fields
			public uint kind; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x18
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x28
			[ReadOnly]
			public NativeArray<float> depthArray; // 0x38
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x48
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0x58
			[ReadOnly]
			public NativeArray<float> frictionArray; // 0x68
			[NativeDisableParallelForRestriction]
			public NativeArray<Primitive> primitiveArray; // 0x78
			[NativeDisableParallelForRestriction]
			public NativeArray<SortData> sortAndSweepArray; // 0x88
			[ReadOnly]
			public NativeArray<uint> processingArray; // 0x98
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xA8
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000186713C10-0x0000000186713C7C
			[IDTag(1)]
			public void Execute(); // 0x0000000186713B78-0x0000000186713C10
			[IDTag(0)]
			public void Execute(int index); // 0x000000018671329C-0x0000000186713B78
			public void UnsafeDo(); // 0x0000000186713C7C-0x0000000186713DF4
		}
	
		[BurstCompile]
		private struct SortJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48111
		{
			// Fields
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeArray<Primitive> primitiveArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<SortData> sortAndSweepArray; // 0x20
			[ReadOnly]
			public int _indexCount; // 0x30
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000186710698-0x00000001867106F0
			[IDTag(1)]
			public void Execute(); // 0x0000000186710624-0x0000000186710698
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186710324-0x0000000186710624
			public void UnsafeDo(); // 0x00000001867106F0-0x0000000186710788
		}
	
		[BurstCompile]
		private struct PointTriangleBroadPhaseJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 48112
		{
			// Fields
			public uint mainKind; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x18
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x28
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x38
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0x48
			[ReadOnly]
			public NativeArray<float> frictionArray; // 0x58
			[ReadOnly]
			public NativeArray<Primitive> primitiveArray; // 0x68
			[ReadOnly]
			public NativeArray<SortData> sortAndSweepArray; // 0x78
			[ReadOnly]
			public NativeArray<uint> processingPointTriangleArray; // 0x88
			[WriteOnly]
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x98
			[ReadOnly]
			public NativeArray<byte> intersectFlagArray; // 0xB0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xC0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x000000018670BBA4-0x000000018670BC10
			[IDTag(1)]
			public void Execute(); // 0x000000018670BB0C-0x000000018670BBA4
			[IDTag(0)]
			public void Execute(int index); // 0x000000018670B1F0-0x000000018670BB0C
			private void SweepTest(int sortIndex, ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck); // 0x000000018670BC10-0x000000018670BF94
			private void BroadPointTriangle(ref Primitive p_pri, ref Primitive t_pri, float thickness, float scr, float ang); // 0x000000018670AB98-0x000000018670B1F0
		}
	
		[BurstCompile]
		private struct EdgeEdgeBroadPhaseJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 48113
		{
			// Fields
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[ReadOnly]
			public NativeArray<Primitive> primitiveArray; // 0x10
			[ReadOnly]
			public NativeArray<SortData> sortAndSweepArray; // 0x20
			[ReadOnly]
			public NativeArray<uint> processingEdgeEdgeArray; // 0x30
			[WriteOnly]
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x40
			[ReadOnly]
			public NativeArray<byte> intersectFlagArray; // 0x58
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x68
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x00000001867060E4-0x000000018670614C
			[IDTag(1)]
			public void Execute(); // 0x000000018670599C-0x0000000186705A30
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186705A30-0x00000001867060E4
			private void SweepTest(int sortIndex, ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck); // 0x000000018670614C-0x0000000186706450
			private void BroadEdgeEdge(ref Primitive pri0, ref Primitive pri1, float thickness, float scr); // 0x000000018670546C-0x000000018670599C
		}
	
		[BurstCompile]
		private struct EdgeEdgeToListJob : IJob // TypeDefIndex: 48114
		{
			// Fields
			[ReadOnly]
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001867066D4-0x00000001867067CC
		}
	
		[BurstCompile]
		private struct PointTriangleToListJob : IJob // TypeDefIndex: 48115
		{
			// Fields
			[ReadOnly]
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x18
	
			// Methods
			public void Execute(); // 0x000000018670C238-0x000000018670C330
		}
	
		[BurstCompile]
		private struct UpdateEdgeEdgeBroadPhaseJob : IJobParallelForDefer // TypeDefIndex: 48116
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<float3> oldPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x20
	
			// Methods
			public void Execute(int index); // 0x0000000186711430-0x0000000186711B5C
		}
	
		[BurstCompile]
		private struct UpdatePointTriangleBroadPhaseJob : IJobParallelForDefer // TypeDefIndex: 48117
		{
			// Fields
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x20
	
			// Methods
			public void Execute(int index); // 0x00000001867121D8-0x00000001867127BC
		}
	
		[BurstCompile]
		private struct SolverEdgeEdgeJob : IJobParallelForDefer // TypeDefIndex: 48118
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<EdgeEdgeContact> edgeEdgeContactArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			public void Execute(int index); // 0x000000018670E8DC-0x000000018670EF00
		}
	
		[BurstCompile]
		private struct SolverPointTriangleJob : IJobParallelForDefer // TypeDefIndex: 48119
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<PointTriangleContact> pointTriangleContactArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			public void Execute(int index); // 0x000000018670F60C-0x000000018670FE90
		}
	
		[BurstCompile]
		private struct IntersectUpdatePrimitiveJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48120
		{
			// Fields
			public uint kind; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x18
			[NativeDisableParallelForRestriction]
			public NativeArray<Primitive> primitiveArray; // 0x28
			[ReadOnly]
			public NativeArray<uint> processingArray; // 0x38
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x48
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x00000001867081A8-0x0000000186708210
			[IDTag(1)]
			public void Execute(); // 0x0000000186708114-0x00000001867081A8
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186707CE0-0x0000000186708114
			public void UnsafeDo(); // 0x0000000186708210-0x00000001867082D4
		}
	
		[BurstCompile]
		private struct IntersectEdgeTriangleJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 48121
		{
			// Fields
			public uint mainKind; // 0x00
			public int execNumber; // 0x04
			public int div; // 0x08
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<Primitive> primitiveArray; // 0x20
			[ReadOnly]
			public NativeArray<SortData> sortAndSweepArray; // 0x30
			[ReadOnly]
			public NativeArray<uint> processingEdgeEdgeArray; // 0x40
			[NativeDisableParallelForRestriction]
			public NativeArray<byte> intersectFlagArray; // 0x50
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x60
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000186707810-0x0000000186707878
			[IDTag(1)]
			public void Execute(); // 0x0000000186707384-0x0000000186707418
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186706A88-0x0000000186707384
			private void SweepTest(ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck); // 0x0000000186707878-0x0000000186707B4C
			private void IntersectTest(ref Primitive epri, ref Primitive tpri); // 0x0000000186707418-0x0000000186707810
		}
	
		[BurstCompile]
		private static class SolverPointTriangleCrossFrameJobKernels // TypeDefIndex: 48126
		{
			// Nested types
			public unsafe delegate void SolverPointTriangleCrossFrameKernel_0000017E_PostfixBurstDelegate(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 48122; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall // TypeDefIndex: 48123
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall(); // 0x0000000184D1BC50-0x0000000184D1BC60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067d49); // 0x000000018670F064-0x000000018670F168
				private static IntPtr GetFunctionPointer(); // 0x000000018670F168-0x000000018670F1BC
				public static void Constructor(); // 0x0000000184D1BC60-0x0000000184D1BCF0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // 0x000000018670F1BC-0x000000018670F280
			}
	
			public unsafe delegate void SolverPointTriangleCrossFrameRangeKernel_0000017F_PostfixBurstDelegate(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 48124; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall // TypeDefIndex: 48125
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall(); // 0x0000000184D1BBB0-0x0000000184D1BBC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067d5e); // 0x000000018670F32C-0x000000018670F430
				private static IntPtr GetFunctionPointer(); // 0x000000018670F430-0x000000018670F484
				public static void Constructor(); // 0x0000000184D1BBC0-0x0000000184D1BC50
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // 0x000000018670F484-0x000000018670F560
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolverPointTriangleCrossFrameKernel(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // 0x000000018670EF00-0x000000018670EF7C
			[BurstCompile]
			internal static unsafe void SolverPointTriangleCrossFrameRangeKernel(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // 0x000000018670EFE8-0x000000018670F064
			[BurstCompile]
			public static unsafe void SolverPointTriangleCrossFrameKernel_BurstManaged(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // 0x0000000186703FDC-0x00000001867051E0
			[BurstCompile]
			public static unsafe void SolverPointTriangleCrossFrameRangeKernel_BurstManaged(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // 0x000000018670EF7C-0x000000018670EFE8
		}
	
		[BurstCompile]
		private static class SolverEdgeEdgeCrossFrameJobKernels // TypeDefIndex: 48131
		{
			// Nested types
			public unsafe delegate void SolverEdgeEdgeCrossFrameKernel_00000180_PostfixBurstDelegate(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 48127; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall // TypeDefIndex: 48128
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall(); // 0x0000000184D1BD90-0x0000000184D1BDA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067d87); // 0x000000018670E260-0x000000018670E364
				private static IntPtr GetFunctionPointer(); // 0x000000018670E364-0x000000018670E3B8
				public static void Constructor(); // 0x0000000184D1BDA0-0x0000000184D1BE30
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // 0x000000018670E3B8-0x000000018670E47C
			}
	
			public unsafe delegate void SolverEdgeEdgeCrossFrameRangeKernel_00000181_PostfixBurstDelegate(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 48129; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall // TypeDefIndex: 48130
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall(); // 0x0000000184D1BCF0-0x0000000184D1BD00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067d9c); // 0x000000018670E5FC-0x000000018670E700
				private static IntPtr GetFunctionPointer(); // 0x000000018670E700-0x000000018670E754
				public static void Constructor(); // 0x0000000184D1BD00-0x0000000184D1BD90
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // 0x000000018670E754-0x000000018670E830
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolverEdgeEdgeCrossFrameKernel(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // 0x000000018670E0FC-0x000000018670E178
			[BurstCompile]
			internal static unsafe void SolverEdgeEdgeCrossFrameRangeKernel(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // 0x000000018670E1E4-0x000000018670E260
			[BurstCompile]
			public static unsafe void SolverEdgeEdgeCrossFrameKernel_BurstManaged(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // 0x00000001867038E8-0x0000000186703FDC
			[BurstCompile]
			public static unsafe void SolverEdgeEdgeCrossFrameRangeKernel_BurstManaged(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // 0x000000018670E178-0x000000018670E1E4
		}
	
		[BurstCompile]
		private struct UpdateEdgeEdgeBroadPhaseCrossFrameJob : IJob // TypeDefIndex: 48132
		{
			// Fields
			[ReadOnly]
			public NativeReference<int> indexCount; // 0x00
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x10
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x30
	
			// Methods
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186710E54-0x0000000186711430
			[IDTag(1)]
			public void Execute(); // 0x0000000186710DC0-0x0000000186710E54
		}
	
		[BurstCompile]
		private struct UpdatePointTriangleBroadPhaseCrossFrameJob : IJob // TypeDefIndex: 48133
		{
			// Fields
			[ReadOnly]
			public NativeReference<int> indexCount; // 0x00
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x10
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x30
	
			// Methods
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186711B5C-0x0000000186712144
			[IDTag(1)]
			public void Execute(); // 0x0000000186712144-0x00000001867121D8
		}
	
		[BurstCompile]
		private struct SolverEdgeEdgeCrossFrameJob : IJob, IUnsafeJob // TypeDefIndex: 48134
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<EdgeEdgeContact> edgeEdgeContactArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			[IDTag(0)]
			public void Execute(int index); // 0x000000018671BD84-0x000000018671C4D0
			[IDTag(1)]
			public void Execute(); // 0x000000018671BD10-0x000000018671BD84
			public void UnsafeDo(); // 0x000000018671C4D0-0x000000018671C570
		}
	
		[BurstCompile]
		private struct SolverPointTriangleCrossFrameJob : IJob, IUnsafeJob // TypeDefIndex: 48135
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<PointTriangleContact> pointTriangleContactArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			[IDTag(0)]
			public void Execute(int index); // 0x000000018671C570-0x000000018671CCAC
			[IDTag(1)]
			public void Execute(); // 0x000000018671CCAC-0x000000018671CD20
			public void UnsafeDo(); // 0x000000018671CD20-0x000000018671CDC0
		}
	
		// Constructors
		public SelfCollisionConstraint(); // 0x0000000183E8B400-0x0000000183E8B740
	
		// Methods
		public void Dispose(); // 0x000000018670C480-0x000000018670C5E0
		public bool HasPrimitive(); // 0x0000000182F91450-0x0000000182F914D0
		public override string ToString(); // 0x000000018670D884-0x000000018670DC40
		internal void Register(ClothProcess cprocess); // 0x0000000183E8C600-0x0000000183E8C650
		internal void Exit(ClothProcess cprocess); // 0x0000000183CF33F0-0x0000000183CF3440
		internal void UpdateTeam(int teamId); // 0x00000001837ECCE0-0x00000001837ED1E0
		private void InitPrimitive(int teamId, TeamManager.TeamData tdata, uint kind, int startPrimitive, int startSort, int length); // 0x000000018670C5E0-0x000000018670C93C
		internal void WorkBufferUpdate(); // 0x0000000182F8A660-0x0000000182F8A690
		private static int BinarySearchSortAndlSweep(ref NativeArray<SortData> sortAndSweepArray, [IsReadOnly] in SortData sd, [IsReadOnly] in DataChunk chunk); // 0x000000018670C390-0x000000018670C480
		internal JobHandle SolverConstraint(int updateIndex, JobHandle jobHandle); // 0x0000000182F91160-0x0000000182F91240
		private JobHandle SolverRuntimeSelfCollision(int updateIndex, JobHandle jobHandle); // 0x0000000182F91300-0x0000000182F91450
		private JobHandle SolverBroadPhase(JobHandle jobHandle); // 0x000000018670C93C-0x000000018670D884
		private JobHandle UpdateBroadPhase(JobHandle jobHandle); // 0x000000018670DC40-0x000000018670DE0C
		private JobHandle SolveIntersect(JobHandle jobHandle); // 0x0000000182F91240-0x0000000182F91300
		public static void Initialize_IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall(); // 0x00000001844F63F0-0x00000001844F6450
		public static void Initialize_IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall(); // 0x00000001844F6450-0x00000001844F64B0
		public static void Initialize_UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147_BurstDirectCall(); // 0x00000001844F64B0-0x00000001844F6510
		public static void Initialize_UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148_BurstDirectCall(); // 0x00000001844F6510-0x00000001844F6570
		public static void Initialize_ClearBufferJobKernels_ClearBufferKernel_00000149_BurstDirectCall(); // 0x00000001844F6570-0x00000001844F65D0
		public static void Initialize_SortJobKernels_SortKernel_0000014A_BurstDirectCall(); // 0x00000001844F65D0-0x00000001844F6630
		public static void Initialize_SortJobKernels_SortRangeKernel_0000014B_BurstDirectCall(); // 0x00000001844F6630-0x00000001844F6690
		public static void Initialize_SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall(); // 0x00000001844F6690-0x00000001844F66F0
		public static void Initialize_SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall(); // 0x00000001844F66F0-0x00000001844F6750
		public static void Initialize_SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall(); // 0x00000001844F6750-0x00000001844F67B0
		public static void Initialize_SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall(); // 0x00000001844F67B0-0x00000001844F6810
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public class SpringConstraint : IDisposable // TypeDefIndex: 48139
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 48137
		{
			// Fields
			public bool useSpring; // 0x10
			[Range(0.001f, 0.2f)]
			public float springPower; // 0x14
			[Range(0f, 0.5f)]
			public float limitDistance; // 0x18
			[Range(0f, 1f)]
			public float normalLimitRatio; // 0x1C
			[Range(0f, 1f)]
			public float springNoise; // 0x20
	
			// Constructors
			public SerializeData(); // 0x0000000184D87340-0x0000000184D87360
	
			// Methods
			public void DataValidate(); // 0x000000018671A424-0x000000018671A4F0
			public SerializeData Clone(); // 0x000000018671A218-0x000000018671A2DC
		}
	
		public struct SpringConstraintParams // TypeDefIndex: 48138
		{
			// Fields
			public float springPower; // 0x00
			public float limitDistance; // 0x04
			public float normalLimitRatio; // 0x08
			public float springNoise; // 0x0C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x000000018308C070-0x000000018308C0E0
		}
	
		// Constructors
		public SpringConstraint(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x000000018671CDC0-0x000000018671CE04
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x000000018671CE04-0x000000018671CE88
	}

	[BurstCompile]
	internal static class TethreConstraintJobKernels // TypeDefIndex: 48144
	{
		// Nested types
		public unsafe delegate void TethreConstraintKernel_00000193_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // TypeDefIndex: 48140; 0x000000018670A4E0-0x000000018670A57C
	
		internal static class TethreConstraintKernel_00000193_BurstDirectCall // TypeDefIndex: 48141
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static TethreConstraintKernel_00000193_BurstDirectCall(); // 0x0000000184D1B9D0-0x0000000184D1B9E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067dfc); // 0x000000018671DC68-0x000000018671DD6C
			private static IntPtr GetFunctionPointer(); // 0x000000018671DD6C-0x000000018671DDC0
			public static void Constructor(); // 0x0000000184D1B9E0-0x0000000184D1BA70
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // 0x000000018671DDC0-0x000000018671DF44
		}
	
		public unsafe delegate void TethreConstraintRangeKernel_00000194_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // TypeDefIndex: 48142; 0x000000018670A9E0-0x000000018670AA80
	
		internal static class TethreConstraintRangeKernel_00000194_BurstDirectCall // TypeDefIndex: 48143
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static TethreConstraintRangeKernel_00000194_BurstDirectCall(); // 0x0000000184D1B930-0x0000000184D1B940
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00067e29); // 0x000000018671E030-0x000000018671E134
			private static IntPtr GetFunctionPointer(); // 0x000000018671E134-0x000000018671E188
			public static void Constructor(); // 0x0000000184D1B940-0x0000000184D1B9D0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // 0x000000018671E188-0x000000018671E330
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void TethreConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // 0x000000018671D378-0x000000018671D460
		[BurstCompile]
		internal static unsafe void TethreConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // 0x000000018671D460-0x000000018671D54C
		[BurstCompile]
		public static unsafe void TethreConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // 0x000000018671CF10-0x000000018671D378
		[BurstCompile]
		public static unsafe void TethreConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // 0x000000018671557C-0x0000000186715CBC
	}

	public class TetherConstraint : IDisposable // TypeDefIndex: 48148
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 48145
		{
			// Fields
			[Range(0f, 1f)]
			public float distanceCompression; // 0x10
	
			// Constructors
			public SerializeData(); // 0x0000000184D87360-0x0000000184D87370
	
			// Methods
			public void DataValidate(); // 0x000000018671A364-0x000000018671A3D0
			public SerializeData Clone(); // 0x000000018671A2DC-0x000000018671A364
		}
	
		public struct TetherConstraintParams // TypeDefIndex: 48146
		{
			// Fields
			public float compressionLimit; // 0x00
			public float stretchLimit; // 0x04
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x000000018308BED0-0x000000018308BF30
		}
	
		[BurstCompile]
		private struct TethreConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48147
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> stepParticleIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x20
			[ReadOnly]
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x30
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x40
			[ReadOnly]
			public NativeArray<float> vertexDepths; // 0x50
			[ReadOnly]
			public NativeArray<int> vertexRootIndices; // 0x60
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x70
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x80
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0x90
			[ReadOnly]
			public NativeArray<float> frictionArray; // 0xA0
			[ReadOnly]
			public NativeArray<double3> stepBasicPositionBuffer; // 0xB0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xC0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183BB72A0-0x0000000183BB7320
			[IDTag(1)]
			public void Execute(); // 0x000000018671D54C-0x000000018671D5E4
			[IDTag(0)]
			public void Execute(int index); // 0x000000018671D5E4-0x000000018671DAC4
			public void UnsafeDo(); // 0x000000018671DAC4-0x000000018671DC68
		}
	
		// Constructors
		public TetherConstraint(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x000000018671CECC-0x000000018671CF10
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x0000000182F8DF00-0x0000000182F8E3A0
	}

	public class TriangleBendingConstraint : IDisposable // TypeDefIndex: 48165
	{
		// Fields
		private const sbyte VOLUME_SIGN = 100; // Metadata: 0x0232CD8C
		public ExNativeArray<ulong> trianglePairArray; // 0x10
		public ExNativeArray<float> restAngleOrVolumeArray; // 0x18
		public ExNativeArray<sbyte> signOrVolumeArray; // 0x20
		public ExNativeArray<uint> writeDataArray; // 0x28
		public ExNativeArray<uint> writeIndexArray; // 0x30
		public ExNativeArray<float3> writeBuffer; // 0x38
		private const float VolumeScale = 1000f; // Metadata: 0x0232CD8D
	
		// Properties
		public int DataCount { get; } // 0x0000000182F8D9E0-0x0000000182F8DA50 
	
		// Nested types
		[BurstCompile]
		private static class TriangleBendingJobKernels // TypeDefIndex: 48153
		{
			// Nested types
			public unsafe delegate void TriangleBendingKernel_000001AA_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // TypeDefIndex: 48149; 0x000000018669C9B4-0x000000018669CA68
	
			internal static class TriangleBendingKernel_000001AA_BurstDirectCall // TypeDefIndex: 48150
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static TriangleBendingKernel_000001AA_BurstDirectCall(); // 0x0000000184D1B890-0x0000000184D1B8A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067eb9); // 0x0000000186722388-0x000000018672248C
				private static IntPtr GetFunctionPointer(); // 0x000000018672248C-0x00000001867224E0
				public static void Constructor(); // 0x0000000184D1B8A0-0x0000000184D1B930
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x00000001867224E0-0x00000001867226C4
			}
	
			public unsafe delegate void TriangleBendingRangeKernel_000001AB_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // TypeDefIndex: 48151; 0x000000018669CF20-0x000000018669CFD8
	
			internal static class TriangleBendingRangeKernel_000001AB_BurstDirectCall // TypeDefIndex: 48152
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static TriangleBendingRangeKernel_000001AB_BurstDirectCall(); // 0x0000000184D1B7F0-0x0000000184D1B800
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067eec); // 0x00000001867227C8-0x00000001867228CC
				private static IntPtr GetFunctionPointer(); // 0x00000001867228CC-0x0000000186722920
				public static void Constructor(); // 0x0000000184D1B800-0x0000000184D1B890
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x0000000186722920-0x0000000186722B04
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void TriangleBendingKernel(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x000000018671FEBC-0x000000018671FFC4
			[BurstCompile]
			internal static unsafe void TriangleBendingRangeKernel(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x000000018671FFC4-0x00000001867200D0
			private static bool Volume([IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double volumeRest, double stiffness, ref double3x4 addPosBuffer); // 0x00000001867200D0-0x0000000186720818
			private static bool DihedralAngle(double sign, [IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double restAngle, double stiffness, ref double3x4 addPosBuffer); // 0x000000018671EDF0-0x000000018671F860
			[BurstCompile]
			public static unsafe void TriangleBendingKernel_BurstManaged(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x000000018671F860-0x000000018671FEBC
			[BurstCompile]
			public static unsafe void TriangleBendingRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x0000000186715CBC-0x0000000186715E00
		}
	
		[BurstCompile]
		private static class SolveAggregateBufferJobKernels // TypeDefIndex: 48158
		{
			// Nested types
			public unsafe delegate void SolveAggregateBufferKernel_000001AE_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // TypeDefIndex: 48154; 0x000000018671B804-0x000000018671B860
	
			internal static class SolveAggregateBufferKernel_000001AE_BurstDirectCall // TypeDefIndex: 48155
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveAggregateBufferKernel_000001AE_BurstDirectCall(); // 0x0000000184D1C010-0x0000000184D1C020
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067f31); // 0x000000018671B4E0-0x000000018671B5E4
				private static IntPtr GetFunctionPointer(); // 0x000000018671B5E4-0x000000018671B638
				public static void Constructor(); // 0x0000000184D1C020-0x0000000184D1C0B0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x000000018671B638-0x000000018671B74C
			}
	
			public unsafe delegate void SolveAggregateBufferRangeKernel_000001AF_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // TypeDefIndex: 48156; 0x000000018621EEA4-0x000000018621EF00
	
			internal static class SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall // TypeDefIndex: 48157
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall(); // 0x0000000184D1BF70-0x0000000184D1BF80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00067f4f); // 0x000000018671B934-0x000000018671BA38
				private static IntPtr GetFunctionPointer(); // 0x000000018671BA38-0x000000018671BA8C
				public static void Constructor(); // 0x0000000184D1BF80-0x0000000184D1C010
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x000000018671BA8C-0x000000018671BBC8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolveAggregateBufferKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x000000018671AE1C-0x000000018671AEC4
			[BurstCompile]
			internal static unsafe void SolveAggregateBufferRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x000000018671AF68-0x000000018671B010
			[BurstCompile]
			public static unsafe void SolveAggregateBufferKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x000000018671AB90-0x000000018671AE1C
			[BurstCompile]
			public static unsafe void SolveAggregateBufferRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x000000018671AEC4-0x000000018671AF68
		}
	
		public enum Method // TypeDefIndex: 48159
		{
			None = 0,
			DihedralAngle = 1,
			DirectionDihedralAngle = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 48160
		{
			// Fields
			[Range(0f, 1f)]
			public float stiffness; // 0x10
	
			// Constructors
			public SerializeData(); // 0x0000000184D87330-0x0000000184D87340
	
			// Methods
			public void DataValidate(); // 0x000000018671A3D0-0x000000018671A424
			public SerializeData Clone(); // 0x000000018671A190-0x000000018671A218
		}
	
		public struct TriangleBendingConstraintParams // TypeDefIndex: 48161
		{
			// Fields
			public Method method; // 0x00
			public float stiffness; // 0x04
	
			// Methods
			public void Convert(SerializeData sdata); // 0x000000018308BF30-0x000000018308BF90
		}
	
		[Serializable]
		public class ConstraintData : IValid // TypeDefIndex: 48162
		{
			// Fields
			public ResultCode result; // 0x10
			public ulong[] trianglePairArray; // 0x18
			public float[] restAngleOrVolumeArray; // 0x20
			public sbyte[] signOrVolumeArray; // 0x28
			public int writeBufferCount; // 0x30
			public uint[] writeDataArray; // 0x38
			public uint[] writeIndexArray; // 0x40
	
			// Constructors
			public ConstraintData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public bool IsValid(); // 0x0000000183E8CC80-0x0000000183E8CCC0
		}
	
		[BurstCompile]
		private struct TriangleBendingJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48163
		{
			// Fields
			public float4 simulationPower; // 0x00
			[ReadOnly]
			public NativeArray<int> stepTriangleBendIndexArray; // 0x10
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x20
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x30
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x40
			[ReadOnly]
			public NativeArray<float> depthArray; // 0x50
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x60
			[ReadOnly]
			public NativeArray<float> frictionArray; // 0x70
			[ReadOnly]
			public NativeArray<ulong> trianglePairArray; // 0x80
			[ReadOnly]
			public NativeArray<float> restAngleOrVolumeArray; // 0x90
			[ReadOnly]
			public NativeArray<sbyte> signOrVolumeArray; // 0xA0
			[ReadOnly]
			public NativeArray<uint> writeDataArray; // 0xB0
			[ReadOnly]
			public NativeArray<uint> writeIndexArray; // 0xC0
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> writeBuffer; // 0xD0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xE0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x00000001867219B8-0x0000000186721A24
			[IDTag(1)]
			public void Execute(); // 0x0000000186721920-0x00000001867219B8
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186721288-0x0000000186721920
			private bool Volume([IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double volumeRest, double stiffness, ref double3x4 addPosBuffer); // 0x0000000186721C3C-0x0000000186722388
			private bool DihedralAngle(double sign, [IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double restAngle, double stiffness, ref double3x4 addPosBuffer); // 0x0000000186720818-0x0000000186721288
			public void UnsafeDo(); // 0x0000000186721A24-0x0000000186721C3C
		}
	
		[BurstCompile]
		private struct SolveAggregateBufferJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48164
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> stepParticleIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x20
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x40
			[ReadOnly]
			public NativeArray<uint> writeIndexArray; // 0x50
			[ReadOnly]
			public NativeArray<float3> writeBuffer; // 0x60
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x70
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x000000018671B368-0x000000018671B3D0
			[IDTag(1)]
			public void Execute(); // 0x000000018671B010-0x000000018671B0A4
			[IDTag(0)]
			public void Execute(int index); // 0x000000018671B0A4-0x000000018671B368
			public void UnsafeDo(); // 0x000000018671B3D0-0x000000018671B4E0
		}
	
		// Constructors
		public TriangleBendingConstraint(); // 0x0000000183E86F80-0x0000000183E87400
	
		// Methods
		public void Dispose(); // 0x000000018671E3F8-0x000000018671E538
		public override string ToString(); // 0x000000018671EB5C-0x000000018671EDF0
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters); // 0x0000000184434220-0x00000001844358C0
		private static void InitVolume(VirtualMesh proxyMesh, int v0, int v1, int v2, int v3, out float volumeRest, out sbyte signFlag); // 0x000000018671E89C-0x000000018671EB5C
		private static void InitDihedralAngle(VirtualMesh proxyMesh, int v0, int v1, int v2, int v3, out float restAngle, out sbyte signFlag); // 0x000000018671E538-0x000000018671E89C
		internal void Register(ClothProcess cprocess); // 0x0000000183E8C650-0x0000000183E8C740
		internal void Exit(ClothProcess cprocess); // 0x0000000183CF36E0-0x0000000183CF38B0
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x0000000182F8ED70-0x0000000182F8EF20
		public static void Initialize_TriangleBendingJobKernels_TriangleBendingKernel_000001AA_BurstDirectCall(); // 0x00000001844F6810-0x00000001844F6870
		public static void Initialize_TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB_BurstDirectCall(); // 0x00000001844F6870-0x00000001844F68D0
		public static void Initialize_SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE_BurstDirectCall(); // 0x00000001844F68D0-0x00000001844F6930
		public static void Initialize_SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall(); // 0x00000001844F6930-0x00000001844F6990
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	[Serializable]
	public class CullingSettings : IDataValidate // TypeDefIndex: 48169
	{
		// Fields
		public CameraCullingMode cameraCullingMode; // 0x10
		public CameraCullingMethod cameraCullingMethod; // 0x14
		public List<Renderer> cameraCullingRenderers; // 0x18
		public CheckSliderSerializeData distanceCullingLength; // 0x20
		[Range(0f, 1f)]
		public float distanceCullingFadeRatio; // 0x28
		public GameObject distanceCullingReferenceObject; // 0x30
	
		// Nested types
		public enum CameraCullingMode // TypeDefIndex: 48166
		{
			Off = 0,
			Reset = 10,
			Keep = 20,
			AnimatorLinkage = 30
		}
	
		public enum CameraCullingMethod // TypeDefIndex: 48167
		{
			AutomaticRenderer = 0,
			ManualRenderer = 10
		}
	
		public struct CullingParams // TypeDefIndex: 48168
		{
			// Fields
			public bool useDistanceCulling; // 0x00
			public float distanceCullingLength; // 0x04
			public float distanceCullingFadeRatio; // 0x08
	
			// Methods
			public void Convert(CullingSettings cullingSettings); // 0x000000018308BE70-0x000000018308BED0
		}
	
		// Constructors
		public CullingSettings(); // 0x00000001844337D0-0x0000000184433890
	
		// Methods
		public void DataValidate(); // 0x000000018671705C-0x00000001867170CC
		public CullingSettings Clone(); // 0x0000000186716F20-0x000000018671705C
		public override int GetHashCode(); // 0x00000001867170CC-0x0000000186717118
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
	}

	[Serializable]
	public class CurveSerializeData // TypeDefIndex: 48170
	{
		// Fields
		public float value; // 0x10
		public bool useCurve; // 0x14
		public AnimationCurve curve; // 0x18
	
		// Constructors
		public CurveSerializeData(); // 0x0000000186717578-0x00000001867175B4
		public CurveSerializeData(float value); // 0x0000000183663C40-0x0000000183663CD0
		public CurveSerializeData(float value, float curveStart, float curveEnd, bool useCurve = true /* Metadata: 0x0232CD9A */); // 0x0000000183663CD0-0x0000000183663DA0
		public CurveSerializeData(float value, AnimationCurve curve); // 0x0000000186717510-0x0000000186717578
	
		// Methods
		[IDTag(0)]
		public void SetValue(float value); // 0x00000001867173DC-0x000000018671743C
		[IDTag(1)]
		public void SetValue(float value, float curveStart, float curveEnd, bool useCurve = true /* Metadata: 0x0232CD9B */); // 0x000000018671743C-0x0000000186717510
		[IDTag(2)]
		public void SetValue(float value, AnimationCurve curve); // 0x000000018671735C-0x00000001867173DC
		public void DataValidate(float min, float max); // 0x000000018671725C-0x00000001867172E0
		public float Evaluate(float time); // 0x00000001867172E0-0x000000018671735C
		public float4x4 ConvertFloatArray(); // 0x000000018308ADC0-0x000000018308AEC0
		public CurveSerializeData Clone(); // 0x0000000186717118-0x000000018671725C
	}

	[Serializable]
	public class CustomSkinningSettings : IValid, IDataValidate, ITransform // TypeDefIndex: 48172
	{
		// Fields
		public bool enable; // 0x10
		public List<Transform> skinningBones; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 48171
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, bool> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000186722B50-0x0000000186722BB4
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _IsValid_b__3_0(Transform n); // 0x0000000186722B04-0x0000000186722B50
		}
	
		// Constructors
		public CustomSkinningSettings(); // 0x0000000184511000-0x0000000184511080
	
		// Methods
		public void DataValidate(); // 0x00000001867176A0-0x00000001867176E0
		public bool IsValid(); // 0x00000001867178D4-0x0000000186717A48
		public CustomSkinningSettings Clone(); // 0x00000001867175B4-0x00000001867176A0
		public override int GetHashCode(); // 0x00000001867176E0-0x000000018671772C
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x000000018671772C-0x00000001867178D4
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000186717A48-0x0000000186717BC4
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
	}

	[Serializable]
	public class GizmoSerializeData // TypeDefIndex: 48173
	{
		// Fields
		public bool always; // 0x10
		public ClothDebugSettings clothDebugSettings; // 0x18
	
		// Constructors
		public GizmoSerializeData(); // 0x0000000186718310-0x0000000186718388
	
		// Methods
		public bool IsAlways(); // 0x00000001867182C4-0x0000000186718310
	}

	[Serializable]
	public class NormalAlignmentSettings : IValid, IDataValidate, ITransform // TypeDefIndex: 48175
	{
		// Fields
		public AlignmentMode alignmentMode; // 0x10
		public Transform adjustmentTransform; // 0x18
	
		// Nested types
		public enum AlignmentMode // TypeDefIndex: 48174
		{
			None = 0,
			BoundingBoxCenter = 1,
			Transform = 2
		}
	
		// Constructors
		public NormalAlignmentSettings(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void DataValidate(); // 0x000000018671841C-0x000000018671845C
		public bool IsValid(); // 0x00000001867185F8-0x0000000186718648
		public NormalAlignmentSettings Clone(); // 0x0000000186718388-0x000000018671841C
		public override int GetHashCode(); // 0x000000018671845C-0x000000018671853C
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x000000018671853C-0x00000001867185F8
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000186718648-0x0000000186718750
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
	}

	[Serializable]
	public class SelectionData : IValid // TypeDefIndex: 48179
	{
		// Fields
		public float3[] positions; // 0x10
		public VertexAttribute[] attributes; // 0x18
		public float maxConnectionDistance; // 0x20
		public bool userEdit; // 0x24
	
		// Properties
		public int Count { get; } // 0x000000018671A134-0x000000018671A190 
	
		// Nested types
		[BurstCompile]
		private struct TransformPositionJob : IJobParallelFor // TypeDefIndex: 48176
		{
			// Fields
			public float4x4 transformMatrix; // 0x00
			public NativeArray<float3> localPositions; // 0x40
	
			// Methods
			public void Execute(int index); // 0x000000018671E330-0x000000018671E3F8
		}
	
		[BurstCompile]
		private struct CreateGridMapJob : IJob // TypeDefIndex: 48177
		{
			// Fields
			public bool move; // 0x00
			public bool fix; // 0x01
			public bool ignore; // 0x02
			public bool invalid; // 0x03
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x08
			public float gridSize; // 0x18
			[ReadOnly]
			public NativeArray<float3> positions; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> attribute; // 0x30
	
			// Methods
			public void Execute(); // 0x000000018431E070-0x000000018431E1A0
		}
	
		[BurstCompile]
		private struct ConvertSelectionJob : IJobParallelFor // TypeDefIndex: 48178
		{
			// Fields
			public float gridSize; // 0x00
			public float radius; // 0x04
			[ReadOnly]
			public NativeArray<float3> toPositions; // 0x08
			[WriteOnly]
			public NativeArray<VertexAttribute> toAttributes; // 0x18
			[ReadOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x28
			[ReadOnly]
			public NativeArray<float3> fromPositions; // 0x38
			[ReadOnly]
			public NativeArray<VertexAttribute> fromAttributes; // 0x48
	
			// Methods
			public void Execute(int vindex); // 0x0000000186716ABC-0x0000000186716F20
		}
	
		// Constructors
		public SelectionData(); // 0x00000001841E1670-0x00000001841E1680
		public SelectionData(int cnt); // 0x000000018671A0B8-0x000000018671A134
		public SelectionData(VirtualMesh vmesh, float4x4 transformMatrix); // 0x0000000186719DF0-0x000000018671A0B8
	
		// Methods
		public bool IsValid(); // 0x000000018455F130-0x000000018455F190
		public bool IsUserEdit(); // 0x0000000186719B6C-0x0000000186719BB8
		public SelectionData Clone(); // 0x0000000184460F70-0x00000001844610A0
		public bool Compare(SelectionData sdata); // 0x0000000186719010-0x0000000186719244
		public void AddRange(float3[] addPositions, VertexAttribute[] addAttributes = null); // 0x0000000186718E54-0x0000000186719010
		public void Fill(VertexAttribute attr); // 0x000000018671997C-0x0000000186719A00
		[IDTag(0)]
		public NativeArray<float3> GetPositionNativeArray(); // 0x00000001841EDFC0-0x00000001841EE030
		[IDTag(1)]
		public NativeArray<float3> GetPositionNativeArray(float4x4 transformMatrix); // 0x0000000186719A00-0x0000000186719B6C
		public NativeArray<VertexAttribute> GetAttributeNativeArray(); // 0x00000001841EE030-0x00000001841EE0A0
		public static GridMap<int> CreateGridMapRun(float gridSize, [IsReadOnly] in NativeArray<float3> positions, [IsReadOnly] in NativeArray<VertexAttribute> attributes, bool move = true /* Metadata: 0x0232CD9F */, bool fix = true /* Metadata: 0x0232CDA0 */, bool ignore = true /* Metadata: 0x0232CDA1 */, bool invalid = true /* Metadata: 0x0232CDA2 */); // 0x00000001841EE0A0-0x00000001841EE230
		public void Merge(SelectionData from); // 0x0000000186719BB8-0x0000000186719DF0
		public void ConvertFrom(SelectionData from); // 0x0000000186719244-0x000000018671997C
	}

	public class BeyondBoneWindZone : ClothBehaviour // TypeDefIndex: 48181
	{
		// Fields
		public Mode mode; // 0x20
		public Vector3 size; // 0x24
		public float radius; // 0x30
		[Range(0f, 30f)]
		public float main; // 0x34
		[Range(0f, 1f)]
		public float turbulence; // 0x38
		[Range(-180f, 180f)]
		public float directionAngleX; // 0x3C
		[Range(-180f, 180f)]
		public float directionAngleY; // 0x40
		public AnimationCurve attenuation; // 0x48
		public bool isAddition; // 0x50
		[CompilerGenerated]
		private int _WindId_k__BackingField; // 0x54
	
		// Properties
		public int WindId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86540-0x0000000184D86550 0x0000000184D86590-0x0000000184D865A0
	
		// Nested types
		public enum Mode // TypeDefIndex: 48180
		{
			GlobalDirection = 0,
			SphereDirection = 1,
			BoxDirection = 2,
			SphereRadial = 10
		}
	
		// Constructors
		public BeyondBoneWindZone(); // 0x0000000186716404-0x0000000186716478
	
		// Methods
		public void Awake(); // 0x0000000186715E00-0x0000000186715E90
		public void Start(); // 0x00000001867163C0-0x0000000186716404
		public void OnEnable(); // 0x00000001867161CC-0x000000018671625C
		public void OnDisable(); // 0x000000018671613C-0x00000001867161CC
		public void OnDestroy(); // 0x00000001867160AC-0x000000018671613C
		public bool IsDirection(); // 0x000000018671600C-0x000000018671605C
		public bool IsRadial(); // 0x000000018671605C-0x00000001867160AC
		public bool IsAddition(); // 0x0000000186715FC0-0x000000018671600C
		public Vector3 GetWindDirection(bool localSpace = false /* Metadata: 0x0232CDA3 */); // 0x0000000186715E90-0x0000000186715FC0
		public void SetWindDirection(Vector3 dir, bool localSpace = false /* Metadata: 0x0232CDA4 */); // 0x000000018671625C-0x00000001867163C0
	}

	public struct WindParams : IValid // TypeDefIndex: 48182
	{
		// Fields
		public float influence; // 0x00
		public float frequency; // 0x04
		public float turbulence; // 0x08
		public float blend; // 0x0C
		public float synchronization; // 0x10
		public float depthWeight; // 0x14
		public float movingWind; // 0x18
	
		// Methods
		public void Convert(WindSettings sdata, ClothProcess.ClothType clothType); // 0x000000018308C000-0x000000018308C070
		public bool IsValid(); // 0x0000000186722BB4-0x0000000186722C0C
	}

	[Serializable]
	public class WindSettings : IValid, IDataValidate // TypeDefIndex: 48183
	{
		// Fields
		[Range(0f, 2f)]
		public float influence; // 0x10
		[Range(0f, 2f)]
		public float frequency; // 0x14
		[Range(0f, 2f)]
		public float turbulence; // 0x18
		[Range(0f, 1f)]
		public float blend; // 0x1C
		[Range(0f, 1f)]
		public float synchronization; // 0x20
		[Range(0f, 1f)]
		public float depthWeight; // 0x24
		[Range(0f, 10f)]
		public float movingWind; // 0x28
	
		// Constructors
		public WindSettings(); // 0x0000000184D87370-0x0000000184D873A0
	
		// Methods
		public bool IsValid(); // 0x0000000186722DE0-0x0000000186722E38
		public void DataValidate(); // 0x0000000186722CE4-0x0000000186722DE0
		public WindSettings Clone(); // 0x0000000186722C0C-0x0000000186722CE4
	}

	public static class Define // TypeDefIndex: 48186
	{
		// Nested types
		public enum Result // TypeDefIndex: 48184
		{
			None = 0,
			Empty = 1,
			Success = 2,
			Cancel = 3,
			Process = 4,
			Warning = 10000,
			RenderMesh_UnknownWarning = 10100,
			RenderMesh_VertexWeightIs5BonesOrMore = 10101,
			Init_NonUniformScale = 10200,
			Error = 20000,
			SerializeData_InvalidData = 20050,
			SerializeData_Over31Renderers = 20051,
			Init_InvalidData = 20100,
			Init_InvalidPaintMap = 20101,
			Init_PaintMapNotReadable = 20102,
			Init_ScaleIsZero = 20103,
			Init_NegativeScale = 20104,
			RenderSetup_Exception = 20200,
			RenderSetup_UnknownError = 20201,
			RenderSetup_InvalidSource = 20202,
			RenderSetup_NoMeshOnRenderer = 20203,
			RenderSetup_InvalidType = 20204,
			RenderSetup_Unreadable = 20205,
			RenderSetup_Over65535vertices = 20206,
			VirtualMesh_UnknownError = 20300,
			VirtualMesh_InvalidSetup = 20301,
			VirtualMesh_InvalidRenderData = 20302,
			VirtualMesh_ImportError = 20303,
			VirtualMesh_SelectionException = 20304,
			VirtualMesh_SelectionUnknownError = 20305,
			VirtualMesh_InvalidSelection = 20306,
			CreateCloth_Exception = 20400,
			CreateCloth_UnknownError = 20401,
			CreateCloth_InvalidCloth = 20402,
			CreateCloth_InvalidSerializeData = 20403,
			CreateCloth_InvalidSetupList = 20404,
			CreateCloth_NoRenderer = 20405,
			CreateCloth_InvalidPaintMap = 20406,
			CreateCloth_PaintMapNotReadable = 20407,
			CreateCloth_PaintMapCountMismatch = 20408,
			CreateCloth_CanNotStart = 20409,
			CreateCloth_VertexAttributeListCountMismatch = 20410,
			CreateCloth_VertexAttributeListIsNull = 20411,
			CreateCloth_VertexAttributeListDataMismatch = 20412,
			CreateCloth_InvalidVertexAttributeData = 20413,
			Reduction_Exception = 20500,
			Reduction_UnknownError = 20501,
			Reduction_InitError = 20502,
			Reduction_SameDistanceException = 20503,
			Reduction_SimpleDistanceException = 20504,
			Reduction_ShapeDistanceException = 20505,
			Reduction_MaxSideLengthZero = 20506,
			Reduction_OrganizationError = 20507,
			Reduction_StoreVirtualMeshError = 20508,
			Reduction_CalcAverageException = 20509,
			Optimize_Exception = 20600,
			ProxyMesh_Exception = 20700,
			ProxyMesh_UnknownError = 20701,
			ProxyMesh_ApplySelectionError = 20702,
			ProxyMesh_ConvertError = 20703,
			ProxyMesh_Over32767Vertices = 20704,
			ProxyMesh_Over32767Edges = 20705,
			ProxyMesh_Over32767Triangles = 20706,
			MappingMesh_Exception = 20800,
			MappingMesh_UnknownError = 20801,
			MappingMesh_ProxyError = 20802,
			ClothInit_Exception = 22000,
			ClothInit_FailedAddRenderer = 22001,
			ClothProcess_Exception = 22100,
			ClothProcess_UnknownError = 22101,
			ClothProcess_Invalid = 22102,
			ClothProcess_InvalidRenderHandleList = 22103,
			ClothProcess_GenerateSelectionError = 22104,
			ClothProcess_OverflowTeamCount4096 = 22105,
			Constraint_Exception = 22200,
			Constraint_UnknownError = 22201,
			Constraint_CreateDistanceException = 22202,
			Constraint_CreateTriangleBendingException = 22203,
			Constraint_CreateInertiaException = 22204,
			Constraint_CreateSelfCollisionException = 22205,
			MagicaMesh_UnknownError = 22500,
			MagicaMesh_Invalid = 22501,
			MagicaMesh_InvalidRenderer = 22502,
			MagicaMesh_InvalidMeshFilter = 22503,
			PreBuildData_UnknownError = 22600,
			PreBuildData_MagicaClothException = 22601,
			PreBuildData_VirtualMeshDeserializationException = 22602,
			PreBuildData_VerificationResult = 22603,
			PreBuildData_VersionMismatch = 22604,
			PreBuildData_InvalidClothData = 22605,
			PreBuildData_Empty = 22606,
			PreBuildData_InvalidScale = 22607,
			PreBuild_UnknownError = 22700,
			PreBuild_Exception = 22701,
			PreBuild_InvalidPreBuildData = 22702,
			PreBuild_InvalidRenderSetupData = 22703,
			PreBuild_SetupDeserializationError = 22704,
			Deserialization_UnknownError = 22800,
			Deserialization_Exception = 22801
		}
	
		public static class System // TypeDefIndex: 48185
		{
			// Fields
			public const int LatestPreBuildVersion = 2; // Metadata: 0x0232CF26
			public const float Epsilon = 1E-08f; // Metadata: 0x0232CF27
			public const int MaxRendererCount = 31; // Metadata: 0x0232CF2B
			public const float MinimumGridSize = 1E-05f; // Metadata: 0x0232CF2C
			public const int MaximumTeamCount = 4096; // Metadata: 0x0232CF30
			public const int DefaultSimulationFrequency = 90; // Metadata: 0x0232CF32
			public const int SimulationFrequency_Low = 30; // Metadata: 0x0232CF34
			public const int SimulationFrequency_Hi = 150; // Metadata: 0x0232CF35
			public const int DefaultMaxSimulationCountPerFrame = 3; // Metadata: 0x0232CF37
			public const int MaxSimulationCountPerFrame_Low = 1; // Metadata: 0x0232CF38
			public const int MaxSimulationCountPerFrame_Hi = 5; // Metadata: 0x0232CF39
			public const float SameSurfaceAngle = 80f; // Metadata: 0x0232CF3A
			public const float MaxDistanceRatioFutuerPrediction = 1.3f; // Metadata: 0x0232CF3E
			public const bool ReductionEnable = true; // Metadata: 0x0232CF42
			public const float ReductionSameDistance = 0.001f; // Metadata: 0x0232CF43
			public const bool ReductionDontMakeLine = true; // Metadata: 0x0232CF47
			public const float ReductionJoinPositionAdjustment = 1f; // Metadata: 0x0232CF48
			public const int ReductionMaxStep = 100; // Metadata: 0x0232CF4C
			public const int MaxProxyMeshVertexCount = 32767; // Metadata: 0x0232CF4E
			public const int MaxProxyMeshEdgeCount = 32767; // Metadata: 0x0232CF52
			public const int MaxProxyMeshTriangleCount = 32767; // Metadata: 0x0232CF56
			public const float ProxyMeshTrianglePairAngle = 20f; // Metadata: 0x0232CF5A
			public const float ProxyMeshBoneClothTriangleAngle = 120f; // Metadata: 0x0232CF5E
			public const float FrictionMass = 3f; // Metadata: 0x0232CF62
			public const float DepthMass = 5f; // Metadata: 0x0232CF66
			public const float FrictionDampingRate = 0.6f; // Metadata: 0x0232CF6A
			public const float PositionAverageExponent = 0.5f; // Metadata: 0x0232CF6E
			public const float MaxRealVelocity = 0.5f; // Metadata: 0x0232CF72
			public const float TetherCompressionStiffness = 1f; // Metadata: 0x0232CF76
			public const float TetherStretchStiffness = 1f; // Metadata: 0x0232CF7A
			public const float TetherStretchLimit = 0.03f; // Metadata: 0x0232CF7E
			public const float TetherStiffnessWidth = 0.3f; // Metadata: 0x0232CF82
			public const float TetherCompressionVelocityAttenuation = 0.7f; // Metadata: 0x0232CF86
			public const float TetherStretchVelocityAttenuation = 0.7f; // Metadata: 0x0232CF8A
			public const float DistanceVelocityAttenuation = 0.3f; // Metadata: 0x0232CF8E
			public const float DistanceVerticalStiffness = 1f; // Metadata: 0x0232CF92
			public const float DistanceHorizontalStiffness = 0.5f; // Metadata: 0x0232CF96
			public const float TriangleBendingMaxAngle = 120f; // Metadata: 0x0232CF9A
			public const float VolumeMinAngle = 90f; // Metadata: 0x0232CF9E
			public const float MaxAngleLimit = 179f; // Metadata: 0x0232CFA2
			public const int AngleLimitIteration = 3; // Metadata: 0x0232CFA6
			public const float AngleLimitAttenuation = 0.9f; // Metadata: 0x0232CFA7
			public const float MaxMovementSpeedLimit = 10f; // Metadata: 0x0232CFAB
			public const float MaxRotationSpeedLimit = 1440f; // Metadata: 0x0232CFAF
			public const float MaxParticleSpeedLimit = 10f; // Metadata: 0x0232CFB3
			public const int ExpandedColliderCount = 8; // Metadata: 0x0232CFB7
			public const float ColliderCollisionDynamicFrictionRatio = 1f; // Metadata: 0x0232CFB8
			public const float ColliderCollisionStaticFrictionRatio = 1f; // Metadata: 0x0232CFBC
			public const float CustomSkinningAngularAttenuation = 1f; // Metadata: 0x0232CFC0
			public const float CustomSkinningDistanceReduction = 0.6f; // Metadata: 0x0232CFC4
			public const float CustomSkinningDistancePow = 2f; // Metadata: 0x0232CFC8
			public const int SelfCollisionSolverIteration = 4; // Metadata: 0x0232CFCC
			public const float SelfCollisionFixedMass = 100f; // Metadata: 0x0232CFCD
			public const float SelfCollisionFrictionMass = 10f; // Metadata: 0x0232CFD1
			public const float SelfCollisionClothMass = 50f; // Metadata: 0x0232CFD5
			public const float SelfCollisionSCR = 2f; // Metadata: 0x0232CFD9
			public static readonly float SelfCollisionPointTriangleAngleCos; // 0x00
			public const int SelfCollisionIntersectDiv = 8; // Metadata: 0x0232CFDD
			public const float SelfCollisionThicknessMin = 0.001f; // Metadata: 0x0232CFDE
			public const float SelfCollisionThicknessMax = 0.05f; // Metadata: 0x0232CFE2
			public const float WindMaxTime = 10000f; // Metadata: 0x0232CFE6
			public const float WindBaseSpeed = 7.5f; // Metadata: 0x0232CFEA
			public const float BoneSpringDistanceStiffness = 0.5f; // Metadata: 0x0232CFEE
			public const float BoneSpringTetherCompressionLimit = 0.8f; // Metadata: 0x0232CFF2
			public const float BoneSpringCollisionFriction = 0.5f; // Metadata: 0x0232CFF6
			public const float DistanceCullingMaxLength = 100f; // Metadata: 0x0232CFFA
	
			// Constructors
			static System(); // 0x000000018671CE88-0x000000018671CECC
		}
	}

	internal interface ICount // TypeDefIndex: 48187
	{
		// Methods
		int Count();
	}

	internal interface IDataValidate // TypeDefIndex: 48188
	{
		// Methods
		void DataValidate();
	}

	internal interface ITransform // TypeDefIndex: 48189
	{
		// Methods
		void GetUsedTransform(HashSet<Transform> transformSet);
		void ReplaceTransform(Dictionary<int, Transform> replaceDict);
	}

	internal interface IValid // TypeDefIndex: 48190
	{
		// Methods
		bool IsValid();
	}

	public class ClothManager : IManager, IValid // TypeDefIndex: 48191
	{
		// Fields
		internal HashSet<ClothProcess> clothSet; // 0x10
		internal HashSet<ClothProcess> boneClothSet; // 0x18
		internal HashSet<ClothProcess> meshClothSet; // 0x20
		private Dictionary<int, bool> animatorVisibleDict; // 0x28
		private Dictionary<int, bool> rendererVisibleDict; // 0x30
		private JobHandle masterJob; // 0x38
		private bool isValid; // 0x48
		private static readonly ProfilerMarker startClothUpdateTimeProfiler; // 0x00
		private static readonly ProfilerMarker startClothUpdateTeamProfiler; // 0x08
		private static readonly ProfilerMarker startClothUpdatePrePareProfiler; // 0x10
		private static readonly ProfilerMarker startClothUpdateScheduleProfiler; // 0x18
		private static readonly ProfilerMarker startClothUpdateScheduleStep1Profiler; // 0x20
		private static readonly ProfilerMarker startClothUpdateScheduleStep2Profiler; // 0x28
		private static readonly ProfilerMarker startClothUpdateScheduleStep3Profiler; // 0x30
		private static readonly ProfilerMarker startClothUpdateScheduleStep4Profiler; // 0x38
		private static readonly ProfilerMarker startClothUpdateScheduleStep5Profiler; // 0x40
		private static readonly ProfilerMarker startClothUpdateWaitMasterJobProfiler; // 0x48
	
		// Constructors
		public ClothManager(); // 0x00000001835B8870-0x00000001835B89E0
		static ClothManager(); // 0x00000001849776B0-0x0000000184977930
	
		// Methods
		public void Dispose(); // 0x0000000186716478-0x000000018671697C
		public void EnterdEditMode(); // 0x000000018671697C-0x00000001867169CC
		public void Initialize(); // 0x00000001835BAA80-0x00000001835BAF80
		public bool IsValid(); // 0x0000000186716A20-0x0000000186716A6C
		private void ClearMasterJob(); // 0x0000000184030DC0-0x0000000184030DF0
		private void CompleteMasterJob(); // 0x0000000182F95120-0x0000000182F95200
		public void ForceCompleteAllJob(); // 0x0000000182F94D30-0x0000000182F94E60
		internal int AddCloth(ClothProcess cprocess, [IsReadOnly] in ClothParameters clothParams); // 0x00000001839C5840-0x00000001839C5A70
		internal void RemoveCloth(ClothProcess cprocess); // 0x0000000183E932A0-0x0000000183E933A0
		private void OnEarlyClothUpdate(); // 0x0000000183234A50-0x0000000183234D80
		private void OnAfterUpdate(); // 0x0000000183E00900-0x0000000183E009D0
		private void OnApplicationQuit(); // 0x0000000186716A6C-0x0000000186716ABC
		private void OnBeforeLateUpdate(); // 0x0000000182F93400-0x0000000182F93490
		private void OnAfterLateUpdate(); // 0x0000000182F93490-0x0000000182F93530
		private void ClothUpdate(); // 0x0000000182F918A0-0x0000000182F93110
		internal void ClearVisibleDict(); // 0x00000001831C6870-0x00000001831C6C30
		internal bool CheckVisible(Animator ani, List<Renderer> renderers); // 0x00000001839AF6E0-0x00000001839AF930
		internal bool CheckLODVisible(Animator ani, int clothAnimatorAbilityLODThresholdProperty, int clothAnimatorLODThresholdProperty); // 0x0000000182F93630-0x0000000182F937A0
		private bool CheckRendererVisible(List<Renderer> renderers); // 0x000000018323ABE0-0x000000018323AF00
		public void InformationLog(StringBuilder allsb); // 0x00000001867169CC-0x0000000186716A20
	}

	public class PreBuildManager : IManager, IValid // TypeDefIndex: 48193
	{
		// Fields
		private Dictionary<SharePreBuildData, ShareDeserializationData> deserializationDict; // 0x10
		private bool isValid; // 0x18
		private static readonly ProfilerMarker deserializationProfiler; // 0x00
	
		// Nested types
		internal class ShareDeserializationData : IDisposable // TypeDefIndex: 48192
		{
			// Fields
			internal string buildId; // 0x10
			internal ResultCode result; // 0x18
			internal int referenceCount; // 0x20
			internal List<RenderSetupData> renderSetupDataList; // 0x28
			internal VirtualMesh proxyMesh; // 0x30
			internal List<VirtualMesh> renderMeshList; // 0x38
			internal DistanceConstraint.ConstraintData distanceConstraintData; // 0x40
			internal TriangleBendingConstraint.ConstraintData bendingConstraintData; // 0x48
			internal InertiaConstraint.ConstraintData inertiaConstraintData; // 0x50
	
			// Properties
			public int RenderMeshCount { get; } // 0x000000018671AB18-0x000000018671AB90 
	
			// Constructors
			public ShareDeserializationData(); // 0x0000000183E8CCC0-0x0000000183E8CD90
	
			// Methods
			public void Dispose(); // 0x000000018671A4F0-0x000000018671A99C
			public void Deserialize(SharePreBuildData sharePreBuilddata); // 0x0000000183E8EE00-0x0000000183E8F7A0
			public VirtualMeshContainer GetProxyMeshContainer(); // 0x000000018671A99C-0x000000018671AA38
			public VirtualMeshContainer GetRenderMeshContainer(int index); // 0x000000018671AA38-0x000000018671AB18
		}
	
		// Constructors
		public PreBuildManager(); // 0x00000001835B9510-0x00000001835B9590
		static PreBuildManager(); // 0x0000000184D38D80-0x0000000184D38DE0
	
		// Methods
		public void Dispose(); // 0x0000000186718750-0x0000000186718900
		public void EnterdEditMode(); // 0x0000000186718900-0x0000000186718950
		public void Initialize(); // 0x00000001835B9360-0x00000001835B9390
		public bool IsValid(); // 0x0000000186718E08-0x0000000186718E54
		public void InformationLog(StringBuilder allsb); // 0x0000000186718950-0x0000000186718E08
		internal ShareDeserializationData RegisterPreBuildData(SharePreBuildData sdata, bool referenceIncrement); // 0x0000000183E8EB10-0x0000000183E8EC60
		internal ShareDeserializationData GetPreBuildData(SharePreBuildData sdata); // 0x0000000183E8EA70-0x0000000183E8EB10
		internal void UnregisterPreBuildData(SharePreBuildData sdata); // 0x0000000183E8BA00-0x0000000183E8BAB0
		internal void UnloadUnusedData(); // 0x000000018477D4B0-0x000000018477D850
	}

	public struct DoAllInOneJob : IJob // TypeDefIndex: 48194
	{
		// Fields
		public GCHandle bmHandle; // 0x00
		public GCHandle tmHandle; // 0x08
		public GCHandle vmHandle; // 0x10
		public GCHandle smHandle; // 0x18
		public GCHandle wmHandle; // 0x20
		public GCHandle meshClothSetHandle; // 0x28
	
		// Methods
		public void Execute(); // 0x0000000186717BC4-0x00000001867182C4
	}

	public interface ICrossFrameParallelForJob : IJob // TypeDefIndex: 48195
	{
		// Methods
		void SetIndexCount(int indexCount);
	}

	public interface ICrossFrameParallelForDeferJob : IJob // TypeDefIndex: 48196
	{
		// Methods
		void SetIndexCount(NativeReference<int> indexCount);
	}

	public interface IUnsafeJob // TypeDefIndex: 48197
	{
		// Methods
		void UnsafeDo();
	}

	public static class CrossFrameJobUtils // TypeDefIndex: 48198
	{
		// Fields
		public static int s_MainThreadId; // 0x00
	
		// Methods
		public static JobHandle ScheduleNoUseRun<T>(ref ref T jobData, JobHandle dependsOn = default)
			where T : struct, IJob;
		public static JobHandle Schedule2<T>(ref ref T jobData, JobHandle dependsOn = default)
			where T : struct, IUnsafeJob, IJob;
		public static JobHandle Schedule<T>(ref ref T jobData, JobHandle dependsOn = default)
			where T : struct, IJob;
		public static JobHandle Schedule<T>(ref ref T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelFor, ICrossFrameParallelForJob;
		public static JobHandle Schedule2<T>(ref ref T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob;
		public static unsafe JobHandle Schedule2<T>(ref ref T jobData, int* forEachCount, NativeReference<int> forEachCountRef, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob;
		public static unsafe JobHandle Schedule<T>(ref ref T jobData, int* forEachCount, NativeReference<int> forEachCountRef, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer, ICrossFrameParallelForDeferJob;
	}

	public class DynamicBoneTransformManager : IManager, IValid // TypeDefIndex: 48218
	{
		// Fields
		internal const byte Flag_Read = 1; // Metadata: 0x0232CFFE
		internal const byte Flag_WorldRotWrite = 2; // Metadata: 0x0232CFFF
		internal const byte Flag_LocalPosRotWrite = 4; // Metadata: 0x0232D000
		internal const byte Flag_Restore = 8; // Metadata: 0x0232D001
		internal const byte Flag_Enable = 16; // Metadata: 0x0232D002
		internal ExNativeArray<ExBitFlag8> flagArray; // 0x10
		internal ExNativeArray<float3> initLocalPositionArray; // 0x18
		internal ExNativeArray<quaternion> initLocalRotationArray; // 0x20
		internal ExNativeArray<double3> positionArray; // 0x28
		internal ExNativeArray<double3> lastpositionArray; // 0x30
		internal ExNativeArray<quaternion> rotationArray; // 0x38
		internal ExNativeArray<quaternion> lastrotationArray; // 0x40
		internal ExNativeArray<float3> scaleArray; // 0x48
		internal ExNativeArray<float3> localPositionArray; // 0x50
		internal ExNativeArray<float3> lastlocalPositionArray; // 0x58
		internal ExNativeArray<quaternion> localRotationArray; // 0x60
		internal ExNativeArray<quaternion> lastlocalRotationArray; // 0x68
		internal ExNativeArray<float4x4> localToWorldMatrixArray; // 0x70
		internal ExNativeArray<short> teamIdArray; // 0x78
		internal TransformAccessArray transformAccessArray; // 0x80
		internal Dictionary<Animator, List<int>> animatorTransformMap; // 0x88
		internal ExNativeArray<float3> componentPositionArray; // 0x90
		internal TransformAccessArray componentTransformAccessArray; // 0x98
		private bool isValid; // 0xA0
	
		// Properties
		internal int Count { get; } // 0x0000000183B12CF0-0x0000000183B12D60 
	
		// Nested types
		[BurstCompile]
		private static class WriteAnimatorBufferDataJobKernels // TypeDefIndex: 48203
		{
			// Nested types
			public unsafe delegate void WriteAnimatorBufferDataKernel_0000025C_PostfixBurstDelegate(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 48199; 0x000000018621C6AC-0x000000018621C72C
	
			internal static class WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall // TypeDefIndex: 48200
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall(); // 0x0000000184D1AF30-0x0000000184D1AF40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068032); // 0x000000018672DFD4-0x000000018672E0D8
				private static IntPtr GetFunctionPointer(); // 0x000000018672E0D8-0x000000018672E12C
				public static void Constructor(); // 0x0000000184D1AF40-0x0000000184D1AFD0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x000000018672E12C-0x000000018672E29C
			}
	
			public unsafe delegate void WriteAnimatorBufferDataRangeKernel_0000025D_PostfixBurstDelegate(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 48201; 0x000000018621C6AC-0x000000018621C72C
	
			internal static class WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall // TypeDefIndex: 48202
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall(); // 0x0000000184D1AE90-0x0000000184D1AEA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068059); // 0x000000018672E448-0x000000018672E54C
				private static IntPtr GetFunctionPointer(); // 0x000000018672E54C-0x000000018672E5A0
				public static void Constructor(); // 0x0000000184D1AEA0-0x0000000184D1AF30
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x000000018672E5A0-0x000000018672E708
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteAnimatorBufferDataKernel(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x000000018672D464-0x000000018672D534
			[BurstCompile]
			internal static unsafe void WriteAnimatorBufferDataRangeKernel(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x000000018672D534-0x000000018672D604
			[BurstCompile]
			public static unsafe void WriteAnimatorBufferDataKernel_BurstManaged(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x000000018672CD1C-0x000000018672D464
			[BurstCompile]
			public static unsafe void WriteAnimatorBufferDataRangeKernel_BurstManaged(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x0000000186724BF4-0x0000000186724CE8
		}
	
		[BurstCompile]
		private struct ReadAnimatorBufferDataJob : IJobCrossFrameTransform // TypeDefIndex: 48204
		{
			// Fields
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagList; // 0x00
			[WriteOnly]
			public NativeArray<double3> positionArray; // 0x10
			[WriteOnly]
			public NativeArray<quaternion> rotationArray; // 0x20
			[WriteOnly]
			public NativeArray<float3> scaleList; // 0x30
			[WriteOnly]
			public NativeArray<float3> localPositionArray; // 0x40
			[WriteOnly]
			public NativeArray<quaternion> localRotationArray; // 0x50
			[WriteOnly]
			public NativeArray<float4x4> localToWorldMatrixArray; // 0x60
			[ReadOnly]
			public NativeParallelHashMap<int, int> teamId2AnimatorInstanceId; // 0x70
			[ReadOnly]
			public NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler; // 0x80
			[ReadOnly]
			public NativeParallelHashMap<int, int> transformID2RWHandlerID; // 0x90
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0xA0
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0xB0
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x00000001867266CC-0x000000018672675C
			private void _Do(int index, TransformAccess transform); // 0x000000018672675C-0x000000018672717C
		}
	
		[BurstCompile]
		private struct WriteAnimatorBufferDataJob : IJob, IUnsafeJob // TypeDefIndex: 48205
		{
			// Fields
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagList; // 0x00
			[ReadOnly]
			public NativeArray<double3> positionArray; // 0x10
			[ReadOnly]
			public NativeArray<quaternion> rotationArray; // 0x20
			[ReadOnly]
			public NativeArray<float3> localPositionArray; // 0x30
			[ReadOnly]
			public NativeArray<quaternion> localRotationArray; // 0x40
			[ReadOnly]
			public NativeParallelHashMap<int, int> teamId2AnimatorInstanceId; // 0x50
			[ReadOnly]
			public NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler; // 0x60
			[ReadOnly]
			public NativeParallelHashMap<int, int> transformID2RWHandlerID; // 0x70
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x80
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x90
	
			// Methods
			public void Execute(); // 0x000000018672D604-0x000000018672DE4C
			public void UnsafeDo(); // 0x000000018672DE4C-0x000000018672DFD4
		}
	
		[BurstCompile]
		private struct CopyDoubleBufferJob : IJob // TypeDefIndex: 48206
		{
			// Fields
			[ReadOnly]
			public NativeArray<double3> worldPositions; // 0x00
			[ReadOnly]
			public NativeArray<quaternion> worldRotations; // 0x10
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x20
			[ReadOnly]
			public NativeArray<quaternion> localRotations; // 0x30
			public NativeArray<double3> lastworldPositions; // 0x40
			public NativeArray<quaternion> lastworldRotations; // 0x50
			public NativeArray<float3> lastlocalPositions; // 0x60
			public NativeArray<quaternion> lastlocalRotations; // 0x70
	
			// Methods
			public void Execute(); // 0x0000000186724CE8-0x0000000186724E0C
		}
	
		[BurstCompile]
		private struct EnableTransformJob : IJob // TypeDefIndex: 48207
		{
			// Fields
			public DataChunk chunk; // 0x00
			public bool sw; // 0x08
			public NativeArray<ExBitFlag8> flagList; // 0x10
	
			// Methods
			public void Execute(); // 0x0000000186726644-0x00000001867266CC
		}
	
		[BurstCompile]
		private struct RestoreTransformJob : IJobParallelForTransform // TypeDefIndex: 48208
		{
			// Fields
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagList; // 0x00
			[ReadOnly]
			public NativeArray<float3> localPositionArray; // 0x10
			[ReadOnly]
			public NativeArray<quaternion> localRotationArray; // 0x20
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x30
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x40
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x0000000186727910-0x0000000186727B24
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 48209
		{
			// Fields
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagList; // 0x00
			[WriteOnly]
			public NativeArray<double3> positionArray; // 0x10
			[WriteOnly]
			public NativeArray<quaternion> rotationArray; // 0x20
			[WriteOnly]
			public NativeArray<float3> scaleList; // 0x30
			[WriteOnly]
			public NativeArray<float3> localPositionArray; // 0x40
			[WriteOnly]
			public NativeArray<quaternion> localRotationArray; // 0x50
			[WriteOnly]
			public NativeArray<float4x4> localToWorldMatrixArray; // 0x60
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x70
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x80
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x0000000186727248-0x0000000186727910
		}
	
		[BurstCompile]
		public static class ValidTransformKernels // TypeDefIndex: 48214
		{
			// Nested types
			public unsafe delegate void ValidateTransformKernel_00000266_PostfixBurstDelegate(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 48210; 0x0000000182BED120-0x0000000182BED140
	
			internal static class ValidateTransformKernel_00000266_BurstDirectCall // TypeDefIndex: 48211
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ValidateTransformKernel_00000266_BurstDirectCall(); // 0x0000000184D1B110-0x0000000184D1B120
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068096); // 0x000000018672C658-0x000000018672C75C
				private static IntPtr GetFunctionPointer(); // 0x000000018672C75C-0x000000018672C7B0
				public static void Constructor(); // 0x0000000184D1B120-0x0000000184D1B1B0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x000000018672C7B0-0x000000018672C884
			}
	
			public unsafe delegate void ValidateTransformRangeKernel_00000267_PostfixBurstDelegate(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 48212; 0x0000000182BED120-0x0000000182BED140
	
			internal static class ValidateTransformRangeKernel_00000267_BurstDirectCall // TypeDefIndex: 48213
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ValidateTransformRangeKernel_00000267_BurstDirectCall(); // 0x0000000184D1B070-0x0000000184D1B080
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000680ae); // 0x000000018672CA10-0x000000018672CB14
				private static IntPtr GetFunctionPointer(); // 0x000000018672CB14-0x000000018672CB68
				public static void Constructor(); // 0x0000000184D1B080-0x0000000184D1B110
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x000000018672CB68-0x000000018672CC64
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void ValidateTransformKernel(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x000000018672C4C8-0x000000018672C550
			[BurstCompile]
			public static unsafe void ValidateTransformRangeKernel(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x000000018672C5D0-0x000000018672C658
			[BurstCompile]
			public static unsafe void ValidateTransformKernel_BurstManaged(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x00000001867242F4-0x0000000186724BF4
			[BurstCompile]
			public static unsafe void ValidateTransformRangeKernel_BurstManaged(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x000000018672C550-0x000000018672C5D0
		}
	
		[BurstCompile]
		private struct ValidTransformJob : IJob, IUnsafeJob // TypeDefIndex: 48215
		{
			// Fields
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagList; // 0x00
			[ReadOnly]
			public NativeArray<double3> worldPositions; // 0x10
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x20
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x30
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x40
			public int count; // 0x50
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183D466C0-0x0000000183D46700
			[IDTag(1)]
			public void Execute(); // 0x000000018672C28C-0x000000018672C2F8
			public void UnsafeDo(); // 0x000000018672C404-0x000000018672C4C8
			[IDTag(0)]
			public void Execute(int index); // 0x000000018672C2F8-0x000000018672C404
		}
	
		[BurstCompile]
		private struct WriteTransformJob : IJobParallelForTransform // TypeDefIndex: 48216
		{
			// Fields
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagList; // 0x00
			[ReadOnly]
			public NativeArray<double3> lastpositionArray; // 0x10
			[ReadOnly]
			public NativeArray<quaternion> lastrotationArray; // 0x20
			[ReadOnly]
			public NativeArray<float3> lastlocalPositionArray; // 0x30
			[ReadOnly]
			public NativeArray<quaternion> lastlocalRotationArray; // 0x40
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x50
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x60
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x000000018672E7E0-0x000000018673149C
		}
	
		[BurstCompile]
		private struct ReadComponentTransformJob : IJobParallelForTransform // TypeDefIndex: 48217
		{
			// Fields
			[WriteOnly]
			public NativeArray<float3> positionArray; // 0x00
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x000000018672717C-0x0000000186727248
		}
	
		// Constructors
		public DynamicBoneTransformManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public JobHandle WriteAnimatorBufferData(JobHandle jobHandle, ref NativeParallelHashMap<int, int> teamId2AnimatorInstnceId, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler, ref NativeParallelHashMap<int, int> transformID2RWHandlerID); // 0x0000000186726158-0x000000018672641C
		public JobHandle ReadAnimatorBufferData(JobHandle jobHandle, ref NativeParallelHashMap<int, int> teamId2AnimatorInstnceId, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler, ref NativeParallelHashMap<int, int> transformID2RWHandlerID); // 0x0000000186725E4C-0x0000000186726158
		public JobHandle CopyDoubleBuffer(JobHandle jobHandle); // 0x0000000183D42300-0x0000000183D42460
		public JobHandle WriteDoubleBufferTransform(JobHandle jobHandle); // 0x0000000183B125A0-0x0000000183B127D0
		public void Dispose(); // 0x00000001835BA600-0x00000001835BA850
		public void EnterdEditMode(); // 0x0000000186725378-0x00000001867253C8
		public void Initialize(); // 0x0000000183E87D80-0x0000000183E88220
		public bool IsValid(); // 0x0000000186725DFC-0x0000000186725E4C
		[IDTag(0)]
		internal DataChunk AddTransform(VirtualMeshContainer cmesh, int teamId); // 0x0000000183CF8680-0x0000000183CF8A50
		[IDTag(1)]
		internal DataChunk AddTransform(int count, int teamId); // 0x0000000183CF8360-0x0000000183CF8680
		[IDTag(2)]
		internal DataChunk AddTransform(Transform t, ExBitFlag8 flag, int teamId); // 0x0000000186724E0C-0x0000000186725378
		internal void SetTransform(Transform t, ExBitFlag8 flag, int index, int teamId); // 0x00000001833A7ED0-0x00000001833A8460
		internal void CopyTransform(int fromIndex, int toIndex); // 0x00000001847D1FA0-0x00000001847D22A0
		internal void RemoveTransform(DataChunk c); // 0x0000000183CF91B0-0x0000000183CF9440
		[IDTag(1)]
		internal void EnableTransform(DataChunk c, bool sw); // 0x00000001837EC980-0x00000001837ECA30
		[IDTag(0)]
		internal void EnableTransform(int index, bool sw); // 0x00000001833A8D60-0x00000001833A8E40
		internal DataChunk Expand(DataChunk c, int newLength); // 0x00000001867253C8-0x0000000186725708
		public JobHandle RestoreTransform(JobHandle jobHandle); // 0x0000000183B12AA0-0x0000000183B12CF0
		public JobHandle ReadTransform(JobHandle jobHandle); // 0x0000000183B127D0-0x0000000183B12AA0
		public JobHandle WriteTransform(JobHandle jobHandle); // 0x000000018672641C-0x0000000186726644
		public JobHandle ValidPosition(JobHandle jobHandle); // 0x0000000183D46540-0x0000000183D466C0
		internal int AddComponentTransform(Transform t); // 0x0000000183CF9EF0-0x0000000183CF9FF0
		internal void RemoveComponentTransform(int index); // 0x0000000183E93210-0x0000000183E932A0
		internal JobHandle ReadComponentTransform(JobHandle jobHandle); // 0x0000000183C06690-0x0000000183C06810
		public void InformationLog(StringBuilder allsb); // 0x0000000186725708-0x0000000186725DFC
		public static void Initialize_WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall(); // 0x00000001844F6990-0x00000001844F69F0
		public static void Initialize_WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall(); // 0x00000001844F69F0-0x00000001844F6A50
	}

	public class TeamManager : IManager, IValid // TypeDefIndex: 48248
	{
		// Fields
		public const int Flag_Valid = 0; // Metadata: 0x0232D003
		public const int Flag_Enable = 1; // Metadata: 0x0232D004
		public const int Flag_Reset = 2; // Metadata: 0x0232D005
		public const int Flag_TimeReset = 3; // Metadata: 0x0232D006
		public const int Flag_SyncSuspend = 4; // Metadata: 0x0232D007
		public const int Flag_Running = 5; // Metadata: 0x0232D008
		public const int Flag_Synchronization = 6; // Metadata: 0x0232D009
		public const int Flag_StepRunning = 7; // Metadata: 0x0232D00A
		public const int Flag_Exit = 8; // Metadata: 0x0232D00B
		public const int Flag_KeepTeleport = 9; // Metadata: 0x0232D00C
		public const int Flag_InertiaShift = 10; // Metadata: 0x0232D00D
		public const int Flag_CameraCullingInvisible = 11; // Metadata: 0x0232D00E
		public const int Flag_CameraCullingKeep = 12; // Metadata: 0x0232D00F
		public const int Flag_Spring = 13; // Metadata: 0x0232D010
		public const int Flag_SkipWriting = 14; // Metadata: 0x0232D011
		public const int Flag_Anchor = 15; // Metadata: 0x0232D012
		public const int Flag_AnchorReset = 16; // Metadata: 0x0232D013
		public const int Flag_NegativeScale = 17; // Metadata: 0x0232D014
		public const int Flag_NegativeScaleTeleport = 18; // Metadata: 0x0232D015
		public const int Flag_DistanceCullingInvisible = 19; // Metadata: 0x0232D016
		public const int Flag_RestoreTransformOnlyOnec = 20; // Metadata: 0x0232D017
		public const int Flag_Tangent = 21; // Metadata: 0x0232D018
		public const int Flag_Self_PointPrimitive = 32; // Metadata: 0x0232D019
		public const int Flag_Self_EdgePrimitive = 33; // Metadata: 0x0232D01A
		public const int Flag_Self_TrianglePrimitive = 34; // Metadata: 0x0232D01B
		public const int Flag_Self_EdgeEdge = 35; // Metadata: 0x0232D01C
		public const int Flag_Sync_EdgeEdge = 36; // Metadata: 0x0232D01D
		public const int Flag_PSync_EdgeEdge = 37; // Metadata: 0x0232D01E
		public const int Flag_Self_PointTriangle = 38; // Metadata: 0x0232D01F
		public const int Flag_Sync_PointTriangle = 39; // Metadata: 0x0232D020
		public const int Flag_PSync_PointTriangle = 40; // Metadata: 0x0232D021
		public const int Flag_Self_TrianglePoint = 41; // Metadata: 0x0232D022
		public const int Flag_Sync_TrianglePoint = 42; // Metadata: 0x0232D023
		public const int Flag_PSync_TrianglePoint = 43; // Metadata: 0x0232D024
		public const int Flag_Self_EdgeTriangleIntersect = 44; // Metadata: 0x0232D025
		public const int Flag_Sync_EdgeTriangleIntersect = 45; // Metadata: 0x0232D026
		public const int Flag_PSync_EdgeTriangleIntersect = 46; // Metadata: 0x0232D027
		public const int Flag_Self_TriangleEdgeIntersect = 47; // Metadata: 0x0232D028
		public const int Flag_Sync_TriangleEdgeIntersect = 48; // Metadata: 0x0232D029
		public const int Flag_PSync_TriangleEdgeIntersect = 49; // Metadata: 0x0232D02A
		public const int Flag_Lod_LodOut = 60; // Metadata: 0x0232D02B
		public const int Flag_Lod_Culled = 61; // Metadata: 0x0232D02C
		public ExNativeArray<TeamData> teamDataArray; // 0x10
		public ExNativeArray<TeamWindData> teamWindArray; // 0x18
		public ExNativeArray<MappingData> mappingDataArray; // 0x20
		public ExNativeArray<FixedList64Bytes<short>> teamMappingIndexArray; // 0x28
		public NativeReference<int> maxUpdateCount; // 0x30
		public ExNativeArray<ClothParameters> parameterArray; // 0x40
		public ExNativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x48
		private HashSet<int> enableTeamSet; // 0x50
		private Dictionary<int, ClothProcess> clothProcessDict; // 0x58
		private bool isValid; // 0x60
		internal int edgeColliderCollisionCount; // 0x64
		internal NativeReference<int> edgeColliderCollisionCountBuff; // 0x68
		internal NativeParallelHashMap<int, int> comp2SuspendCounterMap; // 0x78
		internal NativeParallelHashMap<int, int> comp2TeamIdMap; // 0x88
		internal NativeParallelHashMap<int, int> comp2SyncPartnerCompMap; // 0x98
		internal NativeParallelHashMap<int, int> comp2SyncTopCompMap; // 0xA8
		internal NativeParallelHashMap<int, int> teamId2AnimatorInstnceId; // 0xB8
		internal NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler; // 0xC8
		internal NativeParallelHashMap<int, int> transformID2RWHandlerID; // 0xD8
		internal Dictionary<int, Animator> teamId2Animator; // 0xE8
		internal HashSet<int> dirtyAnimatorTransformTeams; // 0xF0
		private HashSet<int> m_tempList; // 0xF8
		internal List<ClothProcess> parameterDirtyList; // 0x100
		internal List<ClothProcess> skipWritingDirtyList; // 0x108
		internal List<ClothProcess> codeParameterDirtyList; // 0x110
		internal NativeList<int> cullingDirtyList; // 0x118
		internal NativeParallelHashSet<int> alwaysTeamUpdateSelfCollisionUpdateSet; // 0x128
		internal NativeParallelHashMap<int, int> animatorUpdateModeMap; // 0x138
		internal ExSimpleNativeArray<int> teamAnchorTransformIndexArray; // 0x148
		internal ExSimpleNativeArray<int> teamDistanceTransformIndexArray; // 0x150
		internal NativeParallelHashMap<int, float3> transformPositionMap; // 0x158
		internal NativeParallelHashMap<int, quaternion> transformRotationMap; // 0x168
		internal HashSet<BeyondBoneCloth> cameraCullingClothSet; // 0x178
		private static readonly ProfilerMarker teamCameraCullingPreProfiler; // 0x00
		private static readonly ProfilerMarker teamCameraCullingProfiler; // 0x08
		private static readonly ProfilerMarker startClothUpdateComponentProfiler; // 0x10
		private static readonly ProfilerMarker alwaysTeamUpdateParameterDirtyProfiler; // 0x18
		private static readonly ProfilerMarker alwaysTeamUpdateStep2Profiler; // 0x20
		private static readonly ProfilerMarker alwaysTeamUpdateStep3Profiler; // 0x28
		private static readonly ProfilerMarker alwaysTeamUpdateEdgeColliderProfiler; // 0x30
		private static readonly ProfilerMarker alwaysTeamUpdateSelfCollisionStepProfiler; // 0x38
		private HashSet<ClothProcess> monitoringProcessSet; // 0x180
		private List<ClothProcess> disposeProcessList; // 0x188
	
		// Properties
		public int MappingCount { get; } // 0x0000000183FA4230-0x0000000183FA4300 
		public int TeamCount { get; } // 0x00000001835BD790-0x00000001835BD800 
		public int TrueTeamCount { get; } // 0x0000000183234D80-0x0000000183234DF0 
		public int ActiveTeamCount { get; } // 0x0000000182F932F0-0x0000000182F93360 
	
		// Nested types
		[BurstCompile]
		public static class SimulationStepTeamUpdateKernels // TypeDefIndex: 48227
		{
			// Nested types
			public unsafe delegate void SimulationStepTeamUpdateKernel_00000296_PostfixBurstDelegate(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // TypeDefIndex: 48219; 0x0000000186727E44-0x0000000186727E58
	
			internal static class SimulationStepTeamUpdateKernel_00000296_BurstDirectCall // TypeDefIndex: 48220
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SimulationStepTeamUpdateKernel_00000296_BurstDirectCall(); // 0x0000000184D1C150-0x0000000184D1C160
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068120); // 0x0000000186727B24-0x0000000186727C28
				private static IntPtr GetFunctionPointer(); // 0x0000000186727C28-0x0000000186727C7C
				public static void Constructor(); // 0x0000000184D1C160-0x0000000184D1C1F0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // 0x0000000186727C7C-0x0000000186727D78
			}
	
			public unsafe delegate void SimulationStepTeamUpdateRangeKernel_00000297_PostfixBurstDelegate(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // TypeDefIndex: 48221; 0x0000000186727E44-0x0000000186727E58
	
			internal static class SimulationStepTeamUpdateRangeKernel_00000297_BurstDirectCall // TypeDefIndex: 48222
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SimulationStepTeamUpdateRangeKernel_00000297_BurstDirectCall(); // 0x0000000184D1C0B0-0x0000000184D1C0C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006813b); // 0x0000000186729228-0x000000018672932C
				private static IntPtr GetFunctionPointer(); // 0x000000018672932C-0x0000000186729380
				public static void Constructor(); // 0x0000000184D1C0C0-0x0000000184D1C150
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // 0x0000000186729380-0x0000000186729474
			}
	
			public unsafe delegate void UpdateWind_00000298_PostfixBurstDelegate(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // TypeDefIndex: 48223; 0x0000000182BED120-0x0000000182BED140
	
			internal static class UpdateWind_00000298_BurstDirectCall // TypeDefIndex: 48224
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateWind_00000298_BurstDirectCall(); // 0x0000000184D1B1B0-0x0000000184D1B1C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068154); // 0x000000018672BE78-0x000000018672BF7C
				private static IntPtr GetFunctionPointer(); // 0x000000018672BF7C-0x000000018672BFD0
				public static void Constructor(); // 0x0000000184D1B1C0-0x0000000184D1B250
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // 0x000000018672BFD0-0x000000018672C0A8
			}
	
			public delegate void UpdateWindTime_00000299_PostfixBurstDelegate(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // TypeDefIndex: 48225; 0x0000000185FD3D28-0x0000000185FD3D3C
	
			internal static class UpdateWindTime_00000299_BurstDirectCall // TypeDefIndex: 48226
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateWindTime_00000299_BurstDirectCall(); // 0x0000000184D1B250-0x0000000184D1B260
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068166); // 0x000000018673E1AC-0x000000018673E2B0
				private static IntPtr GetFunctionPointer(); // 0x000000018673E2B0-0x000000018673E304
				public static void Constructor(); // 0x0000000184D1B260-0x0000000184D1B2F0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static void Invoke(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // 0x000000018673E304-0x000000018673E3A0
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateKernel(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // 0x0000000186728C80-0x0000000186728D18
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateRangeKernel(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // 0x0000000186728D18-0x0000000186728DB0
			[BurstCompile]
			private static unsafe void UpdateWind(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // 0x00000001867291A0-0x0000000186729228
			[BurstCompile]
			private static void UpdateWindTime(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // 0x0000000186728E0C-0x0000000186728E70
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateKernel_BurstManaged(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // 0x0000000186727F20-0x0000000186728C80
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateRangeKernel_BurstManaged(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // 0x0000000186723F30-0x00000001867242F4
			[BurstCompile]
			public static unsafe void UpdateWind_BurstManaged(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // 0x0000000186728E70-0x00000001867291A0
			[BurstCompile]
			public static void UpdateWindTime_BurstManaged(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // 0x0000000186728DB0-0x0000000186728E0C
		}
	
		[BurstCompile]
		private static class PostTeamUpdateJobKernels // TypeDefIndex: 48232
		{
			// Nested types
			public unsafe delegate void PostTeamUpdateKernel_0000029A_PostfixBurstDelegate(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // TypeDefIndex: 48228; 0x0000000181546280-0x00000001815462A0
	
			internal static class PostTeamUpdateKernel_0000029A_BurstDirectCall // TypeDefIndex: 48229
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostTeamUpdateKernel_0000029A_BurstDirectCall(); // 0x0000000184D1C290-0x0000000184D1C2A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068181); // 0x000000018673C2C8-0x000000018673C3CC
				private static IntPtr GetFunctionPointer(); // 0x000000018673C3CC-0x000000018673C420
				public static void Constructor(); // 0x0000000184D1C2A0-0x0000000184D1C330
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // 0x000000018673C420-0x000000018673C4BC
			}
	
			public unsafe delegate void PostTeamUpdateRangeKernel_0000029B_PostfixBurstDelegate(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // TypeDefIndex: 48230; 0x0000000181546280-0x00000001815462A0
	
			internal static class PostTeamUpdateRangeKernel_0000029B_BurstDirectCall // TypeDefIndex: 48231
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostTeamUpdateRangeKernel_0000029B_BurstDirectCall(); // 0x0000000184D1C1F0-0x0000000184D1C200
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068190); // 0x000000018673C618-0x000000018673C71C
				private static IntPtr GetFunctionPointer(); // 0x000000018673C71C-0x000000018673C770
				public static void Constructor(); // 0x0000000184D1C200-0x0000000184D1C290
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x000000018673C770-0x000000018673C824
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PostTeamUpdateKernel(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // 0x000000018673B8B0-0x000000018673B910
			[BurstCompile]
			internal static unsafe void PostTeamUpdateRangeKernel(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x000000018673B960-0x000000018673B9C0
			[BurstCompile]
			public static unsafe void PostTeamUpdateKernel_BurstManaged(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // 0x00000001867329D0-0x00000001867331B8
			[BurstCompile]
			public static unsafe void PostTeamUpdateRangeKernel_BurstManaged(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x000000018673B910-0x000000018673B960
		}
	
		public struct TeamData // TypeDefIndex: 48233
		{
			// Fields
			public BitField64 flag; // 0x00
			public ClothUpdateMode originalUpdateMode; // 0x08
			public ClothUpdateMode updateMode; // 0x0C
			public float frameDeltaTime; // 0x10
			public float time; // 0x14
			public float oldTime; // 0x18
			public float nowUpdateTime; // 0x1C
			public float oldUpdateTime; // 0x20
			public float frameUpdateTime; // 0x24
			public float frameOldTime; // 0x28
			public float timeScale; // 0x2C
			public float nowTimeScale; // 0x30
			public int updateCount; // 0x34
			public int skipCount; // 0x38
			public float frameInterpolation; // 0x3C
			public float gravityRatio; // 0x40
			public float gravityDot; // 0x44
			public int centerTransformIndex; // 0x48
			public int distanceReferenceObjectId; // 0x4C
			public int componentTransformIndex; // 0x50
			public float3 initScale; // 0x54
			public float scaleRatio; // 0x60
			public float negativeScaleSign; // 0x64
			public float3 negativeScaleDirection; // 0x68
			public float3 negativeScaleChange; // 0x74
			public float2 negativeScaleTriangleSign; // 0x80
			public float4 negativeScaleQuaternionValue; // 0x88
			public int componentId; // 0x98
			public int useRelativeTransform; // 0x9C
			public float3 relativeTransformPos; // 0xA0
			public quaternion relativeTransformRot; // 0xAC
			public int syncTeamId; // 0xBC
			public FixedList32Bytes<int> syncParentTeamId; // 0xC0
			public int syncCenterTransformIndex; // 0xE0
			public int interlockingAnimatorId; // 0xE4
			public float animationPoseRatio; // 0xE8
			public int resetSimulationToAnimationPose; // 0xEC
			public float clothSimulateWeight; // 0xF0
			public float clothLodFadeWeight; // 0xF4
			public float clothLodFadeTime; // 0xF8
			public float velocityWeight; // 0xFC
			public float distanceWeight; // 0x100
			public float blendWeight; // 0x104
			public ClothForceMode forceMode; // 0x108
			public float3 impactForce; // 0x10C
			public VirtualMesh.MeshType proxyMeshType; // 0x118
			public DataChunk proxyTransformChunk; // 0x11C
			public DataChunk proxyCommonChunk; // 0x124
			public DataChunk proxyVertexChildDataChunk; // 0x12C
			public DataChunk proxyTriangleChunk; // 0x134
			public DataChunk proxyEdgeChunk; // 0x13C
			public DataChunk proxyMeshChunk; // 0x144
			public DataChunk proxyBoneChunk; // 0x14C
			public DataChunk proxySkinBoneChunk; // 0x154
			public DataChunk baseLineChunk; // 0x15C
			public DataChunk baseLineDataChunk; // 0x164
			public DataChunk fixedDataChunk; // 0x16C
			public DataChunk particleChunk; // 0x174
			public DataChunk colliderChunk; // 0x17C
			public DataChunk colliderTransformChunk; // 0x184
			public int colliderCount; // 0x18C
			public DataChunk distanceStartChunk; // 0x190
			public DataChunk distanceDataChunk; // 0x198
			public DataChunk bendingPairChunk; // 0x1A0
			public DataChunk bendingWriteIndexChunk; // 0x1A8
			public DataChunk bendingBufferChunk; // 0x1B0
			public DataChunk selfPointChunk; // 0x1B8
			public DataChunk selfEdgeChunk; // 0x1C0
			public DataChunk selfTriangleChunk; // 0x1C8
	
			// Properties
			public bool bUseRelativeTransform { get; } // 0x000000018673E0D4-0x000000018673E128 
			public bool IsFixedUpdate { get; } // 0x000000018673DC38-0x000000018673DC88 
			public bool IsUnscaled { get; } // 0x000000018673DFE4-0x000000018673E034 
			public bool IsValid { get; } // 0x00000001837EBDC0-0x00000001837EBDF0 
			public bool IsEnable { get; } // 0x00000001837EBD60-0x00000001837EBDC0 
			public bool IsLODCulled { get; } // 0x00000001837EBD20-0x00000001837EBD60 
			public bool IsProcess { get; } // 0x000000018673DDD8-0x000000018673DE48 
			public bool IsReset { get; } // 0x000000018673DE48-0x000000018673DE98 
			public bool IsKeepReset { get; } // 0x000000018673DCDC-0x000000018673DD30 
			public bool IsInertiaShift { get; } // 0x000000018673DC88-0x000000018673DCDC 
			public bool IsRunning { get; } // 0x000000018673DE98-0x000000018673DEE8 
			public bool IsStepRunning { get; } // 0x000000018673DF3C-0x000000018673DF90 
			public bool IsCameraCullingInvisible { get; } // 0x000000018673DAD4-0x000000018673DB28 
			public bool IsCameraCullingKeep { get; } // 0x000000018673DB28-0x000000018673DB7C 
			public bool IsDistanceCullingInvisible { get; } // 0x000000018673DBE4-0x000000018673DC38 
			public bool IsCullingInvisible { get; } // 0x000000018673DB7C-0x000000018673DBE4 
			public bool IsSpring { get; } // 0x000000018673DEE8-0x000000018673DF3C 
			public bool IsNegativeScale { get; } // 0x000000018673DD84-0x000000018673DDD8 
			public bool IsNegativeScaleTeleport { get; } // 0x000000018673DD30-0x000000018673DD84 
			public bool IsTangent { get; } // 0x000000018673DF90-0x000000018673DFE4 
			public int ParticleCount { get; } // 0x000000018673E034-0x000000018673E084 
			public int ColliderCount { get; } // 0x000000018448A380-0x000000018448A3B0 
			public int BaseLineCount { get; } // 0x000000018673D9E4-0x000000018673DA34 
			public int TriangleCount { get; } // 0x000000018673E084-0x000000018673E0D4 
			public int EdgeCount { get; } // 0x000000018673DA34-0x000000018673DA84 
			public float InitScale { get; } // 0x000000018673DA84-0x000000018673DAD4 
		}
	
		public struct MappingData : IValid // TypeDefIndex: 48234
		{
			// Fields
			public int teamId; // 0x00
			public int centerTransformIndex; // 0x04
			public DataChunk mappingCommonChunk; // 0x08
			public float4x4 toProxyMatrix; // 0x10
			public quaternion toProxyRotation; // 0x50
			public bool sameSpace; // 0x60
			public double4x4 toMappingMatrix; // 0x68
			public quaternion toMappingRotation; // 0xE8
			public float scaleRatio; // 0xF8
	
			// Properties
			public int VertexCount { get; } // 0x000000018673B864-0x000000018673B8B0 
	
			// Methods
			public bool IsValid(); // 0x000000018673B814-0x000000018673B864
		}
	
		[BurstCompile]
		private struct AlwaysTeamUpdatePreJob : IJob // TypeDefIndex: 48235
		{
			// Fields
			public NativeArray<TeamData> teamDataArray; // 0x00
			public NativeArray<ClothParameters> parameterArray; // 0x10
			public NativeParallelHashMap<int, int> comp2SuspendCounterMap; // 0x20
			public NativeParallelHashMap<int, int> comp2TeamIdMap; // 0x30
			public NativeParallelHashMap<int, int> comp2SyncPartnerCompMap; // 0x40
			public NativeParallelHashMap<int, int> comp2SyncTopCompMap; // 0x50
			public NativeParallelHashSet<int> selfCollisionUpdateSet; // 0x60
			public NativeReference<int> edgeColliderCollisionCountBuff; // 0x70
	
			// Methods
			public void Execute(); // 0x0000000186733DD8-0x0000000186734FCC
		}
	
		[BurstCompile]
		private struct AlwaysTeamUpdatePostJob : IJob // TypeDefIndex: 48236
		{
			// Fields
			public int teamCount; // 0x00
			public float unityFrameDeltaTime; // 0x04
			public float unityFrameFixedDeltaTime; // 0x08
			public float unityFrameUnscaledDeltaTime; // 0x0C
			public float globalTimeScale; // 0x10
			public float simulationDeltaTime; // 0x14
			public int maxSimmulationCountPerFrame; // 0x18
			public NativeReference<int> maxUpdateCount; // 0x20
			public NativeArray<TeamData> teamDataArray; // 0x30
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x40
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x50
			public NativeArray<float3> componentPositionArray; // 0x60
			public bool hasMainCamera; // 0x70
			public NativeParallelHashMap<int, int> comp2TeamIdMap; // 0x78
			public NativeParallelHashMap<int, int> comp2SyncTopCompMap; // 0x88
			public NativeParallelHashMap<int, int> animatorUpdateModeMap; // 0x98
			public NativeArray<int> teamAnchorTransformIndexArray; // 0xA8
			public NativeArray<int> teamDistanceTransformIndexArray; // 0xB8
			public NativeParallelHashMap<int, float3> transformPositionMap; // 0xC8
			public NativeParallelHashMap<int, quaternion> transformRotationMap; // 0xD8
			public NativeList<int> cullingDirtyList; // 0xE8
	
			// Methods
			public void Execute(); // 0x0000000186733450-0x0000000186733DD8
			private void DistanceCullingUpdate(int teamId, ref TeamData tdata); // 0x00000001867331B8-0x0000000186733450
		}
	
		[BurstCompile]
		public static class CalcCenterAndInertiaAndWindKernels // TypeDefIndex: 48243
		{
			// Nested types
			public unsafe delegate void CalcCenterAndInertiaAndWindKernel_000002BB_PostfixBurstDelegate(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // TypeDefIndex: 48237; 0x00000001867383D0-0x0000000186738484
	
			internal static class CalcCenterAndInertiaAndWindKernel_000002BB_BurstDirectCall // TypeDefIndex: 48238
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcCenterAndInertiaAndWindKernel_000002BB_BurstDirectCall(); // 0x0000000184D1D4B0-0x0000000184D1D4C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068201); // 0x0000000186737F74-0x0000000186738078
				private static IntPtr GetFunctionPointer(); // 0x0000000186738078-0x00000001867380CC
				public static void Constructor(); // 0x0000000184D1D4C0-0x0000000184D1D550
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // 0x00000001867380CC-0x00000001867382AC
			}
	
			public unsafe delegate void CalcCenterAndInertiaAndWindRangeKernel_000002BC_PostfixBurstDelegate(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // TypeDefIndex: 48239; 0x00000001867383D0-0x0000000186738484
	
			internal static class CalcCenterAndInertiaAndWindRangeKernel_000002BC_BurstDirectCall // TypeDefIndex: 48240
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcCenterAndInertiaAndWindRangeKernel_000002BC_BurstDirectCall(); // 0x0000000184D1D410-0x0000000184D1D420
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068234); // 0x000000018673B3BC-0x000000018673B4C0
				private static IntPtr GetFunctionPointer(); // 0x000000018673B4C0-0x000000018673B514
				public static void Constructor(); // 0x0000000184D1D420-0x0000000184D1D4B0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // 0x000000018673B514-0x000000018673B6F0
			}
	
			public unsafe delegate void Wind_000002BD_PostfixBurstDelegate(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // TypeDefIndex: 48241; 0x0000000182BED120-0x0000000182BED140
	
			internal static class Wind_000002BD_BurstDirectCall // TypeDefIndex: 48242
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Wind_000002BD_BurstDirectCall(); // 0x0000000184D1AFD0-0x0000000184D1AFE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068255); // 0x000000018674072C-0x0000000186740830
				private static IntPtr GetFunctionPointer(); // 0x0000000186740830-0x0000000186740884
				public static void Constructor(); // 0x0000000184D1AFE0-0x0000000184D1B070
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // 0x0000000186740884-0x0000000186740954
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindKernel(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // 0x000000018673AA38-0x000000018673AB40
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindRangeKernel(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // 0x000000018673AB40-0x000000018673AC48
			[BurstCompile]
			public static unsafe void Wind(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // 0x000000018673B338-0x000000018673B3BC
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindKernel_BurstManaged(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // 0x000000018673854C-0x000000018673AA38
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindRangeKernel_BurstManaged(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // 0x000000018673149C-0x0000000186731CA8
			[BurstCompile]
			public static unsafe void Wind_BurstManaged(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // 0x000000018673AC48-0x000000018673B338
		}
	
		[BurstCompile]
		private struct CalcCenterAndInertiaAndWindJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48244
		{
			// Fields
			public float simulationDeltaTime; // 0x00
			public NativeArray<TeamData> teamDataArray; // 0x08
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x18
			public NativeArray<TeamWindData> teamWindArray; // 0x28
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x38
			[ReadOnly]
			public NativeArray<double3> positions; // 0x48
			[ReadOnly]
			public NativeArray<quaternion> rotations; // 0x58
			[ReadOnly]
			public NativeArray<quaternion> vertexBindPoseRotations; // 0x68
			[ReadOnly]
			public NativeArray<ushort> fixedArray; // 0x78
			[ReadOnly]
			public NativeArray<double3> transformPositionArray; // 0x88
			[ReadOnly]
			public NativeArray<quaternion> transformRotationArray; // 0x98
			[ReadOnly]
			public NativeArray<float3> transformScaleArray; // 0xA8
			public int windZoneCount; // 0xB8
			[ReadOnly]
			public NativeArray<WindManager.WindData> windDataArray; // 0xC0
			[ReadOnly]
			public int _indexCount; // 0xD0
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183D46500-0x0000000183D46540
			[IDTag(1)]
			public void Execute(); // 0x00000001867375F8-0x0000000186737670
			[IDTag(0)]
			public void Execute(int teamId); // 0x0000000186734FCC-0x00000001867375F8
			private void Wind(int teamId, [IsReadOnly] in ClothParameters param, [IsReadOnly] in double3 centerWorldPos); // 0x000000018673781C-0x0000000186737F74
			public void UnsafeDo(); // 0x0000000186737670-0x000000018673781C
		}
	
		[BurstCompile]
		private struct SimulationStepTeamUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48245
		{
			// Fields
			public int updateIndex; // 0x00
			public float simulationDeltaTime; // 0x04
			public NativeArray<TeamData> teamDataArray; // 0x08
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x18
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x28
			public NativeArray<TeamWindData> teamWindArray; // 0x38
			[ReadOnly]
			public int _indexCount; // 0x48
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183C239C0-0x0000000183C23A30
			[IDTag(1)]
			public void Execute(); // 0x000000018673D468-0x000000018673D4DC
			[IDTag(0)]
			public void Execute(int teamId); // 0x000000018673C8AC-0x000000018673D468
			private void UpdateWind(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata); // 0x000000018673D66C-0x000000018673D9E4
			private void UpdateWindTime(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // 0x000000018673D59C-0x000000018673D66C
			public void UnsafeDo(); // 0x000000018673D4DC-0x000000018673D59C
		}
	
		[BurstCompile]
		private struct PostTeamUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48246
		{
			// Fields
			public NativeArray<TeamData> teamDataArray; // 0x00
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x10
			[ReadOnly]
			public int _indexCount; // 0x20
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183DF2840-0x0000000183DF2880
			[IDTag(1)]
			public void Execute(); // 0x000000018673B9C0-0x000000018673BA34
			[IDTag(0)]
			public void Execute(int teamId); // 0x000000018673BA34-0x000000018673C244
			public void UnsafeDo(); // 0x000000018673C244-0x000000018673C2C8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 48247
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<ClothProcess> __9__134_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018673E148-0x000000018673E1AC
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _MonitoringProcess_b__134_0(ClothProcess cprocess); // 0x000000018673E128-0x000000018673E148
		}
	
		// Constructors
		public TeamManager(); // 0x00000001835B85F0-0x00000001835B8870
		static TeamManager(); // 0x00000001849D9A90-0x00000001849D9C90
	
		// Methods
		internal void UpdateTeamAnimatorData(ExNativeArray<short> teamIdArray, TransformAccessArray transformArray); // 0x000000018672B048-0x000000018672BE78
		internal void ClearTeamAnimatorData(int teamId); // 0x0000000183E93180-0x0000000183E93210
		internal void AddTeamAnimatorData(int teamId, ClothProcess cprocess); // 0x00000001839C6240-0x00000001839C6400
		internal void AddAnimatorTransform(int teamId, Transform t); // 0x0000000183CF8B20-0x0000000183CF8BD0
		internal void MarkAnimatorTransformDirty(int teamId, Transform t); // 0x0000000184A379E0-0x0000000184A37AA0
		public void Dispose(); // 0x00000001835B97D0-0x00000001835B9CA0
		public void EnterdEditMode(); // 0x00000001867295C8-0x0000000186729618
		public void Initialize(); // 0x0000000183B6D0B0-0x0000000183B6DD30
		public bool IsValid(); // 0x000000018672AEA0-0x000000018672AEEC
		internal int AddTeam(ClothProcess cprocess, ClothParameters clothParams); // 0x00000001839C5A70-0x00000001839C60F0
		internal void RemoveTeam(int teamId); // 0x0000000183E92E60-0x0000000183E93180
		public void SetEnable(int teamId, bool sw); // 0x00000001837EC7E0-0x00000001837EC980
		public bool IsEnable(int teamId); // 0x0000000182F95AC0-0x0000000182F95B50
		internal void SetSkipWriting(int teamId, bool sw); // 0x000000018672AF88-0x000000018672B048
		public bool ContainsTeamData(int teamId); // 0x00000001837EBCA0-0x00000001837EBD20
		public ref TeamData GetTeamDataRef(int teamId); // 0x0000000182F94A50-0x0000000182F94D30
		public ref FixedList64Bytes<short> GetTeamMappingRef(int teamId); // 0x00000001867296A0-0x0000000186729728
		public ref ClothParameters GetParametersRef(int teamId); // 0x00000001837EBE10-0x00000001837EBE80
		internal ref InertiaConstraint.CenterData GetCenterDataRef(int teamId); // 0x0000000186729618-0x00000001867296A0
		public ClothProcess GetClothProcess(int teamId); // 0x00000001837EBC30-0x00000001837EBCA0
		internal void CameraCullingPreProcess(); // 0x00000001835BD8F0-0x00000001835BEA60
		internal void CameraCullingPostProcess(); // 0x0000000182F93820-0x0000000182F949B0
		private static bool ShouldResetSimulationToAnimationPose(BeyondBoneCloth cloth); // 0x00000001835BD650-0x00000001835BD710
		private static void ApplyWeightDrivenSimulationPosePolicy(ref TeamData tdata, BeyondBoneCloth cloth); // 0x00000001835BD4A0-0x00000001835BD650
		internal void AlwaysTeamUpdate(); // 0x00000001835BEA60-0x00000001835C1C30
		private void RemoveSyncParent(ref TeamData tdata, int parentTeamId); // 0x000000018672AEEC-0x000000018672AF88
		internal JobHandle CalcCenterAndInertiaAndWind(JobHandle jobHandle); // 0x00000001835BC3E0-0x00000001835BC760
		internal JobHandle SimulationStepTeamUpdate(int updateIndex, JobHandle jobHandle); // 0x0000000182F8E3A0-0x0000000182F8E710
		internal JobHandle PostTeamUpdate(JobHandle jobHandle); // 0x0000000183DC03B0-0x0000000183DC05F0
		internal void AddMonitoringProcess(ClothProcess cprocess); // 0x0000000186729540-0x00000001867295C8
		internal void RemoveMonitoringProcess(ClothProcess cprocess); // 0x0000000183E8BBB0-0x0000000183E8BC40
		private void MonitoringProcess(bool force); // 0x00000001835BCAB0-0x00000001835BD130
		private void MonitoringProcessUpdate(); // 0x00000001835BCA40-0x00000001835BCAB0
		public void InformationLog(StringBuilder allsb); // 0x0000000186729728-0x000000018672AEA0
		public static void Initialize_PostTeamUpdateJobKernels_PostTeamUpdateKernel_0000029A_BurstDirectCall(); // 0x00000001844F6A50-0x00000001844F6AB0
		public static void Initialize_PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_0000029B_BurstDirectCall(); // 0x00000001844F6AB0-0x00000001844F6B10
	}

	public class VirtualMeshManager : IManager, IValid // TypeDefIndex: 48308
	{
		// Fields
		public ExNativeArray<short> teamIds; // 0x10
		public ExNativeArray<VertexAttribute> attributes; // 0x18
		public ExNativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x20
		public ExNativeArray<float3> vertexBindPosePositions; // 0x28
		public ExNativeArray<quaternion> vertexBindPoseRotations; // 0x30
		public ExNativeArray<float> vertexDepths; // 0x38
		public ExNativeArray<int> vertexRootIndices; // 0x40
		public ExNativeArray<float3> vertexLocalPositions; // 0x48
		public ExNativeArray<quaternion> vertexLocalRotations; // 0x50
		public ExNativeArray<int> vertexParentIndices; // 0x58
		public ExNativeArray<uint> vertexChildIndexArray; // 0x60
		public ExNativeArray<ushort> vertexChildDataArray; // 0x68
		public ExNativeArray<quaternion> normalAdjustmentRotations; // 0x70
		public ExNativeArray<float2> uv; // 0x78
		public ExNativeArray<short> triangleTeamIdArray; // 0x80
		public ExNativeArray<int3> triangles; // 0x88
		public ExNativeArray<float3> triangleNormals; // 0x90
		public ExNativeArray<float3> triangleTangents; // 0x98
		public ExNativeArray<short> edgeTeamIdArray; // 0xA0
		public ExNativeArray<int2> edges; // 0xA8
		public ExNativeArray<ExBitFlag8> edgeFlags; // 0xB0
		public ExNativeArray<ExBitFlag8> baseLineFlags; // 0xB8
		public ExNativeArray<short> baseLineTeamIds; // 0xC0
		public ExNativeArray<ushort> baseLineStartDataIndices; // 0xC8
		public ExNativeArray<ushort> baseLineDataCounts; // 0xD0
		public ExNativeArray<ushort> baseLineData; // 0xD8
		public ExNativeArray<float3> localPositions; // 0xE0
		public ExNativeArray<float3> localNormals; // 0xE8
		public ExNativeArray<float3> localTangents; // 0xF0
		public ExNativeArray<VirtualMeshBoneWeight> boneWeights; // 0xF8
		public ExNativeArray<int> skinBoneTransformIndices; // 0x100
		public ExNativeArray<float4x4> skinBoneBindPoses; // 0x108
		public ExNativeArray<quaternion> vertexToTransformRotations; // 0x110
		public ExNativeArray<double3> positions; // 0x118
		public ExNativeArray<quaternion> rotations; // 0x120
		public ExNativeArray<short> mappingIdArray; // 0x128
		public ExNativeArray<int> mappingReferenceIndices; // 0x130
		public ExNativeArray<VertexAttribute> mappingAttributes; // 0x138
		public ExNativeArray<float3> mappingLocalPositins; // 0x140
		public ExNativeArray<float3> mappingLocalNormals; // 0x148
		public ExNativeArray<float3> mappingLocalTangents; // 0x150
		public ExNativeArray<VirtualMeshBoneWeight> mappingBoneWeights; // 0x158
		public ExNativeArray<float3> mappingPositions; // 0x160
		public ExNativeArray<float3> mappingNormals; // 0x168
		public ExNativeArray<float3> mappingTangents; // 0x170
		private bool isValid; // 0x178
	
		// Properties
		public int ProxyVertexCount { get; } // 0x0000000182F8C430-0x0000000182F8C4A0 
		public int ProxyTriangleCount { get; } // 0x0000000182F8C3C0-0x0000000182F8C430 
		public int ProxyEdgeCount { get; } // 0x0000000186740634-0x00000001867406B0 
		public int ProxyBaseLineCount { get; } // 0x0000000182F8D970-0x0000000182F8D9E0 
		public int ProxyLocalPositionCount { get; } // 0x00000001867406B0-0x000000018674072C 
		public int MappingVertexCount { get; } // 0x00000001867405B8-0x0000000186740634 
	
		// Nested types
		[BurstCompile]
		public static class CalcProxyMeshSkinningKernels // TypeDefIndex: 48253
		{
			// Nested types
			public unsafe delegate void CalcProxyMeshSkinningKernel_000002E6_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // TypeDefIndex: 48249; 0x00000001866A5628-0x00000001866A56D0
	
			internal static class CalcProxyMeshSkinningKernel_000002E6_BurstDirectCall // TypeDefIndex: 48250
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxyMeshSkinningKernel_000002E6_BurstDirectCall(); // 0x0000000184D1D0F0-0x0000000184D1D100
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000682d9); // 0x0000000186748630-0x0000000186748734
				private static IntPtr GetFunctionPointer(); // 0x0000000186748734-0x0000000186748788
				public static void Constructor(); // 0x0000000184D1D100-0x0000000184D1D190
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // 0x0000000186748788-0x0000000186748948
			}
	
			public unsafe delegate void CalcProxyMeshSkinningRangeKernel_000002E7_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // TypeDefIndex: 48251; 0x00000001866A5B60-0x00000001866A5C0C
	
			internal static class CalcProxyMeshSkinningRangeKernel_000002E7_BurstDirectCall // TypeDefIndex: 48252
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxyMeshSkinningRangeKernel_000002E7_BurstDirectCall(); // 0x0000000184D1D050-0x0000000184D1D060
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068309); // 0x0000000186748C3C-0x0000000186748D40
				private static IntPtr GetFunctionPointer(); // 0x0000000186748D40-0x0000000186748D94
				public static void Constructor(); // 0x0000000184D1D060-0x0000000184D1D0F0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // 0x0000000186748D94-0x0000000186748F5C
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // 0x0000000186748A40-0x0000000186748B3C
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // 0x0000000186748B3C-0x0000000186748C3C
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // 0x000000018674176C-0x0000000186741E0C
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // 0x0000000186741E0C-0x0000000186742DB4
		}
	
		[BurstCompile]
		private static class CreatePostProxyMeshUpdateListJobKernels // TypeDefIndex: 48258
		{
			// Nested types
			public unsafe delegate void CreatePostProxyMeshUpdateListKernel_000002E8_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // TypeDefIndex: 48254; 0x00000001866A7290-0x00000001866A7304
	
			internal static class CreatePostProxyMeshUpdateListKernel_000002E8_BurstDirectCall // TypeDefIndex: 48255
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreatePostProxyMeshUpdateListKernel_000002E8_BurstDirectCall(); // 0x0000000184D1CAB0-0x0000000184D1CAC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068359); // 0x000000018674EFC0-0x000000018674F0C4
				private static IntPtr GetFunctionPointer(); // 0x000000018674F0C4-0x000000018674F118
				public static void Constructor(); // 0x0000000184D1CAC0-0x0000000184D1CB50
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // 0x000000018674F118-0x000000018674F260
			}
	
			public unsafe delegate void CreatePostProxyMeshUpdateListRangeKernel_000002E9_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // TypeDefIndex: 48256; 0x00000001866A7290-0x00000001866A7304
	
			internal static class CreatePostProxyMeshUpdateListRangeKernel_000002E9_BurstDirectCall // TypeDefIndex: 48257
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreatePostProxyMeshUpdateListRangeKernel_000002E9_BurstDirectCall(); // 0x0000000184D1CA10-0x0000000184D1CA20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006837d); // 0x000000018674F404-0x000000018674F508
				private static IntPtr GetFunctionPointer(); // 0x000000018674F508-0x000000018674F55C
				public static void Constructor(); // 0x0000000184D1CA20-0x0000000184D1CAB0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // 0x000000018674F55C-0x000000018674F6CC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CreatePostProxyMeshUpdateListKernel(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // 0x000000018674E9C4-0x000000018674EA88
			[BurstCompile]
			internal static unsafe void CreatePostProxyMeshUpdateListRangeKernel(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // 0x000000018674EB40-0x000000018674EC04
			[BurstCompile]
			public static unsafe void CreatePostProxyMeshUpdateListKernel_BurstManaged(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // 0x0000000186743868-0x0000000186743A8C
			[BurstCompile]
			public static unsafe void CreatePostProxyMeshUpdateListRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // 0x000000018674EA88-0x000000018674EB40
		}
	
		[BurstCompile]
		private static class CalcLineNormalTangentJobKernels // TypeDefIndex: 48263
		{
			// Nested types
			public unsafe delegate void CalcLineNormalTangentKernel_000002EA_PostfixBurstDelegate(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // TypeDefIndex: 48259; 0x000000018674680C-0x00000001867468DC
	
			internal static class CalcLineNormalTangentKernel_000002EA_BurstDirectCall // TypeDefIndex: 48260
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcLineNormalTangentKernel_000002EA_BurstDirectCall(); // 0x0000000184D1D370-0x0000000184D1D380
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000683f3); // 0x0000000186746378-0x000000018674647C
				private static IntPtr GetFunctionPointer(); // 0x000000018674647C-0x00000001867464D0
				public static void Constructor(); // 0x0000000184D1D380-0x0000000184D1D410
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // 0x00000001867464D0-0x00000001867466F0
			}
	
			public unsafe delegate void CalcLineNormalTangentRangeKernel_000002EB_PostfixBurstDelegate(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // TypeDefIndex: 48261; 0x0000000186746DE4-0x0000000186746EB4
	
			internal static class CalcLineNormalTangentRangeKernel_000002EB_BurstDirectCall // TypeDefIndex: 48262
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcLineNormalTangentRangeKernel_000002EB_BurstDirectCall(); // 0x0000000184D1D2D0-0x0000000184D1D2E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006842c); // 0x00000001867469B0-0x0000000186746AB4
				private static IntPtr GetFunctionPointer(); // 0x0000000186746AB4-0x0000000186746B08
				public static void Constructor(); // 0x0000000184D1D2E0-0x0000000184D1D370
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // 0x0000000186746B08-0x0000000186746D24
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcLineNormalTangentKernel(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // 0x00000001867456E4-0x000000018674580C
			[BurstCompile]
			internal static unsafe void CalcLineNormalTangentRangeKernel(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // 0x000000018674580C-0x0000000186745938
			[BurstCompile]
			public static unsafe void CalcLineNormalTangentKernel_BurstManaged(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // 0x0000000186744FB0-0x00000001867456E4
			[BurstCompile]
			public static unsafe void CalcLineNormalTangentRangeKernel_BurstManaged(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // 0x0000000186741214-0x000000018674133C
		}
	
		[BurstCompile]
		private static class WriteTransformDataJobKernels // TypeDefIndex: 48268
		{
			// Nested types
			public unsafe delegate void WriteTransformDataKernel_000002EC_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // TypeDefIndex: 48264; 0x0000000186232B74-0x0000000186232BDC
	
			internal static class WriteTransformDataKernel_000002EC_BurstDirectCall // TypeDefIndex: 48265
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformDataKernel_000002EC_BurstDirectCall(); // 0x0000000184D1ADF0-0x0000000184D1AE00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068479); // 0x0000000186754C48-0x0000000186754D4C
				private static IntPtr GetFunctionPointer(); // 0x0000000186754D4C-0x0000000186754DA0
				public static void Constructor(); // 0x0000000184D1AE00-0x0000000184D1AE90
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // 0x0000000186754DA0-0x0000000186754ECC
			}
	
			public unsafe delegate void WriteTransformDataRangeKernel_000002ED_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // TypeDefIndex: 48266; 0x000000018621F254-0x000000018621F2BC
	
			internal static class WriteTransformDataRangeKernel_000002ED_BurstDirectCall // TypeDefIndex: 48267
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformDataRangeKernel_000002ED_BurstDirectCall(); // 0x0000000184D1AD50-0x0000000184D1AD60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006849a); // 0x0000000186754F8C-0x0000000186755090
				private static IntPtr GetFunctionPointer(); // 0x0000000186755090-0x00000001867550E4
				public static void Constructor(); // 0x0000000184D1AD60-0x0000000184D1ADF0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // 0x00000001867550E4-0x0000000186755238
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteTransformDataKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // 0x0000000186754520-0x00000001867545D4
			[BurstCompile]
			internal static unsafe void WriteTransformDataRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // 0x0000000186754680-0x0000000186754738
			[BurstCompile]
			public static unsafe void WriteTransformDataKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // 0x000000018674454C-0x0000000186744FB0
			[BurstCompile]
			public static unsafe void WriteTransformDataRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // 0x00000001867545D4-0x0000000186754680
		}
	
		[BurstCompile]
		private static class WriteTransformLocalDataJobKernels // TypeDefIndex: 48273
		{
			// Nested types
			public unsafe delegate void WriteTransformLocalDataKernel_000002EE_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // TypeDefIndex: 48269; 0x000000018621C6AC-0x000000018621C72C
	
			internal static class WriteTransformLocalDataKernel_000002EE_BurstDirectCall // TypeDefIndex: 48270
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformLocalDataKernel_000002EE_BurstDirectCall(); // 0x0000000184D1ACB0-0x0000000184D1ACC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000684eb); // 0x0000000186755E0C-0x0000000186755F10
				private static IntPtr GetFunctionPointer(); // 0x0000000186755F10-0x0000000186755F64
				public static void Constructor(); // 0x0000000184D1ACC0-0x0000000184D1AD50
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // 0x0000000186755F64-0x00000001867560CC
			}
	
			public unsafe delegate void WriteTransformLocalDataRangeKernel_000002EF_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // TypeDefIndex: 48271; 0x00000001867565D8-0x0000000186756658
	
			internal static class WriteTransformLocalDataRangeKernel_000002EF_BurstDirectCall // TypeDefIndex: 48272
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformLocalDataRangeKernel_000002EF_BurstDirectCall(); // 0x0000000184D1AC10-0x0000000184D1AC20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068512); // 0x0000000186756278-0x000000018675637C
				private static IntPtr GetFunctionPointer(); // 0x000000018675637C-0x00000001867563D0
				public static void Constructor(); // 0x0000000184D1AC20-0x0000000184D1ACB0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // 0x00000001867563D0-0x0000000186756560
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteTransformLocalDataKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // 0x00000001867555E8-0x00000001867556B8
			[BurstCompile]
			internal static unsafe void WriteTransformLocalDataRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // 0x0000000186755784-0x0000000186755854
			[BurstCompile]
			public static unsafe void WriteTransformLocalDataKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // 0x0000000186755238-0x00000001867555E8
			[BurstCompile]
			public static unsafe void WriteTransformLocalDataRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // 0x00000001867556B8-0x0000000186755784
		}
	
		[BurstCompile]
		private static class CalcProxySkinningJobKernels // TypeDefIndex: 48278
		{
			// Nested types
			public unsafe delegate void CalcProxySkinningKernel_000002F0_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // TypeDefIndex: 48274; 0x000000018674B540-0x000000018674B600
	
			internal static class CalcProxySkinningKernel_000002F0_BurstDirectCall // TypeDefIndex: 48275
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxySkinningKernel_000002F0_BurstDirectCall(); // 0x0000000184D1CFB0-0x0000000184D1CFC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068583); // 0x000000018674B0D8-0x000000018674B1DC
				private static IntPtr GetFunctionPointer(); // 0x000000018674B1DC-0x000000018674B230
				public static void Constructor(); // 0x0000000184D1CFC0-0x0000000184D1D050
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // 0x000000018674B230-0x000000018674B430
			}
	
			public unsafe delegate void CalcProxySkinningRangeKernel_000002F1_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // TypeDefIndex: 48276; 0x000000018674B540-0x000000018674B600
	
			internal static class CalcProxySkinningRangeKernel_000002F1_BurstDirectCall // TypeDefIndex: 48277
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxySkinningRangeKernel_000002F1_BurstDirectCall(); // 0x0000000184D1CF10-0x0000000184D1CF20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000685b9); // 0x000000018674B6D4-0x000000018674B7D8
				private static IntPtr GetFunctionPointer(); // 0x000000018674B7D8-0x000000018674B82C
				public static void Constructor(); // 0x0000000184D1CF20-0x0000000184D1CFB0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // 0x000000018674B82C-0x000000018674BA24
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcProxySkinningKernel(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // 0x0000000186749E08-0x0000000186749F20
			[BurstCompile]
			internal static unsafe void CalcProxySkinningRangeKernel(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // 0x0000000186749F20-0x000000018674A038
			[BurstCompile]
			public static unsafe void CalcProxySkinningKernel_BurstManaged(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // 0x0000000186748F5C-0x0000000186749E08
			[BurstCompile]
			public static unsafe void CalcProxySkinningRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // 0x0000000186742DB4-0x0000000186743868
		}
	
		[BurstCompile]
		private static class CalcMeshConvertMatrixJobKernels // TypeDefIndex: 48283
		{
			// Nested types
			public unsafe delegate void CalcMeshConvertMatrixKernel_000002F2_PostfixBurstDelegate(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // TypeDefIndex: 48279; 0x0000000182BED120-0x0000000182BED140
	
			internal static class CalcMeshConvertMatrixKernel_000002F2_BurstDirectCall // TypeDefIndex: 48280
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcMeshConvertMatrixKernel_000002F2_BurstDirectCall(); // 0x0000000184D1D230-0x0000000184D1D240
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000685f3); // 0x00000001867476FC-0x0000000186747800
				private static IntPtr GetFunctionPointer(); // 0x0000000186747800-0x0000000186747854
				public static void Constructor(); // 0x0000000184D1D240-0x0000000184D1D2D0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // 0x0000000186747854-0x0000000186747928
			}
	
			public unsafe delegate void CalcMeshConvertMatrixRangeKernel_000002F3_PostfixBurstDelegate(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // TypeDefIndex: 48281; 0x0000000182BED120-0x0000000182BED140
	
			internal static class CalcMeshConvertMatrixRangeKernel_000002F3_BurstDirectCall // TypeDefIndex: 48282
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcMeshConvertMatrixRangeKernel_000002F3_BurstDirectCall(); // 0x0000000184D1D190-0x0000000184D1D1A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006860b); // 0x00000001867479E0-0x0000000186747AE4
				private static IntPtr GetFunctionPointer(); // 0x0000000186747AE4-0x0000000186747B38
				public static void Constructor(); // 0x0000000184D1D1A0-0x0000000184D1D230
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // 0x0000000186747B38-0x0000000186747C34
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcMeshConvertMatrixKernel(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // 0x0000000186746F88-0x0000000186747010
			[BurstCompile]
			internal static unsafe void CalcMeshConvertMatrixRangeKernel(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // 0x0000000186747090-0x0000000186747118
			[BurstCompile]
			public static unsafe void CalcMeshConvertMatrixKernel_BurstManaged(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // 0x000000018674133C-0x000000018674176C
			[BurstCompile]
			public static unsafe void CalcMeshConvertMatrixRangeKernel_BurstManaged(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // 0x0000000186747010-0x0000000186747090
		}
	
		[BurstCompile]
		private static class CalcTriangleNormalTangentJobKernels // TypeDefIndex: 48288
		{
			// Nested types
			public unsafe delegate void CalcTriangleNormalTangentKernel_000002F4_PostfixBurstDelegate(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // TypeDefIndex: 48284; 0x0000000186232B74-0x0000000186232BDC
	
			internal static class CalcTriangleNormalTangentKernel_000002F4_BurstDirectCall // TypeDefIndex: 48285
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcTriangleNormalTangentKernel_000002F4_BurstDirectCall(); // 0x0000000184D1CE70-0x0000000184D1CE80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006864d); // 0x000000018674C84C-0x000000018674C950
				private static IntPtr GetFunctionPointer(); // 0x000000018674C950-0x000000018674C9A4
				public static void Constructor(); // 0x0000000184D1CE80-0x0000000184D1CF10
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // 0x000000018674C9A4-0x000000018674CAD0
			}
	
			public unsafe delegate void CalcTriangleNormalTangentRangeKernel_000002F5_PostfixBurstDelegate(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // TypeDefIndex: 48286; 0x000000018621F254-0x000000018621F2BC
	
			internal static class CalcTriangleNormalTangentRangeKernel_000002F5_BurstDirectCall // TypeDefIndex: 48287
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcTriangleNormalTangentRangeKernel_000002F5_BurstDirectCall(); // 0x0000000184D1CDD0-0x0000000184D1CDE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006866e); // 0x000000018674CC64-0x000000018674CD68
				private static IntPtr GetFunctionPointer(); // 0x000000018674CD68-0x000000018674CDBC
				public static void Constructor(); // 0x0000000184D1CDE0-0x0000000184D1CE70
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // 0x000000018674CDBC-0x000000018674CF10
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcTriangleNormalTangentKernel(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // 0x000000018674BF74-0x000000018674C028
			[BurstCompile]
			internal static unsafe void CalcTriangleNormalTangentRangeKernel(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // 0x000000018674C0D4-0x000000018674C18C
			[BurstCompile]
			public static unsafe void CalcTriangleNormalTangentKernel_BurstManaged(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // 0x000000018674BB34-0x000000018674BF74
			[BurstCompile]
			public static unsafe void CalcTriangleNormalTangentRangeKernel_BurstManaged(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // 0x000000018674C028-0x000000018674C0D4
		}
	
		[BurstCompile]
		private static class CalcVertexNormalTangentFromTriangleJobKernels // TypeDefIndex: 48293
		{
			// Nested types
			public unsafe delegate void CalcVertexNormalTangentFromTriangleKernel_000002F6_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // TypeDefIndex: 48289; 0x0000000186232B74-0x0000000186232BDC
	
			internal static class CalcVertexNormalTangentFromTriangleKernel_000002F6_BurstDirectCall // TypeDefIndex: 48290
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcVertexNormalTangentFromTriangleKernel_000002F6_BurstDirectCall(); // 0x0000000184D1CD30-0x0000000184D1CD40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000686b3); // 0x000000018674DF40-0x000000018674E044
				private static IntPtr GetFunctionPointer(); // 0x000000018674E044-0x000000018674E098
				public static void Constructor(); // 0x0000000184D1CD40-0x0000000184D1CDD0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // 0x000000018674E098-0x000000018674E1C4
			}
	
			public unsafe delegate void CalcVertexNormalTangentFromTriangleRangeKernel_000002F7_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // TypeDefIndex: 48291; 0x000000018621F254-0x000000018621F2BC
	
			internal static class CalcVertexNormalTangentFromTriangleRangeKernel_000002F7_BurstDirectCall // TypeDefIndex: 48292
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcVertexNormalTangentFromTriangleRangeKernel_000002F7_BurstDirectCall(); // 0x0000000184D1CC90-0x0000000184D1CCA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000686d4); // 0x000000018674E284-0x000000018674E388
				private static IntPtr GetFunctionPointer(); // 0x000000018674E388-0x000000018674E3DC
				public static void Constructor(); // 0x0000000184D1CCA0-0x0000000184D1CD30
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // 0x000000018674E3DC-0x000000018674E530
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcVertexNormalTangentFromTriangleKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // 0x000000018674D598-0x000000018674D64C
			[BurstCompile]
			internal static unsafe void CalcVertexNormalTangentFromTriangleRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // 0x000000018674D6F8-0x000000018674D7B0
			[BurstCompile]
			public static unsafe void CalcVertexNormalTangentFromTriangleKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // 0x000000018674D048-0x000000018674D598
			[BurstCompile]
			public static unsafe void CalcVertexNormalTangentFromTriangleRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // 0x000000018674D64C-0x000000018674D6F8
		}
	
		[BurstCompile]
		private static class ClearProxyMeshUpdateBufferJobKernels // TypeDefIndex: 48296
		{
			// Nested types
			public unsafe delegate void ClearProxyMeshUpdateBufferKernel_000002F8_PostfixBurstDelegate(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // TypeDefIndex: 48294; 0x00000001815547C0-0x00000001815547E0
	
			internal static class ClearProxyMeshUpdateBufferKernel_000002F8_BurstDirectCall // TypeDefIndex: 48295
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearProxyMeshUpdateBufferKernel_000002F8_BurstDirectCall(); // 0x0000000184D1CB50-0x0000000184D1CB60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000686f3); // 0x000000018674E6A4-0x000000018674E7A8
				private static IntPtr GetFunctionPointer(); // 0x000000018674E7A8-0x000000018674E7FC
				public static void Constructor(); // 0x0000000184D1CB60-0x0000000184D1CBF0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // 0x000000018674E7FC-0x000000018674E8A8
			}
	
			// Methods
			[BurstCompile]
			internal static unsafe void ClearProxyMeshUpdateBufferKernel(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // 0x000000018674E530-0x000000018674E5A4
			[BurstCompile]
			public static unsafe void ClearProxyMeshUpdateBufferKernel_BurstManaged(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // 0x0000000184D873A0-0x0000000184D873B0
		}
	
		[BurstCompile]
		private struct ClearProxyMeshUpdateBufferJob : IJob, IUnsafeJob // TypeDefIndex: 48297
		{
			// Fields
			public NativeReference<int> processingCounter0; // 0x00
			public NativeReference<int> processingCounter1; // 0x10
			public NativeReference<int> processingCounter2; // 0x20
			public NativeReference<int> processingCounter3; // 0x30
	
			// Methods
			public void Execute(); // 0x000000018674E5A4-0x000000018674E624
			public void UnsafeDo(); // 0x000000018674E624-0x000000018674E6A4
		}
	
		[BurstCompile]
		private struct CreateProxyMeshUpdateVertexList : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48298
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> processingCounter1; // 0x10
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> processingList1; // 0x20
			[ReadOnly]
			public int _indexCount; // 0x30
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183DEF5B0-0x0000000183DEF5F0
			[IDTag(1)]
			public void Execute(); // 0x000000018674F908-0x000000018674F97C
			[IDTag(0)]
			public void Execute(int teamId); // 0x000000018674F79C-0x000000018674F908
			public void UnsafeDo(); // 0x000000018674F97C-0x000000018674FA14
		}
	
		[BurstCompile]
		private struct CalcProxyMeshSkinningJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48299
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobVertexIndexList; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<short> teamIds; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x30
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x40
			[ReadOnly]
			public NativeArray<float3> localNormals; // 0x50
			[ReadOnly]
			public NativeArray<float3> localTangents; // 0x60
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x70
			[ReadOnly]
			public NativeArray<int> skinBoneTransformIndices; // 0x80
			[ReadOnly]
			public NativeArray<float4x4> skinBoneBindPoses; // 0x90
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<double3> positions; // 0xA0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> rotations; // 0xB0
			[ReadOnly]
			public NativeArray<float4x4> transformLocalToWorldMatrixArray; // 0xC0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xD0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183D422C0-0x0000000183D42300
			[IDTag(1)]
			public void Execute(); // 0x00000001867483CC-0x0000000186748464
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186747CEC-0x00000001867483CC
			public void UnsafeDo(); // 0x0000000186748464-0x0000000186748630
		}
	
		[BurstCompile]
		private struct CreatePostProxyMeshUpdateListJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48300
		{
			// Fields
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> processingCounter0; // 0x10
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> processingList0; // 0x20
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> processingCounter1; // 0x30
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> processingList1; // 0x40
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> processingCounter2; // 0x50
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> processingList2; // 0x60
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> processingCounter3; // 0x70
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> processingList3; // 0x80
			[ReadOnly]
			public int _indexCount; // 0x90
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183D84160-0x0000000183D841A0
			[IDTag(1)]
			public void Execute(); // 0x000000018674EC04-0x000000018674EC7C
			[IDTag(0)]
			public void Execute(int teamId); // 0x000000018674EC7C-0x000000018674EEC0
			public void UnsafeDo(); // 0x000000018674EEC0-0x000000018674EFC0
		}
	
		[BurstCompile]
		private struct CalcLineNormalTangentJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48301
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobBaseLineList; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x30
			[ReadOnly]
			public NativeArray<double3> positions; // 0x40
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> rotations; // 0x50
			[ReadOnly]
			public NativeArray<float3> vertexLocalPositions; // 0x60
			[ReadOnly]
			public NativeArray<quaternion> vertexLocalRotations; // 0x70
			[ReadOnly]
			public NativeArray<int> parentIndices; // 0x80
			[ReadOnly]
			public NativeArray<uint> childIndexArray; // 0x90
			[ReadOnly]
			public NativeArray<ushort> childDataArray; // 0xA0
			[ReadOnly]
			public NativeArray<ExBitFlag8> baseLineFlags; // 0xB0
			[ReadOnly]
			public NativeArray<short> baseLineTeamIds; // 0xC0
			[ReadOnly]
			public NativeArray<ushort> baseLineStartIndices; // 0xD0
			[ReadOnly]
			public NativeArray<ushort> baseLineDataCounts; // 0xE0
			[ReadOnly]
			public NativeArray<ushort> baseLineData; // 0xF0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x100
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183D51420-0x0000000183D51740
			[IDTag(1)]
			public void Execute(); // 0x000000018674609C-0x0000000186746134
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186745938-0x000000018674609C
			public void UnsafeDo(); // 0x0000000186746134-0x0000000186746378
		}
	
		[BurstCompile]
		private struct CalcTriangleNormalTangentJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48302
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobTriangleList; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<short> triangleTeamIdArray; // 0x20
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x30
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> outTriangleNormals; // 0x40
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> outTriangleTangents; // 0x50
			[ReadOnly]
			public NativeArray<double3> positions; // 0x60
			[ReadOnly]
			public NativeArray<float2> uv; // 0x70
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x80
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x000000018674C6B0-0x000000018674C71C
			[IDTag(1)]
			public void Execute(); // 0x000000018674C618-0x000000018674C6B0
			[IDTag(0)]
			public void Execute(int index); // 0x000000018674C18C-0x000000018674C618
			public void UnsafeDo(); // 0x000000018674C71C-0x000000018674C84C
		}
	
		[BurstCompile]
		private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48303
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobVertexIndexList; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<short> teamIds; // 0x20
			[ReadOnly]
			public NativeArray<float3> triangleNormals; // 0x30
			[ReadOnly]
			public NativeArray<float3> triangleTangents; // 0x40
			[ReadOnly]
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x50
			[ReadOnly]
			public NativeArray<quaternion> normalAdjustmentRotations; // 0x60
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> outRotations; // 0x70
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x80
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x000000018674DDB0-0x000000018674DE1C
			[IDTag(1)]
			public void Execute(); // 0x000000018674DD18-0x000000018674DDB0
			[IDTag(0)]
			public void Execute(int index); // 0x000000018674D7B0-0x000000018674DD18
			public void UnsafeDo(); // 0x000000018674DE1C-0x000000018674DF40
		}
	
		[BurstCompile]
		private struct WriteTransformDataJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48304
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobVertexIndexList; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> transformPositionArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> transformRotationArray; // 0x30
			[ReadOnly]
			public NativeArray<short> teamIds; // 0x40
			[ReadOnly]
			public NativeArray<double3> positions; // 0x50
			[ReadOnly]
			public NativeArray<quaternion> rotations; // 0x60
			[ReadOnly]
			public NativeArray<quaternion> vertexToTransformRotations; // 0x70
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x80
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183D77850-0x0000000183D77930
			[IDTag(1)]
			public void Execute(); // 0x0000000186754738-0x00000001867547D0
			[IDTag(0)]
			public void Execute(int index); // 0x00000001867547D0-0x0000000186754B30
			public void UnsafeDo(); // 0x0000000186754B30-0x0000000186754C48
		}
	
		[BurstCompile]
		private struct WriteTransformLocalDataJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48305
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobVertexIndexList; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<short> teamIds; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<int> vertexParentIndices; // 0x40
			[ReadOnly]
			public NativeArray<double3> transformPositionArray; // 0x50
			[ReadOnly]
			public NativeArray<quaternion> transformRotationArray; // 0x60
			[ReadOnly]
			public NativeArray<float3> transformScaleArray; // 0x70
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> transformLocalPositionArray; // 0x80
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> transformLocalRotationArray; // 0x90
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xA0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183D52360-0x0000000183D525B0
			[IDTag(1)]
			public void Execute(); // 0x0000000186755854-0x00000001867558EC
			[IDTag(0)]
			public void Execute(int index); // 0x00000001867558EC-0x0000000186755CA8
			public void UnsafeDo(); // 0x0000000186755CA8-0x0000000186755E0C
		}
	
		[BurstCompile]
		private struct CalcMeshConvertMatrixJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48306
		{
			// Fields
			public NativeArray<TeamManager.MappingData> mappingDataArray; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<double3> transformPositionArray; // 0x20
			[ReadOnly]
			public NativeArray<quaternion> transformRotationArray; // 0x30
			[ReadOnly]
			public NativeArray<float3> transformScaleArray; // 0x40
			[ReadOnly]
			public int _indexCount; // 0x50
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x00000001867475E0-0x0000000186747638
			[IDTag(1)]
			public void Execute(); // 0x0000000186747118-0x000000018674718C
			[IDTag(0)]
			public void Execute(int index); // 0x000000018674718C-0x00000001867475E0
			public void UnsafeDo(); // 0x0000000186747638-0x00000001867476FC
		}
	
		[BurstCompile]
		private struct CalcProxySkinningJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48307
		{
			// Fields
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.MappingData> mappingDataArray; // 0x10
			[ReadOnly]
			public NativeArray<short> mappingIdArray; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> mappingAttributes; // 0x30
			[ReadOnly]
			public NativeArray<float3> mappingLocalPositions; // 0x40
			[ReadOnly]
			public NativeArray<float3> mappingLocalNormals; // 0x50
			[ReadOnly]
			public NativeArray<float3> mappingLocalTangents; // 0x60
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> mappingBoneWeights; // 0x70
			[WriteOnly]
			public NativeArray<float3> mappingPositions; // 0x80
			[WriteOnly]
			public NativeArray<float3> mappingNormals; // 0x90
			[WriteOnly]
			public NativeArray<float3> mappingTangents; // 0xA0
			[ReadOnly]
			public NativeArray<double3> proxyPositions; // 0xB0
			[ReadOnly]
			public NativeArray<quaternion> proxyRotations; // 0xC0
			[ReadOnly]
			public NativeArray<float3> proxyVertexBindPosePositions; // 0xD0
			[ReadOnly]
			public NativeArray<quaternion> proxyVertexBindPoseRotations; // 0xE0
			[ReadOnly]
			public int _indexCount; // 0xF0
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x000000018674AE9C-0x000000018674AEF8
			[IDTag(1)]
			public void Execute(); // 0x000000018674A038-0x000000018674A0B0
			[IDTag(0)]
			public void Execute(int mvindex); // 0x000000018674A0B0-0x000000018674AE9C
			public void UnsafeDo(); // 0x000000018674AEF8-0x000000018674B0D8
		}
	
		// Constructors
		public VirtualMeshManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		[BurstCompile]
		public static unsafe void CreateProxyMeshUpdateVertexListKernel(TeamManager.TeamData* teamDataArray, int* processingCounter1, int* processingList1, int teamId); // 0x000000018673E520-0x000000018673E644
		[BurstCompile]
		public static unsafe void CreateProxyMeshUpdateVertexListRangeKernel(TeamManager.TeamData* teamDataArray, int* processingCounter1, int* processingList1, int length); // 0x000000018673E644-0x000000018673E6A8
		public void Dispose(); // 0x0000000183E867B0-0x0000000183E86E70
		public void EnterdEditMode(); // 0x000000018673E6A8-0x000000018673E6F8
		public void Initialize(); // 0x0000000183E88220-0x0000000183E89760
		public bool IsValid(); // 0x000000018673FAB8-0x000000018673FB08
		public void RegisterProxyMesh(int teamId, VirtualMeshContainer proxyMeshContainer); // 0x0000000183CF9440-0x0000000183CF9B60
		public void ExitProxyMesh(int teamId); // 0x0000000183CF4BD0-0x0000000183CF5350
		public DataChunk RegisterMappingMesh(int teamId, VirtualMeshContainer mappingMeshContainer); // 0x000000018673FFD4-0x0000000186740468
		public void ExitMappingMesh(int teamId, int mappingIndex); // 0x000000018673E6F8-0x000000018673EAB0
		internal void UpdateBuffer(); // 0x0000000186740468-0x00000001867405B8
		internal JobHandle PreProxyMeshUpdate(JobHandle jobHandle); // 0x0000000182F8B170-0x0000000182F8BCA0
		internal JobHandle PostProxyMeshUpdate(JobHandle jobHandle); // 0x0000000182F8C4A0-0x0000000182F8D550
		internal JobHandle PostMappingMeshUpdate(JobHandle jobHandle); // 0x000000018673FB08-0x000000018673FFD4
		public void InformationLog(StringBuilder allsb); // 0x000000018673EAB0-0x000000018673FAB8
		public static void Initialize_CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E8_BurstDirectCall(); // 0x00000001844F6B10-0x00000001844F6B70
		public static void Initialize_CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E9_BurstDirectCall(); // 0x00000001844F6B70-0x00000001844F6BD0
		public static void Initialize_CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002EA_BurstDirectCall(); // 0x00000001844F6BD0-0x00000001844F6C30
		public static void Initialize_CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002EB_BurstDirectCall(); // 0x00000001844F6C30-0x00000001844F6C90
		public static void Initialize_WriteTransformDataJobKernels_WriteTransformDataKernel_000002EC_BurstDirectCall(); // 0x00000001844F6C90-0x00000001844F6CF0
		public static void Initialize_WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002ED_BurstDirectCall(); // 0x00000001844F6CF0-0x00000001844F6D50
		public static void Initialize_WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EE_BurstDirectCall(); // 0x00000001844F6D50-0x00000001844F6DB0
		public static void Initialize_WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002EF_BurstDirectCall(); // 0x00000001844F6DB0-0x00000001844F6E10
		public static void Initialize_CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002F0_BurstDirectCall(); // 0x00000001844F6E10-0x00000001844F6E70
		public static void Initialize_CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002F1_BurstDirectCall(); // 0x00000001844F6E70-0x00000001844F6ED0
		public static void Initialize_CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F2_BurstDirectCall(); // 0x00000001844F6ED0-0x00000001844F6F30
		public static void Initialize_CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F3_BurstDirectCall(); // 0x00000001844F6F30-0x00000001844F6F90
		public static void Initialize_CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F4_BurstDirectCall(); // 0x00000001844F6F90-0x00000001844F6FF0
		public static void Initialize_CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F5_BurstDirectCall(); // 0x00000001844F6FF0-0x00000001844F7050
		public static void Initialize_CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F6_BurstDirectCall(); // 0x00000001844F7050-0x00000001844F70B0
		public static void Initialize_CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F7_BurstDirectCall(); // 0x00000001844F70B0-0x00000001844F7110
		public static void Initialize_ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F8_BurstDirectCall(); // 0x00000001844F7110-0x00000001844F7170
	}

	public interface IManager : IDisposable // TypeDefIndex: 48309
	{
		// Methods
		void Initialize();
		void EnterdEditMode();
		void InformationLog(StringBuilder allsb);
	}

	public static class MagicaManager // TypeDefIndex: 48314
	{
		// Fields
		private static List<IManager> managers; // 0x00
		public static bool EnableTick; // 0x08
		public static bool UseCrossFrameJob; // 0x09
		public static bool UseAnimatorTransform; // 0x0A
		public static UpdateMethod afterEarlyUpdateDelegate; // 0x10
		public static UpdateMethod afterFixedUpdateDelegate; // 0x18
		public static UpdateMethod afterUpdateDelegate; // 0x20
		public static UpdateMethod beforeLateUpdateDelegate; // 0x28
		public static UpdateMethod afterLateUpdateDelegate; // 0x30
		public static UpdateMethod afterDelayedDelegate; // 0x38
		public static UpdateMethod afterRenderingDelegate; // 0x40
		public static UpdateMethod defaultUpdateDelegate; // 0x48
		public static UpdateMethod onApplicationQuitDelegate; // 0x50
		private static bool isPlaying; // 0x58
		public static Action OnPreSimulation; // 0x60
		public static Action OnPostSimulation; // 0x68
		internal static InitializationLocation initializationLocation; // 0x70
	
		// Properties
		public static TimeManager Time { get; } // 0x0000000182F95240-0x0000000182F95330 
		public static TeamManager Team { get; } // 0x0000000182F95920-0x0000000182F95A30 
		public static ClothManager Cloth { get; } // 0x0000000182F95330-0x0000000182F95410 
		public static RenderManager Render { get; } // 0x0000000183D47770-0x0000000183D47850 
		public static DynamicBoneTransformManager Bone { get; } // 0x0000000182F93200-0x0000000182F932F0 
		public static VirtualMeshManager VMesh { get; } // 0x0000000182F955B0-0x0000000182F956A0 
		public static SimulationManager Simulation { get; } // 0x0000000182F95410-0x0000000182F95500 
		public static ColliderManager Collider { get; } // 0x0000000182F90B80-0x0000000182F90C60 
		public static WindManager Wind { get; } // 0x0000000182F93110-0x0000000182F93200 
		public static PreBuildManager PreBuild { get; } // 0x0000000183E8EC60-0x0000000183E8ED10 
	
		// Nested types
		public delegate void UpdateMethod(); // TypeDefIndex: 48310; 0x00000001853DEDB8-0x00000001853DEDC8
	
		public enum InitializationLocation // TypeDefIndex: 48311
		{
			Start = 0,
			Awake = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 48312
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__39_0; // 0x08
			public static PlayerLoopSystem.UpdateFunction __9__40_0; // 0x10
			public static PlayerLoopSystem.UpdateFunction __9__40_1; // 0x18
			public static PlayerLoopSystem.UpdateFunction __9__40_2; // 0x20
			public static PlayerLoopSystem.UpdateFunction __9__40_3; // 0x28
			public static PlayerLoopSystem.UpdateFunction __9__40_4; // 0x30
			public static PlayerLoopSystem.UpdateFunction __9__40_5; // 0x38
			public static PlayerLoopSystem.UpdateFunction __9__40_6; // 0x40
	
			// Constructors
			static __c(); // 0x0000000184D466F0-0x0000000184D46750
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _InitCustomGameLoop_b__39_0(); // 0x0000000186752620-0x0000000186752670
			internal void _SetCustomGameLoop_b__40_0(); // 0x00000001832345D0-0x0000000183234640
			internal void _SetCustomGameLoop_b__40_1(); // 0x0000000183234640-0x0000000183234A50
			internal void _SetCustomGameLoop_b__40_2(); // 0x00000001832340D0-0x0000000183234180
			internal void _SetCustomGameLoop_b__40_3(); // 0x00000001832341F0-0x0000000183234260
			internal void _SetCustomGameLoop_b__40_4(); // 0x0000000183234260-0x00000001832342D0
			internal void _SetCustomGameLoop_b__40_5(); // 0x00000001832342D0-0x0000000183234340
			internal void _SetCustomGameLoop_b__40_6(); // 0x0000000183234340-0x00000001832343B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 48313
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass41_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x); // 0x0000000184559F30-0x0000000184559F70
		}
	
		// Constructors
		static MagicaManager(); // 0x0000000184CF53D0-0x0000000184CF5480
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Initialize(); // 0x00000001835B89E0-0x00000001835B9360
		private static void Dispose(); // 0x00000001835B82F0-0x00000001835B85F0
		public static bool IsPlaying(); // 0x0000000182F93360-0x0000000182F93400
		public static void SetUseCrossFrameJob(bool value); // 0x0000000186750314-0x00000001867503AC
		public static void InitCustomGameLoop(); // 0x0000000183328DC0-0x0000000183328FB0
		private static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop); // 0x0000000183323680-0x00000001833240B0
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop); // 0x0000000183324B20-0x0000000183324CC0
		public static void SetGlobalTimeScale(float timeScale); // 0x000000018674FFF0-0x00000001867500A0
		public static float GetGlobalTimeScale(); // 0x000000018674FC54-0x000000018674FD14
		public static void SetSimulationFrequency(int freq); // 0x00000001867501CC-0x000000018675027C
		public static void SetAOVMode(bool enable, float deltaTime); // 0x000000018674FF3C-0x000000018674FFF0
		public static void DoAOVUpdate(); // 0x000000018674FB34-0x000000018674FC54
		public static void DoAOVAfterAnimatorUpdate(); // 0x000000018674FA14-0x000000018674FB34
		public static int GetSimulationFrequency(); // 0x000000018674FDCC-0x000000018674FE84
		public static void SetMaxSimulationCountPerFrame(int count); // 0x0000000186750120-0x00000001867501CC
		public static int GetMaxSimulationCountPerFrame(); // 0x000000018674FD14-0x000000018674FDCC
		public static void SetUpdateLocation(TimeManager.UpdateLocation updateLocation); // 0x000000018675027C-0x0000000186750314
		public static TimeManager.UpdateLocation GetUpdateLocation(); // 0x000000018674FE84-0x000000018674FF3C
		public static void UnloadUnusedData(); // 0x000000018477D850-0x000000018477D8E0
		public static void SetInitializationLocation(InitializationLocation initLocation); // 0x00000001867500A0-0x0000000186750120
	}

	[AddComponentMenu("MagicaCloth2/MagicaSettings")]
	[HelpURL("https://magicasoft.jp/en/mc2_settings_component/")]
	public class MagicaSettings : ClothBehaviour // TypeDefIndex: 48316
	{
		// Fields
		public RefreshMode refreshMode; // 0x20
		[Range(30f, 150f)]
		public int simulationFrequency; // 0x24
		[Range(1f, 5f)]
		public int maxSimulationCountPerFrame; // 0x28
		public MagicaManager.InitializationLocation initializationLocation; // 0x2C
		public TimeManager.UpdateLocation updateLocation; // 0x30
		public bool monitorPlayerLoop; // 0x34
	
		// Nested types
		public enum RefreshMode // TypeDefIndex: 48315
		{
			OnAwake = 0,
			EveryFrame = 1,
			OnStart = 2,
			Manual = 3
		}
	
		// Constructors
		public MagicaSettings(); // 0x0000000186750654-0x0000000186750678
	
		// Methods
		public void Awake(); // 0x00000001867503AC-0x0000000186750408
		public void Start(); // 0x000000018675059C-0x00000001867505F8
		public void Update(); // 0x00000001867505F8-0x0000000186750654
		private void OnValidate(); // 0x0000000186750408-0x0000000186750468
		public void Refresh(); // 0x0000000186750468-0x000000018675059C
	}

	[BurstCompile]
	internal static class UpdatePositionNormalJobKernels // TypeDefIndex: 48321
	{
		// Nested types
		public unsafe delegate void UpdatePositionNormalKernel_0000035B_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // TypeDefIndex: 48317; 0x000000018671B804-0x000000018671B860
	
		internal static class UpdatePositionNormalKernel_0000035B_BurstDirectCall // TypeDefIndex: 48318
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalKernel_0000035B_BurstDirectCall(); // 0x0000000184D1B610-0x0000000184D1B620
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068752); // 0x000000018675325C-0x0000000186753360
			private static IntPtr GetFunctionPointer(); // 0x0000000186753360-0x00000001867533B4
			public static void Constructor(); // 0x0000000184D1B620-0x0000000184D1B6B0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // 0x00000001867533B4-0x00000001867534C4
		}
	
		public unsafe delegate void UpdatePositionNormalRangeKernel_0000035C_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // TypeDefIndex: 48319; 0x000000018671B804-0x000000018671B860
	
		internal static class UpdatePositionNormalRangeKernel_0000035C_BurstDirectCall // TypeDefIndex: 48320
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalRangeKernel_0000035C_BurstDirectCall(); // 0x0000000184D1B570-0x0000000184D1B580
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068770); // 0x000000018675364C-0x0000000186753750
			private static IntPtr GetFunctionPointer(); // 0x0000000186753750-0x00000001867537A4
			public static void Constructor(); // 0x0000000184D1B580-0x0000000184D1B610
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // 0x00000001867537A4-0x00000001867538E0
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdatePositionNormalKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // 0x0000000186753074-0x0000000186753118
		[BurstCompile]
		internal static unsafe void UpdatePositionNormalRangeKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // 0x00000001867531B8-0x000000018675325C
		[BurstCompile]
		public static unsafe void UpdatePositionNormalKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // 0x0000000186752F88-0x0000000186753074
		[BurstCompile]
		public static unsafe void UpdatePositionNormalRangeKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // 0x0000000186753118-0x00000001867531B8
	}

	[BurstCompile]
	internal static class UpdatePositionNormalTangentJobKernels // TypeDefIndex: 48326
	{
		// Nested types
		public unsafe delegate void UpdatePositionNormalTangentKernel_0000035D_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // TypeDefIndex: 48322; 0x00000001866A7290-0x00000001866A7304
	
		internal static class UpdatePositionNormalTangentKernel_0000035D_BurstDirectCall // TypeDefIndex: 48323
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalTangentKernel_0000035D_BurstDirectCall(); // 0x0000000184D1B4D0-0x0000000184D1B4E0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000687ba); // 0x0000000186753D44-0x0000000186753E48
			private static IntPtr GetFunctionPointer(); // 0x0000000186753E48-0x0000000186753E9C
			public static void Constructor(); // 0x0000000184D1B4E0-0x0000000184D1B570
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // 0x0000000186753E9C-0x0000000186753FE0
		}
	
		public unsafe delegate void UpdatePositionNormalTangentRangeKernel_0000035E_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // TypeDefIndex: 48324; 0x00000001866A7290-0x00000001866A7304
	
		internal static class UpdatePositionNormalTangentRangeKernel_0000035E_BurstDirectCall // TypeDefIndex: 48325
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalTangentRangeKernel_0000035E_BurstDirectCall(); // 0x0000000184D1B430-0x0000000184D1B440
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000687de); // 0x0000000186754180-0x0000000186754284
			private static IntPtr GetFunctionPointer(); // 0x0000000186754284-0x00000001867542D8
			public static void Constructor(); // 0x0000000184D1B440-0x0000000184D1B4D0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // 0x00000001867542D8-0x0000000186754448
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdatePositionNormalTangentKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // 0x0000000186753B0C-0x0000000186753BCC
		[BurstCompile]
		internal static unsafe void UpdatePositionNormalTangentRangeKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // 0x0000000186753C84-0x0000000186753D44
		[BurstCompile]
		public static unsafe void UpdatePositionNormalTangentKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // 0x00000001867539A0-0x0000000186753B0C
		[BurstCompile]
		public static unsafe void UpdatePositionNormalTangentRangeKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // 0x0000000186753BCC-0x0000000186753C84
	}

	[BurstCompile]
	internal static class UpdateBoneWeightJob2Kernels // TypeDefIndex: 48331
	{
		// Nested types
		public unsafe delegate void UpdateBoneWeight2Kernel_0000035F_PostfixBurstDelegate(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // TypeDefIndex: 48327; 0x0000000182BED120-0x0000000182BED140
	
		internal static class UpdateBoneWeight2Kernel_0000035F_BurstDirectCall // TypeDefIndex: 48328
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdateBoneWeight2Kernel_0000035F_BurstDirectCall(); // 0x0000000184D1B750-0x0000000184D1B760
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068812); // 0x0000000186752670-0x0000000186752774
			private static IntPtr GetFunctionPointer(); // 0x0000000186752774-0x00000001867527C8
			public static void Constructor(); // 0x0000000184D1B760-0x0000000184D1B7F0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // 0x00000001867527C8-0x0000000186752898
		}
	
		public unsafe delegate void UpdateBoneWeight2RangeKernel_00000360_PostfixBurstDelegate(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // TypeDefIndex: 48329; 0x0000000182BED120-0x0000000182BED140
	
		internal static class UpdateBoneWeight2RangeKernel_00000360_BurstDirectCall // TypeDefIndex: 48330
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdateBoneWeight2RangeKernel_00000360_BurstDirectCall(); // 0x0000000184D1B6B0-0x0000000184D1B6C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006882a); // 0x0000000186752A20-0x0000000186752B24
			private static IntPtr GetFunctionPointer(); // 0x0000000186752B24-0x0000000186752B78
			public static void Constructor(); // 0x0000000184D1B6C0-0x0000000184D1B750
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // 0x0000000186752B78-0x0000000186752C74
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdateBoneWeight2Kernel(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // 0x0000000186752E00-0x0000000186752E84
		[BurstCompile]
		internal static unsafe void UpdateBoneWeight2RangeKernel(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // 0x0000000186752F04-0x0000000186752F88
		[BurstCompile]
		public static unsafe void UpdateBoneWeight2Kernel_BurstManaged(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // 0x0000000186752D34-0x0000000186752E00
		[BurstCompile]
		public static unsafe void UpdateBoneWeight2RangeKernel_BurstManaged(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // 0x0000000186752E84-0x0000000186752F04
	}

	public class RenderData : IDisposable, ITransform // TypeDefIndex: 48336
	{
		// Fields
		[CompilerGenerated]
		private int _ReferenceCount_k__BackingField; // 0x10
		private HashSet<ClothProcess> useProcessSet; // 0x18
		private bool isSkipWriting; // 0x20
		internal RenderSetupData setupData; // 0x28
		internal RenderSetupData.UniqueSerializationData preBuildUniqueSerializeData; // 0x30
		private Mesh originalMesh; // 0x38
		private SkinnedMeshRenderer skinnedMeshRendere; // 0x40
		private MeshFilter meshFilter; // 0x48
		private List<Transform> transformList; // 0x50
		private Mesh customMesh; // 0x58
		private NativeArray<Vector3> localPositions; // 0x60
		private NativeArray<Vector3> localNormals; // 0x70
		private NativeArray<Vector4> localTangents; // 0x80
		private NativeArray<BoneWeight> boneWeights; // 0x90
		private BoneWeight centerBoneWeight; // 0xA0
		private const int Flag_UseCustomMesh = 0; // Metadata: 0x0232D033
		private const int Flag_ChangePositionNormal = 1; // Metadata: 0x0232D034
		private const int Flag_ChangeBoneWeight = 2; // Metadata: 0x0232D035
		private const int Flag_ModifyBoneWeight = 3; // Metadata: 0x0232D036
		private const int Flag_HasMeshTangent = 4; // Metadata: 0x0232D037
		private const int Flag_HasTangent = 5; // Metadata: 0x0232D038
		private const int Flag_ChangeTangent = 6; // Metadata: 0x0232D039
		private BitField32 flag; // 0xC0
	
		// Properties
		public int ReferenceCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 0x00000001814F51F0-0x00000001814F5220
		internal string Name { get; } // 0x00000001867524EC-0x000000018675256C 
		internal bool HasSkinnedMesh { get; } // 0x000000018675243C-0x0000000186752498 
		internal bool HasBoneWeight { get; } // 0x000000018675238C-0x00000001867523E8 
		public bool UseCustomMesh { get; } // 0x00000001867525CC-0x0000000186752620 
		public bool HasMeshTangent { get; } // 0x00000001867523E8-0x000000018675243C 
		public bool HasTangent { get; } // 0x0000000186752498-0x00000001867524EC 
		internal ResultCode Result { get; } // 0x000000018675256C-0x00000001867525CC 
	
		// Nested types
		[BurstCompile]
		private struct UpdatePositionNormalJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48332
		{
			// Fields
			public int startIndex; // 0x00
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> meshLocalPositions; // 0x08
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> meshLocalNormals; // 0x18
			[ReadOnly]
			public NativeArray<int> mappingReferenceIndices; // 0x28
			[ReadOnly]
			public NativeArray<VertexAttribute> mappingAttributes; // 0x38
			[ReadOnly]
			public NativeArray<float3> mappingPositions; // 0x48
			[ReadOnly]
			public NativeArray<float3> mappingNormals; // 0x58
			[ReadOnly]
			public int _indexCount; // 0x68
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000186763688-0x00000001867636E0
			[IDTag(1)]
			public void Execute(); // 0x00000001867634F8-0x000000018676356C
			[IDTag(0)]
			public void Execute(int index); // 0x000000018676356C-0x0000000186763688
			public void UnsafeDo(); // 0x00000001867636E0-0x00000001867637A0
		}
	
		[BurstCompile]
		private struct UpdatePositionNormalTangentJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48333
		{
			// Fields
			public int startIndex; // 0x00
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> meshLocalPositions; // 0x08
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> meshLocalNormals; // 0x18
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> meshLocalTangents; // 0x28
			[ReadOnly]
			public NativeArray<int> mappingReferenceIndices; // 0x38
			[ReadOnly]
			public NativeArray<VertexAttribute> mappingAttributes; // 0x48
			[ReadOnly]
			public NativeArray<float3> mappingPositions; // 0x58
			[ReadOnly]
			public NativeArray<float3> mappingNormals; // 0x68
			[ReadOnly]
			public NativeArray<float3> mappingTangents; // 0x78
			[ReadOnly]
			public int _indexCount; // 0x88
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x000000018676399C-0x00000001867639F8
			[IDTag(1)]
			public void Execute(); // 0x00000001867637A0-0x0000000186763818
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186763818-0x000000018676399C
			public void UnsafeDo(); // 0x00000001867639F8-0x0000000186763AF4
		}
	
		[BurstCompile]
		private struct UpdateBoneWeightJob2 : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48334
		{
			// Fields
			public int startIndex; // 0x00
			public BoneWeight centerBoneWeight; // 0x04
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<BoneWeight> meshBoneWeights; // 0x28
			[ReadOnly]
			public NativeArray<int> mappingReferenceIndices; // 0x38
			[ReadOnly]
			public NativeArray<VertexAttribute> mappingAttributes; // 0x48
			[ReadOnly]
			public int _indexCount; // 0x58
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x00000001867633D8-0x0000000186763430
			[IDTag(1)]
			public void Execute(); // 0x000000018676328C-0x0000000186763300
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186763300-0x00000001867633D8
			public void UnsafeDo(); // 0x0000000186763430-0x00000001867634F8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 48335
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ClothProcess, bool> __9__52_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000186762FA0-0x0000000186763004
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _UpdateUse_b__52_0(ClothProcess x); // 0x0000000186762EDC-0x0000000186762F24
		}
	
		// Constructors
		public RenderData(); // 0x0000000186752314-0x000000018675238C
	
		// Methods
		public void Dispose(); // 0x00000001867506C8-0x0000000186750844
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001867508AC-0x0000000186750918
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000186750BBC-0x0000000186750C28
		internal void Initialize(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referencePreBuildUniqueSetupData); // 0x0000000186750918-0x0000000186750B68
		internal int AddReferenceCount(); // 0x0000000186750678-0x00000001867506C8
		internal int RemoveReferenceCount(); // 0x0000000186750B68-0x0000000186750BBC
		private void SwapCustomMesh(); // 0x0000000186750FC4-0x00000001867513D8
		private void ResetCustomMeshWorkData(); // 0x0000000186750C28-0x0000000186750E44
		private void SwapOriginalMesh(); // 0x00000001867513D8-0x00000001867514C4
		private void SetMesh(Mesh mesh); // 0x0000000186750E44-0x0000000186750F5C
		public void StartUse(ClothProcess cprocess); // 0x0000000186750F5C-0x0000000186750FC4
		public void EndUse(ClothProcess cprocess); // 0x0000000186750844-0x00000001867508AC
		internal void UpdateUse(ClothProcess cprocess, int add); // 0x0000000186751EFC-0x0000000186752148
		internal void UpdateSkipWriting(); // 0x0000000186751D9C-0x0000000186751EFC
		internal void WriteMesh(); // 0x0000000186752148-0x0000000186752314
		internal JobHandle UpdatePositionNormal(bool updateTangent, DataChunk mappingChunk, JobHandle jobHandle); // 0x000000018675193C-0x0000000186751D9C
		internal JobHandle UpdateBoneWeight(DataChunk mappingChunk, JobHandle jobHandle = default); // 0x0000000186751710-0x000000018675193C
		public override string ToString(); // 0x00000001867514C4-0x0000000186751710
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public class RenderManager : IManager, IValid // TypeDefIndex: 48337
	{
		// Fields
		private Dictionary<int, BeyondDynamicBone.RenderData> renderDataDict; // 0x10
		private bool isValid; // 0x18
	
		// Constructors
		public RenderManager(); // 0x00000001835B9390-0x00000001835B9410
	
		// Methods
		public void Initialize(); // 0x00000001835B9CA0-0x00000001835B9E00
		public void EnterdEditMode(); // 0x000000018675DB38-0x000000018675DB88
		public void Dispose(); // 0x00000001835B9E00-0x00000001835BA470
		public bool IsValid(); // 0x000000018675E090-0x000000018675E0DC
		public int AddRenderer(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referenceUniqueSetupData); // 0x000000018675D86C-0x000000018675DAB0
		public bool RemoveRenderer(int handle); // 0x000000018675E0DC-0x000000018675E2C4
		public BeyondDynamicBone.RenderData GetRendererData(int handle); // 0x000000018675DB88-0x000000018675DD2C
		public void StartUse(ClothProcess cprocess, int handle); // 0x000000018675E2C4-0x000000018675E34C
		public void EndUse(ClothProcess cprocess, int handle); // 0x000000018675DAB0-0x000000018675DB38
		private void PreRenderingUpdate(); // 0x0000000183233E80-0x00000001832340D0
		public void InformationLog(StringBuilder allsb); // 0x000000018675DD2C-0x000000018675E090
	}

	public class RenderSetupData : IDisposable, ITransform // TypeDefIndex: 48346
	{
		// Fields
		public ResultCode result; // 0x10
		public string name; // 0x18
		public bool isManaged; // 0x20
		public SetupType setupType; // 0x24
		public Renderer renderer; // 0x28
		public SkinnedMeshRenderer skinRenderer; // 0x30
		public MeshFilter meshFilter; // 0x38
		public Mesh originalMesh; // 0x40
		public int vertexCount; // 0x48
		public bool hasSkinnedMesh; // 0x4C
		public bool hasBoneWeight; // 0x4D
		public Mesh.MeshDataArray meshDataArray; // 0x50
		public int skinRootBoneIndex; // 0x60
		public int skinBoneCount; // 0x64
		public List<Matrix4x4> bindPoseList; // 0x68
		public NativeArray<byte> bonesPerVertexArray; // 0x70
		public NativeArray<BoneWeight1> boneWeightArray; // 0x80
		public NativeArray<Vector3> localPositions; // 0x90
		public NativeArray<Vector3> localNormals; // 0xA0
		public NativeArray<Vector4> localTangents; // 0xB0
		public List<int> rootTransformIdList; // 0xC0
		public BoneConnectionMode boneConnectionMode; // 0xC8
		public List<int> collisionBoneIndexList; // 0xD0
		public List<Transform> transformList; // 0xD8
		public List<int> transformIdList; // 0xE0
		public List<int> transformParentIdList; // 0xE8
		public List<FixedList512Bytes<int>> transformChildIdList; // 0xF0
		public NativeArray<float3> transformPositions; // 0xF8
		public NativeArray<quaternion> transformRotations; // 0x108
		public NativeArray<float3> transformLocalPositins; // 0x118
		public NativeArray<quaternion> transformLocalRotations; // 0x128
		public NativeArray<float3> transformScales; // 0x138
		public NativeArray<quaternion> transformInverseRotations; // 0x148
		public int renderTransformIndex; // 0x158
		public float4x4 initRenderLocalToWorld; // 0x15C
		public float4x4 initRenderWorldtoLocal; // 0x19C
		public quaternion initRenderRotation; // 0x1DC
		public float3 initRenderScale; // 0x1EC
	
		// Properties
		public int TransformCount { get; } // 0x000000018468C1E0-0x000000018468C240 
		public bool HasMeshDataArray { get; } // 0x00000001867602DC-0x000000018676032C 
		public bool HasLocalPositions { get; } // 0x000000018676026C-0x00000001867602DC 
		public bool HasTangent { get; } // 0x000000018676032C-0x00000001867603AC 
	
		// Nested types
		public enum SetupType // TypeDefIndex: 48338
		{
			MeshCloth = 0,
			BoneCloth = 1,
			BoneSpring = 2
		}
	
		public enum BoneConnectionMode // TypeDefIndex: 48339
		{
			Line = 0,
			AutomaticMesh = 1,
			SequentialLoopMesh = 2,
			SequentialNonLoopMesh = 3
		}
	
		[BurstCompile]
		private struct VertexWeight5BoneCheckJob : IJob // TypeDefIndex: 48340
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			[WriteOnly]
			public NativeReference<Define.Result> result; // 0x18
	
			// Methods
			public void Execute(); // 0x0000000186763AF4-0x00000001867640F8
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 48341
		{
			// Fields
			[WriteOnly]
			public NativeArray<float3> positions; // 0x00
			[WriteOnly]
			public NativeArray<quaternion> rotations; // 0x10
			[WriteOnly]
			public NativeArray<float3> scales; // 0x20
			[WriteOnly]
			public NativeArray<float3> localPositions; // 0x30
			[WriteOnly]
			public NativeArray<quaternion> localRotations; // 0x40
			[WriteOnly]
			public NativeArray<quaternion> inverseRotations; // 0x50
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x000000018675D514-0x000000018675D86C
		}
	
		[BurstCompile]
		private struct GetBoneWeightJos : IJob // TypeDefIndex: 48342
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			[ReadOnly]
			public NativeArray<BoneWeight1> boneWeightArray; // 0x18
			[WriteOnly]
			public NativeArray<BoneWeight> boneWeights; // 0x28
	
			// Methods
			public void Execute(); // 0x000000018675B304-0x000000018675B44C
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 48343
		{
			// Fields
			public ResultCode result; // 0x10
			public string name; // 0x18
			public SetupType setupType; // 0x20
			public Mesh originalMesh; // 0x28
			public int vertexCount; // 0x30
			public bool hasSkinnedMesh; // 0x34
			public bool hasBoneWeight; // 0x35
			public int skinRootBoneIndex; // 0x38
			public int skinBoneCount; // 0x3C
			public List<Matrix4x4> bindPoseList; // 0x40
			public byte[] bonesPerVertexArray; // 0x48
			public byte[] boneWeightArray; // 0x50
			public Vector3[] localPositions; // 0x58
			public Vector3[] localNormals; // 0x60
			public Vector4[] localTangents; // 0x68
			public BoneConnectionMode boneConnectionMode; // 0x70
			public int renderTransformIndex; // 0x74
	
			// Properties
			public bool HasTangent { get; } // 0x00000001867603AC-0x0000000186760408 
	
			// Constructors
			public ShareSerializationData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 48345
		{
			// Fields
			public ResultCode result; // 0x10
			public Renderer renderer; // 0x18
			public SkinnedMeshRenderer skinRenderer; // 0x20
			public MeshFilter meshFilter; // 0x28
			public Mesh originalMesh; // 0x30
			public List<Transform> transformList; // 0x38
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48344
			{
				// Fields
				public HashSet<Transform> transformSet; // 0x10
	
				// Constructors
				public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal void _GetUsedTransform_b__0(Transform x); // 0x0000000186762F24-0x0000000186762FA0
			}
	
			// Constructors
			public UniqueSerializationData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000186763004-0x0000000186763108
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000186763108-0x000000018676328C
		}
	
		// Constructors
		public RenderSetupData(); // 0x0000000186760224-0x000000018676026C
		public RenderSetupData(Renderer ren); // 0x000000018675F4F0-0x0000000186760224
		public RenderSetupData(SetupType setType, Transform renderTransform, List<Transform> rootTransforms, List<Transform> ignoreFromRootBones, List<Transform> collisionBones, BoneConnectionMode connectionMode = BoneConnectionMode.Line /* Metadata: 0x0232D03A */, string name = "(no name)" /* Metadata: 0x0232D03B */); // 0x0000000183E90F60-0x0000000183E91F50
	
		// Methods
		public bool IsSuccess(); // 0x000000018675E850-0x000000018675E8A4
		public bool IsFaild(); // 0x0000000183CF6EA0-0x0000000183CF6EE0
		private void ReadTransformInformation(bool includeChilds); // 0x00000001837E9FA0-0x00000001837EBB90
		public void Dispose(); // 0x0000000184B2AD40-0x0000000184B2AEA0
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x000000018675E6D4-0x000000018675E850
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x000000018675E8A4-0x000000018675ED60
		public Transform GetRendeerTransform(); // 0x000000018675E440-0x000000018675E4C4
		public int GetRenderTransformId(); // 0x000000018675E4C4-0x000000018675E548
		public float4x4 GetRendeerLocalToWorldMatrix(); // 0x0000000184503AA0-0x0000000184503B80
		public Transform GetSkinRootTransform(); // 0x000000018675E5C8-0x000000018675E648
		public int GetSkinRootTransformId(); // 0x000000018675E548-0x000000018675E5C8
		public int GetTransformIndexFromId(int id); // 0x000000018675E648-0x000000018675E6D4
		public int GetParentTransformIndex(int index, bool centerExcluded); // 0x00000001836411E0-0x0000000183641270
		public void GetBoneWeightsRun(NativeArray<BoneWeight> weights); // 0x000000018675E34C-0x000000018675E440
		public ShareSerializationData ShareSerialize(); // 0x000000018675F074-0x000000018675F328
		public static RenderSetupData ShareDeserialize(ShareSerializationData sdata); // 0x000000018675ED60-0x000000018675F074
		public UniqueSerializationData UniqueSerialize(); // 0x000000018675F328-0x000000018675F4F0
	}

	[BurstCompile]
	internal static class EndSimulationStepJobKernels // TypeDefIndex: 48351
	{
		// Nested types
		public unsafe delegate void EndSimulationStepKernel_000003BA_PostfixBurstDelegate(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // TypeDefIndex: 48347; 0x0000000182BED120-0x0000000182BED140
	
		internal static class EndSimulationStepKernel_000003BA_BurstDirectCall // TypeDefIndex: 48348
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EndSimulationStepKernel_000003BA_BurstDirectCall(); // 0x0000000183FB2D60-0x0000000183FB2D70
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00068890); // 0x000000018675ABBC-0x000000018675ACC0
			private static IntPtr GetFunctionPointer(); // 0x000000018675ACC0-0x000000018675AD14
			public static void Constructor(); // 0x0000000183FB2A50-0x0000000183FB2AE0
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // 0x000000018675AD14-0x000000018675ADE8
		}
	
		public unsafe delegate void EndSimulationStepRangeKernel_000003BB_PostfixBurstDelegate(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // TypeDefIndex: 48349; 0x0000000182BED120-0x0000000182BED140
	
		internal static class EndSimulationStepRangeKernel_000003BB_BurstDirectCall // TypeDefIndex: 48350
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EndSimulationStepRangeKernel_000003BB_BurstDirectCall(); // 0x0000000183FB2D50-0x0000000183FB2D60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000688a8); // 0x000000018675AF74-0x000000018675B078
			private static IntPtr GetFunctionPointer(); // 0x000000018675B078-0x000000018675B0CC
			public static void Constructor(); // 0x0000000183FB29C0-0x0000000183FB2A50
			public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
			public static unsafe void Invoke(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // 0x000000018675B0CC-0x000000018675B1D4
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void EndSimulationStepKernel(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // 0x000000018675A834-0x000000018675A8BC
		[BurstCompile]
		internal static unsafe void EndSimulationStepRangeKernel(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // 0x000000018675A944-0x000000018675A9CC
		[BurstCompile]
		public static unsafe void EndSimulationStepKernel_BurstManaged(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // 0x0000000184D873B0-0x0000000184D87400
		[BurstCompile]
		public static unsafe void EndSimulationStepRangeKernel_BurstManaged(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // 0x000000018675A8BC-0x000000018675A944
	}

	public class ColliderManager : IManager, IValid // TypeDefIndex: 48379
	{
		// Fields
		public ExNativeArray<short> teamIdArray; // 0x10
		public const byte Flag_Valid = 16; // Metadata: 0x0232D04C
		public const byte Flag_Enable = 32; // Metadata: 0x0232D04D
		public const byte Flag_Reset = 64; // Metadata: 0x0232D04E
		public const byte Flag_Reverse = 128; // Metadata: 0x0232D04F
		public ExNativeArray<ExBitFlag8> flagArray; // 0x18
		public ExNativeArray<float3> centerArray; // 0x20
		public ExNativeArray<float3> sizeArray; // 0x28
		public ExNativeArray<double3> framePositions; // 0x30
		public ExNativeArray<quaternion> frameRotations; // 0x38
		public ExNativeArray<float3> frameScales; // 0x40
		public ExNativeArray<double3> oldFramePositions; // 0x48
		public ExNativeArray<quaternion> oldFrameRotations; // 0x50
		public ExNativeArray<double3> nowPositions; // 0x58
		public ExNativeArray<quaternion> nowRotations; // 0x60
		public ExNativeArray<double3> oldPositions; // 0x68
		public ExNativeArray<quaternion> oldRotations; // 0x70
		public HashSet<ColliderComponent> colliderSet; // 0x78
		private bool isValid; // 0x80
		internal ExNativeArray<WorkData> workDataArray; // 0x88
	
		// Properties
		public int DataCount { get; } // 0x0000000182F8D900-0x0000000182F8D970 
		public int ColliderCount { get; } // 0x0000000186759D50-0x0000000186759DC4 
	
		// Nested types
		[BurstCompile]
		public static class ColliderKernels // TypeDefIndex: 48356
		{
			// Nested types
			public unsafe delegate void PreSimulationUpdateKernel_000003D3_PostfixBurstDelegate(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // TypeDefIndex: 48352; 0x00000001866A1944-0x00000001866A1A20
	
			internal static class PreSimulationUpdateKernel_000003D3_BurstDirectCall // TypeDefIndex: 48353
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateKernel_000003D3_BurstDirectCall(); // 0x0000000183FB2D40-0x0000000183FB2D50
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006893a); // 0x000000018675CAC8-0x000000018675CBCC
				private static IntPtr GetFunctionPointer(); // 0x000000018675CBCC-0x000000018675CC20
				public static void Constructor(); // 0x0000000183FB2930-0x0000000183FB29C0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // 0x000000018675CC20-0x000000018675CE60
			}
	
			public unsafe delegate void PreSimulationUpdateRangeKernel_000003D4_PostfixBurstDelegate(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // TypeDefIndex: 48354; 0x00000001866A1944-0x00000001866A1A20
	
			internal static class PreSimulationUpdateRangeKernel_000003D4_BurstDirectCall // TypeDefIndex: 48355
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateRangeKernel_000003D4_BurstDirectCall(); // 0x0000000183FB2D30-0x0000000183FB2D40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068976); // 0x000000018675D05C-0x000000018675D160
				private static IntPtr GetFunctionPointer(); // 0x000000018675D160-0x000000018675D1B4
				public static void Constructor(); // 0x0000000183FB28A0-0x0000000183FB2930
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x000000018675D1B4-0x000000018675D3EC
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // 0x00000001867585C8-0x0000000186758700
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x0000000186758700-0x0000000186758838
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel_BurstManaged(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // 0x000000018675672C-0x0000000186756F68
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel_BurstManaged(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x0000000186756F68-0x00000001867570A4
		}
	
		[BurstCompile]
		private static class CreateUpdatecolliderListJobKernels // TypeDefIndex: 48361
		{
			// Nested types
			public unsafe delegate void CreateUpdatecolliderListKernel_000003D5_PostfixBurstDelegate(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // TypeDefIndex: 48357; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class CreateUpdatecolliderListKernel_000003D5_BurstDirectCall // TypeDefIndex: 48358
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdatecolliderListKernel_000003D5_BurstDirectCall(); // 0x0000000183FB2D20-0x0000000183FB2D30
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000689ac); // 0x000000018675A1BC-0x000000018675A2C0
				private static IntPtr GetFunctionPointer(); // 0x000000018675A2C0-0x000000018675A314
				public static void Constructor(); // 0x0000000183FB2810-0x0000000183FB28A0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // 0x000000018675A314-0x000000018675A3D0
			}
	
			public unsafe delegate void CreateUpdatecolliderListRangeKernel_000003D6_PostfixBurstDelegate(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // TypeDefIndex: 48359; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class CreateUpdatecolliderListRangeKernel_000003D6_BurstDirectCall // TypeDefIndex: 48360
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdatecolliderListRangeKernel_000003D6_BurstDirectCall(); // 0x0000000183FB2D10-0x0000000183FB2D20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000689c1); // 0x000000018675A54C-0x000000018675A650
				private static IntPtr GetFunctionPointer(); // 0x000000018675A650-0x000000018675A6A4
				public static void Constructor(); // 0x0000000183FB2780-0x0000000183FB2810
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // 0x000000018675A6A4-0x000000018675A780
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListKernel(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // 0x0000000186759DC4-0x0000000186759E40
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListRangeKernel(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // 0x0000000186759EAC-0x0000000186759F28
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListKernel_BurstManaged(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // 0x00000001867570A4-0x00000001867574D8
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListRangeKernel_BurstManaged(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // 0x0000000186759E40-0x0000000186759EAC
		}
	
		[BurstCompile]
		public static class StartSimulationStepJobKernels // TypeDefIndex: 48366
		{
			// Nested types
			public unsafe delegate void StartSimulationStepKernel_000003D7_PostfixBurstDelegate(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // TypeDefIndex: 48362; 0x000000018674680C-0x00000001867468DC
	
			internal static class StartSimulationStepKernel_000003D7_BurstDirectCall // TypeDefIndex: 48363
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepKernel_000003D7_BurstDirectCall(); // 0x0000000183FB2D00-0x0000000183FB2D10
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068a32); // 0x00000001867626D4-0x00000001867627D8
				private static IntPtr GetFunctionPointer(); // 0x00000001867627D8-0x000000018676282C
				public static void Constructor(); // 0x0000000183FB26F0-0x0000000183FB2780
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // 0x000000018676282C-0x0000000186762A4C
			}
	
			public unsafe delegate void StartSimulationStepRangeKernel_000003D8_PostfixBurstDelegate(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // TypeDefIndex: 48364; 0x0000000186746DE4-0x0000000186746EB4
	
			internal static class StartSimulationStepRangeKernel_000003D8_BurstDirectCall // TypeDefIndex: 48365
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepRangeKernel_000003D8_BurstDirectCall(); // 0x0000000183FB2CF0-0x0000000183FB2D00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068a6b); // 0x0000000186762B68-0x0000000186762C6C
				private static IntPtr GetFunctionPointer(); // 0x0000000186762C6C-0x0000000186762CC0
				public static void Constructor(); // 0x0000000183FB2660-0x0000000183FB26F0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // 0x0000000186762CC0-0x0000000186762EDC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void StartSimulationStepKernel(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // 0x000000018676132C-0x0000000186761454
			[BurstCompile]
			internal static unsafe void StartSimulationStepRangeKernel(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // 0x0000000186761454-0x0000000186761580
			[BurstCompile]
			public static unsafe void StartSimulationStepKernel_BurstManaged(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // 0x0000000186757618-0x00000001867584A0
			[BurstCompile]
			public static unsafe void StartSimulationStepRangeKernel_BurstManaged(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // 0x00000001867584A0-0x00000001867585C8
		}
	
		[BurstCompile]
		private static class PostSimulationUpdateJobKernels // TypeDefIndex: 48371
		{
			// Nested types
			public unsafe delegate void PostSimulationUpdateKernel_000003D9_PostfixBurstDelegate(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 48367; 0x0000000182C394B0-0x0000000182C394D0
	
			internal static class PostSimulationUpdateKernel_000003D9_BurstDirectCall // TypeDefIndex: 48368
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostSimulationUpdateKernel_000003D9_BurstDirectCall(); // 0x0000000183FB2CE0-0x0000000183FB2CF0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068aac); // 0x000000018675B894-0x000000018675B998
				private static IntPtr GetFunctionPointer(); // 0x000000018675B998-0x000000018675B9EC
				public static void Constructor(); // 0x0000000183FB25D0-0x0000000183FB2660
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // 0x000000018675B9EC-0x000000018675BAD8
			}
	
			public unsafe delegate void PostSimulationUpdateRangeKernel_000003DA_PostfixBurstDelegate(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 48369; 0x0000000182C394B0-0x0000000182C394D0
	
			internal static class PostSimulationUpdateRangeKernel_000003DA_BurstDirectCall // TypeDefIndex: 48370
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostSimulationUpdateRangeKernel_000003DA_BurstDirectCall(); // 0x0000000183FB2CD0-0x0000000183FB2CE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068ac7); // 0x000000018675BC70-0x000000018675BD74
				private static IntPtr GetFunctionPointer(); // 0x000000018675BD74-0x000000018675BDC8
				public static void Constructor(); // 0x0000000183FB2540-0x0000000183FB25D0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // 0x000000018675BDC8-0x000000018675BEE8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PostSimulationUpdateKernel(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // 0x000000018675B44C-0x000000018675B4E0
			[BurstCompile]
			internal static unsafe void PostSimulationUpdateRangeKernel(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // 0x000000018675B574-0x000000018675B608
			[BurstCompile]
			public static unsafe void PostSimulationUpdateKernel_BurstManaged(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // 0x00000001867574D8-0x0000000186757618
			[BurstCompile]
			public static unsafe void PostSimulationUpdateRangeKernel_BurstManaged(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // 0x000000018675B4E0-0x000000018675B574
		}
	
		public enum ColliderType : byte // TypeDefIndex: 48372
		{
			None = 0,
			Sphere = 1,
			CapsuleX_Center = 2,
			CapsuleY_Center = 3,
			CapsuleZ_Center = 4,
			CapsuleX_Start = 5,
			CapsuleY_Start = 6,
			CapsuleZ_Start = 7,
			Plane = 8,
			Box = 9
		}
	
		internal struct WorkData // TypeDefIndex: 48373
		{
			// Fields
			public AABB aabb; // 0x00
			public float2 radius; // 0x30
			public double3x2 oldPos; // 0x38
			public double3x2 nextPos; // 0x68
			public quaternion inverseOldRot; // 0x98
			public quaternion rot; // 0xA8
		}
	
		[BurstCompile]
		private struct PreSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48374
		{
			// Fields
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[ReadOnly]
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x10
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x20
			public NativeArray<ExBitFlag8> flagArray; // 0x30
			[ReadOnly]
			public NativeArray<float3> centerArray; // 0x40
			[WriteOnly]
			public NativeArray<double3> framePositions; // 0x50
			[WriteOnly]
			public NativeArray<quaternion> frameRotations; // 0x60
			[WriteOnly]
			public NativeArray<float3> frameScales; // 0x70
			public NativeArray<double3> oldFramePositions; // 0x80
			public NativeArray<quaternion> oldFrameRotations; // 0x90
			public NativeArray<double3> nowPositions; // 0xA0
			public NativeArray<quaternion> nowRotations; // 0xB0
			public NativeArray<double3> oldPositions; // 0xC0
			public NativeArray<quaternion> oldRotations; // 0xD0
			[ReadOnly]
			public NativeArray<double3> transformPositionArray; // 0xE0
			[ReadOnly]
			public NativeArray<quaternion> transformRotationArray; // 0xF0
			[ReadOnly]
			public NativeArray<float3> transformScaleArray; // 0x100
			[ReadOnly]
			public int _indexCount; // 0x110
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183D525B0-0x0000000183D525F0
			[IDTag(1)]
			public void Execute(); // 0x000000018675BFAC-0x000000018675C024
			[IDTag(0)]
			public void Execute(int index); // 0x000000018675C024-0x000000018675C8B8
			public void UnsafeDo(); // 0x000000018675C8B8-0x000000018675CAC8
		}
	
		[BurstCompile]
		private struct CreateUpdatecolliderListJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48375
		{
			// Fields
			public int updateIndex; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> jobColliderCounter; // 0x18
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> jobColliderIndexList; // 0x28
			[ReadOnly]
			public int _indexCount; // 0x38
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183C2F430-0x0000000183C2F4A0
			[IDTag(1)]
			public void Execute(); // 0x0000000186759F28-0x0000000186759F9C
			[IDTag(0)]
			public void Execute(int teamId); // 0x0000000186759F9C-0x000000018675A11C
			public void UnsafeDo(); // 0x000000018675A11C-0x000000018675A1BC
		}
	
		[BurstCompile]
		private struct StartSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48376
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobColliderIndexList; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x20
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x30
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagArray; // 0x40
			[ReadOnly]
			public NativeArray<float3> sizeArray; // 0x50
			[ReadOnly]
			public NativeArray<double3> framePositions; // 0x60
			[ReadOnly]
			public NativeArray<quaternion> frameRotations; // 0x70
			[ReadOnly]
			public NativeArray<float3> frameScales; // 0x80
			[ReadOnly]
			public NativeArray<double3> oldFramePositions; // 0x90
			[ReadOnly]
			public NativeArray<quaternion> oldFrameRotations; // 0xA0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<double3> nowPositions; // 0xB0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> nowRotations; // 0xC0
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> oldPositions; // 0xD0
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> oldRotations; // 0xE0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<WorkData> workDataArray; // 0xF0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x100
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183BBAF90-0x0000000183BBB010
			[IDTag(1)]
			public void Execute(); // 0x0000000186761580-0x0000000186761618
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186761618-0x00000001867624AC
			public void UnsafeDo(); // 0x00000001867624AC-0x00000001867626D4
		}
	
		[BurstCompile]
		private struct EndSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48377
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> jobColliderIndexList; // 0x00
			[ReadOnly]
			public NativeArray<double3> nowPositions; // 0x10
			[ReadOnly]
			public NativeArray<quaternion> nowRotations; // 0x20
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<double3> oldPositions; // 0x30
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> oldRotations; // 0x40
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x50
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183C06610-0x0000000183C06690
			[IDTag(1)]
			public void Execute(); // 0x000000018675AA6C-0x000000018675AB00
			[IDTag(0)]
			public void Execute(int index); // 0x000000018675A9CC-0x000000018675AA6C
			public void UnsafeDo(); // 0x000000018675AB00-0x000000018675ABBC
		}
	
		[BurstCompile]
		private struct PostSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48378
		{
			// Fields
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x10
			[ReadOnly]
			public NativeArray<double3> framePositions; // 0x20
			[ReadOnly]
			public NativeArray<quaternion> frameRotations; // 0x30
			[WriteOnly]
			public NativeArray<double3> oldFramePositions; // 0x40
			[WriteOnly]
			public NativeArray<quaternion> oldFrameRotations; // 0x50
			[ReadOnly]
			public int _indexCount; // 0x60
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183DB9AD0-0x0000000183DB9B10
			[IDTag(1)]
			public void Execute(); // 0x000000018675B608-0x000000018675B67C
			[IDTag(0)]
			public void Execute(int index); // 0x000000018675B67C-0x000000018675B7D4
			public void UnsafeDo(); // 0x000000018675B7D4-0x000000018675B894
		}
	
		// Constructors
		public ColliderManager(); // 0x00000001835B9410-0x00000001835B9490
	
		// Methods
		public void Dispose(); // 0x0000000183E8B1E0-0x0000000183E8B400
		public void EnterdEditMode(); // 0x0000000186758E94-0x0000000186758EE4
		public void Initialize(); // 0x0000000183E89760-0x0000000183E89B90
		public bool IsValid(); // 0x0000000183CF6A70-0x0000000183CF6AA0
		public void Register(ClothProcess cprocess); // 0x0000000183CF7F20-0x0000000183CF8290
		public void Exit(ClothProcess cprocess); // 0x0000000183CF38B0-0x0000000183CF48A0
		internal void InitColliders(ClothProcess cprocess); // 0x0000000183CF6820-0x0000000183CF6A20
		internal void UpdateColliders(ClothProcess cprocess); // 0x0000000183CF63B0-0x0000000183CF6820
		private void AddCollider(ClothProcess cprocess, ColliderComponent col); // 0x0000000186758838-0x0000000186758E94
		internal void RemoveCollider(ColliderComponent col, int teamId); // 0x0000000183CF5790-0x0000000183CF5D90
		private void AddColliderInternal(ClothProcess cprocess, ColliderComponent col, int index, int arrayIndex, int transformIndex); // 0x00000001833A86A0-0x00000001833A8BF0
		internal void EnableCollider(ColliderComponent col, int teamId, bool sw); // 0x0000000183CF61E0-0x0000000183CF63B0
		internal void EnableTeamCollider(int teamId); // 0x00000001833A8BF0-0x00000001833A8D60
		internal void UpdateParameters(ColliderComponent col, int teamId); // 0x0000000186759A9C-0x0000000186759D50
		internal JobHandle PreSimulationUpdate(JobHandle jobHandle); // 0x0000000182F914D0-0x0000000182F918A0
		internal JobHandle CreateUpdateColliderList(int updateIndex, JobHandle jobHandle); // 0x0000000182F8E710-0x0000000182F8EA60
		internal JobHandle StartSimulationStep(JobHandle jobHandle); // 0x0000000183A95170-0x0000000183A95630
		internal JobHandle EndSimulationStep(JobHandle jobHandle); // 0x0000000182F8EA60-0x0000000182F8ED70
		internal JobHandle PostSimulationUpdate(JobHandle jobHandle); // 0x0000000182F8D550-0x0000000182F8D900
		public void InformationLog(StringBuilder allsb); // 0x0000000186758EE4-0x0000000186759A9C
		public static void Initialize_CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D5_BurstDirectCall(); // 0x00000001844F7170-0x00000001844F71D0
		public static void Initialize_CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D6_BurstDirectCall(); // 0x00000001844F71D0-0x00000001844F7230
		public static void Initialize_PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D9_BurstDirectCall(); // 0x00000001844F7230-0x00000001844F7290
		public static void Initialize_PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003DA_BurstDirectCall(); // 0x00000001844F7290-0x00000001844F72F0
	}

	public class SimulationManager : IManager, IValid // TypeDefIndex: 48428
	{
		// Fields
		public ExNativeArray<short> teamIdArray; // 0x10
		public ExNativeArray<double3> nextPosArray; // 0x18
		public ExNativeArray<double3> oldPosArray; // 0x20
		public ExNativeArray<quaternion> oldRotArray; // 0x28
		public ExNativeArray<double3> basePosArray; // 0x30
		public ExNativeArray<quaternion> baseRotArray; // 0x38
		public ExNativeArray<double3> oldPositionArray; // 0x40
		public ExNativeArray<quaternion> oldRotationArray; // 0x48
		public ExNativeArray<double3> velocityPosArray; // 0x50
		public ExNativeArray<double3> dispPosArray; // 0x58
		public ExNativeArray<float3> velocityArray; // 0x60
		public ExNativeArray<float3> realVelocityArray; // 0x68
		public ExNativeArray<float> frictionArray; // 0x70
		public ExNativeArray<float> staticFrictionArray; // 0x78
		public ExNativeArray<float3> collisionNormalArray; // 0x80
		public DistanceConstraint distanceConstraint; // 0x88
		public TriangleBendingConstraint bendingConstraint; // 0x90
		public TetherConstraint tetherConstraint; // 0x98
		public AngleConstraint angleConstraint; // 0xA0
		public InertiaConstraint inertiaConstraint; // 0xA8
		public ColliderCollisionConstraint colliderCollisionConstraint; // 0xB0
		public MotionConstraint motionConstraint; // 0xB8
		public SelfCollisionConstraint selfCollisionConstraint; // 0xC0
		internal ExProcessingList<int> processingStepParticle; // 0xC8
		internal ExProcessingList<int> processingStepTriangleBending; // 0xD0
		internal ExProcessingList<int> processingStepEdgeCollision; // 0xD8
		internal ExProcessingList<int> processingStepCollider; // 0xE0
		internal ExProcessingList<int> processingStepBaseLine; // 0xE8
		internal ExProcessingList<int> processingStepMotionParticle; // 0xF0
		internal ExProcessingList<int> processingSelfParticle; // 0xF8
		internal ExProcessingList<uint> processingSelfPointTriangle; // 0x100
		internal ExProcessingList<uint> processingSelfEdgeEdge; // 0x108
		internal ExProcessingList<uint> processingSelfTrianglePoint; // 0x110
		internal NativeArray<double3> tempFloat3Buffer; // 0x118
		internal NativeArray<int> countArray; // 0x128
		internal NativeArray<int> sumArray; // 0x138
		public NativeArray<double3> stepBasicPositionBuffer; // 0x148
		public NativeArray<quaternion> stepBasicRotationBuffer; // 0x158
		[CompilerGenerated]
		private int _SimulationStepCount_k__BackingField; // 0x168
		private bool isValid; // 0x16C
	
		// Properties
		public int ParticleCount { get; } // 0x0000000182F8B100-0x0000000182F8B170 
		internal int SimulationStepCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87400-0x0000000184D87410 0x0000000184D87410-0x0000000184D87420
		internal int WorkerCount { get; } // 0x00000001867612DC-0x000000018676132C 
	
		// Nested types
		[BurstCompile]
		public static class CreateUpdateParticleListKernels // TypeDefIndex: 48384
		{
			// Nested types
			public unsafe delegate void CreateUpdateParticleListKernel_00000403_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // TypeDefIndex: 48380; 0x000000018669A174-0x000000018669A278
	
			internal static class CreateUpdateParticleListKernel_00000403_BurstDirectCall // TypeDefIndex: 48381
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdateParticleListKernel_00000403_BurstDirectCall(); // 0x0000000183FB2CC0-0x0000000183FB2CD0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068b6d); // 0x000000018676C3A8-0x000000018676C4AC
				private static IntPtr GetFunctionPointer(); // 0x000000018676C4AC-0x000000018676C500
				public static void Constructor(); // 0x0000000183FB24B0-0x0000000183FB2540
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // 0x000000018676C500-0x000000018676C798
			}
	
			public unsafe delegate void CreateUpdateParticleListRangeKernel_00000404_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // TypeDefIndex: 48382; 0x000000018669A174-0x000000018669A278
	
			internal static class CreateUpdateParticleListRangeKernel_00000404_BurstDirectCall // TypeDefIndex: 48383
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdateParticleListRangeKernel_00000404_BurstDirectCall(); // 0x0000000183FB2CB0-0x0000000183FB2CC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068bb2); // 0x000000018676CC88-0x000000018676CD8C
				private static IntPtr GetFunctionPointer(); // 0x000000018676CD8C-0x000000018676CDE0
				public static void Constructor(); // 0x0000000183FB2420-0x0000000183FB24B0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // 0x000000018676CDE0-0x000000018676D078
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListKernel(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // 0x000000018676C9B8-0x000000018676CB20
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListRangeKernel(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // 0x000000018676CB20-0x000000018676CC88
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListKernel_BurstManaged(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // 0x00000001867641EC-0x0000000186764678
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // 0x0000000186764678-0x00000001867655A8
		}
	
		[BurstCompile]
		public static class PreSimulationUpdateJobKernels // TypeDefIndex: 48389
		{
			// Nested types
			public unsafe delegate void PreSimulationUpdateKernel_00000405_PostfixBurstDelegate(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // TypeDefIndex: 48385; 0x000000018677243C-0x0000000186772530
	
			internal static class PreSimulationUpdateKernel_00000405_BurstDirectCall // TypeDefIndex: 48386
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateKernel_00000405_BurstDirectCall(); // 0x0000000183FB2CA0-0x0000000183FB2CB0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068c45); // 0x0000000186771F24-0x0000000186772028
				private static IntPtr GetFunctionPointer(); // 0x0000000186772028-0x000000018677207C
				public static void Constructor(); // 0x0000000183FB2390-0x0000000183FB2420
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // 0x000000018677207C-0x00000001867722FC
			}
	
			public unsafe delegate void PreSimulationUpdateRangeKernel_00000406_PostfixBurstDelegate(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // TypeDefIndex: 48387; 0x000000018677243C-0x0000000186772530
	
			internal static class PreSimulationUpdateRangeKernel_00000406_BurstDirectCall // TypeDefIndex: 48388
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateRangeKernel_00000406_BurstDirectCall(); // 0x0000000183FB2C90-0x0000000183FB2CA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068c87); // 0x0000000186772604-0x0000000186772708
				private static IntPtr GetFunctionPointer(); // 0x0000000186772708-0x000000018677275C
				public static void Constructor(); // 0x0000000183FB2300-0x0000000183FB2390
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // 0x000000018677275C-0x00000001867729D4
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // 0x00000001867710B8-0x0000000186771210
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // 0x0000000186771210-0x0000000186771368
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel_BurstManaged(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // 0x00000001867707D0-0x00000001867710B8
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel_BurstManaged(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // 0x0000000186765FC8-0x00000001867673DC
		}
	
		[BurstCompile]
		private static class StartSimulationStepJobKernels // TypeDefIndex: 48400
		{
			// Nested types
			public unsafe delegate void StartSimulationStepKernel_00000407_PostfixBurstDelegate(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // TypeDefIndex: 48390; 0x0000000186777268-0x00000001867773DC
	
			internal static class StartSimulationStepKernel_00000407_BurstDirectCall // TypeDefIndex: 48391
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepKernel_00000407_BurstDirectCall(); // 0x0000000183FB2C80-0x0000000183FB2C90
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068d7f); // 0x0000000186776B64-0x0000000186776C68
				private static IntPtr GetFunctionPointer(); // 0x0000000186776C68-0x0000000186776CBC
				public static void Constructor(); // 0x0000000183FB2270-0x0000000183FB2300
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000186776CBC-0x0000000186777074
			}
	
			public unsafe delegate void StartSimulationStepRangeKernel_00000408_PostfixBurstDelegate(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // TypeDefIndex: 48392; 0x0000000186777B88-0x0000000186777D00
	
			internal static class StartSimulationStepRangeKernel_00000408_BurstDirectCall // TypeDefIndex: 48393
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepRangeKernel_00000408_BurstDirectCall(); // 0x0000000183FB2C70-0x0000000183FB2C80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068ddc); // 0x00000001867774A4-0x00000001867775A8
				private static IntPtr GetFunctionPointer(); // 0x00000001867775A8-0x00000001867775FC
				public static void Constructor(); // 0x0000000183FB21E0-0x0000000183FB2270
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x00000001867775FC-0x00000001867779AC
			}
	
			public delegate void Spring_00000409_PostfixBurstDelegate([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // TypeDefIndex: 48394; 0x0000000182C394B0-0x0000000182C394D0
	
			internal static class Spring_00000409_BurstDirectCall // TypeDefIndex: 48395
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Spring_00000409_BurstDirectCall(); // 0x0000000183FB2C60-0x0000000183FB2C70
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068e0d); // 0x0000000186772B14-0x0000000186772C18
				private static IntPtr GetFunctionPointer(); // 0x0000000186772C18-0x0000000186772C6C
				public static void Constructor(); // 0x0000000183FB2150-0x0000000183FB21E0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static void Invoke([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // 0x0000000186772C6C-0x0000000186772D68
			}
	
			public unsafe delegate void Wind_0000040A_PostfixBurstDelegate(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // TypeDefIndex: 48396; 0x000000018677B4EC-0x000000018677B578
	
			internal static class Wind_0000040A_BurstDirectCall // TypeDefIndex: 48397
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Wind_0000040A_BurstDirectCall(); // 0x0000000183FB2C50-0x0000000183FB2C60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068e32); // 0x000000018677B0A4-0x000000018677B1A8
				private static IntPtr GetFunctionPointer(); // 0x000000018677B1A8-0x000000018677B1FC
				public static void Constructor(); // 0x0000000183FB20C0-0x0000000183FB2150
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // 0x000000018677B1FC-0x000000018677B378
			}
	
			public delegate void WindForceBlend_0000040B_PostfixBurstDelegate([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // TypeDefIndex: 48398; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class WindForceBlend_0000040B_BurstDirectCall // TypeDefIndex: 48399
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WindForceBlend_0000040B_BurstDirectCall(); // 0x0000000183FB2C40-0x0000000183FB2C50
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068e4e); // 0x000000018677A3B0-0x000000018677A4B4
				private static IntPtr GetFunctionPointer(); // 0x000000018677A4B4-0x000000018677A508
				public static void Constructor(); // 0x0000000183FB2030-0x0000000183FB20C0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static void Invoke([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // 0x000000018677A508-0x000000018677A5CC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void StartSimulationStepKernel(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x00000001867742B4-0x00000001867744B0
			[BurstCompile]
			internal static unsafe void StartSimulationStepRangeKernel(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x00000001867744B0-0x00000001867746AC
			[BurstCompile]
			private static void Spring([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // 0x000000018677346C-0x0000000186773504
			[BurstCompile]
			private static unsafe void Wind(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // 0x0000000186774B0C-0x0000000186774BE8
			[BurstCompile]
			private static void WindForceBlend([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // 0x00000001867746AC-0x000000018677472C
			[BurstCompile]
			public static unsafe void StartSimulationStepKernel_BurstManaged(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000186773504-0x00000001867742B4
			[BurstCompile]
			public static unsafe void StartSimulationStepRangeKernel_BurstManaged(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x00000001867673DC-0x00000001867675FC
			[BurstCompile]
			public static void Spring_BurstManaged([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // 0x0000000186772F68-0x000000018677346C
			[BurstCompile]
			public static unsafe void Wind_BurstManaged(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // 0x000000018677472C-0x0000000186774B0C
			[BurstCompile]
			public static void WindForceBlend_BurstManaged([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // 0x00000001867675FC-0x0000000186768668
		}
	
		[BurstCompile]
		private static class UpdateStepBasicPotureJobKernels // TypeDefIndex: 48405
		{
			// Nested types
			public unsafe delegate void UpdateStepBasicPotureKernel_0000040C_PostfixBurstDelegate(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // TypeDefIndex: 48401; 0x00000001866A5628-0x00000001866A56D0
	
			internal static class UpdateStepBasicPotureKernel_0000040C_BurstDirectCall // TypeDefIndex: 48402
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateStepBasicPotureKernel_0000040C_BurstDirectCall(); // 0x0000000183FB2C30-0x0000000183FB2C40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068ead); // 0x0000000186779B84-0x0000000186779C88
				private static IntPtr GetFunctionPointer(); // 0x0000000186779C88-0x0000000186779CDC
				public static void Constructor(); // 0x0000000183FB1FA0-0x0000000183FB2030
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000186779CDC-0x0000000186779EA8
			}
	
			public unsafe delegate void UpdateStepBasicPotureRangeKernel_0000040D_PostfixBurstDelegate(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // TypeDefIndex: 48403; 0x00000001866A5B60-0x00000001866A5C0C
	
			internal static class UpdateStepBasicPotureRangeKernel_0000040D_BurstDirectCall // TypeDefIndex: 48404
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateStepBasicPotureRangeKernel_0000040D_BurstDirectCall(); // 0x0000000183FB2C20-0x0000000183FB2C30
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068edd); // 0x0000000186779FA0-0x000000018677A0A4
				private static IntPtr GetFunctionPointer(); // 0x000000018677A0A4-0x000000018677A0F8
				public static void Constructor(); // 0x0000000183FB1F10-0x0000000183FB1FA0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x000000018677A0F8-0x000000018677A2C0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void UpdateStepBasicPotureKernel(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000186778E08-0x0000000186778F04
			[BurstCompile]
			internal static unsafe void UpdateStepBasicPotureRangeKernel(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x0000000186778F04-0x0000000186779004
			[BurstCompile]
			public static unsafe void UpdateStepBasicPotureKernel_BurstManaged(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000186778540-0x0000000186778E08
			[BurstCompile]
			public static unsafe void UpdateStepBasicPotureRangeKernel_BurstManaged(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x0000000186768668-0x0000000186768764
		}
	
		[BurstCompile]
		private static class EndSimulationStepJobKernels // TypeDefIndex: 48410
		{
			// Nested types
			public unsafe delegate void EndSimulationStepKernel_0000040E_PostfixBurstDelegate(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // TypeDefIndex: 48406; 0x000000018676FEE8-0x000000018676FFB4
	
			internal static class EndSimulationStepKernel_0000040E_BurstDirectCall // TypeDefIndex: 48407
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EndSimulationStepKernel_0000040E_BurstDirectCall(); // 0x0000000183FB2C10-0x0000000183FB2C20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068f57); // 0x000000018676FA38-0x000000018676FB3C
				private static IntPtr GetFunctionPointer(); // 0x000000018676FB3C-0x000000018676FB90
				public static void Constructor(); // 0x0000000183FB1E80-0x0000000183FB1F10
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // 0x000000018676FB90-0x000000018676FDB4
			}
	
			public unsafe delegate void EndSimulationStepRangeKernel_0000040F_PostfixBurstDelegate(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // TypeDefIndex: 48408; 0x000000018677050C-0x00000001867705DC
	
			internal static class EndSimulationStepRangeKernel_0000040F_BurstDirectCall // TypeDefIndex: 48409
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EndSimulationStepRangeKernel_0000040F_BurstDirectCall(); // 0x0000000183FB2C00-0x0000000183FB2C10
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068f90); // 0x000000018677007C-0x0000000186770180
				private static IntPtr GetFunctionPointer(); // 0x0000000186770180-0x00000001867701D4
				public static void Constructor(); // 0x0000000183FB1DF0-0x0000000183FB1E80
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x00000001867701D4-0x00000001867703F0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void EndSimulationStepKernel(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // 0x000000018676E70C-0x000000018676E838
			[BurstCompile]
			internal static unsafe void EndSimulationStepRangeKernel(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x000000018676E838-0x000000018676E964
			[BurstCompile]
			public static unsafe void EndSimulationStepKernel_BurstManaged(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // 0x000000018676D948-0x000000018676E70C
			[BurstCompile]
			public static unsafe void EndSimulationStepRangeKernel_BurstManaged(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x00000001867655A8-0x0000000186765FC8
		}
	
		[BurstCompile]
		private static class CalcDisplayPositionJobKernels // TypeDefIndex: 48415
		{
			// Nested types
			public unsafe delegate void CalcDisplayPositionKernel_00000410_PostfixBurstDelegate(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // TypeDefIndex: 48411; 0x000000018676B93C-0x000000018676B9D8
	
			internal static class CalcDisplayPositionKernel_00000410_BurstDirectCall // TypeDefIndex: 48412
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcDisplayPositionKernel_00000410_BurstDirectCall(); // 0x0000000183FB2BF0-0x0000000183FB2C00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00068ff5); // 0x000000018676B534-0x000000018676B638
				private static IntPtr GetFunctionPointer(); // 0x000000018676B638-0x000000018676B68C
				public static void Constructor(); // 0x0000000183FB1D60-0x0000000183FB1DF0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // 0x000000018676B68C-0x000000018676B838
			}
	
			public unsafe delegate void CalcDisplayPositionRangeKernel_00000411_PostfixBurstDelegate(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // TypeDefIndex: 48413; 0x000000018676B93C-0x000000018676B9D8
	
			internal static class CalcDisplayPositionRangeKernel_00000411_BurstDirectCall // TypeDefIndex: 48414
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcDisplayPositionRangeKernel_00000411_BurstDirectCall(); // 0x0000000183FB2BE0-0x0000000183FB2BF0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00069022); // 0x000000018676BAA0-0x000000018676BBA4
				private static IntPtr GetFunctionPointer(); // 0x000000018676BBA4-0x000000018676BBF8
				public static void Constructor(); // 0x0000000183FB1CD0-0x0000000183FB1D60
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // 0x000000018676BBF8-0x000000018676BDA4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcDisplayPositionKernel(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // 0x000000018676ABDC-0x000000018676ACCC
			[BurstCompile]
			internal static unsafe void CalcDisplayPositionRangeKernel(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // 0x000000018676ACCC-0x000000018676ADBC
			[BurstCompile]
			public static unsafe void CalcDisplayPositionKernel_BurstManaged(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // 0x000000018676A670-0x000000018676ABDC
			[BurstCompile]
			public static unsafe void CalcDisplayPositionRangeKernel_BurstManaged(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // 0x00000001867640F8-0x00000001867641EC
		}
	
		[BurstCompile]
		private static class ClearStepCounterKernels // TypeDefIndex: 48418
		{
			// Nested types
			public unsafe delegate void ClearStepCounterKernel_00000412_PostfixBurstDelegate(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // TypeDefIndex: 48416; 0x000000018621C638-0x000000018621C6AC
	
			internal static class ClearStepCounterKernel_00000412_BurstDirectCall // TypeDefIndex: 48417
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearStepCounterKernel_00000412_BurstDirectCall(); // 0x0000000183FB2BD0-0x0000000183FB2BE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006905d); // 0x000000018676BEA8-0x000000018676BFAC
				private static IntPtr GetFunctionPointer(); // 0x000000018676BFAC-0x000000018676C000
				public static void Constructor(); // 0x0000000183FB1C40-0x0000000183FB1CD0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // 0x000000018676C000-0x000000018676C13C
			}
	
			// Methods
			[BurstCompile]
			internal static unsafe void ClearStepCounterKernel(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // 0x000000018676C13C-0x000000018676C200
			[BurstCompile]
			public static unsafe void ClearStepCounterKernel_BurstManaged(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // 0x0000000184D87420-0x0000000184D87460
		}
	
		[BurstCompile]
		private struct PreSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48419
		{
			// Fields
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x10
			[ReadOnly]
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x20
			[ReadOnly]
			public NativeArray<double3> positions; // 0x30
			[ReadOnly]
			public NativeArray<quaternion> rotations; // 0x40
			[ReadOnly]
			public NativeArray<float> vertexDepths; // 0x50
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x60
			[WriteOnly]
			public NativeArray<double3> nextPosArray; // 0x70
			public NativeArray<double3> oldPosArray; // 0x80
			public NativeArray<quaternion> oldRotArray; // 0x90
			[WriteOnly]
			public NativeArray<double3> basePosArray; // 0xA0
			[WriteOnly]
			public NativeArray<quaternion> baseRotArray; // 0xB0
			public NativeArray<double3> oldPositionArray; // 0xC0
			public NativeArray<quaternion> oldRotationArray; // 0xD0
			[WriteOnly]
			public NativeArray<double3> velocityPosArray; // 0xE0
			public NativeArray<double3> dispPosArray; // 0xF0
			public NativeArray<float3> velocityArray; // 0x100
			public NativeArray<float3> realVelocityArray; // 0x110
			[WriteOnly]
			public NativeArray<float> frictionArray; // 0x120
			[WriteOnly]
			public NativeArray<float> staticFrictionArray; // 0x130
			[WriteOnly]
			public NativeArray<float3> collisionNormalArray; // 0x140
			[ReadOnly]
			public int _indexCount; // 0x150
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183D42280-0x0000000183D422C0
			[IDTag(1)]
			public void Execute(); // 0x0000000186771C74-0x0000000186771CEC
			[IDTag(0)]
			public void Execute(int pindex); // 0x0000000186771368-0x0000000186771C74
			public void UnsafeDo(); // 0x0000000186771CEC-0x0000000186771F24
		}
	
		[BurstCompile]
		private struct ClearStepCounter : IJob, IUnsafeJob // TypeDefIndex: 48420
		{
			// Fields
			[WriteOnly]
			public NativeReference<int> processingStepParticle; // 0x00
			[WriteOnly]
			public NativeReference<int> processingStepTriangleBending; // 0x10
			[WriteOnly]
			public NativeReference<int> processingStepEdgeCollision; // 0x20
			[WriteOnly]
			public NativeReference<int> processingStepCollider; // 0x30
			[WriteOnly]
			public NativeReference<int> processingStepBaseLine; // 0x40
			[WriteOnly]
			public NativeReference<int> processingStepMotionParticle; // 0x50
			[WriteOnly]
			public NativeReference<int> processingSelfParticle; // 0x60
			[WriteOnly]
			public NativeReference<int> processingSelfPointTriangle; // 0x70
			[WriteOnly]
			public NativeReference<int> processingSelfEdgeEdge; // 0x80
			[WriteOnly]
			public NativeReference<int> processingSelfTrianglePoint; // 0x90
	
			// Methods
			public void Execute(); // 0x000000018676C200-0x000000018676C2B0
			public void UnsafeDo(); // 0x000000018676C2B0-0x000000018676C3A8
		}
	
		[BurstCompile]
		private struct CreateUpdateParticleList : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48421
		{
			// Fields
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x10
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> stepParticleIndexCounter; // 0x20
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> stepParticleIndexArray; // 0x30
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> stepBaseLineIndexCounter; // 0x40
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> stepBaseLineIndexArray; // 0x50
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> stepTriangleBendIndexCounter; // 0x60
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> stepTriangleBendIndexArray; // 0x70
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> stepEdgeCollisionIndexCounter; // 0x80
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> stepEdgeCollisionIndexArray; // 0x90
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> motionParticleIndexCounter; // 0xA0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> motionParticleIndexArray; // 0xB0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> selfParticleCounter; // 0xC0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> selfParticleIndexArray; // 0xD0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> selfPointTriangleCounter; // 0xE0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<uint> selfPointTriangleIndexArray; // 0xF0
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> selfEdgeEdgeCounter; // 0x100
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<uint> selfEdgeEdgeIndexArray; // 0x110
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeReference<int> selfTrianglePointCounter; // 0x120
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<uint> selfTrianglePointIndexArray; // 0x130
			[ReadOnly]
			public int _indexCount; // 0x140
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183BB6810-0x0000000183BB6880
			[IDTag(1)]
			public void Execute(); // 0x000000018676D1C4-0x000000018676D23C
			[IDTag(0)]
			public void Execute(int teamId); // 0x000000018676D23C-0x000000018676D71C
			public void UnsafeDo(); // 0x000000018676D71C-0x000000018676D948
		}
	
		[BurstCompile]
		private struct StartSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48422
		{
			// Fields
			public float4 simulationPower; // 0x00
			public float simulationDeltaTime; // 0x10
			[ReadOnly]
			public NativeArray<int> stepParticleIndexArray; // 0x18
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x28
			[ReadOnly]
			public NativeArray<float> depthArray; // 0x38
			[ReadOnly]
			public NativeArray<double3> positions; // 0x48
			[ReadOnly]
			public NativeArray<quaternion> rotations; // 0x58
			[ReadOnly]
			public NativeArray<int> vertexRootIndices; // 0x68
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x78
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x88
			[ReadOnly]
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x98
			[ReadOnly]
			public NativeArray<TeamWindData> teamWindArray; // 0xA8
			[ReadOnly]
			public NativeArray<WindManager.WindData> windDataArray; // 0xB8
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0xC8
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0xD8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<double3> nextPosArray; // 0xE8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<double3> basePosArray; // 0xF8
			[ReadOnly]
			public NativeArray<float3> velocityArray; // 0x108
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> baseRotArray; // 0x118
			[ReadOnly]
			public NativeArray<double3> oldPositionArray; // 0x128
			[ReadOnly]
			public NativeArray<quaternion> oldRotationArray; // 0x138
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<double3> velocityPosArray; // 0x148
			[ReadOnly]
			public NativeArray<float> frictionArray; // 0x158
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<double3> stepBasicPositionArray; // 0x168
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> stepBasicRotationArray; // 0x178
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x188
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183BB8790-0x0000000183BB8810
			[IDTag(1)]
			public void Execute(); // 0x0000000186775A4C-0x0000000186775AE4
			[IDTag(0)]
			public void Execute(int index); // 0x0000000186774BE8-0x0000000186775A4C
			private void Spring([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, float scaleRatio); // 0x0000000186775AE4-0x0000000186776080
			private void Wind(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, ref float3 result); // 0x0000000186776704-0x0000000186776B64
			private void WindForceBlend([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // 0x0000000186776394-0x0000000186776704
			public void UnsafeDo(); // 0x0000000186776080-0x0000000186776394
		}
	
		[BurstCompile]
		private struct UpdateStepBasicPotureJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48423
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> stepBaseLineIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x20
			[ReadOnly]
			public NativeArray<int> vertexParentIndices; // 0x30
			[ReadOnly]
			public NativeArray<float3> vertexLocalPositions; // 0x40
			[ReadOnly]
			public NativeArray<quaternion> vertexLocalRotations; // 0x50
			[ReadOnly]
			public NativeArray<ushort> baseLineStartDataIndices; // 0x60
			[ReadOnly]
			public NativeArray<ushort> baseLineDataCounts; // 0x70
			[ReadOnly]
			public NativeArray<ushort> baseLineData; // 0x80
			[ReadOnly]
			public NativeArray<double3> basePosArray; // 0x90
			[ReadOnly]
			public NativeArray<quaternion> baseRotArray; // 0xA0
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> stepBasicPositionArray; // 0xB0
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> stepBasicRotationArray; // 0xC0
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xD0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183BB5120-0x0000000183BB51A0
			[IDTag(1)]
			public void Execute(); // 0x0000000186779004-0x000000018677909C
			[IDTag(0)]
			public void Execute(int index); // 0x000000018677909C-0x00000001867799D0
			public void UnsafeDo(); // 0x00000001867799D0-0x0000000186779B84
		}
	
		[BurstCompile]
		private struct EndSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48424
		{
			// Fields
			public float simulationDeltaTime; // 0x00
			[ReadOnly]
			public NativeArray<int> stepParticleIndexArray; // 0x08
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x18
			[ReadOnly]
			public NativeArray<ClothParameters> parameterArray; // 0x28
			[ReadOnly]
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x38
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x48
			[ReadOnly]
			public NativeArray<float> vertexDepths; // 0x58
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x68
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x78
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> oldPosArray; // 0x88
			[ReadOnly]
			public NativeArray<double3> velocityPosArray; // 0x98
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> velocityArray; // 0xA8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> realVelocityArray; // 0xB8
			[NativeDisableParallelForRestriction]
			public NativeArray<float> frictionArray; // 0xC8
			[NativeDisableParallelForRestriction]
			public NativeArray<float> staticFrictionArray; // 0xD8
			[ReadOnly]
			public NativeArray<float3> collisionNormalArray; // 0xE8
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0xF8
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000183BBB010-0x0000000183BBB090
			[IDTag(1)]
			public void Execute(); // 0x000000018676F784-0x000000018676F81C
			[IDTag(0)]
			public void Execute(int index); // 0x000000018676E964-0x000000018676F784
			public void UnsafeDo(); // 0x000000018676F81C-0x000000018676FA38
		}
	
		[BurstCompile]
		private struct CalcDisplayPositionJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 48425
		{
			// Fields
			public float simulationDeltaTime; // 0x00
			[ReadOnly]
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			[ReadOnly]
			public NativeArray<short> teamIdArray; // 0x18
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0x28
			[WriteOnly]
			public NativeArray<double3> oldPositionArray; // 0x38
			public NativeArray<double3> dispPosArray; // 0x48
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> positions; // 0x58
			[ReadOnly]
			public NativeArray<float3> realVelocityArray; // 0x68
			[WriteOnly]
			public NativeArray<quaternion> oldRotationArray; // 0x78
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x88
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> rotations; // 0x98
			[ReadOnly]
			public NativeArray<int> vertexRootIndices; // 0xA8
			[ReadOnly]
			public int _indexCount; // 0xB8
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000183D687B0-0x0000000183D687F0
			[IDTag(1)]
			public void Execute(); // 0x000000018676ADBC-0x000000018676AE34
			[IDTag(0)]
			public void Execute(int pindex); // 0x000000018676AE34-0x000000018676B3C4
			public void UnsafeDo(); // 0x000000018676B3C4-0x000000018676B534
		}
	
		[BurstCompile]
		private struct FeedbackTempPosJob : IJobParallelForDefer // TypeDefIndex: 48426
		{
			// Fields
			[ReadOnly]
			public NativeList<int> jobParticleIndexList; // 0x00
			[ReadOnly]
			public NativeArray<double3> tempFloat3Buffer; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x20
	
			// Methods
			public void Execute(int index); // 0x0000000186770724-0x00000001867707D0
		}
	
		[BurstCompile]
		private struct FeedbackTempPosJob2 : IJobParallelForDefer // TypeDefIndex: 48427
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> particleIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<double3> tempFloat3Buffer; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x20
	
			// Methods
			public void Execute(int index); // 0x00000001867706A4-0x0000000186770724
		}
	
		// Constructors
		public SimulationManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Dispose(); // 0x0000000183E8A820-0x0000000183E8ACE0
		public void EnterdEditMode(); // 0x0000000186760408-0x0000000186760458
		public void Initialize(); // 0x0000000183E89B90-0x0000000183E8A820
		public bool IsValid(); // 0x000000018676128C-0x00000001867612DC
		internal void RegisterProxyMesh(ClothProcess cprocess); // 0x0000000183CF8EF0-0x0000000183CF91B0
		internal void RegisterConstraint(ClothProcess cprocess); // 0x0000000183E8C3B0-0x0000000183E8C600
		internal void ExitProxyMesh(ClothProcess cprocess); // 0x0000000183CF48A0-0x0000000183CF4BD0
		internal void WorkBufferUpdate(); // 0x0000000182F8BCA0-0x0000000182F8C3C0
		internal JobHandle PreSimulationUpdate(JobHandle jobHandle); // 0x0000000182F8AD10-0x0000000182F8B100
		internal JobHandle SimulationStepUpdate(int updateCount, int updateIndex, JobHandle jobHandle); // 0x0000000182F8F430-0x0000000182F90B80
		internal JobHandle CalcDisplayPosition(JobHandle jobHandle); // 0x0000000182F8A9F0-0x0000000182F8AD10
		[IDTag(0)]
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in NativeList<int> particleList, JobHandle jobHandle); // 0x0000000186760458-0x0000000186760598
		[IDTag(2)]
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in ExProcessingList<int> processingList, JobHandle jobHandle); // 0x00000001867606E8-0x00000001867607B4
		[IDTag(1)]
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in NativeArray<int> particleArray, [IsReadOnly] in NativeReference<int> counter, JobHandle jobHandle); // 0x0000000186760598-0x00000001867606E8
		public void InformationLog(StringBuilder allsb); // 0x00000001867607B4-0x000000018676128C
		public static void Initialize_StartSimulationStepJobKernels_StartSimulationStepKernel_00000407_BurstDirectCall(); // 0x00000001844F72F0-0x00000001844F7350
		public static void Initialize_StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000408_BurstDirectCall(); // 0x00000001844F7350-0x00000001844F73B0
		public static void Initialize_StartSimulationStepJobKernels_Spring_00000409_BurstDirectCall(); // 0x00000001844F73B0-0x00000001844F7410
		public static void Initialize_StartSimulationStepJobKernels_Wind_0000040A_BurstDirectCall(); // 0x00000001844F7410-0x00000001844F7470
		public static void Initialize_StartSimulationStepJobKernels_WindForceBlend_0000040B_BurstDirectCall(); // 0x00000001844F7470-0x00000001844F74D0
		public static void Initialize_UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040C_BurstDirectCall(); // 0x00000001844F74D0-0x00000001844F7530
		public static void Initialize_UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040D_BurstDirectCall(); // 0x00000001844F7530-0x00000001844F7590
		public static void Initialize_EndSimulationStepJobKernels_EndSimulationStepKernel_0000040E_BurstDirectCall(); // 0x00000001844F7590-0x00000001844F75F0
		public static void Initialize_EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040F_BurstDirectCall(); // 0x00000001844F75F0-0x00000001844F7650
		public static void Initialize_CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_00000410_BurstDirectCall(); // 0x00000001844F7650-0x00000001844F76B0
		public static void Initialize_CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_00000411_BurstDirectCall(); // 0x00000001844F76B0-0x00000001844F7710
		public static void Initialize_ClearStepCounterKernels_ClearStepCounterKernel_00000412_BurstDirectCall(); // 0x00000001844F7710-0x00000001844F7770
	}

	public class TimeManager : IManager, IValid // TypeDefIndex: 48430
	{
		// Fields
		internal int simulationFrequency; // 0x10
		internal int maxSimulationCountPerFrame; // 0x14
		internal UpdateLocation updateLocation; // 0x18
		private bool isValid; // 0x1C
		[CompilerGenerated]
		private int _FixedUpdateCount_k__BackingField; // 0x20
		internal float GlobalTimeScale; // 0x24
		[CompilerGenerated]
		private float _SimulationDeltaTime_k__BackingField; // 0x28
		[CompilerGenerated]
		private float _MaxDeltaTime_k__BackingField; // 0x2C
		[CompilerGenerated]
		private float4 _SimulationPower_k__BackingField; // 0x30
		[CompilerGenerated]
		private static float _DeltaTime_k__BackingField; // 0x00
		[CompilerGenerated]
		private static float _FixedDeltaTime_k__BackingField; // 0x04
		[CompilerGenerated]
		private static float _UnscaledDeltaTime_k__BackingField; // 0x08
		[CompilerGenerated]
		private static bool _EnableAOVMode_k__BackingField; // 0x0C
	
		// Properties
		internal int FixedUpdateCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B70F90-0x0000000182B70FA0 0x0000000184D86330-0x0000000184D86340
		internal float SimulationDeltaTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
		internal float MaxDeltaTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86AF0-0x0000000184D86B00 0x0000000184D86B00-0x0000000184D86B10
		internal float4 SimulationPower { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D87480-0x0000000184D87490 0x0000000184D87490-0x0000000184D874A0
		internal static float DeltaTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000186778350-0x0000000186778388 0x0000000186778430-0x0000000186778474
		internal static float FixedDeltaTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001867783C0-0x00000001867783F8 0x00000001867784B0-0x00000001867784F8
		internal static float UnscaledDeltaTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001867783F8-0x0000000186778430 0x00000001867784F8-0x0000000186778540
		internal static bool EnableAOVMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000186778388-0x00000001867783C0 0x0000000186778474-0x00000001867784B0
	
		// Nested types
		public enum UpdateLocation // TypeDefIndex: 48429
		{
			AfterLateUpdate = 0,
			BeforeLateUpdate = 1
		}
	
		// Constructors
		public TimeManager(); // 0x0000000184D87460-0x0000000184D87480
	
		// Methods
		public void Dispose(); // 0x0000000186777DC8-0x0000000186777FF8
		public void EnterdEditMode(); // 0x0000000186777FF8-0x0000000186778048
		public void Initialize(); // 0x00000001835BA850-0x00000001835BAA80
		public bool IsValid(); // 0x0000000186778304-0x0000000186778350
		private void AfterFixedUpdate(); // 0x0000000183E4A330-0x0000000183E4A3A0
		private void AfterRenderring(); // 0x0000000183234180-0x00000001832341F0
		public static float GetDeltaTime(); // 0x0000000183231FA0-0x0000000183232020
		public static float GetFixedDeltaTime(); // 0x0000000183232020-0x0000000183232060
		public static float GetUnscaledDeltaTime(); // 0x0000000183231F60-0x0000000183231FA0
		internal void FrameUpdate(); // 0x00000001834460C0-0x0000000183446280
		public void InformationLog(StringBuilder allsb); // 0x0000000186778048-0x0000000186778304
	}

	public class WindManager : IManager, IValid // TypeDefIndex: 48432
	{
		// Fields
		public const int Flag_Valid = 0; // Metadata: 0x0232D05C
		public const int Flag_Enable = 1; // Metadata: 0x0232D05D
		public const int Flag_Addition = 2; // Metadata: 0x0232D05E
		public ExNativeArray<WindData> windDataArray; // 0x10
		private bool isValid; // 0x18
		private Dictionary<int, BeyondBoneWindZone> windZoneDict; // 0x20
	
		// Properties
		public int WindCount { get; } // 0x00000001835BC760-0x00000001835BC7A0 
	
		// Nested types
		public struct WindData // TypeDefIndex: 48431
		{
			// Fields
			public BitField32 flag; // 0x00
			public BeyondBoneWindZone.Mode mode; // 0x04
			public float3 size; // 0x08
			public float main; // 0x14
			public float turbulence; // 0x18
			public float zoneVolume; // 0x1C
			public float3 worldWindDirection; // 0x20
			public float3 worldPositin; // 0x2C
			public quaternion worldRotation; // 0x38
			public float3 worldScale; // 0x48
			public float4x4 worldToLocalMatrix; // 0x54
			public float4x4 attenuation; // 0x94
	
			// Methods
			public bool IsValid(); // 0x000000018677A360-0x000000018677A3B0
			public bool IsEnable(); // 0x000000018677A310-0x000000018677A360
			public bool IsAddition(); // 0x000000018677A2C0-0x000000018677A310
		}
	
		// Constructors
		public WindManager(); // 0x00000001835B9490-0x00000001835B9510
	
		// Methods
		public void Dispose(); // 0x00000001835B9640-0x00000001835B9690
		public void EnterdEditMode(); // 0x000000018677A948-0x000000018677A998
		public void Initialize(); // 0x00000001835B9590-0x00000001835B9640
		public bool IsValid(); // 0x000000018677ACEC-0x000000018677AD38
		public int AddWind(BeyondBoneWindZone windZone); // 0x000000018677A7A8-0x000000018677A948
		public void RemoveWind(int windId); // 0x000000018677AD38-0x000000018677AEBC
		public void SetEnable(int windId, bool sw); // 0x000000018677AEBC-0x000000018677B0A4
		internal void AlwaysWindUpdate(); // 0x0000000183DF49B0-0x0000000183DF4FB0
		public void InformationLog(StringBuilder allsb); // 0x000000018677A998-0x000000018677ACEC
	}

	[Serializable]
	public class BeyondBoneClothSavePoint // TypeDefIndex: 48433
	{
		// Fields
		public BeyondBoneClothSavePoint_TeamManagerTeamData teamManagerTeamData; // 0x10
		public BeyondBoneClothSavePoint_ColliderManagerData colliderManagerData; // 0x18
		public BeyondBoneClothSavePoint_SimulationManagerData simulationManagerData; // 0x20
		public BeyondBoneClothSavePoint_VirtualMeshManagerData virtualMeshManagerData; // 0x28
		public BeyondBoneClothSavePoint_InertiaConstraintCenterData inertiaConstraintCenterData; // 0x30
	
		// Constructors
		public BeyondBoneClothSavePoint(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Load(ClothProcess cprocess, ColliderManager colliderManager, SimulationManager simulationManager, VirtualMeshManager virtualMeshManager, TeamManager teamManager); // 0x0000000186769150-0x0000000186769378
		public void LoadTeamManagerTeamData(ref TeamManager.TeamData teamData); // 0x0000000186768F9C-0x0000000186769018
		public void LoadColliderManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, ColliderManager colliderManager); // 0x0000000186768764-0x0000000186768980
		public void LoadSimulationManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, SimulationManager simulationManager); // 0x0000000186768C54-0x0000000186768F9C
		public void LoadVirtualMeshManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, VirtualMeshManager virtualMeshManager); // 0x0000000186769018-0x0000000186769150
		public void LoadInertiaConstraintCenterData(ClothProcess cprocess, TeamManager teamManager); // 0x0000000186768980-0x0000000186768C54
		public void Save(ClothProcess cprocess, ColliderManager colliderManager, SimulationManager simulationManager, VirtualMeshManager virtualMeshManager, TeamManager teamManager); // 0x000000018676A540-0x000000018676A670
		public void SaveTeamManagerTeamData(ref TeamManager.TeamData teamData); // 0x000000018676A248-0x000000018676A304
		public void SaveColliderManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, ColliderManager colliderManager); // 0x0000000186769378-0x0000000186769798
		public void SaveSimulationManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, SimulationManager simulationManager); // 0x0000000186769B80-0x000000018676A248
		public void SaveVirtualMeshManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, VirtualMeshManager virtualMeshManager); // 0x000000018676A304-0x000000018676A540
		public void SaveInertiaConstraintCenterData(ClothProcess cprocess, TeamManager teamManager); // 0x0000000186769798-0x0000000186769B80
	}

	internal static class BeyondBoneClothSavePointHelper // TypeDefIndex: 48434
	{
		// Extension methods
		internal static void AddFromNative<T>(this List<T> targetList, NativeArray<T> sourceArray, int sourceStartIndex, int length)
			where T : struct;
		internal static void FillFromList<T>(this NativeArray<T> targetArray, int targetStartIndex, List<T> sourceList, int sourceStartIndex, int length)
			where T : struct;
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_TeamManagerTeamData // TypeDefIndex: 48435
	{
		// Fields
		public float velocityWeight; // 0x10
		public float blendWeight; // 0x14
	
		// Constructors
		public BeyondBoneClothSavePoint_TeamManagerTeamData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_ColliderManagerData // TypeDefIndex: 48436
	{
		// Fields
		public int colliderLength; // 0x10
		public List<double3> oldFramePositions; // 0x18
		public List<quaternion> oldFrameRotations; // 0x20
		public List<double3> nowPositions; // 0x28
		public List<quaternion> nowRotations; // 0x30
		public List<double3> oldPositions; // 0x38
		public List<quaternion> oldRotations; // 0x40
	
		// Constructors
		public BeyondBoneClothSavePoint_ColliderManagerData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_SimulationManagerData // TypeDefIndex: 48437
	{
		// Fields
		public int proxyMeshVertexCount; // 0x10
		public List<double3> nextPosArray; // 0x18
		public List<double3> oldPosArray; // 0x20
		public List<quaternion> oldRotArray; // 0x28
		public List<double3> basePosArray; // 0x30
		public List<quaternion> baseRotArray; // 0x38
		public List<double3> oldPositionArray; // 0x40
		public List<quaternion> oldRotationArray; // 0x48
		public List<double3> velocityPosArray; // 0x50
		public List<double3> dispPosArray; // 0x58
		public List<float3> velocityArray; // 0x60
		public List<float3> realVelocityArray; // 0x68
		public List<float> frictionArray; // 0x70
		public List<float> staticFrictionArray; // 0x78
		public List<float3> collisionNormalArray; // 0x80
	
		// Constructors
		public BeyondBoneClothSavePoint_SimulationManagerData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_VirtualMeshManagerData // TypeDefIndex: 48438
	{
		// Fields
		public int proxyMeshVertexCount; // 0x10
		public List<double3> positions; // 0x18
		public List<quaternion> rotations; // 0x20
	
		// Constructors
		public BeyondBoneClothSavePoint_VirtualMeshManagerData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_InertiaConstraintCenterData // TypeDefIndex: 48439
	{
		// Fields
		public float3 anchorComponentLocalPosition; // 0x10
		public double3 oldAnchorPosition; // 0x20
		public quaternion oldAnchorRotation; // 0x38
		public double3 oldComponentWorldPosition; // 0x48
		public quaternion oldComponentWorldRotation; // 0x60
		public float3 oldComponentWorldScale; // 0x70
		public quaternion oldFrameWorldRotation; // 0x7C
		public float3 oldFrameWorldScale; // 0x8C
		public double3 oldFrameWorldPosition; // 0x98
		public double3 nowWorldPosition; // 0xB0
		public quaternion nowWorldRotation; // 0xC8
		public double3 oldWorldPosition; // 0xD8
		public quaternion oldWorldRotation; // 0xF0
		public float3 frameComponentShiftVector; // 0x100
		public quaternion frameComponentShiftRotation; // 0x10C
		public float3 smoothingVelocity; // 0x11C
	
		// Constructors
		public BeyondBoneClothSavePoint_InertiaConstraintCenterData(); // 0x00000001841E1670-0x00000001841E1680
	}

	public struct TeamWindInfo : IValid // TypeDefIndex: 48440
	{
		// Fields
		public int windId; // 0x00
		public float time; // 0x04
		public float main; // 0x08
		public float3 direction; // 0x0C
	
		// Methods
		public bool IsValid(); // 0x0000000186786478-0x00000001867864D0
		public override string ToString(); // 0x00000001867864D0-0x0000000186786690
		public void DebugLog(); // 0x00000001867863F0-0x0000000186786478
		public string __iFixBaseProxy_ToString(); // 0x0000000186786690-0x00000001867866E8
	}

	public struct TeamWindData // TypeDefIndex: 48441
	{
		// Fields
		public FixedList128Bytes<TeamWindInfo> windZoneList; // 0x00
		public TeamWindInfo movingWind; // 0x80
	
		// Properties
		public int ZoneCount { get; } // 0x0000000186786388-0x00000001867863F0 
	
		// Methods
		public int IndexOf(int windId); // 0x0000000186786230-0x00000001867862F4
		public void ClearZoneList(); // 0x00000001867861BC-0x0000000186786230
		public void AddOrReplaceWindZone(TeamWindInfo windInfo, [IsReadOnly] in TeamWindData oldWindData); // 0x0000000186785FD0-0x00000001867861BC
		public void RemoveWindZone(int windId); // 0x00000001867862F4-0x0000000186786388
	}

	public class TransformData : IDisposable // TypeDefIndex: 48446
	{
		// Fields
		internal List<Transform> transformList; // 0x10
		internal ExSimpleNativeArray<ExBitFlag8> flagArray; // 0x18
		internal ExSimpleNativeArray<float3> initLocalPositionArray; // 0x20
		internal ExSimpleNativeArray<quaternion> initLocalRotationArray; // 0x28
		internal ExSimpleNativeArray<float3> positionArray; // 0x30
		internal ExSimpleNativeArray<quaternion> rotationArray; // 0x38
		internal ExSimpleNativeArray<quaternion> inverseRotationArray; // 0x40
		internal ExSimpleNativeArray<float3> scaleArray; // 0x48
		internal ExSimpleNativeArray<float3> localPositionArray; // 0x50
		internal ExSimpleNativeArray<quaternion> localRotationArray; // 0x58
		internal ExSimpleNativeArray<int> idArray; // 0x60
		internal ExSimpleNativeArray<int> parentIdArray; // 0x68
		internal List<int> rootIdList; // 0x70
		private bool isDirty; // 0x78
		internal TransformAccessArray transformAccessArray; // 0x80
		private Queue<int> emptyStack; // 0x88
	
		// Properties
		public int Count { get; } // 0x0000000183CF7800-0x0000000183CF7860 
		public int RootCount { get; } // 0x000000018468C240-0x000000018468C290 
		public bool IsDirty { get; } // 0x000000018678A438-0x000000018678A484 
		public bool IsEmpty { get; } // 0x000000018678A484-0x000000018678A4D8 
	
		// Nested types
		[BurstCompile]
		private struct RestoreTransformJob : IJobParallelForTransform // TypeDefIndex: 48442
		{
			// Fields
			public int count; // 0x00
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagList; // 0x08
			[ReadOnly]
			public NativeArray<float3> localPositionArray; // 0x18
			[ReadOnly]
			public NativeArray<quaternion> localRotationArray; // 0x28
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x0000000186782348-0x0000000186782460
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 48443
		{
			// Fields
			[ReadOnly]
			public NativeArray<ExBitFlag8> flagList; // 0x00
			[WriteOnly]
			public NativeArray<float3> positionArray; // 0x10
			[WriteOnly]
			public NativeArray<quaternion> rotationArray; // 0x20
			[WriteOnly]
			public NativeArray<float3> scaleList; // 0x30
			[WriteOnly]
			public NativeArray<float3> localPositionArray; // 0x40
			[WriteOnly]
			public NativeArray<quaternion> localRotationArray; // 0x50
			[WriteOnly]
			public NativeArray<quaternion> inverseRotationArray; // 0x60
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x0000000186781830-0x0000000186781BBC
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 48444
		{
			// Fields
			public ExSimpleNativeArray<ExBitFlag8> flagArray; // 0x10
			public ExSimpleNativeArray<float3> initLocalPositionArray; // 0x18
			public ExSimpleNativeArray<quaternion> initLocalRotationArray; // 0x20
	
			// Constructors
			public ShareSerializationData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 48445
		{
			// Fields
			public Transform[] transformArray; // 0x10
	
			// Constructors
			public UniqueSerializationData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet); // 0x000000018678AD68-0x000000018678AE50
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x000000018678AE50-0x000000018678AFBC
		}
	
		// Constructors
		public TransformData(); // 0x00000001841E1670-0x00000001841E1680
		public TransformData(int capacity); // 0x0000000183E90F50-0x0000000183E90F60
	
		// Methods
		public void Init(int capacity); // 0x0000000183E91F50-0x0000000183E92320
		public void Dispose(); // 0x0000000183E923C0-0x0000000183E92580
		[IDTag(2)]
		public int AddTransform(Transform t, int tid = 0 /* Metadata: 0x0232D05F */, int pid = 0 /* Metadata: 0x0232D060 */, byte flag = 1 /* Metadata: 0x0232D061 */, bool checkDuplicate = true /* Metadata: 0x0232D062 */); // 0x0000000186787234-0x0000000186787D5C
		[IDTag(0)]
		public int AddTransform(TransformRecord record, int pid = 0 /* Metadata: 0x0232D063 */, byte flag = 1 /* Metadata: 0x0232D064 */, bool checkDuplicate = true /* Metadata: 0x0232D065 */); // 0x0000000186786B64-0x0000000186787234
		[IDTag(1)]
		public int AddTransform(TransformData srcData, int srcIndex, bool checkDuplicate = true /* Metadata: 0x0232D066 */); // 0x0000000186787D5C-0x00000001867883A8
		[IDTag(1)]
		public int[] AddTransformRange(List<Transform> tlist, List<int> idList, List<int> pidList, int copyCount = 0 /* Metadata: 0x0232D067 */); // 0x0000000186786844-0x0000000186786B64
		[IDTag(2)]
		public int[] AddTransformRange(TransformData stdata, int copyCount = 0 /* Metadata: 0x0232D068 */); // 0x00000001867866E8-0x0000000186786844
		[IDTag(0)]
		public int[] AddTransformRange(List<Transform> tlist, List<int> idList, List<int> pidList, List<int> rootIds, NativeArray<float3> localPositions, NativeArray<quaternion> localRotations, NativeArray<float3> positions, NativeArray<quaternion> rotations, NativeArray<float3> scales, NativeArray<quaternion> inverseRotations); // 0x0000000183CF7430-0x0000000183CF7800
		public void RemoveTransformIndex(int index); // 0x0000000186789734-0x0000000186789804
		public int ReplaceTransform(int index, Transform t, int tid = 0 /* Metadata: 0x0232D069 */, int pid = 0 /* Metadata: 0x0232D06A */, byte flag = 1 /* Metadata: 0x0232D06B */); // 0x0000000186789804-0x0000000186789D0C
		private int ReferenceIndexOf<T>(List<T> list, T item)
			where T : class;
		public void UpdateWorkData(); // 0x000000018678A370-0x000000018678A438
		public JobHandle RestoreTransform(int count, JobHandle jobHandle = default); // 0x0000000186789D0C-0x0000000186789E9C
		public JobHandle ReadTransform(JobHandle jobHandle = default); // 0x0000000186789570-0x0000000186789734
		public void ReadTransformRun(); // 0x0000000186789414-0x0000000186789570
		public void OrganizeReductionTransform(VirtualMesh vmesh, ReductionWorkData workData); // 0x0000000186788828-0x0000000186789414
		public Transform GetTransformFromIndex(int index); // 0x0000000183CF8BD0-0x0000000183CF8C20
		public int GetTransformIndexFormId(int id); // 0x000000018678868C-0x000000018678874C
		public int GetTransformIdFromIndex(int index); // 0x0000000186788608-0x000000018678868C
		public int GetParentIdFromIndex(int index); // 0x0000000186788584-0x0000000186788608
		public float4x4 GetLocalToWorldMatrix(int index); // 0x00000001867883A8-0x0000000186788584
		public float4x4 GetWorldToLocalMatrix(int index); // 0x000000018678874C-0x0000000186788828
		public override string ToString(); // 0x000000018678A050-0x000000018678A228
		public ShareSerializationData ShareSerialize(); // 0x0000000186789E9C-0x000000018678A050
		public static TransformData ShareDeserialize(ShareSerializationData sdata); // 0x0000000183E8FA80-0x0000000183E8FC20
		public UniqueSerializationData UniqueSerialize(); // 0x000000018678A228-0x000000018678A370
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public class TransformRecord : IValid, ITransform // TypeDefIndex: 48447
	{
		// Fields
		public Transform transform; // 0x10
		public int id; // 0x18
		public Vector3 localPosition; // 0x1C
		public Quaternion localRotation; // 0x28
		public Vector3 position; // 0x38
		public Quaternion rotation; // 0x44
		public Vector3 scale; // 0x54
		public Matrix4x4 localToWorldMatrix; // 0x60
		public Matrix4x4 worldToLocalMatrix; // 0xA0
		public int pid; // 0xE0
	
		// Constructors
		public TransformRecord(Transform t); // 0x000000018308CD70-0x000000018308CF70
	
		// Methods
		public Vector3 InverseTransformDirection(Vector3 dir); // 0x000000018678A6A4-0x000000018678A780
		public bool IsValid(); // 0x000000018678A780-0x000000018678A7D0
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x000000018678A618-0x000000018678A6A4
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x000000018678A7D0-0x000000018678A8E8
	}

	[CreateAssetMenu(fileName = "Data", menuName = "MagicaCloth2/PreBuildScriptableObject")]
	public class PreBuildScriptableObject : ScriptableObject // TypeDefIndex: 48450
	{
		// Fields
		public List<SharePreBuildData> sharePreBuildDataList; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 48448
		{
			// Fields
			public SharePreBuildData sdata; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddPreBuildData_b__0(SharePreBuildData x); // 0x000000018678A944-0x000000018678A974
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 48449
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<SharePreBuildData> __9__4_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018678A9D4-0x000000018678AA38
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Warmup_b__4_0(SharePreBuildData sdata); // 0x000000018678A8E8-0x000000018678A944
		}
	
		// Constructors
		public PreBuildScriptableObject(); // 0x000000018678165C-0x00000001867816DC
	
		// Methods
		public bool HasPreBuildData(string buildId); // 0x000000018678149C-0x0000000186781508
		public SharePreBuildData GetPreBuildData(string buildId); // 0x0000000186781328-0x000000018678149C
		public void AddPreBuildData(SharePreBuildData sdata); // 0x00000001867811C4-0x0000000186781328
		public void Warmup(); // 0x0000000186781508-0x000000018678165C
	}

	[Serializable]
	public class PreBuildSerializeData : ITransform // TypeDefIndex: 48451
	{
		// Fields
		public bool enabled; // 0x10
		public SharePreBuildData preBuildData; // 0x18
		public UniquePreBuildData uniquePreBuildData; // 0x20
	
		// Constructors
		public PreBuildSerializeData(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public bool UsePreBuild(); // 0x0000000184790940-0x0000000184790970
		public ResultCode DataValidate(); // 0x0000000183E8E950-0x0000000183E8EA40
		public SharePreBuildData GetSharePreBuildData(); // 0x0000000183E8EA40-0x0000000183E8EA70
		public static string GenerateBuildID(); // 0x00000001867816DC-0x0000000186781758
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000186781758-0x00000001867817C4
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x00000001867817C4-0x0000000186781830
	}

	[Serializable]
	public class SharePreBuildData // TypeDefIndex: 48452
	{
		// Fields
		public int version; // 0x10
		public string buildId; // 0x18
		public ResultCode buildResult; // 0x20
		public Vector3 buildScale; // 0x28
		public List<RenderSetupData.ShareSerializationData> renderSetupDataList; // 0x38
		public VirtualMesh.ShareSerializationData proxyMesh; // 0x40
		public List<VirtualMesh.ShareSerializationData> renderMeshList; // 0x48
		public DistanceConstraint.ConstraintData distanceConstraintData; // 0x50
		public TriangleBendingConstraint.ConstraintData bendingConstraintData; // 0x58
		public InertiaConstraint.ConstraintData inertiaConstraintData; // 0x60
	
		// Constructors
		public SharePreBuildData(); // 0x000000018445C180-0x000000018445C250
	
		// Methods
		public ResultCode DataValidate(); // 0x0000000183E8ED60-0x0000000183E8EDC0
		public bool CheckBuildId(string buildId); // 0x000000018678401C-0x0000000186784090
		public override string ToString(); // 0x0000000186784090-0x0000000186784340
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	[Serializable]
	public class UniquePreBuildData : ITransform // TypeDefIndex: 48455
	{
		// Fields
		public int version; // 0x10
		public ResultCode buildResult; // 0x14
		public List<RenderSetupData.UniqueSerializationData> renderSetupDataList; // 0x20
		public VirtualMesh.UniqueSerializationData proxyMesh; // 0x28
		public List<VirtualMesh.UniqueSerializationData> renderMeshList; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 48453
		{
			// Fields
			public HashSet<Transform> transformSet; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _GetUsedTransform_b__0(RenderSetupData.UniqueSerializationData x); // 0x000000018678A974-0x000000018678A98C
			internal void _GetUsedTransform_b__1(VirtualMesh.UniqueSerializationData x); // 0x000000018678A98C-0x000000018678A9A4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 48454
		{
			// Fields
			public Dictionary<int, Transform> replaceDict; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _ReplaceTransform_b__0(RenderSetupData.UniqueSerializationData x); // 0x000000018678A9A4-0x000000018678A9BC
			internal void _ReplaceTransform_b__1(VirtualMesh.UniqueSerializationData x); // 0x000000018678A9BC-0x000000018678A9D4
		}
	
		// Constructors
		public UniquePreBuildData(); // 0x000000018445C0B0-0x000000018445C180
	
		// Methods
		public ResultCode DataValidate(); // 0x0000000183E8ED10-0x0000000183E8ED60
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x000000018678AA38-0x000000018678ABD0
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x000000018678ABD0-0x000000018678AD68
	}

	[Serializable]
	public class ReductionSettings : IDataValidate // TypeDefIndex: 48456
	{
		// Fields
		[Range(0f, 0.2f)]
		public float simpleDistance; // 0x10
		[Range(0f, 0.2f)]
		public float shapeDistance; // 0x14
	
		// Properties
		public bool IsEnabled { get; } // 0x0000000186781F68-0x0000000186781FB4 
	
		// Constructors
		public ReductionSettings(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public float GetMaxConnectionDistance(); // 0x0000000186781D38-0x0000000186781DBC
		public ReductionSettings Clone(); // 0x0000000186781BBC-0x0000000186781C48
		public void DataValidate(); // 0x0000000186781C48-0x0000000186781CD0
		public override int GetHashCode(); // 0x0000000186781CD0-0x0000000186781D38
		public override string ToString(); // 0x0000000186781DBC-0x0000000186781F68
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public class ReductionWorkData : IDisposable // TypeDefIndex: 48457
	{
		// Fields
		public VirtualMesh vmesh; // 0x10
		public NativeArray<int> vertexJoinIndices; // 0x18
		public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x28
		public NativeArray<int> vertexRemapIndices; // 0x38
		public NativeParallelHashMap<int, int> useSkinBoneMap; // 0x48
		public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x58
		public NativeParallelHashSet<int2> edgeSet; // 0x68
		public NativeParallelHashSet<int3> triangleSet; // 0x78
		public int oldVertexCount; // 0x88
		public int newVertexCount; // 0x8C
		public int removeVertexCount; // 0x90
		public ExSimpleNativeArray<VertexAttribute> newAttributes; // 0x98
		public ExSimpleNativeArray<float3> newLocalPositions; // 0xA0
		public ExSimpleNativeArray<float3> newLocalNormals; // 0xA8
		public ExSimpleNativeArray<float3> newLocalTangents; // 0xB0
		public ExSimpleNativeArray<float2> newUv; // 0xB8
		public ExSimpleNativeArray<VirtualMeshBoneWeight> newBoneWeights; // 0xC0
		public NativeReference<int> newSkinBoneCount; // 0xC8
		public NativeList<int> newSkinBoneTransformIndices; // 0xD8
		public NativeList<float4x4> newSkinBoneBindPoseList; // 0xE8
		public NativeList<int2> newLineList; // 0xF8
		public NativeList<int3> newTriangleList; // 0x108
	
		// Constructors
		public ReductionWorkData(VirtualMesh vmesh); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public void Dispose(); // 0x0000000186781FB4-0x0000000186782348
	}

	public class SameDistanceReduction : IDisposable // TypeDefIndex: 48464
	{
		// Fields
		private string name; // 0x10
		private VirtualMesh vmesh; // 0x18
		private ReductionWorkData workData; // 0x20
		private ResultCode result; // 0x28
		private float mergeLength; // 0x30
		private GridMap<int> gridMap; // 0x38
		private NativeParallelMultiHashMap<ushort, ushort> joinPairMap; // 0x40
		private NativeReference<int> resultRef; // 0x50
	
		// Properties
		public ResultCode Result { get; } // 0x0000000186782F54-0x0000000186782FA4 
	
		// Nested types
		[BurstCompile]
		private struct InitGridJob : IJob // TypeDefIndex: 48458
		{
			// Fields
			public int vcnt; // 0x00
			public float gridSize; // 0x04
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x08
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x18
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x28
	
			// Methods
			public void Execute(); // 0x000000018677FB48-0x000000018677FC30
		}
	
		[BurstCompile]
		private struct SearchJoinJob : IJob // TypeDefIndex: 48459
		{
			// Fields
			public int vcnt; // 0x00
			public float gridSize; // 0x04
			public float radius; // 0x08
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x10
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x20
			[ReadOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x30
			public NativeParallelMultiHashMap<ushort, ushort> joinPairMap; // 0x40
	
			// Methods
			public void Execute(); // 0x000000018678392C-0x0000000186783D90
		}
	
		[BurstCompile]
		private struct JoinJob2 : IJob // TypeDefIndex: 48460
		{
			// Fields
			public int vertexCount; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<ushort, ushort> joinPairMap; // 0x08
			public NativeArray<int> joinIndices; // 0x18
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x28
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x38
			public NativeArray<VertexAttribute> attributes; // 0x48
			public NativeReference<int> result; // 0x58
			public NativeList<ushort> tempList; // 0x68
	
			// Methods
			public void Execute(); // 0x00000001867804F4-0x0000000186780AF4
		}
	
		[BurstCompile]
		private struct UpdateJoinIndexJob : IJobParallelFor // TypeDefIndex: 48461
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
	
			// Methods
			public void Execute(int vindex); // 0x000000018678B044-0x000000018678B0CC
		}
	
		[BurstCompile]
		private struct UpdateLinkIndexJob : IJobParallelFor // TypeDefIndex: 48462
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x10
	
			// Methods
			public void Execute(int vindex); // 0x000000018678B31C-0x000000018678B6B0
		}
	
		[BurstCompile]
		private struct FinalMergeVertexJob : IJobParallelFor // TypeDefIndex: 48463
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
	
			// Methods
			public void Execute(int vindex); // 0x000000018677FA54-0x000000018677FB48
		}
	
		// Constructors
		public SameDistanceReduction(); // 0x0000000186782E50-0x0000000186782E98
		public SameDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float mergeLength); // 0x0000000186782E98-0x0000000186782F54
	
		// Methods
		public virtual void Dispose(); // 0x0000000186782460-0x0000000186782554
		public ResultCode Reduction(); // 0x0000000186782554-0x0000000186782C28
		private void UpdateJoinAndLink(); // 0x0000000186782C28-0x0000000186782D34
		private void UpdateReductionResultJob(); // 0x0000000186782D34-0x0000000186782E50
	}

	public class ShapeDistanceReduction : StepReductionBase // TypeDefIndex: 48466
	{
		// Nested types
		[BurstCompile]
		private struct SearchJoinEdgeJob : IJob // TypeDefIndex: 48465
		{
			// Fields
			public int vcnt; // 0x00
			public float radius; // 0x04
			public bool dontMakeLine; // 0x08
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x10
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x20
			[ReadOnly]
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x30
			public NativeList<StepReductionBase.JoinEdge> joinEdgeList; // 0x40
	
			// Methods
			public void Execute(); // 0x0000000186782FA4-0x000000018678339C
		}
	
		// Constructors
		public ShapeDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment); // 0x0000000186783F4C-0x000000018678401C
	
		// Methods
		public override void Dispose(); // 0x0000000186783E94-0x0000000186783EE4
		protected override void StepInitialize(); // 0x0000000186783EE4-0x0000000186783F34
		protected override void CustomReductionStep(); // 0x0000000186783D90-0x0000000186783E94
		public void __iFixBaseProxy_Dispose(); // 0x0000000186783F3C-0x0000000186783F44
		public void __iFixBaseProxy_StepInitialize(); // 0x0000000186783F44-0x0000000186783F4C
		public void __iFixBaseProxy_CustomReductionStep(); // 0x0000000186783F34-0x0000000186783F3C
	}

	public class SimpleDistanceReduction : StepReductionBase // TypeDefIndex: 48469
	{
		// Fields
		private GridMap<int> gridMap; // 0x90
	
		// Nested types
		[BurstCompile]
		private struct InitGridJob : IJob // TypeDefIndex: 48467
		{
			// Fields
			public int vcnt; // 0x00
			public float gridSize; // 0x04
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x08
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x18
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x28
	
			// Methods
			public void Execute(); // 0x000000018677FC30-0x000000018677FD18
		}
	
		[BurstCompile]
		private struct SearchJoinEdgeJob : IJob // TypeDefIndex: 48468
		{
			// Fields
			public int vcnt; // 0x00
			public float gridSize; // 0x04
			public float radius; // 0x08
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x10
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x20
			[ReadOnly]
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x30
			[ReadOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x40
			[WriteOnly]
			public NativeList<StepReductionBase.JoinEdge> joinEdgeList; // 0x50
	
			// Methods
			public void Execute(); // 0x000000018678339C-0x000000018678392C
		}
	
		// Constructors
		public SimpleDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment); // 0x00000001867846BC-0x000000018678478C
	
		// Methods
		public override void Dispose(); // 0x0000000186784564-0x00000001867845E8
		protected override void StepInitialize(); // 0x00000001867845E8-0x00000001867846BC
		protected override void CustomReductionStep(); // 0x0000000186784340-0x0000000186784564
		public void __iFixBaseProxy_Dispose(); // 0x0000000186783F3C-0x0000000186783F44
		public void __iFixBaseProxy_StepInitialize(); // 0x0000000186783F44-0x0000000186783F4C
		public void __iFixBaseProxy_CustomReductionStep(); // 0x0000000186783F34-0x0000000186783F3C
	}

	public abstract class StepReductionBase : IDisposable // TypeDefIndex: 48476
	{
		// Fields
		protected string name; // 0x10
		protected VirtualMesh vmesh; // 0x18
		protected ReductionWorkData workData; // 0x20
		protected ResultCode result; // 0x28
		protected float startMergeLength; // 0x30
		protected float endMergeLength; // 0x34
		protected int maxStep; // 0x38
		protected bool dontMakeLine; // 0x3C
		protected float joinPositionAdjustment; // 0x40
		protected int nowStepIndex; // 0x44
		protected float nowMergeLength; // 0x48
		protected float nowStepScale; // 0x4C
		protected NativeList<JoinEdge> joinEdgeList; // 0x50
		private NativeParallelHashSet<int> completeVertexSet; // 0x60
		private NativeList<int2> removePairList; // 0x70
		private NativeArray<int> resultArray; // 0x80
	
		// Properties
		public ResultCode Result { get; } // 0x0000000186785F80-0x0000000186785FD0 
	
		// Nested types
		public struct JoinEdge : IComparable<JoinEdge> // TypeDefIndex: 48470
		{
			// Fields
			public int2 vertexPair; // 0x00
			public float cost; // 0x08
	
			// Methods
			public bool Contains([IsReadOnly] in int2 pair); // 0x000000018678047C-0x00000001867804F4
			public int CompareTo(JoinEdge other); // 0x00000001867803EC-0x000000018678047C
		}
	
		[BurstCompile]
		private struct DeterminJoinEdgeJob : IJob // TypeDefIndex: 48471
		{
			// Fields
			public int stepIndex; // 0x00
			public float mergeLength; // 0x04
			[ReadOnly]
			public NativeList<JoinEdge> joinEdgeList; // 0x08
			public NativeParallelHashSet<int> completeVertexSet; // 0x18
			public NativeList<int2> removePairList; // 0x28
			public NativeArray<int> resultArray; // 0x38
	
			// Methods
			public void Execute(); // 0x000000018677F784-0x000000018677F960
		}
	
		[BurstCompile]
		private struct JoinPairJob : IJob // TypeDefIndex: 48472
		{
			// Fields
			public float joinPositionAdjustment; // 0x00
			[ReadOnly]
			public NativeList<int2> removePairList; // 0x08
			public NativeArray<float3> localPositions; // 0x18
			public NativeArray<float3> localNormals; // 0x28
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x38
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x48
			public NativeArray<VertexAttribute> attributes; // 0x58
			public NativeArray<int> joinIndices; // 0x68
	
			// Methods
			public void Execute(); // 0x0000000186780AF4-0x00000001867811C4
		}
	
		[BurstCompile]
		private struct UpdateJoinIndexJob : IJobParallelFor // TypeDefIndex: 48473
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
	
			// Methods
			public void Execute(int vindex); // 0x000000018678AFBC-0x000000018678B044
		}
	
		[BurstCompile]
		private struct UpdateLinkIndexJob : IJobParallelFor // TypeDefIndex: 48474
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x10
	
			// Methods
			public void Execute(int vindex); // 0x000000018678B0CC-0x000000018678B31C
		}
	
		[BurstCompile]
		private struct FinalMergeVertexJob : IJobParallelFor // TypeDefIndex: 48475
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
	
			// Methods
			public void Execute(int vindex); // 0x000000018677F960-0x000000018677FA54
		}
	
		// Constructors
		public StepReductionBase(); // 0x0000000186785F38-0x0000000186785F80
		public StepReductionBase(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment); // 0x0000000186785E44-0x0000000186785F38
	
		// Methods
		public virtual void Dispose(); // 0x0000000186785280-0x00000001867853A8
		public ResultCode Reduction(); // 0x0000000186785640-0x000000018678586C
		private void InitStep(); // 0x00000001867853A8-0x0000000186785404
		private bool IsEndStep(); // 0x0000000186785404-0x0000000186785468
		private void NextStep(); // 0x0000000186785468-0x00000001867854F4
		private void ReductionStep(); // 0x00000001867855D8-0x0000000186785640
		protected virtual void StepInitialize(); // 0x0000000186785AAC-0x0000000186785C1C
		protected virtual void CustomReductionStep(); // 0x000000018678514C-0x0000000186785190
		private void PreReductionStep(); // 0x0000000186785564-0x00000001867855D8
		private void PostReductionStep(); // 0x00000001867854F4-0x0000000186785564
		private void SortJoinEdge(); // 0x0000000186785A2C-0x0000000186785AAC
		private void DetermineJoinEdge(); // 0x0000000186785190-0x0000000186785280
		private void RunJoinEdge(); // 0x000000018678586C-0x0000000186785A2C
		private void UpdateJoinAndLink(); // 0x0000000186785C1C-0x0000000186785D28
		private void UpdateReductionResultJob(); // 0x0000000186785D28-0x0000000186785E44
		protected static bool CheckJoin2([IsReadOnly] in NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap, int vindex, int tvindex, bool dontMakeLine); // 0x000000018678478C-0x0000000186784C70
		protected static bool CheckJoin([IsReadOnly] in NativeArray<FixedList128Bytes<ushort>> vertexToVertexArray, int vindex, int tvindex, [IsReadOnly] in FixedList128Bytes<ushort> vlist, [IsReadOnly] in FixedList128Bytes<ushort> tvlist, bool dontMakeLine); // 0x0000000186784C70-0x000000018678514C
	}

	[Serializable]
	public class ClothDebugSettings // TypeDefIndex: 48478
	{
		// Fields
		public bool enable; // 0x10
		public bool ztest; // 0x11
		public bool position; // 0x12
		public DebugAxis axis; // 0x14
		public bool shape; // 0x18
		public bool baseLine; // 0x19
		public bool depth; // 0x1A
		public bool collider; // 0x1B
		public bool animatedPosition; // 0x1C
		public DebugAxis animatedAxis; // 0x20
		public bool animatedShape; // 0x24
		public bool inertiaCenter; // 0x25
		public bool customSkinningBone; // 0x26
	
		// Nested types
		public enum DebugAxis // TypeDefIndex: 48477
		{
			None = 0,
			Normal = 1,
			All = 2
		}
	
		// Constructors
		public ClothDebugSettings(); // 0x0000000184D874A0-0x0000000184D874B0
	
		// Methods
		public bool CheckParticleDrawing(int index); // 0x000000018677DD70-0x000000018677DDC8
		public bool CheckTriangleDrawing(int index); // 0x000000018677DE14-0x000000018677DE6C
		public bool CheckRadiusDrawing(); // 0x000000018677DDC8-0x000000018677DE14
		public float GetPointSize(); // 0x000000018677DF68-0x000000018677DFBC
		public float GetLineSize(); // 0x000000018677DF14-0x000000018677DF68
		public float GetInertiaCenterRadius(); // 0x000000018677DEC0-0x000000018677DF14
		public float GetCustomSkinningRadius(); // 0x000000018677DE6C-0x000000018677DEC0
		public bool IsReferOldPos(); // 0x000000018677DFBC-0x000000018677E008
	}

	public class DataUtility // TypeDefIndex: 48479
	{
		// Constructors
		public DataUtility(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static int2 PackInt2(int d0, int d1); // 0x000000018677F4AC-0x000000018677F4C8
		public static int2 PackInt2([IsReadOnly] in int2 d); // 0x000000018677F4A0-0x000000018677F4AC
		[IDTag(0)]
		public static int3 PackInt3(int d0, int d1, int d2); // 0x000000018677F54C-0x000000018677F620
		[IDTag(1)]
		public static int3 PackInt3([IsReadOnly] in int3 d); // 0x000000018677F4C8-0x000000018677F54C
		[IDTag(0)]
		public static int4 PackInt4(int d0, int d1, int d2, int d3); // 0x000000018677F6B0-0x000000018677F784
		[IDTag(1)]
		public static int4 PackInt4(int4 d); // 0x000000018677F620-0x000000018677F6B0
		public static uint Pack32(int hi, int low); // 0x0000000184D874D0-0x0000000184D874E0
		public static uint Pack32Sort(int a, int b); // 0x000000018677F488-0x000000018677F4A0
		public static int Unpack32Hi(uint pack); // 0x0000000184D875B0-0x0000000184D875C0
		public static int Unpack32Low(uint pack); // 0x0000000184D875C0-0x0000000184D875D0
		public static uint Pack12_20(int hi, int low); // 0x0000000184D874C0-0x0000000184D874D0
		public static int Unpack12_20Hi(uint pack); // 0x0000000184D87570-0x0000000184D87580
		public static int Unpack12_20Low(uint pack); // 0x0000000184D87580-0x0000000184D87590
		public static void Unpack12_20(uint pack, out int hi, out int low); // 0x0000000184D87590-0x0000000184D875B0
		public static ulong Pack64(int x, int y, int z, int w); // 0x0000000184D87530-0x0000000184D87560
		public static ulong Pack64([IsReadOnly] in int4 a); // 0x0000000184D874E0-0x0000000184D87510
		public static int4 Unpack64([IsReadOnly] in ulong pack); // 0x0000000184D87620-0x0000000184D87650
		public static int Unpack64X([IsReadOnly] in ulong pack); // 0x0000000184D875F0-0x0000000184D87600
		public static int Unpack64Y([IsReadOnly] in ulong pack); // 0x0000000184D87600-0x0000000184D87610
		public static int Unpack64Z([IsReadOnly] in ulong pack); // 0x0000000184D87610-0x0000000184D87620
		public static int Unpack64W([IsReadOnly] in ulong pack); // 0x0000000184D87110-0x0000000184D87120
		public static uint Pack32(int x, int y, int z, int w); // 0x0000000184D87510-0x0000000184D87530
		public static ulong Pack32([IsReadOnly] in int4 a); // 0x0000000184D874E0-0x0000000184D87510
		public static int4 Unpack32([IsReadOnly] in uint pack); // 0x0000000184D875D0-0x0000000184D875F0
		public static int RemainingData([IsReadOnly] in int3 data, [IsReadOnly] in int2 use); // 0x00000001866A7F38-0x00000001866A7F60
		public static float4x4 ConvertAnimationCurve(AnimationCurve curve); // 0x000000018308B620-0x000000018308B780
		public static float EvaluateCurve([IsReadOnly] in float4x4 curve, float time); // 0x00000001866897FC-0x0000000186689908
		public static ColliderManager.ColliderType GetColliderType([IsReadOnly] in ExBitFlag8 flag); // 0x0000000184D874B0-0x0000000184D874C0
		public static ExBitFlag8 SetColliderType(ExBitFlag8 flag, ColliderManager.ColliderType ctype); // 0x0000000184D87560-0x0000000184D87570
		public static void ArrayCopy<T>(T[] src, ref ref T[] dst);
	}

	public class MultiDataBuilder<T> : IDisposable // TypeDefIndex: 48480
		where T : struct
	{
		// Fields
		private int indexCount;
		public NativeParallelMultiHashMap<int, T> Map;
	
		// Constructors
		public MultiDataBuilder(int indexCount, int dataCapacity);
	
		// Methods
		public void Dispose();
		public int Count();
		public int GetDataCount(int index);
		public void Add(int key, T data);
		public int CountValuesForKey(int key);
		public ValueTuple<T[], uint[]> ToArray();
		public uint[] ToIndexArray();
		public void ToNativeArray(out NativeArray<uint> indexArray, out NativeArray<T> dataArray);
	}

	public class GridMap<T> : IDisposable // TypeDefIndex: 48482
		where T : struct, IEquatable<T>
	{
		// Fields
		private NativeParallelMultiHashMap<int3, T> gridMap;
	
		// Properties
		public int DataCount { get; }
	
		// Nested types
		public struct GridEnumerator : IEnumerator<int3> // TypeDefIndex: 48481
		{
			// Fields
			internal NativeParallelMultiHashMap<int3, T> gridMap;
			internal int3 startGrid;
			internal int3 endGrid;
			internal int3 currentGrid;
			internal bool isFirst;
	
			// Properties
			public int3 Current { get; }
			object IEnumerator.Current { get; }
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			public void Reset();
			public GridEnumerator<T> GetEnumerator();
		}
	
		// Constructors
		public GridMap(int capacity = 0 /* Metadata: 0x0232D06F */);
	
		// Methods
		public void Dispose();
		public NativeParallelMultiHashMap<int3, T> GetMultiHashMap();
		public static GridEnumerator GetArea(int3 startGrid, int3 endGrid, NativeParallelMultiHashMap<int3, T> gridMap);
		public static GridEnumerator GetArea(float3 pos, float radius, NativeParallelMultiHashMap<int3, T> gridMap, float gridSize);
		public static int3 GetGrid(float3 pos, float gridSize);
		public static void AddGrid(int3 grid, T data, NativeParallelMultiHashMap<int3, T> gridMap);
		public static int3 AddGrid(float3 pos, T data, NativeParallelMultiHashMap<int3, T> gridMap, float gridSize);
		public static int3 AddGrid(float3 pos, T data, NativeParallelMultiHashMap<int3, T> gridMap, float gridSize);
		public static bool RemoveGrid(int3 grid, T data, NativeParallelMultiHashMap<int3, T> gridMap);
		public static bool MoveGrid(int3 fromGrid, int3 toGrid, T data, NativeParallelMultiHashMap<int3, T> gridMap);
	}

	public static class ClothJobUtility // TypeDefIndex: 48499
	{
		// Nested types
		[BurstCompile]
		private struct FillJob<T> : IJobParallelFor, ICrossFrameParallelForJob // TypeDefIndex: 48483
			where T : struct
		{
			// Fields
			public T value;
			[WriteOnly]
			public NativeArray<T> array;
			[ReadOnly]
			public int _indexCount;
	
			// Methods
			public void Execute(int index);
			public void SetIndexCount(int indexCount);
			public void Execute();
		}
	
		[BurstCompile]
		private struct FillJob2<T> : IJobParallelFor, ICrossFrameParallelForJob // TypeDefIndex: 48484
			where T : struct
		{
			// Fields
			public T value;
			public int startIndex;
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<T> array;
			[ReadOnly]
			public int _indexCount;
	
			// Methods
			public void Execute(int index);
			public void SetIndexCount(int indexCount);
			public void Execute();
		}
	
		[BurstCompile]
		private struct FillRefJob<T> : IJob // TypeDefIndex: 48485
			where T : struct
		{
			// Fields
			public T value;
			[WriteOnly]
			public NativeReference<T> reference;
	
			// Methods
			public void Execute();
		}
	
		[BurstCompile]
		private struct SerialNumberJob : IJobParallelFor // TypeDefIndex: 48486
		{
			// Fields
			[WriteOnly]
			public NativeArray<int> array; // 0x00
	
			// Methods
			public void Execute(int index); // 0x0000000183F48A20-0x0000000183F48A60
		}
	
		[BurstCompile]
		private struct ConvertHashSetToListJob<T> : IJob // TypeDefIndex: 48487
			where T : struct, IEquatable<T>
		{
			// Fields
			[ReadOnly]
			public NativeParallelHashSet<T> hashSet;
			[WriteOnly]
			public NativeList<T> list;
	
			// Methods
			public void Execute();
		}
	
		[BurstCompile]
		private struct ConvertHashSetKeyToListJob<T> : IJob // TypeDefIndex: 48488
			where T : struct, IEquatable<T>
		{
			// Fields
			[ReadOnly]
			public NativeParallelHashSet<T> hashSet;
			[WriteOnly]
			public NativeList<T> list;
	
			// Methods
			public void Execute();
		}
	
		[BurstCompile]
		private struct CalcAABBJob : IJob // TypeDefIndex: 48489
		{
			// Fields
			public int length; // 0x00
			[ReadOnly]
			public NativeArray<float3> positions; // 0x08
			public NativeReference<AABB> outAABB; // 0x18
	
			// Methods
			public void Execute(); // 0x000000018415F200-0x000000018415F270
		}
	
		[BurstCompile]
		private struct CalcAABBDeferJob : IJob // TypeDefIndex: 48490
		{
			// Fields
			[ReadOnly]
			public NativeList<float3> positions; // 0x00
			public NativeReference<AABB> outAABB; // 0x10
	
			// Methods
			public void Execute(); // 0x000000018677DA18-0x000000018677DAF4
		}
	
		[BurstCompile]
		private struct CalcUVJob : IJobParallelFor // TypeDefIndex: 48491
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> positions; // 0x00
			[ReadOnly]
			public NativeReference<AABB> aabb; // 0x10
			[WriteOnly]
			public NativeArray<float2> uvs; // 0x20
	
			// Methods
			public void Execute(int index); // 0x000000018677DAF4-0x000000018677DD04
		}
	
		[BurstCompile]
		public struct AddIntDataCopyJob : IJobParallelFor // TypeDefIndex: 48492
		{
			// Fields
			public int dstOffset; // 0x00
			public int addData; // 0x04
			[ReadOnly]
			public NativeArray<int> srcData; // 0x08
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int> dstData; // 0x18
	
			// Methods
			public void Execute(int index); // 0x000000018677C254-0x000000018677C2C4
		}
	
		[BurstCompile]
		public struct AddInt2DataCopyJob : IJobParallelFor // TypeDefIndex: 48493
		{
			// Fields
			public int dstOffset; // 0x00
			public int2 addData; // 0x04
			[ReadOnly]
			public NativeArray<int2> srcData; // 0x10
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int2> dstData; // 0x20
	
			// Methods
			public void Execute(int index); // 0x000000018677C124-0x000000018677C19C
		}
	
		[BurstCompile]
		public struct AddInt3DataCopyJob : IJobParallelFor // TypeDefIndex: 48494
		{
			// Fields
			public int dstOffset; // 0x00
			public int3 addData; // 0x04
			[ReadOnly]
			public NativeArray<int3> srcData; // 0x10
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<int3> dstData; // 0x20
	
			// Methods
			public void Execute(int index); // 0x000000018677C19C-0x000000018677C254
		}
	
		[BurstCompile]
		public struct TransformPositionJob : IJobParallelFor // TypeDefIndex: 48495
		{
			// Fields
			public float4x4 toM; // 0x00
			public NativeArray<float3> positions; // 0x40
	
			// Methods
			public void Execute(int vindex); // 0x000000018678A578-0x000000018678A618
		}
	
		[BurstCompile]
		public struct TransformPositionJob2 : IJobParallelFor // TypeDefIndex: 48496
		{
			// Fields
			public float4x4 toM; // 0x00
			[ReadOnly]
			public NativeArray<float3> srcPositions; // 0x40
			[WriteOnly]
			public NativeArray<float3> dstPositions; // 0x50
	
			// Methods
			public void Execute(int vindex); // 0x000000018678A4D8-0x000000018678A578
		}
	
		[BurstCompile]
		private struct ConvertArrayToMapJob<TData> : IJob // TypeDefIndex: 48497
			where TData : struct
		{
			// Fields
			[ReadOnly]
			public NativeArray<uint> indexArray;
			[ReadOnly]
			public NativeArray<TData> dataArray;
			[WriteOnly]
			public NativeParallelMultiHashMap<int, TData> map;
	
			// Methods
			public void Execute();
		}
	
		[BurstCompile]
		private struct ClearReferenceJob : IJob // TypeDefIndex: 48498
		{
			// Fields
			public NativeReference<int> reference; // 0x00
	
			// Methods
			public void Execute(); // 0x000000018677DD04-0x000000018677DD70
		}
	
		// Methods
		[IDTag(0)]
		public static JobHandle Fill(NativeArray<byte> array, int length, byte value, JobHandle dependsOn = default); // 0x000000018677EC6C-0x000000018677EDA4
		[IDTag(1)]
		public static void FillRun(NativeArray<int> array, int length, int value); // 0x000000018677E970-0x000000018677EA5C
		[IDTag(2)]
		public static void FillRun(NativeArray<quaternion> array, int length, quaternion value); // 0x00000001843F6FC0-0x00000001843F7070
		[IDTag(0)]
		public static void FillRun(NativeArray<VirtualMeshBoneWeight> array, int length, VirtualMeshBoneWeight value); // 0x000000018677EA5C-0x000000018677EB48
		[IDTag(1)]
		public static JobHandle Fill(NativeArray<int> array, int startIndex, int length, int value, JobHandle dependsOn = default); // 0x000000018677EDA4-0x000000018677EEE0
		[IDTag(2)]
		public static JobHandle Fill(NativeReference<int> reference, int value, JobHandle dependsOn = default); // 0x000000018677EB48-0x000000018677EC6C
		public static JobHandle SerialNumber(NativeArray<int> array, int length, JobHandle dependsOn = default); // 0x000000018677EEE0-0x000000018677EFE4
		public static void SerialNumberRun(NativeArray<int> array, int length); // 0x0000000184554720-0x0000000184554790
		public static JobHandle ConvertHashSetToNativeList(NativeParallelHashSet<int> hashSet, NativeList<int> list, JobHandle dependsOn = default); // 0x000000018677E860-0x000000018677E970
		[IDTag(0)]
		public static JobHandle ConvertHashSetKeyToNativeList(NativeParallelHashSet<int2> hashSet, NativeList<int2> keyList, JobHandle dependsOn = default); // 0x000000018677E640-0x000000018677E750
		[IDTag(1)]
		public static JobHandle ConvertHashSetKeyToNativeList(NativeParallelHashSet<int4> hashSet, NativeList<int4> keyList, JobHandle dependsOn = default); // 0x000000018677E750-0x000000018677E860
		[IDTag(0)]
		public static JobHandle CalcAABB(NativeArray<float3> positions, int length, NativeReference<AABB> outAABB, JobHandle dependsOn = default); // 0x000000018677E1D0-0x000000018677E310
		[IDTag(0)]
		public static void CalcAABBRun(NativeArray<float3> positions, int length, NativeReference<AABB> outAABB); // 0x0000000183CF6DD0-0x0000000183CF6EA0
		[IDTag(1)]
		public static JobHandle CalcAABB(NativeList<float3> positions, NativeReference<AABB> outAABB, JobHandle dependsOn = default); // 0x000000018677E0C0-0x000000018677E1D0
		[IDTag(1)]
		public static void CalcAABBRun(NativeList<float3> positions, NativeReference<AABB> outAABB); // 0x000000018677E008-0x000000018677E0C0
		private static AABB CalcAABBInternal([IsReadOnly] in NativeArray<float3> positions, int length); // 0x000000018415F7C0-0x000000018415F9A0
		public static JobHandle CalcUVWithSphereMapping(NativeArray<float3> positions, int length, NativeReference<AABB> aabb, NativeArray<float2> outUVs, JobHandle dependsOn = default); // 0x000000018677E410-0x000000018677E568
		public static void CalcUVWithSphereMappingRun(NativeArray<float3> positions, int length, NativeReference<AABB> aabb, NativeArray<float2> outUVs); // 0x000000018677E310-0x000000018677E410
		[IDTag(0)]
		public static JobHandle TransformPosition(NativeArray<float3> positions, int length, [IsReadOnly] in float4x4 toM, JobHandle dependsOn = default); // 0x000000018677F1D8-0x000000018677F31C
		[IDTag(1)]
		public static void TransformPositionRun(NativeArray<float3> positions, int length, [IsReadOnly] in float4x4 toM); // 0x000000018677F0F0-0x000000018677F1D8
		[IDTag(1)]
		public static JobHandle TransformPosition(NativeArray<float3> srcPositions, NativeArray<float3> dstPositions, int length, [IsReadOnly] in float4x4 toM, JobHandle dependsOn = default); // 0x000000018677F31C-0x000000018677F488
		[IDTag(0)]
		public static void TransformPositionRun(NativeArray<float3> srcPositions, NativeArray<float3> dstPositions, int length, [IsReadOnly] in float4x4 toM); // 0x000000018677EFE4-0x000000018677F0F0
		public static NativeParallelMultiHashMap<int, ushort> ToNativeMultiHashMap([IsReadOnly] in NativeArray<uint> indexArray, [IsReadOnly] in NativeArray<ushort> dataArray); // 0x00000001843A7F20-0x00000001843A8050
		public static JobHandle ClearReference(NativeReference<int> reference, JobHandle jobHandle); // 0x000000018677E568-0x000000018677E640
	}

	public static class InterlockUtility // TypeDefIndex: 48526
	{
		// Fields
		private const int ToFixed = 1000000; // Metadata: 0x0232D070
		private const float ToFloat = 1E-06f; // Metadata: 0x0232D074
	
		// Nested types
		[BurstCompile]
		private static class AggregateJobKernels // TypeDefIndex: 48504
		{
			// Nested types
			public unsafe delegate void AggregateKernel_0000057A_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 48500; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class AggregateKernel_0000057A_BurstDirectCall // TypeDefIndex: 48501
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateKernel_0000057A_BurstDirectCall(); // 0x0000000183FB2BC0-0x0000000183FB2BD0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00069239); // 0x000000018677CBAC-0x000000018677CCB0
				private static IntPtr GetFunctionPointer(); // 0x000000018677CCB0-0x000000018677CD04
				public static void Constructor(); // 0x0000000183FB1BB0-0x0000000183FB1C40
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x000000018677CD04-0x000000018677CDC4
			}
	
			public unsafe delegate void AggregateRangeKernel_0000057B_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 48502; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class AggregateRangeKernel_0000057B_BurstDirectCall // TypeDefIndex: 48503
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateRangeKernel_0000057B_BurstDirectCall(); // 0x0000000183FB2BB0-0x0000000183FB2BC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006924e); // 0x000000018677CE70-0x000000018677CF74
				private static IntPtr GetFunctionPointer(); // 0x000000018677CF74-0x000000018677CFC8
				public static void Constructor(); // 0x0000000183FB1B20-0x0000000183FB1BB0
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // 0x000000018677CFC8-0x000000018677D0A4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateKernel(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x000000018677CA48-0x000000018677CAC4
			[BurstCompile]
			internal static unsafe void AggregateRangeKernel(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // 0x000000018677CB30-0x000000018677CBAC
			[BurstCompile]
			public static unsafe void AggregateKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x000000018677B640-0x000000018677B780
			[BurstCompile]
			public static unsafe void AggregateRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // 0x000000018677CAC4-0x000000018677CB30
		}
	
		[BurstCompile]
		private static class AggregateWithVelocityJobKernels // TypeDefIndex: 48509
		{
			// Nested types
			public unsafe delegate void AggregateWithVelocityKernel_0000057C_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // TypeDefIndex: 48505; 0x0000000182C394B0-0x0000000182C394D0
	
			internal static class AggregateWithVelocityKernel_0000057C_BurstDirectCall // TypeDefIndex: 48506
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityKernel_0000057C_BurstDirectCall(); // 0x0000000183FB2BA0-0x0000000183FB2BB0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00069283); // 0x000000018677D3C0-0x000000018677D4C4
				private static IntPtr GetFunctionPointer(); // 0x000000018677D4C4-0x000000018677D518
				public static void Constructor(); // 0x0000000183FB1A90-0x0000000183FB1B20
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x000000018677D518-0x000000018677D610
			}
	
			public unsafe delegate void AggregateWithVelocityRangeKernel_0000057D_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // TypeDefIndex: 48507; 0x0000000182C394B0-0x0000000182C394D0
	
			internal static class AggregateWithVelocityRangeKernel_0000057D_BurstDirectCall // TypeDefIndex: 48508
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityRangeKernel_0000057D_BurstDirectCall(); // 0x0000000183FB2B90-0x0000000183FB2BA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006929e); // 0x000000018677D6EC-0x000000018677D7F0
				private static IntPtr GetFunctionPointer(); // 0x000000018677D7F0-0x000000018677D844
				public static void Constructor(); // 0x0000000183FB1A00-0x0000000183FB1A90
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // 0x000000018677D844-0x000000018677D93C
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateWithVelocityKernel(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x000000018677D288-0x000000018677D324
			[BurstCompile]
			internal static unsafe void AggregateWithVelocityRangeKernel(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // 0x000000018677D324-0x000000018677D3C0
			[BurstCompile]
			public static unsafe void AggregateWithVelocityKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x00000001866A7CA8-0x00000001866A7E9C
			[BurstCompile]
			public static unsafe void AggregateWithVelocityRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // 0x000000018677B780-0x000000018677B814
		}
	
		[BurstCompile]
		private static class AggregateJob2Kernels // TypeDefIndex: 48514
		{
			// Nested types
			public unsafe delegate void AggregateJob2Kernel_0000057E_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 48510; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class AggregateJob2Kernel_0000057E_BurstDirectCall // TypeDefIndex: 48511
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateJob2Kernel_0000057E_BurstDirectCall(); // 0x0000000183FB2B80-0x0000000183FB2B90
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000692c9); // 0x000000018677C2C4-0x000000018677C3C8
				private static IntPtr GetFunctionPointer(); // 0x000000018677C3C8-0x000000018677C41C
				public static void Constructor(); // 0x0000000183FB1970-0x0000000183FB1A00
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x000000018677C41C-0x000000018677C4DC
			}
	
			public unsafe delegate void AggregateJob2RangeKernel_0000057F_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // TypeDefIndex: 48512; 0x00000001814DD080-0x00000001814DD0A0
	
			internal static class AggregateJob2RangeKernel_0000057F_BurstDirectCall // TypeDefIndex: 48513
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateJob2RangeKernel_0000057F_BurstDirectCall(); // 0x0000000183FB2B70-0x0000000183FB2B80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000692de); // 0x000000018677C6F0-0x000000018677C7F4
				private static IntPtr GetFunctionPointer(); // 0x000000018677C7F4-0x000000018677C848
				public static void Constructor(); // 0x0000000183FB18E0-0x0000000183FB1970
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // 0x000000018677C848-0x000000018677C924
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateJob2Kernel(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x000000018677C588-0x000000018677C604
			[BurstCompile]
			internal static unsafe void AggregateJob2RangeKernel(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // 0x000000018677C670-0x000000018677C6F0
			[BurstCompile]
			public static unsafe void AggregateJob2Kernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x000000018677B640-0x000000018677B780
			[BurstCompile]
			public static unsafe void AggregateJob2RangeKernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // 0x000000018677C604-0x000000018677C670
		}
	
		[BurstCompile]
		private static class AggregateWithVelocityJob2Kernels // TypeDefIndex: 48519
		{
			// Nested types
			public unsafe delegate void AggregateWithVelocityJob2Kernel_00000580_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // TypeDefIndex: 48515; 0x0000000182C394B0-0x0000000182C394D0
	
			internal static class AggregateWithVelocityJob2Kernel_00000580_BurstDirectCall // TypeDefIndex: 48516
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityJob2Kernel_00000580_BurstDirectCall(); // 0x0000000184D1D730-0x0000000184D1D740
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00069313); // 0x00000001866AA484-0x00000001866AA588
				private static IntPtr GetFunctionPointer(); // 0x00000001866AA588-0x00000001866AA5DC
				public static void Constructor(); // 0x0000000184D1D740-0x0000000184D1D930
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x00000001866AA5DC-0x00000001866AA6D4
			}
	
			public unsafe delegate void AggregateWithVelocityJob2RangeKernel_00000581_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // TypeDefIndex: 48517; 0x0000000182C394B0-0x0000000182C394D0
	
			internal static class AggregateWithVelocityJob2RangeKernel_00000581_BurstDirectCall // TypeDefIndex: 48518
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityJob2RangeKernel_00000581_BurstDirectCall(); // 0x0000000184D1D690-0x0000000184D1D6A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006932e); // 0x00000001866AA884-0x00000001866AA988
				private static IntPtr GetFunctionPointer(); // 0x00000001866AA988-0x00000001866AA9DC
				public static void Constructor(); // 0x0000000184D1D6A0-0x0000000184D1D730
				public static void Initialize(); // 0x00000001841E1670-0x00000001841E1680
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // 0x00000001866AA9DC-0x00000001866AAAD8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateWithVelocityJob2Kernel(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x000000018677D150-0x000000018677D1EC
			[BurstCompile]
			internal static unsafe void AggregateWithVelocityJob2RangeKernel(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // 0x000000018677D1EC-0x000000018677D288
			[BurstCompile]
			public static unsafe void AggregateWithVelocityJob2Kernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x00000001866A7CA8-0x00000001866A7E9C
			[BurstCompile]
			public static unsafe void AggregateWithVelocityJob2RangeKernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // 0x00000001866A7E9C-0x00000001866A7F38
		}
	
		[BurstCompile]
		private struct AggregateJob : IJobParallelForDefer, IUnsafeJob // TypeDefIndex: 48520
		{
			// Fields
			[ReadOnly]
			public NativeList<int> jobParticleIndexList; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			public void Execute(int index); // 0x00000001866A9F78-0x00000001866AA128
			public void UnsafeDo(); // 0x00000001866AA128-0x00000001866AA224
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityJob : IJobParallelForDefer, IUnsafeJob // TypeDefIndex: 48521
		{
			// Fields
			[ReadOnly]
			public NativeList<int> jobParticleIndexList; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0x20
			public float velocityAttenuation; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x38
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x48
	
			// Methods
			public void Execute(int index); // 0x00000001866AB040-0x00000001866AB280
			public void UnsafeDo(); // 0x00000001866AB280-0x00000001866AB3AC
		}
	
		[BurstCompile]
		private struct AggregateJob2 : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48522
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> particleIndexArray; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x30
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x40
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x00000001866A9E6C-0x00000001866A9ED4
			[IDTag(1)]
			public void Execute(); // 0x00000001866A9DD8-0x00000001866A9E6C
			[IDTag(0)]
			public void Execute(int index); // 0x00000001866A9C54-0x00000001866A9DD8
			public void UnsafeDo(); // 0x00000001866A9ED4-0x00000001866A9F78
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityJob2 : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 48523
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> particleIndexArray; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> velocityPosArray; // 0x20
			public float velocityAttenuation; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x38
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x48
			[ReadOnly]
			public NativeReference<int> _indexCount; // 0x58
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount); // 0x00000001866AAF18-0x00000001866AAF80
			[IDTag(1)]
			public void Execute(); // 0x00000001866AAE84-0x00000001866AAF18
			[IDTag(0)]
			public void Execute(int index); // 0x00000001866AAC70-0x00000001866AAE84
			public void UnsafeDo(); // 0x00000001866AAF80-0x00000001866AB040
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityCrossFrameJob2 : IJob // TypeDefIndex: 48524
		{
			// Fields
			[ReadOnly]
			public NativeReference<int> indexCount; // 0x00
			[ReadOnly]
			public NativeArray<int> particleIndexArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> velocityPosArray; // 0x30
			public float velocityAttenuation; // 0x40
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x48
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x58
	
			// Methods
			[IDTag(0)]
			public void Execute(int index); // 0x00000001866AA2B8-0x00000001866AA484
			[IDTag(1)]
			public void Execute(); // 0x00000001866AA224-0x00000001866AA2B8
		}
	
		[BurstCompile]
		private struct AggregateCrossFrameJob2 : IJob // TypeDefIndex: 48525
		{
			// Fields
			[ReadOnly]
			public NativeReference<int> indexCount; // 0x00
			[ReadOnly]
			public NativeArray<int> particleIndexArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<float3> nextPosArray; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeArray<int> countArray; // 0x30
			[NativeDisableParallelForRestriction]
			public NativeArray<int> sumArray; // 0x40
	
			// Methods
			[IDTag(0)]
			public void Execute(int index); // 0x00000001866A9AF8-0x00000001866A9C54
			[IDTag(1)]
			public void Execute(); // 0x00000001866A9A64-0x00000001866A9AF8
		}
	
		// Methods
		internal static unsafe void AddFloat3(int index, float3 add, int* cntPt, int* sumPt); // 0x000000018677FD18-0x000000018677FDB0
		internal static unsafe void AddFloat3(int index, float3 add, int* sumPt); // 0x000000018677FDB0-0x000000018677FE44
		internal static unsafe void Increment(int index, int* cntPt); // 0x0000000184D87650-0x0000000184D87660
		internal static unsafe void Max(int index, float value, int* pt); // 0x0000000186695AD0-0x0000000186695B08
		internal static float3 ReadAverageFloat3(int index, [IsReadOnly] in NativeArray<int> countArray, [IsReadOnly] in NativeArray<int> sumArray); // 0x0000000186695B08-0x0000000186695C20
		internal static unsafe float3 ReadAverageFloat3(int index, int* countArray, int* sumArray); // 0x0000000186695C20-0x0000000186695CC4
		internal static float3 ReadFloat3(int index, [IsReadOnly] in NativeArray<int> bufferArray); // 0x0000000186695D34-0x0000000186695E00
		internal static unsafe float3 ReadFloat3(int index, int* bufferArray); // 0x0000000186695CC4-0x0000000186695D34
		internal static float ReadFloat(int index, [IsReadOnly] in NativeArray<int> bufferArray); // 0x0000000186695E00-0x0000000186695E68
		internal static unsafe float ReadFloat(int index, int* bufferArray); // 0x0000000184D87660-0x0000000184D87680
		[IDTag(2)]
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in NativeList<int> particleList, float velocityAttenuation, JobHandle jobHandle); // 0x000000018677FF10-0x000000018678015C
		[IDTag(1)]
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in ExProcessingList<int> processingList, float velocityAttenuation, JobHandle jobHandle); // 0x000000018677FE44-0x000000018677FF10
		[IDTag(0)]
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in NativeArray<int> particleArray, [IsReadOnly] in NativeReference<int> counter, float velocityAttenuation, JobHandle jobHandle); // 0x000000018678015C-0x00000001867803EC
		public static void Initialize_AggregateJobKernels_AggregateKernel_0000057A_BurstDirectCall(); // 0x00000001844F7770-0x00000001844F77D0
		public static void Initialize_AggregateJobKernels_AggregateRangeKernel_0000057B_BurstDirectCall(); // 0x00000001844F77D0-0x00000001844F7830
		public static void Initialize_AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_0000057C_BurstDirectCall(); // 0x00000001844F7830-0x00000001844F7890
		public static void Initialize_AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_0000057D_BurstDirectCall(); // 0x00000001844F7890-0x00000001844F78F0
		public static void Initialize_AggregateJob2Kernels_AggregateJob2Kernel_0000057E_BurstDirectCall(); // 0x00000001844F78F0-0x00000001844F7950
		public static void Initialize_AggregateJob2Kernels_AggregateJob2RangeKernel_0000057F_BurstDirectCall(); // 0x00000001844F7950-0x00000001844F79B0
		public static void Initialize_AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_00000580_BurstDirectCall(); // 0x00000001844F79B0-0x00000001844F7A10
		public static void Initialize_AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_00000581_BurstDirectCall(); // 0x00000001844F7A10-0x00000001844F7A70
	}

	[Serializable]
	public struct AABB : IEquatable<AABB> // TypeDefIndex: 48527
	{
		// Fields
		public double3 Min; // 0x00
		public double3 Max; // 0x18
	
		// Properties
		public double3 Extents { get; } // 0x00000001866A9670-0x00000001866A9720 
		public double3 HalfExtents { get; } // 0x00000001866A9720-0x00000001866A97F8 
		public double3 Center { get; } // 0x00000001866A9598-0x00000001866A9670 
		public float MaxSideLength { get; } // 0x00000001866A98A4-0x00000001866A9944 
		public bool IsValid { get; } // 0x00000001866A97F8-0x00000001866A98A4 
		public float SurfaceArea { get; } // 0x00000001866A9944-0x00000001866A9A64 
	
		// Constructors
		public AABB([IsReadOnly] in double3 min, [IsReadOnly] in double3 max); // 0x0000000184D87120-0x0000000184D87150
	
		// Methods
		public static AABB CreateFromCenterAndExtents(double3 center, double3 extents); // 0x00000001866A90C0-0x00000001866A9158
		public static AABB CreateFromCenterAndHalfExtents(double3 center, double3 halfExtents); // 0x00000001866A9158-0x00000001866A921C
		public bool Contains([IsReadOnly] in double3 point); // 0x00000001866A8FF8-0x00000001866A90C0
		public bool Contains([IsReadOnly] in AABB aabb); // 0x00000001866A8F30-0x00000001866A8FF8
		public bool Overlaps([IsReadOnly] in AABB aabb); // 0x00000001866A928C-0x00000001866A9354
		public void Expand(double signedDistance); // 0x000000018669266C-0x0000000186693E3C
		public void Encapsulate([IsReadOnly] in AABB aabb); // 0x00000001866925C0-0x000000018669266C
		public void Encapsulate([IsReadOnly] in double3 point); // 0x00000001866A7A40-0x00000001866A7AEC
		public bool Equals(AABB other); // 0x00000001866A921C-0x00000001866A928C
		public void Transform([IsReadOnly] in double4x4 toM); // 0x00000001866A7AEC-0x00000001866A7CA8
		public override string ToString(); // 0x00000001866A9354-0x00000001866A9538
		public string __iFixBaseProxy_ToString(); // 0x00000001866A9538-0x00000001866A9598
	}

	[Serializable]
	public struct IntAABB : IEquatable<IntAABB> // TypeDefIndex: 48528
	{
		// Fields
		public int3 Min; // 0x00
		public int3 Max; // 0x0C
	
		// Properties
		public int3 Extents { get; } // 0x00000001866AD330-0x00000001866AD3D0 
		public int3 Center { get; } // 0x00000001866AD250-0x00000001866AD330 
		public bool IsValid { get; } // 0x00000001866AD3D0-0x00000001866AD474 
	
		// Constructors
		public IntAABB(int3 min, int3 max); // 0x0000000184D871E0-0x0000000184D87200
	
		// Methods
		public bool Contains(int3 point); // 0x00000001866ACE94-0x00000001866ACFB0
		public bool Contains(IntAABB aabb); // 0x00000001866ACD78-0x00000001866ACE94
		public bool Overlaps(IntAABB aabb); // 0x00000001866AD094-0x00000001866AD1B4
		public void Expand(int signedDistance); // 0x00000001866AD020-0x00000001866AD094
		public void Encapsulate(IntAABB aabb); // 0x00000001866A8230-0x00000001866A8318
		public void Encapsulate(int3 point); // 0x00000001866A8318-0x00000001866A85BC
		public bool Equals(IntAABB other); // 0x00000001866ACFB0-0x00000001866AD020
		public override string ToString(); // 0x00000001866AD1B4-0x00000001866AD250
	}

	public static class MathExtensions // TypeDefIndex: 48529
	{
		// Extension methods
		public static float MC2GetValue([IsReadOnly] this in float4x4 m, int index); // 0x00000001866AD6AC-0x00000001866AD704
		public static void MC2SetValue(this ref float4x4 m, int index, float value); // 0x00000001866AD704-0x00000001866AD72C
		public static float MC2EvaluateCurveClamp01([IsReadOnly] this in float4x4 m, float time); // 0x00000001866AD684-0x00000001866AD6A4
		public static float MC2EvaluateCurve([IsReadOnly] this in float4x4 m, float time); // 0x00000001866AD6A4-0x00000001866AD6AC
	}

	public static class MathUtility // TypeDefIndex: 48530
	{
		// Methods
		public static void ComputeVirtualParentWithoutLocal(float3 fromPos, quaternion fromRot, float3 toPos, quaternion toRot, out float3 dPos, out quaternion dRot); // 0x00000001866AEB40-0x00000001866AECDC
		public static float Clamp1(float a); // 0x00000001866AD86C-0x00000001866AD884
		public static double Clamp1(double a); // 0x00000001866AD854-0x00000001866AD86C
		public static double3 Project([IsReadOnly] in double3 v, [IsReadOnly] in double3 n); // 0x0000000186696AC8-0x0000000186696B50
		public static double3 ProjectOnPlane([IsReadOnly] in double3 v, [IsReadOnly] in double3 n); // 0x00000001866B0CB4-0x00000001866B0D70
		public static float3 mul(quaternion q, float3 v); // 0x00000001866B2E2C-0x00000001866B2E7C
		public static double3 mul(quaternion q, double3 v); // 0x00000001866B2C68-0x00000001866B2E2C
		public static float Angle([IsReadOnly] in float3 v1, [IsReadOnly] in float3 v2); // 0x00000001866A85BC-0x00000001866A868C
		public static double Angle([IsReadOnly] in double3 v1, [IsReadOnly] in double3 v2); // 0x0000000186689908-0x0000000186689A68
		public static float3 ClampVector(float3 v, float minlength, float maxlength); // 0x00000001866ADD60-0x00000001866ADE34
		public static float3 ClampVector(float3 v, float maxlength); // 0x00000001866ADEE8-0x00000001866ADF94
		public static double3 ClampVector(double3 v, double maxlength); // 0x00000001866ADE34-0x00000001866ADEE8
		public static double3 ClampDistance(double3 from, double3 to, double maxlength); // 0x00000001866ADC84-0x00000001866ADD60
		public static bool ClampAngle([IsReadOnly] in double3 dir, [IsReadOnly] in double3 basedir, double maxAngle, out double3 outdir); // 0x00000001866AD884-0x00000001866ADC00
		public static quaternion FromToRotation([IsReadOnly] in double3 from, [IsReadOnly] in double3 to, double t = 1 /* Metadata: 0x0232D078 */); // 0x00000001866AEF20-0x00000001866AF228
		public static quaternion FromToRotation([IsReadOnly] in quaternion from, [IsReadOnly] in quaternion to); // 0x00000001866AEEC4-0x00000001866AEF20
		public static float Angle([IsReadOnly] in quaternion a, [IsReadOnly] in quaternion b); // 0x00000001866A868C-0x00000001866A8710
		public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle); // 0x00000001866ADC00-0x00000001866ADC84
		public static quaternion ToRotation([IsReadOnly] in float3 nor, [IsReadOnly] in float3 tan); // 0x00000001866B1510-0x00000001866B1564
		public static void ToNormalTangent([IsReadOnly] in quaternion rot, out float3 nor, out float3 tan); // 0x00000001866A8AB8-0x00000001866A8C28
		public static float3 ToNormal([IsReadOnly] in quaternion rot); // 0x00000001866B14B8-0x00000001866B1510
		public static float3 ToTangent([IsReadOnly] in quaternion rot); // 0x00000001866B1564-0x00000001866B15BC
		public static float3 ToBinormal([IsReadOnly] in quaternion rot); // 0x00000001866B1464-0x00000001866B14B8
		public static float3 Binormal([IsReadOnly] in float3 nor, [IsReadOnly] in float3 tan); // 0x00000001866AD774-0x00000001866AD7CC
		public static float3 AxisToEuler([IsReadOnly] in float3 axis); // 0x00000001866A8710-0x00000001866A87E4
		public static quaternion AxisQuaternion(float3 dir); // 0x00000001866AD72C-0x00000001866AD774
		public static void ToAngleAxis([IsReadOnly] in quaternion q, out float angle, out float3 axis); // 0x00000001866B1398-0x00000001866B1464
		public static float ClosestPtPointSegmentRatio([IsReadOnly] in double3 c, [IsReadOnly] in double3 a, [IsReadOnly] in double3 b); // 0x0000000186695F84-0x000000018669609C
		public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b); // 0x00000001866AE0E0-0x00000001866AE1B8
		public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b); // 0x00000001866AE1B8-0x00000001866AE318
		public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b); // 0x00000001866ADF94-0x00000001866AE0E0
		public static double ClosestPtSegmentSegment([IsReadOnly] in double3 p1, [IsReadOnly] in double3 q1, [IsReadOnly] in double3 p2, [IsReadOnly] in double3 q2, out double s, out double t, out double3 c1, out double3 c2); // 0x00000001866963D4-0x00000001866968D8
		public static void ClosestPtSegmentSegment2([IsReadOnly] in double3 p1, [IsReadOnly] in double3 q1, [IsReadOnly] in double3 p2, [IsReadOnly] in double3 q2, out double s, out double t); // 0x000000018669609C-0x00000001866963D4
		public static double3 ClosestPtPointTriangle([IsReadOnly] in double3 p, [IsReadOnly] in double3 a, [IsReadOnly] in double3 b, [IsReadOnly] in double3 c, out double3 uvw); // 0x00000001866AE318-0x00000001866AE9FC
		public static bool PointInTriangleUVW(float3 uvw); // 0x00000001866B0C90-0x00000001866B0CB4
		public static float3 TriangleCenter([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2); // 0x00000001866B2454-0x00000001866B2508
		public static float3 TriangleNormal([IsReadOnly] in double3 p0, [IsReadOnly] in double3 p1, [IsReadOnly] in double3 p2); // 0x0000000186696B50-0x0000000186697910
		public static float TriangleArea([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2); // 0x00000001866A8CD8-0x00000001866A8DA0
		public static bool IsSafeTriangle([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2); // 0x00000001866B09CC-0x00000001866B09E4
		[IDTag(1)]
		public static float3 TriangleTangent([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2, [IsReadOnly] in float2 uv0, [IsReadOnly] in float2 uv1, [IsReadOnly] in float2 uv2); // 0x00000001866B27C0-0x00000001866B2A28
		[IDTag(0)]
		public static double3 TriangleTangent([IsReadOnly] in double3 p0, [IsReadOnly] in double3 p1, [IsReadOnly] in double3 p2, [IsReadOnly] in float2 uv0, [IsReadOnly] in float2 uv1, [IsReadOnly] in float2 uv2); // 0x00000001866B2508-0x00000001866B27C0
		public static float TriangleAngle([IsReadOnly] in float3 v0, [IsReadOnly] in float3 v1, [IsReadOnly] in float3 v2, [IsReadOnly] in float3 v3); // 0x00000001866B230C-0x00000001866B2454
		public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2); // 0x00000001866AEDF8-0x00000001866AEEC4
		public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c); // 0x00000001866AECDC-0x00000001866AEDF8
		public static int2 GetRestTriangleVertex(int3 tri1, int3 tri2, int2 edge); // 0x00000001866AF34C-0x00000001866AF450
		public static int2 GetCommonEdgeFromTrianglePair(int3 tri1, int3 tri2); // 0x00000001866AF228-0x00000001866AF34C
		public static int4 GetTrianglePairIndices(int3 tri1, int3 tri2); // 0x00000001866AF5A4-0x00000001866AF6C8
		public static int GetUnuseTriangleIndex(int3 tri, int2 edge); // 0x00000001866AF854-0x00000001866AF8F4
		public static float GetTrianglePairAngle(float3 pos0, float3 pos1, float3 pos2, float3 pos3); // 0x00000001866AF450-0x00000001866AF5A4
		public static int3 FlipTriangle([IsReadOnly] in int3 tri); // 0x0000000184D87260-0x0000000184D872A0
		public static void GetTriangleSphere(float3 pos0, float3 pos1, float3 pos2, out float3 sc, out float sr); // 0x00000001866AF6C8-0x00000001866AF854
		public static float4x4 LocalToWorldMatrix([IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x00000001866B0B80-0x00000001866B0C90
		public static double4x4 LocalToWorldMatrix([IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x00000001866B0AE0-0x00000001866B0B80
		public static float4x4 WorldToLocalMatrix([IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x00000001866B2A28-0x00000001866B2B68
		public static double4x4 WorldToLocalMatrix([IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x00000001866B2B68-0x00000001866B2C68
		public static float3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x00000001866B1944-0x00000001866B1A94
		public static double3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x00000001866B1848-0x00000001866B1944
		public static float3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float4x4 m); // 0x00000001866B07C0-0x00000001866B0834
		public static float3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in float4x4 m); // 0x00000001866B17C4-0x00000001866B1848
		public static double3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in double4x4 m); // 0x00000001866B1B40-0x00000001866B1BF0
		public static double3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double4x4 m); // 0x00000001866B1A94-0x00000001866B1B40
		public static float3 TransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in float4x4 m); // 0x00000001866A8C28-0x00000001866A8CD8
		public static double3 TransformVector([IsReadOnly] in double3 vec, [IsReadOnly] in float4x4 m); // 0x00000001866B203C-0x00000001866B2150
		public static double3 TransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in double4x4 m); // 0x00000001866B2220-0x00000001866B230C
		public static double3 TransformVector([IsReadOnly] in double3 vec, [IsReadOnly] in double4x4 m); // 0x00000001866B2150-0x00000001866B2220
		public static float3 TransformDirection([IsReadOnly] in float3 dir, [IsReadOnly] in float4x4 m); // 0x00000001866B15BC-0x00000001866B1694
		public static quaternion TransformRotation([IsReadOnly] in quaternion rot, [IsReadOnly] in double4x4 m, [IsReadOnly] in float3 normalTangentFlip); // 0x00000001866B1D44-0x00000001866B203C
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale); // 0x00000001866B131C-0x00000001866B1398
		public static double4x4 TRS(double3 translation, quaternion rotation, float3 scale); // 0x00000001866B10F8-0x00000001866B131C
		public static float TransformDistance([IsReadOnly] in float dist, [IsReadOnly] in float4x4 localToWorldMatrix); // 0x00000001866B1694-0x00000001866B1718
		public static void TransformPositionNormalTangent([IsReadOnly] in float3 tpos, [IsReadOnly] in quaternion trot, [IsReadOnly] in float3 tscl, ref float3 pos, ref float3 nor, ref float3 tan); // 0x00000001866B1BF0-0x00000001866B1D44
		public static float TransformLength(float length, [IsReadOnly] in float4x4 matrix); // 0x00000001866B1718-0x00000001866B17C4
		public static float3 InverseTransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float4x4 worldToLocalMatrix); // 0x00000001866B07C0-0x00000001866B0834
		public static double3 InverseTransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double4x4 worldToLocalMatrix); // 0x00000001866B0450-0x00000001866B04F4
		public static float3 InverseTransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x00000001866B04F4-0x00000001866B0674
		public static double3 InverseTransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x00000001866B0674-0x00000001866B07C0
		public static float3 InverseTransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in float4x4 worldToLocalMatrix); // 0x00000001866A8C28-0x00000001866A8CD8
		public static float3 InverseTransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in quaternion rot); // 0x00000001866B0834-0x00000001866B089C
		public static float3 InverseTransformDirection([IsReadOnly] in float3 dir, [IsReadOnly] in float4x4 worldToLocalMatrix); // 0x00000001866B0378-0x00000001866B0450
		public static float4x4 Transform([IsReadOnly] in float4x4 fromLocalToWorldMatrix, [IsReadOnly] in float4x4 toWorldToLocalMatrix); // 0x0000000186689A68-0x0000000186689D38
		public static bool CompareMatrix([IsReadOnly] in float4x4 m1, [IsReadOnly] in float4x4 m2); // 0x00000001866A87E4-0x00000001866A8AB8
		public static bool CompareTransform([IsReadOnly] in float3 pos1, [IsReadOnly] in quaternion rot1, [IsReadOnly] in float3 scl1, [IsReadOnly] in float3 pos2, [IsReadOnly] in quaternion rot2, [IsReadOnly] in float3 scl2); // 0x00000001866AE9FC-0x00000001866AEA9C
		public static bool CompareTransform([IsReadOnly] in double3 pos1, [IsReadOnly] in quaternion rot1, [IsReadOnly] in float3 scl1, [IsReadOnly] in double3 pos2, [IsReadOnly] in quaternion rot2, [IsReadOnly] in float3 scl2); // 0x00000001866AEA9C-0x00000001866AEB40
		[IDTag(0)]
		public static bool IntersectSegmentTriangle([IsReadOnly] in float3 p, [IsReadOnly] in float3 q, float3 a, float3 b, float3 c, bool doubleSide, out float u, out float v, out float w, out float t); // 0x00000001866AFA70-0x00000001866AFF90
		[IDTag(1)]
		public static bool IntersectSegmentTriangle([IsReadOnly] in float3 p, [IsReadOnly] in float3 q, float3 a, float3 b, float3 c); // 0x00000001866AFF90-0x00000001866B0378
		public static double IntersectPointPlaneDist([IsReadOnly] in double3 planePos, [IsReadOnly] in double3 planeDir, [IsReadOnly] in double3 pos, out double3 outPos); // 0x00000001866968D8-0x0000000186696AC8
		public static bool IntersectRaySphere([IsReadOnly] in float3 p, [IsReadOnly] in float3 d, [IsReadOnly] in float3 sc, [IsReadOnly] in float sr, ref float t, ref float3 q); // 0x00000001866AF8F4-0x00000001866AFA70
		public static float SqDistPointSegment(Vector3 a, Vector3 b, Vector3 c); // 0x00000001866B0EE8-0x00000001866B10F8
		public static bool IsNaN(float3 v); // 0x00000001866B0908-0x00000001866B0950
		public static bool IsNaN(double3 v); // 0x00000001866B089C-0x00000001866B08E4
		public static bool IsNaN(float4 v); // 0x00000001866B08E4-0x00000001866B0908
		public static bool IsNaN(quaternion q); // 0x00000001866B0950-0x00000001866B09CC
		public static float3 Lerp(float3 x, float3 y, float s); // 0x00000001866B09E4-0x00000001866B0A5C
		public static double3 Lerp(double3 x, double3 y, double s); // 0x00000001866B0A5C-0x00000001866B0AE0
		public static double3 ShiftPosition([IsReadOnly] in double3 oldPos, [IsReadOnly] in double3 oldPivotPosition, [IsReadOnly] in double3 shiftVector, [IsReadOnly] in quaternion shiftRotation); // 0x00000001866B0D70-0x00000001866B0EE8
		public static float CalcMass(float depth); // 0x0000000184D87230-0x0000000184D87260
		public static float CalcInverseMass(float friction); // 0x00000001866AD7CC-0x00000001866AD7E8
		public static float CalcInverseMass(float friction, float depth); // 0x00000001866AD7E8-0x00000001866AD81C
		public static float CalcInverseMass(float friction, float depth, bool fix, float fixMass); // 0x0000000186695E68-0x0000000186695F84
		public static float CalcSelfCollisionInverseMass(float friction, bool fix, float clothMass); // 0x00000001866AD81C-0x00000001866AD854
	
		// Extension methods
		public static double3 AutoConvertToFloat([IsReadOnly] this in Vector3 v); // 0x0000000183B8B4B0-0x0000000183B8B4E0
		public static float3 AutoToFloat3([IsReadOnly] this in double3 v); // 0x0000000184D87200-0x0000000184D87230
	}

	public class MinimumData<T1, T2> // TypeDefIndex: 48531
		where T1 : struct
		where T2 : struct
	{
		// Fields
		private T1 minDist;
		private T2 minData;
		private bool isValid;
	
		// Properties
		public bool IsValid { get; }
		public T1 MinDistance { get; }
		public T2 MinData { get; }
	
		// Constructors
		public MinimumData();
	
		// Methods
		public void Add(T1 distance, T2 data);
		public void Clear();
		public override string ToString();
	}

	public struct FTransform // TypeDefIndex: 48532
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 scale; // 0x1C
	
		// Methods
		public static FTransform Default(); // 0x00000001866ACCA8-0x00000001866ACD78
	}

	public static class MeshUtility // TypeDefIndex: 48533
	{
		// Methods
		public static Mesh GetSharedMesh(Renderer ren); // 0x00000001866B2E7C-0x00000001866B2FE0
		public static bool SetMesh(Renderer ren, Mesh mesh, Transform[] skinBones = null); // 0x00000001866B30C4-0x00000001866B3240
		public static int GetTransformCount(Renderer ren); // 0x00000001866B2FE0-0x00000001866B30C4
	}

	public static class Develop // TypeDefIndex: 48534
	{
		// Methods
		public static void Log([IsReadOnly] in object mes); // 0x00000001866AB848-0x00000001866AB8E4
		public static void LogWarning([IsReadOnly] in object mes); // 0x00000001866AB7AC-0x00000001866AB848
		public static void LogError([IsReadOnly] in object mes); // 0x00000001866AB714-0x00000001866AB7AC
		[Conditional("MC2_LOG")]
		public static void DebugLog([IsReadOnly] in object mes); // 0x00000001866AB678-0x00000001866AB714
		[Conditional("MC2_DEBUG")]
		public static void DebugLogWarning([IsReadOnly] in object mes); // 0x00000001866AB5DC-0x00000001866AB678
		[Conditional("MC2_DEBUG")]
		public static void DebugLogError([IsReadOnly] in object mes); // 0x00000001866AB540-0x00000001866AB5DC
		[Conditional("MC2_DEBUG")]
		public static void Assert(bool condition); // 0x00000001866AB4FC-0x00000001866AB540
	}

	public class StaticStringBuilder // TypeDefIndex: 48535
	{
		// Fields
		private static StringBuilder stringBuilder; // 0x00
	
		// Properties
		public static StringBuilder Instance { get; } // 0x00000001866B3FF4-0x00000001866B406C 
	
		// Constructors
		public StaticStringBuilder(); // 0x00000001841E1670-0x00000001841E1680
		static StaticStringBuilder(); // 0x00000001866B3F70-0x00000001866B3FF4
	
		// Methods
		public static void Clear(); // 0x00000001866B3E60-0x00000001866B3EE8
		public static StringBuilder Append(params object[] args); // 0x00000001866B3D90-0x00000001866B3E60
		[IDTag(0)]
		public static StringBuilder AppendLine(params object[] args); // 0x00000001866B3B78-0x00000001866B3C80
		[IDTag(1)]
		public static StringBuilder AppendLine(); // 0x00000001866B3AD0-0x00000001866B3B78
		public static string AppendToString(params object[] args); // 0x00000001866B3C80-0x00000001866B3D90
		public static new string ToString(); // 0x00000001866B3EE8-0x00000001866B3F70
	}

	public struct DataChunk // TypeDefIndex: 48536
	{
		// Fields
		public int startIndex; // 0x00
		public int dataLength; // 0x04
	
		// Properties
		public bool IsValid { get; } // 0x00000001837EDDD0-0x00000001837EDE40 
		public static DataChunk Empty { get; } // 0x00000001866AB4BC-0x00000001866AB4FC 
	
		// Constructors
		public DataChunk(int sindex, int length); // 0x0000000184D85C40-0x0000000184D85C50
		public DataChunk(int sindex); // 0x0000000184D87150-0x0000000184D87160
	
		// Methods
		public void Clear(); // 0x0000000183CF5350-0x0000000183CF5380
		public override string ToString(); // 0x00000001866AB3AC-0x00000001866AB46C
		public string __iFixBaseProxy_ToString(); // 0x00000001866AB46C-0x00000001866AB4BC
	}

	[Serializable]
	public struct ExBitFlag16 // TypeDefIndex: 48537
	{
		// Fields
		public ushort Value; // 0x00
	
		// Constructors
		public ExBitFlag16(ushort initialValue = 0 /* Metadata: 0x0232D080 */); // 0x0000000184D87160-0x0000000184D87170
	
		// Methods
		public void Clear(); // 0x00000001866AB8E4-0x00000001866AB938
		public void SetFlag(ushort flag, bool sw); // 0x00000001866AB940-0x00000001866AB95C
		public bool IsSet(ushort flag); // 0x00000001866AB938-0x00000001866AB940
	}

	[Serializable]
	public struct ExBitFlag8 // TypeDefIndex: 48538
	{
		// Fields
		public byte Value; // 0x00
	
		// Constructors
		public ExBitFlag8(byte initialValue = 0 /* Metadata: 0x0232D082 */); // 0x0000000184D87180-0x0000000184D87190
	
		// Methods
		public void Clear(); // 0x0000000184D87170-0x0000000184D87180
		public void SetFlag(byte flag, bool sw); // 0x00000001866AB964-0x00000001866AB978
		public bool IsSet(byte flag); // 0x00000001866AB95C-0x00000001866AB964
	}

	public struct ExCostSortedList1 : IComparable<ExCostSortedList1> // TypeDefIndex: 48539
	{
		// Fields
		internal float cost; // 0x00
		internal int data; // 0x04
	
		// Properties
		public bool IsValid { get; } // 0x00000001866ABC14-0x00000001866ABC6C 
		public int Count { get; } // 0x00000001866ABB68-0x00000001866ABBC8 
		public float Cost { get; } // 0x00000001866ABB18-0x00000001866ABB68 
		public int Data { get; } // 0x00000001866ABBC8-0x00000001866ABC14 
	
		// Constructors
		public ExCostSortedList1(float invalidCost); // 0x0000000184D871A0-0x0000000184D871B0
		public ExCostSortedList1(float invalidCost, int initData); // 0x0000000184D87190-0x0000000184D871A0
	
		// Methods
		public void Add(float cost, int item); // 0x00000001866A7F60-0x00000001866A7FA4
		public int CompareTo(ExCostSortedList1 other); // 0x00000001866AB978-0x00000001866AB9F8
		public override string ToString(); // 0x00000001866AB9F8-0x00000001866ABAC8
		public string __iFixBaseProxy_ToString(); // 0x00000001866ABAC8-0x00000001866ABB18
	}

	public struct ExCostSortedList4 // TypeDefIndex: 48540
	{
		// Fields
		internal float4 costs; // 0x00
		internal int4 data; // 0x10
	
		// Properties
		public int Count { get; } // 0x00000001866A7FCC-0x00000001866A8230 
		public bool IsValid { get; } // 0x00000001866ABFBC-0x00000001866AC014 
		public float MinCost { get; } // 0x0000000184D871D0-0x0000000184D871E0 
		public float MaxCost { get; } // 0x00000001866AC014-0x00000001866AC034 
	
		// Constructors
		public ExCostSortedList4(float invalidCost); // 0x0000000184D871B0-0x0000000184D871D0
	
		// Methods
		public bool Add(float cost, int item); // 0x00000001866ABC6C-0x00000001866ABD50
		public bool Contains(int item); // 0x00000001866A7FA4-0x00000001866A7FCC
		public int indexOf(int item); // 0x00000001866AC034-0x00000001866AC0BC
		public void RemoveItem(int item); // 0x00000001866ABD50-0x00000001866ABE04
		public override string ToString(); // 0x00000001866ABE04-0x00000001866ABF64
		public string __iFixBaseProxy_ToString(); // 0x00000001866ABF64-0x00000001866ABFBC
	}

	public class ExNativeArray<T> : IDisposable // TypeDefIndex: 48541
		where T : struct
	{
		// Fields
		private NativeArray<T> nativeArray;
		private List<DataChunk> emptyChunks;
		private int useCount;
	
		// Properties
		public bool IsValid { get; }
		public int Length { get; }
		public int Count { get; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public ExNativeArray();
		public ExNativeArray(int emptyLength, bool create = false /* Metadata: 0x0232D083 */);
		public ExNativeArray(int emptyLength, T fillData);
		public ExNativeArray(NativeArray<T> dataArray);
		public ExNativeArray(T[] dataArray);
	
		// Methods
		public void Dispose();
		public DataChunk AddRange(int dataLength);
		public DataChunk AddRange(int dataLength, T fillData = default);
		public DataChunk AddRange(T[] array);
		public DataChunk AddRange(NativeArray<T> narray, int length = 0 /* Metadata: 0x0232D084 */);
		public DataChunk AddRange(ExNativeArray<T> exarray);
		public DataChunk AddRange(ExSimpleNativeArray<T> exarray);
		public DataChunk AddRange<U>(U[] array)
			where U : struct;
		public DataChunk AddRange<U>(NativeArray<U> udata)
			where U : struct;
		public DataChunk AddRangeTypeChange<U>(U[] array)
			where U : struct;
		public DataChunk AddRangeStride<U>(U[] array)
			where U : struct;
		public DataChunk Add(T data);
		public DataChunk Expand(DataChunk c, int newDataLength);
		public DataChunk ExpandAndFill(DataChunk c, int newDataLength, T fillData = default, T clearData = default);
		public T[] ToArray();
		public void CopyTo(T[] array);
		public void CopyTo<U>(U[] array)
			where U : struct;
		public void CopyFrom(NativeArray<T> array);
		public void CopyFrom<U>(NativeArray<U> array)
			where U : struct;
		public void CopyTypeChange<U>(U[] array)
			where U : struct;
		public void CopyTypeChangeStride<U>(U[] array)
			where U : struct;
		public void AddEmpty(int dataLength);
		public void Remove(DataChunk chunk);
		public void Remove(int index);
		public void RemoveAndFill(DataChunk chunk, T clearData = default);
		public void Fill(T fillData = default);
		public void Fill(DataChunk chunk, T fillData = default);
		private void FillInternal(int start, int size, T fillData = default);
		public void Clear();
		public ref ref T GetRef(int index);
		public NativeArray<T> GetNativeArray();
		public NativeArray<U> GetNativeArray<U>()
			where U : struct;
		private DataChunk GetEmptyChunk(int dataLength);
		private void AddEmptyChunk(DataChunk chunk);
		public override string ToString();
		public string ToSummary();
	}

	public class ExProcessingList<T> : IDisposable, IValid // TypeDefIndex: 48542
		where T : struct
	{
		// Fields
		public NativeReference<int> Counter;
		public NativeArray<T> Buffer;
	
		// Constructors
		public ExProcessingList();
	
		// Methods
		public void Dispose();
		public bool IsValid();
		public void UpdateBuffer(int capacity);
		public unsafe int* GetJobSchedulePtr();
		public override string ToString();
	}

	public class ExSimpleNativeArray<T> : IDisposable // TypeDefIndex: 48544
		where T : struct
	{
		// Fields
		private NativeArray<T> nativeArray;
		private int count;
		private int length;
	
		// Properties
		public bool IsValid { get; }
		public int Count { get; }
		public int Length { get; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		[Serializable]
		public class SerializationData // TypeDefIndex: 48543
		{
			// Fields
			public int count;
			public int length;
			public byte[] arrayBytes;
	
			// Constructors
			public SerializationData();
		}
	
		// Constructors
		public ExSimpleNativeArray();
		public ExSimpleNativeArray(int dataLength, bool areaOnly = false /* Metadata: 0x0232D085 */);
		public ExSimpleNativeArray(T[] dataArray);
		public ExSimpleNativeArray(NativeArray<T> array);
		public ExSimpleNativeArray(NativeList<T> array);
		public ExSimpleNativeArray(SerializationData sdata);
	
		// Methods
		public void Dispose();
		public void SetCount(int newCount);
		public void SetLength(int newLength);
		public void AddRange(int dataLength);
		public void AddRange(T[] dataArray);
		public void AddRange(T[] dataArray, int cnt);
		public void AddRange(int dataLength, T fillData = default);
		public void AddRange(NativeArray<T> narray);
		public void AddRange(NativeList<T> nlist);
		public void AddRange(ExSimpleNativeArray<T> exarray);
		public void AddRange<U>(U[] array)
			where U : struct;
		public void AddRangeTypeChange<U>(U[] array)
			where U : struct;
		public void AddRangeTypeChange<U>(NativeArray<U> array)
			where U : struct;
		public void AddRangeStride<U>(U[] array)
			where U : struct;
		public void Add(T data);
		public T[] ToArray();
		public void CopyTo(T[] array);
		public void CopyTo<U>(U[] array)
			where U : struct;
		public void CopyToWithTypeChange<U>(U[] array)
			where U : struct;
		public void CopyToWithTypeChangeStride<U>(U[] array)
			where U : struct;
		public void CopyFrom(NativeArray<T> array);
		public void CopyFrom<U>(NativeArray<U> array)
			where U : struct;
		public void CopyFromWithTypeChangeStride<U>(NativeArray<U> array)
			where U : struct;
		public void Fill(int startIndex, int dataLength, T fillData = default);
		private void FillInternal(int start, int size, T fillData = default);
		public NativeArray<T> GetNativeArray();
		public NativeArray<U> GetNativeArray<U>()
			where U : struct;
		private void Expand(int dataLength, bool force = false /* Metadata: 0x0232D086 */, bool copy = true /* Metadata: 0x0232D087 */);
		public override string ToString();
		public SerializationData Serialize();
		public bool Deserialize(SerializationData data);
	}

	public class ExTransformAccessArray : IDisposable // TypeDefIndex: 48545
	{
		// Fields
		private TransformAccessArray transformArray; // 0x10
		private int nativeLength; // 0x18
		private Queue<int> emptyStack; // 0x20
		private Dictionary<int, int> useIndexDict; // 0x28
		private Dictionary<int, int> indexDict; // 0x30
		private Dictionary<int, int> referenceDict; // 0x38
	
		// Properties
		public int Count { get; } // 0x00000001866ACB84-0x00000001866ACBF8 
		public int Length { get; } // 0x00000001866ACC5C-0x00000001866ACCA8 
		public Transform this[int index] { get => default; } // 0x00000001866ACBF8-0x00000001866ACC5C 
	
		// Constructors
		public ExTransformAccessArray(int capacity, int desiredJobCount = -1 /* Metadata: 0x0232D088 */); // 0x00000001866ACA18-0x00000001866ACB84
	
		// Methods
		public void Dispose(); // 0x00000001866AC4FC-0x00000001866AC5D8
		public TransformAccessArray GetTransformAccessArray(); // 0x00000001866AC818-0x00000001866AC868
		public int Add(Transform element); // 0x00000001866AC0BC-0x00000001866AC2C8
		public void Remove(int index); // 0x00000001866AC868-0x00000001866ACA18
		[IDTag(0)]
		public bool Exist(int index); // 0x00000001866AC5D8-0x00000001866AC660
		[IDTag(1)]
		public bool Exist(Transform element); // 0x00000001866AC660-0x00000001866AC728
		public int GetIndex(Transform element); // 0x00000001866AC728-0x00000001866AC818
		public void Clear(); // 0x00000001866AC2C8-0x00000001866AC4FC
	}

	public static class FixedList128BytesExtensions // TypeDefIndex: 48546
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Set<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2SetLimit<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2Push<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Pop<T>(this ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Enqueue<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Dequque<T>(this ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
	}

	public static class FixedList32BytesExtensions // TypeDefIndex: 48547
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Set<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2SetLimit<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2Push<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Pop<T>(this ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Enqueue<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Dequque<T>(this ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
	}

	public static class FixedList4096BytesExtensions // TypeDefIndex: 48548
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Set<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2SetLimit<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2Push<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Pop<T>(this ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Enqueue<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Dequque<T>(this ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
	}

	public static class FixedList512BytesExtensions // TypeDefIndex: 48549
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Set<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2SetLimit<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2Push<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Pop<T>(this ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Enqueue<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Dequque<T>(this ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
	}

	public static class FixedList64BytesExtensions // TypeDefIndex: 48550
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Set<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2SetLimit<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static void MC2Push<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Pop<T>(this ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
		public static void MC2Enqueue<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T>;
		public static T MC2Dequque<T>(this ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T>;
	}

	public static class NativeArrayExtensions // TypeDefIndex: 48551
	{
		// Methods
		public static NativeArray<T> MC2FromRawBytes<T>(byte[] bytes, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232D08B */)
			where T : struct;
	
		// Extension methods
		public static void MC2DisposeSafe<T>(this ref NativeArray<T> array)
			where T : struct;
		public static void MC2Resize<T>(this ref NativeArray<T> array, int size, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0232D089 */, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x0232D08A */)
			where T : struct;
		public static byte[] MC2ToRawBytes<T>(this ref NativeArray<T> array)
			where T : struct;
	}

	public static class NativeMultiHashMapExtensions // TypeDefIndex: 48553
	{
		// Nested types
		[BurstCompile]
		private struct SetParallelMultiHashMapJob<TKey, TValue> : IJob // TypeDefIndex: 48552
			where TKey : struct, IEquatable<TKey>
			where TValue : struct
		{
			// Fields
			public NativeParallelMultiHashMap<TKey, TValue> map;
			[ReadOnly]
			public NativeArray<TKey> keyArray;
			[ReadOnly]
			public NativeArray<TValue> valueArray;
	
			// Methods
			public void Execute();
		}
	
		// Methods
		public static NativeParallelMultiHashMap<int2, ushort> MC2Deserialize(int2[] keyArray, ushort[] valueArray); // 0x0000000183E8F7A0-0x0000000183E8FA80
	
		// Extension methods
		public static bool MC2Contains<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue>;
		public static void MC2UniqueAdd<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue>;
		public static bool MC2RemoveValue<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue>;
		public static FixedList512Bytes<TValue> MC2ToFixedList512Bytes<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue>;
		public static FixedList128Bytes<TValue> MC2ToFixedList128Bytes<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue>;
		public static ValueTuple<TKey[], TValue[]> MC2Serialize<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct;
		public static void MC2DisposeSafe<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue>;
	}

	public static class NativeParallelHashMap // TypeDefIndex: 48554
	{
		// Extension methods
		public static void MC2DisposeSafe<TKey, TValue>(this ref NativeParallelHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue>;
	}

	internal static class NativeReferenceExtensions // TypeDefIndex: 48555
	{
		// Methods
		public static unsafe int MC2InterlockedStartIndex(int* cntPt, int dataCount); // 0x0000000184D872A0-0x0000000184D872B0
	
		// Extension methods
		public static int MC2InterlockedStartIndex(this ref NativeReference<int> counter, int dataCount); // 0x00000001866B3240-0x00000001866B32BC
	}

	public class PlayerLoopUtils // TypeDefIndex: 48557
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 48556
		{
			// Fields
			public string categoryName; // 0x10
			public string systemName; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _AddPlayerLoop_b__0(PlayerLoopSystem s); // 0x00000001846448E0-0x0000000184644920
			internal bool _AddPlayerLoop_b__1(PlayerLoopSystem h); // 0x0000000184521ED0-0x0000000184521F10
		}
	
		// Constructors
		public PlayerLoopUtils(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void AddPlayerLoop(PlayerLoopSystem method, ref PlayerLoopSystem playerLoop, string categoryName, string systemName, bool last = false /* Metadata: 0x0232D08C */, bool before = false /* Metadata: 0x0232D08D */); // 0x0000000183325090-0x00000001833253F0
	}

	[Serializable]
	public class MagicaClothProcessingException : Exception // TypeDefIndex: 48558
	{
		// Constructors
		public MagicaClothProcessingException(); // 0x00000001866AD57C-0x00000001866AD5C8
		public MagicaClothProcessingException(string message); // 0x00000001866AD628-0x00000001866AD684
		public MagicaClothProcessingException(string message, Exception inner); // 0x00000001866AD5C8-0x00000001866AD628
	}

	[Serializable]
	public class MagicaClothCanceledException : Exception // TypeDefIndex: 48559
	{
		// Constructors
		public MagicaClothCanceledException(); // 0x00000001866AD4D4-0x00000001866AD520
		public MagicaClothCanceledException(string message); // 0x00000001866AD520-0x00000001866AD57C
		public MagicaClothCanceledException(string message, Exception inner); // 0x00000001866AD474-0x00000001866AD4D4
	}

	[Serializable]
	public struct ResultCode // TypeDefIndex: 48560
	{
		// Fields
		[SerializeField]
		private Define.Result result; // 0x00
		[SerializeField]
		private Define.Result warning; // 0x04
	
		// Properties
		public Define.Result Result { get; } // 0x00000001866B3A84-0x00000001866B3AD0 
		public static ResultCode None { get; } // 0x00000001866B3A30-0x00000001866B3A84 
		public static ResultCode Empty { get; } // 0x00000001840FB030-0x00000001840FB070 
		public static ResultCode Success { get; } // 0x0000000183E8EDC0-0x0000000183E8EE00 
		public static ResultCode Error { get; } // 0x00000001866B39D4-0x00000001866B3A30 
	
		// Constructors
		public ResultCode(Define.Result initResult); // 0x0000000184D872B0-0x0000000184D872D0
	
		// Methods
		public void Clear(); // 0x0000000183E92320-0x0000000183E92360
		public void SetResult(Define.Result code); // 0x000000018308CCF0-0x000000018308CD30
		public void SetSuccess(); // 0x000000018308CCB0-0x000000018308CCF0
		public void SetCancel(); // 0x00000001866B38C8-0x00000001866B3920
		public void SetError(Define.Result code = Define.Result.Error /* Metadata: 0x0232D08E */); // 0x00000001866B3920-0x00000001866B3978
		public void SetWarning(Define.Result code = Define.Result.Warning /* Metadata: 0x0232D092 */); // 0x00000001866B3978-0x00000001866B39D4
		public void Merge(ResultCode src); // 0x000000018453A6F0-0x000000018453A750
		public void SetProcess(); // 0x000000018308CC70-0x000000018308CCB0
		public bool IsResult(Define.Result code); // 0x00000001866B3868-0x00000001866B38C8
		public bool IsNone(); // 0x00000001866B3760-0x00000001866B37B8
		public bool IsSuccess(); // 0x000000018308D070-0x000000018308D0B0
		public bool IsFaild(); // 0x000000018308D030-0x000000018308D070
		public bool IsCancel(); // 0x00000001866B3708-0x00000001866B3760
		public bool IsNormal(); // 0x00000001866B37B8-0x00000001866B3810
		public bool IsError(); // 0x0000000183CFCB30-0x0000000183CFCB70
		public bool IsProcess(); // 0x00000001866B3810-0x00000001866B3868
		public bool IsWarning(); // 0x000000018453A750-0x000000018453A790
		public string GetResultString(); // 0x00000001866B3484-0x00000001866B3594
		public string GetWarningString(); // 0x00000001866B3634-0x00000001866B3708
		public string GetResultInformation(); // 0x00000001866B3348-0x00000001866B3484
		public string GetWarningInformation(); // 0x00000001866B3594-0x00000001866B3634
		[Conditional("MC2_DEBUG")]
		public void DebugLog(bool error = true /* Metadata: 0x0232D096 */, bool warning = true /* Metadata: 0x0232D097 */, bool normal = true /* Metadata: 0x0232D098 */); // 0x00000001866B32BC-0x00000001866B3348
	}

	public class TimeSpan // TypeDefIndex: 48561
	{
		// Fields
		private string name; // 0x10
		private System.DateTime stime; // 0x18
		private System.DateTime etime; // 0x20
	
		// Constructors
		public TimeSpan(); // 0x00000001866B4430-0x00000001866B4478
		public TimeSpan(string name); // 0x00000001866B4478-0x00000001866B4500
	
		// Methods
		public void Start(); // 0x00000001866B4184-0x00000001866B4200
		public void Finish(); // 0x00000001866B40B0-0x00000001866B412C
		public double TotalSeconds(); // 0x00000001866B4370-0x00000001866B4430
		public double TotalMilliSeconds(); // 0x00000001866B42B0-0x00000001866B4370
		public override string ToString(); // 0x00000001866B4200-0x00000001866B42B0
		public void DebugLog(); // 0x00000001866B406C-0x00000001866B40B0
		public void Log(); // 0x00000001866B412C-0x00000001866B4184
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public class UnityTimeSpan // TypeDefIndex: 48562
	{
		// Fields
		private string name; // 0x10
		private float stime; // 0x18
		private float etime; // 0x1C
		private bool isFinish; // 0x20
	
		// Constructors
		public UnityTimeSpan(string name); // 0x00000001866B474C-0x00000001866B47BC
	
		// Methods
		public void Finish(); // 0x00000001866B457C-0x00000001866B45DC
		public float TotalSeconds(); // 0x00000001866B46F0-0x00000001866B474C
		public float TotalMilliSeconds(); // 0x00000001866B468C-0x00000001866B46F0
		public override string ToString(); // 0x00000001866B45DC-0x00000001866B468C
		public void DebugLog(); // 0x00000001866B4500-0x00000001866B457C
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	public class VirtualMesh : IDisposable, IValid // TypeDefIndex: 48620
	{
		// Fields
		public string name; // 0x10
		public ResultCode result; // 0x18
		public bool isManaged; // 0x20
		public MeshType meshType; // 0x24
		public bool isBoneCloth; // 0x28
		public ExSimpleNativeArray<int> referenceIndices; // 0x30
		public ExSimpleNativeArray<VertexAttribute> attributes; // 0x38
		public ExSimpleNativeArray<float3> localPositions; // 0x40
		public ExSimpleNativeArray<float3> localNormals; // 0x48
		public ExSimpleNativeArray<float3> localTangents; // 0x50
		public ExSimpleNativeArray<float2> uv; // 0x58
		public ExSimpleNativeArray<VirtualMeshBoneWeight> boneWeights; // 0x60
		public ExSimpleNativeArray<int3> triangles; // 0x68
		public ExSimpleNativeArray<int2> lines; // 0x70
		public int centerTransformIndex; // 0x78
		public float4x4 initLocalToWorld; // 0x7C
		public float4x4 initWorldToLocal; // 0xBC
		public quaternion initRotation; // 0xFC
		public quaternion initInverseRotation; // 0x10C
		public float3 initScale; // 0x11C
		public int skinRootIndex; // 0x128
		public ExSimpleNativeArray<int> skinBoneTransformIndices; // 0x130
		public ExSimpleNativeArray<float4x4> skinBoneBindPoses; // 0x138
		public BeyondDynamicBone.TransformData transformData; // 0x140
		public NativeReference<AABB> boundingBox; // 0x148
		public NativeReference<float> averageVertexDistance; // 0x158
		public NativeReference<float> maxVertexDistance; // 0x168
		public DataChunk mergeChunk; // 0x178
		public NativeArray<int> joinIndices; // 0x180
		public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x190
		public NativeArray<uint> vertexToVertexIndexArray; // 0x1A0
		public NativeArray<ushort> vertexToVertexDataArray; // 0x1B0
		public NativeArray<int2> edges; // 0x1C0
		public const byte EdgeFlag_Cut = 1; // Metadata: 0x0232D09D
		public NativeArray<ExBitFlag8> edgeFlags; // 0x1D0
		public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x1E0
		public NativeArray<float3> vertexBindPosePositions; // 0x1F0
		public NativeArray<quaternion> vertexBindPoseRotations; // 0x200
		public NativeArray<quaternion> vertexToTransformRotations; // 0x210
		public NativeArray<float> vertexDepths; // 0x220
		public NativeArray<int> vertexRootIndices; // 0x230
		public NativeArray<int> vertexParentIndices; // 0x240
		public NativeArray<uint> vertexChildIndexArray; // 0x250
		public NativeArray<ushort> vertexChildDataArray; // 0x260
		public NativeArray<float3> vertexLocalPositions; // 0x270
		public NativeArray<quaternion> vertexLocalRotations; // 0x280
		public NativeArray<quaternion> normalAdjustmentRotations; // 0x290
		public const byte BaseLineFlag_IncludeLine = 1; // Metadata: 0x0232D09E
		public NativeArray<ExBitFlag8> baseLineFlags; // 0x2A0
		public NativeArray<ushort> baseLineStartDataIndices; // 0x2B0
		public NativeArray<ushort> baseLineDataCounts; // 0x2C0
		public NativeArray<ushort> baseLineData; // 0x2D0
		public int[] customSkinningBoneIndices; // 0x2E0
		public ushort[] centerFixedList; // 0x2E8
		public NativeReference<float3> localCenterPosition; // 0x2F0
		public VirtualMesh mappingProxyMesh; // 0x300
		public float3 centerWorldPosition; // 0x308
		public quaternion centerWorldRotation; // 0x314
		public float3 centerWorldScale; // 0x324
		public float4x4 toProxyMatrix; // 0x330
		public quaternion toProxyRotation; // 0x370
		public int mappingId; // 0x380
	
		// Properties
		public float InitCalcScale { get; } // 0x00000001866BF49C-0x00000001866BF4F0 
		public bool IsSuccess { get; } // 0x00000001866BF5F4-0x00000001866BF648 
		public bool IsError { get; } // 0x0000000183CFCAF0-0x0000000183CFCB30 
		public bool IsProcess { get; } // 0x00000001866BF540-0x00000001866BF594 
		public int VertexCount { get; } // 0x0000000183CFCA70-0x0000000183CFCAB0 
		public int TriangleCount { get; } // 0x0000000183CFAD70-0x0000000183CFADB0 
		public int LineCount { get; } // 0x0000000183CFAD10-0x0000000183CFAD70 
		public int SkinBoneCount { get; } // 0x00000001866BF6C8-0x00000001866BF73C 
		public int TransformCount { get; } // 0x0000000183CF7860-0x0000000183CF78A0 
		public bool IsProxy { get; } // 0x00000001866BF594-0x00000001866BF5F4 
		public bool IsMapping { get; } // 0x00000001866BF4F0-0x00000001866BF540 
		public int BaseLineCount { get; } // 0x0000000183CF9B60-0x0000000183CF9BC0 
		public int EdgeCount { get; } // 0x0000000183CFCAB0-0x0000000183CFCAF0 
		public int CustomSkinningBoneCount { get; } // 0x00000001866BF43C-0x00000001866BF49C 
		public int CenterFixedPointCount { get; } // 0x0000000183E8CA90-0x0000000183E8CAD0 
		public int NormalAdjustmentRotationCount { get; } // 0x00000001866BF648-0x00000001866BF6C8 
	
		// Nested types
		[BurstCompile]
		private struct Import_GenerateTangentJob : IJobParallelFor // TypeDefIndex: 48563
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> localNormals; // 0x00
			[WriteOnly]
			public NativeArray<float3> localTangents; // 0x10
	
			// Methods
			public void Execute(int vindex); // 0x00000001866F9828-0x00000001866F9968
		}
	
		[BurstCompile]
		private struct Import_CalcSkinningJob : IJobParallelFor // TypeDefIndex: 48564
		{
			// Fields
			public NativeArray<float3> localPositions; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<float3> localTangents; // 0x20
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x30
			[ReadOnly]
			public NativeArray<int> skinBoneTransformIndices; // 0x40
			[ReadOnly]
			public NativeArray<float4x4> bindPoses; // 0x50
			[ReadOnly]
			public NativeArray<float3> transformPositionArray; // 0x60
			[ReadOnly]
			public NativeArray<quaternion> transformRotationArray; // 0x70
			[ReadOnly]
			public NativeArray<float3> transformScaleArray; // 0x80
			public float4x4 toM; // 0x90
	
			// Methods
			public void Execute(int vindex); // 0x00000001866F9264-0x00000001866F9828
		}
	
		[BurstCompile]
		private struct Import_BoneWeightJob1 : IJob // TypeDefIndex: 48565
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			[WriteOnly]
			public NativeArray<int> startBoneWeightIndices; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001866F90EC-0x00000001866F9164
		}
	
		[BurstCompile]
		private struct Import_BoneWeightJob2 : IJobParallelFor // TypeDefIndex: 48566
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> startBoneWeightIndices; // 0x00
			[ReadOnly]
			public NativeArray<BoneWeight1> boneWeightArray; // 0x10
			[ReadOnly]
			public NativeArray<byte> bonesPerVertexArray; // 0x20
			[WriteOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x30
	
			// Methods
			public void Execute(int vindex); // 0x00000001866F9164-0x00000001866F9264
		}
	
		[BurstCompile]
		private struct Import_BoneVertexJob : IJobParallelFor // TypeDefIndex: 48567
		{
			// Fields
			public float4x4 WtoL; // 0x00
			public float4x4 LtoW; // 0x40
			[ReadOnly]
			public NativeArray<float3> transformPositions; // 0x80
			[ReadOnly]
			public NativeArray<quaternion> transformRotations; // 0x90
			[ReadOnly]
			public NativeArray<float3> transformScales; // 0xA0
			[WriteOnly]
			public NativeArray<float3> localPositions; // 0xB0
			[WriteOnly]
			public NativeArray<float3> localNormals; // 0xC0
			[WriteOnly]
			public NativeArray<float3> localTangents; // 0xD0
			[WriteOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0xE0
			[WriteOnly]
			public NativeArray<float4x4> skinBoneBindPoses; // 0xF0
	
			// Methods
			public void Execute(int vindex); // 0x000000018308A320-0x000000018308A880
		}
	
		[BurstCompile]
		private struct Select_PackVertexJob : IJob // TypeDefIndex: 48568
		{
			// Fields
			public int vertexCount; // 0x00
			[ReadOnly]
			public NativeArray<int> newVertexRemapIndices; // 0x08
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x18
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x28
			[ReadOnly]
			public NativeArray<float3> localNormals; // 0x38
			[ReadOnly]
			public NativeArray<float3> localTangents; // 0x48
			[ReadOnly]
			public NativeArray<float2> uv; // 0x58
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x68
			[WriteOnly]
			public NativeArray<int> newReferenceIndices; // 0x78
			[WriteOnly]
			public NativeArray<VertexAttribute> newAttributes; // 0x88
			[WriteOnly]
			public NativeArray<float3> newLocalPositions; // 0x98
			[WriteOnly]
			public NativeArray<float3> newLocalNormals; // 0xA8
			[WriteOnly]
			public NativeArray<float3> newLocalTangents; // 0xB8
			[WriteOnly]
			public NativeArray<float2> newUv; // 0xC8
			[WriteOnly]
			public NativeArray<VirtualMeshBoneWeight> newBoneWeights; // 0xD8
	
			// Methods
			public void Execute(); // 0x00000001866FE930-0x00000001866FEAB4
		}
	
		[BurstCompile]
		private struct Select_GridJob : IJob // TypeDefIndex: 48569
		{
			// Fields
			public float gridSize; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x08
			public int selectionCount; // 0x18
			[ReadOnly]
			public NativeArray<float3> selectionPositions; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> selectionAttributes; // 0x30
			public int vertexCount; // 0x40
			public int triangleCount; // 0x44
			public float searchRadius; // 0x48
			[ReadOnly]
			public NativeArray<float3> meshPositions; // 0x50
			[ReadOnly]
			public NativeArray<int3> meshTriangles; // 0x60
			public NativeList<int3> newTriangles; // 0x70
			public NativeArray<int> newVertexRemapIndices; // 0x80
			[WriteOnly]
			public NativeReference<int> newVertexCount; // 0x90
	
			// Methods
			public void Execute(); // 0x00000001866FE2E0-0x00000001866FE930
		}
	
		[BurstCompile]
		private struct Add_CalcBindPoseJob : IJobParallelFor // TypeDefIndex: 48570
		{
			// Fields
			public int skinBoneOffset; // 0x00
			[ReadOnly]
			public NativeArray<int> srcSkinBoneTransformIndices; // 0x08
			[ReadOnly]
			public NativeArray<float3> srcTransformPositionArray; // 0x18
			[ReadOnly]
			public NativeArray<quaternion> srcTransformRotationArray; // 0x28
			[ReadOnly]
			public NativeArray<float3> srcTransformScaleArray; // 0x38
			public float4x4 dstCenterLocalToWorldMatrix; // 0x48
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float4x4> dstSkinBoneBindPoses; // 0x88
	
			// Methods
			public void Execute(int boneIndex); // 0x00000001866F7DBC-0x00000001866F7F50
		}
	
		[BurstCompile]
		private struct Add_CopyVerticesJob : IJobParallelFor // TypeDefIndex: 48571
		{
			// Fields
			public int vertexOffset; // 0x00
			public int skinBoneOffset; // 0x04
			public float4x4 toM; // 0x08
			[ReadOnly]
			public NativeArray<VertexAttribute> srcAttributes; // 0x48
			[ReadOnly]
			public NativeArray<float3> srclocalPositions; // 0x58
			[ReadOnly]
			public NativeArray<float3> srclocalNormals; // 0x68
			[ReadOnly]
			public NativeArray<float3> srclocalTangents; // 0x78
			[ReadOnly]
			public NativeArray<float2> srcUV; // 0x88
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> srcBoneWeights; // 0x98
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<VertexAttribute> dstAttributes; // 0xA8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> dstlocalPositions; // 0xB8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> dstlocalNormals; // 0xC8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> dstlocalTangents; // 0xD8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float2> dstUV; // 0xE8
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<VirtualMeshBoneWeight> dstBoneWeights; // 0xF8
			[ReadOnly]
			public NativeArray<int> dstSkinBoneIndices; // 0x108
	
			// Methods
			public void Execute(int vindex); // 0x00000001866F7F50-0x00000001866F81B4
		}
	
		private struct MappingWorkData // TypeDefIndex: 48572
		{
			// Fields
			public float3 position; // 0x00
			public int vertexIndex; // 0x0C
			public int proxyVertexIndex; // 0x10
			public float proxyVertexDistance; // 0x14
		}
	
		[BurstCompile]
		private struct Mapping_DirectConnectionVertexDataJob : IJob // TypeDefIndex: 48573
		{
			// Fields
			public float4x4 toP; // 0x00
			public int vcnt; // 0x40
			public DataChunk mergeChunk; // 0x44
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x50
			[WriteOnly]
			public NativeArray<VertexAttribute> attributes; // 0x60
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x70
			[ReadOnly]
			public NativeArray<VertexAttribute> proxyAttributes; // 0x80
			[ReadOnly]
			public NativeArray<float3> proxyLocalPositions; // 0x90
			[WriteOnly]
			public NativeArray<MappingWorkData> mappingWorkData; // 0xA0
	
			// Methods
			public void Execute(); // 0x00000001866FAA14-0x00000001866FABF0
		}
	
		private struct Mapping_CalcDirectWeightJob : IJob // TypeDefIndex: 48574
		{
			// Fields
			public int vcnt; // 0x00
			public float weightLength; // 0x04
			[ReadOnly]
			public NativeArray<MappingWorkData> mappingWorkData; // 0x08
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x18
			[WriteOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x28
			[ReadOnly]
			public NativeArray<float3> proxyLocalPositions; // 0x38
			[ReadOnly]
			public NativeArray<uint> proxyVertexToVertexIndexArray; // 0x48
			[ReadOnly]
			public NativeArray<ushort> proxyVertexToVertexDataArray; // 0x58
			public NativeParallelHashSet<ushort> useSet; // 0x68
	
			// Methods
			public void Execute(); // 0x00000001866FA0A4-0x00000001866FA5C0
		}
	
		[BurstCompile]
		private struct Mapping_CalcConnectionVertexDataJob : IJob // TypeDefIndex: 48575
		{
			// Fields
			public float gridSize; // 0x00
			public float searchRadius; // 0x04
			public float4x4 toP; // 0x08
			public int vcnt; // 0x48
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x50
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x60
			[ReadOnly]
			public NativeArray<int> transformIds; // 0x70
			[WriteOnly]
			public NativeArray<VertexAttribute> attributes; // 0x80
			[ReadOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x90
			[ReadOnly]
			public NativeArray<VertexAttribute> proxyAttributes; // 0xA0
			[ReadOnly]
			public NativeArray<float3> proxyLocalPositions; // 0xB0
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> proxyBoneWeights; // 0xC0
			[ReadOnly]
			public NativeArray<int> proxyTransformIds; // 0xD0
			[WriteOnly]
			public NativeArray<MappingWorkData> mappingWorkData; // 0xE0
	
			// Methods
			public void Execute(); // 0x00000001866F9968-0x00000001866FA0A4
		}
	
		[BurstCompile]
		private struct Mapping_CalcWeightJob : IJobParallelFor // TypeDefIndex: 48576
		{
			// Fields
			[ReadOnly]
			public NativeArray<MappingWorkData> mappingWorkData; // 0x00
			public NativeArray<VertexAttribute> attributes; // 0x10
			[WriteOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
			[ReadOnly]
			public NativeArray<VertexAttribute> proxyAttributes; // 0x30
			[ReadOnly]
			public NativeArray<float3> proxyLocalPositions; // 0x40
			[ReadOnly]
			public NativeArray<float3> proxyLocalNormals; // 0x50
			[ReadOnly]
			public NativeArray<uint> proxyVertexToVertexIndexArray; // 0x60
			[ReadOnly]
			public NativeArray<ushort> proxyVertexToVertexDataArray; // 0x70
	
			// Methods
			public void Execute(int vindex); // 0x00000001866FA5C0-0x00000001866FAA14
		}
	
		[BurstCompile]
		private struct Optimize_EdgeToTrianlgeJob : IJob // TypeDefIndex: 48577
		{
			// Fields
			public int tcnt; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x18
			public NativeParallelHashMap<int2, FixedList128Bytes<int>> edgeToTriangleList; // 0x28
			[WriteOnly]
			public NativeList<int3> newTriangles; // 0x38
			public NativeParallelHashSet<int4> useQuadSet; // 0x48
			public NativeParallelHashSet<int3> removeTriangleSet; // 0x58
	
			// Methods
			public void Execute(); // 0x00000001866FABF0-0x00000001866FB7C8
		}
	
		[BurstCompile]
		private struct ProxyNormalRadiationAdjustmentJob : IJobParallelFor // TypeDefIndex: 48578
		{
			// Fields
			public double3 center; // 0x00
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x18
			[ReadOnly]
			public NativeArray<int> vertexParentIndices; // 0x28
			[ReadOnly]
			public NativeArray<uint> vertexChildIndexArray; // 0x38
			[ReadOnly]
			public NativeArray<ushort> vertexChildDataArray; // 0x48
			public NativeArray<float3> localNormals; // 0x58
			public NativeArray<float3> localTangents; // 0x68
			[WriteOnly]
			public NativeArray<quaternion> normalAdjustmentRotations; // 0x78
	
			// Methods
			public void Execute(int vindex); // 0x00000001866FC67C-0x00000001866FCC84
		}
	
		[BurstCompile]
		private struct ProxyCreateFixedListAndAABBJob : IJob // TypeDefIndex: 48579
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x08
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x18
			[ReadOnly]
			public NativeArray<uint> vertexToVertexIndexArray; // 0x28
			[ReadOnly]
			public NativeArray<ushort> vertexToVertexDataArray; // 0x38
			[WriteOnly]
			public NativeReference<AABB> outAABB; // 0x48
			[WriteOnly]
			public NativeList<ushort> fixedList; // 0x58
			[WriteOnly]
			public NativeReference<float3> localCenterPosition; // 0x68
	
			// Methods
			public void Execute(); // 0x000000018415F270-0x000000018415F7C0
		}
	
		[BurstCompile]
		private struct Proxy_CalcTriangleNormalJob : IJobParallelFor // TypeDefIndex: 48580
		{
			// Fields
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x00
			[ReadOnly]
			public NativeArray<float3> localPositins; // 0x10
			[WriteOnly]
			public NativeArray<float3> triangleNormals; // 0x20
	
			// Methods
			public void Execute(int tindex); // 0x00000001866FD0FC-0x00000001866FD264
		}
	
		[BurstCompile]
		private struct Proxy_CalcTriangleTangentJob : IJobParallelFor // TypeDefIndex: 48581
		{
			// Fields
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x00
			[ReadOnly]
			public NativeArray<float3> localPositins; // 0x10
			[ReadOnly]
			public NativeArray<float2> uv; // 0x20
			[WriteOnly]
			public NativeArray<float3> triangleTangents; // 0x30
	
			// Methods
			public void Execute(int tindex); // 0x00000001866FD264-0x00000001866FD3C4
		}
	
		[BurstCompile]
		private struct Proxy_CreateVertexToTrianglesJob : IJob // TypeDefIndex: 48582
		{
			// Fields
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x00
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x10
	
			// Methods
			public void Execute(); // 0x00000001866FD8AC-0x00000001866FDA00
		}
	
		[BurstCompile]
		private struct Proxy_OrganizeVertexToTrianglsJob : IJobParallelFor // TypeDefIndex: 48583
		{
			// Fields
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x00
			[ReadOnly]
			public NativeArray<float3> triangleNormals; // 0x10
			[ReadOnly]
			public NativeArray<float3> triangleTangents; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
	
			// Methods
			public void Execute(int vindex); // 0x00000001866FDA00-0x00000001866FE180
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexNormalTangentFromTriangleJob : IJobParallelFor // TypeDefIndex: 48584
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> triangleNormals; // 0x00
			[ReadOnly]
			public NativeArray<float3> triangleTangents; // 0x10
			[ReadOnly]
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x20
			public NativeArray<float3> localNormals; // 0x30
			public NativeArray<float3> localTangents; // 0x40
	
			// Methods
			public void Execute(int vindex); // 0x00000001866FD3C4-0x00000001866FD6C0
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToTransformJob : IJobParallelFor // TypeDefIndex: 48585
		{
			// Fields
			public quaternion invRot; // 0x00
			[ReadOnly]
			public NativeArray<float3> localNormals; // 0x10
			[ReadOnly]
			public NativeArray<float3> localTangents; // 0x20
			[WriteOnly]
			public NativeArray<quaternion> vertexToTransformRotations; // 0x30
			[ReadOnly]
			public NativeArray<quaternion> transformRotations; // 0x40
	
			// Methods
			public void Execute(int vindex); // 0x0000000183F48550-0x0000000183F486A0
		}
	
		[BurstCompile]
		private struct Proxy_CalcEdgeToTriangleJob : IJob // TypeDefIndex: 48586
		{
			// Fields
			public int tcnt; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001866FCFA8-0x00000001866FD0FC
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexBindPoseJob2 : IJobParallelFor // TypeDefIndex: 48587
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x00
			[ReadOnly]
			public NativeArray<float3> localNormals; // 0x10
			[ReadOnly]
			public NativeArray<float3> localTangents; // 0x20
			[WriteOnly]
			public NativeArray<float3> vertexBindPosePositions; // 0x30
			[WriteOnly]
			public NativeArray<quaternion> vertexBindPoseRotations; // 0x40
	
			// Methods
			public void Execute(int vindex); // 0x0000000183F48320-0x0000000183F48480
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToVertexFromTriangleJob : IJob // TypeDefIndex: 48588
		{
			// Fields
			public int triangleCount; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<int, ushort> vertexToVertexMap; // 0x18
			public NativeParallelHashSet<int2> edgeSet; // 0x28
	
			// Methods
			public void Execute(); // 0x00000001866FD6C0-0x00000001866FD8AC
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToVertexFromLineJob : IJob // TypeDefIndex: 48589
		{
			// Fields
			public int lineCount; // 0x00
			[ReadOnly]
			public NativeArray<int2> lines; // 0x08
			public NativeParallelMultiHashMap<int, ushort> vertexToVertexMap; // 0x18
			public NativeParallelHashSet<int2> edgeSet; // 0x28
	
			// Methods
			public void Execute(); // 0x00000001843CEF20-0x00000001843CF030
		}
	
		[BurstCompile]
		private struct Proxy_CreateEdgeFlagJob : IJobParallelFor // TypeDefIndex: 48590
		{
			// Fields
			[ReadOnly]
			public NativeArray<int2> edges; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x10
			[WriteOnly]
			public NativeArray<ExBitFlag8> edgeFlags; // 0x20
	
			// Methods
			public void Execute(int eindex); // 0x0000000183F48740-0x0000000183F487B0
		}
	
		private struct SkinningBoneInfo // TypeDefIndex: 48591
		{
			// Fields
			public int parentTransformIndex; // 0x00
			public float3 parentPos; // 0x04
			public int childTransformIndex; // 0x10
			public float3 childPos; // 0x14
		}
	
		[BurstCompile]
		private struct Proxy_CalcCustomSkinningWeightsJobV2 : IJobParallelFor // TypeDefIndex: 48592
		{
			// Fields
			public bool isBoneCloth; // 0x00
			public float angularAttenuation; // 0x04
			public float distanceReduction; // 0x08
			public float distancePow; // 0x0C
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x10
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x20
			[ReadOnly]
			public NativeList<SkinningBoneInfo> boneInfoList; // 0x30
			[WriteOnly]
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x40
	
			// Methods
			public void Execute(int vindex); // 0x00000001866FCC84-0x00000001866FCFA8
		}
	
		[BurstCompile]
		private struct Proxy_ApplySelectionJob : IJobParallelFor // TypeDefIndex: 48593
		{
			// Fields
			public float gridSize; // 0x00
			public float radius; // 0x04
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x08
			public NativeArray<VertexAttribute> attributes; // 0x18
			[ReadOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x28
			[ReadOnly]
			public NativeArray<float3> selectionPositions; // 0x38
			[ReadOnly]
			public NativeArray<VertexAttribute> selectionAttributes; // 0x48
	
			// Methods
			public void Execute(int vindex); // 0x00000001834C83A0-0x00000001834C8E90
		}
	
		[BurstCompile]
		private struct Proxy_BoneClothApplayTransformFlagJob : IJobParallelFor // TypeDefIndex: 48594
		{
			// Fields
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x00
			public NativeArray<ExBitFlag8> transformFlags; // 0x10
	
			// Methods
			public void Execute(int vindex); // 0x00000001833A75B0-0x00000001833A7740
		}
	
		private struct BaseLineWork : IComparable<BaseLineWork> // TypeDefIndex: 48595
		{
			// Fields
			public int vindex; // 0x00
			public float dist; // 0x04
	
			// Methods
			public int CompareTo(BaseLineWork other); // 0x00000001866F81B4-0x00000001866F8224
		}
	
		[BurstCompile]
		private struct BaseLine_Mesh_CreateParentJob2 : IJob // TypeDefIndex: 48596
		{
			// Fields
			public int vcnt; // 0x00
			public float avgDist; // 0x04
			[ReadOnly]
			public NativeArray<VertexAttribute> attribues; // 0x08
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x18
			[ReadOnly]
			public NativeArray<uint> vertexToVertexIndexArray; // 0x28
			[ReadOnly]
			public NativeArray<ushort> vertexToVertexDataArray; // 0x38
			public NativeArray<int> vertexParentIndices; // 0x48
			public NativeParallelMultiHashMap<int, ushort> vertexChildMap; // 0x58
			[ReadOnly]
			public NativeList<int> fixedList; // 0x68
			public NativeList<BaseLineWork> nextList; // 0x78
			public NativeArray<byte> markBuff; // 0x88
			public NativeParallelHashMap<int, BaseLineWork> vertexMap; // 0x98
	
			// Methods
			public void Execute(); // 0x00000001866F8388-0x00000001866F8E28
		}
	
		[BurstCompile]
		private struct BaseLine_Mesh_CareteFixedListJob : IJob // TypeDefIndex: 48597
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<VertexAttribute> attribues; // 0x08
			public NativeList<int> fixedList; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001866F82BC-0x00000001866F8388
		}
	
		[BurstCompile]
		private struct BaseLine_Bone_CreateBoneChildInfoJob : IJob // TypeDefIndex: 48598
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<int> parentIndices; // 0x08
			[WriteOnly]
			public NativeParallelMultiHashMap<int, ushort> childMap; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001866F8224-0x00000001866F82BC
		}
	
		[BurstCompile]
		private struct BaseLine_CalcLocalPositionRotationJob : IJobParallelFor // TypeDefIndex: 48599
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> parentIndices; // 0x00
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x10
			[ReadOnly]
			public NativeArray<float3> localNormals; // 0x20
			[ReadOnly]
			public NativeArray<float3> localTangents; // 0x30
			[ReadOnly]
			public NativeArray<ushort> baseLineIndices; // 0x40
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> vertexLocalPositions; // 0x50
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<quaternion> vertexLocalRotations; // 0x60
	
			// Methods
			public void Execute(int index); // 0x0000000183F47EA0-0x0000000183F48170
		}
	
		[BurstCompile]
		private struct BaseLine_CalcMaxBaseLineLengthJob : IJob // TypeDefIndex: 48600
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<VertexAttribute> attribues; // 0x08
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x18
			[ReadOnly]
			public NativeArray<int> vertexParentIndices; // 0x28
			[WriteOnly]
			public NativeArray<float> vertexDepths; // 0x38
			[WriteOnly]
			public NativeArray<int> vertexRootIndices; // 0x48
			public NativeArray<float> rootLengthArray; // 0x58
	
			// Methods
			public void Execute(); // 0x000000018391FFC0-0x00000001839202C0
		}
	
		[BurstCompile]
		private struct Reduction_InitVertexToVertexJob2 : IJob // TypeDefIndex: 48601
		{
			// Fields
			public int triangleCount; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001866FE180-0x00000001866FE2E0
		}
	
		[BurstCompile]
		private struct Organize_RemapVertexJob : IJob // TypeDefIndex: 48602
		{
			// Fields
			public int oldVertexCount; // 0x00
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x08
			public NativeArray<int> vertexRemapIndices; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001866FC5D8-0x00000001866FC67C
		}
	
		[BurstCompile]
		private struct Organize_CollectUseSkinBoneJob : IJob // TypeDefIndex: 48603
		{
			// Fields
			public int oldVertexCount; // 0x00
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x08
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> oldBoneWeights; // 0x18
			[ReadOnly]
			public NativeArray<float4x4> oldBindPoses; // 0x28
			public NativeParallelHashMap<int, int> useSkinBoneMap; // 0x38
			public NativeList<int> newSkinBoneTransformIndices; // 0x48
			public NativeList<float4x4> newSkinBoneBindPoses; // 0x58
			public NativeReference<int> newSkinBoneCount; // 0x68
			public NativeList<int> useSkinBoneMapKeyList; // 0x78
	
			// Methods
			public void Execute(); // 0x00000001866FB7C8-0x00000001866FBB7C
		}
	
		[BurstCompile]
		private struct Organize_CopyVertexJob : IJobParallelFor // TypeDefIndex: 48604
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			[ReadOnly]
			public NativeArray<int> vertexRemapIndices; // 0x10
			[ReadOnly]
			public NativeArray<VertexAttribute> oldAttributes; // 0x20
			[ReadOnly]
			public NativeArray<float3> oldLocalPositions; // 0x30
			[ReadOnly]
			public NativeArray<float3> oldLocalNormals; // 0x40
			[ReadOnly]
			public NativeArray<float3> oldLocalTangents; // 0x50
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<VertexAttribute> newAttributes; // 0x60
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> newLocalPositions; // 0x70
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> newLocalNormals; // 0x80
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<float3> newLocalTangents; // 0x90
	
			// Methods
			public void Execute(int index); // 0x00000001866FBB7C-0x00000001866FBC70
		}
	
		[BurstCompile]
		private struct Organize_RemapBoneWeightJob : IJobParallelFor // TypeDefIndex: 48605
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			[ReadOnly]
			public NativeArray<int> vertexRemapIndices; // 0x10
			[ReadOnly]
			public NativeParallelHashMap<int, int> useSkinBoneMap; // 0x20
			[ReadOnly]
			public NativeArray<int> oldSkinBoneIndices; // 0x30
			[ReadOnly]
			public NativeArray<VirtualMeshBoneWeight> oldBoneWeights; // 0x40
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<VirtualMeshBoneWeight> newBoneWeights; // 0x50
	
			// Methods
			public void Execute(int vindex); // 0x00000001866FC334-0x00000001866FC444
		}
	
		[BurstCompile]
		private struct Organize_RemapLinkPointArrayJob : IJobParallelFor // TypeDefIndex: 48606
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			[ReadOnly]
			public NativeArray<int> vertexRemapIndices; // 0x10
			[ReadOnly]
			public NativeParallelMultiHashMap<ushort, ushort> oldVertexToVertexMap; // 0x20
			[NativeDisableParallelForRestriction]
			public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x30
	
			// Methods
			public void Execute(int vindex); // 0x00000001866FC444-0x00000001866FC5D8
		}
	
		[BurstCompile]
		private struct Organize_CreateLineTriangleJob : IJob // TypeDefIndex: 48607
		{
			// Fields
			public int newVertexCount; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x08
			[WriteOnly]
			public NativeParallelHashSet<int2> edgeSet; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001866FBFF4-0x00000001866FC1A0
		}
	
		[BurstCompile]
		private struct Organize_CreateLineTriangleJob2 : IJob // TypeDefIndex: 48608
		{
			// Fields
			[ReadOnly]
			public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x00
			[WriteOnly]
			public NativeList<int2> newLineList; // 0x10
			[ReadOnly]
			public NativeParallelHashSet<int2> edgeSet; // 0x20
			[WriteOnly]
			public NativeParallelHashSet<int3> triangleSet; // 0x30
	
			// Methods
			public void Execute(); // 0x00000001866FBC70-0x00000001866FBFF4
		}
	
		[BurstCompile]
		private struct Organize_CreateNewTriangleJob3 : IJob // TypeDefIndex: 48609
		{
			// Fields
			[WriteOnly]
			public NativeList<int3> newTriangleList; // 0x00
			[ReadOnly]
			public NativeParallelHashSet<int3> triangleSet; // 0x10
	
			// Methods
			public void Execute(); // 0x00000001866FC1A0-0x00000001866FC334
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 48610
		{
			// Fields
			public string name; // 0x10
			public MeshType meshType; // 0x18
			public bool isBoneCloth; // 0x1C
			public ExSimpleNativeArray<int> referenceIndices; // 0x20
			public ExSimpleNativeArray<VertexAttribute> attributes; // 0x28
			public ExSimpleNativeArray<float3> localPositions; // 0x30
			public ExSimpleNativeArray<float3> localNormals; // 0x38
			public ExSimpleNativeArray<float3> localTangents; // 0x40
			public ExSimpleNativeArray<float2> uv; // 0x48
			public ExSimpleNativeArray<VirtualMeshBoneWeight> boneWeights; // 0x50
			public ExSimpleNativeArray<int3> triangles; // 0x58
			public ExSimpleNativeArray<int2> lines; // 0x60
			public int centerTransformIndex; // 0x68
			public float4x4 initLocalToWorld; // 0x6C
			public float4x4 initWorldToLocal; // 0xAC
			public quaternion initRotation; // 0xEC
			public quaternion initInverseRotation; // 0xFC
			public float3 initScale; // 0x10C
			public int skinRootIndex; // 0x118
			public ExSimpleNativeArray<int> skinBoneTransformIndices; // 0x120
			public ExSimpleNativeArray<float4x4> skinBoneBindPoses; // 0x128
			public BeyondDynamicBone.TransformData.ShareSerializationData transformData; // 0x130
			public AABB boundingBox; // 0x138
			public float averageVertexDistance; // 0x168
			public float maxVertexDistance; // 0x16C
			public byte[] vertexToTriangles; // 0x170
			public byte[] vertexToVertexIndexArray; // 0x178
			public byte[] vertexToVertexDataArray; // 0x180
			public byte[] edges; // 0x188
			public byte[] edgeFlags; // 0x190
			public int2[] edgeToTrianglesKeys; // 0x198
			public ushort[] edgeToTrianglesValues; // 0x1A0
			public byte[] vertexBindPosePositions; // 0x1A8
			public byte[] vertexBindPoseRotations; // 0x1B0
			public byte[] vertexToTransformRotations; // 0x1B8
			public byte[] vertexDepths; // 0x1C0
			public byte[] vertexRootIndices; // 0x1C8
			public byte[] vertexParentIndices; // 0x1D0
			public byte[] vertexChildIndexArray; // 0x1D8
			public byte[] vertexChildDataArray; // 0x1E0
			public byte[] vertexLocalPositions; // 0x1E8
			public byte[] vertexLocalRotations; // 0x1F0
			public byte[] normalAdjustmentRotations; // 0x1F8
			public byte[] baseLineFlags; // 0x200
			public byte[] baseLineStartDataIndices; // 0x208
			public byte[] baseLineDataCounts; // 0x210
			public byte[] baseLineData; // 0x218
			public int[] customSkinningBoneIndices; // 0x220
			public ushort[] centerFixedList; // 0x228
			public float3 localCenterPosition; // 0x230
			public float3 centerWorldPosition; // 0x23C
			public quaternion centerWorldRotation; // 0x248
			public float3 centerWorldScale; // 0x258
			public float4x4 toProxyMatrix; // 0x264
			public quaternion toProxyRotation; // 0x2A4
	
			// Constructors
			public ShareSerializationData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public override string ToString(); // 0x00000001866FEAB4-0x00000001866FED44
			public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 48611
		{
			// Fields
			public BeyondDynamicBone.TransformData.UniqueSerializationData transformData; // 0x10
	
			// Constructors
			public UniqueSerializationData(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001866FED44-0x00000001866FEDB0
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x00000001866FEDB0-0x00000001866FEE1C
		}
	
		[BurstCompile]
		private struct Work_AverageTriangleDistanceJob : IJob // TypeDefIndex: 48612
		{
			// Fields
			public int vcnt; // 0x00
			public int tcnt; // 0x04
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x08
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x18
			public NativeReference<float> averageVertexDistance; // 0x28
			public NativeReference<int> averageCount; // 0x38
			public NativeReference<float> maxVertexDistance; // 0x48
	
			// Methods
			public void Execute(); // 0x000000018670056C-0x00000001867007E4
		}
	
		[BurstCompile]
		private struct Work_AverageLineDistanceJob : IJob // TypeDefIndex: 48613
		{
			// Fields
			public int vcnt; // 0x00
			public int lcnt; // 0x04
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x08
			[ReadOnly]
			public NativeArray<int2> lines; // 0x18
			public NativeReference<float> averageVertexDistance; // 0x28
			public NativeReference<int> averageCount; // 0x38
			public NativeReference<float> maxVertexDistance; // 0x48
	
			// Methods
			public void Execute(); // 0x000000018436E880-0x000000018436EA70
		}
	
		[BurstCompile]
		private struct Work_AddVertexIndexGirdMapJob : IJob // TypeDefIndex: 48614
		{
			// Fields
			public float gridSize; // 0x00
			public int vcnt; // 0x04
			[ReadOnly]
			public NativeArray<float3> positins; // 0x08
			[WriteOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001867004A0-0x000000018670056C
		}
	
		[BurstCompile]
		private struct Work_IntersectTriangleJob : IJobParallelFor // TypeDefIndex: 48615
		{
			// Fields
			public float3 localRayPos; // 0x00
			public float3 localRayDir; // 0x0C
			public float3 localRayEndPos; // 0x18
			public bool doubleSide; // 0x24
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x28
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x38
			[WriteOnly]
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x48
	
			// Methods
			public void Execute(int tindex); // 0x0000000186700C6C-0x0000000186701010
		}
	
		[BurstCompile]
		private struct Work_IntersectEdgeJob : IJobParallelFor // TypeDefIndex: 48616
		{
			// Fields
			public float3 localRayPos; // 0x00
			public float3 localRayDir; // 0x0C
			public float3 localRayEndPos; // 0x18
			public float3 rayDir; // 0x24
			public float localEdgeRadius; // 0x30
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x38
			[ReadOnly]
			public NativeArray<int2> edges; // 0x48
			[ReadOnly]
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x58
			[WriteOnly]
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x68
	
			// Methods
			public void Execute(int eindex); // 0x00000001867007E4-0x0000000186700A9C
		}
	
		[BurstCompile]
		private struct Work_IntersectPointJob : IJobParallelFor // TypeDefIndex: 48617
		{
			// Fields
			public float3 localRayPos; // 0x00
			public float3 localRayDir; // 0x0C
			public float3 rayDir; // 0x18
			public float localPointRadius; // 0x24
			[ReadOnly]
			public NativeArray<float3> localPositions; // 0x28
			[ReadOnly]
			public NativeArray<FixedList32Bytes<int>> vertexToTriangles; // 0x38
			[WriteOnly]
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x48
	
			// Methods
			public void Execute(int vindex); // 0x0000000186700A9C-0x0000000186700C6C
		}
	
		[BurstCompile]
		private struct Work_IntersetcSortJob : IJob // TypeDefIndex: 48618
		{
			// Fields
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x00
	
			// Methods
			public void Execute(); // 0x0000000186701010-0x00000001867010B0
		}
	
		public enum MeshType // TypeDefIndex: 48619
		{
			NormalMesh = 0,
			NormalBoneMesh = 1,
			ProxyMesh = 2,
			ProxyBoneMesh = 3,
			Mapping = 4
		}
	
		// Constructors
		public VirtualMesh(); // 0x0000000184596040-0x0000000184596320
		public VirtualMesh(bool initialize); // 0x0000000183E90B60-0x0000000183E90F50
		public VirtualMesh(string name); // 0x0000000183E90B20-0x0000000183E90B60
	
		// Methods
		[IDTag(0)]
		public void ImportFrom(RenderSetupData rsetup); // 0x0000000183CF7040-0x0000000183CF7430
		private void ImportMeshType(RenderSetupData rsetup, int[] transformIndices); // 0x00000001866B7844-0x00000001866B818C
		private void ImportMeshSkinning(); // 0x00000001866B75B8-0x00000001866B7844
		private void ImportBoneType(RenderSetupData rsetup, int[] transformIndices); // 0x00000001836413E0-0x0000000183644610
		[IDTag(1)]
		public void ImportFrom(BeyondDynamicBone.RenderData renderData); // 0x00000001866B7408-0x00000001866B75B8
		public void SelectionMesh(SelectionData selectionData, float4x4 selectionLocalToWorldMatrix, float mergin); // 0x00000001866BC574-0x00000001866BD77C
		public float CalcSelectionMergin(ReductionSettings settings); // 0x00000001866B5694-0x00000001866B57C0
		public void AddMesh(VirtualMesh cmesh); // 0x00000001866B47BC-0x00000001866B5694
		[IDTag(1)]
		public void SetTransform(Transform center, Transform skinRoot = null, int centerId = 0 /* Metadata: 0x0232D099 */, int skinRootId = 0 /* Metadata: 0x0232D09A */); // 0x00000001866BDF0C-0x00000001866BE154
		[IDTag(0)]
		public void SetTransform(TransformRecord centerRecord, TransformRecord skinRootRecord = null); // 0x00000001866BDCE4-0x00000001866BDF0C
		public void SetCenterTransform(Transform t, int tid = 0 /* Metadata: 0x0232D09B */); // 0x00000001866BD77C-0x00000001866BD878
		public void SetSkinRoot(Transform t, int tid = 0 /* Metadata: 0x0232D09C */); // 0x00000001866BDBDC-0x00000001866BDCE4
		public Transform GetCenterTransform(); // 0x00000001866B73A8-0x00000001866B7408
		public void SetCustomSkinningBones(TransformRecord clothTransformRecord, List<TransformRecord> bones); // 0x00000001866BD878-0x00000001866BDB78
		public bool CompareSpace(VirtualMesh target); // 0x00000001866B5E7C-0x00000001866B5EE4
		public float4x4 CenterTransformTo(VirtualMesh to); // 0x00000001866B5C1C-0x00000001866B5D18
		public void Mapping(VirtualMesh proxyMesh); // 0x00000001866B8D50-0x00000001866B9A28
		private static float4 CalcVertexWeights(float4 distances); // 0x00000001866B5A20-0x00000001866B5C1C
		public void Optimization(); // 0x000000018451B240-0x000000018451B280
		private void RemoveDuplicateTriangles(); // 0x000000018451B280-0x000000018451B7A0
		private bool CheckTwoTriangleOpen([IsReadOnly] in int3 tri1, [IsReadOnly] in int3 tri2, [IsReadOnly] in int2 edge, [IsReadOnly] in float3 tri1n); // 0x00000001866B5D18-0x00000001866B5E7C
		private float CalcTwoTriangleAngle([IsReadOnly] in int3 tri1, [IsReadOnly] in int3 tri2, [IsReadOnly] in int2 edge); // 0x00000001866B57C0-0x00000001866B5A20
		public void ConvertProxyMesh(ClothSerializeData sdata, TransformRecord clothTransformRecord, List<TransformRecord> customSkinningBoneRecords, TransformRecord normalAdjustmentTransformRecord); // 0x0000000183CFB3B0-0x0000000183CFCA70
		private void ProxyNormalAdjustment(ClothSerializeData sdata, TransformRecord normalAdjustmentTransformRecord); // 0x00000001843F6E60-0x00000001843F6FC0
		private void ProxyCreateFixedListAndAABB(); // 0x0000000184373340-0x0000000184373B00
		private void OptimizeTriangleDirection(NativeArray<float3> triangleNormals, float sameSurfaceAngle); // 0x00000001866B9A28-0x00000001866BA464
		private void CreateCustomSkinning(CustomSkinningSettings setting, List<TransformRecord> bones); // 0x00000001866B5EE4-0x00000001866B6298
		public void ApplySelectionAttribute(SelectionData selectionData); // 0x00000001841ECF70-0x00000001841EDFC0
		private void CreateMeshBaseLine(); // 0x00000001866B6298-0x00000001866B7244
		private void CreateTransformBaseLine(); // 0x00000001833A8E40-0x00000001833ABC60
		[BurstCompile]
		public static void DoBaseLine_Bone_CreateBoneChildInfo(int vcnt, NativeArray<int> parentIndices, NativeParallelMultiHashMap<int, ushort> childMap); // 0x00000001841657D0-0x0000000184165850
		private void CreateBaseLinePose(); // 0x0000000183CFADB0-0x0000000183CFAF80
		private void CreateVertexRootAndDepth(); // 0x00000001843C8430-0x00000001843C8870
		public void Reduction(ReductionSettings settings, CancellationToken ct); // 0x00000001866BB88C-0x00000001866BC574
		private void InitReductionWorkData(ReductionWorkData workData); // 0x00000001866B818C-0x00000001866B83D0
		private void Organization(ReductionSettings setting, ReductionWorkData workData); // 0x00000001866BB174-0x00000001866BB298
		private void OrganizationInit(ReductionSettings setting, ReductionWorkData workData); // 0x00000001866BAC8C-0x00000001866BB174
		private void OrganizationCreateRemapData(ReductionWorkData workData); // 0x00000001866BA99C-0x00000001866BAC8C
		private void OrganizationCreateBasicData(ReductionWorkData workData); // 0x00000001866BA464-0x00000001866BA828
		private void OrganizationCreateLineTriangle(ReductionWorkData workData); // 0x00000001866BA828-0x00000001866BA99C
		private void OrganizeStoreVirtualMesh(ReductionWorkData workData); // 0x00000001866BB298-0x00000001866BB88C
		public ShareSerializationData ShareSerialize(); // 0x00000001866BE154-0x00000001866BEB44
		public static VirtualMesh ShareDeserialize(ShareSerializationData sdata); // 0x0000000183E8FE60-0x0000000183E90880
		public UniqueSerializationData UniqueSerialize(); // 0x00000001866BF2F8-0x00000001866BF43C
		internal void CalcAverageAndMaxVertexDistanceRun(); // 0x0000000183CF9FF0-0x0000000183CFAD10
		internal GridMap<int> CreateVertexIndexGridMapRun(float gridSize); // 0x00000001866B7244-0x00000001866B73A8
		public VirtualMeshRaycastHit IntersectRayMesh(float3 rayPos, float3 rayDir, bool doubleSide, float pointRadius); // 0x00000001866B83D0-0x00000001866B8C88
		public void Dispose(); // 0x0000000183E92580-0x0000000183E92BD0
		public void SetName(string newName); // 0x00000001866BDB78-0x00000001866BDBDC
		public bool IsValid(); // 0x00000001866B8C88-0x00000001866B8D50
		public override string ToString(); // 0x00000001866BEB44-0x00000001866BF2F8
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
	}

	[Serializable]
	public struct VertexAttribute : IEquatable<VertexAttribute> // TypeDefIndex: 48621
	{
		// Fields
		public const byte Flag_Fixed = 1; // Metadata: 0x0232D0A5
		public const byte Flag_Move = 2; // Metadata: 0x0232D0A6
		public const byte Flag_InvalidMotion = 8; // Metadata: 0x0232D0A7
		public const byte Flag_DisableCollision = 16; // Metadata: 0x0232D0A8
		public const byte Flag_Triangle = 128; // Metadata: 0x0232D0A9
		public static readonly VertexAttribute Invalid; // 0x00
		public static readonly VertexAttribute Fixed; // 0x01
		public static readonly VertexAttribute Move; // 0x02
		public static readonly VertexAttribute DisableCollision; // 0x03
		public byte Value; // 0x00
	
		// Constructors
		public VertexAttribute(byte initialValue = 0 /* Metadata: 0x0232D0A4 */); // 0x0000000184D87180-0x0000000184D87190
		static VertexAttribute(); // 0x0000000184D347A0-0x0000000184D34810
	
		// Methods
		public void Clear(); // 0x0000000184D87170-0x0000000184D87180
		public void SetFlag(byte flag, bool sw); // 0x00000001866AB964-0x00000001866AB978
		public void SetFlag(VertexAttribute attr, bool sw); // 0x00000001866AB964-0x00000001866AB978
		public bool IsSet(byte flag); // 0x00000001866AB95C-0x00000001866AB964
		public bool IsInvalid(); // 0x00000001866FEFDC-0x00000001866FF01C
		public bool IsFixed(); // 0x00000001866FEF94-0x00000001866FEFDC
		public bool IsMove(); // 0x00000001866FF05C-0x00000001866FF0A4
		public bool IsDontMove(); // 0x00000001866FEF54-0x00000001866FEF94
		public bool IsMotion(); // 0x00000001866FF01C-0x00000001866FF05C
		public bool IsDisableCollision(); // 0x00000001866FEF0C-0x00000001866FEF54
		public static VertexAttribute JoinAttribute(VertexAttribute attr1, VertexAttribute attr2); // 0x00000001866FF0A4-0x00000001866FF0B0
		public bool Equals(VertexAttribute other); // 0x0000000183E5E160-0x0000000183E5E170
		public override bool Equals(object obj); // 0x00000001866FEE1C-0x00000001866FEEC0
		public override int GetHashCode(); // 0x00000001866FEEC0-0x00000001866FEF0C
		public static bool operator ==(VertexAttribute lhs, VertexAttribute rhs); // 0x00000001866FF158-0x00000001866FF160
		public static bool operator !=(VertexAttribute lhs, VertexAttribute rhs); // 0x00000001866FF160-0x00000001866FF168
		public bool __iFixBaseProxy_Equals(object P0); // 0x00000001866FF0B0-0x00000001866FF10C
		public int __iFixBaseProxy_GetHashCode(); // 0x00000001866FF10C-0x00000001866FF158
	}

	public struct VirtualMeshBoneWeight // TypeDefIndex: 48622
	{
		// Fields
		public float4 weights; // 0x00
		public int4 boneIndices; // 0x10
	
		// Properties
		public bool IsValid { get; } // 0x00000001866FF5D0-0x00000001866FF628 
		public int Count { get; } // 0x00000001866FF53C-0x00000001866FF5D0 
	
		// Constructors
		public VirtualMeshBoneWeight(int4 boneIndices, float4 weights); // 0x0000000184D872E0-0x0000000184D872F0
	
		// Methods
		[IDTag(0)]
		public void AddWeight(int boneIndex, float weight); // 0x00000001866FF21C-0x00000001866FF370
		[IDTag(1)]
		public void AddWeight([IsReadOnly] in VirtualMeshBoneWeight bw); // 0x00000001866FF168-0x00000001866FF21C
		public void AdjustWeight(); // 0x00000001866FF370-0x00000001866FF414
		public override string ToString(); // 0x00000001866FF414-0x00000001866FF4E4
		public string __iFixBaseProxy_ToString(); // 0x00000001866FF4E4-0x00000001866FF53C
	}

	public class VirtualMeshContainer : IDisposable // TypeDefIndex: 48623
	{
		// Fields
		public VirtualMesh shareVirtualMesh; // 0x10
		public VirtualMesh.UniqueSerializationData uniqueData; // 0x18
	
		// Properties
		public bool hasUniqueData { get; } // 0x0000000183CF8AF0-0x0000000183CF8B20 
	
		// Constructors
		public VirtualMeshContainer(); // 0x00000001841E1670-0x00000001841E1680
		public VirtualMeshContainer(VirtualMesh vmesh); // 0x0000000183E8CD90-0x0000000183E8CDC0
	
		// Methods
		public void Dispose(); // 0x0000000183E933A0-0x0000000183E933E0
		public int GetTransformCount(); // 0x0000000183CF78A0-0x0000000183CF7910
		public Transform GetTransformFromIndex(int index); // 0x0000000183CF8A50-0x0000000183CF8AF0
		public Transform GetCenterTransform(); // 0x00000001866FF628-0x00000001866FF6CC
	}

	public enum VirtualMeshPrimitive // TypeDefIndex: 48624
	{
		None = 0,
		Point = 1,
		Edge = 2,
		Triangle = 3
	}

	public struct VirtualMeshRaycastHit : IComparable<VirtualMeshRaycastHit>, IValid // TypeDefIndex: 48625
	{
		// Fields
		public VirtualMeshPrimitive type; // 0x00
		public int index; // 0x04
		public double3 position; // 0x08
		public double distance; // 0x20
		public float3 normal; // 0x28
	
		// Methods
		public int CompareTo(VirtualMeshRaycastHit other); // 0x00000001866FF6CC-0x00000001866FF76C
		public bool IsValid(); // 0x00000001866FF76C-0x00000001866FF7BC
		public override string ToString(); // 0x00000001866FF7BC-0x00000001866FF9D4
		public string __iFixBaseProxy_ToString(); // 0x00000001866FF9D4-0x00000001866FFA40
	}

	public struct VirtualMeshTransform // TypeDefIndex: 48626
	{
		// Fields
		public FixedString32Bytes name; // 0x00
		public int index; // 0x20
		public float4x4 localToWorldMatrix; // 0x24
		public float4x4 worldToLocalMatrix; // 0x64
		public int parentIndex; // 0xA4
	
		// Properties
		public static VirtualMeshTransform Origin { get; } // 0x000000018670032C-0x00000001867004A0 
	
		// Constructors
		public VirtualMeshTransform(Transform t); // 0x00000001867001B4-0x000000018670032C
		public VirtualMeshTransform(Transform t, int index); // 0x000000018670018C-0x00000001867001B4
	
		// Methods
		public VirtualMeshTransform Clone(); // 0x00000001866FFA40-0x00000001866FFB8C
		public override int GetHashCode(); // 0x00000001866FFB8C-0x00000001866FFBDC
		public void Update(Transform t); // 0x0000000186700050-0x000000018670018C
		public float3 TransformPoint(float3 pos); // 0x00000001866FFCF0-0x00000001866FFD60
		public float3 TransformVector(float3 vec); // 0x00000001866F7D0C-0x00000001866F7DBC
		public float3 TransformDirection(float3 dir); // 0x00000001866F7C2C-0x00000001866F7D0C
		public float3 InverseTransformPoint(float3 pos); // 0x00000001866FFBDC-0x00000001866FFC54
		public float3 InverseTransformVector(float3 vec); // 0x00000001866F7B78-0x00000001866F7C2C
		public float3 InverseTransformDirection(float3 dir); // 0x00000001866F7A98-0x00000001866F7B78
		public quaternion InverseTransformRotation(quaternion rot); // 0x00000001866FFC54-0x00000001866FFCF0
		public VirtualMeshTransform Transform([IsReadOnly] in VirtualMeshTransform to); // 0x00000001866FFD60-0x00000001866FFFA0
		public int __iFixBaseProxy_GetHashCode(); // 0x00000001866FFFA0-0x0000000186700050
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 48629
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37BF0-0x0000000184D37C60
	
		// Methods
		public void __Gen_Wrap_0(object P0); // 0x00000001863633B4-0x0000000186363474
		public bool __Gen_Wrap_1(); // 0x00000001863623A8-0x0000000186362454
		public ClothProcess __Gen_Wrap_2(object P0); // 0x00000001866D4EC4-0x00000001866D4FB4
		public bool __Gen_Wrap_3(object P0, int P1); // 0x00000001866E0A9C-0x00000001866E0B88
		public bool __Gen_Wrap_4(object P0); // 0x00000001863632E4-0x00000001863633B4
		public ClothSerializeData __Gen_Wrap_5(object P0); // 0x00000001866F4518-0x00000001866F4608
		public void __Gen_Wrap_6(object P0, float P1, float P2); // 0x00000001866F50F4-0x00000001866F51F0
		public TeamManager __Gen_Wrap_7(); // 0x00000001866F5D58-0x00000001866F5E24
		public void __Gen_Wrap_8(object P0, bool P1, float3 P2, quaternion P3); // 0x00000001866F696C-0x00000001866F6AD8
		public void __Gen_Wrap_9(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public Transform __Gen_Wrap_10(object P0); // 0x00000001866C04DC-0x00000001866C05CC
		public BeyondBoneCloth __Gen_Wrap_11(object P0); // 0x00000001866C10E0-0x00000001866C11D0
		public void __Gen_Wrap_12(ref ResultCode P0, Define.Result P1); // 0x00000001866C1EA0-0x00000001866C1FE4
		public void __Gen_Wrap_13(ref ResultCode P0); // 0x00000001866C2A18-0x00000001866C2B40
		public void __Gen_Wrap_14(in object P0); // 0x00000001866C30F8-0x00000001866C31CC
		public ClothSerializeData2 __Gen_Wrap_15(object P0); // 0x00000001866C3B58-0x00000001866C3C48
		public void __Gen_Wrap_16(object P0, int P1, bool P2); // 0x00000001866C44C0-0x00000001866C45B8
		public bool __Gen_Wrap_17(Transform P0); // 0x00000001866C53B4-0x00000001866C5470
		public bool __Gen_Wrap_18(Renderer P0); // 0x00000001866C53B4-0x00000001866C5470
		public Define.Result __Gen_Wrap_19(ref ResultCode P0); // 0x00000001866C8E64-0x00000001866C8F9C
		public Define.Result __Gen_Wrap_20(object P0); // 0x0000000186360E84-0x0000000186360F54
		public ResultCode __Gen_Wrap_21(object P0); // 0x00000001866CB3E0-0x00000001866CB4D0
		public bool __Gen_Wrap_22(ref ResultCode P0); // 0x00000001866CCC68-0x00000001866CCDA0
		public void __Gen_Wrap_23(ref ResultCode P0, ResultCode P1); // 0x00000001866CE250-0x00000001866CE3A8
		public SharePreBuildData __Gen_Wrap_24(object P0); // 0x00000001866CF7D4-0x00000001866CF8C4
		public ResultCode __Gen_Wrap_25(); // 0x00000001866D06D8-0x00000001866D07A4
		public float4x4 __Gen_Wrap_26(object P0); // 0x00000001866D2184-0x00000001866D22A8
		public void __Gen_Wrap_27(ref CullingSettings.CullingParams P0, object P1); // 0x00000001866D2F80-0x00000001866D30DC
		public float __Gen_Wrap_28(object P0, float P1); // 0x00000001866D3DA4-0x00000001866D3E94
		public void __Gen_Wrap_29(ref InertiaConstraint.InertiaConstraintParams P0, object P1); // 0x00000001866D4D44-0x00000001866D4EC4
		public void __Gen_Wrap_30(ref TetherConstraint.TetherConstraintParams P0, object P1, ClothProcess.ClothType P2); // 0x00000001866D5F64-0x00000001866D60B8
		public void __Gen_Wrap_31(ref DistanceConstraint.DistanceConstraintParams P0, object P1, ClothProcess.ClothType P2); // 0x00000001866D7854-0x00000001866D79F8
		public void __Gen_Wrap_32(ref TriangleBendingConstraint.TriangleBendingConstraintParams P0, object P1); // 0x00000001866D8B20-0x00000001866D8C64
		public void __Gen_Wrap_33(ref AngleConstraint.AngleConstraintParams P0, object P1, object P2); // 0x00000001866D9F6C-0x00000001866DA18C
		public void __Gen_Wrap_34(ref MotionConstraint.MotionConstraintParams P0, object P1, ClothProcess.ClothType P2); // 0x00000001866DB548-0x00000001866DB754
		public void __Gen_Wrap_35(ref ColliderCollisionConstraint.ColliderCollisionConstraintParams P0, object P1, ClothProcess.ClothType P2); // 0x00000001866DC940-0x00000001866DCAF8
		public void __Gen_Wrap_36(ref SelfCollisionConstraint.SelfCollisionConstraintParams P0, object P1, ClothProcess.ClothType P2); // 0x00000001866DD184-0x00000001866DD33C
		public void __Gen_Wrap_37(ref WindParams P0, object P1, ClothProcess.ClothType P2); // 0x00000001866DE210-0x00000001866DE394
		public void __Gen_Wrap_38(ref SpringConstraint.SpringConstraintParams P0, object P1, ClothProcess.ClothType P2); // 0x00000001866DF48C-0x00000001866DF5F4
		public ClothParameters __Gen_Wrap_39(object P0); // 0x00000001866E0918-0x00000001866E0A9C
		public PreBuildManager __Gen_Wrap_40(); // 0x00000001866E263C-0x00000001866E2708
		public RenderSetupData __Gen_Wrap_41(object P0); // 0x00000001866E3760-0x00000001866E3850
		public BeyondDynamicBone.TransformData __Gen_Wrap_42(object P0); // 0x00000001866E44A8-0x00000001866E4598
		public NativeParallelMultiHashMap<int2, ushort> __Gen_Wrap_43(object P0, object P1); // 0x00000001866E4FC4-0x00000001866E50EC
		public VirtualMesh __Gen_Wrap_44(object P0); // 0x00000001866E5F4C-0x00000001866E603C
		public PreBuildManager.ShareDeserializationData __Gen_Wrap_45(object P0, object P1, bool P2); // 0x00000001866E6E70-0x00000001866E6F98
		public RenderManager __Gen_Wrap_46(); // 0x00000001866E7FD8-0x00000001866E80A4
		public void __Gen_Wrap_47(object P0, object P1, object P2, object P3); // 0x00000001866E8E30-0x00000001866E8F38
		public int __Gen_Wrap_48(object P0); // 0x0000000186360E84-0x0000000186360F54
		public int __Gen_Wrap_49(object P0, object P1, object P2, object P3); // 0x00000001866EAC88-0x00000001866EADA0
		public BeyondDynamicBone.RenderData __Gen_Wrap_50(object P0, int P1); // 0x00000001866EBDE8-0x00000001866EBEF4
		public void __Gen_Wrap_51(object P0, ClothProcess.ClothType P1, object P2, object P3, object P4, RenderSetupData.BoneConnectionMode P5); // 0x00000001866ECAE4-0x00000001866ECC0C
		public ClothManager __Gen_Wrap_52(); // 0x00000001866ED734-0x00000001866ED800
		public ColliderManager __Gen_Wrap_53(); // 0x00000001866EE894-0x00000001866EE960
		public ref TeamManager.TeamData __Gen_Wrap_54(object P0, int P1); // 0x00000001866EFAAC-0x00000001866EFBB8
		public bool __Gen_Wrap_55(ref TeamManager.TeamData P0); // 0x00000001866F098C-0x00000001866F0BD4
		public int __Gen_Wrap_56(ref TeamManager.TeamData P0); // 0x00000001866F1888-0x00000001866F1AD0
		public DynamicBoneTransformManager __Gen_Wrap_57(); // 0x00000001866F2974-0x00000001866F2A40
		public void __Gen_Wrap_58(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public bool __Gen_Wrap_59(ref DataChunk P0); // 0x00000001866F43E0-0x00000001866F4518
		public void __Gen_Wrap_60(object P0, DataChunk P1, bool P2); // 0x00000001866F4608-0x00000001866F4724
		public bool __Gen_Wrap_61(ClothProcess P0); // 0x00000001866C53B4-0x00000001866C5470
		public void __Gen_Wrap_62(object P0, NativeArray<BoneWeight> P1); // 0x00000001866F4724-0x00000001866F4838
		public void __Gen_Wrap_63(object P0, object P1, int P2); // 0x00000001866F4838-0x00000001866F4930
		public PreBuildManager.ShareDeserializationData __Gen_Wrap_64(object P0, object P1); // 0x00000001866F4930-0x00000001866F4A3C
		public void __Gen_Wrap_65(ref TeamManager.TeamData P0, object P1); // 0x00000001866F4A3C-0x00000001866F4C88
		public int __Gen_Wrap_66(object P0, object P1); // 0x0000000186360610-0x00000001863606FC
		public void __Gen_Wrap_67(object P0, int P1, object P2); // 0x00000001866F4C88-0x00000001866F4D80
		public int __Gen_Wrap_68(object P0, object P1, ClothParameters P2); // 0x00000001866F4D80-0x00000001866F4F30
		public int __Gen_Wrap_69(object P0, object P1, in ClothParameters P2); // 0x00000001866F4F30-0x00000001866F50F4
		public VirtualMeshManager __Gen_Wrap_70(); // 0x00000001866F51F0-0x00000001866F52BC
		public Transform __Gen_Wrap_71(object P0, int P1); // 0x00000001866F52BC-0x00000001866F53C8
		public DataChunk __Gen_Wrap_72(object P0, object P1, int P2); // 0x00000001866F53C8-0x00000001866F54EC
		public SimulationManager __Gen_Wrap_73(); // 0x00000001866F54EC-0x00000001866F55B8
		public DataChunk __Gen_Wrap_74(object P0, int P1, int P2); // 0x00000001866F55B8-0x00000001866F56DC
		public Vector3 __Gen_Wrap_75(object P0); // 0x00000001866F56DC-0x00000001866F57F0
		public void __Gen_Wrap_76(object P0, object P1, ExBitFlag8 P2, int P3, int P4); // 0x00000001866F57F0-0x00000001866F592C
		public void __Gen_Wrap_77(object P0, object P1, object P2, int P3, int P4, int P5); // 0x00000001866F592C-0x00000001866F5A50
		public ref ClothParameters __Gen_Wrap_78(object P0, int P1); // 0x00000001866F5A50-0x00000001866F5B5C
		public void __Gen_Wrap_79(object P0, int P1, TeamManager.TeamData P2, uint P3, int P4, int P5, int P6); // 0x00000001866F5B5C-0x00000001866F5D58
		public void __Gen_Wrap_80(ref DataChunk P0); // 0x00000001866F5E24-0x00000001866F5F4C
		public DataChunk __Gen_Wrap_81(); // 0x00000001866F5F4C-0x00000001866F6018
		public ref FixedList64Bytes<short> __Gen_Wrap_82(object P0, int P1); // 0x00000001866F6018-0x00000001866F6124
		public DataChunk __Gen_Wrap_83(object P0, object P1, ExBitFlag8 P2, int P3); // 0x00000001866F6124-0x00000001866F626C
		public DataChunk __Gen_Wrap_84(object P0, int P1, object P2); // 0x00000001866F626C-0x00000001866F6390
		public void __Gen_Wrap_85(VirtualMeshContainer P0); // 0x00000001866C296C-0x00000001866C2A18
		public string __Gen_Wrap_86(ref ResultCode P0); // 0x00000001866F6390-0x00000001866F64D8
		public NativeParallelMultiHashMap<int, ushort> __Gen_Wrap_87(in NativeArray<uint> P0, in NativeArray<ushort> P1); // 0x00000001866F64D8-0x00000001866F666C
		public int __Gen_Wrap_88(int3 P0, int2 P1); // 0x00000001866F666C-0x00000001866F67B4
		public DistanceConstraint.ConstraintData __Gen_Wrap_89(object P0, in ClothParameters P1); // 0x00000001866F67B4-0x00000001866F696C
		public int2 __Gen_Wrap_90(int3 P0, int3 P1, int2 P2); // 0x00000001866F6AD8-0x00000001866F6C60
		public void __Gen_Wrap_91(object P0, int P1, int P2, int P3, int P4, out float P5, out sbyte P6); // 0x00000001866F6C60-0x00000001866F6DE0
		public int4 __Gen_Wrap_92(int P0, int P1, int P2, int P3); // 0x00000001866F6DE0-0x00000001866F6F24
		public int4 __Gen_Wrap_93(int4 P0); // 0x00000001866F6F24-0x00000001866F7054
		public TriangleBendingConstraint.ConstraintData __Gen_Wrap_94(object P0, in ClothParameters P1); // 0x00000001866F7054-0x00000001866F720C
		public void __Gen_Wrap_95(ref InertiaConstraint.CenterData P0); // 0x00000001866F720C-0x00000001866F7434
		public InertiaConstraint.ConstraintData __Gen_Wrap_96(object P0, in ClothParameters P1); // 0x00000001866F7434-0x00000001866F75EC
		public int __Gen_Wrap_97(object P0, object P1, int P2, byte P3, bool P4); // 0x00000001866F75EC-0x00000001866F7710
		public void __Gen_Wrap_98(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public string __Gen_Wrap_99(object P0); // 0x00000001866F7710-0x00000001866F7800
		public int[] __Gen_Wrap_100(object P0, object P1, object P2, object P3, object P4, NativeArray<float3> P5, NativeArray<quaternion> P6, NativeArray<float3> P7, NativeArray<quaternion> P8, NativeArray<float3> P9, NativeArray<quaternion> P10); // 0x00000001866BF73C-0x00000001866BF99C
		public void __Gen_Wrap_101(NativeArray<int> P0, int P1); // 0x00000001866BF99C-0x00000001866BFAB0
		public void __Gen_Wrap_102(NativeArray<VirtualMeshBoneWeight> P0, int P1, VirtualMeshBoneWeight P2); // 0x00000001866BFAB0-0x00000001866BFC08
		public int __Gen_Wrap_103(object P0, int P1, bool P2); // 0x0000000186369194-0x0000000186369298
		public int3 __Gen_Wrap_104(int P0, int P1, int P2); // 0x00000001866BFC08-0x00000001866BFD44
		public void __Gen_Wrap_105(NativeArray<float3> P0, int P1, NativeReference<AABB> P2); // 0x00000001866BFD44-0x00000001866BFE94
		public void __Gen_Wrap_106(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, NativeArray<float2> P3); // 0x00000001866BFE94-0x00000001866C001C
		public void __Gen_Wrap_107(NativeArray<float3> P0, NativeArray<float3> P1, int P2, in float4x4 P3); // 0x00000001866C001C-0x00000001866C01C0
		public ResultCode __Gen_Wrap_108(object P0, object P1, object P2, object P3, out SelectionData P4); // 0x00000001866C01C0-0x00000001866C0344
		public double3 __Gen_Wrap_109(ref AABB P0); // 0x00000001866C0344-0x00000001866C04DC
		public float __Gen_Wrap_110(ref AABB P0); // 0x00000001866C05CC-0x00000001866C0730
		public float __Gen_Wrap_111(object P0); // 0x00000001866C0730-0x00000001866C0800
		public float __Gen_Wrap_112(object P0, object P1); // 0x00000001866C0800-0x00000001866C08EC
		public NativeArray<float3> __Gen_Wrap_113(object P0); // 0x00000001866C08EC-0x00000001866C09F8
		public NativeArray<VertexAttribute> __Gen_Wrap_114(object P0); // 0x00000001866C09F8-0x00000001866C0B04
		public void __Gen_Wrap_115(NativeArray<float3> P0, int P1, in float4x4 P2); // 0x00000001866C0B04-0x00000001866C0C7C
		public GridMap<int> __Gen_Wrap_116(float P0, in NativeArray<float3> P1, in NativeArray<VertexAttribute> P2, bool P3, bool P4, bool P5, bool P6); // 0x00000001866C0C7C-0x00000001866C0E4C
		public void __Gen_Wrap_117(object P0, object P1, float4x4 P2, float P3); // 0x00000001866C0E4C-0x00000001866C0FA0
		public bool __Gen_Wrap_118(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public float4x4 __Gen_Wrap_119(object P0, object P1); // 0x00000001866C0FA0-0x00000001866C10E0
		public int __Gen_Wrap_120(object P0, object P1, int P2, bool P3); // 0x00000001866C11D0-0x00000001866C12E4
		public void __Gen_Wrap_121(object P0, VertexAttribute P1); // 0x00000001866C12E4-0x00000001866C13F0
		public int __Gen_Wrap_122(object P0, int P1); // 0x00000001866C13F0-0x00000001866C14DC
		public void __Gen_Wrap_123(NativeArray<int> P0, int P1, int P2); // 0x00000001866C14DC-0x00000001866C1608
		public void __Gen_Wrap_124(object P0, object P1, CancellationToken P2); // 0x00000001866C1608-0x00000001866C1724
		public void __Gen_Wrap_125(NativeArray<quaternion> P0, int P1, quaternion P2); // 0x00000001866C1724-0x00000001866C1874
		public float __Gen_Wrap_126(object P0, in int3 P1, in int3 P2, in int2 P3); // 0x00000001866C1874-0x00000001866C1A40
		public bool __Gen_Wrap_127(object P0, in int3 P1, in int3 P2, in int2 P3, in float3 P4); // 0x00000001866C1A40-0x00000001866C1C58
		public void __Gen_Wrap_128(object P0, NativeArray<float3> P1, float P2); // 0x00000001866C1C58-0x00000001866C1D88
		public void __Gen_Wrap_129(object P0, object P1, object P2, object P3, object P4); // 0x00000001866C1D88-0x00000001866C1EA0
		public GridMap<int> __Gen_Wrap_130(object P0, float P1); // 0x00000001866C1FE4-0x00000001866C20F4
		public ResultCode __Gen_Wrap_131(object P0, object P1); // 0x00000001866C20F4-0x00000001866C2200
		public SelectionData __Gen_Wrap_132(object P0); // 0x00000001866C2200-0x00000001866C22F0
		public void __Gen_Wrap_133(); // 0x00000001863625A4-0x0000000186362640
		public void __Gen_Wrap_134(object P0, DataChunk P1); // 0x00000001866C22F0-0x00000001866C2400
		public void __Gen_Wrap_135(object P0, int P1, int P2); // 0x00000001866C2400-0x00000001866C24F8
		public void __Gen_Wrap_136(object P0, ref TeamManager.TeamData P1, int P2); // 0x00000001866C24F8-0x00000001866C2760
		public System.Threading.Tasks.Task __Gen_Wrap_137(object P0, CancellationToken P1); // 0x00000001866C2760-0x00000001866C288C
		public void __Gen_Wrap_138(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public void __Gen_Wrap_139(Transform P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_140(RenderSetupData.UniqueSerializationData P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_141(VirtualMesh.UniqueSerializationData P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_142(int P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_143(TransformRecord P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_144(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public ref InertiaConstraint.CenterData __Gen_Wrap_145(object P0, int P1); // 0x00000001866C2C1C-0x00000001866C2D14
		public void __Gen_Wrap_146(object P0, Vector3 P1, float P2, ClothForceMode P3); // 0x00000001866C2D14-0x00000001866C2E48
		public void __Gen_Wrap_147(object P0, bool P1, float P2); // 0x00000001866C2E48-0x00000001866C2F2C
		public CheckSliderSerializeData __Gen_Wrap_148(object P0); // 0x00000001866C2F2C-0x00000001866C301C
		public BitField32 __Gen_Wrap_149(object P0); // 0x00000001866C301C-0x00000001866C30F8
		public ClothProcess.RenderMeshInfo __Gen_Wrap_150(object P0, int P1); // 0x00000001866C31CC-0x00000001866C32C4
		public ClothUpdateMode __Gen_Wrap_151(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public void __Gen_Wrap_152(ref ClothProcess.GenerateSelectionJob P0, int P1); // 0x00000001866C32C4-0x00000001866C34C8
		public ReductionSettings __Gen_Wrap_153(object P0); // 0x00000001866C34C8-0x00000001866C35B8
		public CustomSkinningSettings __Gen_Wrap_154(object P0); // 0x00000001866C35B8-0x00000001866C36A8
		public NormalAlignmentSettings __Gen_Wrap_155(object P0); // 0x00000001866C36A8-0x00000001866C3798
		public CullingSettings __Gen_Wrap_156(object P0); // 0x00000001866C3798-0x00000001866C3888
		public CurveSerializeData __Gen_Wrap_157(object P0); // 0x00000001866C3888-0x00000001866C3978
		public InertiaConstraint.SerializeData __Gen_Wrap_158(object P0); // 0x00000001866C3978-0x00000001866C3A68
		public TetherConstraint.SerializeData __Gen_Wrap_159(object P0); // 0x00000001866C3A68-0x00000001866C3B58
		public DistanceConstraint.SerializeData __Gen_Wrap_160(object P0); // 0x00000001866C3C48-0x00000001866C3D38
		public TriangleBendingConstraint.SerializeData __Gen_Wrap_161(object P0); // 0x00000001866C3D38-0x00000001866C3E28
		public AngleConstraint.RestorationSerializeData __Gen_Wrap_162(object P0); // 0x00000001866C3E28-0x00000001866C3F18
		public AngleConstraint.LimitSerializeData __Gen_Wrap_163(object P0); // 0x00000001866C3F18-0x00000001866C4008
		public MotionConstraint.SerializeData __Gen_Wrap_164(object P0); // 0x00000001866C4008-0x00000001866C40F8
		public ColliderCollisionConstraint.SerializeData __Gen_Wrap_165(object P0); // 0x00000001866C40F8-0x00000001866C41E8
		public SelfCollisionConstraint.SerializeData __Gen_Wrap_166(object P0); // 0x00000001866C41E8-0x00000001866C42D8
		public WindSettings __Gen_Wrap_167(object P0); // 0x00000001866C42D8-0x00000001866C43C8
		public void __Gen_Wrap_168(object P0, object P1, bool P2); // 0x00000001866C43C8-0x00000001866C44C0
		public ColliderManager.ColliderType __Gen_Wrap_169(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_170(object P0, Vector3 P1); // 0x00000001866C45B8-0x00000001866C46D4
		public void __Gen_Wrap_171(object P0, float P1, float P2, float P3); // 0x00000001866C46D4-0x00000001866C47D0
		public ClothProcess __Gen_Wrap_172(object P0, int P1); // 0x00000001866C47D0-0x00000001866C48C8
		public void __Gen_Wrap_173(object P0, object P1, int P2, bool P3); // 0x00000001866C48C8-0x00000001866C49C0
		public TimeManager __Gen_Wrap_174(); // 0x00000001866C49C0-0x00000001866C4A78
		public JobHandle __Gen_Wrap_175(object P0, JobHandle P1); // 0x00000001866C4A78-0x00000001866C4BB4
		public void __Gen_Wrap_176(ref AngleConstraint.AngleConstraintJob P0, NativeReference<int> P1); // 0x00000001866C4BB4-0x00000001866C4E14
		public bool __Gen_Wrap_177(in double3 P0, in double3 P1, double P2, out double3 P3); // 0x00000001866C4E14-0x00000001866C4FE4
		public quaternion __Gen_Wrap_178(in double3 P0, in double3 P1, double P2); // 0x00000001866C4FE4-0x00000001866C517C
		public void __Gen_Wrap_179(ref AngleConstraint.AngleConstraintJob P0, int P1); // 0x00000001866C517C-0x00000001866C53B4
		public void __Gen_Wrap_180(ref AngleConstraint.AngleConstraintJob P0); // 0x00000001866C5470-0x00000001866C5694
		public double __Gen_Wrap_181(ref double3 P0, in double3 P1, float P2, in AABB P3, in ColliderManager.WorkData P4, bool P5, float P6, out float3 P7); // 0x00000001866C5694-0x00000001866C59E8
		public double __Gen_Wrap_182(ref double3 P0, float P1, in ColliderManager.WorkData P2, out float3 P3); // 0x00000001866C59E8-0x00000001866C5C6C
		public double __Gen_Wrap_183(ref double3 P0, float P1, in AABB P2, in ColliderManager.WorkData P3, out float3 P4); // 0x00000001866C5C6C-0x00000001866C5F4C
		public float __Gen_Wrap_184(ref double3x2 P0, in double2 P1, in AABB P2, double P3, in ColliderManager.WorkData P4, out float3 P5); // 0x00000001866C5F4C-0x00000001866C6288
		public double __Gen_Wrap_185(ref double3x2 P0, in double2 P1, in AABB P2, double P3, in ColliderManager.WorkData P4, out float3 P5); // 0x00000001866C6288-0x00000001866C65C4
		public double __Gen_Wrap_186(ref double3x2 P0, in double2 P1, in ColliderManager.WorkData P2, out float3 P3); // 0x00000001866C65C4-0x00000001866C688C
		public void __Gen_Wrap_187(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, NativeReference<int> P1); // 0x00000001866C688C-0x00000001866C6AE4
		public double __Gen_Wrap_188(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, in double3 P2, double P3, in AABB P4, in ColliderManager.WorkData P5, bool P6, double P7, out float3 P8); // 0x00000001866C6AE4-0x00000001866C6F98
		public double __Gen_Wrap_189(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, double P2, in AABB P3, in ColliderManager.WorkData P4, out float3 P5); // 0x00000001866C6F98-0x00000001866C73E0
		public double __Gen_Wrap_190(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, double P2, in ColliderManager.WorkData P3, out float3 P4); // 0x00000001866C73E0-0x00000001866C77C8
		public void __Gen_Wrap_191(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, int P1); // 0x00000001866C77C8-0x00000001866C79FC
		public void __Gen_Wrap_192(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0); // 0x00000001866C79FC-0x00000001866C7C14
		public void __Gen_Wrap_193(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, NativeReference<int> P1); // 0x00000001866C7C14-0x00000001866C7E44
		public double __Gen_Wrap_194(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, ref double3x2 P1, in double2 P2, in AABB P3, float P4, in ColliderManager.WorkData P5, out float3 P6); // 0x00000001866C7E44-0x00000001866C82B8
		public double __Gen_Wrap_195(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, ref double3x2 P1, in double2 P2, in ColliderManager.WorkData P3, out float3 P4); // 0x00000001866C82B8-0x00000001866C86B8
		public void __Gen_Wrap_196(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, int P1); // 0x00000001866C86B8-0x00000001866C88C0
		public void __Gen_Wrap_197(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0); // 0x00000001866C88C0-0x00000001866C8AB4
		public void __Gen_Wrap_198(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0, NativeReference<int> P1); // 0x00000001866C8AB4-0x00000001866C8CD4
		public float3 __Gen_Wrap_199(int P0, in NativeArray<int> P1, in NativeArray<int> P2); // 0x00000001866C8CD4-0x00000001866C8E64
		public float __Gen_Wrap_200(int P0, in NativeArray<int> P1); // 0x00000001866C8F9C-0x00000001866C90BC
		public float3 __Gen_Wrap_201(int P0, in NativeArray<int> P1); // 0x00000001866C90BC-0x00000001866C9214
		public void __Gen_Wrap_202(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0, int P1); // 0x00000001866C9214-0x00000001866C940C
		public void __Gen_Wrap_203(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0); // 0x00000001866C940C-0x00000001866C95EC
		public void __Gen_Wrap_204(ref DistanceConstraint.DistanceConstraintJob P0, NativeReference<int> P1); // 0x00000001866C95EC-0x00000001866C9858
		public float __Gen_Wrap_205(ref TeamManager.TeamData P0); // 0x00000001866C9858-0x00000001866C9A8C
		public void __Gen_Wrap_206(ref DistanceConstraint.DistanceConstraintJob P0, int P1); // 0x00000001866C9A8C-0x00000001866C9CD0
		public void __Gen_Wrap_207(ref DistanceConstraint.DistanceConstraintJob P0); // 0x00000001866C9CD0-0x00000001866C9EF8
		public void __Gen_Wrap_208(ref MotionConstraint.MotionConstraintJob P0, NativeReference<int> P1); // 0x00000001866C9EF8-0x00000001866CA140
		public void __Gen_Wrap_209(ref MotionConstraint.MotionConstraintJob P0, int P1); // 0x00000001866CA140-0x00000001866CA364
		public void __Gen_Wrap_210(ref MotionConstraint.MotionConstraintJob P0); // 0x00000001866CA364-0x00000001866CA56C
		public int __Gen_Wrap_211(ref NativeArray<SelfCollisionConstraint.SortData> P0, in SelfCollisionConstraint.SortData P1, in DataChunk P2); // 0x00000001866CA56C-0x00000001866CA748
		public JobHandle __Gen_Wrap_212(in NativeArray<int> P0, in NativeReference<int> P1, float P2, JobHandle P3); // 0x00000001866CA748-0x00000001866CA914
		public JobHandle __Gen_Wrap_213(in ExProcessingList<int> P0, float P1, JobHandle P2); // 0x00000001866CA914-0x00000001866CAA78
		public JobHandle __Gen_Wrap_214(object P0, int P1, JobHandle P2); // 0x00000001866CAA78-0x00000001866CABC4
		public JobHandle __Gen_Wrap_215(NativeArray<byte> P0, int P1, byte P2, JobHandle P3); // 0x00000001866CABC4-0x00000001866CAD48
		public int __Gen_Wrap_216(ref SelfCollisionConstraint.SortData P0, SelfCollisionConstraint.SortData P1); // 0x00000001866CAD48-0x00000001866CAEF8
		public string __Gen_Wrap_217(ref SelfCollisionConstraint.EdgeEdgeContact P0); // 0x00000001866CAEF8-0x00000001866CB06C
		public string __Gen_Wrap_218(ref SelfCollisionConstraint.PointTriangleContact P0); // 0x00000001866CB06C-0x00000001866CB1C8
		public void __Gen_Wrap_219(ref SelfCollisionConstraint.InitPrimitiveJob P0, int P1); // 0x00000001866CB1C8-0x00000001866CB3E0
		public void __Gen_Wrap_220(ref SelfCollisionConstraint.ClearBufferJob P0); // 0x00000001866CB4D0-0x00000001866CB610
		public void __Gen_Wrap_221(ref SelfCollisionConstraint.UpdatePrimitiveJob P0, NativeReference<int> P1); // 0x00000001866CB610-0x00000001866CB848
		public void __Gen_Wrap_222(ref SelfCollisionConstraint.UpdatePrimitiveJob P0, int P1); // 0x00000001866CB848-0x00000001866CBA5C
		public void __Gen_Wrap_223(ref SelfCollisionConstraint.UpdatePrimitiveJob P0); // 0x00000001866CBA5C-0x00000001866CBC54
		public void __Gen_Wrap_224(ref SelfCollisionConstraint.SortJob P0, int P1); // 0x00000001866CBC54-0x00000001866CBDC4
		public void __Gen_Wrap_225(ref SelfCollisionConstraint.SortJob P0); // 0x00000001866CBDC4-0x00000001866CBF18
		public void __Gen_Wrap_226(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, NativeReference<int> P1); // 0x00000001866CBF18-0x00000001866CC160
		public void __Gen_Wrap_227(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2, float P3, float P4, float P5); // 0x00000001866CC160-0x00000001866CC620
		public void __Gen_Wrap_228(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, int P1, ref SelfCollisionConstraint.Primitive P2, in SelfCollisionConstraint.SortData P3, in DataChunk P4, bool P5); // 0x00000001866CC620-0x00000001866CCA44
		public void __Gen_Wrap_229(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, int P1); // 0x00000001866CCA44-0x00000001866CCC68
		public void __Gen_Wrap_230(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0); // 0x00000001866CCDA0-0x00000001866CCFA8
		public void __Gen_Wrap_231(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, NativeReference<int> P1); // 0x00000001866CCFA8-0x00000001866CD18C
		public void __Gen_Wrap_232(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2, float P3, float P4); // 0x00000001866CD18C-0x00000001866CD5DC
		public void __Gen_Wrap_233(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, int P1, ref SelfCollisionConstraint.Primitive P2, in SelfCollisionConstraint.SortData P3, in DataChunk P4, bool P5); // 0x00000001866CD5DC-0x00000001866CD9AC
		public void __Gen_Wrap_234(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, int P1); // 0x00000001866CD9AC-0x00000001866CDB6C
		public void __Gen_Wrap_235(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0); // 0x00000001866CDB6C-0x00000001866CDD10
		public void __Gen_Wrap_236(ref SelfCollisionConstraint.EdgeEdgeToListJob P0); // 0x00000001866CDD10-0x00000001866CDE54
		public void __Gen_Wrap_237(ref SelfCollisionConstraint.PointTriangleToListJob P0); // 0x00000001866CDE54-0x00000001866CDF98
		public void __Gen_Wrap_238(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseJob P0, int P1); // 0x00000001866CDF98-0x00000001866CE0F4
		public void __Gen_Wrap_239(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseJob P0, int P1); // 0x00000001866CE0F4-0x00000001866CE250
		public void __Gen_Wrap_240(ref SelfCollisionConstraint.SolverEdgeEdgeJob P0, int P1); // 0x00000001866CE3A8-0x00000001866CE514
		public void __Gen_Wrap_241(ref SelfCollisionConstraint.SolverPointTriangleJob P0, int P1); // 0x00000001866CE514-0x00000001866CE680
		public void __Gen_Wrap_242(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0, NativeReference<int> P1); // 0x00000001866CE680-0x00000001866CE834
		public void __Gen_Wrap_243(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0, int P1); // 0x00000001866CE834-0x00000001866CE9C4
		public void __Gen_Wrap_244(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0); // 0x00000001866CE9C4-0x00000001866CEB38
		public void __Gen_Wrap_245(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, NativeReference<int> P1); // 0x00000001866CEB38-0x00000001866CED08
		public void __Gen_Wrap_246(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2); // 0x00000001866CED08-0x00000001866CF118
		public void __Gen_Wrap_247(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, ref SelfCollisionConstraint.Primitive P1, in SelfCollisionConstraint.SortData P2, in DataChunk P3, bool P4); // 0x00000001866CF118-0x00000001866CF4B8
		public void __Gen_Wrap_248(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, int P1); // 0x00000001866CF4B8-0x00000001866CF654
		public void __Gen_Wrap_249(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0); // 0x00000001866CF654-0x00000001866CF7D4
		public void __Gen_Wrap_250(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob P0, int P1); // 0x00000001866CF8C4-0x00000001866CFA30
		public void __Gen_Wrap_251(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob P0); // 0x00000001866CFA30-0x00000001866CFB80
		public void __Gen_Wrap_252(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob P0, int P1); // 0x00000001866CFB80-0x00000001866CFCEC
		public void __Gen_Wrap_253(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob P0); // 0x00000001866CFCEC-0x00000001866CFE3C
		public void __Gen_Wrap_254(ref SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob P0, int P1); // 0x00000001866CFE3C-0x00000001866CFFA8
		public void __Gen_Wrap_255(ref SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob P0); // 0x00000001866CFFA8-0x00000001866D00F8
		public void __Gen_Wrap_256(ref SelfCollisionConstraint.SolverPointTriangleCrossFrameJob P0, int P1); // 0x00000001866D00F8-0x00000001866D0264
		public void __Gen_Wrap_257(ref SelfCollisionConstraint.SolverPointTriangleCrossFrameJob P0); // 0x00000001866D0264-0x00000001866D03B4
		public SpringConstraint.SerializeData __Gen_Wrap_258(object P0); // 0x00000001866D03B4-0x00000001866D0490
		public void __Gen_Wrap_259(ref TetherConstraint.TethreConstraintJob P0, NativeReference<int> P1); // 0x00000001866D0490-0x00000001866D06D8
		public void __Gen_Wrap_260(ref TetherConstraint.TethreConstraintJob P0, int P1); // 0x00000001866D07A4-0x00000001866D09C8
		public void __Gen_Wrap_261(ref TetherConstraint.TethreConstraintJob P0); // 0x00000001866D09C8-0x00000001866D0BD0
		public bool __Gen_Wrap_262(in double3x4 P0, in double4 P1, double P2, double P3, ref double3x4 P4); // 0x00000001866D0BD0-0x00000001866D0E44
		public bool __Gen_Wrap_263(double P0, in double3x4 P1, in double4 P2, double P3, double P4, ref double3x4 P5); // 0x00000001866D0E44-0x00000001866D10C8
		public void __Gen_Wrap_264(ref TriangleBendingConstraint.TriangleBendingJob P0, NativeReference<int> P1); // 0x00000001866D10C8-0x00000001866D1334
		public bool __Gen_Wrap_265(ref TriangleBendingConstraint.TriangleBendingJob P0, in double3x4 P1, in double4 P2, double P3, double P4, ref double3x4 P5); // 0x00000001866D1334-0x00000001866D1728
		public bool __Gen_Wrap_266(ref TriangleBendingConstraint.TriangleBendingJob P0, double P1, in double3x4 P2, in double4 P3, double P4, double P5, ref double3x4 P6); // 0x00000001866D1728-0x00000001866D1B38
		public void __Gen_Wrap_267(ref TriangleBendingConstraint.TriangleBendingJob P0, int P1); // 0x00000001866D1B38-0x00000001866D1D7C
		public void __Gen_Wrap_268(ref TriangleBendingConstraint.TriangleBendingJob P0); // 0x00000001866D1D7C-0x00000001866D1FA4
		public void __Gen_Wrap_269(ref TriangleBendingConstraint.SolveAggregateBufferJob P0, NativeReference<int> P1); // 0x00000001866D1FA4-0x00000001866D2184
		public void __Gen_Wrap_270(ref TriangleBendingConstraint.SolveAggregateBufferJob P0, int P1); // 0x00000001866D22A8-0x00000001866D2464
		public void __Gen_Wrap_271(ref TriangleBendingConstraint.SolveAggregateBufferJob P0); // 0x00000001866D2464-0x00000001866D2604
		public void __Gen_Wrap_272(object P0, float P1, float P2, float P3, bool P4); // 0x00000001866D2604-0x00000001866D2714
		public void __Gen_Wrap_273(object P0, float P1, object P2); // 0x00000001866D2714-0x00000001866D27F8
		public NativeArray<float3> __Gen_Wrap_274(object P0, float4x4 P1); // 0x00000001866D27F8-0x00000001866D294C
		public void __Gen_Wrap_275(ref SelectionData.TransformPositionJob P0, int P1); // 0x00000001866D294C-0x00000001866D2AC8
		public void __Gen_Wrap_276(ref SelectionData.CreateGridMapJob P0); // 0x00000001866D2AC8-0x00000001866D2C18
		public void __Gen_Wrap_277(ref SelectionData.ConvertSelectionJob P0, int P1); // 0x00000001866D2C18-0x00000001866D2DA8
		public WindManager __Gen_Wrap_278(); // 0x00000001866D2DA8-0x00000001866D2E60
		public Vector3 __Gen_Wrap_279(object P0, bool P1); // 0x00000001866D2E60-0x00000001866D2F80
		public void __Gen_Wrap_280(object P0, Vector3 P1, bool P2); // 0x00000001866D30DC-0x00000001866D3200
		public bool __Gen_Wrap_281(ref WindParams P0); // 0x00000001866D3200-0x00000001866D3350
		public bool __Gen_Wrap_282(object P0, object P1, object P2); // 0x00000001866D3350-0x00000001866D3444
		public bool __Gen_Wrap_283(object P0, object P1, int P2, int P3); // 0x00000001866D3444-0x00000001866D354C
		public void __Gen_Wrap_284(object P0, object P1, TransformAccessArray P2); // 0x00000001866D354C-0x00000001866D3668
		public DataChunk __Gen_Wrap_285(object P0, DataChunk P1, int P2); // 0x00000001866D3668-0x00000001866D3790
		public float __Gen_Wrap_286(); // 0x00000001866D3790-0x00000001866D3828
		public JobHandle __Gen_Wrap_287(object P0, JobHandle P1, ref NativeParallelHashMap<int, int> P2, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> P3, ref NativeParallelHashMap<int, int> P4); // 0x00000001866D3828-0x00000001866D3AB8
		public void __Gen_Wrap_288(ref DynamicBoneTransformManager.ValidTransformJob P0, int P1); // 0x00000001866D3AB8-0x00000001866D3C48
		public JobHandle __Gen_Wrap_289(object P0, int P1, int P2, JobHandle P3); // 0x00000001866D3C48-0x00000001866D3DA4
		public JobHandle __Gen_Wrap_290(object P0, bool P1, DataChunk P2, JobHandle P3); // 0x00000001866D3E94-0x00000001866D4014
		public JobHandle __Gen_Wrap_291(object P0, DataChunk P1, JobHandle P2); // 0x00000001866D4014-0x00000001866D4178
		public VirtualMeshContainer __Gen_Wrap_292(object P0); // 0x00000001866D4178-0x00000001866D4254
		public VirtualMeshContainer __Gen_Wrap_293(object P0, int P1); // 0x00000001866D4254-0x00000001866D434C
		public void __Gen_Wrap_294(ref DoAllInOneJob P0); // 0x00000001866D434C-0x00000001866D448C
		public void __Gen_Wrap_295(ref DynamicBoneTransformManager.ReadAnimatorBufferDataJob P0, int P1, TransformAccess P2); // 0x00000001866D448C-0x00000001866D46D8
		public void __Gen_Wrap_296(ref DynamicBoneTransformManager.WriteAnimatorBufferDataJob P0); // 0x00000001866D46D8-0x00000001866D48B8
		public void __Gen_Wrap_297(ref DynamicBoneTransformManager.CopyDoubleBufferJob P0); // 0x00000001866D48B8-0x00000001866D4A58
		public void __Gen_Wrap_298(ref DynamicBoneTransformManager.EnableTransformJob P0); // 0x00000001866D4A58-0x00000001866D4B88
		public void __Gen_Wrap_299(ref DynamicBoneTransformManager.RestoreTransformJob P0, int P1, TransformAccess P2); // 0x00000001866D4B88-0x00000001866D4D44
		public void __Gen_Wrap_300(ref DynamicBoneTransformManager.ReadTransformJob P0, int P1, TransformAccess P2); // 0x00000001866D4FB4-0x00000001866D51D4
		public void __Gen_Wrap_301(ref DynamicBoneTransformManager.ValidTransformJob P0); // 0x00000001866D51D4-0x00000001866D5348
		public void __Gen_Wrap_302(ref DynamicBoneTransformManager.WriteTransformJob P0, int P1, TransformAccess P2); // 0x00000001866D5348-0x00000001866D5534
		public void __Gen_Wrap_303(ref DynamicBoneTransformManager.ReadComponentTransformJob P0, int P1, TransformAccess P2); // 0x00000001866D5534-0x00000001866D56B0
		public void __Gen_Wrap_304(ClothProcess P0); // 0x00000001866C296C-0x00000001866C2A18
		public int __Gen_Wrap_305(ref TeamManager.MappingData P0); // 0x00000001866D56B0-0x00000001866D5898
		public int __Gen_Wrap_306(ref TeamWindData P0); // 0x00000001866D5898-0x00000001866D5A88
		public string __Gen_Wrap_307(ref TeamWindInfo P0); // 0x00000001866D5A88-0x00000001866D5BDC
		public bool __Gen_Wrap_308(ref TeamManager.MappingData P0); // 0x00000001866D5BDC-0x00000001866D5DC4
		public void __Gen_Wrap_309(ref TeamManager.AlwaysTeamUpdatePreJob P0); // 0x00000001866D5DC4-0x00000001866D5F64
		public void __Gen_Wrap_310(ref TeamManager.AlwaysTeamUpdatePostJob P0, int P1, ref TeamManager.TeamData P2); // 0x00000001866D60B8-0x00000001866D6470
		public void __Gen_Wrap_311(ref TeamManager.AlwaysTeamUpdatePostJob P0); // 0x00000001866D6470-0x00000001866D66A8
		public void __Gen_Wrap_312(ref TeamManager.CalcCenterAndInertiaAndWindJob P0, int P1); // 0x00000001866D66A8-0x00000001866D68DC
		public double3 __Gen_Wrap_313(in double3 P0, in double3 P1, in double3 P2, in quaternion P3); // 0x00000001866D68DC-0x00000001866D6AF8
		public bool __Gen_Wrap_314(ref WindManager.WindData P0); // 0x00000001866D6AF8-0x00000001866D6D1C
		public bool __Gen_Wrap_315(ref TeamWindInfo P0); // 0x00000001866D6D1C-0x00000001866D6E60
		public int __Gen_Wrap_316(ref TeamWindData P0, int P1); // 0x00000001866D6E60-0x00000001866D7068
		public void __Gen_Wrap_317(ref TeamWindData P0, TeamWindInfo P1, in TeamWindData P2); // 0x00000001866D7068-0x00000001866D7324
		public void __Gen_Wrap_318(ref TeamWindData P0, int P1); // 0x00000001866D7324-0x00000001866D751C
		public void __Gen_Wrap_319(ref TeamManager.CalcCenterAndInertiaAndWindJob P0, int P1, in ClothParameters P2, in double3 P3); // 0x00000001866D751C-0x00000001866D7854
		public void __Gen_Wrap_320(ref TeamManager.CalcCenterAndInertiaAndWindJob P0); // 0x00000001866D79F8-0x00000001866D7C10
		public void __Gen_Wrap_321(ref TeamManager.SimulationStepTeamUpdateJob P0, int P1); // 0x00000001866D7C10-0x00000001866D7D8C
		public void __Gen_Wrap_322(ref TeamManager.SimulationStepTeamUpdateJob P0, ref TeamWindInfo P1, float P2, float P3); // 0x00000001866D7D8C-0x00000001866D7FA8
		public void __Gen_Wrap_323(ref TeamManager.SimulationStepTeamUpdateJob P0, int P1, in TeamManager.TeamData P2, in WindParams P3, in InertiaConstraint.CenterData P4); // 0x00000001866D7FA8-0x00000001866D8310
		public void __Gen_Wrap_324(ref TeamManager.SimulationStepTeamUpdateJob P0); // 0x00000001866D8310-0x00000001866D8470
		public void __Gen_Wrap_325(ref TeamManager.PostTeamUpdateJob P0, int P1); // 0x00000001866D8470-0x00000001866D85D0
		public void __Gen_Wrap_326(ref TeamManager.PostTeamUpdateJob P0); // 0x00000001866D85D0-0x00000001866D8714
		public void __Gen_Wrap_327(ref VirtualMeshManager.ClearProxyMeshUpdateBufferJob P0); // 0x00000001866D8714-0x00000001866D8864
		public void __Gen_Wrap_328(ref VirtualMeshManager.CreateProxyMeshUpdateVertexList P0, int P1); // 0x00000001866D8864-0x00000001866D89D4
		public int __Gen_Wrap_329(ref NativeReference<int> P0, int P1); // 0x00000001866D89D4-0x00000001866D8B20
		public void __Gen_Wrap_330(ref VirtualMeshManager.CreateProxyMeshUpdateVertexList P0); // 0x00000001866D8C64-0x00000001866D8DB8
		public void __Gen_Wrap_331(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0, NativeReference<int> P1); // 0x00000001866D8DB8-0x00000001866D9010
		public int __Gen_Wrap_332(ref VirtualMeshBoneWeight P0); // 0x00000001866D9010-0x00000001866D9150
		public void __Gen_Wrap_333(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0, int P1); // 0x00000001866D9150-0x00000001866D9384
		public void __Gen_Wrap_334(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0); // 0x00000001866D9384-0x00000001866D959C
		public void __Gen_Wrap_335(ref VirtualMeshManager.CreatePostProxyMeshUpdateListJob P0, int P1); // 0x00000001866D959C-0x00000001866D9794
		public void __Gen_Wrap_336(ref VirtualMeshManager.CreatePostProxyMeshUpdateListJob P0); // 0x00000001866D9794-0x00000001866D9970
		public void __Gen_Wrap_337(ref VirtualMeshManager.CalcLineNormalTangentJob P0, NativeReference<int> P1); // 0x00000001866D9970-0x00000001866D9B90
		public void __Gen_Wrap_338(ref VirtualMeshManager.CalcLineNormalTangentJob P0, int P1); // 0x00000001866D9B90-0x00000001866D9D88
		public void __Gen_Wrap_339(ref VirtualMeshManager.CalcLineNormalTangentJob P0); // 0x00000001866D9D88-0x00000001866D9F6C
		public void __Gen_Wrap_340(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0, NativeReference<int> P1); // 0x00000001866DA18C-0x00000001866DA398
		public double3 __Gen_Wrap_341(in double3 P0, in double3 P1, in double3 P2, in float2 P3, in float2 P4, in float2 P5); // 0x00000001866DA398-0x00000001866DA62C
		public void __Gen_Wrap_342(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0, int P1); // 0x00000001866DA62C-0x00000001866DA810
		public void __Gen_Wrap_343(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0); // 0x00000001866DA810-0x00000001866DA9D8
		public void __Gen_Wrap_344(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0, NativeReference<int> P1); // 0x00000001866DA9D8-0x00000001866DABE4
		public void __Gen_Wrap_345(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0, int P1); // 0x00000001866DABE4-0x00000001866DADC8
		public void __Gen_Wrap_346(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0); // 0x00000001866DADC8-0x00000001866DAF90
		public void __Gen_Wrap_347(ref VirtualMeshManager.WriteTransformDataJob P0, NativeReference<int> P1); // 0x00000001866DAF90-0x00000001866DB19C
		public void __Gen_Wrap_348(ref VirtualMeshManager.WriteTransformDataJob P0, int P1); // 0x00000001866DB19C-0x00000001866DB380
		public void __Gen_Wrap_349(ref VirtualMeshManager.WriteTransformDataJob P0); // 0x00000001866DB380-0x00000001866DB548
		public void __Gen_Wrap_350(ref VirtualMeshManager.WriteTransformLocalDataJob P0, NativeReference<int> P1); // 0x00000001866DB754-0x00000001866DB984
		public void __Gen_Wrap_351(ref VirtualMeshManager.WriteTransformLocalDataJob P0, int P1); // 0x00000001866DB984-0x00000001866DBB8C
		public void __Gen_Wrap_352(ref VirtualMeshManager.WriteTransformLocalDataJob P0); // 0x00000001866DBB8C-0x00000001866DBD78
		public void __Gen_Wrap_353(ref VirtualMeshManager.CalcMeshConvertMatrixJob P0, int P1); // 0x00000001866DBD78-0x00000001866DBF08
		public void __Gen_Wrap_354(ref VirtualMeshManager.CalcMeshConvertMatrixJob P0); // 0x00000001866DBF08-0x00000001866DC07C
		public void __Gen_Wrap_355(ref VirtualMeshManager.CalcProxySkinningJob P0, int P1); // 0x00000001866DC07C-0x00000001866DC2D0
		public void __Gen_Wrap_356(ref VirtualMeshManager.CalcProxySkinningJob P0); // 0x00000001866DC2D0-0x00000001866DC508
		public bool __Gen_Wrap_357(PlayerLoopSystem P0); // 0x00000001866DC508-0x00000001866DC60C
		public bool __Gen_Wrap_358(ref PlayerLoopSystem P0); // 0x00000001866DC60C-0x00000001866DC768
		public void __Gen_Wrap_359(PlayerLoopSystem P0, ref PlayerLoopSystem P1, object P2, object P3, bool P4, bool P5); // 0x00000001866DC768-0x00000001866DC940
		public void __Gen_Wrap_360(ref PlayerLoopSystem P0); // 0x00000001866DCAF8-0x00000001866DCC44
		public void __Gen_Wrap_361(bool P0); // 0x00000001866DCC44-0x00000001866DCCF0
		public void __Gen_Wrap_362(float P0); // 0x00000001866DCCF0-0x00000001866DCD9C
		public void __Gen_Wrap_363(bool P0, float P1); // 0x00000001866DCD9C-0x00000001866DCE68
		public int __Gen_Wrap_364(); // 0x0000000186377214-0x00000001863772AC
		public void __Gen_Wrap_365(TimeManager.UpdateLocation P0); // 0x0000000186301ED4-0x0000000186301F80
		public TimeManager.UpdateLocation __Gen_Wrap_366(); // 0x0000000186377214-0x00000001863772AC
		public void __Gen_Wrap_367(MagicaManager.InitializationLocation P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_368(ref BeyondDynamicBone.RenderData.UpdatePositionNormalJob P0, int P1); // 0x00000001866DCE68-0x00000001866DD004
		public void __Gen_Wrap_369(ref BeyondDynamicBone.RenderData.UpdatePositionNormalJob P0); // 0x00000001866DD004-0x00000001866DD184
		public void __Gen_Wrap_370(ref BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob P0, int P1); // 0x00000001866DD33C-0x00000001866DD520
		public void __Gen_Wrap_371(ref BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob P0); // 0x00000001866DD520-0x00000001866DD6E8
		public void __Gen_Wrap_372(ref BeyondDynamicBone.RenderData.UpdateBoneWeightJob2 P0, int P1); // 0x00000001866DD6E8-0x00000001866DD874
		public void __Gen_Wrap_373(ref BeyondDynamicBone.RenderData.UpdateBoneWeightJob2 P0); // 0x00000001866DD874-0x00000001866DD9E4
		public RenderSetupData.ShareSerializationData __Gen_Wrap_374(object P0); // 0x00000001866DD9E4-0x00000001866DDAC0
		public RenderSetupData.UniqueSerializationData __Gen_Wrap_375(object P0); // 0x00000001866DDAC0-0x00000001866DDB9C
		public void __Gen_Wrap_376(ref RenderSetupData.VertexWeight5BoneCheckJob P0); // 0x00000001866DDB9C-0x00000001866DDCE0
		public void __Gen_Wrap_377(ref RenderSetupData.ReadTransformJob P0, int P1, TransformAccess P2); // 0x00000001866DDCE0-0x00000001866DDEB4
		public void __Gen_Wrap_378(ref RenderSetupData.GetBoneWeightJos P0); // 0x00000001866DDEB4-0x00000001866DE008
		public void __Gen_Wrap_379(ref ColliderManager.PreSimulationUpdateJob P0, int P1); // 0x00000001866DE008-0x00000001866DE210
		public void __Gen_Wrap_380(ref ColliderManager.PreSimulationUpdateJob P0); // 0x00000001866DE394-0x00000001866DE588
		public void __Gen_Wrap_381(ref ColliderManager.CreateUpdatecolliderListJob P0, int P1); // 0x00000001866DE588-0x00000001866DE6F4
		public void __Gen_Wrap_382(ref ColliderManager.CreateUpdatecolliderListJob P0); // 0x00000001866DE6F4-0x00000001866DE844
		public void __Gen_Wrap_383(ref ColliderManager.StartSimulationStepJob P0, NativeReference<int> P1); // 0x00000001866DE844-0x00000001866DEA64
		public void __Gen_Wrap_384(ref ColliderManager.StartSimulationStepJob P0, int P1); // 0x00000001866DEA64-0x00000001866DEC5C
		public void __Gen_Wrap_385(ref ColliderManager.StartSimulationStepJob P0); // 0x00000001866DEC5C-0x00000001866DEE40
		public void __Gen_Wrap_386(ref ColliderManager.EndSimulationStepJob P0, NativeReference<int> P1); // 0x00000001866DEE40-0x00000001866DEFF0
		public void __Gen_Wrap_387(ref ColliderManager.EndSimulationStepJob P0, int P1); // 0x00000001866DEFF0-0x00000001866DF17C
		public void __Gen_Wrap_388(ref ColliderManager.EndSimulationStepJob P0); // 0x00000001866DF17C-0x00000001866DF2EC
		public void __Gen_Wrap_389(ref ColliderManager.PostSimulationUpdateJob P0, int P1); // 0x00000001866DF2EC-0x00000001866DF48C
		public void __Gen_Wrap_390(ref ColliderManager.PostSimulationUpdateJob P0); // 0x00000001866DF5F4-0x00000001866DF778
		public JobHandle __Gen_Wrap_391(object P0, in NativeList<int> P1, JobHandle P2); // 0x00000001866DF778-0x00000001866DF900
		public JobHandle __Gen_Wrap_392(object P0, in NativeArray<int> P1, in NativeReference<int> P2, JobHandle P3); // 0x00000001866DF900-0x00000001866DFACC
		public JobHandle __Gen_Wrap_393(object P0, in ExProcessingList<int> P1, JobHandle P2); // 0x00000001866DFACC-0x00000001866DFC30
		public void __Gen_Wrap_394(ref SimulationManager.PreSimulationUpdateJob P0, int P1); // 0x00000001866DFC30-0x00000001866DFE78
		public void __Gen_Wrap_395(ref SimulationManager.PreSimulationUpdateJob P0); // 0x00000001866DFE78-0x00000001866E00AC
		public void __Gen_Wrap_396(ref SimulationManager.ClearStepCounter P0); // 0x00000001866E00AC-0x00000001866E028C
		public void __Gen_Wrap_397(ref SimulationManager.CreateUpdateParticleList P0, int P1); // 0x00000001866E028C-0x00000001866E04C4
		public void __Gen_Wrap_398(ref SimulationManager.CreateUpdateParticleList P0); // 0x00000001866E04C4-0x00000001866E06E8
		public void __Gen_Wrap_399(ref SimulationManager.StartSimulationStepJob P0, NativeReference<int> P1); // 0x00000001866E06E8-0x00000001866E0918
		public void __Gen_Wrap_400(ref SimulationManager.StartSimulationStepJob P0, in TeamWindInfo P1, in WindParams P2, in float3 P3, float P4, ref float3 P5); // 0x00000001866E0B88-0x00000001866E0F2C
		public void __Gen_Wrap_401(ref SimulationManager.StartSimulationStepJob P0, int P1, in TeamManager.TeamData P2, in WindParams P3, in InertiaConstraint.CenterData P4, int P5, int P6, float P7, ref float3 P8); // 0x00000001866E0F2C-0x00000001866E13D0
		public void __Gen_Wrap_402(ref SimulationManager.StartSimulationStepJob P0, in SpringConstraint.SpringConstraintParams P1, ClothNormalAxis P2, ref double3 P3, in double3 P4, in quaternion P5, double P6, float P7); // 0x00000001866E13D0-0x00000001866E1784
		public void __Gen_Wrap_403(ref SimulationManager.StartSimulationStepJob P0, int P1); // 0x00000001866E1784-0x00000001866E198C
		public void __Gen_Wrap_404(ref SimulationManager.StartSimulationStepJob P0); // 0x00000001866E198C-0x00000001866E1B80
		public void __Gen_Wrap_405(ref SimulationManager.UpdateStepBasicPotureJob P0, NativeReference<int> P1); // 0x00000001866E1B80-0x00000001866E1DD8
		public void __Gen_Wrap_406(ref SimulationManager.UpdateStepBasicPotureJob P0, int P1); // 0x00000001866E1DD8-0x00000001866E200C
		public void __Gen_Wrap_407(ref SimulationManager.UpdateStepBasicPotureJob P0); // 0x00000001866E200C-0x00000001866E2224
		public void __Gen_Wrap_408(ref SimulationManager.EndSimulationStepJob P0, NativeReference<int> P1); // 0x00000001866E2224-0x00000001866E2444
		public void __Gen_Wrap_409(ref SimulationManager.EndSimulationStepJob P0, int P1); // 0x00000001866E2444-0x00000001866E263C
		public void __Gen_Wrap_410(ref SimulationManager.EndSimulationStepJob P0); // 0x00000001866E2708-0x00000001866E28EC
		public void __Gen_Wrap_411(ref SimulationManager.CalcDisplayPositionJob P0, int P1); // 0x00000001866E28EC-0x00000001866E2B00
		public void __Gen_Wrap_412(ref SimulationManager.CalcDisplayPositionJob P0); // 0x00000001866E2B00-0x00000001866E2CF8
		public void __Gen_Wrap_413(ref SimulationManager.FeedbackTempPosJob P0, int P1); // 0x00000001866E2CF8-0x00000001866E2E54
		public void __Gen_Wrap_414(ref SimulationManager.FeedbackTempPosJob2 P0, int P1); // 0x00000001866E2E54-0x00000001866E2FB0
		public void __Gen_Wrap_415(object P0, ref TeamManager.TeamData P1); // 0x00000001866E2FB0-0x00000001866E31E8
		public void __Gen_Wrap_416(object P0, ref TeamManager.TeamData P1, object P2, object P3); // 0x00000001866E31E8-0x00000001866E3450
		public void __Gen_Wrap_417(object P0, object P1, object P2, object P3, object P4, object P5); // 0x000000018637415C-0x0000000186374274
		public void __Gen_Wrap_418(ref TeamWindInfo P0); // 0x00000001866E3450-0x00000001866E3584
		public void __Gen_Wrap_419(ref TeamWindData P0); // 0x00000001866E3584-0x00000001866E3760
		public int __Gen_Wrap_420(object P0, object P1, int P2, int P3, byte P4, bool P5); // 0x00000001866E3850-0x00000001866E3974
		public int[] __Gen_Wrap_421(object P0, object P1, object P2, object P3, int P4); // 0x00000001866E3974-0x00000001866E3AA8
		public int[] __Gen_Wrap_422(object P0, object P1, int P2); // 0x00000001866E3AA8-0x00000001866E3BBC
		public int __Gen_Wrap_423(object P0, int P1, object P2, int P3, int P4, byte P5); // 0x00000001866E3BBC-0x00000001866E3CE0
		public float4x4 __Gen_Wrap_424(object P0, int P1); // 0x00000001866E3CE0-0x00000001866E3E0C
		public BeyondDynamicBone.TransformData.ShareSerializationData __Gen_Wrap_425(object P0); // 0x00000001866E3E0C-0x00000001866E3EE8
		public BeyondDynamicBone.TransformData.UniqueSerializationData __Gen_Wrap_426(object P0); // 0x00000001866E3EE8-0x00000001866E3FC4
		public void __Gen_Wrap_427(ref BeyondDynamicBone.TransformData.RestoreTransformJob P0, int P1, TransformAccess P2); // 0x00000001866E3FC4-0x00000001866E4174
		public void __Gen_Wrap_428(ref BeyondDynamicBone.TransformData.ReadTransformJob P0, int P1, TransformAccess P2); // 0x00000001866E4174-0x00000001866E4360
		public Vector3 __Gen_Wrap_429(object P0, Vector3 P1); // 0x00000001866E4360-0x00000001866E44A8
		public SharePreBuildData __Gen_Wrap_430(object P0, object P1); // 0x00000001866E4598-0x00000001866E4690
		public bool __Gen_Wrap_431(SharePreBuildData P0); // 0x00000001866C53B4-0x00000001866C5470
		public void __Gen_Wrap_432(SharePreBuildData P0); // 0x00000001866C296C-0x00000001866C2A18
		public string __Gen_Wrap_433(); // 0x00000001866E4690-0x00000001866E4748
		public void __Gen_Wrap_434(ref SameDistanceReduction.InitGridJob P0); // 0x00000001866E4748-0x00000001866E489C
		public void __Gen_Wrap_435(ref SameDistanceReduction.SearchJoinJob P0); // 0x00000001866E489C-0x00000001866E49FC
		public bool __Gen_Wrap_436(ref VirtualMeshBoneWeight P0); // 0x00000001866E49FC-0x00000001866E4B3C
		public void __Gen_Wrap_437(ref VirtualMeshBoneWeight P0, int P1, float P2); // 0x00000001866E4B3C-0x00000001866E4CA4
		public void __Gen_Wrap_438(ref VirtualMeshBoneWeight P0, in VirtualMeshBoneWeight P1); // 0x00000001866E4CA4-0x00000001866E4E20
		public void __Gen_Wrap_439(ref SameDistanceReduction.JoinJob2 P0); // 0x00000001866E4E20-0x00000001866E4FC4
		public void __Gen_Wrap_440(ref SameDistanceReduction.UpdateJoinIndexJob P0, int P1); // 0x00000001866E50EC-0x00000001866E5228
		public void __Gen_Wrap_441(ref SameDistanceReduction.UpdateLinkIndexJob P0, int P1); // 0x00000001866E5228-0x00000001866E5374
		public void __Gen_Wrap_442(ref VirtualMeshBoneWeight P0); // 0x00000001866E5374-0x00000001866E54A4
		public void __Gen_Wrap_443(ref SameDistanceReduction.FinalMergeVertexJob P0, int P1); // 0x00000001866E54A4-0x00000001866E5600
		public bool __Gen_Wrap_444(in NativeParallelMultiHashMap<ushort, ushort> P0, int P1, int P2, bool P3); // 0x00000001866E5600-0x00000001866E574C
		public void __Gen_Wrap_445(ref ShapeDistanceReduction.SearchJoinEdgeJob P0); // 0x00000001866E574C-0x00000001866E58AC
		public void __Gen_Wrap_446(ref SimpleDistanceReduction.InitGridJob P0); // 0x00000001866E58AC-0x00000001866E5A00
		public void __Gen_Wrap_447(ref SimpleDistanceReduction.SearchJoinEdgeJob P0); // 0x00000001866E5A00-0x00000001866E5B70
		public bool __Gen_Wrap_448(in NativeArray<FixedList128Bytes<ushort>> P0, int P1, int P2, in FixedList128Bytes<ushort> P3, in FixedList128Bytes<ushort> P4, bool P5); // 0x00000001866E5B70-0x00000001866E5DC0
		public bool __Gen_Wrap_449(ref StepReductionBase.JoinEdge P0, in int2 P1); // 0x00000001866E5DC0-0x00000001866E5F4C
		public int __Gen_Wrap_450(ref StepReductionBase.JoinEdge P0, StepReductionBase.JoinEdge P1); // 0x00000001866E603C-0x00000001866E61C8
		public void __Gen_Wrap_451(ref StepReductionBase.DeterminJoinEdgeJob P0); // 0x00000001866E61C8-0x00000001866E632C
		public void __Gen_Wrap_452(ref StepReductionBase.JoinPairJob P0); // 0x00000001866E632C-0x00000001866E64D0
		public void __Gen_Wrap_453(ref StepReductionBase.UpdateJoinIndexJob P0, int P1); // 0x00000001866E64D0-0x00000001866E660C
		public void __Gen_Wrap_454(ref StepReductionBase.UpdateLinkIndexJob P0, int P1); // 0x00000001866E660C-0x00000001866E6758
		public void __Gen_Wrap_455(ref StepReductionBase.FinalMergeVertexJob P0, int P1); // 0x00000001866E6758-0x00000001866E68B4
		public int3 __Gen_Wrap_456(in int3 P0); // 0x00000001866E68B4-0x00000001866E69F8
		public JobHandle __Gen_Wrap_457(NativeArray<int> P0, int P1, int P2, int P3, JobHandle P4); // 0x00000001866E69F8-0x00000001866E6B88
		public JobHandle __Gen_Wrap_458(NativeReference<int> P0, int P1, JobHandle P2); // 0x00000001866E6B88-0x00000001866E6CFC
		public JobHandle __Gen_Wrap_459(NativeArray<int> P0, int P1, JobHandle P2); // 0x00000001866E6CFC-0x00000001866E6E70
		public JobHandle __Gen_Wrap_460(NativeParallelHashSet<int> P0, NativeList<int> P1, JobHandle P2); // 0x00000001866E6F98-0x00000001866E7130
		public JobHandle __Gen_Wrap_461(NativeParallelHashSet<int2> P0, NativeList<int2> P1, JobHandle P2); // 0x00000001866E7130-0x00000001866E72C8
		public JobHandle __Gen_Wrap_462(NativeParallelHashSet<int4> P0, NativeList<int4> P1, JobHandle P2); // 0x00000001866E72C8-0x00000001866E7460
		public JobHandle __Gen_Wrap_463(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, JobHandle P3); // 0x00000001866E7460-0x00000001866E7608
		public JobHandle __Gen_Wrap_464(NativeList<float3> P0, NativeReference<AABB> P1, JobHandle P2); // 0x00000001866E7608-0x00000001866E77A0
		public void __Gen_Wrap_465(NativeList<float3> P0, NativeReference<AABB> P1); // 0x00000001866E77A0-0x00000001866E78C8
		public AABB __Gen_Wrap_466(in NativeArray<float3> P0, int P1); // 0x00000001866E78C8-0x00000001866E7A28
		public JobHandle __Gen_Wrap_467(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, NativeArray<float2> P3, JobHandle P4); // 0x00000001866E7A28-0x00000001866E7C08
		public JobHandle __Gen_Wrap_468(NativeArray<float3> P0, int P1, in float4x4 P2, JobHandle P3); // 0x00000001866E7C08-0x00000001866E7DDC
		public JobHandle __Gen_Wrap_469(NativeArray<float3> P0, NativeArray<float3> P1, int P2, in float4x4 P3, JobHandle P4); // 0x00000001866E7DDC-0x00000001866E7FD8
		public JobHandle __Gen_Wrap_470(NativeReference<int> P0, JobHandle P1); // 0x00000001866E80A4-0x00000001866E8204
		public void __Gen_Wrap_471(ref ClothJobUtility.SerialNumberJob P0, int P1); // 0x00000001866E8204-0x00000001866E8340
		public void __Gen_Wrap_472(ref ClothJobUtility.CalcAABBJob P0); // 0x00000001866E8340-0x00000001866E8484
		public void __Gen_Wrap_473(ref ClothJobUtility.CalcAABBDeferJob P0); // 0x00000001866E8484-0x00000001866E85B4
		public void __Gen_Wrap_474(ref ClothJobUtility.CalcUVJob P0, int P1); // 0x00000001866E85B4-0x00000001866E8710
		public void __Gen_Wrap_475(ref ClothJobUtility.AddIntDataCopyJob P0, int P1); // 0x00000001866E8710-0x00000001866E8870
		public void __Gen_Wrap_476(ref ClothJobUtility.AddInt2DataCopyJob P0, int P1); // 0x00000001866E8870-0x00000001866E89CC
		public void __Gen_Wrap_477(ref ClothJobUtility.AddInt3DataCopyJob P0, int P1); // 0x00000001866E89CC-0x00000001866E8B28
		public void __Gen_Wrap_478(ref ClothJobUtility.TransformPositionJob P0, int P1); // 0x00000001866E8B28-0x00000001866E8CA4
		public void __Gen_Wrap_479(ref ClothJobUtility.TransformPositionJob2 P0, int P1); // 0x00000001866E8CA4-0x00000001866E8E30
		public void __Gen_Wrap_480(ref ClothJobUtility.ClearReferenceJob P0); // 0x00000001866E8F38-0x00000001866E905C
		public JobHandle __Gen_Wrap_481(in NativeList<int> P0, float P1, JobHandle P2); // 0x00000001866E905C-0x00000001866E91E4
		public void __Gen_Wrap_482(ref InterlockUtility.AggregateJob P0, int P1); // 0x00000001866E91E4-0x00000001866E9350
		public void __Gen_Wrap_483(ref InterlockUtility.AggregateJob P0); // 0x00000001866E9350-0x00000001866E94A0
		public void __Gen_Wrap_484(ref InterlockUtility.AggregateWithVelocityJob P0, int P1); // 0x00000001866E94A0-0x00000001866E9630
		public void __Gen_Wrap_485(ref InterlockUtility.AggregateWithVelocityJob P0); // 0x00000001866E9630-0x00000001866E97A4
		public void __Gen_Wrap_486(ref InterlockUtility.AggregateJob2 P0, NativeReference<int> P1); // 0x00000001866E97A4-0x00000001866E9944
		public void __Gen_Wrap_487(ref InterlockUtility.AggregateJob2 P0, int P1); // 0x00000001866E9944-0x00000001866E9AC0
		public void __Gen_Wrap_488(ref InterlockUtility.AggregateJob2 P0); // 0x00000001866E9AC0-0x00000001866E9C20
		public void __Gen_Wrap_489(ref InterlockUtility.AggregateWithVelocityJob2 P0, NativeReference<int> P1); // 0x00000001866E9C20-0x00000001866E9DF4
		public void __Gen_Wrap_490(ref InterlockUtility.AggregateWithVelocityJob2 P0, int P1); // 0x00000001866E9DF4-0x00000001866E9F94
		public void __Gen_Wrap_491(ref InterlockUtility.AggregateWithVelocityJob2 P0); // 0x00000001866E9F94-0x00000001866EA118
		public void __Gen_Wrap_492(ref InterlockUtility.AggregateWithVelocityCrossFrameJob2 P0, int P1); // 0x00000001866EA118-0x00000001866EA2B8
		public void __Gen_Wrap_493(ref InterlockUtility.AggregateWithVelocityCrossFrameJob2 P0); // 0x00000001866EA2B8-0x00000001866EA43C
		public void __Gen_Wrap_494(ref InterlockUtility.AggregateCrossFrameJob2 P0, int P1); // 0x00000001866EA43C-0x00000001866EA5B8
		public void __Gen_Wrap_495(ref InterlockUtility.AggregateCrossFrameJob2 P0); // 0x00000001866EA5B8-0x00000001866EA718
		public bool __Gen_Wrap_496(ref AABB P0); // 0x00000001866EA718-0x00000001866EA868
		public string __Gen_Wrap_497(ref AABB P0); // 0x00000001866EA868-0x00000001866EA9CC
		public int3 __Gen_Wrap_498(ref IntAABB P0); // 0x00000001866EA9CC-0x00000001866EAB44
		public bool __Gen_Wrap_499(ref IntAABB P0); // 0x00000001866EAB44-0x00000001866EAC88
		public void __Gen_Wrap_500(float3 P0, quaternion P1, float3 P2, quaternion P3, out float3 P4, out quaternion P5); // 0x00000001866EADA0-0x00000001866EAFE8
		public float3 __Gen_Wrap_501(in float3 P0, in float3 P1, in float3 P2, in float2 P3, in float2 P4, in float2 P5); // 0x00000001866EAFE8-0x00000001866EB274
		public int2 __Gen_Wrap_502(int3 P0, int3 P1); // 0x00000001866EB274-0x00000001866EB3BC
		public int4 __Gen_Wrap_503(int3 P0, int3 P1); // 0x00000001866EB3BC-0x00000001866EB520
		public bool __Gen_Wrap_504(in float3 P0, in float3 P1, float3 P2, float3 P3, float3 P4, bool P5, out float P6, out float P7, out float P8, out float P9); // 0x00000001866EB520-0x00000001866EB800
		public bool __Gen_Wrap_505(in float3 P0, in float3 P1, float3 P2, float3 P3, float3 P4); // 0x00000001866EB800-0x00000001866EB9F8
		public float __Gen_Wrap_506(Vector3 P0, Vector3 P1, Vector3 P2); // 0x00000001866EB9F8-0x00000001866EBB68
		public BeyondDynamicBone.FTransform __Gen_Wrap_507(); // 0x00000001866EBB68-0x00000001866EBC54
		public Mesh __Gen_Wrap_508(object P0); // 0x00000001866EBC54-0x00000001866EBD30
		public StringBuilder __Gen_Wrap_509(); // 0x00000001866EBD30-0x00000001866EBDE8
		public StringBuilder __Gen_Wrap_510(object P0); // 0x00000001866EBEF4-0x00000001866EBFD0
		public string __Gen_Wrap_511(ref DataChunk P0); // 0x00000001866EBFD0-0x00000001866EC108
		public void __Gen_Wrap_512(ref ExBitFlag16 P0); // 0x00000001866EC108-0x00000001866EC224
		public bool __Gen_Wrap_513(ref ExCostSortedList1 P0); // 0x00000001866EC224-0x00000001866EC34C
		public int __Gen_Wrap_514(ref ExCostSortedList1 P0); // 0x00000001866EC34C-0x00000001866EC474
		public float __Gen_Wrap_515(ref ExCostSortedList1 P0); // 0x00000001866EC474-0x00000001866EC59C
		public int __Gen_Wrap_516(ref ExCostSortedList1 P0, ExCostSortedList1 P1); // 0x00000001866EC59C-0x00000001866EC6F4
		public string __Gen_Wrap_517(ref ExCostSortedList1 P0); // 0x00000001866EC6F4-0x00000001866EC82C
		public bool __Gen_Wrap_518(ref ExCostSortedList4 P0); // 0x00000001866EC82C-0x00000001866EC96C
		public bool __Gen_Wrap_519(ref ExCostSortedList4 P0, float P1, int P2); // 0x00000001866EC96C-0x00000001866ECAE4
		public int __Gen_Wrap_520(ref ExCostSortedList4 P0, int P1); // 0x00000001866ECC0C-0x00000001866ECD68
		public void __Gen_Wrap_521(ref ExCostSortedList4 P0, int P1); // 0x00000001866ECD68-0x00000001866ECEB4
		public string __Gen_Wrap_522(ref ExCostSortedList4 P0); // 0x00000001866ECEB4-0x00000001866ED004
		public TransformAccessArray __Gen_Wrap_523(object P0); // 0x00000001866ED004-0x00000001866ED0E0
		public bool __Gen_Wrap_524(ref ResultCode P0, Define.Result P1); // 0x00000001866ED0E0-0x00000001866ED220
		public void __Gen_Wrap_525(ref ResultCode P0, bool P1, bool P2, bool P3); // 0x00000001866ED220-0x00000001866ED370
		public double __Gen_Wrap_526(object P0); // 0x00000001866ED370-0x00000001866ED42C
		public void __Gen_Wrap_527(object P0, object P1, object P2, int P3, int P4); // 0x00000001866ED42C-0x00000001866ED538
		public float4 __Gen_Wrap_528(float4 P0); // 0x00000001866ED538-0x00000001866ED658
		public VirtualMesh.ShareSerializationData __Gen_Wrap_529(object P0); // 0x00000001866ED658-0x00000001866ED734
		public VirtualMesh.UniqueSerializationData __Gen_Wrap_530(object P0); // 0x00000001866ED800-0x00000001866ED8DC
		public VirtualMeshRaycastHit __Gen_Wrap_531(object P0, float3 P1, float3 P2, bool P3, float P4); // 0x00000001866ED8DC-0x00000001866EDA88
		public void __Gen_Wrap_532(ref VirtualMesh.Import_GenerateTangentJob P0, int P1); // 0x00000001866EDA88-0x00000001866EDBD4
		public void __Gen_Wrap_533(ref VirtualMesh.Import_CalcSkinningJob P0, int P1); // 0x00000001866EDBD4-0x00000001866EDDF8
		public void __Gen_Wrap_534(ref VirtualMesh.Import_BoneWeightJob1 P0); // 0x00000001866EDDF8-0x00000001866EDF3C
		public void __Gen_Wrap_535(ref VirtualMesh.Import_BoneWeightJob2 P0, int P1); // 0x00000001866EDF3C-0x00000001866EE0A8
		public void __Gen_Wrap_536(ref VirtualMesh.Import_BoneVertexJob P0, int P1); // 0x00000001866EE0A8-0x00000001866EE294
		public void __Gen_Wrap_537(ref VirtualMesh.Select_PackVertexJob P0); // 0x00000001866EE294-0x00000001866EE4BC
		public void __Gen_Wrap_538(ref VirtualMesh.Select_GridJob P0); // 0x00000001866EE4BC-0x00000001866EE69C
		public void __Gen_Wrap_539(ref VirtualMesh.Add_CalcBindPoseJob P0, int P1); // 0x00000001866EE69C-0x00000001866EE894
		public void __Gen_Wrap_540(ref VirtualMesh.Add_CopyVerticesJob P0, int P1); // 0x00000001866EE960-0x00000001866EEB68
		public void __Gen_Wrap_541(ref VirtualMesh.Mapping_DirectConnectionVertexDataJob P0); // 0x00000001866EEB68-0x00000001866EED54
		public void __Gen_Wrap_542(ref VirtualMesh.Mapping_CalcDirectWeightJob P0); // 0x00000001866EED54-0x00000001866EEEF8
		public void __Gen_Wrap_543(ref VirtualMesh.Mapping_CalcConnectionVertexDataJob P0); // 0x00000001866EEEF8-0x00000001866EF120
		public void __Gen_Wrap_544(ref VirtualMesh.Mapping_CalcWeightJob P0, int P1); // 0x00000001866EF120-0x00000001866EF2DC
		public void __Gen_Wrap_545(ref VirtualMesh.Optimize_EdgeToTrianlgeJob P0); // 0x00000001866EF2DC-0x00000001866EF460
		public void __Gen_Wrap_546(ref VirtualMesh.ProxyNormalRadiationAdjustmentJob P0, int P1); // 0x00000001866EF460-0x00000001866EF640
		public void __Gen_Wrap_547(ref VirtualMesh.ProxyCreateFixedListAndAABBJob P0); // 0x00000001866EF640-0x00000001866EF7E4
		public void __Gen_Wrap_548(ref VirtualMesh.Proxy_CalcTriangleNormalJob P0, int P1); // 0x00000001866EF7E4-0x00000001866EF940
		public void __Gen_Wrap_549(ref VirtualMesh.Proxy_CalcTriangleTangentJob P0, int P1); // 0x00000001866EF940-0x00000001866EFAAC
		public void __Gen_Wrap_550(ref VirtualMesh.Proxy_CreateVertexToTrianglesJob P0); // 0x00000001866EFBB8-0x00000001866EFCE8
		public void __Gen_Wrap_551(ref VirtualMesh.Proxy_OrganizeVertexToTrianglsJob P0, int P1); // 0x00000001866EFCE8-0x00000001866EFE54
		public void __Gen_Wrap_552(ref VirtualMesh.Proxy_CalcVertexNormalTangentFromTriangleJob P0, int P1); // 0x00000001866EFE54-0x00000001866EFFD0
		public void __Gen_Wrap_553(ref VirtualMesh.Proxy_CalcVertexToTransformJob P0, int P1); // 0x00000001866EFFD0-0x00000001866F014C
		public void __Gen_Wrap_554(ref VirtualMesh.Proxy_CalcEdgeToTriangleJob P0); // 0x00000001866F014C-0x00000001866F0290
		public void __Gen_Wrap_555(ref VirtualMesh.Proxy_CalcVertexBindPoseJob2 P0, int P1); // 0x00000001866F0290-0x00000001866F040C
		public void __Gen_Wrap_556(ref VirtualMesh.Proxy_CalcVertexToVertexFromTriangleJob P0); // 0x00000001866F040C-0x00000001866F0560
		public void __Gen_Wrap_557(ref VirtualMesh.Proxy_CalcVertexToVertexFromLineJob P0); // 0x00000001866F0560-0x00000001866F06B4
		public void __Gen_Wrap_558(ref VirtualMesh.Proxy_CreateEdgeFlagJob P0, int P1); // 0x00000001866F06B4-0x00000001866F0810
		public void __Gen_Wrap_559(ref VirtualMesh.Proxy_CalcCustomSkinningWeightsJobV2 P0, int P1); // 0x00000001866F0810-0x00000001866F098C
		public void __Gen_Wrap_560(ref VirtualMesh.Proxy_ApplySelectionJob P0, int P1); // 0x00000001866F0BD4-0x00000001866F0D64
		public void __Gen_Wrap_561(ref VirtualMesh.Proxy_BoneClothApplayTransformFlagJob P0, int P1); // 0x00000001866F0D64-0x00000001866F0EB0
		public int __Gen_Wrap_562(ref VirtualMesh.BaseLineWork P0, VirtualMesh.BaseLineWork P1); // 0x00000001866F0EB0-0x00000001866F1008
		public void __Gen_Wrap_563(ref VirtualMesh.BaseLine_Mesh_CreateParentJob2 P0); // 0x00000001866F1008-0x00000001866F11F4
		public void __Gen_Wrap_564(ref VirtualMesh.BaseLine_Mesh_CareteFixedListJob P0); // 0x00000001866F11F4-0x00000001866F1338
		public void __Gen_Wrap_565(ref VirtualMesh.BaseLine_Bone_CreateBoneChildInfoJob P0); // 0x00000001866F1338-0x00000001866F147C
		public void __Gen_Wrap_566(ref VirtualMesh.BaseLine_CalcLocalPositionRotationJob P0, int P1); // 0x000000018539679C-0x0000000185396938
		public void __Gen_Wrap_567(ref VirtualMesh.BaseLine_CalcMaxBaseLineLengthJob P0); // 0x00000001866F147C-0x00000001866F1600
		public void __Gen_Wrap_568(ref VirtualMesh.Reduction_InitVertexToVertexJob2 P0); // 0x00000001866F1600-0x00000001866F1744
		public void __Gen_Wrap_569(ref VirtualMesh.Organize_RemapVertexJob P0); // 0x00000001866F1744-0x00000001866F1888
		public void __Gen_Wrap_570(ref VirtualMesh.Organize_CollectUseSkinBoneJob P0); // 0x00000001866F1AD0-0x00000001866F1C94
		public void __Gen_Wrap_571(ref VirtualMesh.Organize_CopyVertexJob P0, int P1); // 0x00000001866F1C94-0x00000001866F1E8C
		public void __Gen_Wrap_572(ref VirtualMesh.Organize_RemapBoneWeightJob P0, int P1); // 0x00000001866F1E8C-0x00000001866F2018
		public void __Gen_Wrap_573(ref VirtualMesh.Organize_RemapLinkPointArrayJob P0, int P1); // 0x00000001866F2018-0x00000001866F2184
		public void __Gen_Wrap_574(ref VirtualMesh.Organize_CreateLineTriangleJob P0); // 0x00000001866F2184-0x00000001866F22C8
		public void __Gen_Wrap_575(ref VirtualMesh.Organize_CreateLineTriangleJob2 P0); // 0x00000001866F22C8-0x00000001866F2418
		public void __Gen_Wrap_576(ref VirtualMesh.Organize_CreateNewTriangleJob3 P0); // 0x00000001866F2418-0x00000001866F2548
		public void __Gen_Wrap_577(ref VirtualMesh.Work_AverageTriangleDistanceJob P0); // 0x00000001866F2548-0x00000001866F26BC
		public void __Gen_Wrap_578(ref VirtualMesh.Work_AverageLineDistanceJob P0); // 0x00000001866F26BC-0x00000001866F2830
		public void __Gen_Wrap_579(ref VirtualMesh.Work_AddVertexIndexGirdMapJob P0); // 0x00000001866F2830-0x00000001866F2974
		public void __Gen_Wrap_580(ref VirtualMesh.Work_IntersectTriangleJob P0, int P1); // 0x00000001866F2A40-0x00000001866F2BBC
		public void __Gen_Wrap_581(ref VirtualMesh.Work_IntersectEdgeJob P0, int P1); // 0x00000001866F2BBC-0x00000001866F2D58
		public void __Gen_Wrap_582(ref VirtualMesh.Work_IntersectPointJob P0, int P1); // 0x00000001866F2D58-0x00000001866F2ED4
		public void __Gen_Wrap_583(ref VirtualMesh.Work_IntersetcSortJob P0); // 0x00000001866F2ED4-0x00000001866F2FF8
		public bool __Gen_Wrap_584(ref VertexAttribute P0, object P1); // 0x00000001866F2FF8-0x00000001866F3138
		public int __Gen_Wrap_585(ref VertexAttribute P0); // 0x00000001866F3138-0x00000001866F325C
		public string __Gen_Wrap_586(ref VirtualMeshBoneWeight P0); // 0x00000001866F325C-0x00000001866F33AC
		public int __Gen_Wrap_587(ref VirtualMeshRaycastHit P0, VirtualMeshRaycastHit P1); // 0x00000001866F33AC-0x00000001866F355C
		public bool __Gen_Wrap_588(ref VirtualMeshRaycastHit P0); // 0x00000001866F355C-0x00000001866F36C0
		public string __Gen_Wrap_589(ref VirtualMeshRaycastHit P0); // 0x00000001866F36C0-0x00000001866F3838
		public VirtualMeshTransform __Gen_Wrap_590(ref VirtualMeshTransform P0); // 0x00000001866F3914-0x00000001866F3B8C
		public VirtualMeshTransform __Gen_Wrap_591(); // 0x00000001866F3B8C-0x00000001866F3CC8
		public int __Gen_Wrap_592(ref VirtualMeshTransform P0); // 0x00000001866F3CC8-0x00000001866F3EC4
		public void __Gen_Wrap_593(ref VirtualMeshTransform P0, object P1); // 0x00000001866F3EC4-0x00000001866F40CC
		public VirtualMeshTransform __Gen_Wrap_594(ref VirtualMeshTransform P0, in VirtualMeshTransform P1); // 0x00000001866F40CC-0x00000001866F43E0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IAsyncStateMachine // TypeDefIndex: 48630
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x00000001866F9038-0x00000001866F90EC
	
		// Methods
		[IDTag(0)]
		private void MoveNext(); // 0x00000001866F8E28-0x00000001866F8EB8
		[IDTag(1)]
		private void SetStateMachine(IAsyncStateMachine P0); // 0x00000001866F8F88-0x00000001866F9038
		public void RefAwaitUnsafeOnCompleteMethod(); // 0x00000001866F8F14-0x00000001866F8F88
		public void RefAsyncBuilderStartMethod(); // 0x00000001866F8EB8-0x00000001866F8F14
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 48631
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x0000000185396738-0x000000018539679C
		public static bool IsPatched(int id); // 0x0000000182F95A30-0x0000000182F95AC0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x0000000186701154-0x0000000186701220
		public object CreateWrapper(int id); // 0x0000000186701220-0x0000000186701298
		public object InitWrapperArray(int len); // 0x0000000186701298-0x0000000186701324
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x00000001867010B0-0x0000000186701154
	}

	public enum IDMAP0 // TypeDefIndex: 48632
	{
		BeyondDynamicBone-BeyondBoneCloth-InitAnimationProperty0 = 0,
		BeyondDynamicBone-BeyondBoneCloth-OnDidApplyAnimationProperties0 = 1,
		BeyondDynamicBone-BeyondBoneCloth-SetParameterChange0 = 2,
		BeyondDynamicBone-BeyondBoneCloth-IsValid0 = 3,
		BeyondDynamicBone-MagicaManager-IsPlaying0 = 4,
		BeyondDynamicBone-BeyondBoneCloth-get_Process0 = 5,
		BeyondDynamicBone-ClothProcess-IsValid0 = 7,
		BeyondDynamicBone-ClothProcess-IsState0 = 8,
		BeyondDynamicBone-ClothProcess-DataUpdate0 = 10,
		BeyondDynamicBone-BeyondBoneCloth-get_SerializeData0 = 12,
		BeyondDynamicBone-ClothSerializeData-DataValidate0 = 13,
		BeyondDynamicBone-ReductionSettings-DataValidate0 = 14,
		BeyondDynamicBone-CustomSkinningSettings-DataValidate0 = 15,
		BeyondDynamicBone-NormalAlignmentSettings-DataValidate0 = 16,
		BeyondDynamicBone-CullingSettings-DataValidate0 = 17,
		BeyondDynamicBone-CheckSliderSerializeData-DataValidate0 = 18,
		BeyondDynamicBone-CurveSerializeData-DataValidate0 = 19,
		BeyondDynamicBone-InertiaConstraint-SerializeData-DataValidate0 = 20,
		BeyondDynamicBone-TetherConstraint-SerializeData-DataValidate0 = 21,
		BeyondDynamicBone-DistanceConstraint-SerializeData-DataValidate0 = 22,
		BeyondDynamicBone-TriangleBendingConstraint-SerializeData-DataValidate0 = 23,
		BeyondDynamicBone-AngleConstraint-RestorationSerializeData-DataValidate0 = 24,
		BeyondDynamicBone-AngleConstraint-LimitSerializeData-DataValidate0 = 25,
		BeyondDynamicBone-MotionConstraint-SerializeData-DataValidate0 = 26,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-DataValidate0 = 27,
		BeyondDynamicBone-SelfCollisionConstraint-SerializeData-DataValidate0 = 28,
		BeyondDynamicBone-WindSettings-DataValidate0 = 29,
		BeyondDynamicBone-ClothSerializeData2-DataValidate0 = 30,
		BeyondDynamicBone-MagicaManager-get_Team0 = 31,
		BeyondDynamicBone-BeyondBoneCloth-SetRelativeTransform0 = 32,
		BeyondDynamicBone-BeyondBoneCloth-set_SerializeData0 = 35,
		BeyondDynamicBone-BeyondBoneCloth-get_ClothTransform0 = 36,
		BeyondDynamicBone-BeyondBoneCloth-get_SyncPartnerCloth0 = 37,
		BeyondDynamicBone-ClothSerializeData-IsBoneSpring0 = 38,
		BeyondDynamicBone-SelfCollisionConstraint-SerializeData-GetSyncPartner0 = 39,
		BeyondDynamicBone-BeyondBoneCloth-Reset0 = 40,
		BeyondDynamicBone-BeyondBoneCloth-OnValidate0 = 41,
		BeyondDynamicBone-BeyondBoneCloth-Awake0 = 42,
		BeyondDynamicBone-ClothProcess-Init0 = 43,
		BeyondDynamicBone-ResultCode-SetSuccess0 = 44,
		BeyondDynamicBone-ResultCode-SetResult0 = 45,
		BeyondDynamicBone-Develop-LogError0 = 46,
		BeyondDynamicBone-BeyondBoneCloth-GetSerializeData20 = 47,
		BeyondDynamicBone-ClothProcess-SetState0 = 48,
		BeyondDynamicBone-ClothSerializeData-IsValid0 = 49,
		BeyondDynamicBone-ResultCode-SetError0 = 54,
		BeyondDynamicBone-ClothSerializeData-get_VerificationResult0 = 55,
		BeyondDynamicBone-ResultCode-get_Result0 = 56,
		BeyondDynamicBone-ClothProcess-GenerateStatusCheck0 = 57,
		BeyondDynamicBone-ResultCode-SetWarning0 = 58,
		BeyondDynamicBone-ResultCode-Merge0 = 59,
		BeyondDynamicBone-ResultCode-IsError0 = 60,
		BeyondDynamicBone-ResultCode-IsWarning0 = 61,
		BeyondDynamicBone-PreBuildSerializeData-UsePreBuild0 = 62,
		BeyondDynamicBone-PreBuildSerializeData-DataValidate0 = 63,
		BeyondDynamicBone-PreBuildSerializeData-GetSharePreBuildData0 = 64,
		BeyondDynamicBone-SharePreBuildData-DataValidate0 = 65,
		BeyondDynamicBone-ResultCode-IsFaild0 = 66,
		BeyondDynamicBone-ResultCode-IsSuccess0 = 67,
		BeyondDynamicBone-ResultCode-get_Success0 = 68,
		BeyondDynamicBone-UniquePreBuildData-DataValidate0 = 69,
		BeyondDynamicBone-ClothSerializeData-GetClothParameters0 = 71,
		BeyondDynamicBone-CurveSerializeData-ConvertFloatArray0 = 72,
		BeyondDynamicBone-DataUtility-ConvertAnimationCurve0 = 73,
		BeyondDynamicBone-CullingSettings-CullingParams-Convert0 = 74,
		BeyondDynamicBone-InertiaConstraint-InertiaConstraintParams-Convert0 = 75,
		BeyondDynamicBone-CheckSliderSerializeData-GetValue0 = 76,
		BeyondDynamicBone-TetherConstraint-TetherConstraintParams-Convert0 = 77,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintParams-Convert0 = 78,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingConstraintParams-Convert0 = 79,
		BeyondDynamicBone-AngleConstraint-AngleConstraintParams-Convert0 = 80,
		BeyondDynamicBone-MotionConstraint-MotionConstraintParams-Convert0 = 81,
		BeyondDynamicBone-ColliderCollisionConstraint-ColliderCollisionConstraintParams-Convert0 = 82,
		BeyondDynamicBone-SelfCollisionConstraint-SelfCollisionConstraintParams-Convert0 = 83,
		BeyondDynamicBone-WindParams-Convert0 = 84,
		BeyondDynamicBone-SpringConstraint-SpringConstraintParams-Convert0 = 85,
		BeyondDynamicBone-MagicaManager-get_PreBuild0 = 90,
		BeyondDynamicBone-PreBuildManager-RegisterPreBuildData0 = 91,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-Deserialize0 = 92,
		BeyondDynamicBone-ResultCode-SetProcess0 = 93,
		BeyondDynamicBone-RenderSetupData-ShareDeserialize0 = 94,
		BeyondDynamicBone-RenderSetupData-ShareSerializationData-get_HasTangent0 = 95,
		BeyondDynamicBone-VirtualMesh-ShareDeserialize0 = 96,
		BeyondDynamicBone-TransformData-ShareDeserialize0 = 97,
		BeyondDynamicBone-NativeMultiHashMapExtensions-MC2Deserialize0 = 98,
		BeyondDynamicBone-RenderSetupData-Dispose0 = 100,
		BeyondDynamicBone-ClothProcess-AddRenderer0 = 101,
		BeyondDynamicBone-MagicaManager-get_Render0 = 102,
		BeyondDynamicBone-RenderManager-AddRenderer0 = 103,
		BeyondDynamicBone-RenderData-Initialize0 = 104,
		BeyondDynamicBone-RenderData-AddReferenceCount0 = 105,
		BeyondDynamicBone-RenderManager-GetRendererData0 = 108,
		BeyondDynamicBone-RenderData-get_Result0 = 109,
		BeyondDynamicBone-ResultCode-get_None0 = 110,
		BeyondDynamicBone-ClothProcess-CreateBoneRenderSetupData0 = 111,
		BeyondDynamicBone-TeamManager-AddMonitoringProcess0 = 114,
		BeyondDynamicBone-TeamManager-RemoveMonitoringProcess0 = 115,
		BeyondDynamicBone-BeyondBoneCloth-OnEnable0 = 116,
		BeyondDynamicBone-ClothProcess-StartUse0 = 117,
		BeyondDynamicBone-ClothProcess-UpdateUse0 = 118,
		BeyondDynamicBone-TeamManager-SetEnable0 = 119,
		BeyondDynamicBone-MagicaManager-get_Cloth0 = 120,
		BeyondDynamicBone-ClothManager-ForceCompleteAllJob0 = 121,
		BeyondDynamicBone-ClothManager-CompleteMasterJob0 = 122,
		BeyondDynamicBone-MagicaManager-get_Collider0 = 123,
		BeyondDynamicBone-ColliderManager-EnableTeamCollider0 = 124,
		BeyondDynamicBone-ColliderManager-IsValid0 = 125,
		BeyondDynamicBone-TeamManager-GetTeamDataRef0 = 126,
		BeyondDynamicBone-TeamManager-TeamData-get_IsValid0 = 127,
		BeyondDynamicBone-TeamManager-TeamData-get_ColliderCount0 = 128,
		BeyondDynamicBone-TeamManager-TeamData-get_IsEnable0 = 129,
		BeyondDynamicBone-TeamManager-TeamData-get_IsLODCulled0 = 130,
		BeyondDynamicBone-MagicaManager-get_Bone0 = 131,
		BeyondDynamicBone-DynamicBoneTransformManager-EnableTransform0 = 132,
		BeyondDynamicBone-DynamicBoneTransformManager-EnableTransform1 = 133,
		BeyondDynamicBone-DataChunk-get_IsValid0 = 134,
		BeyondDynamicBone-RenderManager-StartUse0 = 135,
		BeyondDynamicBone-RenderData-StartUse0 = 136,
		BeyondDynamicBone-RenderData-UpdateUse0 = 137,
		BeyondDynamicBone-ClothProcess-IsCameraCullingInvisible0 = 141,
		BeyondDynamicBone-ClothProcess-IsCameraCullingKeep0 = 142,
		BeyondDynamicBone-ClothProcess-IsDistanceCullingInvisible0 = 143,
		BeyondDynamicBone-RenderData-SwapOriginalMesh0 = 144,
		BeyondDynamicBone-RenderData-get_UseCustomMesh0 = 145,
		BeyondDynamicBone-RenderData-SetMesh0 = 146,
		BeyondDynamicBone-RenderData-SwapCustomMesh0 = 147,
		BeyondDynamicBone-RenderSetupData-IsFaild0 = 148,
		BeyondDynamicBone-RenderData-get_HasMeshTangent0 = 149,
		BeyondDynamicBone-RenderData-get_HasBoneWeight0 = 150,
		BeyondDynamicBone-RenderSetupData-get_TransformCount0 = 151,
		BeyondDynamicBone-RenderData-ResetCustomMeshWorkData0 = 152,
		BeyondDynamicBone-RenderSetupData-get_HasMeshDataArray0 = 153,
		BeyondDynamicBone-RenderSetupData-get_HasTangent0 = 154,
		BeyondDynamicBone-RenderSetupData-GetBoneWeightsRun0 = 155,
		BeyondDynamicBone-RenderManager-EndUse0 = 156,
		BeyondDynamicBone-RenderData-EndUse0 = 157,
		BeyondDynamicBone-BeyondBoneCloth-OnDisable0 = 158,
		BeyondDynamicBone-ClothProcess-EndUse0 = 159,
		BeyondDynamicBone-BeyondBoneCloth-Start0 = 160,
		BeyondDynamicBone-ClothProcess-AutoBuild0 = 161,
		BeyondDynamicBone-ClothProcess-PreBuildDataConstruction0 = 162,
		BeyondDynamicBone-PreBuildManager-GetPreBuildData0 = 163,
		BeyondDynamicBone-VirtualMesh-get_IsError0 = 164,
		BeyondDynamicBone-ClothManager-AddCloth0 = 167,
		BeyondDynamicBone-TeamManager-AddTeam0 = 168,
		BeyondDynamicBone-TeamManager-ApplyWeightDrivenSimulationPosePolicy0 = 169,
		BeyondDynamicBone-TeamManager-ShouldResetSimulationToAnimationPose0 = 170,
		BeyondDynamicBone-DynamicBoneTransformManager-AddComponentTransform0 = 171,
		BeyondDynamicBone-TeamManager-AddTeamAnimatorData0 = 173,
		BeyondDynamicBone-MagicaManager-get_VMesh0 = 175,
		BeyondDynamicBone-VirtualMeshManager-RegisterProxyMesh0 = 176,
		BeyondDynamicBone-DynamicBoneTransformManager-AddTransform0 = 177,
		BeyondDynamicBone-VirtualMeshContainer-GetTransformCount0 = 178,
		BeyondDynamicBone-VirtualMeshContainer-get_hasUniqueData0 = 179,
		BeyondDynamicBone-VirtualMesh-get_TransformCount0 = 180,
		BeyondDynamicBone-TransformData-get_Count0 = 181,
		BeyondDynamicBone-VirtualMeshContainer-GetTransformFromIndex0 = 182,
		BeyondDynamicBone-TransformData-GetTransformFromIndex0 = 183,
		BeyondDynamicBone-TeamManager-AddAnimatorTransform0 = 184,
		BeyondDynamicBone-VirtualMesh-get_VertexCount0 = 185,
		BeyondDynamicBone-VirtualMesh-get_TriangleCount0 = 186,
		BeyondDynamicBone-VirtualMesh-get_EdgeCount0 = 187,
		BeyondDynamicBone-VirtualMesh-get_BaseLineCount0 = 188,
		BeyondDynamicBone-MagicaManager-get_Simulation0 = 189,
		BeyondDynamicBone-SimulationManager-RegisterProxyMesh0 = 190,
		BeyondDynamicBone-ColliderManager-Register0 = 191,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-get_ColliderLength0 = 192,
		BeyondDynamicBone-DynamicBoneTransformManager-AddTransform1 = 193,
		BeyondDynamicBone-ColliderManager-InitColliders0 = 194,
		BeyondDynamicBone-ColliderManager-AddColliderInternal0 = 195,
		BeyondDynamicBone-ColliderComponent-IsReverseDirection0 = 196,
		BeyondDynamicBone-ColliderComponent-GetSize0 = 197,
		BeyondDynamicBone-ColliderComponent-Register0 = 198,
		BeyondDynamicBone-ClothProcess-get_IsEnable0 = 199,
		BeyondDynamicBone-TeamManager-IsEnable0 = 200,
		BeyondDynamicBone-DynamicBoneTransformManager-SetTransform0 = 201,
		BeyondDynamicBone-TeamManager-MarkAnimatorTransformDirty0 = 202,
		BeyondDynamicBone-SimulationManager-RegisterConstraint0 = 203,
		BeyondDynamicBone-DistanceConstraint-Register0 = 204,
		BeyondDynamicBone-DistanceConstraint-ConstraintData-IsValid0 = 205,
		BeyondDynamicBone-TriangleBendingConstraint-Register0 = 206,
		BeyondDynamicBone-TriangleBendingConstraint-ConstraintData-IsValid0 = 207,
		BeyondDynamicBone-InertiaConstraint-Register0 = 208,
		BeyondDynamicBone-VirtualMesh-get_CenterFixedPointCount0 = 209,
		BeyondDynamicBone-SelfCollisionConstraint-Register0 = 210,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateTeam0 = 211,
		BeyondDynamicBone-TeamManager-ContainsTeamData0 = 212,
		BeyondDynamicBone-TeamManager-GetParametersRef0 = 213,
		BeyondDynamicBone-TeamManager-TeamData-get_EdgeCount0 = 214,
		BeyondDynamicBone-TeamManager-TeamData-get_TriangleCount0 = 215,
		BeyondDynamicBone-TeamManager-TeamData-get_ParticleCount0 = 216,
		BeyondDynamicBone-SelfCollisionConstraint-InitPrimitive0 = 217,
		BeyondDynamicBone-DataChunk-Clear0 = 220,
		BeyondDynamicBone-VirtualMesh-get_IsMapping0 = 227,
		BeyondDynamicBone-VirtualMesh-IsValid0 = 228,
		BeyondDynamicBone-TransformData-get_IsEmpty0 = 229,
		BeyondDynamicBone-VirtualMeshManager-RegisterMappingMesh0 = 230,
		BeyondDynamicBone-DataChunk-get_Empty0 = 231,
		BeyondDynamicBone-TeamManager-GetTeamMappingRef0 = 232,
		BeyondDynamicBone-VirtualMeshContainer-GetCenterTransform0 = 233,
		BeyondDynamicBone-VirtualMesh-GetCenterTransform0 = 234,
		BeyondDynamicBone-DynamicBoneTransformManager-AddTransform2 = 235,
		BeyondDynamicBone-VirtualMeshContainer-Dispose0 = 239,
		BeyondDynamicBone-VirtualMesh-Dispose0 = 240,
		BeyondDynamicBone-ResultCode-Clear0 = 241,
		BeyondDynamicBone-TransformData-Dispose0 = 242,
		BeyondDynamicBone-ResultCode-GetResultString0 = 244,
		BeyondDynamicBone-ResultCode-IsNormal0 = 245,
		BeyondDynamicBone-ClothProcess-StartRuntimeBuild0 = 246,
		BeyondDynamicBone-ClothProcess-RuntimeBuildAsync0 = 247,
		BeyondDynamicBone-DistanceConstraint-CreateData0 = 251,
		BeyondDynamicBone-ClothJobUtility-ToNativeMultiHashMap0 = 252,
		BeyondDynamicBone-MathUtility-GetUnuseTriangleIndex0 = 253,
		BeyondDynamicBone-TriangleBendingConstraint-CreateData0 = 254,
		BeyondDynamicBone-MathUtility-GetRestTriangleVertex0 = 255,
		BeyondDynamicBone-TriangleBendingConstraint-InitDihedralAngle0 = 256,
		BeyondDynamicBone-DataUtility-PackInt41 = 257,
		BeyondDynamicBone-DataUtility-PackInt40 = 258,
		BeyondDynamicBone-TriangleBendingConstraint-InitVolume0 = 259,
		BeyondDynamicBone-InertiaConstraint-CreateData0 = 260,
		BeyondDynamicBone-InertiaConstraint-CenterData-Initialize0 = 261,
		BeyondDynamicBone-VirtualMesh-SetTransform0 = 264,
		BeyondDynamicBone-TransformData-AddTransform0 = 265,
		BeyondDynamicBone-SelectionData-IsValid0 = 266,
		BeyondDynamicBone-RenderData-get_Name0 = 267,
		BeyondDynamicBone-VirtualMesh-ImportFrom1 = 268,
		BeyondDynamicBone-VirtualMesh-ImportFrom0 = 269,
		BeyondDynamicBone-TransformData-AddTransformRange0 = 270,
		BeyondDynamicBone-VirtualMesh-ImportMeshType0 = 271,
		BeyondDynamicBone-ClothJobUtility-SerialNumberRun0 = 272,
		BeyondDynamicBone-ClothJobUtility-FillRun0 = 273,
		BeyondDynamicBone-VirtualMesh-ImportMeshSkinning0 = 274,
		BeyondDynamicBone-VirtualMesh-ImportBoneType0 = 275,
		BeyondDynamicBone-RenderSetupData-GetParentTransformIndex0 = 276,
		BeyondDynamicBone-DataUtility-PackInt30 = 277,
		BeyondDynamicBone-ClothJobUtility-CalcAABBRun0 = 278,
		BeyondDynamicBone-ClothJobUtility-CalcUVWithSphereMappingRun0 = 279,
		BeyondDynamicBone-VirtualMesh-CalcAverageAndMaxVertexDistanceRun0 = 280,
		BeyondDynamicBone-VirtualMesh-get_LineCount0 = 281,
		BeyondDynamicBone-ResultCode-IsNone0 = 282,
		BeyondDynamicBone-ClothProcess-GenerateSelectionDataFromVertexAttributeData0 = 283,
		BeyondDynamicBone-ClothJobUtility-TransformPositionRun0 = 284,
		BeyondDynamicBone-SelectionData-Merge0 = 285,
		BeyondDynamicBone-SelectionData-get_Count0 = 286,
		BeyondDynamicBone-ClothProcess-GenerateSelectionDataFromPaintMap0 = 287,
		BeyondDynamicBone-VirtualMesh-CalcSelectionMergin0 = 288,
		BeyondDynamicBone-ReductionSettings-get_IsEnabled0 = 289,
		BeyondDynamicBone-AABB-get_MaxSideLength0 = 290,
		BeyondDynamicBone-AABB-get_Extents0 = 291,
		BeyondDynamicBone-ReductionSettings-GetMaxConnectionDistance0 = 292,
		BeyondDynamicBone-VirtualMesh-SelectionMesh0 = 293,
		BeyondDynamicBone-SelectionData-GetPositionNativeArray0 = 294,
		BeyondDynamicBone-SelectionData-GetAttributeNativeArray0 = 295,
		BeyondDynamicBone-ClothJobUtility-TransformPositionRun1 = 296,
		BeyondDynamicBone-SelectionData-CreateGridMapRun0 = 297,
		BeyondDynamicBone-VirtualMesh-AddMesh0 = 298,
		BeyondDynamicBone-VirtualMesh-get_IsSuccess0 = 299,
		BeyondDynamicBone-VirtualMesh-get_SkinBoneCount0 = 300,
		BeyondDynamicBone-VirtualMesh-CenterTransformTo0 = 301,
		BeyondDynamicBone-VirtualMesh-CompareSpace0 = 302,
		BeyondDynamicBone-TransformData-AddTransform1 = 303,
		BeyondDynamicBone-SelectionData-Fill0 = 304,
		BeyondDynamicBone-RenderSetupData-GetTransformIndexFromId0 = 305,
		BeyondDynamicBone-VirtualMesh-Reduction0 = 306,
		BeyondDynamicBone-VirtualMesh-InitReductionWorkData0 = 307,
		BeyondDynamicBone-ClothJobUtility-FillRun1 = 308,
		BeyondDynamicBone-SameDistanceReduction-Reduction0 = 309,
		BeyondDynamicBone-SameDistanceReduction-UpdateJoinAndLink0 = 310,
		BeyondDynamicBone-SameDistanceReduction-UpdateReductionResultJob0 = 311,
		BeyondDynamicBone-SameDistanceReduction-get_Result0 = 312,
		BeyondDynamicBone-StepReductionBase-Reduction0 = 313,
		BeyondDynamicBone-StepReductionBase-StepInitialize0 = 314,
		BeyondDynamicBone-StepReductionBase-InitStep0 = 315,
		BeyondDynamicBone-StepReductionBase-ReductionStep0 = 316,
		BeyondDynamicBone-StepReductionBase-PreReductionStep0 = 317,
		BeyondDynamicBone-StepReductionBase-CustomReductionStep0 = 318,
		BeyondDynamicBone-StepReductionBase-PostReductionStep0 = 319,
		BeyondDynamicBone-StepReductionBase-SortJoinEdge0 = 320,
		BeyondDynamicBone-StepReductionBase-DetermineJoinEdge0 = 321,
		BeyondDynamicBone-StepReductionBase-RunJoinEdge0 = 322,
		BeyondDynamicBone-StepReductionBase-UpdateJoinAndLink0 = 323,
		BeyondDynamicBone-StepReductionBase-IsEndStep0 = 324,
		BeyondDynamicBone-StepReductionBase-NextStep0 = 325,
		BeyondDynamicBone-StepReductionBase-UpdateReductionResultJob0 = 326,
		BeyondDynamicBone-StepReductionBase-get_Result0 = 327,
		BeyondDynamicBone-VirtualMesh-Organization0 = 328,
		BeyondDynamicBone-VirtualMesh-OrganizationInit0 = 329,
		BeyondDynamicBone-VirtualMesh-OrganizationCreateRemapData0 = 330,
		BeyondDynamicBone-VirtualMesh-OrganizationCreateBasicData0 = 331,
		BeyondDynamicBone-VirtualMesh-OrganizationCreateLineTriangle0 = 332,
		BeyondDynamicBone-VirtualMesh-OrganizeStoreVirtualMesh0 = 333,
		BeyondDynamicBone-TransformData-OrganizeReductionTransform0 = 334,
		BeyondDynamicBone-ResultCode-SetCancel0 = 335,
		BeyondDynamicBone-VirtualMesh-Optimization0 = 336,
		BeyondDynamicBone-VirtualMesh-RemoveDuplicateTriangles0 = 337,
		BeyondDynamicBone-VirtualMesh-ApplySelectionAttribute0 = 338,
		BeyondDynamicBone-VirtualMesh-ConvertProxyMesh0 = 340,
		BeyondDynamicBone-VirtualMesh-SetCustomSkinningBones0 = 341,
		BeyondDynamicBone-TransformRecord-IsValid0 = 342,
		BeyondDynamicBone-ClothJobUtility-FillRun2 = 343,
		BeyondDynamicBone-VirtualMesh-OptimizeTriangleDirection0 = 344,
		BeyondDynamicBone-VirtualMesh-CalcTwoTriangleAngle0 = 345,
		BeyondDynamicBone-VirtualMesh-CheckTwoTriangleOpen0 = 346,
		BeyondDynamicBone-VirtualMesh-ProxyCreateFixedListAndAABB0 = 347,
		BeyondDynamicBone-VirtualMesh-CreateTransformBaseLine0 = 348,
		BeyondDynamicBone-TransformData-get_RootCount0 = 349,
		BeyondDynamicBone-VirtualMesh-CreateMeshBaseLine0 = 350,
		BeyondDynamicBone-VirtualMesh-ProxyNormalAdjustment0 = 351,
		BeyondDynamicBone-AABB-get_Center0 = 352,
		BeyondDynamicBone-VirtualMesh-CreateBaseLinePose0 = 353,
		BeyondDynamicBone-VirtualMesh-CreateVertexRootAndDepth0 = 354,
		BeyondDynamicBone-VirtualMesh-CreateCustomSkinning0 = 355,
		BeyondDynamicBone-VirtualMesh-get_CustomSkinningBoneCount0 = 356,
		BeyondDynamicBone-VirtualMesh-Mapping0 = 357,
		BeyondDynamicBone-VirtualMesh-CreateVertexIndexGridMapRun0 = 358,
		BeyondDynamicBone-ClothProcess-IncrementSuspendCounter0 = 359,
		BeyondDynamicBone-ClothProcess-GeneratePaintMapDataList0 = 360,
		BeyondDynamicBone-SelectionData-Clone0 = 361,
		BeyondDynamicBone-Develop-LogWarning0 = 362,
		BeyondDynamicBone-ClothProcess-DecrementSuspendCounter0 = 363,
		BeyondDynamicBone-ClothProcess-DisposeInternal0 = 364,
		BeyondDynamicBone-SimulationManager-ExitProxyMesh0 = 365,
		BeyondDynamicBone-DistanceConstraint-Exit0 = 366,
		BeyondDynamicBone-TriangleBendingConstraint-Exit0 = 367,
		BeyondDynamicBone-InertiaConstraint-Exit0 = 368,
		BeyondDynamicBone-SelfCollisionConstraint-Exit0 = 369,
		BeyondDynamicBone-VirtualMeshManager-ExitProxyMesh0 = 370,
		BeyondDynamicBone-DynamicBoneTransformManager-RemoveTransform0 = 371,
		BeyondDynamicBone-VirtualMeshManager-ExitMappingMesh0 = 372,
		BeyondDynamicBone-ColliderManager-Exit0 = 373,
		BeyondDynamicBone-ColliderComponent-Exit0 = 374,
		BeyondDynamicBone-ClothManager-RemoveCloth0 = 375,
		BeyondDynamicBone-TeamManager-RemoveTeam0 = 376,
		BeyondDynamicBone-TeamManager-RemoveSyncParent0 = 377,
		BeyondDynamicBone-DynamicBoneTransformManager-RemoveComponentTransform0 = 378,
		BeyondDynamicBone-TeamManager-ClearTeamAnimatorData0 = 379,
		BeyondDynamicBone-RenderManager-RemoveRenderer0 = 380,
		BeyondDynamicBone-RenderData-RemoveReferenceCount0 = 381,
		BeyondDynamicBone-RenderData-Dispose0 = 382,
		BeyondDynamicBone-PreBuildManager-UnregisterPreBuildData0 = 383,
		BeyondDynamicBone-BeyondBoneCloth-OnDestroy0 = 385,
		BeyondDynamicBone-ClothProcess-Dispose0 = 386,
		BeyondDynamicBone-BeyondBoneCloth-GetMagicaHashCode0 = 387,
		BeyondDynamicBone-BeyondBoneCloth-Initialize0 = 388,
		BeyondDynamicBone-BeyondBoneCloth-DisableAutoBuild0 = 389,
		BeyondDynamicBone-BeyondBoneCloth-SetClothSimulateWeight0 = 390,
		BeyondDynamicBone-BeyondBoneCloth-SetCodeParamaterDirty0 = 391,
		BeyondDynamicBone-BeyondBoneCloth-SetClothSimulateWeightIgnorePlaying0 = 392,
		BeyondDynamicBone-BeyondBoneCloth-SetCodeParamaterDirtyIgnorePlaying0 = 393,
		BeyondDynamicBone-BeyondBoneCloth-SetClothStablizationTimeAfterResetIgnorePlaying0 = 394,
		BeyondDynamicBone-BeyondBoneCloth-SetAnimationPoseRatio0 = 395,
		BeyondDynamicBone-BeyondBoneCloth-BuildAndRun0 = 396,
		BeyondDynamicBone-ClothProcess-GenerateInitialization0 = 397,
		BeyondDynamicBone-SelectionData-IsUserEdit0 = 398,
		BeyondDynamicBone-ClothProcess-GenerateBoneClothSelection0 = 399,
		BeyondDynamicBone-BeyondBoneCloth-ReplaceTransform0 = 400,
		BeyondDynamicBone-ClothProcess-GetUsedTransform0 = 401,
		BeyondDynamicBone-RenderData-GetUsedTransform0 = 404,
		BeyondDynamicBone-RenderSetupData-GetUsedTransform0 = 405,
		BeyondDynamicBone-TransformRecord-GetUsedTransform0 = 407,
		BeyondDynamicBone-ClothSerializeData-GetUsedTransform0 = 408,
		BeyondDynamicBone-CustomSkinningSettings-GetUsedTransform0 = 409,
		BeyondDynamicBone-NormalAlignmentSettings-GetUsedTransform0 = 410,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-GetUsedTransform0 = 411,
		BeyondDynamicBone-ClothSerializeData2-GetUsedTransform0 = 412,
		BeyondDynamicBone-PreBuildSerializeData-GetUsedTransform0 = 413,
		BeyondDynamicBone-UniquePreBuildData-GetUsedTransform0 = 414,
		BeyondDynamicBone-RenderSetupData-UniqueSerializationData-GetUsedTransform0 = 417,
		BeyondDynamicBone-VirtualMesh-UniqueSerializationData-GetUsedTransform0 = 421,
		BeyondDynamicBone-TransformData-UniqueSerializationData-GetUsedTransform0 = 422,
		BeyondDynamicBone-ClothProcess-ReplaceTransform0 = 423,
		BeyondDynamicBone-RenderData-ReplaceTransform0 = 426,
		BeyondDynamicBone-RenderSetupData-ReplaceTransform0 = 427,
		BeyondDynamicBone-TransformRecord-ReplaceTransform0 = 429,
		BeyondDynamicBone-ClothSerializeData-ReplaceTransform0 = 430,
		BeyondDynamicBone-CustomSkinningSettings-ReplaceTransform0 = 431,
		BeyondDynamicBone-NormalAlignmentSettings-ReplaceTransform0 = 432,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-ReplaceTransform0 = 433,
		BeyondDynamicBone-ClothSerializeData2-ReplaceTransform0 = 434,
		BeyondDynamicBone-PreBuildSerializeData-ReplaceTransform0 = 435,
		BeyondDynamicBone-UniquePreBuildData-ReplaceTransform0 = 436,
		BeyondDynamicBone-RenderSetupData-UniqueSerializationData-ReplaceTransform0 = 439,
		BeyondDynamicBone-VirtualMesh-UniqueSerializationData-ReplaceTransform0 = 441,
		BeyondDynamicBone-TransformData-UniqueSerializationData-ReplaceTransform0 = 442,
		BeyondDynamicBone-BeyondBoneCloth-SetTimeScale0 = 443,
		BeyondDynamicBone-BeyondBoneCloth-GetTimeScale0 = 444,
		BeyondDynamicBone-BeyondBoneCloth-ResetCloth0 = 445,
		BeyondDynamicBone-ClothProcess-UpdateRendererUse0 = 446,
		BeyondDynamicBone-BeyondBoneCloth-SoftResetCloth0 = 447,
		BeyondDynamicBone-BeyondBoneCloth-GetCenterPosition0 = 448,
		BeyondDynamicBone-TeamManager-GetCenterDataRef0 = 449,
		BeyondDynamicBone-BeyondBoneCloth-AddForce0 = 450,
		BeyondDynamicBone-BeyondBoneCloth-SetSkipWriting0 = 451,
		BeyondDynamicBone-ClothProcess-SetSkipWriting0 = 452,
		BeyondDynamicBone-CheckSliderSerializeData-SetValue0 = 453,
		BeyondDynamicBone-CheckSliderSerializeData-Clone0 = 454,
		BeyondDynamicBone-ClothBehaviour-GetMagicaHashCode0 = 455,
		BeyondDynamicBone-ClothBehaviour-OnDrawGizmos0 = 456,
		BeyondDynamicBone-ClothProcess-GetColliderIndex0 = 458,
		BeyondDynamicBone-ClothProcess-UpdateCullingAnimatorAndRenderers0 = 459,
		BeyondDynamicBone-ClothProcess-get_Result0 = 460,
		BeyondDynamicBone-ClothProcess-get_ColliderCapacity0 = 461,
		BeyondDynamicBone-ClothProcess-GetStateFlag0 = 462,
		BeyondDynamicBone-ClothProcess-IsRunning0 = 463,
		BeyondDynamicBone-ClothProcess-IsLodCulled0 = 464,
		BeyondDynamicBone-ClothProcess-IsSkipWriting0 = 465,
		BeyondDynamicBone-ClothProcess-IsUpdateTangent0 = 466,
		BeyondDynamicBone-ClothProcess-get_HasProxyMesh0 = 467,
		BeyondDynamicBone-ClothProcess-get_Name0 = 468,
		BeyondDynamicBone-ClothProcess-GetSuspendCounter0 = 469,
		BeyondDynamicBone-ClothProcess-GetRenderMeshInfo0 = 470,
		BeyondDynamicBone-ClothProcess-SyncParameters0 = 471,
		BeyondDynamicBone-ClothProcess-GetClothUpdateMode0 = 472,
		BeyondDynamicBone-ClothProcess-GenerateSelectionJob-Execute0 = 473,
		BeyondDynamicBone-ClothSerializeData-GetHashCode0 = 474,
		BeyondDynamicBone-ClothSerializeData-ExportJson0 = 475,
		BeyondDynamicBone-ClothSerializeData-ImportJson0 = 476,
		BeyondDynamicBone-ClothSerializeData-TempBuffer-Pop0 = 477,
		BeyondDynamicBone-ClothSerializeData-Import0 = 478,
		BeyondDynamicBone-ReductionSettings-Clone0 = 479,
		BeyondDynamicBone-CustomSkinningSettings-Clone0 = 480,
		BeyondDynamicBone-NormalAlignmentSettings-Clone0 = 481,
		BeyondDynamicBone-CullingSettings-Clone0 = 482,
		BeyondDynamicBone-CurveSerializeData-Clone0 = 483,
		BeyondDynamicBone-InertiaConstraint-SerializeData-Clone0 = 484,
		BeyondDynamicBone-TetherConstraint-SerializeData-Clone0 = 485,
		BeyondDynamicBone-DistanceConstraint-SerializeData-Clone0 = 486,
		BeyondDynamicBone-TriangleBendingConstraint-SerializeData-Clone0 = 487,
		BeyondDynamicBone-AngleConstraint-RestorationSerializeData-Clone0 = 488,
		BeyondDynamicBone-AngleConstraint-LimitSerializeData-Clone0 = 489,
		BeyondDynamicBone-MotionConstraint-SerializeData-Clone0 = 490,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-Clone0 = 491,
		BeyondDynamicBone-SelfCollisionConstraint-SerializeData-Clone0 = 492,
		BeyondDynamicBone-WindSettings-Clone0 = 493,
		BeyondDynamicBone-ClothSerializeData-Import1 = 494,
		BeyondDynamicBone-ClothSerializeData-TempBuffer-Push0 = 495,
		BeyondDynamicBone-ClothSerializeData2-IsValid0 = 496,
		BeyondDynamicBone-ClothSerializeData2-GetHashCode0 = 497,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-GetColliderType0 = 498,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-SetSize0 = 499,
		BeyondDynamicBone-ColliderComponent-SetSize0 = 500,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-GetSize0 = 501,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-GetLocalDir0 = 502,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-GetLocalUp0 = 503,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-IsReverseDirection0 = 504,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-DataValidate0 = 505,
		BeyondDynamicBone-BeyondBonePlaneCollider-GetColliderType0 = 506,
		BeyondDynamicBone-BeyondBonePlaneCollider-DataValidate0 = 507,
		BeyondDynamicBone-BeyondBoneSphereCollider-GetColliderType0 = 508,
		BeyondDynamicBone-BeyondBoneSphereCollider-DataValidate0 = 509,
		BeyondDynamicBone-BeyondBoneSphereCollider-SetSize0 = 510,
		BeyondDynamicBone-ColliderComponent-SetSizeX0 = 511,
		BeyondDynamicBone-ColliderComponent-SetSizeY0 = 512,
		BeyondDynamicBone-ColliderComponent-SetSizeZ0 = 513,
		BeyondDynamicBone-ColliderComponent-GetScale0 = 514,
		BeyondDynamicBone-ColliderComponent-UpdateParameters0 = 515,
		BeyondDynamicBone-ColliderManager-UpdateParameters0 = 516,
		BeyondDynamicBone-TeamManager-GetClothProcess0 = 517,
		BeyondDynamicBone-ColliderComponent-Start0 = 518,
		BeyondDynamicBone-ColliderComponent-OnValidate0 = 519,
		BeyondDynamicBone-ColliderComponent-OnEnable0 = 520,
		BeyondDynamicBone-ColliderManager-EnableCollider0 = 521,
		BeyondDynamicBone-ColliderComponent-OnDisable0 = 522,
		BeyondDynamicBone-ColliderComponent-OnDestroy0 = 523,
		BeyondDynamicBone-ColliderManager-RemoveCollider0 = 524,
		BeyondDynamicBone-DynamicBoneTransformManager-CopyTransform0 = 525,
		BeyondDynamicBone-AngleConstraint-Dispose0 = 526,
		BeyondDynamicBone-AngleConstraint-WorkBufferUpdate0 = 527,
		BeyondDynamicBone-SimulationManager-get_ParticleCount0 = 528,
		BeyondDynamicBone-AngleConstraint-ToString0 = 529,
		BeyondDynamicBone-AngleConstraint-SolverConstraint0 = 530,
		BeyondDynamicBone-MagicaManager-get_Time0 = 531,
		BeyondDynamicBone-AngleConstraint-AngleConstraintJob-SetIndexCount0 = 533,
		BeyondDynamicBone-AngleConstraint-AngleConstraintJob-Execute1 = 534,
		BeyondDynamicBone-AngleConstraint-AngleConstraintJob-Execute0 = 535,
		BeyondDynamicBone-MathUtility-ClampAngle0 = 536,
		BeyondDynamicBone-MathUtility-FromToRotation0 = 537,
		BeyondDynamicBone-AngleConstraint-AngleConstraintJob-UnsafeDo0 = 538,
		BeyondDynamicBone-ColliderCollisionConstraint-Dispose0 = 539,
		BeyondDynamicBone-ColliderCollisionConstraint-WorkBufferUpdate0 = 540,
		BeyondDynamicBone-ColliderCollisionConstraint-ToString0 = 541,
		BeyondDynamicBone-ColliderCollisionConstraint-SolverConstraint0 = 542,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB$BurstDirectCall0 = 543,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC$BurstDirectCall0 = 544,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0$BurstDirectCall0 = 545,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1$BurstDirectCall0 = 546,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5$BurstDirectCall0 = 547,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6$BurstDirectCall0 = 548,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointSphereColliderDetection0 = 549,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointPlaneColliderDetction0 = 550,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointCapsuleColliderDetection0 = 551,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgeSphereColliderDetection0 = 552,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgeCapsuleColliderDetection0 = 553,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgePlaneColliderDetection0 = 554,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-GetHashCode0 = 555,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-SetIndexCount0 = 556,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-Execute1 = 557,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-Execute0 = 558,
		BeyondDynamicBone-TeamManager-TeamData-get_IsSpring0 = 559,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointSphereColliderDetection0 = 560,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointCapsuleColliderDetection0 = 561,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointPlaneColliderDetction0 = 562,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-UnsafeDo0 = 563,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-SetIndexCount0 = 564,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-Execute1 = 565,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-Execute0 = 566,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgeSphereColliderDetection0 = 567,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgeCapsuleColliderDetection0 = 568,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgePlaneColliderDetection0 = 569,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-UnsafeDo0 = 570,
		BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-SetIndexCount0 = 571,
		BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-Execute1 = 572,
		BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-Execute0 = 573,
		BeyondDynamicBone-InterlockUtility-ReadAverageFloat30 = 574,
		BeyondDynamicBone-InterlockUtility-ReadFloat0 = 575,
		BeyondDynamicBone-InterlockUtility-ReadFloat30 = 576,
		BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-UnsafeDo0 = 577,
		BeyondDynamicBone-DistanceConstraint-get_DataCount0 = 578,
		BeyondDynamicBone-DistanceConstraint-Dispose0 = 579,
		BeyondDynamicBone-DistanceConstraint-ToString0 = 580,
		BeyondDynamicBone-DistanceConstraint-SolverConstraint0 = 581,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-SetIndexCount0 = 582,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-Execute1 = 583,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-Execute0 = 584,
		BeyondDynamicBone-TeamManager-TeamData-get_InitScale0 = 585,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-UnsafeDo0 = 586,
		BeyondDynamicBone-InertiaConstraint-Dispose0 = 587,
		BeyondDynamicBone-InertiaConstraint-ToString0 = 588,
		BeyondDynamicBone-MotionConstraint-Dispose0 = 589,
		BeyondDynamicBone-MotionConstraint-SolverConstraint0 = 590,
		BeyondDynamicBone-MotionConstraint-MotionConstraintJob-SetIndexCount0 = 591,
		BeyondDynamicBone-MotionConstraint-MotionConstraintJob-Execute1 = 592,
		BeyondDynamicBone-MotionConstraint-MotionConstraintJob-Execute0 = 593,
		BeyondDynamicBone-MotionConstraint-MotionConstraintJob-UnsafeDo0 = 594,
		BeyondDynamicBone-SelfCollisionConstraint-Dispose0 = 595,
		BeyondDynamicBone-SelfCollisionConstraint-HasPrimitive0 = 596,
		BeyondDynamicBone-SelfCollisionConstraint-ToString0 = 597,
		BeyondDynamicBone-SelfCollisionConstraint-WorkBufferUpdate0 = 598,
		BeyondDynamicBone-SelfCollisionConstraint-BinarySearchSortAndlSweep0 = 599,
		BeyondDynamicBone-SelfCollisionConstraint-SolverConstraint0 = 600,
		BeyondDynamicBone-SelfCollisionConstraint-SolverRuntimeSelfCollision0 = 601,
		BeyondDynamicBone-SelfCollisionConstraint-SolverBroadPhase0 = 602,
		BeyondDynamicBone-TeamManager-get_TeamCount0 = 603,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateBroadPhase0 = 604,
		BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear1 = 605,
		BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear0 = 606,
		BeyondDynamicBone-SelfCollisionConstraint-SolveIntersect0 = 607,
		BeyondDynamicBone-ClothJobUtility-Fill0 = 608,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145$BurstDirectCall0 = 610,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146$BurstDirectCall0 = 611,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147$BurstDirectCall0 = 612,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148$BurstDirectCall0 = 613,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$ClearBufferJobKernels_ClearBufferKernel_00000149$BurstDirectCall0 = 614,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SortJobKernels_SortKernel_0000014A$BurstDirectCall0 = 615,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SortJobKernels_SortRangeKernel_0000014B$BurstDirectCall0 = 616,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E$BurstDirectCall0 = 617,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F$BurstDirectCall0 = 618,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180$BurstDirectCall0 = 619,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181$BurstDirectCall0 = 620,
		BeyondDynamicBone-SelfCollisionConstraint-SortData-CompareTo0 = 621,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeContact-ToString0 = 622,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleContact-ToString0 = 623,
		BeyondDynamicBone-SelfCollisionConstraint-InitPrimitiveJob-Execute0 = 624,
		BeyondDynamicBone-SelfCollisionConstraint-ClearBufferJob-Execute0 = 625,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-SetIndexCount0 = 626,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-Execute1 = 627,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-Execute0 = 628,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-UnsafeDo0 = 629,
		BeyondDynamicBone-SelfCollisionConstraint-SortJob-SetIndexCount0 = 630,
		BeyondDynamicBone-SelfCollisionConstraint-SortJob-Execute1 = 631,
		BeyondDynamicBone-SelfCollisionConstraint-SortJob-Execute0 = 632,
		BeyondDynamicBone-TeamManager-TeamData-get_IsProcess0 = 633,
		BeyondDynamicBone-TeamManager-TeamData-get_IsCullingInvisible0 = 634,
		BeyondDynamicBone-TeamManager-TeamData-get_IsCameraCullingInvisible0 = 635,
		BeyondDynamicBone-TeamManager-TeamData-get_IsDistanceCullingInvisible0 = 636,
		BeyondDynamicBone-SelfCollisionConstraint-SortJob-UnsafeDo0 = 637,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-SetIndexCount0 = 638,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-Execute1 = 639,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-Execute0 = 640,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-SweepTest0 = 641,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-BroadPointTriangle0 = 642,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-SetIndexCount0 = 643,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-Execute1 = 644,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-Execute0 = 645,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-SweepTest0 = 646,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-BroadEdgeEdge0 = 647,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeToListJob-Execute0 = 648,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleToListJob-Execute0 = 649,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseJob-Execute0 = 650,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseJob-Execute0 = 651,
		BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeJob-Execute0 = 652,
		BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleJob-Execute0 = 653,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-SetIndexCount0 = 654,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-Execute1 = 655,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-Execute0 = 656,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-UnsafeDo0 = 657,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-SetIndexCount0 = 658,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-Execute1 = 659,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-Execute0 = 660,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-SweepTest0 = 661,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-IntersectTest0 = 662,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseCrossFrameJob-Execute0 = 663,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseCrossFrameJob-Execute1 = 664,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseCrossFrameJob-Execute0 = 665,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseCrossFrameJob-Execute1 = 666,
		BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-Execute0 = 667,
		BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-Execute1 = 668,
		BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-UnsafeDo0 = 669,
		BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-Execute0 = 670,
		BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-Execute1 = 671,
		BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-UnsafeDo0 = 672,
		BeyondDynamicBone-SpringConstraint-Dispose0 = 673,
		BeyondDynamicBone-SpringConstraint-SolverConstraint0 = 674,
		BeyondDynamicBone-SpringConstraint-SerializeData-DataValidate0 = 675,
		BeyondDynamicBone-SpringConstraint-SerializeData-Clone0 = 676,
		BeyondDynamicBone-TetherConstraint-Dispose0 = 677,
		BeyondDynamicBone-TetherConstraint-SolverConstraint0 = 678,
		BeyondDynamicBone-TetherConstraint-TethreConstraintJob-SetIndexCount0 = 679,
		BeyondDynamicBone-TetherConstraint-TethreConstraintJob-Execute1 = 680,
		BeyondDynamicBone-TetherConstraint-TethreConstraintJob-Execute0 = 681,
		BeyondDynamicBone-TetherConstraint-TethreConstraintJob-UnsafeDo0 = 682,
		BeyondDynamicBone-TriangleBendingConstraint-get_DataCount0 = 683,
		BeyondDynamicBone-TriangleBendingConstraint-Dispose0 = 684,
		BeyondDynamicBone-TriangleBendingConstraint-ToString0 = 685,
		BeyondDynamicBone-TriangleBendingConstraint-SolverConstraint0 = 686,
		BeyondDynamicBone-TriangleBendingConstraint-Initialize$TriangleBendingJobKernels_TriangleBendingKernel_000001AA$BurstDirectCall0 = 687,
		BeyondDynamicBone-TriangleBendingConstraint-Initialize$TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB$BurstDirectCall0 = 688,
		BeyondDynamicBone-TriangleBendingConstraint-Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE$BurstDirectCall0 = 689,
		BeyondDynamicBone-TriangleBendingConstraint-Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF$BurstDirectCall0 = 690,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJobKernels-Volume0 = 691,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJobKernels-DihedralAngle0 = 692,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-SetIndexCount0 = 693,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Execute1 = 694,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Execute0 = 695,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Volume0 = 696,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-DihedralAngle0 = 697,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-UnsafeDo0 = 698,
		BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-SetIndexCount0 = 699,
		BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-Execute1 = 700,
		BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-Execute0 = 701,
		BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-UnsafeDo0 = 702,
		BeyondDynamicBone-CullingSettings-GetHashCode0 = 703,
		BeyondDynamicBone-CurveSerializeData-SetValue0 = 704,
		BeyondDynamicBone-CurveSerializeData-SetValue1 = 705,
		BeyondDynamicBone-CurveSerializeData-SetValue2 = 706,
		BeyondDynamicBone-CurveSerializeData-Evaluate0 = 707,
		BeyondDynamicBone-CustomSkinningSettings-IsValid0 = 708,
		BeyondDynamicBone-CustomSkinningSettings-GetHashCode0 = 712,
		BeyondDynamicBone-GizmoSerializeData-IsAlways0 = 713,
		BeyondDynamicBone-NormalAlignmentSettings-IsValid0 = 714,
		BeyondDynamicBone-NormalAlignmentSettings-GetHashCode0 = 715,
		BeyondDynamicBone-SelectionData-Compare0 = 716,
		BeyondDynamicBone-SelectionData-AddRange0 = 717,
		BeyondDynamicBone-SelectionData-GetPositionNativeArray1 = 718,
		BeyondDynamicBone-SelectionData-ConvertFrom0 = 719,
		BeyondDynamicBone-SelectionData-TransformPositionJob-Execute0 = 720,
		BeyondDynamicBone-SelectionData-CreateGridMapJob-Execute0 = 721,
		BeyondDynamicBone-SelectionData-ConvertSelectionJob-Execute0 = 722,
		BeyondDynamicBone-BeyondBoneWindZone-Awake0 = 723,
		BeyondDynamicBone-MagicaManager-get_Wind0 = 724,
		BeyondDynamicBone-WindManager-AddWind0 = 725,
		BeyondDynamicBone-BeyondBoneWindZone-Start0 = 727,
		BeyondDynamicBone-BeyondBoneWindZone-OnEnable0 = 728,
		BeyondDynamicBone-WindManager-SetEnable0 = 730,
		BeyondDynamicBone-BeyondBoneWindZone-OnDisable0 = 731,
		BeyondDynamicBone-BeyondBoneWindZone-OnDestroy0 = 732,
		BeyondDynamicBone-WindManager-RemoveWind0 = 733,
		BeyondDynamicBone-BeyondBoneWindZone-IsDirection0 = 734,
		BeyondDynamicBone-BeyondBoneWindZone-IsRadial0 = 735,
		BeyondDynamicBone-BeyondBoneWindZone-IsAddition0 = 736,
		BeyondDynamicBone-BeyondBoneWindZone-GetWindDirection0 = 737,
		BeyondDynamicBone-BeyondBoneWindZone-SetWindDirection0 = 738,
		BeyondDynamicBone-WindParams-IsValid0 = 739,
		BeyondDynamicBone-WindSettings-IsValid0 = 740,
		BeyondDynamicBone-ClothManager-Dispose0 = 741,
		BeyondDynamicBone-ClothManager-OnEarlyClothUpdate0 = 742,
		BeyondDynamicBone-TeamManager-get_TrueTeamCount0 = 743,
		BeyondDynamicBone-TeamManager-get_ActiveTeamCount0 = 744,
		BeyondDynamicBone-TeamManager-CameraCullingPostProcess0 = 745,
		BeyondDynamicBone-ClothManager-ClearVisibleDict0 = 746,
		BeyondDynamicBone-ClothManager-CheckVisible0 = 747,
		BeyondDynamicBone-ClothManager-CheckRendererVisible0 = 748,
		BeyondDynamicBone-ClothManager-CheckLODVisible0 = 749,
		BeyondDynamicBone-DynamicBoneTransformManager-RestoreTransform0 = 750,
		BeyondDynamicBone-DynamicBoneTransformManager-get_Count0 = 751,
		BeyondDynamicBone-ClothManager-OnAfterUpdate0 = 752,
		BeyondDynamicBone-TeamManager-UpdateTeamAnimatorData0 = 753,
		BeyondDynamicBone-ClothManager-OnAfterLateUpdate0 = 754,
		BeyondDynamicBone-ClothManager-ClothUpdate0 = 755,
		BeyondDynamicBone-TimeManager-FrameUpdate0 = 756,
		BeyondDynamicBone-TeamManager-AlwaysTeamUpdate0 = 761,
		BeyondDynamicBone-ColliderManager-UpdateColliders0 = 762,
		BeyondDynamicBone-ColliderManager-AddCollider0 = 763,
		BeyondDynamicBone-DynamicBoneTransformManager-Expand0 = 764,
		BeyondDynamicBone-RenderData-UpdateSkipWriting0 = 765,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadComponentTransform0 = 766,
		BeyondDynamicBone-TimeManager-GetDeltaTime0 = 767,
		BeyondDynamicBone-TimeManager-GetFixedDeltaTime0 = 771,
		BeyondDynamicBone-TimeManager-GetUnscaledDeltaTime0 = 773,
		BeyondDynamicBone-WindManager-AlwaysWindUpdate0 = 775,
		BeyondDynamicBone-SimulationManager-WorkBufferUpdate0 = 776,
		BeyondDynamicBone-VirtualMeshManager-get_ProxyBaseLineCount0 = 777,
		BeyondDynamicBone-ColliderManager-get_DataCount0 = 778,
		BeyondDynamicBone-ClothManager-ClearMasterJob0 = 779,
		BeyondDynamicBone-VirtualMeshManager-UpdateBuffer0 = 780,
		BeyondDynamicBone-VirtualMeshManager-get_ProxyVertexCount0 = 781,
		BeyondDynamicBone-VirtualMeshManager-get_ProxyTriangleCount0 = 782,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferData0 = 783,
		BeyondDynamicBone-TeamManager-CameraCullingPreProcess0 = 784,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadTransform0 = 785,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteDoubleBufferTransform0 = 786,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidPosition0 = 787,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-SetIndexCount0 = 788,
		BeyondDynamicBone-VirtualMeshManager-PreProxyMeshUpdate0 = 789,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWind0 = 790,
		BeyondDynamicBone-WindManager-get_WindCount0 = 791,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdate0 = 792,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdate0 = 793,
		BeyondDynamicBone-SimulationManager-SimulationStepUpdate0 = 794,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdate0 = 796,
		BeyondDynamicBone-ColliderManager-CreateUpdateColliderList0 = 797,
		BeyondDynamicBone-ColliderManager-StartSimulationStep0 = 798,
		BeyondDynamicBone-ColliderManager-EndSimulationStep0 = 799,
		BeyondDynamicBone-SimulationManager-CalcDisplayPosition0 = 800,
		BeyondDynamicBone-VirtualMeshManager-PostProxyMeshUpdate0 = 801,
		BeyondDynamicBone-TeamManager-get_MappingCount0 = 802,
		BeyondDynamicBone-VirtualMeshManager-PostMappingMeshUpdate0 = 803,
		BeyondDynamicBone-VirtualMeshManager-get_MappingVertexCount0 = 804,
		BeyondDynamicBone-RenderData-UpdatePositionNormal0 = 805,
		BeyondDynamicBone-RenderData-get_HasTangent0 = 806,
		BeyondDynamicBone-RenderData-UpdateBoneWeight0 = 807,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferData0 = 808,
		BeyondDynamicBone-DynamicBoneTransformManager-CopyDoubleBuffer0 = 809,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteTransform0 = 810,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdate0 = 811,
		BeyondDynamicBone-TeamManager-PostTeamUpdate0 = 812,
		BeyondDynamicBone-ClothManager-OnBeforeLateUpdate0 = 813,
		BeyondDynamicBone-ClothManager-OnApplicationQuit0 = 814,
		BeyondDynamicBone-ClothManager-EnterdEditMode0 = 815,
		BeyondDynamicBone-ClothManager-Initialize0 = 816,
		BeyondDynamicBone-ClothManager-IsValid0 = 817,
		BeyondDynamicBone-ClothManager-InformationLog0 = 818,
		BeyondDynamicBone-PreBuildManager-Dispose0 = 819,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-Dispose0 = 820,
		BeyondDynamicBone-PreBuildManager-EnterdEditMode0 = 821,
		BeyondDynamicBone-PreBuildManager-Initialize0 = 822,
		BeyondDynamicBone-PreBuildManager-IsValid0 = 823,
		BeyondDynamicBone-PreBuildManager-InformationLog0 = 824,
		BeyondDynamicBone-PreBuildManager-UnloadUnusedData0 = 825,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-get_RenderMeshCount0 = 826,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-GetProxyMeshContainer0 = 827,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-GetRenderMeshContainer0 = 828,
		BeyondDynamicBone-DoAllInOneJob-Execute0 = 829,
		BeyondDynamicBone-DynamicBoneTransformManager-Dispose0 = 830,
		BeyondDynamicBone-DynamicBoneTransformManager-EnterdEditMode0 = 831,
		BeyondDynamicBone-DynamicBoneTransformManager-Initialize0 = 832,
		BeyondDynamicBone-DynamicBoneTransformManager-IsValid0 = 833,
		BeyondDynamicBone-DynamicBoneTransformManager-InformationLog0 = 834,
		BeyondDynamicBone-DynamicBoneTransformManager-Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C$BurstDirectCall0 = 835,
		BeyondDynamicBone-DynamicBoneTransformManager-Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D$BurstDirectCall0 = 836,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferDataJob-Execute0 = 837,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferDataJob-_Do0 = 838,
		BeyondDynamicBone-TeamManager-TeamData-get_bUseRelativeTransform0 = 839,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferDataJob-Execute0 = 840,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferDataJob-UnsafeDo0 = 841,
		BeyondDynamicBone-DynamicBoneTransformManager-CopyDoubleBufferJob-Execute0 = 842,
		BeyondDynamicBone-DynamicBoneTransformManager-EnableTransformJob-Execute0 = 843,
		BeyondDynamicBone-DynamicBoneTransformManager-RestoreTransformJob-Execute0 = 844,
		BeyondDynamicBone-TeamManager-TeamData-get_IsCameraCullingKeep0 = 845,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadTransformJob-Execute0 = 846,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-Execute1 = 847,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-Execute0 = 848,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-UnsafeDo0 = 849,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteTransformJob-Execute0 = 850,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadComponentTransformJob-Execute0 = 851,
		BeyondDynamicBone-TeamManager-Dispose0 = 852,
		BeyondDynamicBone-TeamManager-MonitoringProcess0 = 853,
		BeyondDynamicBone-TeamManager-MonitoringProcessUpdate0 = 857,
		BeyondDynamicBone-TeamManager-EnterdEditMode0 = 858,
		BeyondDynamicBone-TeamManager-Initialize0 = 859,
		BeyondDynamicBone-TeamManager-IsValid0 = 860,
		BeyondDynamicBone-TeamManager-SetSkipWriting0 = 861,
		BeyondDynamicBone-TeamManager-InformationLog0 = 862,
		BeyondDynamicBone-TeamManager-MappingData-get_VertexCount0 = 863,
		BeyondDynamicBone-TeamWindData-get_ZoneCount0 = 864,
		BeyondDynamicBone-TeamWindInfo-ToString0 = 865,
		BeyondDynamicBone-TeamManager-Initialize$PostTeamUpdateJobKernels_PostTeamUpdateKernel_0000029A$BurstDirectCall0 = 866,
		BeyondDynamicBone-TeamManager-Initialize$PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_0000029B$BurstDirectCall0 = 867,
		BeyondDynamicBone-TeamManager-TeamData-get_IsFixedUpdate0 = 868,
		BeyondDynamicBone-TeamManager-TeamData-get_IsUnscaled0 = 869,
		BeyondDynamicBone-TeamManager-TeamData-get_IsReset0 = 870,
		BeyondDynamicBone-TeamManager-TeamData-get_IsKeepReset0 = 871,
		BeyondDynamicBone-TeamManager-TeamData-get_IsInertiaShift0 = 872,
		BeyondDynamicBone-TeamManager-TeamData-get_IsRunning0 = 873,
		BeyondDynamicBone-TeamManager-TeamData-get_IsStepRunning0 = 874,
		BeyondDynamicBone-TeamManager-TeamData-get_IsNegativeScale0 = 875,
		BeyondDynamicBone-TeamManager-TeamData-get_IsNegativeScaleTeleport0 = 876,
		BeyondDynamicBone-TeamManager-TeamData-get_IsTangent0 = 877,
		BeyondDynamicBone-TeamManager-TeamData-get_BaseLineCount0 = 878,
		BeyondDynamicBone-TeamManager-MappingData-IsValid0 = 879,
		BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePreJob-Execute0 = 880,
		BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePostJob-Execute0 = 881,
		BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePostJob-DistanceCullingUpdate0 = 882,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-SetIndexCount0 = 883,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Execute1 = 884,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Execute0 = 885,
		BeyondDynamicBone-MathUtility-ShiftPosition0 = 886,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Wind0 = 887,
		BeyondDynamicBone-WindManager-WindData-IsValid0 = 888,
		BeyondDynamicBone-WindManager-WindData-IsEnable0 = 889,
		BeyondDynamicBone-WindManager-WindData-IsAddition0 = 890,
		BeyondDynamicBone-TeamWindData-AddOrReplaceWindZone0 = 891,
		BeyondDynamicBone-TeamWindInfo-IsValid0 = 892,
		BeyondDynamicBone-TeamWindData-IndexOf0 = 893,
		BeyondDynamicBone-TeamWindData-RemoveWindZone0 = 894,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-UnsafeDo0 = 895,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-SetIndexCount0 = 896,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-Execute1 = 897,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-Execute0 = 898,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UpdateWind0 = 899,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UpdateWindTime0 = 900,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UnsafeDo0 = 901,
		BeyondDynamicBone-TeamManager-PostTeamUpdateJob-SetIndexCount0 = 902,
		BeyondDynamicBone-TeamManager-PostTeamUpdateJob-Execute1 = 903,
		BeyondDynamicBone-TeamManager-PostTeamUpdateJob-Execute0 = 904,
		BeyondDynamicBone-TeamManager-PostTeamUpdateJob-UnsafeDo0 = 905,
		BeyondDynamicBone-VirtualMeshManager-get_ProxyEdgeCount0 = 906,
		BeyondDynamicBone-VirtualMeshManager-get_ProxyLocalPositionCount0 = 907,
		BeyondDynamicBone-VirtualMeshManager-Dispose0 = 908,
		BeyondDynamicBone-VirtualMeshManager-EnterdEditMode0 = 909,
		BeyondDynamicBone-VirtualMeshManager-Initialize0 = 910,
		BeyondDynamicBone-VirtualMeshManager-IsValid0 = 911,
		BeyondDynamicBone-VirtualMeshManager-InformationLog0 = 912,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E8$BurstDirectCall0 = 913,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E9$BurstDirectCall0 = 914,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002EA$BurstDirectCall0 = 915,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002EB$BurstDirectCall0 = 916,
		BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformDataJobKernels_WriteTransformDataKernel_000002EC$BurstDirectCall0 = 917,
		BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002ED$BurstDirectCall0 = 918,
		BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EE$BurstDirectCall0 = 919,
		BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002EF$BurstDirectCall0 = 920,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002F0$BurstDirectCall0 = 921,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002F1$BurstDirectCall0 = 922,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F2$BurstDirectCall0 = 923,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F3$BurstDirectCall0 = 924,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F4$BurstDirectCall0 = 925,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F5$BurstDirectCall0 = 926,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F6$BurstDirectCall0 = 927,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F7$BurstDirectCall0 = 928,
		BeyondDynamicBone-VirtualMeshManager-Initialize$ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F8$BurstDirectCall0 = 929,
		BeyondDynamicBone-VirtualMeshManager-ClearProxyMeshUpdateBufferJob-Execute0 = 930,
		BeyondDynamicBone-VirtualMeshManager-ClearProxyMeshUpdateBufferJob-UnsafeDo0 = 931,
		BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-SetIndexCount0 = 932,
		BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-Execute1 = 933,
		BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-Execute0 = 934,
		BeyondDynamicBone-NativeReferenceExtensions-MC2InterlockedStartIndex0 = 935,
		BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-UnsafeDo0 = 936,
		BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-SetIndexCount0 = 937,
		BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-Execute1 = 938,
		BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-Execute0 = 939,
		BeyondDynamicBone-VirtualMeshBoneWeight-get_Count0 = 940,
		BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-UnsafeDo0 = 941,
		BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-SetIndexCount0 = 942,
		BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-Execute1 = 943,
		BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-Execute0 = 944,
		BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-UnsafeDo0 = 945,
		BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-SetIndexCount0 = 946,
		BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-Execute1 = 947,
		BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-Execute0 = 948,
		BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-UnsafeDo0 = 949,
		BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-SetIndexCount0 = 950,
		BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-Execute1 = 951,
		BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-Execute0 = 952,
		BeyondDynamicBone-MathUtility-TriangleTangent0 = 953,
		BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-UnsafeDo0 = 954,
		BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-SetIndexCount0 = 955,
		BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-Execute1 = 956,
		BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-Execute0 = 957,
		BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-UnsafeDo0 = 958,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-SetIndexCount0 = 959,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-Execute1 = 960,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-Execute0 = 961,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-UnsafeDo0 = 962,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-SetIndexCount0 = 963,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-Execute1 = 964,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-Execute0 = 965,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-UnsafeDo0 = 966,
		BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-SetIndexCount0 = 967,
		BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-Execute1 = 968,
		BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-Execute0 = 969,
		BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-UnsafeDo0 = 970,
		BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-SetIndexCount0 = 971,
		BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-Execute1 = 972,
		BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-Execute0 = 973,
		BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-UnsafeDo0 = 974,
		BeyondDynamicBone-MagicaManager-Initialize0 = 975,
		BeyondDynamicBone-MagicaManager-Dispose0 = 976,
		BeyondDynamicBone-MagicaManager-InitCustomGameLoop0 = 977,
		BeyondDynamicBone-MagicaManager-CheckRegist0 = 978,
		BeyondDynamicBone-MagicaManager-SetCustomGameLoop0 = 981,
		BeyondDynamicBone-PlayerLoopUtils-AddPlayerLoop0 = 992,
		BeyondDynamicBone-MagicaManager-SetUseCrossFrameJob0 = 996,
		BeyondDynamicBone-MagicaManager-SetGlobalTimeScale0 = 997,
		BeyondDynamicBone-MagicaManager-GetGlobalTimeScale0 = 998,
		BeyondDynamicBone-MagicaManager-SetSimulationFrequency0 = 999,
		BeyondDynamicBone-MagicaManager-SetAOVMode0 = 1000,
		BeyondDynamicBone-MagicaManager-DoAOVUpdate0 = 1005,
		BeyondDynamicBone-MagicaManager-DoAOVAfterAnimatorUpdate0 = 1006,
		BeyondDynamicBone-MagicaManager-GetSimulationFrequency0 = 1007,
		BeyondDynamicBone-MagicaManager-SetMaxSimulationCountPerFrame0 = 1008,
		BeyondDynamicBone-MagicaManager-GetMaxSimulationCountPerFrame0 = 1009,
		BeyondDynamicBone-MagicaManager-SetUpdateLocation0 = 1010,
		BeyondDynamicBone-MagicaManager-GetUpdateLocation0 = 1011,
		BeyondDynamicBone-MagicaManager-UnloadUnusedData0 = 1012,
		BeyondDynamicBone-MagicaManager-SetInitializationLocation0 = 1013,
		BeyondDynamicBone-MagicaSettings-Awake0 = 1014,
		BeyondDynamicBone-MagicaSettings-Refresh0 = 1015,
		BeyondDynamicBone-MagicaSettings-Start0 = 1016,
		BeyondDynamicBone-MagicaSettings-Update0 = 1017,
		BeyondDynamicBone-MagicaSettings-OnValidate0 = 1018,
		BeyondDynamicBone-RenderData-get_HasSkinnedMesh0 = 1019,
		BeyondDynamicBone-RenderData-WriteMesh0 = 1020,
		BeyondDynamicBone-RenderData-ToString0 = 1021,
		BeyondDynamicBone-RenderData-UpdatePositionNormalJob-SetIndexCount0 = 1022,
		BeyondDynamicBone-RenderData-UpdatePositionNormalJob-Execute1 = 1023,
		BeyondDynamicBone-RenderData-UpdatePositionNormalJob-Execute0 = 1024,
		BeyondDynamicBone-RenderData-UpdatePositionNormalJob-UnsafeDo0 = 1025,
		BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-SetIndexCount0 = 1026,
		BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-Execute1 = 1027,
		BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-Execute0 = 1028,
		BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-UnsafeDo0 = 1029,
		BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-SetIndexCount0 = 1030,
		BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-Execute1 = 1031,
		BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-Execute0 = 1032,
		BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-UnsafeDo0 = 1033,
		BeyondDynamicBone-RenderManager-Initialize0 = 1034,
		BeyondDynamicBone-RenderManager-Dispose0 = 1035,
		BeyondDynamicBone-RenderManager-PreRenderingUpdate0 = 1036,
		BeyondDynamicBone-RenderManager-EnterdEditMode0 = 1037,
		BeyondDynamicBone-RenderManager-IsValid0 = 1038,
		BeyondDynamicBone-RenderManager-InformationLog0 = 1039,
		BeyondDynamicBone-RenderSetupData-IsSuccess0 = 1040,
		BeyondDynamicBone-RenderSetupData-get_HasLocalPositions0 = 1041,
		BeyondDynamicBone-RenderSetupData-ReadTransformInformation0 = 1042,
		BeyondDynamicBone-RenderSetupData-GetRendeerLocalToWorldMatrix0 = 1043,
		BeyondDynamicBone-RenderSetupData-GetRendeerTransform0 = 1044,
		BeyondDynamicBone-RenderSetupData-GetRenderTransformId0 = 1045,
		BeyondDynamicBone-RenderSetupData-GetSkinRootTransform0 = 1046,
		BeyondDynamicBone-RenderSetupData-GetSkinRootTransformId0 = 1047,
		BeyondDynamicBone-RenderSetupData-ShareSerialize0 = 1048,
		BeyondDynamicBone-RenderSetupData-UniqueSerialize0 = 1049,
		BeyondDynamicBone-RenderSetupData-VertexWeight5BoneCheckJob-Execute0 = 1050,
		BeyondDynamicBone-RenderSetupData-ReadTransformJob-Execute0 = 1051,
		BeyondDynamicBone-RenderSetupData-GetBoneWeightJos-Execute0 = 1052,
		BeyondDynamicBone-ColliderManager-get_ColliderCount0 = 1053,
		BeyondDynamicBone-ColliderManager-Dispose0 = 1054,
		BeyondDynamicBone-ColliderManager-EnterdEditMode0 = 1055,
		BeyondDynamicBone-ColliderManager-Initialize0 = 1056,
		BeyondDynamicBone-ColliderManager-InformationLog0 = 1057,
		BeyondDynamicBone-ColliderManager-Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D5$BurstDirectCall0 = 1058,
		BeyondDynamicBone-ColliderManager-Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D6$BurstDirectCall0 = 1059,
		BeyondDynamicBone-ColliderManager-Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D9$BurstDirectCall0 = 1060,
		BeyondDynamicBone-ColliderManager-Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003DA$BurstDirectCall0 = 1061,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-SetIndexCount0 = 1062,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-Execute1 = 1063,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-Execute0 = 1064,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-UnsafeDo0 = 1065,
		BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-SetIndexCount0 = 1066,
		BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-Execute1 = 1067,
		BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-Execute0 = 1068,
		BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-UnsafeDo0 = 1069,
		BeyondDynamicBone-ColliderManager-StartSimulationStepJob-SetIndexCount0 = 1070,
		BeyondDynamicBone-ColliderManager-StartSimulationStepJob-Execute1 = 1071,
		BeyondDynamicBone-ColliderManager-StartSimulationStepJob-Execute0 = 1072,
		BeyondDynamicBone-ColliderManager-StartSimulationStepJob-UnsafeDo0 = 1073,
		BeyondDynamicBone-ColliderManager-EndSimulationStepJob-SetIndexCount0 = 1074,
		BeyondDynamicBone-ColliderManager-EndSimulationStepJob-Execute1 = 1075,
		BeyondDynamicBone-ColliderManager-EndSimulationStepJob-Execute0 = 1076,
		BeyondDynamicBone-ColliderManager-EndSimulationStepJob-UnsafeDo0 = 1077,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-SetIndexCount0 = 1078,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-Execute1 = 1079,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-Execute0 = 1080,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-UnsafeDo0 = 1081,
		BeyondDynamicBone-SimulationManager-get_WorkerCount0 = 1082,
		BeyondDynamicBone-SimulationManager-Dispose0 = 1083,
		BeyondDynamicBone-SimulationManager-EnterdEditMode0 = 1084,
		BeyondDynamicBone-SimulationManager-Initialize0 = 1085,
		BeyondDynamicBone-SimulationManager-IsValid0 = 1086,
		BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer0 = 1087,
		BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer2 = 1088,
		BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer1 = 1089,
		BeyondDynamicBone-SimulationManager-InformationLog0 = 1090,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_StartSimulationStepKernel_00000407$BurstDirectCall0 = 1091,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000408$BurstDirectCall0 = 1092,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_Spring_00000409$BurstDirectCall0 = 1093,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_Wind_0000040A$BurstDirectCall0 = 1094,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_WindForceBlend_0000040B$BurstDirectCall0 = 1095,
		BeyondDynamicBone-SimulationManager-Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040C$BurstDirectCall0 = 1096,
		BeyondDynamicBone-SimulationManager-Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040D$BurstDirectCall0 = 1097,
		BeyondDynamicBone-SimulationManager-Initialize$EndSimulationStepJobKernels_EndSimulationStepKernel_0000040E$BurstDirectCall0 = 1098,
		BeyondDynamicBone-SimulationManager-Initialize$EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040F$BurstDirectCall0 = 1099,
		BeyondDynamicBone-SimulationManager-Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_00000410$BurstDirectCall0 = 1100,
		BeyondDynamicBone-SimulationManager-Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_00000411$BurstDirectCall0 = 1101,
		BeyondDynamicBone-SimulationManager-Initialize$ClearStepCounterKernels_ClearStepCounterKernel_00000412$BurstDirectCall0 = 1102,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-SetIndexCount0 = 1103,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-Execute1 = 1104,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-Execute0 = 1105,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-UnsafeDo0 = 1106,
		BeyondDynamicBone-SimulationManager-ClearStepCounter-Execute0 = 1107,
		BeyondDynamicBone-SimulationManager-ClearStepCounter-UnsafeDo0 = 1108,
		BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-SetIndexCount0 = 1109,
		BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-Execute1 = 1110,
		BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-Execute0 = 1111,
		BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-UnsafeDo0 = 1112,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-SetIndexCount0 = 1113,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Execute1 = 1114,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Execute0 = 1115,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Wind0 = 1116,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-WindForceBlend0 = 1117,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Spring0 = 1118,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-UnsafeDo0 = 1119,
		BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-SetIndexCount0 = 1120,
		BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-Execute1 = 1121,
		BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-Execute0 = 1122,
		BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-UnsafeDo0 = 1123,
		BeyondDynamicBone-SimulationManager-EndSimulationStepJob-SetIndexCount0 = 1124,
		BeyondDynamicBone-SimulationManager-EndSimulationStepJob-Execute1 = 1125,
		BeyondDynamicBone-SimulationManager-EndSimulationStepJob-Execute0 = 1126,
		BeyondDynamicBone-SimulationManager-EndSimulationStepJob-UnsafeDo0 = 1127,
		BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-SetIndexCount0 = 1128,
		BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-Execute1 = 1129,
		BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-Execute0 = 1130,
		BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-UnsafeDo0 = 1131,
		BeyondDynamicBone-SimulationManager-FeedbackTempPosJob-Execute0 = 1132,
		BeyondDynamicBone-SimulationManager-FeedbackTempPosJob2-Execute0 = 1133,
		BeyondDynamicBone-TimeManager-Dispose0 = 1134,
		BeyondDynamicBone-TimeManager-AfterFixedUpdate0 = 1136,
		BeyondDynamicBone-TimeManager-AfterRenderring0 = 1137,
		BeyondDynamicBone-TimeManager-EnterdEditMode0 = 1138,
		BeyondDynamicBone-TimeManager-Initialize0 = 1139,
		BeyondDynamicBone-TimeManager-IsValid0 = 1140,
		BeyondDynamicBone-TimeManager-InformationLog0 = 1141,
		BeyondDynamicBone-WindManager-Dispose0 = 1142,
		BeyondDynamicBone-WindManager-EnterdEditMode0 = 1143,
		BeyondDynamicBone-WindManager-Initialize0 = 1144,
		BeyondDynamicBone-WindManager-IsValid0 = 1145,
		BeyondDynamicBone-WindManager-InformationLog0 = 1146,
		BeyondDynamicBone-BeyondBoneClothSavePoint-Load0 = 1147,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadTeamManagerTeamData0 = 1148,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadColliderManagerData0 = 1149,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadSimulationManagerData0 = 1150,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadVirtualMeshManagerData0 = 1151,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadInertiaConstraintCenterData0 = 1152,
		BeyondDynamicBone-BeyondBoneClothSavePoint-Save0 = 1153,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveTeamManagerTeamData0 = 1154,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveColliderManagerData0 = 1155,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveSimulationManagerData0 = 1156,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveVirtualMeshManagerData0 = 1157,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveInertiaConstraintCenterData0 = 1158,
		BeyondDynamicBone-TeamWindInfo-DebugLog0 = 1159,
		BeyondDynamicBone-TeamWindData-ClearZoneList0 = 1160,
		BeyondDynamicBone-TransformData-Init0 = 1161,
		BeyondDynamicBone-TransformData-get_IsDirty0 = 1162,
		BeyondDynamicBone-TransformData-AddTransform2 = 1163,
		BeyondDynamicBone-TransformData-AddTransformRange1 = 1164,
		BeyondDynamicBone-TransformData-AddTransformRange2 = 1165,
		BeyondDynamicBone-TransformData-RemoveTransformIndex0 = 1166,
		BeyondDynamicBone-TransformData-ReplaceTransform0 = 1167,
		BeyondDynamicBone-TransformData-UpdateWorkData0 = 1168,
		BeyondDynamicBone-TransformData-RestoreTransform0 = 1169,
		BeyondDynamicBone-TransformData-ReadTransform0 = 1170,
		BeyondDynamicBone-TransformData-ReadTransformRun0 = 1171,
		BeyondDynamicBone-TransformData-GetTransformIndexFormId0 = 1172,
		BeyondDynamicBone-TransformData-GetTransformIdFromIndex0 = 1173,
		BeyondDynamicBone-TransformData-GetParentIdFromIndex0 = 1174,
		BeyondDynamicBone-TransformData-GetLocalToWorldMatrix0 = 1175,
		BeyondDynamicBone-TransformData-GetWorldToLocalMatrix0 = 1176,
		BeyondDynamicBone-TransformData-ToString0 = 1177,
		BeyondDynamicBone-TransformData-ShareSerialize0 = 1178,
		BeyondDynamicBone-TransformData-UniqueSerialize0 = 1179,
		BeyondDynamicBone-TransformData-RestoreTransformJob-Execute0 = 1180,
		BeyondDynamicBone-TransformData-ReadTransformJob-Execute0 = 1181,
		BeyondDynamicBone-TransformRecord-InverseTransformDirection0 = 1182,
		BeyondDynamicBone-PreBuildScriptableObject-HasPreBuildData0 = 1183,
		BeyondDynamicBone-PreBuildScriptableObject-GetPreBuildData0 = 1184,
		BeyondDynamicBone-SharePreBuildData-CheckBuildId0 = 1185,
		BeyondDynamicBone-PreBuildScriptableObject-AddPreBuildData0 = 1186,
		BeyondDynamicBone-PreBuildScriptableObject-Warmup0 = 1189,
		BeyondDynamicBone-PreBuildSerializeData-GenerateBuildID0 = 1193,
		BeyondDynamicBone-SharePreBuildData-ToString0 = 1194,
		BeyondDynamicBone-ReductionSettings-GetHashCode0 = 1195,
		BeyondDynamicBone-ReductionSettings-ToString0 = 1196,
		BeyondDynamicBone-ReductionWorkData-Dispose0 = 1197,
		BeyondDynamicBone-SameDistanceReduction-Dispose0 = 1198,
		BeyondDynamicBone-SameDistanceReduction-InitGridJob-Execute0 = 1199,
		BeyondDynamicBone-SameDistanceReduction-SearchJoinJob-Execute0 = 1200,
		BeyondDynamicBone-SameDistanceReduction-JoinJob2-Execute0 = 1201,
		BeyondDynamicBone-VirtualMeshBoneWeight-AddWeight1 = 1202,
		BeyondDynamicBone-VirtualMeshBoneWeight-get_IsValid0 = 1203,
		BeyondDynamicBone-VirtualMeshBoneWeight-AddWeight0 = 1204,
		BeyondDynamicBone-SameDistanceReduction-UpdateJoinIndexJob-Execute0 = 1205,
		BeyondDynamicBone-SameDistanceReduction-UpdateLinkIndexJob-Execute0 = 1206,
		BeyondDynamicBone-SameDistanceReduction-FinalMergeVertexJob-Execute0 = 1207,
		BeyondDynamicBone-VirtualMeshBoneWeight-AdjustWeight0 = 1208,
		BeyondDynamicBone-ShapeDistanceReduction-Dispose0 = 1209,
		BeyondDynamicBone-StepReductionBase-Dispose0 = 1210,
		BeyondDynamicBone-ShapeDistanceReduction-StepInitialize0 = 1211,
		BeyondDynamicBone-ShapeDistanceReduction-CustomReductionStep0 = 1212,
		BeyondDynamicBone-ShapeDistanceReduction-SearchJoinEdgeJob-Execute0 = 1213,
		BeyondDynamicBone-StepReductionBase-CheckJoin20 = 1214,
		BeyondDynamicBone-SimpleDistanceReduction-Dispose0 = 1215,
		BeyondDynamicBone-SimpleDistanceReduction-StepInitialize0 = 1216,
		BeyondDynamicBone-SimpleDistanceReduction-CustomReductionStep0 = 1217,
		BeyondDynamicBone-SimpleDistanceReduction-InitGridJob-Execute0 = 1218,
		BeyondDynamicBone-SimpleDistanceReduction-SearchJoinEdgeJob-Execute0 = 1219,
		BeyondDynamicBone-StepReductionBase-CheckJoin0 = 1220,
		BeyondDynamicBone-StepReductionBase-JoinEdge-Contains0 = 1221,
		BeyondDynamicBone-StepReductionBase-JoinEdge-CompareTo0 = 1222,
		BeyondDynamicBone-StepReductionBase-DeterminJoinEdgeJob-Execute0 = 1223,
		BeyondDynamicBone-StepReductionBase-JoinPairJob-Execute0 = 1224,
		BeyondDynamicBone-StepReductionBase-UpdateJoinIndexJob-Execute0 = 1225,
		BeyondDynamicBone-StepReductionBase-UpdateLinkIndexJob-Execute0 = 1226,
		BeyondDynamicBone-StepReductionBase-FinalMergeVertexJob-Execute0 = 1227,
		BeyondDynamicBone-ClothDebugSettings-CheckParticleDrawing0 = 1228,
		BeyondDynamicBone-ClothDebugSettings-CheckTriangleDrawing0 = 1229,
		BeyondDynamicBone-ClothDebugSettings-CheckRadiusDrawing0 = 1230,
		BeyondDynamicBone-ClothDebugSettings-GetPointSize0 = 1231,
		BeyondDynamicBone-ClothDebugSettings-GetLineSize0 = 1232,
		BeyondDynamicBone-ClothDebugSettings-GetInertiaCenterRadius0 = 1233,
		BeyondDynamicBone-ClothDebugSettings-GetCustomSkinningRadius0 = 1234,
		BeyondDynamicBone-ClothDebugSettings-IsReferOldPos0 = 1235,
		BeyondDynamicBone-DataUtility-PackInt31 = 1236,
		BeyondDynamicBone-ClothJobUtility-Fill1 = 1237,
		BeyondDynamicBone-ClothJobUtility-Fill2 = 1238,
		BeyondDynamicBone-ClothJobUtility-SerialNumber0 = 1239,
		BeyondDynamicBone-ClothJobUtility-ConvertHashSetToNativeList0 = 1240,
		BeyondDynamicBone-ClothJobUtility-ConvertHashSetKeyToNativeList0 = 1241,
		BeyondDynamicBone-ClothJobUtility-ConvertHashSetKeyToNativeList1 = 1242,
		BeyondDynamicBone-ClothJobUtility-CalcAABB0 = 1243,
		BeyondDynamicBone-ClothJobUtility-CalcAABB1 = 1244,
		BeyondDynamicBone-ClothJobUtility-CalcAABBRun1 = 1245,
		BeyondDynamicBone-ClothJobUtility-CalcAABBInternal0 = 1246,
		BeyondDynamicBone-ClothJobUtility-CalcUVWithSphereMapping0 = 1247,
		BeyondDynamicBone-ClothJobUtility-TransformPosition0 = 1248,
		BeyondDynamicBone-ClothJobUtility-TransformPosition1 = 1249,
		BeyondDynamicBone-ClothJobUtility-ClearReference0 = 1250,
		BeyondDynamicBone-ClothJobUtility-SerialNumberJob-Execute0 = 1251,
		BeyondDynamicBone-ClothJobUtility-CalcAABBJob-Execute0 = 1252,
		BeyondDynamicBone-ClothJobUtility-CalcAABBDeferJob-Execute0 = 1253,
		BeyondDynamicBone-ClothJobUtility-CalcUVJob-Execute0 = 1254,
		BeyondDynamicBone-ClothJobUtility-AddIntDataCopyJob-Execute0 = 1255,
		BeyondDynamicBone-ClothJobUtility-AddInt2DataCopyJob-Execute0 = 1256,
		BeyondDynamicBone-ClothJobUtility-AddInt3DataCopyJob-Execute0 = 1257,
		BeyondDynamicBone-ClothJobUtility-TransformPositionJob-Execute0 = 1258,
		BeyondDynamicBone-ClothJobUtility-TransformPositionJob2-Execute0 = 1259,
		BeyondDynamicBone-ClothJobUtility-ClearReferenceJob-Execute0 = 1260,
		BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear2 = 1261,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateJobKernels_AggregateKernel_0000057A$BurstDirectCall0 = 1262,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateJobKernels_AggregateRangeKernel_0000057B$BurstDirectCall0 = 1263,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_0000057C$BurstDirectCall0 = 1264,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_0000057D$BurstDirectCall0 = 1265,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateJob2Kernels_AggregateJob2Kernel_0000057E$BurstDirectCall0 = 1266,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateJob2Kernels_AggregateJob2RangeKernel_0000057F$BurstDirectCall0 = 1267,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_00000580$BurstDirectCall0 = 1268,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_00000581$BurstDirectCall0 = 1269,
		BeyondDynamicBone-InterlockUtility-AggregateJob-Execute0 = 1270,
		BeyondDynamicBone-InterlockUtility-AggregateJob-UnsafeDo0 = 1271,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob-Execute0 = 1272,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob-UnsafeDo0 = 1273,
		BeyondDynamicBone-InterlockUtility-AggregateJob2-SetIndexCount0 = 1274,
		BeyondDynamicBone-InterlockUtility-AggregateJob2-Execute1 = 1275,
		BeyondDynamicBone-InterlockUtility-AggregateJob2-Execute0 = 1276,
		BeyondDynamicBone-InterlockUtility-AggregateJob2-UnsafeDo0 = 1277,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-SetIndexCount0 = 1278,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-Execute1 = 1279,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-Execute0 = 1280,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-UnsafeDo0 = 1281,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityCrossFrameJob2-Execute0 = 1282,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityCrossFrameJob2-Execute1 = 1283,
		BeyondDynamicBone-InterlockUtility-AggregateCrossFrameJob2-Execute0 = 1284,
		BeyondDynamicBone-InterlockUtility-AggregateCrossFrameJob2-Execute1 = 1285,
		BeyondDynamicBone-AABB-get_HalfExtents0 = 1286,
		BeyondDynamicBone-AABB-get_IsValid0 = 1287,
		BeyondDynamicBone-AABB-get_SurfaceArea0 = 1288,
		BeyondDynamicBone-AABB-ToString0 = 1289,
		BeyondDynamicBone-IntAABB-get_Extents0 = 1290,
		BeyondDynamicBone-IntAABB-get_Center0 = 1291,
		BeyondDynamicBone-IntAABB-get_IsValid0 = 1292,
		BeyondDynamicBone-MathUtility-ComputeVirtualParentWithoutLocal0 = 1293,
		BeyondDynamicBone-MathUtility-TriangleTangent1 = 1294,
		BeyondDynamicBone-MathUtility-GetCommonEdgeFromTrianglePair0 = 1295,
		BeyondDynamicBone-MathUtility-GetTrianglePairIndices0 = 1296,
		BeyondDynamicBone-MathUtility-IntersectSegmentTriangle0 = 1297,
		BeyondDynamicBone-MathUtility-IntersectSegmentTriangle1 = 1298,
		BeyondDynamicBone-MathUtility-SqDistPointSegment0 = 1299,
		BeyondDynamicBone-FTransform-Default0 = 1300,
		BeyondDynamicBone-MeshUtility-GetSharedMesh0 = 1301,
		BeyondDynamicBone-MeshUtility-SetMesh0 = 1302,
		BeyondDynamicBone-MeshUtility-GetTransformCount0 = 1303,
		BeyondDynamicBone-Develop-Log0 = 1304,
		BeyondDynamicBone-Develop-DebugLog0 = 1305,
		BeyondDynamicBone-Develop-DebugLogWarning0 = 1306,
		BeyondDynamicBone-Develop-DebugLogError0 = 1307,
		BeyondDynamicBone-Develop-Assert0 = 1308,
		BeyondDynamicBone-StaticStringBuilder-get_Instance0 = 1309,
		BeyondDynamicBone-StaticStringBuilder-Clear0 = 1310,
		BeyondDynamicBone-StaticStringBuilder-Append0 = 1311,
		BeyondDynamicBone-StaticStringBuilder-AppendLine0 = 1312,
		BeyondDynamicBone-StaticStringBuilder-AppendLine1 = 1313,
		BeyondDynamicBone-StaticStringBuilder-AppendToString0 = 1314,
		BeyondDynamicBone-StaticStringBuilder-ToString0 = 1315,
		BeyondDynamicBone-DataChunk-ToString0 = 1316,
		BeyondDynamicBone-ExBitFlag16-Clear0 = 1317,
		BeyondDynamicBone-ExCostSortedList1-get_IsValid0 = 1318,
		BeyondDynamicBone-ExCostSortedList1-get_Count0 = 1319,
		BeyondDynamicBone-ExCostSortedList1-get_Cost0 = 1320,
		BeyondDynamicBone-ExCostSortedList1-get_Data0 = 1321,
		BeyondDynamicBone-ExCostSortedList1-CompareTo0 = 1322,
		BeyondDynamicBone-ExCostSortedList1-ToString0 = 1323,
		BeyondDynamicBone-ExCostSortedList4-get_IsValid0 = 1324,
		BeyondDynamicBone-ExCostSortedList4-Add0 = 1325,
		BeyondDynamicBone-ExCostSortedList4-indexOf0 = 1326,
		BeyondDynamicBone-ExCostSortedList4-RemoveItem0 = 1327,
		BeyondDynamicBone-ExCostSortedList4-ToString0 = 1328,
		BeyondDynamicBone-ExTransformAccessArray-Dispose0 = 1329,
		BeyondDynamicBone-ExTransformAccessArray-GetTransformAccessArray0 = 1330,
		BeyondDynamicBone-ExTransformAccessArray-Add0 = 1331,
		BeyondDynamicBone-ExTransformAccessArray-Remove0 = 1332,
		BeyondDynamicBone-ExTransformAccessArray-Exist0 = 1333,
		BeyondDynamicBone-ExTransformAccessArray-Exist1 = 1334,
		BeyondDynamicBone-ExTransformAccessArray-get_Count0 = 1335,
		BeyondDynamicBone-ExTransformAccessArray-get_Length0 = 1336,
		BeyondDynamicBone-ExTransformAccessArray-get_Item0 = 1337,
		BeyondDynamicBone-ExTransformAccessArray-GetIndex0 = 1338,
		BeyondDynamicBone-ExTransformAccessArray-Clear0 = 1339,
		BeyondDynamicBone-ResultCode-get_Empty0 = 1340,
		BeyondDynamicBone-ResultCode-get_Error0 = 1341,
		BeyondDynamicBone-ResultCode-IsResult0 = 1342,
		BeyondDynamicBone-ResultCode-IsCancel0 = 1343,
		BeyondDynamicBone-ResultCode-IsProcess0 = 1344,
		BeyondDynamicBone-ResultCode-GetWarningString0 = 1345,
		BeyondDynamicBone-ResultCode-GetResultInformation0 = 1346,
		BeyondDynamicBone-ResultCode-GetWarningInformation0 = 1347,
		BeyondDynamicBone-ResultCode-DebugLog0 = 1348,
		BeyondDynamicBone-TimeSpan-Start0 = 1349,
		BeyondDynamicBone-TimeSpan-Finish0 = 1350,
		BeyondDynamicBone-TimeSpan-TotalSeconds0 = 1351,
		BeyondDynamicBone-TimeSpan-TotalMilliSeconds0 = 1352,
		BeyondDynamicBone-TimeSpan-ToString0 = 1353,
		BeyondDynamicBone-TimeSpan-DebugLog0 = 1354,
		BeyondDynamicBone-TimeSpan-Log0 = 1355,
		BeyondDynamicBone-UnityTimeSpan-Finish0 = 1356,
		BeyondDynamicBone-UnityTimeSpan-TotalSeconds0 = 1357,
		BeyondDynamicBone-UnityTimeSpan-TotalMilliSeconds0 = 1358,
		BeyondDynamicBone-UnityTimeSpan-ToString0 = 1359,
		BeyondDynamicBone-UnityTimeSpan-DebugLog0 = 1360,
		BeyondDynamicBone-VirtualMesh-SetTransform1 = 1361,
		BeyondDynamicBone-VirtualMesh-SetCenterTransform0 = 1362,
		BeyondDynamicBone-VirtualMesh-SetSkinRoot0 = 1363,
		BeyondDynamicBone-VirtualMesh-CalcVertexWeights0 = 1364,
		BeyondDynamicBone-VirtualMesh-ShareSerialize0 = 1365,
		BeyondDynamicBone-VirtualMesh-UniqueSerialize0 = 1366,
		BeyondDynamicBone-VirtualMesh-IntersectRayMesh0 = 1367,
		BeyondDynamicBone-VirtualMesh-get_InitCalcScale0 = 1368,
		BeyondDynamicBone-VirtualMesh-get_IsProcess0 = 1369,
		BeyondDynamicBone-VirtualMesh-get_IsProxy0 = 1370,
		BeyondDynamicBone-VirtualMesh-get_NormalAdjustmentRotationCount0 = 1371,
		BeyondDynamicBone-VirtualMesh-SetName0 = 1372,
		BeyondDynamicBone-VirtualMesh-ToString0 = 1373,
		BeyondDynamicBone-VirtualMesh-Import_GenerateTangentJob-Execute0 = 1374,
		BeyondDynamicBone-VirtualMesh-Import_CalcSkinningJob-Execute0 = 1375,
		BeyondDynamicBone-VirtualMesh-Import_BoneWeightJob1-Execute0 = 1376,
		BeyondDynamicBone-VirtualMesh-Import_BoneWeightJob2-Execute0 = 1377,
		BeyondDynamicBone-VirtualMesh-Import_BoneVertexJob-Execute0 = 1378,
		BeyondDynamicBone-VirtualMesh-Select_PackVertexJob-Execute0 = 1379,
		BeyondDynamicBone-VirtualMesh-Select_GridJob-Execute0 = 1380,
		BeyondDynamicBone-VirtualMesh-Add_CalcBindPoseJob-Execute0 = 1381,
		BeyondDynamicBone-VirtualMesh-Add_CopyVerticesJob-Execute0 = 1382,
		BeyondDynamicBone-VirtualMesh-Mapping_DirectConnectionVertexDataJob-Execute0 = 1383,
		BeyondDynamicBone-VirtualMesh-Mapping_CalcDirectWeightJob-Execute0 = 1384,
		BeyondDynamicBone-VirtualMesh-Mapping_CalcConnectionVertexDataJob-Execute0 = 1385,
		BeyondDynamicBone-VirtualMesh-Mapping_CalcWeightJob-Execute0 = 1386,
		BeyondDynamicBone-VirtualMesh-Optimize_EdgeToTrianlgeJob-Execute0 = 1387,
		BeyondDynamicBone-VirtualMesh-ProxyNormalRadiationAdjustmentJob-Execute0 = 1388,
		BeyondDynamicBone-VirtualMesh-ProxyCreateFixedListAndAABBJob-Execute0 = 1389,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcTriangleNormalJob-Execute0 = 1390,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcTriangleTangentJob-Execute0 = 1391,
		BeyondDynamicBone-VirtualMesh-Proxy_CreateVertexToTrianglesJob-Execute0 = 1392,
		BeyondDynamicBone-VirtualMesh-Proxy_OrganizeVertexToTrianglsJob-Execute0 = 1393,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexNormalTangentFromTriangleJob-Execute0 = 1394,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToTransformJob-Execute0 = 1395,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcEdgeToTriangleJob-Execute0 = 1396,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexBindPoseJob2-Execute0 = 1397,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToVertexFromTriangleJob-Execute0 = 1398,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToVertexFromLineJob-Execute0 = 1399,
		BeyondDynamicBone-VirtualMesh-Proxy_CreateEdgeFlagJob-Execute0 = 1400,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcCustomSkinningWeightsJobV2-Execute0 = 1401,
		BeyondDynamicBone-VirtualMesh-Proxy_ApplySelectionJob-Execute0 = 1402,
		BeyondDynamicBone-VirtualMesh-Proxy_BoneClothApplayTransformFlagJob-Execute0 = 1403,
		BeyondDynamicBone-VirtualMesh-BaseLineWork-CompareTo0 = 1404,
		BeyondDynamicBone-VirtualMesh-BaseLine_Mesh_CreateParentJob2-Execute0 = 1405,
		BeyondDynamicBone-VirtualMesh-BaseLine_Mesh_CareteFixedListJob-Execute0 = 1406,
		BeyondDynamicBone-VirtualMesh-BaseLine_Bone_CreateBoneChildInfoJob-Execute0 = 1407,
		BeyondDynamicBone-VirtualMesh-BaseLine_CalcLocalPositionRotationJob-Execute0 = 1408,
		BeyondDynamicBone-VirtualMesh-BaseLine_CalcMaxBaseLineLengthJob-Execute0 = 1409,
		BeyondDynamicBone-VirtualMesh-Reduction_InitVertexToVertexJob2-Execute0 = 1410,
		BeyondDynamicBone-VirtualMesh-Organize_RemapVertexJob-Execute0 = 1411,
		BeyondDynamicBone-VirtualMesh-Organize_CollectUseSkinBoneJob-Execute0 = 1412,
		BeyondDynamicBone-VirtualMesh-Organize_CopyVertexJob-Execute0 = 1413,
		BeyondDynamicBone-VirtualMesh-Organize_RemapBoneWeightJob-Execute0 = 1414,
		BeyondDynamicBone-VirtualMesh-Organize_RemapLinkPointArrayJob-Execute0 = 1415,
		BeyondDynamicBone-VirtualMesh-Organize_CreateLineTriangleJob-Execute0 = 1416,
		BeyondDynamicBone-VirtualMesh-Organize_CreateLineTriangleJob2-Execute0 = 1417,
		BeyondDynamicBone-VirtualMesh-Organize_CreateNewTriangleJob3-Execute0 = 1418,
		BeyondDynamicBone-VirtualMesh-ShareSerializationData-ToString0 = 1419,
		BeyondDynamicBone-VirtualMesh-Work_AverageTriangleDistanceJob-Execute0 = 1420,
		BeyondDynamicBone-VirtualMesh-Work_AverageLineDistanceJob-Execute0 = 1421,
		BeyondDynamicBone-VirtualMesh-Work_AddVertexIndexGirdMapJob-Execute0 = 1422,
		BeyondDynamicBone-VirtualMesh-Work_IntersectTriangleJob-Execute0 = 1423,
		BeyondDynamicBone-VirtualMesh-Work_IntersectEdgeJob-Execute0 = 1424,
		BeyondDynamicBone-VirtualMesh-Work_IntersectPointJob-Execute0 = 1425,
		BeyondDynamicBone-VirtualMesh-Work_IntersetcSortJob-Execute0 = 1426,
		BeyondDynamicBone-VertexAttribute-Equals0 = 1427,
		BeyondDynamicBone-VertexAttribute-GetHashCode0 = 1428,
		BeyondDynamicBone-VirtualMeshBoneWeight-ToString0 = 1429,
		BeyondDynamicBone-VirtualMeshRaycastHit-CompareTo0 = 1430,
		BeyondDynamicBone-VirtualMeshRaycastHit-IsValid0 = 1431,
		BeyondDynamicBone-VirtualMeshRaycastHit-ToString0 = 1432,
		BeyondDynamicBone-VirtualMeshTransform-Clone0 = 1433,
		BeyondDynamicBone-VirtualMeshTransform-get_Origin0 = 1434,
		BeyondDynamicBone-VirtualMeshTransform-GetHashCode0 = 1435,
		BeyondDynamicBone-VirtualMeshTransform-Update0 = 1436,
		BeyondDynamicBone-VirtualMeshTransform-Transform0 = 1437
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 47994
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 47995
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}
