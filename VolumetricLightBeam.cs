/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Image 80: VolumetricLightBeam.dll - Assembly: VolumetricLightBeam, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62504-62571
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public static class EditorPrefsStrings // TypeDefIndex: 62505
{
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 62568
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D; // 0x00 // Static value (base64): AQAAAAEAAAAKAAAA - Metadata: 0x02352014
	internal static readonly __StaticArrayInitTypeSize_12 F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B; // 0x0C // Static value (base64): AQAAAAQAAAAFAAAA - Metadata: 0x02352024

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 62567
	{
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 62507
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 62508
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 62509
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 62510
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 62511
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 62506
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 62569
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x000000018B8974FC-0x000000018B897560
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 62570
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B897560-0x000000018B8975F4
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 62571
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B89AC90-0x000000018B89ACF4
		public static bool IsPatched(int id); // 0x000000018B89AD80-0x000000018B89AE18
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B89AB4C-0x000000018B89AC18
		public object CreateWrapper(int id); // 0x000000018B89AC18-0x000000018B89AC90
		public object InitWrapperArray(int len); // 0x000000018B89ACF4-0x000000018B89AD80
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B89AAA8-0x000000018B89AB4C
	}
}

namespace VLB
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface // TypeDefIndex: 62512
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private VolumetricLightBeam m_Master; // 0x18
		private Matrix4x4 m_ColorGradientMatrix; // 0x20
		private MeshType m_CurrentMeshType; // 0x60
		private MaterialModifier.Callback m_MaterialModifierCallback; // 0x68
		private Coroutine m_CoFadeOut; // 0x70
		[CompilerGenerated]
		private MeshRenderer _meshRenderer_k__BackingField; // 0x78
		[CompilerGenerated]
		private MeshFilter _meshFilter_k__BackingField; // 0x80
		[CompilerGenerated]
		private Mesh _coneMesh_k__BackingField; // 0x88
		[SerializeField]
		public Material m_CustomMaterial; // 0x90
	
		// Properties
		public MeshRenderer meshRenderer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862A0-0x0000000184D862B0 0x0000000186402320-0x0000000186402330
		public MeshFilter meshFilter { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184CD9970-0x0000000184CD9980
		public Mesh coneMesh { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D861F0-0x0000000184D86200 0x0000000185395D30-0x0000000185395D44
		private bool visible { get; set; } // 0x000000018B896EA0-0x000000018B896EC0 0x000000018B896F00-0x000000018B896F7C
		public int sortingLayerID { get; set; } // 0x000000018B896E60-0x000000018B896E80 0x000000018B896EC0-0x000000018B896EE0
		public int sortingOrder { get; set; } // 0x000000018B896E80-0x000000018B896EA0 0x000000018B896EE0-0x000000018B896F00
		public bool _INTERNAL_IsFadeOutCoroutineRunning { get; } // 0x0000000189B02DAC-0x0000000189B02DB8 
	
		// Constructors
		public BeamGeometry(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void RestartFadeOutCoroutine(); // 0x00000001841E1670-0x00000001841E1680
		public void StopFadeOutCoroutine(); // 0x00000001841E1670-0x00000001841E1680
		public void SetMaterialProp(int nameID, float value); // 0x000000018B896D94-0x000000018B896E60
		public void SetMaterialProp(int nameID, Vector4 value); // 0x000000018B896B10-0x000000018B896BF0
		public void SetMaterialProp(int nameID, UnityEngine.Color value); // 0x000000018B896BF0-0x000000018B896CD0
		public void SetMaterialProp(int nameID, Matrix4x4 value); // 0x000000018B8969F8-0x000000018B896B10
		public void SetMaterialProp(int nameID, Texture value); // 0x000000018B896CD0-0x000000018B896D94
	}

	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject // TypeDefIndex: 62513
	{
		// Fields
		public const string ClassName = "Config"; // Metadata: 0x02351B76
		public const string kAssetName = "VLBConfigOverride"; // Metadata: 0x02351B7D
		public const string kAssetNameExt = ".asset"; // Metadata: 0x02351B8F
		private static Config ms_Instance; // 0x00
		[HighlightNull]
		public Mesh sharedMesh; // 0x18
		public bool featureEnabledDustParticles; // 0x20
		public bool featureEnabledEffect; // 0x21
		public bool featureEnabledTriggerZone; // 0x22
		public bool geometryOverrideLayer; // 0x23
		public int geometryLayerID; // 0x24
		public string geometryTag; // 0x28
		public int geometryRenderQueue; // 0x30
		[FormerlySerializedAs("renderPipeline")]
		[SerializeField]
		private VLB.RenderPipeline _RenderPipeline; // 0x34
		[FormerlySerializedAs("renderingMode")]
		[SerializeField]
		private RenderingMode _RenderingMode; // 0x38
		public float ditheringFactor; // 0x3C
		public bool useLightColorTemperature; // 0x40
		public int sharedMeshSides; // 0x44
		public int sharedMeshSegments; // 0x48
		public Vector3 globalNoisesScale; // 0x4C
		public Vector3 globalNoiseVelocity; // 0x58
		public string fadeOutCameraTag; // 0x68
		[HighlightNull]
		public Texture3D noiseTexture3D; // 0x70
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab; // 0x78
		public Texture2D ditheringNoiseTexture; // 0x80
		public FeatureEnabledColorGradient featureEnabledColorGradient; // 0x88
		public bool featureEnabledDepthBlend; // 0x8C
		public bool featureEnabledNoise3D; // 0x8D
		public bool featureEnabledDynamicOcclusion; // 0x8E
		public bool featureEnabledMeshSkewing; // 0x8F
		public bool featureEnabledShaderAccuracyHigh; // 0x90
		[SerializeField]
		private Shader _BeamShader; // 0x98
		private Transform m_CachedFadeOutCamera; // 0xA0
		[SerializeField]
		private int pluginVersion; // 0xA8
		[SerializeField]
		private Material _DummyMaterial; // 0xB0
	
		// Properties
		public VLB.RenderPipeline renderPipeline { get; } // 0x0000000184D86730-0x0000000184D86740 
		public RenderingMode renderingMode { get; } // 0x0000000184D863B0-0x0000000184D863C0 
		public RenderingMode actualRenderingMode { get; } // 0x000000018B8973B0-0x000000018B8973CC 
		public bool useSinglePassShader { get; } // 0x000000018B897440-0x000000018B897458 
		public bool requiresDoubleSidedMesh { get; } // 0x000000018B897440-0x000000018B897458 
		public Shader beamShader { get; } // 0x0000000184D85EE0-0x0000000184D85EF0 
		public Transform fadeOutCameraTransform { get; } // 0x000000018B8973CC-0x000000018B897438 
		public bool isHDRPExposureWeightSupported { get; } // 0x000000018B897438-0x000000018B897440 
		public bool hasRenderPipelineMismatch { get; } // 0x00000001837E2870-0x00000001837E28E0 
		public static Config Instance { get; } // 0x0000000185393938-0x0000000185393944 
	
		// Constructors
		public Config(); // 0x0000000184B698D0-0x0000000184B699F0
	
		// Methods
		public void Reset(); // 0x000000018B8972AC-0x000000018B8973B0
		private void OnEnable(); // 0x0000000184D83220-0x0000000184D83230
		public bool IsSRPBatcherSupported(); // 0x00000001812081B0-0x0000000181208610
		public void ForceUpdateFadeOutCamera(); // 0x000000018B896F7C-0x000000018B897000
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup(); // 0x00000001837E27D0-0x00000001837E2870
		private void RefreshGlobalShaderProperties(); // 0x00000001837E2DC0-0x00000001837E2EA0
		public void ResetInternalData(); // 0x000000018B897138-0x000000018B8972AC
		public ParticleSystem NewVolumetricDustParticles(); // 0x000000018B897000-0x000000018B897138
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion); // 0x0000000184D83230-0x0000000184D83240
		private static Config LoadAssetInternal(string assetName); // 0x000000018496FF50-0x000000018496FF90
		private static Config GetInstance(bool assertIfNotFound); // 0x000000018496FD70-0x000000018496FF50
	}

	public static class Consts // TypeDefIndex: 62520
	{
		// Fields
		public const string PluginFolder = "Plugins/VolumetricLightBeam"; // Metadata: 0x02351B96
	
		// Nested types
		public static class Help // TypeDefIndex: 62514
		{
			// Fields
			private const string UrlBase = "http://saladgamer.com/vlb-doc/"; // Metadata: 0x02351BB2
			private const string UrlSuffix = "/"; // Metadata: 0x02351BD1
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/"; // Metadata: 0x02351BD3
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/"; // Metadata: 0x02351C01
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/"; // Metadata: 0x02351C33
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/"; // Metadata: 0x02351C6F
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/"; // Metadata: 0x02351CAC
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/"; // Metadata: 0x02351CDC
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/"; // Metadata: 0x02351D0E
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/"; // Metadata: 0x02351D41
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/"; // Metadata: 0x02351D72
		}
	
		public static class Internal // TypeDefIndex: 62515
		{
			// Properties
			public static HideFlags ProceduralObjectsHideFlags { get; } // 0x00000001811EC580-0x00000001811EC590 
		}
	
		public static class Beam // TypeDefIndex: 62516
		{
			// Fields
			public const ColorMode ColorModeDefault = ColorMode.Flat; // Metadata: 0x02351D98
			public const float MultiplierDefault = 1f; // Metadata: 0x02351D99
			public const float MultiplierMin = 0f; // Metadata: 0x02351D9D
			public const float IntensityDefault = 1f; // Metadata: 0x02351DA1
			public const float IntensityMin = 0f; // Metadata: 0x02351DA5
			public const float HDRPExposureWeightDefault = 0f; // Metadata: 0x02351DA9
			public const float HDRPExposureWeightMin = 0f; // Metadata: 0x02351DAD
			public const float HDRPExposureWeightMax = 1f; // Metadata: 0x02351DB1
			public const float SpotAngleDefault = 35f; // Metadata: 0x02351DB5
			public const float SpotAngleMin = 0.1f; // Metadata: 0x02351DB9
			public const float SpotAngleMax = 179.9f; // Metadata: 0x02351DBD
			public const float ConeRadiusStart = 0f; // Metadata: 0x02351DC1
			public const MeshType GeomMeshType = MeshType.Shared; // Metadata: 0x02351DC5
			public const int GeomSidesDefault = 18; // Metadata: 0x02351DC6
			public const int GeomSidesMin = 3; // Metadata: 0x02351DC7
			public const int GeomSidesMax = 256; // Metadata: 0x02351DC8
			public const int GeomSegmentsDefault = 5; // Metadata: 0x02351DCA
			public const int GeomSegmentsMin = 0; // Metadata: 0x02351DCB
			public const int GeomSegmentsMax = 64; // Metadata: 0x02351DCC
			public const bool GeomCap = false; // Metadata: 0x02351DCE
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic; // Metadata: 0x02351DCF
			public const float AttenuationCustomBlendingDefault = 0.5f; // Metadata: 0x02351DD0
			public const float AttenuationCustomBlendingMin = 0f; // Metadata: 0x02351DD4
			public const float AttenuationCustomBlendingMax = 1f; // Metadata: 0x02351DD8
			public const float FallOffStart = 0f; // Metadata: 0x02351DDC
			public const float FallOffEnd = 3f; // Metadata: 0x02351DE0
			public const float FallOffDistancesMinThreshold = 0.01f; // Metadata: 0x02351DE4
			public const float DepthBlendDistance = 2f; // Metadata: 0x02351DE8
			public const float CameraClippingDistance = 0.5f; // Metadata: 0x02351DEC
			public const float FresnelPowMaxValue = 10f; // Metadata: 0x02351DF0
			public const float FresnelPow = 8f; // Metadata: 0x02351DF4
			public const float GlareFrontalDefault = 0f; // Metadata: 0x02351DF8
			public const float GlareBehindDefault = 0f; // Metadata: 0x02351DFC
			public const float GlareMin = 0f; // Metadata: 0x02351E00
			public const float GlareMax = 1f; // Metadata: 0x02351E04
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled; // Metadata: 0x02351E08
			public const float NoiseIntensityMin = 0f; // Metadata: 0x02351E09
			public const float NoiseIntensityMax = 1f; // Metadata: 0x02351E0D
			public const float NoiseIntensityDefault = 0.5f; // Metadata: 0x02351E11
			public const float NoiseScaleMin = 0.01f; // Metadata: 0x02351E15
			public const float NoiseScaleMax = 2f; // Metadata: 0x02351E19
			public static readonly Vector3 NoiseScalesDefault; // 0x00
			public const float NoiseContrastDefault = 0f; // Metadata: 0x02351E1D
			public const float NoiseContrastMin = -5f; // Metadata: 0x02351E21
			public const float NoiseContrastMax = 5f; // Metadata: 0x02351E25
			public const float NoiseScaleDefault = 0.5f; // Metadata: 0x02351E29
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive; // Metadata: 0x02351E2D
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.High; // Metadata: 0x02351E2E
			public const float FadeOutBeginDefault = 256f; // Metadata: 0x02351E2F
			public const float FadeOutEndDefault = 200f; // Metadata: 0x02351E33
			public const float FadeOutBeginSecondDefault = 0f; // Metadata: 0x02351E37
			public const float FadeOutEndSecondDefault = 0f; // Metadata: 0x02351E3B
			public const Dimensions DimensionsDefault = Dimensions.Dim3D; // Metadata: 0x02351E3F
			public const Transform ClippingPlaneTransformDefault = null; // Metadata: 0x00000000
			public static readonly UnityEngine.Color FlatColor; // 0x0C
			public static readonly Vector3 NoiseVelocityDefault; // 0x1C
			public static readonly Vector2 TiltDefault; // 0x28
			public static readonly Vector3 SkewingLocalForwardDirectionDefault; // 0x30
	
			// Constructors
			static Beam(); // 0x0000000184B39200-0x0000000184B392E0
		}
	
		public static class DustParticles // TypeDefIndex: 62517
		{
			// Fields
			public const float AlphaDefault = 0.5f; // Metadata: 0x02351E40
			public const float SizeDefault = 0.01f; // Metadata: 0x02351E44
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random; // Metadata: 0x02351E48
			public const float DensityDefault = 5f; // Metadata: 0x02351E49
			public const float DensityMin = 0f; // Metadata: 0x02351E4D
			public const float DensityMax = 1000f; // Metadata: 0x02351E51
			public const bool CullingEnabledDefault = false; // Metadata: 0x02351E55
			public const float CullingMaxDistanceDefault = 10f; // Metadata: 0x02351E56
			public const float CullingMaxDistanceMin = 1f; // Metadata: 0x02351E5A
			public static readonly Vector3 VelocityDefault; // 0x00
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault; // 0x0C
	
			// Constructors
			static DustParticles(); // 0x000000018B897458-0x000000018B8974C0
		}
	
		public static class DynOcclusion // TypeDefIndex: 62518
		{
			// Fields
			public const float FadeDistanceToSurfaceDefault = 0.25f; // Metadata: 0x02351E5E
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames; // Metadata: 0x02351E62
			public const int WaitFramesCountDefault = 3; // Metadata: 0x02351E63
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D; // Metadata: 0x02351E64
			public const bool RaycastingConsiderTriggersDefault = false; // Metadata: 0x02351E65
			public const float RaycastingMinOccluderAreaDefault = 0f; // Metadata: 0x02351E66
			public const float RaycastingMinSurfaceRatioDefault = 0.5f; // Metadata: 0x02351E6A
			public const float RaycastingMinSurfaceRatioMin = 50f; // Metadata: 0x02351E6E
			public const float RaycastingMinSurfaceRatioMax = 100f; // Metadata: 0x02351E72
			public const float RaycastingMaxSurfaceDotDefault = 0.25f; // Metadata: 0x02351E76
			public const float RaycastingMaxSurfaceAngleMin = 45f; // Metadata: 0x02351E7A
			public const float RaycastingMaxSurfaceAngleMax = 90f; // Metadata: 0x02351E7E
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface; // Metadata: 0x02351E82
			public const float RaycastingPlaneOffsetDefault = 0.1f; // Metadata: 0x02351E83
			public const int DepthBufferDepthMapResolutionDefault = 32; // Metadata: 0x02351E87
			public const bool DepthBufferOcclusionCullingDefault = true; // Metadata: 0x02351E88
			public static readonly LayerMask LayerMaskDefault; // 0x00
	
			// Constructors
			static DynOcclusion(); // 0x000000018B8974C0-0x000000018B8974FC
		}
	
		public static class Config // TypeDefIndex: 62519
		{
			// Fields
			public const bool GeometryOverrideLayerDefault = true; // Metadata: 0x02351E89
			public const int GeometryLayerIDDefault = 1; // Metadata: 0x02351E8A
			public const string GeometryTagDefault = "Untagged"; // Metadata: 0x02351E8B
			public const string FadeOutCameraTagDefault = "MainCamera"; // Metadata: 0x02351E94
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent; // Metadata: 0x02351E9F
			public const VLB.RenderPipeline GeometryRenderPipelineDefault = VLB.RenderPipeline.HGRP; // Metadata: 0x02351EA1
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass; // Metadata: 0x02351EA2
			public const int Noise3DSizeDefault = 64; // Metadata: 0x02351EA3
			public const int SharedMeshSides = 24; // Metadata: 0x02351EA5
			public const int SharedMeshSegments = 5; // Metadata: 0x02351EA6
			public const float DitheringFactor = 0f; // Metadata: 0x02351EA7
			public const bool UseLightColorTemperatureDefault = true; // Metadata: 0x02351EAB
			public const bool FeatureEnabledDefault = true; // Metadata: 0x02351EAC
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly; // Metadata: 0x02351EAD
		}
	}

	public static class DummyMaterial // TypeDefIndex: 62521
	{
	}

	public enum FeatureEnabledColorGradient // TypeDefIndex: 62522
	{
		Off = 0,
		HighOnly = 1,
		HighAndLow = 2
	}

	public enum ColorMode // TypeDefIndex: 62523
	{
		Flat = 0,
		Gradient = 1
	}

	public enum AttenuationEquation // TypeDefIndex: 62524
	{
		Linear = 0,
		Quadratic = 1,
		Blend = 2
	}

	public enum BlendingMode // TypeDefIndex: 62525
	{
		Additive = 0,
		SoftAdditive = 1,
		TraditionalTransparency = 2
	}

	public enum ShaderAccuracy // TypeDefIndex: 62526
	{
		Fast = 0,
		High = 1
	}

	public enum NoiseMode // TypeDefIndex: 62527
	{
		Disabled = 0,
		WorldSpace = 1,
		LocalSpace = 2
	}

	public enum MeshType // TypeDefIndex: 62528
	{
		Shared = 0,
		Custom = 1
	}

	public enum RenderPipeline // TypeDefIndex: 62529
	{
		HGRP = 0,
		BuiltIn = 1,
		URP = 2,
		HDRP = 3
	}

	public enum RenderingMode // TypeDefIndex: 62530
	{
		MultiPass = 0,
		SinglePass = 1,
		GPUInstancing = 2,
		SRPBatcher = 3
	}

	public enum RenderQueue // TypeDefIndex: 62531
	{
		Custom = 0,
		Background = 1000,
		Geometry = 2000,
		AlphaTest = 2450,
		GeometryLast = 2500,
		Transparent = 3000,
		Overlay = 4000
	}

	public enum Dimensions // TypeDefIndex: 62532
	{
		Dim3D = 0,
		Dim2D = 1
	}

	public enum PlaneAlignment // TypeDefIndex: 62533
	{
		Surface = 0,
		Beam = 1
	}

	[Flags]
	public enum DynamicOcclusionUpdateRate // TypeDefIndex: 62534
	{
		Never = 1,
		OnEnable = 2,
		OnBeamMove = 4,
		EveryXFrames = 8,
		OnBeamMoveAndEveryXFrames = 12
	}

	public enum ParticlesDirection // TypeDefIndex: 62535
	{
		Random = 0,
		LocalSpace = 1,
		WorldSpace = 2
	}

	public sealed class HighlightNullAttribute : PropertyAttribute // TypeDefIndex: 62536
	{
		// Constructors
		public HighlightNullAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class MaterialManager // TypeDefIndex: 62546
	{
		// Fields
		public const int staticPropertiesCount = 432; // Metadata: 0x02351EE1
		public static MaterialPropertyBlock materialPropertyBlock; // 0x00
		private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor; // 0x08
		private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor; // 0x10
		private static readonly bool[] BlendingMode_AlphaAsBlack; // 0x18
		private static readonly Hashtable ms_MaterialsGroup; // 0x20
	
		// Nested types
		public enum BlendingMode // TypeDefIndex: 62537
		{
			Additive = 0,
			SoftAdditive = 1,
			TraditionalTransparency = 2,
			Count = 3
		}
	
		public enum ColorGradient // TypeDefIndex: 62538
		{
			Off = 0,
			MatrixLow = 1,
			MatrixHigh = 2,
			Count = 3
		}
	
		public enum DepthBlend // TypeDefIndex: 62539
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum DynamicOcclusion // TypeDefIndex: 62540
		{
			Off = 0,
			ClippingPlane = 1,
			DepthTexture = 2,
			Count = 3
		}
	
		public enum MeshSkewing // TypeDefIndex: 62541
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum Noise3D // TypeDefIndex: 62542
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum ShaderAccuracy // TypeDefIndex: 62543
		{
			Fast = 0,
			High = 1,
			Count = 2
		}
	
		public struct StaticProperties // TypeDefIndex: 62544
		{
			// Fields
			public bool useFog; // 0x00
			public BlendingMode blendingMode; // 0x04
			public Noise3D noise3D; // 0x08
			public DepthBlend depthBlend; // 0x0C
			public ColorGradient colorGradient; // 0x10
			public DynamicOcclusion dynamicOcclusion; // 0x14
			public MeshSkewing meshSkewing; // 0x18
			public ShaderAccuracy shaderAccuracy; // 0x1C
	
			// Properties
			private int blendingModeID { get; } // 0x0000000184D88B20-0x0000000184D88B30 
			private int noise3DID { get; } // 0x000000018B8988F4-0x000000018B898928 
			private int depthBlendID { get; } // 0x000000018B8987B8-0x000000018B8987EC 
			private int colorGradientID { get; } // 0x000000018B898784-0x000000018B8987B8 
			private int dynamicOcclusionID { get; } // 0x000000018B8987EC-0x000000018B898820 
			private int meshSkewingID { get; } // 0x000000018B8988C0-0x000000018B8988F4 
			private int shaderAccuracyID { get; } // 0x000000018B898928-0x000000018B89895C 
			public int materialID { get; } // 0x000000018B898820-0x000000018B8988C0 
	
			// Methods
			public void ApplyToMaterial(Material mat); // 0x000000018B898460-0x000000018B898784
		}
	
		private class MaterialsGroup // TypeDefIndex: 62545
		{
			// Fields
			public readonly Material[] materials; // 0x10
	
			// Constructors
			public MaterialsGroup(); // 0x000000018B897B74-0x000000018B897BBC
		}
	
		// Constructors
		static MaterialManager(); // 0x000000018B897964-0x000000018B897B74
	
		// Methods
		public static Material NewMaterialTransient(bool gpuInstanced); // 0x000000018B8978A4-0x000000018B897964
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced); // 0x000000018B8977E8-0x000000018B8978A4
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps); // 0x000000018B8975F4-0x000000018B8977E8
	}

	public static class MaterialModifier // TypeDefIndex: 62549
	{
		// Nested types
		public delegate void Callback(Interface owner); // TypeDefIndex: 62547; 0x0000000182B46B90-0x0000000182B46BA0
	
		public interface Interface // TypeDefIndex: 62548
		{
			// Methods
			void SetMaterialProp(int nameID, float value);
			void SetMaterialProp(int nameID, Vector4 value);
			void SetMaterialProp(int nameID, UnityEngine.Color value);
			void SetMaterialProp(int nameID, Matrix4x4 value);
			void SetMaterialProp(int nameID, Texture value);
		}
	}

	[Serializable]
	public struct MinMaxRangeFloat // TypeDefIndex: 62550
	{
		// Fields
		[SerializeField]
		private float m_MinValue; // 0x00
		[SerializeField]
		private float m_MaxValue; // 0x04
	
		// Properties
		public float minValue { get; } // 0x0000000184D871D0-0x0000000184D871E0 
		public float maxValue { get; } // 0x0000000184D9C560-0x0000000184D9C570 
		public float randomValue { get; } // 0x000000018B897BD0-0x000000018B897BE4 
		public Vector2 asVector2 { get; } // 0x0000000184D889F0-0x0000000184D88A10 
	
		// Constructors
		public MinMaxRangeFloat(float min, float max); // 0x0000000184D87A10-0x0000000184D87A20
	
		// Methods
		public float GetLerpedValue(float lerp01); // 0x000000018B897BBC-0x000000018B897BD0
	}

	public class MinMaxRangeAttribute : Attribute // TypeDefIndex: 62551
	{
		// Fields
		[CompilerGenerated]
		private readonly float _minValue_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly float _maxValue_k__BackingField; // 0x14
	
		// Properties
		public float minValue { [CompilerGenerated] get; } // 0x0000000184D85F70-0x0000000184D85F80 
		public float maxValue { [CompilerGenerated] get; } // 0x0000000184D88D40-0x0000000184D88D50 
	
		// Constructors
		public MinMaxRangeAttribute(float min, float max); // 0x0000000184D8D120-0x0000000184D8D130
	}

	public class PlatformHelper // TypeDefIndex: 62552
	{
		// Constructors
		public PlatformHelper(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static string GetCurrentPlatformSuffix(); // 0x000000018496FF90-0x000000018496FFB0
		private static string GetPlatformSuffix(RuntimePlatform platform); // 0x000000018496FFB0-0x0000000184970000
	}

	public class PolygonHelper : MonoBehaviour // TypeDefIndex: 62554
	{
		// Nested types
		public struct Plane2D // TypeDefIndex: 62553
		{
			// Fields
			public Vector2 normal; // 0x00
			public float distance; // 0x08
	
			// Methods
			public float Distance(Vector2 point); // 0x0000000184DBF500-0x0000000184DBF530
			public Vector2 ClosestPoint(Vector2 pt); // 0x000000018B897D14-0x000000018B897D58
			public Vector2 Intersect(Vector2 p1, Vector2 p2); // 0x000000018B89807C-0x000000018B898148
			public bool GetSide(Vector2 point); // 0x000000018B898060-0x000000018B89807C
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2); // 0x000000018B897FA0-0x000000018B898060
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1); // 0x000000018B897F2C-0x000000018B897FA0
			public void Flip(); // 0x000000018B897F04-0x000000018B897F2C
			public Vector2[] CutConvex(Vector2[] poly); // 0x000000018B897D58-0x000000018B897F04
			public override string ToString(); // 0x000000018B898148-0x000000018B898208
		}
	
		// Constructors
		public PolygonHelper(); // 0x0000000185393520-0x0000000185393538
	}

	public static class ShaderKeywords // TypeDefIndex: 62555
	{
		// Fields
		public const string UseFog = "VLB_USE_FOG"; // Metadata: 0x02351EFB
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK"; // Metadata: 0x02351F07
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW"; // Metadata: 0x02351F1A
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH"; // Metadata: 0x02351F38
		public const string DepthBlend = "VLB_DEPTH_BLEND"; // Metadata: 0x02351F57
		public const string Noise3D = "VLB_NOISE_3D"; // Metadata: 0x02351F67
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE"; // Metadata: 0x02351F74
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE"; // Metadata: 0x02351F91
		public const string MeshSkewing = "VLB_MESH_SKEWING"; // Metadata: 0x02351FAD
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH"; // Metadata: 0x02351FBE
	}

	public static class ShaderProperties // TypeDefIndex: 62556
	{
		// Fields
		public static readonly int ConeParams0; // 0x00
		public static readonly int ConeParams1; // 0x04
		public static readonly int TiltVectorX; // 0x08
		public static readonly int TiltVectorY; // 0x0C
		public static readonly int DistanceFadeStart; // 0x10
		public static readonly int DistanceFadeEnd; // 0x14
		public static readonly int DistanceFadeStartSecond; // 0x18
		public static readonly int DistanceFadeEndSecond; // 0x1C
		public static readonly int NoiseContrast; // 0x20
		public static readonly int NoiseVelocity; // 0x24
		public static readonly int NoiseScale; // 0x28
		public static readonly int DepthBlendCapOff; // 0x2C
		public static readonly int BlendMode; // 0x30
		public static readonly int FogIntensity; // 0x34
		public static readonly int ClippingPlaneTransition; // 0x38
		public static readonly int UseClippingPlane; // 0x3C
		public static readonly int FadeOutFactor; // 0x40
		public static readonly int ConeSlopeCosSin; // 0x44
		public static readonly int ConeRadius; // 0x48
		public static readonly int ConeGeomProps; // 0x4C
		public static readonly int ColorFlat; // 0x50
		public static readonly int AlphaInside; // 0x54
		public static readonly int AlphaOutside; // 0x58
		public static readonly int HDRPExposureWeight; // 0x5C
		public static readonly int AttenuationLerpLinearQuad; // 0x60
		public static readonly int DistanceFallOff; // 0x64
		public static readonly int DistanceCamClipping; // 0x68
		public static readonly int FresnelPow; // 0x6C
		public static readonly int GlareBehind; // 0x70
		public static readonly int GlareFrontal; // 0x74
		public static readonly int DrawCap; // 0x78
		public static readonly int DepthBlendDistance; // 0x7C
		public static readonly int NoiseVelocityAndScale; // 0x80
		public static readonly int NoiseParam; // 0x84
		public static readonly int CameraParams; // 0x88
		public static readonly int ColorGradientMatrix; // 0x8C
		public static readonly int LocalToWorldMatrix; // 0x90
		public static readonly int WorldToLocalMatrix; // 0x94
		public static readonly int BlendSrcFactor; // 0x98
		public static readonly int BlendDstFactor; // 0x9C
		public static readonly int DynamicOcclusionClippingPlaneWS; // 0xA0
		public static readonly int DynamicOcclusionClippingPlaneProps; // 0xA4
		public static readonly int DynamicOcclusionDepthTexture; // 0xA8
		public static readonly int DynamicOcclusionDepthProps; // 0xAC
		public static readonly int LocalForwardDirection; // 0xB0
		public static readonly int TiltVector; // 0xB4
		public static readonly int AdditionalClippingPlaneWS; // 0xB8
		public static readonly int ParticlesTintColor; // 0xBC
		public static readonly int GlobalUsesReversedZBuffer; // 0xC0
		public static readonly int GlobalNoiseTex3D; // 0xC4
		public static readonly int GlobalNoiseCustomTime; // 0xC8
		public static readonly int GlobalDitheringFactor; // 0xCC
		public static readonly int GlobalDitheringNoiseTex; // 0xD0
	
		// Constructors
		static ShaderProperties(); // 0x0000000184654190-0x0000000184654AE0
	}

	public static class SpotLightHelper // TypeDefIndex: 62557
	{
		// Methods
		public static void GetCullingDistance(Light light, ref float cullingDistance, ref float falloffDistance); // 0x000000018B8982A0-0x000000018B898328
		public static float GetIntensity(Light light); // 0x000000018B898390-0x000000018B8983F8
		public static float GetSpotAngle(Light light); // 0x000000018B8983F8-0x000000018B898460
		public static float GetFallOffEnd(Light light); // 0x000000018B898328-0x000000018B898390
	}

	public static class SRPHelper // TypeDefIndex: 62559
	{
		// Fields
		private static RenderPipeline m_RenderPipelineCached; // 0x00
	
		// Properties
		public static RenderPipeline renderPipelineType { get; } // 0x00000001837E28E0-0x00000001837E2980 
	
		// Nested types
		public enum RenderPipeline // TypeDefIndex: 62558
		{
			HGRP = 0,
			Undefined = 1,
			BuiltIn = 2,
			URP = 3,
			LWRP = 4,
			HDRP = 5
		}
	
		// Constructors
		static SRPHelper(); // 0x0000000184D79C10-0x0000000184D79C50
	
		// Methods
		private static RenderPipeline ComputeRenderPipeline(); // 0x00000001811EC580-0x00000001811EC590
		public static bool IsUsingCustomRenderPipeline(); // 0x0000000182FFF600-0x0000000182FFF610
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb); // 0x000000018B898208-0x000000018B898254
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb); // 0x000000018B898254-0x000000018B8982A0
	}

	public static class TransformUtils // TypeDefIndex: 62561
	{
		// Nested types
		public struct Packed // TypeDefIndex: 62560
		{
			// Fields
			public Vector3 position; // 0x00
			public Quaternion rotation; // 0x0C
			public Vector3 lossyScale; // 0x1C
	
			// Methods
			public bool IsSame(Transform transf); // 0x000000018B897BE4-0x000000018B897D14
		}
	
		// Extension methods
		public static Packed GetWorldPacked(this Transform self); // 0x000000018B89895C-0x000000018B8989E8
	}

	public static class Utils // TypeDefIndex: 62563
	{
		// Fields
		private const float kEpsilon = 1E-05f; // Metadata: 0x02351FEE
		private const int kFloatPackingHighMinShaderLevel = 35; // Metadata: 0x02351FF2
		private static FloatPackingPrecision ms_FloatPackingPrecision; // 0x00
	
		// Nested types
		public enum FloatPackingPrecision // TypeDefIndex: 62562
		{
			Undef = 0,
			Low = 8,
			High = 64
		}
	
		// Methods
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle); // 0x0000000184DBF550-0x0000000184DBF590
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd); // 0x0000000184DBF590-0x0000000184DBF5C0
		public static void Swap<T>(ref ref T a, ref ref T b);
		public static string GetPath(Transform current); // 0x000000018B898D3C-0x000000018B898E00
		public static T NewWithComponent<T>(string name)
			where T : Component;
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt); // 0x000000018B898FF4-0x000000018B899068
		public static bool IsAlmostZero(float f); // 0x000000018B898ED8-0x000000018B898EF0
		public static void SetShaderKeywordEnabled(string name, bool enabled); // 0x000000018B8991D0-0x000000018B8991F4
		private static Vector4 Vector4_Floor(Vector4 vec); // 0x0000000184DAFA70-0x0000000184DAFAD0
		public static FloatPackingPrecision GetFloatPackingPrecision(); // 0x000000018B898C20-0x000000018B898C90
		public static void MarkCurrentSceneDirty(); // 0x00000001841E1670-0x00000001841E1680
		public static void MarkObjectDirty(UnityEngine.Object obj); // 0x00000001841E1670-0x00000001841E1680
	
		// Extension methods
		public static T GetOrAddComponent<T>(this GameObject self)
			where T : Component;
		public static T GetOrAddComponent<T>(this MonoBehaviour self)
			where T : Component;
		public static void ForeachComponentsOnlyInChildren<T>(this GameObject self, Action<T> lambda, bool includeInactive = false /* Metadata: 0x02351FDD */)
			where T : Component;
		public static bool HasFlag(this Enum mask, Enum flags); // 0x000000018B898E5C-0x000000018B898ED8
		public static Vector2 xy(this Vector3 aVector); // 0x0000000184D889F0-0x0000000184D88A10
		public static Vector2 xz(this Vector3 aVector); // 0x0000000184D88A40-0x0000000184D88A60
		public static Vector2 yz(this Vector3 aVector); // 0x0000000184D8B880-0x0000000184D8B8A0
		public static Vector2 yx(this Vector3 aVector); // 0x0000000184DB4770-0x0000000184DB4790
		public static Vector2 zx(this Vector3 aVector); // 0x0000000184DB5A80-0x0000000184DB5AA0
		public static Vector2 zy(this Vector3 aVector); // 0x0000000184DB5BE0-0x0000000184DB5C00
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f /* Metadata: 0x02351FDE */); // 0x0000000186935188-0x000000018693519C
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f /* Metadata: 0x02351FE2 */); // 0x000000018B8989E8-0x000000018B898A1C
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f /* Metadata: 0x02351FE6 */); // 0x000000018B898A1C-0x000000018B898A80
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f /* Metadata: 0x02351FEA */); // 0x000000018B898A80-0x000000018B898AD4
		public static Vector4 AsVector4(this Vector3 vec3, float w); // 0x0000000184DBF530-0x0000000184DBF550
		public static float GetVolumeCubic(this Bounds self); // 0x000000018B898E00-0x000000018B898E5C
		public static float GetMaxArea2D(this Bounds self); // 0x000000018B898C90-0x000000018B898D3C
		public static UnityEngine.Color Opaque(this UnityEngine.Color self); // 0x0000000184DBF5C0-0x0000000184DBF5E0
		public static UnityEngine.Color ComputeComplementaryColor(this UnityEngine.Color self, bool blackAndWhite); // 0x000000018B898B7C-0x000000018B898C20
		public static Plane TranslateCustom(this Plane plane, Vector3 translation); // 0x000000018B8991F4-0x000000018B899288
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point); // 0x000000018B898AD4-0x000000018B898B7C
		public static bool IsValid(this Plane plane); // 0x000000018B898EF0-0x000000018B898F20
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled); // 0x000000018690914C-0x0000000186909180
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision); // 0x000000018B89912C-0x000000018B8991D0
		public static UnityEngine.Color[] SampleInArray(this Gradient self, int samplesCount); // 0x000000018B899068-0x000000018B89912C
		public static float PackToFloat(this UnityEngine.Color color, int floatPackingPrecision); // 0x000000018B898F20-0x000000018B898FF4
	}

	public static class Version // TypeDefIndex: 62564
	{
		// Fields
		public const int Current = 1991; // Metadata: 0x02351FF7
	}

	[AddComponentMenu("Rendering/\u4F4E\u914D\u4F53\u79EF\u5149 Volumetric Light Beam")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 62566
	{
		// Fields
		public PlatformLayers platformLayers; // 0x18
		public const string ClassName = "VolumetricLightBeam"; // Metadata: 0x02351FF9
		public bool colorFromLight; // 0x1C
		public ColorMode colorMode; // 0x20
		[ColorUsage(false, true)]
		[FormerlySerializedAs("colorValue")]
		public UnityEngine.Color color; // 0x24
		public Gradient colorGradient; // 0x38
		public bool intensityFromLight; // 0x40
		public bool intensityModeAdvanced; // 0x41
		[FormerlySerializedAs("alphaInside")]
		[Min(0f)]
		public float intensityInside; // 0x44
		[FormerlySerializedAs("alphaOutside")]
		[FormerlySerializedAs("alpha")]
		[Min(0f)]
		public float intensityOutside; // 0x48
		[Min(0f)]
		public float intensityMultiplier; // 0x4C
		[Range(0f, 1f)]
		public float hdrpExposureWeight; // 0x50
		public BlendingMode blendingMode; // 0x54
		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight; // 0x58
		[Range(0.1f, 179.9f)]
		public float spotAngle; // 0x5C
		[Min(0f)]
		public float spotAngleMultiplier; // 0x60
		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart; // 0x64
		public ShaderAccuracy shaderAccuracy; // 0x68
		public MeshType geomMeshType; // 0x6C
		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides; // 0x70
		public int geomCustomSegments; // 0x74
		public Vector3 skewingLocalForwardDirection; // 0x78
		public bool useAdditionalClippingPlane; // 0x84
		public Transform clippingPlaneTransform; // 0x88
		public Vector3 clippingPlanePosition; // 0x90
		public Quaternion clippingPlaneRotation; // 0x9C
		public float clippingPlaneTransition; // 0xAC
		public bool geomCap; // 0xB0
		public AttenuationEquation attenuationEquation; // 0xB4
		[Range(0f, 1f)]
		public float attenuationCustomBlending; // 0xB8
		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart; // 0xBC
		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd; // 0xC0
		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight; // 0xC4
		private Light m_CachedLightSpot; // 0xC8
		public float fallOffCap; // 0xD0
		[Min(0f)]
		public float fallOffEndMultiplier; // 0xD4
		public bool depthBlendCapOff; // 0xD8
		public float depthBlendDistance; // 0xDC
		public float cameraClippingDistance; // 0xE0
		[Range(0f, 1f)]
		public float glareFrontal; // 0xE4
		[Range(0f, 1f)]
		public float glareBehind; // 0xE8
		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow; // 0xEC
		public NoiseMode noiseMode; // 0xF0
		[Range(0f, 1f)]
		public float noiseIntensity; // 0xF4
		public bool noiseScaleUseGlobal; // 0xF8
		[UnclampedRange(-5f, 5f)]
		public float noiseContrast; // 0xFC
		public bool noiseScaleUseSeparateAxis; // 0x100
		public Vector3 noiseScalesLocal; // 0x104
		[Range(0.01f, 2f)]
		public float noiseScaleLocal; // 0x110
		public bool noiseVelocityUseGlobal; // 0x114
		public Vector3 noiseVelocityLocal; // 0x118
		public bool fadeOutFromLight; // 0x124
		public float fadeOutBeginSecond; // 0x128
		public float fadeOutEndSecond; // 0x12C
		public bool useFog; // 0x130
		public float fogIntensity; // 0x134
		public Dimensions dimensions; // 0x138
		public Vector2 tiltFactor; // 0x13C
		[SerializeField]
		private int pluginVersion; // 0x144
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime; // 0x148
		[SerializeField]
		private int _SortingLayerID; // 0x14C
		[SerializeField]
		private int _SortingOrder; // 0x150
		[FormerlySerializedAs("fadeOutBegin")]
		[SerializeField]
		private float _FadeOutBegin; // 0x154
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd; // 0x158
		[CompilerGenerated]
		private uint __INTERNAL_InstancedMaterialGroupID_k__BackingField; // 0x15C
		public BeamGeometry m_BeamGeom; // 0x160
		public bool matIsPersistent; // 0x168
		private Coroutine m_CoPlaytimeUpdate; // 0x170
		private Vector3 m_CachedClippingPlanePosition; // 0x178
		private Quaternion m_CachedClippingPlaneRotation; // 0x184
		private bool m_HasCachedClippingPlanePose; // 0x194
	
		// Properties
		public ColorMode usedColorMode { get; } // 0x000000018B89A810-0x000000018B89A844 
		private bool useColorFromAttachedLightSpot { get; } // 0x000000018B89A660-0x000000018B89A6B8 
		private bool useColorTemperatureFromAttachedLightSpot { get; } // 0x000000018B89A6B8-0x000000018B89A704 
		[Obsolete("Use \'intensityGlobal\' or \'intensityInside\' instead")]
		public float alphaInside { get; set; } // 0x0000000184D86400-0x0000000184D86410 0x0000000184D86480-0x0000000184D86490
		[Obsolete("Use \'intensityGlobal\' or \'intensityOutside\' instead")]
		public float alphaOutside { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184D8D380-0x0000000184D8D390
		public float intensityGlobal { get; set; } // 0x0000000184D8D350-0x0000000184D8D360 0x0000000184DBF620-0x0000000184DBF630
		public bool useIntensityFromAttachedLightSpot { get; } // 0x000000018B89A760-0x000000018B89A7B8 
		public bool useSpotAngleFromAttachedLightSpot { get; } // 0x000000018B89A7B8-0x000000018B89A810 
		public float coneAngle { get; } // 0x000000018B899A90-0x000000018B899AE8 
		public float coneRadiusEnd { get; set; } // 0x000000018B899C50-0x000000018B899CB0 0x000000018B89A844-0x000000018B89A898
		public float coneVolume { get; } // 0x000000018B899CB0-0x000000018B899D00 
		public float coneApexOffsetZ { get; } // 0x000000018B899AE8-0x000000018B899B58 
		public Vector3 coneApexPositionLocal { get; } // 0x000000018B899C20-0x000000018B899C50 
		public Vector3 coneApexPositionGlobal { get; } // 0x000000018B899B58-0x000000018B899C20 
		public int geomSides { get; set; } // 0x000000018B899D4C-0x000000018B899D78 0x000000018B89A8F8-0x000000018B89A958
		public int geomSegments { get; set; } // 0x000000018B899D20-0x000000018B899D4C 0x000000018B89A898-0x000000018B89A8F8
		public Vector3 skewingLocalForwardDirectionNormalized { get; } // 0x000000018B89A518-0x000000018B89A650 
		public bool canHaveMeshSkewing { get; } // 0x0000000182FFF600-0x0000000182FFF610 
		public bool hasMeshSkewing { get; } // 0x000000018B899DCC-0x000000018B899E78 
		public Vector4 additionalClippingPlane { get; } // 0x000000018B899588-0x000000018B899748 
		public float attenuationLerpLinearQuad { get; } // 0x000000018B899748-0x000000018B899770 
		[Obsolete("Use \'fallOffStart\' instead")]
		public float fadeStart { get; set; } // 0x0000000184DA62F0-0x0000000184DA6300 0x0000000184DA6320-0x0000000184DA6330
		[Obsolete("Use \'fallOffEnd\' instead")]
		public float fadeEnd { get; set; } // 0x0000000184D9DF30-0x0000000184D9DF40 0x0000000184D9DFF0-0x0000000184D9E000
		[Obsolete("Use \'fallOffEndFromLight\' instead")]
		public bool fadeEndFromLight { get; set; } // 0x0000000184DA32F0-0x0000000184DA3300 0x0000000184DBF600-0x0000000184DBF610
		public Light lightSpotAttached { get; } // 0x0000000184D8D1D0-0x0000000184D8D1E0 
		public bool useFallOffEndFromAttachedLightSpot { get; } // 0x000000018B89A704-0x000000018B89A760 
		public float maxGeometryDistance { get; } // 0x000000018B89A004-0x000000018B89A034 
		public bool isNoiseEnabled { get; } // 0x000000018B899EA8-0x000000018B899EB4 
		[Obsolete("Use \'noiseMode\' instead")]
		public bool noiseEnabled { get; set; } // 0x000000018B899EA8-0x000000018B899EB4 0x000000018B89A958-0x000000018B89A978
		public float cullingDistance { get; } // 0x000000018B899D00-0x000000018B899D20 
		public float fadeOutBegin { get; set; } // 0x0000000184DBF5F0-0x0000000184DBF600 0x0000000184DBF610-0x0000000184DBF620
		public float fadeOutEnd { get; set; } // 0x0000000184D90480-0x0000000184D90490 0x0000000184D904C0-0x0000000184D904D0
		public bool isFadeOutEnabled { get; } // 0x000000018B899E84-0x000000018B899EA8 
		public bool isTilted { get; } // 0x000000018B899EB4-0x000000018B899F14 
		public int sortingLayerID { get; set; } // 0x0000000184DA7C70-0x0000000184DA7C80 0x000000018B89A978-0x000000018B89A9FC
		public string sortingLayerName { get; set; } // 0x000000018B89A650-0x000000018B89A660 0x000000018B89A9FC-0x000000018B89AA24
		public int sortingOrder { get; set; } // 0x0000000184DA24D0-0x0000000184DA24E0 0x000000018B89AA24-0x000000018B89AAA8
		public bool trackChangesDuringPlaytime { get; set; } // 0x0000000184D8FE60-0x0000000184D8FE70 0x0000000184DBF630-0x0000000184DBF640
		public bool isCurrentlyTrackingChanges { get; } // 0x000000018B899E78-0x000000018B899E84 
		public bool hasGeometry { get; } // 0x000000018B899D78-0x000000018B899DCC 
		public Bounds bounds { get; } // 0x000000018B899994-0x000000018B899A90 
		public int blendingModeAsInt { get; } // 0x000000018B8998E8-0x000000018B899994 
		public Quaternion beamInternalLocalRotation { get; } // 0x000000018B899828-0x000000018B8998AC 
		public Vector3 beamLocalForward { get; } // 0x000000018B8998AC-0x000000018B8998E8 
		public Vector3 beamGlobalForward { get; } // 0x000000018B899770-0x000000018B899828 
		public Vector3 lossyScale { get; } // 0x000000018B899F14-0x000000018B89A004 
		public float raycastDistance { get; } // 0x000000018B89A318-0x000000018B89A3F4 
		public Vector3 raycastGlobalForward { get; } // 0x000000018B89A3F4-0x000000018B89A478 
		public Vector3 raycastGlobalUp { get; } // 0x000000018B89A4C8-0x000000018B89A518 
		public Vector3 raycastGlobalRight { get; } // 0x000000018B89A478-0x000000018B89A4C8 
		public int _INTERNAL_pluginVersion { get; } // 0x0000000184DBD7D0-0x0000000184DBD7E0 
		public uint _INTERNAL_InstancedMaterialGroupID { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D904B0-0x0000000184D904C0 0x0000000184D904E0-0x0000000184D904F0
		public string meshStats { get; } // 0x000000018B89A034-0x000000018B89A1A8 
		public int meshVerticesCount { get; } // 0x000000018B89A26C-0x000000018B89A318 
		public int meshTrianglesCount { get; } // 0x000000018B89A1A8-0x000000018B89A26C 
	
		// Nested types
		public enum AttachedLightType // TypeDefIndex: 62565
		{
			NoLight = 0,
			OtherLight = 1,
			SpotLight = 2
		}
	
		// Constructors
		public VolumetricLightBeam(); // 0x000000018B89937C-0x000000018B899588
	
		// Methods
		public void GetInsideAndOutsideIntensity(out float inside, out float outside); // 0x000000018B899358-0x000000018B89937C
		private Vector3 ComputeRaycastGlobalVector(Vector3 localVec); // 0x000000018B899288-0x000000018B899358
		private void SetFadeOutValue(ref float propToChange, float value); // 0x0000000184DBF5E0-0x0000000184DBF5F0
	}
}
