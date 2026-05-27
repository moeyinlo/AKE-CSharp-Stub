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

// Image 12: BeyondDynamicBone.dll - Assembly: BeyondDynamicBone, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 44678-45317
[assembly: AlwaysLinkAssembly]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateWithVelocityJob2Kernels.AggregateWithVelocityJob2RangeKernel_0000057F_BurstDirectCall))]
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
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.SimulationStepTeamUpdateKernels.SimulationStepTeamUpdateKernel_00000294_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.SimulationStepTeamUpdateKernels.SimulationStepTeamUpdateRangeKernel_00000295_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.SimulationStepTeamUpdateKernels.UpdateWind_00000296_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.SimulationStepTeamUpdateKernels.UpdateWindTime_00000297_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.PostTeamUpdateJobKernels.PostTeamUpdateKernel_00000298_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.PostTeamUpdateJobKernels.PostTeamUpdateRangeKernel_00000299_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.CalcCenterAndInertiaAndWindKernels.CalcCenterAndInertiaAndWindKernel_000002B9_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.CalcCenterAndInertiaAndWindKernels.CalcCenterAndInertiaAndWindRangeKernel_000002BA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(TeamManager.CalcCenterAndInertiaAndWindKernels.Wind_000002BB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcProxyMeshSkinningKernels.CalcProxyMeshSkinningKernel_000002E4_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcProxyMeshSkinningKernels.CalcProxyMeshSkinningRangeKernel_000002E5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CreatePostProxyMeshUpdateListJobKernels.CreatePostProxyMeshUpdateListKernel_000002E6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CreatePostProxyMeshUpdateListJobKernels.CreatePostProxyMeshUpdateListRangeKernel_000002E7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcLineNormalTangentJobKernels.CalcLineNormalTangentKernel_000002E8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcLineNormalTangentJobKernels.CalcLineNormalTangentRangeKernel_000002E9_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.WriteTransformDataJobKernels.WriteTransformDataKernel_000002EA_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.WriteTransformLocalDataJobKernels.WriteTransformLocalDataKernel_000002EC_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.WriteTransformLocalDataJobKernels.WriteTransformLocalDataRangeKernel_000002ED_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcProxySkinningJobKernels.CalcProxySkinningKernel_000002EE_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcProxySkinningJobKernels.CalcProxySkinningRangeKernel_000002EF_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcMeshConvertMatrixJobKernels.CalcMeshConvertMatrixKernel_000002F0_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcMeshConvertMatrixJobKernels.CalcMeshConvertMatrixRangeKernel_000002F1_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcTriangleNormalTangentJobKernels.CalcTriangleNormalTangentKernel_000002F2_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcTriangleNormalTangentJobKernels.CalcTriangleNormalTangentRangeKernel_000002F3_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcVertexNormalTangentFromTriangleJobKernels.CalcVertexNormalTangentFromTriangleKernel_000002F4_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.CalcVertexNormalTangentFromTriangleJobKernels.CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.WriteTransformDataJobKernels.WriteTransformDataRangeKernel_000002EB_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(VirtualMeshManager.ClearProxyMeshUpdateBufferJobKernels.ClearProxyMeshUpdateBufferKernel_000002F6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdatePositionNormalTangentJobKernels.UpdatePositionNormalTangentKernel_0000035B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdatePositionNormalTangentJobKernels.UpdatePositionNormalTangentRangeKernel_0000035C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdateBoneWeightJob2Kernels.UpdateBoneWeight2Kernel_0000035D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdateBoneWeightJob2Kernels.UpdateBoneWeight2RangeKernel_0000035E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(BeyondDynamicBone.EndSimulationStepJobKernels.EndSimulationStepKernel_000003B8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(BeyondDynamicBone.EndSimulationStepJobKernels.EndSimulationStepRangeKernel_000003B9_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.ColliderKernels.PreSimulationUpdateKernel_000003D1_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.ColliderKernels.PreSimulationUpdateRangeKernel_000003D2_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.CreateUpdatecolliderListJobKernels.CreateUpdatecolliderListKernel_000003D3_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.CreateUpdatecolliderListJobKernels.CreateUpdatecolliderListRangeKernel_000003D4_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdatePositionNormalJobKernels.UpdatePositionNormalRangeKernel_0000035A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.StartSimulationStepJobKernels.StartSimulationStepKernel_000003D5_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.StartSimulationStepJobKernels.StartSimulationStepRangeKernel_000003D6_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.EndSimulationStepJobKernels.EndSimulationStepKernel_0000040C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.CreateUpdateParticleListKernels.CreateUpdateParticleListKernel_00000401_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.CreateUpdateParticleListKernels.CreateUpdateParticleListRangeKernel_00000402_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.PreSimulationUpdateJobKernels.PreSimulationUpdateKernel_00000403_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.PreSimulationUpdateJobKernels.PreSimulationUpdateRangeKernel_00000404_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.StartSimulationStepKernel_00000405_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.StartSimulationStepRangeKernel_00000406_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.Spring_00000407_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.Wind_00000408_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.StartSimulationStepJobKernels.WindForceBlend_00000409_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.UpdateStepBasicPotureJobKernels.UpdateStepBasicPotureKernel_0000040A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.UpdateStepBasicPotureJobKernels.UpdateStepBasicPotureRangeKernel_0000040B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.PostSimulationUpdateJobKernels.PostSimulationUpdateKernel_000003D7_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(UpdatePositionNormalJobKernels.UpdatePositionNormalKernel_00000359_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.CalcDisplayPositionJobKernels.CalcDisplayPositionKernel_0000040E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.CalcDisplayPositionJobKernels.CalcDisplayPositionRangeKernel_0000040F_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.ClearStepCounterKernels.ClearStepCounterKernel_00000410_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateJobKernels.AggregateKernel_00000578_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateJobKernels.AggregateRangeKernel_00000579_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateWithVelocityJobKernels.AggregateWithVelocityKernel_0000057A_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateWithVelocityJobKernels.AggregateWithVelocityRangeKernel_0000057B_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateJob2Kernels.AggregateJob2Kernel_0000057C_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateJob2Kernels.AggregateJob2RangeKernel_0000057D_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(InterlockUtility.AggregateWithVelocityJob2Kernels.AggregateWithVelocityJob2Kernel_0000057E_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(ColliderManager.PostSimulationUpdateJobKernels.PostSimulationUpdateRangeKernel_000003D8_BurstDirectCall))]
[assembly: BurstCompiler.StaticTypeReinit(typeof(SimulationManager.EndSimulationStepJobKernels.EndSimulationStepRangeKernel_0000040D_BurstDirectCall))]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1994816753 // TypeDefIndex: 45312
{
	// Constructors
	public __JobReflectionRegistrationOutput__1994816753() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x0000000181007C20-0x00000001810104D0
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit() {} // 0x00000001810104D0-0x0000000181010580
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 45313
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize() {} // 0x00000001835EA770-0x00000001835EAE00
}

namespace BeyondDynamicBone
{
	public class BeyondBoneCloth : ClothBehaviour, IValid // TypeDefIndex: 44681
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
		public bool bUseRelativeTransform { get; private set; } // 0x0000000183D4F800-0x0000000183D4F810 0x0000000183D4F810-0x0000000183D4F820
		public ClothSerializeData SerializeData { get => default; set {} } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
		public ClothProcess Process { get => default; } // 0x00000001827B3FB0-0x00000001827B4040 
		public Transform ClothTransform { get => default; } // 0x0000000184273A88-0x0000000184273A90 
		public BeyondBoneCloth SyncPartnerCloth { get => default; } // 0x0000000182E27DA0-0x0000000182E27E70 
	
		// Constructors
		public BeyondBoneCloth() {} // 0x0000000183325D20-0x0000000183325E20
	
		// Methods
		internal void InitAnimationProperty() {} // 0x0000000183522640-0x00000001835227B0
		private void OnDidApplyAnimationProperties() {} // 0x000000018544B4B0-0x000000018544B790
		public void SetRelativeTransform(bool useRelativeTransform, float3 newPos, quaternion newRot) {} // 0x000000018544BE40-0x000000018544C0AC
		public bool IsValid() => default; // 0x000000018361D740-0x000000018361D7D0
		private void Reset() {} // 0x000000018544BC54-0x000000018544BC94
		private void OnValidate() {} // 0x000000018544B790-0x000000018544B7F0
		private void Awake() {} // 0x000000018375F680-0x000000018375F700
		private void OnEnable() {} // 0x00000001827AEFB0-0x00000001827AF000
		private void OnDisable() {} // 0x00000001827AE8B0-0x00000001827AE900
		private void Start() {} // 0x0000000182E196E0-0x0000000182E197E0
		private void OnDestroy() {} // 0x0000000182E202D0-0x0000000182E20320
		public override int GetMagicaHashCode() => default; // 0x000000018544B33C-0x000000018544B3F0
		public ClothSerializeData2 GetSerializeData2() => default; // 0x0000000182E27D70-0x0000000182E27DA0
		public void Initialize() {} // 0x00000001830C6820-0x00000001830C6880
		public void DisableAutoBuild() {} // 0x000000018544B170-0x000000018544B1E8
		public void SetClothSimulateWeight(float weight) {} // 0x0000000182B9F3C0-0x0000000182B9F500
		public void SetClothSimulateWeightIgnorePlaying(float weight) {} // 0x0000000183519C10-0x0000000183519CD0
		public void SetClothStablizationTimeAfterResetIgnorePlaying(float time) {} // 0x000000018544BD68-0x000000018544BDD4
		public void SetAnimationPoseRatio(float ratio) {} // 0x000000018544BC94-0x000000018544BD68
		private void SetCodeParamaterDirty() {} // 0x0000000182B9F500-0x0000000182B9F670
		private void SetCodeParamaterDirtyIgnorePlaying() {} // 0x0000000183519CD0-0x0000000183519DA0
		public bool BuildAndRun() => default; // 0x000000018544AC38-0x000000018544B170
		public void ReplaceTransform(Dictionary<string, Transform> targetTransformDict) {} // 0x000000018544B7F0-0x000000018544BB0C
		public void SetParameterChange() {} // 0x000000018544BDD4-0x000000018544BE40
		public void SetTimeScale(float timeScale) {} // 0x000000018544C12C-0x000000018544C200
		public float GetTimeScale() => default; // 0x000000018544B3F0-0x000000018544B4B0
		public void ResetCloth(bool keepPose = false /* Metadata: 0x01FB9018 */) {} // 0x000000018544BB0C-0x000000018544BC54
		public void SoftResetCloth(bool keepPose = false /* Metadata: 0x01FB9019 */) {} // 0x000000018361D6D0-0x000000018361D740
		public Vector3 GetCenterPosition() => default; // 0x000000018544B1E8-0x000000018544B33C
		public void AddForce(Vector3 forceDirection, float forceVelocity, ClothForceMode fmode = ClothForceMode.VelocityAdd /* Metadata: 0x01FB901A */) {} // 0x000000018544AA98-0x000000018544AC38
		public void SetSkipWriting(bool sw) {} // 0x000000018544C0AC-0x000000018544C12C
		public int __iFixBaseProxy_GetMagicaHashCode() => default; // 0x000000018544C200-0x000000018544C208
	}

	[Serializable]
	public class CheckSliderSerializeData // TypeDefIndex: 44682
	{
		// Fields
		public float value; // 0x10
		public bool use; // 0x14
	
		// Constructors
		public CheckSliderSerializeData() {} // 0x000000018350B670-0x000000018350B680
		public CheckSliderSerializeData(bool use, float value) {} // 0x0000000183D4F820-0x0000000183D4F830
	
		// Methods
		public float GetValue(float unusedValue) => default; // 0x0000000182E27170-0x0000000182E271C0
		public void SetValue(bool use, float value) {} // 0x000000018544C47C-0x000000018544C4F0
		public void DataValidate(float min, float max) {} // 0x000000018544C3F8-0x000000018544C47C
		public CheckSliderSerializeData Clone() => default; // 0x000000018544C370-0x000000018544C3F8
	}

	public abstract class ClothBehaviour : MonoBehaviour // TypeDefIndex: 44683
	{
		// Properties
		public bool IsGizmoVisible { get; set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
	
		// Constructors
		protected ClothBehaviour() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public virtual int GetMagicaHashCode() => default; // 0x000000018544C4F0-0x000000018544C53C
		protected virtual void OnDrawGizmos() {} // 0x000000018544C53C-0x000000018544C58C
	}

	public enum ClothForceMode // TypeDefIndex: 44684
	{
		None = 0,
		VelocityAdd = 1,
		VelocityChange = 2,
		VelocityAddWithoutDepth = 10,
		VelocityChangeWithoutDepth = 11
	}

	public enum ClothMeshWriteMode // TypeDefIndex: 44685
	{
		PositionAndNormal = 0,
		PositionAndNormalTangent = 1
	}

	public enum ClothNormalAxis // TypeDefIndex: 44686
	{
		Right = 0,
		Up = 1,
		Forward = 2,
		InverseRight = 3,
		InverseUp = 4,
		InverseForward = 5
	}

	public struct ClothParameters // TypeDefIndex: 44687
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

	public class ClothProcess : IDisposable, IValid, ITransform // TypeDefIndex: 44698
	{
		// Fields
		private static readonly ProfilerMarker initProfiler; // 0x00
		private static readonly ProfilerMarker preBuildProfiler; // 0x08
		private static readonly ProfilerMarker preBuildDeserializationProfiler; // 0x10
		private static readonly ProfilerMarker preBuildRegistrationProfiler; // 0x18
		public const int State_Valid = 0; // Metadata: 0x01FB9028
		public const int State_Enable = 1; // Metadata: 0x01FB9029
		public const int State_InitSuccess = 3; // Metadata: 0x01FB902A
		public const int State_InitComplete = 4; // Metadata: 0x01FB902B
		public const int State_Build = 5; // Metadata: 0x01FB902C
		public const int State_Running = 6; // Metadata: 0x01FB902D
		public const int State_DisableAutoBuild = 7; // Metadata: 0x01FB902E
		public const int State_CameraCullingInvisible = 8; // Metadata: 0x01FB902F
		public const int State_CameraCullingKeep = 9; // Metadata: 0x01FB9030
		public const int State_SkipWriting = 10; // Metadata: 0x01FB9031
		public const int State_UsePreBuild = 12; // Metadata: 0x01FB9032
		public const int State_DistanceCullingInvisible = 13; // Metadata: 0x01FB9033
		public const int State_UpdateTangent = 14; // Metadata: 0x01FB9034
		public const int State_Component = 15; // Metadata: 0x01FB9035
		public const int State_Verification = 16; // Metadata: 0x01FB9036
		public const int State_LOD_Culled = 25; // Metadata: 0x01FB9037
		internal BitField32 stateFlag; // 0x20
		private List<int> renderHandleList; // 0x30
		internal RenderSetupData boneClothSetupData; // 0x38
		internal List<RenderMeshInfo> renderMeshInfoList; // 0x40
		internal List<TransformRecord> customSkinningBoneRecords; // 0x48
		internal ResultCode result; // 0x58
		private ReductionSettings reductionSettings; // 0x68
		internal List<ColliderComponent> colliderList; // 0x3A0
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
		public BeyondBoneCloth cloth { get; internal set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public BeyondBoneCloth SyncTopCloth { get; internal set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		internal TransformRecord clothTransformRecord { get; private set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		internal TransformRecord normalAdjustmentTransformRecord { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public ResultCode Result { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		internal ClothType clothType { get; private set; } // 0x0000000183D4F050-0x0000000183D4F060 0x0000000183D4F5A0-0x0000000183D4F5B0
		public ClothParameters parameters { get; private set; } // 0x0000000183D4F850-0x0000000183D4F8E0 0x0000000183D4F8F0-0x0000000183D4F970
		public VirtualMeshContainer ProxyMeshContainer { get; private set; } // 0x0000000183D4F830-0x0000000183D4F840 0x000000018544EF54-0x000000018544EF68
		internal int ColliderCapacity { get => default; } // 0x0000000183210000-0x0000000183210050 
		public int TeamId { get; private set; } // 0x0000000183D4F840-0x0000000183D4F850 0x0000000183D4F8E0-0x0000000183D4F8F0
		public bool IsEnable { get => default; } // 0x00000001827B1CE0-0x00000001827B25E0 
		public bool HasProxyMesh { get => default; } // 0x000000018544EDE0-0x000000018544EEA4 
		public string Name { get => default; } // 0x000000018544EEA4-0x000000018544EF54 
	
		// Nested types
		[BurstCompile]
		private struct GenerateSelectionJob : IJobParallelFor // TypeDefIndex: 44688
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
			public void Execute(int vindex) {} // 0x0000000185450A04-0x0000000185450C1C
		}
	
		public class RenderMeshInfo // TypeDefIndex: 44689
		{
			// Fields
			public int renderHandle; // 0x10
			public VirtualMeshContainer renderMeshContainer; // 0x18
			public DataChunk mappingChunk; // 0x20
	
			// Constructors
			public RenderMeshInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public class PaintMapData // TypeDefIndex: 44690
		{
			// Fields
			public const byte ReadFlag_Fixed = 1; // Metadata: 0x01FB9038
			public const byte ReadFlag_Move = 2; // Metadata: 0x01FB9039
			public const byte ReadFlag_Limit = 4; // Metadata: 0x01FB903A
			public Color32[] paintData; // 0x10
			public int paintMapWidth; // 0x18
			public int paintMapHeight; // 0x1C
			public ExBitFlag8 paintReadFlag; // 0x20
	
			// Constructors
			public PaintMapData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		public enum ClothType // TypeDefIndex: 44691
		{
			MeshCloth = 0,
			BoneCloth = 1,
			BoneSpring = 10
		}
	
		// Constructors
		public ClothProcess() {} // 0x0000000183325FE0-0x00000001833262E0
		static ClothProcess() {} // 0x0000000183B40670-0x0000000183B40790
	
		// Methods
		internal void Init() {} // 0x0000000182E27320-0x0000000182E27A30
		private int AddRenderer(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referenceUniqueSetupData) => default; // 0x000000018544C58C-0x000000018544C7F8
		private void CreateBoneRenderSetupData(ClothType ctype, List<Transform> rootTransforms, List<Transform> ignoreFromRootBones, List<Transform> collisionBones, RenderSetupData.BoneConnectionMode connectionMode) {} // 0x0000000182E1D260-0x0000000182E1D380
		internal void StartUse() {} // 0x00000001827AF000-0x00000001827AF090
		internal void EndUse() {} // 0x00000001827AE900-0x00000001827AE990
		internal void UpdateUse() {} // 0x00000001827AEA30-0x00000001827AECF0
		internal void DataUpdate() {} // 0x000000018544C7F8-0x000000018544C8E0
		internal bool StartRuntimeBuild() => default; // 0x0000000182E19910-0x0000000182E19A40
		internal bool AutoBuild() => default; // 0x0000000182E19870-0x0000000182E19910
		private async System.Threading.Tasks.Task RuntimeBuildAsync(CancellationToken ct) => default; // 0x0000000182E19A70-0x0000000182E19B90
		public ResultCode GenerateSelectionDataFromPaintMap(TransformRecord clothTransformRecord, VirtualMesh renderMesh, PaintMapData paintMapData, out SelectionData selectionData) {
			selectionData = default;
			return default;
		} // 0x000000018544D4F0-0x000000018544DD78
		public ResultCode GeneratePaintMapDataList(List<PaintMapData> dataList) => default; // 0x000000018544D0A4-0x000000018544D4F0
		public ResultCode GenerateSelectionDataFromVertexAttributeData(TransformRecord clothTransformRecord, VirtualMesh renderMesh, VertexAttribute[] vertexAttributeArray, out SelectionData selectionData) {
			selectionData = default;
			return default;
		} // 0x000000018544DD78-0x000000018544E2A4
		internal bool PreBuildDataConstruction() => default; // 0x0000000182E1A440-0x0000000182E1BE70
		internal int GetColliderIndex(ColliderComponent col) => default; // 0x000000018320FF90-0x0000000183210000
		internal void UpdateCullingAnimatorAndRenderers() {} // 0x0000000182FB3570-0x0000000182FB36C0
		internal void UpdateRendererUse() {} // 0x00000001838C16B0-0x00000001838C1810
		public BitField32 GetStateFlag() => default; // 0x000000018544E4C8-0x000000018544E514
		public bool IsState(int state) => default; // 0x00000001827B28E0-0x00000001827B29B0
		public void SetState(int state, bool sw) {} // 0x00000001827B0EC0-0x00000001827B0FB0
		public bool IsValid() => default; // 0x00000001827B25E0-0x00000001827B2740
		public bool IsRunning() => default; // 0x00000001827B0FB0-0x00000001827B1110
		public bool IsCameraCullingInvisible() => default; // 0x000000018544E904-0x000000018544E958
		public bool IsLodCulled() => default; // 0x000000018544EA00-0x000000018544EA58
		public bool IsCameraCullingKeep() => default; // 0x000000018544E958-0x000000018544E9AC
		public bool IsDistanceCullingInvisible() => default; // 0x000000018544E9AC-0x000000018544EA00
		public bool IsSkipWriting() => default; // 0x000000018544EA58-0x000000018544EAB0
		public bool IsUpdateTangent() => default; // 0x000000018544EAB0-0x000000018544EB08
		public void Dispose() {} // 0x0000000182E1FFC0-0x0000000182E202D0
		private void DisposeInternal() {} // 0x0000000182A902E0-0x0000000182A93340
		internal void IncrementSuspendCounter() {} // 0x000000018544E7F0-0x000000018544E904
		internal void DecrementSuspendCounter() {} // 0x000000018544C8E0-0x000000018544C9E8
		internal int GetSuspendCounter() => default; // 0x000000018544E514-0x000000018544E5DC
		public RenderMeshInfo GetRenderMeshInfo(int index) => default; // 0x000000018544E424-0x000000018544E4C8
		internal void SyncParameters() {} // 0x0000000182E24C40-0x0000000182E24D90
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018544E5DC-0x000000018544E7F0
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x000000018544EB08-0x000000018544ED1C
		internal void SetSkipWriting(bool sw) {} // 0x000000018544ED1C-0x000000018544EDE0
		internal ClothUpdateMode GetClothUpdateMode() => default; // 0x000000018544E2A4-0x000000018544E424
		public ResultCode GenerateStatusCheck() => default; // 0x0000000182E271C0-0x0000000182E27320
		internal bool GenerateInitialization() => default; // 0x000000018544CF68-0x000000018544D0A4
		internal bool GenerateBoneClothSelection() => default; // 0x000000018544C9E8-0x000000018544CF68
	}

	[Serializable]
	public class ClothSerializeData : IDataValidate, IValid, ITransform // TypeDefIndex: 44703
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
		[Range(0f, 1f)]
		public float animationPoseRatio; // 0x60
		public ReductionSettings reductionSetting; // 0x68
		public CustomSkinningSettings customSkinningSetting; // 0x70
		public NormalAlignmentSettings normalAlignmentSetting; // 0x78
		public CullingSettings cullingSettings; // 0x80
		public ClothNormalAxis normalAxis; // 0x88
		[Range(0f, 10f)]
		public float gravity; // 0x8C
		public float3 gravityDirection; // 0x90
		[Range(0f, 1f)]
		public float gravityFalloff; // 0x9C
		[Range(0f, 1f)]
		public float stablizationTimeAfterReset; // 0xA0
		[Range(0f, 1f)]
		public float blendWeight; // 0xA4
		public CurveSerializeData damping; // 0xA8
		public CurveSerializeData radius; // 0xB0
		public InertiaConstraint.SerializeData inertiaConstraint; // 0xB8
		public TetherConstraint.SerializeData tetherConstraint; // 0xC0
		public DistanceConstraint.SerializeData distanceConstraint; // 0xC8
		public TriangleBendingConstraint.SerializeData triangleBendingConstraint; // 0xD0
		public AngleConstraint.RestorationSerializeData angleRestorationConstraint; // 0xD8
		public AngleConstraint.LimitSerializeData angleLimitConstraint; // 0xE0
		public MotionConstraint.SerializeData motionConstraint; // 0xE8
		public ColliderCollisionConstraint.SerializeData colliderCollisionConstraint; // 0xF0
		public SelfCollisionConstraint.SerializeData selfCollisionConstraint; // 0xF8
		public WindSettings wind; // 0x100
		public SpringConstraint.SerializeData springConstraint; // 0x108
		private ResultCode verificationResult; // 0x110
	
		// Properties
		public Define.Result VerificationResult { get => default; } // 0x0000000183D4F980-0x0000000183D4F990 
	
		// Nested types
		public enum PaintMode // TypeDefIndex: 44699
		{
			Manual = 0,
			Texture_Fixed_Move = 1,
			Texture_Fixed_Move_Limit = 2
		}
	
		public enum AnimatorAbilityLevel // TypeDefIndex: 44700
		{
			OnlyPlayerOrBoss = 0,
			AICharOrElite = 1,
			DefaultOrAtmosphere = 2
		}
	
		private class TempBuffer // TypeDefIndex: 44701
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
			private ReductionSettings reductionSetting; // 0x68
			private CustomSkinningSettings customSkinningSetting; // 0x70
			private NormalAlignmentSettings normalAlignmentSetting; // 0x78
			private ClothNormalAxis normalAxis; // 0x80
			private List<ColliderComponent> colliderList; // 0x88
			private List<Transform> collisionBones; // 0x90
			private BeyondBoneCloth synchronization; // 0x98
			private float stablizationTimeAfterReset; // 0xA0
			private float blendWeight; // 0xA4
			private CullingSettings cullingSetting; // 0xA8
			private Transform anchor; // 0xB0
			private float anchorInertia; // 0xB8
	
			// Constructors
			public TempBuffer() {} // Dummy constructor
			internal TempBuffer(ClothSerializeData sdata) {} // 0x0000000185451214-0x000000018545121C
	
			// Methods
			internal void Push(ClothSerializeData sdata) {} // 0x0000000185450E44-0x0000000185451214
			internal void Pop(ClothSerializeData sdata) {} // 0x0000000185450C1C-0x0000000185450E44
		}
	
		// Constructors
		public ClothSerializeData() {} // 0x000000018283B7E0-0x000000018283BDF0
	
		// Methods
		public bool IsValid() => default; // 0x00000001835DA6B0-0x00000001835DA8A0
		public void DataValidate() {} // 0x000000018544F118-0x000000018544F410
		public override int GetHashCode() => default; // 0x000000018544F460-0x000000018544FAA8
		public ClothParameters GetClothParameters() => default; // 0x0000000182E254C0-0x0000000182E257D0
		public string ExportJson() => default; // 0x000000018544F410-0x000000018544F460
		public bool ImportJson(string json) => default; // 0x000000018544FCB0-0x000000018544FE14
		[IDTag(0)]
		public void Import(ClothSerializeData sdata, bool deepCopy = false /* Metadata: 0x01FB903E */) {} // 0x000000018544FE98-0x00000001854503E4
		[IDTag(1)]
		public void Import(BeyondBoneCloth src, bool deepCopy = false /* Metadata: 0x01FB903F */) {} // 0x000000018544FE14-0x000000018544FE98
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018544FAA8-0x000000018544FCB0
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001854503E4-0x00000001854505A8
		public bool IsBoneSpring() => default; // 0x0000000182E27EB0-0x0000000182E27EE0
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
	}

	[Serializable]
	public class ClothSerializeData2 : IDataValidate, IValid, ITransform // TypeDefIndex: 44704
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
		public ClothSerializeData2() {} // 0x0000000183325EC0-0x0000000183325FE0
	
		// Methods
		public bool IsValid() => default; // 0x000000018544F060-0x000000018544F0AC
		public void DataValidate() {} // 0x000000018544EF68-0x000000018544EFA8
		public override int GetHashCode() => default; // 0x000000018544EFA8-0x000000018544EFF4
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018544EFF4-0x000000018544F060
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x000000018544F0AC-0x000000018544F118
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
	}

	public enum ClothUpdateMode // TypeDefIndex: 44705
	{
		Normal = 0,
		UnityPhysics = 1,
		Unscaled = 2,
		AnimatorLinkage = 10
	}

	public class BeyondBoneCapsuleCollider : ColliderComponent // TypeDefIndex: 44707
	{
		// Fields
		public Direction direction; // 0x40
		public bool reverseDirection; // 0x44
		public bool radiusSeparation; // 0x45
		public bool alignedOnCenter; // 0x46
	
		// Nested types
		public enum Direction // TypeDefIndex: 44706
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public BeyondBoneCapsuleCollider() {} // 0x0000000183325E20-0x0000000183325E30
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType() => default; // 0x000000018364CC10-0x000000018364CC70
		public void SetSize(float startRadius, float endRadius, float length) {} // 0x000000018544A9A4-0x000000018544AA60
		public override Vector3 GetSize() => default; // 0x00000001835F6020-0x00000001835F6090
		public Vector3 GetLocalDir() => default; // 0x000000018544A848-0x000000018544A91C
		public Vector3 GetLocalUp() => default; // 0x000000018544A91C-0x000000018544A9A4
		public override bool IsReverseDirection() => default; // 0x00000001836CE460-0x00000001836CE490
		public override void DataValidate() {} // 0x000000018544A7CC-0x000000018544A848
		public Vector3 __iFixBaseProxy_GetSize() => default; // 0x000000018544AA60-0x000000018544AA90
		public bool __iFixBaseProxy_IsReverseDirection() => default; // 0x000000018544AA90-0x000000018544AA98
	}

	public class BeyondBonePlaneCollider : ColliderComponent // TypeDefIndex: 44708
	{
		// Constructors
		public BeyondBonePlaneCollider() {} // 0x0000000183325D10-0x0000000183325D20
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType() => default; // 0x000000018544C24C-0x000000018544C298
		public override void DataValidate() {} // 0x000000018544C208-0x000000018544C24C
	}

	public class BeyondBoneSphereCollider : ColliderComponent // TypeDefIndex: 44709
	{
		// Constructors
		public BeyondBoneSphereCollider() {} // 0x0000000183325D10-0x0000000183325D20
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType() => default; // 0x0000000183CB5B60-0x0000000183CB5B90
		public override void DataValidate() {} // 0x000000018544C298-0x000000018544C2F4
		public void SetSize(float radius) {} // 0x000000018544C2F4-0x000000018544C370
	}

	public abstract class ColliderComponent : ClothBehaviour, IDataValidate // TypeDefIndex: 44710
	{
		// Fields
		public Vector3 center; // 0x20
		[SerializeField]
		protected Vector3 size; // 0x2C
		private HashSet<int> teamIdSet; // 0x38
	
		// Constructors
		protected ColliderComponent() {} // 0x0000000183325E30-0x0000000183325EC0
	
		// Methods
		public abstract ColliderManager.ColliderType GetColliderType();
		public abstract void DataValidate();
		public virtual Vector3 GetSize() => default; // 0x0000000183B5CB70-0x0000000183B5CBC0
		public void SetSize(Vector3 size) {} // 0x0000000185450800-0x0000000185450878
		public void SetSizeX(float size) {} // 0x00000001854506EC-0x0000000185450748
		public void SetSizeY(float size) {} // 0x0000000185450748-0x00000001854507A4
		public void SetSizeZ(float size) {} // 0x00000001854507A4-0x0000000185450800
		public virtual float GetScale() => default; // 0x0000000185450630-0x000000018545069C
		public virtual bool IsReverseDirection() => default; // 0x0000000183CDDFC0-0x0000000183CDDFF0
		internal void Register(int teamId) {} // 0x00000001835D52C0-0x00000001835D5330
		internal void Exit(int teamId) {} // 0x00000001854505A8-0x0000000185450630
		public void UpdateParameters() {} // 0x0000000185450878-0x0000000185450A04
		protected virtual void Start() {} // 0x0000000183795C80-0x0000000183795CB0
		protected virtual void OnValidate() {} // 0x000000018545069C-0x00000001854506EC
		protected virtual void OnEnable() {} // 0x00000001834F3C20-0x00000001834F3E70
		protected virtual void OnDisable() {} // 0x000000018320E5A0-0x000000018320E7F0
		protected virtual void OnDestroy() {} // 0x000000018320E2E0-0x000000018320E5A0
	}

	[BurstCompile]
	internal static class AngleConstraintJobKernels // TypeDefIndex: 44715
	{
		// Nested types
		public unsafe delegate void AngleConstraintKernel_000000C4_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // TypeDefIndex: 44711; 0x0000000185459340-0x0000000185459444
	
		internal static class AngleConstraintKernel_000000C4_BurstDirectCall // TypeDefIndex: 44712
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static AngleConstraintKernel_000000C4_BurstDirectCall() {} // 0x0000000183CECC30-0x0000000183CECC40
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0005f1cf) {} // 0x0000000185458DFC-0x0000000185458F00
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185458F00-0x0000000185458F54
			public static void Constructor() {} // 0x0000000183CECC40-0x0000000183CECCD0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index) {} // 0x0000000185458F54-0x00000001854591F4
		}
	
		public unsafe delegate void AngleConstraintRangeKernel_000000C5_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // TypeDefIndex: 44713; 0x00000001854599FC-0x0000000185459B00
	
		internal static class AngleConstraintRangeKernel_000000C5_BurstDirectCall // TypeDefIndex: 44714
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static AngleConstraintRangeKernel_000000C5_BurstDirectCall() {} // 0x0000000183CECB90-0x0000000183CECBA0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0005f214) {} // 0x0000000185459518-0x000000018545961C
			private static IntPtr GetFunctionPointer() => default; // 0x000000018545961C-0x0000000185459670
			public static void Constructor() {} // 0x0000000183CECBA0-0x0000000183CECC30
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr) {} // 0x0000000185459670-0x000000018545990C
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void AngleConstraintKernel(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index) {} // 0x000000018544A384-0x000000018544A4EC
		[BurstCompile]
		internal static unsafe void AngleConstraintRangeKernel(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr) {} // 0x000000018544A660-0x000000018544A7CC
		[BurstCompile]
		public static unsafe void AngleConstraintKernel_BurstManaged(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index) {} // 0x0000000185448D00-0x000000018544A384
		[BurstCompile]
		public static unsafe void AngleConstraintRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr) {} // 0x000000018544A4EC-0x000000018544A660
	}

	public class AngleConstraint : IDisposable // TypeDefIndex: 44720
	{
		// Fields
		private NativeArray<float> lengthBuffer; // 0x10
		private NativeArray<float3> localPosBuffer; // 0x20
		private NativeArray<quaternion> localRotBuffer; // 0x30
		private NativeArray<quaternion> rotationBuffer; // 0x40
		private NativeArray<float3> restorationVectorBuffer; // 0x50
	
		// Nested types
		[Serializable]
		public class RestorationSerializeData : IDataValidate // TypeDefIndex: 44716
		{
			// Fields
			public bool useAngleRestoration; // 0x10
			public CurveSerializeData stiffness; // 0x18
			[Range(0f, 1f)]
			public float velocityAttenuation; // 0x20
			[Range(0f, 1f)]
			public float gravityFalloff; // 0x24
	
			// Constructors
			public RestorationSerializeData() {} // 0x000000018283A7E0-0x000000018283A880
	
			// Methods
			public void DataValidate() {} // 0x0000000185465FE0-0x0000000185466060
			public RestorationSerializeData Clone() => default; // 0x0000000185465F1C-0x0000000185465FE0
		}
	
		[Serializable]
		public class LimitSerializeData : IDataValidate // TypeDefIndex: 44717
		{
			// Fields
			public bool useAngleLimit; // 0x10
			public CurveSerializeData limitAngle; // 0x18
			[Range(0f, 1f)]
			public float stiffness; // 0x20
	
			// Constructors
			public LimitSerializeData() {} // 0x000000018283A740-0x000000018283A7E0
	
			// Methods
			public void DataValidate() {} // 0x00000001854619A0-0x0000000185461A10
			public LimitSerializeData Clone() => default; // 0x00000001854618E8-0x00000001854619A0
		}
	
		public struct AngleConstraintParams // TypeDefIndex: 44718
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
			public void Convert(RestorationSerializeData restorationData, LimitSerializeData limitData) {} // 0x0000000182E258D0-0x0000000182E25A00
		}
	
		[BurstCompile]
		private struct AngleConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44719
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182EE6C90-0x0000000182EE6D30
			[IDTag(1)]
			public void Execute() {} // 0x00000001854572E0-0x0000000185457378
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185457378-0x0000000185458B74
			public void UnsafeDo() {} // 0x0000000185458B74-0x0000000185458DFC
		}
	
		// Constructors
		public AngleConstraint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x0000000185459BD4-0x0000000185459CA0
		internal void WorkBufferUpdate() {} // 0x0000000182C4CE00-0x0000000182C4CF90
		public override string ToString() => default; // 0x0000000185459CA0-0x0000000185459F38
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x0000000182DC4710-0x0000000182DC4D40
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public class ColliderCollisionConstraint : IDisposable // TypeDefIndex: 44742
	{
		// Fields
		private NativeArray<int> tempFrictionArray; // 0x10
		private NativeArray<int> tempNormalArray; // 0x20
	
		// Nested types
		[BurstCompile]
		private static class PointColliderCollisionConstraintJobKernels // TypeDefIndex: 44725
		{
			// Nested types
			public unsafe delegate void PointColliderCollisionConstraintKernel_000000DB_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // TypeDefIndex: 44721; 0x0000000185465864-0x000000018546590C
	
			internal static class PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall // TypeDefIndex: 44722
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall() {} // 0x0000000183CEB010-0x0000000183CEB020
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f29a) {} // 0x0000000185465448-0x000000018546554C
				private static IntPtr GetFunctionPointer() => default; // 0x000000018546554C-0x00000001854655A0
				public static void Constructor() {} // 0x0000000183CEB020-0x0000000183CEB0B0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index) {} // 0x00000001854655A0-0x000000018546576C
			}
	
			public unsafe delegate void PointColliderCollisionConstraintRangeKernel_000000DC_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // TypeDefIndex: 44723; 0x0000000185465D9C-0x0000000185465E48
	
			internal static class PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall // TypeDefIndex: 44724
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall() {} // 0x0000000183CEAF70-0x0000000183CEAF80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f2ca) {} // 0x00000001854659E0-0x0000000185465AE4
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185465AE4-0x0000000185465B38
				public static void Constructor() {} // 0x0000000183CEAF80-0x0000000183CEB010
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr) {} // 0x0000000185465B38-0x0000000185465D00
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PointColliderCollisionConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index) {} // 0x0000000185463630-0x000000018546372C
			[BurstCompile]
			internal static unsafe void PointColliderCollisionConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr) {} // 0x000000018546372C-0x000000018546382C
			private static double PointSphereColliderDetection(ref double3 nextpos, [IsReadOnly] in double3 basePos, float radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, bool isSpring, float maxLength, out float3 normal) {
				normal = default;
				return default;
			} // 0x00000001854639A0-0x0000000185463D24
			private static double PointPlaneColliderDetction(ref double3 nextpos, float radius, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x000000018546382C-0x00000001854639A0
			private static double PointCapsuleColliderDetection(ref double3 nextpos, float radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x00000001854625E4-0x0000000185462988
			[BurstCompile]
			public static unsafe void PointColliderCollisionConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index) {} // 0x0000000185462988-0x0000000185463630
			[BurstCompile]
			public static unsafe void PointColliderCollisionConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr) {} // 0x0000000185456A9C-0x0000000185456B98
		}
	
		[BurstCompile]
		private static class EdgeColliderCollisionConstraintJobKernels // TypeDefIndex: 44730
		{
			// Nested types
			public unsafe delegate void EdgeColliderCollisionConstraintKernel_000000E0_PostfixBurstDelegate(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // TypeDefIndex: 44726; 0x0000000185460FA0-0x000000018546107C
	
			internal static class EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall // TypeDefIndex: 44727
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall() {} // 0x0000000183CEB970-0x0000000183CEB980
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f35a) {} // 0x0000000185460AE0-0x0000000185460BE4
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185460BE4-0x0000000185460C38
				public static void Constructor() {} // 0x0000000183CEB980-0x0000000183CEBA10
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000185460C38-0x0000000185460E78
			}
	
			public unsafe delegate void EdgeColliderCollisionConstraintRangeKernel_000000E1_PostfixBurstDelegate(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // TypeDefIndex: 44728; 0x00000001854615B0-0x000000018546168C
	
			internal static class EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall // TypeDefIndex: 44729
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall() {} // 0x0000000183CEB8D0-0x0000000183CEB8E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f396) {} // 0x0000000185461150-0x0000000185461254
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185461254-0x00000001854612A8
				public static void Constructor() {} // 0x0000000183CEB8E0-0x0000000183CEB970
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x00000001854612A8-0x00000001854614E4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void EdgeColliderCollisionConstraintKernel(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x000000018545DF80-0x000000018545E0B8
			[BurstCompile]
			internal static unsafe void EdgeColliderCollisionConstraintRangeKernel(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x000000018545E0B8-0x000000018545E1F4
			private static float EdgeSphereColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, double cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x000000018545E3DC-0x000000018545E984
			private static double EdgeCapsuleColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, double cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x000000018545C9E4-0x000000018545D270
			private static double EdgePlaneColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x000000018545E1F4-0x000000018545E3DC
			[BurstCompile]
			public static unsafe void EdgeColliderCollisionConstraintKernel_BurstManaged(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x000000018545D270-0x000000018545DF80
			[BurstCompile]
			public static unsafe void EdgeColliderCollisionConstraintRangeKernel_BurstManaged(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x0000000185454A6C-0x0000000185454BA4
		}
	
		[BurstCompile]
		private static class SolveEdgeBufferAndClearJobKernels // TypeDefIndex: 44735
		{
			// Nested types
			public unsafe delegate void SolveEdgeBufferAndClearKernel_000000E5_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // TypeDefIndex: 44731; 0x00000001854674CC-0x0000000185467540
	
			internal static class SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall // TypeDefIndex: 44732
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall() {} // 0x0000000183CEA610-0x0000000183CEA620
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f3ea) {} // 0x0000000185467168-0x000000018546726C
				private static IntPtr GetFunctionPointer() => default; // 0x000000018546726C-0x00000001854672C0
				public static void Constructor() {} // 0x0000000183CEA620-0x0000000183CEA6B0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x00000001854672C0-0x00000001854673FC
			}
	
			public unsafe delegate void SolveEdgeBufferAndClearRangeKernel_000000E6_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // TypeDefIndex: 44733; 0x000000018546794C-0x00000001854679C0
	
			internal static class SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall // TypeDefIndex: 44734
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall() {} // 0x0000000183CEA570-0x0000000183CEA580
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f40e) {} // 0x0000000185467614-0x0000000185467718
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185467718-0x000000018546776C
				public static void Constructor() {} // 0x0000000183CEA580-0x0000000183CEA610
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x000000018546776C-0x00000001854678DC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolveEdgeBufferAndClearKernel(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000185466B04-0x0000000185466BC8
			[BurstCompile]
			internal static unsafe void SolveEdgeBufferAndClearRangeKernel(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x0000000185466C88-0x0000000185466D4C
			[BurstCompile]
			public static unsafe void SolveEdgeBufferAndClearKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000185456B98-0x00000001854572E0
			[BurstCompile]
			public static unsafe void SolveEdgeBufferAndClearRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x0000000185466BC8-0x0000000185466C88
		}
	
		public enum Mode // TypeDefIndex: 44736
		{
			None = 0,
			Point = 1,
			Edge = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate, ITransform // TypeDefIndex: 44737
		{
			// Fields
			public Mode mode; // 0x10
			[Range(0f, 0.5f)]
			public float friction; // 0x14
			public List<ColliderComponent> colliderList; // 0x18
			public List<Transform> collisionBones; // 0x20
			public CurveSerializeData limitDistance; // 0x28
	
			// Properties
			public int ColliderLength { get => default; } // 0x0000000182701870-0x00000001827018B0 
	
			// Constructors
			public SerializeData() {} // 0x000000018283A910-0x000000018283AA30
	
			// Methods
			public void DataValidate() {} // 0x00000001854665C0-0x0000000185466644
			public SerializeData Clone() => default; // 0x00000001854662A4-0x00000001854663FC
			public override int GetHashCode() => default; // 0x0000000185466644-0x00000001854667E0
			public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x00000001854667E0-0x0000000185466988
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x0000000185466988-0x0000000185466B04
			public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
		}
	
		public struct ColliderCollisionConstraintParams // TypeDefIndex: 44738
		{
			// Fields
			public Mode mode; // 0x00
			public float dynamicFriction; // 0x04
			public float staticFriction; // 0x08
			public float4x4 limitDistance; // 0x0C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000182E26F10-0x0000000182E26F80
		}
	
		[BurstCompile]
		private struct PointColliderCollisionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44739
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182EE7240-0x0000000182EE72E0
			[IDTag(1)]
			public void Execute() {} // 0x0000000185463D24-0x0000000185463DBC
			public void UnsafeDo() {} // 0x000000018546526C-0x0000000185465448
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185463DBC-0x0000000185464AB0
			private double PointSphereColliderDetection(ref double3 nextpos, [IsReadOnly] in double3 basePos, double radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, bool isSpring, double maxLength, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000185464F1C-0x000000018546526C
			private double PointPlaneColliderDetction(ref double3 nextpos, double radius, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000185464DD4-0x0000000185464F1C
			private double PointCapsuleColliderDetection(ref double3 nextpos, double radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000185464AB0-0x0000000185464DD4
		}
	
		[BurstCompile]
		private struct EdgeColliderCollisionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44740
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185460820-0x000000018546088C
			[IDTag(1)]
			public void Execute() {} // 0x000000018545F990-0x000000018545FA28
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018545FA28-0x0000000185460820
			private double EdgeSphereColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, float cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x000000018545F400-0x000000018545F990
			private double EdgeCapsuleColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, float cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x000000018545E984-0x000000018545F200
			private double EdgePlaneColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x000000018545F200-0x000000018545F400
			public void UnsafeDo() {} // 0x000000018546088C-0x0000000185460AE0
		}
	
		[BurstCompile]
		private struct SolveEdgeBufferAndClearJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44741
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185466FD4-0x0000000185467040
			[IDTag(1)]
			public void Execute() {} // 0x0000000185466D4C-0x0000000185466DE4
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185466DE4-0x0000000185466FD4
			public void UnsafeDo() {} // 0x0000000185467040-0x0000000185467168
		}
	
		// Constructors
		public ColliderCollisionConstraint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x0000000185459F40-0x0000000185459FC4
		internal void WorkBufferUpdate() {} // 0x0000000182C4CFF0-0x0000000182C4D070
		public override string ToString() => default; // 0x0000000185459FC4-0x000000018545A14C
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x0000000182DCFB00-0x0000000182DD0140
		public static void Initialize_PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall() {} // 0x00000001835EC660-0x00000001835EC6C0
		public static void Initialize_PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall() {} // 0x00000001835EC600-0x00000001835EC660
		public static void Initialize_EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall() {} // 0x00000001835EC5A0-0x00000001835EC600
		public static void Initialize_EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall() {} // 0x00000001835EC540-0x00000001835EC5A0
		public static void Initialize_SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall() {} // 0x00000001835EC4E0-0x00000001835EC540
		public static void Initialize_SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall() {} // 0x00000001835EC480-0x00000001835EC4E0
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	[BurstCompile]
	internal static class DistanceConstraintJobKernels // TypeDefIndex: 44747
	{
		// Nested types
		public unsafe delegate void DistanceConstraintKernel_00000101_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // TypeDefIndex: 44743; 0x000000018545C050-0x000000018545C104
	
		internal static class DistanceConstraintKernel_00000101_BurstDirectCall // TypeDefIndex: 44744
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static DistanceConstraintKernel_00000101_BurstDirectCall() {} // 0x0000000183CEBAB0-0x0000000183CEBAC0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0005f4a3) {} // 0x000000018545BC10-0x000000018545BD14
			private static IntPtr GetFunctionPointer() => default; // 0x000000018545BD14-0x000000018545BD68
			public static void Constructor() {} // 0x0000000183CEBAC0-0x0000000183CEBB50
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index) {} // 0x000000018545BD68-0x000000018545BF4C
		}
	
		public unsafe delegate void DistanceConstraintRangeKernel_00000102_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // TypeDefIndex: 44745; 0x000000018545C5BC-0x000000018545C674
	
		internal static class DistanceConstraintRangeKernel_00000102_BurstDirectCall // TypeDefIndex: 44746
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static DistanceConstraintRangeKernel_00000102_BurstDirectCall() {} // 0x0000000183CEBA10-0x0000000183CEBA20
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0005f4d6) {} // 0x000000018545C1D8-0x000000018545C2DC
			private static IntPtr GetFunctionPointer() => default; // 0x000000018545C2DC-0x000000018545C330
			public static void Constructor() {} // 0x0000000183CEBA20-0x0000000183CEBAB0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr) {} // 0x000000018545C330-0x000000018545C514
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void DistanceConstraintKernel(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index) {} // 0x000000018545AC28-0x000000018545AD30
		[BurstCompile]
		internal static unsafe void DistanceConstraintRangeKernel(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr) {} // 0x000000018545AD30-0x000000018545AE3C
		[BurstCompile]
		public static unsafe void DistanceConstraintKernel_BurstManaged(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index) {} // 0x000000018545A14C-0x000000018545AC28
		[BurstCompile]
		public static unsafe void DistanceConstraintRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr) {} // 0x0000000185453C48-0x0000000185454A6C
	}

	public class DistanceConstraint : IDisposable // TypeDefIndex: 44752
	{
		// Fields
		public const int TypeCount = 2; // Metadata: 0x01FB9050
		public ExNativeArray<uint> indexArray; // 0x10
		public ExNativeArray<ushort> dataArray; // 0x18
		public ExNativeArray<float> distanceArray; // 0x20
	
		// Properties
		public int DataCount { get => default; } // 0x000000018545C9AC-0x000000018545C9E4 
	
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 44748
		{
			// Fields
			public CurveSerializeData stiffness; // 0x10
	
			// Constructors
			public SerializeData() {} // 0x000000018283A880-0x000000018283A910
	
			// Methods
			public void DataValidate() {} // 0x00000001854663FC-0x000000018546645C
			public SerializeData Clone() => default; // 0x0000000185466060-0x0000000185466108
		}
	
		public struct DistanceConstraintParams // TypeDefIndex: 44749
		{
			// Fields
			public float4x4 restorationStiffness; // 0x00
			public float velocityAttenuation; // 0x40
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000182E24E40-0x0000000182E24ED0
		}
	
		[Serializable]
		public class ConstraintData : IValid // TypeDefIndex: 44750
		{
			// Fields
			public ResultCode result; // 0x10
			public uint[] indexArray; // 0x18
			public ushort[] dataArray; // 0x20
			public float[] distanceArray; // 0x28
	
			// Constructors
			public ConstraintData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool IsValid() => default; // 0x0000000182E1A2C0-0x0000000182E1A300
		}
	
		[BurstCompile]
		private struct DistanceConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44751
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182E0A100-0x0000000182E0A1A0
			[IDTag(1)]
			public void Execute() {} // 0x000000018545AE3C-0x000000018545AED4
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018545AED4-0x000000018545BA08
			public void UnsafeDo() {} // 0x000000018545BA08-0x000000018545BC10
		}
	
		// Constructors
		public DistanceConstraint() {} // 0x00000001834E27F0-0x00000001834E2AA0
	
		// Methods
		public void Dispose() {} // 0x000000018545C748-0x000000018545C804
		public override string ToString() => default; // 0x000000018545C804-0x000000018545C9AC
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters) => default; // 0x00000001826D8E70-0x00000001826DBBA0
		internal void Register(ClothProcess cprocess) {} // 0x0000000182E19F60-0x0000000182E1A110
		internal void Exit(ClothProcess cprocess) {} // 0x0000000183212070-0x00000001832121C0
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x000000018281C630-0x000000018281CC30
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public class InertiaConstraint : IDisposable // TypeDefIndex: 44758
	{
		// Fields
		internal ExNativeArray<ushort> fixedArray; // 0x10
	
		// Nested types
		public enum TeleportMode // TypeDefIndex: 44753
		{
			None = 0,
			Reset = 1,
			Keep = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 44754
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
			public SerializeData() {} // 0x0000000183475960-0x0000000183475AC0
	
			// Methods
			public SerializeData Clone() => default; // 0x0000000185466108-0x00000001854662A4
			public void DataValidate() {} // 0x000000018546645C-0x00000001854665C0
		}
	
		public struct InertiaConstraintParams // TypeDefIndex: 44755
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
			public void Convert(SerializeData sdata) {} // 0x0000000182E27060-0x0000000182E27170
		}
	
		[Serializable]
		public struct CenterData // TypeDefIndex: 44756
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
			internal void Initialize() {} // 0x0000000183652440-0x00000001836525B0
		}
	
		[Serializable]
		public class ConstraintData // TypeDefIndex: 44757
		{
			// Fields
			public ResultCode result; // 0x10
			public CenterData centerData; // 0x18
			public float3 initLocalGravityDirection; // 0x2D0
	
			// Constructors
			public ConstraintData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public InertiaConstraint() {} // 0x00000001834DF630-0x00000001834DF740
	
		// Methods
		public void Dispose() {} // 0x0000000185461760-0x00000001854617E8
		public override string ToString() => default; // 0x00000001854617E8-0x00000001854618E8
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters) => default; // 0x0000000182E236B0-0x0000000182E23CE0
		internal void Register(ClothProcess cprocess) {} // 0x0000000182E1A110-0x0000000182E1A2A0
		internal void Exit(ClothProcess cprocess) {} // 0x00000001832122C0-0x00000001832123A0
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	[BurstCompile]
	internal static class MotionConstraintJobKernels // TypeDefIndex: 44763
	{
		// Nested types
		public unsafe delegate void MotionConstraintKernel_00000121_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // TypeDefIndex: 44759; 0x00000001854BEA48-0x00000001854BEAE4
	
		internal static class MotionConstraintKernel_00000121_BurstDirectCall // TypeDefIndex: 44760
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static MotionConstraintKernel_00000121_BurstDirectCall() {} // 0x0000000183CEB150-0x0000000183CEB160
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0005f547) {} // 0x00000001854BE658-0x00000001854BE75C
			private static IntPtr GetFunctionPointer() => default; // 0x00000001854BE75C-0x00000001854BE7B0
			public static void Constructor() {} // 0x0000000183CEB160-0x0000000183CEB1F0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index) {} // 0x00000001854BE7B0-0x00000001854BE95C
		}
	
		public unsafe delegate void MotionConstraintRangeKernel_00000122_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // TypeDefIndex: 44761; 0x00000001854BEF48-0x00000001854BEFE8
	
		internal static class MotionConstraintRangeKernel_00000122_BurstDirectCall // TypeDefIndex: 44762
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static MotionConstraintRangeKernel_00000122_BurstDirectCall() {} // 0x0000000183CEB0B0-0x0000000183CEB0C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0005f574) {} // 0x00000001854BEBB8-0x00000001854BECBC
			private static IntPtr GetFunctionPointer() => default; // 0x00000001854BECBC-0x00000001854BED10
			public static void Constructor() {} // 0x0000000183CEB0C0-0x0000000183CEB150
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x00000001854BED10-0x00000001854BEEB8
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void MotionConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index) {} // 0x000000018546232C-0x0000000185462414
		[BurstCompile]
		internal static unsafe void MotionConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x00000001854624F8-0x00000001854625E4
		[BurstCompile]
		public static unsafe void MotionConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index) {} // 0x0000000185461A10-0x000000018546232C
		[BurstCompile]
		public static unsafe void MotionConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x0000000185462414-0x00000001854624F8
	}

	public class MotionConstraint : IDisposable // TypeDefIndex: 44767
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 44764
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
			public SerializeData() {} // 0x000000018283A5E0-0x000000018283A6A0
	
			// Methods
			public void DataValidate() {} // 0x00000001854C25A8-0x00000001854C2664
			public SerializeData Clone() => default; // 0x00000001854C2374-0x00000001854C245C
		}
	
		public struct MotionConstraintParams // TypeDefIndex: 44765
		{
			// Fields
			public bool useMaxDistance; // 0x00
			public float4x4 maxDistanceCurveData; // 0x04
			public bool useBackstop; // 0x44
			public float backstopRadius; // 0x48
			public float4x4 backstopDistanceCurveData; // 0x4C
			public float stiffness; // 0x8C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000182E257D0-0x0000000182E258D0
		}
	
		[BurstCompile]
		private struct MotionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44766
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182EEB9D0-0x0000000182EEBB00
			[IDTag(1)]
			public void Execute() {} // 0x00000001854BE410-0x00000001854BE4A8
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854BDAC4-0x00000001854BE410
			public void UnsafeDo() {} // 0x00000001854BE4A8-0x00000001854BE658
		}
	
		// Constructors
		public MotionConstraint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x00000001854BF0BC-0x00000001854BF100
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x00000001828201D0-0x0000000182820780
	}

	public class SelfCollisionConstraint : IDisposable // TypeDefIndex: 44821
	{
		// Fields
		public const uint KindPoint = 0; // Metadata: 0x01FB9054
		public const uint KindEdge = 1; // Metadata: 0x01FB9055
		public const uint KindTriangle = 2; // Metadata: 0x01FB9056
		public const uint Flag_KindMask = 50331648; // Metadata: 0x01FB9057
		public const uint Flag_Fix0 = 67108864; // Metadata: 0x01FB905B
		public const uint Flag_Fix1 = 134217728; // Metadata: 0x01FB905F
		public const uint Flag_Fix2 = 268435456; // Metadata: 0x01FB9063
		public const uint Flag_AllFix = 536870912; // Metadata: 0x01FB9067
		public const uint Flag_Ignore = 1073741824; // Metadata: 0x01FB906C
		public const uint Flag_Enable = 2147483648; // Metadata: 0x01FB9071
		private ExNativeArray<Primitive> primitiveArray; // 0x10
		private ExNativeArray<SortData> sortAndSweepArray; // 0x18
		private NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x30
		private NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x48
		private NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x58
		private NativeList<PointTriangleContact> pointTriangleContactList; // 0x70
		private NativeArray<byte> intersectFlagArray; // 0x80
	
		// Properties
		public int PointPrimitiveCount { get; private set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public int EdgePrimitiveCount { get; private set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public int TrianglePrimitiveCount { get; private set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public int IntersectCount { get; private set; } // 0x0000000183D4FB60-0x0000000183D4FB70 0x0000000183D4FB70-0x0000000183D4FB80
	
		// Nested types
		[BurstCompile]
		private static class IntersectUpdatePrimitiveJobKernels // TypeDefIndex: 44772
		{
			// Nested types
			public unsafe delegate void IntersectUpdatePrimitiveKernel_00000145_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // TypeDefIndex: 44768; 0x00000001854BD60C-0x00000001854BD620
	
			internal static class IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall // TypeDefIndex: 44769
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall() {} // 0x0000000183CEB290-0x0000000183CEB2A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f5c7) {} // 0x00000001854BD318-0x00000001854BD41C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854BD41C-0x00000001854BD470
				public static void Constructor() {} // 0x0000000183CEB2A0-0x0000000183CEB330
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index) {} // 0x00000001854BD470-0x00000001854BD540
			}
	
			public unsafe delegate void IntersectUpdatePrimitiveRangeKernel_00000146_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // TypeDefIndex: 44770; 0x00000001854BD60C-0x00000001854BD620
	
			internal static class IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall // TypeDefIndex: 44771
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall() {} // 0x0000000183CEB1F0-0x0000000183CEB200
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f5df) {} // 0x00000001854BD6E8-0x00000001854BD7EC
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854BD7EC-0x00000001854BD840
				public static void Constructor() {} // 0x0000000183CEB200-0x0000000183CEB290
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr) {} // 0x00000001854BD840-0x00000001854BD948
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void IntersectUpdatePrimitiveKernel(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index) {} // 0x00000001854BCB90-0x00000001854BCC14
			[BurstCompile]
			internal static unsafe void IntersectUpdatePrimitiveRangeKernel(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr) {} // 0x00000001854BCC9C-0x00000001854BCD24
			[BurstCompile]
			public static unsafe void IntersectUpdatePrimitiveKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index) {} // 0x00000001854B7484-0x00000001854B7888
			[BurstCompile]
			public static unsafe void IntersectUpdatePrimitiveRangeKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr) {} // 0x00000001854BCC14-0x00000001854BCC9C
		}
	
		[BurstCompile]
		private static class UpdatePrimitiveJobKernels // TypeDefIndex: 44777
		{
			// Nested types
			public unsafe delegate void UpdatePrimitiveKernel_00000147_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // TypeDefIndex: 44773; 0x00000001854C8F84-0x00000001854C9010
	
			internal static class UpdatePrimitiveKernel_00000147_BurstDirectCall // TypeDefIndex: 44774
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdatePrimitiveKernel_00000147_BurstDirectCall() {} // 0x0000000183CE95D0-0x0000000183CE95E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f633) {} // 0x00000001854C8BB4-0x00000001854C8CB8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854C8CB8-0x00000001854C8D0C
				public static void Constructor() {} // 0x0000000183CE95E0-0x0000000183CE9670
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index) {} // 0x00000001854C8D0C-0x00000001854C8E8C
			}
	
			public unsafe delegate void UpdatePrimitiveRangeKernel_00000148_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // TypeDefIndex: 44775; 0x0000000185007DB4-0x0000000185007E40
	
			internal static class UpdatePrimitiveRangeKernel_00000148_BurstDirectCall // TypeDefIndex: 44776
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdatePrimitiveRangeKernel_00000148_BurstDirectCall() {} // 0x0000000183CE9530-0x0000000183CE9540
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f65d) {} // 0x00000001854C90D8-0x00000001854C91DC
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854C91DC-0x00000001854C9230
				public static void Constructor() {} // 0x0000000183CE9540-0x0000000183CE95D0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr) {} // 0x00000001854C9230-0x00000001854C93DC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void UpdatePrimitiveKernel(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index) {} // 0x00000001854C7DD0-0x00000001854C7EAC
			[BurstCompile]
			internal static unsafe void UpdatePrimitiveRangeKernel(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr) {} // 0x00000001854C7F80-0x00000001854C805C
			[BurstCompile]
			public static unsafe void UpdatePrimitiveKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index) {} // 0x00000001854C757C-0x00000001854C7DD0
			[BurstCompile]
			public static unsafe void UpdatePrimitiveRangeKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr) {} // 0x00000001854C7EAC-0x00000001854C7F80
		}
	
		[BurstCompile]
		private static class ClearBufferJobKernels // TypeDefIndex: 44780
		{
			// Nested types
			public delegate void ClearBufferKernel_00000149_PostfixBurstDelegate(); // TypeDefIndex: 44778; 0x00000001842BE03C-0x00000001842BE04C
	
			internal static class ClearBufferKernel_00000149_BurstDirectCall // TypeDefIndex: 44779
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearBufferKernel_00000149_BurstDirectCall() {} // 0x0000000183CEC050-0x0000000183CEC060
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f66f) {} // 0x00000001854BA2F4-0x00000001854BA3F8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854BA3F8-0x00000001854BA44C
				public static void Constructor() {} // 0x0000000183CEC060-0x0000000183CEC0F0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static void Invoke() {} // 0x00000001854BA44C-0x00000001854BA4B0
			}
	
			// Methods
			[BurstCompile]
			internal static void ClearBufferKernel() {} // 0x00000001854BA224-0x00000001854BA264
			[BurstCompile]
			public static void ClearBufferKernel_BurstManaged() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[BurstCompile]
		private static class SortJobKernels // TypeDefIndex: 44785
		{
			// Nested types
			public unsafe delegate void SortKernel_0000014A_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // TypeDefIndex: 44781; 0x0000000182097E50-0x0000000182097E70
	
			internal static class SortKernel_0000014A_BurstDirectCall // TypeDefIndex: 44782
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SortKernel_0000014A_BurstDirectCall() {} // 0x0000000183CEA250-0x0000000183CEA260
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f68d) {} // 0x00000001854C5548-0x00000001854C564C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854C564C-0x00000001854C56A0
				public static void Constructor() {} // 0x0000000183CEA260-0x0000000183CEA2F0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index) {} // 0x00000001854C56A0-0x00000001854C5750
			}
	
			public unsafe delegate void SortRangeKernel_0000014B_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // TypeDefIndex: 44783; 0x0000000182097E50-0x0000000182097E70
	
			internal static class SortRangeKernel_0000014B_BurstDirectCall // TypeDefIndex: 44784
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SortRangeKernel_0000014B_BurstDirectCall() {} // 0x0000000183CEA1B0-0x0000000183CEA1C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f69f) {} // 0x00000001854C58C0-0x00000001854C59C4
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854C59C4-0x00000001854C5A18
				public static void Constructor() {} // 0x0000000183CEA1C0-0x0000000183CEA250
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length) {} // 0x00000001854C5A18-0x00000001854C5AE4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SortKernel(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index) {} // 0x00000001854C4F9C-0x00000001854C5010
			[BurstCompile]
			internal static unsafe void SortRangeKernel(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length) {} // 0x00000001854C5074-0x00000001854C50E8
			[BurstCompile]
			public static unsafe void SortKernel_BurstManaged(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index) {} // 0x00000001854C4CE8-0x00000001854C4F9C
			[BurstCompile]
			public static unsafe void SortRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length) {} // 0x00000001854C5010-0x00000001854C5074
		}
	
		public enum SelfCollisionMode // TypeDefIndex: 44786
		{
			None = 0,
			FullMesh = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 44787
		{
			// Fields
			public SelfCollisionMode selfMode; // 0x10
			public CurveSerializeData surfaceThickness; // 0x18
			public SelfCollisionMode syncMode; // 0x20
			public BeyondBoneCloth syncPartner; // 0x28
			[Range(0f, 1f)]
			public float clothMass; // 0x30
	
			// Constructors
			public SerializeData() {} // 0x000000018283A6A0-0x000000018283A740
	
			// Methods
			public void DataValidate() {} // 0x00000001854C2530-0x00000001854C25A8
			public SerializeData Clone() => default; // 0x00000001854C245C-0x00000001854C2530
			public BeyondBoneCloth GetSyncPartner() => default; // 0x0000000182E27E70-0x0000000182E27EB0
		}
	
		public struct SelfCollisionConstraintParams // TypeDefIndex: 44788
		{
			// Fields
			public SelfCollisionMode selfMode; // 0x00
			public float4x4 surfaceThicknessCurveData; // 0x04
			public SelfCollisionMode syncMode; // 0x44
			public float clothMass; // 0x48
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000182E24D90-0x0000000182E24E40
		}
	
		private struct Primitive // TypeDefIndex: 44789
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
			public bool IsIgnore() => default; // 0x00000001854C08EC-0x00000001854C08F8
			public bool HasParticle(int p) => default; // 0x00000001854C0898-0x00000001854C08EC
			public uint GetKind() => default; // 0x0000000183D4FB20-0x0000000183D4FB30
			public int GetTeamId() => default; // 0x0000000183D4FB50-0x0000000183D4FB60
			public float GetSolveThickness([IsReadOnly] in Primitive pri) => default; // 0x0000000183D4FB30-0x0000000183D4FB50
			public bool AnyParticle([IsReadOnly] in Primitive pri) => default; // 0x00000001854B88C0-0x00000001854B8930
		}
	
		private struct SortData : IComparable<SortData> // TypeDefIndex: 44790
		{
			// Fields
			public uint flagAndTeamId; // 0x00
			public int primitiveIndex; // 0x04
			public double2 firstMinMax; // 0x08
			public double2 secondMinMax; // 0x18
			public double2 thirdMinMax; // 0x28
	
			// Methods
			public int CompareTo(SortData other) => default; // 0x00000001854C4C58-0x00000001854C4CE8
			public uint GetKind() => default; // 0x0000000183D4FB20-0x0000000183D4FB30
		}
	
		internal struct EdgeEdgeContact // TypeDefIndex: 44791
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
			public override string ToString() => default; // 0x00000001854BB494-0x00000001854BB6B0
			public string __iFixBaseProxy_ToString() => default; // 0x00000001854BB6B0-0x00000001854BB718
		}
	
		internal struct PointTriangleContact // TypeDefIndex: 44792
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
			public override string ToString() => default; // 0x00000001854C04FC-0x00000001854C0740
			public string __iFixBaseProxy_ToString() => default; // 0x00000001854C0740-0x00000001854C07A0
		}
	
		[BurstCompile]
		private struct InitPrimitiveJob : IJobParallelFor // TypeDefIndex: 44793
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
			public void Execute(int index) {} // 0x00000001854BB810-0x00000001854BBACC
		}
	
		[BurstCompile]
		private struct ClearBufferJob : IJob // TypeDefIndex: 44794
		{
			// Fields
			[WriteOnly]
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x00
			[WriteOnly]
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854BA264-0x00000001854BA2F4
		}
	
		[BurstCompile]
		private struct UpdatePrimitiveJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44795
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001854C89D0-0x00000001854C8A3C
			[IDTag(1)]
			public void Execute() {} // 0x00000001854C8938-0x00000001854C89D0
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854C805C-0x00000001854C8938
			public void UnsafeDo() {} // 0x00000001854C8A3C-0x00000001854C8BB4
		}
	
		[BurstCompile]
		private struct SortJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 44796
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
			public void SetIndexCount(int indexCount) {} // 0x00000001854C5458-0x00000001854C54B0
			[IDTag(1)]
			public void Execute() {} // 0x00000001854C53E4-0x00000001854C5458
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854C50E8-0x00000001854C53E4
			public void UnsafeDo() {} // 0x00000001854C54B0-0x00000001854C5548
		}
	
		[BurstCompile]
		private struct PointTriangleBroadPhaseJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 44797
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001854C010C-0x00000001854C0178
			[IDTag(1)]
			public void Execute() {} // 0x00000001854C0074-0x00000001854C010C
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854BF758-0x00000001854C0074
			private void SweepTest(int sortIndex, ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck) {} // 0x00000001854C0178-0x00000001854C04FC
			private void BroadPointTriangle(ref Primitive p_pri, ref Primitive t_pri, float thickness, float scr, float ang) {} // 0x00000001854BF100-0x00000001854BF758
		}
	
		[BurstCompile]
		private struct EdgeEdgeBroadPhaseJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 44798
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001854BB128-0x00000001854BB190
			[IDTag(1)]
			public void Execute() {} // 0x00000001854BA9E0-0x00000001854BAA74
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854BAA74-0x00000001854BB128
			private void SweepTest(int sortIndex, ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck) {} // 0x00000001854BB190-0x00000001854BB494
			private void BroadEdgeEdge(ref Primitive pri0, ref Primitive pri1, float thickness, float scr) {} // 0x00000001854BA4B0-0x00000001854BA9E0
		}
	
		[BurstCompile]
		private struct EdgeEdgeToListJob : IJob // TypeDefIndex: 44799
		{
			// Fields
			[ReadOnly]
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854BB718-0x00000001854BB810
		}
	
		[BurstCompile]
		private struct PointTriangleToListJob : IJob // TypeDefIndex: 44800
		{
			// Fields
			[ReadOnly]
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854C07A0-0x00000001854C0898
		}
	
		[BurstCompile]
		private struct UpdateEdgeEdgeBroadPhaseJob : IJobParallelForDefer // TypeDefIndex: 44801
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<float3> oldPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x00000001854C61F0-0x00000001854C691C
		}
	
		[BurstCompile]
		private struct UpdatePointTriangleBroadPhaseJob : IJobParallelForDefer // TypeDefIndex: 44802
		{
			// Fields
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x00000001854C6F98-0x00000001854C757C
		}
	
		[BurstCompile]
		private struct SolverEdgeEdgeJob : IJobParallelForDefer // TypeDefIndex: 44803
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
			public void Execute(int index) {} // 0x00000001854C36A4-0x00000001854C3CC8
		}
	
		[BurstCompile]
		private struct SolverPointTriangleJob : IJobParallelForDefer // TypeDefIndex: 44804
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
			public void Execute(int index) {} // 0x00000001854C43D4-0x00000001854C4C58
		}
	
		[BurstCompile]
		private struct IntersectUpdatePrimitiveJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44805
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001854BD1EC-0x00000001854BD254
			[IDTag(1)]
			public void Execute() {} // 0x00000001854BD158-0x00000001854BD1EC
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854BCD24-0x00000001854BD158
			public void UnsafeDo() {} // 0x00000001854BD254-0x00000001854BD318
		}
	
		[BurstCompile]
		private struct IntersectEdgeTriangleJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 44806
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001854BC854-0x00000001854BC8BC
			[IDTag(1)]
			public void Execute() {} // 0x00000001854BC3C8-0x00000001854BC45C
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854BBACC-0x00000001854BC3C8
			private void SweepTest(ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck) {} // 0x00000001854BC8BC-0x00000001854BCB90
			private void IntersectTest(ref Primitive epri, ref Primitive tpri) {} // 0x00000001854BC45C-0x00000001854BC854
		}
	
		[BurstCompile]
		private static class SolverPointTriangleCrossFrameJobKernels // TypeDefIndex: 44811
		{
			// Nested types
			public unsafe delegate void SolverPointTriangleCrossFrameKernel_0000017E_PostfixBurstDelegate(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 44807; 0x0000000181028930-0x0000000181028950
	
			internal static class SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall // TypeDefIndex: 44808
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall() {} // 0x0000000183CEA390-0x0000000183CEA3A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f6f7) {} // 0x00000001854C3E2C-0x00000001854C3F30
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854C3F30-0x00000001854C3F84
				public static void Constructor() {} // 0x0000000183CEA3A0-0x0000000183CEA430
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001854C3F84-0x00000001854C4048
			}
	
			public unsafe delegate void SolverPointTriangleCrossFrameRangeKernel_0000017F_PostfixBurstDelegate(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 44809; 0x0000000181028930-0x0000000181028950
	
			internal static class SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall // TypeDefIndex: 44810
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall() {} // 0x0000000183CEA2F0-0x0000000183CEA300
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f70c) {} // 0x00000001854C40F4-0x00000001854C41F8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854C41F8-0x00000001854C424C
				public static void Constructor() {} // 0x0000000183CEA300-0x0000000183CEA390
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001854C424C-0x00000001854C4328
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolverPointTriangleCrossFrameKernel(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001854C3CC8-0x00000001854C3D44
			[BurstCompile]
			internal static unsafe void SolverPointTriangleCrossFrameRangeKernel(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001854C3DB0-0x00000001854C3E2C
			[BurstCompile]
			public static unsafe void SolverPointTriangleCrossFrameKernel_BurstManaged(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001854B9024-0x00000001854BA224
			[BurstCompile]
			public static unsafe void SolverPointTriangleCrossFrameRangeKernel_BurstManaged(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001854C3D44-0x00000001854C3DB0
		}
	
		[BurstCompile]
		private static class SolverEdgeEdgeCrossFrameJobKernels // TypeDefIndex: 44816
		{
			// Nested types
			public unsafe delegate void SolverEdgeEdgeCrossFrameKernel_00000180_PostfixBurstDelegate(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 44812; 0x0000000181028930-0x0000000181028950
	
			internal static class SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall // TypeDefIndex: 44813
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall() {} // 0x0000000183CEA4D0-0x0000000183CEA4E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f735) {} // 0x00000001854C3028-0x00000001854C312C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854C312C-0x00000001854C3180
				public static void Constructor() {} // 0x0000000183CEA4E0-0x0000000183CEA570
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001854C3180-0x00000001854C3244
			}
	
			public unsafe delegate void SolverEdgeEdgeCrossFrameRangeKernel_00000181_PostfixBurstDelegate(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 44814; 0x0000000181028930-0x0000000181028950
	
			internal static class SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall // TypeDefIndex: 44815
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall() {} // 0x0000000183CEA430-0x0000000183CEA440
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f74a) {} // 0x00000001854C33C4-0x00000001854C34C8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854C34C8-0x00000001854C351C
				public static void Constructor() {} // 0x0000000183CEA440-0x0000000183CEA4D0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001854C351C-0x00000001854C35F8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolverEdgeEdgeCrossFrameKernel(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001854C2664-0x00000001854C26E0
			[BurstCompile]
			internal static unsafe void SolverEdgeEdgeCrossFrameRangeKernel(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001854C274C-0x00000001854C27C8
			[BurstCompile]
			public static unsafe void SolverEdgeEdgeCrossFrameKernel_BurstManaged(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001854B8930-0x00000001854B9024
			[BurstCompile]
			public static unsafe void SolverEdgeEdgeCrossFrameRangeKernel_BurstManaged(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001854C26E0-0x00000001854C274C
		}
	
		[BurstCompile]
		private struct UpdateEdgeEdgeBroadPhaseCrossFrameJob : IJob // TypeDefIndex: 44817
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
			public void Execute(int index) {} // 0x00000001854C5C14-0x00000001854C61F0
			[IDTag(1)]
			public void Execute() {} // 0x00000001854C5B80-0x00000001854C5C14
		}
	
		[BurstCompile]
		private struct UpdatePointTriangleBroadPhaseCrossFrameJob : IJob // TypeDefIndex: 44818
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
			public void Execute(int index) {} // 0x00000001854C691C-0x00000001854C6F04
			[IDTag(1)]
			public void Execute() {} // 0x00000001854C6F04-0x00000001854C6F98
		}
	
		[BurstCompile]
		private struct SolverEdgeEdgeCrossFrameJob : IJob, IUnsafeJob // TypeDefIndex: 44819
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
			public void Execute(int index) {} // 0x00000001854C283C-0x00000001854C2F88
			[IDTag(1)]
			public void Execute() {} // 0x00000001854C27C8-0x00000001854C283C
			public void UnsafeDo() {} // 0x00000001854C2F88-0x00000001854C3028
		}
	
		[BurstCompile]
		private struct SolverPointTriangleCrossFrameJob : IJob, IUnsafeJob // TypeDefIndex: 44820
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
			public void Execute(int index) {} // 0x00000001854D274C-0x00000001854D2E88
			[IDTag(1)]
			public void Execute() {} // 0x00000001854D2E88-0x00000001854D2EFC
			public void UnsafeDo() {} // 0x00000001854D2EFC-0x00000001854D2F9C
		}
	
		// Constructors
		public SelfCollisionConstraint() {} // 0x00000001834E2CC0-0x00000001834E3000
	
		// Methods
		public void Dispose() {} // 0x00000001854C09E8-0x00000001854C0B48
		public bool HasPrimitive() => default; // 0x0000000182EF7420-0x0000000182EF74B0
		public override string ToString() => default; // 0x00000001854C1DEC-0x00000001854C21A8
		internal void Register(ClothProcess cprocess) {} // 0x0000000182E19E20-0x0000000182E19E70
		internal void Exit(ClothProcess cprocess) {} // 0x00000001832128D0-0x0000000183212920
		internal void UpdateTeam(int teamId) {} // 0x0000000182BB7B40-0x0000000182BB8030
		private void InitPrimitive(int teamId, TeamManager.TeamData tdata, uint kind, int startPrimitive, int startSort, int length) {} // 0x00000001854C0B48-0x00000001854C0EA4
		internal void WorkBufferUpdate() {} // 0x0000000182C4CF90-0x0000000182C4CFF0
		private static int BinarySearchSortAndlSweep(ref NativeArray<SortData> sortAndSweepArray, [IsReadOnly] in SortData sd, [IsReadOnly] in DataChunk chunk) => default; // 0x00000001854C08F8-0x00000001854C09E8
		internal JobHandle SolverConstraint(int updateIndex, JobHandle jobHandle) => default; // 0x0000000182EF6FA0-0x0000000182EF70B0
		private JobHandle SolverRuntimeSelfCollision(int updateIndex, JobHandle jobHandle) => default; // 0x0000000182EF7220-0x0000000182EF7420
		private JobHandle SolverBroadPhase(JobHandle jobHandle) => default; // 0x00000001854C0EA4-0x00000001854C1DEC
		private JobHandle UpdateBroadPhase(JobHandle jobHandle) => default; // 0x00000001854C21A8-0x00000001854C2374
		private JobHandle SolveIntersect(JobHandle jobHandle) => default; // 0x0000000182EF70B0-0x0000000182EF7220
		public static void Initialize_IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall() {} // 0x00000001835EAE00-0x00000001835EAE60
		public static void Initialize_IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall() {} // 0x00000001835EAE60-0x00000001835EAEC0
		public static void Initialize_UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147_BurstDirectCall() {} // 0x00000001835EAEC0-0x00000001835EAF20
		public static void Initialize_UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148_BurstDirectCall() {} // 0x00000001835EAF20-0x00000001835EAF80
		public static void Initialize_ClearBufferJobKernels_ClearBufferKernel_00000149_BurstDirectCall() {} // 0x00000001835EAF80-0x00000001835EAFE0
		public static void Initialize_SortJobKernels_SortKernel_0000014A_BurstDirectCall() {} // 0x00000001835EAFE0-0x00000001835EB040
		public static void Initialize_SortJobKernels_SortRangeKernel_0000014B_BurstDirectCall() {} // 0x00000001835EB040-0x00000001835EB0A0
		public static void Initialize_SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall() {} // 0x00000001835EB0A0-0x00000001835EB100
		public static void Initialize_SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall() {} // 0x00000001835EB100-0x00000001835EB160
		public static void Initialize_SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall() {} // 0x00000001835EB160-0x00000001835EB1C0
		public static void Initialize_SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall() {} // 0x00000001835EB1C0-0x00000001835EB220
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public class SpringConstraint : IDisposable // TypeDefIndex: 44824
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 44822
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
			public SerializeData() {} // 0x0000000183D4FB90-0x0000000183D4FBB0
	
			// Methods
			public void DataValidate() {} // 0x00000001854D0CB8-0x00000001854D0D84
			public SerializeData Clone() => default; // 0x00000001854D0AAC-0x00000001854D0B70
		}
	
		public struct SpringConstraintParams // TypeDefIndex: 44823
		{
			// Fields
			public float springPower; // 0x00
			public float limitDistance; // 0x04
			public float normalLimitRatio; // 0x08
			public float springNoise; // 0x0C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000182E26FF0-0x0000000182E27060
		}
	
		// Constructors
		public SpringConstraint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x00000001854D2F9C-0x00000001854D2FE0
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x00000001854D2FE0-0x00000001854D3064
	}

	[BurstCompile]
	internal static class TethreConstraintJobKernels // TypeDefIndex: 44829
	{
		// Nested types
		public unsafe delegate void TethreConstraintKernel_00000193_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // TypeDefIndex: 44825; 0x00000001854BEA48-0x00000001854BEAE4
	
		internal static class TethreConstraintKernel_00000193_BurstDirectCall // TypeDefIndex: 44826
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static TethreConstraintKernel_00000193_BurstDirectCall() {} // 0x0000000183CE9DF0-0x0000000183CE9E00
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0005f7aa) {} // 0x00000001854D3E44-0x00000001854D3F48
			private static IntPtr GetFunctionPointer() => default; // 0x00000001854D3F48-0x00000001854D3F9C
			public static void Constructor() {} // 0x0000000183CE9E00-0x0000000183CE9E90
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index) {} // 0x00000001854D3F9C-0x00000001854D4120
		}
	
		public unsafe delegate void TethreConstraintRangeKernel_00000194_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // TypeDefIndex: 44827; 0x00000001854BEF48-0x00000001854BEFE8
	
		internal static class TethreConstraintRangeKernel_00000194_BurstDirectCall // TypeDefIndex: 44828
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static TethreConstraintRangeKernel_00000194_BurstDirectCall() {} // 0x0000000183CE9D50-0x0000000183CE9D60
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0005f7d7) {} // 0x00000001854D420C-0x00000001854D4310
			private static IntPtr GetFunctionPointer() => default; // 0x00000001854D4310-0x00000001854D4364
			public static void Constructor() {} // 0x0000000183CE9D60-0x0000000183CE9DF0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr) {} // 0x00000001854D4364-0x00000001854D450C
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void TethreConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index) {} // 0x00000001854D3554-0x00000001854D363C
		[BurstCompile]
		internal static unsafe void TethreConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr) {} // 0x00000001854D363C-0x00000001854D3728
		[BurstCompile]
		public static unsafe void TethreConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index) {} // 0x00000001854D30EC-0x00000001854D3554
		[BurstCompile]
		public static unsafe void TethreConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr) {} // 0x00000001854CA634-0x00000001854CAD74
	}

	public class TetherConstraint : IDisposable // TypeDefIndex: 44833
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 44830
		{
			// Fields
			[Range(0f, 1f)]
			public float distanceCompression; // 0x10
	
			// Constructors
			public SerializeData() {} // 0x0000000183D4FBB0-0x0000000183D4FBC0
	
			// Methods
			public void DataValidate() {} // 0x00000001854D0BF8-0x00000001854D0C64
			public SerializeData Clone() => default; // 0x00000001854D0B70-0x00000001854D0BF8
		}
	
		public struct TetherConstraintParams // TypeDefIndex: 44831
		{
			// Fields
			public float compressionLimit; // 0x00
			public float stretchLimit; // 0x04
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000182E26E50-0x0000000182E26EB0
		}
	
		[BurstCompile]
		private struct TethreConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44832
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182EEB930-0x0000000182EEB9D0
			[IDTag(1)]
			public void Execute() {} // 0x00000001854D3728-0x00000001854D37C0
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854D37C0-0x00000001854D3CA0
			public void UnsafeDo() {} // 0x00000001854D3CA0-0x00000001854D3E44
		}
	
		// Constructors
		public TetherConstraint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x00000001854D30A8-0x00000001854D30EC
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x000000018281FC30-0x00000001828201D0
	}

	public class TriangleBendingConstraint : IDisposable // TypeDefIndex: 44850
	{
		// Fields
		private const sbyte VOLUME_SIGN = 100; // Metadata: 0x01FB9078
		public ExNativeArray<ulong> trianglePairArray; // 0x10
		public ExNativeArray<float> restAngleOrVolumeArray; // 0x18
		public ExNativeArray<sbyte> signOrVolumeArray; // 0x20
		public ExNativeArray<uint> writeDataArray; // 0x28
		public ExNativeArray<uint> writeIndexArray; // 0x30
		public ExNativeArray<float3> writeBuffer; // 0x38
		private const float VolumeScale = 1000f; // Metadata: 0x01FB9079
	
		// Properties
		public int DataCount { get => default; } // 0x0000000182C4C5F0-0x0000000182C4C630 
	
		// Nested types
		[BurstCompile]
		private static class TriangleBendingJobKernels // TypeDefIndex: 44838
		{
			// Nested types
			public unsafe delegate void TriangleBendingKernel_000001AA_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // TypeDefIndex: 44834; 0x000000018545C050-0x000000018545C104
	
			internal static class TriangleBendingKernel_000001AA_BurstDirectCall // TypeDefIndex: 44835
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static TriangleBendingKernel_000001AA_BurstDirectCall() {} // 0x0000000183CE9CB0-0x0000000183CE9CC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f867) {} // 0x00000001854D8564-0x00000001854D8668
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854D8668-0x00000001854D86BC
				public static void Constructor() {} // 0x0000000183CE9CC0-0x0000000183CE9D50
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001854D86BC-0x00000001854D88A0
			}
	
			public unsafe delegate void TriangleBendingRangeKernel_000001AB_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // TypeDefIndex: 44836; 0x000000018545C5BC-0x000000018545C674
	
			internal static class TriangleBendingRangeKernel_000001AB_BurstDirectCall // TypeDefIndex: 44837
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static TriangleBendingRangeKernel_000001AB_BurstDirectCall() {} // 0x0000000183CE9C10-0x0000000183CE9C20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f89a) {} // 0x00000001854D89A4-0x00000001854D8AA8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854D8AA8-0x00000001854D8AFC
				public static void Constructor() {} // 0x0000000183CE9C20-0x0000000183CE9CB0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001854D8AFC-0x00000001854D8CE0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void TriangleBendingKernel(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001854D6098-0x00000001854D61A0
			[BurstCompile]
			internal static unsafe void TriangleBendingRangeKernel(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001854D61A0-0x00000001854D62AC
			private static bool Volume([IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double volumeRest, double stiffness, ref double3x4 addPosBuffer) => default; // 0x00000001854D62AC-0x00000001854D69F4
			private static bool DihedralAngle(double sign, [IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double restAngle, double stiffness, ref double3x4 addPosBuffer) => default; // 0x00000001854D4FCC-0x00000001854D5A3C
			[BurstCompile]
			public static unsafe void TriangleBendingKernel_BurstManaged(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001854D5A3C-0x00000001854D6098
			[BurstCompile]
			public static unsafe void TriangleBendingRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001854CAD74-0x00000001854CAEB8
		}
	
		[BurstCompile]
		private static class SolveAggregateBufferJobKernels // TypeDefIndex: 44843
		{
			// Nested types
			public unsafe delegate void SolveAggregateBufferKernel_000001AE_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // TypeDefIndex: 44839; 0x00000001854D2240-0x00000001854D229C
	
			internal static class SolveAggregateBufferKernel_000001AE_BurstDirectCall // TypeDefIndex: 44840
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveAggregateBufferKernel_000001AE_BurstDirectCall() {} // 0x0000000183CEA750-0x0000000183CEA760
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f8df) {} // 0x00000001854D1F1C-0x00000001854D2020
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854D2020-0x00000001854D2074
				public static void Constructor() {} // 0x0000000183CEA760-0x0000000183CEA7F0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001854D2074-0x00000001854D2188
			}
	
			public unsafe delegate void SolveAggregateBufferRangeKernel_000001AF_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // TypeDefIndex: 44841; 0x000000018500A3A8-0x000000018500A404
	
			internal static class SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall // TypeDefIndex: 44842
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall() {} // 0x0000000183CEA6B0-0x0000000183CEA6C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f8fd) {} // 0x00000001854D2370-0x00000001854D2474
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854D2474-0x00000001854D24C8
				public static void Constructor() {} // 0x0000000183CEA6C0-0x0000000183CEA750
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001854D24C8-0x00000001854D2604
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolveAggregateBufferKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001854D1764-0x00000001854D180C
			[BurstCompile]
			internal static unsafe void SolveAggregateBufferRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001854D18B0-0x00000001854D1958
			[BurstCompile]
			public static unsafe void SolveAggregateBufferKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001854D13E4-0x00000001854D1764
			[BurstCompile]
			public static unsafe void SolveAggregateBufferRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001854D180C-0x00000001854D18B0
		}
	
		public enum Method // TypeDefIndex: 44844
		{
			None = 0,
			DihedralAngle = 1,
			DirectionDihedralAngle = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 44845
		{
			// Fields
			[Range(0f, 1f)]
			public float stiffness; // 0x10
	
			// Constructors
			public SerializeData() {} // 0x0000000183D4FB80-0x0000000183D4FB90
	
			// Methods
			public void DataValidate() {} // 0x00000001854D0C64-0x00000001854D0CB8
			public SerializeData Clone() => default; // 0x00000001854D0A24-0x00000001854D0AAC
		}
	
		public struct TriangleBendingConstraintParams // TypeDefIndex: 44846
		{
			// Fields
			public Method method; // 0x00
			public float stiffness; // 0x04
	
			// Methods
			public void Convert(SerializeData sdata) {} // 0x0000000182E26EB0-0x0000000182E26F10
		}
	
		[Serializable]
		public class ConstraintData : IValid // TypeDefIndex: 44847
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
			public ConstraintData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool IsValid() => default; // 0x0000000182E1A300-0x0000000182E1A340
		}
	
		[BurstCompile]
		private struct TriangleBendingJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44848
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001854D7B94-0x00000001854D7C00
			[IDTag(1)]
			public void Execute() {} // 0x00000001854D7AFC-0x00000001854D7B94
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854D7464-0x00000001854D7AFC
			private bool Volume([IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double volumeRest, double stiffness, ref double3x4 addPosBuffer) => default; // 0x00000001854D7E18-0x00000001854D8564
			private bool DihedralAngle(double sign, [IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double restAngle, double stiffness, ref double3x4 addPosBuffer) => default; // 0x00000001854D69F4-0x00000001854D7464
			public void UnsafeDo() {} // 0x00000001854D7C00-0x00000001854D7E18
		}
	
		[BurstCompile]
		private struct SolveAggregateBufferJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44849
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001854D1DA4-0x00000001854D1E0C
			[IDTag(1)]
			public void Execute() {} // 0x00000001854D1958-0x00000001854D19EC
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854D19EC-0x00000001854D1DA4
			public void UnsafeDo() {} // 0x00000001854D1E0C-0x00000001854D1F1C
		}
	
		// Constructors
		public TriangleBendingConstraint() {} // 0x00000001834DF740-0x00000001834DFBD0
	
		// Methods
		public void Dispose() {} // 0x00000001854D45D4-0x00000001854D4714
		public override string ToString() => default; // 0x00000001854D4D38-0x00000001854D4FCC
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters) => default; // 0x0000000182E21010-0x0000000182E229B0
		private static void InitVolume(VirtualMesh proxyMesh, int v0, int v1, int v2, int v3, out float volumeRest, out sbyte signFlag) {
			volumeRest = default;
			signFlag = default;
		} // 0x00000001854D4A78-0x00000001854D4D38
		private static void InitDihedralAngle(VirtualMesh proxyMesh, int v0, int v1, int v2, int v3, out float restAngle, out sbyte signFlag) {
			restAngle = default;
			signFlag = default;
		} // 0x00000001854D4714-0x00000001854D4A78
		internal void Register(ClothProcess cprocess) {} // 0x0000000182E19E70-0x0000000182E19F60
		internal void Exit(ClothProcess cprocess) {} // 0x0000000183211EA0-0x0000000183212070
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x0000000182C4C390-0x0000000182C4C5F0
		public static void Initialize_TriangleBendingJobKernels_TriangleBendingKernel_000001AA_BurstDirectCall() {} // 0x00000001835EB220-0x00000001835EB280
		public static void Initialize_TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB_BurstDirectCall() {} // 0x00000001835EB280-0x00000001835EB2E0
		public static void Initialize_SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE_BurstDirectCall() {} // 0x00000001835EB2E0-0x00000001835EB340
		public static void Initialize_SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall() {} // 0x00000001835EB340-0x00000001835EB3A0
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	[Serializable]
	public class CullingSettings : IDataValidate // TypeDefIndex: 44854
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
		public enum CameraCullingMode // TypeDefIndex: 44851
		{
			Off = 0,
			Reset = 10,
			Keep = 20,
			AnimatorLinkage = 30
		}
	
		public enum CameraCullingMethod // TypeDefIndex: 44852
		{
			AutomaticRenderer = 0,
			ManualRenderer = 10
		}
	
		public struct CullingParams // TypeDefIndex: 44853
		{
			// Fields
			public bool useDistanceCulling; // 0x00
			public float distanceCullingLength; // 0x04
			public float distanceCullingFadeRatio; // 0x08
	
			// Methods
			public void Convert(CullingSettings cullingSettings) {} // 0x0000000182E26DF0-0x0000000182E26E50
		}
	
		// Constructors
		public CullingSettings() {} // 0x000000018283A510-0x000000018283A5E0
	
		// Methods
		public void DataValidate() {} // 0x00000001854CC108-0x00000001854CC178
		public CullingSettings Clone() => default; // 0x00000001854CBFCC-0x00000001854CC108
		public override int GetHashCode() => default; // 0x00000001854CC178-0x00000001854CC1C4
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
	}

	[Serializable]
	public class CurveSerializeData // TypeDefIndex: 44855
	{
		// Fields
		public float value; // 0x10
		public bool useCurve; // 0x14
		public AnimationCurve curve; // 0x18
	
		// Constructors
		public CurveSerializeData() {} // 0x00000001854CC624-0x00000001854CC660
		public CurveSerializeData(float value) {} // 0x000000018291C870-0x000000018291C900
		public CurveSerializeData(float value, float curveStart, float curveEnd, bool useCurve = true /* Metadata: 0x01FB9086 */) {} // 0x000000018291EE20-0x000000018291EEF0
		public CurveSerializeData(float value, AnimationCurve curve) {} // 0x00000001854CC5BC-0x00000001854CC624
	
		// Methods
		[IDTag(0)]
		public void SetValue(float value) {} // 0x00000001854CC488-0x00000001854CC4E8
		[IDTag(1)]
		public void SetValue(float value, float curveStart, float curveEnd, bool useCurve = true /* Metadata: 0x01FB9087 */) {} // 0x00000001854CC4E8-0x00000001854CC5BC
		[IDTag(2)]
		public void SetValue(float value, AnimationCurve curve) {} // 0x00000001854CC408-0x00000001854CC488
		public void DataValidate(float min, float max) {} // 0x00000001854CC308-0x00000001854CC38C
		public float Evaluate(float time) => default; // 0x00000001854CC38C-0x00000001854CC408
		public float4x4 ConvertFloatArray() => default; // 0x0000000182E25A00-0x0000000182E25B00
		public CurveSerializeData Clone() => default; // 0x00000001854CC1C4-0x00000001854CC308
	}

	[Serializable]
	public class CustomSkinningSettings : IValid, IDataValidate, ITransform // TypeDefIndex: 44857
	{
		// Fields
		public bool enable; // 0x10
		public List<Transform> skinningBones; // 0x18
	
		// Constructors
		public CustomSkinningSettings() {} // 0x000000018283AA30-0x000000018283AAB0
	
		// Methods
		public void DataValidate() {} // 0x00000001854CC74C-0x00000001854CC78C
		public bool IsValid() => default; // 0x00000001854CC980-0x00000001854CCAF4
		public CustomSkinningSettings Clone() => default; // 0x00000001854CC660-0x00000001854CC74C
		public override int GetHashCode() => default; // 0x00000001854CC78C-0x00000001854CC7D8
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x00000001854CC7D8-0x00000001854CC980
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001854CCAF4-0x00000001854CCC70
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
	}

	[Serializable]
	public class GizmoSerializeData // TypeDefIndex: 44858
	{
		// Fields
		public bool always; // 0x10
		public ClothDebugSettings clothDebugSettings; // 0x18
	
		// Constructors
		public GizmoSerializeData() {} // 0x00000001854CEBF0-0x00000001854CEC68
	
		// Methods
		public bool IsAlways() => default; // 0x00000001854CEBA4-0x00000001854CEBF0
	}

	[Serializable]
	public class NormalAlignmentSettings : IValid, IDataValidate, ITransform // TypeDefIndex: 44860
	{
		// Fields
		public AlignmentMode alignmentMode; // 0x10
		public Transform adjustmentTransform; // 0x18
	
		// Nested types
		public enum AlignmentMode // TypeDefIndex: 44859
		{
			None = 0,
			BoundingBoxCenter = 1,
			Transform = 2
		}
	
		// Constructors
		public NormalAlignmentSettings() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void DataValidate() {} // 0x00000001854CECFC-0x00000001854CED3C
		public bool IsValid() => default; // 0x00000001854CEED8-0x00000001854CEF28
		public NormalAlignmentSettings Clone() => default; // 0x00000001854CEC68-0x00000001854CECFC
		public override int GetHashCode() => default; // 0x00000001854CED3C-0x00000001854CEE1C
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x00000001854CEE1C-0x00000001854CEED8
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001854CEF28-0x00000001854CF030
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
	}

	[Serializable]
	public class SelectionData : IValid // TypeDefIndex: 44864
	{
		// Fields
		public float3[] positions; // 0x10
		public VertexAttribute[] attributes; // 0x18
		public float maxConnectionDistance; // 0x20
		public bool userEdit; // 0x24
	
		// Properties
		public int Count { get => default; } // 0x00000001854D0A14-0x00000001854D0A24 
	
		// Nested types
		[BurstCompile]
		private struct TransformPositionJob : IJobParallelFor // TypeDefIndex: 44861
		{
			// Fields
			public float4x4 transformMatrix; // 0x00
			public NativeArray<float3> localPositions; // 0x40
	
			// Methods
			public void Execute(int index) {} // 0x00000001854D450C-0x00000001854D45D4
		}
	
		[BurstCompile]
		private struct CreateGridMapJob : IJob // TypeDefIndex: 44862
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
			public void Execute() {} // 0x00000001834D8000-0x00000001834D8120
		}
	
		[BurstCompile]
		private struct ConvertSelectionJob : IJobParallelFor // TypeDefIndex: 44863
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
			public void Execute(int vindex) {} // 0x00000001854CBB68-0x00000001854CBFCC
		}
	
		// Constructors
		public SelectionData() {} // 0x000000018350B670-0x000000018350B680
		public SelectionData(int cnt) {} // 0x00000001854D0998-0x00000001854D0A14
		public SelectionData(VirtualMesh vmesh, float4x4 transformMatrix) {} // 0x00000001854D06D0-0x00000001854D0998
	
		// Methods
		public bool IsValid() => default; // 0x0000000183721BA0-0x0000000183721C00
		public bool IsUserEdit() => default; // 0x00000001854D044C-0x00000001854D0498
		public SelectionData Clone() => default; // 0x0000000182A488E0-0x0000000182A48A10
		public bool Compare(SelectionData sdata) => default; // 0x00000001854CF8F0-0x00000001854CFB24
		public void AddRange(float3[] addPositions, VertexAttribute[] addAttributes = null) {} // 0x00000001854CF734-0x00000001854CF8F0
		public void Fill(VertexAttribute attr) {} // 0x00000001854D025C-0x00000001854D02E0
		[IDTag(0)]
		public NativeArray<float3> GetPositionNativeArray() => default; // 0x0000000183438D80-0x0000000183438DF0
		[IDTag(1)]
		public NativeArray<float3> GetPositionNativeArray(float4x4 transformMatrix) => default; // 0x00000001854D02E0-0x00000001854D044C
		public NativeArray<VertexAttribute> GetAttributeNativeArray() => default; // 0x0000000183438DF0-0x0000000183438E60
		public static GridMap<int> CreateGridMapRun(float gridSize, [IsReadOnly] in NativeArray<float3> positions, [IsReadOnly] in NativeArray<VertexAttribute> attributes, bool move = true /* Metadata: 0x01FB908B */, bool fix = true /* Metadata: 0x01FB908C */, bool ignore = true /* Metadata: 0x01FB908D */, bool invalid = true /* Metadata: 0x01FB908E */) => default; // 0x0000000183438E60-0x0000000183438FF0
		public void Merge(SelectionData from) {} // 0x00000001854D0498-0x00000001854D06D0
		public void ConvertFrom(SelectionData from) {} // 0x00000001854CFB24-0x00000001854D025C
	}

	public class BeyondBoneWindZone : ClothBehaviour // TypeDefIndex: 44866
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
	
		// Properties
		public int WindId { get; private set; } // 0x0000000183D4EEC0-0x0000000183D4EED0 0x0000000183D4EF10-0x0000000183D4EF20
	
		// Nested types
		public enum Mode // TypeDefIndex: 44865
		{
			GlobalDirection = 0,
			SphereDirection = 1,
			BoxDirection = 2,
			SphereRadial = 10
		}
	
		// Constructors
		public BeyondBoneWindZone() {} // 0x00000001854CB4BC-0x00000001854CB530
	
		// Methods
		public void Awake() {} // 0x00000001854CAEB8-0x00000001854CAF48
		public void Start() {} // 0x00000001854CB478-0x00000001854CB4BC
		public void OnEnable() {} // 0x00000001854CB284-0x00000001854CB314
		public void OnDisable() {} // 0x00000001854CB1F4-0x00000001854CB284
		public void OnDestroy() {} // 0x00000001854CB164-0x00000001854CB1F4
		public bool IsDirection() => default; // 0x00000001854CB0C4-0x00000001854CB114
		public bool IsRadial() => default; // 0x00000001854CB114-0x00000001854CB164
		public bool IsAddition() => default; // 0x00000001854CB078-0x00000001854CB0C4
		public Vector3 GetWindDirection(bool localSpace = false /* Metadata: 0x01FB908F */) => default; // 0x00000001854CAF48-0x00000001854CB078
		public void SetWindDirection(Vector3 dir, bool localSpace = false /* Metadata: 0x01FB9090 */) {} // 0x00000001854CB314-0x00000001854CB478
	}

	public struct WindParams : IValid // TypeDefIndex: 44867
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
		public void Convert(WindSettings sdata, ClothProcess.ClothType clothType) {} // 0x0000000182E26F80-0x0000000182E26FF0
		public bool IsValid() => default; // 0x00000001854D8D90-0x00000001854D8DE8
	}

	[Serializable]
	public class WindSettings : IValid, IDataValidate // TypeDefIndex: 44868
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
		public WindSettings() {} // 0x0000000183D4FBC0-0x0000000183D4FBF0
	
		// Methods
		public bool IsValid() => default; // 0x00000001854D8FBC-0x00000001854D9014
		public void DataValidate() {} // 0x00000001854D8EC0-0x00000001854D8FBC
		public WindSettings Clone() => default; // 0x00000001854D8DE8-0x00000001854D8EC0
	}

	public static class Define // TypeDefIndex: 44871
	{
		// Nested types
		public enum Result // TypeDefIndex: 44869
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
	
		public static class System // TypeDefIndex: 44870
		{
			// Fields
			public const int LatestPreBuildVersion = 2; // Metadata: 0x01FB9212
			public const float Epsilon = 1E-08f; // Metadata: 0x01FB9213
			public const int MaxRendererCount = 31; // Metadata: 0x01FB9217
			public const float MinimumGridSize = 1E-05f; // Metadata: 0x01FB9218
			public const int MaximumTeamCount = 4096; // Metadata: 0x01FB921C
			public const int DefaultSimulationFrequency = 90; // Metadata: 0x01FB921E
			public const int SimulationFrequency_Low = 30; // Metadata: 0x01FB9220
			public const int SimulationFrequency_Hi = 150; // Metadata: 0x01FB9221
			public const int DefaultMaxSimulationCountPerFrame = 3; // Metadata: 0x01FB9223
			public const int MaxSimulationCountPerFrame_Low = 1; // Metadata: 0x01FB9224
			public const int MaxSimulationCountPerFrame_Hi = 5; // Metadata: 0x01FB9225
			public const float SameSurfaceAngle = 80f; // Metadata: 0x01FB9226
			public const float MaxDistanceRatioFutuerPrediction = 1.3f; // Metadata: 0x01FB922A
			public const bool ReductionEnable = true; // Metadata: 0x01FB922E
			public const float ReductionSameDistance = 0.001f; // Metadata: 0x01FB922F
			public const bool ReductionDontMakeLine = true; // Metadata: 0x01FB9233
			public const float ReductionJoinPositionAdjustment = 1f; // Metadata: 0x01FB9234
			public const int ReductionMaxStep = 100; // Metadata: 0x01FB9238
			public const int MaxProxyMeshVertexCount = 32767; // Metadata: 0x01FB923A
			public const int MaxProxyMeshEdgeCount = 32767; // Metadata: 0x01FB923E
			public const int MaxProxyMeshTriangleCount = 32767; // Metadata: 0x01FB9242
			public const float ProxyMeshTrianglePairAngle = 20f; // Metadata: 0x01FB9246
			public const float ProxyMeshBoneClothTriangleAngle = 120f; // Metadata: 0x01FB924A
			public const float FrictionMass = 3f; // Metadata: 0x01FB924E
			public const float DepthMass = 5f; // Metadata: 0x01FB9252
			public const float FrictionDampingRate = 0.6f; // Metadata: 0x01FB9256
			public const float PositionAverageExponent = 0.5f; // Metadata: 0x01FB925A
			public const float MaxRealVelocity = 0.5f; // Metadata: 0x01FB925E
			public const float TetherCompressionStiffness = 1f; // Metadata: 0x01FB9262
			public const float TetherStretchStiffness = 1f; // Metadata: 0x01FB9266
			public const float TetherStretchLimit = 0.03f; // Metadata: 0x01FB926A
			public const float TetherStiffnessWidth = 0.3f; // Metadata: 0x01FB926E
			public const float TetherCompressionVelocityAttenuation = 0.7f; // Metadata: 0x01FB9272
			public const float TetherStretchVelocityAttenuation = 0.7f; // Metadata: 0x01FB9276
			public const float DistanceVelocityAttenuation = 0.3f; // Metadata: 0x01FB927A
			public const float DistanceVerticalStiffness = 1f; // Metadata: 0x01FB927E
			public const float DistanceHorizontalStiffness = 0.5f; // Metadata: 0x01FB9282
			public const float TriangleBendingMaxAngle = 120f; // Metadata: 0x01FB9286
			public const float VolumeMinAngle = 90f; // Metadata: 0x01FB928A
			public const float MaxAngleLimit = 179f; // Metadata: 0x01FB928E
			public const int AngleLimitIteration = 3; // Metadata: 0x01FB9292
			public const float AngleLimitAttenuation = 0.9f; // Metadata: 0x01FB9293
			public const float MaxMovementSpeedLimit = 10f; // Metadata: 0x01FB9297
			public const float MaxRotationSpeedLimit = 1440f; // Metadata: 0x01FB929B
			public const float MaxParticleSpeedLimit = 10f; // Metadata: 0x01FB929F
			public const int ExpandedColliderCount = 8; // Metadata: 0x01FB92A3
			public const float ColliderCollisionDynamicFrictionRatio = 1f; // Metadata: 0x01FB92A4
			public const float ColliderCollisionStaticFrictionRatio = 1f; // Metadata: 0x01FB92A8
			public const float CustomSkinningAngularAttenuation = 1f; // Metadata: 0x01FB92AC
			public const float CustomSkinningDistanceReduction = 0.6f; // Metadata: 0x01FB92B0
			public const float CustomSkinningDistancePow = 2f; // Metadata: 0x01FB92B4
			public const int SelfCollisionSolverIteration = 4; // Metadata: 0x01FB92B8
			public const float SelfCollisionFixedMass = 100f; // Metadata: 0x01FB92B9
			public const float SelfCollisionFrictionMass = 10f; // Metadata: 0x01FB92BD
			public const float SelfCollisionClothMass = 50f; // Metadata: 0x01FB92C1
			public const float SelfCollisionSCR = 2f; // Metadata: 0x01FB92C5
			public static readonly float SelfCollisionPointTriangleAngleCos; // 0x00
			public const int SelfCollisionIntersectDiv = 8; // Metadata: 0x01FB92C9
			public const float SelfCollisionThicknessMin = 0.001f; // Metadata: 0x01FB92CA
			public const float SelfCollisionThicknessMax = 0.05f; // Metadata: 0x01FB92CE
			public const float WindMaxTime = 10000f; // Metadata: 0x01FB92D2
			public const float WindBaseSpeed = 7.5f; // Metadata: 0x01FB92D6
			public const float BoneSpringDistanceStiffness = 0.5f; // Metadata: 0x01FB92DA
			public const float BoneSpringTetherCompressionLimit = 0.8f; // Metadata: 0x01FB92DE
			public const float BoneSpringCollisionFriction = 0.5f; // Metadata: 0x01FB92E2
			public const float DistanceCullingMaxLength = 100f; // Metadata: 0x01FB92E6
	
			// Constructors
			static System() {} // 0x00000001854D3064-0x00000001854D30A8
		}
	}

	internal interface ICount // TypeDefIndex: 44872
	{
		// Methods
		int Count();
	}

	internal interface IDataValidate // TypeDefIndex: 44873
	{
		// Methods
		void DataValidate();
	}

	internal interface ITransform // TypeDefIndex: 44874
	{
		// Methods
		void GetUsedTransform(HashSet<Transform> transformSet);
		void ReplaceTransform(Dictionary<int, Transform> replaceDict);
	}

	internal interface IValid // TypeDefIndex: 44875
	{
		// Methods
		bool IsValid();
	}

	public class ClothManager : IManager, IValid // TypeDefIndex: 44876
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
		public ClothManager() {} // 0x0000000182ECA330-0x0000000182ECA4A0
		static ClothManager() {} // 0x00000001839918E0-0x0000000183991B60
	
		// Methods
		public void Dispose() {} // 0x00000001854CB530-0x00000001854CBA28
		public void EnterdEditMode() {} // 0x00000001854CBA28-0x00000001854CBA78
		public void Initialize() {} // 0x0000000182ECCAB0-0x0000000182ECCFF0
		public bool IsValid() => default; // 0x00000001854CBACC-0x00000001854CBB18
		private void ClearMasterJob() {} // 0x000000018331BE30-0x000000018331BE60
		private void CompleteMasterJob() {} // 0x00000001827B2740-0x00000001827B28A0
		public void ForceCompleteAllJob() {} // 0x00000001827B1510-0x00000001827B1720
		internal int AddCloth(ClothProcess cprocess, [IsReadOnly] in ClothParameters clothParams) => default; // 0x0000000182700F80-0x00000001827011B0
		internal void RemoveCloth(ClothProcess cprocess) {} // 0x0000000183212CD0-0x0000000183212DD0
		private void OnEarlyClothUpdate() {} // 0x00000001823156B0-0x00000001823159A0
		private void OnAfterUpdate() {} // 0x00000001830ADEE0-0x00000001830AE010
		private void OnApplicationQuit() {} // 0x00000001854CBB18-0x00000001854CBB68
		private void OnBeforeLateUpdate() {} // 0x00000001830BA5F0-0x00000001830BA6D0
		private void OnAfterLateUpdate() {} // 0x000000018281B5F0-0x000000018281B6E0
		private void ClothUpdate() {} // 0x0000000182819760-0x000000018281B330
		internal void ClearVisibleDict() {} // 0x00000001827AF090-0x00000001827AF220
		internal bool CheckVisible(Animator ani, List<Renderer> renderers) => default; // 0x00000001827AF220-0x00000001827AF3A0
		internal bool CheckLODVisible(Animator ani, int clothAnimatorAbilityLODThresholdProperty, int clothAnimatorLODThresholdProperty) => default; // 0x00000001827AFC70-0x00000001827AFEA0
		private bool CheckRendererVisible(List<Renderer> renderers) => default; // 0x00000001827AF3A0-0x00000001827AFC30
		public void InformationLog(StringBuilder allsb) {} // 0x00000001854CBA78-0x00000001854CBACC
	}

	public class PreBuildManager : IManager, IValid // TypeDefIndex: 44878
	{
		// Fields
		private Dictionary<SharePreBuildData, ShareDeserializationData> deserializationDict; // 0x10
		private bool isValid; // 0x18
		private static readonly ProfilerMarker deserializationProfiler; // 0x00
	
		// Nested types
		internal class ShareDeserializationData : IDisposable // TypeDefIndex: 44877
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
			public int RenderMeshCount { get => default; } // 0x00000001854D13AC-0x00000001854D13E4 
	
			// Constructors
			public ShareDeserializationData() {} // 0x0000000182E1A340-0x0000000182E1A410
	
			// Methods
			public void Dispose() {} // 0x00000001854D0D84-0x00000001854D1230
			public void Deserialize(SharePreBuildData sharePreBuilddata) {} // 0x0000000182E1C300-0x0000000182E1CBA0
			public VirtualMeshContainer GetProxyMeshContainer() => default; // 0x00000001854D1230-0x00000001854D12CC
			public VirtualMeshContainer GetRenderMeshContainer(int index) => default; // 0x00000001854D12CC-0x00000001854D13AC
		}
	
		// Constructors
		public PreBuildManager() {} // 0x0000000182ECB040-0x0000000182ECB0C0
		static PreBuildManager() {} // 0x0000000183D06DD0-0x0000000183D06E30
	
		// Methods
		public void Dispose() {} // 0x00000001854CF030-0x00000001854CF1E0
		public void EnterdEditMode() {} // 0x00000001854CF1E0-0x00000001854CF230
		public void Initialize() {} // 0x0000000182ECAE90-0x0000000182ECAEC0
		public bool IsValid() => default; // 0x00000001854CF6E8-0x00000001854CF734
		public void InformationLog(StringBuilder allsb) {} // 0x00000001854CF230-0x00000001854CF6E8
		internal ShareDeserializationData RegisterPreBuildData(SharePreBuildData sdata, bool referenceIncrement) => default; // 0x0000000182E1C0E0-0x0000000182E1C230
		internal ShareDeserializationData GetPreBuildData(SharePreBuildData sdata) => default; // 0x0000000182E1C040-0x0000000182E1C0E0
		internal void UnregisterPreBuildData(SharePreBuildData sdata) {} // 0x0000000182E19630-0x0000000182E196E0
		internal void UnloadUnusedData() {} // 0x00000001830CC9D0-0x00000001830CCD70
	}

	public struct DoAllInOneJob : IJob // TypeDefIndex: 44879
	{
		// Fields
		public GCHandle bmHandle; // 0x00
		public GCHandle tmHandle; // 0x08
		public GCHandle vmHandle; // 0x10
		public GCHandle smHandle; // 0x18
		public GCHandle wmHandle; // 0x20
		public GCHandle meshClothSetHandle; // 0x28
	
		// Methods
		public void Execute() {} // 0x00000001854CCC70-0x00000001854CD36C
	}

	public interface ICrossFrameParallelForJob : IJob // TypeDefIndex: 44880
	{
		// Methods
		void SetIndexCount(int indexCount);
	}

	public interface ICrossFrameParallelForDeferJob : IJob // TypeDefIndex: 44881
	{
		// Methods
		void SetIndexCount(NativeReference<int> indexCount);
	}

	public interface IUnsafeJob // TypeDefIndex: 44882
	{
		// Methods
		void UnsafeDo();
	}

	public static class CrossFrameJobUtils // TypeDefIndex: 44883
	{
		// Fields
		public static int s_MainThreadId; // 0x00
	
		// Methods
		public static JobHandle ScheduleNoUseRun<T>(ref ref T jobData, JobHandle dependsOn = default)
			where T : struct, IJob => default;
		public static JobHandle Schedule2<T>(ref ref T jobData, JobHandle dependsOn = default)
			where T : struct, IUnsafeJob, IJob => default;
		public static JobHandle Schedule<T>(ref ref T jobData, JobHandle dependsOn = default)
			where T : struct, IJob => default;
		public static JobHandle Schedule<T>(ref ref T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelFor, ICrossFrameParallelForJob => default;
		public static JobHandle Schedule2<T>(ref ref T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob => default;
		public static unsafe JobHandle Schedule2<T>(ref ref T jobData, int* forEachCount, NativeReference<int> forEachCountRef, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob => default;
		public static unsafe JobHandle Schedule<T>(ref ref T jobData, int* forEachCount, NativeReference<int> forEachCountRef, int innerloopBatchCount, JobHandle dependsOn = default)
			where T : struct, IJobParallelForDefer, ICrossFrameParallelForDeferJob => default;
	}

	public class DynamicBoneTransformManager : IManager, IValid // TypeDefIndex: 44903
	{
		// Fields
		internal const byte Flag_Read = 1; // Metadata: 0x01FB92EA
		internal const byte Flag_WorldRotWrite = 2; // Metadata: 0x01FB92EB
		internal const byte Flag_LocalPosRotWrite = 4; // Metadata: 0x01FB92EC
		internal const byte Flag_Restore = 8; // Metadata: 0x01FB92ED
		internal const byte Flag_Enable = 16; // Metadata: 0x01FB92EE
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
		internal int Count { get => default; } // 0x0000000182DC6220-0x0000000182DC6260 
	
		// Nested types
		[BurstCompile]
		private static class WriteAnimatorBufferDataJobKernels // TypeDefIndex: 44888
		{
			// Nested types
			public unsafe delegate void WriteAnimatorBufferDataKernel_0000025C_PostfixBurstDelegate(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 44884; 0x0000000185007C94-0x0000000185007D14
	
			internal static class WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall // TypeDefIndex: 44885
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall() {} // 0x0000000183CE8E50-0x0000000183CE8E60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005f9e0) {} // 0x00000001854EA00C-0x00000001854EA110
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854EA110-0x00000001854EA164
				public static void Constructor() {} // 0x0000000183CE8E60-0x0000000183CE8EF0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001854EA164-0x00000001854EA2D4
			}
	
			public unsafe delegate void WriteAnimatorBufferDataRangeKernel_0000025D_PostfixBurstDelegate(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 44886; 0x0000000185007C94-0x0000000185007D14
	
			internal static class WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall // TypeDefIndex: 44887
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall() {} // 0x0000000183CE8DB0-0x0000000183CE8DC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fa07) {} // 0x00000001854EA480-0x00000001854EA584
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854EA584-0x00000001854EA5D8
				public static void Constructor() {} // 0x0000000183CE8DC0-0x0000000183CE8E50
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001854EA5D8-0x00000001854EA740
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteAnimatorBufferDataKernel(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001854E937C-0x00000001854E944C
			[BurstCompile]
			internal static unsafe void WriteAnimatorBufferDataRangeKernel(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001854E944C-0x00000001854E951C
			[BurstCompile]
			public static unsafe void WriteAnimatorBufferDataKernel_BurstManaged(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001854E8B14-0x00000001854E937C
			[BurstCompile]
			public static unsafe void WriteAnimatorBufferDataRangeKernel_BurstManaged(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001854DC330-0x00000001854DC424
		}
	
		[BurstCompile]
		private struct ReadAnimatorBufferDataJob : IJobCrossFrameTransform // TypeDefIndex: 44889
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
			public void Execute(int index, TransformAccess transform) {} // 0x00000001854E2174-0x00000001854E2204
			private void _Do(int index, TransformAccess transform) {} // 0x00000001854E2204-0x00000001854E2C1C
		}
	
		[BurstCompile]
		private struct WriteAnimatorBufferDataJob : IJob, IUnsafeJob // TypeDefIndex: 44890
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
			public void Execute() {} // 0x00000001854E951C-0x00000001854E9E84
			public void UnsafeDo() {} // 0x00000001854E9E84-0x00000001854EA00C
		}
	
		[BurstCompile]
		private struct CopyDoubleBufferJob : IJob // TypeDefIndex: 44891
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
			public void Execute() {} // 0x00000001854E1884-0x00000001854E19A8
		}
	
		[BurstCompile]
		private struct EnableTransformJob : IJob // TypeDefIndex: 44892
		{
			// Fields
			public DataChunk chunk; // 0x00
			public bool sw; // 0x08
			public NativeArray<ExBitFlag8> flagList; // 0x10
	
			// Methods
			public void Execute() {} // 0x00000001854E19A8-0x00000001854E1A30
		}
	
		[BurstCompile]
		private struct RestoreTransformJob : IJobParallelForTransform // TypeDefIndex: 44893
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
			public void Execute(int index, TransformAccess transform) {} // 0x00000001854E33B0-0x00000001854E35B0
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 44894
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
			public void Execute(int index, TransformAccess transform) {} // 0x00000001854E2CE8-0x00000001854E33B0
		}
	
		[BurstCompile]
		public static class ValidTransformKernels // TypeDefIndex: 44899
		{
			// Nested types
			public unsafe delegate void ValidateTransformKernel_00000266_PostfixBurstDelegate(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 44895; 0x00000001854BD60C-0x00000001854BD620
	
			internal static class ValidateTransformKernel_00000266_BurstDirectCall // TypeDefIndex: 44896
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ValidateTransformKernel_00000266_BurstDirectCall() {} // 0x0000000183CE9210-0x0000000183CE9220
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fa44) {} // 0x00000001854E8450-0x00000001854E8554
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854E8554-0x00000001854E85A8
				public static void Constructor() {} // 0x0000000183CE9220-0x0000000183CE92B0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001854E85A8-0x00000001854E867C
			}
	
			public unsafe delegate void ValidateTransformRangeKernel_00000267_PostfixBurstDelegate(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 44897; 0x00000001854BD60C-0x00000001854BD620
	
			internal static class ValidateTransformRangeKernel_00000267_BurstDirectCall // TypeDefIndex: 44898
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ValidateTransformRangeKernel_00000267_BurstDirectCall() {} // 0x0000000183CE9170-0x0000000183CE9180
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fa5c) {} // 0x00000001854E8808-0x00000001854E890C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854E890C-0x00000001854E8960
				public static void Constructor() {} // 0x0000000183CE9180-0x0000000183CE9210
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001854E8960-0x00000001854E8A5C
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void ValidateTransformKernel(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001854E82C0-0x00000001854E8348
			[BurstCompile]
			public static unsafe void ValidateTransformRangeKernel(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001854E83C8-0x00000001854E8450
			[BurstCompile]
			public static unsafe void ValidateTransformKernel_BurstManaged(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001854DB820-0x00000001854DC330
			[BurstCompile]
			public static unsafe void ValidateTransformRangeKernel_BurstManaged(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001854E8348-0x00000001854E83C8
		}
	
		[BurstCompile]
		private struct ValidTransformJob : IJob, IUnsafeJob // TypeDefIndex: 44900
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
			public void SetIndexCount(int indexCount) {} // 0x000000018307A6E0-0x000000018307A720
			[IDTag(1)]
			public void Execute() {} // 0x00000001854E813C-0x00000001854E81A8
			public void UnsafeDo() {} // 0x00000001854E81FC-0x00000001854E82C0
			[IDTag(0)]
			public void Execute(int index) {} // 0x00000001854E81A8-0x00000001854E81FC
		}
	
		[BurstCompile]
		private struct WriteTransformJob : IJobParallelForTransform // TypeDefIndex: 44901
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
			public void Execute(int index, TransformAccess transform) {} // 0x00000001854EA818-0x00000001854EE3D8
		}
	
		[BurstCompile]
		private struct ReadComponentTransformJob : IJobParallelForTransform // TypeDefIndex: 44902
		{
			// Fields
			[WriteOnly]
			public NativeArray<float3> positionArray; // 0x00
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001854E2C1C-0x00000001854E2CE8
		}
	
		// Constructors
		public DynamicBoneTransformManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public JobHandle WriteAnimatorBufferData(JobHandle jobHandle, ref NativeParallelHashMap<int, int> teamId2AnimatorInstnceId, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler, ref NativeParallelHashMap<int, int> transformID2RWHandlerID) => default; // 0x00000001854CE6B8-0x00000001854CE97C
		public JobHandle ReadAnimatorBufferData(JobHandle jobHandle, ref NativeParallelHashMap<int, int> teamId2AnimatorInstnceId, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler, ref NativeParallelHashMap<int, int> transformID2RWHandlerID) => default; // 0x00000001854CE3AC-0x00000001854CE6B8
		public JobHandle CopyDoubleBuffer(JobHandle jobHandle) => default; // 0x000000018306BE20-0x000000018306BFE0
		public JobHandle WriteDoubleBufferTransform(JobHandle jobHandle) => default; // 0x0000000182DC59A0-0x0000000182DC5C50
		public void Dispose() {} // 0x0000000182F5DA30-0x0000000182F5DC80
		public void EnterdEditMode() {} // 0x00000001854CD8D8-0x00000001854CD928
		public void Initialize() {} // 0x00000001834DFBD0-0x00000001834E0070
		public bool IsValid() => default; // 0x00000001854CE35C-0x00000001854CE3AC
		[IDTag(0)]
		internal DataChunk AddTransform(VirtualMeshContainer cmesh, int teamId) => default; // 0x0000000182702960-0x0000000182702D20
		[IDTag(1)]
		internal DataChunk AddTransform(int count, int teamId) => default; // 0x00000001827024B0-0x00000001827027A0
		[IDTag(2)]
		internal DataChunk AddTransform(Transform t, ExBitFlag8 flag, int teamId) => default; // 0x00000001854CD36C-0x00000001854CD8D8
		internal void SetTransform(Transform t, ExBitFlag8 flag, int index, int teamId) {} // 0x0000000182B9FD30-0x0000000182BA02F0
		internal void CopyTransform(int fromIndex, int toIndex) {} // 0x0000000183212DD0-0x00000001832130D0
		internal void RemoveTransform(DataChunk c) {} // 0x0000000183211470-0x00000001832116F0
		[IDTag(1)]
		internal void EnableTransform(DataChunk c, bool sw) {} // 0x00000001827AEEE0-0x00000001827AEFB0
		[IDTag(0)]
		internal void EnableTransform(int index, bool sw) {} // 0x0000000182BA2620-0x0000000182BA26D0
		internal DataChunk Expand(DataChunk c, int newLength) => default; // 0x00000001854CD928-0x00000001854CDC68
		public JobHandle RestoreTransform(JobHandle jobHandle) => default; // 0x0000000182DC5C50-0x0000000182DC5EE0
		public JobHandle ReadTransform(JobHandle jobHandle) => default; // 0x0000000182DC5EE0-0x0000000182DC6220
		public JobHandle WriteTransform(JobHandle jobHandle) => default; // 0x00000001854CE97C-0x00000001854CEBA4
		public JobHandle ValidPosition(JobHandle jobHandle) => default; // 0x000000018307A4E0-0x000000018307A6E0
		internal int AddComponentTransform(Transform t) => default; // 0x0000000182701980-0x0000000182701A70
		internal void RemoveComponentTransform(int index) {} // 0x0000000183212230-0x00000001832122C0
		internal JobHandle ReadComponentTransform(JobHandle jobHandle) => default; // 0x0000000182DC6510-0x0000000182DC6700
		public void InformationLog(StringBuilder allsb) {} // 0x00000001854CDC68-0x00000001854CE35C
		public static void Initialize_WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall() {} // 0x00000001835EB3A0-0x00000001835EB400
		public static void Initialize_WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall() {} // 0x00000001835EB400-0x00000001835EB460
	}

	public class TeamManager : IManager, IValid // TypeDefIndex: 44933
	{
		// Fields
		public const int Flag_Valid = 0; // Metadata: 0x01FB92EF
		public const int Flag_Enable = 1; // Metadata: 0x01FB92F0
		public const int Flag_Reset = 2; // Metadata: 0x01FB92F1
		public const int Flag_TimeReset = 3; // Metadata: 0x01FB92F2
		public const int Flag_SyncSuspend = 4; // Metadata: 0x01FB92F3
		public const int Flag_Running = 5; // Metadata: 0x01FB92F4
		public const int Flag_Synchronization = 6; // Metadata: 0x01FB92F5
		public const int Flag_StepRunning = 7; // Metadata: 0x01FB92F6
		public const int Flag_Exit = 8; // Metadata: 0x01FB92F7
		public const int Flag_KeepTeleport = 9; // Metadata: 0x01FB92F8
		public const int Flag_InertiaShift = 10; // Metadata: 0x01FB92F9
		public const int Flag_CameraCullingInvisible = 11; // Metadata: 0x01FB92FA
		public const int Flag_CameraCullingKeep = 12; // Metadata: 0x01FB92FB
		public const int Flag_Spring = 13; // Metadata: 0x01FB92FC
		public const int Flag_SkipWriting = 14; // Metadata: 0x01FB92FD
		public const int Flag_Anchor = 15; // Metadata: 0x01FB92FE
		public const int Flag_AnchorReset = 16; // Metadata: 0x01FB92FF
		public const int Flag_NegativeScale = 17; // Metadata: 0x01FB9300
		public const int Flag_NegativeScaleTeleport = 18; // Metadata: 0x01FB9301
		public const int Flag_DistanceCullingInvisible = 19; // Metadata: 0x01FB9302
		public const int Flag_RestoreTransformOnlyOnec = 20; // Metadata: 0x01FB9303
		public const int Flag_Tangent = 21; // Metadata: 0x01FB9304
		public const int Flag_Self_PointPrimitive = 32; // Metadata: 0x01FB9305
		public const int Flag_Self_EdgePrimitive = 33; // Metadata: 0x01FB9306
		public const int Flag_Self_TrianglePrimitive = 34; // Metadata: 0x01FB9307
		public const int Flag_Self_EdgeEdge = 35; // Metadata: 0x01FB9308
		public const int Flag_Sync_EdgeEdge = 36; // Metadata: 0x01FB9309
		public const int Flag_PSync_EdgeEdge = 37; // Metadata: 0x01FB930A
		public const int Flag_Self_PointTriangle = 38; // Metadata: 0x01FB930B
		public const int Flag_Sync_PointTriangle = 39; // Metadata: 0x01FB930C
		public const int Flag_PSync_PointTriangle = 40; // Metadata: 0x01FB930D
		public const int Flag_Self_TrianglePoint = 41; // Metadata: 0x01FB930E
		public const int Flag_Sync_TrianglePoint = 42; // Metadata: 0x01FB930F
		public const int Flag_PSync_TrianglePoint = 43; // Metadata: 0x01FB9310
		public const int Flag_Self_EdgeTriangleIntersect = 44; // Metadata: 0x01FB9311
		public const int Flag_Sync_EdgeTriangleIntersect = 45; // Metadata: 0x01FB9312
		public const int Flag_PSync_EdgeTriangleIntersect = 46; // Metadata: 0x01FB9313
		public const int Flag_Self_TriangleEdgeIntersect = 47; // Metadata: 0x01FB9314
		public const int Flag_Sync_TriangleEdgeIntersect = 48; // Metadata: 0x01FB9315
		public const int Flag_PSync_TriangleEdgeIntersect = 49; // Metadata: 0x01FB9316
		public const int Flag_Lod_LodOut = 60; // Metadata: 0x01FB9317
		public const int Flag_Lod_Culled = 61; // Metadata: 0x01FB9318
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
		public int MappingCount { get => default; } // 0x00000001832FA730-0x00000001832FA770 
		public int TeamCount { get => default; } // 0x0000000182C4CDC0-0x0000000182C4CE00 
		public int TrueTeamCount { get => default; } // 0x00000001823159A0-0x00000001823159F0 
		public int ActiveTeamCount { get => default; } // 0x000000018281B4D0-0x000000018281B510 
	
		// Nested types
		[BurstCompile]
		public static class SimulationStepTeamUpdateKernels // TypeDefIndex: 44912
		{
			// Nested types
			public unsafe delegate void SimulationStepTeamUpdateKernel_00000294_PostfixBurstDelegate(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // TypeDefIndex: 44904; 0x00000001854E38D0-0x00000001854E38E4
	
			internal static class SimulationStepTeamUpdateKernel_00000294_BurstDirectCall // TypeDefIndex: 44905
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SimulationStepTeamUpdateKernel_00000294_BurstDirectCall() {} // 0x0000000183CEA890-0x0000000183CEA8A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005facb) {} // 0x00000001854E35B0-0x00000001854E36B4
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854E36B4-0x00000001854E3708
				public static void Constructor() {} // 0x0000000183CEA8A0-0x0000000183CEA930
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId) {} // 0x00000001854E3708-0x00000001854E3804
			}
	
			public unsafe delegate void SimulationStepTeamUpdateRangeKernel_00000295_PostfixBurstDelegate(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // TypeDefIndex: 44906; 0x00000001854E38D0-0x00000001854E38E4
	
			internal static class SimulationStepTeamUpdateRangeKernel_00000295_BurstDirectCall // TypeDefIndex: 44907
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SimulationStepTeamUpdateRangeKernel_00000295_BurstDirectCall() {} // 0x0000000183CEA7F0-0x0000000183CEA800
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fae6) {} // 0x00000001854E4C58-0x00000001854E4D5C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854E4D5C-0x00000001854E4DB0
				public static void Constructor() {} // 0x0000000183CEA800-0x0000000183CEA890
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length) {} // 0x00000001854E4DB0-0x00000001854E4EA4
			}
	
			public unsafe delegate void UpdateWind_00000296_PostfixBurstDelegate(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // TypeDefIndex: 44908; 0x00000001854BD60C-0x00000001854BD620
	
			internal static class UpdateWind_00000296_BurstDirectCall // TypeDefIndex: 44909
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateWind_00000296_BurstDirectCall() {} // 0x0000000183CE92B0-0x0000000183CE92C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005faff) {} // 0x00000001854E7D28-0x00000001854E7E2C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854E7E2C-0x00000001854E7E80
				public static void Constructor() {} // 0x0000000183CE92C0-0x0000000183CE9350
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime) {} // 0x00000001854E7E80-0x00000001854E7F58
			}
	
			public delegate void UpdateWindTime_00000297_PostfixBurstDelegate(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // TypeDefIndex: 44910; 0x00000001850C35B4-0x00000001850C35C8
	
			internal static class UpdateWindTime_00000297_BurstDirectCall // TypeDefIndex: 44911
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateWindTime_00000297_BurstDirectCall() {} // 0x0000000183CE9350-0x0000000183CE9360
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fb11) {} // 0x00000001854E79B4-0x00000001854E7AB8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854E7AB8-0x00000001854E7B0C
				public static void Constructor() {} // 0x0000000183CE9360-0x0000000183CE93F0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static void Invoke(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime) {} // 0x00000001854E7B0C-0x00000001854E7BA8
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateKernel(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId) {} // 0x00000001854E470C-0x00000001854E47A4
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateRangeKernel(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length) {} // 0x00000001854E47A4-0x00000001854E483C
			[BurstCompile]
			private static unsafe void UpdateWind(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime) {} // 0x00000001854E4BD0-0x00000001854E4C58
			[BurstCompile]
			private static void UpdateWindTime(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime) {} // 0x00000001854E483C-0x00000001854E48A0
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateKernel_BurstManaged(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId) {} // 0x00000001854E39AC-0x00000001854E470C
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateRangeKernel_BurstManaged(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length) {} // 0x00000001854DB400-0x00000001854DB494
			[BurstCompile]
			public static unsafe void UpdateWind_BurstManaged(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime) {} // 0x00000001854E48A0-0x00000001854E4BD0
			[BurstCompile]
			public static void UpdateWindTime_BurstManaged(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime) {} // 0x00000001854DB494-0x00000001854DB820
		}
	
		[BurstCompile]
		private static class PostTeamUpdateJobKernels // TypeDefIndex: 44917
		{
			// Nested types
			public unsafe delegate void PostTeamUpdateKernel_00000298_PostfixBurstDelegate(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // TypeDefIndex: 44913; 0x00000001811360D0-0x00000001811360F0
	
			internal static class PostTeamUpdateKernel_00000298_BurstDirectCall // TypeDefIndex: 44914
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostTeamUpdateKernel_00000298_BurstDirectCall() {} // 0x0000000183CEAD90-0x0000000183CEADA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fb2c) {} // 0x00000001854E1B90-0x00000001854E1C94
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854E1C94-0x00000001854E1CE8
				public static void Constructor() {} // 0x0000000183CEADA0-0x0000000183CEAE30
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId) {} // 0x00000001854E1CE8-0x00000001854E1D84
			}
	
			public unsafe delegate void PostTeamUpdateRangeKernel_00000299_PostfixBurstDelegate(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // TypeDefIndex: 44915; 0x00000001811360D0-0x00000001811360F0
	
			internal static class PostTeamUpdateRangeKernel_00000299_BurstDirectCall // TypeDefIndex: 44916
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostTeamUpdateRangeKernel_00000299_BurstDirectCall() {} // 0x0000000183CEACF0-0x0000000183CEAD00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fb3b) {} // 0x00000001854E1EE0-0x00000001854E1FE4
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854E1FE4-0x00000001854E2038
				public static void Constructor() {} // 0x0000000183CEAD00-0x0000000183CEAD90
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x00000001854E2038-0x00000001854E20EC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PostTeamUpdateKernel(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId) {} // 0x00000001854E1A80-0x00000001854E1AE0
			[BurstCompile]
			internal static unsafe void PostTeamUpdateRangeKernel(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x00000001854E1B30-0x00000001854E1B90
			[BurstCompile]
			public static unsafe void PostTeamUpdateKernel_BurstManaged(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId) {} // 0x00000001854D9EB8-0x00000001854DB400
			[BurstCompile]
			public static unsafe void PostTeamUpdateRangeKernel_BurstManaged(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x00000001854E1AE0-0x00000001854E1B30
		}
	
		public struct TeamData // TypeDefIndex: 44918
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
			public float clothSimulateWeight; // 0xEC
			public float clothLodFadeWeight; // 0xF0
			public float clothLodFadeTime; // 0xF4
			public float velocityWeight; // 0xF8
			public float distanceWeight; // 0xFC
			public float blendWeight; // 0x100
			public ClothForceMode forceMode; // 0x104
			public float3 impactForce; // 0x108
			public VirtualMesh.MeshType proxyMeshType; // 0x114
			public DataChunk proxyTransformChunk; // 0x118
			public DataChunk proxyCommonChunk; // 0x120
			public DataChunk proxyVertexChildDataChunk; // 0x128
			public DataChunk proxyTriangleChunk; // 0x130
			public DataChunk proxyEdgeChunk; // 0x138
			public DataChunk proxyMeshChunk; // 0x140
			public DataChunk proxyBoneChunk; // 0x148
			public DataChunk proxySkinBoneChunk; // 0x150
			public DataChunk baseLineChunk; // 0x158
			public DataChunk baseLineDataChunk; // 0x160
			public DataChunk fixedDataChunk; // 0x168
			public DataChunk particleChunk; // 0x170
			public DataChunk colliderChunk; // 0x178
			public DataChunk colliderTransformChunk; // 0x180
			public int colliderCount; // 0x188
			public DataChunk distanceStartChunk; // 0x18C
			public DataChunk distanceDataChunk; // 0x194
			public DataChunk bendingPairChunk; // 0x19C
			public DataChunk bendingWriteIndexChunk; // 0x1A4
			public DataChunk bendingBufferChunk; // 0x1AC
			public DataChunk selfPointChunk; // 0x1B4
			public DataChunk selfEdgeChunk; // 0x1BC
			public DataChunk selfTriangleChunk; // 0x1C4
	
			// Properties
			public bool bUseRelativeTransform { get => default; } // 0x00000001854E5090-0x00000001854E509C 
			public bool IsFixedUpdate { get => default; } // 0x00000001854E4FAC-0x00000001854E4FB4 
			public bool IsUnscaled { get => default; } // 0x00000001854E5088-0x00000001854E5090 
			public bool IsValid { get => default; } // 0x0000000184275E20-0x0000000184275E28 
			public bool IsEnable { get => default; } // 0x00000001835229C0-0x0000000183522A10 
			public bool IsLODCulled { get => default; } // 0x00000001842764E8-0x00000001842764FC 
			public bool IsProcess { get => default; } // 0x00000001854E4FE4-0x00000001854E5054 
			public bool IsReset { get => default; } // 0x00000001854E5054-0x00000001854E505C 
			public bool IsKeepReset { get => default; } // 0x00000001854E4FC0-0x00000001854E4FCC 
			public bool IsInertiaShift { get => default; } // 0x00000001854E4FB4-0x00000001854E4FC0 
			public bool IsRunning { get => default; } // 0x00000001854E505C-0x00000001854E5064 
			public bool IsStepRunning { get => default; } // 0x00000001854E5070-0x00000001854E507C 
			public bool IsCameraCullingInvisible { get => default; } // 0x00000001854E4F70-0x00000001854E4F7C 
			public bool IsCameraCullingKeep { get => default; } // 0x00000001854E4F7C-0x00000001854E4F88 
			public bool IsDistanceCullingInvisible { get => default; } // 0x00000001854E4FA0-0x00000001854E4FAC 
			public bool IsCullingInvisible { get => default; } // 0x00000001854E4F88-0x00000001854E4FA0 
			public bool IsSpring { get => default; } // 0x00000001854E5064-0x00000001854E5070 
			public bool IsNegativeScale { get => default; } // 0x00000001854E4FD8-0x00000001854E4FE4 
			public bool IsNegativeScaleTeleport { get => default; } // 0x00000001854E4FCC-0x00000001854E4FD8 
			public bool IsTangent { get => default; } // 0x00000001854E507C-0x00000001854E5088 
			public int ParticleCount { get => default; } // 0x0000000183D4FC30-0x0000000183D4FC40 
			public int ColliderCount { get => default; } // 0x0000000183D4FC10-0x0000000183D4FC20 
			public int BaseLineCount { get => default; } // 0x0000000183D4FC00-0x0000000183D4FC10 
			public int TriangleCount { get => default; } // 0x0000000183D4FC40-0x0000000183D4FC50 
			public int EdgeCount { get => default; } // 0x0000000183D4FC20-0x0000000183D4FC30 
			public float InitScale { get => default; } // 0x0000000183D4F670-0x0000000183D4F680 
		}
	
		public struct MappingData : IValid // TypeDefIndex: 44919
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
			public int VertexCount { get => default; } // 0x0000000183D4FBF0-0x0000000183D4FC00 
	
			// Methods
			public bool IsValid() => default; // 0x00000001854E1A30-0x00000001854E1A80
		}
	
		[BurstCompile]
		private struct AlwaysTeamUpdatePreJob : IJob // TypeDefIndex: 44920
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
			public void Execute() {} // 0x00000001854DCFBC-0x00000001854DE93C
		}
	
		[BurstCompile]
		private struct AlwaysTeamUpdatePostJob : IJob // TypeDefIndex: 44921
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
			public void Execute() {} // 0x00000001854DC6C0-0x00000001854DCFBC
			private void DistanceCullingUpdate(int teamId, ref TeamData tdata) {} // 0x00000001854DC424-0x00000001854DC6C0
		}
	
		[BurstCompile]
		public static class CalcCenterAndInertiaAndWindKernels // TypeDefIndex: 44928
		{
			// Nested types
			public unsafe delegate void CalcCenterAndInertiaAndWindKernel_000002B9_PostfixBurstDelegate(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // TypeDefIndex: 44922; 0x00000001854F4F6C-0x00000001854F5020
	
			internal static class CalcCenterAndInertiaAndWindKernel_000002B9_BurstDirectCall // TypeDefIndex: 44923
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcCenterAndInertiaAndWindKernel_000002B9_BurstDirectCall() {} // 0x0000000183CECA50-0x0000000183CECA60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fbac) {} // 0x00000001854F4B10-0x00000001854F4C14
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F4C14-0x00000001854F4C68
				public static void Constructor() {} // 0x0000000183CECA60-0x0000000183CECAF0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId) {} // 0x00000001854F4C68-0x00000001854F4E48
			}
	
			public unsafe delegate void CalcCenterAndInertiaAndWindRangeKernel_000002BA_PostfixBurstDelegate(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // TypeDefIndex: 44924; 0x00000001854F4F6C-0x00000001854F5020
	
			internal static class CalcCenterAndInertiaAndWindRangeKernel_000002BA_BurstDirectCall // TypeDefIndex: 44925
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcCenterAndInertiaAndWindRangeKernel_000002BA_BurstDirectCall() {} // 0x0000000183CEC9B0-0x0000000183CEC9C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fbdf) {} // 0x00000001854F50E8-0x00000001854F51EC
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F51EC-0x00000001854F5240
				public static void Constructor() {} // 0x0000000183CEC9C0-0x0000000183CECA50
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length) {} // 0x00000001854F5240-0x00000001854F541C
			}
	
			public unsafe delegate void Wind_000002BB_PostfixBurstDelegate(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // TypeDefIndex: 44926; 0x00000001854BD60C-0x00000001854BD620
	
			internal static class Wind_000002BB_BurstDirectCall // TypeDefIndex: 44927
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Wind_000002BB_BurstDirectCall() {} // 0x0000000183CE9030-0x0000000183CE9040
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fc00) {} // 0x00000001854FF2A4-0x00000001854FF3A8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854FF3A8-0x00000001854FF3FC
				public static void Constructor() {} // 0x0000000183CE9040-0x0000000183CE90D0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray) {} // 0x00000001854FF3FC-0x00000001854FF4CC
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindKernel(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId) {} // 0x00000001854E0DEC-0x00000001854E0EF4
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindRangeKernel(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length) {} // 0x00000001854E1008-0x00000001854E1110
			[BurstCompile]
			public static unsafe void Wind(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray) {} // 0x00000001854E1800-0x00000001854E1884
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindKernel_BurstManaged(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId) {} // 0x00000001854DE93C-0x00000001854E0DEC
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindRangeKernel_BurstManaged(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length) {} // 0x00000001854E0EF4-0x00000001854E1008
			[BurstCompile]
			public static unsafe void Wind_BurstManaged(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray) {} // 0x00000001854E1110-0x00000001854E1800
		}
	
		[BurstCompile]
		private struct CalcCenterAndInertiaAndWindJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 44929
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
			public void SetIndexCount(int indexCount) {} // 0x000000018307E770-0x000000018307E7B0
			[IDTag(1)]
			public void Execute() {} // 0x00000001854F4194-0x00000001854F420C
			[IDTag(0)]
			public void Execute(int teamId) {} // 0x00000001854F1BE0-0x00000001854F4194
			private void Wind(int teamId, [IsReadOnly] in ClothParameters param, [IsReadOnly] in double3 centerWorldPos) {} // 0x00000001854F43B8-0x00000001854F4B10
			public void UnsafeDo() {} // 0x00000001854F420C-0x00000001854F43B8
		}
	
		[BurstCompile]
		private struct SimulationStepTeamUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 44930
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
			public void SetIndexCount(int indexCount) {} // 0x0000000182F82690-0x0000000182F82720
			[IDTag(1)]
			public void Execute() {} // 0x00000001854FCB50-0x00000001854FCBC4
			[IDTag(0)]
			public void Execute(int teamId) {} // 0x00000001854FBF94-0x00000001854FCB50
			private void UpdateWind(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata) {} // 0x00000001854FCD54-0x00000001854FD0CC
			private void UpdateWindTime(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime) {} // 0x00000001854FCC84-0x00000001854FCD54
			public void UnsafeDo() {} // 0x00000001854FCBC4-0x00000001854FCC84
		}
	
		[BurstCompile]
		private struct PostTeamUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 44931
		{
			// Fields
			public NativeArray<TeamData> teamDataArray; // 0x00
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x10
			[ReadOnly]
			public int _indexCount; // 0x20
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001830E4C90-0x00000001830E4CD0
			[IDTag(1)]
			public void Execute() {} // 0x00000001854FB694-0x00000001854FB708
			[IDTag(0)]
			public void Execute(int teamId) {} // 0x00000001854FB708-0x00000001854FBF10
			public void UnsafeDo() {} // 0x00000001854FBF10-0x00000001854FBF94
		}
	
		// Constructors
		public TeamManager() {} // 0x0000000182ECA0B0-0x0000000182ECA330
		static TeamManager() {} // 0x00000001839D0880-0x00000001839D0A80
	
		// Methods
		internal void UpdateTeamAnimatorData(ExNativeArray<short> teamIdArray, TransformAccessArray transformArray) {} // 0x00000001854E6B84-0x00000001854E79B4
		internal void ClearTeamAnimatorData(int teamId) {} // 0x0000000183212C40-0x0000000183212CD0
		internal void AddTeamAnimatorData(int teamId, ClothProcess cprocess) {} // 0x0000000182FB36C0-0x0000000182FB3850
		internal void AddAnimatorTransform(int teamId, Transform t) {} // 0x0000000182702DC0-0x0000000182702E70
		internal void MarkAnimatorTransformDirty(int teamId, Transform t) {} // 0x0000000183C90D80-0x0000000183C90E20
		public void Dispose() {} // 0x0000000182ECB1C0-0x0000000182ECB690
		public void EnterdEditMode() {} // 0x00000001854E5124-0x00000001854E5174
		public void Initialize() {} // 0x0000000182FB0050-0x0000000182FB0CD0
		public bool IsValid() => default; // 0x00000001854E69DC-0x00000001854E6A28
		internal int AddTeam(ClothProcess cprocess, ClothParameters clothParams) => default; // 0x00000001827011B0-0x0000000182701800
		internal void RemoveTeam(int teamId) {} // 0x0000000183212920-0x0000000183212C40
		public void SetEnable(int teamId, bool sw) {} // 0x00000001827AECF0-0x00000001827AEEE0
		public bool IsEnable(int teamId) => default; // 0x00000001827B1720-0x00000001827B1CE0
		internal void SetSkipWriting(int teamId, bool sw) {} // 0x00000001854E6AC4-0x00000001854E6B84
		public bool ContainsTeamData(int teamId) => default; // 0x000000018320F0C0-0x000000018320F140
		public ref TeamData GetTeamDataRef(int teamId) => ref _refReturnTypeForGetTeamDataRef; // 0x00000001827B1110-0x00000001827B1510
		private ref TeamData _refReturnTypeForGetTeamDataRef; // Dummy field
		public ref FixedList64Bytes<short> GetTeamMappingRef(int teamId) => ref _refReturnTypeForGetTeamMappingRef; // 0x00000001854E51FC-0x00000001854E5284
		private ref FixedList64Bytes<short> _refReturnTypeForGetTeamMappingRef; // Dummy field
		public ref ClothParameters GetParametersRef(int teamId) => ref _refReturnTypeForGetParametersRef; // 0x000000018362A5A0-0x000000018362A640
		private ref ClothParameters _refReturnTypeForGetParametersRef; // Dummy field
		internal ref InertiaConstraint.CenterData GetCenterDataRef(int teamId) => ref _refReturnTypeForGetCenterDataRef; // 0x00000001854E5174-0x00000001854E51FC
		private ref InertiaConstraint.CenterData _refReturnTypeForGetCenterDataRef; // Dummy field
		public ClothProcess GetClothProcess(int teamId) => default; // 0x000000018320F020-0x000000018320F0C0
		internal void CameraCullingPreProcess() {} // 0x00000001827B2EC0-0x00000001827B3FB0
		internal void CameraCullingPostProcess() {} // 0x00000001827AFF20-0x00000001827B0EC0
		internal void AlwaysTeamUpdate() {} // 0x00000001827B4040-0x00000001827B8110
		private void RemoveSyncParent(ref TeamData tdata, int parentTeamId) {} // 0x00000001854E6A28-0x00000001854E6AC4
		internal JobHandle CalcCenterAndInertiaAndWind(JobHandle jobHandle) => default; // 0x0000000182C4B080-0x0000000182C4B490
		internal JobHandle SimulationStepTeamUpdate(int updateIndex, JobHandle jobHandle) => default; // 0x0000000182C4C670-0x0000000182C4CA40
		internal JobHandle PostTeamUpdate(JobHandle jobHandle) => default; // 0x00000001830FDAB0-0x00000001830FDBE0
		internal void AddMonitoringProcess(ClothProcess cprocess) {} // 0x00000001854E509C-0x00000001854E5124
		internal void RemoveMonitoringProcess(ClothProcess cprocess) {} // 0x0000000182E197E0-0x0000000182E19870
		private void MonitoringProcess(bool force) {} // 0x0000000182ECC090-0x0000000182ECC860
		private void MonitoringProcessUpdate() {} // 0x0000000182ECBFF0-0x0000000182ECC090
		public void InformationLog(StringBuilder allsb) {} // 0x00000001854E5284-0x00000001854E69DC
		public static void Initialize_PostTeamUpdateJobKernels_PostTeamUpdateKernel_00000298_BurstDirectCall() {} // 0x00000001835EB460-0x00000001835EB4C0
		public static void Initialize_PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_00000299_BurstDirectCall() {} // 0x00000001835EB4C0-0x00000001835EB520
	}

	public class VirtualMeshManager : IManager, IValid // TypeDefIndex: 44993
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
		public int ProxyVertexCount { get => default; } // 0x0000000182C4C090-0x0000000182C4C0D0 
		public int ProxyTriangleCount { get => default; } // 0x0000000182C4C050-0x0000000182C4C090 
		public int ProxyEdgeCount { get => default; } // 0x00000001854FF22C-0x00000001854FF268 
		public int ProxyBaseLineCount { get => default; } // 0x0000000182C4C350-0x0000000182C4C390 
		public int ProxyLocalPositionCount { get => default; } // 0x00000001854FF268-0x00000001854FF2A4 
		public int MappingVertexCount { get => default; } // 0x00000001854FF1F0-0x00000001854FF22C 
	
		// Nested types
		[BurstCompile]
		public static class CalcProxyMeshSkinningKernels // TypeDefIndex: 44938
		{
			// Nested types
			public unsafe delegate void CalcProxyMeshSkinningKernel_000002E4_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // TypeDefIndex: 44934; 0x0000000185465864-0x000000018546590C
	
			internal static class CalcProxyMeshSkinningKernel_000002E4_BurstDirectCall // TypeDefIndex: 44935
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxyMeshSkinningKernel_000002E4_BurstDirectCall() {} // 0x0000000183CEC550-0x0000000183CEC560
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fc84) {} // 0x00000001854F7258-0x00000001854F735C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F735C-0x00000001854F73B0
				public static void Constructor() {} // 0x0000000183CEC560-0x0000000183CEC5F0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index) {} // 0x00000001854F73B0-0x00000001854F7570
			}
	
			public unsafe delegate void CalcProxyMeshSkinningRangeKernel_000002E5_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // TypeDefIndex: 44936; 0x0000000185465D9C-0x0000000185465E48
	
			internal static class CalcProxyMeshSkinningRangeKernel_000002E5_BurstDirectCall // TypeDefIndex: 44937
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxyMeshSkinningRangeKernel_000002E5_BurstDirectCall() {} // 0x0000000183CEC4B0-0x0000000183CEC4C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fcb4) {} // 0x00000001854F7864-0x00000001854F7968
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F7968-0x00000001854F79BC
				public static void Constructor() {} // 0x0000000183CEC4C0-0x0000000183CEC550
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr) {} // 0x00000001854F79BC-0x00000001854F7B84
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index) {} // 0x00000001854F7668-0x00000001854F7764
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr) {} // 0x00000001854F7764-0x00000001854F7864
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index) {} // 0x00000001854EE930-0x00000001854EEFD0
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr) {} // 0x00000001854EEFD0-0x00000001854EFF78
		}
	
		[BurstCompile]
		private static class CreatePostProxyMeshUpdateListJobKernels // TypeDefIndex: 44943
		{
			// Nested types
			public unsafe delegate void CreatePostProxyMeshUpdateListKernel_000002E6_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // TypeDefIndex: 44939; 0x00000001854674CC-0x0000000185467540
	
			internal static class CreatePostProxyMeshUpdateListKernel_000002E6_BurstDirectCall // TypeDefIndex: 44940
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreatePostProxyMeshUpdateListKernel_000002E6_BurstDirectCall() {} // 0x0000000183CEBE70-0x0000000183CEBE80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fd04) {} // 0x00000001854FAEB8-0x00000001854FAFBC
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854FAFBC-0x00000001854FB010
				public static void Constructor() {} // 0x0000000183CEBE80-0x0000000183CEBF10
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId) {} // 0x00000001854FB010-0x00000001854FB158
			}
	
			public unsafe delegate void CreatePostProxyMeshUpdateListRangeKernel_000002E7_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // TypeDefIndex: 44941; 0x00000001854674CC-0x0000000185467540
	
			internal static class CreatePostProxyMeshUpdateListRangeKernel_000002E7_BurstDirectCall // TypeDefIndex: 44942
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreatePostProxyMeshUpdateListRangeKernel_000002E7_BurstDirectCall() {} // 0x0000000183CEBDD0-0x0000000183CEBDE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fd28) {} // 0x00000001854FB2FC-0x00000001854FB400
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854FB400-0x00000001854FB454
				public static void Constructor() {} // 0x0000000183CEBDE0-0x0000000183CEBE70
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length) {} // 0x00000001854FB454-0x00000001854FB5C4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CreatePostProxyMeshUpdateListKernel(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId) {} // 0x00000001854FAC78-0x00000001854FAD3C
			[BurstCompile]
			internal static unsafe void CreatePostProxyMeshUpdateListRangeKernel(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length) {} // 0x00000001854FADF4-0x00000001854FAEB8
			[BurstCompile]
			public static unsafe void CreatePostProxyMeshUpdateListKernel_BurstManaged(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId) {} // 0x00000001854F04DC-0x00000001854F06E4
			[BurstCompile]
			public static unsafe void CreatePostProxyMeshUpdateListRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length) {} // 0x00000001854FAD3C-0x00000001854FADF4
		}
	
		[BurstCompile]
		private static class CalcLineNormalTangentJobKernels // TypeDefIndex: 44948
		{
			// Nested types
			public unsafe delegate void CalcLineNormalTangentKernel_000002E8_PostfixBurstDelegate(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // TypeDefIndex: 44944; 0x00000001854F635C-0x00000001854F642C
	
			internal static class CalcLineNormalTangentKernel_000002E8_BurstDirectCall // TypeDefIndex: 44945
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcLineNormalTangentKernel_000002E8_BurstDirectCall() {} // 0x0000000183CEC7D0-0x0000000183CEC7E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fd9e) {} // 0x00000001854F5EC8-0x00000001854F5FCC
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F5FCC-0x00000001854F6020
				public static void Constructor() {} // 0x0000000183CEC7E0-0x0000000183CEC870
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index) {} // 0x00000001854F6020-0x00000001854F6240
			}
	
			public unsafe delegate void CalcLineNormalTangentRangeKernel_000002E9_PostfixBurstDelegate(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // TypeDefIndex: 44946; 0x00000001854F6934-0x00000001854F6A04
	
			internal static class CalcLineNormalTangentRangeKernel_000002E9_BurstDirectCall // TypeDefIndex: 44947
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcLineNormalTangentRangeKernel_000002E9_BurstDirectCall() {} // 0x0000000183CEC730-0x0000000183CEC740
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fdd7) {} // 0x00000001854F6500-0x00000001854F6604
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F6604-0x00000001854F6658
				public static void Constructor() {} // 0x0000000183CEC740-0x0000000183CEC7D0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr) {} // 0x00000001854F6658-0x00000001854F6874
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcLineNormalTangentKernel(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index) {} // 0x00000001854F5C74-0x00000001854F5D9C
			[BurstCompile]
			internal static unsafe void CalcLineNormalTangentRangeKernel(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr) {} // 0x00000001854F5D9C-0x00000001854F5EC8
			[BurstCompile]
			public static unsafe void CalcLineNormalTangentKernel_BurstManaged(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index) {} // 0x00000001854F5540-0x00000001854F5C74
			[BurstCompile]
			public static unsafe void CalcLineNormalTangentRangeKernel_BurstManaged(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr) {} // 0x00000001854EE3D8-0x00000001854EE500
		}
	
		[BurstCompile]
		private static class WriteTransformDataJobKernels // TypeDefIndex: 44953
		{
			// Nested types
			public unsafe delegate void WriteTransformDataKernel_000002EA_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // TypeDefIndex: 44949; 0x000000018501D858-0x000000018501D8C0
	
			internal static class WriteTransformDataKernel_000002EA_BurstDirectCall // TypeDefIndex: 44950
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformDataKernel_000002EA_BurstDirectCall() {} // 0x0000000183CE8D10-0x0000000183CE8D20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fe24) {} // 0x00000001854FF86C-0x00000001854FF970
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854FF970-0x00000001854FF9C4
				public static void Constructor() {} // 0x0000000183CE8D20-0x0000000183CE8DB0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index) {} // 0x00000001854FF9C4-0x00000001854FFAF0
			}
	
			public unsafe delegate void WriteTransformDataRangeKernel_000002EB_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // TypeDefIndex: 44951; 0x000000018500A684-0x000000018500A6EC
	
			internal static class WriteTransformDataRangeKernel_000002EB_BurstDirectCall // TypeDefIndex: 44952
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformDataRangeKernel_000002EB_BurstDirectCall() {} // 0x0000000183CE8C70-0x0000000183CE8C80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fe45) {} // 0x00000001854FFBB0-0x00000001854FFCB4
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854FFCB4-0x00000001854FFD08
				public static void Constructor() {} // 0x0000000183CE8C80-0x0000000183CE8D10
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr) {} // 0x00000001854FFD08-0x00000001854FFE5C
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteTransformDataKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index) {} // 0x00000001854FF654-0x00000001854FF708
			[BurstCompile]
			internal static unsafe void WriteTransformDataRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr) {} // 0x00000001854FF7B4-0x00000001854FF86C
			[BurstCompile]
			public static unsafe void WriteTransformDataKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index) {} // 0x00000001854F1218-0x00000001854F18F8
			[BurstCompile]
			public static unsafe void WriteTransformDataRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr) {} // 0x00000001854FF708-0x00000001854FF7B4
		}
	
		[BurstCompile]
		private static class WriteTransformLocalDataJobKernels // TypeDefIndex: 44958
		{
			// Nested types
			public unsafe delegate void WriteTransformLocalDataKernel_000002EC_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // TypeDefIndex: 44954; 0x0000000185007C94-0x0000000185007D14
	
			internal static class WriteTransformLocalDataKernel_000002EC_BurstDirectCall // TypeDefIndex: 44955
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformLocalDataKernel_000002EC_BurstDirectCall() {} // 0x0000000183CE8BD0-0x0000000183CE8BE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fe96) {} // 0x0000000185500478-0x000000018550057C
				private static IntPtr GetFunctionPointer() => default; // 0x000000018550057C-0x00000001855005D0
				public static void Constructor() {} // 0x0000000183CE8BE0-0x0000000183CE8C70
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index) {} // 0x00000001855005D0-0x0000000185500738
			}
	
			public unsafe delegate void WriteTransformLocalDataRangeKernel_000002ED_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // TypeDefIndex: 44956; 0x0000000185500C44-0x0000000185500CC4
	
			internal static class WriteTransformLocalDataRangeKernel_000002ED_BurstDirectCall // TypeDefIndex: 44957
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformLocalDataRangeKernel_000002ED_BurstDirectCall() {} // 0x0000000183CE8B30-0x0000000183CE8B40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005febd) {} // 0x00000001855008E4-0x00000001855009E8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001855009E8-0x0000000185500A3C
				public static void Constructor() {} // 0x0000000183CE8B40-0x0000000183CE8BD0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr) {} // 0x0000000185500A3C-0x0000000185500BCC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteTransformLocalDataKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index) {} // 0x000000018550020C-0x00000001855002DC
			[BurstCompile]
			internal static unsafe void WriteTransformLocalDataRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr) {} // 0x00000001855003A8-0x0000000185500478
			[BurstCompile]
			public static unsafe void WriteTransformLocalDataKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index) {} // 0x00000001854FFE5C-0x000000018550020C
			[BurstCompile]
			public static unsafe void WriteTransformLocalDataRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr) {} // 0x00000001855002DC-0x00000001855003A8
		}
	
		[BurstCompile]
		private static class CalcProxySkinningJobKernels // TypeDefIndex: 44963
		{
			// Nested types
			public unsafe delegate void CalcProxySkinningKernel_000002EE_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // TypeDefIndex: 44959; 0x00000001854F90C8-0x00000001854F9188
	
			internal static class CalcProxySkinningKernel_000002EE_BurstDirectCall // TypeDefIndex: 44960
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxySkinningKernel_000002EE_BurstDirectCall() {} // 0x0000000183CEC410-0x0000000183CEC420
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005ff2e) {} // 0x00000001854F8C60-0x00000001854F8D64
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F8D64-0x00000001854F8DB8
				public static void Constructor() {} // 0x0000000183CEC420-0x0000000183CEC4B0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex) {} // 0x00000001854F8DB8-0x00000001854F8FB8
			}
	
			public unsafe delegate void CalcProxySkinningRangeKernel_000002EF_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // TypeDefIndex: 44961; 0x00000001854F90C8-0x00000001854F9188
	
			internal static class CalcProxySkinningRangeKernel_000002EF_BurstDirectCall // TypeDefIndex: 44962
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxySkinningRangeKernel_000002EF_BurstDirectCall() {} // 0x0000000183CEC370-0x0000000183CEC380
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005ff64) {} // 0x00000001854F925C-0x00000001854F9360
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F9360-0x00000001854F93B4
				public static void Constructor() {} // 0x0000000183CEC380-0x0000000183CEC410
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length) {} // 0x00000001854F93B4-0x00000001854F95AC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcProxySkinningKernel(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex) {} // 0x00000001854F8A30-0x00000001854F8B48
			[BurstCompile]
			internal static unsafe void CalcProxySkinningRangeKernel(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length) {} // 0x00000001854F8B48-0x00000001854F8C60
			[BurstCompile]
			public static unsafe void CalcProxySkinningKernel_BurstManaged(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex) {} // 0x00000001854F7B84-0x00000001854F8A30
			[BurstCompile]
			public static unsafe void CalcProxySkinningRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length) {} // 0x00000001854EFF78-0x00000001854F04DC
		}
	
		[BurstCompile]
		private static class CalcMeshConvertMatrixJobKernels // TypeDefIndex: 44968
		{
			// Nested types
			public unsafe delegate void CalcMeshConvertMatrixKernel_000002F0_PostfixBurstDelegate(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // TypeDefIndex: 44964; 0x00000001854BD60C-0x00000001854BD620
	
			internal static class CalcMeshConvertMatrixKernel_000002F0_BurstDirectCall // TypeDefIndex: 44965
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcMeshConvertMatrixKernel_000002F0_BurstDirectCall() {} // 0x0000000183CEC690-0x0000000183CEC6A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005ff9e) {} // 0x00000001854F6C68-0x00000001854F6D6C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F6D6C-0x00000001854F6DC0
				public static void Constructor() {} // 0x0000000183CEC6A0-0x0000000183CEC730
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index) {} // 0x00000001854F6DC0-0x00000001854F6E94
			}
	
			public unsafe delegate void CalcMeshConvertMatrixRangeKernel_000002F1_PostfixBurstDelegate(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // TypeDefIndex: 44966; 0x00000001854BD60C-0x00000001854BD620
	
			internal static class CalcMeshConvertMatrixRangeKernel_000002F1_BurstDirectCall // TypeDefIndex: 44967
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcMeshConvertMatrixRangeKernel_000002F1_BurstDirectCall() {} // 0x0000000183CEC5F0-0x0000000183CEC600
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005ffb6) {} // 0x00000001854F6F4C-0x00000001854F7050
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F7050-0x00000001854F70A4
				public static void Constructor() {} // 0x0000000183CEC600-0x0000000183CEC690
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length) {} // 0x00000001854F70A4-0x00000001854F71A0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcMeshConvertMatrixKernel(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index) {} // 0x00000001854F6AD8-0x00000001854F6B60
			[BurstCompile]
			internal static unsafe void CalcMeshConvertMatrixRangeKernel(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length) {} // 0x00000001854F6BE0-0x00000001854F6C68
			[BurstCompile]
			public static unsafe void CalcMeshConvertMatrixKernel_BurstManaged(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index) {} // 0x00000001854EE500-0x00000001854EE930
			[BurstCompile]
			public static unsafe void CalcMeshConvertMatrixRangeKernel_BurstManaged(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length) {} // 0x00000001854F6B60-0x00000001854F6BE0
		}
	
		[BurstCompile]
		private static class CalcTriangleNormalTangentJobKernels // TypeDefIndex: 44973
		{
			// Nested types
			public unsafe delegate void CalcTriangleNormalTangentKernel_000002F2_PostfixBurstDelegate(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // TypeDefIndex: 44969; 0x000000018501D858-0x000000018501D8C0
	
			internal static class CalcTriangleNormalTangentKernel_000002F2_BurstDirectCall // TypeDefIndex: 44970
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcTriangleNormalTangentKernel_000002F2_BurstDirectCall() {} // 0x0000000183CEC2D0-0x0000000183CEC2E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0005fff8) {} // 0x00000001854F9D14-0x00000001854F9E18
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854F9E18-0x00000001854F9E6C
				public static void Constructor() {} // 0x0000000183CEC2E0-0x0000000183CEC370
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index) {} // 0x00000001854F9E6C-0x00000001854F9F98
			}
	
			public unsafe delegate void CalcTriangleNormalTangentRangeKernel_000002F3_PostfixBurstDelegate(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // TypeDefIndex: 44971; 0x000000018500A684-0x000000018500A6EC
	
			internal static class CalcTriangleNormalTangentRangeKernel_000002F3_BurstDirectCall // TypeDefIndex: 44972
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcTriangleNormalTangentRangeKernel_000002F3_BurstDirectCall() {} // 0x0000000183CEC230-0x0000000183CEC240
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060019) {} // 0x00000001854FA12C-0x00000001854FA230
				private static IntPtr GetFunctionPointer() => default; // 0x00000001854FA230-0x00000001854FA284
				public static void Constructor() {} // 0x0000000183CEC240-0x0000000183CEC2D0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr) {} // 0x00000001854FA284-0x00000001854FA3D8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcTriangleNormalTangentKernel(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index) {} // 0x00000001854F9AFC-0x00000001854F9BB0
			[BurstCompile]
			internal static unsafe void CalcTriangleNormalTangentRangeKernel(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr) {} // 0x00000001854F9C5C-0x00000001854F9D14
			[BurstCompile]
			public static unsafe void CalcTriangleNormalTangentKernel_BurstManaged(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index) {} // 0x00000001854F96BC-0x00000001854F9AFC
			[BurstCompile]
			public static unsafe void CalcTriangleNormalTangentRangeKernel_BurstManaged(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr) {} // 0x00000001854F9BB0-0x00000001854F9C5C
		}
	
		[BurstCompile]
		private static class CalcVertexNormalTangentFromTriangleJobKernels // TypeDefIndex: 44978
		{
			// Nested types
			public unsafe delegate void CalcVertexNormalTangentFromTriangleKernel_000002F4_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // TypeDefIndex: 44974; 0x000000018501D858-0x000000018501D8C0
	
			internal static class CalcVertexNormalTangentFromTriangleKernel_000002F4_BurstDirectCall // TypeDefIndex: 44975
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcVertexNormalTangentFromTriangleKernel_000002F4_BurstDirectCall() {} // 0x0000000183CEC190-0x0000000183CEC1A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006005e) {} // 0x00000001855056C8-0x00000001855057CC
				private static IntPtr GetFunctionPointer() => default; // 0x00000001855057CC-0x0000000185505820
				public static void Constructor() {} // 0x0000000183CEC1A0-0x0000000183CEC230
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index) {} // 0x0000000185505820-0x000000018550594C
			}
	
			public unsafe delegate void CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // TypeDefIndex: 44976; 0x000000018500A684-0x000000018500A6EC
	
			internal static class CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_BurstDirectCall // TypeDefIndex: 44977
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_BurstDirectCall() {} // 0x0000000183CEC0F0-0x0000000183CEC100
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006007f) {} // 0x0000000185505A0C-0x0000000185505B10
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185505B10-0x0000000185505B64
				public static void Constructor() {} // 0x0000000183CEC100-0x0000000183CEC190
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr) {} // 0x0000000185505B64-0x0000000185505CB8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcVertexNormalTangentFromTriangleKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index) {} // 0x00000001854FAA60-0x00000001854FAB14
			[BurstCompile]
			internal static unsafe void CalcVertexNormalTangentFromTriangleRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr) {} // 0x00000001854FABC0-0x00000001854FAC78
			[BurstCompile]
			public static unsafe void CalcVertexNormalTangentFromTriangleKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index) {} // 0x00000001854FA510-0x00000001854FAA60
			[BurstCompile]
			public static unsafe void CalcVertexNormalTangentFromTriangleRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr) {} // 0x00000001854FAB14-0x00000001854FABC0
		}
	
		[BurstCompile]
		private static class ClearProxyMeshUpdateBufferJobKernels // TypeDefIndex: 44981
		{
			// Nested types
			public unsafe delegate void ClearProxyMeshUpdateBufferKernel_000002F6_PostfixBurstDelegate(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // TypeDefIndex: 44979; 0x0000000182097E50-0x0000000182097E70
	
			internal static class ClearProxyMeshUpdateBufferKernel_000002F6_BurstDirectCall // TypeDefIndex: 44980
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearProxyMeshUpdateBufferKernel_000002F6_BurstDirectCall() {} // 0x0000000183CEBFB0-0x0000000183CEBFC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006009e) {} // 0x0000000185505E2C-0x0000000185505F30
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185505F30-0x0000000185505F84
				public static void Constructor() {} // 0x0000000183CEBFC0-0x0000000183CEC050
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3) {} // 0x0000000185505F84-0x0000000185506030
			}
	
			// Methods
			[BurstCompile]
			internal static unsafe void ClearProxyMeshUpdateBufferKernel(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3) {} // 0x0000000185505CB8-0x0000000185505D2C
			[BurstCompile]
			public static unsafe void ClearProxyMeshUpdateBufferKernel_BurstManaged(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3) {} // 0x0000000183D4FC50-0x0000000183D4FC60
		}
	
		[BurstCompile]
		private struct ClearProxyMeshUpdateBufferJob : IJob, IUnsafeJob // TypeDefIndex: 44982
		{
			// Fields
			public NativeReference<int> processingCounter0; // 0x00
			public NativeReference<int> processingCounter1; // 0x10
			public NativeReference<int> processingCounter2; // 0x20
			public NativeReference<int> processingCounter3; // 0x30
	
			// Methods
			public void Execute() {} // 0x0000000185505D2C-0x0000000185505DAC
			public void UnsafeDo() {} // 0x0000000185505DAC-0x0000000185505E2C
		}
	
		[BurstCompile]
		private struct CreateProxyMeshUpdateVertexList : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 44983
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
			public void SetIndexCount(int indexCount) {} // 0x00000001830DB120-0x00000001830DB160
			[IDTag(1)]
			public void Execute() {} // 0x0000000185507BA4-0x0000000185507C18
			[IDTag(0)]
			public void Execute(int teamId) {} // 0x0000000185507A38-0x0000000185507BA4
			public void UnsafeDo() {} // 0x0000000185507C18-0x0000000185507CB0
		}
	
		[BurstCompile]
		private struct CalcProxyMeshSkinningJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44984
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000183079F50-0x0000000183079F90
			[IDTag(1)]
			public void Execute() {} // 0x0000000185503570-0x0000000185503608
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185502E90-0x0000000185503570
			public void UnsafeDo() {} // 0x0000000185503608-0x00000001855037D4
		}
	
		[BurstCompile]
		private struct CreatePostProxyMeshUpdateListJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 44985
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
			public void SetIndexCount(int indexCount) {} // 0x00000001830AACF0-0x00000001830AAD30
			[IDTag(1)]
			public void Execute() {} // 0x0000000185507688-0x0000000185507700
			[IDTag(0)]
			public void Execute(int teamId) {} // 0x0000000185507700-0x0000000185507938
			public void UnsafeDo() {} // 0x0000000185507938-0x0000000185507A38
		}
	
		[BurstCompile]
		private struct CalcLineNormalTangentJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44986
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000183093250-0x0000000183093290
			[IDTag(1)]
			public void Execute() {} // 0x00000001855025D0-0x0000000185502668
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185501E6C-0x00000001855025D0
			public void UnsafeDo() {} // 0x0000000185502668-0x00000001855028AC
		}
	
		[BurstCompile]
		private struct CalcTriangleNormalTangentJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44987
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185504D9C-0x0000000185504E08
			[IDTag(1)]
			public void Execute() {} // 0x0000000185504D04-0x0000000185504D9C
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185504878-0x0000000185504D04
			public void UnsafeDo() {} // 0x0000000185504E08-0x0000000185504F38
		}
	
		[BurstCompile]
		private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44988
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185505538-0x00000001855055A4
			[IDTag(1)]
			public void Execute() {} // 0x00000001855054A0-0x0000000185505538
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185504F38-0x00000001855054A0
			public void UnsafeDo() {} // 0x00000001855055A4-0x00000001855056C8
		}
	
		[BurstCompile]
		private struct WriteTransformDataJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44989
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001830A8470-0x00000001830A84B0
			[IDTag(1)]
			public void Execute() {} // 0x0000000185510AB8-0x0000000185510B50
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185510B50-0x0000000185510EB0
			public void UnsafeDo() {} // 0x0000000185510EB0-0x0000000185510FC8
		}
	
		[BurstCompile]
		private struct WriteTransformLocalDataJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 44990
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000183097290-0x00000001830974E0
			[IDTag(1)]
			public void Execute() {} // 0x0000000185510FC8-0x0000000185511060
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185511060-0x000000018551141C
			public void UnsafeDo() {} // 0x000000018551141C-0x0000000185511580
		}
	
		[BurstCompile]
		private struct CalcMeshConvertMatrixJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 44991
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
			public void SetIndexCount(int indexCount) {} // 0x0000000185502D74-0x0000000185502DCC
			[IDTag(1)]
			public void Execute() {} // 0x00000001855028AC-0x0000000185502920
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185502920-0x0000000185502D74
			public void UnsafeDo() {} // 0x0000000185502DCC-0x0000000185502E90
		}
	
		[BurstCompile]
		private struct CalcProxySkinningJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 44992
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
			public void SetIndexCount(int indexCount) {} // 0x000000018550463C-0x0000000185504698
			[IDTag(1)]
			public void Execute() {} // 0x00000001855037D4-0x000000018550384C
			[IDTag(0)]
			public void Execute(int mvindex) {} // 0x000000018550384C-0x000000018550463C
			public void UnsafeDo() {} // 0x0000000185504698-0x0000000185504878
		}
	
		// Constructors
		public VirtualMeshManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		[BurstCompile]
		public static unsafe void CreateProxyMeshUpdateVertexListKernel(TeamManager.TeamData* teamDataArray, int* processingCounter1, int* processingList1, int teamId) {} // 0x00000001854FD150-0x00000001854FD274
		[BurstCompile]
		public static unsafe void CreateProxyMeshUpdateVertexListRangeKernel(TeamManager.TeamData* teamDataArray, int* processingCounter1, int* processingList1, int length) {} // 0x00000001854FD274-0x00000001854FD2D8
		public void Dispose() {} // 0x00000001834DEF70-0x00000001834DF630
		public void EnterdEditMode() {} // 0x00000001854FD2D8-0x00000001854FD328
		public void Initialize() {} // 0x00000001834E0070-0x00000001834E15E0
		public bool IsValid() => default; // 0x00000001854FE6E8-0x00000001854FE738
		public void RegisterProxyMesh(int teamId, VirtualMeshContainer proxyMeshContainer) {} // 0x000000018310DC00-0x000000018310E320
		public void ExitProxyMesh(int teamId) {} // 0x00000001832116F0-0x0000000183211E70
		public DataChunk RegisterMappingMesh(int teamId, VirtualMeshContainer mappingMeshContainer) => default; // 0x00000001854FEC04-0x00000001854FF0A0
		public void ExitMappingMesh(int teamId, int mappingIndex) {} // 0x00000001854FD328-0x00000001854FD6E0
		internal void UpdateBuffer() {} // 0x00000001854FF0A0-0x00000001854FF1F0
		internal JobHandle PreProxyMeshUpdate(JobHandle jobHandle) => default; // 0x0000000182C4B4D0-0x0000000182C4BC00
		internal JobHandle PostProxyMeshUpdate(JobHandle jobHandle) => default; // 0x000000018281EF80-0x000000018281FC30
		internal JobHandle PostMappingMeshUpdate(JobHandle jobHandle) => default; // 0x00000001854FE738-0x00000001854FEC04
		public void InformationLog(StringBuilder allsb) {} // 0x00000001854FD6E0-0x00000001854FE6E8
		public static void Initialize_CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E6_BurstDirectCall() {} // 0x00000001835EB520-0x00000001835EB580
		public static void Initialize_CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E7_BurstDirectCall() {} // 0x00000001835EB580-0x00000001835EB5E0
		public static void Initialize_CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002E8_BurstDirectCall() {} // 0x00000001835EB5E0-0x00000001835EB640
		public static void Initialize_CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002E9_BurstDirectCall() {} // 0x00000001835EB640-0x00000001835EB6A0
		public static void Initialize_WriteTransformDataJobKernels_WriteTransformDataKernel_000002EA_BurstDirectCall() {} // 0x00000001835EB6A0-0x00000001835EB700
		public static void Initialize_WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002EB_BurstDirectCall() {} // 0x00000001835EB700-0x00000001835EB760
		public static void Initialize_WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EC_BurstDirectCall() {} // 0x00000001835EB760-0x00000001835EB7C0
		public static void Initialize_WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002ED_BurstDirectCall() {} // 0x00000001835EB7C0-0x00000001835EB820
		public static void Initialize_CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002EE_BurstDirectCall() {} // 0x00000001835EB820-0x00000001835EB880
		public static void Initialize_CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002EF_BurstDirectCall() {} // 0x00000001835EB880-0x00000001835EB8E0
		public static void Initialize_CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F0_BurstDirectCall() {} // 0x00000001835EB8E0-0x00000001835EB940
		public static void Initialize_CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F1_BurstDirectCall() {} // 0x00000001835EB940-0x00000001835EB9A0
		public static void Initialize_CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F2_BurstDirectCall() {} // 0x00000001835EB9A0-0x00000001835EBA00
		public static void Initialize_CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F3_BurstDirectCall() {} // 0x00000001835EBA00-0x00000001835EBA60
		public static void Initialize_CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F4_BurstDirectCall() {} // 0x00000001835EBA60-0x00000001835EBAC0
		public static void Initialize_CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_BurstDirectCall() {} // 0x00000001835EBAC0-0x00000001835EBB20
		public static void Initialize_ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F6_BurstDirectCall() {} // 0x00000001835EBB20-0x00000001835EBB80
	}

	public interface IManager : IDisposable // TypeDefIndex: 44994
	{
		// Methods
		void Initialize();
		void EnterdEditMode();
		void InformationLog(StringBuilder allsb);
	}

	public static class MagicaManager // TypeDefIndex: 44999
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
		public static TimeManager Time { get; } // 0x00000001827B2C10-0x00000001827B2CE0 
		public static TeamManager Team { get; } // 0x00000001827B2DB0-0x00000001827B2E80 
		public static ClothManager Cloth { get; } // 0x00000001827B2A70-0x00000001827B2B40 
		public static RenderManager Render { get; } // 0x0000000183094770-0x0000000183094840 
		public static DynamicBoneTransformManager Bone { get; } // 0x000000018281B400-0x000000018281B4D0 
		public static VirtualMeshManager VMesh { get; } // 0x00000001827B2CE0-0x00000001827B2DB0 
		public static SimulationManager Simulation { get; } // 0x00000001827B2B40-0x00000001827B2C10 
		public static ColliderManager Collider { get; } // 0x000000018281E520-0x000000018281E5F0 
		public static WindManager Wind { get; } // 0x000000018281B330-0x000000018281B400 
		public static PreBuildManager PreBuild { get; } // 0x0000000182E1BFA0-0x0000000182E1C040 
	
		// Nested types
		public delegate void UpdateMethod(); // TypeDefIndex: 44995; 0x00000001842BE03C-0x00000001842BE04C
	
		public enum InitializationLocation // TypeDefIndex: 44996
		{
			Start = 0,
			Awake = 1
		}
	
		// Constructors
		static MagicaManager() {} // 0x0000000183CC50E0-0x0000000183CC5190
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Initialize() {} // 0x0000000182ECA4A0-0x0000000182ECAE90
		private static void Dispose() {} // 0x0000000182EC9DE0-0x0000000182ECA0B0
		public static bool IsPlaying() => default; // 0x000000018281B510-0x000000018281B5F0
		public static void SetUseCrossFrameJob(bool value) {} // 0x0000000185508FD8-0x0000000185509070
		public static void InitCustomGameLoop() {} // 0x00000001829537A0-0x0000000182953990
		private static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop) {} // 0x0000000182D92D30-0x0000000182D93760
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop) => default; // 0x0000000182D941D0-0x0000000182D94370
		public static void SetGlobalTimeScale(float timeScale) {} // 0x0000000185508CB4-0x0000000185508D64
		public static float GetGlobalTimeScale() => default; // 0x0000000185508918-0x00000001855089D8
		public static void SetSimulationFrequency(int freq) {} // 0x0000000185508E90-0x0000000185508F40
		public static void SetAOVMode(bool enable, float deltaTime) {} // 0x0000000185508C00-0x0000000185508CB4
		public static void DoAOVUpdate() {} // 0x00000001855087F8-0x0000000185508918
		public static void DoAOVAfterAnimatorUpdate() {} // 0x00000001855086D8-0x00000001855087F8
		public static int GetSimulationFrequency() => default; // 0x0000000185508A90-0x0000000185508B48
		public static void SetMaxSimulationCountPerFrame(int count) {} // 0x0000000185508DE4-0x0000000185508E90
		public static int GetMaxSimulationCountPerFrame() => default; // 0x00000001855089D8-0x0000000185508A90
		public static void SetUpdateLocation(TimeManager.UpdateLocation updateLocation) {} // 0x0000000185508F40-0x0000000185508FD8
		public static TimeManager.UpdateLocation GetUpdateLocation() => default; // 0x0000000185508B48-0x0000000185508C00
		public static void UnloadUnusedData() {} // 0x00000001830CDCD0-0x00000001830CDD60
		public static void SetInitializationLocation(InitializationLocation initLocation) {} // 0x0000000185508D64-0x0000000185508DE4
	}

	[AddComponentMenu("MagicaCloth2/MagicaSettings")]
	[HelpURL("https://magicasoft.jp/en/mc2_settings_component/")]
	public class MagicaSettings : ClothBehaviour // TypeDefIndex: 45001
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
		public enum RefreshMode // TypeDefIndex: 45000
		{
			OnAwake = 0,
			EveryFrame = 1,
			OnStart = 2,
			Manual = 3
		}
	
		// Constructors
		public MagicaSettings() {} // 0x0000000185509318-0x0000000185509330
	
		// Methods
		public void Awake() {} // 0x0000000185509070-0x00000001855090CC
		public void Start() {} // 0x0000000185509260-0x00000001855092BC
		public void Update() {} // 0x00000001855092BC-0x0000000185509318
		private void OnValidate() {} // 0x00000001855090CC-0x000000018550912C
		public void Refresh() {} // 0x000000018550912C-0x0000000185509260
	}

	[BurstCompile]
	internal static class UpdatePositionNormalJobKernels // TypeDefIndex: 45006
	{
		// Nested types
		public unsafe delegate void UpdatePositionNormalKernel_00000359_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // TypeDefIndex: 45002; 0x00000001854D2240-0x00000001854D229C
	
		internal static class UpdatePositionNormalKernel_00000359_BurstDirectCall // TypeDefIndex: 45003
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalKernel_00000359_BurstDirectCall() {} // 0x0000000183CE9850-0x0000000183CE9860
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000600fd) {} // 0x000000018550F408-0x000000018550F50C
			private static IntPtr GetFunctionPointer() => default; // 0x000000018550F50C-0x000000018550F560
			public static void Constructor() {} // 0x0000000183CE9860-0x0000000183CE98F0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index) {} // 0x000000018550F560-0x000000018550F670
		}
	
		public unsafe delegate void UpdatePositionNormalRangeKernel_0000035A_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // TypeDefIndex: 45004; 0x00000001854D2240-0x00000001854D229C
	
		internal static class UpdatePositionNormalRangeKernel_0000035A_BurstDirectCall // TypeDefIndex: 45005
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalRangeKernel_0000035A_BurstDirectCall() {} // 0x0000000183CE97B0-0x0000000183CE97C0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006011b) {} // 0x000000018550F7F8-0x000000018550F8FC
			private static IntPtr GetFunctionPointer() => default; // 0x000000018550F8FC-0x000000018550F950
			public static void Constructor() {} // 0x0000000183CE97C0-0x0000000183CE9850
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length) {} // 0x000000018550F950-0x000000018550FA8C
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdatePositionNormalKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index) {} // 0x000000018550EF78-0x000000018550F01C
		[BurstCompile]
		internal static unsafe void UpdatePositionNormalRangeKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length) {} // 0x000000018550F0BC-0x000000018550F160
		[BurstCompile]
		public static unsafe void UpdatePositionNormalKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index) {} // 0x000000018550EE8C-0x000000018550EF78
		[BurstCompile]
		public static unsafe void UpdatePositionNormalRangeKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length) {} // 0x000000018550F01C-0x000000018550F0BC
	}

	[BurstCompile]
	internal static class UpdatePositionNormalTangentJobKernels // TypeDefIndex: 45011
	{
		// Nested types
		public unsafe delegate void UpdatePositionNormalTangentKernel_0000035B_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // TypeDefIndex: 45007; 0x00000001854674CC-0x0000000185467540
	
		internal static class UpdatePositionNormalTangentKernel_0000035B_BurstDirectCall // TypeDefIndex: 45008
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalTangentKernel_0000035B_BurstDirectCall() {} // 0x0000000183CE9710-0x0000000183CE9720
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00060165) {} // 0x0000000185510244-0x0000000185510348
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185510348-0x000000018551039C
			public static void Constructor() {} // 0x0000000183CE9720-0x0000000183CE97B0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index) {} // 0x000000018551039C-0x00000001855104E0
		}
	
		public unsafe delegate void UpdatePositionNormalTangentRangeKernel_0000035C_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // TypeDefIndex: 45009; 0x00000001854674CC-0x0000000185467540
	
		internal static class UpdatePositionNormalTangentRangeKernel_0000035C_BurstDirectCall // TypeDefIndex: 45010
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalTangentRangeKernel_0000035C_BurstDirectCall() {} // 0x0000000183CE9670-0x0000000183CE9680
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00060189) {} // 0x0000000185510680-0x0000000185510784
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185510784-0x00000001855107D8
			public static void Constructor() {} // 0x0000000183CE9680-0x0000000183CE9710
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length) {} // 0x00000001855107D8-0x0000000185510948
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdatePositionNormalTangentKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index) {} // 0x000000018550FCB8-0x000000018550FD78
		[BurstCompile]
		internal static unsafe void UpdatePositionNormalTangentRangeKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length) {} // 0x000000018550FE30-0x000000018550FEF0
		[BurstCompile]
		public static unsafe void UpdatePositionNormalTangentKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index) {} // 0x000000018550FB4C-0x000000018550FCB8
		[BurstCompile]
		public static unsafe void UpdatePositionNormalTangentRangeKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length) {} // 0x000000018550FD78-0x000000018550FE30
	}

	[BurstCompile]
	internal static class UpdateBoneWeightJob2Kernels // TypeDefIndex: 45016
	{
		// Nested types
		public unsafe delegate void UpdateBoneWeight2Kernel_0000035D_PostfixBurstDelegate(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // TypeDefIndex: 45012; 0x00000001854BD60C-0x00000001854BD620
	
		internal static class UpdateBoneWeight2Kernel_0000035D_BurstDirectCall // TypeDefIndex: 45013
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdateBoneWeight2Kernel_0000035D_BurstDirectCall() {} // 0x0000000183CE9990-0x0000000183CE99A0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000601bd) {} // 0x000000018550E308-0x000000018550E40C
			private static IntPtr GetFunctionPointer() => default; // 0x000000018550E40C-0x000000018550E460
			public static void Constructor() {} // 0x0000000183CE99A0-0x0000000183CE9A30
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index) {} // 0x000000018550E460-0x000000018550E530
		}
	
		public unsafe delegate void UpdateBoneWeight2RangeKernel_0000035E_PostfixBurstDelegate(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // TypeDefIndex: 45014; 0x00000001854BD60C-0x00000001854BD620
	
		internal static class UpdateBoneWeight2RangeKernel_0000035E_BurstDirectCall // TypeDefIndex: 45015
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdateBoneWeight2RangeKernel_0000035E_BurstDirectCall() {} // 0x0000000183CE98F0-0x0000000183CE9900
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000601d5) {} // 0x000000018550E6B8-0x000000018550E7BC
			private static IntPtr GetFunctionPointer() => default; // 0x000000018550E7BC-0x000000018550E810
			public static void Constructor() {} // 0x0000000183CE9900-0x0000000183CE9990
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length) {} // 0x000000018550E810-0x000000018550E90C
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdateBoneWeight2Kernel(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index) {} // 0x000000018550EA98-0x000000018550EB1C
		[BurstCompile]
		internal static unsafe void UpdateBoneWeight2RangeKernel(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length) {} // 0x000000018550EB9C-0x000000018550EC20
		[BurstCompile]
		public static unsafe void UpdateBoneWeight2Kernel_BurstManaged(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index) {} // 0x000000018550E9CC-0x000000018550EA98
		[BurstCompile]
		public static unsafe void UpdateBoneWeight2RangeKernel_BurstManaged(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length) {} // 0x000000018550EB1C-0x000000018550EB9C
	}

	public class RenderData : IDisposable, ITransform // TypeDefIndex: 45021
	{
		// Fields
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
		private const int Flag_UseCustomMesh = 0; // Metadata: 0x01FB931F
		private const int Flag_ChangePositionNormal = 1; // Metadata: 0x01FB9320
		private const int Flag_ChangeBoneWeight = 2; // Metadata: 0x01FB9321
		private const int Flag_ModifyBoneWeight = 3; // Metadata: 0x01FB9322
		private const int Flag_HasMeshTangent = 4; // Metadata: 0x01FB9323
		private const int Flag_HasTangent = 5; // Metadata: 0x01FB9324
		private const int Flag_ChangeTangent = 6; // Metadata: 0x01FB9325
		private BitField32 flag; // 0xC0
	
		// Properties
		public int ReferenceCount { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		internal string Name { get => default; } // 0x000000018550B38C-0x000000018550B40C 
		internal bool HasSkinnedMesh { get => default; } // 0x000000018550B370-0x000000018550B380 
		internal bool HasBoneWeight { get => default; } // 0x000000018550B354-0x000000018550B364 
		public bool UseCustomMesh { get => default; } // 0x000000018550B42C-0x000000018550B438 
		public bool HasMeshTangent { get => default; } // 0x000000018550B364-0x000000018550B370 
		public bool HasTangent { get => default; } // 0x000000018550B380-0x000000018550B38C 
		internal ResultCode Result { get => default; } // 0x000000018550B40C-0x000000018550B42C 
	
		// Nested types
		[BurstCompile]
		private struct UpdatePositionNormalJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45017
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
			public void SetIndexCount(int indexCount) {} // 0x000000018550F2F0-0x000000018550F348
			[IDTag(1)]
			public void Execute() {} // 0x000000018550F160-0x000000018550F1D4
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018550F1D4-0x000000018550F2F0
			public void UnsafeDo() {} // 0x000000018550F348-0x000000018550F408
		}
	
		[BurstCompile]
		private struct UpdatePositionNormalTangentJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45018
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
			public void SetIndexCount(int indexCount) {} // 0x00000001855100EC-0x0000000185510148
			[IDTag(1)]
			public void Execute() {} // 0x000000018550FEF0-0x000000018550FF68
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018550FF68-0x00000001855100EC
			public void UnsafeDo() {} // 0x0000000185510148-0x0000000185510244
		}
	
		[BurstCompile]
		private struct UpdateBoneWeightJob2 : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45019
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
			public void SetIndexCount(int indexCount) {} // 0x000000018550ED6C-0x000000018550EDC4
			[IDTag(1)]
			public void Execute() {} // 0x000000018550EC20-0x000000018550EC94
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018550EC94-0x000000018550ED6C
			public void UnsafeDo() {} // 0x000000018550EDC4-0x000000018550EE8C
		}
	
		// Constructors
		public RenderData() {} // 0x000000018550B2DC-0x000000018550B354
	
		// Methods
		public void Dispose() {} // 0x00000001855096D8-0x0000000185509854
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x00000001855098BC-0x0000000185509928
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x0000000185509BCC-0x0000000185509C38
		internal void Initialize(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referencePreBuildUniqueSetupData) {} // 0x0000000185509928-0x0000000185509B78
		internal int AddReferenceCount() => default; // 0x0000000185509688-0x00000001855096D8
		internal int RemoveReferenceCount() => default; // 0x0000000185509B78-0x0000000185509BCC
		private void SwapCustomMesh() {} // 0x0000000185509FA8-0x000000018550A3A8
		private void ResetCustomMeshWorkData() {} // 0x0000000185509C38-0x0000000185509E30
		private void SwapOriginalMesh() {} // 0x000000018550A3A8-0x000000018550A490
		private void SetMesh(Mesh mesh) {} // 0x0000000185509E30-0x0000000185509F44
		public void StartUse(ClothProcess cprocess) {} // 0x0000000185509F44-0x0000000185509FA8
		public void EndUse(ClothProcess cprocess) {} // 0x0000000185509854-0x00000001855098BC
		internal void UpdateUse(ClothProcess cprocess, int add) {} // 0x000000018550AECC-0x000000018550B118
		internal void UpdateSkipWriting() {} // 0x000000018550AD6C-0x000000018550AECC
		internal void WriteMesh() {} // 0x000000018550B118-0x000000018550B2DC
		internal JobHandle UpdatePositionNormal(bool updateTangent, DataChunk mappingChunk, JobHandle jobHandle) => default; // 0x000000018550A904-0x000000018550AD6C
		internal JobHandle UpdateBoneWeight(DataChunk mappingChunk, JobHandle jobHandle = default) => default; // 0x000000018550A6DC-0x000000018550A904
		public override string ToString() => default; // 0x000000018550A490-0x000000018550A6DC
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public class RenderManager : IManager, IValid // TypeDefIndex: 45022
	{
		// Fields
		private Dictionary<int, BeyondDynamicBone.RenderData> renderDataDict; // 0x10
		private bool isValid; // 0x18
	
		// Constructors
		public RenderManager() {} // 0x0000000182ECAFC0-0x0000000182ECB040
	
		// Methods
		public void Initialize() {} // 0x0000000182ECB690-0x0000000182ECB7F0
		public void EnterdEditMode() {} // 0x000000018550B704-0x000000018550B754
		public void Dispose() {} // 0x0000000182ECB7F0-0x0000000182ECBD70
		public bool IsValid() => default; // 0x000000018550BC5C-0x000000018550BCA8
		public int AddRenderer(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referenceUniqueSetupData) => default; // 0x000000018550B438-0x000000018550B67C
		public bool RemoveRenderer(int handle) => default; // 0x000000018550BCA8-0x000000018550BE90
		public BeyondDynamicBone.RenderData GetRendererData(int handle) => default; // 0x000000018550B754-0x000000018550B8F8
		public void StartUse(ClothProcess cprocess, int handle) {} // 0x000000018550BE90-0x000000018550BF14
		public void EndUse(ClothProcess cprocess, int handle) {} // 0x000000018550B67C-0x000000018550B704
		private void PreRenderingUpdate() {} // 0x0000000182315A80-0x0000000182315D30
		public void InformationLog(StringBuilder allsb) {} // 0x000000018550B8F8-0x000000018550BC5C
	}

	public class RenderSetupData : IDisposable, ITransform // TypeDefIndex: 45031
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
		public int TransformCount { get => default; } // 0x00000001828C54C0-0x00000001828C5530 
		public bool HasMeshDataArray { get => default; } // 0x000000018550DE6C-0x000000018550DE74 
		public bool HasLocalPositions { get => default; } // 0x000000018550DE34-0x000000018550DE6C 
		public bool HasTangent { get => default; } // 0x000000018550DE74-0x000000018550DEF4 
	
		// Nested types
		public enum SetupType // TypeDefIndex: 45023
		{
			MeshCloth = 0,
			BoneCloth = 1,
			BoneSpring = 2
		}
	
		public enum BoneConnectionMode // TypeDefIndex: 45024
		{
			Line = 0,
			AutomaticMesh = 1,
			SequentialLoopMesh = 2,
			SequentialNonLoopMesh = 3
		}
	
		[BurstCompile]
		private struct VertexWeight5BoneCheckJob : IJob // TypeDefIndex: 45025
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			[WriteOnly]
			public NativeReference<Define.Result> result; // 0x18
	
			// Methods
			public void Execute() {} // 0x0000000185510A20-0x0000000185510AB8
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 45026
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
			public void Execute(int index, TransformAccess transform) {} // 0x0000000185509330-0x0000000185509688
		}
	
		[BurstCompile]
		private struct GetBoneWeightJos : IJob // TypeDefIndex: 45027
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
			public void Execute() {} // 0x0000000185508590-0x00000001855086D8
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 45028
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
			public bool HasTangent { get => default; } // 0x000000018550DEF4-0x000000018550DF08 
	
			// Constructors
			public ShareSerializationData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 45030
		{
			// Fields
			public ResultCode result; // 0x10
			public Renderer renderer; // 0x18
			public SkinnedMeshRenderer skinRenderer; // 0x20
			public MeshFilter meshFilter; // 0x28
			public Mesh originalMesh; // 0x30
			public List<Transform> transformList; // 0x38
	
			// Constructors
			public UniqueSerializationData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018550E080-0x000000018550E184
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x000000018550E184-0x000000018550E308
		}
	
		// Constructors
		public RenderSetupData() {} // 0x000000018550DDEC-0x000000018550DE34
		public RenderSetupData(Renderer ren) {} // 0x000000018550D0B8-0x000000018550DDEC
		public RenderSetupData(SetupType setType, Transform renderTransform, List<Transform> rootTransforms, List<Transform> ignoreFromRootBones, List<Transform> collisionBones, BoneConnectionMode connectionMode = BoneConnectionMode.Line /* Metadata: 0x01FB9326 */, string name = "(no name)" /* Metadata: 0x01FB9327 */) {} // 0x0000000182E1E360-0x0000000182E1F340
	
		// Methods
		public bool IsSuccess() => default; // 0x000000018550C418-0x000000018550C46C
		public bool IsFaild() => default; // 0x00000001838ED070-0x00000001838ED0B0
		private void ReadTransformInformation(bool includeChilds) {} // 0x0000000182702EE0-0x0000000182704B80
		public void Dispose() {} // 0x0000000183CB36B0-0x0000000183CB3810
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018550C29C-0x000000018550C418
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x000000018550C46C-0x000000018550C928
		public Transform GetRendeerTransform() => default; // 0x000000018550C008-0x000000018550C08C
		public int GetRenderTransformId() => default; // 0x000000018550C08C-0x000000018550C110
		public float4x4 GetRendeerLocalToWorldMatrix() => default; // 0x00000001836BC550-0x00000001836BC630
		public Transform GetSkinRootTransform() => default; // 0x000000018550C190-0x000000018550C210
		public int GetSkinRootTransformId() => default; // 0x000000018550C110-0x000000018550C190
		public int GetTransformIndexFromId(int id) => default; // 0x000000018550C210-0x000000018550C29C
		public int GetParentTransformIndex(int index, bool centerExcluded) => default; // 0x00000001828C5530-0x00000001828C55F0
		public void GetBoneWeightsRun(NativeArray<BoneWeight> weights) {} // 0x000000018550BF14-0x000000018550C008
		public ShareSerializationData ShareSerialize() => default; // 0x000000018550CC3C-0x000000018550CEF0
		public static RenderSetupData ShareDeserialize(ShareSerializationData sdata) => default; // 0x000000018550C928-0x000000018550CC3C
		public UniqueSerializationData UniqueSerialize() => default; // 0x000000018550CEF0-0x000000018550D0B8
	}

	[BurstCompile]
	internal static class EndSimulationStepJobKernels // TypeDefIndex: 45036
	{
		// Nested types
		public unsafe delegate void EndSimulationStepKernel_000003B8_PostfixBurstDelegate(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // TypeDefIndex: 45032; 0x00000001854BD60C-0x00000001854BD620
	
		internal static class EndSimulationStepKernel_000003B8_BurstDirectCall // TypeDefIndex: 45033
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EndSimulationStepKernel_000003B8_BurstDirectCall() {} // 0x0000000183CEB830-0x0000000183CEB840
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_0006023b) {} // 0x0000000185507E48-0x0000000185507F4C
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185507F4C-0x0000000185507FA0
			public static void Constructor() {} // 0x0000000183CEB840-0x0000000183CEB8D0
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index) {} // 0x0000000185507FA0-0x0000000185508074
		}
	
		public unsafe delegate void EndSimulationStepRangeKernel_000003B9_PostfixBurstDelegate(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // TypeDefIndex: 45034; 0x00000001854BD60C-0x00000001854BD620
	
		internal static class EndSimulationStepRangeKernel_000003B9_BurstDirectCall // TypeDefIndex: 45035
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EndSimulationStepRangeKernel_000003B9_BurstDirectCall() {} // 0x0000000183CEB6F0-0x0000000183CEB700
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_00060253) {} // 0x0000000185508200-0x0000000185508304
			private static IntPtr GetFunctionPointer() => default; // 0x0000000185508304-0x0000000185508358
			public static void Constructor() {} // 0x0000000183CEB700-0x0000000183CEB790
			public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
			public static unsafe void Invoke(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr) {} // 0x0000000185508358-0x0000000185508460
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void EndSimulationStepKernel(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index) {} // 0x0000000185507CB0-0x0000000185507D38
		[BurstCompile]
		internal static unsafe void EndSimulationStepRangeKernel(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr) {} // 0x0000000185507DC0-0x0000000185507E48
		[BurstCompile]
		public static unsafe void EndSimulationStepKernel_BurstManaged(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index) {} // 0x0000000183D4FC60-0x0000000183D4FCB0
		[BurstCompile]
		public static unsafe void EndSimulationStepRangeKernel_BurstManaged(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr) {} // 0x0000000185507D38-0x0000000185507DC0
	}

	public class ColliderManager : IManager, IValid // TypeDefIndex: 45064
	{
		// Fields
		public ExNativeArray<short> teamIdArray; // 0x10
		public const byte Flag_Valid = 16; // Metadata: 0x01FB9338
		public const byte Flag_Enable = 32; // Metadata: 0x01FB9339
		public const byte Flag_Reset = 64; // Metadata: 0x01FB933A
		public const byte Flag_Reverse = 128; // Metadata: 0x01FB933B
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
		public int DataCount { get => default; } // 0x0000000182C4C310-0x0000000182C4C350 
		public int ColliderCount { get => default; } // 0x0000000185507648-0x0000000185507688 
	
		// Nested types
		[BurstCompile]
		public static class ColliderKernels // TypeDefIndex: 45041
		{
			// Nested types
			public unsafe delegate void PreSimulationUpdateKernel_000003D1_PostfixBurstDelegate(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // TypeDefIndex: 45037; 0x0000000185460FA0-0x000000018546107C
	
			internal static class PreSimulationUpdateKernel_000003D1_BurstDirectCall // TypeDefIndex: 45038
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateKernel_000003D1_BurstDirectCall() {} // 0x0000000183CEAC50-0x0000000183CEAC60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000602e5) {} // 0x000000018551DFC8-0x000000018551E0CC
				private static IntPtr GetFunctionPointer() => default; // 0x000000018551E0CC-0x000000018551E120
				public static void Constructor() {} // 0x0000000183CEAC60-0x0000000183CEACF0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index) {} // 0x000000018551E120-0x000000018551E360
			}
	
			public unsafe delegate void PreSimulationUpdateRangeKernel_000003D2_PostfixBurstDelegate(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // TypeDefIndex: 45039; 0x0000000185460FA0-0x000000018546107C
	
			internal static class PreSimulationUpdateRangeKernel_000003D2_BurstDirectCall // TypeDefIndex: 45040
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateRangeKernel_000003D2_BurstDirectCall() {} // 0x0000000183CEAB10-0x0000000183CEAB20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060321) {} // 0x000000018551EC3C-0x000000018551ED40
				private static IntPtr GetFunctionPointer() => default; // 0x000000018551ED40-0x000000018551ED94
				public static void Constructor() {} // 0x0000000183CEAB20-0x0000000183CEABB0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x000000018551ED94-0x000000018551EFCC
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index) {} // 0x00000001855183F4-0x000000018551852C
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x000000018551852C-0x0000000185518664
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel_BurstManaged(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index) {} // 0x0000000185511580-0x0000000185511E00
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel_BurstManaged(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x0000000185511E00-0x0000000185511F3C
		}
	
		[BurstCompile]
		private static class CreateUpdatecolliderListJobKernels // TypeDefIndex: 45046
		{
			// Nested types
			public unsafe delegate void CreateUpdatecolliderListKernel_000003D3_PostfixBurstDelegate(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // TypeDefIndex: 45042; 0x0000000181028930-0x0000000181028950
	
			internal static class CreateUpdatecolliderListKernel_000003D3_BurstDirectCall // TypeDefIndex: 45043
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdatecolliderListKernel_000003D3_BurstDirectCall() {} // 0x0000000183CEBBF0-0x0000000183CEBC00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060357) {} // 0x0000000185519840-0x0000000185519944
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185519944-0x0000000185519998
				public static void Constructor() {} // 0x0000000183CEBC00-0x0000000183CEBC90
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId) {} // 0x0000000185519998-0x0000000185519A54
			}
	
			public unsafe delegate void CreateUpdatecolliderListRangeKernel_000003D4_PostfixBurstDelegate(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // TypeDefIndex: 45044; 0x0000000181028930-0x0000000181028950
	
			internal static class CreateUpdatecolliderListRangeKernel_000003D4_BurstDirectCall // TypeDefIndex: 45045
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdatecolliderListRangeKernel_000003D4_BurstDirectCall() {} // 0x0000000183CEBB50-0x0000000183CEBB60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006036c) {} // 0x0000000185519BD0-0x0000000185519CD4
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185519CD4-0x0000000185519D28
				public static void Constructor() {} // 0x0000000183CEBB60-0x0000000183CEBBF0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length) {} // 0x0000000185519D28-0x0000000185519E04
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListKernel(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId) {} // 0x0000000185519480-0x00000001855194FC
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListRangeKernel(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length) {} // 0x0000000185519568-0x00000001855195E4
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListKernel_BurstManaged(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId) {} // 0x00000001855124FC-0x00000001855133C0
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListRangeKernel_BurstManaged(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length) {} // 0x00000001855194FC-0x0000000185519568
		}
	
		[BurstCompile]
		public static class StartSimulationStepJobKernels // TypeDefIndex: 45051
		{
			// Nested types
			public unsafe delegate void StartSimulationStepKernel_000003D5_PostfixBurstDelegate(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // TypeDefIndex: 45047; 0x00000001854F635C-0x00000001854F642C
	
			internal static class StartSimulationStepKernel_000003D5_BurstDirectCall // TypeDefIndex: 45048
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepKernel_000003D5_BurstDirectCall() {} // 0x0000000183CEA070-0x0000000183CEA080
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000603dd) {} // 0x0000000185523A48-0x0000000185523B4C
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185523B4C-0x0000000185523BA0
				public static void Constructor() {} // 0x0000000183CEA080-0x0000000183CEA110
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index) {} // 0x0000000185523BA0-0x0000000185523DC0
			}
	
			public unsafe delegate void StartSimulationStepRangeKernel_000003D6_PostfixBurstDelegate(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // TypeDefIndex: 45049; 0x00000001854F6934-0x00000001854F6A04
	
			internal static class StartSimulationStepRangeKernel_000003D6_BurstDirectCall // TypeDefIndex: 45050
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepRangeKernel_000003D6_BurstDirectCall() {} // 0x0000000183CE9F30-0x0000000183CE9F40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060416) {} // 0x000000018552481C-0x0000000185524920
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185524920-0x0000000185524974
				public static void Constructor() {} // 0x0000000183CE9F40-0x0000000183CE9FD0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr) {} // 0x0000000185524974-0x0000000185524B90
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void StartSimulationStepKernel(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index) {} // 0x0000000185521D6C-0x0000000185521E94
			[BurstCompile]
			internal static unsafe void StartSimulationStepRangeKernel(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr) {} // 0x000000018552228C-0x00000001855223B8
			[BurstCompile]
			public static unsafe void StartSimulationStepKernel_BurstManaged(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index) {} // 0x0000000185514A90-0x00000001855167C0
			[BurstCompile]
			public static unsafe void StartSimulationStepRangeKernel_BurstManaged(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr) {} // 0x00000001855167C0-0x00000001855168E8
		}
	
		[BurstCompile]
		private static class PostSimulationUpdateJobKernels // TypeDefIndex: 45056
		{
			// Nested types
			public unsafe delegate void PostSimulationUpdateKernel_000003D7_PostfixBurstDelegate(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 45052; 0x000000018551C468-0x000000018551C47C
	
			internal static class PostSimulationUpdateKernel_000003D7_BurstDirectCall // TypeDefIndex: 45053
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostSimulationUpdateKernel_000003D7_BurstDirectCall() {} // 0x0000000183CEAED0-0x0000000183CEAEE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060457) {} // 0x000000018551C160-0x000000018551C264
				private static IntPtr GetFunctionPointer() => default; // 0x000000018551C264-0x000000018551C2B8
				public static void Constructor() {} // 0x0000000183CEAEE0-0x0000000183CEAF70
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index) {} // 0x000000018551C2B8-0x000000018551C3A4
			}
	
			public unsafe delegate void PostSimulationUpdateRangeKernel_000003D8_PostfixBurstDelegate(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 45054; 0x000000018551C468-0x000000018551C47C
	
			internal static class PostSimulationUpdateRangeKernel_000003D8_BurstDirectCall // TypeDefIndex: 45055
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostSimulationUpdateRangeKernel_000003D8_BurstDirectCall() {} // 0x0000000183CEAE30-0x0000000183CEAE40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060472) {} // 0x000000018551C550-0x000000018551C654
				private static IntPtr GetFunctionPointer() => default; // 0x000000018551C654-0x000000018551C6A8
				public static void Constructor() {} // 0x0000000183CEAE40-0x0000000183CEAED0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length) {} // 0x000000018551C6A8-0x000000018551C7C8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PostSimulationUpdateKernel(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index) {} // 0x000000018551BD24-0x000000018551BDB8
			[BurstCompile]
			internal static unsafe void PostSimulationUpdateRangeKernel(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length) {} // 0x000000018551BE4C-0x000000018551BEE0
			[BurstCompile]
			public static unsafe void PostSimulationUpdateKernel_BurstManaged(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001855139C0-0x0000000185514430
			[BurstCompile]
			public static unsafe void PostSimulationUpdateRangeKernel_BurstManaged(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length) {} // 0x000000018551BDB8-0x000000018551BE4C
		}
	
		public enum ColliderType : byte // TypeDefIndex: 45057
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
	
		internal struct WorkData // TypeDefIndex: 45058
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
		private struct PreSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45059
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
			public void SetIndexCount(int indexCount) {} // 0x00000001830974E0-0x0000000183097520
			[IDTag(1)]
			public void Execute() {} // 0x000000018551D46C-0x000000018551D4E4
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018551D4E4-0x000000018551DDB8
			public void UnsafeDo() {} // 0x000000018551DDB8-0x000000018551DFC8
		}
	
		[BurstCompile]
		private struct CreateUpdatecolliderListJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45060
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
			public void SetIndexCount(int indexCount) {} // 0x0000000182F8A610-0x0000000182F8A6A0
			[IDTag(1)]
			public void Execute() {} // 0x00000001855195E4-0x0000000185519658
			[IDTag(0)]
			public void Execute(int teamId) {} // 0x0000000185519658-0x00000001855197A0
			public void UnsafeDo() {} // 0x00000001855197A0-0x0000000185519840
		}
	
		[BurstCompile]
		private struct StartSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45061
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182EF83C0-0x0000000182EF8460
			[IDTag(1)]
			public void Execute() {} // 0x00000001855228F4-0x000000018552298C
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018552298C-0x0000000185523820
			public void UnsafeDo() {} // 0x0000000185523820-0x0000000185523A48
		}
	
		[BurstCompile]
		private struct EndSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45062
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182F62F90-0x0000000182F63030
			[IDTag(1)]
			public void Execute() {} // 0x000000018551AF68-0x000000018551AFFC
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018551AEC8-0x000000018551AF68
			public void UnsafeDo() {} // 0x000000018551AFFC-0x000000018551B0B8
		}
	
		[BurstCompile]
		private struct PostSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45063
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
			public void SetIndexCount(int indexCount) {} // 0x00000001830BF4E0-0x00000001830BF520
			[IDTag(1)]
			public void Execute() {} // 0x000000018551BEE0-0x000000018551BF54
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018551BF54-0x000000018551C0A0
			public void UnsafeDo() {} // 0x000000018551C0A0-0x000000018551C160
		}
	
		// Constructors
		public ColliderManager() {} // 0x0000000182ECAF40-0x0000000182ECAFC0
	
		// Methods
		public void Dispose() {} // 0x00000001834E2AA0-0x00000001834E2CC0
		public void EnterdEditMode() {} // 0x0000000185506794-0x00000001855067E4
		public void Initialize() {} // 0x00000001834E15E0-0x00000001834E1A10
		public bool IsValid() => default; // 0x000000018320E7F0-0x000000018320E820
		public void Register(ClothProcess cprocess) {} // 0x0000000182702140-0x00000001827024B0
		public void Exit(ClothProcess cprocess) {} // 0x0000000183210050-0x0000000183211140
		internal void InitColliders(ClothProcess cprocess) {} // 0x000000018320FD90-0x000000018320FF90
		internal void UpdateColliders(ClothProcess cprocess) {} // 0x000000018320F140-0x000000018320FD90
		private void AddCollider(ClothProcess cprocess, ColliderComponent col) {} // 0x000000018550614C-0x0000000185506794
		internal void RemoveCollider(ColliderComponent col, int teamId) {} // 0x000000018320E820-0x000000018320EE20
		private void AddColliderInternal(ClothProcess cprocess, ColliderComponent col, int index, int arrayIndex, int transformIndex) {} // 0x0000000182BA26D0-0x0000000182BA2C70
		internal void EnableCollider(ColliderComponent col, int teamId, bool sw) {} // 0x000000018320EE20-0x000000018320F020
		internal void EnableTeamCollider(int teamId) {} // 0x0000000182BA2270-0x0000000182BA2460
		internal void UpdateParameters(ColliderComponent col, int teamId) {} // 0x000000018550739C-0x0000000185507648
		internal JobHandle PreSimulationUpdate(JobHandle jobHandle) => default; // 0x000000018281C240-0x000000018281C630
		internal JobHandle CreateUpdateColliderList(int updateIndex, JobHandle jobHandle) => default; // 0x0000000182C4CA40-0x0000000182C4CDC0
		internal JobHandle StartSimulationStep(JobHandle jobHandle) => default; // 0x000000018281E9D0-0x000000018281EF80
		internal JobHandle EndSimulationStep(JobHandle jobHandle) => default; // 0x000000018281E5F0-0x000000018281E9D0
		internal JobHandle PostSimulationUpdate(JobHandle jobHandle) => default; // 0x0000000182C4C0D0-0x0000000182C4C310
		public void InformationLog(StringBuilder allsb) {} // 0x00000001855067E4-0x000000018550739C
		public static void Initialize_CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D3_BurstDirectCall() {} // 0x00000001835EBB80-0x00000001835EBBE0
		public static void Initialize_CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D4_BurstDirectCall() {} // 0x00000001835EBBE0-0x00000001835EBC40
		public static void Initialize_PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D7_BurstDirectCall() {} // 0x00000001835EBC40-0x00000001835EBCA0
		public static void Initialize_PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003D8_BurstDirectCall() {} // 0x00000001835EBCA0-0x00000001835EBD00
	}

	public class SimulationManager : IManager, IValid // TypeDefIndex: 45113
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
		private bool isValid; // 0x16C
	
		// Properties
		public int ParticleCount { get => default; } // 0x0000000182C4C630-0x0000000182C4C670 
		internal int SimulationStepCount { get; private set; } // 0x0000000183D4FCB0-0x0000000183D4FCC0 0x0000000183D4FCC0-0x0000000183D4FCD0
		internal int WorkerCount { get => default; } // 0x0000000184271454-0x0000000184271460 
	
		// Nested types
		[BurstCompile]
		public static class CreateUpdateParticleListKernels // TypeDefIndex: 45069
		{
			// Nested types
			public unsafe delegate void CreateUpdateParticleListKernel_00000401_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // TypeDefIndex: 45065; 0x0000000185459340-0x0000000185459444
	
			internal static class CreateUpdateParticleListKernel_00000401_BurstDirectCall // TypeDefIndex: 45066
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdateParticleListKernel_00000401_BurstDirectCall() {} // 0x0000000183CEBD30-0x0000000183CEBD40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060518) {} // 0x0000000185518664-0x0000000185518768
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185518768-0x00000001855187BC
				public static void Constructor() {} // 0x0000000183CEBD40-0x0000000183CEBDD0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId) {} // 0x00000001855187BC-0x0000000185518A54
			}
	
			public unsafe delegate void CreateUpdateParticleListRangeKernel_00000402_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // TypeDefIndex: 45067; 0x0000000185459340-0x0000000185459444
	
			internal static class CreateUpdateParticleListRangeKernel_00000402_BurstDirectCall // TypeDefIndex: 45068
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdateParticleListRangeKernel_00000402_BurstDirectCall() {} // 0x0000000183CEBC90-0x0000000183CEBCA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006055d) {} // 0x0000000185518F44-0x0000000185519048
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185519048-0x000000018551909C
				public static void Constructor() {} // 0x0000000183CEBCA0-0x0000000183CEBD30
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length) {} // 0x000000018551909C-0x0000000185519334
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListKernel(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId) {} // 0x0000000185518C74-0x0000000185518DDC
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListRangeKernel(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length) {} // 0x0000000185518DDC-0x0000000185518F44
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListKernel_BurstManaged(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId) {} // 0x0000000185511F3C-0x0000000185512390
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length) {} // 0x0000000185512390-0x00000001855124FC
		}
	
		[BurstCompile]
		public static class PreSimulationUpdateJobKernels // TypeDefIndex: 45074
		{
			// Nested types
			public unsafe delegate void PreSimulationUpdateKernel_00000403_PostfixBurstDelegate(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // TypeDefIndex: 45070; 0x000000018551EA74-0x000000018551EB68
	
			internal static class PreSimulationUpdateKernel_00000403_BurstDirectCall // TypeDefIndex: 45071
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateKernel_00000403_BurstDirectCall() {} // 0x0000000183CEABB0-0x0000000183CEABC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000605f0) {} // 0x000000018551E55C-0x000000018551E660
				private static IntPtr GetFunctionPointer() => default; // 0x000000018551E660-0x000000018551E6B4
				public static void Constructor() {} // 0x0000000183CEABC0-0x0000000183CEAC50
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex) {} // 0x000000018551E6B4-0x000000018551E934
			}
	
			public unsafe delegate void PreSimulationUpdateRangeKernel_00000404_PostfixBurstDelegate(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // TypeDefIndex: 45072; 0x000000018551EA74-0x000000018551EB68
	
			internal static class PreSimulationUpdateRangeKernel_00000404_BurstDirectCall // TypeDefIndex: 45073
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateRangeKernel_00000404_BurstDirectCall() {} // 0x0000000183CEAA70-0x0000000183CEAA80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060632) {} // 0x000000018551F0F4-0x000000018551F1F8
				private static IntPtr GetFunctionPointer() => default; // 0x000000018551F1F8-0x000000018551F24C
				public static void Constructor() {} // 0x0000000183CEAA80-0x0000000183CEAB10
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length) {} // 0x000000018551F24C-0x000000018551F4C4
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex) {} // 0x000000018551D1BC-0x000000018551D314
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length) {} // 0x000000018551D314-0x000000018551D46C
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel_BurstManaged(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex) {} // 0x000000018551C88C-0x000000018551D1BC
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel_BurstManaged(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length) {} // 0x0000000185514430-0x0000000185514A90
		}
	
		[BurstCompile]
		private static class StartSimulationStepJobKernels // TypeDefIndex: 45085
		{
			// Nested types
			public unsafe delegate void StartSimulationStepKernel_00000405_PostfixBurstDelegate(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // TypeDefIndex: 45075; 0x00000001855245E0-0x0000000185524754
	
			internal static class StartSimulationStepKernel_00000405_BurstDirectCall // TypeDefIndex: 45076
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepKernel_00000405_BurstDirectCall() {} // 0x0000000183CE9FD0-0x0000000183CE9FE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006072a) {} // 0x0000000185523EDC-0x0000000185523FE0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185523FE0-0x0000000185524034
				public static void Constructor() {} // 0x0000000183CE9FE0-0x0000000183CEA070
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x0000000185524034-0x00000001855243EC
			}
	
			public unsafe delegate void StartSimulationStepRangeKernel_00000406_PostfixBurstDelegate(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // TypeDefIndex: 45077; 0x0000000185525274-0x00000001855253EC
	
			internal static class StartSimulationStepRangeKernel_00000406_BurstDirectCall // TypeDefIndex: 45078
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepRangeKernel_00000406_BurstDirectCall() {} // 0x0000000183CE9E90-0x0000000183CE9EA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060787) {} // 0x0000000185524B90-0x0000000185524C94
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185524C94-0x0000000185524CE8
				public static void Constructor() {} // 0x0000000183CE9EA0-0x0000000183CE9F30
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x0000000185524CE8-0x0000000185525098
			}
	
			public delegate void Spring_00000407_PostfixBurstDelegate([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // TypeDefIndex: 45079; 0x000000018551C468-0x000000018551C47C
	
			internal static class Spring_00000407_BurstDirectCall // TypeDefIndex: 45080
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Spring_00000407_BurstDirectCall() {} // 0x0000000183CEA110-0x0000000183CEA120
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000607b8) {} // 0x00000001855204D8-0x00000001855205DC
				private static IntPtr GetFunctionPointer() => default; // 0x00000001855205DC-0x0000000185520630
				public static void Constructor() {} // 0x0000000183CEA120-0x0000000183CEA1B0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static void Invoke([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio) {} // 0x0000000185520630-0x000000018552072C
			}
	
			public unsafe delegate void Wind_00000408_PostfixBurstDelegate(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // TypeDefIndex: 45081; 0x0000000185526EF4-0x0000000185526F80
	
			internal static class Wind_00000408_BurstDirectCall // TypeDefIndex: 45082
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Wind_00000408_BurstDirectCall() {} // 0x0000000183CE8F90-0x0000000183CE8FA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000607dd) {} // 0x0000000185526AAC-0x0000000185526BB0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185526BB0-0x0000000185526C04
				public static void Constructor() {} // 0x0000000183CE8FA0-0x0000000183CE9030
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result) {} // 0x0000000185526C04-0x0000000185526D80
			}
	
			public delegate void WindForceBlend_00000409_PostfixBurstDelegate([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // TypeDefIndex: 45083; 0x0000000181028930-0x0000000181028950
	
			internal static class WindForceBlend_00000409_BurstDirectCall // TypeDefIndex: 45084
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WindForceBlend_00000409_BurstDirectCall() {} // 0x0000000183CE90D0-0x0000000183CE90E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000607f9) {} // 0x00000001855266B4-0x00000001855267B8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001855267B8-0x000000018552680C
				public static void Constructor() {} // 0x0000000183CE90E0-0x0000000183CE9170
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static void Invoke([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result) {} // 0x000000018552680C-0x00000001855268D0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void StartSimulationStepKernel(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x0000000185521E94-0x0000000185522090
			[BurstCompile]
			internal static unsafe void StartSimulationStepRangeKernel(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x0000000185522090-0x000000018552228C
			[BurstCompile]
			private static void Spring([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio) {} // 0x0000000185520E30-0x0000000185520EC8
			[BurstCompile]
			private static unsafe void Wind(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result) {} // 0x0000000185522818-0x00000001855228F4
			[BurstCompile]
			private static void WindForceBlend([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result) {} // 0x00000001855223B8-0x0000000185522438
			[BurstCompile]
			public static unsafe void StartSimulationStepKernel_BurstManaged(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x0000000185520EC8-0x0000000185521D6C
			[BurstCompile]
			public static unsafe void StartSimulationStepRangeKernel_BurstManaged(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x00000001855168E8-0x0000000185516B08
			[BurstCompile]
			public static void Spring_BurstManaged([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio) {} // 0x000000018552092C-0x0000000185520E30
			[BurstCompile]
			public static unsafe void Wind_BurstManaged(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result) {} // 0x0000000185522438-0x0000000185522818
			[BurstCompile]
			public static void WindForceBlend_BurstManaged([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result) {} // 0x0000000185516B08-0x0000000185517ACC
		}
	
		[BurstCompile]
		private static class UpdateStepBasicPotureJobKernels // TypeDefIndex: 45090
		{
			// Nested types
			public unsafe delegate void UpdateStepBasicPotureKernel_0000040A_PostfixBurstDelegate(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // TypeDefIndex: 45086; 0x0000000185465864-0x000000018546590C
	
			internal static class UpdateStepBasicPotureKernel_0000040A_BurstDirectCall // TypeDefIndex: 45087
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateStepBasicPotureKernel_0000040A_BurstDirectCall() {} // 0x0000000183CE9490-0x0000000183CE94A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060858) {} // 0x0000000185525F78-0x000000018552607C
				private static IntPtr GetFunctionPointer() => default; // 0x000000018552607C-0x00000001855260D0
				public static void Constructor() {} // 0x0000000183CE94A0-0x0000000183CE9530
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x00000001855260D0-0x000000018552629C
			}
	
			public unsafe delegate void UpdateStepBasicPotureRangeKernel_0000040B_PostfixBurstDelegate(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // TypeDefIndex: 45088; 0x0000000185465D9C-0x0000000185465E48
	
			internal static class UpdateStepBasicPotureRangeKernel_0000040B_BurstDirectCall // TypeDefIndex: 45089
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateStepBasicPotureRangeKernel_0000040B_BurstDirectCall() {} // 0x0000000183CE93F0-0x0000000183CE9400
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060888) {} // 0x0000000185526394-0x0000000185526498
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185526498-0x00000001855264EC
				public static void Constructor() {} // 0x0000000183CE9400-0x0000000183CE9490
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x00000001855264EC-0x00000001855266B4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void UpdateStepBasicPotureKernel(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x0000000185525D7C-0x0000000185525E78
			[BurstCompile]
			internal static unsafe void UpdateStepBasicPotureRangeKernel(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x0000000185525E78-0x0000000185525F78
			[BurstCompile]
			public static unsafe void UpdateStepBasicPotureKernel_BurstManaged(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x00000001855254B4-0x0000000185525D7C
			[BurstCompile]
			public static unsafe void UpdateStepBasicPotureRangeKernel_BurstManaged(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x0000000185517ACC-0x0000000185517BC8
		}
	
		[BurstCompile]
		private static class EndSimulationStepJobKernels // TypeDefIndex: 45095
		{
			// Nested types
			public unsafe delegate void EndSimulationStepKernel_0000040C_PostfixBurstDelegate(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // TypeDefIndex: 45091; 0x000000018551B568-0x000000018551B634
	
			internal static class EndSimulationStepKernel_0000040C_BurstDirectCall // TypeDefIndex: 45092
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EndSimulationStepKernel_0000040C_BurstDirectCall() {} // 0x0000000183CEB790-0x0000000183CEB7A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060902) {} // 0x000000018551B0B8-0x000000018551B1BC
				private static IntPtr GetFunctionPointer() => default; // 0x000000018551B1BC-0x000000018551B210
				public static void Constructor() {} // 0x0000000183CEB7A0-0x0000000183CEB830
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index) {} // 0x000000018551B210-0x000000018551B434
			}
	
			public unsafe delegate void EndSimulationStepRangeKernel_0000040D_PostfixBurstDelegate(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // TypeDefIndex: 45093; 0x000000018551BB8C-0x000000018551BC5C
	
			internal static class EndSimulationStepRangeKernel_0000040D_BurstDirectCall // TypeDefIndex: 45094
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EndSimulationStepRangeKernel_0000040D_BurstDirectCall() {} // 0x0000000183CEB650-0x0000000183CEB660
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006093b) {} // 0x000000018551B6FC-0x000000018551B800
				private static IntPtr GetFunctionPointer() => default; // 0x000000018551B800-0x000000018551B854
				public static void Constructor() {} // 0x0000000183CEB660-0x0000000183CEB6F0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x000000018551B854-0x000000018551BA70
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void EndSimulationStepKernel(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index) {} // 0x000000018551AC70-0x000000018551AD9C
			[BurstCompile]
			internal static unsafe void EndSimulationStepRangeKernel(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x000000018551AD9C-0x000000018551AEC8
			[BurstCompile]
			public static unsafe void EndSimulationStepKernel_BurstManaged(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index) {} // 0x0000000185519EB8-0x000000018551AC70
			[BurstCompile]
			public static unsafe void EndSimulationStepRangeKernel_BurstManaged(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x00000001855133C0-0x00000001855134F0
		}
	
		[BurstCompile]
		private static class CalcDisplayPositionJobKernels // TypeDefIndex: 45100
		{
			// Nested types
			public unsafe delegate void CalcDisplayPositionKernel_0000040E_PostfixBurstDelegate(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // TypeDefIndex: 45096; 0x000000018552A0C0-0x000000018552A15C
	
			internal static class CalcDisplayPositionKernel_0000040E_BurstDirectCall // TypeDefIndex: 45097
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcDisplayPositionKernel_0000040E_BurstDirectCall() {} // 0x0000000183CEC910-0x0000000183CEC920
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000609a0) {} // 0x0000000185529CB8-0x0000000185529DBC
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185529DBC-0x0000000185529E10
				public static void Constructor() {} // 0x0000000183CEC920-0x0000000183CEC9B0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex) {} // 0x0000000185529E10-0x0000000185529FBC
			}
	
			public unsafe delegate void CalcDisplayPositionRangeKernel_0000040F_PostfixBurstDelegate(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // TypeDefIndex: 45098; 0x000000018552A0C0-0x000000018552A15C
	
			internal static class CalcDisplayPositionRangeKernel_0000040F_BurstDirectCall // TypeDefIndex: 45099
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcDisplayPositionRangeKernel_0000040F_BurstDirectCall() {} // 0x0000000183CEC870-0x0000000183CEC880
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000609cd) {} // 0x000000018552A224-0x000000018552A328
				private static IntPtr GetFunctionPointer() => default; // 0x000000018552A328-0x000000018552A37C
				public static void Constructor() {} // 0x0000000183CEC880-0x0000000183CEC910
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length) {} // 0x000000018552A37C-0x000000018552A528
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcDisplayPositionKernel(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex) {} // 0x0000000185518120-0x0000000185518210
			[BurstCompile]
			internal static unsafe void CalcDisplayPositionRangeKernel(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length) {} // 0x0000000185518304-0x00000001855183F4
			[BurstCompile]
			public static unsafe void CalcDisplayPositionKernel_BurstManaged(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex) {} // 0x0000000185517BC8-0x0000000185518120
			[BurstCompile]
			public static unsafe void CalcDisplayPositionRangeKernel_BurstManaged(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length) {} // 0x0000000185518210-0x0000000185518304
		}
	
		[BurstCompile]
		private static class ClearStepCounterKernels // TypeDefIndex: 45103
		{
			// Nested types
			public unsafe delegate void ClearStepCounterKernel_00000410_PostfixBurstDelegate(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // TypeDefIndex: 45101; 0x000000018546794C-0x00000001854679C0
	
			internal static class ClearStepCounterKernel_00000410_BurstDirectCall // TypeDefIndex: 45102
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearStepCounterKernel_00000410_BurstDirectCall() {} // 0x0000000183CEBF10-0x0000000183CEBF20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060a08) {} // 0x000000018552A62C-0x000000018552A730
				private static IntPtr GetFunctionPointer() => default; // 0x000000018552A730-0x000000018552A784
				public static void Constructor() {} // 0x0000000183CEBF20-0x0000000183CEBFB0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint) {} // 0x000000018552A784-0x000000018552A8C0
			}
	
			// Methods
			[BurstCompile]
			internal static unsafe void ClearStepCounterKernel(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint) {} // 0x000000018552A8C0-0x000000018552A984
			[BurstCompile]
			public static unsafe void ClearStepCounterKernel_BurstManaged(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint) {} // 0x0000000183D4FCD0-0x0000000183D4FD10
		}
	
		[BurstCompile]
		private struct PreSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45104
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
			public void SetIndexCount(int indexCount) {} // 0x0000000183079CE0-0x0000000183079F50
			[IDTag(1)]
			public void Execute() {} // 0x000000018552D454-0x000000018552D4CC
			[IDTag(0)]
			public void Execute(int pindex) {} // 0x000000018552CAE4-0x000000018552D454
			public void UnsafeDo() {} // 0x000000018552D4CC-0x000000018552D704
		}
	
		[BurstCompile]
		private struct ClearStepCounter : IJob, IUnsafeJob // TypeDefIndex: 45105
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
			public void Execute() {} // 0x000000018552A984-0x000000018552AA34
			public void UnsafeDo() {} // 0x000000018552AA34-0x000000018552AB2C
		}
	
		[BurstCompile]
		private struct CreateUpdateParticleList : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45106
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
			public void SetIndexCount(int indexCount) {} // 0x0000000182EEA750-0x0000000182EEA7E0
			[IDTag(1)]
			public void Execute() {} // 0x000000018552AB2C-0x000000018552ABA4
			[IDTag(0)]
			public void Execute(int teamId) {} // 0x000000018552ABA4-0x000000018552B050
			public void UnsafeDo() {} // 0x000000018552B050-0x000000018552B27C
		}
	
		[BurstCompile]
		private struct StartSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45107
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182EF74B0-0x0000000182EF7550
			[IDTag(1)]
			public void Execute() {} // 0x000000018552F46C-0x000000018552F504
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018552E60C-0x000000018552F46C
			private void Spring([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, float scaleRatio) {} // 0x000000018552F504-0x000000018552FAA0
			private void Wind(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, ref float3 result) {} // 0x0000000185530124-0x0000000185530584
			private void WindForceBlend([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result) {} // 0x000000018552FDB4-0x0000000185530124
			public void UnsafeDo() {} // 0x000000018552FAA0-0x000000018552FDB4
		}
	
		[BurstCompile]
		private struct UpdateStepBasicPotureJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45108
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182EE71A0-0x0000000182EE7240
			[IDTag(1)]
			public void Execute() {} // 0x0000000185535AD4-0x0000000185535B6C
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185535B6C-0x00000001855364A0
			public void UnsafeDo() {} // 0x00000001855364A0-0x0000000185536654
		}
	
		[BurstCompile]
		private struct EndSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45109
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000182EF8460-0x0000000182EF8500
			[IDTag(1)]
			public void Execute() {} // 0x000000018552C098-0x000000018552C130
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018552B27C-0x000000018552C098
			public void UnsafeDo() {} // 0x000000018552C130-0x000000018552C34C
		}
	
		[BurstCompile]
		private struct CalcDisplayPositionJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45110
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
			public void SetIndexCount(int indexCount) {} // 0x000000018309AA60-0x000000018309AAA0
			[IDTag(1)]
			public void Execute() {} // 0x0000000185529554-0x00000001855295CC
			[IDTag(0)]
			public void Execute(int pindex) {} // 0x00000001855295CC-0x0000000185529B48
			public void UnsafeDo() {} // 0x0000000185529B48-0x0000000185529CB8
		}
	
		[BurstCompile]
		private struct FeedbackTempPosJob : IJobParallelForDefer // TypeDefIndex: 45111
		{
			// Fields
			[ReadOnly]
			public NativeList<int> jobParticleIndexList; // 0x00
			[ReadOnly]
			public NativeArray<double3> tempFloat3Buffer; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x000000018552C3CC-0x000000018552C478
		}
	
		[BurstCompile]
		private struct FeedbackTempPosJob2 : IJobParallelForDefer // TypeDefIndex: 45112
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> particleIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<double3> tempFloat3Buffer; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x000000018552C34C-0x000000018552C3CC
		}
	
		// Constructors
		public SimulationManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x00000001834E3000-0x00000001834E34C0
		public void EnterdEditMode() {} // 0x000000018551F604-0x000000018551F654
		public void Initialize() {} // 0x00000001834E1A10-0x00000001834E26A0
		public bool IsValid() => default; // 0x0000000185520488-0x00000001855204D8
		internal void RegisterProxyMesh(ClothProcess cprocess) {} // 0x0000000182701E80-0x0000000182702140
		internal void RegisterConstraint(ClothProcess cprocess) {} // 0x0000000182E19BD0-0x0000000182E19E20
		internal void ExitProxyMesh(ClothProcess cprocess) {} // 0x0000000183211140-0x0000000183211470
		internal void WorkBufferUpdate() {} // 0x0000000182C4BC00-0x0000000182C4C050
		internal JobHandle PreSimulationUpdate(JobHandle jobHandle) => default; // 0x0000000182C4AC30-0x0000000182C4B080
		internal JobHandle SimulationStepUpdate(int updateCount, int updateIndex, JobHandle jobHandle) => default; // 0x000000018281CC30-0x000000018281E520
		internal JobHandle CalcDisplayPosition(JobHandle jobHandle) => default; // 0x0000000182C4A8B0-0x0000000182C4AC30
		[IDTag(0)]
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in NativeList<int> particleList, JobHandle jobHandle) => default; // 0x000000018551F654-0x000000018551F794
		[IDTag(2)]
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in ExProcessingList<int> processingList, JobHandle jobHandle) => default; // 0x000000018551F8E4-0x000000018551F9B0
		[IDTag(1)]
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in NativeArray<int> particleArray, [IsReadOnly] in NativeReference<int> counter, JobHandle jobHandle) => default; // 0x000000018551F794-0x000000018551F8E4
		public void InformationLog(StringBuilder allsb) {} // 0x000000018551F9B0-0x0000000185520488
		public static void Initialize_StartSimulationStepJobKernels_StartSimulationStepKernel_00000405_BurstDirectCall() {} // 0x00000001835EBD00-0x00000001835EBD60
		public static void Initialize_StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000406_BurstDirectCall() {} // 0x00000001835EBD60-0x00000001835EBDC0
		public static void Initialize_StartSimulationStepJobKernels_Spring_00000407_BurstDirectCall() {} // 0x00000001835EBDC0-0x00000001835EBE20
		public static void Initialize_StartSimulationStepJobKernels_Wind_00000408_BurstDirectCall() {} // 0x00000001835EBE20-0x00000001835EBE80
		public static void Initialize_StartSimulationStepJobKernels_WindForceBlend_00000409_BurstDirectCall() {} // 0x00000001835EBE80-0x00000001835EBEE0
		public static void Initialize_UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040A_BurstDirectCall() {} // 0x00000001835EBEE0-0x00000001835EBF40
		public static void Initialize_UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040B_BurstDirectCall() {} // 0x00000001835EBF40-0x00000001835EBFA0
		public static void Initialize_EndSimulationStepJobKernels_EndSimulationStepKernel_0000040C_BurstDirectCall() {} // 0x00000001835EBFA0-0x00000001835EC000
		public static void Initialize_EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040D_BurstDirectCall() {} // 0x00000001835EC000-0x00000001835EC060
		public static void Initialize_CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_0000040E_BurstDirectCall() {} // 0x00000001835EC060-0x00000001835EC0C0
		public static void Initialize_CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_0000040F_BurstDirectCall() {} // 0x00000001835EC0C0-0x00000001835EC120
		public static void Initialize_ClearStepCounterKernels_ClearStepCounterKernel_00000410_BurstDirectCall() {} // 0x00000001835EC120-0x00000001835EC180
	}

	public class TimeManager : IManager, IValid // TypeDefIndex: 45115
	{
		// Fields
		internal int simulationFrequency; // 0x10
		internal int maxSimulationCountPerFrame; // 0x14
		internal UpdateLocation updateLocation; // 0x18
		private bool isValid; // 0x1C
		internal float GlobalTimeScale; // 0x24
	
		// Properties
		internal int FixedUpdateCount { get; private set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		internal float SimulationDeltaTime { get; private set; } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
		internal float MaxDeltaTime { get; private set; } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000183D4F3B0-0x0000000183D4F3C0
		internal float4 SimulationPower { get; private set; } // 0x0000000183D4FD30-0x0000000183D4FD40 0x0000000183D4FD40-0x0000000183D4FD50
		internal static float DeltaTime { get; set; } // 0x00000001855311F0-0x0000000185531228 0x00000001855312D0-0x0000000185531314
		internal static float FixedDeltaTime { get; set; } // 0x0000000185531260-0x0000000185531298 0x0000000185531350-0x0000000185531398
		internal static float UnscaledDeltaTime { get; set; } // 0x0000000185531298-0x00000001855312D0 0x0000000185531398-0x00000001855313E0
		internal static bool EnableAOVMode { get; set; } // 0x0000000185531228-0x0000000185531260 0x0000000185531314-0x0000000185531350
	
		// Nested types
		public enum UpdateLocation // TypeDefIndex: 45114
		{
			AfterLateUpdate = 0,
			BeforeLateUpdate = 1
		}
	
		// Constructors
		public TimeManager() {} // 0x0000000183D4FD10-0x0000000183D4FD30
	
		// Methods
		public void Dispose() {} // 0x0000000185530C68-0x0000000185530E98
		public void EnterdEditMode() {} // 0x0000000185530E98-0x0000000185530EE8
		public void Initialize() {} // 0x0000000182ECC860-0x0000000182ECCAB0
		public bool IsValid() => default; // 0x00000001855311A4-0x00000001855311F0
		private void AfterFixedUpdate() {} // 0x00000001830EA0E0-0x00000001830EA160
		private void AfterRenderring() {} // 0x00000001823159F0-0x0000000182315A80
		public static float GetDeltaTime() => default; // 0x0000000182311420-0x00000001823114A0
		public static float GetFixedDeltaTime() => default; // 0x00000001823114A0-0x00000001823114E0
		public static float GetUnscaledDeltaTime() => default; // 0x00000001823113E0-0x0000000182311420
		internal void FrameUpdate() {} // 0x0000000182817A30-0x0000000182817C00
		public void InformationLog(StringBuilder allsb) {} // 0x0000000185530EE8-0x00000001855311A4
	}

	public class WindManager : IManager, IValid // TypeDefIndex: 45117
	{
		// Fields
		public const int Flag_Valid = 0; // Metadata: 0x01FB9348
		public const int Flag_Enable = 1; // Metadata: 0x01FB9349
		public const int Flag_Addition = 2; // Metadata: 0x01FB934A
		public ExNativeArray<WindData> windDataArray; // 0x10
		private bool isValid; // 0x18
		private Dictionary<int, BeyondBoneWindZone> windZoneDict; // 0x20
	
		// Properties
		public int WindCount { get => default; } // 0x0000000182C4B490-0x0000000182C4B4D0 
	
		// Nested types
		public struct WindData // TypeDefIndex: 45116
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
			public bool IsValid() => default; // 0x00000001855366F4-0x0000000185536744
			public bool IsEnable() => default; // 0x00000001855366A4-0x00000001855366F4
			public bool IsAddition() => default; // 0x0000000185536654-0x00000001855366A4
		}
	
		// Constructors
		public WindManager() {} // 0x0000000182ECAEC0-0x0000000182ECAF40
	
		// Methods
		public void Dispose() {} // 0x0000000182ECB170-0x0000000182ECB1C0
		public void EnterdEditMode() {} // 0x00000001855368E4-0x0000000185536934
		public void Initialize() {} // 0x0000000182ECB0C0-0x0000000182ECB170
		public bool IsValid() => default; // 0x0000000185536C88-0x0000000185536CD4
		public int AddWind(BeyondBoneWindZone windZone) => default; // 0x0000000185536744-0x00000001855368E4
		public void RemoveWind(int windId) {} // 0x0000000185536CD4-0x0000000185536E58
		public void SetEnable(int windId, bool sw) {} // 0x0000000185536E58-0x000000018553729C
		internal void AlwaysWindUpdate() {} // 0x00000001830E44D0-0x00000001830E4C90
		public void InformationLog(StringBuilder allsb) {} // 0x0000000185536934-0x0000000185536C88
	}

	[Serializable]
	public class BeyondBoneClothSavePoint // TypeDefIndex: 45118
	{
		// Fields
		public BeyondBoneClothSavePoint_TeamManagerTeamData teamManagerTeamData; // 0x10
		public BeyondBoneClothSavePoint_ColliderManagerData colliderManagerData; // 0x18
		public BeyondBoneClothSavePoint_SimulationManagerData simulationManagerData; // 0x20
		public BeyondBoneClothSavePoint_VirtualMeshManagerData virtualMeshManagerData; // 0x28
		public BeyondBoneClothSavePoint_InertiaConstraintCenterData inertiaConstraintCenterData; // 0x30
	
		// Constructors
		public BeyondBoneClothSavePoint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Load(ClothProcess cprocess, ColliderManager colliderManager, SimulationManager simulationManager, VirtualMeshManager virtualMeshManager, TeamManager teamManager) {} // 0x0000000185528034-0x000000018552825C
		public void LoadTeamManagerTeamData(ref TeamManager.TeamData teamData) {} // 0x0000000185527E80-0x0000000185527EFC
		public void LoadColliderManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, ColliderManager colliderManager) {} // 0x0000000185527648-0x0000000185527864
		public void LoadSimulationManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, SimulationManager simulationManager) {} // 0x0000000185527B38-0x0000000185527E80
		public void LoadVirtualMeshManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, VirtualMeshManager virtualMeshManager) {} // 0x0000000185527EFC-0x0000000185528034
		public void LoadInertiaConstraintCenterData(ClothProcess cprocess, TeamManager teamManager) {} // 0x0000000185527864-0x0000000185527B38
		public void Save(ClothProcess cprocess, ColliderManager colliderManager, SimulationManager simulationManager, VirtualMeshManager virtualMeshManager, TeamManager teamManager) {} // 0x0000000185529424-0x0000000185529554
		public void SaveTeamManagerTeamData(ref TeamManager.TeamData teamData) {} // 0x000000018552912C-0x00000001855291E8
		public void SaveColliderManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, ColliderManager colliderManager) {} // 0x000000018552825C-0x000000018552867C
		public void SaveSimulationManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, SimulationManager simulationManager) {} // 0x0000000185528A64-0x000000018552912C
		public void SaveVirtualMeshManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, VirtualMeshManager virtualMeshManager) {} // 0x00000001855291E8-0x0000000185529424
		public void SaveInertiaConstraintCenterData(ClothProcess cprocess, TeamManager teamManager) {} // 0x000000018552867C-0x0000000185528A64
	}

	internal static class BeyondBoneClothSavePointHelper // TypeDefIndex: 45119
	{
		// Extension methods
		internal static void AddFromNative<T>(this List<T> targetList, NativeArray<T> sourceArray, int sourceStartIndex, int length)
			where T : struct {}
		internal static void FillFromList<T>(this NativeArray<T> targetArray, int targetStartIndex, List<T> sourceList, int sourceStartIndex, int length)
			where T : struct {}
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_TeamManagerTeamData // TypeDefIndex: 45120
	{
		// Fields
		public float velocityWeight; // 0x10
		public float blendWeight; // 0x14
	
		// Constructors
		public BeyondBoneClothSavePoint_TeamManagerTeamData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_ColliderManagerData // TypeDefIndex: 45121
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
		public BeyondBoneClothSavePoint_ColliderManagerData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_SimulationManagerData // TypeDefIndex: 45122
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
		public BeyondBoneClothSavePoint_SimulationManagerData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_VirtualMeshManagerData // TypeDefIndex: 45123
	{
		// Fields
		public int proxyMeshVertexCount; // 0x10
		public List<double3> positions; // 0x18
		public List<quaternion> rotations; // 0x20
	
		// Constructors
		public BeyondBoneClothSavePoint_VirtualMeshManagerData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_InertiaConstraintCenterData // TypeDefIndex: 45124
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
		public BeyondBoneClothSavePoint_InertiaConstraintCenterData() {} // 0x000000018350B670-0x000000018350B680
	}

	public struct TeamWindInfo : IValid // TypeDefIndex: 45125
	{
		// Fields
		public int windId; // 0x00
		public float time; // 0x04
		public float main; // 0x08
		public float3 direction; // 0x0C
	
		// Methods
		public bool IsValid() => default; // 0x00000001855309F8-0x0000000185530A50
		public override string ToString() => default; // 0x0000000185530A50-0x0000000185530C10
		public void DebugLog() {} // 0x0000000185530970-0x00000001855309F8
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185530C10-0x0000000185530C68
	}

	public struct TeamWindData // TypeDefIndex: 45126
	{
		// Fields
		public FixedList128Bytes<TeamWindInfo> windZoneList; // 0x00
		public TeamWindInfo movingWind; // 0x80
	
		// Properties
		public int ZoneCount { get => default; } // 0x000000018553093C-0x0000000185530970 
	
		// Methods
		public int IndexOf(int windId) => default; // 0x00000001855307E4-0x00000001855308A8
		public void ClearZoneList() {} // 0x0000000185530770-0x00000001855307E4
		public void AddOrReplaceWindZone(TeamWindInfo windInfo, [IsReadOnly] in TeamWindData oldWindData) {} // 0x0000000185530584-0x0000000185530770
		public void RemoveWindZone(int windId) {} // 0x00000001855308A8-0x000000018553093C
	}

	public class TransformData : IDisposable // TypeDefIndex: 45131
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
		public int Count { get => default; } // 0x0000000182E20FD0-0x0000000182E21010 
		public int RootCount { get => default; } // 0x00000001838E4950-0x00000001838E4990 
		public bool IsDirty { get => default; } // 0x0000000183D4F800-0x0000000183D4F810 
		public bool IsEmpty { get => default; } // 0x00000001825EB8A0-0x00000001825EB8B0 
	
		// Nested types
		[BurstCompile]
		private struct RestoreTransformJob : IJobParallelForTransform // TypeDefIndex: 45127
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
			public void Execute(int index, TransformAccess transform) {} // 0x000000018552E1D0-0x000000018552E2E8
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 45128
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
			public void Execute(int index, TransformAccess transform) {} // 0x000000018552D704-0x000000018552DA90
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 45129
		{
			// Fields
			public ExSimpleNativeArray<ExBitFlag8> flagArray; // 0x10
			public ExSimpleNativeArray<float3> initLocalPositionArray; // 0x18
			public ExSimpleNativeArray<quaternion> initLocalRotationArray; // 0x20
	
			// Constructors
			public ShareSerializationData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 45130
		{
			// Fields
			public Transform[] transformArray; // 0x10
	
			// Constructors
			public UniqueSerializationData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000185535880-0x0000000185535968
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x0000000185535968-0x0000000185535AD4
		}
	
		// Constructors
		public TransformData() {} // 0x000000018350B670-0x000000018350B680
		public TransformData(int capacity) {} // 0x0000000182E1E350-0x0000000182E1E360
	
		// Methods
		public void Init(int capacity) {} // 0x0000000182E1F340-0x0000000182E1F710
		public void Dispose() {} // 0x0000000182E1F7B0-0x0000000182E1F970
		[IDTag(2)]
		public int AddTransform(Transform t, int tid = 0 /* Metadata: 0x01FB934B */, int pid = 0 /* Metadata: 0x01FB934C */, byte flag = 1 /* Metadata: 0x01FB934D */, bool checkDuplicate = true /* Metadata: 0x01FB934E */) => default; // 0x0000000185531F2C-0x0000000185532A54
		[IDTag(0)]
		public int AddTransform(TransformRecord record, int pid = 0 /* Metadata: 0x01FB934F */, byte flag = 1 /* Metadata: 0x01FB9350 */, bool checkDuplicate = true /* Metadata: 0x01FB9351 */) => default; // 0x000000018553185C-0x0000000185531F2C
		[IDTag(1)]
		public int AddTransform(TransformData srcData, int srcIndex, bool checkDuplicate = true /* Metadata: 0x01FB9352 */) => default; // 0x0000000185532A54-0x00000001855330A0
		[IDTag(1)]
		public int[] AddTransformRange(List<Transform> tlist, List<int> idList, List<int> pidList, int copyCount = 0 /* Metadata: 0x01FB9353 */) => default; // 0x000000018553153C-0x000000018553185C
		[IDTag(2)]
		public int[] AddTransformRange(TransformData stdata, int copyCount = 0 /* Metadata: 0x01FB9354 */) => default; // 0x00000001855313E0-0x000000018553153C
		[IDTag(0)]
		public int[] AddTransformRange(List<Transform> tlist, List<int> idList, List<int> pidList, List<int> rootIds, NativeArray<float3> localPositions, NativeArray<quaternion> localRotations, NativeArray<float3> positions, NativeArray<quaternion> rotations, NativeArray<float3> scales, NativeArray<quaternion> inverseRotations) => default; // 0x0000000182E22EC0-0x0000000182E232C0
		public void RemoveTransformIndex(int index) {} // 0x000000018553442C-0x00000001855344FC
		public int ReplaceTransform(int index, Transform t, int tid = 0 /* Metadata: 0x01FB9355 */, int pid = 0 /* Metadata: 0x01FB9356 */, byte flag = 1 /* Metadata: 0x01FB9357 */) => default; // 0x00000001855344FC-0x0000000185534A04
		private int ReferenceIndexOf<T>(List<T> list, T item)
			where T : class => default;
		public void UpdateWorkData() {} // 0x0000000185535068-0x0000000185535130
		public JobHandle RestoreTransform(int count, JobHandle jobHandle = default) => default; // 0x0000000185534A04-0x0000000185534B94
		public JobHandle ReadTransform(JobHandle jobHandle = default) => default; // 0x0000000185534268-0x000000018553442C
		public void ReadTransformRun() {} // 0x000000018553410C-0x0000000185534268
		public void OrganizeReductionTransform(VirtualMesh vmesh, ReductionWorkData workData) {} // 0x0000000185533520-0x000000018553410C
		public Transform GetTransformFromIndex(int index) => default; // 0x0000000182702E70-0x0000000182702EE0
		public int GetTransformIndexFormId(int id) => default; // 0x0000000185533384-0x0000000185533444
		public int GetTransformIdFromIndex(int index) => default; // 0x0000000185533300-0x0000000185533384
		public int GetParentIdFromIndex(int index) => default; // 0x000000018553327C-0x0000000185533300
		public float4x4 GetLocalToWorldMatrix(int index) => default; // 0x00000001855330A0-0x000000018553327C
		public float4x4 GetWorldToLocalMatrix(int index) => default; // 0x0000000185533444-0x0000000185533520
		public override string ToString() => default; // 0x0000000185534D48-0x0000000185534F20
		public ShareSerializationData ShareSerialize() => default; // 0x0000000185534B94-0x0000000185534D48
		public static TransformData ShareDeserialize(ShareSerializationData sdata) => default; // 0x0000000182E1CE80-0x0000000182E1D020
		public UniqueSerializationData UniqueSerialize() => default; // 0x0000000185534F20-0x0000000185535068
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public class TransformRecord : IValid, ITransform // TypeDefIndex: 45132
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
		public TransformRecord() {} // Dummy constructor
		public TransformRecord(Transform t) {} // 0x0000000182E27AF0-0x0000000182E27CF0
	
		// Methods
		public Vector3 InverseTransformDirection(Vector3 dir) => default; // 0x00000001855351BC-0x0000000185535298
		public bool IsValid() => default; // 0x0000000185535298-0x00000001855352E8
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000185535130-0x00000001855351BC
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001855352E8-0x0000000185535400
	}

	[CreateAssetMenu(fileName = "Data", menuName = "MagicaCloth2/PreBuildScriptableObject")]
	public class PreBuildScriptableObject : ScriptableObject // TypeDefIndex: 45135
	{
		// Fields
		public List<SharePreBuildData> sharePreBuildDataList; // 0x18
	
		// Constructors
		public PreBuildScriptableObject() {} // 0x000000018552C910-0x000000018552C990
	
		// Methods
		public bool HasPreBuildData(string buildId) => default; // 0x000000018552C750-0x000000018552C7BC
		public SharePreBuildData GetPreBuildData(string buildId) => default; // 0x000000018552C5DC-0x000000018552C750
		public void AddPreBuildData(SharePreBuildData sdata) {} // 0x000000018552C478-0x000000018552C5DC
		public void Warmup() {} // 0x000000018552C7BC-0x000000018552C910
	}

	[Serializable]
	public class PreBuildSerializeData : ITransform // TypeDefIndex: 45136
	{
		// Fields
		public bool enabled; // 0x10
		public SharePreBuildData preBuildData; // 0x18
		public UniquePreBuildData uniquePreBuildData; // 0x20
	
		// Constructors
		public PreBuildSerializeData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool UsePreBuild() => default; // 0x00000001838302B0-0x00000001838302E0
		public ResultCode DataValidate() => default; // 0x0000000182E1BE70-0x0000000182E1BF70
		public SharePreBuildData GetSharePreBuildData() => default; // 0x0000000182E1BF70-0x0000000182E1BFA0
		public static string GenerateBuildID() => default; // 0x000000018552C990-0x000000018552CA0C
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018552CA0C-0x000000018552CA78
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x000000018552CA78-0x000000018552CAE4
	}

	[Serializable]
	public class SharePreBuildData // TypeDefIndex: 45137
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
		public SharePreBuildData() {} // 0x0000000183589950-0x0000000183589AB0
	
		// Methods
		public ResultCode DataValidate() => default; // 0x0000000182E1C290-0x0000000182E1C300
		public bool CheckBuildId(string buildId) => default; // 0x000000018552E2E8-0x000000018552E35C
		public override string ToString() => default; // 0x000000018552E35C-0x000000018552E60C
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	[Serializable]
	public class UniquePreBuildData : ITransform // TypeDefIndex: 45140
	{
		// Fields
		public int version; // 0x10
		public ResultCode buildResult; // 0x14
		public List<RenderSetupData.UniqueSerializationData> renderSetupDataList; // 0x20
		public VirtualMesh.UniqueSerializationData proxyMesh; // 0x28
		public List<VirtualMesh.UniqueSerializationData> renderMeshList; // 0x30
	
		// Constructors
		public UniquePreBuildData() {} // 0x0000000183589880-0x0000000183589950
	
		// Methods
		public ResultCode DataValidate() => default; // 0x0000000182E1C230-0x0000000182E1C290
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000185535550-0x00000001855356E8
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001855356E8-0x0000000185535880
	}

	[Serializable]
	public class ReductionSettings : IDataValidate // TypeDefIndex: 45141
	{
		// Fields
		[Range(0f, 0.2f)]
		public float simpleDistance; // 0x10
		[Range(0f, 0.2f)]
		public float shapeDistance; // 0x14
	
		// Properties
		public bool IsEnabled { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public ReductionSettings() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public float GetMaxConnectionDistance() => default; // 0x000000018552DC0C-0x000000018552DC90
		public ReductionSettings Clone() => default; // 0x000000018552DA90-0x000000018552DB1C
		public void DataValidate() {} // 0x000000018552DB1C-0x000000018552DBA4
		public override int GetHashCode() => default; // 0x000000018552DBA4-0x000000018552DC0C
		public override string ToString() => default; // 0x000000018552DC90-0x000000018552DE3C
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public class ReductionWorkData : IDisposable // TypeDefIndex: 45142
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
		public ReductionWorkData() {} // Dummy constructor
		public ReductionWorkData(VirtualMesh vmesh) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public void Dispose() {} // 0x000000018552DE3C-0x000000018552E1D0
	}

	public class SameDistanceReduction : IDisposable // TypeDefIndex: 45149
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
		public ResultCode Result { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Nested types
		[BurstCompile]
		private struct InitGridJob : IJob // TypeDefIndex: 45143
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
			public void Execute() {} // 0x000000018553E660-0x000000018553E748
		}
	
		[BurstCompile]
		private struct SearchJoinJob : IJob // TypeDefIndex: 45144
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
			public void Execute() {} // 0x0000000185545B34-0x0000000185545F98
		}
	
		[BurstCompile]
		private struct JoinJob2 : IJob // TypeDefIndex: 45145
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
			public void Execute() {} // 0x000000018553F61C-0x000000018553FC1C
		}
	
		[BurstCompile]
		private struct UpdateJoinIndexJob : IJobParallelFor // TypeDefIndex: 45146
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018554803C-0x00000001855480C4
		}
	
		[BurstCompile]
		private struct UpdateLinkIndexJob : IJobParallelFor // TypeDefIndex: 45147
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x10
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185548314-0x00000001855486D4
		}
	
		[BurstCompile]
		private struct FinalMergeVertexJob : IJobParallelFor // TypeDefIndex: 45148
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018553E56C-0x000000018553E660
		}
	
		// Constructors
		public SameDistanceReduction() {} // 0x0000000185545094-0x00000001855450DC
		public SameDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float mergeLength) {} // 0x00000001855450DC-0x00000001855451AC
	
		// Methods
		public virtual void Dispose() {} // 0x000000018554456C-0x0000000185544660
		public ResultCode Reduction() => default; // 0x0000000185544660-0x0000000185544E6C
		private void UpdateJoinAndLink() {} // 0x0000000185544E6C-0x0000000185544F78
		private void UpdateReductionResultJob() {} // 0x0000000185544F78-0x0000000185545094
	}

	public class ShapeDistanceReduction : StepReductionBase // TypeDefIndex: 45151
	{
		// Nested types
		[BurstCompile]
		private struct SearchJoinEdgeJob : IJob // TypeDefIndex: 45150
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
			public void Execute() {} // 0x00000001855451AC-0x00000001855455A4
		}
	
		// Constructors
		public ShapeDistanceReduction() {} // Dummy constructor
		public ShapeDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment) {} // 0x0000000185546154-0x0000000185546224
	
		// Methods
		public override void Dispose() {} // 0x000000018554609C-0x00000001855460EC
		protected override void StepInitialize() {} // 0x00000001855460EC-0x000000018554613C
		protected override void CustomReductionStep() {} // 0x0000000185545F98-0x000000018554609C
		public void __iFixBaseProxy_Dispose() {} // 0x0000000185546144-0x000000018554614C
		public void __iFixBaseProxy_StepInitialize() {} // 0x000000018554614C-0x0000000185546154
		public void __iFixBaseProxy_CustomReductionStep() {} // 0x000000018554613C-0x0000000185546144
	}

	public class SimpleDistanceReduction : StepReductionBase // TypeDefIndex: 45154
	{
		// Fields
		private GridMap<int> gridMap; // 0x90
	
		// Nested types
		[BurstCompile]
		private struct InitGridJob : IJob // TypeDefIndex: 45152
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
			public void Execute() {} // 0x000000018553E748-0x000000018553E830
		}
	
		[BurstCompile]
		private struct SearchJoinEdgeJob : IJob // TypeDefIndex: 45153
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
			public void Execute() {} // 0x00000001855455A4-0x0000000185545B34
		}
	
		// Constructors
		public SimpleDistanceReduction() {} // Dummy constructor
		public SimpleDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment) {} // 0x00000001855465A0-0x0000000185546670
	
		// Methods
		public override void Dispose() {} // 0x0000000185546448-0x00000001855464CC
		protected override void StepInitialize() {} // 0x00000001855464CC-0x00000001855465A0
		protected override void CustomReductionStep() {} // 0x0000000185546224-0x0000000185546448
		public void __iFixBaseProxy_Dispose() {} // 0x0000000185546144-0x000000018554614C
		public void __iFixBaseProxy_StepInitialize() {} // 0x000000018554614C-0x0000000185546154
		public void __iFixBaseProxy_CustomReductionStep() {} // 0x000000018554613C-0x0000000185546144
	}

	public abstract class StepReductionBase : IDisposable // TypeDefIndex: 45161
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
		public ResultCode Result { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Nested types
		public struct JoinEdge : IComparable<JoinEdge> // TypeDefIndex: 45155
		{
			// Fields
			public int2 vertexPair; // 0x00
			public float cost; // 0x08
	
			// Methods
			public bool Contains([IsReadOnly] in int2 pair) => default; // 0x000000018553F5A4-0x000000018553F61C
			public int CompareTo(JoinEdge other) => default; // 0x000000018553F514-0x000000018553F5A4
		}
	
		[BurstCompile]
		private struct DeterminJoinEdgeJob : IJob // TypeDefIndex: 45156
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
			public void Execute() {} // 0x000000018553E29C-0x000000018553E478
		}
	
		[BurstCompile]
		private struct JoinPairJob : IJob // TypeDefIndex: 45157
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
			public void Execute() {} // 0x000000018553FC1C-0x00000001855402EC
		}
	
		[BurstCompile]
		private struct UpdateJoinIndexJob : IJobParallelFor // TypeDefIndex: 45158
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185547FB4-0x000000018554803C
		}
	
		[BurstCompile]
		private struct UpdateLinkIndexJob : IJobParallelFor // TypeDefIndex: 45159
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x10
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001855480C4-0x0000000185548314
		}
	
		[BurstCompile]
		private struct FinalMergeVertexJob : IJobParallelFor // TypeDefIndex: 45160
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018553E478-0x000000018553E56C
		}
	
		// Constructors
		public StepReductionBase() {} // 0x0000000185547E2C-0x0000000185547E74
		public StepReductionBase(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment) {} // 0x0000000185547D28-0x0000000185547E2C
	
		// Methods
		public virtual void Dispose() {} // 0x0000000185547164-0x000000018554728C
		public ResultCode Reduction() => default; // 0x0000000185547524-0x0000000185547750
		private void InitStep() {} // 0x000000018554728C-0x00000001855472E8
		private bool IsEndStep() => default; // 0x00000001855472E8-0x000000018554734C
		private void NextStep() {} // 0x000000018554734C-0x00000001855473D8
		private void ReductionStep() {} // 0x00000001855474BC-0x0000000185547524
		protected virtual void StepInitialize() {} // 0x0000000185547990-0x0000000185547B00
		protected virtual void CustomReductionStep() {} // 0x0000000185547030-0x0000000185547074
		private void PreReductionStep() {} // 0x0000000185547448-0x00000001855474BC
		private void PostReductionStep() {} // 0x00000001855473D8-0x0000000185547448
		private void SortJoinEdge() {} // 0x0000000185547910-0x0000000185547990
		private void DetermineJoinEdge() {} // 0x0000000185547074-0x0000000185547164
		private void RunJoinEdge() {} // 0x0000000185547750-0x0000000185547910
		private void UpdateJoinAndLink() {} // 0x0000000185547B00-0x0000000185547C0C
		private void UpdateReductionResultJob() {} // 0x0000000185547C0C-0x0000000185547D28
		protected static bool CheckJoin2([IsReadOnly] in NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap, int vindex, int tvindex, bool dontMakeLine) => default; // 0x0000000185546670-0x0000000185546B54
		protected static bool CheckJoin([IsReadOnly] in NativeArray<FixedList128Bytes<ushort>> vertexToVertexArray, int vindex, int tvindex, [IsReadOnly] in FixedList128Bytes<ushort> vlist, [IsReadOnly] in FixedList128Bytes<ushort> tvlist, bool dontMakeLine) => default; // 0x0000000185546B54-0x0000000185547030
	}

	[Serializable]
	public class ClothDebugSettings // TypeDefIndex: 45163
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
		public enum DebugAxis // TypeDefIndex: 45162
		{
			None = 0,
			Normal = 1,
			All = 2
		}
	
		// Constructors
		public ClothDebugSettings() {} // 0x0000000183D4FD80-0x0000000183D4FD90
	
		// Methods
		public bool CheckParticleDrawing(int index) => default; // 0x000000018553C888-0x000000018553C8E0
		public bool CheckTriangleDrawing(int index) => default; // 0x000000018553C92C-0x000000018553C984
		public bool CheckRadiusDrawing() => default; // 0x000000018553C8E0-0x000000018553C92C
		public float GetPointSize() => default; // 0x000000018553CA80-0x000000018553CAD4
		public float GetLineSize() => default; // 0x000000018553CA2C-0x000000018553CA80
		public float GetInertiaCenterRadius() => default; // 0x000000018553C9D8-0x000000018553CA2C
		public float GetCustomSkinningRadius() => default; // 0x000000018553C984-0x000000018553C9D8
		public bool IsReferOldPos() => default; // 0x000000018553CAD4-0x000000018553CB20
	}

	public class DataUtility // TypeDefIndex: 45164
	{
		// Constructors
		public DataUtility() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static int2 PackInt2(int d0, int d1) => default; // 0x000000018553DFC4-0x000000018553DFE0
		public static int2 PackInt2([IsReadOnly] in int2 d) => default; // 0x000000018553DFB8-0x000000018553DFC4
		[IDTag(0)]
		public static int3 PackInt3(int d0, int d1, int d2) => default; // 0x000000018553E064-0x000000018553E138
		[IDTag(1)]
		public static int3 PackInt3([IsReadOnly] in int3 d) => default; // 0x000000018553DFE0-0x000000018553E064
		[IDTag(0)]
		public static int4 PackInt4(int d0, int d1, int d2, int d3) => default; // 0x000000018553E1C8-0x000000018553E29C
		[IDTag(1)]
		public static int4 PackInt4(int4 d) => default; // 0x000000018553E138-0x000000018553E1C8
		public static uint Pack32(int hi, int low) => default; // 0x0000000183D4FDB0-0x0000000183D4FDC0
		public static uint Pack32Sort(int a, int b) => default; // 0x000000018553DFA0-0x000000018553DFB8
		public static int Unpack32Hi(uint pack) => default; // 0x0000000183D4FE90-0x0000000183D4FEA0
		public static int Unpack32Low(uint pack) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static uint Pack12_20(int hi, int low) => default; // 0x0000000183D4FDA0-0x0000000183D4FDB0
		public static int Unpack12_20Hi(uint pack) => default; // 0x0000000183D4FE50-0x0000000183D4FE60
		public static int Unpack12_20Low(uint pack) => default; // 0x0000000183D4FE60-0x0000000183D4FE70
		public static void Unpack12_20(uint pack, out int hi, out int low) {
			hi = default;
			low = default;
		} // 0x0000000183D4FE70-0x0000000183D4FE90
		public static ulong Pack64(int x, int y, int z, int w) => default; // 0x0000000183D4FE10-0x0000000183D4FE40
		public static ulong Pack64([IsReadOnly] in int4 a) => default; // 0x0000000183D4FDC0-0x0000000183D4FDF0
		public static int4 Unpack64([IsReadOnly] in ulong pack) => default; // 0x0000000183D4FF00-0x0000000183D4FF30
		public static int Unpack64X([IsReadOnly] in ulong pack) => default; // 0x0000000183D4FED0-0x0000000183D4FEE0
		public static int Unpack64Y([IsReadOnly] in ulong pack) => default; // 0x0000000183D4FEE0-0x0000000183D4FEF0
		public static int Unpack64Z([IsReadOnly] in ulong pack) => default; // 0x0000000183D4FEF0-0x0000000183D4FF00
		public static int Unpack64W([IsReadOnly] in ulong pack) => default; // 0x0000000183D4F990-0x0000000183D4F9A0
		public static uint Pack32(int x, int y, int z, int w) => default; // 0x0000000183D4FDF0-0x0000000183D4FE10
		public static ulong Pack32([IsReadOnly] in int4 a) => default; // 0x0000000183D4FDC0-0x0000000183D4FDF0
		public static int4 Unpack32([IsReadOnly] in uint pack) => default; // 0x0000000183D4FEB0-0x0000000183D4FED0
		public static int RemainingData([IsReadOnly] in int3 data, [IsReadOnly] in int2 use) => default; // 0x0000000185467A94-0x0000000185467ABC
		public static float4x4 ConvertAnimationCurve(AnimationCurve curve) => default; // 0x00000001826EC3B0-0x00000001826EC510
		public static float EvaluateCurve([IsReadOnly] in float4x4 curve, float time) => default; // 0x00000001854487C4-0x00000001854488D0
		public static ColliderManager.ColliderType GetColliderType([IsReadOnly] in ExBitFlag8 flag) => default; // 0x0000000183D4FD90-0x0000000183D4FDA0
		public static ExBitFlag8 SetColliderType(ExBitFlag8 flag, ColliderManager.ColliderType ctype) => default; // 0x0000000183D4FE40-0x0000000183D4FE50
		public static void ArrayCopy<T>(T[] src, ref ref T[] dst) {}
	}

	public class MultiDataBuilder<T> : IDisposable // TypeDefIndex: 45165
		where T : struct
	{
		// Fields
		private int indexCount;
		public NativeParallelMultiHashMap<int, T> Map;
	
		// Constructors
		public MultiDataBuilder() {} // Dummy constructor
		public MultiDataBuilder(int indexCount, int dataCapacity) {}
	
		// Methods
		public void Dispose() {}
		public int Count() => default;
		public int GetDataCount(int index) => default;
		public void Add(int key, T data) {}
		public int CountValuesForKey(int key) => default;
		public ValueTuple<T[], uint[]> ToArray() => default;
		public uint[] ToIndexArray() => default;
		public void ToNativeArray(out NativeArray<uint> indexArray, out NativeArray<T> dataArray) {
			indexArray = default;
			dataArray = default;
		}
	}

	public class GridMap<T> : IDisposable // TypeDefIndex: 45167
		where T : struct, IEquatable<T>
	{
		// Fields
		private NativeParallelMultiHashMap<int3, T> gridMap;
	
		// Properties
		public int DataCount { get => default; }
	
		// Nested types
		public struct GridEnumerator : IEnumerator<int3> // TypeDefIndex: 45166
		{
			// Fields
			internal NativeParallelMultiHashMap<int3, T> gridMap;
			internal int3 startGrid;
			internal int3 endGrid;
			internal int3 currentGrid;
			internal bool isFirst;
	
			// Properties
			public int3 Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			public void Reset() {}
			public GridEnumerator<T> GetEnumerator() => default;
		}
	
		// Constructors
		public GridMap() {} // Dummy constructor
		public GridMap(int capacity = 0 /* Metadata: 0x01FB935B */) {}
	
		// Methods
		public void Dispose() {}
		public NativeParallelMultiHashMap<int3, T> GetMultiHashMap() => default;
		public static GridEnumerator GetArea(int3 startGrid, int3 endGrid, NativeParallelMultiHashMap<int3, T> gridMap) => default;
		public static GridEnumerator GetArea(float3 pos, float radius, NativeParallelMultiHashMap<int3, T> gridMap, float gridSize) => default;
		public static int3 GetGrid(float3 pos, float gridSize) => default;
		public static void AddGrid(int3 grid, T data, NativeParallelMultiHashMap<int3, T> gridMap) {}
		public static int3 AddGrid(float3 pos, T data, NativeParallelMultiHashMap<int3, T> gridMap, float gridSize) => default;
		public static int3 AddGrid(float3 pos, T data, NativeParallelMultiHashMap<int3, T> gridMap, float gridSize) => default;
		public static bool RemoveGrid(int3 grid, T data, NativeParallelMultiHashMap<int3, T> gridMap) => default;
		public static bool MoveGrid(int3 fromGrid, int3 toGrid, T data, NativeParallelMultiHashMap<int3, T> gridMap) => default;
	}

	public static class ClothJobUtility // TypeDefIndex: 45184
	{
		// Nested types
		[BurstCompile]
		private struct FillJob<T> : IJobParallelFor, ICrossFrameParallelForJob // TypeDefIndex: 45168
			where T : struct
		{
			// Fields
			public T value;
			[WriteOnly]
			public NativeArray<T> array;
			[ReadOnly]
			public int _indexCount;
	
			// Methods
			public void Execute(int index) {}
			public void SetIndexCount(int indexCount) {}
			public void Execute() {}
		}
	
		[BurstCompile]
		private struct FillJob2<T> : IJobParallelFor, ICrossFrameParallelForJob // TypeDefIndex: 45169
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
			public void Execute(int index) {}
			public void SetIndexCount(int indexCount) {}
			public void Execute() {}
		}
	
		[BurstCompile]
		private struct FillRefJob<T> : IJob // TypeDefIndex: 45170
			where T : struct
		{
			// Fields
			public T value;
			[WriteOnly]
			public NativeReference<T> reference;
	
			// Methods
			public void Execute() {}
		}
	
		[BurstCompile]
		private struct SerialNumberJob : IJobParallelFor // TypeDefIndex: 45171
		{
			// Fields
			[WriteOnly]
			public NativeArray<int> array; // 0x00
	
			// Methods
			public void Execute(int index) {} // 0x0000000182E24B90-0x0000000182E24BD0
		}
	
		[BurstCompile]
		private struct ConvertHashSetToListJob<T> : IJob // TypeDefIndex: 45172
			where T : struct, IEquatable<T>
		{
			// Fields
			[ReadOnly]
			public NativeParallelHashSet<T> hashSet;
			[WriteOnly]
			public NativeList<T> list;
	
			// Methods
			public void Execute() {}
		}
	
		[BurstCompile]
		private struct ConvertHashSetKeyToListJob<T> : IJob // TypeDefIndex: 45173
			where T : struct, IEquatable<T>
		{
			// Fields
			[ReadOnly]
			public NativeParallelHashSet<T> hashSet;
			[WriteOnly]
			public NativeList<T> list;
	
			// Methods
			public void Execute() {}
		}
	
		[BurstCompile]
		private struct CalcAABBJob : IJob // TypeDefIndex: 45174
		{
			// Fields
			public int length; // 0x00
			[ReadOnly]
			public NativeArray<float3> positions; // 0x08
			public NativeReference<AABB> outAABB; // 0x18
	
			// Methods
			public void Execute() {} // 0x000000018337F1D0-0x000000018337F240
		}
	
		[BurstCompile]
		private struct CalcAABBDeferJob : IJob // TypeDefIndex: 45175
		{
			// Fields
			[ReadOnly]
			public NativeList<float3> positions; // 0x00
			public NativeReference<AABB> outAABB; // 0x10
	
			// Methods
			public void Execute() {} // 0x000000018553C530-0x000000018553C60C
		}
	
		[BurstCompile]
		private struct CalcUVJob : IJobParallelFor // TypeDefIndex: 45176
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> positions; // 0x00
			[ReadOnly]
			public NativeReference<AABB> aabb; // 0x10
			[WriteOnly]
			public NativeArray<float2> uvs; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x000000018553C60C-0x000000018553C81C
		}
	
		[BurstCompile]
		public struct AddIntDataCopyJob : IJobParallelFor // TypeDefIndex: 45177
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
			public void Execute(int index) {} // 0x0000000185539424-0x0000000185539494
		}
	
		[BurstCompile]
		public struct AddInt2DataCopyJob : IJobParallelFor // TypeDefIndex: 45178
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
			public void Execute(int index) {} // 0x00000001855392F4-0x000000018553936C
		}
	
		[BurstCompile]
		public struct AddInt3DataCopyJob : IJobParallelFor // TypeDefIndex: 45179
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
			public void Execute(int index) {} // 0x000000018553936C-0x0000000185539424
		}
	
		[BurstCompile]
		public struct TransformPositionJob : IJobParallelFor // TypeDefIndex: 45180
		{
			// Fields
			public float4x4 toM; // 0x00
			public NativeArray<float3> positions; // 0x40
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185547F14-0x0000000185547FB4
		}
	
		[BurstCompile]
		public struct TransformPositionJob2 : IJobParallelFor // TypeDefIndex: 45181
		{
			// Fields
			public float4x4 toM; // 0x00
			[ReadOnly]
			public NativeArray<float3> srcPositions; // 0x40
			[WriteOnly]
			public NativeArray<float3> dstPositions; // 0x50
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185547E74-0x0000000185547F14
		}
	
		[BurstCompile]
		private struct ConvertArrayToMapJob<TData> : IJob // TypeDefIndex: 45182
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
			public void Execute() {}
		}
	
		[BurstCompile]
		private struct ClearReferenceJob : IJob // TypeDefIndex: 45183
		{
			// Fields
			public NativeReference<int> reference; // 0x00
	
			// Methods
			public void Execute() {} // 0x000000018553C81C-0x000000018553C888
		}
	
		// Methods
		[IDTag(0)]
		public static JobHandle Fill(NativeArray<byte> array, int length, byte value, JobHandle dependsOn = default) => default; // 0x000000018553D784-0x000000018553D8BC
		[IDTag(1)]
		public static void FillRun(NativeArray<int> array, int length, int value) {} // 0x000000018553D488-0x000000018553D574
		[IDTag(2)]
		public static void FillRun(NativeArray<quaternion> array, int length, quaternion value) {} // 0x00000001835AE950-0x00000001835AEA00
		[IDTag(0)]
		public static void FillRun(NativeArray<VirtualMeshBoneWeight> array, int length, VirtualMeshBoneWeight value) {} // 0x000000018553D574-0x000000018553D660
		[IDTag(1)]
		public static JobHandle Fill(NativeArray<int> array, int startIndex, int length, int value, JobHandle dependsOn = default) => default; // 0x000000018553D8BC-0x000000018553D9F8
		[IDTag(2)]
		public static JobHandle Fill(NativeReference<int> reference, int value, JobHandle dependsOn = default) => default; // 0x000000018553D660-0x000000018553D784
		public static JobHandle SerialNumber(NativeArray<int> array, int length, JobHandle dependsOn = default) => default; // 0x000000018553D9F8-0x000000018553DAFC
		public static void SerialNumberRun(NativeArray<int> array, int length) {} // 0x00000001828C5450-0x00000001828C54C0
		public static JobHandle ConvertHashSetToNativeList(NativeParallelHashSet<int> hashSet, NativeList<int> list, JobHandle dependsOn = default) => default; // 0x000000018553D378-0x000000018553D488
		[IDTag(0)]
		public static JobHandle ConvertHashSetKeyToNativeList(NativeParallelHashSet<int2> hashSet, NativeList<int2> keyList, JobHandle dependsOn = default) => default; // 0x000000018553D158-0x000000018553D268
		[IDTag(1)]
		public static JobHandle ConvertHashSetKeyToNativeList(NativeParallelHashSet<int4> hashSet, NativeList<int4> keyList, JobHandle dependsOn = default) => default; // 0x000000018553D268-0x000000018553D378
		[IDTag(0)]
		public static JobHandle CalcAABB(NativeArray<float3> positions, int length, NativeReference<AABB> outAABB, JobHandle dependsOn = default) => default; // 0x000000018553CCE8-0x000000018553CE28
		[IDTag(0)]
		public static void CalcAABBRun(NativeArray<float3> positions, int length, NativeReference<AABB> outAABB) {} // 0x0000000183745750-0x0000000183745820
		[IDTag(1)]
		public static JobHandle CalcAABB(NativeList<float3> positions, NativeReference<AABB> outAABB, JobHandle dependsOn = default) => default; // 0x000000018553CBD8-0x000000018553CCE8
		[IDTag(1)]
		public static void CalcAABBRun(NativeList<float3> positions, NativeReference<AABB> outAABB) {} // 0x000000018553CB20-0x000000018553CBD8
		private static AABB CalcAABBInternal([IsReadOnly] in NativeArray<float3> positions, int length) => default; // 0x000000018337F7C0-0x000000018337F9A0
		public static JobHandle CalcUVWithSphereMapping(NativeArray<float3> positions, int length, NativeReference<AABB> aabb, NativeArray<float2> outUVs, JobHandle dependsOn = default) => default; // 0x000000018553CF28-0x000000018553D080
		public static void CalcUVWithSphereMappingRun(NativeArray<float3> positions, int length, NativeReference<AABB> aabb, NativeArray<float2> outUVs) {} // 0x000000018553CE28-0x000000018553CF28
		[IDTag(0)]
		public static JobHandle TransformPosition(NativeArray<float3> positions, int length, [IsReadOnly] in float4x4 toM, JobHandle dependsOn = default) => default; // 0x000000018553DCF0-0x000000018553DE34
		[IDTag(1)]
		public static void TransformPositionRun(NativeArray<float3> positions, int length, [IsReadOnly] in float4x4 toM) {} // 0x000000018553DC08-0x000000018553DCF0
		[IDTag(1)]
		public static JobHandle TransformPosition(NativeArray<float3> srcPositions, NativeArray<float3> dstPositions, int length, [IsReadOnly] in float4x4 toM, JobHandle dependsOn = default) => default; // 0x000000018553DE34-0x000000018553DFA0
		[IDTag(0)]
		public static void TransformPositionRun(NativeArray<float3> srcPositions, NativeArray<float3> dstPositions, int length, [IsReadOnly] in float4x4 toM) {} // 0x000000018553DAFC-0x000000018553DC08
		public static NativeParallelMultiHashMap<int, ushort> ToNativeMultiHashMap([IsReadOnly] in NativeArray<uint> indexArray, [IsReadOnly] in NativeArray<ushort> dataArray) => default; // 0x000000018356FAA0-0x000000018356FBD0
		public static JobHandle ClearReference(NativeReference<int> reference, JobHandle jobHandle) => default; // 0x000000018553D080-0x000000018553D158
	}

	public static class InterlockUtility // TypeDefIndex: 45211
	{
		// Fields
		private const int ToFixed = 1000000; // Metadata: 0x01FB935C
		private const float ToFloat = 1E-06f; // Metadata: 0x01FB9360
	
		// Nested types
		[BurstCompile]
		private static class AggregateJobKernels // TypeDefIndex: 45189
		{
			// Nested types
			public unsafe delegate void AggregateKernel_00000578_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 45185; 0x0000000181028930-0x0000000181028950
	
			internal static class AggregateKernel_00000578_BurstDirectCall // TypeDefIndex: 45186
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateKernel_00000578_BurstDirectCall() {} // 0x0000000183CECFF0-0x0000000183CED000
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060be4) {} // 0x000000018553A53C-0x000000018553A640
				private static IntPtr GetFunctionPointer() => default; // 0x000000018553A640-0x000000018553A694
				public static void Constructor() {} // 0x0000000183CED000-0x0000000183CED090
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x000000018553A694-0x000000018553A754
			}
	
			public unsafe delegate void AggregateRangeKernel_00000579_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 45187; 0x0000000181028930-0x0000000181028950
	
			internal static class AggregateRangeKernel_00000579_BurstDirectCall // TypeDefIndex: 45188
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateRangeKernel_00000579_BurstDirectCall() {} // 0x0000000183CECF50-0x0000000183CECF60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060bf9) {} // 0x000000018553A800-0x000000018553A904
				private static IntPtr GetFunctionPointer() => default; // 0x000000018553A904-0x000000018553A958
				public static void Constructor() {} // 0x0000000183CECF60-0x0000000183CECFF0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length) {} // 0x000000018553A958-0x000000018553AA34
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateKernel(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x000000018553A12C-0x000000018553A1A8
			[BurstCompile]
			internal static unsafe void AggregateRangeKernel(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length) {} // 0x000000018553A214-0x000000018553A290
			[BurstCompile]
			public static unsafe void AggregateKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x0000000185537458-0x0000000185537598
			[BurstCompile]
			public static unsafe void AggregateRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length) {} // 0x000000018553A1A8-0x000000018553A214
		}
	
		[BurstCompile]
		private static class AggregateWithVelocityJobKernels // TypeDefIndex: 45194
		{
			// Nested types
			public unsafe delegate void AggregateWithVelocityKernel_0000057A_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // TypeDefIndex: 45190; 0x000000018551C468-0x000000018551C47C
	
			internal static class AggregateWithVelocityKernel_0000057A_BurstDirectCall // TypeDefIndex: 45191
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityKernel_0000057A_BurstDirectCall() {} // 0x0000000183CECD70-0x0000000183CECD80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060c2e) {} // 0x000000018553BED8-0x000000018553BFDC
				private static IntPtr GetFunctionPointer() => default; // 0x000000018553BFDC-0x000000018553C030
				public static void Constructor() {} // 0x0000000183CECD80-0x0000000183CECE10
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x000000018553C030-0x000000018553C128
			}
	
			public unsafe delegate void AggregateWithVelocityRangeKernel_0000057B_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // TypeDefIndex: 45192; 0x000000018551C468-0x000000018551C47C
	
			internal static class AggregateWithVelocityRangeKernel_0000057B_BurstDirectCall // TypeDefIndex: 45193
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityRangeKernel_0000057B_BurstDirectCall() {} // 0x0000000183CECCD0-0x0000000183CECCE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060c49) {} // 0x000000018553C204-0x000000018553C308
				private static IntPtr GetFunctionPointer() => default; // 0x000000018553C308-0x000000018553C35C
				public static void Constructor() {} // 0x0000000183CECCE0-0x0000000183CECD70
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length) {} // 0x000000018553C35C-0x000000018553C454
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateWithVelocityKernel(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x000000018553BA34-0x000000018553BAD0
			[BurstCompile]
			internal static unsafe void AggregateWithVelocityRangeKernel(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length) {} // 0x000000018553BAD0-0x000000018553BB6C
			[BurstCompile]
			public static unsafe void AggregateWithVelocityKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x0000000185537598-0x000000018553778C
			[BurstCompile]
			public static unsafe void AggregateWithVelocityRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length) {} // 0x0000000185537828-0x00000001855378BC
		}
	
		[BurstCompile]
		private static class AggregateJob2Kernels // TypeDefIndex: 45199
		{
			// Nested types
			public unsafe delegate void AggregateJob2Kernel_0000057C_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 45195; 0x0000000181028930-0x0000000181028950
	
			internal static class AggregateJob2Kernel_0000057C_BurstDirectCall // TypeDefIndex: 45196
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateJob2Kernel_0000057C_BurstDirectCall() {} // 0x0000000183CED130-0x0000000183CED140
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060c74) {} // 0x0000000185539684-0x0000000185539788
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185539788-0x00000001855397DC
				public static void Constructor() {} // 0x0000000183CED140-0x0000000183CED1D0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x00000001855397DC-0x000000018553989C
			}
	
			public unsafe delegate void AggregateJob2RangeKernel_0000057D_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // TypeDefIndex: 45197; 0x0000000181028930-0x0000000181028950
	
			internal static class AggregateJob2RangeKernel_0000057D_BurstDirectCall // TypeDefIndex: 45198
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateJob2RangeKernel_0000057D_BurstDirectCall() {} // 0x0000000183CED090-0x0000000183CED0A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060c89) {} // 0x0000000185539AB0-0x0000000185539BB4
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185539BB4-0x0000000185539C08
				public static void Constructor() {} // 0x0000000183CED0A0-0x0000000183CED130
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr) {} // 0x0000000185539C08-0x0000000185539CE4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateJob2Kernel(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x0000000185539948-0x00000001855399C4
			[BurstCompile]
			internal static unsafe void AggregateJob2RangeKernel(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr) {} // 0x0000000185539A30-0x0000000185539AB0
			[BurstCompile]
			public static unsafe void AggregateJob2Kernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x0000000185537458-0x0000000185537598
			[BurstCompile]
			public static unsafe void AggregateJob2RangeKernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr) {} // 0x00000001855399C4-0x0000000185539A30
		}
	
		[BurstCompile]
		private static class AggregateWithVelocityJob2Kernels // TypeDefIndex: 45204
		{
			// Nested types
			public unsafe delegate void AggregateWithVelocityJob2Kernel_0000057E_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // TypeDefIndex: 45200; 0x000000018551C468-0x000000018551C47C
	
			internal static class AggregateWithVelocityJob2Kernel_0000057E_BurstDirectCall // TypeDefIndex: 45201
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityJob2Kernel_0000057E_BurstDirectCall() {} // 0x0000000183CECEB0-0x0000000183CECEC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060cbe) {} // 0x000000018553AD40-0x000000018553AE44
				private static IntPtr GetFunctionPointer() => default; // 0x000000018553AE44-0x000000018553AE98
				public static void Constructor() {} // 0x0000000183CECEC0-0x0000000183CECF50
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x000000018553AE98-0x000000018553AF90
			}
	
			public unsafe delegate void AggregateWithVelocityJob2RangeKernel_0000057F_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // TypeDefIndex: 45202; 0x000000018551C468-0x000000018551C47C
	
			internal static class AggregateWithVelocityJob2RangeKernel_0000057F_BurstDirectCall // TypeDefIndex: 45203
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityJob2RangeKernel_0000057F_BurstDirectCall() {} // 0x0000000183CECE10-0x0000000183CECE20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060cd9) {} // 0x000000018553B278-0x000000018553B37C
				private static IntPtr GetFunctionPointer() => default; // 0x000000018553B37C-0x000000018553B3D0
				public static void Constructor() {} // 0x0000000183CECE20-0x0000000183CECEB0
				public static void Initialize() {} // 0x000000018350B670-0x000000018350B680
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr) {} // 0x000000018553B3D0-0x000000018553B4CC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateWithVelocityJob2Kernel(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x000000018553B140-0x000000018553B1DC
			[BurstCompile]
			internal static unsafe void AggregateWithVelocityJob2RangeKernel(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr) {} // 0x000000018553B1DC-0x000000018553B278
			[BurstCompile]
			public static unsafe void AggregateWithVelocityJob2Kernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x0000000185537598-0x000000018553778C
			[BurstCompile]
			public static unsafe void AggregateWithVelocityJob2RangeKernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr) {} // 0x000000018553778C-0x0000000185537828
		}
	
		[BurstCompile]
		private struct AggregateJob : IJobParallelForDefer, IUnsafeJob // TypeDefIndex: 45205
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
			public void Execute(int index) {} // 0x000000018553A290-0x000000018553A440
			public void UnsafeDo() {} // 0x000000018553A440-0x000000018553A53C
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityJob : IJobParallelForDefer, IUnsafeJob // TypeDefIndex: 45206
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
			public void Execute(int index) {} // 0x000000018553BB6C-0x000000018553BDAC
			public void UnsafeDo() {} // 0x000000018553BDAC-0x000000018553BED8
		}
	
		[BurstCompile]
		private struct AggregateJob2 : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45207
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x000000018553A020-0x000000018553A088
			[IDTag(1)]
			public void Execute() {} // 0x0000000185539F8C-0x000000018553A020
			[IDTag(0)]
			public void Execute(int index) {} // 0x0000000185539E08-0x0000000185539F8C
			public void UnsafeDo() {} // 0x000000018553A088-0x000000018553A12C
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityJob2 : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45208
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
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x000000018553B90C-0x000000018553B974
			[IDTag(1)]
			public void Execute() {} // 0x000000018553B878-0x000000018553B90C
			[IDTag(0)]
			public void Execute(int index) {} // 0x000000018553B664-0x000000018553B878
			public void UnsafeDo() {} // 0x000000018553B974-0x000000018553BA34
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityCrossFrameJob2 : IJob // TypeDefIndex: 45209
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
			public void Execute(int index) {} // 0x000000018553AB74-0x000000018553AD40
			[IDTag(1)]
			public void Execute() {} // 0x000000018553AAE0-0x000000018553AB74
		}
	
		[BurstCompile]
		private struct AggregateCrossFrameJob2 : IJob // TypeDefIndex: 45210
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
			public void Execute(int index) {} // 0x0000000185539528-0x0000000185539684
			[IDTag(1)]
			public void Execute() {} // 0x0000000185539494-0x0000000185539528
		}
	
		// Methods
		internal static unsafe void AddFloat3(int index, float3 add, int* cntPt, int* sumPt) {} // 0x000000018553EE40-0x000000018553EED8
		internal static unsafe void AddFloat3(int index, float3 add, int* sumPt) {} // 0x000000018553EED8-0x000000018553EF6C
		internal static unsafe void Increment(int index, int* cntPt) {} // 0x0000000183D4FF50-0x0000000183D4FF60
		internal static unsafe void Max(int index, float value, int* pt) {} // 0x0000000185454BA4-0x0000000185454BDC
		internal static float3 ReadAverageFloat3(int index, [IsReadOnly] in NativeArray<int> countArray, [IsReadOnly] in NativeArray<int> sumArray) => default; // 0x0000000185454BDC-0x0000000185454CF4
		internal static unsafe float3 ReadAverageFloat3(int index, int* countArray, int* sumArray) => default; // 0x0000000185454CF4-0x0000000185454D98
		internal static float3 ReadFloat3(int index, [IsReadOnly] in NativeArray<int> bufferArray) => default; // 0x0000000185454E08-0x0000000185454ED4
		internal static unsafe float3 ReadFloat3(int index, int* bufferArray) => default; // 0x0000000185454D98-0x0000000185454E08
		internal static float ReadFloat(int index, [IsReadOnly] in NativeArray<int> bufferArray) => default; // 0x0000000185454ED4-0x0000000185454F3C
		internal static unsafe float ReadFloat(int index, int* bufferArray) => default; // 0x0000000183D4FF60-0x0000000183D4FF80
		[IDTag(2)]
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in NativeList<int> particleList, float velocityAttenuation, JobHandle jobHandle) => default; // 0x000000018553F038-0x000000018553F284
		[IDTag(1)]
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in ExProcessingList<int> processingList, float velocityAttenuation, JobHandle jobHandle) => default; // 0x000000018553EF6C-0x000000018553F038
		[IDTag(0)]
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in NativeArray<int> particleArray, [IsReadOnly] in NativeReference<int> counter, float velocityAttenuation, JobHandle jobHandle) => default; // 0x000000018553F284-0x000000018553F514
		public static void Initialize_AggregateJobKernels_AggregateKernel_00000578_BurstDirectCall() {} // 0x00000001835EC180-0x00000001835EC1E0
		public static void Initialize_AggregateJobKernels_AggregateRangeKernel_00000579_BurstDirectCall() {} // 0x00000001835EC1E0-0x00000001835EC240
		public static void Initialize_AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_0000057A_BurstDirectCall() {} // 0x00000001835EC240-0x00000001835EC2A0
		public static void Initialize_AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_0000057B_BurstDirectCall() {} // 0x00000001835EC2A0-0x00000001835EC300
		public static void Initialize_AggregateJob2Kernels_AggregateJob2Kernel_0000057C_BurstDirectCall() {} // 0x00000001835EC300-0x00000001835EC360
		public static void Initialize_AggregateJob2Kernels_AggregateJob2RangeKernel_0000057D_BurstDirectCall() {} // 0x00000001835EC360-0x00000001835EC3C0
		public static void Initialize_AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_0000057E_BurstDirectCall() {} // 0x00000001835EC3C0-0x00000001835EC420
		public static void Initialize_AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_0000057F_BurstDirectCall() {} // 0x00000001835EC420-0x00000001835EC480
	}

	[Serializable]
	public struct AABB : IEquatable<AABB> // TypeDefIndex: 45212
	{
		// Fields
		public double3 Min; // 0x00
		public double3 Max; // 0x18
	
		// Properties
		public double3 Extents { get => default; } // 0x0000000185538FA0-0x0000000185539000 
		public double3 HalfExtents { get => default; } // 0x0000000185539000-0x00000001855390D8 
		public double3 Center { get => default; } // 0x0000000185538EC8-0x0000000185538FA0 
		public float MaxSideLength { get => default; } // 0x0000000185539134-0x00000001855391D4 
		public bool IsValid { get => default; } // 0x00000001855390D8-0x0000000185539134 
		public float SurfaceArea { get => default; } // 0x00000001855391D4-0x00000001855392F4 
	
		// Constructors
		public AABB([IsReadOnly] in double3 min, [IsReadOnly] in double3 max) : this() {
			Min = default;
			Max = default;
		} // 0x0000000183D4FD50-0x0000000183D4FD80
	
		// Methods
		public static AABB CreateFromCenterAndExtents(double3 center, double3 extents) => default; // 0x00000001855389F0-0x0000000185538A88
		public static AABB CreateFromCenterAndHalfExtents(double3 center, double3 halfExtents) => default; // 0x0000000185538A88-0x0000000185538B4C
		public bool Contains([IsReadOnly] in double3 point) => default; // 0x0000000185538928-0x00000001855389F0
		public bool Contains([IsReadOnly] in AABB aabb) => default; // 0x0000000185538860-0x0000000185538928
		public bool Overlaps([IsReadOnly] in AABB aabb) => default; // 0x0000000185538BBC-0x0000000185538C84
		public void Expand(double signedDistance) {} // 0x00000001854514CC-0x0000000185452C9C
		public void Encapsulate([IsReadOnly] in AABB aabb) {} // 0x0000000185451420-0x00000001854514CC
		public void Encapsulate([IsReadOnly] in double3 point) {} // 0x00000001854B5D3C-0x00000001854B5DE8
		public bool Equals(AABB other) => default; // 0x0000000185538B4C-0x0000000185538BBC
		public void Transform([IsReadOnly] in double4x4 toM) {} // 0x000000018553729C-0x0000000185537458
		public override string ToString() => default; // 0x0000000185538C84-0x0000000185538E68
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185538E68-0x0000000185538EC8
	}

	[Serializable]
	public struct IntAABB : IEquatable<IntAABB> // TypeDefIndex: 45213
	{
		// Fields
		public int3 Min; // 0x00
		public int3 Max; // 0x0C
	
		// Properties
		public int3 Extents { get => default; } // 0x000000018553ED88-0x000000018553EDE0 
		public int3 Center { get => default; } // 0x000000018553ECFC-0x000000018553ED88 
		public bool IsValid { get => default; } // 0x000000018553EDE0-0x000000018553EE40 
	
		// Constructors
		public IntAABB(int3 min, int3 max) : this() {
			Min = default;
			Max = default;
		} // 0x0000000183D4FF30-0x0000000183D4FF50
	
		// Methods
		public bool Contains(int3 point) => default; // 0x000000018553E94C-0x000000018553EA68
		public bool Contains(IntAABB aabb) => default; // 0x000000018553E830-0x000000018553E94C
		public bool Overlaps(IntAABB aabb) => default; // 0x000000018553EB40-0x000000018553EC60
		public void Expand(int signedDistance) {} // 0x000000018553EACC-0x000000018553EB40
		public void Encapsulate(IntAABB aabb) {} // 0x000000018553840C-0x00000001855384F4
		public void Encapsulate(int3 point) {} // 0x00000001855384F4-0x0000000185538798
		public bool Equals(IntAABB other) => default; // 0x000000018553EA68-0x000000018553EACC
		public override string ToString() => default; // 0x000000018553EC60-0x000000018553ECFC
	}

	public static class MathExtensions // TypeDefIndex: 45214
	{
		// Extension methods
		public static float MC2GetValue([IsReadOnly] this in float4x4 m, int index) => default; // 0x0000000185540314-0x000000018554036C
		public static void MC2SetValue(this ref float4x4 m, int index, float value) {} // 0x000000018554036C-0x0000000185540394
		public static float MC2EvaluateCurveClamp01([IsReadOnly] this in float4x4 m, float time) => default; // 0x00000001855402EC-0x000000018554030C
		public static float MC2EvaluateCurve([IsReadOnly] this in float4x4 m, float time) => default; // 0x000000018554030C-0x0000000185540314
	}

	public static class MathUtility // TypeDefIndex: 45215
	{
		// Methods
		public static void ComputeVirtualParentWithoutLocal(float3 fromPos, quaternion fromRot, float3 toPos, quaternion toRot, out float3 dPos, out quaternion dRot) {
			dPos = default;
			dRot = default;
		} // 0x0000000185540EF4-0x0000000185541090
		public static float Clamp1(float a) => default; // 0x0000000185540454-0x000000018554046C
		public static double Clamp1(double a) => default; // 0x000000018554043C-0x0000000185540454
		public static double3 Project([IsReadOnly] in double3 v, [IsReadOnly] in double3 n) => default; // 0x0000000185455C50-0x0000000185455CD8
		public static double3 ProjectOnPlane([IsReadOnly] in double3 v, [IsReadOnly] in double3 n) => default; // 0x000000018551360C-0x00000001855139C0
		public static float3 mul(quaternion q, float3 v) => default; // 0x000000018554451C-0x000000018554456C
		public static double3 mul(quaternion q, double3 v) => default; // 0x0000000185544358-0x000000018554451C
		public static float Angle([IsReadOnly] in float3 v1, [IsReadOnly] in float3 v2) => default; // 0x0000000185467B08-0x0000000185467BD8
		public static double Angle([IsReadOnly] in double3 v1, [IsReadOnly] in double3 v2) => default; // 0x00000001854488D0-0x0000000185448A30
		public static float3 ClampVector(float3 v, float minlength, float maxlength) => default; // 0x0000000185540948-0x0000000185540A1C
		public static float3 ClampVector(float3 v, float maxlength) => default; // 0x00000001854D9110-0x00000001854D91BC
		public static double3 ClampVector(double3 v, double maxlength) => default; // 0x0000000185540A1C-0x0000000185540AD0
		public static double3 ClampDistance(double3 from, double3 to, double maxlength) => default; // 0x000000018554086C-0x0000000185540948
		public static bool ClampAngle([IsReadOnly] in double3 dir, [IsReadOnly] in double3 basedir, double maxAngle, out double3 outdir) {
			outdir = default;
			return default;
		} // 0x000000018554046C-0x00000001855407E8
		public static quaternion FromToRotation([IsReadOnly] in double3 from, [IsReadOnly] in double3 to, double t = 1 /* Metadata: 0x01FB9364 */) => default; // 0x0000000185541278-0x0000000185541580
		public static quaternion FromToRotation([IsReadOnly] in quaternion from, [IsReadOnly] in quaternion to) => default; // 0x00000001854D91BC-0x00000001854D9520
		public static float Angle([IsReadOnly] in quaternion a, [IsReadOnly] in quaternion b) => default; // 0x00000001854D908C-0x00000001854D9110
		public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle) => default; // 0x00000001855407E8-0x000000018554086C
		public static quaternion ToRotation([IsReadOnly] in float3 nor, [IsReadOnly] in float3 tan) => default; // 0x00000001855431B4-0x0000000185543208
		public static void ToNormalTangent([IsReadOnly] in quaternion rot, out float3 nor, out float3 tan) {
			nor = default;
			tan = default;
		} // 0x00000001854D9920-0x00000001854D9C78
		public static float3 ToNormal([IsReadOnly] in quaternion rot) => default; // 0x000000018554315C-0x00000001855431B4
		public static float3 ToTangent([IsReadOnly] in quaternion rot) => default; // 0x0000000185543208-0x0000000185543260
		public static float3 ToBinormal([IsReadOnly] in quaternion rot) => default; // 0x0000000185543108-0x000000018554315C
		public static float3 Binormal([IsReadOnly] in float3 nor, [IsReadOnly] in float3 tan) => default; // 0x0000000185540394-0x00000001855403EC
		public static float3 AxisToEuler([IsReadOnly] in float3 axis) => default; // 0x0000000185513538-0x000000018551360C
		public static quaternion AxisQuaternion(float3 dir) => default; // 0x00000001855134F0-0x0000000185513538
		public static void ToAngleAxis([IsReadOnly] in quaternion q, out float angle, out float3 axis) {
			angle = default;
			axis = default;
		} // 0x00000001854D9854-0x00000001854D9920
		public static float ClosestPtPointSegmentRatio([IsReadOnly] in double3 c, [IsReadOnly] in double3 a, [IsReadOnly] in double3 b) => default; // 0x000000018545510C-0x0000000185455224
		public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b) => default; // 0x0000000185540C1C-0x0000000185540CF4
		public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b) => default; // 0x0000000185540CF4-0x0000000185540E54
		public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b) => default; // 0x0000000185540AD0-0x0000000185540C1C
		public static double ClosestPtSegmentSegment([IsReadOnly] in double3 p1, [IsReadOnly] in double3 q1, [IsReadOnly] in double3 p2, [IsReadOnly] in double3 q2, out double s, out double t, out double3 c1, out double3 c2) {
			s = default;
			t = default;
			c1 = default;
			c2 = default;
			return default;
		} // 0x000000018545555C-0x0000000185455A60
		public static void ClosestPtSegmentSegment2([IsReadOnly] in double3 p1, [IsReadOnly] in double3 q1, [IsReadOnly] in double3 p2, [IsReadOnly] in double3 q2, out double s, out double t) {
			s = default;
			t = default;
		} // 0x0000000185455224-0x000000018545555C
		public static double3 ClosestPtPointTriangle([IsReadOnly] in double3 p, [IsReadOnly] in double3 a, [IsReadOnly] in double3 b, [IsReadOnly] in double3 c, out double3 uvw) {
			uvw = default;
			return default;
		} // 0x00000001854B78C0-0x00000001854B88C0
		public static bool PointInTriangleUVW(float3 uvw) => default; // 0x0000000185542ABC-0x0000000185542AE0
		public static float3 TriangleCenter([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2) => default; // 0x0000000185543D84-0x0000000185543E38
		public static float3 TriangleNormal([IsReadOnly] in double3 p0, [IsReadOnly] in double3 p1, [IsReadOnly] in double3 p2) => default; // 0x0000000185455CD8-0x0000000185456A9C
		public static float TriangleArea([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2) => default; // 0x0000000185538798-0x0000000185538860
		public static bool IsSafeTriangle([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2) => default; // 0x00000001855429A8-0x00000001855429C0
		[IDTag(1)]
		public static float3 TriangleTangent([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2, [IsReadOnly] in float2 uv0, [IsReadOnly] in float2 uv1, [IsReadOnly] in float2 uv2) => default; // 0x00000001855440F0-0x0000000185544358
		[IDTag(0)]
		public static double3 TriangleTangent([IsReadOnly] in double3 p0, [IsReadOnly] in double3 p1, [IsReadOnly] in double3 p2, [IsReadOnly] in float2 uv0, [IsReadOnly] in float2 uv1, [IsReadOnly] in float2 uv2) => default; // 0x0000000185543E38-0x00000001855440F0
		public static float TriangleAngle([IsReadOnly] in float3 v0, [IsReadOnly] in float3 v1, [IsReadOnly] in float3 v2, [IsReadOnly] in float3 v3) => default; // 0x00000001854AC250-0x00000001854AC398
		public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2) => default; // 0x00000001855411AC-0x0000000185541278
		public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c) => default; // 0x0000000185541090-0x00000001855411AC
		public static int2 GetRestTriangleVertex(int3 tri1, int3 tri2, int2 edge) => default; // 0x00000001855416A4-0x00000001855417A8
		public static int2 GetCommonEdgeFromTrianglePair(int3 tri1, int3 tri2) => default; // 0x0000000185541580-0x00000001855416A4
		public static int4 GetTrianglePairIndices(int3 tri1, int3 tri2) => default; // 0x00000001855418FC-0x0000000185541A20
		public static int GetUnuseTriangleIndex(int3 tri, int2 edge) => default; // 0x0000000185541A20-0x0000000185541AC0
		public static float GetTrianglePairAngle(float3 pos0, float3 pos1, float3 pos2, float3 pos3) => default; // 0x00000001855417A8-0x00000001855418FC
		public static int3 FlipTriangle([IsReadOnly] in int3 tri) => default; // 0x0000000183D4FFE0-0x0000000183D50020
		public static void GetTriangleSphere(float3 pos0, float3 pos1, float3 pos2, out float3 sc, out float sr) {
			sc = default;
			sr = default;
		} // 0x00000001854ABBF8-0x00000001854ABD84
		public static float4x4 LocalToWorldMatrix([IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl) => default; // 0x00000001854D9520-0x00000001854D9854
		public static double4x4 LocalToWorldMatrix([IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl) => default; // 0x00000001854F1178-0x00000001854F1218
		public static float4x4 WorldToLocalMatrix([IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl) => default; // 0x00000001854D9C78-0x00000001854D9DB8
		public static double4x4 WorldToLocalMatrix([IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl) => default; // 0x00000001854D9DB8-0x00000001854D9EB8
		public static float3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl) => default; // 0x0000000185543510-0x0000000185543660
		public static double3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl) => default; // 0x0000000185543414-0x0000000185543510
		public static float3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float4x4 m) => default; // 0x00000001854ABFD8-0x00000001854AC04C
		public static float3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in float4x4 m) => default; // 0x0000000185543390-0x0000000185543414
		public static double3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in double4x4 m) => default; // 0x000000018554370C-0x00000001855437BC
		public static double3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double4x4 m) => default; // 0x0000000185543660-0x000000018554370C
		public static float3 TransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in float4x4 m) => default; // 0x00000001854AC1A0-0x00000001854AC250
		public static double3 TransformVector([IsReadOnly] in double3 vec, [IsReadOnly] in float4x4 m) => default; // 0x0000000185543AB4-0x0000000185543BC8
		public static double3 TransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in double4x4 m) => default; // 0x0000000185543C98-0x0000000185543D84
		public static double3 TransformVector([IsReadOnly] in double3 vec, [IsReadOnly] in double4x4 m) => default; // 0x0000000185543BC8-0x0000000185543C98
		public static float3 TransformDirection([IsReadOnly] in float3 dir, [IsReadOnly] in float4x4 m) => default; // 0x00000001854ABF00-0x00000001854ABFD8
		public static quaternion TransformRotation([IsReadOnly] in quaternion rot, [IsReadOnly] in double4x4 m, [IsReadOnly] in float3 normalTangentFlip) => default; // 0x00000001855437BC-0x0000000185543AB4
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) => default; // 0x000000018554308C-0x0000000185543108
		public static double4x4 TRS(double3 translation, quaternion rotation, float3 scale) => default; // 0x0000000185542E68-0x000000018554308C
		public static float TransformDistance([IsReadOnly] in float dist, [IsReadOnly] in float4x4 localToWorldMatrix) => default; // 0x0000000185543260-0x00000001855432E4
		public static void TransformPositionNormalTangent([IsReadOnly] in float3 tpos, [IsReadOnly] in quaternion trot, [IsReadOnly] in float3 tscl, ref float3 pos, ref float3 nor, ref float3 tan) {} // 0x00000001854AC04C-0x00000001854AC1A0
		public static float TransformLength(float length, [IsReadOnly] in float4x4 matrix) => default; // 0x00000001855432E4-0x0000000185543390
		public static float3 InverseTransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float4x4 worldToLocalMatrix) => default; // 0x00000001854ABFD8-0x00000001854AC04C
		public static double3 InverseTransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double4x4 worldToLocalMatrix) => default; // 0x00000001855424A0-0x0000000185542544
		public static float3 InverseTransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl) => default; // 0x0000000185542544-0x00000001855426C4
		public static double3 InverseTransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl) => default; // 0x00000001855426C4-0x0000000185542810
		public static float3 InverseTransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in float4x4 worldToLocalMatrix) => default; // 0x00000001854AC1A0-0x00000001854AC250
		public static float3 InverseTransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in quaternion rot) => default; // 0x0000000185542810-0x0000000185542878
		public static float3 InverseTransformDirection([IsReadOnly] in float3 dir, [IsReadOnly] in float4x4 worldToLocalMatrix) => default; // 0x00000001855423C8-0x00000001855424A0
		public static float4x4 Transform([IsReadOnly] in float4x4 fromLocalToWorldMatrix, [IsReadOnly] in float4x4 toWorldToLocalMatrix) => default; // 0x0000000185448A30-0x0000000185448D00
		public static bool CompareMatrix([IsReadOnly] in float4x4 m1, [IsReadOnly] in float4x4 m2) => default; // 0x0000000185467BD8-0x0000000185467E78
		public static bool CompareTransform([IsReadOnly] in float3 pos1, [IsReadOnly] in quaternion rot1, [IsReadOnly] in float3 scl1, [IsReadOnly] in float3 pos2, [IsReadOnly] in quaternion rot2, [IsReadOnly] in float3 scl2) => default; // 0x0000000185540E54-0x0000000185540EF4
		public static bool CompareTransform([IsReadOnly] in double3 pos1, [IsReadOnly] in quaternion rot1, [IsReadOnly] in float3 scl1, [IsReadOnly] in double3 pos2, [IsReadOnly] in quaternion rot2, [IsReadOnly] in float3 scl2) => default; // 0x00000001854F10D4-0x00000001854F1178
		[IDTag(0)]
		public static bool IntersectSegmentTriangle([IsReadOnly] in float3 p, [IsReadOnly] in float3 q, float3 a, float3 b, float3 c, bool doubleSide, out float u, out float v, out float w, out float t) {
			u = default;
			v = default;
			w = default;
			t = default;
			return default;
		} // 0x0000000185541AC0-0x0000000185541FE0
		[IDTag(1)]
		public static bool IntersectSegmentTriangle([IsReadOnly] in float3 p, [IsReadOnly] in float3 q, float3 a, float3 b, float3 c) => default; // 0x0000000185541FE0-0x00000001855423C8
		public static double IntersectPointPlaneDist([IsReadOnly] in double3 planePos, [IsReadOnly] in double3 planeDir, [IsReadOnly] in double3 pos, out double3 outPos) {
			outPos = default;
			return default;
		} // 0x0000000185455A60-0x0000000185455C50
		public static bool IntersectRaySphere([IsReadOnly] in float3 p, [IsReadOnly] in float3 d, [IsReadOnly] in float3 sc, [IsReadOnly] in float sr, ref float t, ref float3 q) => default; // 0x00000001854ABD84-0x00000001854ABF00
		public static float SqDistPointSegment(Vector3 a, Vector3 b, Vector3 c) => default; // 0x0000000185542C58-0x0000000185542E68
		public static bool IsNaN(float3 v) => default; // 0x00000001855428E4-0x000000018554292C
		public static bool IsNaN(double3 v) => default; // 0x0000000185542878-0x00000001855428C0
		public static bool IsNaN(float4 v) => default; // 0x00000001855428C0-0x00000001855428E4
		public static bool IsNaN(quaternion q) => default; // 0x000000018554292C-0x00000001855429A8
		public static float3 Lerp(float3 x, float3 y, float s) => default; // 0x00000001855429C0-0x0000000185542A38
		public static double3 Lerp(double3 x, double3 y, double s) => default; // 0x0000000185542A38-0x0000000185542ABC
		public static double3 ShiftPosition([IsReadOnly] in double3 oldPos, [IsReadOnly] in double3 oldPivotPosition, [IsReadOnly] in double3 shiftVector, [IsReadOnly] in quaternion shiftRotation) => default; // 0x0000000185542AE0-0x0000000185542C58
		public static float CalcMass(float depth) => default; // 0x0000000183D4FFB0-0x0000000183D4FFE0
		public static float CalcInverseMass(float friction) => default; // 0x00000001855403EC-0x0000000185540408
		public static float CalcInverseMass(float friction, float depth) => default; // 0x0000000185540408-0x000000018554043C
		public static float CalcInverseMass(float friction, float depth, bool fix, float fixMass) => default; // 0x0000000185454F3C-0x000000018545510C
		public static float CalcSelfCollisionInverseMass(float friction, bool fix, float clothMass) => default; // 0x00000001854B7888-0x00000001854B78C0
	
		// Extension methods
		public static double3 AutoConvertToFloat([IsReadOnly] this in Vector3 v) => default; // 0x0000000182BA1B00-0x0000000182BA1B30
		public static float3 AutoToFloat3([IsReadOnly] this in double3 v) => default; // 0x0000000183D4FF80-0x0000000183D4FFB0
	}

	public class MinimumData<T1, T2> // TypeDefIndex: 45216
		where T1 : struct
		where T2 : struct
	{
		// Fields
		private T1 minDist;
		private T2 minData;
		private bool isValid;
	
		// Properties
		public bool IsValid { get => default; }
		public T1 MinDistance { get => default; }
		public T2 MinData { get => default; }
	
		// Constructors
		public MinimumData() {}
	
		// Methods
		public void Add(T1 distance, T2 data) {}
		public void Clear() {}
		public override string ToString() => default;
	}

	public struct FTransform // TypeDefIndex: 45217
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 scale; // 0x1C
	
		// Methods
		public static FTransform Default() => default; // 0x00000001854694E4-0x00000001854695B4
	}

	public static class MeshUtility // TypeDefIndex: 45218
	{
		// Methods
		public static Mesh GetSharedMesh(Renderer ren) => default; // 0x00000001854697C4-0x0000000185469928
		public static bool SetMesh(Renderer ren, Mesh mesh, Transform[] skinBones = null) => default; // 0x0000000185469A0C-0x0000000185469B88
		public static int GetTransformCount(Renderer ren) => default; // 0x0000000185469928-0x0000000185469A0C
	}

	public static class Develop // TypeDefIndex: 45219
	{
		// Methods
		public static void Log([IsReadOnly] in object mes) {} // 0x00000001854682D4-0x0000000185468370
		public static void LogWarning([IsReadOnly] in object mes) {} // 0x0000000185468238-0x00000001854682D4
		public static void LogError([IsReadOnly] in object mes) {} // 0x00000001854681A0-0x0000000185468238
		[Conditional("MC2_LOG")]
		public static void DebugLog([IsReadOnly] in object mes) {} // 0x0000000185468104-0x00000001854681A0
		[Conditional("MC2_DEBUG")]
		public static void DebugLogWarning([IsReadOnly] in object mes) {} // 0x0000000185468068-0x0000000185468104
		[Conditional("MC2_DEBUG")]
		public static void DebugLogError([IsReadOnly] in object mes) {} // 0x0000000185467FCC-0x0000000185468068
		[Conditional("MC2_DEBUG")]
		public static void Assert(bool condition) {} // 0x0000000185467F88-0x0000000185467FCC
	}

	public class StaticStringBuilder // TypeDefIndex: 45220
	{
		// Fields
		private static StringBuilder stringBuilder; // 0x00
	
		// Properties
		public static StringBuilder Instance { get => default; } // 0x000000018546A840-0x000000018546A890 
	
		// Constructors
		public StaticStringBuilder() {} // 0x000000018350B670-0x000000018350B680
		static StaticStringBuilder() {} // 0x000000018546A7BC-0x000000018546A840
	
		// Methods
		public static void Clear() {} // 0x000000018546A6AC-0x000000018546A734
		public static StringBuilder Append(params object[] args) => default; // 0x000000018546A5DC-0x000000018546A6AC
		[IDTag(0)]
		public static StringBuilder AppendLine(params object[] args) => default; // 0x000000018546A3C4-0x000000018546A4CC
		[IDTag(1)]
		public static StringBuilder AppendLine() => default; // 0x000000018546A31C-0x000000018546A3C4
		public static string AppendToString(params object[] args) => default; // 0x000000018546A4CC-0x000000018546A5DC
		public static new string ToString() => default; // 0x000000018546A734-0x000000018546A7BC
	}

	public struct DataChunk // TypeDefIndex: 45221
	{
		// Fields
		public int startIndex; // 0x00
		public int dataLength; // 0x04
	
		// Properties
		public bool IsValid { get => default; } // 0x0000000182BB8B20-0x0000000182BB8B30 
		public static DataChunk Empty { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public DataChunk(int sindex, int length) : this() {
			startIndex = default;
			dataLength = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		public DataChunk(int sindex) : this() {
			startIndex = default;
			dataLength = default;
		} // 0x0000000183D4F9A0-0x0000000183D4F9B0
	
		// Methods
		public void Clear() {} // 0x0000000183211E70-0x0000000183211EA0
		public override string ToString() => default; // 0x0000000185467E78-0x0000000185467F38
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185467F38-0x0000000185467F88
	}

	[Serializable]
	public struct ExBitFlag16 // TypeDefIndex: 45222
	{
		// Fields
		public ushort Value; // 0x00
	
		// Constructors
		public ExBitFlag16(ushort initialValue = 0 /* Metadata: 0x01FB936C */) {
			Value = default;
		} // 0x0000000183D4F9B0-0x0000000183D4F9C0
	
		// Methods
		public void Clear() {} // 0x0000000185468370-0x00000001854683C4
		public void SetFlag(ushort flag, bool sw) {} // 0x00000001854683CC-0x00000001854683E8
		public bool IsSet(ushort flag) => default; // 0x00000001854683C4-0x00000001854683CC
	}

	[Serializable]
	public struct ExBitFlag8 // TypeDefIndex: 45223
	{
		// Fields
		public byte Value; // 0x00
	
		// Constructors
		public ExBitFlag8(byte initialValue = 0 /* Metadata: 0x01FB936E */) {
			Value = default;
		} // 0x0000000183D4F9D0-0x0000000183D4F9E0
	
		// Methods
		public void Clear() {} // 0x0000000183D4F9C0-0x0000000183D4F9D0
		public void SetFlag(byte flag, bool sw) {} // 0x00000001854683F0-0x0000000185468404
		public bool IsSet(byte flag) => default; // 0x00000001854683E8-0x00000001854683F0
	}

	public struct ExCostSortedList1 : IComparable<ExCostSortedList1> // TypeDefIndex: 45224
	{
		// Fields
		internal float cost; // 0x00
		internal int data; // 0x04
	
		// Properties
		public bool IsValid { get => default; } // 0x00000001854685D0-0x00000001854685E0 
		public int Count { get => default; } // 0x00000001854685C0-0x00000001854685D0 
		public float Cost { get => default; } // 0x0000000183D4FA00-0x0000000183D4FA10 
		public int Data { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
	
		// Constructors
		public ExCostSortedList1(float invalidCost) : this() {
			cost = default;
			data = default;
		} // 0x0000000183D4F9F0-0x0000000183D4FA00
		public ExCostSortedList1(float invalidCost, int initData) : this() {
			cost = default;
			data = default;
		} // 0x0000000183D4F9E0-0x0000000183D4F9F0
	
		// Methods
		public void Add(float cost, int item) {} // 0x0000000185468404-0x0000000185468420
		public int CompareTo(ExCostSortedList1 other) => default; // 0x0000000185468420-0x00000001854684A0
		public override string ToString() => default; // 0x00000001854684A0-0x0000000185468570
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185468570-0x00000001854685C0
	}

	public struct ExCostSortedList4 // TypeDefIndex: 45225
	{
		// Fields
		internal float4 costs; // 0x00
		internal int4 data; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x0000000185467AE4-0x0000000185467B08 
		public bool IsValid { get => default; } // 0x00000001854685D0-0x00000001854685E0 
		public float MinCost { get => default; } // 0x0000000183D4FA00-0x0000000183D4FA10 
		public float MaxCost { get => default; } // 0x0000000185468930-0x0000000185468950 
	
		// Constructors
		public ExCostSortedList4(float invalidCost) : this() {
			costs = default;
			data = default;
		} // 0x0000000183D4FA10-0x0000000183D4FA30
	
		// Methods
		public bool Add(float cost, int item) => default; // 0x00000001854685E0-0x00000001854686C4
		public bool Contains(int item) => default; // 0x0000000185467ABC-0x0000000185467AE4
		public int indexOf(int item) => default; // 0x0000000185468950-0x00000001854689D8
		public void RemoveItem(int item) {} // 0x00000001854686C4-0x0000000185468778
		public override string ToString() => default; // 0x0000000185468778-0x00000001854688D8
		public string __iFixBaseProxy_ToString() => default; // 0x00000001854688D8-0x0000000185468930
	}

	public class ExNativeArray<T> : IDisposable // TypeDefIndex: 45226
		where T : struct
	{
		// Fields
		private NativeArray<T> nativeArray;
		private List<DataChunk> emptyChunks;
		private int useCount;
	
		// Properties
		public bool IsValid { get => default; }
		public int Length { get => default; }
		public int Count { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public ExNativeArray() {}
		public ExNativeArray(int emptyLength, bool create = false /* Metadata: 0x01FB936F */) {}
		public ExNativeArray(int emptyLength, T fillData) {}
		public ExNativeArray(NativeArray<T> dataArray) {}
		public ExNativeArray(T[] dataArray) {}
	
		// Methods
		public void Dispose() {}
		public DataChunk AddRange(int dataLength) => default;
		public DataChunk AddRange(int dataLength, T fillData = default) => default;
		public DataChunk AddRange(T[] array) => default;
		public DataChunk AddRange(NativeArray<T> narray, int length = 0 /* Metadata: 0x01FB9370 */) => default;
		public DataChunk AddRange(ExNativeArray<T> exarray) => default;
		public DataChunk AddRange(ExSimpleNativeArray<T> exarray) => default;
		public DataChunk AddRange<U>(U[] array)
			where U : struct => default;
		public DataChunk AddRange<U>(NativeArray<U> udata)
			where U : struct => default;
		public DataChunk AddRangeTypeChange<U>(U[] array)
			where U : struct => default;
		public DataChunk AddRangeStride<U>(U[] array)
			where U : struct => default;
		public DataChunk Add(T data) => default;
		public DataChunk Expand(DataChunk c, int newDataLength) => default;
		public DataChunk ExpandAndFill(DataChunk c, int newDataLength, T fillData = default, T clearData = default) => default;
		public T[] ToArray() => default;
		public void CopyTo(T[] array) {}
		public void CopyTo<U>(U[] array)
			where U : struct {}
		public void CopyFrom(NativeArray<T> array) {}
		public void CopyFrom<U>(NativeArray<U> array)
			where U : struct {}
		public void CopyTypeChange<U>(U[] array)
			where U : struct {}
		public void CopyTypeChangeStride<U>(U[] array)
			where U : struct {}
		public void AddEmpty(int dataLength) {}
		public void Remove(DataChunk chunk) {}
		public void Remove(int index) {}
		public void RemoveAndFill(DataChunk chunk, T clearData = default) {}
		public void Fill(T fillData = default) {}
		public void Fill(DataChunk chunk, T fillData = default) {}
		private void FillInternal(int start, int size, T fillData = default) {}
		public void Clear() {}
		public ref ref T GetRef(int index) => ref _refReturnTypeForGetRef;
		private ref T _refReturnTypeForGetRef; // Dummy field
		public NativeArray<T> GetNativeArray() => default;
		public NativeArray<U> GetNativeArray<U>()
			where U : struct => default;
		private DataChunk GetEmptyChunk(int dataLength) => default;
		private void AddEmptyChunk(DataChunk chunk) {}
		public override string ToString() => default;
		public string ToSummary() => default;
	}

	public class ExProcessingList<T> : IDisposable, IValid // TypeDefIndex: 45227
		where T : struct
	{
		// Fields
		public NativeReference<int> Counter;
		public NativeArray<T> Buffer;
	
		// Constructors
		public ExProcessingList() {}
	
		// Methods
		public void Dispose() {}
		public bool IsValid() => default;
		public void UpdateBuffer(int capacity) {}
		public unsafe int* GetJobSchedulePtr() => default;
		public override string ToString() => default;
	}

	public class ExSimpleNativeArray<T> : IDisposable // TypeDefIndex: 45229
		where T : struct
	{
		// Fields
		private NativeArray<T> nativeArray;
		private int count;
		private int length;
	
		// Properties
		public bool IsValid { get => default; }
		public int Count { get => default; }
		public int Length { get => default; }
		public T this[int index] { get => default; set {} }
	
		// Nested types
		[Serializable]
		public class SerializationData // TypeDefIndex: 45228
		{
			// Fields
			public int count;
			public int length;
			public byte[] arrayBytes;
	
			// Constructors
			public SerializationData() {}
		}
	
		// Constructors
		public ExSimpleNativeArray() {}
		public ExSimpleNativeArray(int dataLength, bool areaOnly = false /* Metadata: 0x01FB9371 */) {}
		public ExSimpleNativeArray(T[] dataArray) {}
		public ExSimpleNativeArray(NativeArray<T> array) {}
		public ExSimpleNativeArray(NativeList<T> array) {}
		public ExSimpleNativeArray(SerializationData sdata) {}
	
		// Methods
		public void Dispose() {}
		public void SetCount(int newCount) {}
		public void SetLength(int newLength) {}
		public void AddRange(int dataLength) {}
		public void AddRange(T[] dataArray) {}
		public void AddRange(T[] dataArray, int cnt) {}
		public void AddRange(int dataLength, T fillData = default) {}
		public void AddRange(NativeArray<T> narray) {}
		public void AddRange(NativeList<T> nlist) {}
		public void AddRange(ExSimpleNativeArray<T> exarray) {}
		public void AddRange<U>(U[] array)
			where U : struct {}
		public void AddRangeTypeChange<U>(U[] array)
			where U : struct {}
		public void AddRangeTypeChange<U>(NativeArray<U> array)
			where U : struct {}
		public void AddRangeStride<U>(U[] array)
			where U : struct {}
		public void Add(T data) {}
		public T[] ToArray() => default;
		public void CopyTo(T[] array) {}
		public void CopyTo<U>(U[] array)
			where U : struct {}
		public void CopyToWithTypeChange<U>(U[] array)
			where U : struct {}
		public void CopyToWithTypeChangeStride<U>(U[] array)
			where U : struct {}
		public void CopyFrom(NativeArray<T> array) {}
		public void CopyFrom<U>(NativeArray<U> array)
			where U : struct {}
		public void CopyFromWithTypeChangeStride<U>(NativeArray<U> array)
			where U : struct {}
		public void Fill(int startIndex, int dataLength, T fillData = default) {}
		private void FillInternal(int start, int size, T fillData = default) {}
		public NativeArray<T> GetNativeArray() => default;
		public NativeArray<U> GetNativeArray<U>()
			where U : struct => default;
		private void Expand(int dataLength, bool force = false /* Metadata: 0x01FB9372 */, bool copy = true /* Metadata: 0x01FB9373 */) {}
		public override string ToString() => default;
		public SerializationData Serialize() => default;
		public bool Deserialize(SerializationData data) => default;
	}

	public class ExTransformAccessArray : IDisposable // TypeDefIndex: 45230
	{
		// Fields
		private TransformAccessArray transformArray; // 0x10
		private int nativeLength; // 0x18
		private Queue<int> emptyStack; // 0x20
		private Dictionary<int, int> useIndexDict; // 0x28
		private Dictionary<int, int> indexDict; // 0x30
		private Dictionary<int, int> referenceDict; // 0x38
	
		// Properties
		public int Count { get => default; } // 0x0000000185469498-0x00000001854694D8 
		public int Length { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public Transform this[int index] { get => default; } // 0x00000001854694D8-0x00000001854694E4 
	
		// Constructors
		public ExTransformAccessArray() {} // Dummy constructor
		public ExTransformAccessArray(int capacity, int desiredJobCount = -1 /* Metadata: 0x01FB9374 */) {} // 0x000000018546932C-0x0000000185469498
	
		// Methods
		public void Dispose() {} // 0x0000000185468E10-0x0000000185468EEC
		public TransformAccessArray GetTransformAccessArray() => default; // 0x000000018546912C-0x000000018546917C
		public int Add(Transform element) => default; // 0x00000001854689D8-0x0000000185468BE4
		public void Remove(int index) {} // 0x000000018546917C-0x000000018546932C
		[IDTag(0)]
		public bool Exist(int index) => default; // 0x0000000185468EEC-0x0000000185468F74
		[IDTag(1)]
		public bool Exist(Transform element) => default; // 0x0000000185468F74-0x000000018546903C
		public int GetIndex(Transform element) => default; // 0x000000018546903C-0x000000018546912C
		public void Clear() {} // 0x0000000185468BE4-0x0000000185468E10
	}

	public static class FixedList128BytesExtensions // TypeDefIndex: 45231
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(this ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(this ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(this ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class FixedList32BytesExtensions // TypeDefIndex: 45232
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(this ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(this ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(this ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class FixedList4096BytesExtensions // TypeDefIndex: 45233
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(this ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(this ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(this ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class FixedList512BytesExtensions // TypeDefIndex: 45234
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(this ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(this ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(this ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class FixedList64BytesExtensions // TypeDefIndex: 45235
	{
		// Extension methods
		public static bool MC2IsCapacity<T>(this ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(this ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(this ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(this ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class NativeArrayExtensions // TypeDefIndex: 45236
	{
		// Methods
		public static NativeArray<T> MC2FromRawBytes<T>(byte[] bytes, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FB9377 */)
			where T : struct => default;
	
		// Extension methods
		public static void MC2DisposeSafe<T>(this ref NativeArray<T> array)
			where T : struct {}
		public static void MC2Resize<T>(this ref NativeArray<T> array, int size, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x01FB9375 */, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x01FB9376 */)
			where T : struct {}
		public static byte[] MC2ToRawBytes<T>(this ref NativeArray<T> array)
			where T : struct => default;
	}

	public static class NativeMultiHashMapExtensions // TypeDefIndex: 45238
	{
		// Nested types
		[BurstCompile]
		private struct SetParallelMultiHashMapJob<TKey, TValue> : IJob // TypeDefIndex: 45237
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
			public void Execute() {}
		}
	
		// Methods
		public static NativeParallelMultiHashMap<int2, ushort> MC2Deserialize(int2[] keyArray, ushort[] valueArray) => default; // 0x0000000182E1CBA0-0x0000000182E1CE80
	
		// Extension methods
		public static bool MC2Contains<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> => default;
		public static void MC2UniqueAdd<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> {}
		public static bool MC2RemoveValue<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> => default;
		public static FixedList512Bytes<TValue> MC2ToFixedList512Bytes<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> => default;
		public static FixedList128Bytes<TValue> MC2ToFixedList128Bytes<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> => default;
		public static ValueTuple<TKey[], TValue[]> MC2Serialize<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct => default;
		public static void MC2DisposeSafe<TKey, TValue>(this ref NativeParallelMultiHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> {}
	}

	public static class NativeParallelHashMap // TypeDefIndex: 45239
	{
		// Extension methods
		public static void MC2DisposeSafe<TKey, TValue>(this ref NativeParallelHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> {}
	}

	internal static class NativeReferenceExtensions // TypeDefIndex: 45240
	{
		// Methods
		public static unsafe int MC2InterlockedStartIndex(int* cntPt, int dataCount) => default; // 0x0000000183D4FA30-0x0000000183D4FA40
	
		// Extension methods
		public static int MC2InterlockedStartIndex(this ref NativeReference<int> counter, int dataCount) => default; // 0x0000000185469B88-0x0000000185469C04
	}

	public class PlayerLoopUtils // TypeDefIndex: 45242
	{
		// Constructors
		public PlayerLoopUtils() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void AddPlayerLoop(PlayerLoopSystem method, ref PlayerLoopSystem playerLoop, string categoryName, string systemName, bool last = false /* Metadata: 0x01FB9378 */, bool before = false /* Metadata: 0x01FB9379 */) {} // 0x0000000182D94740-0x0000000182D94AA0
	}

	[Serializable]
	public class MagicaClothProcessingException : Exception // TypeDefIndex: 45243
	{
		// Constructors
		public MagicaClothProcessingException() {} // 0x00000001854696BC-0x0000000185469708
		public MagicaClothProcessingException(string message) {} // 0x0000000185469768-0x00000001854697C4
		public MagicaClothProcessingException(string message, Exception inner) {} // 0x0000000185469708-0x0000000185469768
	}

	[Serializable]
	public class MagicaClothCanceledException : Exception // TypeDefIndex: 45244
	{
		// Constructors
		public MagicaClothCanceledException() {} // 0x0000000185469614-0x0000000185469660
		public MagicaClothCanceledException(string message) {} // 0x0000000185469660-0x00000001854696BC
		public MagicaClothCanceledException(string message, Exception inner) {} // 0x00000001854695B4-0x0000000185469614
	}

	[Serializable]
	public struct ResultCode // TypeDefIndex: 45245
	{
		// Fields
		[SerializeField]
		private Define.Result result; // 0x00
		[SerializeField]
		private Define.Result warning; // 0x04
	
		// Properties
		public Define.Result Result { get => default; } // 0x0000000183D4FAC0-0x0000000183D4FAD0 
		public static ResultCode None { get => default; } // 0x0000000183D4FAA0-0x0000000183D4FAC0 
		public static ResultCode Empty { get => default; } // 0x0000000183D4FA60-0x0000000183D4FA80 
		public static ResultCode Success { get => default; } // 0x0000000183D4FAD0-0x0000000183D4FAF0 
		public static ResultCode Error { get => default; } // 0x0000000183D4FA80-0x0000000183D4FAA0 
	
		// Constructors
		public ResultCode(Define.Result initResult) : this() {
			result = default;
			warning = default;
		} // 0x0000000183D4FA40-0x0000000183D4FA60
	
		// Methods
		public void Clear() {} // 0x0000000182E1F710-0x0000000182E1F750
		public void SetResult(Define.Result code) {} // 0x0000000182E27AB0-0x0000000182E27AF0
		public void SetSuccess() {} // 0x0000000182E27A70-0x0000000182E27AB0
		public void SetCancel() {} // 0x000000018546A210-0x000000018546A268
		public void SetError(Define.Result code = Define.Result.Error /* Metadata: 0x01FB937A */) {} // 0x000000018546A268-0x000000018546A2C0
		public void SetWarning(Define.Result code = Define.Result.Warning /* Metadata: 0x01FB937E */) {} // 0x000000018546A2C0-0x000000018546A31C
		public void Merge(ResultCode src) {} // 0x0000000182E229B0-0x0000000182E22A10
		public void SetProcess() {} // 0x0000000182E27A30-0x0000000182E27A70
		public bool IsResult(Define.Result code) => default; // 0x000000018546A1B0-0x000000018546A210
		public bool IsNone() => default; // 0x000000018546A0A8-0x000000018546A100
		public bool IsSuccess() => default; // 0x0000000182E27D30-0x0000000182E27D70
		public bool IsFaild() => default; // 0x0000000182E27CF0-0x0000000182E27D30
		public bool IsCancel() => default; // 0x000000018546A050-0x000000018546A0A8
		public bool IsNormal() => default; // 0x000000018546A100-0x000000018546A158
		public bool IsError() => default; // 0x0000000182E22E80-0x0000000182E22EC0
		public bool IsProcess() => default; // 0x000000018546A158-0x000000018546A1B0
		public bool IsWarning() => default; // 0x0000000182E22A10-0x0000000182E22A50
		public string GetResultString() => default; // 0x0000000185469DCC-0x0000000185469EDC
		public string GetWarningString() => default; // 0x0000000185469F7C-0x000000018546A050
		public string GetResultInformation() => default; // 0x0000000185469C90-0x0000000185469DCC
		public string GetWarningInformation() => default; // 0x0000000185469EDC-0x0000000185469F7C
		[Conditional("MC2_DEBUG")]
		public void DebugLog(bool error = true /* Metadata: 0x01FB9382 */, bool warning = true /* Metadata: 0x01FB9383 */, bool normal = true /* Metadata: 0x01FB9384 */) {} // 0x0000000185469C04-0x0000000185469C90
	}

	public class TimeSpan // TypeDefIndex: 45246
	{
		// Fields
		private string name; // 0x10
		private System.DateTime stime; // 0x18
		private System.DateTime etime; // 0x20
	
		// Constructors
		public TimeSpan() {} // 0x000000018546AC54-0x000000018546AC9C
		public TimeSpan(string name) {} // 0x000000018546AC9C-0x000000018546AD24
	
		// Methods
		public void Start() {} // 0x000000018546A9A8-0x000000018546AA24
		public void Finish() {} // 0x000000018546A8D4-0x000000018546A950
		public double TotalSeconds() => default; // 0x000000018546AB94-0x000000018546AC54
		public double TotalMilliSeconds() => default; // 0x000000018546AAD4-0x000000018546AB94
		public override string ToString() => default; // 0x000000018546AA24-0x000000018546AAD4
		public void DebugLog() {} // 0x000000018546A890-0x000000018546A8D4
		public void Log() {} // 0x000000018546A950-0x000000018546A9A8
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public class UnityTimeSpan // TypeDefIndex: 45247
	{
		// Fields
		private string name; // 0x10
		private float stime; // 0x18
		private float etime; // 0x1C
		private bool isFinish; // 0x20
	
		// Constructors
		public UnityTimeSpan() {} // Dummy constructor
		public UnityTimeSpan(string name) {} // 0x000000018546AF70-0x000000018546AFE0
	
		// Methods
		public void Finish() {} // 0x000000018546ADA0-0x000000018546AE00
		public float TotalSeconds() => default; // 0x000000018546AF14-0x000000018546AF70
		public float TotalMilliSeconds() => default; // 0x000000018546AEB0-0x000000018546AF14
		public override string ToString() => default; // 0x000000018546AE00-0x000000018546AEB0
		public void DebugLog() {} // 0x000000018546AD24-0x000000018546ADA0
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	public class VirtualMesh : IDisposable, IValid // TypeDefIndex: 45305
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
		public const byte EdgeFlag_Cut = 1; // Metadata: 0x01FB9389
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
		public const byte BaseLineFlag_IncludeLine = 1; // Metadata: 0x01FB938A
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
		public float InitCalcScale { get => default; } // 0x0000000183D4FAF0-0x0000000183D4FB00 
		public bool IsSuccess { get => default; } // 0x0000000185475D7C-0x0000000185475D88 
		public bool IsError { get => default; } // 0x00000001842757D0-0x00000001842757DC 
		public bool IsProcess { get => default; } // 0x0000000185475D5C-0x0000000185475D68 
		public int VertexCount { get => default; } // 0x000000018310FC70-0x000000018310FCB0 
		public int TriangleCount { get => default; } // 0x000000018310DB10-0x000000018310DB50 
		public int LineCount { get => default; } // 0x000000018310DB50-0x000000018310DB90 
		public int SkinBoneCount { get => default; } // 0x0000000185475E08-0x0000000185475E48 
		public int TransformCount { get => default; } // 0x0000000182E20FB0-0x0000000182E20FD0 
		public bool IsProxy { get => default; } // 0x0000000185475D68-0x0000000185475D7C 
		public bool IsMapping { get => default; } // 0x0000000185475D54-0x0000000185475D5C 
		public int BaseLineCount { get => default; } // 0x000000018310E320-0x000000018310E380 
		public int EdgeCount { get => default; } // 0x000000018310E380-0x000000018310E3E0 
		public int CustomSkinningBoneCount { get => default; } // 0x0000000185475D40-0x0000000185475D54 
		public int CenterFixedPointCount { get => default; } // 0x0000000182E1A2A0-0x0000000182E1A2C0 
		public int NormalAdjustmentRotationCount { get => default; } // 0x0000000185475D88-0x0000000185475E08 
	
		// Nested types
		[BurstCompile]
		private struct Import_GenerateTangentJob : IJobParallelFor // TypeDefIndex: 45248
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> localNormals; // 0x00
			[WriteOnly]
			public NativeArray<float3> localTangents; // 0x10
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001854AE1A0-0x00000001854AE2E0
		}
	
		[BurstCompile]
		private struct Import_CalcSkinningJob : IJobParallelFor // TypeDefIndex: 45249
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
			public void Execute(int vindex) {} // 0x00000001854ADBDC-0x00000001854AE1A0
		}
	
		[BurstCompile]
		private struct Import_BoneWeightJob1 : IJob // TypeDefIndex: 45250
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			[WriteOnly]
			public NativeArray<int> startBoneWeightIndices; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854ADA64-0x00000001854ADADC
		}
	
		[BurstCompile]
		private struct Import_BoneWeightJob2 : IJobParallelFor // TypeDefIndex: 45251
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
			public void Execute(int vindex) {} // 0x00000001854ADADC-0x00000001854ADBDC
		}
	
		[BurstCompile]
		private struct Import_BoneVertexJob : IJobParallelFor // TypeDefIndex: 45252
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
			public void Execute(int vindex) {} // 0x0000000182E24F60-0x0000000182E254C0
		}
	
		[BurstCompile]
		private struct Select_PackVertexJob : IJob // TypeDefIndex: 45253
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
			public void Execute() {} // 0x00000001854B3338-0x00000001854B34BC
		}
	
		[BurstCompile]
		private struct Select_GridJob : IJob // TypeDefIndex: 45254
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
			public void Execute() {} // 0x00000001854B2CE8-0x00000001854B3338
		}
	
		[BurstCompile]
		private struct Add_CalcBindPoseJob : IJobParallelFor // TypeDefIndex: 45255
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
			public void Execute(int boneIndex) {} // 0x00000001854AC6EC-0x00000001854AC880
		}
	
		[BurstCompile]
		private struct Add_CopyVerticesJob : IJobParallelFor // TypeDefIndex: 45256
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
			public void Execute(int vindex) {} // 0x00000001854AC880-0x00000001854ACAE4
		}
	
		private struct MappingWorkData // TypeDefIndex: 45257
		{
			// Fields
			public float3 position; // 0x00
			public int vertexIndex; // 0x0C
			public int proxyVertexIndex; // 0x10
			public float proxyVertexDistance; // 0x14
		}
	
		[BurstCompile]
		private struct Mapping_DirectConnectionVertexDataJob : IJob // TypeDefIndex: 45258
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
			public void Execute() {} // 0x00000001854AF428-0x00000001854AF604
		}
	
		private struct Mapping_CalcDirectWeightJob : IJob // TypeDefIndex: 45259
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
			public void Execute() {} // 0x00000001854AEAB8-0x00000001854AEFD4
		}
	
		[BurstCompile]
		private struct Mapping_CalcConnectionVertexDataJob : IJob // TypeDefIndex: 45260
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
			public void Execute() {} // 0x00000001854AE2E0-0x00000001854AEAB8
		}
	
		[BurstCompile]
		private struct Mapping_CalcWeightJob : IJobParallelFor // TypeDefIndex: 45261
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
			public void Execute(int vindex) {} // 0x00000001854AEFD4-0x00000001854AF428
		}
	
		[BurstCompile]
		private struct Optimize_EdgeToTrianlgeJob : IJob // TypeDefIndex: 45262
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
			public void Execute() {} // 0x00000001854AF604-0x00000001854B01DC
		}
	
		[BurstCompile]
		private struct ProxyNormalRadiationAdjustmentJob : IJobParallelFor // TypeDefIndex: 45263
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
			public void Execute(int vindex) {} // 0x00000001854B1084-0x00000001854B168C
		}
	
		[BurstCompile]
		private struct ProxyCreateFixedListAndAABBJob : IJob // TypeDefIndex: 45264
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
			public void Execute() {} // 0x000000018337F270-0x000000018337F7C0
		}
	
		[BurstCompile]
		private struct Proxy_CalcTriangleNormalJob : IJobParallelFor // TypeDefIndex: 45265
		{
			// Fields
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x00
			[ReadOnly]
			public NativeArray<float3> localPositins; // 0x10
			[WriteOnly]
			public NativeArray<float3> triangleNormals; // 0x20
	
			// Methods
			public void Execute(int tindex) {} // 0x00000001854B1B04-0x00000001854B1C6C
		}
	
		[BurstCompile]
		private struct Proxy_CalcTriangleTangentJob : IJobParallelFor // TypeDefIndex: 45266
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
			public void Execute(int tindex) {} // 0x00000001854B1C6C-0x00000001854B1DCC
		}
	
		[BurstCompile]
		private struct Proxy_CreateVertexToTrianglesJob : IJob // TypeDefIndex: 45267
		{
			// Fields
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x00
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x10
	
			// Methods
			public void Execute() {} // 0x00000001854B22B4-0x00000001854B2408
		}
	
		[BurstCompile]
		private struct Proxy_OrganizeVertexToTrianglsJob : IJobParallelFor // TypeDefIndex: 45268
		{
			// Fields
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x00
			[ReadOnly]
			public NativeArray<float3> triangleNormals; // 0x10
			[ReadOnly]
			public NativeArray<float3> triangleTangents; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001854B2408-0x00000001854B2B88
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexNormalTangentFromTriangleJob : IJobParallelFor // TypeDefIndex: 45269
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
			public void Execute(int vindex) {} // 0x00000001854B1DCC-0x00000001854B20C8
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToTransformJob : IJobParallelFor // TypeDefIndex: 45270
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
			public void Execute(int vindex) {} // 0x0000000182E23E00-0x0000000182E23F50
		}
	
		[BurstCompile]
		private struct Proxy_CalcEdgeToTriangleJob : IJob // TypeDefIndex: 45271
		{
			// Fields
			public int tcnt; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854B19B0-0x00000001854B1B04
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexBindPoseJob2 : IJobParallelFor // TypeDefIndex: 45272
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
			public void Execute(int vindex) {} // 0x0000000182E23FE0-0x0000000182E241C0
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToVertexFromTriangleJob : IJob // TypeDefIndex: 45273
		{
			// Fields
			public int triangleCount; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<int, ushort> vertexToVertexMap; // 0x18
			public NativeParallelHashSet<int2> edgeSet; // 0x28
	
			// Methods
			public void Execute() {} // 0x00000001854B20C8-0x00000001854B22B4
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToVertexFromLineJob : IJob // TypeDefIndex: 45274
		{
			// Fields
			public int lineCount; // 0x00
			[ReadOnly]
			public NativeArray<int2> lines; // 0x08
			public NativeParallelMultiHashMap<int, ushort> vertexToVertexMap; // 0x18
			public NativeParallelHashSet<int2> edgeSet; // 0x28
	
			// Methods
			public void Execute() {} // 0x000000018353DFD0-0x000000018353E0E0
		}
	
		[BurstCompile]
		private struct Proxy_CreateEdgeFlagJob : IJobParallelFor // TypeDefIndex: 45275
		{
			// Fields
			[ReadOnly]
			public NativeArray<int2> edges; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x10
			[WriteOnly]
			public NativeArray<ExBitFlag8> edgeFlags; // 0x20
	
			// Methods
			public void Execute(int eindex) {} // 0x0000000182E24880-0x0000000182E24920
		}
	
		private struct SkinningBoneInfo // TypeDefIndex: 45276
		{
			// Fields
			public int parentTransformIndex; // 0x00
			public float3 parentPos; // 0x04
			public int childTransformIndex; // 0x10
			public float3 childPos; // 0x14
		}
	
		[BurstCompile]
		private struct Proxy_CalcCustomSkinningWeightsJobV2 : IJobParallelFor // TypeDefIndex: 45277
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
			public void Execute(int vindex) {} // 0x00000001854B168C-0x00000001854B19B0
		}
	
		[BurstCompile]
		private struct Proxy_ApplySelectionJob : IJobParallelFor // TypeDefIndex: 45278
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
			public void Execute(int vindex) {} // 0x00000001826D62E0-0x00000001826D6F00
		}
	
		[BurstCompile]
		private struct Proxy_BoneClothApplayTransformFlagJob : IJobParallelFor // TypeDefIndex: 45279
		{
			// Fields
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x00
			public NativeArray<ExBitFlag8> transformFlags; // 0x10
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000182BA2460-0x0000000182BA2620
		}
	
		private struct BaseLineWork : IComparable<BaseLineWork> // TypeDefIndex: 45280
		{
			// Fields
			public int vindex; // 0x00
			public float dist; // 0x04
	
			// Methods
			public int CompareTo(BaseLineWork other) => default; // 0x00000001854ACAE4-0x00000001854ACB54
		}
	
		[BurstCompile]
		private struct BaseLine_Mesh_CreateParentJob2 : IJob // TypeDefIndex: 45281
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
			public void Execute() {} // 0x00000001854ACCB8-0x00000001854AD7A0
		}
	
		[BurstCompile]
		private struct BaseLine_Mesh_CareteFixedListJob : IJob // TypeDefIndex: 45282
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<VertexAttribute> attribues; // 0x08
			public NativeList<int> fixedList; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854ACBEC-0x00000001854ACCB8
		}
	
		[BurstCompile]
		private struct BaseLine_Bone_CreateBoneChildInfoJob : IJob // TypeDefIndex: 45283
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<int> parentIndices; // 0x08
			[WriteOnly]
			public NativeParallelMultiHashMap<int, ushort> childMap; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854ACB54-0x00000001854ACBEC
		}
	
		[BurstCompile]
		private struct BaseLine_CalcLocalPositionRotationJob : IJobParallelFor // TypeDefIndex: 45284
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
			public void Execute(int index) {} // 0x0000000182E24200-0x0000000182E246E0
		}
	
		[BurstCompile]
		private struct BaseLine_CalcMaxBaseLineLengthJob : IJob // TypeDefIndex: 45285
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
			public void Execute() {} // 0x00000001826D7840-0x00000001826D7B40
		}
	
		[BurstCompile]
		private struct Reduction_InitVertexToVertexJob2 : IJob // TypeDefIndex: 45286
		{
			// Fields
			public int triangleCount; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854B2B88-0x00000001854B2CE8
		}
	
		[BurstCompile]
		private struct Organize_RemapVertexJob : IJob // TypeDefIndex: 45287
		{
			// Fields
			public int oldVertexCount; // 0x00
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x08
			public NativeArray<int> vertexRemapIndices; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854B0FE0-0x00000001854B1084
		}
	
		[BurstCompile]
		private struct Organize_CollectUseSkinBoneJob : IJob // TypeDefIndex: 45288
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
			public void Execute() {} // 0x00000001854B01DC-0x00000001854B0584
		}
	
		[BurstCompile]
		private struct Organize_CopyVertexJob : IJobParallelFor // TypeDefIndex: 45289
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
			public void Execute(int index) {} // 0x00000001854B0584-0x00000001854B0678
		}
	
		[BurstCompile]
		private struct Organize_RemapBoneWeightJob : IJobParallelFor // TypeDefIndex: 45290
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
			public void Execute(int vindex) {} // 0x00000001854B0D3C-0x00000001854B0E4C
		}
	
		[BurstCompile]
		private struct Organize_RemapLinkPointArrayJob : IJobParallelFor // TypeDefIndex: 45291
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
			public void Execute(int vindex) {} // 0x00000001854B0E4C-0x00000001854B0FE0
		}
	
		[BurstCompile]
		private struct Organize_CreateLineTriangleJob : IJob // TypeDefIndex: 45292
		{
			// Fields
			public int newVertexCount; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x08
			[WriteOnly]
			public NativeParallelHashSet<int2> edgeSet; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854B09FC-0x00000001854B0BA8
		}
	
		[BurstCompile]
		private struct Organize_CreateLineTriangleJob2 : IJob // TypeDefIndex: 45293
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
			public void Execute() {} // 0x00000001854B0678-0x00000001854B09FC
		}
	
		[BurstCompile]
		private struct Organize_CreateNewTriangleJob3 : IJob // TypeDefIndex: 45294
		{
			// Fields
			[WriteOnly]
			public NativeList<int3> newTriangleList; // 0x00
			[ReadOnly]
			public NativeParallelHashSet<int3> triangleSet; // 0x10
	
			// Methods
			public void Execute() {} // 0x00000001854B0BA8-0x00000001854B0D3C
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 45295
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
			public ShareSerializationData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override string ToString() => default; // 0x00000001854B34BC-0x00000001854B374C
			public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 45296
		{
			// Fields
			public BeyondDynamicBone.TransformData.UniqueSerializationData transformData; // 0x10
	
			// Constructors
			public UniqueSerializationData() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x00000001854B374C-0x00000001854B37B8
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001854B37B8-0x00000001854B3824
		}
	
		[BurstCompile]
		private struct Work_AverageTriangleDistanceJob : IJob // TypeDefIndex: 45297
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
			public void Execute() {} // 0x00000001854B4F20-0x00000001854B5198
		}
	
		[BurstCompile]
		private struct Work_AverageLineDistanceJob : IJob // TypeDefIndex: 45298
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
			public void Execute() {} // 0x00000001834F3920-0x00000001834F3B70
		}
	
		[BurstCompile]
		private struct Work_AddVertexIndexGirdMapJob : IJob // TypeDefIndex: 45299
		{
			// Fields
			public float gridSize; // 0x00
			public int vcnt; // 0x04
			[ReadOnly]
			public NativeArray<float3> positins; // 0x08
			[WriteOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001854B4E54-0x00000001854B4F20
		}
	
		[BurstCompile]
		private struct Work_IntersectTriangleJob : IJobParallelFor // TypeDefIndex: 45300
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
			public void Execute(int tindex) {} // 0x00000001854B5620-0x00000001854B59C4
		}
	
		[BurstCompile]
		private struct Work_IntersectEdgeJob : IJobParallelFor // TypeDefIndex: 45301
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
			public void Execute(int eindex) {} // 0x00000001854B5198-0x00000001854B5450
		}
	
		[BurstCompile]
		private struct Work_IntersectPointJob : IJobParallelFor // TypeDefIndex: 45302
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
			public void Execute(int vindex) {} // 0x00000001854B5450-0x00000001854B5620
		}
	
		[BurstCompile]
		private struct Work_IntersetcSortJob : IJob // TypeDefIndex: 45303
		{
			// Fields
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x00
	
			// Methods
			public void Execute() {} // 0x00000001854B59C4-0x00000001854B5A64
		}
	
		public enum MeshType // TypeDefIndex: 45304
		{
			NormalMesh = 0,
			NormalBoneMesh = 1,
			ProxyMesh = 2,
			ProxyBoneMesh = 3,
			Mapping = 4
		}
	
		// Constructors
		public VirtualMesh() {} // 0x0000000183572420-0x0000000183572700
		public VirtualMesh(bool initialize) {} // 0x0000000182E1DF60-0x0000000182E1E350
		public VirtualMesh(string name) {} // 0x0000000182E1D380-0x0000000182E1D3C0
	
		// Methods
		[IDTag(0)]
		public void ImportFrom(RenderSetupData rsetup) {} // 0x0000000182E232C0-0x0000000182E236B0
		private void ImportMeshType(RenderSetupData rsetup, int[] transformIndices) {} // 0x000000018546E040-0x000000018546E970
		private void ImportMeshSkinning() {} // 0x000000018546DDB4-0x000000018546E040
		private void ImportBoneType(RenderSetupData rsetup, int[] transformIndices) {} // 0x00000001828C58D0-0x00000001828C8C30
		[IDTag(1)]
		public void ImportFrom(BeyondDynamicBone.RenderData renderData) {} // 0x000000018546DC04-0x000000018546DDB4
		public void SelectionMesh(SelectionData selectionData, float4x4 selectionLocalToWorldMatrix, float mergin) {} // 0x0000000185472E78-0x0000000185474080
		public float CalcSelectionMergin(ReductionSettings settings) => default; // 0x000000018546BEBC-0x000000018546BFBC
		public void AddMesh(VirtualMesh cmesh) {} // 0x000000018546AFE0-0x000000018546BEBC
		[IDTag(1)]
		public void SetTransform(Transform center, Transform skinRoot = null, int centerId = 0 /* Metadata: 0x01FB9385 */, int skinRootId = 0 /* Metadata: 0x01FB9386 */) {} // 0x0000000185474810-0x0000000185474A58
		[IDTag(0)]
		public void SetTransform(TransformRecord centerRecord, TransformRecord skinRootRecord = null) {} // 0x00000001854745E8-0x0000000185474810
		public void SetCenterTransform(Transform t, int tid = 0 /* Metadata: 0x01FB9387 */) {} // 0x0000000185474080-0x000000018547417C
		public void SetSkinRoot(Transform t, int tid = 0 /* Metadata: 0x01FB9388 */) {} // 0x00000001854744E0-0x00000001854745E8
		public Transform GetCenterTransform() => default; // 0x000000018546DBA4-0x000000018546DC04
		public void SetCustomSkinningBones(TransformRecord clothTransformRecord, List<TransformRecord> bones) {} // 0x000000018547417C-0x000000018547447C
		public bool CompareSpace(VirtualMesh target) => default; // 0x000000018546C678-0x000000018546C6E0
		public float4x4 CenterTransformTo(VirtualMesh to) => default; // 0x000000018546C418-0x000000018546C514
		public void Mapping(VirtualMesh proxyMesh) {} // 0x000000018546F528-0x00000001854701F8
		private static float4 CalcVertexWeights(float4 distances) => default; // 0x000000018546C21C-0x000000018546C418
		public void Optimization() {} // 0x000000018310C320-0x000000018310C360
		private void RemoveDuplicateTriangles() {} // 0x000000018310CA80-0x000000018310CFA0
		private bool CheckTwoTriangleOpen([IsReadOnly] in int3 tri1, [IsReadOnly] in int3 tri2, [IsReadOnly] in int2 edge, [IsReadOnly] in float3 tri1n) => default; // 0x000000018546C514-0x000000018546C678
		private float CalcTwoTriangleAngle([IsReadOnly] in int3 tri1, [IsReadOnly] in int3 tri2, [IsReadOnly] in int2 edge) => default; // 0x000000018546BFBC-0x000000018546C21C
		public void ConvertProxyMesh(ClothSerializeData sdata, TransformRecord clothTransformRecord, List<TransformRecord> customSkinningBoneRecords, TransformRecord normalAdjustmentTransformRecord) {} // 0x000000018310E630-0x000000018310FC70
		private void ProxyNormalAdjustment(ClothSerializeData sdata, TransformRecord normalAdjustmentTransformRecord) {} // 0x00000001835AE7F0-0x00000001835AE950
		private void ProxyCreateFixedListAndAABB() {} // 0x0000000183555700-0x0000000183555EC0
		private void OptimizeTriangleDirection(NativeArray<float3> triangleNormals, float sameSurfaceAngle) {} // 0x00000001854701F8-0x0000000185470C34
		private void CreateCustomSkinning(CustomSkinningSettings setting, List<TransformRecord> bones) {} // 0x000000018546C6E0-0x000000018546CA94
		public void ApplySelectionAttribute(SelectionData selectionData) {} // 0x0000000183437D20-0x0000000183438D80
		private void CreateMeshBaseLine() {} // 0x000000018546CA94-0x000000018546DA40
		private void CreateTransformBaseLine() {} // 0x0000000182BA2C70-0x0000000182BA5A10
		[BurstCompile]
		public static void DoBaseLine_Bone_CreateBoneChildInfo(int vcnt, NativeArray<int> parentIndices, NativeParallelMultiHashMap<int, ushort> childMap) {} // 0x000000018338C1F0-0x000000018338C270
		private void CreateBaseLinePose() {} // 0x00000001835F4CD0-0x00000001835F4EA0
		private void CreateVertexRootAndDepth() {} // 0x0000000182A795D0-0x0000000182A79AC0
		public void Reduction(ReductionSettings settings, CancellationToken ct) {} // 0x000000018547205C-0x0000000185472E78
		private void InitReductionWorkData(ReductionWorkData workData) {} // 0x000000018546E970-0x000000018546EBB4
		private void Organization(ReductionSettings setting, ReductionWorkData workData) {} // 0x0000000185471944-0x0000000185471A68
		private void OrganizationInit(ReductionSettings setting, ReductionWorkData workData) {} // 0x000000018547145C-0x0000000185471944
		private void OrganizationCreateRemapData(ReductionWorkData workData) {} // 0x000000018547116C-0x000000018547145C
		private void OrganizationCreateBasicData(ReductionWorkData workData) {} // 0x0000000185470C34-0x0000000185470FF8
		private void OrganizationCreateLineTriangle(ReductionWorkData workData) {} // 0x0000000185470FF8-0x000000018547116C
		private void OrganizeStoreVirtualMesh(ReductionWorkData workData) {} // 0x0000000185471A68-0x000000018547205C
		public ShareSerializationData ShareSerialize() => default; // 0x0000000185474A58-0x0000000185475448
		public static VirtualMesh ShareDeserialize(ShareSerializationData sdata) => default; // 0x0000000182E1D3C0-0x0000000182E1DDE0
		public UniqueSerializationData UniqueSerialize() => default; // 0x0000000185475BFC-0x0000000185475D40
		internal void CalcAverageAndMaxVertexDistanceRun() {} // 0x000000018310D0B0-0x000000018310DB10
		internal GridMap<int> CreateVertexIndexGridMapRun(float gridSize) => default; // 0x000000018546DA40-0x000000018546DBA4
		public VirtualMeshRaycastHit IntersectRayMesh(float3 rayPos, float3 rayDir, bool doubleSide, float pointRadius) => default; // 0x000000018546EBB4-0x000000018546F46C
		public void Dispose() {} // 0x0000000182E1F970-0x0000000182E1FFC0
		public void SetName(string newName) {} // 0x000000018547447C-0x00000001854744E0
		public bool IsValid() => default; // 0x000000018546F46C-0x000000018546F528
		public override string ToString() => default; // 0x0000000185475448-0x0000000185475BFC
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
	}

	[Serializable]
	public struct VertexAttribute : IEquatable<VertexAttribute> // TypeDefIndex: 45306
	{
		// Fields
		public const byte Flag_Fixed = 1; // Metadata: 0x01FB9391
		public const byte Flag_Move = 2; // Metadata: 0x01FB9392
		public const byte Flag_InvalidMotion = 8; // Metadata: 0x01FB9393
		public const byte Flag_DisableCollision = 16; // Metadata: 0x01FB9394
		public const byte Flag_Triangle = 128; // Metadata: 0x01FB9395
		public static readonly VertexAttribute Invalid; // 0x00
		public static readonly VertexAttribute Fixed; // 0x01
		public static readonly VertexAttribute Move; // 0x02
		public static readonly VertexAttribute DisableCollision; // 0x03
		public byte Value; // 0x00
	
		// Constructors
		public VertexAttribute(byte initialValue = 0 /* Metadata: 0x01FB9390 */) {
			Value = default;
		} // 0x0000000183D4F9D0-0x0000000183D4F9E0
		static VertexAttribute() {
			Invalid = default;
			Fixed = default;
			Move = default;
			DisableCollision = default;
		} // 0x0000000183D022A0-0x0000000183D02310
	
		// Methods
		public void Clear() {} // 0x0000000183D4F9C0-0x0000000183D4F9D0
		public void SetFlag(byte flag, bool sw) {} // 0x00000001854683F0-0x0000000185468404
		public void SetFlag(VertexAttribute attr, bool sw) {} // 0x00000001854683F0-0x0000000185468404
		public bool IsSet(byte flag) => default; // 0x00000001854683E8-0x00000001854683F0
		public bool IsInvalid() => default; // 0x00000001854B39E4-0x00000001854B3A24
		public bool IsFixed() => default; // 0x00000001854B399C-0x00000001854B39E4
		public bool IsMove() => default; // 0x00000001854B3A64-0x00000001854B3AAC
		public bool IsDontMove() => default; // 0x00000001854B395C-0x00000001854B399C
		public bool IsMotion() => default; // 0x00000001854B3A24-0x00000001854B3A64
		public bool IsDisableCollision() => default; // 0x00000001854B3914-0x00000001854B395C
		public static VertexAttribute JoinAttribute(VertexAttribute attr1, VertexAttribute attr2) => default; // 0x00000001854B3AAC-0x00000001854B3AB8
		public bool Equals(VertexAttribute other) => default; // 0x000000018311BAE0-0x000000018311BAF0
		public override bool Equals(object obj) => default; // 0x00000001854B3824-0x00000001854B38C8
		public override int GetHashCode() => default; // 0x00000001854B38C8-0x00000001854B3914
		public static bool operator ==(VertexAttribute lhs, VertexAttribute rhs) => default; // 0x00000001854B3B60-0x00000001854B3B68
		public static bool operator !=(VertexAttribute lhs, VertexAttribute rhs) => default; // 0x00000001854B3B68-0x00000001854B3B70
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x00000001854B3AB8-0x00000001854B3B14
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001854B3B14-0x00000001854B3B60
	}

	public struct VirtualMeshBoneWeight // TypeDefIndex: 45307
	{
		// Fields
		public float4 weights; // 0x00
		public int4 boneIndices; // 0x10
	
		// Properties
		public bool IsValid { get => default; } // 0x00000001854B3FD0-0x00000001854B3FE0 
		public int Count { get => default; } // 0x00000001854B3F3C-0x00000001854B3FD0 
	
		// Constructors
		public VirtualMeshBoneWeight(int4 boneIndices, float4 weights) : this() {
			this.weights = default;
			this.boneIndices = default;
		} // 0x0000000183D4FB10-0x0000000183D4FB20
	
		// Methods
		[IDTag(0)]
		public void AddWeight(int boneIndex, float weight) {} // 0x00000001854B3C18-0x00000001854B3D6C
		[IDTag(1)]
		public void AddWeight([IsReadOnly] in VirtualMeshBoneWeight bw) {} // 0x00000001854B3B70-0x00000001854B3C18
		public void AdjustWeight() {} // 0x00000001854B3D6C-0x00000001854B3E14
		public override string ToString() => default; // 0x00000001854B3E14-0x00000001854B3EE4
		public string __iFixBaseProxy_ToString() => default; // 0x00000001854B3EE4-0x00000001854B3F3C
	}

	public class VirtualMeshContainer : IDisposable // TypeDefIndex: 45308
	{
		// Fields
		public VirtualMesh shareVirtualMesh; // 0x10
		public VirtualMesh.UniqueSerializationData uniqueData; // 0x18
	
		// Properties
		public bool hasUniqueData { get => default; } // 0x0000000182702DB0-0x0000000182702DC0 
	
		// Constructors
		public VirtualMeshContainer() {} // 0x000000018350B670-0x000000018350B680
		public VirtualMeshContainer(VirtualMesh vmesh) {} // 0x0000000182E1A410-0x0000000182E1A440
	
		// Methods
		public void Dispose() {} // 0x0000000182E20320-0x0000000182E20360
		public int GetTransformCount() => default; // 0x0000000182701800-0x0000000182701870
		public Transform GetTransformFromIndex(int index) => default; // 0x0000000182702D20-0x0000000182702DB0
		public Transform GetCenterTransform() => default; // 0x00000001854B3FE0-0x00000001854B4080
	}

	public enum VirtualMeshPrimitive // TypeDefIndex: 45309
	{
		None = 0,
		Point = 1,
		Edge = 2,
		Triangle = 3
	}

	public struct VirtualMeshRaycastHit : IComparable<VirtualMeshRaycastHit>, IValid // TypeDefIndex: 45310
	{
		// Fields
		public VirtualMeshPrimitive type; // 0x00
		public int index; // 0x04
		public double3 position; // 0x08
		public double distance; // 0x20
		public float3 normal; // 0x28
	
		// Methods
		public int CompareTo(VirtualMeshRaycastHit other) => default; // 0x00000001854B4080-0x00000001854B4120
		public bool IsValid() => default; // 0x00000001854B4120-0x00000001854B4170
		public override string ToString() => default; // 0x00000001854B4170-0x00000001854B4388
		public string __iFixBaseProxy_ToString() => default; // 0x00000001854B4388-0x00000001854B43F4
	}

	public struct VirtualMeshTransform // TypeDefIndex: 45311
	{
		// Fields
		public FixedString32Bytes name; // 0x00
		public int index; // 0x20
		public float4x4 localToWorldMatrix; // 0x24
		public float4x4 worldToLocalMatrix; // 0x64
		public int parentIndex; // 0xA4
	
		// Properties
		public static VirtualMeshTransform Origin { get => default; } // 0x00000001854B4CE0-0x00000001854B4E54 
	
		// Constructors
		public VirtualMeshTransform(Transform t) : this() {
			name = default;
			index = default;
			localToWorldMatrix = default;
			worldToLocalMatrix = default;
			parentIndex = default;
		} // 0x00000001854B4B68-0x00000001854B4CE0
		public VirtualMeshTransform(Transform t, int index) : this() {
			name = default;
			this.index = default;
			localToWorldMatrix = default;
			worldToLocalMatrix = default;
			parentIndex = default;
		} // 0x00000001854B4B40-0x00000001854B4B68
	
		// Methods
		public VirtualMeshTransform Clone() => default; // 0x00000001854B43F4-0x00000001854B4540
		public override int GetHashCode() => default; // 0x00000001854B4540-0x00000001854B4590
		public void Update(Transform t) {} // 0x00000001854B4A04-0x00000001854B4B40
		public float3 TransformPoint(float3 pos) => default; // 0x00000001854B46A4-0x00000001854B4714
		public float3 TransformVector(float3 vec) => default; // 0x00000001854AC63C-0x00000001854AC6EC
		public float3 TransformDirection(float3 dir) => default; // 0x00000001854AC55C-0x00000001854AC63C
		public float3 InverseTransformPoint(float3 pos) => default; // 0x00000001854B4590-0x00000001854B4608
		public float3 InverseTransformVector(float3 vec) => default; // 0x00000001854AC4A8-0x00000001854AC55C
		public float3 InverseTransformDirection(float3 dir) => default; // 0x00000001854AC3C8-0x00000001854AC4A8
		public quaternion InverseTransformRotation(quaternion rot) => default; // 0x00000001854B4608-0x00000001854B46A4
		public VirtualMeshTransform Transform([IsReadOnly] in VirtualMeshTransform to) => default; // 0x00000001854B4714-0x00000001854B4954
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001854B4954-0x00000001854B4A04
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 45314
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D06210-0x0000000183D06280
	
		// Methods
		public void __Gen_Wrap_0(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public bool __Gen_Wrap_1() => default; // 0x000000018514F380-0x000000018514F42C
		public bool __Gen_Wrap_2(object P0, int P1) => default; // 0x000000018548C780-0x000000018548C86C
		public bool __Gen_Wrap_3(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public void __Gen_Wrap_4(object P0, float P1, float P2) {} // 0x00000001854A1120-0x00000001854A1208
		public void __Gen_Wrap_5(object P0, bool P1, float3 P2, quaternion P3) {} // 0x00000001854A8184-0x00000001854A82F0
		public BeyondBoneCloth __Gen_Wrap_6(object P0) => default; // 0x00000001854A8DF4-0x00000001854A8EE4
		public void __Gen_Wrap_7(ref ResultCode P0, Define.Result P1) {} // 0x00000001854A9E8C-0x00000001854A9FD0
		public void __Gen_Wrap_8(ref ResultCode P0) {} // 0x00000001854AAAD8-0x00000001854AAC00
		public void __Gen_Wrap_9(in object P0) {} // 0x00000001854AB8FC-0x00000001854AB9D0
		public ClothSerializeData2 __Gen_Wrap_10(object P0) => default; // 0x00000001854769FC-0x0000000185476AEC
		public void __Gen_Wrap_11(object P0, int P1, bool P2) {} // 0x0000000185477648-0x0000000185477740
		public bool __Gen_Wrap_12(Transform P0) => default; // 0x00000001850EF298-0x00000001850EF354
		public bool __Gen_Wrap_13(Renderer P0) => default; // 0x00000001850EF298-0x00000001850EF354
		public ResultCode __Gen_Wrap_14(object P0) => default; // 0x0000000185478EF0-0x0000000185478FE0
		public bool __Gen_Wrap_15(ref ResultCode P0) => default; // 0x0000000185479B3C-0x0000000185479C74
		public void __Gen_Wrap_16(ref ResultCode P0, ResultCode P1) {} // 0x000000018547B6B0-0x000000018547B808
		public SharePreBuildData __Gen_Wrap_17(object P0) => default; // 0x000000018547D7D8-0x000000018547D8C8
		public float4x4 __Gen_Wrap_18(object P0) => default; // 0x000000018547EBE8-0x000000018547ED0C
		public void __Gen_Wrap_19(ref CullingSettings.CullingParams P0, object P1) {} // 0x000000018547FD94-0x000000018547FEF0
		public float __Gen_Wrap_20(object P0, float P1) => default; // 0x0000000185481690-0x0000000185481780
		public void __Gen_Wrap_21(ref InertiaConstraint.InertiaConstraintParams P0, object P1) {} // 0x0000000185482CF8-0x0000000185482E78
		public void __Gen_Wrap_22(ref TetherConstraint.TetherConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018548428C-0x00000001854843E0
		public void __Gen_Wrap_23(ref DistanceConstraint.DistanceConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018548512C-0x00000001854852D0
		public void __Gen_Wrap_24(ref TriangleBendingConstraint.TriangleBendingConstraintParams P0, object P1) {} // 0x0000000185486D38-0x0000000185486E7C
		public void __Gen_Wrap_25(ref AngleConstraint.AngleConstraintParams P0, object P1, object P2) {} // 0x0000000185487C7C-0x0000000185487E9C
		public void __Gen_Wrap_26(ref MotionConstraint.MotionConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x0000000185488ACC-0x0000000185488CD8
		public void __Gen_Wrap_27(ref ColliderCollisionConstraint.ColliderCollisionConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x0000000185489B80-0x0000000185489D38
		public void __Gen_Wrap_28(ref SelfCollisionConstraint.SelfCollisionConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018548AF00-0x000000018548B0B8
		public void __Gen_Wrap_29(ref WindParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018548C5F8-0x000000018548C780
		public void __Gen_Wrap_30(ref SpringConstraint.SpringConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018548D9AC-0x000000018548DB14
		public ClothParameters __Gen_Wrap_31(object P0) => default; // 0x000000018548EF08-0x000000018548F08C
		public RenderSetupData __Gen_Wrap_32(object P0) => default; // 0x00000001854903E0-0x00000001854904D0
		public BeyondDynamicBone.TransformData __Gen_Wrap_33(object P0) => default; // 0x00000001854913D0-0x00000001854914C0
		public NativeParallelMultiHashMap<int2, ushort> __Gen_Wrap_34(object P0, object P1) => default; // 0x0000000185491C54-0x0000000185491D7C
		public VirtualMesh __Gen_Wrap_35(object P0) => default; // 0x0000000185492C04-0x0000000185492CF4
		public void __Gen_Wrap_36(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public PreBuildManager.ShareDeserializationData __Gen_Wrap_37(object P0, object P1, bool P2) => default; // 0x00000001854955F8-0x0000000185495720
		public void __Gen_Wrap_38(object P0, object P1, object P2, object P3) {} // 0x0000000185496D84-0x0000000185496E8C
		public int __Gen_Wrap_39(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public int __Gen_Wrap_40(object P0, object P1, object P2, object P3) => default; // 0x000000018549883C-0x0000000185498954
		public BeyondDynamicBone.RenderData __Gen_Wrap_41(object P0, int P1) => default; // 0x0000000185499500-0x000000018549960C
		public void __Gen_Wrap_42(object P0, ClothProcess.ClothType P1, object P2, object P3, object P4, RenderSetupData.BoneConnectionMode P5) {} // 0x000000018549A548-0x000000018549A670
		public ref TeamManager.TeamData __Gen_Wrap_43(object P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_43; // 0x000000018549B4D8-0x000000018549B5E4
		private ref TeamManager.TeamData _refReturnTypeFor__Gen_Wrap_43; // Dummy field
		public bool __Gen_Wrap_44(ref TeamManager.TeamData P0) => default; // 0x000000018549C53C-0x000000018549C784
		public void __Gen_Wrap_45(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public void __Gen_Wrap_46(object P0, DataChunk P1, bool P2) {} // 0x000000018549E58C-0x000000018549E6A8
		public bool __Gen_Wrap_47(ClothProcess P0) => default; // 0x00000001850EF298-0x00000001850EF354
		public void __Gen_Wrap_48(object P0, NativeArray<BoneWeight> P1) {} // 0x00000001854A03EC-0x00000001854A0500
		public void __Gen_Wrap_49(object P0, object P1, int P2) {} // 0x00000001854A1028-0x00000001854A1120
		public PreBuildManager.ShareDeserializationData __Gen_Wrap_50(object P0, object P1) => default; // 0x00000001854A229C-0x00000001854A2394
		public int __Gen_Wrap_51(object P0, object P1) => default; // 0x0000000185152714-0x0000000185152800
		public void __Gen_Wrap_52(object P0, int P1, object P2) {} // 0x000000018514F720-0x000000018514F818
		public int __Gen_Wrap_53(object P0, object P1, ClothParameters P2) => default; // 0x00000001854A5104-0x00000001854A52B4
		public int __Gen_Wrap_54(object P0, object P1, in ClothParameters P2) => default; // 0x00000001854A6158-0x00000001854A631C
		public Transform __Gen_Wrap_55(object P0, int P1) => default; // 0x00000001854A7114-0x00000001854A7220
		public DataChunk __Gen_Wrap_56(object P0, object P1, int P2) => default; // 0x00000001854A7CEC-0x00000001854A7E10
		public DataChunk __Gen_Wrap_57(object P0, int P1, int P2) => default; // 0x00000001854A7E10-0x00000001854A7F34
		public Vector3 __Gen_Wrap_58(object P0) => default; // 0x00000001854A7F34-0x00000001854A8048
		public void __Gen_Wrap_59(object P0, object P1, ExBitFlag8 P2, int P3, int P4) {} // 0x00000001854A8048-0x00000001854A8184
		public void __Gen_Wrap_60(object P0, object P1, object P2, int P3, int P4, int P5) {} // 0x00000001854A82F0-0x00000001854A8414
		public ref ClothParameters __Gen_Wrap_61(object P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_61; // 0x00000001854A8414-0x00000001854A8520
		private ref ClothParameters _refReturnTypeFor__Gen_Wrap_61; // Dummy field
		public void __Gen_Wrap_62(object P0, int P1, TeamManager.TeamData P2, uint P3, int P4, int P5, int P6) {} // 0x00000001854A8520-0x00000001854A871C
		public void __Gen_Wrap_63(ref DataChunk P0) {} // 0x00000001854A871C-0x00000001854A8844
		public ref FixedList64Bytes<short> __Gen_Wrap_64(object P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_64; // 0x00000001854A8844-0x00000001854A8950
		private ref FixedList64Bytes<short> _refReturnTypeFor__Gen_Wrap_64; // Dummy field
		public Transform __Gen_Wrap_65(object P0) => default; // 0x00000001854A8950-0x00000001854A8A40
		public DataChunk __Gen_Wrap_66(object P0, object P1, ExBitFlag8 P2, int P3) => default; // 0x00000001854A8A40-0x00000001854A8B88
		public DataChunk __Gen_Wrap_67(object P0, int P1, object P2) => default; // 0x00000001854A8B88-0x00000001854A8CAC
		public void __Gen_Wrap_68(VirtualMeshContainer P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public string __Gen_Wrap_69(ref ResultCode P0) => default; // 0x00000001854A8CAC-0x00000001854A8DF4
		public NativeParallelMultiHashMap<int, ushort> __Gen_Wrap_70(in NativeArray<uint> P0, in NativeArray<ushort> P1) => default; // 0x00000001854A8EE4-0x00000001854A9078
		public int __Gen_Wrap_71(int3 P0, int2 P1) => default; // 0x00000001854A9078-0x00000001854A91C0
		public DistanceConstraint.ConstraintData __Gen_Wrap_72(object P0, in ClothParameters P1) => default; // 0x00000001854A91C0-0x00000001854A9378
		public int2 __Gen_Wrap_73(int3 P0, int3 P1, int2 P2) => default; // 0x00000001854A9378-0x00000001854A9500
		public void __Gen_Wrap_74(object P0, int P1, int P2, int P3, int P4, out float P5, out sbyte P6) {
			P5 = default;
			P6 = default;
		} // 0x00000001854A9500-0x00000001854A9680
		public int4 __Gen_Wrap_75(int P0, int P1, int P2, int P3) => default; // 0x00000001854A9680-0x00000001854A97C4
		public int4 __Gen_Wrap_76(int4 P0) => default; // 0x00000001854A97C4-0x00000001854A98F4
		public TriangleBendingConstraint.ConstraintData __Gen_Wrap_77(object P0, in ClothParameters P1) => default; // 0x00000001854A98F4-0x00000001854A9AAC
		public void __Gen_Wrap_78(ref InertiaConstraint.CenterData P0) {} // 0x00000001854A9AAC-0x00000001854A9CD4
		public InertiaConstraint.ConstraintData __Gen_Wrap_79(object P0, in ClothParameters P1) => default; // 0x00000001854A9CD4-0x00000001854A9E8C
		public int __Gen_Wrap_80(object P0, object P1, int P2, byte P3, bool P4) => default; // 0x00000001854A9FD0-0x00000001854AA0F4
		public void __Gen_Wrap_81(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public string __Gen_Wrap_82(object P0) => default; // 0x00000001854AA0F4-0x00000001854AA1E4
		public int[] __Gen_Wrap_83(object P0, object P1, object P2, object P3, object P4, NativeArray<float3> P5, NativeArray<quaternion> P6, NativeArray<float3> P7, NativeArray<quaternion> P8, NativeArray<float3> P9, NativeArray<quaternion> P10) => default; // 0x00000001854AA1E4-0x00000001854AA458
		public void __Gen_Wrap_84(NativeArray<int> P0, int P1) {} // 0x00000001854AA458-0x00000001854AA56C
		public void __Gen_Wrap_85(NativeArray<VirtualMeshBoneWeight> P0, int P1, VirtualMeshBoneWeight P2) {} // 0x00000001854AA56C-0x00000001854AA6C4
		public int __Gen_Wrap_86(object P0, int P1, bool P2) => default; // 0x0000000185156024-0x0000000185156128
		public int3 __Gen_Wrap_87(int P0, int P1, int P2) => default; // 0x00000001854AA6C4-0x00000001854AA800
		public void __Gen_Wrap_88(NativeArray<float3> P0, int P1, NativeReference<AABB> P2) {} // 0x00000001854AA800-0x00000001854AA950
		public void __Gen_Wrap_89(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, NativeArray<float2> P3) {} // 0x00000001854AA950-0x00000001854AAAD8
		public void __Gen_Wrap_90(NativeArray<float3> P0, NativeArray<float3> P1, int P2, in float4x4 P3) {} // 0x00000001854AAC00-0x00000001854AADA4
		public ResultCode __Gen_Wrap_91(object P0, object P1, object P2, object P3, out SelectionData P4) {
			P4 = default;
			return default;
		} // 0x00000001854AADA4-0x00000001854AAF28
		public float __Gen_Wrap_92(ref AABB P0) => default; // 0x00000001854AAF28-0x00000001854AB08C
		public float __Gen_Wrap_93(object P0) => default; // 0x00000001854AB08C-0x00000001854AB15C
		public float __Gen_Wrap_94(object P0, object P1) => default; // 0x00000001854AB15C-0x00000001854AB248
		public NativeArray<float3> __Gen_Wrap_95(object P0) => default; // 0x00000001854AB248-0x00000001854AB354
		public NativeArray<VertexAttribute> __Gen_Wrap_96(object P0) => default; // 0x00000001854AB354-0x00000001854AB460
		public void __Gen_Wrap_97(NativeArray<float3> P0, int P1, in float4x4 P2) {} // 0x00000001854AB460-0x00000001854AB5D8
		public GridMap<int> __Gen_Wrap_98(float P0, in NativeArray<float3> P1, in NativeArray<VertexAttribute> P2, bool P3, bool P4, bool P5, bool P6) => default; // 0x00000001854AB5D8-0x00000001854AB7A8
		public void __Gen_Wrap_99(object P0, object P1, float4x4 P2, float P3) {} // 0x00000001854AB7A8-0x00000001854AB8FC
		public bool __Gen_Wrap_100(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
		public float4x4 __Gen_Wrap_101(object P0, object P1) => default; // 0x0000000185475E48-0x0000000185475F88
		public int __Gen_Wrap_102(object P0, object P1, int P2, bool P3) => default; // 0x0000000185475F88-0x000000018547609C
		public void __Gen_Wrap_103(object P0, VertexAttribute P1) {} // 0x000000018547609C-0x00000001854761A8
		public int __Gen_Wrap_104(object P0, int P1) => default; // 0x00000001854761A8-0x0000000185476294
		public void __Gen_Wrap_105(NativeArray<int> P0, int P1, int P2) {} // 0x0000000185476294-0x00000001854763C0
		public void __Gen_Wrap_106(object P0, object P1, CancellationToken P2) {} // 0x00000001854763C0-0x00000001854764DC
		public void __Gen_Wrap_107(NativeArray<quaternion> P0, int P1, quaternion P2) {} // 0x00000001854764DC-0x000000018547662C
		public float __Gen_Wrap_108(object P0, in int3 P1, in int3 P2, in int2 P3) => default; // 0x000000018547662C-0x00000001854767EC
		public bool __Gen_Wrap_109(object P0, in int3 P1, in int3 P2, in int2 P3, in float3 P4) => default; // 0x00000001854767EC-0x00000001854769FC
		public void __Gen_Wrap_110(object P0, NativeArray<float3> P1, float P2) {} // 0x0000000185476AEC-0x0000000185476C1C
		public double3 __Gen_Wrap_111(ref AABB P0) => default; // 0x0000000185476C1C-0x0000000185476DB4
		public void __Gen_Wrap_112(object P0, object P1, object P2, object P3, object P4) {} // 0x0000000185476DB4-0x0000000185476ECC
		public GridMap<int> __Gen_Wrap_113(object P0, float P1) => default; // 0x0000000185476ECC-0x0000000185476FDC
		public ResultCode __Gen_Wrap_114(object P0, object P1) => default; // 0x0000000185476FDC-0x00000001854770E8
		public SelectionData __Gen_Wrap_115(object P0) => default; // 0x00000001854770E8-0x00000001854771D8
		public void __Gen_Wrap_116() {} // 0x00000001850F3444-0x00000001850F34E0
		public void __Gen_Wrap_117(object P0, DataChunk P1) {} // 0x00000001854771D8-0x00000001854772E8
		public void __Gen_Wrap_118(object P0, int P1, int P2) {} // 0x00000001854772E8-0x00000001854773E0
		public void __Gen_Wrap_119(object P0, ref TeamManager.TeamData P1, int P2) {} // 0x00000001854773E0-0x0000000185477648
		public System.Threading.Tasks.Task __Gen_Wrap_120(object P0, CancellationToken P1) => default; // 0x0000000185477740-0x0000000185477860
		public void __Gen_Wrap_121(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public void __Gen_Wrap_122(Transform P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public void __Gen_Wrap_123(RenderSetupData.UniqueSerializationData P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public void __Gen_Wrap_124(VirtualMesh.UniqueSerializationData P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public void __Gen_Wrap_125(int P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public void __Gen_Wrap_126(TransformRecord P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public void __Gen_Wrap_127(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public ref InertiaConstraint.CenterData __Gen_Wrap_128(object P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_128; // 0x000000018547793C-0x0000000185477A34
		private ref InertiaConstraint.CenterData _refReturnTypeFor__Gen_Wrap_128; // Dummy field
		public void __Gen_Wrap_129(object P0, Vector3 P1, float P2, ClothForceMode P3) {} // 0x0000000185477A34-0x0000000185477B68
		public void __Gen_Wrap_130(object P0, bool P1, float P2) {} // 0x0000000185477B68-0x0000000185477C4C
		public CheckSliderSerializeData __Gen_Wrap_131(object P0) => default; // 0x0000000185477C4C-0x0000000185477D3C
		public BitField32 __Gen_Wrap_132(object P0) => default; // 0x0000000185477D3C-0x0000000185477E18
		public ClothProcess.RenderMeshInfo __Gen_Wrap_133(object P0, int P1) => default; // 0x0000000185477E18-0x0000000185477F10
		public ClothUpdateMode __Gen_Wrap_134(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public void __Gen_Wrap_135(ref ClothProcess.GenerateSelectionJob P0, int P1) {} // 0x0000000185477FCC-0x00000001854781D0
		public ReductionSettings __Gen_Wrap_136(object P0) => default; // 0x00000001854781D0-0x00000001854782C0
		public CustomSkinningSettings __Gen_Wrap_137(object P0) => default; // 0x00000001854782C0-0x00000001854783B0
		public NormalAlignmentSettings __Gen_Wrap_138(object P0) => default; // 0x00000001854783B0-0x00000001854784A0
		public CullingSettings __Gen_Wrap_139(object P0) => default; // 0x00000001854784A0-0x0000000185478590
		public CurveSerializeData __Gen_Wrap_140(object P0) => default; // 0x0000000185478590-0x0000000185478680
		public InertiaConstraint.SerializeData __Gen_Wrap_141(object P0) => default; // 0x0000000185478680-0x0000000185478770
		public TetherConstraint.SerializeData __Gen_Wrap_142(object P0) => default; // 0x0000000185478770-0x0000000185478860
		public DistanceConstraint.SerializeData __Gen_Wrap_143(object P0) => default; // 0x0000000185478860-0x0000000185478950
		public TriangleBendingConstraint.SerializeData __Gen_Wrap_144(object P0) => default; // 0x0000000185478950-0x0000000185478A40
		public AngleConstraint.RestorationSerializeData __Gen_Wrap_145(object P0) => default; // 0x0000000185478A40-0x0000000185478B30
		public AngleConstraint.LimitSerializeData __Gen_Wrap_146(object P0) => default; // 0x0000000185478B30-0x0000000185478C20
		public MotionConstraint.SerializeData __Gen_Wrap_147(object P0) => default; // 0x0000000185478C20-0x0000000185478D10
		public ColliderCollisionConstraint.SerializeData __Gen_Wrap_148(object P0) => default; // 0x0000000185478D10-0x0000000185478E00
		public SelfCollisionConstraint.SerializeData __Gen_Wrap_149(object P0) => default; // 0x0000000185478E00-0x0000000185478EF0
		public WindSettings __Gen_Wrap_150(object P0) => default; // 0x0000000185478FE0-0x00000001854790D0
		public void __Gen_Wrap_151(object P0, object P1, bool P2) {} // 0x00000001854790D0-0x00000001854791C8
		public ColliderManager.ColliderType __Gen_Wrap_152(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public void __Gen_Wrap_153(object P0, Vector3 P1) {} // 0x00000001854791C8-0x00000001854792E4
		public void __Gen_Wrap_154(object P0, float P1, float P2, float P3) {} // 0x00000001854792E4-0x00000001854793E0
		public ClothProcess __Gen_Wrap_155(object P0, int P1) => default; // 0x00000001854793E0-0x00000001854794D8
		public void __Gen_Wrap_156(object P0, object P1, int P2, bool P3) {} // 0x00000001854794D8-0x00000001854795D0
		public JobHandle __Gen_Wrap_157(object P0, JobHandle P1) => default; // 0x00000001854795D0-0x000000018547970C
		public void __Gen_Wrap_158(ref AngleConstraint.AngleConstraintJob P0, NativeReference<int> P1) {} // 0x000000018547970C-0x000000018547996C
		public bool __Gen_Wrap_159(in double3 P0, in double3 P1, double P2, out double3 P3) {
			P3 = default;
			return default;
		} // 0x000000018547996C-0x0000000185479B3C
		public quaternion __Gen_Wrap_160(in double3 P0, in double3 P1, double P2) => default; // 0x0000000185479C74-0x0000000185479E10
		public void __Gen_Wrap_161(ref AngleConstraint.AngleConstraintJob P0, int P1) {} // 0x0000000185479E10-0x000000018547A048
		public void __Gen_Wrap_162(ref AngleConstraint.AngleConstraintJob P0) {} // 0x000000018547A048-0x000000018547A26C
		public double __Gen_Wrap_163(ref double3 P0, in double3 P1, float P2, in AABB P3, in ColliderManager.WorkData P4, bool P5, float P6, out float3 P7) {
			P7 = default;
			return default;
		} // 0x000000018547A26C-0x000000018547A5BC
		public double __Gen_Wrap_164(ref double3 P0, float P1, in ColliderManager.WorkData P2, out float3 P3) {
			P3 = default;
			return default;
		} // 0x000000018547A5BC-0x000000018547A840
		public double __Gen_Wrap_165(ref double3 P0, float P1, in AABB P2, in ColliderManager.WorkData P3, out float3 P4) {
			P4 = default;
			return default;
		} // 0x000000018547A840-0x000000018547AB20
		public float __Gen_Wrap_166(ref double3x2 P0, in double2 P1, in AABB P2, double P3, in ColliderManager.WorkData P4, out float3 P5) {
			P5 = default;
			return default;
		} // 0x000000018547AB20-0x000000018547AE58
		public double __Gen_Wrap_167(ref double3x2 P0, in double2 P1, in AABB P2, double P3, in ColliderManager.WorkData P4, out float3 P5) {
			P5 = default;
			return default;
		} // 0x000000018547AE58-0x000000018547B190
		public double __Gen_Wrap_168(ref double3x2 P0, in double2 P1, in ColliderManager.WorkData P2, out float3 P3) {
			P3 = default;
			return default;
		} // 0x000000018547B190-0x000000018547B458
		public void __Gen_Wrap_169(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, NativeReference<int> P1) {} // 0x000000018547B458-0x000000018547B6B0
		public double __Gen_Wrap_170(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, in double3 P2, double P3, in AABB P4, in ColliderManager.WorkData P5, bool P6, double P7, out float3 P8) {
			P8 = default;
			return default;
		} // 0x000000018547B808-0x000000018547BCBC
		public double __Gen_Wrap_171(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, double P2, in AABB P3, in ColliderManager.WorkData P4, out float3 P5) {
			P5 = default;
			return default;
		} // 0x000000018547BCBC-0x000000018547C104
		public double __Gen_Wrap_172(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, double P2, in ColliderManager.WorkData P3, out float3 P4) {
			P4 = default;
			return default;
		} // 0x000000018547C104-0x000000018547C4EC
		public void __Gen_Wrap_173(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, int P1) {} // 0x000000018547C4EC-0x000000018547C720
		public void __Gen_Wrap_174(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0) {} // 0x000000018547C720-0x000000018547C938
		public void __Gen_Wrap_175(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, NativeReference<int> P1) {} // 0x000000018547C938-0x000000018547CB68
		public double __Gen_Wrap_176(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, ref double3x2 P1, in double2 P2, in AABB P3, float P4, in ColliderManager.WorkData P5, out float3 P6) {
			P6 = default;
			return default;
		} // 0x000000018547CB68-0x000000018547CFDC
		public double __Gen_Wrap_177(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, ref double3x2 P1, in double2 P2, in ColliderManager.WorkData P3, out float3 P4) {
			P4 = default;
			return default;
		} // 0x000000018547CFDC-0x000000018547D3DC
		public void __Gen_Wrap_178(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, int P1) {} // 0x000000018547D3DC-0x000000018547D5E4
		public void __Gen_Wrap_179(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0) {} // 0x000000018547D5E4-0x000000018547D7D8
		public void __Gen_Wrap_180(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0, NativeReference<int> P1) {} // 0x000000018547D8C8-0x000000018547DAE8
		public float3 __Gen_Wrap_181(int P0, in NativeArray<int> P1, in NativeArray<int> P2) => default; // 0x000000018547DAE8-0x000000018547DC78
		public float __Gen_Wrap_182(int P0, in NativeArray<int> P1) => default; // 0x000000018547DC78-0x000000018547DD98
		public float3 __Gen_Wrap_183(int P0, in NativeArray<int> P1) => default; // 0x000000018547DD98-0x000000018547DEF0
		public void __Gen_Wrap_184(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0, int P1) {} // 0x000000018547DEF0-0x000000018547E0E8
		public void __Gen_Wrap_185(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0) {} // 0x000000018547E0E8-0x000000018547E2C8
		public void __Gen_Wrap_186(ref DistanceConstraint.DistanceConstraintJob P0, NativeReference<int> P1) {} // 0x000000018547E2C8-0x000000018547E534
		public void __Gen_Wrap_187(ref DistanceConstraint.DistanceConstraintJob P0, int P1) {} // 0x000000018547E534-0x000000018547E778
		public void __Gen_Wrap_188(ref DistanceConstraint.DistanceConstraintJob P0) {} // 0x000000018547E778-0x000000018547E9A0
		public void __Gen_Wrap_189(ref MotionConstraint.MotionConstraintJob P0, NativeReference<int> P1) {} // 0x000000018547E9A0-0x000000018547EBE8
		public void __Gen_Wrap_190(ref MotionConstraint.MotionConstraintJob P0, int P1) {} // 0x000000018547ED0C-0x000000018547EF30
		public void __Gen_Wrap_191(ref MotionConstraint.MotionConstraintJob P0) {} // 0x000000018547EF30-0x000000018547F138
		public int __Gen_Wrap_192(ref NativeArray<SelfCollisionConstraint.SortData> P0, in SelfCollisionConstraint.SortData P1, in DataChunk P2) => default; // 0x000000018547F138-0x000000018547F314
		public JobHandle __Gen_Wrap_193(in NativeArray<int> P0, in NativeReference<int> P1, float P2, JobHandle P3) => default; // 0x000000018547F314-0x000000018547F4E0
		public JobHandle __Gen_Wrap_194(in ExProcessingList<int> P0, float P1, JobHandle P2) => default; // 0x000000018547F4E0-0x000000018547F644
		public JobHandle __Gen_Wrap_195(object P0, int P1, JobHandle P2) => default; // 0x000000018547F644-0x000000018547F790
		public JobHandle __Gen_Wrap_196(NativeArray<byte> P0, int P1, byte P2, JobHandle P3) => default; // 0x000000018547F790-0x000000018547F914
		public int __Gen_Wrap_197(ref SelfCollisionConstraint.SortData P0, SelfCollisionConstraint.SortData P1) => default; // 0x000000018547F914-0x000000018547FAC4
		public string __Gen_Wrap_198(ref SelfCollisionConstraint.EdgeEdgeContact P0) => default; // 0x000000018547FAC4-0x000000018547FC38
		public string __Gen_Wrap_199(ref SelfCollisionConstraint.PointTriangleContact P0) => default; // 0x000000018547FC38-0x000000018547FD94
		public void __Gen_Wrap_200(ref SelfCollisionConstraint.InitPrimitiveJob P0, int P1) {} // 0x000000018547FEF0-0x0000000185480108
		public void __Gen_Wrap_201(ref SelfCollisionConstraint.ClearBufferJob P0) {} // 0x0000000185480108-0x0000000185480248
		public void __Gen_Wrap_202(ref SelfCollisionConstraint.UpdatePrimitiveJob P0, NativeReference<int> P1) {} // 0x0000000185480248-0x0000000185480480
		public void __Gen_Wrap_203(ref SelfCollisionConstraint.UpdatePrimitiveJob P0, int P1) {} // 0x0000000185480480-0x0000000185480694
		public void __Gen_Wrap_204(ref SelfCollisionConstraint.UpdatePrimitiveJob P0) {} // 0x0000000185480694-0x000000018548088C
		public void __Gen_Wrap_205(ref SelfCollisionConstraint.SortJob P0, int P1) {} // 0x000000018548088C-0x00000001854809FC
		public void __Gen_Wrap_206(ref SelfCollisionConstraint.SortJob P0) {} // 0x00000001854809FC-0x0000000185480B50
		public void __Gen_Wrap_207(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, NativeReference<int> P1) {} // 0x0000000185480B50-0x0000000185480D98
		public void __Gen_Wrap_208(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2, float P3, float P4, float P5) {} // 0x0000000185480D98-0x000000018548125C
		public void __Gen_Wrap_209(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, int P1, ref SelfCollisionConstraint.Primitive P2, in SelfCollisionConstraint.SortData P3, in DataChunk P4, bool P5) {} // 0x000000018548125C-0x0000000185481690
		public void __Gen_Wrap_210(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, int P1) {} // 0x0000000185481780-0x00000001854819A4
		public void __Gen_Wrap_211(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0) {} // 0x00000001854819A4-0x0000000185481BAC
		public void __Gen_Wrap_212(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, NativeReference<int> P1) {} // 0x0000000185481BAC-0x0000000185481D90
		public void __Gen_Wrap_213(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2, float P3, float P4) {} // 0x0000000185481D90-0x00000001854821E4
		public void __Gen_Wrap_214(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, int P1, ref SelfCollisionConstraint.Primitive P2, in SelfCollisionConstraint.SortData P3, in DataChunk P4, bool P5) {} // 0x00000001854821E4-0x00000001854825B0
		public void __Gen_Wrap_215(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, int P1) {} // 0x00000001854825B0-0x0000000185482770
		public void __Gen_Wrap_216(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0) {} // 0x0000000185482770-0x0000000185482914
		public void __Gen_Wrap_217(ref SelfCollisionConstraint.EdgeEdgeToListJob P0) {} // 0x0000000185482914-0x0000000185482A58
		public void __Gen_Wrap_218(ref SelfCollisionConstraint.PointTriangleToListJob P0) {} // 0x0000000185482A58-0x0000000185482B9C
		public void __Gen_Wrap_219(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseJob P0, int P1) {} // 0x0000000185482B9C-0x0000000185482CF8
		public void __Gen_Wrap_220(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseJob P0, int P1) {} // 0x0000000185482E78-0x0000000185482FD4
		public void __Gen_Wrap_221(ref SelfCollisionConstraint.SolverEdgeEdgeJob P0, int P1) {} // 0x0000000185482FD4-0x0000000185483140
		public void __Gen_Wrap_222(ref SelfCollisionConstraint.SolverPointTriangleJob P0, int P1) {} // 0x0000000185483140-0x00000001854832AC
		public void __Gen_Wrap_223(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0, NativeReference<int> P1) {} // 0x00000001854832AC-0x0000000185483460
		public void __Gen_Wrap_224(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0, int P1) {} // 0x0000000185483460-0x00000001854835F0
		public void __Gen_Wrap_225(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0) {} // 0x00000001854835F0-0x0000000185483764
		public void __Gen_Wrap_226(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, NativeReference<int> P1) {} // 0x0000000185483764-0x0000000185483934
		public void __Gen_Wrap_227(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2) {} // 0x0000000185483934-0x0000000185483D48
		public void __Gen_Wrap_228(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, ref SelfCollisionConstraint.Primitive P1, in SelfCollisionConstraint.SortData P2, in DataChunk P3, bool P4) {} // 0x0000000185483D48-0x00000001854840F0
		public void __Gen_Wrap_229(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, int P1) {} // 0x00000001854840F0-0x000000018548428C
		public void __Gen_Wrap_230(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0) {} // 0x00000001854843E0-0x0000000185484560
		public void __Gen_Wrap_231(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob P0, int P1) {} // 0x0000000185484560-0x00000001854846CC
		public void __Gen_Wrap_232(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob P0) {} // 0x00000001854846CC-0x000000018548481C
		public void __Gen_Wrap_233(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob P0, int P1) {} // 0x000000018548481C-0x0000000185484988
		public void __Gen_Wrap_234(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob P0) {} // 0x0000000185484988-0x0000000185484AD8
		public void __Gen_Wrap_235(ref SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob P0, int P1) {} // 0x0000000185484AD8-0x0000000185484C44
		public void __Gen_Wrap_236(ref SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob P0) {} // 0x0000000185484C44-0x0000000185484D94
		public void __Gen_Wrap_237(ref SelfCollisionConstraint.SolverPointTriangleCrossFrameJob P0, int P1) {} // 0x0000000185484D94-0x0000000185484F00
		public void __Gen_Wrap_238(ref SelfCollisionConstraint.SolverPointTriangleCrossFrameJob P0) {} // 0x0000000185484F00-0x0000000185485050
		public SpringConstraint.SerializeData __Gen_Wrap_239(object P0) => default; // 0x0000000185485050-0x000000018548512C
		public void __Gen_Wrap_240(ref TetherConstraint.TethreConstraintJob P0, NativeReference<int> P1) {} // 0x00000001854852D0-0x0000000185485518
		public void __Gen_Wrap_241(ref TetherConstraint.TethreConstraintJob P0, int P1) {} // 0x0000000185485518-0x000000018548573C
		public void __Gen_Wrap_242(ref TetherConstraint.TethreConstraintJob P0) {} // 0x000000018548573C-0x0000000185485944
		public bool __Gen_Wrap_243(in double3x4 P0, in double4 P1, double P2, double P3, ref double3x4 P4) => default; // 0x0000000185485944-0x0000000185485BC4
		public bool __Gen_Wrap_244(double P0, in double3x4 P1, in double4 P2, double P3, double P4, ref double3x4 P5) => default; // 0x0000000185485BC4-0x0000000185485E5C
		public void __Gen_Wrap_245(ref TriangleBendingConstraint.TriangleBendingJob P0, NativeReference<int> P1) {} // 0x0000000185485E5C-0x00000001854860C8
		public bool __Gen_Wrap_246(ref TriangleBendingConstraint.TriangleBendingJob P0, in double3x4 P1, in double4 P2, double P3, double P4, ref double3x4 P5) => default; // 0x00000001854860C8-0x00000001854864BC
		public bool __Gen_Wrap_247(ref TriangleBendingConstraint.TriangleBendingJob P0, double P1, in double3x4 P2, in double4 P3, double P4, double P5, ref double3x4 P6) => default; // 0x00000001854864BC-0x00000001854868CC
		public void __Gen_Wrap_248(ref TriangleBendingConstraint.TriangleBendingJob P0, int P1) {} // 0x00000001854868CC-0x0000000185486B10
		public void __Gen_Wrap_249(ref TriangleBendingConstraint.TriangleBendingJob P0) {} // 0x0000000185486B10-0x0000000185486D38
		public void __Gen_Wrap_250(ref TriangleBendingConstraint.SolveAggregateBufferJob P0, NativeReference<int> P1) {} // 0x0000000185486E7C-0x000000018548705C
		public void __Gen_Wrap_251(ref TriangleBendingConstraint.SolveAggregateBufferJob P0, int P1) {} // 0x000000018548705C-0x0000000185487218
		public void __Gen_Wrap_252(ref TriangleBendingConstraint.SolveAggregateBufferJob P0) {} // 0x0000000185487218-0x00000001854873B8
		public void __Gen_Wrap_253(object P0, float P1, float P2, float P3, bool P4) {} // 0x00000001854873B8-0x00000001854874C8
		public void __Gen_Wrap_254(object P0, float P1, object P2) {} // 0x00000001854874C8-0x00000001854875AC
		public NativeArray<float3> __Gen_Wrap_255(object P0, float4x4 P1) => default; // 0x00000001854875AC-0x0000000185487700
		public void __Gen_Wrap_256(ref SelectionData.TransformPositionJob P0, int P1) {} // 0x0000000185487700-0x000000018548787C
		public void __Gen_Wrap_257(ref SelectionData.CreateGridMapJob P0) {} // 0x000000018548787C-0x00000001854879CC
		public void __Gen_Wrap_258(ref SelectionData.ConvertSelectionJob P0, int P1) {} // 0x00000001854879CC-0x0000000185487B5C
		public Vector3 __Gen_Wrap_259(object P0, bool P1) => default; // 0x0000000185487B5C-0x0000000185487C7C
		public void __Gen_Wrap_260(object P0, Vector3 P1, bool P2) {} // 0x0000000185487E9C-0x0000000185487FC0
		public bool __Gen_Wrap_261(ref WindParams P0) => default; // 0x0000000185487FC0-0x0000000185488110
		public bool __Gen_Wrap_262(object P0, object P1, object P2) => default; // 0x0000000185488110-0x0000000185488204
		public bool __Gen_Wrap_263(object P0, object P1, int P2, int P3) => default; // 0x0000000185488204-0x000000018548830C
		public void __Gen_Wrap_264(object P0, object P1, TransformAccessArray P2) {} // 0x000000018548830C-0x0000000185488428
		public DataChunk __Gen_Wrap_265(object P0, DataChunk P1, int P2) => default; // 0x0000000185488428-0x0000000185488550
		public float __Gen_Wrap_266() => default; // 0x00000001850F18D0-0x00000001850F1968
		public JobHandle __Gen_Wrap_267(object P0, JobHandle P1, ref NativeParallelHashMap<int, int> P2, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> P3, ref NativeParallelHashMap<int, int> P4) => default; // 0x0000000185488550-0x00000001854887E0
		public void __Gen_Wrap_268(ref DynamicBoneTransformManager.ValidTransformJob P0, int P1) {} // 0x00000001854887E0-0x0000000185488970
		public JobHandle __Gen_Wrap_269(object P0, int P1, int P2, JobHandle P3) => default; // 0x0000000185488970-0x0000000185488ACC
		public JobHandle __Gen_Wrap_270(object P0, bool P1, DataChunk P2, JobHandle P3) => default; // 0x0000000185488CD8-0x0000000185488E50
		public JobHandle __Gen_Wrap_271(object P0, DataChunk P1, JobHandle P2) => default; // 0x0000000185488E50-0x0000000185488FB4
		public VirtualMeshContainer __Gen_Wrap_272(object P0) => default; // 0x0000000185488FB4-0x0000000185489090
		public VirtualMeshContainer __Gen_Wrap_273(object P0, int P1) => default; // 0x0000000185489090-0x0000000185489188
		public void __Gen_Wrap_274(ref DoAllInOneJob P0) {} // 0x0000000185489188-0x00000001854892C8
		public void __Gen_Wrap_275(ref DynamicBoneTransformManager.ReadAnimatorBufferDataJob P0, int P1, TransformAccess P2) {} // 0x00000001854892C8-0x0000000185489514
		public void __Gen_Wrap_276(ref DynamicBoneTransformManager.WriteAnimatorBufferDataJob P0) {} // 0x0000000185489514-0x00000001854896F4
		public void __Gen_Wrap_277(ref DynamicBoneTransformManager.CopyDoubleBufferJob P0) {} // 0x00000001854896F4-0x0000000185489894
		public void __Gen_Wrap_278(ref DynamicBoneTransformManager.EnableTransformJob P0) {} // 0x0000000185489894-0x00000001854899C4
		public void __Gen_Wrap_279(ref DynamicBoneTransformManager.RestoreTransformJob P0, int P1, TransformAccess P2) {} // 0x00000001854899C4-0x0000000185489B80
		public void __Gen_Wrap_280(ref DynamicBoneTransformManager.ReadTransformJob P0, int P1, TransformAccess P2) {} // 0x0000000185489D38-0x0000000185489F58
		public void __Gen_Wrap_281(ref DynamicBoneTransformManager.ValidTransformJob P0) {} // 0x0000000185489F58-0x000000018548A0CC
		public void __Gen_Wrap_282(ref DynamicBoneTransformManager.WriteTransformJob P0, int P1, TransformAccess P2) {} // 0x000000018548A0CC-0x000000018548A2B8
		public void __Gen_Wrap_283(ref DynamicBoneTransformManager.ReadComponentTransformJob P0, int P1, TransformAccess P2) {} // 0x000000018548A2B8-0x000000018548A434
		public void __Gen_Wrap_284(ClothProcess P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public string __Gen_Wrap_285(ref TeamWindInfo P0) => default; // 0x000000018548A434-0x000000018548A588
		public bool __Gen_Wrap_286(ref TeamManager.MappingData P0) => default; // 0x000000018548A588-0x000000018548A770
		public void __Gen_Wrap_287(ref TeamManager.AlwaysTeamUpdatePreJob P0) {} // 0x000000018548A770-0x000000018548A910
		public void __Gen_Wrap_288(ref TeamManager.AlwaysTeamUpdatePostJob P0, int P1, ref TeamManager.TeamData P2) {} // 0x000000018548A910-0x000000018548ACC8
		public void __Gen_Wrap_289(ref TeamManager.AlwaysTeamUpdatePostJob P0) {} // 0x000000018548ACC8-0x000000018548AF00
		public void __Gen_Wrap_290(ref TeamManager.CalcCenterAndInertiaAndWindJob P0, int P1) {} // 0x000000018548B0B8-0x000000018548B2EC
		public double3 __Gen_Wrap_291(in double3 P0, in double3 P1, in double3 P2, in quaternion P3) => default; // 0x000000018548B2EC-0x000000018548B508
		public bool __Gen_Wrap_292(ref WindManager.WindData P0) => default; // 0x000000018548B508-0x000000018548B72C
		public bool __Gen_Wrap_293(ref TeamWindInfo P0) => default; // 0x000000018548B72C-0x000000018548B870
		public int __Gen_Wrap_294(ref TeamWindData P0, int P1) => default; // 0x000000018548B870-0x000000018548BA78
		public void __Gen_Wrap_295(ref TeamWindData P0, TeamWindInfo P1, in TeamWindData P2) {} // 0x000000018548BA78-0x000000018548BD34
		public void __Gen_Wrap_296(ref TeamWindData P0, int P1) {} // 0x000000018548BD34-0x000000018548BF2C
		public void __Gen_Wrap_297(ref TeamManager.CalcCenterAndInertiaAndWindJob P0, int P1, in ClothParameters P2, in double3 P3) {} // 0x000000018548BF2C-0x000000018548C264
		public void __Gen_Wrap_298(ref TeamManager.CalcCenterAndInertiaAndWindJob P0) {} // 0x000000018548C264-0x000000018548C47C
		public void __Gen_Wrap_299(ref TeamManager.SimulationStepTeamUpdateJob P0, int P1) {} // 0x000000018548C47C-0x000000018548C5F8
		public void __Gen_Wrap_300(ref TeamManager.SimulationStepTeamUpdateJob P0, ref TeamWindInfo P1, float P2, float P3) {} // 0x000000018548C86C-0x000000018548CA88
		public void __Gen_Wrap_301(ref TeamManager.SimulationStepTeamUpdateJob P0, int P1, in TeamManager.TeamData P2, in WindParams P3, in InertiaConstraint.CenterData P4) {} // 0x000000018548CA88-0x000000018548CDF0
		public void __Gen_Wrap_302(ref TeamManager.SimulationStepTeamUpdateJob P0) {} // 0x000000018548CDF0-0x000000018548CF50
		public void __Gen_Wrap_303(ref TeamManager.PostTeamUpdateJob P0, int P1) {} // 0x000000018548CF50-0x000000018548D0B0
		public void __Gen_Wrap_304(ref TeamManager.PostTeamUpdateJob P0) {} // 0x000000018548D0B0-0x000000018548D1F4
		public void __Gen_Wrap_305(ref VirtualMeshManager.ClearProxyMeshUpdateBufferJob P0) {} // 0x000000018548D1F4-0x000000018548D344
		public void __Gen_Wrap_306(ref VirtualMeshManager.CreateProxyMeshUpdateVertexList P0, int P1) {} // 0x000000018548D344-0x000000018548D4B4
		public int __Gen_Wrap_307(ref NativeReference<int> P0, int P1) => default; // 0x000000018548D4B4-0x000000018548D600
		public void __Gen_Wrap_308(ref VirtualMeshManager.CreateProxyMeshUpdateVertexList P0) {} // 0x000000018548D600-0x000000018548D754
		public void __Gen_Wrap_309(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0, NativeReference<int> P1) {} // 0x000000018548D754-0x000000018548D9AC
		public int __Gen_Wrap_310(ref VirtualMeshBoneWeight P0) => default; // 0x000000018548DB14-0x000000018548DC54
		public void __Gen_Wrap_311(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0, int P1) {} // 0x000000018548DC54-0x000000018548DE88
		public void __Gen_Wrap_312(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0) {} // 0x000000018548DE88-0x000000018548E0A0
		public void __Gen_Wrap_313(ref VirtualMeshManager.CreatePostProxyMeshUpdateListJob P0, int P1) {} // 0x000000018548E0A0-0x000000018548E298
		public void __Gen_Wrap_314(ref VirtualMeshManager.CreatePostProxyMeshUpdateListJob P0) {} // 0x000000018548E298-0x000000018548E474
		public void __Gen_Wrap_315(ref VirtualMeshManager.CalcLineNormalTangentJob P0, NativeReference<int> P1) {} // 0x000000018548E474-0x000000018548E694
		public void __Gen_Wrap_316(ref VirtualMeshManager.CalcLineNormalTangentJob P0, int P1) {} // 0x000000018548E694-0x000000018548E88C
		public void __Gen_Wrap_317(ref VirtualMeshManager.CalcLineNormalTangentJob P0) {} // 0x000000018548E88C-0x000000018548EA70
		public void __Gen_Wrap_318(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0, NativeReference<int> P1) {} // 0x000000018548EA70-0x000000018548EC7C
		public double3 __Gen_Wrap_319(in double3 P0, in double3 P1, in double3 P2, in float2 P3, in float2 P4, in float2 P5) => default; // 0x000000018548EC7C-0x000000018548EF08
		public void __Gen_Wrap_320(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0, int P1) {} // 0x000000018548F08C-0x000000018548F270
		public void __Gen_Wrap_321(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0) {} // 0x000000018548F270-0x000000018548F438
		public void __Gen_Wrap_322(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0, NativeReference<int> P1) {} // 0x000000018548F438-0x000000018548F644
		public void __Gen_Wrap_323(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0, int P1) {} // 0x000000018548F644-0x000000018548F828
		public void __Gen_Wrap_324(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0) {} // 0x000000018548F828-0x000000018548F9F0
		public void __Gen_Wrap_325(ref VirtualMeshManager.WriteTransformDataJob P0, NativeReference<int> P1) {} // 0x000000018548F9F0-0x000000018548FBFC
		public void __Gen_Wrap_326(ref VirtualMeshManager.WriteTransformDataJob P0, int P1) {} // 0x000000018548FBFC-0x000000018548FDE0
		public void __Gen_Wrap_327(ref VirtualMeshManager.WriteTransformDataJob P0) {} // 0x000000018548FDE0-0x000000018548FFA8
		public void __Gen_Wrap_328(ref VirtualMeshManager.WriteTransformLocalDataJob P0, NativeReference<int> P1) {} // 0x000000018548FFA8-0x00000001854901D8
		public void __Gen_Wrap_329(ref VirtualMeshManager.WriteTransformLocalDataJob P0, int P1) {} // 0x00000001854901D8-0x00000001854903E0
		public void __Gen_Wrap_330(ref VirtualMeshManager.WriteTransformLocalDataJob P0) {} // 0x00000001854904D0-0x00000001854906BC
		public void __Gen_Wrap_331(ref VirtualMeshManager.CalcMeshConvertMatrixJob P0, int P1) {} // 0x00000001854906BC-0x000000018549084C
		public void __Gen_Wrap_332(ref VirtualMeshManager.CalcMeshConvertMatrixJob P0) {} // 0x000000018549084C-0x00000001854909C0
		public void __Gen_Wrap_333(ref VirtualMeshManager.CalcProxySkinningJob P0, int P1) {} // 0x00000001854909C0-0x0000000185490C14
		public void __Gen_Wrap_334(ref VirtualMeshManager.CalcProxySkinningJob P0) {} // 0x0000000185490C14-0x0000000185490E4C
		public bool __Gen_Wrap_335(PlayerLoopSystem P0) => default; // 0x0000000185490E4C-0x0000000185490F50
		public bool __Gen_Wrap_336(ref PlayerLoopSystem P0) => default; // 0x0000000185490F50-0x00000001854910AC
		public void __Gen_Wrap_337(PlayerLoopSystem P0, ref PlayerLoopSystem P1, object P2, object P3, bool P4, bool P5) {} // 0x00000001854910AC-0x0000000185491284
		public void __Gen_Wrap_338(ref PlayerLoopSystem P0) {} // 0x0000000185491284-0x00000001854913D0
		public void __Gen_Wrap_339(bool P0) {} // 0x00000001850F0C14-0x00000001850F0CC0
		public void __Gen_Wrap_340(float P0) {} // 0x00000001850F0B68-0x00000001850F0C14
		public void __Gen_Wrap_341(bool P0, float P1) {} // 0x00000001854914C0-0x000000018549158C
		public int __Gen_Wrap_342() => default; // 0x00000001850F1DD4-0x00000001850F1E6C
		public void __Gen_Wrap_343(TimeManager.UpdateLocation P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public TimeManager.UpdateLocation __Gen_Wrap_344() => default; // 0x00000001850F1DD4-0x00000001850F1E6C
		public void __Gen_Wrap_345(MagicaManager.InitializationLocation P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public void __Gen_Wrap_346(ref BeyondDynamicBone.RenderData.UpdatePositionNormalJob P0, int P1) {} // 0x000000018549158C-0x0000000185491728
		public void __Gen_Wrap_347(ref BeyondDynamicBone.RenderData.UpdatePositionNormalJob P0) {} // 0x0000000185491728-0x00000001854918A8
		public void __Gen_Wrap_348(ref BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob P0, int P1) {} // 0x00000001854918A8-0x0000000185491A8C
		public void __Gen_Wrap_349(ref BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob P0) {} // 0x0000000185491A8C-0x0000000185491C54
		public void __Gen_Wrap_350(ref BeyondDynamicBone.RenderData.UpdateBoneWeightJob2 P0, int P1) {} // 0x0000000185491D7C-0x0000000185491F08
		public void __Gen_Wrap_351(ref BeyondDynamicBone.RenderData.UpdateBoneWeightJob2 P0) {} // 0x0000000185491F08-0x0000000185492078
		public RenderSetupData.ShareSerializationData __Gen_Wrap_352(object P0) => default; // 0x0000000185492078-0x0000000185492154
		public RenderSetupData.UniqueSerializationData __Gen_Wrap_353(object P0) => default; // 0x0000000185492154-0x0000000185492230
		public void __Gen_Wrap_354(ref RenderSetupData.VertexWeight5BoneCheckJob P0) {} // 0x0000000185492230-0x0000000185492374
		public void __Gen_Wrap_355(ref RenderSetupData.ReadTransformJob P0, int P1, TransformAccess P2) {} // 0x0000000185492374-0x0000000185492548
		public void __Gen_Wrap_356(ref RenderSetupData.GetBoneWeightJos P0) {} // 0x0000000185492548-0x000000018549269C
		public void __Gen_Wrap_357(ref ColliderManager.PreSimulationUpdateJob P0, int P1) {} // 0x000000018549269C-0x00000001854928A4
		public void __Gen_Wrap_358(ref ColliderManager.PreSimulationUpdateJob P0) {} // 0x00000001854928A4-0x0000000185492A98
		public void __Gen_Wrap_359(ref ColliderManager.CreateUpdatecolliderListJob P0, int P1) {} // 0x0000000185492A98-0x0000000185492C04
		public void __Gen_Wrap_360(ref ColliderManager.CreateUpdatecolliderListJob P0) {} // 0x0000000185492CF4-0x0000000185492E44
		public void __Gen_Wrap_361(ref ColliderManager.StartSimulationStepJob P0, NativeReference<int> P1) {} // 0x0000000185492E44-0x0000000185493064
		public void __Gen_Wrap_362(ref ColliderManager.StartSimulationStepJob P0, int P1) {} // 0x0000000185493064-0x000000018549325C
		public void __Gen_Wrap_363(ref ColliderManager.StartSimulationStepJob P0) {} // 0x000000018549325C-0x0000000185493440
		public void __Gen_Wrap_364(ref ColliderManager.EndSimulationStepJob P0, NativeReference<int> P1) {} // 0x0000000185493440-0x00000001854935F0
		public void __Gen_Wrap_365(ref ColliderManager.EndSimulationStepJob P0, int P1) {} // 0x00000001854935F0-0x000000018549377C
		public void __Gen_Wrap_366(ref ColliderManager.EndSimulationStepJob P0) {} // 0x000000018549377C-0x00000001854938EC
		public void __Gen_Wrap_367(ref ColliderManager.PostSimulationUpdateJob P0, int P1) {} // 0x00000001854938EC-0x0000000185493A8C
		public void __Gen_Wrap_368(ref ColliderManager.PostSimulationUpdateJob P0) {} // 0x0000000185493A8C-0x0000000185493C10
		public JobHandle __Gen_Wrap_369(object P0, in NativeList<int> P1, JobHandle P2) => default; // 0x0000000185493C10-0x0000000185493D98
		public JobHandle __Gen_Wrap_370(object P0, in NativeArray<int> P1, in NativeReference<int> P2, JobHandle P3) => default; // 0x0000000185493D98-0x0000000185493F64
		public JobHandle __Gen_Wrap_371(object P0, in ExProcessingList<int> P1, JobHandle P2) => default; // 0x0000000185493F64-0x00000001854940C8
		public void __Gen_Wrap_372(ref SimulationManager.PreSimulationUpdateJob P0, int P1) {} // 0x00000001854940C8-0x0000000185494310
		public void __Gen_Wrap_373(ref SimulationManager.PreSimulationUpdateJob P0) {} // 0x0000000185494310-0x0000000185494544
		public void __Gen_Wrap_374(ref SimulationManager.ClearStepCounter P0) {} // 0x0000000185494544-0x0000000185494724
		public void __Gen_Wrap_375(ref SimulationManager.CreateUpdateParticleList P0, int P1) {} // 0x0000000185494724-0x000000018549495C
		public void __Gen_Wrap_376(ref SimulationManager.CreateUpdateParticleList P0) {} // 0x000000018549495C-0x0000000185494B80
		public void __Gen_Wrap_377(ref SimulationManager.StartSimulationStepJob P0, NativeReference<int> P1) {} // 0x0000000185494B80-0x0000000185494DB0
		public void __Gen_Wrap_378(ref SimulationManager.StartSimulationStepJob P0, in TeamWindInfo P1, in WindParams P2, in float3 P3, float P4, ref float3 P5) {} // 0x0000000185494DB0-0x0000000185495154
		public void __Gen_Wrap_379(ref SimulationManager.StartSimulationStepJob P0, int P1, in TeamManager.TeamData P2, in WindParams P3, in InertiaConstraint.CenterData P4, int P5, int P6, float P7, ref float3 P8) {} // 0x0000000185495154-0x00000001854955F8
		public void __Gen_Wrap_380(ref SimulationManager.StartSimulationStepJob P0, in SpringConstraint.SpringConstraintParams P1, ClothNormalAxis P2, ref double3 P3, in double3 P4, in quaternion P5, double P6, float P7) {} // 0x0000000185495720-0x0000000185495AD4
		public void __Gen_Wrap_381(ref SimulationManager.StartSimulationStepJob P0, int P1) {} // 0x0000000185495AD4-0x0000000185495CDC
		public void __Gen_Wrap_382(ref SimulationManager.StartSimulationStepJob P0) {} // 0x0000000185495CDC-0x0000000185495ED0
		public void __Gen_Wrap_383(ref SimulationManager.UpdateStepBasicPotureJob P0, NativeReference<int> P1) {} // 0x0000000185495ED0-0x0000000185496128
		public void __Gen_Wrap_384(ref SimulationManager.UpdateStepBasicPotureJob P0, int P1) {} // 0x0000000185496128-0x000000018549635C
		public void __Gen_Wrap_385(ref SimulationManager.UpdateStepBasicPotureJob P0) {} // 0x000000018549635C-0x0000000185496574
		public void __Gen_Wrap_386(ref SimulationManager.EndSimulationStepJob P0, NativeReference<int> P1) {} // 0x0000000185496574-0x0000000185496794
		public void __Gen_Wrap_387(ref SimulationManager.EndSimulationStepJob P0, int P1) {} // 0x0000000185496794-0x000000018549698C
		public void __Gen_Wrap_388(ref SimulationManager.EndSimulationStepJob P0) {} // 0x000000018549698C-0x0000000185496B70
		public void __Gen_Wrap_389(ref SimulationManager.CalcDisplayPositionJob P0, int P1) {} // 0x0000000185496B70-0x0000000185496D84
		public void __Gen_Wrap_390(ref SimulationManager.CalcDisplayPositionJob P0) {} // 0x0000000185496E8C-0x0000000185497084
		public void __Gen_Wrap_391(ref SimulationManager.FeedbackTempPosJob P0, int P1) {} // 0x0000000185497084-0x00000001854971E0
		public void __Gen_Wrap_392(ref SimulationManager.FeedbackTempPosJob2 P0, int P1) {} // 0x00000001854971E0-0x000000018549733C
		public void __Gen_Wrap_393(object P0, ref TeamManager.TeamData P1) {} // 0x000000018549733C-0x0000000185497574
		public void __Gen_Wrap_394(object P0, ref TeamManager.TeamData P1, object P2, object P3) {} // 0x0000000185497574-0x00000001854977DC
		public void __Gen_Wrap_395(object P0, object P1, object P2, object P3, object P4, object P5) {} // 0x000000018516104C-0x0000000185161164
		public void __Gen_Wrap_396(ref TeamWindInfo P0) {} // 0x00000001854977DC-0x0000000185497910
		public void __Gen_Wrap_397(ref TeamWindData P0) {} // 0x0000000185497910-0x0000000185497AEC
		public int __Gen_Wrap_398(object P0, object P1, int P2, int P3, byte P4, bool P5) => default; // 0x0000000185497AEC-0x0000000185497C10
		public int[] __Gen_Wrap_399(object P0, object P1, object P2, object P3, int P4) => default; // 0x0000000185497C10-0x0000000185497D44
		public int[] __Gen_Wrap_400(object P0, object P1, int P2) => default; // 0x0000000185497D44-0x0000000185497E58
		public int __Gen_Wrap_401(object P0, int P1, object P2, int P3, int P4, byte P5) => default; // 0x0000000185497E58-0x0000000185497F7C
		public float4x4 __Gen_Wrap_402(object P0, int P1) => default; // 0x0000000185497F7C-0x00000001854980A8
		public BeyondDynamicBone.TransformData.ShareSerializationData __Gen_Wrap_403(object P0) => default; // 0x00000001854980A8-0x0000000185498184
		public BeyondDynamicBone.TransformData.UniqueSerializationData __Gen_Wrap_404(object P0) => default; // 0x0000000185498184-0x0000000185498260
		public void __Gen_Wrap_405(ref BeyondDynamicBone.TransformData.RestoreTransformJob P0, int P1, TransformAccess P2) {} // 0x0000000185498260-0x0000000185498410
		public void __Gen_Wrap_406(ref BeyondDynamicBone.TransformData.ReadTransformJob P0, int P1, TransformAccess P2) {} // 0x0000000185498410-0x00000001854985FC
		public Vector3 __Gen_Wrap_407(object P0, Vector3 P1) => default; // 0x00000001854985FC-0x0000000185498744
		public SharePreBuildData __Gen_Wrap_408(object P0, object P1) => default; // 0x0000000185498744-0x000000018549883C
		public bool __Gen_Wrap_409(SharePreBuildData P0) => default; // 0x00000001850EF298-0x00000001850EF354
		public void __Gen_Wrap_410(SharePreBuildData P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public string __Gen_Wrap_411() => default; // 0x0000000185498954-0x0000000185498A0C
		public void __Gen_Wrap_412(ref SameDistanceReduction.InitGridJob P0) {} // 0x0000000185498A0C-0x0000000185498B60
		public void __Gen_Wrap_413(ref SameDistanceReduction.SearchJoinJob P0) {} // 0x0000000185498B60-0x0000000185498CC0
		public void __Gen_Wrap_414(ref VirtualMeshBoneWeight P0, int P1, float P2) {} // 0x0000000185498CC0-0x0000000185498E28
		public void __Gen_Wrap_415(ref VirtualMeshBoneWeight P0, in VirtualMeshBoneWeight P1) {} // 0x0000000185498E28-0x0000000185498FA4
		public void __Gen_Wrap_416(ref SameDistanceReduction.JoinJob2 P0) {} // 0x0000000185498FA4-0x0000000185499148
		public void __Gen_Wrap_417(ref SameDistanceReduction.UpdateJoinIndexJob P0, int P1) {} // 0x0000000185499148-0x0000000185499284
		public void __Gen_Wrap_418(ref SameDistanceReduction.UpdateLinkIndexJob P0, int P1) {} // 0x0000000185499284-0x00000001854993D0
		public void __Gen_Wrap_419(ref VirtualMeshBoneWeight P0) {} // 0x00000001854993D0-0x0000000185499500
		public void __Gen_Wrap_420(ref SameDistanceReduction.FinalMergeVertexJob P0, int P1) {} // 0x000000018549960C-0x0000000185499768
		public bool __Gen_Wrap_421(in NativeParallelMultiHashMap<ushort, ushort> P0, int P1, int P2, bool P3) => default; // 0x0000000185499768-0x00000001854998B4
		public void __Gen_Wrap_422(ref ShapeDistanceReduction.SearchJoinEdgeJob P0) {} // 0x00000001854998B4-0x0000000185499A14
		public void __Gen_Wrap_423(ref SimpleDistanceReduction.InitGridJob P0) {} // 0x0000000185499A14-0x0000000185499B68
		public void __Gen_Wrap_424(ref SimpleDistanceReduction.SearchJoinEdgeJob P0) {} // 0x0000000185499B68-0x0000000185499CD8
		public bool __Gen_Wrap_425(in NativeArray<FixedList128Bytes<ushort>> P0, int P1, int P2, in FixedList128Bytes<ushort> P3, in FixedList128Bytes<ushort> P4, bool P5) => default; // 0x0000000185499CD8-0x0000000185499F28
		public bool __Gen_Wrap_426(ref StepReductionBase.JoinEdge P0, in int2 P1) => default; // 0x0000000185499F28-0x000000018549A0B4
		public int __Gen_Wrap_427(ref StepReductionBase.JoinEdge P0, StepReductionBase.JoinEdge P1) => default; // 0x000000018549A0B4-0x000000018549A240
		public void __Gen_Wrap_428(ref StepReductionBase.DeterminJoinEdgeJob P0) {} // 0x000000018549A240-0x000000018549A3A4
		public void __Gen_Wrap_429(ref StepReductionBase.JoinPairJob P0) {} // 0x000000018549A3A4-0x000000018549A548
		public void __Gen_Wrap_430(ref StepReductionBase.UpdateJoinIndexJob P0, int P1) {} // 0x000000018549A670-0x000000018549A7AC
		public void __Gen_Wrap_431(ref StepReductionBase.UpdateLinkIndexJob P0, int P1) {} // 0x000000018549A7AC-0x000000018549A8F8
		public void __Gen_Wrap_432(ref StepReductionBase.FinalMergeVertexJob P0, int P1) {} // 0x000000018549A8F8-0x000000018549AA54
		public int3 __Gen_Wrap_433(in int3 P0) => default; // 0x000000018549AA54-0x000000018549AB98
		public JobHandle __Gen_Wrap_434(NativeArray<int> P0, int P1, int P2, int P3, JobHandle P4) => default; // 0x000000018549AB98-0x000000018549AD28
		public JobHandle __Gen_Wrap_435(NativeReference<int> P0, int P1, JobHandle P2) => default; // 0x000000018549AD28-0x000000018549AE9C
		public JobHandle __Gen_Wrap_436(NativeArray<int> P0, int P1, JobHandle P2) => default; // 0x000000018549AE9C-0x000000018549B010
		public JobHandle __Gen_Wrap_437(NativeParallelHashSet<int> P0, NativeList<int> P1, JobHandle P2) => default; // 0x000000018549B010-0x000000018549B1A8
		public JobHandle __Gen_Wrap_438(NativeParallelHashSet<int2> P0, NativeList<int2> P1, JobHandle P2) => default; // 0x000000018549B1A8-0x000000018549B340
		public JobHandle __Gen_Wrap_439(NativeParallelHashSet<int4> P0, NativeList<int4> P1, JobHandle P2) => default; // 0x000000018549B340-0x000000018549B4D8
		public JobHandle __Gen_Wrap_440(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, JobHandle P3) => default; // 0x000000018549B5E4-0x000000018549B78C
		public JobHandle __Gen_Wrap_441(NativeList<float3> P0, NativeReference<AABB> P1, JobHandle P2) => default; // 0x000000018549B78C-0x000000018549B924
		public void __Gen_Wrap_442(NativeList<float3> P0, NativeReference<AABB> P1) {} // 0x000000018549B924-0x000000018549BA4C
		public AABB __Gen_Wrap_443(in NativeArray<float3> P0, int P1) => default; // 0x000000018549BA4C-0x000000018549BBAC
		public JobHandle __Gen_Wrap_444(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, NativeArray<float2> P3, JobHandle P4) => default; // 0x000000018549BBAC-0x000000018549BD8C
		public JobHandle __Gen_Wrap_445(NativeArray<float3> P0, int P1, in float4x4 P2, JobHandle P3) => default; // 0x000000018549BD8C-0x000000018549BF60
		public JobHandle __Gen_Wrap_446(NativeArray<float3> P0, NativeArray<float3> P1, int P2, in float4x4 P3, JobHandle P4) => default; // 0x000000018549BF60-0x000000018549C15C
		public JobHandle __Gen_Wrap_447(NativeReference<int> P0, JobHandle P1) => default; // 0x000000018549C15C-0x000000018549C2BC
		public void __Gen_Wrap_448(ref ClothJobUtility.SerialNumberJob P0, int P1) {} // 0x000000018549C2BC-0x000000018549C3F8
		public void __Gen_Wrap_449(ref ClothJobUtility.CalcAABBJob P0) {} // 0x000000018549C3F8-0x000000018549C53C
		public void __Gen_Wrap_450(ref ClothJobUtility.CalcAABBDeferJob P0) {} // 0x000000018549C784-0x000000018549C8B4
		public void __Gen_Wrap_451(ref ClothJobUtility.CalcUVJob P0, int P1) {} // 0x000000018549C8B4-0x000000018549CA10
		public void __Gen_Wrap_452(ref ClothJobUtility.AddIntDataCopyJob P0, int P1) {} // 0x000000018549CA10-0x000000018549CB70
		public void __Gen_Wrap_453(ref ClothJobUtility.AddInt2DataCopyJob P0, int P1) {} // 0x000000018549CB70-0x000000018549CCCC
		public void __Gen_Wrap_454(ref ClothJobUtility.AddInt3DataCopyJob P0, int P1) {} // 0x000000018549CCCC-0x000000018549CE28
		public void __Gen_Wrap_455(ref ClothJobUtility.TransformPositionJob P0, int P1) {} // 0x000000018549CE28-0x000000018549CFA4
		public void __Gen_Wrap_456(ref ClothJobUtility.TransformPositionJob2 P0, int P1) {} // 0x000000018549CFA4-0x000000018549D130
		public void __Gen_Wrap_457(ref ClothJobUtility.ClearReferenceJob P0) {} // 0x000000018549D130-0x000000018549D254
		public JobHandle __Gen_Wrap_458(in NativeList<int> P0, float P1, JobHandle P2) => default; // 0x000000018549D254-0x000000018549D3DC
		public void __Gen_Wrap_459(ref InterlockUtility.AggregateJob P0, int P1) {} // 0x000000018549D3DC-0x000000018549D548
		public void __Gen_Wrap_460(ref InterlockUtility.AggregateJob P0) {} // 0x000000018549D624-0x000000018549D774
		public void __Gen_Wrap_461(ref InterlockUtility.AggregateWithVelocityJob P0, int P1) {} // 0x000000018549D774-0x000000018549D904
		public void __Gen_Wrap_462(ref InterlockUtility.AggregateWithVelocityJob P0) {} // 0x000000018549D904-0x000000018549DA78
		public void __Gen_Wrap_463(ref InterlockUtility.AggregateJob2 P0, NativeReference<int> P1) {} // 0x000000018549DA78-0x000000018549DC18
		public void __Gen_Wrap_464(ref InterlockUtility.AggregateJob2 P0, int P1) {} // 0x000000018549DC18-0x000000018549DD94
		public void __Gen_Wrap_465(ref InterlockUtility.AggregateJob2 P0) {} // 0x000000018549DD94-0x000000018549DEF4
		public void __Gen_Wrap_466(ref InterlockUtility.AggregateWithVelocityJob2 P0, NativeReference<int> P1) {} // 0x000000018549DEF4-0x000000018549E0C8
		public void __Gen_Wrap_467(ref InterlockUtility.AggregateWithVelocityJob2 P0, int P1) {} // 0x000000018549E0C8-0x000000018549E268
		public void __Gen_Wrap_468(ref InterlockUtility.AggregateWithVelocityJob2 P0) {} // 0x000000018549E268-0x000000018549E3EC
		public void __Gen_Wrap_469(ref InterlockUtility.AggregateWithVelocityCrossFrameJob2 P0, int P1) {} // 0x000000018549E3EC-0x000000018549E58C
		public void __Gen_Wrap_470(ref InterlockUtility.AggregateWithVelocityCrossFrameJob2 P0) {} // 0x000000018549E6A8-0x000000018549E82C
		public void __Gen_Wrap_471(ref InterlockUtility.AggregateCrossFrameJob2 P0, int P1) {} // 0x000000018549E82C-0x000000018549E9A8
		public void __Gen_Wrap_472(ref InterlockUtility.AggregateCrossFrameJob2 P0) {} // 0x000000018549E9A8-0x000000018549EB08
		public string __Gen_Wrap_473(ref AABB P0) => default; // 0x000000018549EB08-0x000000018549EC6C
		public void __Gen_Wrap_474(float3 P0, quaternion P1, float3 P2, quaternion P3, out float3 P4, out quaternion P5) {
			P4 = default;
			P5 = default;
		} // 0x000000018549EC6C-0x000000018549EEB4
		public float3 __Gen_Wrap_475(in float3 P0, in float3 P1, in float3 P2, in float2 P3, in float2 P4, in float2 P5) => default; // 0x000000018549EEB4-0x000000018549F140
		public int2 __Gen_Wrap_476(int3 P0, int3 P1) => default; // 0x000000018549F140-0x000000018549F288
		public int4 __Gen_Wrap_477(int3 P0, int3 P1) => default; // 0x000000018549F288-0x000000018549F3EC
		public bool __Gen_Wrap_478(in float3 P0, in float3 P1, float3 P2, float3 P3, float3 P4, bool P5, out float P6, out float P7, out float P8, out float P9) {
			P6 = default;
			P7 = default;
			P8 = default;
			P9 = default;
			return default;
		} // 0x000000018549F3EC-0x000000018549F6CC
		public bool __Gen_Wrap_479(in float3 P0, in float3 P1, float3 P2, float3 P3, float3 P4) => default; // 0x000000018549F6CC-0x000000018549F8C4
		public float __Gen_Wrap_480(Vector3 P0, Vector3 P1, Vector3 P2) => default; // 0x000000018549F8C4-0x000000018549FA34
		public BeyondDynamicBone.FTransform __Gen_Wrap_481() => default; // 0x000000018549FA34-0x000000018549FB20
		public Mesh __Gen_Wrap_482(object P0) => default; // 0x000000018549FB20-0x000000018549FBFC
		public StringBuilder __Gen_Wrap_483(object P0) => default; // 0x000000018549FBFC-0x000000018549FCD8
		public StringBuilder __Gen_Wrap_484() => default; // 0x000000018549FCD8-0x000000018549FD90
		public string __Gen_Wrap_485(ref DataChunk P0) => default; // 0x000000018549FD90-0x000000018549FEC8
		public void __Gen_Wrap_486(ref ExBitFlag16 P0) {} // 0x000000018549FEC8-0x000000018549FFE4
		public int __Gen_Wrap_487(ref ExCostSortedList1 P0, ExCostSortedList1 P1) => default; // 0x000000018549FFE4-0x00000001854A013C
		public string __Gen_Wrap_488(ref ExCostSortedList1 P0) => default; // 0x00000001854A013C-0x00000001854A0274
		public bool __Gen_Wrap_489(ref ExCostSortedList4 P0, float P1, int P2) => default; // 0x00000001854A0274-0x00000001854A03EC
		public int __Gen_Wrap_490(ref ExCostSortedList4 P0, int P1) => default; // 0x00000001854A0500-0x00000001854A065C
		public void __Gen_Wrap_491(ref ExCostSortedList4 P0, int P1) {} // 0x00000001854A065C-0x00000001854A07A8
		public string __Gen_Wrap_492(ref ExCostSortedList4 P0) => default; // 0x00000001854A07A8-0x00000001854A08F8
		public TransformAccessArray __Gen_Wrap_493(object P0) => default; // 0x00000001854A08F8-0x00000001854A09D4
		public bool __Gen_Wrap_494(ref ResultCode P0, Define.Result P1) => default; // 0x00000001854A09D4-0x00000001854A0B14
		public void __Gen_Wrap_495(ref ResultCode P0, bool P1, bool P2, bool P3) {} // 0x00000001854A0B14-0x00000001854A0C64
		public double __Gen_Wrap_496(object P0) => default; // 0x00000001854A0C64-0x00000001854A0D20
		public void __Gen_Wrap_497(object P0, object P1, object P2, int P3, int P4) {} // 0x00000001854A0D20-0x00000001854A0E2C
		public float4 __Gen_Wrap_498(float4 P0) => default; // 0x00000001854A0E2C-0x00000001854A0F4C
		public VirtualMesh.ShareSerializationData __Gen_Wrap_499(object P0) => default; // 0x00000001854A0F4C-0x00000001854A1028
		public VirtualMesh.UniqueSerializationData __Gen_Wrap_500(object P0) => default; // 0x00000001854A1208-0x00000001854A12E4
		public VirtualMeshRaycastHit __Gen_Wrap_501(object P0, float3 P1, float3 P2, bool P3, float P4) => default; // 0x00000001854A12E4-0x00000001854A1490
		public void __Gen_Wrap_502(ref VirtualMesh.Import_GenerateTangentJob P0, int P1) {} // 0x00000001854A1490-0x00000001854A15DC
		public void __Gen_Wrap_503(ref VirtualMesh.Import_CalcSkinningJob P0, int P1) {} // 0x00000001854A15DC-0x00000001854A1800
		public void __Gen_Wrap_504(ref VirtualMesh.Import_BoneWeightJob1 P0) {} // 0x00000001854A1800-0x00000001854A1944
		public void __Gen_Wrap_505(ref VirtualMesh.Import_BoneWeightJob2 P0, int P1) {} // 0x00000001854A1944-0x00000001854A1AB0
		public void __Gen_Wrap_506(ref VirtualMesh.Import_BoneVertexJob P0, int P1) {} // 0x00000001854A1AB0-0x00000001854A1C9C
		public void __Gen_Wrap_507(ref VirtualMesh.Select_PackVertexJob P0) {} // 0x00000001854A1C9C-0x00000001854A1EC4
		public void __Gen_Wrap_508(ref VirtualMesh.Select_GridJob P0) {} // 0x00000001854A1EC4-0x00000001854A20A4
		public void __Gen_Wrap_509(ref VirtualMesh.Add_CalcBindPoseJob P0, int P1) {} // 0x00000001854A20A4-0x00000001854A229C
		public void __Gen_Wrap_510(ref VirtualMesh.Add_CopyVerticesJob P0, int P1) {} // 0x00000001854A2394-0x00000001854A259C
		public void __Gen_Wrap_511(ref VirtualMesh.Mapping_DirectConnectionVertexDataJob P0) {} // 0x00000001854A259C-0x00000001854A2788
		public void __Gen_Wrap_512(ref VirtualMesh.Mapping_CalcDirectWeightJob P0) {} // 0x00000001854A2788-0x00000001854A292C
		public void __Gen_Wrap_513(ref VirtualMesh.Mapping_CalcConnectionVertexDataJob P0) {} // 0x00000001854A292C-0x00000001854A2B54
		public void __Gen_Wrap_514(ref VirtualMesh.Mapping_CalcWeightJob P0, int P1) {} // 0x00000001854A2B54-0x00000001854A2D10
		public void __Gen_Wrap_515(ref VirtualMesh.Optimize_EdgeToTrianlgeJob P0) {} // 0x00000001854A2D10-0x00000001854A2E94
		public void __Gen_Wrap_516(ref VirtualMesh.ProxyNormalRadiationAdjustmentJob P0, int P1) {} // 0x00000001854A2E94-0x00000001854A3074
		public void __Gen_Wrap_517(ref VirtualMesh.ProxyCreateFixedListAndAABBJob P0) {} // 0x00000001854A3074-0x00000001854A3218
		public void __Gen_Wrap_518(ref VirtualMesh.Proxy_CalcTriangleNormalJob P0, int P1) {} // 0x00000001854A3218-0x00000001854A3374
		public void __Gen_Wrap_519(ref VirtualMesh.Proxy_CalcTriangleTangentJob P0, int P1) {} // 0x00000001854A3374-0x00000001854A34E0
		public void __Gen_Wrap_520(ref VirtualMesh.Proxy_CreateVertexToTrianglesJob P0) {} // 0x00000001854A34E0-0x00000001854A3610
		public void __Gen_Wrap_521(ref VirtualMesh.Proxy_OrganizeVertexToTrianglsJob P0, int P1) {} // 0x00000001854A3610-0x00000001854A377C
		public void __Gen_Wrap_522(ref VirtualMesh.Proxy_CalcVertexNormalTangentFromTriangleJob P0, int P1) {} // 0x00000001854A377C-0x00000001854A38F8
		public void __Gen_Wrap_523(ref VirtualMesh.Proxy_CalcVertexToTransformJob P0, int P1) {} // 0x00000001854A38F8-0x00000001854A3A74
		public void __Gen_Wrap_524(ref VirtualMesh.Proxy_CalcEdgeToTriangleJob P0) {} // 0x00000001854A3A74-0x00000001854A3BB8
		public void __Gen_Wrap_525(ref VirtualMesh.Proxy_CalcVertexBindPoseJob2 P0, int P1) {} // 0x00000001854A3BB8-0x00000001854A3D34
		public void __Gen_Wrap_526(ref VirtualMesh.Proxy_CalcVertexToVertexFromTriangleJob P0) {} // 0x00000001854A3D34-0x00000001854A3E88
		public void __Gen_Wrap_527(ref VirtualMesh.Proxy_CalcVertexToVertexFromLineJob P0) {} // 0x00000001854A3E88-0x00000001854A3FDC
		public void __Gen_Wrap_528(ref VirtualMesh.Proxy_CreateEdgeFlagJob P0, int P1) {} // 0x00000001854A3FDC-0x00000001854A4138
		public void __Gen_Wrap_529(ref VirtualMesh.Proxy_CalcCustomSkinningWeightsJobV2 P0, int P1) {} // 0x00000001854A4138-0x00000001854A42B4
		public void __Gen_Wrap_530(ref VirtualMesh.Proxy_ApplySelectionJob P0, int P1) {} // 0x00000001854A42B4-0x00000001854A4444
		public void __Gen_Wrap_531(ref VirtualMesh.Proxy_BoneClothApplayTransformFlagJob P0, int P1) {} // 0x00000001854A4444-0x00000001854A4590
		public int __Gen_Wrap_532(ref VirtualMesh.BaseLineWork P0, VirtualMesh.BaseLineWork P1) => default; // 0x00000001854A4590-0x00000001854A46E8
		public void __Gen_Wrap_533(ref VirtualMesh.BaseLine_Mesh_CreateParentJob2 P0) {} // 0x00000001854A46E8-0x00000001854A48D4
		public void __Gen_Wrap_534(ref VirtualMesh.BaseLine_Mesh_CareteFixedListJob P0) {} // 0x00000001854A48D4-0x00000001854A4A18
		public void __Gen_Wrap_535(ref VirtualMesh.BaseLine_Bone_CreateBoneChildInfoJob P0) {} // 0x00000001854A4A18-0x00000001854A4B5C
		public void __Gen_Wrap_536(ref VirtualMesh.BaseLine_CalcLocalPositionRotationJob P0, int P1) {} // 0x00000001854A4B5C-0x00000001854A4CF8
		public void __Gen_Wrap_537(ref VirtualMesh.BaseLine_CalcMaxBaseLineLengthJob P0) {} // 0x00000001854A4CF8-0x00000001854A4E7C
		public void __Gen_Wrap_538(ref VirtualMesh.Reduction_InitVertexToVertexJob2 P0) {} // 0x00000001854A4E7C-0x00000001854A4FC0
		public void __Gen_Wrap_539(ref VirtualMesh.Organize_RemapVertexJob P0) {} // 0x00000001854A4FC0-0x00000001854A5104
		public void __Gen_Wrap_540(ref VirtualMesh.Organize_CollectUseSkinBoneJob P0) {} // 0x00000001854A52B4-0x00000001854A5478
		public void __Gen_Wrap_541(ref VirtualMesh.Organize_CopyVertexJob P0, int P1) {} // 0x00000001854A5478-0x00000001854A5670
		public void __Gen_Wrap_542(ref VirtualMesh.Organize_RemapBoneWeightJob P0, int P1) {} // 0x00000001854A5670-0x00000001854A57FC
		public void __Gen_Wrap_543(ref VirtualMesh.Organize_RemapLinkPointArrayJob P0, int P1) {} // 0x00000001854A57FC-0x00000001854A5968
		public void __Gen_Wrap_544(ref VirtualMesh.Organize_CreateLineTriangleJob P0) {} // 0x00000001854A5968-0x00000001854A5AAC
		public void __Gen_Wrap_545(ref VirtualMesh.Organize_CreateLineTriangleJob2 P0) {} // 0x00000001854A5AAC-0x00000001854A5BFC
		public void __Gen_Wrap_546(ref VirtualMesh.Organize_CreateNewTriangleJob3 P0) {} // 0x00000001854A5BFC-0x00000001854A5D2C
		public void __Gen_Wrap_547(ref VirtualMesh.Work_AverageTriangleDistanceJob P0) {} // 0x00000001854A5D2C-0x00000001854A5EA0
		public void __Gen_Wrap_548(ref VirtualMesh.Work_AverageLineDistanceJob P0) {} // 0x00000001854A5EA0-0x00000001854A6014
		public void __Gen_Wrap_549(ref VirtualMesh.Work_AddVertexIndexGirdMapJob P0) {} // 0x00000001854A6014-0x00000001854A6158
		public void __Gen_Wrap_550(ref VirtualMesh.Work_IntersectTriangleJob P0, int P1) {} // 0x00000001854A631C-0x00000001854A6498
		public void __Gen_Wrap_551(ref VirtualMesh.Work_IntersectEdgeJob P0, int P1) {} // 0x00000001854A6498-0x00000001854A6634
		public void __Gen_Wrap_552(ref VirtualMesh.Work_IntersectPointJob P0, int P1) {} // 0x00000001854A6634-0x00000001854A67B0
		public void __Gen_Wrap_553(ref VirtualMesh.Work_IntersetcSortJob P0) {} // 0x00000001854A67B0-0x00000001854A68D4
		public bool __Gen_Wrap_554(ref VertexAttribute P0, object P1) => default; // 0x00000001854A68D4-0x00000001854A6A14
		public int __Gen_Wrap_555(ref VertexAttribute P0) => default; // 0x00000001854A6A14-0x00000001854A6B38
		public string __Gen_Wrap_556(ref VirtualMeshBoneWeight P0) => default; // 0x00000001854A6B38-0x00000001854A6C88
		public int __Gen_Wrap_557(ref VirtualMeshRaycastHit P0, VirtualMeshRaycastHit P1) => default; // 0x00000001854A6C88-0x00000001854A6E38
		public bool __Gen_Wrap_558(ref VirtualMeshRaycastHit P0) => default; // 0x00000001854A6E38-0x00000001854A6F9C
		public string __Gen_Wrap_559(ref VirtualMeshRaycastHit P0) => default; // 0x00000001854A6F9C-0x00000001854A7114
		public VirtualMeshTransform __Gen_Wrap_560(ref VirtualMeshTransform P0) => default; // 0x00000001854A7220-0x00000001854A7498
		public VirtualMeshTransform __Gen_Wrap_561() => default; // 0x00000001854A7498-0x00000001854A75D4
		public int __Gen_Wrap_562(ref VirtualMeshTransform P0) => default; // 0x00000001854A75D4-0x00000001854A77D0
		public void __Gen_Wrap_563(ref VirtualMeshTransform P0, object P1) {} // 0x00000001854A77D0-0x00000001854A79D8
		public VirtualMeshTransform __Gen_Wrap_564(ref VirtualMeshTransform P0, in VirtualMeshTransform P1) => default; // 0x00000001854A79D8-0x00000001854A7CEC
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IAsyncStateMachine // TypeDefIndex: 45315
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001854AD9B0-0x00000001854ADA64
	
		// Methods
		[IDTag(0)]
		private void MoveNext() {} // 0x00000001854AD7A0-0x00000001854AD830
		[IDTag(1)]
		private void SetStateMachine(IAsyncStateMachine P0) {} // 0x00000001854AD900-0x00000001854AD9B0
		public void RefAwaitUnsafeOnCompleteMethod() {} // 0x00000001854AD88C-0x00000001854AD900
		public void RefAsyncBuilderStartMethod() {} // 0x00000001854AD830-0x00000001854AD88C
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 45316
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001854B5C4C-0x00000001854B5CB0
		public static bool IsPatched(int id) => default; // 0x00000001827B29C0-0x00000001827B2A70
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001854B5B08-0x00000001854B5BD4
		public object CreateWrapper(int id) => default; // 0x00000001854B5BD4-0x00000001854B5C4C
		public object InitWrapperArray(int len) => default; // 0x00000001854B5CB0-0x00000001854B5D3C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001854B5A64-0x00000001854B5B08
	}

	public enum IDMAP0 // TypeDefIndex: 45317
	{
		BeyondDynamicBone-BeyondBoneCloth-InitAnimationProperty0 = 0,
		BeyondDynamicBone-BeyondBoneCloth-OnDidApplyAnimationProperties0 = 1,
		BeyondDynamicBone-BeyondBoneCloth-SetParameterChange0 = 2,
		BeyondDynamicBone-BeyondBoneCloth-IsValid0 = 3,
		BeyondDynamicBone-MagicaManager-IsPlaying0 = 4,
		BeyondDynamicBone-ClothProcess-IsValid0 = 5,
		BeyondDynamicBone-ClothProcess-IsState0 = 6,
		BeyondDynamicBone-ClothProcess-DataUpdate0 = 8,
		BeyondDynamicBone-ClothSerializeData-DataValidate0 = 10,
		BeyondDynamicBone-ReductionSettings-DataValidate0 = 11,
		BeyondDynamicBone-CustomSkinningSettings-DataValidate0 = 12,
		BeyondDynamicBone-NormalAlignmentSettings-DataValidate0 = 13,
		BeyondDynamicBone-CullingSettings-DataValidate0 = 14,
		BeyondDynamicBone-CheckSliderSerializeData-DataValidate0 = 15,
		BeyondDynamicBone-CurveSerializeData-DataValidate0 = 16,
		BeyondDynamicBone-InertiaConstraint-SerializeData-DataValidate0 = 17,
		BeyondDynamicBone-TetherConstraint-SerializeData-DataValidate0 = 18,
		BeyondDynamicBone-DistanceConstraint-SerializeData-DataValidate0 = 19,
		BeyondDynamicBone-TriangleBendingConstraint-SerializeData-DataValidate0 = 20,
		BeyondDynamicBone-AngleConstraint-RestorationSerializeData-DataValidate0 = 21,
		BeyondDynamicBone-AngleConstraint-LimitSerializeData-DataValidate0 = 22,
		BeyondDynamicBone-MotionConstraint-SerializeData-DataValidate0 = 23,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-DataValidate0 = 24,
		BeyondDynamicBone-SelfCollisionConstraint-SerializeData-DataValidate0 = 25,
		BeyondDynamicBone-WindSettings-DataValidate0 = 26,
		BeyondDynamicBone-ClothSerializeData2-DataValidate0 = 27,
		BeyondDynamicBone-BeyondBoneCloth-SetRelativeTransform0 = 28,
		BeyondDynamicBone-BeyondBoneCloth-get_SyncPartnerCloth0 = 31,
		BeyondDynamicBone-ClothSerializeData-IsBoneSpring0 = 32,
		BeyondDynamicBone-SelfCollisionConstraint-SerializeData-GetSyncPartner0 = 33,
		BeyondDynamicBone-BeyondBoneCloth-Reset0 = 34,
		BeyondDynamicBone-BeyondBoneCloth-OnValidate0 = 35,
		BeyondDynamicBone-BeyondBoneCloth-Awake0 = 36,
		BeyondDynamicBone-ClothProcess-Init0 = 37,
		BeyondDynamicBone-ResultCode-SetSuccess0 = 38,
		BeyondDynamicBone-ResultCode-SetResult0 = 39,
		BeyondDynamicBone-Develop-LogError0 = 40,
		BeyondDynamicBone-BeyondBoneCloth-GetSerializeData20 = 41,
		BeyondDynamicBone-ClothProcess-SetState0 = 42,
		BeyondDynamicBone-ClothSerializeData-IsValid0 = 43,
		BeyondDynamicBone-ResultCode-SetError0 = 48,
		BeyondDynamicBone-ClothProcess-GenerateStatusCheck0 = 49,
		BeyondDynamicBone-ResultCode-SetWarning0 = 50,
		BeyondDynamicBone-ResultCode-Merge0 = 51,
		BeyondDynamicBone-ResultCode-IsError0 = 52,
		BeyondDynamicBone-ResultCode-IsWarning0 = 53,
		BeyondDynamicBone-PreBuildSerializeData-UsePreBuild0 = 54,
		BeyondDynamicBone-PreBuildSerializeData-DataValidate0 = 55,
		BeyondDynamicBone-PreBuildSerializeData-GetSharePreBuildData0 = 56,
		BeyondDynamicBone-SharePreBuildData-DataValidate0 = 57,
		BeyondDynamicBone-ResultCode-IsFaild0 = 58,
		BeyondDynamicBone-ResultCode-IsSuccess0 = 59,
		BeyondDynamicBone-UniquePreBuildData-DataValidate0 = 60,
		BeyondDynamicBone-ClothSerializeData-GetClothParameters0 = 62,
		BeyondDynamicBone-CurveSerializeData-ConvertFloatArray0 = 63,
		BeyondDynamicBone-DataUtility-ConvertAnimationCurve0 = 64,
		BeyondDynamicBone-CullingSettings-CullingParams-Convert0 = 65,
		BeyondDynamicBone-InertiaConstraint-InertiaConstraintParams-Convert0 = 66,
		BeyondDynamicBone-CheckSliderSerializeData-GetValue0 = 67,
		BeyondDynamicBone-TetherConstraint-TetherConstraintParams-Convert0 = 68,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintParams-Convert0 = 69,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingConstraintParams-Convert0 = 70,
		BeyondDynamicBone-AngleConstraint-AngleConstraintParams-Convert0 = 71,
		BeyondDynamicBone-MotionConstraint-MotionConstraintParams-Convert0 = 72,
		BeyondDynamicBone-ColliderCollisionConstraint-ColliderCollisionConstraintParams-Convert0 = 73,
		BeyondDynamicBone-SelfCollisionConstraint-SelfCollisionConstraintParams-Convert0 = 74,
		BeyondDynamicBone-WindParams-Convert0 = 75,
		BeyondDynamicBone-SpringConstraint-SpringConstraintParams-Convert0 = 76,
		BeyondDynamicBone-PreBuildManager-RegisterPreBuildData0 = 81,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-Deserialize0 = 82,
		BeyondDynamicBone-ResultCode-SetProcess0 = 83,
		BeyondDynamicBone-RenderSetupData-ShareDeserialize0 = 84,
		BeyondDynamicBone-VirtualMesh-ShareDeserialize0 = 85,
		BeyondDynamicBone-TransformData-ShareDeserialize0 = 86,
		BeyondDynamicBone-NativeMultiHashMapExtensions-MC2Deserialize0 = 87,
		BeyondDynamicBone-RenderSetupData-Dispose0 = 89,
		BeyondDynamicBone-ClothProcess-AddRenderer0 = 90,
		BeyondDynamicBone-RenderManager-AddRenderer0 = 91,
		BeyondDynamicBone-RenderData-Initialize0 = 92,
		BeyondDynamicBone-RenderData-AddReferenceCount0 = 93,
		BeyondDynamicBone-RenderManager-GetRendererData0 = 96,
		BeyondDynamicBone-ClothProcess-CreateBoneRenderSetupData0 = 97,
		BeyondDynamicBone-TeamManager-AddMonitoringProcess0 = 100,
		BeyondDynamicBone-TeamManager-RemoveMonitoringProcess0 = 101,
		BeyondDynamicBone-BeyondBoneCloth-OnEnable0 = 102,
		BeyondDynamicBone-ClothProcess-StartUse0 = 103,
		BeyondDynamicBone-ClothProcess-UpdateUse0 = 104,
		BeyondDynamicBone-TeamManager-SetEnable0 = 105,
		BeyondDynamicBone-ClothManager-ForceCompleteAllJob0 = 106,
		BeyondDynamicBone-ClothManager-CompleteMasterJob0 = 107,
		BeyondDynamicBone-ColliderManager-EnableTeamCollider0 = 108,
		BeyondDynamicBone-ColliderManager-IsValid0 = 109,
		BeyondDynamicBone-TeamManager-GetTeamDataRef0 = 110,
		BeyondDynamicBone-TeamManager-TeamData-get_IsEnable0 = 111,
		BeyondDynamicBone-DynamicBoneTransformManager-EnableTransform0 = 112,
		BeyondDynamicBone-DynamicBoneTransformManager-EnableTransform1 = 113,
		BeyondDynamicBone-RenderManager-StartUse0 = 114,
		BeyondDynamicBone-RenderData-StartUse0 = 115,
		BeyondDynamicBone-RenderData-UpdateUse0 = 116,
		BeyondDynamicBone-ClothProcess-IsCameraCullingInvisible0 = 120,
		BeyondDynamicBone-ClothProcess-IsCameraCullingKeep0 = 121,
		BeyondDynamicBone-ClothProcess-IsDistanceCullingInvisible0 = 122,
		BeyondDynamicBone-RenderData-SwapOriginalMesh0 = 123,
		BeyondDynamicBone-RenderData-SetMesh0 = 124,
		BeyondDynamicBone-RenderData-SwapCustomMesh0 = 125,
		BeyondDynamicBone-RenderSetupData-IsFaild0 = 126,
		BeyondDynamicBone-RenderData-ResetCustomMeshWorkData0 = 127,
		BeyondDynamicBone-RenderSetupData-get_HasTangent0 = 128,
		BeyondDynamicBone-RenderSetupData-GetBoneWeightsRun0 = 129,
		BeyondDynamicBone-RenderManager-EndUse0 = 130,
		BeyondDynamicBone-RenderData-EndUse0 = 131,
		BeyondDynamicBone-BeyondBoneCloth-OnDisable0 = 132,
		BeyondDynamicBone-ClothProcess-EndUse0 = 133,
		BeyondDynamicBone-BeyondBoneCloth-Start0 = 134,
		BeyondDynamicBone-ClothProcess-AutoBuild0 = 135,
		BeyondDynamicBone-ClothProcess-PreBuildDataConstruction0 = 136,
		BeyondDynamicBone-PreBuildManager-GetPreBuildData0 = 137,
		BeyondDynamicBone-ClothManager-AddCloth0 = 140,
		BeyondDynamicBone-TeamManager-AddTeam0 = 141,
		BeyondDynamicBone-DynamicBoneTransformManager-AddComponentTransform0 = 142,
		BeyondDynamicBone-TeamManager-AddTeamAnimatorData0 = 144,
		BeyondDynamicBone-VirtualMeshManager-RegisterProxyMesh0 = 146,
		BeyondDynamicBone-DynamicBoneTransformManager-AddTransform0 = 147,
		BeyondDynamicBone-VirtualMeshContainer-GetTransformCount0 = 148,
		BeyondDynamicBone-VirtualMeshContainer-GetTransformFromIndex0 = 149,
		BeyondDynamicBone-TransformData-GetTransformFromIndex0 = 150,
		BeyondDynamicBone-TeamManager-AddAnimatorTransform0 = 151,
		BeyondDynamicBone-VirtualMesh-get_EdgeCount0 = 152,
		BeyondDynamicBone-VirtualMesh-get_BaseLineCount0 = 153,
		BeyondDynamicBone-SimulationManager-RegisterProxyMesh0 = 154,
		BeyondDynamicBone-ColliderManager-Register0 = 155,
		BeyondDynamicBone-DynamicBoneTransformManager-AddTransform1 = 156,
		BeyondDynamicBone-ColliderManager-InitColliders0 = 157,
		BeyondDynamicBone-ColliderManager-AddColliderInternal0 = 158,
		BeyondDynamicBone-ColliderComponent-IsReverseDirection0 = 159,
		BeyondDynamicBone-ColliderComponent-GetSize0 = 160,
		BeyondDynamicBone-ColliderComponent-Register0 = 161,
		BeyondDynamicBone-ClothProcess-get_IsEnable0 = 162,
		BeyondDynamicBone-TeamManager-IsEnable0 = 163,
		BeyondDynamicBone-DynamicBoneTransformManager-SetTransform0 = 164,
		BeyondDynamicBone-TeamManager-MarkAnimatorTransformDirty0 = 165,
		BeyondDynamicBone-SimulationManager-RegisterConstraint0 = 166,
		BeyondDynamicBone-DistanceConstraint-Register0 = 167,
		BeyondDynamicBone-DistanceConstraint-ConstraintData-IsValid0 = 168,
		BeyondDynamicBone-TriangleBendingConstraint-Register0 = 169,
		BeyondDynamicBone-TriangleBendingConstraint-ConstraintData-IsValid0 = 170,
		BeyondDynamicBone-InertiaConstraint-Register0 = 171,
		BeyondDynamicBone-SelfCollisionConstraint-Register0 = 172,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateTeam0 = 173,
		BeyondDynamicBone-TeamManager-ContainsTeamData0 = 174,
		BeyondDynamicBone-TeamManager-GetParametersRef0 = 175,
		BeyondDynamicBone-SelfCollisionConstraint-InitPrimitive0 = 176,
		BeyondDynamicBone-DataChunk-Clear0 = 179,
		BeyondDynamicBone-VirtualMesh-IsValid0 = 186,
		BeyondDynamicBone-VirtualMeshManager-RegisterMappingMesh0 = 187,
		BeyondDynamicBone-TeamManager-GetTeamMappingRef0 = 188,
		BeyondDynamicBone-VirtualMeshContainer-GetCenterTransform0 = 189,
		BeyondDynamicBone-VirtualMesh-GetCenterTransform0 = 190,
		BeyondDynamicBone-DynamicBoneTransformManager-AddTransform2 = 191,
		BeyondDynamicBone-VirtualMeshContainer-Dispose0 = 195,
		BeyondDynamicBone-VirtualMesh-Dispose0 = 196,
		BeyondDynamicBone-ResultCode-Clear0 = 197,
		BeyondDynamicBone-TransformData-Dispose0 = 198,
		BeyondDynamicBone-ResultCode-GetResultString0 = 200,
		BeyondDynamicBone-ResultCode-IsNormal0 = 201,
		BeyondDynamicBone-ClothProcess-StartRuntimeBuild0 = 202,
		BeyondDynamicBone-ClothProcess-RuntimeBuildAsync0 = 203,
		BeyondDynamicBone-DistanceConstraint-CreateData0 = 207,
		BeyondDynamicBone-ClothJobUtility-ToNativeMultiHashMap0 = 208,
		BeyondDynamicBone-MathUtility-GetUnuseTriangleIndex0 = 209,
		BeyondDynamicBone-TriangleBendingConstraint-CreateData0 = 210,
		BeyondDynamicBone-MathUtility-GetRestTriangleVertex0 = 211,
		BeyondDynamicBone-TriangleBendingConstraint-InitDihedralAngle0 = 212,
		BeyondDynamicBone-DataUtility-PackInt41 = 213,
		BeyondDynamicBone-DataUtility-PackInt40 = 214,
		BeyondDynamicBone-TriangleBendingConstraint-InitVolume0 = 215,
		BeyondDynamicBone-InertiaConstraint-CreateData0 = 216,
		BeyondDynamicBone-InertiaConstraint-CenterData-Initialize0 = 217,
		BeyondDynamicBone-VirtualMesh-SetTransform0 = 220,
		BeyondDynamicBone-TransformData-AddTransform0 = 221,
		BeyondDynamicBone-SelectionData-IsValid0 = 222,
		BeyondDynamicBone-RenderData-get_Name0 = 223,
		BeyondDynamicBone-VirtualMesh-ImportFrom1 = 224,
		BeyondDynamicBone-VirtualMesh-ImportFrom0 = 225,
		BeyondDynamicBone-TransformData-AddTransformRange0 = 226,
		BeyondDynamicBone-VirtualMesh-ImportMeshType0 = 227,
		BeyondDynamicBone-ClothJobUtility-SerialNumberRun0 = 228,
		BeyondDynamicBone-ClothJobUtility-FillRun0 = 229,
		BeyondDynamicBone-VirtualMesh-ImportMeshSkinning0 = 230,
		BeyondDynamicBone-VirtualMesh-ImportBoneType0 = 231,
		BeyondDynamicBone-RenderSetupData-GetParentTransformIndex0 = 232,
		BeyondDynamicBone-DataUtility-PackInt30 = 233,
		BeyondDynamicBone-ClothJobUtility-CalcAABBRun0 = 234,
		BeyondDynamicBone-ClothJobUtility-CalcUVWithSphereMappingRun0 = 235,
		BeyondDynamicBone-VirtualMesh-CalcAverageAndMaxVertexDistanceRun0 = 236,
		BeyondDynamicBone-ResultCode-IsNone0 = 237,
		BeyondDynamicBone-ClothProcess-GenerateSelectionDataFromVertexAttributeData0 = 238,
		BeyondDynamicBone-ClothJobUtility-TransformPositionRun0 = 239,
		BeyondDynamicBone-SelectionData-Merge0 = 240,
		BeyondDynamicBone-ClothProcess-GenerateSelectionDataFromPaintMap0 = 241,
		BeyondDynamicBone-VirtualMesh-CalcSelectionMergin0 = 242,
		BeyondDynamicBone-AABB-get_MaxSideLength0 = 243,
		BeyondDynamicBone-ReductionSettings-GetMaxConnectionDistance0 = 244,
		BeyondDynamicBone-VirtualMesh-SelectionMesh0 = 245,
		BeyondDynamicBone-SelectionData-GetPositionNativeArray0 = 246,
		BeyondDynamicBone-SelectionData-GetAttributeNativeArray0 = 247,
		BeyondDynamicBone-ClothJobUtility-TransformPositionRun1 = 248,
		BeyondDynamicBone-SelectionData-CreateGridMapRun0 = 249,
		BeyondDynamicBone-VirtualMesh-AddMesh0 = 250,
		BeyondDynamicBone-VirtualMesh-CenterTransformTo0 = 251,
		BeyondDynamicBone-VirtualMesh-CompareSpace0 = 252,
		BeyondDynamicBone-TransformData-AddTransform1 = 253,
		BeyondDynamicBone-SelectionData-Fill0 = 254,
		BeyondDynamicBone-RenderSetupData-GetTransformIndexFromId0 = 255,
		BeyondDynamicBone-VirtualMesh-Reduction0 = 256,
		BeyondDynamicBone-VirtualMesh-InitReductionWorkData0 = 257,
		BeyondDynamicBone-ClothJobUtility-FillRun1 = 258,
		BeyondDynamicBone-SameDistanceReduction-Reduction0 = 259,
		BeyondDynamicBone-SameDistanceReduction-UpdateJoinAndLink0 = 260,
		BeyondDynamicBone-SameDistanceReduction-UpdateReductionResultJob0 = 261,
		BeyondDynamicBone-StepReductionBase-Reduction0 = 262,
		BeyondDynamicBone-StepReductionBase-StepInitialize0 = 263,
		BeyondDynamicBone-StepReductionBase-InitStep0 = 264,
		BeyondDynamicBone-StepReductionBase-ReductionStep0 = 265,
		BeyondDynamicBone-StepReductionBase-PreReductionStep0 = 266,
		BeyondDynamicBone-StepReductionBase-CustomReductionStep0 = 267,
		BeyondDynamicBone-StepReductionBase-PostReductionStep0 = 268,
		BeyondDynamicBone-StepReductionBase-SortJoinEdge0 = 269,
		BeyondDynamicBone-StepReductionBase-DetermineJoinEdge0 = 270,
		BeyondDynamicBone-StepReductionBase-RunJoinEdge0 = 271,
		BeyondDynamicBone-StepReductionBase-UpdateJoinAndLink0 = 272,
		BeyondDynamicBone-StepReductionBase-IsEndStep0 = 273,
		BeyondDynamicBone-StepReductionBase-NextStep0 = 274,
		BeyondDynamicBone-StepReductionBase-UpdateReductionResultJob0 = 275,
		BeyondDynamicBone-VirtualMesh-Organization0 = 276,
		BeyondDynamicBone-VirtualMesh-OrganizationInit0 = 277,
		BeyondDynamicBone-VirtualMesh-OrganizationCreateRemapData0 = 278,
		BeyondDynamicBone-VirtualMesh-OrganizationCreateBasicData0 = 279,
		BeyondDynamicBone-VirtualMesh-OrganizationCreateLineTriangle0 = 280,
		BeyondDynamicBone-VirtualMesh-OrganizeStoreVirtualMesh0 = 281,
		BeyondDynamicBone-TransformData-OrganizeReductionTransform0 = 282,
		BeyondDynamicBone-ResultCode-SetCancel0 = 283,
		BeyondDynamicBone-VirtualMesh-Optimization0 = 284,
		BeyondDynamicBone-VirtualMesh-RemoveDuplicateTriangles0 = 285,
		BeyondDynamicBone-VirtualMesh-ApplySelectionAttribute0 = 286,
		BeyondDynamicBone-VirtualMesh-ConvertProxyMesh0 = 288,
		BeyondDynamicBone-VirtualMesh-SetCustomSkinningBones0 = 289,
		BeyondDynamicBone-TransformRecord-IsValid0 = 290,
		BeyondDynamicBone-ClothJobUtility-FillRun2 = 291,
		BeyondDynamicBone-VirtualMesh-OptimizeTriangleDirection0 = 292,
		BeyondDynamicBone-VirtualMesh-CalcTwoTriangleAngle0 = 293,
		BeyondDynamicBone-VirtualMesh-CheckTwoTriangleOpen0 = 294,
		BeyondDynamicBone-VirtualMesh-ProxyCreateFixedListAndAABB0 = 295,
		BeyondDynamicBone-VirtualMesh-CreateTransformBaseLine0 = 296,
		BeyondDynamicBone-VirtualMesh-CreateMeshBaseLine0 = 297,
		BeyondDynamicBone-VirtualMesh-ProxyNormalAdjustment0 = 298,
		BeyondDynamicBone-AABB-get_Center0 = 299,
		BeyondDynamicBone-VirtualMesh-CreateBaseLinePose0 = 300,
		BeyondDynamicBone-VirtualMesh-CreateVertexRootAndDepth0 = 301,
		BeyondDynamicBone-VirtualMesh-CreateCustomSkinning0 = 302,
		BeyondDynamicBone-VirtualMesh-Mapping0 = 303,
		BeyondDynamicBone-VirtualMesh-CreateVertexIndexGridMapRun0 = 304,
		BeyondDynamicBone-ClothProcess-IncrementSuspendCounter0 = 305,
		BeyondDynamicBone-ClothProcess-GeneratePaintMapDataList0 = 306,
		BeyondDynamicBone-SelectionData-Clone0 = 307,
		BeyondDynamicBone-Develop-LogWarning0 = 308,
		BeyondDynamicBone-ClothProcess-DecrementSuspendCounter0 = 309,
		BeyondDynamicBone-ClothProcess-DisposeInternal0 = 310,
		BeyondDynamicBone-SimulationManager-ExitProxyMesh0 = 311,
		BeyondDynamicBone-DistanceConstraint-Exit0 = 312,
		BeyondDynamicBone-TriangleBendingConstraint-Exit0 = 313,
		BeyondDynamicBone-InertiaConstraint-Exit0 = 314,
		BeyondDynamicBone-SelfCollisionConstraint-Exit0 = 315,
		BeyondDynamicBone-VirtualMeshManager-ExitProxyMesh0 = 316,
		BeyondDynamicBone-DynamicBoneTransformManager-RemoveTransform0 = 317,
		BeyondDynamicBone-VirtualMeshManager-ExitMappingMesh0 = 318,
		BeyondDynamicBone-ColliderManager-Exit0 = 319,
		BeyondDynamicBone-ColliderComponent-Exit0 = 320,
		BeyondDynamicBone-ClothManager-RemoveCloth0 = 321,
		BeyondDynamicBone-TeamManager-RemoveTeam0 = 322,
		BeyondDynamicBone-TeamManager-RemoveSyncParent0 = 323,
		BeyondDynamicBone-DynamicBoneTransformManager-RemoveComponentTransform0 = 324,
		BeyondDynamicBone-TeamManager-ClearTeamAnimatorData0 = 325,
		BeyondDynamicBone-RenderManager-RemoveRenderer0 = 326,
		BeyondDynamicBone-RenderData-RemoveReferenceCount0 = 327,
		BeyondDynamicBone-RenderData-Dispose0 = 328,
		BeyondDynamicBone-PreBuildManager-UnregisterPreBuildData0 = 329,
		BeyondDynamicBone-BeyondBoneCloth-OnDestroy0 = 331,
		BeyondDynamicBone-ClothProcess-Dispose0 = 332,
		BeyondDynamicBone-BeyondBoneCloth-GetMagicaHashCode0 = 333,
		BeyondDynamicBone-BeyondBoneCloth-Initialize0 = 334,
		BeyondDynamicBone-BeyondBoneCloth-DisableAutoBuild0 = 335,
		BeyondDynamicBone-BeyondBoneCloth-SetClothSimulateWeight0 = 336,
		BeyondDynamicBone-BeyondBoneCloth-SetCodeParamaterDirty0 = 337,
		BeyondDynamicBone-BeyondBoneCloth-SetClothSimulateWeightIgnorePlaying0 = 338,
		BeyondDynamicBone-BeyondBoneCloth-SetCodeParamaterDirtyIgnorePlaying0 = 339,
		BeyondDynamicBone-BeyondBoneCloth-SetClothStablizationTimeAfterResetIgnorePlaying0 = 340,
		BeyondDynamicBone-BeyondBoneCloth-SetAnimationPoseRatio0 = 341,
		BeyondDynamicBone-BeyondBoneCloth-BuildAndRun0 = 342,
		BeyondDynamicBone-ClothProcess-GenerateInitialization0 = 343,
		BeyondDynamicBone-SelectionData-IsUserEdit0 = 344,
		BeyondDynamicBone-ClothProcess-GenerateBoneClothSelection0 = 345,
		BeyondDynamicBone-BeyondBoneCloth-ReplaceTransform0 = 346,
		BeyondDynamicBone-ClothProcess-GetUsedTransform0 = 347,
		BeyondDynamicBone-RenderData-GetUsedTransform0 = 350,
		BeyondDynamicBone-RenderSetupData-GetUsedTransform0 = 351,
		BeyondDynamicBone-TransformRecord-GetUsedTransform0 = 353,
		BeyondDynamicBone-ClothSerializeData-GetUsedTransform0 = 354,
		BeyondDynamicBone-CustomSkinningSettings-GetUsedTransform0 = 355,
		BeyondDynamicBone-NormalAlignmentSettings-GetUsedTransform0 = 356,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-GetUsedTransform0 = 357,
		BeyondDynamicBone-ClothSerializeData2-GetUsedTransform0 = 358,
		BeyondDynamicBone-PreBuildSerializeData-GetUsedTransform0 = 359,
		BeyondDynamicBone-UniquePreBuildData-GetUsedTransform0 = 360,
		BeyondDynamicBone-RenderSetupData-UniqueSerializationData-GetUsedTransform0 = 363,
		BeyondDynamicBone-VirtualMesh-UniqueSerializationData-GetUsedTransform0 = 367,
		BeyondDynamicBone-TransformData-UniqueSerializationData-GetUsedTransform0 = 368,
		BeyondDynamicBone-ClothProcess-ReplaceTransform0 = 369,
		BeyondDynamicBone-RenderData-ReplaceTransform0 = 372,
		BeyondDynamicBone-RenderSetupData-ReplaceTransform0 = 373,
		BeyondDynamicBone-TransformRecord-ReplaceTransform0 = 375,
		BeyondDynamicBone-ClothSerializeData-ReplaceTransform0 = 376,
		BeyondDynamicBone-CustomSkinningSettings-ReplaceTransform0 = 377,
		BeyondDynamicBone-NormalAlignmentSettings-ReplaceTransform0 = 378,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-ReplaceTransform0 = 379,
		BeyondDynamicBone-ClothSerializeData2-ReplaceTransform0 = 380,
		BeyondDynamicBone-PreBuildSerializeData-ReplaceTransform0 = 381,
		BeyondDynamicBone-UniquePreBuildData-ReplaceTransform0 = 382,
		BeyondDynamicBone-RenderSetupData-UniqueSerializationData-ReplaceTransform0 = 385,
		BeyondDynamicBone-VirtualMesh-UniqueSerializationData-ReplaceTransform0 = 387,
		BeyondDynamicBone-TransformData-UniqueSerializationData-ReplaceTransform0 = 388,
		BeyondDynamicBone-BeyondBoneCloth-SetTimeScale0 = 389,
		BeyondDynamicBone-BeyondBoneCloth-GetTimeScale0 = 390,
		BeyondDynamicBone-BeyondBoneCloth-ResetCloth0 = 391,
		BeyondDynamicBone-ClothProcess-UpdateRendererUse0 = 392,
		BeyondDynamicBone-BeyondBoneCloth-SoftResetCloth0 = 393,
		BeyondDynamicBone-BeyondBoneCloth-GetCenterPosition0 = 394,
		BeyondDynamicBone-TeamManager-GetCenterDataRef0 = 395,
		BeyondDynamicBone-BeyondBoneCloth-AddForce0 = 396,
		BeyondDynamicBone-BeyondBoneCloth-SetSkipWriting0 = 397,
		BeyondDynamicBone-ClothProcess-SetSkipWriting0 = 398,
		BeyondDynamicBone-CheckSliderSerializeData-SetValue0 = 399,
		BeyondDynamicBone-CheckSliderSerializeData-Clone0 = 400,
		BeyondDynamicBone-ClothBehaviour-GetMagicaHashCode0 = 401,
		BeyondDynamicBone-ClothBehaviour-OnDrawGizmos0 = 402,
		BeyondDynamicBone-ClothProcess-GetColliderIndex0 = 404,
		BeyondDynamicBone-ClothProcess-UpdateCullingAnimatorAndRenderers0 = 405,
		BeyondDynamicBone-ClothProcess-GetStateFlag0 = 406,
		BeyondDynamicBone-ClothProcess-IsRunning0 = 407,
		BeyondDynamicBone-ClothProcess-IsLodCulled0 = 408,
		BeyondDynamicBone-ClothProcess-IsSkipWriting0 = 409,
		BeyondDynamicBone-ClothProcess-IsUpdateTangent0 = 410,
		BeyondDynamicBone-ClothProcess-get_HasProxyMesh0 = 411,
		BeyondDynamicBone-ClothProcess-get_Name0 = 412,
		BeyondDynamicBone-ClothProcess-GetSuspendCounter0 = 413,
		BeyondDynamicBone-ClothProcess-GetRenderMeshInfo0 = 414,
		BeyondDynamicBone-ClothProcess-SyncParameters0 = 415,
		BeyondDynamicBone-ClothProcess-GetClothUpdateMode0 = 416,
		BeyondDynamicBone-ClothProcess-GenerateSelectionJob-Execute0 = 417,
		BeyondDynamicBone-ClothSerializeData-GetHashCode0 = 418,
		BeyondDynamicBone-ClothSerializeData-ExportJson0 = 419,
		BeyondDynamicBone-ClothSerializeData-ImportJson0 = 420,
		BeyondDynamicBone-ClothSerializeData-TempBuffer-Pop0 = 421,
		BeyondDynamicBone-ClothSerializeData-Import0 = 422,
		BeyondDynamicBone-ReductionSettings-Clone0 = 423,
		BeyondDynamicBone-CustomSkinningSettings-Clone0 = 424,
		BeyondDynamicBone-NormalAlignmentSettings-Clone0 = 425,
		BeyondDynamicBone-CullingSettings-Clone0 = 426,
		BeyondDynamicBone-CurveSerializeData-Clone0 = 427,
		BeyondDynamicBone-InertiaConstraint-SerializeData-Clone0 = 428,
		BeyondDynamicBone-TetherConstraint-SerializeData-Clone0 = 429,
		BeyondDynamicBone-DistanceConstraint-SerializeData-Clone0 = 430,
		BeyondDynamicBone-TriangleBendingConstraint-SerializeData-Clone0 = 431,
		BeyondDynamicBone-AngleConstraint-RestorationSerializeData-Clone0 = 432,
		BeyondDynamicBone-AngleConstraint-LimitSerializeData-Clone0 = 433,
		BeyondDynamicBone-MotionConstraint-SerializeData-Clone0 = 434,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-Clone0 = 435,
		BeyondDynamicBone-SelfCollisionConstraint-SerializeData-Clone0 = 436,
		BeyondDynamicBone-WindSettings-Clone0 = 437,
		BeyondDynamicBone-ClothSerializeData-Import1 = 438,
		BeyondDynamicBone-ClothSerializeData-TempBuffer-Push0 = 439,
		BeyondDynamicBone-ClothSerializeData2-IsValid0 = 440,
		BeyondDynamicBone-ClothSerializeData2-GetHashCode0 = 441,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-GetColliderType0 = 442,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-SetSize0 = 443,
		BeyondDynamicBone-ColliderComponent-SetSize0 = 444,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-GetSize0 = 445,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-GetLocalDir0 = 446,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-GetLocalUp0 = 447,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-IsReverseDirection0 = 448,
		BeyondDynamicBone-BeyondBoneCapsuleCollider-DataValidate0 = 449,
		BeyondDynamicBone-BeyondBonePlaneCollider-GetColliderType0 = 450,
		BeyondDynamicBone-BeyondBonePlaneCollider-DataValidate0 = 451,
		BeyondDynamicBone-BeyondBoneSphereCollider-GetColliderType0 = 452,
		BeyondDynamicBone-BeyondBoneSphereCollider-DataValidate0 = 453,
		BeyondDynamicBone-BeyondBoneSphereCollider-SetSize0 = 454,
		BeyondDynamicBone-ColliderComponent-SetSizeX0 = 455,
		BeyondDynamicBone-ColliderComponent-SetSizeY0 = 456,
		BeyondDynamicBone-ColliderComponent-SetSizeZ0 = 457,
		BeyondDynamicBone-ColliderComponent-GetScale0 = 458,
		BeyondDynamicBone-ColliderComponent-UpdateParameters0 = 459,
		BeyondDynamicBone-ColliderManager-UpdateParameters0 = 460,
		BeyondDynamicBone-TeamManager-GetClothProcess0 = 461,
		BeyondDynamicBone-ColliderComponent-Start0 = 462,
		BeyondDynamicBone-ColliderComponent-OnValidate0 = 463,
		BeyondDynamicBone-ColliderComponent-OnEnable0 = 464,
		BeyondDynamicBone-ColliderManager-EnableCollider0 = 465,
		BeyondDynamicBone-ColliderComponent-OnDisable0 = 466,
		BeyondDynamicBone-ColliderComponent-OnDestroy0 = 467,
		BeyondDynamicBone-ColliderManager-RemoveCollider0 = 468,
		BeyondDynamicBone-DynamicBoneTransformManager-CopyTransform0 = 469,
		BeyondDynamicBone-AngleConstraint-Dispose0 = 470,
		BeyondDynamicBone-AngleConstraint-WorkBufferUpdate0 = 471,
		BeyondDynamicBone-AngleConstraint-ToString0 = 472,
		BeyondDynamicBone-AngleConstraint-SolverConstraint0 = 473,
		BeyondDynamicBone-AngleConstraint-AngleConstraintJob-SetIndexCount0 = 475,
		BeyondDynamicBone-AngleConstraint-AngleConstraintJob-Execute1 = 476,
		BeyondDynamicBone-AngleConstraint-AngleConstraintJob-Execute0 = 477,
		BeyondDynamicBone-MathUtility-ClampAngle0 = 478,
		BeyondDynamicBone-MathUtility-FromToRotation0 = 479,
		BeyondDynamicBone-AngleConstraint-AngleConstraintJob-UnsafeDo0 = 480,
		BeyondDynamicBone-ColliderCollisionConstraint-Dispose0 = 481,
		BeyondDynamicBone-ColliderCollisionConstraint-WorkBufferUpdate0 = 482,
		BeyondDynamicBone-ColliderCollisionConstraint-ToString0 = 483,
		BeyondDynamicBone-ColliderCollisionConstraint-SolverConstraint0 = 484,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB$BurstDirectCall0 = 485,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC$BurstDirectCall0 = 486,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0$BurstDirectCall0 = 487,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1$BurstDirectCall0 = 488,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5$BurstDirectCall0 = 489,
		BeyondDynamicBone-ColliderCollisionConstraint-Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6$BurstDirectCall0 = 490,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointSphereColliderDetection0 = 491,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointPlaneColliderDetction0 = 492,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointCapsuleColliderDetection0 = 493,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgeSphereColliderDetection0 = 494,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgeCapsuleColliderDetection0 = 495,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgePlaneColliderDetection0 = 496,
		BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-GetHashCode0 = 497,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-SetIndexCount0 = 498,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-Execute1 = 499,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-Execute0 = 500,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointSphereColliderDetection0 = 501,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointCapsuleColliderDetection0 = 502,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointPlaneColliderDetction0 = 503,
		BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-UnsafeDo0 = 504,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-SetIndexCount0 = 505,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-Execute1 = 506,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-Execute0 = 507,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgeSphereColliderDetection0 = 508,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgeCapsuleColliderDetection0 = 509,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgePlaneColliderDetection0 = 510,
		BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-UnsafeDo0 = 511,
		BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-SetIndexCount0 = 512,
		BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-Execute1 = 513,
		BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-Execute0 = 514,
		BeyondDynamicBone-InterlockUtility-ReadAverageFloat30 = 515,
		BeyondDynamicBone-InterlockUtility-ReadFloat0 = 516,
		BeyondDynamicBone-InterlockUtility-ReadFloat30 = 517,
		BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-UnsafeDo0 = 518,
		BeyondDynamicBone-DistanceConstraint-Dispose0 = 519,
		BeyondDynamicBone-DistanceConstraint-ToString0 = 520,
		BeyondDynamicBone-DistanceConstraint-SolverConstraint0 = 521,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-SetIndexCount0 = 522,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-Execute1 = 523,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-Execute0 = 524,
		BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-UnsafeDo0 = 525,
		BeyondDynamicBone-InertiaConstraint-Dispose0 = 526,
		BeyondDynamicBone-InertiaConstraint-ToString0 = 527,
		BeyondDynamicBone-MotionConstraint-Dispose0 = 528,
		BeyondDynamicBone-MotionConstraint-SolverConstraint0 = 529,
		BeyondDynamicBone-MotionConstraint-MotionConstraintJob-SetIndexCount0 = 530,
		BeyondDynamicBone-MotionConstraint-MotionConstraintJob-Execute1 = 531,
		BeyondDynamicBone-MotionConstraint-MotionConstraintJob-Execute0 = 532,
		BeyondDynamicBone-MotionConstraint-MotionConstraintJob-UnsafeDo0 = 533,
		BeyondDynamicBone-SelfCollisionConstraint-Dispose0 = 534,
		BeyondDynamicBone-SelfCollisionConstraint-HasPrimitive0 = 535,
		BeyondDynamicBone-SelfCollisionConstraint-ToString0 = 536,
		BeyondDynamicBone-SelfCollisionConstraint-WorkBufferUpdate0 = 537,
		BeyondDynamicBone-SelfCollisionConstraint-BinarySearchSortAndlSweep0 = 538,
		BeyondDynamicBone-SelfCollisionConstraint-SolverConstraint0 = 539,
		BeyondDynamicBone-SelfCollisionConstraint-SolverRuntimeSelfCollision0 = 540,
		BeyondDynamicBone-SelfCollisionConstraint-SolverBroadPhase0 = 541,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateBroadPhase0 = 542,
		BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear1 = 543,
		BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear0 = 544,
		BeyondDynamicBone-SelfCollisionConstraint-SolveIntersect0 = 545,
		BeyondDynamicBone-ClothJobUtility-Fill0 = 546,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145$BurstDirectCall0 = 548,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146$BurstDirectCall0 = 549,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147$BurstDirectCall0 = 550,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148$BurstDirectCall0 = 551,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$ClearBufferJobKernels_ClearBufferKernel_00000149$BurstDirectCall0 = 552,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SortJobKernels_SortKernel_0000014A$BurstDirectCall0 = 553,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SortJobKernels_SortRangeKernel_0000014B$BurstDirectCall0 = 554,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E$BurstDirectCall0 = 555,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F$BurstDirectCall0 = 556,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180$BurstDirectCall0 = 557,
		BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181$BurstDirectCall0 = 558,
		BeyondDynamicBone-SelfCollisionConstraint-SortData-CompareTo0 = 559,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeContact-ToString0 = 560,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleContact-ToString0 = 561,
		BeyondDynamicBone-SelfCollisionConstraint-InitPrimitiveJob-Execute0 = 562,
		BeyondDynamicBone-SelfCollisionConstraint-ClearBufferJob-Execute0 = 563,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-SetIndexCount0 = 564,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-Execute1 = 565,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-Execute0 = 566,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-UnsafeDo0 = 567,
		BeyondDynamicBone-SelfCollisionConstraint-SortJob-SetIndexCount0 = 568,
		BeyondDynamicBone-SelfCollisionConstraint-SortJob-Execute1 = 569,
		BeyondDynamicBone-SelfCollisionConstraint-SortJob-Execute0 = 570,
		BeyondDynamicBone-TeamManager-TeamData-get_IsProcess0 = 571,
		BeyondDynamicBone-SelfCollisionConstraint-SortJob-UnsafeDo0 = 572,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-SetIndexCount0 = 573,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-Execute1 = 574,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-Execute0 = 575,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-SweepTest0 = 576,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-BroadPointTriangle0 = 577,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-SetIndexCount0 = 578,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-Execute1 = 579,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-Execute0 = 580,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-SweepTest0 = 581,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-BroadEdgeEdge0 = 582,
		BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeToListJob-Execute0 = 583,
		BeyondDynamicBone-SelfCollisionConstraint-PointTriangleToListJob-Execute0 = 584,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseJob-Execute0 = 585,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseJob-Execute0 = 586,
		BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeJob-Execute0 = 587,
		BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleJob-Execute0 = 588,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-SetIndexCount0 = 589,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-Execute1 = 590,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-Execute0 = 591,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-UnsafeDo0 = 592,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-SetIndexCount0 = 593,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-Execute1 = 594,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-Execute0 = 595,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-SweepTest0 = 596,
		BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-IntersectTest0 = 597,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseCrossFrameJob-Execute0 = 598,
		BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseCrossFrameJob-Execute1 = 599,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseCrossFrameJob-Execute0 = 600,
		BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseCrossFrameJob-Execute1 = 601,
		BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-Execute0 = 602,
		BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-Execute1 = 603,
		BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-UnsafeDo0 = 604,
		BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-Execute0 = 605,
		BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-Execute1 = 606,
		BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-UnsafeDo0 = 607,
		BeyondDynamicBone-SpringConstraint-Dispose0 = 608,
		BeyondDynamicBone-SpringConstraint-SolverConstraint0 = 609,
		BeyondDynamicBone-SpringConstraint-SerializeData-DataValidate0 = 610,
		BeyondDynamicBone-SpringConstraint-SerializeData-Clone0 = 611,
		BeyondDynamicBone-TetherConstraint-Dispose0 = 612,
		BeyondDynamicBone-TetherConstraint-SolverConstraint0 = 613,
		BeyondDynamicBone-TetherConstraint-TethreConstraintJob-SetIndexCount0 = 614,
		BeyondDynamicBone-TetherConstraint-TethreConstraintJob-Execute1 = 615,
		BeyondDynamicBone-TetherConstraint-TethreConstraintJob-Execute0 = 616,
		BeyondDynamicBone-TetherConstraint-TethreConstraintJob-UnsafeDo0 = 617,
		BeyondDynamicBone-TriangleBendingConstraint-Dispose0 = 618,
		BeyondDynamicBone-TriangleBendingConstraint-ToString0 = 619,
		BeyondDynamicBone-TriangleBendingConstraint-SolverConstraint0 = 620,
		BeyondDynamicBone-TriangleBendingConstraint-Initialize$TriangleBendingJobKernels_TriangleBendingKernel_000001AA$BurstDirectCall0 = 621,
		BeyondDynamicBone-TriangleBendingConstraint-Initialize$TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB$BurstDirectCall0 = 622,
		BeyondDynamicBone-TriangleBendingConstraint-Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE$BurstDirectCall0 = 623,
		BeyondDynamicBone-TriangleBendingConstraint-Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF$BurstDirectCall0 = 624,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJobKernels-Volume0 = 625,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJobKernels-DihedralAngle0 = 626,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-SetIndexCount0 = 627,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Execute1 = 628,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Execute0 = 629,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Volume0 = 630,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-DihedralAngle0 = 631,
		BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-UnsafeDo0 = 632,
		BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-SetIndexCount0 = 633,
		BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-Execute1 = 634,
		BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-Execute0 = 635,
		BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-UnsafeDo0 = 636,
		BeyondDynamicBone-CullingSettings-GetHashCode0 = 637,
		BeyondDynamicBone-CurveSerializeData-SetValue0 = 638,
		BeyondDynamicBone-CurveSerializeData-SetValue1 = 639,
		BeyondDynamicBone-CurveSerializeData-SetValue2 = 640,
		BeyondDynamicBone-CurveSerializeData-Evaluate0 = 641,
		BeyondDynamicBone-CustomSkinningSettings-IsValid0 = 642,
		BeyondDynamicBone-CustomSkinningSettings-GetHashCode0 = 646,
		BeyondDynamicBone-GizmoSerializeData-IsAlways0 = 647,
		BeyondDynamicBone-NormalAlignmentSettings-IsValid0 = 648,
		BeyondDynamicBone-NormalAlignmentSettings-GetHashCode0 = 649,
		BeyondDynamicBone-SelectionData-Compare0 = 650,
		BeyondDynamicBone-SelectionData-AddRange0 = 651,
		BeyondDynamicBone-SelectionData-GetPositionNativeArray1 = 652,
		BeyondDynamicBone-SelectionData-ConvertFrom0 = 653,
		BeyondDynamicBone-SelectionData-TransformPositionJob-Execute0 = 654,
		BeyondDynamicBone-SelectionData-CreateGridMapJob-Execute0 = 655,
		BeyondDynamicBone-SelectionData-ConvertSelectionJob-Execute0 = 656,
		BeyondDynamicBone-BeyondBoneWindZone-Awake0 = 657,
		BeyondDynamicBone-WindManager-AddWind0 = 658,
		BeyondDynamicBone-BeyondBoneWindZone-Start0 = 660,
		BeyondDynamicBone-BeyondBoneWindZone-OnEnable0 = 661,
		BeyondDynamicBone-WindManager-SetEnable0 = 663,
		BeyondDynamicBone-BeyondBoneWindZone-OnDisable0 = 664,
		BeyondDynamicBone-BeyondBoneWindZone-OnDestroy0 = 665,
		BeyondDynamicBone-WindManager-RemoveWind0 = 666,
		BeyondDynamicBone-BeyondBoneWindZone-IsDirection0 = 667,
		BeyondDynamicBone-BeyondBoneWindZone-IsRadial0 = 668,
		BeyondDynamicBone-BeyondBoneWindZone-IsAddition0 = 669,
		BeyondDynamicBone-BeyondBoneWindZone-GetWindDirection0 = 670,
		BeyondDynamicBone-BeyondBoneWindZone-SetWindDirection0 = 671,
		BeyondDynamicBone-WindParams-IsValid0 = 672,
		BeyondDynamicBone-WindSettings-IsValid0 = 673,
		BeyondDynamicBone-ClothManager-Dispose0 = 674,
		BeyondDynamicBone-ClothManager-OnEarlyClothUpdate0 = 675,
		BeyondDynamicBone-TeamManager-CameraCullingPostProcess0 = 676,
		BeyondDynamicBone-ClothManager-ClearVisibleDict0 = 677,
		BeyondDynamicBone-ClothManager-CheckVisible0 = 678,
		BeyondDynamicBone-ClothManager-CheckRendererVisible0 = 679,
		BeyondDynamicBone-ClothManager-CheckLODVisible0 = 680,
		BeyondDynamicBone-DynamicBoneTransformManager-RestoreTransform0 = 681,
		BeyondDynamicBone-ClothManager-OnAfterUpdate0 = 682,
		BeyondDynamicBone-TeamManager-UpdateTeamAnimatorData0 = 683,
		BeyondDynamicBone-ClothManager-OnAfterLateUpdate0 = 684,
		BeyondDynamicBone-ClothManager-ClothUpdate0 = 685,
		BeyondDynamicBone-TimeManager-FrameUpdate0 = 686,
		BeyondDynamicBone-TeamManager-AlwaysTeamUpdate0 = 691,
		BeyondDynamicBone-ColliderManager-UpdateColliders0 = 692,
		BeyondDynamicBone-ColliderManager-AddCollider0 = 693,
		BeyondDynamicBone-DynamicBoneTransformManager-Expand0 = 694,
		BeyondDynamicBone-RenderData-UpdateSkipWriting0 = 695,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadComponentTransform0 = 696,
		BeyondDynamicBone-TimeManager-GetDeltaTime0 = 697,
		BeyondDynamicBone-TimeManager-GetFixedDeltaTime0 = 701,
		BeyondDynamicBone-TimeManager-GetUnscaledDeltaTime0 = 703,
		BeyondDynamicBone-WindManager-AlwaysWindUpdate0 = 705,
		BeyondDynamicBone-SimulationManager-WorkBufferUpdate0 = 706,
		BeyondDynamicBone-ClothManager-ClearMasterJob0 = 707,
		BeyondDynamicBone-VirtualMeshManager-UpdateBuffer0 = 708,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferData0 = 709,
		BeyondDynamicBone-TeamManager-CameraCullingPreProcess0 = 710,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadTransform0 = 711,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteDoubleBufferTransform0 = 712,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidPosition0 = 713,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-SetIndexCount0 = 714,
		BeyondDynamicBone-VirtualMeshManager-PreProxyMeshUpdate0 = 715,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWind0 = 716,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdate0 = 717,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdate0 = 718,
		BeyondDynamicBone-SimulationManager-SimulationStepUpdate0 = 719,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdate0 = 721,
		BeyondDynamicBone-ColliderManager-CreateUpdateColliderList0 = 722,
		BeyondDynamicBone-ColliderManager-StartSimulationStep0 = 723,
		BeyondDynamicBone-ColliderManager-EndSimulationStep0 = 724,
		BeyondDynamicBone-SimulationManager-CalcDisplayPosition0 = 725,
		BeyondDynamicBone-VirtualMeshManager-PostProxyMeshUpdate0 = 726,
		BeyondDynamicBone-VirtualMeshManager-PostMappingMeshUpdate0 = 727,
		BeyondDynamicBone-RenderData-UpdatePositionNormal0 = 728,
		BeyondDynamicBone-RenderData-UpdateBoneWeight0 = 729,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferData0 = 730,
		BeyondDynamicBone-DynamicBoneTransformManager-CopyDoubleBuffer0 = 731,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteTransform0 = 732,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdate0 = 733,
		BeyondDynamicBone-TeamManager-PostTeamUpdate0 = 734,
		BeyondDynamicBone-ClothManager-OnBeforeLateUpdate0 = 735,
		BeyondDynamicBone-ClothManager-OnApplicationQuit0 = 736,
		BeyondDynamicBone-ClothManager-EnterdEditMode0 = 737,
		BeyondDynamicBone-ClothManager-Initialize0 = 738,
		BeyondDynamicBone-ClothManager-IsValid0 = 739,
		BeyondDynamicBone-ClothManager-InformationLog0 = 740,
		BeyondDynamicBone-PreBuildManager-Dispose0 = 741,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-Dispose0 = 742,
		BeyondDynamicBone-PreBuildManager-EnterdEditMode0 = 743,
		BeyondDynamicBone-PreBuildManager-Initialize0 = 744,
		BeyondDynamicBone-PreBuildManager-IsValid0 = 745,
		BeyondDynamicBone-PreBuildManager-InformationLog0 = 746,
		BeyondDynamicBone-PreBuildManager-UnloadUnusedData0 = 747,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-GetProxyMeshContainer0 = 748,
		BeyondDynamicBone-PreBuildManager-ShareDeserializationData-GetRenderMeshContainer0 = 749,
		BeyondDynamicBone-DoAllInOneJob-Execute0 = 750,
		BeyondDynamicBone-DynamicBoneTransformManager-Dispose0 = 751,
		BeyondDynamicBone-DynamicBoneTransformManager-EnterdEditMode0 = 752,
		BeyondDynamicBone-DynamicBoneTransformManager-Initialize0 = 753,
		BeyondDynamicBone-DynamicBoneTransformManager-IsValid0 = 754,
		BeyondDynamicBone-DynamicBoneTransformManager-InformationLog0 = 755,
		BeyondDynamicBone-DynamicBoneTransformManager-Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C$BurstDirectCall0 = 756,
		BeyondDynamicBone-DynamicBoneTransformManager-Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D$BurstDirectCall0 = 757,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferDataJob-Execute0 = 758,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferDataJob-_Do0 = 759,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferDataJob-Execute0 = 760,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferDataJob-UnsafeDo0 = 761,
		BeyondDynamicBone-DynamicBoneTransformManager-CopyDoubleBufferJob-Execute0 = 762,
		BeyondDynamicBone-DynamicBoneTransformManager-EnableTransformJob-Execute0 = 763,
		BeyondDynamicBone-DynamicBoneTransformManager-RestoreTransformJob-Execute0 = 764,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadTransformJob-Execute0 = 765,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-Execute1 = 766,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-Execute0 = 767,
		BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-UnsafeDo0 = 768,
		BeyondDynamicBone-DynamicBoneTransformManager-WriteTransformJob-Execute0 = 769,
		BeyondDynamicBone-DynamicBoneTransformManager-ReadComponentTransformJob-Execute0 = 770,
		BeyondDynamicBone-TeamManager-Dispose0 = 771,
		BeyondDynamicBone-TeamManager-MonitoringProcess0 = 772,
		BeyondDynamicBone-TeamManager-MonitoringProcessUpdate0 = 776,
		BeyondDynamicBone-TeamManager-EnterdEditMode0 = 777,
		BeyondDynamicBone-TeamManager-Initialize0 = 778,
		BeyondDynamicBone-TeamManager-IsValid0 = 779,
		BeyondDynamicBone-TeamManager-SetSkipWriting0 = 780,
		BeyondDynamicBone-TeamManager-InformationLog0 = 781,
		BeyondDynamicBone-TeamWindInfo-ToString0 = 782,
		BeyondDynamicBone-TeamManager-Initialize$PostTeamUpdateJobKernels_PostTeamUpdateKernel_00000298$BurstDirectCall0 = 783,
		BeyondDynamicBone-TeamManager-Initialize$PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_00000299$BurstDirectCall0 = 784,
		BeyondDynamicBone-TeamManager-MappingData-IsValid0 = 785,
		BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePreJob-Execute0 = 786,
		BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePostJob-Execute0 = 787,
		BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePostJob-DistanceCullingUpdate0 = 788,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-SetIndexCount0 = 789,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Execute1 = 790,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Execute0 = 791,
		BeyondDynamicBone-MathUtility-ShiftPosition0 = 792,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Wind0 = 793,
		BeyondDynamicBone-WindManager-WindData-IsValid0 = 794,
		BeyondDynamicBone-WindManager-WindData-IsEnable0 = 795,
		BeyondDynamicBone-WindManager-WindData-IsAddition0 = 796,
		BeyondDynamicBone-TeamWindData-AddOrReplaceWindZone0 = 797,
		BeyondDynamicBone-TeamWindInfo-IsValid0 = 798,
		BeyondDynamicBone-TeamWindData-IndexOf0 = 799,
		BeyondDynamicBone-TeamWindData-RemoveWindZone0 = 800,
		BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-UnsafeDo0 = 801,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-SetIndexCount0 = 802,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-Execute1 = 803,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-Execute0 = 804,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UpdateWind0 = 805,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UpdateWindTime0 = 806,
		BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UnsafeDo0 = 807,
		BeyondDynamicBone-TeamManager-PostTeamUpdateJob-SetIndexCount0 = 808,
		BeyondDynamicBone-TeamManager-PostTeamUpdateJob-Execute1 = 809,
		BeyondDynamicBone-TeamManager-PostTeamUpdateJob-Execute0 = 810,
		BeyondDynamicBone-TeamManager-PostTeamUpdateJob-UnsafeDo0 = 811,
		BeyondDynamicBone-VirtualMeshManager-Dispose0 = 812,
		BeyondDynamicBone-VirtualMeshManager-EnterdEditMode0 = 813,
		BeyondDynamicBone-VirtualMeshManager-Initialize0 = 814,
		BeyondDynamicBone-VirtualMeshManager-IsValid0 = 815,
		BeyondDynamicBone-VirtualMeshManager-InformationLog0 = 816,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E6$BurstDirectCall0 = 817,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E7$BurstDirectCall0 = 818,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002E8$BurstDirectCall0 = 819,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002E9$BurstDirectCall0 = 820,
		BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformDataJobKernels_WriteTransformDataKernel_000002EA$BurstDirectCall0 = 821,
		BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002EB$BurstDirectCall0 = 822,
		BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EC$BurstDirectCall0 = 823,
		BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002ED$BurstDirectCall0 = 824,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002EE$BurstDirectCall0 = 825,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002EF$BurstDirectCall0 = 826,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F0$BurstDirectCall0 = 827,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F1$BurstDirectCall0 = 828,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F2$BurstDirectCall0 = 829,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F3$BurstDirectCall0 = 830,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F4$BurstDirectCall0 = 831,
		BeyondDynamicBone-VirtualMeshManager-Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$BurstDirectCall0 = 832,
		BeyondDynamicBone-VirtualMeshManager-Initialize$ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F6$BurstDirectCall0 = 833,
		BeyondDynamicBone-VirtualMeshManager-ClearProxyMeshUpdateBufferJob-Execute0 = 834,
		BeyondDynamicBone-VirtualMeshManager-ClearProxyMeshUpdateBufferJob-UnsafeDo0 = 835,
		BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-SetIndexCount0 = 836,
		BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-Execute1 = 837,
		BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-Execute0 = 838,
		BeyondDynamicBone-NativeReferenceExtensions-MC2InterlockedStartIndex0 = 839,
		BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-UnsafeDo0 = 840,
		BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-SetIndexCount0 = 841,
		BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-Execute1 = 842,
		BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-Execute0 = 843,
		BeyondDynamicBone-VirtualMeshBoneWeight-get_Count0 = 844,
		BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-UnsafeDo0 = 845,
		BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-SetIndexCount0 = 846,
		BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-Execute1 = 847,
		BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-Execute0 = 848,
		BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-UnsafeDo0 = 849,
		BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-SetIndexCount0 = 850,
		BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-Execute1 = 851,
		BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-Execute0 = 852,
		BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-UnsafeDo0 = 853,
		BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-SetIndexCount0 = 854,
		BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-Execute1 = 855,
		BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-Execute0 = 856,
		BeyondDynamicBone-MathUtility-TriangleTangent0 = 857,
		BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-UnsafeDo0 = 858,
		BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-SetIndexCount0 = 859,
		BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-Execute1 = 860,
		BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-Execute0 = 861,
		BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-UnsafeDo0 = 862,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-SetIndexCount0 = 863,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-Execute1 = 864,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-Execute0 = 865,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-UnsafeDo0 = 866,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-SetIndexCount0 = 867,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-Execute1 = 868,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-Execute0 = 869,
		BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-UnsafeDo0 = 870,
		BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-SetIndexCount0 = 871,
		BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-Execute1 = 872,
		BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-Execute0 = 873,
		BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-UnsafeDo0 = 874,
		BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-SetIndexCount0 = 875,
		BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-Execute1 = 876,
		BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-Execute0 = 877,
		BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-UnsafeDo0 = 878,
		BeyondDynamicBone-MagicaManager-Initialize0 = 879,
		BeyondDynamicBone-MagicaManager-Dispose0 = 880,
		BeyondDynamicBone-MagicaManager-InitCustomGameLoop0 = 881,
		BeyondDynamicBone-MagicaManager-CheckRegist0 = 882,
		BeyondDynamicBone-MagicaManager-SetCustomGameLoop0 = 885,
		BeyondDynamicBone-PlayerLoopUtils-AddPlayerLoop0 = 896,
		BeyondDynamicBone-MagicaManager-SetUseCrossFrameJob0 = 900,
		BeyondDynamicBone-MagicaManager-SetGlobalTimeScale0 = 901,
		BeyondDynamicBone-MagicaManager-GetGlobalTimeScale0 = 902,
		BeyondDynamicBone-MagicaManager-SetSimulationFrequency0 = 903,
		BeyondDynamicBone-MagicaManager-SetAOVMode0 = 904,
		BeyondDynamicBone-MagicaManager-DoAOVUpdate0 = 909,
		BeyondDynamicBone-MagicaManager-DoAOVAfterAnimatorUpdate0 = 910,
		BeyondDynamicBone-MagicaManager-GetSimulationFrequency0 = 911,
		BeyondDynamicBone-MagicaManager-SetMaxSimulationCountPerFrame0 = 912,
		BeyondDynamicBone-MagicaManager-GetMaxSimulationCountPerFrame0 = 913,
		BeyondDynamicBone-MagicaManager-SetUpdateLocation0 = 914,
		BeyondDynamicBone-MagicaManager-GetUpdateLocation0 = 915,
		BeyondDynamicBone-MagicaManager-UnloadUnusedData0 = 916,
		BeyondDynamicBone-MagicaManager-SetInitializationLocation0 = 917,
		BeyondDynamicBone-MagicaSettings-Awake0 = 918,
		BeyondDynamicBone-MagicaSettings-Refresh0 = 919,
		BeyondDynamicBone-MagicaSettings-Start0 = 920,
		BeyondDynamicBone-MagicaSettings-Update0 = 921,
		BeyondDynamicBone-MagicaSettings-OnValidate0 = 922,
		BeyondDynamicBone-RenderData-WriteMesh0 = 923,
		BeyondDynamicBone-RenderData-ToString0 = 924,
		BeyondDynamicBone-RenderData-UpdatePositionNormalJob-SetIndexCount0 = 925,
		BeyondDynamicBone-RenderData-UpdatePositionNormalJob-Execute1 = 926,
		BeyondDynamicBone-RenderData-UpdatePositionNormalJob-Execute0 = 927,
		BeyondDynamicBone-RenderData-UpdatePositionNormalJob-UnsafeDo0 = 928,
		BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-SetIndexCount0 = 929,
		BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-Execute1 = 930,
		BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-Execute0 = 931,
		BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-UnsafeDo0 = 932,
		BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-SetIndexCount0 = 933,
		BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-Execute1 = 934,
		BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-Execute0 = 935,
		BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-UnsafeDo0 = 936,
		BeyondDynamicBone-RenderManager-Initialize0 = 937,
		BeyondDynamicBone-RenderManager-Dispose0 = 938,
		BeyondDynamicBone-RenderManager-PreRenderingUpdate0 = 939,
		BeyondDynamicBone-RenderManager-EnterdEditMode0 = 940,
		BeyondDynamicBone-RenderManager-IsValid0 = 941,
		BeyondDynamicBone-RenderManager-InformationLog0 = 942,
		BeyondDynamicBone-RenderSetupData-IsSuccess0 = 943,
		BeyondDynamicBone-RenderSetupData-ReadTransformInformation0 = 944,
		BeyondDynamicBone-RenderSetupData-GetRendeerLocalToWorldMatrix0 = 945,
		BeyondDynamicBone-RenderSetupData-GetRendeerTransform0 = 946,
		BeyondDynamicBone-RenderSetupData-GetRenderTransformId0 = 947,
		BeyondDynamicBone-RenderSetupData-GetSkinRootTransform0 = 948,
		BeyondDynamicBone-RenderSetupData-GetSkinRootTransformId0 = 949,
		BeyondDynamicBone-RenderSetupData-ShareSerialize0 = 950,
		BeyondDynamicBone-RenderSetupData-UniqueSerialize0 = 951,
		BeyondDynamicBone-RenderSetupData-VertexWeight5BoneCheckJob-Execute0 = 952,
		BeyondDynamicBone-RenderSetupData-ReadTransformJob-Execute0 = 953,
		BeyondDynamicBone-RenderSetupData-GetBoneWeightJos-Execute0 = 954,
		BeyondDynamicBone-ColliderManager-Dispose0 = 955,
		BeyondDynamicBone-ColliderManager-EnterdEditMode0 = 956,
		BeyondDynamicBone-ColliderManager-Initialize0 = 957,
		BeyondDynamicBone-ColliderManager-InformationLog0 = 958,
		BeyondDynamicBone-ColliderManager-Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D3$BurstDirectCall0 = 959,
		BeyondDynamicBone-ColliderManager-Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D4$BurstDirectCall0 = 960,
		BeyondDynamicBone-ColliderManager-Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D7$BurstDirectCall0 = 961,
		BeyondDynamicBone-ColliderManager-Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003D8$BurstDirectCall0 = 962,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-SetIndexCount0 = 963,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-Execute1 = 964,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-Execute0 = 965,
		BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-UnsafeDo0 = 966,
		BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-SetIndexCount0 = 967,
		BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-Execute1 = 968,
		BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-Execute0 = 969,
		BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-UnsafeDo0 = 970,
		BeyondDynamicBone-ColliderManager-StartSimulationStepJob-SetIndexCount0 = 971,
		BeyondDynamicBone-ColliderManager-StartSimulationStepJob-Execute1 = 972,
		BeyondDynamicBone-ColliderManager-StartSimulationStepJob-Execute0 = 973,
		BeyondDynamicBone-ColliderManager-StartSimulationStepJob-UnsafeDo0 = 974,
		BeyondDynamicBone-ColliderManager-EndSimulationStepJob-SetIndexCount0 = 975,
		BeyondDynamicBone-ColliderManager-EndSimulationStepJob-Execute1 = 976,
		BeyondDynamicBone-ColliderManager-EndSimulationStepJob-Execute0 = 977,
		BeyondDynamicBone-ColliderManager-EndSimulationStepJob-UnsafeDo0 = 978,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-SetIndexCount0 = 979,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-Execute1 = 980,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-Execute0 = 981,
		BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-UnsafeDo0 = 982,
		BeyondDynamicBone-SimulationManager-Dispose0 = 983,
		BeyondDynamicBone-SimulationManager-EnterdEditMode0 = 984,
		BeyondDynamicBone-SimulationManager-Initialize0 = 985,
		BeyondDynamicBone-SimulationManager-IsValid0 = 986,
		BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer0 = 987,
		BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer2 = 988,
		BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer1 = 989,
		BeyondDynamicBone-SimulationManager-InformationLog0 = 990,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_StartSimulationStepKernel_00000405$BurstDirectCall0 = 991,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000406$BurstDirectCall0 = 992,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_Spring_00000407$BurstDirectCall0 = 993,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_Wind_00000408$BurstDirectCall0 = 994,
		BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_WindForceBlend_00000409$BurstDirectCall0 = 995,
		BeyondDynamicBone-SimulationManager-Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040A$BurstDirectCall0 = 996,
		BeyondDynamicBone-SimulationManager-Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040B$BurstDirectCall0 = 997,
		BeyondDynamicBone-SimulationManager-Initialize$EndSimulationStepJobKernels_EndSimulationStepKernel_0000040C$BurstDirectCall0 = 998,
		BeyondDynamicBone-SimulationManager-Initialize$EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040D$BurstDirectCall0 = 999,
		BeyondDynamicBone-SimulationManager-Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_0000040E$BurstDirectCall0 = 1000,
		BeyondDynamicBone-SimulationManager-Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_0000040F$BurstDirectCall0 = 1001,
		BeyondDynamicBone-SimulationManager-Initialize$ClearStepCounterKernels_ClearStepCounterKernel_00000410$BurstDirectCall0 = 1002,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-SetIndexCount0 = 1003,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-Execute1 = 1004,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-Execute0 = 1005,
		BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-UnsafeDo0 = 1006,
		BeyondDynamicBone-SimulationManager-ClearStepCounter-Execute0 = 1007,
		BeyondDynamicBone-SimulationManager-ClearStepCounter-UnsafeDo0 = 1008,
		BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-SetIndexCount0 = 1009,
		BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-Execute1 = 1010,
		BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-Execute0 = 1011,
		BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-UnsafeDo0 = 1012,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-SetIndexCount0 = 1013,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Execute1 = 1014,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Execute0 = 1015,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Wind0 = 1016,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-WindForceBlend0 = 1017,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Spring0 = 1018,
		BeyondDynamicBone-SimulationManager-StartSimulationStepJob-UnsafeDo0 = 1019,
		BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-SetIndexCount0 = 1020,
		BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-Execute1 = 1021,
		BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-Execute0 = 1022,
		BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-UnsafeDo0 = 1023,
		BeyondDynamicBone-SimulationManager-EndSimulationStepJob-SetIndexCount0 = 1024,
		BeyondDynamicBone-SimulationManager-EndSimulationStepJob-Execute1 = 1025,
		BeyondDynamicBone-SimulationManager-EndSimulationStepJob-Execute0 = 1026,
		BeyondDynamicBone-SimulationManager-EndSimulationStepJob-UnsafeDo0 = 1027,
		BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-SetIndexCount0 = 1028,
		BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-Execute1 = 1029,
		BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-Execute0 = 1030,
		BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-UnsafeDo0 = 1031,
		BeyondDynamicBone-SimulationManager-FeedbackTempPosJob-Execute0 = 1032,
		BeyondDynamicBone-SimulationManager-FeedbackTempPosJob2-Execute0 = 1033,
		BeyondDynamicBone-TimeManager-Dispose0 = 1034,
		BeyondDynamicBone-TimeManager-AfterFixedUpdate0 = 1036,
		BeyondDynamicBone-TimeManager-AfterRenderring0 = 1037,
		BeyondDynamicBone-TimeManager-EnterdEditMode0 = 1038,
		BeyondDynamicBone-TimeManager-Initialize0 = 1039,
		BeyondDynamicBone-TimeManager-IsValid0 = 1040,
		BeyondDynamicBone-TimeManager-InformationLog0 = 1041,
		BeyondDynamicBone-WindManager-Dispose0 = 1042,
		BeyondDynamicBone-WindManager-EnterdEditMode0 = 1043,
		BeyondDynamicBone-WindManager-Initialize0 = 1044,
		BeyondDynamicBone-WindManager-IsValid0 = 1045,
		BeyondDynamicBone-WindManager-InformationLog0 = 1046,
		BeyondDynamicBone-BeyondBoneClothSavePoint-Load0 = 1047,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadTeamManagerTeamData0 = 1048,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadColliderManagerData0 = 1049,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadSimulationManagerData0 = 1050,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadVirtualMeshManagerData0 = 1051,
		BeyondDynamicBone-BeyondBoneClothSavePoint-LoadInertiaConstraintCenterData0 = 1052,
		BeyondDynamicBone-BeyondBoneClothSavePoint-Save0 = 1053,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveTeamManagerTeamData0 = 1054,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveColliderManagerData0 = 1055,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveSimulationManagerData0 = 1056,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveVirtualMeshManagerData0 = 1057,
		BeyondDynamicBone-BeyondBoneClothSavePoint-SaveInertiaConstraintCenterData0 = 1058,
		BeyondDynamicBone-TeamWindInfo-DebugLog0 = 1059,
		BeyondDynamicBone-TeamWindData-ClearZoneList0 = 1060,
		BeyondDynamicBone-TransformData-Init0 = 1061,
		BeyondDynamicBone-TransformData-AddTransform2 = 1062,
		BeyondDynamicBone-TransformData-AddTransformRange1 = 1063,
		BeyondDynamicBone-TransformData-AddTransformRange2 = 1064,
		BeyondDynamicBone-TransformData-RemoveTransformIndex0 = 1065,
		BeyondDynamicBone-TransformData-ReplaceTransform0 = 1066,
		BeyondDynamicBone-TransformData-UpdateWorkData0 = 1067,
		BeyondDynamicBone-TransformData-RestoreTransform0 = 1068,
		BeyondDynamicBone-TransformData-ReadTransform0 = 1069,
		BeyondDynamicBone-TransformData-ReadTransformRun0 = 1070,
		BeyondDynamicBone-TransformData-GetTransformIndexFormId0 = 1071,
		BeyondDynamicBone-TransformData-GetTransformIdFromIndex0 = 1072,
		BeyondDynamicBone-TransformData-GetParentIdFromIndex0 = 1073,
		BeyondDynamicBone-TransformData-GetLocalToWorldMatrix0 = 1074,
		BeyondDynamicBone-TransformData-GetWorldToLocalMatrix0 = 1075,
		BeyondDynamicBone-TransformData-ToString0 = 1076,
		BeyondDynamicBone-TransformData-ShareSerialize0 = 1077,
		BeyondDynamicBone-TransformData-UniqueSerialize0 = 1078,
		BeyondDynamicBone-TransformData-RestoreTransformJob-Execute0 = 1079,
		BeyondDynamicBone-TransformData-ReadTransformJob-Execute0 = 1080,
		BeyondDynamicBone-TransformRecord-InverseTransformDirection0 = 1081,
		BeyondDynamicBone-PreBuildScriptableObject-HasPreBuildData0 = 1082,
		BeyondDynamicBone-PreBuildScriptableObject-GetPreBuildData0 = 1083,
		BeyondDynamicBone-SharePreBuildData-CheckBuildId0 = 1084,
		BeyondDynamicBone-PreBuildScriptableObject-AddPreBuildData0 = 1085,
		BeyondDynamicBone-PreBuildScriptableObject-Warmup0 = 1088,
		BeyondDynamicBone-PreBuildSerializeData-GenerateBuildID0 = 1092,
		BeyondDynamicBone-SharePreBuildData-ToString0 = 1093,
		BeyondDynamicBone-ReductionSettings-GetHashCode0 = 1094,
		BeyondDynamicBone-ReductionSettings-ToString0 = 1095,
		BeyondDynamicBone-ReductionWorkData-Dispose0 = 1096,
		BeyondDynamicBone-SameDistanceReduction-Dispose0 = 1097,
		BeyondDynamicBone-SameDistanceReduction-InitGridJob-Execute0 = 1098,
		BeyondDynamicBone-SameDistanceReduction-SearchJoinJob-Execute0 = 1099,
		BeyondDynamicBone-SameDistanceReduction-JoinJob2-Execute0 = 1100,
		BeyondDynamicBone-VirtualMeshBoneWeight-AddWeight1 = 1101,
		BeyondDynamicBone-VirtualMeshBoneWeight-AddWeight0 = 1102,
		BeyondDynamicBone-SameDistanceReduction-UpdateJoinIndexJob-Execute0 = 1103,
		BeyondDynamicBone-SameDistanceReduction-UpdateLinkIndexJob-Execute0 = 1104,
		BeyondDynamicBone-SameDistanceReduction-FinalMergeVertexJob-Execute0 = 1105,
		BeyondDynamicBone-VirtualMeshBoneWeight-AdjustWeight0 = 1106,
		BeyondDynamicBone-ShapeDistanceReduction-Dispose0 = 1107,
		BeyondDynamicBone-StepReductionBase-Dispose0 = 1108,
		BeyondDynamicBone-ShapeDistanceReduction-StepInitialize0 = 1109,
		BeyondDynamicBone-ShapeDistanceReduction-CustomReductionStep0 = 1110,
		BeyondDynamicBone-ShapeDistanceReduction-SearchJoinEdgeJob-Execute0 = 1111,
		BeyondDynamicBone-StepReductionBase-CheckJoin20 = 1112,
		BeyondDynamicBone-SimpleDistanceReduction-Dispose0 = 1113,
		BeyondDynamicBone-SimpleDistanceReduction-StepInitialize0 = 1114,
		BeyondDynamicBone-SimpleDistanceReduction-CustomReductionStep0 = 1115,
		BeyondDynamicBone-SimpleDistanceReduction-InitGridJob-Execute0 = 1116,
		BeyondDynamicBone-SimpleDistanceReduction-SearchJoinEdgeJob-Execute0 = 1117,
		BeyondDynamicBone-StepReductionBase-CheckJoin0 = 1118,
		BeyondDynamicBone-StepReductionBase-JoinEdge-Contains0 = 1119,
		BeyondDynamicBone-StepReductionBase-JoinEdge-CompareTo0 = 1120,
		BeyondDynamicBone-StepReductionBase-DeterminJoinEdgeJob-Execute0 = 1121,
		BeyondDynamicBone-StepReductionBase-JoinPairJob-Execute0 = 1122,
		BeyondDynamicBone-StepReductionBase-UpdateJoinIndexJob-Execute0 = 1123,
		BeyondDynamicBone-StepReductionBase-UpdateLinkIndexJob-Execute0 = 1124,
		BeyondDynamicBone-StepReductionBase-FinalMergeVertexJob-Execute0 = 1125,
		BeyondDynamicBone-ClothDebugSettings-CheckParticleDrawing0 = 1126,
		BeyondDynamicBone-ClothDebugSettings-CheckTriangleDrawing0 = 1127,
		BeyondDynamicBone-ClothDebugSettings-CheckRadiusDrawing0 = 1128,
		BeyondDynamicBone-ClothDebugSettings-GetPointSize0 = 1129,
		BeyondDynamicBone-ClothDebugSettings-GetLineSize0 = 1130,
		BeyondDynamicBone-ClothDebugSettings-GetInertiaCenterRadius0 = 1131,
		BeyondDynamicBone-ClothDebugSettings-GetCustomSkinningRadius0 = 1132,
		BeyondDynamicBone-ClothDebugSettings-IsReferOldPos0 = 1133,
		BeyondDynamicBone-DataUtility-PackInt31 = 1134,
		BeyondDynamicBone-ClothJobUtility-Fill1 = 1135,
		BeyondDynamicBone-ClothJobUtility-Fill2 = 1136,
		BeyondDynamicBone-ClothJobUtility-SerialNumber0 = 1137,
		BeyondDynamicBone-ClothJobUtility-ConvertHashSetToNativeList0 = 1138,
		BeyondDynamicBone-ClothJobUtility-ConvertHashSetKeyToNativeList0 = 1139,
		BeyondDynamicBone-ClothJobUtility-ConvertHashSetKeyToNativeList1 = 1140,
		BeyondDynamicBone-ClothJobUtility-CalcAABB0 = 1141,
		BeyondDynamicBone-ClothJobUtility-CalcAABB1 = 1142,
		BeyondDynamicBone-ClothJobUtility-CalcAABBRun1 = 1143,
		BeyondDynamicBone-ClothJobUtility-CalcAABBInternal0 = 1144,
		BeyondDynamicBone-ClothJobUtility-CalcUVWithSphereMapping0 = 1145,
		BeyondDynamicBone-ClothJobUtility-TransformPosition0 = 1146,
		BeyondDynamicBone-ClothJobUtility-TransformPosition1 = 1147,
		BeyondDynamicBone-ClothJobUtility-ClearReference0 = 1148,
		BeyondDynamicBone-ClothJobUtility-SerialNumberJob-Execute0 = 1149,
		BeyondDynamicBone-ClothJobUtility-CalcAABBJob-Execute0 = 1150,
		BeyondDynamicBone-ClothJobUtility-CalcAABBDeferJob-Execute0 = 1151,
		BeyondDynamicBone-ClothJobUtility-CalcUVJob-Execute0 = 1152,
		BeyondDynamicBone-ClothJobUtility-AddIntDataCopyJob-Execute0 = 1153,
		BeyondDynamicBone-ClothJobUtility-AddInt2DataCopyJob-Execute0 = 1154,
		BeyondDynamicBone-ClothJobUtility-AddInt3DataCopyJob-Execute0 = 1155,
		BeyondDynamicBone-ClothJobUtility-TransformPositionJob-Execute0 = 1156,
		BeyondDynamicBone-ClothJobUtility-TransformPositionJob2-Execute0 = 1157,
		BeyondDynamicBone-ClothJobUtility-ClearReferenceJob-Execute0 = 1158,
		BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear2 = 1159,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateJobKernels_AggregateKernel_00000578$BurstDirectCall0 = 1160,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateJobKernels_AggregateRangeKernel_00000579$BurstDirectCall0 = 1161,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_0000057A$BurstDirectCall0 = 1162,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_0000057B$BurstDirectCall0 = 1163,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateJob2Kernels_AggregateJob2Kernel_0000057C$BurstDirectCall0 = 1164,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateJob2Kernels_AggregateJob2RangeKernel_0000057D$BurstDirectCall0 = 1165,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_0000057E$BurstDirectCall0 = 1166,
		BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_0000057F$BurstDirectCall0 = 1167,
		BeyondDynamicBone-InterlockUtility-AggregateJob-Execute0 = 1168,
		BeyondDynamicBone-InterlockUtility-AggregateJob-UnsafeDo0 = 1169,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob-Execute0 = 1170,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob-UnsafeDo0 = 1171,
		BeyondDynamicBone-InterlockUtility-AggregateJob2-SetIndexCount0 = 1172,
		BeyondDynamicBone-InterlockUtility-AggregateJob2-Execute1 = 1173,
		BeyondDynamicBone-InterlockUtility-AggregateJob2-Execute0 = 1174,
		BeyondDynamicBone-InterlockUtility-AggregateJob2-UnsafeDo0 = 1175,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-SetIndexCount0 = 1176,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-Execute1 = 1177,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-Execute0 = 1178,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-UnsafeDo0 = 1179,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityCrossFrameJob2-Execute0 = 1180,
		BeyondDynamicBone-InterlockUtility-AggregateWithVelocityCrossFrameJob2-Execute1 = 1181,
		BeyondDynamicBone-InterlockUtility-AggregateCrossFrameJob2-Execute0 = 1182,
		BeyondDynamicBone-InterlockUtility-AggregateCrossFrameJob2-Execute1 = 1183,
		BeyondDynamicBone-AABB-get_HalfExtents0 = 1184,
		BeyondDynamicBone-AABB-get_SurfaceArea0 = 1185,
		BeyondDynamicBone-AABB-ToString0 = 1186,
		BeyondDynamicBone-MathUtility-ComputeVirtualParentWithoutLocal0 = 1187,
		BeyondDynamicBone-MathUtility-TriangleTangent1 = 1188,
		BeyondDynamicBone-MathUtility-GetCommonEdgeFromTrianglePair0 = 1189,
		BeyondDynamicBone-MathUtility-GetTrianglePairIndices0 = 1190,
		BeyondDynamicBone-MathUtility-IntersectSegmentTriangle0 = 1191,
		BeyondDynamicBone-MathUtility-IntersectSegmentTriangle1 = 1192,
		BeyondDynamicBone-MathUtility-SqDistPointSegment0 = 1193,
		BeyondDynamicBone-FTransform-Default0 = 1194,
		BeyondDynamicBone-MeshUtility-GetSharedMesh0 = 1195,
		BeyondDynamicBone-MeshUtility-SetMesh0 = 1196,
		BeyondDynamicBone-MeshUtility-GetTransformCount0 = 1197,
		BeyondDynamicBone-Develop-Log0 = 1198,
		BeyondDynamicBone-Develop-DebugLog0 = 1199,
		BeyondDynamicBone-Develop-DebugLogWarning0 = 1200,
		BeyondDynamicBone-Develop-DebugLogError0 = 1201,
		BeyondDynamicBone-Develop-Assert0 = 1202,
		BeyondDynamicBone-StaticStringBuilder-Clear0 = 1203,
		BeyondDynamicBone-StaticStringBuilder-Append0 = 1204,
		BeyondDynamicBone-StaticStringBuilder-AppendLine0 = 1205,
		BeyondDynamicBone-StaticStringBuilder-AppendLine1 = 1206,
		BeyondDynamicBone-StaticStringBuilder-AppendToString0 = 1207,
		BeyondDynamicBone-StaticStringBuilder-ToString0 = 1208,
		BeyondDynamicBone-DataChunk-ToString0 = 1209,
		BeyondDynamicBone-ExBitFlag16-Clear0 = 1210,
		BeyondDynamicBone-ExCostSortedList1-CompareTo0 = 1211,
		BeyondDynamicBone-ExCostSortedList1-ToString0 = 1212,
		BeyondDynamicBone-ExCostSortedList4-Add0 = 1213,
		BeyondDynamicBone-ExCostSortedList4-indexOf0 = 1214,
		BeyondDynamicBone-ExCostSortedList4-RemoveItem0 = 1215,
		BeyondDynamicBone-ExCostSortedList4-ToString0 = 1216,
		BeyondDynamicBone-ExTransformAccessArray-Dispose0 = 1217,
		BeyondDynamicBone-ExTransformAccessArray-GetTransformAccessArray0 = 1218,
		BeyondDynamicBone-ExTransformAccessArray-Add0 = 1219,
		BeyondDynamicBone-ExTransformAccessArray-Remove0 = 1220,
		BeyondDynamicBone-ExTransformAccessArray-Exist0 = 1221,
		BeyondDynamicBone-ExTransformAccessArray-Exist1 = 1222,
		BeyondDynamicBone-ExTransformAccessArray-GetIndex0 = 1223,
		BeyondDynamicBone-ExTransformAccessArray-Clear0 = 1224,
		BeyondDynamicBone-ResultCode-IsResult0 = 1225,
		BeyondDynamicBone-ResultCode-IsCancel0 = 1226,
		BeyondDynamicBone-ResultCode-IsProcess0 = 1227,
		BeyondDynamicBone-ResultCode-GetWarningString0 = 1228,
		BeyondDynamicBone-ResultCode-GetResultInformation0 = 1229,
		BeyondDynamicBone-ResultCode-GetWarningInformation0 = 1230,
		BeyondDynamicBone-ResultCode-DebugLog0 = 1231,
		BeyondDynamicBone-TimeSpan-Start0 = 1232,
		BeyondDynamicBone-TimeSpan-Finish0 = 1233,
		BeyondDynamicBone-TimeSpan-TotalSeconds0 = 1234,
		BeyondDynamicBone-TimeSpan-TotalMilliSeconds0 = 1235,
		BeyondDynamicBone-TimeSpan-ToString0 = 1236,
		BeyondDynamicBone-TimeSpan-DebugLog0 = 1237,
		BeyondDynamicBone-TimeSpan-Log0 = 1238,
		BeyondDynamicBone-UnityTimeSpan-Finish0 = 1239,
		BeyondDynamicBone-UnityTimeSpan-TotalSeconds0 = 1240,
		BeyondDynamicBone-UnityTimeSpan-TotalMilliSeconds0 = 1241,
		BeyondDynamicBone-UnityTimeSpan-ToString0 = 1242,
		BeyondDynamicBone-UnityTimeSpan-DebugLog0 = 1243,
		BeyondDynamicBone-VirtualMesh-SetTransform1 = 1244,
		BeyondDynamicBone-VirtualMesh-SetCenterTransform0 = 1245,
		BeyondDynamicBone-VirtualMesh-SetSkinRoot0 = 1246,
		BeyondDynamicBone-VirtualMesh-CalcVertexWeights0 = 1247,
		BeyondDynamicBone-VirtualMesh-ShareSerialize0 = 1248,
		BeyondDynamicBone-VirtualMesh-UniqueSerialize0 = 1249,
		BeyondDynamicBone-VirtualMesh-IntersectRayMesh0 = 1250,
		BeyondDynamicBone-VirtualMesh-get_NormalAdjustmentRotationCount0 = 1251,
		BeyondDynamicBone-VirtualMesh-SetName0 = 1252,
		BeyondDynamicBone-VirtualMesh-ToString0 = 1253,
		BeyondDynamicBone-VirtualMesh-Import_GenerateTangentJob-Execute0 = 1254,
		BeyondDynamicBone-VirtualMesh-Import_CalcSkinningJob-Execute0 = 1255,
		BeyondDynamicBone-VirtualMesh-Import_BoneWeightJob1-Execute0 = 1256,
		BeyondDynamicBone-VirtualMesh-Import_BoneWeightJob2-Execute0 = 1257,
		BeyondDynamicBone-VirtualMesh-Import_BoneVertexJob-Execute0 = 1258,
		BeyondDynamicBone-VirtualMesh-Select_PackVertexJob-Execute0 = 1259,
		BeyondDynamicBone-VirtualMesh-Select_GridJob-Execute0 = 1260,
		BeyondDynamicBone-VirtualMesh-Add_CalcBindPoseJob-Execute0 = 1261,
		BeyondDynamicBone-VirtualMesh-Add_CopyVerticesJob-Execute0 = 1262,
		BeyondDynamicBone-VirtualMesh-Mapping_DirectConnectionVertexDataJob-Execute0 = 1263,
		BeyondDynamicBone-VirtualMesh-Mapping_CalcDirectWeightJob-Execute0 = 1264,
		BeyondDynamicBone-VirtualMesh-Mapping_CalcConnectionVertexDataJob-Execute0 = 1265,
		BeyondDynamicBone-VirtualMesh-Mapping_CalcWeightJob-Execute0 = 1266,
		BeyondDynamicBone-VirtualMesh-Optimize_EdgeToTrianlgeJob-Execute0 = 1267,
		BeyondDynamicBone-VirtualMesh-ProxyNormalRadiationAdjustmentJob-Execute0 = 1268,
		BeyondDynamicBone-VirtualMesh-ProxyCreateFixedListAndAABBJob-Execute0 = 1269,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcTriangleNormalJob-Execute0 = 1270,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcTriangleTangentJob-Execute0 = 1271,
		BeyondDynamicBone-VirtualMesh-Proxy_CreateVertexToTrianglesJob-Execute0 = 1272,
		BeyondDynamicBone-VirtualMesh-Proxy_OrganizeVertexToTrianglsJob-Execute0 = 1273,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexNormalTangentFromTriangleJob-Execute0 = 1274,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToTransformJob-Execute0 = 1275,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcEdgeToTriangleJob-Execute0 = 1276,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexBindPoseJob2-Execute0 = 1277,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToVertexFromTriangleJob-Execute0 = 1278,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToVertexFromLineJob-Execute0 = 1279,
		BeyondDynamicBone-VirtualMesh-Proxy_CreateEdgeFlagJob-Execute0 = 1280,
		BeyondDynamicBone-VirtualMesh-Proxy_CalcCustomSkinningWeightsJobV2-Execute0 = 1281,
		BeyondDynamicBone-VirtualMesh-Proxy_ApplySelectionJob-Execute0 = 1282,
		BeyondDynamicBone-VirtualMesh-Proxy_BoneClothApplayTransformFlagJob-Execute0 = 1283,
		BeyondDynamicBone-VirtualMesh-BaseLineWork-CompareTo0 = 1284,
		BeyondDynamicBone-VirtualMesh-BaseLine_Mesh_CreateParentJob2-Execute0 = 1285,
		BeyondDynamicBone-VirtualMesh-BaseLine_Mesh_CareteFixedListJob-Execute0 = 1286,
		BeyondDynamicBone-VirtualMesh-BaseLine_Bone_CreateBoneChildInfoJob-Execute0 = 1287,
		BeyondDynamicBone-VirtualMesh-BaseLine_CalcLocalPositionRotationJob-Execute0 = 1288,
		BeyondDynamicBone-VirtualMesh-BaseLine_CalcMaxBaseLineLengthJob-Execute0 = 1289,
		BeyondDynamicBone-VirtualMesh-Reduction_InitVertexToVertexJob2-Execute0 = 1290,
		BeyondDynamicBone-VirtualMesh-Organize_RemapVertexJob-Execute0 = 1291,
		BeyondDynamicBone-VirtualMesh-Organize_CollectUseSkinBoneJob-Execute0 = 1292,
		BeyondDynamicBone-VirtualMesh-Organize_CopyVertexJob-Execute0 = 1293,
		BeyondDynamicBone-VirtualMesh-Organize_RemapBoneWeightJob-Execute0 = 1294,
		BeyondDynamicBone-VirtualMesh-Organize_RemapLinkPointArrayJob-Execute0 = 1295,
		BeyondDynamicBone-VirtualMesh-Organize_CreateLineTriangleJob-Execute0 = 1296,
		BeyondDynamicBone-VirtualMesh-Organize_CreateLineTriangleJob2-Execute0 = 1297,
		BeyondDynamicBone-VirtualMesh-Organize_CreateNewTriangleJob3-Execute0 = 1298,
		BeyondDynamicBone-VirtualMesh-ShareSerializationData-ToString0 = 1299,
		BeyondDynamicBone-VirtualMesh-Work_AverageTriangleDistanceJob-Execute0 = 1300,
		BeyondDynamicBone-VirtualMesh-Work_AverageLineDistanceJob-Execute0 = 1301,
		BeyondDynamicBone-VirtualMesh-Work_AddVertexIndexGirdMapJob-Execute0 = 1302,
		BeyondDynamicBone-VirtualMesh-Work_IntersectTriangleJob-Execute0 = 1303,
		BeyondDynamicBone-VirtualMesh-Work_IntersectEdgeJob-Execute0 = 1304,
		BeyondDynamicBone-VirtualMesh-Work_IntersectPointJob-Execute0 = 1305,
		BeyondDynamicBone-VirtualMesh-Work_IntersetcSortJob-Execute0 = 1306,
		BeyondDynamicBone-VertexAttribute-Equals0 = 1307,
		BeyondDynamicBone-VertexAttribute-GetHashCode0 = 1308,
		BeyondDynamicBone-VirtualMeshBoneWeight-ToString0 = 1309,
		BeyondDynamicBone-VirtualMeshRaycastHit-CompareTo0 = 1310,
		BeyondDynamicBone-VirtualMeshRaycastHit-IsValid0 = 1311,
		BeyondDynamicBone-VirtualMeshRaycastHit-ToString0 = 1312,
		BeyondDynamicBone-VirtualMeshTransform-Clone0 = 1313,
		BeyondDynamicBone-VirtualMeshTransform-get_Origin0 = 1314,
		BeyondDynamicBone-VirtualMeshTransform-GetHashCode0 = 1315,
		BeyondDynamicBone-VirtualMeshTransform-Update0 = 1316,
		BeyondDynamicBone-VirtualMeshTransform-Transform0 = 1317
	}
}
