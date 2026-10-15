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
using BeyondDynamicBone.ClothTeleport;
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

// Image 16: BeyondDynamicBone.dll - Assembly: BeyondDynamicBone, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 77499-78139

[DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4154197192 // TypeDefIndex: 78138
{
	// Methods
	public static void CreateJobReflectionData(); // 0x0000000182372280-0x000000018237AC10
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit(); // 0x000000018237AC10-0x000000018237AC20
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 78139
{
	// Methods
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize(); // 0x0000000186B30B70-0x0000000186B31200
}

namespace BeyondDynamicBone
{
	public class BeyondBoneCloth : ClothBehaviour, IValid // TypeDefIndex: 77502
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
		private bool m_pendingTeleportApply; // 0xB0
		private RigidTransform m_pendingRWBufferDelta; // 0xB4
		private int m_pendingRWBufferTeamId; // 0xD0
		private NativeList<TransformSlice> m_teleportSlices; // 0xD8
		[JsonIgnore]
		public Action<bool> OnBuildComplete; // 0xE8
	
		// Properties
		public bool bUseRelativeTransform { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EFA0-0x000000018226EFB0 0x000000018226EFB0-0x000000018226EFC0
		public ClothSerializeData SerializeData { get; set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
		public ClothProcess Process { get; } // 0x00000001854D81C0-0x00000001854D8250 
		public Transform ClothTransform { get; } // 0x0000000187834814-0x000000018783481C 
		public BeyondBoneCloth SyncPartnerCloth { get; } // 0x0000000185D7A6B0-0x0000000185D7A760 
	
		// Constructors
		public BeyondBoneCloth(); // 0x0000000185F6A810-0x0000000185F6A930
	
		// Methods
		internal void InitAnimationProperty(); // 0x0000000185D78920-0x0000000185D78A70
		private void OnDidApplyAnimationProperties(); // 0x00000001889CFD18-0x00000001889CFFC4
		public void SetRelativeTransform(bool useRelativeTransform, float3 newPos, quaternion newRot); // 0x00000001889D1558-0x00000001889D1760
		public bool IsValid(); // 0x0000000186A713F0-0x0000000186A71460
		private void Reset(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnValidate(); // 0x00000001889D08CC-0x00000001889D08F0
		private void Awake(); // 0x0000000186C3C310-0x0000000186C3C380
		private void OnEnable(); // 0x0000000185B1AE50-0x0000000185B1AE80
		private void OnDisable(); // 0x00000001869B2580-0x00000001869B25B0
		private void Start(); // 0x0000000185D78570-0x0000000185D78660
		private void OnDestroy(); // 0x0000000185FF1380-0x0000000185FF13C0
		public override int GetMagicaHashCode(); // 0x00000001889CFC00-0x00000001889CFC84
		public void OnRootTeleported(); // 0x00000001889D0128-0x00000001889D08CC
		private void OnPreSimulationApplyRWBufferCovaryOnce(); // 0x00000001889CFFC4-0x00000001889D0128
		private void DisposeTeleportResources(); // 0x0000000185FF13C0-0x0000000185FF1420
		private static unsafe void AddSlice(ref NativeList<TransformSlice> slices, void* ptr, int count, RigidTransformRule rule); // 0x00000001889CF0BC-0x00000001889CF140
		private static unsafe void* PtrAt<T>(NativeArray<T> arr, int start)
			where T : struct;
		private void RegisterCdataSlices(ref NativeList<TransformSlice> slices, ref InertiaConstraint.CenterData cdata); // 0x00000001889D08F0-0x00000001889D0ACC
		private void RegisterClothArraySlices(ref NativeList<TransformSlice> slices, int teamId); // 0x00000001889D0ACC-0x00000001889D0F10
		private void RegisterTransformCacheSlices(ref NativeList<TransformSlice> slices, int teamId); // 0x00000001889D0F10-0x00000001889D109C
		private void CovaryCrossFrameWriteSources(int teamId, [IsReadOnly] in RigidTransform delta); // 0x00000001889CF5EC-0x00000001889CFAB0
		public ClothSerializeData2 GetSerializeData2(); // 0x0000000187232F60-0x0000000187232F70
		public void Initialize(); // 0x000000018613CE70-0x000000018613CEB0
		public void DisableAutoBuild(); // 0x00000001889CFAB0-0x00000001889CFAE4
		public void SetClothSimulateWeight(float weight); // 0x00000001853AB470-0x00000001853AB650
		public void SetClothSimulateWeightIgnorePlaying(float weight); // 0x00000001853C86A0-0x00000001853C8750
		public void SetClothStablizationTimeAfterResetIgnorePlaying(float time); // 0x00000001889D14F4-0x00000001889D1518
		public void SetAnimationPoseRatio(float ratio); // 0x00000001889D1454-0x00000001889D14F4
		private void SetCodeParamaterDirty(); // 0x00000001854D7470-0x00000001854D7590
		private void SetCodeParamaterDirtyIgnorePlaying(); // 0x00000001853C8750-0x00000001853C8A90
		public bool BuildAndRun(); // 0x00000001889CF140-0x00000001889CF5EC
		public void ReplaceTransform(Dictionary<string, Transform> targetTransformDict); // 0x00000001889D109C-0x00000001889D136C
		public void SetParameterChange(); // 0x00000001889D1518-0x00000001889D1558
		public void SetTimeScale(float timeScale); // 0x00000001889D17AC-0x00000001889D184C
		public float GetTimeScale(); // 0x00000001889CFC84-0x00000001889CFD18
		public void ResetCloth(bool keepPose = false /* Metadata: 0x02629F21 */); // 0x00000001889D136C-0x00000001889D1454
		public void SoftResetCloth(bool keepPose = false /* Metadata: 0x02629F22 */); // 0x0000000186A713A0-0x0000000186A713F0
		public Vector3 GetCenterPosition(); // 0x00000001889CFAE4-0x00000001889CFC00
		public void AddForce(Vector3 forceDirection, float forceVelocity, ClothForceMode fmode = ClothForceMode.VelocityAdd /* Metadata: 0x02629F23 */); // 0x00000001889CEF70-0x00000001889CF0BC
		public void SetSkipWriting(bool sw); // 0x00000001889D1760-0x00000001889D17AC
	}

	[Serializable]
	public class CheckSliderSerializeData // TypeDefIndex: 77503
	{
		// Fields
		public float value; // 0x10
		public bool use; // 0x14
	
		// Constructors
		public CheckSliderSerializeData(); // 0x0000000186805BA0-0x0000000186805BB0
		public CheckSliderSerializeData(bool use, float value); // 0x0000000187233960-0x0000000187233970
	
		// Methods
		public float GetValue(float unusedValue); // 0x0000000185D79A30-0x0000000185D79A40
		public void SetValue(bool use, float value); // 0x0000000187233960-0x0000000187233970
		public void DataValidate(float min, float max); // 0x00000001889D18B8-0x00000001889D18DC
		public CheckSliderSerializeData Clone(); // 0x00000001889D1864-0x00000001889D18B8
	}

	public abstract class ClothBehaviour : MonoBehaviour // TypeDefIndex: 77504
	{
		// Fields
		[CompilerGenerated]
		private bool _IsGizmoVisible_k__BackingField; // 0x18
	
		// Properties
		public bool IsGizmoVisible { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
	
		// Constructors
		protected ClothBehaviour(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public virtual int GetMagicaHashCode(); // 0x0000000185829EC0-0x0000000185829ED0
		protected virtual void OnDrawGizmos(); // 0x0000000187233970-0x0000000187233980
	}

	public enum ClothForceMode // TypeDefIndex: 77505
	{
		None = 0,
		VelocityAdd = 1,
		VelocityChange = 2,
		VelocityAddWithoutDepth = 10,
		VelocityChangeWithoutDepth = 11
	}

	public enum ClothMeshWriteMode // TypeDefIndex: 77506
	{
		PositionAndNormal = 0,
		PositionAndNormalTangent = 1
	}

	public enum ClothNormalAxis // TypeDefIndex: 77507
	{
		Right = 0,
		Up = 1,
		Forward = 2,
		InverseRight = 3,
		InverseUp = 4,
		InverseForward = 5
	}

	public struct ClothParameters // TypeDefIndex: 77508
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

	public class ClothProcess : IDisposable, IValid, ITransform // TypeDefIndex: 77519
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
		public const int State_Valid = 0; // Metadata: 0x02629F31
		public const int State_Enable = 1; // Metadata: 0x02629F32
		public const int State_InitSuccess = 3; // Metadata: 0x02629F33
		public const int State_InitComplete = 4; // Metadata: 0x02629F34
		public const int State_Build = 5; // Metadata: 0x02629F35
		public const int State_Running = 6; // Metadata: 0x02629F36
		public const int State_DisableAutoBuild = 7; // Metadata: 0x02629F37
		public const int State_CameraCullingInvisible = 8; // Metadata: 0x02629F38
		public const int State_CameraCullingKeep = 9; // Metadata: 0x02629F39
		public const int State_SkipWriting = 10; // Metadata: 0x02629F3A
		public const int State_UsePreBuild = 12; // Metadata: 0x02629F3B
		public const int State_DistanceCullingInvisible = 13; // Metadata: 0x02629F3C
		public const int State_UpdateTangent = 14; // Metadata: 0x02629F3D
		public const int State_Component = 15; // Metadata: 0x02629F3E
		public const int State_Verification = 16; // Metadata: 0x02629F3F
		public const int State_LOD_Culled = 25; // Metadata: 0x02629F40
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
		public BeyondBoneCloth cloth { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public BeyondBoneCloth SyncTopCloth { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		internal TransformRecord clothTransformRecord { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182262130-0x0000000182262140 0x0000000185CA30F0-0x0000000185CA3100
		internal TransformRecord normalAdjustmentTransformRecord { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public ResultCode Result { get; } // 0x0000000187232F70-0x0000000187232F80 
		internal ClothType clothType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872332A0-0x00000001872332B0 0x0000000185FF5E70-0x0000000185FF5F30
		public ClothParameters parameters { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872339A0-0x0000000187233A30 0x0000000187233A40-0x0000000187233AC0
		public VirtualMeshContainer ProxyMeshContainer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233980-0x0000000187233990 0x00000001889D3C38-0x00000001889D3C4C
		internal int ColliderCapacity { get; } // 0x00000001859F4DF0-0x00000001859F4E40 
		public int TeamId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233990-0x00000001872339A0 0x0000000187233A30-0x0000000187233A40
		public bool IsEnable { get; } // 0x00000001854D7A60-0x00000001854D7B60 
		public bool HasProxyMesh { get; } // 0x00000001889D3B30-0x00000001889D3BB8 
		public string Name { get; } // 0x00000001889D3BB8-0x00000001889D3C38 
	
		// Nested types
		[BurstCompile]
		private struct GenerateSelectionJob : IJobParallelFor // TypeDefIndex: 77509
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
			public void Execute(int vindex); // 0x00000001889D5140-0x00000001889D5318
		}
	
		public class RenderMeshInfo // TypeDefIndex: 77510
		{
			// Fields
			public int renderHandle; // 0x10
			public VirtualMeshContainer renderMeshContainer; // 0x18
			public DataChunk mappingChunk; // 0x20
	
			// Constructors
			public RenderMeshInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public class PaintMapData // TypeDefIndex: 77511
		{
			// Fields
			public const byte ReadFlag_Fixed = 1; // Metadata: 0x02629F41
			public const byte ReadFlag_Move = 2; // Metadata: 0x02629F42
			public const byte ReadFlag_Limit = 4; // Metadata: 0x02629F43
			public Color32[] paintData; // 0x10
			public int paintMapWidth; // 0x18
			public int paintMapHeight; // 0x1C
			public ExBitFlag8 paintReadFlag; // 0x20
	
			// Constructors
			public PaintMapData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		public enum ClothType // TypeDefIndex: 77512
		{
			MeshCloth = 0,
			BoneCloth = 1,
			BoneSpring = 10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 77513
		{
			// Fields
			public CancellationToken ct; // 0x10
			public VirtualMesh proxyMesh; // 0x18
			public ClothProcess __4__this; // 0x20
			public List<RenderMeshInfo> renderMeshInfos; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RuntimeBuildAsync_b__1(); // 0x0000000185D78AB0-0x0000000185D78EE0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_1 // TypeDefIndex: 77514
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
			public __c__DisplayClass10_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _RuntimeBuildAsync_b__0(); // 0x0000000186266910-0x0000000186268D00
		}
	
		[CompilerGenerated]
		private struct _RuntimeBuildAsync_d__10 : IAsyncStateMachine // TypeDefIndex: 77515
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
			private void MoveNext(); // 0x0000000185D7A830-0x0000000185D7E160
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000186517E10-0x0000000186517E70
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77516
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<VirtualMeshContainer> __9__18_0; // 0x08
			public static Action<int> __9__21_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E4AC0-0x00000001871E4B20
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PreBuildDataConstruction_b__18_0(VirtualMeshContainer x); // 0x00000001889D5AB8-0x00000001889D5ACC
			internal void _UpdateRendererUse_b__21_0(int handle); // 0x00000001889D5ACC-0x00000001889D5B38
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass126_0 // TypeDefIndex: 77517
		{
			// Fields
			public HashSet<Transform> transformSet; // 0x10
	
			// Constructors
			public __c__DisplayClass126_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetUsedTransform_b__0(int handle); // 0x00000001889D5B38-0x00000001889D5BAC
			internal void _GetUsedTransform_b__1(TransformRecord rd); // 0x00000001889D5BAC-0x00000001889D5BD4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass127_0 // TypeDefIndex: 77518
		{
			// Fields
			public Dictionary<int, Transform> replaceDict; // 0x10
	
			// Constructors
			public __c__DisplayClass127_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _ReplaceTransform_b__0(int handle); // 0x00000001889D5BD4-0x00000001889D5C48
			internal void _ReplaceTransform_b__1(TransformRecord rd); // 0x00000001889D5C48-0x00000001889D5C70
		}
	
		// Constructors
		public ClothProcess(); // 0x0000000185F6AAD0-0x0000000185F6AD30
		static ClothProcess(); // 0x0000000186FCB560-0x0000000186FCB680
	
		// Methods
		internal void Init(); // 0x0000000185D79C10-0x0000000185D7A240
		private int AddRenderer(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referenceUniqueSetupData); // 0x00000001889D18DC-0x00000001889D1B10
		private void CreateBoneRenderSetupData(ClothType ctype, List<Transform> rootTransforms, List<Transform> ignoreFromRootBones, List<Transform> collisionBones, RenderSetupData.BoneConnectionMode connectionMode); // 0x0000000186AD9960-0x0000000186AD9A70
		internal void StartUse(); // 0x0000000185B1AE80-0x0000000185B1AED0
		internal void EndUse(); // 0x00000001869B25B0-0x00000001869B2600
		internal void UpdateUse(); // 0x0000000185B1AFC0-0x0000000185B1B200
		internal void DataUpdate(); // 0x00000001889D1B10-0x00000001889D1BBC
		internal bool StartRuntimeBuild(); // 0x0000000185AE18A0-0x0000000185AE1980
		internal bool AutoBuild(); // 0x0000000185D786D0-0x0000000185D78740
		private async System.Threading.Tasks.Task RuntimeBuildAsync(CancellationToken ct); // 0x0000000185AE1790-0x0000000185AE18A0
		public ResultCode GenerateSelectionDataFromPaintMap(TransformRecord clothTransformRecord, VirtualMesh renderMesh, PaintMapData paintMapData, out SelectionData selectionData); // 0x00000001889D26D4-0x00000001889D2ED8
		public ResultCode GeneratePaintMapDataList(List<PaintMapData> dataList); // 0x00000001889D22D8-0x00000001889D26D4
		public ResultCode GenerateSelectionDataFromVertexAttributeData(TransformRecord clothTransformRecord, VirtualMesh renderMesh, VertexAttribute[] vertexAttributeArray, out SelectionData selectionData); // 0x00000001889D2ED8-0x00000001889D3388
		internal bool PreBuildDataConstruction(); // 0x00000001861837B0-0x0000000186185BF0
		internal int GetColliderIndex(ColliderComponent col); // 0x00000001859F4DC0-0x00000001859F4DF0
		internal void UpdateCullingAnimatorAndRenderers(); // 0x00000001853C80C0-0x00000001853C8200
		internal void UpdateRendererUse(); // 0x0000000186C183F0-0x0000000186C18530
		public BitField32 GetStateFlag(); // 0x000000018226A850-0x000000018226A860
		public bool IsState(int state); // 0x0000000187839878-0x000000018783988C
		public void SetState(int state, bool sw); // 0x00000001854D7A30-0x00000001854D7A60
		public bool IsValid(); // 0x00000001878365AC-0x00000001878365B4
		public bool IsRunning(); // 0x00000001878365B4-0x00000001878365BC
		public bool IsCameraCullingInvisible(); // 0x00000001889D389C-0x00000001889D38A8
		public bool IsLodCulled(); // 0x00000001889D38A8-0x00000001889D38B4
		public bool IsCameraCullingKeep(); // 0x0000000186BE8180-0x0000000186BE8190
		public bool IsDistanceCullingInvisible(); // 0x0000000187838018-0x0000000187838024
		public bool IsSkipWriting(); // 0x00000001889D38B4-0x00000001889D38C0
		public bool IsUpdateTangent(); // 0x0000000187837C90-0x0000000187837C9C
		public void Dispose(); // 0x0000000185FF1420-0x0000000185FF1590
		private void DisposeInternal(); // 0x0000000185FF2950-0x0000000185FF5370
		internal void IncrementSuspendCounter(); // 0x00000001889D37B4-0x00000001889D389C
		internal void DecrementSuspendCounter(); // 0x00000001889D1BBC-0x00000001889D1C98
		internal int GetSuspendCounter(); // 0x00000001889D353C-0x00000001889D35D4
		public RenderMeshInfo GetRenderMeshInfo(int index); // 0x00000001889D34CC-0x00000001889D353C
		internal void SyncParameters(); // 0x0000000185D78F00-0x0000000185D79040
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001889D35D4-0x00000001889D37B4
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x00000001889D38C0-0x00000001889D3AA0
		internal void SetSkipWriting(bool sw); // 0x00000001889D3AA0-0x00000001889D3B30
		internal ClothUpdateMode GetClothUpdateMode(); // 0x00000001889D3388-0x00000001889D34CC
		public ResultCode GenerateStatusCheck(); // 0x0000000185D79A40-0x0000000185D79C10
		internal bool GenerateInitialization(); // 0x00000001889D21E0-0x00000001889D22D8
		internal bool GenerateBoneClothSelection(); // 0x00000001889D1C98-0x00000001889D21E0
	}

	[Serializable]
	public class ClothSerializeData : IDataValidate, IValid, ITransform // TypeDefIndex: 77524
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
		public Define.Result VerificationResult { get; } // 0x0000000187233AC0-0x0000000187233AD0 
	
		// Nested types
		public enum PaintMode // TypeDefIndex: 77520
		{
			Manual = 0,
			Texture_Fixed_Move = 1,
			Texture_Fixed_Move_Limit = 2
		}
	
		public enum AnimatorAbilityLevel // TypeDefIndex: 77521
		{
			OnlyPlayerOrBoss = 0,
			AICharOrElite = 1,
			DefaultOrAtmosphere = 2
		}
	
		private class TempBuffer // TypeDefIndex: 77522
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
			internal TempBuffer(ClothSerializeData sdata); // 0x00000001889D5A64-0x00000001889D5A6C
	
			// Methods
			internal void Push(ClothSerializeData sdata); // 0x00000001889D56B4-0x00000001889D5A64
			internal void Pop(ClothSerializeData sdata); // 0x00000001889D54BC-0x00000001889D56B4
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77523
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, bool> __9__47_0; // 0x08
			public static Func<Renderer, bool> __9__47_1; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E4CA0-0x00000001871E4D00
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _IsValid_b__47_0(Transform x); // 0x0000000186AC8B20-0x0000000186AC8BB0
			internal bool _IsValid_b__47_1(Renderer x); // 0x00000001889D5A6C-0x00000001889D5AB8
		}
	
		// Constructors
		public ClothSerializeData(); // 0x0000000185F6AE50-0x0000000185F6B460
	
		// Methods
		public bool IsValid(); // 0x0000000185D78740-0x0000000185D78920
		public void DataValidate(); // 0x00000001889D3C8C-0x00000001889D3F5C
		public override int GetHashCode(); // 0x00000001889D3F5C-0x00000001889D4580
		public ClothParameters GetClothParameters(); // 0x0000000185D79140-0x0000000185D793B0
		public string ExportJson(); // 0x000000018783B884-0x000000018783B890
		public bool ImportJson(string json); // 0x00000001889D4750-0x00000001889D487C
		public void Import(ClothSerializeData sdata, bool deepCopy = false /* Metadata: 0x02629F47 */); // 0x00000001889D48A0-0x00000001889D4DC4
		public void Import(BeyondBoneCloth src, bool deepCopy = false /* Metadata: 0x02629F48 */); // 0x00000001889D487C-0x00000001889D48A0
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001889D4580-0x00000001889D4750
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x00000001889D4DC4-0x00000001889D4F54
		public bool IsBoneSpring(); // 0x0000000185D7A770-0x0000000185D7A780
	}

	[Serializable]
	public class ClothSerializeData2 : IDataValidate, IValid, ITransform // TypeDefIndex: 77525
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
		public ClothSerializeData2(); // 0x0000000185F6A9B0-0x0000000185F6AAD0
	
		// Methods
		public bool IsValid(); // 0x00000001851A4410-0x00000001851A4420
		public void DataValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		public override int GetHashCode(); // 0x0000000185829EC0-0x0000000185829ED0
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001889D3C4C-0x00000001889D3C6C
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x00000001889D3C6C-0x00000001889D3C8C
	}

	public enum ClothUpdateMode // TypeDefIndex: 77526
	{
		Normal = 0,
		UnityPhysics = 1,
		Unscaled = 2,
		AnimatorLinkage = 10
	}

	public class BeyondBoneCapsuleCollider : ColliderComponent // TypeDefIndex: 77528
	{
		// Fields
		public Direction direction; // 0x40
		public bool reverseDirection; // 0x44
		public bool radiusSeparation; // 0x45
		public bool alignedOnCenter; // 0x46
	
		// Nested types
		public enum Direction // TypeDefIndex: 77527
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public BeyondBoneCapsuleCollider(); // 0x0000000185F6A930-0x0000000185F6A940
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType(); // 0x0000000186B9EFB0-0x0000000186B9EFF0
		public void SetSize(float startRadius, float endRadius, float length); // 0x00000001889CEF4C-0x00000001889CEF70
		public override Vector3 GetSize(); // 0x0000000186AD8400-0x0000000186AD8430
		public Vector3 GetLocalDir(); // 0x00000001889CEE88-0x00000001889CEF10
		public Vector3 GetLocalUp(); // 0x00000001889CEF10-0x00000001889CEF4C
		public override bool IsReverseDirection(); // 0x000000018226ED80-0x000000018226ED90
		public override void DataValidate(); // 0x00000001889CEE50-0x00000001889CEE88
	}

	public class BeyondBonePlaneCollider : ColliderComponent // TypeDefIndex: 77529
	{
		// Constructors
		public BeyondBonePlaneCollider(); // 0x0000000185F6A3F0-0x0000000185F6A400
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType(); // 0x0000000187233930-0x0000000187233940
		public override void DataValidate(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class BeyondBoneSphereCollider : ColliderComponent // TypeDefIndex: 77530
	{
		// Constructors
		public BeyondBoneSphereCollider(); // 0x0000000185F6A3F0-0x0000000185F6A400
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType(); // 0x00000001851A4410-0x00000001851A4420
		public override void DataValidate(); // 0x00000001889D184C-0x00000001889D1864
		public void SetSize(float radius); // 0x0000000187233940-0x0000000187233960
	}

	public abstract class ColliderComponent : ClothBehaviour, IDataValidate // TypeDefIndex: 77531
	{
		// Fields
		public Vector3 center; // 0x20
		[SerializeField]
		protected Vector3 size; // 0x2C
		private HashSet<int> teamIdSet; // 0x38
	
		// Constructors
		protected ColliderComponent(); // 0x0000000185F6A940-0x0000000185F6A9B0
	
		// Methods
		public abstract ColliderManager.ColliderType GetColliderType();
		public abstract void DataValidate();
		public virtual Vector3 GetSize(); // 0x0000000187233AD0-0x0000000187233AF0
		public void SetSize(Vector3 size); // 0x0000000187233B00-0x0000000187233B10
		public void SetSizeX(float size); // 0x0000000187233340-0x0000000187233350
		public void SetSizeY(float size); // 0x0000000187233880-0x0000000187233890
		public void SetSizeZ(float size); // 0x0000000187233AF0-0x0000000187233B00
		public virtual float GetScale(); // 0x00000001889D4FA8-0x00000001889D4FD8
		public virtual bool IsReverseDirection(); // 0x00000001843FFFF0-0x0000000184400000
		internal void Register(int teamId); // 0x0000000185B1A890-0x0000000185B1A8F0
		internal void Exit(int teamId); // 0x00000001889D4F54-0x00000001889D4FA8
		public void UpdateParameters(); // 0x00000001889D4FE0-0x00000001889D5140
		protected virtual void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnValidate(); // 0x00000001889D4FD8-0x00000001889D4FE0
		protected virtual void OnEnable(); // 0x000000018685C1D0-0x000000018685C3F0
		protected virtual void OnDisable(); // 0x00000001859F2AA0-0x00000001859F2CC0
		protected virtual void OnDestroy(); // 0x00000001859F2850-0x00000001859F2AA0
	}

	[BurstCompile]
	internal static class AngleConstraintJobKernels // TypeDefIndex: 77536
	{
		// Nested types
		public unsafe delegate void AngleConstraintKernel_000000CD_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // TypeDefIndex: 77532; 0x00000001823DF230-0x00000001823DF340
	
		internal static class AngleConstraintKernel_000000CD_BurstDirectCall // TypeDefIndex: 77533
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static AngleConstraintKernel_000000CD_BurstDirectCall(); // 0x000000018633AB30-0x000000018633AB40
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a5d4e); // 0x00000001889CDEB0-0x00000001889CDFB4
			private static IntPtr GetFunctionPointer(); // 0x00000001889CDFB4-0x00000001889CE008
			public static void Constructor(); // 0x000000018633AF50-0x000000018633AFE0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // 0x00000001889CE008-0x00000001889CE2AC
		}
	
		public unsafe delegate void AngleConstraintRangeKernel_000000CE_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // TypeDefIndex: 77534; 0x00000001889CE99C-0x00000001889CEAA0
	
		internal static class AngleConstraintRangeKernel_000000CE_BurstDirectCall // TypeDefIndex: 77535
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static AngleConstraintRangeKernel_000000CE_BurstDirectCall(); // 0x000000018633AB40-0x000000018633AB50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a5d93); // 0x00000001889CE4B8-0x00000001889CE5BC
			private static IntPtr GetFunctionPointer(); // 0x00000001889CE5BC-0x00000001889CE610
			public static void Constructor(); // 0x000000018633AFE0-0x000000018633B070
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // 0x00000001889CE610-0x00000001889CE8AC
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void AngleConstraintKernel(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // 0x00000001889CC278-0x00000001889CC2F8
		[BurstCompile]
		internal static unsafe void AngleConstraintRangeKernel(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // 0x00000001889CC2F8-0x00000001889CC378
		[BurstCompile]
		public static unsafe void AngleConstraintKernel_BurstManaged(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // 0x00000001889CABF8-0x00000001889CC278
		[BurstCompile]
		public static unsafe void AngleConstraintRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // 0x00000001889C9F00-0x00000001889CA0A0
	}

	public class AngleConstraint : IDisposable // TypeDefIndex: 77541
	{
		// Fields
		private NativeArray<float> lengthBuffer; // 0x10
		private NativeArray<float3> localPosBuffer; // 0x20
		private NativeArray<quaternion> localRotBuffer; // 0x30
		private NativeArray<quaternion> rotationBuffer; // 0x40
		private NativeArray<float3> restorationVectorBuffer; // 0x50
	
		// Nested types
		[Serializable]
		public class RestorationSerializeData : IDataValidate // TypeDefIndex: 77537
		{
			// Fields
			public bool useAngleRestoration; // 0x10
			public CurveSerializeData stiffness; // 0x18
			[Range(0f, 1f)]
			public float velocityAttenuation; // 0x20
			[Range(0f, 1f)]
			public float gravityFalloff; // 0x24
	
			// Constructors
			public RestorationSerializeData(); // 0x0000000185F6B800-0x0000000185F6B8A0
	
			// Methods
			public void DataValidate(); // 0x00000001889D546C-0x00000001889D54BC
			public RestorationSerializeData Clone(); // 0x00000001889D53E0-0x00000001889D546C
		}
	
		[Serializable]
		public class LimitSerializeData : IDataValidate // TypeDefIndex: 77538
		{
			// Fields
			public bool useAngleLimit; // 0x10
			public CurveSerializeData limitAngle; // 0x18
			[Range(0f, 1f)]
			public float stiffness; // 0x20
	
			// Constructors
			public LimitSerializeData(); // 0x0000000185F6B760-0x0000000185F6B800
	
			// Methods
			public void DataValidate(); // 0x00000001889D53A0-0x00000001889D53E0
			public LimitSerializeData Clone(); // 0x00000001889D5318-0x00000001889D53A0
		}
	
		public struct AngleConstraintParams // TypeDefIndex: 77539
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
			public void Convert(RestorationSerializeData restorationData, LimitSerializeData limitData); // 0x0000000185D793B0-0x0000000185D794D0
		}
	
		[BurstCompile]
		private struct AngleConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77540
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233920-0x0000000187233930
			public void Execute(); // 0x00000001889CC378-0x00000001889CC3D8
			public void Execute(int index); // 0x00000001889CC3D8-0x00000001889CDB98
			public void UnsafeDo(); // 0x00000001889CDB98-0x00000001889CDEB0
		}
	
		// Constructors
		public AngleConstraint(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x00000001889CEB60-0x00000001889CEBF4
		internal void WorkBufferUpdate(); // 0x00000001854CCF40-0x00000001854CD220
		public override string ToString(); // 0x00000001889CEBF4-0x00000001889CEE50
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x000000018592F440-0x000000018592F960
	}

	public class ColliderCollisionConstraint : IDisposable // TypeDefIndex: 77563
	{
		// Fields
		private NativeArray<int> tempFrictionArray; // 0x10
		private NativeArray<int> tempNormalArray; // 0x20
	
		// Nested types
		[BurstCompile]
		private static class PointColliderCollisionConstraintJobKernels // TypeDefIndex: 77546
		{
			// Nested types
			public unsafe delegate void PointColliderCollisionConstraintKernel_000000E4_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // TypeDefIndex: 77542; 0x00000001823A52D0-0x00000001823A5380
	
			internal static class PointColliderCollisionConstraintKernel_000000E4_BurstDirectCall // TypeDefIndex: 77543
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PointColliderCollisionConstraintKernel_000000E4_BurstDirectCall(); // 0x000000018633AB50-0x000000018633AB60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a5e19); // 0x00000001889E839C-0x00000001889E84A0
				private static IntPtr GetFunctionPointer(); // 0x00000001889E84A0-0x00000001889E84F4
				public static void Constructor(); // 0x000000018633B070-0x000000018633B100
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // 0x00000001889E84F4-0x00000001889E86C0
			}
	
			public unsafe delegate void PointColliderCollisionConstraintRangeKernel_000000E5_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // TypeDefIndex: 77544; 0x00000001823A7D60-0x00000001823A7E10
	
			internal static class PointColliderCollisionConstraintRangeKernel_000000E5_BurstDirectCall // TypeDefIndex: 77545
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PointColliderCollisionConstraintRangeKernel_000000E5_BurstDirectCall(); // 0x000000018633AB60-0x000000018633AB70
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a5e49); // 0x00000001889E8878-0x00000001889E897C
				private static IntPtr GetFunctionPointer(); // 0x00000001889E897C-0x00000001889E89D0
				public static void Constructor(); // 0x000000018633B100-0x000000018633B190
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // 0x00000001889E89D0-0x00000001889E8B98
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PointColliderCollisionConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // 0x00000001889E6958-0x00000001889E69D8
			[BurstCompile]
			internal static unsafe void PointColliderCollisionConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // 0x00000001889E69D8-0x00000001889E6A58
			private static double PointSphereColliderDetection(ref double3 nextpos, [IsReadOnly] in double3 basePos, float radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, bool isSpring, float maxLength, out float3 normal); // 0x00000001889E6B5C-0x00000001889E6E68
			private static double PointPlaneColliderDetction(ref double3 nextpos, float radius, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E6A58-0x00000001889E6B5C
			private static double PointCapsuleColliderDetection(ref double3 nextpos, float radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E5970-0x00000001889E5CA8
			[BurstCompile]
			public static unsafe void PointColliderCollisionConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // 0x00000001889E5CA8-0x00000001889E6958
			[BurstCompile]
			public static unsafe void PointColliderCollisionConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // 0x00000001889DBC9C-0x00000001889DBD9C
		}
	
		[BurstCompile]
		private static class EdgeColliderCollisionConstraintJobKernels // TypeDefIndex: 77551
		{
			// Nested types
			public unsafe delegate void EdgeColliderCollisionConstraintKernel_000000E9_PostfixBurstDelegate(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // TypeDefIndex: 77547; 0x00000001823F40A0-0x00000001823F4180
	
			internal static class EdgeColliderCollisionConstraintKernel_000000E9_BurstDirectCall // TypeDefIndex: 77548
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EdgeColliderCollisionConstraintKernel_000000E9_BurstDirectCall(); // 0x000000018633AB70-0x000000018633AB80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a5ed9); // 0x00000001889E2DB0-0x00000001889E2EB4
				private static IntPtr GetFunctionPointer(); // 0x00000001889E2EB4-0x00000001889E2F08
				public static void Constructor(); // 0x000000018633B190-0x000000018633B220
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001889E2F08-0x00000001889E314C
			}
	
			public unsafe delegate void EdgeColliderCollisionConstraintRangeKernel_000000EA_PostfixBurstDelegate(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // TypeDefIndex: 77549; 0x00000001889E3794-0x00000001889E3870
	
			internal static class EdgeColliderCollisionConstraintRangeKernel_000000EA_BurstDirectCall // TypeDefIndex: 77550
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EdgeColliderCollisionConstraintRangeKernel_000000EA_BurstDirectCall(); // 0x000000018633AB80-0x000000018633AB90
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a5f15); // 0x00000001889E3334-0x00000001889E3438
				private static IntPtr GetFunctionPointer(); // 0x00000001889E3438-0x00000001889E348C
				public static void Constructor(); // 0x000000018633B220-0x000000018633B2B0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001889E348C-0x00000001889E36C8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void EdgeColliderCollisionConstraintKernel(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001889E05B0-0x00000001889E0630
			[BurstCompile]
			internal static unsafe void EdgeColliderCollisionConstraintRangeKernel(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001889E0630-0x00000001889E06B0
			private static float EdgeSphereColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, double cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E083C-0x00000001889E0DA4
			private static double EdgeCapsuleColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, double cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889DF050-0x00000001889DF874
			private static double EdgePlaneColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E06B0-0x00000001889E083C
			[BurstCompile]
			public static unsafe void EdgeColliderCollisionConstraintKernel_BurstManaged(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001889DF874-0x00000001889E05B0
			[BurstCompile]
			public static unsafe void EdgeColliderCollisionConstraintRangeKernel_BurstManaged(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001889D92D4-0x00000001889D944C
		}
	
		[BurstCompile]
		private static class SolveEdgeBufferAndClearJobKernels // TypeDefIndex: 77556
		{
			// Nested types
			public unsafe delegate void SolveEdgeBufferAndClearKernel_000000EE_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // TypeDefIndex: 77552; 0x00000001823BBF70-0x00000001823BBFF0
	
			internal static class SolveEdgeBufferAndClearKernel_000000EE_BurstDirectCall // TypeDefIndex: 77553
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveEdgeBufferAndClearKernel_000000EE_BurstDirectCall(); // 0x000000018633AB90-0x000000018633ABA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a5f69); // 0x00000001889EB3EC-0x00000001889EB4F0
				private static IntPtr GetFunctionPointer(); // 0x00000001889EB4F0-0x00000001889EB544
				public static void Constructor(); // 0x000000018633B2B0-0x000000018633B340
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001889EB544-0x00000001889EB680
			}
	
			public unsafe delegate void SolveEdgeBufferAndClearRangeKernel_000000EF_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // TypeDefIndex: 77554; 0x000000018240B340-0x000000018240B3C0
	
			internal static class SolveEdgeBufferAndClearRangeKernel_000000EF_BurstDirectCall // TypeDefIndex: 77555
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveEdgeBufferAndClearRangeKernel_000000EF_BurstDirectCall(); // 0x000000018633ABA0-0x000000018633ABB0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a5f8d); // 0x00000001889EB810-0x00000001889EB914
				private static IntPtr GetFunctionPointer(); // 0x00000001889EB914-0x00000001889EB968
				public static void Constructor(); // 0x000000018633B340-0x000000018633B3D0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001889EB968-0x00000001889EBAD8
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolveEdgeBufferAndClearKernel(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001889EAF1C-0x00000001889EAF98
			[BurstCompile]
			internal static unsafe void SolveEdgeBufferAndClearRangeKernel(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001889EB05C-0x00000001889EB0D8
			[BurstCompile]
			public static unsafe void SolveEdgeBufferAndClearKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // 0x00000001889DBD9C-0x00000001889DC178
			[BurstCompile]
			public static unsafe void SolveEdgeBufferAndClearRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // 0x00000001889EAF98-0x00000001889EB05C
		}
	
		public enum Mode // TypeDefIndex: 77557
		{
			None = 0,
			Point = 1,
			Edge = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate, ITransform // TypeDefIndex: 77558
		{
			// Fields
			public Mode mode; // 0x10
			[Range(0f, 0.5f)]
			public float friction; // 0x14
			public List<ColliderComponent> colliderList; // 0x18
			public List<Transform> collisionBones; // 0x20
			public CurveSerializeData limitDistance; // 0x28
	
			// Properties
			public int ColliderLength { get; } // 0x0000000186CABE80-0x0000000186CABEC0 
	
			// Constructors
			public SerializeData(); // 0x0000000185F6AD30-0x0000000185F6AE50
	
			// Methods
			public void DataValidate(); // 0x00000001889EAA30-0x00000001889EAA84
			public SerializeData Clone(); // 0x00000001889EA7B8-0x00000001889EA8D8
			public override int GetHashCode(); // 0x00000001889EAB14-0x00000001889EAC70
			public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001889EAC70-0x00000001889EADD4
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x00000001889EADD4-0x00000001889EAF1C
		}
	
		public struct ColliderCollisionConstraintParams // TypeDefIndex: 77559
		{
			// Fields
			public Mode mode; // 0x00
			public float dynamicFriction; // 0x04
			public float staticFriction; // 0x08
			public float4x4 limitDistance; // 0x0C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x0000000185D79870-0x0000000185D798B0
		}
	
		[BurstCompile]
		private struct PointColliderCollisionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77560
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B40-0x0000000187233B50
			public void Execute(); // 0x00000001889E6E68-0x00000001889E6EC8
			public void UnsafeDo(); // 0x00000001889E81F8-0x00000001889E839C
			public void Execute(int index); // 0x00000001889E6EC8-0x00000001889E7B94
			private double PointSphereColliderDetection(ref double3 nextpos, [IsReadOnly] in double3 basePos, double radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, bool isSpring, double maxLength, out float3 normal); // 0x00000001889E7F2C-0x00000001889E81F8
			private double PointPlaneColliderDetction(ref double3 nextpos, double radius, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E7E5C-0x00000001889E7F2C
			private double PointCapsuleColliderDetection(ref double3 nextpos, double radius, [IsReadOnly] in AABB aabb, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E7B94-0x00000001889E7E5C
		}
	
		[BurstCompile]
		private struct EdgeColliderCollisionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77561
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B20-0x0000000187233B30
			public void Execute(); // 0x00000001889E1C78-0x00000001889E1CD8
			public void Execute(int index); // 0x00000001889E1CD8-0x00000001889E2ADC
			private double EdgeSphereColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, float cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E1748-0x00000001889E1C78
			private double EdgeCapsuleColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in AABB aabbE, float cfr, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E0DA4-0x00000001889E15B8
			private double EdgePlaneColliderDetection(ref double3x2 nextPosE, [IsReadOnly] in double2 radiusE, [IsReadOnly] in ColliderManager.WorkData cwork, out float3 normal); // 0x00000001889E15B8-0x00000001889E1748
			public void UnsafeDo(); // 0x00000001889E2ADC-0x00000001889E2DB0
		}
	
		[BurstCompile]
		private struct SolveEdgeBufferAndClearJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77562
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B50-0x0000000187233B60
			public void Execute(); // 0x00000001889EB0D8-0x00000001889EB138
			public void Execute(int index); // 0x00000001889EB138-0x00000001889EB2F8
			public void UnsafeDo(); // 0x00000001889EB2F8-0x00000001889EB3EC
		}
	
		// Constructors
		public ColliderCollisionConstraint(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x00000001889DC83C-0x00000001889DC888
		internal void WorkBufferUpdate(); // 0x0000000186233F30-0x0000000186233F80
		public override string ToString(); // 0x00000001889DC888-0x00000001889DC9D8
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x0000000185BA76B0-0x0000000185BA7B50
		public static void Initialize_PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000E4_BurstDirectCall(); // 0x0000000186B31780-0x0000000186B317C0
		public static void Initialize_PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000E5_BurstDirectCall(); // 0x0000000186B31740-0x0000000186B31780
		public static void Initialize_EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E9_BurstDirectCall(); // 0x0000000186B31700-0x0000000186B31740
		public static void Initialize_EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000EA_BurstDirectCall(); // 0x0000000186B316C0-0x0000000186B31700
		public static void Initialize_SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000EE_BurstDirectCall(); // 0x0000000186B31680-0x0000000186B316C0
		public static void Initialize_SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000EF_BurstDirectCall(); // 0x0000000186B31640-0x0000000186B31680
	}

	[BurstCompile]
	internal static class DistanceConstraintJobKernels // TypeDefIndex: 77568
	{
		// Nested types
		public unsafe delegate void DistanceConstraintKernel_0000010A_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // TypeDefIndex: 77564; 0x00000001889DE750-0x00000001889DE804
	
		internal static class DistanceConstraintKernel_0000010A_BurstDirectCall // TypeDefIndex: 77565
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static DistanceConstraintKernel_0000010A_BurstDirectCall(); // 0x000000018633ABB0-0x000000018633ABC0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6022); // 0x00000001889DE30C-0x00000001889DE410
			private static IntPtr GetFunctionPointer(); // 0x00000001889DE410-0x00000001889DE464
			public static void Constructor(); // 0x000000018633B3D0-0x000000018633B460
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // 0x00000001889DE464-0x00000001889DE64C
		}
	
		public unsafe delegate void DistanceConstraintRangeKernel_0000010B_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // TypeDefIndex: 77566; 0x00000001889DECA8-0x00000001889DED60
	
		internal static class DistanceConstraintRangeKernel_0000010B_BurstDirectCall // TypeDefIndex: 77567
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static DistanceConstraintRangeKernel_0000010B_BurstDirectCall(); // 0x000000018633ABC0-0x000000018633ABD0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6055); // 0x00000001889DE8C4-0x00000001889DE9C8
			private static IntPtr GetFunctionPointer(); // 0x00000001889DE9C8-0x00000001889DEA1C
			public static void Constructor(); // 0x000000018633B460-0x000000018633B4F0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // 0x00000001889DEA1C-0x00000001889DEC00
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void DistanceConstraintKernel(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // 0x00000001889DD4CC-0x00000001889DD54C
		[BurstCompile]
		internal static unsafe void DistanceConstraintRangeKernel(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // 0x00000001889DD54C-0x00000001889DD5CC
		[BurstCompile]
		public static unsafe void DistanceConstraintKernel_BurstManaged(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // 0x00000001889DC9D8-0x00000001889DD4CC
		[BurstCompile]
		public static unsafe void DistanceConstraintRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // 0x00000001889D8484-0x00000001889D92D4
	}

	public class DistanceConstraint : IDisposable // TypeDefIndex: 77573
	{
		// Fields
		public const int TypeCount = 2; // Metadata: 0x02629F59
		public ExNativeArray<uint> indexArray; // 0x10
		public ExNativeArray<ushort> dataArray; // 0x18
		public ExNativeArray<float> distanceArray; // 0x20
	
		// Properties
		public int DataCount { get; } // 0x00000001889DF018-0x00000001889DF050 
	
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 77569
		{
			// Fields
			public CurveSerializeData stiffness; // 0x10
	
			// Constructors
			public SerializeData(); // 0x0000000185F6B630-0x0000000185F6B6C0
	
			// Methods
			public void DataValidate(); // 0x00000001889EA8D8-0x00000001889EA904
			public SerializeData Clone(); // 0x00000001889EA544-0x00000001889EA5BC
		}
	
		public struct DistanceConstraintParams // TypeDefIndex: 77570
		{
			// Fields
			public float4x4 restorationStiffness; // 0x00
			public float velocityAttenuation; // 0x40
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x0000000185D790E0-0x0000000185D79140
		}
	
		[Serializable]
		public class ConstraintData : IValid // TypeDefIndex: 77571
		{
			// Fields
			public ResultCode result; // 0x10
			public uint[] indexArray; // 0x18
			public ushort[] dataArray; // 0x20
			public float[] distanceArray; // 0x28
	
			// Constructors
			public ConstraintData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool IsValid(); // 0x0000000185B93FC0-0x0000000185B93FE0
		}
	
		[BurstCompile]
		private struct DistanceConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77572
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B10-0x0000000187233B20
			public void Execute(); // 0x00000001889DD5CC-0x00000001889DD62C
			public void Execute(int index); // 0x00000001889DD62C-0x00000001889DE148
			public void UnsafeDo(); // 0x00000001889DE148-0x00000001889DE30C
		}
	
		// Constructors
		public DistanceConstraint(); // 0x000000018609BBA0-0x000000018609BE50
	
		// Methods
		public void Dispose(); // 0x00000001889DEE20-0x00000001889DEEA4
		public override string ToString(); // 0x00000001889DEEA4-0x00000001889DF018
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters); // 0x0000000185B98A70-0x0000000185B9A4C0
		internal void Register(ClothProcess cprocess); // 0x0000000185B93CA0-0x0000000185B93E30
		internal void Exit(ClothProcess cprocess); // 0x00000001859F5120-0x00000001859F5250
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x00000001854D6F20-0x00000001854D7470
	}

	public class InertiaConstraint : IDisposable // TypeDefIndex: 77579
	{
		// Fields
		internal ExNativeArray<ushort> fixedArray; // 0x10
	
		// Nested types
		public enum TeleportMode // TypeDefIndex: 77574
		{
			None = 0,
			Reset = 1,
			Keep = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 77575
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
			public SerializeData(); // 0x0000000185F6BA30-0x0000000185F6BB90
	
			// Methods
			public SerializeData Clone(); // 0x00000001889EA670-0x00000001889EA7B8
			public void DataValidate(); // 0x00000001889EA904-0x00000001889EAA30
		}
	
		public struct InertiaConstraintParams // TypeDefIndex: 77576
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
			public void Convert(SerializeData sdata); // 0x0000000185D79930-0x0000000185D79A30
		}
	
		[Serializable]
		public struct CenterData // TypeDefIndex: 77577
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
			internal void Initialize(); // 0x0000000185B93570-0x0000000185B936C0
		}
	
		[Serializable]
		public class ConstraintData // TypeDefIndex: 77578
		{
			// Fields
			public ResultCode result; // 0x10
			public CenterData centerData; // 0x18
			public float3 initLocalGravityDirection; // 0x2D0
	
			// Constructors
			public ConstraintData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public InertiaConstraint(); // 0x00000001860984E0-0x00000001860985F0
	
		// Methods
		public void Dispose(); // 0x00000001889E3930-0x00000001889E3980
		public override string ToString(); // 0x00000001889E3980-0x00000001889E3A50
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters); // 0x0000000185B947F0-0x0000000185B94E50
		internal void Register(ClothProcess cprocess); // 0x0000000185B93E30-0x0000000185B93FA0
		internal void Exit(ClothProcess cprocess); // 0x00000001859F5060-0x00000001859F5120
	}

	[BurstCompile]
	internal static class MotionConstraintJobKernels // TypeDefIndex: 77584
	{
		// Nested types
		public unsafe delegate void MotionConstraintKernel_0000012A_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // TypeDefIndex: 77580; 0x00000001889E5324-0x00000001889E53C0
	
		internal static class MotionConstraintKernel_0000012A_BurstDirectCall // TypeDefIndex: 77581
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static MotionConstraintKernel_0000012A_BurstDirectCall(); // 0x000000018633ABD0-0x000000018633ABE0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a60c6); // 0x00000001889E4F34-0x00000001889E5038
			private static IntPtr GetFunctionPointer(); // 0x00000001889E5038-0x00000001889E508C
			public static void Constructor(); // 0x000000018633B4F0-0x000000018633B580
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // 0x00000001889E508C-0x00000001889E5238
		}
	
		public unsafe delegate void MotionConstraintRangeKernel_0000012B_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // TypeDefIndex: 77582; 0x00000001889E5810-0x00000001889E58B0
	
		internal static class MotionConstraintRangeKernel_0000012B_BurstDirectCall // TypeDefIndex: 77583
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static MotionConstraintRangeKernel_0000012B_BurstDirectCall(); // 0x000000018633ABE0-0x000000018633ABF0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a60f3); // 0x00000001889E5480-0x00000001889E5584
			private static IntPtr GetFunctionPointer(); // 0x00000001889E5584-0x00000001889E55D8
			public static void Constructor(); // 0x000000018633B580-0x000000018633B610
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x00000001889E55D8-0x00000001889E5780
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void MotionConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // 0x00000001889E4364-0x00000001889E43E0
		[BurstCompile]
		internal static unsafe void MotionConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x00000001889E43E0-0x00000001889E445C
		[BurstCompile]
		public static unsafe void MotionConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // 0x00000001889E3A50-0x00000001889E4364
		[BurstCompile]
		public static unsafe void MotionConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x00000001889DAF04-0x00000001889DBC9C
	}

	public class MotionConstraint : IDisposable // TypeDefIndex: 77588
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 77585
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
			public SerializeData(); // 0x0000000185F6B460-0x0000000185F6B520
	
			// Methods
			public void DataValidate(); // 0x00000001889EAA84-0x00000001889EAB14
			public SerializeData Clone(); // 0x00000001889EA5BC-0x00000001889EA670
		}
	
		public struct MotionConstraintParams // TypeDefIndex: 77586
		{
			// Fields
			public bool useMaxDistance; // 0x00
			public float4x4 maxDistanceCurveData; // 0x04
			public bool useBackstop; // 0x44
			public float backstopRadius; // 0x48
			public float4x4 backstopDistanceCurveData; // 0x4C
			public float stiffness; // 0x8C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x0000000185D794D0-0x0000000185D795C0
		}
	
		[BurstCompile]
		private struct MotionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77587
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B30-0x0000000187233B40
			public void Execute(); // 0x00000001889E4D5C-0x00000001889E4DBC
			public void Execute(int index); // 0x00000001889E445C-0x00000001889E4D5C
			public void UnsafeDo(); // 0x00000001889E4DBC-0x00000001889E4F34
		}
	
		// Constructors
		public MotionConstraint(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x00000001854D39D0-0x00000001854D3E20
	}

	public class SelfCollisionConstraint : IDisposable // TypeDefIndex: 77642
	{
		// Fields
		public const uint KindPoint = 0; // Metadata: 0x02629F5D
		public const uint KindEdge = 1; // Metadata: 0x02629F5E
		public const uint KindTriangle = 2; // Metadata: 0x02629F5F
		public const uint Flag_KindMask = 50331648; // Metadata: 0x02629F60
		public const uint Flag_Fix0 = 67108864; // Metadata: 0x02629F64
		public const uint Flag_Fix1 = 134217728; // Metadata: 0x02629F68
		public const uint Flag_Fix2 = 268435456; // Metadata: 0x02629F6C
		public const uint Flag_AllFix = 536870912; // Metadata: 0x02629F70
		public const uint Flag_Ignore = 1073741824; // Metadata: 0x02629F75
		public const uint Flag_Enable = 2147483648; // Metadata: 0x02629F7A
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
		public int PointPrimitiveCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		public int EdgePrimitiveCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182A819B0-0x0000000182A819C0 0x0000000182A819D0-0x0000000182A819E0
		public int TrianglePrimitiveCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
		public int IntersectCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872333B0-0x00000001872333C0 0x0000000185FD6920-0x0000000185FD6930
	
		// Nested types
		[BurstCompile]
		private static class IntersectUpdatePrimitiveJobKernels // TypeDefIndex: 77593
		{
			// Nested types
			public unsafe delegate void IntersectUpdatePrimitiveKernel_0000014E_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // TypeDefIndex: 77589; 0x0000000181256340-0x0000000181256360
	
			internal static class IntersectUpdatePrimitiveKernel_0000014E_BurstDirectCall // TypeDefIndex: 77590
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static IntersectUpdatePrimitiveKernel_0000014E_BurstDirectCall(); // 0x000000018633ABF0-0x000000018633AC00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6146); // 0x00000001889FB118-0x00000001889FB21C
				private static IntPtr GetFunctionPointer(); // 0x00000001889FB21C-0x00000001889FB270
				public static void Constructor(); // 0x000000018633B610-0x000000018633B6A0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // 0x00000001889FB270-0x00000001889FB340
			}
	
			public unsafe delegate void IntersectUpdatePrimitiveRangeKernel_0000014F_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // TypeDefIndex: 77591; 0x0000000181256340-0x0000000181256360
	
			internal static class IntersectUpdatePrimitiveRangeKernel_0000014F_BurstDirectCall // TypeDefIndex: 77592
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static IntersectUpdatePrimitiveRangeKernel_0000014F_BurstDirectCall(); // 0x000000018633AC00-0x000000018633AC10
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a615e); // 0x00000001889FB4C0-0x00000001889FB5C4
				private static IntPtr GetFunctionPointer(); // 0x00000001889FB5C4-0x00000001889FB618
				public static void Constructor(); // 0x000000018633B6A0-0x000000018633B730
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // 0x00000001889FB618-0x00000001889FB724
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void IntersectUpdatePrimitiveKernel(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // 0x00000001889FAAB8-0x00000001889FAB30
			[BurstCompile]
			internal static unsafe void IntersectUpdatePrimitiveRangeKernel(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // 0x00000001889FABBC-0x00000001889FAC34
			[BurstCompile]
			public static unsafe void IntersectUpdatePrimitiveKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // 0x00000001889F4CA8-0x00000001889F50A8
			[BurstCompile]
			public static unsafe void IntersectUpdatePrimitiveRangeKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // 0x00000001889FAB30-0x00000001889FABBC
		}
	
		[BurstCompile]
		private static class UpdatePrimitiveJobKernels // TypeDefIndex: 77598
		{
			// Nested types
			public unsafe delegate void UpdatePrimitiveKernel_00000150_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // TypeDefIndex: 77594; 0x0000000188A085F0-0x0000000188A0867C
	
			internal static class UpdatePrimitiveKernel_00000150_BurstDirectCall // TypeDefIndex: 77595
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdatePrimitiveKernel_00000150_BurstDirectCall(); // 0x000000018633AC10-0x000000018633AC20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a61b2); // 0x0000000188A08220-0x0000000188A08324
				private static IntPtr GetFunctionPointer(); // 0x0000000188A08324-0x0000000188A08378
				public static void Constructor(); // 0x000000018633B730-0x000000018633B7C0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // 0x0000000188A08378-0x0000000188A084F8
			}
	
			public unsafe delegate void UpdatePrimitiveRangeKernel_00000151_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // TypeDefIndex: 77596; 0x00000001826EC500-0x00000001826EC590
	
			internal static class UpdatePrimitiveRangeKernel_00000151_BurstDirectCall // TypeDefIndex: 77597
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdatePrimitiveRangeKernel_00000151_BurstDirectCall(); // 0x000000018633AC20-0x000000018633AC30
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a61dc); // 0x0000000188A0872C-0x0000000188A08830
				private static IntPtr GetFunctionPointer(); // 0x0000000188A08830-0x0000000188A08884
				public static void Constructor(); // 0x000000018633B7C0-0x000000018633B850
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // 0x0000000188A08884-0x0000000188A08A08
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void UpdatePrimitiveKernel(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // 0x0000000188A076E8-0x0000000188A07760
			[BurstCompile]
			internal static unsafe void UpdatePrimitiveRangeKernel(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // 0x0000000188A07760-0x0000000188A077D8
			[BurstCompile]
			public static unsafe void UpdatePrimitiveKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // 0x0000000188A06E94-0x0000000188A076E8
			[BurstCompile]
			public static unsafe void UpdatePrimitiveRangeKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // 0x00000001889F83B8-0x00000001889F8524
		}
	
		[BurstCompile]
		private static class ClearBufferJobKernels // TypeDefIndex: 77601
		{
			// Nested types
			public delegate void ClearBufferKernel_00000152_PostfixBurstDelegate(); // TypeDefIndex: 77599; 0x0000000185B44B70-0x0000000185B44B80
	
			internal static class ClearBufferKernel_00000152_BurstDirectCall // TypeDefIndex: 77600
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearBufferKernel_00000152_BurstDirectCall(); // 0x000000018633AC30-0x000000018633AC40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a61ee); // 0x00000001889F860C-0x00000001889F8710
				private static IntPtr GetFunctionPointer(); // 0x00000001889F8710-0x00000001889F8764
				public static void Constructor(); // 0x000000018633B850-0x000000018633B8E0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static void Invoke(); // 0x00000001889F8764-0x00000001889F87C8
			}
	
			// Methods
			[BurstCompile]
			internal static void ClearBufferKernel(); // 0x00000001889F8574-0x00000001889F85B4
			[BurstCompile]
			public static void ClearBufferKernel_BurstManaged(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[BurstCompile]
		private static class SortJobKernels // TypeDefIndex: 77606
		{
			// Nested types
			public unsafe delegate void SortKernel_00000153_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // TypeDefIndex: 77602; 0x00000001811CDB70-0x00000001811CDB90
	
			internal static class SortKernel_00000153_BurstDirectCall // TypeDefIndex: 77603
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SortKernel_00000153_BurstDirectCall(); // 0x000000018633AC40-0x000000018633AC50
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a620c); // 0x0000000188A01450-0x0000000188A01554
				private static IntPtr GetFunctionPointer(); // 0x0000000188A01554-0x0000000188A015A8
				public static void Constructor(); // 0x000000018633B8E0-0x000000018633B970
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // 0x0000000188A015A8-0x0000000188A01658
			}
	
			public unsafe delegate void SortRangeKernel_00000154_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // TypeDefIndex: 77604; 0x00000001811CDB70-0x00000001811CDB90
	
			internal static class SortRangeKernel_00000154_BurstDirectCall // TypeDefIndex: 77605
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SortRangeKernel_00000154_BurstDirectCall(); // 0x000000018633AC50-0x000000018633AC60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a621e); // 0x0000000188A017B8-0x0000000188A018BC
				private static IntPtr GetFunctionPointer(); // 0x0000000188A018BC-0x0000000188A01910
				public static void Constructor(); // 0x000000018633B970-0x000000018633BA00
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // 0x0000000188A01910-0x0000000188A019E0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SortKernel(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // 0x0000000188A00E10-0x0000000188A00E88
			[BurstCompile]
			internal static unsafe void SortRangeKernel(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // 0x0000000188A00EF0-0x0000000188A00F68
			[BurstCompile]
			public static unsafe void SortKernel_BurstManaged(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // 0x0000000188A009D0-0x0000000188A00E10
			[BurstCompile]
			public static unsafe void SortRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // 0x0000000188A00E88-0x0000000188A00EF0
		}
	
		public enum SelfCollisionMode // TypeDefIndex: 77607
		{
			None = 0,
			FullMesh = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 77608
		{
			// Fields
			public SelfCollisionMode selfMode; // 0x10
			public CurveSerializeData surfaceThickness; // 0x18
			public SelfCollisionMode syncMode; // 0x20
			public BeyondBoneCloth syncPartner; // 0x28
			[Range(0f, 1f)]
			public float clothMass; // 0x30
	
			// Constructors
			public SerializeData(); // 0x0000000185F6B6C0-0x0000000185F6B760
	
			// Methods
			public void DataValidate(); // 0x00000001889FCF44-0x00000001889FCF8C
			public SerializeData Clone(); // 0x00000001889FCEA4-0x00000001889FCF44
			public BeyondBoneCloth GetSyncPartner(); // 0x0000000185D7A760-0x0000000185D7A770
		}
	
		public struct SelfCollisionConstraintParams // TypeDefIndex: 77609
		{
			// Fields
			public SelfCollisionMode selfMode; // 0x00
			public float4x4 surfaceThicknessCurveData; // 0x04
			public SelfCollisionMode syncMode; // 0x44
			public float clothMass; // 0x48
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x0000000185D79040-0x0000000185D790E0
		}
	
		private struct Primitive // TypeDefIndex: 77610
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
			public bool IsIgnore(); // 0x00000001889FCD68-0x00000001889FCD74
			public bool HasParticle(int p); // 0x00000001889FCD14-0x00000001889FCD68
			public uint GetKind(); // 0x0000000187233CA0-0x0000000187233CB0
			public int GetTeamId(); // 0x0000000187233CD0-0x0000000187233CE0
			public float GetSolveThickness([IsReadOnly] in Primitive pri); // 0x0000000187233CB0-0x0000000187233CD0
			public bool AnyParticle([IsReadOnly] in Primitive pri); // 0x00000001889F5868-0x00000001889F5C60
		}
	
		private struct SortData : IComparable<SortData> // TypeDefIndex: 77611
		{
			// Fields
			public uint flagAndTeamId; // 0x00
			public int primitiveIndex; // 0x04
			public double2 firstMinMax; // 0x08
			public double2 secondMinMax; // 0x18
			public double2 thirdMinMax; // 0x28
	
			// Methods
			public int CompareTo(SortData other); // 0x0000000188A009B4-0x0000000188A009D0
			public uint GetKind(); // 0x0000000187233CA0-0x0000000187233CB0
		}
	
		internal struct EdgeEdgeContact // TypeDefIndex: 77612
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
			public override string ToString(); // 0x00000001889F963C-0x00000001889F9820
		}
	
		internal struct PointTriangleContact // TypeDefIndex: 77613
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
			public override string ToString(); // 0x00000001889FCA48-0x00000001889FCC54
		}
	
		[BurstCompile]
		private struct InitPrimitiveJob : IJobParallelFor // TypeDefIndex: 77614
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
			public void Execute(int index); // 0x00000001889F98E0-0x00000001889F9B74
		}
	
		[BurstCompile]
		private struct ClearBufferJob : IJob // TypeDefIndex: 77615
		{
			// Fields
			[WriteOnly]
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x00
			[WriteOnly]
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889F85B4-0x00000001889F860C
		}
	
		[BurstCompile]
		private struct UpdatePrimitiveJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77616
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233D30-0x0000000187233D40
			public void Execute(); // 0x0000000188A0807C-0x0000000188A080DC
			public void Execute(int index); // 0x0000000188A077D8-0x0000000188A0807C
			public void UnsafeDo(); // 0x0000000188A080DC-0x0000000188A08220
		}
	
		[BurstCompile]
		private struct SortJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77617
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
			public void SetIndexCount(int indexCount); // 0x0000000186033510-0x0000000186033520
			public void Execute(); // 0x0000000188A013B0-0x0000000188A013F0
			public void Execute(int index); // 0x0000000188A00F68-0x0000000188A013B0
			public void UnsafeDo(); // 0x0000000188A013F0-0x0000000188A01450
		}
	
		[BurstCompile]
		private struct PointTriangleBroadPhaseJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 77618
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B30-0x0000000187233B40
			public void Execute(); // 0x00000001889FC6C8-0x00000001889FC728
			public void Execute(int index); // 0x00000001889FBDE0-0x00000001889FC6C8
			private void SweepTest(int sortIndex, ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck); // 0x00000001889FC728-0x00000001889FCA48
			private void BroadPointTriangle(ref Primitive p_pri, ref Primitive t_pri, float thickness, float scr, float ang); // 0x00000001889FB7DC-0x00000001889FBDE0
		}
	
		[BurstCompile]
		private struct EdgeEdgeBroadPhaseJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 77619
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233C70-0x0000000187233C80
			public void Execute(); // 0x00000001889F8CC8-0x00000001889F8D24
			public void Execute(int index); // 0x00000001889F8D24-0x00000001889F93A0
			private void SweepTest(int sortIndex, ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck); // 0x00000001889F93A0-0x00000001889F963C
			private void BroadEdgeEdge(ref Primitive pri0, ref Primitive pri1, float thickness, float scr); // 0x00000001889F87C8-0x00000001889F8CC8
		}
	
		[BurstCompile]
		private struct EdgeEdgeToListJob : IJob // TypeDefIndex: 77620
		{
			// Fields
			[ReadOnly]
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889F9820-0x00000001889F98E0
		}
	
		[BurstCompile]
		private struct PointTriangleToListJob : IJob // TypeDefIndex: 77621
		{
			// Fields
			[ReadOnly]
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x00
			[NativeDisableParallelForRestriction]
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889FCC54-0x00000001889FCD14
		}
	
		[BurstCompile]
		private struct UpdateEdgeEdgeBroadPhaseJob : IJobParallelForDefer // TypeDefIndex: 77622
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<float3> oldPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x20
	
			// Methods
			public void Execute(int index); // 0x0000000188A05BF4-0x0000000188A062E4
		}
	
		[BurstCompile]
		private struct UpdatePointTriangleBroadPhaseJob : IJobParallelForDefer // TypeDefIndex: 77623
		{
			// Fields
			[ReadOnly]
			public NativeArray<double3> nextPosArray; // 0x00
			[ReadOnly]
			public NativeArray<double3> oldPosArray; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x20
	
			// Methods
			public void Execute(int index); // 0x0000000188A068EC-0x0000000188A06E94
		}
	
		[BurstCompile]
		private struct SolverEdgeEdgeJob : IJobParallelForDefer // TypeDefIndex: 77624
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
			public void Execute(int index); // 0x00000001889FECAC-0x00000001889FF2A4
		}
	
		[BurstCompile]
		private struct SolverPointTriangleJob : IJobParallelForDefer // TypeDefIndex: 77625
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
			public void Execute(int index); // 0x0000000188A00168-0x0000000188A009B4
		}
	
		[BurstCompile]
		private struct IntersectUpdatePrimitiveJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77626
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233C90-0x0000000187233CA0
			public void Execute(); // 0x00000001889FB02C-0x00000001889FB088
			public void Execute(int index); // 0x00000001889FAC34-0x00000001889FB02C
			public void UnsafeDo(); // 0x00000001889FB088-0x00000001889FB118
		}
	
		[BurstCompile]
		private struct IntersectEdgeTriangleJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 77627
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233C80-0x0000000187233C90
			public void Execute(); // 0x00000001889FA438-0x00000001889FA494
			public void Execute(int index); // 0x00000001889F9B74-0x00000001889FA438
			private void SweepTest(ref Primitive primitive0, [IsReadOnly] in SortData sd0, [IsReadOnly] in DataChunk subChunk, bool connectionCheck); // 0x00000001889FA844-0x00000001889FAAB8
			private void IntersectTest(ref Primitive epri, ref Primitive tpri); // 0x00000001889FA494-0x00000001889FA844
		}
	
		[BurstCompile]
		private static class SolverPointTriangleCrossFrameJobKernels // TypeDefIndex: 77632
		{
			// Nested types
			public unsafe delegate void SolverPointTriangleCrossFrameKernel_00000187_PostfixBurstDelegate(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 77628; 0x00000001812083C0-0x00000001812083E0
	
			internal static class SolverPointTriangleCrossFrameKernel_00000187_BurstDirectCall // TypeDefIndex: 77629
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverPointTriangleCrossFrameKernel_00000187_BurstDirectCall(); // 0x000000018633AC60-0x000000018633AC70
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6276); // 0x00000001889FFBB8-0x00000001889FFCBC
				private static IntPtr GetFunctionPointer(); // 0x00000001889FFCBC-0x00000001889FFD10
				public static void Constructor(); // 0x000000018633BA00-0x000000018633BA90
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // 0x00000001889FFD10-0x00000001889FFDD8
			}
	
			public unsafe delegate void SolverPointTriangleCrossFrameRangeKernel_00000188_PostfixBurstDelegate(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 77630; 0x00000001812083C0-0x00000001812083E0
	
			internal static class SolverPointTriangleCrossFrameRangeKernel_00000188_BurstDirectCall // TypeDefIndex: 77631
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverPointTriangleCrossFrameRangeKernel_00000188_BurstDirectCall(); // 0x000000018633AC70-0x000000018633AC80
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a628b); // 0x00000001889FFE84-0x00000001889FFF88
				private static IntPtr GetFunctionPointer(); // 0x00000001889FFF88-0x00000001889FFFDC
				public static void Constructor(); // 0x000000018633BA90-0x000000018633BB20
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // 0x00000001889FFFDC-0x0000000188A000BC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolverPointTriangleCrossFrameKernel(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // 0x00000001889FF2A4-0x00000001889FF31C
			[BurstCompile]
			internal static unsafe void SolverPointTriangleCrossFrameRangeKernel(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // 0x00000001889FF38C-0x00000001889FF404
			[BurstCompile]
			public static unsafe void SolverPointTriangleCrossFrameKernel_BurstManaged(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // 0x00000001889F635C-0x00000001889F72F4
			[BurstCompile]
			public static unsafe void SolverPointTriangleCrossFrameRangeKernel_BurstManaged(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // 0x00000001889FF31C-0x00000001889FF38C
		}
	
		[BurstCompile]
		private static class SolverEdgeEdgeCrossFrameJobKernels // TypeDefIndex: 77637
		{
			// Nested types
			public unsafe delegate void SolverEdgeEdgeCrossFrameKernel_00000189_PostfixBurstDelegate(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 77633; 0x00000001812083C0-0x00000001812083E0
	
			internal static class SolverEdgeEdgeCrossFrameKernel_00000189_BurstDirectCall // TypeDefIndex: 77634
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverEdgeEdgeCrossFrameKernel_00000189_BurstDirectCall(); // 0x000000018633AC80-0x000000018633AC90
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a62b4); // 0x00000001889FE63C-0x00000001889FE740
				private static IntPtr GetFunctionPointer(); // 0x00000001889FE740-0x00000001889FE794
				public static void Constructor(); // 0x000000018633BB20-0x000000018633BBB0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // 0x00000001889FE794-0x00000001889FE85C
			}
	
			public unsafe delegate void SolverEdgeEdgeCrossFrameRangeKernel_0000018A_PostfixBurstDelegate(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 77635; 0x00000001812083C0-0x00000001812083E0
	
			internal static class SolverEdgeEdgeCrossFrameRangeKernel_0000018A_BurstDirectCall // TypeDefIndex: 77636
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverEdgeEdgeCrossFrameRangeKernel_0000018A_BurstDirectCall(); // 0x000000018633AC90-0x000000018633ACA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a62c9); // 0x00000001889FE9C8-0x00000001889FEACC
				private static IntPtr GetFunctionPointer(); // 0x00000001889FEACC-0x00000001889FEB20
				public static void Constructor(); // 0x000000018633BBB0-0x000000018633BC40
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // 0x00000001889FEB20-0x00000001889FEC00
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolverEdgeEdgeCrossFrameKernel(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // 0x00000001889FDD18-0x00000001889FDD90
			[BurstCompile]
			internal static unsafe void SolverEdgeEdgeCrossFrameRangeKernel(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // 0x00000001889FDE00-0x00000001889FDE78
			[BurstCompile]
			public static unsafe void SolverEdgeEdgeCrossFrameKernel_BurstManaged(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // 0x00000001889F5C60-0x00000001889F635C
			[BurstCompile]
			public static unsafe void SolverEdgeEdgeCrossFrameRangeKernel_BurstManaged(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // 0x00000001889FDD90-0x00000001889FDE00
		}
	
		[BurstCompile]
		private struct UpdateEdgeEdgeBroadPhaseCrossFrameJob : IJob // TypeDefIndex: 77638
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
			public void Execute(int index); // 0x0000000188A05658-0x0000000188A05BF4
			public void Execute(); // 0x0000000188A055FC-0x0000000188A05658
		}
	
		[BurstCompile]
		private struct UpdatePointTriangleBroadPhaseCrossFrameJob : IJob // TypeDefIndex: 77639
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
			public void Execute(int index); // 0x0000000188A062E4-0x0000000188A06890
			public void Execute(); // 0x0000000188A06890-0x0000000188A068EC
		}
	
		[BurstCompile]
		private struct SolverEdgeEdgeCrossFrameJob : IJob, IUnsafeJob // TypeDefIndex: 77640
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
			public void Execute(int index); // 0x00000001889FDEB8-0x00000001889FE5D4
			public void Execute(); // 0x00000001889FDE78-0x00000001889FDEB8
			public void UnsafeDo(); // 0x00000001889FE5D4-0x00000001889FE63C
		}
	
		[BurstCompile]
		private struct SolverPointTriangleCrossFrameJob : IJob, IUnsafeJob // TypeDefIndex: 77641
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
			public void Execute(int index); // 0x00000001889FF404-0x00000001889FFB10
			public void Execute(); // 0x00000001889FFB10-0x00000001889FFB50
			public void UnsafeDo(); // 0x00000001889FFB50-0x00000001889FFBB8
		}
	
		// Constructors
		public SelfCollisionConstraint(); // 0x000000018609C050-0x000000018609C390
	
		// Methods
		public void Dispose(); // 0x00000001889E8DA8-0x00000001889E8ED4
		public bool HasPrimitive(); // 0x00000001854D3550-0x00000001854D3570
		public override string ToString(); // 0x00000001889EA040-0x00000001889EA3C4
		internal void Register(ClothProcess cprocess); // 0x0000000185B93BA0-0x0000000185B93BD0
		internal void Exit(ClothProcess cprocess); // 0x00000001859F5760-0x00000001859F5780
		internal void UpdateTeam(int teamId); // 0x0000000185B1BEE0-0x0000000185B1C3D0
		private void InitPrimitive(int teamId, TeamManager.TeamData tdata, uint kind, int startPrimitive, int startSort, int length); // 0x00000001889E8ED4-0x00000001889E9148
		internal void WorkBufferUpdate(); // 0x00000001863DDBF0-0x00000001863DDC10
		private static int BinarySearchSortAndlSweep(ref NativeArray<SortData> sortAndSweepArray, [IsReadOnly] in SortData sd, [IsReadOnly] in DataChunk chunk); // 0x00000001889E8CF4-0x00000001889E8DA8
		internal JobHandle SolverConstraint(int updateIndex, JobHandle jobHandle); // 0x00000001854D4C60-0x00000001854D4CD0
		private JobHandle SolverRuntimeSelfCollision(int updateIndex, JobHandle jobHandle); // 0x00000001854D4D20-0x00000001854D4D70
		private JobHandle SolverBroadPhase(JobHandle jobHandle); // 0x00000001889E9148-0x00000001889EA040
		private JobHandle UpdateBroadPhase(JobHandle jobHandle); // 0x00000001889EA3C4-0x00000001889EA544
		private JobHandle SolveIntersect(JobHandle jobHandle); // 0x00000001854D4CD0-0x00000001854D4D20
		public static void Initialize_IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_0000014E_BurstDirectCall(); // 0x0000000186B31600-0x0000000186B31640
		public static void Initialize_IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_0000014F_BurstDirectCall(); // 0x0000000186B315C0-0x0000000186B31600
		public static void Initialize_UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000150_BurstDirectCall(); // 0x0000000186B31580-0x0000000186B315C0
		public static void Initialize_UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000151_BurstDirectCall(); // 0x0000000186B31540-0x0000000186B31580
		public static void Initialize_ClearBufferJobKernels_ClearBufferKernel_00000152_BurstDirectCall(); // 0x0000000186B31500-0x0000000186B31540
		public static void Initialize_SortJobKernels_SortKernel_00000153_BurstDirectCall(); // 0x0000000186B314C0-0x0000000186B31500
		public static void Initialize_SortJobKernels_SortRangeKernel_00000154_BurstDirectCall(); // 0x0000000186B31480-0x0000000186B314C0
		public static void Initialize_SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_00000187_BurstDirectCall(); // 0x0000000186B31440-0x0000000186B31480
		public static void Initialize_SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_00000188_BurstDirectCall(); // 0x0000000186B31400-0x0000000186B31440
		public static void Initialize_SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000189_BurstDirectCall(); // 0x0000000186B313C0-0x0000000186B31400
		public static void Initialize_SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_0000018A_BurstDirectCall(); // 0x0000000186B31380-0x0000000186B313C0
	}

	public class SpringConstraint : IDisposable // TypeDefIndex: 77645
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 77643
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
			public SerializeData(); // 0x0000000187233CF0-0x0000000187233D10
	
			// Methods
			public void DataValidate(); // 0x00000001889FCFCC-0x00000001889FD060
			public SerializeData Clone(); // 0x00000001889FCDCC-0x00000001889FCE4C
		}
	
		public struct SpringConstraintParams // TypeDefIndex: 77644
		{
			// Fields
			public float springPower; // 0x00
			public float limitDistance; // 0x04
			public float normalLimitRatio; // 0x08
			public float springNoise; // 0x0C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x0000000185D798F0-0x0000000185D79930
		}
	
		// Constructors
		public SpringConstraint(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x0000000187233D20-0x0000000187233D30
	}

	[BurstCompile]
	internal static class TethreConstraintJobKernels // TypeDefIndex: 77650
	{
		// Nested types
		public unsafe delegate void TethreConstraintKernel_0000019C_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // TypeDefIndex: 77646; 0x00000001889E5324-0x00000001889E53C0
	
		internal static class TethreConstraintKernel_0000019C_BurstDirectCall // TypeDefIndex: 77647
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static TethreConstraintKernel_0000019C_BurstDirectCall(); // 0x000000018633ACA0-0x000000018633ACB0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6329); // 0x0000000188A02654-0x0000000188A02758
			private static IntPtr GetFunctionPointer(); // 0x0000000188A02758-0x0000000188A027AC
			public static void Constructor(); // 0x000000018633BC40-0x000000018633BCD0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // 0x0000000188A027AC-0x0000000188A02930
		}
	
		public unsafe delegate void TethreConstraintRangeKernel_0000019D_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // TypeDefIndex: 77648; 0x00000001889E5810-0x00000001889E58B0
	
		internal static class TethreConstraintRangeKernel_0000019D_BurstDirectCall // TypeDefIndex: 77649
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static TethreConstraintRangeKernel_0000019D_BurstDirectCall(); // 0x000000018633ACB0-0x000000018633ACC0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6356); // 0x0000000188A02A1C-0x0000000188A02B20
			private static IntPtr GetFunctionPointer(); // 0x0000000188A02B20-0x0000000188A02B74
			public static void Constructor(); // 0x000000018633BCD0-0x000000018633BD60
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // 0x0000000188A02B74-0x0000000188A02D1C
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void TethreConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // 0x0000000188A01EE8-0x0000000188A01F64
		[BurstCompile]
		internal static unsafe void TethreConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // 0x0000000188A01F64-0x0000000188A01FE0
		[BurstCompile]
		public static unsafe void TethreConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // 0x0000000188A01A80-0x0000000188A01EE8
		[BurstCompile]
		public static unsafe void TethreConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // 0x00000001889F72F4-0x00000001889F7A44
	}

	public class TetherConstraint : IDisposable // TypeDefIndex: 77654
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 77651
		{
			// Fields
			[Range(0f, 1f)]
			public float distanceCompression; // 0x10
	
			// Constructors
			public SerializeData(); // 0x0000000187233D10-0x0000000187233D20
	
			// Methods
			public void DataValidate(); // 0x00000001889FCF8C-0x00000001889FCFB4
			public SerializeData Clone(); // 0x00000001889FCE4C-0x00000001889FCEA4
		}
	
		public struct TetherConstraintParams // TypeDefIndex: 77652
		{
			// Fields
			public float compressionLimit; // 0x00
			public float stretchLimit; // 0x04
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType); // 0x0000000185D797C0-0x0000000185D797F0
		}
	
		[BurstCompile]
		private struct TethreConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77653
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B30-0x0000000187233B40
			public void Execute(); // 0x0000000188A01FE0-0x0000000188A02040
			public void Execute(int index); // 0x0000000188A02040-0x0000000188A024E8
			public void UnsafeDo(); // 0x0000000188A024E8-0x0000000188A02654
		}
	
		// Constructors
		public TetherConstraint(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x00000001854D3E20-0x00000001854D4260
	}

	public class TriangleBendingConstraint : IDisposable // TypeDefIndex: 77671
	{
		// Fields
		private const sbyte VOLUME_SIGN = 100; // Metadata: 0x02629F81
		public ExNativeArray<ulong> trianglePairArray; // 0x10
		public ExNativeArray<float> restAngleOrVolumeArray; // 0x18
		public ExNativeArray<sbyte> signOrVolumeArray; // 0x20
		public ExNativeArray<uint> writeDataArray; // 0x28
		public ExNativeArray<uint> writeIndexArray; // 0x30
		public ExNativeArray<float3> writeBuffer; // 0x38
		private const float VolumeScale = 1000f; // Metadata: 0x02629F82
	
		// Properties
		public int DataCount { get; } // 0x00000001854CD220-0x00000001854CD230 
	
		// Nested types
		[BurstCompile]
		private static class TriangleBendingJobKernels // TypeDefIndex: 77659
		{
			// Nested types
			public unsafe delegate void TriangleBendingKernel_000001B3_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // TypeDefIndex: 77655; 0x00000001889DE750-0x00000001889DE804
	
			internal static class TriangleBendingKernel_000001B3_BurstDirectCall // TypeDefIndex: 77656
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static TriangleBendingKernel_000001B3_BurstDirectCall(); // 0x000000018633ACC0-0x000000018633ACD0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a63e6); // 0x0000000188A04E7C-0x0000000188A04F80
				private static IntPtr GetFunctionPointer(); // 0x0000000188A04F80-0x0000000188A04FD4
				public static void Constructor(); // 0x000000018633BD60-0x000000018633BDF0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x0000000188A04FD4-0x0000000188A051BC
			}
	
			public unsafe delegate void TriangleBendingRangeKernel_000001B4_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // TypeDefIndex: 77657; 0x00000001889DECA8-0x00000001889DED60
	
			internal static class TriangleBendingRangeKernel_000001B4_BurstDirectCall // TypeDefIndex: 77658
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static TriangleBendingRangeKernel_000001B4_BurstDirectCall(); // 0x000000018633ACD0-0x000000018633ACE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6419); // 0x0000000188A052C0-0x0000000188A053C4
				private static IntPtr GetFunctionPointer(); // 0x0000000188A053C4-0x0000000188A05418
				public static void Constructor(); // 0x000000018633BDF0-0x000000018633BE80
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x0000000188A05418-0x0000000188A055FC
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void TriangleBendingKernel(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x0000000188A04690-0x0000000188A04710
			[BurstCompile]
			internal static unsafe void TriangleBendingRangeKernel(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x0000000188A04710-0x0000000188A04790
			private static bool Volume([IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double volumeRest, double stiffness, ref double3x4 addPosBuffer); // 0x0000000188A04790-0x0000000188A04E7C
			private static bool DihedralAngle(double sign, [IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double restAngle, double stiffness, ref double3x4 addPosBuffer); // 0x0000000188A035F0-0x0000000188A04028
			[BurstCompile]
			public static unsafe void TriangleBendingKernel_BurstManaged(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x0000000188A04028-0x0000000188A04690
			[BurstCompile]
			public static unsafe void TriangleBendingRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x00000001889F7A44-0x00000001889F83B8
		}
	
		[BurstCompile]
		private static class SolveAggregateBufferJobKernels // TypeDefIndex: 77664
		{
			// Nested types
			public unsafe delegate void SolveAggregateBufferKernel_000001B7_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // TypeDefIndex: 77660; 0x00000001889FD8A8-0x00000001889FD904
	
			internal static class SolveAggregateBufferKernel_000001B7_BurstDirectCall // TypeDefIndex: 77661
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveAggregateBufferKernel_000001B7_BurstDirectCall(); // 0x000000018633ACE0-0x000000018633ACF0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a645e); // 0x00000001889FD580-0x00000001889FD684
				private static IntPtr GetFunctionPointer(); // 0x00000001889FD684-0x00000001889FD6D8
				public static void Constructor(); // 0x000000018633BE80-0x000000018633BF10
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x00000001889FD6D8-0x00000001889FD7EC
			}
	
			public unsafe delegate void SolveAggregateBufferRangeKernel_000001B8_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // TypeDefIndex: 77662; 0x0000000187921820-0x000000018792187C
	
			internal static class SolveAggregateBufferRangeKernel_000001B8_BurstDirectCall // TypeDefIndex: 77663
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveAggregateBufferRangeKernel_000001B8_BurstDirectCall(); // 0x000000018633ACF0-0x000000018633AD00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a647c); // 0x00000001889FD9C4-0x00000001889FDAC8
				private static IntPtr GetFunctionPointer(); // 0x00000001889FDAC8-0x00000001889FDB1C
				public static void Constructor(); // 0x000000018633BF10-0x000000018633BFA0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x00000001889FDB1C-0x00000001889FDC58
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void SolveAggregateBufferKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x00000001889FD3E0-0x00000001889FD45C
			[BurstCompile]
			internal static unsafe void SolveAggregateBufferRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x00000001889FD504-0x00000001889FD580
			[BurstCompile]
			public static unsafe void SolveAggregateBufferKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // 0x00000001889FD060-0x00000001889FD3E0
			[BurstCompile]
			public static unsafe void SolveAggregateBufferRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // 0x00000001889FD45C-0x00000001889FD504
		}
	
		public enum Method // TypeDefIndex: 77665
		{
			None = 0,
			DihedralAngle = 1,
			DirectionDihedralAngle = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 77666
		{
			// Fields
			[Range(0f, 1f)]
			public float stiffness; // 0x10
	
			// Constructors
			public SerializeData(); // 0x0000000187233CE0-0x0000000187233CF0
	
			// Methods
			public void DataValidate(); // 0x00000001889FCFB4-0x00000001889FCFCC
			public SerializeData Clone(); // 0x00000001889FCD74-0x00000001889FCDCC
		}
	
		public struct TriangleBendingConstraintParams // TypeDefIndex: 77667
		{
			// Fields
			public Method method; // 0x00
			public float stiffness; // 0x04
	
			// Methods
			public void Convert(SerializeData sdata); // 0x0000000185D79830-0x0000000185D79870
		}
	
		[Serializable]
		public class ConstraintData : IValid // TypeDefIndex: 77668
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
			public ConstraintData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool IsValid(); // 0x0000000185B93550-0x0000000185B93570
		}
	
		[BurstCompile]
		private struct TriangleBendingJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77669
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B10-0x0000000187233B20
			public void Execute(); // 0x0000000188A14794-0x0000000188A147F4
			public void Execute(int index); // 0x0000000188A14130-0x0000000188A14794
			private bool Volume([IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double volumeRest, double stiffness, ref double3x4 addPosBuffer); // 0x0000000188A149C8-0x0000000188A150BC
			private bool DihedralAngle(double sign, [IsReadOnly] in double3x4 nextPosBuffer, [IsReadOnly] in double4 invMassBuffer, double restAngle, double stiffness, ref double3x4 addPosBuffer); // 0x0000000188A136F8-0x0000000188A14130
			public void UnsafeDo(); // 0x0000000188A147F4-0x0000000188A149C8
		}
	
		[BurstCompile]
		private struct SolveAggregateBufferJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77670
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233D60-0x0000000187233D70
			public void Execute(); // 0x0000000188A10A98-0x0000000188A10AF4
			public void Execute(int index); // 0x0000000188A10AF4-0x0000000188A10E70
			public void UnsafeDo(); // 0x0000000188A10E70-0x0000000188A10F4C
		}
	
		// Constructors
		public TriangleBendingConstraint(); // 0x00000001860985F0-0x0000000186098A70
	
		// Methods
		public void Dispose(); // 0x0000000188A02D1C-0x0000000188A02E28
		public override string ToString(); // 0x0000000188A03394-0x0000000188A035F0
		public static ConstraintData CreateData(VirtualMesh proxyMesh, [IsReadOnly] in ClothParameters parameters); // 0x0000000185D77070-0x0000000185D78570
		private static void InitVolume(VirtualMesh proxyMesh, int v0, int v1, int v2, int v3, out float volumeRest, out sbyte signFlag); // 0x0000000188A03130-0x0000000188A03394
		private static void InitDihedralAngle(VirtualMesh proxyMesh, int v0, int v1, int v2, int v3, out float restAngle, out sbyte signFlag); // 0x0000000188A02E28-0x0000000188A03130
		internal void Register(ClothProcess cprocess); // 0x0000000185B93BD0-0x0000000185B93CA0
		internal void Exit(ClothProcess cprocess); // 0x00000001859F4EB0-0x00000001859F5060
		internal JobHandle SolverConstraint(JobHandle jobHandle); // 0x00000001854D4B80-0x00000001854D4C60
		public static void Initialize_TriangleBendingJobKernels_TriangleBendingKernel_000001B3_BurstDirectCall(); // 0x0000000186B31200-0x0000000186B31240
		public static void Initialize_TriangleBendingJobKernels_TriangleBendingRangeKernel_000001B4_BurstDirectCall(); // 0x0000000186B31240-0x0000000186B31280
		public static void Initialize_SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001B7_BurstDirectCall(); // 0x0000000186B31280-0x0000000186B312C0
		public static void Initialize_SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001B8_BurstDirectCall(); // 0x0000000186B312C0-0x0000000186B31300
	}

	[Serializable]
	public class CullingSettings : IDataValidate // TypeDefIndex: 77675
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
		public enum CameraCullingMode // TypeDefIndex: 77672
		{
			Off = 0,
			Reset = 10,
			Keep = 20,
			AnimatorLinkage = 30
		}
	
		public enum CameraCullingMethod // TypeDefIndex: 77673
		{
			AutomaticRenderer = 0,
			ManualRenderer = 10
		}
	
		public struct CullingParams // TypeDefIndex: 77674
		{
			// Fields
			public bool useDistanceCulling; // 0x00
			public float distanceCullingLength; // 0x04
			public float distanceCullingFadeRatio; // 0x08
	
			// Methods
			public void Convert(CullingSettings cullingSettings); // 0x0000000185D797F0-0x0000000185D79830
		}
	
		// Constructors
		public CullingSettings(); // 0x0000000185F6B8A0-0x0000000185F6B960
	
		// Methods
		public void DataValidate(); // 0x0000000188A0B348-0x0000000188A0B388
		public CullingSettings Clone(); // 0x0000000188A0B244-0x0000000188A0B348
		public override int GetHashCode(); // 0x0000000185829EC0-0x0000000185829ED0
	}

	[Serializable]
	public class CurveSerializeData // TypeDefIndex: 77676
	{
		// Fields
		public float value; // 0x10
		public bool useCurve; // 0x14
		public AnimationCurve curve; // 0x18
	
		// Constructors
		public CurveSerializeData(); // 0x0000000188A0B5A8-0x0000000188A0B5E4
		public CurveSerializeData(float value); // 0x0000000185F6B520-0x0000000185F6B5B0
		public CurveSerializeData(float value, float curveStart, float curveEnd, bool useCurve = true /* Metadata: 0x02629F8F */); // 0x0000000185F6B960-0x0000000185F6BA30
		public CurveSerializeData(float value, AnimationCurve curve); // 0x0000000188A0B53C-0x0000000188A0B5A8
	
		// Methods
		public void SetValue(float value); // 0x0000000187233D50-0x0000000187233D60
		public void SetValue(float value, float curveStart, float curveEnd, bool useCurve = true /* Metadata: 0x02629F90 */); // 0x0000000188A0B4E4-0x0000000188A0B53C
		public void SetValue(float value, AnimationCurve curve); // 0x0000000188A0B4CC-0x0000000188A0B4E4
		public void DataValidate(float min, float max); // 0x00000001889D18B8-0x00000001889D18DC
		public float Evaluate(float time); // 0x0000000188A0B494-0x0000000188A0B4CC
		public float4x4 ConvertFloatArray(); // 0x0000000185D795C0-0x0000000185D796A0
		public CurveSerializeData Clone(); // 0x0000000188A0B388-0x0000000188A0B494
	}

	[Serializable]
	public class CustomSkinningSettings : IValid, IDataValidate, ITransform // TypeDefIndex: 77678
	{
		// Fields
		public bool enable; // 0x10
		public List<Transform> skinningBones; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77677
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, bool> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188A15108-0x0000000188A1516C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _IsValid_b__3_0(Transform n); // 0x0000000188A150BC-0x0000000188A15108
		}
	
		// Constructors
		public CustomSkinningSettings(); // 0x0000000185F6B5B0-0x0000000185F6B630
	
		// Methods
		public void DataValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		public bool IsValid(); // 0x0000000188A0B804-0x0000000188A0B944
		public CustomSkinningSettings Clone(); // 0x0000000188A0B5E4-0x0000000188A0B6A0
		public override int GetHashCode(); // 0x0000000185829EC0-0x0000000185829ED0
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A0B6A0-0x0000000188A0B804
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A0B944-0x0000000188A0BA8C
	}

	[Serializable]
	public class GizmoSerializeData // TypeDefIndex: 77679
	{
		// Fields
		public bool always; // 0x10
		public ClothDebugSettings clothDebugSettings; // 0x18
	
		// Constructors
		public GizmoSerializeData(); // 0x0000000188A0D72C-0x0000000188A0D7A4
	
		// Methods
		public bool IsAlways(); // 0x00000001829D0800-0x00000001829D0810
	}

	[Serializable]
	public class NormalAlignmentSettings : IValid, IDataValidate, ITransform // TypeDefIndex: 77681
	{
		// Fields
		public AlignmentMode alignmentMode; // 0x10
		public Transform adjustmentTransform; // 0x18
	
		// Nested types
		public enum AlignmentMode // TypeDefIndex: 77680
		{
			None = 0,
			BoundingBoxCenter = 1,
			Transform = 2
		}
	
		// Constructors
		public NormalAlignmentSettings(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void DataValidate(); // 0x0000000186805BA0-0x0000000186805BB0
		public bool IsValid(); // 0x0000000188A0D940-0x0000000188A0D948
		public NormalAlignmentSettings Clone(); // 0x0000000188A0D7A4-0x0000000188A0D804
		public override int GetHashCode(); // 0x0000000188A0D804-0x0000000188A0D8B4
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A0D8B4-0x0000000188A0D940
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A0D948-0x0000000188A0DA20
	}

	[Serializable]
	public class SelectionData : IValid // TypeDefIndex: 77685
	{
		// Fields
		public float3[] positions; // 0x10
		public VertexAttribute[] attributes; // 0x18
		public float maxConnectionDistance; // 0x20
		public bool userEdit; // 0x24
	
		// Properties
		public int Count { get; } // 0x0000000188A104BC-0x0000000188A104CC 
	
		// Nested types
		[BurstCompile]
		private struct TransformPositionJob : IJobParallelFor // TypeDefIndex: 77682
		{
			// Fields
			public float4x4 transformMatrix; // 0x00
			public NativeArray<float3> localPositions; // 0x40
	
			// Methods
			public void Execute(int index); // 0x0000000188A13668-0x0000000188A136F8
		}
	
		[BurstCompile]
		private struct CreateGridMapJob : IJob // TypeDefIndex: 77683
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
			public void Execute(); // 0x00000001867E3EB0-0x00000001867E3FC0
		}
	
		[BurstCompile]
		private struct ConvertSelectionJob : IJobParallelFor // TypeDefIndex: 77684
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
			public void Execute(int vindex); // 0x0000000188A0AD10-0x0000000188A0B15C
		}
	
		// Constructors
		public SelectionData(); // 0x0000000186805BA0-0x0000000186805BB0
		public SelectionData(int cnt); // 0x0000000188A10440-0x0000000188A104BC
		public SelectionData(VirtualMesh vmesh, float4x4 transformMatrix); // 0x0000000188A10178-0x0000000188A10440
	
		// Methods
		public bool IsValid(); // 0x0000000186BA0070-0x0000000186BA00B0
		public bool IsUserEdit(); // 0x000000018223FE80-0x000000018223FE90
		public SelectionData Clone(); // 0x0000000186A51370-0x0000000186A51490
		public bool Compare(SelectionData sdata); // 0x0000000188A0F544-0x0000000188A0F73C
		public void AddRange(float3[] addPositions, VertexAttribute[] addAttributes = null); // 0x0000000188A0F3B8-0x0000000188A0F544
		public void Fill(VertexAttribute attr); // 0x0000000188A0FE28-0x0000000188A0FE74
		public NativeArray<float3> GetPositionNativeArray(); // 0x0000000186704710-0x0000000186704770
		public NativeArray<float3> GetPositionNativeArray(float4x4 transformMatrix); // 0x0000000188A0FE74-0x0000000188A0FF74
		public NativeArray<VertexAttribute> GetAttributeNativeArray(); // 0x00000001867046B0-0x0000000186704710
		public static GridMap<int> CreateGridMapRun(float gridSize, [IsReadOnly] in NativeArray<float3> positions, [IsReadOnly] in NativeArray<VertexAttribute> attributes, bool move = true /* Metadata: 0x02629F94 */, bool fix = true /* Metadata: 0x02629F95 */, bool ignore = true /* Metadata: 0x02629F96 */, bool invalid = true /* Metadata: 0x02629F97 */); // 0x0000000186704770-0x00000001867048D0
		public void Merge(SelectionData from); // 0x0000000188A0FF74-0x0000000188A10178
		public void ConvertFrom(SelectionData from); // 0x0000000188A0F73C-0x0000000188A0FE28
	}

	public class BeyondBoneWindZone : ClothBehaviour // TypeDefIndex: 77687
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
		public int WindId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872336F0-0x0000000187233700 0x0000000187233700-0x0000000187233710
	
		// Nested types
		public enum Mode // TypeDefIndex: 77686
		{
			GlobalDirection = 0,
			SphereDirection = 1,
			BoxDirection = 2,
			SphereRadial = 10
		}
	
		// Constructors
		public BeyondBoneWindZone(); // 0x0000000188A0A7B0-0x0000000188A0A828
	
		// Methods
		public void Awake(); // 0x0000000188A0A438-0x0000000188A0A494
		public void Start(); // 0x0000000186805BA0-0x0000000186805BB0
		public void OnEnable(); // 0x0000000188A0A650-0x0000000188A0A6AC
		public void OnDisable(); // 0x0000000188A0A5F4-0x0000000188A0A650
		public void OnDestroy(); // 0x0000000188A0A594-0x0000000188A0A5F4
		public bool IsDirection(); // 0x0000000188A0A584-0x0000000188A0A58C
		public bool IsRadial(); // 0x0000000188A0A58C-0x0000000188A0A594
		public bool IsAddition(); // 0x000000018225DFF0-0x000000018225E000
		public Vector3 GetWindDirection(bool localSpace = false /* Metadata: 0x02629F98 */); // 0x0000000188A0A494-0x0000000188A0A584
		public void SetWindDirection(Vector3 dir, bool localSpace = false /* Metadata: 0x02629F99 */); // 0x0000000188A0A6AC-0x0000000188A0A7B0
	}

	public struct WindParams : IValid // TypeDefIndex: 77688
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
		public void Convert(WindSettings sdata, ClothProcess.ClothType clothType); // 0x0000000185D798B0-0x0000000185D798F0
		public bool IsValid(); // 0x0000000188A15A60-0x0000000188A15A70
	}

	[Serializable]
	public class WindSettings : IValid, IDataValidate // TypeDefIndex: 77689
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
		public WindSettings(); // 0x0000000187233D70-0x0000000187233DA0
	
		// Methods
		public bool IsValid(); // 0x0000000188A15BB8-0x0000000188A15BC8
		public void DataValidate(); // 0x0000000188A15AFC-0x0000000188A15BB8
		public WindSettings Clone(); // 0x0000000188A15A70-0x0000000188A15AFC
	}

	public static class Define // TypeDefIndex: 77692
	{
		// Nested types
		public enum Result // TypeDefIndex: 77690
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
	
		public static class System // TypeDefIndex: 77691
		{
			// Fields
			public const int LatestPreBuildVersion = 2; // Metadata: 0x0262A11B
			public const float Epsilon = 1E-08f; // Metadata: 0x0262A11C
			public const int MaxRendererCount = 31; // Metadata: 0x0262A120
			public const float MinimumGridSize = 1E-05f; // Metadata: 0x0262A121
			public const int MaximumTeamCount = 4096; // Metadata: 0x0262A125
			public const int DefaultSimulationFrequency = 90; // Metadata: 0x0262A127
			public const int SimulationFrequency_Low = 30; // Metadata: 0x0262A129
			public const int SimulationFrequency_Hi = 150; // Metadata: 0x0262A12A
			public const int DefaultMaxSimulationCountPerFrame = 3; // Metadata: 0x0262A12C
			public const int MaxSimulationCountPerFrame_Low = 1; // Metadata: 0x0262A12D
			public const int MaxSimulationCountPerFrame_Hi = 5; // Metadata: 0x0262A12E
			public const float SameSurfaceAngle = 80f; // Metadata: 0x0262A12F
			public const float MaxDistanceRatioFutuerPrediction = 1.3f; // Metadata: 0x0262A133
			public const bool ReductionEnable = true; // Metadata: 0x0262A137
			public const float ReductionSameDistance = 0.001f; // Metadata: 0x0262A138
			public const bool ReductionDontMakeLine = true; // Metadata: 0x0262A13C
			public const float ReductionJoinPositionAdjustment = 1f; // Metadata: 0x0262A13D
			public const int ReductionMaxStep = 100; // Metadata: 0x0262A141
			public const int MaxProxyMeshVertexCount = 32767; // Metadata: 0x0262A143
			public const int MaxProxyMeshEdgeCount = 32767; // Metadata: 0x0262A147
			public const int MaxProxyMeshTriangleCount = 32767; // Metadata: 0x0262A14B
			public const float ProxyMeshTrianglePairAngle = 20f; // Metadata: 0x0262A14F
			public const float ProxyMeshBoneClothTriangleAngle = 120f; // Metadata: 0x0262A153
			public const float FrictionMass = 3f; // Metadata: 0x0262A157
			public const float DepthMass = 5f; // Metadata: 0x0262A15B
			public const float FrictionDampingRate = 0.6f; // Metadata: 0x0262A15F
			public const float PositionAverageExponent = 0.5f; // Metadata: 0x0262A163
			public const float MaxRealVelocity = 0.5f; // Metadata: 0x0262A167
			public const float TetherCompressionStiffness = 1f; // Metadata: 0x0262A16B
			public const float TetherStretchStiffness = 1f; // Metadata: 0x0262A16F
			public const float TetherStretchLimit = 0.03f; // Metadata: 0x0262A173
			public const float TetherStiffnessWidth = 0.3f; // Metadata: 0x0262A177
			public const float TetherCompressionVelocityAttenuation = 0.7f; // Metadata: 0x0262A17B
			public const float TetherStretchVelocityAttenuation = 0.7f; // Metadata: 0x0262A17F
			public const float DistanceVelocityAttenuation = 0.3f; // Metadata: 0x0262A183
			public const float DistanceVerticalStiffness = 1f; // Metadata: 0x0262A187
			public const float DistanceHorizontalStiffness = 0.5f; // Metadata: 0x0262A18B
			public const float TriangleBendingMaxAngle = 120f; // Metadata: 0x0262A18F
			public const float VolumeMinAngle = 90f; // Metadata: 0x0262A193
			public const float MaxAngleLimit = 179f; // Metadata: 0x0262A197
			public const int AngleLimitIteration = 3; // Metadata: 0x0262A19B
			public const float AngleLimitAttenuation = 0.9f; // Metadata: 0x0262A19C
			public const float MaxMovementSpeedLimit = 10f; // Metadata: 0x0262A1A0
			public const float MaxRotationSpeedLimit = 1440f; // Metadata: 0x0262A1A4
			public const float MaxParticleSpeedLimit = 10f; // Metadata: 0x0262A1A8
			public const int ExpandedColliderCount = 8; // Metadata: 0x0262A1AC
			public const float ColliderCollisionDynamicFrictionRatio = 1f; // Metadata: 0x0262A1AD
			public const float ColliderCollisionStaticFrictionRatio = 1f; // Metadata: 0x0262A1B1
			public const float CustomSkinningAngularAttenuation = 1f; // Metadata: 0x0262A1B5
			public const float CustomSkinningDistanceReduction = 0.6f; // Metadata: 0x0262A1B9
			public const float CustomSkinningDistancePow = 2f; // Metadata: 0x0262A1BD
			public const int SelfCollisionSolverIteration = 4; // Metadata: 0x0262A1C1
			public const float SelfCollisionFixedMass = 100f; // Metadata: 0x0262A1C2
			public const float SelfCollisionFrictionMass = 10f; // Metadata: 0x0262A1C6
			public const float SelfCollisionClothMass = 50f; // Metadata: 0x0262A1CA
			public const float SelfCollisionSCR = 2f; // Metadata: 0x0262A1CE
			public static readonly float SelfCollisionPointTriangleAngleCos; // 0x00
			public const int SelfCollisionIntersectDiv = 8; // Metadata: 0x0262A1D2
			public const float SelfCollisionThicknessMin = 0.001f; // Metadata: 0x0262A1D3
			public const float SelfCollisionThicknessMax = 0.05f; // Metadata: 0x0262A1D7
			public const float WindMaxTime = 10000f; // Metadata: 0x0262A1DB
			public const float WindBaseSpeed = 7.5f; // Metadata: 0x0262A1DF
			public const float BoneSpringDistanceStiffness = 0.5f; // Metadata: 0x0262A1E3
			public const float BoneSpringTetherCompressionLimit = 0.8f; // Metadata: 0x0262A1E7
			public const float BoneSpringCollisionFriction = 0.5f; // Metadata: 0x0262A1EB
			public const float DistanceCullingMaxLength = 100f; // Metadata: 0x0262A1EF
	
			// Constructors
			static System(); // 0x0000000188A10F4C-0x0000000188A10F90
		}
	}

	internal interface ICount // TypeDefIndex: 77693
	{
		// Methods
		int Count();
	}

	internal interface IDataValidate // TypeDefIndex: 77694
	{
		// Methods
		void DataValidate();
	}

	internal interface ITransform // TypeDefIndex: 77695
	{
		// Methods
		void GetUsedTransform(HashSet<Transform> transformSet);
		void ReplaceTransform(Dictionary<int, Transform> replaceDict);
	}

	internal interface IValid // TypeDefIndex: 77696
	{
		// Methods
		bool IsValid();
	}

	public class ClothManager : IManager, IValid // TypeDefIndex: 77697
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
		public ClothManager(); // 0x0000000186CADB10-0x0000000186CADC80
		static ClothManager(); // 0x0000000186DE7B40-0x0000000186DE7DC0
	
		// Methods
		public void Dispose(); // 0x0000000188A0A828-0x0000000188A0AD08
		public void EnterdEditMode(); // 0x0000000188A0AD08-0x0000000188A0AD10
		public void Initialize(); // 0x0000000185E73BE0-0x0000000185E740E0
		public bool IsValid(); // 0x000000018223CB60-0x000000018223CB70
		private void ClearMasterJob(); // 0x0000000187233D40-0x0000000187233D50
		private void CompleteMasterJob(); // 0x00000001856FB590-0x00000001856FB620
		public void ForceCompleteAllJob(); // 0x0000000187836578-0x0000000187836580
		internal int AddCloth(ClothProcess cprocess, [IsReadOnly] in ClothParameters clothParams); // 0x00000001853C8480-0x00000001853C86A0
		internal void RemoveCloth(ClothProcess cprocess); // 0x0000000185FF1590-0x0000000185FF16E0
		private void OnEarlyClothUpdate(); // 0x00000001854CEBF0-0x00000001854CEFF0
		private void OnAfterUpdate(); // 0x000000018618FE60-0x000000018618FED0
		private void OnApplicationQuit(); // 0x0000000187836578-0x0000000187836580
		private void OnBeforeLateUpdate(); // 0x00000001861A7670-0x00000001861A76C0
		private void OnAfterLateUpdate(); // 0x00000001854CF1B0-0x00000001854CF200
		private void ClothUpdate(); // 0x00000001854CF200-0x00000001854D0390
		internal void ClearVisibleDict(); // 0x0000000186065590-0x00000001860658E0
		internal bool CheckVisible(Animator ani, List<Renderer> renderers); // 0x0000000185491420-0x00000001854915F0
		internal bool CheckLODVisible(Animator ani, int clothAnimatorAbilityLODThresholdProperty, int clothAnimatorLODThresholdProperty); // 0x00000001854D7590-0x00000001854D7690
		private bool CheckRendererVisible(List<Renderer> renderers); // 0x00000001854915F0-0x00000001854918E0
		public void InformationLog(StringBuilder allsb); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class PreBuildManager : IManager, IValid // TypeDefIndex: 77699
	{
		// Fields
		private Dictionary<SharePreBuildData, ShareDeserializationData> deserializationDict; // 0x10
		private bool isValid; // 0x18
		private static readonly ProfilerMarker deserializationProfiler; // 0x00
	
		// Nested types
		internal class ShareDeserializationData : IDisposable // TypeDefIndex: 77698
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
			public int RenderMeshCount { get; } // 0x0000000188A10A60-0x0000000188A10A98 
	
			// Constructors
			public ShareDeserializationData(); // 0x0000000186183380-0x0000000186183450
	
			// Methods
			public void Dispose(); // 0x0000000188A104CC-0x0000000188A10944
			public void Deserialize(SharePreBuildData sharePreBuilddata); // 0x0000000186260A00-0x0000000186260F30
			public VirtualMeshContainer GetProxyMeshContainer(); // 0x0000000188A10944-0x0000000188A109B0
			public VirtualMeshContainer GetRenderMeshContainer(int index); // 0x0000000188A109B0-0x0000000188A10A60
		}
	
		// Constructors
		public PreBuildManager(); // 0x0000000185E74220-0x0000000185E742A0
		static PreBuildManager(); // 0x00000001871DCE30-0x00000001871DCE90
	
		// Methods
		public void Dispose(); // 0x0000000188A0DA20-0x0000000188A0DBAC
		public void EnterdEditMode(); // 0x0000000188A0DBAC-0x0000000188A0DBB4
		public void Initialize(); // 0x0000000187233970-0x0000000187233980
		public bool IsValid(); // 0x000000018225E050-0x000000018225E060
		public void InformationLog(StringBuilder allsb); // 0x0000000188A0DBB4-0x0000000188A0E01C
		internal ShareDeserializationData RegisterPreBuildData(SharePreBuildData sdata, bool referenceIncrement); // 0x0000000186183670-0x00000001861837B0
		internal ShareDeserializationData GetPreBuildData(SharePreBuildData sdata); // 0x00000001861835E0-0x0000000186183670
		internal void UnregisterPreBuildData(SharePreBuildData sdata); // 0x00000001861832E0-0x0000000186183380
		internal void UnloadUnusedData(); // 0x0000000186182DC0-0x0000000186183140
	}

	public struct DoAllInOneJob : IJob // TypeDefIndex: 77700
	{
		// Fields
		public GCHandle bmHandle; // 0x00
		public GCHandle tmHandle; // 0x08
		public GCHandle vmHandle; // 0x10
		public GCHandle smHandle; // 0x18
		public GCHandle wmHandle; // 0x20
		public GCHandle meshClothSetHandle; // 0x28
	
		// Methods
		public void Execute(); // 0x0000000188A0BA8C-0x0000000188A0C138
	}

	public interface ICrossFrameParallelForJob : IJob // TypeDefIndex: 77701
	{
		// Methods
		void SetIndexCount(int indexCount);
	}

	public interface ICrossFrameParallelForDeferJob : IJob // TypeDefIndex: 77702
	{
		// Methods
		void SetIndexCount(NativeReference<int> indexCount);
	}

	public interface IUnsafeJob // TypeDefIndex: 77703
	{
		// Methods
		void UnsafeDo();
	}

	public static class CrossFrameJobUtils // TypeDefIndex: 77704
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

	public class DynamicBoneTransformManager : IManager, IValid // TypeDefIndex: 77724
	{
		// Fields
		internal const byte Flag_Read = 1; // Metadata: 0x0262A1F3
		internal const byte Flag_WorldRotWrite = 2; // Metadata: 0x0262A1F4
		internal const byte Flag_LocalPosRotWrite = 4; // Metadata: 0x0262A1F5
		internal const byte Flag_Restore = 8; // Metadata: 0x0262A1F6
		internal const byte Flag_Enable = 16; // Metadata: 0x0262A1F7
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
		internal int Count { get; } // 0x00000001854CD220-0x00000001854CD230 
	
		// Nested types
		[BurstCompile]
		private static class WriteAnimatorBufferDataJobKernels // TypeDefIndex: 77709
		{
			// Nested types
			public unsafe delegate void WriteAnimatorBufferDataKernel_00000265_PostfixBurstDelegate(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 77705; 0x00000001823D90D0-0x00000001823D9150
	
			internal static class WriteAnimatorBufferDataKernel_00000265_BurstDirectCall // TypeDefIndex: 77706
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteAnimatorBufferDataKernel_00000265_BurstDirectCall(); // 0x000000018633AD00-0x000000018633AD10
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a655f); // 0x0000000188A16F80-0x0000000188A17084
				private static IntPtr GetFunctionPointer(); // 0x0000000188A17084-0x0000000188A170D8
				public static void Constructor(); // 0x000000018633BFA0-0x000000018633C030
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x0000000188A170D8-0x0000000188A1724C
			}
	
			public unsafe delegate void WriteAnimatorBufferDataRangeKernel_00000266_PostfixBurstDelegate(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 77707; 0x00000001823D90D0-0x00000001823D9150
	
			internal static class WriteAnimatorBufferDataRangeKernel_00000266_BurstDirectCall // TypeDefIndex: 77708
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteAnimatorBufferDataRangeKernel_00000266_BurstDirectCall(); // 0x000000018633AD10-0x000000018633AD20
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6586); // 0x0000000188A173E4-0x0000000188A174E8
				private static IntPtr GetFunctionPointer(); // 0x0000000188A174E8-0x0000000188A1753C
				public static void Constructor(); // 0x000000018633C030-0x000000018633C0C0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x0000000188A1753C-0x0000000188A176A4
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteAnimatorBufferDataKernel(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x0000000188A16424-0x0000000188A164A0
			[BurstCompile]
			internal static unsafe void WriteAnimatorBufferDataRangeKernel(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x0000000188A164A0-0x0000000188A1651C
			[BurstCompile]
			public static unsafe void WriteAnimatorBufferDataKernel_BurstManaged(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x0000000188A15BC8-0x0000000188A16424
			[BurstCompile]
			public static unsafe void WriteAnimatorBufferDataRangeKernel_BurstManaged(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x0000000188A09DE8-0x0000000188A09F14
		}
	
		[BurstCompile]
		private struct ReadAnimatorBufferDataJob : IJobCrossFrameTransform // TypeDefIndex: 77710
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
			public void Execute(int index, TransformAccess transform); // 0x0000000188A0E01C-0x0000000188A0E03C
			private void _Do(int index, TransformAccess transform); // 0x0000000188A0E03C-0x0000000188A0EB1C
		}
	
		[BurstCompile]
		private struct WriteAnimatorBufferDataJob : IJob, IUnsafeJob // TypeDefIndex: 77711
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
			public void Execute(); // 0x0000000188A1651C-0x0000000188A16E48
			public void UnsafeDo(); // 0x0000000188A16E48-0x0000000188A16F80
		}
	
		[BurstCompile]
		private struct CopyDoubleBufferJob : IJob // TypeDefIndex: 77712
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
			public void Execute(); // 0x0000000188A0B15C-0x0000000188A0B244
		}
	
		[BurstCompile]
		private struct EnableTransformJob : IJob // TypeDefIndex: 77713
		{
			// Fields
			public DataChunk chunk; // 0x00
			public bool sw; // 0x08
			public NativeArray<ExBitFlag8> flagList; // 0x10
	
			// Methods
			public void Execute(); // 0x0000000188A0D6F0-0x0000000188A0D72C
		}
	
		[BurstCompile]
		private struct RestoreTransformJob : IJobParallelForTransform // TypeDefIndex: 77714
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
			public void Execute(int index, TransformAccess transform); // 0x0000000188A0F204-0x0000000188A0F3B8
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 77715
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
			public void Execute(int index, TransformAccess transform); // 0x0000000188A0EB8C-0x0000000188A0F204
		}
	
		[BurstCompile]
		public static class ValidTransformKernels // TypeDefIndex: 77720
		{
			// Nested types
			public unsafe delegate void ValidateTransformKernel_0000026F_PostfixBurstDelegate(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 77716; 0x0000000181256340-0x0000000181256360
	
			internal static class ValidateTransformKernel_0000026F_BurstDirectCall // TypeDefIndex: 77717
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ValidateTransformKernel_0000026F_BurstDirectCall(); // 0x000000018633AD20-0x000000018633AD30
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a65c3); // 0x0000000188A153A4-0x0000000188A154A8
				private static IntPtr GetFunctionPointer(); // 0x0000000188A154A8-0x0000000188A154FC
				public static void Constructor(); // 0x000000018633C0C0-0x000000018633C150
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x0000000188A154FC-0x0000000188A155D0
			}
	
			public unsafe delegate void ValidateTransformRangeKernel_00000270_PostfixBurstDelegate(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 77718; 0x0000000181256340-0x0000000181256360
	
			internal static class ValidateTransformRangeKernel_00000270_BurstDirectCall // TypeDefIndex: 77719
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ValidateTransformRangeKernel_00000270_BurstDirectCall(); // 0x000000018633AD30-0x000000018633AD40
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a65db); // 0x0000000188A1574C-0x0000000188A15850
				private static IntPtr GetFunctionPointer(); // 0x0000000188A15850-0x0000000188A158A4
				public static void Constructor(); // 0x000000018633C150-0x000000018633C1E0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x0000000188A158A4-0x0000000188A159A4
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void ValidateTransformKernel(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x0000000188A1522C-0x0000000188A152A8
			[BurstCompile]
			public static unsafe void ValidateTransformRangeKernel(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x0000000188A15328-0x0000000188A153A4
			[BurstCompile]
			public static unsafe void ValidateTransformKernel_BurstManaged(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // 0x0000000188A092E4-0x0000000188A09DE8
			[BurstCompile]
			public static unsafe void ValidateTransformRangeKernel_BurstManaged(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // 0x0000000188A152A8-0x0000000188A15328
		}
	
		[BurstCompile]
		private struct ValidTransformJob : IJob, IUnsafeJob // TypeDefIndex: 77721
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
			public void SetIndexCount(int indexCount); // 0x00000001854CCF30-0x00000001854CCF40
			public void Execute(); // 0x0000000188A1516C-0x0000000188A151A0
			public void UnsafeDo(); // 0x0000000188A151A0-0x0000000188A1522C
			public void Execute(int index); // 0x000000018722B770-0x000000018722B780
		}
	
		[BurstCompile]
		private struct WriteTransformJob : IJobParallelForTransform // TypeDefIndex: 77722
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
			public void Execute(int index, TransformAccess transform); // 0x0000000188A1777C-0x0000000188A1AC68
		}
	
		[BurstCompile]
		private struct ReadComponentTransformJob : IJobParallelForTransform // TypeDefIndex: 77723
		{
			// Fields
			[WriteOnly]
			public NativeArray<float3> positionArray; // 0x00
	
			// Methods
			public void Execute(int index, TransformAccess transform); // 0x0000000188A0EB1C-0x0000000188A0EB8C
		}
	
		// Constructors
		public DynamicBoneTransformManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public JobHandle WriteAnimatorBufferData(JobHandle jobHandle, ref NativeParallelHashMap<int, int> teamId2AnimatorInstnceId, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler, ref NativeParallelHashMap<int, int> transformID2RWHandlerID); // 0x0000000188A0D2AC-0x0000000188A0D508
		public JobHandle ReadAnimatorBufferData(JobHandle jobHandle, ref NativeParallelHashMap<int, int> teamId2AnimatorInstnceId, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler, ref NativeParallelHashMap<int, int> transformID2RWHandlerID); // 0x0000000188A0D008-0x0000000188A0D2AC
		public JobHandle CopyDoubleBuffer(JobHandle jobHandle); // 0x00000001854CDBE0-0x00000001854CDEE0
		public JobHandle WriteDoubleBufferTransform(JobHandle jobHandle); // 0x00000001854CE630-0x00000001854CE840
		public void Dispose(); // 0x0000000185E359E0-0x0000000185E35C20
		public void EnterdEditMode(); // 0x0000000188A0C65C-0x0000000188A0C664
		public void Initialize(); // 0x0000000186098A70-0x0000000186098F00
		public bool IsValid(); // 0x0000000182271B00-0x0000000182271B10
		internal DataChunk AddTransform(VirtualMeshContainer cmesh, int teamId); // 0x0000000185B199D0-0x0000000185B19D80
		internal DataChunk AddTransform(int count, int teamId); // 0x0000000185B19FB0-0x0000000185B1A290
		internal DataChunk AddTransform(Transform t, ExBitFlag8 flag, int teamId); // 0x0000000188A0C138-0x0000000188A0C65C
		internal void SetTransform(Transform t, ExBitFlag8 flag, int index, int teamId); // 0x0000000185B1A8F0-0x0000000185B1AE20
		internal void CopyTransform(int fromIndex, int toIndex); // 0x00000001859F2570-0x00000001859F2850
		internal void RemoveTransform(DataChunk c); // 0x00000001859F3F40-0x00000001859F41B0
		internal void EnableTransform(DataChunk c, bool sw); // 0x0000000185B1BBF0-0x0000000185B1BC60
		internal void EnableTransform(int index, bool sw); // 0x0000000185B1BB90-0x0000000185B1BBF0
		internal DataChunk Expand(DataChunk c, int newLength); // 0x0000000188A0C664-0x0000000188A0C950
		public JobHandle RestoreTransform(JobHandle jobHandle); // 0x00000001854CE840-0x00000001854CEBF0
		public JobHandle ReadTransform(JobHandle jobHandle); // 0x00000001854CE1A0-0x00000001854CE410
		public JobHandle WriteTransform(JobHandle jobHandle); // 0x0000000188A0D508-0x0000000188A0D6F0
		public JobHandle ValidPosition(JobHandle jobHandle); // 0x00000001854CDEE0-0x00000001854CE1A0
		internal int AddComponentTransform(Transform t); // 0x00000001853C8A90-0x00000001853C8B70
		internal void RemoveComponentTransform(int index); // 0x0000000185FF16E0-0x0000000185FF1760
		internal JobHandle ReadComponentTransform(JobHandle jobHandle); // 0x000000018605B1A0-0x000000018605B2B0
		public void InformationLog(StringBuilder allsb); // 0x0000000188A0C950-0x0000000188A0D008
		public static void Initialize_WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_00000265_BurstDirectCall(); // 0x0000000186B31300-0x0000000186B31340
		public static void Initialize_WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_00000266_BurstDirectCall(); // 0x0000000186B31340-0x0000000186B31380
	}

	public class TeamManager : IManager, IValid // TypeDefIndex: 77754
	{
		// Fields
		public const int Flag_Valid = 0; // Metadata: 0x0262A1F8
		public const int Flag_Enable = 1; // Metadata: 0x0262A1F9
		public const int Flag_Reset = 2; // Metadata: 0x0262A1FA
		public const int Flag_TimeReset = 3; // Metadata: 0x0262A1FB
		public const int Flag_SyncSuspend = 4; // Metadata: 0x0262A1FC
		public const int Flag_Running = 5; // Metadata: 0x0262A1FD
		public const int Flag_Synchronization = 6; // Metadata: 0x0262A1FE
		public const int Flag_StepRunning = 7; // Metadata: 0x0262A1FF
		public const int Flag_Exit = 8; // Metadata: 0x0262A200
		public const int Flag_KeepTeleport = 9; // Metadata: 0x0262A201
		public const int Flag_InertiaShift = 10; // Metadata: 0x0262A202
		public const int Flag_CameraCullingInvisible = 11; // Metadata: 0x0262A203
		public const int Flag_CameraCullingKeep = 12; // Metadata: 0x0262A204
		public const int Flag_Spring = 13; // Metadata: 0x0262A205
		public const int Flag_SkipWriting = 14; // Metadata: 0x0262A206
		public const int Flag_Anchor = 15; // Metadata: 0x0262A207
		public const int Flag_AnchorReset = 16; // Metadata: 0x0262A208
		public const int Flag_NegativeScale = 17; // Metadata: 0x0262A209
		public const int Flag_NegativeScaleTeleport = 18; // Metadata: 0x0262A20A
		public const int Flag_DistanceCullingInvisible = 19; // Metadata: 0x0262A20B
		public const int Flag_RestoreTransformOnlyOnec = 20; // Metadata: 0x0262A20C
		public const int Flag_Tangent = 21; // Metadata: 0x0262A20D
		public const int Flag_Self_PointPrimitive = 32; // Metadata: 0x0262A20E
		public const int Flag_Self_EdgePrimitive = 33; // Metadata: 0x0262A20F
		public const int Flag_Self_TrianglePrimitive = 34; // Metadata: 0x0262A210
		public const int Flag_Self_EdgeEdge = 35; // Metadata: 0x0262A211
		public const int Flag_Sync_EdgeEdge = 36; // Metadata: 0x0262A212
		public const int Flag_PSync_EdgeEdge = 37; // Metadata: 0x0262A213
		public const int Flag_Self_PointTriangle = 38; // Metadata: 0x0262A214
		public const int Flag_Sync_PointTriangle = 39; // Metadata: 0x0262A215
		public const int Flag_PSync_PointTriangle = 40; // Metadata: 0x0262A216
		public const int Flag_Self_TrianglePoint = 41; // Metadata: 0x0262A217
		public const int Flag_Sync_TrianglePoint = 42; // Metadata: 0x0262A218
		public const int Flag_PSync_TrianglePoint = 43; // Metadata: 0x0262A219
		public const int Flag_Self_EdgeTriangleIntersect = 44; // Metadata: 0x0262A21A
		public const int Flag_Sync_EdgeTriangleIntersect = 45; // Metadata: 0x0262A21B
		public const int Flag_PSync_EdgeTriangleIntersect = 46; // Metadata: 0x0262A21C
		public const int Flag_Self_TriangleEdgeIntersect = 47; // Metadata: 0x0262A21D
		public const int Flag_Sync_TriangleEdgeIntersect = 48; // Metadata: 0x0262A21E
		public const int Flag_PSync_TriangleEdgeIntersect = 49; // Metadata: 0x0262A21F
		public const int Flag_Lod_LodOut = 60; // Metadata: 0x0262A220
		public const int Flag_Lod_Culled = 61; // Metadata: 0x0262A221
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
		internal HashSet<ClothProcess> codeParameterDirtyList; // 0x110
		private readonly object m_codeParameterDirtyLock; // 0x118
		internal NativeList<int> cullingDirtyList; // 0x120
		internal NativeParallelHashSet<int> alwaysTeamUpdateSelfCollisionUpdateSet; // 0x130
		internal NativeParallelHashMap<int, int> animatorUpdateModeMap; // 0x140
		internal ExSimpleNativeArray<int> teamAnchorTransformIndexArray; // 0x150
		internal ExSimpleNativeArray<int> teamDistanceTransformIndexArray; // 0x158
		internal NativeParallelHashMap<int, float3> transformPositionMap; // 0x160
		internal NativeParallelHashMap<int, quaternion> transformRotationMap; // 0x170
		internal HashSet<BeyondBoneCloth> cameraCullingClothSet; // 0x180
		private static readonly ProfilerMarker teamCameraCullingPreProfiler; // 0x00
		private static readonly ProfilerMarker teamCameraCullingProfiler; // 0x08
		private static readonly ProfilerMarker startClothUpdateComponentProfiler; // 0x10
		private static readonly ProfilerMarker alwaysTeamUpdateCodeParameterDirtyProfiler; // 0x18
		private static readonly ProfilerMarker alwaysTeamUpdateParameterDirtyProfiler; // 0x20
		private static readonly ProfilerMarker alwaysTeamUpdateStep2Profiler; // 0x28
		private static readonly ProfilerMarker alwaysTeamUpdateStep3Profiler; // 0x30
		private static readonly ProfilerMarker alwaysTeamUpdateEdgeColliderProfiler; // 0x38
		private static readonly ProfilerMarker alwaysTeamUpdateSelfCollisionStepProfiler; // 0x40
		private HashSet<ClothProcess> monitoringProcessSet; // 0x188
		private List<ClothProcess> disposeProcessList; // 0x190
	
		// Properties
		public int MappingCount { get; } // 0x000000018629A5D0-0x000000018629A5E0 
		public int TeamCount { get; } // 0x00000001854CD220-0x00000001854CD230 
		public int TrueTeamCount { get; } // 0x00000001854CEFF0-0x00000001854CF010 
		public int ActiveTeamCount { get; } // 0x00000001854D0C50-0x00000001854D0C70 
	
		// Nested types
		[BurstCompile]
		public static class SimulationStepTeamUpdateKernels // TypeDefIndex: 77733
		{
			// Nested types
			public unsafe delegate void SimulationStepTeamUpdateKernel_000002A0_PostfixBurstDelegate(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // TypeDefIndex: 77725; 0x0000000182388DE0-0x0000000182388E00
	
			internal static class SimulationStepTeamUpdateKernel_000002A0_BurstDirectCall // TypeDefIndex: 77726
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SimulationStepTeamUpdateKernel_000002A0_BurstDirectCall(); // 0x00000001823881E0-0x00000001823881F0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a664e); // 0x0000000182386C60-0x00000001823878C0
				private static IntPtr GetFunctionPointer(); // 0x00000001823878C0-0x0000000182387BC0
				public static void Constructor(); // 0x00000001823863E0-0x0000000182386C60
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // 0x0000000182387BC0-0x00000001823881E0
			}
	
			public unsafe delegate void SimulationStepTeamUpdateRangeKernel_000002A1_PostfixBurstDelegate(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // TypeDefIndex: 77727; 0x0000000182388DE0-0x0000000182388E00
	
			internal static class SimulationStepTeamUpdateRangeKernel_000002A1_BurstDirectCall // TypeDefIndex: 77728
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SimulationStepTeamUpdateRangeKernel_000002A1_BurstDirectCall(); // 0x000000018238B040-0x000000018238B050
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6669); // 0x00000001823897A0-0x000000018238A400
				private static IntPtr GetFunctionPointer(); // 0x000000018238A400-0x000000018238A700
				public static void Constructor(); // 0x0000000182388F20-0x00000001823897A0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // 0x000000018238A700-0x000000018238B040
			}
	
			public unsafe delegate void UpdateWind_000002A2_PostfixBurstDelegate(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // TypeDefIndex: 77729; 0x0000000181256340-0x0000000181256360
	
			internal static class UpdateWind_000002A2_BurstDirectCall // TypeDefIndex: 77730
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateWind_000002A2_BurstDirectCall(); // 0x0000000182391350-0x0000000182391360
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6682); // 0x000000018238F050-0x000000018238FCB0
				private static IntPtr GetFunctionPointer(); // 0x000000018238FCB0-0x000000018238FFB0
				public static void Constructor(); // 0x000000018238E7D0-0x000000018238F050
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // 0x000000018238FFB0-0x0000000182391350
			}
	
			public delegate void UpdateWindTime_000002A3_PostfixBurstDelegate(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // TypeDefIndex: 77731; 0x000000018238E680-0x000000018238E6A0
	
			internal static class UpdateWindTime_000002A3_BurstDirectCall // TypeDefIndex: 77732
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateWindTime_000002A3_BurstDirectCall(); // 0x000000018238DAB0-0x000000018238DAC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6694); // 0x000000018238C4E0-0x000000018238D140
				private static IntPtr GetFunctionPointer(); // 0x000000018238D140-0x000000018238D440
				public static void Constructor(); // 0x000000018238BC60-0x000000018238C4E0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static void Invoke(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // 0x000000018238D440-0x000000018238DAB0
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateKernel(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // 0x0000000188A294E4-0x0000000188A2955C
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateRangeKernel(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // 0x0000000188A295F4-0x0000000188A2966C
			[BurstCompile]
			private static unsafe void UpdateWind(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // 0x0000000188A29A58-0x0000000188A29AD0
			[BurstCompile]
			private static void UpdateWindTime(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // 0x0000000188A296C4-0x0000000188A29728
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateKernel_BurstManaged(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // 0x0000000188A286F8-0x0000000188A294E4
			[BurstCompile]
			public static unsafe void SimulationStepTeamUpdateRangeKernel_BurstManaged(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // 0x0000000188A2955C-0x0000000188A295F4
			[BurstCompile]
			public static unsafe void UpdateWind_BurstManaged(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // 0x0000000188A29728-0x0000000188A29A58
			[BurstCompile]
			public static void UpdateWindTime_BurstManaged(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // 0x0000000188A2966C-0x0000000188A296C4
		}
	
		[BurstCompile]
		private static class PostTeamUpdateJobKernels // TypeDefIndex: 77738
		{
			// Nested types
			public unsafe delegate void PostTeamUpdateKernel_000002A4_PostfixBurstDelegate(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // TypeDefIndex: 77734; 0x00000001811DF7F0-0x00000001811DF810
	
			internal static class PostTeamUpdateKernel_000002A4_BurstDirectCall // TypeDefIndex: 77735
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostTeamUpdateKernel_000002A4_BurstDirectCall(); // 0x0000000182383020-0x0000000182383030
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a66af); // 0x0000000182381AB0-0x0000000182382710
				private static IntPtr GetFunctionPointer(); // 0x0000000182382710-0x0000000182382A10
				public static void Constructor(); // 0x0000000182381230-0x0000000182381AB0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // 0x0000000182382A10-0x0000000182383020
			}
	
			public unsafe delegate void PostTeamUpdateRangeKernel_000002A5_PostfixBurstDelegate(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // TypeDefIndex: 77736; 0x00000001811DF7F0-0x00000001811DF810
	
			internal static class PostTeamUpdateRangeKernel_000002A5_BurstDirectCall // TypeDefIndex: 77737
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostTeamUpdateRangeKernel_000002A5_BurstDirectCall(); // 0x0000000182385AF0-0x0000000182385B00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a66be); // 0x00000001823842C0-0x0000000182384F20
				private static IntPtr GetFunctionPointer(); // 0x0000000182384F20-0x0000000182385220
				public static void Constructor(); // 0x0000000182383A40-0x00000001823842C0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x0000000182385220-0x0000000182385AF0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PostTeamUpdateKernel(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // 0x0000000188A26D3C-0x0000000188A26D9C
			[BurstCompile]
			internal static unsafe void PostTeamUpdateRangeKernel(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x0000000188A26DEC-0x0000000188A26E4C
			[BurstCompile]
			public static unsafe void PostTeamUpdateKernel_BurstManaged(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // 0x0000000188A1C108-0x0000000188A1D6C8
			[BurstCompile]
			public static unsafe void PostTeamUpdateRangeKernel_BurstManaged(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x0000000188A26D9C-0x0000000188A26DEC
		}
	
		public struct TeamData // TypeDefIndex: 77739
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
			public bool bUseRelativeTransform { get; } // 0x0000000188A29BC4-0x0000000188A29BD0 
			public bool IsFixedUpdate { get; } // 0x0000000188A29B0C-0x0000000188A29B14 
			public bool IsUnscaled { get; } // 0x0000000188A29BBC-0x0000000188A29BC4 
			public bool IsValid { get; } // 0x000000018783988C-0x0000000187839894 
			public bool IsEnable { get; } // 0x0000000185B1AF80-0x0000000185B1AFA0 
			public bool IsLODCulled { get; } // 0x0000000188A29B2C-0x0000000188A29B40 
			public bool IsProcess { get; } // 0x0000000188A29B58-0x0000000188A29B88 
			public bool IsReset { get; } // 0x0000000188A29B88-0x0000000188A29B90 
			public bool IsKeepReset { get; } // 0x0000000188A29B20-0x0000000188A29B2C 
			public bool IsInertiaShift { get; } // 0x0000000188A29B14-0x0000000188A29B20 
			public bool IsRunning { get; } // 0x0000000188A29B90-0x0000000188A29B98 
			public bool IsStepRunning { get; } // 0x0000000188A29BA4-0x0000000188A29BB0 
			public bool IsCameraCullingInvisible { get; } // 0x0000000188A29AD0-0x0000000188A29ADC 
			public bool IsCameraCullingKeep { get; } // 0x0000000188A29ADC-0x0000000188A29AE8 
			public bool IsDistanceCullingInvisible { get; } // 0x0000000188A29B00-0x0000000188A29B0C 
			public bool IsCullingInvisible { get; } // 0x0000000188A29AE8-0x0000000188A29B00 
			public bool IsSpring { get; } // 0x0000000188A29B98-0x0000000188A29BA4 
			public bool IsNegativeScale { get; } // 0x0000000188A29B4C-0x0000000188A29B58 
			public bool IsNegativeScaleTeleport { get; } // 0x0000000188A29B40-0x0000000188A29B4C 
			public bool IsTangent { get; } // 0x0000000188A29BB0-0x0000000188A29BBC 
			public int ParticleCount { get; } // 0x0000000187233DD0-0x0000000187233DE0 
			public int ColliderCount { get; } // 0x0000000187233DB0-0x0000000187233DC0 
			public int BaseLineCount { get; } // 0x0000000187233DA0-0x0000000187233DB0 
			public int TriangleCount { get; } // 0x0000000187233DE0-0x0000000187233DF0 
			public int EdgeCount { get; } // 0x0000000187233DC0-0x0000000187233DD0 
			public float InitScale { get; } // 0x0000000187233590-0x00000001872335A0 
		}
	
		public struct MappingData : IValid // TypeDefIndex: 77740
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
			public int VertexCount { get; } // 0x0000000184431980-0x0000000184431990 
	
			// Methods
			public bool IsValid(); // 0x0000000188A26D34-0x0000000188A26D3C
		}
	
		[BurstCompile]
		private struct AlwaysTeamUpdatePreJob : IJob // TypeDefIndex: 77741
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
			public void Execute(); // 0x0000000188A1F420-0x0000000188A20DB4
		}
	
		[BurstCompile]
		private struct AlwaysTeamUpdatePostJob : IJob // TypeDefIndex: 77742
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
			public void Execute(); // 0x0000000188A1EB4C-0x0000000188A1F420
			private void DistanceCullingUpdate(int teamId, ref TeamData tdata); // 0x0000000188A1E8F4-0x0000000188A1EB4C
		}
	
		[BurstCompile]
		public static class CalcCenterAndInertiaAndWindKernels // TypeDefIndex: 77749
		{
			// Nested types
			public unsafe delegate void CalcCenterAndInertiaAndWindKernel_000002C5_PostfixBurstDelegate(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // TypeDefIndex: 77743; 0x000000018237E1D0-0x000000018237E290
	
			internal static class CalcCenterAndInertiaAndWindKernel_000002C5_BurstDirectCall // TypeDefIndex: 77744
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcCenterAndInertiaAndWindKernel_000002C5_BurstDirectCall(); // 0x000000018237D590-0x000000018237D5A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a672f); // 0x000000018237BEE0-0x000000018237CB40
				private static IntPtr GetFunctionPointer(); // 0x000000018237CB40-0x000000018237CE40
				public static void Constructor(); // 0x000000018237B660-0x000000018237BEE0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // 0x000000018237CE40-0x000000018237D590
			}
	
			public unsafe delegate void CalcCenterAndInertiaAndWindRangeKernel_000002C6_PostfixBurstDelegate(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // TypeDefIndex: 77745; 0x000000018237E1D0-0x000000018237E290
	
			internal static class CalcCenterAndInertiaAndWindRangeKernel_000002C6_BurstDirectCall // TypeDefIndex: 77746
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcCenterAndInertiaAndWindRangeKernel_000002C6_BurstDirectCall(); // 0x00000001823805F0-0x0000000182380600
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6762); // 0x000000018237EC30-0x000000018237F890
				private static IntPtr GetFunctionPointer(); // 0x000000018237F890-0x000000018237FB90
				public static void Constructor(); // 0x000000018237E3B0-0x000000018237EC30
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // 0x000000018237FB90-0x00000001823805F0
			}
	
			public unsafe delegate void Wind_000002C7_PostfixBurstDelegate(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // TypeDefIndex: 77747; 0x0000000181256340-0x0000000181256360
	
			internal static class Wind_000002C7_BurstDirectCall // TypeDefIndex: 77748
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Wind_000002C7_BurstDirectCall(); // 0x0000000182397860-0x0000000182397870
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6783); // 0x00000001823962E0-0x0000000182396F40
				private static IntPtr GetFunctionPointer(); // 0x0000000182396F40-0x0000000182397240
				public static void Constructor(); // 0x0000000182395A60-0x00000001823962E0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // 0x0000000182397240-0x0000000182397860
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindKernel(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // 0x0000000188A26344-0x0000000188A263C8
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindRangeKernel(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // 0x0000000188A264E0-0x0000000188A26564
			[BurstCompile]
			public static unsafe void Wind(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // 0x0000000188A26CBC-0x0000000188A26D34
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindKernel_BurstManaged(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // 0x0000000188A23E58-0x0000000188A26344
			[BurstCompile]
			public static unsafe void CalcCenterAndInertiaAndWindRangeKernel_BurstManaged(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // 0x0000000188A263C8-0x0000000188A264E0
			[BurstCompile]
			public static unsafe void Wind_BurstManaged(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // 0x0000000188A26564-0x0000000188A26CBC
		}
	
		[BurstCompile]
		private struct CalcCenterAndInertiaAndWindJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77750
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
			public void SetIndexCount(int indexCount); // 0x0000000185F72560-0x0000000185F72570
			public void Execute(); // 0x0000000188A23544-0x0000000188A23588
			public void Execute(int teamId); // 0x0000000188A20DB4-0x0000000188A23544
			private void Wind(int teamId, [IsReadOnly] in ClothParameters param, [IsReadOnly] in double3 centerWorldPos); // 0x0000000188A236FC-0x0000000188A23E58
			public void UnsafeDo(); // 0x0000000188A23588-0x0000000188A236FC
		}
	
		[BurstCompile]
		private struct SimulationStepTeamUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77751
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
			public void SetIndexCount(int indexCount); // 0x0000000185E120B0-0x0000000185E120C0
			public void Execute(); // 0x0000000188A282A4-0x0000000188A282E4
			public void Execute(int teamId); // 0x0000000188A276A0-0x0000000188A282A4
			private void UpdateWind(int teamId, [IsReadOnly] in TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata); // 0x0000000188A283C8-0x0000000188A286F8
			private void UpdateWindTime(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // 0x0000000188A28370-0x0000000188A283C8
			public void UnsafeDo(); // 0x0000000188A282E4-0x0000000188A28370
		}
	
		[BurstCompile]
		private struct PostTeamUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77752
		{
			// Fields
			public NativeArray<TeamData> teamDataArray; // 0x00
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x10
			[ReadOnly]
			public int _indexCount; // 0x20
	
			// Methods
			public void SetIndexCount(int indexCount); // 0x0000000186036460-0x0000000186036470
			public void Execute(); // 0x0000000188A26E4C-0x0000000188A26E8C
			public void Execute(int teamId); // 0x0000000188A26E8C-0x0000000188A27654
			public void UnsafeDo(); // 0x0000000188A27654-0x0000000188A276A0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77753
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<ClothProcess> __9__137_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188A29BD0-0x0000000188A29C34
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _MonitoringProcess_b__137_0(ClothProcess cprocess); // 0x000000018238BC40-0x000000018238BC60
		}
	
		// Constructors
		public TeamManager(); // 0x0000000186CABF20-0x0000000186CADB10
		static TeamManager(); // 0x0000000186E16250-0x0000000186E16490
	
		// Methods
		internal void UpdateTeamAnimatorData(ExNativeArray<short> teamIdArray, TransformAccessArray transformArray); // 0x0000000188A12880-0x0000000188A13668
		internal void ClearTeamAnimatorData(int teamId); // 0x0000000185FF1A90-0x0000000185FF1B10
		internal void AddTeamAnimatorData(int teamId, ClothProcess cprocess); // 0x00000001853C8200-0x00000001853C83C0
		internal void AddAnimatorTransform(int teamId, Transform t); // 0x0000000185B19E00-0x0000000185B19EA0
		internal void MarkAnimatorTransformDirty(int teamId, Transform t); // 0x0000000186FBABE0-0x0000000186FBAC90
		internal void MarkCodeParameterDirtyFromAnimationJob(ClothProcess process); // 0x000000018237B220-0x000000018237B660
		public void Dispose(); // 0x0000000185E724D0-0x0000000185E72990
		public void EnterdEditMode(); // 0x0000000188A10FE8-0x0000000188A10FF0
		public void Initialize(); // 0x00000001864DEFA0-0x00000001864DFC20
		public bool IsValid(); // 0x000000018226ED60-0x000000018226ED70
		internal int AddTeam(ClothProcess cprocess, ClothParameters clothParams); // 0x00000001853C9310-0x00000001853C9960
		internal void RemoveTeam(int teamId); // 0x0000000185FF1760-0x0000000185FF1A70
		public void SetEnable(int teamId, bool sw); // 0x0000000185B1B200-0x0000000185B1B390
		public bool IsEnable(int teamId); // 0x00000001854D7C80-0x00000001854D7CB0
		internal void SetSkipWriting(int teamId, bool sw); // 0x0000000188A127F8-0x0000000188A12880
		public bool ContainsTeamData(int teamId); // 0x00000001859F34B0-0x00000001859F3510
		public ref TeamData GetTeamDataRef(int teamId); // 0x00000001854D7710-0x00000001854D7910
		public ref FixedList64Bytes<short> GetTeamMappingRef(int teamId); // 0x0000000188A11044-0x0000000188A11098
		public ref ClothParameters GetParametersRef(int teamId); // 0x0000000186AC6730-0x0000000186AC6790
		internal ref InertiaConstraint.CenterData GetCenterDataRef(int teamId); // 0x0000000188A10FF0-0x0000000188A11044
		public ClothProcess GetClothProcess(int teamId); // 0x00000001859F3450-0x00000001859F34B0
		internal void CameraCullingPreProcess(); // 0x00000001854D8250-0x00000001854D8820
		internal void CameraCullingPostProcess(); // 0x00000001854D7CF0-0x00000001854D81C0
		private static bool ShouldResetSimulationToAnimationPose(BeyondBoneCloth cloth); // 0x00000001853C8450-0x00000001853C8480
		private static void ApplyWeightDrivenSimulationPosePolicy(ref TeamData tdata, BeyondBoneCloth cloth); // 0x00000001853C83C0-0x00000001853C8450
		internal void AlwaysTeamUpdate(); // 0x00000001854D8820-0x00000001854DB8C0
		private void RemoveSyncParent(ref TeamData tdata, int parentTeamId); // 0x0000000188A127AC-0x0000000188A127F8
		internal JobHandle CalcCenterAndInertiaAndWind(JobHandle jobHandle); // 0x00000001854D30C0-0x00000001854D3550
		internal JobHandle SimulationStepTeamUpdate(int updateIndex, JobHandle jobHandle); // 0x00000001854D4260-0x00000001854D4520
		internal JobHandle PostTeamUpdate(JobHandle jobHandle); // 0x00000001854CE410-0x00000001854CE630
		internal void AddMonitoringProcess(ClothProcess cprocess); // 0x0000000188A10F90-0x0000000188A10FE8
		internal void RemoveMonitoringProcess(ClothProcess cprocess); // 0x0000000185D78660-0x0000000185D786D0
		private void MonitoringProcess(bool force); // 0x0000000185E733C0-0x0000000185E739B0
		private void MonitoringProcessUpdate(); // 0x0000000185E733B0-0x0000000185E733C0
		public void InformationLog(StringBuilder allsb); // 0x0000000188A11098-0x0000000188A127AC
		public static void Initialize_PostTeamUpdateJobKernels_PostTeamUpdateKernel_000002A4_BurstDirectCall(); // 0x000000018237AC20-0x000000018237AF20
		public static void Initialize_PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_000002A5_BurstDirectCall(); // 0x000000018237AF20-0x000000018237B220
	}

	public class VirtualMeshManager : IManager, IValid // TypeDefIndex: 77814
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
		public int ProxyVertexCount { get; } // 0x00000001854CD220-0x00000001854CD230 
		public int ProxyTriangleCount { get; } // 0x00000001854D2110-0x00000001854D2130 
		public int ProxyEdgeCount { get; } // 0x0000000188A2BBE8-0x0000000188A2BC24 
		public int ProxyBaseLineCount { get; } // 0x0000000186129290-0x00000001861292B0 
		public int ProxyLocalPositionCount { get; } // 0x0000000188A2BC24-0x0000000188A2C514 
		public int MappingVertexCount { get; } // 0x0000000188A2BBAC-0x0000000188A2BBE8 
	
		// Nested types
		[BurstCompile]
		public static class CalcProxyMeshSkinningKernels // TypeDefIndex: 77759
		{
			// Nested types
			public unsafe delegate void CalcProxyMeshSkinningKernel_000002F0_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // TypeDefIndex: 77755; 0x00000001823A52D0-0x00000001823A5380
	
			internal static class CalcProxyMeshSkinningKernel_000002F0_BurstDirectCall // TypeDefIndex: 77756
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxyMeshSkinningKernel_000002F0_BurstDirectCall(); // 0x00000001823A4950-0x00000001823A4960
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6807); // 0x00000001823A32B0-0x00000001823A3F10
				private static IntPtr GetFunctionPointer(); // 0x00000001823A3F10-0x00000001823A4210
				public static void Constructor(); // 0x00000001823A2A30-0x00000001823A32B0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // 0x00000001823A4210-0x00000001823A4950
			}
	
			public unsafe delegate void CalcProxyMeshSkinningRangeKernel_000002F1_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // TypeDefIndex: 77757; 0x00000001823A7D60-0x00000001823A7E10
	
			internal static class CalcProxyMeshSkinningRangeKernel_000002F1_BurstDirectCall // TypeDefIndex: 77758
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxyMeshSkinningRangeKernel_000002F1_BurstDirectCall(); // 0x00000001823A76C0-0x00000001823A76D0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6837); // 0x00000001823A5D30-0x00000001823A6990
				private static IntPtr GetFunctionPointer(); // 0x00000001823A6990-0x00000001823A6C90
				public static void Constructor(); // 0x00000001823A54B0-0x00000001823A5D30
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // 0x00000001823A6C90-0x00000001823A76C0
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // 0x0000000188A33364-0x0000000188A333E4
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // 0x0000000188A334E4-0x0000000188A33564
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // 0x0000000188A2CC2C-0x0000000188A2EC38
			[BurstCompile]
			public static unsafe void CalcProxyMeshSkinningRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // 0x0000000188A333E4-0x0000000188A334E4
		}
	
		[BurstCompile]
		private static class CreatePostProxyMeshUpdateListJobKernels // TypeDefIndex: 77764
		{
			// Nested types
			public unsafe delegate void CreatePostProxyMeshUpdateListKernel_000002F2_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // TypeDefIndex: 77760; 0x00000001823BBF70-0x00000001823BBFF0
	
			internal static class CreatePostProxyMeshUpdateListKernel_000002F2_BurstDirectCall // TypeDefIndex: 77761
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreatePostProxyMeshUpdateListKernel_000002F2_BurstDirectCall(); // 0x00000001823BB620-0x00000001823BB630
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6887); // 0x00000001823B9DC0-0x00000001823BAA20
				private static IntPtr GetFunctionPointer(); // 0x00000001823BAA20-0x00000001823BAD20
				public static void Constructor(); // 0x00000001823B9540-0x00000001823B9DC0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // 0x00000001823BAD20-0x00000001823BB620
			}
	
			public unsafe delegate void CreatePostProxyMeshUpdateListRangeKernel_000002F3_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // TypeDefIndex: 77762; 0x00000001823BBF70-0x00000001823BBFF0
	
			internal static class CreatePostProxyMeshUpdateListRangeKernel_000002F3_BurstDirectCall // TypeDefIndex: 77763
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreatePostProxyMeshUpdateListRangeKernel_000002F3_BurstDirectCall(); // 0x00000001823BE2B0-0x00000001823BE2C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a68ab); // 0x00000001823BC9A0-0x00000001823BD600
				private static IntPtr GetFunctionPointer(); // 0x00000001823BD600-0x00000001823BD900
				public static void Constructor(); // 0x00000001823BC120-0x00000001823BC9A0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // 0x00000001823BD900-0x00000001823BE2B0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CreatePostProxyMeshUpdateListKernel(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // 0x0000000188A37520-0x0000000188A3759C
			[BurstCompile]
			internal static unsafe void CreatePostProxyMeshUpdateListRangeKernel(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // 0x0000000188A37658-0x0000000188A376D4
			[BurstCompile]
			public static unsafe void CreatePostProxyMeshUpdateListKernel_BurstManaged(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // 0x0000000188A37298-0x0000000188A37520
			[BurstCompile]
			public static unsafe void CreatePostProxyMeshUpdateListRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // 0x0000000188A3759C-0x0000000188A37658
		}
	
		[BurstCompile]
		private static class CalcLineNormalTangentJobKernels // TypeDefIndex: 77769
		{
			// Nested types
			public unsafe delegate void CalcLineNormalTangentKernel_000002F4_PostfixBurstDelegate(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // TypeDefIndex: 77765; 0x000000018239AA50-0x000000018239AB20
	
			internal static class CalcLineNormalTangentKernel_000002F4_BurstDirectCall // TypeDefIndex: 77766
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcLineNormalTangentKernel_000002F4_BurstDirectCall(); // 0x000000018239A0B0-0x000000018239A0C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6921); // 0x0000000182398B10-0x0000000182399770
				private static IntPtr GetFunctionPointer(); // 0x0000000182399770-0x0000000182399A70
				public static void Constructor(); // 0x0000000182398290-0x0000000182398B10
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // 0x0000000182399A70-0x000000018239A0B0
			}
	
			public unsafe delegate void CalcLineNormalTangentRangeKernel_000002F5_PostfixBurstDelegate(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // TypeDefIndex: 77767; 0x000000018239D580-0x000000018239D650
	
			internal static class CalcLineNormalTangentRangeKernel_000002F5_BurstDirectCall // TypeDefIndex: 77768
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcLineNormalTangentRangeKernel_000002F5_BurstDirectCall(); // 0x000000018239CEB0-0x000000018239CEC0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a695a); // 0x000000018239B4D0-0x000000018239C130
				private static IntPtr GetFunctionPointer(); // 0x000000018239C130-0x000000018239C430
				public static void Constructor(); // 0x000000018239AC50-0x000000018239B4D0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // 0x000000018239C430-0x000000018239CEB0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcLineNormalTangentKernel(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // 0x0000000188A31434-0x0000000188A314B4
			[BurstCompile]
			internal static unsafe void CalcLineNormalTangentRangeKernel(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // 0x0000000188A315E0-0x0000000188A31660
			[BurstCompile]
			public static unsafe void CalcLineNormalTangentKernel_BurstManaged(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // 0x0000000188A30B90-0x0000000188A31434
			[BurstCompile]
			public static unsafe void CalcLineNormalTangentRangeKernel_BurstManaged(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // 0x0000000188A314B4-0x0000000188A315E0
		}
	
		[BurstCompile]
		private static class WriteTransformDataJobKernels // TypeDefIndex: 77774
		{
			// Nested types
			public unsafe delegate void WriteTransformDataKernel_000002F6_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // TypeDefIndex: 77770; 0x0000000181241E70-0x0000000181241E90
	
			internal static class WriteTransformDataKernel_000002F6_BurstDirectCall // TypeDefIndex: 77771
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformDataKernel_000002F6_BurstDirectCall(); // 0x00000001823D3E90-0x00000001823D3EA0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a69a7); // 0x00000001823D2580-0x00000001823D31E0
				private static IntPtr GetFunctionPointer(); // 0x00000001823D31E0-0x00000001823D34E0
				public static void Constructor(); // 0x00000001823D1D00-0x00000001823D2580
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // 0x00000001823D34E0-0x00000001823D3E90
			}
	
			public unsafe delegate void WriteTransformDataRangeKernel_000002F7_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // TypeDefIndex: 77772; 0x00000001823B2550-0x00000001823B25C0
	
			internal static class WriteTransformDataRangeKernel_000002F7_BurstDirectCall // TypeDefIndex: 77773
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformDataRangeKernel_000002F7_BurstDirectCall(); // 0x00000001823D6950-0x00000001823D6960
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a69c8); // 0x00000001823D5060-0x00000001823D5CC0
				private static IntPtr GetFunctionPointer(); // 0x00000001823D5CC0-0x00000001823D5FC0
				public static void Constructor(); // 0x00000001823D47E0-0x00000001823D5060
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // 0x00000001823D5FC0-0x00000001823D6950
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteTransformDataKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // 0x0000000188A3D2A0-0x0000000188A3D31C
			[BurstCompile]
			internal static unsafe void WriteTransformDataRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // 0x0000000188A3D3CC-0x0000000188A3D448
			[BurstCompile]
			public static unsafe void WriteTransformDataKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // 0x0000000188A3CF78-0x0000000188A3D2A0
			[BurstCompile]
			public static unsafe void WriteTransformDataRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // 0x0000000188A3D31C-0x0000000188A3D3CC
		}
	
		[BurstCompile]
		private static class WriteTransformLocalDataJobKernels // TypeDefIndex: 77779
		{
			// Nested types
			public unsafe delegate void WriteTransformLocalDataKernel_000002F8_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // TypeDefIndex: 77775; 0x00000001823D90D0-0x00000001823D9150
	
			internal static class WriteTransformLocalDataKernel_000002F8_BurstDirectCall // TypeDefIndex: 77776
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformLocalDataKernel_000002F8_BurstDirectCall(); // 0x00000001823D8770-0x00000001823D8780
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6a19); // 0x00000001823D71E0-0x00000001823D7E40
				private static IntPtr GetFunctionPointer(); // 0x00000001823D7E40-0x00000001823D8140
				public static void Constructor(); // 0x00000001823D6960-0x00000001823D71E0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // 0x00000001823D8140-0x00000001823D8770
			}
	
			public unsafe delegate void WriteTransformLocalDataRangeKernel_000002F9_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // TypeDefIndex: 77777; 0x00000001823DBAB0-0x00000001823DBB30
	
			internal static class WriteTransformLocalDataRangeKernel_000002F9_BurstDirectCall // TypeDefIndex: 77778
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformLocalDataRangeKernel_000002F9_BurstDirectCall(); // 0x00000001823DB430-0x00000001823DB440
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6a40); // 0x00000001823D9B00-0x00000001823DA760
				private static IntPtr GetFunctionPointer(); // 0x00000001823DA760-0x00000001823DAA60
				public static void Constructor(); // 0x00000001823D9280-0x00000001823D9B00
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // 0x00000001823DAA60-0x00000001823DB430
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void WriteTransformLocalDataKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // 0x0000000188A3DC58-0x0000000188A3DCD4
			[BurstCompile]
			internal static unsafe void WriteTransformLocalDataRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // 0x0000000188A3DDA4-0x0000000188A3DE20
			[BurstCompile]
			public static unsafe void WriteTransformLocalDataKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // 0x0000000188A3D8A8-0x0000000188A3DC58
			[BurstCompile]
			public static unsafe void WriteTransformLocalDataRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // 0x0000000188A3DCD4-0x0000000188A3DDA4
		}
	
		[BurstCompile]
		private static class CalcProxySkinningJobKernels // TypeDefIndex: 77784
		{
			// Nested types
			public unsafe delegate void CalcProxySkinningKernel_000002FA_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // TypeDefIndex: 77780; 0x00000001823AA700-0x00000001823AA7C0
	
			internal static class CalcProxySkinningKernel_000002FA_BurstDirectCall // TypeDefIndex: 77781
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxySkinningKernel_000002FA_BurstDirectCall(); // 0x00000001823A9D60-0x00000001823A9D70
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6ab1); // 0x00000001823A87C0-0x00000001823A9420
				private static IntPtr GetFunctionPointer(); // 0x00000001823A9420-0x00000001823A9720
				public static void Constructor(); // 0x00000001823A7F40-0x00000001823A87C0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // 0x00000001823A9720-0x00000001823A9D60
			}
	
			public unsafe delegate void CalcProxySkinningRangeKernel_000002FB_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // TypeDefIndex: 77782; 0x00000001823AA700-0x00000001823AA7C0
	
			internal static class CalcProxySkinningRangeKernel_000002FB_BurstDirectCall // TypeDefIndex: 77783
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxySkinningRangeKernel_000002FB_BurstDirectCall(); // 0x00000001823ACB20-0x00000001823ACB30
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6ae7); // 0x00000001823AB170-0x00000001823ABDD0
				private static IntPtr GetFunctionPointer(); // 0x00000001823ABDD0-0x00000001823AC0D0
				public static void Constructor(); // 0x00000001823AA8F0-0x00000001823AB170
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // 0x00000001823AC0D0-0x00000001823ACB20
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcProxySkinningKernel(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // 0x0000000188A34434-0x0000000188A344B4
			[BurstCompile]
			internal static unsafe void CalcProxySkinningRangeKernel(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // 0x0000000188A345D0-0x0000000188A34650
			[BurstCompile]
			public static unsafe void CalcProxySkinningKernel_BurstManaged(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // 0x0000000188A33564-0x0000000188A34434
			[BurstCompile]
			public static unsafe void CalcProxySkinningRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // 0x0000000188A344B4-0x0000000188A345D0
		}
	
		[BurstCompile]
		private static class CalcMeshConvertMatrixJobKernels // TypeDefIndex: 77789
		{
			// Nested types
			public unsafe delegate void CalcMeshConvertMatrixKernel_000002FC_PostfixBurstDelegate(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // TypeDefIndex: 77785; 0x0000000181256340-0x0000000181256360
	
			internal static class CalcMeshConvertMatrixKernel_000002FC_BurstDirectCall // TypeDefIndex: 77786
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcMeshConvertMatrixKernel_000002FC_BurstDirectCall(); // 0x000000018239F580-0x000000018239F590
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6b21); // 0x000000018239E000-0x000000018239EC60
				private static IntPtr GetFunctionPointer(); // 0x000000018239EC60-0x000000018239EF60
				public static void Constructor(); // 0x000000018239D780-0x000000018239E000
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // 0x000000018239EF60-0x000000018239F580
			}
	
			public unsafe delegate void CalcMeshConvertMatrixRangeKernel_000002FD_PostfixBurstDelegate(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // TypeDefIndex: 77787; 0x0000000181256340-0x0000000181256360
	
			internal static class CalcMeshConvertMatrixRangeKernel_000002FD_BurstDirectCall // TypeDefIndex: 77788
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcMeshConvertMatrixRangeKernel_000002FD_BurstDirectCall(); // 0x00000001823A20F0-0x00000001823A2100
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6b39); // 0x00000001823A0870-0x00000001823A14D0
				private static IntPtr GetFunctionPointer(); // 0x00000001823A14D0-0x00000001823A17D0
				public static void Constructor(); // 0x000000018239FFF0-0x00000001823A0870
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // 0x00000001823A17D0-0x00000001823A20F0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcMeshConvertMatrixKernel(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // 0x0000000188A3217C-0x0000000188A321F8
			[BurstCompile]
			internal static unsafe void CalcMeshConvertMatrixRangeKernel(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // 0x0000000188A32278-0x0000000188A322F4
			[BurstCompile]
			public static unsafe void CalcMeshConvertMatrixKernel_BurstManaged(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // 0x0000000188A2C514-0x0000000188A2CC2C
			[BurstCompile]
			public static unsafe void CalcMeshConvertMatrixRangeKernel_BurstManaged(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // 0x0000000188A321F8-0x0000000188A32278
		}
	
		[BurstCompile]
		private static class CalcTriangleNormalTangentJobKernels // TypeDefIndex: 77794
		{
			// Nested types
			public unsafe delegate void CalcTriangleNormalTangentKernel_000002FE_PostfixBurstDelegate(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // TypeDefIndex: 77790; 0x0000000181241E70-0x0000000181241E90
	
			internal static class CalcTriangleNormalTangentKernel_000002FE_BurstDirectCall // TypeDefIndex: 77791
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcTriangleNormalTangentKernel_000002FE_BurstDirectCall(); // 0x00000001823AF2D0-0x00000001823AF2E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6b7b); // 0x00000001823ADD40-0x00000001823AE9A0
				private static IntPtr GetFunctionPointer(); // 0x00000001823AE9A0-0x00000001823AECA0
				public static void Constructor(); // 0x00000001823AD4C0-0x00000001823ADD40
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // 0x00000001823AECA0-0x00000001823AF2D0
			}
	
			public unsafe delegate void CalcTriangleNormalTangentRangeKernel_000002FF_PostfixBurstDelegate(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // TypeDefIndex: 77792; 0x00000001823B2550-0x00000001823B25C0
	
			internal static class CalcTriangleNormalTangentRangeKernel_000002FF_BurstDirectCall // TypeDefIndex: 77793
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcTriangleNormalTangentRangeKernel_000002FF_BurstDirectCall(); // 0x00000001823B1EC0-0x00000001823B1ED0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6b9c); // 0x00000001823B05D0-0x00000001823B1230
				private static IntPtr GetFunctionPointer(); // 0x00000001823B1230-0x00000001823B1530
				public static void Constructor(); // 0x00000001823AFD50-0x00000001823B05D0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // 0x00000001823B1530-0x00000001823B1EC0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcTriangleNormalTangentKernel(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // 0x0000000188A35B90-0x0000000188A35C0C
			[BurstCompile]
			internal static unsafe void CalcTriangleNormalTangentRangeKernel(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // 0x0000000188A35CBC-0x0000000188A35D38
			[BurstCompile]
			public static unsafe void CalcTriangleNormalTangentKernel_BurstManaged(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // 0x0000000188A3564C-0x0000000188A35B90
			[BurstCompile]
			public static unsafe void CalcTriangleNormalTangentRangeKernel_BurstManaged(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // 0x0000000188A35C0C-0x0000000188A35CBC
		}
	
		[BurstCompile]
		private static class CalcVertexNormalTangentFromTriangleJobKernels // TypeDefIndex: 77799
		{
			// Nested types
			public unsafe delegate void CalcVertexNormalTangentFromTriangleKernel_00000300_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // TypeDefIndex: 77795; 0x0000000181241E70-0x0000000181241E90
	
			internal static class CalcVertexNormalTangentFromTriangleKernel_00000300_BurstDirectCall // TypeDefIndex: 77796
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcVertexNormalTangentFromTriangleKernel_00000300_BurstDirectCall(); // 0x00000001823B4500-0x00000001823B4510
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6be1); // 0x00000001823B2F70-0x00000001823B3BD0
				private static IntPtr GetFunctionPointer(); // 0x00000001823B3BD0-0x00000001823B3ED0
				public static void Constructor(); // 0x00000001823B26F0-0x00000001823B2F70
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // 0x00000001823B3ED0-0x00000001823B4500
			}
	
			public unsafe delegate void CalcVertexNormalTangentFromTriangleRangeKernel_00000301_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // TypeDefIndex: 77797; 0x00000001823B2550-0x00000001823B25C0
	
			internal static class CalcVertexNormalTangentFromTriangleRangeKernel_00000301_BurstDirectCall // TypeDefIndex: 77798
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcVertexNormalTangentFromTriangleRangeKernel_00000301_BurstDirectCall(); // 0x00000001823B6FC0-0x00000001823B6FD0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6c02); // 0x00000001823B56D0-0x00000001823B6330
				private static IntPtr GetFunctionPointer(); // 0x00000001823B6330-0x00000001823B6630
				public static void Constructor(); // 0x00000001823B4E50-0x00000001823B56D0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // 0x00000001823B6630-0x00000001823B6FC0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcVertexNormalTangentFromTriangleKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // 0x0000000188A36958-0x0000000188A369D4
			[BurstCompile]
			internal static unsafe void CalcVertexNormalTangentFromTriangleRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // 0x0000000188A36A84-0x0000000188A36B00
			[BurstCompile]
			public static unsafe void CalcVertexNormalTangentFromTriangleKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // 0x0000000188A36400-0x0000000188A36958
			[BurstCompile]
			public static unsafe void CalcVertexNormalTangentFromTriangleRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // 0x0000000188A369D4-0x0000000188A36A84
		}
	
		[BurstCompile]
		private static class ClearProxyMeshUpdateBufferJobKernels // TypeDefIndex: 77802
		{
			// Nested types
			public unsafe delegate void ClearProxyMeshUpdateBufferKernel_00000302_PostfixBurstDelegate(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // TypeDefIndex: 77800; 0x00000001811CDB70-0x00000001811CDB90
	
			internal static class ClearProxyMeshUpdateBufferKernel_00000302_BurstDirectCall // TypeDefIndex: 77801
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearProxyMeshUpdateBufferKernel_00000302_BurstDirectCall(); // 0x00000001823B8DC0-0x00000001823B8DD0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6c21); // 0x00000001823B7850-0x00000001823B84B0
				private static IntPtr GetFunctionPointer(); // 0x00000001823B84B0-0x00000001823B87B0
				public static void Constructor(); // 0x00000001823B6FD0-0x00000001823B7850
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // 0x00000001823B87B0-0x00000001823B8DC0
			}
	
			// Methods
			[BurstCompile]
			internal static unsafe void ClearProxyMeshUpdateBufferKernel(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // 0x0000000188A37184-0x0000000188A371FC
			[BurstCompile]
			public static unsafe void ClearProxyMeshUpdateBufferKernel_BurstManaged(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // 0x0000000187233E30-0x0000000187233E40
		}
	
		[BurstCompile]
		private struct ClearProxyMeshUpdateBufferJob : IJob, IUnsafeJob // TypeDefIndex: 77803
		{
			// Fields
			public NativeReference<int> processingCounter0; // 0x00
			public NativeReference<int> processingCounter1; // 0x10
			public NativeReference<int> processingCounter2; // 0x20
			public NativeReference<int> processingCounter3; // 0x30
	
			// Methods
			public void Execute(); // 0x0000000188A371FC-0x0000000188A37250
			public void UnsafeDo(); // 0x0000000188A37250-0x0000000188A37298
		}
	
		[BurstCompile]
		private struct CreateProxyMeshUpdateVertexList : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77804
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
			public void SetIndexCount(int indexCount); // 0x0000000186033510-0x0000000186033520
			public void Execute(); // 0x0000000188A37C14-0x0000000188A37C54
			public void Execute(int teamId); // 0x0000000188A37A54-0x0000000188A37C14
			public void UnsafeDo(); // 0x0000000188A37C54-0x0000000188A37CB4
		}
	
		[BurstCompile]
		private struct CalcProxyMeshSkinningJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77805
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B40-0x0000000187233B50
			public void Execute(); // 0x0000000188A33170-0x0000000188A331D0
			public void Execute(int index); // 0x0000000188A32AC8-0x0000000188A33170
			public void UnsafeDo(); // 0x0000000188A331D0-0x0000000188A33364
		}
	
		[BurstCompile]
		private struct CreatePostProxyMeshUpdateListJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77806
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
			public void SetIndexCount(int indexCount); // 0x0000000185FD6920-0x0000000185FD6930
			public void Execute(); // 0x0000000188A376D4-0x0000000188A37718
			public void Execute(int teamId); // 0x0000000188A37718-0x0000000188A37988
			public void UnsafeDo(); // 0x0000000188A37988-0x0000000188A37A54
		}
	
		[BurstCompile]
		private struct CalcLineNormalTangentJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77807
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233E00-0x0000000187233E10
			public void Execute(); // 0x0000000188A31F18-0x0000000188A31F78
			public void Execute(int index); // 0x0000000188A31660-0x0000000188A31F18
			public void UnsafeDo(); // 0x0000000188A31F78-0x0000000188A3217C
		}
	
		[BurstCompile]
		private struct CalcTriangleNormalTangentJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77808
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233E20-0x0000000187233E30
			public void Execute(); // 0x0000000188A362A4-0x0000000188A36304
			public void Execute(int index); // 0x0000000188A35D38-0x0000000188A362A4
			public void UnsafeDo(); // 0x0000000188A36304-0x0000000188A36400
		}
	
		[BurstCompile]
		private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77809
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233E20-0x0000000187233E30
			public void Execute(); // 0x0000000188A37034-0x0000000188A37094
			public void Execute(int index); // 0x0000000188A36B00-0x0000000188A37034
			public void UnsafeDo(); // 0x0000000188A37094-0x0000000188A37184
		}
	
		[BurstCompile]
		private struct WriteTransformDataJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77810
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233E20-0x0000000187233E30
			public void Execute(); // 0x0000000188A3D448-0x0000000188A3D4A8
			public void Execute(int index); // 0x0000000188A3D4A8-0x0000000188A3D7C4
			public void UnsafeDo(); // 0x0000000188A3D7C4-0x0000000188A3D8A8
		}
	
		[BurstCompile]
		private struct WriteTransformLocalDataJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77811
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233E60-0x0000000187233E70
			public void Execute(); // 0x0000000188A3DE20-0x0000000188A3DE80
			public void Execute(int index); // 0x0000000188A3DE80-0x0000000188A3E200
			public void UnsafeDo(); // 0x0000000188A3E200-0x0000000188A3E330
		}
	
		[BurstCompile]
		private struct CalcMeshConvertMatrixJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77812
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
			public void SetIndexCount(int indexCount); // 0x00000001854CCF30-0x00000001854CCF40
			public void Execute(); // 0x0000000188A322F4-0x0000000188A32334
			public void Execute(int index); // 0x0000000188A32334-0x0000000188A32A3C
			public void UnsafeDo(); // 0x0000000188A32A3C-0x0000000188A32AC8
		}
	
		[BurstCompile]
		private struct CalcProxySkinningJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77813
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
			public void SetIndexCount(int indexCount); // 0x0000000187233E10-0x0000000187233E20
			public void Execute(); // 0x0000000188A34650-0x0000000188A34694
			public void Execute(int mvindex); // 0x0000000188A34694-0x0000000188A354A4
			public void UnsafeDo(); // 0x0000000188A354A4-0x0000000188A3564C
		}
	
		// Constructors
		public VirtualMeshManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		[BurstCompile]
		public static unsafe void CreateProxyMeshUpdateVertexListKernel(TeamManager.TeamData* teamDataArray, int* processingCounter1, int* processingList1, int teamId); // 0x0000000188A29C34-0x0000000188A29DEC
		[BurstCompile]
		public static unsafe void CreateProxyMeshUpdateVertexListRangeKernel(TeamManager.TeamData* teamDataArray, int* processingCounter1, int* processingList1, int length); // 0x0000000188A29DEC-0x0000000188A29E54
		public void Dispose(); // 0x0000000186097E40-0x00000001860984E0
		public void EnterdEditMode(); // 0x0000000188A29E54-0x0000000188A29E5C
		public void Initialize(); // 0x0000000186098F00-0x000000018609A430
		public bool IsValid(); // 0x0000000187233DF0-0x0000000187233E00
		public void RegisterProxyMesh(int teamId, VirtualMeshContainer proxyMeshContainer); // 0x0000000186265F50-0x0000000186266660
		public void ExitProxyMesh(int teamId); // 0x00000001859F41B0-0x00000001859F48E0
		public DataChunk RegisterMappingMesh(int teamId, VirtualMeshContainer mappingMeshContainer); // 0x0000000188A2B634-0x0000000188A2BA90
		public void ExitMappingMesh(int teamId, int mappingIndex); // 0x0000000188A29E5C-0x0000000188A2A1EC
		internal void UpdateBuffer(); // 0x0000000188A2BA90-0x0000000188A2BBAC
		internal JobHandle PreProxyMeshUpdate(JobHandle jobHandle); // 0x00000001854D0CD0-0x00000001854D17E0
		internal JobHandle PostProxyMeshUpdate(JobHandle jobHandle); // 0x00000001854D2130-0x00000001854D30C0
		internal JobHandle PostMappingMeshUpdate(JobHandle jobHandle); // 0x0000000188A2B1B4-0x0000000188A2B634
		public void InformationLog(StringBuilder allsb); // 0x0000000188A2A1EC-0x0000000188A2B1B4
		public static void Initialize_CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002F2_BurstDirectCall(); // 0x0000000182394860-0x0000000182394B60
		public static void Initialize_CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002F3_BurstDirectCall(); // 0x0000000182394B60-0x0000000182394E60
		public static void Initialize_CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002F4_BurstDirectCall(); // 0x0000000182392760-0x0000000182392A60
		public static void Initialize_CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002F5_BurstDirectCall(); // 0x0000000182392A60-0x0000000182392D60
		public static void Initialize_WriteTransformDataJobKernels_WriteTransformDataKernel_000002F6_BurstDirectCall(); // 0x0000000182394E60-0x0000000182395160
		public static void Initialize_WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002F7_BurstDirectCall(); // 0x0000000182395160-0x0000000182395460
		public static void Initialize_WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002F8_BurstDirectCall(); // 0x0000000182395460-0x0000000182395760
		public static void Initialize_WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002F9_BurstDirectCall(); // 0x0000000182395760-0x0000000182395A60
		public static void Initialize_CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002FA_BurstDirectCall(); // 0x0000000182393360-0x0000000182393660
		public static void Initialize_CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002FB_BurstDirectCall(); // 0x0000000182393660-0x0000000182393960
		public static void Initialize_CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002FC_BurstDirectCall(); // 0x0000000182392D60-0x0000000182393060
		public static void Initialize_CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002FD_BurstDirectCall(); // 0x0000000182393060-0x0000000182393360
		public static void Initialize_CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002FE_BurstDirectCall(); // 0x0000000182393960-0x0000000182393C60
		public static void Initialize_CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002FF_BurstDirectCall(); // 0x0000000182393C60-0x0000000182393F60
		public static void Initialize_CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_00000300_BurstDirectCall(); // 0x0000000182393F60-0x0000000182394260
		public static void Initialize_CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_00000301_BurstDirectCall(); // 0x0000000182394260-0x0000000182394560
		public static void Initialize_ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_00000302_BurstDirectCall(); // 0x0000000182394560-0x0000000182394860
	}

	public interface IManager : IDisposable // TypeDefIndex: 77815
	{
		// Methods
		void Initialize();
		void EnterdEditMode();
		void InformationLog(StringBuilder allsb);
	}

	public static class MagicaManager // TypeDefIndex: 77820
	{
		// Fields
		private static List<IManager> managers; // 0x00
		public static bool EnableTick; // 0x08
		public static bool UseCrossFrameJob; // 0x09
		public static bool UseAnimatorTransform; // 0x0A
		private static TimeManager s_Time; // 0x10
		private static TeamManager s_Team; // 0x18
		private static ClothManager s_Cloth; // 0x20
		private static RenderManager s_Render; // 0x28
		private static DynamicBoneTransformManager s_Bone; // 0x30
		private static VirtualMeshManager s_VMesh; // 0x38
		private static SimulationManager s_Simulation; // 0x40
		private static ColliderManager s_Collider; // 0x48
		private static WindManager s_Wind; // 0x50
		private static PreBuildManager s_PreBuild; // 0x58
		public static UpdateMethod afterEarlyUpdateDelegate; // 0x60
		public static UpdateMethod afterFixedUpdateDelegate; // 0x68
		public static UpdateMethod afterUpdateDelegate; // 0x70
		public static UpdateMethod beforeLateUpdateDelegate; // 0x78
		public static UpdateMethod afterLateUpdateDelegate; // 0x80
		public static UpdateMethod postClothUpdateDelegate; // 0x88
		public static UpdateMethod afterDelayedDelegate; // 0x90
		public static UpdateMethod afterRenderingDelegate; // 0x98
		public static UpdateMethod defaultUpdateDelegate; // 0xA0
		public static UpdateMethod onApplicationQuitDelegate; // 0xA8
		private static bool isPlaying; // 0xB0
		public static Action OnPreSimulation; // 0xB8
		public static Action OnPostSimulation; // 0xC0
		internal static InitializationLocation initializationLocation; // 0xC8
	
		// Properties
		public static TimeManager Time { get; } // 0x00000001854D6BC0-0x00000001854D6CE0 
		public static TeamManager Team { get; } // 0x00000001854D7B60-0x00000001854D7C80 
		public static ClothManager Cloth { get; } // 0x00000001854D7910-0x00000001854D7A30 
		public static RenderManager Render { get; } // 0x00000001861831C0-0x00000001861832E0 
		public static DynamicBoneTransformManager Bone { get; } // 0x00000001854D0B30-0x00000001854D0C50 
		public static VirtualMeshManager VMesh { get; } // 0x00000001854D6CE0-0x00000001854D6E00 
		public static SimulationManager Simulation { get; } // 0x00000001854D6E00-0x00000001854D6F20 
		public static ColliderManager Collider { get; } // 0x00000001854D6AA0-0x00000001854D6BC0 
		public static WindManager Wind { get; } // 0x00000001854D4A60-0x00000001854D4B80 
		public static PreBuildManager PreBuild { get; } // 0x0000000186183480-0x00000001861835E0 
	
		// Nested types
		public delegate void UpdateMethod(); // TypeDefIndex: 77816; 0x0000000185B44B70-0x0000000185B44B80
	
		public enum InitializationLocation // TypeDefIndex: 77817
		{
			Start = 0,
			Awake = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77818
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__50_0; // 0x08
			public static PlayerLoopSystem.UpdateFunction __9__51_0; // 0x10
			public static PlayerLoopSystem.UpdateFunction __9__51_1; // 0x18
			public static PlayerLoopSystem.UpdateFunction __9__51_2; // 0x20
			public static PlayerLoopSystem.UpdateFunction __9__51_3; // 0x28
			public static PlayerLoopSystem.UpdateFunction __9__51_4; // 0x30
			public static PlayerLoopSystem.UpdateFunction __9__51_5; // 0x38
			public static PlayerLoopSystem.UpdateFunction __9__51_6; // 0x40
	
			// Constructors
			static __c(); // 0x00000001871E5FC0-0x00000001871E6020
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _InitCustomGameLoop_b__50_0(); // 0x00000001823BEC00-0x00000001823BEF20
			internal void _SetCustomGameLoop_b__51_0(); // 0x00000001823BEF20-0x00000001823BF260
			internal void _SetCustomGameLoop_b__51_1(); // 0x00000001823BF260-0x00000001823BF5A0
			internal void _SetCustomGameLoop_b__51_2(); // 0x00000001823BF5A0-0x00000001823BF960
			internal void _SetCustomGameLoop_b__51_3(); // 0x00000001823BF960-0x00000001823BFCA0
			internal void _SetCustomGameLoop_b__51_4(); // 0x00000001823BFCA0-0x00000001823C0020
			internal void _SetCustomGameLoop_b__51_5(); // 0x00000001823C0020-0x00000001823C0360
			internal void _SetCustomGameLoop_b__51_6(); // 0x00000001823C0360-0x00000001823C06A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0 // TypeDefIndex: 77819
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass52_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x); // 0x00000001823C06A0-0x00000001823C09C0
		}
	
		// Constructors
		static MagicaManager(); // 0x0000000186E5F340-0x0000000186E5F590
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Initialize(); // 0x0000000185E74420-0x0000000185E76630
		private static void Dispose(); // 0x0000000186DFC820-0x0000000186DFCF50
		public static bool IsPlaying(); // 0x00000001854D0C70-0x00000001854D0CD0
		public static void SetUseCrossFrameJob(bool value); // 0x0000000188A38358-0x0000000188A383BC
		public static void InitCustomGameLoop(); // 0x0000000185BBF580-0x0000000185BBF740
		private static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop); // 0x0000000185BB9DE0-0x0000000185BBA800
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop); // 0x0000000185BBB250-0x0000000185BBB3F0
		public static void SetGlobalTimeScale(float timeScale); // 0x0000000188A38134-0x0000000188A381A8
		public static float GetGlobalTimeScale(); // 0x0000000188A37E94-0x0000000188A37F24
		public static void SetSimulationFrequency(int freq); // 0x0000000188A38278-0x0000000188A382F4
		public static void SetAOVMode(bool enable, float deltaTime); // 0x0000000188A380BC-0x0000000188A38134
		public static void DoAOVUpdate(); // 0x0000000188A37DA8-0x0000000188A37E94
		public static void DoAOVAfterAnimatorUpdate(); // 0x0000000188A37CB4-0x0000000188A37DA8
		public static int GetSimulationFrequency(); // 0x0000000188A37FAC-0x0000000188A38034
		public static void SetMaxSimulationCountPerFrame(int count); // 0x0000000188A38200-0x0000000188A38278
		public static int GetMaxSimulationCountPerFrame(); // 0x0000000188A37F24-0x0000000188A37FAC
		public static void SetUpdateLocation(TimeManager.UpdateLocation updateLocation); // 0x0000000188A382F4-0x0000000188A38358
		public static TimeManager.UpdateLocation GetUpdateLocation(); // 0x0000000188A38034-0x0000000188A380BC
		public static void UnloadUnusedData(); // 0x0000000186183140-0x00000001861831C0
		public static void SetInitializationLocation(InitializationLocation initLocation); // 0x0000000188A381A8-0x0000000188A38200
	}

	[AddComponentMenu("MagicaCloth2/MagicaSettings")]
	[HelpURL("https://magicasoft.jp/en/mc2_settings_component/")]
	public class MagicaSettings : ClothBehaviour // TypeDefIndex: 77822
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
		public enum RefreshMode // TypeDefIndex: 77821
		{
			OnAwake = 0,
			EveryFrame = 1,
			OnStart = 2,
			Manual = 3
		}
	
		// Constructors
		public MagicaSettings(); // 0x0000000188A38548-0x0000000188A3856C
	
		// Methods
		public void Awake(); // 0x0000000188A383BC-0x0000000188A383CC
		public void Start(); // 0x0000000188A38528-0x0000000188A38538
		public void Update(); // 0x0000000188A38538-0x0000000188A38548
		private void OnValidate(); // 0x0000000188A383CC-0x0000000188A383F8
		public void Refresh(); // 0x0000000188A383F8-0x0000000188A38528
	}

	[BurstCompile]
	internal static class UpdatePositionNormalJobKernels // TypeDefIndex: 77827
	{
		// Nested types
		public unsafe delegate void UpdatePositionNormalKernel_00000365_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // TypeDefIndex: 77823; 0x00000001812458F0-0x0000000181245910
	
		internal static class UpdatePositionNormalKernel_00000365_BurstDirectCall // TypeDefIndex: 77824
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalKernel_00000365_BurstDirectCall(); // 0x00000001823C8BB0-0x00000001823C8BC0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6c80); // 0x00000001823C6D30-0x00000001823C7990
			private static IntPtr GetFunctionPointer(); // 0x00000001823C7990-0x00000001823C7C90
			public static void Constructor(); // 0x00000001823C64B0-0x00000001823C6D30
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // 0x00000001823C7C90-0x00000001823C8BB0
		}
	
		public unsafe delegate void UpdatePositionNormalRangeKernel_00000366_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // TypeDefIndex: 77825; 0x00000001812458F0-0x0000000181245910
	
		internal static class UpdatePositionNormalRangeKernel_00000366_BurstDirectCall // TypeDefIndex: 77826
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalRangeKernel_00000366_BurstDirectCall(); // 0x00000001823CB740-0x00000001823CB750
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6c9e); // 0x00000001823C9E70-0x00000001823CAAD0
			private static IntPtr GetFunctionPointer(); // 0x00000001823CAAD0-0x00000001823CADD0
			public static void Constructor(); // 0x00000001823C95F0-0x00000001823C9E70
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // 0x00000001823CADD0-0x00000001823CB740
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdatePositionNormalKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // 0x0000000188A3C6DC-0x0000000188A3C754
		[BurstCompile]
		internal static unsafe void UpdatePositionNormalRangeKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // 0x0000000188A3C7F8-0x0000000188A3C870
		[BurstCompile]
		public static unsafe void UpdatePositionNormalKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // 0x0000000188A3C5F0-0x0000000188A3C6DC
		[BurstCompile]
		public static unsafe void UpdatePositionNormalRangeKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // 0x0000000188A3C754-0x0000000188A3C7F8
	}

	[BurstCompile]
	internal static class UpdatePositionNormalTangentJobKernels // TypeDefIndex: 77832
	{
		// Nested types
		public unsafe delegate void UpdatePositionNormalTangentKernel_00000367_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // TypeDefIndex: 77828; 0x00000001823BBF70-0x00000001823BBFF0
	
		internal static class UpdatePositionNormalTangentKernel_00000367_BurstDirectCall // TypeDefIndex: 77829
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalTangentKernel_00000367_BurstDirectCall(); // 0x00000001823CE7E0-0x00000001823CE7F0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6ce8); // 0x00000001823CC8E0-0x00000001823CD540
			private static IntPtr GetFunctionPointer(); // 0x00000001823CD540-0x00000001823CD840
			public static void Constructor(); // 0x00000001823CC060-0x00000001823CC8E0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // 0x00000001823CD840-0x00000001823CE7E0
		}
	
		public unsafe delegate void UpdatePositionNormalTangentRangeKernel_00000368_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // TypeDefIndex: 77830; 0x00000001823BBF70-0x00000001823BBFF0
	
		internal static class UpdatePositionNormalTangentRangeKernel_00000368_BurstDirectCall // TypeDefIndex: 77831
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalTangentRangeKernel_00000368_BurstDirectCall(); // 0x00000001823D13C0-0x00000001823D13D0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6d0c); // 0x00000001823CFAC0-0x00000001823D0720
			private static IntPtr GetFunctionPointer(); // 0x00000001823D0720-0x00000001823D0A20
			public static void Constructor(); // 0x00000001823CF240-0x00000001823CFAC0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // 0x00000001823D0A20-0x00000001823D13C0
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdatePositionNormalTangentKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // 0x0000000188A3CB7C-0x0000000188A3CBF4
		[BurstCompile]
		internal static unsafe void UpdatePositionNormalTangentRangeKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // 0x0000000188A3CCB0-0x0000000188A3CD28
		[BurstCompile]
		public static unsafe void UpdatePositionNormalTangentKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // 0x0000000188A3CA10-0x0000000188A3CB7C
		[BurstCompile]
		public static unsafe void UpdatePositionNormalTangentRangeKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // 0x0000000188A3CBF4-0x0000000188A3CCB0
	}

	[BurstCompile]
	internal static class UpdateBoneWeightJob2Kernels // TypeDefIndex: 77837
	{
		// Nested types
		public unsafe delegate void UpdateBoneWeight2Kernel_00000369_PostfixBurstDelegate(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // TypeDefIndex: 77833; 0x0000000181256340-0x0000000181256360
	
		internal static class UpdateBoneWeight2Kernel_00000369_BurstDirectCall // TypeDefIndex: 77834
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdateBoneWeight2Kernel_00000369_BurstDirectCall(); // 0x00000001823C3070-0x00000001823C3080
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6d40); // 0x00000001823C1240-0x00000001823C1EA0
			private static IntPtr GetFunctionPointer(); // 0x00000001823C1EA0-0x00000001823C21A0
			public static void Constructor(); // 0x00000001823C09C0-0x00000001823C1240
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // 0x00000001823C21A0-0x00000001823C3070
		}
	
		public unsafe delegate void UpdateBoneWeight2RangeKernel_0000036A_PostfixBurstDelegate(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // TypeDefIndex: 77835; 0x0000000181256340-0x0000000181256360
	
		internal static class UpdateBoneWeight2RangeKernel_0000036A_BurstDirectCall // TypeDefIndex: 77836
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdateBoneWeight2RangeKernel_0000036A_BurstDirectCall(); // 0x00000001823C5BA0-0x00000001823C5BB0
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6d58); // 0x00000001823C4320-0x00000001823C4F80
			private static IntPtr GetFunctionPointer(); // 0x00000001823C4F80-0x00000001823C5280
			public static void Constructor(); // 0x00000001823C3AA0-0x00000001823C4320
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // 0x00000001823C5280-0x00000001823C5BA0
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void UpdateBoneWeight2Kernel(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // 0x0000000188A3C31C-0x0000000188A3C394
		[BurstCompile]
		internal static unsafe void UpdateBoneWeight2RangeKernel(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // 0x0000000188A3C414-0x0000000188A3C48C
		[BurstCompile]
		public static unsafe void UpdateBoneWeight2Kernel_BurstManaged(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // 0x0000000188A3C250-0x0000000188A3C31C
		[BurstCompile]
		public static unsafe void UpdateBoneWeight2RangeKernel_BurstManaged(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // 0x0000000188A3C394-0x0000000188A3C414
	}

	public class RenderData : IDisposable, ITransform // TypeDefIndex: 77842
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
		private const int Flag_UseCustomMesh = 0; // Metadata: 0x0262A228
		private const int Flag_ChangePositionNormal = 1; // Metadata: 0x0262A229
		private const int Flag_ChangeBoneWeight = 2; // Metadata: 0x0262A22A
		private const int Flag_ModifyBoneWeight = 3; // Metadata: 0x0262A22B
		private const int Flag_HasMeshTangent = 4; // Metadata: 0x0262A22C
		private const int Flag_HasTangent = 5; // Metadata: 0x0262A22D
		private const int Flag_ChangeTangent = 6; // Metadata: 0x0262A22E
		private BitField32 flag; // 0xC0
	
		// Properties
		public int ReferenceCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
		internal string Name { get; } // 0x0000000188A39DC0-0x0000000188A39E04 
		internal bool HasSkinnedMesh { get; } // 0x0000000188A39DA4-0x0000000188A39DB4 
		internal bool HasBoneWeight { get; } // 0x0000000188A39D88-0x0000000188A39D98 
		public bool UseCustomMesh { get; } // 0x0000000188A39E24-0x0000000188A39E30 
		public bool HasMeshTangent { get; } // 0x0000000188A39D98-0x0000000188A39DA4 
		public bool HasTangent { get; } // 0x0000000188A39DB4-0x0000000188A39DC0 
		internal ResultCode Result { get; } // 0x0000000188A39E04-0x0000000188A39E24 
	
		// Nested types
		[BurstCompile]
		private struct UpdatePositionNormalJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77838
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
			public void SetIndexCount(int indexCount); // 0x0000000185B8E660-0x0000000185B8E8A0
			public void Execute(); // 0x0000000188A3C870-0x0000000188A3C8B0
			public void Execute(int index); // 0x0000000188A3C8B0-0x0000000188A3C988
			public void UnsafeDo(); // 0x0000000188A3C988-0x0000000188A3CA10
		}
	
		[BurstCompile]
		private struct UpdatePositionNormalTangentJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77839
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
			public void SetIndexCount(int indexCount); // 0x0000000185B8E410-0x0000000185B8E660
			public void Execute(); // 0x0000000188A3CD28-0x0000000188A3CD6C
			public void Execute(int index); // 0x0000000188A3CD6C-0x0000000188A3CEB0
			public void UnsafeDo(); // 0x0000000188A3CEB0-0x0000000188A3CF78
		}
	
		[BurstCompile]
		private struct UpdateBoneWeightJob2 : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77840
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
			public void SetIndexCount(int indexCount); // 0x0000000185B8E8A0-0x0000000185B8EB10
			public void Execute(); // 0x0000000188A3C48C-0x0000000188A3C4CC
			public void Execute(int index); // 0x0000000188A3C4CC-0x0000000188A3C56C
			public void UnsafeDo(); // 0x0000000188A3C56C-0x0000000188A3C5F0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77841
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ClothProcess, bool> __9__52_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188A3C1EC-0x0000000188A3C250
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _UpdateUse_b__52_0(ClothProcess x); // 0x0000000188A3C1B8-0x0000000188A3C1EC
		}
	
		// Constructors
		public RenderData(); // 0x0000000188A39D10-0x0000000188A39D88
	
		// Methods
		public void Dispose(); // 0x0000000188A3856C-0x0000000188A386B4
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A386C4-0x0000000188A386D8
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A388EC-0x0000000188A38900
		internal void Initialize(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referencePreBuildUniqueSetupData); // 0x0000000188A386D8-0x0000000188A388EC
		internal int AddReferenceCount(); // 0x0000000187233E40-0x0000000187233E50
		internal int RemoveReferenceCount(); // 0x0000000187233E50-0x0000000187233E60
		private void SwapCustomMesh(); // 0x0000000188A38BB0-0x0000000188A38F88
		private void ResetCustomMeshWorkData(); // 0x0000000188A38900-0x0000000188A38AC8
		private void SwapOriginalMesh(); // 0x0000000188A38F88-0x0000000188A39044
		private void SetMesh(Mesh mesh); // 0x0000000188A38AC8-0x0000000188A38BA0
		public void StartUse(ClothProcess cprocess); // 0x0000000188A38BA0-0x0000000188A38BB0
		public void EndUse(ClothProcess cprocess); // 0x0000000188A386B4-0x0000000188A386C4
		internal void UpdateUse(ClothProcess cprocess, int add); // 0x0000000188A39970-0x0000000188A39B80
		internal void UpdateSkipWriting(); // 0x0000000188A39838-0x0000000188A39970
		internal void WriteMesh(); // 0x0000000188A39B80-0x0000000188A39D10
		internal JobHandle UpdatePositionNormal(bool updateTangent, DataChunk mappingChunk, JobHandle jobHandle); // 0x0000000188A3942C-0x0000000188A39838
		internal JobHandle UpdateBoneWeight(DataChunk mappingChunk, JobHandle jobHandle = default); // 0x0000000188A3925C-0x0000000188A3942C
		public override string ToString(); // 0x0000000188A39044-0x0000000188A3925C
	}

	public class RenderManager : IManager, IValid // TypeDefIndex: 77843
	{
		// Fields
		private Dictionary<int, RenderData> renderDataDict; // 0x10
		private bool isValid; // 0x18
	
		// Constructors
		public RenderManager(); // 0x0000000185E742A0-0x0000000185E74320
	
		// Methods
		public void Initialize(); // 0x0000000185E72990-0x0000000185E72AE0
		public void EnterdEditMode(); // 0x0000000188A3A068-0x0000000188A3A070
		public void Dispose(); // 0x0000000185E72AE0-0x0000000185E730F0
		public bool IsValid(); // 0x000000018225E050-0x000000018225E060
		public int AddRenderer(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referenceUniqueSetupData); // 0x0000000188A39E30-0x0000000188A3A038
		public bool RemoveRenderer(int handle); // 0x0000000188A3A4D8-0x0000000188A3A650
		public RenderData GetRendererData(int handle); // 0x0000000188A3A070-0x0000000188A3A1B4
		public void StartUse(ClothProcess cprocess, int handle); // 0x0000000188A3A650-0x0000000188A3A680
		public void EndUse(ClothProcess cprocess, int handle); // 0x0000000188A3A038-0x0000000188A3A068
		private void PreRenderingUpdate(); // 0x00000001854CF010-0x00000001854CF1B0
		public void InformationLog(StringBuilder allsb); // 0x0000000188A3A1B4-0x0000000188A3A4D8
	}

	public class RenderSetupData : IDisposable, ITransform // TypeDefIndex: 77852
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
		public int TransformCount { get; } // 0x0000000186D358B0-0x0000000186D358F0 
		public bool HasMeshDataArray { get; } // 0x0000000188A3C16C-0x0000000188A3C174 
		public bool HasLocalPositions { get; } // 0x0000000188A3C134-0x0000000188A3C16C 
		public bool HasTangent { get; } // 0x0000000188A3C174-0x0000000188A3C1B8 
	
		// Nested types
		public enum SetupType // TypeDefIndex: 77844
		{
			MeshCloth = 0,
			BoneCloth = 1,
			BoneSpring = 2
		}
	
		public enum BoneConnectionMode // TypeDefIndex: 77845
		{
			Line = 0,
			AutomaticMesh = 1,
			SequentialLoopMesh = 2,
			SequentialNonLoopMesh = 3
		}
	
		[BurstCompile]
		private struct VertexWeight5BoneCheckJob : IJob // TypeDefIndex: 77846
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			[WriteOnly]
			public NativeReference<Define.Result> result; // 0x18
	
			// Methods
			public void Execute(); // 0x0000000188A49394-0x0000000188A4A800
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 77847
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
			public void Execute(int index, TransformAccess transform); // 0x0000000188A44EB4-0x0000000188A451BC
		}
	
		[BurstCompile]
		private struct GetBoneWeightJos : IJob // TypeDefIndex: 77848
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
			public void Execute(); // 0x0000000188A43020-0x0000000188A4312C
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 77849
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
			public bool HasTangent { get; } // 0x0000000188A451BC-0x0000000188A451D0 
	
			// Constructors
			public ShareSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 77851
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
			private sealed class __c__DisplayClass6_0 // TypeDefIndex: 77850
			{
				// Fields
				public HashSet<Transform> transformSet; // 0x10
	
				// Constructors
				public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal void _GetUsedTransform_b__0(Transform x); // 0x0000000188A490F8-0x0000000188A49174
			}
	
			// Constructors
			public UniqueSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A49174-0x0000000188A49244
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A49244-0x0000000188A49394
		}
	
		// Constructors
		public RenderSetupData(); // 0x0000000188A3C0EC-0x0000000188A3C134
		public RenderSetupData(Renderer ren); // 0x0000000188A3B570-0x0000000188A3C0EC
		public RenderSetupData(SetupType setType, Transform renderTransform, List<Transform> rootTransforms, List<Transform> ignoreFromRootBones, List<Transform> collisionBones, BoneConnectionMode connectionMode = BoneConnectionMode.Line /* Metadata: 0x0262A22F */, string name = "(no name)" /* Metadata: 0x0262A230 */); // 0x0000000185B14370-0x0000000185B14EC0
	
		// Methods
		public bool IsSuccess(); // 0x0000000188A3A9F4-0x0000000188A3AA00
		public bool IsFaild(); // 0x0000000187839A28-0x0000000187839A34
		private void ReadTransformInformation(bool includeChilds); // 0x0000000185B17CF0-0x0000000185B19870
		public void Dispose(); // 0x0000000185FF1230-0x0000000185FF1380
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A3A8C0-0x0000000188A3A9F4
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A3AA00-0x0000000188A3AE88
		public Transform GetRendeerTransform(); // 0x0000000188A3A730-0x0000000188A3A780
		public int GetRenderTransformId(); // 0x0000000188A3A780-0x0000000188A3A7D0
		public float4x4 GetRendeerLocalToWorldMatrix(); // 0x0000000186B27D10-0x0000000186B27DD0
		public Transform GetSkinRootTransform(); // 0x0000000188A3A81C-0x0000000188A3A868
		public int GetSkinRootTransformId(); // 0x0000000188A3A7D0-0x0000000188A3A81C
		public int GetTransformIndexFromId(int id); // 0x0000000188A3A868-0x0000000188A3A8C0
		public int GetParentTransformIndex(int index, bool centerExcluded); // 0x0000000185454170-0x00000001854541E0
		public void GetBoneWeightsRun(NativeArray<BoneWeight> weights); // 0x0000000188A3A680-0x0000000188A3A730
		public ShareSerializationData ShareSerialize(); // 0x0000000188A3B164-0x0000000188A3B3E0
		public static RenderSetupData ShareDeserialize(ShareSerializationData sdata); // 0x0000000188A3AE88-0x0000000188A3B164
		public UniqueSerializationData UniqueSerialize(); // 0x0000000188A3B3E0-0x0000000188A3B570
	}

	[BurstCompile]
	internal static class EndSimulationStepJobKernels // TypeDefIndex: 77857
	{
		// Nested types
		public unsafe delegate void EndSimulationStepKernel_000003C4_PostfixBurstDelegate(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // TypeDefIndex: 77853; 0x0000000181256340-0x0000000181256360
	
		internal static class EndSimulationStepKernel_000003C4_BurstDirectCall // TypeDefIndex: 77854
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EndSimulationStepKernel_000003C4_BurstDirectCall(); // 0x00000001823E9300-0x00000001823E9310
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6dbe); // 0x00000001823E7D50-0x00000001823E89B0
			private static IntPtr GetFunctionPointer(); // 0x00000001823E89B0-0x00000001823E8CB0
			public static void Constructor(); // 0x00000001823E74D0-0x00000001823E7D50
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // 0x00000001823E8CB0-0x00000001823E9300
		}
	
		public unsafe delegate void EndSimulationStepRangeKernel_000003C5_PostfixBurstDelegate(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // TypeDefIndex: 77855; 0x0000000181256340-0x0000000181256360
	
		internal static class EndSimulationStepRangeKernel_000003C5_BurstDirectCall // TypeDefIndex: 77856
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EndSimulationStepRangeKernel_000003C5_BurstDirectCall(); // 0x00000001823EBD40-0x00000001823EBD50
	
			// Methods
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr param_000a6dd6); // 0x00000001823EA4C0-0x00000001823EB120
			private static IntPtr GetFunctionPointer(); // 0x00000001823EB120-0x00000001823EB420
			public static void Constructor(); // 0x00000001823E9C40-0x00000001823EA4C0
			public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
			public static unsafe void Invoke(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // 0x00000001823EB420-0x00000001823EBD40
		}
	
		// Methods
		[BurstCompile]
		private static unsafe void EndSimulationStepKernel(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // 0x0000000188A42DBC-0x0000000188A42E38
		[BurstCompile]
		internal static unsafe void EndSimulationStepRangeKernel(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // 0x0000000188A42EC4-0x0000000188A42F40
		[BurstCompile]
		public static unsafe void EndSimulationStepKernel_BurstManaged(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // 0x0000000187233E70-0x0000000187233EC0
		[BurstCompile]
		public static unsafe void EndSimulationStepRangeKernel_BurstManaged(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // 0x0000000188A42E38-0x0000000188A42EC4
	}

	public class ColliderManager : IManager, IValid // TypeDefIndex: 77885
	{
		// Fields
		public ExNativeArray<short> teamIdArray; // 0x10
		public const byte Flag_Valid = 16; // Metadata: 0x0262A241
		public const byte Flag_Enable = 32; // Metadata: 0x0262A242
		public const byte Flag_Reset = 64; // Metadata: 0x0262A243
		public const byte Flag_Reverse = 128; // Metadata: 0x0262A244
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
		public int DataCount { get; } // 0x00000001854CD220-0x00000001854CD230 
		public int ColliderCount { get; } // 0x0000000188A425A0-0x0000000188A425E0 
	
		// Nested types
		[BurstCompile]
		public static class ColliderKernels // TypeDefIndex: 77862
		{
			// Nested types
			public unsafe delegate void PreSimulationUpdateKernel_000003DD_PostfixBurstDelegate(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // TypeDefIndex: 77858; 0x00000001823F40A0-0x00000001823F4180
	
			internal static class PreSimulationUpdateKernel_000003DD_BurstDirectCall // TypeDefIndex: 77859
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateKernel_000003DD_BurstDirectCall(); // 0x00000001823F36F0-0x00000001823F3700
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6e68); // 0x00000001823F2150-0x00000001823F2DB0
				private static IntPtr GetFunctionPointer(); // 0x00000001823F2DB0-0x00000001823F30B0
				public static void Constructor(); // 0x00000001823F18D0-0x00000001823F2150
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // 0x00000001823F30B0-0x00000001823F36F0
			}
	
			public unsafe delegate void PreSimulationUpdateRangeKernel_000003DE_PostfixBurstDelegate(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // TypeDefIndex: 77860; 0x00000001823F40A0-0x00000001823F4180
	
			internal static class PreSimulationUpdateRangeKernel_000003DE_BurstDirectCall // TypeDefIndex: 77861
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateRangeKernel_000003DE_BurstDirectCall(); // 0x00000001823F8F40-0x00000001823F8F50
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6ea4); // 0x00000001823F7550-0x00000001823F81B0
				private static IntPtr GetFunctionPointer(); // 0x00000001823F81B0-0x00000001823F84B0
				public static void Constructor(); // 0x00000001823F6CD0-0x00000001823F7550
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x00000001823F84B0-0x00000001823F8F40
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // 0x0000000188A40F54-0x0000000188A40FD4
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x0000000188A41138-0x0000000188A411B8
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel_BurstManaged(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // 0x0000000188A3E330-0x0000000188A3ECBC
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel_BurstManaged(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // 0x0000000188A40FD4-0x0000000188A41138
		}
	
		[BurstCompile]
		private static class CreateUpdatecolliderListJobKernels // TypeDefIndex: 77867
		{
			// Nested types
			public unsafe delegate void CreateUpdatecolliderListKernel_000003DF_PostfixBurstDelegate(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // TypeDefIndex: 77863; 0x00000001812083C0-0x00000001812083E0
	
			internal static class CreateUpdatecolliderListKernel_000003DF_BurstDirectCall // TypeDefIndex: 77864
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdatecolliderListKernel_000003DF_BurstDirectCall(); // 0x00000001823E40B0-0x00000001823E40C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6eda); // 0x00000001823E2990-0x00000001823E35F0
				private static IntPtr GetFunctionPointer(); // 0x00000001823E35F0-0x00000001823E38F0
				public static void Constructor(); // 0x00000001823E2110-0x00000001823E2990
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // 0x00000001823E38F0-0x00000001823E40B0
			}
	
			public unsafe delegate void CreateUpdatecolliderListRangeKernel_000003E0_PostfixBurstDelegate(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // TypeDefIndex: 77865; 0x00000001812083C0-0x00000001812083E0
	
			internal static class CreateUpdatecolliderListRangeKernel_000003E0_BurstDirectCall // TypeDefIndex: 77866
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdatecolliderListRangeKernel_000003E0_BurstDirectCall(); // 0x00000001823E6BD0-0x00000001823E6BE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6eef); // 0x00000001823E5350-0x00000001823E5FB0
				private static IntPtr GetFunctionPointer(); // 0x00000001823E5FB0-0x00000001823E62B0
				public static void Constructor(); // 0x00000001823E4AD0-0x00000001823E5350
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // 0x00000001823E62B0-0x00000001823E6BD0
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListKernel(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // 0x0000000188A42A18-0x0000000188A42A8C
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListRangeKernel(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // 0x0000000188A42AFC-0x0000000188A42B70
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListKernel_BurstManaged(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // 0x0000000188A42874-0x0000000188A42A18
			[BurstCompile]
			public static unsafe void CreateUpdatecolliderListRangeKernel_BurstManaged(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // 0x0000000188A42A8C-0x0000000188A42AFC
		}
	
		[BurstCompile]
		public static class StartSimulationStepJobKernels // TypeDefIndex: 77872
		{
			// Nested types
			public unsafe delegate void StartSimulationStepKernel_000003E1_PostfixBurstDelegate(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // TypeDefIndex: 77868; 0x000000018239AA50-0x000000018239AB20
	
			internal static class StartSimulationStepKernel_000003E1_BurstDirectCall // TypeDefIndex: 77869
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepKernel_000003E1_BurstDirectCall(); // 0x0000000182400790-0x00000001824007A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6f60); // 0x00000001823FF1F0-0x00000001823FFE50
				private static IntPtr GetFunctionPointer(); // 0x00000001823FFE50-0x0000000182400150
				public static void Constructor(); // 0x00000001823FE970-0x00000001823FF1F0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // 0x0000000182400150-0x0000000182400790
			}
	
			public unsafe delegate void StartSimulationStepRangeKernel_000003E2_PostfixBurstDelegate(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // TypeDefIndex: 77870; 0x000000018239D580-0x000000018239D650
	
			internal static class StartSimulationStepRangeKernel_000003E2_BurstDirectCall // TypeDefIndex: 77871
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepRangeKernel_000003E2_BurstDirectCall(); // 0x0000000182403390-0x00000001824033A0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6f99); // 0x00000001824019B0-0x0000000182402610
				private static IntPtr GetFunctionPointer(); // 0x0000000182402610-0x0000000182402910
				public static void Constructor(); // 0x0000000182401130-0x00000001824019B0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // 0x0000000182402910-0x0000000182403390
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void StartSimulationStepKernel(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // 0x0000000188A472E0-0x0000000188A47360
			[BurstCompile]
			internal static unsafe void StartSimulationStepRangeKernel(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // 0x0000000188A477F8-0x0000000188A47878
			[BurstCompile]
			public static unsafe void StartSimulationStepKernel_BurstManaged(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // 0x0000000188A40034-0x0000000188A40F54
			[BurstCompile]
			public static unsafe void StartSimulationStepRangeKernel_BurstManaged(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // 0x0000000188A473F0-0x0000000188A4751C
		}
	
		[BurstCompile]
		private static class PostSimulationUpdateJobKernels // TypeDefIndex: 77877
		{
			// Nested types
			public unsafe delegate void PostSimulationUpdateKernel_000003E3_PostfixBurstDelegate(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 77873; 0x00000001811C5A40-0x00000001811C5A60
	
			internal static class PostSimulationUpdateKernel_000003E3_BurstDirectCall // TypeDefIndex: 77874
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostSimulationUpdateKernel_000003E3_BurstDirectCall(); // 0x00000001823EE410-0x00000001823EE420
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6fda); // 0x00000001823ECD60-0x00000001823ED9C0
				private static IntPtr GetFunctionPointer(); // 0x00000001823ED9C0-0x00000001823EDCC0
				public static void Constructor(); // 0x00000001823EC4E0-0x00000001823ECD60
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // 0x00000001823EDCC0-0x00000001823EE410
			}
	
			public unsafe delegate void PostSimulationUpdateRangeKernel_000003E4_PostfixBurstDelegate(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 77875; 0x00000001811C5A40-0x00000001811C5A60
	
			internal static class PostSimulationUpdateRangeKernel_000003E4_BurstDirectCall // TypeDefIndex: 77876
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostSimulationUpdateRangeKernel_000003E4_BurstDirectCall(); // 0x00000001823F0FA0-0x00000001823F0FB0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a6ff5); // 0x00000001823EF6F0-0x00000001823F0350
				private static IntPtr GetFunctionPointer(); // 0x00000001823F0350-0x00000001823F0650
				public static void Constructor(); // 0x00000001823EEE70-0x00000001823EF6F0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // 0x00000001823F0650-0x00000001823F0FA0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void PostSimulationUpdateKernel(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // 0x0000000188A43264-0x0000000188A432E0
			[BurstCompile]
			internal static unsafe void PostSimulationUpdateRangeKernel(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // 0x0000000188A43378-0x0000000188A433F4
			[BurstCompile]
			public static unsafe void PostSimulationUpdateKernel_BurstManaged(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // 0x0000000188A4312C-0x0000000188A43264
			[BurstCompile]
			public static unsafe void PostSimulationUpdateRangeKernel_BurstManaged(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // 0x0000000188A432E0-0x0000000188A43378
		}
	
		public enum ColliderType : byte // TypeDefIndex: 77878
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
	
		internal struct WorkData // TypeDefIndex: 77879
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
		private struct PreSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77880
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
			public void SetIndexCount(int indexCount); // 0x0000000185FBF190-0x0000000185FBF1A0
			public void Execute(); // 0x0000000188A44264-0x0000000188A442A8
			public void Execute(int index); // 0x0000000188A442A8-0x0000000188A44C34
			public void UnsafeDo(); // 0x0000000188A44C34-0x0000000188A44EB4
		}
	
		[BurstCompile]
		private struct CreateUpdatecolliderListJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77881
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
			public void SetIndexCount(int indexCount); // 0x0000000185E3C070-0x0000000185E3C080
			public void Execute(); // 0x0000000188A42B70-0x0000000188A42BB0
			public void Execute(int teamId); // 0x0000000188A42BB0-0x0000000188A42D54
			public void UnsafeDo(); // 0x0000000188A42D54-0x0000000188A42DBC
		}
	
		[BurstCompile]
		private struct StartSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77882
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233E00-0x0000000187233E10
			public void Execute(); // 0x0000000188A48060-0x0000000188A480C0
			public void Execute(int index); // 0x0000000188A480C0-0x0000000188A48F10
			public void UnsafeDo(); // 0x0000000188A48F10-0x0000000188A490F8
		}
	
		[BurstCompile]
		private struct EndSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77883
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233F10-0x0000000187233F20
			public void Execute(); // 0x0000000188A42F40-0x0000000188A42F9C
			public void Execute(int index); // 0x0000000187233EC0-0x0000000187233F10
			public void UnsafeDo(); // 0x0000000188A42F9C-0x0000000188A43020
		}
	
		[BurstCompile]
		private struct PostSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77884
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
			public void SetIndexCount(int indexCount); // 0x0000000185FF5E70-0x0000000185FF5F30
			public void Execute(); // 0x0000000188A433F4-0x0000000188A43434
			public void Execute(int index); // 0x0000000188A43434-0x0000000188A43550
			public void UnsafeDo(); // 0x0000000188A43550-0x0000000188A435DC
		}
	
		// Constructors
		public ColliderManager(); // 0x0000000185E743A0-0x0000000185E74420
	
		// Methods
		public void Dispose(); // 0x000000018609BE50-0x000000018609C050
		public void EnterdEditMode(); // 0x0000000188A417CC-0x0000000188A417D4
		public void Initialize(); // 0x000000018609A430-0x000000018609A850
		public bool IsValid(); // 0x000000018226EFC0-0x000000018226EFD0
		public void Register(ClothProcess cprocess); // 0x0000000185B1A290-0x0000000185B1A5E0
		public void Exit(ClothProcess cprocess); // 0x00000001859F3510-0x00000001859F3C30
		internal void InitColliders(ClothProcess cprocess); // 0x00000001859F4BD0-0x00000001859F4DC0
		internal void UpdateColliders(ClothProcess cprocess); // 0x00000001859F48E0-0x00000001859F4BD0
		private void AddCollider(ClothProcess cprocess, ColliderComponent col); // 0x0000000188A411B8-0x0000000188A417CC
		internal void RemoveCollider(ColliderComponent col, int teamId); // 0x00000001859F2CC0-0x00000001859F32B0
		private void AddColliderInternal(ClothProcess cprocess, ColliderComponent col, int index, int arrayIndex, int transformIndex); // 0x0000000185B1B690-0x0000000185B1BB90
		internal void EnableCollider(ColliderComponent col, int teamId, bool sw); // 0x00000001859F32B0-0x00000001859F3450
		internal void EnableTeamCollider(int teamId); // 0x0000000185B1B510-0x0000000185B1B690
		internal void UpdateParameters(ColliderComponent col, int teamId); // 0x0000000188A42334-0x0000000188A425A0
		internal JobHandle PreSimulationUpdate(JobHandle jobHandle); // 0x00000001854D0680-0x00000001854D0B30
		internal JobHandle CreateUpdateColliderList(int updateIndex, JobHandle jobHandle); // 0x00000001854D47E0-0x00000001854D4A60
		internal JobHandle StartSimulationStep(JobHandle jobHandle); // 0x00000001854D3570-0x00000001854D39D0
		internal JobHandle EndSimulationStep(JobHandle jobHandle); // 0x00000001854D4520-0x00000001854D47E0
		internal JobHandle PostSimulationUpdate(JobHandle jobHandle); // 0x00000001854D0390-0x00000001854D0680
		public void InformationLog(StringBuilder allsb); // 0x0000000188A417D4-0x0000000188A42334
		public static void Initialize_CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003DF_BurstDirectCall(); // 0x00000001823DBC60-0x00000001823DBF60
		public static void Initialize_CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003E0_BurstDirectCall(); // 0x00000001823DBF60-0x00000001823DC260
		public static void Initialize_PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003E3_BurstDirectCall(); // 0x00000001823DC260-0x00000001823DC560
		public static void Initialize_PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003E4_BurstDirectCall(); // 0x00000001823DC560-0x00000001823DC860
	}

	public class SimulationManager : IManager, IValid // TypeDefIndex: 77934
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
		public int ParticleCount { get; } // 0x00000001854CD780-0x00000001854CD790 
		internal int SimulationStepCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233F30-0x0000000187233F40 0x0000000187233F40-0x0000000187233F50
		internal int WorkerCount { get; } // 0x0000000187834DD4-0x0000000187834DE0 
	
		// Nested types
		[BurstCompile]
		public static class CreateUpdateParticleListKernels // TypeDefIndex: 77890
		{
			// Nested types
			public unsafe delegate void CreateUpdateParticleListKernel_0000040D_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // TypeDefIndex: 77886; 0x00000001823DF230-0x00000001823DF340
	
			internal static class CreateUpdateParticleListKernel_0000040D_BurstDirectCall // TypeDefIndex: 77887
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdateParticleListKernel_0000040D_BurstDirectCall(); // 0x00000001823DE860-0x00000001823DE870
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a709b); // 0x00000001823DD0E0-0x00000001823DDD40
				private static IntPtr GetFunctionPointer(); // 0x00000001823DDD40-0x00000001823DE040
				public static void Constructor(); // 0x00000001823DC860-0x00000001823DD0E0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // 0x00000001823DE040-0x00000001823DE860
			}
	
			public unsafe delegate void CreateUpdateParticleListRangeKernel_0000040E_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // TypeDefIndex: 77888; 0x00000001823DF230-0x00000001823DF340
	
			internal static class CreateUpdateParticleListRangeKernel_0000040E_BurstDirectCall // TypeDefIndex: 77889
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdateParticleListRangeKernel_0000040E_BurstDirectCall(); // 0x00000001823E1740-0x00000001823E1750
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a70e0); // 0x00000001823DFCF0-0x00000001823E0950
				private static IntPtr GetFunctionPointer(); // 0x00000001823E0950-0x00000001823E0C50
				public static void Constructor(); // 0x00000001823DF470-0x00000001823DFCF0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // 0x00000001823E0C50-0x00000001823E1740
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListKernel(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // 0x0000000188A425E0-0x0000000188A42660
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListRangeKernel(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // 0x0000000188A427F4-0x0000000188A42874
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListKernel_BurstManaged(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // 0x0000000188A3ECBC-0x0000000188A3F20C
			[BurstCompile]
			public static unsafe void CreateUpdateParticleListRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // 0x0000000188A42660-0x0000000188A427F4
		}
	
		[BurstCompile]
		public static class PreSimulationUpdateJobKernels // TypeDefIndex: 77895
		{
			// Nested types
			public unsafe delegate void PreSimulationUpdateKernel_0000040F_PostfixBurstDelegate(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // TypeDefIndex: 77891; 0x00000001823F6AA0-0x00000001823F6BA0
	
			internal static class PreSimulationUpdateKernel_0000040F_BurstDirectCall // TypeDefIndex: 77892
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateKernel_0000040F_BurstDirectCall(); // 0x00000001823F60D0-0x00000001823F60E0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a7173); // 0x00000001823F4B30-0x00000001823F5790
				private static IntPtr GetFunctionPointer(); // 0x00000001823F5790-0x00000001823F5A90
				public static void Constructor(); // 0x00000001823F42B0-0x00000001823F4B30
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // 0x00000001823F5A90-0x00000001823F60D0
			}
	
			public unsafe delegate void PreSimulationUpdateRangeKernel_00000410_PostfixBurstDelegate(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // TypeDefIndex: 77893; 0x00000001823F6AA0-0x00000001823F6BA0
	
			internal static class PreSimulationUpdateRangeKernel_00000410_BurstDirectCall // TypeDefIndex: 77894
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateRangeKernel_00000410_BurstDirectCall(); // 0x00000001823FBBA0-0x00000001823FBBB0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a71b5); // 0x00000001823FA170-0x00000001823FADD0
				private static IntPtr GetFunctionPointer(); // 0x00000001823FADD0-0x00000001823FB0D0
				public static void Constructor(); // 0x00000001823F98F0-0x00000001823FA170
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // 0x00000001823FB0D0-0x00000001823FBBA0
			}
	
			// Methods
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // 0x0000000188A43FE0-0x0000000188A44060
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // 0x0000000188A441E4-0x0000000188A44264
			[BurstCompile]
			public static unsafe void PreSimulationUpdateKernel_BurstManaged(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // 0x0000000188A435DC-0x0000000188A43FE0
			[BurstCompile]
			public static unsafe void PreSimulationUpdateRangeKernel_BurstManaged(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // 0x0000000188A44060-0x0000000188A441E4
		}
	
		[BurstCompile]
		private static class StartSimulationStepJobKernels // TypeDefIndex: 77906
		{
			// Nested types
			public unsafe delegate void StartSimulationStepKernel_00000411_PostfixBurstDelegate(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // TypeDefIndex: 77896; 0x0000000182417150-0x00000001824172D0
	
			internal static class StartSimulationStepKernel_00000411_BurstDirectCall // TypeDefIndex: 77897
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepKernel_00000411_BurstDirectCall(); // 0x0000000182416410-0x0000000182416420
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a72ad); // 0x0000000182414B80-0x00000001824157E0
				private static IntPtr GetFunctionPointer(); // 0x00000001824157E0-0x0000000182415AE0
				public static void Constructor(); // 0x0000000182414300-0x0000000182414B80
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000182415AE0-0x0000000182416410
			}
	
			public unsafe delegate void StartSimulationStepRangeKernel_00000412_PostfixBurstDelegate(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // TypeDefIndex: 77898; 0x000000018241A290-0x000000018241A410
	
			internal static class StartSimulationStepRangeKernel_00000412_BurstDirectCall // TypeDefIndex: 77899
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepRangeKernel_00000412_BurstDirectCall(); // 0x0000000182419820-0x0000000182419830
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a730a); // 0x0000000182417C70-0x00000001824188D0
				private static IntPtr GetFunctionPointer(); // 0x00000001824188D0-0x0000000182418BD0
				public static void Constructor(); // 0x00000001824173F0-0x0000000182417C70
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x0000000182418BD0-0x0000000182419820
			}
	
			public delegate void Spring_00000413_PostfixBurstDelegate([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // TypeDefIndex: 77900; 0x00000001811C5A40-0x00000001811C5A60
	
			internal static class Spring_00000413_BurstDirectCall // TypeDefIndex: 77901
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Spring_00000413_BurstDirectCall(); // 0x0000000182412EA0-0x0000000182412EB0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a733b); // 0x0000000182411920-0x0000000182412580
				private static IntPtr GetFunctionPointer(); // 0x0000000182412580-0x0000000182412880
				public static void Constructor(); // 0x00000001824110A0-0x0000000182411920
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static void Invoke([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // 0x0000000182412880-0x0000000182412EA0
			}
	
			public unsafe delegate void Wind_00000414_PostfixBurstDelegate(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // TypeDefIndex: 77902; 0x0000000182425000-0x0000000182425090
	
			internal static class Wind_00000414_BurstDirectCall // TypeDefIndex: 77903
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Wind_00000414_BurstDirectCall(); // 0x0000000182423E20-0x0000000182423E30
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a7360); // 0x00000001824227D0-0x0000000182423430
				private static IntPtr GetFunctionPointer(); // 0x0000000182423430-0x0000000182423730
				public static void Constructor(); // 0x0000000182421F50-0x00000001824227D0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // 0x0000000182423730-0x0000000182423E20
			}
	
			public delegate void WindForceBlend_00000415_PostfixBurstDelegate([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // TypeDefIndex: 77904; 0x00000001812083C0-0x00000001812083E0
	
			internal static class WindForceBlend_00000415_BurstDirectCall // TypeDefIndex: 77905
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WindForceBlend_00000415_BurstDirectCall(); // 0x0000000182420D00-0x0000000182420D10
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a737c); // 0x000000018241F770-0x00000001824203D0
				private static IntPtr GetFunctionPointer(); // 0x00000001824203D0-0x00000001824206D0
				public static void Constructor(); // 0x000000018241EEF0-0x000000018241F770
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static void Invoke([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // 0x00000001824206D0-0x0000000182420D00
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void StartSimulationStepKernel(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000188A47360-0x0000000188A473F0
			[BurstCompile]
			internal static unsafe void StartSimulationStepRangeKernel(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x0000000188A47768-0x0000000188A477F8
			[BurstCompile]
			private static void Spring([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // 0x0000000188A463B8-0x0000000188A46430
			[BurstCompile]
			private static unsafe void Wind(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // 0x0000000188A47FE8-0x0000000188A48060
			[BurstCompile]
			private static void WindForceBlend([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // 0x0000000188A47B90-0x0000000188A47C08
			[BurstCompile]
			public static unsafe void StartSimulationStepKernel_BurstManaged(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000188A46430-0x0000000188A472E0
			[BurstCompile]
			public static unsafe void StartSimulationStepRangeKernel_BurstManaged(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x0000000188A4751C-0x0000000188A47768
			[BurstCompile]
			public static void Spring_BurstManaged([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, double scaleRatio); // 0x0000000188A45EB4-0x0000000188A463B8
			[BurstCompile]
			public static unsafe void Wind_BurstManaged(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // 0x0000000188A47C08-0x0000000188A47FE8
			[BurstCompile]
			public static void WindForceBlend_BurstManaged([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // 0x0000000188A47878-0x0000000188A47B90
		}
	
		[BurstCompile]
		private static class UpdateStepBasicPotureJobKernels // TypeDefIndex: 77911
		{
			// Nested types
			public unsafe delegate void UpdateStepBasicPotureKernel_00000416_PostfixBurstDelegate(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // TypeDefIndex: 77907; 0x00000001823A52D0-0x00000001823A5380
	
			internal static class UpdateStepBasicPotureKernel_00000416_BurstDirectCall // TypeDefIndex: 77908
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateStepBasicPotureKernel_00000416_BurstDirectCall(); // 0x000000018241C350-0x000000018241C360
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a73db); // 0x000000018241ADB0-0x000000018241BA10
				private static IntPtr GetFunctionPointer(); // 0x000000018241BA10-0x000000018241BD10
				public static void Constructor(); // 0x000000018241A530-0x000000018241ADB0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x000000018241BD10-0x000000018241C350
			}
	
			public unsafe delegate void UpdateStepBasicPotureRangeKernel_00000417_PostfixBurstDelegate(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // TypeDefIndex: 77909; 0x00000001823A7D60-0x00000001823A7E10
	
			internal static class UpdateStepBasicPotureRangeKernel_00000417_BurstDirectCall // TypeDefIndex: 77910
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateStepBasicPotureRangeKernel_00000417_BurstDirectCall(); // 0x000000018241EEE0-0x000000018241EEF0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a740b); // 0x000000018241D550-0x000000018241E1B0
				private static IntPtr GetFunctionPointer(); // 0x000000018241E1B0-0x000000018241E4B0
				public static void Constructor(); // 0x000000018241CCD0-0x000000018241D550
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x000000018241E4B0-0x000000018241EEE0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void UpdateStepBasicPotureKernel(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000188A5A8AC-0x0000000188A5A92C
			[BurstCompile]
			internal static unsafe void UpdateStepBasicPotureRangeKernel(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x0000000188A5AA2C-0x0000000188A5AAAC
			[BurstCompile]
			public static unsafe void UpdateStepBasicPotureKernel_BurstManaged(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // 0x0000000188A59FE8-0x0000000188A5A8AC
			[BurstCompile]
			public static unsafe void UpdateStepBasicPotureRangeKernel_BurstManaged(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // 0x0000000188A5A92C-0x0000000188A5AA2C
		}
	
		[BurstCompile]
		private static class EndSimulationStepJobKernels // TypeDefIndex: 77916
		{
			// Nested types
			public unsafe delegate void EndSimulationStepKernel_00000418_PostfixBurstDelegate(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // TypeDefIndex: 77912; 0x000000018240E0B0-0x000000018240E180
	
			internal static class EndSimulationStepKernel_00000418_BurstDirectCall // TypeDefIndex: 77913
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EndSimulationStepKernel_00000418_BurstDirectCall(); // 0x000000018240D460-0x000000018240D470
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a7485); // 0x000000018240BD70-0x000000018240C9D0
				private static IntPtr GetFunctionPointer(); // 0x000000018240C9D0-0x000000018240CCD0
				public static void Constructor(); // 0x000000018240B4F0-0x000000018240BD70
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // 0x000000018240CCD0-0x000000018240D460
			}
	
			public unsafe delegate void EndSimulationStepRangeKernel_00000419_PostfixBurstDelegate(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // TypeDefIndex: 77914; 0x0000000182410EB0-0x0000000182410F80
	
			internal static class EndSimulationStepRangeKernel_00000419_BurstDirectCall // TypeDefIndex: 77915
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EndSimulationStepRangeKernel_00000419_BurstDirectCall(); // 0x0000000182410520-0x0000000182410530
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a74be); // 0x000000018240EB20-0x000000018240F780
				private static IntPtr GetFunctionPointer(); // 0x000000018240F780-0x000000018240FA80
				public static void Constructor(); // 0x000000018240E2A0-0x000000018240EB20
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x000000018240FA80-0x0000000182410520
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void EndSimulationStepKernel(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // 0x0000000188A50D84-0x0000000188A50E08
			[BurstCompile]
			internal static unsafe void EndSimulationStepRangeKernel(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x0000000188A50F3C-0x0000000188A50FC0
			[BurstCompile]
			public static unsafe void EndSimulationStepKernel_BurstManaged(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // 0x0000000188A4FFCC-0x0000000188A50D84
			[BurstCompile]
			public static unsafe void EndSimulationStepRangeKernel_BurstManaged(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // 0x0000000188A50E08-0x0000000188A50F3C
		}
	
		[BurstCompile]
		private static class CalcDisplayPositionJobKernels // TypeDefIndex: 77921
		{
			// Nested types
			public unsafe delegate void CalcDisplayPositionKernel_0000041A_PostfixBurstDelegate(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // TypeDefIndex: 77917; 0x0000000182405EC0-0x0000000182405F60
	
			internal static class CalcDisplayPositionKernel_0000041A_BurstDirectCall // TypeDefIndex: 77918
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcDisplayPositionKernel_0000041A_BurstDirectCall(); // 0x00000001824052A0-0x00000001824052B0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a7523); // 0x0000000182403C20-0x0000000182404880
				private static IntPtr GetFunctionPointer(); // 0x0000000182404880-0x0000000182404B80
				public static void Constructor(); // 0x00000001824033A0-0x0000000182403C20
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // 0x0000000182404B80-0x00000001824052A0
			}
	
			public unsafe delegate void CalcDisplayPositionRangeKernel_0000041B_PostfixBurstDelegate(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // TypeDefIndex: 77919; 0x0000000182405EC0-0x0000000182405F60
	
			internal static class CalcDisplayPositionRangeKernel_0000041B_BurstDirectCall // TypeDefIndex: 77920
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcDisplayPositionRangeKernel_0000041B_BurstDirectCall(); // 0x0000000182408280-0x0000000182408290
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a7550); // 0x0000000182406900-0x0000000182407560
				private static IntPtr GetFunctionPointer(); // 0x0000000182407560-0x0000000182407860
				public static void Constructor(); // 0x0000000182406080-0x0000000182406900
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // 0x0000000182407860-0x0000000182408280
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void CalcDisplayPositionKernel(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // 0x0000000188A4EBCC-0x0000000188A4EC50
			[BurstCompile]
			internal static unsafe void CalcDisplayPositionRangeKernel(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // 0x0000000188A4ED48-0x0000000188A4EDCC
			[BurstCompile]
			public static unsafe void CalcDisplayPositionKernel_BurstManaged(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // 0x0000000188A4E578-0x0000000188A4EBCC
			[BurstCompile]
			public static unsafe void CalcDisplayPositionRangeKernel_BurstManaged(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // 0x0000000188A4EC50-0x0000000188A4ED48
		}
	
		[BurstCompile]
		private static class ClearStepCounterKernels // TypeDefIndex: 77924
		{
			// Nested types
			public unsafe delegate void ClearStepCounterKernel_0000041C_PostfixBurstDelegate(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // TypeDefIndex: 77922; 0x000000018240B340-0x000000018240B3C0
	
			internal static class ClearStepCounterKernel_0000041C_BurstDirectCall // TypeDefIndex: 77923
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearStepCounterKernel_0000041C_BurstDirectCall(); // 0x000000018240ACD0-0x000000018240ACE0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a758b); // 0x0000000182409720-0x000000018240A380
				private static IntPtr GetFunctionPointer(); // 0x000000018240A380-0x000000018240A680
				public static void Constructor(); // 0x0000000182408EA0-0x0000000182409720
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // 0x000000018240A680-0x000000018240ACD0
			}
	
			// Methods
			[BurstCompile]
			internal static unsafe void ClearStepCounterKernel(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // 0x0000000188A4F584-0x0000000188A4F600
			[BurstCompile]
			public static unsafe void ClearStepCounterKernel_BurstManaged(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // 0x0000000187233F50-0x0000000187233F90
		}
	
		[BurstCompile]
		private struct PreSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77925
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
			public void SetIndexCount(int indexCount); // 0x0000000185F5BC70-0x0000000185F5BC80
			public void Execute(); // 0x0000000188A52F24-0x0000000188A52F68
			public void Execute(int pindex); // 0x0000000188A52528-0x0000000188A52F24
			public void UnsafeDo(); // 0x0000000188A52F68-0x0000000188A53230
		}
	
		[BurstCompile]
		private struct ClearStepCounter : IJob, IUnsafeJob // TypeDefIndex: 77926
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
			public void Execute(); // 0x0000000188A4F600-0x0000000188A4F694
			public void UnsafeDo(); // 0x0000000188A4F694-0x0000000188A4F758
		}
	
		[BurstCompile]
		private struct CreateUpdateParticleList : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77927
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
			public void SetIndexCount(int indexCount); // 0x0000000185D8E610-0x0000000185D8E620
			public void Execute(); // 0x0000000188A4F758-0x0000000188A4F79C
			public void Execute(int teamId); // 0x0000000188A4F79C-0x0000000188A4FD00
			public void UnsafeDo(); // 0x0000000188A4FD00-0x0000000188A4FFCC
		}
	
		[BurstCompile]
		private struct StartSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77928
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233FD0-0x0000000187233FE0
			public void Execute(); // 0x0000000188A54710-0x0000000188A54770
			public void Execute(int index); // 0x0000000188A538D8-0x0000000188A54710
			private void Spring([IsReadOnly] in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, [IsReadOnly] in double3 basePos, [IsReadOnly] in quaternion baseRot, double noiseTime, float scaleRatio); // 0x0000000188A54770-0x0000000188A54C94
			private void Wind(int teamId, [IsReadOnly] in TeamManager.TeamData tdata, [IsReadOnly] in WindParams windParams, [IsReadOnly] in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, ref float3 result); // 0x0000000188A553D8-0x0000000188A557B0
			private void WindForceBlend([IsReadOnly] in TeamWindInfo windInfo, [IsReadOnly] in WindParams windParams, [IsReadOnly] in float3 windPos, float windTurbulence, ref float3 result); // 0x0000000188A550CC-0x0000000188A553D8
			public void UnsafeDo(); // 0x0000000188A54C94-0x0000000188A550CC
		}
	
		[BurstCompile]
		private struct UpdateStepBasicPotureJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77929
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233B40-0x0000000187233B50
			public void Execute(); // 0x0000000188A5AAAC-0x0000000188A5AB0C
			public void Execute(int index); // 0x0000000188A5AB0C-0x0000000188A5B3FC
			public void UnsafeDo(); // 0x0000000188A5B3FC-0x0000000188A5B578
		}
	
		[BurstCompile]
		private struct EndSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 77930
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187233F90-0x0000000187233FA0
			public void Execute(); // 0x0000000188A51D98-0x0000000188A51DF8
			public void Execute(int index); // 0x0000000188A50FC0-0x0000000188A51D98
			public void UnsafeDo(); // 0x0000000188A51DF8-0x0000000188A51FDC
		}
	
		[BurstCompile]
		private struct CalcDisplayPositionJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 77931
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
			public void SetIndexCount(int indexCount); // 0x0000000185FC1900-0x0000000185FC1910
			public void Execute(); // 0x0000000188A4EDCC-0x0000000188A4EE10
			public void Execute(int pindex); // 0x0000000188A4EE10-0x0000000188A4F44C
			public void UnsafeDo(); // 0x0000000188A4F44C-0x0000000188A4F584
		}
	
		[BurstCompile]
		private struct FeedbackTempPosJob : IJobParallelForDefer // TypeDefIndex: 77932
		{
			// Fields
			[ReadOnly]
			public NativeList<int> jobParticleIndexList; // 0x00
			[ReadOnly]
			public NativeArray<double3> tempFloat3Buffer; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x20
	
			// Methods
			public void Execute(int index); // 0x0000000188A51FDC-0x0000000188A5204C
		}
	
		[BurstCompile]
		private struct FeedbackTempPosJob2 : IJobParallelForDefer // TypeDefIndex: 77933
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> particleIndexArray; // 0x00
			[ReadOnly]
			public NativeArray<double3> tempFloat3Buffer; // 0x10
			[NativeDisableParallelForRestriction]
			public NativeArray<double3> nextPosArray; // 0x20
	
			// Methods
			public void Execute(int index); // 0x0000000187233FA0-0x0000000187233FD0
		}
	
		// Constructors
		public SimulationManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x000000018609B4C0-0x000000018609B950
		public void EnterdEditMode(); // 0x0000000188A451D0-0x0000000188A451D8
		public void Initialize(); // 0x000000018609A850-0x000000018609B4C0
		public bool IsValid(); // 0x0000000187233F20-0x0000000187233F30
		internal void RegisterProxyMesh(ClothProcess cprocess); // 0x0000000185B1A5E0-0x0000000185B1A890
		internal void RegisterConstraint(ClothProcess cprocess); // 0x0000000185B93960-0x0000000185B93BA0
		internal void ExitProxyMesh(ClothProcess cprocess); // 0x00000001859F3C30-0x00000001859F3F40
		internal void WorkBufferUpdate(); // 0x00000001854D17E0-0x00000001854D2110
		internal JobHandle PreSimulationUpdate(JobHandle jobHandle); // 0x00000001854CD230-0x00000001854CD780
		internal JobHandle SimulationStepUpdate(int updateCount, int updateIndex, JobHandle jobHandle); // 0x00000001854D4D70-0x00000001854D6AA0
		internal JobHandle CalcDisplayPosition(JobHandle jobHandle); // 0x00000001854CD790-0x00000001854CDBE0
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in NativeList<int> particleList, JobHandle jobHandle); // 0x0000000188A451D8-0x0000000188A452C8
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in ExProcessingList<int> processingList, JobHandle jobHandle); // 0x0000000188A453C4-0x0000000188A45418
		internal JobHandle FeedbackTempFloat3Buffer([IsReadOnly] in NativeArray<int> particleArray, [IsReadOnly] in NativeReference<int> counter, JobHandle jobHandle); // 0x0000000188A452C8-0x0000000188A453C4
		public void InformationLog(StringBuilder allsb); // 0x0000000188A45418-0x0000000188A45EB4
		public static void Initialize_StartSimulationStepJobKernels_StartSimulationStepKernel_00000411_BurstDirectCall(); // 0x00000001823FD770-0x00000001823FDA70
		public static void Initialize_StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000412_BurstDirectCall(); // 0x00000001823FDA70-0x00000001823FDD70
		public static void Initialize_StartSimulationStepJobKernels_Spring_00000413_BurstDirectCall(); // 0x00000001823FD470-0x00000001823FD770
		public static void Initialize_StartSimulationStepJobKernels_Wind_00000414_BurstDirectCall(); // 0x00000001823FE070-0x00000001823FE370
		public static void Initialize_StartSimulationStepJobKernels_WindForceBlend_00000415_BurstDirectCall(); // 0x00000001823FDD70-0x00000001823FE070
		public static void Initialize_UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_00000416_BurstDirectCall(); // 0x00000001823FE370-0x00000001823FE670
		public static void Initialize_UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_00000417_BurstDirectCall(); // 0x00000001823FE670-0x00000001823FE970
		public static void Initialize_EndSimulationStepJobKernels_EndSimulationStepKernel_00000418_BurstDirectCall(); // 0x00000001823FCE70-0x00000001823FD170
		public static void Initialize_EndSimulationStepJobKernels_EndSimulationStepRangeKernel_00000419_BurstDirectCall(); // 0x00000001823FD170-0x00000001823FD470
		public static void Initialize_CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_0000041A_BurstDirectCall(); // 0x00000001823FC570-0x00000001823FC870
		public static void Initialize_CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_0000041B_BurstDirectCall(); // 0x00000001823FC870-0x00000001823FCB70
		public static void Initialize_ClearStepCounterKernels_ClearStepCounterKernel_0000041C_BurstDirectCall(); // 0x00000001823FCB70-0x00000001823FCE70
	}

	public class TimeManager : IManager, IValid // TypeDefIndex: 77936
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
		internal int FixedUpdateCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226A850-0x000000018226A860 0x0000000186036460-0x0000000186036470
		internal float SimulationDeltaTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
		internal float MaxDeltaTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233330-0x0000000187233340 0x0000000187233340-0x0000000187233350
		internal float4 SimulationPower { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187234010-0x0000000187234020 0x0000000187234020-0x0000000187234030
		internal static float DeltaTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000188A560FC-0x0000000188A56134 0x0000000188A561DC-0x0000000188A56220
		internal static float FixedDeltaTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000188A5616C-0x0000000188A561A4 0x0000000188A5625C-0x0000000188A562A4
		internal static float UnscaledDeltaTime { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000188A561A4-0x0000000188A561DC 0x0000000188A562A4-0x0000000188A562EC
		internal static bool EnableAOVMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000188A56134-0x0000000188A5616C 0x0000000188A56220-0x0000000188A5625C
	
		// Nested types
		public enum UpdateLocation // TypeDefIndex: 77935
		{
			AfterLateUpdate = 0,
			BeforeLateUpdate = 1
		}
	
		// Constructors
		public TimeManager(); // 0x0000000187233FF0-0x0000000187234010
	
		// Methods
		public void Dispose(); // 0x0000000188A55C70-0x0000000188A55E78
		public void EnterdEditMode(); // 0x0000000188A55E78-0x0000000188A55E80
		public void Initialize(); // 0x0000000185E739B0-0x0000000185E73BE0
		public bool IsValid(); // 0x000000018226EB80-0x000000018226EB90
		private void AfterFixedUpdate(); // 0x0000000187233FE0-0x0000000187233FF0
		private void AfterRenderring(); // 0x00000001872327A0-0x00000001872327B0
		public static float GetDeltaTime(); // 0x00000001851515D0-0x0000000185151640
		public static float GetFixedDeltaTime(); // 0x0000000185151640-0x0000000185151670
		public static float GetUnscaledDeltaTime(); // 0x00000001851515A0-0x00000001851515D0
		internal void FrameUpdate(); // 0x00000001853F5670-0x00000001853F5FD0
		public void InformationLog(StringBuilder allsb); // 0x0000000188A55E80-0x0000000188A560FC
	}

	public class WindManager : IManager, IValid // TypeDefIndex: 77938
	{
		// Fields
		public const int Flag_Valid = 0; // Metadata: 0x0262A251
		public const int Flag_Enable = 1; // Metadata: 0x0262A252
		public const int Flag_Addition = 2; // Metadata: 0x0262A253
		public ExNativeArray<WindData> windDataArray; // 0x10
		private bool isValid; // 0x18
		private Dictionary<int, BeyondBoneWindZone> windZoneDict; // 0x20
	
		// Properties
		public int WindCount { get; } // 0x00000001854CD220-0x00000001854CD230 
	
		// Nested types
		public struct WindData // TypeDefIndex: 77937
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
			public bool IsValid(); // 0x000000018783988C-0x0000000187839894
			public bool IsEnable(); // 0x0000000188A5B578-0x0000000188A5B580
			public bool IsAddition(); // 0x0000000188A29B88-0x0000000188A29B90
		}
	
		// Constructors
		public WindManager(); // 0x0000000185E74320-0x0000000185E743A0
	
		// Methods
		public void Dispose(); // 0x0000000185E741E0-0x0000000185E74220
		public void EnterdEditMode(); // 0x0000000188A5B6EC-0x0000000188A5B6F4
		public void Initialize(); // 0x0000000185E74150-0x0000000185E741E0
		public bool IsValid(); // 0x000000018225E050-0x000000018225E060
		public int AddWind(BeyondBoneWindZone windZone); // 0x0000000188A5B580-0x0000000188A5B6EC
		public void RemoveWind(int windId); // 0x0000000188A5BA0C-0x0000000188A5BB58
		public void SetEnable(int windId, bool sw); // 0x0000000188A5BB58-0x0000000188A5BF60
		internal void AlwaysWindUpdate(); // 0x00000001860106D0-0x0000000186010C30
		public void InformationLog(StringBuilder allsb); // 0x0000000188A5B6F4-0x0000000188A5BA0C
	}

	[Serializable]
	public class BeyondBoneClothSavePoint // TypeDefIndex: 77939
	{
		// Fields
		public BeyondBoneClothSavePoint_TeamManagerTeamData teamManagerTeamData; // 0x10
		public BeyondBoneClothSavePoint_ColliderManagerData colliderManagerData; // 0x18
		public BeyondBoneClothSavePoint_SimulationManagerData simulationManagerData; // 0x20
		public BeyondBoneClothSavePoint_VirtualMeshManagerData virtualMeshManagerData; // 0x28
		public BeyondBoneClothSavePoint_InertiaConstraintCenterData inertiaConstraintCenterData; // 0x30
	
		// Constructors
		public BeyondBoneClothSavePoint(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Load(ClothProcess cprocess, ColliderManager colliderManager, SimulationManager simulationManager, VirtualMeshManager virtualMeshManager, TeamManager teamManager); // 0x0000000188A4D240-0x0000000188A4D414
		public void LoadTeamManagerTeamData(ref TeamManager.TeamData teamData); // 0x0000000188A4D118-0x0000000188A4D14C
		public void LoadColliderManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, ColliderManager colliderManager); // 0x0000000188A4C9C4-0x0000000188A4CB90
		public void LoadSimulationManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, SimulationManager simulationManager); // 0x0000000188A4CE24-0x0000000188A4D118
		public void LoadVirtualMeshManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, VirtualMeshManager virtualMeshManager); // 0x0000000188A4D14C-0x0000000188A4D240
		public void LoadInertiaConstraintCenterData(ClothProcess cprocess, TeamManager teamManager); // 0x0000000188A4CB90-0x0000000188A4CE24
		public void Save(ClothProcess cprocess, ColliderManager colliderManager, SimulationManager simulationManager, VirtualMeshManager virtualMeshManager, TeamManager teamManager); // 0x0000000188A4E494-0x0000000188A4E578
		public void SaveTeamManagerTeamData(ref TeamManager.TeamData teamData); // 0x0000000188A4E218-0x0000000188A4E2A0
		public void SaveColliderManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, ColliderManager colliderManager); // 0x0000000188A4D414-0x0000000188A4D7EC
		public void SaveSimulationManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, SimulationManager simulationManager); // 0x0000000188A4DB98-0x0000000188A4E218
		public void SaveVirtualMeshManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, VirtualMeshManager virtualMeshManager); // 0x0000000188A4E2A0-0x0000000188A4E494
		public void SaveInertiaConstraintCenterData(ClothProcess cprocess, TeamManager teamManager); // 0x0000000188A4D7EC-0x0000000188A4DB98
	}

	internal static class BeyondBoneClothSavePointHelper // TypeDefIndex: 77940
	{
		// Extension methods
		internal static void AddFromNative<T>(this List<T> targetList, NativeArray<T> sourceArray, int sourceStartIndex, int length)
			where T : struct;
		internal static void FillFromList<T>(this NativeArray<T> targetArray, int targetStartIndex, List<T> sourceList, int sourceStartIndex, int length)
			where T : struct;
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_TeamManagerTeamData // TypeDefIndex: 77941
	{
		// Fields
		public float velocityWeight; // 0x10
		public float blendWeight; // 0x14
	
		// Constructors
		public BeyondBoneClothSavePoint_TeamManagerTeamData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_ColliderManagerData // TypeDefIndex: 77942
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
		public BeyondBoneClothSavePoint_ColliderManagerData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_SimulationManagerData // TypeDefIndex: 77943
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
		public BeyondBoneClothSavePoint_SimulationManagerData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_VirtualMeshManagerData // TypeDefIndex: 77944
	{
		// Fields
		public int proxyMeshVertexCount; // 0x10
		public List<double3> positions; // 0x18
		public List<quaternion> rotations; // 0x20
	
		// Constructors
		public BeyondBoneClothSavePoint_VirtualMeshManagerData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_InertiaConstraintCenterData // TypeDefIndex: 77945
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
		public BeyondBoneClothSavePoint_InertiaConstraintCenterData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public struct TeamWindInfo : IValid // TypeDefIndex: 77946
	{
		// Fields
		public int windId; // 0x00
		public float time; // 0x04
		public float main; // 0x08
		public float3 direction; // 0x0C
	
		// Methods
		public bool IsValid(); // 0x0000000188A55AD8-0x0000000188A55AE8
		public override string ToString(); // 0x0000000188A55AE8-0x0000000188A55C70
		public void DebugLog(); // 0x0000000188A55A88-0x0000000188A55AD8
	}

	public struct TeamWindData // TypeDefIndex: 77947
	{
		// Fields
		public FixedList128Bytes<TeamWindInfo> windZoneList; // 0x00
		public TeamWindInfo movingWind; // 0x80
	
		// Properties
		public int ZoneCount { get; } // 0x0000000188A55A54-0x0000000188A55A88 
	
		// Methods
		public int IndexOf(int windId); // 0x0000000188A55974-0x0000000188A559FC
		public void ClearZoneList(); // 0x0000000188A55934-0x0000000188A55974
		public void AddOrReplaceWindZone(TeamWindInfo windInfo, [IsReadOnly] in TeamWindData oldWindData); // 0x0000000188A557B0-0x0000000188A55934
		public void RemoveWindZone(int windId); // 0x0000000188A559FC-0x0000000188A55A54
	}

	public class TransformData : IDisposable // TypeDefIndex: 77952
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
		public int Count { get; } // 0x0000000185B93920-0x0000000185B93960 
		public int RootCount { get; } // 0x0000000186D35870-0x0000000186D358B0 
		public bool IsDirty { get; } // 0x000000018226EFA0-0x000000018226EFB0 
		public bool IsEmpty { get; } // 0x0000000185371DA0-0x0000000185371DB0 
	
		// Nested types
		[BurstCompile]
		private struct RestoreTransformJob : IJobParallelForTransform // TypeDefIndex: 77948
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
			public void Execute(int index, TransformAccess transform); // 0x0000000188A5356C-0x0000000188A53638
		}
	
		[BurstCompile]
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 77949
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
			public void Execute(int index, TransformAccess transform); // 0x0000000188A53230-0x0000000188A5356C
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 77950
		{
			// Fields
			public ExSimpleNativeArray<ExBitFlag8> flagArray; // 0x10
			public ExSimpleNativeArray<float3> initLocalPositionArray; // 0x18
			public ExSimpleNativeArray<quaternion> initLocalRotationArray; // 0x20
	
			// Constructors
			public ShareSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 77951
		{
			// Fields
			public Transform[] transformArray; // 0x10
	
			// Constructors
			public UniqueSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A59DF0-0x0000000188A59EB4
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A59EB4-0x0000000188A59FE8
		}
	
		// Constructors
		public TransformData(); // 0x0000000186805BA0-0x0000000186805BB0
		public TransformData(int capacity); // 0x0000000186262000-0x0000000186262010
	
		// Methods
		public void Init(int capacity); // 0x0000000186262010-0x00000001862623D0
		public void Dispose(); // 0x00000001862603F0-0x0000000186260590
		public int AddTransform(Transform t, int tid = 0 /* Metadata: 0x0262A254 */, int pid = 0 /* Metadata: 0x0262A255 */, byte flag = 1 /* Metadata: 0x0262A256 */, bool checkDuplicate = true /* Metadata: 0x0262A257 */); // 0x0000000188A56D7C-0x0000000188A57858
		public int AddTransform(TransformRecord record, int pid = 0 /* Metadata: 0x0262A258 */, byte flag = 1 /* Metadata: 0x0262A259 */, bool checkDuplicate = true /* Metadata: 0x0262A25A */); // 0x0000000188A566F4-0x0000000188A56D7C
		public int AddTransform(TransformData srcData, int srcIndex, bool checkDuplicate = true /* Metadata: 0x0262A25B */); // 0x0000000188A57858-0x0000000188A57E68
		public int[] AddTransformRange(List<Transform> tlist, List<int> idList, List<int> pidList, int copyCount = 0 /* Metadata: 0x0262A25C */); // 0x0000000188A56410-0x0000000188A566F4
		public int[] AddTransformRange(TransformData stdata, int copyCount = 0 /* Metadata: 0x0262A25D */); // 0x0000000188A562EC-0x0000000188A56410
		public int[] AddTransformRange(List<Transform> tlist, List<int> idList, List<int> pidList, List<int> rootIds, NativeArray<float3> localPositions, NativeArray<quaternion> localRotations, NativeArray<float3> positions, NativeArray<quaternion> rotations, NativeArray<float3> scales, NativeArray<quaternion> inverseRotations); // 0x0000000185B93FE0-0x0000000185B94410
		public void RemoveTransformIndex(int index); // 0x0000000188A58FF8-0x0000000188A59094
		public int ReplaceTransform(int index, Transform t, int tid = 0 /* Metadata: 0x0262A25E */, int pid = 0 /* Metadata: 0x0262A25F */, byte flag = 1 /* Metadata: 0x0262A260 */); // 0x0000000188A59094-0x0000000188A59548
		private int ReferenceIndexOf<T>(List<T> list, T item)
			where T : class;
		public void UpdateWorkData(); // 0x0000000188A59AC0-0x0000000188A59B54
		public JobHandle RestoreTransform(int count, JobHandle jobHandle = default); // 0x0000000188A59548-0x0000000188A59688
		public JobHandle ReadTransform(JobHandle jobHandle = default); // 0x0000000188A58E74-0x0000000188A58FF8
		public void ReadTransformRun(); // 0x0000000188A58D4C-0x0000000188A58E74
		public void OrganizeReductionTransform(VirtualMesh vmesh, ReductionWorkData workData); // 0x0000000188A581AC-0x0000000188A58D4C
		public Transform GetTransformFromIndex(int index); // 0x0000000185B199A0-0x0000000185B199D0
		public int GetTransformIndexFormId(int id); // 0x0000000188A580A8-0x0000000188A58134
		public int GetTransformIdFromIndex(int index); // 0x0000000188A58058-0x0000000188A580A8
		public int GetParentIdFromIndex(int index); // 0x0000000188A58008-0x0000000188A58058
		public float4x4 GetLocalToWorldMatrix(int index); // 0x0000000188A57E68-0x0000000188A58008
		public float4x4 GetWorldToLocalMatrix(int index); // 0x0000000188A58134-0x0000000188A581AC
		public override string ToString(); // 0x0000000188A59804-0x0000000188A599A8
		public ShareSerializationData ShareSerialize(); // 0x0000000188A59688-0x0000000188A59804
		public static TransformData ShareDeserialize(ShareSerializationData sdata); // 0x0000000186262490-0x0000000186262610
		public UniqueSerializationData UniqueSerialize(); // 0x0000000188A599A8-0x0000000188A59AC0
	}

	public class TransformRecord : IValid, ITransform // TypeDefIndex: 77953
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
		public TransformRecord(Transform t); // 0x0000000185D7A240-0x0000000185D7A440
	
		// Methods
		public Vector3 InverseTransformDirection(Vector3 dir); // 0x0000000188A59BA8-0x0000000188A59C18
		public bool IsValid(); // 0x0000000188A59C18-0x0000000188A59C20
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A59B54-0x0000000188A59BA8
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A59C20-0x0000000188A59D00
	}

	[CreateAssetMenu(fileName = "Data", menuName = "MagicaCloth2/PreBuildScriptableObject")]
	public class PreBuildScriptableObject : ScriptableObject // TypeDefIndex: 77956
	{
		// Fields
		public List<SharePreBuildData> sharePreBuildDataList; // 0x18
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 77954
		{
			// Fields
			public SharePreBuildData sdata; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddPreBuildData_b__0(SharePreBuildData x); // 0x0000000188A59D5C-0x0000000188A59D8C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 77955
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<SharePreBuildData> __9__4_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000188A59D8C-0x0000000188A59DF0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Warmup_b__4_0(SharePreBuildData sdata); // 0x0000000188A59D00-0x0000000188A59D5C
		}
	
		// Constructors
		public PreBuildScriptableObject(); // 0x0000000188A523F0-0x0000000188A52470
	
		// Methods
		public bool HasPreBuildData(string buildId); // 0x0000000188A522B8-0x0000000188A522D0
		public SharePreBuildData GetPreBuildData(string buildId); // 0x0000000188A52178-0x0000000188A522B8
		public void AddPreBuildData(SharePreBuildData sdata); // 0x0000000188A5204C-0x0000000188A52178
		public void Warmup(); // 0x0000000188A522D0-0x0000000188A523F0
	}

	[Serializable]
	public class PreBuildSerializeData : ITransform // TypeDefIndex: 77957
	{
		// Fields
		public bool enabled; // 0x10
		public SharePreBuildData preBuildData; // 0x18
		public UniquePreBuildData uniquePreBuildData; // 0x20
	
		// Constructors
		public PreBuildSerializeData(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public bool UsePreBuild(); // 0x00000001829D0800-0x00000001829D0810
		public ResultCode DataValidate(); // 0x00000001862608D0-0x0000000186260950
		public SharePreBuildData GetSharePreBuildData(); // 0x0000000182234E30-0x0000000182234E40
		public static string GenerateBuildID(); // 0x0000000188A52470-0x0000000188A524E8
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A524E8-0x0000000188A52508
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A52508-0x0000000188A52528
	}

	[Serializable]
	public class SharePreBuildData // TypeDefIndex: 77958
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
		public SharePreBuildData(); // 0x0000000186950700-0x00000001869507D0
	
		// Methods
		public ResultCode DataValidate(); // 0x00000001862609A0-0x0000000186260A00
		public bool CheckBuildId(string buildId); // 0x0000000188A53638-0x0000000188A5365C
		public override string ToString(); // 0x0000000188A5365C-0x0000000188A538D8
	}

	[Serializable]
	public class UniquePreBuildData : ITransform // TypeDefIndex: 77961
	{
		// Fields
		public int version; // 0x10
		public ResultCode buildResult; // 0x14
		public List<RenderSetupData.UniqueSerializationData> renderSetupDataList; // 0x20
		public VirtualMesh.UniqueSerializationData proxyMesh; // 0x28
		public List<VirtualMesh.UniqueSerializationData> renderMeshList; // 0x30
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 77959
		{
			// Fields
			public HashSet<Transform> transformSet; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _GetUsedTransform_b__0(RenderSetupData.UniqueSerializationData x); // 0x0000000188A6A698-0x0000000188A6A6B0
			internal void _GetUsedTransform_b__1(VirtualMesh.UniqueSerializationData x); // 0x0000000188A6A6B0-0x0000000188A6A6C8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 77960
		{
			// Fields
			public Dictionary<int, Transform> replaceDict; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _ReplaceTransform_b__0(RenderSetupData.UniqueSerializationData x); // 0x0000000188A6A6C8-0x0000000188A6A6E0
			internal void _ReplaceTransform_b__1(VirtualMesh.UniqueSerializationData x); // 0x0000000188A6A6E0-0x0000000188A6A6F8
		}
	
		// Constructors
		public UniquePreBuildData(); // 0x0000000186950630-0x0000000186950700
	
		// Methods
		public ResultCode DataValidate(); // 0x0000000186260950-0x00000001862609A0
		public void GetUsedTransform(HashSet<Transform> transformSet); // 0x0000000188A6A6F8-0x0000000188A6A858
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x0000000188A6A858-0x0000000188A6A9B8
	}

	[Serializable]
	public class ReductionSettings : IDataValidate // TypeDefIndex: 77962
	{
		// Fields
		[Range(0f, 0.2f)]
		public float simpleDistance; // 0x10
		[Range(0f, 0.2f)]
		public float shapeDistance; // 0x14
	
		// Properties
		public bool IsEnabled { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Constructors
		public ReductionSettings(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public float GetMaxConnectionDistance(); // 0x0000000188A66AF4-0x0000000188A66B2C
		public ReductionSettings Clone(); // 0x0000000188A66A24-0x0000000188A66A78
		public void DataValidate(); // 0x0000000188A66A78-0x0000000188A66AC0
		public override int GetHashCode(); // 0x0000000188A66AC0-0x0000000188A66AF4
		public override string ToString(); // 0x0000000188A66B2C-0x0000000188A66CA0
	}

	public class ReductionWorkData : IDisposable // TypeDefIndex: 77963
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
		public ReductionWorkData(VirtualMesh vmesh); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public void Dispose(); // 0x0000000188A66CA0-0x0000000188A66FF4
	}

	public class SameDistanceReduction : IDisposable // TypeDefIndex: 77970
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
		public ResultCode Result { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Nested types
		[BurstCompile]
		private struct InitGridJob : IJob // TypeDefIndex: 77964
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
			public void Execute(); // 0x0000000188A60E3C-0x0000000188A60EEC
		}
	
		[BurstCompile]
		private struct SearchJoinJob : IJob // TypeDefIndex: 77965
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
			public void Execute(); // 0x0000000188A68458-0x0000000188A68898
		}
	
		[BurstCompile]
		private struct JoinJob2 : IJob // TypeDefIndex: 77966
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
			public void Execute(); // 0x0000000188A61BA0-0x0000000188A62184
		}
	
		[BurstCompile]
		private struct UpdateJoinIndexJob : IJobParallelFor // TypeDefIndex: 77967
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A6A9B8-0x0000000188A6A9FC
		}
	
		[BurstCompile]
		private struct UpdateLinkIndexJob : IJobParallelFor // TypeDefIndex: 77968
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x10
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A6AC20-0x0000000188A6AEF4
		}
	
		[BurstCompile]
		private struct FinalMergeVertexJob : IJobParallelFor // TypeDefIndex: 77969
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A60D84-0x0000000188A60E3C
		}
	
		// Constructors
		public SameDistanceReduction(); // 0x0000000188A679F4-0x0000000188A67A3C
		public SameDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float mergeLength); // 0x0000000188A67A3C-0x0000000188A67B0C
	
		// Methods
		public virtual void Dispose(); // 0x0000000188A66FF4-0x0000000188A670AC
		public ResultCode Reduction(); // 0x0000000188A670AC-0x0000000188A67830
		private void UpdateJoinAndLink(); // 0x0000000188A67830-0x0000000188A67908
		private void UpdateReductionResultJob(); // 0x0000000188A67908-0x0000000188A679F4
	}

	public class ShapeDistanceReduction : StepReductionBase // TypeDefIndex: 77972
	{
		// Nested types
		[BurstCompile]
		private struct SearchJoinEdgeJob : IJob // TypeDefIndex: 77971
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
			public void Execute(); // 0x0000000188A67B0C-0x0000000188A67EF0
		}
	
		// Constructors
		public ShapeDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment); // 0x0000000188A68970-0x0000000188A68A04
	
		// Methods
		public override void Dispose(); // 0x0000000188A68960-0x0000000188A68968
		protected override void StepInitialize(); // 0x0000000188A68968-0x0000000188A68970
		protected override void CustomReductionStep(); // 0x0000000188A68898-0x0000000188A68960
	}

	public class SimpleDistanceReduction : StepReductionBase // TypeDefIndex: 77975
	{
		// Fields
		private GridMap<int> gridMap; // 0x90
	
		// Nested types
		[BurstCompile]
		private struct InitGridJob : IJob // TypeDefIndex: 77973
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
			public void Execute(); // 0x0000000188A60EEC-0x0000000188A60F9C
		}
	
		[BurstCompile]
		private struct SearchJoinEdgeJob : IJob // TypeDefIndex: 77974
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
			public void Execute(); // 0x0000000188A67EF0-0x0000000188A68458
		}
	
		// Constructors
		public SimpleDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment); // 0x0000000188A68CEC-0x0000000188A68D80
	
		// Methods
		public override void Dispose(); // 0x0000000188A68BF4-0x0000000188A68C48
		protected override void StepInitialize(); // 0x0000000188A68C48-0x0000000188A68CEC
		protected override void CustomReductionStep(); // 0x0000000188A68A04-0x0000000188A68BF4
	}

	public abstract class StepReductionBase : IDisposable // TypeDefIndex: 77982
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
		public ResultCode Result { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Nested types
		public struct JoinEdge : IComparable<JoinEdge> // TypeDefIndex: 77976
		{
			// Fields
			public int2 vertexPair; // 0x00
			public float cost; // 0x08
	
			// Methods
			public bool Contains([IsReadOnly] in int2 pair); // 0x0000000188A61B7C-0x0000000188A61BA0
			public int CompareTo(JoinEdge other); // 0x0000000188A61B50-0x0000000188A61B7C
		}
	
		[BurstCompile]
		private struct DeterminJoinEdgeJob : IJob // TypeDefIndex: 77977
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
			public void Execute(); // 0x0000000188A605CC-0x0000000188A60764
		}
	
		[BurstCompile]
		private struct JoinPairJob : IJob // TypeDefIndex: 77978
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
			public void Execute(); // 0x0000000188A62184-0x0000000188A6284C
		}
	
		[BurstCompile]
		private struct UpdateJoinIndexJob : IJobParallelFor // TypeDefIndex: 77979
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A6A9B8-0x0000000188A6A9FC
		}
	
		[BurstCompile]
		private struct UpdateLinkIndexJob : IJobParallelFor // TypeDefIndex: 77980
		{
			// Fields
			[NativeDisableParallelForRestriction]
			public NativeArray<int> joinIndices; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x10
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A6A9FC-0x0000000188A6AC20
		}
	
		[BurstCompile]
		private struct FinalMergeVertexJob : IJobParallelFor // TypeDefIndex: 77981
		{
			// Fields
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A60D84-0x0000000188A60E3C
		}
	
		// Constructors
		public StepReductionBase(); // 0x0000000188A6A588-0x0000000188A6A5D0
		public StepReductionBase(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment); // 0x0000000188A6A484-0x0000000188A6A588
	
		// Methods
		public virtual void Dispose(); // 0x0000000188A69BCC-0x0000000188A69CBC
		public ResultCode Reduction(); // 0x0000000188A69DC0-0x0000000188A69FB8
		private void InitStep(); // 0x0000000187234400-0x0000000187234420
		private bool IsEndStep(); // 0x0000000188A69CBC-0x0000000188A69CD0
		private void NextStep(); // 0x0000000188A69CD0-0x0000000188A69D18
		private void ReductionStep(); // 0x0000000188A69D94-0x0000000188A69DC0
		protected virtual void StepInitialize(); // 0x0000000188A6A188-0x0000000188A6A2C0
		protected virtual void CustomReductionStep(); // 0x0000000186805BA0-0x0000000186805BB0
		private void PreReductionStep(); // 0x0000000188A69D4C-0x0000000188A69D94
		private void PostReductionStep(); // 0x0000000188A69D18-0x0000000188A69D4C
		private void SortJoinEdge(); // 0x0000000188A6A140-0x0000000188A6A188
		private void DetermineJoinEdge(); // 0x0000000188A69B10-0x0000000188A69BCC
		private void RunJoinEdge(); // 0x0000000188A69FB8-0x0000000188A6A140
		private void UpdateJoinAndLink(); // 0x0000000188A6A2C0-0x0000000188A6A398
		private void UpdateReductionResultJob(); // 0x0000000188A6A398-0x0000000188A6A484
		protected static bool CheckJoin2([IsReadOnly] in NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap, int vindex, int tvindex, bool dontMakeLine); // 0x0000000188A691F4-0x0000000188A69680
		protected static bool CheckJoin([IsReadOnly] in NativeArray<FixedList128Bytes<ushort>> vertexToVertexArray, int vindex, int tvindex, [IsReadOnly] in FixedList128Bytes<ushort> vlist, [IsReadOnly] in FixedList128Bytes<ushort> tvlist, bool dontMakeLine); // 0x0000000188A69680-0x0000000188A69B10
	}

	[Serializable]
	public class ClothDebugSettings // TypeDefIndex: 77984
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
		public enum DebugAxis // TypeDefIndex: 77983
		{
			None = 0,
			Normal = 1,
			All = 2
		}
	
		// Constructors
		public ClothDebugSettings(); // 0x00000001872340D0-0x00000001872340E0
	
		// Methods
		public bool CheckParticleDrawing(int index); // 0x00000001851A4410-0x00000001851A4420
		public bool CheckTriangleDrawing(int index); // 0x00000001851A4410-0x00000001851A4420
		public bool CheckRadiusDrawing(); // 0x00000001851A4410-0x00000001851A4420
		public float GetPointSize(); // 0x00000001872340B0-0x00000001872340C0
		public float GetLineSize(); // 0x00000001872340C0-0x00000001872340D0
		public float GetInertiaCenterRadius(); // 0x00000001872340B0-0x00000001872340C0
		public float GetCustomSkinningRadius(); // 0x00000001872340A0-0x00000001872340B0
		public bool IsReferOldPos(); // 0x00000001843FFFF0-0x0000000184400000
	}

	public class DataUtility // TypeDefIndex: 77985
	{
		// Constructors
		public DataUtility(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static int2 PackInt2(int d0, int d1); // 0x0000000188A60480-0x0000000188A6049C
		public static int2 PackInt2([IsReadOnly] in int2 d); // 0x0000000188A60474-0x0000000188A60480
		public static int3 PackInt3(int d0, int d1, int d2); // 0x0000000188A604DC-0x0000000188A60534
		public static int3 PackInt3([IsReadOnly] in int3 d); // 0x0000000188A6049C-0x0000000188A604DC
		public static int4 PackInt4(int d0, int d1, int d2, int d3); // 0x0000000188A60570-0x0000000188A605CC
		public static int4 PackInt4(int4 d); // 0x0000000188A60534-0x0000000188A60570
		public static uint Pack32(int hi, int low); // 0x0000000187234120-0x0000000187234130
		public static uint Pack32Sort(int a, int b); // 0x0000000188A6045C-0x0000000188A60474
		public static int Unpack32Hi(uint pack); // 0x0000000187234200-0x0000000187234210
		public static int Unpack32Low(uint pack); // 0x0000000187234210-0x0000000187234220
		public static uint Pack12_20(int hi, int low); // 0x0000000187234110-0x0000000187234120
		public static int Unpack12_20Hi(uint pack); // 0x00000001872341C0-0x00000001872341D0
		public static int Unpack12_20Low(uint pack); // 0x00000001872341D0-0x00000001872341E0
		public static void Unpack12_20(uint pack, out int hi, out int low); // 0x00000001872341E0-0x0000000187234200
		public static ulong Pack64(int x, int y, int z, int w); // 0x0000000187234180-0x00000001872341B0
		public static ulong Pack64([IsReadOnly] in int4 a); // 0x0000000187234130-0x0000000187234160
		public static int4 Unpack64([IsReadOnly] in ulong pack); // 0x0000000187234270-0x00000001872342A0
		public static int Unpack64X([IsReadOnly] in ulong pack); // 0x0000000187234240-0x0000000187234250
		public static int Unpack64Y([IsReadOnly] in ulong pack); // 0x0000000187234250-0x0000000187234260
		public static int Unpack64Z([IsReadOnly] in ulong pack); // 0x0000000187234260-0x0000000187234270
		public static int Unpack64W([IsReadOnly] in ulong pack); // 0x000000018448B780-0x000000018448B790
		public static uint Pack32(int x, int y, int z, int w); // 0x0000000187234160-0x0000000187234180
		public static ulong Pack32([IsReadOnly] in int4 a); // 0x0000000187234130-0x0000000187234160
		public static int4 Unpack32([IsReadOnly] in uint pack); // 0x0000000187234220-0x0000000187234240
		public static int RemainingData([IsReadOnly] in int3 data, [IsReadOnly] in int2 use); // 0x00000001889EBB98-0x00000001889EBBC0
		public static float4x4 ConvertAnimationCurve(AnimationCurve curve); // 0x00000001852F5560-0x00000001852F5660
		public static float EvaluateCurve([IsReadOnly] in float4x4 curve, float time); // 0x00000001889CA0A0-0x00000001889CA1AC
		public static ColliderManager.ColliderType GetColliderType([IsReadOnly] in ExBitFlag8 flag); // 0x0000000187234100-0x0000000187234110
		public static ExBitFlag8 SetColliderType(ExBitFlag8 flag, ColliderManager.ColliderType ctype); // 0x00000001872341B0-0x00000001872341C0
		public static void ArrayCopy<T>(T[] src, ref ref T[] dst);
	}

	public class MultiDataBuilder<T> : IDisposable // TypeDefIndex: 77986
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

	public class GridMap<T> : IDisposable // TypeDefIndex: 77988
		where T : struct, IEquatable<T>
	{
		// Fields
		private NativeParallelMultiHashMap<int3, T> gridMap;
	
		// Properties
		public int DataCount { get; }
	
		// Nested types
		public struct GridEnumerator : IEnumerator<int3> // TypeDefIndex: 77987
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
		public GridMap(int capacity = 0 /* Metadata: 0x0262A264 */);
	
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

	public static class ClothJobUtility // TypeDefIndex: 78005
	{
		// Nested types
		[BurstCompile]
		private struct FillJob<T> : IJobParallelFor, ICrossFrameParallelForJob // TypeDefIndex: 77989
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
		private struct FillJob2<T> : IJobParallelFor, ICrossFrameParallelForJob // TypeDefIndex: 77990
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
		private struct FillRefJob<T> : IJob // TypeDefIndex: 77991
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
		private struct SerialNumberJob : IJobParallelFor // TypeDefIndex: 77992
		{
			// Fields
			[WriteOnly]
			public NativeArray<int> array; // 0x00
	
			// Methods
			public void Execute(int index); // 0x0000000185B95C70-0x0000000185B95C80
		}
	
		[BurstCompile]
		private struct ConvertHashSetToListJob<T> : IJob // TypeDefIndex: 77993
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
		private struct ConvertHashSetKeyToListJob<T> : IJob // TypeDefIndex: 77994
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
		private struct CalcAABBJob : IJob // TypeDefIndex: 77995
		{
			// Fields
			public int length; // 0x00
			[ReadOnly]
			public NativeArray<float3> positions; // 0x08
			public NativeReference<AABB> outAABB; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001865AE5A0-0x00000001865AE600
		}
	
		[BurstCompile]
		private struct CalcAABBDeferJob : IJob // TypeDefIndex: 77996
		{
			// Fields
			[ReadOnly]
			public NativeList<float3> positions; // 0x00
			public NativeReference<AABB> outAABB; // 0x10
	
			// Methods
			public void Execute(); // 0x0000000188A5F474-0x0000000188A5F514
		}
	
		[BurstCompile]
		private struct CalcUVJob : IJobParallelFor // TypeDefIndex: 77997
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> positions; // 0x00
			[ReadOnly]
			public NativeReference<AABB> aabb; // 0x10
			[WriteOnly]
			public NativeArray<float2> uvs; // 0x20
	
			// Methods
			public void Execute(int index); // 0x0000000188A5F514-0x0000000188A5F6E0
		}
	
		[BurstCompile]
		public struct AddIntDataCopyJob : IJobParallelFor // TypeDefIndex: 77998
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
			public void Execute(int index); // 0x0000000187234060-0x0000000187234080
		}
	
		[BurstCompile]
		public struct AddInt2DataCopyJob : IJobParallelFor // TypeDefIndex: 77999
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
			public void Execute(int index); // 0x0000000188A5DCF4-0x0000000188A5DD28
		}
	
		[BurstCompile]
		public struct AddInt3DataCopyJob : IJobParallelFor // TypeDefIndex: 78000
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
			public void Execute(int index); // 0x0000000188A5DD28-0x0000000188A5DD9C
		}
	
		[BurstCompile]
		public struct TransformPositionJob : IJobParallelFor // TypeDefIndex: 78001
		{
			// Fields
			public float4x4 toM; // 0x00
			public NativeArray<float3> positions; // 0x40
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A6A634-0x0000000188A6A698
		}
	
		[BurstCompile]
		public struct TransformPositionJob2 : IJobParallelFor // TypeDefIndex: 78002
		{
			// Fields
			public float4x4 toM; // 0x00
			[ReadOnly]
			public NativeArray<float3> srcPositions; // 0x40
			[WriteOnly]
			public NativeArray<float3> dstPositions; // 0x50
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A6A5D0-0x0000000188A6A634
		}
	
		[BurstCompile]
		private struct ConvertArrayToMapJob<TData> : IJob // TypeDefIndex: 78003
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
		private struct ClearReferenceJob : IJob // TypeDefIndex: 78004
		{
			// Fields
			public NativeReference<int> reference; // 0x00
	
			// Methods
			public void Execute(); // 0x0000000188A5F6E0-0x0000000188A5F71C
		}
	
		// Methods
		public static JobHandle Fill(NativeArray<byte> array, int length, byte value, JobHandle dependsOn = default); // 0x0000000188A5FE78-0x0000000188A5FF48
		public static void FillRun(NativeArray<int> array, int length, int value); // 0x0000000188A5FCB8-0x0000000188A5FD3C
		public static void FillRun(NativeArray<quaternion> array, int length, quaternion value); // 0x00000001862634F0-0x0000000186263580
		public static void FillRun(NativeArray<VirtualMeshBoneWeight> array, int length, VirtualMeshBoneWeight value); // 0x0000000188A5FD3C-0x0000000188A5FDCC
		public static JobHandle Fill(NativeArray<int> array, int startIndex, int length, int value, JobHandle dependsOn = default); // 0x0000000188A5FF48-0x0000000188A60018
		public static JobHandle Fill(NativeReference<int> reference, int value, JobHandle dependsOn = default); // 0x0000000188A5FDCC-0x0000000188A5FE78
		public static JobHandle SerialNumber(NativeArray<int> array, int length, JobHandle dependsOn = default); // 0x0000000188A60018-0x0000000188A600B8
		public static void SerialNumberRun(NativeArray<int> array, int length); // 0x0000000186C009B0-0x0000000186C00A10
		public static JobHandle ConvertHashSetToNativeList(NativeParallelHashSet<int> hashSet, NativeList<int> list, JobHandle dependsOn = default); // 0x0000000188A5FC18-0x0000000188A5FCB8
		public static JobHandle ConvertHashSetKeyToNativeList(NativeParallelHashSet<int2> hashSet, NativeList<int2> keyList, JobHandle dependsOn = default); // 0x0000000188A5FAD8-0x0000000188A5FB78
		public static JobHandle ConvertHashSetKeyToNativeList(NativeParallelHashSet<int4> hashSet, NativeList<int4> keyList, JobHandle dependsOn = default); // 0x0000000188A5FB78-0x0000000188A5FC18
		public static JobHandle CalcAABB(NativeArray<float3> positions, int length, NativeReference<AABB> outAABB, JobHandle dependsOn = default); // 0x0000000188A5F824-0x0000000188A5F8F0
		public static void CalcAABBRun(NativeArray<float3> positions, int length, NativeReference<AABB> outAABB); // 0x0000000185B936C0-0x0000000185B93760
		public static JobHandle CalcAABB(NativeList<float3> positions, NativeReference<AABB> outAABB, JobHandle dependsOn = default); // 0x0000000188A5F784-0x0000000188A5F824
		public static void CalcAABBRun(NativeList<float3> positions, NativeReference<AABB> outAABB); // 0x0000000188A5F71C-0x0000000188A5F784
		private static AABB CalcAABBInternal([IsReadOnly] in NativeArray<float3> positions, int length); // 0x00000001865AEB50-0x00000001865AED00
		public static JobHandle CalcUVWithSphereMapping(NativeArray<float3> positions, int length, NativeReference<AABB> aabb, NativeArray<float2> outUVs, JobHandle dependsOn = default); // 0x0000000188A5F980-0x0000000188A5FA58
		public static void CalcUVWithSphereMappingRun(NativeArray<float3> positions, int length, NativeReference<AABB> aabb, NativeArray<float2> outUVs); // 0x0000000188A5F8F0-0x0000000188A5F980
		public static JobHandle TransformPosition(NativeArray<float3> positions, int length, [IsReadOnly] in float4x4 toM, JobHandle dependsOn = default); // 0x0000000188A601FC-0x0000000188A602E4
		public static void TransformPositionRun(NativeArray<float3> positions, int length, [IsReadOnly] in float4x4 toM); // 0x0000000188A60168-0x0000000188A601FC
		public static JobHandle TransformPosition(NativeArray<float3> srcPositions, NativeArray<float3> dstPositions, int length, [IsReadOnly] in float4x4 toM, JobHandle dependsOn = default); // 0x0000000188A602E4-0x0000000188A603D4
		public static void TransformPositionRun(NativeArray<float3> srcPositions, NativeArray<float3> dstPositions, int length, [IsReadOnly] in float4x4 toM); // 0x0000000188A600B8-0x0000000188A60168
		public static NativeParallelMultiHashMap<int, ushort> ToNativeMultiHashMap([IsReadOnly] in NativeArray<uint> indexArray, [IsReadOnly] in NativeArray<ushort> dataArray); // 0x000000018693D1A0-0x000000018693D260
		public static JobHandle ClearReference(NativeReference<int> reference, JobHandle jobHandle); // 0x0000000188A5FA58-0x0000000188A5FAD8
	}

	public static class InterlockUtility // TypeDefIndex: 78032
	{
		// Fields
		private const int ToFixed = 1000000; // Metadata: 0x0262A265
		private const float ToFloat = 1E-06f; // Metadata: 0x0262A269
	
		// Nested types
		[BurstCompile]
		private static class AggregateJobKernels // TypeDefIndex: 78010
		{
			// Nested types
			public unsafe delegate void AggregateKernel_00000584_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 78006; 0x00000001812083C0-0x00000001812083E0
	
			internal static class AggregateKernel_00000584_BurstDirectCall // TypeDefIndex: 78007
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateKernel_00000584_BurstDirectCall(); // 0x000000018242C0C0-0x000000018242C0D0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a7767); // 0x000000018242AAA0-0x000000018242B700
				private static IntPtr GetFunctionPointer(); // 0x000000018242B700-0x000000018242BA00
				public static void Constructor(); // 0x000000018242A220-0x000000018242AAA0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x000000018242BA00-0x000000018242C0C0
			}
	
			public unsafe delegate void AggregateRangeKernel_00000585_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 78008; 0x00000001812083C0-0x00000001812083E0
	
			internal static class AggregateRangeKernel_00000585_BurstDirectCall // TypeDefIndex: 78009
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateRangeKernel_00000585_BurstDirectCall(); // 0x000000018242EAF0-0x000000018242EB00
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a777c); // 0x000000018242D270-0x000000018242DED0
				private static IntPtr GetFunctionPointer(); // 0x000000018242DED0-0x000000018242E1D0
				public static void Constructor(); // 0x000000018242C9F0-0x000000018242D270
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // 0x000000018242E1D0-0x000000018242EAF0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateKernel(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x0000000188A5E3D0-0x0000000188A5E448
			[BurstCompile]
			internal static unsafe void AggregateRangeKernel(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // 0x0000000188A5E4B8-0x0000000188A5E530
			[BurstCompile]
			public static unsafe void AggregateKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x0000000188A5DF18-0x0000000188A5E064
			[BurstCompile]
			public static unsafe void AggregateRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // 0x0000000188A5E448-0x0000000188A5E4B8
		}
	
		[BurstCompile]
		private static class AggregateWithVelocityJobKernels // TypeDefIndex: 78015
		{
			// Nested types
			public unsafe delegate void AggregateWithVelocityKernel_00000586_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // TypeDefIndex: 78011; 0x00000001811C5A40-0x00000001811C5A60
	
			internal static class AggregateWithVelocityKernel_00000586_BurstDirectCall // TypeDefIndex: 78012
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityKernel_00000586_BurstDirectCall(); // 0x0000000182436B50-0x0000000182436B60
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a77b1); // 0x0000000182435490-0x00000001824360F0
				private static IntPtr GetFunctionPointer(); // 0x00000001824360F0-0x00000001824363F0
				public static void Constructor(); // 0x0000000182434C10-0x0000000182435490
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x00000001824363F0-0x0000000182436B50
			}
	
			public unsafe delegate void AggregateWithVelocityRangeKernel_00000587_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // TypeDefIndex: 78013; 0x00000001811C5A40-0x00000001811C5A60
	
			internal static class AggregateWithVelocityRangeKernel_00000587_BurstDirectCall // TypeDefIndex: 78014
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityRangeKernel_00000587_BurstDirectCall(); // 0x0000000182439870-0x0000000182439880
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a77cc); // 0x0000000182437FD0-0x0000000182438C30
				private static IntPtr GetFunctionPointer(); // 0x0000000182438C30-0x0000000182438F30
				public static void Constructor(); // 0x0000000182437750-0x0000000182437FD0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // 0x0000000182438F30-0x0000000182439870
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateWithVelocityKernel(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x0000000188A5EFD4-0x0000000188A5F050
			[BurstCompile]
			internal static unsafe void AggregateWithVelocityRangeKernel(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // 0x0000000188A5F0E8-0x0000000188A5F164
			[BurstCompile]
			public static unsafe void AggregateWithVelocityKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x0000000188A5E974-0x0000000188A5EB74
			[BurstCompile]
			public static unsafe void AggregateWithVelocityRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // 0x0000000188A5F050-0x0000000188A5F0E8
		}
	
		[BurstCompile]
		private static class AggregateJob2Kernels // TypeDefIndex: 78020
		{
			// Nested types
			public unsafe delegate void AggregateJob2Kernel_00000588_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 78016; 0x00000001812083C0-0x00000001812083E0
	
			internal static class AggregateJob2Kernel_00000588_BurstDirectCall // TypeDefIndex: 78017
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateJob2Kernel_00000588_BurstDirectCall(); // 0x0000000182427050-0x0000000182427060
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a77f7); // 0x0000000182425A30-0x0000000182426690
				private static IntPtr GetFunctionPointer(); // 0x0000000182426690-0x0000000182426990
				public static void Constructor(); // 0x00000001824251B0-0x0000000182425A30
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x0000000182426990-0x0000000182427050
			}
	
			public unsafe delegate void AggregateJob2RangeKernel_00000589_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // TypeDefIndex: 78018; 0x00000001812083C0-0x00000001812083E0
	
			internal static class AggregateJob2RangeKernel_00000589_BurstDirectCall // TypeDefIndex: 78019
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateJob2RangeKernel_00000589_BurstDirectCall(); // 0x0000000182429BC0-0x0000000182429BD0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a780c); // 0x0000000182428330-0x0000000182428F90
				private static IntPtr GetFunctionPointer(); // 0x0000000182428F90-0x0000000182429290
				public static void Constructor(); // 0x0000000182427AB0-0x0000000182428330
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // 0x0000000182429290-0x0000000182429BC0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateJob2Kernel(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x0000000188A5E064-0x0000000188A5E0DC
			[BurstCompile]
			internal static unsafe void AggregateJob2RangeKernel(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // 0x0000000188A5E14C-0x0000000188A5E1C4
			[BurstCompile]
			public static unsafe void AggregateJob2Kernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // 0x0000000188A5DF18-0x0000000188A5E064
			[BurstCompile]
			public static unsafe void AggregateJob2RangeKernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // 0x0000000188A5E0DC-0x0000000188A5E14C
		}
	
		[BurstCompile]
		private static class AggregateWithVelocityJob2Kernels // TypeDefIndex: 78025
		{
			// Nested types
			public unsafe delegate void AggregateWithVelocityJob2Kernel_0000058A_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // TypeDefIndex: 78021; 0x00000001811C5A40-0x00000001811C5A60
	
			internal static class AggregateWithVelocityJob2Kernel_0000058A_BurstDirectCall // TypeDefIndex: 78022
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityJob2Kernel_0000058A_BurstDirectCall(); // 0x0000000182431360-0x0000000182431370
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a7841); // 0x000000018242FCA0-0x0000000182430900
				private static IntPtr GetFunctionPointer(); // 0x0000000182430900-0x0000000182430C00
				public static void Constructor(); // 0x000000018242F420-0x000000018242FCA0
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x0000000182430C00-0x0000000182431360
			}
	
			public unsafe delegate void AggregateWithVelocityJob2RangeKernel_0000058B_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // TypeDefIndex: 78023; 0x00000001811C5A40-0x00000001811C5A60
	
			internal static class AggregateWithVelocityJob2RangeKernel_0000058B_BurstDirectCall // TypeDefIndex: 78024
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityJob2RangeKernel_0000058B_BurstDirectCall(); // 0x00000001824341B0-0x00000001824341C0
	
				// Methods
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr param_000a785c); // 0x0000000182432910-0x0000000182433570
				private static IntPtr GetFunctionPointer(); // 0x0000000182433570-0x0000000182433870
				public static void Constructor(); // 0x0000000182432090-0x0000000182432910
				public static void Initialize(); // 0x0000000186805BA0-0x0000000186805BB0
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // 0x0000000182433870-0x00000001824341B0
			}
	
			// Methods
			[BurstCompile]
			private static unsafe void AggregateWithVelocityJob2Kernel(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x0000000188A5EB74-0x0000000188A5EBF0
			[BurstCompile]
			internal static unsafe void AggregateWithVelocityJob2RangeKernel(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // 0x0000000188A5EC90-0x0000000188A5ED0C
			[BurstCompile]
			public static unsafe void AggregateWithVelocityJob2Kernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // 0x0000000188A5E974-0x0000000188A5EB74
			[BurstCompile]
			public static unsafe void AggregateWithVelocityJob2RangeKernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // 0x0000000188A5EBF0-0x0000000188A5EC90
		}
	
		[BurstCompile]
		private struct AggregateJob : IJobParallelForDefer, IUnsafeJob // TypeDefIndex: 78026
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
			public void Execute(int index); // 0x0000000188A5E530-0x0000000188A5E6B8
			public void UnsafeDo(); // 0x0000000188A5E6B8-0x0000000188A5E780
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityJob : IJobParallelForDefer, IUnsafeJob // TypeDefIndex: 78027
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
			public void Execute(int index); // 0x0000000188A5F164-0x0000000188A5F37C
			public void UnsafeDo(); // 0x0000000188A5F37C-0x0000000188A5F474
		}
	
		[BurstCompile]
		private struct AggregateJob2 : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 78028
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187234080-0x0000000187234090
			public void Execute(); // 0x0000000188A5E308-0x0000000188A5E364
			public void Execute(int index); // 0x0000000188A5E1C4-0x0000000188A5E308
			public void UnsafeDo(); // 0x0000000188A5E364-0x0000000188A5E3D0
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityJob2 : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 78029
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
			public void SetIndexCount(NativeReference<int> indexCount); // 0x0000000187234090-0x00000001872340A0
			public void Execute(); // 0x0000000188A5EEEC-0x0000000188A5EF48
			public void Execute(int index); // 0x0000000188A5ED0C-0x0000000188A5EEEC
			public void UnsafeDo(); // 0x0000000188A5EF48-0x0000000188A5EFD4
		}
	
		[BurstCompile]
		private struct AggregateWithVelocityCrossFrameJob2 : IJob // TypeDefIndex: 78030
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
			public void Execute(int index); // 0x0000000188A5E7DC-0x0000000188A5E974
			public void Execute(); // 0x0000000188A5E780-0x0000000188A5E7DC
		}
	
		[BurstCompile]
		private struct AggregateCrossFrameJob2 : IJob // TypeDefIndex: 78031
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
			public void Execute(int index); // 0x0000000188A5DDF8-0x0000000188A5DF18
			public void Execute(); // 0x0000000188A5DD9C-0x0000000188A5DDF8
		}
	
		// Methods
		internal static unsafe void AddFloat3(int index, float3 add, int* cntPt, int* sumPt); // 0x0000000188A615AC-0x0000000188A61644
		internal static unsafe void AddFloat3(int index, float3 add, int* sumPt); // 0x0000000188A61644-0x0000000188A616D8
		internal static unsafe void Increment(int index, int* cntPt); // 0x0000000187234310-0x0000000187234320
		internal static unsafe void Max(int index, float value, int* pt); // 0x00000001889D944C-0x00000001889D9484
		internal static float3 ReadAverageFloat3(int index, [IsReadOnly] in NativeArray<int> countArray, [IsReadOnly] in NativeArray<int> sumArray); // 0x00000001889D9484-0x00000001889D9534
		internal static unsafe float3 ReadAverageFloat3(int index, int* countArray, int* sumArray); // 0x00000001889D9534-0x00000001889D95D8
		internal static float3 ReadFloat3(int index, [IsReadOnly] in NativeArray<int> bufferArray); // 0x00000001889D9648-0x00000001889D96CC
		internal static unsafe float3 ReadFloat3(int index, int* bufferArray); // 0x00000001889D95D8-0x00000001889D9648
		internal static float ReadFloat(int index, [IsReadOnly] in NativeArray<int> bufferArray); // 0x0000000187234340-0x0000000187234360
		internal static unsafe float ReadFloat(int index, int* bufferArray); // 0x0000000187234320-0x0000000187234340
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in NativeList<int> particleList, float velocityAttenuation, JobHandle jobHandle); // 0x0000000188A61730-0x0000000188A61924
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in ExProcessingList<int> processingList, float velocityAttenuation, JobHandle jobHandle); // 0x0000000188A616D8-0x0000000188A61730
		internal static JobHandle SolveAggregateBufferAndClear([IsReadOnly] in NativeArray<int> particleArray, [IsReadOnly] in NativeReference<int> counter, float velocityAttenuation, JobHandle jobHandle); // 0x0000000188A61924-0x0000000188A61B50
		public static void Initialize_AggregateJobKernels_AggregateKernel_00000584_BurstDirectCall(); // 0x000000018243AA70-0x000000018243AD70
		public static void Initialize_AggregateJobKernels_AggregateRangeKernel_00000585_BurstDirectCall(); // 0x000000018243AD70-0x000000018243B070
		public static void Initialize_AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_00000586_BurstDirectCall(); // 0x000000018243B670-0x000000018243B970
		public static void Initialize_AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_00000587_BurstDirectCall(); // 0x000000018243B970-0x000000018243BCC0
		public static void Initialize_AggregateJob2Kernels_AggregateJob2Kernel_00000588_BurstDirectCall(); // 0x000000018243A470-0x000000018243A770
		public static void Initialize_AggregateJob2Kernels_AggregateJob2RangeKernel_00000589_BurstDirectCall(); // 0x000000018243A770-0x000000018243AA70
		public static void Initialize_AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_0000058A_BurstDirectCall(); // 0x000000018243B070-0x000000018243B370
		public static void Initialize_AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_0000058B_BurstDirectCall(); // 0x000000018243B370-0x000000018243B670
	}

	[Serializable]
	public struct AABB : IEquatable<BeyondDynamicBone.AABB> // TypeDefIndex: 78033
	{
		// Fields
		public double3 Min; // 0x00
		public double3 Max; // 0x18
	
		// Properties
		public double3 Extents { get; } // 0x0000000188A5DA74-0x0000000188A5DAD4 
		public double3 HalfExtents { get; } // 0x0000000188A5DAD4-0x0000000188A5DB5C 
		public double3 Center { get; } // 0x0000000188A5D9EC-0x0000000188A5DA74 
		public float MaxSideLength { get; } // 0x0000000188A5DBB8-0x0000000188A5DC20 
		public bool IsValid { get; } // 0x0000000188A5DB5C-0x0000000188A5DBB8 
		public float SurfaceArea { get; } // 0x0000000188A5DC20-0x0000000188A5DCF4 
	
		// Constructors
		public AABB([IsReadOnly] in double3 min, [IsReadOnly] in double3 max); // 0x0000000187234030-0x0000000187234060
	
		// Methods
		public static AABB CreateFromCenterAndExtents(double3 center, double3 extents); // 0x0000000188A5D5AC-0x0000000188A5D644
		public static AABB CreateFromCenterAndHalfExtents(double3 center, double3 halfExtents); // 0x0000000188A5D644-0x0000000188A5D708
		public bool Contains([IsReadOnly] in double3 point); // 0x0000000188A5D4E4-0x0000000188A5D5AC
		public bool Contains([IsReadOnly] in AABB aabb); // 0x0000000188A5D41C-0x0000000188A5D4E4
		public bool Overlaps([IsReadOnly] in AABB aabb); // 0x0000000188A5D778-0x0000000188A5D840
		public void Expand(double signedDistance); // 0x00000001889D5D1C-0x00000001889D5E64
		public void Encapsulate([IsReadOnly] in AABB aabb); // 0x00000001889D5C70-0x00000001889D5D1C
		public void Encapsulate([IsReadOnly] in double3 point); // 0x00000001889F4748-0x00000001889F47F4
		public bool Equals(AABB other); // 0x0000000188A5D708-0x0000000188A5D778
		public void Transform([IsReadOnly] in double4x4 toM); // 0x0000000188A5BF60-0x0000000188A5C12C
		public override string ToString(); // 0x0000000188A5D840-0x0000000188A5D9EC
	}

	[Serializable]
	public struct IntAABB : IEquatable<BeyondDynamicBone.IntAABB> // TypeDefIndex: 78034
	{
		// Fields
		public int3 Min; // 0x00
		public int3 Max; // 0x0C
	
		// Properties
		public int3 Extents { get; } // 0x0000000188A614F4-0x0000000188A6154C 
		public int3 Center { get; } // 0x0000000188A61468-0x0000000188A614F4 
		public bool IsValid { get; } // 0x0000000188A6154C-0x0000000188A615AC 
	
		// Constructors
		public IntAABB(int3 min, int3 max); // 0x0000000187233BB0-0x0000000187233BD0
	
		// Methods
		public bool Contains(int3 point); // 0x0000000188A610B4-0x0000000188A611CC
		public bool Contains(IntAABB aabb); // 0x0000000188A60F9C-0x0000000188A610B4
		public bool Overlaps(IntAABB aabb); // 0x0000000188A612B0-0x0000000188A613CC
		public void Expand(int signedDistance); // 0x0000000188A6123C-0x0000000188A612B0
		public void Encapsulate(IntAABB aabb); // 0x0000000188A5CC64-0x0000000188A5CD4C
		public void Encapsulate(int3 point); // 0x0000000188A5CD4C-0x0000000188A5CFEC
		public bool Equals(IntAABB other); // 0x0000000188A611CC-0x0000000188A6123C
		public override string ToString(); // 0x0000000188A613CC-0x0000000188A61468
	}

	public static class MathExtensions // TypeDefIndex: 78035
	{
		// Extension methods
		public static float MC2GetValue([IsReadOnly] this in float4x4 m, int index); // 0x0000000188A62874-0x0000000188A628C4
		public static void MC2SetValue(this ref float4x4 m, int index, float value); // 0x0000000188A628C4-0x0000000188A628EC
		public static float MC2EvaluateCurveClamp01([IsReadOnly] this in float4x4 m, float time); // 0x0000000188A6284C-0x0000000188A6286C
		public static float MC2EvaluateCurve([IsReadOnly] this in float4x4 m, float time); // 0x0000000188A6286C-0x0000000188A62874
	}

	public static class MathUtility // TypeDefIndex: 78036
	{
		// Methods
		public static void ComputeVirtualParentWithoutLocal(float3 fromPos, quaternion fromRot, float3 toPos, quaternion toRot, out float3 dPos, out quaternion dRot); // 0x0000000188A634AC-0x0000000188A635A4
		public static float Clamp1(float a); // 0x0000000188A629AC-0x0000000188A629C4
		public static double Clamp1(double a); // 0x0000000188A62994-0x0000000188A629AC
		public static double3 Project([IsReadOnly] in double3 v, [IsReadOnly] in double3 n); // 0x00000001889DA44C-0x00000001889DA4D4
		public static double3 ProjectOnPlane([IsReadOnly] in double3 v, [IsReadOnly] in double3 n); // 0x0000000188A4A800-0x0000000188A4C9C4
		public static float3 mul(quaternion q, float3 v); // 0x00000001889EC46C-0x00000001889EC4BC
		public static double3 mul(quaternion q, double3 v); // 0x0000000188A6654C-0x0000000188A66710
		public static float Angle([IsReadOnly] in float3 v1, [IsReadOnly] in float3 v2); // 0x00000001889EBE34-0x00000001889EBF04
		public static double Angle([IsReadOnly] in double3 v1, [IsReadOnly] in double3 v2); // 0x00000001889CA1AC-0x00000001889CA310
		public static float3 ClampVector(float3 v, float minlength, float maxlength); // 0x0000000188A62E50-0x0000000188A62F24
		public static float3 ClampVector(float3 v, float maxlength); // 0x0000000188A1B6C0-0x0000000188A1B76C
		public static double3 ClampVector(double3 v, double maxlength); // 0x0000000188A62F24-0x0000000188A62FD8
		public static double3 ClampDistance(double3 from, double3 to, double maxlength); // 0x0000000188A62D74-0x0000000188A62E50
		public static bool ClampAngle([IsReadOnly] in double3 dir, [IsReadOnly] in double3 basedir, double maxAngle, out double3 outdir); // 0x0000000188A629C4-0x0000000188A62CF0
		public static quaternion FromToRotation([IsReadOnly] in double3 from, [IsReadOnly] in double3 to, double t = 1 /* Metadata: 0x0262A26D */); // 0x0000000188A6378C-0x0000000188A63A38
		public static quaternion FromToRotation([IsReadOnly] in quaternion from, [IsReadOnly] in quaternion to); // 0x0000000188A1B76C-0x0000000188A1BBE4
		public static float Angle([IsReadOnly] in quaternion a, [IsReadOnly] in quaternion b); // 0x0000000188A1B638-0x0000000188A1B6C0
		public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle); // 0x0000000188A62CF0-0x0000000188A62D74
		public static quaternion ToRotation([IsReadOnly] in float3 nor, [IsReadOnly] in float3 tan); // 0x0000000188A65264-0x0000000188A652B8
		public static void ToNormalTangent([IsReadOnly] in quaternion rot, out float3 nor, out float3 tan); // 0x0000000188A1BCB0-0x0000000188A1C008
		public static float3 ToNormal([IsReadOnly] in quaternion rot); // 0x0000000188A6520C-0x0000000188A65264
		public static float3 ToTangent([IsReadOnly] in quaternion rot); // 0x0000000188A652B8-0x0000000188A65310
		public static float3 ToBinormal([IsReadOnly] in quaternion rot); // 0x0000000188A651B8-0x0000000188A6520C
		public static float3 Binormal([IsReadOnly] in float3 nor, [IsReadOnly] in float3 tan); // 0x0000000188A628EC-0x0000000188A62944
		public static float3 AxisToEuler([IsReadOnly] in float3 axis); // 0x0000000188A3F254-0x0000000188A40034
		public static quaternion AxisQuaternion(float3 dir); // 0x0000000188A3F20C-0x0000000188A3F254
		public static void ToAngleAxis([IsReadOnly] in quaternion q, out float angle, out float3 axis); // 0x0000000188A1BBE4-0x0000000188A1BCB0
		public static float ClosestPtPointSegmentRatio([IsReadOnly] in double3 c, [IsReadOnly] in double3 a, [IsReadOnly] in double3 b); // 0x00000001889D989C-0x00000001889D99B4
		public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b); // 0x0000000188A63124-0x0000000188A631FC
		public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b); // 0x0000000188A631FC-0x0000000188A6335C
		public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b); // 0x0000000188A62FD8-0x0000000188A63124
		public static double ClosestPtSegmentSegment([IsReadOnly] in double3 p1, [IsReadOnly] in double3 q1, [IsReadOnly] in double3 p2, [IsReadOnly] in double3 q2, out double s, out double t, out double3 c1, out double3 c2); // 0x00000001889D9D24-0x00000001889DA25C
		public static void ClosestPtSegmentSegment2([IsReadOnly] in double3 p1, [IsReadOnly] in double3 q1, [IsReadOnly] in double3 p2, [IsReadOnly] in double3 q2, out double s, out double t); // 0x00000001889D99B4-0x00000001889D9D24
		public static double3 ClosestPtPointTriangle([IsReadOnly] in double3 p, [IsReadOnly] in double3 a, [IsReadOnly] in double3 b, [IsReadOnly] in double3 c, out double3 uvw); // 0x00000001889F5180-0x00000001889F5868
		public static bool PointInTriangleUVW(float3 uvw); // 0x0000000188A64C38-0x0000000188A64C74
		public static float3 TriangleCenter([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2); // 0x0000000188A66070-0x0000000188A66124
		public static float3 TriangleNormal([IsReadOnly] in double3 p0, [IsReadOnly] in double3 p1, [IsReadOnly] in double3 p2); // 0x00000001889DA4D4-0x00000001889DAF04
		public static float TriangleArea([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2); // 0x0000000188A5D0A0-0x0000000188A5D2C4
		public static bool IsSafeTriangle([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2); // 0x0000000188A64B24-0x0000000188A64B3C
		public static float3 TriangleTangent([IsReadOnly] in float3 p0, [IsReadOnly] in float3 p1, [IsReadOnly] in float3 p2, [IsReadOnly] in float2 uv0, [IsReadOnly] in float2 uv1, [IsReadOnly] in float2 uv2); // 0x0000000188A6635C-0x0000000188A6654C
		public static double3 TriangleTangent([IsReadOnly] in double3 p0, [IsReadOnly] in double3 p1, [IsReadOnly] in double3 p2, [IsReadOnly] in float2 uv0, [IsReadOnly] in float2 uv1, [IsReadOnly] in float2 uv2); // 0x0000000188A66124-0x0000000188A6635C
		public static float TriangleAngle([IsReadOnly] in float3 v0, [IsReadOnly] in float3 v1, [IsReadOnly] in float3 v2, [IsReadOnly] in float3 v3); // 0x00000001889EC284-0x00000001889EC3CC
		public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2); // 0x0000000188A636C0-0x0000000188A6378C
		public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c); // 0x0000000188A635A4-0x0000000188A636C0
		public static int2 GetRestTriangleVertex(int3 tri1, int3 tri2, int2 edge); // 0x0000000188A63B00-0x0000000188A63B68
		public static int2 GetCommonEdgeFromTrianglePair(int3 tri1, int3 tri2); // 0x0000000188A63A38-0x0000000188A63B00
		public static int4 GetTrianglePairIndices(int3 tri1, int3 tri2); // 0x0000000188A63CBC-0x0000000188A63D6C
		public static int GetUnuseTriangleIndex(int3 tri, int2 edge); // 0x0000000188A63D6C-0x0000000188A63DAC
		public static float GetTrianglePairAngle(float3 pos0, float3 pos1, float3 pos2, float3 pos3); // 0x0000000188A63B68-0x0000000188A63CBC
		public static int3 FlipTriangle([IsReadOnly] in int3 tri); // 0x00000001872343C0-0x0000000187234400
		public static void GetTriangleSphere(float3 pos0, float3 pos1, float3 pos2, out float3 sc, out float sr); // 0x00000001889EBF04-0x00000001889EC090
		public static float4x4 LocalToWorldMatrix([IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x0000000188A0908C-0x0000000188A091A0
		public static double4x4 LocalToWorldMatrix([IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x0000000188A2F2D4-0x0000000188A2F874
		public static float4x4 WorldToLocalMatrix([IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x0000000188A091A0-0x0000000188A092E4
		public static double4x4 WorldToLocalMatrix([IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x0000000188A1C008-0x0000000188A1C108
		public static float3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x0000000188A656A0-0x0000000188A657F4
		public static double3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x0000000188A655A4-0x0000000188A656A0
		public static float3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float4x4 m); // 0x00000001889EC210-0x00000001889EC284
		public static float3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in float4x4 m); // 0x0000000188A65520-0x0000000188A655A4
		public static double3 TransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in double4x4 m); // 0x0000000188A658A0-0x0000000188A65950
		public static double3 TransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double4x4 m); // 0x0000000188A657F4-0x0000000188A658A0
		public static float3 TransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in float4x4 m); // 0x0000000188A5CFEC-0x0000000188A5D0A0
		public static double3 TransformVector([IsReadOnly] in double3 vec, [IsReadOnly] in float4x4 m); // 0x0000000188A65DA0-0x0000000188A65EB4
		public static double3 TransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in double4x4 m); // 0x0000000188A65F84-0x0000000188A66070
		public static double3 TransformVector([IsReadOnly] in double3 vec, [IsReadOnly] in double4x4 m); // 0x0000000188A65EB4-0x0000000188A65F84
		public static float3 TransformDirection([IsReadOnly] in float3 dir, [IsReadOnly] in float4x4 m); // 0x0000000188A65310-0x0000000188A653E8
		public static quaternion TransformRotation([IsReadOnly] in quaternion rot, [IsReadOnly] in double4x4 m, [IsReadOnly] in float3 normalTangentFlip); // 0x0000000188A65AA4-0x0000000188A65DA0
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale); // 0x0000000188A6513C-0x0000000188A651B8
		public static double4x4 TRS(double3 translation, quaternion rotation, float3 scale); // 0x0000000188A64F10-0x0000000188A6513C
		public static float TransformDistance([IsReadOnly] in float dist, [IsReadOnly] in float4x4 localToWorldMatrix); // 0x0000000188A653E8-0x0000000188A65470
		public static void TransformPositionNormalTangent([IsReadOnly] in float3 tpos, [IsReadOnly] in quaternion trot, [IsReadOnly] in float3 tscl, ref float3 pos, ref float3 nor, ref float3 tan); // 0x0000000188A65950-0x0000000188A65AA4
		public static float TransformLength(float length, [IsReadOnly] in float4x4 matrix); // 0x0000000188A65470-0x0000000188A65520
		public static float3 InverseTransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float4x4 worldToLocalMatrix); // 0x00000001889EC210-0x00000001889EC284
		public static double3 InverseTransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double4x4 worldToLocalMatrix); // 0x0000000188A64618-0x0000000188A646BC
		public static float3 InverseTransformPoint([IsReadOnly] in float3 pos, [IsReadOnly] in float3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x0000000188A646BC-0x0000000188A64840
		public static double3 InverseTransformPoint([IsReadOnly] in double3 pos, [IsReadOnly] in double3 wpos, [IsReadOnly] in quaternion wrot, [IsReadOnly] in float3 wscl); // 0x0000000188A64840-0x0000000188A6498C
		public static float3 InverseTransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in float4x4 worldToLocalMatrix); // 0x0000000188A5CFEC-0x0000000188A5D0A0
		public static float3 InverseTransformVector([IsReadOnly] in float3 vec, [IsReadOnly] in quaternion rot); // 0x0000000188A6498C-0x0000000188A649F4
		public static float3 InverseTransformDirection([IsReadOnly] in float3 dir, [IsReadOnly] in float4x4 worldToLocalMatrix); // 0x0000000188A64540-0x0000000188A64618
		public static float4x4 Transform([IsReadOnly] in float4x4 fromLocalToWorldMatrix, [IsReadOnly] in float4x4 toWorldToLocalMatrix); // 0x00000001889CA310-0x00000001889CA684
		public static bool CompareMatrix([IsReadOnly] in float4x4 m1, [IsReadOnly] in float4x4 m2); // 0x0000000188A6335C-0x0000000188A6340C
		public static bool CompareTransform([IsReadOnly] in float3 pos1, [IsReadOnly] in quaternion rot1, [IsReadOnly] in float3 scl1, [IsReadOnly] in float3 pos2, [IsReadOnly] in quaternion rot2, [IsReadOnly] in float3 scl2); // 0x0000000188A6340C-0x0000000188A634AC
		public static bool CompareTransform([IsReadOnly] in double3 pos1, [IsReadOnly] in quaternion rot1, [IsReadOnly] in float3 scl1, [IsReadOnly] in double3 pos2, [IsReadOnly] in quaternion rot2, [IsReadOnly] in float3 scl2); // 0x0000000188A2F230-0x0000000188A2F2D4
		public static bool IntersectSegmentTriangle([IsReadOnly] in float3 p, [IsReadOnly] in float3 q, float3 a, float3 b, float3 c, bool doubleSide, out float u, out float v, out float w, out float t); // 0x0000000188A63DAC-0x0000000188A641E0
		public static bool IntersectSegmentTriangle([IsReadOnly] in float3 p, [IsReadOnly] in float3 q, float3 a, float3 b, float3 c); // 0x0000000188A641E0-0x0000000188A64540
		public static double IntersectPointPlaneDist([IsReadOnly] in double3 planePos, [IsReadOnly] in double3 planeDir, [IsReadOnly] in double3 pos, out double3 outPos); // 0x00000001889DA25C-0x00000001889DA44C
		public static bool IntersectRaySphere([IsReadOnly] in float3 p, [IsReadOnly] in float3 d, [IsReadOnly] in float3 sc, [IsReadOnly] in float sr, ref float t, ref float3 q); // 0x00000001889EC090-0x00000001889EC210
		public static float SqDistPointSegment(Vector3 a, Vector3 b, Vector3 c); // 0x0000000188A64D8C-0x0000000188A64F10
		public static bool IsNaN(float3 v); // 0x0000000188A64A60-0x0000000188A64AA8
		public static bool IsNaN(double3 v); // 0x0000000188A649F4-0x0000000188A64A3C
		public static bool IsNaN(float4 v); // 0x0000000188A64A3C-0x0000000188A64A60
		public static bool IsNaN(quaternion q); // 0x0000000188A64AA8-0x0000000188A64B24
		public static float3 Lerp(float3 x, float3 y, float s); // 0x0000000188A64B3C-0x0000000188A64BB4
		public static double3 Lerp(double3 x, double3 y, double s); // 0x0000000188A64BB4-0x0000000188A64C38
		public static double3 ShiftPosition([IsReadOnly] in double3 oldPos, [IsReadOnly] in double3 oldPivotPosition, [IsReadOnly] in double3 shiftVector, [IsReadOnly] in quaternion shiftRotation); // 0x0000000188A64C74-0x0000000188A64D8C
		public static float CalcMass(float depth); // 0x0000000187234390-0x00000001872343C0
		public static float CalcInverseMass(float friction); // 0x0000000188A62944-0x0000000188A62960
		public static float CalcInverseMass(float friction, float depth); // 0x0000000188A62960-0x0000000188A62994
		public static float CalcInverseMass(float friction, float depth, bool fix, float fixMass); // 0x00000001889D96CC-0x00000001889D989C
		public static float CalcSelfCollisionInverseMass(float friction, bool fix, float clothMass); // 0x00000001889F5148-0x00000001889F5180
	
		// Extension methods
		public static double3 AutoConvertToFloat([IsReadOnly] this in Vector3 v); // 0x0000000185B1AE20-0x0000000185B1AE50
		public static float3 AutoToFloat3([IsReadOnly] this in double3 v); // 0x0000000187234360-0x0000000187234390
	}

	public class MinimumData<T1, T2> // TypeDefIndex: 78037
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

	public struct FTransform // TypeDefIndex: 78038
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 scale; // 0x1C
	
		// Methods
		public static FTransform Default(); // 0x0000000188A60D30-0x0000000188A60D84
	}

	public static class MeshUtility // TypeDefIndex: 78039
	{
		// Methods
		public static Mesh GetSharedMesh(Renderer ren); // 0x0000000188A66710-0x0000000188A66838
		public static bool SetMesh(Renderer ren, Mesh mesh, Transform[] skinBones = null); // 0x0000000188A668EC-0x0000000188A66A24
		public static int GetTransformCount(Renderer ren); // 0x0000000188A66838-0x0000000188A668EC
	}

	public static class Develop // TypeDefIndex: 78040
	{
		// Methods
		public static void Log([IsReadOnly] in object mes); // 0x0000000188A60958-0x0000000188A609BC
		public static void LogWarning([IsReadOnly] in object mes); // 0x0000000188A608F4-0x0000000188A60958
		public static void LogError([IsReadOnly] in object mes); // 0x0000000188A60890-0x0000000188A608F4
		[Conditional("MC2_LOG")]
		public static void DebugLog([IsReadOnly] in object mes); // 0x0000000188A6082C-0x0000000188A60890
		[Conditional("MC2_DEBUG")]
		public static void DebugLogWarning([IsReadOnly] in object mes); // 0x0000000188A607C8-0x0000000188A6082C
		[Conditional("MC2_DEBUG")]
		public static void DebugLogError([IsReadOnly] in object mes); // 0x0000000188A60764-0x0000000188A607C8
		[Conditional("MC2_DEBUG")]
		public static void Assert(bool condition); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class StaticStringBuilder // TypeDefIndex: 78041
	{
		// Fields
		private static StringBuilder stringBuilder; // 0x00
	
		// Properties
		public static StringBuilder Instance { get; } // 0x0000000188A691A4-0x0000000188A691F4 
	
		// Constructors
		public StaticStringBuilder(); // 0x0000000186805BA0-0x0000000186805BB0
		static StaticStringBuilder(); // 0x0000000188A69120-0x0000000188A691A4
	
		// Methods
		public static void Clear(); // 0x0000000188A69070-0x0000000188A690C8
		public static StringBuilder Append(params object[] args); // 0x0000000188A68FC4-0x0000000188A69070
		public static StringBuilder AppendLine(params object[] args); // 0x0000000188A68DFC-0x0000000188A68EDC
		public static StringBuilder AppendLine(); // 0x0000000188A68D80-0x0000000188A68DFC
		public static string AppendToString(params object[] args); // 0x0000000188A68EDC-0x0000000188A68FC4
		public static new string ToString(); // 0x0000000188A690C8-0x0000000188A69120
	}

	public struct DataChunk // TypeDefIndex: 78042
	{
		// Fields
		public int startIndex; // 0x00
		public int dataLength; // 0x04
	
		// Properties
		public bool IsValid { get; } // 0x0000000185B1CEC0-0x0000000185B1CED0 
		public static DataChunk Empty { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	
		// Constructors
		public DataChunk(int sindex, int length); // 0x00000001827241A0-0x00000001827241B0
		public DataChunk(int sindex); // 0x00000001872340F0-0x0000000187234100
	
		// Methods
		public void Clear(); // 0x00000001872340E0-0x00000001872340F0
		public override string ToString(); // 0x0000000188A603D4-0x0000000188A6045C
	}

	[Serializable]
	public struct ExBitFlag16 // TypeDefIndex: 78043
	{
		// Fields
		public ushort Value; // 0x00
	
		// Constructors
		public ExBitFlag16(ushort initialValue = 0 /* Metadata: 0x0262A275 */); // 0x000000018448B8B0-0x000000018448B8C0
	
		// Methods
		public void Clear(); // 0x00000001872342A0-0x00000001872342B0
		public void SetFlag(ushort flag, bool sw); // 0x0000000188A609C4-0x0000000188A609E0
		public bool IsSet(ushort flag); // 0x0000000188A609BC-0x0000000188A609C4
	}

	[Serializable]
	public struct ExBitFlag8 // TypeDefIndex: 78044
	{
		// Fields
		public byte Value; // 0x00
	
		// Constructors
		public ExBitFlag8(byte initialValue = 0 /* Metadata: 0x0262A277 */); // 0x0000000187233BE0-0x0000000187233BF0
	
		// Methods
		public void Clear(); // 0x0000000187233BD0-0x0000000187233BE0
		public void SetFlag(byte flag, bool sw); // 0x00000001889F30DC-0x00000001889F30F0
		public bool IsSet(byte flag); // 0x00000001889F30C8-0x00000001889F30D0
	}

	public struct ExCostSortedList1 : IComparable<BeyondDynamicBone.ExCostSortedList1> // TypeDefIndex: 78045
	{
		// Fields
		internal float cost; // 0x00
		internal int data; // 0x04
	
		// Properties
		public bool IsValid { get; } // 0x0000000188A60AD0-0x0000000188A60AE0 
		public int Count { get; } // 0x0000000188A60AC0-0x0000000188A60AD0 
		public float Cost { get; } // 0x00000001872342D0-0x00000001872342E0 
		public int Data { get; } // 0x00000001872342E0-0x00000001872342F0 
	
		// Constructors
		public ExCostSortedList1(float invalidCost); // 0x00000001872342C0-0x00000001872342D0
		public ExCostSortedList1(float invalidCost, int initData); // 0x00000001872342B0-0x00000001872342C0
	
		// Methods
		public void Add(float cost, int item); // 0x0000000188A609E0-0x0000000188A609FC
		public int CompareTo(ExCostSortedList1 other); // 0x0000000188A609FC-0x0000000188A60A28
		public override string ToString(); // 0x0000000188A60A28-0x0000000188A60AC0
	}

	public struct ExCostSortedList4 // TypeDefIndex: 78046
	{
		// Fields
		internal float4 costs; // 0x00
		internal int4 data; // 0x10
	
		// Properties
		public int Count { get; } // 0x00000001889EBC48-0x00000001889EBC6C 
		public bool IsValid { get; } // 0x0000000188A60AD0-0x0000000188A60AE0 
		public float MinCost { get; } // 0x00000001872342D0-0x00000001872342E0 
		public float MaxCost { get; } // 0x0000000188A60CE4-0x0000000188A60D00 
	
		// Constructors
		public ExCostSortedList4(float invalidCost); // 0x00000001872342F0-0x0000000187234310
	
		// Methods
		public bool Add(float cost, int item); // 0x0000000188A60AE0-0x0000000188A60B58
		public bool Contains(int item); // 0x00000001889EBC20-0x00000001889EBC48
		public int indexOf(int item); // 0x0000000188A60D00-0x0000000188A60D30
		public void RemoveItem(int item); // 0x0000000188A60B58-0x0000000188A60BC0
		public override string ToString(); // 0x0000000188A60BC0-0x0000000188A60CE4
	}

	public class ExNativeArray<T> : IDisposable // TypeDefIndex: 78047
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
		public ExNativeArray(int emptyLength, bool create = false /* Metadata: 0x0262A278 */);
		public ExNativeArray(int emptyLength, T fillData);
		public ExNativeArray(NativeArray<T> dataArray);
		public ExNativeArray(T[] dataArray);
	
		// Methods
		public void Dispose();
		public DataChunk AddRange(int dataLength);
		public DataChunk AddRange(int dataLength, T fillData = default);
		public DataChunk AddRange(T[] array);
		public DataChunk AddRange(NativeArray<T> narray, int length = 0 /* Metadata: 0x0262A279 */);
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

	public class ExProcessingList<T> : IDisposable, IValid // TypeDefIndex: 78048
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

	public class ExSimpleNativeArray<T> : IDisposable // TypeDefIndex: 78050
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
		public class SerializationData // TypeDefIndex: 78049
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
		public ExSimpleNativeArray(int dataLength, bool areaOnly = false /* Metadata: 0x0262A27A */);
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
		private void Expand(int dataLength, bool force = false /* Metadata: 0x0262A27B */, bool copy = true /* Metadata: 0x0262A27C */);
		public override string ToString();
		public SerializationData Serialize();
		public bool Deserialize(SerializationData data);
	}

	public class ExTransformAccessArray : IDisposable // TypeDefIndex: 78051
	{
		// Fields
		private TransformAccessArray transformArray; // 0x10
		private int nativeLength; // 0x18
		private Queue<int> emptyStack; // 0x20
		private Dictionary<int, int> useIndexDict; // 0x28
		private Dictionary<int, int> indexDict; // 0x30
		private Dictionary<int, int> referenceDict; // 0x38
	
		// Properties
		public int Count { get; } // 0x0000000188A6BC24-0x0000000188A6BC64 
		public int Length { get; } // 0x00000001844AF510-0x00000001844AF520 
		public Transform this[int index] { get => default; } // 0x0000000188A6BC64-0x0000000188A6BC74 
	
		// Constructors
		public ExTransformAccessArray(int capacity, int desiredJobCount = -1 /* Metadata: 0x0262A27D */); // 0x0000000188A6BAB4-0x0000000188A6BC24
	
		// Methods
		public void Dispose(); // 0x0000000188A6B6EC-0x0000000188A6B798
		public TransformAccessArray GetTransformAccessArray(); // 0x00000001829260F0-0x0000000182926100
		public int Add(Transform element); // 0x0000000188A6B314-0x0000000188A6B4EC
		public void Remove(int index); // 0x0000000188A6B93C-0x0000000188A6BAB4
		public bool Exist(int index); // 0x0000000188A6B798-0x0000000188A6B7EC
		public bool Exist(Transform element); // 0x0000000188A6B7EC-0x0000000188A6B880
		public int GetIndex(Transform element); // 0x0000000188A6B880-0x0000000188A6B93C
		public void Clear(); // 0x0000000188A6B4EC-0x0000000188A6B6EC
	}

	public static class FixedList128BytesExtensions // TypeDefIndex: 78052
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

	public static class FixedList32BytesExtensions // TypeDefIndex: 78053
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

	public static class FixedList4096BytesExtensions // TypeDefIndex: 78054
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

	public static class FixedList512BytesExtensions // TypeDefIndex: 78055
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

	public static class FixedList64BytesExtensions // TypeDefIndex: 78056
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

	public static class NativeArrayExtensions // TypeDefIndex: 78057
	{
		// Methods
		public static NativeArray<T> MC2FromRawBytes<T>(byte[] bytes, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0262A280 */)
			where T : struct;
	
		// Extension methods
		public static void MC2DisposeSafe<T>(this ref NativeArray<T> array)
			where T : struct;
		public static void MC2Resize<T>(this ref NativeArray<T> array, int size, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0262A27E */, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x0262A27F */)
			where T : struct;
		public static byte[] MC2ToRawBytes<T>(this ref NativeArray<T> array)
			where T : struct;
	}

	public static class NativeMultiHashMapExtensions // TypeDefIndex: 78059
	{
		// Nested types
		[BurstCompile]
		private struct SetParallelMultiHashMapJob<TKey, TValue> : IJob // TypeDefIndex: 78058
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
		public static NativeParallelMultiHashMap<int2, ushort> MC2Deserialize(int2[] keyArray, ushort[] valueArray); // 0x0000000186262610-0x00000001862628A0
	
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

	public static class NativeParallelHashMap // TypeDefIndex: 78060
	{
		// Extension methods
		public static void MC2DisposeSafe<TKey, TValue>(this ref NativeParallelHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue>;
	}

	internal static class NativeReferenceExtensions // TypeDefIndex: 78061
	{
		// Methods
		public static unsafe int MC2InterlockedStartIndex(int* cntPt, int dataCount); // 0x0000000187234420-0x0000000187234430
	
		// Extension methods
		public static int MC2InterlockedStartIndex(this ref NativeReference<int> counter, int dataCount); // 0x0000000188A6C5F8-0x0000000188A6C638
	}

	public class PlayerLoopUtils // TypeDefIndex: 78063
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 78062
		{
			// Fields
			public string categoryName; // 0x10
			public string systemName; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _AddPlayerLoop_b__0(PlayerLoopSystem s); // 0x0000000186B30B30-0x0000000186B30B70
			internal bool _AddPlayerLoop_b__1(PlayerLoopSystem h); // 0x00000001869F4780-0x00000001869F47C0
		}
	
		// Constructors
		public PlayerLoopUtils(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void AddPlayerLoop(PlayerLoopSystem method, ref PlayerLoopSystem playerLoop, string categoryName, string systemName, bool last = false /* Metadata: 0x0262A281 */, bool before = false /* Metadata: 0x0262A282 */); // 0x0000000185BBB7B0-0x0000000185BBBAF0
	}

	[Serializable]
	public class MagicaClothProcessingException : Exception // TypeDefIndex: 78064
	{
		// Constructors
		public MagicaClothProcessingException(); // 0x0000000188A6C4F0-0x0000000188A6C53C
		public MagicaClothProcessingException(string message); // 0x0000000188A6C59C-0x0000000188A6C5F8
		public MagicaClothProcessingException(string message, Exception inner); // 0x0000000188A6C53C-0x0000000188A6C59C
	}

	[Serializable]
	public class MagicaClothCanceledException : Exception // TypeDefIndex: 78065
	{
		// Constructors
		public MagicaClothCanceledException(); // 0x0000000188A6C448-0x0000000188A6C494
		public MagicaClothCanceledException(string message); // 0x0000000188A6C494-0x0000000188A6C4F0
		public MagicaClothCanceledException(string message, Exception inner); // 0x0000000188A6C3E8-0x0000000188A6C448
	}

	[Serializable]
	public struct ResultCode // TypeDefIndex: 78066
	{
		// Fields
		[SerializeField]
		private Define.Result result; // 0x00
		[SerializeField]
		private Define.Result warning; // 0x04
	
		// Properties
		public Define.Result Result { get; } // 0x0000000187234510-0x0000000187234520 
		public static ResultCode None { get; } // 0x00000001872344F0-0x0000000187234510 
		public static ResultCode Empty { get; } // 0x00000001872344B0-0x00000001872344D0 
		public static ResultCode Success { get; } // 0x0000000187234520-0x0000000187234540 
		public static ResultCode Error { get; } // 0x00000001872344D0-0x00000001872344F0 
	
		// Constructors
		public ResultCode(Define.Result initResult); // 0x0000000187234490-0x00000001872344B0
	
		// Methods
		public void Clear(); // 0x0000000187234430-0x0000000187234450
		public void SetResult(Define.Result code); // 0x0000000187234460-0x0000000187234470
		public void SetSuccess(); // 0x0000000187234480-0x0000000187234490
		public void SetCancel(); // 0x0000000187234450-0x0000000187234460
		public void SetError(Define.Result code = Define.Result.Error /* Metadata: 0x0262A283 */); // 0x0000000187234460-0x0000000187234470
		public void SetWarning(Define.Result code = Define.Result.Warning /* Metadata: 0x0262A287 */); // 0x0000000188A6C978-0x0000000188A6C988
		public void Merge(ResultCode src); // 0x0000000185D78A70-0x0000000185D78AA0
		public void SetProcess(); // 0x0000000187234470-0x0000000187234480
		public bool IsResult(Define.Result code); // 0x0000000188A6C968-0x0000000188A6C978
		public bool IsNone(); // 0x0000000188A6C938-0x0000000188A6C948
		public bool IsSuccess(); // 0x0000000185D7A690-0x0000000185D7A6B0
		public bool IsFaild(); // 0x0000000185D7A670-0x0000000185D7A690
		public bool IsCancel(); // 0x0000000188A6C928-0x0000000188A6C938
		public bool IsNormal(); // 0x0000000188A6C948-0x0000000188A6C958
		public bool IsError(); // 0x0000000185D78EE0-0x0000000185D78F00
		public bool IsProcess(); // 0x0000000188A6C958-0x0000000188A6C968
		public bool IsWarning(); // 0x0000000185D78AA0-0x0000000185D78AB0
		public string GetResultString(); // 0x0000000188A6C748-0x0000000188A6C820
		public string GetWarningString(); // 0x0000000188A6C888-0x0000000188A6C928
		public string GetResultInformation(); // 0x0000000188A6C658-0x0000000188A6C748
		public string GetWarningInformation(); // 0x0000000188A6C820-0x0000000188A6C888
		[Conditional("MC2_DEBUG")]
		public void DebugLog(bool error = true /* Metadata: 0x0262A28B */, bool warning = true /* Metadata: 0x0262A28C */, bool normal = true /* Metadata: 0x0262A28D */); // 0x0000000188A6C638-0x0000000188A6C658
	}

	public class TimeSpan // TypeDefIndex: 78067
	{
		// Fields
		private string name; // 0x10
		private System.DateTime stime; // 0x18
		private System.DateTime etime; // 0x20
	
		// Constructors
		public TimeSpan(); // 0x0000000188A6D338-0x0000000188A6D380
		public TimeSpan(string name); // 0x0000000188A6D380-0x0000000188A6D408
	
		// Methods
		public void Start(); // 0x0000000188A6D158-0x0000000188A6D1A4
		public void Finish(); // 0x0000000188A6D0F0-0x0000000188A6D13C
		public double TotalSeconds(); // 0x0000000188A6D2AC-0x0000000188A6D338
		public double TotalMilliSeconds(); // 0x0000000188A6D220-0x0000000188A6D2AC
		public override string ToString(); // 0x0000000188A6D1A4-0x0000000188A6D220
		public void DebugLog(); // 0x0000000186805BA0-0x0000000186805BB0
		public void Log(); // 0x0000000188A6D13C-0x0000000188A6D158
	}

	public class UnityTimeSpan // TypeDefIndex: 78068
	{
		// Fields
		private string name; // 0x10
		private float stime; // 0x18
		private float etime; // 0x1C
		private bool isFinish; // 0x20
	
		// Constructors
		public UnityTimeSpan(string name); // 0x0000000188A6D540-0x0000000188A6D5B0
	
		// Methods
		public void Finish(); // 0x0000000188A6D454-0x0000000188A6D47C
		public float TotalSeconds(); // 0x0000000188A6D520-0x0000000188A6D540
		public float TotalMilliSeconds(); // 0x0000000188A6D4F8-0x0000000188A6D520
		public override string ToString(); // 0x0000000188A6D47C-0x0000000188A6D4F8
		public void DebugLog(); // 0x0000000188A6D408-0x0000000188A6D454
	}

	public class VirtualMesh : IDisposable, IValid // TypeDefIndex: 78126
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
		public TransformData transformData; // 0x140
		public NativeReference<AABB> boundingBox; // 0x148
		public NativeReference<float> averageVertexDistance; // 0x158
		public NativeReference<float> maxVertexDistance; // 0x168
		public DataChunk mergeChunk; // 0x178
		public NativeArray<int> joinIndices; // 0x180
		public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x190
		public NativeArray<uint> vertexToVertexIndexArray; // 0x1A0
		public NativeArray<ushort> vertexToVertexDataArray; // 0x1B0
		public NativeArray<int2> edges; // 0x1C0
		public const byte EdgeFlag_Cut = 1; // Metadata: 0x0262A292
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
		public const byte BaseLineFlag_IncludeLine = 1; // Metadata: 0x0262A293
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
		public float InitCalcScale { get; } // 0x0000000187234540-0x0000000187234550 
		public bool IsSuccess { get; } // 0x0000000188A77630-0x0000000188A7763C 
		public bool IsError { get; } // 0x000000018783BCDC-0x000000018783BCE8 
		public bool IsProcess { get; } // 0x0000000188A7760C-0x0000000188A7761C 
		public int VertexCount { get; } // 0x00000001861D53D0-0x00000001861D53F0 
		public int TriangleCount { get; } // 0x00000001862642C0-0x00000001862642E0 
		public int LineCount { get; } // 0x0000000186264280-0x00000001862642C0 
		public int SkinBoneCount { get; } // 0x0000000188A7767C-0x0000000188A77870 
		public int TransformCount { get; } // 0x0000000185B93900-0x0000000185B93920 
		public bool IsProxy { get; } // 0x0000000188A7761C-0x0000000188A77630 
		public bool IsMapping { get; } // 0x0000000188A77604-0x0000000188A7760C 
		public int BaseLineCount { get; } // 0x0000000186266680-0x00000001862666D0 
		public int EdgeCount { get; } // 0x0000000186266660-0x0000000186266680 
		public int CustomSkinningBoneCount { get; } // 0x0000000188A775F0-0x0000000188A77604 
		public int CenterFixedPointCount { get; } // 0x0000000185B93FA0-0x0000000185B93FC0 
		public int NormalAdjustmentRotationCount { get; } // 0x0000000188A7763C-0x0000000188A7767C 
	
		// Nested types
		[BurstCompile]
		private struct Import_GenerateTangentJob : IJobParallelFor // TypeDefIndex: 78069
		{
			// Fields
			[ReadOnly]
			public NativeArray<float3> localNormals; // 0x00
			[WriteOnly]
			public NativeArray<float3> localTangents; // 0x10
	
			// Methods
			public void Execute(int vindex); // 0x0000000188A6C2E4-0x0000000188A6C3E8
		}
	
		[BurstCompile]
		private struct Import_CalcSkinningJob : IJobParallelFor // TypeDefIndex: 78070
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
			public void Execute(int vindex); // 0x0000000188A6BD58-0x0000000188A6C2E4
		}
	
		[BurstCompile]
		private struct Import_BoneWeightJob1 : IJob // TypeDefIndex: 78071
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			[WriteOnly]
			public NativeArray<int> startBoneWeightIndices; // 0x18
	
			// Methods
			public void Execute(); // 0x0000000188A6BC74-0x0000000188A6BCA0
		}
	
		[BurstCompile]
		private struct Import_BoneWeightJob2 : IJobParallelFor // TypeDefIndex: 78072
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
			public void Execute(int vindex); // 0x0000000188A6BCA0-0x0000000188A6BD58
		}
	
		[BurstCompile]
		private struct Import_BoneVertexJob : IJobParallelFor // TypeDefIndex: 78073
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
			public void Execute(int vindex); // 0x00000001859DFBE0-0x00000001859E0200
		}
	
		[BurstCompile]
		private struct Select_PackVertexJob : IJob // TypeDefIndex: 78074
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
			public void Execute(); // 0x0000000188A6CFAC-0x0000000188A6D0F0
		}
	
		[BurstCompile]
		private struct Select_GridJob : IJob // TypeDefIndex: 78075
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
			public void Execute(); // 0x0000000188A6C988-0x0000000188A6CFAC
		}
	
		[BurstCompile]
		private struct Add_CalcBindPoseJob : IJobParallelFor // TypeDefIndex: 78076
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
			public void Execute(int boneIndex); // 0x0000000188A6AF98-0x0000000188A6B0F0
		}
	
		[BurstCompile]
		private struct Add_CopyVerticesJob : IJobParallelFor // TypeDefIndex: 78077
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
			public void Execute(int vindex); // 0x0000000188A6B0F0-0x0000000188A6B314
		}
	
		private struct MappingWorkData // TypeDefIndex: 78078
		{
			// Fields
			public float3 position; // 0x00
			public int vertexIndex; // 0x0C
			public int proxyVertexIndex; // 0x10
			public float proxyVertexDistance; // 0x14
		}
	
		[BurstCompile]
		private struct Mapping_DirectConnectionVertexDataJob : IJob // TypeDefIndex: 78079
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
			public void Execute(); // 0x00000001889EE8E4-0x00000001889EEA94
		}
	
		private struct Mapping_CalcDirectWeightJob : IJob // TypeDefIndex: 78080
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
			public void Execute(); // 0x00000001889EDFC8-0x00000001889EE4C8
		}
	
		[BurstCompile]
		private struct Mapping_CalcConnectionVertexDataJob : IJob // TypeDefIndex: 78081
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
			public void Execute(); // 0x00000001889ED858-0x00000001889EDFC8
		}
	
		[BurstCompile]
		private struct Mapping_CalcWeightJob : IJobParallelFor // TypeDefIndex: 78082
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
			public void Execute(int vindex); // 0x00000001889EE4C8-0x00000001889EE8E4
		}
	
		[BurstCompile]
		private struct Optimize_EdgeToTrianlgeJob : IJob // TypeDefIndex: 78083
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
			public void Execute(); // 0x00000001889EEA94-0x00000001889EF63C
		}
	
		[BurstCompile]
		private struct ProxyNormalRadiationAdjustmentJob : IJobParallelFor // TypeDefIndex: 78084
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
			public void Execute(int vindex); // 0x00000001889F0368-0x00000001889F0950
		}
	
		[BurstCompile]
		private struct ProxyCreateFixedListAndAABBJob : IJob // TypeDefIndex: 78085
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
			public void Execute(); // 0x00000001865AE600-0x00000001865AEB50
		}
	
		[BurstCompile]
		private struct Proxy_CalcTriangleNormalJob : IJobParallelFor // TypeDefIndex: 78086
		{
			// Fields
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x00
			[ReadOnly]
			public NativeArray<float3> localPositins; // 0x10
			[WriteOnly]
			public NativeArray<float3> triangleNormals; // 0x20
	
			// Methods
			public void Execute(int tindex); // 0x00000001889F0D54-0x00000001889F0E80
		}
	
		[BurstCompile]
		private struct Proxy_CalcTriangleTangentJob : IJobParallelFor // TypeDefIndex: 78087
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
			public void Execute(int tindex); // 0x00000001889F0E80-0x00000001889F0FA0
		}
	
		[BurstCompile]
		private struct Proxy_CreateVertexToTrianglesJob : IJob // TypeDefIndex: 78088
		{
			// Fields
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x00
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x10
	
			// Methods
			public void Execute(); // 0x00000001889F1410-0x00000001889F1528
		}
	
		[BurstCompile]
		private struct Proxy_OrganizeVertexToTrianglsJob : IJobParallelFor // TypeDefIndex: 78089
		{
			// Fields
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x00
			[ReadOnly]
			public NativeArray<float3> triangleNormals; // 0x10
			[ReadOnly]
			public NativeArray<float3> triangleTangents; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
	
			// Methods
			public void Execute(int vindex); // 0x00000001889F1528-0x00000001889F1C6C
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexNormalTangentFromTriangleJob : IJobParallelFor // TypeDefIndex: 78090
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
			public void Execute(int vindex); // 0x00000001889F0FA0-0x00000001889F1260
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToTransformJob : IJobParallelFor // TypeDefIndex: 78091
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
			public void Execute(int vindex); // 0x0000000185B95060-0x0000000185B95190
		}
	
		[BurstCompile]
		private struct Proxy_CalcEdgeToTriangleJob : IJob // TypeDefIndex: 78092
		{
			// Fields
			public int tcnt; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889F0C40-0x00000001889F0D54
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexBindPoseJob2 : IJobParallelFor // TypeDefIndex: 78093
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
			public void Execute(int vindex); // 0x0000000185B95190-0x0000000185B95350
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToVertexFromTriangleJob : IJob // TypeDefIndex: 78094
		{
			// Fields
			public int triangleCount; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<int, ushort> vertexToVertexMap; // 0x18
			public NativeParallelHashSet<int2> edgeSet; // 0x28
	
			// Methods
			public void Execute(); // 0x00000001889F1260-0x00000001889F1410
		}
	
		[BurstCompile]
		private struct Proxy_CalcVertexToVertexFromLineJob : IJob // TypeDefIndex: 78095
		{
			// Fields
			public int lineCount; // 0x00
			[ReadOnly]
			public NativeArray<int2> lines; // 0x08
			public NativeParallelMultiHashMap<int, ushort> vertexToVertexMap; // 0x18
			public NativeParallelHashSet<int2> edgeSet; // 0x28
	
			// Methods
			public void Execute(); // 0x00000001868A9570-0x00000001868A9660
		}
	
		[BurstCompile]
		private struct Proxy_CreateEdgeFlagJob : IJobParallelFor // TypeDefIndex: 78096
		{
			// Fields
			[ReadOnly]
			public NativeArray<int2> edges; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x10
			[WriteOnly]
			public NativeArray<ExBitFlag8> edgeFlags; // 0x20
	
			// Methods
			public void Execute(int eindex); // 0x0000000185B95A10-0x0000000185B95A70
		}
	
		private struct SkinningBoneInfo // TypeDefIndex: 78097
		{
			// Fields
			public int parentTransformIndex; // 0x00
			public float3 parentPos; // 0x04
			public int childTransformIndex; // 0x10
			public float3 childPos; // 0x14
		}
	
		[BurstCompile]
		private struct Proxy_CalcCustomSkinningWeightsJobV2 : IJobParallelFor // TypeDefIndex: 78098
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
			public void Execute(int vindex); // 0x00000001889F0950-0x00000001889F0C40
		}
	
		[BurstCompile]
		private struct Proxy_ApplySelectionJob : IJobParallelFor // TypeDefIndex: 78099
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
			public void Execute(int vindex); // 0x0000000185B96D60-0x0000000185B97810
		}
	
		[BurstCompile]
		private struct Proxy_BoneClothApplayTransformFlagJob : IJobParallelFor // TypeDefIndex: 78100
		{
			// Fields
			[ReadOnly]
			public NativeArray<VertexAttribute> attributes; // 0x00
			public NativeArray<ExBitFlag8> transformFlags; // 0x10
	
			// Methods
			public void Execute(int vindex); // 0x0000000185B1B390-0x0000000185B1B510
		}
	
		private struct BaseLineWork : IComparable<BaseLineWork> // TypeDefIndex: 78101
		{
			// Fields
			public int vindex; // 0x00
			public float dist; // 0x04
	
			// Methods
			public int CompareTo(BaseLineWork other); // 0x00000001889ECC68-0x00000001889ECC8C
		}
	
		[BurstCompile]
		private struct BaseLine_Mesh_CreateParentJob2 : IJob // TypeDefIndex: 78102
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
			public void Execute(); // 0x00000001889ECD88-0x00000001889ED858
		}
	
		[BurstCompile]
		private struct BaseLine_Mesh_CareteFixedListJob : IJob // TypeDefIndex: 78103
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<VertexAttribute> attribues; // 0x08
			public NativeList<int> fixedList; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889ECCF0-0x00000001889ECD88
		}
	
		[BurstCompile]
		private struct BaseLine_Bone_CreateBoneChildInfoJob : IJob // TypeDefIndex: 78104
		{
			// Fields
			public int vcnt; // 0x00
			[ReadOnly]
			public NativeArray<int> parentIndices; // 0x08
			[WriteOnly]
			public NativeParallelMultiHashMap<int, ushort> childMap; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889ECC8C-0x00000001889ECCF0
		}
	
		[BurstCompile]
		private struct BaseLine_CalcLocalPositionRotationJob : IJobParallelFor // TypeDefIndex: 78105
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
			public void Execute(int index); // 0x0000000185B953F0-0x0000000185B95850
		}
	
		[BurstCompile]
		private struct BaseLine_CalcMaxBaseLineLengthJob : IJob // TypeDefIndex: 78106
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
			public void Execute(); // 0x0000000185B96A60-0x0000000185B96D60
		}
	
		[BurstCompile]
		private struct Reduction_InitVertexToVertexJob2 : IJob // TypeDefIndex: 78107
		{
			// Fields
			public int triangleCount; // 0x00
			[ReadOnly]
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889F1C6C-0x00000001889F1D90
		}
	
		[BurstCompile]
		private struct Organize_RemapVertexJob : IJob // TypeDefIndex: 78108
		{
			// Fields
			public int oldVertexCount; // 0x00
			[ReadOnly]
			public NativeArray<int> joinIndices; // 0x08
			public NativeArray<int> vertexRemapIndices; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889F030C-0x00000001889F0368
		}
	
		[BurstCompile]
		private struct Organize_CollectUseSkinBoneJob : IJob // TypeDefIndex: 78109
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
			public void Execute(); // 0x00000001889EF63C-0x00000001889EF9C4
		}
	
		[BurstCompile]
		private struct Organize_CopyVertexJob : IJobParallelFor // TypeDefIndex: 78110
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
			public void Execute(int index); // 0x00000001889EF9C4-0x00000001889EFA78
		}
	
		[BurstCompile]
		private struct Organize_RemapBoneWeightJob : IJobParallelFor // TypeDefIndex: 78111
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
			public void Execute(int vindex); // 0x00000001889F00C0-0x00000001889F019C
		}
	
		[BurstCompile]
		private struct Organize_RemapLinkPointArrayJob : IJobParallelFor // TypeDefIndex: 78112
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
			public void Execute(int vindex); // 0x00000001889F019C-0x00000001889F030C
		}
	
		[BurstCompile]
		private struct Organize_CreateLineTriangleJob : IJob // TypeDefIndex: 78113
		{
			// Fields
			public int newVertexCount; // 0x00
			[ReadOnly]
			public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x08
			[WriteOnly]
			public NativeParallelHashSet<int2> edgeSet; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889EFDD8-0x00000001889EFF5C
		}
	
		[BurstCompile]
		private struct Organize_CreateLineTriangleJob2 : IJob // TypeDefIndex: 78114
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
			public void Execute(); // 0x00000001889EFA78-0x00000001889EFDD8
		}
	
		[BurstCompile]
		private struct Organize_CreateNewTriangleJob3 : IJob // TypeDefIndex: 78115
		{
			// Fields
			[WriteOnly]
			public NativeList<int3> newTriangleList; // 0x00
			[ReadOnly]
			public NativeParallelHashSet<int3> triangleSet; // 0x10
	
			// Methods
			public void Execute(); // 0x00000001889EFF5C-0x00000001889F00C0
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 78116
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
			public TransformData.ShareSerializationData transformData; // 0x130
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
			public ShareSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public override string ToString(); // 0x00000001889F2884-0x00000001889F2ADC
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 78117
		{
			// Fields
			public TransformData.UniqueSerializationData transformData; // 0x10
	
			// Constructors
			public UniqueSerializationData(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet); // 0x00000001889F2EA0-0x00000001889F2EB4
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict); // 0x00000001889F2EB4-0x00000001889F2EC8
		}
	
		[BurstCompile]
		private struct Work_AverageTriangleDistanceJob : IJob // TypeDefIndex: 78118
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
			public void Execute(); // 0x00000001889F3D38-0x00000001889F3F78
		}
	
		[BurstCompile]
		private struct Work_AverageLineDistanceJob : IJob // TypeDefIndex: 78119
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
			public void Execute(); // 0x0000000186837E00-0x0000000186838040
		}
	
		[BurstCompile]
		private struct Work_AddVertexIndexGirdMapJob : IJob // TypeDefIndex: 78120
		{
			// Fields
			public float gridSize; // 0x00
			public int vcnt; // 0x04
			[ReadOnly]
			public NativeArray<float3> positins; // 0x08
			[WriteOnly]
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x18
	
			// Methods
			public void Execute(); // 0x00000001889F3CA4-0x00000001889F3D38
		}
	
		[BurstCompile]
		private struct Work_IntersectTriangleJob : IJobParallelFor // TypeDefIndex: 78121
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
			public void Execute(int tindex); // 0x00000001889F4370-0x00000001889F46E0
		}
	
		[BurstCompile]
		private struct Work_IntersectEdgeJob : IJobParallelFor // TypeDefIndex: 78122
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
			public void Execute(int eindex); // 0x00000001889F3F78-0x00000001889F41E4
		}
	
		[BurstCompile]
		private struct Work_IntersectPointJob : IJobParallelFor // TypeDefIndex: 78123
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
			public void Execute(int vindex); // 0x00000001889F41E4-0x00000001889F4370
		}
	
		[BurstCompile]
		private struct Work_IntersetcSortJob : IJob // TypeDefIndex: 78124
		{
			// Fields
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x00
	
			// Methods
			public void Execute(); // 0x00000001889F46E0-0x00000001889F4748
		}
	
		public enum MeshType // TypeDefIndex: 78125
		{
			NormalMesh = 0,
			NormalBoneMesh = 1,
			ProxyMesh = 2,
			ProxyBoneMesh = 3,
			Mapping = 4
		}
	
		// Constructors
		public VirtualMesh(); // 0x0000000186260590-0x0000000186260870
		public VirtualMesh(bool initialize); // 0x0000000186261C10-0x0000000186262000
		public VirtualMesh(string name); // 0x00000001862610B0-0x00000001862610F0
	
		// Methods
		public void ImportFrom(RenderSetupData rsetup); // 0x0000000185B94410-0x0000000185B947F0
		private void ImportMeshType(RenderSetupData rsetup, int[] transformIndices); // 0x0000000188A7027C-0x0000000188A70B8C
		private void ImportMeshSkinning(); // 0x0000000188A70024-0x0000000188A7027C
		private void ImportBoneType(RenderSetupData rsetup, int[] transformIndices); // 0x00000001854541E0-0x0000000185456E20
		public void ImportFrom(RenderData renderData); // 0x0000000188A6FED0-0x0000000188A70024
		public void SelectionMesh(SelectionData selectionData, float4x4 selectionLocalToWorldMatrix, float mergin); // 0x0000000188A74AE0-0x0000000188A75B70
		public float CalcSelectionMergin(ReductionSettings settings); // 0x0000000188A6E44C-0x0000000188A6E514
		public void AddMesh(VirtualMesh cmesh); // 0x0000000188A6D5B0-0x0000000188A6E44C
		public void SetTransform(Transform center, Transform skinRoot = null, int centerId = 0 /* Metadata: 0x0262A28E */, int skinRootId = 0 /* Metadata: 0x0262A28F */); // 0x0000000188A761B4-0x0000000188A763B0
		public void SetTransform(TransformRecord centerRecord, TransformRecord skinRootRecord = null); // 0x0000000188A75FC8-0x0000000188A761B4
		public void SetCenterTransform(Transform t, int tid = 0 /* Metadata: 0x0262A290 */); // 0x0000000188A75B70-0x0000000188A75C38
		public void SetSkinRoot(Transform t, int tid = 0 /* Metadata: 0x0262A291 */); // 0x0000000188A75EF8-0x0000000188A75FC8
		public Transform GetCenterTransform(); // 0x0000000188A6FEA8-0x0000000188A6FED0
		public void SetCustomSkinningBones(TransformRecord clothTransformRecord, List<TransformRecord> bones); // 0x0000000188A75C38-0x0000000188A75EF8
		public bool CompareSpace(VirtualMesh target); // 0x0000000188A6EAB4-0x0000000188A6EAD4
		public float4x4 CenterTransformTo(VirtualMesh to); // 0x0000000188A6E8E8-0x0000000188A6E9A8
		public void Mapping(VirtualMesh proxyMesh); // 0x0000000188A71594-0x0000000188A72214
		private static float4 CalcVertexWeights(float4 distances); // 0x0000000188A6E734-0x0000000188A6E8E8
		public void Optimization(); // 0x0000000186262F10-0x0000000186262F30
		private void RemoveDuplicateTriangles(); // 0x0000000186263580-0x0000000186263A60
		private bool CheckTwoTriangleOpen([IsReadOnly] in int3 tri1, [IsReadOnly] in int3 tri2, [IsReadOnly] in int2 edge, [IsReadOnly] in float3 tri1n); // 0x0000000188A6E9A8-0x0000000188A6EAB4
		private float CalcTwoTriangleAngle([IsReadOnly] in int3 tri1, [IsReadOnly] in int3 tri2, [IsReadOnly] in int2 edge); // 0x0000000188A6E514-0x0000000188A6E734
		public void ConvertProxyMesh(ClothSerializeData sdata, TransformRecord clothTransformRecord, List<TransformRecord> customSkinningBoneRecords, TransformRecord normalAdjustmentTransformRecord); // 0x0000000186264A50-0x0000000186265F50
		private void ProxyNormalAdjustment(ClothSerializeData sdata, TransformRecord normalAdjustmentTransformRecord); // 0x0000000186263350-0x00000001862634F0
		private void ProxyCreateFixedListAndAABB(); // 0x00000001862642E0-0x00000001862648A0
		private void OptimizeTriangleDirection(NativeArray<float3> triangleNormals, float sameSurfaceAngle); // 0x0000000188A72214-0x0000000188A72C04
		private void CreateCustomSkinning(CustomSkinningSettings setting, List<TransformRecord> bones); // 0x0000000188A6EAD4-0x0000000188A6EE30
		public void ApplySelectionAttribute(SelectionData selectionData); // 0x0000000186703D10-0x00000001867046B0
		private void CreateMeshBaseLine(); // 0x0000000188A6EE30-0x0000000188A6FD78
		private void CreateTransformBaseLine(); // 0x0000000185B9A4C0-0x0000000185B9D010
		[BurstCompile]
		public static void DoBaseLine_Bone_CreateBoneChildInfo(int vcnt, NativeArray<int> parentIndices, NativeParallelMultiHashMap<int, ushort> childMap); // 0x00000001865C3130-0x00000001865C31B0
		private void CreateBaseLinePose(); // 0x00000001862648A0-0x0000000186264A50
		private void CreateVertexRootAndDepth(); // 0x0000000186262F30-0x0000000186263350
		public void Reduction(ReductionSettings settings, CancellationToken ct); // 0x0000000188A73E88-0x0000000188A74AE0
		private void InitReductionWorkData(ReductionWorkData workData); // 0x0000000188A70B8C-0x0000000188A70D90
		private void Organization(ReductionSettings setting, ReductionWorkData workData); // 0x0000000188A73810-0x0000000188A738D8
		private void OrganizationInit(ReductionSettings setting, ReductionWorkData workData); // 0x0000000188A73368-0x0000000188A73810
		private void OrganizationCreateRemapData(ReductionWorkData workData); // 0x0000000188A730C0-0x0000000188A73368
		private void OrganizationCreateBasicData(ReductionWorkData workData); // 0x0000000188A72C04-0x0000000188A72F94
		private void OrganizationCreateLineTriangle(ReductionWorkData workData); // 0x0000000188A72F94-0x0000000188A730C0
		private void OrganizeStoreVirtualMesh(ReductionWorkData workData); // 0x0000000188A738D8-0x0000000188A73E88
		public ShareSerializationData ShareSerialize(); // 0x0000000188A763B0-0x0000000188A76D60
		public static VirtualMesh ShareDeserialize(ShareSerializationData sdata); // 0x00000001862610F0-0x0000000186261A90
		public UniqueSerializationData UniqueSerialize(); // 0x0000000188A774DC-0x0000000188A775F0
		internal void CalcAverageAndMaxVertexDistanceRun(); // 0x0000000186263A60-0x0000000186264280
		internal GridMap<int> CreateVertexIndexGridMapRun(float gridSize); // 0x0000000188A6FD78-0x0000000188A6FEA8
		public VirtualMeshRaycastHit IntersectRayMesh(float3 rayPos, float3 rayDir, bool doubleSide, float pointRadius); // 0x0000000188A70D90-0x0000000188A71514
		public void Dispose(); // 0x00000001859F5B00-0x00000001859F6140
		public void SetName(string newName); // 0x0000000184FD2410-0x0000000184FD2420
		public bool IsValid(); // 0x0000000188A71514-0x0000000188A71594
		public override string ToString(); // 0x0000000188A76D60-0x0000000188A774DC
	}

	[Serializable]
	public struct VertexAttribute : IEquatable<BeyondDynamicBone.VertexAttribute> // TypeDefIndex: 78127
	{
		// Fields
		public const byte Flag_Fixed = 1; // Metadata: 0x0262A29A
		public const byte Flag_Move = 2; // Metadata: 0x0262A29B
		public const byte Flag_InvalidMotion = 8; // Metadata: 0x0262A29C
		public const byte Flag_DisableCollision = 16; // Metadata: 0x0262A29D
		public const byte Flag_Triangle = 128; // Metadata: 0x0262A29E
		public static readonly VertexAttribute Invalid; // 0x00
		public static readonly VertexAttribute Fixed; // 0x01
		public static readonly VertexAttribute Move; // 0x02
		public static readonly VertexAttribute DisableCollision; // 0x03
		public byte Value; // 0x00
	
		// Constructors
		public VertexAttribute(byte initialValue = 0 /* Metadata: 0x0262A299 */); // 0x0000000187233BE0-0x0000000187233BF0
		static VertexAttribute(); // 0x00000001871D3BC0-0x00000001871D3C30
	
		// Methods
		public void Clear(); // 0x0000000187233BD0-0x0000000187233BE0
		public void SetFlag(byte flag, bool sw); // 0x00000001889F30DC-0x00000001889F30F0
		public void SetFlag(VertexAttribute attr, bool sw); // 0x00000001889F30DC-0x00000001889F30F0
		public bool IsSet(byte flag); // 0x00000001889F30C8-0x00000001889F30D0
		public bool IsInvalid(); // 0x00000001889F3000-0x00000001889F3040
		public bool IsFixed(); // 0x00000001889F2FB8-0x00000001889F3000
		public bool IsMove(); // 0x00000001889F3080-0x00000001889F30C8
		public bool IsDontMove(); // 0x00000001889F2F78-0x00000001889F2FB8
		public bool IsMotion(); // 0x00000001889F3040-0x00000001889F3080
		public bool IsDisableCollision(); // 0x00000001889F2F30-0x00000001889F2F78
		public static VertexAttribute JoinAttribute(VertexAttribute attr1, VertexAttribute attr2); // 0x00000001889F30D0-0x00000001889F30DC
		public bool Equals(VertexAttribute other); // 0x0000000185D7EFE0-0x0000000185D7EFF0
		public override bool Equals(object obj); // 0x00000001889F2EC8-0x00000001889F2F30
		public override int GetHashCode(); // 0x00000001844AD2A0-0x00000001844AD2B0
		public static bool operator ==(VertexAttribute lhs, VertexAttribute rhs); // 0x00000001889F30F0-0x00000001889F30F8
		public static bool operator !=(VertexAttribute lhs, VertexAttribute rhs); // 0x00000001889F30F8-0x00000001889F3100
	}

	public struct VirtualMeshBoneWeight // TypeDefIndex: 78128
	{
		// Fields
		public float4 weights; // 0x00
		public int4 boneIndices; // 0x10
	
		// Properties
		public bool IsValid { get; } // 0x00000001889F3398-0x00000001889F33A8 
		public int Count { get; } // 0x00000001889F3358-0x00000001889F3398 
	
		// Constructors
		public VirtualMeshBoneWeight(int4 boneIndices, float4 weights); // 0x0000000187233BF0-0x0000000187233C00
	
		// Methods
		public void AddWeight(int boneIndex, float weight); // 0x00000001889F3170-0x00000001889F3258
		public void AddWeight([IsReadOnly] in VirtualMeshBoneWeight bw); // 0x00000001889F3100-0x00000001889F3170
		public void AdjustWeight(); // 0x00000001889F3258-0x00000001889F32C0
		public override string ToString(); // 0x00000001889F32C0-0x00000001889F3358
	}

	public class VirtualMeshContainer : IDisposable // TypeDefIndex: 78129
	{
		// Fields
		public VirtualMesh shareVirtualMesh; // 0x10
		public VirtualMesh.UniqueSerializationData uniqueData; // 0x18
	
		// Properties
		public bool hasUniqueData { get; } // 0x0000000185B19DF0-0x0000000185B19E00 
	
		// Constructors
		public VirtualMeshContainer(); // 0x0000000186805BA0-0x0000000186805BB0
		public VirtualMeshContainer(VirtualMesh vmesh); // 0x0000000186183450-0x0000000186183480
	
		// Methods
		public void Dispose(); // 0x0000000185FF1A70-0x0000000185FF1A90
		public int GetTransformCount(); // 0x0000000185B938B0-0x0000000185B93900
		public Transform GetTransformFromIndex(int index); // 0x0000000185B19D80-0x0000000185B19DF0
		public Transform GetCenterTransform(); // 0x00000001889F33A8-0x00000001889F340C
	}

	public enum VirtualMeshPrimitive // TypeDefIndex: 78130
	{
		None = 0,
		Point = 1,
		Edge = 2,
		Triangle = 3
	}

	public struct VirtualMeshRaycastHit : IComparable<BeyondDynamicBone.VirtualMeshRaycastHit>, IValid // TypeDefIndex: 78131
	{
		// Fields
		public VirtualMeshPrimitive type; // 0x00
		public int index; // 0x04
		public double3 position; // 0x08
		public double distance; // 0x20
		public float3 normal; // 0x28
	
		// Methods
		public int CompareTo(VirtualMeshRaycastHit other); // 0x00000001889F340C-0x00000001889F343C
		public bool IsValid(); // 0x00000001889F343C-0x00000001889F3444
		public override string ToString(); // 0x00000001889F3444-0x00000001889F3624
	}

	public struct VirtualMeshTransform // TypeDefIndex: 78132
	{
		// Fields
		public FixedString32Bytes name; // 0x00
		public int index; // 0x20
		public float4x4 localToWorldMatrix; // 0x24
		public float4x4 worldToLocalMatrix; // 0x64
		public int parentIndex; // 0xA4
	
		// Properties
		public static VirtualMeshTransform Origin { get; } // 0x00000001889F3BDC-0x00000001889F3CA4 
	
		// Constructors
		public VirtualMeshTransform(Transform t); // 0x00000001889F3A64-0x00000001889F3BDC
		public VirtualMeshTransform(Transform t, int index); // 0x00000001889F3A3C-0x00000001889F3A64
	
		// Methods
		public VirtualMeshTransform Clone(); // 0x0000000187233C00-0x0000000187233C70
		public override int GetHashCode(); // 0x00000001889F3624-0x00000001889F362C
		public void Update(Transform t); // 0x00000001889F3940-0x00000001889F3A3C
		public float3 TransformPoint(float3 pos); // 0x00000001889F3740-0x00000001889F37B0
		public float3 TransformVector(float3 vec); // 0x00000001889EC734-0x00000001889EC850
		public float3 TransformDirection(float3 dir); // 0x00000001889EC654-0x00000001889EC734
		public float3 InverseTransformPoint(float3 pos); // 0x00000001889F362C-0x00000001889F36A4
		public float3 InverseTransformVector(float3 vec); // 0x00000001889EC59C-0x00000001889EC654
		public float3 InverseTransformDirection(float3 dir); // 0x00000001889EC4BC-0x00000001889EC59C
		public quaternion InverseTransformRotation(quaternion rot); // 0x00000001889F36A4-0x00000001889F3740
		public VirtualMeshTransform Transform([IsReadOnly] in VirtualMeshTransform to); // 0x00000001889F37B0-0x00000001889F3940
	}
}

namespace BeyondDynamicBone.ClothTeleport
{
	public enum RigidTransformRule : byte // TypeDefIndex: 78133
	{
		Position = 0,
		Vector = 1,
		Rotation = 2,
		Direction = 3,
		Scalar = 4,
		BodyLocal = 5
	}

	public struct Twist // TypeDefIndex: 78134
	{
		// Fields
		public float3 omega; // 0x00
		public float3 v; // 0x0C
		public static readonly Twist Zero; // 0x00
	
		// Constructors
		public Twist(float3 omega, float3 v); // 0x0000000187233BB0-0x0000000187233BD0
		static Twist(); // 0x00000001889F2D10-0x00000001889F2D9C
	
		// Methods
		public static Twist operator *(float s, Twist xi); // 0x00000001889F2E1C-0x00000001889F2EA0
		public static Twist operator *(Twist xi, float s); // 0x00000001889F2D9C-0x00000001889F2E1C
	}

	[IsReadOnly]
	public struct RigidTransform // TypeDefIndex: 78135
	{
		// Fields
		public readonly quaternion rotation; // 0x00
		public readonly float3 translation; // 0x10
		public static readonly RigidTransform Identity; // 0x00
	
		// Constructors
		public RigidTransform(float3 translation, quaternion rotation); // 0x0000000187233B90-0x0000000187233BB0
		static RigidTransform(); // 0x00000001889F2804-0x00000001889F2884
	
		// Methods
		public static RigidTransform FromDelta(float3 dp, quaternion dr); // 0x0000000187233B70-0x0000000187233B90
		public static RigidTransform Mul(RigidTransform g1, RigidTransform g2); // 0x00000001889F26E8-0x00000001889F27C4
		public RigidTransform Inverse(); // 0x00000001889EC3CC-0x00000001889EC46C
		public static RigidTransform Exp(Twist xi); // 0x00000001889F1D90-0x00000001889F2134
		public static RigidTransform Exp(float s, Twist xi); // 0x00000001889F2134-0x00000001889F2218
		public Twist Log(); // 0x00000001889F238C-0x00000001889F26E8
		public static RigidTransform Interpolate(RigidTransform a, RigidTransform b, float t); // 0x00000001889F2218-0x00000001889F238C
		public float3 TransformPoint(float3 x); // 0x00000001889CA684-0x00000001889CA910
		public float3 TransformVector(float3 v); // 0x00000001889EC46C-0x00000001889EC4BC
		public quaternion TransformRotation(quaternion q); // 0x00000001889F27C4-0x00000001889F2804
		public float3 TransformDirection(float3 u); // 0x00000001889EC46C-0x00000001889EC4BC
	}

	public struct TransformSlice // TypeDefIndex: 78136
	{
		// Fields
		public IntPtr ptr; // 0x00
		public int count; // 0x08
		public RigidTransformRule rule; // 0x0C
	}

	[BurstCompile]
	internal struct TeleportClothJob : IJob // TypeDefIndex: 78137
	{
		// Fields
		public RigidTransform t; // 0x00
		public double3 positionPivot; // 0x20
		public double3 positionShift; // 0x38
		[ReadOnly]
		public NativeArray<TransformSlice> slices; // 0x50
	
		// Methods
		public void Execute(); // 0x00000001889F2ADC-0x00000001889F2D10
	}
}

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 77500
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 77501
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
