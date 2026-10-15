/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 64: UnityEngine.HGGraphicsCPPModule.dll - Assembly: UnityEngine.HGGraphicsCPPModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89081-89260

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 89082
	{
		// Constructors
		public EmbeddedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 89083
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 89084
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.HyperGryphEngineCode
{
	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeatureCPP // TypeDefIndex: 89085
	{
		// Fields
		public bool enabled; // 0x00
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeatureCPP_float // TypeDefIndex: 89086
	{
		// Fields
		public bool overriding; // 0x00
		public float value; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeatureCPP_int // TypeDefIndex: 89087
	{
		// Fields
		public bool overriding; // 0x00
		public int value; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeatureCPP_bool // TypeDefIndex: 89088
	{
		// Fields
		public bool overriding; // 0x00
		public bool value; // 0x01
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeaturesManagerCPP // TypeDefIndex: 89089
	{
		// Fields
		public HGDebugFeatureCPP cppRenderPath; // 0x00
		public HGDebugFeatureCPP uiCamValidation; // 0x01
		public HGDebugFeatureCPP shadows; // 0x02
		public HGDebugFeatureCPP csm; // 0x03
		public HGDebugFeatureCPP asmShadow; // 0x04
		public HGDebugFeatureCPP cloudShadow; // 0x05
		public HGDebugFeatureCPP rhodesShipCsm; // 0x06
		public HGDebugFeatureCPP characterShadow; // 0x07
		public HGDebugFeatureCPP punctualLightShadow; // 0x08
		public HGDebugFeatureCPP hdplsCharacterShadow; // 0x09
		public HGDebugFeatureCPP contactShadow; // 0x0A
		public HGDebugFeatureCPP shadowDecalProjector; // 0x0B
		public HGDebugFeatureCPP_float csmFarDistance; // 0x0C
		public HGDebugFeatureCPP_int csmCascadeCount; // 0x14
		public HGDebugFeatureCPP_int punctualLightShadowResolution; // 0x1C
		public HGDebugFeatureCPP_int directionalShadowResolution; // 0x24
		public HGDebugFeatureCPP_int characterShadowResolution; // 0x2C
		public HGDebugFeatureCPP shadowNoAlphaTest; // 0x34
		public HGDebugFeatureCPP shadowProxy; // 0x35
		public HGDebugFeatureCPP visibilitySH; // 0x36
		public HGDebugFeatureCPP mergeShadowCullingView; // 0x37
		public HGDebugFeatureCPP_float cullingViewScreenSizeMin; // 0x38
		public HGDebugFeatureCPP_float shadowViewScreenSizeMin; // 0x40
		public HGDebugFeatureCPP_float fogCullingFarClipPlane; // 0x48
		public HGDebugFeatureCPP occlusionCulling; // 0x50
		public HGDebugFeatureCPP_bool occlusionCullingCSM; // 0x51
		public HGDebugFeatureCPP hizCulling; // 0x53
		public HGDebugFeatureCPP optimizedChunkCulling; // 0x54
		public HGDebugFeatureCPP_float ocScreenSizeMin; // 0x58
		public HGDebugFeatureCPP_int ocPerformanceRenderMode; // 0x60
		public HGDebugFeatureCPP lodDither; // 0x68
		public HGDebugFeatureCPP skipAllDrawCommands; // 0x69
		public HGDebugFeatureCPP keepDisabledPassCPUUsages; // 0x6A
		public HGDebugFeatureCPP skipRender; // 0x6B
		public HGDebugFeatureCPP preZ; // 0x6C
		public HGDebugFeatureCPP deferred; // 0x6D
		public HGDebugFeatureCPP characterPrePass; // 0x6E
		public HGDebugFeatureCPP customDepthPass; // 0x6F
		public HGDebugFeatureCPP deferredOpaque; // 0x70
		public HGDebugFeatureCPP deferredOpaquePreZ; // 0x71
		public HGDebugFeatureCPP deferredOpaqueEqual; // 0x72
		public HGDebugFeatureCPP deferredGrassPreZ; // 0x73
		public HGDebugFeatureCPP deferredGrass; // 0x74
		public HGDebugFeatureCPP deferredTreePreZ; // 0x75
		public HGDebugFeatureCPP deferredTree; // 0x76
		public HGDebugFeatureCPP deferredDecal; // 0x77
		public HGDebugFeatureCPP deferredErosion; // 0x78
		public HGDebugFeatureCPP deferredSludge; // 0x79
		public HGDebugFeatureCPP deferredSludgeDecal; // 0x7A
		public HGDebugFeatureCPP forward; // 0x7B
		public HGDebugFeatureCPP skipForwardTransparent; // 0x7C
		public HGDebugFeatureCPP forwardTransparent; // 0x7D
		public HGDebugFeatureCPP forwardOpaque; // 0x7E
		public HGDebugFeatureCPP forwardOpaquePreZ; // 0x7F
		public HGDebugFeatureCPP forwardOpaqueEqual; // 0x80
		public HGDebugFeatureCPP forwardDecal; // 0x81
		public HGDebugFeatureCPP forwardCharacter; // 0x82
		public HGDebugFeatureCPP characterOutlineOpaque; // 0x83
		public HGDebugFeatureCPP characterOutlineOpaquePreZ; // 0x84
		public HGDebugFeatureCPP characterOutlineOpaqueEqual; // 0x85
		public HGDebugFeatureCPP vfxDecal; // 0x86
		public HGDebugFeatureCPP distortion; // 0x87
		public HGDebugFeatureCPP distortionOpaque; // 0x88
		public HGDebugFeatureCPP distortionTransparent; // 0x89
		public HGDebugFeatureCPP UI; // 0x8A
		public HGDebugFeatureCPP UISprite; // 0x8B
		public HGDebugFeatureCPP UIWorld; // 0x8C
		public HGDebugFeatureCPP UIDistorion; // 0x8D
		public HGDebugFeatureCPP UIFrostedGlass; // 0x8E
		public HGDebugFeatureCPP_float chunkLoadRadius; // 0x90
		public HGDebugFeatureCPP_float defaultLayerLoadRadius; // 0x98
		public HGDebugFeatureCPP_float hlod0LayerLoadRadius; // 0xA0
		public HGDebugFeatureCPP_float hlod1LayerLoadRadius; // 0xA8
		public HGDebugFeatureCPP_float hlod2LayerLoadRadius; // 0xB0
		public HGDebugFeatureCPP_float colliderLayerLoadRadius; // 0xB8
		public HGDebugFeatureCPP_float tinyLayerLoadRadius; // 0xC0
		public HGDebugFeatureCPP deferredShading; // 0xC8
		public HGDebugFeatureCPP deferredShadingDefaultLit; // 0xC9
		public HGDebugFeatureCPP deferredShadingTwoSidedFoliage; // 0xCA
		public HGDebugFeatureCPP deferredShadingSubsurface; // 0xCB
		public HGDebugFeatureCPP splitDeferredShadingStage; // 0xCC
		public HGDebugFeatureCPP usePerLightDynamicLighting; // 0xCD
		public HGDebugFeatureCPP deferredShadingDirectionalLightStage; // 0xCE
		public HGDebugFeatureCPP deferredShadingDynamicLightStage; // 0xCF
		public HGDebugFeatureCPP deferredShadingIndirectStage; // 0xD0
		public HGDebugFeatureCPP deferredShadingForceSplitOnePass; // 0xD1
		public HGDebugFeatureCPP usePerTileDeferredLighting; // 0xD2
		public HGDebugFeatureCPP directionalLight; // 0xD3
		public HGDebugFeatureCPP punctualLights; // 0xD4
		public HGDebugFeatureCPP_int punctualLightsMaxCount; // 0xD8
		public HGDebugFeatureCPP irradianceVolume; // 0xE0
		public HGDebugFeatureCPP irradianceVolumeSample; // 0xE1
		public HGDebugFeatureCPP gtao; // 0xE2
		public HGDebugFeatureCPP irradianceVolumeV2; // 0xE3
		public HGDebugFeatureCPP irradianceVolumeV3; // 0xE4
		public HGDebugFeatureCPP fallenLeaves; // 0xE5
		public HGDebugFeatureCPP postProcess; // 0xE6
		public HGDebugFeatureCPP lightShaft; // 0xE7
		public HGDebugFeatureCPP bloom; // 0xE8
		public HGDebugFeatureCPP vignette; // 0xE9
		public HGDebugFeatureCPP radialBlur; // 0xEA
		public HGDebugFeatureCPP chromaticAbberation; // 0xEB
		public HGDebugFeatureCPP dirtyLens; // 0xEC
		public HGDebugFeatureCPP toneMapping; // 0xED
		public HGDebugFeatureCPP sharpen; // 0xEE
		public HGDebugFeatureCPP autoExposure; // 0xEF
		public HGDebugFeatureCPP motionBlur; // 0xF0
		public HGDebugFeatureCPP frostedGlass; // 0xF1
		public HGDebugFeatureCPP lensFlare; // 0xF2
		public HGDebugFeatureCPP anamorphicStreaks; // 0xF3
		public HGDebugFeatureCPP depthOfField; // 0xF4
		public HGDebugFeatureCPP_int depthOfFieldQuality; // 0xF8
		public HGDebugFeatureCPP_float depthOfFieldScale; // 0x100
		public HGDebugFeatureCPP_float depthOfFieldMaxRadius; // 0x108
		public HGDebugFeatureCPP depthOfFieldDebug; // 0x110
		public HGDebugFeatureCPP fog; // 0x111
		public HGDebugFeatureCPP atmosphereFog; // 0x112
		public HGDebugFeatureCPP heightFog; // 0x113
		public HGDebugFeatureCPP volumetricFog; // 0x114
		public HGDebugFeatureCPP volumetricCloud; // 0x115
		public HGDebugFeatureCPP ssr; // 0x116
		public HGDebugFeatureCPP_int ssrRayMarchingSampleCount; // 0x118
		public HGDebugFeatureCPP_bool ssrImportanceSample; // 0x120
		public HGDebugFeatureCPP_bool ssrV2; // 0x122
		public HGDebugFeatureCPP_bool ssrV2Upsample; // 0x124
		public HGDebugFeatureCPP reflectionProbe; // 0x126
		public HGDebugFeatureCPP reflectionProbeNormalization; // 0x127
		public HGDebugFeatureCPP reflectionProbeTextureDebugInfo; // 0x128
		public HGDebugFeatureCPP reflectionProbeSlotDebugInfo; // 0x129
		public HGDebugFeatureCPP reflectionProbeTextureArrayReset; // 0x12A
		public HGDebugFeatureCPP_bool reflectionProbeTextureArrayDebugLog; // 0x12B
		public HGDebugFeatureCPP waterRendering; // 0x12D
		public HGDebugFeatureCPP waterSSROnMobile; // 0x12E
		public HGDebugFeatureCPP waterSector; // 0x12F
		public HGDebugFeatureCPP waterInteraction; // 0x130
		public HGDebugFeatureCPP underWaterWetness; // 0x131
		public HGDebugFeatureCPP waterSectorDebug; // 0x132
		public HGDebugFeatureCPP_bool waterIndirect; // 0x133
		public HGDebugFeatureCPP_float waterCameraFoVInc; // 0x138
		public HGDebugFeatureCPP_float waterCameraPosOffset; // 0x140
		public HGDebugFeatureCPP_float waterDisplacementWeight; // 0x148
		public HGDebugFeatureCPP_float waterDisplacementDistance; // 0x150
		public HGDebugFeatureCPP rain; // 0x158
		public HGDebugFeatureCPP wetness; // 0x159
		public HGDebugFeatureCPP rainWetnessHighQuality; // 0x15A
		public HGDebugFeatureCPP rainOcclusion; // 0x15B
		public HGDebugFeatureCPP rainOcclusionSamplePosJitter; // 0x15C
		public HGDebugFeatureCPP rainSplash; // 0x15D
		public HGDebugFeatureCPP rainLighting; // 0x15E
		public HGDebugFeatureCPP snow; // 0x15F
		public HGDebugFeatureCPP snowLighting; // 0x160
		public HGDebugFeatureCPP snowCollision; // 0x161
		public HGDebugFeatureCPP terrainDeform; // 0x162
		public HGDebugFeatureCPP terrainDeformCCD; // 0x163
		public HGDebugFeatureCPP terrain; // 0x164
		public HGDebugFeatureCPP terrainPreDepth; // 0x165
		public HGDebugFeatureCPP terrainScreenSpace; // 0x166
		public HGDebugFeatureCPP terrainPostGBuffer; // 0x167
		public HGDebugFeatureCPP terrainVTBake; // 0x168
		public HGDebugFeatureCPP terrainIndirectionUpdate; // 0x169
		public HGDebugFeatureCPP terrainDepthPrepass; // 0x16A
		public HGDebugFeatureCPP terrainSimpleSubsurface; // 0x16B
		public HGDebugFeatureCPP terrainSubdivision; // 0x16C
		public HGDebugFeatureCPP terrainSubdivisionV2; // 0x16D
		public HGDebugFeatureCPP terrainSubdivisionHZBCulling; // 0x16E
		public HGDebugFeatureCPP terrainNewEditorRendering; // 0x16F
		public HGDebugFeatureCPP terrainDecalInteraction; // 0x170
		public HGDebugFeatureCPP entity; // 0x171
		public HGDebugFeatureCPP character; // 0x172
		public HGDebugFeatureCPP enemy; // 0x173
		public HGDebugFeatureCPP npc; // 0x174
		public HGDebugFeatureCPP sky; // 0x175
		public HGDebugFeatureCPP skyBox; // 0x176
		public HGDebugFeatureCPP skyCloud; // 0x177
		public HGDebugFeatureCPP skyCelestial; // 0x178
		public HGDebugFeatureCPP skyOctahedron; // 0x179
		public HGDebugFeatureCPP_float grassGlobalSparsity; // 0x17C
		public HGDebugFeatureCPP foliageInteractive; // 0x184
		public HGDebugFeatureCPP foliageOccluder; // 0x185
		public HGDebugFeatureCPP gpuCloth; // 0x186
		public HGDebugFeatureCPP particleLighting; // 0x187
		public HGDebugFeatureCPP_bool shaderLOD; // 0x188
		public HGDebugFeatureCPP_bool shaderLODWhiteKeyword; // 0x18A
		public HGDebugFeatureCPP_bool rayTracingReflectionEnable; // 0x18C
		public HGDebugFeatureCPP_int rayTracingReflectionPlatform; // 0x190
		public HGDebugFeatureCPP rayTracingReflectionGlossy; // 0x198
		public HGDebugFeatureCPP rayTracingReflectionRTOnly; // 0x199
		public HGDebugFeatureCPP rayTracingReflectionDebugVariable; // 0x19A
		public HGDebugFeatureCPP_float rayTracingReflectionSSQuality0; // 0x19C
		public HGDebugFeatureCPP_float rayTracingReflectionSSQuality1; // 0x1A4
		public HGDebugFeatureCPP_float rayTracingReflectionSSQuality2; // 0x1AC
		public HGDebugFeatureCPP_float rayTracingReflectionSSQuality3; // 0x1B4
		public HGDebugFeatureCPP_float rayTracingReflectionRTQuality0; // 0x1BC
		public HGDebugFeatureCPP_float rayTracingReflectionRTQuality1; // 0x1C4
		public HGDebugFeatureCPP_float rayTracingReflectionRTQuality2; // 0x1CC
		public HGDebugFeatureCPP_float rayTracingReflectionRTQuality3; // 0x1D4
		public HGDebugFeatureCPP gpuDriven; // 0x1DC
		public HGDebugFeatureCPP gpuDrivenNoCulling; // 0x1DD
		public HGDebugFeatureCPP gpuDrivenInspection; // 0x1DE
		public HGDebugFeatureCPP_int hzbSizeShiftBits; // 0x1E0
		public HGDebugFeatureCPP_bool gpuParticle; // 0x1E8
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugRenderManagerCPP // TypeDefIndex: 89092
	{
		// Fields
		public bool enableAOVOutput; // 0x00
		public bool enableAOVRenderMatte; // 0x01
		public float ppCompareScaleValue; // 0x04
		public bool enableAlbedoTexelDetection; // 0x08
		public float albedoMinLuminance; // 0x0C
		public float albedoMaxLuminance; // 0x10
		public float baseColorAlpha; // 0x14
		public float checkerSize; // 0x18
		public bool leafBackFaceRed; // 0x1C
		public int triangleCountMin; // 0x20
		public int triangleCountMax; // 0x24
		public bool autoExposureEnabled; // 0x28
		public bool centerMode; // 0x29
		public bool autoModeEnabled; // 0x2A
		public float currentExposureValue; // 0x2C
		public float targetExposureValue; // 0x30
		public float avgLogLuminance; // 0x34
		public float ev100Compensation; // 0x38
		public float directEV100; // 0x3C
		public bool displayPPResult; // 0x40
		public Vector4 overrideBaseColor; // 0x44
		public bool disableNormalMap; // 0x54
		public float debugDisplayEV; // 0x58
		public bool displayPBRColorChart; // 0x5C
		public float debugXRayDistance; // 0x60
		public int compositionFlags; // 0x64
		public int compositionOverlayType; // 0x68
		public float compositionDesaturateStrength; // 0x6C
		public float compositionLineWidthPixels; // 0x70
		public Vector4 compositionLineColor; // 0x74
		public Vector4 compositionFrameLineColor; // 0x84
		public float compositionCrosshairSizePixels; // 0x94
		public float compositionLetterboxAspect; // 0x98
		public float compositionLetterboxOpacity; // 0x9C
		public float compositionFrameAspect; // 0xA0
		public float compositionFrameScale; // 0xA4
		public float compositionFrameOpacity; // 0xA8
		public bool displayIVVoxelSize; // 0xAC
		public bool debugSkyAO; // 0xAD
		public float fetchedAverageQuadOverdraw; // 0xB0
		public bool ignoreZeroValuePixels; // 0xB4
		public int quadOverdrawDetectionMode; // 0xB8
		public bool isQuadOverdrawPreDepthMode; // 0xBC
		public float fetchedAverageLightDensity; // 0xC0
		public bool enableLightDebugger; // 0xC4
		public int visibleLightCount; // 0xC8
		public int visiblePunctualLightCount; // 0xCC
		public int lightsForDebugCount; // 0xD0
		public int lightsRenderingShadowsCount; // 0xD4
		public int lightsBakedCount; // 0xD8
		public IntPtr visibleLights; // 0xE0
		public IntPtr punctualLightIndices; // 0xE8
		public IntPtr lightsForDebug; // 0xF0
		public IntPtr lightsRenderingShadows; // 0xF8
		public IntPtr lightsBaked; // 0x100
		public bool reflectionProbeDebugIncludeWater; // 0x108
		public int reflectionProbeShowTextureIndex; // 0x10C
		public float reflectionProbeShowTextureMip; // 0x110
		public unsafe fixed /* 0x00000000-0x00000000 */ float reflectionProbeFetchedData[0]; // 0x114
		public bool enableShadowDebugger; // 0x124
		public int shadowDebugDataCount; // 0x128
		public IntPtr shadowDebugDataArray; // 0x130
		public Vector2 m_sceneViewSelectionPos; // 0x138
		public unsafe fixed /* 0x00000000-0x00000000 */ float m_fetchedData[0]; // 0x140
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _reflectionProbeFetchedData_e__FixedBuffer // TypeDefIndex: 89090
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _m_fetchedData_e__FixedBuffer // TypeDefIndex: 89091
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public enum FSR3Quality // TypeDefIndex: 89093
	{
		UltraPerformance = 0,
		Performance = 1,
		Balanced = 2,
		Quality = 3,
		NativeAA = 4
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/FSR3/FSR3UpscaleCommon.h")]
	[UsedByNativeCode]
	public struct HGFSR3Util // TypeDefIndex: 89094
	{
		// Methods
		[FreeFunction("IsFSR3Supported")]
		[UsedByNativeCode]
		public static bool IsFSR3Supported(); // 0x00000001854726E0-0x0000000185472720
		[FreeFunction("GetFSR3RenderScale")]
		[UsedByNativeCode]
		public static float GetFSR3RenderScale(FSR3Quality quality); // 0x000000018D521074-0x000000018D52110C
		[FreeFunction("IsFSR3FISupported")]
		[UsedByNativeCode]
		public static bool IsFSR3FISupported(); // 0x00000001854723D0-0x0000000185472410
	}

	[UsedByNativeCode]
	public struct HGVolumetricFogSettingParametersV2 // TypeDefIndex: 89095
	{
		// Fields
		public bool enableVolumetricFog; // 0x00
		public int gridPixelSize; // 0x04
		public int gridSizeZ; // 0x08
		public int maxSourceRTWidth; // 0x0C
		public int maxSourceRTHeight; // 0x10
		public int depthDistributionScale; // 0x14
		public int historyMissSuperSampleCount; // 0x18
		public float fogHistoryWeight; // 0x1C
		public float lightScatteringSampleJitterMultiplier; // 0x20
		public float upsampleJitterMultiplier; // 0x24
		public bool enableTemporalReprojection; // 0x28
		public bool enablePunctualLightShadow; // 0x29
		public bool enableEmissiveVBufferB; // 0x2A
		public bool enableScalarizeDynamicLightLoop; // 0x2B
	}

	[UsedByNativeCode]
	public struct HGAtmosphereSettingParameters // TypeDefIndex: 89096
	{
		// Fields
		public float transmittanceLutSampleCount; // 0x00
		public int transmittanceLutWidth; // 0x04
		public int transmittanceLutHeight; // 0x08
		public float multiScatteredLuminanceLutSampleCount; // 0x0C
		public bool multiScatteredLuminanceLutHighQuality; // 0x10
		public int multiScatteredLuminanceLutWidth; // 0x14
		public int multiScatteredLuminanceLutHeight; // 0x18
		public float skyViewLutSampleCountMin; // 0x1C
		public float skyViewLutSampleCountMax; // 0x20
		public float skyViewLutDistanceToSampleCountMax; // 0x24
		public int skyViewLutWidth; // 0x28
		public int skyViewLutHeight; // 0x2C
		public bool skyAtmosphereLutUseSmallFormat; // 0x30
	}

	[UsedByNativeCode]
	public struct HGSettingParametersCpp // TypeDefIndex: 89098
	{
		// Fields
		public float cullingViewScreenSizeMin; // 0x00
		public float ocScreenSizeMin; // 0x04
		public bool taauEnable; // 0x08
		public int taauQuality; // 0x0C
		public float historyWeight; // 0x10
		public float historyWeightInMotion; // 0x14
		public float fastConvergeHistoryWeight; // 0x18
		public float responsiveAAWeight; // 0x1C
		public float minMotion; // 0x20
		public float maxMotion; // 0x24
		public float characterMotionSensitivity; // 0x28
		public float occlusionDepthDiff; // 0x2C
		public float inputLumaWeight; // 0x30
		public float sharpenStrength1K; // 0x34
		public float sharpenStrength2K; // 0x38
		public float sharpenStrength4K; // 0x3C
		public bool pssrEnable; // 0x40
		public float pssrSharpness; // 0x44
		public bool dlssEnable; // 0x48
		public DLSSQuality dlssQuality; // 0x4C
		public bool dlssUseAutoExposure; // 0x50
		public StreamlineDLSSFGMode dlssFGMode; // 0x54
		public uint dlssFGGenFrames; // 0x58
		public StreamlineReflexMode dlssReflexMode; // 0x5C
		public bool dlssPCLEnable; // 0x60
		public float dlssSharpenStrength; // 0x64
		public bool dlssUseUIHint; // 0x68
		public float dlssUIHintAlphaThreshold; // 0x6C
		public DLSSModel dlssModel; // 0x70
		public bool fsr3Enable; // 0x74
		public bool fsr3UseReaciveAndTCMask; // 0x75
		public FSR3Quality fsr3Quality; // 0x78
		public float fsr3SharpenStrength; // 0x7C
		public bool fsr3UseFP16; // 0x80
		public bool fsr3UseWave; // 0x81
		public bool fsr3UseWave64; // 0x82
		public bool fsr3UseLanczosLut; // 0x83
		public bool fsr3FIEnable; // 0x84
		public BloomQuality bloomQuality; // 0x88
		public bool bloomUseComputeShader; // 0x8C
		public int lutSize; // 0x90
		public GraphicsFormat lutFormat; // 0x94
		public GraphicsFormat ppBufferFormat; // 0x98
		public GraphicsFormat uiPPBufferFormat; // 0x9C
		public bool frostedGlassUseComputeShader; // 0xA0
		public int depthOfFieldQuality; // 0xA4
		public float depthOfFieldMaxRadius; // 0xA8
		public bool depthOfFieldScaleAdjust; // 0xAC
		public float depthOfFieldScaleAdjustThreshold; // 0xB0
		public bool motionBlurEnable; // 0xB4
		public bool motionBlurLowQuality; // 0xB5
		public bool bloomEnabled; // 0xB6
		public bool vignetteEnabled; // 0xB7
		public bool radialBlurEnabled; // 0xB8
		public bool chromaticAberrationEnabled; // 0xB9
		public bool dirtyLensEnabled; // 0xBA
		public bool sharpenEnabled; // 0xBB
		public bool frostedGlassEnabled; // 0xBC
		public bool cutsceneEffectEnabled; // 0xBD
		public bool fisheyeEffectEnabled; // 0xBE
		public bool lensFlareEnabled; // 0xBF
		public int punctualLightMaxCount; // 0xC0
		public bool enableShadowProxy; // 0xC4
		public int shadowDepthBits; // 0xC8
		public bool enableScreenSpaceShadowMask; // 0xCC
		public bool csmEnabled; // 0xCD
		public int csmShadowMapTileResolution; // 0xD0
		public float csmMaxDistance; // 0xD4
		public float csmFadeInnerDistance; // 0xD8
		public int csmSplitCount; // 0xDC
		public float csmSplit0; // 0xE0
		public float csmSplit1; // 0xE4
		public float csmSplit2; // 0xE8
		public float csmSplit3; // 0xEC
		public bool csmUseShadowmapCache; // 0xF0
		public int csmCachedFrame0; // 0xF4
		public int csmCachedFrame1; // 0xF8
		public int csmCachedFrame2; // 0xFC
		public int csmCachedFrame3; // 0x100
		public float csmScreenSizeMin0; // 0x104
		public float csmScreenSizeMin1; // 0x108
		public float csmScreenSizeMin2; // 0x10C
		public float csmScreenSizeMin3; // 0x110
		public bool csmEnableOcclusionCulling0; // 0x114
		public bool csmEnableOcclusionCulling1; // 0x115
		public bool csmEnableOcclusionCulling2; // 0x116
		public bool csmEnableOcclusionCulling3; // 0x117
		public int csmOcclusionDepthSize; // 0x118
		public int csmStopRenderCharacterCascade; // 0x11C
		public float csmNearPlaneOffset; // 0x120
		public float csmHardwareBias; // 0x124
		public float csmHardwareNormalBias; // 0x128
		public bool characterShadowEnabled; // 0x12C
		public int characterShadowMapResolution; // 0x130
		public float characterShadowHardwareBias; // 0x134
		public float characterShadowHardwareNormalBias; // 0x138
		public float characterShadowShaderBias; // 0x13C
		public float characterShadowShaderNormalBias; // 0x140
		public bool punctualLightShadowEnabled; // 0x144
		public int punctualLightTileMaxSize; // 0x148
		public float punctualLightForceCullDistance; // 0x14C
		public int punctualLightEnvDynamicCasterCount; // 0x150
		public int punctualLightMovableDynamicCasterCount; // 0x154
		public float punctualLightShadowScreenSizeMin; // 0x158
		public bool hdplsCharacterShadowEnabled; // 0x15C
		public int hdplsAtlasHeight; // 0x160
		public bool hdplsScreenSpaceReduceResolution; // 0x164
		public float hdplsDepthBias; // 0x168
		public float hdplsNormalBias; // 0x16C
		public float hdplsSoftness; // 0x170
		public bool asmEnabled; // 0x174
		public int asmShadowMapTileResolution; // 0x178
		public float asmMaxDistance; // 0x17C
		public int asmMaxTileRenderCountPerFrame; // 0x180
		public float asmDepthBias; // 0x184
		public float asmNormalBias; // 0x188
		public float asmScreenSizeMin; // 0x18C
		public bool shadowDecalProjectorEnabled; // 0x190
		public int shadowDecalProjectorMaxCount; // 0x194
		public bool transientGBuffer; // 0x198
		public int depthBitsGBuffer; // 0x19C
		public bool depthCombinedWithStencil; // 0x1A0
		public float copySceneRTScale; // 0x1A4
		public int taauResolveResolutionHeight; // 0x1A8
		public float renderingScale; // 0x1AC
		public int backBufferResolutionHeight; // 0x1B0
		public bool textureStreamingEnable; // 0x1B4
		public int textureStreamingBudget; // 0x1B8
		public int textureStreamingMaxBudget; // 0x1BC
		public int reservedMemoryForNonTextureStreaming; // 0x1C0
		public float textureStreamingMobileBudgetPercent; // 0x1C4
		public int textureStreamingRendererPerFrame; // 0x1C8
		public int textureStreamingMaxFileIORequests; // 0x1CC
		public bool contactShadowEnableParam; // 0x1D0
		public bool gtaoEnable; // 0x1D1
		public int gtaoQualityLevel; // 0x1D4
		public bool ssrEnable; // 0x1D8
		public int ssrRayMarchingSampleCount; // 0x1DC
		public bool ssrImportanceSample; // 0x1E0
		public bool ssrV2; // 0x1E1
		public bool ssrV2Upsample; // 0x1E2
		public bool terrainFallbackGBuffer; // 0x1E3
		public int terrainLODFactor; // 0x1E4
		public bool terrainPOM; // 0x1E8
		public bool terrainDeformEnable; // 0x1E9
		public int terrainDeformSubdMode; // 0x1EC
		public int terrainDeformSubdModeV2; // 0x1F0
		public int terrainDeformGpuSubd; // 0x1F4
		public int terrainDeformPrimitivePixelLengthTargetLog2; // 0x1F8
		public bool erosionEnable; // 0x1FC
		public bool enableLightShaft; // 0x1FD
		public int lightShaftSampleNum; // 0x200
		public float lightShaftDownSampleFactor; // 0x204
		public int lightShaftBlurPassCount; // 0x208
		public bool enableAnamorphicStreaks; // 0x20C
		public float anamorphicStreaksDownSampleFactor; // 0x210
		public bool lightWeightUICamera; // 0x214
		public bool enableRainWetnessHighQuality; // 0x215
		public int rainOcclusionMapSize; // 0x218
		public int rainOcclusionMapOverrideRange; // 0x21C
		public bool rainSplashEnabled; // 0x220
		public int rainSplashMaxCount; // 0x224
		public float screenRainDropPercent; // 0x228
		public bool enableMiddleDistRain; // 0x22C
		public bool enableRainWave; // 0x22D
		public bool enableRainLighting; // 0x22E
		public int sceneEffectRainLayerCount; // 0x230
		public bool enableSnowLighting; // 0x234
		public int snowLayerCount; // 0x238
		public bool enableSnowCollision; // 0x23C
		public int depthOcclusionMapSize; // 0x240
		public int depthOcclusionMapRange; // 0x244
		public HGAtmosphereSettingParameters atmosphereParams; // 0x248
		public float waterPrepassTextureSize; // 0x27C
		public bool waterInteractiveEnable; // 0x280
		public bool waterIndirectEnable; // 0x281
		public int waterVRRx; // 0x284
		public int waterVRRy; // 0x288
		public float waterDisplacementWeight; // 0x28C
		public float waterDisplacementDistance; // 0x290
		public int waterHeightTextureSize; // 0x294
		public float artTagLODBiasAll; // 0x298
		public unsafe fixed /* 0x00000000-0x00000000 */ float artTagLODBias[0]; // 0x29C
		public bool shouldSplitOnePass; // 0x39C
		public HGVolumetricFogSettingParametersV2 volumetricFogParams; // 0x3A0
		public bool reflectionProbeUseRGBAHalf; // 0x3CC
		public int reflectionProbeOctTextureSize; // 0x3D0
		public int reflectionProbeMaxSampleMip; // 0x3D4
		public int reflectionProbeMaxBlitCountPerFrame; // 0x3D8
		public float reflectionProbeCameraJumpDistance; // 0x3DC
		public int reflectionProbeCameraJumpMaxBlitCount; // 0x3E0
		public bool transparentLowResOffscreenEnable; // 0x3E4
		public bool transparentLowResVRSEnable; // 0x3E5
		public int transparentVRRx; // 0x3E8
		public int transparentVRRy; // 0x3EC
		public bool rayTracingReflectionEnable; // 0x3F0
		public int rayTracingReflectionMode; // 0x3F4
		public float rayTracingReflectionSSQuality0; // 0x3F8
		public float rayTracingReflectionSSQuality1; // 0x3FC
		public float rayTracingReflectionSSQuality2; // 0x400
		public float rayTracingReflectionSSQuality3; // 0x404
		public float rayTracingReflectionRTQuality0; // 0x408
		public float rayTracingReflectionRTQuality1; // 0x40C
		public float rayTracingReflectionRTQuality2; // 0x410
		public float rayTracingReflectionRTQuality3; // 0x414
		public bool frameInterpolationEnable; // 0x418
		public bool frameInterpolationPause; // 0x419
		public FrameInterpolationAlgo frameInterpolationAlgo; // 0x41C
		public bool hasWorldUIAfterFrameInterpolation; // 0x420
		public float afmeCameraRotationCosFallbackThreshold; // 0x424
		public float afmeCameraMoveDistanceSqrFallbackThreshold; // 0x428
		public float mfrcCameraRotationCosFallbackThreshold; // 0x42C
		public float mfrcCameraMoveDistanceSqrFallbackThreshold; // 0x430
		public float mfrcGeneralFallbackThreshold; // 0x434
		public float mfrcBrightnessDiffFallbackThreshold; // 0x438
		public float mfrcRepeatedPatternFallbackThreshold; // 0x43C
		public int inkSimulationResolution; // 0x440
		public int inkDensityResolution; // 0x444
		public bool inkSimulationEnable; // 0x448
		public bool enableHGWindMotorWaveInstruction; // 0x449
		public bool windMotorInjectionEnable; // 0x44A
		public int windMotorInjectionGridSizeX; // 0x44C
		public int windMotorInjectionGridSizeY; // 0x450
		public int windMotorInjectionGridSizeZ; // 0x454
		public float windMotorInjectionCellSizeX; // 0x458
		public float windMotorInjectionCellSizeY; // 0x45C
		public float windMotorInjectionCellSizeZ; // 0x460
		public float windMotorInjectionForwardBias; // 0x464
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _artTagLODBias_e__FixedBuffer // TypeDefIndex: 89097
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct HGRenderPathConstants // TypeDefIndex: 89099
	{
		// Fields
		public float _RenderPathInjected; // 0x00
		public float _HGFlipX; // 0x04
		public float _HGFlipY; // 0x08
		public float _HGOrientationType; // 0x0C
	}

	public struct CurrentViewTransformConstants // TypeDefIndex: 89100
	{
		// Fields
		public Matrix4x4 _ViewMatrix; // 0x00
		public Matrix4x4 _InvViewMatrix; // 0x40
		public Matrix4x4 _ProjMatrix; // 0x80
		public Matrix4x4 _InvProjMatrix; // 0xC0
		public Matrix4x4 _ViewProjMatrix; // 0x100
		public Matrix4x4 _ViewNoTransProjMatrix; // 0x140
		public Matrix4x4 _InvViewProjMatrix; // 0x180
		public Matrix4x4 _NonJitteredViewProjMatrix; // 0x1C0
		public Matrix4x4 _NonJitteredViewNoTransProjMatrix; // 0x200
		public Matrix4x4 _InvNonJitteredViewProjMatrix; // 0x240
		public Matrix4x4 _InvPretransformMatrix; // 0x280
		public Vector4 _WorldSpaceCameraPos_Internal; // 0x2C0
	}

	public struct BasicTransformConstants // TypeDefIndex: 89101
	{
		// Fields
		public CurrentViewTransformConstants current; // 0x00
		public Matrix4x4 _PrevViewProjMatrix; // 0x2D0
		public Matrix4x4 _PrevViewNoTransProjMatrix; // 0x310
		public Matrix4x4 _PrevNonJitteredViewProjMatrix; // 0x350
		public Matrix4x4 _PrevNonJitteredViewNoTransProjMatrix; // 0x390
		public Matrix4x4 _PrevInvViewProjMatrix; // 0x3D0
		public Matrix4x4 _PrevNonJitteredInvViewProjMatrix; // 0x410
		public Matrix4x4 _ReprojectionMatrix; // 0x450
		public Matrix4x4 _WiderFoVViewProjMatrix; // 0x490
		public Matrix4x4 _WiderFoVInvViewProjMatrix; // 0x4D0
		public Vector4 _PrevCamPosRWS_Internal; // 0x510
	}

	public struct ShaderVariablesGlobal // TypeDefIndex: 89114
	{
		// Fields
		public Vector4 _ScreenSize; // 0x00
		public Vector4 _BackBufferSize; // 0x10
		public Vector4 _ZBufferParams; // 0x20
		public Vector4 _ProjectionParams; // 0x30
		public Vector4 unity_OrthoParams; // 0x40
		public Vector4 _ScreenParams; // 0x50
		public unsafe fixed /* 0x00000000-0x00000000 */ float _FrustumPlanes[0]; // 0x60
		public unsafe fixed /* 0x00000000-0x00000000 */ float _ShadowFrustumPlanes[0]; // 0xC0
		public Vector4 _TaaFrameInfo; // 0x120
		public Vector4 _TaaJitterStrength; // 0x130
		public Vector4 _Time; // 0x140
		public Vector4 _SinTime; // 0x150
		public Vector4 _CosTime; // 0x160
		public Vector4 unity_DeltaTime; // 0x170
		public Vector4 _TimeParameters; // 0x180
		public Vector4 _LastTimeParameters; // 0x190
		public float _GlobalMipBias; // 0x1A0
		public float _GlobalMipBiasPow2; // 0x1A4
		public float _ProbeExposureScale; // 0x1A8
		public uint _FrameCount; // 0x1AC
		public Vector4 _ExposureWithMiscParams; // 0x1B0
		public Vector4Int _BinningBufferOffsets; // 0x1C0
		public Vector4 _EnvironmentGlobalParams0; // 0x1D0
		public Vector4 _GraphicsFeaturesGlobalParam0; // 0x1E0
		public Vector4 _GraphicsFeaturesGlobalParam1; // 0x1F0
		public Vector4 _WindGlobalParams0; // 0x200
		public Vector4 _WindGlobalParams2; // 0x210
		public Vector4 _CharacterPositionParams0; // 0x220
		public Vector4 _CharacterPositionParams1; // 0x230
		public Vector4 _CharacterPositionParams2; // 0x240
		public Vector4 _CharacterPositionParams3; // 0x250
		public Vector4 _CharacterHeightParams; // 0x260
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams0[0]; // 0x270
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams1[0]; // 0x2B0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams2[0]; // 0x2F0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams3[0]; // 0x330
		public Vector4 _WindMotorCount; // 0x370
		public Vector4 _LastWindGlobalParams0; // 0x380
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams0[0]; // 0x390
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams1[0]; // 0x3D0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams3[0]; // 0x410
		public Vector4 _FoliageInteractiveParams0; // 0x450
		public Vector4 _PrevFoliageInteractiveParams0; // 0x460
		public Vector4 _AtmosphereFogParams0; // 0x470
		public Vector4 _AtmosphereFogParams1; // 0x480
		public Vector4 _AtmosphereFogParams2; // 0x490
		public Vector4 _AtmosphereFogParams3; // 0x4A0
		public Vector4 _AtmosphereFogParams4; // 0x4B0
		public Vector4 _AtmosphereFogParams5; // 0x4C0
		public Vector4 _ExponentialFogParams0; // 0x4D0
		public Vector4 _ExponentialFogParams1; // 0x4E0
		public Vector4 _ExponentialFogParams2; // 0x4F0
		public Vector4 _ExponentialFogParams3; // 0x500
		public Vector4 _ExponentialFogParams4; // 0x510
		public Vector4 _ExponentialFogParams5; // 0x520
		public Vector4 _VolumetricFogParams0; // 0x530
		public Vector4 _VolumetricFogParams1; // 0x540
		public Vector4 _VolumetricFogParams2; // 0x550
		public Vector4 _VolumetricFogParams3; // 0x560
		public Vector4 _VolumetricFogParams4; // 0x570
		public Vector4 _HeightFogFlowNoiseParams0; // 0x580
		public Vector4 _HeightFogFlowNoiseParams1; // 0x590
		public Vector4 _FogBakeLutRescaleParams; // 0x5A0
		public Vector4 _FogBakeLutEncodeParams; // 0x5B0
		public Vector4 _FogBakeLutYawParams; // 0x5C0
		public Vector4 _CloudShadowParams0; // 0x5D0
		public Vector4 _CloudShadowParams1; // 0x5E0
		public Vector4 _CloudShadowParams2; // 0x5F0
		public Vector4 _CloudShadowParams3; // 0x600
		public Vector4 _CloudShadowFarParams0; // 0x610
		public Vector4 _CloudShadowFarParams1; // 0x620
		public Vector4 _Style_MatDistCoef; // 0x630
		public Vector4 _Style_MatFarAlb0; // 0x640
		public Vector4 _Style_MatFarAlb1; // 0x650
		public Vector4 _Style_GbFarEms; // 0x660
		public Vector4 _Style_GbFarDir; // 0x670
		public Vector4 _Style_GbCoef; // 0x680
		public Vector4 _VFXParams0; // 0x690
		public Vector4 _VFXParams1; // 0x6A0
		public Vector4 _VFXParams2; // 0x6B0
		public Vector4 _VFXParams3; // 0x6C0
		public Vector4 _InkWashGlobalParams; // 0x6D0
		public Vector4 _CharacterParams0; // 0x6E0
		public Vector4 _CharacterParams1; // 0x6F0
		public Vector4 _CharacterParams2; // 0x700
		public Vector4 _CharacterParams3; // 0x710
		public Vector4 _CharacterParams4; // 0x720
		public Vector4 _CharacterParams5; // 0x730
		public Vector4 _CharacterParams6; // 0x740
		public Vector4 _CharacterParams7; // 0x750
		public Vector4 _CharacterParams8; // 0x760
		public Vector4 _CharacterParams9; // 0x770
		public Vector4 _CharacterParams10; // 0x780
		public Vector4 _CharacterParams11; // 0x790
		public Vector4 _CharacterParams12; // 0x7A0
		public Vector4 _CharacterParams13; // 0x7B0
		public Vector4 _CharacterParams14; // 0x7C0
		public Vector4 _CharacterParams15; // 0x7D0
		public Vector4 _CharacterParams16; // 0x7E0
		public Vector4 _InkSimulationWorldToUV; // 0x7F0
		public Vector4 _TerrainDeformParams0; // 0x800
		public Vector4 _TerrainDeformParams1; // 0x810
		public unsafe fixed /* 0x00000000-0x00000000 */ float _TerrainClipmapParams0[0]; // 0x820
		public unsafe fixed /* 0x00000000-0x00000000 */ float _TerrainClipmapParams1[0]; // 0x840
		public float _G_EnableFeatureErosionBlend; // 0x860
		public float _G_EnableFeatureB; // 0x864
		public float _G_EnableFeatureC; // 0x868
		public float _G_EnableFeatureD; // 0x86C
		public Vector4 _IVParam0; // 0x870
		public Vector4 _IVParam1; // 0x880
		public Vector4 _IVParam2; // 0x890
		public Vector4 _IVDefaultSHAr; // 0x8A0
		public Vector4 _IVDefaultshAg; // 0x8B0
		public Vector4 _IVDefaultshAb; // 0x8C0
		public Vector4 _IVV2Param0; // 0x8D0
		public Vector4 _IVV2Param1; // 0x8E0
		public Vector4 _IVV2Param2; // 0x8F0
		public Vector4 _IVV2Param3; // 0x900
		public Vector4 _WaterInteractionParams0; // 0x910
		public Vector4 _WaterInteractionParams1; // 0x920
		public Vector4 _RainWetnessGlobalParam0; // 0x930
		public Vector4 _RainWetnessGlobalParam1; // 0x940
		public Vector4 _RainWetnessGlobalParam2; // 0x950
		public Vector4 _RainWetnessGlobalParam3; // 0x960
		public Vector4 _RainWetnessGlobalParam4; // 0x970
		public Vector4 _RainWetnessGlobalParam5; // 0x980
		public Vector4 _RainWetnessGlobalParam6; // 0x990
		public Vector4 _RainWetnessGlobalParam7; // 0x9A0
		public Vector4 _RainWetnessGlobalParam8; // 0x9B0
		public Vector4 _RainWetnessGlobalParam9; // 0x9C0
		public Vector4 _RainWetnessGlobalParam10; // 0x9D0
		public Vector4 _VerticalOcclusionMapParam0; // 0x9E0
		public Vector4 _WaterWetnessMaskParam0; // 0x9F0
		public Vector4 _GpuClothParams; // 0xA00
		public Vector4 _FoliageOccluderParams0; // 0xA10
		public Vector4 _FoliageOccluderCameraPosParam; // 0xA20
		public Vector4 _InteractRaftParams0; // 0xA30
		public Vector4 _InteractRaftParams1; // 0xA40
		public Matrix4x4 _FakePlanarReflectionViewProjMatrix; // 0xA50
		public Vector4 _FakeSphericalLightSource; // 0xA90
		public Vector4 _VolumetricComposeParams; // 0xAA0
		public Vector4 _WindGridMinPacked; // 0xAB0
		public Vector4 _WindInvCellSizePacked; // 0xAC0
		public Vector4Int _WindGridDimsMotorCount; // 0xAD0
		public Vector4Int _WindBinningEnabledPacked; // 0xAE0
		public Vector4Int _WindMotorBufferOffsets; // 0xAF0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _HackTempDataBeforeCPPPlugin[0]; // 0xB00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __FrustumPlanes_e__FixedBuffer // TypeDefIndex: 89102
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __ShadowFrustumPlanes_e__FixedBuffer // TypeDefIndex: 89103
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __WindMotorParams0_e__FixedBuffer // TypeDefIndex: 89104
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __WindMotorParams1_e__FixedBuffer // TypeDefIndex: 89105
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __WindMotorParams2_e__FixedBuffer // TypeDefIndex: 89106
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __WindMotorParams3_e__FixedBuffer // TypeDefIndex: 89107
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __LastWindMotorParams0_e__FixedBuffer // TypeDefIndex: 89108
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __LastWindMotorParams1_e__FixedBuffer // TypeDefIndex: 89109
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __LastWindMotorParams3_e__FixedBuffer // TypeDefIndex: 89110
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __TerrainClipmapParams0_e__FixedBuffer // TypeDefIndex: 89111
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __TerrainClipmapParams1_e__FixedBuffer // TypeDefIndex: 89112
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __HackTempDataBeforeCPPPlugin_e__FixedBuffer // TypeDefIndex: 89113
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct UIShaderVariablesGlobal // TypeDefIndex: 89115
	{
		// Fields
		public Vector4 _Time; // 0x00
		public Vector4 _ProjectionParams; // 0x10
		public Vector4 _ScreenParams; // 0x20
		public Vector4 _ZBufferParams; // 0x30
	}

	[UsedByNativeCode]
	public enum DLSSQuality // TypeDefIndex: 89116
	{
		UltraPerformance = 0,
		Performance = 1,
		Balanced = 2,
		Quality = 3,
		DLAA = 4
	}

	[UsedByNativeCode]
	public enum DLSSModel // TypeDefIndex: 89117
	{
		Default_4_0 = 0,
		M_4_5 = 1,
		L_4_5 = 2
	}

	[UsedByNativeCode]
	public enum StreamlineReflexMode // TypeDefIndex: 89118
	{
		Off = 0,
		LowLatency = 1,
		LowLatencyWithBoost = 2
	}

	[UsedByNativeCode]
	public enum StreamlineDLSSFGMode // TypeDefIndex: 89119
	{
		Off = 0,
		On = 1,
		Auto = 2
	}

	[UsedByNativeCode]
	public struct DLSSGMinMaxFrameInfo // TypeDefIndex: 89120
	{
		// Fields
		public int min; // 0x00
		public int max; // 0x04
	}

	[NativeHeader("Modules/HGGraphics/Public/DLSS/HGDLSSCommon.h")]
	[NativeHeader("Modules/HGGraphics/Public/DLSS/HGDLSSUtil.h")]
	[UsedByNativeCode]
	public struct DLSSOptimalSettings // TypeDefIndex: 89121
	{
		// Fields
		public uint optimalRenderWidth; // 0x00
		public uint optimalRenderHeight; // 0x04
		public float optimalSharpness; // 0x08
		public uint renderWidthMin; // 0x0C
		public uint renderHeightMin; // 0x10
		public uint renderWidthMax; // 0x14
		public uint renderHeightMax; // 0x18
	
		// Methods
		[FreeFunction("GetDLSSOptimalSetting")]
		[UsedByNativeCode]
		public static DLSSOptimalSettings GetDLSSOptimalSetting(DLSSQuality quality, Vector2Int nonScaledViewport); // 0x00000001850F6CB0-0x00000001850F6D20
		private static void GetDLSSOptimalSetting_Injected(DLSSQuality quality, ref Vector2Int nonScaledViewport, out DLSSOptimalSettings ret); // 0x00000001850F6D60-0x00000001850F6DC0
	}

	[NativeHeader("Modules/StreamLine/StreamlineDLSSG.h")]
	[UsedByNativeCode]
	public struct HGCPPDLSSUtil // TypeDefIndex: 89122
	{
		// Methods
		[FreeFunction("SetStreamlineDLSSGMode")]
		[UsedByNativeCode]
		public static void SetStreamlineDLSSGMode(StreamlineDLSSFGMode frameGenMode); // 0x0000000185475700-0x0000000185475740
		[FreeFunction("GetStreamlineDLSSGMinMaxFrameGen")]
		[UsedByNativeCode]
		public static DLSSGMinMaxFrameInfo GetStreamlineDLSSGMinMaxFrameGen(); // 0x0000000185472340-0x0000000185472390
		[FreeFunction("CalcStreamlineDLSSGVRAMUsage")]
		[UsedByNativeCode]
		public static int CalcStreamlineDLSSGVRAMUsage(Vector2Int taauSize, Vector2Int finalRTSize); // 0x000000018783AD70-0x000000018783AD98
		private static void GetStreamlineDLSSGMinMaxFrameGen_Injected(out DLSSGMinMaxFrameInfo ret); // 0x0000000185472390-0x00000001854723D0
		private static int CalcStreamlineDLSSGVRAMUsage_Injected(ref Vector2Int taauSize, ref Vector2Int finalRTSize); // 0x0000000185E3B530-0x0000000185E3B580
	}

	public enum HGLightConfigPitchYawModeCPP // TypeDefIndex: 89123
	{
		DirLight = 0,
		Custom = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGLightConfigCPP // TypeDefIndex: 89124
	{
		// Fields
		public float preExposure; // 0x00
		public UnityEngine.Color directColor; // 0x04
		public float directIntensity; // 0x14
		public float directSpecularIntensity; // 0x18
		public float directSoftSourceRadius; // 0x1C
		public Vector2 directPitchYaw; // 0x20
		public float indirectDiffuseFactor; // 0x28
		public float indirectSpecularFactor; // 0x2C
		public float bakedIndirectMultiplier; // 0x30
		public float giBakedIndirectMultiplier; // 0x34
		public Quaternion rotationDirect; // 0x38
		public Vector3 forwardDirect; // 0x48
		public Matrix4x4 localToWorld; // 0x54
		public Quaternion rotationAtmosphere; // 0x94
		public Quaternion rotationLightShaft; // 0xA4
		public Quaternion rotationSunDisc; // 0xB4
		public Quaternion rotationLensFlare; // 0xC4
		public Quaternion rotationCloudShadow; // 0xD4
		public Quaternion rotationHeightFogDirectionalInscattering; // 0xE4
		public HGLightConfigPitchYawModeCPP cloudShadowPitchYawMode; // 0xF4
		public Vector2 cloudShadowPitchYaw; // 0xF8
	}

	public enum HGSkyConfigSkyMaterialTypeCPP // TypeDefIndex: 89125
	{
		ProceduralSky = 0,
		Skybox = 1
	}

	public enum HGSkyConfigReflectionTypeCPP // TypeDefIndex: 89126
	{
		FromSky = 0,
		Custom = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGSkyConfigCPP // TypeDefIndex: 89127
	{
		// Fields
		public float skyDistance; // 0x00
		public float skyBakedIndirectIntensity; // 0x04
		public float skyDirectIntensity; // 0x08
		public float giSkyMultiplier; // 0x0C
		public bool useCustomIVDefaultSH; // 0x10
		public bool useSkyDistanceForBakeFogLut; // 0x11
		public SphericalHarmonicsL2 customIVDefaultSH; // 0x14
		public HGSkyConfigSkyMaterialTypeCPP skyMaterialType; // 0x80
		public float proceduralSkyLuxFactor; // 0x84
		public bool enableSunDisc; // 0x88
		public float sunDiscRadius; // 0x8C
		public float sunDiscRampIntensity; // 0x90
		public UnityEngine.Color sunDiscColor; // 0x94
		public float skyboxBrightness; // 0xA4
		public UnityEngine.Color skyboxTintColor; // 0xA8
		public float skyboxRotation; // 0xB8
		public Vector3 visibleBox; // 0xBC
		public HGSkyConfigReflectionTypeCPP reflectionType; // 0xC8
		public IntPtr reflectionMap; // 0xD0
		public float culloff; // 0xD8
		public SphericalHarmonicsL2 skyAmbientSH; // 0xDC
		public IntPtr skyboxCubeMap; // 0x148
		public IntPtr customIVCubemapMapForEdit; // 0x150
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGAtmosphereConfigCPP // TypeDefIndex: 89128
	{
		// Fields
		public float groundRadius; // 0x00
		public UnityEngine.Color groundAlbedo; // 0x04
		public UnityEngine.Color outerSunIrradianceColor; // 0x14
		public float atmosphereHeight; // 0x24
		public float multiScatteringFactor; // 0x28
		public float rayleighScatteringScale; // 0x2C
		public UnityEngine.Color rayleighScattering; // 0x30
		public float rayleighExponentialDistribution; // 0x40
		public float mieScatteringScale; // 0x44
		public UnityEngine.Color mieScattering; // 0x48
		public float mieAbsorptionScale; // 0x58
		public UnityEngine.Color mieAbsorption; // 0x5C
		public float mieAnisotropy; // 0x6C
		public float mieExponentialDistribution; // 0x70
		public float ozoneAbsorptionScale; // 0x74
		public UnityEngine.Color ozoneAbsorption; // 0x78
		public float tentTipAltitude; // 0x88
		public float tentTipValue; // 0x8C
		public float tentWidth; // 0x90
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGFogConfigCPP // TypeDefIndex: 89129
	{
		// Fields
		public bool enable; // 0x00
		public float startDistance; // 0x04
		public float startHeight; // 0x08
		public float fallOffHeight; // 0x0C
		public float fallOffDistance; // 0x10
		public UnityEngine.Color mieScattering; // 0x14
		public float mieScatteringScale; // 0x24
		public float mieAnisotropy; // 0x28
		public UnityEngine.Color rayleighScattering; // 0x2C
		public float rayleighScatteringScale; // 0x3C
		public UnityEngine.Color inscatterAmbientColor; // 0x40
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGHeightFogConfigCPP // TypeDefIndex: 89130
	{
		// Fields
		public bool enable; // 0x00
		public float heightFogStartHeight; // 0x04
		public float heightFogDensity; // 0x08
		public float heightFogFalloff; // 0x0C
		public float heightFogStartHeightSecond; // 0x10
		public float heightFogDensitySecond; // 0x14
		public float heightFogFalloffSecond; // 0x18
		public UnityEngine.Color heightFogInscatter; // 0x1C
		public float heightFogMaxOpacity; // 0x2C
		public float heightFogStartDistance; // 0x30
		public float heightFogStartTransition; // 0x34
		public float heightFogCutoffDistance; // 0x38
		public float heightFogCutoffTransition; // 0x3C
		public float heightFogCullingFarClipPlane; // 0x40
		public float heightFogDirectionalInscatteringExponent; // 0x44
		public float heightFogDirectionalInscatteringStartDistance; // 0x48
		public UnityEngine.Color heightFogDirectionalInscattering; // 0x4C
		public float heightFogDirectionalInscatteringExponentMobile; // 0x5C
		public UnityEngine.Color heightFogDirectionalInscatteringMobile; // 0x60
		public bool enableVolumetricFog; // 0x70
		public float volumetricFogScatteringDistribution; // 0x74
		public UnityEngine.Color volumetricFogAlbedo; // 0x78
		public UnityEngine.Color volumetricFogEmissive; // 0x88
		public float volumetricFogExtinctionScale; // 0x98
		public float volumetricFogDistance; // 0x9C
		public float volumetricFogStartDistance; // 0xA0
		public float volumetricFogNearFadeInDistance; // 0xA4
		public float volumetricFogDirectLightingScatteringIntensity; // 0xA8
		public float volumetricFogSkyLightingScatteringIntensity; // 0xAC
		public bool enableFlowNoise; // 0xB0
		public float flowNoiseIntensity; // 0xB4
		public float flowNoiseDistance; // 0xB8
		public float flowNoiseTilling; // 0xBC
		public float flowNoiseHorizontalDirAngle; // 0xC0
		public float flowNoiseVerticalDirAngle; // 0xC4
		public Vector3 flowNoiseDir; // 0xC8
		public float flowNoiseSpeed; // 0xD4
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGVolumetricFogConfigCPP // TypeDefIndex: 89131
	{
		// Fields
		public bool enable; // 0x00
		public float heightFogStartHeight; // 0x04
		public float heightFogDensity; // 0x08
		public float heightFogFalloff; // 0x0C
		public float heightFogStartHeightSecond; // 0x10
		public float heightFogDensitySecond; // 0x14
		public float heightFogFalloffSecond; // 0x18
		public UnityEngine.Color heightFogInscatter; // 0x1C
		public float heightFogMaxOpacity; // 0x2C
		public float heightFogStartDistance; // 0x30
		public float heightFogStartTransition; // 0x34
		public float heightFogCutoffDistance; // 0x38
		public float heightFogCutoffTransition; // 0x3C
		public float heightFogDirectionalInscatteringExponent; // 0x40
		public float heightFogDirectionalInscatteringStartDistance; // 0x44
		public UnityEngine.Color heightFogDirectionalInscattering; // 0x48
		public float volumetricFogScatteringDistribution; // 0x58
		public UnityEngine.Color volumetricFogAlbedo; // 0x5C
		public UnityEngine.Color volumetricFogEmissive; // 0x6C
		public float volumetricFogExtinctionScale; // 0x7C
		public float volumetricFogDistance; // 0x80
		public float volumetricFogStartDistance; // 0x84
		public float volumetricFogNearFadeInDistance; // 0x88
		public float volumetricFogDirectLightingScatteringIntensity; // 0x8C
		public float volumetricFogSkyLightingScatteringIntensity; // 0x90
		public bool enableFlowNoise; // 0x94
		public float flowNoiseIntensity; // 0x98
		public float flowNoiseDistance; // 0x9C
		public float flowNoiseTilling; // 0xA0
		public float flowNoiseHorizontalDirAngle; // 0xA4
		public float flowNoiseVerticalDirAngle; // 0xA8
		public Vector3 flowNoiseDir; // 0xAC
		public float flowNoiseSpeed; // 0xB8
		public bool enableVLFlowNoise; // 0xBC
		public bool enableTwoParameter; // 0xBD
		public float flowVLNoiseIntensity; // 0xC0
		public float flowVLNoiseDistance; // 0xC4
		public float flowVLNoiseTilling; // 0xC8
		public Vector3 flowVLNoiseTillingScale; // 0xCC
		public float flowVLNoiseHorizontalDirAngle; // 0xD8
		public float flowVLNoiseVerticalDirAngle; // 0xDC
		public Vector3 flowVLNoiseDir; // 0xE0
		public float flowVLNoiseSpeed; // 0xEC
		public Vector2 flowVLNoiseRemapRange; // 0xF0
		public float flowVLNoisePerturbTilling; // 0xF8
		public float flowVLNoisePerturbIntensity; // 0xFC
		public Vector3 flowVLNoisePerturbSpeed; // 0x100
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCloudShadowConfigCPP // TypeDefIndex: 89132
	{
		// Fields
		public IntPtr cloudShadowTexture; // 0x00
		public Vector3 cloudShadowEnvCenter; // 0x08
		public float cloudShadowCoverage; // 0x14
		public float cloudShadowFlowSpeed; // 0x18
		public Vector2 cloudShadowFlowDirection; // 0x1C
		public float cloudShadowAlpha; // 0x24
		public float cloudShadowDistanceScale; // 0x28
		public float cloudShadowScaleStartDistance; // 0x2C
		public float cloudShadowScaleEndDistance; // 0x30
		public bool enableFarCloudShadowTexture; // 0x34
		public Vector3 cloudShadowFarEnvCenter; // 0x38
		public float cloudShadowFarCoverage; // 0x44
		public float cloudShadowFarFlowSpeed; // 0x48
		public Vector2 cloudShadowFarFlowDirection; // 0x4C
	}

	public enum HGCloudConfigCloudFlowTypeCPP // TypeDefIndex: 89133
	{
		None = 0,
		Procedural = 1,
		FlowMap = 2
	}

	public enum HGCloudConfigCloudTextureModeCPP // TypeDefIndex: 89134
	{
		SingleChannelRG = 0,
		ColorRGB = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCloudConfigCPP // TypeDefIndex: 89135
	{
		// Fields
		public bool enable; // 0x00
		public bool enableCloudShadow; // 0x01
		public HGCloudShadowConfigCPP cloudShadowConfig; // 0x08
		public IntPtr cloudTexture; // 0x60
		public UnityEngine.Color cloudTint; // 0x68
		public float cloudFadeAlpha; // 0x78
		public float cloudContrast; // 0x7C
		public bool lightAffectCloud; // 0x80
		public float cloudBrightness; // 0x84
		public float cloudAbsoluteBrightness; // 0x88
		public bool brightnessAffectCloudAlpha; // 0x8C
		public bool drawCloudAfterPlanet; // 0x8D
		public float drawCloudAfterPlanetWeight; // 0x90
		public HGCloudConfigCloudFlowTypeCPP cloudTextureMode; // 0x94
		public float cloudOpacityR; // 0x98
		public float cloudOpacityG; // 0x9C
		public HGCloudConfigCloudTextureModeCPP cloudFlowType; // 0xA0
		public int rotation; // 0xA4
		public IntPtr cloudFlowMap; // 0xA8
		public float flowSpeed; // 0xB0
		public float flowDirectionX; // 0xB4
		public float flowDirectionY; // 0xB8
		public bool enableLightShaftCloudMask; // 0xBC
		public IntPtr lightShaftCloudMaskTexture; // 0xC0
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGRingPropertyCPP // TypeDefIndex: 89136
	{
		// Fields
		public float outerRadius; // 0x00
		public float width; // 0x04
		public UnityEngine.Color ringColor; // 0x08
		public IntPtr planetRingMap; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialObjectConfigCPP // TypeDefIndex: 89137
	{
		// Fields
		public float radius; // 0x00
		public float orbitRadius; // 0x04
		public bool enableRing; // 0x08
		public float drawPlanetBelowHorizon; // 0x0C
		public float worldLongitude; // 0x10
		public float worldLatitude; // 0x14
		public float rotationAroundUp; // 0x18
		public HGRingPropertyCPP ring; // 0x20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialObjectPropertyCPP // TypeDefIndex: 89138
	{
		// Fields
		public float radius; // 0x00
		public float selfTiltX; // 0x04
		public float selfTiltZ; // 0x08
		public float selfRotationY; // 0x0C
	}

	public enum HGCelestialDrawerDrawModeCPP // TypeDefIndex: 89139
	{
		Texture = 0,
		Simulated = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialDrawerCPP // TypeDefIndex: 89140
	{
		// Fields
		public HGCelestialDrawerDrawModeCPP drawMode; // 0x00
		public IntPtr drawMaterial; // 0x08
		public Vector2 pitchYaw; // 0x10
		public Vector2 incidentLightingPitchYaw; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGAtmospherePropertyCPP // TypeDefIndex: 89141
	{
		// Fields
		public float bakeFaceVisibility; // 0x00
		public float atmosphereHeight; // 0x04
		public int numInscatteredSamplePoints; // 0x08
		public int numOpticalDepthSamplePoints; // 0x0C
		public float coff_R; // 0x10
		public float heightScale_R; // 0x14
		public float atmosphereBrightness; // 0x18
		public float atmosphereHueshift; // 0x1C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialAtmosphereObjectConfigCPP // TypeDefIndex: 89142
	{
		// Fields
		public bool drawPlanetInSkydome; // 0x00
		public float drawPlanetBelowHorizon; // 0x04
		public HGCelestialObjectPropertyCPP objectProperty; // 0x08
		public HGCelestialDrawerCPP skydomeDrawer; // 0x18
		public bool enableRing; // 0x38
		public HGRingPropertyCPP ring; // 0x40
		public bool enableAtmosphere; // 0x60
		public HGAtmospherePropertyCPP atmosphere; // 0x64
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialAdvancedObjectConfigCPP // TypeDefIndex: 89143
	{
		// Fields
		public bool drawAdvancedPlanet; // 0x00
		public IntPtr advancedPlanetMat; // 0x08
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialConfigCPP // TypeDefIndex: 89144
	{
		// Fields
		public HGCelestialObjectConfigCPP moonConfig; // 0x00
		public HGCelestialAtmosphereObjectConfigCPP talosAlphaConfig; // 0x40
		public HGCelestialAtmosphereObjectConfigCPP planetConfig; // 0xC8
		public HGCelestialAdvancedObjectConfigCPP advancedPlanetConfig; // 0x150
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGLightShaftConfigCPP // TypeDefIndex: 89145
	{
		// Fields
		public bool enable; // 0x00
		public float bloomScale; // 0x04
		public float bloomThreshold; // 0x08
		public float bloomMaxBrightness; // 0x0C
		public UnityEngine.Color bloomTint; // 0x10
		public float blurIntensity; // 0x20
		public float occlusionDepthRange; // 0x24
		public bool enableOcclusion; // 0x28
		public float occlusionMaskDarkness; // 0x2C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGAnamorphicStreaksConfigCPP // TypeDefIndex: 89146
	{
		// Fields
		public bool enable; // 0x00
		public float bloomScale; // 0x04
		public float bloomThreshold; // 0x08
		public float bloomMaxBrightness; // 0x0C
		public UnityEngine.Color bloomTint; // 0x10
		public float blurIntensity; // 0x20
		public float blurAngle; // 0x24
		public int filterSize; // 0x28
	}

	public enum HGStarConfigDebugModeCPP // TypeDefIndex: 89147
	{
		Material = 0,
		RChannel = 1,
		GChannel = 2,
		BChannel = 3,
		RGBChannel = 4
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGStarConfigCPP // TypeDefIndex: 89148
	{
		// Fields
		public bool enableStars; // 0x00
		public float starsTilling; // 0x04
		public float starsFlickerSpeed; // 0x08
		public Vector2 minMaxRange; // 0x0C
		public UnityEngine.Color starsTint; // 0x14
		public UnityEngine.Color starsTint1; // 0x24
		public float thresholdSoftness; // 0x34
		public float starsDensity; // 0x38
		public float starsExposure; // 0x3C
		public float brightnessRandomSeed; // 0x40
		public float colorRandomSeed; // 0x44
		public float distributionRandomSeed; // 0x48
		public IntPtr skyBoxStarRangeMap; // 0x50
		public float skyBoxStarDensityMapRotation; // 0x58
		public float starRingStarCoverage; // 0x5C
		public float cloudRingStarCoverage; // 0x60
		public float starDensityMapMaskThres; // 0x64
		public HGStarConfigDebugModeCPP debugMode; // 0x68
		public bool enableNebula; // 0x6C
		public IntPtr nebulaMap; // 0x70
		public UnityEngine.Color nebulaTint; // 0x78
		public float nebulaMapRotation; // 0x88
		public float nebulaStarConverage; // 0x8C
		public float celestialNebulaConverage; // 0x90
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct ScreenSpaceReflectionVolumeCPP // TypeDefIndex: 89149
	{
		// Fields
		public bool enable; // 0x00
		public float fadenessOnScreen; // 0x04
		public float fadenessOnDepth; // 0x08
		public float fadenessOnDepthFactor; // 0x0C
		public float fadenessOnMirrorMul; // 0x10
		public float fadenessOnMirrorAdd; // 0x14
		public float mipThreshold; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGAutoExposureConfigCPP // TypeDefIndex: 89150
	{
		// Fields
		public bool active; // 0x00
		public bool autoMode; // 0x01
		public bool centerMode; // 0x02
		public bool curveEditModeEnabled; // 0x03
		public Vector2 ev100Range; // 0x04
		public Vector2 ev100HistogramRange; // 0x0C
		public Vector2 pixelLuminanceRange; // 0x14
		public float centerPixelWeight; // 0x1C
		public float evCompensationManual; // 0x20
		public float evCompensationAuto; // 0x24
		public Vector2 evClampRange; // 0x28
		public float lerpDownSpeed; // 0x30
		public float lerpUpSpeed; // 0x34
	}

	public enum HGToneMappingModeCPP // TypeDefIndex: 89151
	{
		None = 0,
		Neutral = 1,
		ACES = 2,
		Custom = 3,
		External = 4,
		ACES_Modified = 5,
		Count = 6
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGColorGradingConfigCPP // TypeDefIndex: 89152
	{
		// Fields
		public bool active; // 0x00
		public bool colorLookupEnabled; // 0x01
		public IntPtr colorLookupTexture; // 0x08
		public float colorLookupContribution; // 0x10
		public bool colorAdjustmentsEnabled; // 0x14
		public float colorAdjustmentsPostExposure; // 0x18
		public bool colorCurveDirty; // 0x1C
		public HGToneMappingModeCPP ToneMappingMode; // 0x20
		public float whiteBalanceTemperature; // 0x24
		public float whiteBalanceTint; // 0x28
		public float colorAdjustmentsHueShift; // 0x2C
		public float colorAdjustmentsSaturation; // 0x30
		public float colorAdjustmentsContrast; // 0x34
		public float channelMixerRedOutRedIn; // 0x38
		public float channelMixerRedOutGreenIn; // 0x3C
		public float channelMixerRedOutBlueIn; // 0x40
		public float channelMixerGreenOutRedIn; // 0x44
		public float channelMixerGreenOutGreenIn; // 0x48
		public float channelMixerGreenOutBlueIn; // 0x4C
		public float channelMixerBlueOutRedIn; // 0x50
		public float channelMixerBlueOutGreenIn; // 0x54
		public float channelMixerBlueOutBlueIn; // 0x58
		public Vector4 shadows; // 0x5C
		public Vector4 midTones; // 0x6C
		public Vector4 highLights; // 0x7C
		public float shadowsStart; // 0x8C
		public float shadowsEnd; // 0x90
		public float highLightsStart; // 0x94
		public float highLightsEnd; // 0x98
		public Vector4 lift; // 0x9C
		public Vector4 gamma; // 0xAC
		public Vector4 gain; // 0xBC
		public Vector3 splitShadows; // 0xCC
		public Vector3 splitToneHighLights; // 0xD8
		public float splitToningBalance; // 0xE4
		public int masterCurve; // 0xE8
		public int redCurve; // 0xEC
		public int greenCurve; // 0xF0
		public int blueCurve; // 0xF4
		public int hueVsHueCurve; // 0xF8
		public int hueVsSatCurve; // 0xFC
		public int lumVsSatCurve; // 0x100
		public int satVsSatCurve; // 0x104
		public Vector4 colorFilter; // 0x108
		public Vector4 miscPrams; // 0x118
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGContactShadowConfigCPP // TypeDefIndex: 89153
	{
		// Fields
		public bool ignoreEdgePixels; // 0x00
		public bool disableTerrainContactShadow; // 0x01
		public float intensity; // 0x04
		public float surfaceThickness; // 0x08
		public float bilinearThreshold; // 0x0C
		public int contract; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGShadowConfigCPP // TypeDefIndex: 89154
	{
		// Fields
		public float csmDepthBias; // 0x00
		public float csmNormalBias; // 0x04
		public float csmIntensity; // 0x08
		public IntPtr csmRampTexture; // 0x10
		public float csmShadowSoftness; // 0x18
		public float asmCasterMinY; // 0x1C
		public float asmCasterMaxY; // 0x20
		public float contactShadowIntensity; // 0x24
		public float contactShadowSurfaceThickness; // 0x28
		public float contactShadowBilinearThreshold; // 0x2C
		public float contactShadowContract; // 0x30
		public bool contactShadowIgnoreEdgePixels; // 0x34
		public bool overrideCsmFarDistanceEnabled; // 0x35
		public float overrideCsmFarDistance; // 0x38
		public bool manualOverrideCsmRendering; // 0x3C
		public Vector3 overrideCsmSpherePosition; // 0x40
		public float overrideCsmSphereRadius; // 0x4C
		public bool disableCsm; // 0x50
		public float disableCsmBlendFactor; // 0x54
		public float csmSimulatedAttenuation; // 0x58
		public bool disableAsm; // 0x5C
		public bool rhodesModeEnabled; // 0x5D
		public Vector3 rhodesShipCenter; // 0x60
		public float rhodesShipRadius; // 0x6C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGEnvironmentPhaseCPP // TypeDefIndex: 89155
	{
		// Fields
		public unsafe HGLightConfigCPP* lightConfig; // 0x00
		public unsafe HGSkyConfigCPP* skyConfig; // 0x08
		public unsafe HGAtmosphereConfigCPP* atmosphereConfig; // 0x10
		public unsafe HGFogConfigCPP* fogConfig; // 0x18
		public unsafe HGHeightFogConfigCPP* heightFogConfig; // 0x20
		public unsafe HGVolumetricFogConfigCPP* volumetricFogConfig; // 0x28
		public unsafe HGCloudConfigCPP* cloudConfig; // 0x30
		public unsafe HGCelestialConfigCPP* celestialConfig; // 0x38
		public unsafe HGLightShaftConfigCPP* lightShaftConfig; // 0x40
		public unsafe HGAnamorphicStreaksConfigCPP* anamorphicStreaksConfig; // 0x48
		public unsafe HGStarConfigCPP* starConfig; // 0x50
		public unsafe HGAutoExposureConfigCPP* autoExposureConfig; // 0x58
		public unsafe HGColorGradingConfigCPP* colorGradingConfig; // 0x60
		public unsafe HGContactShadowConfigCPP* contactShadowConfig; // 0x68
		public unsafe HGWaterEnvConfigCPP* waterEnvConfig; // 0x70
		public unsafe HGInkWashConfigCPP* inkWashConfig; // 0x78
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct FishEyeEffectVolumeCPP // TypeDefIndex: 89156
	{
		// Fields
		public bool enable; // 0x00
		public float distortion; // 0x04
	}

	[UsedByNativeCode]
	public enum BloomQuality // TypeDefIndex: 89157
	{
		Low = 0,
		Medium = 1,
		High = 2
	}

	[UsedByNativeCode]
	public enum BloomResolution // TypeDefIndex: 89158
	{
		Half = 2,
		Quarter = 4
	}

	[UsedByNativeCode]
	public enum BloomBlendMode // TypeDefIndex: 89159
	{
		Add = 0,
		EnergyConservation = 2
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct BloomVolumeCPP // TypeDefIndex: 89160
	{
		// Fields
		public float intensity; // 0x00
		public UnityEngine.Color tint; // 0x04
		public IntPtr dirtTexture; // 0x18
		public float dirtIntensity; // 0x20
		public BloomBlendMode blendMode; // 0x24
		public float anamorphic; // 0x28
		public float scatter; // 0x2C
		public float threshold; // 0x30
		public float characterThreshold; // 0x34
		public float characterSoftness; // 0x38
		public float characterIntensity; // 0x3C
		public BloomResolution resolution; // 0x40
		public float thresholdAdditive; // 0x44
		public float scatterAdditive; // 0x48
		public float intensityAdditive; // 0x4C
		public bool enableBloomDirt; // 0x50
		public bool enableCharacterBloomControl; // 0x51
		public bool enableAlpha; // 0x52
		public bool enableAnamorphic; // 0x53
		public bool upsampleAdditive; // 0x54
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public enum HGSharpenMode // TypeDefIndex: 89161
	{
		Off = 0,
		Filter1 = 1,
		Filter2 = 2,
		Filter4 = 3
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public enum VignetteMode // TypeDefIndex: 89162
	{
		Procedural = 0,
		Masked = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct VignetteCPP // TypeDefIndex: 89163
	{
		// Fields
		public VignetteMode mode; // 0x00
		public UnityEngine.Color color; // 0x04
		public Vector2 center; // 0x14
		public float intensity; // 0x1C
		public float smoothness; // 0x20
		public float roundness; // 0x24
		public bool rounded; // 0x28
		public bool blink; // 0x29
		public IntPtr mask; // 0x30
		public float opacity; // 0x38
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGVignetteCPP // TypeDefIndex: 89164
	{
		// Fields
		public UnityEngine.Color color; // 0x00
		public float intensity; // 0x10
		public float smoothness; // 0x14
		public bool rounded; // 0x18
		public bool blink; // 0x19
		public bool useIntensityWeightedBlend; // 0x1A
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGDirtyLensCPP // TypeDefIndex: 89165
	{
		// Fields
		public IntPtr dirtyTex; // 0x00
		public float intensity; // 0x08
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGRadialBlurCPP // TypeDefIndex: 89166
	{
		// Fields
		public bool enabled; // 0x00
		public Vector2 center; // 0x04
		public float intensity; // 0x0C
		public float power; // 0x10
		public bool averageSteps; // 0x14
		public bool enableGlobalCenter; // 0x15
		public Vector3 globalCenter; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGHorizontalBlurCPP // TypeDefIndex: 89167
	{
		// Fields
		public bool enabled; // 0x00
		public bool useBlurTarget; // 0x01
		public bool useBlurCenter; // 0x02
		public bool _pad0; // 0x03
		public float radius; // 0x04
		public float blurTargetAngleDeg; // 0x08
		public float blurCenterFadeWidth; // 0x0C
		public Vector2 blurCenter; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGSplitScreenZoomCPP // TypeDefIndex: 89168
	{
		// Fields
		public bool enabled; // 0x00
		public bool flipY; // 0x01
		public bool _pad0; // 0x02
		public bool _pad1; // 0x03
		public float splitPosition; // 0x04
		public float dividerWidth; // 0x08
		public Vector2 leftCenter; // 0x0C
		public Vector2 rightCenter; // 0x14
		public float leftZoom; // 0x1C
		public float rightZoom; // 0x20
		public float lineAngle; // 0x24
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGChromaticAbberationCPP // TypeDefIndex: 89169
	{
		// Fields
		public bool enabled; // 0x00
		public Vector2 center; // 0x04
		public float intensity; // 0x0C
		public bool averageStep; // 0x10
		public bool enableGlobalCenter; // 0x11
		public Vector3 globalCenter; // 0x14
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGBWFlashCPP // TypeDefIndex: 89170
	{
		// Fields
		public bool enabled; // 0x00
		public Vector2 centerPosition; // 0x04
		public float bwSceneLerp; // 0x0C
		public float bwThreshold; // 0x10
		public float colorBias; // 0x14
		public bool inverse; // 0x18
		public bool useFlashTex; // 0x19
		public IntPtr flashTexture; // 0x20
		public Vector2 flashTexTiling; // 0x28
		public Vector2 flashTexOffset; // 0x30
		public Vector2 flashTexSpeed; // 0x38
		public Vector2 flashIntensity; // 0x40
		public bool useMaskTex; // 0x48
		public IntPtr maskTexture; // 0x50
		public float maskIntensity; // 0x58
		public bool maskUsePolarUV; // 0x5C
		public Vector2 maskTexTiling; // 0x60
		public Vector2 maskTexOffset; // 0x68
		public UnityEngine.Color flashColor; // 0x70
		public UnityEngine.Color backGroundColor; // 0x80
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct SharpenVolumeCPP // TypeDefIndex: 89171
	{
		// Fields
		public bool isActive; // 0x00
		public HGSharpenMode sharpenMode; // 0x04
		public float sharpenRange; // 0x08
		public float sharpenIntensity; // 0x0C
		public float sharpenThreshold; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGWaterEnvConfigCPP // TypeDefIndex: 89172
	{
		// Fields
		public float waterInteractionStrengthMultiplier; // 0x00
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGInkWashBaseConfigCPP // TypeDefIndex: 89173
	{
		// Fields
		public IntPtr baseMaterial; // 0x00
		public float verticalFadeStart; // 0x08
		public float verticalFadeEnd; // 0x0C
		public float verticalFadeAffectDist; // 0x10
		public float verticalFadeFadeDist; // 0x14
		public float groundColorAdj; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGInkWashOverlayConfigCPP // TypeDefIndex: 89174
	{
		// Fields
		public IntPtr overlayMaterial; // 0x00
		public float verticalFadeStart; // 0x08
		public float verticalFadeEnd; // 0x0C
		public float verticalFadeAffectDist; // 0x10
		public float verticalFadeFadeDist; // 0x14
		public float groundColorAdj; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGInkWashMaskConfigCPP // TypeDefIndex: 89175
	{
		// Fields
		public IntPtr maskMaterial; // 0x00
		public bool addNewInkDrop; // 0x08
		public float inkDropSize; // 0x0C
		public float inkBleedingSpeed; // 0x10
		public Vector3 currInkPointDir; // 0x14
		public float inkBleedingDeltaTime; // 0x20
		public float inkStrokeSeed; // 0x24
		public float atlasSize; // 0x28
		public float edgeFade; // 0x2C
		public float splashDecayFactor; // 0x30
		public float trailDecayFactor; // 0x34
		public float strokeDecayFactor; // 0x38
		public float modeSwitch; // 0x3C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGInkWashConfigCPP // TypeDefIndex: 89176
	{
		// Fields
		public bool enable; // 0x00
		public float intensity; // 0x04
		public float distortIntensity; // 0x08
		public float distortSpeed; // 0x0C
		public float inkDistortDeltaTime; // 0x10
		public bool isDrawing; // 0x14
		public bool ignoreCharacter; // 0x15
		public float screenFade; // 0x18
		public HGInkWashBaseConfigCPP baseConfig; // 0x20
		public HGInkWashOverlayConfigCPP overlayConfig; // 0x40
		public HGInkWashMaskConfigCPP maskConfig; // 0x60
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGVolumeComponentsDataCPP // TypeDefIndex: 89177
	{
		// Fields
		public unsafe BloomVolumeCPP* m_bloomVolume; // 0x00
		public unsafe VignetteCPP* m_vignette; // 0x08
		public unsafe HGVignetteCPP* m_hgVignette; // 0x10
		public unsafe HGDirtyLensCPP* m_hgDirtyLens; // 0x18
		public unsafe SharpenVolumeCPP* m_sharpenVolume; // 0x20
		public unsafe HGRadialBlurCPP* m_radialBlur; // 0x28
		public unsafe HGBWFlashCPP* m_bwFlash; // 0x30
		public unsafe FishEyeEffectVolumeCPP* m_fishEyeVolume; // 0x38
		public unsafe HGChromaticAbberationCPP* m_chromaticAbberation; // 0x40
		public unsafe ScreenSpaceReflectionVolumeCPP* m_hgssrVolume; // 0x48
		public unsafe HGHorizontalBlurCPP* m_horizontalBlur; // 0x50
		public unsafe HGSplitScreenZoomCPP* m_splitScreenZoom; // 0x58
	}

	[UsedByNativeCode]
	public enum FrameInterpolationAlgo // TypeDefIndex: 89178
	{
		Vendor = 0,
		HGFI = 1,
		Blit = 2
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/FrameGeneration/HGFrameInterpolator.h")]
	[UsedByNativeCode]
	public struct HGCPPFrameInterpolatorUtil // TypeDefIndex: 89179
	{
		// Methods
		[FreeFunction("SetAFMECameraFallbackThreshold")]
		[UsedByNativeCode]
		public static void SetAFMECameraFallbackThreshold(float rotationCos, float moveDistanceSqr); // 0x000000018D520F74-0x000000018D520FC0
		[FreeFunction("SetMFRCGeneralallbackThreshold")]
		[UsedByNativeCode]
		public static void SetMFRCGeneralallbackThreshold(float vaule); // 0x000000018D520FFC-0x000000018D521038
		[FreeFunction("SetMFRCBrightnessDiffFallbackThreshold")]
		[UsedByNativeCode]
		public static void SetMFRCBrightnessDiffFallbackThreshold(float vaule); // 0x000000018D520FC0-0x000000018D520FFC
		[FreeFunction("SetMFRCRepeatedPatternFallbackThreshold")]
		[UsedByNativeCode]
		public static void SetMFRCRepeatedPatternFallbackThreshold(float vaule); // 0x000000018D521038-0x000000018D521074
	}

	public enum HGLensFlareBlendMode // TypeDefIndex: 89180
	{
		Additive = 0,
		Screen = 1,
		Premultiply = 2,
		Lerp = 3
	}

	public enum HGLensFlareDistribution // TypeDefIndex: 89181
	{
		Uniform = 0,
		Curve = 1,
		Random = 2
	}

	public enum HGLensFlareType // TypeDefIndex: 89182
	{
		Image = 0,
		Circle = 1,
		Polygon = 2
	}

	public struct HGLensFlareDrawData // TypeDefIndex: 89183
	{
		// Fields
		public bool useOcclusion; // 0x00
		public bool allowMultipleElement; // 0x01
		public bool inverseSDF; // 0x02
		public int elementCount; // 0x04
		public HGLensFlareBlendMode blendMode; // 0x08
		public HGLensFlareDistribution distribution; // 0x0C
		public HGLensFlareType flareType; // 0x10
		public CBHandle lensFlareCBHandle; // 0x18
		public IntPtr flareOcclusionTexture; // 0x30
		public IntPtr flareTexture; // 0x38
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/HGRenderPipelineDebugResources.h")]
	[UsedByNativeCode]
	public struct HGRenderPipelineDebugResourcesShaderResourcesCPP // TypeDefIndex: 89184
	{
		// Fields
		public int debugFullScreenClearBufferCS; // 0x00
		public int debugFetchPixelDataCS; // 0x04
		public int debugFetchQuadOverdrawDataCS; // 0x08
		public int debugFetchRegularPerformanceDataCS; // 0x0C
		public int debugReflectionProbeCS; // 0x10
		public int debugDepthPyramidReadbackCS; // 0x14
		public int debugReflectionProbePS; // 0x18
		public int debugDisplayPS; // 0x1C
		public int debugGizmosShapePS; // 0x20
		public int debugGizmosDecalPS; // 0x24
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/HGRenderPipelineDebugResources.h")]
	[UsedByNativeCode]
	public struct HGRenderPipelineDebugResourcesMaterialResourcesCPP // TypeDefIndex: 89185
	{
		// Fields
		public int debugGizmosMat; // 0x00
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/HGRenderPipelineDebugResources.h")]
	[UsedByNativeCode]
	public struct HGRenderPipelineDebugResourcesTextureResourcesCPP // TypeDefIndex: 89186
	{
		// Fields
		public int debugTexelDensityTexArray; // 0x00
		public int debugAlbedoTex; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/HGRenderPipelineDebugResources.h")]
	[UsedByNativeCode]
	public struct HGRenderPipelineDebugResourcesCPP // TypeDefIndex: 89187
	{
		// Fields
		public bool enable; // 0x00
		public HGRenderPipelineDebugResourcesShaderResourcesCPP shaders; // 0x04
		public HGRenderPipelineDebugResourcesMaterialResourcesCPP materials; // 0x2C
		public HGRenderPipelineDebugResourcesTextureResourcesCPP textures; // 0x30
	}

	[UsedByNativeCode]
	public struct HGRenderPipelineRuntimeResourcesShaderResourcesCPP // TypeDefIndex: 89188
	{
		// Fields
		public int defaultPS; // 0x00
		public int defaultUnlitPS; // 0x04
		public int inkSimulationPS; // 0x08
		public int characterLitPS; // 0x0C
		public int characterLitHairPS; // 0x10
		public int characterLitSkinPS; // 0x14
		public int deferredPS; // 0x18
		public int deferredWriteAlphaPS; // 0x1C
		public int deferredPerLightPS; // 0x20
		public int colorPyramidPS; // 0x24
		public int depthPyramidCS; // 0x28
		public int buildHZBCS; // 0x2C
		public int maxZCS; // 0x30
		public int lightBinningXYCS; // 0x34
		public int lightBinningZCS; // 0x38
		public int singleColorPS; // 0x3C
		public int particleCleanupCS; // 0x40
		public int particleInitCS; // 0x44
		public int particleCullCS; // 0x48
		public int particleSortCS; // 0x4C
		public int particleIndirectArgsCS; // 0x50
		public int physicalParticleEmitCS; // 0x54
		public int senderParticleEmitCS; // 0x58
		public int recieverParticleEmitCS; // 0x5C
		public int physicalParticleSimulateCS; // 0x60
		public int senderParticleSimulateCS; // 0x64
		public int recieverParticleSimulateCS; // 0x68
		public int physicalParticleRenderPS; // 0x6C
		public int reflectionProbeBinningCS; // 0x70
		public int GTAmbientOcclusionCS; // 0x74
		public int copyChannelCS; // 0x78
		public int clearStencilBufferPS; // 0x7C
		public int copyStencilBufferPS; // 0x80
		public int copyDepthBufferPS; // 0x84
		public int blitPS; // 0x88
		public int blitColorAndDepthPS; // 0x8C
		public int blitMotionVectorPS; // 0x90
		public int vsmPassPS; // 0x94
		public int blurPS; // 0x98
		public int horizontalBlurPS; // 0x9C
		public int lowResBlitPS; // 0xA0
		public int copyBufferCS; // 0xA4
		public int taauDilationPS; // 0xA8
		public int taauMaskDilationPS; // 0xAC
		public int taauResolvePS; // 0xB0
		public int encodeBC6HCS; // 0xB4
		public int cubeToPanoPS; // 0xB8
		public int blitCubeTextureFacePS; // 0xBC
		public int clearUIntTextureCS; // 0xC0
		public int texture3DAtlasCS; // 0xC4
		public int shadowClearPS; // 0xC8
		public int shadowBlitPS; // 0xCC
		public int shadowBlurPS; // 0xD0
		public int lowResDirectionalShadowPS; // 0xD4
		public int screenSpaceShadowResolvePS; // 0xD8
		public int shadowDecalProjectorPS; // 0xDC
		public int capsuleShadowCasterPS; // 0xE0
		public int hizDownSampleCS; // 0xE4
		public int renderAtmosphereLutPS; // 0xE8
		public int renderAtmosphereLutCS; // 0xEC
		public int proceduralSkyPS; // 0xF0
		public int skyBoxCubemapPS; // 0xF4
		public int volumetricFogGridInjectionCS; // 0xF8
		public int volumetricFogLightScatteringCS; // 0xFC
		public int volumetricFogFinalIntegrationCS; // 0x100
		public int bakeFogLutPS; // 0x104
		public int clothDataUploadCS; // 0x108
		public int clothSingleDispatchCS; // 0x10C
		public int drawInteractionNodePS; // 0x110
		public int terrainRenderCS; // 0x114
		public int terrainRenderPS; // 0x118
		public int terrainCSV3; // 0x11C
		public int terrainPSV3; // 0x120
		public int terrainDeformGenerateCSV3; // 0x124
		public int terrainDeformEditorGenerateCS; // 0x128
		public int terrainDeformEditorGroundLayerCS; // 0x12C
		public int terrainDeformGenerateV2CS; // 0x130
		public int terrainDeformGenerateCS; // 0x134
		public int terrainDeformReprojectHistoryCS; // 0x138
		public int terrainDeformSpatialFilterCS; // 0x13C
		public int terrainDeformGenerateNormalCS; // 0x140
		public int terrainDeformGenerateDensityCS; // 0x144
		public int terrainDeformEdgeDetectionCS; // 0x148
		public int terrainGroundLayerClipmapCS; // 0x14C
		public int lutBuilder3DCS; // 0x150
		public int lutBuilder2DPS; // 0x154
		public int hgAutoExposureHistogramCS; // 0x158
		public int uberPostPS; // 0x15C
		public int CutsceneEffectPS; // 0x160
		public int bloomPS; // 0x164
		public int sharpenPS; // 0x168
		public int finalPassPS; // 0x16C
		public int blitBackBufferPS; // 0x170
		public int bloomPrefilterCS; // 0x174
		public int bloomBlurCS; // 0x178
		public int bloomBlurNonOptCS; // 0x17C
		public int bloomUpsampleCS; // 0x180
		public int skillScanLinePS; // 0x184
		public int sceneColorAdjustmentPS; // 0x188
		public int frostedGlassBlurCS; // 0x18C
		public int frostedGlassBlurPS; // 0x190
		public int lensFlareDataDrivenPS; // 0x194
		public int uiImageBlurPS; // 0x198
		public int smaaPS; // 0x19C
		public int lightShaftPS; // 0x1A0
		public int anamorphicStreaksPS; // 0x1A4
		public int anamorphicStreaksCS; // 0x1A8
		public int depthOfFieldPS; // 0x1AC
		public int depthOfFieldMobilePS; // 0x1B0
		public int depthOfFieldHexagonalPS; // 0x1B4
		public int circleDepthOfFieldCS; // 0x1B8
		public int motionBlurCS; // 0x1BC
		public int screenSpaceReflectionCS; // 0x1C0
		public int screenSpaceReflectionPS; // 0x1C4
		public int ssprCS; // 0x1C8
		public int contactShadowCS; // 0x1CC
		public int foliageOccluderPS; // 0x1D0
		public int foliageOccluderBlitPS; // 0x1D4
		public int foliageInteractiveBlitPS; // 0x1D8
		public int foliageInteractiveColliderPS; // 0x1DC
		public int sludgeBlitPS; // 0x1E0
		public int sludgePS; // 0x1E4
		public int waterRenderingPS; // 0x1E8
		public int waterOcclusionCS; // 0x1EC
		public int rippleRangePS; // 0x1F0
		public int rippleSimulationPS; // 0x1F4
		public int rippleHeightConvertPS; // 0x1F8
		public int waterProxyPS; // 0x1FC
		public int waterForwardRenderingPS; // 0x200
		public int waterTextureProcessPS; // 0x204
		public int ivBakeV2CS; // 0x208
		public int ivIndirectV2CS; // 0x20C
		public int ivBakeV3CS; // 0x210
		public int ivClipmapUpdateCS; // 0x214
		public int ivUpdateV3CS; // 0x218
		public int ivCopyBufferCS; // 0x21C
		public int hgSchemaCS; // 0x220
		public int gpuParticleCommonCS; // 0x224
		public int windMotorInjectionCS; // 0x228
		public int giGridBuildCS; // 0x22C
		public int giProbeTraceCS; // 0x230
		public int giPrepareDispatchCS; // 0x234
		public int giProbeBlendCS; // 0x238
		public int giFinalGatherCS; // 0x23C
		public int giReferencePathTracingCS; // 0x240
		public int giReferencePathTracingRayQueryCS; // 0x244
		public int giDenoiseV2CS; // 0x248
		public int geoNormalCS; // 0x24C
		public int giProbeVisualizationPS; // 0x250
		public int giWRCDebugViewCS; // 0x254
		public int giProbeInspectorReadbackCS; // 0x258
		public int giIndirectBlackoutClearCS; // 0x25C
		public int giRadianceCacheEvictionCS; // 0x260
		public int wsgDebugDrawPS; // 0x264
		public int volumetricComposePS; // 0x268
		public int farRainPS; // 0x26C
		public int sceneEffectRainPS; // 0x270
		public int screenRainDropFXShader; // 0x274
		public int rainSplashShader; // 0x278
		public int scanLineHighlightShader; // 0x27C
		public int fakeVolumeFogPS; // 0x280
		public int clearDepth; // 0x284
		public int particleLightingCS; // 0x288
		public int shaderLODPS; // 0x28C
		public int visibilitySHPS; // 0x290
		public int visibilitySHCS; // 0x294
		public int dlssVelocityCombineCS; // 0x298
		public int dlssGFlipBlitCS; // 0x29C
		public int dlssGUIHintCS; // 0x2A0
		public int rayTracingReflectionPS; // 0x2A4
		public int rayTracingBinningCS; // 0x2A8
		public int rtrVariableRateCS; // 0x2AC
		public int rtrScreenSpaceReflectionCS; // 0x2B0
		public int rtrRayTracingReflectionCS; // 0x2B4
		public int rtrRayTracingMobileCS; // 0x2B8
		public int rtrDenoiseCS; // 0x2BC
		public int rtrDenoiseMobileCS; // 0x2C0
		public int rtrMaterialSortingCS; // 0x2C4
		public int rtrMaterialSortingFallbackCS; // 0x2C8
		public int rtrVariableMixedResolutionCS; // 0x2CC
		public int rtrScreenSpaceReflectionV2CS; // 0x2D0
		public int gpuDrivenInitCS; // 0x2D4
		public int gpuDrivenCullingCS; // 0x2D8
		public int gpuDrivenCullingWaveBasicCS; // 0x2DC
		public int gpuGrassInitCS; // 0x2E0
		public int gpuGrassCullCS; // 0x2E4
		public int fontGenerateSDFPS; // 0x2E8
		public int hgFSR3ResolvedMotionVectors; // 0x2EC
		public int fsr3PrepareInputCS; // 0x2F0
		public int fsr3ComputeLuminancePyramid; // 0x2F4
		public int fsr3ComputeLuminanceInstability; // 0x2F8
		public int fsr3ComputeShadingChangePyramid; // 0x2FC
		public int fsr3ComputeShadingChange; // 0x300
		public int fsr3PrepareReactivity; // 0x304
		public int fsr3Accumulate; // 0x308
		public int fsr3RCAS; // 0x30C
		public int fsr3OpticalFlowPrepareLumaCS; // 0x310
		public int fsr3OpticalFlowComputeSCDDivergenceCS; // 0x314
		public int fsr3OpticalFlowFilterOpticalFlowCS; // 0x318
		public int fsr3OpticalFlowGenerateSCDHistogramCS; // 0x31C
		public int fsr3OpticalFlowComputeLuminacePyramidCS; // 0x320
		public int fsr3OpticalFlowScaleOpticalFlowAdvancedCS; // 0x324
		public int fsr3OpticalFlowComputeOpticalFlowAdvancedCS; // 0x328
		public int fsr3FrameInterpolationCS; // 0x32C
		public int fsr3FrameInterpolationSetupCS; // 0x330
		public int fsr3FrameInterpolationInpaintingCS; // 0x334
		public int fsr3FrameInterpolationDisocclusionMaskCS; // 0x338
		public int fsr3FrameInterpolationReconstructAndDilateCS; // 0x33C
		public int fsr3FrameInterpolationGameMotionVectorFiledCS; // 0x340
		public int fsr3FrameInterpolationOpticalFlowVectorFiledCS; // 0x344
		public int fsr3FrameInterpolationComputeInpaintingPyramidCS; // 0x348
		public int fsr3FrameInterpolationReconstructPreviousDepthCS; // 0x34C
		public int fsr3FrameInterpolationComputeGameVectorFieldInpaintingPyramidCS; // 0x350
		public int frameInterpolationInputConvertPS; // 0x354
		public int textureStreamingFeedbackProcessReadbackBufferCS; // 0x358
	}

	[UsedByNativeCode]
	public struct HGRenderPipelineRuntimeResourcesTextureResourcesCPP // TypeDefIndex: 89189
	{
		// Fields
		public int HeightFogNoise3DTex; // 0x00
		public int HeightFogNoisePerturb3DTex; // 0x04
		public int GlintCellNoiseTex; // 0x08
		public int PerlinNoiseTex; // 0x0C
		public int SnowDetailNormal; // 0x10
		public int VisibilityABLut; // 0x14
		public int VisibilitySHLut; // 0x18
		public int WindGlobalNoiseTex; // 0x1C
		public int fgBlueNoiseTile; // 0x20
		public int farRainTex0; // 0x24
		public int farRainTex1; // 0x28
		public int sceneEffectRainTex; // 0x2C
		public int rainWaveTex; // 0x30
		public int screenDropFXNoiseTex; // 0x34
		public int verticalFlowTexture; // 0x38
		public int rippleTexture; // 0x3C
		public int rainSplashTexture; // 0x40
		public int rainOcclusionSampleNoise; // 0x44
		public int snowflakeTex; // 0x48
		public int ltc1Lut; // 0x4C
		public int ltc2Lut; // 0x50
	}

	[UsedByNativeCode]
	public struct HGRenderPipelineRuntimeResourcesAssetResourcesCPP // TypeDefIndex: 89190
	{
		// Fields
		public int simpleSphereMesh; // 0x00
		public int defaultCapsuleMesh; // 0x04
		public int defaultCubeMesh; // 0x08
		public int defaultConeMesh; // 0x0C
		public int defaultQuadMesh; // 0x10
		public int farRainSpindleMesh; // 0x14
		public int sceneEffectRainMesh; // 0x18
		public int rainSplashMesh; // 0x1C
	}

	[UsedByNativeCode]
	public struct HGRenderPipelineRuntimeResourcesCPP // TypeDefIndex: 89191
	{
		// Fields
		public HGRenderPipelineRuntimeResourcesShaderResourcesCPP shaders; // 0x00
		public HGRenderPipelineRuntimeResourcesTextureResourcesCPP textures; // 0x35C
		public HGRenderPipelineRuntimeResourcesAssetResourcesCPP assets; // 0x3B0
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/InkSimulationPass.h")]
	[UsedByNativeCode]
	public struct InkSimulationPassInput // TypeDefIndex: 89194
	{
		// Fields
		public float influence; // 0x00
		public Vector3 center; // 0x04
		public float deltaTime; // 0x10
		public int simulationResolution; // 0x14
		public int densityResolution; // 0x18
		public float worldSize; // 0x1C
		public float inkViscosity; // 0x20
		public float inkDebugJacobi; // 0x24
		public float inkVorticity; // 0x28
		public unsafe fixed /* 0x00000000-0x00000000 */ float inkSimulationDynamicData[0]; // 0x2C
		public unsafe fixed /* 0x00000000-0x00000000 */ float inkSimulationConfigData[0]; // 0x22C
		public int enableExtraInkData; // 0x2EC
		public int enableInkRipple; // 0x2F0
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _inkSimulationDynamicData_e__FixedBuffer // TypeDefIndex: 89192
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _inkSimulationConfigData_e__FixedBuffer // TypeDefIndex: 89193
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDeformPass.h")]
	[UsedByNativeCode]
	public struct TerrainDeformPassInput // TypeDefIndex: 89195
	{
		// Fields
		public IntPtr drawInteractionNodeMaterial; // 0x00
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct TerrainDepthPrepassInput // TypeDefIndex: 89196
	{
		// Fields
		public bool enableTerrainTessellation; // 0x00
		public bool enableTerrainSubdivision; // 0x01
		public bool enableTerrainSubdivisionV2; // 0x02
		public bool enableTerrainDecalDeform; // 0x03
		public bool enableTerrainWetRipple; // 0x04
		public bool enableTerrainBlendInCinematicMode; // 0x05
		public unsafe HGTerrainLayerTypeData* layerTypeData; // 0x08
		public int subdivisionHandle; // 0x10
		public uint terrainCullViewHandle; // 0x14
		public uint editorTerrainCullViewHandle; // 0x18
		public int vtFeedbackId; // 0x1C
		public Vector4 terrainVTUpdatePos; // 0x20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainV3/HGTerrainRenderer.h")]
	[UsedByNativeCode]
	public struct TerrainRendererInput // TypeDefIndex: 89197
	{
		// Fields
		public bool enableDeform; // 0x00
		public bool enableSubd; // 0x01
		public bool enableDecalDeform; // 0x02
		public bool enableWetRipple; // 0x03
		public bool useRuntimeBlend; // 0x04
		public bool enableShadow; // 0x05
		public unsafe HGTerrainLayerTypeData* layerTypeData; // 0x08
		public uint terrainCullViewHandle; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/Utils.h")]
	[UsedByNativeCode]
	public struct HGViewConstantsCPP // TypeDefIndex: 89198
	{
		// Fields
		public Matrix4x4 viewMatrix; // 0x00
		public Matrix4x4 invViewMatrix; // 0x40
		public Matrix4x4 projMatrix; // 0x80
		public Matrix4x4 nonJitteredProjMatrix; // 0xC0
		public Matrix4x4 invProjMatrix; // 0x100
		public Matrix4x4 viewProjMatrix; // 0x140
		public Matrix4x4 viewNoTransProjMatrix; // 0x180
		public Matrix4x4 invViewProjMatrix; // 0x1C0
		public Matrix4x4 nonJitteredViewProjMatrix; // 0x200
		public Matrix4x4 nonJitteredViewNoTransProjMatrix; // 0x240
		public Matrix4x4 invNonJitteredViewProjMatrix; // 0x280
		public Matrix4x4 prevViewMatrix; // 0x2C0
		public Matrix4x4 prevViewProjMatrix; // 0x300
		public Matrix4x4 prevViewNoTransProjMatrix; // 0x340
		public Matrix4x4 prevNonJitteredViewProjMatrix; // 0x380
		public Matrix4x4 prevNonJitteredViewNoTransProjMatrix; // 0x3C0
		public Matrix4x4 prevInvViewProjMatrix; // 0x400
		public Matrix4x4 prevNonJitteredInvViewProjMatrix; // 0x440
		public Matrix4x4 reprojectionMatrix; // 0x480
		public Matrix4x4 widerFoVViewProjMatrix; // 0x4C0
		public Matrix4x4 widerFoVInvViewProjMatrix; // 0x500
		public Matrix4x4 pixelCoordToViewDirWS; // 0x540
		public Matrix4x4 cullingMatrix; // 0x580
		public Vector3 worldSpaceCameraPos; // 0x5C0
		public float pad0; // 0x5CC
		public Vector3 worldSpaceCameraPosViewOffset; // 0x5D0
		public float pad1; // 0x5DC
		public Vector3 prevWorldSpaceCameraPos; // 0x5E0
		public float pad2; // 0x5EC
	}

	[UsedByNativeCode]
	public struct HGRenderPathOtherData // TypeDefIndex: 89207
	{
		// Fields
		public bool taaEnabled; // 0x00
		public float taaSharpenStrength; // 0x04
		public int taaFrameIndex; // 0x08
		public int taaJitterPhaseCount; // 0x0C
		public Vector4 taaJitter; // 0x10
		public float globalMipBias; // 0x20
		public float characterLightSmoothFactor; // 0x24
		public float time; // 0x28
		public float lastTime; // 0x2C
		public float gameplayTime; // 0x30
		public float lastGameplayTime; // 0x34
		public float deltaTime; // 0x38
		public float smoothDeltaTime; // 0x3C
		public uint frameCount; // 0x40
		public Vector4 _Style_MatDistCoef; // 0x44
		public Vector4 _Style_MatFarAlb0; // 0x54
		public Vector4 _Style_MatFarAlb1; // 0x64
		public Vector4 _Style_GbFarEms; // 0x74
		public Vector4 _Style_GbFarDir; // 0x84
		public Vector4 _Style_GbCoef; // 0x94
		public Vector4 _VFXParams0; // 0xA4
		public Vector4 _VFXParams1; // 0xB4
		public Vector4 _VFXParams2; // 0xC4
		public Vector4 _VFXParams3; // 0xD4
		public Vector4 _CharacterParams0; // 0xE4
		public Vector4 _CharacterParams1; // 0xF4
		public Vector4 _CharacterParams2; // 0x104
		public Vector4 _CharacterParams3; // 0x114
		public Vector4 _CharacterParams4; // 0x124
		public Vector4 _CharacterParams5; // 0x134
		public Vector4 _CharacterParams6; // 0x144
		public Vector4 _CharacterParams7; // 0x154
		public Vector4 _CharacterParams8; // 0x164
		public Vector4 _CharacterParams9; // 0x174
		public Vector4 _CharacterParams10; // 0x184
		public Vector4 _CharacterParams11; // 0x194
		public Vector4 _CharacterParams12; // 0x1A4
		public Vector4 _CharacterParams13; // 0x1B4
		public Vector4 _CharacterParams14; // 0x1C4
		public Vector4 _CharacterParams15; // 0x1D4
		public Vector4 _CharacterParams16; // 0x1E4
		public Vector4 _IVParam0; // 0x1F4
		public Vector4 _IVParam1; // 0x204
		public Vector4 _IVParam2; // 0x214
		public Vector4 _IVDefaultSHAr; // 0x224
		public Vector4 _IVDefaultshAg; // 0x234
		public Vector4 _IVDefaultshAb; // 0x244
		public IntPtr indirectionTexture; // 0x258
		public IntPtr physicalTexture0; // 0x260
		public IntPtr physicalTexture1; // 0x268
		public Vector4 _IVV2Param0; // 0x270
		public Vector4 _IVV2Param1; // 0x280
		public Vector4 _IVV2Param2; // 0x290
		public Vector4 _IVV2Param3; // 0x2A0
		public IntPtr clipmapTextureALod0; // 0x2B0
		public IntPtr clipmapTextureBLod0; // 0x2B8
		public IntPtr clipmapTextureALod1; // 0x2C0
		public IntPtr clipmapTextureBLod1; // 0x2C8
		public IntPtr clipmapTextureALod3; // 0x2D0
		public IntPtr clipmapTextureBLod3; // 0x2D8
		public IntPtr _CharMaxCubemap; // 0x2E0
		public IntPtr _CharacterRainEffectTex; // 0x2E8
		public IntPtr _CharacterRainStreakTex; // 0x2F0
		public IntPtr _CharacterRainFaceDripTex; // 0x2F8
		public IntPtr _CharacterRainFaceDropletTex; // 0x300
		public IntPtr _CharacterSnowEffectTex; // 0x308
		public Vector4 _WindGlobalParams0; // 0x310
		public Vector4 _WindGlobalParams2; // 0x320
		public Vector4 _CharacterPositionParams0; // 0x330
		public Vector4 _CharacterPositionParams1; // 0x340
		public Vector4 _CharacterPositionParams2; // 0x350
		public Vector4 _CharacterPositionParams3; // 0x360
		public Vector4 _CharacterHeightParams; // 0x370
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams0[0]; // 0x380
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams1[0]; // 0x3C0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams2[0]; // 0x400
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams3[0]; // 0x440
		public Vector4 _WindMotorCount; // 0x480
		public Vector4 _LastWindGlobalParams0; // 0x490
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams0[0]; // 0x4A0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams1[0]; // 0x4E0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams3[0]; // 0x520
		public Vector4 _WaterInteractionParams0; // 0x560
		public Vector4 _WaterInteractionParams1; // 0x570
		public Vector4 _RainWetnessGlobalParam0; // 0x580
		public Vector4 _RainWetnessGlobalParam1; // 0x590
		public Vector4 _RainWetnessGlobalParam2; // 0x5A0
		public Vector4 _RainWetnessGlobalParam3; // 0x5B0
		public Vector4 _RainWetnessGlobalParam4; // 0x5C0
		public Vector4 _RainWetnessGlobalParam5; // 0x5D0
		public Vector4 _RainWetnessGlobalParam6; // 0x5E0
		public Vector4 _RainWetnessGlobalParam7; // 0x5F0
		public Vector4 _RainWetnessGlobalParam8; // 0x600
		public Vector4 _RainWetnessGlobalParam9; // 0x610
		public Vector4 _RainWetnessGlobalParam10; // 0x620
		public IntPtr verticalFlowTexture; // 0x630
		public IntPtr rippleTexture; // 0x638
		public IntPtr rainOcclusionSampleJitterNoise; // 0x640
		public Vector4 _VerticalOcclusionMapParam0; // 0x648
		public bool enabledVerticalOcclusion; // 0x658
		public Vector4 _InteractRaftParams0; // 0x65C
		public Vector4 _InteractRaftParams1; // 0x66C
		public unsafe fixed /* 0x00000000-0x00000000 */ float _HackTempDataBeforeCPPPlugin[0]; // 0x67C
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __WindMotorParams0_e__FixedBuffer // TypeDefIndex: 89199
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __WindMotorParams1_e__FixedBuffer // TypeDefIndex: 89200
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __WindMotorParams2_e__FixedBuffer // TypeDefIndex: 89201
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __WindMotorParams3_e__FixedBuffer // TypeDefIndex: 89202
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __LastWindMotorParams0_e__FixedBuffer // TypeDefIndex: 89203
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __LastWindMotorParams1_e__FixedBuffer // TypeDefIndex: 89204
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __LastWindMotorParams3_e__FixedBuffer // TypeDefIndex: 89205
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct __HackTempDataBeforeCPPPlugin_e__FixedBuffer // TypeDefIndex: 89206
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/ReflectionProbeBinningPass.h")]
	[UsedByNativeCode]
	public struct HGReflectionProbeBinningInput // TypeDefIndex: 89208
	{
		// Fields
		public bool enable; // 0x00
		public bool reset; // 0x01
		public bool alwaysBlend; // 0x02
		public bool enableFadeness; // 0x03
		public uint viewHandle; // 0x04
		public float dt; // 0x08
		public int defaultTextureCount; // 0x0C
		public unsafe int* defaultTextureInstanceIDs; // 0x10
		public unsafe float* defaultTextureFactors; // 0x18
		public Vector4 defaultTextureSHLuminance; // 0x20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/SkyRenderer.h")]
	[UsedByNativeCode]
	public struct SkyRendererInput // TypeDefIndex: 89209
	{
		// Fields
		public bool isSkyBoxRenderingEnabled; // 0x00
		public bool shouldRenderSkybox; // 0x01
		public bool shouldRenderSkyCelestial; // 0x02
		public bool shouldRenderSkyCloud; // 0x03
		public bool forceHideSunDisc; // 0x04
		public Vector3 skyCelestialPos; // 0x08
		public Matrix4x4 skyboxMatrix; // 0x14
		public Matrix4x4 skyCloudMatrix; // 0x54
		public IntPtr skyboxMaterial; // 0x98
		public IntPtr skyCloudMaterial; // 0xA0
		public IntPtr icosphereMesh; // 0xA8
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Water/WaterSectorRenderingPass.h")]
	[UsedByNativeCode]
	public struct HGWaterSectorRenderingInput // TypeDefIndex: 89210
	{
		// Fields
		public bool enable; // 0x00
		public int sectorTextureSize; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Water/WaterInteractionRenderingPass.h")]
	[UsedByNativeCode]
	public struct HGWaterInteractionRenderingInput // TypeDefIndex: 89211
	{
		// Fields
		public bool enable; // 0x00
		public CBHandle waterInteractiveCB; // 0x08
		public float deltaTime; // 0x20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Water/WaterRenderingPass.h")]
	[UsedByNativeCode]
	public struct HGWaterRenderingInput // TypeDefIndex: 89212
	{
		// Fields
		public bool enable; // 0x00
		public bool enableUnlit; // 0x01
		public bool enableRain; // 0x02
		public bool enableInk; // 0x03
		public bool shouldStoreDepth; // 0x04
		public bool enableWaterQualityLow; // 0x05
		public uint waterProxyCullHandle; // 0x08
		public uint waterProxyVisibleCount; // 0x0C
		public uint waterDecalCullHandle; // 0x10
		public uint waterDecalVisibleCount; // 0x14
		public int frameShadingRateX; // 0x18
		public int frameShadingRateY; // 0x1C
		public int prepassTextureSize; // 0x20
		public int meshNumPerLOD; // 0x24
		public int lodNum; // 0x28
		public CBHandle waterDataCB; // 0x30
		public Matrix4x4 widerFoVViewProjMatrix; // 0x48
		public Matrix4x4 widerFoVInvViewProjMatrix; // 0x88
		public Matrix4x4 orthoViewProj; // 0xC8
		public Matrix4x4 orthoDeviceViewProj; // 0x108
		public Matrix4x4 orthoDeviceInvViewProj; // 0x148
		public IntPtr globalFlowmapTexture; // 0x188
		public IntPtr globalNormalTextureArray; // 0x190
		public IntPtr globalCausticTexture; // 0x198
		public IntPtr globalRainTexture; // 0x1A0
		public IntPtr planarReflectionTexture; // 0x1A8
		public IntPtr screenSpaceMesh; // 0x1B0
		public int readbackFlags; // 0x1B8
		public int readbackParamsCount; // 0x1BC
		public unsafe Vector4* readbackParams; // 0x1C0
	}

	[Flags]
	public enum HGWaterReadbackFlag // TypeDefIndex: 89213
	{
		None = 0,
		HeightDataTexture = 1,
		HeightNormalTexture = 2,
		HeightDepthTexture = 4,
		DecalDisplacementTexture = 8,
		HeightBuffer = 16
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Water/WaterRenderingPass.h")]
	[UsedByNativeCode]
	public struct HGWaterReadbackData // TypeDefIndex: 89214
	{
		// Fields
		public bool valid; // 0x00
		public IntPtr tempData; // 0x08
		public int width; // 0x10
		public int height; // 0x14
		public int count; // 0x18
		public int format; // 0x1C
		public int stride; // 0x20
		public int readbackIndex; // 0x24
		public int type; // 0x28
		public Vector4 readbackRect; // 0x2C
		public Matrix4x4 orthoDeviceViewProj; // 0x3C
		public Matrix4x4 orthoDeviceInvViewProj; // 0x7C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Water/WaterRenderingPass.h")]
	[UsedByNativeCode]
	public struct HGWaterReadbackOutput // TypeDefIndex: 89215
	{
		// Fields
		public unsafe HGWaterReadbackData* heightData; // 0x00
		public unsafe HGWaterReadbackData* heightNormal; // 0x08
		public unsafe HGWaterReadbackData* heightDepth; // 0x10
		public unsafe HGWaterReadbackData* decalDisplacement; // 0x18
		public unsafe HGWaterReadbackData* heightBuffer; // 0x20
		public Matrix4x4 orthoDeviceViewProj; // 0x28
		public Matrix4x4 orthoDeviceInvViewProj; // 0x68
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
	[UsedByNativeCode]
	public struct HGRenderPathBeforeCullingParamsCPP // TypeDefIndex: 89216
	{
		// Fields
		public int currentDeviceType; // 0x00
		public int currentDeviceTier; // 0x04
		public Vector2Int sceneRTSize; // 0x08
		public uint splitScreenStageLayer; // 0x10
		public uint COMPOUND_CHARACTER_LAYER_MASK; // 0x14
		public unsafe LODCrossFadeConfig* lodCrossFadeConfig; // 0x18
		public unsafe LODCrossFadeConfig* uiCameraLodCrossFadeConfig; // 0x20
		public unsafe HGSettingParametersCpp* settingParameters; // 0x28
		public unsafe HGLightConfigCPP* lightConfig; // 0x30
		public unsafe HGShadowConfigCPP* shadowConfig; // 0x38
		public unsafe HGTerrainLayerTypeData* terrainLayerTypeData; // 0x40
		public float heightFogCullingFarClipPlane; // 0x48
		public float overrideCsmMaxDistanceValue; // 0x4C
		public bool overrideCsmShadowDistance; // 0x50
		public bool enableShadowCulling; // 0x51
		public bool forceRegenerateAsm; // 0x52
		public bool isInIsolatedDisplayMode; // 0x53
		public bool renderPathMobile; // 0x54
		public bool renderCinematicTerrain; // 0x55
		public bool isUICamera; // 0x56
		public bool needRenderTerrain; // 0x57
		public bool enableTerrainDeform; // 0x58
		public bool enableTerrainShadow; // 0x59
		public bool terrainRuntimeBlendV3; // 0x5A
		public bool enableLTCAreaLight; // 0x5B
		public Vector4 terrainVTUpdatePos; // 0x5C
		public bool enableSceneViewLODCrossFade; // 0x6C
		public bool prevTransformReset; // 0x6D
		public bool showOcclusionCulling; // 0x6E
		public uint cullingViewUniqueID; // 0x70
		public unsafe HGCharacterShadowInputsCPP* characterShadowInputs; // 0x78
		public IntPtr hdplsInputs; // 0x80
		public unsafe HGRainWetnessRendererInputCPP* rainWetnessRendererInput; // 0x88
		public unsafe HGSnowRendererInputCPP* snowRendererInput; // 0x90
		public bool scanlineNeedsOcclusion; // 0x98
		public uint debugRenderMode; // 0x9C
		public bool enableTAAU; // 0xA0
		public float time; // 0xA4
		public float occlusionRange; // 0xA8
		public int occlusionMapSize; // 0xAC
		public float occlusionMapHeight; // 0xB0
		public unsafe HGDebugFeaturesManagerCPP* debugFeaturesManager; // 0xB8
		public bool bSkipRender; // 0xC0
		public IntPtr lightClusteringBeforeCullingOutput; // 0xC8
		public IntPtr shadowPassBeforeCullingOutput; // 0xD0
		public IntPtr customDepthOnlyBeforeCullingOutput; // 0xD8
		public uint foliageOccluderCullViewHandle; // 0xE0
		public IntPtr shadowDecalProjectorBeforeCullingOutput; // 0xE8
		public IntPtr renderCamera; // 0xF0
		public IntPtr uiRenderCamera; // 0xF8
		public IntPtr occlusionCamera; // 0x100
		public uint cullingViewHandle; // 0x108
		public uint uiCullingViewHandle; // 0x10C
		public uint rayTracingCullingViewHandle; // 0x110
		public uint rayTracingTLASHandle; // 0x114
		public uint terrainCullViewHandle; // 0x118
		public uint editorTerrainCullViewHandle; // 0x11C
		public int vtFeedbackViewId; // 0x120
		public int subdivisionHandle; // 0x124
		public uint terrainCullViewHandleV3; // 0x128
		public IntPtr visibleLights; // 0x130
		public int visibleLightCount; // 0x138
		public IntPtr rainResult; // 0x140
		public IntPtr snowResult; // 0x148
	}

	[UsedByNativeCode]
	public struct VivoQ3UDSParamsCPP // TypeDefIndex: 89217
	{
		// Fields
		public int serverSRLevel; // 0x00
		public int serverFILevel; // 0x04
		public int srGear; // 0x08
		public bool ignore; // 0x0C
		public bool supported; // 0x0D
		public bool useVivoSpacialFI; // 0x0E
		public bool blitSceneColorToBackbuffer; // 0x0F
	}

	[UsedByNativeCode]
	public struct HGSplitScreenParamsCPP // TypeDefIndex: 89218
	{
		// Fields
		public int enabled; // 0x00
		public int splitAxis; // 0x04
		public float splitPos; // 0x08
		public float crossMarginPx; // 0x0C
		public int stageSide; // 0x10
		public int crossSide; // 0x14
		public uint normalLayerMask; // 0x18
		public uint stageLayerMask; // 0x1C
		public int dividerEnabled; // 0x20
		public float dividerWidthPx; // 0x24
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/PostProcess/VFXPPScanLinePass.h")]
	[UsedByNativeCode]
	public struct HGRenderPathParamsCPP // TypeDefIndex: 89219
	{
		// Fields
		public int currentDeviceType; // 0x00
		public int fogLayer; // 0x04
		public uint COMPOUND_CHARACTER_LAYER_MASK; // 0x08
		public int sizeofShaderVariablesGlobal; // 0x0C
		public int sizeBasicTransformConstants; // 0x10
		public int sizePerPassConstants; // 0x14
		public unsafe HGRenderPathOtherData* otherData; // 0x18
		public unsafe HGSettingParametersCpp* settingParameters; // 0x20
		public unsafe HGViewConstantsCPP* sceneRTViewConstants; // 0x28
		public bool didResetPostProcessingHistoryInLastFrame; // 0x30
		public float enableResponsiveTransparency; // 0x34
		public bool enableTAAU; // 0x38
		public bool fastConvergeState; // 0x39
		public bool enableDLSS; // 0x3A
		public bool disableFrameGenTemporarily; // 0x3B
		public bool ssrEnable; // 0x3C
		public bool shouldRenderPostProcess; // 0x3D
		public bool shouldRenderAtmosphereFog; // 0x3E
		public bool shouldRenderHeightFog; // 0x3F
		public bool shouldRenderVolumetricFog; // 0x40
		public bool shouldBakeFogLut; // 0x41
		public bool enablePlanarReflection; // 0x42
		public bool enableReflectionProbeBaker; // 0x43
		public bool enableAOVOutput; // 0x44
		public bool characterOutlineEnabled; // 0x45
		public bool renderWithAlpha; // 0x46
		public bool sceneViewVolumetricFogEnable; // 0x47
		public bool isInIsolatedDisplayMode; // 0x48
		public bool isFirstFrame; // 0x49
		public bool prevTransformReset; // 0x4A
		public bool shouldRenderRippleState; // 0x4B
		public bool enableEditorMacros; // 0x4C
		public UnityEngine.Color backgroundColorHDR; // 0x50
		public uint cameraFrameCount; // 0x60
		public uint debugRenderMode; // 0x64
		public uint cullingViewHandle; // 0x68
		public float screenCullingRatio; // 0x6C
		public float screenCullingRatioDistance; // 0x70
		public uint screenCullingLayerMask; // 0x74
		public HGSplitScreenParamsCPP splitScreenParams; // 0x78
		public uint rayTracingTLASHandle; // 0xA0
		public unsafe HGEnvironmentPhaseCPP* envPhase; // 0xA8
		public unsafe HGVolumeComponentsDataCPP* volumeComponentsData; // 0xB0
		public unsafe HGVolumeComponentsDataCPP* uiVolumeComponentsData; // 0xB8
		public ulong frameSettingsData0; // 0xC0
		public ulong frameSettingsData1; // 0xC8
		public int lutSize; // 0xD0
		public GraphicsFormat lutFormat; // 0xD4
		public Vector2Int sceneRTSize; // 0xD8
		public GraphicsFormat sceneRTColorFormat; // 0xE0
		public GraphicsFormat sceneRTDepthFormat; // 0xE4
		public Vector2Int taauRTSize; // 0xE8
		public Vector2Int finalRTSize; // 0xF0
		public IntPtr runtimeGizmosDepthRT; // 0xF8
		public IntPtr cullingResults; // 0x100
		public IntPtr visibleLights; // 0x108
		public int visibleLightCount; // 0x110
		public uint uiCullingViewHandle; // 0x114
		public int sortingOrdersToBlurInternalCount; // 0x118
		public unsafe int* sortingOrdersToBlurInternal; // 0x120
		public bool render3DUI; // 0x128
		public bool enableGPUDriven; // 0x129
		public unsafe HGDebugRenderManagerCPP* debugRenderManager; // 0x130
		public unsafe HGDebugFeaturesManagerCPP* debugFeaturesManager; // 0x138
		public IntPtr customDrawRTManager; // 0x140
		public unsafe UIImageBlurPassInputV2* uiImageBlurPassInput; // 0x148
		public bool isPlaying; // 0x150
		public bool isSkyRenderingEnabled; // 0x151
		public bool forceRenderAtmosphereLutEveryFrame; // 0x152
		public bool renderAtmosphereLutUsingCompute; // 0x153
		public unsafe InkSimulationPassInput* inkSimulationPassInput; // 0x158
		public unsafe HGReflectionProbeBinningInput* reflectionProbeBinningInput; // 0x160
		public bool renderPathMobile; // 0x168
		public bool lightsUseLinearIntensity; // 0x169
		public bool isActiveColorSpaceGamma; // 0x16A
		public long ivTargetID; // 0x170
		public unsafe TerrainDeformPassInput* terrainDeformPassInput; // 0x178
		public unsafe TerrainDepthPrepassInput* terrainDepthPrepassInput; // 0x180
		public unsafe TerrainRendererInput* terrainRendererInput; // 0x188
		public unsafe HGWaterSectorRenderingInput* waterSectorRenderingInput; // 0x190
		public unsafe HGWaterInteractionRenderingInput* waterInteractionRenderingInput; // 0x198
		public unsafe HGWaterRenderingInput* waterRenderingInput; // 0x1A0
		public unsafe HGWaterReadbackOutput* waterReadbackOutput; // 0x1A8
		public unsafe HGGTAmbientOcclusionSettingParameters* gtaoSettingParameters; // 0x1B0
		public unsafe HGFakePlanarReflectionRenderingInput* fakePlanarReflectionRenderingInput; // 0x1B8
		public bool flowNoiseEnabled; // 0x1C0
		public bool hasTerrainSimpleSubsurface; // 0x1C1
		public unsafe HGDepthOfFieldParameters* dofParameters; // 0x1C8
		public unsafe HGMotionBlurParametersV2* motionBlurParameters; // 0x1D0
		public unsafe LensFlareRenderingInput* lensFlareRenderingInput; // 0x1D8
		public unsafe ParafinRenderingInput* parafinRenderingInput; // 0x1E0
		public unsafe VFXScreenMaterialData* vfxScreenMaterialData; // 0x1E8
		public unsafe VFXPPScanLinePassInput* vfxPPScanLinePassInput; // 0x1F0
		public unsafe SkyRendererInput* skyRendererInput; // 0x1F8
		public unsafe VisibilitySHRPInput* visibilitySHRPInput; // 0x200
		public unsafe FrostedGlassPassRPInput* frostedGlassPassRPInput; // 0x208
		public unsafe FishEyeEffectInput* fishEyeEffectInput; // 0x210
		public unsafe CutsceneEffectPassRPInput* cutsceneEffectPassRPInput; // 0x218
		public unsafe VolumetricCloudInput* volumetricCloudInput; // 0x220
		public unsafe int* rtExtractionSceneColorLS; // 0x228
		public unsafe int* rtExtractionBlurredSceneColorPS; // 0x230
		public unsafe int* rtExtractionSceneColorPS; // 0x238
		public unsafe int* rtExtractionFinalResult; // 0x240
		public int rtExtractionSceneColorLSCount; // 0x248
		public int rtExtractionBlurredSceneColorPSCount; // 0x24C
		public int rtExtractionSceneColorPSCount; // 0x250
		public int rtExtractionFinalResultCount; // 0x254
		public int waterMarkRTCount; // 0x258
		public unsafe int* waterMarkSrcRTs; // 0x260
		public unsafe int* waterMarkDstRTs; // 0x268
		public unsafe float* waterMarkHeightScales; // 0x270
		public int inplaceWaterMarkRTCount; // 0x278
		public unsafe int* inplaceWaterMarkDstRTs; // 0x280
		public unsafe float* inplaceWaterMarkHeightScales; // 0x288
		public bool forceRegenerateAsm; // 0x290
		public unsafe LODCrossFadeConfig* lodCrossFadeConfig; // 0x298
		public bool bSkipRender; // 0x2A0
		public IntPtr lightClusteringBeforeCullingOutput; // 0x2A8
		public IntPtr shadowPassBeforeCullingOutput; // 0x2B0
		public IntPtr customDepthOnlyBeforeCullingOutput; // 0x2B8
		public uint foliageOccluderCullViewHandle; // 0x2C0
		public IntPtr shadowDecalProjectorBeforeCullingOutput; // 0x2C8
		public float rayTracingReflectionVolumeBlend; // 0x2D0
		public int rayTracingReflectionMode; // 0x2D4
		public unsafe HGRTRDebugData* rtrDebugData; // 0x2D8
		public IntPtr cameraTargetTexture; // 0x2E0
		public int uboAlignment; // 0x2E8
		public IntPtr fontSDFGenerationRequestQueue; // 0x2F0
		public IntPtr uiAtlasManager; // 0x2F8
		public IntPtr rainResult; // 0x300
		public IntPtr snowResult; // 0x308
		public VivoQ3UDSParamsCPP vivoQ3UDSParams; // 0x310
	}

	public enum HGRenderPathInternalCPP // TypeDefIndex: 89220
	{
		Forward = 0,
		UI = 1,
		UI3D = 2,
		DefaultDeferred = 3,
		OnePassDeferredSubpass = 4,
		DebugFullScreen = 5,
		DebugRegularDefaultDeferred = 6,
		DebugRegularOnePassDeferredSubpass = 7,
		Count = 8
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/GTAmbientOcclusionPass.h")]
	[UsedByNativeCode]
	public struct HGGTAmbientOcclusionSettingParameters // TypeDefIndex: 89221
	{
		// Fields
		public bool enableAO; // 0x00
		public bool enableFP32Depths; // 0x01
		public bool enableBentNormals; // 0x02
		public bool generateNormalsInplace; // 0x03
		public int screenWidth; // 0x04
		public int screenHeight; // 0x08
		public int qualityLevel; // 0x0C
		public int denoisePasses; // 0x10
		public int cameraFrameCount; // 0x14
		public float finalValuePower; // 0x18
		public float depthMIPSamplingOffset; // 0x1C
		public bool useCustomSettings; // 0x20
		public float radius; // 0x24
		public float radiusMultiplier; // 0x28
		public float falloffRange; // 0x2C
		public float sampleDistributionPower; // 0x30
		public float thinOccluderCompensation; // 0x34
		public float mvFactor; // 0x38
		public float depthFactor; // 0x3C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/MotionBlurPass.h")]
	[UsedByNativeCode]
	public struct HGMotionBlurParametersV2 // TypeDefIndex: 89222
	{
		// Fields
		public bool enable; // 0x00
		public float shutterAngle; // 0x04
		public float sampleCount; // 0x08
		public float blendFrame; // 0x0C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/LensFlarePass.h")]
	[UsedByNativeCode]
	public struct LensFlareRenderingInput // TypeDefIndex: 89223
	{
		// Fields
		public bool enable; // 0x00
		public unsafe HGLensFlareDrawData* drawDataList; // 0x08
		public int drawDataCount; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/PostProcess/ParafinPass.h")]
	[UsedByNativeCode]
	public struct ParafinRenderingInput // TypeDefIndex: 89224
	{
		// Fields
		public bool enable; // 0x00
		public int parafinMaterialCount; // 0x04
		public unsafe int* parafinMaterialIDs; // 0x08
		public IntPtr parafinMesh; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/DepthOfFieldPass.h")]
	[UsedByNativeCode]
	public struct HGDepthOfFieldParameters // TypeDefIndex: 89225
	{
		// Fields
		public bool enable; // 0x00
		public float focusDistance; // 0x04
		public float aperture; // 0x08
		public float nearFocusStart; // 0x0C
		public float nearFocusEnd; // 0x10
		public float nearRadius; // 0x14
		public float farFocusStart; // 0x18
		public float farFocusEnd; // 0x1C
		public float farRadius; // 0x20
		public float temporalFactor; // 0x24
		public float scale; // 0x28
		public int camera; // 0x2C
		public Vector4 nearStartColor; // 0x30
		public Vector4 nearEndColor; // 0x40
		public Vector4 farStartColor; // 0x50
		public Vector4 farEndColor; // 0x60
		public bool debug; // 0x70
		public bool usePhysicalCamera; // 0x71
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/DistortionPass.h")]
	[UsedByNativeCode]
	public struct VFXScreenMaterialData // TypeDefIndex: 89226
	{
		// Fields
		public bool enableFullScreenVFXData; // 0x00
		public int meshMode; // 0x04
		public ulong gridMask; // 0x08
		public IntPtr vfxFullScreenMaterial; // 0x10
		public IntPtr vfxFullScreenMaterialPropertyBlock; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/FakePlanarReflectionPass.h")]
	[UsedByNativeCode]
	public struct HGFakePlanarReflectionRenderingInput // TypeDefIndex: 89227
	{
		// Fields
		public bool enable; // 0x00
		public bool enableCharacterOutline; // 0x01
		public bool enableScreenSpaceShadowMask; // 0x02
		public bool useRGBAHalf; // 0x03
		public float blurRadius; // 0x04
		public Vector3 normalWS; // 0x08
		public Vector3 pivot; // 0x14
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct HGTerrainGlintData // TypeDefIndex: 89228
	{
		// Fields
		public bool m_enableFakeGlint; // 0x00
		public float m_glintTopBlendSmoothness; // 0x04
		public float m_glintTopBlendThreshold; // 0x08
		public float m_glintStrength; // 0x0C
		public float m_glintScale; // 0x10
		public float m_glintThreshold; // 0x14
		public float m_glintFadeDistance; // 0x18
		public UnityEngine.Color m_glintColor; // 0x1C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct HGTerrainSubsurfaceData // TypeDefIndex: 89229
	{
		// Fields
		public bool m_useSubsurfaceProfile; // 0x00
		public float m_subsurfaceCurvatureScale; // 0x04
		public float m_subsurfaceCurvatureOffset; // 0x08
		public bool m_enableSubsurfaceProfileKeyword; // 0x0C
		public int m_terrainStencil; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct HGTerrainFakeVolumeData // TypeDefIndex: 89230
	{
		// Fields
		public bool m_enableFakeVolume; // 0x00
		public float m_fakeVolumeIoR; // 0x04
		public float m_fakeVolumeFresnelStrength; // 0x08
		public int m_fakeVolumeMode; // 0x0C
		public float m_fakeVolumeOpacityTiling; // 0x10
		public float m_fakeCrackLayerTiling; // 0x14
		public UnityEngine.Color m_fakeCrackTint; // 0x18
		public float m_fakeCrackHeightScale; // 0x28
		public float m_fakeCrackDepth; // 0x2C
		public float m_fakeCrackMarchSteps; // 0x30
		public UnityEngine.Color m_fakeRefractionTint; // 0x34
		public float m_fakeRefractionLayerTiling; // 0x44
		public UnityEngine.Color m_fakeVolumeScatterExtinction; // 0x48
		public UnityEngine.Color m_fakeVolumeScatterAlbedo; // 0x58
		public float m_fakeRefractionHeightScale; // 0x68
		public float m_fakeRefractionDepth; // 0x6C
		public float m_fakeRefractionMarchSteps; // 0x70
		public float m_fakeDustLayerTiling; // 0x74
		public float m_fakeDustDepth; // 0x78
		public Vector4 m_fakeDustFlowSpeed; // 0x7C
		public UnityEngine.Color m_fakeDustTint; // 0x8C
		public IntPtr m_fakeVolumeOpacityMask; // 0xA0
		public IntPtr m_fakeVolumeMask; // 0xA8
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct HGTerrainFakeShadowData // TypeDefIndex: 89231
	{
		// Fields
		public bool m_enableFakeShadow; // 0x00
		public float m_fakeShadowPenumbra; // 0x04
		public float m_fakeShadowStrength; // 0x08
		public float m_fakeShadowMarchSteps; // 0x0C
		public float m_fakeShadowDistanceLerp; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct HGTerrainLayerTypeData // TypeDefIndex: 89232
	{
		// Fields
		public bool m_bHasLayerTypeData; // 0x00
		public Matrix4x4 m_localToWorldMatrix; // 0x04
		public Matrix4x4 m_worldToLocalMatrix; // 0x44
		public IntPtr m_heightmapTexture; // 0x88
		public Vector4 m_heightmapScale; // 0x90
		public HGTerrainGlintData m_glintData; // 0xA0
		public HGTerrainSubsurfaceData m_subsurfaceData; // 0xCC
		public HGTerrainFakeVolumeData m_fakeVolumeData; // 0xE0
		public HGTerrainFakeShadowData m_fakeShadowData; // 0x190
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct HGTerrainFeatures // TypeDefIndex: 89233
	{
		// Fields
		public bool enableDeformBlend; // 0x00
		public bool enableWetRipple; // 0x01
		public bool enablePOM; // 0x02
		public bool isOnePassDeferred; // 0x03
		public unsafe HGTerrainLayerTypeData* layerTypeData; // 0x08
	}

	[UsedByNativeCode]
	public struct HGVolumetricCloudDataCB // TypeDefIndex: 89234
	{
		// Fields
		public int _MarchStepNum; // 0x00
		public float _InvMarchStepNum; // 0x04
		public int _GodRayStepNum; // 0x08
		public float _InvGodRayStepNum; // 0x0C
		public int _PanoramicMarchStepNum; // 0x10
		public int _FarCloudMarchStepNum; // 0x14
		public int _FarCloudReconstructCubicSample; // 0x18
		public int _FarCloudTAACubicSample; // 0x1C
		public int _WindFieldNum; // 0x20
		public float _DynamicStepScale; // 0x24
		public float _OpticalDepthScale; // 0x28
		public float _InvOpticalDepthScale; // 0x2C
		public float _WindOffsetScale; // 0x30
		public float _InvWindOffsetScale; // 0x34
		public float _FlowTime; // 0x38
		public float _FlowSpeedScale; // 0x3C
		public float _GlobalScale; // 0x40
		public float _InvGlobalScale; // 0x44
		public float _InvResolution; // 0x48
		public float _SdfStepScale; // 0x4C
		public float _FarCloudDeltaTimeScale; // 0x50
		public float _FarCloudReprojectLerpRatio; // 0x54
		public float _FarCloudReprojectDeltaTimeScale; // 0x58
		public float _FarCloudReprojectDeltaTimeScale2; // 0x5C
		public float _FarCloudReconstructComposeRatio; // 0x60
		public float _FarCloudTAABlendRatio; // 0x64
		public float _OctahedronHeightScale; // 0x68
		public float _OctahedronUVRescale; // 0x6C
		public float _OctahedronUVInvRescale; // 0x70
		public float _SemicircularZScale; // 0x74
		public uint _FarCloudPixelSubOffset; // 0x78
		public uint _FarCloudFrameCountMod8; // 0x7C
		public uint _FarCloudFrameCountMod16; // 0x80
		public uint _FarCloudFrameCountMod32; // 0x84
		public uint _FarCloudFrameCountMod64; // 0x88
		public uint _FarCloudFrameCountMod128; // 0x8C
		public Vector4 _LocalRayOrigin; // 0x90
		public Vector4 _VoxelSize; // 0xA0
		public Vector4 _InvScale; // 0xB0
		public Vector4 _MarchRangeLocal; // 0xC0
		public Vector4 _DynamicStepRange; // 0xD0
		public Vector4 _MainLightDirection; // 0xE0
		public Vector4 _MainCameraPos; // 0xF0
		public Vector4 _MainCameraPosLocal; // 0x100
		public Vector4 _MainCameraFovTan; // 0x110
		public Vector4 _EmptySkipUVScale; // 0x120
		public Vector4 _EmptySkipRTSize; // 0x130
		public Vector4 _MsFalloffRangeRemap; // 0x140
		public Vector4 _WindLerpDistance; // 0x150
		public Vector4 _WindSpeed; // 0x160
		public Vector4 _WindSpeed2; // 0x170
		public Vector4 _WindSpeed3; // 0x180
		public Vector4 _WindPhase; // 0x190
		public Vector4 _WindPhase2; // 0x1A0
		public Vector4 _WindPhase3; // 0x1B0
		public Vector4 _WindOffset; // 0x1C0
		public Vector4 _WindOffset2; // 0x1D0
		public Vector4 _WindOffset3; // 0x1E0
		public Vector4 _FarCloudMarchRangeLocal; // 0x1F0
		public Vector4 _FarCloudCenter; // 0x200
		public Vector4 _FarCloudCenterLocal; // 0x210
		public Vector4 _FarCloudLastCenter; // 0x220
		public Vector4 _FarCloudSize; // 0x230
		public Vector4 _SemicircularForward; // 0x240
		public Vector4 _SemicircularRight; // 0x250
		public Vector4 _SemicircularUp; // 0x260
		public Vector4 _SemicircularPrevForward; // 0x270
		public Vector4 _SemicircularPrevRight; // 0x280
		public Vector4 _SemicircularPrevUp; // 0x290
		public Vector4 _FarCloudEmptySkipUVScale; // 0x2A0
		public Vector4 _FarCloudEmptySkipRTSize; // 0x2B0
		public Vector4 _FarCloudSlicingUVRescale; // 0x2C0
		public Vector4 _FarCloudSlicingPrevCenter; // 0x2D0
		public Vector4 _FarCloudSlicingPrev2Center; // 0x2E0
		public Vector4 _DensityTex_RemapRangeBase; // 0x2F0
		public Vector4 _DensityTex_RemapRangeScale; // 0x300
		public Vector4 _AdvancedTex_RemapRangeBase; // 0x310
		public Vector4 _AdvancedTex_RemapRangeScale; // 0x320
		public Vector4 _WindFieldTex_RemapRangeBase; // 0x330
		public Vector4 _WindFieldTex_RemapRangeScale; // 0x340
		public Vector4 _SHTex_RemapRangeBase; // 0x350
		public Vector4 _SHTex_RemapRangeScale; // 0x360
		public Matrix4x4 _BoxWorldToLocal; // 0x370
		public Matrix4x4 _BoxLocalToWorld; // 0x3B0
	}

	[UsedByNativeCode]
	public struct HGVolumetricBounds // TypeDefIndex: 89235
	{
		// Fields
		public bool enableBounds; // 0x00
		public Bounds worldBounds; // 0x04
	}

	[UsedByNativeCode]
	public struct HGVolumetricRenderItem // TypeDefIndex: 89236
	{
		// Fields
		public int id; // 0x00
		public IntPtr material; // 0x08
		public int passIndex; // 0x10
		public int passIndex2; // 0x14
		public IntPtr mesh; // 0x18
		public Matrix4x4 localToWorldMatrix; // 0x20
		public IntPtr propertySheet; // 0x60
		public HGVolumetricBounds bounds; // 0x68
		public bool enableFraming; // 0x84
		public bool enableTAA; // 0x85
		public int sortingOrder; // 0x88
		public int renderQueue; // 0x8C
		public float distToCamera; // 0x90
		public int composePriority; // 0x94
		public bool pureBlit; // 0x98
		public bool fullScreen; // 0x99
		public Vector2Int msBakeSize; // 0x9C
		public float opticalDepthScale; // 0xA4
		public bool drawFarCloud; // 0xA8
		public bool volumeFadeIn; // 0xA9
		public IntPtr cloudDataCB; // 0xB0
		public CBHandle cloudCBHandle; // 0xB8
	}

	public enum EFramingQuality // TypeDefIndex: 89237
	{
		Checkerboard = 0,
		Quarter = 1
	}

	public enum EDownResFilter // TypeDefIndex: 89238
	{
		DepthFade = 0,
		Nearest = 1,
		Bilateal = 2,
		Noisy = 3
	}

	[UsedByNativeCode]
	public struct HGDownResQualityPack // TypeDefIndex: 89239
	{
		// Fields
		public bool enableDownRes; // 0x00
		public float downResRatio; // 0x04
		public EDownResFilter downResFilter; // 0x08
	}

	[UsedByNativeCode]
	public struct HGFramingQualityPack // TypeDefIndex: 89240
	{
		// Fields
		public bool enableFraming; // 0x00
		public EFramingQuality framingLevel; // 0x04
		public float framingComposeRatio; // 0x08
		public bool enableFramingCubicSample; // 0x0C
		public bool enableFramingMotionVector; // 0x0D
		public bool enableFramingDepthOpt; // 0x0E
		public bool enableFramingColorAABB; // 0x0F
		public bool enableFramingNeighborAvg; // 0x10
	}

	[UsedByNativeCode]
	public struct HGTAAQualityPack // TypeDefIndex: 89241
	{
		// Fields
		public bool enableTAA; // 0x00
		public bool enableTAACubicSample; // 0x01
		public bool enableTAAMotionVector; // 0x02
		public bool enableTAADepthOpt; // 0x03
		public bool enableTAAColorAABB; // 0x04
		public bool enableTAANeighborAvg; // 0x05
		public float invalidDepthBlendRatio; // 0x08
	}

	public enum EFarCloudFramingQuality // TypeDefIndex: 89242
	{
		None = 0,
		Checkerboard = 1,
		Quarter = 2,
		Framing4x2 = 3,
		Framing4x4 = 4
	}

	[UsedByNativeCode]
	public struct HGCloudQualityPack // TypeDefIndex: 89243
	{
		// Fields
		public float marchStepScale; // 0x00
		public float godRayStepScale; // 0x04
		public float emptySkipSizeScale; // 0x08
		public float dynamicStepRange; // 0x0C
		public float dynamicStepScale; // 0x10
		public bool enableFarCloud; // 0x14
		public int panoramicSizeX; // 0x18
		public int panoramicSizeY; // 0x1C
		public int octahedronSize; // 0x20
		public float octahedronHeightScale; // 0x24
		public bool octahedronEnableSlicing; // 0x28
		public int octahedronSlicingCountX; // 0x2C
		public int octahedronSlicingCountY; // 0x30
		public int semicircularSize; // 0x34
		public float semicircularZScale; // 0x38
		public EFarCloudFramingQuality farCloudFramingLevel; // 0x3C
		public float farCloudFramingComposeRatio; // 0x40
		public bool farCloudFramingCubicSample; // 0x44
		public bool farCloudEnableTAA; // 0x45
		public float farCloudTAABlendRatio; // 0x48
		public bool farCloudTAACubicSample; // 0x4C
		public float farCloudMarchStepScale; // 0x50
		public float farCloudFullUpdateMarchStepScale; // 0x54
		public float farCloudEmptySkipSizeScale; // 0x58
	}

	[UsedByNativeCode]
	public struct HGVolumetricQualitySettings // TypeDefIndex: 89244
	{
		// Fields
		public HGDownResQualityPack downResQualityPack; // 0x00
		public HGFramingQualityPack framingQualityPack; // 0x0C
		public HGTAAQualityPack taaQualityPack; // 0x20
		public HGCloudQualityPack cloudQualityPack; // 0x2C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/RainWetness/RainWetnessPass.h")]
	[UsedByNativeCode]
	public struct HGRainWetnessRendererInputCPP // TypeDefIndex: 89245
	{
		// Fields
		public int enable; // 0x00
		public int enableWetness; // 0x04
		public int enableWetnessAffectSSR; // 0x08
		public float intensity; // 0x0C
		public float speed; // 0x10
		public Vector4 color; // 0x14
		public float streakLength; // 0x24
		public float rainCenterBias; // 0x28
		public Vector3 rainDirection; // 0x2C
		public float middleRainDistance; // 0x38
		public float farRainDistance; // 0x3C
		public float middleRainLayerSpeedDiffMultiplier; // 0x40
		public float farRainLayerSpeedDiffMultiplier; // 0x44
		public float middleRainAlphaMultiplier; // 0x48
		public float farRainAlphaMultiplier; // 0x4C
		public float middleRainLightingPercent; // 0x50
		public Vector3 middleRainDirection; // 0x54
		public Vector3 farRainDirection; // 0x60
		public float rainWaveAlpha; // 0x6C
		public float rainWaveVerticalSpeed; // 0x70
		public float rainWaveHorizontalSpeed; // 0x74
		public float rainWaveBottomFadeFactor; // 0x78
		public float rainWaveDistance; // 0x7C
		public float sceneEffectRainJitterLevel; // 0x80
		public float sceneEffectRainWidthScale; // 0x84
		public float sceneEffectRainLightingPercent; // 0x88
		public float sceneEffectRainRange; // 0x8C
		public Vector4 screenDropColor; // 0x90
		public int screenDropMaxCountLim; // 0xA0
		public float screenDropFlowPercent; // 0xA4
		public float screenDropJitterSpeedScale; // 0xA8
		public Vector2 screenDropMinMaxLifeTime; // 0xAC
		public Vector2 screenDropMinMaxSize; // 0xB4
		public Vector2 screenDropMinMaxSpeed; // 0xBC
		public Vector2 screenDropCentroidFadeParam; // 0xC4
		public Vector2 screenDropScatterParam; // 0xCC
		public float screenDropFXShadingSize; // 0xD4
		public float screenDropNoiseLevel; // 0xD8
		public float screenRainDropEdgeSharpness; // 0xDC
		public int rainSplashCount; // 0xE0
		public float rainSplashSpeed; // 0xE4
		public float rainSplashAlpha; // 0xE8
		public Vector2 rainSplashMinMaxSize; // 0xEC
		public float rainSplashLightingPercent; // 0xF4
		public float rainSplashRange; // 0xF8
		public float rainSplashYBias; // 0xFC
		public float wetness; // 0x100
		public float wetnessBasePorosity; // 0x104
		public float wetnessPorosityFactor; // 0x108
		public float baseWetnessLevel; // 0x10C
		public float verticalWetnessScalar; // 0x110
		public float farSceneWetnessDistanceFactor; // 0x114
		public float farSceneWetnessValue; // 0x118
		public float wetnessProceduralForWater; // 0x11C
		public float verticalFlowSpeed; // 0x120
		public float verticalFlowNormalStrength; // 0x124
		public float verticalFlowSurfaceThreshold; // 0x128
		public float verticalFlowPorosityBias; // 0x12C
		public float rippleFrequency; // 0x130
		public float rippleNormalStrength; // 0x134
		public float rippleWaveSpeed; // 0x138
		public float rippleWaveNormalStrength; // 0x13C
		public float rippleRoughnessMaskThreshold; // 0x140
		public float maxRainHeight; // 0x144
		public float maxMoveDirectionLength; // 0x148
		public float rainTemporalTimeThreshold; // 0x14C
		public float farRainMaxUVFlowSpeed; // 0x150
		public float sceneEffectRainMaxUVFlowSpeed; // 0x154
		public float rainWaveNoiseFlowSpeedMultiplier; // 0x158
		public int rainOcclusionMaskSampleMode; // 0x15C
		public int rainOcclusionMaskSamplePosJitterMode; // 0x160
		public float rainOcclusionMapRange; // 0x164
		public float rainOcclusionMapHeight; // 0x168
		public float rainOcclusionSampleNormalBias; // 0x16C
		public float rainOcclusionSampleDepthBias; // 0x170
		public float rainOcclusionSampleNoiseScale; // 0x174
		public float rainOcclusionSampleHorizontalJitterLevel; // 0x178
		public float rainOcclusionSampleVerticalJitterLevel; // 0x17C
		public float acneFixNormalBiasScale; // 0x180
		public Vector4 farRainTex0_ST; // 0x184
		public Vector4 farRainTex1_ST; // 0x194
		public Vector4 sceneEffectRainTex_ST; // 0x1A4
		public Vector4 rainWaveTex_ST; // 0x1B4
		public Vector4 rainWaveNoise_ST; // 0x1C4
		public Vector4 screenDropFXNoiseTex_ST; // 0x1D4
		public Vector4 verticalFlowTexture_ST; // 0x1E4
		public Vector2 rippleTexture_ST; // 0x1F4
		public int rippleRowColumnCount; // 0x1FC
		public int rainSplashTextureRowColumnCount; // 0x200
	}

	[UsedByNativeCode]
	public struct ScanLineDataPack // TypeDefIndex: 89246
	{
		// Fields
		public Vector4 blackBoxCenterPos; // 0x00
		public UnityEngine.Color blackBoxBackground; // 0x10
		public UnityEngine.Color blackBoxContourColor; // 0x20
		public Vector4 blackBoxParams1; // 0x30
		public Vector4 blackBoxParams2; // 0x40
		public Vector4 blackBoxParams3; // 0x50
		public Vector4 blackBoxParams4; // 0x60
		public Vector4 blackBoxParams5; // 0x70
		public Vector4 scanLineCenterPos; // 0x80
		public Vector4 scanlineParams1; // 0x90
		public Vector4 scanlineParams2; // 0xA0
		public Vector4 scanlineParams3; // 0xB0
		public Vector4 scanlineParams4; // 0xC0
		public Vector4 scanlineParams5; // 0xD0
		public UnityEngine.Color scanlineTint; // 0xE0
		public Vector4 scanlineParams6; // 0xF0
		public Vector4 scanlineParams7; // 0x100
		public Vector4 scanlineParams8; // 0x110
		public Vector4 scanlineParams9; // 0x120
		public Vector4 scanlineParams10; // 0x130
		public UnityEngine.Color scanlineHighlightTint; // 0x140
		public UnityEngine.Color scanlineHighlightBeamTint; // 0x150
		public Vector4 boxPosition1; // 0x160
		public Vector4 boxPosition2; // 0x170
		public Vector4 boxPosition3; // 0x180
	}

	[UsedByNativeCode]
	public struct HighlightDataPack // TypeDefIndex: 89247
	{
		// Fields
		public Vector4 detectDistance; // 0x00
		public Vector3 beamHeight; // 0x10
		public float meshHeight; // 0x1C
	}

	[UsedByNativeCode]
	public struct VFXPPScanLinePassInput // TypeDefIndex: 89248
	{
		// Fields
		public bool useScanLine; // 0x00
		public bool useBlackBox; // 0x01
		public bool scanLineUseMask; // 0x02
		public bool shouldDrawScanLineHighlight; // 0x03
		public IntPtr scanLineDataPack; // 0x08
		public IntPtr scanlineMaskTex; // 0x10
		public IntPtr blackBoxContourTex; // 0x18
		public IntPtr highlightDataPack; // 0x20
		public IntPtr highlightMaterial; // 0x28
		public IntPtr highlightMesh; // 0x30
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/UIImageBlurPass.h")]
	[UsedByNativeCode]
	public struct UIImageBlurPassInputV2 // TypeDefIndex: 89249
	{
		// Fields
		public IntPtr source; // 0x00
		public IntPtr target; // 0x08
		public Vector2Int rectOffset; // 0x10
		public Vector2Int rectSize; // 0x18
		public Vector2Int srcSize; // 0x20
		public float scale; // 0x28
		public int material; // 0x2C
		public GraphicsFormat format; // 0x30
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/VisibilitySHPass.h")]
	[UsedByNativeCode]
	public struct VisibilitySHRPInput // TypeDefIndex: 89250
	{
		// Fields
		public int passIdx; // 0x00
		public int indirectPassIdx; // 0x04
		public uint cullViewHandle; // 0x08
		public bool enabled; // 0x0C
		public float sphereIntervalScale; // 0x10
		public float sphereRangeScale; // 0x14
		public bool enableHalfRez; // 0x18
		public bool useTileRendering; // 0x19
		public uint tileSize; // 0x1C
		public int visibilitySHMaterial; // 0x20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/PostProcess/FrostedGlassPass.h")]
	[UsedByNativeCode]
	public struct FrostedGlassPassRPInput // TypeDefIndex: 89251
	{
		// Fields
		public bool isEnabled; // 0x00
		public bool useCachedTex; // 0x01
		public bool enableUserLut; // 0x02
		public int userLut; // 0x04
		public Vector4 userLogLutSettings; // 0x08
		public Vector4 logLutSettings; // 0x18
		public GraphicsFormat outputFormat; // 0x28
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/PostProcess/FishEyeEffectPass.h")]
	[UsedByNativeCode]
	public struct FishEyeEffectInput // TypeDefIndex: 89252
	{
		// Fields
		public int colorPassIndex; // 0x00
		public int depthPassIndex; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/PostProcess/CutsceneEffectPass.h")]
	[UsedByNativeCode]
	public struct CutsceneEffectPassRPInput // TypeDefIndex: 89253
	{
		// Fields
		public bool isEnabled; // 0x00
		public int cutsceneEffectMeshID; // 0x04
		public int blitMaterialID; // 0x08
		public int cutsceneEffectMaterialNum; // 0x0C
		public unsafe int* cutsceneEffectMaterialIDs; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/VolumetricCloudPass.h")]
	[UsedByNativeCode]
	public struct VolumetricCloudInput // TypeDefIndex: 89254
	{
		// Fields
		public IntPtr defaultVolumetricMat; // 0x00
		public uint renderSizeX; // 0x08
		public uint renderSizeY; // 0x0C
		public Matrix4x4 volumeMatrixVP; // 0x10
		public unsafe HGVolumetricRenderItem* renderItems; // 0x50
		public int renderItemsCount; // 0x58
		public HGVolumetricQualitySettings qualitySetting; // 0x5C
		public int volumetricState; // 0xE4
		public float volumetricFadeRatio; // 0xE8
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Shadow/HGShadowUtils.h")]
	[UsedByNativeCode]
	public struct HGHDPLSCharacterShadowInputs // TypeDefIndex: 89255
	{
		// Fields
		public bool enabled; // 0x00
		public int characterCount; // 0x04
		public int atlasHeight; // 0x08
		public unsafe Bounds* bounds; // 0x10
		public unsafe int* entityCounts; // 0x18
		public IntPtr entityLists; // 0x20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Shadow/HGCharacterShadowmapManager.h")]
	[UsedByNativeCode]
	public struct HGCharacterShadowInputsCPP // TypeDefIndex: 89256
	{
		// Fields
		public int characterCount; // 0x00
		public unsafe Bounds* bounds; // 0x08
		public unsafe uint* shadowLayers; // 0x10
		public bool characterVolumeEnabled; // 0x18
		public bool characterVolume_shadowPassEnabledState; // 0x19
		public int characterVolume_selfShadowMode; // 0x1C
		public int characterVolume_charMainLightMode; // 0x20
		public Vector2 characterVolume_charCameraFollowMainLightBias; // 0x24
		public Vector2 characterVolume_charCustomMainLightDir; // 0x2C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/ParticleLightingPass.h")]
	[UsedByNativeCode]
	public struct ParticleLightingIVInput // TypeDefIndex: 89257
	{
		// Fields
		public Matrix4x4 invViewMatrix; // 0x00
		public Vector4 IVParam0; // 0x40
		public Vector4 IVParam1; // 0x50
		public Vector4 IVParam2; // 0x60
		public Vector4 IVDefaultSHAr; // 0x70
		public Vector4 IVDefaultSHAg; // 0x80
		public Vector4 IVDefaultSHAb; // 0x90
	}

	public class HGRenderGraphCPP // TypeDefIndex: 89258
	{
		// Methods
		[FreeFunction("HGRenderGraph_AllocateTempFromCSharp")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/HGRenderGraph.h")]
		public static IntPtr AllocateTempFromCSharp(long size); // 0x000000018524F1B0-0x000000018524F1F0
		public static unsafe T* AllocateTempFromCSharp<T>()
			where T : struct;
		[FreeFunction("HGRenderPath_Create")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/Utils.h")]
		public static unsafe long HGRenderPath_Create(HGRenderPathInternalCPP renderPath, HGRenderPipelineRuntimeResourcesCPP* defaultResources, HGRenderPipelineDebugResourcesCPP* debugResources); // 0x0000000185FA4C80-0x0000000185FA4CE0
		[FreeFunction("HGRenderPath_BeforeCulling")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static unsafe void HGRenderPath_BeforeCulling(long _ptr, HGRenderPathBeforeCullingParamsCPP* renderPathBeforeCullingParams, IntPtr camera, IntPtr uiCamera, IntPtr occlusionCamera); // 0x000000018611C160-0x000000018611C1D0
		[FreeFunction("HGRenderPath_Render")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static unsafe void HGRenderPath_Render(long _ptr, HGRenderPathParamsCPP* renderPathParams, HGRenderPathBeforeCullingParamsCPP* renderPathBeforeCullingParams, IntPtr camera, IntPtr renderContext, IntPtr _cmd); // 0x00000001860F3D00-0x00000001860F3D70
		[FreeFunction("HGRenderPath_Destroy")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static void HGRenderPath_Destroy(long _ptr); // 0x00000001871EC060-0x00000001871EC0A0
		[FreeFunction("HGRenderPathSimpleUI_Create")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static long HGRenderPathSimpleUI_Create(); // 0x00000001865405C0-0x0000000186540600
		[FreeFunction("HGRenderPathSimpleUI_Render")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static void HGRenderPathSimpleUI_Render(long _ptr, IntPtr camera, IntPtr renderContext, IntPtr _cmd); // 0x0000000186540550-0x00000001865405C0
		[FreeFunction("HGRenderPathSimpleUI_Destroy")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static void HGRenderPathSimpleUI_Destroy(long _ptr); // 0x0000000185B9E0E0-0x0000000185B9E120
		[FreeFunction("CustomDrawRTManager_CreateWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		public static long CustomDrawRTManager_Create(); // 0x0000000185B9ECF0-0x0000000185B9ED30
		[FreeFunction("CustomDrawRTManager_DestroyWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		public static void CustomDrawRTManager_Destroy(long ptr); // 0x0000000185B9E0A0-0x0000000185B9E0E0
		[FreeFunction("CustomDrawRTManager_AllocateRenderTextureWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		private static int CustomDrawRTManager_AllocateRenderTextureImpl(long manager, int width, int height, int depth, int mipCount, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat); // 0x000000018604BC10-0x000000018604BC80
		public static RenderTexture CustomDrawRTManager_AllocateRenderTexture(long manager, int width, int height, int depth, int mipCount, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat); // 0x000000018604BB30-0x000000018604BBD0
		[FreeFunction("CustomDrawRTManager_ReleaseRenderTextureWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		private static void CustomDrawRTManager_ReleaseRenderTextureImpl(long manager, IntPtr rt); // 0x0000000186BD33E0-0x0000000186BD3430
		public static void CustomDrawRTManager_ReleaseRenderTexture(long manager, RenderTexture rt); // 0x0000000186BD33C0-0x0000000186BD33E0
		[FreeFunction("CustomDrawRTManager_DrawTextureWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		private static void CustomDrawRTManager_DrawTextureImpl(long manager, IntPtr rt, [IsReadOnly] in Rect rect, IntPtr texture, IntPtr material, int pass); // 0x000000018647E4B0-0x000000018647E520
		public static void CustomDrawRTManager_DrawTexture(long manager, RenderTexture rt, [IsReadOnly] in Rect rect, Texture texture, Material material, int pass); // 0x000000018647E460-0x000000018647E4B0
		[FreeFunction("CustomDrawRTManager_ClearTextureWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		private static void CustomDrawRTManager_ClearTextureImpl(long manager, IntPtr rt, [IsReadOnly] in UnityEngine.Color color); // 0x000000018698FA20-0x000000018698FA80
		public static void CustomDrawRTManager_ClearTexture(long manager, RenderTexture rt, [IsReadOnly] in UnityEngine.Color color); // 0x000000018698FA00-0x000000018698FA20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Snow/SnowPass.h")]
	[UsedByNativeCode]
	public struct HGSnowRendererInputCPP // TypeDefIndex: 89259
	{
		// Fields
		public int enable; // 0x00
		public float intensity; // 0x04
		public Vector2 speed; // 0x08
		public Vector4 color; // 0x10
		public Vector3 snowDirection; // 0x20
		public float snowJitterLevel; // 0x2C
		public float snowSpeedNoiseLevel; // 0x30
		public float snowSpeedNoiseFreq; // 0x34
		public float snowTrailLength; // 0x38
		public Vector2 snowSizeRange; // 0x3C
		public float snowLightingPercent; // 0x44
		public float snowCollisionFadeTimeScale; // 0x48
		public float maxSnowHeight; // 0x4C
		public float snowMaxUVFlowSpeed; // 0x50
		public float snowRange; // 0x54
		public float maxMoveDirectionLength; // 0x58
		public float snowTemporalTimeThreshold; // 0x5C
		public Vector4 snowflakeTex_ST; // 0x60
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/RayTracing/Reflection/RayTracingReflectionPass.h")]
	[UsedByNativeCode]
	public struct HGRTRDebugData // TypeDefIndex: 89260
	{
		// Fields
		public bool vmrEnabled; // 0x00
		public bool notUseIndirectDispatch; // 0x01
		public bool temporalFilterEnabled; // 0x02
		public bool spatialResolveEnabled; // 0x03
		public bool pcRenderHalfRes; // 0x04
		public bool pcFullResLegacyRays; // 0x05
		public float vmrRoughFullBoundary; // 0x08
		public float vmrRoughHalfBoundary; // 0x0C
		public float vmrRoughQuarterBoundary; // 0x10
		public float vmrMetallicUpgradeThreshold; // 0x14
		public float samplingBias; // 0x18
		public float reflectionFadeRoughnessMin; // 0x1C
		public float reflectionFadeRoughnessMax; // 0x20
		public uint debugView; // 0x24
		public uint forceTileQualityMode; // 0x28
		public Vector4 debugTierColorOneOf16; // 0x2C
		public Vector4 debugTierColorQuarter; // 0x3C
		public Vector4 debugTierColorHalf; // 0x4C
		public Vector4 debugTierColorHalfIso; // 0x5C
		public Vector4 debugTierColorFull; // 0x6C
		public Vector4 debugTierColorSky; // 0x7C
		public float pcDenoiseMaxFrames; // 0x8C
		public float pcDenoiseMaxFramesMirror; // 0x90
		public float pcDenoiseSigmaScaleMirror; // 0x94
		public float pcDenoiseSigmaScaleRough; // 0x98
		public float pcDenoiseDepthThreshold; // 0x9C
		public bool pcDenoiseUseBilateralNeighborhood; // 0xA0
		public bool pcDenoiseUse5x5Neighborhood; // 0xA1
		public float vmrMaxReflectionDistance; // 0xA4
		public float vmrFadenessStartDistance; // 0xA8
		public uint ssSampleCount; // 0xAC
		public bool ssDebugDisableSs; // 0xB0
	}
}
