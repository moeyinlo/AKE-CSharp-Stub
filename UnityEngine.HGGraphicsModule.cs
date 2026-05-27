/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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

// Image 55: UnityEngine.HGGraphicsModule.dll - Assembly: UnityEngine.HGGraphicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57362-57600
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

namespace UnityEngine
{
	[NativeHeader("Modules/HGGraphics/Public/CapsuleShadow/HGCapsuleBindingComponent.h")]
	public class HGCapsuleBindingComponent : Component // TypeDefIndex: 57366
	{
		// Properties
		public bool enabled { set {} } // 0x0000000183228D00-0x0000000183228D50
		public float capsuleRadius { set {} } // 0x0000000183228D50-0x0000000183228DA0
		public float capsuleHeight { set {} } // 0x0000000183228DA0-0x0000000183228DF0
		public Vector3 localOffset { set {} } // 0x0000000184275E98-0x0000000184275EAC
		public Vector3 localRotation { set {} } // 0x0000000184275EAC-0x0000000184275EC0
		public float intensityScale { set {} } // 0x0000000183228DF0-0x0000000183228E40
		public bool forceRender { set {} } // 0x0000000183228E40-0x0000000183228E90
	
		// Constructors
		public HGCapsuleBindingComponent() {} // Dummy constructor
	
		// Methods
		private void set_localOffset_Injected(ref Vector3 value) {} // 0x0000000183228E90-0x0000000183228EE0
		private void set_localRotation_Injected(ref Vector3 value) {} // 0x0000000183228EE0-0x0000000183228F30
	}

	public enum HGDecalShapeType // TypeDefIndex: 57367
	{
		Box = 0,
		Cylinder = 1,
		Sector = 2,
		Sphere = 3,
		Mesh = 255
	}

	[NativeHeader("Modules/HGGraphics/Public/Decal/HGDecalProjector.h")]
	public sealed class HGDecalProjector : UnityEngine.Behaviour // TypeDefIndex: 57368
	{
		// Properties
		public HGDecalShapeType shapeType { get => default; } // 0x0000000189DF5A18-0x0000000189DF5A4C 
		public Material material { get => default; set {} } // 0x0000000189DF59E4-0x0000000189DF5A18 0x0000000189DF5B0C-0x0000000189DF5B50
		public UnityEngine.Color baseColor { get => default; set {} } // 0x0000000189DF59B8-0x0000000189DF59E4 0x0000000189DF5AF8-0x0000000189DF5B0C
		public Vector2 uvOffset { get => default; set {} } // 0x0000000189DF5A90-0x0000000189DF5AB4 0x0000000189DF5BD8-0x0000000189DF5BF4
		public float sectorAngle { set {} } // 0x0000000189DF5B50-0x0000000189DF5B94
	
		// Constructors
		public HGDecalProjector() {} // Dummy constructor
	
		// Methods
		private void get_baseColor_Injected(out UnityEngine.Color ret) {
			ret = default;
		} // 0x0000000189DF5974-0x0000000189DF59B8
		private void set_baseColor_Injected(ref UnityEngine.Color value) {} // 0x0000000189DF5AB4-0x0000000189DF5AF8
		private void get_uvOffset_Injected(out Vector2 ret) {
			ret = default;
		} // 0x0000000189DF5A4C-0x0000000189DF5A90
		private void set_uvOffset_Injected(ref Vector2 value) {} // 0x0000000189DF5B94-0x0000000189DF5BD8
	}

	[NativeHeader("Modules/HGGraphics/Public/OC/HGOccluder.h")]
	public sealed class HGOccluder : Component // TypeDefIndex: 57369
	{
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000189DF6FEC-0x0000000189DF7020 0x0000000189DF7054-0x0000000189DF7098
		public HGSoftwareOcclusionCullingData occluderData { get => default; set {} } // 0x0000000189DF7020-0x0000000189DF7054 0x0000000189DF7098-0x0000000189DF70DC
	
		// Constructors
		public HGOccluder() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[NativeHeader("Modules/HGGraphics/Public/OC/HGSoftwareOcclusionCullingData.h")]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGSoftwareOcclusionCulling.bindings.h")]
	[UsedByNativeCode]
	public sealed class HGSoftwareOcclusionCullingData : UnityEngine.Object // TypeDefIndex: 57370
	{
		// Properties
		public int quadCount { get => default; } // 0x0000000189DF7C04-0x0000000189DF7C38 
	
		// Constructors
		public HGSoftwareOcclusionCullingData() {} // 0x0000000189DF7BB8-0x0000000189DF7C04
	
		// Methods
		[FreeFunction("HGSoftwareOcclusionCulling_Bindings::CreateOcclusionCullingData")]
		private static void Internal_Create([Writable] HGSoftwareOcclusionCullingData cullingData) {} // 0x0000000189DF7B84-0x0000000189DF7BB8
		public void GetOccluderData(NativeArray<float> centerXs, NativeArray<float> centerYs, NativeArray<float> centerZs, NativeArray<float> extentXs, NativeArray<float> extentYs, NativeArray<float> extentZs, NativeArray<Vector3> vertexData, ref int quadCount) {} // 0x0000000189DF7A28-0x0000000189DF7B84
		public void GetOccluderData(IntPtr centerXs, IntPtr centerYs, IntPtr centerZs, IntPtr extentXs, IntPtr extentYs, IntPtr extentZs, IntPtr vertexData, ref int quadCount) {} // 0x0000000189DF79C4-0x0000000189DF7A28
	}

	public enum TransformAnimatedPhasePlayMode // TypeDefIndex: 57371
	{
		TransformAnimatedPhaseCurrent = 0,
		TransformAnimatedPhaseSequence = 1,
		TransformAnimatedPhaseSequenceLoop = 2
	}

	[Serializable]
	[UsedByNativeCode]
	public struct TransformAnimatedCurveData // TypeDefIndex: 57372
	{
		// Fields
		public byte[] data; // 0x00
		public float duration; // 0x08
	}

	[Serializable]
	[UsedByNativeCode]
	public struct TransformMotionPhase // TypeDefIndex: 57373
	{
		// Fields
		public Vector3 translationSpeed; // 0x00
		public Vector3 eulerAngleSpeed; // 0x0C
		public Vector3 rotAnchorPosition; // 0x18
		public float duration; // 0x24
	}

	public struct HGTransformAnimatedProfile // TypeDefIndex: 57374
	{
		// Fields
		public TransformMotionPhase[] motionPhaseProfiles; // 0x00
		public TransformAnimatedCurveData animCurveData; // 0x08
		public TransformAnimatedPhasePlayMode phasePlayMode; // 0x18
	}

	[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedBehaviour.h")]
	public sealed class HGTransformAnimatedBehaviour : UnityEngine.Behaviour // TypeDefIndex: 57375
	{
		// Fields
		public HGTransformAnimatedProfile profileData; // 0x18
		public bool useLogicDeltaTime; // 0x38
		public Renderer shadowProxyRenderer; // 0x40
	
		// Constructors
		public HGTransformAnimatedBehaviour() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void SetPause() {} // 0x0000000189DF8894-0x0000000189DF88C8
		public void Play() {} // 0x0000000189DF8820-0x0000000189DF8854
		public float GetTimeScale() => default; // 0x0000000189DF8770-0x0000000189DF87A4
		public void SetTimeScale(float scale) {} // 0x0000000189DF88C8-0x0000000189DF890C
		public void SetCurrentPhaseIndex(int phase) {} // 0x0000000189DF8854-0x0000000189DF8894
		public int GetCurrentPhaseIndex() => default; // 0x0000000189DF873C-0x0000000189DF8770
		public Matrix4x4 GetWorldMatrix() => default; // 0x0000000189DF87E8-0x0000000189DF8820
		public void SetUseLogicTime(bool useLogicTime) {} // 0x0000000189DF890C-0x0000000189DF8950
		public bool UseLogicTime() => default; // 0x0000000189DF8950-0x0000000189DF8984
		private void GetWorldMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		} // 0x0000000189DF87A4-0x0000000189DF87E8
	}

	public static class HGTransformAnimatedSystemCPP // TypeDefIndex: 57376
	{
		// Methods
		[FreeFunction("HGTransformAnimatedSystemCPP_Create")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static long HGTransformAnimatedSystemCPP_Create() => default; // 0x0000000182EC5780-0x0000000182EC57C0
		[FreeFunction("HGTransformAnimatedSystemCPP_UpdateAbsoluteTime")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static void HGTransformAnimatedSystemCPP_UpdateAbsoluteTime(long ptr, float absoluteTimeSec) {} // 0x0000000182EC5730-0x0000000182EC5780
		[FreeFunction("HGTransformAnimatedSystemCPP_Destroy")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGTransformAnimatedSystem.h")]
		public static void HGTransformAnimatedSystemCPP_Destroy(long ptr) {} // 0x0000000189DF8984-0x0000000189DF89B8
	}

	public class HGWindFoliageSyncSystemCPP // TypeDefIndex: 57377
	{
		// Constructors
		public HGWindFoliageSyncSystemCPP() {} // Dummy constructor
	
		// Methods
		[FreeFunction("HGWindFoliageSyncSystemCPP_Create")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static long HGWindFoliageSyncSystemCPP_Create() => default; // 0x0000000182E79AB0-0x0000000182E79AF0
		[FreeFunction("HGWindFoliageSyncSystemCPP_UpdateWindParam")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static unsafe void HGWindFoliageSyncSystemCPP_UpdateWindParam(long _ptr, Vector4 windGlobalParam, float* windMotorParam0, float* windMotorParam1, float* windMotorParam2, float* windMotorParam3, Vector4 count, float time, float lastTime) {} // 0x0000000184270C64-0x0000000184270CC0
		[FreeFunction("HGWindFoliageSyncSystemCPP_Destroy")]
		[NativeHeader("Modules/HGGraphics/Public/TransformAnimated/HGWindFoliageSyncTransformSystem.h")]
		public static void HGWindFoliageSyncSystemCPP_Destroy(long _ptr) {} // 0x0000000189DF8BB8-0x0000000189DF8BEC
		private static unsafe void HGWindFoliageSyncSystemCPP_UpdateWindParam_Injected(long _ptr, ref Vector4 windGlobalParam, float* windMotorParam0, float* windMotorParam1, float* windMotorParam2, float* windMotorParam3, ref Vector4 count, float time, float lastTime) {} // 0x0000000183059240-0x00000001830592B0
	}
}

namespace UnityEngine.HyperGryph
{
	[NativeHeader("Modules/StreamLine/StreamlineDLSSG.h")]
	[NativeHeader("Modules/StreamLine/StreamlineReflex.h")]
	[NativeHeader("Modules/StreamLine/StreamlineDLSS.h")]
	[NativeHeader("Modules/HGGraphics/Public/DLSS/HGDLSSUtil.h")]
	[UsedByNativeCode]
	public struct HGDLSSUtil // TypeDefIndex: 57378
	{
		// Methods
		[FreeFunction("IsStreamlineDLSSSupported")]
		[UsedByNativeCode]
		public static bool IsStreamlineDLSSSupported() => default; // 0x0000000183D470D0-0x0000000183D47110
		[FreeFunction("IsStreamlineDLSSGSupported")]
		[UsedByNativeCode]
		public static bool IsStreamlineDLSSGSupported() => default; // 0x0000000183B0DE90-0x0000000183B0DED0
		[FreeFunction("IsLowLatencyAvailable")]
		[UsedByNativeCode]
		public static bool IsLowLatencyAvailable() => default; // 0x0000000189DF5948-0x0000000189DF5974
	}

	[NativeType("Modules/HGGraphics/Public/GPUDriven/Version1/GPUDrivenRendererV1.h")]
	[StaticAccessor("GetGPUDrivenRendererV1()", StaticAccessorType.Dot)]
	public static class GPUDrivenRendererV1 // TypeDefIndex: 57379
	{
		// Methods
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, bool retainCustomDS, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, ref Matrix4x4 prevViewProjection) {} // 0x0000000189DF535C-0x0000000189DF53BC
		public static bool Valid() => default; // 0x00000001832437E0-0x0000000183243950
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool retainCustomDS, out uint normalList, out uint preZPart0List, out uint preZPart1List, ref Matrix4x4 prevViewProjection) {
			normalList = default;
			preZPart0List = default;
			preZPart1List = default;
		} // 0x0000000189DF5334-0x0000000189DF535C
		public static void DrawRendererList(CommandBuffer cmd, uint rendererList, bool renderDepthOnly) {} // 0x0000000189DF5490-0x0000000189DF54AC
		public static void AdvanceFrame() {} // 0x0000000189DF51F8-0x0000000189DF5224
		public static bool CullingInspectionMode() => default; // 0x0000000189DF53BC-0x0000000189DF53E8
		public static void PopulatePerFrameData(CommandBuffer cmd, uint threadGroupSize, uint hzbWidth, uint hzbHeight, bool usePrevVP = false /* Metadata: 0x01FD9D41 */) {} // 0x0000000189DF54AC-0x0000000189DF550C
		public static void BindFrameConstantsBuffer(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x0000000189DF52E0-0x0000000189DF5334
		public static void BindFrameConstantsBufferGlobal(CommandBuffer cmd) {} // 0x0000000189DF52AC-0x0000000189DF52E0
		public static void BindBuffersForCulling(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x0000000189DF5224-0x0000000189DF5278
		public static void BindBuffersForRendering(CommandBuffer cmd) {} // 0x0000000189DF5278-0x0000000189DF52AC
		public static void DispatchComputeMeshletInstanceCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x0000000189DF543C-0x0000000189DF5490
		public static void DispatchComputeDrawBucketCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x0000000189DF53E8-0x0000000189DF543C
	}

	[NativeType("Modules/HGGraphics/Public/GPUDriven/Version2/GPUDrivenRendererV2.h")]
	[StaticAccessor("GetGPUDrivenRendererV2()", StaticAccessorType.Dot)]
	public static class GPUDrivenRendererV2 // TypeDefIndex: 57380
	{
		// Methods
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, bool retainCustomDS, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, ref Matrix4x4 prevViewProjection) {} // 0x0000000189DF5648-0x0000000189DF56A8
		public static bool Valid() => default; // 0x00000001832437A0-0x00000001832437E0
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool retainCustomDS, out uint normalList, out uint preZPart0List, out uint preZPart1List, ref Matrix4x4 prevViewProjection) {
			normalList = default;
			preZPart0List = default;
			preZPart1List = default;
		} // 0x0000000189DF56A8-0x0000000189DF56D0
		public static void DrawRendererList(CommandBuffer cmd, uint rendererList, bool renderDepthOnly) {} // 0x0000000189DF5490-0x0000000189DF54AC
		public static void AdvanceFrame() {} // 0x0000000189DF550C-0x0000000189DF5538
		public static void BindFrameConstantsBuffer(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x0000000189DF55F4-0x0000000189DF5648
		public static void BindFrameConstantsBufferGlobal(CommandBuffer cmd) {} // 0x0000000189DF55C0-0x0000000189DF55F4
		public static void BindBuffersForCulling(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x0000000189DF5538-0x0000000189DF558C
		public static void BindBuffersForRendering(CommandBuffer cmd) {} // 0x0000000189DF558C-0x0000000189DF55C0
		public static void DispatchComputeMeshletInstanceCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x0000000189DF5724-0x0000000189DF5778
		public static void DispatchComputeDrawBucketCount(CommandBuffer cmd, ComputeShader shader, uint kernelIdx) {} // 0x0000000189DF56D0-0x0000000189DF5724
	}

	public struct CapsuleData // TypeDefIndex: 57381
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
	public static class HGCapsuleShadowManager // TypeDefIndex: 57382
	{
		// Methods
		public static uint GetRenderCapsuleNum() => default; // 0x0000000189DF591C-0x0000000189DF5948
		public static uint CullAndGetRenderCapsuleData(uint viewHandle, IntPtr outData, uint outDataCapacity) => default; // 0x0000000189DF58CC-0x0000000189DF591C
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGDecalRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetDecalRender()", StaticAccessorType.Dot)]
	public static class HGDecalRender // TypeDefIndex: 57383
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGShaderLightMode lightModeMask, IntPtr context) => default; // 0x0000000189DF5BF4-0x0000000189DF5C10
		public static uint CreateRendererList(uint viewHandle, HGShaderLightMode lightModeMask, IntPtr context, IntPtr drawableFeedbackPtr) => default; // 0x0000000189DF5C10-0x0000000189DF5C20
		private static unsafe uint CreateRendererList(uint viewHandle, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr) => default; // 0x0000000189DF5C20-0x0000000189DF5C80
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList) {} // 0x0000000189DF5C80-0x0000000189DF5C9C
	}

	public struct HGDrawCallDetailedStats // TypeDefIndex: 57384
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
	public class HGFastString // TypeDefIndex: 57385
	{
		// Constructors
		public HGFastString() {} // Dummy constructor
	
		// Methods
		[FreeFunction("HyperGryph::HGFastString::IndexToString")]
		public static string IndexToString(int index) => default; // 0x0000000182763330-0x0000000182763370
		[FreeFunction("HyperGryph::HGFastString::StringToIndex")]
		public static int StringToIndex(string s) => default; // 0x00000001827D9CC0-0x00000001827D9D00
	}

	public enum HGFactoryLODTier // TypeDefIndex: 57386
	{
		Low = 0,
		Medium = 1,
		High = 2,
		Ultra = 3
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryRendererData // TypeDefIndex: 57387
	{
		// Fields
		public Mesh m_mesh; // 0x00
		public Mesh m_shadowProxyMesh; // 0x08
		public Material[] m_materials; // 0x10
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryInstancingLODDataV3 // TypeDefIndex: 57388
	{
		// Fields
		public HGFactoryRendererData[] m_rendererDataArr; // 0x00
		public Vector4 m_lodScreenSizeMaxs; // 0x08
		public Vector4 m_lodScreenSizeMins; // 0x18
	}

	[Serializable]
	[UsedByNativeCode]
	public struct HGFactoryEntityDesc // TypeDefIndex: 57389
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

	public struct HGFactoryEntityTransformData // TypeDefIndex: 57390
	{
		// Fields
		public Vector4 m_positionAndScale; // 0x00
		public Quaternion m_rotation; // 0x10
	}

	[NativeHeader("Modules/HGGraphics/Public/Factory/HGFactoryRenderManager.h")]
	[StaticAccessor("HyperGryph::HGFactoryRenderManager::GetInstance()", StaticAccessorType.Dot)]
	public static class HGFactoryRenderManager // TypeDefIndex: 57391
	{
		// Methods
		public static void SetFactoryLodTier(HGFactoryLODTier lodTier) {} // 0x0000000183B2EA90-0x0000000183B2EAD0
		public static Entity CreateRegularEntity(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, string entityName, Entity gameplayEntity, Material[] additiveMaterials) => default; // 0x0000000183167F60-0x0000000183167FF0
		public static void UpdateRegularEntity(Entity gameplayEntity, HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc) {} // 0x0000000189DF6164-0x0000000189DF6180
		public static void UpdateRegularEntityAdditiveMaterials(Entity gameplayEntity, Material[] additiveMaterials) {} // 0x0000000189DF6148-0x0000000189DF6164
		public static void DestroyRegularEntity(Entity gameplayEntity) {} // 0x00000001842728D8-0x00000001842728F4
		public static void CreateBatchedEntities(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, NativeArray<Entity> entities, NativeArray<Entity> gameplayEntities, string entityName) {} // 0x00000001830872C0-0x0000000183087410
		public static void DestroyBatchedEntities(NativeArray<Entity> gameplayEntities) {} // 0x0000000182BC10D0-0x0000000182BC1110
		private static void CreateBatchedEntities(HGFactoryInstancingLODDataV3[] entityData, HGFactoryEntityDesc desc, IntPtr entities, IntPtr gameplayEntities, int count, string entityName) {} // 0x0000000184274E1C-0x0000000184274E48
		private static void DestroyBatchedEntities(IntPtr gameplayEntities, int count) {} // 0x0000000182BC1110-0x0000000182BC1160
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityEnabledLightModes(Entity rendererEntity, uint lightModeMask) {} // 0x0000000189DF612C-0x0000000189DF6148
		public static void SetEntitySharedData<T>(uint sharedDataIndex, T data, int offset)
			where T : struct {}
		[NativeMethod(IsThreadSafe = true)]
		private static void SetEntitySharedDataPartial(uint sharedDataIndex, IntPtr data, int offset, int size) {} // 0x0000000182F266E0-0x0000000182F26750
		[NativeMethod(IsThreadSafe = true)]
		public static byte GetEntityDirtyFlags(uint sharedDataIndex) => default; // 0x00000001824204A0-0x00000001824204E0
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityDirtyFlags(uint sharedDataIndex, byte flags) {} // 0x00000001824204E0-0x0000000182420530
		[NativeMethod(IsThreadSafe = true)]
		public static byte GetEntityObjectFlags(uint sharedDataIndex) => default; // 0x0000000182420DC0-0x0000000182420E00
		[NativeMethod(IsThreadSafe = true)]
		public static uint GetEntityAdditiveVFXFlags(uint sharedDataIndex) => default; // 0x0000000182421DD0-0x0000000182421E10
		[NativeMethod(IsThreadSafe = true)]
		public static void SetEntityAdditiveVFXFlags(uint sharedDataIndex, uint flags) {} // 0x0000000182421E10-0x0000000182421E60
		public static void FrameUpdateEntities() {} // 0x000000018350B670-0x000000018350B680
		private static void CreateRegularEntity_Injected(HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc, string entityName, ref Entity gameplayEntity, Material[] additiveMaterials, out Entity ret) {
			ret = default;
		} // 0x0000000183167FF0-0x0000000183168060
		private static void UpdateRegularEntity_Injected(ref Entity gameplayEntity, HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc) {} // 0x000000018349B420-0x000000018349B480
		private static void UpdateRegularEntityAdditiveMaterials_Injected(ref Entity gameplayEntity, Material[] additiveMaterials) {} // 0x00000001834DE4D0-0x00000001834DE520
		private static void DestroyRegularEntity_Injected(ref Entity gameplayEntity) {} // 0x0000000183891230-0x0000000183891270
		private static void CreateBatchedEntities_Injected(HGFactoryInstancingLODDataV3[] entityData, ref HGFactoryEntityDesc desc, IntPtr entities, IntPtr gameplayEntities, int count, string entityName) {} // 0x000000018368C870-0x000000018368C8E0
		private static void SetEntityEnabledLightModes_Injected(ref Entity rendererEntity, uint lightModeMask) {} // 0x0000000189DF60EC-0x0000000189DF612C
	}

	[UsedByNativeCode]
	public struct HGFoliageInteractCPP // TypeDefIndex: 57392
	{
		// Fields
		public int compID; // 0x00
		public Transform transform; // 0x08
		public Mesh interactCollider; // 0x10
	}

	[UsedByNativeCode]
	public struct HGFoliageInteractRaftCPP // TypeDefIndex: 57393
	{
		// Fields
		public int compID; // 0x00
		public Transform transform; // 0x08
		public Mesh interactCollider; // 0x10
	}

	[NativeType("Modules/HGGraphics/Public/FoliageInteractive/FoliageInteractiveManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageInteractiveManager()", StaticAccessorType.Dot)]
	public static class HGFoliageInteractiveManagerV2 // TypeDefIndex: 57394
	{
		// Methods
		public static void SetupFoliageInteractiveManager(Mesh characterProxyMesh, bool enabled) {} // 0x0000000183D00940-0x0000000183D00990
		public static void CleanUpFoliageInteractiveManager() {} // 0x0000000182D15570-0x0000000182D155B0
		public static void SetEnabled(bool enabled) {} // 0x0000000182ACDD40-0x0000000182ACDD80
		public static void SetInteractCenter(Vector3 center) {} // 0x0000000184272764-0x0000000184272774
		public static void SetCharacterPositions(List<Vector3> positions) {} // 0x0000000182A7B830-0x0000000182A7B8B0
		public static unsafe void SetCharacterPositions(Vector3* positions, int count) {} // 0x0000000182A7B8B0-0x0000000182A7B900
		public static void RegisterInteract(HGFoliageInteractCPP interact) {} // 0x0000000189DF6254-0x0000000189DF6264
		public static void UnregisterInteract(int interactInstID) {} // 0x0000000189DF6298-0x0000000189DF62CC
		public static void RegisterInteractRaft(HGFoliageInteractRaftCPP raft) {} // 0x0000000189DF6210-0x0000000189DF6220
		public static void UnregisterInteractRaft(int raftInstID) {} // 0x0000000189DF6264-0x0000000189DF6298
		private static void SetInteractCenter_Injected(ref Vector3 center) {} // 0x00000001833D7BD0-0x00000001833D7C10
		private static void RegisterInteract_Injected(ref HGFoliageInteractCPP interact) {} // 0x0000000189DF6220-0x0000000189DF6254
		private static void RegisterInteractRaft_Injected(ref HGFoliageInteractRaftCPP raft) {} // 0x0000000189DF61DC-0x0000000189DF6210
	}

	[NativeType("Modules/HGGraphics/Public/FoliageOccluder/FoliageOccluderManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageOccluderManager()", StaticAccessorType.Dot)]
	public static class HGFoliageOccluderManagerV2 // TypeDefIndex: 57395
	{
		// Methods
		public static void SetCenterPosition(Vector3 center) {} // 0x0000000184272774-0x0000000184272784
		private static void SetCenterPosition_Injected(ref Vector3 center) {} // 0x00000001833D7B90-0x00000001833D7BD0
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGFoliageOccluderRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetFoliageOccluderRender()", StaticAccessorType.Dot)]
	public static class HGFoliageOccluderRender // TypeDefIndex: 57396
	{
		// Methods
		public static uint CreateRendererList(uint viewHandle, uint materialHandle, uint geometryHandle, HGShaderLightMode lightModeMask, IntPtr context) => default; // 0x0000000189DF62CC-0x0000000189DF62F0
		private static unsafe uint CreateRendererList(uint viewHandle, uint materialHandle, uint geometryHandle, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr) => default; // 0x0000000189DF62F0-0x0000000189DF6350
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList) {} // 0x0000000189DF6350-0x0000000189DF636C
	}

	[UsedByNativeCode]
	public struct GpuClothClearBufferDataCPP // TypeDefIndex: 57397
	{
		// Fields
		public bool shouldClear; // 0x00
		public IVec4 eleNum; // 0x04
	
		// Methods
		public bool IsValid() => default; // 0x0000000183D51020-0x0000000183D51030
	}

	[UsedByNativeCode]
	public struct ClothGroupUploadDataMapCPP // TypeDefIndex: 57398
	{
		// Fields
		private IVec4 clothNodeDataMap; // 0x00
		private IVec4 clothBatchMetaDataMap; // 0x10
		private IVec4 clothBatchCacheDataMap; // 0x20
	}

	[UsedByNativeCode]
	public struct ClothMetaDataCPP // TypeDefIndex: 57399
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
	public struct ClothNodeDataCPP // TypeDefIndex: 57402
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
	}

	[UsedByNativeCode]
	public struct GpuClothGroupUploadDataCPP // TypeDefIndex: 57403
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
		public bool IsValid() => default; // 0x0000000183D51020-0x0000000183D51030
	}

	[UsedByNativeCode]
	public struct ClothConstDataCPP // TypeDefIndex: 57405
	{
		// Fields
		private Vector4 packedDeltaT; // 0x00
		private Vector4 clothParam1; // 0x10
		private unsafe fixed /* 0x00000000-0x00000000 */ float colliderInfos[0]; // 0x20
	}

	[UsedByNativeCode]
	public struct GpuClothRenderDataCPP // TypeDefIndex: 57406
	{
		// Fields
		public bool isValid; // 0x00
		public int clothNum; // 0x04
		public ClothConstDataCPP clothConstData; // 0x08
	
		// Methods
		public bool IsValid() => default; // 0x0000000183D51020-0x0000000183D51030
	}

	[NativeHeader("Modules/HGGraphics/Public/GpuCloth/GpuClothManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGpuClothManager()", StaticAccessorType.Dot)]
	public static class HGGpuClothManagerV2 // TypeDefIndex: 57407
	{
		// Methods
		public static void SetupGpuClothManager(Mesh defaultCapsuleMesh) {} // 0x0000000183D1EFA0-0x0000000183D1EFE0
		public static void SetWindDirection(Vector3 direction) {} // 0x00000001842746B8-0x00000001842746C8
		public static void SetPlayerCenter(Vector3 playerCenter) {} // 0x00000001842746C8-0x00000001842746D8
		public static void UpdateCharacterPositions(List<Vector3> positions) {} // 0x0000000182A7B7B0-0x0000000182A7B830
		public static unsafe void UpdateCharacterPositions(Vector3* positionPtr, int count) {} // 0x0000000182A7B900-0x0000000182A7B950
		public static bool IsClothSkeletonValid() => default; // 0x0000000189DF65C4-0x0000000189DF65F0
		public static bool IsClothSkeletonFlipped() => default; // 0x0000000189DF6598-0x0000000189DF65C4
		public static bool ShouldStep() => default; // 0x0000000189DF65F0-0x0000000189DF661C
		public static GpuClothClearBufferDataCPP GetClearBufferData_CSharpWrapper() => default; // 0x0000000189DF63D4-0x0000000189DF63F8
		public static GpuClothGroupUploadDataCPP GetUploadData_CSharpWrapper() => default; // 0x0000000189DF6568-0x0000000189DF6598
		public static GpuClothRenderDataCPP GetRenderData_CSharpWrapper() => default; // 0x0000000189DF64DC-0x0000000189DF6508
		public static uint GetSkeletonBufferID() => default; // 0x0000000189DF6508-0x0000000189DF6534
		public static uint GetClothNodeBufferID() => default; // 0x0000000189DF647C-0x0000000189DF64A8
		public static uint GetClothMetaDataBufferID() => default; // 0x0000000189DF6450-0x0000000189DF647C
		public static uint GetClothBatchMetaDataBufferID() => default; // 0x0000000189DF6424-0x0000000189DF6450
		public static uint GetClothBatchCacheMapBufferID() => default; // 0x0000000189DF63F8-0x0000000189DF6424
		private static void SetWindDirection_Injected(ref Vector3 direction) {} // 0x0000000182F24980-0x0000000182F249C0
		private static void SetPlayerCenter_Injected(ref Vector3 playerCenter) {} // 0x0000000182F24940-0x0000000182F24980
		private static void GetClearBufferData_CSharpWrapper_Injected(out GpuClothClearBufferDataCPP ret) {
			ret = default;
		} // 0x0000000189DF63A0-0x0000000189DF63D4
		private static void GetUploadData_CSharpWrapper_Injected(out GpuClothGroupUploadDataCPP ret) {
			ret = default;
		} // 0x0000000189DF6534-0x0000000189DF6568
		private static void GetRenderData_CSharpWrapper_Injected(out GpuClothRenderDataCPP ret) {
			ret = default;
		} // 0x0000000189DF64A8-0x0000000189DF64DC
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGLODSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetLODStateSystem()", StaticAccessorType.Dot)]
	public static class HGLODStateSystem // TypeDefIndex: 57408
	{
		// Methods
		public static bool IsCurrFrameTriggerTransition() => default; // 0x00000001825B2AE0-0x00000001825B2B20
		public static float GetLODTransitionFraction() => default; // 0x000000018279F3F0-0x000000018279F430
		public static float GetLODTransitionTime() => default; // 0x0000000183CB52B0-0x0000000183CB52F0
		public static void SetLODTransitionTime(float lodTransitionTime) {} // 0x000000018382DC00-0x000000018382DC50
	}

	[Flags]
	public enum LODStreamingStatus : byte // TypeDefIndex: 57409
	{
		Idle = 0,
		Loading = 1,
		Unloading = 2,
		Disabled = 4
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGLODStreamingSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetLODStreamingSystem()", StaticAccessorType.Dot)]
	public static class HGLODStreamingSystem // TypeDefIndex: 57410
	{
		// Properties
		public static bool enableLODStreaming { [NativeName("GetEnableLODStreaming")] get; [NativeName("SetEnableLODStreaming")] set; } // 0x0000000183D3E6A0-0x0000000183D3E6E0 0x0000000183D00FB0-0x0000000183D00FF0
		public static bool enableLODStreamingKeepLastLODResource { get; [NativeName("SetEnableLODStreamingKeepLastLODResource")] set; } // 0x000000018279F310-0x000000018279F350
		public static LODCrossFadeConfig lodConfig { get; [NativeName("SetLODConfig")] set; } // 0x00000001842718D8-0x00000001842718E8
		public static float lodStreamingLoadDirtyDistance { get; [NativeName("SetLODStreamingLoadDirtyDistance")] set; } // 0x000000018279F350-0x000000018279F3A0
		public static float lodStreamingUnloadDirtyDistance { get; [NativeName("SetLODStreamingUnloadDirtyDistance")] set; } // 0x000000018279F3A0-0x000000018279F3F0
	
		// Methods
		public static void SetArtTagLODStreamingOffset(uint artTag, int lodStreamingOffset) {} // 0x0000000183367160-0x00000001833671B0
		public static void SetHLODUnloadDistance(int hlodLevel, float unloadDistance) {} // 0x000000018279F160-0x000000018279F1B0
		public static LODStreamingStatus QueryLODStreamingStatus() => default; // 0x0000000189DF6D14-0x0000000189DF6D40
		private static void set_lodConfig_Injected(ref LODCrossFadeConfig value) {} // 0x000000018328C9C0-0x000000018328CA00
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGShadingStateSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetShadingStateSystem()", StaticAccessorType.Dot)]
	public static class HGShadingStateSystem // TypeDefIndex: 57411
	{
		// Events
		public static event UnityAction<int, bool> shadingStateChanged;
	
		// Methods
		public static uint GetMaterialHandle(int instanceId) => default; // 0x0000000182AC07C0-0x0000000182AC0800
		public static Material GetMaterial(uint handle) => default; // 0x0000000189DF75D8-0x0000000189DF760C
		[RequiredByNativeCode]
		private static void Internal_OnShadingStateChanged(int instanceId, bool state) {} // 0x0000000189DF760C-0x0000000189DF766C
		public static void FlushAllMaterialCallbacks() {} // 0x000000018388D300-0x000000018388D340
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGGeometrySystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGeometrySystem()", StaticAccessorType.Dot)]
	public static class HGGeometrySystem // TypeDefIndex: 57412
	{
		// Methods
		public static uint GetGeometryHandle(int instanceId) => default; // 0x0000000189DF636C-0x0000000189DF63A0
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGGeometrySystem.h")]
	[StaticAccessor("HyperGryph::GetMeshBufferAllocator()", StaticAccessorType.Arrow)]
	public static class HGMeshBufferAllocator // TypeDefIndex: 57413
	{
		// Methods
		public static void GarbageCollect() {} // 0x00000001830CDF00-0x00000001830CDF40
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGGeometryJobRendererUtils.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceSetup.h")]
	[NativeHeader("Runtime/GfxDevice/hg/HGTempBuffer.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGRendererSystem.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGCullingSystem.h")]
	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	public static class HGGraphicsUtils // TypeDefIndex: 57414
	{
		// Properties
		public static bool enableRayTracing { [FreeFunction("GetEnableRayTracing")] get; [FreeFunction("SetEnableRayTracing")] set; } // 0x0000000183D2CF80-0x0000000183D2CFC0 0x0000000183A2D070-0x0000000183A2D0B0
		public static bool enableRayTracingRender { [FreeFunction("GetEnableRayTracingRender")] get; [FreeFunction("SetEnableRayTracingRender")] set; } // 0x00000001832436E0-0x0000000183243720 0x0000000183A2D0B0-0x0000000183A2D0F0
		public static bool enableECSRenderer { [FreeFunction("GetEnableECSRenderer")] get; } // 0x0000000189DF681C-0x0000000189DF6848 
		public static bool enableHGNewGraphicsAPI { [FreeFunction("GetEnableHGNewGraphicsAPI")] get; } // 0x0000000189DF6848-0x0000000189DF6874 
		public static bool enableCppRenderPath { [FreeFunction("GetEnableCppRenderPath")] get; } // 0x0000000183241380-0x00000001832413C0 
		public static int maxAnisoLevel { [FreeFunction("GetHGMaxAnisoLevel")] get; [FreeFunction("SetHGMaxAnisoLevel")] set; } // 0x0000000189DF6874-0x0000000189DF68A0 0x0000000183CC4600-0x0000000183CC4640
		public static bool enableRenderingCommandBufferDirectCall { get; [FreeFunction("SetEnableRenderingCommandBufferDirectCall")] set; } // 0x00000001831B4E20-0x00000001831B4E60
	
		// Methods
		[FreeFunction("HGAllocateTempVertexBuffer")]
		public static CBHandle HGAllocateTempVertexBuffer(int size) => default; // 0x0000000189DF67B8-0x0000000189DF67E8
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint AllocateTempCompoundRendererListFromScript(ref IntPtr outPtr) => default; // 0x0000000189DF661C-0x0000000189DF6650
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static bool IsCompoundRendererListDrawable(uint id) => default; // 0x0000000189DF67E8-0x0000000189DF681C
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static void PrepareGeometryJobRenderersForRendering() {} // 0x0000000183243720-0x0000000183243760
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint CreateMetalFXSpatialScaler(int inputWidth, int inputWeight, int outputWidth, int outputHeight, GraphicsFormat colorTextureFormat, GraphicsFormat outputTextureFormat) => default; // 0x0000000189DF6650-0x0000000189DF66B0
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static void DestroyMetalFXSpatialScaler(uint spatialScalerHandle) {} // 0x0000000189DF6710-0x0000000189DF6744
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static uint CreateMetalFXTemporalScaler(int inputWidth, int inputWeight, int outputWidth, int outputHeight, GraphicsFormat colorTextureFormat, GraphicsFormat depthTextureFormat, GraphicsFormat motionTextureFormat, GraphicsFormat outputTextureFormat) => default; // 0x0000000189DF66B0-0x0000000189DF6710
		[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
		public static void DestroyMetalFXTemporalScaler(uint temporalScalerHandle) {} // 0x0000000189DF6744-0x0000000189DF6778
		private static void HGAllocateTempVertexBuffer_Injected(int size, out CBHandle ret) {
			ret = default;
		} // 0x0000000189DF6778-0x0000000189DF67B8
	}

	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/ECS/HGRendererSystem.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetRendererSystem()", StaticAccessorType.Dot)]
	public static class HGRendererSystem // TypeDefIndex: 57415
	{
		// Properties
		public static Vector3 PerRendererLightingFallbackPosition { get; set; } // 0x0000000189DF73D0-0x0000000189DF73E0
		public static uint MaxPerRendererLightingCount { get; } // 0x0000000189DF733C-0x0000000189DF7368 
		public static uint CSMStopRenderCharacterCascadeLevel { get; set; } // 0x0000000189DF7368-0x0000000189DF739C
	
		// Methods
		private static void set_PerRendererLightingFallbackPosition_Injected(ref Vector3 value) {} // 0x0000000189DF739C-0x0000000189DF73D0
	}

	[NativeHeader("Modules/HGGraphics/Public/HGGlobalGameManager.h")]
	[StaticAccessor("GetHGGlobalGameManager()", StaticAccessorType.Dot)]
	public static class HGLogicTimeManager // TypeDefIndex: 57416
	{
		// Methods
		public static void SetLogicTickDeltaTime(float deltaTime) {} // 0x000000018303E110-0x000000018303E160
		public static void SetHgrpDeltaTime(float deltaTime) {} // 0x0000000182634260-0x00000001826342B0
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGGrassRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetGrassRender()", StaticAccessorType.Dot)]
	public static class HGGrassRender // TypeDefIndex: 57417
	{
		// Properties
		public static float grassGlobalSparsity { get; set; } // 0x00000001838BA700-0x00000001838BA750
	
		// Methods
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, bool noAlphaTest = false /* Metadata: 0x01FD9D4A */) => default; // 0x0000000189DF68A0-0x0000000189DF68D0
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, uint* drawableFeedbackPtr, bool noAlphaTest) => default; // 0x0000000189DF68D0-0x0000000189DF6930
		public static uint RegisterGrassBatchGroup(uint batchGroupKey, Material material, Mesh mesh, ushort subMeshIndex) => default; // 0x0000000189DF694C-0x0000000189DF69B0
		public static void UnregisterGrassBatchGroupWithHandle(uint batchGroupKey, uint batchGroupHandle) {} // 0x0000000189DF69B0-0x0000000189DF69F0
		public static bool IsInGrassBoundsV2(Vector3 worldPos, out Bounds overlapBounds, out Bounds originBounds, out uint argTag) {
			overlapBounds = default;
			originBounds = default;
			argTag = default;
			return default;
		} // 0x000000018426FAA0-0x000000018426FAB8
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList) {} // 0x0000000189DF6930-0x0000000189DF694C
		private static bool IsInGrassBoundsV2_Injected(ref Vector3 worldPos, out Bounds overlapBounds, out Bounds originBounds, out uint argTag) {
			overlapBounds = default;
			originBounds = default;
			argTag = default;
			return default;
		} // 0x00000001830FDCB0-0x00000001830FDD20
	}

	public enum EInteractionProxyType : uint // TypeDefIndex: 57418
	{
		Sphere = 0,
		Capsule = 1,
		Texture = 2,
		Mesh = 3
	}

	[UsedByNativeCode]
	public struct HGInteractionNodeV2 // TypeDefIndex: 57419
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
	public struct HGDecalInteractionParametersV2 // TypeDefIndex: 57420
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
	public static class HGInteractionManagerV2 // TypeDefIndex: 57421
	{
		// Methods
		public static void UpdateFromNodes(NativeArray<HGInteractionNodeV2> nodes, int nodeCount, bool bUpdateMobile) {} // 0x0000000183090790-0x0000000183090820
		[StaticAccessor("GetHGGlobalGameManager().GetInteractionManager()", StaticAccessorType.Dot)]
		public static void UpdateFromNodes(IntPtr nodeData, int nodeCount, bool bUpdateMobile) {} // 0x0000000183090820-0x0000000183090880
		[StaticAccessor("GetHGGlobalGameManager().GetInteractionManager()", StaticAccessorType.Dot)]
		public static void UpdateSettingParameters(HGDecalInteractionParametersV2 settingParameters) {} // 0x0000000189DF69F0-0x0000000189DF6A00
		private static void UpdateSettingParameters_Injected(ref HGDecalInteractionParametersV2 settingParameters) {} // 0x00000001831B4EB0-0x00000001831B4EF0
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumeConfig // TypeDefIndex: 57433
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
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumePipelineUpdateResult // TypeDefIndex: 57434
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
	public class HGIrradianceVolume // TypeDefIndex: 57435
	{
		// Constructors
		public HGIrradianceVolume() {} // Dummy constructor
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static long Create([IsReadOnly] in HGIrradianceVolumeConfig config) => default; // 0x000000018263D140-0x000000018263D180
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void Destroy(long id) {} // 0x0000000189DF6C14-0x0000000189DF6C48
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetEnableV3(bool enable) {} // 0x000000018263D180-0x000000018263D1C0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetSceneStateNames(string[] stateNames, string[] activateStates) {} // 0x0000000183589350-0x00000001835893A0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateNames(string[] activateNames) {} // 0x0000000189DF6C48-0x0000000189DF6C7C
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateMask(uint mask) {} // 0x0000000182F12F30-0x0000000182F12F70
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static string[] GetActiveSceneStateNames() => default; // 0x0000000183589310-0x0000000183589350
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetMap(long id, string path) {} // 0x000000018263D1C0-0x000000018263D210
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetMapV3(long id, string path) {} // 0x000000018263D210-0x000000018263D260
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void StreamingInCabin(long id, string slotId, uint roomTypeId) {} // 0x0000000189DF6C7C-0x0000000189DF6CD0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void StreamingOutCabin(long id, string slotId) {} // 0x0000000189DF6CD0-0x0000000189DF6D14
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void SetStreamingCenter(long id, Vector3 center) {} // 0x0000000184270CD0-0x0000000184270CE4
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolume()", StaticAccessorType.Dot)]
		public static void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResult result, long id, IntPtr renderContext, CommandBuffer cmd, int bakeCS, int updateIndirectionCS) {
			result = default;
		} // 0x000000018263CD80-0x000000018263CDF0
		private static void SetStreamingCenter_Injected(long id, ref Vector3 center) {} // 0x000000018263D310-0x000000018263D360
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumeConfigV2 // TypeDefIndex: 57455
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
	}

	[UsedByNativeCode]
	public struct HGIrradianceVolumePipelineUpdateResultV2 // TypeDefIndex: 57456
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
	public class HGIrradianceVolumeV2 // TypeDefIndex: 57457
	{
		// Constructors
		public HGIrradianceVolumeV2() {} // Dummy constructor
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static long Create([IsReadOnly] in HGIrradianceVolumeConfigV2 config) => default; // 0x0000000183D3E6E0-0x0000000183D3E720
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void Destroy(long id) {} // 0x0000000189DF6A00-0x0000000189DF6A34
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetSceneStateNames(string[] stateNames, string[] activateStates) {} // 0x0000000183589460-0x00000001835894B0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateNames(string[] activateStates) {} // 0x0000000189DF6A98-0x0000000189DF6ACC
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetActiveSceneStateMask(uint mask) {} // 0x0000000182F12FB0-0x0000000182F12FF0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static string[] GetActiveSceneStateNames() => default; // 0x0000000183589420-0x0000000183589460
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetMap(long id, string path) {} // 0x0000000183D008F0-0x0000000183D00940
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetStreamingCenter(long id, Vector3 center) {} // 0x0000000189DF6B68-0x0000000189DF6B7C
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void SetCameraForwardDirection(long id, Vector3 cameraForwardDir) {} // 0x0000000189DF6B10-0x0000000189DF6B24
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void PipelineUpdate(out HGIrradianceVolumePipelineUpdateResultV2 result, long id, IntPtr renderContext, CommandBuffer cmd, int bakeCS, int updateClipmapCS) {
			result = default;
		} // 0x0000000189DF6A34-0x0000000189DF6A98
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void StreamingInCabin(long id, long slotId, uint roomTypeId) {} // 0x0000000189DF6B7C-0x0000000189DF6BD0
		[StaticAccessor("GetHGGlobalGameManager().GetHGIrradianceVolumeV2()", StaticAccessorType.Dot)]
		public static void StreamingOutCabin(long id, long slotId) {} // 0x0000000189DF6BD0-0x0000000189DF6C14
		private static void SetStreamingCenter_Injected(long id, ref Vector3 center) {} // 0x0000000189DF6B24-0x0000000189DF6B68
		private static void SetCameraForwardDirection_Injected(long id, ref Vector3 cameraForwardDir) {} // 0x0000000189DF6ACC-0x0000000189DF6B10
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGMeshRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetMeshRender()", StaticAccessorType.Dot)]
	public static class HGMeshRender // TypeDefIndex: 57458
	{
		// Methods
		private static unsafe uint CreateRendererList(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalKeywords, IntPtr context, bool multiDraw, bool transparentSorting, uint cullingLayerMask, bool noAlphaTest, uint* drawableFeedbackPtr, bool excludeGPUDriven) => default; // 0x0000000189DF6F30-0x0000000189DF6FA4
		private static void CreateRendererListWithPreZ(uint viewHandle, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, IntPtr context, ref uint normalList, ref uint preZPart0List, ref uint preZPart1List, bool excludeGPUDriven) {} // 0x0000000189DF6DC8-0x0000000189DF6E28
		private static uint CreateRendererListWithCharacterIndex(uint viewHandle, ushort characterIndex, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, ushort globalHGKeywords, IntPtr context) => default; // 0x0000000189DF6D40-0x0000000189DF6DAC
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, bool multiDraw = false /* Metadata: 0x01FD9D4F */, bool transparentSorting = false /* Metadata: 0x01FD9D50 */, uint cullingLayerMask = 4294967295 /* Metadata: 0x01FD9D51 */, bool noAlphaTest = false /* Metadata: 0x01FD9D52 */, bool excludeGPUDriven = false /* Metadata: 0x01FD9D53 */) => default; // 0x0000000189DF6E50-0x0000000189DF6EBC
		public static uint CreateRendererList(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context, IntPtr drawableFeedbackPtr, bool multiDraw = false /* Metadata: 0x01FD9D54 */, bool transparentSorting = false /* Metadata: 0x01FD9D55 */, uint cullingLayerMask = 4294967295 /* Metadata: 0x01FD9D56 */, bool noAlphaTest = false /* Metadata: 0x01FD9D57 */, bool excludeGPUDriven = false /* Metadata: 0x01FD9D58 */) => default; // 0x0000000189DF6EBC-0x0000000189DF6F30
		public static uint CreateRendererListWithCharacterIndex(uint viewHandle, ushort characterIndex, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, HGRenderKeyword globalKeywords, IntPtr context) => default; // 0x0000000189DF6DAC-0x0000000189DF6DC8
		public static void CreateRendererListWithPreZ(uint viewHandle, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, IntPtr context, out uint normalList, out uint preZPart0List, out uint preZPart1List, bool excludeGPUDriven = false /* Metadata: 0x01FD9D59 */) {
			normalList = default;
			preZPart0List = default;
			preZPart1List = default;
		} // 0x0000000189DF6E28-0x0000000189DF6E50
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList) {} // 0x0000000189DF6FD0-0x0000000189DF6FEC
		public static void DrawECSMeshRendererListWithSRPRendererList(CommandBuffer cmd, uint ecsList, UnityEngine.Rendering.RendererUtils.RendererList srpList) {} // 0x0000000189DF6FA4-0x0000000189DF6FD0
	}

	[NativeType("Modules/HGGraphics/Public/RayTracing/HGRayTracingScene.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetRayTracingScene()", StaticAccessorType.Dot)]
	public static class HGRayTracingScene // TypeDefIndex: 57459
	{
		// Methods
		public static uint AddCullViewHandle(ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, LODCrossFadeConfig config, float viewScreenSizeMinSquared, float cullingRadius) => default; // 0x0000000189DF713C-0x0000000189DF7178
		public static uint PrepareTLASCreationForCullView(uint viewHandle) => default; // 0x0000000189DF7178-0x0000000189DF71AC
		private static uint AddCullViewHandle_Injected(ulong sceneMask, uint cullingLayerMask, uint objectFlagsValue, uint objectFlagsMask, ref LODCrossFadeConfig config, float viewScreenSizeMinSquared, float cullingRadius) => default; // 0x0000000189DF70DC-0x0000000189DF713C
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGReflectionProbeSystem.h")]
	public class HGReflectionProbe // TypeDefIndex: 57460
	{
		// Properties
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()")]
		public static float cameraMovementNotFadeness { get => default; } // 0x0000000189DF7310-0x0000000189DF733C 
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()")]
		public static float fadeTime { get => default; } // 0x00000001832436A0-0x00000001832436E0 
	
		// Constructors
		public HGReflectionProbe() {} // Dummy constructor
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static uint AddView(Camera camera) => default; // 0x0000000182E87070-0x0000000182E870B0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void RemoveView(uint viewHandle) {} // 0x0000000183D1EF60-0x0000000183D1EFA0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void ResetView(uint viewHandle) {} // 0x0000000182E870B0-0x0000000182E870F0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewPhase0(uint viewHandle, Vector3 cameraPosition, Vector3 visibleBox, bool loadSync = false /* Metadata: 0x01FD9D5A */) {} // 0x00000001842743B4-0x00000001842743D0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewPhase1(uint viewHandle, float dt, bool enableFadeness, IntPtr blitList, int maxBlitCount, out int blitCount) {
			blitCount = default;
		} // 0x0000000189DF72B0-0x0000000189DF7310
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void UpdateViewCBHandle(uint viewHandle, Matrix4x4 worldToCameraMatrix, Matrix4x4 unitExtents, IntPtr binningBufferPtr, IntPtr globalBufferPtr) {} // 0x0000000189DF728C-0x0000000189DF72B0
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static Texture GetTexture(uint viewHandle, ulong hash) => default; // 0x0000000189DF71EC-0x0000000189DF722C
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static int GetTextureIndex(uint viewHandle, ulong hash) => default; // 0x0000000189DF71AC-0x0000000189DF71EC
		[StaticAccessor("GetHGGlobalGameManager().GetHGReflectionProbeSystem()", StaticAccessorType.Dot)]
		public static void SetViewTextureArrayCount(uint viewHandle, int count) {} // 0x0000000182E870F0-0x0000000182E87140
		private static void UpdateViewPhase0_Injected(uint viewHandle, ref Vector3 cameraPosition, ref Vector3 visibleBox, bool loadSync = false /* Metadata: 0x01FD9D5B */) {} // 0x0000000182E87140-0x0000000182E871B0
		private static void UpdateViewCBHandle_Injected(uint viewHandle, ref Matrix4x4 worldToCameraMatrix, ref Matrix4x4 unitExtents, IntPtr binningBufferPtr, IntPtr globalBufferPtr) {} // 0x0000000189DF722C-0x0000000189DF728C
	}

	public enum AssetType // TypeDefIndex: 57461
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

	public enum AssetPriority : ushort // TypeDefIndex: 57462
	{
		Preload = 0,
		LODStreaming = 5,
		Default = 10,
		Streaming = 15
	}

	public enum AssetState : byte // TypeDefIndex: 57463
	{
		Loading = 0,
		Loaded = 1,
		Failed = 2
	}

	public struct VFSBlockFileInfo // TypeDefIndex: 57464
	{
		// Fields
		public ulong offset; // 0x00
		public ulong len; // 0x08
		public string chunkFilePath; // 0x10
	}

	public struct AssetIdentifier // TypeDefIndex: 57465
	{
		// Fields
		public long hash; // 0x00
		public AssetType type; // 0x08
	}

	public struct AssetHandleIndex // TypeDefIndex: 57466
	{
		// Fields
		public uint index; // 0x00
	}

	public struct AssetOperation // TypeDefIndex: 57467
	{
		// Fields
		public bool isLoadOperation; // 0x00
		public AssetPriority priority; // 0x02
		public AssetHandleIndex handleIndex; // 0x04
		public AssetIdentifier identifier; // 0x08
	}

	[NativeHeader("Modules/HGGraphics/Public/HGResourceManager.bindings.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetHGResourceManager()", StaticAccessorType.Dot)]
	public static class HGResourceManager // TypeDefIndex: 57471
	{
		// Fields
		public static GetFileHashMappingCallback getFileHashMappingCallback; // 0x00
		public static GetFilePathMappingCallback getFilePathMappingCallback; // 0x08
		public static GetTextureFromHGWaterSectorDataCallback getWaterSectorTextureCallback; // 0x10
		private static readonly System.Type[] kAssetTypeToUnityType; // 0x18
	
		// Properties
		public static bool usingVFS { get; [NativeName("SetUsingVFS")] set; } // 0x00000001822A1910-0x00000001822A1950
		public static IntPtr assetOperations { get; } // 0x00000001822A1A20-0x00000001822A1A60 
		public static int assetOperationCount { get; } // 0x00000001822A1950-0x00000001822A1A20 
	
		// Nested types
		public delegate VFSBlockFileInfo GetFileHashMappingCallback(long originNameHash); // TypeDefIndex: 57468; 0x000000018500ADA0-0x000000018500ADD8
	
		public delegate VFSBlockFileInfo GetFilePathMappingCallback(string originName); // TypeDefIndex: 57469; 0x000000018500ADA0-0x000000018500ADD8
	
		public delegate Texture2D GetTextureFromHGWaterSectorDataCallback(ScriptableObject sectorDataScriptableObject); // TypeDefIndex: 57470; 0x000000018102B410-0x000000018102B420
	
		// Constructors
		static HGResourceManager() {} // 0x000000018389EAB0-0x000000018389ED90
	
		// Methods
		public static AssetHandleIndex LoadAsync(long assetHash, AssetType type, AssetPriority priority) => default; // 0x0000000183290A30-0x0000000183290AC0
		public static void Dispose(AssetHandleIndex assetHandle) {} // 0x00000001832909A0-0x00000001832909F0
		public static AssetState GetAssetState(AssetHandleIndex assetHandle) => default; // 0x0000000183407DA0-0x0000000183407DF0
		private static UnityEngine.Object GetAsset(AssetHandleIndex assetHandle) => default; // 0x0000000183407D10-0x0000000183407D60
		public static bool TryGetAsset<T>(AssetHandleIndex assetHandle, out ref T asset)
			where T : UnityEngine.Object {
			asset = default;
			return default;
		}
		public static void UpdateAssetHandle(AssetHandleIndex handleIndex, AssetIdentifier identifier, AssetState state, int assetInstanceID) {} // 0x00000001822A1CA0-0x00000001822A1D40
		public static void ClearAssetOperations() {} // 0x00000001822A18D0-0x00000001822A1910
		public static void Reset() {} // 0x0000000182E77B90-0x0000000182E77BD0
		[RequiredByNativeCode]
		public static VFSBlockFileInfo GetFileHashMapping(long originNameHash) => default; // 0x0000000182E9C240-0x0000000182E9C2F0
		[RequiredByNativeCode]
		public static VFSBlockFileInfo GetFilePathMapping(string originName) => default; // 0x0000000189DF7474-0x0000000189DF750C
		[RequiredByNativeCode]
		public static Texture2D GetTextureFromHGWaterSectorData(ScriptableObject sectorDataScriptableObject) => default; // 0x0000000189DF750C-0x0000000189DF7574
		public static NativeArray<AssetOperation> GetAssetOperationsArray() => default; // 0x0000000189DF73E0-0x0000000189DF7474
		private static void LoadAsync_Injected(long assetHash, AssetType type, AssetPriority priority, out AssetHandleIndex ret) {
			ret = default;
		} // 0x0000000183290930-0x00000001832909A0
		private static void Dispose_Injected(ref AssetHandleIndex assetHandle) {} // 0x00000001832909F0-0x0000000183290A30
		private static AssetState GetAssetState_Injected(ref AssetHandleIndex assetHandle) => default; // 0x0000000183407DF0-0x0000000183407E30
		private static UnityEngine.Object GetAsset_Injected(ref AssetHandleIndex assetHandle) => default; // 0x0000000183407D60-0x0000000183407DA0
		private static void UpdateAssetHandle_Injected(ref AssetHandleIndex handleIndex, ref AssetIdentifier identifier, AssetState state, int assetInstanceID) {} // 0x00000001822A1D40-0x00000001822A1DB0
	
		// Extension methods
		public static System.Type ToUnityType(this AssetType type) => default; // 0x0000000189DF7574-0x0000000189DF75D8
	}

	[Flags]
	public enum HGRenderFlags : uint // TypeDefIndex: 57472
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

	[Flags]
	public enum HGRenderKeyword : ushort // TypeDefIndex: 57473
	{
		None = 0,
		CrossFade = 1,
		Dither = 2
	}

	[Flags]
	public enum HGShaderLightMode : uint // TypeDefIndex: 57474
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

	[Flags]
	public enum HGObjectFlags : uint // TypeDefIndex: 57475
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

	[Flags]
	public enum HGFactoryDirtyFlags : byte // TypeDefIndex: 57476
	{
		None = 0,
		PerDrawData = 1,
		ObjectData = 2,
		TransformData = 4,
		VFXStatus = 16,
		VFXVisibility = 32
	}

	[UsedByNativeCode]
	public struct IVec2 // TypeDefIndex: 57477
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
	}

	[UsedByNativeCode]
	public struct IVec4 // TypeDefIndex: 57478
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public int w; // 0x0C
	}

	[UsedByNativeCode]
	public struct SludgeNodeData // TypeDefIndex: 57480
	{
		// Fields
		public byte allHole; // 0x00
		public byte treeLevel; // 0x01
		public ushort parent; // 0x02
		public Vector3 aabbCenter; // 0x04
		public Vector3 aabbExtent; // 0x10
		public unsafe fixed /* 0x00000000-0x00000000 */ byte patchAABBData[0]; // 0x1C
	}

	[UsedByNativeCode]
	public struct SludgeHeightmapInfo // TypeDefIndex: 57481
	{
		// Fields
		public Vector4 heightmapUVOffsetScale; // 0x00
		public Texture2D heightmapAtlas; // 0x10
	}

	[NativeType("Modules/HGGraphics/Public/Sludge/HGSludgeRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetSludgeRender()", StaticAccessorType.Dot)]
	public static class HGSludgeRender // TypeDefIndex: 57482
	{
		// Methods
		public static bool RegisterSludge(Entity entity, Texture2D bakedHeightmap, NativeArray<SludgeNodeData> nodeData) => default; // 0x0000000182AC0800-0x0000000182AC0870
		private static bool RegisterSludge(Entity entity, Texture2D bakedHeightmap, int nodeCount, IntPtr nodeData) => default; // 0x000000018427290C-0x0000000184272930
		public static void UnregisterAndDestroySludge(Entity entity) {} // 0x0000000189DF79A8-0x0000000189DF79C4
		public static uint CreateRendererList(Camera camera, Vector2Int sceneRTSize, uint viewHandle, HGShaderLightMode lightModeMask, HGShaderLightMode decalLightModeMask, float lodFactor, IntPtr context, bool useMetric = true /* Metadata: 0x01FD9E6F */) => default; // 0x0000000189DF76D0-0x0000000189DF76EC
		private static uint CreateRendererList(Camera camera, Vector2Int sceneRTSize, uint viewHandle, uint lightModeMask, uint decalLightModeMask, float loadFactor, IntPtr context, bool useMetric) => default; // 0x0000000189DF76EC-0x0000000189DF7740
		public static void DrawECSRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customPros) {} // 0x0000000189DF77E0-0x0000000189DF7830
		public static void DrawECSDecalRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customProps) {} // 0x0000000189DF7790-0x0000000189DF77E0
		public static void DrawECSBlendRendererList(CommandBuffer cmd, uint rendererList, MaterialPropertyBlock customProps) {} // 0x0000000189DF7740-0x0000000189DF7790
		public static void HitSludge(Entity entity, Vector3 worldPos, float range, float deltaHeightNormalized = 1f /* Metadata: 0x01FD9E70 */) {} // 0x0000000189DF7924-0x0000000189DF7948
		public static SludgeHeightmapInfo GetHeightmapInfo(Entity entity) => default; // 0x000000018304C600-0x000000018304C640
		public static uint GetDynamicThicknessMapSize() => default; // 0x0000000189DF7894-0x0000000189DF78C0
		public static bool ShouldDrawThicknessMap() => default; // 0x0000000189DF7948-0x0000000189DF7974
		public static void DrawThicknessMap(IntPtr context, CommandBuffer cmd, Material blitMat, int passIdx, int viewHandle) {} // 0x0000000189DF7830-0x0000000189DF7894
		private static bool RegisterSludge_Injected(ref Entity entity, Texture2D bakedHeightmap, int nodeCount, IntPtr nodeData) => default; // 0x0000000183C8F6D0-0x0000000183C8F740
		private static void UnregisterAndDestroySludge_Injected(ref Entity entity) {} // 0x0000000189DF7974-0x0000000189DF79A8
		private static uint CreateRendererList_Injected(Camera camera, ref Vector2Int sceneRTSize, uint viewHandle, uint lightModeMask, uint decalLightModeMask, float loadFactor, IntPtr context, bool useMetric) => default; // 0x0000000189DF766C-0x0000000189DF76D0
		private static void HitSludge_Injected(ref Entity entity, ref Vector3 worldPos, float range, float deltaHeightNormalized = 1f /* Metadata: 0x01FD9E74 */) {} // 0x0000000189DF78C0-0x0000000189DF7924
		private static void GetHeightmapInfo_Injected(ref Entity entity, out SludgeHeightmapInfo ret) {
			ret = default;
		} // 0x000000018304C720-0x000000018304C770
	}

	public enum SplineEmissionType // TypeDefIndex: 57483
	{
		Box = 0,
		Mesh = 1
	}

	public enum SplineEmissionMeshType // TypeDefIndex: 57484
	{
		Triangle = 0,
		Vertex = 1,
		Edge = 2
	}

	[Serializable]
	[UsedByNativeCode]
	public struct SplineObjectsDesc // TypeDefIndex: 57485
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
	public struct SplineObjectsKnotData // TypeDefIndex: 57486
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
	public static class HGSplineMovingObjectsManager // TypeDefIndex: 57487
	{
		// Methods
		public static uint CreateInstance(SplineObjectsDesc desc, NativeArray<SplineObjectsKnotData> curveData) => default; // 0x0000000189DF7C8C-0x0000000189DF7D5C
		[NativeName("AddInstanceToDestroyQueue")]
		public static bool DestroyInstance(uint instanceID) => default; // 0x0000000189DF7D70-0x0000000189DF7DA4
		public static bool UpdateObjectToWorld(uint instanceID, Matrix4x4 objectToWorld) => default; // 0x0000000189DF7E18-0x0000000189DF7E2C
		public static bool Pause(uint instanceID) => default; // 0x0000000189DF7DA4-0x0000000189DF7DD8
		private static unsafe uint CreateInstance(SplineObjectsDesc desc, SplineObjectsKnotData* curveData, int length) => default; // 0x0000000189DF7D5C-0x0000000189DF7D70
		private static bool UpdateObjectToWorld_Injected(uint instanceID, ref Matrix4x4 objectToWorld) => default; // 0x0000000189DF7DD8-0x0000000189DF7E18
		private static unsafe uint CreateInstance_Injected(ref SplineObjectsDesc desc, SplineObjectsKnotData* curveData, int length) => default; // 0x0000000189DF7C38-0x0000000189DF7C8C
	}

	[NativeType("Modules/HGGraphics/Public/Subsurface/HGSubsurfaceProfileManager.h")]
	public static class HGSubsurfaceProfileManager // TypeDefIndex: 57488
	{
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetSubsurfaceProfileManager()", StaticAccessorType.Dot)]
		public static void RegisterFromTerrain(HGSubsurfaceProfile profile) {} // 0x0000000182C510C0-0x0000000182C511B0
		[StaticAccessor("GetHGGlobalGameManager().GetSubsurfaceProfileManager()", StaticAccessorType.Dot)]
		public static void UnregisterFromTerrain() {} // 0x0000000189DF8004-0x0000000189DF8030
	}

	[UsedByNativeCode]
	public struct TerrainNodePayload // TypeDefIndex: 57489
	{
		// Fields
		public Texture2D heightmapPage; // 0x00
		public Texture2D normalmapPage; // 0x08
		public Texture2D tintColorPage; // 0x10
		public Texture2D splatCtrlPage; // 0x18
		public Texture2D albedoPage; // 0x20
	}

	[UsedByNativeCode]
	public struct TerrainSplatPayload // TypeDefIndex: 57490
	{
		// Fields
		public Texture2D diffuseTex; // 0x00
		public Texture2D normalROTex; // 0x08
		public Texture2D coneMapTex; // 0x10
	}

	[UsedByNativeCode]
	public struct TerrainInfo // TypeDefIndex: 57491
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

	[UsedByNativeCode]
	public struct TerrainNodeData // TypeDefIndex: 57492
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
	public struct SplatLayerData // TypeDefIndex: 57493
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

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGTerrainManager.h")]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGTerrain.bindings.h")]
	public class HGTerrainManager // TypeDefIndex: 57494
	{
		// Properties
		public static float minVerticalFieldOfView { [StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)] set {} } // 0x0000000183290450-0x00000001832904A0
	
		// Constructors
		public HGTerrainManager() {} // Dummy constructor
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ReadbackVTFeedbackBuffer(int feedbackViewId, CommandBuffer cmd, IntPtr renderContext) {} // 0x0000000189DF8390-0x0000000189DF83E0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static unsafe void* GetTerrainNodesForCanceling(out int length) {
			length = default;
			return default;
		} // 0x0000000182D1FF60-0x0000000182D1FFA0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static unsafe void* GetTerrainNodesForStreaming(out int length) {
			length = default;
			return default;
		} // 0x0000000182D1FFA0-0x0000000182D1FFE0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static ulong GetTerrainSplatsForCanceling() => default; // 0x0000000182D1FEE0-0x0000000182D1FF20
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static ulong GetTerrainSplatsForStreaming() => default; // 0x0000000182D1FF20-0x0000000182D1FF60
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ResetTerrainNodesForCanceling() {} // 0x0000000182D20060-0x0000000182D200A0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ResetTerrainNodesForStreaming() {} // 0x0000000182D200A0-0x0000000182D200E0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ResetTerrainSplatsForCanceling() {} // 0x0000000182D1FFE0-0x0000000182D20020
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ResetTerrainSplatsForStreaming() {} // 0x0000000182D20020-0x0000000182D20060
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static bool StreamingInTerrainNodePayload(uint nodeKey, [IsReadOnly] in TerrainNodePayload payload) => default; // 0x00000001826A10E0-0x00000001826A1130
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void StreamingInTerrainSplat(uint splatIdx, TerrainSplatPayload payload) {} // 0x0000000189DF8668-0x0000000189DF867C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ResetLoadingStatusForAllNodes() {} // 0x0000000182C51DF0-0x0000000182C51E30
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ResetLoadingStatusForAllSplats() {} // 0x0000000182C51DB0-0x0000000182C51DF0
		public static void SetupTerrainManager([IsReadOnly] in TerrainInfo terrainInfo, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, NativeArray<UnityEngine.HyperGryph.SplatLayerData> layerData, Texture2D[] splatDiffuseTextures, Texture2D[] splatNormalTextures, Texture2D[] splatConeMapTextures, int splatTier, NativeArray<UnityEngine.HyperGryph.TerrainNodeData> nodeData, NativeArray<ulong> sectorSplatInfo, bool enableHalfVTSize, bool enableHalfAtlasSize = false /* Metadata: 0x01FD9E7D */, GraphicsFormat mobileSplatCtrlAtlasFormat = GraphicsFormat.RGBA_ASTC4X4_UNorm /* Metadata: 0x01FD9E7E */, bool enableIndirectionCpuUpload = false /* Metadata: 0x01FD9E80 */) {} // 0x0000000182C4FDC0-0x0000000182C4FF20
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		private static void SetupTerrainManager([IsReadOnly] in TerrainInfo terrainInfo, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, int layerCount, IntPtr layerData, Texture2D[] splatDiffuseTextures, Texture2D[] splatNormalTextures, Texture2D[] splatConeMapTextures, int splatTier, int nodeCount, IntPtr nodeData, int sectorCount, IntPtr sectorSplatInfo, bool enableHalfVTSize, bool enableHalfAtlasSize, GraphicsFormat mobileSplatCtrlAtlasFormat, bool enableIndirectionCpuUpload) {} // 0x0000000182C4FF20-0x0000000182C4FFC0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void CleanupTerrainManager() {} // 0x0000000189DF8030-0x0000000189DF805C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrainAndUpdateVTFeedbackView(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, Vector3 vtUpdateCenter) => default; // 0x0000000189DF805C-0x0000000189DF80BC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrain(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext) => default; // 0x0000000189DF8120-0x0000000189DF8154
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void PrepareDecalRendererListsForVTPages(int feedbackViewId, IntPtr renderContext) {} // 0x0000000189DF8350-0x0000000189DF8390
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void ExecuteVTUpdateCommand(int feedbackViewId, IntPtr renderContext) {} // 0x0000000189DF8154-0x0000000189DF8194
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderVTPages(int feedbackViewId, IntPtr renderContext, CommandBuffer copyCmd, CommandBuffer renderCmd, int bakePassIndex, int bc3PassIndex, int astcPassIndex, int bc5PassIndex) {} // 0x0000000189DF8500-0x0000000189DF8560
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderScreenSpaceTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr features) {} // 0x0000000189DF83E0-0x0000000189DF8440
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrainAfterGBuffer(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, IntPtr features) {} // 0x0000000189DF8440-0x0000000189DF84A0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void UpdateSubdivisionParameters(int mode, int modeV2, int subd, int primitivePixelLengthTargetLog2) {} // 0x0000000189DF86DC-0x0000000189DF873C
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SetTerrainBlendBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId) {} // 0x0000000189DF85C4-0x0000000189DF8628
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SetDecalDeformBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId) {} // 0x0000000189DF8560-0x0000000189DF85C4
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetHeightmapAtlas() => default; // 0x0000000189DF81C0-0x0000000189DF81EC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetNormalmapAtlas() => default; // 0x0000000189DF81EC-0x0000000189DF8218
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetTintColorAtlas() => default; // 0x0000000189DF8324-0x0000000189DF8350
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetSplatControlAtlas() => default; // 0x0000000189DF8218-0x0000000189DF8244
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetAlbedoAtlas() => default; // 0x0000000189DF8194-0x0000000189DF81C0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2D GetSplatIndexMap() => default; // 0x0000000189DF82CC-0x0000000189DF82F8
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2DArray GetSplatDiffuseArray() => default; // 0x0000000189DF82A0-0x0000000189DF82CC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static Texture2DArray GetSplatNormalROArray() => default; // 0x0000000189DF82F8-0x0000000189DF8324
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static CBHandle GetSplatDataUBO() => default; // 0x0000000189DF8278-0x0000000189DF82A0
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void SubdivisionTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, bool enableSubdivision, bool enableSubdivisionV2, Texture HZBTexture) {} // 0x0000000189DF867C-0x0000000189DF86DC
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, int tessellationPassIndex = -1 /* Metadata: 0x01FD9E81 */, int subdivisionPassIndex = -1 /* Metadata: 0x01FD9E82 */, bool enableSubdivisionV2 = false /* Metadata: 0x01FD9E83 */) {} // 0x0000000189DF84A0-0x0000000189DF8500
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void StreamingInChunkSurfaceTypeData(uint chunkKey, UIntPtr chunkSurfaceTypeData, int dataLength, int chunkSize) {} // 0x00000001836610E0-0x0000000183661150
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static void StreamingOutChunkSurfaceTypeData(uint chunkKey) {} // 0x0000000183661150-0x0000000183661190
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainManager()", StaticAccessorType.Dot)]
		public static bool GetSurfaceTypeByWorldPosition(float x, float y, out int surfaceType) {
			surfaceType = default;
			return default;
		} // 0x0000000182FA37B0-0x0000000182FA3810
		private static void StreamingInTerrainSplat_Injected(uint splatIdx, ref TerrainSplatPayload payload) {} // 0x0000000189DF8628-0x0000000189DF8668
		private static uint CullTerrainAndUpdateVTFeedbackView_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, ref Vector3 vtUpdateCenter) => default; // 0x000000018306BD20-0x000000018306BDA0
		private static uint CullTerrain_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext) => default; // 0x0000000189DF80BC-0x0000000189DF8120
		private static void GetSplatDataUBO_Injected(out CBHandle ret) {
			ret = default;
		} // 0x0000000189DF8244-0x0000000189DF8278
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGEditorTerrainManager.h")]
	public class HGEditorTerrainManager // TypeDefIndex: 57495
	{
		// Constructors
		public HGEditorTerrainManager() {} // Dummy constructor
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void SetUseNewEditorTerrainRendering(bool value) {} // 0x0000000182D1E190-0x0000000182D1E1D0
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrainAndUpdateVTFeedbackView(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, Vector3 vtUpdateCenter) => default; // 0x0000000189DF5CE0-0x0000000189DF5D40
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static uint CullTerrain(Camera camera, Vector2Int sceneRTSize, Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext) => default; // 0x0000000189DF5DA4-0x0000000189DF5DD8
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void SetTerrainBlendBindings(IntPtr renderContext, CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId) {} // 0x0000000189DF6088-0x0000000189DF60EC
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int subdivisionHandle, int passIndex, int subdivisionPassIndex = -1 /* Metadata: 0x01FD9E84 */, bool enableSubdivisionV2 = false /* Metadata: 0x01FD9E85 */) {} // 0x0000000189DF5FC8-0x0000000189DF6028
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderScreenSpaceTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, int passIndex, IntPtr features) {} // 0x0000000189DF5EA8-0x0000000189DF5F08
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderSeparateTerrain(CommandBuffer cmd, uint terrainCullViewHandle, int passIndex, IntPtr features) {} // 0x0000000189DF5F08-0x0000000189DF5F68
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderTerrainAfterGBuffer(CommandBuffer cmd, uint terrainCullViewHandle, int feedbackViewId, IntPtr features) {} // 0x0000000189DF5F68-0x0000000189DF5FC8
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void BakeAtlasTexture(CommandBuffer cmd, IntPtr renderContext) {} // 0x0000000189DF5C9C-0x0000000189DF5CE0
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void PrepareDecalRendererListsForVTPages(int feedbackViewId, IntPtr renderContext) {} // 0x0000000189DF5E18-0x0000000189DF5E58
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void ExecuteVTUpdateCommand(int feedbackViewId, IntPtr renderContext) {} // 0x0000000189DF5DD8-0x0000000189DF5E18
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void RenderVTPages(int feedbackViewId, IntPtr renderContext, CommandBuffer copyCmd, CommandBuffer renderCmd, int bakePass, int bc3Pass, int astcPass) {} // 0x0000000189DF6028-0x0000000189DF6088
		[StaticAccessor("GetHGGlobalGameManager().GetEditorTerrainManager()", StaticAccessorType.Dot)]
		public static void ReadbackVTFeedbackBuffer(int feedbackViewId, CommandBuffer cmd, IntPtr renderContext) {} // 0x0000000189DF5E58-0x0000000189DF5EA8
		private static uint CullTerrainAndUpdateVTFeedbackView_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext, uint viewHandle, int feedbackViewId, ref Vector3 vtUpdateCenter) => default; // 0x000000018306BDA0-0x000000018306BE20
		private static uint CullTerrain_Injected(Camera camera, ref Vector2Int sceneRTSize, ref Matrix4x4 viewProj, float lodFactor, bool useMetric, IntPtr renderContext) => default; // 0x0000000189DF5D40-0x0000000189DF5DA4
	}

	[UsedByNativeCode]
	public struct HGTerrainDeformConfigV2 // TypeDefIndex: 57496
	{
		// Fields
		public float m_deformGlobalStrength; // 0x00
		public float m_latency; // 0x04
	}

	[NativeHeader("Modules/HGGraphics/Public/Terrain/HGTerrainDeformManager.h")]
	public class HGTerrainDeformManagerV2 // TypeDefIndex: 57497
	{
		// Constructors
		public HGTerrainDeformManagerV2() {} // Dummy constructor
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainDeformManager()", StaticAccessorType.Dot)]
		public static void SetPlayerCenter(Vector3 position) {} // 0x0000000184272784-0x0000000184272794
		[StaticAccessor("GetHGGlobalGameManager().GetTerrainDeformManager()", StaticAccessorType.Dot)]
		public static void UpdateDeformConfig(HGTerrainDeformConfigV2 config) {} // 0x0000000184274A7C-0x0000000184274A98
		private static void SetPlayerCenter_Injected(ref Vector3 position) {} // 0x00000001833D7B50-0x00000001833D7B90
		private static void UpdateDeformConfig_Injected(ref HGTerrainDeformConfigV2 config) {} // 0x0000000183040220-0x0000000183040260
	}

	[NativeHeader("Modules/HGGraphics/Public/ECS/HGUIRender.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetUIRender()", StaticAccessorType.Dot)]
	public static class HGUIRender // TypeDefIndex: 57498
	{
		// Methods
		public static uint CreateRendererList(uint cullingLayerMask, HGRenderFlags renderFlagsMask, HGRenderFlags renderFlagsValue, HGShaderLightMode lightModeMask, short sortingOrderMin, short sortingOrderMax, int cameraInstanceID, IntPtr context, bool isWorldUI, float wolrdUICullingDistance = 3.4028235E+38f /* Metadata: 0x01FD9E86 */) => default; // 0x0000000189DF89B8-0x0000000189DF89E8
		private static uint CreateRendererList(uint cullingLayerMask, uint renderFlagsMask, uint renderFlagsValue, uint lightModeMask, short sortingOrderMin, short sortingOrderMax, int cameraInstanceID, IntPtr context, bool isWorldUI, float wolrdUICullingDistance) => default; // 0x0000000189DF89E8-0x0000000189DF8A6C
	}

	[NativeType("Modules/HGGraphics/Public/ECS/HGWaterRender.h")]
	public static class HGWaterRender // TypeDefIndex: 57502
	{
		// Nested types
		public enum HGWaterHeightLayer // TypeDefIndex: 57499
		{
			HeightLayer0 = 0,
			HeightLayer1 = 1,
			HeightLayer2 = 2,
			HeightLayer3 = 3
		}
	
		public enum HGWaterRenderType // TypeDefIndex: 57500
		{
			Proxy = 1,
			LOD = 2
		}
	
		public enum HGWaterDecalRenderType // TypeDefIndex: 57501
		{
			None = 0,
			Regular = 1,
			Emissive = 2
		}
	
		// Methods
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void CullWaterProxy(uint viewHandle, Matrix4x4 viewProj, uint cullingMask, bool useOC, out uint visibleCount, out uint cullHandle, bool orderByDistance = false /* Metadata: 0x01FD9E8A */, Vector3 viewPosition = default) {
			visibleCount = default;
			cullHandle = default;
		} // 0x000000018427455C-0x00000001842745A8
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void CullWaterDecals(uint viewHandle, Matrix4x4 viewProj, out uint visibleCount, out uint cullHandle, bool useAnchorSH = false /* Metadata: 0x01FD9E8B */) {
			visibleCount = default;
			cullHandle = default;
		} // 0x000000018427453C-0x000000018427455C
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool IsHeightLayerVisible(uint cullHandle, uint renderTypeMask, int lodLayer) => default; // 0x0000000189DF8B34-0x0000000189DF8B84
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void DrawWaterProxy(IntPtr renderContext, CommandBuffer cmd, uint cullHandle, Material material, MaterialPropertyBlock properties, int shaderPass, int nameID, bool clear = true /* Metadata: 0x01FD9E8C */, uint renderTypeMask = 3 /* Metadata: 0x01FD9E8D */, int lodLayer = -1 /* Metadata: 0x01FD9E8E */) {} // 0x0000000189DF8AD0-0x0000000189DF8B34
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void DrawWaterDecals(IntPtr renderContext, CommandBuffer cmd, uint cullHandle, MaterialPropertyBlock properties, int nameID, bool clear = true /* Metadata: 0x01FD9E8F */, int shaderPass = 0 /* Metadata: 0x01FD9E90 */, uint renderTypeMask = 1 /* Metadata: 0x01FD9E91 */, int heightLayer = -1 /* Metadata: 0x01FD9E92 */) {} // 0x0000000189DF8A6C-0x0000000189DF8AD0
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool IsHGWaterGloablConfigValidCPP() => default; // 0x00000001832BABF0-0x00000001832BAC30
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static bool CheckNewHGWaterGloablConfigCPP(string scenePath) => default; // 0x0000000182564D20-0x0000000182564D60
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void UpdateHGWaterGloablConfigCPP(string scenePath, int sectorNum, int sectorSize, int sectorCoordsMin, int sectorCoordsMax, long[] sectorDataGUIDs, bool[] sectorDataExists) {} // 0x0000000183CF9220-0x0000000183CF9290
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void AddSectorTexture(int id, int textureID) {} // 0x00000001836893A0-0x00000001836893F0
		[StaticAccessor("GetHGGlobalGameManager().GetWaterRender()", StaticAccessorType.Dot)]
		public static void RemoveSectorTexture(int id) {} // 0x0000000189DF8B84-0x0000000189DF8BB8
		private static void CullWaterProxy_Injected(uint viewHandle, ref Matrix4x4 viewProj, uint cullingMask, bool useOC, out uint visibleCount, out uint cullHandle, bool orderByDistance = false /* Metadata: 0x01FD9E93 */, ref Vector3 viewPosition = null) {
			visibleCount = default;
			cullHandle = default;
		} // 0x0000000182EC5340-0x0000000182EC53C0
		private static void CullWaterDecals_Injected(uint viewHandle, ref Matrix4x4 viewProj, out uint visibleCount, out uint cullHandle, bool useAnchorSH = false /* Metadata: 0x01FD9E94 */) {
			visibleCount = default;
			cullHandle = default;
		} // 0x0000000182EC52C0-0x0000000182EC5340
	}
}

namespace UnityEngine.HyperGryph.ECS
{
	public enum ECSExplicitEntityType : uint // TypeDefIndex: 57535
	{
		Unknown = 0,
		MeshRenderer = 1,
		ReflectionProbe = 2,
		WaterRenderer = 3,
		FactoryRenderer = 4,
		HGDecalProjector = 5
	}

	[UsedByNativeCode]
	public struct EntityInstanceData // TypeDefIndex: 57536
	{
		// Fields
		public uint entityType; // 0x00
		public int entityIdx; // 0x04
		public uint version; // 0x08
		public uint padding; // 0x0C
	}

	[UsedByNativeCode]
	public struct ComponentType // TypeDefIndex: 57537
	{
		// Fields
		public ulong value; // 0x00
		public short componentID; // 0x00
		public short componentSize; // 0x02
		public int offset; // 0x04
	}

	public struct ComponentMask // TypeDefIndex: 57539
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ ulong componentMaskWords[0]; // 0x00
	
		// Constructors
		public unsafe ComponentMask(int id) {
			componentMaskWords = default;
		} // 0x0000000183D87AD0-0x0000000183D87AF0
	
		// Methods
		[IsReadOnly]
		public bool ContainsComponentId(int id) => default; // 0x00000001823F4970-0x00000001823F4990
		[IsReadOnly]
		public bool ContainsComponentMask([IsReadOnly] in ComponentMask other) => default; // 0x0000000182433900-0x0000000182433920
		[IsReadOnly]
		public bool ExcludesComponentMask([IsReadOnly] in ComponentMask other) => default; // 0x0000000182433920-0x0000000182433940
		public override bool Equals(object obj) => default; // 0x0000000189DF4A38-0x0000000189DF4AB4
		public override int GetHashCode() => default; // 0x0000000183D87A80-0x0000000183D87AB0
		public void And(ref ComponentMask other) {} // 0x0000000183D87A70-0x0000000183D87A80
		public void Or(int id) {} // 0x0000000183D87AB0-0x0000000183D87AD0
	}

	[UsedByNativeCode]
	public struct EntityTypeInstanceData // TypeDefIndex: 57541
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
	}

	[UsedByNativeCode]
	public struct Entity : IEquatable<Entity> // TypeDefIndex: 57542
	{
		// Fields
		public uint globalIndex; // 0x00
		public uint version; // 0x04
	
		// Properties
		public ulong id { get => default; set {} } // 0x0000000183D87BB0-0x0000000183D87BC0 0x0000000183D824F0-0x0000000183D82500
		public static Entity invaildEntity { get; } // 0x0000000189DF5098-0x0000000189DF50E8 
	
		// Constructors
		static Entity() {
	
		} // 0x0000000183D27320-0x0000000183D27370
	
		// Methods
		public bool Equals(Entity rhs) => default; // 0x00000001822AAB30-0x00000001822AAB50
		public override int GetHashCode() => default; // 0x0000000183D85860-0x0000000183D85870
		public override string ToString() => default; // 0x0000000189DF5010-0x0000000189DF5098
		public bool Valid() => default; // 0x00000001824FE430-0x00000001824FE450
		public static bool operator ==(Entity left, Entity right) => default; // 0x00000001827D27D0-0x00000001827D2950
		public static bool operator !=(Entity left, Entity right) => default; // 0x00000001827D2760-0x00000001827D27D0
		public override bool Equals(object obj) => default; // 0x0000000189DF4F94-0x0000000189DF5010
	}

	[UsedByNativeCode]
	public struct EntityType // TypeDefIndex: 57543
	{
		// Fields
		public uint id; // 0x00
	}

	public interface IComponentECS // TypeDefIndex: 57544
	{
		// Properties
		int id { get; }
	}

	public struct BoundingCenterXComponent : IComponentECS // TypeDefIndex: 57545
	{
		// Fields
		public float x; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000181002730-0x0000000181002740 
	}

	public struct BoundingCenterYComponent : IComponentECS // TypeDefIndex: 57546
	{
		// Fields
		public float y; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000181168950-0x0000000181168960 
	}

	public struct BoundingCenterZComponent : IComponentECS // TypeDefIndex: 57547
	{
		// Fields
		public float z; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	}

	public struct BoundingExtentXComponent : IComponentECS // TypeDefIndex: 57548
	{
		// Fields
		public float x; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	}

	public struct BoundingExtentYComponent : IComponentECS // TypeDefIndex: 57549
	{
		// Fields
		public float y; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	}

	public struct BoundingExtentZComponent : IComponentECS // TypeDefIndex: 57550
	{
		// Fields
		public float z; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000183D51100-0x0000000183D51110 
	}

	public struct RenderObjectLODInfoComponent : IComponentECS // TypeDefIndex: 57551
	{
		// Fields
		public Vector3 lodCenter; // 0x00
		public float lodObjectHalfSizeSquared; // 0x0C
		public bool enableDither; // 0x10
		public byte lodCullingOptions; // 0x11
		public byte padding0; // 0x12
		public byte padding1; // 0x13
	
		// Properties
		public int id { get => default; } // 0x0000000183D51110-0x0000000183D51120 
	}

	public struct RenderObjectInfoComponent : IComponentECS // TypeDefIndex: 57552
	{
		// Fields
		public uint roLayerMask; // 0x00
		public uint objectFlags; // 0x04
		public ulong sceneMask; // 0x08
		public uint artTag; // 0x10
		public float sortingFudgeSqr; // 0x14
	
		// Properties
		public int id { get => default; } // 0x0000000183D55AA0-0x0000000183D55AB0 
	}

	public struct RendererInfo // TypeDefIndex: 57553
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

	public struct LODInfo // TypeDefIndex: 57554
	{
		// Fields
		public float lodScreenSizeMaxSquared; // 0x00
		public float lodScreenSizeMinSquared; // 0x04
	}

	public interface IRenderObjectKComponent : IComponentECS // TypeDefIndex: 57555
	{
		// Methods
		byte* GetRenderersPtr();
	}

	public struct RenderObjectK1Component : IRenderObjectKComponent // TypeDefIndex: 57558
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x1C
	
		// Properties
		public int id { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000183D87B70-0x0000000183D87B80
	}

	public struct RenderObjectK2Component : IRenderObjectKComponent // TypeDefIndex: 57561
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x34
	
		// Properties
		public int id { get => default; } // 0x0000000183D55810-0x0000000183D55820 
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000183D87B70-0x0000000183D87B80
	}

	public struct RenderObjectK4Component : IRenderObjectKComponent // TypeDefIndex: 57564
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x64
	
		// Properties
		public int id { get => default; } // 0x0000000183D55730-0x0000000183D55740 
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000183D87B70-0x0000000183D87B80
	}

	public struct RenderObjectK8Component : IRenderObjectKComponent // TypeDefIndex: 57567
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0xC4
	
		// Properties
		public int id { get => default; } // 0x0000000183D557B0-0x0000000183D557C0 
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000183D87B70-0x0000000183D87B80
	}

	public struct RenderObjectK16Component : IRenderObjectKComponent // TypeDefIndex: 57570
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte renderers[0]; // 0x04
		public unsafe fixed /* 0x00000000-0x00000000 */ byte lodInfos[0]; // 0x184
	
		// Properties
		public int id { get => default; } // 0x0000000183D557A0-0x0000000183D557B0 
	
		// Methods
		public unsafe byte* GetRenderersPtr() => default; // 0x0000000183D87B70-0x0000000183D87B80
	}

	[UsedByNativeCode]
	public struct PerDrawBaseData // TypeDefIndex: 57571
	{
		// Fields
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 lodFade; // 0x40
		public Vector4 worldTransformParams; // 0x50
		public Matrix4x4 matrixPreviousM; // 0x60
		public Vector4 motionVectorsParams; // 0xA0
	}

	public struct CommonInstanceDataComponent : IComponentECS // TypeDefIndex: 57573
	{
		// Fields
		public PerDrawBaseData baseData; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float customData[0]; // 0xB0
	
		// Properties
		public int id { get => default; } // 0x0000000183D56100-0x0000000183D56110 
	}

	public struct FactoryInstanceDataComponent : IComponentECS // TypeDefIndex: 57575
	{
		// Fields
		public PerDrawBaseData baseData; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ float customData[0]; // 0xB0
	
		// Properties
		public int id { get => default; } // 0x0000000183D56100-0x0000000183D56110 
	}

	public struct ECSFixedString64 // TypeDefIndex: 57577
	{
		// Fields
		public unsafe fixed /* 0x00000000-0x00000000 */ byte data[0]; // 0x00
	
		// Methods
		public string GetData() => default; // 0x0000000189DF4AB4-0x0000000189DF4B50
		public override string ToString() => default; // 0x0000000189DF4B50-0x0000000189DF4B58
	}

	public struct DebugContentsComponent : IComponentECS // TypeDefIndex: 57578
	{
		// Fields
		public ECSFixedString64 entityName; // 0x00
		public ECSExplicitEntityType entityType; // 0x40
		public ECSFixedString64 debugStr; // 0x44
	
		// Properties
		public int id { get => default; } // 0x0000000183D55750-0x0000000183D55760 
	}

	public struct HGFactoryRendererBinderComponent : IComponentECS // TypeDefIndex: 57579
	{
		// Fields
		public Entity rendererEntity; // 0x00
		public uint sharedDataIndex; // 0x08
		public byte rendererType; // 0x0C
		public byte padding0; // 0x0D
		public byte padding1; // 0x0E
		public byte padding2; // 0x0F
	
		// Properties
		public int id { get => default; } // 0x0000000183D51E30-0x0000000183D51E40 
	
		// Methods
		public void SetDirtyFlag(HGFactoryDirtyFlags flag) {} // 0x0000000182420410-0x00000001824204A0
		public void SetAdditiveMaterialBit(int bitIndex, bool enable) {} // 0x0000000182421CD0-0x0000000182421DD0
		public void SetPosition(Vector3 position) {} // 0x000000018294D130-0x000000018294D3C0
		public void SetUniformScale(float uniformScale) {} // 0x0000000189DF6180-0x0000000189DF61DC
		public void SetRotation(Quaternion rotation) {} // 0x000000018294D0A0-0x000000018294D130
		public void SetTransform(HGFactoryEntityTransformData transform) {} // 0x00000001824210B0-0x0000000182421150
		public void SetCustomPerDrawData<T>(T data, int offset)
			where T : struct {}
		public void SetEnabled(bool enabled) {} // 0x0000000182420CD0-0x0000000182420DC0
		public void SetAdditiveEntitiesVisibility(bool visible) {} // 0x0000000182421B20-0x0000000182421BE0
	}

	public struct HGWaterComponent : IComponentECS // TypeDefIndex: 57580
	{
		// Fields
		public uint renderTypeMask; // 0x00
		public int meshID; // 0x04
		public Matrix4x4 objectToWorld; // 0x08
		public Vector4 param0; // 0x48
		public Vector4 param1; // 0x58
	
		// Properties
		public int id { get => default; } // 0x0000000183D55770-0x0000000183D55780 
	}

	public struct HGWaterDecalComponent : IComponentECS // TypeDefIndex: 57581
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
		public int id { get => default; } // 0x0000000183D55C10-0x0000000183D55C20 
	}

	public struct GrassRendererInfo // TypeDefIndex: 57582
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
	public struct GrassPerInstanceData // TypeDefIndex: 57583
	{
		// Fields
		public const int SIZE = 96; // Metadata: 0x01FDA03B
		public Matrix4x4 objectToWorld; // 0x00
		public Vector4 param0; // 0x40
		public Vector4 param1; // 0x50
	}

	public struct GrassClusterK4Component : IComponentECS // TypeDefIndex: 57585
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get => default; } // 0x0000000183D55BF0-0x0000000183D55C00 
	}

	public struct GrassClusterK8Component : IComponentECS // TypeDefIndex: 57587
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get => default; } // 0x0000000183D55B90-0x0000000183D55BA0 
	}

	public struct GrassClusterK16Component : IComponentECS // TypeDefIndex: 57589
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get => default; } // 0x0000000183D55C40-0x0000000183D55C50 
	}

	public struct GrassClusterK32Component : IComponentECS // TypeDefIndex: 57591
	{
		// Fields
		public int count; // 0x00
		public unsafe fixed /* 0x00000000-0x00000000 */ byte perInstanceData[0]; // 0x04
	
		// Properties
		public int id { get => default; } // 0x0000000183D55740-0x0000000183D55750 
	}

	public struct ECSColliderComponent : IComponentECS // TypeDefIndex: 57592
	{
		// Fields
		public IntPtr actor; // 0x00
		public int ecsId; // 0x08
		public uint ecsVersion; // 0x0C
	
		// Properties
		public int id { get => default; } // 0x0000000183D59180-0x0000000183D59190 
	}

	public struct HGSludgeComponent : IComponentECS // TypeDefIndex: 57593
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
		public int id { get => default; } // 0x0000000183D56190-0x0000000183D561A0 
	}

	public struct ECSClothDataComponent : IComponentECS // TypeDefIndex: 57594
	{
		// Fields
		public uint clothHash; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000183D55AF0-0x0000000183D55B00 
	}

	public struct HGECSRegionComponent : IComponentECS // TypeDefIndex: 57595
	{
		// Fields
		public bool isEnable; // 0x00
		public Vector3 center; // 0x04
		public Vector3 size; // 0x10
		public Quaternion rotation; // 0x1C
	
		// Properties
		public int id { get => default; } // 0x0000000183D560B0-0x0000000183D560C0 
	}

	public struct HGCullingParameterComponent : IComponentECS // TypeDefIndex: 57596
	{
		// Fields
		public bool enableShadowCulling; // 0x00
	
		// Properties
		public int id { get => default; } // 0x0000000183D560A0-0x0000000183D560B0 
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/ScriptBindings/HGEntityManager.bindings.h")]
	public struct EntityManager // TypeDefIndex: 57597
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		public readonly IntPtr m_entitiesPPtr; // 0x00
		[NativeDisableUnsafePtrRestriction]
		public readonly IntPtr m_entityTypesPPtr; // 0x08
	
		// Methods
		public static int GetNFromKNComponentMask(ulong componentMask) => default; // 0x0000000183D87BA0-0x0000000183D87BB0
		public static unsafe int GetCountFromKNComponent(byte* component) => default; // 0x0000000183D85860-0x0000000183D85870
		public static unsafe void SetCountForKNComponent(byte* component, int count) {} // 0x0000000183D4E970-0x0000000183D4E980
		public static unsafe GrassRendererInfo* GetGrassRendererInfosFromKNComponent(byte* component) => default; // 0x0000000183D87B70-0x0000000183D87B80
		public static unsafe LODInfo* GetLODInfosFromKNComponent(byte* component, int n) => default; // 0x0000000183D87B80-0x0000000183D87BA0
		public static unsafe int GetCountFromKNGrassCluster(byte* component) => default; // 0x0000000183D85860-0x0000000183D85870
		public static unsafe void SetCountForKNGrassCluster(byte* component, int count) {} // 0x0000000183D4E970-0x0000000183D4E980
		public static unsafe GrassPerInstanceData* GetPerInstanceDataFromKNGrassCluster(byte* component) => default; // 0x0000000183D87B70-0x0000000183D87B80
		public static EntityManager GetEntityManager() => default; // 0x00000001823F6FD0-0x00000001823F7020
		public static EntityManager GetGameplayEntityManager() => default; // 0x0000000182501030-0x0000000182501080
		public static EntityManager GetRendererEntityManager() => default; // 0x00000001826E5150-0x00000001826E51A0
		public bool HasEntity(Entity entity) => default; // 0x00000001824FE450-0x00000001824FE4E0
		public Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityType entityType) => default; // 0x000000018241C980-0x000000018241C9E0
		public void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, IntPtr entities, int count) {} // 0x0000000184272F04-0x0000000184272F24
		public void CreateEntities(UnityEngine.HyperGryph.ECS.EntityType entityType, NativeArray<Entity> entities) {} // 0x0000000182C5EA00-0x0000000182C5EA60
		public void DestroyEntity(Entity entity) {} // 0x0000000184276334-0x0000000184276350
		public void DestroyEntities(NativeArray<Entity> entities) {} // 0x0000000182BC2930-0x0000000182BC29B0
		public void DestroyEntities(IntPtr entities, int entityCount) {} // 0x0000000184272C68-0x0000000184272C70
		public static ComponentType GetComponentType<T>()
			where T : struct, IComponentECS => default;
		public void AddComponent<T>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS {}
		public void RemoveComponent<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS {}
		public void RemoveComponentsWithMask([IsReadOnly] in Entity entity, ref ComponentMask needRemoveComponentMask) {} // 0x00000001823F5130-0x00000001823F52E0
		public UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityType(NativeArray<ComponentType> componentTypes) => default; // 0x000000018241CA40-0x000000018241CAD0
		public UnityEngine.HyperGryph.ECS.EntityType GetOrRegisterEntityTypeImpl(int componentTypeCount, IntPtr componentTypes) => default; // 0x000000018241CAD0-0x000000018241CB40
		public void AddMoveEntityAndEntityTypeDataImpl([IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType) {} // 0x000000018426FD70-0x000000018426FD78
		public void RemoveMoveEntityAndEntityTypeDataImpl([IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType) {} // 0x0000000189DF4DC4-0x0000000189DF4DCC
		public static ulong NumberOfSetBits(ulong i) => default; // 0x0000000183D79190-0x0000000183D791F0
		public static ulong NumberOfSetBits(ref ComponentMask mask) => default; // 0x00000001823F4880-0x00000001823F48C0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1) => default; // 0x00000001826E5380-0x00000001826E53E0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2) => default; // 0x00000001830209A0-0x0000000183020AF0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3) => default; // 0x0000000183017A20-0x0000000183017AC0
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3, int id4) => default; // 0x0000000182EE6BD0-0x0000000182EE6C90
		public ComponentMask ComposeComponentMaskAll(int id0, int id1, int id2, int id3, int id4, int id5) => default; // 0x0000000182EE1470-0x0000000182EE1550
		public bool HasComponent<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS => default;
		public void SetComponents<T0, T1>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T0 t0, [IsReadOnly] in ref T1 t1)
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS {}
		public static ComponentMask GetCountingMask(int id) => default; // 0x00000001823F48C0-0x00000001823F4910
		public static void SetComponentImplWithRef<T>(ref EntityInstanceData entityData, ref EntityTypeInstanceData entityTypeData, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS {}
		public void SetComponent<T>([IsReadOnly] in Entity entity, [IsReadOnly] in ref T t)
			where T : struct, IComponentECS {}
		private static unsafe byte* GetComponentPtrImpl(int entityIdx, ref EntityTypeInstanceData entityTypeData, int componentId, int componentSize) => default; // 0x0000000189DF4C48-0x0000000189DF4CDC
		public bool TryGetWorldAABBFromRendererEntity([IsReadOnly] in Entity entity, out Bounds aabb) {
			aabb = default;
			return default;
		} // 0x0000000189DF4DCC-0x0000000189DF4F94
		public ulong GetComponentMaskLow([IsReadOnly] in Entity entity) => default; // 0x0000000183D87B40-0x0000000183D87B70
		public ComponentMask GetComponentMaskAll([IsReadOnly] in Entity entity) => default; // 0x0000000183D87B10-0x0000000183D87B40
		public unsafe byte* GetComponentPtrLowBits([IsReadOnly] in Entity entity, ulong componentMask) => default; // 0x0000000189DF4CDC-0x0000000189DF4DC4
		public T GetComponent<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS => default;
		public bool TryGetComponent<T>([IsReadOnly] in Entity entity, out ref T component)
			where T : struct, IComponentECS {
			component = default;
			return default;
		}
		public ref ref T GetComponentRef<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS => ref _refReturnTypeForGetComponentRef;
		private ref T _refReturnTypeForGetComponentRef; // Dummy field
		public unsafe T* GetComponentPtr<T>([IsReadOnly] in Entity entity)
			where T : struct, IComponentECS => default;
		public unsafe bool TryGetComponentPtr<T>([IsReadOnly] in Entity entity, out ref T* componentPtr)
			where T : struct, IComponentECS {
			componentPtr = default;
			return default;
		}
		public EntityManagerRange Iterate(ref ComponentMask includeComponentMask, ref ComponentMask excludeComponentMask) => default; // 0x0000000182434D60-0x0000000182434ED0
		public EntityManagerRange Iterate(ref ComponentMask componentMask) => default; // 0x0000000182431A60-0x0000000182431B20
		public EntityManagerRange Iterate<T>()
			where T : struct, IComponentECS => default;
		public EntityManagerRange Iterate<T0, T1>()
			where T0 : struct, IComponentECS
			where T1 : struct, IComponentECS => default;
		[NativeMethod(IsThreadSafe = true)]
		public int GetEntityTypeCount() => default; // 0x000000018426FE38-0x000000018426FE40
		[NativeMethod(IsThreadSafe = true)]
		public uint GetEntityContainerSize() => default; // 0x0000000184270334-0x000000018427033C
		public void GarbageCollect() {} // 0x0000000184274B00-0x0000000184274B08
		private static void GetEntityManager_Injected(out EntityManager ret) {
			ret = default;
		} // 0x00000001823F7020-0x00000001823F7060
		private static void GetGameplayEntityManager_Injected(out EntityManager ret) {
			ret = default;
		} // 0x0000000182501080-0x00000001825010C0
		private static void GetRendererEntityManager_Injected(out EntityManager ret) {
			ret = default;
		} // 0x00000001826E51A0-0x00000001826E51E0
		private static void CreateEntity_Injected(ref EntityManager _unity_self, ref UnityEngine.HyperGryph.ECS.EntityType entityType, out Entity ret) {
			ret = default;
		} // 0x000000018241C9E0-0x000000018241CA40
		private static void CreateEntities_Injected(ref EntityManager _unity_self, ref UnityEngine.HyperGryph.ECS.EntityType entityType, IntPtr entities, int count) {} // 0x00000001836E10E0-0x00000001836E1150
		private static void DestroyEntity_Injected(ref EntityManager _unity_self, ref Entity entity) {} // 0x000000018329DC70-0x000000018329DCC0
		private static void DestroyEntities_Injected(ref EntityManager _unity_self, IntPtr entities, int entityCount) {} // 0x0000000182BC0D80-0x0000000182BC0DE0
		private static void GetOrRegisterEntityTypeImpl_Injected(ref EntityManager _unity_self, int componentTypeCount, IntPtr componentTypes, out UnityEngine.HyperGryph.ECS.EntityType ret) {
			ret = default;
		} // 0x000000018241CB40-0x000000018241CBB0
		private static void AddMoveEntityAndEntityTypeDataImpl_Injected(ref EntityManager _unity_self, [IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType) {} // 0x0000000182E2BFB0-0x0000000182E2C010
		private static void RemoveMoveEntityAndEntityTypeDataImpl_Injected(ref EntityManager _unity_self, [IsReadOnly] in Entity entity, [IsReadOnly] in UnityEngine.HyperGryph.ECS.EntityType newEntityType) {} // 0x00000001835B6A60-0x00000001835B6AC0
		private static int GetEntityTypeCount_Injected(ref EntityManager _unity_self) => default; // 0x0000000182DF8590-0x0000000182DF85D0
		private static uint GetEntityContainerSize_Injected(ref EntityManager _unity_self) => default; // 0x0000000182AD3B00-0x0000000182AD3B40
		private static void GarbageCollect_Injected(ref EntityManager _unity_self) {} // 0x000000018304C9E0-0x000000018304CA20
	}

	[IsReadOnly]
	public struct GroupType // TypeDefIndex: 57598
	{
		// Fields
		private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
	
		// Constructors
		internal unsafe GroupType(EntityTypeInstanceData* types) {
			m_entityTypes = default;
		} // 0x0000000183D51730-0x0000000183D51740
	
		// Methods
		public int Size() => default; // 0x000000018426FE68-0x000000018426FE84
		public bool HasComponent<T>()
			where T : struct, IComponentECS => default;
		public unsafe T* GetComponent<T>()
			where T : struct, IComponentECS => default;
		public unsafe byte* GetComponentPtr(int componentId) => default; // 0x0000000189DF5778-0x0000000189DF58CC
		public NativeArray<T> GetComponentAsArray<T>()
			where T : struct, IComponentECS => default;
		public unsafe Entity* GetEntities() => default; // 0x000000018426FE40-0x000000018426FE60
		public ComponentMask GetComponentMaskAll() => default; // 0x0000000183629AF0-0x0000000183629B20
		public NativeArray<Entity> GetEntitiesAsArray() => default; // 0x0000000182EDAE60-0x0000000182EDAEE0
	}

	[IsReadOnly]
	public struct EntityManagerRange : IEnumerable<GroupType> // TypeDefIndex: 57600
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
		private readonly ComponentMask m_componentMask; // 0x08
		private readonly ComponentMask m_excludeComponentMask; // 0x18
		private readonly int m_count; // 0x28
	
		// Nested types
		[ExcludeFromDocs]
		public struct Enumerator : IEnumerator<GroupType> // TypeDefIndex: 57599
		{
			// Fields
			private readonly unsafe EntityTypeInstanceData* m_entityTypes; // 0x00
			private readonly int m_count; // 0x08
			private ComponentMask m_includeComponentMask; // 0x10
			private ComponentMask m_excludedComponentMask; // 0x20
			private int m_index; // 0x30
	
			// Properties
			public GroupType Current { get => default; } // 0x0000000183D87BF0-0x0000000183D87C00 
			object IEnumerator.Current { get => default; } // 0x0000000189DF50E8-0x0000000189DF5138 
	
			// Constructors
			internal unsafe Enumerator(EntityTypeInstanceData* entityTypes, int count, [IsReadOnly] in ComponentMask includeComponentMask, [IsReadOnly] in ComponentMask excludeComponentMask) : this() {
				m_entityTypes = default;
				m_count = default;
				m_includeComponentMask = default;
				m_excludedComponentMask = default;
				m_index = default;
			} // 0x0000000183D87BC0-0x0000000183D87BF0
	
			// Methods
			public void Dispose() {} // 0x000000018350B670-0x000000018350B680
			public bool MoveNext() => default; // 0x0000000182433890-0x0000000182433900
			public void Reset() {} // 0x0000000183D5C430-0x0000000183D5C440
		}
	
		// Constructors
		internal unsafe EntityManagerRange(EntityTypeInstanceData* entityTypes, int count, ref ComponentMask componentMask) {
			m_entityTypes = default;
			m_componentMask = default;
			m_excludeComponentMask = default;
			m_count = default;
		} // 0x0000000183D87AF0-0x0000000183D87B10
		internal unsafe EntityManagerRange(EntityTypeInstanceData* entityTypes, int count, ref ComponentMask includeComponentMask, ref ComponentMask excludeComponentMask) {
			m_entityTypes = default;
			m_componentMask = default;
			m_excludeComponentMask = default;
			m_count = default;
		} // 0x0000000182434870-0x0000000182434950
	
		// Methods
		public Enumerator GetEnumerator() => default; // 0x00000001826E5100-0x00000001826E5150
		IEnumerator<GroupType> IEnumerable<GroupType>.GetEnumerator() => default; // 0x0000000189DF4B58-0x0000000189DF4BD0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189DF4BD0-0x0000000189DF4C48
	}
}

namespace UnityEngine.HyperGryph.Streaming
{
	public struct StreamingAssetData // TypeDefIndex: 57503
	{
		// Fields
		public long assetHashV2; // 0x00
		public AssetType assetType; // 0x08
	
		// Methods
		public bool Equals(StreamingAssetData other) => default; // 0x000000018775423C-0x0000000187754254
		public override bool Equals(object obj) => default; // 0x0000000189DF8C58-0x0000000189DF8CD0
		public override int GetHashCode() => default; // 0x0000000183D85860-0x0000000183D85870
	}

	public struct PropertySerializeId // TypeDefIndex: 57504
	{
		// Fields
		public uint componentIndex; // 0x00
		public uint propertyId; // 0x04
		public uint subPropertyIndex; // 0x08
	
		// Constructors
		public PropertySerializeId(StreamingComponentType componentType, uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x01FD9E9E */) {
			componentIndex = default;
			this.propertyId = default;
			this.subPropertyIndex = default;
		} // 0x0000000183427780-0x00000001834277C0
		public PropertySerializeId(uint componentIndex, uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x01FD9E9F */) {
			this.componentIndex = default;
			this.propertyId = default;
			this.subPropertyIndex = default;
		} // 0x0000000183D4E5D0-0x0000000183D4E5E0
		public PropertySerializeId(uint propertyId, uint subPropertyIndex = 0 /* Metadata: 0x01FD9EA0 */) {
			componentIndex = default;
			this.propertyId = default;
			this.subPropertyIndex = default;
		} // 0x0000000183D87C20-0x0000000183D87C30
	
		// Methods
		public static implicit operator PropertySerializeId(uint propertyId) => default; // 0x0000000183D87C60-0x0000000183D87C90
		public static uint GetComponentIndexFromType(StreamingComponentType componentType) => default; // 0x00000001834277C0-0x0000000183427800
		public override int GetHashCode() => default; // 0x0000000189DF8C50-0x0000000189DF8C58
		public uint EncodeSerializeIdentifier() => default; // 0x0000000189DF8BEC-0x0000000189DF8C50
		public static PropertySerializeId operator +(PropertySerializeId a, uint subIndex) => default; // 0x0000000183D87C30-0x0000000183D87C60
		public static PropertySerializeId operator +(PropertySerializeId a, int subIndex) => default; // 0x0000000183290C50-0x0000000183290CA0
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/FlatBufferConvertContext.bindings.h")]
	public struct FlatBufferConvertContextV2 // TypeDefIndex: 57505
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Properties
		public uint sceneScopeId { get => default; } // 0x0000000184275D3C-0x0000000184275D44 
	
		// Methods
		public bool TryEnqueueAssetForAsyncLoad(PropertySerializeId propertySerializeId) => default; // 0x0000000184274988-0x000000018427499C
		public void AddExternalAssetForAsyncLoad(long assetHash, AssetType assetType, AssetHandleIndex assetHandleIndex) {} // 0x0000000184275F8C-0x0000000184275FB0
		private UnityEngine.Object ConvertAssetFromImpl(PropertySerializeId propertySerializeId) => default; // 0x00000001842757FC-0x0000000184275810
		private IntPtr ConvertPropertyPtrFromImpl(PropertySerializeId propertySerializeId) => default; // 0x0000000184275108-0x000000018427511C
		private void ConvertPropertyDataFromBytesImpl(PropertySerializeId propertySerializeId, out IntPtr data, out int size) {
			data = default;
			size = default;
		} // 0x0000000184275D24-0x0000000184275D3C
		public string ConvertStringFrom(PropertySerializeId propertySerializeId) => default; // 0x0000000184275F78-0x0000000184275F8C
		public bool TryConvertAssetFrom<T>(PropertySerializeId propertySerializeId, out ref T asset)
			where T : UnityEngine.Object {
			asset = default;
			return default;
		}
		public T ConvertPropertyFrom<T>(PropertySerializeId propertySerializeId)
			where T : struct => default;
		public T ConvertPropertyFromBytes<T>(PropertySerializeId propertySerializeId)
			where T : struct => default;
		public NativeArray<byte> ConvertPropertyFromBytes(PropertySerializeId propertySerializeId) => default; // 0x0000000189DF5138-0x0000000189DF51F8
		private static uint get_sceneScopeId_Injected(ref FlatBufferConvertContextV2 _unity_self) => default; // 0x000000018367E7E0-0x000000018367E820
		private static bool TryEnqueueAssetForAsyncLoad_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId) => default; // 0x00000001833BEDD0-0x00000001833BEE20
		private static void AddExternalAssetForAsyncLoad_Injected(ref FlatBufferConvertContextV2 _unity_self, long assetHash, AssetType assetType, ref AssetHandleIndex assetHandleIndex) {} // 0x0000000183650790-0x0000000183650800
		private static UnityEngine.Object ConvertAssetFromImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId) => default; // 0x0000000183126BE0-0x0000000183126C30
		private static IntPtr ConvertPropertyPtrFromImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId) => default; // 0x00000001830B9170-0x00000001830B91C0
		private static void ConvertPropertyDataFromBytesImpl_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId, out IntPtr data, out int size) {
			data = default;
			size = default;
		} // 0x0000000183569850-0x00000001835698C0
		private static string ConvertStringFrom_Injected(ref FlatBufferConvertContextV2 _unity_self, ref PropertySerializeId propertySerializeId) => default; // 0x0000000183D00990-0x0000000183D009E0
	}

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingGameplayManager.binding.h")]
	public struct StreamingGameplayManager // TypeDefIndex: 57506
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Methods
		public void Create(StreamingSceneParameter parameter) {} // 0x0000000189DF8D64-0x0000000189DF8D78
		public void Destroy() {} // 0x0000000189DF8DAC-0x0000000189DF8DB4
		public uint AllocateRuntimeChunk(string initBasePath, string streamingBasePath) => default; // 0x000000018427147C-0x0000000184271484
		public uint CreateEntityGroupAndLoad(uint chunkId, int blobIndex) => default; // 0x0000000184271484-0x000000018427148C
		public void LoadGroup(uint groupHandle) {} // 0x0000000189DF8E78-0x0000000189DF8E80
		public bool IsGroupReady(uint groupId) => default; // 0x0000000189DF8E30-0x0000000189DF8E38
		public uint CreateGroupAndLoadWaitBeforeShow(uint chunkId, int blobIndex) => default; // 0x0000000189DF8D5C-0x0000000189DF8D64
		public void StopGroupWait(uint groupId) {} // 0x0000000189DF8EC0-0x0000000189DF8EC8
		public void UnloadGroup(uint groupId, bool imm) {} // 0x0000000184275A40-0x0000000184275A48
		public void DestroyGroup(uint groupId) {} // 0x0000000184275A48-0x0000000184275A50
		public bool IsGroupLoaded(uint groupId) => default; // 0x000000018427148C-0x0000000184271494
		public bool IsGroupUnloaded(uint groupId) => default; // 0x0000000184275A38-0x0000000184275A40
		public void Tick(int budget) {} // 0x00000001842726E0-0x00000001842726E8
		public void TickResource() {} // 0x000000018426FCCC-0x000000018426FCD4
		public void Clear() {} // 0x0000000189DF8D04-0x0000000189DF8D0C
		public bool IsIdle() => default; // 0x00000001842726D8-0x00000001842726E0
		public bool IsValid() => default; // 0x0000000184274818-0x0000000184274824
		public void SetNeedLodTransition(bool needTransition) {} // 0x0000000184274E70-0x0000000184274E78
		public bool GetNeedLodTransition() => default; // 0x0000000189DF8DE8-0x0000000189DF8DF0
		private static void Create_Injected(ref StreamingGameplayManager _unity_self, ref StreamingSceneParameter parameter) {} // 0x00000001832CEFC0-0x00000001832CF010
		private static void Destroy_Injected(ref StreamingGameplayManager _unity_self) {} // 0x0000000189DF8D78-0x0000000189DF8DAC
		private static uint AllocateRuntimeChunk_Injected(ref StreamingGameplayManager _unity_self, string initBasePath, string streamingBasePath) => default; // 0x000000018367AAA0-0x000000018367AB00
		private static uint CreateEntityGroupAndLoad_Injected(ref StreamingGameplayManager _unity_self, uint chunkId, int blobIndex) => default; // 0x00000001826F1A60-0x00000001826F1AC0
		private static void LoadGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupHandle) {} // 0x0000000189DF8E38-0x0000000189DF8E78
		private static bool IsGroupReady_Injected(ref StreamingGameplayManager _unity_self, uint groupId) => default; // 0x0000000189DF8DF0-0x0000000189DF8E30
		private static uint CreateGroupAndLoadWaitBeforeShow_Injected(ref StreamingGameplayManager _unity_self, uint chunkId, int blobIndex) => default; // 0x0000000189DF8D0C-0x0000000189DF8D5C
		private static void StopGroupWait_Injected(ref StreamingGameplayManager _unity_self, uint groupId) {} // 0x0000000189DF8E80-0x0000000189DF8EC0
		private static void UnloadGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupId, bool imm) {} // 0x0000000183168A50-0x0000000183168AB0
		private static void DestroyGroup_Injected(ref StreamingGameplayManager _unity_self, uint groupId) {} // 0x00000001831689B0-0x0000000183168A00
		private static bool IsGroupLoaded_Injected(ref StreamingGameplayManager _unity_self, uint groupId) => default; // 0x00000001826F1AC0-0x00000001826F1B10
		private static bool IsGroupUnloaded_Injected(ref StreamingGameplayManager _unity_self, uint groupId) => default; // 0x0000000183168A00-0x0000000183168A50
		private static void Tick_Injected(ref StreamingGameplayManager _unity_self, int budget) {} // 0x0000000183274A30-0x0000000183274A80
		private static void TickResource_Injected(ref StreamingGameplayManager _unity_self) {} // 0x0000000182D10A00-0x0000000182D10A40
		private static void Clear_Injected(ref StreamingGameplayManager _unity_self) {} // 0x0000000189DF8CD0-0x0000000189DF8D04
		private static bool IsIdle_Injected(ref StreamingGameplayManager _unity_self) => default; // 0x00000001834AF8D0-0x00000001834AF910
		private static void SetNeedLodTransition_Injected(ref StreamingGameplayManager _unity_self, bool needTransition) {} // 0x000000018309BA60-0x000000018309BAB0
		private static bool GetNeedLodTransition_Injected(ref StreamingGameplayManager _unity_self) => default; // 0x0000000189DF8DB4-0x0000000189DF8DE8
	}

	[Flags]
	public enum StreamingComponentType : ulong // TypeDefIndex: 57507
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

	public enum StreamingLayer : byte // TypeDefIndex: 57508
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

	public enum EntityTransition : byte // TypeDefIndex: 57509
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

	public enum StreamingMode : byte // TypeDefIndex: 57510
	{
		Stream = 0,
		Pause = 1,
		Load = 2,
		Unload = 3
	}

	[Flags]
	public enum StreamingStatus : byte // TypeDefIndex: 57511
	{
		Idle = 0,
		Loading = 1,
		Unloading = 2,
		Empty = 4
	}

	public struct StreamingSceneParameter // TypeDefIndex: 57512
	{
		// Fields
		public string mapName; // 0x00
		public GameObject streamingRootObject; // 0x08
		public string streamingDataPathRoot; // 0x10
	}

	public enum GridStatus : byte // TypeDefIndex: 57513
	{
		Loading = 0,
		Loaded = 1,
		Unloading = 2,
		Unloaded = 3,
		NotExist = 4
	}

	public struct GridIdentifier // TypeDefIndex: 57514
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
		} // 0x0000000183D87C00-0x0000000183D87C20
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018258F380-0x000000018258F3A0
	}

	public struct StreamingSourceData // TypeDefIndex: 57517
	{
		// Fields
		public Vector2 streamingPos; // 0x00
		public float chunkLoadRadius; // 0x08
		public unsafe fixed /* 0x00000000-0x00000000 */ float layerLoadRadius[0]; // 0x0C
		public unsafe fixed /* 0x00000000-0x00000000 */ byte layerEnabledInDefaultArea[0]; // 0x34
		public static readonly StreamingSourceData kInvalid; // 0x00
	
		// Constructors
		static StreamingSourceData() {
			kInvalid = default;
		} // 0x0000000182E7A070-0x0000000182E7A180
	
		// Methods
		public float GetGridLoadRadius(int layerIndex) => default; // 0x0000000183D87C90-0x0000000183D87CA0
	}

	public enum ECSEntityType : byte // TypeDefIndex: 57518
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

	public enum ProxyEntityType : byte // TypeDefIndex: 57519
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

	[IsReadOnly]
	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingScene.bindings.h")]
	public struct StreamingSceneV2 // TypeDefIndex: 57520
	{
		// Fields
		public readonly IntPtr ptr; // 0x00
	
		// Properties
		public StreamingMode streamingMode { get => default; set {} } // 0x0000000189DF9020-0x0000000189DF9028 0x0000000189DF9044-0x0000000189DF904C
		public StreamingSourceData primaryStreamingSourceData { get => default; set {} } // 0x000000018279F230-0x000000018279F2A0 0x0000000189DF9030-0x0000000189DF9044
		public StreamingSourceData secondaryStreamingSourceData { set {} } // 0x0000000184276D68-0x0000000184276D7C
		public float streamingProgress { get => default; } // 0x0000000189DF9028-0x0000000189DF9030 
	
		// Methods
		public void Create(StreamingSceneParameter parameter) {} // 0x00000001842746A4-0x00000001842746B8
		public void Destroy() {} // 0x0000000189DF8EFC-0x0000000189DF8F04
		public void UnloadImmediately() {} // 0x0000000189DF8FE4-0x0000000189DF8FEC
		public StreamingStatus QueryStreamingStatus() => default; // 0x0000000189DF8FA8-0x0000000189DF8FB0
		public void SetArea(int areaId, bool enabled) {} // 0x0000000184276AD0-0x0000000184276AD8
		public void SetSceneState(int sceneStateId, bool enabled) {} // 0x0000000184276388-0x0000000184276390
		private GridStatus QueryGridLoadStatusImpl(StreamingLayer layer, int sceneStateId, int areaId, Vector2 queryPos) => default; // 0x00000001842718B4-0x00000001842718D8
		private GridStatus QueryGridLoadStatusByGridIdentifierImpl(GridIdentifier gridIdentifier) => default; // 0x0000000189DF8F48-0x0000000189DF8F5C
		public bool IsValid() => default; // 0x00000001842718AC-0x00000001842718B4
		public GridStatus QueryGridLoadStatus(StreamingLayer layer, Vector2 queryPos) => default; // 0x0000000189DF8F84-0x0000000189DF8FA8
		public GridStatus QueryGridLoadStatus(GridIdentifier gridIdentifier) => default; // 0x0000000189DF8F5C-0x0000000189DF8F84
		private static void Create_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSceneParameter parameter) {} // 0x0000000182F13860-0x0000000182F138B0
		private static void Destroy_Injected(ref StreamingSceneV2 _unity_self) {} // 0x0000000189DF8EC8-0x0000000189DF8EFC
		private static void UnloadImmediately_Injected(ref StreamingSceneV2 _unity_self) {} // 0x0000000189DF8FB0-0x0000000189DF8FE4
		private static StreamingStatus QueryStreamingStatus_Injected(ref StreamingSceneV2 _unity_self) => default; // 0x00000001833CBE40-0x00000001833CBE80
		private static void SetArea_Injected(ref StreamingSceneV2 _unity_self, int areaId, bool enabled) {} // 0x0000000183CF4950-0x0000000183CF49B0
		private static void SetSceneState_Injected(ref StreamingSceneV2 _unity_self, int sceneStateId, bool enabled) {} // 0x00000001839CF7D0-0x00000001839CF830
		private static GridStatus QueryGridLoadStatusImpl_Injected(ref StreamingSceneV2 _unity_self, StreamingLayer layer, int sceneStateId, int areaId, ref Vector2 queryPos) => default; // 0x0000000182F93AC0-0x0000000182F93B30
		private static GridStatus QueryGridLoadStatusByGridIdentifierImpl_Injected(ref StreamingSceneV2 _unity_self, ref GridIdentifier gridIdentifier) => default; // 0x0000000189DF8F04-0x0000000189DF8F48
		private static StreamingMode get_streamingMode_Injected(ref StreamingSceneV2 _unity_self) => default; // 0x0000000189DF8FEC-0x0000000189DF9020
		private static void set_streamingMode_Injected(ref StreamingSceneV2 _unity_self, StreamingMode value) {} // 0x0000000183CDDAB0-0x0000000183CDDB00
		private static void get_primaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, out StreamingSourceData ret) {
			ret = default;
		} // 0x000000018279F2A0-0x000000018279F2F0
		private static void set_primaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSourceData value) {} // 0x000000018322B190-0x000000018322B1E0
		private static void set_secondaryStreamingSourceData_Injected(ref StreamingSceneV2 _unity_self, ref StreamingSourceData value) {} // 0x0000000183B10680-0x0000000183B106D0
		private static float get_streamingProgress_Injected(ref StreamingSceneV2 _unity_self) => default; // 0x00000001833CBF30-0x00000001833CBF70
		private static bool IsValid_Injected(ref StreamingSceneV2 _unity_self) => default; // 0x000000018303D4C0-0x000000018303D500
	}

	public delegate void ECSEntityHasRequiredComponentsDelegate(); // TypeDefIndex: 57521; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void ECSEntityConvertToDelegate(); // TypeDefIndex: 57522; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void ProxyEntityHasRequiredComponentsDelegate(); // TypeDefIndex: 57523; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void ProxyEntityConvertToDelegate(); // TypeDefIndex: 57524; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void MonoIsConvertorOfComponentDelegate(); // TypeDefIndex: 57525; 0x00000001842BE03C-0x00000001842BE04C

	public delegate void MonoComponentConvertToDelegate(); // TypeDefIndex: 57526; 0x00000001842BE03C-0x00000001842BE04C

	public delegate bool ECSEntityConvertFromDelegate(Entity entity, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 57527; 0x0000000183483950-0x00000001834839A0

	public delegate bool ProxyEntityConvertFromDelegate(ref IntPtr proxyPtr, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 57528; 0x000000018356B4B0-0x000000018356B500

	public delegate bool MonoComponentConvertFromDelegate(Component component, FlatBufferConvertContextV2 cContext, EntityTransition transition); // TypeDefIndex: 57529; 0x00000001836394E0-0x0000000183639530

	public delegate Component MonoComponentAddComponentToDelegate(GameObject gameObject); // TypeDefIndex: 57530; 0x00000001836D9FC0-0x00000001836DA0E0

	public delegate Component MonoComponentGetComponentFromDelegate(GameObject gameObject, int multiComponentIndex); // TypeDefIndex: 57531; 0x00000001838CB680-0x00000001838CB7A0

	[NativeHeader("Modules/HGGraphics/Public/Streaming/HGStreamingSceneManager.h")]
	[StaticAccessor("GetHGGlobalGameManager().GetHGStreamingSceneManager()", StaticAccessorType.Dot)]
	public static class HGStreamingSceneManager // TypeDefIndex: 57532
	{
		// Properties
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static int streamingVersion { [NativeName("GetStreamingSerializeCodeVersion")] get; } // 0x0000000182F45C70-0x0000000182F45CB0 
		[StaticAccessor("HyperGryph", StaticAccessorType.DoubleColon)]
		public static int streamingChunkSize { [NativeName("GetStreamingChunkSize")] get; } // 0x0000000183807320-0x0000000183807360 
		private static IntPtr streamingScenesManaged { get; } // 0x0000000189DF7FA4-0x0000000189DF7FD0 
		private static int streamingSceneCount { get; } // 0x0000000189DF7F78-0x0000000189DF7FA4 
	
		// Methods
		public static void ResetLastProcessStreamingPos() {} // 0x0000000183D1F3F0-0x0000000183D1F430
		public static void BindECSEntityConvertFuncFromScript(ECSEntityType entityType, ECSEntityHasRequiredComponentsDelegate hasRequiredComponentsDelegate, ECSEntityConvertToDelegate convertToDelegate, ECSEntityConvertFromDelegate convertFromFunc) {} // 0x00000001835923E0-0x0000000183592450
		public static void ResetECSEntityConvertFuncFromScript(ECSEntityType entityType) {} // 0x0000000189DF7EA8-0x0000000189DF7EDC
		public static bool IsECSEntityConvertFuncValid(ECSEntityType entityType) => default; // 0x00000001835923A0-0x00000001835923E0
		public static void BindProxyEntityConvertFuncFromScript(ProxyEntityType entityType, ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, ProxyEntityConvertToDelegate convertToFunc, ProxyEntityConvertFromDelegate convertFromFunc) {} // 0x0000000183592290-0x0000000183592300
		public static void ResetProxyEntityConvertFuncFromScript(ProxyEntityType entityType) {} // 0x0000000189DF7F10-0x0000000189DF7F44
		public static bool IsProxyEntityConvertFuncValid(ProxyEntityType entityType) => default; // 0x0000000183592250-0x0000000183592290
		public static void BindMonoComponentConvertFuncFromScript(StreamingComponentType componentType, MonoIsConvertorOfComponentDelegate isConvertorOfFunc, MonoComponentConvertToDelegate convertToFunc, MonoComponentConvertFromDelegate convertFromFunc, MonoComponentAddComponentToDelegate addComponentToFunc, MonoComponentGetComponentFromDelegate getComponentFromFunc) {} // 0x0000000183592140-0x00000001835921B0
		public static void ResetMonoComponentConvertFuncFromScript(StreamingComponentType componentType) {} // 0x0000000189DF7EDC-0x0000000189DF7F10
		public static bool IsMonoComponentConvertFuncValid(StreamingComponentType componentType) => default; // 0x0000000183592100-0x0000000183592140
		public static void BindProxyEntityConvertToFuncFromScript(ProxyEntityType entityType, ProxyEntityHasRequiredComponentsDelegate hasRequiredComponentsFunc, ProxyEntityConvertToDelegate convertToFunc) {} // 0x0000000183592450-0x00000001835924B0
		public static void ResetProxyEntityConvertToFuncFromScript(ProxyEntityType entityType) {} // 0x0000000189DF7F44-0x0000000189DF7F78
		public static NativeArray<StreamingSceneV2> GetStreamingScenesArray() => default; // 0x0000000189DF7E2C-0x0000000189DF7EA8
	}

	public struct StreamingLayerConfig // TypeDefIndex: 57533
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
	public static class HGStreamingSettings // TypeDefIndex: 57534
	{
		// Properties
		public static float loadDirtyDistance { get; set; } // 0x000000018279F830-0x000000018279F880
		public static float unloadDirtyDistance { get; set; } // 0x000000018279F7E0-0x000000018279F830
		public static float loadElapsedMsPerFrame { get; set; } // 0x000000018279F790-0x000000018279F7E0
		public static float unloadElapsedMsPerFrame { get; set; } // 0x000000018279F740-0x000000018279F790
		public static bool sequentialUnloadBeforeLoad { get; set; } // 0x0000000189DF7FD0-0x0000000189DF8004
	
		// Methods
		public static void SetLayerConfig(StreamingLayer layer, StreamingLayerConfig config) {} // 0x00000001842766B4-0x00000001842766C8
		private static void SetLayerConfig_Injected(StreamingLayer layer, ref StreamingLayerConfig config) {} // 0x00000001835924B0-0x0000000183592500
	}
}
