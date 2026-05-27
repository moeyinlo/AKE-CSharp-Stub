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

// Image 77: VolumetricLightBeam.dll - Assembly: VolumetricLightBeam, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58864-58931
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public static class EditorPrefsStrings // TypeDefIndex: 58865
{
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 58867
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 58868
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 58869
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 58870
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 58871
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 58866
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 58929
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x000000018A293AB0-0x000000018A293B14
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 58930
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018A293B14-0x000000018A293BA8
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 58931
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018A297180-0x000000018A2971E4
		public static bool IsPatched(int id) => default; // 0x000000018A297270-0x000000018A297308
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018A29703C-0x000000018A297108
		public object CreateWrapper(int id) => default; // 0x000000018A297108-0x000000018A297180
		public object InitWrapperArray(int len) => default; // 0x000000018A2971E4-0x000000018A297270
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018A296F98-0x000000018A29703C
	}
}

namespace VLB
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface // TypeDefIndex: 58872
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private VolumetricLightBeam m_Master; // 0x18
		private Matrix4x4 m_ColorGradientMatrix; // 0x20
		private MeshType m_CurrentMeshType; // 0x60
		private MaterialModifier.Callback m_MaterialModifierCallback; // 0x68
		private Coroutine m_CoFadeOut; // 0x70
		[SerializeField]
		public Material m_CustomMaterial; // 0x90
	
		// Properties
		public MeshRenderer meshRenderer { get; private set; } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		public MeshFilter meshFilter { get; private set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public Mesh coneMesh { get; private set; } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000184274DA0-0x0000000184274DB4
		private bool visible { get => default; set {} } // 0x000000018A293454-0x000000018A293474 0x000000018A2934B4-0x000000018A293530
		public int sortingLayerID { get => default; set {} } // 0x000000018A293414-0x000000018A293434 0x000000018A293474-0x000000018A293494
		public int sortingOrder { get => default; set {} } // 0x000000018A293434-0x000000018A293454 0x000000018A293494-0x000000018A2934B4
		public bool _INTERNAL_IsFadeOutCoroutineRunning { get => default; } // 0x0000000188574B70-0x0000000188574B7C 
	
		// Constructors
		public BeamGeometry() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void RestartFadeOutCoroutine() {} // 0x000000018350B670-0x000000018350B680
		public void StopFadeOutCoroutine() {} // 0x000000018350B670-0x000000018350B680
		public void SetMaterialProp(int nameID, float value) {} // 0x000000018A293348-0x000000018A293414
		public void SetMaterialProp(int nameID, Vector4 value) {} // 0x000000018A2930C4-0x000000018A2931A4
		public void SetMaterialProp(int nameID, UnityEngine.Color value) {} // 0x000000018A2931A4-0x000000018A293284
		public void SetMaterialProp(int nameID, Matrix4x4 value) {} // 0x000000018A292FAC-0x000000018A2930C4
		public void SetMaterialProp(int nameID, Texture value) {} // 0x000000018A293284-0x000000018A293348
	}

	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject // TypeDefIndex: 58873
	{
		// Fields
		public const string ClassName = "Config"; // Metadata: 0x01FDC74C
		public const string kAssetName = "VLBConfigOverride"; // Metadata: 0x01FDC753
		public const string kAssetNameExt = ".asset"; // Metadata: 0x01FDC765
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
		public VLB.RenderPipeline renderPipeline { get => default; } // 0x0000000183D4EE00-0x0000000183D4EE10 
		public RenderingMode renderingMode { get => default; } // 0x0000000183D4EC30-0x0000000183D4EC40 
		public RenderingMode actualRenderingMode { get => default; } // 0x000000018A293964-0x000000018A293980 
		public bool useSinglePassShader { get => default; } // 0x000000018A2939F4-0x000000018A293A0C 
		public bool requiresDoubleSidedMesh { get => default; } // 0x000000018A2939F4-0x000000018A293A0C 
		public Shader beamShader { get => default; } // 0x00000001811AC510-0x00000001811AC520 
		public Transform fadeOutCameraTransform { get => default; } // 0x000000018A293980-0x000000018A2939EC 
		public bool isHDRPExposureWeightSupported { get => default; } // 0x000000018A2939EC-0x000000018A2939F4 
		public bool hasRenderPipelineMismatch { get => default; } // 0x00000001839ABF50-0x00000001839ABFC0 
		public static Config Instance { get => default; } // 0x0000000184276CA0-0x0000000184276CAC 
	
		// Constructors
		public Config() {} // 0x0000000183B5B630-0x0000000183B5B750
	
		// Methods
		public void Reset() {} // 0x000000018A293860-0x000000018A293964
		private void OnEnable() {} // 0x0000000183D4B9C0-0x0000000183D4B9D0
		public bool IsSRPBatcherSupported() => default; // 0x000000018115F4C0-0x000000018115F530
		public void ForceUpdateFadeOutCamera() {} // 0x000000018A293530-0x000000018A2935B4
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup() {} // 0x00000001839ABEB0-0x00000001839ABF50
		private void RefreshGlobalShaderProperties() {} // 0x00000001839AC060-0x00000001839AC140
		public void ResetInternalData() {} // 0x000000018A2936EC-0x000000018A293860
		public ParticleSystem NewVolumetricDustParticles() => default; // 0x000000018A2935B4-0x000000018A2936EC
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion) {} // 0x0000000183D4B9D0-0x0000000183D4B9E0
		private static Config LoadAssetInternal(string assetName) => default; // 0x000000018398BB80-0x000000018398BBC0
		private static Config GetInstance(bool assertIfNotFound) => default; // 0x000000018398BA30-0x000000018398BB80
	}

	public static class Consts // TypeDefIndex: 58880
	{
		// Fields
		public const string PluginFolder = "Plugins/VolumetricLightBeam"; // Metadata: 0x01FDC76C
	
		// Nested types
		public static class Help // TypeDefIndex: 58874
		{
			// Fields
			private const string UrlBase = "http://saladgamer.com/vlb-doc/"; // Metadata: 0x01FDC788
			private const string UrlSuffix = "/"; // Metadata: 0x01FDC7A7
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/"; // Metadata: 0x01FDC7A9
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/"; // Metadata: 0x01FDC7D7
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/"; // Metadata: 0x01FDC809
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/"; // Metadata: 0x01FDC845
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/"; // Metadata: 0x01FDC882
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/"; // Metadata: 0x01FDC8B2
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/"; // Metadata: 0x01FDC8E4
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/"; // Metadata: 0x01FDC917
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/"; // Metadata: 0x01FDC948
		}
	
		public static class Internal // TypeDefIndex: 58875
		{
			// Properties
			public static HideFlags ProceduralObjectsHideFlags { get; } // 0x0000000181002730-0x0000000181002740 
		}
	
		public static class Beam // TypeDefIndex: 58876
		{
			// Fields
			public const ColorMode ColorModeDefault = ColorMode.Flat; // Metadata: 0x01FDC96E
			public const float MultiplierDefault = 1f; // Metadata: 0x01FDC96F
			public const float MultiplierMin = 0f; // Metadata: 0x01FDC973
			public const float IntensityDefault = 1f; // Metadata: 0x01FDC977
			public const float IntensityMin = 0f; // Metadata: 0x01FDC97B
			public const float HDRPExposureWeightDefault = 0f; // Metadata: 0x01FDC97F
			public const float HDRPExposureWeightMin = 0f; // Metadata: 0x01FDC983
			public const float HDRPExposureWeightMax = 1f; // Metadata: 0x01FDC987
			public const float SpotAngleDefault = 35f; // Metadata: 0x01FDC98B
			public const float SpotAngleMin = 0.1f; // Metadata: 0x01FDC98F
			public const float SpotAngleMax = 179.9f; // Metadata: 0x01FDC993
			public const float ConeRadiusStart = 0f; // Metadata: 0x01FDC997
			public const MeshType GeomMeshType = MeshType.Shared; // Metadata: 0x01FDC99B
			public const int GeomSidesDefault = 18; // Metadata: 0x01FDC99C
			public const int GeomSidesMin = 3; // Metadata: 0x01FDC99D
			public const int GeomSidesMax = 256; // Metadata: 0x01FDC99E
			public const int GeomSegmentsDefault = 5; // Metadata: 0x01FDC9A0
			public const int GeomSegmentsMin = 0; // Metadata: 0x01FDC9A1
			public const int GeomSegmentsMax = 64; // Metadata: 0x01FDC9A2
			public const bool GeomCap = false; // Metadata: 0x01FDC9A4
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic; // Metadata: 0x01FDC9A5
			public const float AttenuationCustomBlendingDefault = 0.5f; // Metadata: 0x01FDC9A6
			public const float AttenuationCustomBlendingMin = 0f; // Metadata: 0x01FDC9AA
			public const float AttenuationCustomBlendingMax = 1f; // Metadata: 0x01FDC9AE
			public const float FallOffStart = 0f; // Metadata: 0x01FDC9B2
			public const float FallOffEnd = 3f; // Metadata: 0x01FDC9B6
			public const float FallOffDistancesMinThreshold = 0.01f; // Metadata: 0x01FDC9BA
			public const float DepthBlendDistance = 2f; // Metadata: 0x01FDC9BE
			public const float CameraClippingDistance = 0.5f; // Metadata: 0x01FDC9C2
			public const float FresnelPowMaxValue = 10f; // Metadata: 0x01FDC9C6
			public const float FresnelPow = 8f; // Metadata: 0x01FDC9CA
			public const float GlareFrontalDefault = 0f; // Metadata: 0x01FDC9CE
			public const float GlareBehindDefault = 0f; // Metadata: 0x01FDC9D2
			public const float GlareMin = 0f; // Metadata: 0x01FDC9D6
			public const float GlareMax = 1f; // Metadata: 0x01FDC9DA
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled; // Metadata: 0x01FDC9DE
			public const float NoiseIntensityMin = 0f; // Metadata: 0x01FDC9DF
			public const float NoiseIntensityMax = 1f; // Metadata: 0x01FDC9E3
			public const float NoiseIntensityDefault = 0.5f; // Metadata: 0x01FDC9E7
			public const float NoiseScaleMin = 0.01f; // Metadata: 0x01FDC9EB
			public const float NoiseScaleMax = 2f; // Metadata: 0x01FDC9EF
			public static readonly Vector3 NoiseScalesDefault; // 0x00
			public const float NoiseScaleDefault = 0.5f; // Metadata: 0x01FDC9F3
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive; // Metadata: 0x01FDC9F7
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.High; // Metadata: 0x01FDC9F8
			public const float FadeOutBeginDefault = 256f; // Metadata: 0x01FDC9F9
			public const float FadeOutEndDefault = 200f; // Metadata: 0x01FDC9FD
			public const float FadeOutBeginSecondDefault = 0f; // Metadata: 0x01FDCA01
			public const float FadeOutEndSecondDefault = 0f; // Metadata: 0x01FDCA05
			public const Dimensions DimensionsDefault = Dimensions.Dim3D; // Metadata: 0x01FDCA09
			public const Transform ClippingPlaneTransformDefault = null; // Metadata: 0x00000000
			public static readonly UnityEngine.Color FlatColor; // 0x0C
			public static readonly Vector3 NoiseVelocityDefault; // 0x1C
			public static readonly Vector2 TiltDefault; // 0x28
			public static readonly Vector3 SkewingLocalForwardDirectionDefault; // 0x30
	
			// Constructors
			static Beam() {} // 0x0000000183B33110-0x0000000183B331F0
		}
	
		public static class DustParticles // TypeDefIndex: 58877
		{
			// Fields
			public const float AlphaDefault = 0.5f; // Metadata: 0x01FDCA0A
			public const float SizeDefault = 0.01f; // Metadata: 0x01FDCA0E
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random; // Metadata: 0x01FDCA12
			public const float DensityDefault = 5f; // Metadata: 0x01FDCA13
			public const float DensityMin = 0f; // Metadata: 0x01FDCA17
			public const float DensityMax = 1000f; // Metadata: 0x01FDCA1B
			public const bool CullingEnabledDefault = false; // Metadata: 0x01FDCA1F
			public const float CullingMaxDistanceDefault = 10f; // Metadata: 0x01FDCA20
			public const float CullingMaxDistanceMin = 1f; // Metadata: 0x01FDCA24
			public static readonly Vector3 VelocityDefault; // 0x00
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault; // 0x0C
	
			// Constructors
			static DustParticles() {} // 0x000000018A293A0C-0x000000018A293A74
		}
	
		public static class DynOcclusion // TypeDefIndex: 58878
		{
			// Fields
			public const float FadeDistanceToSurfaceDefault = 0.25f; // Metadata: 0x01FDCA28
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames; // Metadata: 0x01FDCA2C
			public const int WaitFramesCountDefault = 3; // Metadata: 0x01FDCA2D
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D; // Metadata: 0x01FDCA2E
			public const bool RaycastingConsiderTriggersDefault = false; // Metadata: 0x01FDCA2F
			public const float RaycastingMinOccluderAreaDefault = 0f; // Metadata: 0x01FDCA30
			public const float RaycastingMinSurfaceRatioDefault = 0.5f; // Metadata: 0x01FDCA34
			public const float RaycastingMinSurfaceRatioMin = 50f; // Metadata: 0x01FDCA38
			public const float RaycastingMinSurfaceRatioMax = 100f; // Metadata: 0x01FDCA3C
			public const float RaycastingMaxSurfaceDotDefault = 0.25f; // Metadata: 0x01FDCA40
			public const float RaycastingMaxSurfaceAngleMin = 45f; // Metadata: 0x01FDCA44
			public const float RaycastingMaxSurfaceAngleMax = 90f; // Metadata: 0x01FDCA48
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface; // Metadata: 0x01FDCA4C
			public const float RaycastingPlaneOffsetDefault = 0.1f; // Metadata: 0x01FDCA4D
			public const int DepthBufferDepthMapResolutionDefault = 32; // Metadata: 0x01FDCA51
			public const bool DepthBufferOcclusionCullingDefault = true; // Metadata: 0x01FDCA52
			public static readonly LayerMask LayerMaskDefault; // 0x00
	
			// Constructors
			static DynOcclusion() {} // 0x000000018A293A74-0x000000018A293AB0
		}
	
		public static class Config // TypeDefIndex: 58879
		{
			// Fields
			public const bool GeometryOverrideLayerDefault = true; // Metadata: 0x01FDCA53
			public const int GeometryLayerIDDefault = 1; // Metadata: 0x01FDCA54
			public const string GeometryTagDefault = "Untagged"; // Metadata: 0x01FDCA55
			public const string FadeOutCameraTagDefault = "MainCamera"; // Metadata: 0x01FDCA5E
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent; // Metadata: 0x01FDCA69
			public const VLB.RenderPipeline GeometryRenderPipelineDefault = VLB.RenderPipeline.HGRP; // Metadata: 0x01FDCA6B
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass; // Metadata: 0x01FDCA6C
			public const int Noise3DSizeDefault = 64; // Metadata: 0x01FDCA6D
			public const int SharedMeshSides = 24; // Metadata: 0x01FDCA6F
			public const int SharedMeshSegments = 5; // Metadata: 0x01FDCA70
			public const float DitheringFactor = 0f; // Metadata: 0x01FDCA71
			public const bool UseLightColorTemperatureDefault = true; // Metadata: 0x01FDCA75
			public const bool FeatureEnabledDefault = true; // Metadata: 0x01FDCA76
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly; // Metadata: 0x01FDCA77
		}
	}

	public static class DummyMaterial // TypeDefIndex: 58881
	{
	}

	public enum FeatureEnabledColorGradient // TypeDefIndex: 58882
	{
		Off = 0,
		HighOnly = 1,
		HighAndLow = 2
	}

	public enum ColorMode // TypeDefIndex: 58883
	{
		Flat = 0,
		Gradient = 1
	}

	public enum AttenuationEquation // TypeDefIndex: 58884
	{
		Linear = 0,
		Quadratic = 1,
		Blend = 2
	}

	public enum BlendingMode // TypeDefIndex: 58885
	{
		Additive = 0,
		SoftAdditive = 1,
		TraditionalTransparency = 2
	}

	public enum ShaderAccuracy // TypeDefIndex: 58886
	{
		Fast = 0,
		High = 1
	}

	public enum NoiseMode // TypeDefIndex: 58887
	{
		Disabled = 0,
		WorldSpace = 1,
		LocalSpace = 2
	}

	public enum MeshType // TypeDefIndex: 58888
	{
		Shared = 0,
		Custom = 1
	}

	public enum RenderPipeline // TypeDefIndex: 58889
	{
		HGRP = 0,
		BuiltIn = 1,
		URP = 2,
		HDRP = 3
	}

	public enum RenderingMode // TypeDefIndex: 58890
	{
		MultiPass = 0,
		SinglePass = 1,
		GPUInstancing = 2,
		SRPBatcher = 3
	}

	public enum RenderQueue // TypeDefIndex: 58891
	{
		Custom = 0,
		Background = 1000,
		Geometry = 2000,
		AlphaTest = 2450,
		GeometryLast = 2500,
		Transparent = 3000,
		Overlay = 4000
	}

	public enum Dimensions // TypeDefIndex: 58892
	{
		Dim3D = 0,
		Dim2D = 1
	}

	public enum PlaneAlignment // TypeDefIndex: 58893
	{
		Surface = 0,
		Beam = 1
	}

	[Flags]
	public enum DynamicOcclusionUpdateRate // TypeDefIndex: 58894
	{
		Never = 1,
		OnEnable = 2,
		OnBeamMove = 4,
		EveryXFrames = 8,
		OnBeamMoveAndEveryXFrames = 12
	}

	public enum ParticlesDirection // TypeDefIndex: 58895
	{
		Random = 0,
		LocalSpace = 1,
		WorldSpace = 2
	}

	public sealed class HighlightNullAttribute : PropertyAttribute // TypeDefIndex: 58896
	{
		// Constructors
		public HighlightNullAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class MaterialManager // TypeDefIndex: 58906
	{
		// Fields
		public const int staticPropertiesCount = 432; // Metadata: 0x01FDCAAB
		public static MaterialPropertyBlock materialPropertyBlock; // 0x00
		private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor; // 0x08
		private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor; // 0x10
		private static readonly bool[] BlendingMode_AlphaAsBlack; // 0x18
		private static readonly Hashtable ms_MaterialsGroup; // 0x20
	
		// Nested types
		public enum BlendingMode // TypeDefIndex: 58897
		{
			Additive = 0,
			SoftAdditive = 1,
			TraditionalTransparency = 2,
			Count = 3
		}
	
		public enum ColorGradient // TypeDefIndex: 58898
		{
			Off = 0,
			MatrixLow = 1,
			MatrixHigh = 2,
			Count = 3
		}
	
		public enum DepthBlend // TypeDefIndex: 58899
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum DynamicOcclusion // TypeDefIndex: 58900
		{
			Off = 0,
			ClippingPlane = 1,
			DepthTexture = 2,
			Count = 3
		}
	
		public enum MeshSkewing // TypeDefIndex: 58901
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum Noise3D // TypeDefIndex: 58902
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum ShaderAccuracy // TypeDefIndex: 58903
		{
			Fast = 0,
			High = 1,
			Count = 2
		}
	
		public struct StaticProperties // TypeDefIndex: 58904
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
			private int blendingModeID { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
			private int noise3DID { get => default; } // 0x000000018A294EA8-0x000000018A294EDC 
			private int depthBlendID { get => default; } // 0x000000018A294D6C-0x000000018A294DA0 
			private int colorGradientID { get => default; } // 0x000000018A294D38-0x000000018A294D6C 
			private int dynamicOcclusionID { get => default; } // 0x000000018A294DA0-0x000000018A294DD4 
			private int meshSkewingID { get => default; } // 0x000000018A294E74-0x000000018A294EA8 
			private int shaderAccuracyID { get => default; } // 0x000000018A294EDC-0x000000018A294F10 
			public int materialID { get => default; } // 0x000000018A294DD4-0x000000018A294E74 
	
			// Methods
			public void ApplyToMaterial(Material mat) {} // 0x000000018A294A14-0x000000018A294D38
		}
	
		private class MaterialsGroup // TypeDefIndex: 58905
		{
			// Fields
			public readonly Material[] materials; // 0x10
	
			// Constructors
			public MaterialsGroup() {} // 0x000000018A294128-0x000000018A294170
		}
	
		// Constructors
		static MaterialManager() {} // 0x000000018A293F18-0x000000018A294128
	
		// Methods
		public static Material NewMaterialTransient(bool gpuInstanced) => default; // 0x000000018A293E58-0x000000018A293F18
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced) => default; // 0x000000018A293D9C-0x000000018A293E58
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps) => default; // 0x000000018A293BA8-0x000000018A293D9C
	}

	public static class MaterialModifier // TypeDefIndex: 58909
	{
		// Nested types
		public delegate void Callback(Interface owner); // TypeDefIndex: 58907; 0x0000000182149960-0x0000000182149970
	
		public interface Interface // TypeDefIndex: 58908
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
	public struct MinMaxRangeFloat // TypeDefIndex: 58910
	{
		// Fields
		[SerializeField]
		private float m_MinValue; // 0x00
		[SerializeField]
		private float m_MaxValue; // 0x04
	
		// Properties
		public float minValue { get => default; } // 0x0000000183D4FA00-0x0000000183D4FA10 
		public float maxValue { get => default; } // 0x0000000183D58BC0-0x0000000183D58BD0 
		public float randomValue { get => default; } // 0x000000018A294184-0x000000018A294198 
		public Vector2 asVector2 { get => default; } // 0x0000000183D51540-0x0000000183D51560 
	
		// Constructors
		public MinMaxRangeFloat(float min, float max) : this() {
			m_MinValue = default;
			m_MaxValue = default;
		} // 0x0000000183D50430-0x0000000183D50440
	
		// Methods
		public float GetLerpedValue(float lerp01) => default; // 0x000000018A294170-0x000000018A294184
	}

	public class MinMaxRangeAttribute : Attribute // TypeDefIndex: 58911
	{
		// Properties
		public float minValue { get; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 
		public float maxValue { get; } // 0x0000000183D51930-0x0000000183D51940 
	
		// Constructors
		public MinMaxRangeAttribute() {} // Dummy constructor
		public MinMaxRangeAttribute(float min, float max) {} // 0x0000000183D5E2F0-0x0000000183D5E300
	}

	public class PlatformHelper // TypeDefIndex: 58912
	{
		// Constructors
		public PlatformHelper() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static string GetCurrentPlatformSuffix() => default; // 0x000000018398BBC0-0x000000018398BBE0
		private static string GetPlatformSuffix(RuntimePlatform platform) => default; // 0x000000018398BBE0-0x000000018398BC30
	}

	public class PolygonHelper : MonoBehaviour // TypeDefIndex: 58914
	{
		// Nested types
		public struct Plane2D // TypeDefIndex: 58913
		{
			// Fields
			public Vector2 normal; // 0x00
			public float distance; // 0x08
	
			// Methods
			public float Distance(Vector2 point) => default; // 0x0000000183D8A050-0x0000000183D8A080
			public Vector2 ClosestPoint(Vector2 pt) => default; // 0x000000018A2942C8-0x000000018A29430C
			public Vector2 Intersect(Vector2 p1, Vector2 p2) => default; // 0x000000018A294630-0x000000018A2946FC
			public bool GetSide(Vector2 point) => default; // 0x000000018A294614-0x000000018A294630
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2) => default; // 0x000000018A294554-0x000000018A294614
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1) => default; // 0x000000018A2944E0-0x000000018A294554
			public void Flip() {} // 0x000000018A2944B8-0x000000018A2944E0
			public Vector2[] CutConvex(Vector2[] poly) => default; // 0x000000018A29430C-0x000000018A2944B8
			public override string ToString() => default; // 0x000000018A2946FC-0x000000018A2947BC
		}
	
		// Constructors
		public PolygonHelper() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public static class ShaderKeywords // TypeDefIndex: 58915
	{
		// Fields
		public const string UseFog = "VLB_USE_FOG"; // Metadata: 0x01FDCAC5
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK"; // Metadata: 0x01FDCAD1
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW"; // Metadata: 0x01FDCAE4
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH"; // Metadata: 0x01FDCB02
		public const string DepthBlend = "VLB_DEPTH_BLEND"; // Metadata: 0x01FDCB21
		public const string Noise3D = "VLB_NOISE_3D"; // Metadata: 0x01FDCB31
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE"; // Metadata: 0x01FDCB3E
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE"; // Metadata: 0x01FDCB5B
		public const string MeshSkewing = "VLB_MESH_SKEWING"; // Metadata: 0x01FDCB77
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH"; // Metadata: 0x01FDCB88
	}

	public static class ShaderProperties // TypeDefIndex: 58916
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
		public static readonly int NoiseVelocity; // 0x20
		public static readonly int NoiseScale; // 0x24
		public static readonly int DepthBlendCapOff; // 0x28
		public static readonly int BlendMode; // 0x2C
		public static readonly int FogIntensity; // 0x30
		public static readonly int ClippingPlaneTransition; // 0x34
		public static readonly int UseClippingPlane; // 0x38
		public static readonly int FadeOutFactor; // 0x3C
		public static readonly int ConeSlopeCosSin; // 0x40
		public static readonly int ConeRadius; // 0x44
		public static readonly int ConeGeomProps; // 0x48
		public static readonly int ColorFlat; // 0x4C
		public static readonly int AlphaInside; // 0x50
		public static readonly int AlphaOutside; // 0x54
		public static readonly int HDRPExposureWeight; // 0x58
		public static readonly int AttenuationLerpLinearQuad; // 0x5C
		public static readonly int DistanceFallOff; // 0x60
		public static readonly int DistanceCamClipping; // 0x64
		public static readonly int FresnelPow; // 0x68
		public static readonly int GlareBehind; // 0x6C
		public static readonly int GlareFrontal; // 0x70
		public static readonly int DrawCap; // 0x74
		public static readonly int DepthBlendDistance; // 0x78
		public static readonly int NoiseVelocityAndScale; // 0x7C
		public static readonly int NoiseParam; // 0x80
		public static readonly int CameraParams; // 0x84
		public static readonly int ColorGradientMatrix; // 0x88
		public static readonly int LocalToWorldMatrix; // 0x8C
		public static readonly int WorldToLocalMatrix; // 0x90
		public static readonly int BlendSrcFactor; // 0x94
		public static readonly int BlendDstFactor; // 0x98
		public static readonly int DynamicOcclusionClippingPlaneWS; // 0x9C
		public static readonly int DynamicOcclusionClippingPlaneProps; // 0xA0
		public static readonly int DynamicOcclusionDepthTexture; // 0xA4
		public static readonly int DynamicOcclusionDepthProps; // 0xA8
		public static readonly int LocalForwardDirection; // 0xAC
		public static readonly int TiltVector; // 0xB0
		public static readonly int AdditionalClippingPlaneWS; // 0xB4
		public static readonly int ParticlesTintColor; // 0xB8
		public static readonly int GlobalUsesReversedZBuffer; // 0xBC
		public static readonly int GlobalNoiseTex3D; // 0xC0
		public static readonly int GlobalNoiseCustomTime; // 0xC4
		public static readonly int GlobalDitheringFactor; // 0xC8
		public static readonly int GlobalDitheringNoiseTex; // 0xCC
	
		// Constructors
		static ShaderProperties() {} // 0x000000018370AD50-0x000000018370B670
	}

	public static class SpotLightHelper // TypeDefIndex: 58917
	{
		// Methods
		public static void GetCullingDistance(Light light, ref float cullingDistance, ref float falloffDistance) {} // 0x000000018A294854-0x000000018A2948DC
		public static float GetIntensity(Light light) => default; // 0x000000018A294944-0x000000018A2949AC
		public static float GetSpotAngle(Light light) => default; // 0x000000018A2949AC-0x000000018A294A14
		public static float GetFallOffEnd(Light light) => default; // 0x000000018A2948DC-0x000000018A294944
	}

	public static class SRPHelper // TypeDefIndex: 58919
	{
		// Fields
		private static RenderPipeline m_RenderPipelineCached; // 0x00
	
		// Properties
		public static RenderPipeline renderPipelineType { get; } // 0x00000001839ABFC0-0x00000001839AC060 
	
		// Nested types
		public enum RenderPipeline // TypeDefIndex: 58918
		{
			HGRP = 0,
			Undefined = 1,
			BuiltIn = 2,
			URP = 3,
			LWRP = 4,
			HDRP = 5
		}
	
		// Constructors
		static SRPHelper() {} // 0x0000000183D43CE0-0x0000000183D43D20
	
		// Methods
		private static RenderPipeline ComputeRenderPipeline() => default; // 0x0000000181002730-0x0000000181002740
		public static bool IsUsingCustomRenderPipeline() => default; // 0x000000018232EB60-0x000000018232EB70
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb) {} // 0x000000018A2947BC-0x000000018A294808
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb) {} // 0x000000018A294808-0x000000018A294854
	}

	public static class TransformUtils // TypeDefIndex: 58921
	{
		// Nested types
		public struct Packed // TypeDefIndex: 58920
		{
			// Fields
			public Vector3 position; // 0x00
			public Quaternion rotation; // 0x0C
			public Vector3 lossyScale; // 0x1C
	
			// Methods
			public bool IsSame(Transform transf) => default; // 0x000000018A294198-0x000000018A2942C8
		}
	
		// Extension methods
		public static Packed GetWorldPacked(this Transform self) => default; // 0x000000018A294F10-0x000000018A294F9C
	}

	public static class Utils // TypeDefIndex: 58923
	{
		// Fields
		private const float kEpsilon = 1E-05f; // Metadata: 0x01FDCBB8
		private const int kFloatPackingHighMinShaderLevel = 35; // Metadata: 0x01FDCBBC
		private static FloatPackingPrecision ms_FloatPackingPrecision; // 0x00
	
		// Nested types
		public enum FloatPackingPrecision // TypeDefIndex: 58922
		{
			Undef = 0,
			Low = 8,
			High = 64
		}
	
		// Methods
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle) => default; // 0x0000000183D8A0A0-0x0000000183D8A0E0
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd) => default; // 0x0000000183D8A0E0-0x0000000183D8A110
		public static void Swap<T>(ref ref T a, ref ref T b) {}
		public static string GetPath(Transform current) => default; // 0x000000018A2952F0-0x000000018A2953B4
		public static T NewWithComponent<T>(string name)
			where T : Component => default;
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt) => default; // 0x000000018A2955A8-0x000000018A29561C
		public static bool IsAlmostZero(float f) => default; // 0x000000018A29548C-0x000000018A2954A4
		public static void SetShaderKeywordEnabled(string name, bool enabled) {} // 0x000000018A295784-0x000000018A2957A8
		private static Vector4 Vector4_Floor(Vector4 vec) => default; // 0x0000000183D7ACF0-0x0000000183D7AD50
		public static FloatPackingPrecision GetFloatPackingPrecision() => default; // 0x000000018A2951D4-0x000000018A295244
		public static void MarkCurrentSceneDirty() {} // 0x000000018350B670-0x000000018350B680
		public static void MarkObjectDirty(UnityEngine.Object obj) {} // 0x000000018350B670-0x000000018350B680
	
		// Extension methods
		public static T GetOrAddComponent<T>(this GameObject self)
			where T : Component => default;
		public static T GetOrAddComponent<T>(this MonoBehaviour self)
			where T : Component => default;
		public static void ForeachComponentsOnlyInChildren<T>(this GameObject self, Action<T> lambda, bool includeInactive = false /* Metadata: 0x01FDCBA7 */)
			where T : Component {}
		public static bool HasFlag(this Enum mask, Enum flags) => default; // 0x000000018A295410-0x000000018A29548C
		public static Vector2 xy(this Vector3 aVector) => default; // 0x0000000183D51540-0x0000000183D51560
		public static Vector2 xz(this Vector3 aVector) => default; // 0x0000000183D51590-0x0000000183D515B0
		public static Vector2 yz(this Vector3 aVector) => default; // 0x0000000183D54520-0x0000000183D54540
		public static Vector2 yx(this Vector3 aVector) => default; // 0x0000000183D7F9F0-0x0000000183D7FA10
		public static Vector2 zx(this Vector3 aVector) => default; // 0x0000000183D80D00-0x0000000183D80D20
		public static Vector2 zy(this Vector3 aVector) => default; // 0x0000000183D80E60-0x0000000183D80E80
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f /* Metadata: 0x01FDCBA8 */) => default; // 0x0000000185717BC8-0x0000000185717BDC
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f /* Metadata: 0x01FDCBAC */) => default; // 0x000000018A294F9C-0x000000018A294FD0
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f /* Metadata: 0x01FDCBB0 */) => default; // 0x000000018A294FD0-0x000000018A295034
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f /* Metadata: 0x01FDCBB4 */) => default; // 0x000000018A295034-0x000000018A295088
		public static Vector4 AsVector4(this Vector3 vec3, float w) => default; // 0x0000000183D8A080-0x0000000183D8A0A0
		public static float GetVolumeCubic(this Bounds self) => default; // 0x000000018A2953B4-0x000000018A295410
		public static float GetMaxArea2D(this Bounds self) => default; // 0x000000018A295244-0x000000018A2952F0
		public static UnityEngine.Color Opaque(this UnityEngine.Color self) => default; // 0x0000000183D8A110-0x0000000183D8A130
		public static UnityEngine.Color ComputeComplementaryColor(this UnityEngine.Color self, bool blackAndWhite) => default; // 0x000000018A295130-0x000000018A2951D4
		public static Plane TranslateCustom(this Plane plane, Vector3 translation) => default; // 0x000000018A2957A8-0x000000018A29583C
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point) => default; // 0x000000018A295088-0x000000018A295130
		public static bool IsValid(this Plane plane) => default; // 0x000000018A2954A4-0x000000018A2954D4
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled) {} // 0x00000001856EC558-0x00000001856EC58C
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision) => default; // 0x000000018A2956E0-0x000000018A295784
		public static UnityEngine.Color[] SampleInArray(this Gradient self, int samplesCount) => default; // 0x000000018A29561C-0x000000018A2956E0
		public static float PackToFloat(this UnityEngine.Color color, int floatPackingPrecision) => default; // 0x000000018A2954D4-0x000000018A2955A8
	}

	public static class Version // TypeDefIndex: 58924
	{
		// Fields
		public const int Current = 1991; // Metadata: 0x01FDCBC1
	}

	[AddComponentMenu("Rendering/\u4F4E\u914D\u4F53\u79EF\u5149 Volumetric Light Beam")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 58926
	{
		// Fields
		public PlatformLayers platformLayers; // 0x18
		public const string ClassName = "VolumetricLightBeam"; // Metadata: 0x01FDCBC3
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
		public bool noiseScaleUseSeparateAxis; // 0xF9
		public Vector3 noiseScalesLocal; // 0xFC
		[Range(0.01f, 2f)]
		public float noiseScaleLocal; // 0x108
		public bool noiseVelocityUseGlobal; // 0x10C
		public Vector3 noiseVelocityLocal; // 0x110
		public bool fadeOutFromLight; // 0x11C
		public float fadeOutBeginSecond; // 0x120
		public float fadeOutEndSecond; // 0x124
		public bool useFog; // 0x128
		public float fogIntensity; // 0x12C
		public Dimensions dimensions; // 0x130
		public Vector2 tiltFactor; // 0x134
		[SerializeField]
		private int pluginVersion; // 0x13C
		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime; // 0x140
		[SerializeField]
		private int _SortingLayerID; // 0x144
		[SerializeField]
		private int _SortingOrder; // 0x148
		[FormerlySerializedAs("fadeOutBegin")]
		[SerializeField]
		private float _FadeOutBegin; // 0x14C
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd; // 0x150
		public BeamGeometry m_BeamGeom; // 0x158
		public bool matIsPersistent; // 0x160
		private Coroutine m_CoPlaytimeUpdate; // 0x168
	
		// Properties
		public ColorMode usedColorMode { get => default; } // 0x000000018A296D00-0x000000018A296D34 
		private bool useColorFromAttachedLightSpot { get => default; } // 0x000000018A296B50-0x000000018A296BA8 
		private bool useColorTemperatureFromAttachedLightSpot { get => default; } // 0x000000018A296BA8-0x000000018A296BF4 
		[Obsolete("Use \'intensityGlobal\' or \'intensityInside\' instead")]
		public float alphaInside { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		[Obsolete("Use \'intensityGlobal\' or \'intensityOutside\' instead")]
		public float alphaOutside { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D5BE60-0x0000000183D5BE70
		public float intensityGlobal { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000183D8A170-0x0000000183D8A180
		public bool useIntensityFromAttachedLightSpot { get => default; } // 0x000000018A296C50-0x000000018A296CA8 
		public bool useSpotAngleFromAttachedLightSpot { get => default; } // 0x000000018A296CA8-0x000000018A296D00 
		public float coneAngle { get => default; } // 0x000000018A296030-0x000000018A296088 
		public float coneRadiusEnd { get => default; set {} } // 0x000000018A2961F0-0x000000018A296250 0x000000018A296D34-0x000000018A296D88
		public float coneVolume { get => default; } // 0x000000018A296250-0x000000018A2962A0 
		public float coneApexOffsetZ { get => default; } // 0x000000018A296088-0x000000018A2960F8 
		public Vector3 coneApexPositionLocal { get => default; } // 0x000000018A2961C0-0x000000018A2961F0 
		public Vector3 coneApexPositionGlobal { get => default; } // 0x000000018A2960F8-0x000000018A2961C0 
		public int geomSides { get => default; set {} } // 0x000000018A2962EC-0x000000018A296318 0x000000018A296DE8-0x000000018A296E48
		public int geomSegments { get => default; set {} } // 0x000000018A2962C0-0x000000018A2962EC 0x000000018A296D88-0x000000018A296DE8
		public Vector3 skewingLocalForwardDirectionNormalized { get => default; } // 0x000000018A296A44-0x000000018A296B40 
		public bool canHaveMeshSkewing { get => default; } // 0x000000018232EB60-0x000000018232EB70 
		public bool hasMeshSkewing { get => default; } // 0x000000018A29636C-0x000000018A2963D8 
		public Vector4 additionalClippingPlane { get => default; } // 0x000000018A295B28-0x000000018A295CE8 
		public float attenuationLerpLinearQuad { get => default; } // 0x000000018A295CE8-0x000000018A295D10 
		[Obsolete("Use \'fallOffStart\' instead")]
		public float fadeStart { get => default; set {} } // 0x0000000183D582F0-0x0000000183D58300 0x0000000183D71A70-0x0000000183D71A80
		[Obsolete("Use \'fallOffEnd\' instead")]
		public float fadeEnd { get => default; set {} } // 0x0000000183D5D790-0x0000000183D5D7A0 0x0000000183D5D7B0-0x0000000183D5D7C0
		[Obsolete("Use \'fallOffEndFromLight\' instead")]
		public bool fadeEndFromLight { get => default; set {} } // 0x0000000183D57F00-0x0000000183D57F10 0x0000000183D57F80-0x0000000183D57F90
		public Light lightSpotAttached { get => default; } // 0x0000000183D4E7C0-0x0000000183D4E7D0 
		public bool useFallOffEndFromAttachedLightSpot { get => default; } // 0x000000018A296BF4-0x000000018A296C50 
		public float maxGeometryDistance { get => default; } // 0x000000018A296564-0x000000018A296594 
		public bool isNoiseEnabled { get => default; } // 0x000000018A296408-0x000000018A296414 
		[Obsolete("Use \'noiseMode\' instead")]
		public bool noiseEnabled { get => default; set {} } // 0x000000018A296408-0x000000018A296414 0x000000018A296E48-0x000000018A296E68
		public float cullingDistance { get => default; } // 0x000000018A2962A0-0x000000018A2962C0 
		public float fadeOutBegin { get => default; set {} } // 0x0000000183D575C0-0x0000000183D575D0 0x0000000183D8A150-0x0000000183D8A160
		public float fadeOutEnd { get => default; set {} } // 0x0000000183D581F0-0x0000000183D58200 0x0000000183D8A160-0x0000000183D8A170
		public bool isFadeOutEnabled { get => default; } // 0x000000018A2963E4-0x000000018A296408 
		public bool isTilted { get => default; } // 0x000000018A296414-0x000000018A296474 
		public int sortingLayerID { get => default; set {} } // 0x0000000183D76300-0x0000000183D76310 0x000000018A296E68-0x000000018A296EEC
		public string sortingLayerName { get => default; set {} } // 0x000000018A296B40-0x000000018A296B50 0x000000018A296EEC-0x000000018A296F14
		public int sortingOrder { get => default; set {} } // 0x0000000183D72F40-0x0000000183D72F50 0x000000018A296F14-0x000000018A296F98
		public bool trackChangesDuringPlaytime { get => default; set {} } // 0x0000000183D576E0-0x0000000183D576F0 0x0000000183D8A180-0x0000000183D8A190
		public bool isCurrentlyTrackingChanges { get => default; } // 0x000000018A2963D8-0x000000018A2963E4 
		public bool hasGeometry { get => default; } // 0x000000018A296318-0x000000018A29636C 
		public Bounds bounds { get => default; } // 0x000000018A295F34-0x000000018A296030 
		public int blendingModeAsInt { get => default; } // 0x000000018A295E88-0x000000018A295F34 
		public Quaternion beamInternalLocalRotation { get => default; } // 0x000000018A295DC8-0x000000018A295E4C 
		public Vector3 beamLocalForward { get => default; } // 0x000000018A295E4C-0x000000018A295E88 
		public Vector3 beamGlobalForward { get => default; } // 0x000000018A295D10-0x000000018A295DC8 
		public Vector3 lossyScale { get => default; } // 0x000000018A296474-0x000000018A296564 
		public float raycastDistance { get => default; } // 0x000000018A296878-0x000000018A296920 
		public Vector3 raycastGlobalForward { get => default; } // 0x000000018A296920-0x000000018A2969A4 
		public Vector3 raycastGlobalUp { get => default; } // 0x000000018A2969F4-0x000000018A296A44 
		public Vector3 raycastGlobalRight { get => default; } // 0x000000018A2969A4-0x000000018A2969F4 
		public int _INTERNAL_pluginVersion { get => default; } // 0x0000000183D4FC20-0x0000000183D4FC30 
		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; } // 0x0000000183D58C90-0x0000000183D58CA0 0x0000000183D8A140-0x0000000183D8A150
		public string meshStats { get => default; } // 0x000000018A296594-0x000000018A296708 
		public int meshVerticesCount { get => default; } // 0x000000018A2967CC-0x000000018A296878 
		public int meshTrianglesCount { get => default; } // 0x000000018A296708-0x000000018A2967CC 
	
		// Nested types
		public enum AttachedLightType // TypeDefIndex: 58925
		{
			NoLight = 0,
			OtherLight = 1,
			SpotLight = 2
		}
	
		// Constructors
		public VolumetricLightBeam() {} // 0x000000018A295930-0x000000018A295B28
	
		// Methods
		public void GetInsideAndOutsideIntensity(out float inside, out float outside) {
			inside = default;
			outside = default;
		} // 0x000000018A29590C-0x000000018A295930
		private Vector3 ComputeRaycastGlobalVector(Vector3 localVec) => default; // 0x000000018A29583C-0x000000018A29590C
		private void SetFadeOutValue(ref float propToChange, float value) {} // 0x0000000183D8A130-0x0000000183D8A140
	}
}
