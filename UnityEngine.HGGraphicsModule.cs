/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;
using UnityEngine.Scripting;

// Image 52: UnityEngine.HGGraphicsModule.dll - Assembly: UnityEngine.HGGraphicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 87715-87990

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 87716
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 87717
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 87718
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine
{
	[NativeHeader("Modules/HGGraphics/Public/CapsuleShadow/HGCapsuleBindingComponent.h")]
	public class HGCapsuleBindingComponent : Component // TypeDefIndex: 87719
	{
		// Properties
		public bool enabled { set; } // 0x00000001859DF770-0x00000001859DF7C0
		public float capsuleRadius { set; } // 0x00000001859DF7C0-0x00000001859DF810
		public float capsuleHeight { set; } // 0x00000001859DF810-0x00000001859DF860
		public Vector3 localOffset { set; } // 0x0000000187838D8C-0x0000000187838DA0
		public Vector3 localRotation { set; } // 0x0000000187838DA0-0x0000000187838DB4
		public float intensityScale { set; } // 0x00000001859DF860-0x00000001859DF8B0
		public bool forceRender { set; } // 0x00000001859DF8B0-0x00000001859DF900
	
		// Methods
		private void set_localOffset_Injected(ref Vector3 value); // 0x00000001869B29E0-0x00000001869B2A30
		private void set_localRotation_Injected(ref Vector3 value); // 0x00000001869B2990-0x00000001869B29E0
	}

	public enum HGDecalShapeType // TypeDefIndex: 87720
	{
		Box = 0,
		Cylinder = 1,
		Sector = 2,
		Sphere = 3,
		Mesh = 255
	}

	[NativeHeader("Modules/HGGraphics/Public/Decal/HGDecalProjector.h")]
	public sealed class HGDecalProjector : UnityEngine.Behaviour // TypeDefIndex: 87721
	{
		// Properties
		public HGDecalShapeType shapeType { get; } // 0x0000000186CE2110-0x0000000186CE2150 
		public Material material { get; set; } // 0x0000000186DFE330-0x0000000186DFE370 0x000000018D52247C-0x000000018D5224C0
		public Bounds bounds { get; } // 0x000000018D5223F4-0x000000018D522424 
		public UnityEngine.Color baseColor { get; set; } // 0x000000018D522384-0x000000018D5223B0 0x000000018D522468-0x000000018D52247C
		public Vector2 uvOffset { get; set; } // 0x0000000186CE21F0-0x0000000186CE2240 0x000000018783D4B8-0x000000018783D4D4
		public float sectorAngle { set; } // 0x000000018D5224C0-0x000000018D522504
	
		// Methods
		private void get_bounds_Injected(out Bounds ret); // 0x000000018D5223B0-0x000000018D5223F4
		private void get_baseColor_Injected(out UnityEngine.Color ret); // 0x000000018D522340-0x000000018D522384
		private void set_baseColor_Injected(ref UnityEngine.Color value); // 0x000000018D522424-0x000000018D522468
		private void get_uvOffset_Injected(out Vector2 ret); // 0x0000000186CE2240-0x0000000186CE2290
		private void set_uvOffset_Injected(ref Vector2 value); // 0x00000001871FC570-0x00000001871FC5C0
	}

	public enum HGGPUParticleLoopMode // TypeDefIndex: 87722
	{
		Once = 0,
		LoopN = 1,
		LoopInfinite = 2
	}

	public struct HGGPUParticleBurst // TypeDefIndex: 87723
	{
		// Fields
		public float time; // 0x00
		public uint minCount; // 0x04
		public uint maxCount; // 0x08
	}

	[NativeHeader("Modules/HGGraphics/Public/GPUParticle/HGGPUParticleSystem.h")]
	public sealed class HGGPUParticleSystem : UnityEngine.Behaviour // TypeDefIndex: 87724
	{
		// Fields
		public const int MaxBurstsPerEmitter = 8; // Metadata: 0x02647B44
	
		// Properties
		public int emitterCount { get; } // 0x0000000184F700F0-0x0000000184F70140 
		public int streamingBoundsMode { get; set; } // 0x0000000184F702E0-0x0000000184F70330 0x0000000184F704B0-0x0000000184F70510
		public Vector3 streamingBoundMin { get; set; } // 0x0000000184F70270-0x0000000184F702E0 0x0000000184F70450-0x0000000184F704B0
		public Vector3 streamingBoundMax { get; set; } // 0x0000000184F701A0-0x0000000184F70210 0x0000000184F70390-0x0000000184F703F0
	
		// Constructors
		public HGGPUParticleSystem(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[NativeName("GetEmitterEmissionRate")]
		public float GetEmitterEmissionRate(int index); // 0x0000000184F6FD30-0x0000000184F6FD90
		[NativeName("SetEmitterEmissionRate")]
		public void SetEmitterEmissionRate(int index, float value); // 0x0000000184F6FFA0-0x0000000184F70010
		[NativeName("GetEmitterCastShadows")]
		internal int GetEmitterCastShadowsRaw(int index); // 0x0000000184F6FC70-0x0000000184F6FCD0
		[NativeName("SetEmitterCastShadows")]
		internal void SetEmitterCastShadowsRaw(int index, int value); // 0x0000000184F6FEC0-0x0000000184F6FF30
		public ShadowCastingMode GetEmitterCastShadows(int index); // 0x0000000184F6FC70-0x0000000184F6FCD0
		public void SetEmitterCastShadows(int index, ShadowCastingMode mode); // 0x0000000184F6FEC0-0x0000000184F6FF30
		public float GetEmitterDuration(int index); // 0x0000000184F6FCD0-0x0000000184F6FD30
		public void SetEmitterDuration(int index, float value); // 0x0000000184F6FF30-0x0000000184F6FFA0
		[NativeName("GetEmitterLoopMode")]
		internal int GetEmitterLoopModeRaw(int index); // 0x0000000184F6FDF0-0x0000000184F6FE50
		[NativeName("SetEmitterLoopMode")]
		internal void SetEmitterLoopModeRaw(int index, int mode); // 0x0000000184F70080-0x0000000184F700F0
		public HGGPUParticleLoopMode GetEmitterLoopMode(int index); // 0x0000000184F6FDF0-0x0000000184F6FE50
		public void SetEmitterLoopMode(int index, HGGPUParticleLoopMode mode); // 0x0000000184F70080-0x0000000184F700F0
		public int GetEmitterLoopCount(int index); // 0x0000000184F6FD90-0x0000000184F6FDF0
		public void SetEmitterLoopCount(int index, int count); // 0x0000000184F70010-0x0000000184F70080
		public int GetEmitterBurstCount(int index); // 0x0000000184F6FB00-0x0000000184F6FB60
		public HGGPUParticleBurst GetEmitterBurst(int index, int burstIndex); // 0x0000000184F6FBE0-0x0000000184F6FC70
		public void SetEmitterBursts(int index, HGGPUParticleBurst[] bursts); // 0x0000000184F6FE50-0x0000000184F6FEC0
		private void get_streamingBoundMin_Injected(out Vector3 ret); // 0x0000000184F70210-0x0000000184F70270
		private void set_streamingBoundMin_Injected(ref Vector3 value); // 0x0000000184F703F0-0x0000000184F70450
		private void get_streamingBoundMax_Injected(out Vector3 ret); // 0x0000000184F70140-0x0000000184F701A0
		private void set_streamingBoundMax_Injected(ref Vector3 value); // 0x0000000184F70330-0x0000000184F70390
		private void GetEmitterBurst_Injected(int index, int burstIndex, out HGGPUParticleBurst ret); // 0x0000000184F6FB60-0x0000000184F6FBE0
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGMeshRenderer.h")]
	public sealed class HGMeshRenderer : UnityEngine.Behaviour // TypeDefIndex: 87725
	{
		// Properties
		public HGMeshRendererData data { [NativeName("GetData")] get; [NativeName("SetData")] set; } // 0x000000018D524194-0x000000018D5241C8 0x000000018D5241C8-0x000000018D52420C
	
		// Methods
		public Entity GetEntity(); // 0x000000018D524170-0x000000018D524194
		private void GetEntity_Injected(out Entity ret); // 0x000000018D52412C-0x000000018D524170
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGMeshRendererData.h")]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGMeshRendererData.bindings.h")]
	[UsedByNativeCode]
	public sealed class HGMeshRendererData : UnityEngine.Object // TypeDefIndex: 87726
	{
		// Constructors
		public HGMeshRendererData(); // 0x000000018D5240E0-0x000000018D52412C
	
		// Methods
		[FreeFunction("HGMeshRendererData_Bindings::Create")]
		private static void Internal_Create([Writable] HGMeshRendererData self); // 0x000000018D524068-0x000000018D52409C
		public Material[] GetMaterials(); // 0x000000018D524000-0x000000018D524034
		public void SetMaterials(Material[] materials); // 0x000000018D52409C-0x000000018D5240E0
		public Mesh[] GetMeshes(); // 0x000000018D524034-0x000000018D524068
	}

	[NativeHeader("Modules/HGGraphics/Public/OC/HGOccluder.h")]
	public sealed class HGOccluder : Component // TypeDefIndex: 87727
	{
		// Properties
		public bool enabled { get; set; } // 0x000000018D52420C-0x000000018D524240 0x000000018D524274-0x000000018D5242B8
		public HGSoftwareOcclusionCullingData occluderData { get; set; } // 0x000000018D524240-0x000000018D524274 0x000000018D5242B8-0x000000018D5242FC
	
		// Constructors
		public HGOccluder(); // 0x00000001878364A0-0x00000001878364B8
	}

	[NativeHeader("Modules/HGGraphics/Public/OC/HGSoftwareOcclusionCullingData.h")]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGSoftwareOcclusionCulling.bindings.h")]
	[UsedByNativeCode]
	public sealed class HGSoftwareOcclusionCullingData : UnityEngine.Object // TypeDefIndex: 87728
	{
		// Properties
		public int quadCount { get; } // 0x000000018D524F2C-0x000000018D524F60 
	
		// Constructors
		public HGSoftwareOcclusionCullingData(); // 0x000000018D524EE0-0x000000018D524F2C
	
		// Methods
		[FreeFunction("HGSoftwareOcclusionCulling_Bindings::CreateOcclusionCullingData")]
		private static void Internal_Create([Writable] HGSoftwareOcclusionCullingData cullingData); // 0x000000018D524EAC-0x000000018D524EE0
		public void GetOccluderData(NativeArray<float> centerXs, NativeArray<float> centerYs, NativeArray<float> centerZs, NativeArray<float> extentXs, NativeArray<float> extentYs, NativeArray<float> extentZs, NativeArray<Vector3> vertexData, ref int quadCount); // 0x000000018D524D4C-0x000000018D524EAC
		public void GetOccluderData(IntPtr centerXs, IntPtr centerYs, IntPtr centerZs, IntPtr extentXs, IntPtr extentYs, IntPtr extentZs, IntPtr vertexData, ref int quadCount); // 0x000000018D524CE8-0x000000018D524D4C
	}

	public enum TransformAnimatedPhasePlayMode // TypeDefIndex: 87729
	{
		TransformAnimatedPhaseCurrent = 0,
		TransformAnimatedPhaseSequence = 1,
		TransformAnimatedPhaseSequenceLoop = 2
	}

	[Serializable]
	[UsedByNativeCode]
	public struct TransformAnimatedCurveData // TypeDefIndex: 87730
	{
		// Fields
		public byte[] data; // 0x00
		public float duration; // 0x08
	}

	[Serializable]
	[UsedByNativeCode]
	public struct TransformMotionPhase // TypeDefIndex: 87731
	{
		// Fields
		public Vector3 translationSpeed; // 0x00
		public Vector3 eulerAngleSpeed; // 0x0C
		public Vector3 rotAnchorPosition; // 0x18
		public float duration; // 0x24
	}

	public struct HGTransformAnimatedProfile // TypeDefIndex: 87732
	{
		// Fields
		public TransformMotionPhase[] motionPhaseProfiles; // 0x00
		public TransformAnimatedCurveData animCurveData; // 0x08
		public TransformAnimatedPhasePlayMode phasePlayMode; // 0x18
	}

	[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedBehaviour.h")]
	public sealed class HGTransformAnimatedBehaviour : UnityEngine.Behaviour // TypeDefIndex: 87733
	{
		// Fields
		public HGTransformAnimatedProfile profileData; // 0x18
		public bool useLogicDeltaTime; // 0x38
		public Renderer shadowProxyRenderer; // 0x40
	
		// Constructors
		public HGTransformAnimatedBehaviour(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetPause(); // 0x000000018D525CBC-0x000000018D525CF0
		public void Play(); // 0x000000018D525C48-0x000000018D525C7C
		public float GetTimeScale(); // 0x000000018D525B98-0x000000018D525BCC
		public void SetTimeScale(float scale); // 0x000000018D525CF0-0x000000018D525D34
		public void SetCurrentPhaseIndex(int phase); // 0x000000018D525C7C-0x000000018D525CBC
		public int GetCurrentPhaseIndex(); // 0x000000018D525B64-0x000000018D525B98
		public Matrix4x4 GetWorldMatrix(); // 0x000000018D525C10-0x000000018D525C48
		public void SetUseLogicTime(bool useLogicTime); // 0x000000018D525D34-0x000000018D525D78
		public bool UseLogicTime(); // 0x000000018D525D78-0x000000018D525DAC
		private void GetWorldMatrix_Injected(out Matrix4x4 ret); // 0x000000018D525BCC-0x000000018D525C10
	}

	public static class HGTransformAnimatedSystemCPP // TypeDefIndex: 87734
	{
		// Methods
		[FreeFunction("HGTransformAnimatedSystemCPP_Create")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static long HGTransformAnimatedSystemCPP_Create(); // 0x0000000185E6B500-0x0000000185E6B540
		[FreeFunction("HGTransformAnimatedSystemCPP_UpdateAbsoluteTime")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static void HGTransformAnimatedSystemCPP_UpdateAbsoluteTime(long ptr, float absoluteTimeSec); // 0x0000000185E6B4B0-0x0000000185E6B500
		[FreeFunction("HGTransformAnimatedSystemCPP_Destroy")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static void HGTransformAnimatedSystemCPP_Destroy(long ptr); // 0x000000018D525DAC-0x000000018D525DE0
	}

	[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformBehaviour.h")]
	public sealed class HGWindFoliageSyncTransformBehaviour : UnityEngine.Behaviour // TypeDefIndex: 87735
	{
		// Fields
		public MeshRenderer m_windPlant; // 0x18
		public MeshRenderer m_windPlantMobile; // 0x20
	
		// Constructors
		public HGWindFoliageSyncTransformBehaviour(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void Disable(); // 0x000000018D526150-0x000000018D526184
	}

	public class HGWindFoliageSyncSystemCPP // TypeDefIndex: 87736
	{
		// Methods
		[FreeFunction("HGWindFoliageSyncSystemCPP_Create")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static long HGWindFoliageSyncSystemCPP_Create(); // 0x00000001862CDC40-0x00000001862CDC80
		[FreeFunction("HGWindFoliageSyncSystemCPP_UpdateGlobalWindParam")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static void HGWindFoliageSyncSystemCPP_UpdateGlobalWindParam(long _ptr, Vector4 windGlobalParam, float time, float lastTime); // 0x0000000187839EA8-0x0000000187839EC0
		[FreeFunction("HGWindFoliageSyncSystemCPP_Destroy")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static void HGWindFoliageSyncSystemCPP_Destroy(long _ptr); // 0x000000018D52611C-0x000000018D526150
		private static void HGWindFoliageSyncSystemCPP_UpdateGlobalWindParam_Injected(long _ptr, ref Vector4 windGlobalParam, float time, float lastTime); // 0x0000000185C67E20-0x0000000185C67E90
	}
}

namespace UnityEngine.HyperGryph
{
	[NativeHeader("Modules/StreamLine/StreamlineDLSSG.h")]
	[NativeHeader("Modules/StreamLine/StreamlineDLSS.h")]
	[NativeHeader("Modules/StreamLine/StreamlineReflex.h")]
	[NativeHeader("Modules/HGGraphics/Public/DLSS/HGDLSSUtil.h")]
	[UsedByNativeCode]
	public struct HGDLSSUtil // TypeDefIndex: 87737
	{
		// Methods
		[FreeFunction("IsStreamlineDLSSSupported")]
		[UsedByNativeCode]
		public static bool IsStreamlineDLSSSupported(); // 0x00000001850F6D20-0x00000001850F6D60
		[FreeFunction("IsStreamlineDLSSGSupported")]
		[UsedByNativeCode]
		public static bool IsStreamlineDLSSGSupported(); // 0x00000001854756C0-0x0000000185475700
		[FreeFunction("IsLowLatencyAvailable")]
		[UsedByNativeCode]
		public static bool IsLowLatencyAvailable(); // 0x00000001854726A0-0x00000001854726E0
	}

	[NativeType("Modules/HGGraphics/Public/GPUDriven/Version1/GPUDrivenRendererV1.h")]
	[StaticAccessor("GetGPUDrivenRendererV1()", StaticAccessorType.Dot)]
	public static class GPUDrivenRendererV1 // TypeDefIndex: 87738
	{
		// Methods
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, bool retainCustomDS, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, ref Matrix4x4 view, ref Matrix4x4 proj, ref Matrix4x4 nonJitteredProj, ref Vector4 zBufferParams, ref Matrix4x4 prevView, ref Matrix4x4 prevViewProj, ref Matrix4x4 prevNonJitteredViewProj, ref Vector3 cameraPos); // 0x000000018D521AE0-0x000000018D521B48
		public static bool Valid(); // 0x00000001862B82C0-0x00000001862B8300
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool retainCustomDS, out uint normalList, out uint preZPart0List, out uint preZPart1List, ref Matrix4x4 view, ref Matrix4x4 proj, ref Matrix4x4 nonJitteredProj, ref Vector4 zBufferParams, ref Matrix4x4 prevView, ref Matrix4x4 prevViewProj, ref Matrix4x4 prevNonJitteredViewProj, ref Vector3 cameraPos); // 0x000000018D521B48-0x000000018D521C00
		public static void DrawRendererList(CommandBuffer cmd, uint rendererList, bool renderDepthOnly); // 0x000000018D521CD4-0x000000018D521CF0
		public static void AdvanceFrame(); // 0x000000018D5219A4-0x000000018D5219D0
		public static void ToggleCullingInspectionMode(bool flag); // 0x000000018D521D50-0x000000018D521D84
		public static bool CullingInspectionMode(); // 0x000000018D521C00-0x000000018D521C2C
		public static void PopulatePerFrameData(CommandBuffer cmd, uint threadGroupSize, uint hzbWidth, uint hzbHeight, bool usePrevVP = false /* Metadata: 0x02647B48 */); // 0x000000018D521CF0-0x000000018D521D50
		public static void BindFrameConstantsBuffer(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018D521A8C-0x000000018D521AE0
		public static void BindFrameConstantsBufferGlobal(CommandBuffer cmd); // 0x000000018D521A58-0x000000018D521A8C
		public static void BindBuffersForCulling(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018D5219D0-0x000000018D521A24
		public static void BindBuffersForRendering(CommandBuffer cmd); // 0x000000018D521A24-0x000000018D521A58
		public static void DispatchComputeMeshletInstanceCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018D521C80-0x000000018D521CD4
		public static void DispatchComputeDrawBucketCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018D521C2C-0x000000018D521C80
	}

	[NativeType("Modules/HGGraphics/Public/GPUDriven/Version2/GPUDrivenRendererV2.h")]
	[StaticAccessor("GetGPUDrivenRendererV2()", StaticAccessorType.Dot)]
	public static class GPUDrivenRendererV2 // TypeDefIndex: 87739
	{
		// Methods
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, ref Matrix4x4 view, ref Matrix4x4 proj, ref Matrix4x4 nonJitteredProj, ref Vector4 zBufferParams, ref Matrix4x4 prevView, ref Matrix4x4 prevViewProj, ref Matrix4x4 prevNonJitteredViewProj, ref Vector3 cameraPos); // 0x000000018D521EC0-0x000000018D521F28
		public static bool Valid(); // 0x00000001862B8280-0x00000001862B82C0
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, out uint normalList, out uint preZPart0List, out uint preZPart1List, ref Matrix4x4 view, ref Matrix4x4 proj, ref Matrix4x4 nonJitteredProj, ref Vector4 zBufferParams, ref Matrix4x4 prevView, ref Matrix4x4 prevViewProj, ref Matrix4x4 prevNonJitteredViewProj, ref Vector3 cameraPos); // 0x000000018D521F28-0x000000018D521FE0
		public static void DrawRendererList(CommandBuffer cmd, uint rendererList, bool renderDepthOnly); // 0x000000018D521CD4-0x000000018D521CF0
		public static void AdvanceFrame(); // 0x000000018D521D84-0x000000018D521DB0
		public static void ToggleCullingInspectionMode(bool flag); // 0x000000018D522114-0x000000018D522148
		public static bool CullingInspectionMode(); // 0x000000018D521FE0-0x000000018D52200C
		public static void PopulatePerFrameData(CommandBuffer cmd, uint threadGroupSize, uint hzbWidth, uint hzbHeight, bool usePrevVP = false /* Metadata: 0x02647B49 */); // 0x000000018D5220B4-0x000000018D522114
		public static void BindFrameConstantsBuffer(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018D521E6C-0x000000018D521EC0
		public static void BindFrameConstantsBufferGlobal(CommandBuffer cmd); // 0x000000018D521E38-0x000000018D521E6C
		public static void BindBuffersForCulling(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018D521DB0-0x000000018D521E04
		public static void BindBuffersForRendering(CommandBuffer cmd); // 0x000000018D521E04-0x000000018D521E38
		public static void DispatchComputeMeshletInstanceCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018D522060-0x000000018D5220B4
		public static void DispatchComputeDrawBucketCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018D52200C-0x000000018D522060
	}

	public struct CapsuleData // TypeDefIndex: 87740
	{
		// Fields
		public Vector3 pa; // 0x00
		public float radius; // 0x0C
		public Vector3 pb; // 0x10
		public float len; // 0x1C
		public Vector3 dir; // 0x20
		public float padding; // 0x2C
	}

	[NativeType("Modules/HGGraphics/Public/CapsuleShadow/HGCapsuleShadowManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetCapsuleShadowManager()", StaticAccessorType.Dot)]
	public static class HGCapsuleShadowManager // TypeDefIndex: 87741
	{
		// Methods
		public static uint GetRenderCapsuleNum(); // 0x000000018D522314-0x000000018D522340
		public static uint CullAndGetRenderCapsuleData(uint viewHandle, IntPtr outData, uint outDataCapacity); // 0x000000018D5222C4-0x000000018D522314
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGDecalRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetDecalRender()", StaticAccessorType.Dot)]
	public static class HGDecalRender // TypeDefIndex: 87742
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGShaderLightMode lightModeMask, IntPtr context); // 0x000000018D522504-0x000000018D522520
		public static uint CreateRendererList(uint viewHandle, HGShaderLightMode lightModeMask, IntPtr context, IntPtr drawableFeedbackPtr); // 0x000000018D522520-0x000000018D522530
		private static unsafe uint CreateRendererList(uint viewHandle, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr); // 0x000000018D522530-0x000000018D522590
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018D522590-0x000000018D5225AC
	}

	public struct HGDrawCallDetailedStats // TypeDefIndex: 87743
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

	[NativeHeader("Modules/HGGraphics/Public/Common/HGFastString.h")]
	public class HGFastString // TypeDefIndex: 87744
	{
		// Methods
		[FreeFunction("HyperGryph::HGFastString::IndexToString")]
		public static string IndexToString(int index); // 0x000000018D522D78-0x000000018D522DAC
	}

	public enum HGFactoryLODTier // TypeDefIndex: 87745
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryRendererData // TypeDefIndex: 87746
	{
		// Fields
		public Mesh m_mesh; // 0x00
		public Mesh m_shadowProxyMesh; // 0x08
		public Material[] m_materials; // 0x10
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryInstancingLODDataV3 // TypeDefIndex: 87747
	{
		// Fields
		public HGFactoryRendererData[] m_rendererDataArr; // 0x00
		public Vector4 m_lodScreenSizeMaxs; // 0x08
		public Vector4 m_lodScreenSizeMins; // 0x18
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryEntityDesc // TypeDefIndex: 87748
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

	public struct HGFactoryEntityTransformData // TypeDefIndex: 87749
	{
		// Fields
		public Vector4 m_positionAndScale; // 0x00
		public Quaternion m_rotation; // 0x10
	}

	[NativeHeader("Modules/HGGraphics/Public/Factory/HGFactoryRenderManager.h")]
	[StaticAccessor("HyperGryph::HGFactoryRenderManager::GetInstance()", StaticAccessorType.Dot)]
	public static class HGFactoryRenderManager // TypeDefIndex: 87750
	{
		// Methods
		public static void SetFactoryLodTier(HGFactoryLODTier lodTier); // 0x0000000186FB53B0-0x0000000186FB53F0
		public static Entity CreateRegularEntity(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, string entityName, Entity gameplayEntity, Material[] additiveMaterials); // 0x000000018598A160-0x000000018598A1F0
		public static void UpdateRegularEntity(Entity gameplayEntity, HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc); // 0x000000018783B02C-0x000000018783B048
		public static void UpdateRegularEntityAdditiveMaterials(Entity gameplayEntity, Material[] additiveMaterials); // 0x000000018783B048-0x000000018783B064
		public static void DestroyRegularEntity(Entity gameplayEntity); // 0x000000018D522B38-0x000000018D522B54
		public static void CreateBatchedEntities(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, NativeArray<Entity> entities, NativeArray<Entity> gameplayEntities, string entityName); // 0x00000001862C1770-0x00000001862C18B0
		public static void DestroyBatchedEntities(NativeArray<Entity> gameplayEntities); // 0x000000018D522AC0-0x000000018D522AF8
		private static void CreateBatchedEntities(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, IntPtr entities, IntPtr gameplayEntities, int count, string entityName); // 0x000000018783BD78-0x000000018783BDA4
		private static void DestroyBatchedEntities(IntPtr gameplayEntities, int count); // 0x000000018D522AF8-0x000000018D522B38
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityEnabledLightModes(Entity rendererEntity, uint lightModeMask); // 0x000000018D522C08-0x000000018D522C24
		public static void SetEntitySharedData<T>(uint sharedDataIndex, T data, int offset)
			where T : struct;
		[NativeMethod(IsThreadSafe = true)]
		private static void SetEntitySharedDataPartial(uint sharedDataIndex, IntPtr data, int offset, int size); // 0x0000000185FBFDB0-0x0000000185FC0560
		[NativeMethod(IsThreadSafe = true)]
		public static byte GetEntityDirtyFlags(uint sharedDataIndex); // 0x000000018598F0F0-0x000000018598F130
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityDirtyFlags(uint sharedDataIndex, byte flags); // 0x000000018598F130-0x000000018598F180
		[NativeMethod(IsThreadSafe = true)]
		public static byte GetEntityObjectFlags(uint sharedDataIndex); // 0x000000018598F020-0x000000018598F060
		[NativeMethod(IsThreadSafe = true)]
		public static uint GetEntityAdditiveVFXFlags(uint sharedDataIndex); // 0x000000018D522B54-0x000000018D522B88
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityAdditiveVFXFlags(uint sharedDataIndex, uint flags); // 0x000000018D522B88-0x000000018D522BC8
		public static void FrameUpdateEntities(); // 0x0000000186805BA0-0x0000000186805BB0
		private static void CreateRegularEntity_Injected(HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc, string entityName, ref Entity gameplayEntity, Material[] additiveMaterials, out Entity ret); // 0x000000018598A240-0x000000018598A2B0
		private static void UpdateRegularEntity_Injected(ref Entity gameplayEntity, HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc); // 0x0000000186CB3A70-0x0000000186CB3AD0
		private static void UpdateRegularEntityAdditiveMaterials_Injected(ref Entity gameplayEntity, Material[] additiveMaterials); // 0x0000000186D248F0-0x0000000186D24940
		private static void DestroyRegularEntity_Injected(ref Entity gameplayEntity); // 0x0000000186B7C6C0-0x0000000186B7C700
		private static void CreateBatchedEntities_Injected(HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc, IntPtr entities, IntPtr gameplayEntities, int count, string entityName); // 0x00000001862BF890-0x00000001862BF900
		private static void SetEntityEnabledLightModes_Injected(ref Entity rendererEntity, uint lightModeMask); // 0x000000018D522BC8-0x000000018D522C08
	}

	[UsedByNativeCode]
	public struct HGFoliageInteractCPP // TypeDefIndex: 87751
	{
		// Fields
		public int compID; // 0x00
		public Transform transform; // 0x08
		public Mesh interactCollider; // 0x10
	}

	[UsedByNativeCode]
	public struct HGFoliageInteractRaftCPP // TypeDefIndex: 87752
	{
		// Fields
		public int compID; // 0x00
		public Transform transform; // 0x08
		public Mesh interactCollider; // 0x10
	}

	[NativeType("Modules/HGGraphics/Public/FoliageInteractive/FoliageInteractiveManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageInteractiveManager()", StaticAccessorType.Dot)]
	public static class HGFoliageInteractiveManagerV2 // TypeDefIndex: 87753
	{
		// Methods
		public static void SetupFoliageInteractiveManager(Mesh characterProxyMesh, bool enabled); // 0x00000001871CB230-0x00000001871CB280
		public static void CleanUpFoliageInteractiveManager(); // 0x0000000185B9E060-0x0000000185B9E0A0
		public static void SetEnabled(bool enabled); // 0x0000000186CEECA0-0x0000000186CEECE0
		public static void SetInteractCenter(Vector3 center); // 0x0000000187837E2C-0x0000000187837E3C
		public static void SetCharacterPositions(List<Vector3> positions); // 0x0000000185679D80-0x0000000185679E80
		public static unsafe void SetCharacterPositions(Vector3* positions, int count); // 0x0000000185679E80-0x0000000185679ED0
		public static void RegisterInteract(HGFoliageInteractCPP interact); // 0x000000018D522E24-0x000000018D522E34
		public static void UnregisterInteract(int interactInstID); // 0x000000018D522E68-0x000000018D522E9C
		public static void RegisterInteractRaft(HGFoliageInteractRaftCPP raft); // 0x000000018D522DE0-0x000000018D522DF0
		public static void UnregisterInteractRaft(int raftInstID); // 0x000000018D522E34-0x000000018D522E68
		private static void SetInteractCenter_Injected(ref Vector3 center); // 0x00000001863C3AF0-0x00000001863C3B30
		private static void RegisterInteract_Injected(ref HGFoliageInteractCPP interact); // 0x000000018D522DF0-0x000000018D522E24
		private static void RegisterInteractRaft_Injected(ref HGFoliageInteractRaftCPP raft); // 0x000000018D522DAC-0x000000018D522DE0
	}

	[NativeType("Modules/HGGraphics/Public/FoliageOccluder/FoliageOccluderManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageOccluderManager()", StaticAccessorType.Dot)]
	public static class HGFoliageOccluderManagerV2 // TypeDefIndex: 87754
	{
		// Methods
		public static void SetCenterPosition(Vector3 center); // 0x0000000187837E1C-0x0000000187837E2C
		private static void SetCenterPosition_Injected(ref Vector3 center); // 0x00000001863C3AB0-0x00000001863C3AF0
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGFoliageOccluderRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageOccluderRender()", StaticAccessorType.Dot)]
	public static class HGFoliageOccluderRender // TypeDefIndex: 87755
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, uint materialHandle, uint geometryHandle, HGShaderLightMode lightModeMask, IntPtr context); // 0x000000018D522E9C-0x000000018D522EC0
		private static unsafe uint CreateRendererList(uint viewHandle, uint materialHandle, uint geometryHandle, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr); // 0x000000018D522EC0-0x000000018D522F20
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018D522F20-0x000000018D522F3C
	}

	[NativeType("Modules/HGGraphics/Public/GI/HGGISystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGISystem()", StaticAccessorType.Dot)]
	public static class HGGISystem // TypeDefIndex: 87756
	{
		// Methods
		[NativeMethod("IsEnabled")]
		public static bool GetEnabled(); // 0x00000001862B8200-0x00000001862B8240
	}

	[UsedByNativeCode]
	public struct GpuClothClearBufferDataCPP // TypeDefIndex: 87757
	{
		// Fields
		public bool shouldClear; // 0x00
		public IVec4 eleNum; // 0x04
	
		// Methods
		public bool IsValid(); // 0x00000001844AD2A0-0x00000001844AD2B0
	}

	[UsedByNativeCode]
	public struct ClothGroupUploadDataMapCPP // TypeDefIndex: 87758
	{
		// Fields
		private IVec4 clothNodeDataMap; // 0x00
		private IVec4 clothBatchMetaDataMap; // 0x10
		private IVec4 clothBatchCacheDataMap; // 0x20
	}

	[UsedByNativeCode]
	public struct ClothMetaDataCPP // TypeDefIndex: 87759
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

	[UsedByNativeCode]
	public struct ClothNodeDataCPP // TypeDefIndex: 87762
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
		private unsafe fixed /* 0x00000000-0x00000000 */ int neighborClothNodeCacheIdx[0]; // 0x80
		private unsafe fixed /* 0x00000000-0x00000000 */ float neighborClothNodeDistance[0]; // 0xA0
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _neighborClothNodeCacheIdx_e__FixedBuffer // TypeDefIndex: 87760
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _neighborClothNodeDistance_e__FixedBuffer // TypeDefIndex: 87761
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct GpuClothGroupUploadDataCPP // TypeDefIndex: 87763
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
		public bool IsValid(); // 0x00000001844AD2A0-0x00000001844AD2B0
	}

	[UsedByNativeCode]
	public struct ClothConstDataCPP // TypeDefIndex: 87765
	{
		// Fields
		private Vector4 packedDeltaT; // 0x00
		private Vector4 clothParam1; // 0x10
		private unsafe fixed /* 0x00000000-0x00000000 */ float colliderInfos[0]; // 0x20
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _colliderInfos_e__FixedBuffer // TypeDefIndex: 87764
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct GpuClothRenderDataCPP // TypeDefIndex: 87766
	{
		// Fields
		public bool isValid; // 0x00
		public int clothNum; // 0x04
		public ClothConstDataCPP clothConstData; // 0x08
	
		// Methods
		public bool IsValid(); // 0x00000001844AD2A0-0x00000001844AD2B0
	}

	[NativeHeader("Modules/HGGraphics/Public/GpuCloth/GpuClothManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGpuClothManager()", StaticAccessorType.Dot)]
	public static class HGGpuClothManagerV2 // TypeDefIndex: 87767
	{
		// Methods
		public static void SetupGpuClothManager(Mesh defaultCapsuleMesh); // 0x0000000185B9E8C0-0x0000000185B9E900
		public static void SetWindDirection(Vector3 direction); // 0x000000018783B22C-0x000000018783B23C
		public static void SetPlayerCenter(Vector3 playerCenter); // 0x000000018783B23C-0x000000018783B24C
		public static void UpdateCharacterPositions(List<Vector3> positions); // 0x0000000185679C80-0x0000000185679D80
		public static unsafe void UpdateCharacterPositions(Vector3* positionPtr, int count); // 0x0000000185679ED0-0x0000000185679F20
		public static bool IsClothSkeletonValid(); // 0x000000018D523350-0x000000018D52337C
		public static bool IsClothSkeletonFlipped(); // 0x000000018D523324-0x000000018D523350
		public static bool ShouldStep(); // 0x000000018D52337C-0x000000018D5233A8
		public static GpuClothClearBufferDataCPP GetClearBufferData_CSharpWrapper(); // 0x000000018D523160-0x000000018D523184
		public static GpuClothGroupUploadDataCPP GetUploadData_CSharpWrapper(); // 0x000000018D5232F4-0x000000018D523324
		public static GpuClothRenderDataCPP GetRenderData_CSharpWrapper(); // 0x000000018D523268-0x000000018D523294
		public static uint GetSkeletonBufferID(); // 0x000000018D523294-0x000000018D5232C0
		public static uint GetClothNodeBufferID(); // 0x000000018D523208-0x000000018D523234
		public static uint GetClothMetaDataBufferID(); // 0x000000018D5231DC-0x000000018D523208
		public static uint GetClothBatchMetaDataBufferID(); // 0x000000018D5231B0-0x000000018D5231DC
		public static uint GetClothBatchCacheMapBufferID(); // 0x000000018D523184-0x000000018D5231B0
		private static void SetWindDirection_Injected(ref Vector3 direction); // 0x0000000186245990-0x00000001862459D0
		private static void SetPlayerCenter_Injected(ref Vector3 playerCenter); // 0x00000001862459D0-0x0000000186245A10
		private static void GetClearBufferData_CSharpWrapper_Injected(out GpuClothClearBufferDataCPP ret); // 0x000000018D52312C-0x000000018D523160
		private static void GetUploadData_CSharpWrapper_Injected(out GpuClothGroupUploadDataCPP ret); // 0x000000018D5232C0-0x000000018D5232F4
		private static void GetRenderData_CSharpWrapper_Injected(out GpuClothRenderDataCPP ret); // 0x000000018D523234-0x000000018D523268
	}

	[UsedByNativeCode]
	public struct ScreenEmitStaticTransformInfo // TypeDefIndex: 87768
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector3 scale; // 0x0C
		public Quaternion rotation; // 0x18
	}

	[NativeHeader("Modules/HGGraphics/Public/GPUParticle/HGGPUParticleManager.h")]
	[StaticAccessor("GetHGGPUParticleManager()", StaticAccessorType.Dot)]
	public static class HGGPUParticleRuntimeBindings // TypeDefIndex: 87769
	{
		// Methods
		public static ulong CreateScreenEmitter(HGMaterial bufferWriterMaterial, uint maxEmitCount, HGMaterial computeMaterial, HGMaterial renderMaterial, Mesh mesh, uint maxParticleCount, uint castShadows, uint enabled); // 0x000000018D52300C-0x000000018D52306C
		public static void DestroyScreenEmitter(ulong screenEmitterHandle); // 0x000000018D52306C-0x000000018D5230A0
		public static ulong CreateScreenEmitStaticRenderable(ulong screenEmitterHandle, Mesh mesh, uint subMeshIdx, ScreenEmitStaticTransformInfo transformInfo); // 0x000000018D522FF4-0x000000018D52300C
		public static ulong CreateScreenEmitSkinnedRenderable(ulong screenEmitterHandle, SkinnedMeshRenderer renderer, uint subMeshIdx); // 0x000000018D522F3C-0x000000018D522F90
		public static void UpdateScreenEmitStaticRenderableTransform(ulong renderableHandle, ScreenEmitStaticTransformInfo transformInfo); // 0x000000018D5230E4-0x000000018D5230F8
		private static ulong CreateScreenEmitStaticRenderable_Injected(ulong screenEmitterHandle, Mesh mesh, uint subMeshIdx, ref ScreenEmitStaticTransformInfo transformInfo); // 0x000000018D522F90-0x000000018D522FF4
		private static void UpdateScreenEmitStaticRenderableTransform_Injected(ulong renderableHandle, ref ScreenEmitStaticTransformInfo transformInfo); // 0x000000018D5230A0-0x000000018D5230E4
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGLODSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetLODStateSystem()", StaticAccessorType.Dot)]
	public static class HGLODStateSystem // TypeDefIndex: 87770
	{
		// Methods
		public static bool IsCurrFrameTriggerTransition(); // 0x0000000185477EB0-0x0000000185477EF0
		public static float GetLODTransitionFraction(); // 0x0000000185576D70-0x0000000185576DB0
		public static float GetLODTransitionTime(); // 0x00000001860581C0-0x0000000186058200
		public static void SetLODTransitionTime(float lodTransitionTime); // 0x0000000186B92480-0x0000000186B924D0
	}

	[Flags]
	public enum LODStreamingStatus : byte // TypeDefIndex: 87771
	{
		Idle = 0,
		Loading = 1,
		Unloading = 2,
		Disabled = 4
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGLODStreamingSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetLODStreamingSystem()", StaticAccessorType.Dot)]
	public static class HGLODStreamingSystem // TypeDefIndex: 87772
	{
		// Properties
		public static bool enableLODStreaming { [NativeName("GetEnableLODStreaming")] get; [NativeName("SetEnableLODStreaming")] set; } // 0x000000018716D670-0x000000018716D6B0 0x00000001871DE530-0x00000001871DE570
		public static bool enableLODStreamingKeepLastLODResource { [NativeName("SetEnableLODStreamingKeepLastLODResource")] set; } // 0x0000000185577B80-0x0000000185577BC0
		public static LODCrossFadeConfig lodConfig { [NativeName("SetLODConfig")] set; } // 0x00000001878369C4-0x00000001878369D4
		public static uint hlodUnloadSubSceneMask { [NativeName("SetHLODUnloadSubSceneMask")] set; } // 0x0000000184F70510-0x0000000184F70560
		public static float lodStreamingLoadDirtyDistance { [NativeName("SetLODStreamingLoadDirtyDistance")] set; } // 0x0000000185577BC0-0x0000000185577C10
		public static float lodStreamingUnloadDirtyDistance { [NativeName("SetLODStreamingUnloadDirtyDistance")] set; } // 0x0000000185577C10-0x0000000185577C60
	
		// Methods
		public static void SetArtTagLODStreamingOffset(uint artTag, int lodStreamingOffset); // 0x0000000185475E90-0x0000000185475EE0
		public static void SetHLODUnloadDistance(int hlodLevel, float unloadDistance); // 0x0000000185577A30-0x0000000185577A80
		public static LODStreamingStatus QueryLODStreamingStatus(); // 0x000000018D523B54-0x000000018D523B80
		private static void set_lodConfig_Injected(ref LODCrossFadeConfig value); // 0x00000001862AD6E0-0x00000001862AD720
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGShadingStateSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetShadingStateSystem()", StaticAccessorType.Dot)]
	public static class HGShadingStateSystem // TypeDefIndex: 87773
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<int, bool> shadingStateChanged; // 0x00
	
		// Events
		public static event UnityAction<int, bool> shadingStateChanged {
			add; // 0x0000000186CB7440-0x0000000186CB74E0
			remove; // 0x0000000186CB74E0-0x0000000186CB7580
		}
	
		// Methods
		public static uint GetMaterialHandle(int instanceId); // 0x00000001861142C0-0x0000000186114300
		public static Material GetMaterial(uint handle); // 0x000000018D5248D4-0x000000018D524908
		[RequiredByNativeCode]
		private static void Internal_OnShadingStateChanged(int instanceId, bool state); // 0x000000018D524908-0x000000018D524968
		public static void FlushAllMaterialCallbacks(); // 0x0000000186CB7400-0x0000000186CB7440
		public static void SetupGpuSceneUploadCs(ComputeShader cs); // 0x0000000185B9E7C0-0x0000000185B9E800
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGGeometrySystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGeometrySystem()", StaticAccessorType.Dot)]
	public static class HGGeometrySystem // TypeDefIndex: 87774
	{
		// Methods
		public static uint GetGeometryHandle(int instanceId); // 0x000000018D5230F8-0x000000018D52312C
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGGeometrySystem.h")]
	[StaticAccessor("HyperGryph::GetMeshBufferAllocator()", StaticAccessorType.Arrow)]
	public static class HGMeshBufferAllocator // TypeDefIndex: 87775
	{
		// Methods
		public static void GarbageCollect(); // 0x00000001872220F0-0x0000000187222130
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGGeometryJobRendererUtils.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGCullingSystem.h")]
	[NativeHeader("Runtime/GfxDevice/hg/HGTempBuffer.h")]
	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGVATBLASManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGRendererSystem.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceSetup.h")]
	public static class HGGraphicsUtils // TypeDefIndex: 87776
	{
		// Properties
		public static bool enableRayTracing { [FreeFunction("GetEnableRayTracing")] get; [FreeFunction("SetEnableRayTracing")] set; } // 0x0000000186E4C640-0x0000000186E4C680 0x0000000185472560-0x00000001854725A0
		public static bool enableRayTracingRender { [FreeFunction("GetEnableRayTracingRender")] get; [FreeFunction("SetEnableRayTracingRender")] set; } // 0x00000001862B8180-0x00000001862B81C0 0x0000000185472520-0x0000000185472560
		public static bool enableFactoryRayTracing { [FreeFunction("HyperGryph::GetEnableFactoryRayTracing")] get; } // 0x000000018561C9F0-0x000000018561CA30 
		public static bool enableECSRenderer { [FreeFunction("GetEnableECSRenderer")] get; } // 0x000000018D5235A8-0x000000018D5235D4 
		public static bool enableHGNewGraphicsAPI { [FreeFunction("GetEnableHGNewGraphicsAPI")] get; } // 0x000000018D5235D4-0x000000018D523600 
		public static bool enableCppRenderPath { [FreeFunction("GetEnableCppRenderPath")] get; } // 0x00000001862B7380-0x00000001862B73C0 
		public static int maxAnisoLevel { [FreeFunction("GetHGMaxAnisoLevel")] get; [FreeFunction("SetHGMaxAnisoLevel")] set; } // 0x000000018D523600-0x000000018D52362C 0x000000018716C4C0-0x000000018716C500
		public static bool enableRenderingCommandBufferDirectCall { [FreeFunction("SetEnableRenderingCommandBufferDirectCall")] set; } // 0x0000000186245950-0x0000000186245990
		public static double gpuDuration { [FreeFunction("HGGetGpuDuration")] get; } // 0x00000001856F6B90-0x00000001856F6BD0 
	
		// Methods
		[FreeFunction("HGAllocateTempVertexBuffer")]
		public static CBHandle HGAllocateTempVertexBuffer(int size); // 0x000000018D523544-0x000000018D523574
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint AllocateTempCompoundRendererListFromScript(ref IntPtr outPtr); // 0x000000018D5233A8-0x000000018D5233DC
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static bool IsCompoundRendererListDrawable(uint id); // 0x000000018D523574-0x000000018D5235A8
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static void PrepareGeometryJobRenderersForRendering(); // 0x00000001862B81C0-0x00000001862B8200
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint CreateMetalFXSpatialScaler(int inputWidth, int inputWeight, int outputWidth, int outputHeight, GraphicsFormat colorTextureFormat, GraphicsFormat outputTextureFormat); // 0x000000018D5233DC-0x000000018D52343C
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static void DestroyMetalFXSpatialScaler(uint spatialScalerHandle); // 0x000000018D52349C-0x000000018D5234D0
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint CreateMetalFXTemporalScaler(int inputWidth, int inputWeight, int outputWidth, int outputHeight, GraphicsFormat colorTextureFormat, GraphicsFormat depthTextureFormat, GraphicsFormat motionTextureFormat, GraphicsFormat outputTextureFormat); // 0x000000018D52343C-0x000000018D52349C
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static void DestroyMetalFXTemporalScaler(uint temporalScalerHandle); // 0x000000018D5234D0-0x000000018D523504
		private static void HGAllocateTempVertexBuffer_Injected(int size, out CBHandle ret); // 0x000000018D523504-0x000000018D523544
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGRendererSystem.h")]
	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
	public static class HGRendererSystem // TypeDefIndex: 87777
	{
		// Properties
		public static Vector3 PerRendererLightingFallbackPosition { set; } // 0x000000018D5245F0-0x000000018D524600
		public static uint MaxPerRendererLightingCount { get; } // 0x000000018D52455C-0x000000018D524588 
		public static uint CSMStopRenderCharacterCascadeLevel { set; } // 0x000000018D524588-0x000000018D5245BC
	
		// Methods
		private static void set_PerRendererLightingFallbackPosition_Injected(ref Vector3 value); // 0x000000018D5245BC-0x000000018D5245F0
	}

	[NativeHeader("Modules/HGGraphics/Public/HGLightManager.h")]
	[NativeType("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetHGLightManager()", StaticAccessorType.Dot)]
	public static class HGLightSystem // TypeDefIndex: 87778
	{
		// Methods
		public static Entity GetSunSourceLightEntity(); // 0x0000000186170130-0x0000000186170180
		public static Light GetSunSourceMonoLight(); // 0x00000001851B54A0-0x00000001851B54E0
		public static bool IsSunSourceLightEntity(Entity entity); // 0x000000018D523BB4-0x000000018D523BD0
		public static void ApplySunSourceLightEnvironmentData(UnityEngine.Color color, float intensity, float specularIntensity, float softSourceRadius, Matrix4x4 localToWorld); // 0x0000000187834FD8-0x0000000187834FFC
		private static void GetSunSourceLightEntity_Injected(out Entity ret); // 0x0000000186170180-0x00000001861701C0
		private static bool IsSunSourceLightEntity_Injected(ref Entity entity); // 0x000000018D523B80-0x000000018D523BB4
		private static void ApplySunSourceLightEnvironmentData_Injected(ref UnityEngine.Color color, float intensity, float specularIntensity, float softSourceRadius, ref Matrix4x4 localToWorld); // 0x000000018611C0E0-0x000000018611C160
	}

	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[StaticAccessor("GetHGGlobalGameManager()", StaticAccessorType.Dot)]
	public static class HGLogicTimeManager // TypeDefIndex: 87779
	{
		// Methods
		public static void SetLogicTickDeltaTime(float deltaTime); // 0x00000001857B4940-0x00000001857B4990
		public static void SetLogicTickDeltaTimeNoScale(float deltaTime); // 0x00000001857B4990-0x00000001857B49E0
		public static void SetHgrpDeltaTime(float deltaTime); // 0x0000000185FBE330-0x0000000185FBE380
	}

	[NativeType("Modules/HGGraphics/Public/Foliage/HGGrassCPURender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGrassRender().GetGrassCPURender()", StaticAccessorType.Dot)]
	public static class HGGrassCPURender // TypeDefIndex: 87780
	{
		// Methods
		public static bool IsInGrassBounds(Vector3 worldPos, out Bounds overlapBounds, out Bounds originBounds, out uint argTag); // 0x0000000187834570-0x0000000187834588
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018D5236B0-0x000000018D5236CC
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, bool noAlphaTest = false /* Metadata: 0x02647B52 */); // 0x000000018D52362C-0x000000018D523650
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, uint* drawableFeedbackPtr, bool noAlphaTest); // 0x000000018D523650-0x000000018D5236B0
		private static bool IsInGrassBounds_Injected(ref Vector3 worldPos, out Bounds overlapBounds, out Bounds originBounds, out uint argTag); // 0x000000018600CFE0-0x000000018600D050
	}

	[NativeType("Modules/HGGraphics/Public/Foliage/HGGrassGPURender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGrassRender().GetGrassGPURender()", StaticAccessorType.Dot)]
	public static class HGGrassGPURender // TypeDefIndex: 87781
	{
		// Methods
		private static unsafe void OnGrassEntitiesLoaded(Entity* entities, uint entityCount); // 0x000000018D523704-0x000000018D523744
		private static unsafe void OnGrassEntitiesUnloaded(Entity* entities, uint entityCount); // 0x000000018D52377C-0x000000018D5237BC
		public static void OnGrassEntitiesLoaded(NativeArray<Entity> entities); // 0x000000018D5236CC-0x000000018D523704
		public static void OnGrassEntitiesUnloaded(NativeArray<Entity> entities); // 0x000000018D523744-0x000000018D52377C
	}

	[NativeType("Modules/HGGraphics/Public/Foliage/HGGrassRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGrassRender()", StaticAccessorType.Dot)]
	public static class HGGrassRender // TypeDefIndex: 87782
	{
		// Properties
		public static float grassGlobalSparsity { set; } // 0x0000000186BFB7A0-0x0000000186BFB7F0
		public static bool enableGPUDrivenGrassRender { set; } // 0x0000000186BFB610-0x0000000186BFB650
	
		// Methods
		public static uint RegisterGrassBatchGroup(uint batchGroupKey, Material material, Mesh mesh, ushort subMeshIndex); // 0x000000018D5237BC-0x000000018D523820
		public static void UnregisterGrassBatchGroupWithHandle(uint batchGroupKey, uint batchGroupHandle); // 0x000000018D523820-0x000000018D523860
	}

	public enum EInteractionProxyType : uint // TypeDefIndex: 87783
	{
		Sphere = 0,
		Capsule = 1,
		Texture = 2,
		Mesh = 3
	}

	public enum EInteractionDeformType // TypeDefIndex: 87784
	{
		Terrain = 0,
		ObjectSnow = 1,
		ObjectNonSnow = 2
	}

	[UsedByNativeCode]
	public struct HGInteractionNodeV2 // TypeDefIndex: 87785
	{
		// Fields
		public int m_nodeKey; // 0x00
		public EInteractionProxyType m_proxyType; // 0x04
		public Matrix4x4 m_localToWorldMatrix; // 0x08
		public Matrix4x4 m_prevLocalToWorldMatrix; // 0x48
		public float m_groundHeight; // 0x88
		public Vector3 m_groundNormal; // 0x8C
		public EInteractionDeformType m_deformType; // 0x98
		public bool m_bUseCCD; // 0x9C
		public float m_length; // 0xA0
		public float m_radius; // 0xA4
		public float m_interactLength; // 0xA8
		public float m_interactHeight; // 0xAC
		public int m_texture; // 0xB0
		public Vector2 m_extent; // 0xB4
		public float m_heightScale; // 0xBC
		public int m_mesh; // 0xC0
	}

	[UsedByNativeCode]
	public struct HGDecalInteractionParametersV2 // TypeDefIndex: 87786
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

	[NativeHeader("Modules/HGGraphics/Public/Interaction/HGDecalInteraction.h")]
	[NativeHeader("Modules/HGGraphics/Public/Interaction/HGInteractionManager.h")]
	public static class HGInteractionManagerV2 // TypeDefIndex: 87787
	{
		// Methods
		public static void UpdateFromNodes(NativeArray<HGInteractionNodeV2> nodes, int nodeCount, bool bUpdateMobile); // 0x0000000185476DA0-0x0000000185476E00
		[StaticAccessor("GetHGGlobalGameManager().GetInteractionManager()", StaticAccessorType.Dot)]
		public static void UpdateFromNodes(IntPtr nodeData, int nodeCount, bool bUpdateMobile); // 0x0000000185476E00-0x0000000185476E60
		[StaticAccessor("GetHGGlobalGameManager().GetInteractionManager()", StaticAccessorType.Dot)]
		public static void UpdateSettingParameters(HGDecalInteractionParametersV2 settingParameters); // 0x00000001878363FC-0x000000018783640C
		private static void UpdateSettingParameters_Injected(ref HGDecalInteractionParametersV2 settingParameters); // 0x0000000186245BB0-0x0000000186245BF0
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumeConfig // TypeDefIndex: 87799
	{
		// Fields
		public uint enableLowQualityMode; // 0x00
		public int indirectionTextureSize; // 0x04
		public uint blockCountX; // 0x08
		public uint blockCountY; // 0x0C
		public uint blockCountZ; // 0x10
		public uint hashTableSize; // 0x14
		public unsafe fixed /* 0x00000000-0x00000000 */ int perLOD[0]; // 0x18
		public unsafe fixed /* 0x00000000-0x00000000 */ int perHalfChunkCounts[0]; // 0x24
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perHashTableOffsets[0]; // 0x30
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perHashTableSizes[0]; // 0x3C
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perPhysicalTextureOffsets[0]; // 0x48
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perPhysicalTextureBlockCounts[0]; // 0x54
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perFrameMaxLoadingByteCount[0]; // 0x60
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perFrameMaxUploadChunkCount[0]; // 0x6C
		public uint perFrameMaxLoadingByteCountV3; // 0x78
		public uint perFrameMaxUploadChunkCountV3; // 0x7C
		public uint maxHashTableSize; // 0x80
		public uint maxInactiveFrameCount; // 0x84
		public unsafe fixed /* 0x00000000-0x00000000 */ int ClipmapTextureSize[0]; // 0x88
		public unsafe fixed /* 0x00000000-0x00000000 */ uint blockSizesV3[0]; // 0x94
		public unsafe fixed /* 0x00000000-0x00000000 */ float cameraForwardBiasForYAxis[0]; // 0xA0
		public uint maxRegionCount; // 0xAC
		public int regionAtlasSizeX; // 0xB0
		public int regionAtlasSizeY; // 0xB4
		public int regionAtlasSizeZ; // 0xB8
		public uint enableLowMemoryMode; // 0xBC
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perLOD_e__FixedBuffer // TypeDefIndex: 87788
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHalfChunkCounts_e__FixedBuffer // TypeDefIndex: 87789
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHashTableOffsets_e__FixedBuffer // TypeDefIndex: 87790
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHashTableSizes_e__FixedBuffer // TypeDefIndex: 87791
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perPhysicalTextureOffsets_e__FixedBuffer // TypeDefIndex: 87792
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perPhysicalTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 87793
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perFrameMaxLoadingByteCount_e__FixedBuffer // TypeDefIndex: 87794
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perFrameMaxUploadChunkCount_e__FixedBuffer // TypeDefIndex: 87795
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _ClipmapTextureSize_e__FixedBuffer // TypeDefIndex: 87796
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _blockSizesV3_e__FixedBuffer // TypeDefIndex: 87797
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _cameraForwardBiasForYAxis_e__FixedBuffer // TypeDefIndex: 87798
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumePipelineUpdateResult // TypeDefIndex: 87800
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

	[NativeHeader("Modules/HGGraphics/Public/IV/HGIrradianceVolume.h")]
	public class HGIrradianceVolume // TypeDefIndex: 87801
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static long Create([IsReadOnly] in HGIrradianceVolumeConfig config); // 0x0000000185EAB550-0x0000000185EAB590
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void Destroy(long id); // 0x0000000187183CF0-0x0000000187183D30
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetEnableV3(bool enable); // 0x0000000186245850-0x0000000186245890
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void EnableBurstMode(); // 0x00000001857CCE50-0x00000001857CCE90
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void DisableBurstMode(); // 0x00000001857CCE10-0x00000001857CCE50
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetSceneStateNames(string[] stateNames, string[] activateStates); // 0x0000000185DEDA80-0x0000000185DEDAD0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateNames(string[] activateNames); // 0x000000018D523A74-0x000000018D523AA8
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateMask(uint mask); // 0x0000000185C70890-0x0000000185C708D0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static string[] GetActiveSceneStateNames(); // 0x0000000185DEDA40-0x0000000185DEDA80
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetMapV3(long id, string path); // 0x000000018716D1B0-0x000000018716D200
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void StreamingInCabin(long id, string slotId, uint roomTypeId); // 0x000000018D523ABC-0x000000018D523B10
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void StreamingOutCabin(long id, string slotId); // 0x000000018D523B10-0x000000018D523B54
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetStreamingCenter(long id, Vector3 center); // 0x000000018D523AA8-0x000000018D523ABC
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResult result, long id, IntPtr renderContext, CommandBuffer cmd, int bakeCS, int updateIndirectionCS); // 0x00000001860F40F0-0x00000001860F4160
		private static void SetStreamingCenter_Injected(long id, ref Vector3 center); // 0x00000001861D84A0-0x00000001861D84F0
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumeConfigV2 // TypeDefIndex: 87821
	{
		// Fields
		public uint enableLowQualityMode; // 0x00
		public int clipMapTextureSizeX; // 0x04
		public int clipMapTextureSizeY; // 0x08
		public int clipMapTextureSizeZ; // 0x0C
		public unsafe fixed /* 0x00000000-0x00000000 */ uint basisBaseGridDim[0]; // 0x10
		public unsafe fixed /* 0x00000000-0x00000000 */ uint basisVoxelDataDim[0]; // 0x28
		public uint coeffBaseGridDim; // 0x40
		public uint coeffVoxelDataDim; // 0x44
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perCoeffLodBudget[0]; // 0x48
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perBasisLodBudget[0]; // 0x54
		public uint lod3BaseGridDim; // 0x60
		public uint lod3VoxelDataDim; // 0x64
		public uint lod3Budget; // 0x68
		public uint rawDataSize; // 0x6C
		public uint modelBufferBudget; // 0x70
		public unsafe fixed /* 0x00000000-0x00000000 */ int perLOD[0]; // 0x74
		public unsafe fixed /* 0x00000000-0x00000000 */ int perHalfStreamingChunkCountsX[0]; // 0x80
		public unsafe fixed /* 0x00000000-0x00000000 */ int perHalfStreamingChunkCountsY[0]; // 0x8C
		public unsafe fixed /* 0x00000000-0x00000000 */ int perHalfStreamingChunkCountsZ[0]; // 0x98
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perRawBufferOffsets[0]; // 0xA4
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perRawBufferCounts[0]; // 0xB0
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perBlockInfoBufferOffsets[0]; // 0xBC
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perBlockInfoSize[0]; // 0xC8
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perBasisTextureOffset[0]; // 0xD4
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perBasisTextureBlockCounts[0]; // 0xE0
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perCoeffTextureOffset[0]; // 0xEC
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perCoeffTextureBlockCounts[0]; // 0xF8
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perFrameMaxLoadingByteCount[0]; // 0x104
		public unsafe fixed /* 0x00000000-0x00000000 */ uint perFrameMaxUploadChunkCount[0]; // 0x110
		public uint maxRegionCount; // 0x11C
		public uint regionAtlasSizeX; // 0x120
		public uint regionAtlasSizeY; // 0x124
		public uint regionAtlasSizeZ; // 0x128
		public unsafe fixed /* 0x00000000-0x00000000 */ float streamingCenterBias[0]; // 0x12C
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _basisBaseGridDim_e__FixedBuffer // TypeDefIndex: 87802
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _basisVoxelDataDim_e__FixedBuffer // TypeDefIndex: 87803
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perCoeffLodBudget_e__FixedBuffer // TypeDefIndex: 87804
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBasisLodBudget_e__FixedBuffer // TypeDefIndex: 87805
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perLOD_e__FixedBuffer // TypeDefIndex: 87806
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHalfStreamingChunkCountsX_e__FixedBuffer // TypeDefIndex: 87807
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHalfStreamingChunkCountsY_e__FixedBuffer // TypeDefIndex: 87808
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHalfStreamingChunkCountsZ_e__FixedBuffer // TypeDefIndex: 87809
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perRawBufferOffsets_e__FixedBuffer // TypeDefIndex: 87810
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perRawBufferCounts_e__FixedBuffer // TypeDefIndex: 87811
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBlockInfoBufferOffsets_e__FixedBuffer // TypeDefIndex: 87812
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBlockInfoSize_e__FixedBuffer // TypeDefIndex: 87813
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBasisTextureOffset_e__FixedBuffer // TypeDefIndex: 87814
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBasisTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 87815
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perCoeffTextureOffset_e__FixedBuffer // TypeDefIndex: 87816
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perCoeffTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 87817
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perFrameMaxLoadingByteCount_e__FixedBuffer // TypeDefIndex: 87818
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perFrameMaxUploadChunkCount_e__FixedBuffer // TypeDefIndex: 87819
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _streamingCenterBias_e__FixedBuffer // TypeDefIndex: 87820
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumePipelineUpdateResultV2 // TypeDefIndex: 87822
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

	[NativeHeader("Modules/HGGraphics/Public/IV/HGIrradianceVolumeV2.h")]
	public class HGIrradianceVolumeV2 // TypeDefIndex: 87823
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static long Create([IsReadOnly] in HGIrradianceVolumeConfigV2 config); // 0x0000000187217FA0-0x0000000187217FE0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void Destroy(long id); // 0x000000018D523860-0x000000018D523894
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetSceneStateNames(string[] stateNames, string[] activateStates); // 0x0000000185DEDB80-0x0000000185DEDBD0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateNames(string[] activateStates); // 0x000000018D5238F8-0x000000018D52392C
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateMask(uint mask); // 0x0000000185C70910-0x0000000185C70950
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static string[] GetActiveSceneStateNames(); // 0x0000000185DEDB40-0x0000000185DEDB80
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetMap(long id, string path); // 0x00000001871CB1E0-0x00000001871CB230
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetStreamingCenter(long id, Vector3 center); // 0x000000018D5239C8-0x000000018D5239DC
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetCameraForwardDirection(long id, Vector3 cameraForwardDir); // 0x000000018D523970-0x000000018D523984
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResultV2 result, long id, IntPtr renderContext, CommandBuffer cmd, int bakeCS, int updateClipmapCS); // 0x000000018D523894-0x000000018D5238F8
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void StreamingInCabin(long id, long slotId, uint roomTypeId); // 0x000000018D5239DC-0x000000018D523A30
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void StreamingOutCabin(long id, long slotId); // 0x000000018D523A30-0x000000018D523A74
		private static void SetStreamingCenter_Injected(long id, ref Vector3 center); // 0x000000018D523984-0x000000018D5239C8
		private static void SetCameraForwardDirection_Injected(long id, ref Vector3 cameraForwardDir); // 0x000000018D52392C-0x000000018D523970
	}

	public struct HGLensFlareStreamingKeyframe // TypeDefIndex: 87824
	{
		// Fields
		public float time; // 0x00
		public float value; // 0x04
		public float inTangent; // 0x08
		public float outTangent; // 0x0C
		public WeightedMode weightedMode; // 0x10
		public float inWeight; // 0x14
		public float outWeight; // 0x18
	}

	public struct HGLensFlareStreamingSourcePayload // TypeDefIndex: 87825
	{
		// Fields
		public int flags; // 0x00
		public float intensity; // 0x04
		public float maxAttenuationDistance; // 0x08
		public float maxAttenuationScale; // 0x0C
		public int attenuationByLightShape; // 0x10
		public int useOcclusion; // 0x14
		public float occlusionRadius; // 0x18
		public int sampleCount; // 0x1C
		public float occlusionOffset; // 0x20
		public float scale; // 0x24
		public int allowOffScreen; // 0x28
		public int useCustomForward; // 0x2C
		public Vector3 customForward; // 0x30
		public Vector3 positionWS; // 0x3C
		public Vector3 forwardWS; // 0x48
	}

	public struct HGLensFlareStreamingCurvePayload // TypeDefIndex: 87826
	{
		// Fields
		public IntPtr radialScreenAttenuationKeys; // 0x00
		public int radialScreenAttenuationKeyCount; // 0x08
		public int radialScreenAttenuationPreWrapMode; // 0x0C
		public int radialScreenAttenuationPostWrapMode; // 0x10
		public int padding0; // 0x14
		public IntPtr distanceAttenuationKeys; // 0x18
		public int distanceAttenuationKeyCount; // 0x20
		public int distanceAttenuationPreWrapMode; // 0x24
		public int distanceAttenuationPostWrapMode; // 0x28
		public int padding1; // 0x2C
		public IntPtr scaleByDistanceKeys; // 0x30
		public int scaleByDistanceKeyCount; // 0x38
		public int scaleByDistancePreWrapMode; // 0x3C
		public int scaleByDistancePostWrapMode; // 0x40
		public int padding2; // 0x44
	}

	public static class HGLensFlareStreamingBridge // TypeDefIndex: 87829
	{
		// Fields
		public static RegisterStreamingSourceCallback registerStreamingSourceCallback; // 0x00
		public static UnregisterStreamingSourceCallback unregisterStreamingSourceCallback; // 0x08
	
		// Nested types
		public delegate void RegisterStreamingSourceCallback(Entity entity, ScriptableObject lensFlareData, HGLensFlareStreamingSourcePayload payload, AnimationCurve radialScreenAttenuationCurve, AnimationCurve distanceAttenuationCurve, AnimationCurve scaleByDistanceCurve); // TypeDefIndex: 87827; 0x0000000184901480-0x0000000184901510
	
		public delegate void UnregisterStreamingSourceCallback(Entity entity); // TypeDefIndex: 87828; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Methods
		[RequiredByNativeCode]
		public static void RegisterStreamingSource(Entity entity, ScriptableObject lensFlareData, HGLensFlareStreamingSourcePayload payload, HGLensFlareStreamingCurvePayload curvePayload); // 0x0000000186BA6460-0x0000000186BA6760
		[RequiredByNativeCode]
		public static void UnregisterStreamingSource(Entity entity); // 0x000000018650E2C0-0x000000018650E3E0
		private static AnimationCurve CreateCurve(IntPtr keyframePtr, int keyframeCount, int preWrapMode, int postWrapMode); // 0x0000000186BA6760-0x0000000186BA69A0
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGMeshRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetMeshRender()", StaticAccessorType.Dot)]
	public static class HGMeshRender // TypeDefIndex: 87830
	{
		// Methods
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalKeywords, IntPtr context, bool multiDraw, bool transparentSorting, uint cullingLayerMask, bool noAlphaTest, uint* drawableFeedbackPtr, bool excludeGPUDriven); // 0x000000018D523F44-0x000000018D523FB8
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, bool excludeGPUDriven); // 0x000000018D523DD0-0x000000018D523E30
		private static uint CreateRendererListWithCharacterIndex(uint viewHandle, ushort characterIndex, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalHGKeywords, IntPtr context); // 0x000000018D523D48-0x000000018D523DB4
		private static unsafe uint CreateRendererListFromEntities(Entity* entities, uint entityCount, Vector3 cameraPosition, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalHGKeywords, IntPtr context, uint cullingLayerMask); // 0x000000018D523CF4-0x000000018D523D48
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, bool multiDraw = false /* Metadata: 0x02647B5A */, bool transparentSorting = false /* Metadata: 0x02647B5B */, uint cullingLayerMask = 4294967295 /* Metadata: 0x02647B5C */, bool noAlphaTest = false /* Metadata: 0x02647B5D */, bool excludeGPUDriven = false /* Metadata: 0x02647B5E */); // 0x000000018D523E58-0x000000018D523ECC
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, IntPtr drawableFeedbackPtr, bool multiDraw = false /* Metadata: 0x02647B5F */, bool transparentSorting = false /* Metadata: 0x02647B60 */, uint cullingLayerMask = 4294967295 /* Metadata: 0x02647B61 */, bool noAlphaTest = false /* Metadata: 0x02647B62 */, bool excludeGPUDriven = false /* Metadata: 0x02647B63 */); // 0x000000018D523ECC-0x000000018D523F44
		public static uint CreateRendererListWithCharacterIndex(uint viewHandle, ushort characterIndex, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context); // 0x000000018D523DB4-0x000000018D523DD0
		public static uint CreateRendererListFromEntities(NativeArray<Entity> entities, Vector3 cameraPosition, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, uint cullingLayerMask = 4294967295 /* Metadata: 0x02647B64 */); // 0x000000018D523C40-0x000000018D523CF4
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, out uint normalList, out uint preZPart0List, out uint preZPart1List, bool excludeGPUDriven = false /* Metadata: 0x02647B65 */); // 0x000000018D523E30-0x000000018D523E58
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018D523FE4-0x000000018D524000
		public static void DrawECSMeshRendererListWithSRPRendererList(CommandBuffer cmd, uint ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList); // 0x000000018D523FB8-0x000000018D523FE4
		private static unsafe uint CreateRendererListFromEntities_Injected(Entity* entities, uint entityCount, ref Vector3 cameraPosition, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalHGKeywords, IntPtr context, uint cullingLayerMask); // 0x000000018D523BD0-0x000000018D523C40
	}

	[NativeType("Modules/HGGraphics/Public/RayTracing/HGRayTracingScene.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetRayTracingScene()", StaticAccessorType.Dot)]
	public static class HGRayTracingScene // TypeDefIndex: 87831
	{
		// Methods
		public static uint AddCullViewHandle(ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, LODCrossFadeConfig config, float viewScreenSizeMinSquared, float cullingRadius); // 0x000000018D52435C-0x000000018D524398
		public static uint PrepareTLASCreationForCullView(uint viewHandle); // 0x000000018D524398-0x000000018D5243CC
		public static void SetupGpuSceneUploadCs(ComputeShader cs); // 0x0000000185B9E800-0x0000000185B9E840
		private static uint AddCullViewHandle_Injected(ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, ref LODCrossFadeConfig config, float viewScreenSizeMinSquared, float cullingRadius); // 0x000000018D5242FC-0x000000018D52435C
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGReflectionProbeSystem.h")]
	public class HGReflectionProbe // TypeDefIndex: 87832
	{
		// Properties
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()")]
		public static float cameraMovementNotFadeness { get; } // 0x000000018D524530-0x000000018D52455C 
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()")]
		public static float fadeTime { get; } // 0x00000001862B8140-0x00000001862B8180 
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static uint AddView(Camera camera); // 0x00000001871904B0-0x00000001871904F0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void RemoveView(uint viewHandle); // 0x00000001871EC0A0-0x00000001871EC0E0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void ResetView(uint viewHandle); // 0x0000000187190470-0x00000001871904B0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewPhase0(uint viewHandle, Vector3 cameraPosition, Vector3 visibleBox, bool loadSync = false /* Metadata: 0x02647B66 */); // 0x0000000187834FB0-0x0000000187834FC8
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewPhase1(uint viewHandle, float dt, bool enableFadeness, IntPtr blitList, int maxBlitCount, out int blitCount); // 0x000000018D5244D0-0x000000018D524530
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewCBHandle(uint viewHandle, Matrix4x4 worldToCameraMatrix, Matrix4x4 unitExtents, IntPtr binningBufferPtr, IntPtr globalBufferPtr); // 0x000000018D5244AC-0x000000018D5244D0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static Texture GetTexture(uint viewHandle, ulong hash); // 0x000000018D52440C-0x000000018D52444C
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static int GetTextureIndex(uint viewHandle, ulong hash); // 0x000000018D5243CC-0x000000018D52440C
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void SetViewTextureArrayCount(uint viewHandle, int count); // 0x000000018716D110-0x000000018716D160
		private static void UpdateViewPhase0_Injected(uint viewHandle, ref Vector3 cameraPosition, ref Vector3 visibleBox, bool loadSync = false /* Metadata: 0x02647B67 */); // 0x0000000186158460-0x00000001861584D0
		private static void UpdateViewCBHandle_Injected(uint viewHandle, ref Matrix4x4 worldToCameraMatrix, ref Matrix4x4 unitExtents, IntPtr binningBufferPtr, IntPtr globalBufferPtr); // 0x000000018D52444C-0x000000018D5244AC
	}

	public enum AssetType // TypeDefIndex: 87833
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
		HGMaterial = 11,
		HGShader = 12,
		Count = 13
	}

	public enum AssetPriority : ushort // TypeDefIndex: 87834
	{
		Preload = 0,
		LODStreaming = 5,
		Default = 10,
		Streaming = 15
	}

	public enum AssetState : byte // TypeDefIndex: 87835
	{
		Loading = 0,
		Loaded = 1,
		Failed = 2
	}

	public struct VFSBlockFileInfo // TypeDefIndex: 87836
	{
		// Fields
		public ulong offset; // 0x00
		public ulong len; // 0x08
		public string chunkFilePath; // 0x10
	}

	public struct AssetIdentifier // TypeDefIndex: 87837
	{
		// Fields
		public long hash; // 0x00
		public AssetType type; // 0x08
	}

	public struct AssetHandleIndex // TypeDefIndex: 87838
	{
		// Fields
		public uint index; // 0x00
	}

	public struct AssetOperation // TypeDefIndex: 87839
	{
		// Fields
		public bool isLoadOperation; // 0x00
		public AssetPriority priority; // 0x02
		public AssetHandleIndex handleIndex; // 0x04
		public AssetIdentifier identifier; // 0x08
	}

	[NativeHeader("Modules/HGGraphics/Public/HGResourceManager.bindings.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetHGResourceManager()", StaticAccessorType.Dot)]
	public static class HGResourceManager // TypeDefIndex: 87843
	{
		// Fields
		public static GetFileHashMappingCallback getFileHashMappingCallback; // 0x00
		public static GetFilePathMappingCallback getFilePathMappingCallback; // 0x08
		public static GetTextureFromHGWaterSectorDataCallback getWaterSectorTextureCallback; // 0x10
		private static readonly System.Type[] kAssetTypeToUnityType; // 0x18
	
		// Properties
		public static bool usingVFS { [NativeName("SetUsingVFS")] set; } // 0x0000000186242740-0x0000000186242780
		public static IntPtr assetOperations { get; } // 0x0000000186000E80-0x0000000186000EC0 
		public static int assetOperationCount { get; } // 0x0000000186000EC0-0x0000000186000FD0 
	
		// Nested types
		public delegate VFSBlockFileInfo GetFileHashMappingCallback(long originNameHash); // TypeDefIndex: 87840; 0x00000001811D4E00-0x00000001811D4E40
	
		public delegate VFSBlockFileInfo GetFilePathMappingCallback(string originName); // TypeDefIndex: 87841; 0x00000001811D4E00-0x00000001811D4E40
	
		public delegate Texture2D GetTextureFromHGWaterSectorDataCallback(ScriptableObject sectorDataScriptableObject); // TypeDefIndex: 87842; 0x0000000185B78EA0-0x0000000185B78EB0
	
		// Constructors
		static HGResourceManager(); // 0x0000000186C94E90-0x0000000186C951E0
	
		// Methods
		public static AssetHandleIndex LoadAsync(long assetHash, AssetType type, AssetPriority priority); // 0x000000018D5247F8-0x000000018D524870
		public static void UpdateAssetHandle(AssetHandleIndex handleIndex, AssetIdentifier identifier, AssetState state, int assetInstanceID); // 0x0000000185ECCA00-0x0000000185ECCA80
		public static void ClearAssetOperations(); // 0x00000001862B7340-0x00000001862B7380
		public static void Reset(); // 0x00000001862CD640-0x00000001862CD680
		[RequiredByNativeCode]
		public static VFSBlockFileInfo GetFileHashMapping(long originNameHash); // 0x0000000185FD5500-0x0000000185FD5590
		[RequiredByNativeCode]
		public static VFSBlockFileInfo GetFilePathMapping(string originName); // 0x000000018D524694-0x000000018D52472C
		[RequiredByNativeCode]
		public static Texture2D GetTextureFromHGWaterSectorData(ScriptableObject sectorDataScriptableObject); // 0x000000018D52472C-0x000000018D524794
		public static NativeArray<AssetOperation> GetAssetOperationsArray(); // 0x000000018D524600-0x000000018D524694
		private static void LoadAsync_Injected(long assetHash, AssetType type, AssetPriority priority, out AssetHandleIndex ret); // 0x000000018D524794-0x000000018D5247F8
		private static void UpdateAssetHandle_Injected(ref AssetHandleIndex handleIndex, ref AssetIdentifier identifier, AssetState state, int assetInstanceID); // 0x0000000185ECCA80-0x0000000185ECCAF0
	
		// Extension methods
		public static System.Type ToUnityType(this AssetType type); // 0x000000018D524870-0x000000018D5248D4
	}

	[Flags]
	public enum HGRenderFlags : uint // TypeDefIndex: 87844
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
		RayTracing = 134217728,
		OITTransparent = 268435456,
		MaterialTwoSided = 536870912
	}

	[Flags]
	public enum HGRenderKeyword : ushort // TypeDefIndex: 87845
	{
		None = 0,
		CrossFade = 1,
		Dither = 2
	}

	[Flags]
	public enum HGShaderLightMode : uint // TypeDefIndex: 87846
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
		RayTracingReflectionCompute = 8388608,
		RayTracingGI = 16777216,
		StencilAlphaBlend = 33554432,
		WaterMarkUI = 67108864,
		ForwardAfterUI = 134217728,
		TextureStreamingFeedback = 268435456,
		GPUParticleSpawn = 536870912,
		GPUParticleSimulate = 1073741824,
		TreeAnimationCompute = 2147483648
	}

	[Flags]
	public enum HGObjectFlags : uint // TypeDefIndex: 87847
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
		RealtimeShadowCaster = 134217728,
		Character = 268435456
	}

	[Flags]
	public enum HGFactoryDirtyFlags : byte // TypeDefIndex: 87848
	{
		None = 0,
		PerDrawData = 1,
		VATData = 1,
		ObjectData = 2,
		TransformData = 4,
		VFXStatus = 16,
		VFXVisibility = 32
	}

	[UsedByNativeCode]
	public struct IVec2 // TypeDefIndex: 87849
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
	}

	[UsedByNativeCode]
	public struct IVec4 // TypeDefIndex: 87850
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public int w; // 0x0C
	}

	[UsedByNativeCode]
	public struct SludgeNodeData // TypeDefIndex: 87852
	{
		// Fields
		public byte allHole; // 0x00
		public byte treeLevel; // 0x01
		public ushort parent; // 0x02
		public Vector3 aabbCenter; // 0x04
		public Vector3 aabbExtent; // 0x10
		public unsafe fixed /* 0x00000000-0x00000000 */ byte patchAABBData[0]; // 0x1C
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _patchAABBData_e__FixedBuffer // TypeDefIndex: 87851
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct SludgeHeightmapInfo // TypeDefIndex: 87853
	{
		// Fields
		public Vector4 heightmapUVOffsetScale; // 0x00
		public Texture2D heightmapAtlas; // 0x10
	}

	[NativeType("Modules/HGGraphics/Public/Sludge/HGSludgeRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetSludgeRender()", StaticAccessorType.Dot)]
	public static class HGSludgeRender // TypeDefIndex: 87854
	{
		// Methods
		public static bool RegisterSludge(Entity entity, Texture2D bakedHeightmap, NativeArray<SludgeNodeData> nodeData); // 0x0000000186114300-0x0000000186114360
		private static bool RegisterSludge(Entity entity, Texture2D bakedHeightmap, int nodeCount, IntPtr nodeData); // 0x000000018783B7A0-0x000000018783B7C4
		public static void UnregisterAndDestroySludge(Entity entity); // 0x0000000187836C74-0x0000000187836C90
		public static uint CreateRendererList(Camera camera, Vector2Int sceneRTSize, uint viewHandle, HGShaderLightMode lightModeMask, HGShaderLightMode decalLightModeMask, float lodFactor, IntPtr context, bool useMetric = true /* Metadata: 0x02647CA6 */); // 0x000000018D5249CC-0x000000018D5249E8
		private static uint CreateRendererList(Camera camera, Vector2Int sceneRTSize, uint viewHandle, uint lightModeMask, uint decalLightModeMask, float loadFactor, IntPtr context, bool useMetric); // 0x000000018D5249E8-0x000000018D524A3C
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customPros); // 0x000000018D524ADC-0x000000018D524B2C
		public static void DrawECSDecalRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customProps); // 0x000000018D524A8C-0x000000018D524ADC
		public static void DrawECSBlendRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customProps); // 0x000000018D524A3C-0x000000018D524A8C
		public static void HitSludge(Entity entity, Vector3 worldPos, float range, float deltaHeightNormalized = 1f /* Metadata: 0x02647CA7 */); // 0x000000018D524C98-0x000000018D524CBC
		public static SludgeHeightmapInfo GetHeightmapInfo(Entity entity); // 0x000000018D524C00-0x000000018D524C34
		public static uint GetDynamicThicknessMapSize(); // 0x000000018D524B90-0x000000018D524BBC
		public static bool ShouldDrawThicknessMap(); // 0x000000018D524CBC-0x000000018D524CE8
		public static void DrawThicknessMap(IntPtr context, CommandBuffer cmd, Material blitMat, int passIdx, int viewHandle); // 0x000000018D524B2C-0x000000018D524B90
		private static bool RegisterSludge_Injected(ref Entity entity, Texture2D bakedHeightmap, int nodeCount, IntPtr nodeData); // 0x000000018716C3E0-0x000000018716C450
		private static void UnregisterAndDestroySludge_Injected(ref Entity entity); // 0x00000001871EC020-0x00000001871EC060
		private static uint CreateRendererList_Injected(Camera camera, ref Vector2Int sceneRTSize, uint viewHandle, uint lightModeMask, uint decalLightModeMask, float loadFactor, IntPtr context, bool useMetric); // 0x000000018D524968-0x000000018D5249CC
		private static void HitSludge_Injected(ref Entity entity, ref Vector3 worldPos, float range, float deltaHeightNormalized = 1f /* Metadata: 0x02647CAB */); // 0x000000018D524C34-0x000000018D524C98
		private static void GetHeightmapInfo_Injected(ref Entity entity, out SludgeHeightmapInfo ret); // 0x000000018D524BBC-0x000000018D524C00
	}

	public enum SplineEmissionType // TypeDefIndex: 87855
	{
		Box = 0,
		Mesh = 1
	}

	public enum SplineEmissionMeshType // TypeDefIndex: 87856
	{
		Triangle = 0,
		Vertex = 1,
		Edge = 2
	}

	[Serializable]
	[UsedByNativeCode]
	public struct SplineObjectsDesc // TypeDefIndex: 87857
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
	[UsedByNativeCode]
	public struct SplineObjectsKnotData // TypeDefIndex: 87858
	{
		// Fields
		public Vector3 p0; // 0x00
		public Vector3 p1; // 0x0C
		public Vector3 p2; // 0x18
		public Vector3 p3; // 0x24
		public float length; // 0x30
	}

	[NativeType("Modules/HGGraphics/Public/SplineMovingObject/HGSplineMovingObjectsManager.h")]
	[StaticAccessor("HyperGryph::HGSplineMovingObjectsManager::GetInstance()", StaticAccessorType.Dot)]
	public static class HGSplineMovingObjectsManager // TypeDefIndex: 87859
	{
		// Methods
		public static uint CreateInstance(SplineObjectsDesc desc, NativeArray<SplineObjectsKnotData> curveData); // 0x0000000186ADA9B0-0x0000000186ADAA90
		[NativeName("AddInstanceToDestroyQueue")]
		public static bool DestroyInstance(uint instanceID); // 0x0000000186BB1AB0-0x0000000186BB1AF0
		public static bool UpdateObjectToWorld(uint instanceID, Matrix4x4 objectToWorld); // 0x000000018783B424-0x000000018783B440
		public static bool Pause(uint instanceID); // 0x000000018D524F60-0x000000018D524F94
		private static unsafe uint CreateInstance(SplineObjectsDesc desc, SplineObjectsKnotData* curveData, int length); // 0x000000018783CEF8-0x000000018783CF0C
		private static bool UpdateObjectToWorld_Injected(uint instanceID, ref Matrix4x4 objectToWorld); // 0x0000000185FAC280-0x0000000185FAC2D0
		private static unsafe uint CreateInstance_Injected(ref SplineObjectsDesc desc, SplineObjectsKnotData* curveData, int length); // 0x000000018709C5D0-0x000000018709C630
	}

	[NativeType("Modules/HGGraphics/Public/Subsurface/HGSubsurfaceProfileManager.h")]
	public static class HGSubsurfaceProfileManager // TypeDefIndex: 87860
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetSubsurfaceProfileManager()", StaticAccessorType.Dot)]
		public static void RegisterFromTerrain(HGSubsurfaceProfile profile); // 0x00000001859D65C0-0x00000001859D6690
		[StaticAccessor("GetHGGlobalGameManager().GetSubsurfaceProfileManager()", StaticAccessorType.Dot)]
		public static void UnregisterFromTerrain(); // 0x000000018D525198-0x000000018D5251C4
	}

	[UsedByNativeCode]
	public struct TerrainInfo // TypeDefIndex: 87861
	{
		// Fields
		public Vector3 terrainPosition; // 0x00
		public float heightScale; // 0x0C
		public uint terrainSize; // 0x10
		public int splatTexCount; // 0x14
		public int splatTexSize; // 0x18
		public int hasConeMap; // 0x1C
		public ushort heightmapPageSize; // 0x20
		public ushort normalmapPageSize; // 0x22
		public ushort tintColorPageSize; // 0x24
		public ushort splatCtrlPageSize; // 0x26
		public ushort albedoTexPageSize; // 0x28
		public ushort cliffIndexPageSize; // 0x2A
	}

	[UsedByNativeCode]
	public struct TerrainNodeData // TypeDefIndex: 87862
	{
		// Fields
		public byte allHole; // 0x00
		public byte nodeLevel; // 0x01
		public ushort parent; // 0x02
		public float localMinHeight; // 0x04
		public float localMaxHeight; // 0x08
		public float maxHeightError; // 0x0C
	}

	[UsedByNativeCode]
	public struct SplatLayerData // TypeDefIndex: 87863
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

	[UsedByNativeCode]
	public enum ETerrainStreamingState : uint // TypeDefIndex: 87864
	{
		kNotInitialized = 0,
		kHasPendingTasks = 1,
		kAllTaskCleared = 2
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGTerrainManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGTerrain.bindings.h")]
	public class HGTerrainManager // TypeDefIndex: 87865
	{
		// Properties
		public static float minVerticalFieldOfView { [StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)] set; } // 0x0000000185ECD350-0x0000000185ECD3A0
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager().GetTerrainStreamer()", StaticAccessorType.Arrow)]
		public static ETerrainStreamingState QueryTerrainStreamingState(); // 0x00000001871EBFE0-0x00000001871EC020
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ReadbackVTFeedbackBuffer(int feedbackViewId, CommandBuffer cmd, IntPtr renderContext); // 0x000000018D52580C-0x000000018D52585C
		public static void SetupTerrainManager(string atlasPageRootPath, [IsReadOnly] in TerrainInfo terrainInfo, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, NativeArray<UnityEngine.HyperGryph.SplatLayerData> layerData, int splatTier, NativeArray<UnityEngine.HyperGryph.TerrainNodeData> nodeData, NativeArray<ulong> sectorSplatInfo, uint regionHandle, bool enableHalfVTSize, bool enableHalfAtlasSize = false /* Metadata: 0x02647CB7 */, GraphicsFormat mobileSplatCtrlAtlasFormat = GraphicsFormat.RGBA_ASTC4X4_UNorm /* Metadata: 0x02647CB8 */, bool enableIndirectionCpuUpload = false /* Metadata: 0x02647CBA */, bool enableSplitNormalRO = false /* Metadata: 0x02647CBB */, bool enableCompressUseBuffer = false /* Metadata: 0x02647CBC */, bool atlasPageBytesCompressed = true /* Metadata: 0x02647CBD */, bool isDev = false /* Metadata: 0x02647CBE */); // 0x00000001859D5DF0-0x00000001859D5F70
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		private static void SetupTerrainManager(string atlasPageRootPath, [IsReadOnly] in TerrainInfo terrainInfo, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, int layerCount, IntPtr layerData, int splatTier, int nodeCount, IntPtr nodeData, int sectorCount, IntPtr sectorSplatInfo, uint regionHandle, bool enableHalfVTSize, bool enableHalfAtlasSize, GraphicsFormat mobileSplatCtrlAtlasFormat, bool enableIndirectionCpuUpload, bool enableSplitNormalRO, bool enableCompressUseBuffer, bool atlasPageBytesCompressed, bool isDev); // 0x00000001859D5F70-0x00000001859D6050
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void CleanupTerrainManager(); // 0x000000018D52540C-0x000000018D525438
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static int GetNonTerrainFallbackDeformLayerIndex(); // 0x000000018D52562C-0x000000018D525658
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrainAndUpdateVTFeedbackView(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, Vector3 vtUpdateCenter); // 0x000000018D52549C-0x000000018D5254FC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrain(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext); // 0x000000018D525560-0x000000018D525594
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void PrepareDecalRendererListsForVTPages(int feedbackViewId, IntPtr renderContext, IntPtr features); // 0x000000018D5257BC-0x000000018D52580C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ExecuteVTUpdateCommand(int feedbackViewId, IntPtr renderContext); // 0x000000018D525594-0x000000018D5255D4
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderVTPages(int feedbackViewId, IntPtr features, IntPtr renderContext, CommandBuffer copyCmd, CommandBuffer renderCmd, int bakePassIndex, int bc3PassIndex, int astcPassIndex, int bc5PassIndex, int astcRGPassIndex); // 0x000000018D52597C-0x000000018D5259DC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderScreenSpaceTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr features); // 0x000000018D52585C-0x000000018D5258BC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrainAfterGBuffer(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, IntPtr features); // 0x000000018D5258BC-0x000000018D52591C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void UpdateSubdivisionParameters(int mode, int modeV2, int subd, int primitivePixelLengthTargetLog2); // 0x000000018D525B04-0x000000018D525B64
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SetTerrainBlendBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId); // 0x000000018D525A40-0x000000018D525AA4
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SetDecalDeformBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId); // 0x000000018D5259DC-0x000000018D525A40
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetHeightmapAtlas(); // 0x000000018D525600-0x000000018D52562C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetNormalmapAtlas(); // 0x000000018D525658-0x000000018D525684
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetTintColorAtlas(); // 0x000000018D525790-0x000000018D5257BC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetSplatControlAtlas(); // 0x000000018D525684-0x000000018D5256B0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetAlbedoAtlas(); // 0x000000018D5255D4-0x000000018D525600
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetSplatIndexMap(); // 0x000000018D525738-0x000000018D525764
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2DArray GetSplatDiffuseArray(); // 0x000000018D52570C-0x000000018D525738
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2DArray GetSplatNormalROArray(); // 0x000000018D525764-0x000000018D525790
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static CBHandle GetSplatDataUBO(); // 0x000000018D5256E4-0x000000018D52570C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SubdivisionTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, bool enableSubdivision, bool enableSubdivisionV2, Texture HZBTexture); // 0x000000018D525AA4-0x000000018D525B04
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, int tessellationPassIndex = -1 /* Metadata: 0x02647CBF */, int subdivisionPassIndex = -1 /* Metadata: 0x02647CC0 */, bool enableSubdivisionV2 = false /* Metadata: 0x02647CC1 */); // 0x000000018D52591C-0x000000018D52597C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void StreamingInChunkSurfaceTypeData(uint chunkKey, UIntPtr chunkSurfaceTypeData, int dataLength, int chunkSize); // 0x000000018679CFF0-0x000000018679D060
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void StreamingOutChunkSurfaceTypeData(uint chunkKey); // 0x000000018679D060-0x000000018679D0A0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static bool GetSurfaceTypeByWorldPosition(float x, float y, out int surfaceType); // 0x0000000185778E10-0x0000000185778E70
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static bool HasTerrainNodeData(); // 0x000000018580BF80-0x000000018580BFC0
		private static uint CullTerrainAndUpdateVTFeedbackView_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, ref Vector3 vtUpdateCenter); // 0x000000018D525438-0x000000018D52549C
		private static uint CullTerrain_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext); // 0x000000018D5254FC-0x000000018D525560
		private static void GetSplatDataUBO_Injected(out CBHandle ret); // 0x000000018D5256B0-0x000000018D5256E4
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGEditorTerrainManager.h")]
	public class HGEditorTerrainManager // TypeDefIndex: 87866
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void SetUseNewEditorTerrainRendering(bool value); // 0x000000018580C270-0x000000018580C2B0
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrainAndUpdateVTFeedbackView(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, Vector3 vtUpdateCenter); // 0x000000018D522654-0x000000018D5226B4
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrain(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext); // 0x000000018D522718-0x000000018D52274C
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void SetTerrainBlendBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId); // 0x000000018D522A0C-0x000000018D522A70
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, int subdivisionPassIndex = -1 /* Metadata: 0x02647CC2 */, bool enableSubdivisionV2 = false /* Metadata: 0x02647CC3 */); // 0x000000018D52294C-0x000000018D5229AC
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderScreenSpaceTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr features); // 0x000000018D52282C-0x000000018D52288C
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderSeparateTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int passIndex, IntPtr features); // 0x000000018D52288C-0x000000018D5228EC
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrainAfterGBuffer(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, IntPtr features); // 0x000000018D5228EC-0x000000018D52294C
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void BakeAtlasTexture(CommandBuffer cmd, IntPtr renderContext); // 0x000000018D5225AC-0x000000018D5225F0
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void PrepareDecalRendererListsForVTPages(int feedbackViewId, IntPtr renderContext, IntPtr features); // 0x000000018D52278C-0x000000018D5227DC
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void ExecuteVTUpdateCommand(int feedbackViewId, IntPtr renderContext); // 0x000000018D52274C-0x000000018D52278C
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderVTPages(int feedbackViewId, IntPtr features, IntPtr renderContext, CommandBuffer copyCmd, CommandBuffer renderCmd, int bakePass, int bc3Pass, int astcPass); // 0x000000018D5229AC-0x000000018D522A0C
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void ReadbackVTFeedbackBuffer(int feedbackViewId, CommandBuffer cmd, IntPtr renderContext); // 0x000000018D5227DC-0x000000018D52282C
		private static uint CullTerrainAndUpdateVTFeedbackView_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, ref Vector3 vtUpdateCenter); // 0x000000018D5225F0-0x000000018D522654
		private static uint CullTerrain_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext); // 0x000000018D5226B4-0x000000018D522718
	}

	[UsedByNativeCode]
	public struct HGTerrainDeformConfigV2 // TypeDefIndex: 87867
	{
		// Fields
		public float m_deformGlobalStrength; // 0x00
		public float m_latency; // 0x04
		public float m_deformExtent; // 0x08
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGTerrainDeformManager.h")]
	public class HGTerrainDeformManagerV2 // TypeDefIndex: 87868
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainDeformManager()", StaticAccessorType.Dot)]
		public static void SetPlayerCenter(Vector3 position); // 0x0000000187837E4C-0x0000000187837E5C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainDeformManager()", StaticAccessorType.Dot)]
		public static void UpdateDeformConfig(HGTerrainDeformConfigV2 config); // 0x000000018783B500-0x000000018783B510
		private static void SetPlayerCenter_Injected(ref Vector3 position); // 0x00000001863C3A70-0x00000001863C3AB0
		private static void UpdateDeformConfig_Injected(ref HGTerrainDeformConfigV2 config); // 0x0000000185FEED00-0x0000000185FEED40
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/V3/HGTerrainCommonV3.h")]
	[UsedByNativeCode]
	public enum ETerrainManagerMode : uint // TypeDefIndex: 87869
	{
		kTerrainMode_None = 0,
		kTerrainMode_Streaming = 1,
		kTerrainMode_Editor = 2
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/V3/HGTerrainCommonV3.h")]
	[UsedByNativeCode]
	public struct HGTerrainInitialResource // TypeDefIndex: 87870
	{
		// Fields
		public ETerrainManagerMode mode; // 0x00
		public int enableWetnessVT; // 0x04
		public int enableHalfVTSize; // 0x08
		public int enableHalfAtlasSize; // 0x0C
		public int enableIndirectionCpuUpload; // 0x10
		public int enableSplitNormalRO; // 0x14
		public int enableCompression; // 0x18
		public int enableCompressUseBuffer; // 0x1C
		public int forceIndirectionUpdateFallback; // 0x20
		public string splatTexRootPath; // 0x28
		public int atlasPageBytesCompressed; // 0x30
		public int splatTier; // 0x34
		public uint maxTerrainNum; // 0x38
		public ushort heightmapPageSize; // 0x3C
		public ushort normalmapPageSize; // 0x3E
		public ushort tintColorPageSize; // 0x40
		public ushort splatCtrlPageSize; // 0x42
		public ushort albedoTexPageSize; // 0x44
		public ushort cliffIndexPageSize; // 0x46
		public ComputeShader terrainCS; // 0x48
		public ComputeShader terrainRTCS; // 0x50
		public Shader terrainPS; // 0x58
		public ComputeShader editorTerrainCS; // 0x60
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/V3/HGTerrainCommonV3.h")]
	[UsedByNativeCode]
	public struct HGSplatLayerDataV3 // TypeDefIndex: 87871
	{
		// Fields
		public uint layerHash; // 0x00
		public uint splatTexHash; // 0x04
		public Vector4 packedSplatInfo; // 0x08
		public Vector4 splatST; // 0x18
		public Vector4 diffuseRemapScale; // 0x28
		public Vector4 maskMapRemapOffset; // 0x38
		public Vector4 maskMapRemapScale; // 0x48
		public Vector4 packedDeformParams; // 0x58
		public Vector4 pomParams; // 0x68
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/V3/HGTerrainCommonV3.h")]
	[UsedByNativeCode]
	public struct HGStreamingTerrainInfoV3 // TypeDefIndex: 87872
	{
		// Fields
		public uint terrainHash; // 0x00
		public Vector3 terrainPos; // 0x04
		public float heightScale; // 0x10
		public uint terrainSize; // 0x14
		public int hasConeMap; // 0x18
		public IntPtr editorTerrain; // 0x20
		public int layerCount; // 0x28
		public unsafe HGSplatLayerDataV3* layerData; // 0x30
		public int nodeCount; // 0x38
		public unsafe UnityEngine.HyperGryph.TerrainNodeData* nodeData; // 0x40
		public int sectorCount; // 0x48
		public unsafe ulong* sectorSplatInfo; // 0x50
		public uint regionHandle; // 0x58
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGTerrainManagerV3.h")]
	public class HGTerrainManagerV3 // TypeDefIndex: 87873
	{
		// Properties
		public static float minVerticalFieldOfView { [StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)] set; } // 0x000000018D5253D0-0x000000018D52540C
	
		// Methods
		[FreeFunction("GetEnableTerrainV3")]
		public static bool GetEnableTerrainV3(); // 0x0000000185778E70-0x0000000185778EB0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static ETerrainManagerMode GetTerrainMode(); // 0x000000018580BF40-0x000000018580BF80
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static bool HasAnyTerrain(); // 0x000000018D525248-0x000000018D525274
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static bool SetupTerrainManagerV3(HGTerrainInitialResource initRes); // 0x000000018D5252EC-0x000000018D5252FC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static void CleanupTerrainManagerV3(); // 0x000000018D5251C4-0x000000018D5251F0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static unsafe uint RegisterStreamingTerrain(HGStreamingTerrainInfoV3* info, string atlasPageRootPath); // 0x000000018D525274-0x000000018D5252B8
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static void UnregisterStreamingTerrain(uint handle); // 0x000000018D52539C-0x000000018D5253D0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static void StreamingInChunkSurfaceTypeData(uint terrainHash, uint chunkKey, UIntPtr chunkSurfaceTypeData, int dataLength, int chunkSize); // 0x000000018D5252FC-0x000000018D52535C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static void StreamingOutChunkSurfaceTypeData(uint terrainHash, uint chunkKey); // 0x000000018D52535C-0x000000018D52539C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static bool GetSurfaceTypeByWorldPosition(Vector3 worldPos, out int surfaceType); // 0x000000018D525234-0x000000018D525248
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static void SetPlayerCenter(Vector3 playerCenter); // 0x0000000187837E5C-0x0000000187837E6C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static void UpdateDeformConfig(HGTerrainDeformConfigV2 config); // 0x000000018783B510-0x000000018783B520
		private static bool SetupTerrainManagerV3_Injected(ref HGTerrainInitialResource initRes); // 0x000000018D5252B8-0x000000018D5252EC
		private static bool GetSurfaceTypeByWorldPosition_Injected(ref Vector3 worldPos, out int surfaceType); // 0x000000018D5251F0-0x000000018D525234
		private static void SetPlayerCenter_Injected(ref Vector3 playerCenter); // 0x00000001863C3A30-0x00000001863C3A70
		private static void UpdateDeformConfig_Injected(ref HGTerrainDeformConfigV2 config); // 0x0000000185FEECC0-0x0000000185FEED00
	}

	[NativeType("Modules/HGGraphics/Public/Foliage/HGTreeRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetTreeRender()", StaticAccessorType.Dot)]
	public static class HGTreeRender // TypeDefIndex: 87874
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool noAlphaTest = false /* Metadata: 0x02647CC7 */); // 0x000000018D525E6C-0x000000018D525E9C
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr, bool noAlphaTest); // 0x000000018D525E9C-0x000000018D525EFC
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, bool noAlphaTest); // 0x000000018D525DE0-0x000000018D525E40
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, out uint normalList, out uint preZPart0List, out uint preZPart1List, bool noAlphaTest = false /* Metadata: 0x02647CC8 */); // 0x000000018D525E40-0x000000018D525E6C
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018D525EFC-0x000000018D525F18
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGUIRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetUIRender()", StaticAccessorType.Dot)]
	public static class HGUIRender // TypeDefIndex: 87875
	{
		// Methods
		public static uint CreateRendererList(uint cullingLayerMask, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, short sortingOrderMin, short sortingOrderMax, int cameraInstanceID, IntPtr context, bool isWorldUI, float wolrdUICullingDistance = 3.4028235E+38f /* Metadata: 0x02647CC9 */); // 0x000000018D525F18-0x000000018D525F48
		private static uint CreateRendererList(uint cullingLayerMask, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, short sortingOrderMin, short sortingOrderMax, int cameraInstanceID, IntPtr context, bool isWorldUI, float wolrdUICullingDistance); // 0x000000018D525F48-0x000000018D525FCC
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGVATBLASManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetVATBLASManager()", StaticAccessorType.Dot)]
	public static class HGVATBLASManager // TypeDefIndex: 87876
	{
		// Methods
		public static void Setup(ComputeShader vatSkinningCs); // 0x0000000185B9E880-0x0000000185B9E8C0
		public static void SetVATMapPropertyName(int propertyNameId); // 0x0000000185B9E840-0x0000000185B9E880
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGWaterRender.h")]
	public static class HGWaterRender // TypeDefIndex: 87880
	{
		// Nested types
		public enum HGWaterHeightLayer // TypeDefIndex: 87877
		{
			HeightLayer0 = 0,
			HeightLayer1 = 1,
			HeightLayer2 = 2,
			HeightLayer3 = 3
		}
	
		public enum HGWaterRenderType // TypeDefIndex: 87878
		{
			Proxy = 1,
			LOD = 2
		}
	
		public enum HGWaterDecalRenderType // TypeDefIndex: 87879
		{
			None = 0,
			Regular = 1,
			Emissive = 2
		}
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void CullWaterProxy(uint viewHandle, Matrix4x4 viewProj, uint cullingMask, bool useOC, out uint visibleCount, out uint cullHandle, bool orderByDistance = false /* Metadata: 0x02647CCD */, Vector3 viewPosition = default); // 0x000000018783B10C-0x000000018783B158
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void CullWaterDecals(uint viewHandle, Matrix4x4 viewProj, out uint visibleCount, out uint cullHandle, bool useAnchorSH = false /* Metadata: 0x02647CCE */); // 0x000000018783B0EC-0x000000018783B10C
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool IsHeightLayerVisible(uint cullHandle, uint renderTypeMask, int lodLayer); // 0x000000018D526098-0x000000018D5260E8
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void DrawWaterProxy(IntPtr renderContext, CommandBuffer cmd, uint cullHandle, Material material, MaterialPropertyBlock properties, int shaderPass, int nameID, bool clear = true /* Metadata: 0x02647CCF */, uint renderTypeMask = 3 /* Metadata: 0x02647CD0 */, int lodLayer = -1 /* Metadata: 0x02647CD1 */, bool filterByWetnessMask = false /* Metadata: 0x02647CD2 */); // 0x000000018D526030-0x000000018D526098
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void DrawWaterDecals(IntPtr renderContext, CommandBuffer cmd, uint cullHandle, MaterialPropertyBlock properties, int nameID, bool clear = true /* Metadata: 0x02647CD3 */, int shaderPass = 0 /* Metadata: 0x02647CD4 */, uint renderTypeMask = 1 /* Metadata: 0x02647CD5 */, int heightLayer = -1 /* Metadata: 0x02647CD6 */); // 0x000000018D525FCC-0x000000018D526030
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool IsHGWaterGloablConfigValidCPP(); // 0x00000001862A7200-0x00000001862A7280
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool CheckNewHGWaterGloablConfigCPP(string scenePath); // 0x00000001862AEFC0-0x00000001862AF000
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void UpdateHGWaterGloablConfigCPP(string scenePath, int sectorNum, int sectorSize, int sectorCoordsMin, int sectorCoordsMax, long[] sectorDataGUIDs, bool[] sectorDataExists); // 0x000000018718F5A0-0x000000018718F610
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void AddSectorTexture(int id, int textureID); // 0x00000001867FA8A0-0x00000001867FA8F0
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void RemoveSectorTexture(int id); // 0x000000018D5260E8-0x000000018D52611C
		private static void CullWaterProxy_Injected(uint viewHandle, ref Matrix4x4 viewProj, uint cullingMask, bool useOC, out uint visibleCount, out uint cullHandle, bool orderByDistance = false /* Metadata: 0x02647CD7 */, ref Vector3 viewPosition = null); // 0x0000000186124DB0-0x0000000186124E30
		private static void CullWaterDecals_Injected(uint viewHandle, ref Matrix4x4 viewProj, out uint visibleCount, out uint cullHandle, bool useAnchorSH = false /* Metadata: 0x02647CD8 */); // 0x000000018619C620-0x000000018619C6A0
	}

	[Flags]
	public enum HGWindMotorExcludeFlags : byte // TypeDefIndex: 87881
	{
		None = 0,
		GlobalData = 1,
		InjectionField = 2
	}

	[UsedByNativeCode]
	public struct HGWindMotorInitData // TypeDefIndex: 87882
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector3 forward; // 0x0C
		public float radius; // 0x18
		public float length; // 0x1C
		public float width; // 0x20
		public float height; // 0x24
		public float angleCos; // 0x28
		public float forceStrength; // 0x2C
		public float rangeIn; // 0x30
		public sbyte shape; // 0x34
		public sbyte orient; // 0x35
		public sbyte rectBackward; // 0x36
		public sbyte priority; // 0x37
		public HGWindMotorExcludeFlags excludeFlags; // 0x38
		public sbyte pad0; // 0x39
		public sbyte pad1; // 0x3A
		public sbyte pad2; // 0x3B
	}

	[UsedByNativeCode]
	public struct HGWindMotorAuthoringData // TypeDefIndex: 87883
	{
		// Fields
		public float angleCos; // 0x00
		public float forceStrength; // 0x04
		public float rangeIn; // 0x08
		public sbyte shape; // 0x0C
		public sbyte orient; // 0x0D
		public sbyte rectBackward; // 0x0E
		public sbyte priority; // 0x0F
		public HGWindMotorExcludeFlags excludeFlags; // 0x10
		public sbyte pad0; // 0x11
		public sbyte pad1; // 0x12
		public sbyte pad2; // 0x13
	}

	public static class HGWindMotorSystemCPP // TypeDefIndex: 87884
	{
		// Methods
		[FreeFunction("HGWindMotorSystemCPP_CreateEntity")]
		[NativeHeader("Modules/HGGraphics/Public/WindMotor/HGWindMotorSystem.h")]
		public static ulong HGWindMotorSystemCPP_CreateEntity(ref HGWindMotorInitData data); // 0x00000001860EC530-0x00000001860EC570
		[FreeFunction("HGWindMotorSystemCPP_DestroyEntity")]
		[NativeHeader("Modules/HGGraphics/Public/WindMotor/HGWindMotorSystem.h")]
		public static void HGWindMotorSystemCPP_DestroyEntity(ulong entityHandle); // 0x00000001860EC3B0-0x00000001860EC3F0
		[FreeFunction("HGWindMotorSystemCPP_UpdateAuthoringDataBatch")]
		[NativeHeader("Modules/HGGraphics/Public/WindMotor/HGWindMotorSystem.h")]
		public static unsafe void HGWindMotorSystemCPP_UpdateAuthoringDataBatch(ulong* handles, HGWindMotorAuthoringData* datas, int count); // 0x000000018585BBF0-0x000000018585BC50
		public static void HGWindMotorSystemCPP_UpdateAuthoringDataBatch(ulong[] handles, HGWindMotorAuthoringData[] datas, int count); // 0x000000018585BB60-0x000000018585BBF0
		[FreeFunction("HGWindMotorSystemCPP_BindTransformInterest")]
		[NativeHeader("Modules/HGGraphics/Public/WindMotor/HGWindMotorSystem.h")]
		public static void HGWindMotorSystemCPP_BindTransformInterest(ulong entityHandle, Transform transform); // 0x00000001860EC8E0-0x00000001860EC930
		[FreeFunction("HGWindMotorSystemCPP_UnbindTransformInterest")]
		[NativeHeader("Modules/HGGraphics/Public/WindMotor/HGWindMotorSystem.h")]
		public static void HGWindMotorSystemCPP_UnbindTransformInterest(ulong entityHandle); // 0x00000001860EC370-0x00000001860EC3B0
		[FreeFunction("HGWindMotorSystemCPP_SetPlayerCenter")]
		[NativeHeader("Modules/HGGraphics/Public/WindMotor/HGWindMotorSystem.h")]
		public static void HGWindMotorSystemCPP_SetPlayerCenter(Vector3 center); // 0x0000000187837E3C-0x0000000187837E4C
		private static void HGWindMotorSystemCPP_SetPlayerCenter_Injected(ref Vector3 center); // 0x00000001863C39F0-0x00000001863C3A30
	}

	[NativeHeader("Modules/HGGraphics/Public/VivoGameCore/VivoGameCoreUDSClient.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetVivoGameCoreUDSClient()", StaticAccessorType.Dot)]
	public static class VivoGameCoreUDSClient // TypeDefIndex: 87885
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<int> serverSRLevelChanged; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<int> serverFILevelChanged; // 0x08
	
		// Events
		public static event UnityAction<int> serverSRLevelChanged {
			add; // 0x000000018D5268C4-0x000000018D526960
			remove; // 0x000000018D526A04-0x000000018D526AA0
		}
		public static event UnityAction<int> serverFILevelChanged {
			add; // 0x000000018D526820-0x000000018D5268C4
			remove; // 0x000000018D526960-0x000000018D526A04
		}
	
		// Methods
		public static int GetServerSRLevel(); // 0x000000018D526644-0x000000018D526670
		public static int GetServerFILevel(); // 0x000000018D526618-0x000000018D526644
		[RequiredByNativeCode]
		private static void Internal_OnServerSRLevelChanged(int level); // 0x000000018D526714-0x000000018D526760
		[RequiredByNativeCode]
		private static void Internal_OnServerFILevelChanged(int level); // 0x000000018D5266C8-0x000000018D526714
		public static bool IsSRSupported(); // 0x000000018D52678C-0x000000018D5267B8
		public static bool IsFISupported(); // 0x000000018D526760-0x000000018D52678C
		public static bool GetVivoIgnoreState(); // 0x000000018D52669C-0x000000018D5266C8
		public static bool GetUseVivoSpacialFI(); // 0x000000018D526670-0x000000018D52669C
		public static bool SetLocalSRLevel(int level); // 0x000000018D5267EC-0x000000018D526820
		public static bool SetLocalFILevel(int level); // 0x000000018D5267B8-0x000000018D5267EC
		public static int GetSRGear(); // 0x000000018D5265EC-0x000000018D526618
	}
}

namespace UnityEngine.HyperGryph.ECS
{
	public enum ECSExplicitEntityType : uint // TypeDefIndex: 87919
	{
		Unknown = 0,
		MeshRenderer = 1,
		ReflectionProbe = 2,
		WaterRenderer = 3,
		FactoryRenderer = 4,
		HGDecalProjector = 5,
		HGMeshRenderer = 6,
		WindMotor = 7
	}

	[UsedByNativeCode]
	public struct EntityInstanceData // TypeDefIndex: 87920
	{
		// Fields
		public uint entityType; // 0x00
		public int entityIdx; // 0x04
		public uint version; // 0x08
		public uint padding; // 0x0C
	}

	[UsedByNativeCode]
	public struct ComponentType // TypeDefIndex: 87921
	{
		// Fields
		public ulong value; // 0x00
		public short componentID; // 0x00
		public short componentSize; // 0x02
		public int offset; // 0x04
	}

	public struct ComponentMask // TypeDefIndex: 87923
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ ulong componentMaskWords[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _componentMaskWords_e__FixedBuffer // TypeDefIndex: 87922
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		// Constructors
		public unsafe ComponentMask(int id); // 0x0000000187261BF0-0x0000000187261C10
	
		// Methods
		[IsReadOnly]
		public bool ContainsComponentId(int id); // 0x0000000184FFE380-0x0000000184FFE3A0
		[IsReadOnly]
		public bool ContainsComponentMask([IsReadOnly] in ComponentMask other); // 0x0000000184FA56D0-0x0000000184FA56F0
		[IsReadOnly]
		public bool ExcludesComponentMask([IsReadOnly] in ComponentMask other); // 0x0000000184FA5710-0x0000000184FA5730
		[IsReadOnly]
		public bool IntersectsComponentMask([IsReadOnly] in ComponentMask other); // 0x000000018D521188-0x000000018D5211A0
		[IsReadOnly]
		public bool HasAnyBit(); // 0x0000000184FA56F0-0x0000000184FA5710
		public override bool Equals(object obj); // 0x000000018D52110C-0x000000018D521188
		public override int GetHashCode(); // 0x0000000187261BA0-0x0000000187261BD0
		public void And(ref ComponentMask other); // 0x0000000187261B90-0x0000000187261BA0
		public void Or(int id); // 0x0000000187261BD0-0x0000000187261BF0
	}

	[UsedByNativeCode]
	public struct EntityTypeInstanceData // TypeDefIndex: 87925
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
		public unsafe fixed /* 0x00000000-0x00000000 */ ulong componentTypes[0]; // 0x40
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _componentTypes_e__FixedBuffer // TypeDefIndex: 87924
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct Entity : IEquatable<Entity> // TypeDefIndex: 87926
	{
		// Fields
		public uint globalIndex; // 0x00
		public uint version; // 0x04
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Entity _invaildEntity_k__BackingField; // 0x00
	
		// Properties
		public ulong id { get; set; } // 0x0000000187261D30-0x0000000187261D40 0x000000018725DCB0-0x000000018725DCC0
		public static Entity invaildEntity { [CompilerGenerated] get; } // 0x000000018D5217B4-0x000000018D521804 
	
		// Constructors
		static Entity(); // 0x00000001871F50D0-0x00000001871F5120
	
		// Methods
		public bool Equals(Entity rhs); // 0x00000001855E7260-0x00000001855E72F0
		public override int GetHashCode(); // 0x000000018725FD00-0x000000018725FD10
		public override string ToString(); // 0x000000018D52172C-0x000000018D5217B4
		public bool Valid(); // 0x000000018509D600-0x000000018509D620
		public static bool operator ==(Entity left, Entity right); // 0x00000001855E7140-0x00000001855E71A0
		public static bool operator !=(Entity left, Entity right); // 0x0000000185A5A890-0x0000000185A5A8E0
		public override bool Equals(object obj); // 0x000000018D5216B0-0x000000018D52172C
	}

	[UsedByNativeCode]
	public struct EntityType // TypeDefIndex: 87927
	{
		// Fields
		public uint id; // 0x00
	}

	public interface IComponentECS // TypeDefIndex: 87928
	{
		// Properties
		int id { get; }
	}

	public struct BoundingCenterXComponent : IComponentECS // TypeDefIndex: 87929
	{
		// Fields
		public float x; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000185829EC0-0x0000000185829ED0 
	}

	public struct BoundingCenterYComponent : IComponentECS // TypeDefIndex: 87930
	{
		// Fields
		public float y; // 0x00
	
		// Properties
		public int id { get; } // 0x00000001872328C0-0x00000001872328D0 
	}

	public struct BoundingCenterZComponent : IComponentECS // TypeDefIndex: 87931
	{
		// Fields
		public float z; // 0x00
	
		// Properties
		public int id { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
	}

	public struct BoundingExtentXComponent : IComponentECS // TypeDefIndex: 87932
	{
		// Fields
		public float x; // 0x00
	
		// Properties
		public int id { get; } // 0x00000001872396E0-0x00000001872396F0 
	}

	public struct BoundingExtentYComponent : IComponentECS // TypeDefIndex: 87933
	{
		// Fields
		public float y; // 0x00
	
		// Properties
		public int id { get; } // 0x00000001845BA780-0x00000001845BA790 
	}

	public struct BoundingExtentZComponent : IComponentECS // TypeDefIndex: 87934
	{
		// Fields
		public float z; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000187239C70-0x0000000187239C80 
	}

	public struct RenderObjectLODInfoComponent : IComponentECS // TypeDefIndex: 87935
	{
		// Fields
		public Vector3 lodCenter; // 0x00
		public float lodObjectHalfSizeSquared; // 0x0C
		public bool enableDither; // 0x10
		public byte lodCullingOptions; // 0x11
		public byte padding0; // 0x12
		public byte padding1; // 0x13
	
		// Properties
		public int id { get; } // 0x0000000187239C80-0x0000000187239C90 
	}

	public struct RenderObjectInfoComponent : IComponentECS // TypeDefIndex: 87936
	{
		// Fields
		public uint roLayerMask; // 0x00
		public uint objectFlags; // 0x04
		public ulong sceneMask; // 0x08
		public uint artTag; // 0x10
		public float sortingFudgeSqr; // 0x14
	
		// Properties
		public int id { get; } // 0x0000000187239C90-0x0000000187239CA0 
	}

	public struct RendererInfo // TypeDefIndex: 87937
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

	public struct LODInfo // TypeDefIndex: 87938
	{
		// Fields
		public float lodScreenSizeMaxSquared; // 0x00
		public float lodScreenSizeMinSquared; // 0x04
	}

	public interface IRenderObjectKComponent : IComponentECS // TypeDefIndex: 87939
	{
		// Methods
		byte* GetRenderersPtr();
	}

	public struct RenderObjectK1Component : IRenderObjectKComponent // TypeDefIndex: 87942
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x1C
	
		// Properties
		public int id { get; } // 0x0000000187239CB0-0x0000000187239CC0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 87940
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 87941
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000187261C90-0x0000000187261CA0
	}

	public struct RenderObjectK2Component : IRenderObjectKComponent // TypeDefIndex: 87945
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x34
	
		// Properties
		public int id { get; } // 0x0000000187239CC0-0x0000000187239CD0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 87943
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 87944
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000187261C90-0x0000000187261CA0
	}

	public struct RenderObjectK4Component : IRenderObjectKComponent // TypeDefIndex: 87948
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x64
	
		// Properties
		public int id { get; } // 0x0000000187239CD0-0x0000000187239CE0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 87946
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 87947
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000187261C90-0x0000000187261CA0
	}

	public struct RenderObjectK8Component : IRenderObjectKComponent // TypeDefIndex: 87951
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0xC4
	
		// Properties
		public int id { get; } // 0x0000000187239CE0-0x0000000187239CF0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 87949
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 87950
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000187261C90-0x0000000187261CA0
	}

	public struct RenderObjectK16Component : IRenderObjectKComponent // TypeDefIndex: 87954
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x184
	
		// Properties
		public int id { get; } // 0x0000000187239CF0-0x0000000187239D00 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 87952
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 87953
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000187261C90-0x0000000187261CA0
	}

	[UsedByNativeCode]
	public struct PerDrawBaseData // TypeDefIndex: 87955
	{
		// Fields
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 lodFade; // 0x40
		public Vector4 worldTransformParams; // 0x50
		public Matrix4x4 matrixPreviousM; // 0x60
		public Vector4 motionVectorsParams; // 0xA0
	}

	public struct CommonInstanceDataComponent : IComponentECS // TypeDefIndex: 87957
	{
		// Fields
		public PerDrawBaseData baseData; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float customData[0]; // 0xB0
	
		// Properties
		public int id { get; } // 0x0000000187239DD0-0x0000000187239DE0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _customData_e__FixedBuffer // TypeDefIndex: 87956
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct FactoryInstanceDataComponent : IComponentECS // TypeDefIndex: 87959
	{
		// Fields
		public PerDrawBaseData baseData; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float customData[0]; // 0xB0
	
		// Properties
		public int id { get; } // 0x0000000187239DD0-0x0000000187239DE0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _customData_e__FixedBuffer // TypeDefIndex: 87958
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct ECSFixedString64 // TypeDefIndex: 87961
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 87960
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string GetData(); // 0x000000018D5211A0-0x000000018D52123C
		public override string ToString(); // 0x000000018D52123C-0x000000018D521244
	}

	public struct DebugContentsComponent : IComponentECS // TypeDefIndex: 87962
	{
		// Fields
		public ECSFixedString64 entityName; // 0x00
		public ECSExplicitEntityType entityType; // 0x40
		public ECSFixedString64 debugStr; // 0x44
	
		// Properties
		public int id { get; } // 0x0000000187251F30-0x0000000187251F40 
	}

	public struct HGFactoryRendererBinderComponent : IComponentECS // TypeDefIndex: 87963
	{
		// Fields
		public Entity rendererEntity; // 0x00
		public uint sharedDataIndex; // 0x08
		public byte rendererType; // 0x0C
		public byte padding0; // 0x0D
		public byte padding1; // 0x0E
		public byte padding2; // 0x0F
	
		// Properties
		public int id { get; } // 0x0000000187236080-0x0000000187236090 
	
		// Methods
		public void SetDirtyFlag(HGFactoryDirtyFlags flag); // 0x000000018598F060-0x000000018598F0F0
		public void SetAdditiveMaterialBit(int bitIndex, bool enable); // 0x000000018D522C24-0x000000018D522CD4
		public void SetPosition(Vector3 position); // 0x000000018598EC50-0x000000018598ECF0
		public void SetUniformScale(float uniformScale); // 0x000000018D522D1C-0x000000018D522D78
		public void SetRotation(Quaternion rotation); // 0x0000000185990D70-0x0000000185990E00
		public void SetTransform(HGFactoryEntityTransformData transform); // 0x000000018D522CD4-0x000000018D522D1C
		public void SetCustomPerDrawData<T>(T data, int offset)
			where T : struct;
		public void SetEnabled(bool enabled); // 0x000000018598EF30-0x000000018598F020
		public void SetAdditiveEntitiesVisibility(bool visible); // 0x000000018598F500-0x000000018598F5A0
	}

	public struct HGWaterComponent : IComponentECS // TypeDefIndex: 87964
	{
		// Fields
		public uint renderTypeMask; // 0x00
		public int meshID; // 0x04
		public Matrix4x4 objectToWorld; // 0x08
		public Vector4 param0; // 0x48
		public Vector4 param1; // 0x58
	
		// Properties
		public int id { get; } // 0x000000018723A470-0x000000018723A480 
	}

	public struct HGWaterDecalComponent : IComponentECS // TypeDefIndex: 87965
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
		public int id { get; } // 0x0000000187239DE0-0x0000000187239DF0 
	}

	public struct GrassRendererInfo // TypeDefIndex: 87966
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
	[UsedByNativeCode]
	public struct GrassPerInstanceData // TypeDefIndex: 87967
	{
		// Fields
		public const int SIZE = 96; // Metadata: 0x02647EAC
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 param0; // 0x40
		public Vector4 param1; // 0x50
	}

	public struct GrassClusterK4Component : IComponentECS // TypeDefIndex: 87969
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get; } // 0x0000000187239CA0-0x0000000187239CB0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 87968
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK8Component : IComponentECS // TypeDefIndex: 87971
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get; } // 0x000000018723A8C0-0x000000018723A8D0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 87970
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK16Component : IComponentECS // TypeDefIndex: 87973
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get; } // 0x0000000187239F20-0x0000000187239F30 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 87972
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK32Component : IComponentECS // TypeDefIndex: 87975
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get; } // 0x000000018723A870-0x000000018723A880 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 87974
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct ECSColliderComponent : IComponentECS // TypeDefIndex: 87976
	{
		// Fields
		public IntPtr actor; // 0x00
		public int ecsId; // 0x08
		public uint ecsVersion; // 0x0C
	
		// Properties
		public int id { get; } // 0x0000000187258A20-0x0000000187258A30 
	}

	public struct HGSludgeComponent : IComponentECS // TypeDefIndex: 87977
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
		public int id { get; } // 0x0000000187239F40-0x0000000187239F50 
	}

	public struct HGWindMotorKinematicState // TypeDefIndex: 87978
	{
		// Fields
		public Vector3 position; // 0x00
		public Vector3 forward; // 0x0C
		public float motorTime; // 0x18
		public float radius; // 0x1C
		public float length; // 0x20
		public float width; // 0x24
		public float height; // 0x28
		public float angleCos; // 0x2C
		public float forceStrength; // 0x30
		public float rangeIn; // 0x34
		public sbyte shape; // 0x38
		public sbyte orient; // 0x39
		public sbyte rectBackward; // 0x3A
		public sbyte pad; // 0x3B
	}

	public struct HGWindMotorComponent : IComponentECS // TypeDefIndex: 87979
	{
		// Fields
		public HGWindMotorKinematicState kin; // 0x00
		public sbyte priority; // 0x3C
		public HGWindMotorExcludeFlags excludeFlags; // 0x3D
		public sbyte pad0; // 0x3E
		public sbyte pad1; // 0x3F
	
		// Properties
		public int id { get; } // 0x0000000187239FD0-0x0000000187239FE0 
	}

	public struct HGGrassTagComponent : IComponentECS // TypeDefIndex: 87980
	{
		// Fields
		public uint tagId; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000187239FE0-0x0000000187239FF0 
	}

	public struct ECSClothDataComponent : IComponentECS // TypeDefIndex: 87981
	{
		// Fields
		public uint clothHash; // 0x00
	
		// Properties
		public int id { get; } // 0x000000018723A010-0x000000018723A020 
	}

	public struct HGStreamingVolumeComponent : IComponentECS // TypeDefIndex: 87982
	{
		// Fields
		public bool isEnable; // 0x00
		public Vector3 center; // 0x04
		public Vector3 size; // 0x10
		public Quaternion rotation; // 0x1C
	
		// Properties
		public int id { get; } // 0x000000018723B230-0x000000018723B240 
	}

	public struct HGCullingParameterComponent : IComponentECS // TypeDefIndex: 87983
	{
		// Fields
		public bool enableShadowCulling; // 0x00
	
		// Properties
		public int id { get; } // 0x000000018723A250-0x000000018723A260 
	}

	[Serializable]
	[UsedByNativeCode]
	public struct TreePerInstanceData // TypeDefIndex: 87984
	{
		// Fields
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 param0; // 0x40
		public Vector4 param1; // 0x50
	}

	[UsedByNativeCode]
	public struct HGTreeComponent : IComponentECS // TypeDefIndex: 87985
	{
		// Fields
		public TreePerInstanceData perInstanceData; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000187239D10-0x0000000187239D20 
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGEntityManager.bindings.h")]
	public struct EntityManager // TypeDefIndex: 87986
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public readonly IntPtr m_entitiesPPtr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public readonly IntPtr m_entityTypesPPtr; // 0x08
	
		// Methods
		public static int GetNFromKNComponentMask(ulong componentMask); // 0x0000000187261CC0-0x0000000187261CD0
		public static unsafe int GetCountFromKNComponent(byte* component); // 0x000000018725FD00-0x000000018725FD10
		public static unsafe void SetCountForKNComponent(byte* component, int count); // 0x0000000184547F40-0x0000000184547F50
		public static unsafe GrassRendererInfo* GetGrassRendererInfosFromKNComponent(byte* component); // 0x0000000187261C90-0x0000000187261CA0
		public static unsafe LODInfo* GetLODInfosFromKNComponent(byte* component, int n); // 0x0000000187261CA0-0x0000000187261CC0
		public static unsafe int GetCountFromKNGrassCluster(byte* component); // 0x000000018725FD00-0x000000018725FD10
		public static unsafe void SetCountForKNGrassCluster(byte* component, int count); // 0x0000000184547F40-0x0000000184547F50
		public static unsafe GrassPerInstanceData* GetPerInstanceDataFromKNGrassCluster(byte* component); // 0x0000000187261C90-0x0000000187261CA0
		public static EntityManager GetEntityManager(); // 0x0000000186392160-0x00000001863921B0
		public static EntityManager GetGameplayEntityManager(); // 0x000000018509BAC0-0x000000018509BB10
		public static EntityManager GetRendererEntityManager(); // 0x00000001856790A0-0x00000001856790F0
		public bool HasEntity(Entity entity); // 0x000000018509D620-0x000000018509D6B0
		public Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityType entityType); // 0x000000018573A800-0x000000018573A860
		public void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, IntPtr entities, int count); // 0x0000000187835ED0-0x0000000187835EF0
		public void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, NativeArray<Entity> entities); // 0x000000018543E4E0-0x000000018543EAE0
		public void DestroyEntity(Entity entity); // 0x0000000187834EAC-0x0000000187834EC8
		public void DestroyEntities(NativeArray<Entity> entities); // 0x0000000185965B10-0x0000000185965B70
		public void DestroyEntities(IntPtr entities, int entityCount); // 0x0000000187838BA4-0x0000000187838BAC
		public static ComponentType GetComponentType<T>()
			where T : struct, IComponentECS;
		public void AddComponent<T>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS;
		public void RemoveComponent<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS;
		public void RemoveComponentsWithMask([IsReadOnly] in Entity entity, ref ComponentMask needRemoveComponentMask); // 0x000000018598E8C0-0x000000018598EA30
		public UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityType(NativeArray<ComponentType> componentTypes); // 0x000000018573A8C0-0x000000018573A930
		public UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityTypeImpl(int componentTypeCount, IntPtr componentTypes); // 0x000000018573A930-0x000000018573A9A0
		public void AddMoveEntityAndEntityTypeDataImpl([IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType); // 0x0000000187838CA4-0x0000000187838CAC
		public void RemoveMoveEntityAndEntityTypeDataImpl([IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType); // 0x000000018D5214C4-0x000000018D5214CC
		public static ulong NumberOfSetBits(ulong i); // 0x0000000187261CD0-0x0000000187261D30
		public static ulong NumberOfSetBits(ref ComponentMask mask); // 0x0000000184FFE480-0x0000000184FFE4C0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1); // 0x0000000185964070-0x00000001859640D0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2); // 0x000000018604B5B0-0x000000018604B630
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3); // 0x0000000185E65900-0x0000000185E659A0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3, int id4); // 0x0000000185DCD440-0x0000000185DCD500
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3, int id4, int id5); // 0x0000000185D4C050-0x0000000185D4C130
		public bool HasComponent<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS;
		public void SetComponents<T0, T1>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS;
		public static ComponentMask GetCountingMask(int id); // 0x0000000184FFE4C0-0x0000000184FFE520
		public static void SetComponentImplWithRef<T>(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS;
		public void SetComponent<T>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS;
		private static unsafe byte* GetComponentPtrImpl(int entityIdx, ref EntityTypeInstanceData entityTypeData, int componentId, int componentSize); // 0x000000018D521344-0x000000018D5213DC
		public bool TryGetWorldAABBFromRendererEntity([IsReadOnly] in Entity entity, out Bounds aabb); // 0x000000018D5214CC-0x000000018D5216B0
		public ulong GetComponentMaskLow([IsReadOnly] in Entity entity); // 0x0000000187261C60-0x0000000187261C90
		public ComponentMask GetComponentMaskAll([IsReadOnly] in Entity entity); // 0x0000000187261C30-0x0000000187261C60
		public unsafe byte* GetComponentPtrLowBits([IsReadOnly] in Entity entity, ulong componentMask); // 0x000000018D5213DC-0x000000018D5214C4
		public T GetComponent<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS;
		public bool TryGetComponent<T>([IsReadOnly] in Entity entity, out ref T component)
			where T : struct, IComponentECS;
		public ref ref T GetComponentRef<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS;
		public unsafe T* GetComponentPtr<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS;
		public unsafe bool TryGetComponentPtr<T>([IsReadOnly] in Entity entity, out ref T* componentPtr)
			where T : struct, IComponentECS;
		public EntityManagerRange Iterate(ref ComponentMask includeComponentMask, ref ComponentMask excludeComponentMask); // 0x0000000184FA40E0-0x0000000184FA4210
		public EntityManagerRange Iterate(ref ComponentMask componentMask); // 0x0000000184FA4000-0x0000000184FA40E0
		public EntityManagerRange Iterate<T>()
			where T : struct, IComponentECS;
		public EntityManagerRange Iterate<T0, T1>()
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS;
		[NativeMethod(IsThreadSafe = true)]
		public int GetEntityTypeCount(); // 0x00000001878344C4-0x00000001878344CC
		[NativeMethod(IsThreadSafe = true)]
		public uint GetEntityContainerSize(); // 0x000000018783498C-0x0000000187834994
		public void GarbageCollect(); // 0x000000018783B7C4-0x000000018783B7CC
		private static void GetEntityManager_Injected(out EntityManager ret); // 0x00000001863921B0-0x00000001863921F0
		private static void GetGameplayEntityManager_Injected(out EntityManager ret); // 0x000000018509BB10-0x000000018509BB50
		private static void GetRendererEntityManager_Injected(out EntityManager ret); // 0x00000001856790F0-0x0000000185679130
		private static void CreateEntity_Injected(ref EntityManager _unity_self, ref UnityEngine.HyperGryph.ECS.EntityType entityType, out Entity ret); // 0x000000018573A860-0x000000018573A8C0
		private static void CreateEntities_Injected(ref EntityManager _unity_self, ref UnityEngine.HyperGryph.ECS.EntityType entityType, IntPtr entities, int count); // 0x0000000186AD77F0-0x0000000186AD7860
		private static void DestroyEntity_Injected(ref EntityManager _unity_self, ref Entity entity); // 0x0000000186114640-0x0000000186114690
		private static void DestroyEntities_Injected(ref EntityManager _unity_self, IntPtr entities, int entityCount); // 0x000000018623C040-0x000000018623C0A0
		private static void GetOrRegisterEntityTypeImpl_Injected(ref EntityManager _unity_self, int componentTypeCount, IntPtr componentTypes, out UnityEngine.HyperGryph.ECS.EntityType ret); // 0x000000018573A9A0-0x000000018573AA10
		private static void AddMoveEntityAndEntityTypeDataImpl_Injected(ref EntityManager _unity_self, [IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType); // 0x00000001862A41B0-0x00000001862A4210
		private static void RemoveMoveEntityAndEntityTypeDataImpl_Injected(ref EntityManager _unity_self, [IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType); // 0x00000001867372A0-0x0000000186737300
		private static int GetEntityTypeCount_Injected(ref EntityManager _unity_self); // 0x0000000185D1A650-0x0000000185D1A690
		private static uint GetEntityContainerSize_Injected(ref EntityManager _unity_self); // 0x000000018593A9E0-0x000000018593AA20
		private static void GarbageCollect_Injected(ref EntityManager _unity_self); // 0x0000000186114360-0x00000001861143A0
	}

	[IsReadOnly]
	public struct GroupType // TypeDefIndex: 87987
	{
		// Fields
		private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
	
		// Constructors
		internal unsafe GroupType(EntityTypeInstanceData* types); // 0x000000018561B5B0-0x000000018561B5C0
	
		// Methods
		public int Size(); // 0x00000001878344E8-0x0000000187834504
		public bool HasComponent<T>()
			where T : struct, IComponentECS;
		public unsafe T* GetComponent<T>()
			where T : struct, IComponentECS;
		public unsafe byte* GetComponentPtr(int componentId); // 0x000000018D522170-0x000000018D5222C4
		public NativeArray<T> GetComponentAsArray<T>()
			where T : struct, IComponentECS;
		public unsafe Entity* GetEntities(); // 0x00000001878344CC-0x00000001878344E8
		public ComponentMask GetComponentMaskAll(); // 0x000000018D522148-0x000000018D522170
		public NativeArray<Entity> GetEntitiesAsArray(); // 0x0000000186235E60-0x0000000186235EB0
	}

	[IsReadOnly]
	public struct EntityManagerRange : IEnumerable<GroupType> // TypeDefIndex: 87989
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
		private readonly ComponentMask m_componentMask; // 0x08
		private readonly ComponentMask m_excludeComponentMask; // 0x18
		private readonly ComponentMask m_anyComponentMask; // 0x28
		private readonly int m_count; // 0x38
	
		// Nested types
		[ExcludeFromDocs]
		public struct Enumerator : IEnumerator<GroupType> // TypeDefIndex: 87988
		{
			// Fields
			private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
			private readonly int m_count; // 0x08
			private ComponentMask m_includeComponentMask; // 0x10
			private ComponentMask m_excludedComponentMask; // 0x20
			private ComponentMask m_anyComponentMask; // 0x30
			private int m_index; // 0x40
	
			// Properties
			public GroupType Current { get; } // 0x0000000187261D70-0x0000000187261D80 
			object IEnumerator.Current { get; } // 0x000000018D521804-0x000000018D521854 
	
			// Constructors
			internal unsafe Enumerator(EntityTypeInstanceData* entityTypes, int count, [IsReadOnly] in ComponentMask includeComponentMask, [IsReadOnly] in ComponentMask excludeComponentMask, [IsReadOnly] in ComponentMask anyComponentMask); // 0x0000000187261D40-0x0000000187261D70
	
			// Methods
			public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			public bool MoveNext(); // 0x0000000184FA5620-0x0000000184FA56D0
			public void Reset(); // 0x000000018723C990-0x000000018723C9A0
		}
	
		// Constructors
		internal unsafe EntityManagerRange(EntityTypeInstanceData* entityTypes, int count, ref ComponentMask componentMask); // 0x0000000187261C10-0x0000000187261C30
		internal unsafe EntityManagerRange(EntityTypeInstanceData* entityTypes, int count, ref ComponentMask includeComponentMask, ref ComponentMask excludeComponentMask); // 0x0000000184FA5AD0-0x0000000184FA5B40
	
		// Methods
		public Enumerator GetEnumerator(); // 0x0000000185965AB0-0x0000000185965B10
		IEnumerator<GroupType> IEnumerable<GroupType>.GetEnumerator(); // 0x000000018D521244-0x000000018D5212C4
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D5212C4-0x000000018D521344
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGEntityDelayedOperationSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetEntityDelayedOperationSystem()", StaticAccessorType.Dot)]
	public static class HGEntityDelayedOperationSystem // TypeDefIndex: 87990
	{
		// Methods
		public static void RemoveEntity(Entity entity); // 0x000000018D522AA4-0x000000018D522AC0
		private static void RemoveEntity_Injected(ref Entity entity); // 0x000000018D522A70-0x000000018D522AA4
	}
}

namespace UnityEngine.HyperGryph.Streaming
{
	public struct StreamingAssetData // TypeDefIndex: 87886
	{
		// Fields
		public long assetHashV2; // 0x00
		public AssetType assetType; // 0x08
	
		// Methods
		public bool Equals(StreamingAssetData other); // 0x0000000184539570-0x0000000184539590
		public override bool Equals(object obj); // 0x000000018D5261F0-0x000000018D526268
		public override int GetHashCode(); // 0x000000018725FD00-0x000000018725FD10
	}

	public struct PropertySerializeId // TypeDefIndex: 87887
	{
		// Fields
		public uint componentIndex; // 0x00
		public uint propertyId; // 0x04
		public uint subPropertyIndex; // 0x08
	
		// Constructors
		public PropertySerializeId(StreamingComponentType componentType, uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x02647CE5 */); // 0x00000001866C5F30-0x00000001866C5F70
		public PropertySerializeId(uint componentIndex, uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x02647CE6 */); // 0x0000000187232A60-0x0000000187232A70
		public PropertySerializeId(uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x02647CE7 */); // 0x0000000187261DA0-0x0000000187261DB0
	
		// Methods
		public static implicit operator PropertySerializeId(uint propertyId); // 0x0000000187261DE0-0x0000000187261E10
		public static uint GetComponentIndexFromType(StreamingComponentType componentType); // 0x00000001866C5F70-0x00000001866C5FB0
		public override int GetHashCode(); // 0x000000018D5261E8-0x000000018D5261F0
		public uint EncodeSerializeIdentifier(); // 0x000000018D526184-0x000000018D5261E8
		public static PropertySerializeId operator +(PropertySerializeId a, uint subIndex); // 0x0000000187261DB0-0x0000000187261DE0
		public static PropertySerializeId operator +(PropertySerializeId a, int subIndex); // 0x0000000185ED1A30-0x0000000185ED1A80
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/FlatBufferConvertContext.bindings.h")]
	public struct FlatBufferConvertContextV2 // TypeDefIndex: 87888
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Properties
		public uint sceneScopeId { get; } // 0x0000000187838F54-0x0000000187838F60 
		public uint sceneScopeRegionHandle { get; } // 0x000000018783B160-0x000000018783B168 
		public bool sceneScopeIsDev { get; } // 0x000000018783B158-0x000000018783B160 
		public int componentScopeSerializeVersion { get; } // 0x0000000184F6FAB0-0x0000000184F6FB00 
	
		// Methods
		public bool TryEnqueueAssetForAsyncLoad(PropertySerializeId propertySerializeId); // 0x000000018783B17C-0x000000018783B190
		public void AddExternalAssetForAsyncLoad(long assetHash, AssetType assetType, AssetHandleIndex assetHandleIndex); // 0x000000018D5218B8-0x000000018D5218DC
		private UnityEngine.Object ConvertAssetFromImpl(PropertySerializeId propertySerializeId); // 0x000000018783BCE8-0x000000018783BCFC
		private IntPtr ConvertPropertyPtrFromImpl(PropertySerializeId propertySerializeId); // 0x000000018783BDB4-0x000000018783BDC8
		private void ConvertPropertyDataFromBytesImpl(PropertySerializeId propertySerializeId, out IntPtr data, out int size); // 0x0000000187838F3C-0x0000000187838F54
		public string ConvertStringFrom(PropertySerializeId propertySerializeId); // 0x000000018783B168-0x000000018783B17C
		public bool TryConvertAssetFrom<T>(PropertySerializeId propertySerializeId, out ref T asset)
			where T : UnityEngine.Object;
		public T ConvertPropertyFrom<T>(PropertySerializeId propertySerializeId)
			where T : struct;
		public T ConvertPropertyFromBytes<T>(PropertySerializeId propertySerializeId)
			where T : struct;
		public NativeArray<byte> ConvertPropertyFromBytes(PropertySerializeId propertySerializeId); // 0x000000018D5218DC-0x000000018D5219A4
		private static uint get_sceneScopeId_Injected(ref FlatBufferConvertContextV2 _unity_self); // 0x0000000186777300-0x0000000186777340
		private static uint get_sceneScopeRegionHandle_Injected(ref FlatBufferConvertContextV2 _unity_self); // 0x0000000187218FE0-0x0000000187219020
		private static bool get_sceneScopeIsDev_Injected(ref FlatBufferConvertContextV2 _unity_self); // 0x0000000187219020-0x0000000187219060
		private static int get_componentScopeSerializeVersion_Injected(ref FlatBufferConvertContextV2 _unity_self); // 0x0000000184F6FAB0-0x0000000184F6FB00
		private static bool TryEnqueueAssetForAsyncLoad_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId); // 0x0000000186585B20-0x0000000186585B70
		private static void AddExternalAssetForAsyncLoad_Injected(ref FlatBufferConvertContextV2 _unity_self, long assetHash, AssetType assetType, ref AssetHandleIndex assetHandleIndex); // 0x000000018D521854-0x000000018D5218B8
		private static UnityEngine.Object ConvertAssetFromImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId); // 0x000000018626CA00-0x000000018626CAC0
		private static IntPtr ConvertPropertyPtrFromImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId); // 0x0000000186300250-0x00000001863002A0
		private static void ConvertPropertyDataFromBytesImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId, out IntPtr data, out int size); // 0x00000001866C39D0-0x00000001866C3A40
		private static string ConvertStringFrom_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId); // 0x00000001871CB280-0x00000001871CB2D0
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingGameplayManager.binding.h")]
	public struct StreamingGameplayManager // TypeDefIndex: 87889
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Methods
		public void Create(StreamingSceneParameter parameter); // 0x000000018D526304-0x000000018D526318
		public void Destroy(); // 0x000000018D52634C-0x000000018D526354
		public uint AllocateRuntimeChunk(string initBasePath, string streamingBasePath); // 0x000000018D526268-0x000000018D526270
		public uint CreateEntityGroupAndLoad(uint chunkId, int blobIndex); // 0x0000000187835628-0x0000000187835630
		public void LoadGroup(uint groupHandle); // 0x000000018D526418-0x000000018D526420
		public bool IsGroupReady(uint groupId); // 0x000000018D5263D0-0x000000018D5263D8
		public uint CreateGroupAndLoadWaitBeforeShow(uint chunkId, int blobIndex); // 0x000000018D5262FC-0x000000018D526304
		public void StopGroupWait(uint groupId); // 0x000000018D526460-0x000000018D526468
		public void UnloadGroup(uint groupId, bool imm); // 0x000000018783C058-0x000000018783C060
		public void DestroyGroup(uint groupId); // 0x000000018783BBA8-0x000000018783BBB0
		public bool IsGroupLoaded(uint groupId); // 0x000000018783640C-0x0000000187836448
		public bool IsGroupUnloaded(uint groupId); // 0x000000018783BBA0-0x000000018783BBA8
		public void Tick(int budget); // 0x0000000187835EB0-0x0000000187835EB8
		public void TickResource(); // 0x0000000187835EA8-0x0000000187835EB0
		public void Clear(); // 0x000000018D5262A4-0x000000018D5262AC
		public bool IsIdle(); // 0x000000018783BED8-0x000000018783BEE0
		public bool IsValid(); // 0x00000001853AE700-0x00000001853AE710
		public void SetNeedLodTransition(bool needTransition); // 0x000000018783C354-0x000000018783C35C
		public bool GetNeedLodTransition(); // 0x000000018D526388-0x000000018D526390
		private static void Create_Injected(ref StreamingGameplayManager _unity_self, ref StreamingSceneParameter parameter); // 0x00000001871F9C50-0x00000001871F9CA0
		private static void Destroy_Injected(ref StreamingGameplayManager _unity_self); // 0x000000018D526318-0x000000018D52634C
		private static uint AllocateRuntimeChunk_Injected(ref StreamingGameplayManager _unity_self, string initBasePath, string streamingBasePath); // 0x00000001869B2A50-0x00000001869B2AB0
		private static uint CreateEntityGroupAndLoad_Injected(ref StreamingGameplayManager _unity_self, uint chunkId, int blobIndex); // 0x00000001865AE4E0-0x00000001865AE540
		private static void LoadGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupHandle); // 0x000000018D5263D8-0x000000018D526418
		private static bool IsGroupReady_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x000000018D526390-0x000000018D5263D0
		private static uint CreateGroupAndLoadWaitBeforeShow_Injected(ref StreamingGameplayManager _unity_self, uint chunkId, int blobIndex); // 0x000000018D5262AC-0x000000018D5262FC
		private static void StopGroupWait_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x000000018D526420-0x000000018D526460
		private static void UnloadGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupId, bool imm); // 0x00000001863B3DF0-0x00000001863B3E50
		private static void DestroyGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x00000001861F3810-0x00000001861F3860
		private static bool IsGroupLoaded_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x0000000185E67E70-0x0000000185E67EC0
		private static bool IsGroupUnloaded_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x00000001861F3860-0x00000001861F38B0
		private static void Tick_Injected(ref StreamingGameplayManager _unity_self, int budget); // 0x00000001864DAE90-0x00000001864DAEE0
		private static void TickResource_Injected(ref StreamingGameplayManager _unity_self); // 0x0000000186291E90-0x0000000186291ED0
		private static void Clear_Injected(ref StreamingGameplayManager _unity_self); // 0x000000018D526270-0x000000018D5262A4
		private static bool IsIdle_Injected(ref StreamingGameplayManager _unity_self); // 0x00000001863523D0-0x0000000186352410
		private static void SetNeedLodTransition_Injected(ref StreamingGameplayManager _unity_self, bool needTransition); // 0x0000000186530D70-0x0000000186530DC0
		private static bool GetNeedLodTransition_Injected(ref StreamingGameplayManager _unity_self); // 0x000000018D526354-0x000000018D526388
	}

	[Flags]
	public enum StreamingComponentType : ulong // TypeDefIndex: 87890
	{
		None = 0,
		Transform = 1,
		MeshFilter = 2,
		MeshRenderer = 4,
		LODGroup = 8,
		BoxCollider = 16,
		MeshCollider = 32,
		Count = 45,
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
		HGStreamingVolume = 17179869184,
		FakeFogSimple = 34359738368,
		VLB = 68719476736,
		HGWaterDecal = 137438953472,
		VFXFakeVolumeFog = 274877906944,
		HGTimeOfDayEnvironmentVolume = 549755813888,
		HGVolumetricCloud = 1099511627776,
		HGTree = 2199023255552,
		HGGPUParticleSystem = 4398046511104,
		HGTerrainV3 = 8796093022208,
		HGTerrainSurfTypeDataV3 = 17592186044416
	}

	public enum StreamingLayer : byte // TypeDefIndex: 87891
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
		RendererWithCollider = 10,
		Count = 11
	}

	public enum EntityTransition : byte // TypeDefIndex: 87892
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

	public enum StreamingMode : byte // TypeDefIndex: 87893
	{
		Stream = 0,
		Pause = 1,
		Teleport = 2,
		Unload = 3,
		TeleportUnload = 4,
		TeleportLoad = 5
	}

	[Flags]
	public enum StreamingStatus : byte // TypeDefIndex: 87894
	{
		Idle = 0,
		Loading = 1,
		Unloading = 2,
		Empty = 4
	}

	public struct StreamingSceneParameter // TypeDefIndex: 87895
	{
		// Fields
		public string mapName; // 0x00
		public uint regionHandle; // 0x08
		public GameObject streamingRootObject; // 0x10
		public string streamingDataPathRoot; // 0x18
		public bool isDev; // 0x20
	}

	public enum GridStatus : byte // TypeDefIndex: 87896
	{
		Loading = 0,
		Loaded = 1,
		Unloading = 2,
		Unloaded = 3,
		NotExist = 4
	}

	public struct GridIdentifier // TypeDefIndex: 87897
	{
		// Fields
		public Vector2Int pos; // 0x00
		public int sceneStateId; // 0x08
		public int areaId; // 0x0C
		public StreamingLayer layer; // 0x10
	
		// Constructors
		public GridIdentifier(StreamingLayer layer, int sceneStateId, int areaId, Vector2Int pos); // 0x0000000187261D80-0x0000000187261DA0
	
		// Methods
		public override int GetHashCode(); // 0x00000001862AF400-0x00000001862AF420
	}

	public struct StreamingSourceData // TypeDefIndex: 87900
	{
		// Fields
		public Vector2 streamingPos; // 0x00
		public float chunkLoadRadius; // 0x08
		public unsafe fixed /* 0x00000000-0x00000000 */ float layerLoadRadius[0]; // 0x0C
		public unsafe fixed /* 0x00000000-0x00000000 */ byte layerEnabledInDefaultArea[0]; // 0x38
		public static readonly StreamingSourceData kInvalid; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _layerLoadRadius_e__FixedBuffer // TypeDefIndex: 87898
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _layerEnabledInDefaultArea_e__FixedBuffer // TypeDefIndex: 87899
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		static StreamingSourceData(); // 0x0000000187186A90-0x0000000187186B20
	
		// Methods
		public float GetGridLoadRadius(int layerIndex); // 0x0000000187261E10-0x0000000187261E20
	}

	public enum ECSEntityType : byte // TypeDefIndex: 87901
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
		HGStreamingVolume = 12,
		WaterDecal = 13,
		HGWindMotor = 14,
		Light = 15,
		TypeCount = 16
	}

	public enum ProxyEntityType : byte // TypeDefIndex: 87902
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
		TreeGrid = 9,
		GPUParticleSystem = 10,
		TerrainSurfaceTypeDataV3 = 11,
		TypeCount = 12
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingScene.bindings.h")]
	public struct StreamingSceneV2 // TypeDefIndex: 87903
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Properties
		public StreamingMode streamingMode { get; set; } // 0x000000018D5265C0-0x000000018D5265C8 0x000000018D5265E4-0x000000018D5265EC
		public StreamingSourceData primaryStreamingSourceData { get; set; } // 0x0000000185577A80-0x0000000185577AF0 0x000000018D5265D0-0x000000018D5265E4
		public StreamingSourceData secondaryStreamingSourceData { set; } // 0x000000018783D5CC-0x000000018783D5E0
		public float streamingProgress { get; } // 0x000000018D5265C8-0x000000018D5265D0 
	
		// Methods
		public void Create(StreamingSceneParameter parameter); // 0x000000018783ABE4-0x000000018783ABF8
		public void Destroy(); // 0x000000018D52649C-0x000000018D5264A4
		public void UnloadImmediately(); // 0x000000018D526584-0x000000018D52658C
		public StreamingStatus QueryStreamingStatus(); // 0x000000018D526548-0x000000018D526550
		public void SetArea(int areaId, bool enabled); // 0x0000000187835630-0x0000000187835638
		public void SetSceneState(int sceneStateId, bool enabled); // 0x000000018783AC00-0x000000018783AC08
		public void UpdateNeedProcessChunkGridSet(); // 0x000000018783ABF8-0x000000018783AC00
		private GridStatus QueryGridLoadStatusImpl(StreamingLayer layer, int sceneStateId, int areaId, Vector2 queryPos); // 0x00000001878369D4-0x00000001878369F8
		private GridStatus QueryGridLoadStatusByGridIdentifierImpl(GridIdentifier gridIdentifier); // 0x000000018D5264E8-0x000000018D5264FC
		public bool IsValid(); // 0x00000001878369F8-0x0000000187836A00
		public GridStatus QueryGridLoadStatus(StreamingLayer layer, Vector2 queryPos); // 0x000000018D526524-0x000000018D526548
		public GridStatus QueryGridLoadStatus(GridIdentifier gridIdentifier); // 0x000000018D5264FC-0x000000018D526524
		private static void Create_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSceneParameter parameter); // 0x0000000185DED080-0x0000000185DED0D0
		private static void Destroy_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018D526468-0x000000018D52649C
		private static void UnloadImmediately_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018D526550-0x000000018D526584
		private static StreamingStatus QueryStreamingStatus_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018654AED0-0x000000018654AF10
		private static void SetArea_Injected(ref StreamingSceneV2 _unity_self, int areaId, bool enabled); // 0x0000000186AAD120-0x0000000186AAD180
		private static void SetSceneState_Injected(ref StreamingSceneV2 _unity_self, int sceneStateId, bool enabled); // 0x0000000186E1AD90-0x0000000186E1ADF0
		private static void UpdateNeedProcessChunkGridSet_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018716D330-0x000000018716D370
		private static GridStatus QueryGridLoadStatusImpl_Injected(ref StreamingSceneV2 _unity_self, StreamingLayer layer, int sceneStateId, int areaId, ref Vector2 queryPos); // 0x0000000185E07370-0x0000000185E073E0
		private static GridStatus QueryGridLoadStatusByGridIdentifierImpl_Injected(ref StreamingSceneV2 _unity_self, ref GridIdentifier gridIdentifier); // 0x000000018D5264A4-0x000000018D5264E8
		private static StreamingMode get_streamingMode_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018D52658C-0x000000018D5265C0
		private static void set_streamingMode_Injected(ref StreamingSceneV2 _unity_self, StreamingMode value); // 0x0000000186F8D670-0x0000000186F8D6C0
		private static void get_primaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, out StreamingSourceData ret); // 0x0000000185577AF0-0x0000000185577B40
		private static void set_primaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSourceData value); // 0x0000000186252C60-0x0000000186252CB0
		private static void set_secondaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSourceData value); // 0x0000000186DD7D40-0x0000000186DD7D90
		private static float get_streamingProgress_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018654B180-0x000000018654B1C0
		private static bool IsValid_Injected(ref StreamingSceneV2 _unity_self); // 0x0000000185FFB0C0-0x0000000185FFB100
	}

	public delegate void ECSEntityHasRequiredComponentsDelegate(); // TypeDefIndex: 87904; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void ECSEntityConvertToDelegate(); // TypeDefIndex: 87905; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void ProxyEntityHasRequiredComponentsDelegate(); // TypeDefIndex: 87906; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void ProxyEntityConvertToDelegate(); // TypeDefIndex: 87907; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void MonoIsConvertorOfComponentDelegate(); // TypeDefIndex: 87908; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void MonoComponentConvertToDelegate(); // TypeDefIndex: 87909; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void LensFlareComponentSRPECSExportDelegate(); // TypeDefIndex: 87910; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool ECSEntityConvertFromDelegate(Entity entity, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 87911; 0x000000018662DAD0-0x000000018662DB20

	public delegate bool ProxyEntityConvertFromDelegate(ref IntPtr proxyPtr, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 87912; 0x00000001866D9E20-0x00000001866D9E70

	public delegate bool MonoComponentConvertFromDelegate(Component component, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 87913; 0x00000001869F2950-0x00000001869F29A0

	public delegate Component MonoComponentAddComponentToDelegate(GameObject gameObject); // TypeDefIndex: 87914; 0x0000000186C3D730-0x0000000186C3D850

	public delegate Component MonoComponentGetComponentFromDelegate(GameObject gameObject, int multiComponentIndex); // TypeDefIndex: 87915; 0x0000000186B0DC70-0x0000000186B0DD70

	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingSceneManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetHGStreamingSceneManager()", StaticAccessorType.Dot)]
	public static class HGStreamingSceneManager // TypeDefIndex: 87916
	{
		// Properties
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static int streamingVersion { [NativeName("GetStreamingSerializeCodeVersion")] get; } // 0x000000018521AFF0-0x000000018521B030 
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static int streamingChunkSize { [NativeName("GetStreamingChunkSize")] get; } // 0x0000000186C1BFE0-0x0000000186C1C020 
		private static IntPtr streamingScenesManaged { get; } // 0x000000018D525138-0x000000018D525164 
		private static int streamingSceneCount { get; } // 0x000000018D52510C-0x000000018D525138 
	
		// Methods
		public static void BindECSEntityConvertFuncFromScript(ECSEntityType entityType, ECSEntityHasRequiredComponentsDelegate hasRequiredComponentsDelegate, ECSEntityConvertToDelegate convertToDelegate, ECSEntityConvertFromDelegate convertFromFunc); // 0x00000001869165D0-0x0000000186916640
		public static void ResetECSEntityConvertFuncFromScript(ECSEntityType entityType); // 0x000000018D525010-0x000000018D525044
		public static bool IsECSEntityConvertFuncValid(ECSEntityType entityType); // 0x0000000186916590-0x00000001869165D0
		public static void BindProxyEntityConvertFuncFromScript(ProxyEntityType entityType, ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, ProxyEntityConvertToDelegate convertToFunc, ProxyEntityConvertFromDelegate convertFromFunc); // 0x0000000186916480-0x00000001869164F0
		public static void ResetProxyEntityConvertFuncFromScript(ProxyEntityType entityType); // 0x000000018D5250A4-0x000000018D5250D8
		public static bool IsProxyEntityConvertFuncValid(ProxyEntityType entityType); // 0x0000000186916440-0x0000000186916480
		public static void BindMonoComponentConvertFuncFromScript(StreamingComponentType componentType, MonoIsConvertorOfComponentDelegate isConvertorOfFunc, MonoComponentConvertToDelegate convertToFunc, MonoComponentConvertFromDelegate convertFromFunc, MonoComponentAddComponentToDelegate addComponentToFunc, MonoComponentGetComponentFromDelegate getComponentFromFunc); // 0x0000000186916330-0x00000001869163A0
		public static void ResetMonoComponentConvertFuncFromScript(StreamingComponentType componentType); // 0x000000018D525070-0x000000018D5250A4
		public static bool IsMonoComponentConvertFuncValid(StreamingComponentType componentType); // 0x00000001869162F0-0x0000000186916330
		public static void BindLensFlareComponentSRPECSExportFuncFromScript(LensFlareComponentSRPECSExportDelegate exportFunc); // 0x0000000186916790-0x00000001869167D0
		public static void ResetLensFlareComponentSRPECSExportFuncFromScript(); // 0x000000018D525044-0x000000018D525070
		public static bool IsLensFlareComponentSRPECSExportFuncValid(); // 0x0000000186916750-0x0000000186916790
		public static void BindProxyEntityConvertToFuncFromScript(ProxyEntityType entityType, ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, ProxyEntityConvertToDelegate convertToFunc); // 0x0000000186916640-0x00000001869166A0
		public static void ResetProxyEntityConvertToFuncFromScript(ProxyEntityType entityType); // 0x000000018D5250D8-0x000000018D52510C
		public static NativeArray<StreamingSceneV2> GetStreamingScenesArray(); // 0x000000018D524F94-0x000000018D525010
	}

	public struct StreamingLayerConfig // TypeDefIndex: 87917
	{
		// Fields
		public bool enabled; // 0x00
		public StreamingLayer layer; // 0x01
		public bool chunkLoad; // 0x02
		public int gridSize; // 0x04
		public int priority; // 0x08
	}

	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingSettings.h")]
	[StaticAccessor("HyperGryph::HGStreamingSettings", StaticAccessorType.DoubleColon)]
	public static class HGStreamingSettings // TypeDefIndex: 87918
	{
		// Properties
		public static float loadDirtyDistance { set; } // 0x0000000185E63220-0x0000000185E63270
		public static float unloadDirtyDistance { set; } // 0x0000000185E63270-0x0000000185E632C0
		public static float loadElapsedMsPerFrame { set; } // 0x0000000185E632C0-0x0000000185E63310
		public static float unloadElapsedMsPerFrame { set; } // 0x0000000185E63310-0x0000000185E63360
		public static bool sequentialUnloadBeforeLoad { set; } // 0x000000018D525164-0x000000018D525198
	
		// Methods
		public static void SetLayerConfig(StreamingLayer layer, StreamingLayerConfig config); // 0x000000018783CA10-0x000000018783CA24
		private static void SetLayerConfig_Injected(StreamingLayer layer, ref StreamingLayerConfig config); // 0x00000001869166A0-0x00000001869166F0
	}
}
