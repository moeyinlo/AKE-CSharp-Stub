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

// Image 55: UnityEngine.HGGraphicsModule.dll - Assembly: UnityEngine.HGGraphicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60878-61124
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: InternalsVisibleTo("UnityEngine")]
[assembly: InternalsVisibleTo("UnityEngine.SharedInternalsModule")]
[assembly: InternalsVisibleTo("UnityEngine.CoreModule")]
[assembly: InternalsVisibleTo("UnityEngine.AccessibilityModule")]
[assembly: InternalsVisibleTo("UnityEngine.AndroidJNIModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputModule")]
[assembly: InternalsVisibleTo("UnityEngine.AnimationModule")]
[assembly: InternalsVisibleTo("UnityEngine.AntiSDKModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainModule")]
[assembly: InternalsVisibleTo("UnityEngine.ParticleSystemModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.PhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.JSONSerializeModule")]
[assembly: InternalsVisibleTo("UnityEngine.AIModule")]
[assembly: InternalsVisibleTo("UnityEngine.ARModule")]
[assembly: InternalsVisibleTo("UnityEngine.HotReloadModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterInputModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterRendererModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityConnectModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommonModule")]
[assembly: InternalsVisibleTo("UnityEngine.TLSModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.CrashReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.DSPGraphModule")]
[assembly: InternalsVisibleTo("UnityEngine.ImageConversionModule")]
[assembly: InternalsVisibleTo("UnityEngine.GameCenterModule")]
[assembly: InternalsVisibleTo("UnityEngine.GIModule")]
[assembly: InternalsVisibleTo("UnityEngine.GridModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsCPPModule")]
[assembly: InternalsVisibleTo("UnityEngine.AssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.DirectorModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGOcclusionCullingModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputLegacyModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestWWWModule")]
[assembly: InternalsVisibleTo("UnityEngine.LiteSSLModule")]
[assembly: InternalsVisibleTo("UnityEngine.LocalizationModule")]
[assembly: InternalsVisibleTo("UnityEngine.PerformanceReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.Physics2DModule")]
[assembly: InternalsVisibleTo("UnityEngine.ProfilerModule")]
[assembly: InternalsVisibleTo("UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule")]
[assembly: InternalsVisibleTo("UnityEngine.ScreenCaptureModule")]
[assembly: InternalsVisibleTo("UnityEngine.TilemapModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteMaskModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamingModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamLineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubstanceModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubsystemsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainPhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreFontEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreTextEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteShapeModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClothModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsModule")]
[assembly: InternalsVisibleTo("UnityEngine.UmbraModule")]
[assembly: InternalsVisibleTo("UnityEngine.UNETModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityCurlModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityTestProtocolModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestTextureModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsNativeModule")]
[assembly: InternalsVisibleTo("UnityEngine.VehiclesModule")]
[assembly: InternalsVisibleTo("UnityEngine.VFXModule")]
[assembly: InternalsVisibleTo("UnityEngine.VideoModule")]
[assembly: InternalsVisibleTo("UnityEngine.VirtualTexturingModule")]
[assembly: InternalsVisibleTo("UnityEngine.XRModule")]
[assembly: InternalsVisibleTo("UnityEngine.VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.WindModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5Module")]
[assembly: InternalsVisibleTo("UnityEngine.IMGUIModule")]
[assembly: InternalsVisibleTo("UnityEngine.AudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextRenderingModule")]
[assembly: InternalsVisibleTo("Unity.Analytics")]
[assembly: InternalsVisibleTo("UnityEngine.Analytics")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommon")]
[assembly: InternalsVisibleTo("UnityEngine.Advertisements")]
[assembly: InternalsVisibleTo("UnityEngine.Purchasing")]
[assembly: InternalsVisibleTo("UnityEngine.TestRunner")]
[assembly: InternalsVisibleTo("Unity.Automation")]
[assembly: InternalsVisibleTo("Unity.Burst")]
[assembly: InternalsVisibleTo("Unity.Burst.Editor")]
[assembly: InternalsVisibleTo("Unity.DeploymentTests.Services")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.UnityAnalytics")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Timeline")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Framework")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework")]
[assembly: InternalsVisibleTo("Unity.ucg.QoS")]
[assembly: InternalsVisibleTo("Unity.Networking.Transport")]
[assembly: InternalsVisibleTo("Unity.PerformanceTests.RuntimeTestRunner.Tests")]
[assembly: InternalsVisibleTo("Unity.Timeline")]
[assembly: InternalsVisibleTo("Assembly-CSharp-testable")]
[assembly: InternalsVisibleTo("Assembly-CSharp-firstpass-testable")]
[assembly: InternalsVisibleTo("UnityEngine.SpatialTracking")]
[assembly: InternalsVisibleTo("GoogleAR.UnityNative")]
[assembly: InternalsVisibleTo("Unity.WindowsMRAutomation")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.Editor")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.EditorTests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework.Tests")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.EditorTests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.AllIn1Runner")]
[assembly: InternalsVisibleTo("Unity.UIElements")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsGameObjectsModule")]
[assembly: InternalsVisibleTo("Unity.UIElements.Editor")]
[assembly: InternalsVisibleTo("Unity.UIElements.PlayModeTests")]
[assembly: InternalsVisibleTo("Unity.UIElements.EditorTests")]
[assembly: InternalsVisibleTo("UnityEngine.UI")]
[assembly: InternalsVisibleTo("UnityEditor.UIBuilderModule")]
[assembly: InternalsVisibleTo("Unity.Services.QoS")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.Editor")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.022")]
[assembly: InternalsVisibleTo("Unity.Entities.Tests")]
[assembly: InternalsVisibleTo("Unity.Collections")]
[assembly: InternalsVisibleTo("Unity.Runtime")]
[assembly: InternalsVisibleTo("Unity.Core")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.003")]
[assembly: InternalsVisibleTo("Unity.Entities")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.006")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.007")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.008")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.009")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.010")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud.Service")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.005")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.011")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.012")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.013")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.015")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.016")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.017")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.018")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.019")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.020")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.021")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.023")]
[assembly: InternalsVisibleTo("Unity.Logging")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.024")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.005")]
[assembly: InternalsVisibleTo("Unity.Subsystem.Registration")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.014")]
[assembly: InternalsVisibleTo("UnityEngine.Networking")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: UnityEngineModuleAssembly]

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 60879
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 60880
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[CompilerGenerated]
	[Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 60881
	{
		// Constructors
		public IsUnmanagedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine
{
	[NativeHeader("Modules/HGGraphics/Public/CapsuleShadow/HGCapsuleBindingComponent.h")]
	public class HGCapsuleBindingComponent : Component // TypeDefIndex: 60882
	{
		// Properties
		public bool enabled { set; } // 0x000000018351FDE0-0x000000018351FE30
		public float capsuleRadius { set; } // 0x000000018351FE30-0x000000018351FE80
		public float capsuleHeight { set; } // 0x000000018351FE80-0x000000018351FED0
		public Vector3 localOffset { set; } // 0x0000000185392D9C-0x0000000185392DB0
		public Vector3 localRotation { set; } // 0x0000000185392DB0-0x0000000185392DC4
		public float intensityScale { set; } // 0x000000018351FED0-0x000000018351FF20
		public bool forceRender { set; } // 0x000000018351FF20-0x000000018351FF70
	
		// Methods
		private void set_localOffset_Injected(ref Vector3 value); // 0x0000000184476360-0x00000001844763B0
		private void set_localRotation_Injected(ref Vector3 value); // 0x0000000184476310-0x0000000184476360
	}

	public enum HGDecalShapeType // TypeDefIndex: 60883
	{
		Box = 0,
		Cylinder = 1,
		Sector = 2,
		Sphere = 3,
		Mesh = 255
	}

	[NativeHeader("Modules/HGGraphics/Public/Decal/HGDecalProjector.h")]
	public sealed class HGDecalProjector : UnityEngine.Behaviour // TypeDefIndex: 60884
	{
		// Properties
		public HGDecalShapeType shapeType { get; } // 0x000000018B3F8814-0x000000018B3F8848 
		public Material material { get; set; } // 0x0000000184CA74A0-0x0000000184CA74E0 0x000000018B3F8908-0x000000018B3F894C
		public Bounds bounds { get; } // 0x000000018B3F87E4-0x000000018B3F8814 
		public UnityEngine.Color baseColor { get; set; } // 0x000000018B3F8774-0x000000018B3F87A0 0x000000018B3F88F4-0x000000018B3F8908
		public Vector2 uvOffset { get; set; } // 0x000000018B3F888C-0x000000018B3F88B0 0x000000018B3F89D4-0x000000018B3F89F0
		public float sectorAngle { set; } // 0x000000018B3F894C-0x000000018B3F8990
	
		// Methods
		private void get_bounds_Injected(out Bounds ret); // 0x000000018B3F87A0-0x000000018B3F87E4
		private void get_baseColor_Injected(out UnityEngine.Color ret); // 0x000000018B3F8730-0x000000018B3F8774
		private void set_baseColor_Injected(ref UnityEngine.Color value); // 0x000000018B3F88B0-0x000000018B3F88F4
		private void get_uvOffset_Injected(out Vector2 ret); // 0x000000018B3F8848-0x000000018B3F888C
		private void set_uvOffset_Injected(ref Vector2 value); // 0x000000018B3F8990-0x000000018B3F89D4
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGMeshRenderer.h")]
	public sealed class HGMeshRenderer : UnityEngine.Behaviour // TypeDefIndex: 60885
	{
		// Properties
		public HGMeshRendererData data { [NativeName("GetData")] get; [NativeName("SetData")] set; } // 0x000000018B3FA3D4-0x000000018B3FA408 0x000000018B3FA408-0x000000018B3FA44C
	
		// Methods
		public Entity GetEntity(); // 0x000000018B3FA3B0-0x000000018B3FA3D4
		private void GetEntity_Injected(out Entity ret); // 0x000000018B3FA36C-0x000000018B3FA3B0
	}

	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGMeshRendererData.bindings.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGMeshRendererData.h")]
	[UsedByNativeCode]
	public sealed class HGMeshRendererData : UnityEngine.Object // TypeDefIndex: 60886
	{
		// Constructors
		public HGMeshRendererData(); // 0x000000018B3FA320-0x000000018B3FA36C
	
		// Methods
		[FreeFunction("HGMeshRendererData_Bindings::Create")]
		private static void Internal_Create([Writable] HGMeshRendererData self); // 0x000000018B3FA2A8-0x000000018B3FA2DC
		public Material[] GetMaterials(); // 0x000000018B3FA240-0x000000018B3FA274
		public void SetMaterials(Material[] materials); // 0x000000018B3FA2DC-0x000000018B3FA320
		public Mesh[] GetMeshes(); // 0x000000018B3FA274-0x000000018B3FA2A8
	}

	[NativeHeader("Modules/HGGraphics/Public/OC/HGOccluder.h")]
	public sealed class HGOccluder : Component // TypeDefIndex: 60887
	{
		// Properties
		public bool enabled { get; set; } // 0x000000018B3FA44C-0x000000018B3FA480 0x000000018B3FA4B4-0x000000018B3FA4F8
		public HGSoftwareOcclusionCullingData occluderData { get; set; } // 0x000000018B3FA480-0x000000018B3FA4B4 0x000000018B3FA4F8-0x000000018B3FA53C
	
		// Constructors
		public HGOccluder(); // 0x0000000185393520-0x0000000185393538
	}

	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGSoftwareOcclusionCulling.bindings.h")]
	[NativeHeader("Modules/HGGraphics/Public/OC/HGSoftwareOcclusionCullingData.h")]
	[UsedByNativeCode]
	public sealed class HGSoftwareOcclusionCullingData : UnityEngine.Object // TypeDefIndex: 60888
	{
		// Properties
		public int quadCount { get; } // 0x000000018B3FB08C-0x000000018B3FB0C0 
	
		// Constructors
		public HGSoftwareOcclusionCullingData(); // 0x000000018B3FB040-0x000000018B3FB08C
	
		// Methods
		[FreeFunction("HGSoftwareOcclusionCulling_Bindings::CreateOcclusionCullingData")]
		private static void Internal_Create([Writable] HGSoftwareOcclusionCullingData cullingData); // 0x000000018B3FB00C-0x000000018B3FB040
		public void GetOccluderData(NativeArray<float> centerXs, NativeArray<float> centerYs, NativeArray<float> centerZs, NativeArray<float> extentXs, NativeArray<float> extentYs, NativeArray<float> extentZs, NativeArray<Vector3> vertexData, ref int quadCount); // 0x000000018B3FAEB0-0x000000018B3FB00C
		public void GetOccluderData(IntPtr centerXs, IntPtr centerYs, IntPtr centerZs, IntPtr extentXs, IntPtr extentYs, IntPtr extentZs, IntPtr vertexData, ref int quadCount); // 0x000000018B3FAE4C-0x000000018B3FAEB0
	}

	public enum TransformAnimatedPhasePlayMode // TypeDefIndex: 60889
	{
		TransformAnimatedPhaseCurrent = 0,
		TransformAnimatedPhaseSequence = 1,
		TransformAnimatedPhaseSequenceLoop = 2
	}

	[Serializable]
	[UsedByNativeCode]
	public struct TransformAnimatedCurveData // TypeDefIndex: 60890
	{
		// Fields
		public byte[] data; // 0x00
		public float duration; // 0x08
	}

	[Serializable]
	[UsedByNativeCode]
	public struct TransformMotionPhase // TypeDefIndex: 60891
	{
		// Fields
		public Vector3 translationSpeed; // 0x00
		public Vector3 eulerAngleSpeed; // 0x0C
		public Vector3 rotAnchorPosition; // 0x18
		public float duration; // 0x24
	}

	public struct HGTransformAnimatedProfile // TypeDefIndex: 60892
	{
		// Fields
		public TransformMotionPhase[] motionPhaseProfiles; // 0x00
		public TransformAnimatedCurveData animCurveData; // 0x08
		public TransformAnimatedPhasePlayMode phasePlayMode; // 0x18
	}

	[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedBehaviour.h")]
	public sealed class HGTransformAnimatedBehaviour : UnityEngine.Behaviour // TypeDefIndex: 60893
	{
		// Fields
		public HGTransformAnimatedProfile profileData; // 0x18
		public bool useLogicDeltaTime; // 0x38
		public Renderer shadowProxyRenderer; // 0x40
	
		// Constructors
		public HGTransformAnimatedBehaviour(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void SetPause(); // 0x000000018B3FBD2C-0x000000018B3FBD60
		public void Play(); // 0x000000018B3FBCB8-0x000000018B3FBCEC
		public float GetTimeScale(); // 0x000000018B3FBC08-0x000000018B3FBC3C
		public void SetTimeScale(float scale); // 0x000000018B3FBD60-0x000000018B3FBDA4
		public void SetCurrentPhaseIndex(int phase); // 0x000000018B3FBCEC-0x000000018B3FBD2C
		public int GetCurrentPhaseIndex(); // 0x000000018B3FBBD4-0x000000018B3FBC08
		public Matrix4x4 GetWorldMatrix(); // 0x000000018B3FBC80-0x000000018B3FBCB8
		public void SetUseLogicTime(bool useLogicTime); // 0x000000018B3FBDA4-0x000000018B3FBDE8
		public bool UseLogicTime(); // 0x000000018B3FBDE8-0x000000018B3FBE1C
		private void GetWorldMatrix_Injected(out Matrix4x4 ret); // 0x000000018B3FBC3C-0x000000018B3FBC80
	}

	public static class HGTransformAnimatedSystemCPP // TypeDefIndex: 60894
	{
		// Methods
		[FreeFunction("HGTransformAnimatedSystemCPP_Create")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static long HGTransformAnimatedSystemCPP_Create(); // 0x0000000184D7C1F0-0x0000000184D7C230
		[FreeFunction("HGTransformAnimatedSystemCPP_UpdateAbsoluteTime")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static void HGTransformAnimatedSystemCPP_UpdateAbsoluteTime(long ptr, float absoluteTimeSec); // 0x0000000182F5C870-0x0000000182F5C8C0
		[FreeFunction("HGTransformAnimatedSystemCPP_Destroy")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static void HGTransformAnimatedSystemCPP_Destroy(long ptr); // 0x000000018B3FBE1C-0x000000018B3FBE50
	}

	[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformBehaviour.h")]
	public sealed class HGWindFoliageSyncTransformBehaviour : UnityEngine.Behaviour // TypeDefIndex: 60895
	{
		// Fields
		public MeshRenderer m_windPlant; // 0x18
		public MeshRenderer m_windPlantMobile; // 0x20
	
		// Constructors
		public HGWindFoliageSyncTransformBehaviour(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Disable(); // 0x000000018B3FC1F8-0x000000018B3FC22C
	}

	public class HGWindFoliageSyncSystemCPP // TypeDefIndex: 60896
	{
		// Methods
		[FreeFunction("HGWindFoliageSyncSystemCPP_Create")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static long HGWindFoliageSyncSystemCPP_Create(); // 0x0000000182ED8AD0-0x0000000182ED8B10
		[FreeFunction("HGWindFoliageSyncSystemCPP_UpdateWindParam")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static unsafe void HGWindFoliageSyncSystemCPP_UpdateWindParam(long _ptr, Vector4 windGlobalParam, float* windMotorParam0, float* windMotorParam1, float* windMotorParam2, float* windMotorParam3, Vector4 count, float time, float lastTime); // 0x0000000185391E9C-0x0000000185391EF8
		[FreeFunction("HGWindFoliageSyncSystemCPP_Destroy")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static void HGWindFoliageSyncSystemCPP_Destroy(long _ptr); // 0x000000018B3FC1C4-0x000000018B3FC1F8
		private static unsafe void HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(long _ptr, ref Vector4 windGlobalParam, float* windMotorParam0, float* windMotorParam1, float* windMotorParam2, float* windMotorParam3, ref Vector4 count, float time, float lastTime); // 0x0000000183D51280-0x0000000183D512F0
	}
}

namespace UnityEngine.HyperGryph
{
	[NativeHeader("Modules/StreamLine/StreamlineDLSSG.h")]
	[NativeHeader("Modules/StreamLine/StreamlineDLSS.h")]
	[NativeHeader("Modules/StreamLine/StreamlineReflex.h")]
	[NativeHeader("Modules/HGGraphics/Public/DLSS/HGDLSSUtil.h")]
	[UsedByNativeCode]
	public struct HGDLSSUtil // TypeDefIndex: 60897
	{
		// Methods
		[FreeFunction("IsStreamlineDLSSSupported")]
		[UsedByNativeCode]
		public static bool IsStreamlineDLSSSupported(); // 0x0000000184D7C230-0x0000000184D7C270
		[FreeFunction("IsStreamlineDLSSGSupported")]
		[UsedByNativeCode]
		public static bool IsStreamlineDLSSGSupported(); // 0x0000000184B08B40-0x0000000184B08B80
		[FreeFunction("IsLowLatencyAvailable")]
		[UsedByNativeCode]
		public static bool IsLowLatencyAvailable(); // 0x000000018B3F8704-0x000000018B3F8730
	}

	[NativeType("Modules/HGGraphics/Public/GPUDriven/Version1/GPUDrivenRendererV1.h")]
	[StaticAccessor("GetGPUDrivenRendererV1()", StaticAccessorType.Dot)]
	public static class GPUDrivenRendererV1 // TypeDefIndex: 60898
	{
		// Methods
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, bool retainCustomDS, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, ref Matrix4x4 view, ref Matrix4x4 proj, ref Matrix4x4 nonJitteredProj, ref Vector4 zBufferParams, ref Matrix4x4 prevView, ref Matrix4x4 prevViewProj, ref Matrix4x4 prevNonJitteredViewProj, ref Vector3 cameraPos); // 0x000000018B3F7EA4-0x000000018B3F7F0C
		public static bool Valid(); // 0x0000000183F9BD70-0x0000000183F9BE90
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool retainCustomDS, out uint normalList, out uint preZPart0List, out uint preZPart1List, ref Matrix4x4 view, ref Matrix4x4 proj, ref Matrix4x4 nonJitteredProj, ref Vector4 zBufferParams, ref Matrix4x4 prevView, ref Matrix4x4 prevViewProj, ref Matrix4x4 prevNonJitteredViewProj, ref Vector3 cameraPos); // 0x000000018B3F7F0C-0x000000018B3F7FC4
		public static void DrawRendererList(CommandBuffer cmd, uint rendererList, bool renderDepthOnly); // 0x000000018B3F8098-0x000000018B3F80B4
		public static void AdvanceFrame(); // 0x000000018B3F7D68-0x000000018B3F7D94
		public static void ToggleCullingInspectionMode(bool flag); // 0x000000018B3F8114-0x000000018B3F8148
		public static bool CullingInspectionMode(); // 0x000000018B3F7FC4-0x000000018B3F7FF0
		public static void PopulatePerFrameData(CommandBuffer cmd, uint threadGroupSize, uint hzbWidth, uint hzbHeight, bool usePrevVP = false /* Metadata: 0x0234EE9D */); // 0x000000018B3F80B4-0x000000018B3F8114
		public static void BindFrameConstantsBuffer(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018B3F7E50-0x000000018B3F7EA4
		public static void BindFrameConstantsBufferGlobal(CommandBuffer cmd); // 0x000000018B3F7E1C-0x000000018B3F7E50
		public static void BindBuffersForCulling(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018B3F7D94-0x000000018B3F7DE8
		public static void BindBuffersForRendering(CommandBuffer cmd); // 0x000000018B3F7DE8-0x000000018B3F7E1C
		public static void DispatchComputeMeshletInstanceCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018B3F8044-0x000000018B3F8098
		public static void DispatchComputeDrawBucketCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018B3F7FF0-0x000000018B3F8044
	}

	[NativeType("Modules/HGGraphics/Public/GPUDriven/Version2/GPUDrivenRendererV2.h")]
	[StaticAccessor("GetGPUDrivenRendererV2()", StaticAccessorType.Dot)]
	public static class GPUDrivenRendererV2 // TypeDefIndex: 60899
	{
		// Methods
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, ref Matrix4x4 view, ref Matrix4x4 proj, ref Matrix4x4 nonJitteredProj, ref Vector4 zBufferParams, ref Matrix4x4 prevView, ref Matrix4x4 prevViewProj, ref Matrix4x4 prevNonJitteredViewProj, ref Vector3 cameraPos); // 0x000000018B3F8284-0x000000018B3F82EC
		public static bool Valid(); // 0x0000000183F9BD30-0x0000000183F9BD70
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, out uint normalList, out uint preZPart0List, out uint preZPart1List, ref Matrix4x4 view, ref Matrix4x4 proj, ref Matrix4x4 nonJitteredProj, ref Vector4 zBufferParams, ref Matrix4x4 prevView, ref Matrix4x4 prevViewProj, ref Matrix4x4 prevNonJitteredViewProj, ref Vector3 cameraPos); // 0x000000018B3F82EC-0x000000018B3F83A4
		public static void DrawRendererList(CommandBuffer cmd, uint rendererList, bool renderDepthOnly); // 0x000000018B3F8098-0x000000018B3F80B4
		public static void AdvanceFrame(); // 0x000000018B3F8148-0x000000018B3F8174
		public static void ToggleCullingInspectionMode(bool flag); // 0x000000018B3F84D8-0x000000018B3F850C
		public static bool CullingInspectionMode(); // 0x000000018B3F83A4-0x000000018B3F83D0
		public static void PopulatePerFrameData(CommandBuffer cmd, uint threadGroupSize, uint hzbWidth, uint hzbHeight, bool usePrevVP = false /* Metadata: 0x0234EE9E */); // 0x000000018B3F8478-0x000000018B3F84D8
		public static void BindFrameConstantsBuffer(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018B3F8230-0x000000018B3F8284
		public static void BindFrameConstantsBufferGlobal(CommandBuffer cmd); // 0x000000018B3F81FC-0x000000018B3F8230
		public static void BindBuffersForCulling(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018B3F8174-0x000000018B3F81C8
		public static void BindBuffersForRendering(CommandBuffer cmd); // 0x000000018B3F81C8-0x000000018B3F81FC
		public static void DispatchComputeMeshletInstanceCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018B3F8424-0x000000018B3F8478
		public static void DispatchComputeDrawBucketCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx); // 0x000000018B3F83D0-0x000000018B3F8424
	}

	public struct CapsuleData // TypeDefIndex: 60900
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
	public static class HGCapsuleShadowManager // TypeDefIndex: 60901
	{
		// Methods
		public static uint GetRenderCapsuleNum(); // 0x000000018B3F86D8-0x000000018B3F8704
		public static uint CullAndGetRenderCapsuleData(uint viewHandle, IntPtr outData, uint outDataCapacity); // 0x000000018B3F8688-0x000000018B3F86D8
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGDecalRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetDecalRender()", StaticAccessorType.Dot)]
	public static class HGDecalRender // TypeDefIndex: 60902
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGShaderLightMode lightModeMask, IntPtr context); // 0x000000018B3F89F0-0x000000018B3F8A0C
		public static uint CreateRendererList(uint viewHandle, HGShaderLightMode lightModeMask, IntPtr context, IntPtr drawableFeedbackPtr); // 0x000000018B3F8A0C-0x000000018B3F8A1C
		private static unsafe uint CreateRendererList(uint viewHandle, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr); // 0x000000018B3F8A1C-0x000000018B3F8A7C
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018B3F8A7C-0x000000018B3F8A98
	}

	public struct HGDrawCallDetailedStats // TypeDefIndex: 60903
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
	public class HGFastString // TypeDefIndex: 60904
	{
		// Methods
		[FreeFunction("HyperGryph::HGFastString::IndexToString")]
		public static string IndexToString(int index); // 0x000000018B3F9288-0x000000018B3F92BC
	}

	public enum HGFactoryLODTier // TypeDefIndex: 60905
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryRendererData // TypeDefIndex: 60906
	{
		// Fields
		public Mesh m_mesh; // 0x00
		public Mesh m_shadowProxyMesh; // 0x08
		public Material[] m_materials; // 0x10
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryInstancingLODDataV3 // TypeDefIndex: 60907
	{
		// Fields
		public HGFactoryRendererData[] m_rendererDataArr; // 0x00
		public Vector4 m_lodScreenSizeMaxs; // 0x08
		public Vector4 m_lodScreenSizeMins; // 0x18
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryEntityDesc // TypeDefIndex: 60908
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

	public struct HGFactoryEntityTransformData // TypeDefIndex: 60909
	{
		// Fields
		public Vector4 m_positionAndScale; // 0x00
		public Quaternion m_rotation; // 0x10
	}

	[NativeHeader("Modules/HGGraphics/Public/Factory/HGFactoryRenderManager.h")]
	[StaticAccessor("HyperGryph::HGFactoryRenderManager::GetInstance()", StaticAccessorType.Dot)]
	public static class HGFactoryRenderManager // TypeDefIndex: 60910
	{
		// Methods
		public static void SetFactoryLodTier(HGFactoryLODTier lodTier); // 0x0000000184B334B0-0x0000000184B334F0
		public static Entity CreateRegularEntity(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, string entityName, Entity gameplayEntity, Material[] additiveMaterials); // 0x0000000184030110-0x00000001840301A0
		public static void UpdateRegularEntity(Entity gameplayEntity, HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc); // 0x0000000185395BF0-0x0000000185395C0C
		public static void UpdateRegularEntityAdditiveMaterials(Entity gameplayEntity, Material[] additiveMaterials); // 0x0000000185395C0C-0x0000000185395C28
		public static void DestroyRegularEntity(Entity gameplayEntity); // 0x000000018B3F9048-0x000000018B3F9064
		public static void CreateBatchedEntities(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, NativeArray<Entity> entities, NativeArray<Entity> gameplayEntities, string entityName); // 0x0000000183E5C120-0x0000000183E5C260
		public static void DestroyBatchedEntities(NativeArray<Entity> gameplayEntities); // 0x000000018B3F8F9C-0x000000018B3F8FD4
		private static void CreateBatchedEntities(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, IntPtr entities, IntPtr gameplayEntities, int count, string entityName); // 0x0000000185396190-0x00000001853961BC
		private static void DestroyBatchedEntities(IntPtr gameplayEntities, int count); // 0x000000018B3F8FD4-0x000000018B3F9014
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityEnabledLightModes(Entity rendererEntity, uint lightModeMask); // 0x000000018B3F9118-0x000000018B3F9134
		public static void SetEntitySharedData<T>(uint sharedDataIndex, T data, int offset)
			where T : struct;
		[NativeMethod(IsThreadSafe = true)]
		private static void SetEntitySharedDataPartial(uint sharedDataIndex, IntPtr data, int offset, int size); // 0x0000000183D689C0-0x0000000183D68A30
		[NativeMethod(IsThreadSafe = true)]
		public static byte GetEntityDirtyFlags(uint sharedDataIndex); // 0x00000001834A4030-0x00000001834A4070
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityDirtyFlags(uint sharedDataIndex, byte flags); // 0x00000001834A4070-0x00000001834A40C0
		[NativeMethod(IsThreadSafe = true)]
		public static byte GetEntityObjectFlags(uint sharedDataIndex); // 0x00000001834A3F60-0x00000001834A3FA0
		[NativeMethod(IsThreadSafe = true)]
		public static uint GetEntityAdditiveVFXFlags(uint sharedDataIndex); // 0x000000018B3F9064-0x000000018B3F9098
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityAdditiveVFXFlags(uint sharedDataIndex, uint flags); // 0x000000018B3F9098-0x000000018B3F90D8
		public static void FrameUpdateEntities(); // 0x00000001841E1670-0x00000001841E1680
		private static void CreateRegularEntity_Injected(HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc, string entityName, ref Entity gameplayEntity, Material[] additiveMaterials, out Entity ret); // 0x00000001840301A0-0x0000000184030210
		private static void UpdateRegularEntity_Injected(ref Entity gameplayEntity, HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc); // 0x0000000183D6C680-0x0000000183D6C6E0
		private static void UpdateRegularEntityAdditiveMaterials_Injected(ref Entity gameplayEntity, Material[] additiveMaterials); // 0x0000000184B39FB0-0x0000000184B3A000
		private static void DestroyRegularEntity_Injected(ref Entity gameplayEntity); // 0x000000018B3F9014-0x000000018B3F9048
		private static void CreateBatchedEntities_Injected(HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc, IntPtr entities, IntPtr gameplayEntities, int count, string entityName); // 0x000000018452E490-0x000000018452E500
		private static void SetEntityEnabledLightModes_Injected(ref Entity rendererEntity, uint lightModeMask); // 0x000000018B3F90D8-0x000000018B3F9118
	}

	[UsedByNativeCode]
	public struct HGFoliageInteractCPP // TypeDefIndex: 60911
	{
		// Fields
		public int compID; // 0x00
		public Transform transform; // 0x08
		public Mesh interactCollider; // 0x10
	}

	[UsedByNativeCode]
	public struct HGFoliageInteractRaftCPP // TypeDefIndex: 60912
	{
		// Fields
		public int compID; // 0x00
		public Transform transform; // 0x08
		public Mesh interactCollider; // 0x10
	}

	[NativeType("Modules/HGGraphics/Public/FoliageInteractive/FoliageInteractiveManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageInteractiveManager()", StaticAccessorType.Dot)]
	public static class HGFoliageInteractiveManagerV2 // TypeDefIndex: 60913
	{
		// Methods
		public static void SetupFoliageInteractiveManager(Mesh characterProxyMesh, bool enabled); // 0x0000000184D33050-0x0000000184D330A0
		public static void CleanUpFoliageInteractiveManager(); // 0x0000000183949C50-0x0000000183949C90
		public static void SetEnabled(bool enabled); // 0x00000001838B2A50-0x00000001838B2A90
		public static void SetInteractCenter(Vector3 center); // 0x00000001853914E4-0x00000001853914F4
		public static void SetCharacterPositions(List<Vector3> positions); // 0x00000001833A4390-0x00000001833A43E0
		public static unsafe void SetCharacterPositions(Vector3* positions, int count); // 0x00000001833A43E0-0x00000001833A4430
		public static void RegisterInteract(HGFoliageInteractCPP interact); // 0x000000018B3F9334-0x000000018B3F9344
		public static void UnregisterInteract(int interactInstID); // 0x000000018B3F9378-0x000000018B3F93AC
		public static void RegisterInteractRaft(HGFoliageInteractRaftCPP raft); // 0x000000018B3F92F0-0x000000018B3F9300
		public static void UnregisterInteractRaft(int raftInstID); // 0x000000018B3F9344-0x000000018B3F9378
		private static void SetInteractCenter_Injected(ref Vector3 center); // 0x00000001841E31B0-0x00000001841E31F0
		private static void RegisterInteract_Injected(ref HGFoliageInteractCPP interact); // 0x000000018B3F9300-0x000000018B3F9334
		private static void RegisterInteractRaft_Injected(ref HGFoliageInteractRaftCPP raft); // 0x000000018B3F92BC-0x000000018B3F92F0
	}

	[NativeType("Modules/HGGraphics/Public/FoliageOccluder/FoliageOccluderManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageOccluderManager()", StaticAccessorType.Dot)]
	public static class HGFoliageOccluderManagerV2 // TypeDefIndex: 60914
	{
		// Methods
		public static void SetCenterPosition(Vector3 center); // 0x00000001853914F4-0x0000000185391504
		private static void SetCenterPosition_Injected(ref Vector3 center); // 0x00000001841E3170-0x00000001841E31B0
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGFoliageOccluderRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageOccluderRender()", StaticAccessorType.Dot)]
	public static class HGFoliageOccluderRender // TypeDefIndex: 60915
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, uint materialHandle, uint geometryHandle, HGShaderLightMode lightModeMask, IntPtr context); // 0x000000018B3F93AC-0x000000018B3F93D0
		private static unsafe uint CreateRendererList(uint viewHandle, uint materialHandle, uint geometryHandle, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr); // 0x000000018B3F93D0-0x000000018B3F9430
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018B3F9430-0x000000018B3F944C
	}

	[UsedByNativeCode]
	public struct GpuClothClearBufferDataCPP // TypeDefIndex: 60916
	{
		// Fields
		public bool shouldClear; // 0x00
		public IVec4 eleNum; // 0x04
	
		// Methods
		public bool IsValid(); // 0x0000000184D883E0-0x0000000184D883F0
	}

	[UsedByNativeCode]
	public struct ClothGroupUploadDataMapCPP // TypeDefIndex: 60917
	{
		// Fields
		private IVec4 clothNodeDataMap; // 0x00
		private IVec4 clothBatchMetaDataMap; // 0x10
		private IVec4 clothBatchCacheDataMap; // 0x20
	}

	[UsedByNativeCode]
	public struct ClothMetaDataCPP // TypeDefIndex: 60918
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
	public struct ClothNodeDataCPP // TypeDefIndex: 60921
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
		public struct _neighborClothNodeCacheIdx_e__FixedBuffer // TypeDefIndex: 60919
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _neighborClothNodeDistance_e__FixedBuffer // TypeDefIndex: 60920
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct GpuClothGroupUploadDataCPP // TypeDefIndex: 60922
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
		public bool IsValid(); // 0x0000000184D883E0-0x0000000184D883F0
	}

	[UsedByNativeCode]
	public struct ClothConstDataCPP // TypeDefIndex: 60924
	{
		// Fields
		private Vector4 packedDeltaT; // 0x00
		private Vector4 clothParam1; // 0x10
		private unsafe fixed /* 0x00000000-0x00000000 */ float colliderInfos[0]; // 0x20
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _colliderInfos_e__FixedBuffer // TypeDefIndex: 60923
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct GpuClothRenderDataCPP // TypeDefIndex: 60925
	{
		// Fields
		public bool isValid; // 0x00
		public int clothNum; // 0x04
		public ClothConstDataCPP clothConstData; // 0x08
	
		// Methods
		public bool IsValid(); // 0x0000000184D883E0-0x0000000184D883F0
	}

	[NativeHeader("Modules/HGGraphics/Public/GpuCloth/GpuClothManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGpuClothManager()", StaticAccessorType.Dot)]
	public static class HGGpuClothManagerV2 // TypeDefIndex: 60926
	{
		// Methods
		public static void SetupGpuClothManager(Mesh defaultCapsuleMesh); // 0x00000001839455D0-0x0000000183945610
		public static void SetWindDirection(Vector3 direction); // 0x0000000185395644-0x0000000185395654
		public static void SetPlayerCenter(Vector3 playerCenter); // 0x0000000185395654-0x0000000185395664
		public static void UpdateCharacterPositions(List<Vector3> positions); // 0x00000001833A4340-0x00000001833A4390
		public static unsafe void UpdateCharacterPositions(Vector3* positionPtr, int count); // 0x00000001833A4430-0x00000001833A4480
		public static bool IsClothSkeletonValid(); // 0x000000018B3F96A4-0x000000018B3F96D0
		public static bool IsClothSkeletonFlipped(); // 0x000000018B3F9678-0x000000018B3F96A4
		public static bool ShouldStep(); // 0x000000018B3F96D0-0x000000018B3F96FC
		public static GpuClothClearBufferDataCPP GetClearBufferData_CSharpWrapper(); // 0x000000018B3F94B4-0x000000018B3F94D8
		public static GpuClothGroupUploadDataCPP GetUploadData_CSharpWrapper(); // 0x000000018B3F9648-0x000000018B3F9678
		public static GpuClothRenderDataCPP GetRenderData_CSharpWrapper(); // 0x000000018B3F95BC-0x000000018B3F95E8
		public static uint GetSkeletonBufferID(); // 0x000000018B3F95E8-0x000000018B3F9614
		public static uint GetClothNodeBufferID(); // 0x000000018B3F955C-0x000000018B3F9588
		public static uint GetClothMetaDataBufferID(); // 0x000000018B3F9530-0x000000018B3F955C
		public static uint GetClothBatchMetaDataBufferID(); // 0x000000018B3F9504-0x000000018B3F9530
		public static uint GetClothBatchCacheMapBufferID(); // 0x000000018B3F94D8-0x000000018B3F9504
		private static void SetWindDirection_Injected(ref Vector3 direction); // 0x0000000183C072F0-0x0000000183C07330
		private static void SetPlayerCenter_Injected(ref Vector3 playerCenter); // 0x0000000183C072B0-0x0000000183C072F0
		private static void GetClearBufferData_CSharpWrapper_Injected(out GpuClothClearBufferDataCPP ret); // 0x000000018B3F9480-0x000000018B3F94B4
		private static void GetUploadData_CSharpWrapper_Injected(out GpuClothGroupUploadDataCPP ret); // 0x000000018B3F9614-0x000000018B3F9648
		private static void GetRenderData_CSharpWrapper_Injected(out GpuClothRenderDataCPP ret); // 0x000000018B3F9588-0x000000018B3F95BC
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGLODSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetLODStateSystem()", StaticAccessorType.Dot)]
	public static class HGLODStateSystem // TypeDefIndex: 60927
	{
		// Methods
		public static bool IsCurrFrameTriggerTransition(); // 0x00000001838B4AB0-0x00000001838B4AF0
		public static float GetLODTransitionFraction(); // 0x00000001838B4150-0x00000001838B4190
		public static float GetLODTransitionTime(); // 0x0000000184B462E0-0x0000000184B46320
		public static void SetLODTransitionTime(float lodTransitionTime); // 0x00000001846540C0-0x0000000184654110
	}

	[Flags]
	public enum LODStreamingStatus : byte // TypeDefIndex: 60928
	{
		Idle = 0,
		Loading = 1,
		Unloading = 2,
		Disabled = 4
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGLODStreamingSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetLODStreamingSystem()", StaticAccessorType.Dot)]
	public static class HGLODStreamingSystem // TypeDefIndex: 60929
	{
		// Properties
		public static bool enableLODStreaming { [NativeName("GetEnableLODStreaming")] get; [NativeName("SetEnableLODStreaming")] set; } // 0x0000000184CD9340-0x0000000184CD9380 0x0000000184D33960-0x0000000184D339A0
		public static bool enableLODStreamingKeepLastLODResource { [NativeName("SetEnableLODStreamingKeepLastLODResource")] set; } // 0x00000001838B4070-0x00000001838B40B0
		public static LODCrossFadeConfig lodConfig { [NativeName("SetLODConfig")] set; } // 0x0000000185393E30-0x0000000185393E40
		public static float lodStreamingLoadDirtyDistance { [NativeName("SetLODStreamingLoadDirtyDistance")] set; } // 0x00000001838B40B0-0x00000001838B4100
		public static float lodStreamingUnloadDirtyDistance { [NativeName("SetLODStreamingUnloadDirtyDistance")] set; } // 0x00000001838B4100-0x00000001838B4150
	
		// Methods
		public static void SetArtTagLODStreamingOffset(uint artTag, int lodStreamingOffset); // 0x00000001841E09A0-0x00000001841E09F0
		public static void SetHLODUnloadDistance(int hlodLevel, float unloadDistance); // 0x00000001838B3E70-0x00000001838B3EC0
		public static LODStreamingStatus QueryLODStreamingStatus(); // 0x000000018B3F9DF4-0x000000018B3F9E20
		private static void set_lodConfig_Injected(ref LODCrossFadeConfig value); // 0x00000001838B2110-0x00000001838B2150
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGShadingStateSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetShadingStateSystem()", StaticAccessorType.Dot)]
	public static class HGShadingStateSystem // TypeDefIndex: 60930
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static UnityAction<int, bool> shadingStateChanged; // 0x00
	
		// Events
		public static event UnityAction<int, bool> shadingStateChanged {
			add; // 0x000000018485FB30-0x000000018485FBD0
			remove; // 0x000000018485FBD0-0x000000018485FC70
		}
	
		// Methods
		public static uint GetMaterialHandle(int instanceId); // 0x0000000184162940-0x0000000184162980
		public static Material GetMaterial(uint handle); // 0x000000018B3FAA38-0x000000018B3FAA6C
		[RequiredByNativeCode]
		private static void Internal_OnShadingStateChanged(int instanceId, bool state); // 0x000000018B3FAA6C-0x000000018B3FAACC
		public static void FlushAllMaterialCallbacks(); // 0x000000018485FAF0-0x000000018485FB30
		public static void SetupGpuSceneUploadCs(ComputeShader cs); // 0x00000001839454D0-0x0000000183945510
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGGeometrySystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGeometrySystem()", StaticAccessorType.Dot)]
	public static class HGGeometrySystem // TypeDefIndex: 60931
	{
		// Methods
		public static uint GetGeometryHandle(int instanceId); // 0x000000018B3F944C-0x000000018B3F9480
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGGeometrySystem.h")]
	[StaticAccessor("HyperGryph::GetMeshBufferAllocator()", StaticAccessorType.Arrow)]
	public static class HGMeshBufferAllocator // TypeDefIndex: 60932
	{
		// Methods
		public static void GarbageCollect(); // 0x0000000182ED1E60-0x0000000182ED4350
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGCullingSystem.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGVATBLASManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGRendererSystem.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceSetup.h")]
	[NativeHeader("Runtime/GfxDevice/hg/HGTempBuffer.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGGeometryJobRendererUtils.h")]
	public static class HGGraphicsUtils // TypeDefIndex: 60933
	{
		// Properties
		public static bool enableRayTracing { [FreeFunction("GetEnableRayTracing")] get; [FreeFunction("SetEnableRayTracing")] set; } // 0x0000000184D11750-0x0000000184D11790 0x0000000184A1EBD0-0x0000000184A1EC10
		public static bool enableRayTracingRender { [FreeFunction("GetEnableRayTracingRender")] get; [FreeFunction("SetEnableRayTracingRender")] set; } // 0x0000000183F9BC70-0x0000000183F9BCB0 0x0000000184A1EB90-0x0000000184A1EBD0
		public static bool enableFactoryRayTracing { [FreeFunction("HyperGryph::GetEnableFactoryRayTracing")] get; } // 0x00000001838AC880-0x00000001838AC8C0 
		public static bool enableECSRenderer { [FreeFunction("GetEnableECSRenderer")] get; } // 0x000000018B3F98FC-0x000000018B3F9928 
		public static bool enableHGNewGraphicsAPI { [FreeFunction("GetEnableHGNewGraphicsAPI")] get; } // 0x000000018B3F9928-0x000000018B3F9954 
		public static bool enableCppRenderPath { [FreeFunction("GetEnableCppRenderPath")] get; } // 0x0000000183F95430-0x0000000183F95470 
		public static int maxAnisoLevel { [FreeFunction("GetHGMaxAnisoLevel")] get; [FreeFunction("SetHGMaxAnisoLevel")] set; } // 0x000000018B3F9954-0x000000018B3F9980 0x0000000184B87D90-0x0000000184B87E20
		public static bool enableRenderingCommandBufferDirectCall { [FreeFunction("SetEnableRenderingCommandBufferDirectCall")] set; } // 0x0000000183F30F80-0x0000000183F30FC0
		public static double gpuDuration { [FreeFunction("HGGetGpuDuration")] get; } // 0x0000000182ED1D70-0x0000000182ED1DC0 
	
		// Methods
		[FreeFunction("HGAllocateTempVertexBuffer")]
		public static CBHandle HGAllocateTempVertexBuffer(int size); // 0x000000018B3F9898-0x000000018B3F98C8
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint AllocateTempCompoundRendererListFromScript(ref IntPtr outPtr); // 0x000000018B3F96FC-0x000000018B3F9730
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static bool IsCompoundRendererListDrawable(uint id); // 0x000000018B3F98C8-0x000000018B3F98FC
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static void PrepareGeometryJobRenderersForRendering(); // 0x0000000183F9BCB0-0x0000000183F9BCF0
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint CreateMetalFXSpatialScaler(int inputWidth, int inputWeight, int outputWidth, int outputHeight, GraphicsFormat colorTextureFormat, GraphicsFormat outputTextureFormat); // 0x000000018B3F9730-0x000000018B3F9790
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static void DestroyMetalFXSpatialScaler(uint spatialScalerHandle); // 0x000000018B3F97F0-0x000000018B3F9824
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint CreateMetalFXTemporalScaler(int inputWidth, int inputWeight, int outputWidth, int outputHeight, GraphicsFormat colorTextureFormat, GraphicsFormat depthTextureFormat, GraphicsFormat motionTextureFormat, GraphicsFormat outputTextureFormat); // 0x000000018B3F9790-0x000000018B3F97F0
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static void DestroyMetalFXTemporalScaler(uint temporalScalerHandle); // 0x000000018B3F9824-0x000000018B3F9858
		private static void HGAllocateTempVertexBuffer_Injected(int size, out CBHandle ret); // 0x000000018B3F9858-0x000000018B3F9898
	}

	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGRendererSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
	public static class HGRendererSystem // TypeDefIndex: 60934
	{
		// Properties
		public static Vector3 PerRendererLightingFallbackPosition { set; } // 0x000000018B3FA830-0x000000018B3FA840
		public static uint MaxPerRendererLightingCount { get; } // 0x000000018B3FA79C-0x000000018B3FA7C8 
		public static uint CSMStopRenderCharacterCascadeLevel { set; } // 0x000000018B3FA7C8-0x000000018B3FA7FC
	
		// Methods
		private static void set_PerRendererLightingFallbackPosition_Injected(ref Vector3 value); // 0x000000018B3FA7FC-0x000000018B3FA830
	}

	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[StaticAccessor("GetHGGlobalGameManager()", StaticAccessorType.Dot)]
	public static class HGLogicTimeManager // TypeDefIndex: 60935
	{
		// Methods
		public static void SetLogicTickDeltaTime(float deltaTime); // 0x0000000183B0C5A0-0x0000000183B0C5F0
		public static void SetLogicTickDeltaTimeNoScale(float deltaTime); // 0x0000000183B0C5F0-0x0000000183B0C640
		public static void SetHgrpDeltaTime(float deltaTime); // 0x00000001832E2690-0x00000001832E26E0
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGGrassRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGrassRender()", StaticAccessorType.Dot)]
	public static class HGGrassRender // TypeDefIndex: 60936
	{
		// Properties
		public static float grassGlobalSparsity { set; } // 0x00000001848E0E30-0x00000001848E0E80
	
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool noAlphaTest = false /* Metadata: 0x0234EEA7 */); // 0x000000018B3F9980-0x000000018B3F99B0
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr, bool noAlphaTest); // 0x000000018B3F99B0-0x000000018B3F9A10
		public static uint RegisterGrassBatchGroup(uint batchGroupKey, Material material, Mesh mesh, ushort subMeshIndex); // 0x000000018B3F9A2C-0x000000018B3F9A90
		public static void UnregisterGrassBatchGroupWithHandle(uint batchGroupKey, uint batchGroupHandle); // 0x000000018B3F9A90-0x000000018B3F9AD0
		public static bool IsInGrassBoundsV2(Vector3 worldPos, out Bounds overlapBounds, out Bounds originBounds, out uint argTag); // 0x0000000185391B50-0x0000000185391B68
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018B3F9A10-0x000000018B3F9A2C
		private static bool IsInGrassBoundsV2_Injected(ref Vector3 worldPos, out Bounds overlapBounds, out Bounds originBounds, out uint argTag); // 0x0000000183E418B0-0x0000000183E41920
	}

	public enum EInteractionProxyType : uint // TypeDefIndex: 60937
	{
		Sphere = 0,
		Capsule = 1,
		Texture = 2,
		Mesh = 3
	}

	[UsedByNativeCode]
	public struct HGInteractionNodeV2 // TypeDefIndex: 60938
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

	[UsedByNativeCode]
	public struct HGDecalInteractionParametersV2 // TypeDefIndex: 60939
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

	[NativeHeader("Modules/HGGraphics/Public/Interaction/HGInteractionManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/Interaction/HGDecalInteraction.h")]
	public static class HGInteractionManagerV2 // TypeDefIndex: 60940
	{
		// Methods
		public static void UpdateFromNodes(NativeArray<HGInteractionNodeV2> nodes, int nodeCount, bool bUpdateMobile); // 0x0000000183E45910-0x0000000183E45970
		[StaticAccessor("GetHGGlobalGameManager().GetInteractionManager()", StaticAccessorType.Dot)]
		public static void UpdateFromNodes(IntPtr nodeData, int nodeCount, bool bUpdateMobile); // 0x0000000183E45970-0x0000000183E459D0
		[StaticAccessor("GetHGGlobalGameManager().GetInteractionManager()", StaticAccessorType.Dot)]
		public static void UpdateSettingParameters(HGDecalInteractionParametersV2 settingParameters); // 0x000000018B3F9AD0-0x000000018B3F9AE0
		private static void UpdateSettingParameters_Injected(ref HGDecalInteractionParametersV2 settingParameters); // 0x0000000183F31030-0x0000000183F31070
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumeConfig // TypeDefIndex: 60952
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
		public struct _perLOD_e__FixedBuffer // TypeDefIndex: 60941
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHalfChunkCounts_e__FixedBuffer // TypeDefIndex: 60942
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHashTableOffsets_e__FixedBuffer // TypeDefIndex: 60943
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHashTableSizes_e__FixedBuffer // TypeDefIndex: 60944
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perPhysicalTextureOffsets_e__FixedBuffer // TypeDefIndex: 60945
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perPhysicalTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 60946
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perFrameMaxLoadingByteCount_e__FixedBuffer // TypeDefIndex: 60947
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perFrameMaxUploadChunkCount_e__FixedBuffer // TypeDefIndex: 60948
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _ClipmapTextureSize_e__FixedBuffer // TypeDefIndex: 60949
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _blockSizesV3_e__FixedBuffer // TypeDefIndex: 60950
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _cameraForwardBiasForYAxis_e__FixedBuffer // TypeDefIndex: 60951
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumePipelineUpdateResult // TypeDefIndex: 60953
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
	public class HGIrradianceVolume // TypeDefIndex: 60954
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static long Create([IsReadOnly] in HGIrradianceVolumeConfig config); // 0x0000000184D513F0-0x0000000184D51430
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void Destroy(long id); // 0x000000018B3F9CF4-0x000000018B3F9D28
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetEnableV3(bool enable); // 0x0000000183F30EC0-0x0000000183F30F00
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void EnableBurstMode(); // 0x0000000182ED1E10-0x0000000182ED1E60
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void DisableBurstMode(); // 0x0000000182ED1DC0-0x0000000182ED1E10
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetSceneStateNames(string[] stateNames, string[] activateStates); // 0x0000000183A86C70-0x0000000183A86CC0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateNames(string[] activateNames); // 0x000000018B3F9D28-0x000000018B3F9D5C
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateMask(uint mask); // 0x00000001845FB540-0x00000001845FB580
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static string[] GetActiveSceneStateNames(); // 0x0000000183A86C30-0x0000000183A86C70
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetMapV3(long id, string path); // 0x0000000184D32FB0-0x0000000184D33000
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void StreamingInCabin(long id, string slotId, uint roomTypeId); // 0x000000018B3F9D5C-0x000000018B3F9DB0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void StreamingOutCabin(long id, string slotId); // 0x000000018B3F9DB0-0x000000018B3F9DF4
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetStreamingCenter(long id, Vector3 center); // 0x00000001853920CC-0x00000001853920E0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResult result, long id, IntPtr renderContext, CommandBuffer cmd, int bakeCS, int updateIndirectionCS); // 0x00000001833397E0-0x0000000183339850
		private static void SetStreamingCenter_Injected(long id, ref Vector3 center); // 0x0000000183EC9780-0x0000000183EC97D0
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumeConfigV2 // TypeDefIndex: 60974
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
		public struct _basisBaseGridDim_e__FixedBuffer // TypeDefIndex: 60955
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _basisVoxelDataDim_e__FixedBuffer // TypeDefIndex: 60956
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perCoeffLodBudget_e__FixedBuffer // TypeDefIndex: 60957
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBasisLodBudget_e__FixedBuffer // TypeDefIndex: 60958
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perLOD_e__FixedBuffer // TypeDefIndex: 60959
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHalfStreamingChunkCountsX_e__FixedBuffer // TypeDefIndex: 60960
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHalfStreamingChunkCountsY_e__FixedBuffer // TypeDefIndex: 60961
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perHalfStreamingChunkCountsZ_e__FixedBuffer // TypeDefIndex: 60962
		{
			// Fields
			public int FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perRawBufferOffsets_e__FixedBuffer // TypeDefIndex: 60963
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perRawBufferCounts_e__FixedBuffer // TypeDefIndex: 60964
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBlockInfoBufferOffsets_e__FixedBuffer // TypeDefIndex: 60965
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBlockInfoSize_e__FixedBuffer // TypeDefIndex: 60966
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBasisTextureOffset_e__FixedBuffer // TypeDefIndex: 60967
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perBasisTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 60968
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perCoeffTextureOffset_e__FixedBuffer // TypeDefIndex: 60969
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perCoeffTextureBlockCounts_e__FixedBuffer // TypeDefIndex: 60970
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perFrameMaxLoadingByteCount_e__FixedBuffer // TypeDefIndex: 60971
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perFrameMaxUploadChunkCount_e__FixedBuffer // TypeDefIndex: 60972
		{
			// Fields
			public uint FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _streamingCenterBias_e__FixedBuffer // TypeDefIndex: 60973
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumePipelineUpdateResultV2 // TypeDefIndex: 60975
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
	public class HGIrradianceVolumeV2 // TypeDefIndex: 60976
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static long Create([IsReadOnly] in HGIrradianceVolumeConfigV2 config); // 0x0000000184D72880-0x0000000184D728C0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void Destroy(long id); // 0x000000018B3F9AE0-0x000000018B3F9B14
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetSceneStateNames(string[] stateNames, string[] activateStates); // 0x0000000183A86B70-0x0000000183A86BC0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateNames(string[] activateStates); // 0x000000018B3F9B78-0x000000018B3F9BAC
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateMask(uint mask); // 0x00000001845FB5C0-0x00000001845FB600
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static string[] GetActiveSceneStateNames(); // 0x0000000183A86B30-0x0000000183A86B70
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetMap(long id, string path); // 0x0000000184D33000-0x0000000184D33050
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetStreamingCenter(long id, Vector3 center); // 0x000000018B3F9C48-0x000000018B3F9C5C
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetCameraForwardDirection(long id, Vector3 cameraForwardDir); // 0x000000018B3F9BF0-0x000000018B3F9C04
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResultV2 result, long id, IntPtr renderContext, CommandBuffer cmd, int bakeCS, int updateClipmapCS); // 0x000000018B3F9B14-0x000000018B3F9B78
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void StreamingInCabin(long id, long slotId, uint roomTypeId); // 0x000000018B3F9C5C-0x000000018B3F9CB0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void StreamingOutCabin(long id, long slotId); // 0x000000018B3F9CB0-0x000000018B3F9CF4
		private static void SetStreamingCenter_Injected(long id, ref Vector3 center); // 0x000000018B3F9C04-0x000000018B3F9C48
		private static void SetCameraForwardDirection_Injected(long id, ref Vector3 cameraForwardDir); // 0x000000018B3F9BAC-0x000000018B3F9BF0
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGMeshRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetMeshRender()", StaticAccessorType.Dot)]
	public static class HGMeshRender // TypeDefIndex: 60977
	{
		// Methods
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalKeywords, IntPtr context, bool multiDraw, bool transparentSorting, uint cullingLayerMask, bool noAlphaTest, uint* drawableFeedbackPtr, bool excludeGPUDriven); // 0x000000018B3FA184-0x000000018B3FA1F8
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, bool excludeGPUDriven); // 0x000000018B3FA01C-0x000000018B3FA07C
		private static uint CreateRendererListWithCharacterIndex(uint viewHandle, ushort characterIndex, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalHGKeywords, IntPtr context); // 0x000000018B3F9F94-0x000000018B3FA000
		private static unsafe uint CreateRendererListFromEntities(Entity* entities, uint entityCount, Vector3 cameraPosition, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalHGKeywords, IntPtr context, uint cullingLayerMask); // 0x000000018B3F9F40-0x000000018B3F9F94
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, bool multiDraw = false /* Metadata: 0x0234EEAC */, bool transparentSorting = false /* Metadata: 0x0234EEAD */, uint cullingLayerMask = 4294967295 /* Metadata: 0x0234EEAE */, bool noAlphaTest = false /* Metadata: 0x0234EEAF */, bool excludeGPUDriven = false /* Metadata: 0x0234EEB0 */); // 0x000000018B3FA0A4-0x000000018B3FA110
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, IntPtr drawableFeedbackPtr, bool multiDraw = false /* Metadata: 0x0234EEB1 */, bool transparentSorting = false /* Metadata: 0x0234EEB2 */, uint cullingLayerMask = 4294967295 /* Metadata: 0x0234EEB3 */, bool noAlphaTest = false /* Metadata: 0x0234EEB4 */, bool excludeGPUDriven = false /* Metadata: 0x0234EEB5 */); // 0x000000018B3FA110-0x000000018B3FA184
		public static uint CreateRendererListWithCharacterIndex(uint viewHandle, ushort characterIndex, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context); // 0x000000018B3FA000-0x000000018B3FA01C
		public static uint CreateRendererListFromEntities(NativeArray<Entity> entities, Vector3 cameraPosition, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, uint cullingLayerMask = 4294967295 /* Metadata: 0x0234EEB6 */); // 0x000000018B3F9E90-0x000000018B3F9F40
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, out uint normalList, out uint preZPart0List, out uint preZPart1List, bool excludeGPUDriven = false /* Metadata: 0x0234EEB7 */); // 0x000000018B3FA07C-0x000000018B3FA0A4
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018B3FA224-0x000000018B3FA240
		public static void DrawECSMeshRendererListWithSRPRendererList(CommandBuffer cmd, uint ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList); // 0x000000018B3FA1F8-0x000000018B3FA224
		private static unsafe uint CreateRendererListFromEntities_Injected(Entity* entities, uint entityCount, ref Vector3 cameraPosition, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalHGKeywords, IntPtr context, uint cullingLayerMask); // 0x000000018B3F9E20-0x000000018B3F9E90
	}

	[NativeType("Modules/HGGraphics/Public/RayTracing/HGRayTracingScene.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetRayTracingScene()", StaticAccessorType.Dot)]
	public static class HGRayTracingScene // TypeDefIndex: 60978
	{
		// Methods
		public static uint AddCullViewHandle(ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, LODCrossFadeConfig config, float viewScreenSizeMinSquared, float cullingRadius); // 0x000000018B3FA59C-0x000000018B3FA5D8
		public static uint PrepareTLASCreationForCullView(uint viewHandle); // 0x000000018B3FA5D8-0x000000018B3FA60C
		public static void SetupGpuSceneUploadCs(ComputeShader cs); // 0x0000000183945510-0x0000000183945550
		private static uint AddCullViewHandle_Injected(ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, ref LODCrossFadeConfig config, float viewScreenSizeMinSquared, float cullingRadius); // 0x000000018B3FA53C-0x000000018B3FA59C
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGReflectionProbeSystem.h")]
	public class HGReflectionProbe // TypeDefIndex: 60979
	{
		// Properties
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()")]
		public static float cameraMovementNotFadeness { get; } // 0x000000018B3FA770-0x000000018B3FA79C 
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()")]
		public static float fadeTime { get; } // 0x0000000183F9BC30-0x0000000183F9BC70 
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static uint AddView(Camera camera); // 0x0000000184D2BBB0-0x0000000184D2BBF0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void RemoveView(uint viewHandle); // 0x0000000184D513B0-0x0000000184D513F0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void ResetView(uint viewHandle); // 0x0000000184D2BB70-0x0000000184D2BBB0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewPhase0(uint viewHandle, Vector3 cameraPosition, Vector3 visibleBox, bool loadSync = false /* Metadata: 0x0234EEB8 */); // 0x00000001853925EC-0x0000000185392604
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewPhase1(uint viewHandle, float dt, bool enableFadeness, IntPtr blitList, int maxBlitCount, out int blitCount); // 0x000000018B3FA710-0x000000018B3FA770
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewCBHandle(uint viewHandle, Matrix4x4 worldToCameraMatrix, Matrix4x4 unitExtents, IntPtr binningBufferPtr, IntPtr globalBufferPtr); // 0x000000018B3FA6EC-0x000000018B3FA710
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static Texture GetTexture(uint viewHandle, ulong hash); // 0x000000018B3FA64C-0x000000018B3FA68C
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static int GetTextureIndex(uint viewHandle, ulong hash); // 0x000000018B3FA60C-0x000000018B3FA64C
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void SetViewTextureArrayCount(uint viewHandle, int count); // 0x0000000184D112C0-0x0000000184D11310
		private static void UpdateViewPhase0_Injected(uint viewHandle, ref Vector3 cameraPosition, ref Vector3 visibleBox, bool loadSync = false /* Metadata: 0x0234EEB9 */); // 0x0000000183E4FDB0-0x0000000183E4FE20
		private static void UpdateViewCBHandle_Injected(uint viewHandle, ref Matrix4x4 worldToCameraMatrix, ref Matrix4x4 unitExtents, IntPtr binningBufferPtr, IntPtr globalBufferPtr); // 0x000000018B3FA68C-0x000000018B3FA6EC
	}

	public enum AssetType // TypeDefIndex: 60980
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

	public enum AssetPriority : ushort // TypeDefIndex: 60981
	{
		Preload = 0,
		LODStreaming = 5,
		Default = 10,
		Streaming = 15
	}

	public enum AssetState : byte // TypeDefIndex: 60982
	{
		Loading = 0,
		Loaded = 1,
		Failed = 2
	}

	public struct VFSBlockFileInfo // TypeDefIndex: 60983
	{
		// Fields
		public ulong offset; // 0x00
		public ulong len; // 0x08
		public string chunkFilePath; // 0x10
	}

	public struct AssetIdentifier // TypeDefIndex: 60984
	{
		// Fields
		public long hash; // 0x00
		public AssetType type; // 0x08
	}

	public struct AssetHandleIndex // TypeDefIndex: 60985
	{
		// Fields
		public uint index; // 0x00
	}

	public struct AssetOperation // TypeDefIndex: 60986
	{
		// Fields
		public bool isLoadOperation; // 0x00
		public AssetPriority priority; // 0x02
		public AssetHandleIndex handleIndex; // 0x04
		public AssetIdentifier identifier; // 0x08
	}

	[NativeHeader("Modules/HGGraphics/Public/HGResourceManager.bindings.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetHGResourceManager()", StaticAccessorType.Dot)]
	public static class HGResourceManager // TypeDefIndex: 60990
	{
		// Fields
		public static GetFileHashMappingCallback getFileHashMappingCallback; // 0x00
		public static GetFilePathMappingCallback getFilePathMappingCallback; // 0x08
		public static GetTextureFromHGWaterSectorDataCallback getWaterSectorTextureCallback; // 0x10
		private static readonly System.Type[] kAssetTypeToUnityType; // 0x18
	
		// Properties
		public static bool usingVFS { [NativeName("SetUsingVFS")] set; } // 0x0000000183F2EF70-0x0000000183F2EFB0
		public static IntPtr assetOperations { get; } // 0x0000000183CCA7C0-0x0000000183CCA800 
		public static int assetOperationCount { get; } // 0x0000000183CCA800-0x0000000183CCA840 
	
		// Nested types
		public delegate VFSBlockFileInfo GetFileHashMappingCallback(long originNameHash); // TypeDefIndex: 60987; 0x0000000185FD6454-0x0000000185FD648C
	
		public delegate VFSBlockFileInfo GetFilePathMappingCallback(string originName); // TypeDefIndex: 60988; 0x0000000185FD6454-0x0000000185FD648C
	
		public delegate Texture2D GetTextureFromHGWaterSectorDataCallback(ScriptableObject sectorDataScriptableObject); // TypeDefIndex: 60989; 0x00000001814E2060-0x00000001814E2070
	
		// Constructors
		static HGResourceManager(); // 0x000000018485BD80-0x000000018485C060
	
		// Methods
		public static AssetHandleIndex LoadAsync(long assetHash, AssetType type, AssetPriority priority); // 0x0000000183E4B6F0-0x0000000183E4B780
		public static void UpdateAssetHandle(AssetHandleIndex handleIndex, AssetIdentifier identifier, AssetState state, int assetInstanceID); // 0x0000000183B9F6F0-0x0000000183B9F770
		public static void ClearAssetOperations(); // 0x0000000183F953F0-0x0000000183F95430
		public static void Reset(); // 0x0000000182ED79E0-0x0000000182ED7A20
		[RequiredByNativeCode]
		public static VFSBlockFileInfo GetFileHashMapping(long originNameHash); // 0x00000001833510E0-0x0000000183351170
		[RequiredByNativeCode]
		public static VFSBlockFileInfo GetFilePathMapping(string originName); // 0x000000018B3FA8D4-0x000000018B3FA96C
		[RequiredByNativeCode]
		public static Texture2D GetTextureFromHGWaterSectorData(ScriptableObject sectorDataScriptableObject); // 0x000000018B3FA96C-0x000000018B3FA9D4
		public static NativeArray<AssetOperation> GetAssetOperationsArray(); // 0x000000018B3FA840-0x000000018B3FA8D4
		private static void LoadAsync_Injected(long assetHash, AssetType type, AssetPriority priority, out AssetHandleIndex ret); // 0x0000000183E4B780-0x0000000183E4B7F0
		private static void UpdateAssetHandle_Injected(ref AssetHandleIndex handleIndex, ref AssetIdentifier identifier, AssetState state, int assetInstanceID); // 0x0000000183B9F770-0x0000000183B9F7E0
	
		// Extension methods
		public static System.Type ToUnityType(this AssetType type); // 0x000000018B3FA9D4-0x000000018B3FAA38
	}

	[Flags]
	public enum HGRenderFlags : uint // TypeDefIndex: 60991
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
	public enum HGRenderKeyword : ushort // TypeDefIndex: 60992
	{
		None = 0,
		CrossFade = 1,
		Dither = 2
	}

	[Flags]
	public enum HGShaderLightMode : uint // TypeDefIndex: 60993
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
		GPUParticleSimulate = 1073741824
	}

	[Flags]
	public enum HGObjectFlags : uint // TypeDefIndex: 60994
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
	public enum HGFactoryDirtyFlags : byte // TypeDefIndex: 60995
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
	public struct IVec2 // TypeDefIndex: 60996
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
	}

	[UsedByNativeCode]
	public struct IVec4 // TypeDefIndex: 60997
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public int w; // 0x0C
	}

	[UsedByNativeCode]
	public struct SludgeNodeData // TypeDefIndex: 60999
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
		public struct _patchAABBData_e__FixedBuffer // TypeDefIndex: 60998
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct SludgeHeightmapInfo // TypeDefIndex: 61000
	{
		// Fields
		public Vector4 heightmapUVOffsetScale; // 0x00
		public Texture2D heightmapAtlas; // 0x10
	}

	[NativeType("Modules/HGGraphics/Public/Sludge/HGSludgeRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetSludgeRender()", StaticAccessorType.Dot)]
	public static class HGSludgeRender // TypeDefIndex: 61001
	{
		// Methods
		public static bool RegisterSludge(Entity entity, Texture2D bakedHeightmap, NativeArray<SludgeNodeData> nodeData); // 0x0000000184162980-0x00000001841629F0
		private static bool RegisterSludge(Entity entity, Texture2D bakedHeightmap, int nodeCount, IntPtr nodeData); // 0x0000000185397024-0x0000000185397048
		public static void UnregisterAndDestroySludge(Entity entity); // 0x00000001853937D0-0x00000001853937EC
		public static uint CreateRendererList(Camera camera, Vector2Int sceneRTSize, uint viewHandle, HGShaderLightMode lightModeMask, HGShaderLightMode decalLightModeMask, float lodFactor, IntPtr context, bool useMetric = true /* Metadata: 0x0234EFF1 */); // 0x000000018B3FAB30-0x000000018B3FAB4C
		private static uint CreateRendererList(Camera camera, Vector2Int sceneRTSize, uint viewHandle, uint lightModeMask, uint decalLightModeMask, float loadFactor, IntPtr context, bool useMetric); // 0x000000018B3FAB4C-0x000000018B3FABA0
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customPros); // 0x000000018B3FAC40-0x000000018B3FAC90
		public static void DrawECSDecalRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customProps); // 0x000000018B3FABF0-0x000000018B3FAC40
		public static void DrawECSBlendRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customProps); // 0x000000018B3FABA0-0x000000018B3FABF0
		public static void HitSludge(Entity entity, Vector3 worldPos, float range, float deltaHeightNormalized = 1f /* Metadata: 0x0234EFF2 */); // 0x000000018B3FADFC-0x000000018B3FAE20
		public static SludgeHeightmapInfo GetHeightmapInfo(Entity entity); // 0x000000018B3FAD64-0x000000018B3FAD98
		public static uint GetDynamicThicknessMapSize(); // 0x000000018B3FACF4-0x000000018B3FAD20
		public static bool ShouldDrawThicknessMap(); // 0x000000018B3FAE20-0x000000018B3FAE4C
		public static void DrawThicknessMap(IntPtr context, CommandBuffer cmd, Material blitMat, int passIdx, int viewHandle); // 0x000000018B3FAC90-0x000000018B3FACF4
		private static bool RegisterSludge_Injected(ref Entity entity, Texture2D bakedHeightmap, int nodeCount, IntPtr nodeData); // 0x00000001848AC570-0x00000001848AC5E0
		private static void UnregisterAndDestroySludge_Injected(ref Entity entity); // 0x0000000184B46450-0x0000000184B46490
		private static uint CreateRendererList_Injected(Camera camera, ref Vector2Int sceneRTSize, uint viewHandle, uint lightModeMask, uint decalLightModeMask, float loadFactor, IntPtr context, bool useMetric); // 0x000000018B3FAACC-0x000000018B3FAB30
		private static void HitSludge_Injected(ref Entity entity, ref Vector3 worldPos, float range, float deltaHeightNormalized = 1f /* Metadata: 0x0234EFF6 */); // 0x000000018B3FAD98-0x000000018B3FADFC
		private static void GetHeightmapInfo_Injected(ref Entity entity, out SludgeHeightmapInfo ret); // 0x000000018B3FAD20-0x000000018B3FAD64
	}

	public enum SplineEmissionType // TypeDefIndex: 61002
	{
		Box = 0,
		Mesh = 1
	}

	public enum SplineEmissionMeshType // TypeDefIndex: 61003
	{
		Triangle = 0,
		Vertex = 1,
		Edge = 2
	}

	[Serializable]
	[UsedByNativeCode]
	public struct SplineObjectsDesc // TypeDefIndex: 61004
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
	public struct SplineObjectsKnotData // TypeDefIndex: 61005
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
	public static class HGSplineMovingObjectsManager // TypeDefIndex: 61006
	{
		// Methods
		public static uint CreateInstance(SplineObjectsDesc desc, NativeArray<SplineObjectsKnotData> curveData); // 0x000000018B3FB114-0x000000018B3FB1E4
		[NativeName("AddInstanceToDestroyQueue")]
		public static bool DestroyInstance(uint instanceID); // 0x000000018B3FB1F8-0x000000018B3FB22C
		public static bool UpdateObjectToWorld(uint instanceID, Matrix4x4 objectToWorld); // 0x000000018B3FB2A0-0x000000018B3FB2B4
		public static bool Pause(uint instanceID); // 0x000000018B3FB22C-0x000000018B3FB260
		private static unsafe uint CreateInstance(SplineObjectsDesc desc, SplineObjectsKnotData* curveData, int length); // 0x000000018B3FB1E4-0x000000018B3FB1F8
		private static bool UpdateObjectToWorld_Injected(uint instanceID, ref Matrix4x4 objectToWorld); // 0x000000018B3FB260-0x000000018B3FB2A0
		private static unsafe uint CreateInstance_Injected(ref SplineObjectsDesc desc, SplineObjectsKnotData* curveData, int length); // 0x000000018B3FB0C0-0x000000018B3FB114
	}

	[NativeType("Modules/HGGraphics/Public/Subsurface/HGSubsurfaceProfileManager.h")]
	public static class HGSubsurfaceProfileManager // TypeDefIndex: 61007
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetSubsurfaceProfileManager()", StaticAccessorType.Dot)]
		public static void RegisterFromTerrain(HGSubsurfaceProfile profile); // 0x00000001837E2B50-0x00000001837E2C20
		[StaticAccessor("GetHGGlobalGameManager().GetSubsurfaceProfileManager()", StaticAccessorType.Dot)]
		public static void UnregisterFromTerrain(); // 0x000000018B3FB48C-0x000000018B3FB4B8
	}

	[UsedByNativeCode]
	public struct TerrainInfo // TypeDefIndex: 61008
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
	public struct TerrainNodeData // TypeDefIndex: 61009
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
	public struct SplatLayerData // TypeDefIndex: 61010
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
	public enum ETerrainStreamingState : uint // TypeDefIndex: 61011
	{
		kNotInitialized = 0,
		kHasPendingTasks = 1,
		kAllTaskCleared = 2
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGTerrainManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGTerrain.bindings.h")]
	public class HGTerrainManager // TypeDefIndex: 61012
	{
		// Properties
		public static float minVerticalFieldOfView { [StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)] set; } // 0x0000000184D50BB0-0x0000000184D50C00
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager().GetTerrainStreamer()", StaticAccessorType.Arrow)]
		public static ETerrainStreamingState QueryTerrainStreamingState(); // 0x0000000184D338E0-0x0000000184D33920
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ReadbackVTFeedbackBuffer(int feedbackViewId, CommandBuffer cmd, IntPtr renderContext); // 0x000000018B3FB87C-0x000000018B3FB8CC
		public static void SetupTerrainManager(string atlasPageRootPath, [IsReadOnly] in TerrainInfo terrainInfo, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, NativeArray<UnityEngine.HyperGryph.SplatLayerData> layerData, int splatTier, NativeArray<UnityEngine.HyperGryph.TerrainNodeData> nodeData, NativeArray<ulong> sectorSplatInfo, uint regionHandle, bool enableHalfVTSize, bool enableHalfAtlasSize = false /* Metadata: 0x0234F002 */, GraphicsFormat mobileSplatCtrlAtlasFormat = GraphicsFormat.RGBA_ASTC4X4_UNorm /* Metadata: 0x0234F003 */, bool enableIndirectionCpuUpload = false /* Metadata: 0x0234F005 */, bool enableSplitNormalRO = false /* Metadata: 0x0234F006 */, bool enableCompressUseBuffer = false /* Metadata: 0x0234F007 */, bool atlasPageBytesCompressed = true /* Metadata: 0x0234F008 */); // 0x00000001837E31B0-0x00000001837E3320
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		private static void SetupTerrainManager(string atlasPageRootPath, [IsReadOnly] in TerrainInfo terrainInfo, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, int layerCount, IntPtr layerData, int splatTier, int nodeCount, IntPtr nodeData, int sectorCount, IntPtr sectorSplatInfo, uint regionHandle, bool enableHalfVTSize, bool enableHalfAtlasSize, GraphicsFormat mobileSplatCtrlAtlasFormat, bool enableIndirectionCpuUpload, bool enableSplitNormalRO, bool enableCompressUseBuffer, bool atlasPageBytesCompressed); // 0x00000001837E3320-0x00000001837E33F0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void CleanupTerrainManager(); // 0x000000018B3FB4B8-0x000000018B3FB4E4
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrainAndUpdateVTFeedbackView(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, Vector3 vtUpdateCenter); // 0x000000018B3FB548-0x000000018B3FB5A8
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrain(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext); // 0x000000018B3FB60C-0x000000018B3FB640
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void PrepareDecalRendererListsForVTPages(int feedbackViewId, IntPtr renderContext); // 0x000000018B3FB83C-0x000000018B3FB87C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ExecuteVTUpdateCommand(int feedbackViewId, IntPtr renderContext); // 0x000000018B3FB640-0x000000018B3FB680
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderVTPages(int feedbackViewId, IntPtr renderContext, CommandBuffer copyCmd, CommandBuffer renderCmd, int bakePassIndex, int bc3PassIndex, int astcPassIndex, int bc5PassIndex, int astcRGPassIndex); // 0x000000018B3FB9EC-0x000000018B3FBA4C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderScreenSpaceTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr features); // 0x000000018B3FB8CC-0x000000018B3FB92C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrainAfterGBuffer(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, IntPtr features); // 0x000000018B3FB92C-0x000000018B3FB98C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void UpdateSubdivisionParameters(int mode, int modeV2, int subd, int primitivePixelLengthTargetLog2); // 0x000000018B3FBB74-0x000000018B3FBBD4
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SetTerrainBlendBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId); // 0x000000018B3FBAB0-0x000000018B3FBB14
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SetDecalDeformBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId); // 0x000000018B3FBA4C-0x000000018B3FBAB0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetHeightmapAtlas(); // 0x000000018B3FB6AC-0x000000018B3FB6D8
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetNormalmapAtlas(); // 0x000000018B3FB6D8-0x000000018B3FB704
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetTintColorAtlas(); // 0x000000018B3FB810-0x000000018B3FB83C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetSplatControlAtlas(); // 0x000000018B3FB704-0x000000018B3FB730
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetAlbedoAtlas(); // 0x000000018B3FB680-0x000000018B3FB6AC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetSplatIndexMap(); // 0x000000018B3FB7B8-0x000000018B3FB7E4
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2DArray GetSplatDiffuseArray(); // 0x000000018B3FB78C-0x000000018B3FB7B8
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2DArray GetSplatNormalROArray(); // 0x000000018B3FB7E4-0x000000018B3FB810
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static CBHandle GetSplatDataUBO(); // 0x000000018B3FB764-0x000000018B3FB78C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SubdivisionTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, bool enableSubdivision, bool enableSubdivisionV2, Texture HZBTexture); // 0x000000018B3FBB14-0x000000018B3FBB74
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, int tessellationPassIndex = -1 /* Metadata: 0x0234F009 */, int subdivisionPassIndex = -1 /* Metadata: 0x0234F00A */, bool enableSubdivisionV2 = false /* Metadata: 0x0234F00B */); // 0x000000018B3FB98C-0x000000018B3FB9EC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void StreamingInChunkSurfaceTypeData(uint chunkKey, UIntPtr chunkSurfaceTypeData, int dataLength, int chunkSize); // 0x00000001843EC6E0-0x00000001843EC750
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void StreamingOutChunkSurfaceTypeData(uint chunkKey); // 0x00000001843EC750-0x00000001843EC790
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static bool GetSurfaceTypeByWorldPosition(float x, float y, out int surfaceType); // 0x0000000183287FF0-0x0000000183288050
		private static uint CullTerrainAndUpdateVTFeedbackView_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, ref Vector3 vtUpdateCenter); // 0x000000018B3FB4E4-0x000000018B3FB548
		private static uint CullTerrain_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext); // 0x000000018B3FB5A8-0x000000018B3FB60C
		private static void GetSplatDataUBO_Injected(out CBHandle ret); // 0x000000018B3FB730-0x000000018B3FB764
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGEditorTerrainManager.h")]
	public class HGEditorTerrainManager // TypeDefIndex: 61013
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void SetUseNewEditorTerrainRendering(bool value); // 0x0000000183335D00-0x0000000183335D40
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrainAndUpdateVTFeedbackView(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, Vector3 vtUpdateCenter); // 0x000000018B3F8B40-0x000000018B3F8BA0
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrain(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext); // 0x000000018B3F8C04-0x000000018B3F8C38
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void SetTerrainBlendBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId); // 0x000000018B3F8EE8-0x000000018B3F8F4C
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, int subdivisionPassIndex = -1 /* Metadata: 0x0234F00C */, bool enableSubdivisionV2 = false /* Metadata: 0x0234F00D */); // 0x000000018B3F8E28-0x000000018B3F8E88
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderScreenSpaceTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr features); // 0x000000018B3F8D08-0x000000018B3F8D68
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderSeparateTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int passIndex, IntPtr features); // 0x000000018B3F8D68-0x000000018B3F8DC8
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrainAfterGBuffer(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, IntPtr features); // 0x000000018B3F8DC8-0x000000018B3F8E28
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void BakeAtlasTexture(CommandBuffer cmd, IntPtr renderContext); // 0x000000018B3F8A98-0x000000018B3F8ADC
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void PrepareDecalRendererListsForVTPages(int feedbackViewId, IntPtr renderContext); // 0x000000018B3F8C78-0x000000018B3F8CB8
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void ExecuteVTUpdateCommand(int feedbackViewId, IntPtr renderContext); // 0x000000018B3F8C38-0x000000018B3F8C78
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderVTPages(int feedbackViewId, IntPtr renderContext, CommandBuffer copyCmd, CommandBuffer renderCmd, int bakePass, int bc3Pass, int astcPass); // 0x000000018B3F8E88-0x000000018B3F8EE8
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void ReadbackVTFeedbackBuffer(int feedbackViewId, CommandBuffer cmd, IntPtr renderContext); // 0x000000018B3F8CB8-0x000000018B3F8D08
		private static uint CullTerrainAndUpdateVTFeedbackView_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, ref Vector3 vtUpdateCenter); // 0x000000018B3F8ADC-0x000000018B3F8B40
		private static uint CullTerrain_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext); // 0x000000018B3F8BA0-0x000000018B3F8C04
	}

	[UsedByNativeCode]
	public struct HGTerrainDeformConfigV2 // TypeDefIndex: 61014
	{
		// Fields
		public float m_deformGlobalStrength; // 0x00
		public float m_latency; // 0x04
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGTerrainDeformManager.h")]
	public class HGTerrainDeformManagerV2 // TypeDefIndex: 61015
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainDeformManager()", StaticAccessorType.Dot)]
		public static void SetPlayerCenter(Vector3 position); // 0x00000001853920E0-0x00000001853920F0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainDeformManager()", StaticAccessorType.Dot)]
		public static void UpdateDeformConfig(HGTerrainDeformConfigV2 config); // 0x00000001853957D0-0x00000001853957EC
		private static void SetPlayerCenter_Injected(ref Vector3 position); // 0x00000001841E3130-0x00000001841E3170
		private static void UpdateDeformConfig_Injected(ref HGTerrainDeformConfigV2 config); // 0x0000000183C820E0-0x0000000183C82120
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGTerrainManagerV3.h")]
	public class HGTerrainManagerV3 // TypeDefIndex: 61016
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static void SetPlayerCenter(Vector3 playerCenter); // 0x00000001853920F0-0x0000000185392100
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManagerV3()", StaticAccessorType.Dot)]
		public static void UpdateDeformConfig(HGTerrainDeformConfigV2 config); // 0x00000001853957EC-0x0000000185395808
		private static void SetPlayerCenter_Injected(ref Vector3 playerCenter); // 0x00000001841E30F0-0x00000001841E3130
		private static void UpdateDeformConfig_Injected(ref HGTerrainDeformConfigV2 config); // 0x0000000183C820A0-0x0000000183C820E0
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGTreeRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetTreeRender()", StaticAccessorType.Dot)]
	public static class HGTreeRender // TypeDefIndex: 61017
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool noAlphaTest = false /* Metadata: 0x0234F00E */); // 0x000000018B3FBF14-0x000000018B3FBF44
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr, bool noAlphaTest); // 0x000000018B3FBF44-0x000000018B3FBFA4
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, bool noAlphaTest); // 0x000000018B3FBE50-0x000000018B3FBEB0
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, out uint normalList, out uint preZPart0List, out uint preZPart1List, bool noAlphaTest = false /* Metadata: 0x0234F00F */); // 0x000000018B3FBEB0-0x000000018B3FBF14
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList); // 0x000000018B3FBFA4-0x000000018B3FBFC0
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGUIRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetUIRender()", StaticAccessorType.Dot)]
	public static class HGUIRender // TypeDefIndex: 61018
	{
		// Methods
		public static uint CreateRendererList(uint cullingLayerMask, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, short sortingOrderMin, short sortingOrderMax, int cameraInstanceID, IntPtr context, bool isWorldUI, float wolrdUICullingDistance = 3.4028235E+38f /* Metadata: 0x0234F010 */); // 0x000000018B3FBFC0-0x000000018B3FBFF0
		private static uint CreateRendererList(uint cullingLayerMask, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, short sortingOrderMin, short sortingOrderMax, int cameraInstanceID, IntPtr context, bool isWorldUI, float wolrdUICullingDistance); // 0x000000018B3FBFF0-0x000000018B3FC074
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGVATBLASManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetVATBLASManager()", StaticAccessorType.Dot)]
	public static class HGVATBLASManager // TypeDefIndex: 61019
	{
		// Methods
		public static void Setup(ComputeShader vatSkinningCs); // 0x0000000183945590-0x00000001839455D0
		public static void SetVATMapPropertyName(int propertyNameId); // 0x0000000183945550-0x0000000183945590
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGWaterRender.h")]
	public static class HGWaterRender // TypeDefIndex: 61023
	{
		// Nested types
		public enum HGWaterHeightLayer // TypeDefIndex: 61020
		{
			HeightLayer0 = 0,
			HeightLayer1 = 1,
			HeightLayer2 = 2,
			HeightLayer3 = 3
		}
	
		public enum HGWaterRenderType // TypeDefIndex: 61021
		{
			Proxy = 1,
			LOD = 2
		}
	
		public enum HGWaterDecalRenderType // TypeDefIndex: 61022
		{
			None = 0,
			Regular = 1,
			Emissive = 2
		}
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void CullWaterProxy(uint viewHandle, Matrix4x4 viewProj, uint cullingMask, bool useOC, out uint visibleCount, out uint cullHandle, bool orderByDistance = false /* Metadata: 0x0234F014 */, Vector3 viewPosition = default); // 0x000000018539262C-0x0000000185392678
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void CullWaterDecals(uint viewHandle, Matrix4x4 viewProj, out uint visibleCount, out uint cullHandle, bool useAnchorSH = false /* Metadata: 0x0234F015 */); // 0x000000018539260C-0x000000018539262C
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool IsHeightLayerVisible(uint cullHandle, uint renderTypeMask, int lodLayer); // 0x000000018B3FC140-0x000000018B3FC190
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void DrawWaterProxy(IntPtr renderContext, CommandBuffer cmd, uint cullHandle, Material material, MaterialPropertyBlock properties, int shaderPass, int nameID, bool clear = true /* Metadata: 0x0234F016 */, uint renderTypeMask = 3 /* Metadata: 0x0234F017 */, int lodLayer = -1 /* Metadata: 0x0234F018 */, bool filterByWetnessMask = false /* Metadata: 0x0234F019 */); // 0x000000018B3FC0D8-0x000000018B3FC140
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void DrawWaterDecals(IntPtr renderContext, CommandBuffer cmd, uint cullHandle, MaterialPropertyBlock properties, int nameID, bool clear = true /* Metadata: 0x0234F01A */, int shaderPass = 0 /* Metadata: 0x0234F01B */, uint renderTypeMask = 1 /* Metadata: 0x0234F01C */, int heightLayer = -1 /* Metadata: 0x0234F01D */); // 0x000000018B3FC074-0x000000018B3FC0D8
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool IsHGWaterGloablConfigValidCPP(); // 0x0000000184035DA0-0x0000000184035DE0
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool CheckNewHGWaterGloablConfigCPP(string scenePath); // 0x000000018404F410-0x000000018404F450
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void UpdateHGWaterGloablConfigCPP(string scenePath, int sectorNum, int sectorSize, int sectorCoordsMin, int sectorCoordsMax, long[] sectorDataGUIDs, bool[] sectorDataExists); // 0x0000000184D2A9D0-0x0000000184D2AA40
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void AddSectorTexture(int id, int textureID); // 0x000000018447F770-0x000000018447F7C0
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void RemoveSectorTexture(int id); // 0x000000018B3FC190-0x000000018B3FC1C4
		private static void CullWaterProxy_Injected(uint viewHandle, ref Matrix4x4 viewProj, uint cullingMask, bool useOC, out uint visibleCount, out uint cullHandle, bool orderByDistance = false /* Metadata: 0x0234F01E */, ref Vector3 viewPosition = null); // 0x000000018344C270-0x000000018344C2F0
		private static void CullWaterDecals_Injected(uint viewHandle, ref Matrix4x4 viewProj, out uint visibleCount, out uint cullHandle, bool useAnchorSH = false /* Metadata: 0x0234F01F */); // 0x000000018344C2F0-0x000000018344C370
	}
}

namespace UnityEngine.HyperGryph.ECS
{
	public enum ECSExplicitEntityType : uint // TypeDefIndex: 61056
	{
		Unknown = 0,
		MeshRenderer = 1,
		ReflectionProbe = 2,
		WaterRenderer = 3,
		FactoryRenderer = 4,
		HGDecalProjector = 5
	}

	[UsedByNativeCode]
	public struct EntityInstanceData // TypeDefIndex: 61057
	{
		// Fields
		public uint entityType; // 0x00
		public int entityIdx; // 0x04
		public uint version; // 0x08
		public uint padding; // 0x0C
	}

	[UsedByNativeCode]
	public struct ComponentType // TypeDefIndex: 61058
	{
		// Fields
		public ulong value; // 0x00
		public short componentID; // 0x00
		public short componentSize; // 0x02
		public int offset; // 0x04
	}

	public struct ComponentMask // TypeDefIndex: 61060
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ ulong componentMaskWords[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _componentMaskWords_e__FixedBuffer // TypeDefIndex: 61059
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	
		// Constructors
		public unsafe ComponentMask(int id); // 0x0000000184DBCD50-0x0000000184DBCD70
	
		// Methods
		[IsReadOnly]
		public bool ContainsComponentId(int id); // 0x0000000182EF4120-0x0000000182EF4140
		[IsReadOnly]
		public bool ContainsComponentMask([IsReadOnly] in ComponentMask other); // 0x00000001830C7EB0-0x00000001830C7ED0
		[IsReadOnly]
		public bool ExcludesComponentMask([IsReadOnly] in ComponentMask other); // 0x00000001830C7ED0-0x00000001830C7EF0
		public override bool Equals(object obj); // 0x000000018B3F75A8-0x000000018B3F7624
		public override int GetHashCode(); // 0x0000000184DBCD00-0x0000000184DBCD30
		public void And(ref ComponentMask other); // 0x0000000184DBCCF0-0x0000000184DBCD00
		public void Or(int id); // 0x0000000184DBCD30-0x0000000184DBCD50
	}

	[UsedByNativeCode]
	public struct EntityTypeInstanceData // TypeDefIndex: 61062
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
		public struct _componentTypes_e__FixedBuffer // TypeDefIndex: 61061
		{
			// Fields
			public ulong FixedElementField; // 0x00
		}
	}

	[UsedByNativeCode]
	public struct Entity : IEquatable<Entity> // TypeDefIndex: 61063
	{
		// Fields
		public uint globalIndex; // 0x00
		public uint version; // 0x04
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly Entity _invaildEntity_k__BackingField; // 0x00
	
		// Properties
		public ulong id { get; set; } // 0x0000000184DBCE40-0x0000000184DBCE50 0x0000000184DB7280-0x0000000184DB7290
		public static Entity invaildEntity { [CompilerGenerated] get; } // 0x000000018B3F7C00-0x000000018B3F7C50 
	
		// Constructors
		static Entity(); // 0x0000000184D57130-0x0000000184D57180
	
		// Methods
		public bool Equals(Entity rhs); // 0x0000000182EF0510-0x0000000182EF0530
		public override int GetHashCode(); // 0x0000000184DBA750-0x0000000184DBA760
		public override string ToString(); // 0x000000018B3F7B78-0x000000018B3F7C00
		public bool Valid(); // 0x0000000183056420-0x0000000183056440
		public static bool operator ==(Entity left, Entity right); // 0x00000001839636F0-0x0000000183963980
		public static bool operator !=(Entity left, Entity right); // 0x00000001839636A0-0x00000001839636F0
		public override bool Equals(object obj); // 0x000000018B3F7AFC-0x000000018B3F7B78
	}

	[UsedByNativeCode]
	public struct EntityType // TypeDefIndex: 61064
	{
		// Fields
		public uint id; // 0x00
	}

	public interface IComponentECS // TypeDefIndex: 61065
	{
		// Properties
		int id { get; }
	}

	public struct BoundingCenterXComponent : IComponentECS // TypeDefIndex: 61066
	{
		// Fields
		public float x; // 0x00
	
		// Properties
		public int id { get; } // 0x00000001811EC580-0x00000001811EC590 
	}

	public struct BoundingCenterYComponent : IComponentECS // TypeDefIndex: 61067
	{
		// Fields
		public float y; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000184D85B80-0x0000000184D85B90 
	}

	public struct BoundingCenterZComponent : IComponentECS // TypeDefIndex: 61068
	{
		// Fields
		public float z; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000182BBE540-0x0000000182BBE550 
	}

	public struct BoundingExtentXComponent : IComponentECS // TypeDefIndex: 61069
	{
		// Fields
		public float x; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000184D8C9E0-0x0000000184D8C9F0 
	}

	public struct BoundingExtentYComponent : IComponentECS // TypeDefIndex: 61070
	{
		// Fields
		public float y; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000184D882B0-0x0000000184D882C0 
	}

	public struct BoundingExtentZComponent : IComponentECS // TypeDefIndex: 61071
	{
		// Fields
		public float z; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000184D9EC50-0x0000000184D9EC60 
	}

	public struct RenderObjectLODInfoComponent : IComponentECS // TypeDefIndex: 61072
	{
		// Fields
		public Vector3 lodCenter; // 0x00
		public float lodObjectHalfSizeSquared; // 0x0C
		public bool enableDither; // 0x10
		public byte lodCullingOptions; // 0x11
		public byte padding0; // 0x12
		public byte padding1; // 0x13
	
		// Properties
		public int id { get; } // 0x0000000184D9EC60-0x0000000184D9EC70 
	}

	public struct RenderObjectInfoComponent : IComponentECS // TypeDefIndex: 61073
	{
		// Fields
		public uint roLayerMask; // 0x00
		public uint objectFlags; // 0x04
		public ulong sceneMask; // 0x08
		public uint artTag; // 0x10
		public float sortingFudgeSqr; // 0x14
	
		// Properties
		public int id { get; } // 0x0000000184D9BE00-0x0000000184D9BE10 
	}

	public struct RendererInfo // TypeDefIndex: 61074
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

	public struct LODInfo // TypeDefIndex: 61075
	{
		// Fields
		public float lodScreenSizeMaxSquared; // 0x00
		public float lodScreenSizeMinSquared; // 0x04
	}

	public interface IRenderObjectKComponent : IComponentECS // TypeDefIndex: 61076
	{
		// Methods
		byte* GetRenderersPtr();
	}

	public struct RenderObjectK1Component : IRenderObjectKComponent // TypeDefIndex: 61079
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x1C
	
		// Properties
		public int id { get; } // 0x0000000184D8D060-0x0000000184D8D070 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 61077
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 61078
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000184DBCE00-0x0000000184DBCE10
	}

	public struct RenderObjectK2Component : IRenderObjectKComponent // TypeDefIndex: 61082
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x34
	
		// Properties
		public int id { get; } // 0x0000000184DA4FC0-0x0000000184DA4FD0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 61080
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 61081
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000184DBCE00-0x0000000184DBCE10
	}

	public struct RenderObjectK4Component : IRenderObjectKComponent // TypeDefIndex: 61085
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x64
	
		// Properties
		public int id { get; } // 0x0000000184DA5360-0x0000000184DA5370 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 61083
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 61084
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000184DBCE00-0x0000000184DBCE10
	}

	public struct RenderObjectK8Component : IRenderObjectKComponent // TypeDefIndex: 61088
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0xC4
	
		// Properties
		public int id { get; } // 0x0000000184DA4FE0-0x0000000184DA4FF0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 61086
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 61087
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000184DBCE00-0x0000000184DBCE10
	}

	public struct RenderObjectK16Component : IRenderObjectKComponent // TypeDefIndex: 61091
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x184
	
		// Properties
		public int id { get; } // 0x0000000184DA5380-0x0000000184DA5390 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _renderers_e__FixedBuffer // TypeDefIndex: 61089
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _lodInfos_e__FixedBuffer // TypeDefIndex: 61090
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public unsafe byte* GetRenderersPtr(); // 0x0000000184DBCE00-0x0000000184DBCE10
	}

	[UsedByNativeCode]
	public struct PerDrawBaseData // TypeDefIndex: 61092
	{
		// Fields
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 lodFade; // 0x40
		public Vector4 worldTransformParams; // 0x50
		public Matrix4x4 matrixPreviousM; // 0x60
		public Vector4 motionVectorsParams; // 0xA0
	}

	public struct CommonInstanceDataComponent : IComponentECS // TypeDefIndex: 61094
	{
		// Fields
		public PerDrawBaseData baseData; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float customData[0]; // 0xB0
	
		// Properties
		public int id { get; } // 0x0000000184DA3EE0-0x0000000184DA3EF0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _customData_e__FixedBuffer // TypeDefIndex: 61093
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct FactoryInstanceDataComponent : IComponentECS // TypeDefIndex: 61096
	{
		// Fields
		public PerDrawBaseData baseData; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float customData[0]; // 0xB0
	
		// Properties
		public int id { get; } // 0x0000000184DA3EE0-0x0000000184DA3EF0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _customData_e__FixedBuffer // TypeDefIndex: 61095
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	}

	public struct ECSFixedString64 // TypeDefIndex: 61098
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x00
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _data_e__FixedBuffer // TypeDefIndex: 61097
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Methods
		public string GetData(); // 0x000000018B3F7624-0x000000018B3F76C0
		public override string ToString(); // 0x000000018B3F76C0-0x000000018B3F76C8
	}

	public struct DebugContentsComponent : IComponentECS // TypeDefIndex: 61099
	{
		// Fields
		public ECSFixedString64 entityName; // 0x00
		public ECSExplicitEntityType entityType; // 0x40
		public ECSFixedString64 debugStr; // 0x44
	
		// Properties
		public int id { get; } // 0x0000000184DA43D0-0x0000000184DA43E0 
	}

	public struct HGFactoryRendererBinderComponent : IComponentECS // TypeDefIndex: 61100
	{
		// Fields
		public Entity rendererEntity; // 0x00
		public uint sharedDataIndex; // 0x08
		public byte rendererType; // 0x0C
		public byte padding0; // 0x0D
		public byte padding1; // 0x0E
		public byte padding2; // 0x0F
	
		// Properties
		public int id { get; } // 0x0000000184D89170-0x0000000184D89180 
	
		// Methods
		public void SetDirtyFlag(HGFactoryDirtyFlags flag); // 0x00000001834A3FA0-0x00000001834A4030
		public void SetAdditiveMaterialBit(int bitIndex, bool enable); // 0x000000018B3F9134-0x000000018B3F91E4
		public void SetPosition(Vector3 position); // 0x00000001834A3CE0-0x00000001834A3D60
		public void SetUniformScale(float uniformScale); // 0x000000018B3F922C-0x000000018B3F9288
		public void SetRotation(Quaternion rotation); // 0x0000000183E21230-0x0000000183E212C0
		public void SetTransform(HGFactoryEntityTransformData transform); // 0x000000018B3F91E4-0x000000018B3F922C
		public void SetCustomPerDrawData<T>(T data, int offset)
			where T : struct;
		public void SetEnabled(bool enabled); // 0x00000001834A3E60-0x00000001834A3F60
		public void SetAdditiveEntitiesVisibility(bool visible); // 0x00000001834A3C40-0x00000001834A3CE0
	}

	public struct HGWaterComponent : IComponentECS // TypeDefIndex: 61101
	{
		// Fields
		public uint renderTypeMask; // 0x00
		public int meshID; // 0x04
		public Matrix4x4 objectToWorld; // 0x08
		public Vector4 param0; // 0x48
		public Vector4 param1; // 0x58
	
		// Properties
		public int id { get; } // 0x0000000184DA77E0-0x0000000184DA77F0 
	}

	public struct HGWaterDecalComponent : IComponentECS // TypeDefIndex: 61102
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
		public int id { get; } // 0x0000000184DA7810-0x0000000184DA7820 
	}

	public struct GrassRendererInfo // TypeDefIndex: 61103
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
	public struct GrassPerInstanceData // TypeDefIndex: 61104
	{
		// Fields
		public const int SIZE = 96; // Metadata: 0x0234F1D9
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 param0; // 0x40
		public Vector4 param1; // 0x50
	}

	public struct GrassClusterK4Component : IComponentECS // TypeDefIndex: 61106
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get; } // 0x0000000184DA7820-0x0000000184DA7830 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 61105
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK8Component : IComponentECS // TypeDefIndex: 61108
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get; } // 0x0000000184DA9FD0-0x0000000184DA9FE0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 61107
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK16Component : IComponentECS // TypeDefIndex: 61110
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get; } // 0x0000000184DAAAE0-0x0000000184DAAAF0 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 61109
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct GrassClusterK32Component : IComponentECS // TypeDefIndex: 61112
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get; } // 0x0000000184DAAB10-0x0000000184DAAB20 
	
		// Nested types
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _perInstanceData_e__FixedBuffer // TypeDefIndex: 61111
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	}

	public struct ECSColliderComponent : IComponentECS // TypeDefIndex: 61113
	{
		// Fields
		public IntPtr actor; // 0x00
		public int ecsId; // 0x08
		public uint ecsVersion; // 0x0C
	
		// Properties
		public int id { get; } // 0x0000000184DAAB60-0x0000000184DAAB70 
	}

	public struct HGSludgeComponent : IComponentECS // TypeDefIndex: 61114
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
		public int id { get; } // 0x0000000184DA9F60-0x0000000184DA9F70 
	}

	public struct ECSClothDataComponent : IComponentECS // TypeDefIndex: 61115
	{
		// Fields
		public uint clothHash; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000184DBCD70-0x0000000184DBCD80 
	}

	public struct HGStreamingVolumeComponent : IComponentECS // TypeDefIndex: 61116
	{
		// Fields
		public bool isEnable; // 0x00
		public Vector3 center; // 0x04
		public Vector3 size; // 0x10
		public Quaternion rotation; // 0x1C
	
		// Properties
		public int id { get; } // 0x0000000184DA9FF0-0x0000000184DAA000 
	}

	public struct HGCullingParameterComponent : IComponentECS // TypeDefIndex: 61117
	{
		// Fields
		public bool enableShadowCulling; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000184DBCEB0-0x0000000184DBCEC0 
	}

	[Serializable]
	[UsedByNativeCode]
	public struct TreePerInstanceData // TypeDefIndex: 61118
	{
		// Fields
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 param0; // 0x40
		public Vector4 param1; // 0x50
	}

	[UsedByNativeCode]
	public struct HGTreeComponent : IComponentECS // TypeDefIndex: 61119
	{
		// Fields
		public TreePerInstanceData perInstanceData; // 0x00
	
		// Properties
		public int id { get; } // 0x0000000184DBCEC0-0x0000000184DBCED0 
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGEntityManager.bindings.h")]
	public struct EntityManager // TypeDefIndex: 61120
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public readonly IntPtr m_entitiesPPtr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public readonly IntPtr m_entityTypesPPtr; // 0x08
	
		// Methods
		public static int GetNFromKNComponentMask(ulong componentMask); // 0x0000000184DBCE30-0x0000000184DBCE40
		public static unsafe int GetCountFromKNComponent(byte* component); // 0x0000000184DBA750-0x0000000184DBA760
		public static unsafe void SetCountForKNComponent(byte* component, int count); // 0x0000000184D86140-0x0000000184D86150
		public static unsafe GrassRendererInfo* GetGrassRendererInfosFromKNComponent(byte* component); // 0x0000000184DBCE00-0x0000000184DBCE10
		public static unsafe LODInfo* GetLODInfosFromKNComponent(byte* component, int n); // 0x0000000184DBCE10-0x0000000184DBCE30
		public static unsafe int GetCountFromKNGrassCluster(byte* component); // 0x0000000184DBA750-0x0000000184DBA760
		public static unsafe void SetCountForKNGrassCluster(byte* component, int count); // 0x0000000184D86140-0x0000000184D86150
		public static unsafe GrassPerInstanceData* GetPerInstanceDataFromKNGrassCluster(byte* component); // 0x0000000184DBCE00-0x0000000184DBCE10
		public static EntityManager GetEntityManager(); // 0x0000000183476310-0x00000001834763B0
		public static EntityManager GetGameplayEntityManager(); // 0x0000000183053AB0-0x0000000183053B00
		public static EntityManager GetRendererEntityManager(); // 0x00000001830C8F20-0x00000001830C8F70
		public bool HasEntity(Entity entity); // 0x0000000183056390-0x0000000183056420
		public Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityType entityType); // 0x00000001837AD2D0-0x00000001837AD330
		public void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, IntPtr entities, int count); // 0x0000000185394880-0x00000001853948A0
		public void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, NativeArray<Entity> entities); // 0x0000000183A259E0-0x0000000183A25FD0
		public void DestroyEntity(Entity entity); // 0x0000000185397290-0x00000001853972AC
		public void DestroyEntities(NativeArray<Entity> entities); // 0x00000001834CC3F0-0x00000001834CC450
		public void DestroyEntities(IntPtr entities, int entityCount); // 0x0000000185392CD8-0x0000000185392CE0
		public static ComponentType GetComponentType<T>()
			where T : struct, IComponentECS;
		public void AddComponent<T>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS;
		public void RemoveComponent<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS;
		public void RemoveComponentsWithMask([IsReadOnly] in Entity entity, ref ComponentMask needRemoveComponentMask); // 0x00000001837AB8C0-0x00000001837ABA30
		public UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityType(NativeArray<ComponentType> componentTypes); // 0x00000001837AD390-0x00000001837AD400
		public UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityTypeImpl(int componentTypeCount, IntPtr componentTypes); // 0x00000001837AD400-0x00000001837AD470
		public void AddMoveEntityAndEntityTypeDataImpl([IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType); // 0x00000001853938CC-0x00000001853938D4
		public void RemoveMoveEntityAndEntityTypeDataImpl([IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType); // 0x00000001853938C4-0x00000001853938CC
		public static ulong NumberOfSetBits(ulong i); // 0x0000000184DADF40-0x0000000184DADFA0
		public static ulong NumberOfSetBits(ref ComponentMask mask); // 0x0000000182EF0C30-0x0000000182EF0C70
		public ComponentMask ComposeComponentMaskAll(int id0, int id1); // 0x00000001830C5280-0x00000001830C52E0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2); // 0x00000001830C5060-0x00000001830C50E0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3); // 0x0000000183D09AD0-0x0000000183D09B70
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3, int id4); // 0x00000001830C51C0-0x00000001830C5280
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3, int id4, int id5); // 0x00000001830C50E0-0x00000001830C51C0
		public bool HasComponent<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS;
		public void SetComponents<T0, T1>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS;
		public static ComponentMask GetCountingMask(int id); // 0x0000000182EF0C70-0x0000000182EF0CC0
		public static void SetComponentImplWithRef<T>(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS;
		public void SetComponent<T>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS;
		private static unsafe byte* GetComponentPtrImpl(int entityIdx, ref EntityTypeInstanceData entityTypeData, int componentId, int componentSize); // 0x000000018B3F77B8-0x000000018B3F784C
		public bool TryGetWorldAABBFromRendererEntity([IsReadOnly] in Entity entity, out Bounds aabb); // 0x000000018B3F7934-0x000000018B3F7AFC
		public ulong GetComponentMaskLow([IsReadOnly] in Entity entity); // 0x0000000184DBCDD0-0x0000000184DBCE00
		public ComponentMask GetComponentMaskAll([IsReadOnly] in Entity entity); // 0x0000000184DBCDA0-0x0000000184DBCDD0
		public unsafe byte* GetComponentPtrLowBits([IsReadOnly] in Entity entity, ulong componentMask); // 0x000000018B3F784C-0x000000018B3F7934
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
		public EntityManagerRange Iterate(ref ComponentMask includeComponentMask, ref ComponentMask excludeComponentMask); // 0x00000001830C6090-0x00000001830C61A0
		public EntityManagerRange Iterate(ref ComponentMask componentMask); // 0x00000001830C7D80-0x00000001830C7E40
		public EntityManagerRange Iterate<T>()
			where T : struct, IComponentECS;
		public EntityManagerRange Iterate<T0, T1>()
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS;
		[NativeMethod(IsThreadSafe = true)]
		public int GetEntityTypeCount(); // 0x0000000185391060-0x0000000185391068
		[NativeMethod(IsThreadSafe = true)]
		public uint GetEntityContainerSize(); // 0x0000000185390ED4-0x0000000185390EDC
		public void GarbageCollect(); // 0x0000000185396DF0-0x0000000185396DF8
		private static void GetEntityManager_Injected(out EntityManager ret); // 0x00000001834762D0-0x0000000183476310
		private static void GetGameplayEntityManager_Injected(out EntityManager ret); // 0x0000000183053B00-0x0000000183053C00
		private static void GetRendererEntityManager_Injected(out EntityManager ret); // 0x00000001830C8F70-0x00000001830C8FB0
		private static void CreateEntity_Injected(ref EntityManager _unity_self, ref UnityEngine.HyperGryph.ECS.EntityType entityType, out Entity ret); // 0x00000001837AD330-0x00000001837AD390
		private static void CreateEntities_Injected(ref EntityManager _unity_self, ref UnityEngine.HyperGryph.ECS.EntityType entityType, IntPtr entities, int count); // 0x0000000184592630-0x00000001845926A0
		private static void DestroyEntity_Injected(ref EntityManager _unity_self, ref Entity entity); // 0x00000001841D47E0-0x00000001841D4830
		private static void DestroyEntities_Injected(ref EntityManager _unity_self, IntPtr entities, int entityCount); // 0x0000000183FFA970-0x0000000183FFA9D0
		private static void GetOrRegisterEntityTypeImpl_Injected(ref EntityManager _unity_self, int componentTypeCount, IntPtr componentTypes, out UnityEngine.HyperGryph.ECS.EntityType ret); // 0x00000001837AD470-0x00000001837AD4E0
		private static void AddMoveEntityAndEntityTypeDataImpl_Injected(ref EntityManager _unity_self, [IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType); // 0x0000000183F61850-0x0000000183F618B0
		private static void RemoveMoveEntityAndEntityTypeDataImpl_Injected(ref EntityManager _unity_self, [IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType); // 0x00000001842E5260-0x00000001842E52C0
		private static int GetEntityTypeCount_Injected(ref EntityManager _unity_self); // 0x0000000183B736A0-0x0000000183B736E0
		private static uint GetEntityContainerSize_Injected(ref EntityManager _unity_self); // 0x00000001839742C0-0x0000000183974300
		private static void GarbageCollect_Injected(ref EntityManager _unity_self); // 0x000000018404DA80-0x000000018404DAC0
	}

	[IsReadOnly]
	public struct GroupType // TypeDefIndex: 61121
	{
		// Fields
		private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
	
		// Constructors
		internal unsafe GroupType(EntityTypeInstanceData* types); // 0x0000000184D88B60-0x0000000184D88B70
	
		// Methods
		public int Size(); // 0x0000000185393E14-0x0000000185393E30
		public bool HasComponent<T>()
			where T : struct, IComponentECS;
		public unsafe T* GetComponent<T>()
			where T : struct, IComponentECS;
		public unsafe byte* GetComponentPtr(int componentId); // 0x000000018B3F8534-0x000000018B3F8688
		public NativeArray<T> GetComponentAsArray<T>()
			where T : struct, IComponentECS;
		public unsafe Entity* GetEntities(); // 0x0000000185391044-0x0000000185391060
		public ComponentMask GetComponentMaskAll(); // 0x000000018B3F850C-0x000000018B3F8534
		public NativeArray<Entity> GetEntitiesAsArray(); // 0x0000000183EFFF80-0x0000000183EFFFD0
	}

	[IsReadOnly]
	public struct EntityManagerRange : IEnumerable<GroupType> // TypeDefIndex: 61123
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
		private readonly ComponentMask m_componentMask; // 0x08
		private readonly ComponentMask m_excludeComponentMask; // 0x18
		private readonly int m_count; // 0x28
	
		// Nested types
		[ExcludeFromDocs]
		public struct Enumerator : IEnumerator<GroupType> // TypeDefIndex: 61122
		{
			// Fields
			private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
			private readonly int m_count; // 0x08
			private ComponentMask m_includeComponentMask; // 0x10
			private ComponentMask m_excludedComponentMask; // 0x20
			private int m_index; // 0x30
	
			// Properties
			public GroupType Current { get; } // 0x0000000184DBCE80-0x0000000184DBCE90 
			object IEnumerator.Current { get; } // 0x000000018B3F7C50-0x000000018B3F7CA0 
	
			// Constructors
			internal unsafe Enumerator(EntityTypeInstanceData* entityTypes, int count, [IsReadOnly] in ComponentMask includeComponentMask, [IsReadOnly] in ComponentMask excludeComponentMask); // 0x0000000184DBCE50-0x0000000184DBCE80
	
			// Methods
			public void Dispose(); // 0x00000001841E1670-0x00000001841E1680
			public bool MoveNext(); // 0x00000001830C7E40-0x00000001830C7EB0
			public void Reset(); // 0x0000000182B2C650-0x0000000182B2C660
		}
	
		// Constructors
		internal unsafe EntityManagerRange(EntityTypeInstanceData* entityTypes, int count, ref ComponentMask componentMask); // 0x0000000184DBCD80-0x0000000184DBCDA0
		internal unsafe EntityManagerRange(EntityTypeInstanceData* entityTypes, int count, ref ComponentMask includeComponentMask, ref ComponentMask excludeComponentMask); // 0x00000001830C7EF0-0x00000001830C7F60
	
		// Methods
		public Enumerator GetEnumerator(); // 0x00000001830C8ED0-0x00000001830C8F20
		IEnumerator<GroupType> IEnumerable<GroupType>.GetEnumerator(); // 0x000000018B3F76C8-0x000000018B3F7740
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B3F7740-0x000000018B3F77B8
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGEntityDelayedOperationSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetEntityDelayedOperationSystem()", StaticAccessorType.Dot)]
	public static class HGEntityDelayedOperationSystem // TypeDefIndex: 61124
	{
		// Methods
		public static void RemoveEntity(Entity entity); // 0x000000018B3F8F80-0x000000018B3F8F9C
		private static void RemoveEntity_Injected(ref Entity entity); // 0x000000018B3F8F4C-0x000000018B3F8F80
	}
}

namespace UnityEngine.HyperGryph.Streaming
{
	public struct StreamingAssetData // TypeDefIndex: 61024
	{
		// Fields
		public long assetHashV2; // 0x00
		public AssetType assetType; // 0x08
	
		// Methods
		public bool Equals(StreamingAssetData other); // 0x0000000188CD4F00-0x0000000188CD4F18
		public override bool Equals(object obj); // 0x000000018B3FC2E0-0x000000018B3FC358
		public override int GetHashCode(); // 0x0000000184DBA750-0x0000000184DBA760
	}

	public struct PropertySerializeId // TypeDefIndex: 61025
	{
		// Fields
		public uint componentIndex; // 0x00
		public uint propertyId; // 0x04
		public uint subPropertyIndex; // 0x08
	
		// Constructors
		public PropertySerializeId(StreamingComponentType componentType, uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x0234F029 */); // 0x00000001842E1F50-0x00000001842E1F90
		public PropertySerializeId(uint componentIndex, uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x0234F02A */); // 0x0000000184D85D60-0x0000000184D85D70
		public PropertySerializeId(uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x0234F02B */); // 0x0000000184DBCED0-0x0000000184DBCEE0
	
		// Methods
		public static implicit operator PropertySerializeId(uint propertyId); // 0x0000000184DBCF10-0x0000000184DBCF40
		public static uint GetComponentIndexFromType(StreamingComponentType componentType); // 0x00000001842E1F90-0x00000001842E1FD0
		public override int GetHashCode(); // 0x000000018B3FC290-0x000000018B3FC298
		public uint EncodeSerializeIdentifier(); // 0x000000018B3FC22C-0x000000018B3FC290
		public static PropertySerializeId operator +(PropertySerializeId a, uint subIndex); // 0x0000000184DBCEE0-0x0000000184DBCF10
		public static PropertySerializeId operator +(PropertySerializeId a, int subIndex); // 0x000000018B3FC298-0x000000018B3FC2E0
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/FlatBufferConvertContext.bindings.h")]
	public struct FlatBufferConvertContextV2 // TypeDefIndex: 61026
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Properties
		public uint sceneScopeId { get; } // 0x000000018539535C-0x0000000185395364 
		public uint sceneScopeRegionHandle { get; } // 0x000000018B3F7D60-0x000000018B3F7D68 
	
		// Methods
		public bool TryEnqueueAssetForAsyncLoad(PropertySerializeId propertySerializeId); // 0x0000000185395B64-0x0000000185395B78
		public void AddExternalAssetForAsyncLoad(long assetHash, AssetType assetType, AssetHandleIndex assetHandleIndex); // 0x000000018539614C-0x0000000185396170
		private UnityEngine.Object ConvertAssetFromImpl(PropertySerializeId propertySerializeId); // 0x00000001853965CC-0x00000001853965E0
		private IntPtr ConvertPropertyPtrFromImpl(PropertySerializeId propertySerializeId); // 0x0000000185396138-0x000000018539614C
		private void ConvertPropertyDataFromBytesImpl(PropertySerializeId propertySerializeId, out IntPtr data, out int size); // 0x0000000185395344-0x000000018539535C
		public string ConvertStringFrom(PropertySerializeId propertySerializeId); // 0x0000000185397CCC-0x0000000185397CE0
		public bool TryConvertAssetFrom<T>(PropertySerializeId propertySerializeId, out ref T asset)
			where T : UnityEngine.Object;
		public T ConvertPropertyFrom<T>(PropertySerializeId propertySerializeId)
			where T : struct;
		public T ConvertPropertyFromBytes<T>(PropertySerializeId propertySerializeId)
			where T : struct;
		public NativeArray<byte> ConvertPropertyFromBytes(PropertySerializeId propertySerializeId); // 0x000000018B3F7CA0-0x000000018B3F7D60
		private static uint get_sceneScopeId_Injected(ref FlatBufferConvertContextV2 _unity_self); // 0x0000000184407510-0x0000000184407550
		private static uint get_sceneScopeRegionHandle_Injected(ref FlatBufferConvertContextV2 _unity_self); // 0x0000000184D73580-0x0000000184D735C0
		private static bool TryEnqueueAssetForAsyncLoad_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId); // 0x00000001841D1C50-0x00000001841D1CA0
		private static void AddExternalAssetForAsyncLoad_Injected(ref FlatBufferConvertContextV2 _unity_self, long assetHash, AssetType assetType, ref AssetHandleIndex assetHandleIndex); // 0x0000000184D4FAC0-0x0000000184D4FB30
		private static UnityEngine.Object ConvertAssetFromImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId); // 0x0000000183F00A10-0x0000000183F00A60
		private static IntPtr ConvertPropertyPtrFromImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId); // 0x0000000183E4B6A0-0x0000000183E4B6F0
		private static void ConvertPropertyDataFromBytesImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId, out IntPtr data, out int size); // 0x000000018436DF00-0x000000018436DF70
		private static string ConvertStringFrom_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId); // 0x0000000184D330A0-0x0000000184D330F0
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingGameplayManager.binding.h")]
	public struct StreamingGameplayManager // TypeDefIndex: 61027
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Methods
		public void Create(StreamingSceneParameter parameter); // 0x0000000185392E48-0x0000000185392E5C
		public void Destroy(); // 0x000000018B3FC420-0x000000018B3FC428
		public uint AllocateRuntimeChunk(string initBasePath, string streamingBasePath); // 0x00000001853960F8-0x0000000185396100
		public uint CreateEntityGroupAndLoad(uint chunkId, int blobIndex); // 0x00000001853960F0-0x00000001853960F8
		public void LoadGroup(uint groupHandle); // 0x000000018B3FC4EC-0x000000018B3FC4F4
		public bool IsGroupReady(uint groupId); // 0x000000018B3FC4A4-0x000000018B3FC4AC
		public uint CreateGroupAndLoadWaitBeforeShow(uint chunkId, int blobIndex); // 0x000000018B3FC3E4-0x000000018B3FC3EC
		public void StopGroupWait(uint groupId); // 0x000000018B3FC534-0x000000018B3FC53C
		public void UnloadGroup(uint groupId, bool imm); // 0x0000000185392D0C-0x0000000185392D14
		public void DestroyGroup(uint groupId); // 0x0000000185396D74-0x0000000185396D7C
		public bool IsGroupLoaded(uint groupId); // 0x0000000185392D14-0x0000000185392D1C
		public bool IsGroupUnloaded(uint groupId); // 0x0000000185396D6C-0x0000000185396D74
		public void Tick(int budget); // 0x0000000185392C50-0x0000000185392C58
		public void TickResource(); // 0x0000000185391010-0x0000000185391018
		public void Clear(); // 0x000000018B3FC38C-0x000000018B3FC394
		public bool IsIdle(); // 0x0000000185392C58-0x0000000185392C60
		public bool IsValid(); // 0x00000001853930B4-0x00000001853930C0
		public void SetNeedLodTransition(bool needTransition); // 0x00000001853958C8-0x00000001853958D0
		public bool GetNeedLodTransition(); // 0x000000018B3FC45C-0x000000018B3FC464
		private static void Create_Injected(ref StreamingGameplayManager _unity_self, ref StreamingSceneParameter parameter); // 0x0000000183582540-0x0000000183582590
		private static void Destroy_Injected(ref StreamingGameplayManager _unity_self); // 0x000000018B3FC3EC-0x000000018B3FC420
		private static uint AllocateRuntimeChunk_Injected(ref StreamingGameplayManager _unity_self, string initBasePath, string streamingBasePath); // 0x00000001845B0B90-0x00000001845B0C50
		private static uint CreateEntityGroupAndLoad_Injected(ref StreamingGameplayManager _unity_self, uint chunkId, int blobIndex); // 0x0000000183E23110-0x0000000183E23170
		private static void LoadGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupHandle); // 0x000000018B3FC4AC-0x000000018B3FC4EC
		private static bool IsGroupReady_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x000000018B3FC464-0x000000018B3FC4A4
		private static uint CreateGroupAndLoadWaitBeforeShow_Injected(ref StreamingGameplayManager _unity_self, uint chunkId, int blobIndex); // 0x000000018B3FC394-0x000000018B3FC3E4
		private static void StopGroupWait_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x000000018B3FC4F4-0x000000018B3FC534
		private static void UnloadGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupId, bool imm); // 0x0000000183505CC0-0x0000000183505D20
		private static void DestroyGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x000000018400C6B0-0x000000018400C700
		private static bool IsGroupLoaded_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x0000000183BF1C40-0x0000000183BF1C90
		private static bool IsGroupUnloaded_Injected(ref StreamingGameplayManager _unity_self, uint groupId); // 0x000000018400C700-0x000000018400C750
		private static void Tick_Injected(ref StreamingGameplayManager _unity_self, int budget); // 0x0000000183FD8C40-0x0000000183FD8C90
		private static void TickResource_Injected(ref StreamingGameplayManager _unity_self); // 0x0000000183F1E450-0x0000000183F1E490
		private static void Clear_Injected(ref StreamingGameplayManager _unity_self); // 0x000000018B3FC358-0x000000018B3FC38C
		private static bool IsIdle_Injected(ref StreamingGameplayManager _unity_self); // 0x0000000184387EF0-0x0000000184387F30
		private static void SetNeedLodTransition_Injected(ref StreamingGameplayManager _unity_self, bool needTransition); // 0x0000000183CC75C0-0x0000000183CC7610
		private static bool GetNeedLodTransition_Injected(ref StreamingGameplayManager _unity_self); // 0x000000018B3FC428-0x000000018B3FC45C
	}

	[Flags]
	public enum StreamingComponentType : ulong // TypeDefIndex: 61028
	{
		None = 0,
		Transform = 1,
		MeshFilter = 2,
		MeshRenderer = 4,
		LODGroup = 8,
		BoxCollider = 16,
		MeshCollider = 32,
		Count = 43,
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
		HGGPUParticleSystem = 4398046511104
	}

	public enum StreamingLayer : byte // TypeDefIndex: 61029
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

	public enum EntityTransition : byte // TypeDefIndex: 61030
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

	public enum StreamingMode : byte // TypeDefIndex: 61031
	{
		Stream = 0,
		Pause = 1,
		Load = 2,
		Unload = 3
	}

	[Flags]
	public enum StreamingStatus : byte // TypeDefIndex: 61032
	{
		Idle = 0,
		Loading = 1,
		Unloading = 2,
		Empty = 4
	}

	public struct StreamingSceneParameter // TypeDefIndex: 61033
	{
		// Fields
		public string mapName; // 0x00
		public uint regionHandle; // 0x08
		public GameObject streamingRootObject; // 0x10
		public string streamingDataPathRoot; // 0x18
		public bool isDev; // 0x20
	}

	public enum GridStatus : byte // TypeDefIndex: 61034
	{
		Loading = 0,
		Loaded = 1,
		Unloading = 2,
		Unloaded = 3,
		NotExist = 4
	}

	public struct GridIdentifier // TypeDefIndex: 61035
	{
		// Fields
		public Vector2Int pos; // 0x00
		public int sceneStateId; // 0x08
		public int areaId; // 0x0C
		public StreamingLayer layer; // 0x10
	
		// Constructors
		public GridIdentifier(StreamingLayer layer, int sceneStateId, int areaId, Vector2Int pos); // 0x0000000184DBCE90-0x0000000184DBCEB0
	
		// Methods
		public override int GetHashCode(); // 0x00000001832D6160-0x00000001832D6180
	}

	public struct StreamingSourceData // TypeDefIndex: 61038
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
		public struct _layerLoadRadius_e__FixedBuffer // TypeDefIndex: 61036
		{
			// Fields
			public float FixedElementField; // 0x00
		}
	
		[CompilerGenerated]
		[UnsafeValueType]
		public struct _layerEnabledInDefaultArea_e__FixedBuffer // TypeDefIndex: 61037
		{
			// Fields
			public byte FixedElementField; // 0x00
		}
	
		// Constructors
		static StreamingSourceData(); // 0x0000000184D2C6A0-0x0000000184D2C730
	
		// Methods
		public float GetGridLoadRadius(int layerIndex); // 0x0000000184DBCF40-0x0000000184DBCF50
	}

	public enum ECSEntityType : byte // TypeDefIndex: 61039
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
		TypeCount = 14
	}

	public enum ProxyEntityType : byte // TypeDefIndex: 61040
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
		TypeCount = 11
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingScene.bindings.h")]
	public struct StreamingSceneV2 // TypeDefIndex: 61041
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Properties
		public StreamingMode streamingMode { get; set; } // 0x000000018B3FC694-0x000000018B3FC69C 0x000000018B3FC6A4-0x000000018B3FC6AC
		public StreamingSourceData primaryStreamingSourceData { get; set; } // 0x00000001838B3FB0-0x00000001838B4020 0x0000000185391828-0x000000018539183C
		public StreamingSourceData secondaryStreamingSourceData { set; } // 0x0000000185397D84-0x0000000185397D98
		public float streamingProgress { get; } // 0x000000018B3FC69C-0x000000018B3FC6A4 
	
		// Methods
		public void Create(StreamingSceneParameter parameter); // 0x00000001853965E0-0x00000001853965F4
		public void Destroy(); // 0x000000018B3FC570-0x000000018B3FC578
		public void UnloadImmediately(); // 0x000000018B3FC658-0x000000018B3FC660
		public StreamingStatus QueryStreamingStatus(); // 0x000000018B3FC61C-0x000000018B3FC624
		public void SetArea(int areaId, bool enabled); // 0x000000018539739C-0x00000001853973A4
		public void SetSceneState(int sceneStateId, bool enabled); // 0x00000001853965F4-0x00000001853965FC
		public void UpdateNeedProcessChunkGridSet(); // 0x0000000185397394-0x000000018539739C
		private GridStatus QueryGridLoadStatusImpl(StreamingLayer layer, int sceneStateId, int areaId, Vector2 queryPos); // 0x00000001853925C8-0x00000001853925EC
		private GridStatus QueryGridLoadStatusByGridIdentifierImpl(GridIdentifier gridIdentifier); // 0x000000018B3FC5BC-0x000000018B3FC5D0
		public bool IsValid(); // 0x00000001853925C0-0x00000001853925C8
		public GridStatus QueryGridLoadStatus(StreamingLayer layer, Vector2 queryPos); // 0x000000018B3FC5F8-0x000000018B3FC61C
		public GridStatus QueryGridLoadStatus(GridIdentifier gridIdentifier); // 0x000000018B3FC5D0-0x000000018B3FC5F8
		private static void Create_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSceneParameter parameter); // 0x0000000183F01530-0x0000000183F01580
		private static void Destroy_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018B3FC53C-0x000000018B3FC570
		private static void UnloadImmediately_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018B3FC624-0x000000018B3FC658
		private static StreamingStatus QueryStreamingStatus_Injected(ref StreamingSceneV2 _unity_self); // 0x0000000184191D50-0x0000000184191D90
		private static void SetArea_Injected(ref StreamingSceneV2 _unity_self, int areaId, bool enabled); // 0x000000018466C050-0x000000018466C110
		private static void SetSceneState_Injected(ref StreamingSceneV2 _unity_self, int sceneStateId, bool enabled); // 0x00000001849D6C70-0x00000001849D6CD0
		private static void UpdateNeedProcessChunkGridSet_Injected(ref StreamingSceneV2 _unity_self); // 0x0000000184D50FF0-0x0000000184D51030
		private static GridStatus QueryGridLoadStatusImpl_Injected(ref StreamingSceneV2 _unity_self, StreamingLayer layer, int sceneStateId, int areaId, ref Vector2 queryPos); // 0x0000000183CB4320-0x0000000183CB4390
		private static GridStatus QueryGridLoadStatusByGridIdentifierImpl_Injected(ref StreamingSceneV2 _unity_self, ref GridIdentifier gridIdentifier); // 0x000000018B3FC578-0x000000018B3FC5BC
		private static StreamingMode get_streamingMode_Injected(ref StreamingSceneV2 _unity_self); // 0x000000018B3FC660-0x000000018B3FC694
		private static void set_streamingMode_Injected(ref StreamingSceneV2 _unity_self, StreamingMode value); // 0x0000000184B0E820-0x0000000184B0E870
		private static void get_primaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, out StreamingSourceData ret); // 0x00000001838B4020-0x00000001838B4070
		private static void set_primaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSourceData value); // 0x0000000183FA1FD0-0x0000000183FA2020
		private static void set_secondaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSourceData value); // 0x0000000184890CC0-0x0000000184890D10
		private static float get_streamingProgress_Injected(ref StreamingSceneV2 _unity_self); // 0x0000000184192820-0x00000001841928B0
		private static bool IsValid_Injected(ref StreamingSceneV2 _unity_self); // 0x00000001838B20D0-0x00000001838B2110
	}

	public delegate void ECSEntityHasRequiredComponentsDelegate(); // TypeDefIndex: 61042; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void ECSEntityConvertToDelegate(); // TypeDefIndex: 61043; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void ProxyEntityHasRequiredComponentsDelegate(); // TypeDefIndex: 61044; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void ProxyEntityConvertToDelegate(); // TypeDefIndex: 61045; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void MonoIsConvertorOfComponentDelegate(); // TypeDefIndex: 61046; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate void MonoComponentConvertToDelegate(); // TypeDefIndex: 61047; 0x00000001853DEDB8-0x00000001853DEDC8

	public delegate bool ECSEntityConvertFromDelegate(Entity entity, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 61048; 0x000000018429ABB0-0x000000018429AC00

	public delegate bool ProxyEntityConvertFromDelegate(ref IntPtr proxyPtr, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 61049; 0x000000018435EE20-0x000000018435EE70

	public delegate bool MonoComponentConvertFromDelegate(Component component, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 61050; 0x00000001844A5650-0x00000001844A56A0

	public delegate Component MonoComponentAddComponentToDelegate(GameObject gameObject); // TypeDefIndex: 61051; 0x000000018458AB70-0x000000018458AC70

	public delegate Component MonoComponentGetComponentFromDelegate(GameObject gameObject, int multiComponentIndex); // TypeDefIndex: 61052; 0x00000001846DBD80-0x00000001846DBE80

	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingSceneManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetHGStreamingSceneManager()", StaticAccessorType.Dot)]
	public static class HGStreamingSceneManager // TypeDefIndex: 61053
	{
		// Properties
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static int streamingVersion { [NativeName("GetStreamingSerializeCodeVersion")] get; } // 0x0000000183585D40-0x0000000183585D80 
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static int streamingChunkSize { [NativeName("GetStreamingChunkSize")] get; } // 0x00000001847A5FA0-0x00000001847A5FE0 
		private static IntPtr streamingScenesManaged { get; } // 0x000000018B3FB42C-0x000000018B3FB458 
		private static int streamingSceneCount { get; } // 0x000000018B3FB400-0x000000018B3FB42C 
	
		// Methods
		public static void BindECSEntityConvertFuncFromScript(ECSEntityType entityType, ECSEntityHasRequiredComponentsDelegate hasRequiredComponentsDelegate, ECSEntityConvertToDelegate convertToDelegate, ECSEntityConvertFromDelegate convertFromFunc); // 0x0000000183949FD0-0x000000018394A040
		public static void ResetECSEntityConvertFuncFromScript(ECSEntityType entityType); // 0x000000018B3FB330-0x000000018B3FB364
		public static bool IsECSEntityConvertFuncValid(ECSEntityType entityType); // 0x0000000183949F90-0x0000000183949FD0
		public static void BindProxyEntityConvertFuncFromScript(ProxyEntityType entityType, ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, ProxyEntityConvertToDelegate convertToFunc, ProxyEntityConvertFromDelegate convertFromFunc); // 0x000000018394A120-0x000000018394A190
		public static void ResetProxyEntityConvertFuncFromScript(ProxyEntityType entityType); // 0x000000018B3FB398-0x000000018B3FB3CC
		public static bool IsProxyEntityConvertFuncValid(ProxyEntityType entityType); // 0x000000018394A0E0-0x000000018394A120
		public static void BindMonoComponentConvertFuncFromScript(StreamingComponentType componentType, MonoIsConvertorOfComponentDelegate isConvertorOfFunc, MonoComponentConvertToDelegate convertToFunc, MonoComponentConvertFromDelegate convertFromFunc, MonoComponentAddComponentToDelegate addComponentToFunc, MonoComponentGetComponentFromDelegate getComponentFromFunc); // 0x000000018394A280-0x000000018394A2F0
		public static void ResetMonoComponentConvertFuncFromScript(StreamingComponentType componentType); // 0x000000018B3FB364-0x000000018B3FB398
		public static bool IsMonoComponentConvertFuncValid(StreamingComponentType componentType); // 0x000000018394A240-0x000000018394A280
		public static void BindProxyEntityConvertToFuncFromScript(ProxyEntityType entityType, ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, ProxyEntityConvertToDelegate convertToFunc); // 0x0000000183949E90-0x0000000183949EF0
		public static void ResetProxyEntityConvertToFuncFromScript(ProxyEntityType entityType); // 0x000000018B3FB3CC-0x000000018B3FB400
		public static NativeArray<StreamingSceneV2> GetStreamingScenesArray(); // 0x000000018B3FB2B4-0x000000018B3FB330
	}

	public struct StreamingLayerConfig // TypeDefIndex: 61054
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
	public static class HGStreamingSettings // TypeDefIndex: 61055
	{
		// Properties
		public static float loadDirtyDistance { set; } // 0x000000018350DAA0-0x000000018350DAF0
		public static float unloadDirtyDistance { set; } // 0x000000018350DA50-0x000000018350DAA0
		public static float loadElapsedMsPerFrame { set; } // 0x000000018350DA00-0x000000018350DA50
		public static float unloadElapsedMsPerFrame { set; } // 0x000000018350D9B0-0x000000018350DA00
		public static bool sequentialUnloadBeforeLoad { set; } // 0x000000018B3FB458-0x000000018B3FB48C
	
		// Methods
		public static void SetLayerConfig(StreamingLayer layer, StreamingLayerConfig config); // 0x00000001853945C8-0x00000001853945DC
		private static void SetLayerConfig_Injected(StreamingLayer layer, ref StreamingLayerConfig config); // 0x0000000184A27FC0-0x0000000184A28010
	}
}
