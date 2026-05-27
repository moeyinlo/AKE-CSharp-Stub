/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 66: UnityEngine.HGGraphicsCPPModule.dll - Assembly: UnityEngine.HGGraphicsCPPModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58279-58440

namespace UnityEngine.HyperGryphEngineCode
{
	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeatureCPP // TypeDefIndex: 58283
	{
		// Fields
		public bool enabled; // 0x00
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeatureCPP_float // TypeDefIndex: 58284
	{
		// Fields
		public bool overriding; // 0x00
		public float value; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeatureCPP_int // TypeDefIndex: 58285
	{
		// Fields
		public bool overriding; // 0x00
		public int value; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeatureCPP_bool // TypeDefIndex: 58286
	{
		// Fields
		public bool overriding; // 0x00
		public bool value; // 0x01
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugFeaturesManagerCPP // TypeDefIndex: 58287
	{
		// Fields
		public HGDebugFeatureCPP cppRenderPath; // 0x00
		public HGDebugFeatureCPP shadows; // 0x01
		public HGDebugFeatureCPP csm; // 0x02
		public HGDebugFeatureCPP asmShadow; // 0x03
		public HGDebugFeatureCPP cloudShadow; // 0x04
		public HGDebugFeatureCPP characterShadow; // 0x05
		public HGDebugFeatureCPP punctualLightShadow; // 0x06
		public HGDebugFeatureCPP contactShadow; // 0x07
		public HGDebugFeatureCPP_float csmFarDistance; // 0x08
		public HGDebugFeatureCPP_int csmCascadeCount; // 0x10
		public HGDebugFeatureCPP_int punctualLightShadowResolution; // 0x18
		public HGDebugFeatureCPP_int directionalShadowResolution; // 0x20
		public HGDebugFeatureCPP_int characterShadowResolution; // 0x28
		public HGDebugFeatureCPP shadowNoAlphaTest; // 0x30
		public HGDebugFeatureCPP shadowProxy; // 0x31
		public HGDebugFeatureCPP visibilitySH; // 0x32
		public HGDebugFeatureCPP mergeShadowCullingView; // 0x33
		public HGDebugFeatureCPP_float cullingViewScreenSizeMin; // 0x34
		public HGDebugFeatureCPP_float shadowViewScreenSizeMin; // 0x3C
		public HGDebugFeatureCPP_float fogCullingFarClipPlane; // 0x44
		public HGDebugFeatureCPP occlusionCulling; // 0x4C
		public HGDebugFeatureCPP_bool occlusionCullingCSM; // 0x4D
		public HGDebugFeatureCPP hizCulling; // 0x4F
		public HGDebugFeatureCPP optimizedChunkCulling; // 0x50
		public HGDebugFeatureCPP_float ocScreenSizeMin; // 0x54
		public HGDebugFeatureCPP_int ocPerformanceRenderMode; // 0x5C
		public HGDebugFeatureCPP lodDither; // 0x64
		public HGDebugFeatureCPP skipAllDrawCommands; // 0x65
		public HGDebugFeatureCPP keepDisabledPassCPUUsages; // 0x66
		public HGDebugFeatureCPP skipRender; // 0x67
		public HGDebugFeatureCPP preZ; // 0x68
		public HGDebugFeatureCPP deferred; // 0x69
		public HGDebugFeatureCPP characterPrePass; // 0x6A
		public HGDebugFeatureCPP customDepthPass; // 0x6B
		public HGDebugFeatureCPP deferredOpaque; // 0x6C
		public HGDebugFeatureCPP deferredOpaquePreZ; // 0x6D
		public HGDebugFeatureCPP deferredOpaqueEqual; // 0x6E
		public HGDebugFeatureCPP gpuDrivenDeferredOpaque; // 0x6F
		public HGDebugFeatureCPP gpuDrivenDeferredOpaquePreZ; // 0x70
		public HGDebugFeatureCPP gpuDrivenDeferredOpaqueEqual; // 0x71
		public HGDebugFeatureCPP deferredGrassPreZ; // 0x72
		public HGDebugFeatureCPP deferredGrass; // 0x73
		public HGDebugFeatureCPP deferredDecal; // 0x74
		public HGDebugFeatureCPP deferredErosion; // 0x75
		public HGDebugFeatureCPP deferredSludge; // 0x76
		public HGDebugFeatureCPP deferredSludgeDecal; // 0x77
		public HGDebugFeatureCPP forward; // 0x78
		public HGDebugFeatureCPP skipForwardTransparent; // 0x79
		public HGDebugFeatureCPP forwardTransparent; // 0x7A
		public HGDebugFeatureCPP forwardOpaque; // 0x7B
		public HGDebugFeatureCPP forwardOpaquePreZ; // 0x7C
		public HGDebugFeatureCPP forwardOpaqueEqual; // 0x7D
		public HGDebugFeatureCPP forwardDecal; // 0x7E
		public HGDebugFeatureCPP forwardCharacter; // 0x7F
		public HGDebugFeatureCPP characterOutlineOpaque; // 0x80
		public HGDebugFeatureCPP characterOutlineOpaquePreZ; // 0x81
		public HGDebugFeatureCPP characterOutlineOpaqueEqual; // 0x82
		public HGDebugFeatureCPP vfxDecal; // 0x83
		public HGDebugFeatureCPP distortion; // 0x84
		public HGDebugFeatureCPP distortionOpaque; // 0x85
		public HGDebugFeatureCPP distortionTransparent; // 0x86
		public HGDebugFeatureCPP UI; // 0x87
		public HGDebugFeatureCPP UISprite; // 0x88
		public HGDebugFeatureCPP UIWorld; // 0x89
		public HGDebugFeatureCPP UIDistorion; // 0x8A
		public HGDebugFeatureCPP UIFrostedGlass; // 0x8B
		public HGDebugFeatureCPP_float chunkLoadRadius; // 0x8C
		public HGDebugFeatureCPP_float defaultLayerLoadRadius; // 0x94
		public HGDebugFeatureCPP_float hlod0LayerLoadRadius; // 0x9C
		public HGDebugFeatureCPP_float hlod1LayerLoadRadius; // 0xA4
		public HGDebugFeatureCPP_float hlod2LayerLoadRadius; // 0xAC
		public HGDebugFeatureCPP_float colliderLayerLoadRadius; // 0xB4
		public HGDebugFeatureCPP_float tinyLayerLoadRadius; // 0xBC
		public HGDebugFeatureCPP deferredShading; // 0xC4
		public HGDebugFeatureCPP deferredShadingDefaultLit; // 0xC5
		public HGDebugFeatureCPP deferredShadingTwoSidedFoliage; // 0xC6
		public HGDebugFeatureCPP deferredShadingSubsurface; // 0xC7
		public HGDebugFeatureCPP splitDeferredShadingStage; // 0xC8
		public HGDebugFeatureCPP usePerLightDynamicLighting; // 0xC9
		public HGDebugFeatureCPP deferredShadingDirectionalLightStage; // 0xCA
		public HGDebugFeatureCPP deferredShadingDynamicLightStage; // 0xCB
		public HGDebugFeatureCPP deferredShadingIndirectStage; // 0xCC
		public HGDebugFeatureCPP deferredShadingForceSplitOnePass; // 0xCD
		public HGDebugFeatureCPP usePerTileDeferredLighting; // 0xCE
		public HGDebugFeatureCPP directionalLight; // 0xCF
		public HGDebugFeatureCPP punctualLights; // 0xD0
		public HGDebugFeatureCPP_int punctualLightsMaxCount; // 0xD4
		public HGDebugFeatureCPP irradianceVolume; // 0xDC
		public HGDebugFeatureCPP irradianceVolumeSample; // 0xDD
		public HGDebugFeatureCPP gtao; // 0xDE
		public HGDebugFeatureCPP irradianceVolumeV2; // 0xDF
		public HGDebugFeatureCPP irradianceVolumeV3; // 0xE0
		public HGDebugFeatureCPP postProcess; // 0xE1
		public HGDebugFeatureCPP lightShaft; // 0xE2
		public HGDebugFeatureCPP bloom; // 0xE3
		public HGDebugFeatureCPP vignette; // 0xE4
		public HGDebugFeatureCPP radialBlur; // 0xE5
		public HGDebugFeatureCPP chromaticAbberation; // 0xE6
		public HGDebugFeatureCPP dirtyLens; // 0xE7
		public HGDebugFeatureCPP toneMapping; // 0xE8
		public HGDebugFeatureCPP sharpen; // 0xE9
		public HGDebugFeatureCPP autoExposure; // 0xEA
		public HGDebugFeatureCPP motionBlur; // 0xEB
		public HGDebugFeatureCPP frostedGlass; // 0xEC
		public HGDebugFeatureCPP lensFlare; // 0xED
		public HGDebugFeatureCPP anamorphicStreaks; // 0xEE
		public HGDebugFeatureCPP depthOfField; // 0xEF
		public HGDebugFeatureCPP_int depthOfFieldQuality; // 0xF0
		public HGDebugFeatureCPP_float depthOfFieldScale; // 0xF8
		public HGDebugFeatureCPP_float depthOfFieldMaxRadius; // 0x100
		public HGDebugFeatureCPP fog; // 0x108
		public HGDebugFeatureCPP atmosphereFog; // 0x109
		public HGDebugFeatureCPP heightFog; // 0x10A
		public HGDebugFeatureCPP volumetricFog; // 0x10B
		public HGDebugFeatureCPP volumetricCloud; // 0x10C
		public HGDebugFeatureCPP ssr; // 0x10D
		public HGDebugFeatureCPP_int ssrRayMarchingSampleCount; // 0x110
		public HGDebugFeatureCPP_bool ssrImportanceSample; // 0x118
		public HGDebugFeatureCPP_bool ssrV2; // 0x11A
		public HGDebugFeatureCPP_bool ssrV2Upsample; // 0x11C
		public HGDebugFeatureCPP reflectionProbe; // 0x11E
		public HGDebugFeatureCPP reflectionProbeNormalization; // 0x11F
		public HGDebugFeatureCPP reflectionProbeTextureDebugInfo; // 0x120
		public HGDebugFeatureCPP reflectionProbeSlotDebugInfo; // 0x121
		public HGDebugFeatureCPP reflectionProbeTextureArrayReset; // 0x122
		public HGDebugFeatureCPP_bool reflectionProbeTextureArrayDebugLog; // 0x123
		public HGDebugFeatureCPP waterRendering; // 0x125
		public HGDebugFeatureCPP waterSSROnMobile; // 0x126
		public HGDebugFeatureCPP waterSector; // 0x127
		public HGDebugFeatureCPP waterInteraction; // 0x128
		public HGDebugFeatureCPP underWaterWetness; // 0x129
		public HGDebugFeatureCPP waterSectorDebug; // 0x12A
		public HGDebugFeatureCPP_bool waterIndirect; // 0x12B
		public HGDebugFeatureCPP_float waterCameraFoVInc; // 0x130
		public HGDebugFeatureCPP_float waterCameraPosOffset; // 0x138
		public HGDebugFeatureCPP_float waterDisplacementWeight; // 0x140
		public HGDebugFeatureCPP_float waterDisplacementDistance; // 0x148
		public HGDebugFeatureCPP rain; // 0x150
		public HGDebugFeatureCPP wetness; // 0x151
		public HGDebugFeatureCPP rainWetnessHighQuality; // 0x152
		public HGDebugFeatureCPP rainOcclusion; // 0x153
		public HGDebugFeatureCPP rainOcclusionSamplePosJitter; // 0x154
		public HGDebugFeatureCPP rainSplash; // 0x155
		public HGDebugFeatureCPP terrainDeform; // 0x156
		public HGDebugFeatureCPP terrainDeformCCD; // 0x157
		public HGDebugFeatureCPP terrain; // 0x158
		public HGDebugFeatureCPP terrainPreDepth; // 0x159
		public HGDebugFeatureCPP terrainScreenSpace; // 0x15A
		public HGDebugFeatureCPP terrainPostGBuffer; // 0x15B
		public HGDebugFeatureCPP terrainVTBake; // 0x15C
		public HGDebugFeatureCPP terrainIndirectionUpdate; // 0x15D
		public HGDebugFeatureCPP terrainDepthPrepass; // 0x15E
		public HGDebugFeatureCPP terrainSimpleSubsurface; // 0x15F
		public HGDebugFeatureCPP terrainSubdivision; // 0x160
		public HGDebugFeatureCPP terrainSubdivisionV2; // 0x161
		public HGDebugFeatureCPP terrainSubdivisionHZBCulling; // 0x162
		public HGDebugFeatureCPP terrainNewEditorRendering; // 0x163
		public HGDebugFeatureCPP terrainDecalInteraction; // 0x164
		public HGDebugFeatureCPP entity; // 0x165
		public HGDebugFeatureCPP character; // 0x166
		public HGDebugFeatureCPP enemy; // 0x167
		public HGDebugFeatureCPP npc; // 0x168
		public HGDebugFeatureCPP sky; // 0x169
		public HGDebugFeatureCPP skyBox; // 0x16A
		public HGDebugFeatureCPP skyCloud; // 0x16B
		public HGDebugFeatureCPP skyCelestial; // 0x16C
		public HGDebugFeatureCPP skyOctahedron; // 0x16D
		public HGDebugFeatureCPP_float grassGlobalSparsity; // 0x170
		public HGDebugFeatureCPP foliageInteractive; // 0x178
		public HGDebugFeatureCPP foliageOccluder; // 0x179
		public HGDebugFeatureCPP gpuCloth; // 0x17A
		public HGDebugFeatureCPP particleLighting; // 0x17B
		public HGDebugFeatureCPP_bool shaderLOD; // 0x17C
		public HGDebugFeatureCPP_bool shaderLODWhiteKeyword; // 0x17E
		public HGDebugFeatureCPP_bool rayTracingReflectionEnable; // 0x180
		public HGDebugFeatureCPP_int rayTracingReflectionMode; // 0x184
		public HGDebugFeatureCPP rayTracingReflectionGlossy; // 0x18C
		public HGDebugFeatureCPP rayTracingReflectionRTOnly; // 0x18D
		public HGDebugFeatureCPP rayTracingReflectionDebugVariable; // 0x18E
		public HGDebugFeatureCPP_float rayTracingReflectionSSQuality0; // 0x190
		public HGDebugFeatureCPP_float rayTracingReflectionSSQuality1; // 0x198
		public HGDebugFeatureCPP_float rayTracingReflectionSSQuality2; // 0x1A0
		public HGDebugFeatureCPP_float rayTracingReflectionSSQuality3; // 0x1A8
		public HGDebugFeatureCPP_float rayTracingReflectionRTQuality0; // 0x1B0
		public HGDebugFeatureCPP_float rayTracingReflectionRTQuality1; // 0x1B8
		public HGDebugFeatureCPP_float rayTracingReflectionRTQuality2; // 0x1C0
		public HGDebugFeatureCPP_float rayTracingReflectionRTQuality3; // 0x1C8
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/DebugFeatures/HGDebugFeaturesManager.h")]
	[UsedByNativeCode]
	public struct HGDebugRenderManagerCPP // TypeDefIndex: 58290
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
		public bool displayIVVoxelSize; // 0x64
		public bool debugSkyAO; // 0x65
		public float fetchedAverageQuadOverdraw; // 0x68
		public bool ignoreZeroValuePixels; // 0x6C
		public int quadOverdrawDetectionMode; // 0x70
		public bool isQuadOverdrawPreDepthMode; // 0x74
		public float fetchedAverageLightDensity; // 0x78
		public bool enableLightDebugger; // 0x7C
		public int visibleLightCount; // 0x80
		public int visiblePunctualLightCount; // 0x84
		public int lightsForDebugCount; // 0x88
		public int lightsRenderingShadowsCount; // 0x8C
		public int lightsBakedCount; // 0x90
		public IntPtr visibleLights; // 0x98
		public IntPtr punctualLightIndices; // 0xA0
		public IntPtr lightsForDebug; // 0xA8
		public IntPtr lightsRenderingShadows; // 0xB0
		public IntPtr lightsBaked; // 0xB8
		public bool reflectionProbeDebugIncludeWater; // 0xC0
		public int reflectionProbeShowTextureIndex; // 0xC4
		public float reflectionProbeShowTextureMip; // 0xC8
		public unsafe fixed /* 0x00000000-0x00000000 */ float reflectionProbeFetchedData[0]; // 0xCC
		public bool enableShadowDebugger; // 0xDC
		public int shadowDebugDataCount; // 0xE0
		public IntPtr shadowDebugDataArray; // 0xE8
		public Vector2 m_sceneViewSelectionPos; // 0xF0
		public unsafe fixed /* 0x00000000-0x00000000 */ float m_fetchedData[0]; // 0xF8
	}

	[UsedByNativeCode]
	public enum FSR3Quality // TypeDefIndex: 58291
	{
		UltraPerformance = 0,
		Performance = 1,
		Balanced = 2,
		Quality = 3,
		NativeAA = 4
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/FSR3/FSR3UpscaleCommon.h")]
	[UsedByNativeCode]
	public struct HGFSR3Util // TypeDefIndex: 58292
	{
		// Methods
		[FreeFunction("IsFSR3Supported")]
		[UsedByNativeCode]
		public static bool IsFSR3Supported() => default; // 0x0000000189DF4910-0x0000000189DF493C
		[FreeFunction("GetFSR3RenderScale")]
		[UsedByNativeCode]
		public static float GetFSR3RenderScale(FSR3Quality quality) => default; // 0x0000000189DF48DC-0x0000000189DF4910
	}

	[UsedByNativeCode]
	public struct HGVolumetricFogSettingParametersV2 // TypeDefIndex: 58293
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
	public struct HGAtmosphereSettingParameters // TypeDefIndex: 58294
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
	public struct HGSettingParametersCpp // TypeDefIndex: 58296
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
		public bool pssrPassThrough; // 0x41
		public bool dlssEnable; // 0x42
		public DLSSQuality dlssQuality; // 0x44
		public bool dlssUseAutoExposure; // 0x48
		public StreamlineDLSSFGMode dlssFGMode; // 0x4C
		public uint dlssFGGenFrames; // 0x50
		public StreamlineReflexMode dlssReflexMode; // 0x54
		public bool dlssPCLEnable; // 0x58
		public float dlssSharpenStrength; // 0x5C
		public bool dlssUseUIHint; // 0x60
		public float dlssUIHintAlphaThreshold; // 0x64
		public bool fsr3Enable; // 0x68
		public bool fsr3UseReaciveAndTCMask; // 0x69
		public FSR3Quality fsr3Quality; // 0x6C
		public float fsr3SharpenStrength; // 0x70
		public bool fsr3UseFP16; // 0x74
		public bool fsr3UseWave; // 0x75
		public bool fsr3UseWave64; // 0x76
		public bool fsr3UseLanczosLut; // 0x77
		public BloomQuality bloomQuality; // 0x78
		public bool bloomUseComputeShader; // 0x7C
		public int lutSize; // 0x80
		public GraphicsFormat lutFormat; // 0x84
		public GraphicsFormat ppBufferFormat; // 0x88
		public GraphicsFormat uiPPBufferFormat; // 0x8C
		public bool frostedGlassUseComputeShader; // 0x90
		public int depthOfFieldQuality; // 0x94
		public float depthOfFieldMaxRadius; // 0x98
		public bool depthOfFieldScaleAdjust; // 0x9C
		public float depthOfFieldScaleAdjustThreshold; // 0xA0
		public bool motionBlurEnable; // 0xA4
		public bool bloomEnabled; // 0xA5
		public bool vignetteEnabled; // 0xA6
		public bool radialBlurEnabled; // 0xA7
		public bool chromaticAberrationEnabled; // 0xA8
		public bool dirtyLensEnabled; // 0xA9
		public bool sharpenEnabled; // 0xAA
		public bool frostedGlassEnabled; // 0xAB
		public bool cutsceneEffectEnabled; // 0xAC
		public bool fisheyeEffectEnabled; // 0xAD
		public bool lensFlareEnabled; // 0xAE
		public int punctualLightMaxCount; // 0xB0
		public bool enableShadowProxy; // 0xB4
		public int shadowDepthBits; // 0xB8
		public bool enableScreenSpaceShadowMask; // 0xBC
		public bool csmEnabled; // 0xBD
		public int csmShadowMapTileResolution; // 0xC0
		public float csmMaxDistance; // 0xC4
		public float csmFadeInnerDistance; // 0xC8
		public int csmSplitCount; // 0xCC
		public float csmSplit0; // 0xD0
		public float csmSplit1; // 0xD4
		public float csmSplit2; // 0xD8
		public float csmSplit3; // 0xDC
		public bool csmUseShadowmapCache; // 0xE0
		public int csmCachedFrame0; // 0xE4
		public int csmCachedFrame1; // 0xE8
		public int csmCachedFrame2; // 0xEC
		public int csmCachedFrame3; // 0xF0
		public float csmScreenSizeMin0; // 0xF4
		public float csmScreenSizeMin1; // 0xF8
		public float csmScreenSizeMin2; // 0xFC
		public float csmScreenSizeMin3; // 0x100
		public bool csmEnableOcclusionCulling0; // 0x104
		public bool csmEnableOcclusionCulling1; // 0x105
		public bool csmEnableOcclusionCulling2; // 0x106
		public bool csmEnableOcclusionCulling3; // 0x107
		public int csmOcclusionDepthSize; // 0x108
		public int csmStopRenderCharacterCascade; // 0x10C
		public float csmNearPlaneOffset; // 0x110
		public float csmHardwareBias; // 0x114
		public float csmHardwareNormalBias; // 0x118
		public bool characterShadowEnabled; // 0x11C
		public int characterShadowMapResolution; // 0x120
		public float characterShadowHardwareBias; // 0x124
		public float characterShadowHardwareNormalBias; // 0x128
		public float characterShadowShaderBias; // 0x12C
		public float characterShadowShaderNormalBias; // 0x130
		public bool punctualLightShadowEnabled; // 0x134
		public int punctualLightTileMaxSize; // 0x138
		public float punctualLightForceCullDistance; // 0x13C
		public int punctualLightEnvDynamicCasterCount; // 0x140
		public int punctualLightMovableDynamicCasterCount; // 0x144
		public float punctualLightShadowScreenSizeMin; // 0x148
		public bool asmEnabled; // 0x14C
		public int asmShadowMapTileResolution; // 0x150
		public float asmMaxDistance; // 0x154
		public int asmMaxTileRenderCountPerFrame; // 0x158
		public float asmDepthBias; // 0x15C
		public float asmNormalBias; // 0x160
		public float asmScreenSizeMin; // 0x164
		public bool transientGBuffer; // 0x168
		public int depthBitsGBuffer; // 0x16C
		public bool depthCombinedWithStencil; // 0x170
		public float copySceneRTScale; // 0x174
		public int taauResolveResolutionHeight; // 0x178
		public float renderingScale; // 0x17C
		public int backBufferResolutionHeight; // 0x180
		public bool textureStreamingEnable; // 0x184
		public int textureStreamingBudget; // 0x188
		public int textureStreamingMaxBudget; // 0x18C
		public int reservedMemoryForNonTextureStreaming; // 0x190
		public float textureStreamingMobileBudgetPercent; // 0x194
		public int textureStreamingRendererPerFrame; // 0x198
		public int textureStreamingMaxFileIORequests; // 0x19C
		public bool contactShadowEnableParam; // 0x1A0
		public bool gtaoEnable; // 0x1A1
		public int gtaoQualityLevel; // 0x1A4
		public bool ssrEnable; // 0x1A8
		public int ssrRayMarchingSampleCount; // 0x1AC
		public bool ssrImportanceSample; // 0x1B0
		public bool ssrV2; // 0x1B1
		public bool ssrV2Upsample; // 0x1B2
		public bool terrainFallbackGBuffer; // 0x1B3
		public int terrainLODFactor; // 0x1B4
		public bool terrainDeformEnable; // 0x1B8
		public int terrainDeformSubdMode; // 0x1BC
		public int terrainDeformSubdModeV2; // 0x1C0
		public int terrainDeformGpuSubd; // 0x1C4
		public int terrainDeformPrimitivePixelLengthTargetLog2; // 0x1C8
		public bool erosionEnable; // 0x1CC
		public bool enableLightShaft; // 0x1CD
		public int lightShaftSampleNum; // 0x1D0
		public float lightShaftDownSampleFactor; // 0x1D4
		public int lightShaftBlurPassCount; // 0x1D8
		public bool enableAnamorphicStreaks; // 0x1DC
		public float anamorphicStreaksDownSampleFactor; // 0x1E0
		public bool lightWeightUICamera; // 0x1E4
		public bool enableRainWetnessHighQuality; // 0x1E5
		public int rainOcclusionMapSize; // 0x1E8
		public int rainOcclusionMapOverrideRange; // 0x1EC
		public bool rainSplashEnabled; // 0x1F0
		public int rainSplashMaxCount; // 0x1F4
		public float screenRainDropPercent; // 0x1F8
		public bool enableMiddleDistRain; // 0x1FC
		public bool enableRainWave; // 0x1FD
		public int depthOcclusionMapSize; // 0x200
		public int depthOcclusionMapRange; // 0x204
		public HGAtmosphereSettingParameters atmosphereParams; // 0x208
		public float waterPrepassTextureSize; // 0x23C
		public bool waterInteractiveEnable; // 0x240
		public bool waterIndirectEnable; // 0x241
		public int waterVRRx; // 0x244
		public int waterVRRy; // 0x248
		public float waterDisplacementWeight; // 0x24C
		public float waterDisplacementDistance; // 0x250
		public int waterHeightTextureSize; // 0x254
		public float artTagLODBiasAll; // 0x258
		public unsafe fixed /* 0x00000000-0x00000000 */ float artTagLODBias[0]; // 0x25C
		public bool shouldSplitOnePass; // 0x35C
		public HGVolumetricFogSettingParametersV2 volumetricFogParams; // 0x360
		public bool reflectionProbeUseRGBAHalf; // 0x38C
		public int reflectionProbeOctTextureSize; // 0x390
		public int reflectionProbeMaxSampleMip; // 0x394
		public int reflectionProbeMaxBlitCountPerFrame; // 0x398
		public bool transparentLowResOffscreenEnable; // 0x39C
		public bool transparentLowResVRSEnable; // 0x39D
		public int transparentVRRx; // 0x3A0
		public int transparentVRRy; // 0x3A4
		public bool rayTracingReflectionEnable; // 0x3A8
		public int rayTracingReflectionMode; // 0x3AC
		public float rayTracingReflectionSSQuality0; // 0x3B0
		public float rayTracingReflectionSSQuality1; // 0x3B4
		public float rayTracingReflectionSSQuality2; // 0x3B8
		public float rayTracingReflectionSSQuality3; // 0x3BC
		public float rayTracingReflectionRTQuality0; // 0x3C0
		public float rayTracingReflectionRTQuality1; // 0x3C4
		public float rayTracingReflectionRTQuality2; // 0x3C8
		public float rayTracingReflectionRTQuality3; // 0x3CC
		public bool frameInterpolationEnable; // 0x3D0
		public bool frameInterpolationPause; // 0x3D1
		public FrameInterpolationAlgo frameInterpolationAlgo; // 0x3D4
		public bool hasWorldUIAfterFrameInterpolation; // 0x3D8
		public float afmeCameraRotationCosFallbackThreshold; // 0x3DC
		public float afmeCameraMoveDistanceSqrFallbackThreshold; // 0x3E0
		public float mfrcCameraRotationCosFallbackThreshold; // 0x3E4
		public float mfrcCameraMoveDistanceSqrFallbackThreshold; // 0x3E8
		public float mfrcGeneralFallbackThreshold; // 0x3EC
		public float mfrcBrightnessDiffFallbackThreshold; // 0x3F0
		public float mfrcRepeatedPatternFallbackThreshold; // 0x3F4
		public int inkSimulationResolution; // 0x3F8
		public int inkDensityResolution; // 0x3FC
		public bool inkSimulationEnable; // 0x400
	}

	public struct HGRenderPathConstants // TypeDefIndex: 58297
	{
		// Fields
		public float _RenderPathInjected; // 0x00
		public float _HGFlipX; // 0x04
		public float _HGFlipY; // 0x08
		public float _HGOrientationType; // 0x0C
	}

	public struct BasicTransformConstants // TypeDefIndex: 58298
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

	public struct ShaderVariablesGlobal // TypeDefIndex: 58311
	{
		// Fields
		public Matrix4x4 _PrevViewProjMatrix; // 0x00
		public Matrix4x4 _PrevViewNoTransProjMatrix; // 0x40
		public Matrix4x4 _PrevNonJitteredViewProjMatrix; // 0x80
		public Matrix4x4 _PrevNonJitteredViewNoTransProjMatrix; // 0xC0
		public Matrix4x4 _PrevInvViewProjMatrix; // 0x100
		public Matrix4x4 _PrevNonJitteredInvViewProjMatrix; // 0x140
		public Matrix4x4 _ReprojectionMatrix; // 0x180
		public Matrix4x4 _WiderFoVViewProjMatrix; // 0x1C0
		public Matrix4x4 _WiderFoVInvViewProjMatrix; // 0x200
		public Vector4 _PrevCamPosRWS_Internal; // 0x240
		public Vector4 _ScreenSize; // 0x250
		public Vector4 _BackBufferSize; // 0x260
		public Vector4 _ZBufferParams; // 0x270
		public Vector4 _ProjectionParams; // 0x280
		public Vector4 unity_OrthoParams; // 0x290
		public Vector4 _ScreenParams; // 0x2A0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _FrustumPlanes[0]; // 0x2B0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _ShadowFrustumPlanes[0]; // 0x310
		public Vector4 _TaaFrameInfo; // 0x370
		public Vector4 _TaaJitterStrength; // 0x380
		public Vector4 _Time; // 0x390
		public Vector4 _SinTime; // 0x3A0
		public Vector4 _CosTime; // 0x3B0
		public Vector4 unity_DeltaTime; // 0x3C0
		public Vector4 _TimeParameters; // 0x3D0
		public Vector4 _LastTimeParameters; // 0x3E0
		public float _GlobalMipBias; // 0x3F0
		public float _GlobalMipBiasPow2; // 0x3F4
		public float _ProbeExposureScale; // 0x3F8
		public uint _FrameCount; // 0x3FC
		public Vector4 _ExposureParams; // 0x400
		public Vector4Int _BinningBufferOffsets; // 0x410
		public Vector4 _EnvironmentGlobalParams0; // 0x420
		public Vector4 _GraphicsFeaturesGlobalParam0; // 0x430
		public Vector4 _GraphicsFeaturesGlobalParam1; // 0x440
		public Vector4 _WindGlobalParams0; // 0x450
		public Vector4 _WindGlobalParams2; // 0x460
		public Vector4 _CharacterPositionParams0; // 0x470
		public Vector4 _CharacterPositionParams1; // 0x480
		public Vector4 _CharacterPositionParams2; // 0x490
		public Vector4 _CharacterPositionParams3; // 0x4A0
		public Vector4 _CharacterHeightParams; // 0x4B0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams0[0]; // 0x4C0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams1[0]; // 0x500
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams2[0]; // 0x540
		public unsafe fixed /* 0x00000000-0x00000000 */ float _WindMotorParams3[0]; // 0x580
		public Vector4 _WindMotorCount; // 0x5C0
		public Vector4 _LastWindGlobalParams0; // 0x5D0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams0[0]; // 0x5E0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams1[0]; // 0x620
		public unsafe fixed /* 0x00000000-0x00000000 */ float _LastWindMotorParams3[0]; // 0x660
		public Vector4 _FoliageInteractiveParams0; // 0x6A0
		public Vector4 _PrevFoliageInteractiveParams0; // 0x6B0
		public Vector4 _AtmosphereFogParams0; // 0x6C0
		public Vector4 _AtmosphereFogParams1; // 0x6D0
		public Vector4 _AtmosphereFogParams2; // 0x6E0
		public Vector4 _AtmosphereFogParams3; // 0x6F0
		public Vector4 _AtmosphereFogParams4; // 0x700
		public Vector4 _AtmosphereFogParams5; // 0x710
		public Vector4 _ExponentialFogParams0; // 0x720
		public Vector4 _ExponentialFogParams1; // 0x730
		public Vector4 _ExponentialFogParams2; // 0x740
		public Vector4 _ExponentialFogParams3; // 0x750
		public Vector4 _ExponentialFogParams4; // 0x760
		public Vector4 _ExponentialFogParams5; // 0x770
		public Vector4 _VolumetricFogParams0; // 0x780
		public Vector4 _VolumetricFogParams1; // 0x790
		public Vector4 _VolumetricFogParams2; // 0x7A0
		public Vector4 _VolumetricFogParams3; // 0x7B0
		public Vector4 _VolumetricFogParams4; // 0x7C0
		public Vector4 _HeightFogFlowNoiseParams0; // 0x7D0
		public Vector4 _HeightFogFlowNoiseParams1; // 0x7E0
		public Vector4 _FogBakeLutRescaleParams; // 0x7F0
		public Vector4 _FogBakeLutEncodeParams; // 0x800
		public Vector4 _FogBakeLutYawParams; // 0x810
		public Vector4 _CloudShadowParams0; // 0x820
		public Vector4 _CloudShadowParams1; // 0x830
		public Vector4 _CloudShadowParams2; // 0x840
		public Vector4 _CloudShadowParams3; // 0x850
		public Vector4 _Style_MatDistCoef; // 0x860
		public Vector4 _Style_MatFarAlb0; // 0x870
		public Vector4 _Style_MatFarAlb1; // 0x880
		public Vector4 _Style_GbFarEms; // 0x890
		public Vector4 _Style_GbFarDir; // 0x8A0
		public Vector4 _Style_GbCoef; // 0x8B0
		public Vector4 _VFXParams0; // 0x8C0
		public Vector4 _VFXParams1; // 0x8D0
		public Vector4 _VFXParams2; // 0x8E0
		public Vector4 _VFXParams3; // 0x8F0
		public Vector4 _CharacterParams0; // 0x900
		public Vector4 _CharacterParams1; // 0x910
		public Vector4 _CharacterParams2; // 0x920
		public Vector4 _CharacterParams3; // 0x930
		public Vector4 _CharacterParams4; // 0x940
		public Vector4 _CharacterParams5; // 0x950
		public Vector4 _CharacterParams6; // 0x960
		public Vector4 _CharacterParams7; // 0x970
		public Vector4 _CharacterParams8; // 0x980
		public Vector4 _CharacterParams9; // 0x990
		public Vector4 _CharacterParams10; // 0x9A0
		public Vector4 _CharacterParams11; // 0x9B0
		public Vector4 _CharacterParams12; // 0x9C0
		public Vector4 _CharacterParams13; // 0x9D0
		public Vector4 _CharacterParams14; // 0x9E0
		public Vector4 _CharacterParams15; // 0x9F0
		public Vector4 _CharacterParams16; // 0xA00
		public Vector4 _InkSimulationWorldToUV; // 0xA10
		public Vector4 _TerrainDeformParams0; // 0xA20
		public Vector4 _TerrainDeformParams1; // 0xA30
		public unsafe fixed /* 0x00000000-0x00000000 */ float _TerrainClipmapParams0[0]; // 0xA40
		public unsafe fixed /* 0x00000000-0x00000000 */ float _TerrainClipmapParams1[0]; // 0xA60
		public float _G_EnableFeatureErosionBlend; // 0xA80
		public float _G_EnableFeatureB; // 0xA84
		public float _G_EnableFeatureC; // 0xA88
		public float _G_EnableFeatureD; // 0xA8C
		public Vector4 _IVParam0; // 0xA90
		public Vector4 _IVParam1; // 0xAA0
		public Vector4 _IVParam2; // 0xAB0
		public Vector4 _IVDefaultSHAr; // 0xAC0
		public Vector4 _IVDefaultshAg; // 0xAD0
		public Vector4 _IVDefaultshAb; // 0xAE0
		public Vector4 _IVV2Param0; // 0xAF0
		public Vector4 _IVV2Param1; // 0xB00
		public Vector4 _IVV2Param2; // 0xB10
		public Vector4 _IVV2Param3; // 0xB20
		public Vector4 _WaterInteractionParams0; // 0xB30
		public Vector4 _WaterInteractionParams1; // 0xB40
		public Vector4 _RainWetnessGlobalParam0; // 0xB50
		public Vector4 _RainWetnessGlobalParam1; // 0xB60
		public Vector4 _RainWetnessGlobalParam2; // 0xB70
		public Vector4 _RainWetnessGlobalParam3; // 0xB80
		public Vector4 _RainWetnessGlobalParam4; // 0xB90
		public Vector4 _RainWetnessGlobalParam5; // 0xBA0
		public Vector4 _RainWetnessGlobalParam6; // 0xBB0
		public Vector4 _RainWetnessGlobalParam7; // 0xBC0
		public Vector4 _RainWetnessGlobalParam8; // 0xBD0
		public Vector4 _RainWetnessGlobalParam9; // 0xBE0
		public Vector4 _RainWetnessGlobalParam10; // 0xBF0
		public Vector4 _VerticalOcclusionMapParam0; // 0xC00
		public Vector4 _WaterWetnessMaskParam0; // 0xC10
		public Vector4 _GpuClothParams; // 0xC20
		public Vector4 _FoliageOccluderParams0; // 0xC30
		public Vector4 _FoliageOccluderCameraPosParam; // 0xC40
		public Vector4 _InteractRaftParams0; // 0xC50
		public Vector4 _InteractRaftParams1; // 0xC60
		public Matrix4x4 _FakePlanarReflectionViewProjMatrix; // 0xC70
		public Vector4 _FakeSphericalLightSource; // 0xCB0
		public Vector4 _VolumetricComposeParams; // 0xCC0
		public unsafe fixed /* 0x00000000-0x00000000 */ float _HackTempDataBeforeCPPPlugin[0]; // 0xCD0
	}

	[UsedByNativeCode]
	public enum DLSSQuality // TypeDefIndex: 58312
	{
		UltraPerformance = 0,
		Performance = 1,
		Balanced = 2,
		Quality = 3,
		DLAA = 4
	}

	[UsedByNativeCode]
	public enum StreamlineReflexMode // TypeDefIndex: 58313
	{
		Off = 0,
		LowLatency = 1,
		LowLatencyWithBoost = 2
	}

	[UsedByNativeCode]
	public enum StreamlineDLSSFGMode // TypeDefIndex: 58314
	{
		Off = 0,
		On = 1,
		Auto = 2
	}

	[NativeHeader("Modules/HGGraphics/Public/DLSS/HGDLSSCommon.h")]
	[NativeHeader("Modules/HGGraphics/Public/DLSS/HGDLSSUtil.h")]
	[UsedByNativeCode]
	public struct DLSSOptimalSettings // TypeDefIndex: 58315
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
		public static DLSSOptimalSettings GetDLSSOptimalSetting(DLSSQuality quality, Vector2Int nonScaledViewport) => default; // 0x0000000189DF46DC-0x0000000189DF4718
		private static void GetDLSSOptimalSetting_Injected(DLSSQuality quality, ref Vector2Int nonScaledViewport, out DLSSOptimalSettings ret) {
			ret = default;
		} // 0x0000000189DF468C-0x0000000189DF46DC
	}

	[NativeHeader("Modules/StreamLine/StreamlineDLSSG.h")]
	[UsedByNativeCode]
	public struct HGCPPDLSSUtil // TypeDefIndex: 58316
	{
		// Methods
		[FreeFunction("SetStreamlineDLSSGMode")]
		[UsedByNativeCode]
		public static void SetStreamlineDLSSGMode(StreamlineDLSSFGMode frameGenMode) {} // 0x0000000182ACE470-0x0000000182ACE4B0
		[FreeFunction("GetStreamlineDLSSGMinMaxFrameGen")]
		[UsedByNativeCode]
		public static Vector2Int GetStreamlineDLSSGMinMaxFrameGen() => default; // 0x0000000189DF47B8-0x0000000189DF47DC
		[FreeFunction("CalcStreamlineDLSSGVRAMUsage")]
		[UsedByNativeCode]
		public static int CalcStreamlineDLSSGVRAMUsage(Vector2Int taauSize, Vector2Int finalRTSize) => default; // 0x0000000189DF475C-0x0000000189DF4784
		private static void GetStreamlineDLSSGMinMaxFrameGen_Injected(out Vector2Int ret) {
			ret = default;
		} // 0x0000000189DF4784-0x0000000189DF47B8
		private static int CalcStreamlineDLSSGVRAMUsage_Injected(ref Vector2Int taauSize, ref Vector2Int finalRTSize) => default; // 0x0000000189DF4718-0x0000000189DF475C
	}

	public enum HGLightConfigPitchYawModeCPP // TypeDefIndex: 58317
	{
		DirLight = 0,
		Custom = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGLightConfigCPP // TypeDefIndex: 58318
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
		public Quaternion rotationDirect; // 0x30
		public Vector3 forwardDirect; // 0x40
		public Matrix4x4 localToWorld; // 0x4C
		public Quaternion rotationAtmosphere; // 0x8C
		public Quaternion rotationLightShaft; // 0x9C
		public Quaternion rotationSunDisc; // 0xAC
		public Quaternion rotationLensFlare; // 0xBC
		public Quaternion rotationCloudShadow; // 0xCC
		public Quaternion rotationHeightFogDirectionalInscattering; // 0xDC
		public HGLightConfigPitchYawModeCPP cloudShadowPitchYawMode; // 0xEC
		public Vector2 cloudShadowPitchYaw; // 0xF0
	}

	public enum HGSkyConfigSkyMaterialTypeCPP // TypeDefIndex: 58319
	{
		ProceduralSky = 0,
		Skybox = 1
	}

	public enum HGSkyConfigReflectionTypeCPP // TypeDefIndex: 58320
	{
		FromSky = 0,
		Custom = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGSkyConfigCPP // TypeDefIndex: 58321
	{
		// Fields
		public float skyDistance; // 0x00
		public float skyBakedIndirectIntensity; // 0x04
		public float skyDirectIntensity; // 0x08
		public bool useCustomIVDefaultSH; // 0x0C
		public SphericalHarmonicsL2 customIVDefaultSH; // 0x10
		public HGSkyConfigSkyMaterialTypeCPP skyMaterialType; // 0x7C
		public float proceduralSkyLuxFactor; // 0x80
		public bool enableSunDisc; // 0x84
		public float sunDiscRadius; // 0x88
		public float sunDiscRampIntensity; // 0x8C
		public UnityEngine.Color sunDiscColor; // 0x90
		public float skyboxBrightness; // 0xA0
		public UnityEngine.Color skyboxTintColor; // 0xA4
		public float skyboxRotation; // 0xB4
		public Vector3 visibleBox; // 0xB8
		public HGSkyConfigReflectionTypeCPP reflectionType; // 0xC4
		public IntPtr reflectionMap; // 0xC8
		public float culloff; // 0xD0
		public SphericalHarmonicsL2 skyAmbientSH; // 0xD4
		public IntPtr skyboxCubeMap; // 0x140
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGAtmosphereConfigCPP // TypeDefIndex: 58322
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
	public struct HGFogConfigCPP // TypeDefIndex: 58323
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
	public struct HGHeightFogConfigCPP // TypeDefIndex: 58324
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
		public bool enableVolumetricFog; // 0x5C
		public float volumetricFogScatteringDistribution; // 0x60
		public UnityEngine.Color volumetricFogAlbedo; // 0x64
		public UnityEngine.Color volumetricFogEmissive; // 0x74
		public float volumetricFogExtinctionScale; // 0x84
		public float volumetricFogDistance; // 0x88
		public float volumetricFogStartDistance; // 0x8C
		public float volumetricFogNearFadeInDistance; // 0x90
		public float volumetricFogDirectLightingScatteringIntensity; // 0x94
		public float volumetricFogSkyLightingScatteringIntensity; // 0x98
		public bool enableFlowNoise; // 0x9C
		public float flowNoiseIntensity; // 0xA0
		public float flowNoiseDistance; // 0xA4
		public float flowNoiseTilling; // 0xA8
		public float flowNoiseHorizontalDirAngle; // 0xAC
		public float flowNoiseVerticalDirAngle; // 0xB0
		public Vector3 flowNoiseDir; // 0xB4
		public float flowNoiseSpeed; // 0xC0
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGVolumetricFogConfigCPP // TypeDefIndex: 58325
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
		public float flowVLNoiseHorizontalDirAngle; // 0xCC
		public float flowVLNoiseVerticalDirAngle; // 0xD0
		public Vector3 flowVLNoiseDir; // 0xD4
		public float flowVLNoiseSpeed; // 0xE0
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCloudShadowConfigCPP // TypeDefIndex: 58326
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
	}

	public enum HGCloudConfigCloudFlowTypeCPP // TypeDefIndex: 58327
	{
		None = 0,
		Procedural = 1,
		FlowMap = 2
	}

	public enum HGCloudConfigCloudTextureModeCPP // TypeDefIndex: 58328
	{
		SingleChannelRG = 0,
		ColorRGB = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCloudConfigCPP // TypeDefIndex: 58329
	{
		// Fields
		public bool enable; // 0x00
		public bool enableCloudShadow; // 0x01
		public HGCloudShadowConfigCPP cloudShadowConfig; // 0x08
		public IntPtr cloudTexture; // 0x40
		public UnityEngine.Color cloudTint; // 0x48
		public float cloudFadeAlpha; // 0x58
		public float cloudContrast; // 0x5C
		public bool lightAffectCloud; // 0x60
		public float cloudBrightness; // 0x64
		public float cloudAbsoluteBrightness; // 0x68
		public bool brightnessAffectCloudAlpha; // 0x6C
		public bool drawCloudAfterPlanet; // 0x6D
		public HGCloudConfigCloudFlowTypeCPP cloudTextureMode; // 0x70
		public float cloudOpacityR; // 0x74
		public float cloudOpacityG; // 0x78
		public HGCloudConfigCloudTextureModeCPP cloudFlowType; // 0x7C
		public int rotation; // 0x80
		public IntPtr cloudFlowMap; // 0x88
		public float flowSpeed; // 0x90
		public float flowDirectionX; // 0x94
		public float flowDirectionY; // 0x98
		public bool enableLightShaftCloudMask; // 0x9C
		public IntPtr lightShaftCloudMaskTexture; // 0xA0
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGRingPropertyCPP // TypeDefIndex: 58330
	{
		// Fields
		public float outerRadius; // 0x00
		public float width; // 0x04
		public UnityEngine.Color ringColor; // 0x08
		public IntPtr planetRingMap; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialObjectConfigCPP // TypeDefIndex: 58331
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
	public struct HGCelestialObjectPropertyCPP // TypeDefIndex: 58332
	{
		// Fields
		public float radius; // 0x00
		public float selfTiltX; // 0x04
		public float selfTiltZ; // 0x08
		public float selfRotationY; // 0x0C
	}

	public enum HGCelestialDrawerDrawModeCPP // TypeDefIndex: 58333
	{
		Texture = 0,
		Simulated = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialDrawerCPP // TypeDefIndex: 58334
	{
		// Fields
		public HGCelestialDrawerDrawModeCPP drawMode; // 0x00
		public IntPtr drawMaterial; // 0x08
		public Vector2 pitchYaw; // 0x10
		public Vector2 incidentLightingPitchYaw; // 0x18
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGAtmospherePropertyCPP // TypeDefIndex: 58335
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
	public struct HGCelestialAtmosphereObjectConfigCPP // TypeDefIndex: 58336
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
	public struct HGCelestialAdvancedObjectConfigCPP // TypeDefIndex: 58337
	{
		// Fields
		public bool drawAdvancedPlanet; // 0x00
		public IntPtr advancedPlanetMat; // 0x08
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGCelestialConfigCPP // TypeDefIndex: 58338
	{
		// Fields
		public HGCelestialObjectConfigCPP moonConfig; // 0x00
		public HGCelestialAtmosphereObjectConfigCPP talosAlphaConfig; // 0x40
		public HGCelestialAtmosphereObjectConfigCPP planetConfig; // 0xC8
		public HGCelestialAdvancedObjectConfigCPP advancedPlanetConfig; // 0x150
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGLightShaftConfigCPP // TypeDefIndex: 58339
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
	public struct HGAnamorphicStreaksConfigCPP // TypeDefIndex: 58340
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

	public enum HGStarConfigStarTypeCPP // TypeDefIndex: 58341
	{
		RealTimeNoise = 0,
		BakedMap = 1
	}

	public enum HGStarConfigDebugModeCPP // TypeDefIndex: 58342
	{
		Material = 0,
		RChannel = 1,
		GChannel = 2,
		BChannel = 3,
		RGBChannel = 4
	}

	public enum HGStarConfigStarLayerViewModeCPP // TypeDefIndex: 58343
	{
		FullLayer = 0,
		RLayer = 1,
		GLayer = 2,
		BLayer = 3
	}

	public struct HGStarConfigCPP // TypeDefIndex: 58344
	{
		// Fields
		public bool enableStars; // 0x00
		public HGStarConfigStarTypeCPP starType; // 0x04
		public IntPtr noiseRenderTex; // 0x08
		public float starsSize; // 0x10
		public float starsFlickerSpeed; // 0x14
		public UnityEngine.Color starsTint; // 0x18
		public float starsOffset0; // 0x28
		public float starsDensityR; // 0x2C
		public float starsDensity; // 0x30
		public float starsExposure; // 0x34
		public UnityEngine.Color starsTint1; // 0x38
		public float starsOffset1; // 0x48
		public float starsDensityG; // 0x4C
		public float starsDensity1; // 0x50
		public float starsExposure1; // 0x54
		public UnityEngine.Color starsTint2; // 0x58
		public float starsOffset2; // 0x68
		public float starsDensityB; // 0x6C
		public float starsDensity2; // 0x70
		public float starsExposure2; // 0x74
		public HGStarConfigStarLayerViewModeCPP starLayerViewMode; // 0x78
		public IntPtr skyboxStarNoiseMap; // 0x80
		public IntPtr skyBoxStarRangeMap; // 0x88
		public float skyBoxStarDensityMapRotation; // 0x90
		public HGStarConfigDebugModeCPP debugMode; // 0x94
		public bool enableNebula; // 0x98
		public IntPtr nebulaMap; // 0xA0
		public UnityEngine.Color nebulaTint; // 0xA8
		public float nebulaMapRotation; // 0xB8
		public float nebulaStarConverage; // 0xBC
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct ScreenSpaceReflectionVolumeCPP // TypeDefIndex: 58345
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
	public struct HGAutoExposureConfigCPP // TypeDefIndex: 58346
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

	public enum HGToneMappingModeCPP // TypeDefIndex: 58347
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
	public struct HGColorGradingConfigCPP // TypeDefIndex: 58348
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
	public struct HGContactShadowConfigCPP // TypeDefIndex: 58349
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
	public struct HGShadowConfigCPP // TypeDefIndex: 58350
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
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGEnvironmentPhaseCPP // TypeDefIndex: 58351
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
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct FishEyeEffectVolumeCPP // TypeDefIndex: 58352
	{
		// Fields
		public bool enable; // 0x00
		public float distortion; // 0x04
	}

	[UsedByNativeCode]
	public enum BloomQuality // TypeDefIndex: 58353
	{
		Low = 0,
		Medium = 1,
		High = 2
	}

	[UsedByNativeCode]
	public enum BloomResolution // TypeDefIndex: 58354
	{
		Half = 2,
		Quarter = 4
	}

	[UsedByNativeCode]
	public enum BloomBlendMode // TypeDefIndex: 58355
	{
		Add = 0,
		EnergyConservation = 2
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct BloomVolumeCPP // TypeDefIndex: 58356
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
		public bool enableBloomDirt; // 0x44
		public bool enableCharacterBloomControl; // 0x45
		public bool enableAlpha; // 0x46
		public bool enableAnamorphic; // 0x47
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public enum HGSharpenMode // TypeDefIndex: 58357
	{
		Off = 0,
		Filter1 = 1,
		Filter2 = 2,
		Filter4 = 3
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public enum VignetteMode // TypeDefIndex: 58358
	{
		Procedural = 0,
		Masked = 1
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct VignetteCPP // TypeDefIndex: 58359
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
	public struct HGVignetteCPP // TypeDefIndex: 58360
	{
		// Fields
		public UnityEngine.Color color; // 0x00
		public float intensity; // 0x10
		public float smoothness; // 0x14
		public bool rounded; // 0x18
		public bool blink; // 0x19
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGDirtyLensCPP // TypeDefIndex: 58361
	{
		// Fields
		public IntPtr dirtyTex; // 0x00
		public float intensity; // 0x08
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct HGRadialBlurCPP // TypeDefIndex: 58362
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
	public struct HGChromaticAbberationCPP // TypeDefIndex: 58363
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
	public struct HGBWFlashCPP // TypeDefIndex: 58364
	{
		// Fields
		public bool enabled; // 0x00
		public Vector2 centerPosition; // 0x04
		public float bwThreshold; // 0x0C
		public float colorBias; // 0x10
		public bool inverse; // 0x14
		public bool useFlashTex; // 0x15
		public IntPtr flashTexture; // 0x18
		public Vector2 flashTexTiling; // 0x20
		public Vector2 flashTexOffset; // 0x28
		public Vector2 flashTexSpeed; // 0x30
		public Vector2 flashIntensity; // 0x38
		public bool useMaskTex; // 0x40
		public IntPtr maskTexture; // 0x48
		public float maskIntensity; // 0x50
		public bool maskUsePolarUV; // 0x54
		public Vector2 maskTexTiling; // 0x58
		public Vector2 maskTexOffset; // 0x60
		public UnityEngine.Color flashColor; // 0x68
		public UnityEngine.Color backGroundColor; // 0x78
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Environment/HGEnvironmentPhase.h")]
	[UsedByNativeCode]
	public struct SharpenVolumeCPP // TypeDefIndex: 58365
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
	public struct HGVolumeComponentsDataCPP // TypeDefIndex: 58366
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
	}

	[UsedByNativeCode]
	public enum FrameInterpolationAlgo // TypeDefIndex: 58367
	{
		Vendor = 0,
		HGFI = 1,
		Blit = 2
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/FrameGeneration/HGFrameInterpolator.h")]
	[UsedByNativeCode]
	public struct HGCPPFrameInterpolatorUtil // TypeDefIndex: 58368
	{
		// Methods
		[FreeFunction("SetAFMECameraFallbackThreshold")]
		[UsedByNativeCode]
		public static void SetAFMECameraFallbackThreshold(float rotationCos, float moveDistanceSqr) {} // 0x0000000189DF47DC-0x0000000189DF4828
		[FreeFunction("SetMFRCGeneralallbackThreshold")]
		[UsedByNativeCode]
		public static void SetMFRCGeneralallbackThreshold(float vaule) {} // 0x0000000189DF4864-0x0000000189DF48A0
		[FreeFunction("SetMFRCBrightnessDiffFallbackThreshold")]
		[UsedByNativeCode]
		public static void SetMFRCBrightnessDiffFallbackThreshold(float vaule) {} // 0x0000000189DF4828-0x0000000189DF4864
		[FreeFunction("SetMFRCRepeatedPatternFallbackThreshold")]
		[UsedByNativeCode]
		public static void SetMFRCRepeatedPatternFallbackThreshold(float vaule) {} // 0x0000000189DF48A0-0x0000000189DF48DC
	}

	public enum HGLensFlareBlendMode // TypeDefIndex: 58369
	{
		Additive = 0,
		Screen = 1,
		Premultiply = 2,
		Lerp = 3
	}

	public enum HGLensFlareDistribution // TypeDefIndex: 58370
	{
		Uniform = 0,
		Curve = 1,
		Random = 2
	}

	public enum HGLensFlareType // TypeDefIndex: 58371
	{
		Image = 0,
		Circle = 1,
		Polygon = 2
	}

	public struct HGLensFlareDrawData // TypeDefIndex: 58372
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
	public struct HGRenderPipelineDebugResourcesShaderResourcesCPP // TypeDefIndex: 58373
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
	public struct HGRenderPipelineDebugResourcesMaterialResourcesCPP // TypeDefIndex: 58374
	{
		// Fields
		public int debugGizmosMat; // 0x00
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/HGRenderPipelineDebugResources.h")]
	[UsedByNativeCode]
	public struct HGRenderPipelineDebugResourcesTextureResourcesCPP // TypeDefIndex: 58375
	{
		// Fields
		public int debugTexelDensityTexArray; // 0x00
		public int debugAlbedoTex; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/Debug/HGRenderPipelineDebugResources.h")]
	[UsedByNativeCode]
	public struct HGRenderPipelineDebugResourcesCPP // TypeDefIndex: 58376
	{
		// Fields
		public bool enable; // 0x00
		public HGRenderPipelineDebugResourcesShaderResourcesCPP shaders; // 0x04
		public HGRenderPipelineDebugResourcesMaterialResourcesCPP materials; // 0x2C
		public HGRenderPipelineDebugResourcesTextureResourcesCPP textures; // 0x30
	}

	[UsedByNativeCode]
	public struct HGRenderPipelineRuntimeResourcesShaderResourcesCPP // TypeDefIndex: 58377
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
		public int lowResBlitPS; // 0x9C
		public int copyBufferCS; // 0xA0
		public int taauDilationPS; // 0xA4
		public int taauMaskDilationPS; // 0xA8
		public int taauResolvePS; // 0xAC
		public int encodeBC6HCS; // 0xB0
		public int cubeToPanoPS; // 0xB4
		public int blitCubeTextureFacePS; // 0xB8
		public int clearUIntTextureCS; // 0xBC
		public int texture3DAtlasCS; // 0xC0
		public int shadowClearPS; // 0xC4
		public int shadowBlitPS; // 0xC8
		public int shadowBlurPS; // 0xCC
		public int lowResDirectionalShadowPS; // 0xD0
		public int screenSpaceShadowResolvePS; // 0xD4
		public int capsuleShadowCasterPS; // 0xD8
		public int hizDownSampleCS; // 0xDC
		public int renderAtmosphereLutPS; // 0xE0
		public int renderAtmosphereLutCS; // 0xE4
		public int proceduralSkyPS; // 0xE8
		public int skyBoxCubemapPS; // 0xEC
		public int volumetricFogGridInjectionCS; // 0xF0
		public int volumetricFogLightScatteringCS; // 0xF4
		public int volumetricFogFinalIntegrationCS; // 0xF8
		public int bakeFogLutPS; // 0xFC
		public int clothDataUploadCS; // 0x100
		public int clothSingleDispatchCS; // 0x104
		public int drawInteractionNodePS; // 0x108
		public int terrainRenderCS; // 0x10C
		public int terrainRenderPS; // 0x110
		public int terrainDeformEditorGenerateCS; // 0x114
		public int terrainDeformEditorGroundLayerCS; // 0x118
		public int terrainDeformGenerateV2CS; // 0x11C
		public int terrainDeformGenerateCS; // 0x120
		public int terrainDeformReprojectHistoryCS; // 0x124
		public int terrainDeformSpatialFilterCS; // 0x128
		public int terrainDeformGenerateNormalCS; // 0x12C
		public int terrainDeformGenerateDensityCS; // 0x130
		public int terrainDeformEdgeDetectionCS; // 0x134
		public int terrainGroundLayerClipmapCS; // 0x138
		public int lutBuilder3DCS; // 0x13C
		public int lutBuilder2DPS; // 0x140
		public int hgAutoExposureHistogramCS; // 0x144
		public int uberPostPS; // 0x148
		public int CutsceneEffectPS; // 0x14C
		public int bloomPS; // 0x150
		public int sharpenPS; // 0x154
		public int finalPassPS; // 0x158
		public int blitBackBufferPS; // 0x15C
		public int bloomPrefilterCS; // 0x160
		public int bloomBlurCS; // 0x164
		public int bloomBlurNonOptCS; // 0x168
		public int bloomUpsampleCS; // 0x16C
		public int skillScanLinePS; // 0x170
		public int sceneColorAdjustmentPS; // 0x174
		public int frostedGlassBlurCS; // 0x178
		public int frostedGlassBlurPS; // 0x17C
		public int lensFlareDataDrivenPS; // 0x180
		public int uiImageBlurPS; // 0x184
		public int smaaPS; // 0x188
		public int lightShaftPS; // 0x18C
		public int anamorphicStreaksPS; // 0x190
		public int anamorphicStreaksCS; // 0x194
		public int depthOfFieldPS; // 0x198
		public int depthOfFieldMobilePS; // 0x19C
		public int depthOfFieldHexagonalPS; // 0x1A0
		public int circleDepthOfFieldCS; // 0x1A4
		public int motionBlurCS; // 0x1A8
		public int screenSpaceReflectionCS; // 0x1AC
		public int screenSpaceReflectionPS; // 0x1B0
		public int ssprCS; // 0x1B4
		public int contactShadowCS; // 0x1B8
		public int foliageOccluderPS; // 0x1BC
		public int foliageOccluderBlitPS; // 0x1C0
		public int foliageInteractiveBlitPS; // 0x1C4
		public int foliageInteractiveColliderPS; // 0x1C8
		public int sludgeBlitPS; // 0x1CC
		public int sludgePS; // 0x1D0
		public int waterRenderingPS; // 0x1D4
		public int waterOcclusionCS; // 0x1D8
		public int rippleRangePS; // 0x1DC
		public int rippleSimulationPS; // 0x1E0
		public int rippleHeightConvertPS; // 0x1E4
		public int waterProxyPS; // 0x1E8
		public int waterForwardRenderingPS; // 0x1EC
		public int waterTextureProcessPS; // 0x1F0
		public int ivBakeV2CS; // 0x1F4
		public int ivIndirectV2CS; // 0x1F8
		public int ivBakeV3CS; // 0x1FC
		public int ivClipmapUpdateCS; // 0x200
		public int ivUpdateV3CS; // 0x204
		public int ivCopyBufferCS; // 0x208
		public int volumetricComposePS; // 0x20C
		public int farRainPS; // 0x210
		public int sceneEffectRainPS; // 0x214
		public int screenRainDropFXShader; // 0x218
		public int rainSplashShader; // 0x21C
		public int scanLineHighlightShader; // 0x220
		public int fakeVolumeFogPS; // 0x224
		public int clearDepth; // 0x228
		public int particleLightingCS; // 0x22C
		public int shaderLODPS; // 0x230
		public int visibilitySHPS; // 0x234
		public int visibilitySHCS; // 0x238
		public int dlssVelocityCombineCS; // 0x23C
		public int dlssGFlipBlitCS; // 0x240
		public int dlssGUIHintCS; // 0x244
		public int rayTracingReflectionPS; // 0x248
		public int rayTracingReflectionCS; // 0x24C
		public int rayTracingBinningCS; // 0x250
		public int rtrVariableRateCS; // 0x254
		public int rtrScreenSpaceReflectionCS; // 0x258
		public int rtrRayTracingReflection; // 0x25C
		public int rtrTemporalCS; // 0x260
		public int rtrSpatialCS; // 0x264
		public int rtrDebugCS; // 0x268
		public int gpuDrivenInitCS; // 0x26C
		public int gpuDrivenCullingCS; // 0x270
		public int fontGenerateSDFPS; // 0x274
		public int hgFSR3ResolvedMotionVectors; // 0x278
		public int fsr3PrepareInputCS; // 0x27C
		public int fsr3ComputeLuminancePyramid; // 0x280
		public int fsr3ComputeLuminanceInstability; // 0x284
		public int fsr3ComputeShadingChangePyramid; // 0x288
		public int fsr3ComputeShadingChange; // 0x28C
		public int fsr3PrepareReactivity; // 0x290
		public int fsr3Accumulate; // 0x294
		public int fsr3RCAS; // 0x298
		public int frameInterpolationInputConvertPS; // 0x29C
	}

	[UsedByNativeCode]
	public struct HGRenderPipelineRuntimeResourcesTextureResourcesCPP // TypeDefIndex: 58378
	{
		// Fields
		public int HeightFogNoise3DTex; // 0x00
		public int GlintCellNoiseTex; // 0x04
		public int PerlinNoiseTex; // 0x08
		public int SnowDetailNormal; // 0x0C
		public int VisibilityABLut; // 0x10
		public int VisibilitySHLut; // 0x14
		public int WindGlobalNoiseTex; // 0x18
	}

	[UsedByNativeCode]
	public struct HGRenderPipelineRuntimeResourcesAssetResourcesCPP // TypeDefIndex: 58379
	{
		// Fields
		public int simpleSphereMesh; // 0x00
		public int defaultCapsuleMesh; // 0x04
		public int defaultCubeMesh; // 0x08
		public int defaultConeMesh; // 0x0C
		public int defaultQuadMesh; // 0x10
	}

	[UsedByNativeCode]
	public struct HGRenderPipelineRuntimeResourcesCPP // TypeDefIndex: 58380
	{
		// Fields
		public HGRenderPipelineRuntimeResourcesShaderResourcesCPP shaders; // 0x00
		public HGRenderPipelineRuntimeResourcesTextureResourcesCPP textures; // 0x2A0
		public HGRenderPipelineRuntimeResourcesAssetResourcesCPP assets; // 0x2BC
	}

	[UsedByNativeCode]
	public struct InkSimulationPassInput // TypeDefIndex: 58381
	{
		// Fields
		public IntPtr material; // 0x00
		public float influence; // 0x08
		public Vector3 center; // 0x0C
		public float deltaTime; // 0x18
		public int simulationResolution; // 0x1C
		public int densityResolution; // 0x20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDeformPass.h")]
	[UsedByNativeCode]
	public struct TerrainDeformPassInput // TypeDefIndex: 58382
	{
		// Fields
		public IntPtr drawInteractionNodeMaterial; // 0x00
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct TerrainDepthPrepassInput // TypeDefIndex: 58383
	{
		// Fields
		public bool enableTerrainTessellation; // 0x00
		public bool enableTerrainSubdivision; // 0x01
		public bool enableTerrainSubdivisionV2; // 0x02
		public bool enableTerrainDecalDeform; // 0x03
		public bool enableTerrainWetRipple; // 0x04
		public unsafe HGTerrainLayerTypeData* layerTypeData; // 0x08
		public int subdivisionHandle; // 0x10
		public uint terrainCullViewHandle; // 0x14
		public uint editorTerrainCullViewHandle; // 0x18
		public int vtFeedbackId; // 0x1C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/Utils.h")]
	[UsedByNativeCode]
	public struct HGViewConstantsCPP // TypeDefIndex: 58384
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
	public struct HGRenderPathOtherData // TypeDefIndex: 58393
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
		public bool enableWetness; // 0x648
		public bool enableWetnessHighQuality; // 0x649
		public bool rainRendererUpdateSuccess; // 0x64A
		public Vector4 _VerticalOcclusionMapParam0; // 0x64C
		public bool enabledVerticalOcclusion; // 0x65C
		public Vector4 _InteractRaftParams0; // 0x660
		public Vector4 _InteractRaftParams1; // 0x670
		public unsafe fixed /* 0x00000000-0x00000000 */ float _HackTempDataBeforeCPPPlugin[0]; // 0x680
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/ReflectionProbeBinningPass.h")]
	[UsedByNativeCode]
	public struct HGReflectionProbeBinningInput // TypeDefIndex: 58394
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
	public struct SkyRendererInput // TypeDefIndex: 58395
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
	public struct HGWaterSectorRenderingInput // TypeDefIndex: 58396
	{
		// Fields
		public bool enable; // 0x00
		public int sectorTextureSize; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Water/WaterInteractionRenderingPass.h")]
	[UsedByNativeCode]
	public struct HGWaterInteractionRenderingInput // TypeDefIndex: 58397
	{
		// Fields
		public bool enable; // 0x00
		public CBHandle waterInteractiveCB; // 0x08
		public float deltaTime; // 0x20
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Water/WaterRenderingPass.h")]
	[UsedByNativeCode]
	public struct HGWaterRenderingInput // TypeDefIndex: 58398
	{
		// Fields
		public bool enable; // 0x00
		public bool enableUnlit; // 0x01
		public bool enableRain; // 0x02
		public bool enableInk; // 0x03
		public bool shouldStoreDepth; // 0x04
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
		public IntPtr screenSpaceMesh; // 0x1A8
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
	[UsedByNativeCode]
	public struct HGRenderPathBeforeCullingParamsCPP // TypeDefIndex: 58399
	{
		// Fields
		public int currentDeviceType; // 0x00
		public Vector2Int sceneRTSize; // 0x04
		public uint COMPOUND_CHARACTER_LAYER_MASK; // 0x0C
		public unsafe LODCrossFadeConfig* lodCrossFadeConfig; // 0x10
		public unsafe LODCrossFadeConfig* uiCameraLodCrossFadeConfig; // 0x18
		public unsafe HGSettingParametersCpp* settingParameters; // 0x20
		public unsafe HGLightConfigCPP* lightConfig; // 0x28
		public unsafe HGShadowConfigCPP* shadowConfig; // 0x30
		public float heightFogCullingFarClipPlane; // 0x38
		public float overrideCsmMaxDistanceValue; // 0x3C
		public bool overrideCsmShadowDistance; // 0x40
		public bool enableShadowCulling; // 0x41
		public bool forceRegenerateAsm; // 0x42
		public bool isInIsolatedDisplayMode; // 0x43
		public bool renderPathMobile; // 0x44
		public bool enableSceneViewLODCrossFade; // 0x45
		public bool prevTransformReset; // 0x46
		public bool showOcclusionCulling; // 0x47
		public uint cullingViewUniqueID; // 0x48
		public unsafe HGCharacterShadowInputsCPP* characterShadowInputs; // 0x50
		public IntPtr lightManager; // 0x58
		public unsafe HGDebugFeaturesManagerCPP* debugFeaturesManager; // 0x60
		public IntPtr cullingSystem; // 0x68
		public IntPtr rendererSystem; // 0x70
		public IntPtr rayTracingScene; // 0x78
		public IntPtr lodStateSystem; // 0x80
		public IntPtr customDepthOnlyRequestManager; // 0x88
		public IntPtr foliageOccluderManager; // 0x90
		public bool bSkipRender; // 0x98
		public IntPtr lightClusteringBeforeCullingOutput; // 0xA0
		public IntPtr shadowPassBeforeCullingOutput; // 0xA8
		public IntPtr customDepthOnlyBeforeCullingOutput; // 0xB0
		public uint foliageOccluderCullViewHandle; // 0xB8
		public IntPtr renderCamera; // 0xC0
		public IntPtr uiRenderCamera; // 0xC8
		public IntPtr occlusionCamera; // 0xD0
		public uint cullingViewHandle; // 0xD8
		public uint uiCullingViewHandle; // 0xDC
		public uint rayTracingCullingViewHandle; // 0xE0
		public uint rayTracingTLASHandle; // 0xE4
		public IntPtr visibleLights; // 0xE8
		public int visibleLightCount; // 0xF0
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/PostProcess/VFXPPScanLinePass.h")]
	[UsedByNativeCode]
	public struct HGRenderPathParamsCPP // TypeDefIndex: 58400
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
		public unsafe HGViewConstantsCPP* mainViewConstants; // 0x28
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
		public bool enableAOVOutput; // 0x42
		public bool characterOutlineEnabled; // 0x43
		public bool renderWithAlpha; // 0x44
		public bool sceneViewVolumetricFogEnable; // 0x45
		public bool isInIsolatedDisplayMode; // 0x46
		public bool isFirstFrame; // 0x47
		public bool prevTransformReset; // 0x48
		public bool enableWetness; // 0x49
		public bool shouldRenderRippleState; // 0x4A
		public bool enableEditorMacros; // 0x4B
		public UnityEngine.Color backgroundColorHDR; // 0x4C
		public uint cameraFrameCount; // 0x5C
		public uint debugRenderMode; // 0x60
		public uint cullingViewHandle; // 0x64
		public float screenCullingRatio; // 0x68
		public float screenCullingRatioDistance; // 0x6C
		public uint screenCullingLayerMask; // 0x70
		public uint rayTracingTLASHandle; // 0x74
		public unsafe HGEnvironmentPhaseCPP* envPhase; // 0x78
		public unsafe HGVolumeComponentsDataCPP* volumeComponentsData; // 0x80
		public unsafe HGVolumeComponentsDataCPP* uiVolumeComponentsData; // 0x88
		public ulong frameSettingsData0; // 0x90
		public ulong frameSettingsData1; // 0x98
		public int lutSize; // 0xA0
		public GraphicsFormat lutFormat; // 0xA4
		public Vector2Int sceneRTSize; // 0xA8
		public GraphicsFormat sceneRTColorFormat; // 0xB0
		public GraphicsFormat sceneRTDepthFormat; // 0xB4
		public Vector2Int taauRTSize; // 0xB8
		public Vector2Int finalRTSize; // 0xC0
		public IntPtr cullingResults; // 0xC8
		public IntPtr visibleLights; // 0xD0
		public int visibleLightCount; // 0xD8
		public uint uiCullingViewHandle; // 0xDC
		public int sortingOrdersToBlurInternalCount; // 0xE0
		public unsafe int* sortingOrdersToBlurInternal; // 0xE8
		public bool render3DUI; // 0xF0
		public bool enableGPUDriven; // 0xF1
		public IntPtr lightManager; // 0xF8
		public unsafe HGDebugRenderManagerCPP* debugRenderManager; // 0x100
		public unsafe HGDebugFeaturesManagerCPP* debugFeaturesManager; // 0x108
		public IntPtr graphicsFeatureManager; // 0x110
		public IntPtr ivManager; // 0x118
		public IntPtr terrainDeformManager; // 0x120
		public IntPtr interactionManager; // 0x128
		public IntPtr terrainManager; // 0x130
		public IntPtr editorTerrainManager; // 0x138
		public IntPtr sludgeRender; // 0x140
		public IntPtr decalRender; // 0x148
		public IntPtr meshRender; // 0x150
		public IntPtr grassRender; // 0x158
		public IntPtr reflectionProbeSystem; // 0x160
		public IntPtr clothManager; // 0x168
		public IntPtr uiRender; // 0x170
		public IntPtr capsuleShadowManager; // 0x178
		public IntPtr foliageOccluderRenderer; // 0x180
		public IntPtr foliageInteractiveManager; // 0x188
		public IntPtr foliageOccluderManager; // 0x190
		public IntPtr waterRender; // 0x198
		public IntPtr gpuDrivenRendererV1; // 0x1A0
		public IntPtr gpuDrivenRendererV2; // 0x1A8
		public IntPtr cullingSystem; // 0x1B0
		public IntPtr rendererSystem; // 0x1B8
		public IntPtr subsurfaceManager; // 0x1C0
		public IntPtr subsurfaceProfileManager; // 0x1C8
		public IntPtr shadingStateSystem; // 0x1D0
		public IntPtr geometrySystem; // 0x1D8
		public IntPtr resourceManager; // 0x1E0
		public IntPtr customDepthOnlyRequestManager; // 0x1E8
		public IntPtr dlssRender; // 0x1F0
		public IntPtr customDrawRTManager; // 0x1F8
		public IntPtr rayTracingRender; // 0x200
		public unsafe UIImageBlurPassInputV2* uiImageBlurPassInput; // 0x208
		public bool isPlaying; // 0x210
		public bool isSkyRenderingEnabled; // 0x211
		public bool forceRenderAtmosphereLutEveryFrame; // 0x212
		public bool renderAtmosphereLutUsingCompute; // 0x213
		public unsafe InkSimulationPassInput* inkSimulationPassInput; // 0x218
		public unsafe HGReflectionProbeBinningInput* reflectionProbeBinningInput; // 0x220
		public bool renderPathMobile; // 0x228
		public bool lightsUseLinearIntensity; // 0x229
		public bool isActiveColorSpaceGamma; // 0x22A
		public long ivTargetID; // 0x230
		public unsafe TerrainDeformPassInput* terrainDeformPassInput; // 0x238
		public unsafe TerrainDepthPrepassInput* terrainDepthPrepassInput; // 0x240
		public unsafe HGWaterSectorRenderingInput* waterSectorRenderingInput; // 0x248
		public unsafe HGWaterInteractionRenderingInput* waterInteractionRenderingInput; // 0x250
		public unsafe HGWaterRenderingInput* waterRenderingInput; // 0x258
		public unsafe HGGTAmbientOcclusionSettingParameters* gtaoSettingParameters; // 0x260
		public unsafe HGFakePlanarReflectionRenderingInput* fakePlanarReflectionRenderingInput; // 0x268
		public bool flowNoiseEnabled; // 0x270
		public bool hasTerrainSimpleSubsurface; // 0x271
		public unsafe HGDepthOfFieldParameters* dofParameters; // 0x278
		public unsafe HGMotionBlurParametersV2* motionBlurParameters; // 0x280
		public unsafe LensFlareRenderingInput* lensFlareRenderingInput; // 0x288
		public unsafe ParafinRenderingInput* parafinRenderingInput; // 0x290
		public unsafe VFXScreenMaterialData* vfxScreenMaterialData; // 0x298
		public unsafe VFXPPScanLinePassInput* vfxPPScanLinePassInput; // 0x2A0
		public unsafe SkyRendererInput* skyRendererInput; // 0x2A8
		public unsafe VisibilitySHRPInput* visibilitySHRPInput; // 0x2B0
		public unsafe FrostedGlassPassRPInput* frostedGlassPassRPInput; // 0x2B8
		public unsafe FishEyeEffectInput* fishEyeEffectInput; // 0x2C0
		public unsafe CutsceneEffectPassRPInput* cutsceneEffectPassRPInput; // 0x2C8
		public unsafe VolumetricCloudInput* volumetricCloudInput; // 0x2D0
		public unsafe int* rtExtractionSceneColorLS; // 0x2D8
		public unsafe int* rtExtractionBlurredSceneColorPS; // 0x2E0
		public unsafe int* rtExtractionSceneColorPS; // 0x2E8
		public unsafe int* rtExtractionFinalResult; // 0x2F0
		public int rtExtractionSceneColorLSCount; // 0x2F8
		public int rtExtractionBlurredSceneColorPSCount; // 0x2FC
		public int rtExtractionSceneColorPSCount; // 0x300
		public int rtExtractionFinalResultCount; // 0x304
		public int waterMarkRTCount; // 0x308
		public unsafe int* waterMarkSrcRTs; // 0x310
		public unsafe int* waterMarkDstRTs; // 0x318
		public unsafe float* waterMarkHeightScales; // 0x320
		public int inplaceWaterMarkRTCount; // 0x328
		public unsafe int* inplaceWaterMarkDstRTs; // 0x330
		public unsafe float* inplaceWaterMarkHeightScales; // 0x338
		public bool forceRegenerateAsm; // 0x340
		public unsafe LODCrossFadeConfig* lodCrossFadeConfig; // 0x348
		public bool bSkipRender; // 0x350
		public IntPtr lightClusteringBeforeCullingOutput; // 0x358
		public IntPtr shadowPassBeforeCullingOutput; // 0x360
		public IntPtr customDepthOnlyBeforeCullingOutput; // 0x368
		public uint foliageOccluderCullViewHandle; // 0x370
		public float rayTracingReflectionVolumeBlend; // 0x374
		public int rayTracingReflectionMode; // 0x378
		public IntPtr cameraTargetTexture; // 0x380
		public IntPtr fontSDFGenerationRequestQueue; // 0x388
		public bool enableFSR3; // 0x390
	}

	public enum HGRenderPathInternalCPP // TypeDefIndex: 58401
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
	public struct HGGTAmbientOcclusionSettingParameters // TypeDefIndex: 58402
	{
		// Fields
		public bool enableAO; // 0x00
		public bool enableFP32Depths; // 0x01
		public bool enableBentNormals; // 0x02
		public int screenWidth; // 0x04
		public int screenHeight; // 0x08
		public int qualityLevel; // 0x0C
		public int denoisePasses; // 0x10
		public int cameraFrameCount; // 0x14
		public float finalValuePower; // 0x18
		public float depthMIPSamplingOffset; // 0x1C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/MotionBlurPass.h")]
	[UsedByNativeCode]
	public struct HGMotionBlurParametersV2 // TypeDefIndex: 58403
	{
		// Fields
		public bool enable; // 0x00
		public float shutterAngle; // 0x04
		public float sampleCount; // 0x08
		public float blendFrame; // 0x0C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/LensFlarePass.h")]
	[UsedByNativeCode]
	public struct LensFlareRenderingInput // TypeDefIndex: 58404
	{
		// Fields
		public bool enable; // 0x00
		public unsafe HGLensFlareDrawData* drawDataList; // 0x08
		public int drawDataCount; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/PostProcess/ParafinPass.h")]
	[UsedByNativeCode]
	public struct ParafinRenderingInput // TypeDefIndex: 58405
	{
		// Fields
		public bool enable; // 0x00
		public int parafinMaterialCount; // 0x04
		public unsafe int* parafinMaterialIDs; // 0x08
		public IntPtr parafinMesh; // 0x10
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/DepthOfFieldPass.h")]
	[UsedByNativeCode]
	public struct HGDepthOfFieldParameters // TypeDefIndex: 58406
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
	public struct VFXScreenMaterialData // TypeDefIndex: 58407
	{
		// Fields
		public bool enableFullScreenVFXData; // 0x00
		public IntPtr vfxFullScreenMesh; // 0x08
		public IntPtr vfxFullScreenMaterial; // 0x10
		public IntPtr vfxFullScreenMaterialPropertyBlock; // 0x18
	}

	[UsedByNativeCode]
	public struct CustomDepthOnlySystemRequest // TypeDefIndex: 58408
	{
		// Fields
		public Vector3 rootPosition; // 0x00
		public Vector3 frustumSize; // 0x0C
		public Vector2Int rtSize; // 0x18
		public Vector2Int pageSize; // 0x20
		public uint depthBits; // 0x28
		public GraphicsFormat format; // 0x2C
		public int depthRTShaderID; // 0x30
		public int transformCBShaderID; // 0x34
		public bool includeDynamicObjects; // 0x38
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/FakePlanarReflectionPass.h")]
	[UsedByNativeCode]
	public struct HGFakePlanarReflectionRenderingInput // TypeDefIndex: 58409
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
	public struct HGTerrainGlintData // TypeDefIndex: 58410
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
	public struct HGTerrainSubsurfaceData // TypeDefIndex: 58411
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
	public struct HGTerrainFakeVolumeData // TypeDefIndex: 58412
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
		public int m_fakeVolumeOpacityMask; // 0x9C
		public int m_fakeVolumeMask; // 0xA0
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct HGTerrainFakeShadowData // TypeDefIndex: 58413
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
	public struct HGTerrainLayerTypeData // TypeDefIndex: 58414
	{
		// Fields
		public bool m_bHasLayerTypeData; // 0x00
		public Matrix4x4 m_localToWorldMatrix; // 0x04
		public Matrix4x4 m_worldToLocalMatrix; // 0x44
		public int m_heightmapTexture; // 0x84
		public Vector4 m_heightmapScale; // 0x88
		public HGTerrainGlintData m_glintData; // 0x98
		public HGTerrainSubsurfaceData m_subsurfaceData; // 0xC4
		public HGTerrainFakeVolumeData m_fakeVolumeData; // 0xD8
		public HGTerrainFakeShadowData m_fakeShadowData; // 0x17C
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/TerrainDepthPrepass.h")]
	[UsedByNativeCode]
	public struct HGTerrainFeatures // TypeDefIndex: 58415
	{
		// Fields
		public bool enableDeformBlend; // 0x00
		public bool enableWetRipple; // 0x01
		public unsafe HGTerrainLayerTypeData* layerTypeData; // 0x08
	}

	[UsedByNativeCode]
	public struct HGVolumetricCloudDataCB // TypeDefIndex: 58416
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
	public struct HGVolumetricBounds // TypeDefIndex: 58417
	{
		// Fields
		public bool enableBounds; // 0x00
		public Bounds worldBounds; // 0x04
	}

	[UsedByNativeCode]
	public struct HGVolumetricRenderItem // TypeDefIndex: 58418
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

	public enum EFramingQuality // TypeDefIndex: 58419
	{
		Checkerboard = 0,
		Quarter = 1
	}

	public enum EDownResFilter // TypeDefIndex: 58420
	{
		DepthFade = 0,
		Nearest = 1,
		Bilateal = 2,
		Noisy = 3
	}

	[UsedByNativeCode]
	public struct HGDownResQualityPack // TypeDefIndex: 58421
	{
		// Fields
		public bool enableDownRes; // 0x00
		public float downResRatio; // 0x04
		public EDownResFilter downResFilter; // 0x08
	}

	[UsedByNativeCode]
	public struct HGFramingQualityPack // TypeDefIndex: 58422
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
	public struct HGTAAQualityPack // TypeDefIndex: 58423
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

	public enum EFarCloudFramingQuality // TypeDefIndex: 58424
	{
		None = 0,
		Checkerboard = 1,
		Quarter = 2,
		Framing4x2 = 3,
		Framing4x4 = 4
	}

	[UsedByNativeCode]
	public struct HGCloudQualityPack // TypeDefIndex: 58425
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
		public float farCloudEmptySkipSizeScale; // 0x54
	}

	[UsedByNativeCode]
	public struct HGVolumetricQualitySettings // TypeDefIndex: 58426
	{
		// Fields
		public HGDownResQualityPack downResQualityPack; // 0x00
		public HGFramingQualityPack framingQualityPack; // 0x0C
		public HGTAAQualityPack taaQualityPack; // 0x20
		public HGCloudQualityPack cloudQualityPack; // 0x2C
	}

	public enum HGRainDrawCmdType // TypeDefIndex: 58427
	{
		DrawMesh = 0,
		DrawMeshInstancedProcedural = 1
	}

	[UsedByNativeCode]
	public struct HGRainParams // TypeDefIndex: 58428
	{
		// Fields
		public int mesh; // 0x00
		public int material; // 0x04
		public IntPtr shaderPropertySheet; // 0x08
		public Matrix4x4 matrix; // 0x10
		public int subMeshIndex; // 0x50
		public int shaderPass; // 0x54
		public int instanceCount; // 0x58
		public HGRainDrawCmdType type; // 0x5C
	}

	[UsedByNativeCode]
	public struct ScanLineDataPack // TypeDefIndex: 58429
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
	public struct HighlightDataPack // TypeDefIndex: 58430
	{
		// Fields
		public Vector4 detectDistance; // 0x00
		public Vector3 beamHeight; // 0x10
		public float meshHeight; // 0x1C
	}

	[UsedByNativeCode]
	public struct VFXPPScanLinePassInput // TypeDefIndex: 58431
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
	public struct UIImageBlurPassInputV2 // TypeDefIndex: 58432
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
	public struct VisibilitySHRPInput // TypeDefIndex: 58433
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
	public struct FrostedGlassPassRPInput // TypeDefIndex: 58434
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
	public struct FishEyeEffectInput // TypeDefIndex: 58435
	{
		// Fields
		public int colorPassIndex; // 0x00
		public int depthPassIndex; // 0x04
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/PostProcess/CutsceneEffectPass.h")]
	[UsedByNativeCode]
	public struct CutsceneEffectPassRPInput // TypeDefIndex: 58436
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
	public struct VolumetricCloudInput // TypeDefIndex: 58437
	{
		// Fields
		public IntPtr defaultVolumetricMat; // 0x00
		public uint renderSizeX; // 0x08
		public uint renderSizeY; // 0x0C
		public Matrix4x4 volumeMatrixVP; // 0x10
		public unsafe HGVolumetricRenderItem* renderItems; // 0x50
		public int renderItemsCount; // 0x58
		public HGVolumetricQualitySettings qualitySetting; // 0x5C
		public int volumetricState; // 0xE0
		public float volumetricFadeRatio; // 0xE4
	}

	[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/Shadow/HGCharacterShadowmapManager.h")]
	[UsedByNativeCode]
	public struct HGCharacterShadowInputsCPP // TypeDefIndex: 58438
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
	public struct ParticleLightingIVInput // TypeDefIndex: 58439
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

	public class HGRenderGraphCPP // TypeDefIndex: 58440
	{
		// Constructors
		public HGRenderGraphCPP() {} // Dummy constructor
	
		// Methods
		[FreeFunction("HGRenderGraph_AllocateTempFromCSharp")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/HGRenderGraph.h")]
		public static IntPtr AllocateTempFromCSharp(long size) => default; // 0x0000000182508BE0-0x0000000182508C20
		public static unsafe T* AllocateTempFromCSharp<T>()
			where T : struct => default;
		[FreeFunction("HGRenderPath_Create")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/Utils.h")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static unsafe long HGRenderPath_Create(HGRenderPathInternalCPP renderPath, HGRenderPipelineRuntimeResourcesCPP* defaultResources, HGRenderPipelineDebugResourcesCPP* debugResources) => default; // 0x0000000183CAA520-0x0000000183CAA580
		[FreeFunction("HGRenderPath_BeforeCulling")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static unsafe void HGRenderPath_BeforeCulling(long _ptr, HGRenderPathBeforeCullingParamsCPP* renderPathBeforeCullingParams, IntPtr camera, IntPtr uiCamera, IntPtr occlusionCamera) {} // 0x00000001825AD460-0x00000001825AD4D0
		[FreeFunction("HGRenderPath_Render")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static unsafe void HGRenderPath_Render(long _ptr, HGRenderPathParamsCPP* renderPathParams, HGRenderPathBeforeCullingParamsCPP* renderPathBeforeCullingParams, IntPtr camera, IntPtr renderContext, IntPtr _cmd) {} // 0x00000001830C5730-0x00000001830C57A0
		[FreeFunction("HGRenderPath_Destroy")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static void HGRenderPath_Destroy(long _ptr) {} // 0x0000000183D1EF20-0x0000000183D1EF60
		[FreeFunction("HGRenderPathSimpleUI_Create")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static long HGRenderPathSimpleUI_Create() => default; // 0x000000018333D400-0x000000018333D440
		[FreeFunction("HGRenderPathSimpleUI_Render")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static void HGRenderPathSimpleUI_Render(long _ptr, IntPtr camera, IntPtr renderContext, IntPtr _cmd) {} // 0x000000018333D390-0x000000018333D400
		[FreeFunction("HGRenderPathSimpleUI_Destroy")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPath/HGRenderPathDefaultDeferred.h")]
		public static void HGRenderPathSimpleUI_Destroy(long _ptr) {} // 0x0000000182D155F0-0x0000000182D15630
		[FreeFunction("CustomDepthRequestManager_CreateWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDepthOnlyPass.h")]
		public static long CustomDepthRequestManager_Create() => default; // 0x0000000182D16050-0x0000000182D16090
		[FreeFunction("CustomDepthRequestManager_RemoveWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDepthOnlyPass.h")]
		public static void CustomDepthRequestManager_Remove(long mgr) {} // 0x0000000182D15530-0x0000000182D15570
		[FreeFunction("CustomDepthRequestManager_RequestSystemWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDepthOnlyPass.h")]
		public static unsafe uint CustomDepthRequestManager_RequestSystem(long mgr, CustomDepthOnlySystemRequest* request) => default; // 0x00000001836B0A90-0x00000001836B0AE0
		[FreeFunction("CustomDepthRequestManager_RemoveSystemWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDepthOnlyPass.h")]
		public static void CustomDepthRequestManager_RemoveSystem(long mgr, uint idx) {} // 0x00000001836B0AE0-0x00000001836B0B30
		[FreeFunction("CustomDepthRequestManager_UpdateSystemWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDepthOnlyPass.h")]
		public static void CustomDepthRequestManager_UpdateSystem(long mgr, uint idx, Vector3 position) {} // 0x0000000189DF498C-0x0000000189DF49A0
		[FreeFunction("CustomDepthRequestManager_ToggleSystemWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDepthOnlyPass.h")]
		public static void CustomDepthRequestManager_ToggleSystem(long mgr, uint idx, bool flag) {} // 0x0000000182799E00-0x0000000182799E60
		[FreeFunction("CustomDrawRTManager_CreateWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		public static long CustomDrawRTManager_Create() => default; // 0x0000000182D16010-0x0000000182D16050
		[FreeFunction("CustomDrawRTManager_DestroyWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		public static void CustomDrawRTManager_Destroy(long ptr) {} // 0x0000000182D155B0-0x0000000182D155F0
		[FreeFunction("CustomDrawRTManager_AllocateRenderTextureWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		private static int CustomDrawRTManager_AllocateRenderTextureImpl(long manager, int width, int height, int depth, int mipCount, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) => default; // 0x0000000183114960-0x00000001831149D0
		public static RenderTexture CustomDrawRTManager_AllocateRenderTexture(long manager, int width, int height, int depth, int mipCount, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) => default; // 0x0000000183114790-0x0000000183114830
		[FreeFunction("CustomDrawRTManager_ReleaseRenderTextureWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		private static void CustomDrawRTManager_ReleaseRenderTextureImpl(long manager, IntPtr rt) {} // 0x0000000183115080-0x00000001831150D0
		public static void CustomDrawRTManager_ReleaseRenderTexture(long manager, RenderTexture rt) {} // 0x00000001831146B0-0x00000001831146D0
		[FreeFunction("CustomDrawRTManager_DrawTextureWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		private static void CustomDrawRTManager_DrawTextureImpl(long manager, IntPtr rt, [IsReadOnly] in Rect rect, IntPtr texture, IntPtr material, int pass) {} // 0x0000000183114FB0-0x0000000183115020
		public static void CustomDrawRTManager_DrawTexture(long manager, RenderTexture rt, [IsReadOnly] in Rect rect, Texture texture, Material material, int pass) {} // 0x0000000183114F60-0x0000000183114FB0
		[FreeFunction("CustomDrawRTManager_ClearTextureWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/CustomDrawTexturePass.h")]
		private static void CustomDrawRTManager_ClearTextureImpl(long manager, IntPtr rt, [IsReadOnly] in UnityEngine.Color color) {} // 0x0000000183115020-0x0000000183115080
		public static void CustomDrawRTManager_ClearTexture(long manager, RenderTexture rt, [IsReadOnly] in UnityEngine.Color color) {} // 0x0000000183114B40-0x0000000183114B60
		[FreeFunction("InkSimulationPass_DestroyCSharpWrapper")]
		[NativeHeader("Modules/HGGraphicsCPP/Public/RenderPipeline/RenderPass/InkSimulationPass.h")]
		public static void InkSimulationPass_Destroy(long _ptr) {} // 0x0000000189DF49A0-0x0000000189DF4A38
		private static void CustomDepthRequestManager_UpdateSystem_Injected(long mgr, uint idx, ref Vector3 position) {} // 0x0000000189DF493C-0x0000000189DF498C
	}
}
