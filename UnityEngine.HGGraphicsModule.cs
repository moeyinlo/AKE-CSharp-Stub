/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

// Image 55: UnityEngine.HGGraphicsModule.dll - Assembly: UnityEngine.HGGraphicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58367-58604

namespace Microsoft.CodeAnalysis
{
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 58368
	{
		// Constructors
		public EmbeddedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace System.Runtime.CompilerServices
{
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 58369
	{
		// Constructors
		public IsReadOnlyAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 58370
	{
		// Constructors
		public IsUnmanagedAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine
{
	public class HGCapsuleBindingComponent : Component // TypeDefIndex: 58371
	{
		// Properties
		public bool enabled { set {} } // 0x0000000185188CB0-0x0000000185188D00
		public float capsuleRadius { set {} } // 0x0000000185188D00-0x0000000185188D50
		public float capsuleHeight { set {} } // 0x0000000185188D50-0x0000000185188DA0
		public Vector3 localOffset { set {} } // 0x0000000186473754-0x0000000186473768
		public Vector3 localRotation { set {} } // 0x0000000186473768-0x000000018647377C
		public float intensityScale { set {} } // 0x0000000185188DA0-0x0000000185188DF0
		public bool forceRender { set {} } // 0x0000000185188DF0-0x0000000185188E40
	
		// Constructors
		public HGCapsuleBindingComponent() {} // Dummy constructor
	
		// Methods
		private void set_localOffset_Injected(ref Vector3 value) {} // 0x0000000185188E40-0x0000000185188E90
		private void set_localRotation_Injected(ref Vector3 value) {} // 0x0000000185188E90-0x0000000185188EE0
	}

	public enum HGDecalShapeType // TypeDefIndex: 58372
	{
		Box = 0,
		Cylinder = 1,
		Sector = 2,
		Sphere = 3,
		Mesh = 255
	}

	public sealed class HGDecalProjector : UnityEngine.Behaviour // TypeDefIndex: 58373
	{
		// Properties
		public HGDecalShapeType shapeType { get => default; } // 0x000000018BF0D7C8-0x000000018BF0D7FC 
		public Material material { get => default; set {} } // 0x000000018BF0D794-0x000000018BF0D7C8 0x000000018BF0D8BC-0x000000018BF0D900
		public UnityEngine.Color baseColor { get => default; set {} } // 0x000000018BF0D768-0x000000018BF0D794 0x000000018BF0D8A8-0x000000018BF0D8BC
		public Vector2 uvOffset { get => default; set {} } // 0x000000018BF0D840-0x000000018BF0D864 0x000000018BF0D988-0x000000018BF0D9A4
		public float sectorAngle { set {} } // 0x000000018BF0D900-0x000000018BF0D944
	
		// Constructors
		public HGDecalProjector() {} // Dummy constructor
	
		// Methods
		private void get_baseColor_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x000000018BF0D724-0x000000018BF0D768
		private void set_baseColor_Injected(ref UnityEngine.Color value) {} // 0x000000018BF0D864-0x000000018BF0D8A8
		private void get_uvOffset_Injected(out Vector2 ret) {
			ret = default;
		} // 0x000000018BF0D7FC-0x000000018BF0D840
		private void set_uvOffset_Injected(ref Vector2 value) {} // 0x000000018BF0D944-0x000000018BF0D988
	}

	public sealed class HGOccluder : Component // TypeDefIndex: 58374
	{
		// Properties
		public bool enabled { get => default; set {} } // 0x000000018BF0ED9C-0x000000018BF0EDD0 0x000000018BF0EE04-0x000000018BF0EE48
		public HGSoftwareOcclusionCullingData occluderData { get => default; set {} } // 0x000000018BF0EDD0-0x000000018BF0EE04 0x000000018BF0EE48-0x000000018BF0EE8C
	
		// Constructors
		public HGOccluder() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public sealed class HGSoftwareOcclusionCullingData : UnityEngine.Object // TypeDefIndex: 58375
	{
		// Properties
		public int quadCount { get => default; } // 0x000000018BF0F9CC-0x000000018BF0FA00 
	
		// Constructors
		public HGSoftwareOcclusionCullingData() {} // 0x000000018BF0F980-0x000000018BF0F9CC
	
		// Methods
		private static void Internal_Create(HGSoftwareOcclusionCullingData cullingData) {} // 0x000000018BF0F94C-0x000000018BF0F980
		public void GetOccluderData(NativeArray<float> centerXs, NativeArray<float> centerYs, NativeArray<float> centerZs, NativeArray<float> extentXs, NativeArray<float> extentYs, NativeArray<float> extentZs, NativeArray<Vector3> vertexData, ref int quadCount) {} // 0x000000018BF0F7F0-0x000000018BF0F94C
		public void GetOccluderData(IntPtr centerXs, IntPtr centerYs, IntPtr centerZs, IntPtr extentXs, IntPtr extentYs, IntPtr extentZs, IntPtr vertexData, ref int quadCount) {} // 0x000000018BF0F78C-0x000000018BF0F7F0
	}

	public enum TransformAnimatedPhasePlayMode // TypeDefIndex: 58376
	{
		TransformAnimatedPhaseCurrent = 0,
		TransformAnimatedPhaseSequence = 1,
		TransformAnimatedPhaseSequenceLoop = 2
	}

	[Serializable]
	public struct TransformAnimatedCurveData // TypeDefIndex: 58377
	{
		// Fields
		public byte[] data; // 0x00
		public float duration; // 0x08
	}

	[Serializable]
	public struct TransformMotionPhase // TypeDefIndex: 58378
	{
		// Fields
		public Vector3 translationSpeed; // 0x00
		public Vector3 eulerAngleSpeed; // 0x0C
		public Vector3 rotAnchorPosition; // 0x18
		public float duration; // 0x24
	}

	public struct HGTransformAnimatedProfile // TypeDefIndex: 58379
	{
		// Fields
		public TransformMotionPhase[] motionPhaseProfiles; // 0x00
		public TransformAnimatedCurveData animCurveData; // 0x08
		public TransformAnimatedPhasePlayMode phasePlayMode; // 0x18
	}

	public sealed class HGTransformAnimatedBehaviour : UnityEngine.Behaviour // TypeDefIndex: 58380
	{
		// Fields
		public HGTransformAnimatedProfile profileData; // 0x18
		public bool useLogicDeltaTime; // 0x38
		public Renderer shadowProxyRenderer; // 0x40
	
		// Constructors
		public HGTransformAnimatedBehaviour() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void SetPause() {} // 0x000000018BF1065C-0x000000018BF10690
		public void Play() {} // 0x000000018BF105E8-0x000000018BF1061C
		public float GetTimeScale() => default; // 0x000000018BF10538-0x000000018BF1056C
		public void SetTimeScale(float scale) {} // 0x000000018BF10690-0x000000018BF106D4
		public void SetCurrentPhaseIndex(int phase) {} // 0x000000018BF1061C-0x000000018BF1065C
		public int GetCurrentPhaseIndex() => default; // 0x000000018BF10504-0x000000018BF10538
		public Matrix4x4 GetWorldMatrix() => default; // 0x000000018BF105B0-0x000000018BF105E8
		public void SetUseLogicTime(bool useLogicTime) {} // 0x000000018BF106D4-0x000000018BF10718
		public bool UseLogicTime() => default; // 0x000000018BF10718-0x000000018BF1074C
		private void GetWorldMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x000000018BF1056C-0x000000018BF105B0
	}

	public static class HGTransformAnimatedSystemCPP // TypeDefIndex: 58381
	{
		// Methods
		public static long HGTransformAnimatedSystemCPP_Create() => default; // 0x0000000184CAD6A0-0x0000000184CAD6E0
		public static void HGTransformAnimatedSystemCPP_UpdateAbsoluteTime(long ptr, float absoluteTimeSec) {} // 0x0000000184CAD650-0x0000000184CAD6A0
		public static void HGTransformAnimatedSystemCPP_Destroy(long ptr) {} // 0x000000018BF1074C-0x000000018BF10780
	}

	public class HGWindFoliageSyncSystemCPP // TypeDefIndex: 58382
	{
		// Constructors
		public HGWindFoliageSyncSystemCPP() {} // Dummy constructor
	
		// Methods
		public static long HGWindFoliageSyncSystemCPP_Create() => default; // 0x000000018448EE50-0x000000018448EE90
		public static unsafe void HGWindFoliageSyncSystemCPP_UpdateWindParam(long _ptr, Vector4 windGlobalParam, float* windMotorParam0, float* windMotorParam1, float* windMotorParam2, float* windMotorParam3, Vector4 count, float time, float lastTime) {} // 0x000000018646EEB0-0x000000018646EF0C
		public static void HGWindFoliageSyncSystemCPP_Destroy(long _ptr) {} // 0x000000018BF1091C-0x000000018BF10950
		private static unsafe void HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(long _ptr, ref Vector4 windGlobalParam, float* windMotorParam0, float* windMotorParam1, float* windMotorParam2, float* windMotorParam3, ref Vector4 count, float time, float lastTime) {} // 0x0000000184EF49B0-0x0000000184EF4A20
	}
}

namespace UnityEngine.HyperGryph
{
	public struct HGDLSSUtil // TypeDefIndex: 58383
	{
		// Methods
		public static bool IsStreamlineDLSSSupported() => default; // 0x0000000184E74360-0x0000000184E743A0
		public static bool IsStreamlineDLSSGSupported() => default; // 0x0000000184E74320-0x0000000184E74360
		public static bool IsLowLatencyAvailable() => default; // 0x000000018BF0D6F8-0x000000018BF0D724
	}

	public static class GPUDrivenRendererV1 // TypeDefIndex: 58384
	{
		// Methods
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, bool retainCustomDS, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, ref Matrix4x4 prevViewProjection) {} // 0x000000018BF0D10C-0x000000018BF0D16C
		public static bool Valid() => default; // 0x000000018519E220-0x000000018519E390
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool retainCustomDS, out uint normalList, out uint preZPart0List, out uint preZPart1List, ref Matrix4x4 prevViewProjection) {
			normalList = default;
			preZPart0List = default;
			preZPart1List = default;
		} // 0x000000018BF0D0E4-0x000000018BF0D10C
		public static void DrawRendererList(CommandBuffer cmd, uint rendererList, bool renderDepthOnly) {} // 0x000000018BF0D240-0x000000018BF0D25C
		public static void AdvanceFrame() {} // 0x000000018BF0CFA8-0x000000018BF0CFD4
		public static bool CullingInspectionMode() => default; // 0x000000018BF0D16C-0x000000018BF0D198
		public static void PopulatePerFrameData(CommandBuffer cmd, uint threadGroupSize, uint hzbWidth, uint hzbHeight, bool usePrevVP = false /* Metadata: 0x0207F5F5 */) {} // 0x000000018BF0D25C-0x000000018BF0D2BC
		public static void BindFrameConstantsBuffer(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x000000018BF0D090-0x000000018BF0D0E4
		public static void BindFrameConstantsBufferGlobal(CommandBuffer cmd) {} // 0x000000018BF0D05C-0x000000018BF0D090
		public static void BindBuffersForCulling(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x000000018BF0CFD4-0x000000018BF0D028
		public static void BindBuffersForRendering(CommandBuffer cmd) {} // 0x000000018BF0D028-0x000000018BF0D05C
		public static void DispatchComputeMeshletInstanceCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x000000018BF0D1EC-0x000000018BF0D240
		public static void DispatchComputeDrawBucketCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x000000018BF0D198-0x000000018BF0D1EC
	}

	public static class GPUDrivenRendererV2 // TypeDefIndex: 58385
	{
		// Methods
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, bool retainCustomDS, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, ref Matrix4x4 prevViewProjection) {} // 0x000000018BF0D3F8-0x000000018BF0D458
		public static bool Valid() => default; // 0x000000018519E1E0-0x000000018519E220
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool retainCustomDS, out uint normalList, out uint preZPart0List, out uint preZPart1List, ref Matrix4x4 prevViewProjection) {
			normalList = default;
			preZPart0List = default;
			preZPart1List = default;
		} // 0x000000018BF0D458-0x000000018BF0D480
		public static void DrawRendererList(CommandBuffer cmd, uint rendererList, bool renderDepthOnly) {} // 0x000000018BF0D240-0x000000018BF0D25C
		public static void AdvanceFrame() {} // 0x000000018BF0D2BC-0x000000018BF0D2E8
		public static void BindFrameConstantsBuffer(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x000000018BF0D3A4-0x000000018BF0D3F8
		public static void BindFrameConstantsBufferGlobal(CommandBuffer cmd) {} // 0x000000018BF0D370-0x000000018BF0D3A4
		public static void BindBuffersForCulling(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x000000018BF0D2E8-0x000000018BF0D33C
		public static void BindBuffersForRendering(CommandBuffer cmd) {} // 0x000000018BF0D33C-0x000000018BF0D370
		public static void DispatchComputeMeshletInstanceCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x000000018BF0D4D4-0x000000018BF0D528
		public static void DispatchComputeDrawBucketCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x000000018BF0D480-0x000000018BF0D4D4
	}

	public struct CapsuleData // TypeDefIndex: 58386
	{
		// Fields
		public Vector3 pa; // 0x00
		public float radius; // 0x0C
		public Vector3 pb; // 0x10
		public float len; // 0x1C
		public Vector3 dir; // 0x20
		public float padding; // 0x2C
	}

	public static class HGCapsuleShadowManager // TypeDefIndex: 58387
	{
		// Methods
		public static uint GetRenderCapsuleNum() => default; // 0x000000018BF0D6CC-0x000000018BF0D6F8
		public static uint CullAndGetRenderCapsuleData(uint viewHandle, IntPtr outData, uint outDataCapacity) => default; // 0x000000018BF0D67C-0x000000018BF0D6CC
	}

	public static class HGDecalRender // TypeDefIndex: 58388
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGShaderLightMode lightModeMask, IntPtr context) => default; // 0x000000018BF0D9A4-0x000000018BF0D9C0
		public static uint CreateRendererList(uint viewHandle, HGShaderLightMode lightModeMask, IntPtr context, IntPtr drawableFeedbackPtr) => default; // 0x000000018BF0D9C0-0x000000018BF0D9D0
		private static unsafe uint CreateRendererList(uint viewHandle, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr) => default; // 0x000000018BF0D9D0-0x000000018BF0DA30
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList) {} // 0x000000018BF0DA30-0x000000018BF0DA4C
	}

	public struct HGDrawCallDetailedStats // TypeDefIndex: 58389
	{
		// Fields
		public int componentInstanceID; // 0x00
		public int meshInstanceID; // 0x04
		public int triCount; // 0x08
		public int meshBatchCount; // 0x0C
		public int shaderInstanceID; // 0x10
		public int passNameID; // 0x14
		public int passVertKeywordsID; // 0x18
		public int passFragKeywordsID; // 0x1C
	}

	public class HGFastString // TypeDefIndex: 58390
	{
		// Constructors
		public HGFastString() {} // Dummy constructor
	
		// Methods
		public static string IndexToString(int index) => default; // 0x0000000184E79F50-0x0000000184E79F90
	}

	public enum HGFactoryLODTier // TypeDefIndex: 58391
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3
	}

	[Serializable]
	public struct HGFactoryRendererData // TypeDefIndex: 58392
	{
		// Fields
		public Mesh m_mesh; // 0x00
		public Mesh m_shadowProxyMesh; // 0x08
		public Material[] m_materials; // 0x10
	}

	[Serializable]
	public struct HGFactoryInstancingLODDataV3 // TypeDefIndex: 58393
	{
		// Fields
		public HGFactoryRendererData[] m_rendererDataArr; // 0x00
		public Vector4 m_lodScreenSizeMaxs; // 0x08
		public Vector4 m_lodScreenSizeMins; // 0x18
	}

	[Serializable]
	public struct HGFactoryEntityDesc // TypeDefIndex: 58394
	{
		// Fields
		public Vector3 m_initPosition; // 0x00
		public float m_initUniformScale; // 0x0C
		public Quaternion m_initRotation; // 0x10
		public ShadowCastingMode m_shadowCastingMode; // 0x20
		public SubMeshRenderMode m_subMeshRenderMode; // 0x24
		public int m_objectLayer; // 0x28
		public int m_objectEnabled; // 0x2C
		public int m_renderFoliageOccluder; // 0x30
		public float m_objectBoundExtentsMultiplier; // 0x34
		public int m_useCustomLocalBounds; // 0x38
		public Bounds m_customLocalBounds; // 0x3C
		public int m_autoUpdatePrevTransform; // 0x54
		public uint m_enabledLightModes; // 0x58
		public Entity m_logicalEntityHandle; // 0x5C
	}

	public struct HGFactoryEntityTransformData // TypeDefIndex: 58395
	{
		// Fields
		public Vector4 m_positionAndScale; // 0x00
		public Quaternion m_rotation; // 0x10
	}

	public static class HGFactoryRenderManager // TypeDefIndex: 58396
	{
		// Methods
		public static void SetFactoryLodTier(HGFactoryLODTier lodTier) {} // 0x0000000185D5C860-0x0000000185D5C8A0
		public static Entity CreateRegularEntity(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, string entityName, Entity gameplayEntity, Material[] additiveMaterials) => default; // 0x00000001850CBD50-0x00000001850CBDE0
		public static void UpdateRegularEntity(Entity gameplayEntity, HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc) {} // 0x000000018BF0DF14-0x000000018BF0DF30
		public static void UpdateRegularEntityAdditiveMaterials(Entity gameplayEntity, Material[] additiveMaterials) {} // 0x000000018BF0DEF8-0x000000018BF0DF14
		public static void DestroyRegularEntity(Entity gameplayEntity) {} // 0x000000018646FF5C-0x000000018646FF78
		public static void CreateBatchedEntities(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, NativeArray<Entity> entities, NativeArray<Entity> gameplayEntities, string entityName) {} // 0x00000001840B2DA0-0x00000001840B2EF0
		public static void DestroyBatchedEntities(NativeArray<Entity> gameplayEntities) {} // 0x00000001848ADC10-0x00000001848ADC50
		private static void CreateBatchedEntities(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, IntPtr entities, IntPtr gameplayEntities, int count, string entityName) {} // 0x000000018646DA34-0x000000018646DA60
		private static void DestroyBatchedEntities(IntPtr gameplayEntities, int count) {} // 0x00000001848ADC50-0x00000001848ADCA0
		public static void SetEntityEnabledLightModes(Entity rendererEntity, uint lightModeMask) {} // 0x000000018BF0DEDC-0x000000018BF0DEF8
		public static void SetEntitySharedData<T>(uint sharedDataIndex, T data, int offset)
			where T : struct {}
		private static void SetEntitySharedDataPartial(uint sharedDataIndex, IntPtr data, int offset, int size) {} // 0x0000000184D25300-0x0000000184D25370
		public static byte GetEntityDirtyFlags(uint sharedDataIndex) => default; // 0x00000001840FF9A0-0x00000001840FF9E0
		public static void SetEntityDirtyFlags(uint sharedDataIndex, byte flags) {} // 0x00000001840FF9E0-0x00000001840FFA30
		public static byte GetEntityObjectFlags(uint sharedDataIndex) => default; // 0x00000001840FF570-0x00000001840FF5B0
		public static uint GetEntityAdditiveVFXFlags(uint sharedDataIndex) => default; // 0x00000001840FEB60-0x00000001840FEBA0
		public static void SetEntityAdditiveVFXFlags(uint sharedDataIndex, uint flags) {} // 0x00000001840FEBA0-0x00000001840FEBF0
		public static void FrameUpdateEntities() {} // 0x0000000185492010-0x0000000185492020
		private static void CreateRegularEntity_Injected(HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc, string entityName, ref Entity gameplayEntity, Material[] additiveMaterials, out Entity ret) {
			ret = default;
		} // 0x00000001850CBDE0-0x00000001850CBE50
		private static void UpdateRegularEntity_Injected(ref Entity gameplayEntity, HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc) {} // 0x00000001854A2D40-0x00000001854A2DA0
		private static void UpdateRegularEntityAdditiveMaterials_Injected(ref Entity gameplayEntity, Material[] additiveMaterials) {} // 0x000000018551AF40-0x000000018551AF90
		private static void DestroyRegularEntity_Injected(ref Entity gameplayEntity) {} // 0x0000000185A17260-0x0000000185A172A0
		private static void CreateBatchedEntities_Injected(HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc, IntPtr entities, IntPtr gameplayEntities, int count, string entityName) {} // 0x0000000185765470-0x00000001857654E0
		private static void SetEntityEnabledLightModes_Injected(ref Entity rendererEntity, uint lightModeMask) {} // 0x000000018BF0DE9C-0x000000018BF0DEDC
	}

	public struct HGFoliageInteractCPP // TypeDefIndex: 58397
	{
		// Fields
		public int compID; // 0x00
		public Transform transform; // 0x08
		public Mesh interactCollider; // 0x10
	}

	public struct HGFoliageInteractRaftCPP // TypeDefIndex: 58398
	{
		// Fields
		public int compID; // 0x00
		public Transform transform; // 0x08
		public Mesh interactCollider; // 0x10
	}

	public static class HGFoliageInteractiveManagerV2 // TypeDefIndex: 58399
	{
		// Methods
		public static void SetupFoliageInteractiveManager(Mesh characterProxyMesh, bool enabled) {} // 0x0000000185F5F6B0-0x0000000185F5F700
		public static void CleanUpFoliageInteractiveManager() {} // 0x00000001852C88F0-0x00000001852C8930
		public static void SetEnabled(bool enabled) {} // 0x00000001855470C0-0x0000000185547100
		public static void SetInteractCenter(Vector3 center) {} // 0x000000018646ED00-0x000000018646ED10
		public static void SetCharacterPositions(List<Vector3> positions) {} // 0x00000001846E3130-0x00000001846E31B0
		public static unsafe void SetCharacterPositions(Vector3* positions, int count) {} // 0x00000001846E31B0-0x00000001846E3200
		public static void RegisterInteract(HGFoliageInteractCPP interact) {} // 0x000000018BF0E004-0x000000018BF0E014
		public static void UnregisterInteract(int interactInstID) {} // 0x000000018BF0E048-0x000000018BF0E07C
		public static void RegisterInteractRaft(HGFoliageInteractRaftCPP raft) {} // 0x000000018BF0DFC0-0x000000018BF0DFD0
		public static void UnregisterInteractRaft(int raftInstID) {} // 0x000000018BF0E014-0x000000018BF0E048
		private static void SetInteractCenter_Injected(ref Vector3 center) {} // 0x00000001853B08F0-0x00000001853B0930
		private static void RegisterInteract_Injected(ref HGFoliageInteractCPP interact) {} // 0x000000018BF0DFD0-0x000000018BF0E004
		private static void RegisterInteractRaft_Injected(ref HGFoliageInteractRaftCPP raft) {} // 0x000000018BF0DF8C-0x000000018BF0DFC0
	}

	public static class HGFoliageOccluderManagerV2 // TypeDefIndex: 58400
	{
		// Methods
		public static void SetCenterPosition(Vector3 center) {} // 0x000000018646ED10-0x000000018646ED20
		private static void SetCenterPosition_Injected(ref Vector3 center) {} // 0x00000001853B08B0-0x00000001853B08F0
	}

	public static class HGFoliageOccluderRender // TypeDefIndex: 58401
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, uint materialHandle, uint geometryHandle, HGShaderLightMode lightModeMask, IntPtr context) => default; // 0x000000018BF0E07C-0x000000018BF0E0A0
		private static unsafe uint CreateRendererList(uint viewHandle, uint materialHandle, uint geometryHandle, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr) => default; // 0x000000018BF0E0A0-0x000000018BF0E100
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList) {} // 0x000000018BF0E100-0x000000018BF0E11C
	}

	public struct GpuClothClearBufferDataCPP // TypeDefIndex: 58402
	{
		// Fields
		public bool shouldClear; // 0x00
		public IVec4 eleNum; // 0x04
	
		// Methods
		public bool IsValid() => default; // 0x00000001835E3010-0x00000001835E3020
	}

	public struct ClothGroupUploadDataMapCPP // TypeDefIndex: 58403
	{
		// Fields
		private IVec4 clothNodeDataMap; // 0x00
		private IVec4 clothBatchMetaDataMap; // 0x10
		private IVec4 clothBatchCacheDataMap; // 0x20
	}

	public struct ClothMetaDataCPP // TypeDefIndex: 58404
	{
		// Fields
		private uint clothNodeIdxStart; // 0x00
		private uint clothNodeIdxEnd; // 0x04
		private uint batchIdxStart; // 0x08
		private uint iterNum; // 0x0C
		private float damping; // 0x10
		private float windFreqFactor; // 0x14
		private float windBalanceFactor; // 0x18
		private float windIntensityScale; // 0x1C
		private IVec4 groupOffset; // 0x20
		private Vector4 packedLongestAnchorDistance; // 0x30
		private Vector4 packedClothNormal; // 0x40
		private Vector4 localToWorld0; // 0x50
		private Vector4 localToWorld1; // 0x60
		private Vector4 localToWorld2; // 0x70
		private Vector4 worldToLocal0; // 0x80
		private Vector4 worldToLocal1; // 0x90
		private Vector4 worldToLocal2; // 0xA0
	}

	public struct ClothNodeDataCPP // TypeDefIndex: 58407
	{
		// Fields
		private IVec2 anchorNodeCacheIdx; // 0x00
		private Vector2 anchorNodeDistance; // 0x08
		private Vector2 uv; // 0x10
		private Vector2 collisionPlaneXY; // 0x18
		private Vector4 packedBasePosition; // 0x20
		private Vector4 packedBaseNormal; // 0x30
		private Vector4 baseTangent; // 0x40
		private Vector4 packedPrePosition; // 0x50
		private Vector4 packedCurPosition; // 0x60
		private Vector4 packedCurNormal; // 0x70
		private _neighborClothNodeCacheIdx_e__FixedBuffer neighborClothNodeCacheIdx; // 0x80
		private _neighborClothNodeDistance_e__FixedBuffer neighborClothNodeDistance; // 0xA0
	
		// Nested types
		public struct _neighborClothNodeCacheIdx_e__FixedBuffer // TypeDefIndex: 58405
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _neighborClothNodeDistance_e__FixedBuffer // TypeDefIndex: 58406
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct GpuClothGroupUploadDataCPP // TypeDefIndex: 58408
	{
		// Fields
		public bool isValid; // 0x00
		public int uploadDataMapNum; // 0x04
		public IntPtr uploadDataMap; // 0x08
		public int clothMetaUploadDataNum; // 0x10
		public IntPtr clothMetaUploadData; // 0x18
		public int clothNodeUploadDataNum; // 0x20
		public IntPtr clothNodeUploadData; // 0x28
		public int clothBatchMetaUploadDataNum; // 0x30
		public IntPtr clothBatchMetaUploadData; // 0x38
		public int clothBatchCacheMapUploadDataNum; // 0x40
		public IntPtr clothBatchCacheMapUploadData; // 0x48
	
		// Methods
		public bool IsValid() => default; // 0x00000001835E3010-0x00000001835E3020
	}

	public struct ClothConstDataCPP // TypeDefIndex: 58410
	{
		// Fields
		private Vector4 packedDeltaT; // 0x00
		private Vector4 clothParam1; // 0x10
		private _colliderInfos_e__FixedBuffer colliderInfos; // 0x20
	
		// Nested types
		public struct _colliderInfos_e__FixedBuffer // TypeDefIndex: 58409
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct GpuClothRenderDataCPP // TypeDefIndex: 58411
	{
		// Fields
		public bool isValid; // 0x00
		public int clothNum; // 0x04
		public ClothConstDataCPP clothConstData; // 0x08
	
		// Methods
		public bool IsValid() => default; // 0x00000001835E3010-0x00000001835E3020
	}

	public static class HGGpuClothManagerV2 // TypeDefIndex: 58412
	{
		// Methods
		public static void SetupGpuClothManager(Mesh defaultCapsuleMesh) {} // 0x0000000185F7DE30-0x0000000185F7DE70
		public static void SetWindDirection(Vector3 direction) {} // 0x00000001864725DC-0x00000001864725EC
		public static void SetPlayerCenter(Vector3 playerCenter) {} // 0x00000001864725EC-0x00000001864725FC
		public static void UpdateCharacterPositions(List<Vector3> positions) {} // 0x00000001846E30B0-0x00000001846E3130
		public static unsafe void UpdateCharacterPositions(Vector3* positionPtr, int count) {} // 0x00000001846E3200-0x00000001846E3250
		public static bool IsClothSkeletonValid() => default; // 0x000000018BF0E374-0x000000018BF0E3A0
		public static bool IsClothSkeletonFlipped() => default; // 0x000000018BF0E348-0x000000018BF0E374
		public static bool ShouldStep() => default; // 0x000000018BF0E3A0-0x000000018BF0E3CC
		public static GpuClothClearBufferDataCPP GetClearBufferData_CSharpWrapper() => default; // 0x000000018BF0E184-0x000000018BF0E1A8
		public static GpuClothGroupUploadDataCPP GetUploadData_CSharpWrapper() => default; // 0x000000018BF0E318-0x000000018BF0E348
		public static GpuClothRenderDataCPP GetRenderData_CSharpWrapper() => default; // 0x000000018BF0E28C-0x000000018BF0E2B8
		public static uint GetSkeletonBufferID() => default; // 0x000000018BF0E2B8-0x000000018BF0E2E4
		public static uint GetClothNodeBufferID() => default; // 0x000000018BF0E22C-0x000000018BF0E258
		public static uint GetClothMetaDataBufferID() => default; // 0x000000018BF0E200-0x000000018BF0E22C
		public static uint GetClothBatchMetaDataBufferID() => default; // 0x000000018BF0E1D4-0x000000018BF0E200
		public static uint GetClothBatchCacheMapBufferID() => default; // 0x000000018BF0E1A8-0x000000018BF0E1D4
		private static void SetWindDirection_Injected(ref Vector3 direction) {} // 0x0000000184D161C0-0x0000000184D16200
		private static void SetPlayerCenter_Injected(ref Vector3 playerCenter) {} // 0x0000000184D16180-0x0000000184D161C0
		private static void GetClearBufferData_CSharpWrapper_Injected(out GpuClothClearBufferDataCPP ret) {
			ret = default;
		} // 0x000000018BF0E150-0x000000018BF0E184
		private static void GetUploadData_CSharpWrapper_Injected(out GpuClothGroupUploadDataCPP ret) {
			ret = default;
		} // 0x000000018BF0E2E4-0x000000018BF0E318
		private static void GetRenderData_CSharpWrapper_Injected(out GpuClothRenderDataCPP ret) {
			ret = default;
		} // 0x000000018BF0E258-0x000000018BF0E28C
	}

	public static class HGLODStateSystem // TypeDefIndex: 58413
	{
		// Methods
		public static bool IsCurrFrameTriggerTransition() => default; // 0x00000001843FB260-0x00000001843FB2A0
		public static float GetLODTransitionFraction() => default; // 0x0000000184A64C10-0x0000000184A64C50
		public static float GetLODTransitionTime() => default; // 0x0000000185F08140-0x0000000185F08180
		public static void SetLODTransitionTime(float lodTransitionTime) {} // 0x00000001859A3C20-0x00000001859A3C70
	}

	public enum LODStreamingStatus : byte // TypeDefIndex: 58414
	{
		Idle = 0,
		Loading = 1,
		Unloading = 2,
		Disabled = 4
	}

	public static class HGLODStreamingSystem // TypeDefIndex: 58415
	{
		// Properties
		public static bool enableLODStreaming { get; set; } // 0x0000000185F9E4F0-0x0000000185F9E530 0x0000000185F5FC80-0x0000000185F5FCC0
		public static bool enableLODStreamingKeepLastLODResource { get; set; } // 0x0000000184A64B30-0x0000000184A64B70
		public static LODCrossFadeConfig lodConfig { get; set; } // 0x0000000186471820-0x0000000186471830
		public static float lodStreamingLoadDirtyDistance { get; set; } // 0x0000000184A64B70-0x0000000184A64BC0
		public static float lodStreamingUnloadDirtyDistance { get; set; } // 0x0000000184A64BC0-0x0000000184A64C10
	
		// Methods
		public static void SetArtTagLODStreamingOffset(uint artTag, int lodStreamingOffset) {} // 0x000000018531EA60-0x000000018531EAB0
		public static void SetHLODUnloadDistance(int hlodLevel, float unloadDistance) {} // 0x0000000184A64980-0x0000000184A649D0
		public static LODStreamingStatus QueryLODStreamingStatus() => default; // 0x000000018BF0EAC4-0x000000018BF0EAF0
		private static void set_lodConfig_Injected(ref LODCrossFadeConfig value) {} // 0x0000000184A64C50-0x0000000184A64C90
	}

	public static class HGShadingStateSystem // TypeDefIndex: 58416
	{
		// Fields
		private static UnityAction<int, bool> shadingStateChanged; // 0x00
	
		// Events
		public static event UnityAction<int, bool> shadingStateChanged;
	
		// Methods
		public static uint GetMaterialHandle(int instanceId) => default; // 0x0000000185147230-0x0000000185147270
		public static Material GetMaterial(uint handle) => default; // 0x000000018BF0F3A0-0x000000018BF0F3D4
		private static void Internal_OnShadingStateChanged(int instanceId, bool state) {} // 0x000000018BF0F3D4-0x000000018BF0F434
		public static void FlushAllMaterialCallbacks() {} // 0x0000000185A114C0-0x0000000185A11500
	}

	public static class HGGeometrySystem // TypeDefIndex: 58417
	{
		// Methods
		public static uint GetGeometryHandle(int instanceId) => default; // 0x000000018BF0E11C-0x000000018BF0E150
	}

	public static class HGGraphicsUtils // TypeDefIndex: 58418
	{
		// Properties
		public static bool enableRayTracing { get; set; } // 0x0000000185F8C340-0x0000000185F8C380 0x0000000185C318C0-0x0000000185C31900
		public static bool enableRayTracingRender { get; set; } // 0x000000018519E120-0x000000018519E160 0x0000000185C31900-0x0000000185C31940
		public static bool enableECSRenderer { get; } // 0x000000018BF0E5CC-0x000000018BF0E5F8 
		public static bool enableHGNewGraphicsAPI { get; } // 0x000000018BF0E5F8-0x000000018BF0E624 
		public static bool enableCppRenderPath { get; } // 0x00000001851983B0-0x00000001851983F0 
		public static int maxAnisoLevel { get; set; } // 0x000000018BF0E624-0x000000018BF0E650 0x0000000185F1D1C0-0x0000000185F1D200
		public static bool enableRenderingCommandBufferDirectCall { get; set; } // 0x000000018512D890-0x000000018512D8D0
	
		// Methods
		public static CBHandle HGAllocateTempVertexBuffer(int size) => default; // 0x000000018BF0E568-0x000000018BF0E598
		public static uint AllocateTempCompoundRendererListFromScript(ref IntPtr outPtr) => default; // 0x000000018BF0E3CC-0x000000018BF0E400
		public static bool IsCompoundRendererListDrawable(uint id) => default; // 0x000000018BF0E598-0x000000018BF0E5CC
		public static void PrepareGeometryJobRenderersForRendering() {} // 0x000000018519E160-0x000000018519E1A0
		public static uint CreateMetalFXSpatialScaler(int inputWidth, int inputWeight, int outputWidth, int outputHeight, GraphicsFormat colorTextureFormat, GraphicsFormat outputTextureFormat) => default; // 0x000000018BF0E400-0x000000018BF0E460
		public static void DestroyMetalFXSpatialScaler(uint spatialScalerHandle) {} // 0x000000018BF0E4C0-0x000000018BF0E4F4
		public static uint CreateMetalFXTemporalScaler(int inputWidth, int inputWeight, int outputWidth, int outputHeight, GraphicsFormat colorTextureFormat, GraphicsFormat depthTextureFormat, GraphicsFormat motionTextureFormat, GraphicsFormat outputTextureFormat) => default; // 0x000000018BF0E460-0x000000018BF0E4C0
		public static void DestroyMetalFXTemporalScaler(uint temporalScalerHandle) {} // 0x000000018BF0E4F4-0x000000018BF0E528
		private static void HGAllocateTempVertexBuffer_Injected(int size, out CBHandle ret) {
			ret = default;
		} // 0x000000018BF0E528-0x000000018BF0E568
	}

	public static class HGRendererSystem // TypeDefIndex: 58419
	{
		// Properties
		public static Vector3 PerRendererLightingFallbackPosition { get; set; } // 0x000000018BF0F198-0x000000018BF0F1A8
		public static uint MaxPerRendererLightingCount { get; } // 0x000000018BF0F104-0x000000018BF0F130 
		public static uint CSMStopRenderCharacterCascadeLevel { get; set; } // 0x000000018BF0F130-0x000000018BF0F164
	
		// Methods
		private static void set_PerRendererLightingFallbackPosition_Injected(ref Vector3 value) {} // 0x000000018BF0F164-0x000000018BF0F198
	}

	public static class HGLogicTimeManager // TypeDefIndex: 58420
	{
		// Methods
		public static void SetLogicTickDeltaTime(float deltaTime) {} // 0x0000000184EC3920-0x0000000184EC3970
		public static void SetHgrpDeltaTime(float deltaTime) {} // 0x00000001844B51E0-0x00000001844B5230
	}

	public static class HGGrassRender // TypeDefIndex: 58421
	{
		// Properties
		public static float grassGlobalSparsity { get; set; } // 0x0000000185A54710-0x0000000185A54760
	
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool noAlphaTest = false /* Metadata: 0x0207F5FE */) => default; // 0x000000018BF0E650-0x000000018BF0E680
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr, bool noAlphaTest) => default; // 0x000000018BF0E680-0x000000018BF0E6E0
		public static uint RegisterGrassBatchGroup(uint batchGroupKey, Material material, Mesh mesh, ushort subMeshIndex) => default; // 0x000000018BF0E6FC-0x000000018BF0E760
		public static void UnregisterGrassBatchGroupWithHandle(uint batchGroupKey, uint batchGroupHandle) {} // 0x000000018BF0E760-0x000000018BF0E7A0
		public static bool IsInGrassBoundsV2(Vector3 worldPos, out Bounds overlapBounds, out Bounds originBounds, out uint argTag) {
			overlapBounds = default;
			originBounds = default;
			argTag = default;
			return default;
		} // 0x000000018646E48C-0x000000018646E4A4
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList) {} // 0x000000018BF0E6E0-0x000000018BF0E6FC
		private static bool IsInGrassBoundsV2_Injected(ref Vector3 worldPos, out Bounds overlapBounds, out Bounds originBounds, out uint argTag) {
			overlapBounds = default;
			originBounds = default;
			argTag = default;
			return default;
		} // 0x000000018502B6B0-0x000000018502B720
	}

	public enum EInteractionProxyType : uint // TypeDefIndex: 58422
	{
		Sphere = 0,
		Capsule = 1,
		Texture = 2,
		Mesh = 3
	}

	public struct HGInteractionNodeV2 // TypeDefIndex: 58423
	{
		// Fields
		public int m_nodeKey; // 0x00
		public EInteractionProxyType m_proxyType; // 0x04
		public Matrix4x4 m_localToWorldMatrix; // 0x08
		public Matrix4x4 m_prevLocalToWorldMatrix; // 0x48
		public float m_groundHeight; // 0x88
		public bool m_bUseCCD; // 0x8C
		public float m_length; // 0x90
		public float m_radius; // 0x94
		public float m_interactLength; // 0x98
		public float m_interactHeight; // 0x9C
		public int m_texture; // 0xA0
		public Vector2 m_extent; // 0xA4
		public float m_heightScale; // 0xAC
		public int m_mesh; // 0xB0
	}

	public struct HGDecalInteractionParametersV2 // TypeDefIndex: 58424
	{
		// Fields
		public bool m_enableDecalInteraction; // 0x00
		public IntPtr m_decalInteractionMaterial; // 0x08
		public float m_decalNodeWidth; // 0x10
		public float m_decalNodeLength; // 0x14
		public float m_decalNodeHeadLength; // 0x18
		public float m_decalNodeOffset; // 0x1C
		public float m_nodeDistanceThreshold; // 0x20
		public float m_edgeFadeDistance; // 0x24
		public float m_heightFadeDistanceMin; // 0x28
		public float m_heightFadeDistanceMax; // 0x2C
		public float m_rotationThreshold; // 0x30
		public float m_backwardDistanceThreshold; // 0x34
		public float m_timeFadeSpeed; // 0x38
	}

	public static class HGInteractionManagerV2 // TypeDefIndex: 58425
	{
		// Methods
		public static void UpdateFromNodes(NativeArray<HGInteractionNodeV2> nodes, int nodeCount, bool bUpdateMobile) {} // 0x0000000184F27B00-0x0000000184F27B90
		public static void UpdateFromNodes(IntPtr nodeData, int nodeCount, bool bUpdateMobile) {} // 0x0000000184F27B90-0x0000000184F27BF0
		public static void UpdateSettingParameters(HGDecalInteractionParametersV2 settingParameters) {} // 0x000000018BF0E7A0-0x000000018BF0E7B0
		private static void UpdateSettingParameters_Injected(ref HGDecalInteractionParametersV2 settingParameters) {} // 0x000000018512D920-0x000000018512D960
	}

	public struct HGIrradianceVolumeConfig // TypeDefIndex: 58437
	{
		// Fields
		public uint enableLowQualityMode; // 0x00
		public int indirectionTextureSize; // 0x04
		public uint blockCountX; // 0x08
		public uint blockCountY; // 0x0C
		public uint blockCountZ; // 0x10
		public uint hashTableSize; // 0x14
		public _perLOD_e__FixedBuffer perLOD; // 0x18
		public _perHalfChunkCounts_e__FixedBuffer perHalfChunkCounts; // 0x24
		public _perHashTableOffsets_e__FixedBuffer perHashTableOffsets; // 0x30
		public _perHashTableSizes_e__FixedBuffer perHashTableSizes; // 0x3C
		public _perPhysicalTextureOffsets_e__FixedBuffer perPhysicalTextureOffsets; // 0x48
		public _perPhysicalTextureBlockCounts_e__FixedBuffer perPhysicalTextureBlockCounts; // 0x54
		public _perFrameMaxLoadingByteCount_e__FixedBuffer perFrameMaxLoadingByteCount; // 0x60
		public _perFrameMaxUploadChunkCount_e__FixedBuffer perFrameMaxUploadChunkCount; // 0x6C
		public uint perFrameMaxLoadingByteCountV3; // 0x78
		public uint perFrameMaxUploadChunkCountV3; // 0x7C
		public uint maxHashTableSize; // 0x80
		public uint maxInactiveFrameCount; // 0x84
		public _ClipmapTextureSize_e__FixedBuffer ClipmapTextureSize; // 0x88
		public _blockSizesV3_e__FixedBuffer blockSizesV3; // 0x94
		public _cameraForwardBiasForYAxis_e__FixedBuffer cameraForwardBiasForYAxis; // 0xA0
		public uint maxRegionCount; // 0xAC
		public int regionAtlasSizeX; // 0xB0
		public int regionAtlasSizeY; // 0xB4
		public int regionAtlasSizeZ; // 0xB8
		public uint enableLowMemoryMode; // 0xBC
	
		// Nested types
		public struct _perLOD_e__FixedBuffer // TypeDefIndex: 58426
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _perHalfChunkCounts_e__FixedBuffer // TypeDefIndex: 58427
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _perHashTableOffsets_e__FixedBuffer // TypeDefIndex: 58428
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perHashTableSizes_e__FixedBuffer // TypeDefIndex: 58429
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perPhysicalTextureOffsets_e__FixedBuffer // TypeDefIndex: 58430
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perPhysicalTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 58431
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perFrameMaxLoadingByteCount_e__FixedBuffer // TypeDefIndex: 58432
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perFrameMaxUploadChunkCount_e__FixedBuffer // TypeDefIndex: 58433
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _ClipmapTextureSize_e__FixedBuffer // TypeDefIndex: 58434
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _blockSizesV3_e__FixedBuffer // TypeDefIndex: 58435
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _cameraForwardBiasForYAxis_e__FixedBuffer // TypeDefIndex: 58436
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct HGIrradianceVolumePipelineUpdateResult // TypeDefIndex: 58438
	{
		// Fields
		public Vector4 param0; // 0x00
		public Vector4 param1; // 0x10
		public Vector4 param2; // 0x20
		public Vector4 param3; // 0x30
		public Texture indirectionTexture; // 0x40
		public Texture physicalTexture0; // 0x48
		public Texture physicalTexture1; // 0x50
	}

	public class HGIrradianceVolume // TypeDefIndex: 58439
	{
		// Constructors
		public HGIrradianceVolume() {} // Dummy constructor
	
		// Methods
		public static long Create(in HGIrradianceVolumeConfig config) => default; // 0x0000000185F7A610-0x0000000185F7A650
		public static void Destroy(long id) {} // 0x000000018BF0E9C4-0x000000018BF0E9F8
		public static void SetEnableV3(bool enable) {} // 0x000000018512D790-0x000000018512D7D0
		public static void SetSceneStateNames(string[] stateNames, string[] activateStates) {} // 0x000000018535DC40-0x000000018535DC90
		public static void SetActiveSceneStateNames(string[] activateNames) {} // 0x000000018BF0E9F8-0x000000018BF0EA2C
		public static void SetActiveSceneStateMask(uint mask) {} // 0x00000001843BFEE0-0x00000001843BFF20
		public static string[] GetActiveSceneStateNames() => default; // 0x000000018535DBC0-0x000000018535DC00
		public static void SetMap(long id, string path) {} // 0x0000000185F5F5C0-0x0000000185F5F610
		public static void SetMapV3(long id, string path) {} // 0x0000000185F5F610-0x0000000185F5F660
		public static void StreamingInCabin(long id, string slotId, uint roomTypeId) {} // 0x000000018BF0EA2C-0x000000018BF0EA80
		public static void StreamingOutCabin(long id, string slotId) {} // 0x000000018BF0EA80-0x000000018BF0EAC4
		public static void SetStreamingCenter(long id, Vector3 center) {} // 0x000000018646DB28-0x000000018646DB3C
		public static void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResult result, long id, IntPtr renderContext, CommandBuffer cmd, int bakeCS, int updateIndirectionCS) {
			result = default;
		} // 0x00000001840C3870-0x00000001840C38E0
		private static void SetStreamingCenter_Injected(long id, ref Vector3 center) {} // 0x00000001850D1240-0x00000001850D1290
	}

	public struct HGIrradianceVolumeConfigV2 // TypeDefIndex: 58459
	{
		// Fields
		public uint enableLowQualityMode; // 0x00
		public int clipMapTextureSizeX; // 0x04
		public int clipMapTextureSizeY; // 0x08
		public int clipMapTextureSizeZ; // 0x0C
		public _basisBaseGridDim_e__FixedBuffer basisBaseGridDim; // 0x10
		public _basisVoxelDataDim_e__FixedBuffer basisVoxelDataDim; // 0x28
		public uint coeffBaseGridDim; // 0x40
		public uint coeffVoxelDataDim; // 0x44
		public _perCoeffLodBudget_e__FixedBuffer perCoeffLodBudget; // 0x48
		public _perBasisLodBudget_e__FixedBuffer perBasisLodBudget; // 0x54
		public uint lod3BaseGridDim; // 0x60
		public uint lod3VoxelDataDim; // 0x64
		public uint lod3Budget; // 0x68
		public uint rawDataSize; // 0x6C
		public uint modelBufferBudget; // 0x70
		public _perLOD_e__FixedBuffer perLOD; // 0x74
		public _perHalfStreamingChunkCountsX_e__FixedBuffer perHalfStreamingChunkCountsX; // 0x80
		public _perHalfStreamingChunkCountsY_e__FixedBuffer perHalfStreamingChunkCountsY; // 0x8C
		public _perHalfStreamingChunkCountsZ_e__FixedBuffer perHalfStreamingChunkCountsZ; // 0x98
		public _perRawBufferOffsets_e__FixedBuffer perRawBufferOffsets; // 0xA4
		public _perRawBufferCounts_e__FixedBuffer perRawBufferCounts; // 0xB0
		public _perBlockInfoBufferOffsets_e__FixedBuffer perBlockInfoBufferOffsets; // 0xBC
		public _perBlockInfoSize_e__FixedBuffer perBlockInfoSize; // 0xC8
		public _perBasisTextureOffset_e__FixedBuffer perBasisTextureOffset; // 0xD4
		public _perBasisTextureBlockCounts_e__FixedBuffer perBasisTextureBlockCounts; // 0xE0
		public _perCoeffTextureOffset_e__FixedBuffer perCoeffTextureOffset; // 0xEC
		public _perCoeffTextureBlockCounts_e__FixedBuffer perCoeffTextureBlockCounts; // 0xF8
		public _perFrameMaxLoadingByteCount_e__FixedBuffer perFrameMaxLoadingByteCount; // 0x104
		public _perFrameMaxUploadChunkCount_e__FixedBuffer perFrameMaxUploadChunkCount; // 0x110
		public uint maxRegionCount; // 0x11C
		public uint regionAtlasSizeX; // 0x120
		public uint regionAtlasSizeY; // 0x124
		public uint regionAtlasSizeZ; // 0x128
		public _streamingCenterBias_e__FixedBuffer streamingCenterBias; // 0x12C
	
		// Nested types
		public struct _basisBaseGridDim_e__FixedBuffer // TypeDefIndex: 58440
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _basisVoxelDataDim_e__FixedBuffer // TypeDefIndex: 58441
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perCoeffLodBudget_e__FixedBuffer // TypeDefIndex: 58442
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perBasisLodBudget_e__FixedBuffer // TypeDefIndex: 58443
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perLOD_e__FixedBuffer // TypeDefIndex: 58444
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _perHalfStreamingChunkCountsX_e__FixedBuffer // TypeDefIndex: 58445
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _perHalfStreamingChunkCountsY_e__FixedBuffer // TypeDefIndex: 58446
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _perHalfStreamingChunkCountsZ_e__FixedBuffer // TypeDefIndex: 58447
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		public struct _perRawBufferOffsets_e__FixedBuffer // TypeDefIndex: 58448
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perRawBufferCounts_e__FixedBuffer // TypeDefIndex: 58449
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perBlockInfoBufferOffsets_e__FixedBuffer // TypeDefIndex: 58450
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perBlockInfoSize_e__FixedBuffer // TypeDefIndex: 58451
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perBasisTextureOffset_e__FixedBuffer // TypeDefIndex: 58452
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perBasisTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 58453
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perCoeffTextureOffset_e__FixedBuffer // TypeDefIndex: 58454
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perCoeffTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 58455
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perFrameMaxLoadingByteCount_e__FixedBuffer // TypeDefIndex: 58456
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _perFrameMaxUploadChunkCount_e__FixedBuffer // TypeDefIndex: 58457
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		public struct _streamingCenterBias_e__FixedBuffer // TypeDefIndex: 58458
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct HGIrradianceVolumePipelineUpdateResultV2 // TypeDefIndex: 58460
	{
		// Fields
		public Vector4 param0; // 0x00
		public Vector4 param1; // 0x10
		public Vector4 param2; // 0x20
		public Vector4 param3; // 0x30
		public Texture clipmapTextureALod0; // 0x40
		public Texture clipmapTextureBLod0; // 0x48
		public Texture clipmapTextureALod1; // 0x50
		public Texture clipmapTextureBLod1; // 0x58
		public Texture clipmapTextureALod3; // 0x60
		public Texture clipmapTextureBLod3; // 0x68
	}

	public class HGIrradianceVolumeV2 // TypeDefIndex: 58461
	{
		// Constructors
		public HGIrradianceVolumeV2() {} // Dummy constructor
	
		// Methods
		public static long Create(in HGIrradianceVolumeConfigV2 config) => default; // 0x0000000185F9E530-0x0000000185F9E570
		public static void Destroy(long id) {} // 0x000000018BF0E7B0-0x000000018BF0E7E4
		public static void SetSceneStateNames(string[] stateNames, string[] activateStates) {} // 0x000000018535DC90-0x000000018535DCE0
		public static void SetActiveSceneStateNames(string[] activateStates) {} // 0x000000018BF0E848-0x000000018BF0E87C
		public static void SetActiveSceneStateMask(uint mask) {} // 0x00000001843BFF60-0x00000001843BFFA0
		public static string[] GetActiveSceneStateNames() => default; // 0x000000018535DC00-0x000000018535DC40
		public static void SetMap(long id, string path) {} // 0x0000000185F5F660-0x0000000185F5F6B0
		public static void SetStreamingCenter(long id, Vector3 center) {} // 0x000000018BF0E918-0x000000018BF0E92C
		public static void SetCameraForwardDirection(long id, Vector3 cameraForwardDir) {} // 0x000000018BF0E8C0-0x000000018BF0E8D4
		public static void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResultV2 result, long id, IntPtr renderContext, CommandBuffer cmd, int bakeCS, int updateClipmapCS) {
			result = default;
		} // 0x000000018BF0E7E4-0x000000018BF0E848
		public static void StreamingInCabin(long id, long slotId, uint roomTypeId) {} // 0x000000018BF0E92C-0x000000018BF0E980
		public static void StreamingOutCabin(long id, long slotId) {} // 0x000000018BF0E980-0x000000018BF0E9C4
		private static void SetStreamingCenter_Injected(long id, ref Vector3 center) {} // 0x000000018BF0E8D4-0x000000018BF0E918
		private static void SetCameraForwardDirection_Injected(long id, ref Vector3 cameraForwardDir) {} // 0x000000018BF0E87C-0x000000018BF0E8C0
	}

	public static class HGMeshRender // TypeDefIndex: 58462
	{
		// Methods
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalKeywords, IntPtr context, bool multiDraw, bool transparentSorting, uint cullingLayerMask, bool noAlphaTest, uint* drawableFeedbackPtr, bool excludeGPUDriven) => default; // 0x000000018BF0ECE0-0x000000018BF0ED54
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, bool excludeGPUDriven) {} // 0x000000018BF0EB78-0x000000018BF0EBD8
		private static uint CreateRendererListWithCharacterIndex(uint viewHandle, ushort characterIndex, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalHGKeywords, IntPtr context) => default; // 0x000000018BF0EAF0-0x000000018BF0EB5C
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, bool multiDraw = false /* Metadata: 0x0207F603 */, bool transparentSorting = false /* Metadata: 0x0207F604 */, uint cullingLayerMask = 4294967295 /* Metadata: 0x0207F605 */, bool noAlphaTest = false /* Metadata: 0x0207F606 */, bool excludeGPUDriven = false /* Metadata: 0x0207F607 */) => default; // 0x000000018BF0EC00-0x000000018BF0EC6C
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, IntPtr drawableFeedbackPtr, bool multiDraw = false /* Metadata: 0x0207F608 */, bool transparentSorting = false /* Metadata: 0x0207F609 */, uint cullingLayerMask = 4294967295 /* Metadata: 0x0207F60A */, bool noAlphaTest = false /* Metadata: 0x0207F60B */, bool excludeGPUDriven = false /* Metadata: 0x0207F60C */) => default; // 0x000000018BF0EC6C-0x000000018BF0ECE0
		public static uint CreateRendererListWithCharacterIndex(uint viewHandle, ushort characterIndex, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context) => default; // 0x000000018BF0EB5C-0x000000018BF0EB78
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, out uint normalList, out uint preZPart0List, out uint preZPart1List, bool excludeGPUDriven = false /* Metadata: 0x0207F60D */) {
			normalList = default;
			preZPart0List = default;
			preZPart1List = default;
		} // 0x000000018BF0EBD8-0x000000018BF0EC00
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList) {} // 0x000000018BF0ED80-0x000000018BF0ED9C
		public static void DrawECSMeshRendererListWithSRPRendererList(CommandBuffer cmd, uint ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList) {} // 0x000000018BF0ED54-0x000000018BF0ED80
	}

	public static class HGRayTracingScene // TypeDefIndex: 58463
	{
		// Methods
		public static uint AddCullViewHandle(ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, LODCrossFadeConfig config, float viewScreenSizeMinSquared, float cullingRadius) => default; // 0x000000018BF0EEEC-0x000000018BF0EF28
		public static uint PrepareTLASCreationForCullView(uint viewHandle) => default; // 0x000000018BF0EF28-0x000000018BF0EF5C
		private static uint AddCullViewHandle_Injected(ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, ref LODCrossFadeConfig config, float viewScreenSizeMinSquared, float cullingRadius) => default; // 0x000000018BF0EE8C-0x000000018BF0EEEC
	}

	public class HGReflectionProbe // TypeDefIndex: 58464
	{
		// Properties
		public static float cameraMovementNotFadeness { get => default; } // 0x000000018BF0F0D8-0x000000018BF0F104 
		public static float fadeTime { get => default; } // 0x000000018519E0E0-0x000000018519E120 
	
		// Constructors
		public HGReflectionProbe() {} // Dummy constructor
	
		// Methods
		public static uint AddView(Camera camera) => default; // 0x0000000185F56B20-0x0000000185F56B60
		public static void RemoveView(uint viewHandle) {} // 0x0000000185F7DDF0-0x0000000185F7DE30
		public static void ResetView(uint viewHandle) {} // 0x0000000185F56AE0-0x0000000185F56B20
		public static void UpdateViewPhase0(uint viewHandle, Vector3 cameraPosition, Vector3 visibleBox, bool loadSync = false /* Metadata: 0x0207F60E */) {} // 0x000000018BF0F060-0x000000018BF0F078
		public static void UpdateViewPhase1(uint viewHandle, float dt, bool enableFadeness, IntPtr blitList, int maxBlitCount, out int blitCount) {
			blitCount = default;
		} // 0x000000018BF0F078-0x000000018BF0F0D8
		public static void UpdateViewCBHandle(uint viewHandle, Matrix4x4 worldToCameraMatrix, Matrix4x4 unitExtents, IntPtr binningBufferPtr, IntPtr globalBufferPtr) {} // 0x000000018BF0F03C-0x000000018BF0F060
		public static Texture GetTexture(uint viewHandle, ulong hash) => default; // 0x000000018BF0EF9C-0x000000018BF0EFDC
		public static int GetTextureIndex(uint viewHandle, ulong hash) => default; // 0x000000018BF0EF5C-0x000000018BF0EF9C
		public static void SetViewTextureArrayCount(uint viewHandle, int count) {} // 0x0000000185F374B0-0x0000000185F37500
		private static void UpdateViewPhase0_Injected(uint viewHandle, ref Vector3 cameraPosition, ref Vector3 visibleBox, bool loadSync = false /* Metadata: 0x0207F60F */) {} // 0x000000018502CB30-0x000000018502CBA0
		private static void UpdateViewCBHandle_Injected(uint viewHandle, ref Matrix4x4 worldToCameraMatrix, ref Matrix4x4 unitExtents, IntPtr binningBufferPtr, IntPtr globalBufferPtr) {} // 0x000000018BF0EFDC-0x000000018BF0F03C
	}

	public enum AssetType // TypeDefIndex: 58465
	{
		Invalid = 0,
		Material = 1,
		Mesh = 2,
		Texture2D = 3,
		Texture3D = 4,
		CubeMap = 5,
		ScriptableObject = 6,
		Shader = 7,
		ComputeShader = 8,
		TerrainLayer = 9,
		SubsurfaceProfile = 10,
		Count = 11
	}

	public enum AssetPriority : ushort // TypeDefIndex: 58466
	{
		Preload = 0,
		LODStreaming = 5,
		Default = 10,
		Streaming = 15
	}

	public enum AssetState : byte // TypeDefIndex: 58467
	{
		Loading = 0,
		Loaded = 1,
		Failed = 2
	}

	public struct VFSBlockFileInfo // TypeDefIndex: 58468
	{
		// Fields
		public ulong offset; // 0x00
		public ulong len; // 0x08
		public string chunkFilePath; // 0x10
	}

	public struct AssetIdentifier // TypeDefIndex: 58469
	{
		// Fields
		public long hash; // 0x00
		public AssetType type; // 0x08
	}

	public struct AssetHandleIndex // TypeDefIndex: 58470
	{
		// Fields
		public uint index; // 0x00
	}

	public struct AssetOperation // TypeDefIndex: 58471
	{
		// Fields
		public bool isLoadOperation; // 0x00
		public AssetPriority priority; // 0x02
		public AssetHandleIndex handleIndex; // 0x04
		public AssetIdentifier identifier; // 0x08
	}

	public static class HGResourceManager // TypeDefIndex: 58475
	{
		// Fields
		public static GetFileHashMappingCallback getFileHashMappingCallback; // 0x00
		public static GetFilePathMappingCallback getFilePathMappingCallback; // 0x08
		public static GetTextureFromHGWaterSectorDataCallback getWaterSectorTextureCallback; // 0x10
		private static readonly System.Type[] kAssetTypeToUnityType; // 0x18
	
		// Properties
		public static bool usingVFS { get; set; } // 0x000000018401ADC0-0x000000018401AE60
		public static IntPtr assetOperations { get; } // 0x000000018BF0F2D4-0x000000018BF0F33C 
		public static int assetOperationCount { get; } // 0x000000018BF0F33C-0x000000018BF0F3A0 
	
		// Nested types
		public delegate VFSBlockFileInfo GetFileHashMappingCallback(long originNameHash); // TypeDefIndex: 58472; 0x0000000185216600-0x0000000185216690
	
		public delegate VFSBlockFileInfo GetFilePathMappingCallback(string originName); // TypeDefIndex: 58473; 0x00000001853E41C0-0x00000001853E4210
	
		public delegate Texture2D GetTextureFromHGWaterSectorDataCallback(ScriptableObject sectorDataScriptableObject); // TypeDefIndex: 58474; 0x00000000-0x00000000
	
		// Constructors
		static HGResourceManager() {} // 0x000000018448D310-0x000000018448D3A0
	
		// Methods
		public static AssetHandleIndex LoadAsync(long assetHash, AssetType type, AssetPriority priority) => default; // 0x000000018401AB40-0x000000018401AB80
		public static void Dispose(AssetHandleIndex assetHandle) {} // 0x000000018401AA70-0x000000018401AB40
		public static AssetState GetAssetState(AssetHandleIndex assetHandle) => default; // 0x000000018401A9F0-0x000000018401AA30
		private static UnityEngine.Object GetAsset(AssetHandleIndex assetHandle) => default; // 0x000000018448D2D0-0x000000018448D310
		public static bool TryGetAsset<T>(AssetHandleIndex assetHandle, out ref T asset)
			where T : UnityEngine.Object {
			asset = default;
			return default;
		} // 0x0000000185103940-0x00000001851039F0
		public static void UpdateAssetHandle(AssetHandleIndex handleIndex, AssetIdentifier identifier, AssetState state, int assetInstanceID) {} // 0x000000018BF0F23C-0x000000018BF0F2D4
		public static void ClearAssetOperations() {} // 0x000000018BF0F1A8-0x000000018BF0F23C
		public static void Reset() {} // 0x0000000185A29220-0x0000000185A29500
		public static VFSBlockFileInfo GetFileHashMapping(long originNameHash) => default; // 0x0000000185216500-0x0000000185216570
		public static VFSBlockFileInfo GetFilePathMapping(string originName) => default; // 0x00000001852165C0-0x0000000185216600
		public static Texture2D GetTextureFromHGWaterSectorData(ScriptableObject sectorDataScriptableObject) => default; // 0x00000001853E4210-0x00000001853E4250
		public static System.Type ToUnityType(AssetType type) => default; // 0x00000001853E4180-0x00000001853E41C0
		public static NativeArray<AssetOperation> GetAssetOperationsArray() => default; // 0x000000018401AE60-0x000000018401AED0
		private static void LoadAsync_Injected(long assetHash, AssetType type, AssetPriority priority, out AssetHandleIndex ret) {
			ret = default;
		} // 0x0000000183779FF0-0x000000018377A030
		private static void Dispose_Injected(ref AssetHandleIndex assetHandle) {} // 0x000000018448D3A0-0x000000018448D430
		private static AssetState GetAssetState_Injected(ref AssetHandleIndex assetHandle) => default; // 0x0000000183779FF0-0x000000018377A030
		private static UnityEngine.Object GetAsset_Injected(ref AssetHandleIndex assetHandle) => default; // 0x000000018448D430-0x000000018448D4C0
		private static void UpdateAssetHandle_Injected(ref AssetHandleIndex handleIndex, ref AssetIdentifier identifier, AssetState state, int assetInstanceID) {} // 0x00000001817C2F70-0x00000001817C2F80
	}

	public enum HGRenderFlags : uint // TypeDefIndex: 58476
	{
		None = 0,
		PreZ = 1,
		ShadowTwoSided = 2,
		NegativeScale = 4,
		PreZEqual = 8,
		AlphaTest = 16,
		Opaque = 256,
		Transparent = 512,
		ShadowOnly = 1024,
		TransparentBeforeDistortion = 2048,
		TransparentAfterDistortionBeforePP = 4096,
		TransparentAfterDistortion = 8192,
		TransparentAfterPP = 16384,
		HasCustomProps = 32768,
		ManualDither = 131072,
		CameraDither = 262144,
		CastShadow = 524288,
		CSMShadowCascade0 = 1048576,
		CSMShadowCascade1 = 2097152,
		CSMShadowCascade2 = 4194304,
		CSMShadowCascade3 = 8388608,
		CSMShadows = 15728640,
		StaticShadowCaster = 16777216,
		RealtimeShadowCaster = 33554432,
		EnableCharacterOutline = 67108864,
		RayTracing = 134217728
	}

	public enum HGRenderKeyword : ushort // TypeDefIndex: 58477
	{
		None = 0,
		CrossFade = 1,
		Dither = 2
	}

	public enum HGShaderLightMode : uint // TypeDefIndex: 58478
	{
		None = 0,
		GBuffer = 1,
		GBufferMobile = 2,
		Erosion = 4,
		ErosionMobile = 8,
		ErosionClear = 16,
		ForwardOnly = 32,
		Forward = 64,
		ForwardCharacterOnly = 128,
		ForwardReflection = 256,
		CharacterOutline = 512,
		ShadowCaster = 1024,
		DepthOnly = 2048,
		DepthCharacterOnly = 4096,
		SRPDefaultUnlit = 8192,
		ForwardDecal = 16384,
		VFXDecal = 32768,
		WetnessDecal = 65536,
		Distortion = 131072,
		FullScreenDebug = 262144,
		OccludedDisplay = 524288,
		TerrainVTDecal = 1048576,
		TerrainVTDecalMobile = 2097152,
		RayTracingReflection = 4194304,
		StencilAlphaBlend = 8388608,
		WaterMarkUI = 16777216,
		ForwardAfterUI = 33554432
	}

	public enum HGObjectFlags : uint // TypeDefIndex: 58479
	{
		None = 0,
		Enabled = 1,
		CastShadow = 2,
		NegativeScale = 4,
		PrevResReady = 256,
		CurrResReady = 512,
		CanBeRenderedMask = 513,
		TempResReady = 1024,
		ResReadyMask = 1792,
		PrevHideByHLODSystem = 2048,
		CurrHideByHLODSystem = 4096,
		TempHideAsHLODChildByHLODSystem = 8192,
		TempHideAsHLODParentByHLODSystem = 16384,
		TempHideByHLODSystemMask = 24576,
		HideByHLODSystemMask = 30720,
		TransformDirty = 32768,
		Static = 65536,
		ManualDither = 131072,
		CameraDither = 262144,
		ToRenderFlagMask = 393220,
		FoliageOccluder = 524288,
		CpuSkinning = 1048576,
		VertexSkinning = 2097152,
		SkinningMask = 3145728,
		CSMShadowCascade0 = 4194304,
		CSMShadowCascade1 = 8388608,
		CSMShadowCascade2 = 16777216,
		CSMShadowCascade3 = 33554432,
		CSMShadows = 62914560,
		StaticShadowCaster = 67108864,
		RealtimeShadowCaster = 134217728
	}

	public enum HGFactoryDirtyFlags : byte // TypeDefIndex: 58480
	{
		None = 0,
		PerDrawData = 1,
		ObjectData = 2,
		TransformData = 4,
		VFXStatus = 16,
		VFXVisibility = 32
	}

	public struct IVec2 // TypeDefIndex: 58481
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
	}

	public struct IVec4 // TypeDefIndex: 58482
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public int w; // 0x0C
	}

	public struct SludgeNodeData // TypeDefIndex: 58484
	{
		// Fields
		public byte allHole; // 0x00
		public byte treeLevel; // 0x01
		public ushort parent; // 0x02
		public Vector3 aabbCenter; // 0x04
		public Vector3 aabbExtent; // 0x10
		public _patchAABBData_e__FixedBuffer patchAABBData; // 0x1C
	
		// Nested types
		public struct _patchAABBData_e__FixedBuffer // TypeDefIndex: 58483
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct SludgeHeightmapInfo // TypeDefIndex: 58485
	{
		// Fields
		public Vector4 heightmapUVOffsetScale; // 0x00
		public Texture2D heightmapAtlas; // 0x10
	}

	public static class HGSludgeRender // TypeDefIndex: 58486
	{
		// Methods
		public static bool RegisterSludge(Entity entity, Texture2D bakedHeightmap, NativeArray<SludgeNodeData> nodeData) => default; // 0x0000000185147270-0x00000001851472E0
		private static bool RegisterSludge(Entity entity, Texture2D bakedHeightmap, int nodeCount, IntPtr nodeData) => default; // 0x0000000186473684-0x00000001864736A8
		public static void UnregisterAndDestroySludge(Entity entity) {} // 0x000000018BF0F770-0x000000018BF0F78C
		public static uint CreateRendererList(Camera camera, Vector2Int sceneRTSize, uint viewHandle, HGShaderLightMode lightModeMask, HGShaderLightMode decalLightModeMask, float lodFactor, IntPtr context, bool useMetric = true /* Metadata: 0x0207F723 */) => default; // 0x000000018BF0F498-0x000000018BF0F4B4
		private static uint CreateRendererList(Camera camera, Vector2Int sceneRTSize, uint viewHandle, uint lightModeMask, uint decalLightModeMask, float loadFactor, IntPtr context, bool useMetric) => default; // 0x000000018BF0F4B4-0x000000018BF0F508
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customPros) {} // 0x000000018BF0F5A8-0x000000018BF0F5F8
		public static void DrawECSDecalRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customProps) {} // 0x000000018BF0F558-0x000000018BF0F5A8
		public static void DrawECSBlendRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customProps) {} // 0x000000018BF0F508-0x000000018BF0F558
		public static void HitSludge(Entity entity, Vector3 worldPos, float range, float deltaHeightNormalized = 1f /* Metadata: 0x0207F724 */) {} // 0x000000018BF0F6EC-0x000000018BF0F710
		public static SludgeHeightmapInfo GetHeightmapInfo(Entity entity) => default; // 0x00000001851473D0-0x0000000185147410
		public static uint GetDynamicThicknessMapSize() => default; // 0x000000018BF0F65C-0x000000018BF0F688
		public static bool ShouldDrawThicknessMap() => default; // 0x000000018BF0F710-0x000000018BF0F73C
		public static void DrawThicknessMap(IntPtr context, CommandBuffer cmd, Material blitMat, int passIdx, int viewHandle) {} // 0x000000018BF0F5F8-0x000000018BF0F65C
		private static bool RegisterSludge_Injected(ref Entity entity, Texture2D bakedHeightmap, int nodeCount, IntPtr nodeData) => default; // 0x0000000185EDB270-0x0000000185EDB2E0
		private static void UnregisterAndDestroySludge_Injected(ref Entity entity) {} // 0x000000018BF0F73C-0x000000018BF0F770
		private static uint CreateRendererList_Injected(Camera camera, ref Vector2Int sceneRTSize, uint viewHandle, uint lightModeMask, uint decalLightModeMask, float loadFactor, IntPtr context, bool useMetric) => default; // 0x000000018BF0F434-0x000000018BF0F498
		private static void HitSludge_Injected(ref Entity entity, ref Vector3 worldPos, float range, float deltaHeightNormalized = 1f /* Metadata: 0x0207F728 */) {} // 0x000000018BF0F688-0x000000018BF0F6EC
		private static void GetHeightmapInfo_Injected(ref Entity entity, out SludgeHeightmapInfo ret) {
			ret = default;
		} // 0x0000000185147380-0x00000001851473D0
	}

	public enum SplineEmissionType // TypeDefIndex: 58487
	{
		Box = 0,
		Mesh = 1
	}

	public enum SplineEmissionMeshType // TypeDefIndex: 58488
	{
		Triangle = 0,
		Vertex = 1,
		Edge = 2
	}

	[Serializable]
	public struct SplineObjectsDesc // TypeDefIndex: 58489
	{
		// Fields
		public string name; // 0x00
		public bool useLogicDeltaTime; // 0x08
		public bool prewarm; // 0x09
		public bool has3dStartRotation; // 0x0A
		public bool hasNoise; // 0x0B
		public bool hasAlphaControl; // 0x0C
		public bool hasRotation; // 0x0D
		public bool has3dRotation; // 0x0E
		public float simulateSpeed; // 0x10
		public float emissionRateOverTime; // 0x14
		public float transparentAlpha; // 0x18
		public Vector3 emissionMeshScale; // 0x1C
		public SplineEmissionType emissionType; // 0x28
		public SplineEmissionMeshType emissionMeshType; // 0x2C
		public Matrix4x4 objectToWorld; // 0x30
		public Bounds aabb; // 0x70
		public ulong sceneMask; // 0x88
		public Mesh emissionMesh; // 0x90
		public LODGroup[] lodGroups; // 0x98
		public ParticleSystem.MinMaxCurve startLifeTime; // 0xA0
		public ParticleSystem.MinMaxCurve startSize; // 0xC0
		public ParticleSystem.MinMaxCurve rotationOverLifeTime; // 0xE0
		public ParticleSystem.MinMaxCurve rotationXOverLifeTime; // 0x100
		public ParticleSystem.MinMaxCurve rotationYOverLifeTime; // 0x120
		public ParticleSystem.MinMaxCurve startRotationX; // 0x140
		public ParticleSystem.MinMaxCurve startRotationY; // 0x160
		public ParticleSystem.MinMaxCurve startRotationZ; // 0x180
		public ParticleSystem.MinMaxCurve sizeOverLifeTime; // 0x1A0
		public ParticleSystem.MinMaxCurve velocityOverLifeTime; // 0x1C0
		public ParticleSystem.MinMaxCurve alphaOverLifeTime; // 0x1E0
		public ParticleSystem.MinMaxCurve noiseAmplitudeLifeTime; // 0x200
		public ParticleSystem.MinMaxCurve noiseFrequencyLifeTime; // 0x220
	}

	[Serializable]
	public struct SplineObjectsKnotData // TypeDefIndex: 58490
	{
		// Fields
		public Vector3 p0; // 0x00
		public Vector3 p1; // 0x0C
		public Vector3 p2; // 0x18
		public Vector3 p3; // 0x24
		public float length; // 0x30
	}

	public static class HGSplineMovingObjectsManager // TypeDefIndex: 58491
	{
		// Methods
		public static uint CreateInstance(SplineObjectsDesc desc, NativeArray<SplineObjectsKnotData> curveData) => default; // 0x000000018BF0FA54-0x000000018BF0FB24
		public static bool DestroyInstance(uint instanceID) => default; // 0x000000018BF0FB38-0x000000018BF0FB6C
		public static bool UpdateObjectToWorld(uint instanceID, Matrix4x4 objectToWorld) => default; // 0x000000018BF0FBE0-0x000000018BF0FBF4
		public static bool Pause(uint instanceID) => default; // 0x000000018BF0FB6C-0x000000018BF0FBA0
		private static unsafe uint CreateInstance(SplineObjectsDesc desc, SplineObjectsKnotData* curveData, int length) => default; // 0x000000018BF0FB24-0x000000018BF0FB38
		private static bool UpdateObjectToWorld_Injected(uint instanceID, ref Matrix4x4 objectToWorld) => default; // 0x000000018BF0FBA0-0x000000018BF0FBE0
		private static unsafe uint CreateInstance_Injected(ref SplineObjectsDesc desc, SplineObjectsKnotData* curveData, int length) => default; // 0x000000018BF0FA00-0x000000018BF0FA54
	}

	public static class HGSubsurfaceProfileManager // TypeDefIndex: 58492
	{
		// Methods
		public static void RegisterFromTerrain(HGSubsurfaceProfile profile) {} // 0x00000001849470B0-0x00000001849471A0
		public static void UnregisterFromTerrain() {} // 0x000000018BF0FDCC-0x000000018BF0FDF8
	}

	public struct TerrainNodePayload // TypeDefIndex: 58493
	{
		// Fields
		public Texture2D heightmapPage; // 0x00
		public Texture2D normalmapPage; // 0x08
		public Texture2D tintColorPage; // 0x10
		public Texture2D splatCtrlPage; // 0x18
		public Texture2D albedoPage; // 0x20
	}

	public struct TerrainSplatPayload // TypeDefIndex: 58494
	{
		// Fields
		public Texture2D diffuseTex; // 0x00
		public Texture2D normalROTex; // 0x08
		public Texture2D coneMapTex; // 0x10
	}

	public struct TerrainInfo // TypeDefIndex: 58495
	{
		// Fields
		public Vector3 terrainPosition; // 0x00
		public float heightScale; // 0x0C
		public uint terrainSize; // 0x10
		public ushort heightmapPageSize; // 0x14
		public ushort normalmapPageSize; // 0x16
		public ushort tintColorPageSize; // 0x18
		public ushort splatCtrlPageSize; // 0x1A
		public ushort albedoTexPageSize; // 0x1C
	}

	public struct TerrainNodeData // TypeDefIndex: 58496
	{
		// Fields
		public byte allHole; // 0x00
		public byte nodeLevel; // 0x01
		public ushort parent; // 0x02
		public float localMinHeight; // 0x04
		public float localMaxHeight; // 0x08
		public float maxHeightError; // 0x0C
	}

	public struct SplatLayerData // TypeDefIndex: 58497
	{
		// Fields
		public Vector4 packedSplatInfo; // 0x00
		public Vector4 splatST; // 0x10
		public Vector4 diffuseRemapScale; // 0x20
		public Vector4 maskMapRemapOffset; // 0x30
		public Vector4 maskMapRemapScale; // 0x40
		public Vector4 packedDeformParams; // 0x50
		public Vector4 pomParams; // 0x60
	}

	public class HGTerrainManager // TypeDefIndex: 58498
	{
		// Properties
		public static float minVerticalFieldOfView { set {} } // 0x0000000185216020-0x0000000185216070
	
		// Constructors
		public HGTerrainManager() {} // Dummy constructor
	
		// Methods
		public static void ReadbackVTFeedbackBuffer(int feedbackViewId, CommandBuffer cmd, IntPtr renderContext) {} // 0x000000018BF10158-0x000000018BF101A8
		public static unsafe void* GetTerrainNodesForCanceling(out int length) {
			length = default;
			return default;
		} // 0x0000000184BCD260-0x0000000184BCD2A0
		public static unsafe void* GetTerrainNodesForStreaming(out int length) {
			length = default;
			return default;
		} // 0x0000000184BCD2A0-0x0000000184BCD2E0
		public static ulong GetTerrainSplatsForCanceling() => default; // 0x0000000184BCD1E0-0x0000000184BCD220
		public static ulong GetTerrainSplatsForStreaming() => default; // 0x0000000184BCD220-0x0000000184BCD260
		public static void ResetTerrainNodesForCanceling() {} // 0x0000000184BCD360-0x0000000184BCD3A0
		public static void ResetTerrainNodesForStreaming() {} // 0x0000000184BCD3A0-0x0000000184BCD3E0
		public static void ResetTerrainSplatsForCanceling() {} // 0x0000000184BCD2E0-0x0000000184BCD320
		public static void ResetTerrainSplatsForStreaming() {} // 0x0000000184BCD320-0x0000000184BCD360
		public static bool StreamingInTerrainNodePayload(uint nodeKey, in TerrainNodePayload payload) => default; // 0x000000018441B6F0-0x000000018441B740
		public static void StreamingInTerrainSplat(uint splatIdx, TerrainSplatPayload payload) {} // 0x000000018BF10430-0x000000018BF10444
		public static void ResetLoadingStatusForAllNodes() {} // 0x0000000184947DE0-0x0000000184947E20
		public static void ResetLoadingStatusForAllSplats() {} // 0x0000000184947DA0-0x0000000184947DE0
		public static void SetupTerrainManager(in TerrainInfo terrainInfo, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, NativeArray<UnityEngine.HyperGryph.SplatLayerData> layerData, Texture2D[] splatDiffuseTextures, Texture2D[] splatNormalTextures, Texture2D[] splatConeMapTextures, int splatTier, NativeArray<UnityEngine.HyperGryph.TerrainNodeData> nodeData, NativeArray<ulong> sectorSplatInfo, bool enableHalfVTSize, bool enableHalfAtlasSize = false /* Metadata: 0x0207F731 */, GraphicsFormat mobileSplatCtrlAtlasFormat = GraphicsFormat.RGBA_ASTC4X4_UNorm /* Metadata: 0x0207F732 */, bool enableIndirectionCpuUpload = false /* Metadata: 0x0207F734 */) {} // 0x0000000184945DB0-0x0000000184945F10
		private static void SetupTerrainManager(in TerrainInfo terrainInfo, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, int layerCount, IntPtr layerData, Texture2D[] splatDiffuseTextures, Texture2D[] splatNormalTextures, Texture2D[] splatConeMapTextures, int splatTier, int nodeCount, IntPtr nodeData, int sectorCount, IntPtr sectorSplatInfo, bool enableHalfVTSize, bool enableHalfAtlasSize, GraphicsFormat mobileSplatCtrlAtlasFormat, bool enableIndirectionCpuUpload) {} // 0x0000000184945F10-0x0000000184945FB0
		public static void CleanupTerrainManager() {} // 0x000000018BF0FDF8-0x000000018BF0FE24
		public static uint CullTerrainAndUpdateVTFeedbackView(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, Vector3 vtUpdateCenter) => default; // 0x000000018BF0FE24-0x000000018BF0FE84
		public static uint CullTerrain(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext) => default; // 0x000000018BF0FEE8-0x000000018BF0FF1C
		public static void PrepareDecalRendererListsForVTPages(int feedbackViewId, IntPtr renderContext) {} // 0x000000018BF10118-0x000000018BF10158
		public static void ExecuteVTUpdateCommand(int feedbackViewId, IntPtr renderContext) {} // 0x000000018BF0FF1C-0x000000018BF0FF5C
		public static void RenderVTPages(int feedbackViewId, IntPtr renderContext, CommandBuffer copyCmd, CommandBuffer renderCmd, int bakePassIndex, int bc3PassIndex, int astcPassIndex, int bc5PassIndex) {} // 0x000000018BF102C8-0x000000018BF10328
		public static void RenderScreenSpaceTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr features) {} // 0x000000018BF101A8-0x000000018BF10208
		public static void RenderTerrainAfterGBuffer(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, IntPtr features) {} // 0x000000018BF10208-0x000000018BF10268
		public static void UpdateSubdivisionParameters(int mode, int modeV2, int subd, int primitivePixelLengthTargetLog2) {} // 0x000000018BF104A4-0x000000018BF10504
		public static void SetTerrainBlendBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId) {} // 0x000000018BF1038C-0x000000018BF103F0
		public static void SetDecalDeformBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId) {} // 0x000000018BF10328-0x000000018BF1038C
		public static Texture2D GetHeightmapAtlas() => default; // 0x000000018BF0FF88-0x000000018BF0FFB4
		public static Texture2D GetNormalmapAtlas() => default; // 0x000000018BF0FFB4-0x000000018BF0FFE0
		public static Texture2D GetTintColorAtlas() => default; // 0x000000018BF100EC-0x000000018BF10118
		public static Texture2D GetSplatControlAtlas() => default; // 0x000000018BF0FFE0-0x000000018BF1000C
		public static Texture2D GetAlbedoAtlas() => default; // 0x000000018BF0FF5C-0x000000018BF0FF88
		public static Texture2D GetSplatIndexMap() => default; // 0x000000018BF10094-0x000000018BF100C0
		public static Texture2DArray GetSplatDiffuseArray() => default; // 0x000000018BF10068-0x000000018BF10094
		public static Texture2DArray GetSplatNormalROArray() => default; // 0x000000018BF100C0-0x000000018BF100EC
		public static CBHandle GetSplatDataUBO() => default; // 0x000000018BF10040-0x000000018BF10068
		public static void SubdivisionTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, bool enableSubdivision, bool enableSubdivisionV2, Texture HZBTexture) {} // 0x000000018BF10444-0x000000018BF104A4
		public static void RenderTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, int tessellationPassIndex = -1 /* Metadata: 0x0207F735 */, int subdivisionPassIndex = -1 /* Metadata: 0x0207F736 */, bool enableSubdivisionV2 = false /* Metadata: 0x0207F737 */) {} // 0x000000018BF10268-0x000000018BF102C8
		public static void StreamingInChunkSurfaceTypeData(uint chunkKey, UIntPtr chunkSurfaceTypeData, int dataLength, int chunkSize) {} // 0x000000018572A9C0-0x000000018572AA30
		public static void StreamingOutChunkSurfaceTypeData(uint chunkKey) {} // 0x000000018572AA30-0x000000018572AA70
		public static bool GetSurfaceTypeByWorldPosition(float x, float y, out int surfaceType) {
			surfaceType = default;
			return default;
		} // 0x00000001847F89F0-0x00000001847F8A50
		private static void StreamingInTerrainSplat_Injected(uint splatIdx, ref TerrainSplatPayload payload) {} // 0x000000018BF103F0-0x000000018BF10430
		private static uint CullTerrainAndUpdateVTFeedbackView_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, ref Vector3 vtUpdateCenter) => default; // 0x0000000184F0EB00-0x0000000184F0EB80
		private static uint CullTerrain_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext) => default; // 0x000000018BF0FE84-0x000000018BF0FEE8
		private static void GetSplatDataUBO_Injected(out CBHandle ret) {
			ret = default;
		} // 0x000000018BF1000C-0x000000018BF10040
	}

	public class HGEditorTerrainManager // TypeDefIndex: 58499
	{
		// Constructors
		public HGEditorTerrainManager() {} // Dummy constructor
	
		// Methods
		public static void SetUseNewEditorTerrainRendering(bool value) {} // 0x0000000184BCB490-0x0000000184BCB4D0
		public static uint CullTerrainAndUpdateVTFeedbackView(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, Vector3 vtUpdateCenter) => default; // 0x000000018BF0DA90-0x000000018BF0DAF0
		public static uint CullTerrain(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext) => default; // 0x000000018BF0DB54-0x000000018BF0DB88
		public static void SetTerrainBlendBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId) {} // 0x000000018BF0DE38-0x000000018BF0DE9C
		public static void RenderTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, int subdivisionPassIndex = -1 /* Metadata: 0x0207F738 */, bool enableSubdivisionV2 = false /* Metadata: 0x0207F739 */) {} // 0x000000018BF0DD78-0x000000018BF0DDD8
		public static void RenderScreenSpaceTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr features) {} // 0x000000018BF0DC58-0x000000018BF0DCB8
		public static void RenderSeparateTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int passIndex, IntPtr features) {} // 0x000000018BF0DCB8-0x000000018BF0DD18
		public static void RenderTerrainAfterGBuffer(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, IntPtr features) {} // 0x000000018BF0DD18-0x000000018BF0DD78
		public static void BakeAtlasTexture(CommandBuffer cmd, IntPtr renderContext) {} // 0x000000018BF0DA4C-0x000000018BF0DA90
		public static void PrepareDecalRendererListsForVTPages(int feedbackViewId, IntPtr renderContext) {} // 0x000000018BF0DBC8-0x000000018BF0DC08
		public static void ExecuteVTUpdateCommand(int feedbackViewId, IntPtr renderContext) {} // 0x000000018BF0DB88-0x000000018BF0DBC8
		public static void RenderVTPages(int feedbackViewId, IntPtr renderContext, CommandBuffer copyCmd, CommandBuffer renderCmd, int bakePass, int bc3Pass, int astcPass) {} // 0x000000018BF0DDD8-0x000000018BF0DE38
		public static void ReadbackVTFeedbackBuffer(int feedbackViewId, CommandBuffer cmd, IntPtr renderContext) {} // 0x000000018BF0DC08-0x000000018BF0DC58
		private static uint CullTerrainAndUpdateVTFeedbackView_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, ref Vector3 vtUpdateCenter) => default; // 0x0000000184F0EB80-0x0000000184F0EC00
		private static uint CullTerrain_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext) => default; // 0x000000018BF0DAF0-0x000000018BF0DB54
	}

	public struct HGTerrainDeformConfigV2 // TypeDefIndex: 58500
	{
		// Fields
		public float m_deformGlobalStrength; // 0x00
		public float m_latency; // 0x04
	}

	public class HGTerrainDeformManagerV2 // TypeDefIndex: 58501
	{
		// Constructors
		public HGTerrainDeformManagerV2() {} // Dummy constructor
	
		// Methods
		public static void SetPlayerCenter(Vector3 position) {} // 0x000000018646ECF0-0x000000018646ED00
		public static void UpdateDeformConfig(HGTerrainDeformConfigV2 config) {} // 0x00000001864729D8-0x00000001864729F4
		private static void SetPlayerCenter_Injected(ref Vector3 position) {} // 0x00000001853B0870-0x00000001853B08B0
		private static void UpdateDeformConfig_Injected(ref HGTerrainDeformConfigV2 config) {} // 0x0000000184EC6250-0x0000000184EC6290
	}

	public static class HGUIRender // TypeDefIndex: 58502
	{
		// Methods
		public static uint CreateRendererList(uint cullingLayerMask, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, short sortingOrderMin, short sortingOrderMax, int cameraInstanceID, IntPtr context, bool isWorldUI, float wolrdUICullingDistance = 3.4028235E+38f /* Metadata: 0x0207F73A */) => default; // 0x000000018BF10780-0x000000018BF107B0
		private static uint CreateRendererList(uint cullingLayerMask, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, short sortingOrderMin, short sortingOrderMax, int cameraInstanceID, IntPtr context, bool isWorldUI, float wolrdUICullingDistance) => default; // 0x000000018BF107B0-0x000000018BF10834
	}

	public static class HGWaterRender // TypeDefIndex: 58506
	{
		// Nested types
		public enum HGWaterHeightLayer // TypeDefIndex: 58503
		{
			HeightLayer0 = 0,
			HeightLayer1 = 1,
			HeightLayer2 = 2,
			HeightLayer3 = 3
		}
	
		public enum HGWaterRenderType // TypeDefIndex: 58504
		{
			Proxy = 1,
			LOD = 2
		}
	
		public enum HGWaterDecalRenderType // TypeDefIndex: 58505
		{
			None = 0,
			Regular = 1,
			Emissive = 2
		}
	
		// Methods
		public static void CullWaterProxy(uint viewHandle, Matrix4x4 viewProj, uint cullingMask, bool useOC, out uint visibleCount, out uint cullHandle, bool orderByDistance = false /* Metadata: 0x0207F73E */, Vector3 viewPosition = default) {
			visibleCount = default;
			cullHandle = default;
		} // 0x0000000186472400-0x000000018647244C
		public static void CullWaterDecals(uint viewHandle, Matrix4x4 viewProj, out uint visibleCount, out uint cullHandle, bool useAnchorSH = false /* Metadata: 0x0207F73F */) {
			visibleCount = default;
			cullHandle = default;
		} // 0x00000001864723E0-0x0000000186472400
		public static bool IsHeightLayerVisible(uint cullHandle, uint renderTypeMask, int lodLayer) => default; // 0x000000018BF10898-0x000000018BF108E8
		public static void DrawWaterProxy(IntPtr renderContext, CommandBuffer cmd, uint cullHandle, Material material, MaterialPropertyBlock properties, int shaderPass, int nameID, bool clear = true /* Metadata: 0x0207F740 */, uint renderTypeMask = 3 /* Metadata: 0x0207F741 */, int lodLayer = -1 /* Metadata: 0x0207F742 */, bool filterByWetnessMask = false /* Metadata: 0x0207F743 */) {} // 0x0000000183F87E20-0x0000000183F87ED0
		public static void DrawWaterDecals(IntPtr renderContext, CommandBuffer cmd, uint cullHandle, MaterialPropertyBlock properties, int nameID, bool clear = true /* Metadata: 0x0207F744 */, int shaderPass = 0 /* Metadata: 0x0207F745 */, uint renderTypeMask = 1 /* Metadata: 0x0207F746 */, int heightLayer = -1 /* Metadata: 0x0207F747 */) {} // 0x000000018BF10834-0x000000018BF10898
		public static bool IsHGWaterGloablConfigValidCPP() => default; // 0x000000018522BD70-0x000000018522BE00
		public static bool CheckNewHGWaterGloablConfigCPP(string scenePath) => default; // 0x0000000185212840-0x0000000185212880
		public static void UpdateHGWaterGloablConfigCPP(string scenePath, int sectorNum, int sectorSize, int sectorCoordsMin, int sectorCoordsMax, long[] sectorDataGUIDs, bool[] sectorDataExists) {} // 0x0000000185F55640-0x0000000185F556B0
		public static void AddSectorTexture(int id, int textureID) {} // 0x0000000185763030-0x0000000185763080
		public static void RemoveSectorTexture(int id) {} // 0x000000018BF108E8-0x000000018BF1091C
		private static void CullWaterProxy_Injected(uint viewHandle, ref Matrix4x4 viewProj, uint cullingMask, bool useOC, out uint visibleCount, out uint cullHandle, bool orderByDistance = false /* Metadata: 0x0207F748 */, ref Vector3 viewPosition = null) {
			visibleCount = default;
			cullHandle = default;
		} // 0x0000000184CAD260-0x0000000184CAD2E0
		private static void CullWaterDecals_Injected(uint viewHandle, ref Matrix4x4 viewProj, out uint visibleCount, out uint cullHandle, bool useAnchorSH = false /* Metadata: 0x0207F749 */) {
			visibleCount = default;
			cullHandle = default;
		} // 0x0000000184CAD1E0-0x0000000184CAD260
	}
}

namespace UnityEngine.HyperGryph.ECS
{
	public enum ECSExplicitEntityType : uint // TypeDefIndex: 58539
	{
		Unknown = 0,
		MeshRenderer = 1,
		ReflectionProbe = 2,
		WaterRenderer = 3,
		FactoryRenderer = 4,
		HGDecalProjector = 5
	}

	public struct EntityInstanceData // TypeDefIndex: 58540
	{
		// Fields
		public uint entityType; // 0x00
		public int entityIdx; // 0x04
		public uint version; // 0x08
		public uint padding; // 0x0C
	}

	public struct ComponentType // TypeDefIndex: 58541
	{
		// Fields
		public ulong value; // 0x00
		public short componentID; // 0x00
		public short componentSize; // 0x02
		public int offset; // 0x04
	}

	public struct ComponentMask // TypeDefIndex: 58543
	{
		// Fields
		public _componentMaskWords_e__FixedBuffer componentMaskWords; // 0x00
	
		// Nested types
		public struct _componentMaskWords_e__FixedBuffer // TypeDefIndex: 58542
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		// Constructors
		public ComponentMask(int id) {
			componentMaskWords = default;
		} // 0x0000000185FE8910-0x0000000185FE8930
	
		// Methods
		public bool ContainsComponentId(int id) => default; // 0x0000000184136F50-0x0000000184136F70
		public bool ContainsComponentMask(in ComponentMask other) => default; // 0x00000001840BFA70-0x00000001840BFA90
		public bool ExcludesComponentMask(in ComponentMask other) => default; // 0x00000001840BFA90-0x00000001840BFAB0
		public override bool Equals(object obj) => default; // 0x000000018BF0C7E8-0x000000018BF0C864
		public override int GetHashCode() => default; // 0x0000000185FE88C0-0x0000000185FE88F0
		public void And(ref ComponentMask other) {} // 0x0000000185FE88B0-0x0000000185FE88C0
		public void Or(int id) {} // 0x0000000185FE88F0-0x0000000185FE8910
	}

	public struct EntityTypeInstanceData // TypeDefIndex: 58545
	{
		// Fields
		public ulong groupComponentMask; // 0x00
		public unsafe byte* groupMemory; // 0x08
		public ulong componentMask; // 0x10
		public ComponentMask componentMaskAll; // 0x10
		public unsafe byte* memory; // 0x20
		public uint extraDataMisc; // 0x28
		public int count; // 0x2C
		public int capacity; // 0x30
		public int stride; // 0x34
		public uint fence; // 0x38
		public ushort chunkType; // 0x3C
		public short componentTypeCount; // 0x3E
		public _componentTypes_e__FixedBuffer componentTypes; // 0x40
	
		// Nested types
		public struct _componentTypes_e__FixedBuffer // TypeDefIndex: 58544
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	}

	public struct Entity : IEquatable<Entity> // TypeDefIndex: 58546
	{
		// Fields
		public uint globalIndex; // 0x00
		public uint version; // 0x04
		private static readonly Entity _invaildEntity_k__BackingField; // 0x00
	
		// Properties
		public ulong id { get => default; set {} } // 0x0000000185FE89F0-0x0000000185FE8A00 0x0000000185FE3180-0x0000000185FE3190
		public static Entity invaildEntity { get; } // 0x000000018BF0CE48-0x000000018BF0CE98 
	
		// Constructors
		static Entity() {
			<invaildEntity>k__BackingField = default;
		} // 0x0000000185F86640-0x0000000185F86690
	
		// Methods
		public bool Equals(Entity rhs) => default; // 0x0000000183FAB6D0-0x0000000183FAB6F0
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public override string ToString() => default; // 0x000000018BF0CDC0-0x000000018BF0CE48
		public bool Valid() => default; // 0x0000000184165F10-0x0000000184165F30
		public static bool operator ==(Entity left, Entity right) => default; // 0x0000000184AC44E0-0x0000000184AC4560
		public static bool operator !=(Entity left, Entity right) => default; // 0x0000000184AC4470-0x0000000184AC44E0
		public override bool Equals(object obj) => default; // 0x000000018BF0CD44-0x000000018BF0CDC0
	}

	public struct EntityType // TypeDefIndex: 58547
	{
		// Fields
		public uint id; // 0x00
	}

	public interface IComponentECS // TypeDefIndex: 58548
	{
		// Properties
		int id { get; }
	}

	public struct BoundingCenterXComponent : IComponentECS // TypeDefIndex: 58549
	{
		// Fields
		public float x; // 0x00
	
		// Properties
		public int id { get => default; } // 0x00000001813AE580-0x00000001813AE590 
	}

	public struct BoundingCenterYComponent : IComponentECS // TypeDefIndex: 58550
	{
		// Fields
		public float y; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	}

	public struct BoundingCenterZComponent : IComponentECS // TypeDefIndex: 58551
	{
		// Fields
		public float z; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
	}

	public struct BoundingExtentXComponent : IComponentECS // TypeDefIndex: 58552
	{
		// Fields
		public float x; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000181D1CE70-0x0000000181D1CE80 
	}

	public struct BoundingExtentYComponent : IComponentECS // TypeDefIndex: 58553
	{
		// Fields
		public float y; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000181C44E90-0x0000000181C44EA0 
	}

	public struct BoundingExtentZComponent : IComponentECS // TypeDefIndex: 58554
	{
		// Fields
		public float z; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000181D27740-0x0000000181D27750 
	}

	public struct RenderObjectLODInfoComponent : IComponentECS // TypeDefIndex: 58555
	{
		// Fields
		public Vector3 lodCenter; // 0x00
		public float lodObjectHalfSizeSquared; // 0x0C
		public bool enableDither; // 0x10
		public byte lodCullingOptions; // 0x11
		public byte padding0; // 0x12
		public byte padding1; // 0x13
	
		// Properties
		public int id { get => default; } // 0x0000000181D409B0-0x0000000181D40CF0 
	}

	public struct RenderObjectInfoComponent : IComponentECS // TypeDefIndex: 58556
	{
		// Fields
		public uint roLayerMask; // 0x00
		public uint objectFlags; // 0x04
		public ulong sceneMask; // 0x08
		public uint artTag; // 0x10
		public float sortingFudgeSqr; // 0x14
	
		// Properties
		public int id { get => default; } // 0x0000000181B9FE80-0x0000000181B9FE90 
	}

	public struct RendererInfo // TypeDefIndex: 58557
	{
		// Fields
		public ushort hgKeywords; // 0x00
		public byte meshSubIndex; // 0x02
		public sbyte sortOrder; // 0x03
		public uint materialHandle; // 0x04
		public uint geometryHandle; // 0x08
		public uint shadowProxyGeometryHandle; // 0x0C
		public uint renderFlags; // 0x10
		public uint lightModeMask; // 0x14
	}

	public struct LODInfo // TypeDefIndex: 58558
	{
		// Fields
		public float lodScreenSizeMaxSquared; // 0x00
		public float lodScreenSizeMinSquared; // 0x04
	}

	public interface IRenderObjectKComponent : IComponentECS // TypeDefIndex: 58559
	{
		// Methods
		byte* GetRenderersPtr();
	}

	public struct RenderObjectK1Component : IRenderObjectKComponent // TypeDefIndex: 58562
	{
		// Fields
		public int count; // 0x00
		public _renderers_e__FixedBuffer renderers; // 0x04
		public _lodInfos_e__FixedBuffer lodInfos; // 0x1C
	
		// Properties
		public int id { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Nested types
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 58560
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 58561
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000185FE89B0-0x0000000185FE89C0
	}

	public struct RenderObjectK2Component : IRenderObjectKComponent // TypeDefIndex: 58565
	{
		// Fields
		public int count; // 0x00
		public _renderers_e__FixedBuffer renderers; // 0x04
		public _lodInfos_e__FixedBuffer lodInfos; // 0x34
	
		// Properties
		public int id { get => default; } // 0x0000000183056920-0x0000000183056930 
	
		// Nested types
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 58563
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 58564
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000185FE89B0-0x0000000185FE89C0
	}

	public struct RenderObjectK4Component : IRenderObjectKComponent // TypeDefIndex: 58568
	{
		// Fields
		public int count; // 0x00
		public _renderers_e__FixedBuffer renderers; // 0x04
		public _lodInfos_e__FixedBuffer lodInfos; // 0x64
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6A00-0x0000000185FB6A10 
	
		// Nested types
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 58566
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 58567
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000185FE89B0-0x0000000185FE89C0
	}

	public struct RenderObjectK8Component : IRenderObjectKComponent // TypeDefIndex: 58571
	{
		// Fields
		public int count; // 0x00
		public _renderers_e__FixedBuffer renderers; // 0x04
		public _lodInfos_e__FixedBuffer lodInfos; // 0xC4
	
		// Properties
		public int id { get => default; } // 0x0000000181DDC740-0x0000000181DDC750 
	
		// Nested types
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 58569
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 58570
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000185FE89B0-0x0000000185FE89C0
	}

	public struct RenderObjectK16Component : IRenderObjectKComponent // TypeDefIndex: 58574
	{
		// Fields
		public int count; // 0x00
		public _renderers_e__FixedBuffer renderers; // 0x04
		public _lodInfos_e__FixedBuffer lodInfos; // 0x184
	
		// Properties
		public int id { get => default; } // 0x0000000181B75290-0x0000000181B752A0 
	
		// Nested types
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 58572
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 58573
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000185FE89B0-0x0000000185FE89C0
	}

	public struct PerDrawBaseData // TypeDefIndex: 58575
	{
		// Fields
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 lodFade; // 0x40
		public Vector4 worldTransformParams; // 0x50
		public Matrix4x4 matrixPreviousM; // 0x60
		public Vector4 motionVectorsParams; // 0xA0
	}

	public struct CommonInstanceDataComponent : IComponentECS // TypeDefIndex: 58577
	{
		// Fields
		public PerDrawBaseData baseData; // 0x00
		public _customData_e__FixedBuffer customData; // 0xB0
	
		// Properties
		public int id { get => default; } // 0x0000000185FB72C0-0x0000000185FB72D0 
	
		// Nested types
		public struct _customData_e__FixedBuffer // TypeDefIndex: 58576
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct FactoryInstanceDataComponent : IComponentECS // TypeDefIndex: 58579
	{
		// Fields
		public PerDrawBaseData baseData; // 0x00
		public _customData_e__FixedBuffer customData; // 0xB0
	
		// Properties
		public int id { get => default; } // 0x0000000185FB72C0-0x0000000185FB72D0 
	
		// Nested types
		public struct _customData_e__FixedBuffer // TypeDefIndex: 58578
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct ECSFixedString64 // TypeDefIndex: 58581
	{
		// Fields
		public _data_e__FixedBuffer data; // 0x00
	
		// Nested types
		public struct _data_e__FixedBuffer // TypeDefIndex: 58580
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string GetData() => default; // 0x000000018BF0C864-0x000000018BF0C900
		public override string ToString() => default; // 0x000000018BF0C900-0x000000018BF0C908
	}

	public struct DebugContentsComponent : IComponentECS // TypeDefIndex: 58582
	{
		// Fields
		public ECSFixedString64 entityName; // 0x00
		public ECSExplicitEntityType entityType; // 0x40
		public ECSFixedString64 debugStr; // 0x44
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6A20-0x0000000185FB6A30 
	}

	public struct HGFactoryRendererBinderComponent : IComponentECS // TypeDefIndex: 58583
	{
		// Fields
		public Entity rendererEntity; // 0x00
		public uint sharedDataIndex; // 0x08
		public byte rendererType; // 0x0C
		public byte padding0; // 0x0D
		public byte padding1; // 0x0E
		public byte padding2; // 0x0F
	
		// Properties
		public int id { get => default; } // 0x0000000185FB3170-0x0000000185FB3180 
	
		// Methods
		public void SetDirtyFlag(HGFactoryDirtyFlags flag) {} // 0x00000001840FF910-0x00000001840FF9A0
		public void SetAdditiveMaterialBit(int bitIndex, bool enable) {} // 0x00000001840FEA60-0x00000001840FEB60
		public void SetPosition(Vector3 position) {} // 0x00000001840FDC10-0x00000001840FDCB0
		public void SetUniformScale(float uniformScale) {} // 0x000000018BF0DF30-0x000000018BF0DF8C
		public void SetRotation(Quaternion rotation) {} // 0x00000001840FDB80-0x00000001840FDC10
		public void SetTransform(HGFactoryEntityTransformData transform) {} // 0x00000001840FF2C0-0x00000001840FF360
		public void SetCustomPerDrawData<T>(T data, int offset)
			where T : struct {}
		public void SetEnabled(bool enabled) {} // 0x00000001840FF480-0x00000001840FF570
		public void SetAdditiveEntitiesVisibility(bool visible) {} // 0x00000001840FECE0-0x00000001840FEDA0
	}

	public struct HGWaterComponent : IComponentECS // TypeDefIndex: 58584
	{
		// Fields
		public uint renderTypeMask; // 0x00
		public int meshID; // 0x04
		public Matrix4x4 objectToWorld; // 0x08
		public Vector4 param0; // 0x48
		public Vector4 param1; // 0x58
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6A40-0x0000000185FB6A50 
	}

	public struct HGWaterDecalComponent : IComponentECS // TypeDefIndex: 58585
	{
		// Fields
		public uint renderTypeMask; // 0x00
		public int meshID; // 0x04
		public int materialID; // 0x08
		public Matrix4x4 objectToWorld; // 0x0C
		public Vector4 param0; // 0x4C
		public Vector4 param1; // 0x5C
		public Vector4 animParam0; // 0x6C
		public Vector4 animParam1; // 0x7C
		public Vector4 animParam2; // 0x8C
		public Vector4 animParam3; // 0x9C
	
		// Properties
		public int id { get => default; } // 0x0000000183214D00-0x0000000183214D10 
	}

	public struct GrassRendererInfo // TypeDefIndex: 58586
	{
		// Fields
		public ushort hgKeywords; // 0x00
		public ushort batchGroupHandle; // 0x02
		public uint batchGroupKey; // 0x04
		public float sparsity; // 0x08
		public uint renderFlags; // 0x0C
		public uint padding0; // 0x10
		public uint padding1; // 0x14
	}

	[Serializable]
	public struct GrassPerInstanceData // TypeDefIndex: 58587
	{
		// Fields
		public const int SIZE = 96; // Metadata: 0x0207F8F0
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 param0; // 0x40
		public Vector4 param1; // 0x50
	}

	public struct GrassClusterK4Component : IComponentECS // TypeDefIndex: 58589
	{
		// Fields
		public int count; // 0x00
		public _perInstanceData_e__FixedBuffer perInstanceData; // 0x04
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6E00-0x0000000185FB6E10 
	
		// Nested types
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 58588
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK8Component : IComponentECS // TypeDefIndex: 58591
	{
		// Fields
		public int count; // 0x00
		public _perInstanceData_e__FixedBuffer perInstanceData; // 0x04
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6DC0-0x0000000185FB6DD0 
	
		// Nested types
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 58590
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK16Component : IComponentECS // TypeDefIndex: 58593
	{
		// Fields
		public int count; // 0x00
		public _perInstanceData_e__FixedBuffer perInstanceData; // 0x04
	
		// Properties
		public int id { get => default; } // 0x0000000181BA5810-0x0000000181BA5820 
	
		// Nested types
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 58592
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK32Component : IComponentECS // TypeDefIndex: 58595
	{
		// Fields
		public int count; // 0x00
		public _perInstanceData_e__FixedBuffer perInstanceData; // 0x04
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6A10-0x0000000185FB6A20 
	
		// Nested types
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 58594
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct ECSColliderComponent : IComponentECS // TypeDefIndex: 58596
	{
		// Fields
		public IntPtr actor; // 0x00
		public int ecsId; // 0x08
		public uint ecsVersion; // 0x0C
	
		// Properties
		public int id { get => default; } // 0x0000000185FBA700-0x0000000185FBA710 
	}

	public struct HGSludgeComponent : IComponentECS // TypeDefIndex: 58597
	{
		// Fields
		public uint materialHandle; // 0x00
		public uint sludgeSize; // 0x04
		public float disappearTime; // 0x08
		public float ditherAlpha; // 0x0C
		public Vector4 right; // 0x10
		public Vector4 forward; // 0x20
		public Vector4 position; // 0x30
		public Vector4 up; // 0x40
		public Vector4 customPerDraw0; // 0x50
		public Vector4 customPerDraw1; // 0x60
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7340-0x0000000185FB7350 
	}

	public struct ECSClothDataComponent : IComponentECS // TypeDefIndex: 58598
	{
		// Fields
		public uint clothHash; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000185FB6D30-0x0000000185FB6D40 
	}

	public struct HGECSRegionComponent : IComponentECS // TypeDefIndex: 58599
	{
		// Fields
		public bool isEnable; // 0x00
		public Vector3 center; // 0x04
		public Vector3 size; // 0x10
		public Quaternion rotation; // 0x1C
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7270-0x0000000185FB7280 
	}

	public struct HGCullingParameterComponent : IComponentECS // TypeDefIndex: 58600
	{
		// Fields
		public bool enableShadowCulling; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000185FB7260-0x0000000185FB7270 
	}

	public struct EntityManager // TypeDefIndex: 58601
	{
		// Fields
		public readonly IntPtr m_entitiesPPtr; // 0x00
		public readonly IntPtr m_entityTypesPPtr; // 0x08
	
		// Methods
		public static int GetNFromKNComponentMask(ulong componentMask) => default; // 0x0000000185FE89E0-0x0000000185FE89F0
		public static unsafe int GetCountFromKNComponent(byte* component) => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public static unsafe void SetCountForKNComponent(byte* component, int count) {} // 0x00000001818AA390-0x00000001818AA3A0
		public static unsafe GrassRendererInfo* GetGrassRendererInfosFromKNComponent(byte* component) => default; // 0x0000000185FE89B0-0x0000000185FE89C0
		public static unsafe LODInfo* GetLODInfosFromKNComponent(byte* component, int n) => default; // 0x0000000185FE89C0-0x0000000185FE89E0
		public static unsafe int GetCountFromKNGrassCluster(byte* component) => default; // 0x0000000185FE64F0-0x0000000185FE6500
		public static unsafe void SetCountForKNGrassCluster(byte* component, int count) {} // 0x00000001818AA390-0x00000001818AA3A0
		public static unsafe GrassPerInstanceData* GetPerInstanceDataFromKNGrassCluster(byte* component) => default; // 0x0000000185FE89B0-0x0000000185FE89C0
		public static EntityManager GetEntityManager() => default; // 0x00000001847984A0-0x00000001847984F0
		public static EntityManager GetGameplayEntityManager() => default; // 0x0000000184168B10-0x0000000184168B60
		public static EntityManager GetRendererEntityManager() => default; // 0x00000001840C45C0-0x00000001840C4610
		public bool HasEntity(Entity entity) => default; // 0x0000000184165F30-0x0000000184165FC0
		public Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityType entityType) => default; // 0x00000001840BE5A0-0x00000001840BE600
		public void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, IntPtr entities, int count) {} // 0x0000000186470198-0x00000001864701B8
		public void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, NativeArray<Entity> entities) {} // 0x00000001847E7930-0x00000001847E7990
		public void DestroyEntity(Entity entity) {} // 0x000000018646DAC0-0x000000018646DADC
		public void DestroyEntities(NativeArray<Entity> entities) {} // 0x00000001848AF160-0x00000001848AF1E0
		public void DestroyEntities(IntPtr entities, int entityCount) {} // 0x0000000186470CB8-0x0000000186470CC0
		public static ComponentType GetComponentType<T>()
			where T : struct, IComponentECS => default;
		public void AddComponent<T>(in Entity entity, in ref T t)
			where T : struct, IComponentECS {}
		public void RemoveComponent<T>(in Entity entity)
			where T : struct, IComponentECS {}
		public void RemoveComponentsWithMask(in Entity entity, ref ComponentMask needRemoveComponentMask) {} // 0x00000001840BACE0-0x00000001840BAE90
		public UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityType(NativeArray<ComponentType> componentTypes) => default; // 0x00000001840BE660-0x00000001840BE6F0
		public UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityTypeImpl(int componentTypeCount, IntPtr componentTypes) => default; // 0x00000001840BE6F0-0x00000001840BE760
		public void AddMoveEntityAndEntityTypeDataImpl(in Entity entity, in UnityEngine.HyperGryph.ECS.EntityType newEntityType) {} // 0x000000018646DAF0-0x000000018646DAF8
		public void RemoveMoveEntityAndEntityTypeDataImpl(in Entity entity, in UnityEngine.HyperGryph.ECS.EntityType newEntityType) {} // 0x000000018BF0CB74-0x000000018BF0CB7C
		public static ulong NumberOfSetBits(ulong i) => default; // 0x0000000185FD9E20-0x0000000185FD9E80
		public static ulong NumberOfSetBits(ref ComponentMask mask) => default; // 0x0000000184136E60-0x0000000184136EA0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1) => default; // 0x00000001840C3550-0x00000001840C35B0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2) => default; // 0x0000000184E70E40-0x0000000184E70F90
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3) => default; // 0x0000000184E61D30-0x0000000184E61DD0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3, int id4) => default; // 0x0000000184CFE700-0x0000000184CFE7C0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3, int id4, int id5) => default; // 0x0000000184CF8760-0x0000000184CF8840
		public bool HasComponent<T>(in Entity entity)
			where T : struct, IComponentECS => default;
		public void SetComponents<T0, T1>(in Entity entity, in ref T0 t0, in ref T1 t1)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS {}
		public static ComponentMask GetCountingMask(int id) => default; // 0x0000000184136EA0-0x0000000184136EF0
		public static void SetComponentImplWithRef<T>(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, in ref T t)
			where T : struct, IComponentECS {}
		public void SetComponent<T>(in Entity entity, in ref T t)
			where T : struct, IComponentECS {}
		private static unsafe byte* GetComponentPtrImpl(int entityIdx, ref EntityTypeInstanceData entityTypeData, int componentId, int componentSize) => default; // 0x000000018BF0C9F8-0x000000018BF0CA8C
		public bool TryGetWorldAABBFromRendererEntity(in Entity entity, out Bounds aabb) {
			aabb = default;
			return default;
		} // 0x000000018BF0CB7C-0x000000018BF0CD44
		public ulong GetComponentMaskLow(in Entity entity) => default; // 0x0000000185FE8980-0x0000000185FE89B0
		public ComponentMask GetComponentMaskAll(in Entity entity) => default; // 0x0000000185FE8950-0x0000000185FE8980
		public unsafe byte* GetComponentPtrLowBits(in Entity entity, ulong componentMask) => default; // 0x000000018BF0CA8C-0x000000018BF0CB74
		public T GetComponent<T>(in Entity entity)
			where T : struct, IComponentECS => default;
		public bool TryGetComponent<T>(in Entity entity, out ref T component)
			where T : struct, IComponentECS {
			component = default;
			return default;
		}
		public ref ref T GetComponentRef<T>(in Entity entity)
			where T : struct, IComponentECS => ref _refReturnTypeForGetComponentRef;
		private ref T _refReturnTypeForGetComponentRef; // Dummy field
		public unsafe T* GetComponentPtr<T>(in Entity entity)
			where T : struct, IComponentECS => default;
		public unsafe bool TryGetComponentPtr<T>(in Entity entity, out ref T* componentPtr)
			where T : struct, IComponentECS {
			componentPtr = default;
			return default;
		}
		public EntityManagerRange Iterate(ref ComponentMask includeComponentMask, ref ComponentMask excludeComponentMask) => default; // 0x00000001840C18E0-0x00000001840C1A50
		public EntityManagerRange Iterate(ref ComponentMask componentMask) => default; // 0x00000001840C0CF0-0x00000001840C0DB0
		public EntityManagerRange Iterate<T>()
			where T : struct, IComponentECS => default;
		public EntityManagerRange Iterate<T0, T1>()
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS => default;
		public int GetEntityTypeCount() => default; // 0x000000018646DB14-0x000000018646DB20
		public uint GetEntityContainerSize() => default; // 0x000000018646DE44-0x000000018646DE4C
		public void GarbageCollect() {} // 0x0000000186472D30-0x0000000186472D38
		private static void GetEntityManager_Injected(out EntityManager ret) {
			ret = default;
		} // 0x00000001847984F0-0x0000000184798580
		private static void GetGameplayEntityManager_Injected(out EntityManager ret) {
			ret = default;
		} // 0x0000000184168B60-0x0000000184168BA0
		private static void GetRendererEntityManager_Injected(out EntityManager ret) {
			ret = default;
		} // 0x00000001840C4610-0x00000001840C4650
		private static void CreateEntity_Injected(ref EntityManager _unity_self, ref UnityEngine.HyperGryph.ECS.EntityType entityType, out Entity ret) {
			ret = default;
		} // 0x00000001840BE600-0x00000001840BE660
		private static void CreateEntities_Injected(ref EntityManager _unity_self, ref UnityEngine.HyperGryph.ECS.EntityType entityType, IntPtr entities, int count) {} // 0x00000001857D3BF0-0x00000001857D3C60
		private static void DestroyEntity_Injected(ref EntityManager _unity_self, ref Entity entity) {} // 0x000000018521E680-0x000000018521E6D0
		private static void DestroyEntities_Injected(ref EntityManager _unity_self, IntPtr entities, int entityCount) {} // 0x00000001848AD8C0-0x00000001848AD920
		private static void GetOrRegisterEntityTypeImpl_Injected(ref EntityManager _unity_self, int componentTypeCount, IntPtr componentTypes, out UnityEngine.HyperGryph.ECS.EntityType ret) {
			ret = default;
		} // 0x00000001840BE760-0x00000001840BE7D0
		private static void AddMoveEntityAndEntityTypeDataImpl_Injected(ref EntityManager _unity_self, in Entity entity, in UnityEngine.HyperGryph.ECS.EntityType newEntityType) {} // 0x0000000184C14560-0x0000000184C145C0
		private static void RemoveMoveEntityAndEntityTypeDataImpl_Injected(ref EntityManager _unity_self, in Entity entity, in UnityEngine.HyperGryph.ECS.EntityType newEntityType) {} // 0x00000001856455C0-0x0000000185645620
		private static int GetEntityTypeCount_Injected(ref EntityManager _unity_self) => default; // 0x0000000184BE87C0-0x0000000184BE8800
		private static uint GetEntityContainerSize_Injected(ref EntityManager _unity_self) => default; // 0x00000001847B7D30-0x00000001847B7D70
		private static void GarbageCollect_Injected(ref EntityManager _unity_self) {} // 0x0000000184F67530-0x0000000184F67570
	}

	public struct GroupType // TypeDefIndex: 58602
	{
		// Fields
		private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
	
		// Constructors
		internal unsafe GroupType(EntityTypeInstanceData* types) {
			m_entityTypes = default;
		} // 0x0000000185FB2BB0-0x0000000185FB2BC0
	
		// Methods
		public int Size() => default; // 0x000000018646F864-0x000000018646F880
		public bool HasComponent<T>()
			where T : struct, IComponentECS => default;
		public unsafe T* GetComponent<T>()
			where T : struct, IComponentECS => default;
		public unsafe byte* GetComponentPtr(int componentId) => default; // 0x000000018BF0D528-0x000000018BF0D67C
		public NativeArray<T> GetComponentAsArray<T>()
			where T : struct, IComponentECS => default;
		public unsafe Entity* GetEntities() => default; // 0x000000018646DAF8-0x000000018646DB14
		public ComponentMask GetComponentMaskAll() => default; // 0x00000001856E0250-0x00000001856E0280
		public NativeArray<Entity> GetEntitiesAsArray() => default; // 0x00000001840B4850-0x00000001840B48D0
	}

	public struct EntityManagerRange : IEnumerable<GroupType> // TypeDefIndex: 58604
	{
		// Fields
		private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
		private readonly ComponentMask m_componentMask; // 0x08
		private readonly ComponentMask m_excludeComponentMask; // 0x18
		private readonly int m_count; // 0x28
	
		// Nested types
		public struct Enumerator : IEnumerator<GroupType> // TypeDefIndex: 58603
		{
			// Fields
			private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
			private readonly int m_count; // 0x08
			private ComponentMask m_includeComponentMask; // 0x10
			private ComponentMask m_excludedComponentMask; // 0x20
			private int m_index; // 0x30
	
			// Properties
			public GroupType Current { get => default; } // 0x000000018BF0C980-0x000000018BF0C9F8 
			object IEnumerator.Current { get => default; } // 0x0000000185FE8A00-0x0000000185FE8A30 
	
			// Constructors
			internal unsafe Enumerator(EntityTypeInstanceData* entityTypes, int count, in ComponentMask includeComponentMask, in ComponentMask excludeComponentMask) : this() {
				m_entityTypes = default;
				m_count = default;
				m_includeComponentMask = default;
				m_excludedComponentMask = default;
				m_index = default;
			} // 0x0000000185FE8930-0x0000000185FE8950
	
			// Methods
			public void Dispose() {} // 0x00000001840BF230-0x00000001840BF310
			public bool MoveNext() => default; // 0x00000001840C4570-0x00000001840C45C0
			public void Reset() {} // 0x000000018BF0C908-0x000000018BF0C980
		}
	
		// Constructors
		internal unsafe EntityManagerRange(EntityTypeInstanceData* entityTypes, int count, ref ComponentMask componentMask) {
			m_entityTypes = default;
			m_componentMask = default;
			m_excludeComponentMask = default;
			m_count = default;
		} // 0x0000000185492010-0x0000000185492020
		internal unsafe EntityManagerRange(EntityTypeInstanceData* entityTypes, int count, ref ComponentMask includeComponentMask, ref ComponentMask excludeComponentMask) {
			m_entityTypes = default;
			m_componentMask = default;
			m_excludeComponentMask = default;
			m_count = default;
		} // 0x00000001840BFA00-0x00000001840BFA70
	
		// Methods
		public Enumerator GetEnumerator() => default; // 0x000000018346D190-0x000000018346D1A0
		IEnumerator<GroupType> IEnumerable<GroupType>.GetEnumerator() => default; // 0x0000000185FE8A30-0x0000000185FE8A40
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BF0CE98-0x000000018BF0CEE8
	}
}

namespace UnityEngine.HyperGryph.Streaming
{
	public struct StreamingAssetData // TypeDefIndex: 58507
	{
		// Fields
		public long assetHashV2; // 0x00
		public AssetType assetType; // 0x08
	
		// Methods
		public bool Equals(StreamingAssetData other) => default; // 0x00000001835DAFD0-0x00000001835DAFF0
		public override bool Equals(object obj) => default; // 0x000000018BF109BC-0x000000018BF10A34
		public override int GetHashCode() => default; // 0x0000000185FE64F0-0x0000000185FE6500
	}

	public struct PropertySerializeId // TypeDefIndex: 58508
	{
		// Fields
		public uint componentIndex; // 0x00
		public uint propertyId; // 0x04
		public uint subPropertyIndex; // 0x08
	
		// Constructors
		public PropertySerializeId(StreamingComponentType componentType, uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x0207F753 */) {
			componentIndex = default;
			this.propertyId = default;
			this.subPropertyIndex = default;
		} // 0x0000000185407480-0x00000001854074C0
		public PropertySerializeId(uint componentIndex, uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x0207F754 */) {
			this.componentIndex = default;
			this.propertyId = default;
			this.subPropertyIndex = default;
		} // 0x0000000185FB0130-0x0000000185FB0140
		public PropertySerializeId(uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x0207F755 */) {
			componentIndex = default;
			this.propertyId = default;
			this.subPropertyIndex = default;
		} // 0x0000000185FE8A60-0x0000000185FE8A70
	
		// Methods
		public static implicit operator PropertySerializeId(uint propertyId) => default; // 0x0000000185FE8AA0-0x0000000185FE8AD0
		public static uint GetComponentIndexFromType(StreamingComponentType componentType) => default; // 0x00000001854074C0-0x0000000185407500
		public override int GetHashCode() => default; // 0x000000018BF109B4-0x000000018BF109BC
		public uint EncodeSerializeIdentifier() => default; // 0x000000018BF10950-0x000000018BF109B4
		public static PropertySerializeId operator +(PropertySerializeId a, uint subIndex) => default; // 0x0000000185FE8A70-0x0000000185FE8AA0
		public static PropertySerializeId operator +(PropertySerializeId a, int subIndex) => default; // 0x0000000185216820-0x0000000185216870
	}

	public struct FlatBufferConvertContextV2 // TypeDefIndex: 58509
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Properties
		public uint sceneScopeId { get => default; } // 0x0000000186472FE0-0x0000000186472FE8 
	
		// Methods
		public bool TryEnqueueAssetForAsyncLoad(PropertySerializeId propertySerializeId) => default; // 0x00000001864703B0-0x00000001864703C4
		public void AddExternalAssetForAsyncLoad(long assetHash, AssetType assetType, AssetHandleIndex assetHandleIndex) {} // 0x000000018647383C-0x0000000186473860
		private UnityEngine.Object ConvertAssetFromImpl(PropertySerializeId propertySerializeId) => default; // 0x000000018647317C-0x0000000186473190
		private IntPtr ConvertPropertyPtrFromImpl(PropertySerializeId propertySerializeId) => default; // 0x0000000186472FA8-0x0000000186472FBC
		private void ConvertPropertyDataFromBytesImpl(PropertySerializeId propertySerializeId, out IntPtr data, out int size) {
			data = default;
			size = default;
		} // 0x000000018646F3D8-0x000000018646F3F0
		public string ConvertStringFrom(PropertySerializeId propertySerializeId) => default; // 0x0000000186473828-0x000000018647383C
		public bool TryConvertAssetFrom<T>(PropertySerializeId propertySerializeId, out ref T asset)
			where T : UnityEngine.Object {
			asset = default;
			return default;
		}
		public T ConvertPropertyFrom<T>(PropertySerializeId propertySerializeId)
			where T : struct => default;
		public T ConvertPropertyFromBytes<T>(PropertySerializeId propertySerializeId)
			where T : struct => default;
		public NativeArray<byte> ConvertPropertyFromBytes(PropertySerializeId propertySerializeId) => default; // 0x000000018BF0CEE8-0x000000018BF0CFA8
		private static uint get_sceneScopeId_Injected(ref FlatBufferConvertContextV2 _unity_self) => default; // 0x0000000185755060-0x00000001857550A0
		private static bool TryEnqueueAssetForAsyncLoad_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId) => default; // 0x0000000185392C00-0x0000000185392C50
		private static void AddExternalAssetForAsyncLoad_Injected(ref FlatBufferConvertContextV2 _unity_self, long assetHash, AssetType assetType, ref AssetHandleIndex assetHandleIndex) {} // 0x0000000185717260-0x00000001857172D0
		private static UnityEngine.Object ConvertAssetFromImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId) => default; // 0x0000000185076840-0x0000000185076890
		private static IntPtr ConvertPropertyPtrFromImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId) => default; // 0x0000000184F8DF60-0x0000000184F8DFB0
		private static void ConvertPropertyDataFromBytesImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId, out IntPtr data, out int size) {
			data = default;
			size = default;
		} // 0x00000001855DE060-0x00000001855DE0D0
		private static string ConvertStringFrom_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId) => default; // 0x0000000185F5F700-0x0000000185F5F750
	}

	public struct StreamingGameplayManager // TypeDefIndex: 58510
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Methods
		public void Create(StreamingSceneParameter parameter) {} // 0x000000018BF10AC8-0x000000018BF10ADC
		public void Destroy() {} // 0x000000018BF10B10-0x000000018BF10B18
		public uint AllocateRuntimeChunk(string initBasePath, string streamingBasePath) => default; // 0x000000018646EDF0-0x000000018646EDF8
		public uint CreateEntityGroupAndLoad(uint chunkId, int blobIndex) => default; // 0x000000018646EDF8-0x000000018646EE00
		public void LoadGroup(uint groupHandle) {} // 0x000000018BF10BE4-0x000000018BF10BEC
		public bool IsGroupReady(uint groupId) => default; // 0x000000018BF10B94-0x000000018BF10B9C
		public uint CreateGroupAndLoadWaitBeforeShow(uint chunkId, int blobIndex) => default; // 0x000000018BF10AC0-0x000000018BF10AC8
		public void StopGroupWait(uint groupId) {} // 0x000000018BF10C2C-0x000000018BF10C34
		public void UnloadGroup(uint groupId, bool imm) {} // 0x00000001864733A4-0x00000001864733AC
		public void DestroyGroup(uint groupId) {} // 0x00000001864733AC-0x00000001864733B4
		public bool IsGroupLoaded(uint groupId) => default; // 0x000000018646EE00-0x000000018646EE08
		public bool IsGroupUnloaded(uint groupId) => default; // 0x000000018647339C-0x00000001864733A4
		public void Tick(int budget) {} // 0x000000018646E484-0x000000018646E48C
		public void TickResource() {} // 0x000000018646E47C-0x000000018646E484
		public void Clear() {} // 0x000000018BF10A68-0x000000018BF10A70
		public bool IsIdle() => default; // 0x000000018BF10B9C-0x000000018BF10BA4
		public bool IsValid() => default; // 0x0000000186470EB8-0x0000000186470EC4
		public void SetNeedLodTransition(bool needTransition) {} // 0x000000018646E22C-0x000000018646E234
		public bool GetNeedLodTransition() => default; // 0x000000018BF10B4C-0x000000018BF10B54
		private static void Create_Injected(ref StreamingGameplayManager _unity_self, ref StreamingSceneParameter parameter) {} // 0x0000000185F89930-0x0000000185F89980
		private static void Destroy_Injected(ref StreamingGameplayManager _unity_self) {} // 0x000000018BF10ADC-0x000000018BF10B10
		private static uint AllocateRuntimeChunk_Injected(ref StreamingGameplayManager _unity_self, string initBasePath, string streamingBasePath) => default; // 0x000000018574DC90-0x000000018574DCF0
		private static uint CreateEntityGroupAndLoad_Injected(ref StreamingGameplayManager _unity_self, uint chunkId, int blobIndex) => default; // 0x000000018445F590-0x000000018445F5F0
		private static void LoadGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupHandle) {} // 0x000000018BF10BA4-0x000000018BF10BE4
		private static bool IsGroupReady_Injected(ref StreamingGameplayManager _unity_self, uint groupId) => default; // 0x000000018BF10B54-0x000000018BF10B94
		private static uint CreateGroupAndLoadWaitBeforeShow_Injected(ref StreamingGameplayManager _unity_self, uint chunkId, int blobIndex) => default; // 0x000000018BF10A70-0x000000018BF10AC0
		private static void StopGroupWait_Injected(ref StreamingGameplayManager _unity_self, uint groupId) {} // 0x000000018BF10BEC-0x000000018BF10C2C
		private static void UnloadGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupId, bool imm) {} // 0x00000001850CC840-0x00000001850CC8A0
		private static void DestroyGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupId) {} // 0x00000001850CC7A0-0x00000001850CC7F0
		private static bool IsGroupLoaded_Injected(ref StreamingGameplayManager _unity_self, uint groupId) => default; // 0x000000018445F5F0-0x000000018445F640
		private static bool IsGroupUnloaded_Injected(ref StreamingGameplayManager _unity_self, uint groupId) => default; // 0x00000001850CC7F0-0x00000001850CC840
		private static void Tick_Injected(ref StreamingGameplayManager _unity_self, int budget) {} // 0x00000001851DF2F0-0x00000001851DF340
		private static void TickResource_Injected(ref StreamingGameplayManager _unity_self) {} // 0x0000000184A5AAD0-0x0000000184A5AB10
		private static void Clear_Injected(ref StreamingGameplayManager _unity_self) {} // 0x000000018BF10A34-0x000000018BF10A68
		private static bool IsIdle_Injected(ref StreamingGameplayManager _unity_self) => default; // 0x00000001854C57C0-0x00000001854C5800
		private static void SetNeedLodTransition_Injected(ref StreamingGameplayManager _unity_self, bool needTransition) {} // 0x00000001841E9780-0x00000001841E97D0
		private static bool GetNeedLodTransition_Injected(ref StreamingGameplayManager _unity_self) => default; // 0x000000018BF10B18-0x000000018BF10B4C
	}

	public enum StreamingComponentType : ulong // TypeDefIndex: 58511
	{
		None = 0,
		Transform = 1,
		MeshFilter = 2,
		MeshRenderer = 4,
		LODGroup = 8,
		BoxCollider = 16,
		MeshCollider = 32,
		Count = 41,
		SphereCollider = 64,
		CapsuleCollider = 128,
		TerrainCollider = 256,
		MultiCollider = 512,
		HGDecalProjector = 1024,
		HLODGroup = 2048,
		HGVolumetricLocalFog = 4096,
		HGWaterRenderer = 8192,
		HGEnvironmentVolume = 16384,
		Volume = 32768,
		ReflectionProbe = 65536,
		Light = 131072,
		HGIrradianceVolume = 262144,
		HGTerrain = 524288,
		HGGrass = 1048576,
		AudioVolume = 2097152,
		AudioSceneEmitter = 4194304,
		AudioRoom = 8388608,
		AudioPortal = 16777216,
		HGAdditionalLightData = 33554432,
		HGTerrainSurfTypeData = 67108864,
		HGSOCChunk = 134217728,
		GpuClothGroup = 268435456,
		LensFlareComponentSRP = 536870912,
		HGTerrainDecal = 1073741824,
		MergedRenderColliderECS = 2147483648,
		HGWaterGlobalConfig = 4294967296,
		HGWindMotor = 8589934592,
		HGECSRegion = 17179869184,
		FakeFogSimple = 34359738368,
		VLB = 68719476736,
		HGWaterDecal = 137438953472,
		VFXFakeVolumeFog = 274877906944,
		HGTimeOfDayEnvironmentVolume = 549755813888,
		HGVolumetricCloud = 1099511627776
	}

	public enum StreamingLayer : byte // TypeDefIndex: 58512
	{
		Default = 0,
		Persistent = 1,
		HLOD0 = 2,
		HLOD1 = 3,
		HLOD2 = 4,
		Collider = 5,
		Tiny = 6,
		Water = 7,
		Lighting = 8,
		Audio = 9,
		Count = 10
	}

	public enum EntityTransition : byte // TypeDefIndex: 58513
	{
		Initializing = 0,
		UnloadedToLoading = 1,
		LoadingWaiting = 2,
		LoadingToLoaded = 3,
		UnloadingToLoaded = 4,
		LoadedToUnloading = 5,
		UnloadingToUnloaded = 6,
		UnloadingWaiting = 7,
		LoadingToUnloaded = 8,
		Destroying = 9,
		Count = 10
	}

	public enum StreamingMode : byte // TypeDefIndex: 58514
	{
		Stream = 0,
		Pause = 1,
		Load = 2,
		Unload = 3
	}

	public enum StreamingStatus : byte // TypeDefIndex: 58515
	{
		Idle = 0,
		Loading = 1,
		Unloading = 2,
		Empty = 4
	}

	public struct StreamingSceneParameter // TypeDefIndex: 58516
	{
		// Fields
		public string mapName; // 0x00
		public GameObject streamingRootObject; // 0x08
		public string streamingDataPathRoot; // 0x10
	}

	public enum GridStatus : byte // TypeDefIndex: 58517
	{
		Loading = 0,
		Loaded = 1,
		Unloading = 2,
		Unloaded = 3,
		NotExist = 4
	}

	public struct GridIdentifier // TypeDefIndex: 58518
	{
		// Fields
		public Vector2Int pos; // 0x00
		public int sceneStateId; // 0x08
		public int areaId; // 0x0C
		public StreamingLayer layer; // 0x10
	
		// Constructors
		public GridIdentifier(StreamingLayer layer, int sceneStateId, int areaId, Vector2Int pos) {
			this.pos = default;
			this.sceneStateId = default;
			this.areaId = default;
			this.layer = default;
		} // 0x0000000185FE8A40-0x0000000185FE8A60
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000184389290-0x00000001843892B0
	}

	public struct StreamingSourceData // TypeDefIndex: 58521
	{
		// Fields
		public Vector2 streamingPos; // 0x00
		public float chunkLoadRadius; // 0x08
		public _layerLoadRadius_e__FixedBuffer layerLoadRadius; // 0x0C
		public _layerEnabledInDefaultArea_e__FixedBuffer layerEnabledInDefaultArea; // 0x34
		public static readonly StreamingSourceData kInvalid; // 0x00
	
		// Nested types
		public struct _layerLoadRadius_e__FixedBuffer // TypeDefIndex: 58519
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		public struct _layerEnabledInDefaultArea_e__FixedBuffer // TypeDefIndex: 58520
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		static StreamingSourceData() {
			kInvalid = default;
		} // 0x000000018448F410-0x000000018448F520
	
		// Methods
		public float GetGridLoadRadius(int layerIndex) => default; // 0x0000000185FE8AD0-0x0000000185FE8AE0
	}

	public enum ECSEntityType : byte // TypeDefIndex: 58522
	{
		Render = 0,
		Water = 1,
		ConvexCollider = 2,
		CapsuleCollider = 3,
		SphereCollider = 4,
		MeshCollider = 5,
		MultiCollider = 6,
		TerrainCollider = 7,
		TerrainDecal = 8,
		MergedRenderCollider = 9,
		HGDecalProjector = 10,
		TerrainSplineDecal = 11,
		HGECSRegion = 12,
		WaterDecal = 13,
		TypeCount = 14
	}

	public enum ProxyEntityType : byte // TypeDefIndex: 58523
	{
		IrradianceVolume = 0,
		AudioVolume = 1,
		AudioEmitter = 2,
		AudioRoom = 3,
		TerrainSurfaceTypeData = 4,
		AudioPortal = 5,
		SOCChunk = 6,
		GrassGrid = 7,
		GpuClothGroup = 8,
		TypeCount = 9
	}

	public struct StreamingSceneV2 // TypeDefIndex: 58524
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Properties
		public StreamingMode streamingMode { get => default; set {} } // 0x000000018BF10D8C-0x000000018BF10D94 0x000000018BF10DB0-0x000000018BF10DB8
		public StreamingSourceData primaryStreamingSourceData { get => default; set {} } // 0x0000000184A64A50-0x0000000184A64AC0 0x000000018BF10D9C-0x000000018BF10DB0
		public StreamingSourceData secondaryStreamingSourceData { set {} } // 0x0000000186473C14-0x0000000186473C28
		public float streamingProgress { get => default; } // 0x000000018BF10D94-0x000000018BF10D9C 
	
		// Methods
		public void Create(StreamingSceneParameter parameter) {} // 0x0000000186472908-0x000000018647291C
		public void Destroy() {} // 0x000000018BF10C68-0x000000018BF10C70
		public void UnloadImmediately() {} // 0x000000018BF10D50-0x000000018BF10D58
		public StreamingStatus QueryStreamingStatus() => default; // 0x000000018BF10D14-0x000000018BF10D1C
		public void SetArea(int areaId, bool enabled) {} // 0x0000000186470E44-0x0000000186470E4C
		public void SetSceneState(int sceneStateId, bool enabled) {} // 0x000000018646EB40-0x000000018646EB48
		private GridStatus QueryGridLoadStatusImpl(StreamingLayer layer, int sceneStateId, int areaId, Vector2 queryPos) => default; // 0x000000018646EDCC-0x000000018646EDF0
		private GridStatus QueryGridLoadStatusByGridIdentifierImpl(GridIdentifier gridIdentifier) => default; // 0x000000018BF10CB4-0x000000018BF10CC8
		public bool IsValid() => default; // 0x000000018646EDC4-0x000000018646EDCC
		public GridStatus QueryGridLoadStatus(StreamingLayer layer, Vector2 queryPos) => default; // 0x000000018BF10CF0-0x000000018BF10D14
		public GridStatus QueryGridLoadStatus(GridIdentifier gridIdentifier) => default; // 0x000000018BF10CC8-0x000000018BF10CF0
		private static void Create_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSceneParameter parameter) {} // 0x0000000184E98990-0x0000000184E989E0
		private static void Destroy_Injected(ref StreamingSceneV2 _unity_self) {} // 0x000000018BF10C34-0x000000018BF10C68
		private static void UnloadImmediately_Injected(ref StreamingSceneV2 _unity_self) {} // 0x000000018BF10D1C-0x000000018BF10D50
		private static StreamingStatus QueryStreamingStatus_Injected(ref StreamingSceneV2 _unity_self) => default; // 0x00000001853A6D50-0x00000001853A6D90
		private static void SetArea_Injected(ref StreamingSceneV2 _unity_self, int areaId, bool enabled) {} // 0x0000000185F50EA0-0x0000000185F50F00
		private static void SetSceneState_Injected(ref StreamingSceneV2 _unity_self, int sceneStateId, bool enabled) {} // 0x0000000185BB7320-0x0000000185BB7380
		private static GridStatus QueryGridLoadStatusImpl_Injected(ref StreamingSceneV2 _unity_self, StreamingLayer layer, int sceneStateId, int areaId, ref Vector2 queryPos) => default; // 0x0000000184DDEAB0-0x0000000184DDEB20
		private static GridStatus QueryGridLoadStatusByGridIdentifierImpl_Injected(ref StreamingSceneV2 _unity_self, ref GridIdentifier gridIdentifier) => default; // 0x000000018BF10C70-0x000000018BF10CB4
		private static StreamingMode get_streamingMode_Injected(ref StreamingSceneV2 _unity_self) => default; // 0x000000018BF10D58-0x000000018BF10D8C
		private static void set_streamingMode_Injected(ref StreamingSceneV2 _unity_self, StreamingMode value) {} // 0x0000000185F373C0-0x0000000185F37410
		private static void get_primaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, out StreamingSourceData ret) {
			ret = default;
		} // 0x0000000184A64AC0-0x0000000184A64B10
		private static void set_primaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSourceData value) {} // 0x000000018518B0F0-0x000000018518B140
		private static void set_secondaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSourceData value) {} // 0x0000000185F7A440-0x0000000185F7A490
		private static float get_streamingProgress_Injected(ref StreamingSceneV2 _unity_self) => default; // 0x00000001853A6E40-0x00000001853A6E80
		private static bool IsValid_Injected(ref StreamingSceneV2 _unity_self) => default; // 0x0000000184EC2CD0-0x0000000184EC2D10
	}

	public delegate void ECSEntityHasRequiredComponentsDelegate(); // TypeDefIndex: 58525; 0x00000001864BC320-0x00000001864BC330

	public delegate void ECSEntityConvertToDelegate(); // TypeDefIndex: 58526; 0x00000001864BC320-0x00000001864BC330

	public delegate void ProxyEntityHasRequiredComponentsDelegate(); // TypeDefIndex: 58527; 0x00000001864BC320-0x00000001864BC330

	public delegate void ProxyEntityConvertToDelegate(); // TypeDefIndex: 58528; 0x00000001864BC320-0x00000001864BC330

	public delegate void MonoIsConvertorOfComponentDelegate(); // TypeDefIndex: 58529; 0x00000001864BC320-0x00000001864BC330

	public delegate void MonoComponentConvertToDelegate(); // TypeDefIndex: 58530; 0x00000001864BC320-0x00000001864BC330

	public delegate bool ECSEntityConvertFromDelegate(Entity entity, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 58531; 0x0000000185478970-0x00000001854789C0

	public delegate bool ProxyEntityConvertFromDelegate(ref IntPtr proxyPtr, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 58532; 0x00000001855DEB20-0x00000001855DEB70

	public delegate bool MonoComponentConvertFromDelegate(Component component, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 58533; 0x00000001856F4840-0x00000001856F4890

	public delegate Component MonoComponentAddComponentToDelegate(GameObject gameObject); // TypeDefIndex: 58534; 0x00000001857CCD00-0x00000001857CCE20

	public delegate Component MonoComponentGetComponentFromDelegate(GameObject gameObject, int multiComponentIndex); // TypeDefIndex: 58535; 0x0000000185A6C720-0x0000000185A6C840

	public static class HGStreamingSceneManager // TypeDefIndex: 58536
	{
		// Properties
		public static int streamingVersion { get; } // 0x000000018457A9C0-0x000000018457AA00 
		public static int streamingChunkSize { get; } // 0x000000018596E010-0x000000018596E050 
		private static IntPtr streamingScenesManaged { get; } // 0x000000018BF0FD6C-0x000000018BF0FD98 
		private static int streamingSceneCount { get; } // 0x000000018BF0FD40-0x000000018BF0FD6C 
	
		// Methods
		public static void ResetLastProcessStreamingPos() {} // 0x0000000185F7E260-0x0000000185F7E2A0
		public static void BindECSEntityConvertFuncFromScript(ECSEntityType entityType, ECSEntityHasRequiredComponentsDelegate hasRequiredComponentsDelegate, ECSEntityConvertToDelegate convertToDelegate, ECSEntityConvertFromDelegate convertFromFunc) {} // 0x00000001854A1E20-0x00000001854A1E90
		public static void ResetECSEntityConvertFuncFromScript(ECSEntityType entityType) {} // 0x000000018BF0FC70-0x000000018BF0FCA4
		public static bool IsECSEntityConvertFuncValid(ECSEntityType entityType) => default; // 0x00000001854A1DE0-0x00000001854A1E20
		public static void BindProxyEntityConvertFuncFromScript(ProxyEntityType entityType, ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, ProxyEntityConvertToDelegate convertToFunc, ProxyEntityConvertFromDelegate convertFromFunc) {} // 0x00000001854A1CD0-0x00000001854A1D40
		public static void ResetProxyEntityConvertFuncFromScript(ProxyEntityType entityType) {} // 0x000000018BF0FCD8-0x000000018BF0FD0C
		public static bool IsProxyEntityConvertFuncValid(ProxyEntityType entityType) => default; // 0x00000001854A1C90-0x00000001854A1CD0
		public static void BindMonoComponentConvertFuncFromScript(StreamingComponentType componentType, MonoIsConvertorOfComponentDelegate isConvertorOfFunc, MonoComponentConvertToDelegate convertToFunc, MonoComponentConvertFromDelegate convertFromFunc, MonoComponentAddComponentToDelegate addComponentToFunc, MonoComponentGetComponentFromDelegate getComponentFromFunc) {} // 0x00000001854A1B80-0x00000001854A1BF0
		public static void ResetMonoComponentConvertFuncFromScript(StreamingComponentType componentType) {} // 0x000000018BF0FCA4-0x000000018BF0FCD8
		public static bool IsMonoComponentConvertFuncValid(StreamingComponentType componentType) => default; // 0x00000001854A1B40-0x00000001854A1B80
		public static void BindProxyEntityConvertToFuncFromScript(ProxyEntityType entityType, ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, ProxyEntityConvertToDelegate convertToFunc) {} // 0x00000001854A1E90-0x00000001854A1EF0
		public static void ResetProxyEntityConvertToFuncFromScript(ProxyEntityType entityType) {} // 0x000000018BF0FD0C-0x000000018BF0FD40
		public static NativeArray<StreamingSceneV2> GetStreamingScenesArray() => default; // 0x000000018BF0FBF4-0x000000018BF0FC70
	}

	public struct StreamingLayerConfig // TypeDefIndex: 58537
	{
		// Fields
		public bool enabled; // 0x00
		public StreamingLayer layer; // 0x01
		public bool chunkLoad; // 0x02
		public int gridSize; // 0x04
		public int priority; // 0x08
	}

	public static class HGStreamingSettings // TypeDefIndex: 58538
	{
		// Properties
		public static float loadDirtyDistance { get; set; } // 0x0000000184456CA0-0x0000000184456CF0
		public static float unloadDirtyDistance { get; set; } // 0x0000000184456C50-0x0000000184456CA0
		public static float loadElapsedMsPerFrame { get; set; } // 0x0000000184456C00-0x0000000184456C50
		public static float unloadElapsedMsPerFrame { get; set; } // 0x0000000184456BB0-0x0000000184456C00
		public static bool sequentialUnloadBeforeLoad { get; set; } // 0x000000018BF0FD98-0x000000018BF0FDCC
	
		// Methods
		public static void SetLayerConfig(StreamingLayer layer, StreamingLayerConfig config) {} // 0x0000000186473E90-0x0000000186473EA4
		private static void SetLayerConfig_Injected(StreamingLayer layer, ref StreamingLayerConfig config) {} // 0x00000001854A1EF0-0x00000001854A1F40
	}
}
