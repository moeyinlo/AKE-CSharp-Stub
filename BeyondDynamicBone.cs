/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BeyondDynamicBone;
using IFix.Core;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.LowLevel;

// Image 12: BeyondDynamicBone.dll - Assembly: BeyondDynamicBone, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 45639-46278

internal class __JobReflectionRegistrationOutput__3181798692 // TypeDefIndex: 46273
{
	// Constructors
	public __JobReflectionRegistrationOutput__3181798692() {} // Dummy constructor

	// Methods
	public static void CreateJobReflectionData() {} // 0x0000000181465330-0x000000018146DBE0
	public static void EarlyInit() {} // 0x000000018146DBE0-0x0000000181472100
}

internal static class _BurstDirectCallInitializer // TypeDefIndex: 46274
{
	// Methods
	private static void Initialize() {} // 0x000000018568C2A0-0x000000018568C930
}

namespace BeyondDynamicBone
{
	public class BeyondBoneCloth : ClothBehaviour, IValid // TypeDefIndex: 45642
	{
		// Fields
		public int clothAnimatorAbilityLODThresholdProperty; // 0x20
		private int _clothAnimatorAbilityLODThresholdProperty; // 0x24
		public int clothAnimatorLODThresholdProperty; // 0x28
		private int _clothAnimatorLODThresholdProperty; // 0x2C
		public float clothLODFadeTimeProperty; // 0x30
		private float _clothLODFadeTimeProperty; // 0x34
		public float animationPoseRatioProperty; // 0x38
		private float _animationPoseRatioProperty; // 0x3C
		public float clothSimulateWeightProperty; // 0x40
		private float _clothSimulateWeightProperty; // 0x44
		public float gravityProperty; // 0x48
		private float _gravityProperty; // 0x4C
		public float dampingProperty; // 0x50
		private float _dampingProperty; // 0x54
		public float worldInertiaProperty; // 0x58
		private float _worldInertiaProperty; // 0x5C
		public float localInertiaProperty; // 0x60
		private float _localInertiaProperty; // 0x64
		public float windInfluenceProperty; // 0x68
		private float _windInfluenceProperty; // 0x6C
		public float blendWeightProperty; // 0x70
		private float _blendWeightProperty; // 0x74
		private bool _bUseRelativeTransform_k__BackingField; // 0x78
		public float3 relativeTransformPos; // 0x7C
		public quaternion relativeTransformRot; // 0x88
		private ClothSerializeData serializeData; // 0x98
		internal ClothSerializeData2 serializeData2; // 0xA0
		private ClothProcess process; // 0xA8
		public Action<bool> OnBuildComplete; // 0xB0
	
		// Properties
		public bool bUseRelativeTransform { get; private set; } // 0x0000000185FB0DA0-0x0000000185FB0DB0 0x0000000185FB0DB0-0x0000000185FB0DC0
		public ClothSerializeData SerializeData { get => default; set {} } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
		public ClothProcess Process { get => default; } // 0x0000000184488CC0-0x0000000184488D50 
		public Transform ClothTransform { get => default; } // 0x000000018646DBCC-0x000000018646DBD4 
		public BeyondBoneCloth SyncPartnerCloth { get => default; } // 0x00000001846A10C0-0x00000001846A1190 
	
		// Constructors
		public BeyondBoneCloth() {} // 0x0000000184807CC0-0x0000000184807DC0
	
		// Methods
		internal void InitAnimationProperty() {} // 0x00000001840DE6B0-0x00000001840DE820
		private void OnDidApplyAnimationProperties() {} // 0x000000018764C4AC-0x000000018764C78C
		public void SetRelativeTransform(bool useRelativeTransform, float3 newPos, quaternion newRot) {} // 0x000000018764CE3C-0x000000018764D0A8
		public bool IsValid() => default; // 0x0000000184A97210-0x0000000184A972A0
		private void Reset() {} // 0x000000018764CC50-0x000000018764CC90
		private void OnValidate() {} // 0x000000018764C78C-0x000000018764C7EC
		private void Awake() {} // 0x0000000185871010-0x0000000185871090
		private void OnEnable() {} // 0x0000000184483CC0-0x0000000184483D10
		private void OnDisable() {} // 0x00000001844835C0-0x0000000184483610
		private void Start() {} // 0x00000001840DE480-0x00000001840DE580
		private void OnDestroy() {} // 0x0000000185B96F20-0x0000000185B96F70
		public override int GetMagicaHashCode() => default; // 0x000000018764C338-0x000000018764C3EC
		public ClothSerializeData2 GetSerializeData2() => default; // 0x00000001840DF1E0-0x00000001840DF210
		public void Initialize() {} // 0x0000000184FB2590-0x0000000184FB25F0
		public void DisableAutoBuild() {} // 0x000000018764C16C-0x000000018764C1E4
		public void SetClothSimulateWeight(float weight) {} // 0x00000001848D15A0-0x00000001848D16E0
		public void SetClothSimulateWeightIgnorePlaying(float weight) {} // 0x00000001855608A0-0x0000000185560960
		public void SetClothStablizationTimeAfterResetIgnorePlaying(float time) {} // 0x000000018764CD64-0x000000018764CDD0
		public void SetAnimationPoseRatio(float ratio) {} // 0x000000018764CC90-0x000000018764CD64
		private void SetCodeParamaterDirty() {} // 0x00000001848D16E0-0x00000001848D1850
		private void SetCodeParamaterDirtyIgnorePlaying() {} // 0x0000000185560960-0x0000000185560A30
		public bool BuildAndRun() => default; // 0x000000018764BC34-0x000000018764C16C
		public void ReplaceTransform(Dictionary<string, Transform> targetTransformDict) {} // 0x000000018764C7EC-0x000000018764CB08
		public void SetParameterChange() {} // 0x000000018764CDD0-0x000000018764CE3C
		public void SetTimeScale(float timeScale) {} // 0x000000018764D128-0x000000018764D1FC
		public float GetTimeScale() => default; // 0x000000018764C3EC-0x000000018764C4AC
		public void ResetCloth(bool keepPose = false /* Metadata: 0x0205E6C4 */) {} // 0x000000018764CB08-0x000000018764CC50
		public void SoftResetCloth(bool keepPose = false /* Metadata: 0x0205E6C5 */) {} // 0x0000000184A972A0-0x0000000184A97310
		public Vector3 GetCenterPosition() => default; // 0x000000018764C1E4-0x000000018764C338
		public void AddForce(Vector3 forceDirection, float forceVelocity, ClothForceMode fmode = ClothForceMode.VelocityAdd /* Metadata: 0x0205E6C6 */) {} // 0x000000018764BA94-0x000000018764BC34
		public void SetSkipWriting(bool sw) {} // 0x000000018764D0A8-0x000000018764D128
		public int __iFixBaseProxy_GetMagicaHashCode() => default; // 0x000000018764D1FC-0x000000018764D204
	}

	[Serializable]
	public class CheckSliderSerializeData // TypeDefIndex: 45643
	{
		// Fields
		public float value; // 0x10
		public bool use; // 0x14
	
		// Constructors
		public CheckSliderSerializeData() {} // 0x0000000185492010-0x0000000185492020
		public CheckSliderSerializeData(bool use, float value) {} // 0x0000000185FB0DC0-0x0000000185FB0DD0
	
		// Methods
		public float GetValue(float unusedValue) => default; // 0x00000001840DE3C0-0x00000001840DE410
		public void SetValue(bool use, float value) {} // 0x000000018764D478-0x000000018764D4EC
		public void DataValidate(float min, float max) {} // 0x000000018764D3F4-0x000000018764D478
		public CheckSliderSerializeData Clone() => default; // 0x000000018764D36C-0x000000018764D3F4
	}

	public abstract class ClothBehaviour : MonoBehaviour // TypeDefIndex: 45644
	{
		// Fields
		private bool _IsGizmoVisible_k__BackingField; // 0x18
	
		// Properties
		public bool IsGizmoVisible { get; set; } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
	
		// Constructors
		protected ClothBehaviour() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public virtual int GetMagicaHashCode() => default; // 0x000000018764D4EC-0x000000018764D538
		protected virtual void OnDrawGizmos() {} // 0x000000018764D538-0x000000018764D588
	}

	public enum ClothForceMode // TypeDefIndex: 45645
	{
		None = 0,
		VelocityAdd = 1,
		VelocityChange = 2,
		VelocityAddWithoutDepth = 10,
		VelocityChangeWithoutDepth = 11
	}

	public enum ClothMeshWriteMode // TypeDefIndex: 45646
	{
		PositionAndNormal = 0,
		PositionAndNormalTangent = 1
	}

	public enum ClothNormalAxis // TypeDefIndex: 45647
	{
		Right = 0,
		Up = 1,
		Forward = 2,
		InverseRight = 3,
		InverseUp = 4,
		InverseForward = 5
	}

	public struct ClothParameters // TypeDefIndex: 45648
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

	public class ClothProcess : IDisposable, IValid, ITransform // TypeDefIndex: 45659
	{
		// Fields
		private static readonly ProfilerMarker initProfiler; // 0x00
		private static readonly ProfilerMarker preBuildProfiler; // 0x08
		private static readonly ProfilerMarker preBuildDeserializationProfiler; // 0x10
		private static readonly ProfilerMarker preBuildRegistrationProfiler; // 0x18
		private BeyondBoneCloth _cloth_k__BackingField; // 0x10
		private BeyondBoneCloth _SyncTopCloth_k__BackingField; // 0x18
		public const int State_Valid = 0; // Metadata: 0x0205E6D4
		public const int State_Enable = 1; // Metadata: 0x0205E6D5
		public const int State_InitSuccess = 3; // Metadata: 0x0205E6D6
		public const int State_InitComplete = 4; // Metadata: 0x0205E6D7
		public const int State_Build = 5; // Metadata: 0x0205E6D8
		public const int State_Running = 6; // Metadata: 0x0205E6D9
		public const int State_DisableAutoBuild = 7; // Metadata: 0x0205E6DA
		public const int State_CameraCullingInvisible = 8; // Metadata: 0x0205E6DB
		public const int State_CameraCullingKeep = 9; // Metadata: 0x0205E6DC
		public const int State_SkipWriting = 10; // Metadata: 0x0205E6DD
		public const int State_UsePreBuild = 12; // Metadata: 0x0205E6DE
		public const int State_DistanceCullingInvisible = 13; // Metadata: 0x0205E6DF
		public const int State_UpdateTangent = 14; // Metadata: 0x0205E6E0
		public const int State_Component = 15; // Metadata: 0x0205E6E1
		public const int State_Verification = 16; // Metadata: 0x0205E6E2
		public const int State_LOD_Culled = 25; // Metadata: 0x0205E6E3
		internal BitField32 stateFlag; // 0x20
		private TransformRecord _clothTransformRecord_k__BackingField; // 0x28
		private List<int> renderHandleList; // 0x30
		internal RenderSetupData boneClothSetupData; // 0x38
		internal List<RenderMeshInfo> renderMeshInfoList; // 0x40
		internal List<TransformRecord> customSkinningBoneRecords; // 0x48
		private TransformRecord _normalAdjustmentTransformRecord_k__BackingField; // 0x50
		internal ResultCode result; // 0x58
		private ClothType _clothType_k__BackingField; // 0x60
		private ReductionSettings reductionSettings; // 0x68
		private ClothParameters _parameters_k__BackingField; // 0x70
		private VirtualMeshContainer _ProxyMeshContainer_k__BackingField; // 0x398
		internal List<ColliderComponent> colliderList; // 0x3A0
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
		public BeyondBoneCloth cloth { get; internal set; } // 0x00000001844875F0-0x00000001844876C0 0x0000000184485BD0-0x0000000184485CC0
		public BeyondBoneCloth SyncTopCloth { get; internal set; } // 0x00000001844872F0-0x0000000184487450 0x0000000184485CC0-0x0000000184485E20
		internal TransformRecord clothTransformRecord { get; private set; } // 0x000000018764F900-0x000000018764F954 0x000000018764F9FC-0x000000018764FA54
		internal TransformRecord normalAdjustmentTransformRecord { get; private set; } // 0x000000018764F954-0x000000018764F9A8 0x000000018764F9A8-0x000000018764F9FC
		public ResultCode Result { get => default; } // 0x000000018764FA54-0x000000018764FAAC 
		internal ClothType clothType { get; private set; } // 0x000000018764FAAC-0x000000018764FB04 0x00000001844869F0-0x00000001844872F0
		public ClothParameters parameters { get; private set; } // 0x000000018764FDDC-0x000000018764FEA0 0x000000018764FEA0-0x000000018764FF50
		public VirtualMeshContainer ProxyMeshContainer { get; private set; } // 0x0000000184808800-0x0000000184808A60 0x0000000185B96F70-0x0000000185B97280
		internal int ColliderCapacity { get => default; } // 0x0000000184D639A0-0x0000000184D66A00 
		public int TeamId { get; private set; } // 0x000000018764F7EC-0x000000018764F900 0x000000018764D8DC-0x000000018764D9E4
		public bool IsEnable { get => default; } // 0x0000000187651A00-0x0000000187651C18 
		public bool HasProxyMesh { get => default; } // 0x0000000185492010-0x0000000185492020 
		public string Name { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private struct GenerateSelectionJob : IJobParallelFor // TypeDefIndex: 45649
		{
			// Fields
			public int offset; // 0x00
			public NativeArray<float3> positionList; // 0x08
			public NativeArray<VertexAttribute> attributeList; // 0x18
			public int attributeMapWidth; // 0x28
			public float4x4 toM; // 0x2C
			public int2 xySize; // 0x6C
			public ExBitFlag8 attributeReadFlag; // 0x74
			public NativeArray<Color32> attributeMapData; // 0x78
			public NativeArray<float2> uvs; // 0x88
			public NativeArray<float3> vertexs; // 0x98
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001840DF7B0-0x00000001840DFEC0
		}
	
		public class RenderMeshInfo // TypeDefIndex: 45650
		{
			// Fields
			public int renderHandle; // 0x10
			public VirtualMeshContainer renderMeshContainer; // 0x18
			public DataChunk mappingChunk; // 0x20
	
			// Constructors
			public RenderMeshInfo() {} // 0x000000018764D588-0x000000018764D7F4
		}
	
		public class PaintMapData // TypeDefIndex: 45651
		{
			// Fields
			public const byte ReadFlag_Fixed = 1; // Metadata: 0x0205E6E4
			public const byte ReadFlag_Move = 2; // Metadata: 0x0205E6E5
			public const byte ReadFlag_Limit = 4; // Metadata: 0x0205E6E6
			public Color32[] paintData; // 0x10
			public int paintMapWidth; // 0x18
			public int paintMapHeight; // 0x1C
			public ExBitFlag8 paintReadFlag; // 0x20
	
			// Constructors
			public PaintMapData() {} // 0x0000000184871B40-0x0000000184871C60
		}
	
		public enum ClothType // TypeDefIndex: 45652
		{
			MeshCloth = 0,
			BoneCloth = 1,
			BoneSpring = 10
		}
	
		private sealed class __c__DisplayClass10_0 // TypeDefIndex: 45653
		{
			// Fields
			public CancellationToken ct; // 0x10
			public VirtualMesh proxyMesh; // 0x18
			public ClothProcess __4__this; // 0x20
			public List<RenderMeshInfo> renderMeshInfos; // 0x28
	
			// Constructors
			public __c__DisplayClass10_0() {} // 0x0000000184483D10-0x0000000184483DA0
	
			// Methods
			internal void _RuntimeBuildAsync_b__1() {} // 0x0000000184483610-0x00000001844836A0
		}
	
		private sealed class __c__DisplayClass10_1 // TypeDefIndex: 45654
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
			public __c__DisplayClass10_1() {} // 0x0000000184483740-0x0000000184483A00
	
			// Methods
			internal void _RuntimeBuildAsync_b__0() {} // 0x000000018764D7F4-0x000000018764D8DC
		}
	
		private struct _RuntimeBuildAsync_d__10 : IAsyncStateMachine // TypeDefIndex: 45655
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
			private void MoveNext() {} // 0x000000018545C9D0-0x000000018545CB00
			private void SetStateMachine(IAsyncStateMachine stateMachine) {} // 0x00000001840DE610-0x00000001840DE6B0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45656
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<VirtualMeshContainer> __9__18_0; // 0x08
			public static Action<int> __9__21_0; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018545CB30-0x000000018545CC50
			public __c() {} // 0x000000018764E4EC-0x000000018764ED74
	
			// Methods
			internal void _PreBuildDataConstruction_b__18_0(VirtualMeshContainer x) {} // 0x000000018764E0A0-0x000000018764E4EC
			internal void _UpdateRendererUse_b__21_0(int handle) {} // 0x000000018764ED74-0x000000018764F2A0
		}
	
		private sealed class __c__DisplayClass126_0 // TypeDefIndex: 45657
		{
			// Fields
			public HashSet<Transform> transformSet; // 0x10
	
			// Constructors
			public __c__DisplayClass126_0() {} // 0x000000018486E1C0-0x000000018486FBF0
	
			// Methods
			internal void _GetUsedTransform_b__0(int handle) {} // 0x0000000184D5E700-0x0000000184D5E770
			internal void _GetUsedTransform_b__1(TransformRecord rd) {} // 0x00000001845CD2A0-0x00000001845CD3F0
		}
	
		private sealed class __c__DisplayClass127_0 // TypeDefIndex: 45658
		{
			// Fields
			public Dictionary<int, Transform> replaceDict; // 0x10
	
			// Constructors
			public __c__DisplayClass127_0() {} // 0x0000000185A5EE10-0x0000000185A5EF70
	
			// Methods
			internal void _ReplaceTransform_b__0(int handle) {} // 0x000000018346D130-0x000000018346D140
			internal void _ReplaceTransform_b__1(TransformRecord rd) {} // 0x0000000184096E30-0x0000000184096EF0
		}
	
		// Constructors
		public ClothProcess() {} // 0x0000000185492010-0x0000000185492020
		static ClothProcess() {} // 0x00000001876523F4-0x000000018765241C
	
		// Methods
		internal void Init() {} // 0x0000000181377E40-0x0000000181377E50
		private int AddRenderer(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referenceUniqueSetupData) => default; // 0x0000000184088E70-0x0000000184088E80
		private void CreateBoneRenderSetupData(ClothType ctype, List<Transform> rootTransforms, List<Transform> ignoreFromRootBones, List<Transform> collisionBones, RenderSetupData.BoneConnectionMode connectionMode) {} // 0x00000001813B8590-0x00000001813B85A0
		internal void StartUse() {} // 0x0000000184A4EDC0-0x0000000184A4EDD0
		internal void EndUse() {} // 0x0000000181460F60-0x0000000181460F70
		internal void UpdateUse() {} // 0x0000000184A4E570-0x0000000184A4E580
		internal void DataUpdate() {} // 0x00000001813F1630-0x00000001813F1640
		internal bool StartRuntimeBuild() => default; // 0x000000018143E3B0-0x000000018143E3C0
		internal bool AutoBuild() => default; // 0x000000018143E3C0-0x000000018143E3D0
		private System.Threading.Tasks.Task RuntimeBuildAsync(CancellationToken ct) => default; // 0x0000000185FB0DF0-0x0000000185FB0E80
		public ResultCode GenerateSelectionDataFromPaintMap(TransformRecord clothTransformRecord, VirtualMesh renderMesh, PaintMapData paintMapData, out SelectionData selectionData) {
			selectionData = default;
			return default;
		} // 0x0000000185FB0E90-0x0000000185FB0F10
		public ResultCode GeneratePaintMapDataList(List<PaintMapData> dataList) => default; // 0x0000000185FB0DD0-0x0000000185FB0DE0
		public ResultCode GenerateSelectionDataFromVertexAttributeData(TransformRecord clothTransformRecord, VirtualMesh renderMesh, VertexAttribute[] vertexAttributeArray, out SelectionData selectionData) {
			selectionData = default;
			return default;
		} // 0x000000018764FF50-0x000000018764FF64
		internal bool PreBuildDataConstruction() => default; // 0x0000000184D5E770-0x0000000184D5E7C0
		internal int GetColliderIndex(ColliderComponent col) => default; // 0x0000000185FB0DE0-0x0000000185FB0DF0
		internal void UpdateCullingAnimatorAndRenderers() {} // 0x0000000185FB0E80-0x0000000185FB0E90
		internal void UpdateRendererUse() {} // 0x000000018764F4C4-0x000000018764F510
		public BitField32 GetStateFlag() => default; // 0x000000018764F510-0x000000018764F5D8
		public bool IsState(int state) => default; // 0x000000018764F420-0x000000018764F4C4
		public void SetState(int state, bool sw) {} // 0x00000001840DBE90-0x00000001840DBFE0
		public bool IsValid() => default; // 0x000000018764F5D8-0x000000018764F7EC
		public bool IsRunning() => default; // 0x000000018764FB04-0x000000018764FD18
		public bool IsCameraCullingInvisible() => default; // 0x000000018764FD18-0x000000018764FDDC
		public bool IsLodCulled() => default; // 0x000000018764F2A0-0x000000018764F420
		public bool IsCameraCullingKeep() => default; // 0x00000001840DF080-0x00000001840DF1E0
		public bool IsDistanceCullingInvisible() => default; // 0x000000018764DF64-0x000000018764E0A0
		public bool IsSkipWriting() => default; // 0x000000018764D9E4-0x000000018764DF64
		public bool IsUpdateTangent() => default; // 0x0000000185D72FD0-0x0000000185D730F0
		public void Dispose() {} // 0x00000001840DE8C0-0x00000001840DECF0
		private void DisposeInternal() {} // 0x0000000185492010-0x0000000185492020
		internal void IncrementSuspendCounter() {} // 0x0000000185036D80-0x000000018503A2B0
		internal void DecrementSuspendCounter() {} // 0x00000001846A12B0-0x00000001846A5220
		internal int GetSuspendCounter() => default; // 0x00000001857B8DA0-0x00000001857B8E00
		public RenderMeshInfo GetRenderMeshInfo(int index) => default; // 0x0000000185F6C790-0x0000000185F6C7F0
		internal void SyncParameters() {} // 0x0000000185492010-0x0000000185492020
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000187652264-0x0000000187652278
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x0000000187652278-0x00000001876522E4
		internal void SetSkipWriting(bool sw) {} // 0x0000000185492010-0x0000000185492020
		internal ClothUpdateMode GetClothUpdateMode() => default; // 0x00000001876522E4-0x0000000187652358
		public ResultCode GenerateStatusCheck() => default; // 0x0000000187652358-0x0000000187652380
		internal bool GenerateInitialization() => default; // 0x0000000185492010-0x0000000185492020
		internal bool GenerateBoneClothSelection() => default; // 0x0000000187652380-0x00000001876523F4
	}

	[Serializable]
	public class ClothSerializeData : IDataValidate, IValid, ITransform // TypeDefIndex: 45664
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
		public float rotationalInterpolation; // 0x44
		public float rootRotation; // 0x48
		public ClothUpdateMode updateMode; // 0x4C
		public AnimatorAbilityLevel clothAnimatorAbilityLODThreshold; // 0x50
		public int clothAnimatorLODThreshold; // 0x54
		public float clothLodFadeTime; // 0x58
		public float clothSimulateWeight; // 0x5C
		public float animationPoseRatio; // 0x60
		public ReductionSettings reductionSetting; // 0x68
		public CustomSkinningSettings customSkinningSetting; // 0x70
		public NormalAlignmentSettings normalAlignmentSetting; // 0x78
		public CullingSettings cullingSettings; // 0x80
		public ClothNormalAxis normalAxis; // 0x88
		public float gravity; // 0x8C
		public float3 gravityDirection; // 0x90
		public float gravityFalloff; // 0x9C
		public float stablizationTimeAfterReset; // 0xA0
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
		public Define.Result VerificationResult { get => default; } // 0x0000000187650CAC-0x0000000187650E10 
	
		// Nested types
		public enum PaintMode // TypeDefIndex: 45660
		{
			Manual = 0,
			Texture_Fixed_Move = 1,
			Texture_Fixed_Move_Limit = 2
		}
	
		public enum AnimatorAbilityLevel // TypeDefIndex: 45661
		{
			OnlyPlayerOrBoss = 0,
			AICharOrElite = 1,
			DefaultOrAtmosphere = 2
		}
	
		private class TempBuffer // TypeDefIndex: 45662
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
			internal TempBuffer(ClothSerializeData sdata) {} // 0x0000000185FB0F20-0x0000000185FB0F30
	
			// Methods
			internal void Push(ClothSerializeData sdata) {} // 0x0000000184809990-0x0000000184809FA0
			internal void Pop(ClothSerializeData sdata) {} // 0x00000001840DED30-0x00000001840DEF20
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45663
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, bool> __9__45_0; // 0x08
			public static Func<Renderer, bool> __9__45_1; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000187650114-0x000000018765040C
			public __c() {} // 0x000000018765045C-0x0000000187650AA4
	
			// Methods
			internal bool _IsValid_b__45_0(Transform x) => default; // 0x00000001840DC710-0x00000001840DCA20
			internal bool _IsValid_b__45_1(Renderer x) => default; // 0x000000018765040C-0x000000018765045C
		}
	
		// Constructors
		public ClothSerializeData() {} // 0x0000000187650E94-0x00000001876513E0
	
		// Methods
		public bool IsValid() => default; // 0x0000000187650E10-0x0000000187650E94
		public void DataValidate() {} // 0x0000000187650AA4-0x0000000187650CAC
		public override int GetHashCode() => default; // 0x00000001876513E0-0x00000001876515A4
		public ClothParameters GetClothParameters() => default; // 0x00000001846A11D0-0x00000001846A1200
		public string ExportJson() => default; // 0x0000000185FB0F10-0x0000000185FB0F20
		public bool ImportJson(string json) => default; // 0x0000000187652210-0x0000000187652218
		public void Import(ClothSerializeData sdata, bool deepCopy = false /* Metadata: 0x0205E6EA */) {} // 0x0000000187651E40-0x0000000187652210
		public void Import(BeyondBoneCloth src, bool deepCopy = false /* Metadata: 0x0205E6EB */) {} // 0x0000000187651C18-0x0000000187651E40
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000185F6D3F0-0x0000000185F6D450
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x0000000185492010-0x0000000185492020
		public bool IsBoneSpring() => default; // 0x0000000185785AB0-0x0000000185785B00
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000187652218-0x0000000187652264
	}

	[Serializable]
	public class ClothSerializeData2 : IDataValidate, IValid, ITransform // TypeDefIndex: 45665
	{
		// Fields
		public SelectionData selectionData; // 0x10
		[NonSerialized]
		public Dictionary<Transform, VertexAttribute> boneAttributeDict; // 0x18
		[NonSerialized]
		public List<VertexAttribute[]> vertexAttributeList; // 0x20
		public PreBuildSerializeData preBuildData; // 0x28
	
		// Constructors
		public ClothSerializeData2() {} // 0x0000000184807E60-0x0000000184807F80
	
		// Methods
		public bool IsValid() => default; // 0x000000018765005C-0x00000001876500A8
		public void DataValidate() {} // 0x000000018764FF64-0x000000018764FFA4
		public override int GetHashCode() => default; // 0x000000018764FFA4-0x000000018764FFF0
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018764FFF0-0x000000018765005C
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001876500A8-0x0000000187650114
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000185FB0F10-0x0000000185FB0F20
	}

	public enum ClothUpdateMode // TypeDefIndex: 45666
	{
		Normal = 0,
		UnityPhysics = 1,
		Unscaled = 2,
		AnimatorLinkage = 10
	}

	public class BeyondBoneCapsuleCollider : ColliderComponent // TypeDefIndex: 45668
	{
		// Fields
		public Direction direction; // 0x40
		public bool reverseDirection; // 0x44
		public bool radiusSeparation; // 0x45
		public bool alignedOnCenter; // 0x46
	
		// Nested types
		public enum Direction // TypeDefIndex: 45667
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		// Constructors
		public BeyondBoneCapsuleCollider() {} // 0x0000000184807DC0-0x0000000184807DD0
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType() => default; // 0x0000000185712E50-0x0000000185712EB0
		public void SetSize(float startRadius, float endRadius, float length) {} // 0x000000018764B9A0-0x000000018764BA5C
		public override Vector3 GetSize() => default; // 0x0000000185698500-0x0000000185698570
		public Vector3 GetLocalDir() => default; // 0x000000018764B844-0x000000018764B918
		public Vector3 GetLocalUp() => default; // 0x000000018764B918-0x000000018764B9A0
		public override bool IsReverseDirection() => default; // 0x00000001857BC570-0x00000001857BC5A0
		public override void DataValidate() {} // 0x000000018764B7C8-0x000000018764B844
		public Vector3 __iFixBaseProxy_GetSize() => default; // 0x000000018764BA5C-0x000000018764BA8C
		public bool __iFixBaseProxy_IsReverseDirection() => default; // 0x000000018764BA8C-0x000000018764BA94
	}

	public class BeyondBonePlaneCollider : ColliderComponent // TypeDefIndex: 45669
	{
		// Constructors
		public BeyondBonePlaneCollider() {} // 0x0000000184806A10-0x0000000184806A20
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType() => default; // 0x000000018764D248-0x000000018764D294
		public override void DataValidate() {} // 0x000000018764D204-0x000000018764D248
	}

	public class BeyondBoneSphereCollider : ColliderComponent // TypeDefIndex: 45670
	{
		// Constructors
		public BeyondBoneSphereCollider() {} // 0x0000000184806A10-0x0000000184806A20
	
		// Methods
		public override ColliderManager.ColliderType GetColliderType() => default; // 0x0000000185F088D0-0x0000000185F08900
		public override void DataValidate() {} // 0x000000018764D294-0x000000018764D2F0
		public void SetSize(float radius) {} // 0x000000018764D2F0-0x000000018764D36C
	}

	public abstract class ColliderComponent : ClothBehaviour, IDataValidate // TypeDefIndex: 45671
	{
		// Fields
		public Vector3 center; // 0x20
		protected Vector3 size; // 0x2C
		private HashSet<int> teamIdSet; // 0x38
	
		// Constructors
		protected ColliderComponent() {} // 0x0000000184807DD0-0x0000000184807E60
	
		// Methods
		public abstract ColliderManager.ColliderType GetColliderType();
		public abstract void DataValidate();
		public virtual Vector3 GetSize() => default; // 0x0000000185D91190-0x0000000185D911E0
		public void SetSize(Vector3 size) {} // 0x00000001876517FC-0x0000000187651874
		public void SetSizeX(float size) {} // 0x00000001876516E8-0x0000000187651744
		public void SetSizeY(float size) {} // 0x0000000187651744-0x00000001876517A0
		public void SetSizeZ(float size) {} // 0x00000001876517A0-0x00000001876517FC
		public virtual float GetScale() => default; // 0x000000018765162C-0x0000000187651698
		public virtual bool IsReverseDirection() => default; // 0x0000000185F37880-0x0000000185F378B0
		internal void Register(int teamId) {} // 0x0000000184B3C1D0-0x0000000184B3C240
		internal void Exit(int teamId) {} // 0x00000001876515A4-0x000000018765162C
		public void UpdateParameters() {} // 0x0000000187651874-0x0000000187651A00
		protected virtual void Start() {} // 0x00000001858BA1A0-0x00000001858BA1D0
		protected virtual void OnValidate() {} // 0x0000000187651698-0x00000001876516E8
		protected virtual void OnEnable() {} // 0x0000000185530A50-0x0000000185530CA0
		protected virtual void OnDisable() {} // 0x0000000184D5CD10-0x0000000184D5CF60
		protected virtual void OnDestroy() {} // 0x0000000184D5CA50-0x0000000184D5CD10
	}

	internal static class AngleConstraintJobKernels // TypeDefIndex: 45676
	{
		// Nested types
		public unsafe delegate void AngleConstraintKernel_000000C4_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index); // TypeDefIndex: 45672; 0x000000018764B65C-0x000000018764B7C8
	
		internal static class AngleConstraintKernel_000000C4_BurstDirectCall // TypeDefIndex: 45673
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static AngleConstraintKernel_000000C4_BurstDirectCall() {} // 0x0000000187659DF8-0x0000000187659EFC
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00060dcc) {} // 0x000000018765A440-0x000000018765A514
			private static IntPtr GetFunctionPointer() => default; // 0x000000018765A33C-0x000000018765A440
			public static void Constructor() {} // 0x000000018765A1F0-0x000000018765A33C
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index) {} // 0x0000000187659EFC-0x0000000187659F50
		}
	
		public unsafe delegate void AngleConstraintRangeKernel_000000C5_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr); // TypeDefIndex: 45674; 0x0000000185492010-0x0000000185492020
	
		internal static class AngleConstraintRangeKernel_000000C5_BurstDirectCall // TypeDefIndex: 45675
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static AngleConstraintRangeKernel_000000C5_BurstDirectCall() {} // 0x000000018765A514-0x000000018765A618
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00060e11) {} // 0x000000018765AAFC-0x000000018765ABD0
			private static IntPtr GetFunctionPointer() => default; // 0x000000018765A9F8-0x000000018765AAFC
			public static void Constructor() {} // 0x000000018765A908-0x000000018765A9F8
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr) {} // 0x000000018765A618-0x000000018765A66C
		}
	
		// Methods
		private static unsafe void AngleConstraintKernel(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index) {} // 0x0000000185F48660-0x0000000185F486F0
		internal static unsafe void AngleConstraintRangeKernel(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void AngleConstraintKernel_BurstManaged(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int index) {} // 0x0000000185F48650-0x0000000185F48660
		public static unsafe void AngleConstraintRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, int* vertexParentIndices, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, quaternion* stepBasicRotationBuffer, float* lengthBufferArray, float3* localPosBufferArray, quaternion* localRotBufferArray, quaternion* rotationBufferArray, float3* restorationVectorBufferArray, int* lengthPtr) {} // 0x000000018765A66C-0x000000018765A908
	}

	public class AngleConstraint : IDisposable // TypeDefIndex: 45681
	{
		// Fields
		private NativeArray<float> lengthBuffer; // 0x10
		private NativeArray<float3> localPosBuffer; // 0x20
		private NativeArray<quaternion> localRotBuffer; // 0x30
		private NativeArray<quaternion> rotationBuffer; // 0x40
		private NativeArray<float3> restorationVectorBuffer; // 0x50
	
		// Nested types
		[Serializable]
		public class RestorationSerializeData : IDataValidate // TypeDefIndex: 45677
		{
			// Fields
			public bool useAngleRestoration; // 0x10
			public CurveSerializeData stiffness; // 0x18
			public float velocityAttenuation; // 0x20
			public float gravityFalloff; // 0x24
	
			// Constructors
			public RestorationSerializeData() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public void DataValidate() {} // 0x000000018765ABD0-0x000000018765AC9C
			public RestorationSerializeData Clone() => default; // 0x00000001847014F0-0x0000000184701680
		}
	
		[Serializable]
		public class LimitSerializeData : IDataValidate // TypeDefIndex: 45678
		{
			// Fields
			public bool useAngleLimit; // 0x10
			public CurveSerializeData limitAngle; // 0x18
			public float stiffness; // 0x20
	
			// Constructors
			public LimitSerializeData() {} // 0x000000018765AC9C-0x000000018765AF34
	
			// Methods
			public void DataValidate() {} // 0x00000001847036A0-0x0000000184703CD0
			public LimitSerializeData Clone() => default; // 0x000000018765AF34-0x000000018765AF3C
		}
	
		public struct AngleConstraintParams // TypeDefIndex: 45679
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
			public void Convert(RestorationSerializeData restorationData, LimitSerializeData limitData) {} // 0x0000000184808E90-0x0000000184808F30
		}
	
		private struct AngleConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45680
		{
			// Fields
			public float4 simulationPower; // 0x00
			public NativeArray<int> stepBaseLineIndexArray; // 0x10
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x20
			public NativeArray<ClothParameters> parameterArray; // 0x30
			public NativeArray<VertexAttribute> attributes; // 0x40
			public NativeArray<float> vertexDepths; // 0x50
			public NativeArray<int> vertexParentIndices; // 0x60
			public NativeArray<ushort> baseLineStartDataIndices; // 0x70
			public NativeArray<ushort> baseLineDataCounts; // 0x80
			public NativeArray<ushort> baseLineData; // 0x90
			public NativeArray<double3> nextPosArray; // 0xA0
			public NativeArray<double3> velocityPosArray; // 0xB0
			public NativeArray<float> frictionArray; // 0xC0
			public NativeArray<double3> stepBasicPositionBuffer; // 0xD0
			public NativeArray<quaternion> stepBasicRotationBuffer; // 0xE0
			public NativeArray<float> lengthBufferArray; // 0xF0
			public NativeArray<float3> localPosBufferArray; // 0x100
			public NativeArray<quaternion> localRotBufferArray; // 0x110
			public NativeArray<quaternion> rotationBufferArray; // 0x120
			public NativeArray<float3> restorationVectorBufferArray; // 0x130
			public NativeReference<int> _indexCount; // 0x140
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000187666FDC-0x000000018766705C
			public void Execute() {} // 0x0000000187666F18-0x0000000187666FDC
			public void Execute(int index) {} // 0x0000000184808DF0-0x0000000184808E90
			public void UnsafeDo() {} // 0x000000018766299C-0x0000000187662A0C
		}
	
		// Constructors
		public AngleConstraint() {} // 0x00000001876628E4-0x000000018766299C
	
		// Methods
		public void Dispose() {} // 0x00000001840DCB20-0x00000001840DCC50
		internal void WorkBufferUpdate() {} // 0x0000000184CFE7C0-0x0000000184CFE860
		public override string ToString() => default; // 0x00000001876582DC-0x0000000187658374
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x0000000187658374-0x0000000187659B70
		public string __iFixBaseProxy_ToString() => default; // 0x0000000187659B70-0x0000000187659DF8
	}

	public class ColliderCollisionConstraint : IDisposable // TypeDefIndex: 45703
	{
		// Fields
		private NativeArray<int> tempFrictionArray; // 0x10
		private NativeArray<int> tempNormalArray; // 0x20
	
		// Nested types
		private static class PointColliderCollisionConstraintJobKernels // TypeDefIndex: 45686
		{
			// Nested types
			public unsafe delegate void PointColliderCollisionConstraintKernel_000000DB_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index); // TypeDefIndex: 45682; 0x000000018765AF3C-0x000000018765AFC0
	
			internal static class PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall // TypeDefIndex: 45683
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall() {} // 0x000000018568E070-0x000000018568E0D0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060e97) {} // 0x0000000184BDA470-0x0000000184BDAAB0
				private static IntPtr GetFunctionPointer() => default; // 0x000000018568E190-0x000000018568E1F0
				public static void Constructor() {} // 0x000000018568E130-0x000000018568E190
				public static void Initialize() {} // 0x000000018568E0D0-0x000000018568E130
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index) {} // 0x000000018568E010-0x000000018568E070
			}
	
			public unsafe delegate void PointColliderCollisionConstraintRangeKernel_000000DC_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr); // TypeDefIndex: 45684; 0x000000018765AF34-0x000000018765AF3C
	
			internal static class PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall // TypeDefIndex: 45685
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall() {} // 0x0000000187657A98-0x0000000187657B94
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060ec7) {} // 0x000000018766499C-0x0000000187664D20
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187664828-0x000000018766499C
				public static void Constructor() {} // 0x00000001876635E0-0x0000000187663984
				public static void Initialize() {} // 0x0000000187663984-0x000000018766462C
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr) {} // 0x0000000187666908-0x00000001876669DC
			}
	
			// Methods
			private static unsafe void PointColliderCollisionConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index) {} // 0x0000000187666860-0x0000000187666908
			internal static unsafe void PointColliderCollisionConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr) {} // 0x0000000187666768-0x0000000187666860
			private static double PointSphereColliderDetection(ref double3 nextpos, in double3 basePos, float radius, in AABB aabb, in ColliderManager.WorkData cwork, bool isSpring, float maxLength, out float3 normal) {
				normal = default;
				return default;
			} // 0x00000001864BB614-0x00000001864BB734
			private static double PointPlaneColliderDetction(ref double3 nextpos, float radius, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000187666444-0x0000000187666548
			private static double PointCapsuleColliderDetection(ref double3 nextpos, float radius, in AABB aabb, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000187666548-0x000000018766659C
			public static unsafe void PointColliderCollisionConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int index) {} // 0x0000000185F46AE0-0x0000000185F46B70
			public static unsafe void PointColliderCollisionConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, double3* basePosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private static class EdgeColliderCollisionConstraintJobKernels // TypeDefIndex: 45691
		{
			// Nested types
			public unsafe delegate void EdgeColliderCollisionConstraintKernel_000000E0_PostfixBurstDelegate(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // TypeDefIndex: 45687; 0x000000018766659C-0x0000000187666768
	
			internal static class EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall // TypeDefIndex: 45688
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall() {} // 0x0000000185F46A40-0x0000000185F46AD0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060f57) {} // 0x0000000187666CFC-0x0000000187666D98
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x00000001876669DC-0x0000000187666AE0
				public static void Initialize() {} // 0x0000000187666AE0-0x0000000187666B34
				public static unsafe void Invoke(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000185492010-0x0000000185492020
			}
	
			public unsafe delegate void EdgeColliderCollisionConstraintRangeKernel_000000E1_PostfixBurstDelegate(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // TypeDefIndex: 45689; 0x0000000187666B34-0x0000000187666CFC
	
			internal static class EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall // TypeDefIndex: 45690
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall() {} // 0x0000000187655A68-0x0000000187655BA0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060f93) {} // 0x000000018765F3D8-0x000000018765F980
				private static IntPtr GetFunctionPointer() => default; // 0x000000018765D9E0-0x000000018765E26C
				public static void Constructor() {} // 0x000000018765F1F0-0x000000018765F3D8
				public static void Initialize() {} // 0x000000018765E26C-0x000000018765EF7C
				public static unsafe void Invoke(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x0000000187662078-0x000000018766214C
			}
	
			// Methods
			private static unsafe void EdgeColliderCollisionConstraintKernel(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000187661F9C-0x0000000187662078
			internal static unsafe void EdgeColliderCollisionConstraintRangeKernel(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x0000000187661E74-0x0000000187661F9C
			private static float EdgeSphereColliderDetection(ref double3x2 nextPosE, in double2 radiusE, in AABB aabbE, double cfr, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x00000001864BB614-0x00000001864BB734
			private static double EdgeCapsuleColliderDetection(ref double3x2 nextPosE, in double2 radiusE, in AABB aabbE, double cfr, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000187661ADC-0x0000000187661BE0
			private static double EdgePlaneColliderDetection(ref double3x2 nextPosE, in double2 radiusE, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000187661BE0-0x0000000187661C34
			public static unsafe void EdgeColliderCollisionConstraintKernel_BurstManaged(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000185F47440-0x0000000185F474D0
			public static unsafe void EdgeColliderCollisionConstraintRangeKernel_BurstManaged(int* stepEdgeCollisionIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* edgeTeamIdArray, int2* edges, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, ExBitFlag8* colliderFlagArray, ColliderManager.WorkData* colliderWorkDataArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private static class SolveEdgeBufferAndClearJobKernels // TypeDefIndex: 45696
		{
			// Nested types
			public unsafe delegate void SolveEdgeBufferAndClearKernel_000000E5_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index); // TypeDefIndex: 45692; 0x0000000187661C34-0x0000000187661E74
	
			internal static class SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall // TypeDefIndex: 45693
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall() {} // 0x0000000185F473A0-0x0000000185F47430
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00060fe7) {} // 0x00000001876624E0-0x00000001876625AC
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x000000018766214C-0x0000000187662250
				public static void Initialize() {} // 0x0000000187662250-0x00000001876622A4
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000185492010-0x0000000185492020
			}
	
			public unsafe delegate void SolveEdgeBufferAndClearRangeKernel_000000E6_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr); // TypeDefIndex: 45694; 0x00000001876622A4-0x00000001876624E0
	
			internal static class SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall // TypeDefIndex: 45695
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall() {} // 0x00000001876683F8-0x00000001876684C8
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006100b) {} // 0x0000000187657B94-0x00000001876582DC
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187667BC4-0x0000000187667C84
				public static void Constructor() {} // 0x000000018766853C-0x0000000187668610
				public static void Initialize() {} // 0x00000001876684C8-0x000000018766853C
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x00000001864BB614-0x00000001864BB734
			}
	
			// Methods
			private static unsafe void SolveEdgeBufferAndClearKernel(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000187668164-0x0000000187668268
			internal static unsafe void SolveEdgeBufferAndClearRangeKernel(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x0000000187668268-0x00000001876682BC
			public static unsafe void SolveEdgeBufferAndClearKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int index) {} // 0x0000000185F460E0-0x0000000185F46170
			public static unsafe void SolveEdgeBufferAndClearRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, float* frictionArray, float3* collisionNormalArray, double3* velocityPosArray, int* countArray, int* sumArray, int* tempFrictionArray, int* tempNormalArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
		}
	
		public enum Mode // TypeDefIndex: 45697
		{
			None = 0,
			Point = 1,
			Edge = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate, ITransform // TypeDefIndex: 45698
		{
			// Fields
			public Mode mode; // 0x10
			public float friction; // 0x14
			public List<ColliderComponent> colliderList; // 0x18
			public List<Transform> collisionBones; // 0x20
			public CurveSerializeData limitDistance; // 0x28
	
			// Properties
			public int ColliderLength { get => default; } // 0x0000000187668610-0x0000000187668714 
	
			// Constructors
			public SerializeData() {} // 0x0000000185F460D0-0x0000000185F460E0
	
			// Methods
			public void DataValidate() {} // 0x00000001876682BC-0x00000001876683F8
			public SerializeData Clone() => default; // 0x0000000187668948-0x0000000187668A1C
			public override int GetHashCode() => default; // 0x0000000183706EE0-0x0000000183706F60
			public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x00000001876688D8-0x0000000187668948
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001864BB614-0x00000001864BB734
			public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000187668714-0x0000000187668768
		}
	
		public struct ColliderCollisionConstraintParams // TypeDefIndex: 45699
		{
			// Fields
			public Mode mode; // 0x00
			public float dynamicFriction; // 0x04
			public float staticFriction; // 0x08
			public float4x4 limitDistance; // 0x0C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000185F46040-0x0000000185F460D0
		}
	
		private struct PointColliderCollisionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45700
		{
			// Fields
			public NativeArray<int> stepParticleIndexArray; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<ClothParameters> parameterArray; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
			public NativeArray<float> vertexDepths; // 0x40
			public NativeArray<short> teamIdArray; // 0x50
			public NativeArray<double3> nextPosArray; // 0x60
			public NativeArray<double3> velocityPosArray; // 0x70
			public NativeArray<double3> basePosArray; // 0x80
			public NativeArray<float> frictionArray; // 0x90
			public NativeArray<float3> collisionNormalArray; // 0xA0
			public NativeArray<ExBitFlag8> colliderFlagArray; // 0xB0
			public NativeArray<ColliderManager.WorkData> colliderWorkDataArray; // 0xC0
			public NativeReference<int> _indexCount; // 0xD0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185492010-0x0000000185492020
			public void Execute() {} // 0x0000000185F46030-0x0000000185F46040
			public void UnsafeDo() {} // 0x0000000187668768-0x00000001876688D8
			public void Execute(int index) {} // 0x0000000184808FC0-0x00000001848090E0
			private double PointSphereColliderDetection(ref double3 nextpos, in double3 basePos, double radius, in AABB aabb, in ColliderManager.WorkData cwork, bool isSpring, double maxLength, out float3 normal) {
				normal = default;
				return default;
			} // 0x00000001876675BC-0x0000000187667640
			private double PointPlaneColliderDetction(ref double3 nextpos, double radius, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x00000001876672A0-0x00000001876673F8
			private double PointCapsuleColliderDetection(ref double3 nextpos, double radius, in AABB aabb, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000187667640-0x00000001876677DC
		}
	
		private struct EdgeColliderCollisionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45701
		{
			// Fields
			public NativeArray<int> stepEdgeCollisionIndexArray; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<ClothParameters> parameterArray; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
			public NativeArray<float> vertexDepths; // 0x40
			public NativeArray<short> edgeTeamIdArray; // 0x50
			public NativeArray<int2> edges; // 0x60
			public NativeArray<double3> nextPosArray; // 0x70
			public NativeArray<double3> velocityPosArray; // 0x80
			public NativeArray<float> frictionArray; // 0x90
			public NativeArray<float3> collisionNormalArray; // 0xA0
			public NativeArray<ExBitFlag8> colliderFlagArray; // 0xB0
			public NativeArray<ColliderManager.WorkData> colliderWorkDataArray; // 0xC0
			public NativeArray<int> countArray; // 0xD0
			public NativeArray<int> sumArray; // 0xE0
			public NativeArray<int> tempFrictionArray; // 0xF0
			public NativeArray<int> tempNormalArray; // 0x100
			public NativeReference<int> _indexCount; // 0x110
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001876677DC-0x0000000187667984
			public void Execute() {} // 0x0000000187667984-0x0000000187667B00
			public void Execute(int index) {} // 0x0000000184B38ED0-0x0000000184B38F10
			private double EdgeSphereColliderDetection(ref double3x2 nextPosE, in double2 radiusE, in AABB aabbE, float cfr, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000185FB0F10-0x0000000185FB0F20
			private double EdgeCapsuleColliderDetection(ref double3x2 nextPosE, in double2 radiusE, in AABB aabbE, float cfr, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x00000001840DE160-0x00000001840DE1D0
			private double EdgePlaneColliderDetection(ref double3x2 nextPosE, in double2 radiusE, in ColliderManager.WorkData cwork, out float3 normal) {
				normal = default;
				return default;
			} // 0x0000000184CFF290-0x0000000184CFF330
			public void UnsafeDo() {} // 0x0000000187664D20-0x0000000187664DB8
		}
	
		private struct SolveEdgeBufferAndClearJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45702
		{
			// Fields
			public NativeArray<int> jobParticleIndexList; // 0x00
			public NativeArray<float> frictionArray; // 0x10
			public NativeArray<float3> collisionNormalArray; // 0x20
			public NativeArray<double3> nextPosArray; // 0x30
			public NativeArray<double3> velocityPosArray; // 0x40
			public NativeArray<int> countArray; // 0x50
			public NativeArray<int> sumArray; // 0x60
			public NativeArray<int> tempFrictionArray; // 0x70
			public NativeArray<int> tempNormalArray; // 0x80
			public NativeReference<int> _indexCount; // 0x90
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000187666268-0x0000000187666444
			public void Execute() {} // 0x0000000187664DB8-0x0000000187665AAC
			public void Execute(int index) {} // 0x0000000187665F18-0x0000000187666268
			public void UnsafeDo() {} // 0x0000000187665DD0-0x0000000187665F18
		}
	
		// Constructors
		public ColliderCollisionConstraint() {} // 0x0000000187665AAC-0x0000000187665DD0
	
		// Methods
		public void Dispose() {} // 0x000000018766181C-0x0000000187661888
		internal void WorkBufferUpdate() {} // 0x000000018766098C-0x0000000187660A24
		public override string ToString() => default; // 0x0000000187660A24-0x000000018766181C
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x00000001876603FC-0x000000018766098C
		public static void Initialize_PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB_BurstDirectCall() {} // 0x000000018765F980-0x00000001876601FC
		public static void Initialize_PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC_BurstDirectCall() {} // 0x00000001876601FC-0x00000001876603FC
		public static void Initialize_EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0_BurstDirectCall() {} // 0x0000000187661888-0x0000000187661ADC
		public static void Initialize_EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1_BurstDirectCall() {} // 0x0000000187667FD0-0x000000018766803C
		public static void Initialize_SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5_BurstDirectCall() {} // 0x0000000187667D48-0x0000000187667DE0
		public static void Initialize_SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6_BurstDirectCall() {} // 0x0000000187667DE0-0x0000000187667FD0
		public string __iFixBaseProxy_ToString() => default; // 0x000000018766803C-0x0000000187668164
	}

	internal static class DistanceConstraintJobKernels // TypeDefIndex: 45708
	{
		// Nested types
		public unsafe delegate void DistanceConstraintKernel_00000101_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index); // TypeDefIndex: 45704; 0x000000018765BD2C-0x000000018765BE38
	
		internal static class DistanceConstraintKernel_00000101_BurstDirectCall // TypeDefIndex: 45705
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static DistanceConstraintKernel_00000101_BurstDirectCall() {} // 0x000000018765CC0C-0x000000018765CD10
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000610a0) {} // 0x000000018765D100-0x000000018765D1D4
			private static IntPtr GetFunctionPointer() => default; // 0x000000018765D04C-0x000000018765D100
			public static void Constructor() {} // 0x000000018765CF48-0x000000018765D04C
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index) {} // 0x000000018765CD10-0x000000018765CD64
		}
	
		public unsafe delegate void DistanceConstraintRangeKernel_00000102_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr); // TypeDefIndex: 45706; 0x0000000185492010-0x0000000185492020
	
		internal static class DistanceConstraintRangeKernel_00000102_BurstDirectCall // TypeDefIndex: 45707
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static DistanceConstraintRangeKernel_00000102_BurstDirectCall() {} // 0x000000018765D1D4-0x000000018765D2D8
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000610d3) {} // 0x000000018765D670-0x000000018765D744
			private static IntPtr GetFunctionPointer() => default; // 0x000000018765D5B8-0x000000018765D670
			public static void Constructor() {} // 0x000000018765D510-0x000000018765D5B8
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr) {} // 0x000000018765D2D8-0x000000018765D32C
		}
	
		// Methods
		private static unsafe void DistanceConstraintKernel(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index) {} // 0x0000000185F474E0-0x0000000185F47570
		internal static unsafe void DistanceConstraintRangeKernel(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void DistanceConstraintKernel_BurstManaged(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int index) {} // 0x0000000185F474D0-0x0000000185F474E0
		public static unsafe void DistanceConstraintRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, short* teamIdArray, double3* nextPosArray, double3* basePosArray, double3* velocityPosArray, float* frictionArray, uint* indexArray, ushort* dataArray, float* distanceArray, int* lengthPtr) {} // 0x000000018765D32C-0x000000018765D510
	}

	public class DistanceConstraint : IDisposable // TypeDefIndex: 45713
	{
		// Fields
		public const int TypeCount = 2; // Metadata: 0x0205E6FC
		public ExNativeArray<uint> indexArray; // 0x10
		public ExNativeArray<ushort> dataArray; // 0x18
		public ExNativeArray<float> distanceArray; // 0x20
	
		// Properties
		public int DataCount { get => default; } // 0x00000001876673F8-0x0000000187667458 
	
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 45709
		{
			// Fields
			public CurveSerializeData stiffness; // 0x10
	
			// Constructors
			public SerializeData() {} // 0x000000018765D9A8-0x000000018765D9E0
	
			// Methods
			public void DataValidate() {} // 0x000000018551F010-0x000000018551F2C0
			public SerializeData Clone() => default; // 0x000000018765D744-0x000000018765D800
		}
	
		public struct DistanceConstraintParams // TypeDefIndex: 45710
		{
			// Fields
			public float4x4 restorationStiffness; // 0x00
			public float velocityAttenuation; // 0x40
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x000000018765D800-0x000000018765D9A8
		}
	
		[Serializable]
		public class ConstraintData : IValid // TypeDefIndex: 45711
		{
			// Fields
			public ResultCode result; // 0x10
			public uint[] indexArray; // 0x18
			public ushort[] dataArray; // 0x20
			public float[] distanceArray; // 0x28
	
			// Constructors
			public ConstraintData() {} // 0x00000001840D9D70-0x00000001840D9F20
	
			// Methods
			public bool IsValid() => default; // 0x00000001841274E0-0x000000018412A210
		}
	
		private struct DistanceConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45712
		{
			// Fields
			public float4 simulationPower; // 0x00
			public NativeArray<int> stepParticleIndexArray; // 0x10
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x20
			public NativeArray<ClothParameters> parameterArray; // 0x30
			public NativeArray<VertexAttribute> attributes; // 0x40
			public NativeArray<float> depthArray; // 0x50
			public NativeArray<short> teamIdArray; // 0x60
			public NativeArray<double3> nextPosArray; // 0x70
			public NativeArray<double3> basePosArray; // 0x80
			public NativeArray<double3> velocityPosArray; // 0x90
			public NativeArray<float> frictionArray; // 0xA0
			public NativeArray<uint> indexArray; // 0xB0
			public NativeArray<ushort> dataArray; // 0xC0
			public NativeArray<float> distanceArray; // 0xD0
			public NativeReference<int> _indexCount; // 0xE0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000184D607E0-0x0000000184D60930
			public void Execute() {} // 0x0000000184704B00-0x0000000184705100
			public void Execute(int index) {} // 0x000000018765AF34-0x000000018765AF3C
			public void UnsafeDo() {} // 0x0000000184808F30-0x0000000184808FC0
		}
	
		// Constructors
		public DistanceConstraint() {} // 0x000000018766705C-0x0000000187667104
	
		// Methods
		public void Dispose() {} // 0x00000001840DC090-0x00000001840DC120
		public override string ToString() => default; // 0x00000001840DA0D0-0x00000001840DA110
		public static ConstraintData CreateData(VirtualMesh proxyMesh, in ClothParameters parameters) => default; // 0x0000000185492010-0x0000000185492020
		internal void Register(ClothProcess cprocess) {} // 0x0000000184C01C60-0x0000000184C01D00
		internal void Exit(ClothProcess cprocess) {} // 0x000000018765BE38-0x000000018765BED0
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x000000018765BED0-0x000000018765CA04
		public string __iFixBaseProxy_ToString() => default; // 0x000000018765CA04-0x000000018765CC0C
	}

	public class InertiaConstraint : IDisposable // TypeDefIndex: 45719
	{
		// Fields
		internal ExNativeArray<ushort> fixedArray; // 0x10
	
		// Nested types
		public enum TeleportMode // TypeDefIndex: 45714
		{
			None = 0,
			Reset = 1,
			Keep = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 45715
		{
			// Fields
			public Transform anchor; // 0x10
			public float anchorInertia; // 0x18
			public float worldInertia; // 0x1C
			public float movementInertiaSmoothing; // 0x20
			public CheckSliderSerializeData movementSpeedLimit; // 0x28
			public CheckSliderSerializeData rotationSpeedLimit; // 0x30
			public float localInertia; // 0x38
			public CheckSliderSerializeData localMovementSpeedLimit; // 0x40
			public CheckSliderSerializeData localRotationSpeedLimit; // 0x48
			public float depthInertia; // 0x50
			public float centrifualAcceleration; // 0x54
			public CheckSliderSerializeData particleSpeedLimit; // 0x58
			public TeleportMode teleportMode; // 0x60
			public float teleportDistance; // 0x64
			public float teleportRotation; // 0x68
	
			// Constructors
			public SerializeData() {} // 0x000000018551BE50-0x000000018551BF60
	
			// Methods
			public SerializeData Clone() => default; // 0x000000018766275C-0x00000001876627E4
			public void DataValidate() {} // 0x00000001876627E4-0x00000001876628E4
		}
	
		public struct InertiaConstraintParams // TypeDefIndex: 45716
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
			public void Convert(SerializeData sdata) {} // 0x00000001840DA900-0x00000001840DAF30
		}
	
		[Serializable]
		public struct CenterData // TypeDefIndex: 45717
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
			internal void Initialize() {} // 0x00000001840D9F20-0x00000001840DA0B0
		}
	
		[Serializable]
		public class ConstraintData // TypeDefIndex: 45718
		{
			// Fields
			public ResultCode result; // 0x10
			public CenterData centerData; // 0x18
			public float3 initLocalGravityDirection; // 0x2D0
	
			// Constructors
			public ConstraintData() {} // 0x0000000184D609A0-0x0000000184D60A80
		}
	
		// Constructors
		public InertiaConstraint() {} // 0x000000018765AF34-0x000000018765AF3C
	
		// Methods
		public void Dispose() {} // 0x0000000184808A60-0x0000000184808BC0
		public override string ToString() => default; // 0x0000000187667104-0x00000001876672A0
		public static ConstraintData CreateData(VirtualMesh proxyMesh, in ClothParameters parameters) => default; // 0x0000000187667458-0x00000001876675BC
		internal void Register(ClothProcess cprocess) {} // 0x00000001840DE2B0-0x00000001840DE3C0
		internal void Exit(ClothProcess cprocess) {} // 0x00000001840D9560-0x00000001840D96D0
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185492010-0x0000000185492020
	}

	internal static class MotionConstraintJobKernels // TypeDefIndex: 45724
	{
		// Nested types
		public unsafe delegate void MotionConstraintKernel_00000121_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index); // TypeDefIndex: 45720; 0x00000001876634F4-0x00000001876635E0
	
		internal static class MotionConstraintKernel_00000121_BurstDirectCall // TypeDefIndex: 45721
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static MotionConstraintKernel_00000121_BurstDirectCall() {} // 0x00000001876BFBD0-0x00000001876BFCD4
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061144) {} // 0x00000001876C005C-0x00000001876C0130
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876BFFC0-0x00000001876C005C
			public static void Constructor() {} // 0x00000001876BFED4-0x00000001876BFFC0
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index) {} // 0x00000001876BFCD4-0x00000001876BFD28
		}
	
		public unsafe delegate void MotionConstraintRangeKernel_00000122_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr); // TypeDefIndex: 45722; 0x0000000185492010-0x0000000185492020
	
		internal static class MotionConstraintRangeKernel_00000122_BurstDirectCall // TypeDefIndex: 45723
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static MotionConstraintRangeKernel_00000122_BurstDirectCall() {} // 0x00000001876C0130-0x00000001876C0234
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061171) {} // 0x00000001876C0560-0x00000001876C0634
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876C04C0-0x00000001876C0560
			public static void Constructor() {} // 0x00000001876C0430-0x00000001876C04C0
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x00000001876C0234-0x00000001876C0288
		}
	
		// Methods
		private static unsafe void MotionConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index) {} // 0x0000000185F46B80-0x0000000185F46C10
		internal static unsafe void MotionConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void MotionConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int index) {} // 0x0000000185F46B70-0x0000000185F46B80
		public static unsafe void MotionConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* basePosArray, quaternion* baseRotArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x00000001876C0288-0x00000001876C0430
	}

	public class MotionConstraint : IDisposable // TypeDefIndex: 45728
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 45725
		{
			// Fields
			public bool useMaxDistance; // 0x10
			public CurveSerializeData maxDistance; // 0x18
			public bool useBackstop; // 0x20
			public float backstopRadius; // 0x24
			public CurveSerializeData backstopDistance; // 0x28
			public float stiffness; // 0x30
	
			// Constructors
			public SerializeData() {} // 0x00000001876C0634-0x00000001876C0678
	
			// Methods
			public void DataValidate() {} // 0x00000001847086A0-0x0000000184708C50
			public SerializeData Clone() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		public struct MotionConstraintParams // TypeDefIndex: 45726
		{
			// Fields
			public bool useMaxDistance; // 0x00
			public float4x4 maxDistanceCurveData; // 0x04
			public bool useBackstop; // 0x44
			public float backstopRadius; // 0x48
			public float4x4 backstopDistanceCurveData; // 0x4C
			public float stiffness; // 0x8C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000184808C90-0x0000000184808D50
		}
	
		private struct MotionConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45727
		{
			// Fields
			public NativeArray<int> stepParticleIndexArray; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<ClothParameters> parameterArray; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
			public NativeArray<float> vertexDepths; // 0x40
			public NativeArray<short> teamIdArray; // 0x50
			public NativeArray<double3> basePosArray; // 0x60
			public NativeArray<double3> nextPosArray; // 0x70
			public NativeArray<double3> velocityPosArray; // 0x80
			public NativeArray<quaternion> baseRotArray; // 0x90
			public NativeArray<float> frictionArray; // 0xA0
			public NativeArray<float3> collisionNormalArray; // 0xB0
			public NativeReference<int> _indexCount; // 0xC0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001876C3B20-0x00000001876C3BDC
			public void Execute() {} // 0x00000001876C38EC-0x00000001876C39D4
			public void Execute(int index) {} // 0x00000001840DCA20-0x00000001840DCB20
			public void UnsafeDo() {} // 0x0000000184D008E0-0x0000000184D00980
		}
	
		// Constructors
		public MotionConstraint() {} // 0x00000001876BFA20-0x00000001876BFBD0
	
		// Methods
		public void Dispose() {} // 0x00000001876BF988-0x00000001876BFA20
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x00000001876BF03C-0x00000001876BF988
	}

	public class SelfCollisionConstraint : IDisposable // TypeDefIndex: 45782
	{
		// Fields
		public const uint KindPoint = 0; // Metadata: 0x0205E700
		public const uint KindEdge = 1; // Metadata: 0x0205E701
		public const uint KindTriangle = 2; // Metadata: 0x0205E702
		public const uint Flag_KindMask = 50331648; // Metadata: 0x0205E703
		public const uint Flag_Fix0 = 67108864; // Metadata: 0x0205E707
		public const uint Flag_Fix1 = 134217728; // Metadata: 0x0205E70B
		public const uint Flag_Fix2 = 268435456; // Metadata: 0x0205E70F
		public const uint Flag_AllFix = 536870912; // Metadata: 0x0205E713
		public const uint Flag_Ignore = 1073741824; // Metadata: 0x0205E718
		public const uint Flag_Enable = 2147483648; // Metadata: 0x0205E71D
		private ExNativeArray<Primitive> primitiveArray; // 0x10
		private ExNativeArray<SortData> sortAndSweepArray; // 0x18
		private int _PointPrimitiveCount_k__BackingField; // 0x20
		private int _EdgePrimitiveCount_k__BackingField; // 0x24
		private int _TrianglePrimitiveCount_k__BackingField; // 0x28
		private NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x30
		private NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x48
		private NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x58
		private NativeList<PointTriangleContact> pointTriangleContactList; // 0x70
		private NativeArray<byte> intersectFlagArray; // 0x80
		private int _IntersectCount_k__BackingField; // 0x90
	
		// Properties
		public int PointPrimitiveCount { get; private set; } // 0x00000001876C57C4-0x00000001876C58A0 0x00000001876C3BDC-0x00000001876C3C58
		public int EdgePrimitiveCount { get; private set; } // 0x00000001876C3CC4-0x00000001876C3D40 0x00000001876B9EA8-0x00000001876BA59C
		public int TrianglePrimitiveCount { get; private set; } // 0x00000001876C3C58-0x00000001876C3CC4 0x00000001876C4868-0x00000001876C493C
		public int IntersectCount { get; private set; } // 0x00000001817C0490-0x00000001817C04B0 0x00000001876C47BC-0x00000001876C4868
	
		// Nested types
		private static class IntersectUpdatePrimitiveJobKernels // TypeDefIndex: 45733
		{
			// Nested types
			public unsafe delegate void IntersectUpdatePrimitiveKernel_00000145_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index); // TypeDefIndex: 45729; 0x00000001813B9430-0x00000001813B9440
	
			internal static class IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall // TypeDefIndex: 45730
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall() {} // 0x000000018551F4E0-0x000000018551F820
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000611c4) {} // 0x0000000181C9AC80-0x0000000181C9AC90
				private static IntPtr GetFunctionPointer() => default; // 0x0000000181C9A5C0-0x0000000181C9A5D0
				public static void Constructor() {} // 0x00000001834A0D50-0x00000001834A0D60
				public static void Initialize() {} // 0x00000001834A2260-0x00000001834A2270
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index) {} // 0x00000001876C1F60-0x00000001876C20C0
			}
	
			public unsafe delegate void IntersectUpdatePrimitiveRangeKernel_00000146_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr); // TypeDefIndex: 45731; 0x00000001876C3364-0x00000001876C3720
	
			internal static class IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall // TypeDefIndex: 45732
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall() {} // 0x00000001847049F0-0x0000000184704B00
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000611dc) {} // 0x0000000184090280-0x0000000184090770
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876C20C0-0x00000001876C241C
				public static void Constructor() {} // 0x0000000184701490-0x00000001847014F0
				public static void Initialize() {} // 0x00000001876C1E70-0x00000001876C1F60
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr) {} // 0x0000000184704680-0x0000000184704880
			}
	
			// Methods
			private static unsafe void IntersectUpdatePrimitiveKernel(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index) {} // 0x00000001876C241C-0x00000001876C3364
			internal static unsafe void IntersectUpdatePrimitiveRangeKernel(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr) {} // 0x00000001876C3720-0x00000001876C38EC
			public static unsafe void IntersectUpdatePrimitiveKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int index) {} // 0x0000000184704880-0x00000001847049F0
			public static unsafe void IntersectUpdatePrimitiveRangeKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, double3* nextPosArray, Primitive* primitiveArray, uint* processingArray, int* lengthPtr) {} // 0x000000018568C930-0x000000018568C990
		}
	
		private static class UpdatePrimitiveJobKernels // TypeDefIndex: 45738
		{
			// Nested types
			public unsafe delegate void UpdatePrimitiveKernel_00000147_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index); // TypeDefIndex: 45734; 0x000000018568C9F0-0x000000018568CA50
	
			internal static class UpdatePrimitiveKernel_00000147_BurstDirectCall // TypeDefIndex: 45735
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdatePrimitiveKernel_00000147_BurstDirectCall() {} // 0x000000018568CC90-0x000000018568CCF0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061230) {} // 0x000000018568CB10-0x000000018568CB70
				private static IntPtr GetFunctionPointer() => default; // 0x000000018568CB70-0x000000018568CBD0
				public static void Constructor() {} // 0x000000018568CBD0-0x000000018568CC30
				public static void Initialize() {} // 0x000000018568CC30-0x000000018568CC90
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index) {} // 0x000000018568CCF0-0x000000018568CD50
			}
	
			public unsafe delegate void UpdatePrimitiveRangeKernel_00000148_PostfixBurstDelegate(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr); // TypeDefIndex: 45736; 0x00000001876BE108-0x00000001876BE18C
	
			internal static class UpdatePrimitiveRangeKernel_00000148_BurstDirectCall // TypeDefIndex: 45737
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdatePrimitiveRangeKernel_00000148_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006125a) {} // 0x00000001876BE18C-0x00000001876BE214
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876BEB98-0x00000001876BEC60
				public static void Constructor() {} // 0x00000001876BEB84-0x00000001876BEB98
				public static void Initialize() {} // 0x00000001876BEAB8-0x00000001876BEB84
				public static unsafe void Invoke(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr) {} // 0x00000001876BE890-0x00000001876BE994
			}
	
			// Methods
			private static unsafe void UpdatePrimitiveKernel(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index) {} // 0x00000001876BE994-0x00000001876BE9E8
			internal static unsafe void UpdatePrimitiveRangeKernel(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr) {} // 0x0000000185F46D60-0x0000000185F46DF0
			public static unsafe void UpdatePrimitiveKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int index) {} // 0x0000000185492010-0x0000000185492020
			public static unsafe void UpdatePrimitiveRangeKernel_BurstManaged(uint kind, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, double3* oldPosArray, float* frictionArray, Primitive* primitiveArray, SortData* sortAndSweepArray, uint* processingArray, int* lengthPtr) {} // 0x0000000185F46D50-0x0000000185F46D60
		}
	
		private static class ClearBufferJobKernels // TypeDefIndex: 45741
		{
			// Nested types
			public delegate void ClearBufferKernel_00000149_PostfixBurstDelegate(); // TypeDefIndex: 45739; 0x00000001876BEF74-0x00000001876BF03C
	
			internal static class ClearBufferKernel_00000149_BurstDirectCall // TypeDefIndex: 45740
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearBufferKernel_00000149_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006126c) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876BEC60-0x00000001876BED64
				public static void Constructor() {} // 0x00000001876BED64-0x00000001876BEDB8
				public static void Initialize() {} // 0x0000000185F46CC0-0x0000000185F46D50
				public static void Invoke() {} // 0x0000000185F46CB0-0x0000000185F46CC0
			}
	
			// Methods
			internal static void ClearBufferKernel() {} // 0x00000001876BEDB8-0x00000001876BEEC0
			public static void ClearBufferKernel_BurstManaged() {} // 0x00000001876C9348-0x00000001876C9424
		}
	
		private static class SortJobKernels // TypeDefIndex: 45746
		{
			// Nested types
			public unsafe delegate void SortKernel_0000014A_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index); // TypeDefIndex: 45742; 0x00000001876C8AF4-0x00000001876C9348
	
			internal static class SortKernel_0000014A_BurstDirectCall // TypeDefIndex: 45743
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SortKernel_0000014A_BurstDirectCall() {} // 0x00000001876CA230-0x00000001876CA284
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006128a) {} // 0x00000001876CA4FC-0x00000001876CA588
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876CA404-0x00000001876CA4FC
				public static void Constructor() {} // 0x00000001864BB614-0x00000001864BB734
				public static void Initialize() {} // 0x00000001876CA12C-0x00000001876CA230
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index) {} // 0x0000000185F450A0-0x0000000185F45130
			}
	
			public unsafe delegate void SortRangeKernel_0000014B_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length); // TypeDefIndex: 45744; 0x0000000185F45090-0x0000000185F450A0
	
			internal static class SortRangeKernel_0000014B_BurstDirectCall // TypeDefIndex: 45745
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SortRangeKernel_0000014B_BurstDirectCall() {} // 0x00000001876CA754-0x00000001876CA7A8
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006129c) {} // 0x000000018720FB48-0x000000018720FBD4
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876CA954-0x00000001876CAA34
				public static void Constructor() {} // 0x00000001864BB614-0x00000001864BB734
				public static void Initialize() {} // 0x00000001876CA650-0x00000001876CA754
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length) {} // 0x0000000185F45000-0x0000000185F45090
			}
	
			// Methods
			private static unsafe void SortKernel(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index) {} // 0x0000000185492010-0x0000000185492020
			internal static unsafe void SortRangeKernel(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length) {} // 0x0000000185F44FF0-0x0000000185F45000
			public static unsafe void SortKernel_BurstManaged(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int index) {} // 0x00000001876CA7A8-0x00000001876CA954
			public static unsafe void SortRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, Primitive* primitiveArray, SortData* sortAndSweepArray, int length) {} // 0x00000001876BB79C-0x00000001876BB7DC
		}
	
		public enum SelfCollisionMode // TypeDefIndex: 45747
		{
			None = 0,
			FullMesh = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 45748
		{
			// Fields
			public SelfCollisionMode selfMode; // 0x10
			public CurveSerializeData surfaceThickness; // 0x18
			public SelfCollisionMode syncMode; // 0x20
			public BeyondBoneCloth syncPartner; // 0x28
			public float clothMass; // 0x30
	
			// Constructors
			public SerializeData() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			public void DataValidate() {} // 0x00000001864BC330-0x00000001864BC3F4
			public SerializeData Clone() => default; // 0x00000001864BC320-0x00000001864BC330
			public BeyondBoneCloth GetSyncPartner() => default; // 0x00000001864BC2FC-0x00000001864BC320
		}
	
		public struct SelfCollisionConstraintParams // TypeDefIndex: 45749
		{
			// Fields
			public SelfCollisionMode selfMode; // 0x00
			public float4x4 surfaceThicknessCurveData; // 0x04
			public SelfCollisionMode syncMode; // 0x44
			public float clothMass; // 0x48
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x00000001864BB614-0x00000001864BB734
		}
	
		private struct Primitive // TypeDefIndex: 45750
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
			public bool IsIgnore() => default; // 0x00000001876BB86C-0x00000001876BB970
			public bool HasParticle(int p) => default; // 0x00000001876BB970-0x00000001876BB9C4
			public uint GetKind() => default; // 0x0000000185F47B20-0x0000000185F47BB0
			public int GetTeamId() => default; // 0x0000000185492010-0x0000000185492020
			public float GetSolveThickness(in Primitive pri) => default; // 0x0000000185F47B10-0x0000000185F47B20
			public bool AnyParticle(in Primitive pri) => default; // 0x00000001876BB9C4-0x00000001876BBA28
		}
	
		private struct SortData : IComparable<SortData> // TypeDefIndex: 45751
		{
			// Fields
			public uint flagAndTeamId; // 0x00
			public int primitiveIndex; // 0x04
			public double2 firstMinMax; // 0x08
			public double2 secondMinMax; // 0x18
			public double2 thirdMinMax; // 0x28
	
			// Methods
			public int CompareTo(SortData other) => default; // 0x00000001876C6514-0x00000001876C6588
			public uint GetKind() => default; // 0x00000001876C65EC-0x00000001876C6660
		}
	
		internal struct EdgeEdgeContact // TypeDefIndex: 45752
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
			public override string ToString() => default; // 0x00000001876C6260-0x00000001876C6514
			public string __iFixBaseProxy_ToString() => default; // 0x00000001876C6588-0x00000001876C65EC
		}
	
		internal struct PointTriangleContact // TypeDefIndex: 45753
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
			public override string ToString() => default; // 0x00000001876C6D64-0x00000001876C6E38
			public string __iFixBaseProxy_ToString() => default; // 0x00000001832D8120-0x00000001832D8140
		}
	
		private struct InitPrimitiveJob : IJobParallelFor // TypeDefIndex: 45754
		{
			// Fields
			public int teamId; // 0x00
			public TeamManager.TeamData tdata; // 0x08
			public uint kind; // 0x1D8
			public int startPrimitive; // 0x1DC
			public int startSort; // 0x1E0
			public NativeArray<int2> edges; // 0x1E8
			public NativeArray<int3> triangles; // 0x1F8
			public NativeArray<Primitive> primitiveArray; // 0x208
			public NativeArray<SortData> sortArray; // 0x218
	
			// Methods
			public void Execute(int index) {} // 0x00000001876C6CC8-0x00000001876C6D64
		}
	
		private struct ClearBufferJob : IJob // TypeDefIndex: 45755
		{
			// Fields
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x00
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001864BB614-0x00000001864BB734
		}
	
		private struct UpdatePrimitiveJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45756
		{
			// Fields
			public uint kind; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			public NativeArray<ClothParameters> parameterArray; // 0x18
			public NativeArray<VertexAttribute> attributes; // 0x28
			public NativeArray<float> depthArray; // 0x38
			public NativeArray<double3> nextPosArray; // 0x48
			public NativeArray<double3> oldPosArray; // 0x58
			public NativeArray<float> frictionArray; // 0x68
			public NativeArray<Primitive> primitiveArray; // 0x78
			public NativeArray<SortData> sortAndSweepArray; // 0x88
			public NativeArray<uint> processingArray; // 0x98
			public NativeReference<int> _indexCount; // 0xA8
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001876C6AC0-0x00000001876C6BC4
			public void Execute() {} // 0x00000001876C6BC4-0x00000001876C6C18
			public void Execute(int index) {} // 0x0000000185F45D20-0x0000000185F45DB0
			public void UnsafeDo() {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct SortJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45757
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeArray<Primitive> primitiveArray; // 0x10
			public NativeArray<SortData> sortAndSweepArray; // 0x20
			public int _indexCount; // 0x30
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x0000000185F45D10-0x0000000185F45D20
			public void Execute() {} // 0x00000001876C6C18-0x00000001876C6CC8
			public void Execute(int index) {} // 0x00000001876C6D64-0x00000001876C6E38
			public void UnsafeDo() {} // 0x00000001832D8120-0x00000001832D8140
		}
	
		private struct PointTriangleBroadPhaseJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 45758
		{
			// Fields
			public uint mainKind; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			public NativeArray<int3> triangles; // 0x18
			public NativeArray<VertexAttribute> attributes; // 0x28
			public NativeArray<double3> nextPosArray; // 0x38
			public NativeArray<double3> oldPosArray; // 0x48
			public NativeArray<float> frictionArray; // 0x58
			public NativeArray<Primitive> primitiveArray; // 0x68
			public NativeArray<SortData> sortAndSweepArray; // 0x78
			public NativeArray<uint> processingPointTriangleArray; // 0x88
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x98
			public NativeArray<byte> intersectFlagArray; // 0xB0
			public NativeReference<int> _indexCount; // 0xC0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001876C705C-0x00000001876C70F8
			public void Execute() {} // 0x00000001864BB614-0x00000001864BB734
			public void Execute(int index) {} // 0x00000001876C6E38-0x00000001876C6F3C
			private void SweepTest(int sortIndex, ref Primitive primitive0, in SortData sd0, in DataChunk subChunk, bool connectionCheck) {} // 0x00000001876C6F3C-0x00000001876C6F90
			private void BroadPointTriangle(ref Primitive p_pri, ref Primitive t_pri, float thickness, float scr, float ang) {} // 0x0000000185F45C80-0x0000000185F45D10
		}
	
		private struct EdgeEdgeBroadPhaseJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 45759
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeArray<Primitive> primitiveArray; // 0x10
			public NativeArray<SortData> sortAndSweepArray; // 0x20
			public NativeArray<uint> processingEdgeEdgeArray; // 0x30
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x40
			public NativeArray<byte> intersectFlagArray; // 0x58
			public NativeReference<int> _indexCount; // 0x68
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185492010-0x0000000185492020
			public void Execute() {} // 0x0000000185F45C70-0x0000000185F45C80
			public void Execute(int index) {} // 0x00000001876C6F90-0x00000001876C705C
			private void SweepTest(int sortIndex, ref Primitive primitive0, in SortData sd0, in DataChunk subChunk, bool connectionCheck) {} // 0x0000000184808D50-0x0000000184808DF0
			private void BroadEdgeEdge(ref Primitive pri0, ref Primitive pri1, float thickness, float scr) {} // 0x00000001876C3AA8-0x00000001876C3B20
		}
	
		private struct EdgeEdgeToListJob : IJob // TypeDefIndex: 45760
		{
			// Fields
			public NativeQueue<EdgeEdgeContact> edgeEdgeContactQueue; // 0x00
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001876C39D4-0x00000001876C3AA8
		}
	
		private struct PointTriangleToListJob : IJob // TypeDefIndex: 45761
		{
			// Fields
			public NativeQueue<PointTriangleContact> pointTriangleContactQueue; // 0x00
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001846A1190-0x00000001846A11D0
		}
	
		private struct UpdateEdgeEdgeBroadPhaseJob : IJobParallelForDefer // TypeDefIndex: 45762
		{
			// Fields
			public NativeArray<float3> nextPosArray; // 0x00
			public NativeArray<float3> oldPosArray; // 0x10
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x00000001840DBFE0-0x00000001840DC090
		}
	
		private struct UpdatePointTriangleBroadPhaseJob : IJobParallelForDefer // TypeDefIndex: 45763
		{
			// Fields
			public NativeArray<double3> nextPosArray; // 0x00
			public NativeArray<double3> oldPosArray; // 0x10
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x00000001876C1E64-0x00000001876C1E70
		}
	
		private struct SolverEdgeEdgeJob : IJobParallelForDefer // TypeDefIndex: 45764
		{
			// Fields
			public NativeArray<float3> nextPosArray; // 0x00
			public NativeArray<EdgeEdgeContact> edgeEdgeContactArray; // 0x10
			public NativeArray<int> countArray; // 0x20
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x00000001876C1E10-0x00000001876C1E64
		}
	
		private struct SolverPointTriangleJob : IJobParallelForDefer // TypeDefIndex: 45765
		{
			// Fields
			public NativeArray<float3> nextPosArray; // 0x00
			public NativeArray<PointTriangleContact> pointTriangleContactArray; // 0x10
			public NativeArray<int> countArray; // 0x20
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x0000000185FB10B0-0x0000000185FB10C0
		}
	
		private struct IntersectUpdatePrimitiveJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45766
		{
			// Fields
			public uint kind; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			public NativeArray<double3> nextPosArray; // 0x18
			public NativeArray<Primitive> primitiveArray; // 0x28
			public NativeArray<uint> processingArray; // 0x38
			public NativeReference<int> _indexCount; // 0x48
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185FB10E0-0x0000000185FB10F0
			public void Execute() {} // 0x0000000185FB10C0-0x0000000185FB10E0
			public void Execute(int index) {} // 0x00000001876B9E38-0x00000001876B9EA8
			public void UnsafeDo() {} // 0x00000001876C61D0-0x00000001876C6260
		}
	
		private struct IntersectEdgeTriangleJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob // TypeDefIndex: 45767
		{
			// Fields
			public uint mainKind; // 0x00
			public int execNumber; // 0x04
			public int div; // 0x08
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<Primitive> primitiveArray; // 0x20
			public NativeArray<SortData> sortAndSweepArray; // 0x30
			public NativeArray<uint> processingEdgeEdgeArray; // 0x40
			public NativeArray<byte> intersectFlagArray; // 0x50
			public NativeReference<int> _indexCount; // 0x60
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185FB10B0-0x0000000185FB10C0
			public void Execute() {} // 0x00000001876BCA0C-0x00000001876BCC28
			public void Execute(int index) {} // 0x00000001876BCC28-0x00000001876BCC90
			private void SweepTest(ref Primitive primitive0, in SortData sd0, in DataChunk subChunk, bool connectionCheck) {} // 0x00000001876C1A74-0x00000001876C1CB8
			private void IntersectTest(ref Primitive epri, ref Primitive tpri) {} // 0x00000001876C1CB8-0x00000001876C1D18
		}
	
		private static class SolverPointTriangleCrossFrameJobKernels // TypeDefIndex: 45772
		{
			// Nested types
			public unsafe delegate void SolverPointTriangleCrossFrameKernel_0000017E_PostfixBurstDelegate(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 45768; 0x00000001876BB7DC-0x00000001876BB86C
	
			internal static class SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall // TypeDefIndex: 45769
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall() {} // 0x00000001876C6660-0x00000001876C695C
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000612f4) {} // 0x00000001876C95D4-0x00000001876C9EB0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876C9FB4-0x00000001876CA12C
				public static void Constructor() {} // 0x00000001876C69D0-0x00000001876C6A28
				public static void Initialize() {} // 0x00000001876C695C-0x00000001876C69D0
				public static unsafe void Invoke(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001876C6A28-0x00000001876C6AC0
			}
	
			public unsafe delegate void SolverPointTriangleCrossFrameRangeKernel_0000017F_PostfixBurstDelegate(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 45770; 0x00000001876C15EC-0x00000001876C1684
	
			internal static class SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall // TypeDefIndex: 45771
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall() {} // 0x00000001876BC708-0x00000001876BCA0C
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061309) {} // 0x00000001876C0678-0x00000001876C0CD0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876BC6A0-0x00000001876BC708
				public static void Constructor() {} // 0x00000001876BBF58-0x00000001876BBFEC
				public static void Initialize() {} // 0x00000001876BBFEC-0x00000001876BC6A0
				public static unsafe void Invoke(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001876BBA28-0x00000001876BBF58
			}
	
			// Methods
			private static unsafe void SolverPointTriangleCrossFrameKernel(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001876BCC90-0x00000001876BCD88
			internal static unsafe void SolverPointTriangleCrossFrameRangeKernel(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001876C1D18-0x00000001876C1E10
			public static unsafe void SolverPointTriangleCrossFrameKernel_BurstManaged(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001876C7768-0x00000001876C7E94
			public static unsafe void SolverPointTriangleCrossFrameRangeKernel_BurstManaged(double3* nextPosArray, PointTriangleContact* pointTriangleContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001876C8510-0x00000001876C8AF4
		}
	
		private static class SolverEdgeEdgeCrossFrameJobKernels // TypeDefIndex: 45777
		{
			// Nested types
			public unsafe delegate void SolverEdgeEdgeCrossFrameKernel_00000180_PostfixBurstDelegate(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 45773; 0x00000001876C594C-0x00000001876C61D0
	
			internal static class SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall // TypeDefIndex: 45774
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall() {} // 0x00000001876BD044-0x00000001876BD940
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061332) {} // 0x00000001876BE29C-0x00000001876BE6D0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876BE7CC-0x00000001876BE890
				public static void Constructor() {} // 0x00000001876BDDCC-0x00000001876BDE34
				public static void Initialize() {} // 0x00000001876BD940-0x00000001876BD9D4
				public static unsafe void Invoke(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001876BDE34-0x00000001876BE108
			}
	
			public unsafe delegate void SolverEdgeEdgeCrossFrameRangeKernel_00000181_PostfixBurstDelegate(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 45775; 0x00000001876C5240-0x00000001876C52BC
	
			internal static class SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall // TypeDefIndex: 45776
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061347) {} // 0x00000001876C52BC-0x00000001876C5328
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876C4868-0x00000001876C493C
				public static void Constructor() {} // 0x00000001817C0490-0x00000001817C04B0
				public static void Initialize() {} // 0x00000001876C55C0-0x00000001876C566C
				public static unsafe void Invoke(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length) {} // 0x00000001876C53A4-0x00000001876C54A8
			}
	
			// Methods
			private static unsafe void SolverEdgeEdgeCrossFrameKernel(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index) {} // 0x00000001876C54A8-0x00000001876C54FC
			internal static unsafe void SolverEdgeEdgeCrossFrameRangeKernel(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length) {} // 0x0000000185F45E60-0x0000000185F45EF0
			public static unsafe void SolverEdgeEdgeCrossFrameKernel_BurstManaged(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int index) {} // 0x0000000185492010-0x0000000185492020
			public static unsafe void SolverEdgeEdgeCrossFrameRangeKernel_BurstManaged(double3* nextPosArray, EdgeEdgeContact* edgeEdgeContactArray, int* countArray, int* sumArray, int length) {} // 0x0000000185F45E50-0x0000000185F45E60
		}
	
		private struct UpdateEdgeEdgeBroadPhaseCrossFrameJob : IJob // TypeDefIndex: 45778
		{
			// Fields
			public NativeReference<int> indexCount; // 0x00
			public NativeArray<double3> nextPosArray; // 0x10
			public NativeArray<double3> oldPosArray; // 0x20
			public NativeList<EdgeEdgeContact> edgeEdgeContactList; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x00000001876C54FC-0x00000001876C55C0
			public void Execute() {} // 0x00000001876C4868-0x00000001876C493C
		}
	
		private struct UpdatePointTriangleBroadPhaseCrossFrameJob : IJob // TypeDefIndex: 45779
		{
			// Fields
			public NativeReference<int> indexCount; // 0x00
			public NativeArray<double3> nextPosArray; // 0x10
			public NativeArray<double3> oldPosArray; // 0x20
			public NativeList<PointTriangleContact> pointTriangleContactList; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x00000001817C0490-0x00000001817C04B0
			public void Execute() {} // 0x00000001876C58A0-0x00000001876C594C
		}
	
		private struct SolverEdgeEdgeCrossFrameJob : IJob, IUnsafeJob // TypeDefIndex: 45780
		{
			// Fields
			public NativeArray<double3> nextPosArray; // 0x00
			public NativeArray<EdgeEdgeContact> edgeEdgeContactArray; // 0x10
			public NativeArray<int> countArray; // 0x20
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x00000001864BB614-0x00000001864BB734
			public void Execute() {} // 0x00000001876C566C-0x00000001876C5770
			public void UnsafeDo() {} // 0x00000001876C5770-0x00000001876C57C4
		}
	
		private struct SolverPointTriangleCrossFrameJob : IJob, IUnsafeJob // TypeDefIndex: 45781
		{
			// Fields
			public NativeArray<double3> nextPosArray; // 0x00
			public NativeArray<PointTriangleContact> pointTriangleContactArray; // 0x10
			public NativeArray<int> countArray; // 0x20
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x0000000185F45DC0-0x0000000185F45E50
			public void Execute() {} // 0x0000000185492010-0x0000000185492020
			public void UnsafeDo() {} // 0x0000000185F45DB0-0x0000000185F45DC0
		}
	
		// Constructors
		public SelfCollisionConstraint() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		public void Dispose() {} // 0x00000001876C45A0-0x00000001876C46A4
		public bool HasPrimitive() => default; // 0x00000001876C46A4-0x00000001876C46F8
		public override string ToString() => default; // 0x0000000185F45FA0-0x0000000185F46030
		internal void Register(ClothProcess cprocess) {} // 0x0000000185492010-0x0000000185492020
		internal void Exit(ClothProcess cprocess) {} // 0x0000000185F45F90-0x0000000185F45FA0
		internal void UpdateTeam(int teamId) {} // 0x00000001876C46F8-0x00000001876C47BC
		private void InitPrimitive(int teamId, TeamManager.TeamData tdata, uint kind, int startPrimitive, int startSort, int length) {} // 0x00000001876C4868-0x00000001876C493C
		internal void WorkBufferUpdate() {} // 0x00000001817C0490-0x00000001817C04B0
		private static int BinarySearchSortAndlSweep(ref NativeArray<SortData> sortAndSweepArray, in SortData sd, in DataChunk chunk) => default; // 0x00000001876C4B70-0x00000001876C4C1C
		internal JobHandle SolverConstraint(int updateIndex, JobHandle jobHandle) => default; // 0x00000001864BB614-0x00000001864BB734
		private JobHandle SolverRuntimeSelfCollision(int updateIndex, JobHandle jobHandle) => default; // 0x00000001876C493C-0x00000001876C4A40
		private JobHandle SolverBroadPhase(JobHandle jobHandle) => default; // 0x00000001876C4A40-0x00000001876C4A94
		private JobHandle UpdateBroadPhase(JobHandle jobHandle) => default; // 0x0000000185F45F00-0x0000000185F45F90
		private JobHandle SolveIntersect(JobHandle jobHandle) => default; // 0x0000000185492010-0x0000000185492020
		public static void Initialize_IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145_BurstDirectCall() {} // 0x0000000185F45EF0-0x0000000185F45F00
		public static void Initialize_IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146_BurstDirectCall() {} // 0x00000001876C4A94-0x00000001876C4B70
		public static void Initialize_UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147_BurstDirectCall() {} // 0x00000001876C718C-0x00000001876C7768
		public static void Initialize_UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148_BurstDirectCall() {} // 0x00000001876C70F8-0x00000001876C718C
		public static void Initialize_ClearBufferJobKernels_ClearBufferKernel_00000149_BurstDirectCall() {} // 0x00000001876C7E94-0x00000001876C847C
		public static void Initialize_SortJobKernels_SortKernel_0000014A_BurstDirectCall() {} // 0x00000001876C847C-0x00000001876C8510
		public static void Initialize_SortJobKernels_SortRangeKernel_0000014B_BurstDirectCall() {} // 0x00000001876C3DB4-0x00000001876C4500
		public static void Initialize_SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E_BurstDirectCall() {} // 0x00000001876C3D40-0x00000001876C3DB4
		public static void Initialize_SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F_BurstDirectCall() {} // 0x00000001876C4500-0x00000001876C45A0
		public static void Initialize_SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180_BurstDirectCall() {} // 0x00000001876D3CC4-0x00000001876D4400
		public static void Initialize_SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181_BurstDirectCall() {} // 0x00000001876D4400-0x00000001876D4474
		public string __iFixBaseProxy_ToString() => default; // 0x00000001876D4474-0x00000001876D4514
	}

	public class SpringConstraint : IDisposable // TypeDefIndex: 45785
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 45783
		{
			// Fields
			public bool useSpring; // 0x10
			public float springPower; // 0x14
			public float limitDistance; // 0x18
			public float normalLimitRatio; // 0x1C
			public float springNoise; // 0x20
	
			// Constructors
			public SerializeData() {} // 0x00000001876D4514-0x00000001876D4558
	
			// Methods
			public void DataValidate() {} // 0x00000001876D4558-0x00000001876D45DC
			public SerializeData Clone() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		public struct SpringConstraintParams // TypeDefIndex: 45784
		{
			// Fields
			public float springPower; // 0x00
			public float limitDistance; // 0x04
			public float normalLimitRatio; // 0x08
			public float springNoise; // 0x0C
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000185FB1100-0x0000000185FB1120
		}
	
		// Constructors
		public SpringConstraint() {} // 0x00000001840DE240-0x00000001840DE2B0
	
		// Methods
		public void Dispose() {} // 0x00000001876D2230-0x00000001876D22FC
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x00000001876D2024-0x00000001876D20E8
	}

	internal static class TethreConstraintJobKernels // TypeDefIndex: 45790
	{
		// Nested types
		public unsafe delegate void TethreConstraintKernel_00000193_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index); // TypeDefIndex: 45786; 0x00000001876D4BB4-0x00000001876D4CA0
	
		internal static class TethreConstraintKernel_00000193_BurstDirectCall // TypeDefIndex: 45787
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static TethreConstraintKernel_00000193_BurstDirectCall() {} // 0x00000001876D53BC-0x00000001876D54C0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000613a7) {} // 0x00000001876C005C-0x00000001876C0130
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876BFFC0-0x00000001876C005C
			public static void Constructor() {} // 0x00000001876D5698-0x00000001876D5784
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index) {} // 0x00000001876D54C0-0x00000001876D5514
		}
	
		public unsafe delegate void TethreConstraintRangeKernel_00000194_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr); // TypeDefIndex: 45788; 0x0000000185492010-0x0000000185492020
	
		internal static class TethreConstraintRangeKernel_00000194_BurstDirectCall // TypeDefIndex: 45789
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static TethreConstraintRangeKernel_00000194_BurstDirectCall() {} // 0x00000001876D5784-0x00000001876D5888
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_000613d4) {} // 0x00000001876C0560-0x00000001876C0634
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876C04C0-0x00000001876C0560
			public static void Constructor() {} // 0x00000001876C0430-0x00000001876C04C0
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr) {} // 0x00000001876D5888-0x00000001876D58DC
		}
	
		// Methods
		private static unsafe void TethreConstraintKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index) {} // 0x0000000185F45820-0x0000000185F458B0
		internal static unsafe void TethreConstraintRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void TethreConstraintKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int index) {} // 0x0000000185F45810-0x0000000185F45820
		public static unsafe void TethreConstraintRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, int* vertexRootIndices, short* teamIdArray, double3* nextPosArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionBuffer, int* lengthPtr) {} // 0x00000001876D58DC-0x00000001876D5A84
	}

	public class TetherConstraint : IDisposable // TypeDefIndex: 45794
	{
		// Nested types
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 45791
		{
			// Fields
			public float distanceCompression; // 0x10
	
			// Constructors
			public SerializeData() {} // 0x00000001876D4620-0x00000001876D4664
	
			// Methods
			public void DataValidate() {} // 0x0000000184708100-0x00000001847086A0
			public SerializeData Clone() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		public struct TetherConstraintParams // TypeDefIndex: 45792
		{
			// Fields
			public float compressionLimit; // 0x00
			public float stretchLimit; // 0x04
	
			// Methods
			public void Convert(SerializeData sdata, ClothProcess.ClothType clothType) {} // 0x0000000185FB1120-0x0000000185FB1130
		}
	
		private struct TethreConstraintJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45793
		{
			// Fields
			public NativeArray<int> stepParticleIndexArray; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<ClothParameters> parameterArray; // 0x20
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x30
			public NativeArray<VertexAttribute> attributes; // 0x40
			public NativeArray<float> vertexDepths; // 0x50
			public NativeArray<int> vertexRootIndices; // 0x60
			public NativeArray<short> teamIdArray; // 0x70
			public NativeArray<double3> nextPosArray; // 0x80
			public NativeArray<double3> velocityPosArray; // 0x90
			public NativeArray<float> frictionArray; // 0xA0
			public NativeArray<double3> stepBasicPositionBuffer; // 0xB0
			public NativeReference<int> _indexCount; // 0xC0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001876D2170-0x00000001876D21DC
			public void Execute() {} // 0x00000001876D20E8-0x00000001876D2170
			public void Execute(int index) {} // 0x00000001840DE0A0-0x00000001840DE100
			public void UnsafeDo() {} // 0x0000000184D00840-0x0000000184D008E0
		}
	
		// Constructors
		public TetherConstraint() {} // 0x00000001876D5218-0x00000001876D53BC
	
		// Methods
		public void Dispose() {} // 0x00000001876D4CA0-0x00000001876D4D38
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x00000001876D4D38-0x00000001876D5218
	}

	public class TriangleBendingConstraint : IDisposable // TypeDefIndex: 45811
	{
		// Fields
		private const sbyte VOLUME_SIGN = 100; // Metadata: 0x0205E724
		public ExNativeArray<ulong> trianglePairArray; // 0x10
		public ExNativeArray<float> restAngleOrVolumeArray; // 0x18
		public ExNativeArray<sbyte> signOrVolumeArray; // 0x20
		public ExNativeArray<uint> writeDataArray; // 0x28
		public ExNativeArray<uint> writeIndexArray; // 0x30
		public ExNativeArray<float3> writeBuffer; // 0x38
		private const float VolumeScale = 1000f; // Metadata: 0x0205E725
	
		// Properties
		public int DataCount { get => default; } // 0x00000001876D21DC-0x00000001876D2230 
	
		// Nested types
		private static class TriangleBendingJobKernels // TypeDefIndex: 45799
		{
			// Nested types
			public unsafe delegate void TriangleBendingKernel_000001AA_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index); // TypeDefIndex: 45795; 0x000000018551BF60-0x000000018551C3F0
	
			internal static class TriangleBendingKernel_000001AA_BurstDirectCall // TypeDefIndex: 45796
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static TriangleBendingKernel_000001AA_BurstDirectCall() {} // 0x0000000184D60610-0x0000000184D607E0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061464) {} // 0x00000001855E2E20-0x00000001855E47C0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876D5FF0-0x00000001876D62B0
				public static void Constructor() {} // 0x00000001876D5C8C-0x00000001876D5FF0
				public static void Initialize() {} // 0x00000001840D9C80-0x00000001840D9D70
				public static unsafe void Invoke(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x0000000184704420-0x0000000184704680
			}
	
			public unsafe delegate void TriangleBendingRangeKernel_000001AB_PostfixBurstDelegate(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // TypeDefIndex: 45797; 0x000000018568CDB0-0x000000018568CE10
	
			internal static class TriangleBendingRangeKernel_000001AB_BurstDirectCall // TypeDefIndex: 45798
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static TriangleBendingRangeKernel_000001AB_BurstDirectCall() {} // 0x00000001876D6544-0x00000001876D6FB4
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061497) {} // 0x000000018765AF34-0x000000018765AF3C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876D7610-0x00000001876D7718
				public static void Constructor() {} // 0x00000001876D7718-0x00000001876D7824
				public static void Initialize() {} // 0x00000001876D7824-0x00000001876D7F6C
				public static unsafe void Invoke(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001876D6FB4-0x00000001876D7610
			}
	
			// Methods
			private static unsafe void TriangleBendingKernel(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001876CC2EC-0x00000001876CC430
			internal static unsafe void TriangleBendingRangeKernel(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x000000018765D100-0x000000018765D1D4
			private static bool Volume(in double3x4 nextPosBuffer, in double4 invMassBuffer, double volumeRest, double stiffness, ref double3x4 addPosBuffer) => default; // 0x000000018765D04C-0x000000018765D100
			private static bool DihedralAngle(double sign, in double3x4 nextPosBuffer, in double4 invMassBuffer, double restAngle, double stiffness, ref double3x4 addPosBuffer) => default; // 0x00000001876D9E18-0x00000001876D9F1C
			public static unsafe void TriangleBendingKernel_BurstManaged(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void TriangleBendingRangeKernel_BurstManaged(float4* simulationPowerPtr, int* stepTriangleBendIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, float* depthArray, double3* nextPosArray, float* frictionArray, ulong* trianglePairArray, float* restAngleOrVolumeArray, sbyte* signOrVolumeArray, uint* writeDataArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001876D9ADC-0x00000001876D9BE0
		}
	
		private static class SolveAggregateBufferJobKernels // TypeDefIndex: 45804
		{
			// Nested types
			public unsafe delegate void SolveAggregateBufferKernel_000001AE_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index); // TypeDefIndex: 45800; 0x0000000185F45780-0x0000000185F45810
	
			internal static class SolveAggregateBufferKernel_000001AE_BurstDirectCall // TypeDefIndex: 45801
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveAggregateBufferKernel_000001AE_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000614dc) {} // 0x00000001876D9C34-0x00000001876D9E18
				private static IntPtr GetFunctionPointer() => default; // 0x000000018765D670-0x000000018765D744
				public static void Constructor() {} // 0x000000018765D5B8-0x000000018765D670
				public static void Initialize() {} // 0x000000018765D510-0x000000018765D5B8
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001876D9F1C-0x00000001876DA020
			}
	
			public unsafe delegate void SolveAggregateBufferRangeKernel_000001AF_PostfixBurstDelegate(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr); // TypeDefIndex: 45802; 0x0000000185F456E0-0x0000000185F45770
	
			internal static class SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall // TypeDefIndex: 45803
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall() {} // 0x00000001876D2D84-0x00000001876D2E28
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000614fa) {} // 0x00000001876DA074-0x00000001876DA258
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876D2CDC-0x00000001876D2D84
				public static void Constructor() {} // 0x00000001876D2E28-0x00000001876D2ED0
				public static void Initialize() {} // 0x00000001876D295C-0x00000001876D2CDC
				public static unsafe void Invoke(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001876D3814-0x00000001876D38E8
			}
	
			// Methods
			private static unsafe void SolveAggregateBufferKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001876D37B8-0x00000001876D3814
			internal static unsafe void SolveAggregateBufferRangeKernel(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001876D3700-0x00000001876D37B8
			public static unsafe void SolveAggregateBufferKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void SolveAggregateBufferRangeKernel_BurstManaged(int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, short* teamIdArray, double3* nextPosArray, uint* writeIndexArray, float3* writeBuffer, int* lengthPtr) {} // 0x00000001876D3494-0x00000001876D3598
		}
	
		public enum Method // TypeDefIndex: 45805
		{
			None = 0,
			DihedralAngle = 1,
			DirectionDihedralAngle = 2
		}
	
		[Serializable]
		public class SerializeData : IDataValidate // TypeDefIndex: 45806
		{
			// Fields
			public float stiffness; // 0x10
	
			// Constructors
			public SerializeData() {} // 0x00000001876D3598-0x00000001876D35EC
	
			// Methods
			public void DataValidate() {} // 0x0000000185F46220-0x0000000185F462B0
			public SerializeData Clone() => default; // 0x0000000185492010-0x0000000185492020
		}
	
		public struct TriangleBendingConstraintParams // TypeDefIndex: 45807
		{
			// Fields
			public Method method; // 0x00
			public float stiffness; // 0x04
	
			// Methods
			public void Convert(SerializeData sdata) {} // 0x0000000185F46210-0x0000000185F46220
		}
	
		[Serializable]
		public class ConstraintData : IValid // TypeDefIndex: 45808
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
			public ConstraintData() {} // 0x00000001876D3BF0-0x00000001876D3CC4
	
			// Methods
			public bool IsValid() => default; // 0x00000001876D35EC-0x00000001876D3700
		}
	
		private struct TriangleBendingJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45809
		{
			// Fields
			public float4 simulationPower; // 0x00
			public NativeArray<int> stepTriangleBendIndexArray; // 0x10
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x20
			public NativeArray<ClothParameters> parameterArray; // 0x30
			public NativeArray<VertexAttribute> attributes; // 0x40
			public NativeArray<float> depthArray; // 0x50
			public NativeArray<double3> nextPosArray; // 0x60
			public NativeArray<float> frictionArray; // 0x70
			public NativeArray<ulong> trianglePairArray; // 0x80
			public NativeArray<float> restAngleOrVolumeArray; // 0x90
			public NativeArray<sbyte> signOrVolumeArray; // 0xA0
			public NativeArray<uint> writeDataArray; // 0xB0
			public NativeArray<uint> writeIndexArray; // 0xC0
			public NativeArray<float3> writeBuffer; // 0xD0
			public NativeReference<int> _indexCount; // 0xE0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000187211EDC-0x0000000187211F38
			public void Execute() {} // 0x00000001876D3B7C-0x00000001876D3BF0
			public void Execute(int index) {} // 0x00000001864BB614-0x00000001864BB734
			private bool Volume(in double3x4 nextPosBuffer, in double4 invMassBuffer, double volumeRest, double stiffness, ref double3x4 addPosBuffer) => default; // 0x00000001876D38E8-0x00000001876D39EC
			private bool DihedralAngle(double sign, in double3x4 nextPosBuffer, in double4 invMassBuffer, double restAngle, double stiffness, ref double3x4 addPosBuffer) => default; // 0x00000001876D39EC-0x00000001876D3A40
			public void UnsafeDo() {} // 0x0000000185F46180-0x0000000185F46210
		}
	
		private struct SolveAggregateBufferJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45810
		{
			// Fields
			public NativeArray<int> stepParticleIndexArray; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<VertexAttribute> attributes; // 0x20
			public NativeArray<short> teamIdArray; // 0x30
			public NativeArray<double3> nextPosArray; // 0x40
			public NativeArray<uint> writeIndexArray; // 0x50
			public NativeArray<float3> writeBuffer; // 0x60
			public NativeReference<int> _indexCount; // 0x70
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185492010-0x0000000185492020
			public void Execute() {} // 0x0000000185F46170-0x0000000185F46180
			public void Execute(int index) {} // 0x00000001876D3A40-0x00000001876D3B7C
			public void UnsafeDo() {} // 0x0000000185FB10F0-0x0000000185FB1100
		}
	
		// Constructors
		public TriangleBendingConstraint() {} // 0x00000001876D1F9C-0x00000001876D2024
	
		// Methods
		public void Dispose() {} // 0x00000001840DE100-0x00000001840DE160
		public override string ToString() => default; // 0x00000001840D9520-0x00000001840D9560
		public static ConstraintData CreateData(VirtualMesh proxyMesh, in ClothParameters parameters) => default; // 0x0000000185492010-0x0000000185492020
		private static void InitVolume(VirtualMesh proxyMesh, int v0, int v1, int v2, int v3, out float volumeRest, out sbyte signFlag) {
			volumeRest = default;
			signFlag = default;
		} // 0x00000001876D910C-0x00000001876D9178
		private static void InitDihedralAngle(VirtualMesh proxyMesh, int v0, int v1, int v2, int v3, out float restAngle, out sbyte signFlag) {
			restAngle = default;
			signFlag = default;
		} // 0x00000001876D9074-0x00000001876D910C
		internal void Register(ClothProcess cprocess) {} // 0x00000001876D89DC-0x00000001876D9074
		internal void Exit(ClothProcess cprocess) {} // 0x00000001876D9390-0x00000001876D9ADC
		internal JobHandle SolverConstraint(JobHandle jobHandle) => default; // 0x00000001876D7F6C-0x00000001876D89DC
		public static void Initialize_TriangleBendingJobKernels_TriangleBendingKernel_000001AA_BurstDirectCall() {} // 0x00000001876D9178-0x00000001876D9390
		public static void Initialize_TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB_BurstDirectCall() {} // 0x00000001876D331C-0x00000001876D3384
		public static void Initialize_SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE_BurstDirectCall() {} // 0x00000001876D2ED0-0x00000001876D2F64
		public static void Initialize_SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF_BurstDirectCall() {} // 0x00000001876D2F64-0x00000001876D331C
		public string __iFixBaseProxy_ToString() => default; // 0x00000001876D3384-0x00000001876D3494
	}

	[Serializable]
	public class CullingSettings : IDataValidate // TypeDefIndex: 45815
	{
		// Fields
		public CameraCullingMode cameraCullingMode; // 0x10
		public CameraCullingMethod cameraCullingMethod; // 0x14
		public List<Renderer> cameraCullingRenderers; // 0x18
		public CheckSliderSerializeData distanceCullingLength; // 0x20
		public float distanceCullingFadeRatio; // 0x28
		public GameObject distanceCullingReferenceObject; // 0x30
	
		// Nested types
		public enum CameraCullingMode // TypeDefIndex: 45812
		{
			Off = 0,
			Reset = 10,
			Keep = 20,
			AnimatorLinkage = 30
		}
	
		public enum CameraCullingMethod // TypeDefIndex: 45813
		{
			AutomaticRenderer = 0,
			ManualRenderer = 10
		}
	
		public struct CullingParams // TypeDefIndex: 45814
		{
			// Fields
			public bool useDistanceCulling; // 0x00
			public float distanceCullingLength; // 0x04
			public float distanceCullingFadeRatio; // 0x08
	
			// Methods
			public void Convert(CullingSettings cullingSettings) {} // 0x0000000184808BC0-0x0000000184808C90
		}
	
		// Constructors
		public CullingSettings() {} // 0x00000001876CD680-0x00000001876CD6F0
	
		// Methods
		public void DataValidate() {} // 0x00000001876CD544-0x00000001876CD680
		public CullingSettings Clone() => default; // 0x00000001876CD6F0-0x00000001876CD73C
		public override int GetHashCode() => default; // 0x0000000185FB0F10-0x0000000185FB0F20
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001840DE040-0x00000001840DE0A0
	}

	[Serializable]
	public class CurveSerializeData // TypeDefIndex: 45816
	{
		// Fields
		public float value; // 0x10
		public bool useCurve; // 0x14
		public AnimationCurve curve; // 0x18
	
		// Constructors
		public CurveSerializeData() {} // 0x00000001876CDB9C-0x00000001876CDBD8
		public CurveSerializeData(float value) {} // 0x00000001847124C0-0x0000000184712550
		public CurveSerializeData(float value, float curveStart, float curveEnd, bool useCurve = true /* Metadata: 0x0205E732 */) {} // 0x0000000184714A70-0x0000000184714B40
		public CurveSerializeData(float value, AnimationCurve curve) {} // 0x00000001876CDB34-0x00000001876CDB9C
	
		// Methods
		public void SetValue(float value) {} // 0x00000001876CDA00-0x00000001876CDA60
		public void SetValue(float value, float curveStart, float curveEnd, bool useCurve = true /* Metadata: 0x0205E733 */) {} // 0x00000001876CDA60-0x00000001876CDB34
		public void SetValue(float value, AnimationCurve curve) {} // 0x00000001876CD980-0x00000001876CDA00
		public void DataValidate(float min, float max) {} // 0x00000001876CD880-0x00000001876CD904
		public float Evaluate(float time) => default; // 0x00000001876CD904-0x00000001876CD980
		public float4x4 ConvertFloatArray() => default; // 0x00000001840DCC50-0x00000001840DCD50
		public CurveSerializeData Clone() => default; // 0x00000001876CD73C-0x00000001876CD880
	}

	[Serializable]
	public class CustomSkinningSettings : IValid, IDataValidate, ITransform // TypeDefIndex: 45818
	{
		// Fields
		public bool enable; // 0x10
		public List<Transform> skinningBones; // 0x18
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 45817
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, bool> __9__3_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001876CDCC4-0x00000001876CDD04
			public __c() {} // 0x00000001876CDEF8-0x00000001876CE06C
	
			// Methods
			internal bool _IsValid_b__3_0(Transform n) => default; // 0x00000001876CDBD8-0x00000001876CDCC4
		}
	
		// Constructors
		public CustomSkinningSettings() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void DataValidate() {} // 0x00000001876CDD04-0x00000001876CDD50
		public bool IsValid() => default; // 0x00000001876CDD50-0x00000001876CDEF8
		public CustomSkinningSettings Clone() => default; // 0x00000001876CE06C-0x00000001876CE1E8
		public override int GetHashCode() => default; // 0x00000001848090E0-0x0000000184809160
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000185FB0F10-0x0000000185FB0F20
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001876DA2A4-0x00000001876DA308
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001876DA258-0x00000001876DA2A4
	}

	[Serializable]
	public class GizmoSerializeData // TypeDefIndex: 45819
	{
		// Fields
		public bool always; // 0x10
		public ClothDebugSettings clothDebugSettings; // 0x18
	
		// Constructors
		public GizmoSerializeData() {} // 0x00000001876D0168-0x00000001876D01E0
	
		// Methods
		public bool IsAlways() => default; // 0x00000001876D011C-0x00000001876D0168
	}

	[Serializable]
	public class NormalAlignmentSettings : IValid, IDataValidate, ITransform // TypeDefIndex: 45821
	{
		// Fields
		public AlignmentMode alignmentMode; // 0x10
		public Transform adjustmentTransform; // 0x18
	
		// Nested types
		public enum AlignmentMode // TypeDefIndex: 45820
		{
			None = 0,
			BoundingBoxCenter = 1,
			Transform = 2
		}
	
		// Constructors
		public NormalAlignmentSettings() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void DataValidate() {} // 0x00000001876D0274-0x00000001876D02B4
		public bool IsValid() => default; // 0x00000001876D0450-0x00000001876D04A0
		public NormalAlignmentSettings Clone() => default; // 0x00000001876D01E0-0x00000001876D0274
		public override int GetHashCode() => default; // 0x00000001876D02B4-0x00000001876D0394
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x00000001876D0394-0x00000001876D0450
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001876D04A0-0x00000001876D05A8
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000185FB0F10-0x0000000185FB0F20
	}

	[Serializable]
	public class SelectionData : IValid // TypeDefIndex: 45825
	{
		// Fields
		public float3[] positions; // 0x10
		public VertexAttribute[] attributes; // 0x18
		public float maxConnectionDistance; // 0x20
		public bool userEdit; // 0x24
	
		// Properties
		public int Count { get => default; } // 0x00000001846A0F90-0x00000001846A10C0 
	
		// Nested types
		private struct TransformPositionJob : IJobParallelFor // TypeDefIndex: 45822
		{
			// Fields
			public float4x4 transformMatrix; // 0x00
			public NativeArray<float3> localPositions; // 0x40
	
			// Methods
			public void Execute(int index) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct CreateGridMapJob : IJob // TypeDefIndex: 45823
		{
			// Fields
			public bool move; // 0x00
			public bool fix; // 0x01
			public bool ignore; // 0x02
			public bool invalid; // 0x03
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x08
			public float gridSize; // 0x18
			public NativeArray<float3> positions; // 0x20
			public NativeArray<VertexAttribute> attribute; // 0x30
	
			// Methods
			public void Execute() {} // 0x00000001876D1F10-0x00000001876D1F8C
		}
	
		private struct ConvertSelectionJob : IJobParallelFor // TypeDefIndex: 45824
		{
			// Fields
			public float gridSize; // 0x00
			public float radius; // 0x04
			public NativeArray<float3> toPositions; // 0x08
			public NativeArray<VertexAttribute> toAttributes; // 0x18
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x28
			public NativeArray<float3> fromPositions; // 0x38
			public NativeArray<VertexAttribute> fromAttributes; // 0x48
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001876D1C48-0x00000001876D1F10
		}
	
		// Constructors
		public SelectionData() {} // 0x00000001876D1F8C-0x00000001876D1F9C
		public SelectionData(int cnt) {} // 0x00000001858247C0-0x0000000185824820
		public SelectionData(VirtualMesh vmesh, float4x4 transformMatrix) {} // 0x00000001876D19C4-0x00000001876D1A10
	
		// Methods
		public bool IsValid() => default; // 0x00000001876D0E68-0x00000001876D109C
		public bool IsUserEdit() => default; // 0x00000001876D0CAC-0x00000001876D0E68
		public SelectionData Clone() => default; // 0x00000001876D17D4-0x00000001876D1858
		public bool Compare(SelectionData sdata) => default; // 0x0000000185419A90-0x0000000185419B00
		public void AddRange(float3[] addPositions, VertexAttribute[] addAttributes = null) {} // 0x00000001876D1858-0x00000001876D19C4
		public void Fill(VertexAttribute attr) {} // 0x0000000185419B00-0x0000000185419B70
		public NativeArray<float3> GetPositionNativeArray() => default; // 0x0000000185419B70-0x0000000185419D00
		public NativeArray<float3> GetPositionNativeArray(float4x4 transformMatrix) => default; // 0x00000001876D1A10-0x00000001876D1C48
		public NativeArray<VertexAttribute> GetAttributeNativeArray() => default; // 0x00000001876D109C-0x00000001876D17D4
		public static GridMap<int> CreateGridMapRun(float gridSize, in NativeArray<float3> positions, in NativeArray<VertexAttribute> attributes, bool move = true /* Metadata: 0x0205E737 */, bool fix = true /* Metadata: 0x0205E738 */, bool ignore = true /* Metadata: 0x0205E739 */, bool invalid = true /* Metadata: 0x0205E73A */) => default; // 0x00000001876D5A84-0x00000001876D5B4C
		public void Merge(SelectionData from) {} // 0x000000018550A2F0-0x000000018550A410
		public void ConvertFrom(SelectionData from) {} // 0x00000001876CD0E0-0x00000001876CD544
	}

	public class BeyondBoneWindZone : ClothBehaviour // TypeDefIndex: 45827
	{
		// Fields
		public Mode mode; // 0x20
		public Vector3 size; // 0x24
		public float radius; // 0x30
		public float main; // 0x34
		public float turbulence; // 0x38
		public float directionAngleX; // 0x3C
		public float directionAngleY; // 0x40
		public AnimationCurve attenuation; // 0x48
		public bool isAddition; // 0x50
		private int _WindId_k__BackingField; // 0x54
	
		// Properties
		public int WindId { get; private set; } // 0x0000000185FB0670-0x0000000185FB0680 0x0000000185FB06A0-0x0000000185FB06B0
	
		// Nested types
		public enum Mode // TypeDefIndex: 45826
		{
			GlobalDirection = 0,
			SphereDirection = 1,
			BoxDirection = 2,
			SphereRadial = 10
		}
	
		// Constructors
		public BeyondBoneWindZone() {} // 0x00000001876CCA34-0x00000001876CCAA8
	
		// Methods
		public void Awake() {} // 0x00000001876CC430-0x00000001876CC4C0
		public void Start() {} // 0x00000001876CC9F0-0x00000001876CCA34
		public void OnEnable() {} // 0x00000001876CC7FC-0x00000001876CC88C
		public void OnDisable() {} // 0x00000001876CC76C-0x00000001876CC7FC
		public void OnDestroy() {} // 0x00000001876CC6DC-0x00000001876CC76C
		public bool IsDirection() => default; // 0x00000001876CC63C-0x00000001876CC68C
		public bool IsRadial() => default; // 0x00000001876CC68C-0x00000001876CC6DC
		public bool IsAddition() => default; // 0x00000001876CC5F0-0x00000001876CC63C
		public Vector3 GetWindDirection(bool localSpace = false /* Metadata: 0x0205E73B */) => default; // 0x00000001876CC4C0-0x00000001876CC5F0
		public void SetWindDirection(Vector3 dir, bool localSpace = false /* Metadata: 0x0205E73C */) {} // 0x00000001876CC88C-0x00000001876CC9F0
	}

	public struct WindParams : IValid // TypeDefIndex: 45828
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
		public void Convert(WindSettings sdata, ClothProcess.ClothType clothType) {} // 0x00000001840DE1D0-0x00000001840DE240
		public bool IsValid() => default; // 0x00000001876DA308-0x00000001876DA360
	}

	[Serializable]
	public class WindSettings : IValid, IDataValidate // TypeDefIndex: 45829
	{
		// Fields
		public float influence; // 0x10
		public float frequency; // 0x14
		public float turbulence; // 0x18
		public float blend; // 0x1C
		public float synchronization; // 0x20
		public float depthWeight; // 0x24
		public float movingWind; // 0x28
	
		// Constructors
		public WindSettings() {} // 0x0000000185FB1130-0x0000000185FB1160
	
		// Methods
		public bool IsValid() => default; // 0x00000001876DA534-0x00000001876DA58C
		public void DataValidate() {} // 0x00000001876DA438-0x00000001876DA534
		public WindSettings Clone() => default; // 0x00000001876DA360-0x00000001876DA438
	}

	public static class Define // TypeDefIndex: 45832
	{
		// Nested types
		public enum Result // TypeDefIndex: 45830
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
	
		public static class System // TypeDefIndex: 45831
		{
			// Fields
			public const int LatestPreBuildVersion = 2; // Metadata: 0x0205E8BE
			public const float Epsilon = 1E-08f; // Metadata: 0x0205E8BF
			public const int MaxRendererCount = 31; // Metadata: 0x0205E8C3
			public const float MinimumGridSize = 1E-05f; // Metadata: 0x0205E8C4
			public const int MaximumTeamCount = 4096; // Metadata: 0x0205E8C8
			public const int DefaultSimulationFrequency = 90; // Metadata: 0x0205E8CA
			public const int SimulationFrequency_Low = 30; // Metadata: 0x0205E8CC
			public const int SimulationFrequency_Hi = 150; // Metadata: 0x0205E8CD
			public const int DefaultMaxSimulationCountPerFrame = 3; // Metadata: 0x0205E8CF
			public const int MaxSimulationCountPerFrame_Low = 1; // Metadata: 0x0205E8D0
			public const int MaxSimulationCountPerFrame_Hi = 5; // Metadata: 0x0205E8D1
			public const float SameSurfaceAngle = 80f; // Metadata: 0x0205E8D2
			public const float MaxDistanceRatioFutuerPrediction = 1.3f; // Metadata: 0x0205E8D6
			public const bool ReductionEnable = true; // Metadata: 0x0205E8DA
			public const float ReductionSameDistance = 0.001f; // Metadata: 0x0205E8DB
			public const bool ReductionDontMakeLine = true; // Metadata: 0x0205E8DF
			public const float ReductionJoinPositionAdjustment = 1f; // Metadata: 0x0205E8E0
			public const int ReductionMaxStep = 100; // Metadata: 0x0205E8E4
			public const int MaxProxyMeshVertexCount = 32767; // Metadata: 0x0205E8E6
			public const int MaxProxyMeshEdgeCount = 32767; // Metadata: 0x0205E8EA
			public const int MaxProxyMeshTriangleCount = 32767; // Metadata: 0x0205E8EE
			public const float ProxyMeshTrianglePairAngle = 20f; // Metadata: 0x0205E8F2
			public const float ProxyMeshBoneClothTriangleAngle = 120f; // Metadata: 0x0205E8F6
			public const float FrictionMass = 3f; // Metadata: 0x0205E8FA
			public const float DepthMass = 5f; // Metadata: 0x0205E8FE
			public const float FrictionDampingRate = 0.6f; // Metadata: 0x0205E902
			public const float PositionAverageExponent = 0.5f; // Metadata: 0x0205E906
			public const float MaxRealVelocity = 0.5f; // Metadata: 0x0205E90A
			public const float TetherCompressionStiffness = 1f; // Metadata: 0x0205E90E
			public const float TetherStretchStiffness = 1f; // Metadata: 0x0205E912
			public const float TetherStretchLimit = 0.03f; // Metadata: 0x0205E916
			public const float TetherStiffnessWidth = 0.3f; // Metadata: 0x0205E91A
			public const float TetherCompressionVelocityAttenuation = 0.7f; // Metadata: 0x0205E91E
			public const float TetherStretchVelocityAttenuation = 0.7f; // Metadata: 0x0205E922
			public const float DistanceVelocityAttenuation = 0.3f; // Metadata: 0x0205E926
			public const float DistanceVerticalStiffness = 1f; // Metadata: 0x0205E92A
			public const float DistanceHorizontalStiffness = 0.5f; // Metadata: 0x0205E92E
			public const float TriangleBendingMaxAngle = 120f; // Metadata: 0x0205E932
			public const float VolumeMinAngle = 90f; // Metadata: 0x0205E936
			public const float MaxAngleLimit = 179f; // Metadata: 0x0205E93A
			public const int AngleLimitIteration = 3; // Metadata: 0x0205E93E
			public const float AngleLimitAttenuation = 0.9f; // Metadata: 0x0205E93F
			public const float MaxMovementSpeedLimit = 10f; // Metadata: 0x0205E943
			public const float MaxRotationSpeedLimit = 1440f; // Metadata: 0x0205E947
			public const float MaxParticleSpeedLimit = 10f; // Metadata: 0x0205E94B
			public const int ExpandedColliderCount = 8; // Metadata: 0x0205E94F
			public const float ColliderCollisionDynamicFrictionRatio = 1f; // Metadata: 0x0205E950
			public const float ColliderCollisionStaticFrictionRatio = 1f; // Metadata: 0x0205E954
			public const float CustomSkinningAngularAttenuation = 1f; // Metadata: 0x0205E958
			public const float CustomSkinningDistanceReduction = 0.6f; // Metadata: 0x0205E95C
			public const float CustomSkinningDistancePow = 2f; // Metadata: 0x0205E960
			public const int SelfCollisionSolverIteration = 4; // Metadata: 0x0205E964
			public const float SelfCollisionFixedMass = 100f; // Metadata: 0x0205E965
			public const float SelfCollisionFrictionMass = 10f; // Metadata: 0x0205E969
			public const float SelfCollisionClothMass = 50f; // Metadata: 0x0205E96D
			public const float SelfCollisionSCR = 2f; // Metadata: 0x0205E971
			public static readonly float SelfCollisionPointTriangleAngleCos; // 0x00
			public const int SelfCollisionIntersectDiv = 8; // Metadata: 0x0205E975
			public const float SelfCollisionThicknessMin = 0.001f; // Metadata: 0x0205E976
			public const float SelfCollisionThicknessMax = 0.05f; // Metadata: 0x0205E97A
			public const float WindMaxTime = 10000f; // Metadata: 0x0205E97E
			public const float WindBaseSpeed = 7.5f; // Metadata: 0x0205E982
			public const float BoneSpringDistanceStiffness = 0.5f; // Metadata: 0x0205E986
			public const float BoneSpringTetherCompressionLimit = 0.8f; // Metadata: 0x0205E98A
			public const float BoneSpringCollisionFriction = 0.5f; // Metadata: 0x0205E98E
			public const float DistanceCullingMaxLength = 100f; // Metadata: 0x0205E992
	
			// Constructors
			static System() {} // 0x00000001876D45DC-0x00000001876D4620
		}
	}

	internal interface ICount // TypeDefIndex: 45833
	{
		// Methods
		int Count();
	}

	internal interface IDataValidate // TypeDefIndex: 45834
	{
		// Methods
		void DataValidate();
	}

	internal interface ITransform // TypeDefIndex: 45835
	{
		// Methods
		void GetUsedTransform(HashSet<Transform> transformSet);
		void ReplaceTransform(Dictionary<int, Transform> replaceDict);
	}

	internal interface IValid // TypeDefIndex: 45836
	{
		// Methods
		bool IsValid();
	}

	public class ClothManager : IManager, IValid // TypeDefIndex: 45837
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
		public ClothManager() {} // 0x0000000184CCA440-0x0000000184CCA5B0
		static ClothManager() {} // 0x0000000185B5C160-0x0000000185B5C3E0
	
		// Methods
		public void Dispose() {} // 0x00000001876CCAA8-0x00000001876CCFA0
		public void EnterdEditMode() {} // 0x00000001876CCFA0-0x00000001876CCFF0
		public void Initialize() {} // 0x0000000184CCCBC0-0x0000000184CCD100
		public bool IsValid() => default; // 0x00000001876CD044-0x00000001876CD090
		private void ClearMasterJob() {} // 0x0000000185285360-0x0000000185285390
		private void CompleteMasterJob() {} // 0x0000000184487450-0x00000001844875B0
		public void ForceCompleteAllJob() {} // 0x0000000184486220-0x0000000184486430
		internal int AddCloth(ClothProcess cprocess, in ClothParameters clothParams) => default; // 0x0000000184B385E0-0x0000000184B38810
		internal void RemoveCloth(ClothProcess cprocess) {} // 0x0000000184D618D0-0x0000000184D619D0
		private void OnEarlyClothUpdate() {} // 0x0000000184408D70-0x0000000184409060
		private void OnAfterUpdate() {} // 0x0000000184F7E480-0x0000000184F7E5B0
		private void OnApplicationQuit() {} // 0x00000001876CD090-0x00000001876CD0E0
		private void OnBeforeLateUpdate() {} // 0x0000000184F8F540-0x0000000184F8F620
		private void OnAfterLateUpdate() {} // 0x0000000184299E10-0x0000000184299F00
		private void ClothUpdate() {} // 0x0000000184297F80-0x0000000184299B50
		internal void ClearVisibleDict() {} // 0x0000000184483DA0-0x0000000184483F30
		internal bool CheckVisible(Animator ani, List<Renderer> renderers) => default; // 0x0000000184483F30-0x00000001844840B0
		internal bool CheckLODVisible(Animator ani, int clothAnimatorAbilityLODThresholdProperty, int clothAnimatorLODThresholdProperty) => default; // 0x0000000184484980-0x0000000184484BB0
		private bool CheckRendererVisible(List<Renderer> renderers) => default; // 0x00000001844840B0-0x0000000184484940
		public void InformationLog(StringBuilder allsb) {} // 0x00000001876CCFF0-0x00000001876CD044
	}

	public class PreBuildManager : IManager, IValid // TypeDefIndex: 45839
	{
		// Fields
		private Dictionary<SharePreBuildData, ShareDeserializationData> deserializationDict; // 0x10
		private bool isValid; // 0x18
		private static readonly ProfilerMarker deserializationProfiler; // 0x00
	
		// Nested types
		internal class ShareDeserializationData : IDisposable // TypeDefIndex: 45838
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
			public int RenderMeshCount { get => default; } // 0x0000000184CCAFA0-0x0000000184CCAFD0 
	
			// Constructors
			public ShareDeserializationData() {} // 0x000000018486FE60-0x000000018486FFB0
	
			// Methods
			public void Dispose() {} // 0x00000001876D05A8-0x00000001876D0758
			public void Deserialize(SharePreBuildData sharePreBuilddata) {} // 0x00000001876D0758-0x00000001876D07A8
			public VirtualMeshContainer GetProxyMeshContainer() => default; // 0x00000001876D0C60-0x00000001876D0CAC
			public VirtualMeshContainer GetRenderMeshContainer(int index) => default; // 0x00000001876D07A8-0x00000001876D0C60
		}
	
		// Constructors
		public PreBuildManager() {} // 0x00000001876D2844-0x00000001876D2924
		static PreBuildManager() {} // 0x0000000184870010-0x00000001848700E0
	
		// Methods
		public void Dispose() {} // 0x000000018486FDC0-0x000000018486FE60
		public void EnterdEditMode() {} // 0x000000018486E110-0x000000018486E1C0
		public void Initialize() {} // 0x000000018486DCE0-0x000000018486E080
		public bool IsValid() => default; // 0x0000000184CCB150-0x0000000184CCB1D0
		public void InformationLog(StringBuilder allsb) {} // 0x0000000185F65AB0-0x0000000185F65B10
		internal ShareDeserializationData RegisterPreBuildData(SharePreBuildData sdata, bool referenceIncrement) => default; // 0x00000001876D22FC-0x00000001876D27A8
		internal ShareDeserializationData GetPreBuildData(SharePreBuildData sdata) => default; // 0x0000000184870BE0-0x0000000184871480
		internal void UnregisterPreBuildData(SharePreBuildData sdata) {} // 0x00000001876D2924-0x00000001876D295C
		internal void UnloadUnusedData() {} // 0x00000001876D27A8-0x00000001876D2844
	}

	public struct DoAllInOneJob : IJob // TypeDefIndex: 45840
	{
		// Fields
		public GCHandle bmHandle; // 0x00
		public GCHandle tmHandle; // 0x08
		public GCHandle vmHandle; // 0x10
		public GCHandle smHandle; // 0x18
		public GCHandle wmHandle; // 0x20
		public GCHandle meshClothSetHandle; // 0x28
	
		// Methods
		public void Execute() {} // 0x00000001876CE1E8-0x00000001876CE8E4
	}

	public interface ICrossFrameParallelForJob : IJob // TypeDefIndex: 45841
	{
		// Methods
		void SetIndexCount(int indexCount);
	}

	public interface ICrossFrameParallelForDeferJob : IJob // TypeDefIndex: 45842
	{
		// Methods
		void SetIndexCount(NativeReference<int> indexCount);
	}

	public interface IUnsafeJob // TypeDefIndex: 45843
	{
		// Methods
		void UnsafeDo();
	}

	public static class CrossFrameJobUtils // TypeDefIndex: 45844
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

	public class DynamicBoneTransformManager : IManager, IValid // TypeDefIndex: 45864
	{
		// Fields
		internal const byte Flag_Read = 1; // Metadata: 0x0205E996
		internal const byte Flag_WorldRotWrite = 2; // Metadata: 0x0205E997
		internal const byte Flag_LocalPosRotWrite = 4; // Metadata: 0x0205E998
		internal const byte Flag_Restore = 8; // Metadata: 0x0205E999
		internal const byte Flag_Enable = 16; // Metadata: 0x0205E99A
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
		internal int Count { get => default; } // 0x00000001876BEB84-0x00000001876BEB98 
	
		// Nested types
		private static class WriteAnimatorBufferDataJobKernels // TypeDefIndex: 45849
		{
			// Nested types
			public unsafe delegate void WriteAnimatorBufferDataKernel_0000025C_PostfixBurstDelegate(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 45845; 0x00000001876CF924-0x00000001876CFC30
	
			internal static class WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall // TypeDefIndex: 45846
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall() {} // 0x00000001876CF8D4-0x00000001876CF924
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000615dd) {} // 0x0000000184BB4C60-0x0000000184BB4CA0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001849480A0-0x00000001849482F0
				public static void Constructor() {} // 0x00000001876CEE50-0x00000001876CEEA0
				public static void Initialize() {} // 0x000000018551C3F0-0x000000018551C890
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x0000000184B39FC0-0x0000000184B3A380
			}
	
			public unsafe delegate void WriteAnimatorBufferDataRangeKernel_0000025D_PostfixBurstDelegate(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 45847; 0x00000001876CE8E4-0x00000001876CEE50
	
			internal static class WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall // TypeDefIndex: 45848
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall() {} // 0x0000000184BB4690-0x0000000184BB4920
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061604) {} // 0x0000000184D5FBE0-0x0000000184D5FE60
				private static IntPtr GetFunctionPointer() => default; // 0x0000000184483BF0-0x0000000184483CC0
				public static void Constructor() {} // 0x0000000184B3CC70-0x0000000184B3CD20
				public static void Initialize() {} // 0x00000001876CEEA0-0x00000001876CF1E0
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x0000000184BB4920-0x0000000184BB4C60
			}
	
			// Methods
			private static unsafe void WriteAnimatorBufferDataKernel(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001876CFEF4-0x00000001876D011C
			internal static unsafe void WriteAnimatorBufferDataRangeKernel(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x0000000184F1DE30-0x0000000184F1E030
			public static unsafe void WriteAnimatorBufferDataKernel_BurstManaged(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x0000000184B38FE0-0x0000000184B390D0
			public static unsafe void WriteAnimatorBufferDataRangeKernel_BurstManaged(ExBitFlag8* flagList, float3* positionArray, quaternion* rotationArray, float3* localPositionArray, quaternion* localRotationArray, UnsafeParallelHashMap<int, int>* teamId2AnimatorInstanceIdPtr, UnsafeParallelHashMap<int, AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, UnsafeParallelHashMap<int, int>* transformID2RWHandlerIDPtr, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x0000000184D619D0-0x0000000184D61A60
		}
	
		private struct ReadAnimatorBufferDataJob : IJobCrossFrameTransform // TypeDefIndex: 45850
		{
			// Fields
			public NativeArray<ExBitFlag8> flagList; // 0x00
			public NativeArray<double3> positionArray; // 0x10
			public NativeArray<quaternion> rotationArray; // 0x20
			public NativeArray<float3> scaleList; // 0x30
			public NativeArray<float3> localPositionArray; // 0x40
			public NativeArray<quaternion> localRotationArray; // 0x50
			public NativeArray<float4x4> localToWorldMatrixArray; // 0x60
			public NativeParallelHashMap<int, int> teamId2AnimatorInstanceId; // 0x70
			public NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler; // 0x80
			public NativeParallelHashMap<int, int> transformID2RWHandlerID; // 0x90
			public NativeArray<short> teamIdArray; // 0xA0
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0xB0
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x0000000184BB4F50-0x0000000184BB5140
			private void _Do(int index, TransformAccess transform) {} // 0x00000001876CF1E0-0x00000001876CF8D4
		}
	
		private struct WriteAnimatorBufferDataJob : IJob, IUnsafeJob // TypeDefIndex: 45851
		{
			// Fields
			public NativeArray<ExBitFlag8> flagList; // 0x00
			public NativeArray<double3> positionArray; // 0x10
			public NativeArray<quaternion> rotationArray; // 0x20
			public NativeArray<float3> localPositionArray; // 0x30
			public NativeArray<quaternion> localRotationArray; // 0x40
			public NativeParallelHashMap<int, int> teamId2AnimatorInstanceId; // 0x50
			public NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler; // 0x60
			public NativeParallelHashMap<int, int> transformID2RWHandlerID; // 0x70
			public NativeArray<short> teamIdArray; // 0x80
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x90
	
			// Methods
			public void Execute() {} // 0x0000000185492010-0x0000000185492020
			public void UnsafeDo() {} // 0x000000018568CED0-0x000000018568CF30
		}
	
		private struct CopyDoubleBufferJob : IJob // TypeDefIndex: 45852
		{
			// Fields
			public NativeArray<double3> worldPositions; // 0x00
			public NativeArray<quaternion> worldRotations; // 0x10
			public NativeArray<float3> localPositions; // 0x20
			public NativeArray<quaternion> localRotations; // 0x30
			public NativeArray<double3> lastworldPositions; // 0x40
			public NativeArray<quaternion> lastworldRotations; // 0x50
			public NativeArray<float3> lastlocalPositions; // 0x60
			public NativeArray<quaternion> lastlocalRotations; // 0x70
	
			// Methods
			public void Execute() {} // 0x000000018568CF30-0x000000018568CF90
		}
	
		private struct EnableTransformJob : IJob // TypeDefIndex: 45853
		{
			// Fields
			public DataChunk chunk; // 0x00
			public bool sw; // 0x08
			public NativeArray<ExBitFlag8> flagList; // 0x10
	
			// Methods
			public void Execute() {} // 0x00000001876EA914-0x00000001876EA9E4
		}
	
		private struct RestoreTransformJob : IJobParallelForTransform // TypeDefIndex: 45854
		{
			// Fields
			public NativeArray<ExBitFlag8> flagList; // 0x00
			public NativeArray<float3> localPositionArray; // 0x10
			public NativeArray<quaternion> localRotationArray; // 0x20
			public NativeArray<short> teamIdArray; // 0x30
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x40
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001876EA9E4-0x00000001876EAAB4
		}
	
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 45855
		{
			// Fields
			public NativeArray<ExBitFlag8> flagList; // 0x00
			public NativeArray<double3> positionArray; // 0x10
			public NativeArray<quaternion> rotationArray; // 0x20
			public NativeArray<float3> scaleList; // 0x30
			public NativeArray<float3> localPositionArray; // 0x40
			public NativeArray<quaternion> localRotationArray; // 0x50
			public NativeArray<float4x4> localToWorldMatrixArray; // 0x60
			public NativeArray<short> teamIdArray; // 0x70
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x80
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001876EA0AC-0x00000001876EA914
		}
	
		public static class ValidTransformKernels // TypeDefIndex: 45860
		{
			// Nested types
			public unsafe delegate void ValidateTransformKernel_00000266_PostfixBurstDelegate(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 45856; 0x00000001876EB944-0x00000001876EBA18
	
			internal static class ValidateTransformKernel_00000266_BurstDirectCall // TypeDefIndex: 45857
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ValidateTransformKernel_00000266_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061641) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876EB5A4-0x00000001876EB6A8
				public static void Constructor() {} // 0x00000001876EB6A8-0x00000001876EB6FC
				public static void Initialize() {} // 0x0000000185F44920-0x0000000185F449B0
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x0000000185F44910-0x0000000185F44920
			}
	
			public unsafe delegate void ValidateTransformRangeKernel_00000267_PostfixBurstDelegate(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 45858; 0x00000001876EB944-0x00000001876EBA18
	
			internal static class ValidateTransformRangeKernel_00000267_BurstDirectCall // TypeDefIndex: 45859
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ValidateTransformRangeKernel_00000267_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061659) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876EBA18-0x00000001876EBB1C
				public static void Constructor() {} // 0x00000001876EBB1C-0x00000001876EBB70
				public static void Initialize() {} // 0x0000000185F44880-0x0000000185F44910
				public static unsafe void Invoke(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x0000000185F44870-0x0000000185F44880
			}
	
			// Methods
			public static unsafe void ValidateTransformKernel(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001876EBB70-0x00000001876EBCD8
			public static unsafe void ValidateTransformRangeKernel(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001876E36EC-0x00000001876E377C
			public static unsafe void ValidateTransformKernel_BurstManaged(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001876E377C-0x00000001876E4194
			public static unsafe void ValidateTransformRangeKernel_BurstManaged(ExBitFlag8* flagList, float3* worldPositions, float3* localPositions, short* teamIdArray, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001876EAAB4-0x00000001876EB41C
		}
	
		private struct ValidTransformJob : IJob, IUnsafeJob // TypeDefIndex: 45861
		{
			// Fields
			public NativeArray<ExBitFlag8> flagList; // 0x00
			public NativeArray<double3> worldPositions; // 0x10
			public NativeArray<float3> localPositions; // 0x20
			public NativeArray<short> teamIdArray; // 0x30
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x40
			public int count; // 0x50
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001876EB41C-0x00000001876EB5A4
			public void Execute() {} // 0x00000001876E2DFC-0x00000001876E2F20
			public void UnsafeDo() {} // 0x00000001876E2F20-0x00000001876E2FA8
			public void Execute(int index) {} // 0x00000001876E4928-0x00000001876E4B28
		}
	
		private struct WriteTransformJob : IJobParallelForTransform // TypeDefIndex: 45862
		{
			// Fields
			public NativeArray<ExBitFlag8> flagList; // 0x00
			public NativeArray<double3> lastpositionArray; // 0x10
			public NativeArray<quaternion> lastrotationArray; // 0x20
			public NativeArray<float3> lastlocalPositionArray; // 0x30
			public NativeArray<quaternion> lastlocalRotationArray; // 0x40
			public NativeArray<short> teamIdArray; // 0x50
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x60
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001876E4260-0x00000001876E4928
		}
	
		private struct ReadComponentTransformJob : IJobParallelForTransform // TypeDefIndex: 45863
		{
			// Fields
			public NativeArray<float3> positionArray; // 0x00
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001876E9858-0x00000001876E98E0
		}
	
		// Constructors
		public DynamicBoneTransformManager() {} // 0x00000001876E9740-0x00000001876E9794
	
		// Methods
		public JobHandle WriteAnimatorBufferData(JobHandle jobHandle, ref NativeParallelHashMap<int, int> teamId2AnimatorInstnceId, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler, ref NativeParallelHashMap<int, int> transformID2RWHandlerID) => default; // 0x00000001876E9960-0x00000001876E99E8
		public JobHandle ReadAnimatorBufferData(JobHandle jobHandle, ref NativeParallelHashMap<int, int> teamId2AnimatorInstnceId, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> animatorID2RWHandler, ref NativeParallelHashMap<int, int> transformID2RWHandlerID) => default; // 0x00000001876DCD98-0x00000001876DD8A8
		public JobHandle CopyDoubleBuffer(JobHandle jobHandle) => default; // 0x00000001876E98E0-0x00000001876E9960
		public JobHandle WriteDoubleBufferTransform(JobHandle jobHandle) => default; // 0x00000001876E9CCC-0x00000001876E9DA0
		public void Dispose() {} // 0x00000001876E9C14-0x00000001876E9CCC
		public void EnterdEditMode() {} // 0x00000001864BB614-0x00000001864BB734
		public void Initialize() {} // 0x00000001876E99E8-0x00000001876E9AEC
		public bool IsValid() => default; // 0x00000001876E9AEC-0x00000001876E9B40
		internal DataChunk AddTransform(VirtualMeshContainer cmesh, int teamId) => default; // 0x0000000185F44CE0-0x0000000185F44D70
		internal DataChunk AddTransform(int count, int teamId) => default; // 0x0000000185492010-0x0000000185492020
		internal DataChunk AddTransform(Transform t, ExBitFlag8 flag, int teamId) => default; // 0x0000000185F44CD0-0x0000000185F44CE0
		internal void SetTransform(Transform t, ExBitFlag8 flag, int index, int teamId) {} // 0x00000001876E9B40-0x00000001876E9C14
		internal void CopyTransform(int fromIndex, int toIndex) {} // 0x00000001876E9CCC-0x00000001876E9DA0
		internal void RemoveTransform(DataChunk c) {} // 0x00000001876BEB84-0x00000001876BEB98
		internal void EnableTransform(DataChunk c, bool sw) {} // 0x00000001876E9FF4-0x00000001876EA0AC
		internal void EnableTransform(int index, bool sw) {} // 0x00000001864BB614-0x00000001864BB734
		internal DataChunk Expand(DataChunk c, int newLength) => default; // 0x00000001876E9DA0-0x00000001876E9EA4
		public JobHandle RestoreTransform(JobHandle jobHandle) => default; // 0x00000001876E9EA4-0x00000001876E9EF8
		public JobHandle ReadTransform(JobHandle jobHandle) => default; // 0x0000000185F44C40-0x0000000185F44CD0
		public JobHandle WriteTransform(JobHandle jobHandle) => default; // 0x0000000185492010-0x0000000185492020
		public JobHandle ValidPosition(JobHandle jobHandle) => default; // 0x0000000185F44C30-0x0000000185F44C40
		internal int AddComponentTransform(Transform t) => default; // 0x00000001876E9EF8-0x00000001876E9FF4
		internal void RemoveComponentTransform(int index) {} // 0x0000000184F1E030-0x0000000184F1E070
		internal JobHandle ReadComponentTransform(JobHandle jobHandle) => default; // 0x00000001876E96D4-0x00000001876E9740
		public void InformationLog(StringBuilder allsb) {} // 0x00000001876E9794-0x00000001876E9858
		public static void Initialize_WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C_BurstDirectCall() {} // 0x00000001876EBDB0-0x00000001876EF970
		public static void Initialize_WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D_BurstDirectCall() {} // 0x00000001876E4194-0x00000001876E4260
	}

	public class TeamManager : IManager, IValid // TypeDefIndex: 45894
	{
		// Fields
		public const int Flag_Valid = 0; // Metadata: 0x0205E99B
		public const int Flag_Enable = 1; // Metadata: 0x0205E99C
		public const int Flag_Reset = 2; // Metadata: 0x0205E99D
		public const int Flag_TimeReset = 3; // Metadata: 0x0205E99E
		public const int Flag_SyncSuspend = 4; // Metadata: 0x0205E99F
		public const int Flag_Running = 5; // Metadata: 0x0205E9A0
		public const int Flag_Synchronization = 6; // Metadata: 0x0205E9A1
		public const int Flag_StepRunning = 7; // Metadata: 0x0205E9A2
		public const int Flag_Exit = 8; // Metadata: 0x0205E9A3
		public const int Flag_KeepTeleport = 9; // Metadata: 0x0205E9A4
		public const int Flag_InertiaShift = 10; // Metadata: 0x0205E9A5
		public const int Flag_CameraCullingInvisible = 11; // Metadata: 0x0205E9A6
		public const int Flag_CameraCullingKeep = 12; // Metadata: 0x0205E9A7
		public const int Flag_Spring = 13; // Metadata: 0x0205E9A8
		public const int Flag_SkipWriting = 14; // Metadata: 0x0205E9A9
		public const int Flag_Anchor = 15; // Metadata: 0x0205E9AA
		public const int Flag_AnchorReset = 16; // Metadata: 0x0205E9AB
		public const int Flag_NegativeScale = 17; // Metadata: 0x0205E9AC
		public const int Flag_NegativeScaleTeleport = 18; // Metadata: 0x0205E9AD
		public const int Flag_DistanceCullingInvisible = 19; // Metadata: 0x0205E9AE
		public const int Flag_RestoreTransformOnlyOnec = 20; // Metadata: 0x0205E9AF
		public const int Flag_Tangent = 21; // Metadata: 0x0205E9B0
		public const int Flag_Self_PointPrimitive = 32; // Metadata: 0x0205E9B1
		public const int Flag_Self_EdgePrimitive = 33; // Metadata: 0x0205E9B2
		public const int Flag_Self_TrianglePrimitive = 34; // Metadata: 0x0205E9B3
		public const int Flag_Self_EdgeEdge = 35; // Metadata: 0x0205E9B4
		public const int Flag_Sync_EdgeEdge = 36; // Metadata: 0x0205E9B5
		public const int Flag_PSync_EdgeEdge = 37; // Metadata: 0x0205E9B6
		public const int Flag_Self_PointTriangle = 38; // Metadata: 0x0205E9B7
		public const int Flag_Sync_PointTriangle = 39; // Metadata: 0x0205E9B8
		public const int Flag_PSync_PointTriangle = 40; // Metadata: 0x0205E9B9
		public const int Flag_Self_TrianglePoint = 41; // Metadata: 0x0205E9BA
		public const int Flag_Sync_TrianglePoint = 42; // Metadata: 0x0205E9BB
		public const int Flag_PSync_TrianglePoint = 43; // Metadata: 0x0205E9BC
		public const int Flag_Self_EdgeTriangleIntersect = 44; // Metadata: 0x0205E9BD
		public const int Flag_Sync_EdgeTriangleIntersect = 45; // Metadata: 0x0205E9BE
		public const int Flag_PSync_EdgeTriangleIntersect = 46; // Metadata: 0x0205E9BF
		public const int Flag_Self_TriangleEdgeIntersect = 47; // Metadata: 0x0205E9C0
		public const int Flag_Sync_TriangleEdgeIntersect = 48; // Metadata: 0x0205E9C1
		public const int Flag_PSync_TriangleEdgeIntersect = 49; // Metadata: 0x0205E9C2
		public const int Flag_Lod_LodOut = 60; // Metadata: 0x0205E9C3
		public const int Flag_Lod_Culled = 61; // Metadata: 0x0205E9C4
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
		public int MappingCount { get => default; } // 0x0000000185F48510-0x0000000185F48520 
		public int TeamCount { get => default; } // 0x00000001876F6200-0x00000001876F63E0 
		public int TrueTeamCount { get => default; } // 0x00000001876F65B8-0x00000001876F6680 
		public int ActiveTeamCount { get => default; } // 0x00000001876F6504-0x00000001876F65B8 
	
		// Nested types
		public static class SimulationStepTeamUpdateKernels // TypeDefIndex: 45873
		{
			// Nested types
			public unsafe delegate void SimulationStepTeamUpdateKernel_00000294_PostfixBurstDelegate(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId); // TypeDefIndex: 45865; 0x0000000184703660-0x00000001847036A0
	
			internal static class SimulationStepTeamUpdateKernel_00000294_BurstDirectCall // TypeDefIndex: 45866
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SimulationStepTeamUpdateKernel_00000294_BurstDirectCall() {} // 0x0000000185EDC820-0x0000000185EDC8C0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000616c8) {} // 0x00000001876E80FC-0x00000001876E8F4C
				private static IntPtr GetFunctionPointer() => default; // 0x0000000184D61DC0-0x0000000184D61E50
				public static void Constructor() {} // 0x00000001845CD3F0-0x00000001845CD580
				public static void Initialize() {} // 0x0000000184B3A410-0x0000000184B3A4C0
				public static unsafe void Invoke(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId) {} // 0x0000000184CCB2D0-0x0000000184CCB7A0
			}
	
			public unsafe delegate void SimulationStepTeamUpdateRangeKernel_00000295_PostfixBurstDelegate(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length); // TypeDefIndex: 45867; 0x0000000184874500-0x0000000184875180
	
			internal static class SimulationStepTeamUpdateRangeKernel_00000295_BurstDirectCall // TypeDefIndex: 45868
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static SimulationStepTeamUpdateRangeKernel_00000295_BurstDirectCall() {} // 0x0000000184D5D830-0x0000000184D5D8B0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000616e3) {} // 0x0000000184D61A60-0x0000000184D61D80
				private static IntPtr GetFunctionPointer() => default; // 0x0000000184483A00-0x0000000184483BF0
				public static void Constructor() {} // 0x0000000184486430-0x00000001844869F0
				public static void Initialize() {} // 0x00000001876E803C-0x00000001876E80FC
				public static unsafe void Invoke(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length) {} // 0x0000000184485E20-0x0000000184486220
			}
	
			public unsafe delegate void UpdateWind_00000296_PostfixBurstDelegate(int teamId, in TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime); // TypeDefIndex: 45869; 0x00000001856E0B10-0x00000001856E0BB0
	
			internal static class UpdateWind_00000296_BurstDirectCall // TypeDefIndex: 45870
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateWind_00000296_BurstDirectCall() {} // 0x0000000184701E50-0x0000000184702260
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000616fc) {} // 0x0000000184487BD0-0x0000000184488CC0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000184484C30-0x0000000184485BD0
				public static void Constructor() {} // 0x0000000184488D50-0x000000018448CE20
				public static void Initialize() {} // 0x00000001876E7FA0-0x00000001876E803C
				public static unsafe void Invoke(int teamId, in TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime) {} // 0x0000000184703CD0-0x00000001847040A0
			}
	
			public delegate void UpdateWindTime_00000297_PostfixBurstDelegate(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime); // TypeDefIndex: 45871; 0x00000001876E6614-0x00000001876E669C
	
			internal static class UpdateWindTime_00000297_BurstDirectCall // TypeDefIndex: 45872
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateWindTime_00000297_BurstDirectCall() {} // 0x000000018568CF90-0x000000018568CFF0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006170e) {} // 0x0000000184CCC100-0x0000000184CCC1A0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876E67FC-0x00000001876E7F54
				public static void Constructor() {} // 0x0000000184CCA1C0-0x0000000184CCA440
				public static void Initialize() {} // 0x0000000185BB8A70-0x0000000185BB8C70
				public static void Invoke(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime) {} // 0x000000018568CFF0-0x000000018568D050
			}
	
			// Methods
			public static unsafe void SimulationStepTeamUpdateKernel(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId) {} // 0x00000001876E5C84-0x00000001876E5D1C
			public static unsafe void SimulationStepTeamUpdateRangeKernel(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length) {} // 0x00000001876E5D1C-0x00000001876E5DB4
			private static unsafe void UpdateWind(int teamId, in TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime) {} // 0x00000001876E6148-0x00000001876E61D0
			private static void UpdateWindTime(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime) {} // 0x00000001876E5DB4-0x00000001876E5E18
			public static unsafe void SimulationStepTeamUpdateKernel_BurstManaged(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int teamId) {} // 0x00000001876E4F24-0x00000001876E5C84
			public static unsafe void SimulationStepTeamUpdateRangeKernel_BurstManaged(int updateIndex, float simulationDeltaTime, TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, int length) {} // 0x00000001876DC978-0x00000001876DCA0C
			public static unsafe void UpdateWind_BurstManaged(int teamId, in TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, TeamWindData* teamWindArray, float simulationDeltaTime) {} // 0x00000001876E5E18-0x00000001876E6148
			public static void UpdateWindTime_BurstManaged(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime) {} // 0x00000001876DCA0C-0x00000001876DCD98
		}
	
		private static class PostTeamUpdateJobKernels // TypeDefIndex: 45878
		{
			// Nested types
			public unsafe delegate void PostTeamUpdateKernel_00000298_PostfixBurstDelegate(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId); // TypeDefIndex: 45874; 0x00000001876E4E48-0x00000001876E4E5C
	
			internal static class PostTeamUpdateKernel_00000298_BurstDirectCall // TypeDefIndex: 45875
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostTeamUpdateKernel_00000298_BurstDirectCall() {} // 0x0000000185F46350-0x0000000185F46360
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061729) {} // 0x00000001876E4B28-0x00000001876E4C2C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876E4C2C-0x00000001876E4C80
				public static void Constructor() {} // 0x0000000185F46360-0x0000000185F463F0
				public static void Initialize() {} // 0x0000000185492010-0x0000000185492020
				public static unsafe void Invoke(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId) {} // 0x00000001876E4C80-0x00000001876E4D7C
			}
	
			public unsafe delegate void PostTeamUpdateRangeKernel_00000299_PostfixBurstDelegate(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // TypeDefIndex: 45876; 0x00000001876E4E48-0x00000001876E4E5C
	
			internal static class PostTeamUpdateRangeKernel_00000299_BurstDirectCall // TypeDefIndex: 45877
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostTeamUpdateRangeKernel_00000299_BurstDirectCall() {} // 0x0000000185F462B0-0x0000000185F462C0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061738) {} // 0x00000001876E61D0-0x00000001876E62D4
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876E62D4-0x00000001876E6328
				public static void Constructor() {} // 0x0000000185F462C0-0x0000000185F46350
				public static void Initialize() {} // 0x0000000185492010-0x0000000185492020
				public static unsafe void Invoke(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x00000001876E6328-0x00000001876E641C
			}
	
			// Methods
			private static unsafe void PostTeamUpdateKernel(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId) {} // 0x00000001876E960C-0x00000001876E96D4
			internal static unsafe void PostTeamUpdateRangeKernel(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x00000001876BEB84-0x00000001876BEB98
			public static unsafe void PostTeamUpdateKernel_BurstManaged(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int teamId) {} // 0x00000001876E94F0-0x00000001876E960C
			public static unsafe void PostTeamUpdateRangeKernel_BurstManaged(TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x00000001864BB614-0x00000001864BB734
		}
	
		public struct TeamData // TypeDefIndex: 45879
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
			public bool bUseRelativeTransform { get => default; } // 0x00000001876E92C0-0x00000001876E93C4 
			public bool IsFixedUpdate { get => default; } // 0x00000001876E93C4-0x00000001876E9418 
			public bool IsUnscaled { get => default; } // 0x0000000185F44D80-0x0000000185F44E10 
			public bool IsValid { get => default; } // 0x0000000185492010-0x0000000185492020 
			public bool IsEnable { get => default; } // 0x0000000185F44D70-0x0000000185F44D80 
			public bool IsLODCulled { get => default; } // 0x00000001876E9418-0x00000001876E94F0 
			public bool IsProcess { get => default; } // 0x00000001876E91EC-0x00000001876E92C0 
			public bool IsReset { get => default; } // 0x000000018340B160-0x000000018340B180 
			public bool IsKeepReset { get => default; } // 0x00000001876E9140-0x00000001876E91EC 
			public bool IsInertiaShift { get => default; } // 0x00000001864BB614-0x00000001864BB734 
			public bool IsRunning { get => default; } // 0x00000001876E8F4C-0x00000001876E9050 
			public bool IsStepRunning { get => default; } // 0x00000001876E9050-0x00000001876E90A4 
			public bool IsCameraCullingInvisible { get => default; } // 0x0000000185F44E20-0x0000000185F44EB0 
			public bool IsCameraCullingKeep { get => default; } // 0x0000000185492010-0x0000000185492020 
			public bool IsDistanceCullingInvisible { get => default; } // 0x0000000185F44E10-0x0000000185F44E20 
			public bool IsCullingInvisible { get => default; } // 0x00000001876E90A4-0x00000001876E9140 
			public bool IsSpring { get => default; } // 0x00000001876E2FF8-0x00000001876E3058 
			public bool IsNegativeScale { get => default; } // 0x00000001876E30A8-0x00000001876E3108 
			public bool IsNegativeScaleTeleport { get => default; } // 0x00000001876DB430-0x00000001876DC978 
			public bool IsTangent { get => default; } // 0x00000001876E3058-0x00000001876E30A8 
			public int ParticleCount { get => default; } // 0x00000001876E3384-0x00000001876E3458 
			public int ColliderCount { get => default; } // 0x0000000181A578C0-0x0000000181A578E0 
			public int BaseLineCount { get => default; } // 0x00000001876E32FC-0x00000001876E3384 
			public int TriangleCount { get => default; } // 0x00000001864BB614-0x00000001864BB734 
			public int EdgeCount { get => default; } // 0x00000001876E3108-0x00000001876E320C 
			public float InitScale { get => default; } // 0x00000001876E320C-0x00000001876E3260 
		}
	
		public struct MappingData : IValid // TypeDefIndex: 45880
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
			public int VertexCount { get => default; } // 0x0000000185492010-0x0000000185492020 
	
			// Methods
			public bool IsValid() => default; // 0x0000000185F46860-0x0000000185F468F0
		}
	
		private struct AlwaysTeamUpdatePreJob : IJob // TypeDefIndex: 45881
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
			public void Execute() {} // 0x0000000185F46850-0x0000000185F46860
		}
	
		private struct AlwaysTeamUpdatePostJob : IJob // TypeDefIndex: 45882
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
			public void Execute() {} // 0x00000001876E3260-0x00000001876E32FC
			private void DistanceCullingUpdate(int teamId, ref TeamData tdata) {} // 0x00000001876E3384-0x00000001876E3458
		}
	
		public static class CalcCenterAndInertiaAndWindKernels // TypeDefIndex: 45889
		{
			// Nested types
			public unsafe delegate void CalcCenterAndInertiaAndWindKernel_000002B9_PostfixBurstDelegate(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId); // TypeDefIndex: 45883; 0x00000001876E3664-0x00000001876E36EC
	
			internal static class CalcCenterAndInertiaAndWindKernel_000002B9_BurstDirectCall // TypeDefIndex: 45884
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcCenterAndInertiaAndWindKernel_000002B9_BurstDirectCall() {} // 0x00000001876E35B0-0x00000001876E3664
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000617a9) {} // 0x00000001876E355C-0x00000001876E35B0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185F467C0-0x0000000185F46850
				public static void Constructor() {} // 0x0000000185492010-0x0000000185492020
				public static void Initialize() {} // 0x0000000185F467B0-0x0000000185F467C0
				public static unsafe void Invoke(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId) {} // 0x00000001876E6608-0x00000001876E6614
			}
	
			public unsafe delegate void CalcCenterAndInertiaAndWindRangeKernel_000002BA_PostfixBurstDelegate(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length); // TypeDefIndex: 45885; 0x00000001876E6600-0x00000001876E6608
	
			internal static class CalcCenterAndInertiaAndWindRangeKernel_000002BA_BurstDirectCall // TypeDefIndex: 45886
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcCenterAndInertiaAndWindRangeKernel_000002BA_BurstDirectCall() {} // 0x00000001876E652C-0x00000001876E6538
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000617dc) {} // 0x000000018647405C-0x0000000186474070
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876E655C-0x00000001876E65CC
				public static void Constructor() {} // 0x00000001876E65CC-0x00000001876E65D4
				public static void Initialize() {} // 0x00000001876E6538-0x00000001876E6544
				public static unsafe void Invoke(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length) {} // 0x00000001876E65D4-0x00000001876E65DC
			}
	
			public unsafe delegate void Wind_000002BB_PostfixBurstDelegate(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray); // TypeDefIndex: 45887; 0x00000001876E64E8-0x00000001876E64F4
	
			internal static class Wind_000002BB_BurstDirectCall // TypeDefIndex: 45888
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Wind_000002BB_BurstDirectCall() {} // 0x00000001876E65F4-0x00000001876E6600
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000617fd) {} // 0x00000001876E6500-0x00000001876E6518
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876E65DC-0x00000001876E65E8
				public static void Constructor() {} // 0x00000001876E6550-0x00000001876E655C
				public static void Initialize() {} // 0x00000001876E6544-0x00000001876E6550
				public static unsafe void Invoke(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray) {} // 0x0000000185FB1190-0x0000000185FB11A0
			}
	
			// Methods
			public static unsafe void CalcCenterAndInertiaAndWindKernel(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId) {} // 0x0000000185FB1170-0x0000000185FB1180
			public static unsafe void CalcCenterAndInertiaAndWindRangeKernel(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length) {} // 0x0000000185FB1160-0x0000000185FB1170
			public static unsafe void Wind(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray) {} // 0x0000000185FB11A0-0x0000000185FB11B0
			public static unsafe void CalcCenterAndInertiaAndWindKernel_BurstManaged(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int teamId) {} // 0x0000000185FB1180-0x0000000185FB1190
			public static unsafe void CalcCenterAndInertiaAndWindRangeKernel_BurstManaged(float simulationDeltaTime, TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, ClothParameters* parameterArray, double3* positions, quaternion* rotations, quaternion* vertexBindPoseRotations, ushort* fixedArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int windZoneCount, WindManager.WindData* windDataArray, int length) {} // 0x0000000183F80440-0x0000000183F80450
			public static unsafe void Wind_BurstManaged(int teamId, ClothParameters* param, double3* centerWorldPos, TeamWindData* teamWindArray, int windZoneCount, WindManager.WindData* windDataArray) {} // 0x00000001876E2FA8-0x00000001876E2FF8
		}
	
		private struct CalcCenterAndInertiaAndWindJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45890
		{
			// Fields
			public float simulationDeltaTime; // 0x00
			public NativeArray<TeamData> teamDataArray; // 0x08
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x18
			public NativeArray<TeamWindData> teamWindArray; // 0x28
			public NativeArray<ClothParameters> parameterArray; // 0x38
			public NativeArray<double3> positions; // 0x48
			public NativeArray<quaternion> rotations; // 0x58
			public NativeArray<quaternion> vertexBindPoseRotations; // 0x68
			public NativeArray<ushort> fixedArray; // 0x78
			public NativeArray<double3> transformPositionArray; // 0x88
			public NativeArray<quaternion> transformRotationArray; // 0x98
			public NativeArray<float3> transformScaleArray; // 0xA8
			public int windZoneCount; // 0xB8
			public NativeArray<WindManager.WindData> windDataArray; // 0xC0
			public int _indexCount; // 0xD0
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001834AFB70-0x00000001834AFB80
			public void Execute() {} // 0x00000001876DE534-0x00000001876DFEB4
			public void Execute(int teamId) {} // 0x00000001876DDC38-0x00000001876DE534
			private void Wind(int teamId, in ClothParameters param, in double3 centerWorldPos) {} // 0x00000001876DD99C-0x00000001876DDC38
			public void UnsafeDo() {} // 0x00000001876E2364-0x00000001876E246C
		}
	
		private struct SimulationStepTeamUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45891
		{
			// Fields
			public int updateIndex; // 0x00
			public float simulationDeltaTime; // 0x04
			public NativeArray<TeamData> teamDataArray; // 0x08
			public NativeArray<ClothParameters> parameterArray; // 0x18
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x28
			public NativeArray<TeamWindData> teamWindArray; // 0x38
			public int _indexCount; // 0x48
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001876E2580-0x00000001876E2688
			public void Execute() {} // 0x00000001876E2D78-0x00000001876E2DFC
			public void Execute(int teamId) {} // 0x00000001876DFEB4-0x00000001876E2364
			private void UpdateWind(int teamId, in TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata) {} // 0x00000001876E246C-0x00000001876E2580
			private void UpdateWindTime(ref TeamWindInfo windInfo, float frequency, float simulationDeltaTime) {} // 0x00000001876E2688-0x00000001876E2D78
			public void UnsafeDo() {} // 0x00000001876F65B8-0x00000001876F6680
		}
	
		private struct PostTeamUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45892
		{
			// Fields
			public NativeArray<TeamData> teamDataArray; // 0x00
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x10
			public int _indexCount; // 0x20
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001876F6504-0x00000001876F65B8
			public void Execute() {} // 0x00000001876F63E0-0x00000001876F6504
			public void Execute(int teamId) {} // 0x00000001864BB614-0x00000001864BB734
			public void UnsafeDo() {} // 0x00000001876F60A8-0x00000001876F61AC
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45893
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<ClothProcess> __9__132_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001876F61AC-0x00000001876F6200
			public __c() {} // 0x0000000185F48520-0x0000000185F485B0
	
			// Methods
			internal void _MonitoringProcess_b__132_0(ClothProcess cprocess) {} // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public TeamManager() {} // 0x00000001876FD4A8-0x00000001876FD52C
		static TeamManager() {} // 0x00000001876FE684-0x00000001876FE6E8
	
		// Methods
		internal void UpdateTeamAnimatorData(ExNativeArray<short> teamIdArray, TransformAccessArray transformArray) {} // 0x00000001876F69B4-0x00000001876F6AD8
		internal void ClearTeamAnimatorData(int teamId) {} // 0x00000001864BB614-0x00000001864BB734
		internal void AddTeamAnimatorData(int teamId, ClothProcess cprocess) {} // 0x00000001876F6680-0x00000001876F6784
		internal void AddAnimatorTransform(int teamId, Transform t) {} // 0x00000001876F6784-0x00000001876F67D8
		internal void MarkAnimatorTransformDirty(int teamId, Transform t) {} // 0x0000000185F48480-0x0000000185F48510
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
		public void EnterdEditMode() {} // 0x0000000185F48470-0x0000000185F48480
		public void Initialize() {} // 0x00000001876F67D8-0x00000001876F69B4
		public bool IsValid() => default; // 0x0000000187700B24-0x0000000187700BEC
		internal int AddTeam(ClothProcess cprocess, ClothParameters clothParams) => default; // 0x00000001876BEB84-0x00000001876BEB98
		internal void RemoveTeam(int teamId) {} // 0x0000000187700A64-0x0000000187700B24
		public void SetEnable(int teamId, bool sw) {} // 0x00000001864BB614-0x00000001864BB734
		public bool IsEnable(int teamId) => default; // 0x000000018770083C-0x0000000187700940
		internal void SetSkipWriting(int teamId, bool sw) {} // 0x0000000187700940-0x0000000187700994
		public bool ContainsTeamData(int teamId) => default; // 0x0000000185F44B00-0x0000000185F44B90
		public ref TeamData GetTeamDataRef(int teamId) => ref _refReturnTypeForGetTeamDataRef; // 0x0000000185492010-0x0000000185492020
		private ref TeamData _refReturnTypeForGetTeamDataRef; // Dummy field
		public ref FixedList64Bytes<short> GetTeamMappingRef(int teamId) => ref _refReturnTypeForGetTeamMappingRef; // 0x0000000185F44AF0-0x0000000185F44B00
		private ref FixedList64Bytes<short> _refReturnTypeForGetTeamMappingRef; // Dummy field
		public ref ClothParameters GetParametersRef(int teamId) => ref _refReturnTypeForGetParametersRef; // 0x0000000187700994-0x0000000187700A64
		private ref ClothParameters _refReturnTypeForGetParametersRef; // Dummy field
		internal ref InertiaConstraint.CenterData GetCenterDataRef(int teamId) => ref _refReturnTypeForGetCenterDataRef; // 0x0000000184F20D40-0x0000000184F20D80
		private ref InertiaConstraint.CenterData _refReturnTypeForGetCenterDataRef; // Dummy field
		public ClothProcess GetClothProcess(int teamId) => default; // 0x00000001876F572C-0x00000001876F57A4
		internal void CameraCullingPreProcess() {} // 0x00000001876F3178-0x00000001876F572C
		internal void CameraCullingPostProcess() {} // 0x00000001876F5950-0x00000001876F60A8
		internal void AlwaysTeamUpdate() {} // 0x00000001876F57A4-0x00000001876F5950
		private void RemoveSyncParent(ref TeamData tdata, int parentTeamId) {} // 0x0000000184DBEDE0-0x0000000184DBEE70
		internal JobHandle CalcCenterAndInertiaAndWind(JobHandle jobHandle) => default; // 0x00000001876FE0E8-0x00000001876FE15C
		internal JobHandle SimulationStepTeamUpdate(int updateIndex, JobHandle jobHandle) => default; // 0x00000001876FD52C-0x00000001876FE0E8
		internal JobHandle PostTeamUpdate(JobHandle jobHandle) => default; // 0x00000001876FE2EC-0x00000001876FE664
		internal void AddMonitoringProcess(ClothProcess cprocess) {} // 0x00000001876FE21C-0x00000001876FE2EC
		internal void RemoveMonitoringProcess(ClothProcess cprocess) {} // 0x00000001876FE15C-0x00000001876FE21C
		private void MonitoringProcess(bool force) {} // 0x0000000184FE7000-0x0000000184FE7040
		private void MonitoringProcessUpdate() {} // 0x00000001876FCC2C-0x00000001876FCCA0
		public void InformationLog(StringBuilder allsb) {} // 0x00000001876FCCA0-0x00000001876FD4A8
		public static void Initialize_PostTeamUpdateJobKernels_PostTeamUpdateKernel_00000298_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
		public static void Initialize_PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_00000299_BurstDirectCall() {} // 0x00000001876FE664-0x00000001876FE684
	}

	public class VirtualMeshManager : IManager, IValid // TypeDefIndex: 45954
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
		public int ProxyVertexCount { get => default; } // 0x00000001877091B0-0x0000000187709248 
		public int ProxyTriangleCount { get => default; } // 0x0000000184F1D6B0-0x0000000184F1D6F0 
		public int ProxyEdgeCount { get => default; } // 0x0000000187704B08-0x0000000187704BA0 
		public int ProxyBaseLineCount { get => default; } // 0x0000000187704428-0x0000000187704B08 
		public int ProxyLocalPositionCount { get => default; } // 0x0000000187704BA0-0x0000000187704D6C 
		public int MappingVertexCount { get => default; } // 0x0000000184F6FC00-0x0000000184F6FC40 
	
		// Nested types
		public static class CalcProxyMeshSkinningKernels // TypeDefIndex: 45899
		{
			// Nested types
			public unsafe delegate void CalcProxyMeshSkinningKernel_000002E4_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index); // TypeDefIndex: 45895; 0x00000001876FE80C-0x00000001876FE870
	
			internal static class CalcProxyMeshSkinningKernel_000002E4_BurstDirectCall // TypeDefIndex: 45896
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxyMeshSkinningKernel_000002E4_BurstDirectCall() {} // 0x000000018551B790-0x000000018551BE50
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061881) {} // 0x00000001877007C4-0x0000000187700800
				private static IntPtr GetFunctionPointer() => default; // 0x0000000184703550-0x0000000184703590
				public static void Constructor() {} // 0x0000000187700800-0x000000018770083C
				public static void Initialize() {} // 0x0000000187700788-0x00000001877007C4
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index) {} // 0x00000001876FE870-0x00000001876FE8C0
			}
	
			public unsafe delegate void CalcProxyMeshSkinningRangeKernel_000002E5_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr); // TypeDefIndex: 45897; 0x00000001876FFC80-0x00000001876FFCD0
	
			internal static class CalcProxyMeshSkinningRangeKernel_000002E5_BurstDirectCall // TypeDefIndex: 45898
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxyMeshSkinningRangeKernel_000002E5_BurstDirectCall() {} // 0x0000000184707450-0x0000000184708100
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000618b1) {} // 0x000000018770019C-0x0000000187700638
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876FE8C0-0x00000001876FEC78
				public static void Constructor() {} // 0x0000000187700638-0x0000000187700788
				public static void Initialize() {} // 0x00000001847022E0-0x0000000184702A10
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr) {} // 0x00000001876FFCD0-0x000000018770019C
			}
	
			// Methods
			public static unsafe void CalcProxyMeshSkinningKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index) {} // 0x00000001876FEC78-0x00000001876FFC80
			public static unsafe void CalcProxyMeshSkinningRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
			public static unsafe void CalcProxyMeshSkinningKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int index) {} // 0x000000018568D050-0x000000018568D0B0
			public static unsafe void CalcProxyMeshSkinningRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, float3* localPositions, float3* localNormals, float3* localTangents, VirtualMeshBoneWeight* boneWeights, int* skinBoneTransformIndices, float4x4* skinBoneBindPoses, double3* positions, quaternion* rotations, float4x4* transformLocalToWorldMatrixArray, int* lengthPtr) {} // 0x000000018568D0B0-0x000000018568D110
		}
	
		private static class CreatePostProxyMeshUpdateListJobKernels // TypeDefIndex: 45904
		{
			// Nested types
			public unsafe delegate void CreatePostProxyMeshUpdateListKernel_000002E6_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId); // TypeDefIndex: 45900; 0x000000018568D170-0x000000018568D1D0
	
			internal static class CreatePostProxyMeshUpdateListKernel_000002E6_BurstDirectCall // TypeDefIndex: 45901
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreatePostProxyMeshUpdateListKernel_000002E6_BurstDirectCall() {} // 0x000000018568D410-0x000000018568D470
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061901) {} // 0x000000018568D290-0x000000018568D2F0
				private static IntPtr GetFunctionPointer() => default; // 0x000000018568D2F0-0x000000018568D350
				public static void Constructor() {} // 0x000000018568D350-0x000000018568D3B0
				public static void Initialize() {} // 0x000000018568D3B0-0x000000018568D410
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId) {} // 0x000000018568D470-0x000000018568D4D0
			}
	
			public unsafe delegate void CreatePostProxyMeshUpdateListRangeKernel_000002E7_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length); // TypeDefIndex: 45902; 0x000000018568D530-0x000000018568D590
	
			internal static class CreatePostProxyMeshUpdateListRangeKernel_000002E7_BurstDirectCall // TypeDefIndex: 45903
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreatePostProxyMeshUpdateListRangeKernel_000002E7_BurstDirectCall() {} // 0x00000001876F0568-0x00000001876F1510
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061925) {} // 0x000000018568D650-0x000000018568D6B0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876F8C00-0x00000001876F8CFC
				public static void Constructor() {} // 0x00000001876F8CFC-0x00000001876F8DFC
				public static void Initialize() {} // 0x00000001876EFEC8-0x00000001876F0568
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length) {} // 0x0000000187666908-0x00000001876669DC
			}
	
			// Methods
			private static unsafe void CreatePostProxyMeshUpdateListKernel(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId) {} // 0x0000000187666860-0x0000000187666908
			internal static unsafe void CreatePostProxyMeshUpdateListRangeKernel(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length) {} // 0x00000001876F8B08-0x00000001876F8C00
			public static unsafe void CreatePostProxyMeshUpdateListKernel_BurstManaged(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int teamId) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void CreatePostProxyMeshUpdateListRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, int* processingCounter0, int* processingList0, int* processingCounter1, int* processingList1, int* processingCounter2, int* processingList2, int* processingCounter3, int* processingList3, int length) {} // 0x00000001876F87F0-0x00000001876F88F4
		}
	
		private static class CalcLineNormalTangentJobKernels // TypeDefIndex: 45909
		{
			// Nested types
			public unsafe delegate void CalcLineNormalTangentKernel_000002E8_PostfixBurstDelegate(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index); // TypeDefIndex: 45905; 0x0000000185F48020-0x0000000185F480B0
	
			internal static class CalcLineNormalTangentKernel_000002E8_BurstDirectCall // TypeDefIndex: 45906
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcLineNormalTangentKernel_000002E8_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006199b) {} // 0x00000001876F8948-0x00000001876F8B08
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187666E44-0x0000000187666F18
				public static void Constructor() {} // 0x0000000187666D98-0x0000000187666E44
				public static void Initialize() {} // 0x0000000187666CFC-0x0000000187666D98
				public static unsafe void Invoke(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index) {} // 0x00000001876F8DFC-0x00000001876F8F00
			}
	
			public unsafe delegate void CalcLineNormalTangentRangeKernel_000002E9_PostfixBurstDelegate(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr); // TypeDefIndex: 45907; 0x0000000185F47F80-0x0000000185F48010
	
			internal static class CalcLineNormalTangentRangeKernel_000002E9_BurstDirectCall // TypeDefIndex: 45908
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcLineNormalTangentRangeKernel_000002E9_BurstDirectCall() {} // 0x00000001876FC2D4-0x00000001876FC38C
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000619d4) {} // 0x00000001876F8F54-0x00000001876F911C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876FC210-0x00000001876FC2D4
				public static void Constructor() {} // 0x00000001876FC38C-0x00000001876FC450
				public static void Initialize() {} // 0x00000001876F1A74-0x00000001876F1C7C
				public static unsafe void Invoke(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr) {} // 0x00000001876FC7C0-0x00000001876FC894
			}
	
			// Methods
			private static unsafe void CalcLineNormalTangentKernel(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index) {} // 0x00000001876684C8-0x000000018766853C
			internal static unsafe void CalcLineNormalTangentRangeKernel(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr) {} // 0x00000001876FC6F0-0x00000001876FC7C0
			public static unsafe void CalcLineNormalTangentKernel_BurstManaged(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void CalcLineNormalTangentRangeKernel_BurstManaged(int* jobBaseLineList, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, float3* vertexLocalPositions, quaternion* vertexLocalRotations, int* parentIndices, uint* childIndexArray, ushort* childDataArray, ExBitFlag8* baseLineFlags, short* baseLineTeamIds, ushort* baseLineStartIndices, ushort* baseLineDataCounts, ushort* baseLineData, int* lengthPtr) {} // 0x00000001876FC450-0x00000001876FC554
		}
	
		private static class WriteTransformDataJobKernels // TypeDefIndex: 45914
		{
			// Nested types
			public unsafe delegate void WriteTransformDataKernel_000002EA_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index); // TypeDefIndex: 45910; 0x0000000185F47940-0x0000000185F479D0
	
			internal static class WriteTransformDataKernel_000002EA_BurstDirectCall // TypeDefIndex: 45911
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformDataKernel_000002EA_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061a21) {} // 0x00000001876FC5A8-0x00000001876FC6F0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876FC7C0-0x00000001876FC894
				public static void Constructor() {} // 0x00000001876684C8-0x000000018766853C
				public static void Initialize() {} // 0x00000001876FCB5C-0x00000001876FCC2C
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index) {} // 0x00000001876FC894-0x00000001876FC998
			}
	
			public unsafe delegate void WriteTransformDataRangeKernel_000002EB_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr); // TypeDefIndex: 45912; 0x0000000185F478A0-0x0000000185F47930
	
			internal static class WriteTransformDataRangeKernel_000002EB_BurstDirectCall // TypeDefIndex: 45913
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformDataRangeKernel_000002EB_BurstDirectCall() {} // 0x00000001876EF970-0x00000001876EFA98
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061a42) {} // 0x00000001876FC9EC-0x00000001876FCB5C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876F720C-0x00000001876F7334
				public static void Constructor() {} // 0x00000001876F7334-0x00000001876F7460
				public static void Initialize() {} // 0x00000001876F6AD8-0x00000001876F720C
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr) {} // 0x00000001876F79C4-0x00000001876F7A98
			}
	
			// Methods
			private static unsafe void WriteTransformDataKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index) {} // 0x00000001876F78F4-0x00000001876F79C4
			internal static unsafe void WriteTransformDataRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr) {} // 0x00000001876F77D8-0x00000001876F78F4
			public static unsafe void WriteTransformDataKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void WriteTransformDataRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, short* teamIds, double3* positions, quaternion* rotations, quaternion* vertexToTransformRotations, int* lengthPtr) {} // 0x00000001876F7460-0x00000001876F7564
		}
	
		private static class WriteTransformLocalDataJobKernels // TypeDefIndex: 45919
		{
			// Nested types
			public unsafe delegate void WriteTransformLocalDataKernel_000002EC_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index); // TypeDefIndex: 45915; 0x0000000185F482A0-0x0000000185F48330
	
			internal static class WriteTransformLocalDataKernel_000002EC_BurstDirectCall // TypeDefIndex: 45916
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformLocalDataKernel_000002EC_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061a93) {} // 0x00000001876F75B8-0x00000001876F77D8
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876F7F9C-0x00000001876F8070
				public static void Constructor() {} // 0x00000001876F7ECC-0x00000001876F7F9C
				public static void Initialize() {} // 0x00000001876F7E0C-0x00000001876F7ECC
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index) {} // 0x00000001876F7A98-0x00000001876F7B9C
			}
	
			public unsafe delegate void WriteTransformLocalDataRangeKernel_000002ED_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr); // TypeDefIndex: 45917; 0x0000000185F48200-0x0000000185F48290
	
			internal static class WriteTransformLocalDataRangeKernel_000002ED_BurstDirectCall // TypeDefIndex: 45918
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WriteTransformLocalDataRangeKernel_000002ED_BurstDirectCall() {} // 0x0000000187700CA0-0x0000000187700D4C
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061aba) {} // 0x00000001876F7BF0-0x00000001876F7E0C
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187700BEC-0x0000000187700CA0
				public static void Constructor() {} // 0x0000000187700D4C-0x0000000187700E04
				public static void Initialize() {} // 0x00000001876F27B0-0x00000001876F2E90
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr) {} // 0x00000001876FB5F0-0x00000001876FB6C4
			}
	
			// Methods
			private static unsafe void WriteTransformLocalDataKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index) {} // 0x0000000187223B54-0x0000000187223BBC
			internal static unsafe void WriteTransformLocalDataRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr) {} // 0x0000000187701088-0x0000000187701148
			public static unsafe void WriteTransformLocalDataKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void WriteTransformLocalDataRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, VertexAttribute* attributes, int* vertexParentIndices, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, float3* transformLocalPositionArray, quaternion* transformLocalRotationArray, int* lengthPtr) {} // 0x0000000187700E04-0x0000000187700F08
		}
	
		private static class CalcProxySkinningJobKernels // TypeDefIndex: 45924
		{
			// Nested types
			public unsafe delegate void CalcProxySkinningKernel_000002EE_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex); // TypeDefIndex: 45920; 0x0000000185F447E0-0x0000000185F44870
	
			internal static class CalcProxySkinningKernel_000002EE_BurstDirectCall // TypeDefIndex: 45921
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxySkinningKernel_000002EE_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061b2b) {} // 0x0000000187700F5C-0x0000000187701088
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876FB9D4-0x00000001876FBAA8
				public static void Constructor() {} // 0x00000001872121B8-0x0000000187212220
				public static void Initialize() {} // 0x00000001876FB970-0x00000001876FB9D4
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex) {} // 0x0000000187701148-0x000000018770124C
			}
	
			public unsafe delegate void CalcProxySkinningRangeKernel_000002EF_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length); // TypeDefIndex: 45922; 0x0000000185F44740-0x0000000185F447D0
	
			internal static class CalcProxySkinningRangeKernel_000002EF_BurstDirectCall // TypeDefIndex: 45923
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcProxySkinningRangeKernel_000002EF_BurstDirectCall() {} // 0x0000000187701874-0x0000000187701940
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061b61) {} // 0x00000001877012A0-0x00000001877013F4
				private static IntPtr GetFunctionPointer() => default; // 0x00000001877017A4-0x0000000187701874
				public static void Constructor() {} // 0x0000000187701940-0x0000000187701A10
				public static void Initialize() {} // 0x00000001877013F4-0x00000001877017A4
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length) {} // 0x0000000187701DA8-0x0000000187701E7C
			}
	
			// Methods
			private static unsafe void CalcProxySkinningKernel(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex) {} // 0x000000018720FA28-0x000000018720FAA8
			internal static unsafe void CalcProxySkinningRangeKernel(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length) {} // 0x0000000187701CD0-0x0000000187701DA8
			public static unsafe void CalcProxySkinningKernel_BurstManaged(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int mvindex) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void CalcProxySkinningRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, TeamManager.MappingData* mappingDataArray, short* mappingIdArray, VertexAttribute* mappingAttributes, float3* mappingLocalPositions, float3* mappingLocalNormals, float3* mappingLocalTangents, VirtualMeshBoneWeight* mappingBoneWeights, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, double3* proxyPositions, quaternion* proxyRotations, float3* proxyVertexBindPosePositions, quaternion* proxyVertexBindPoseRotations, int length) {} // 0x0000000187701A10-0x0000000187701B14
		}
	
		private static class CalcMeshConvertMatrixJobKernels // TypeDefIndex: 45929
		{
			// Nested types
			public unsafe delegate void CalcMeshConvertMatrixKernel_000002F0_PostfixBurstDelegate(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index); // TypeDefIndex: 45925; 0x0000000185F446A0-0x0000000185F44730
	
			internal static class CalcMeshConvertMatrixKernel_000002F0_BurstDirectCall // TypeDefIndex: 45926
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcMeshConvertMatrixKernel_000002F0_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061b9b) {} // 0x0000000187701B68-0x0000000187701CD0
				private static IntPtr GetFunctionPointer() => default; // 0x000000018770225C-0x0000000187702880
				public static void Constructor() {} // 0x00000001877021DC-0x000000018770225C
				public static void Initialize() {} // 0x0000000187702164-0x00000001877021DC
				public static unsafe void Invoke(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index) {} // 0x0000000187701E7C-0x0000000187701F80
			}
	
			public unsafe delegate void CalcMeshConvertMatrixRangeKernel_000002F1_PostfixBurstDelegate(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length); // TypeDefIndex: 45927; 0x0000000185F44600-0x0000000185F44690
	
			internal static class CalcMeshConvertMatrixRangeKernel_000002F1_BurstDirectCall // TypeDefIndex: 45928
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcMeshConvertMatrixRangeKernel_000002F1_BurstDirectCall() {} // 0x00000001876F1510-0x00000001876F1A74
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061bb3) {} // 0x0000000187701FD4-0x0000000187702164
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876F9FC8-0x00000001876FA0E0
				public static void Constructor() {} // 0x00000001876FA0E0-0x00000001876FA1F8
				public static void Initialize() {} // 0x00000001876F911C-0x00000001876F9FC8
				public static unsafe void Invoke(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length) {} // 0x00000001876FA720-0x00000001876FA7F4
			}
	
			// Methods
			private static unsafe void CalcMeshConvertMatrixKernel(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index) {} // 0x00000001876FA660-0x00000001876FA720
			internal static unsafe void CalcMeshConvertMatrixRangeKernel(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length) {} // 0x00000001876FA550-0x00000001876FA660
			public static unsafe void CalcMeshConvertMatrixKernel_BurstManaged(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void CalcMeshConvertMatrixRangeKernel_BurstManaged(TeamManager.MappingData* mappingDataArray, TeamManager.TeamData* teamDataArray, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, int length) {} // 0x00000001876FA1F8-0x00000001876FA2FC
		}
	
		private static class CalcTriangleNormalTangentJobKernels // TypeDefIndex: 45934
		{
			// Nested types
			public unsafe delegate void CalcTriangleNormalTangentKernel_000002F2_PostfixBurstDelegate(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index); // TypeDefIndex: 45930; 0x0000000185F47EE0-0x0000000185F47F70
	
			internal static class CalcTriangleNormalTangentKernel_000002F2_BurstDirectCall // TypeDefIndex: 45931
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcTriangleNormalTangentKernel_000002F2_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061bf5) {} // 0x00000001876FA350-0x00000001876FA550
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876FA720-0x00000001876FA7F4
				public static void Constructor() {} // 0x00000001876FA660-0x00000001876FA720
				public static void Initialize() {} // 0x00000001876FAB44-0x00000001876FAC54
				public static unsafe void Invoke(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index) {} // 0x00000001876FA7F4-0x00000001876FA8F8
			}
	
			public unsafe delegate void CalcTriangleNormalTangentRangeKernel_000002F3_PostfixBurstDelegate(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr); // TypeDefIndex: 45932; 0x0000000185F47E40-0x0000000185F47ED0
	
			internal static class CalcTriangleNormalTangentRangeKernel_000002F3_BurstDirectCall // TypeDefIndex: 45933
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcTriangleNormalTangentRangeKernel_000002F3_BurstDirectCall() {} // 0x00000001876F80F8-0x00000001876F8178
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061c16) {} // 0x00000001876FA94C-0x00000001876FAB44
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876F8070-0x00000001876F80F8
				public static void Constructor() {} // 0x00000001876F8178-0x00000001876F8200
				public static void Initialize() {} // 0x00000001876EFA98-0x00000001876EFEC8
				public static unsafe void Invoke(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr) {} // 0x00000001876E9CCC-0x00000001876E9DA0
			}
	
			// Methods
			private static unsafe void CalcTriangleNormalTangentKernel(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index) {} // 0x00000001876BEB84-0x00000001876BEB98
			internal static unsafe void CalcTriangleNormalTangentRangeKernel(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr) {} // 0x00000001876F842C-0x00000001876F84E4
			public static unsafe void CalcTriangleNormalTangentKernel_BurstManaged(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void CalcTriangleNormalTangentRangeKernel_BurstManaged(int* jobTriangleList, TeamManager.TeamData* teamDataArray, short* triangleTeamIdArray, int3* triangles, float3* outTriangleNormals, float3* outTriangleTangents, double3* positions, float2* uv, int* lengthPtr) {} // 0x00000001876F8200-0x00000001876F8304
		}
	
		private static class CalcVertexNormalTangentFromTriangleJobKernels // TypeDefIndex: 45939
		{
			// Nested types
			public unsafe delegate void CalcVertexNormalTangentFromTriangleKernel_000002F4_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index); // TypeDefIndex: 45935; 0x0000000185F48160-0x0000000185F481F0
	
			internal static class CalcVertexNormalTangentFromTriangleKernel_000002F4_BurstDirectCall // TypeDefIndex: 45936
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcVertexNormalTangentFromTriangleKernel_000002F4_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061c5b) {} // 0x00000001876F8358-0x00000001876F842C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876E9CCC-0x00000001876E9DA0
				public static void Constructor() {} // 0x00000001876BEB84-0x00000001876BEB98
				public static void Initialize() {} // 0x00000001876F8738-0x00000001876F87F0
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index) {} // 0x00000001876F84E4-0x00000001876F85E8
			}
	
			public unsafe delegate void CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_PostfixBurstDelegate(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr); // TypeDefIndex: 45937; 0x0000000185F480C0-0x0000000185F48150
	
			internal static class CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_BurstDirectCall // TypeDefIndex: 45938
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_BurstDirectCall() {} // 0x00000001876FB148-0x00000001876FB1F4
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061c7c) {} // 0x00000001876F863C-0x00000001876F8738
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876FB094-0x00000001876FB148
				public static void Constructor() {} // 0x00000001876FB1F4-0x00000001876FB2AC
				public static void Initialize() {} // 0x00000001876FAC54-0x00000001876FB094
				public static unsafe void Invoke(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr) {} // 0x00000001876FB5F0-0x00000001876FB6C4
			}
	
			// Methods
			private static unsafe void CalcVertexNormalTangentFromTriangleKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index) {} // 0x0000000187223B54-0x0000000187223BBC
			internal static unsafe void CalcVertexNormalTangentFromTriangleRangeKernel(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr) {} // 0x00000001876FB530-0x00000001876FB5F0
			public static unsafe void CalcVertexNormalTangentFromTriangleKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void CalcVertexNormalTangentFromTriangleRangeKernel_BurstManaged(int* jobVertexIndexList, TeamManager.TeamData* teamDataArray, short* teamIds, float3* triangleNormals, float3* triangleTangents, FixedList32Bytes<uint>* vertexToTriangles, quaternion* normalAdjustmentRotations, quaternion* outRotations, int* lengthPtr) {} // 0x00000001876FB2AC-0x00000001876FB3B0
		}
	
		private static class ClearProxyMeshUpdateBufferJobKernels // TypeDefIndex: 45942
		{
			// Nested types
			public unsafe delegate void ClearProxyMeshUpdateBufferKernel_000002F6_PostfixBurstDelegate(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3); // TypeDefIndex: 45940; 0x0000000185F47DA0-0x0000000185F47E30
	
			internal static class ClearProxyMeshUpdateBufferKernel_000002F6_BurstDirectCall // TypeDefIndex: 45941
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearProxyMeshUpdateBufferKernel_000002F6_BurstDirectCall() {} // 0x00000001864BB614-0x00000001864BB734
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061c9b) {} // 0x00000001876FB404-0x00000001876FB530
				private static IntPtr GetFunctionPointer() => default; // 0x00000001876FB9D4-0x00000001876FBAA8
				public static void Constructor() {} // 0x00000001872121B8-0x0000000187212220
				public static void Initialize() {} // 0x00000001876FB970-0x00000001876FB9D4
				public static unsafe void Invoke(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3) {} // 0x00000001876FB6C4-0x00000001876FB7C8
			}
	
			// Methods
			internal static unsafe void ClearProxyMeshUpdateBufferKernel(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3) {} // 0x00000001876FB7C8-0x00000001876FB81C
			public static unsafe void ClearProxyMeshUpdateBufferKernel_BurstManaged(int* processingCounter0, int* processingCounter1, int* processingCounter2, int* processingCounter3) {} // 0x0000000185F47D00-0x0000000185F47D90
		}
	
		private struct ClearProxyMeshUpdateBufferJob : IJob, IUnsafeJob // TypeDefIndex: 45943
		{
			// Fields
			public NativeReference<int> processingCounter0; // 0x00
			public NativeReference<int> processingCounter1; // 0x10
			public NativeReference<int> processingCounter2; // 0x20
			public NativeReference<int> processingCounter3; // 0x30
	
			// Methods
			public void Execute() {} // 0x0000000185492010-0x0000000185492020
			public void UnsafeDo() {} // 0x0000000185F47CF0-0x0000000185F47D00
		}
	
		private struct CreateProxyMeshUpdateVertexList : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45944
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeReference<int> processingCounter1; // 0x10
			public NativeArray<int> processingList1; // 0x20
			public int _indexCount; // 0x30
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001876FB81C-0x00000001876FB970
			public void Execute() {} // 0x00000001876FBFF8-0x00000001876FC0AC
			public void Execute(int teamId) {} // 0x00000001876FC158-0x00000001876FC210
			public void UnsafeDo() {} // 0x00000001876FBAA8-0x00000001876FBFF8
		}
	
		private struct CalcProxyMeshSkinningJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45945
		{
			// Fields
			public NativeArray<int> jobVertexIndexList; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<short> teamIds; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
			public NativeArray<float3> localPositions; // 0x40
			public NativeArray<float3> localNormals; // 0x50
			public NativeArray<float3> localTangents; // 0x60
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x70
			public NativeArray<int> skinBoneTransformIndices; // 0x80
			public NativeArray<float4x4> skinBoneBindPoses; // 0x90
			public NativeArray<double3> positions; // 0xA0
			public NativeArray<quaternion> rotations; // 0xB0
			public NativeArray<float4x4> transformLocalToWorldMatrixArray; // 0xC0
			public NativeReference<int> _indexCount; // 0xD0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001876FC0AC-0x00000001876FC158
			public void Execute() {} // 0x00000001876FB5F0-0x00000001876FB6C4
			public void Execute(int index) {} // 0x0000000187223B54-0x0000000187223BBC
			public void UnsafeDo() {} // 0x0000000187706EE4-0x0000000187706FA4
		}
	
		private struct CreatePostProxyMeshUpdateListJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45946
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeReference<int> processingCounter0; // 0x10
			public NativeArray<int> processingList0; // 0x20
			public NativeReference<int> processingCounter1; // 0x30
			public NativeArray<int> processingList1; // 0x40
			public NativeReference<int> processingCounter2; // 0x50
			public NativeArray<int> processingList2; // 0x60
			public NativeReference<int> processingCounter3; // 0x70
			public NativeArray<int> processingList3; // 0x80
			public int _indexCount; // 0x90
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001864BB614-0x00000001864BB734
			public void Execute() {} // 0x0000000187706C60-0x0000000187706D64
			public void Execute(int teamId) {} // 0x0000000187706D64-0x0000000187706DB8
			public void UnsafeDo() {} // 0x0000000185F47C60-0x0000000185F47CF0
		}
	
		private struct CalcLineNormalTangentJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45947
		{
			// Fields
			public NativeArray<int> jobBaseLineList; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<ClothParameters> parameterArray; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
			public NativeArray<double3> positions; // 0x40
			public NativeArray<quaternion> rotations; // 0x50
			public NativeArray<float3> vertexLocalPositions; // 0x60
			public NativeArray<quaternion> vertexLocalRotations; // 0x70
			public NativeArray<int> parentIndices; // 0x80
			public NativeArray<uint> childIndexArray; // 0x90
			public NativeArray<ushort> childDataArray; // 0xA0
			public NativeArray<ExBitFlag8> baseLineFlags; // 0xB0
			public NativeArray<short> baseLineTeamIds; // 0xC0
			public NativeArray<ushort> baseLineStartIndices; // 0xD0
			public NativeArray<ushort> baseLineDataCounts; // 0xE0
			public NativeArray<ushort> baseLineData; // 0xF0
			public NativeReference<int> _indexCount; // 0x100
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185492010-0x0000000185492020
			public void Execute() {} // 0x0000000185F47C50-0x0000000185F47C60
			public void Execute(int index) {} // 0x0000000187706DB8-0x0000000187706EE4
			public void UnsafeDo() {} // 0x00000001876FB9D4-0x00000001876FBAA8
		}
	
		private struct CalcTriangleNormalTangentJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45948
		{
			// Fields
			public NativeArray<int> jobTriangleList; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<short> triangleTeamIdArray; // 0x20
			public NativeArray<int3> triangles; // 0x30
			public NativeArray<float3> outTriangleNormals; // 0x40
			public NativeArray<float3> outTriangleTangents; // 0x50
			public NativeArray<double3> positions; // 0x60
			public NativeArray<float2> uv; // 0x70
			public NativeReference<int> _indexCount; // 0x80
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001872121B8-0x0000000187212220
			public void Execute() {} // 0x00000001876FB970-0x00000001876FB9D4
			public void Execute(int index) {} // 0x00000001864BB614-0x00000001864BB734
			public void UnsafeDo() {} // 0x0000000187706FA4-0x00000001877070A8
		}
	
		private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45949
		{
			// Fields
			public NativeArray<int> jobVertexIndexList; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<short> teamIds; // 0x20
			public NativeArray<float3> triangleNormals; // 0x30
			public NativeArray<float3> triangleTangents; // 0x40
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x50
			public NativeArray<quaternion> normalAdjustmentRotations; // 0x60
			public NativeArray<quaternion> outRotations; // 0x70
			public NativeReference<int> _indexCount; // 0x80
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001877070A8-0x00000001877070FC
			public void Execute() {} // 0x0000000185F47BC0-0x0000000185F47C50
			public void Execute(int index) {} // 0x0000000185492010-0x0000000185492020
			public void UnsafeDo() {} // 0x0000000185F47BB0-0x0000000185F47BC0
		}
	
		private struct WriteTransformDataJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45950
		{
			// Fields
			public NativeArray<int> jobVertexIndexList; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<double3> transformPositionArray; // 0x20
			public NativeArray<quaternion> transformRotationArray; // 0x30
			public NativeArray<short> teamIds; // 0x40
			public NativeArray<double3> positions; // 0x50
			public NativeArray<quaternion> rotations; // 0x60
			public NativeArray<quaternion> vertexToTransformRotations; // 0x70
			public NativeReference<int> _indexCount; // 0x80
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001877070FC-0x0000000187707250
			public void Execute() {} // 0x0000000187707250-0x00000001877072C4
			public void Execute(int index) {} // 0x0000000185FB11B0-0x0000000185FB11C0
			public void UnsafeDo() {} // 0x0000000187707610-0x00000001877076E4
		}
	
		private struct WriteTransformLocalDataJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 45951
		{
			// Fields
			public NativeArray<int> jobVertexIndexList; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<short> teamIds; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
			public NativeArray<int> vertexParentIndices; // 0x40
			public NativeArray<double3> transformPositionArray; // 0x50
			public NativeArray<quaternion> transformRotationArray; // 0x60
			public NativeArray<float3> transformScaleArray; // 0x70
			public NativeArray<float3> transformLocalPositionArray; // 0x80
			public NativeArray<quaternion> transformLocalRotationArray; // 0x90
			public NativeReference<int> _indexCount; // 0xA0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001832D8120-0x00000001832D8140
			public void Execute() {} // 0x00000001877075C8-0x0000000187707610
			public void Execute(int index) {} // 0x00000001864BB614-0x00000001864BB734
			public void UnsafeDo() {} // 0x00000001877073C4-0x00000001877074C8
		}
	
		private struct CalcMeshConvertMatrixJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45952
		{
			// Fields
			public NativeArray<TeamManager.MappingData> mappingDataArray; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<double3> transformPositionArray; // 0x20
			public NativeArray<quaternion> transformRotationArray; // 0x30
			public NativeArray<float3> transformScaleArray; // 0x40
			public int _indexCount; // 0x50
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001877074C8-0x000000018770751C
			public void Execute() {} // 0x0000000185F47A80-0x0000000185F47B10
			public void Execute(int index) {} // 0x0000000185492010-0x0000000185492020
			public void UnsafeDo() {} // 0x0000000185F47A70-0x0000000185F47A80
		}
	
		private struct CalcProxySkinningJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45953
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeArray<TeamManager.MappingData> mappingDataArray; // 0x10
			public NativeArray<short> mappingIdArray; // 0x20
			public NativeArray<VertexAttribute> mappingAttributes; // 0x30
			public NativeArray<float3> mappingLocalPositions; // 0x40
			public NativeArray<float3> mappingLocalNormals; // 0x50
			public NativeArray<float3> mappingLocalTangents; // 0x60
			public NativeArray<VirtualMeshBoneWeight> mappingBoneWeights; // 0x70
			public NativeArray<float3> mappingPositions; // 0x80
			public NativeArray<float3> mappingNormals; // 0x90
			public NativeArray<float3> mappingTangents; // 0xA0
			public NativeArray<double3> proxyPositions; // 0xB0
			public NativeArray<quaternion> proxyRotations; // 0xC0
			public NativeArray<float3> proxyVertexBindPosePositions; // 0xD0
			public NativeArray<quaternion> proxyVertexBindPoseRotations; // 0xE0
			public int _indexCount; // 0xF0
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x000000018770751C-0x00000001877075C8
			public void Execute() {} // 0x00000001877072C4-0x0000000187707344
			public void Execute(int mvindex) {} // 0x0000000187707344-0x00000001877073C4
			public void UnsafeDo() {} // 0x0000000184FD5DB0-0x0000000184FD5DF0
		}
	
		// Constructors
		public VirtualMeshManager() {} // 0x00000001877064D0-0x0000000187706A38
	
		// Methods
		public static unsafe void CreateProxyMeshUpdateVertexListKernel(TeamManager.TeamData* teamDataArray, int* processingCounter1, int* processingList1, int teamId) {} // 0x000000018770913C-0x00000001877091B0
		public static unsafe void CreateProxyMeshUpdateVertexListRangeKernel(TeamManager.TeamData* teamDataArray, int* processingCounter1, int* processingList1, int length) {} // 0x0000000187708FD0-0x000000018770913C
		public void Dispose() {} // 0x0000000187708C20-0x0000000187708C98
		public void EnterdEditMode() {} // 0x0000000187708C98-0x0000000187708ED0
		public void Initialize() {} // 0x0000000187708ED0-0x0000000187708FD0
		public bool IsValid() => default; // 0x0000000184F3BBC0-0x0000000184F3BC00
		public void RegisterProxyMesh(int teamId, VirtualMeshContainer proxyMeshContainer) {} // 0x0000000187703B68-0x0000000187703C00
		public void ExitProxyMesh(int teamId) {} // 0x0000000187703404-0x0000000187703B68
		public DataChunk RegisterMappingMesh(int teamId, VirtualMeshContainer mappingMeshContainer) => default; // 0x0000000187703C00-0x0000000187703E44
		public void ExitMappingMesh(int teamId, int mappingIndex) {} // 0x0000000187706334-0x00000001877063A0
		internal void UpdateBuffer() {} // 0x000000018770629C-0x0000000187706334
		internal JobHandle PreProxyMeshUpdate(JobHandle jobHandle) => default; // 0x0000000187705E10-0x000000018770629C
		internal JobHandle PostProxyMeshUpdate(JobHandle jobHandle) => default; // 0x00000001877063A0-0x00000001877064D0
		internal JobHandle PostMappingMeshUpdate(JobHandle jobHandle) => default; // 0x0000000187706AD0-0x0000000187706B3C
		public void InformationLog(StringBuilder allsb) {} // 0x0000000187706A38-0x0000000187706AD0
		public static void Initialize_CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E6_BurstDirectCall() {} // 0x0000000187706B3C-0x0000000187706C60
		public static void Initialize_CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E7_BurstDirectCall() {} // 0x0000000184F6DF90-0x0000000184F6DFD0
		public static void Initialize_CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002E8_BurstDirectCall() {} // 0x0000000187712050-0x00000001877120E8
		public static void Initialize_CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002E9_BurstDirectCall() {} // 0x00000001877120E8-0x0000000187712448
		public static void Initialize_WriteTransformDataJobKernels_WriteTransformDataKernel_000002EA_BurstDirectCall() {} // 0x0000000187712448-0x0000000187712560
		public static void Initialize_WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002EB_BurstDirectCall() {} // 0x0000000184F3FD70-0x0000000184F3FFC0
		public static void Initialize_WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EC_BurstDirectCall() {} // 0x0000000187712560-0x00000001877125F8
		public static void Initialize_WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002ED_BurstDirectCall() {} // 0x00000001877125F8-0x00000001877129B4
		public static void Initialize_CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002EE_BurstDirectCall() {} // 0x00000001877129B4-0x0000000187712B18
		public static void Initialize_CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002EF_BurstDirectCall() {} // 0x000000018770430C-0x0000000187704364
		public static void Initialize_CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F0_BurstDirectCall() {} // 0x0000000187703E44-0x0000000187703EB8
		public static void Initialize_CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F1_BurstDirectCall() {} // 0x0000000187703EB8-0x000000018770430C
		public static void Initialize_CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F2_BurstDirectCall() {} // 0x0000000187704364-0x0000000187704428
		public static void Initialize_CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F3_BurstDirectCall() {} // 0x0000000187705BD4-0x0000000187705C30
		public static void Initialize_CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F4_BurstDirectCall() {} // 0x0000000187704D6C-0x0000000187704DE4
		public static void Initialize_CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F5_BurstDirectCall() {} // 0x0000000187704DE4-0x0000000187705BD4
		public static void Initialize_ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F6_BurstDirectCall() {} // 0x0000000187705C30-0x0000000187705E10
	}

	public interface IManager : IDisposable // TypeDefIndex: 45955
	{
		// Methods
		void Initialize();
		void EnterdEditMode();
		void InformationLog(StringBuilder allsb);
	}

	public static class MagicaManager // TypeDefIndex: 45960
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
		public static TimeManager Time { get; } // 0x0000000184B27550-0x0000000184B276F0 
		public static TeamManager Team { get; } // 0x000000018770A24C-0x000000018770A2FC 
		public static ClothManager Cloth { get; } // 0x0000000187709EB0-0x0000000187709F70 
		public static RenderManager Render { get; } // 0x000000018770A428-0x000000018770A4D8 
		public static DynamicBoneTransformManager Bone { get; } // 0x000000018770A198-0x000000018770A24C 
		public static VirtualMeshManager VMesh { get; } // 0x0000000187709D90-0x0000000187709EB0 
		public static SimulationManager Simulation { get; } // 0x0000000187709C70-0x0000000187709D90 
		public static ColliderManager Collider { get; } // 0x000000018770A028-0x000000018770A0E0 
		public static WindManager Wind { get; } // 0x000000018770A37C-0x000000018770A428 
		public static PreBuildManager PreBuild { get; } // 0x0000000187709F70-0x000000018770A028 
	
		// Nested types
		public delegate void UpdateMethod(); // TypeDefIndex: 45956; 0x0000000184487AC0-0x0000000184487B90
	
		public enum InitializationLocation // TypeDefIndex: 45957
		{
			Start = 0,
			Awake = 1
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45958
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
			static __c() {} // 0x0000000184299C20-0x0000000184299CF0
			public __c() {} // 0x00000001844879F0-0x0000000184487AC0
	
			// Methods
			internal void _InitCustomGameLoop_b__39_0() {} // 0x0000000184487850-0x0000000184487920
			internal void _SetCustomGameLoop_b__40_0() {} // 0x00000001847069F0-0x0000000184706AC0
			internal void _SetCustomGameLoop_b__40_1() {} // 0x0000000184299B50-0x0000000184299C20
			internal void _SetCustomGameLoop_b__40_2() {} // 0x000000018486FD20-0x000000018486FDC0
			internal void _SetCustomGameLoop_b__40_3() {} // 0x0000000184CCA5B0-0x0000000184CCAFA0
			internal void _SetCustomGameLoop_b__40_4() {} // 0x0000000184CC9EF0-0x0000000184CCA1C0
			internal void _SetCustomGameLoop_b__40_5() {} // 0x0000000184299D30-0x0000000184299E10
			internal void _SetCustomGameLoop_b__40_6() {} // 0x000000018770A570-0x000000018770A608
		}
	
		private sealed class __c__DisplayClass41_0 // TypeDefIndex: 45959
		{
			// Fields
			public System.Type t; // 0x10
			public Func<PlayerLoopSystem, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass41_0() {} // 0x0000000184B2C130-0x0000000184B2C320
	
			// Methods
			internal bool _CheckRegist_b__0(PlayerLoopSystem x) => default; // 0x0000000184B260B0-0x0000000184B26AE0
		}
	
		// Constructors
		static MagicaManager() {} // 0x0000000185673960-0x0000000185673A20
	
		// Methods
		private static void Initialize() {} // 0x000000018770A4D8-0x000000018770A570
		private static void Dispose() {} // 0x000000018770A0E0-0x000000018770A198
		public static bool IsPlaying() => default; // 0x000000018486E080-0x000000018486E110
		public static void SetUseCrossFrameJob(bool value) {} // 0x000000018770A2FC-0x000000018770A37C
		public static void InitCustomGameLoop() {} // 0x0000000185F1EA60-0x0000000185F1EB10
		private static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop) {} // 0x0000000184CCD100-0x0000000184CCD200
		private static bool CheckRegist(ref PlayerLoopSystem playerLoop) => default; // 0x00000001864BC320-0x00000001864BC330
		public static void SetGlobalTimeScale(float timeScale) {} // 0x00000001864BC2FC-0x00000001864BC320
		public static float GetGlobalTimeScale() => default; // 0x00000001864BB614-0x00000001864BB734
		public static void SetSimulationFrequency(int freq) {} // 0x0000000185F72CD0-0x0000000185F72D30
		public static void SetAOVMode(bool enable, float deltaTime) {} // 0x0000000185492010-0x0000000185492020
		public static void DoAOVUpdate() {} // 0x000000018770F4A0-0x000000018770F4F0
		public static void DoAOVAfterAnimatorUpdate() {} // 0x0000000184408790-0x0000000184408820
		public static int GetSimulationFrequency() => default; // 0x0000000184408820-0x0000000184408D70
		public static void SetMaxSimulationCountPerFrame(int count) {} // 0x0000000184408120-0x00000001844081F0
		public static int GetMaxSimulationCountPerFrame() => default; // 0x0000000184408280-0x0000000184408310
		public static void SetUpdateLocation(TimeManager.UpdateLocation updateLocation) {} // 0x0000000184408310-0x00000001844083A0
		public static TimeManager.UpdateLocation GetUpdateLocation() => default; // 0x00000001844083A0-0x0000000184408430
		public static void UnloadUnusedData() {} // 0x0000000184408430-0x00000001844084C0
		public static void SetInitializationLocation(InitializationLocation initLocation) {} // 0x0000000185492010-0x0000000185492020
	}

	public class MagicaSettings : ClothBehaviour // TypeDefIndex: 45962
	{
		// Fields
		public RefreshMode refreshMode; // 0x20
		public int simulationFrequency; // 0x24
		public int maxSimulationCountPerFrame; // 0x28
		public MagicaManager.InitializationLocation initializationLocation; // 0x2C
		public TimeManager.UpdateLocation updateLocation; // 0x30
		public bool monitorPlayerLoop; // 0x34
	
		// Nested types
		public enum RefreshMode // TypeDefIndex: 45961
		{
			OnAwake = 0,
			EveryFrame = 1,
			OnStart = 2,
			Manual = 3
		}
	
		// Constructors
		public MagicaSettings() {} // 0x000000018770A8B0-0x000000018770A8C8
	
		// Methods
		public void Awake() {} // 0x000000018770A608-0x000000018770A664
		public void Start() {} // 0x000000018770A7F8-0x000000018770A854
		public void Update() {} // 0x000000018770A854-0x000000018770A8B0
		private void OnValidate() {} // 0x000000018770A664-0x000000018770A6C4
		public void Refresh() {} // 0x000000018770A6C4-0x000000018770A7F8
	}

	internal static class UpdatePositionNormalJobKernels // TypeDefIndex: 45967
	{
		// Nested types
		public unsafe delegate void UpdatePositionNormalKernel_00000359_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index); // TypeDefIndex: 45963; 0x0000000187710654-0x00000001877106F8
	
		internal static class UpdatePositionNormalKernel_00000359_BurstDirectCall // TypeDefIndex: 45964
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalKernel_00000359_BurstDirectCall() {} // 0x00000001877109A0-0x0000000187710AA4
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061cfa) {} // 0x0000000187710CC8-0x0000000187710D90
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876D37B8-0x00000001876D3814
			public static void Constructor() {} // 0x0000000187710C08-0x0000000187710CC8
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index) {} // 0x0000000187710AA4-0x0000000187710AF8
		}
	
		public unsafe delegate void UpdatePositionNormalRangeKernel_0000035A_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length); // TypeDefIndex: 45965; 0x0000000185492010-0x0000000185492020
	
		internal static class UpdatePositionNormalRangeKernel_0000035A_BurstDirectCall // TypeDefIndex: 45966
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalRangeKernel_0000035A_BurstDirectCall() {} // 0x0000000187710D90-0x0000000187710E94
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061d18) {} // 0x0000000187710CC8-0x0000000187710D90
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876D37B8-0x00000001876D3814
			public static void Constructor() {} // 0x0000000187711024-0x00000001877110E4
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length) {} // 0x0000000187710E94-0x0000000187710EE8
		}
	
		// Methods
		private static unsafe void UpdatePositionNormalKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index) {} // 0x0000000185F45280-0x0000000185F45310
		internal static unsafe void UpdatePositionNormalRangeKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void UpdatePositionNormalKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int index) {} // 0x0000000185F45270-0x0000000185F45280
		public static unsafe void UpdatePositionNormalRangeKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, int length) {} // 0x0000000187710EE8-0x0000000187711024
	}

	internal static class UpdatePositionNormalTangentJobKernels // TypeDefIndex: 45972
	{
		// Nested types
		public unsafe delegate void UpdatePositionNormalTangentKernel_0000035B_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index); // TypeDefIndex: 45968; 0x00000001877113C8-0x0000000187711488
	
		internal static class UpdatePositionNormalTangentKernel_0000035B_BurstDirectCall // TypeDefIndex: 45969
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalTangentKernel_0000035B_BurstDirectCall() {} // 0x00000001877117DC-0x00000001877118E0
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061d62) {} // 0x0000000187711B50-0x0000000187711C18
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876684C8-0x000000018766853C
			public static void Constructor() {} // 0x0000000187711A78-0x0000000187711B50
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index) {} // 0x00000001877118E0-0x0000000187711934
		}
	
		public unsafe delegate void UpdatePositionNormalTangentRangeKernel_0000035C_PostfixBurstDelegate(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length); // TypeDefIndex: 45970; 0x0000000185492010-0x0000000185492020
	
		internal static class UpdatePositionNormalTangentRangeKernel_0000035C_BurstDirectCall // TypeDefIndex: 45971
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdatePositionNormalTangentRangeKernel_0000035C_BurstDirectCall() {} // 0x0000000187711C18-0x0000000187711D1C
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061d86) {} // 0x0000000187711B50-0x0000000187711C18
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876684C8-0x000000018766853C
			public static void Constructor() {} // 0x0000000187711EE0-0x0000000187711FB8
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length) {} // 0x0000000187711D1C-0x0000000187711D70
		}
	
		// Methods
		private static unsafe void UpdatePositionNormalTangentKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index) {} // 0x0000000185F45140-0x0000000185F451D0
		internal static unsafe void UpdatePositionNormalTangentRangeKernel(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void UpdatePositionNormalTangentKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int index) {} // 0x0000000185F45130-0x0000000185F45140
		public static unsafe void UpdatePositionNormalTangentRangeKernel_BurstManaged(int startIndex, float3* meshLocalPositions, float3* meshLocalNormals, float4* meshLocalTangents, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, float3* mappingPositions, float3* mappingNormals, float3* mappingTangents, int length) {} // 0x0000000187711D70-0x0000000187711EE0
	}

	internal static class UpdateBoneWeightJob2Kernels // TypeDefIndex: 45977
	{
		// Nested types
		public unsafe delegate void UpdateBoneWeight2Kernel_0000035D_PostfixBurstDelegate(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index); // TypeDefIndex: 45973; 0x0000000187710134-0x00000001877101B8
	
		internal static class UpdateBoneWeight2Kernel_0000035D_BurstDirectCall // TypeDefIndex: 45974
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdateBoneWeight2Kernel_0000035D_BurstDirectCall() {} // 0x000000018770F8A0-0x000000018770F9A4
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061dba) {} // 0x000000018770FB88-0x000000018770FC50
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876BEB84-0x00000001876BEB98
			public static void Constructor() {} // 0x000000018770FAC8-0x000000018770FB88
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index) {} // 0x000000018770F9A4-0x000000018770F9F8
		}
	
		public unsafe delegate void UpdateBoneWeight2RangeKernel_0000035E_PostfixBurstDelegate(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length); // TypeDefIndex: 45975; 0x0000000185492010-0x0000000185492020
	
		internal static class UpdateBoneWeight2RangeKernel_0000035E_BurstDirectCall // TypeDefIndex: 45976
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static UpdateBoneWeight2RangeKernel_0000035E_BurstDirectCall() {} // 0x000000018770FC50-0x000000018770FD54
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061dd2) {} // 0x000000018770FB88-0x000000018770FC50
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876BEB84-0x00000001876BEB98
			public static void Constructor() {} // 0x000000018770FEA4-0x000000018770FF64
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length) {} // 0x000000018770FD54-0x000000018770FDA8
		}
	
		// Methods
		private static unsafe void UpdateBoneWeight2Kernel(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index) {} // 0x0000000185F453C0-0x0000000185F45450
		internal static unsafe void UpdateBoneWeight2RangeKernel(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void UpdateBoneWeight2Kernel_BurstManaged(int startIndex, BoneWeight* centerBoneWeightptr, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int index) {} // 0x0000000185F453B0-0x0000000185F453C0
		public static unsafe void UpdateBoneWeight2RangeKernel_BurstManaged(int startIndex, BoneWeight* centerBoneWeight, BoneWeight* meshBoneWeights, int* mappingReferenceIndices, VertexAttribute* mappingAttributes, int length) {} // 0x000000018770FDA8-0x000000018770FEA4
	}

	public class RenderData : IDisposable, ITransform // TypeDefIndex: 45982
	{
		// Fields
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
		private const int Flag_UseCustomMesh = 0; // Metadata: 0x0205E9CB
		private const int Flag_ChangePositionNormal = 1; // Metadata: 0x0205E9CC
		private const int Flag_ChangeBoneWeight = 2; // Metadata: 0x0205E9CD
		private const int Flag_ModifyBoneWeight = 3; // Metadata: 0x0205E9CE
		private const int Flag_HasMeshTangent = 4; // Metadata: 0x0205E9CF
		private const int Flag_HasTangent = 5; // Metadata: 0x0205E9D0
		private const int Flag_ChangeTangent = 6; // Metadata: 0x0205E9D1
		private BitField32 flag; // 0xC0
	
		// Properties
		public int ReferenceCount { get; private set; } // 0x000000018770B540-0x000000018770B940 0x000000018770B1D0-0x000000018770B3C8
		internal string Name { get => default; } // 0x000000018770B940-0x000000018770BA28 
		internal bool HasSkinnedMesh { get => default; } // 0x000000018770B3C8-0x000000018770B4DC 
		internal bool HasBoneWeight { get => default; } // 0x000000018770B4DC-0x000000018770B540 
		public bool UseCustomMesh { get => default; } // 0x000000018770ADEC-0x000000018770AE54 
		public bool HasMeshTangent { get => default; } // 0x000000018770C464-0x000000018770C6B0 
		public bool HasTangent { get => default; } // 0x000000018770C304-0x000000018770C464 
		internal ResultCode Result { get => default; } // 0x000000018770C874-0x000000018770C8EC 
	
		// Nested types
		private struct UpdatePositionNormalJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45978
		{
			// Fields
			public int startIndex; // 0x00
			public NativeArray<float3> meshLocalPositions; // 0x08
			public NativeArray<float3> meshLocalNormals; // 0x18
			public NativeArray<int> mappingReferenceIndices; // 0x28
			public NativeArray<VertexAttribute> mappingAttributes; // 0x38
			public NativeArray<float3> mappingPositions; // 0x48
			public NativeArray<float3> mappingNormals; // 0x58
			public int _indexCount; // 0x68
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x0000000181C0BBD0-0x0000000181C0BBE0
			public void Execute() {} // 0x0000000181378230-0x0000000181378240
			public void Execute(int index) {} // 0x000000018770C924-0x000000018770C9A4
			public void UnsafeDo() {} // 0x000000018770C908-0x000000018770C918
		}
	
		private struct UpdatePositionNormalTangentJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45979
		{
			// Fields
			public int startIndex; // 0x00
			public NativeArray<float3> meshLocalPositions; // 0x08
			public NativeArray<float3> meshLocalNormals; // 0x18
			public NativeArray<float4> meshLocalTangents; // 0x28
			public NativeArray<int> mappingReferenceIndices; // 0x38
			public NativeArray<VertexAttribute> mappingAttributes; // 0x48
			public NativeArray<float3> mappingPositions; // 0x58
			public NativeArray<float3> mappingNormals; // 0x68
			public NativeArray<float3> mappingTangents; // 0x78
			public int _indexCount; // 0x88
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x000000018770C8EC-0x000000018770C8FC
			public void Execute() {} // 0x000000018770C9C4-0x000000018770C9D0
			public void Execute(int index) {} // 0x000000018770C8FC-0x000000018770C908
			public void UnsafeDo() {} // 0x000000018770C918-0x000000018770C924
		}
	
		private struct UpdateBoneWeightJob2 : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 45980
		{
			// Fields
			public int startIndex; // 0x00
			public BoneWeight centerBoneWeight; // 0x04
			public NativeArray<BoneWeight> meshBoneWeights; // 0x28
			public NativeArray<int> mappingReferenceIndices; // 0x38
			public NativeArray<VertexAttribute> mappingAttributes; // 0x48
			public int _indexCount; // 0x58
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x000000018770AC70-0x000000018770ADEC
			public void Execute() {} // 0x000000018770AE54-0x000000018770AEC0
			public void Execute(int index) {} // 0x000000018770B164-0x000000018770B1D0
			public void UnsafeDo() {} // 0x000000018770AEC0-0x000000018770B110
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 45981
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ClothProcess, bool> __9__52_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018770C9A4-0x000000018770C9C4
			public __c() {} // 0x000000018770AC20-0x000000018770AC70
	
			// Methods
			internal bool _UpdateUse_b__52_0(ClothProcess x) => default; // 0x000000018770B110-0x000000018770B164
		}
	
		// Constructors
		public RenderData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x000000018770C6B0-0x000000018770C874
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018770BE9C-0x000000018770C304
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x000000018770BC74-0x000000018770BE9C
		internal void Initialize(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referencePreBuildUniqueSetupData) {} // 0x000000018770BA28-0x000000018770BC74
		internal int AddReferenceCount() => default; // 0x000000018765AF34-0x000000018765AF3C
		internal int RemoveReferenceCount() => default; // 0x0000000187710888-0x00000001877108E0
		private void SwapCustomMesh() {} // 0x00000001877106F8-0x000000018771076C
		private void ResetCustomMeshWorkData() {} // 0x000000018771076C-0x0000000187710888
		private void SwapOriginalMesh() {} // 0x00000001877108E0-0x00000001877109A0
		private void SetMesh(Mesh mesh) {} // 0x0000000187711684-0x00000001877116E0
		public void StartUse(ClothProcess cprocess) {} // 0x0000000187711488-0x0000000187711500
		public void EndUse(ClothProcess cprocess) {} // 0x0000000187711500-0x0000000187711684
		internal void UpdateUse(ClothProcess cprocess, int add) {} // 0x00000001877116E0-0x00000001877117DC
		internal void UpdateSkipWriting() {} // 0x0000000187710304-0x000000018771035C
		internal void WriteMesh() {} // 0x00000001877101B8-0x000000018771022C
		internal JobHandle UpdatePositionNormal(bool updateTangent, DataChunk mappingChunk, JobHandle jobHandle) => default; // 0x000000018771022C-0x0000000187710304
		internal JobHandle UpdateBoneWeight(DataChunk mappingChunk, JobHandle jobHandle = default) => default; // 0x000000018771035C-0x0000000187710424
		public override string ToString() => default; // 0x000000018770F5B4-0x000000018770F618
		public string __iFixBaseProxy_ToString() => default; // 0x000000018770F4F0-0x000000018770F538
	}

	public class RenderManager : IManager, IValid // TypeDefIndex: 45983
	{
		// Fields
		private Dictionary<int, BeyondDynamicBone.RenderData> renderDataDict; // 0x10
		private bool isValid; // 0x18
	
		// Constructors
		public RenderManager() {} // 0x0000000184CCB0D0-0x0000000184CCB150
	
		// Methods
		public void Initialize() {} // 0x0000000184CCB7A0-0x0000000184CCB900
		public void EnterdEditMode() {} // 0x000000018770CC9C-0x000000018770CCEC
		public void Dispose() {} // 0x0000000184CCB900-0x0000000184CCBE80
		public bool IsValid() => default; // 0x000000018770D1F4-0x000000018770D240
		public int AddRenderer(Renderer ren, RenderSetupData referenceSetupData, RenderSetupData.UniqueSerializationData referenceUniqueSetupData) => default; // 0x000000018770C9D0-0x000000018770CC14
		public bool RemoveRenderer(int handle) => default; // 0x000000018770D240-0x000000018770D428
		public BeyondDynamicBone.RenderData GetRendererData(int handle) => default; // 0x000000018770CCEC-0x000000018770CE90
		public void StartUse(ClothProcess cprocess, int handle) {} // 0x000000018770D428-0x000000018770D4AC
		public void EndUse(ClothProcess cprocess, int handle) {} // 0x000000018770CC14-0x000000018770CC9C
		private void PreRenderingUpdate() {} // 0x0000000184407E70-0x0000000184408120
		public void InformationLog(StringBuilder allsb) {} // 0x000000018770CE90-0x000000018770D1F4
	}

	public class RenderSetupData : IDisposable, ITransform // TypeDefIndex: 45992
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
		public int TransformCount { get => default; } // 0x000000018770DA04-0x000000018770DEC0 
		public bool HasMeshDataArray { get => default; } // 0x000000018770D5A0-0x000000018770D624 
		public bool HasLocalPositions { get => default; } // 0x000000018770D624-0x000000018770D6A8 
		public bool HasTangent { get => default; } // 0x00000001857A7C50-0x00000001857A7D30 
	
		// Nested types
		public enum SetupType // TypeDefIndex: 45984
		{
			MeshCloth = 0,
			BoneCloth = 1,
			BoneSpring = 2
		}
	
		public enum BoneConnectionMode // TypeDefIndex: 45985
		{
			Line = 0,
			AutomaticMesh = 1,
			SequentialLoopMesh = 2,
			SequentialNonLoopMesh = 3
		}
	
		private struct VertexWeight5BoneCheckJob : IJob // TypeDefIndex: 45986
		{
			// Fields
			public int vcnt; // 0x00
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			public NativeReference<Define.Result> result; // 0x18
	
			// Methods
			public void Execute() {} // 0x000000018770D9B0-0x000000018770DA04
		}
	
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 45987
		{
			// Fields
			public NativeArray<float3> positions; // 0x00
			public NativeArray<quaternion> rotations; // 0x10
			public NativeArray<float3> scales; // 0x20
			public NativeArray<float3> localPositions; // 0x30
			public NativeArray<quaternion> localRotations; // 0x40
			public NativeArray<quaternion> inverseRotations; // 0x50
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x00000001840D97A0-0x00000001840D97E0
		}
	
		private struct GetBoneWeightJos : IJob // TypeDefIndex: 45988
		{
			// Fields
			public int vcnt; // 0x00
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			public NativeArray<BoneWeight1> boneWeightArray; // 0x18
			public NativeArray<BoneWeight> boneWeights; // 0x28
	
			// Methods
			public void Execute() {} // 0x0000000184545C20-0x0000000184545C90
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 45989
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
			public bool HasTangent { get => default; } // 0x000000018770F404-0x000000018770F40C 
	
			// Constructors
			public ShareSerializationData() {} // 0x000000018770F3CC-0x000000018770F404
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 45991
		{
			// Fields
			public ResultCode result; // 0x10
			public Renderer renderer; // 0x18
			public SkinnedMeshRenderer skinRenderer; // 0x20
			public MeshFilter meshFilter; // 0x28
			public Mesh originalMesh; // 0x30
			public List<Transform> transformList; // 0x38
	
			// Nested types
			private sealed class __c__DisplayClass6_0 // TypeDefIndex: 45990
			{
				// Fields
				public HashSet<Transform> transformSet; // 0x10
	
				// Constructors
				public __c__DisplayClass6_0() {} // 0x000000018770F40C-0x000000018770F48C
	
				// Methods
				internal void _GetUsedTransform_b__0(Transform x) {} // 0x000000018770F384-0x000000018770F3CC
			}
	
			// Constructors
			public UniqueSerializationData() {} // 0x0000000184B3A530-0x0000000184B3C1D0
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018770E650-0x000000018770F384
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x0000000184872C40-0x0000000184873C50
		}
	
		// Constructors
		public RenderSetupData() {} // 0x000000018770D728-0x000000018770D7A8
		public RenderSetupData(Renderer ren) {} // 0x000000018770D6A8-0x000000018770D728
		public RenderSetupData(SetupType setType, Transform renderTransform, List<Transform> rootTransforms, List<Transform> ignoreFromRootBones, List<Transform> collisionBones, BoneConnectionMode connectionMode = BoneConnectionMode.Line /* Metadata: 0x0205E9D2 */, string name = "(no name)" /* Metadata: 0x0205E9D3 */) {} // 0x000000018770D7A8-0x000000018770D834
	
		// Methods
		public bool IsSuccess() => default; // 0x0000000185F065B0-0x0000000185F06710
		public bool IsFaild() => default; // 0x000000018770D834-0x000000018770D9B0
		private void ReadTransformInformation(bool includeChilds) {} // 0x0000000184545C90-0x0000000184545D50
		public void Dispose() {} // 0x000000018770D4AC-0x000000018770D5A0
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018770E1D4-0x000000018770E488
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x000000018770DEC0-0x000000018770E1D4
		public Transform GetRendeerTransform() => default; // 0x000000018770E488-0x000000018770E650
		public int GetRenderTransformId() => default; // 0x0000000187711FB8-0x0000000187712050
		public float4x4 GetRendeerLocalToWorldMatrix() => default; // 0x000000018770A8C8-0x000000018770AC20
		public Transform GetSkinRootTransform() => default; // 0x0000000187709B28-0x0000000187709C70
		public int GetSkinRootTransformId() => default; // 0x000000018770F48C-0x000000018770F4A0
		public int GetTransformIndexFromId(int id) => default; // 0x0000000185492010-0x0000000185492020
		public int GetParentTransformIndex(int index, bool centerExcluded) => default; // 0x000000018770F618-0x000000018770F71C
		public void GetBoneWeightsRun(NativeArray<BoneWeight> weights) {} // 0x000000018770F71C-0x000000018770F8A0
		public ShareSerializationData ShareSerialize() => default; // 0x0000000185492010-0x0000000185492020
		public static RenderSetupData ShareDeserialize(ShareSerializationData sdata) => default; // 0x0000000185492010-0x0000000185492020
		public UniqueSerializationData UniqueSerialize() => default; // 0x000000018770F538-0x000000018770F5B4
	}

	internal static class EndSimulationStepJobKernels // TypeDefIndex: 45997
	{
		// Nested types
		public unsafe delegate void EndSimulationStepKernel_000003B8_PostfixBurstDelegate(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index); // TypeDefIndex: 45993; 0x0000000187709358-0x00000001877093E0
	
		internal static class EndSimulationStepKernel_000003B8_BurstDirectCall // TypeDefIndex: 45994
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EndSimulationStepKernel_000003B8_BurstDirectCall() {} // 0x00000001877093E0-0x00000001877094E4
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061e38) {} // 0x00000001877096C4-0x0000000187709798
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876BEB84-0x00000001876BEB98
			public static void Constructor() {} // 0x000000018770960C-0x00000001877096C4
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index) {} // 0x00000001877094E4-0x0000000187709538
		}
	
		public unsafe delegate void EndSimulationStepRangeKernel_000003B9_PostfixBurstDelegate(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr); // TypeDefIndex: 45995; 0x0000000185492010-0x0000000185492020
	
		internal static class EndSimulationStepRangeKernel_000003B9_BurstDirectCall // TypeDefIndex: 45996
		{
			// Fields
			private static IntPtr Pointer; // 0x00
			private static IntPtr DeferredCompilation; // 0x08
	
			// Constructors
			static EndSimulationStepRangeKernel_000003B9_BurstDirectCall() {} // 0x0000000187709798-0x000000018770989C
	
			// Methods
			private static void GetFunctionPointerDiscard(ref IntPtr param_00061e50) {} // 0x0000000187709A54-0x0000000187709B28
			private static IntPtr GetFunctionPointer() => default; // 0x00000001876BEB84-0x00000001876BEB98
			public static void Constructor() {} // 0x00000001877099F8-0x0000000187709A54
			public static void Initialize() {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void Invoke(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr) {} // 0x000000018770989C-0x00000001877098F0
		}
	
		// Methods
		private static unsafe void EndSimulationStepKernel(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index) {} // 0x0000000185F471C0-0x0000000185F47250
		internal static unsafe void EndSimulationStepRangeKernel(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
		public static unsafe void EndSimulationStepKernel_BurstManaged(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int index) {} // 0x0000000185F471B0-0x0000000185F471C0
		public static unsafe void EndSimulationStepRangeKernel_BurstManaged(int* jobColliderIndexList, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, int* lengthPtr) {} // 0x00000001877098F0-0x00000001877099F8
	}

	public class ColliderManager : IManager, IValid // TypeDefIndex: 46025
	{
		// Fields
		public ExNativeArray<short> teamIdArray; // 0x10
		public const byte Flag_Valid = 16; // Metadata: 0x0205E9E4
		public const byte Flag_Enable = 32; // Metadata: 0x0205E9E5
		public const byte Flag_Reset = 64; // Metadata: 0x0205E9E6
		public const byte Flag_Reverse = 128; // Metadata: 0x0205E9E7
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
		public int DataCount { get => default; } // 0x00000001864BB614-0x00000001864BB734 
		public int ColliderCount { get => default; } // 0x000000018771DAE8-0x000000018771DBEC 
	
		// Nested types
		public static class ColliderKernels // TypeDefIndex: 46002
		{
			// Nested types
			public unsafe delegate void PreSimulationUpdateKernel_000003D1_PostfixBurstDelegate(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index); // TypeDefIndex: 45998; 0x0000000187708BE0-0x0000000187708C20
	
			internal static class PreSimulationUpdateKernel_000003D1_BurstDirectCall // TypeDefIndex: 45999
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateKernel_000003D1_BurstDirectCall() {} // 0x0000000184D5E500-0x0000000184D5E700
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061ee2) {} // 0x000000018551DE00-0x000000018551E230
				private static IntPtr GetFunctionPointer() => default; // 0x0000000184D5CF60-0x0000000184D5CF90
				public static void Constructor() {} // 0x0000000184B397A0-0x0000000184B39B10
				public static void Initialize() {} // 0x0000000184D5E7C0-0x0000000184D5F8B0
				public static unsafe void Invoke(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index) {} // 0x0000000184D5D8B0-0x0000000184D5E500
			}
	
			public unsafe delegate void PreSimulationUpdateRangeKernel_000003D2_PostfixBurstDelegate(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length); // TypeDefIndex: 46000; 0x0000000184D5CF90-0x0000000184D5D590
	
			internal static class PreSimulationUpdateRangeKernel_000003D2_BurstDirectCall // TypeDefIndex: 46001
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateRangeKernel_000003D2_BurstDirectCall() {} // 0x0000000184706EA0-0x0000000184707450
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061f1e) {} // 0x0000000184B3C8C0-0x0000000184B3CAB0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187708934-0x0000000187708BE0
				public static void Constructor() {} // 0x0000000184703120-0x0000000184703510
				public static void Initialize() {} // 0x00000001847040A0-0x0000000184704420
				public static unsafe void Invoke(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x0000000184706AC0-0x0000000184706EA0
			}
	
			// Methods
			public static unsafe void PreSimulationUpdateKernel(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index) {} // 0x0000000184702EE0-0x0000000184703120
			public static unsafe void PreSimulationUpdateRangeKernel(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x0000000187707D7C-0x0000000187708934
			public static unsafe void PreSimulationUpdateKernel_BurstManaged(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int index) {} // 0x0000000184CCB050-0x0000000184CCB0D0
			public static unsafe void PreSimulationUpdateRangeKernel_BurstManaged(ExBitFlag8* flagArray, short* teamIdArray, float3* centerArray, double3* framePositions, quaternion* frameRotations, float3* frameScales, double3* oldFramePositions, quaternion* oldFrameRotations, double3* nowPositions, quaternion* nowRotations, double3* oldPositions, quaternion* oldRotations, double3* transformPositionArray, quaternion* transformRotationArray, float3* transformScaleArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, int length) {} // 0x000000018568D6B0-0x000000018568D710
		}
	
		private static class CreateUpdatecolliderListJobKernels // TypeDefIndex: 46007
		{
			// Nested types
			public unsafe delegate void CreateUpdatecolliderListKernel_000003D3_PostfixBurstDelegate(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId); // TypeDefIndex: 46003; 0x000000018568D770-0x000000018568D7D0
	
			internal static class CreateUpdatecolliderListKernel_000003D3_BurstDirectCall // TypeDefIndex: 46004
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdatecolliderListKernel_000003D3_BurstDirectCall() {} // 0x0000000187661F9C-0x0000000187662078
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061f54) {} // 0x0000000187719AC4-0x0000000187719BFC
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187712B18-0x0000000187713398
				public static void Constructor() {} // 0x0000000187713398-0x00000001877134D4
				public static void Initialize() {} // 0x000000018771FA20-0x000000018771FAF4
				public static unsafe void Invoke(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId) {} // 0x000000018771F8F8-0x000000018771FA20
			}
	
			public unsafe delegate void CreateUpdatecolliderListRangeKernel_000003D4_PostfixBurstDelegate(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length); // TypeDefIndex: 46005; 0x000000018771F560-0x000000018771F664
	
			internal static class CreateUpdatecolliderListRangeKernel_000003D4_BurstDirectCall // TypeDefIndex: 46006
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdatecolliderListRangeKernel_000003D4_BurstDirectCall() {} // 0x0000000187661F9C-0x0000000187662078
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061f69) {} // 0x0000000185492010-0x0000000185492020
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185F46710-0x0000000185F46720
				public static void Constructor() {} // 0x000000018771F6B8-0x000000018771F8F8
				public static void Initialize() {} // 0x000000018771FA20-0x000000018771FAF4
				public static unsafe void Invoke(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length) {} // 0x0000000187720564-0x000000018772068C
			}
	
			// Methods
			public static unsafe void CreateUpdatecolliderListKernel(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void CreateUpdatecolliderListRangeKernel(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length) {} // 0x00000001877201D4-0x00000001877202D8
			public static unsafe void CreateUpdatecolliderListKernel_BurstManaged(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int teamId) {} // 0x00000001877202D8-0x000000018772032C
			public static unsafe void CreateUpdatecolliderListRangeKernel_BurstManaged(int updateIndex, TeamManager.TeamData* teamDataArray, int* jobColliderCounter, int* jobColliderIndexList, int length) {} // 0x0000000185F465E0-0x0000000185F46670
		}
	
		public static class StartSimulationStepJobKernels // TypeDefIndex: 46012
		{
			// Nested types
			public unsafe delegate void StartSimulationStepKernel_000003D5_PostfixBurstDelegate(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index); // TypeDefIndex: 46008; 0x0000000185F465D0-0x0000000185F465E0
	
			internal static class StartSimulationStepKernel_000003D5_BurstDirectCall // TypeDefIndex: 46009
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepKernel_000003D5_BurstDirectCall() {} // 0x00000001817C0490-0x00000001817C04B0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00061fda) {} // 0x000000018771AB00-0x000000018771AB7C
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187713A94-0x0000000187714958
				public static void Constructor() {} // 0x000000018771AA94-0x000000018771AB00
				public static void Initialize() {} // 0x000000018771B0A0-0x000000018771B168
				public static unsafe void Invoke(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index) {} // 0x000000018771AFEC-0x000000018771B0A0
			}
	
			public unsafe delegate void StartSimulationStepRangeKernel_000003D6_PostfixBurstDelegate(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr); // TypeDefIndex: 46010; 0x000000018771ADD8-0x000000018771AEDC
	
			internal static class StartSimulationStepRangeKernel_000003D6_BurstDirectCall // TypeDefIndex: 46011
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepRangeKernel_000003D6_BurstDirectCall() {} // 0x00000001817C0490-0x00000001817C04B0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062013) {} // 0x0000000185492010-0x0000000185492020
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185F476B0-0x0000000185F476C0
				public static void Constructor() {} // 0x000000018771AF30-0x000000018771AFEC
				public static void Initialize() {} // 0x000000018771B0A0-0x000000018771B168
				public static unsafe void Invoke(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr) {} // 0x000000018771B39C-0x000000018771B450
			}
	
			// Methods
			private static unsafe void StartSimulationStepKernel(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index) {} // 0x00000001864BB614-0x00000001864BB734
			internal static unsafe void StartSimulationStepRangeKernel(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr) {} // 0x000000018771B168-0x000000018771B26C
			public static unsafe void StartSimulationStepKernel_BurstManaged(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int index) {} // 0x000000018771B26C-0x000000018771B2C0
			public static unsafe void StartSimulationStepRangeKernel_BurstManaged(int* jobColliderIndexList, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, short* teamIdArray, ExBitFlag8* flagArray, float3* sizeArray, float3* framePositions, quaternion* frameRotations, float3* frameScales, float3* oldFramePositions, quaternion* oldFrameRotations, float3* nowPositions, quaternion* nowRotations, float3* oldPositions, quaternion* oldRotations, WorkData* workDataArray, int* lengthPtr) {} // 0x0000000185F47620-0x0000000185F476B0
		}
	
		private static class PostSimulationUpdateJobKernels // TypeDefIndex: 46017
		{
			// Nested types
			public unsafe delegate void PostSimulationUpdateKernel_000003D7_PostfixBurstDelegate(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index); // TypeDefIndex: 46013; 0x0000000185F47610-0x0000000185F47620
	
			internal static class PostSimulationUpdateKernel_000003D7_BurstDirectCall // TypeDefIndex: 46014
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostSimulationUpdateKernel_000003D7_BurstDirectCall() {} // 0x00000001876F78F4-0x00000001876F79C4
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062054) {} // 0x0000000187723824-0x0000000187723950
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187716028-0x0000000187717D58
				public static void Constructor() {} // 0x0000000187717D58-0x0000000187717E80
				public static void Initialize() {} // 0x00000001876F79C4-0x00000001876F7A98
				public static unsafe void Invoke(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index) {} // 0x0000000187725358-0x0000000187725474
			}
	
			public unsafe delegate void PostSimulationUpdateRangeKernel_000003D8_PostfixBurstDelegate(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length); // TypeDefIndex: 46015; 0x0000000187724FE0-0x00000001877250E4
	
			internal static class PostSimulationUpdateRangeKernel_000003D8_BurstDirectCall // TypeDefIndex: 46016
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PostSimulationUpdateRangeKernel_000003D8_BurstDirectCall() {} // 0x00000001876F7ECC-0x00000001876F7F9C
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006206f) {} // 0x0000000185492010-0x0000000185492020
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185F45B30-0x0000000185F45B40
				public static void Constructor() {} // 0x0000000187725138-0x0000000187725358
				public static void Initialize() {} // 0x00000001876F7F9C-0x00000001876F8070
				public static unsafe void Invoke(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length) {} // 0x00000001876F7E0C-0x00000001876F7ECC
			}
	
			// Methods
			private static unsafe void PostSimulationUpdateKernel(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index) {} // 0x00000001864BB614-0x00000001864BB734
			internal static unsafe void PostSimulationUpdateRangeKernel(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length) {} // 0x0000000187725DB4-0x0000000187725EB8
			public static unsafe void PostSimulationUpdateKernel_BurstManaged(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int index) {} // 0x0000000187725EB8-0x0000000187725F0C
			public static unsafe void PostSimulationUpdateRangeKernel_BurstManaged(short* teamIdArray, float3* framePositions, quaternion* frameRotations, float3* oldFramePositions, quaternion* oldFrameRotations, TeamManager.TeamData* teamDataArray, int length) {} // 0x0000000185F45A00-0x0000000185F45A90
		}
	
		public enum ColliderType : byte // TypeDefIndex: 46018
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
	
		internal struct WorkData // TypeDefIndex: 46019
		{
			// Fields
			public AABB aabb; // 0x00
			public float2 radius; // 0x30
			public double3x2 oldPos; // 0x38
			public double3x2 nextPos; // 0x68
			public quaternion inverseOldRot; // 0x98
			public quaternion rot; // 0xA8
		}
	
		private struct PreSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 46020
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x10
			public NativeArray<short> teamIdArray; // 0x20
			public NativeArray<ExBitFlag8> flagArray; // 0x30
			public NativeArray<float3> centerArray; // 0x40
			public NativeArray<double3> framePositions; // 0x50
			public NativeArray<quaternion> frameRotations; // 0x60
			public NativeArray<float3> frameScales; // 0x70
			public NativeArray<double3> oldFramePositions; // 0x80
			public NativeArray<quaternion> oldFrameRotations; // 0x90
			public NativeArray<double3> nowPositions; // 0xA0
			public NativeArray<quaternion> nowRotations; // 0xB0
			public NativeArray<double3> oldPositions; // 0xC0
			public NativeArray<quaternion> oldRotations; // 0xD0
			public NativeArray<double3> transformPositionArray; // 0xE0
			public NativeArray<quaternion> transformRotationArray; // 0xF0
			public NativeArray<float3> transformScaleArray; // 0x100
			public int _indexCount; // 0x110
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x0000000185492010-0x0000000185492020
			public void Execute() {} // 0x0000000185F459F0-0x0000000185F45A00
			public void Execute(int index) {} // 0x0000000187725F0C-0x0000000187726128
			public void UnsafeDo() {} // 0x000000018771D2BC-0x000000018771D350
		}
	
		private struct CreateUpdatecolliderListJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 46021
		{
			// Fields
			public int updateIndex; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			public NativeReference<int> jobColliderCounter; // 0x18
			public NativeArray<int> jobColliderIndexList; // 0x28
			public int _indexCount; // 0x38
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x000000018771D3E4-0x000000018771D478
			public void Execute() {} // 0x0000000187714F58-0x00000001877159C8
			public void Execute(int teamId) {} // 0x000000018771D350-0x000000018771D3E4
			public void UnsafeDo() {} // 0x000000018771DA14-0x000000018771DAE8
		}
	
		private struct StartSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 46022
		{
			// Fields
			public NativeArray<int> jobColliderIndexList; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x20
			public NativeArray<short> teamIdArray; // 0x30
			public NativeArray<ExBitFlag8> flagArray; // 0x40
			public NativeArray<float3> sizeArray; // 0x50
			public NativeArray<double3> framePositions; // 0x60
			public NativeArray<quaternion> frameRotations; // 0x70
			public NativeArray<float3> frameScales; // 0x80
			public NativeArray<double3> oldFramePositions; // 0x90
			public NativeArray<quaternion> oldFrameRotations; // 0xA0
			public NativeArray<double3> nowPositions; // 0xB0
			public NativeArray<quaternion> nowRotations; // 0xC0
			public NativeArray<double3> oldPositions; // 0xD0
			public NativeArray<quaternion> oldRotations; // 0xE0
			public NativeArray<WorkData> workDataArray; // 0xF0
			public NativeReference<int> _indexCount; // 0x100
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x000000018771DA00-0x000000018771DA14
			public void Execute() {} // 0x000000018771D93C-0x000000018771DA00
			public void Execute(int index) {} // 0x00000001864BB614-0x00000001864BB734
			public void UnsafeDo() {} // 0x000000018771D6F8-0x000000018771D7FC
		}
	
		private struct EndSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 46023
		{
			// Fields
			public NativeArray<int> jobColliderIndexList; // 0x00
			public NativeArray<double3> nowPositions; // 0x10
			public NativeArray<quaternion> nowRotations; // 0x20
			public NativeArray<double3> oldPositions; // 0x30
			public NativeArray<quaternion> oldRotations; // 0x40
			public NativeReference<int> _indexCount; // 0x50
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x000000018771D7FC-0x000000018771D850
			public void Execute() {} // 0x0000000185F469A0-0x0000000185F46A30
			public void Execute(int index) {} // 0x0000000185492010-0x0000000185492020
			public void UnsafeDo() {} // 0x0000000185F46990-0x0000000185F469A0
		}
	
		private struct PostSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 46024
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeArray<short> teamIdArray; // 0x10
			public NativeArray<double3> framePositions; // 0x20
			public NativeArray<quaternion> frameRotations; // 0x30
			public NativeArray<double3> oldFramePositions; // 0x40
			public NativeArray<quaternion> oldFrameRotations; // 0x50
			public int _indexCount; // 0x60
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x000000018771D850-0x000000018771D93C
			public void Execute() {} // 0x000000018771DA14-0x000000018771DAE8
			public void Execute(int index) {} // 0x000000018771DA00-0x000000018771DA14
			public void UnsafeDo() {} // 0x000000018771DD60-0x000000018771DE24
		}
	
		// Constructors
		public ColliderManager() {} // 0x000000018771C594-0x000000018771C650
	
		// Methods
		public void Dispose() {} // 0x000000018771DBEC-0x000000018771DC40
		public void EnterdEditMode() {} // 0x0000000185F46900-0x0000000185F46990
		public void Initialize() {} // 0x0000000185492010-0x0000000185492020
		public bool IsValid() => default; // 0x0000000185F468F0-0x0000000185F46900
		public void Register(ClothProcess cprocess) {} // 0x000000018771DC40-0x000000018771DD60
		public void Exit(ClothProcess cprocess) {} // 0x0000000184F3FFC0-0x0000000184F40000
		internal void InitColliders(ClothProcess cprocess) {} // 0x000000018771EA04-0x000000018771EA7C
		internal void UpdateColliders(ClothProcess cprocess) {} // 0x000000018771EA7C-0x000000018771F350
		private void AddCollider(ClothProcess cprocess, ColliderComponent col) {} // 0x000000018771F350-0x000000018771F560
		internal void RemoveCollider(ColliderComponent col, int teamId) {} // 0x0000000184DCCE20-0x0000000184DCCEB0
		private void AddColliderInternal(ClothProcess cprocess, ColliderComponent col, int index, int arrayIndex, int transformIndex) {} // 0x000000018771AB7C-0x000000018771ABF0
		internal void EnableCollider(ColliderComponent col, int teamId, bool sw) {} // 0x000000018771ABF0-0x000000018771AD38
		internal void EnableTeamCollider(int teamId) {} // 0x000000018771AD38-0x000000018771ADD8
		internal void UpdateParameters(ColliderComponent col, int teamId) {} // 0x0000000184D0A320-0x0000000184D0A3C0
		internal JobHandle PreSimulationUpdate(JobHandle jobHandle) => default; // 0x0000000187723E8C-0x0000000187723F24
		internal JobHandle CreateUpdateColliderList(int updateIndex, JobHandle jobHandle) => default; // 0x0000000187723F24-0x0000000187724DB8
		internal JobHandle StartSimulationStep(JobHandle jobHandle) => default; // 0x0000000187724DB8-0x0000000187724FE0
		internal JobHandle EndSimulationStep(JobHandle jobHandle) => default; // 0x0000000184D81F30-0x0000000184D81FD0
		internal JobHandle PostSimulationUpdate(JobHandle jobHandle) => default; // 0x000000018771C500-0x000000018771C594
		public void InformationLog(StringBuilder allsb) {} // 0x000000018771C460-0x000000018771C500
		public static void Initialize_CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D3_BurstDirectCall() {} // 0x0000000184F9C000-0x0000000184F9C040
		public static void Initialize_CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D4_BurstDirectCall() {} // 0x000000018771D478-0x000000018771D4EC
		public static void Initialize_PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D7_BurstDirectCall() {} // 0x000000018771D4EC-0x000000018771D638
		public static void Initialize_PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003D8_BurstDirectCall() {} // 0x000000018771D638-0x000000018771D6F8
	}

	public class SimulationManager : IManager, IValid // TypeDefIndex: 46074
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
		private int _SimulationStepCount_k__BackingField; // 0x168
		private bool isValid; // 0x16C
	
		// Properties
		public int ParticleCount { get => default; } // 0x000000018772BD1C-0x000000018772BE58 
		internal int SimulationStepCount { get; private set; } // 0x0000000184F1D440-0x0000000184F1D6B0 0x000000018772E9EC-0x000000018772EA64
		internal int WorkerCount { get => default; } // 0x000000018772E07C-0x000000018772E9EC 
	
		// Nested types
		public static class CreateUpdateParticleListKernels // TypeDefIndex: 46030
		{
			// Nested types
			public unsafe delegate void CreateUpdateParticleListKernel_00000401_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId); // TypeDefIndex: 46026; 0x0000000185FB1210-0x0000000185FB1220
	
			internal static class CreateUpdateParticleListKernel_00000401_BurstDirectCall // TypeDefIndex: 46027
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdateParticleListKernel_00000401_BurstDirectCall() {} // 0x0000000184B394E0-0x0000000184B397A0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062115) {} // 0x000000018551F820-0x000000018551FCE0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187720B9C-0x0000000187720BEC
				public static void Constructor() {} // 0x000000018551E230-0x000000018551EEC0
				public static void Initialize() {} // 0x0000000187721A20-0x0000000187721A70
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId) {} // 0x00000001840D99E0-0x00000001840D9C30
			}
	
			public unsafe delegate void CreateUpdateParticleListRangeKernel_00000402_PostfixBurstDelegate(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length); // TypeDefIndex: 46028; 0x0000000184702A10-0x0000000184702E60
	
			internal static class CreateUpdateParticleListRangeKernel_00000402_BurstDirectCall // TypeDefIndex: 46029
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CreateUpdateParticleListRangeKernel_00000402_BurstDirectCall() {} // 0x0000000187720F48-0x0000000187721A20
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006215a) {} // 0x0000000184701680-0x0000000184701A00
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187720BEC-0x0000000187720D2C
				public static void Constructor() {} // 0x0000000187720E7C-0x0000000187720F48
				public static void Initialize() {} // 0x0000000187720D2C-0x0000000187720E7C
				public static unsafe void Invoke(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length) {} // 0x0000000185492010-0x0000000185492020
			}
	
			// Methods
			public static unsafe void CreateUpdateParticleListKernel(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId) {} // 0x000000018568D830-0x000000018568D890
			public static unsafe void CreateUpdateParticleListRangeKernel(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length) {} // 0x000000018568D890-0x000000018568D8F0
			public static unsafe void CreateUpdateParticleListKernel_BurstManaged(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int teamId) {} // 0x000000018568D8F0-0x000000018568D950
			public static unsafe void CreateUpdateParticleListRangeKernel_BurstManaged(TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, int* stepParticleIndexArray, int* stepBaseLineIndexArray, int* stepTriangleBendIndexArray, int* stepEdgeCollisionIndexArray, int* motionParticleIndexArray, int* selfParticleIndexArray, uint* selfPointTriangleIndexArray, uint* selfEdgeEdgeIndexArray, uint* selfTrianglePointIndexArray, int* stepParticleIndexCounter, int* stepBaseLineIndexCounter, int* stepTriangleBendIndexCounter, int* stepEdgeCollisionIndexCounter, int* motionParticleIndexCounter, int* selfParticleCounter, int* selfPointTriangleCounter, int* selfEdgeEdgeCounter, int* selfTrianglePointCounter, int length) {} // 0x000000018568D950-0x000000018568D9B0
		}
	
		public static class PreSimulationUpdateJobKernels // TypeDefIndex: 46035
		{
			// Nested types
			public unsafe delegate void PreSimulationUpdateKernel_00000403_PostfixBurstDelegate(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex); // TypeDefIndex: 46031; 0x000000018568DA10-0x000000018568DA70
	
			internal static class PreSimulationUpdateKernel_00000403_BurstDirectCall // TypeDefIndex: 46032
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateKernel_00000403_BurstDirectCall() {} // 0x000000018771A20C-0x000000018771A374
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000621ed) {} // 0x000000018568DB30-0x000000018568DB90
				private static IntPtr GetFunctionPointer() => default; // 0x000000018568DB90-0x000000018568DBF0
				public static void Constructor() {} // 0x000000018568DBF0-0x000000018568DC50
				public static void Initialize() {} // 0x000000018568DC50-0x000000018568DCB0
				public static unsafe void Invoke(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex) {} // 0x000000018771A374-0x000000018771A4DC
			}
	
			public unsafe delegate void PreSimulationUpdateRangeKernel_00000404_PostfixBurstDelegate(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length); // TypeDefIndex: 46033; 0x0000000187713928-0x0000000187713A94
	
			internal static class PreSimulationUpdateRangeKernel_00000404_BurstDirectCall // TypeDefIndex: 46034
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static PreSimulationUpdateRangeKernel_00000404_BurstDirectCall() {} // 0x0000000185F47800-0x0000000185F47890
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006222f) {} // 0x0000000187719FEC-0x000000018771A138
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x0000000187719BFC-0x0000000187719D00
				public static void Initialize() {} // 0x0000000187719D00-0x0000000187719D54
				public static unsafe void Invoke(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length) {} // 0x0000000185492010-0x0000000185492020
			}
	
			// Methods
			public static unsafe void PreSimulationUpdateKernel(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex) {} // 0x0000000185F477F0-0x0000000185F47800
			public static unsafe void PreSimulationUpdateRangeKernel(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length) {} // 0x0000000187719D54-0x0000000187719FEC
			public static unsafe void PreSimulationUpdateKernel_BurstManaged(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int pindex) {} // 0x000000018771A138-0x000000018771A20C
			public static unsafe void PreSimulationUpdateRangeKernel_BurstManaged(short* teamIdArray, double3* nextPosArray, double3* oldPosArray, quaternion* oldRotArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, double3* dispPosArray, float3* velocityArray, float3* realVelocityArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, TeamManager.TeamData* teamDataArray, InertiaConstraint.CenterData* centerDataArray, double3* positions, quaternion* rotations, int length) {} // 0x000000018765A33C-0x000000018765A440
		}
	
		private static class StartSimulationStepJobKernels // TypeDefIndex: 46046
		{
			// Nested types
			public unsafe delegate void StartSimulationStepKernel_00000405_PostfixBurstDelegate(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // TypeDefIndex: 46036; 0x00000001864BB614-0x00000001864BB734
	
			internal static class StartSimulationStepKernel_00000405_BurstDirectCall // TypeDefIndex: 46037
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepKernel_00000405_BurstDirectCall() {} // 0x000000018771E754-0x000000018771E8AC
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062327) {} // 0x0000000185F47760-0x0000000185F477F0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185492010-0x0000000185492020
				public static void Constructor() {} // 0x0000000185F47750-0x0000000185F47760
				public static void Initialize() {} // 0x000000018771A634-0x000000018771A8CC
				public static unsafe void Invoke(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x000000018771E8AC-0x000000018771EA04
			}
	
			public unsafe delegate void StartSimulationStepRangeKernel_00000406_PostfixBurstDelegate(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // TypeDefIndex: 46038; 0x00000001877159C8-0x0000000187716028
	
			internal static class StartSimulationStepRangeKernel_00000406_BurstDirectCall // TypeDefIndex: 46039
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static StartSimulationStepRangeKernel_00000406_BurstDirectCall() {} // 0x0000000185F46680-0x0000000185F46710
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062384) {} // 0x000000018771FECC-0x000000018772000C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x000000018771FAF4-0x000000018771FBF8
				public static void Initialize() {} // 0x000000018771FBF8-0x000000018771FC4C
				public static unsafe void Invoke(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
			}
	
			public delegate void Spring_00000407_PostfixBurstDelegate(in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, in double3 basePos, in quaternion baseRot, double noiseTime, double scaleRatio); // TypeDefIndex: 46040; 0x000000018771FC4C-0x000000018771FECC
	
			internal static class Spring_00000407_BurstDirectCall // TypeDefIndex: 46041
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Spring_00000407_BurstDirectCall() {} // 0x0000000185F46540-0x0000000185F465D0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000623b5) {} // 0x0000000187720A5C-0x0000000187720B9C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x000000018772068C-0x0000000187720790
				public static void Initialize() {} // 0x0000000187720790-0x00000001877207E4
				public static void Invoke(in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, in double3 basePos, in quaternion baseRot, double noiseTime, double scaleRatio) {} // 0x0000000185492010-0x0000000185492020
			}
	
			public unsafe delegate void Wind_00000408_PostfixBurstDelegate(int teamId, in TeamManager.TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result); // TypeDefIndex: 46042; 0x00000001877207E4-0x0000000187720A5C
	
			internal static class Wind_00000408_BurstDirectCall // TypeDefIndex: 46043
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static Wind_00000408_BurstDirectCall() {} // 0x0000000187717E80-0x00000001877180A0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000623da) {} // 0x00000001877223C8-0x0000000187722460
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187723DB0-0x0000000187723E8C
				public static void Constructor() {} // 0x0000000187723950-0x00000001877239D0
				public static void Initialize() {} // 0x0000000187722460-0x0000000187723304
				public static unsafe void Invoke(int teamId, in TeamManager.TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result) {} // 0x0000000187721EC4-0x00000001877223C8
			}
	
			public delegate void WindForceBlend_00000409_PostfixBurstDelegate(in TeamWindInfo windInfo, in WindParams windParams, in float3 windPos, float windTurbulence, ref float3 result); // TypeDefIndex: 46044; 0x00000001877180A0-0x0000000187719064
	
			internal static class WindForceBlend_00000409_BurstDirectCall // TypeDefIndex: 46045
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static WindForceBlend_00000409_BurstDirectCall() {} // 0x0000000185F45AA0-0x0000000185F45B30
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000623f6) {} // 0x0000000187725984-0x0000000187725B78
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x0000000187725474-0x0000000187725578
				public static void Initialize() {} // 0x0000000187725578-0x00000001877255CC
				public static void Invoke(in TeamWindInfo windInfo, in WindParams windParams, in float3 windPos, float windTurbulence, ref float3 result) {} // 0x0000000185492010-0x0000000185492020
			}
	
			// Methods
			private static unsafe void StartSimulationStepKernel(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x0000000185F45A90-0x0000000185F45AA0
			internal static unsafe void StartSimulationStepRangeKernel(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x00000001877255CC-0x0000000187725984
			private static void Spring(in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, in double3 basePos, in quaternion baseRot, double noiseTime, double scaleRatio) {} // 0x0000000187726984-0x0000000187726A4C
			private static unsafe void Wind(int teamId, in TeamManager.TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result) {} // 0x000000018772680C-0x0000000187726984
			private static void WindForceBlend(in TeamWindInfo windInfo, in WindParams windParams, in float3 windPos, float windTurbulence, ref float3 result) {} // 0x0000000187726630-0x000000018772680C
			public static unsafe void StartSimulationStepKernel_BurstManaged(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x00000001864BB614-0x00000001864BB734
			public static unsafe void StartSimulationStepRangeKernel_BurstManaged(float simulationPowerX, float simulationPowerY, float simulationPowerZ, float simulationPowerW, float simulationDeltaTime, int* stepParticleIndexArray, VertexAttribute* attributes, float* depthArray, double3* positions, quaternion* rotations, int* vertexRootIndices, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, short* teamIdArray, double3* oldPosArray, float3* velocityArray, double3* nextPosArray, double3* basePosArray, quaternion* baseRotArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* velocityPosArray, float* frictionArray, double3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x0000000187726128-0x000000018772622C
			public static void Spring_BurstManaged(in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, in double3 basePos, in quaternion baseRot, double noiseTime, double scaleRatio) {} // 0x000000018772622C-0x0000000187726280
			public static unsafe void Wind_BurstManaged(int teamId, in TeamManager.TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, TeamWindData* teamWindArray, WindManager.WindData* windDataArray, int* vertexRootIndices, float* frictionArray, ref float3 result) {} // 0x0000000185F45960-0x0000000185F459F0
			public static void WindForceBlend_BurstManaged(in TeamWindInfo windInfo, in WindParams windParams, in float3 windPos, float windTurbulence, ref float3 result) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private static class UpdateStepBasicPotureJobKernels // TypeDefIndex: 46051
		{
			// Nested types
			public unsafe delegate void UpdateStepBasicPotureKernel_0000040A_PostfixBurstDelegate(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index); // TypeDefIndex: 46047; 0x0000000187726280-0x0000000187726630
	
			internal static class UpdateStepBasicPotureKernel_0000040A_BurstDirectCall // TypeDefIndex: 46048
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateStepBasicPotureKernel_0000040A_BurstDirectCall() {} // 0x0000000185F45BE0-0x0000000185F45C70
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062455) {} // 0x0000000187721CC4-0x0000000187721DF0
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x0000000187721A70-0x0000000187721B74
				public static void Initialize() {} // 0x0000000187721B74-0x0000000187721BC8
				public static unsafe void Invoke(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x0000000185492010-0x0000000185492020
			}
	
			public unsafe delegate void UpdateStepBasicPotureRangeKernel_0000040B_PostfixBurstDelegate(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr); // TypeDefIndex: 46049; 0x0000000187721BC8-0x0000000187721CC4
	
			internal static class UpdateStepBasicPotureRangeKernel_0000040B_BurstDirectCall // TypeDefIndex: 46050
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static UpdateStepBasicPotureRangeKernel_0000040B_BurstDirectCall() {} // 0x0000000185F44A60-0x0000000185F44AF0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062485) {} // 0x0000000187728318-0x000000018772848C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x0000000187728044-0x0000000187728148
				public static void Initialize() {} // 0x0000000187728148-0x000000018772819C
				public static unsafe void Invoke(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
			}
	
			// Methods
			private static unsafe void UpdateStepBasicPotureKernel(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x0000000185F44A50-0x0000000185F44A60
			internal static unsafe void UpdateStepBasicPotureRangeKernel(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x000000018772819C-0x0000000187728318
			public static unsafe void UpdateStepBasicPotureKernel_BurstManaged(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int index) {} // 0x0000000187727F70-0x0000000187728044
			public static unsafe void UpdateStepBasicPotureRangeKernel_BurstManaged(int* stepBaseLineIndexArray, TeamManager.TeamData* teamDataArray, VertexAttribute* attributes, int* vertexParentIndices, float3* vertexLocalPositions, quaternion* vertexLocalRotations, ushort* baseLineStartDataIndices, ushort* baseLineDataCounts, ushort* baseLineData, float3* basePosArray, quaternion* baseRotArray, float3* stepBasicPositionArray, quaternion* stepBasicRotationArray, int* lengthPtr) {} // 0x00000001817C0490-0x00000001817C04B0
		}
	
		private static class EndSimulationStepJobKernels // TypeDefIndex: 46056
		{
			// Nested types
			public unsafe delegate void EndSimulationStepKernel_0000040C_PostfixBurstDelegate(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index); // TypeDefIndex: 46052; 0x00000001864BB614-0x00000001864BB734
	
			internal static class EndSimulationStepKernel_0000040C_BurstDirectCall // TypeDefIndex: 46053
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EndSimulationStepKernel_0000040C_BurstDirectCall() {} // 0x0000000187727314-0x0000000187727410
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000624ff) {} // 0x0000000185F44BA0-0x0000000185F44C30
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185492010-0x0000000185492020
				public static void Constructor() {} // 0x0000000185F44B90-0x0000000185F44BA0
				public static void Initialize() {} // 0x0000000187727DA4-0x0000000187727E68
				public static unsafe void Invoke(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index) {} // 0x0000000187727410-0x0000000187727510
			}
	
			public unsafe delegate void EndSimulationStepRangeKernel_0000040D_PostfixBurstDelegate(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr); // TypeDefIndex: 46054; 0x0000000187719064-0x0000000187719160
	
			internal static class EndSimulationStepRangeKernel_0000040D_BurstDirectCall // TypeDefIndex: 46055
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static EndSimulationStepRangeKernel_0000040D_BurstDirectCall() {} // 0x0000000185F44F60-0x0000000185F44FF0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062538) {} // 0x0000000187727834-0x000000018772792C
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x0000000187727510-0x0000000187727614
				public static void Initialize() {} // 0x0000000187727614-0x0000000187727668
				public static unsafe void Invoke(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x0000000185492010-0x0000000185492020
			}
	
			// Methods
			private static unsafe void EndSimulationStepKernel(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index) {} // 0x0000000185F44F50-0x0000000185F44F60
			internal static unsafe void EndSimulationStepRangeKernel(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x0000000187727668-0x0000000187727834
			public static unsafe void EndSimulationStepKernel_BurstManaged(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int index) {} // 0x0000000187666E44-0x0000000187666F18
			public static unsafe void EndSimulationStepRangeKernel_BurstManaged(float simulationDeltaTime, int* stepParticleIndexArray, TeamManager.TeamData* teamDataArray, ClothParameters* parameterArray, InertiaConstraint.CenterData* centerDataArray, VertexAttribute* attributes, float* vertexDepths, short* teamIdArray, double3* nextPosArray, double3* oldPosArray, float3* velocityArray, float3* realVelocityArray, double3* velocityPosArray, float* frictionArray, float* staticFrictionArray, float3* collisionNormalArray, int* lengthPtr) {} // 0x0000000187666D98-0x0000000187666E44
		}
	
		private static class CalcDisplayPositionJobKernels // TypeDefIndex: 46061
		{
			// Nested types
			public unsafe delegate void CalcDisplayPositionKernel_0000040E_PostfixBurstDelegate(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex); // TypeDefIndex: 46057; 0x00000001864BB614-0x00000001864BB734
	
			internal static class CalcDisplayPositionKernel_0000040E_BurstDirectCall // TypeDefIndex: 46058
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcDisplayPositionKernel_0000040E_BurstDirectCall() {} // 0x000000018771C208-0x000000018771C334
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006259d) {} // 0x0000000185F44EC0-0x0000000185F44F50
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185492010-0x0000000185492020
				public static void Constructor() {} // 0x0000000185F44EB0-0x0000000185F44EC0
				public static void Initialize() {} // 0x0000000187727A84-0x0000000187727C4C
				public static unsafe void Invoke(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex) {} // 0x000000018771C334-0x000000018771C460
			}
	
			public unsafe delegate void CalcDisplayPositionRangeKernel_0000040F_PostfixBurstDelegate(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length); // TypeDefIndex: 46059; 0x0000000187714958-0x0000000187714A88
	
			internal static class CalcDisplayPositionRangeKernel_0000040F_BurstDirectCall // TypeDefIndex: 46060
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static CalcDisplayPositionRangeKernel_0000040F_BurstDirectCall() {} // 0x0000000185F47260-0x0000000185F472F0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000625ca) {} // 0x000000018771C9CC-0x000000018771CB00
				private static IntPtr GetFunctionPointer() => default; // 0x00000001864BB614-0x00000001864BB734
				public static void Constructor() {} // 0x000000018771C650-0x000000018771C754
				public static void Initialize() {} // 0x000000018771C754-0x000000018771C7A8
				public static unsafe void Invoke(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length) {} // 0x0000000185492010-0x0000000185492020
			}
	
			// Methods
			private static unsafe void CalcDisplayPositionKernel(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex) {} // 0x0000000185F47250-0x0000000185F47260
			internal static unsafe void CalcDisplayPositionRangeKernel(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length) {} // 0x000000018771C7A8-0x000000018771C9CC
			public static unsafe void CalcDisplayPositionKernel_BurstManaged(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int pindex) {} // 0x000000018771D1F4-0x000000018771D2BC
			public static unsafe void CalcDisplayPositionRangeKernel_BurstManaged(float simulationDeltaTime, TeamManager.TeamData* teamDataArray, short* teamIdArray, double3* oldPosArray, float3* realVelocityArray, double3* oldPositionArray, quaternion* oldRotationArray, double3* dispPosArray, VertexAttribute* attributes, double3* positions, quaternion* rotations, int* vertexRootIndices, int length) {} // 0x000000018771D124-0x000000018771D1F4
		}
	
		private static class ClearStepCounterKernels // TypeDefIndex: 46064
		{
			// Nested types
			public unsafe delegate void ClearStepCounterKernel_00000410_PostfixBurstDelegate(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint); // TypeDefIndex: 46062; 0x00000001864BB614-0x00000001864BB734
	
			internal static class ClearStepCounterKernel_00000410_BurstDirectCall // TypeDefIndex: 46063
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static ClearStepCounterKernel_00000410_BurstDirectCall() {} // 0x00000001877196B8-0x00000001877197A8
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062605) {} // 0x0000000185F47120-0x0000000185F471B0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000185492010-0x0000000185492020
				public static void Constructor() {} // 0x0000000185F47110-0x0000000185F47120
				public static void Initialize() {} // 0x000000018771CDEC-0x000000018771D008
				public static unsafe void Invoke(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint) {} // 0x000000018771989C-0x000000018771998C
			}
	
			// Methods
			internal static unsafe void ClearStepCounterKernel(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint) {} // 0x0000000187719160-0x00000001877196B8
			public static unsafe void ClearStepCounterKernel_BurstManaged(int* processingStepParticle, int* processingStepTriangleBending, int* processingStepEdgeCollision, int* processingStepCollider, int* processingStepBaseLine, int* processingStepMotionParticle, int* processingSelfParticle, int* processingSelfPointTriangle, int* processingSelfEdgeEdge, int* processingSelfTrianglePoint) {} // 0x00000001877197A8-0x000000018771989C
		}
	
		private struct PreSimulationUpdateJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 46065
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeArray<ClothParameters> parameterArray; // 0x10
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x20
			public NativeArray<double3> positions; // 0x30
			public NativeArray<quaternion> rotations; // 0x40
			public NativeArray<float> vertexDepths; // 0x50
			public NativeArray<short> teamIdArray; // 0x60
			public NativeArray<double3> nextPosArray; // 0x70
			public NativeArray<double3> oldPosArray; // 0x80
			public NativeArray<quaternion> oldRotArray; // 0x90
			public NativeArray<double3> basePosArray; // 0xA0
			public NativeArray<quaternion> baseRotArray; // 0xB0
			public NativeArray<double3> oldPositionArray; // 0xC0
			public NativeArray<quaternion> oldRotationArray; // 0xD0
			public NativeArray<double3> velocityPosArray; // 0xE0
			public NativeArray<double3> dispPosArray; // 0xF0
			public NativeArray<float3> velocityArray; // 0x100
			public NativeArray<float3> realVelocityArray; // 0x110
			public NativeArray<float> frictionArray; // 0x120
			public NativeArray<float> staticFrictionArray; // 0x130
			public NativeArray<float3> collisionNormalArray; // 0x140
			public int _indexCount; // 0x150
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x000000018772B6F4-0x000000018772B7BC
			public void Execute() {} // 0x000000018772B658-0x000000018772B6F4
			public void Execute(int pindex) {} // 0x000000018772B554-0x000000018772B658
			public void UnsafeDo() {} // 0x00000001864BB614-0x00000001864BB734
		}
	
		private struct ClearStepCounter : IJob, IUnsafeJob // TypeDefIndex: 46066
		{
			// Fields
			public NativeReference<int> processingStepParticle; // 0x00
			public NativeReference<int> processingStepTriangleBending; // 0x10
			public NativeReference<int> processingStepEdgeCollision; // 0x20
			public NativeReference<int> processingStepCollider; // 0x30
			public NativeReference<int> processingStepBaseLine; // 0x40
			public NativeReference<int> processingStepMotionParticle; // 0x50
			public NativeReference<int> processingSelfParticle; // 0x60
			public NativeReference<int> processingSelfPointTriangle; // 0x70
			public NativeReference<int> processingSelfEdgeEdge; // 0x80
			public NativeReference<int> processingSelfTrianglePoint; // 0x90
	
			// Methods
			public void Execute() {} // 0x000000018772B250-0x000000018772B354
			public void UnsafeDo() {} // 0x000000018772B354-0x000000018772B3A8
		}
	
		private struct CreateUpdateParticleList : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 46067
		{
			// Fields
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x00
			public NativeArray<ClothParameters> parameterArray; // 0x10
			public NativeReference<int> stepParticleIndexCounter; // 0x20
			public NativeArray<int> stepParticleIndexArray; // 0x30
			public NativeReference<int> stepBaseLineIndexCounter; // 0x40
			public NativeArray<int> stepBaseLineIndexArray; // 0x50
			public NativeReference<int> stepTriangleBendIndexCounter; // 0x60
			public NativeArray<int> stepTriangleBendIndexArray; // 0x70
			public NativeReference<int> stepEdgeCollisionIndexCounter; // 0x80
			public NativeArray<int> stepEdgeCollisionIndexArray; // 0x90
			public NativeReference<int> motionParticleIndexCounter; // 0xA0
			public NativeArray<int> motionParticleIndexArray; // 0xB0
			public NativeReference<int> selfParticleCounter; // 0xC0
			public NativeArray<int> selfParticleIndexArray; // 0xD0
			public NativeReference<int> selfPointTriangleCounter; // 0xE0
			public NativeArray<uint> selfPointTriangleIndexArray; // 0xF0
			public NativeReference<int> selfEdgeEdgeCounter; // 0x100
			public NativeArray<uint> selfEdgeEdgeIndexArray; // 0x110
			public NativeReference<int> selfTrianglePointCounter; // 0x120
			public NativeArray<uint> selfTrianglePointIndexArray; // 0x130
			public int _indexCount; // 0x140
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x0000000185F483E0-0x0000000185F48470
			public void Execute() {} // 0x0000000185492010-0x0000000185492020
			public void Execute(int teamId) {} // 0x0000000185F483D0-0x0000000185F483E0
			public void UnsafeDo() {} // 0x000000018772B3A8-0x000000018772B554
		}
	
		private struct StartSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 46068
		{
			// Fields
			public float4 simulationPower; // 0x00
			public float simulationDeltaTime; // 0x10
			public NativeArray<int> stepParticleIndexArray; // 0x18
			public NativeArray<VertexAttribute> attributes; // 0x28
			public NativeArray<float> depthArray; // 0x38
			public NativeArray<double3> positions; // 0x48
			public NativeArray<quaternion> rotations; // 0x58
			public NativeArray<int> vertexRootIndices; // 0x68
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x78
			public NativeArray<ClothParameters> parameterArray; // 0x88
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x98
			public NativeArray<TeamWindData> teamWindArray; // 0xA8
			public NativeArray<WindManager.WindData> windDataArray; // 0xB8
			public NativeArray<short> teamIdArray; // 0xC8
			public NativeArray<double3> oldPosArray; // 0xD8
			public NativeArray<double3> nextPosArray; // 0xE8
			public NativeArray<double3> basePosArray; // 0xF8
			public NativeArray<float3> velocityArray; // 0x108
			public NativeArray<quaternion> baseRotArray; // 0x118
			public NativeArray<double3> oldPositionArray; // 0x128
			public NativeArray<quaternion> oldRotationArray; // 0x138
			public NativeArray<double3> velocityPosArray; // 0x148
			public NativeArray<float> frictionArray; // 0x158
			public NativeArray<double3> stepBasicPositionArray; // 0x168
			public NativeArray<quaternion> stepBasicRotationArray; // 0x178
			public NativeReference<int> _indexCount; // 0x188
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x000000018772B6F4-0x000000018772B7BC
			public void Execute() {} // 0x000000018772B658-0x000000018772B6F4
			public void Execute(int index) {} // 0x000000018772BAC0-0x000000018772BBC4
			private void Spring(in SpringConstraint.SpringConstraintParams springParams, ClothNormalAxis normalAxis, ref double3 nextPos, in double3 basePos, in quaternion baseRot, double noiseTime, float scaleRatio) {} // 0x00000001864BB614-0x00000001864BB734
			private void Wind(int teamId, in TeamManager.TeamData tdata, in WindParams windParams, in InertiaConstraint.CenterData cdata, int vindex, int pindex, float depth, ref float3 result) {} // 0x000000018772B7BC-0x000000018772B8C0
			private void WindForceBlend(in TeamWindInfo windInfo, in WindParams windParams, in float3 windPos, float windTurbulence, ref float3 result) {} // 0x000000018772B8C0-0x000000018772B914
			public void UnsafeDo() {} // 0x0000000185F48340-0x0000000185F483D0
		}
	
		private struct UpdateStepBasicPotureJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 46069
		{
			// Fields
			public NativeArray<int> stepBaseLineIndexArray; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x10
			public NativeArray<VertexAttribute> attributes; // 0x20
			public NativeArray<int> vertexParentIndices; // 0x30
			public NativeArray<float3> vertexLocalPositions; // 0x40
			public NativeArray<quaternion> vertexLocalRotations; // 0x50
			public NativeArray<ushort> baseLineStartDataIndices; // 0x60
			public NativeArray<ushort> baseLineDataCounts; // 0x70
			public NativeArray<ushort> baseLineData; // 0x80
			public NativeArray<double3> basePosArray; // 0x90
			public NativeArray<quaternion> baseRotArray; // 0xA0
			public NativeArray<double3> stepBasicPositionArray; // 0xB0
			public NativeArray<quaternion> stepBasicRotationArray; // 0xC0
			public NativeReference<int> _indexCount; // 0xD0
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185492010-0x0000000185492020
			public void Execute() {} // 0x0000000185F48330-0x0000000185F48340
			public void Execute(int index) {} // 0x000000018772B914-0x000000018772BAC0
			public void UnsafeDo() {} // 0x000000018772BE58-0x000000018772BF1C
		}
	
		private struct EndSimulationStepJob : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 46070
		{
			// Fields
			public float simulationDeltaTime; // 0x00
			public NativeArray<int> stepParticleIndexArray; // 0x08
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x18
			public NativeArray<ClothParameters> parameterArray; // 0x28
			public NativeArray<InertiaConstraint.CenterData> centerDataArray; // 0x38
			public NativeArray<VertexAttribute> attributes; // 0x48
			public NativeArray<float> vertexDepths; // 0x58
			public NativeArray<short> teamIdArray; // 0x68
			public NativeArray<double3> nextPosArray; // 0x78
			public NativeArray<double3> oldPosArray; // 0x88
			public NativeArray<double3> velocityPosArray; // 0x98
			public NativeArray<float3> velocityArray; // 0xA8
			public NativeArray<float3> realVelocityArray; // 0xB8
			public NativeArray<float> frictionArray; // 0xC8
			public NativeArray<float> staticFrictionArray; // 0xD8
			public NativeArray<float3> collisionNormalArray; // 0xE8
			public NativeReference<int> _indexCount; // 0xF8
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185FB1230-0x0000000185FB1270
			public void Execute() {} // 0x0000000187668948-0x0000000187668A1C
			public void Execute(int index) {} // 0x0000000183706EE0-0x0000000183706F60
			public void UnsafeDo() {} // 0x00000001876688D8-0x0000000187668948
		}
	
		private struct CalcDisplayPositionJob : IJobParallelFor, ICrossFrameParallelForJob, IUnsafeJob // TypeDefIndex: 46071
		{
			// Fields
			public float simulationDeltaTime; // 0x00
			public NativeArray<TeamManager.TeamData> teamDataArray; // 0x08
			public NativeArray<short> teamIdArray; // 0x18
			public NativeArray<double3> oldPosArray; // 0x28
			public NativeArray<double3> oldPositionArray; // 0x38
			public NativeArray<double3> dispPosArray; // 0x48
			public NativeArray<double3> positions; // 0x58
			public NativeArray<float3> realVelocityArray; // 0x68
			public NativeArray<quaternion> oldRotationArray; // 0x78
			public NativeArray<VertexAttribute> attributes; // 0x88
			public NativeArray<quaternion> rotations; // 0x98
			public NativeArray<int> vertexRootIndices; // 0xA8
			public int _indexCount; // 0xB8
	
			// Methods
			public void SetIndexCount(int indexCount) {} // 0x00000001864BB614-0x00000001864BB734
			public void Execute() {} // 0x000000018772BBC4-0x000000018772BCC8
			public void Execute(int pindex) {} // 0x000000018772BCC8-0x000000018772BD1C
			public void UnsafeDo() {} // 0x0000000185F479E0-0x0000000185F47A70
		}
	
		private struct FeedbackTempPosJob : IJobParallelForDefer // TypeDefIndex: 46072
		{
			// Fields
			public NativeList<int> jobParticleIndexList; // 0x00
			public NativeArray<double3> tempFloat3Buffer; // 0x10
			public NativeArray<double3> nextPosArray; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct FeedbackTempPosJob2 : IJobParallelForDefer // TypeDefIndex: 46073
		{
			// Fields
			public NativeArray<int> particleIndexArray; // 0x00
			public NativeArray<double3> tempFloat3Buffer; // 0x10
			public NativeArray<double3> nextPosArray; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x0000000185F479D0-0x0000000185F479E0
		}
	
		// Constructors
		public SimulationManager() {} // 0x000000018773706C-0x0000000187737104
	
		// Methods
		public void Dispose() {} // 0x000000018772EA64-0x000000018772EC9C
		public void EnterdEditMode() {} // 0x000000018772BF1C-0x000000018772BFCC
		public void Initialize() {} // 0x000000018772BFCC-0x000000018772C0C4
		public bool IsValid() => default; // 0x0000000184CFFCC0-0x0000000184CFFD50
		internal void RegisterProxyMesh(ClothProcess cprocess) {} // 0x000000018772C0C4-0x000000018772C13C
		internal void RegisterConstraint(ClothProcess cprocess) {} // 0x000000018772C13C-0x000000018772C5E8
		internal void ExitProxyMesh(ClothProcess cprocess) {} // 0x000000018772C5E8-0x000000018772C814
		internal void WorkBufferUpdate() {} // 0x0000000184D04E10-0x0000000184D04EB0
		internal JobHandle PreSimulationUpdate(JobHandle jobHandle) => default; // 0x0000000187730A04-0x0000000187730A9C
		internal JobHandle SimulationStepUpdate(int updateCount, int updateIndex, JobHandle jobHandle) => default; // 0x000000018772FBA4-0x0000000187730A04
		internal JobHandle CalcDisplayPosition(JobHandle jobHandle) => default; // 0x0000000187730A9C-0x0000000187731038
		internal JobHandle FeedbackTempFloat3Buffer(in NativeList<int> particleList, JobHandle jobHandle) => default; // 0x00000001877316BC-0x0000000187731B1C
		internal JobHandle FeedbackTempFloat3Buffer(in ExProcessingList<int> processingList, JobHandle jobHandle) => default; // 0x000000018773134C-0x00000001877316BC
		internal JobHandle FeedbackTempFloat3Buffer(in NativeArray<int> particleArray, in NativeReference<int> counter, JobHandle jobHandle) => default; // 0x0000000187731038-0x000000018773134C
		public void InformationLog(StringBuilder allsb) {} // 0x0000000184CFF1F0-0x0000000184CFF290
		public static void Initialize_StartSimulationStepJobKernels_StartSimulationStepKernel_00000405_BurstDirectCall() {} // 0x0000000187737104-0x0000000187737A38
		public static void Initialize_StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000406_BurstDirectCall() {} // 0x0000000187737A38-0x0000000187737BEC
		public static void Initialize_StartSimulationStepJobKernels_Spring_00000407_BurstDirectCall() {} // 0x0000000184D0A3C0-0x0000000184D0A460
		public static void Initialize_StartSimulationStepJobKernels_Wind_00000408_BurstDirectCall() {} // 0x000000018772D630-0x000000018772D6C8
		public static void Initialize_StartSimulationStepJobKernels_WindForceBlend_00000409_BurstDirectCall() {} // 0x000000018772C814-0x000000018772D630
		public static void Initialize_UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040A_BurstDirectCall() {} // 0x000000018772D6C8-0x000000018772D8E4
		public static void Initialize_UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040B_BurstDirectCall() {} // 0x0000000184F430F0-0x0000000184F43130
		public static void Initialize_EndSimulationStepJobKernels_EndSimulationStepKernel_0000040C_BurstDirectCall() {} // 0x000000018772AAEC-0x000000018772AB64
		public static void Initialize_EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040D_BurstDirectCall() {} // 0x000000018772AB64-0x000000018772B0E0
		public static void Initialize_CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_0000040E_BurstDirectCall() {} // 0x000000018772B0E0-0x000000018772B250
		public static void Initialize_CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_0000040F_BurstDirectCall() {} // 0x000000018772D964-0x000000018772DA10
		public static void Initialize_ClearStepCounterKernels_ClearStepCounterKernel_00000410_BurstDirectCall() {} // 0x000000018772D8E4-0x000000018772D964
	}

	public class TimeManager : IManager, IValid // TypeDefIndex: 46076
	{
		// Fields
		internal int simulationFrequency; // 0x10
		internal int maxSimulationCountPerFrame; // 0x14
		internal UpdateLocation updateLocation; // 0x18
		private bool isValid; // 0x1C
		private int _FixedUpdateCount_k__BackingField; // 0x20
		internal float GlobalTimeScale; // 0x24
		private float _SimulationDeltaTime_k__BackingField; // 0x28
		private float _MaxDeltaTime_k__BackingField; // 0x2C
		private float4 _SimulationPower_k__BackingField; // 0x30
		private static float _DeltaTime_k__BackingField; // 0x00
		private static float _FixedDeltaTime_k__BackingField; // 0x04
		private static float _UnscaledDeltaTime_k__BackingField; // 0x08
		private static bool _EnableAOVMode_k__BackingField; // 0x0C
	
		// Properties
		internal int FixedUpdateCount { get; private set; } // 0x00000001813B88B0-0x00000001813B88C0 0x00000001813B9430-0x00000001813B9440
		internal float SimulationDeltaTime { get; private set; } // 0x0000000185FB0A50-0x0000000185FB0A60 0x0000000185FB0A60-0x0000000185FB0A70
		internal float MaxDeltaTime { get; private set; } // 0x0000000185FB09A0-0x0000000185FB09B0 0x0000000185FB09B0-0x0000000185FB09C0
		internal float4 SimulationPower { get; private set; } // 0x0000000185FB1290-0x0000000185FB12A0 0x0000000185FB12A0-0x0000000185FB12B0
		internal static float DeltaTime { get; set; } // 0x0000000187732788-0x00000001877327C0 0x0000000187732868-0x00000001877328AC
		internal static float FixedDeltaTime { get; set; } // 0x00000001877327F8-0x0000000187732830 0x00000001877328E8-0x0000000187732930
		internal static float UnscaledDeltaTime { get; set; } // 0x0000000187732830-0x0000000187732868 0x0000000187732930-0x0000000187732978
		internal static bool EnableAOVMode { get; set; } // 0x00000001877327C0-0x00000001877327F8 0x00000001877328AC-0x00000001877328E8
	
		// Nested types
		public enum UpdateLocation // TypeDefIndex: 46075
		{
			AfterLateUpdate = 0,
			BeforeLateUpdate = 1
		}
	
		// Constructors
		public TimeManager() {} // 0x0000000185FB1270-0x0000000185FB1290
	
		// Methods
		public void Dispose() {} // 0x0000000187732200-0x0000000187732430
		public void EnterdEditMode() {} // 0x0000000187732430-0x0000000187732480
		public void Initialize() {} // 0x0000000184CCC970-0x0000000184CCCBC0
		public bool IsValid() => default; // 0x000000018773273C-0x0000000187732788
		private void AfterFixedUpdate() {} // 0x0000000184FEBB90-0x0000000184FEBC10
		private void AfterRenderring() {} // 0x00000001844081F0-0x0000000184408280
		public static float GetDeltaTime() => default; // 0x0000000185029B30-0x0000000185029BB0
		public static float GetFixedDeltaTime() => default; // 0x0000000185029AF0-0x0000000185029B30
		public static float GetUnscaledDeltaTime() => default; // 0x0000000185029AB0-0x0000000185029AF0
		internal void FrameUpdate() {} // 0x0000000184297DB0-0x0000000184297F80
		public void InformationLog(StringBuilder allsb) {} // 0x0000000187732480-0x000000018773273C
	}

	public class WindManager : IManager, IValid // TypeDefIndex: 46078
	{
		// Fields
		public const int Flag_Valid = 0; // Metadata: 0x0205E9F4
		public const int Flag_Enable = 1; // Metadata: 0x0205E9F5
		public const int Flag_Addition = 2; // Metadata: 0x0205E9F6
		public ExNativeArray<WindData> windDataArray; // 0x10
		private bool isValid; // 0x18
		private Dictionary<int, BeyondBoneWindZone> windZoneDict; // 0x20
	
		// Properties
		public int WindCount { get => default; } // 0x0000000184CCB1D0-0x0000000184CCB280 
	
		// Nested types
		public struct WindData // TypeDefIndex: 46077
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
			public bool IsValid() => default; // 0x0000000184702260-0x00000001847022A0
			public bool IsEnable() => default; // 0x0000000184CCB280-0x0000000184CCB2D0
			public bool IsAddition() => default; // 0x0000000187737E7C-0x0000000187737ECC
		}
	
		// Constructors
		public WindManager() {} // 0x0000000187737BEC-0x0000000187737C3C
	
		// Methods
		public void Dispose() {} // 0x0000000187738220-0x000000018773826C
		public void EnterdEditMode() {} // 0x0000000187737CDC-0x0000000187737E7C
		public void Initialize() {} // 0x000000018773826C-0x00000001877383F0
		public bool IsValid() => default; // 0x00000001877383F0-0x0000000187738834
		public int AddWind(BeyondBoneWindZone windZone) => default; // 0x0000000184FE6840-0x0000000184FE7000
		public void RemoveWind(int windId) {} // 0x0000000187737ECC-0x0000000187738220
		public void SetEnable(int windId, bool sw) {} // 0x0000000184CCAFD0-0x0000000184CCB050
		internal void AlwaysWindUpdate() {} // 0x0000000187737C8C-0x0000000187737CDC
		public void InformationLog(StringBuilder allsb) {} // 0x0000000187737C3C-0x0000000187737C8C
	}

	[Serializable]
	public class BeyondBoneClothSavePoint // TypeDefIndex: 46079
	{
		// Fields
		public BeyondBoneClothSavePoint_TeamManagerTeamData teamManagerTeamData; // 0x10
		public BeyondBoneClothSavePoint_ColliderManagerData colliderManagerData; // 0x18
		public BeyondBoneClothSavePoint_SimulationManagerData simulationManagerData; // 0x20
		public BeyondBoneClothSavePoint_VirtualMeshManagerData virtualMeshManagerData; // 0x28
		public BeyondBoneClothSavePoint_InertiaConstraintCenterData inertiaConstraintCenterData; // 0x30
	
		// Constructors
		public BeyondBoneClothSavePoint() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Load(ClothProcess cprocess, ColliderManager colliderManager, SimulationManager simulationManager, VirtualMeshManager virtualMeshManager, TeamManager teamManager) {} // 0x00000001877295CC-0x00000001877297F4
		public void LoadTeamManagerTeamData(ref TeamManager.TeamData teamData) {} // 0x0000000187729418-0x0000000187729494
		public void LoadColliderManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, ColliderManager colliderManager) {} // 0x0000000187728BE0-0x0000000187728DFC
		public void LoadSimulationManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, SimulationManager simulationManager) {} // 0x00000001877290D0-0x0000000187729418
		public void LoadVirtualMeshManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, VirtualMeshManager virtualMeshManager) {} // 0x0000000187729494-0x00000001877295CC
		public void LoadInertiaConstraintCenterData(ClothProcess cprocess, TeamManager teamManager) {} // 0x0000000187728DFC-0x00000001877290D0
		public void Save(ClothProcess cprocess, ColliderManager colliderManager, SimulationManager simulationManager, VirtualMeshManager virtualMeshManager, TeamManager teamManager) {} // 0x000000018772A9BC-0x000000018772AAEC
		public void SaveTeamManagerTeamData(ref TeamManager.TeamData teamData) {} // 0x000000018772A6C4-0x000000018772A780
		public void SaveColliderManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, ColliderManager colliderManager) {} // 0x00000001877297F4-0x0000000187729C14
		public void SaveSimulationManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, SimulationManager simulationManager) {} // 0x0000000187729FFC-0x000000018772A6C4
		public void SaveVirtualMeshManagerData(ref TeamManager.TeamData tdata, ClothProcess cprocess, VirtualMeshManager virtualMeshManager) {} // 0x000000018772A780-0x000000018772A9BC
		public void SaveInertiaConstraintCenterData(ClothProcess cprocess, TeamManager teamManager) {} // 0x0000000187729C14-0x0000000187729FFC
	}

	internal static class BeyondBoneClothSavePointHelper // TypeDefIndex: 46080
	{
		// Methods
		internal static void AddFromNative<T>(List<T> targetList, NativeArray<T> sourceArray, int sourceStartIndex, int length)
			where T : struct {}
		internal static void FillFromList<T>(NativeArray<T> targetArray, int targetStartIndex, List<T> sourceList, int sourceStartIndex, int length)
			where T : struct {}
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_TeamManagerTeamData // TypeDefIndex: 46081
	{
		// Fields
		public float velocityWeight; // 0x10
		public float blendWeight; // 0x14
	
		// Constructors
		public BeyondBoneClothSavePoint_TeamManagerTeamData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_ColliderManagerData // TypeDefIndex: 46082
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
		public BeyondBoneClothSavePoint_ColliderManagerData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_SimulationManagerData // TypeDefIndex: 46083
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
		public BeyondBoneClothSavePoint_SimulationManagerData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_VirtualMeshManagerData // TypeDefIndex: 46084
	{
		// Fields
		public int proxyMeshVertexCount; // 0x10
		public List<double3> positions; // 0x18
		public List<quaternion> rotations; // 0x20
	
		// Constructors
		public BeyondBoneClothSavePoint_VirtualMeshManagerData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class BeyondBoneClothSavePoint_InertiaConstraintCenterData // TypeDefIndex: 46085
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
		public BeyondBoneClothSavePoint_InertiaConstraintCenterData() {} // 0x0000000185492010-0x0000000185492020
	}

	public struct TeamWindInfo : IValid // TypeDefIndex: 46086
	{
		// Fields
		public int windId; // 0x00
		public float time; // 0x04
		public float main; // 0x08
		public float3 direction; // 0x0C
	
		// Methods
		public bool IsValid() => default; // 0x0000000187731F90-0x0000000187731FE8
		public override string ToString() => default; // 0x0000000187731FE8-0x00000001877321A8
		public void DebugLog() {} // 0x0000000187731F08-0x0000000187731F90
		public string __iFixBaseProxy_ToString() => default; // 0x00000001877321A8-0x0000000187732200
	}

	public struct TeamWindData // TypeDefIndex: 46087
	{
		// Fields
		public FixedList128Bytes<TeamWindInfo> windZoneList; // 0x00
		public TeamWindInfo movingWind; // 0x80
	
		// Properties
		public int ZoneCount { get => default; } // 0x0000000187731ED4-0x0000000187731F08 
	
		// Methods
		public int IndexOf(int windId) => default; // 0x0000000187731D7C-0x0000000187731E40
		public void ClearZoneList() {} // 0x0000000187731D08-0x0000000187731D7C
		public void AddOrReplaceWindZone(TeamWindInfo windInfo, in TeamWindData oldWindData) {} // 0x0000000187731B1C-0x0000000187731D08
		public void RemoveWindZone(int windId) {} // 0x0000000187731E40-0x0000000187731ED4
	}

	public class TransformData : IDisposable // TypeDefIndex: 46092
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
		public int Count { get => default; } // 0x0000000187733FEC-0x0000000187734638 
		public int RootCount { get => default; } // 0x0000000187732AD4-0x0000000187732DF4 
		public bool IsDirty { get => default; } // 0x0000000187732978-0x0000000187732AD4 
		public bool IsEmpty { get => default; } // 0x00000001840DA110-0x00000001840DA510 
	
		// Nested types
		private struct RestoreTransformJob : IJobParallelForTransform // TypeDefIndex: 46088
		{
			// Fields
			public int count; // 0x00
			public NativeArray<ExBitFlag8> flagList; // 0x08
			public NativeArray<float3> localPositionArray; // 0x18
			public NativeArray<quaternion> localRotationArray; // 0x28
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x0000000185492010-0x0000000185492020
		}
	
		private struct ReadTransformJob : IJobParallelForTransform // TypeDefIndex: 46089
		{
			// Fields
			public NativeArray<ExBitFlag8> flagList; // 0x00
			public NativeArray<float3> positionArray; // 0x10
			public NativeArray<quaternion> rotationArray; // 0x20
			public NativeArray<float3> scaleList; // 0x30
			public NativeArray<float3> localPositionArray; // 0x40
			public NativeArray<quaternion> localRotationArray; // 0x50
			public NativeArray<quaternion> inverseRotationArray; // 0x60
	
			// Methods
			public void Execute(int index, TransformAccess transform) {} // 0x0000000184872C30-0x0000000184872C40
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 46090
		{
			// Fields
			public ExSimpleNativeArray<ExBitFlag8> flagArray; // 0x10
			public ExSimpleNativeArray<float3> initLocalPositionArray; // 0x18
			public ExSimpleNativeArray<quaternion> initLocalRotationArray; // 0x20
	
			// Constructors
			public ShareSerializationData() {} // 0x0000000184873C50-0x0000000184874020
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 46091
		{
			// Fields
			public Transform[] transformArray; // 0x10
	
			// Constructors
			public UniqueSerializationData() {} // 0x0000000185A89330-0x0000000185A89370
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000184947E20-0x0000000184947FE0
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001840D99A0-0x00000001840D99E0
		}
	
		// Constructors
		public TransformData() {} // 0x0000000185FB0DA0-0x0000000185FB0DB0
		public TransformData(int capacity) {} // 0x00000001841C04C0-0x00000001841C04D0
	
		// Methods
		public void Init(int capacity) {} // 0x00000001877334C4-0x0000000187733FEC
		public void Dispose() {} // 0x0000000187732DF4-0x00000001877334C4
		public int AddTransform(Transform t, int tid = 0 /* Metadata: 0x0205E9F7 */, int pid = 0 /* Metadata: 0x0205E9F8 */, byte flag = 1 /* Metadata: 0x0205E9F9 */, bool checkDuplicate = true /* Metadata: 0x0205E9FA */) => default; // 0x00000001877359C4-0x0000000187735A94
		public int AddTransform(TransformRecord record, int pid = 0 /* Metadata: 0x0205E9FB */, byte flag = 1 /* Metadata: 0x0205E9FC */, bool checkDuplicate = true /* Metadata: 0x0205E9FD */) => default; // 0x0000000187735A94-0x0000000187735F9C
		public int AddTransform(TransformData srcData, int srcIndex, bool checkDuplicate = true /* Metadata: 0x0205E9FE */) => default;
		public int[] AddTransformRange(List<Transform> tlist, List<int> idList, List<int> pidList, int copyCount = 0 /* Metadata: 0x0205E9FF */) => default; // 0x0000000187736600-0x00000001877366C8
		public int[] AddTransformRange(TransformData stdata, int copyCount = 0 /* Metadata: 0x0205EA00 */) => default; // 0x0000000187735F9C-0x000000018773612C
		public int[] AddTransformRange(List<Transform> tlist, List<int> idList, List<int> pidList, List<int> rootIds, NativeArray<float3> localPositions, NativeArray<quaternion> localRotations, NativeArray<float3> positions, NativeArray<quaternion> rotations, NativeArray<float3> scales, NativeArray<quaternion> inverseRotations) => default; // 0x0000000187735800-0x00000001877359C4
		public void RemoveTransformIndex(int index) {} // 0x00000001877356A4-0x0000000187735800
		public int ReplaceTransform(int index, Transform t, int tid = 0 /* Metadata: 0x0205EA01 */, int pid = 0 /* Metadata: 0x0205EA02 */, byte flag = 1 /* Metadata: 0x0205EA03 */) => default; // 0x0000000187734AB8-0x00000001877356A4
		private int ReferenceIndexOf<T>(List<T> list, T item)
			where T : class => default; // 0x0000000184B3A4C0-0x0000000184B3A530
		public void UpdateWorkData() {} // 0x000000018773491C-0x00000001877349DC
		public JobHandle RestoreTransform(int count, JobHandle jobHandle = default) => default; // 0x0000000187734898-0x000000018773491C
		public JobHandle ReadTransform(JobHandle jobHandle = default) => default; // 0x0000000187734814-0x0000000187734898
		public void ReadTransformRun() {} // 0x0000000187734638-0x0000000187734814
		public void OrganizeReductionTransform(VirtualMesh vmesh, ReductionWorkData workData) {} // 0x00000001877349DC-0x0000000187734AB8
		public Transform GetTransformFromIndex(int index) => default; // 0x00000001877362E0-0x00000001877364B8
		public int GetTransformIndexFormId(int id) => default; // 0x000000018773612C-0x00000001877362E0
		public int GetTransformIdFromIndex(int index) => default; // 0x0000000184871760-0x0000000184871900
		public int GetParentIdFromIndex(int index) => default; // 0x00000001877364B8-0x0000000187736600
		public float4x4 GetLocalToWorldMatrix(int index) => default; // 0x000000018765AF34-0x000000018765AF3C
		public float4x4 GetWorldToLocalMatrix(int index) => default; // 0x000000018772F768-0x000000018772F880
		public override string ToString() => default; // 0x000000018772EC9C-0x000000018772F028
		public ShareSerializationData ShareSerialize() => default; // 0x0000000185492010-0x0000000185492020
		public static TransformData ShareDeserialize(ShareSerializationData sdata) => default; // 0x0000000187736E18-0x0000000187736F00
		public UniqueSerializationData UniqueSerialize() => default; // 0x0000000187736F00-0x000000018773706C
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185492010-0x0000000185492020
	}

	public class TransformRecord : IValid, ITransform // TypeDefIndex: 46093
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
		public TransformRecord(Transform t) {} // 0x00000001840DFF80-0x00000001840E0180
	
		// Methods
		public Vector3 InverseTransformDirection(Vector3 dir) => default; // 0x0000000187736754-0x0000000187736830
		public bool IsValid() => default; // 0x0000000187736830-0x0000000187736880
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x00000001877366C8-0x0000000187736754
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x0000000187736880-0x0000000187736998
	}

	public class PreBuildScriptableObject : ScriptableObject // TypeDefIndex: 46096
	{
		// Fields
		public List<SharePreBuildData> sharePreBuildDataList; // 0x18
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 46094
		{
			// Fields
			public SharePreBuildData sdata; // 0x10
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018772DCE8-0x000000018772DD54
	
			// Methods
			internal bool _AddPreBuildData_b__0(SharePreBuildData x) => default; // 0x000000018772DB74-0x000000018772DCE8
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 46095
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<SharePreBuildData> __9__4_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018772DA10-0x000000018772DB74
			public __c() {} // 0x000000018772DD54-0x000000018772DEA8
	
			// Methods
			internal void _Warmup_b__4_0(SharePreBuildData sdata) {} // 0x000000018772DEA8-0x000000018772DF28
		}
	
		// Constructors
		public PreBuildScriptableObject() {} // 0x0000000187736998-0x00000001877369F4
	
		// Methods
		public bool HasPreBuildData(string buildId) => default; // 0x0000000185492010-0x0000000185492020
		public SharePreBuildData GetPreBuildData(string buildId) => default; // 0x00000001877369F4-0x0000000187736A24
		public void AddPreBuildData(SharePreBuildData sdata) {} // 0x0000000187736A84-0x0000000187736AE8
		public void Warmup() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class PreBuildSerializeData : ITransform // TypeDefIndex: 46097
	{
		// Fields
		public bool enabled; // 0x10
		public SharePreBuildData preBuildData; // 0x18
		public UniquePreBuildData uniquePreBuildData; // 0x20
	
		// Constructors
		public PreBuildSerializeData() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public bool UsePreBuild() => default; // 0x00000001840DEF20-0x00000001840DEF50
		public ResultCode DataValidate() => default; // 0x000000018486FBF0-0x000000018486FCF0
		public SharePreBuildData GetSharePreBuildData() => default; // 0x000000018486FCF0-0x000000018486FD20
		public static string GenerateBuildID() => default; // 0x000000018772DF28-0x000000018772DFA4
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x000000018772DFA4-0x000000018772E010
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x000000018772E010-0x000000018772E07C
	}

	[Serializable]
	public class SharePreBuildData // TypeDefIndex: 46098
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
		public SharePreBuildData() {} // 0x0000000185609730-0x0000000185609890
	
		// Methods
		public ResultCode DataValidate() => default; // 0x00000001840DE410-0x00000001840DE480
		public bool CheckBuildId(string buildId) => default; // 0x000000018772F880-0x000000018772F8F4
		public override string ToString() => default; // 0x000000018772F8F4-0x000000018772FBA4
		public string __iFixBaseProxy_ToString() => default; // 0x000000018765AF34-0x000000018765AF3C
	}

	[Serializable]
	public class UniquePreBuildData : ITransform // TypeDefIndex: 46101
	{
		// Fields
		public int version; // 0x10
		public ResultCode buildResult; // 0x14
		public List<RenderSetupData.UniqueSerializationData> renderSetupDataList; // 0x20
		public VirtualMesh.UniqueSerializationData proxyMesh; // 0x28
		public List<VirtualMesh.UniqueSerializationData> renderMeshList; // 0x30
	
		// Nested types
		private sealed class __c__DisplayClass6_0 // TypeDefIndex: 46099
		{
			// Fields
			public HashSet<Transform> transformSet; // 0x10
	
			// Constructors
			public __c__DisplayClass6_0() {} // 0x000000018486FFB0-0x0000000184870010
	
			// Methods
			internal void _GetUsedTransform_b__0(RenderSetupData.UniqueSerializationData x) {} // 0x0000000187736AE8-0x0000000187736C80
			internal void _GetUsedTransform_b__1(VirtualMesh.UniqueSerializationData x) {} // 0x0000000187736C80-0x0000000187736E18
		}
	
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 46100
		{
			// Fields
			public Dictionary<int, Transform> replaceDict; // 0x10
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x0000000185609660-0x0000000185609730
	
			// Methods
			internal void _ReplaceTransform_b__0(RenderSetupData.UniqueSerializationData x) {} // 0x0000000185492010-0x0000000185492020
			internal void _ReplaceTransform_b__1(VirtualMesh.UniqueSerializationData x) {} // 0x0000000187736A24-0x0000000187736A3C
		}
	
		// Constructors
		public UniquePreBuildData() {} // 0x0000000187736A6C-0x0000000187736A84
	
		// Methods
		public ResultCode DataValidate() => default; // 0x0000000187736A3C-0x0000000187736A54
		public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000185492010-0x0000000185492020
		public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x0000000187736A54-0x0000000187736A6C
	}

	[Serializable]
	public class ReductionSettings : IDataValidate // TypeDefIndex: 46102
	{
		// Fields
		public float simpleDistance; // 0x10
		public float shapeDistance; // 0x14
	
		// Properties
		public bool IsEnabled { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Constructors
		public ReductionSettings() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public float GetMaxConnectionDistance() => default; // 0x000000018772F1A4-0x000000018772F228
		public ReductionSettings Clone() => default; // 0x000000018772F028-0x000000018772F0B4
		public void DataValidate() {} // 0x000000018772F0B4-0x000000018772F13C
		public override int GetHashCode() => default; // 0x000000018772F13C-0x000000018772F1A4
		public override string ToString() => default; // 0x000000018772F228-0x000000018772F3D4
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000185FB0F10-0x0000000185FB0F20
		public string __iFixBaseProxy_ToString() => default; // 0x000000018765AF34-0x000000018765AF3C
	}

	public class ReductionWorkData : IDisposable // TypeDefIndex: 46103
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
		public ReductionWorkData(VirtualMesh vmesh) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public void Dispose() {} // 0x000000018772F3D4-0x000000018772F768
	}

	public class SameDistanceReduction : IDisposable // TypeDefIndex: 46110
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
		public ResultCode Result { get => default; } // 0x0000000187740BB4-0x00000001877411B4 
	
		// Nested types
		private struct InitGridJob : IJob // TypeDefIndex: 46104
		{
			// Fields
			public int vcnt; // 0x00
			public float gridSize; // 0x04
			public NativeArray<float3> localPositions; // 0x08
			public NativeArray<int> joinIndices; // 0x18
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x28
	
			// Methods
			public void Execute() {} // 0x000000018774662C-0x0000000187746674
		}
	
		private struct SearchJoinJob : IJob // TypeDefIndex: 46105
		{
			// Fields
			public int vcnt; // 0x00
			public float gridSize; // 0x04
			public float radius; // 0x08
			public NativeArray<float3> localPositions; // 0x10
			public NativeArray<int> joinIndices; // 0x20
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x30
			public NativeParallelMultiHashMap<ushort, ushort> joinPairMap; // 0x40
	
			// Methods
			public void Execute() {} // 0x0000000187746674-0x0000000187746744
		}
	
		private struct JoinJob2 : IJob // TypeDefIndex: 46106
		{
			// Fields
			public int vertexCount; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> joinPairMap; // 0x08
			public NativeArray<int> joinIndices; // 0x18
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x28
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x38
			public NativeArray<VertexAttribute> attributes; // 0x48
			public NativeReference<int> result; // 0x58
			public NativeList<ushort> tempList; // 0x68
	
			// Methods
			public void Execute() {} // 0x0000000187745B04-0x0000000187745BF8
		}
	
		private struct UpdateJoinIndexJob : IJobParallelFor // TypeDefIndex: 46107
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001813B8590-0x00000001813B85A0
		}
	
		private struct UpdateLinkIndexJob : IJobParallelFor // TypeDefIndex: 46108
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x10
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000187745BF8-0x0000000187746404
		}
	
		private struct FinalMergeVertexJob : IJobParallelFor // TypeDefIndex: 46109
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000187746404-0x0000000187746510
		}
	
		// Constructors
		public SameDistanceReduction() {} // 0x0000000187746510-0x000000018774662C
		public SameDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float mergeLength) {} // 0x000000018773FBF8-0x000000018773FCE0
	
		// Methods
		public virtual void Dispose() {} // 0x00000001877470CC-0x0000000187747530
		public ResultCode Reduction() => default; // 0x00000001877495D4-0x000000018774965C
		private void UpdateJoinAndLink() {} // 0x00000001877498AC-0x0000000187749C6C
		private void UpdateReductionResultJob() {} // 0x000000018773FB04-0x000000018773FBF8
	}

	public class ShapeDistanceReduction : StepReductionBase // TypeDefIndex: 46112
	{
		// Nested types
		private struct SearchJoinEdgeJob : IJob // TypeDefIndex: 46111
		{
			// Fields
			public int vcnt; // 0x00
			public float radius; // 0x04
			public bool dontMakeLine; // 0x08
			public NativeArray<float3> localPositions; // 0x10
			public NativeArray<int> joinIndices; // 0x20
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x30
			public NativeList<StepReductionBase.JoinEdge> joinEdgeList; // 0x40
	
			// Methods
			public void Execute() {} // 0x00000001877476EC-0x00000001877477BC
		}
	
		// Constructors
		public ShapeDistanceReduction() {} // Dummy constructor
		public ShapeDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment) {} // 0x0000000187747634-0x0000000187747684
	
		// Methods
		public override void Dispose() {} // 0x0000000187747684-0x00000001877476D4
		protected override void StepInitialize() {} // 0x0000000187747530-0x0000000187747634
		protected override void CustomReductionStep() {} // 0x00000001877476DC-0x00000001877476E4
		public void __iFixBaseProxy_Dispose() {} // 0x00000001877476E4-0x00000001877476EC
		public void __iFixBaseProxy_StepInitialize() {} // 0x00000001877476D4-0x00000001877476DC
		public void __iFixBaseProxy_CustomReductionStep() {} // 0x0000000187746744-0x0000000187746B3C
	}

	public class SimpleDistanceReduction : StepReductionBase // TypeDefIndex: 46115
	{
		// Fields
		private GridMap<int> gridMap; // 0x90
	
		// Nested types
		private struct InitGridJob : IJob // TypeDefIndex: 46113
		{
			// Fields
			public int vcnt; // 0x00
			public float gridSize; // 0x04
			public NativeArray<float3> localPositions; // 0x08
			public NativeArray<int> joinIndices; // 0x18
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x28
	
			// Methods
			public void Execute() {} // 0x0000000187747B38-0x0000000187747C08
		}
	
		private struct SearchJoinEdgeJob : IJob // TypeDefIndex: 46114
		{
			// Fields
			public int vcnt; // 0x00
			public float gridSize; // 0x04
			public float radius; // 0x08
			public NativeArray<float3> localPositions; // 0x10
			public NativeArray<int> joinIndices; // 0x20
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x30
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x40
			public NativeList<StepReductionBase.JoinEdge> joinEdgeList; // 0x50
	
			// Methods
			public void Execute() {} // 0x00000001877479E0-0x0000000187747A64
		}
	
		// Constructors
		public SimpleDistanceReduction() {} // Dummy constructor
		public SimpleDistanceReduction(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment) {} // 0x0000000187747A64-0x0000000187747B38
	
		// Methods
		public override void Dispose() {} // 0x00000001877477BC-0x00000001877479E0
		protected override void StepInitialize() {} // 0x00000001877476DC-0x00000001877476E4
		protected override void CustomReductionStep() {} // 0x00000001877476E4-0x00000001877476EC
		public void __iFixBaseProxy_Dispose() {} // 0x00000001877476D4-0x00000001877476DC
		public void __iFixBaseProxy_StepInitialize() {} // 0x000000018773FCE0-0x000000018773FDC8
		public void __iFixBaseProxy_CustomReductionStep() {} // 0x0000000187746B3C-0x00000001877470CC
	}

	public abstract class StepReductionBase : IDisposable // TypeDefIndex: 46122
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
		public ResultCode Result { get; } // 0x00000001877485C8-0x000000018774860C 
	
		// Nested types
		public struct JoinEdge : IComparable<JoinEdge> // TypeDefIndex: 46116
		{
			// Fields
			public int2 vertexPair; // 0x00
			public float cost; // 0x08
	
			// Methods
			public bool Contains(in int2 pair) => default; // 0x00000001877493C4-0x000000018774940C
			public int CompareTo(JoinEdge other) => default; // 0x00000001877492C0-0x00000001877493C4
		}
	
		private struct DeterminJoinEdgeJob : IJob // TypeDefIndex: 46117
		{
			// Fields
			public int stepIndex; // 0x00
			public float mergeLength; // 0x04
			public NativeList<JoinEdge> joinEdgeList; // 0x08
			public NativeParallelHashSet<int> completeVertexSet; // 0x18
			public NativeList<int2> removePairList; // 0x28
			public NativeArray<int> resultArray; // 0x38
	
			// Methods
			public void Execute() {} // 0x00000001877486FC-0x0000000187748824
		}
	
		private struct JoinPairJob : IJob // TypeDefIndex: 46118
		{
			// Fields
			public float joinPositionAdjustment; // 0x00
			public NativeList<int2> removePairList; // 0x08
			public NativeArray<float3> localPositions; // 0x18
			public NativeArray<float3> localNormals; // 0x28
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x38
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x48
			public NativeArray<VertexAttribute> attributes; // 0x58
			public NativeArray<int> joinIndices; // 0x68
	
			// Methods
			public void Execute() {} // 0x00000001813B8590-0x00000001813B85A0
		}
	
		private struct UpdateJoinIndexJob : IJobParallelFor // TypeDefIndex: 46119
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000187748ABC-0x0000000187748CE8
		}
	
		private struct UpdateLinkIndexJob : IJobParallelFor // TypeDefIndex: 46120
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x10
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000187748824-0x0000000187748880
		}
	
		private struct FinalMergeVertexJob : IJobParallelFor // TypeDefIndex: 46121
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000187748880-0x00000001877488E4
		}
	
		// Constructors
		public StepReductionBase() {} // 0x00000001877488E4-0x0000000187748970
		public StepReductionBase(string name, VirtualMesh mesh, ReductionWorkData workingData, float startMergeLength, float endMergeLength, int maxStep, bool dontMakeLine, float joinPositionAdjustment) {} // 0x0000000187748A54-0x0000000187748ABC
	
		// Methods
		public virtual void Dispose() {} // 0x0000000187748F28-0x0000000187749098
		public ResultCode Reduction() => default; // 0x00000001877489E0-0x0000000187748A54
		private void InitStep() {} // 0x0000000187748970-0x00000001877489E0
		private bool IsEndStep() => default; // 0x0000000187748EA8-0x0000000187748F28
		private void NextStep() {} // 0x000000018774860C-0x00000001877486FC
		private void ReductionStep() {} // 0x0000000187748CE8-0x0000000187748EA8
		protected virtual void StepInitialize() {} // 0x0000000187749098-0x00000001877491A4
		protected virtual void CustomReductionStep() {} // 0x00000001877491A4-0x00000001877492C0
		private void PreReductionStep() {} // 0x0000000187747C08-0x00000001877480EC
		private void PostReductionStep() {} // 0x00000001877480EC-0x00000001877485C8
		private void SortJoinEdge() {} // 0x0000000187740B3C-0x0000000187740BB4
		private void DetermineJoinEdge() {} // 0x0000000187740AAC-0x0000000187740B3C
		private void RunJoinEdge() {} // 0x000000018773F834-0x000000018773FA10
		private void UpdateJoinAndLink() {} // 0x00000001877411B4-0x0000000187741884
		private void UpdateReductionResultJob() {} // 0x000000018774954C-0x00000001877495D4
		protected static bool CheckJoin2(in NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap, int vindex, int tvindex, bool dontMakeLine) => default; // 0x000000018774965C-0x00000001877498AC
		protected static bool CheckJoin(in NativeArray<FixedList128Bytes<ushort>> vertexToVertexArray, int vindex, int tvindex, in FixedList128Bytes<ushort> vlist, in FixedList128Bytes<ushort> tvlist, bool dontMakeLine) => default; // 0x000000018773FA10-0x000000018773FB04
	}

	[Serializable]
	public class ClothDebugSettings // TypeDefIndex: 46124
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
		public enum DebugAxis // TypeDefIndex: 46123
		{
			None = 0,
			Normal = 1,
			All = 2
		}
	
		// Constructors
		public ClothDebugSettings() {} // 0x0000000185FB12E0-0x0000000185FB12F0
	
		// Methods
		public bool CheckParticleDrawing(int index) => default; // 0x000000018773DE20-0x000000018773DE78
		public bool CheckTriangleDrawing(int index) => default; // 0x000000018773DEC4-0x000000018773DF1C
		public bool CheckRadiusDrawing() => default; // 0x000000018773DE78-0x000000018773DEC4
		public float GetPointSize() => default; // 0x000000018773E018-0x000000018773E06C
		public float GetLineSize() => default; // 0x000000018773DFC4-0x000000018773E018
		public float GetInertiaCenterRadius() => default; // 0x000000018773DF70-0x000000018773DFC4
		public float GetCustomSkinningRadius() => default; // 0x000000018773DF1C-0x000000018773DF70
		public bool IsReferOldPos() => default; // 0x000000018773E06C-0x000000018773E0B8
	}

	public class DataUtility // TypeDefIndex: 46125
	{
		// Constructors
		public DataUtility() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static int2 PackInt2(int d0, int d1) => default; // 0x000000018773F55C-0x000000018773F578
		public static int2 PackInt2(in int2 d) => default; // 0x000000018773F550-0x000000018773F55C
		public static int3 PackInt3(int d0, int d1, int d2) => default; // 0x000000018773F5FC-0x000000018773F6D0
		public static int3 PackInt3(in int3 d) => default; // 0x000000018773F578-0x000000018773F5FC
		public static int4 PackInt4(int d0, int d1, int d2, int d3) => default; // 0x000000018773F760-0x000000018773F834
		public static int4 PackInt4(int4 d) => default; // 0x000000018773F6D0-0x000000018773F760
		public static uint Pack32(int hi, int low) => default; // 0x0000000185FB1310-0x0000000185FB1320
		public static uint Pack32Sort(int a, int b) => default; // 0x000000018773F538-0x000000018773F550
		public static int Unpack32Hi(uint pack) => default; // 0x0000000185FB13F0-0x0000000185FB1400
		public static int Unpack32Low(uint pack) => default; // 0x0000000185FB1400-0x0000000185FB1410
		public static uint Pack12_20(int hi, int low) => default; // 0x0000000185FB1300-0x0000000185FB1310
		public static int Unpack12_20Hi(uint pack) => default; // 0x0000000185FB13B0-0x0000000185FB13C0
		public static int Unpack12_20Low(uint pack) => default; // 0x0000000185FB13C0-0x0000000185FB13D0
		public static void Unpack12_20(uint pack, out int hi, out int low) {
			hi = default;
			low = default;
		} // 0x0000000185FB13D0-0x0000000185FB13F0
		public static ulong Pack64(int x, int y, int z, int w) => default; // 0x0000000185FB1370-0x0000000185FB13A0
		public static ulong Pack64(in int4 a) => default; // 0x0000000185FB1320-0x0000000185FB1350
		public static int4 Unpack64(in ulong pack) => default; // 0x0000000185FB1450-0x0000000185FB1480
		public static int Unpack64X(in ulong pack) => default; // 0x0000000185FB1430-0x0000000185FB1440
		public static int Unpack64Y(in ulong pack) => default; // 0x0000000185FB1440-0x0000000185FB1450
		public static int Unpack64Z(in ulong pack) => default; // 0x0000000182FA7E50-0x0000000182FA7E60
		public static int Unpack64W(in ulong pack) => default; // 0x0000000182FA7E40-0x0000000182FA7E50
		public static uint Pack32(int x, int y, int z, int w) => default; // 0x0000000185FB1350-0x0000000185FB1370
		public static ulong Pack32(in int4 a) => default; // 0x0000000185FB1320-0x0000000185FB1350
		public static int4 Unpack32(in uint pack) => default; // 0x0000000185FB1410-0x0000000185FB1430
		public static int RemainingData(in int3 data, in int2 use) => default; // 0x0000000187668A1C-0x0000000187668A44
		public static float4x4 ConvertAnimationCurve(AnimationCurve curve) => default; // 0x00000001840CC140-0x00000001840CC2A0
		public static float EvaluateCurve(in float4x4 curve, float time) => default; // 0x00000001876497C0-0x00000001876498CC
		public static ColliderManager.ColliderType GetColliderType(in ExBitFlag8 flag) => default; // 0x0000000185FB12F0-0x0000000185FB1300
		public static ExBitFlag8 SetColliderType(ExBitFlag8 flag, ColliderManager.ColliderType ctype) => default; // 0x0000000185FB13A0-0x0000000185FB13B0
		public static void ArrayCopy<T>(T[] src, ref ref T[] dst) {}
	}

	public class MultiDataBuilder<T> : IDisposable // TypeDefIndex: 46126
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

	public class GridMap<T> : IDisposable // TypeDefIndex: 46128
		where T : struct, IEquatable<T>
	{
		// Fields
		private NativeParallelMultiHashMap<int3, T> gridMap;
	
		// Properties
		public int DataCount { get => default; }
	
		// Nested types
		public struct GridEnumerator : IEnumerator<int3> // TypeDefIndex: 46127
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
		public GridMap(int capacity = 0 /* Metadata: 0x0205EA07 */) {}
	
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

	public static class ClothJobUtility // TypeDefIndex: 46145
	{
		// Nested types
		private struct FillJob<T> : IJobParallelFor, ICrossFrameParallelForJob // TypeDefIndex: 46129
			where T : struct
		{
			// Fields
			public T value;
			public NativeArray<T> array;
			public int _indexCount;
	
			// Methods
			public void Execute(int index) {}
			public void SetIndexCount(int indexCount) {} // 0x000000018773EA20-0x000000018773EB0C
			public void Execute() {} // 0x000000018563AB20-0x000000018563ABD0
		}
	
		private struct FillJob2<T> : IJobParallelFor, ICrossFrameParallelForJob // TypeDefIndex: 46130
			where T : struct
		{
			// Fields
			public T value;
			public int startIndex;
			public NativeArray<T> array;
			public int _indexCount;
	
			// Methods
			public void Execute(int index) {}
			public void SetIndexCount(int indexCount) {} // 0x000000018773EE54-0x000000018773EF90
			public void Execute() {} // 0x000000018773EBF8-0x000000018773ED1C
		}
	
		private struct FillRefJob<T> : IJob // TypeDefIndex: 46131
			where T : struct
		{
			// Fields
			public T value;
			public NativeReference<T> reference;
	
			// Methods
			public void Execute() {} // 0x000000018773EF90-0x000000018773F094
		}
	
		private struct SerialNumberJob : IJobParallelFor // TypeDefIndex: 46132
		{
			// Fields
			public NativeArray<int> array; // 0x00
	
			// Methods
			public void Execute(int index) {} // 0x0000000184545BB0-0x0000000184545C20
		}
	
		private struct ConvertHashSetToListJob<T> : IJob // TypeDefIndex: 46133
			where T : struct, IEquatable<T>
		{
			// Fields
			public NativeParallelHashSet<T> hashSet;
			public NativeList<T> list;
	
			// Methods
			public void Execute() {} // 0x000000018773E910-0x000000018773EA20
		}
	
		private struct ConvertHashSetKeyToListJob<T> : IJob // TypeDefIndex: 46134
			where T : struct, IEquatable<T>
		{
			// Fields
			public NativeParallelHashSet<T> hashSet;
			public NativeList<T> list;
	
			// Methods
			public void Execute() {} // 0x000000018773E6F0-0x000000018773E800
		}
	
		private struct CalcAABBJob : IJob // TypeDefIndex: 46135
		{
			// Fields
			public int length; // 0x00
			public NativeArray<float3> positions; // 0x08
			public NativeReference<AABB> outAABB; // 0x18
	
			// Methods
			public void Execute() {} // 0x000000018773E800-0x000000018773E910
		}
	
		private struct CalcAABBDeferJob : IJob // TypeDefIndex: 46136
		{
			// Fields
			public NativeList<float3> positions; // 0x00
			public NativeReference<AABB> outAABB; // 0x10
	
			// Methods
			public void Execute() {} // 0x000000018773E280-0x000000018773E3C0
		}
	
		private struct CalcUVJob : IJobParallelFor // TypeDefIndex: 46137
		{
			// Fields
			public NativeArray<float3> positions; // 0x00
			public NativeReference<AABB> aabb; // 0x10
			public NativeArray<float2> uvs; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x00000001840D96D0-0x00000001840D97A0
		}
	
		public struct AddIntDataCopyJob : IJobParallelFor // TypeDefIndex: 46138
		{
			// Fields
			public int dstOffset; // 0x00
			public int addData; // 0x04
			public NativeArray<int> srcData; // 0x08
			public NativeArray<int> dstData; // 0x18
	
			// Methods
			public void Execute(int index) {} // 0x000000018773E170-0x000000018773E280
		}
	
		public struct AddInt2DataCopyJob : IJobParallelFor // TypeDefIndex: 46139
		{
			// Fields
			public int dstOffset; // 0x00
			public int2 addData; // 0x04
			public NativeArray<int2> srcData; // 0x10
			public NativeArray<int2> dstData; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x000000018773E0B8-0x000000018773E170
		}
	
		public struct AddInt3DataCopyJob : IJobParallelFor // TypeDefIndex: 46140
		{
			// Fields
			public int dstOffset; // 0x00
			public int3 addData; // 0x04
			public NativeArray<int3> srcData; // 0x10
			public NativeArray<int3> dstData; // 0x20
	
			// Methods
			public void Execute(int index) {} // 0x000000018533AFB0-0x000000018533B190
		}
	
		public struct TransformPositionJob : IJobParallelFor // TypeDefIndex: 46141
		{
			// Fields
			public float4x4 toM; // 0x00
			public NativeArray<float3> positions; // 0x40
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018773E4C0-0x000000018773E618
		}
	
		public struct TransformPositionJob2 : IJobParallelFor // TypeDefIndex: 46142
		{
			// Fields
			public float4x4 toM; // 0x00
			public NativeArray<float3> srcPositions; // 0x40
			public NativeArray<float3> dstPositions; // 0x50
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018773E3C0-0x000000018773E4C0
		}
	
		private struct ConvertArrayToMapJob<TData> : IJob // TypeDefIndex: 46143
			where TData : struct
		{
			// Fields
			public NativeArray<uint> indexArray;
			public NativeArray<TData> dataArray;
			public NativeParallelMultiHashMap<int, TData> map;
	
			// Methods
			public void Execute() {} // 0x000000018773F288-0x000000018773F3CC
		}
	
		private struct ClearReferenceJob : IJob // TypeDefIndex: 46144
		{
			// Fields
			public NativeReference<int> reference; // 0x00
	
			// Methods
			public void Execute() {} // 0x000000018773F1A0-0x000000018773F288
		}
	
		// Methods
		public static JobHandle Fill(NativeArray<byte> array, int length, byte value, JobHandle dependsOn = default) => default; // 0x000000018773F3CC-0x000000018773F538
		public static void FillRun(NativeArray<int> array, int length, int value) {} // 0x000000018773F094-0x000000018773F1A0
		public static void FillRun(NativeArray<quaternion> array, int length, quaternion value) {} // 0x00000001855E5FC0-0x00000001855E60F0
		public static void FillRun(NativeArray<VirtualMeshBoneWeight> array, int length, VirtualMeshBoneWeight value) {} // 0x000000018773E618-0x000000018773E6F0
		public static JobHandle Fill(NativeArray<int> array, int startIndex, int length, int value, JobHandle dependsOn = default) => default;
		public static JobHandle Fill(NativeReference<int> reference, int value, JobHandle dependsOn = default) => default;
		public static JobHandle SerialNumber(NativeArray<int> array, int length, JobHandle dependsOn = default) => default;
		public static void SerialNumberRun(NativeArray<int> array, int length) {}
		public static JobHandle ConvertHashSetToNativeList(NativeParallelHashSet<int> hashSet, NativeList<int> list, JobHandle dependsOn = default) => default;
		public static JobHandle ConvertHashSetKeyToNativeList(NativeParallelHashSet<int2> hashSet, NativeList<int2> keyList, JobHandle dependsOn = default) => default;
		public static JobHandle ConvertHashSetKeyToNativeList(NativeParallelHashSet<int4> hashSet, NativeList<int4> keyList, JobHandle dependsOn = default) => default;
		public static JobHandle CalcAABB(NativeArray<float3> positions, int length, NativeReference<AABB> outAABB, JobHandle dependsOn = default) => default; // 0x00000001840DBDE0-0x00000001840DBE20
		public static void CalcAABBRun(NativeArray<float3> positions, int length, NativeReference<AABB> outAABB) {}
		public static JobHandle CalcAABB(NativeList<float3> positions, NativeReference<AABB> outAABB, JobHandle dependsOn = default) => default;
		public static void CalcAABBRun(NativeList<float3> positions, NativeReference<AABB> outAABB) {} // 0x000000018533A9C0-0x000000018533AA30
		private static AABB CalcAABBInternal(in NativeArray<float3> positions, int length) => default; // 0x000000018773DAC8-0x000000018773DBA4
		public static JobHandle CalcUVWithSphereMapping(NativeArray<float3> positions, int length, NativeReference<AABB> aabb, NativeArray<float2> outUVs, JobHandle dependsOn = default) => default; // 0x000000018773DBA4-0x000000018773DDB4
		public static void CalcUVWithSphereMappingRun(NativeArray<float3> positions, int length, NativeReference<AABB> aabb, NativeArray<float2> outUVs) {} // 0x000000018773A9BC-0x000000018773AA2C
		public static JobHandle TransformPosition(NativeArray<float3> positions, int length, in float4x4 toM, JobHandle dependsOn = default) => default; // 0x000000018773A88C-0x000000018773A904
		public static void TransformPositionRun(NativeArray<float3> positions, int length, in float4x4 toM) {} // 0x000000018773A904-0x000000018773A9BC
		public static JobHandle TransformPosition(NativeArray<float3> srcPositions, NativeArray<float3> dstPositions, int length, in float4x4 toM, JobHandle dependsOn = default) => default; // 0x00000001877494AC-0x000000018774954C
		public static void TransformPositionRun(NativeArray<float3> srcPositions, NativeArray<float3> dstPositions, int length, in float4x4 toM) {} // 0x000000018774940C-0x00000001877494AC
		public static NativeParallelMultiHashMap<int, ushort> ToNativeMultiHashMap(in NativeArray<uint> indexArray, in NativeArray<ushort> dataArray) => default;
		public static JobHandle ClearReference(NativeReference<int> reference, JobHandle jobHandle) => default; // 0x000000018773DDB4-0x000000018773DE20
	}

	public static class InterlockUtility // TypeDefIndex: 46172
	{
		// Fields
		private const int ToFixed = 1000000; // Metadata: 0x0205EA08
		private const float ToFloat = 1E-06f; // Metadata: 0x0205EA0C
	
		// Nested types
		private static class AggregateJobKernels // TypeDefIndex: 46150
		{
			// Nested types
			public unsafe delegate void AggregateKernel_00000578_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 46146; 0x0000000187740470-0x0000000187740504
	
			internal static class AggregateKernel_00000578_BurstDirectCall // TypeDefIndex: 46147
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateKernel_00000578_BurstDirectCall() {} // 0x0000000187655ED0-0x0000000187655F38
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000627e1) {} // 0x0000000187655BD8-0x0000000187655CF0
				private static IntPtr GetFunctionPointer() => default; // 0x0000000187655CF0-0x0000000187655D94
				public static void Constructor() {} // 0x0000000187655E04-0x0000000187655ED0
				public static void Initialize() {} // 0x0000000187655D94-0x0000000187655E04
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x0000000185FB14B0-0x0000000185FB14D0
			}
	
			public unsafe delegate void AggregateRangeKernel_00000579_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length); // TypeDefIndex: 46148; 0x0000000187740504-0x00000001877405D0
	
			internal static class AggregateRangeKernel_00000579_BurstDirectCall // TypeDefIndex: 46149
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateRangeKernel_00000579_BurstDirectCall() {} // 0x000000018568DE90-0x000000018568DEF0
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000627f6) {} // 0x000000018568DD10-0x000000018568DD70
				private static IntPtr GetFunctionPointer() => default; // 0x000000018568DD70-0x000000018568DDD0
				public static void Constructor() {} // 0x000000018568DDD0-0x000000018568DE30
				public static void Initialize() {} // 0x000000018568DE30-0x000000018568DE90
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length) {} // 0x000000018568DEF0-0x000000018568DF50
			}
	
			// Methods
			private static unsafe void AggregateKernel(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x000000018568DF50-0x000000018568DFB0
			internal static unsafe void AggregateRangeKernel(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length) {} // 0x000000018773B6C4-0x000000018773B740
			public static unsafe void AggregateKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x000000018773B7AC-0x000000018773B828
			public static unsafe void AggregateRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, int* countArray, int* sumArray, int length) {} // 0x00000001877389F0-0x0000000187738B30
		}
	
		private static class AggregateWithVelocityJobKernels // TypeDefIndex: 46155
		{
			// Nested types
			public unsafe delegate void AggregateWithVelocityKernel_0000057A_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // TypeDefIndex: 46151; 0x00000001876C4868-0x00000001876C493C
	
			internal static class AggregateWithVelocityKernel_0000057A_BurstDirectCall // TypeDefIndex: 46152
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityKernel_0000057A_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_0006282b) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x000000018773BAD4-0x000000018773BBD8
				public static void Constructor() {} // 0x000000018773BBD8-0x000000018773BC2C
				public static void Initialize() {} // 0x0000000185F48AC0-0x0000000185F48B50
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x0000000185F48AB0-0x0000000185F48AC0
			}
	
			public unsafe delegate void AggregateWithVelocityRangeKernel_0000057B_PostfixBurstDelegate(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length); // TypeDefIndex: 46153; 0x00000001876C4868-0x00000001876C493C
	
			internal static class AggregateWithVelocityRangeKernel_0000057B_BurstDirectCall // TypeDefIndex: 46154
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityRangeKernel_0000057B_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062846) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x000000018773BD98-0x000000018773BE9C
				public static void Constructor() {} // 0x000000018773BE9C-0x000000018773BEF0
				public static void Initialize() {} // 0x0000000185F48A20-0x0000000185F48AB0
				public static unsafe void Invoke(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length) {} // 0x0000000185F48A10-0x0000000185F48A20
			}
	
			// Methods
			private static unsafe void AggregateWithVelocityKernel(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x000000018773BEF0-0x000000018773BFCC
			internal static unsafe void AggregateWithVelocityRangeKernel(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length) {} // 0x000000018773CFCC-0x000000018773D068
			public static unsafe void AggregateWithVelocityKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x000000018773D068-0x000000018773D104
			public static unsafe void AggregateWithVelocityRangeKernel_BurstManaged(int* jobParticleIndexList, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int length) {} // 0x0000000187738B30-0x0000000187738D24
		}
	
		private static class AggregateJob2Kernels // TypeDefIndex: 46160
		{
			// Nested types
			public unsafe delegate void AggregateJob2Kernel_0000057C_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index); // TypeDefIndex: 46156; 0x000000018773C604-0x000000018773C6D8
	
			internal static class AggregateJob2Kernel_0000057C_BurstDirectCall // TypeDefIndex: 46157
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateJob2Kernel_0000057C_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062871) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x000000018773D470-0x000000018773D574
				public static void Constructor() {} // 0x000000018773D574-0x000000018773D5C8
				public static void Initialize() {} // 0x0000000185F48840-0x0000000185F488D0
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x0000000185F48830-0x0000000185F48840
			}
	
			public unsafe delegate void AggregateJob2RangeKernel_0000057D_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr); // TypeDefIndex: 46158; 0x000000018773C604-0x000000018773C6D8
	
			internal static class AggregateJob2RangeKernel_0000057D_BurstDirectCall // TypeDefIndex: 46159
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateJob2RangeKernel_0000057D_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_00062886) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x000000018773D79C-0x000000018773D8A0
				public static void Constructor() {} // 0x000000018773D8A0-0x000000018773D8F4
				public static void Initialize() {} // 0x0000000185F487A0-0x0000000185F48830
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr) {} // 0x0000000185F48790-0x0000000185F487A0
			}
	
			// Methods
			private static unsafe void AggregateJob2Kernel(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x000000018773D8F4-0x000000018773D9EC
			internal static unsafe void AggregateJob2RangeKernel(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr) {} // 0x000000018773AEE0-0x000000018773AF5C
			public static unsafe void AggregateJob2Kernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int index) {} // 0x000000018773AFC8-0x000000018773B048
			public static unsafe void AggregateJob2RangeKernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, int* countArray, int* sumArray, int* lengthPtr) {} // 0x00000001877389F0-0x0000000187738B30
		}
	
		private static class AggregateWithVelocityJob2Kernels // TypeDefIndex: 46165
		{
			// Nested types
			public unsafe delegate void AggregateWithVelocityJob2Kernel_0000057E_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index); // TypeDefIndex: 46161; 0x00000001876C4868-0x00000001876C493C
	
			internal static class AggregateWithVelocityJob2Kernel_0000057E_BurstDirectCall // TypeDefIndex: 46162
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityJob2Kernel_0000057E_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000628bb) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x000000018773AC1C-0x000000018773AD20
				public static void Constructor() {} // 0x000000018773AD20-0x000000018773AD74
				public static void Initialize() {} // 0x0000000185F48C00-0x0000000185F48C90
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x0000000185F48BF0-0x0000000185F48C00
			}
	
			public unsafe delegate void AggregateWithVelocityJob2RangeKernel_0000057F_PostfixBurstDelegate(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr); // TypeDefIndex: 46163; 0x000000018773B2CC-0x000000018773B3A0
	
			internal static class AggregateWithVelocityJob2RangeKernel_0000057F_BurstDirectCall // TypeDefIndex: 46164
			{
				// Fields
				private static IntPtr Pointer; // 0x00
				private static IntPtr DeferredCompilation; // 0x08
	
				// Constructors
				static AggregateWithVelocityJob2RangeKernel_0000057F_BurstDirectCall() {} // 0x0000000185492010-0x0000000185492020
	
				// Methods
				private static void GetFunctionPointerDiscard(ref IntPtr param_000628d6) {} // 0x00000001864BB614-0x00000001864BB734
				private static IntPtr GetFunctionPointer() => default; // 0x000000018773B048-0x000000018773B14C
				public static void Constructor() {} // 0x000000018773B14C-0x000000018773B1A0
				public static void Initialize() {} // 0x0000000185F48B60-0x0000000185F48BF0
				public static unsafe void Invoke(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr) {} // 0x0000000185F48B50-0x0000000185F48B60
			}
	
			// Methods
			private static unsafe void AggregateWithVelocityJob2Kernel(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x000000018773B1A0-0x000000018773B27C
			internal static unsafe void AggregateWithVelocityJob2RangeKernel(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr) {} // 0x000000018773C6D8-0x000000018773C774
			public static unsafe void AggregateWithVelocityJob2Kernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int index) {} // 0x000000018773C774-0x000000018773C810
			public static unsafe void AggregateWithVelocityJob2RangeKernel_BurstManaged(int* particleIndexArray, double3* nextPosArray, double3* velocityPosArray, float velocityAttenuation, int* countArray, int* sumArray, int* lengthPtr) {} // 0x0000000187738B30-0x0000000187738D24
		}
	
		private struct AggregateJob : IJobParallelForDefer, IUnsafeJob // TypeDefIndex: 46166
		{
			// Fields
			public NativeList<int> jobParticleIndexList; // 0x00
			public NativeArray<double3> nextPosArray; // 0x10
			public NativeArray<int> countArray; // 0x20
			public NativeArray<int> sumArray; // 0x30
	
			// Methods
			public void Execute(int index) {} // 0x0000000187738D24-0x0000000187738DC0
			public void UnsafeDo() {} // 0x000000018773C604-0x000000018773C6D8
		}
	
		private struct AggregateWithVelocityJob : IJobParallelForDefer, IUnsafeJob // TypeDefIndex: 46167
		{
			// Fields
			public NativeList<int> jobParticleIndexList; // 0x00
			public NativeArray<double3> nextPosArray; // 0x10
			public NativeArray<double3> velocityPosArray; // 0x20
			public float velocityAttenuation; // 0x30
			public NativeArray<int> countArray; // 0x38
			public NativeArray<int> sumArray; // 0x48
	
			// Methods
			public void Execute(int index) {} // 0x000000018771DA00-0x000000018771DA14
			public void UnsafeDo() {} // 0x000000018773C528-0x000000018773C604
		}
	
		private struct AggregateJob2 : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 46168
		{
			// Fields
			public NativeArray<int> particleIndexArray; // 0x00
			public NativeArray<double3> nextPosArray; // 0x10
			public NativeArray<int> countArray; // 0x20
			public NativeArray<int> sumArray; // 0x30
			public NativeReference<int> _indexCount; // 0x40
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x00000001864BB614-0x00000001864BB734
			public void Execute() {} // 0x000000018773C2D8-0x000000018773C3DC
			public void Execute(int index) {} // 0x000000018773C3DC-0x000000018773C430
			public void UnsafeDo() {} // 0x0000000185F48980-0x0000000185F48A10
		}
	
		private struct AggregateWithVelocityJob2 : IJobParallelForDefer, ICrossFrameParallelForDeferJob, IUnsafeJob // TypeDefIndex: 46169
		{
			// Fields
			public NativeArray<int> particleIndexArray; // 0x00
			public NativeArray<double3> nextPosArray; // 0x10
			public NativeArray<double3> velocityPosArray; // 0x20
			public float velocityAttenuation; // 0x30
			public NativeArray<int> countArray; // 0x38
			public NativeArray<int> sumArray; // 0x48
			public NativeReference<int> _indexCount; // 0x58
	
			// Methods
			public void SetIndexCount(NativeReference<int> indexCount) {} // 0x0000000185492010-0x0000000185492020
			public void Execute() {} // 0x0000000185F48970-0x0000000185F48980
			public void Execute(int index) {} // 0x000000018773C430-0x000000018773C528
			public void UnsafeDo() {} // 0x000000018773CB28-0x000000018773CBFC
		}
	
		private struct AggregateWithVelocityCrossFrameJob2 : IJob // TypeDefIndex: 46170
		{
			// Fields
			public NativeReference<int> indexCount; // 0x00
			public NativeArray<int> particleIndexArray; // 0x10
			public NativeArray<float3> nextPosArray; // 0x20
			public NativeArray<float3> velocityPosArray; // 0x30
			public float velocityAttenuation; // 0x40
			public NativeArray<int> countArray; // 0x48
			public NativeArray<int> sumArray; // 0x58
	
			// Methods
			public void Execute(int index) {} // 0x000000018771DA00-0x000000018771DA14
			public void Execute() {} // 0x000000018773CA64-0x000000018773CB28
		}
	
		private struct AggregateCrossFrameJob2 : IJob // TypeDefIndex: 46171
		{
			// Fields
			public NativeReference<int> indexCount; // 0x00
			public NativeArray<int> particleIndexArray; // 0x10
			public NativeArray<float3> nextPosArray; // 0x20
			public NativeArray<int> countArray; // 0x30
			public NativeArray<int> sumArray; // 0x40
	
			// Methods
			public void Execute(int index) {} // 0x00000001864BB614-0x00000001864BB734
			public void Execute() {} // 0x000000018773C810-0x000000018773C914
		}
	
		// Methods
		internal static unsafe void AddFloat3(int index, float3 add, int* cntPt, int* sumPt) {} // 0x000000018773C914-0x000000018773C968
		internal static unsafe void AddFloat3(int index, float3 add, int* sumPt) {} // 0x0000000185F488E0-0x0000000185F48970
		internal static unsafe void Increment(int index, int* cntPt) {} // 0x0000000185492010-0x0000000185492020
		internal static unsafe void Max(int index, float value, int* pt) {} // 0x0000000185F488D0-0x0000000185F488E0
		internal static float3 ReadAverageFloat3(int index, in NativeArray<int> countArray, in NativeArray<int> sumArray) => default; // 0x000000018773C968-0x000000018773CA64
		internal static unsafe float3 ReadAverageFloat3(int index, int* countArray, int* sumArray) => default; // 0x000000018773B828-0x000000018773B9D8
		internal static float3 ReadFloat3(int index, in NativeArray<int> bufferArray) => default; // 0x000000018773B9D8-0x000000018773BAD4
		internal static unsafe float3 ReadFloat3(int index, int* bufferArray) => default; // 0x000000018773D104-0x000000018773D344
		internal static float ReadFloat(int index, in NativeArray<int> bufferArray) => default; // 0x000000018773D344-0x000000018773D470
		internal static unsafe float ReadFloat(int index, int* bufferArray) => default; // 0x000000018773B5B8-0x000000018773B620
		internal static JobHandle SolveAggregateBufferAndClear(in NativeList<int> particleList, float velocityAttenuation, JobHandle jobHandle) => default; // 0x000000018773B524-0x000000018773B5B8
		internal static JobHandle SolveAggregateBufferAndClear(in ExProcessingList<int> processingList, float velocityAttenuation, JobHandle jobHandle) => default; // 0x000000018773B3A0-0x000000018773B524
		internal static JobHandle SolveAggregateBufferAndClear(in NativeArray<int> particleArray, in NativeReference<int> counter, float velocityAttenuation, JobHandle jobHandle) => default; // 0x000000018773B620-0x000000018773B6C4
		public static void Initialize_AggregateJobKernels_AggregateKernel_00000578_BurstDirectCall() {} // 0x000000018773CEA4-0x000000018773CF0C
		public static void Initialize_AggregateJobKernels_AggregateRangeKernel_00000579_BurstDirectCall() {} // 0x000000018773CE10-0x000000018773CEA4
		public static void Initialize_AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_0000057A_BurstDirectCall() {} // 0x000000018773CBFC-0x000000018773CE10
		public static void Initialize_AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_0000057B_BurstDirectCall() {} // 0x000000018773CF0C-0x000000018773CFCC
		public static void Initialize_AggregateJob2Kernels_AggregateJob2Kernel_0000057C_BurstDirectCall() {} // 0x000000018773C10C-0x000000018773C2D8
		public static void Initialize_AggregateJob2Kernels_AggregateJob2RangeKernel_0000057D_BurstDirectCall() {} // 0x000000018773C078-0x000000018773C10C
		public static void Initialize_AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_0000057E_BurstDirectCall() {} // 0x000000018773AAC0-0x000000018773AC1C
		public static void Initialize_AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_0000057F_BurstDirectCall() {} // 0x000000018773AA2C-0x000000018773AAC0
	}

	[Serializable]
	public struct AABB : IEquatable<AABB> // TypeDefIndex: 46173
	{
		// Fields
		public double3 Min; // 0x00
		public double3 Max; // 0x18
	
		// Properties
		public double3 Extents { get => default; } // 0x000000018773A538-0x000000018773A598 
		public double3 HalfExtents { get => default; } // 0x000000018773A598-0x000000018773A670 
		public double3 Center { get => default; } // 0x000000018773A460-0x000000018773A538 
		public float MaxSideLength { get => default; } // 0x000000018773A6CC-0x000000018773A76C 
		public bool IsValid { get => default; } // 0x000000018773A670-0x000000018773A6CC 
		public float SurfaceArea { get => default; } // 0x000000018773A76C-0x000000018773A88C 
	
		// Constructors
		public AABB(in double3 min, in double3 max) : this() {
			Min = default;
			Max = default;
		} // 0x0000000185FB12B0-0x0000000185FB12E0
	
		// Methods
		public static AABB CreateFromCenterAndExtents(double3 center, double3 extents) => default; // 0x0000000187739F88-0x000000018773A020
		public static AABB CreateFromCenterAndHalfExtents(double3 center, double3 halfExtents) => default; // 0x000000018773A020-0x000000018773A0E4
		public bool Contains(in double3 point) => default; // 0x0000000187739EC0-0x0000000187739F88
		public bool Contains(in AABB aabb) => default; // 0x0000000187739DF8-0x0000000187739EC0
		public bool Overlaps(in AABB aabb) => default; // 0x000000018773A154-0x000000018773A21C
		public void Expand(double signedDistance) {} // 0x00000001876524C8-0x0000000187653C98
		public void Encapsulate(in AABB aabb) {} // 0x000000018765241C-0x00000001876524C8
		public void Encapsulate(in double3 point) {} // 0x00000001876B72B4-0x00000001876B7360
		public bool Equals(AABB other) => default; // 0x000000018773A0E4-0x000000018773A154
		public void Transform(in double4x4 toM) {} // 0x0000000187738834-0x00000001877389F0
		public override string ToString() => default; // 0x000000018773A21C-0x000000018773A400
		public string __iFixBaseProxy_ToString() => default; // 0x000000018773A400-0x000000018773A460
	}

	[Serializable]
	public struct IntAABB : IEquatable<IntAABB> // TypeDefIndex: 46174
	{
		// Fields
		public int3 Min; // 0x00
		public int3 Max; // 0x0C
	
		// Properties
		public int3 Extents { get => default; } // 0x0000000187740320-0x0000000187740378 
		public int3 Center { get => default; } // 0x0000000187740294-0x0000000187740320 
		public bool IsValid { get => default; } // 0x0000000187740378-0x00000001877403D8 
	
		// Constructors
		public IntAABB(int3 min, int3 max) : this() {
			Min = default;
			Max = default;
		} // 0x0000000185FB1480-0x0000000185FB14A0
	
		// Methods
		public bool Contains(int3 point) => default; // 0x000000018773FEE4-0x0000000187740000
		public bool Contains(IntAABB aabb) => default; // 0x000000018773FDC8-0x000000018773FEE4
		public bool Overlaps(IntAABB aabb) => default; // 0x00000001877400D8-0x00000001877401F8
		public void Expand(int signedDistance) {} // 0x0000000187740064-0x00000001877400D8
		public void Encapsulate(IntAABB aabb) {} // 0x00000001877399A4-0x0000000187739A8C
		public void Encapsulate(int3 point) {} // 0x0000000187739A8C-0x0000000187739D30
		public bool Equals(IntAABB other) => default; // 0x0000000187740000-0x0000000187740064
		public override string ToString() => default; // 0x00000001877401F8-0x0000000187740294
	}

	public static class MathExtensions // TypeDefIndex: 46175
	{
		// Methods
		public static float MC2GetValue(in float4x4 m, int index) => default; // 0x00000001877418AC-0x0000000187741904
		public static void MC2SetValue(ref float4x4 m, int index, float value) {} // 0x0000000187741904-0x000000018774192C
		public static float MC2EvaluateCurveClamp01(in float4x4 m, float time) => default; // 0x0000000187741884-0x00000001877418A4
		public static float MC2EvaluateCurve(in float4x4 m, float time) => default; // 0x00000001877418A4-0x00000001877418AC
	}

	public static class MathUtility // TypeDefIndex: 46176
	{
		// Methods
		public static void ComputeVirtualParentWithoutLocal(float3 fromPos, quaternion fromRot, float3 toPos, quaternion toRot, out float3 dPos, out quaternion dRot) {
			dPos = default;
			dRot = default;
		} // 0x000000018774248C-0x0000000187742628
		public static float Clamp1(float a) => default; // 0x00000001877419EC-0x0000000187741A04
		public static double Clamp1(double a) => default; // 0x00000001877419D4-0x00000001877419EC
		public static double3 Project(in double3 v, in double3 n) => default; // 0x0000000187656C4C-0x0000000187656CD4
		public static double3 ProjectOnPlane(in double3 v, in double3 n) => default; // 0x0000000187714BA4-0x0000000187714F58
		public static double3 AutoConvertToFloat(in Vector3 v) => default; // 0x0000000184B3C800-0x0000000184B3C830
		public static float3 AutoToFloat3(in double3 v) => default; // 0x0000000185FB14D0-0x0000000185FB1500
		public static float3 mul(quaternion q, float3 v) => default; // 0x0000000187745AB4-0x0000000187745B04
		public static double3 mul(quaternion q, double3 v) => default; // 0x00000001877458F0-0x0000000187745AB4
		public static float Angle(in float3 v1, in float3 v2) => default; // 0x0000000187668A90-0x0000000187668B60
		public static double Angle(in double3 v1, in double3 v2) => default; // 0x00000001876498CC-0x0000000187649A2C
		public static float3 ClampVector(float3 v, float minlength, float maxlength) => default; // 0x0000000187741EE0-0x0000000187741FB4
		public static float3 ClampVector(float3 v, float maxlength) => default; // 0x00000001876DA688-0x00000001876DA734
		public static double3 ClampVector(double3 v, double maxlength) => default; // 0x0000000187741FB4-0x0000000187742068
		public static double3 ClampDistance(double3 from, double3 to, double maxlength) => default; // 0x0000000187741E04-0x0000000187741EE0
		public static bool ClampAngle(in double3 dir, in double3 basedir, double maxAngle, out double3 outdir) {
			outdir = default;
			return default;
		} // 0x0000000187741A04-0x0000000187741D80
		public static quaternion FromToRotation(in double3 from, in double3 to, double t = 1 /* Metadata: 0x0205EA10 */) => default; // 0x0000000187742810-0x0000000187742B18
		public static quaternion FromToRotation(in quaternion from, in quaternion to) => default; // 0x00000001876DA734-0x00000001876DAA98
		public static float Angle(in quaternion a, in quaternion b) => default; // 0x00000001876DA604-0x00000001876DA688
		public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle) => default; // 0x0000000187741D80-0x0000000187741E04
		public static quaternion ToRotation(in float3 nor, in float3 tan) => default; // 0x000000018774474C-0x00000001877447A0
		public static void ToNormalTangent(in quaternion rot, out float3 nor, out float3 tan) {
			nor = default;
			tan = default;
		} // 0x00000001876DAE98-0x00000001876DB1F0
		public static float3 ToNormal(in quaternion rot) => default; // 0x00000001877446F4-0x000000018774474C
		public static float3 ToTangent(in quaternion rot) => default; // 0x00000001877447A0-0x00000001877447F8
		public static float3 ToBinormal(in quaternion rot) => default; // 0x00000001877446A0-0x00000001877446F4
		public static float3 Binormal(in float3 nor, in float3 tan) => default; // 0x000000018774192C-0x0000000187741984
		public static float3 AxisToEuler(in float3 axis) => default; // 0x0000000187714AD0-0x0000000187714BA4
		public static quaternion AxisQuaternion(float3 dir) => default; // 0x0000000187714A88-0x0000000187714AD0
		public static void ToAngleAxis(in quaternion q, out float angle, out float3 axis) {
			angle = default;
			axis = default;
		} // 0x00000001876DADCC-0x00000001876DAE98
		public static float ClosestPtPointSegmentRatio(in double3 c, in double3 a, in double3 b) => default; // 0x0000000187656108-0x0000000187656220
		public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b) => default; // 0x00000001877421B4-0x000000018774228C
		public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b) => default; // 0x000000018774228C-0x00000001877423EC
		public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b) => default; // 0x0000000187742068-0x00000001877421B4
		public static double ClosestPtSegmentSegment(in double3 p1, in double3 q1, in double3 p2, in double3 q2, out double s, out double t, out double3 c1, out double3 c2) {
			s = default;
			t = default;
			c1 = default;
			c2 = default;
			return default;
		} // 0x0000000187656558-0x0000000187656A5C
		public static void ClosestPtSegmentSegment2(in double3 p1, in double3 q1, in double3 p2, in double3 q2, out double s, out double t) {
			s = default;
			t = default;
		} // 0x0000000187656220-0x0000000187656558
		public static double3 ClosestPtPointTriangle(in double3 p, in double3 a, in double3 b, in double3 c, out double3 uvw) {
			uvw = default;
			return default;
		} // 0x00000001876B8E38-0x00000001876B9E38
		public static bool PointInTriangleUVW(float3 uvw) => default; // 0x0000000187744054-0x0000000187744078
		public static float3 TriangleCenter(in float3 p0, in float3 p1, in float3 p2) => default; // 0x000000018774531C-0x00000001877453D0
		public static float3 TriangleNormal(in double3 p0, in double3 p1, in double3 p2) => default; // 0x0000000187656CD4-0x0000000187657A98
		public static float TriangleArea(in float3 p0, in float3 p1, in float3 p2) => default; // 0x0000000187739D30-0x0000000187739DF8
		public static bool IsSafeTriangle(in float3 p0, in float3 p1, in float3 p2) => default; // 0x0000000187743F40-0x0000000187743F58
		public static float3 TriangleTangent(in float3 p0, in float3 p1, in float3 p2, in float2 uv0, in float2 uv1, in float2 uv2) => default; // 0x0000000187745688-0x00000001877458F0
		public static double3 TriangleTangent(in double3 p0, in double3 p1, in double3 p2, in float2 uv0, in float2 uv1, in float2 uv2) => default; // 0x00000001877453D0-0x0000000187745688
		public static float TriangleAngle(in float3 v0, in float3 v1, in float3 v2, in float3 v3) => default; // 0x00000001876AD7F8-0x00000001876AD940
		public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2) => default; // 0x0000000187742744-0x0000000187742810
		public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c) => default; // 0x0000000187742628-0x0000000187742744
		public static int2 GetRestTriangleVertex(int3 tri1, int3 tri2, int2 edge) => default; // 0x0000000187742C3C-0x0000000187742D40
		public static int2 GetCommonEdgeFromTrianglePair(int3 tri1, int3 tri2) => default; // 0x0000000187742B18-0x0000000187742C3C
		public static int4 GetTrianglePairIndices(int3 tri1, int3 tri2) => default; // 0x0000000187742E94-0x0000000187742FB8
		public static int GetUnuseTriangleIndex(int3 tri, int2 edge) => default; // 0x0000000187742FB8-0x0000000187743058
		public static float GetTrianglePairAngle(float3 pos0, float3 pos1, float3 pos2, float3 pos3) => default; // 0x0000000187742D40-0x0000000187742E94
		public static int3 FlipTriangle(in int3 tri) => default; // 0x0000000185FB1530-0x0000000185FB1570
		public static void GetTriangleSphere(float3 pos0, float3 pos1, float3 pos2, out float3 sc, out float sr) {
			sc = default;
			sr = default;
		} // 0x00000001876AD1A0-0x00000001876AD32C
		public static float4x4 LocalToWorldMatrix(in float3 wpos, in quaternion wrot, in float3 wscl) => default; // 0x00000001876DAA98-0x00000001876DADCC
		public static double4x4 LocalToWorldMatrix(in double3 wpos, in quaternion wrot, in float3 wscl) => default; // 0x00000001876F2710-0x00000001876F27B0
		public static float4x4 WorldToLocalMatrix(in float3 wpos, in quaternion wrot, in float3 wscl) => default; // 0x00000001876DB1F0-0x00000001876DB330
		public static double4x4 WorldToLocalMatrix(in double3 wpos, in quaternion wrot, in float3 wscl) => default; // 0x00000001876DB330-0x00000001876DB430
		public static float3 TransformPoint(in float3 pos, in float3 wpos, in quaternion wrot, in float3 wscl) => default; // 0x0000000187744AA8-0x0000000187744BF8
		public static double3 TransformPoint(in double3 pos, in double3 wpos, in quaternion wrot, in float3 wscl) => default; // 0x00000001877449AC-0x0000000187744AA8
		public static float3 TransformPoint(in float3 pos, in float4x4 m) => default; // 0x00000001876AD580-0x00000001876AD5F4
		public static float3 TransformPoint(in double3 pos, in float4x4 m) => default; // 0x0000000187744928-0x00000001877449AC
		public static double3 TransformPoint(in float3 pos, in double4x4 m) => default; // 0x0000000187744CA4-0x0000000187744D54
		public static double3 TransformPoint(in double3 pos, in double4x4 m) => default; // 0x0000000187744BF8-0x0000000187744CA4
		public static float3 TransformVector(in float3 vec, in float4x4 m) => default; // 0x00000001876AD748-0x00000001876AD7F8
		public static double3 TransformVector(in double3 vec, in float4x4 m) => default; // 0x000000018774504C-0x0000000187745160
		public static double3 TransformVector(in float3 vec, in double4x4 m) => default; // 0x0000000187745230-0x000000018774531C
		public static double3 TransformVector(in double3 vec, in double4x4 m) => default; // 0x0000000187745160-0x0000000187745230
		public static float3 TransformDirection(in float3 dir, in float4x4 m) => default; // 0x00000001876AD4A8-0x00000001876AD580
		public static quaternion TransformRotation(in quaternion rot, in double4x4 m, in float3 normalTangentFlip) => default; // 0x0000000187744D54-0x000000018774504C
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) => default; // 0x0000000187744624-0x00000001877446A0
		public static double4x4 TRS(double3 translation, quaternion rotation, float3 scale) => default; // 0x0000000187744400-0x0000000187744624
		public static float TransformDistance(in float dist, in float4x4 localToWorldMatrix) => default; // 0x00000001877447F8-0x000000018774487C
		public static void TransformPositionNormalTangent(in float3 tpos, in quaternion trot, in float3 tscl, ref float3 pos, ref float3 nor, ref float3 tan) {} // 0x00000001876AD5F4-0x00000001876AD748
		public static float TransformLength(float length, in float4x4 matrix) => default; // 0x000000018774487C-0x0000000187744928
		public static float3 InverseTransformPoint(in float3 pos, in float4x4 worldToLocalMatrix) => default; // 0x00000001876AD580-0x00000001876AD5F4
		public static double3 InverseTransformPoint(in double3 pos, in double4x4 worldToLocalMatrix) => default; // 0x0000000187743A38-0x0000000187743ADC
		public static float3 InverseTransformPoint(in float3 pos, in float3 wpos, in quaternion wrot, in float3 wscl) => default; // 0x0000000187743ADC-0x0000000187743C5C
		public static double3 InverseTransformPoint(in double3 pos, in double3 wpos, in quaternion wrot, in float3 wscl) => default; // 0x0000000187743C5C-0x0000000187743DA8
		public static float3 InverseTransformVector(in float3 vec, in float4x4 worldToLocalMatrix) => default; // 0x00000001876AD748-0x00000001876AD7F8
		public static float3 InverseTransformVector(in float3 vec, in quaternion rot) => default; // 0x0000000187743DA8-0x0000000187743E10
		public static float3 InverseTransformDirection(in float3 dir, in float4x4 worldToLocalMatrix) => default; // 0x0000000187743960-0x0000000187743A38
		public static float4x4 Transform(in float4x4 fromLocalToWorldMatrix, in float4x4 toWorldToLocalMatrix) => default; // 0x0000000187649A2C-0x0000000187649CFC
		public static bool CompareMatrix(in float4x4 m1, in float4x4 m2) => default; // 0x0000000187668B60-0x0000000187668E00
		public static bool CompareTransform(in float3 pos1, in quaternion rot1, in float3 scl1, in float3 pos2, in quaternion rot2, in float3 scl2) => default; // 0x00000001877423EC-0x000000018774248C
		public static bool CompareTransform(in double3 pos1, in quaternion rot1, in float3 scl1, in double3 pos2, in quaternion rot2, in float3 scl2) => default; // 0x00000001876F266C-0x00000001876F2710
		public static bool IntersectSegmentTriangle(in float3 p, in float3 q, float3 a, float3 b, float3 c, bool doubleSide, out float u, out float v, out float w, out float t) {
			u = default;
			v = default;
			w = default;
			t = default;
			return default;
		} // 0x0000000187743058-0x0000000187743578
		public static bool IntersectSegmentTriangle(in float3 p, in float3 q, float3 a, float3 b, float3 c) => default; // 0x0000000187743578-0x0000000187743960
		public static double IntersectPointPlaneDist(in double3 planePos, in double3 planeDir, in double3 pos, out double3 outPos) {
			outPos = default;
			return default;
		} // 0x0000000187656A5C-0x0000000187656C4C
		public static bool IntersectRaySphere(in float3 p, in float3 d, in float3 sc, in float sr, ref float t, ref float3 q) => default; // 0x00000001876AD32C-0x00000001876AD4A8
		public static float SqDistPointSegment(Vector3 a, Vector3 b, Vector3 c) => default; // 0x00000001877441F0-0x0000000187744400
		public static bool IsNaN(float3 v) => default; // 0x0000000187743E7C-0x0000000187743EC4
		public static bool IsNaN(double3 v) => default; // 0x0000000187743E10-0x0000000187743E58
		public static bool IsNaN(float4 v) => default; // 0x0000000187743E58-0x0000000187743E7C
		public static bool IsNaN(quaternion q) => default; // 0x0000000187743EC4-0x0000000187743F40
		public static float3 Lerp(float3 x, float3 y, float s) => default; // 0x0000000187743F58-0x0000000187743FD0
		public static double3 Lerp(double3 x, double3 y, double s) => default; // 0x0000000187743FD0-0x0000000187744054
		public static double3 ShiftPosition(in double3 oldPos, in double3 oldPivotPosition, in double3 shiftVector, in quaternion shiftRotation) => default; // 0x0000000187744078-0x00000001877441F0
		public static float CalcMass(float depth) => default; // 0x0000000185FB1500-0x0000000185FB1530
		public static float CalcInverseMass(float friction) => default; // 0x0000000187741984-0x00000001877419A0
		public static float CalcInverseMass(float friction, float depth) => default; // 0x00000001877419A0-0x00000001877419D4
		public static float CalcInverseMass(float friction, float depth, bool fix, float fixMass) => default; // 0x0000000187655F38-0x0000000187656108
		public static float CalcSelfCollisionInverseMass(float friction, bool fix, float clothMass) => default; // 0x00000001876B8E00-0x00000001876B8E38
	}

	public class MinimumData<T1, T2> // TypeDefIndex: 46177
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

	public struct FTransform // TypeDefIndex: 46178
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 scale; // 0x1C
	
		// Methods
		public static FTransform Default() => default; // 0x000000018766A46C-0x000000018766A53C
	}

	public static class MeshUtility // TypeDefIndex: 46179
	{
		// Methods
		public static Mesh GetSharedMesh(Renderer ren) => default; // 0x000000018766A74C-0x000000018766A8B0
		public static bool SetMesh(Renderer ren, Mesh mesh, Transform[] skinBones = null) => default; // 0x000000018766A994-0x000000018766AB10
		public static int GetTransformCount(Renderer ren) => default; // 0x000000018766A8B0-0x000000018766A994
	}

	public static class Develop // TypeDefIndex: 46180
	{
		// Methods
		public static void Log(in object mes) {} // 0x000000018766925C-0x00000001876692F8
		public static void LogWarning(in object mes) {} // 0x00000001876691C0-0x000000018766925C
		public static void LogError(in object mes) {} // 0x0000000187669128-0x00000001876691C0
		public static void DebugLog(in object mes) {} // 0x000000018766908C-0x0000000187669128
		public static void DebugLogWarning(in object mes) {} // 0x0000000187668FF0-0x000000018766908C
		public static void DebugLogError(in object mes) {} // 0x0000000187668F54-0x0000000187668FF0
		public static void Assert(bool condition) {} // 0x0000000187668F10-0x0000000187668F54
	}

	public class StaticStringBuilder // TypeDefIndex: 46181
	{
		// Fields
		private static StringBuilder stringBuilder; // 0x00
	
		// Properties
		public static StringBuilder Instance { get => default; } // 0x000000018766B7C8-0x000000018766B818 
	
		// Constructors
		public StaticStringBuilder() {} // 0x0000000185492010-0x0000000185492020
		static StaticStringBuilder() {} // 0x000000018766B744-0x000000018766B7C8
	
		// Methods
		public static void Clear() {} // 0x000000018766B634-0x000000018766B6BC
		public static StringBuilder Append(object[] args) => default; // 0x000000018766B564-0x000000018766B634
		public static StringBuilder AppendLine(object[] args) => default; // 0x000000018766B34C-0x000000018766B454
		public static StringBuilder AppendLine() => default; // 0x000000018766B2A4-0x000000018766B34C
		public static string AppendToString(object[] args) => default; // 0x000000018766B454-0x000000018766B564
		public static new string ToString() => default; // 0x000000018766B6BC-0x000000018766B744
	}

	public struct DataChunk // TypeDefIndex: 46182
	{
		// Fields
		public int startIndex; // 0x00
		public int dataLength; // 0x04
	
		// Properties
		public bool IsValid { get => default; } // 0x0000000184091260-0x0000000184091270 
		public static DataChunk Empty { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	
		// Constructors
		public DataChunk(int sindex, int length) : this() {
			startIndex = default;
			dataLength = default;
		} // 0x000000018357CB90-0x000000018357CBA0
		public DataChunk(int sindex) : this() {
			startIndex = default;
			dataLength = default;
		} // 0x0000000185FB0F30-0x0000000185FB0F40
	
		// Methods
		public void Clear() {} // 0x0000000184D605E0-0x0000000184D60610
		public override string ToString() => default; // 0x0000000187668E00-0x0000000187668EC0
		public string __iFixBaseProxy_ToString() => default; // 0x0000000187668EC0-0x0000000187668F10
	}

	[Serializable]
	public struct ExBitFlag16 // TypeDefIndex: 46183
	{
		// Fields
		public ushort Value; // 0x00
	
		// Constructors
		public ExBitFlag16(ushort initialValue = 0 /* Metadata: 0x0205EA18 */) {
			Value = default;
		} // 0x0000000185FB0F40-0x0000000185FB0F50
	
		// Methods
		public void Clear() {} // 0x00000001876692F8-0x000000018766934C
		public void SetFlag(ushort flag, bool sw) {} // 0x0000000187669354-0x0000000187669370
		public bool IsSet(ushort flag) => default; // 0x000000018766934C-0x0000000187669354
	}

	[Serializable]
	public struct ExBitFlag8 // TypeDefIndex: 46184
	{
		// Fields
		public byte Value; // 0x00
	
		// Constructors
		public ExBitFlag8(byte initialValue = 0 /* Metadata: 0x0205EA1A */) {
			Value = default;
		} // 0x0000000185FB0F60-0x0000000185FB0F70
	
		// Methods
		public void Clear() {} // 0x0000000185FB0F50-0x0000000185FB0F60
		public void SetFlag(byte flag, bool sw) {} // 0x0000000187669378-0x000000018766938C
		public bool IsSet(byte flag) => default; // 0x0000000187669370-0x0000000187669378
	}

	public struct ExCostSortedList1 : IComparable<ExCostSortedList1> // TypeDefIndex: 46185
	{
		// Fields
		internal float cost; // 0x00
		internal int data; // 0x04
	
		// Properties
		public bool IsValid { get => default; } // 0x0000000187669558-0x0000000187669568 
		public int Count { get => default; } // 0x0000000187669548-0x0000000187669558 
		public float Cost { get => default; } // 0x0000000185FB0F90-0x0000000185FB0FA0 
		public int Data { get => default; } // 0x000000018357CBC0-0x000000018357CBD0 
	
		// Constructors
		public ExCostSortedList1(float invalidCost) : this() {
			cost = default;
			data = default;
		} // 0x0000000185FB0F80-0x0000000185FB0F90
		public ExCostSortedList1(float invalidCost, int initData) : this() {
			cost = default;
			data = default;
		} // 0x0000000185FB0F70-0x0000000185FB0F80
	
		// Methods
		public void Add(float cost, int item) {} // 0x000000018766938C-0x00000001876693A8
		public int CompareTo(ExCostSortedList1 other) => default; // 0x00000001876693A8-0x0000000187669428
		public override string ToString() => default; // 0x0000000187669428-0x00000001876694F8
		public string __iFixBaseProxy_ToString() => default; // 0x00000001876694F8-0x0000000187669548
	}

	public struct ExCostSortedList4 // TypeDefIndex: 46186
	{
		// Fields
		internal float4 costs; // 0x00
		internal int4 data; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x0000000187668A6C-0x0000000187668A90 
		public bool IsValid { get => default; } // 0x0000000187669558-0x0000000187669568 
		public float MinCost { get => default; } // 0x0000000185FB0F90-0x0000000185FB0FA0 
		public float MaxCost { get => default; } // 0x00000001876698B8-0x00000001876698D8 
	
		// Constructors
		public ExCostSortedList4(float invalidCost) : this() {
			costs = default;
			data = default;
		} // 0x0000000185FB0FA0-0x0000000185FB0FC0
	
		// Methods
		public bool Add(float cost, int item) => default; // 0x0000000187669568-0x000000018766964C
		public bool Contains(int item) => default; // 0x0000000187668A44-0x0000000187668A6C
		public int indexOf(int item) => default; // 0x00000001876698D8-0x0000000187669960
		public void RemoveItem(int item) {} // 0x000000018766964C-0x0000000187669700
		public override string ToString() => default; // 0x0000000187669700-0x0000000187669860
		public string __iFixBaseProxy_ToString() => default; // 0x0000000187669860-0x00000001876698B8
	}

	public class ExNativeArray<T> : IDisposable // TypeDefIndex: 46187
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
		public ExNativeArray(int emptyLength, bool create = false /* Metadata: 0x0205EA1B */) {}
		public ExNativeArray(int emptyLength, T fillData) {}
		public ExNativeArray(NativeArray<T> dataArray) {}
		public ExNativeArray(T[] dataArray) {}
	
		// Methods
		public void Dispose() {}
		public DataChunk AddRange(int dataLength) => default;
		public DataChunk AddRange(int dataLength, T fillData = default) => default;
		public DataChunk AddRange(T[] array) => default;
		public DataChunk AddRange(NativeArray<T> narray, int length = 0 /* Metadata: 0x0205EA1C */) => default;
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

	public class ExProcessingList<T> : IDisposable, IValid // TypeDefIndex: 46188
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

	public class ExSimpleNativeArray<T> : IDisposable // TypeDefIndex: 46190
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
		public class SerializationData // TypeDefIndex: 46189
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
		public ExSimpleNativeArray(int dataLength, bool areaOnly = false /* Metadata: 0x0205EA1D */) {}
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
		private void Expand(int dataLength, bool force = false /* Metadata: 0x0205EA1E */, bool copy = true /* Metadata: 0x0205EA1F */) {}
		public override string ToString() => default;
		public SerializationData Serialize() => default;
		public bool Deserialize(SerializationData data) => default;
	}

	public class ExTransformAccessArray : IDisposable // TypeDefIndex: 46191
	{
		// Fields
		private TransformAccessArray transformArray; // 0x10
		private int nativeLength; // 0x18
		private Queue<int> emptyStack; // 0x20
		private Dictionary<int, int> useIndexDict; // 0x28
		private Dictionary<int, int> indexDict; // 0x30
		private Dictionary<int, int> referenceDict; // 0x38
	
		// Properties
		public int Count { get => default; } // 0x000000018766A420-0x000000018766A460 
		public int Length { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public Transform this[int index] { get => default; } // 0x000000018766A460-0x000000018766A46C 
	
		// Constructors
		public ExTransformAccessArray() {} // Dummy constructor
		public ExTransformAccessArray(int capacity, int desiredJobCount = -1 /* Metadata: 0x0205EA20 */) {} // 0x000000018766A2B4-0x000000018766A420
	
		// Methods
		public void Dispose() {} // 0x0000000187669D98-0x0000000187669E74
		public TransformAccessArray GetTransformAccessArray() => default; // 0x000000018766A0B4-0x000000018766A104
		public int Add(Transform element) => default; // 0x0000000187669960-0x0000000187669B6C
		public void Remove(int index) {} // 0x000000018766A104-0x000000018766A2B4
		public bool Exist(int index) => default; // 0x0000000187669E74-0x0000000187669EFC
		public bool Exist(Transform element) => default; // 0x0000000187669EFC-0x0000000187669FC4
		public int GetIndex(Transform element) => default; // 0x0000000187669FC4-0x000000018766A0B4
		public void Clear() {} // 0x0000000187669B6C-0x0000000187669D98
	}

	public static class FixedList128BytesExtensions // TypeDefIndex: 46192
	{
		// Methods
		public static bool MC2IsCapacity<T>(ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(ref FixedList128Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(ref FixedList128Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class FixedList32BytesExtensions // TypeDefIndex: 46193
	{
		// Methods
		public static bool MC2IsCapacity<T>(ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(ref FixedList32Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(ref FixedList32Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class FixedList4096BytesExtensions // TypeDefIndex: 46194
	{
		// Methods
		public static bool MC2IsCapacity<T>(ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(ref FixedList4096Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(ref FixedList4096Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class FixedList512BytesExtensions // TypeDefIndex: 46195
	{
		// Methods
		public static bool MC2IsCapacity<T>(ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(ref FixedList512Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(ref FixedList512Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class FixedList64BytesExtensions // TypeDefIndex: 46196
	{
		// Methods
		public static bool MC2IsCapacity<T>(ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Set<T>(ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2SetLimit<T>(ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2RemoveItemAtSwapBack<T>(ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static void MC2Push<T>(ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Pop<T>(ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
		public static void MC2Enqueue<T>(ref FixedList64Bytes<T> fixedList, T item)
			where T : struct, IEquatable<T> {}
		public static T MC2Dequque<T>(ref FixedList64Bytes<T> fixedList)
			where T : struct, IEquatable<T> => default;
	}

	public static class NativeArrayExtensions // TypeDefIndex: 46197
	{
		// Methods
		public static void MC2DisposeSafe<T>(ref NativeArray<T> array)
			where T : struct {}
		public static void MC2Resize<T>(ref NativeArray<T> array, int size, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0205EA21 */, NativeArrayOptions options = NativeArrayOptions.ClearMemory /* Metadata: 0x0205EA22 */)
			where T : struct {}
		public static byte[] MC2ToRawBytes<T>(ref NativeArray<T> array)
			where T : struct => default;
		public static NativeArray<T> MC2FromRawBytes<T>(byte[] bytes, Unity.Collections.Allocator allocator = Unity.Collections.Allocator.Persistent /* Metadata: 0x0205EA23 */)
			where T : struct => default;
	}

	public static class NativeMultiHashMapExtensions // TypeDefIndex: 46199
	{
		// Nested types
		private struct SetParallelMultiHashMapJob<TKey, TValue> : IJob // TypeDefIndex: 46198
			where TKey : struct, IEquatable<TKey>
			where TValue : struct
		{
			// Fields
			public NativeParallelMultiHashMap<TKey, TValue> map;
			public NativeArray<TKey> keyArray;
			public NativeArray<TValue> valueArray;
	
			// Methods
			public void Execute() {}
		}
	
		// Methods
		public static bool MC2Contains<TKey, TValue>(ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> => default;
		public static void MC2UniqueAdd<TKey, TValue>(ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> {}
		public static bool MC2RemoveValue<TKey, TValue>(ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key, TValue value)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> => default;
		public static FixedList512Bytes<TValue> MC2ToFixedList512Bytes<TKey, TValue>(ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> => default;
		public static FixedList128Bytes<TValue> MC2ToFixedList128Bytes<TKey, TValue>(ref NativeParallelMultiHashMap<TKey, TValue> map, TKey key)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> => default;
		public static ValueTuple<TKey[], TValue[]> MC2Serialize<TKey, TValue>(ref NativeParallelMultiHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct => default; // 0x0000000184871480-0x0000000184871760
		public static NativeParallelMultiHashMap<int2, ushort> MC2Deserialize(int2[] keyArray, ushort[] valueArray) => default;
		public static void MC2DisposeSafe<TKey, TValue>(ref NativeParallelMultiHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> {}
	}

	public static class NativeParallelHashMap // TypeDefIndex: 46200
	{
		// Methods
		public static void MC2DisposeSafe<TKey, TValue>(ref NativeParallelHashMap<TKey, TValue> map)
			where TKey : struct, IEquatable<TKey>
			where TValue : struct, IEquatable<TValue> {}
	}

	internal static class NativeReferenceExtensions // TypeDefIndex: 46201
	{
		// Methods
		public static int MC2InterlockedStartIndex(ref NativeReference<int> counter, int dataCount) => default; // 0x000000018766AB10-0x000000018766AB8C
		public static unsafe int MC2InterlockedStartIndex(int* cntPt, int dataCount) => default; // 0x0000000185FB0FC0-0x0000000185FB0FD0
	}

	public class PlayerLoopUtils // TypeDefIndex: 46203
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 46202
		{
			// Fields
			public string categoryName; // 0x10
			public string systemName; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x0000000184B27AC0-0x0000000184B27E20
	
			// Methods
			internal bool _AddPlayerLoop_b__0(PlayerLoopSystem s) => default; // 0x0000000185492010-0x0000000185492020
			internal bool _AddPlayerLoop_b__1(PlayerLoopSystem h) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public PlayerLoopUtils() {} // 0x00000001856C0BF0-0x00000001856C0C30
	
		// Methods
		public static void AddPlayerLoop(PlayerLoopSystem method, ref PlayerLoopSystem playerLoop, string categoryName, string systemName, bool last = false /* Metadata: 0x0205EA24 */, bool before = false /* Metadata: 0x0205EA25 */) {} // 0x00000001857F74C0-0x00000001857F7500
	}

	[Serializable]
	public class MagicaClothProcessingException : Exception // TypeDefIndex: 46204
	{
		// Constructors
		public MagicaClothProcessingException() {} // 0x000000018766A644-0x000000018766A690
		public MagicaClothProcessingException(string message) {} // 0x000000018766A6F0-0x000000018766A74C
		public MagicaClothProcessingException(string message, Exception inner) {} // 0x000000018766A690-0x000000018766A6F0
	}

	[Serializable]
	public class MagicaClothCanceledException : Exception // TypeDefIndex: 46205
	{
		// Constructors
		public MagicaClothCanceledException() {} // 0x000000018766A59C-0x000000018766A5E8
		public MagicaClothCanceledException(string message) {} // 0x000000018766A5E8-0x000000018766A644
		public MagicaClothCanceledException(string message, Exception inner) {} // 0x000000018766A53C-0x000000018766A59C
	}

	[Serializable]
	public struct ResultCode // TypeDefIndex: 46206
	{
		// Fields
		private Define.Result result; // 0x00
		private Define.Result warning; // 0x04
	
		// Properties
		public Define.Result Result { get => default; } // 0x0000000185FB1050-0x0000000185FB1060 
		public static ResultCode None { get => default; } // 0x0000000185FB1030-0x0000000185FB1050 
		public static ResultCode Empty { get => default; } // 0x0000000185FB0FF0-0x0000000185FB1010 
		public static ResultCode Success { get => default; } // 0x0000000185FB1060-0x0000000185FB1080 
		public static ResultCode Error { get => default; } // 0x0000000185FB1010-0x0000000185FB1030 
	
		// Constructors
		public ResultCode(Define.Result initResult) : this() {
			result = default;
			warning = default;
		} // 0x0000000185FB0FD0-0x0000000185FB0FF0
	
		// Methods
		public void Clear() {} // 0x0000000184874020-0x0000000184874060
		public void SetResult(Define.Result code) {} // 0x00000001840DFF40-0x00000001840DFF80
		public void SetSuccess() {} // 0x00000001840DFF00-0x00000001840DFF40
		public void SetCancel() {} // 0x000000018766B198-0x000000018766B1F0
		public void SetError(Define.Result code = Define.Result.Error /* Metadata: 0x0205EA26 */) {} // 0x000000018766B1F0-0x000000018766B248
		public void SetWarning(Define.Result code = Define.Result.Warning /* Metadata: 0x0205EA2A */) {} // 0x000000018766B248-0x000000018766B2A4
		public void Merge(ResultCode src) {} // 0x00000001840DE820-0x00000001840DE880
		public void SetProcess() {} // 0x00000001840DFEC0-0x00000001840DFF00
		public bool IsResult(Define.Result code) => default; // 0x000000018766B138-0x000000018766B198
		public bool IsNone() => default; // 0x000000018766B030-0x000000018766B088
		public bool IsSuccess() => default; // 0x00000001840DF2E0-0x00000001840DF320
		public bool IsFaild() => default; // 0x00000001840DF2A0-0x00000001840DF2E0
		public bool IsCancel() => default; // 0x000000018766AFD8-0x000000018766B030
		public bool IsNormal() => default; // 0x000000018766B088-0x000000018766B0E0
		public bool IsError() => default; // 0x00000001840DECF0-0x00000001840DED30
		public bool IsProcess() => default; // 0x000000018766B0E0-0x000000018766B138
		public bool IsWarning() => default; // 0x00000001840DE880-0x00000001840DE8C0
		public string GetResultString() => default; // 0x000000018766AD54-0x000000018766AE64
		public string GetWarningString() => default; // 0x000000018766AF04-0x000000018766AFD8
		public string GetResultInformation() => default; // 0x000000018766AC18-0x000000018766AD54
		public string GetWarningInformation() => default; // 0x000000018766AE64-0x000000018766AF04
		public void DebugLog(bool error = true /* Metadata: 0x0205EA2E */, bool warning = true /* Metadata: 0x0205EA2F */, bool normal = true /* Metadata: 0x0205EA30 */) {} // 0x000000018766AB8C-0x000000018766AC18
	}

	public class TimeSpan // TypeDefIndex: 46207
	{
		// Fields
		private string name; // 0x10
		private System.DateTime stime; // 0x18
		private System.DateTime etime; // 0x20
	
		// Constructors
		public TimeSpan() {} // 0x000000018766BBDC-0x000000018766BC24
		public TimeSpan(string name) {} // 0x000000018766BC24-0x000000018766BCAC
	
		// Methods
		public void Start() {} // 0x000000018766B930-0x000000018766B9AC
		public void Finish() {} // 0x000000018766B85C-0x000000018766B8D8
		public double TotalSeconds() => default; // 0x000000018766BB1C-0x000000018766BBDC
		public double TotalMilliSeconds() => default; // 0x000000018766BA5C-0x000000018766BB1C
		public override string ToString() => default; // 0x000000018766B9AC-0x000000018766BA5C
		public void DebugLog() {} // 0x000000018766B818-0x000000018766B85C
		public void Log() {} // 0x000000018766B8D8-0x000000018766B930
		public string __iFixBaseProxy_ToString() => default; // 0x000000018765AF34-0x000000018765AF3C
	}

	public class UnityTimeSpan // TypeDefIndex: 46208
	{
		// Fields
		private string name; // 0x10
		private float stime; // 0x18
		private float etime; // 0x1C
		private bool isFinish; // 0x20
	
		// Constructors
		public UnityTimeSpan() {} // Dummy constructor
		public UnityTimeSpan(string name) {} // 0x000000018766BEF8-0x000000018766BF68
	
		// Methods
		public void Finish() {} // 0x000000018766BD28-0x000000018766BD88
		public float TotalSeconds() => default; // 0x000000018766BE9C-0x000000018766BEF8
		public float TotalMilliSeconds() => default; // 0x000000018766BE38-0x000000018766BE9C
		public override string ToString() => default; // 0x000000018766BD88-0x000000018766BE38
		public void DebugLog() {} // 0x000000018766BCAC-0x000000018766BD28
		public string __iFixBaseProxy_ToString() => default; // 0x000000018765AF34-0x000000018765AF3C
	}

	public class VirtualMesh : IDisposable, IValid // TypeDefIndex: 46266
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
		public const byte EdgeFlag_Cut = 1; // Metadata: 0x0205EA35
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
		public const byte BaseLineFlag_IncludeLine = 1; // Metadata: 0x0205EA36
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
		public float InitCalcScale { get => default; } // 0x00000001840DB450-0x00000001840DB930 
		public bool IsSuccess { get => default; } // 0x0000000184125EB0-0x00000001841261B0 
		public bool IsError { get => default; } // 0x00000001876B4100-0x00000001876B4260 
		public bool IsProcess { get => default; } // 0x00000001876B2558-0x00000001876B25FC 
		public int VertexCount { get => default; } // 0x00000001876B1754-0x00000001876B1AFC 
		public int TriangleCount { get => default; } // 0x00000001876B1AFC-0x00000001876B1BF0 
		public int LineCount { get => default; } // 0x00000001876B22B4-0x00000001876B23C4 
		public int SkinBoneCount { get => default; } // 0x00000001876B23C4-0x00000001876B2558 
		public int TransformCount { get => default; } // 0x00000001876B1F74-0x00000001876B2120 
		public bool IsProxy { get => default; } // 0x00000001876B1BF0-0x00000001876B1F74 
		public bool IsMapping { get => default; } // 0x00000001876B2120-0x00000001876B22B4 
		public int BaseLineCount { get => default; } // 0x00000001876B4A34-0x00000001876B4CC4 
		public int EdgeCount { get => default; } // 0x0000000185492010-0x0000000185492020 
		public int CustomSkinningBoneCount { get => default; } // 0x000000018765AF34-0x000000018765AF3C 
		public int CenterFixedPointCount { get => default; } // 0x00000001876B4CC4-0x00000001876B4D30 
		public int NormalAdjustmentRotationCount { get => default; } // 0x00000001876B4D30-0x00000001876B4D9C 
	
		// Nested types
		private struct Import_GenerateTangentJob : IJobParallelFor // TypeDefIndex: 46209
		{
			// Fields
			public NativeArray<float3> localNormals; // 0x00
			public NativeArray<float3> localTangents; // 0x10
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001840DA510-0x00000001840DA900
		}
	
		private struct Import_CalcSkinningJob : IJobParallelFor // TypeDefIndex: 46210
		{
			// Fields
			public NativeArray<float3> localPositions; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<float3> localTangents; // 0x20
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x30
			public NativeArray<int> skinBoneTransformIndices; // 0x40
			public NativeArray<float4x4> bindPoses; // 0x50
			public NativeArray<float3> transformPositionArray; // 0x60
			public NativeArray<quaternion> transformRotationArray; // 0x70
			public NativeArray<float3> transformScaleArray; // 0x80
			public float4x4 toM; // 0x90
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018766EFC8-0x000000018766F8F8
		}
	
		private struct Import_BoneWeightJob1 : IJob // TypeDefIndex: 46211
		{
			// Fields
			public int vcnt; // 0x00
			public NativeArray<byte> bonesPerVertexArray; // 0x08
			public NativeArray<int> startBoneWeightIndices; // 0x18
	
			// Methods
			public void Execute() {} // 0x000000018766ED3C-0x000000018766EFC8
		}
	
		private struct Import_BoneWeightJob2 : IJobParallelFor // TypeDefIndex: 46212
		{
			// Fields
			public NativeArray<int> startBoneWeightIndices; // 0x00
			public NativeArray<BoneWeight1> boneWeightArray; // 0x10
			public NativeArray<byte> bonesPerVertexArray; // 0x20
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x30
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000184546030-0x0000000184549390
		}
	
		private struct Import_BoneVertexJob : IJobParallelFor // TypeDefIndex: 46213
		{
			// Fields
			public float4x4 WtoL; // 0x00
			public float4x4 LtoW; // 0x40
			public NativeArray<float3> transformPositions; // 0x80
			public NativeArray<quaternion> transformRotations; // 0x90
			public NativeArray<float3> transformScales; // 0xA0
			public NativeArray<float3> localPositions; // 0xB0
			public NativeArray<float3> localNormals; // 0xC0
			public NativeArray<float3> localTangents; // 0xD0
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0xE0
			public NativeArray<float4x4> skinBoneBindPoses; // 0xF0
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018766EB8C-0x000000018766ED3C
		}
	
		private struct Select_PackVertexJob : IJob // TypeDefIndex: 46214
		{
			// Fields
			public int vertexCount; // 0x00
			public NativeArray<int> newVertexRemapIndices; // 0x08
			public NativeArray<VertexAttribute> attributes; // 0x18
			public NativeArray<float3> localPositions; // 0x28
			public NativeArray<float3> localNormals; // 0x38
			public NativeArray<float3> localTangents; // 0x48
			public NativeArray<float2> uv; // 0x58
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x68
			public NativeArray<int> newReferenceIndices; // 0x78
			public NativeArray<VertexAttribute> newAttributes; // 0x88
			public NativeArray<float3> newLocalPositions; // 0x98
			public NativeArray<float3> newLocalNormals; // 0xA8
			public NativeArray<float3> newLocalTangents; // 0xB8
			public NativeArray<float2> newUv; // 0xC8
			public NativeArray<VirtualMeshBoneWeight> newBoneWeights; // 0xD8
	
			// Methods
			public void Execute() {} // 0x0000000187673E00-0x0000000187675008
		}
	
		private struct Select_GridJob : IJob // TypeDefIndex: 46215
		{
			// Fields
			public float gridSize; // 0x00
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x08
			public int selectionCount; // 0x18
			public NativeArray<float3> selectionPositions; // 0x20
			public NativeArray<VertexAttribute> selectionAttributes; // 0x30
			public int vertexCount; // 0x40
			public int triangleCount; // 0x44
			public float searchRadius; // 0x48
			public NativeArray<float3> meshPositions; // 0x50
			public NativeArray<int3> meshTriangles; // 0x60
			public NativeList<int3> newTriangles; // 0x70
			public NativeArray<int> newVertexRemapIndices; // 0x80
			public NativeReference<int> newVertexCount; // 0x90
	
			// Methods
			public void Execute() {} // 0x000000018766CE44-0x000000018766CF44
		}
	
		private struct Add_CalcBindPoseJob : IJobParallelFor // TypeDefIndex: 46216
		{
			// Fields
			public int skinBoneOffset; // 0x00
			public NativeArray<int> srcSkinBoneTransformIndices; // 0x08
			public NativeArray<float3> srcTransformPositionArray; // 0x18
			public NativeArray<quaternion> srcTransformRotationArray; // 0x28
			public NativeArray<float3> srcTransformScaleArray; // 0x38
			public float4x4 dstCenterLocalToWorldMatrix; // 0x48
			public NativeArray<float4x4> dstSkinBoneBindPoses; // 0x88
	
			// Methods
			public void Execute(int boneIndex) {} // 0x000000018766BF68-0x000000018766CE44
		}
	
		private struct Add_CopyVerticesJob : IJobParallelFor // TypeDefIndex: 46217
		{
			// Fields
			public int vertexOffset; // 0x00
			public int skinBoneOffset; // 0x04
			public float4x4 toM; // 0x08
			public NativeArray<VertexAttribute> srcAttributes; // 0x48
			public NativeArray<float3> srclocalPositions; // 0x58
			public NativeArray<float3> srclocalNormals; // 0x68
			public NativeArray<float3> srclocalTangents; // 0x78
			public NativeArray<float2> srcUV; // 0x88
			public NativeArray<VirtualMeshBoneWeight> srcBoneWeights; // 0x98
			public NativeArray<VertexAttribute> dstAttributes; // 0xA8
			public NativeArray<float3> dstlocalPositions; // 0xB8
			public NativeArray<float3> dstlocalNormals; // 0xC8
			public NativeArray<float3> dstlocalTangents; // 0xD8
			public NativeArray<float2> dstUV; // 0xE8
			public NativeArray<VirtualMeshBoneWeight> dstBoneWeights; // 0xF8
			public NativeArray<int> dstSkinBoneIndices; // 0x108
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000187675798-0x00000001876759E0
		}
	
		private struct MappingWorkData // TypeDefIndex: 46218
		{
			// Fields
			public float3 position; // 0x00
			public int vertexIndex; // 0x0C
			public int proxyVertexIndex; // 0x10
			public float proxyVertexDistance; // 0x14
		}
	
		private struct Mapping_DirectConnectionVertexDataJob : IJob // TypeDefIndex: 46219
		{
			// Fields
			public float4x4 toP; // 0x00
			public int vcnt; // 0x40
			public DataChunk mergeChunk; // 0x44
			public NativeArray<float3> localPositions; // 0x50
			public NativeArray<VertexAttribute> attributes; // 0x60
			public NativeArray<int> joinIndices; // 0x70
			public NativeArray<VertexAttribute> proxyAttributes; // 0x80
			public NativeArray<float3> proxyLocalPositions; // 0x90
			public NativeArray<MappingWorkData> mappingWorkData; // 0xA0
	
			// Methods
			public void Execute() {} // 0x0000000187675570-0x0000000187675798
		}
	
		private struct Mapping_CalcDirectWeightJob : IJob // TypeDefIndex: 46220
		{
			// Fields
			public int vcnt; // 0x00
			public float weightLength; // 0x04
			public NativeArray<MappingWorkData> mappingWorkData; // 0x08
			public NativeArray<VertexAttribute> attributes; // 0x18
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x28
			public NativeArray<float3> proxyLocalPositions; // 0x38
			public NativeArray<uint> proxyVertexToVertexIndexArray; // 0x48
			public NativeArray<ushort> proxyVertexToVertexDataArray; // 0x58
			public NativeParallelHashSet<ushort> useSet; // 0x68
	
			// Methods
			public void Execute() {} // 0x0000000187675008-0x0000000187675104
		}
	
		private struct Mapping_CalcConnectionVertexDataJob : IJob // TypeDefIndex: 46221
		{
			// Fields
			public float gridSize; // 0x00
			public float searchRadius; // 0x04
			public float4x4 toP; // 0x08
			public int vcnt; // 0x48
			public NativeArray<float3> localPositions; // 0x50
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x60
			public NativeArray<int> transformIds; // 0x70
			public NativeArray<VertexAttribute> attributes; // 0x80
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x90
			public NativeArray<VertexAttribute> proxyAttributes; // 0xA0
			public NativeArray<float3> proxyLocalPositions; // 0xB0
			public NativeArray<VirtualMeshBoneWeight> proxyBoneWeights; // 0xC0
			public NativeArray<int> proxyTransformIds; // 0xD0
			public NativeArray<MappingWorkData> mappingWorkData; // 0xE0
	
			// Methods
			public void Execute() {} // 0x0000000187675468-0x0000000187675570
		}
	
		private struct Mapping_CalcWeightJob : IJobParallelFor // TypeDefIndex: 46222
		{
			// Fields
			public NativeArray<MappingWorkData> mappingWorkData; // 0x00
			public NativeArray<VertexAttribute> attributes; // 0x10
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x20
			public NativeArray<VertexAttribute> proxyAttributes; // 0x30
			public NativeArray<float3> proxyLocalPositions; // 0x40
			public NativeArray<float3> proxyLocalNormals; // 0x50
			public NativeArray<uint> proxyVertexToVertexIndexArray; // 0x60
			public NativeArray<ushort> proxyVertexToVertexDataArray; // 0x70
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018766EB2C-0x000000018766EB8C
		}
	
		private struct Optimize_EdgeToTrianlgeJob : IJob // TypeDefIndex: 46223
		{
			// Fields
			public int tcnt; // 0x00
			public NativeArray<int3> triangles; // 0x08
			public NativeArray<float3> localPositions; // 0x18
			public NativeParallelHashMap<int2, FixedList128Bytes<int>> edgeToTriangleList; // 0x28
			public NativeList<int3> newTriangles; // 0x38
			public NativeParallelHashSet<int4> useQuadSet; // 0x48
			public NativeParallelHashSet<int3> removeTriangleSet; // 0x58
	
			// Methods
			public void Execute() {} // 0x0000000187675104-0x0000000187675404
		}
	
		private struct ProxyNormalRadiationAdjustmentJob : IJobParallelFor // TypeDefIndex: 46224
		{
			// Fields
			public double3 center; // 0x00
			public NativeArray<float3> localPositions; // 0x18
			public NativeArray<int> vertexParentIndices; // 0x28
			public NativeArray<uint> vertexChildIndexArray; // 0x38
			public NativeArray<ushort> vertexChildDataArray; // 0x48
			public NativeArray<float3> localNormals; // 0x58
			public NativeArray<float3> localTangents; // 0x68
			public NativeArray<quaternion> normalAdjustmentRotations; // 0x78
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018766D600-0x000000018766D668
		}
	
		private struct ProxyCreateFixedListAndAABBJob : IJob // TypeDefIndex: 46225
		{
			// Fields
			public int vcnt; // 0x00
			public NativeArray<VertexAttribute> attributes; // 0x08
			public NativeArray<float3> localPositions; // 0x18
			public NativeArray<uint> vertexToVertexIndexArray; // 0x28
			public NativeArray<ushort> vertexToVertexDataArray; // 0x38
			public NativeReference<AABB> outAABB; // 0x48
			public NativeList<ushort> fixedList; // 0x58
			public NativeReference<float3> localCenterPosition; // 0x68
	
			// Methods
			public void Execute() {} // 0x000000018766D3A0-0x000000018766D49C
		}
	
		private struct Proxy_CalcTriangleNormalJob : IJobParallelFor // TypeDefIndex: 46226
		{
			// Fields
			public NativeArray<int3> triangles; // 0x00
			public NativeArray<float3> localPositins; // 0x10
			public NativeArray<float3> triangleNormals; // 0x20
	
			// Methods
			public void Execute(int tindex) {} // 0x00000001876704B0-0x0000000187671180
		}
	
		private struct Proxy_CalcTriangleTangentJob : IJobParallelFor // TypeDefIndex: 46227
		{
			// Fields
			public NativeArray<int3> triangles; // 0x00
			public NativeArray<float3> localPositins; // 0x10
			public NativeArray<float2> uv; // 0x20
			public NativeArray<float3> triangleTangents; // 0x30
	
			// Methods
			public void Execute(int tindex) {} // 0x000000018766D1A4-0x000000018766D3A0
		}
	
		private struct Proxy_CreateVertexToTrianglesJob : IJob // TypeDefIndex: 46228
		{
			// Fields
			public NativeArray<int3> triangles; // 0x00
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x10
	
			// Methods
			public void Execute() {} // 0x0000000185033A70-0x0000000185033AB0
		}
	
		private struct Proxy_OrganizeVertexToTrianglsJob : IJobParallelFor // TypeDefIndex: 46229
		{
			// Fields
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x00
			public NativeArray<float3> triangleNormals; // 0x10
			public NativeArray<float3> triangleTangents; // 0x20
			public NativeArray<VertexAttribute> attributes; // 0x30
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185033B50-0x0000000185034070
		}
	
		private struct Proxy_CalcVertexNormalTangentFromTriangleJob : IJobParallelFor // TypeDefIndex: 46230
		{
			// Fields
			public NativeArray<float3> triangleNormals; // 0x00
			public NativeArray<float3> triangleTangents; // 0x10
			public NativeArray<FixedList32Bytes<uint>> vertexToTriangles; // 0x20
			public NativeArray<float3> localNormals; // 0x30
			public NativeArray<float3> localTangents; // 0x40
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018766D49C-0x000000018766D600
		}
	
		private struct Proxy_CalcVertexToTransformJob : IJobParallelFor // TypeDefIndex: 46231
		{
			// Fields
			public quaternion invRot; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<float3> localTangents; // 0x20
			public NativeArray<quaternion> vertexToTransformRotations; // 0x30
			public NativeArray<quaternion> transformRotations; // 0x40
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018766CF44-0x000000018766D1A4
		}
	
		private struct Proxy_CalcEdgeToTriangleJob : IJob // TypeDefIndex: 46232
		{
			// Fields
			public int tcnt; // 0x00
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x18
	
			// Methods
			public void Execute() {} // 0x0000000185035700-0x0000000185036D40
		}
	
		private struct Proxy_CalcVertexBindPoseJob2 : IJobParallelFor // TypeDefIndex: 46233
		{
			// Fields
			public NativeArray<float3> localPositions; // 0x00
			public NativeArray<float3> localNormals; // 0x10
			public NativeArray<float3> localTangents; // 0x20
			public NativeArray<float3> vertexBindPosePositions; // 0x30
			public NativeArray<quaternion> vertexBindPoseRotations; // 0x40
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018563A9C0-0x000000018563AB20
		}
	
		private struct Proxy_CalcVertexToVertexFromTriangleJob : IJob // TypeDefIndex: 46234
		{
			// Fields
			public int triangleCount; // 0x00
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<int, ushort> vertexToVertexMap; // 0x18
			public NativeParallelHashSet<int2> edgeSet; // 0x28
	
			// Methods
			public void Execute() {} // 0x00000001848703C0-0x0000000184870B80
		}
	
		private struct Proxy_CalcVertexToVertexFromLineJob : IJob // TypeDefIndex: 46235
		{
			// Fields
			public int lineCount; // 0x00
			public NativeArray<int2> lines; // 0x08
			public NativeParallelMultiHashMap<int, ushort> vertexToVertexMap; // 0x18
			public NativeParallelHashSet<int2> edgeSet; // 0x28
	
			// Methods
			public void Execute() {} // 0x0000000187671180-0x0000000187671BBC
		}
	
		private struct Proxy_CreateEdgeFlagJob : IJobParallelFor // TypeDefIndex: 46236
		{
			// Fields
			public NativeArray<int2> edges; // 0x00
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x10
			public NativeArray<ExBitFlag8> edgeFlags; // 0x20
	
			// Methods
			public void Execute(int eindex) {} // 0x000000018766D668-0x000000018766DA1C
		}
	
		private struct SkinningBoneInfo // TypeDefIndex: 46237
		{
			// Fields
			public int parentTransformIndex; // 0x00
			public float3 parentPos; // 0x04
			public int childTransformIndex; // 0x10
			public float3 childPos; // 0x14
		}
	
		private struct Proxy_CalcCustomSkinningWeightsJobV2 : IJobParallelFor // TypeDefIndex: 46238
		{
			// Fields
			public bool isBoneCloth; // 0x00
			public float angularAttenuation; // 0x04
			public float distanceReduction; // 0x08
			public float distancePow; // 0x0C
			public NativeArray<VertexAttribute> attributes; // 0x10
			public NativeArray<float3> localPositions; // 0x20
			public NativeList<SkinningBoneInfo> boneInfoList; // 0x30
			public NativeArray<VirtualMeshBoneWeight> boneWeights; // 0x40
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000185418A30-0x0000000185419A90
		}
	
		private struct Proxy_ApplySelectionJob : IJobParallelFor // TypeDefIndex: 46239
		{
			// Fields
			public float gridSize; // 0x00
			public float radius; // 0x04
			public NativeArray<float3> localPositions; // 0x08
			public NativeArray<VertexAttribute> attributes; // 0x18
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x28
			public NativeArray<float3> selectionPositions; // 0x38
			public NativeArray<VertexAttribute> selectionAttributes; // 0x48
	
			// Methods
			public void Execute(int vindex) {} // 0x000000018766DA1C-0x000000018766E9C8
		}
	
		private struct Proxy_BoneClothApplayTransformFlagJob : IJobParallelFor // TypeDefIndex: 46240
		{
			// Fields
			public NativeArray<VertexAttribute> attributes; // 0x00
			public NativeArray<ExBitFlag8> transformFlags; // 0x10
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000184B3D2C0-0x0000000184B40060
		}
	
		private struct BaseLineWork : IComparable<BaseLineWork> // TypeDefIndex: 46241
		{
			// Fields
			public int vindex; // 0x00
			public float dist; // 0x04
	
			// Methods
			public int CompareTo(BaseLineWork other) => default; // 0x000000018534E8A0-0x000000018534E920
		}
	
		private struct BaseLine_Mesh_CreateParentJob2 : IJob // TypeDefIndex: 46242
		{
			// Fields
			public int vcnt; // 0x00
			public float avgDist; // 0x04
			public NativeArray<VertexAttribute> attribues; // 0x08
			public NativeArray<float3> localPositions; // 0x18
			public NativeArray<uint> vertexToVertexIndexArray; // 0x28
			public NativeArray<ushort> vertexToVertexDataArray; // 0x38
			public NativeArray<int> vertexParentIndices; // 0x48
			public NativeParallelMultiHashMap<int, ushort> vertexChildMap; // 0x58
			public NativeList<int> fixedList; // 0x68
			public NativeList<BaseLineWork> nextList; // 0x78
			public NativeArray<byte> markBuff; // 0x88
			public NativeParallelHashMap<int, BaseLineWork> vertexMap; // 0x98
	
			// Methods
			public void Execute() {} // 0x00000001856970F0-0x0000000185697380
		}
	
		private struct BaseLine_Mesh_CareteFixedListJob : IJob // TypeDefIndex: 46243
		{
			// Fields
			public int vcnt; // 0x00
			public NativeArray<VertexAttribute> attribues; // 0x08
			public NativeList<int> fixedList; // 0x18
	
			// Methods
			public void Execute() {} // 0x000000018481C5E0-0x000000018481CAD0
		}
	
		private struct BaseLine_Bone_CreateBoneChildInfoJob : IJob // TypeDefIndex: 46244
		{
			// Fields
			public int vcnt; // 0x00
			public NativeArray<int> parentIndices; // 0x08
			public NativeParallelMultiHashMap<int, ushort> childMap; // 0x18
	
			// Methods
			public void Execute() {} // 0x0000000187672FE4-0x0000000187673E00
		}
	
		private struct BaseLine_CalcLocalPositionRotationJob : IJobParallelFor // TypeDefIndex: 46245
		{
			// Fields
			public NativeArray<int> parentIndices; // 0x00
			public NativeArray<float3> localPositions; // 0x10
			public NativeArray<float3> localNormals; // 0x20
			public NativeArray<float3> localTangents; // 0x30
			public NativeArray<ushort> baseLineIndices; // 0x40
			public NativeArray<float3> vertexLocalPositions; // 0x50
			public NativeArray<quaternion> vertexLocalRotations; // 0x60
	
			// Methods
			public void Execute(int index) {} // 0x000000018766F8F8-0x000000018766FB3C
		}
	
		private struct BaseLine_CalcMaxBaseLineLengthJob : IJob // TypeDefIndex: 46246
		{
			// Fields
			public int vcnt; // 0x00
			public NativeArray<VertexAttribute> attribues; // 0x08
			public NativeArray<float3> localPositions; // 0x18
			public NativeArray<int> vertexParentIndices; // 0x28
			public NativeArray<float> vertexDepths; // 0x38
			public NativeArray<int> vertexRootIndices; // 0x48
			public NativeArray<float> rootLengthArray; // 0x58
	
			// Methods
			public void Execute() {} // 0x00000001876728CC-0x00000001876729F0
		}
	
		private struct Reduction_InitVertexToVertexJob2 : IJob // TypeDefIndex: 46247
		{
			// Fields
			public int triangleCount; // 0x00
			public NativeArray<int3> triangles; // 0x08
			public NativeParallelMultiHashMap<ushort, ushort> vertexToVertexMap; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001876723E4-0x00000001876728CC
		}
	
		private struct Organize_RemapVertexJob : IJob // TypeDefIndex: 46248
		{
			// Fields
			public int oldVertexCount; // 0x00
			public NativeArray<int> joinIndices; // 0x08
			public NativeArray<int> vertexRemapIndices; // 0x18
	
			// Methods
			public void Execute() {} // 0x00000001876720F4-0x00000001876723E4
		}
	
		private struct Organize_CollectUseSkinBoneJob : IJob // TypeDefIndex: 46249
		{
			// Fields
			public int oldVertexCount; // 0x00
			public NativeArray<int> joinIndices; // 0x08
			public NativeArray<VirtualMeshBoneWeight> oldBoneWeights; // 0x18
			public NativeArray<float4x4> oldBindPoses; // 0x28
			public NativeParallelHashMap<int, int> useSkinBoneMap; // 0x38
			public NativeList<int> newSkinBoneTransformIndices; // 0x48
			public NativeList<float4x4> newSkinBoneBindPoses; // 0x58
			public NativeReference<int> newSkinBoneCount; // 0x68
			public NativeList<int> useSkinBoneMapKeyList; // 0x78
	
			// Methods
			public void Execute() {} // 0x0000000187671BBC-0x0000000187671F80
		}
	
		private struct Organize_CopyVertexJob : IJobParallelFor // TypeDefIndex: 46250
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<int> vertexRemapIndices; // 0x10
			public NativeArray<VertexAttribute> oldAttributes; // 0x20
			public NativeArray<float3> oldLocalPositions; // 0x30
			public NativeArray<float3> oldLocalNormals; // 0x40
			public NativeArray<float3> oldLocalTangents; // 0x50
			public NativeArray<VertexAttribute> newAttributes; // 0x60
			public NativeArray<float3> newLocalPositions; // 0x70
			public NativeArray<float3> newLocalNormals; // 0x80
			public NativeArray<float3> newLocalTangents; // 0x90
	
			// Methods
			public void Execute(int index) {} // 0x0000000187671F80-0x00000001876720F4
		}
	
		private struct Organize_RemapBoneWeightJob : IJobParallelFor // TypeDefIndex: 46251
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<int> vertexRemapIndices; // 0x10
			public NativeParallelHashMap<int, int> useSkinBoneMap; // 0x20
			public NativeArray<int> oldSkinBoneIndices; // 0x30
			public NativeArray<VirtualMeshBoneWeight> oldBoneWeights; // 0x40
			public NativeArray<VirtualMeshBoneWeight> newBoneWeights; // 0x50
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001876729F0-0x0000000187672FE4
		}
	
		private struct Organize_RemapLinkPointArrayJob : IJobParallelFor // TypeDefIndex: 46252
		{
			// Fields
			public NativeArray<int> joinIndices; // 0x00
			public NativeArray<int> vertexRemapIndices; // 0x10
			public NativeParallelMultiHashMap<ushort, ushort> oldVertexToVertexMap; // 0x20
			public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x30
	
			// Methods
			public void Execute(int vindex) {} // 0x00000001876759E0-0x00000001876763D0
		}
	
		private struct Organize_CreateLineTriangleJob : IJob // TypeDefIndex: 46253
		{
			// Fields
			public int newVertexCount; // 0x00
			public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x08
			public NativeParallelHashSet<int2> edgeSet; // 0x18
	
			// Methods
			public void Execute() {} // 0x0000000184871CA0-0x00000001848726C0
		}
	
		private struct Organize_CreateLineTriangleJob2 : IJob // TypeDefIndex: 46254
		{
			// Fields
			public NativeParallelMultiHashMap<ushort, ushort> newVertexToVertexMap; // 0x00
			public NativeList<int2> newLineList; // 0x10
			public NativeParallelHashSet<int2> edgeSet; // 0x20
			public NativeParallelHashSet<int3> triangleSet; // 0x30
	
			// Methods
			public void Execute() {} // 0x0000000187676B84-0x0000000187676CC8
		}
	
		private struct Organize_CreateNewTriangleJob3 : IJob // TypeDefIndex: 46255
		{
			// Fields
			public NativeList<int3> newTriangleList; // 0x00
			public NativeParallelHashSet<int3> triangleSet; // 0x10
	
			// Methods
			public void Execute() {} // 0x0000000185034180-0x0000000185034BE0
		}
	
		[Serializable]
		public class ShareSerializationData // TypeDefIndex: 46256
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
			public ShareSerializationData() {} // 0x000000018766FB3C-0x00000001876703F4
	
			// Methods
			public override string ToString() => default; // 0x000000018766E9C8-0x000000018766EB2C
			public string __iFixBaseProxy_ToString() => default; // 0x0000000185FB1080-0x0000000185FB1090
		}
	
		[Serializable]
		public class UniqueSerializationData : ITransform // TypeDefIndex: 46257
		{
			// Fields
			public BeyondDynamicBone.TransformData.UniqueSerializationData transformData; // 0x10
	
			// Constructors
			public UniqueSerializationData() {} // 0x0000000187676CE4-0x0000000187676CF0
	
			// Methods
			public void GetUsedTransform(HashSet<Transform> transformSet) {} // 0x0000000187676D04-0x0000000187676D10
			public void ReplaceTransform(Dictionary<int, Transform> replaceDict) {} // 0x00000001864730FC-0x0000000186473108
		}
	
		private struct Work_AverageTriangleDistanceJob : IJob // TypeDefIndex: 46258
		{
			// Fields
			public int vcnt; // 0x00
			public int tcnt; // 0x04
			public NativeArray<float3> localPositions; // 0x08
			public NativeArray<int3> triangles; // 0x18
			public NativeReference<float> averageVertexDistance; // 0x28
			public NativeReference<int> averageCount; // 0x38
			public NativeReference<float> maxVertexDistance; // 0x48
	
			// Methods
			public void Execute() {} // 0x0000000185036D40-0x0000000185036D80
		}
	
		private struct Work_AverageLineDistanceJob : IJob // TypeDefIndex: 46259
		{
			// Fields
			public int vcnt; // 0x00
			public int lcnt; // 0x04
			public NativeArray<float3> localPositions; // 0x08
			public NativeArray<int2> lines; // 0x18
			public NativeReference<float> averageVertexDistance; // 0x28
			public NativeReference<int> averageCount; // 0x38
			public NativeReference<float> maxVertexDistance; // 0x48
	
			// Methods
			public void Execute() {} // 0x0000000185034BE0-0x0000000185034C20
		}
	
		private struct Work_AddVertexIndexGirdMapJob : IJob // TypeDefIndex: 46260
		{
			// Fields
			public float gridSize; // 0x00
			public int vcnt; // 0x04
			public NativeArray<float3> positins; // 0x08
			public NativeParallelMultiHashMap<int3, int> gridMap; // 0x18
	
			// Methods
			public void Execute() {} // 0x0000000185034C20-0x0000000185034C60
		}
	
		private struct Work_IntersectTriangleJob : IJobParallelFor // TypeDefIndex: 46261
		{
			// Fields
			public float3 localRayPos; // 0x00
			public float3 localRayDir; // 0x0C
			public float3 localRayEndPos; // 0x18
			public bool doubleSide; // 0x24
			public NativeArray<float3> localPositions; // 0x28
			public NativeArray<int3> triangles; // 0x38
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x48
	
			// Methods
			public void Execute(int tindex) {} // 0x0000000187676D90-0x0000000187676DD0
		}
	
		private struct Work_IntersectEdgeJob : IJobParallelFor // TypeDefIndex: 46262
		{
			// Fields
			public float3 localRayPos; // 0x00
			public float3 localRayDir; // 0x0C
			public float3 localRayEndPos; // 0x18
			public float3 rayDir; // 0x24
			public float localEdgeRadius; // 0x30
			public NativeArray<float3> localPositions; // 0x38
			public NativeArray<int2> edges; // 0x48
			public NativeParallelMultiHashMap<int2, ushort> edgeToTriangles; // 0x58
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x68
	
			// Methods
			public void Execute(int eindex) {} // 0x00000001840D9980-0x00000001840D99A0
		}
	
		private struct Work_IntersectPointJob : IJobParallelFor // TypeDefIndex: 46263
		{
			// Fields
			public float3 localRayPos; // 0x00
			public float3 localRayDir; // 0x0C
			public float3 rayDir; // 0x18
			public float localPointRadius; // 0x24
			public NativeArray<float3> localPositions; // 0x28
			public NativeArray<FixedList32Bytes<int>> vertexToTriangles; // 0x38
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x48
	
			// Methods
			public void Execute(int vindex) {} // 0x0000000187676CF0-0x0000000187676D04
		}
	
		private struct Work_IntersetcSortJob : IJob // TypeDefIndex: 46264
		{
			// Fields
			public NativeList<VirtualMeshRaycastHit> hitList; // 0x00
	
			// Methods
			public void Execute() {} // 0x0000000187676CDC-0x0000000187676CE4
		}
	
		public enum MeshType // TypeDefIndex: 46265
		{
			NormalMesh = 0,
			NormalBoneMesh = 1,
			ProxyMesh = 2,
			ProxyBoneMesh = 3,
			Mapping = 4
		}
	
		// Constructors
		public VirtualMesh() {} // 0x0000000185492010-0x0000000185492020
		public VirtualMesh(bool initialize) {} // 0x00000001876B6498-0x00000001876B6710
		public VirtualMesh(string name) {} // 0x00000001855307B0-0x00000001855309A0
	
		// Methods
		public void ImportFrom(RenderSetupData rsetup) {} // 0x00000001850353F0-0x0000000185035450
		private void ImportMeshType(RenderSetupData rsetup, int[] transformIndices) {} // 0x0000000185035450-0x00000001850354B0
		private void ImportMeshSkinning() {} // 0x0000000187676CC8-0x0000000187676CDC
		private void ImportBoneType(RenderSetupData rsetup, int[] transformIndices) {} // 0x00000001840DA0B0-0x00000001840DA0D0
		public void ImportFrom(BeyondDynamicBone.RenderData renderData) {} // 0x0000000187676D10-0x0000000187676D90
		public void SelectionMesh(SelectionData selectionData, float4x4 selectionLocalToWorldMatrix, float mergin) {} // 0x00000001848700E0-0x00000001848703C0
		public float CalcSelectionMergin(ReductionSettings settings) => default; // 0x0000000184872840-0x0000000184872C30
		public void AddMesh(VirtualMesh cmesh) {} // 0x0000000184871C60-0x0000000184871CA0
		public void SetTransform(Transform center, Transform skinRoot = null, int centerId = 0 /* Metadata: 0x0205EA31 */, int skinRootId = 0 /* Metadata: 0x0205EA32 */) {} // 0x0000000184D61280-0x0000000184D618D0
		public void SetTransform(TransformRecord centerRecord, TransformRecord skinRootRecord = null) {} // 0x0000000187675404-0x0000000187675468
		public void SetCenterTransform(Transform t, int tid = 0 /* Metadata: 0x0205EA33 */) {} // 0x00000001876703F4-0x00000001876704B0
		public void SetSkinRoot(Transform t, int tid = 0 /* Metadata: 0x0205EA34 */) {} // 0x00000001876763D0-0x0000000187676B84
		public Transform GetCenterTransform() => default; // 0x000000018765AF34-0x000000018765AF3C
		public void SetCustomSkinningBones(TransformRecord clothTransformRecord, List<TransformRecord> bones) {} // 0x00000001876AF718-0x00000001876AF858
		public bool CompareSpace(VirtualMesh target) => default; // 0x00000001876AF154-0x00000001876AF718
		public float4x4 CenterTransformTo(VirtualMesh to) => default; // 0x00000001876AEFDC-0x00000001876AF054
		public void Mapping(VirtualMesh proxyMesh) {} // 0x00000001876AF054-0x00000001876AF154
		private static float4 CalcVertexWeights(float4 distances) => default; // 0x00000001840DC1B0-0x00000001840DC710
		public void Optimization() {} // 0x00000001876B48B0-0x00000001876B4A34
		private void RemoveDuplicateTriangles() {} // 0x00000001876B4260-0x00000001876B48B0
		private bool CheckTwoTriangleOpen(in int3 tri1, in int3 tri2, in int2 edge, in float3 tri1n) => default; // 0x00000001876ADC64-0x00000001876ADDF8
		private float CalcTwoTriangleAngle(in int3 tri1, in int3 tri2, in int2 edge) => default; // 0x00000001876ADDF8-0x00000001876AE05C
		public void ConvertProxyMesh(ClothSerializeData sdata, TransformRecord clothTransformRecord, List<TransformRecord> customSkinningBoneRecords, TransformRecord normalAdjustmentTransformRecord) {} // 0x00000001876B09A0-0x00000001876B0B7C
		private void ProxyNormalAdjustment(ClothSerializeData sdata, TransformRecord normalAdjustmentTransformRecord) {} // 0x00000001876B0030-0x00000001876B054C
		private void ProxyCreateFixedListAndAABB() {} // 0x00000001876AF858-0x00000001876B0030
		private void OptimizeTriangleDirection(NativeArray<float3> triangleNormals, float sameSurfaceAngle) {} // 0x00000001876B054C-0x00000001876B09A0
		private void CreateCustomSkinning(CustomSkinningSettings setting, List<TransformRecord> bones) {} // 0x00000001876B0B7C-0x00000001876B1754
		public void ApplySelectionAttribute(SelectionData selectionData) {} // 0x00000001876B25FC-0x00000001876B2C04
		private void CreateMeshBaseLine() {} // 0x000000018533AA60-0x000000018533AFB0
		private void CreateTransformBaseLine() {} // 0x00000001876B307C-0x00000001876B31E4
		public static void DoBaseLine_Bone_CreateBoneChildInfo(int vcnt, NativeArray<int> parentIndices, NativeParallelMultiHashMap<int, ushort> childMap) {} // 0x00000001876B31E4-0x00000001876B3344
		private void CreateBaseLinePose() {} // 0x00000001876B382C-0x00000001876B3980
		private void CreateVertexRootAndDepth() {} // 0x00000001876B3980-0x00000001876B4100
		public void Reduction(ReductionSettings settings, CancellationToken ct) {} // 0x00000001876B3344-0x00000001876B3640
		private void InitReductionWorkData(ReductionWorkData workData) {} // 0x00000001840DB050-0x00000001840DB1A0
		private void Organization(ReductionSettings setting, ReductionWorkData workData) {} // 0x00000001876B2F28-0x00000001876B307C
		private void OrganizationInit(ReductionSettings setting, ReductionWorkData workData) {} // 0x00000001840DB230-0x00000001840DB410
		private void OrganizationCreateRemapData(ReductionWorkData workData) {} // 0x00000001876B3640-0x00000001876B382C
		private void OrganizationCreateBasicData(ReductionWorkData workData) {} // 0x0000000185588250-0x0000000185588360
		private void OrganizationCreateLineTriangle(ReductionWorkData workData) {} // 0x00000001840DBAD0-0x00000001840DBB70
		private void OrganizeStoreVirtualMesh(ReductionWorkData workData) {} // 0x00000001876B2C04-0x00000001876B2F28
		public ShareSerializationData ShareSerialize() => default; // 0x0000000184124950-0x0000000184125570
		public static VirtualMesh ShareDeserialize(ShareSerializationData sdata) => default; // 0x0000000184B3CAB0-0x0000000184B3CC70
		public UniqueSerializationData UniqueSerialize() => default; // 0x00000001876AE05C-0x00000001876AE0CC
		internal void CalcAverageAndMaxVertexDistanceRun() {} // 0x00000001876AE230-0x00000001876AED18
		internal GridMap<int> CreateVertexIndexGridMapRun(float gridSize) => default; // 0x00000001876AE164-0x00000001876AE230
		public VirtualMeshRaycastHit IntersectRayMesh(float3 rayPos, float3 rayDir, bool doubleSide, float pointRadius) => default; // 0x00000001876AE0CC-0x00000001876AE164
		public void Dispose() {} // 0x00000001876B63CC-0x00000001876B6498
		public void SetName(string newName) {} // 0x00000001876B6B98-0x00000001876B6F3C
		public bool IsValid() => default; // 0x00000001876B6710-0x00000001876B69C8
		public override string ToString() => default; // 0x00000001876B69C8-0x00000001876B6B98
		public string __iFixBaseProxy_ToString() => default; // 0x00000001876B6F3C-0x00000001876B6FDC
	}

	[Serializable]
	public struct VertexAttribute : IEquatable<VertexAttribute> // TypeDefIndex: 46267
	{
		// Fields
		public const byte Flag_Fixed = 1; // Metadata: 0x0205EA3D
		public const byte Flag_Move = 2; // Metadata: 0x0205EA3E
		public const byte Flag_InvalidMotion = 8; // Metadata: 0x0205EA3F
		public const byte Flag_DisableCollision = 16; // Metadata: 0x0205EA40
		public const byte Flag_Triangle = 128; // Metadata: 0x0205EA41
		public static readonly VertexAttribute Invalid; // 0x00
		public static readonly VertexAttribute Fixed; // 0x01
		public static readonly VertexAttribute Move; // 0x02
		public static readonly VertexAttribute DisableCollision; // 0x03
		public byte Value; // 0x00
	
		// Constructors
		public VertexAttribute(byte initialValue = 0 /* Metadata: 0x0205EA3C */) {
			Value = default;
		} // 0x0000000185FB0F60-0x0000000185FB0F70
		static VertexAttribute() {
			Invalid = default;
			Fixed = default;
			Move = default;
			DisableCollision = default;
		} // 0x0000000185F60D60-0x0000000185F60DD0
	
		// Methods
		public void Clear() {} // 0x0000000185FB0F50-0x0000000185FB0F60
		public void SetFlag(byte flag, bool sw) {} // 0x0000000187669378-0x000000018766938C
		public void SetFlag(VertexAttribute attr, bool sw) {} // 0x0000000187669378-0x000000018766938C
		public bool IsSet(byte flag) => default; // 0x0000000187669370-0x0000000187669378
		public bool IsInvalid() => default; // 0x00000001876B4F5C-0x00000001876B4F9C
		public bool IsFixed() => default; // 0x00000001876B4F14-0x00000001876B4F5C
		public bool IsMove() => default; // 0x00000001876B4FDC-0x00000001876B5024
		public bool IsDontMove() => default; // 0x00000001876B4ED4-0x00000001876B4F14
		public bool IsMotion() => default; // 0x00000001876B4F9C-0x00000001876B4FDC
		public bool IsDisableCollision() => default; // 0x00000001876B4E8C-0x00000001876B4ED4
		public static VertexAttribute JoinAttribute(VertexAttribute attr1, VertexAttribute attr2) => default; // 0x00000001876B5024-0x00000001876B5030
		public bool Equals(VertexAttribute other) => default; // 0x00000001850507D0-0x00000001850507E0
		public override bool Equals(object obj) => default; // 0x00000001876B4D9C-0x00000001876B4E40
		public override int GetHashCode() => default; // 0x00000001876B4E40-0x00000001876B4E8C
		public static bool operator ==(VertexAttribute lhs, VertexAttribute rhs) => default; // 0x00000001876B50D8-0x00000001876B50E0
		public static bool operator !=(VertexAttribute lhs, VertexAttribute rhs) => default; // 0x00000001876B50E0-0x00000001876B50E8
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x00000001876B5030-0x00000001876B508C
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001876B508C-0x00000001876B50D8
	}

	public struct VirtualMeshBoneWeight // TypeDefIndex: 46268
	{
		// Fields
		public float4 weights; // 0x00
		public int4 boneIndices; // 0x10
	
		// Properties
		public bool IsValid { get => default; } // 0x00000001876B5548-0x00000001876B5558 
		public int Count { get => default; } // 0x00000001876B54B4-0x00000001876B5548 
	
		// Constructors
		public VirtualMeshBoneWeight(int4 boneIndices, float4 weights) : this() {
			this.weights = default;
			this.boneIndices = default;
		} // 0x0000000185FB10A0-0x0000000185FB10B0
	
		// Methods
		public void AddWeight(int boneIndex, float weight) {} // 0x00000001876B5190-0x00000001876B52E4
		public void AddWeight(in VirtualMeshBoneWeight bw) {} // 0x00000001876B50E8-0x00000001876B5190
		public void AdjustWeight() {} // 0x00000001876B52E4-0x00000001876B538C
		public override string ToString() => default; // 0x00000001876B538C-0x00000001876B545C
		public string __iFixBaseProxy_ToString() => default; // 0x00000001876B545C-0x00000001876B54B4
	}

	public class VirtualMeshContainer : IDisposable // TypeDefIndex: 46269
	{
		// Fields
		public VirtualMesh shareVirtualMesh; // 0x10
		public VirtualMesh.UniqueSerializationData uniqueData; // 0x18
	
		// Properties
		public bool hasUniqueData { get => default; } // 0x00000001847EB9E0-0x00000001847EB9F0 
	
		// Constructors
		public VirtualMeshContainer() {} // 0x0000000185492010-0x0000000185492020
		public VirtualMeshContainer(VirtualMesh vmesh) {} // 0x00000001846A0F60-0x00000001846A0F90
	
		// Methods
		public void Dispose() {} // 0x0000000184D61D80-0x0000000184D61DC0
		public int GetTransformCount() => default; // 0x0000000184B38E60-0x0000000184B38ED0
		public Transform GetTransformFromIndex(int index) => default; // 0x0000000184B3A380-0x0000000184B3A410
		public Transform GetCenterTransform() => default; // 0x00000001876B5558-0x00000001876B55F8
	}

	public enum VirtualMeshPrimitive // TypeDefIndex: 46270
	{
		None = 0,
		Point = 1,
		Edge = 2,
		Triangle = 3
	}

	public struct VirtualMeshRaycastHit : IComparable<VirtualMeshRaycastHit>, IValid // TypeDefIndex: 46271
	{
		// Fields
		public VirtualMeshPrimitive type; // 0x00
		public int index; // 0x04
		public double3 position; // 0x08
		public double distance; // 0x20
		public float3 normal; // 0x28
	
		// Methods
		public int CompareTo(VirtualMeshRaycastHit other) => default; // 0x00000001876B55F8-0x00000001876B5698
		public bool IsValid() => default; // 0x00000001876B5698-0x00000001876B56E8
		public override string ToString() => default; // 0x00000001876B56E8-0x00000001876B5900
		public string __iFixBaseProxy_ToString() => default; // 0x00000001876B5900-0x00000001876B596C
	}

	public struct VirtualMeshTransform // TypeDefIndex: 46272
	{
		// Fields
		public FixedString32Bytes name; // 0x00
		public int index; // 0x20
		public float4x4 localToWorldMatrix; // 0x24
		public float4x4 worldToLocalMatrix; // 0x64
		public int parentIndex; // 0xA4
	
		// Properties
		public static VirtualMeshTransform Origin { get => default; } // 0x00000001876B6258-0x00000001876B63CC 
	
		// Constructors
		public VirtualMeshTransform(Transform t) : this() {
			name = default;
			index = default;
			localToWorldMatrix = default;
			worldToLocalMatrix = default;
			parentIndex = default;
		} // 0x00000001876B60E0-0x00000001876B6258
		public VirtualMeshTransform(Transform t, int index) : this() {
			name = default;
			this.index = default;
			localToWorldMatrix = default;
			worldToLocalMatrix = default;
			parentIndex = default;
		} // 0x00000001876B60B8-0x00000001876B60E0
	
		// Methods
		public VirtualMeshTransform Clone() => default; // 0x00000001876B596C-0x00000001876B5AB8
		public override int GetHashCode() => default; // 0x00000001876B5AB8-0x00000001876B5B08
		public void Update(Transform t) {} // 0x00000001876B5F7C-0x00000001876B60B8
		public float3 TransformPoint(float3 pos) => default; // 0x00000001876B5C1C-0x00000001876B5C8C
		public float3 TransformVector(float3 vec) => default; // 0x00000001876ADBB4-0x00000001876ADC64
		public float3 TransformDirection(float3 dir) => default; // 0x00000001876ADAD4-0x00000001876ADBB4
		public float3 InverseTransformPoint(float3 pos) => default; // 0x00000001876B5B08-0x00000001876B5B80
		public float3 InverseTransformVector(float3 vec) => default; // 0x00000001876ADA20-0x00000001876ADAD4
		public float3 InverseTransformDirection(float3 dir) => default; // 0x00000001876AD940-0x00000001876ADA20
		public quaternion InverseTransformRotation(quaternion rot) => default; // 0x00000001876B5B80-0x00000001876B5C1C
		public VirtualMeshTransform Transform(in VirtualMeshTransform to) => default; // 0x00000001876B5C8C-0x00000001876B5ECC
		public int __iFixBaseProxy_GetHashCode() => default; // 0x00000001876B5ECC-0x00000001876B5F7C
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 46275
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64B00-0x0000000185F64B70
	
		// Methods
		public void __Gen_Wrap_0(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public bool __Gen_Wrap_1() => default; // 0x000000018735B3F8-0x000000018735B4A4
		public bool __Gen_Wrap_2(object P0, int P1) => default; // 0x000000018768D9EC-0x000000018768DAD8
		public bool __Gen_Wrap_3(object P0) => default; // 0x000000018735B960-0x000000018735BA30
		public void __Gen_Wrap_4(object P0, float P1, float P2) {} // 0x00000001876A24E4-0x00000001876A25CC
		public void __Gen_Wrap_5(object P0, bool P1, float3 P2, quaternion P3) {} // 0x00000001876A972C-0x00000001876A9898
		public BeyondBoneCloth __Gen_Wrap_6(object P0) => default; // 0x00000001876AA39C-0x00000001876AA48C
		public void __Gen_Wrap_7(ref ResultCode P0, Define.Result P1) {} // 0x00000001876AB434-0x00000001876AB578
		public void __Gen_Wrap_8(ref ResultCode P0) {} // 0x00000001876AC080-0x00000001876AC1A8
		public void __Gen_Wrap_9(in object P0) {} // 0x00000001876ACEA4-0x00000001876ACF78
		public ClothSerializeData2 __Gen_Wrap_10(object P0) => default; // 0x0000000187677984-0x0000000187677A74
		public void __Gen_Wrap_11(object P0, int P1, bool P2) {} // 0x000000018767866C-0x0000000187678764
		public bool __Gen_Wrap_12(Transform P0) => default; // 0x0000000187678D18-0x0000000187678DD4
		public bool __Gen_Wrap_13(Renderer P0) => default; // 0x0000000187678D18-0x0000000187678DD4
		public ResultCode __Gen_Wrap_14(object P0) => default; // 0x000000018767A15C-0x000000018767A24C
		public bool __Gen_Wrap_15(ref ResultCode P0) => default; // 0x000000018767ADA8-0x000000018767AEE0
		public void __Gen_Wrap_16(ref ResultCode P0, ResultCode P1) {} // 0x000000018767C91C-0x000000018767CA74
		public SharePreBuildData __Gen_Wrap_17(object P0) => default; // 0x000000018767EA44-0x000000018767EB34
		public float4x4 __Gen_Wrap_18(object P0) => default; // 0x000000018767FE54-0x000000018767FF78
		public void __Gen_Wrap_19(ref CullingSettings.CullingParams P0, object P1) {} // 0x0000000187681000-0x000000018768115C
		public float __Gen_Wrap_20(object P0, float P1) => default; // 0x00000001876828FC-0x00000001876829EC
		public void __Gen_Wrap_21(ref InertiaConstraint.InertiaConstraintParams P0, object P1) {} // 0x0000000187683F64-0x00000001876840E4
		public void __Gen_Wrap_22(ref TetherConstraint.TetherConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x00000001876854F8-0x000000018768564C
		public void __Gen_Wrap_23(ref DistanceConstraint.DistanceConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x0000000187686398-0x000000018768653C
		public void __Gen_Wrap_24(ref TriangleBendingConstraint.TriangleBendingConstraintParams P0, object P1) {} // 0x0000000187687FA4-0x00000001876880E8
		public void __Gen_Wrap_25(ref AngleConstraint.AngleConstraintParams P0, object P1, object P2) {} // 0x0000000187688EE8-0x0000000187689108
		public void __Gen_Wrap_26(ref MotionConstraint.MotionConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x0000000187689D38-0x0000000187689F44
		public void __Gen_Wrap_27(ref ColliderCollisionConstraint.ColliderCollisionConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018768ADEC-0x000000018768AFA4
		public void __Gen_Wrap_28(ref SelfCollisionConstraint.SelfCollisionConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018768C16C-0x000000018768C324
		public void __Gen_Wrap_29(ref WindParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018768D864-0x000000018768D9EC
		public void __Gen_Wrap_30(ref SpringConstraint.SpringConstraintParams P0, object P1, ClothProcess.ClothType P2) {} // 0x000000018768EC18-0x000000018768ED80
		public ClothParameters __Gen_Wrap_31(object P0) => default; // 0x0000000187690174-0x00000001876902F8
		public RenderSetupData __Gen_Wrap_32(object P0) => default; // 0x000000018769164C-0x000000018769173C
		public BeyondDynamicBone.TransformData __Gen_Wrap_33(object P0) => default; // 0x00000001876926E8-0x00000001876927D8
		public NativeParallelMultiHashMap<int2, ushort> __Gen_Wrap_34(object P0, object P1) => default; // 0x0000000187693018-0x0000000187693140
		public VirtualMesh __Gen_Wrap_35(object P0) => default; // 0x0000000187693FC8-0x00000001876940B8
		public void __Gen_Wrap_36(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public PreBuildManager.ShareDeserializationData __Gen_Wrap_37(object P0, object P1, bool P2) => default; // 0x00000001876969BC-0x0000000187696AE4
		public void __Gen_Wrap_38(object P0, object P1, object P2, object P3) {} // 0x0000000187698148-0x0000000187698250
		public int __Gen_Wrap_39(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public int __Gen_Wrap_40(object P0, object P1, object P2, object P3) => default; // 0x0000000187699C00-0x0000000187699D18
		public BeyondDynamicBone.RenderData __Gen_Wrap_41(object P0, int P1) => default; // 0x000000018769A8C4-0x000000018769A9D0
		public void __Gen_Wrap_42(object P0, ClothProcess.ClothType P1, object P2, object P3, object P4, RenderSetupData.BoneConnectionMode P5) {} // 0x000000018769B90C-0x000000018769BA34
		public ref TeamManager.TeamData __Gen_Wrap_43(object P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_43; // 0x000000018769C89C-0x000000018769C9A8
		private ref TeamManager.TeamData _refReturnTypeFor__Gen_Wrap_43; // Dummy field
		public bool __Gen_Wrap_44(ref TeamManager.TeamData P0) => default; // 0x000000018769D900-0x000000018769DB48
		public void __Gen_Wrap_45(object P0, int P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public void __Gen_Wrap_46(object P0, DataChunk P1, bool P2) {} // 0x000000018769F950-0x000000018769FA6C
		public bool __Gen_Wrap_47(ClothProcess P0) => default; // 0x0000000187678D18-0x0000000187678DD4
		public void __Gen_Wrap_48(object P0, NativeArray<BoneWeight> P1) {} // 0x00000001876A17B0-0x00000001876A18C4
		public void __Gen_Wrap_49(object P0, object P1, int P2) {} // 0x00000001876A23EC-0x00000001876A24E4
		public PreBuildManager.ShareDeserializationData __Gen_Wrap_50(object P0, object P1) => default; // 0x00000001876A3660-0x00000001876A3758
		public int __Gen_Wrap_51(object P0, object P1) => default; // 0x00000001876A48A4-0x00000001876A4990
		public void __Gen_Wrap_52(object P0, int P1, object P2) {} // 0x00000001876A5764-0x00000001876A585C
		public int __Gen_Wrap_53(object P0, object P1, ClothParameters P2) => default; // 0x00000001876A66AC-0x00000001876A685C
		public int __Gen_Wrap_54(object P0, object P1, in ClothParameters P2) => default; // 0x00000001876A7700-0x00000001876A78C4
		public Transform __Gen_Wrap_55(object P0, int P1) => default; // 0x00000001876A86BC-0x00000001876A87C8
		public DataChunk __Gen_Wrap_56(object P0, object P1, int P2) => default; // 0x00000001876A9294-0x00000001876A93B8
		public DataChunk __Gen_Wrap_57(object P0, int P1, int P2) => default; // 0x00000001876A93B8-0x00000001876A94DC
		public Vector3 __Gen_Wrap_58(object P0) => default; // 0x00000001876A94DC-0x00000001876A95F0
		public void __Gen_Wrap_59(object P0, object P1, ExBitFlag8 P2, int P3, int P4) {} // 0x00000001876A95F0-0x00000001876A972C
		public void __Gen_Wrap_60(object P0, object P1, object P2, int P3, int P4, int P5) {} // 0x00000001876A9898-0x00000001876A99BC
		public ref ClothParameters __Gen_Wrap_61(object P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_61; // 0x00000001876A99BC-0x00000001876A9AC8
		private ref ClothParameters _refReturnTypeFor__Gen_Wrap_61; // Dummy field
		public void __Gen_Wrap_62(object P0, int P1, TeamManager.TeamData P2, uint P3, int P4, int P5, int P6) {} // 0x00000001876A9AC8-0x00000001876A9CC4
		public void __Gen_Wrap_63(ref DataChunk P0) {} // 0x00000001876A9CC4-0x00000001876A9DEC
		public ref FixedList64Bytes<short> __Gen_Wrap_64(object P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_64; // 0x00000001876A9DEC-0x00000001876A9EF8
		private ref FixedList64Bytes<short> _refReturnTypeFor__Gen_Wrap_64; // Dummy field
		public Transform __Gen_Wrap_65(object P0) => default; // 0x00000001876A9EF8-0x00000001876A9FE8
		public DataChunk __Gen_Wrap_66(object P0, object P1, ExBitFlag8 P2, int P3) => default; // 0x00000001876A9FE8-0x00000001876AA130
		public DataChunk __Gen_Wrap_67(object P0, int P1, object P2) => default; // 0x00000001876AA130-0x00000001876AA254
		public void __Gen_Wrap_68(VirtualMeshContainer P0) {} // 0x0000000187678964-0x0000000187678A10
		public string __Gen_Wrap_69(ref ResultCode P0) => default; // 0x00000001876AA254-0x00000001876AA39C
		public NativeParallelMultiHashMap<int, ushort> __Gen_Wrap_70(in NativeArray<uint> P0, in NativeArray<ushort> P1) => default; // 0x00000001876AA48C-0x00000001876AA620
		public int __Gen_Wrap_71(int3 P0, int2 P1) => default; // 0x00000001876AA620-0x00000001876AA768
		public DistanceConstraint.ConstraintData __Gen_Wrap_72(object P0, in ClothParameters P1) => default; // 0x00000001876AA768-0x00000001876AA920
		public int2 __Gen_Wrap_73(int3 P0, int3 P1, int2 P2) => default; // 0x00000001876AA920-0x00000001876AAAA8
		public void __Gen_Wrap_74(object P0, int P1, int P2, int P3, int P4, out float P5, out sbyte P6) {
			P5 = default;
			P6 = default;
		} // 0x00000001876AAAA8-0x00000001876AAC28
		public int4 __Gen_Wrap_75(int P0, int P1, int P2, int P3) => default; // 0x00000001876AAC28-0x00000001876AAD6C
		public int4 __Gen_Wrap_76(int4 P0) => default; // 0x00000001876AAD6C-0x00000001876AAE9C
		public TriangleBendingConstraint.ConstraintData __Gen_Wrap_77(object P0, in ClothParameters P1) => default; // 0x00000001876AAE9C-0x00000001876AB054
		public void __Gen_Wrap_78(ref InertiaConstraint.CenterData P0) {} // 0x00000001876AB054-0x00000001876AB27C
		public InertiaConstraint.ConstraintData __Gen_Wrap_79(object P0, in ClothParameters P1) => default; // 0x00000001876AB27C-0x00000001876AB434
		public int __Gen_Wrap_80(object P0, object P1, int P2, byte P3, bool P4) => default; // 0x00000001876AB578-0x00000001876AB69C
		public void __Gen_Wrap_81(object P0, object P1, object P2) {} // 0x0000000187340E48-0x0000000187340F40
		public string __Gen_Wrap_82(object P0) => default; // 0x00000001876AB69C-0x00000001876AB78C
		public int[] __Gen_Wrap_83(object P0, object P1, object P2, object P3, object P4, NativeArray<float3> P5, NativeArray<quaternion> P6, NativeArray<float3> P7, NativeArray<quaternion> P8, NativeArray<float3> P9, NativeArray<quaternion> P10) => default; // 0x00000001876AB78C-0x00000001876ABA00
		public void __Gen_Wrap_84(NativeArray<int> P0, int P1) {} // 0x00000001876ABA00-0x00000001876ABB14
		public void __Gen_Wrap_85(NativeArray<VirtualMeshBoneWeight> P0, int P1, VirtualMeshBoneWeight P2) {} // 0x00000001876ABB14-0x00000001876ABC6C
		public int __Gen_Wrap_86(object P0, int P1, bool P2) => default; // 0x0000000187344878-0x000000018734497C
		public int3 __Gen_Wrap_87(int P0, int P1, int P2) => default; // 0x00000001876ABC6C-0x00000001876ABDA8
		public void __Gen_Wrap_88(NativeArray<float3> P0, int P1, NativeReference<AABB> P2) {} // 0x00000001876ABDA8-0x00000001876ABEF8
		public void __Gen_Wrap_89(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, NativeArray<float2> P3) {} // 0x00000001876ABEF8-0x00000001876AC080
		public void __Gen_Wrap_90(NativeArray<float3> P0, NativeArray<float3> P1, int P2, in float4x4 P3) {} // 0x00000001876AC1A8-0x00000001876AC34C
		public ResultCode __Gen_Wrap_91(object P0, object P1, object P2, object P3, out SelectionData P4) {
			P4 = default;
			return default;
		} // 0x00000001876AC34C-0x00000001876AC4D0
		public float __Gen_Wrap_92(ref AABB P0) => default; // 0x00000001876AC4D0-0x00000001876AC634
		public float __Gen_Wrap_93(object P0) => default; // 0x00000001876AC634-0x00000001876AC704
		public float __Gen_Wrap_94(object P0, object P1) => default; // 0x00000001876AC704-0x00000001876AC7F0
		public NativeArray<float3> __Gen_Wrap_95(object P0) => default; // 0x00000001876AC7F0-0x00000001876AC8FC
		public NativeArray<VertexAttribute> __Gen_Wrap_96(object P0) => default; // 0x00000001876AC8FC-0x00000001876ACA08
		public void __Gen_Wrap_97(NativeArray<float3> P0, int P1, in float4x4 P2) {} // 0x00000001876ACA08-0x00000001876ACB80
		public GridMap<int> __Gen_Wrap_98(float P0, in NativeArray<float3> P1, in NativeArray<VertexAttribute> P2, bool P3, bool P4, bool P5, bool P6) => default; // 0x00000001876ACB80-0x00000001876ACD50
		public void __Gen_Wrap_99(object P0, object P1, float4x4 P2, float P3) {} // 0x00000001876ACD50-0x00000001876ACEA4
		public bool __Gen_Wrap_100(object P0, object P1) => default; // 0x0000000187342174-0x0000000187342260
		public float4x4 __Gen_Wrap_101(object P0, object P1) => default; // 0x0000000187676DD0-0x0000000187676F10
		public int __Gen_Wrap_102(object P0, object P1, int P2, bool P3) => default; // 0x0000000187676F10-0x0000000187677024
		public void __Gen_Wrap_103(object P0, VertexAttribute P1) {} // 0x0000000187677024-0x0000000187677130
		public int __Gen_Wrap_104(object P0, int P1) => default; // 0x0000000187677130-0x000000018767721C
		public void __Gen_Wrap_105(NativeArray<int> P0, int P1, int P2) {} // 0x000000018767721C-0x0000000187677348
		public void __Gen_Wrap_106(object P0, object P1, CancellationToken P2) {} // 0x0000000187677348-0x0000000187677464
		public void __Gen_Wrap_107(NativeArray<quaternion> P0, int P1, quaternion P2) {} // 0x0000000187677464-0x00000001876775B4
		public float __Gen_Wrap_108(object P0, in int3 P1, in int3 P2, in int2 P3) => default; // 0x00000001876775B4-0x0000000187677774
		public bool __Gen_Wrap_109(object P0, in int3 P1, in int3 P2, in int2 P3, in float3 P4) => default; // 0x0000000187677774-0x0000000187677984
		public void __Gen_Wrap_110(object P0, NativeArray<float3> P1, float P2) {} // 0x0000000187677A74-0x0000000187677BA4
		public double3 __Gen_Wrap_111(ref AABB P0) => default; // 0x0000000187677BA4-0x0000000187677D3C
		public void __Gen_Wrap_112(object P0, object P1, object P2, object P3, object P4) {} // 0x0000000187677D3C-0x0000000187677E54
		public GridMap<int> __Gen_Wrap_113(object P0, float P1) => default; // 0x0000000187677E54-0x0000000187677F64
		public ResultCode __Gen_Wrap_114(object P0, object P1) => default; // 0x0000000187677F64-0x0000000187678070
		public SelectionData __Gen_Wrap_115(object P0) => default; // 0x0000000187678070-0x0000000187678160
		public void __Gen_Wrap_116() {} // 0x0000000187678160-0x00000001876781FC
		public void __Gen_Wrap_117(object P0, DataChunk P1) {} // 0x00000001876781FC-0x000000018767830C
		public void __Gen_Wrap_118(object P0, int P1, int P2) {} // 0x000000018767830C-0x0000000187678404
		public void __Gen_Wrap_119(object P0, ref TeamManager.TeamData P1, int P2) {} // 0x0000000187678404-0x000000018767866C
		public System.Threading.Tasks.Task __Gen_Wrap_120(object P0, CancellationToken P1) => default; // 0x0000000187678764-0x0000000187678884
		public void __Gen_Wrap_121(object P0, float P1) {} // 0x0000000187678884-0x0000000187678964
		public void __Gen_Wrap_122(Transform P0) {} // 0x0000000187678964-0x0000000187678A10
		public void __Gen_Wrap_123(RenderSetupData.UniqueSerializationData P0) {} // 0x0000000187678964-0x0000000187678A10
		public void __Gen_Wrap_124(VirtualMesh.UniqueSerializationData P0) {} // 0x0000000187678964-0x0000000187678A10
		public void __Gen_Wrap_125(int P0) {} // 0x00000001872E71D4-0x00000001872E7280
		public void __Gen_Wrap_126(TransformRecord P0) {} // 0x0000000187678964-0x0000000187678A10
		public void __Gen_Wrap_127(object P0, bool P1) {} // 0x0000000187678A10-0x0000000187678AEC
		public ref InertiaConstraint.CenterData __Gen_Wrap_128(object P0, int P1) => ref _refReturnTypeFor__Gen_Wrap_128; // 0x0000000187678AEC-0x0000000187678BE4
		private ref InertiaConstraint.CenterData _refReturnTypeFor__Gen_Wrap_128; // Dummy field
		public void __Gen_Wrap_129(object P0, Vector3 P1, float P2, ClothForceMode P3) {} // 0x0000000187678BE4-0x0000000187678D18
		public void __Gen_Wrap_130(object P0, bool P1, float P2) {} // 0x0000000187678DD4-0x0000000187678EB8
		public CheckSliderSerializeData __Gen_Wrap_131(object P0) => default; // 0x0000000187678EB8-0x0000000187678FA8
		public BitField32 __Gen_Wrap_132(object P0) => default; // 0x0000000187678FA8-0x0000000187679084
		public ClothProcess.RenderMeshInfo __Gen_Wrap_133(object P0, int P1) => default; // 0x0000000187679084-0x000000018767917C
		public ClothUpdateMode __Gen_Wrap_134(object P0) => default; // 0x000000018767917C-0x0000000187679238
		public void __Gen_Wrap_135(ref ClothProcess.GenerateSelectionJob P0, int P1) {} // 0x0000000187679238-0x000000018767943C
		public ReductionSettings __Gen_Wrap_136(object P0) => default; // 0x000000018767943C-0x000000018767952C
		public CustomSkinningSettings __Gen_Wrap_137(object P0) => default; // 0x000000018767952C-0x000000018767961C
		public NormalAlignmentSettings __Gen_Wrap_138(object P0) => default; // 0x000000018767961C-0x000000018767970C
		public CullingSettings __Gen_Wrap_139(object P0) => default; // 0x000000018767970C-0x00000001876797FC
		public CurveSerializeData __Gen_Wrap_140(object P0) => default; // 0x00000001876797FC-0x00000001876798EC
		public InertiaConstraint.SerializeData __Gen_Wrap_141(object P0) => default; // 0x00000001876798EC-0x00000001876799DC
		public TetherConstraint.SerializeData __Gen_Wrap_142(object P0) => default; // 0x00000001876799DC-0x0000000187679ACC
		public DistanceConstraint.SerializeData __Gen_Wrap_143(object P0) => default; // 0x0000000187679ACC-0x0000000187679BBC
		public TriangleBendingConstraint.SerializeData __Gen_Wrap_144(object P0) => default; // 0x0000000187679BBC-0x0000000187679CAC
		public AngleConstraint.RestorationSerializeData __Gen_Wrap_145(object P0) => default; // 0x0000000187679CAC-0x0000000187679D9C
		public AngleConstraint.LimitSerializeData __Gen_Wrap_146(object P0) => default; // 0x0000000187679D9C-0x0000000187679E8C
		public MotionConstraint.SerializeData __Gen_Wrap_147(object P0) => default; // 0x0000000187679E8C-0x0000000187679F7C
		public ColliderCollisionConstraint.SerializeData __Gen_Wrap_148(object P0) => default; // 0x0000000187679F7C-0x000000018767A06C
		public SelfCollisionConstraint.SerializeData __Gen_Wrap_149(object P0) => default; // 0x000000018767A06C-0x000000018767A15C
		public WindSettings __Gen_Wrap_150(object P0) => default; // 0x000000018767A24C-0x000000018767A33C
		public void __Gen_Wrap_151(object P0, object P1, bool P2) {} // 0x000000018767A33C-0x000000018767A434
		public ColliderManager.ColliderType __Gen_Wrap_152(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public void __Gen_Wrap_153(object P0, Vector3 P1) {} // 0x000000018767A434-0x000000018767A550
		public void __Gen_Wrap_154(object P0, float P1, float P2, float P3) {} // 0x000000018767A550-0x000000018767A64C
		public ClothProcess __Gen_Wrap_155(object P0, int P1) => default; // 0x000000018767A64C-0x000000018767A744
		public void __Gen_Wrap_156(object P0, object P1, int P2, bool P3) {} // 0x000000018767A744-0x000000018767A83C
		public JobHandle __Gen_Wrap_157(object P0, JobHandle P1) => default; // 0x000000018767A83C-0x000000018767A978
		public void __Gen_Wrap_158(ref AngleConstraint.AngleConstraintJob P0, NativeReference<int> P1) {} // 0x000000018767A978-0x000000018767ABD8
		public bool __Gen_Wrap_159(in double3 P0, in double3 P1, double P2, out double3 P3) {
			P3 = default;
			return default;
		} // 0x000000018767ABD8-0x000000018767ADA8
		public quaternion __Gen_Wrap_160(in double3 P0, in double3 P1, double P2) => default; // 0x000000018767AEE0-0x000000018767B07C
		public void __Gen_Wrap_161(ref AngleConstraint.AngleConstraintJob P0, int P1) {} // 0x000000018767B07C-0x000000018767B2B4
		public void __Gen_Wrap_162(ref AngleConstraint.AngleConstraintJob P0) {} // 0x000000018767B2B4-0x000000018767B4D8
		public double __Gen_Wrap_163(ref double3 P0, in double3 P1, float P2, in AABB P3, in ColliderManager.WorkData P4, bool P5, float P6, out float3 P7) {
			P7 = default;
			return default;
		} // 0x000000018767B4D8-0x000000018767B828
		public double __Gen_Wrap_164(ref double3 P0, float P1, in ColliderManager.WorkData P2, out float3 P3) {
			P3 = default;
			return default;
		} // 0x000000018767B828-0x000000018767BAAC
		public double __Gen_Wrap_165(ref double3 P0, float P1, in AABB P2, in ColliderManager.WorkData P3, out float3 P4) {
			P4 = default;
			return default;
		} // 0x000000018767BAAC-0x000000018767BD8C
		public float __Gen_Wrap_166(ref double3x2 P0, in double2 P1, in AABB P2, double P3, in ColliderManager.WorkData P4, out float3 P5) {
			P5 = default;
			return default;
		} // 0x000000018767BD8C-0x000000018767C0C4
		public double __Gen_Wrap_167(ref double3x2 P0, in double2 P1, in AABB P2, double P3, in ColliderManager.WorkData P4, out float3 P5) {
			P5 = default;
			return default;
		} // 0x000000018767C0C4-0x000000018767C3FC
		public double __Gen_Wrap_168(ref double3x2 P0, in double2 P1, in ColliderManager.WorkData P2, out float3 P3) {
			P3 = default;
			return default;
		} // 0x000000018767C3FC-0x000000018767C6C4
		public void __Gen_Wrap_169(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, NativeReference<int> P1) {} // 0x000000018767C6C4-0x000000018767C91C
		public double __Gen_Wrap_170(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, in double3 P2, double P3, in AABB P4, in ColliderManager.WorkData P5, bool P6, double P7, out float3 P8) {
			P8 = default;
			return default;
		} // 0x000000018767CA74-0x000000018767CF28
		public double __Gen_Wrap_171(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, double P2, in AABB P3, in ColliderManager.WorkData P4, out float3 P5) {
			P5 = default;
			return default;
		} // 0x000000018767CF28-0x000000018767D370
		public double __Gen_Wrap_172(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, ref double3 P1, double P2, in ColliderManager.WorkData P3, out float3 P4) {
			P4 = default;
			return default;
		} // 0x000000018767D370-0x000000018767D758
		public void __Gen_Wrap_173(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0, int P1) {} // 0x000000018767D758-0x000000018767D98C
		public void __Gen_Wrap_174(ref ColliderCollisionConstraint.PointColliderCollisionConstraintJob P0) {} // 0x000000018767D98C-0x000000018767DBA4
		public void __Gen_Wrap_175(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, NativeReference<int> P1) {} // 0x000000018767DBA4-0x000000018767DDD4
		public double __Gen_Wrap_176(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, ref double3x2 P1, in double2 P2, in AABB P3, float P4, in ColliderManager.WorkData P5, out float3 P6) {
			P6 = default;
			return default;
		} // 0x000000018767DDD4-0x000000018767E248
		public double __Gen_Wrap_177(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, ref double3x2 P1, in double2 P2, in ColliderManager.WorkData P3, out float3 P4) {
			P4 = default;
			return default;
		} // 0x000000018767E248-0x000000018767E648
		public void __Gen_Wrap_178(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0, int P1) {} // 0x000000018767E648-0x000000018767E850
		public void __Gen_Wrap_179(ref ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob P0) {} // 0x000000018767E850-0x000000018767EA44
		public void __Gen_Wrap_180(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0, NativeReference<int> P1) {} // 0x000000018767EB34-0x000000018767ED54
		public float3 __Gen_Wrap_181(int P0, in NativeArray<int> P1, in NativeArray<int> P2) => default; // 0x000000018767ED54-0x000000018767EEE4
		public float __Gen_Wrap_182(int P0, in NativeArray<int> P1) => default; // 0x000000018767EEE4-0x000000018767F004
		public float3 __Gen_Wrap_183(int P0, in NativeArray<int> P1) => default; // 0x000000018767F004-0x000000018767F15C
		public void __Gen_Wrap_184(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0, int P1) {} // 0x000000018767F15C-0x000000018767F354
		public void __Gen_Wrap_185(ref ColliderCollisionConstraint.SolveEdgeBufferAndClearJob P0) {} // 0x000000018767F354-0x000000018767F534
		public void __Gen_Wrap_186(ref DistanceConstraint.DistanceConstraintJob P0, NativeReference<int> P1) {} // 0x000000018767F534-0x000000018767F7A0
		public void __Gen_Wrap_187(ref DistanceConstraint.DistanceConstraintJob P0, int P1) {} // 0x000000018767F7A0-0x000000018767F9E4
		public void __Gen_Wrap_188(ref DistanceConstraint.DistanceConstraintJob P0) {} // 0x000000018767F9E4-0x000000018767FC0C
		public void __Gen_Wrap_189(ref MotionConstraint.MotionConstraintJob P0, NativeReference<int> P1) {} // 0x000000018767FC0C-0x000000018767FE54
		public void __Gen_Wrap_190(ref MotionConstraint.MotionConstraintJob P0, int P1) {} // 0x000000018767FF78-0x000000018768019C
		public void __Gen_Wrap_191(ref MotionConstraint.MotionConstraintJob P0) {} // 0x000000018768019C-0x00000001876803A4
		public int __Gen_Wrap_192(ref NativeArray<SelfCollisionConstraint.SortData> P0, in SelfCollisionConstraint.SortData P1, in DataChunk P2) => default; // 0x00000001876803A4-0x0000000187680580
		public JobHandle __Gen_Wrap_193(in NativeArray<int> P0, in NativeReference<int> P1, float P2, JobHandle P3) => default; // 0x0000000187680580-0x000000018768074C
		public JobHandle __Gen_Wrap_194(in ExProcessingList<int> P0, float P1, JobHandle P2) => default; // 0x000000018768074C-0x00000001876808B0
		public JobHandle __Gen_Wrap_195(object P0, int P1, JobHandle P2) => default; // 0x00000001876808B0-0x00000001876809FC
		public JobHandle __Gen_Wrap_196(NativeArray<byte> P0, int P1, byte P2, JobHandle P3) => default; // 0x00000001876809FC-0x0000000187680B80
		public int __Gen_Wrap_197(ref SelfCollisionConstraint.SortData P0, SelfCollisionConstraint.SortData P1) => default; // 0x0000000187680B80-0x0000000187680D30
		public string __Gen_Wrap_198(ref SelfCollisionConstraint.EdgeEdgeContact P0) => default; // 0x0000000187680D30-0x0000000187680EA4
		public string __Gen_Wrap_199(ref SelfCollisionConstraint.PointTriangleContact P0) => default; // 0x0000000187680EA4-0x0000000187681000
		public void __Gen_Wrap_200(ref SelfCollisionConstraint.InitPrimitiveJob P0, int P1) {} // 0x000000018768115C-0x0000000187681374
		public void __Gen_Wrap_201(ref SelfCollisionConstraint.ClearBufferJob P0) {} // 0x0000000187681374-0x00000001876814B4
		public void __Gen_Wrap_202(ref SelfCollisionConstraint.UpdatePrimitiveJob P0, NativeReference<int> P1) {} // 0x00000001876814B4-0x00000001876816EC
		public void __Gen_Wrap_203(ref SelfCollisionConstraint.UpdatePrimitiveJob P0, int P1) {} // 0x00000001876816EC-0x0000000187681900
		public void __Gen_Wrap_204(ref SelfCollisionConstraint.UpdatePrimitiveJob P0) {} // 0x0000000187681900-0x0000000187681AF8
		public void __Gen_Wrap_205(ref SelfCollisionConstraint.SortJob P0, int P1) {} // 0x0000000187681AF8-0x0000000187681C68
		public void __Gen_Wrap_206(ref SelfCollisionConstraint.SortJob P0) {} // 0x0000000187681C68-0x0000000187681DBC
		public void __Gen_Wrap_207(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, NativeReference<int> P1) {} // 0x0000000187681DBC-0x0000000187682004
		public void __Gen_Wrap_208(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2, float P3, float P4, float P5) {} // 0x0000000187682004-0x00000001876824C8
		public void __Gen_Wrap_209(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, int P1, ref SelfCollisionConstraint.Primitive P2, in SelfCollisionConstraint.SortData P3, in DataChunk P4, bool P5) {} // 0x00000001876824C8-0x00000001876828FC
		public void __Gen_Wrap_210(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0, int P1) {} // 0x00000001876829EC-0x0000000187682C10
		public void __Gen_Wrap_211(ref SelfCollisionConstraint.PointTriangleBroadPhaseJob P0) {} // 0x0000000187682C10-0x0000000187682E18
		public void __Gen_Wrap_212(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, NativeReference<int> P1) {} // 0x0000000187682E18-0x0000000187682FFC
		public void __Gen_Wrap_213(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2, float P3, float P4) {} // 0x0000000187682FFC-0x0000000187683450
		public void __Gen_Wrap_214(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, int P1, ref SelfCollisionConstraint.Primitive P2, in SelfCollisionConstraint.SortData P3, in DataChunk P4, bool P5) {} // 0x0000000187683450-0x000000018768381C
		public void __Gen_Wrap_215(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0, int P1) {} // 0x000000018768381C-0x00000001876839DC
		public void __Gen_Wrap_216(ref SelfCollisionConstraint.EdgeEdgeBroadPhaseJob P0) {} // 0x00000001876839DC-0x0000000187683B80
		public void __Gen_Wrap_217(ref SelfCollisionConstraint.EdgeEdgeToListJob P0) {} // 0x0000000187683B80-0x0000000187683CC4
		public void __Gen_Wrap_218(ref SelfCollisionConstraint.PointTriangleToListJob P0) {} // 0x0000000187683CC4-0x0000000187683E08
		public void __Gen_Wrap_219(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseJob P0, int P1) {} // 0x0000000187683E08-0x0000000187683F64
		public void __Gen_Wrap_220(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseJob P0, int P1) {} // 0x00000001876840E4-0x0000000187684240
		public void __Gen_Wrap_221(ref SelfCollisionConstraint.SolverEdgeEdgeJob P0, int P1) {} // 0x0000000187684240-0x00000001876843AC
		public void __Gen_Wrap_222(ref SelfCollisionConstraint.SolverPointTriangleJob P0, int P1) {} // 0x00000001876843AC-0x0000000187684518
		public void __Gen_Wrap_223(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0, NativeReference<int> P1) {} // 0x0000000187684518-0x00000001876846CC
		public void __Gen_Wrap_224(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0, int P1) {} // 0x00000001876846CC-0x000000018768485C
		public void __Gen_Wrap_225(ref SelfCollisionConstraint.IntersectUpdatePrimitiveJob P0) {} // 0x000000018768485C-0x00000001876849D0
		public void __Gen_Wrap_226(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, NativeReference<int> P1) {} // 0x00000001876849D0-0x0000000187684BA0
		public void __Gen_Wrap_227(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, ref SelfCollisionConstraint.Primitive P1, ref SelfCollisionConstraint.Primitive P2) {} // 0x0000000187684BA0-0x0000000187684FB4
		public void __Gen_Wrap_228(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, ref SelfCollisionConstraint.Primitive P1, in SelfCollisionConstraint.SortData P2, in DataChunk P3, bool P4) {} // 0x0000000187684FB4-0x000000018768535C
		public void __Gen_Wrap_229(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0, int P1) {} // 0x000000018768535C-0x00000001876854F8
		public void __Gen_Wrap_230(ref SelfCollisionConstraint.IntersectEdgeTriangleJob P0) {} // 0x000000018768564C-0x00000001876857CC
		public void __Gen_Wrap_231(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob P0, int P1) {} // 0x00000001876857CC-0x0000000187685938
		public void __Gen_Wrap_232(ref SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob P0) {} // 0x0000000187685938-0x0000000187685A88
		public void __Gen_Wrap_233(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob P0, int P1) {} // 0x0000000187685A88-0x0000000187685BF4
		public void __Gen_Wrap_234(ref SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob P0) {} // 0x0000000187685BF4-0x0000000187685D44
		public void __Gen_Wrap_235(ref SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob P0, int P1) {} // 0x0000000187685D44-0x0000000187685EB0
		public void __Gen_Wrap_236(ref SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob P0) {} // 0x0000000187685EB0-0x0000000187686000
		public void __Gen_Wrap_237(ref SelfCollisionConstraint.SolverPointTriangleCrossFrameJob P0, int P1) {} // 0x0000000187686000-0x000000018768616C
		public void __Gen_Wrap_238(ref SelfCollisionConstraint.SolverPointTriangleCrossFrameJob P0) {} // 0x000000018768616C-0x00000001876862BC
		public SpringConstraint.SerializeData __Gen_Wrap_239(object P0) => default; // 0x00000001876862BC-0x0000000187686398
		public void __Gen_Wrap_240(ref TetherConstraint.TethreConstraintJob P0, NativeReference<int> P1) {} // 0x000000018768653C-0x0000000187686784
		public void __Gen_Wrap_241(ref TetherConstraint.TethreConstraintJob P0, int P1) {} // 0x0000000187686784-0x00000001876869A8
		public void __Gen_Wrap_242(ref TetherConstraint.TethreConstraintJob P0) {} // 0x00000001876869A8-0x0000000187686BB0
		public bool __Gen_Wrap_243(in double3x4 P0, in double4 P1, double P2, double P3, ref double3x4 P4) => default; // 0x0000000187686BB0-0x0000000187686E30
		public bool __Gen_Wrap_244(double P0, in double3x4 P1, in double4 P2, double P3, double P4, ref double3x4 P5) => default; // 0x0000000187686E30-0x00000001876870C8
		public void __Gen_Wrap_245(ref TriangleBendingConstraint.TriangleBendingJob P0, NativeReference<int> P1) {} // 0x00000001876870C8-0x0000000187687334
		public bool __Gen_Wrap_246(ref TriangleBendingConstraint.TriangleBendingJob P0, in double3x4 P1, in double4 P2, double P3, double P4, ref double3x4 P5) => default; // 0x0000000187687334-0x0000000187687728
		public bool __Gen_Wrap_247(ref TriangleBendingConstraint.TriangleBendingJob P0, double P1, in double3x4 P2, in double4 P3, double P4, double P5, ref double3x4 P6) => default; // 0x0000000187687728-0x0000000187687B38
		public void __Gen_Wrap_248(ref TriangleBendingConstraint.TriangleBendingJob P0, int P1) {} // 0x0000000187687B38-0x0000000187687D7C
		public void __Gen_Wrap_249(ref TriangleBendingConstraint.TriangleBendingJob P0) {} // 0x0000000187687D7C-0x0000000187687FA4
		public void __Gen_Wrap_250(ref TriangleBendingConstraint.SolveAggregateBufferJob P0, NativeReference<int> P1) {} // 0x00000001876880E8-0x00000001876882C8
		public void __Gen_Wrap_251(ref TriangleBendingConstraint.SolveAggregateBufferJob P0, int P1) {} // 0x00000001876882C8-0x0000000187688484
		public void __Gen_Wrap_252(ref TriangleBendingConstraint.SolveAggregateBufferJob P0) {} // 0x0000000187688484-0x0000000187688624
		public void __Gen_Wrap_253(object P0, float P1, float P2, float P3, bool P4) {} // 0x0000000187688624-0x0000000187688734
		public void __Gen_Wrap_254(object P0, float P1, object P2) {} // 0x0000000187688734-0x0000000187688818
		public NativeArray<float3> __Gen_Wrap_255(object P0, float4x4 P1) => default; // 0x0000000187688818-0x000000018768896C
		public void __Gen_Wrap_256(ref SelectionData.TransformPositionJob P0, int P1) {} // 0x000000018768896C-0x0000000187688AE8
		public void __Gen_Wrap_257(ref SelectionData.CreateGridMapJob P0) {} // 0x0000000187688AE8-0x0000000187688C38
		public void __Gen_Wrap_258(ref SelectionData.ConvertSelectionJob P0, int P1) {} // 0x0000000187688C38-0x0000000187688DC8
		public Vector3 __Gen_Wrap_259(object P0, bool P1) => default; // 0x0000000187688DC8-0x0000000187688EE8
		public void __Gen_Wrap_260(object P0, Vector3 P1, bool P2) {} // 0x0000000187689108-0x000000018768922C
		public bool __Gen_Wrap_261(ref WindParams P0) => default; // 0x000000018768922C-0x000000018768937C
		public bool __Gen_Wrap_262(object P0, object P1, object P2) => default; // 0x000000018768937C-0x0000000187689470
		public bool __Gen_Wrap_263(object P0, object P1, int P2, int P3) => default; // 0x0000000187689470-0x0000000187689578
		public void __Gen_Wrap_264(object P0, object P1, TransformAccessArray P2) {} // 0x0000000187689578-0x0000000187689694
		public DataChunk __Gen_Wrap_265(object P0, DataChunk P1, int P2) => default; // 0x0000000187689694-0x00000001876897BC
		public float __Gen_Wrap_266() => default; // 0x000000018735B7F8-0x000000018735B890
		public JobHandle __Gen_Wrap_267(object P0, JobHandle P1, ref NativeParallelHashMap<int, int> P2, ref NativeParallelHashMap<int, AnimationTransformRWBufferHandle> P3, ref NativeParallelHashMap<int, int> P4) => default; // 0x00000001876897BC-0x0000000187689A4C
		public void __Gen_Wrap_268(ref DynamicBoneTransformManager.ValidTransformJob P0, int P1) {} // 0x0000000187689A4C-0x0000000187689BDC
		public JobHandle __Gen_Wrap_269(object P0, int P1, int P2, JobHandle P3) => default; // 0x0000000187689BDC-0x0000000187689D38
		public JobHandle __Gen_Wrap_270(object P0, bool P1, DataChunk P2, JobHandle P3) => default; // 0x0000000187689F44-0x000000018768A0BC
		public JobHandle __Gen_Wrap_271(object P0, DataChunk P1, JobHandle P2) => default; // 0x000000018768A0BC-0x000000018768A220
		public VirtualMeshContainer __Gen_Wrap_272(object P0) => default; // 0x000000018768A220-0x000000018768A2FC
		public VirtualMeshContainer __Gen_Wrap_273(object P0, int P1) => default; // 0x000000018768A2FC-0x000000018768A3F4
		public void __Gen_Wrap_274(ref DoAllInOneJob P0) {} // 0x000000018768A3F4-0x000000018768A534
		public void __Gen_Wrap_275(ref DynamicBoneTransformManager.ReadAnimatorBufferDataJob P0, int P1, TransformAccess P2) {} // 0x000000018768A534-0x000000018768A780
		public void __Gen_Wrap_276(ref DynamicBoneTransformManager.WriteAnimatorBufferDataJob P0) {} // 0x000000018768A780-0x000000018768A960
		public void __Gen_Wrap_277(ref DynamicBoneTransformManager.CopyDoubleBufferJob P0) {} // 0x000000018768A960-0x000000018768AB00
		public void __Gen_Wrap_278(ref DynamicBoneTransformManager.EnableTransformJob P0) {} // 0x000000018768AB00-0x000000018768AC30
		public void __Gen_Wrap_279(ref DynamicBoneTransformManager.RestoreTransformJob P0, int P1, TransformAccess P2) {} // 0x000000018768AC30-0x000000018768ADEC
		public void __Gen_Wrap_280(ref DynamicBoneTransformManager.ReadTransformJob P0, int P1, TransformAccess P2) {} // 0x000000018768AFA4-0x000000018768B1C4
		public void __Gen_Wrap_281(ref DynamicBoneTransformManager.ValidTransformJob P0) {} // 0x000000018768B1C4-0x000000018768B338
		public void __Gen_Wrap_282(ref DynamicBoneTransformManager.WriteTransformJob P0, int P1, TransformAccess P2) {} // 0x000000018768B338-0x000000018768B524
		public void __Gen_Wrap_283(ref DynamicBoneTransformManager.ReadComponentTransformJob P0, int P1, TransformAccess P2) {} // 0x000000018768B524-0x000000018768B6A0
		public void __Gen_Wrap_284(ClothProcess P0) {} // 0x0000000187678964-0x0000000187678A10
		public string __Gen_Wrap_285(ref TeamWindInfo P0) => default; // 0x000000018768B6A0-0x000000018768B7F4
		public bool __Gen_Wrap_286(ref TeamManager.MappingData P0) => default; // 0x000000018768B7F4-0x000000018768B9DC
		public void __Gen_Wrap_287(ref TeamManager.AlwaysTeamUpdatePreJob P0) {} // 0x000000018768B9DC-0x000000018768BB7C
		public void __Gen_Wrap_288(ref TeamManager.AlwaysTeamUpdatePostJob P0, int P1, ref TeamManager.TeamData P2) {} // 0x000000018768BB7C-0x000000018768BF34
		public void __Gen_Wrap_289(ref TeamManager.AlwaysTeamUpdatePostJob P0) {} // 0x000000018768BF34-0x000000018768C16C
		public void __Gen_Wrap_290(ref TeamManager.CalcCenterAndInertiaAndWindJob P0, int P1) {} // 0x000000018768C324-0x000000018768C558
		public double3 __Gen_Wrap_291(in double3 P0, in double3 P1, in double3 P2, in quaternion P3) => default; // 0x000000018768C558-0x000000018768C774
		public bool __Gen_Wrap_292(ref WindManager.WindData P0) => default; // 0x000000018768C774-0x000000018768C998
		public bool __Gen_Wrap_293(ref TeamWindInfo P0) => default; // 0x000000018768C998-0x000000018768CADC
		public int __Gen_Wrap_294(ref TeamWindData P0, int P1) => default; // 0x000000018768CADC-0x000000018768CCE4
		public void __Gen_Wrap_295(ref TeamWindData P0, TeamWindInfo P1, in TeamWindData P2) {} // 0x000000018768CCE4-0x000000018768CFA0
		public void __Gen_Wrap_296(ref TeamWindData P0, int P1) {} // 0x000000018768CFA0-0x000000018768D198
		public void __Gen_Wrap_297(ref TeamManager.CalcCenterAndInertiaAndWindJob P0, int P1, in ClothParameters P2, in double3 P3) {} // 0x000000018768D198-0x000000018768D4D0
		public void __Gen_Wrap_298(ref TeamManager.CalcCenterAndInertiaAndWindJob P0) {} // 0x000000018768D4D0-0x000000018768D6E8
		public void __Gen_Wrap_299(ref TeamManager.SimulationStepTeamUpdateJob P0, int P1) {} // 0x000000018768D6E8-0x000000018768D864
		public void __Gen_Wrap_300(ref TeamManager.SimulationStepTeamUpdateJob P0, ref TeamWindInfo P1, float P2, float P3) {} // 0x000000018768DAD8-0x000000018768DCF4
		public void __Gen_Wrap_301(ref TeamManager.SimulationStepTeamUpdateJob P0, int P1, in TeamManager.TeamData P2, in WindParams P3, in InertiaConstraint.CenterData P4) {} // 0x000000018768DCF4-0x000000018768E05C
		public void __Gen_Wrap_302(ref TeamManager.SimulationStepTeamUpdateJob P0) {} // 0x000000018768E05C-0x000000018768E1BC
		public void __Gen_Wrap_303(ref TeamManager.PostTeamUpdateJob P0, int P1) {} // 0x000000018768E1BC-0x000000018768E31C
		public void __Gen_Wrap_304(ref TeamManager.PostTeamUpdateJob P0) {} // 0x000000018768E31C-0x000000018768E460
		public void __Gen_Wrap_305(ref VirtualMeshManager.ClearProxyMeshUpdateBufferJob P0) {} // 0x000000018768E460-0x000000018768E5B0
		public void __Gen_Wrap_306(ref VirtualMeshManager.CreateProxyMeshUpdateVertexList P0, int P1) {} // 0x000000018768E5B0-0x000000018768E720
		public int __Gen_Wrap_307(ref NativeReference<int> P0, int P1) => default; // 0x000000018768E720-0x000000018768E86C
		public void __Gen_Wrap_308(ref VirtualMeshManager.CreateProxyMeshUpdateVertexList P0) {} // 0x000000018768E86C-0x000000018768E9C0
		public void __Gen_Wrap_309(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0, NativeReference<int> P1) {} // 0x000000018768E9C0-0x000000018768EC18
		public int __Gen_Wrap_310(ref VirtualMeshBoneWeight P0) => default; // 0x000000018768ED80-0x000000018768EEC0
		public void __Gen_Wrap_311(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0, int P1) {} // 0x000000018768EEC0-0x000000018768F0F4
		public void __Gen_Wrap_312(ref VirtualMeshManager.CalcProxyMeshSkinningJob P0) {} // 0x000000018768F0F4-0x000000018768F30C
		public void __Gen_Wrap_313(ref VirtualMeshManager.CreatePostProxyMeshUpdateListJob P0, int P1) {} // 0x000000018768F30C-0x000000018768F504
		public void __Gen_Wrap_314(ref VirtualMeshManager.CreatePostProxyMeshUpdateListJob P0) {} // 0x000000018768F504-0x000000018768F6E0
		public void __Gen_Wrap_315(ref VirtualMeshManager.CalcLineNormalTangentJob P0, NativeReference<int> P1) {} // 0x000000018768F6E0-0x000000018768F900
		public void __Gen_Wrap_316(ref VirtualMeshManager.CalcLineNormalTangentJob P0, int P1) {} // 0x000000018768F900-0x000000018768FAF8
		public void __Gen_Wrap_317(ref VirtualMeshManager.CalcLineNormalTangentJob P0) {} // 0x000000018768FAF8-0x000000018768FCDC
		public void __Gen_Wrap_318(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0, NativeReference<int> P1) {} // 0x000000018768FCDC-0x000000018768FEE8
		public double3 __Gen_Wrap_319(in double3 P0, in double3 P1, in double3 P2, in float2 P3, in float2 P4, in float2 P5) => default; // 0x000000018768FEE8-0x0000000187690174
		public void __Gen_Wrap_320(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0, int P1) {} // 0x00000001876902F8-0x00000001876904DC
		public void __Gen_Wrap_321(ref VirtualMeshManager.CalcTriangleNormalTangentJob P0) {} // 0x00000001876904DC-0x00000001876906A4
		public void __Gen_Wrap_322(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0, NativeReference<int> P1) {} // 0x00000001876906A4-0x00000001876908B0
		public void __Gen_Wrap_323(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0, int P1) {} // 0x00000001876908B0-0x0000000187690A94
		public void __Gen_Wrap_324(ref VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob P0) {} // 0x0000000187690A94-0x0000000187690C5C
		public void __Gen_Wrap_325(ref VirtualMeshManager.WriteTransformDataJob P0, NativeReference<int> P1) {} // 0x0000000187690C5C-0x0000000187690E68
		public void __Gen_Wrap_326(ref VirtualMeshManager.WriteTransformDataJob P0, int P1) {} // 0x0000000187690E68-0x000000018769104C
		public void __Gen_Wrap_327(ref VirtualMeshManager.WriteTransformDataJob P0) {} // 0x000000018769104C-0x0000000187691214
		public void __Gen_Wrap_328(ref VirtualMeshManager.WriteTransformLocalDataJob P0, NativeReference<int> P1) {} // 0x0000000187691214-0x0000000187691444
		public void __Gen_Wrap_329(ref VirtualMeshManager.WriteTransformLocalDataJob P0, int P1) {} // 0x0000000187691444-0x000000018769164C
		public void __Gen_Wrap_330(ref VirtualMeshManager.WriteTransformLocalDataJob P0) {} // 0x000000018769173C-0x0000000187691928
		public void __Gen_Wrap_331(ref VirtualMeshManager.CalcMeshConvertMatrixJob P0, int P1) {} // 0x0000000187691928-0x0000000187691AB8
		public void __Gen_Wrap_332(ref VirtualMeshManager.CalcMeshConvertMatrixJob P0) {} // 0x0000000187691AB8-0x0000000187691C2C
		public void __Gen_Wrap_333(ref VirtualMeshManager.CalcProxySkinningJob P0, int P1) {} // 0x0000000187691C2C-0x0000000187691E80
		public void __Gen_Wrap_334(ref VirtualMeshManager.CalcProxySkinningJob P0) {} // 0x0000000187691E80-0x00000001876920B8
		public bool __Gen_Wrap_335(PlayerLoopSystem P0) => default; // 0x00000001876920B8-0x00000001876921BC
		public bool __Gen_Wrap_336(ref PlayerLoopSystem P0) => default; // 0x00000001876921BC-0x0000000187692318
		public void __Gen_Wrap_337(PlayerLoopSystem P0, ref PlayerLoopSystem P1, object P2, object P3, bool P4, bool P5) {} // 0x0000000187692318-0x00000001876924F0
		public void __Gen_Wrap_338(ref PlayerLoopSystem P0) {} // 0x00000001876924F0-0x000000018769263C
		public void __Gen_Wrap_339(bool P0) {} // 0x000000018769263C-0x00000001876926E8
		public void __Gen_Wrap_340(float P0) {} // 0x00000001876927D8-0x0000000187692884
		public void __Gen_Wrap_341(bool P0, float P1) {} // 0x0000000187692884-0x0000000187692950
		public int __Gen_Wrap_342() => default; // 0x0000000187352750-0x00000001873527E8
		public void __Gen_Wrap_343(TimeManager.UpdateLocation P0) {} // 0x00000001872E71D4-0x00000001872E7280
		public TimeManager.UpdateLocation __Gen_Wrap_344() => default; // 0x0000000187352750-0x00000001873527E8
		public void __Gen_Wrap_345(MagicaManager.InitializationLocation P0) {} // 0x00000001872E71D4-0x00000001872E7280
		public void __Gen_Wrap_346(ref BeyondDynamicBone.RenderData.UpdatePositionNormalJob P0, int P1) {} // 0x0000000187692950-0x0000000187692AEC
		public void __Gen_Wrap_347(ref BeyondDynamicBone.RenderData.UpdatePositionNormalJob P0) {} // 0x0000000187692AEC-0x0000000187692C6C
		public void __Gen_Wrap_348(ref BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob P0, int P1) {} // 0x0000000187692C6C-0x0000000187692E50
		public void __Gen_Wrap_349(ref BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob P0) {} // 0x0000000187692E50-0x0000000187693018
		public void __Gen_Wrap_350(ref BeyondDynamicBone.RenderData.UpdateBoneWeightJob2 P0, int P1) {} // 0x0000000187693140-0x00000001876932CC
		public void __Gen_Wrap_351(ref BeyondDynamicBone.RenderData.UpdateBoneWeightJob2 P0) {} // 0x00000001876932CC-0x000000018769343C
		public RenderSetupData.ShareSerializationData __Gen_Wrap_352(object P0) => default; // 0x000000018769343C-0x0000000187693518
		public RenderSetupData.UniqueSerializationData __Gen_Wrap_353(object P0) => default; // 0x0000000187693518-0x00000001876935F4
		public void __Gen_Wrap_354(ref RenderSetupData.VertexWeight5BoneCheckJob P0) {} // 0x00000001876935F4-0x0000000187693738
		public void __Gen_Wrap_355(ref RenderSetupData.ReadTransformJob P0, int P1, TransformAccess P2) {} // 0x0000000187693738-0x000000018769390C
		public void __Gen_Wrap_356(ref RenderSetupData.GetBoneWeightJos P0) {} // 0x000000018769390C-0x0000000187693A60
		public void __Gen_Wrap_357(ref ColliderManager.PreSimulationUpdateJob P0, int P1) {} // 0x0000000187693A60-0x0000000187693C68
		public void __Gen_Wrap_358(ref ColliderManager.PreSimulationUpdateJob P0) {} // 0x0000000187693C68-0x0000000187693E5C
		public void __Gen_Wrap_359(ref ColliderManager.CreateUpdatecolliderListJob P0, int P1) {} // 0x0000000187693E5C-0x0000000187693FC8
		public void __Gen_Wrap_360(ref ColliderManager.CreateUpdatecolliderListJob P0) {} // 0x00000001876940B8-0x0000000187694208
		public void __Gen_Wrap_361(ref ColliderManager.StartSimulationStepJob P0, NativeReference<int> P1) {} // 0x0000000187694208-0x0000000187694428
		public void __Gen_Wrap_362(ref ColliderManager.StartSimulationStepJob P0, int P1) {} // 0x0000000187694428-0x0000000187694620
		public void __Gen_Wrap_363(ref ColliderManager.StartSimulationStepJob P0) {} // 0x0000000187694620-0x0000000187694804
		public void __Gen_Wrap_364(ref ColliderManager.EndSimulationStepJob P0, NativeReference<int> P1) {} // 0x0000000187694804-0x00000001876949B4
		public void __Gen_Wrap_365(ref ColliderManager.EndSimulationStepJob P0, int P1) {} // 0x00000001876949B4-0x0000000187694B40
		public void __Gen_Wrap_366(ref ColliderManager.EndSimulationStepJob P0) {} // 0x0000000187694B40-0x0000000187694CB0
		public void __Gen_Wrap_367(ref ColliderManager.PostSimulationUpdateJob P0, int P1) {} // 0x0000000187694CB0-0x0000000187694E50
		public void __Gen_Wrap_368(ref ColliderManager.PostSimulationUpdateJob P0) {} // 0x0000000187694E50-0x0000000187694FD4
		public JobHandle __Gen_Wrap_369(object P0, in NativeList<int> P1, JobHandle P2) => default; // 0x0000000187694FD4-0x000000018769515C
		public JobHandle __Gen_Wrap_370(object P0, in NativeArray<int> P1, in NativeReference<int> P2, JobHandle P3) => default; // 0x000000018769515C-0x0000000187695328
		public JobHandle __Gen_Wrap_371(object P0, in ExProcessingList<int> P1, JobHandle P2) => default; // 0x0000000187695328-0x000000018769548C
		public void __Gen_Wrap_372(ref SimulationManager.PreSimulationUpdateJob P0, int P1) {} // 0x000000018769548C-0x00000001876956D4
		public void __Gen_Wrap_373(ref SimulationManager.PreSimulationUpdateJob P0) {} // 0x00000001876956D4-0x0000000187695908
		public void __Gen_Wrap_374(ref SimulationManager.ClearStepCounter P0) {} // 0x0000000187695908-0x0000000187695AE8
		public void __Gen_Wrap_375(ref SimulationManager.CreateUpdateParticleList P0, int P1) {} // 0x0000000187695AE8-0x0000000187695D20
		public void __Gen_Wrap_376(ref SimulationManager.CreateUpdateParticleList P0) {} // 0x0000000187695D20-0x0000000187695F44
		public void __Gen_Wrap_377(ref SimulationManager.StartSimulationStepJob P0, NativeReference<int> P1) {} // 0x0000000187695F44-0x0000000187696174
		public void __Gen_Wrap_378(ref SimulationManager.StartSimulationStepJob P0, in TeamWindInfo P1, in WindParams P2, in float3 P3, float P4, ref float3 P5) {} // 0x0000000187696174-0x0000000187696518
		public void __Gen_Wrap_379(ref SimulationManager.StartSimulationStepJob P0, int P1, in TeamManager.TeamData P2, in WindParams P3, in InertiaConstraint.CenterData P4, int P5, int P6, float P7, ref float3 P8) {} // 0x0000000187696518-0x00000001876969BC
		public void __Gen_Wrap_380(ref SimulationManager.StartSimulationStepJob P0, in SpringConstraint.SpringConstraintParams P1, ClothNormalAxis P2, ref double3 P3, in double3 P4, in quaternion P5, double P6, float P7) {} // 0x0000000187696AE4-0x0000000187696E98
		public void __Gen_Wrap_381(ref SimulationManager.StartSimulationStepJob P0, int P1) {} // 0x0000000187696E98-0x00000001876970A0
		public void __Gen_Wrap_382(ref SimulationManager.StartSimulationStepJob P0) {} // 0x00000001876970A0-0x0000000187697294
		public void __Gen_Wrap_383(ref SimulationManager.UpdateStepBasicPotureJob P0, NativeReference<int> P1) {} // 0x0000000187697294-0x00000001876974EC
		public void __Gen_Wrap_384(ref SimulationManager.UpdateStepBasicPotureJob P0, int P1) {} // 0x00000001876974EC-0x0000000187697720
		public void __Gen_Wrap_385(ref SimulationManager.UpdateStepBasicPotureJob P0) {} // 0x0000000187697720-0x0000000187697938
		public void __Gen_Wrap_386(ref SimulationManager.EndSimulationStepJob P0, NativeReference<int> P1) {} // 0x0000000187697938-0x0000000187697B58
		public void __Gen_Wrap_387(ref SimulationManager.EndSimulationStepJob P0, int P1) {} // 0x0000000187697B58-0x0000000187697D50
		public void __Gen_Wrap_388(ref SimulationManager.EndSimulationStepJob P0) {} // 0x0000000187697D50-0x0000000187697F34
		public void __Gen_Wrap_389(ref SimulationManager.CalcDisplayPositionJob P0, int P1) {} // 0x0000000187697F34-0x0000000187698148
		public void __Gen_Wrap_390(ref SimulationManager.CalcDisplayPositionJob P0) {} // 0x0000000187698250-0x0000000187698448
		public void __Gen_Wrap_391(ref SimulationManager.FeedbackTempPosJob P0, int P1) {} // 0x0000000187698448-0x00000001876985A4
		public void __Gen_Wrap_392(ref SimulationManager.FeedbackTempPosJob2 P0, int P1) {} // 0x00000001876985A4-0x0000000187698700
		public void __Gen_Wrap_393(object P0, ref TeamManager.TeamData P1) {} // 0x0000000187698700-0x0000000187698938
		public void __Gen_Wrap_394(object P0, ref TeamManager.TeamData P1, object P2, object P3) {} // 0x0000000187698938-0x0000000187698BA0
		public void __Gen_Wrap_395(object P0, object P1, object P2, object P3, object P4, object P5) {} // 0x000000018734F97C-0x000000018734FA94
		public void __Gen_Wrap_396(ref TeamWindInfo P0) {} // 0x0000000187698BA0-0x0000000187698CD4
		public void __Gen_Wrap_397(ref TeamWindData P0) {} // 0x0000000187698CD4-0x0000000187698EB0
		public int __Gen_Wrap_398(object P0, object P1, int P2, int P3, byte P4, bool P5) => default; // 0x0000000187698EB0-0x0000000187698FD4
		public int[] __Gen_Wrap_399(object P0, object P1, object P2, object P3, int P4) => default; // 0x0000000187698FD4-0x0000000187699108
		public int[] __Gen_Wrap_400(object P0, object P1, int P2) => default; // 0x0000000187699108-0x000000018769921C
		public int __Gen_Wrap_401(object P0, int P1, object P2, int P3, int P4, byte P5) => default; // 0x000000018769921C-0x0000000187699340
		public float4x4 __Gen_Wrap_402(object P0, int P1) => default; // 0x0000000187699340-0x000000018769946C
		public BeyondDynamicBone.TransformData.ShareSerializationData __Gen_Wrap_403(object P0) => default; // 0x000000018769946C-0x0000000187699548
		public BeyondDynamicBone.TransformData.UniqueSerializationData __Gen_Wrap_404(object P0) => default; // 0x0000000187699548-0x0000000187699624
		public void __Gen_Wrap_405(ref BeyondDynamicBone.TransformData.RestoreTransformJob P0, int P1, TransformAccess P2) {} // 0x0000000187699624-0x00000001876997D4
		public void __Gen_Wrap_406(ref BeyondDynamicBone.TransformData.ReadTransformJob P0, int P1, TransformAccess P2) {} // 0x00000001876997D4-0x00000001876999C0
		public Vector3 __Gen_Wrap_407(object P0, Vector3 P1) => default; // 0x00000001876999C0-0x0000000187699B08
		public SharePreBuildData __Gen_Wrap_408(object P0, object P1) => default; // 0x0000000187699B08-0x0000000187699C00
		public bool __Gen_Wrap_409(SharePreBuildData P0) => default; // 0x0000000187678D18-0x0000000187678DD4
		public void __Gen_Wrap_410(SharePreBuildData P0) {} // 0x0000000187678964-0x0000000187678A10
		public string __Gen_Wrap_411() => default; // 0x0000000187699D18-0x0000000187699DD0
		public void __Gen_Wrap_412(ref SameDistanceReduction.InitGridJob P0) {} // 0x0000000187699DD0-0x0000000187699F24
		public void __Gen_Wrap_413(ref SameDistanceReduction.SearchJoinJob P0) {} // 0x0000000187699F24-0x000000018769A084
		public void __Gen_Wrap_414(ref VirtualMeshBoneWeight P0, int P1, float P2) {} // 0x000000018769A084-0x000000018769A1EC
		public void __Gen_Wrap_415(ref VirtualMeshBoneWeight P0, in VirtualMeshBoneWeight P1) {} // 0x000000018769A1EC-0x000000018769A368
		public void __Gen_Wrap_416(ref SameDistanceReduction.JoinJob2 P0) {} // 0x000000018769A368-0x000000018769A50C
		public void __Gen_Wrap_417(ref SameDistanceReduction.UpdateJoinIndexJob P0, int P1) {} // 0x000000018769A50C-0x000000018769A648
		public void __Gen_Wrap_418(ref SameDistanceReduction.UpdateLinkIndexJob P0, int P1) {} // 0x000000018769A648-0x000000018769A794
		public void __Gen_Wrap_419(ref VirtualMeshBoneWeight P0) {} // 0x000000018769A794-0x000000018769A8C4
		public void __Gen_Wrap_420(ref SameDistanceReduction.FinalMergeVertexJob P0, int P1) {} // 0x000000018769A9D0-0x000000018769AB2C
		public bool __Gen_Wrap_421(in NativeParallelMultiHashMap<ushort, ushort> P0, int P1, int P2, bool P3) => default; // 0x000000018769AB2C-0x000000018769AC78
		public void __Gen_Wrap_422(ref ShapeDistanceReduction.SearchJoinEdgeJob P0) {} // 0x000000018769AC78-0x000000018769ADD8
		public void __Gen_Wrap_423(ref SimpleDistanceReduction.InitGridJob P0) {} // 0x000000018769ADD8-0x000000018769AF2C
		public void __Gen_Wrap_424(ref SimpleDistanceReduction.SearchJoinEdgeJob P0) {} // 0x000000018769AF2C-0x000000018769B09C
		public bool __Gen_Wrap_425(in NativeArray<FixedList128Bytes<ushort>> P0, int P1, int P2, in FixedList128Bytes<ushort> P3, in FixedList128Bytes<ushort> P4, bool P5) => default; // 0x000000018769B09C-0x000000018769B2EC
		public bool __Gen_Wrap_426(ref StepReductionBase.JoinEdge P0, in int2 P1) => default; // 0x000000018769B2EC-0x000000018769B478
		public int __Gen_Wrap_427(ref StepReductionBase.JoinEdge P0, StepReductionBase.JoinEdge P1) => default; // 0x000000018769B478-0x000000018769B604
		public void __Gen_Wrap_428(ref StepReductionBase.DeterminJoinEdgeJob P0) {} // 0x000000018769B604-0x000000018769B768
		public void __Gen_Wrap_429(ref StepReductionBase.JoinPairJob P0) {} // 0x000000018769B768-0x000000018769B90C
		public void __Gen_Wrap_430(ref StepReductionBase.UpdateJoinIndexJob P0, int P1) {} // 0x000000018769BA34-0x000000018769BB70
		public void __Gen_Wrap_431(ref StepReductionBase.UpdateLinkIndexJob P0, int P1) {} // 0x000000018769BB70-0x000000018769BCBC
		public void __Gen_Wrap_432(ref StepReductionBase.FinalMergeVertexJob P0, int P1) {} // 0x000000018769BCBC-0x000000018769BE18
		public int3 __Gen_Wrap_433(in int3 P0) => default; // 0x000000018769BE18-0x000000018769BF5C
		public JobHandle __Gen_Wrap_434(NativeArray<int> P0, int P1, int P2, int P3, JobHandle P4) => default; // 0x000000018769BF5C-0x000000018769C0EC
		public JobHandle __Gen_Wrap_435(NativeReference<int> P0, int P1, JobHandle P2) => default; // 0x000000018769C0EC-0x000000018769C260
		public JobHandle __Gen_Wrap_436(NativeArray<int> P0, int P1, JobHandle P2) => default; // 0x000000018769C260-0x000000018769C3D4
		public JobHandle __Gen_Wrap_437(NativeParallelHashSet<int> P0, NativeList<int> P1, JobHandle P2) => default; // 0x000000018769C3D4-0x000000018769C56C
		public JobHandle __Gen_Wrap_438(NativeParallelHashSet<int2> P0, NativeList<int2> P1, JobHandle P2) => default; // 0x000000018769C56C-0x000000018769C704
		public JobHandle __Gen_Wrap_439(NativeParallelHashSet<int4> P0, NativeList<int4> P1, JobHandle P2) => default; // 0x000000018769C704-0x000000018769C89C
		public JobHandle __Gen_Wrap_440(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, JobHandle P3) => default; // 0x000000018769C9A8-0x000000018769CB50
		public JobHandle __Gen_Wrap_441(NativeList<float3> P0, NativeReference<AABB> P1, JobHandle P2) => default; // 0x000000018769CB50-0x000000018769CCE8
		public void __Gen_Wrap_442(NativeList<float3> P0, NativeReference<AABB> P1) {} // 0x000000018769CCE8-0x000000018769CE10
		public AABB __Gen_Wrap_443(in NativeArray<float3> P0, int P1) => default; // 0x000000018769CE10-0x000000018769CF70
		public JobHandle __Gen_Wrap_444(NativeArray<float3> P0, int P1, NativeReference<AABB> P2, NativeArray<float2> P3, JobHandle P4) => default; // 0x000000018769CF70-0x000000018769D150
		public JobHandle __Gen_Wrap_445(NativeArray<float3> P0, int P1, in float4x4 P2, JobHandle P3) => default; // 0x000000018769D150-0x000000018769D324
		public JobHandle __Gen_Wrap_446(NativeArray<float3> P0, NativeArray<float3> P1, int P2, in float4x4 P3, JobHandle P4) => default; // 0x000000018769D324-0x000000018769D520
		public JobHandle __Gen_Wrap_447(NativeReference<int> P0, JobHandle P1) => default; // 0x000000018769D520-0x000000018769D680
		public void __Gen_Wrap_448(ref ClothJobUtility.SerialNumberJob P0, int P1) {} // 0x000000018769D680-0x000000018769D7BC
		public void __Gen_Wrap_449(ref ClothJobUtility.CalcAABBJob P0) {} // 0x000000018769D7BC-0x000000018769D900
		public void __Gen_Wrap_450(ref ClothJobUtility.CalcAABBDeferJob P0) {} // 0x000000018769DB48-0x000000018769DC78
		public void __Gen_Wrap_451(ref ClothJobUtility.CalcUVJob P0, int P1) {} // 0x000000018769DC78-0x000000018769DDD4
		public void __Gen_Wrap_452(ref ClothJobUtility.AddIntDataCopyJob P0, int P1) {} // 0x000000018769DDD4-0x000000018769DF34
		public void __Gen_Wrap_453(ref ClothJobUtility.AddInt2DataCopyJob P0, int P1) {} // 0x000000018769DF34-0x000000018769E090
		public void __Gen_Wrap_454(ref ClothJobUtility.AddInt3DataCopyJob P0, int P1) {} // 0x000000018769E090-0x000000018769E1EC
		public void __Gen_Wrap_455(ref ClothJobUtility.TransformPositionJob P0, int P1) {} // 0x000000018769E1EC-0x000000018769E368
		public void __Gen_Wrap_456(ref ClothJobUtility.TransformPositionJob2 P0, int P1) {} // 0x000000018769E368-0x000000018769E4F4
		public void __Gen_Wrap_457(ref ClothJobUtility.ClearReferenceJob P0) {} // 0x000000018769E4F4-0x000000018769E618
		public JobHandle __Gen_Wrap_458(in NativeList<int> P0, float P1, JobHandle P2) => default; // 0x000000018769E618-0x000000018769E7A0
		public void __Gen_Wrap_459(ref InterlockUtility.AggregateJob P0, int P1) {} // 0x000000018769E7A0-0x000000018769E90C
		public void __Gen_Wrap_460(ref InterlockUtility.AggregateJob P0) {} // 0x000000018769E9E8-0x000000018769EB38
		public void __Gen_Wrap_461(ref InterlockUtility.AggregateWithVelocityJob P0, int P1) {} // 0x000000018769EB38-0x000000018769ECC8
		public void __Gen_Wrap_462(ref InterlockUtility.AggregateWithVelocityJob P0) {} // 0x000000018769ECC8-0x000000018769EE3C
		public void __Gen_Wrap_463(ref InterlockUtility.AggregateJob2 P0, NativeReference<int> P1) {} // 0x000000018769EE3C-0x000000018769EFDC
		public void __Gen_Wrap_464(ref InterlockUtility.AggregateJob2 P0, int P1) {} // 0x000000018769EFDC-0x000000018769F158
		public void __Gen_Wrap_465(ref InterlockUtility.AggregateJob2 P0) {} // 0x000000018769F158-0x000000018769F2B8
		public void __Gen_Wrap_466(ref InterlockUtility.AggregateWithVelocityJob2 P0, NativeReference<int> P1) {} // 0x000000018769F2B8-0x000000018769F48C
		public void __Gen_Wrap_467(ref InterlockUtility.AggregateWithVelocityJob2 P0, int P1) {} // 0x000000018769F48C-0x000000018769F62C
		public void __Gen_Wrap_468(ref InterlockUtility.AggregateWithVelocityJob2 P0) {} // 0x000000018769F62C-0x000000018769F7B0
		public void __Gen_Wrap_469(ref InterlockUtility.AggregateWithVelocityCrossFrameJob2 P0, int P1) {} // 0x000000018769F7B0-0x000000018769F950
		public void __Gen_Wrap_470(ref InterlockUtility.AggregateWithVelocityCrossFrameJob2 P0) {} // 0x000000018769FA6C-0x000000018769FBF0
		public void __Gen_Wrap_471(ref InterlockUtility.AggregateCrossFrameJob2 P0, int P1) {} // 0x000000018769FBF0-0x000000018769FD6C
		public void __Gen_Wrap_472(ref InterlockUtility.AggregateCrossFrameJob2 P0) {} // 0x000000018769FD6C-0x000000018769FECC
		public string __Gen_Wrap_473(ref AABB P0) => default; // 0x000000018769FECC-0x00000001876A0030
		public void __Gen_Wrap_474(float3 P0, quaternion P1, float3 P2, quaternion P3, out float3 P4, out quaternion P5) {
			P4 = default;
			P5 = default;
		} // 0x00000001876A0030-0x00000001876A0278
		public float3 __Gen_Wrap_475(in float3 P0, in float3 P1, in float3 P2, in float2 P3, in float2 P4, in float2 P5) => default; // 0x00000001876A0278-0x00000001876A0504
		public int2 __Gen_Wrap_476(int3 P0, int3 P1) => default; // 0x00000001876A0504-0x00000001876A064C
		public int4 __Gen_Wrap_477(int3 P0, int3 P1) => default; // 0x00000001876A064C-0x00000001876A07B0
		public bool __Gen_Wrap_478(in float3 P0, in float3 P1, float3 P2, float3 P3, float3 P4, bool P5, out float P6, out float P7, out float P8, out float P9) {
			P6 = default;
			P7 = default;
			P8 = default;
			P9 = default;
			return default;
		} // 0x00000001876A07B0-0x00000001876A0A90
		public bool __Gen_Wrap_479(in float3 P0, in float3 P1, float3 P2, float3 P3, float3 P4) => default; // 0x00000001876A0A90-0x00000001876A0C88
		public float __Gen_Wrap_480(Vector3 P0, Vector3 P1, Vector3 P2) => default; // 0x00000001876A0C88-0x00000001876A0DF8
		public BeyondDynamicBone.FTransform __Gen_Wrap_481() => default; // 0x00000001876A0DF8-0x00000001876A0EE4
		public Mesh __Gen_Wrap_482(object P0) => default; // 0x00000001876A0EE4-0x00000001876A0FC0
		public StringBuilder __Gen_Wrap_483(object P0) => default; // 0x00000001876A0FC0-0x00000001876A109C
		public StringBuilder __Gen_Wrap_484() => default; // 0x00000001876A109C-0x00000001876A1154
		public string __Gen_Wrap_485(ref DataChunk P0) => default; // 0x00000001876A1154-0x00000001876A128C
		public void __Gen_Wrap_486(ref ExBitFlag16 P0) {} // 0x00000001876A128C-0x00000001876A13A8
		public int __Gen_Wrap_487(ref ExCostSortedList1 P0, ExCostSortedList1 P1) => default; // 0x00000001876A13A8-0x00000001876A1500
		public string __Gen_Wrap_488(ref ExCostSortedList1 P0) => default; // 0x00000001876A1500-0x00000001876A1638
		public bool __Gen_Wrap_489(ref ExCostSortedList4 P0, float P1, int P2) => default; // 0x00000001876A1638-0x00000001876A17B0
		public int __Gen_Wrap_490(ref ExCostSortedList4 P0, int P1) => default; // 0x00000001876A18C4-0x00000001876A1A20
		public void __Gen_Wrap_491(ref ExCostSortedList4 P0, int P1) {} // 0x00000001876A1A20-0x00000001876A1B6C
		public string __Gen_Wrap_492(ref ExCostSortedList4 P0) => default; // 0x00000001876A1B6C-0x00000001876A1CBC
		public TransformAccessArray __Gen_Wrap_493(object P0) => default; // 0x00000001876A1CBC-0x00000001876A1D98
		public bool __Gen_Wrap_494(ref ResultCode P0, Define.Result P1) => default; // 0x00000001876A1D98-0x00000001876A1ED8
		public void __Gen_Wrap_495(ref ResultCode P0, bool P1, bool P2, bool P3) {} // 0x00000001876A1ED8-0x00000001876A2028
		public double __Gen_Wrap_496(object P0) => default; // 0x00000001876A2028-0x00000001876A20E4
		public void __Gen_Wrap_497(object P0, object P1, object P2, int P3, int P4) {} // 0x00000001876A20E4-0x00000001876A21F0
		public float4 __Gen_Wrap_498(float4 P0) => default; // 0x00000001876A21F0-0x00000001876A2310
		public VirtualMesh.ShareSerializationData __Gen_Wrap_499(object P0) => default; // 0x00000001876A2310-0x00000001876A23EC
		public VirtualMesh.UniqueSerializationData __Gen_Wrap_500(object P0) => default; // 0x00000001876A25CC-0x00000001876A26A8
		public VirtualMeshRaycastHit __Gen_Wrap_501(object P0, float3 P1, float3 P2, bool P3, float P4) => default; // 0x00000001876A26A8-0x00000001876A2854
		public void __Gen_Wrap_502(ref VirtualMesh.Import_GenerateTangentJob P0, int P1) {} // 0x00000001876A2854-0x00000001876A29A0
		public void __Gen_Wrap_503(ref VirtualMesh.Import_CalcSkinningJob P0, int P1) {} // 0x00000001876A29A0-0x00000001876A2BC4
		public void __Gen_Wrap_504(ref VirtualMesh.Import_BoneWeightJob1 P0) {} // 0x00000001876A2BC4-0x00000001876A2D08
		public void __Gen_Wrap_505(ref VirtualMesh.Import_BoneWeightJob2 P0, int P1) {} // 0x00000001876A2D08-0x00000001876A2E74
		public void __Gen_Wrap_506(ref VirtualMesh.Import_BoneVertexJob P0, int P1) {} // 0x00000001876A2E74-0x00000001876A3060
		public void __Gen_Wrap_507(ref VirtualMesh.Select_PackVertexJob P0) {} // 0x00000001876A3060-0x00000001876A3288
		public void __Gen_Wrap_508(ref VirtualMesh.Select_GridJob P0) {} // 0x00000001876A3288-0x00000001876A3468
		public void __Gen_Wrap_509(ref VirtualMesh.Add_CalcBindPoseJob P0, int P1) {} // 0x00000001876A3468-0x00000001876A3660
		public void __Gen_Wrap_510(ref VirtualMesh.Add_CopyVerticesJob P0, int P1) {} // 0x00000001876A3758-0x00000001876A3960
		public void __Gen_Wrap_511(ref VirtualMesh.Mapping_DirectConnectionVertexDataJob P0) {} // 0x00000001876A3960-0x00000001876A3B4C
		public void __Gen_Wrap_512(ref VirtualMesh.Mapping_CalcDirectWeightJob P0) {} // 0x00000001876A3B4C-0x00000001876A3CF0
		public void __Gen_Wrap_513(ref VirtualMesh.Mapping_CalcConnectionVertexDataJob P0) {} // 0x00000001876A3CF0-0x00000001876A3F18
		public void __Gen_Wrap_514(ref VirtualMesh.Mapping_CalcWeightJob P0, int P1) {} // 0x00000001876A3F18-0x00000001876A40D4
		public void __Gen_Wrap_515(ref VirtualMesh.Optimize_EdgeToTrianlgeJob P0) {} // 0x00000001876A40D4-0x00000001876A4258
		public void __Gen_Wrap_516(ref VirtualMesh.ProxyNormalRadiationAdjustmentJob P0, int P1) {} // 0x00000001876A4258-0x00000001876A4438
		public void __Gen_Wrap_517(ref VirtualMesh.ProxyCreateFixedListAndAABBJob P0) {} // 0x00000001876A4438-0x00000001876A45DC
		public void __Gen_Wrap_518(ref VirtualMesh.Proxy_CalcTriangleNormalJob P0, int P1) {} // 0x00000001876A45DC-0x00000001876A4738
		public void __Gen_Wrap_519(ref VirtualMesh.Proxy_CalcTriangleTangentJob P0, int P1) {} // 0x00000001876A4738-0x00000001876A48A4
		public void __Gen_Wrap_520(ref VirtualMesh.Proxy_CreateVertexToTrianglesJob P0) {} // 0x00000001876A4990-0x00000001876A4AC0
		public void __Gen_Wrap_521(ref VirtualMesh.Proxy_OrganizeVertexToTrianglsJob P0, int P1) {} // 0x00000001876A4AC0-0x00000001876A4C2C
		public void __Gen_Wrap_522(ref VirtualMesh.Proxy_CalcVertexNormalTangentFromTriangleJob P0, int P1) {} // 0x00000001876A4C2C-0x00000001876A4DA8
		public void __Gen_Wrap_523(ref VirtualMesh.Proxy_CalcVertexToTransformJob P0, int P1) {} // 0x00000001876A4DA8-0x00000001876A4F24
		public void __Gen_Wrap_524(ref VirtualMesh.Proxy_CalcEdgeToTriangleJob P0) {} // 0x00000001876A4F24-0x00000001876A5068
		public void __Gen_Wrap_525(ref VirtualMesh.Proxy_CalcVertexBindPoseJob2 P0, int P1) {} // 0x00000001876A5068-0x00000001876A51E4
		public void __Gen_Wrap_526(ref VirtualMesh.Proxy_CalcVertexToVertexFromTriangleJob P0) {} // 0x00000001876A51E4-0x00000001876A5338
		public void __Gen_Wrap_527(ref VirtualMesh.Proxy_CalcVertexToVertexFromLineJob P0) {} // 0x00000001876A5338-0x00000001876A548C
		public void __Gen_Wrap_528(ref VirtualMesh.Proxy_CreateEdgeFlagJob P0, int P1) {} // 0x00000001876A548C-0x00000001876A55E8
		public void __Gen_Wrap_529(ref VirtualMesh.Proxy_CalcCustomSkinningWeightsJobV2 P0, int P1) {} // 0x00000001876A55E8-0x00000001876A5764
		public void __Gen_Wrap_530(ref VirtualMesh.Proxy_ApplySelectionJob P0, int P1) {} // 0x00000001876A585C-0x00000001876A59EC
		public void __Gen_Wrap_531(ref VirtualMesh.Proxy_BoneClothApplayTransformFlagJob P0, int P1) {} // 0x00000001876A59EC-0x00000001876A5B38
		public int __Gen_Wrap_532(ref VirtualMesh.BaseLineWork P0, VirtualMesh.BaseLineWork P1) => default; // 0x00000001876A5B38-0x00000001876A5C90
		public void __Gen_Wrap_533(ref VirtualMesh.BaseLine_Mesh_CreateParentJob2 P0) {} // 0x00000001876A5C90-0x00000001876A5E7C
		public void __Gen_Wrap_534(ref VirtualMesh.BaseLine_Mesh_CareteFixedListJob P0) {} // 0x00000001876A5E7C-0x00000001876A5FC0
		public void __Gen_Wrap_535(ref VirtualMesh.BaseLine_Bone_CreateBoneChildInfoJob P0) {} // 0x00000001876A5FC0-0x00000001876A6104
		public void __Gen_Wrap_536(ref VirtualMesh.BaseLine_CalcLocalPositionRotationJob P0, int P1) {} // 0x00000001876A6104-0x00000001876A62A0
		public void __Gen_Wrap_537(ref VirtualMesh.BaseLine_CalcMaxBaseLineLengthJob P0) {} // 0x00000001876A62A0-0x00000001876A6424
		public void __Gen_Wrap_538(ref VirtualMesh.Reduction_InitVertexToVertexJob2 P0) {} // 0x00000001876A6424-0x00000001876A6568
		public void __Gen_Wrap_539(ref VirtualMesh.Organize_RemapVertexJob P0) {} // 0x00000001876A6568-0x00000001876A66AC
		public void __Gen_Wrap_540(ref VirtualMesh.Organize_CollectUseSkinBoneJob P0) {} // 0x00000001876A685C-0x00000001876A6A20
		public void __Gen_Wrap_541(ref VirtualMesh.Organize_CopyVertexJob P0, int P1) {} // 0x00000001876A6A20-0x00000001876A6C18
		public void __Gen_Wrap_542(ref VirtualMesh.Organize_RemapBoneWeightJob P0, int P1) {} // 0x00000001876A6C18-0x00000001876A6DA4
		public void __Gen_Wrap_543(ref VirtualMesh.Organize_RemapLinkPointArrayJob P0, int P1) {} // 0x00000001876A6DA4-0x00000001876A6F10
		public void __Gen_Wrap_544(ref VirtualMesh.Organize_CreateLineTriangleJob P0) {} // 0x00000001876A6F10-0x00000001876A7054
		public void __Gen_Wrap_545(ref VirtualMesh.Organize_CreateLineTriangleJob2 P0) {} // 0x00000001876A7054-0x00000001876A71A4
		public void __Gen_Wrap_546(ref VirtualMesh.Organize_CreateNewTriangleJob3 P0) {} // 0x00000001876A71A4-0x00000001876A72D4
		public void __Gen_Wrap_547(ref VirtualMesh.Work_AverageTriangleDistanceJob P0) {} // 0x00000001876A72D4-0x00000001876A7448
		public void __Gen_Wrap_548(ref VirtualMesh.Work_AverageLineDistanceJob P0) {} // 0x00000001876A7448-0x00000001876A75BC
		public void __Gen_Wrap_549(ref VirtualMesh.Work_AddVertexIndexGirdMapJob P0) {} // 0x00000001876A75BC-0x00000001876A7700
		public void __Gen_Wrap_550(ref VirtualMesh.Work_IntersectTriangleJob P0, int P1) {} // 0x00000001876A78C4-0x00000001876A7A40
		public void __Gen_Wrap_551(ref VirtualMesh.Work_IntersectEdgeJob P0, int P1) {} // 0x00000001876A7A40-0x00000001876A7BDC
		public void __Gen_Wrap_552(ref VirtualMesh.Work_IntersectPointJob P0, int P1) {} // 0x00000001876A7BDC-0x00000001876A7D58
		public void __Gen_Wrap_553(ref VirtualMesh.Work_IntersetcSortJob P0) {} // 0x00000001876A7D58-0x00000001876A7E7C
		public bool __Gen_Wrap_554(ref VertexAttribute P0, object P1) => default; // 0x00000001876A7E7C-0x00000001876A7FBC
		public int __Gen_Wrap_555(ref VertexAttribute P0) => default; // 0x00000001876A7FBC-0x00000001876A80E0
		public string __Gen_Wrap_556(ref VirtualMeshBoneWeight P0) => default; // 0x00000001876A80E0-0x00000001876A8230
		public int __Gen_Wrap_557(ref VirtualMeshRaycastHit P0, VirtualMeshRaycastHit P1) => default; // 0x00000001876A8230-0x00000001876A83E0
		public bool __Gen_Wrap_558(ref VirtualMeshRaycastHit P0) => default; // 0x00000001876A83E0-0x00000001876A8544
		public string __Gen_Wrap_559(ref VirtualMeshRaycastHit P0) => default; // 0x00000001876A8544-0x00000001876A86BC
		public VirtualMeshTransform __Gen_Wrap_560(ref VirtualMeshTransform P0) => default; // 0x00000001876A87C8-0x00000001876A8A40
		public VirtualMeshTransform __Gen_Wrap_561() => default; // 0x00000001876A8A40-0x00000001876A8B7C
		public int __Gen_Wrap_562(ref VirtualMeshTransform P0) => default; // 0x00000001876A8B7C-0x00000001876A8D78
		public void __Gen_Wrap_563(ref VirtualMeshTransform P0, object P1) {} // 0x00000001876A8D78-0x00000001876A8F80
		public VirtualMeshTransform __Gen_Wrap_564(ref VirtualMeshTransform P0, in VirtualMeshTransform P1) => default; // 0x00000001876A8F80-0x00000001876A9294
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IAsyncStateMachine // TypeDefIndex: 46276
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x00000001876AEF28-0x00000001876AEFDC
	
		// Methods
		private void MoveNext() {} // 0x00000001876AED18-0x00000001876AEDA8
		private void SetStateMachine(IAsyncStateMachine P0) {} // 0x00000001876AEE78-0x00000001876AEF28
		public void RefAwaitUnsafeOnCompleteMethod() {} // 0x00000001876AEE04-0x00000001876AEE78
		public void RefAsyncBuilderStartMethod() {} // 0x00000001876AEDA8-0x00000001876AEE04
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 46277
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x00000001876B71C4-0x00000001876B7228
		public static bool IsPatched(int id) => default; // 0x00000001844876D0-0x0000000184487780
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x00000001876B7080-0x00000001876B714C
		public object CreateWrapper(int id) => default; // 0x00000001876B714C-0x00000001876B71C4
		public object InitWrapperArray(int len) => default; // 0x00000001876B7228-0x00000001876B72B4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x00000001876B6FDC-0x00000001876B7080
	}

	public enum IDMAP0 // TypeDefIndex: 46278
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

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 45640
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 45641
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}
