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

// Image 78: VolumetricLightBeam.dll - Assembly: VolumetricLightBeam, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89768-89837

public static class EditorPrefsStrings // TypeDefIndex: 89769
{
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 89834
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D; // 0x00 // Static value (base64): AQAAAAEAAAAKAAAA - Metadata: 0x0264A8E8
	internal static readonly __StaticArrayInitTypeSize_12 F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B; // 0x0C // Static value (base64): AQAAAAQAAAAFAAAA - Metadata: 0x0264A8F8

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 89833
	{
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 89771
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 89772
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 89773
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 89774
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 89775
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 89776
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 89777
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 89770
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 89835
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D9C1A20-0x000000018D9C1A84
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 89836
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D9C1A84-0x000000018D9C1B1C
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 89837
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D9C51EC-0x000000018D9C5250
		public static bool IsPatched(int id); // 0x000000018D9C52DC-0x000000018D9C5374
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D9C50A4-0x000000018D9C5170
		public object CreateWrapper(int id); // 0x000000018D9C5170-0x000000018D9C51EC
		public object InitWrapperArray(int len); // 0x000000018D9C5250-0x000000018D9C52DC
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D9C5000-0x000000018D9C50A4
	}
}

namespace VLB
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface // TypeDefIndex: 89778
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
		public MeshRenderer meshRenderer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829CD170-0x00000001829CD180 0x0000000188800CC0-0x0000000188800CD0
		public MeshFilter meshFilter { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828D49D0-0x00000001828D49E0 0x00000001870EAAE0-0x00000001870EAAF0
		public Mesh coneMesh { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232F50-0x0000000187232F60 0x0000000188800C74-0x0000000188800C88
		private bool visible { get; set; } // 0x000000018D9C13BC-0x000000018D9C13DC 0x000000018D9C141C-0x000000018D9C1498
		public int sortingLayerID { get; set; } // 0x000000018D9C137C-0x000000018D9C139C 0x000000018D9C13DC-0x000000018D9C13FC
		public int sortingOrder { get; set; } // 0x000000018D9C139C-0x000000018D9C13BC 0x000000018D9C13FC-0x000000018D9C141C
		public float sortingFudge { get; set; } // 0x0000000184F79F80-0x0000000184F79FE0 0x0000000184F79FE0-0x0000000184F7A050
		public bool _INTERNAL_IsFadeOutCoroutineRunning { get; } // 0x000000018D9C1370-0x000000018D9C137C 
	
		// Constructors
		public BeamGeometry(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void RestartFadeOutCoroutine(); // 0x0000000186805BA0-0x0000000186805BB0
		public void StopFadeOutCoroutine(); // 0x0000000186805BA0-0x0000000186805BB0
		public void SetMaterialProp(int nameID, float value); // 0x000000018D9C12A4-0x000000018D9C1370
		public void SetMaterialProp(int nameID, Vector4 value); // 0x000000018D9C1020-0x000000018D9C1100
		public void SetMaterialProp(int nameID, UnityEngine.Color value); // 0x000000018D9C1100-0x000000018D9C11E0
		public void SetMaterialProp(int nameID, Matrix4x4 value); // 0x000000018D9C0F08-0x000000018D9C1020
		public void SetMaterialProp(int nameID, Texture value); // 0x000000018D9C11E0-0x000000018D9C12A4
	}

	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject // TypeDefIndex: 89779
	{
		// Fields
		public const string ClassName = "Config"; // Metadata: 0x0264A44B
		public const string kAssetName = "VLBConfigOverride"; // Metadata: 0x0264A452
		public const string kAssetNameExt = ".asset"; // Metadata: 0x0264A464
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
		public VLB.RenderPipeline renderPipeline { get; } // 0x0000000182271A70-0x0000000182271A80 
		public RenderingMode renderingMode { get; } // 0x00000001829600C0-0x00000001829600D0 
		public RenderingMode actualRenderingMode { get; } // 0x000000018D9C18D0-0x000000018D9C18EC 
		public bool useSinglePassShader { get; } // 0x000000018D9C1960-0x000000018D9C1978 
		public bool requiresDoubleSidedMesh { get; } // 0x000000018D9C1960-0x000000018D9C1978 
		public Shader beamShader { get; } // 0x0000000187232C70-0x0000000187232C80 
		public Transform fadeOutCameraTransform { get; } // 0x000000018D9C18EC-0x000000018D9C1958 
		public bool isHDRPExposureWeightSupported { get; } // 0x000000018D9C1958-0x000000018D9C1960 
		public bool hasRenderPipelineMismatch { get; } // 0x00000001859D62E0-0x00000001859D6350 
		public static Config Instance { get; } // 0x0000000187838CE4-0x0000000187838CF0 
	
		// Constructors
		public Config(); // 0x0000000187029CF0-0x0000000187029E10
	
		// Methods
		public void Reset(); // 0x000000018D9C17C8-0x000000018D9C18D0
		private void OnEnable(); // 0x000000018722B760-0x000000018722B770
		public bool IsSRPBatcherSupported(); // 0x00000001843FFFF0-0x0000000184400000
		public void ForceUpdateFadeOutCamera(); // 0x000000018D9C1498-0x000000018D9C151C
		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup(); // 0x00000001859D6240-0x00000001859D62E0
		private void RefreshGlobalShaderProperties(); // 0x00000001859D6860-0x00000001859D6940
		public void ResetInternalData(); // 0x000000018D9C1654-0x000000018D9C17C8
		public ParticleSystem NewVolumetricDustParticles(); // 0x000000018D9C151C-0x000000018D9C1654
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion); // 0x000000018722B770-0x000000018722B780
		private static Config LoadAssetInternal(string assetName); // 0x0000000186DDBE60-0x0000000186DDBEA0
		private static Config GetInstance(bool assertIfNotFound); // 0x0000000186DDBC80-0x0000000186DDBE60
	}

	public static class Consts // TypeDefIndex: 89786
	{
		// Fields
		public const string PluginFolder = "Plugins/VolumetricLightBeam"; // Metadata: 0x0264A46B
	
		// Nested types
		public static class Help // TypeDefIndex: 89780
		{
			// Fields
			private const string UrlBase = "http://saladgamer.com/vlb-doc/"; // Metadata: 0x0264A487
			private const string UrlSuffix = "/"; // Metadata: 0x0264A4A6
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/"; // Metadata: 0x0264A4A8
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/"; // Metadata: 0x0264A4D6
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/"; // Metadata: 0x0264A508
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/"; // Metadata: 0x0264A544
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/"; // Metadata: 0x0264A581
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/"; // Metadata: 0x0264A5B1
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/"; // Metadata: 0x0264A5E3
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/"; // Metadata: 0x0264A616
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/"; // Metadata: 0x0264A647
		}
	
		public static class Internal // TypeDefIndex: 89781
		{
			// Properties
			public static HideFlags ProceduralObjectsHideFlags { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		}
	
		public static class Beam // TypeDefIndex: 89782
		{
			// Fields
			public const ColorMode ColorModeDefault = ColorMode.Flat; // Metadata: 0x0264A66D
			public const float MultiplierDefault = 1f; // Metadata: 0x0264A66E
			public const float MultiplierMin = 0f; // Metadata: 0x0264A672
			public const float IntensityDefault = 1f; // Metadata: 0x0264A676
			public const float IntensityMin = 0f; // Metadata: 0x0264A67A
			public const float HDRPExposureWeightDefault = 0f; // Metadata: 0x0264A67E
			public const float HDRPExposureWeightMin = 0f; // Metadata: 0x0264A682
			public const float HDRPExposureWeightMax = 1f; // Metadata: 0x0264A686
			public const float SpotAngleDefault = 35f; // Metadata: 0x0264A68A
			public const float SpotAngleMin = 0.1f; // Metadata: 0x0264A68E
			public const float SpotAngleMax = 179.9f; // Metadata: 0x0264A692
			public const float ConeRadiusStart = 0f; // Metadata: 0x0264A696
			public const MeshType GeomMeshType = MeshType.Shared; // Metadata: 0x0264A69A
			public const int GeomSidesDefault = 18; // Metadata: 0x0264A69B
			public const int GeomSidesMin = 3; // Metadata: 0x0264A69C
			public const int GeomSidesMax = 256; // Metadata: 0x0264A69D
			public const int GeomSegmentsDefault = 5; // Metadata: 0x0264A69F
			public const int GeomSegmentsMin = 0; // Metadata: 0x0264A6A0
			public const int GeomSegmentsMax = 64; // Metadata: 0x0264A6A1
			public const bool GeomCap = false; // Metadata: 0x0264A6A3
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic; // Metadata: 0x0264A6A4
			public const float AttenuationCustomBlendingDefault = 0.5f; // Metadata: 0x0264A6A5
			public const float AttenuationCustomBlendingMin = 0f; // Metadata: 0x0264A6A9
			public const float AttenuationCustomBlendingMax = 1f; // Metadata: 0x0264A6AD
			public const float FallOffStart = 0f; // Metadata: 0x0264A6B1
			public const float FallOffEnd = 3f; // Metadata: 0x0264A6B5
			public const float FallOffDistancesMinThreshold = 0.01f; // Metadata: 0x0264A6B9
			public const float DepthBlendDistance = 2f; // Metadata: 0x0264A6BD
			public const float CameraClippingDistance = 0.5f; // Metadata: 0x0264A6C1
			public const float FresnelPowMaxValue = 10f; // Metadata: 0x0264A6C5
			public const float FresnelPow = 8f; // Metadata: 0x0264A6C9
			public const float GlareFrontalDefault = 0f; // Metadata: 0x0264A6CD
			public const float GlareBehindDefault = 0f; // Metadata: 0x0264A6D1
			public const float GlareMin = 0f; // Metadata: 0x0264A6D5
			public const float GlareMax = 1f; // Metadata: 0x0264A6D9
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled; // Metadata: 0x0264A6DD
			public const float NoiseIntensityMin = 0f; // Metadata: 0x0264A6DE
			public const float NoiseIntensityMax = 1f; // Metadata: 0x0264A6E2
			public const float NoiseIntensityDefault = 0.5f; // Metadata: 0x0264A6E6
			public const float NoiseScaleMin = 0.01f; // Metadata: 0x0264A6EA
			public const float NoiseScaleMax = 2f; // Metadata: 0x0264A6EE
			public static readonly Vector3 NoiseScalesDefault; // 0x00
			public const float NoiseContrastDefault = 0f; // Metadata: 0x0264A6F2
			public const float NoiseContrastMin = -5f; // Metadata: 0x0264A6F6
			public const float NoiseContrastMax = 5f; // Metadata: 0x0264A6FA
			public const float NoiseScaleDefault = 0.5f; // Metadata: 0x0264A6FE
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive; // Metadata: 0x0264A702
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.High; // Metadata: 0x0264A703
			public const float FadeOutBeginDefault = 256f; // Metadata: 0x0264A704
			public const float FadeOutEndDefault = 200f; // Metadata: 0x0264A708
			public const float FadeOutBeginSecondDefault = 0f; // Metadata: 0x0264A70C
			public const float FadeOutEndSecondDefault = 0f; // Metadata: 0x0264A710
			public const Dimensions DimensionsDefault = Dimensions.Dim3D; // Metadata: 0x0264A714
			public const Transform ClippingPlaneTransformDefault = null; // Metadata: 0x00000000
			public static readonly UnityEngine.Color FlatColor; // 0x0C
			public static readonly Vector3 NoiseVelocityDefault; // 0x1C
			public static readonly Vector2 TiltDefault; // 0x28
			public static readonly Vector3 SkewingLocalForwardDirectionDefault; // 0x30
	
			// Constructors
			static Beam(); // 0x0000000186FB6580-0x0000000186FB6660
		}
	
		public static class DustParticles // TypeDefIndex: 89783
		{
			// Fields
			public const float AlphaDefault = 0.5f; // Metadata: 0x0264A715
			public const float SizeDefault = 0.01f; // Metadata: 0x0264A719
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random; // Metadata: 0x0264A71D
			public const float DensityDefault = 5f; // Metadata: 0x0264A71E
			public const float DensityMin = 0f; // Metadata: 0x0264A722
			public const float DensityMax = 1000f; // Metadata: 0x0264A726
			public const bool CullingEnabledDefault = false; // Metadata: 0x0264A72A
			public const float CullingMaxDistanceDefault = 10f; // Metadata: 0x0264A72B
			public const float CullingMaxDistanceMin = 1f; // Metadata: 0x0264A72F
			public static readonly Vector3 VelocityDefault; // 0x00
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault; // 0x0C
	
			// Constructors
			static DustParticles(); // 0x000000018D9C1978-0x000000018D9C19E4
		}
	
		public static class DynOcclusion // TypeDefIndex: 89784
		{
			// Fields
			public const float FadeDistanceToSurfaceDefault = 0.25f; // Metadata: 0x0264A733
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames; // Metadata: 0x0264A737
			public const int WaitFramesCountDefault = 3; // Metadata: 0x0264A738
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D; // Metadata: 0x0264A739
			public const bool RaycastingConsiderTriggersDefault = false; // Metadata: 0x0264A73A
			public const float RaycastingMinOccluderAreaDefault = 0f; // Metadata: 0x0264A73B
			public const float RaycastingMinSurfaceRatioDefault = 0.5f; // Metadata: 0x0264A73F
			public const float RaycastingMinSurfaceRatioMin = 50f; // Metadata: 0x0264A743
			public const float RaycastingMinSurfaceRatioMax = 100f; // Metadata: 0x0264A747
			public const float RaycastingMaxSurfaceDotDefault = 0.25f; // Metadata: 0x0264A74B
			public const float RaycastingMaxSurfaceAngleMin = 45f; // Metadata: 0x0264A74F
			public const float RaycastingMaxSurfaceAngleMax = 90f; // Metadata: 0x0264A753
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface; // Metadata: 0x0264A757
			public const float RaycastingPlaneOffsetDefault = 0.1f; // Metadata: 0x0264A758
			public const int DepthBufferDepthMapResolutionDefault = 32; // Metadata: 0x0264A75C
			public const bool DepthBufferOcclusionCullingDefault = true; // Metadata: 0x0264A75D
			public static readonly LayerMask LayerMaskDefault; // 0x00
	
			// Constructors
			static DynOcclusion(); // 0x000000018D9C19E4-0x000000018D9C1A20
		}
	
		public static class Config // TypeDefIndex: 89785
		{
			// Fields
			public const bool GeometryOverrideLayerDefault = true; // Metadata: 0x0264A75E
			public const int GeometryLayerIDDefault = 1; // Metadata: 0x0264A75F
			public const string GeometryTagDefault = "Untagged"; // Metadata: 0x0264A760
			public const string FadeOutCameraTagDefault = "MainCamera"; // Metadata: 0x0264A769
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent; // Metadata: 0x0264A774
			public const VLB.RenderPipeline GeometryRenderPipelineDefault = VLB.RenderPipeline.HGRP; // Metadata: 0x0264A776
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass; // Metadata: 0x0264A777
			public const int Noise3DSizeDefault = 64; // Metadata: 0x0264A778
			public const int SharedMeshSides = 24; // Metadata: 0x0264A77A
			public const int SharedMeshSegments = 5; // Metadata: 0x0264A77B
			public const float DitheringFactor = 0f; // Metadata: 0x0264A77C
			public const bool UseLightColorTemperatureDefault = true; // Metadata: 0x0264A780
			public const bool FeatureEnabledDefault = true; // Metadata: 0x0264A781
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly; // Metadata: 0x0264A782
		}
	}

	public static class DummyMaterial // TypeDefIndex: 89787
	{
	}

	public enum FeatureEnabledColorGradient // TypeDefIndex: 89788
	{
		Off = 0,
		HighOnly = 1,
		HighAndLow = 2
	}

	public enum ColorMode // TypeDefIndex: 89789
	{
		Flat = 0,
		Gradient = 1
	}

	public enum AttenuationEquation // TypeDefIndex: 89790
	{
		Linear = 0,
		Quadratic = 1,
		Blend = 2
	}

	public enum BlendingMode // TypeDefIndex: 89791
	{
		Additive = 0,
		SoftAdditive = 1,
		TraditionalTransparency = 2
	}

	public enum ShaderAccuracy // TypeDefIndex: 89792
	{
		Fast = 0,
		High = 1
	}

	public enum NoiseMode // TypeDefIndex: 89793
	{
		Disabled = 0,
		WorldSpace = 1,
		LocalSpace = 2
	}

	public enum MeshType // TypeDefIndex: 89794
	{
		Shared = 0,
		Custom = 1
	}

	public enum RenderPipeline // TypeDefIndex: 89795
	{
		HGRP = 0,
		BuiltIn = 1,
		URP = 2,
		HDRP = 3
	}

	public enum RenderingMode // TypeDefIndex: 89796
	{
		MultiPass = 0,
		SinglePass = 1,
		GPUInstancing = 2,
		SRPBatcher = 3
	}

	public enum RenderQueue // TypeDefIndex: 89797
	{
		Custom = 0,
		Background = 1000,
		Geometry = 2000,
		AlphaTest = 2450,
		GeometryLast = 2500,
		Transparent = 3000,
		Overlay = 4000
	}

	public enum Dimensions // TypeDefIndex: 89798
	{
		Dim3D = 0,
		Dim2D = 1
	}

	public enum PlaneAlignment // TypeDefIndex: 89799
	{
		Surface = 0,
		Beam = 1
	}

	[Flags]
	public enum DynamicOcclusionUpdateRate // TypeDefIndex: 89800
	{
		Never = 1,
		OnEnable = 2,
		OnBeamMove = 4,
		EveryXFrames = 8,
		OnBeamMoveAndEveryXFrames = 12
	}

	public enum ParticlesDirection // TypeDefIndex: 89801
	{
		Random = 0,
		LocalSpace = 1,
		WorldSpace = 2
	}

	public sealed class HighlightNullAttribute : PropertyAttribute // TypeDefIndex: 89802
	{
		// Constructors
		public HighlightNullAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class MaterialManager // TypeDefIndex: 89812
	{
		// Fields
		public const int staticPropertiesCount = 432; // Metadata: 0x0264A7B6
		public static MaterialPropertyBlock materialPropertyBlock; // 0x00
		private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor; // 0x08
		private static readonly UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor; // 0x10
		private static readonly bool[] BlendingMode_AlphaAsBlack; // 0x18
		private static readonly Hashtable ms_MaterialsGroup; // 0x20
	
		// Nested types
		public enum BlendingMode // TypeDefIndex: 89803
		{
			Additive = 0,
			SoftAdditive = 1,
			TraditionalTransparency = 2,
			Count = 3
		}
	
		public enum ColorGradient // TypeDefIndex: 89804
		{
			Off = 0,
			MatrixLow = 1,
			MatrixHigh = 2,
			Count = 3
		}
	
		public enum DepthBlend // TypeDefIndex: 89805
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum DynamicOcclusion // TypeDefIndex: 89806
		{
			Off = 0,
			ClippingPlane = 1,
			DepthTexture = 2,
			Count = 3
		}
	
		public enum MeshSkewing // TypeDefIndex: 89807
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum Noise3D // TypeDefIndex: 89808
		{
			Off = 0,
			On = 1,
			Count = 2
		}
	
		public enum ShaderAccuracy // TypeDefIndex: 89809
		{
			Fast = 0,
			High = 1,
			Count = 2
		}
	
		public struct StaticProperties // TypeDefIndex: 89810
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
			private int blendingModeID { get; } // 0x00000001872342E0-0x00000001872342F0 
			private int noise3DID { get; } // 0x000000018D9C2E30-0x000000018D9C2E64 
			private int depthBlendID { get; } // 0x000000018D9C2CF4-0x000000018D9C2D28 
			private int colorGradientID { get; } // 0x000000018D9C2CC0-0x000000018D9C2CF4 
			private int dynamicOcclusionID { get; } // 0x000000018D9C2D28-0x000000018D9C2D5C 
			private int meshSkewingID { get; } // 0x000000018D9C2DFC-0x000000018D9C2E30 
			private int shaderAccuracyID { get; } // 0x000000018D9C2E64-0x000000018D9C2E98 
			public int materialID { get; } // 0x000000018D9C2D5C-0x000000018D9C2DFC 
	
			// Methods
			public void ApplyToMaterial(Material mat); // 0x000000018D9C299C-0x000000018D9C2CC0
		}
	
		private class MaterialsGroup // TypeDefIndex: 89811
		{
			// Fields
			public readonly Material[] materials; // 0x10
	
			// Constructors
			public MaterialsGroup(); // 0x000000018D9C209C-0x000000018D9C20E4
		}
	
		// Constructors
		static MaterialManager(); // 0x000000018D9C1E8C-0x000000018D9C209C
	
		// Methods
		public static Material NewMaterialTransient(bool gpuInstanced); // 0x000000018D9C1DCC-0x000000018D9C1E8C
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced); // 0x000000018D9C1D10-0x000000018D9C1DCC
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps); // 0x000000018D9C1B1C-0x000000018D9C1D10
	}

	public static class MaterialModifier // TypeDefIndex: 89815
	{
		// Nested types
		public delegate void Callback(Interface owner); // TypeDefIndex: 89813; 0x0000000185B78EA0-0x0000000185B78EB0
	
		public interface Interface // TypeDefIndex: 89814
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
	public struct MinMaxRangeFloat // TypeDefIndex: 89816
	{
		// Fields
		[SerializeField]
		private float m_MinValue; // 0x00
		[SerializeField]
		private float m_MaxValue; // 0x04
	
		// Properties
		public float minValue { get; } // 0x00000001872342D0-0x00000001872342E0 
		public float maxValue { get; } // 0x000000018724A6D0-0x000000018724A6E0 
		public float randomValue { get; } // 0x000000018D9C20F8-0x000000018D9C210C 
		public Vector2 asVector2 { get; } // 0x00000001872358F0-0x0000000187235910 
	
		// Constructors
		public MinMaxRangeFloat(float min, float max); // 0x0000000187234A10-0x0000000187234A20
	
		// Methods
		public float GetLerpedValue(float lerp01); // 0x000000018D9C20E4-0x000000018D9C20F8
	}

	public class MinMaxRangeAttribute : Attribute // TypeDefIndex: 89817
	{
		// Fields
		[CompilerGenerated]
		private readonly float _minValue_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly float _maxValue_k__BackingField; // 0x14
	
		// Properties
		public float minValue { [CompilerGenerated] get; } // 0x0000000187232D00-0x0000000187232D10 
		public float maxValue { [CompilerGenerated] get; } // 0x0000000187235C60-0x0000000187235C70 
	
		// Constructors
		public MinMaxRangeAttribute(float min, float max); // 0x0000000187240DF0-0x0000000187240E00
	}

	public class PlatformHelper // TypeDefIndex: 89818
	{
		// Constructors
		public PlatformHelper(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static string GetCurrentPlatformSuffix(); // 0x0000000186DDBEA0-0x0000000186DDBEC0
		private static string GetPlatformSuffix(RuntimePlatform platform); // 0x0000000186DDBEC0-0x0000000186DDBF10
	}

	public class PolygonHelper : MonoBehaviour // TypeDefIndex: 89820
	{
		// Nested types
		public struct Plane2D // TypeDefIndex: 89819
		{
			// Fields
			public Vector2 normal; // 0x00
			public float distance; // 0x08
	
			// Methods
			public float Distance(Vector2 point); // 0x0000000187264370-0x00000001872643A0
			public Vector2 ClosestPoint(Vector2 pt); // 0x000000018D9C223C-0x000000018D9C2298
			public Vector2 Intersect(Vector2 p1, Vector2 p2); // 0x000000018D9C25C0-0x000000018D9C2680
			public bool GetSide(Vector2 point); // 0x000000018D9C25A4-0x000000018D9C25C0
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2); // 0x000000018D9C24E4-0x000000018D9C25A4
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1); // 0x000000018D9C2494-0x000000018D9C24E4
			public void Flip(); // 0x000000018D9C2444-0x000000018D9C2494
			public Vector2[] CutConvex(Vector2[] poly); // 0x000000018D9C2298-0x000000018D9C2444
			public override string ToString(); // 0x000000018D9C2680-0x000000018D9C2744
		}
	
		// Constructors
		public PolygonHelper(); // 0x00000001878364A0-0x00000001878364B8
	}

	public static class ShaderKeywords // TypeDefIndex: 89821
	{
		// Fields
		public const string UseFog = "VLB_USE_FOG"; // Metadata: 0x0264A7D0
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK"; // Metadata: 0x0264A7DC
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW"; // Metadata: 0x0264A7EF
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH"; // Metadata: 0x0264A80D
		public const string DepthBlend = "VLB_DEPTH_BLEND"; // Metadata: 0x0264A82C
		public const string Noise3D = "VLB_NOISE_3D"; // Metadata: 0x0264A83C
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE"; // Metadata: 0x0264A849
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE"; // Metadata: 0x0264A866
		public const string MeshSkewing = "VLB_MESH_SKEWING"; // Metadata: 0x0264A882
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH"; // Metadata: 0x0264A893
	}

	public static class ShaderProperties // TypeDefIndex: 89822
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
		static ShaderProperties(); // 0x0000000186B42240-0x0000000186B42B90
	}

	public static class SpotLightHelper // TypeDefIndex: 89823
	{
		// Methods
		public static void GetCullingDistance(Light light, ref float cullingDistance, ref float falloffDistance); // 0x000000018D9C27DC-0x000000018D9C2864
		public static float GetIntensity(Light light); // 0x000000018D9C28CC-0x000000018D9C2934
		public static float GetSpotAngle(Light light); // 0x000000018D9C2934-0x000000018D9C299C
		public static float GetFallOffEnd(Light light); // 0x000000018D9C2864-0x000000018D9C28CC
	}

	public static class SRPHelper // TypeDefIndex: 89825
	{
		// Fields
		private static RenderPipeline m_RenderPipelineCached; // 0x00
	
		// Properties
		public static RenderPipeline renderPipelineType { get; } // 0x00000001859D6350-0x00000001859D63F0 
	
		// Nested types
		public enum RenderPipeline // TypeDefIndex: 89824
		{
			HGRP = 0,
			Undefined = 1,
			BuiltIn = 2,
			URP = 3,
			LWRP = 4,
			HDRP = 5
		}
	
		// Constructors
		static SRPHelper(); // 0x000000018721FC70-0x000000018721FCB0
	
		// Methods
		private static RenderPipeline ComputeRenderPipeline(); // 0x0000000185829EC0-0x0000000185829ED0
		public static bool IsUsingCustomRenderPipeline(); // 0x00000001851A4410-0x00000001851A4420
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb); // 0x000000018D9C2744-0x000000018D9C2790
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb); // 0x000000018D9C2790-0x000000018D9C27DC
	}

	public static class TransformUtils // TypeDefIndex: 89827
	{
		// Nested types
		public struct Packed // TypeDefIndex: 89826
		{
			// Fields
			public Vector3 position; // 0x00
			public Quaternion rotation; // 0x0C
			public Vector3 lossyScale; // 0x1C
	
			// Methods
			public bool IsSame(Transform transf); // 0x000000018D9C210C-0x000000018D9C223C
		}
	
		// Extension methods
		public static Packed GetWorldPacked(this Transform self); // 0x000000018D9C2E98-0x000000018D9C2F24
	}

	public static class Utils // TypeDefIndex: 89829
	{
		// Fields
		private const float kEpsilon = 1E-05f; // Metadata: 0x0264A8C3
		private const int kFloatPackingHighMinShaderLevel = 35; // Metadata: 0x0264A8C7
		private static FloatPackingPrecision ms_FloatPackingPrecision; // 0x00
	
		// Nested types
		public enum FloatPackingPrecision // TypeDefIndex: 89828
		{
			Undef = 0,
			Low = 8,
			High = 64
		}
	
		// Methods
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle); // 0x00000001872643C0-0x0000000187264400
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd); // 0x0000000187264400-0x0000000187264430
		public static void Swap<T>(ref ref T a, ref ref T b);
		public static string GetPath(Transform current); // 0x000000018D9C3288-0x000000018D9C334C
		public static T NewWithComponent<T>(string name)
			where T : Component;
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt); // 0x000000018D9C354C-0x000000018D9C35C0
		public static bool IsAlmostZero(float f); // 0x000000018D9C3430-0x000000018D9C3448
		public static void SetShaderKeywordEnabled(string name, bool enabled); // 0x000000018D9C3728-0x000000018D9C374C
		private static Vector4 Vector4_Floor(Vector4 vec); // 0x000000018725D1B0-0x000000018725D210
		public static FloatPackingPrecision GetFloatPackingPrecision(); // 0x000000018D9C315C-0x000000018D9C31CC
		public static void MarkCurrentSceneDirty(); // 0x0000000186805BA0-0x0000000186805BB0
		public static void MarkObjectDirty(UnityEngine.Object obj); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Extension methods
		public static T GetOrAddComponent<T>(this GameObject self)
			where T : Component;
		public static T GetOrAddComponent<T>(this MonoBehaviour self)
			where T : Component;
		public static void ForeachComponentsOnlyInChildren<T>(this GameObject self, Action<T> lambda, bool includeInactive = false /* Metadata: 0x0264A8B2 */)
			where T : Component;
		public static bool HasFlag(this Enum mask, Enum flags); // 0x000000018D9C33B4-0x000000018D9C3430
		public static Vector2 xy(this Vector3 aVector); // 0x00000001872358F0-0x0000000187235910
		public static Vector2 xz(this Vector3 aVector); // 0x0000000187235940-0x0000000187235960
		public static Vector2 yz(this Vector3 aVector); // 0x00000001872385C0-0x00000001872385E0
		public static Vector2 yx(this Vector3 aVector); // 0x000000018725B690-0x000000018725B6B0
		public static Vector2 zx(this Vector3 aVector); // 0x000000018725C170-0x000000018725C190
		public static Vector2 zy(this Vector3 aVector); // 0x000000018725C2F0-0x000000018725C310
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f /* Metadata: 0x0264A8B3 */); // 0x0000000188C5491C-0x0000000188C54930
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f /* Metadata: 0x0264A8B7 */); // 0x000000018D9C2F24-0x000000018D9C2F58
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f /* Metadata: 0x0264A8BB */); // 0x000000018D9C2F58-0x000000018D9C2FBC
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f /* Metadata: 0x0264A8BF */); // 0x000000018D9C2FBC-0x000000018D9C3010
		public static Vector4 AsVector4(this Vector3 vec3, float w); // 0x00000001872643A0-0x00000001872643C0
		public static float GetVolumeCubic(this Bounds self); // 0x000000018D9C334C-0x000000018D9C33B4
		public static float GetMaxArea2D(this Bounds self); // 0x000000018D9C31CC-0x000000018D9C3288
		public static UnityEngine.Color Opaque(this UnityEngine.Color self); // 0x0000000187264430-0x0000000187264450
		public static UnityEngine.Color ComputeComplementaryColor(this UnityEngine.Color self, bool blackAndWhite); // 0x000000018D9C30B8-0x000000018D9C315C
		public static Plane TranslateCustom(this Plane plane, Vector3 translation); // 0x000000018D9C374C-0x000000018D9C37E0
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point); // 0x000000018D9C3010-0x000000018D9C30B8
		public static bool IsValid(this Plane plane); // 0x000000018D9C3448-0x000000018D9C3478
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled); // 0x000000018D3EFD90-0x000000018D3EFDC4
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision); // 0x000000018D9C3684-0x000000018D9C3728
		public static UnityEngine.Color[] SampleInArray(this Gradient self, int samplesCount); // 0x000000018D9C35C0-0x000000018D9C3684
		public static float PackToFloat(this UnityEngine.Color color, int floatPackingPrecision); // 0x000000018D9C3478-0x000000018D9C354C
	}

	public static class Version // TypeDefIndex: 89830
	{
		// Fields
		public const int Current = 1991; // Metadata: 0x0264A8CC
	}

	[AddComponentMenu("Rendering/\u4F4E\u914D\u4F53\u79EF\u5149 Volumetric Light Beam")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[SelectionBase]
	public class VolumetricLightBeam : MonoBehaviour // TypeDefIndex: 89832
	{
		// Fields
		public PlatformLayers platformLayers; // 0x18
		public const string ClassName = "VolumetricLightBeam"; // Metadata: 0x0264A8CE
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
		[SerializeField]
		private float _SortingFudge; // 0x154
		[FormerlySerializedAs("fadeOutBegin")]
		[SerializeField]
		private float _FadeOutBegin; // 0x158
		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd; // 0x15C
		[CompilerGenerated]
		private uint __INTERNAL_InstancedMaterialGroupID_k__BackingField; // 0x160
		public BeamGeometry m_BeamGeom; // 0x168
		public bool matIsPersistent; // 0x170
		private Coroutine m_CoPlaytimeUpdate; // 0x178
		private Vector3 m_CachedClippingPlanePosition; // 0x180
		private Quaternion m_CachedClippingPlaneRotation; // 0x18C
		private bool m_HasCachedClippingPlanePose; // 0x19C
	
		// Properties
		public ColorMode usedColorMode { get; } // 0x000000018D9C4D68-0x000000018D9C4D9C 
		private bool useColorFromAttachedLightSpot { get; } // 0x000000018D9C4BB8-0x000000018D9C4C10 
		private bool useColorTemperatureFromAttachedLightSpot { get; } // 0x000000018D9C4C10-0x000000018D9C4C5C 
		[Obsolete("Use \'intensityGlobal\' or \'intensityInside\' instead")]
		public float alphaInside { get; set; } // 0x00000001872330D0-0x00000001872330E0 0x0000000187233130-0x0000000187233140
		[Obsolete("Use \'intensityGlobal\' or \'intensityOutside\' instead")]
		public float alphaOutside { get; set; } // 0x000000018723F460-0x000000018723F470 0x000000018723F470-0x000000018723F480
		public float intensityGlobal { get; set; } // 0x000000018723F460-0x000000018723F470 0x0000000187264460-0x0000000187264470
		public bool useIntensityFromAttachedLightSpot { get; } // 0x000000018D9C4CB8-0x000000018D9C4D10 
		public bool useSpotAngleFromAttachedLightSpot { get; } // 0x000000018D9C4D10-0x000000018D9C4D68 
		public float coneAngle { get; } // 0x000000018D9C3FE8-0x000000018D9C4040 
		public float coneRadiusEnd { get; set; } // 0x000000018D9C41A8-0x000000018D9C4208 0x000000018D9C4D9C-0x000000018D9C4DF0
		public float coneVolume { get; } // 0x000000018D9C4208-0x000000018D9C4258 
		public float coneApexOffsetZ { get; } // 0x000000018D9C4040-0x000000018D9C40B0 
		public Vector3 coneApexPositionLocal { get; } // 0x000000018D9C4178-0x000000018D9C41A8 
		public Vector3 coneApexPositionGlobal { get; } // 0x000000018D9C40B0-0x000000018D9C4178 
		public int geomSides { get; set; } // 0x000000018D9C42A4-0x000000018D9C42D0 0x000000018D9C4E50-0x000000018D9C4EB0
		public int geomSegments { get; set; } // 0x000000018D9C4278-0x000000018D9C42A4 0x000000018D9C4DF0-0x000000018D9C4E50
		public Vector3 skewingLocalForwardDirectionNormalized { get; } // 0x000000018D9C4A70-0x000000018D9C4BA8 
		public bool canHaveMeshSkewing { get; } // 0x00000001851A4410-0x00000001851A4420 
		public bool hasMeshSkewing { get; } // 0x000000018D9C4324-0x000000018D9C43D0 
		public Vector4 additionalClippingPlane { get; } // 0x000000018D9C3AE0-0x000000018D9C3CA0 
		public float attenuationLerpLinearQuad { get; } // 0x000000018D9C3CA0-0x000000018D9C3CC8 
		[Obsolete("Use \'fallOffStart\' instead")]
		public float fadeStart { get; set; } // 0x000000018723F5B0-0x000000018723F5C0 0x000000018723F690-0x000000018723F6A0
		[Obsolete("Use \'fallOffEnd\' instead")]
		public float fadeEnd { get; set; } // 0x000000018723F5C0-0x000000018723F5D0 0x000000018723F6A0-0x000000018723F6B0
		[Obsolete("Use \'fallOffEndFromLight\' instead")]
		public bool fadeEndFromLight { get; set; } // 0x000000018723BAD0-0x000000018723BAE0 0x000000018723BB30-0x000000018723BB40
		public Light lightSpotAttached { get; } // 0x000000018723BB00-0x000000018723BB10 
		public bool useFallOffEndFromAttachedLightSpot { get; } // 0x000000018D9C4C5C-0x000000018D9C4CB8 
		public float maxGeometryDistance { get; } // 0x000000018D9C4554-0x000000018D9C4584 
		public bool isNoiseEnabled { get; } // 0x000000018D9C4400-0x000000018D9C440C 
		[Obsolete("Use \'noiseMode\' instead")]
		public bool noiseEnabled { get; set; } // 0x000000018D9C4400-0x000000018D9C440C 0x000000018D9C4EB0-0x000000018D9C4ED0
		public float cullingDistance { get; } // 0x000000018D9C4258-0x000000018D9C4278 
		public float fadeOutBegin { get; set; } // 0x000000018723E3F0-0x000000018723E400 0x000000018723E430-0x000000018723E440
		public float fadeOutEnd { get; set; } // 0x000000018723E350-0x000000018723E360 0x000000018723E3C0-0x000000018723E3D0
		public bool isFadeOutEnabled { get; } // 0x000000018D9C43DC-0x000000018D9C4400 
		public bool isTilted { get; } // 0x000000018D9C440C-0x000000018D9C446C 
		public int sortingLayerID { get; set; } // 0x0000000187255BE0-0x0000000187255BF0 0x000000018D9C4ED0-0x000000018D9C4F54
		public string sortingLayerName { get; set; } // 0x000000018D9C4BA8-0x000000018D9C4BB8 0x000000018D9C4F54-0x000000018D9C4F7C
		public int sortingOrder { get; set; } // 0x00000001872501A0-0x00000001872501B0 0x000000018D9C4F7C-0x000000018D9C5000
		public float sortingFudge { get; set; } // 0x0000000184F7A050-0x0000000184F7A060 0x0000000184F7A060-0x0000000184F7A730
		public bool trackChangesDuringPlaytime { get; set; } // 0x0000000184F6ABE0-0x0000000184F6ABF0 0x0000000187264470-0x0000000187264480
		public bool isCurrentlyTrackingChanges { get; } // 0x000000018D9C43D0-0x000000018D9C43DC 
		public bool hasGeometry { get; } // 0x000000018D9C42D0-0x000000018D9C4324 
		public Bounds bounds { get; } // 0x000000018D9C3EEC-0x000000018D9C3FE8 
		public int blendingModeAsInt { get; } // 0x000000018D9C3E40-0x000000018D9C3EEC 
		public Quaternion beamInternalLocalRotation { get; } // 0x000000018D9C3D80-0x000000018D9C3E04 
		public Vector3 beamLocalForward { get; } // 0x000000018D9C3E04-0x000000018D9C3E40 
		public Vector3 beamGlobalForward { get; } // 0x000000018D9C3CC8-0x000000018D9C3D80 
		public Vector3 lossyScale { get; } // 0x000000018D9C446C-0x000000018D9C4554 
		public float raycastDistance { get; } // 0x000000018D9C486C-0x000000018D9C494C 
		public Vector3 raycastGlobalForward { get; } // 0x000000018D9C494C-0x000000018D9C49D0 
		public Vector3 raycastGlobalUp { get; } // 0x000000018D9C4A20-0x000000018D9C4A70 
		public Vector3 raycastGlobalRight { get; } // 0x000000018D9C49D0-0x000000018D9C4A20 
		public int _INTERNAL_pluginVersion { get; } // 0x0000000187262670-0x0000000187262680 
		public uint _INTERNAL_InstancedMaterialGroupID { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000187233DA0-0x0000000187233DB0 0x0000000187254CD0-0x0000000187254CE0
		public string meshStats { get; } // 0x000000018D9C4584-0x000000018D9C46FC 
		public int meshVerticesCount { get; } // 0x000000018D9C47C0-0x000000018D9C486C 
		public int meshTrianglesCount { get; } // 0x000000018D9C46FC-0x000000018D9C47C0 
	
		// Nested types
		public enum AttachedLightType // TypeDefIndex: 89831
		{
			NoLight = 0,
			OtherLight = 1,
			SpotLight = 2
		}
	
		// Constructors
		public VolumetricLightBeam(); // 0x000000018D9C38D4-0x000000018D9C3AE0
	
		// Methods
		public void GetInsideAndOutsideIntensity(out float inside, out float outside); // 0x000000018D9C38B0-0x000000018D9C38D4
		private Vector3 ComputeRaycastGlobalVector(Vector3 localVec); // 0x000000018D9C37E0-0x000000018D9C38B0
		private void SetFadeOutValue(ref float propToChange, float value); // 0x0000000187264450-0x0000000187264460
	}
}
