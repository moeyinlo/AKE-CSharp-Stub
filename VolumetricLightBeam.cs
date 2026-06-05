/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 77: VolumetricLightBeam.dll - Assembly: VolumetricLightBeam, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59889-59956

public static class EditorPrefsStrings // TypeDefIndex: 59890
{
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 59953
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D; // 0x00 // Static value (base64): AQAAAAEAAAAKAAAA - Metadata: 0x020824C4
	internal static readonly __StaticArrayInitTypeSize_12 F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B; // 0x0C // Static value (base64): AQAAAAQAAAAFAAAA - Metadata: 0x020824D4

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 59952
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond.SourceGenerator
{
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 59892
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 59893
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 59894
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 59895
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 59896
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 59891
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 59954
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x000000018C3ABB84-0x000000018C3ABBE8
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 59955
	{
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018C3ABBE8-0x000000018C3ABC7C
	
		// Methods
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 59956
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018C3AF250-0x000000018C3AF2B4
		public static bool IsPatched(int id) => default; // 0x000000018C3AF340-0x000000018C3AF3D8
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018C3AF10C-0x000000018C3AF1D8
		public object CreateWrapper(int id) => default; // 0x000000018C3AF1D8-0x000000018C3AF250
		public object InitWrapperArray(int len) => default; // 0x000000018C3AF2B4-0x000000018C3AF340
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018C3AF068-0x000000018C3AF10C
	}
}

namespace VLB
{
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface // TypeDefIndex: 59897
	{
		// Fields
		private VolumetricLightBeam m_Master; // 0x18
		private Matrix4x4 m_ColorGradientMatrix; // 0x20
		private MeshType m_CurrentMeshType; // 0x60
		private MaterialModifier.Callback m_MaterialModifierCallback; // 0x68
		private Coroutine m_CoFadeOut; // 0x70
		private MeshRenderer _meshRenderer_k__BackingField; // 0x78
		private MeshFilter _meshFilter_k__BackingField; // 0x80
		private Mesh _coneMesh_k__BackingField; // 0x88
		public Material m_CustomMaterial; // 0x90
	
		// Properties
		public MeshRenderer meshRenderer { get; private set; } // 0x0000000183060C50-0x0000000183060C60 0x000000018738A324-0x000000018738A334
		public MeshFilter meshFilter { get; private set; } // 0x000000018140CF50-0x000000018140CF60 0x00000001873CBE98-0x00000001873CBEA8
		public Mesh coneMesh { get; private set; } // 0x0000000185FB0510-0x0000000185FB0520 0x0000000186472AA8-0x0000000186472ABC
		private bool visible { get => default; set {} } // 0x000000018C3AB528-0x000000018C3AB548 0x000000018C3AB588-0x000000018C3AB604
		public int sortingLayerID { get => default; set {} } // 0x000000018C3AB4E8-0x000000018C3AB508 0x000000018C3AB548-0x000000018C3AB568
		public int sortingOrder { get => default; set {} } // 0x000000018C3AB508-0x000000018C3AB528 0x000000018C3AB568-0x000000018C3AB588
		public bool _INTERNAL_IsFadeOutCoroutineRunning { get => default; } // 0x000000018A69E57C-0x000000018A69E588 
	
		// Constructors
		public BeamGeometry() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void RestartFadeOutCoroutine() {} // 0x0000000185492010-0x0000000185492020
		public void StopFadeOutCoroutine() {} // 0x0000000185492010-0x0000000185492020
		public void SetMaterialProp(int nameID, float value) {} // 0x000000018C3AB41C-0x000000018C3AB4E8
		public void SetMaterialProp(int nameID, Vector4 value) {} // 0x000000018C3AB198-0x000000018C3AB278
		public void SetMaterialProp(int nameID, UnityEngine.Color value) {} // 0x000000018C3AB278-0x000000018C3AB358
		public void SetMaterialProp(int nameID, Matrix4x4 value) {} // 0x000000018C3AB080-0x000000018C3AB198
		public void SetMaterialProp(int nameID, Texture value) {} // 0x000000018C3AB358-0x000000018C3AB41C
	}

	public class Config : ScriptableObject // TypeDefIndex: 59898
	{
		// Fields
		public const string ClassName = "Config"; // Metadata: 0x02082030
		public const string kAssetName = "VLBConfigOverride"; // Metadata: 0x02082037
		public const string kAssetNameExt = ".asset"; // Metadata: 0x02082049
		private static Config ms_Instance; // 0x00
		public Mesh sharedMesh; // 0x18
		public bool featureEnabledDustParticles; // 0x20
		public bool featureEnabledEffect; // 0x21
		public bool featureEnabledTriggerZone; // 0x22
		public bool geometryOverrideLayer; // 0x23
		public int geometryLayerID; // 0x24
		public string geometryTag; // 0x28
		public int geometryRenderQueue; // 0x30
		private VLB.RenderPipeline _RenderPipeline; // 0x34
		private RenderingMode _RenderingMode; // 0x38
		public float ditheringFactor; // 0x3C
		public bool useLightColorTemperature; // 0x40
		public int sharedMeshSides; // 0x44
		public int sharedMeshSegments; // 0x48
		public Vector3 globalNoisesScale; // 0x4C
		public Vector3 globalNoiseVelocity; // 0x58
		public string fadeOutCameraTag; // 0x68
		public Texture3D noiseTexture3D; // 0x70
		public ParticleSystem dustParticlesPrefab; // 0x78
		public Texture2D ditheringNoiseTexture; // 0x80
		public FeatureEnabledColorGradient featureEnabledColorGradient; // 0x88
		public bool featureEnabledDepthBlend; // 0x8C
		public bool featureEnabledNoise3D; // 0x8D
		public bool featureEnabledDynamicOcclusion; // 0x8E
		public bool featureEnabledMeshSkewing; // 0x8F
		public bool featureEnabledShaderAccuracyHigh; // 0x90
		private Shader _BeamShader; // 0x98
		private Transform m_CachedFadeOutCamera; // 0xA0
		private int pluginVersion; // 0xA8
		private Material _DummyMaterial; // 0xB0
	
		// Properties
		public VLB.RenderPipeline renderPipeline { get => default; } // 0x0000000185FB07C0-0x0000000185FB07D0 
		public RenderingMode renderingMode { get => default; } // 0x00000001813E5E30-0x00000001813E5E40 
		public RenderingMode actualRenderingMode { get => default; } // 0x000000018C3ABA38-0x000000018C3ABA54 
		public bool useSinglePassShader { get => default; } // 0x000000018C3ABAC8-0x000000018C3ABAE0 
		public bool requiresDoubleSidedMesh { get => default; } // 0x000000018C3ABAC8-0x000000018C3ABAE0 
		public Shader beamShader { get => default; } // 0x0000000181E336C0-0x0000000181E336D0 
		public Transform fadeOutCameraTransform { get => default; } // 0x000000018C3ABA54-0x000000018C3ABAC0 
		public bool isHDRPExposureWeightSupported { get => default; } // 0x000000018C3ABAC0-0x000000018C3ABAC8 
		public bool hasRenderPipelineMismatch { get => default; } // 0x0000000184BD1600-0x0000000184BD1670 
		public static Config Instance { get => default; } // 0x0000000186471FFC-0x0000000186472008 
	
		// Constructors
		public Config() {} // 0x0000000185D8FA60-0x0000000185D8FB80
	
		// Methods
		public void Reset() {} // 0x000000018C3AB934-0x000000018C3ABA38
		private void OnEnable() {} // 0x0000000185FACE10-0x0000000185FACE20
		public bool IsSRPBatcherSupported() => default; // 0x00000001814A81B0-0x00000001814A81C0
		public void ForceUpdateFadeOutCamera() {} // 0x000000018C3AB604-0x000000018C3AB688
		private static void OnStartup() {} // 0x0000000184BD1560-0x0000000184BD1600
		private void RefreshGlobalShaderProperties() {} // 0x0000000184BD1710-0x0000000184BD17F0
		public void ResetInternalData() {} // 0x000000018C3AB7C0-0x000000018C3AB934
		public ParticleSystem NewVolumetricDustParticles() => default; // 0x000000018C3AB688-0x000000018C3AB7C0
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion) {} // 0x0000000185FACE20-0x0000000185FACE30
		private static Config LoadAssetInternal(string assetName) => default; // 0x0000000185B56C70-0x0000000185B56CB0
		private static Config GetInstance(bool assertIfNotFound) => default; // 0x0000000185B56B20-0x0000000185B56C70
	}

	public static class Consts // TypeDefIndex: 59905
	{
		// Fields
		public const string PluginFolder = "Plugins/VolumetricLightBeam"; // Metadata: 0x02082050
	
		// Nested types
		public static class Help // TypeDefIndex: 59899
		{
			// Fields
			private const string UrlBase = "http://saladgamer.com/vlb-doc/"; // Metadata: 0x0208206C
			private const string UrlSuffix = "/"; // Metadata: 0x0208208B
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/"; // Metadata: 0x0208208D
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/"; // Metadata: 0x020820BB
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/"; // Metadata: 0x020820ED
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/"; // Metadata: 0x02082129
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/"; // Metadata: 0x02082166
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/"; // Metadata: 0x02082196
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/"; // Metadata: 0x020821C8
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/"; // Metadata: 0x020821FB
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/"; // Metadata: 0x0208222C
		}
	
		public static class Internal // TypeDefIndex: 59900
		{
			// Properties
			public static HideFlags ProceduralObjectsHideFlags { get; } // 0x00000001813AE580-0x00000001813AE590 
		}
	
		public static class Beam // TypeDefIndex: 59901
		{
			// Fields
			public const ColorMode ColorModeDefault = ColorMode.Flat; // Metadata: 0x02082252
			public const float MultiplierDefault = 1f; // Metadata: 0x02082253
			public const float MultiplierMin = 0f; // Metadata: 0x02082257
			public const float IntensityDefault = 1f; // Metadata: 0x0208225B
			public const float IntensityMin = 0f; // Metadata: 0x0208225F
			public const float HDRPExposureWeightDefault = 0f; // Metadata: 0x02082263
			public const float HDRPExposureWeightMin = 0f; // Metadata: 0x02082267
			public const float HDRPExposureWeightMax = 1f; // Metadata: 0x0208226B
			public const float SpotAngleDefault = 35f; // Metadata: 0x0208226F
			public const float SpotAngleMin = 0.1f; // Metadata: 0x02082273
			public const float SpotAngleMax = 179.9f; // Metadata: 0x02082277
			public const float ConeRadiusStart = 0f; // Metadata: 0x0208227B
			public const MeshType GeomMeshType = MeshType.Shared; // Metadata: 0x0208227F
			public const int GeomSidesDefault = 18; // Metadata: 0x02082280
			public const int GeomSidesMin = 3; // Metadata: 0x02082281
			public const int GeomSidesMax = 256; // Metadata: 0x02082282
			public const int GeomSegmentsDefault = 5; // Metadata: 0x02082284
			public const int GeomSegmentsMin = 0; // Metadata: 0x02082285
			public const int GeomSegmentsMax = 64; // Metadata: 0x02082286
			public const bool GeomCap = false; // Metadata: 0x02082288
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic; // Metadata: 0x02082289
			public const float AttenuationCustomBlendingDefault = 0.5f; // Metadata: 0x0208228A
			public const float AttenuationCustomBlendingMin = 0f; // Metadata: 0x0208228E
			public const float AttenuationCustomBlendingMax = 1f; // Metadata: 0x02082292
			public const float FallOffStart = 0f; // Metadata: 0x02082296
			public const float FallOffEnd = 3f; // Metadata: 0x0208229A
			public const float FallOffDistancesMinThreshold = 0.01f; // Metadata: 0x0208229E
			public const float DepthBlendDistance = 2f; // Metadata: 0x020822A2
			public const float CameraClippingDistance = 0.5f; // Metadata: 0x020822A6
			public const float FresnelPowMaxValue = 10f; // Metadata: 0x020822AA
			public const float FresnelPow = 8f; // Metadata: 0x020822AE
			public const float GlareFrontalDefault = 0f; // Metadata: 0x020822B2
			public const float GlareBehindDefault = 0f; // Metadata: 0x020822B6
			public const float GlareMin = 0f; // Metadata: 0x020822BA
			public const float GlareMax = 1f; // Metadata: 0x020822BE
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled; // Metadata: 0x020822C2
			public const float NoiseIntensityMin = 0f; // Metadata: 0x020822C3
			public const float NoiseIntensityMax = 1f; // Metadata: 0x020822C7
			public const float NoiseIntensityDefault = 0.5f; // Metadata: 0x020822CB
			public const float NoiseScaleMin = 0.01f; // Metadata: 0x020822CF
			public const float NoiseScaleMax = 2f; // Metadata: 0x020822D3
			public static readonly Vector3 NoiseScalesDefault; // 0x00
			public const float NoiseScaleDefault = 0.5f; // Metadata: 0x020822D7
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive; // Metadata: 0x020822DB
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.High; // Metadata: 0x020822DC
			public const float FadeOutBeginDefault = 256f; // Metadata: 0x020822DD
			public const float FadeOutEndDefault = 200f; // Metadata: 0x020822E1
			public const float FadeOutBeginSecondDefault = 0f; // Metadata: 0x020822E5
			public const float FadeOutEndSecondDefault = 0f; // Metadata: 0x020822E9
			public const Dimensions DimensionsDefault = Dimensions.Dim3D; // Metadata: 0x020822ED
			public const Transform ClippingPlaneTransformDefault = null; // Metadata: 0x00000000
			public static readonly UnityEngine.Color FlatColor; // 0x0C
			public static readonly Vector3 NoiseVelocityDefault; // 0x1C
			public static readonly Vector2 TiltDefault; // 0x28
			public static readonly Vector3 SkewingLocalForwardDirectionDefault; // 0x30
	
			// Constructors
			static Beam() {} // 0x0000000185D64E90-0x0000000185D65040
		}
	
		public static class DustParticles // TypeDefIndex: 59902
		{
			// Fields
			public const float AlphaDefault = 0.5f; // Metadata: 0x020822EE
			public const float SizeDefault = 0.01f; // Metadata: 0x020822F2
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random; // Metadata: 0x020822F6
			public const float DensityDefault = 5f; // Metadata: 0x020822F7
			public const float DensityMin = 0f; // Metadata: 0x020822FB
			public const float DensityMax = 1000f; // Metadata: 0x020822FF
			public const bool CullingEnabledDefault = false; // Metadata: 0x02082303
			public const float CullingMaxDistanceDefault = 10f; // Metadata: 0x02082304
			public const float CullingMaxDistanceMin = 1f; // Metadata: 0x02082308
			public static readonly Vector3 VelocityDefault; // 0x00
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault; // 0x0C
	
			// Constructors
			static DustParticles() {} // 0x000000018C3ABAE0-0x000000018C3ABB48
		}
	
		public static class DynOcclusion // TypeDefIndex: 59903
		{
			// Fields
			public const float FadeDistanceToSurfaceDefault = 0.25f; // Metadata: 0x0208230C
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames; // Metadata: 0x02082310
			public const int WaitFramesCountDefault = 3; // Metadata: 0x02082311
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D; // Metadata: 0x02082312
			public const bool RaycastingConsiderTriggersDefault = false; // Metadata: 0x02082313
			public const float RaycastingMinOccluderAreaDefault = 0f; // Metadata: 0x02082314
			public const float RaycastingMinSurfaceRatioDefault = 0.5f; // Metadata: 0x02082318
			public const float RaycastingMinSurfaceRatioMin = 50f; // Metadata: 0x0208231C
			public const float RaycastingMinSurfaceRatioMax = 100f; // Metadata: 0x02082320
			public const float RaycastingMaxSurfaceDotDefault = 0.25f; // Metadata: 0x02082324
			public const float RaycastingMaxSurfaceAngleMin = 45f; // Metadata: 0x02082328
			public const float RaycastingMaxSurfaceAngleMax = 90f; // Metadata: 0x0208232C
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface; // Metadata: 0x02082330
			public const float RaycastingPlaneOffsetDefault = 0.1f; // Metadata: 0x02082331
			public const int DepthBufferDepthMapResolutionDefault = 32; // Metadata: 0x02082335
			public const bool DepthBufferOcclusionCullingDefault = true; // Metadata: 0x02082336
			public static readonly LayerMask LayerMaskDefault; // 0x00
	
			// Constructors
			static DynOcclusion() {} // 0x000000018C3ABB48-0x000000018C3ABB84
		}
	
		public static class Config // TypeDefIndex: 59904
		{
			// Fields
			public const bool GeometryOverrideLayerDefault = true; // Metadata: 0x02082337
			public const int GeometryLayerIDDefault = 1; // Metadata: 0x02082338
			public const string GeometryTagDefault = "Untagged"; // Metadata: 0x02082339
			public const string FadeOutCameraTagDefault = "MainCamera"; // Metadata: 0x02082342
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent; // Metadata: 0x0208234D
			public const VLB.RenderPipeline GeometryRenderPipelineDefault = VLB.RenderPipeline.HGRP; // Metadata: 0x0208234F
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass; // Metadata: 0x02082350
			public const int Noise3DSizeDefault = 64; // Metadata: 0x02082351
			public const int SharedMeshSides = 24; // Metadata: 0x02082353
			public const int SharedMeshSegments = 5; // Metadata: 0x02082354
			public const float DitheringFactor = 0f; // Metadata: 0x02082355
			public const bool UseLightColorTemperatureDefault = true; // Metadata: 0x02082359
			public const bool FeatureEnabledDefault = true; // Metadata: 0x0208235A
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly; // Metadata: 0x0208235B
		}
	}

	public static class DummyMaterial // TypeDefIndex: 59906
	{
	}

	public enum FeatureEnabledColorGradient // TypeDefIndex: 59907
	{
		Off = 0,
		HighOnly = 1,
		HighAndLow = 2
	}

	public enum ColorMode // TypeDefIndex: 59908
	{
		Flat = 0,
		Gradient = 1
	}

	public enum AttenuationEquation // TypeDefIndex: 59909
	{
		Linear = 0,
		Quadratic = 1,
		Blend = 2
	}

	public enum BlendingMode // TypeDefIndex: 59910
	{
		Additive = 0,
		SoftAdditive = 1,
		TraditionalTransparency = 2
	}

	public enum ShaderAccuracy // TypeDefIndex: 59911
	{
		Fast = 0,
		High = 1
	}

	public enum NoiseMode // TypeDefIndex: 59912
	{
		Disabled = 0,
		WorldSpace = 1,
		LocalSpace = 2
	}

	public enum MeshType // TypeDefIndex: 59913
	{
		Shared = 0,
		Custom = 1
	}

	public enum RenderPipeline // TypeDefIndex: 59914
	{
		HGRP = 0,
		BuiltIn = 1,
		URP = 2,
		HDRP = 3
	}

	public enum RenderingMode // TypeDefIndex: 59915
	{
		MultiPass = 0,
		SinglePass = 1,
		GPUInstancing = 2,
		SRPBatcher = 3
	}

	public enum RenderQueue // TypeDefIndex: 59916
	{
		Custom = 0,
		Background = 1000,
		Geometry = 2000,
		AlphaTest = 2450,
		GeometryLast = 2500,
		Transparent = 3000,
		Overlay = 4000
	}

	public enum Dimensions // TypeDefIndex: 59917
	{
		Dim3D = 0,
		Dim2D = 1
	}

	public enum PlaneAlignment // TypeDefIndex: 59918
	{
		Surface = 0,
		Beam = 1
	}

	public enum DynamicOcclusionUpdateRate // TypeDefIndex: 59919
	{
		Never = 1,
		OnEnable = 2,
		OnBeamMove = 4,
		EveryXFrames = 8,
		OnBeamMoveAndEveryXFrames = 12
	}

	public enum ParticlesDirection // TypeDefIndex: 59920
	{
		Random = 0,
		LocalSpace = 1,
		WorldSpace = 2
	}

	public sealed class HighlightNullAttribute : PropertyAttribute // TypeDefIndex: 59921
	{
		// Constructors
		public HighlightNullAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class MaterialManager // TypeDefIndex: 59931
	{
		// Fields
		public const int staticPropertiesCount = 432; // Metadata: 0x0208238F
		public static MaterialPropertyBlock materialPropertyBlock; // 0x00
		private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor; // 0x08
		private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor; // 0x10
		private static readonly bool[] BlendingMode_AlphaAsBlack; // 0x18
		private static readonly Hashtable ms_MaterialsGroup; // 0x20
	
		// Nested types
		public enum BlendingMode // TypeDefIndex: 59922
		{
			Additive = 0,
			SoftAdditive = 1,
			TraditionalTransparency = 2,
			Count = 3
		}
	
		public enum ColorGradient // TypeDefIndex: 59923
		{
			Off = 0,
			MatrixLow = 1,
			MatrixHigh = 2,
			Count = 3
		}
	
		public enum DepthBlend // TypeDefIndex: 59924
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum DynamicOcclusion // TypeDefIndex: 59925
		{
			Off = 0,
			ClippingPlane = 1,
			DepthTexture = 2,
			Count = 3
		}
	
		public enum MeshSkewing // TypeDefIndex: 59926
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum Noise3D // TypeDefIndex: 59927
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum ShaderAccuracy // TypeDefIndex: 59928
		{
			Fast = 0,
			High = 1,
			Count = 2
		}
	
		public struct StaticProperties // TypeDefIndex: 59929
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
			private int blendingModeID { get => default; } // 0x000000018C3ABF2C-0x000000018C3ABFEC 
			private int noise3DID { get => default; } // 0x000000018C3ABE70-0x000000018C3ABF2C 
			private int depthBlendID { get => default; } // 0x000000018C3ABC7C-0x000000018C3ABE70 
			private int colorGradientID { get => default; } // 0x000000018C3ABFEC-0x000000018C3AC1FC 
			private int dynamicOcclusionID { get => default; } // 0x000000018357CBC0-0x000000018357CBD0 
			private int meshSkewingID { get => default; } // 0x000000018C3ACF7C-0x000000018C3ACFB0 
			private int shaderAccuracyID { get => default; } // 0x000000018C3ACE40-0x000000018C3ACE74 
			public int materialID { get => default; } // 0x000000018C3ACE0C-0x000000018C3ACE40 
	
			// Methods
			public void ApplyToMaterial(Material mat) {} // 0x000000018C3ACE74-0x000000018C3ACEA8
		}
	
		private class MaterialsGroup // TypeDefIndex: 59930
		{
			// Fields
			public readonly Material[] materials; // 0x10
	
			// Constructors
			public MaterialsGroup() {} // 0x000000018C3ACF48-0x000000018C3ACF7C
		}
	
		// Constructors
		static MaterialManager() {} // 0x000000018C3AC1FC-0x000000018C3AC244
	
		// Methods
		public static Material NewMaterialTransient(bool gpuInstanced) => default; // 0x000000018C3ACFB0-0x000000018C3ACFE4
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced) => default; // 0x000000018C3ACEA8-0x000000018C3ACF48
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps) => default; // 0x000000018C3ACAE8-0x000000018C3ACE0C
	}

	public static class MaterialModifier // TypeDefIndex: 59934
	{
		// Nested types
		public delegate void Callback(Interface owner); // TypeDefIndex: 59932; 0x00000001833EEC70-0x00000001833EEC80
	
		public interface Interface // TypeDefIndex: 59933
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
	public struct MinMaxRangeFloat // TypeDefIndex: 59935
	{
		// Fields
		private float m_MinValue; // 0x00
		private float m_MaxValue; // 0x04
	
		// Properties
		public float minValue { get => default; } // 0x0000000185FB0F90-0x0000000185FB0FA0 
		public float maxValue { get => default; } // 0x0000000185FBA150-0x0000000185FBA160 
		public float randomValue { get => default; } // 0x000000018C3AC258-0x000000018C3AC26C 
		public Vector2 asVector2 { get => default; } // 0x0000000185FB29D0-0x0000000185FB29F0 
	
		// Constructors
		public MinMaxRangeFloat(float min, float max) : this() {
			m_MinValue = default;
			m_MaxValue = default;
		} // 0x0000000185FB1970-0x0000000185FB1980
	
		// Methods
		public float GetLerpedValue(float lerp01) => default; // 0x000000018C3AC244-0x000000018C3AC258
	}

	public class MinMaxRangeAttribute : Attribute // TypeDefIndex: 59936
	{
		// Fields
		private readonly float _minValue_k__BackingField; // 0x10
		private readonly float _maxValue_k__BackingField; // 0x14
	
		// Properties
		public float minValue { get; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 
		public float maxValue { get; } // 0x0000000185FB2D80-0x0000000185FB2D90 
	
		// Constructors
		public MinMaxRangeAttribute() {} // Dummy constructor
		public MinMaxRangeAttribute(float min, float max) {} // 0x0000000185FBF890-0x0000000185FBF8A0
	}

	public class PlatformHelper // TypeDefIndex: 59937
	{
		// Constructors
		public PlatformHelper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static string GetCurrentPlatformSuffix() => default; // 0x0000000185B56CB0-0x0000000185B56CD0
		private static string GetPlatformSuffix(RuntimePlatform platform) => default; // 0x0000000185B56CD0-0x0000000185B56D20
	}

	public class PolygonHelper : MonoBehaviour // TypeDefIndex: 59939
	{
		// Nested types
		public struct Plane2D // TypeDefIndex: 59938
		{
			// Fields
			public Vector2 normal; // 0x00
			public float distance; // 0x08
	
			// Methods
			public float Distance(Vector2 point) => default; // 0x000000018646DB20-0x000000018646DB28
			public Vector2 ClosestPoint(Vector2 pt) => default; // 0x0000000185FEAE90-0x0000000185FEAEC0
			public Vector2 Intersect(Vector2 p1, Vector2 p2) => default; // 0x000000018C3AC39C-0x000000018C3AC3E0
			public bool GetSide(Vector2 point) => default; // 0x000000018C3AC704-0x000000018C3AC7D0
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2) => default; // 0x000000018C3AC6E8-0x000000018C3AC704
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1) => default; // 0x000000018C3AC628-0x000000018C3AC6E8
			public void Flip() {} // 0x000000018C3AC5B4-0x000000018C3AC628
			public Vector2[] CutConvex(Vector2[] poly) => default; // 0x000000018C3AC58C-0x000000018C3AC5B4
			public override string ToString() => default; // 0x000000018C3AC3E0-0x000000018C3AC58C
		}
	
		// Constructors
		public PolygonHelper() {} // 0x000000018C3AC7D0-0x000000018C3AC890
	}

	public static class ShaderKeywords // TypeDefIndex: 59940
	{
		// Fields
		public const string UseFog = "VLB_USE_FOG"; // Metadata: 0x020823A9
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK"; // Metadata: 0x020823B5
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW"; // Metadata: 0x020823C8
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH"; // Metadata: 0x020823E6
		public const string DepthBlend = "VLB_DEPTH_BLEND"; // Metadata: 0x02082405
		public const string Noise3D = "VLB_NOISE_3D"; // Metadata: 0x02082415
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE"; // Metadata: 0x02082422
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE"; // Metadata: 0x0208243F
		public const string MeshSkewing = "VLB_MESH_SKEWING"; // Metadata: 0x0208245B
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH"; // Metadata: 0x0208246C
	}

	public static class ShaderProperties // TypeDefIndex: 59941
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
		static ShaderProperties() {} // 0x000000018580F650-0x000000018580FF70
	}

	public static class SpotLightHelper // TypeDefIndex: 59942
	{
		// Methods
		public static void GetCullingDistance(Light light, ref float cullingDistance, ref float falloffDistance) {} // 0x000000018C3AC928-0x000000018C3AC9B0
		public static float GetIntensity(Light light) => default; // 0x000000018C3ACA18-0x000000018C3ACA80
		public static float GetSpotAngle(Light light) => default; // 0x000000018C3ACA80-0x000000018C3ACAE8
		public static float GetFallOffEnd(Light light) => default; // 0x000000018C3AC9B0-0x000000018C3ACA18
	}

	public static class SRPHelper // TypeDefIndex: 59944
	{
		// Fields
		private static RenderPipeline m_RenderPipelineCached; // 0x00
	
		// Properties
		public static RenderPipeline renderPipelineType { get; } // 0x0000000184BD1670-0x0000000184BD1710 
	
		// Nested types
		public enum RenderPipeline // TypeDefIndex: 59943
		{
			HGRP = 0,
			Undefined = 1,
			BuiltIn = 2,
			URP = 3,
			LWRP = 4,
			HDRP = 5
		}
	
		// Constructors
		static SRPHelper() {} // 0x0000000185FA40E0-0x0000000185FA4120
	
		// Methods
		private static RenderPipeline ComputeRenderPipeline() => default; // 0x00000001813AE580-0x00000001813AE590
		public static bool IsUsingCustomRenderPipeline() => default; // 0x00000001840A27C0-0x00000001840A27D0
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb) {} // 0x000000018C3AC890-0x000000018C3AC8DC
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb) {} // 0x000000018C3AC8DC-0x000000018C3AC928
	}

	public static class TransformUtils // TypeDefIndex: 59946
	{
		// Nested types
		public struct Packed // TypeDefIndex: 59945
		{
			// Fields
			public Vector3 position; // 0x00
			public Quaternion rotation; // 0x0C
			public Vector3 lossyScale; // 0x1C
	
			// Methods
			public bool IsSame(Transform transf) => default; // 0x000000018C3ACFE4-0x000000018C3AD070
		}
	
		// Methods
		public static Packed GetWorldPacked(Transform self) => default; // 0x000000018C3AC26C-0x000000018C3AC39C
	}

	public static class Utils // TypeDefIndex: 59948
	{
		// Fields
		private const float kEpsilon = 1E-05f; // Metadata: 0x0208249C
		private const int kFloatPackingHighMinShaderLevel = 35; // Metadata: 0x020824A0
		private static FloatPackingPrecision ms_FloatPackingPrecision; // 0x00
	
		// Nested types
		public enum FloatPackingPrecision // TypeDefIndex: 59947
		{
			Undef = 0,
			Low = 8,
			High = 64
		}
	
		// Methods
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle) => default; // 0x0000000185FEAEE0-0x0000000185FEAF20
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd) => default; // 0x0000000185FEAF20-0x0000000185FEAF50
		public static void Swap<T>(ref ref T a, ref ref T b) {}
		public static string GetPath(Transform current) => default; // 0x000000018C3AD3C4-0x000000018C3AD488
		public static T NewWithComponent<T>(string name)
			where T : Component => default;
		public static T GetOrAddComponent<T>(GameObject self)
			where T : Component => default;
		public static T GetOrAddComponent<T>(MonoBehaviour self)
			where T : Component => default;
		public static void ForeachComponentsOnlyInChildren<T>(GameObject self, Action<T> lambda, bool includeInactive = false /* Metadata: 0x0208248B */)
			where T : Component {}
		public static bool HasFlag(Enum mask, Enum flags) => default; // 0x000000018C3AD4E4-0x000000018C3AD560
		public static Vector2 xy(Vector3 aVector) => default; // 0x0000000185FB29D0-0x0000000185FB29F0
		public static Vector2 xz(Vector3 aVector) => default; // 0x0000000185FB2A20-0x0000000185FB2A40
		public static Vector2 yz(Vector3 aVector) => default; // 0x0000000185FB5840-0x0000000185FB5860
		public static Vector2 yx(Vector3 aVector) => default; // 0x0000000185FE0680-0x0000000185FE06A0
		public static Vector2 zx(Vector3 aVector) => default; // 0x0000000185FE1990-0x0000000185FE19B0
		public static Vector2 zy(Vector3 aVector) => default; // 0x0000000185FE1AF0-0x0000000185FE1B10
		public static bool Approximately(float a, float b, float epsilon = 1E-05f /* Metadata: 0x0208248C */) => default; // 0x00000001878CA664-0x00000001878CA678
		public static bool Approximately(Vector2 a, Vector2 b, float epsilon = 1E-05f /* Metadata: 0x02082490 */) => default; // 0x000000018C3AD070-0x000000018C3AD0A4
		public static bool Approximately(Vector3 a, Vector3 b, float epsilon = 1E-05f /* Metadata: 0x02082494 */) => default; // 0x000000018C3AD0A4-0x000000018C3AD108
		public static bool Approximately(Vector4 a, Vector4 b, float epsilon = 1E-05f /* Metadata: 0x02082498 */) => default; // 0x000000018C3AD108-0x000000018C3AD15C
		public static Vector4 AsVector4(Vector3 vec3, float w) => default; // 0x0000000185FEAEC0-0x0000000185FEAEE0
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt) => default; // 0x000000018C3AD67C-0x000000018C3AD6F0
		public static float GetVolumeCubic(Bounds self) => default; // 0x000000018C3AD488-0x000000018C3AD4E4
		public static float GetMaxArea2D(Bounds self) => default; // 0x000000018C3AD318-0x000000018C3AD3C4
		public static UnityEngine.Color Opaque(UnityEngine.Color self) => default; // 0x0000000185FEAF50-0x0000000185FEAF70
		public static UnityEngine.Color ComputeComplementaryColor(UnityEngine.Color self, bool blackAndWhite) => default; // 0x000000018C3AD204-0x000000018C3AD2A8
		public static Plane TranslateCustom(Plane plane, Vector3 translation) => default; // 0x000000018C3AD87C-0x000000018C3AD910
		public static Vector3 ClosestPointOnPlaneCustom(Plane plane, Vector3 point) => default; // 0x000000018C3AD15C-0x000000018C3AD204
		public static bool IsAlmostZero(float f) => default; // 0x000000018C3AD560-0x000000018C3AD578
		public static bool IsValid(Plane plane) => default; // 0x000000018C3AD578-0x000000018C3AD5A8
		public static void SetKeywordEnabled(Material mat, string name, bool enabled) {} // 0x000000018789EFF4-0x000000018789F028
		public static void SetShaderKeywordEnabled(string name, bool enabled) {} // 0x000000018C3AD858-0x000000018C3AD87C
		public static Matrix4x4 SampleInMatrix(Gradient self, int floatPackingPrecision) => default; // 0x000000018C3AD7B4-0x000000018C3AD858
		public static UnityEngine.Color[] SampleInArray(Gradient self, int samplesCount) => default; // 0x000000018C3AD6F0-0x000000018C3AD7B4
		private static Vector4 Vector4_Floor(Vector4 vec) => default; // 0x0000000185FDB980-0x0000000185FDB9E0
		public static float PackToFloat(UnityEngine.Color color, int floatPackingPrecision) => default; // 0x000000018C3AD5A8-0x000000018C3AD67C
		public static FloatPackingPrecision GetFloatPackingPrecision() => default; // 0x000000018C3AD2A8-0x000000018C3AD318
		public static void MarkCurrentSceneDirty() {} // 0x0000000185492010-0x0000000185492020
		public static void MarkObjectDirty(UnityEngine.Object obj) {} // 0x0000000185492010-0x0000000185492020
	}

	public static class Version // TypeDefIndex: 59949
	{
		// Fields
		public const int Current = 1991; // Metadata: 0x020824A5
	}

	public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 59951
	{
		// Fields
		public PlatformLayers platformLayers; // 0x18
		public const string ClassName = "VolumetricLightBeam"; // Metadata: 0x020824A7
		public bool colorFromLight; // 0x1C
		public ColorMode colorMode; // 0x20
		public UnityEngine.Color color; // 0x24
		public Gradient colorGradient; // 0x38
		public bool intensityFromLight; // 0x40
		public bool intensityModeAdvanced; // 0x41
		public float intensityInside; // 0x44
		public float intensityOutside; // 0x48
		public float intensityMultiplier; // 0x4C
		public float hdrpExposureWeight; // 0x50
		public BlendingMode blendingMode; // 0x54
		public bool spotAngleFromLight; // 0x58
		public float spotAngle; // 0x5C
		public float spotAngleMultiplier; // 0x60
		public float coneRadiusStart; // 0x64
		public ShaderAccuracy shaderAccuracy; // 0x68
		public MeshType geomMeshType; // 0x6C
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
		public float attenuationCustomBlending; // 0xB8
		public float fallOffStart; // 0xBC
		public float fallOffEnd; // 0xC0
		public bool fallOffEndFromLight; // 0xC4
		private Light m_CachedLightSpot; // 0xC8
		public float fallOffCap; // 0xD0
		public float fallOffEndMultiplier; // 0xD4
		public bool depthBlendCapOff; // 0xD8
		public float depthBlendDistance; // 0xDC
		public float cameraClippingDistance; // 0xE0
		public float glareFrontal; // 0xE4
		public float glareBehind; // 0xE8
		public float fresnelPow; // 0xEC
		public NoiseMode noiseMode; // 0xF0
		public float noiseIntensity; // 0xF4
		public bool noiseScaleUseGlobal; // 0xF8
		public bool noiseScaleUseSeparateAxis; // 0xF9
		public Vector3 noiseScalesLocal; // 0xFC
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
		private int pluginVersion; // 0x13C
		private bool _TrackChangesDuringPlaytime; // 0x140
		private int _SortingLayerID; // 0x144
		private int _SortingOrder; // 0x148
		private float _FadeOutBegin; // 0x14C
		private float _FadeOutEnd; // 0x150
		private uint __INTERNAL_InstancedMaterialGroupID_k__BackingField; // 0x154
		public BeamGeometry m_BeamGeom; // 0x158
		public bool matIsPersistent; // 0x160
		private Coroutine m_CoPlaytimeUpdate; // 0x168
		private Vector3 m_CachedClippingPlanePosition; // 0x170
		private Quaternion m_CachedClippingPlaneRotation; // 0x17C
		private bool m_HasCachedClippingPlanePose; // 0x18C
	
		// Properties
		public ColorMode usedColorMode { get => default; } // 0x000000018C3AEDD0-0x000000018C3AEE04 
		private bool useColorFromAttachedLightSpot { get => default; } // 0x000000018C3AEC20-0x000000018C3AEC78 
		private bool useColorTemperatureFromAttachedLightSpot { get => default; } // 0x000000018C3AEC78-0x000000018C3AECC4 
		public float alphaInside { get => default; set {} } // 0x0000000185FB05A0-0x0000000185FB05B0 0x0000000185FB0600-0x0000000185FB0610
		public float alphaOutside { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FBCE20-0x0000000185FBCE30
		public float intensityGlobal { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x0000000185FEAFB0-0x0000000185FEAFC0
		public bool useIntensityFromAttachedLightSpot { get => default; } // 0x000000018C3AED20-0x000000018C3AED78 
		public bool useSpotAngleFromAttachedLightSpot { get => default; } // 0x000000018C3AED78-0x000000018C3AEDD0 
		public float coneAngle { get => default; } // 0x000000018C3AE100-0x000000018C3AE158 
		public float coneRadiusEnd { get => default; set {} } // 0x000000018C3AE2C0-0x000000018C3AE320 0x000000018C3AEE04-0x000000018C3AEE58
		public float coneVolume { get => default; } // 0x000000018C3AE320-0x000000018C3AE370 
		public float coneApexOffsetZ { get => default; } // 0x000000018C3AE158-0x000000018C3AE1C8 
		public Vector3 coneApexPositionLocal { get => default; } // 0x000000018C3AE290-0x000000018C3AE2C0 
		public Vector3 coneApexPositionGlobal { get => default; } // 0x000000018C3AE1C8-0x000000018C3AE290 
		public int geomSides { get => default; set {} } // 0x000000018C3AE3BC-0x000000018C3AE3E8 0x000000018C3AEEB8-0x000000018C3AEF18
		public int geomSegments { get => default; set {} } // 0x000000018C3AE390-0x000000018C3AE3BC 0x000000018C3AEE58-0x000000018C3AEEB8
		public Vector3 skewingLocalForwardDirectionNormalized { get => default; } // 0x000000018C3AEB14-0x000000018C3AEC10 
		public bool canHaveMeshSkewing { get => default; } // 0x00000001840A27C0-0x00000001840A27D0 
		public bool hasMeshSkewing { get => default; } // 0x000000018C3AE43C-0x000000018C3AE4A8 
		public Vector4 additionalClippingPlane { get => default; } // 0x000000018C3ADBF8-0x000000018C3ADDB8 
		public float attenuationLerpLinearQuad { get => default; } // 0x000000018C3ADDB8-0x000000018C3ADDE0 
		public float fadeStart { get => default; set {} } // 0x0000000185FB9B20-0x0000000185FB9B30 0x0000000185FD26D0-0x0000000185FD26E0
		public float fadeEnd { get => default; set {} } // 0x0000000185FBECC0-0x0000000185FBECD0 0x0000000185FBECF0-0x0000000185FBED00
		public bool fadeEndFromLight { get => default; set {} } // 0x0000000185FB99D0-0x0000000185FB99E0 0x0000000185FCD9F0-0x0000000185FCDA00
		public Light lightSpotAttached { get => default; } // 0x0000000185FB0300-0x0000000185FB0310 
		public bool useFallOffEndFromAttachedLightSpot { get => default; } // 0x000000018C3AECC4-0x000000018C3AED20 
		public float maxGeometryDistance { get => default; } // 0x000000018C3AE634-0x000000018C3AE664 
		public bool isNoiseEnabled { get => default; } // 0x000000018C3AE4D8-0x000000018C3AE4E4 
		public bool noiseEnabled { get => default; set {} } // 0x000000018C3AE4D8-0x000000018C3AE4E4 0x000000018C3AEF18-0x000000018C3AEF38
		public float cullingDistance { get => default; } // 0x000000018C3AE370-0x000000018C3AE390 
		public float fadeOutBegin { get => default; set {} } // 0x0000000185FB8E50-0x0000000185FB8E60 0x0000000185FEAF90-0x0000000185FEAFA0
		public float fadeOutEnd { get => default; set {} } // 0x0000000185FB9A40-0x0000000185FB9A50 0x0000000185FEAFA0-0x0000000185FEAFB0
		public bool isFadeOutEnabled { get => default; } // 0x000000018C3AE4B4-0x000000018C3AE4D8 
		public bool isTilted { get => default; } // 0x000000018C3AE4E4-0x000000018C3AE544 
		public int sortingLayerID { get => default; set {} } // 0x0000000185FD6F70-0x0000000185FD6F80 0x000000018C3AEF38-0x000000018C3AEFBC
		public string sortingLayerName { get => default; set {} } // 0x000000018C3AEC10-0x000000018C3AEC20 0x000000018C3AEFBC-0x000000018C3AEFE4
		public int sortingOrder { get => default; set {} } // 0x0000000181ABEDE0-0x0000000181ABEDF0 0x000000018C3AEFE4-0x000000018C3AF068
		public bool trackChangesDuringPlaytime { get => default; set {} } // 0x0000000185FB8EC0-0x0000000185FB8ED0 0x0000000185FEAFC0-0x0000000185FEAFD0
		public bool isCurrentlyTrackingChanges { get => default; } // 0x000000018C3AE4A8-0x000000018C3AE4B4 
		public bool hasGeometry { get => default; } // 0x000000018C3AE3E8-0x000000018C3AE43C 
		public Bounds bounds { get => default; } // 0x000000018C3AE004-0x000000018C3AE100 
		public int blendingModeAsInt { get => default; } // 0x000000018C3ADF58-0x000000018C3AE004 
		public Quaternion beamInternalLocalRotation { get => default; } // 0x000000018C3ADE98-0x000000018C3ADF1C 
		public Vector3 beamLocalForward { get => default; } // 0x000000018C3ADF1C-0x000000018C3ADF58 
		public Vector3 beamGlobalForward { get => default; } // 0x000000018C3ADDE0-0x000000018C3ADE98 
		public Vector3 lossyScale { get => default; } // 0x000000018C3AE544-0x000000018C3AE634 
		public float raycastDistance { get => default; } // 0x000000018C3AE948-0x000000018C3AE9F0 
		public Vector3 raycastGlobalForward { get => default; } // 0x000000018C3AE9F0-0x000000018C3AEA74 
		public Vector3 raycastGlobalUp { get => default; } // 0x000000018C3AEAC4-0x000000018C3AEB14 
		public Vector3 raycastGlobalRight { get => default; } // 0x000000018C3AEA74-0x000000018C3AEAC4 
		public int _INTERNAL_pluginVersion { get => default; } // 0x0000000185FB1180-0x0000000185FB1190 
		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; } // 0x0000000185FBA220-0x0000000185FBA230 0x0000000185FEAF80-0x0000000185FEAF90
		public string meshStats { get => default; } // 0x000000018C3AE664-0x000000018C3AE7D8 
		public int meshVerticesCount { get => default; } // 0x000000018C3AE89C-0x000000018C3AE948 
		public int meshTrianglesCount { get => default; } // 0x000000018C3AE7D8-0x000000018C3AE89C 
	
		// Nested types
		public enum AttachedLightType // TypeDefIndex: 59950
		{
			NoLight = 0,
			OtherLight = 1,
			SpotLight = 2
		}
	
		// Constructors
		public VolumetricLightBeam() {} // 0x000000018C3ADA04-0x000000018C3ADBF8
	
		// Methods
		public void GetInsideAndOutsideIntensity(out float inside, out float outside) {
			inside = default;
			outside = default;
		} // 0x000000018C3AD9E0-0x000000018C3ADA04
		private Vector3 ComputeRaycastGlobalVector(Vector3 localVec) => default; // 0x000000018C3AD910-0x000000018C3AD9E0
		private void SetFadeOutValue(ref float propToChange, float value) {} // 0x0000000185FEAF70-0x0000000185FEAF80
	}
}
